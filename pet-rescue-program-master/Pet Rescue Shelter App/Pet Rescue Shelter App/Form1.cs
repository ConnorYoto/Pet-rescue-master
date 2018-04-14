using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rfid;

namespace Pet_Rescue_Shelter_App
{
    public partial class Happy_Hounds : Form
    {
        //RFID CODE
        //Initialise Transponder Type to Hitag S
        int TTYP = GIS_LF_API.TTYP_HITAG_S;
        //Make String From Array
        static string MakeStringFromArray(sbyte[] Arr, int StringNumber)
        {
            string stringline;
            stringline = "";

            int i = 0;
            for (int aktStringNumber = 0; aktStringNumber <= StringNumber; aktStringNumber++)
            {
                stringline = "";
                for (; (i < Arr.Length); i++)
                {
                    if (Arr[i] == 0)
                    {
                        break;
                    }
                    stringline = stringline + (char)Arr[i];
                }
                i++;
                if (stringline.Length == 0)
                {
                    break;
                }
            }
            return stringline;
        }
        //Make Array From String
        static sbyte[] MakeArrayFromString(string Name)
        {
            sbyte[] arr = new sbyte[Name.Length];
            for (int i = 0; i < Name.Length; i++)
            {
                arr[i] = (sbyte)Name[i];
            }
            return arr;
        }
        //Make String from a Byte Array
        static string MakeStringFromByteArray(Byte[] Arr)
        {
            string stringline;
            stringline = "";

            int i = 0;
            for (; (i < Arr.Length); i++)
            {
                if (Arr[i] == 0)
                {
                    break;
                }
                stringline = stringline + (char)Arr[i];
            }
            i++;
            return stringline;
        }
        //Make Byte Array from String
        static byte[] MakeByteArrayFromString(string Name)
        {
            byte[] arr = new byte[Name.Length];
            for (int i = 0; i < Name.Length; i++)
            {
                arr[i] = (byte)Name[i];
            }
            return arr;
        }
        //Copying Array To
        static void CopyArrayTo(SByte[] Src, int SrcOffset, SByte[] Dest, int DestOffset, int Length)
        {
            while (Length > 0)
            {
                Dest[DestOffset++] = Src[SrcOffset++];
                Length--;
            }
        }
        //cNibble
        static char cNibble(byte bValue)
        {
            if (bValue > 9)
                return (char)(bValue - 10 + 'A');
            else
                return (char)(bValue + '0');
        }
        //HexNibble
        static byte HexNibble(char Nibble)
        {
            if ((Nibble >= '0') && (Nibble <= '9'))
                return (byte)(Nibble - '0');
            else if ((Nibble >= 'A') && (Nibble <= 'F'))
                return (byte)(Nibble - 'A' + 10);
            else if ((Nibble >= 'a') && (Nibble <= 'f'))
                return (byte)(Nibble - 'a' + 10);
            else
                return 0;
        }
        //HexByte
        static byte HexByte(char HiNibble, char LoNibble)
        {
            return (byte)(HexNibble(LoNibble) + HexNibble(HiNibble) * 16);
        }
        //Make HexString
        static string MakeHexString(byte[] Arr)
        {
            string stringline;
            stringline = "";
            for (int i = Arr.Length - 1; (i >= 0); --i)
            {
                byte lChar = (byte)(Arr[i] & 0x0F);
                byte hChar = (byte)((Arr[i] >> 4) & 0x0F);

                stringline += cNibble(hChar);
                stringline += cNibble(lChar);
            }
            return stringline;
        }
        //From HexString
        static byte[] FromHexString(string HexString, int Length)
        {
            while (HexString.Length < Length * 2)
                HexString = "0" + HexString;
            byte[] arr = new byte[HexString.Length / 2];
            for (int i = 0, j = Length - 1; (j >= 0) && (i < HexString.Length / 2); i++, j--)
                arr[j] = HexByte(HexString[i * 2], HexString[i * 2 + 1]);
            return arr;
        }
        //Create PortHandle Variable
        int PortHandle;

        public Happy_Hounds()
        {
            InitializeComponent();
            //Initialise Variables
            int MaxLength = 255;
            int ListLength = 0;
            int DeviceListLength;
            SByte[] NameList = new SByte[1000];
            SByte[] DeviceList = new SByte[MaxLength];
            //Grab USB Device Names
            DeviceListLength = GIS_LF_API.TSLF_GetUSBDeviceNames(DeviceList, MaxLength) - 1;
            CopyArrayTo(DeviceList, 0, NameList, ListLength, DeviceListLength);
            ListLength += DeviceListLength;
            ListLength++;

            if (ListLength > 1)
            {
                string DeviceName;
                // Use first Device in List
                DeviceName = MakeStringFromArray(NameList, 0);

                PortHandle = GIS_LF_API.TSLF_Open(MakeArrayFromString(DeviceName), 19200, 0, 500);
                if (GIS_LF_API.TSLF_IsProgrammer(PortHandle) != 1)
                {
                    MessageBox.Show("Device is not a Programmer");
                }
            }
            else
            {
                PortHandle = 0;
            }

            if (PortHandle <= 0)
            {
                MessageBox.Show("Device could not be opened");
            }
        }

        private void btn_read_lost_Click(object sender, EventArgs e)
        {
            if (PortHandle > 0)
            {
                Byte[] Buffer = new Byte[5];

                if (GIS_LF_API.TSLF_Read_Unique(PortHandle, Buffer, 5) == 5)
                {
                    tb_tag_id_lost.Text = MakeHexString(Buffer);
                }
                else
                {
                    MessageBox.Show("Read Error");
                }
            }
            else
            {
                MessageBox.Show("No Device attached");
            }
        }
    }
}

