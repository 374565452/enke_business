using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DTUGateWay
{
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

        #region 连接服务器
        public void connect(string ip, int port)
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress address = IPAddress.Parse(ip);
                IPEndPoint endPoint = new IPEndPoint(address, port);
                //socket.BeginConnect(endPoint, new AsyncCallback(connectCallBakc), socket);
                socket.Connect(endPoint);

                receive(socket);
              
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
        private void send(byte[] buffer, int offset, int count)
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


    }
}
