using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LAB03
{
    enum Command
    {
        Login,
        Logout,
        Message,
        List,
        Private,
        InitPrivate,
        MessageSecret,
        File,
        Null
    }
    internal class Data
    {
        public string strName { get; set; }
        public string strMessage { get; set; }
        public Command cmdCommand { get; set; }

        public Data()
        {
            this.cmdCommand = Command.Null;
            this.strMessage = null;
            this.strName = null;
        }


        //Structure of data in this program: Command | Len of Name | Len of Message | Name | Message 
        public byte[] Serialize()
        {
            List<byte> result = new List<byte>();

            //Serialize Command
            result.AddRange(BitConverter.GetBytes((int)cmdCommand));

            //Serialize Len of name
            if (strName != null)
                result.AddRange(BitConverter.GetBytes(strName.Length));
            else
                result.AddRange(BitConverter.GetBytes(0));

            //Serialize Len of message
            if (strMessage != null)
                result.AddRange(BitConverter.GetBytes(strMessage.Length));
            else
                result.AddRange(BitConverter.GetBytes(0));

            //Serialize Name
            if (strName != null)
                result.AddRange(Encoding.UTF8.GetBytes(strName));

            //Serialize Message
            if (strMessage != null)
                result.AddRange(Encoding.UTF8.GetBytes(strMessage));

            return result.ToArray();
        }

        //Deserialize
        public Data(byte[] data)
        {
            //Deserialize Command
            this.cmdCommand = (Command)BitConverter.ToInt32(data, 0);

            //Deserialize  Len of Name
            int nameLen = BitConverter.ToInt32(data, 4);

            //Deserialize  Len of Message
            int msgLen = BitConverter.ToInt32(data, 8);

            //Deserialize  Name
            if (nameLen > 0)
                this.strName = Encoding.UTF8.GetString(data, 12, nameLen);
            else
                this.strName = null;

            //Deserialize  Message
            if (msgLen > 0)
                this.strMessage = Encoding.UTF8.GetString(data, 12 + nameLen, msgLen);
            else
                this.strMessage = null;
        }
    }
}
