using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DTUGateWay
{

    public class ByteValueEventArgs : EventArgs
    {
        public int Pos { get; set; }

        public int Length { get; set; }

        public byte[] ArrayData { get; set; }
    }

    public delegate void ByteValueEventHandler(object sender,ByteValueEventArgs args);

    public delegate void ConnectedEventHandler(object sender, EventArgs args);

    public class SocketState
    {
        private Socket socket;
        public Socket Socket
        {
            get
            {
                return socket;
            }
            set
            {
                socket = value;
            }
        }

        private byte[] receiveBuffer;

        public SocketState(int receiveSize)
        {
            receiveBuffer = new byte[receiveSize];
        }

        public byte[] ReceiveBuffer
        {
            get
            {
                return receiveBuffer;
            }
        }
    }
    public class DownloadClient
    {
        public Socket socket;

        public event ConnectedEventHandler connectEventHandler;

        public event ByteValueEventHandler byteValueEventHandler;

        #region 连接服务器
        public void connect(string ip, int port)
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress address = IPAddress.Parse(ip);
                IPEndPoint endPoint = new IPEndPoint(address, port);
                socket.BeginConnect(endPoint, new AsyncCallback(connectCallBakc), socket);
                //socket.Connect(endPoint);

                //receive(socket);
              
                //connectDone.WaitOne();
            }
            catch (Exception e)
            {
               

            }
        }
        #endregion

        #region 连接回调函数
        private void connectCallBakc(IAsyncResult ar)
        {
            try
            {
                Socket client = (Socket)ar.AsyncState;
                //Console.WriteLine(client.LocalEndPoint.ToString());
                client.EndConnect(ar);
                //string info = String.Format("Socket connected to {0} \n", client.RemoteEndPoint.ToString());
                //this.showInfo(info);
                //connectDone.Set();
                if (connectEventHandler != null)
                {
                    connectEventHandler(this, new EventArgs());
                }
                receive(client);
                //connectDone.Set();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        #endregion

        #region 接收数据
        public void receive(Socket client)
        {
            try
            {
                SocketState state = new SocketState(1024 * 4);
                state.Socket = client;
                client.BeginReceive(state.ReceiveBuffer, 0, state.ReceiveBuffer.Length, 0, new AsyncCallback(receiveCallBack), state);
            }
            catch (Exception e)
            {
              
            }
        }
        #endregion

        #region 接收回调函数
        private void receiveCallBack(IAsyncResult ar)
        {
            try
            {
                SocketState state = (SocketState)ar.AsyncState;
                Socket client = state.Socket;
                int byteReceive = client.EndReceive(ar);
                if (byteReceive > 0)
                {
                    if (byteReceive >= CommandCommon.CMD_MIN_LENGTH)
                    {
                        byte[] newByte = new byte[byteReceive];
                        Array.Copy(state.ReceiveBuffer,newByte, byteReceive);
                        if (byteValueEventHandler != null)
                        {
                            ByteValueEventArgs args = new ByteValueEventArgs();
                            args.Pos = 0;
                            args.Length = byteReceive;
                            args.ArrayData = newByte;
                            byteValueEventHandler(this, args);
                        }
                    }
                   // receiveBufferManager.writeBuffer(state.ReceiveBuffer, 0, byteReceive);
                    //receiveProcess(receiveBufferManager);
                    client.BeginReceive(state.ReceiveBuffer, 0, state.ReceiveBuffer.Length, 0, new AsyncCallback(receiveCallBack), state);
                }

            }
            catch (Exception e)
            {
               
            }
        }
        #endregion

        #region 发送数据
        public void send(byte[] buffer, int offset, int count)
        {
            socket.BeginSend(buffer, 0, count, 0, new AsyncCallback(sendCallBack), socket);
        }
        #endregion

        #region 发送回调函数
        private void sendCallBack(IAsyncResult ar)
        {
            try
            {
                Socket client = (Socket)ar.AsyncState;
                int bytes = client.EndSend(ar);
               // sendCallBack(bytes);
               // doSendComplete();
                //dynamicBufferManager.clearAll();
                // string info = String.Format("sent {0} bytes to server \n", bytes);
                //this.receiveTextBox.AppendText(info + "\n");
                //this.showInfo(info);

            }
            catch (Exception e)
            {
             
            }
        }
        #endregion

        public void close()
        {
            if (socket == null)
                return;

            if (!socket.Connected)
                return;

            try
            {
                socket.Shutdown(SocketShutdown.Both);
            }
            catch
            {
            }

            try
            {
                socket.Close();
            }
            catch
            {
            }  
        }
    }
}
