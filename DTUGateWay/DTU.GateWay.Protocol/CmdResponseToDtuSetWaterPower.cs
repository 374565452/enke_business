using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTU.GateWay.Protocol
{
    public class CmdResponseToDtuSetWaterPower :BaseMessage
    {
         public CmdResponseToDtuSetWaterPower()
        {
            BeginChar = BaseProtocol.BeginChar;
            EndChar = BaseProtocol.EndChar;

            //AFN = 0x23;
            AFN = (byte)BaseProtocol.AFN.ToDtuSetWaterPower;
            //ControlField = 0xB3;
            ControlField = (byte)BaseProtocol.ControlField.FromDtu;
        }

         public CmdResponseToDtuSetWaterPower(BaseMessage bm)
        {
            BeginChar = BaseProtocol.BeginChar;
            EndChar = BaseProtocol.EndChar;

            //AFN = 0x23;
            AFN = (byte)BaseProtocol.AFN.ToDtuSetWaterPower;
            //ControlField = 0xB3;
            ControlField = (byte)BaseProtocol.ControlField.FromDtu;

            this.RawDataStr = bm.RawDataStr;
            this.RawDataChar = bm.RawDataChar;
            this.Length = bm.Length;
            this.AddressField = bm.AddressField;
            this.StationType = bm.StationType;
            this.StationCode = bm.StationCode;
            this.UserData = bm.UserData;
            this.UserDataBytes = bm.UserDataBytes;
            this.CC = bm.CC;
            this.IsPW = bm.IsPW;
            this.PW = bm.PW;
            this.IsTP = bm.IsTP;
            this.TP = bm.TP;
        }

         /// <summary>
         /// 设置累计用水量
         /// </summary>
         public decimal WaterUsed
         {
             set;
             get;
         }

         /// <summary>
         /// 设置累计用电量
         /// </summary>
         /// <returns></returns>
         public decimal PowerUsed
         {
             get;
             set;
         }

        public override byte[] WriteMsg()
        {
            string data = ((int)(WaterUsed * 10)).ToString().PadLeft(8, '0')
                   + ((int)(PowerUsed * 10)).ToString().PadLeft(8, '0');

            DateTime dateNow = DateTime.Now;
            IsPW = true;
            PW = "0000";
            IsTP = true;
            TP = dateNow.ToString("ssmmHHdd") + "00";

            UserData = data;

            UserDataBytes = HexStringUtility.HexStringToByteArray(UserData);

            return WriteMsg2();
        }

        public override string ReadMsg()
        {
            WaterUsed = 0;

            string data = UserData;

            try
            {
                WaterUsed = decimal.Parse(data.Substring(0, 8)) / 10m;
                PowerUsed = decimal.Parse(data.Substring(9, 17)) / 10m;
            }
            catch(Exception ex)
            {
                if (ShowLog)
                    logHelper.Error(ex.Message + Environment.NewLine + "获取累计用水用电量出错" + " " + RawDataStr);
                return "获取累计用水用电量出错";
            }

            return "";
            
        }
    }
}
