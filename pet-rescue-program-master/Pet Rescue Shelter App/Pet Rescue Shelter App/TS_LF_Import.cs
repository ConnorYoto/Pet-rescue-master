using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace rfid
{
    public unsafe class GIS_LF_API
    {

        public const int TSLF_NO_ERROR = 0;
        public const int TSLF_PORT_OEFFNEN = 1;
        public const int TSLF_TIMEOUT_UNGUELTIG = 5;
        public const int TSLF_PORTHANDLE_UNGUELTIG = 6;
        public const int TSLF_TIMEOUT = 7;
        public const int TSLF_BUFFER_ZU_KLEIN = 8;
        public const int TSLF_BUFFERGROESSE_FALSCH = 9;
        public const int TSLF_FALSCHER_TRANSPONDERTYP = 10;
        public const int TSLF_KEINE_SENDEDATEN = 11;
        public const int TSLF_BLOCKNUMMER_UNGUELTIG = 12;
        public const int TSLF_LOCK_UNGUELTIG = 13;
        public const int TSLF_CHECKSUMMENFEHLER = 14;
        public const int TSLF_KEINE_KOMMUNIKATION = 15;
        public const int TSLF_CHECKBUFFER_LEER = 16;
        public const int TSLF_NULL_POINTER = 17;
        public const int TSLF_MODE_UNGUELTIG = 18;
        public const int TSLF_DONT_SET_USB = 19;
        public const int TSLF_COMPARE_ERROR = 20;
        public const int TSLF_NACK = 0x15; // 21
        public const int TSLF_SYNC = 0x16; // 22
        public const int TSLF_LOCKED = 0x17; // 23
        public const int TSLF_CANCEL = 0x18; // 24
        public const int TSLF_INVALID_DATA = 0x19; // 25

        public const int TTYP_DEFAULT = 0;
        public const int TTYP_HITAG_2 = 2;
        public const int TTYP_Q5 = 3;
        public const int TTYP_HITAG_S = 4;
        public const int TTYP_HITAG_1 = 5;
        public const int TTYP_TITAN = 6;
        public const int TTYP_EM4569 = 7;
        public const int TTYP_EM4305 = 8;
        public const int TTYP_ATA5577 = 9;
        public const int TTYP_HITAG_Y = 10;
        public const int TTYP_ATA5575 = 11;
        public const int TTYP_SIC7888 = 12;
        public const int TTYP_ATA5551 = 13;

        public const int TTYP_HDX_TIRIS = 0x21; // 33
        public const int TTYP_HDX_INCIDE = 0x22; // 34
        public const int TTYP_HDX_PLUS = 0x23; // 35
        public const int TTYP_HDX_SIC7900 = 0x24; // 36
        public const int TTYP_HDX_PLUS_HIQ = 0x25; // 37
        public const int TTYP_HDX_SIC7999 = 0x26; // 38

        public const int TTYP_ATA5577_PW = 0x30;

        public const int TTYP_FIRST = 1;
        public const int TTYP_LAST = 0x26;

        public const int SIC_LOGIN_RW = 0x0100;

        public const int READ_AFTER_WRITE = 0x0100;
        public const int READ_AFTER_WRITE_INVERS = 0x0200;
        public const int READ_INVERS = 0x0400;
        public const int DO_ALL_ERRORS = 0x0800;
        public const int NO_RETRY = 0x1000;
        public const int DO_OVERLAPPED = 0x2000;
        public const int NO_READ_AFTER_WRITE = 0x4000;
        public const int NO_FACTORY_ID = 0x8000;

        public const int ANSWER_MODE_MANCHESTER2KBIT = 0x00; // Manchester     RF/64
        public const int ANSWER_MODE_BIPHASE4KBIT = 0x01; // Diff. Biphase  RF/32
        public const int ANSWER_MODE_FSK2A = 0x02; // FSK 2A         RF/50
        public const int ANSWER_MODE_HDX = 0x03; // HDX
        public const int ANSWER_MODE_FSK_MANCHESTER = 0x04; // FSK 2A         RF/50 + Manchester Dekodierung
        public const int ANSWER_MODE_MANCHESTER4KBIT = 0x05; // Manchester     RF/32
        public const int ANSWER_MODE_BIPHASE2KBIT = 0x06; // Diff. Biphase  RF/64
        public const int ANSWER_MODE_FSK2A2KBIT = 0x07; // FSK 2A         RF/64
        public const int ANSWER_MODE_INVERS = 0x80; // Zusätzliches Flag Invers

        // Parameter für TSLF_ReadFormattedData()
        public const int TSLF_FORMAT_UNIQUE = 0x0001;
        public const int TSLF_FORMAT_GIS16BIT = 0x0002;
        public const int TSLF_FORMAT_UNIQUEXL = 0x0003;
        public const int TSLF_FORMAT_ANIMAL_FDXB = 0x0004;
        public const int TSLF_FORMAT_ANIMAL_FDXA = 0x0005;
        public const int TSLF_FORMAT_ANIMAL_HDX = 0x0006;

        public const int TSLF_READ_BY_DEFAULT = 0x0000;
        public const int TSLF_READ_BY_CMD = 0x0100;
        public const int TSLF_READ_UID = 0x0200;

        // possible values for Lock in WriteFSK commands
        public const int TSLF_WRITEFSK_LOCK_NONE = 0;
        public const int TSLF_WRITEFSK_LOCK_DATA = 1;
        public const int TSLF_WRITEFSK_LOCK_CONFIG = 2;
        public const int TSLF_WRITEFSK_LOCK_ALL = 3;

        // Rückgabewerte
        public const int TSLF_RETVAL_ERROR = -1;
        public const int TSLF_RETVAL_OK = 0;
        public const int TSLF_RETVAL_FORMAT_FALSCH = 1;
        public const int TSLF_RETVAL_LOCKED = 2;
        public const int TSLF_RETVAL_SAME_TAG = 3;
        public const int TSLF_RETVAL_PROCESS_PENDING = 4;
        public const int TSLF_RETVAL_INVALID_DATA = 5;

        public delegate int AutoReadCallback([MarshalAsAttribute(UnmanagedType.LPStr)] string pData, int Len);

        const string dllname = "TS_LF_SDK.dll";
        // Get Library Version                               
        [DllImport(dllname)] public static extern int TSLF_LibVersion();

        [DllImport(dllname)] public static extern int TSLF_IsVirtualComInstalled();

        // Get Names of all USB Devices connected, only valid devices are listed
        [DllImport(dllname)] public static extern int TSLF_GetUSBDeviceNames(SByte[] NamenListe, int nBufferSize);

        // Get Names of all USB Devices connected, all devices from GiS are listed
        [DllImport(dllname)] public static extern int TSLF_GetUSBDeviceNamesEx(SByte[] NamenListe, int nBufferSize);

        // Get Names of all COM Ports available, not tested if there is a device at the port connected.
        [DllImport(dllname)] public static extern int TSLF_GetCOMDeviceNames(SByte[] NamenListe, int nBufferSize);

        // Get Names of all valid LAN devices found in same subnet
        [DllImport(dllname)] public static extern int TSLF_GetLanDeviceNames(SByte[] NamenListe, int nBufferSize);

        // Get Names of all LAN devices found even in other subnets
        [DllImport(dllname)] public static extern int TSLF_GetLanDeviceNamesEx(SByte[] Buffer, int nBufferSize);

        // Change IP Address of LAN device
        [DllImport(dllname)] public static extern int TSLF_ChangeLanIPAddress(SByte[] OldAddress, SByte[] NewAddress, SByte[] IPMask);

        // Change IP Address and Gateway of LAN device
        [DllImport(dllname)] public static extern int TSLF_ChangeLanIPAddressEx(SByte[] OldAddress, SByte[] NewAddress, SByte[] IPMask, SByte[] GatewayAddress);

        // Get IP Address and Gateway of LAN device
        [DllImport(dllname)] public static extern int TSLF_GetLanIPAddressEx(SByte[] strName, SByte[] Address, SByte[] IPMask, SByte[] GatewayAddress);

        // Check if specific LAN device is available
        [DllImport(dllname)] public static extern int TSLF_IsLanDeviceAvailable(SByte[] Address);

        // Open LAN Device for configuration
        [DllImport(dllname)] public static extern int TSLF_LanConfigOpen(SByte[] strName);

        // Set Configuration Record of LAN device, use with care!
        [DllImport(dllname)] public static extern int TSLF_LanConfigGet(int nHandle, int RecordNr, Byte[] pData, int Len);

        // Get Configuration Record of LAN device
        [DllImport(dllname)] public static extern int TSLF_LanConfigSet(int nHandle, int RecordNr, Byte[] pData, int Len);

        // Close LAN device configuration.
        [DllImport(dllname)] public static extern int TSLF_LanConfigClose(int nHandle, int Reset);

        // Read Configuration of USB HID device
        [DllImport(dllname)] public static extern int TSLF_HIDConfigRead(int PortHandle, Byte[] pSendBuf, int SendBufLen, Byte[] pRecvBuf, int RecvBufLen);
        // Write Configuration to USB HID device
        [DllImport(dllname)] public static extern int TSLF_HIDConfigWrite(int PortHandle, Byte[] pSendBuf, int SendBufLen);

        [DllImport(dllname)] public static extern int TSLF_Open(SByte[] Name, int Baudrate, int ParityMode, int Timeout);
        [DllImport(dllname)] public static extern int TSLF_Close(int handle);
        [DllImport(dllname)] public static extern int TSLF_KeepAppActive(int handle, int bActive);
        [DllImport(dllname)] public static extern int TSLF_SetReaderAdresse(int handle, int Adresse);

        [DllImport(dllname)] public static extern int TSLF_StartAutoRead(int handle, int TermChar, AutoReadCallback cbFunction);
        [DllImport(dllname)] public static extern int TSLF_StopAutoRead(int handle);


        [DllImport(dllname)] public static extern int TSLF_GetDeviceVersion(int handle, SByte[] pDevVer, int VerLen, SByte[] pDevName, int NameLen);
        [DllImport(dllname)] public static extern int TSLF_IsProgrammer(int handle);
        [DllImport(dllname)] public static extern int TSLF_IsReader(int handle);
        [DllImport(dllname)] public static extern int TSLF_IsUSB(int handle);
        [DllImport(dllname)] public static extern int TSLF_GetFilter(int handle, int TTyp, Byte[] pParam, int nParamLen);
        [DllImport(dllname)] public static extern int TSLF_SetFilter(int handle, int TTyp, Byte[] pParam, int nParamLen);
        [DllImport(dllname)] public static extern int TSLF_SetBaudrate(int handle, int Baudrate, int ParityMode);
        [DllImport(dllname)] public static extern int TSLF_SetWriteDelay(int handle, int delay);
        [DllImport(dllname)] public static extern int TSLF_SetReaderMode(int handle, int mode);
        [DllImport(dllname)] public static extern int TSLF_SetRF(int handle, int OnOff);
        [DllImport(dllname)] public static extern int TSLF_GetLastError(int handle);
        [DllImport(dllname)] public static extern int TSLF_SetIO(int handle, int Maske, int Daten);
        [DllImport(dllname)] public static extern int TSLF_ReadIO(int handle, out int pDaten);
        [DllImport(dllname)] public static extern int TSLF_TestIO(int handle, out int pTestwert);

        [DllImport(dllname)] public static extern int TSLF_SetLED(int handle, int red, int green, int yellow);
        [DllImport(dllname)] public static extern int TSLF_Beep(int handle);


        [DllImport(dllname)] public static extern int TSLF_ClearLCD(int handle);
        [DllImport(dllname)] public static extern int TSLF_SetLCDFont(int handle, int FontNr);
        [DllImport(dllname)] public static extern int TSLF_SetLCDText(int handle, int StartLine, SByte[] strText);
        [DllImport(dllname)] public static extern int TSLF_SetLCDLight(int handle, int Helligkeit);

        [DllImport(dllname)] public static extern int TSLF_ReadSerialNumber(int handle, Byte[] pSerial, int Buflen);
        [DllImport(dllname)] public static extern int TSLF_SetConfig(int handle, Byte[] pConfig, int ConfigLen);
        [DllImport(dllname)] public static extern int TSLF_GetConfig(int handle, Byte[] pConfig, int ConfigLen);
        [DllImport(dllname)] public static extern int TSLF_SetDefault(int handle);
        [DllImport(dllname)] public static extern int TSLF_SetAnswerMode(int handle, int AnswerMode);
        [DllImport(dllname)] public static extern int TSLF_GetAnswerMode(int handle);

        [DllImport(dllname)] public static extern int TSLF_ReadMagnetCard(int handle, Byte[] pBuffer, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_ClearMagnetCard(int handle);

        [DllImport(dllname)] public static extern int TSLF_GetActivationContext(int handle, Byte[] pData, int Len);
        [DllImport(dllname)] public static extern int TSLF_WriteActivationContext(int handle, Byte[] pData, int Len);
        [DllImport(dllname)] public static extern int TSLF_ReadCounter(int handle, out int pCounter);
        [DllImport(dllname)] public static extern int TSLF_DecrementCounter(int handle, out int pNewCounter);
        [DllImport(dllname)] public static extern int TSLF_GetDaysRemain(int handle, out int pDaysRemain);
        [DllImport(dllname)] public static extern int TSLF_UpdateDaysRemain(int handle, out int pDaysRemain);

        [DllImport(dllname)] public static extern int TSLF_SetCommunicationMode(int handle, int Mode);
        [DllImport(dllname)] public static extern int TSLF_RawWrite(int handle, Byte[] pBuffer, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_RawRead(int handle, Byte[] pBuffer, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_Transfer(int PortHandle, int Cmd, Byte[] pSendBuf, int SendBufLen, Byte[] pRecvBuf, int RecvBufLen);

        [DllImport(dllname)] public static extern int TSLF_Read(int handle, int TransponderTyp, int WortBlockPageNr, Byte[] pBuffer, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_Write(int handle, int TransponderTyp, int WortBlockPageNr, Byte[] pBuffer, int BufLen, int Lock);

        [DllImport(dllname)] public static extern int TSLF_GetTagType(int handle, int TTypExpected);
        [DllImport(dllname)] public static extern int TSLF_GetTagAnswerMode(int handle, int TTyp, int AnswerModeExpected);

        [DllImport(dllname)] public static extern int TSLF_Write_Unique(int handle, int TransponderTyp, Byte[] pBuffer, int BufLen, int Lock);
        [DllImport(dllname)] public static extern int TSLF_Write_FastUnique(int handle, int TransponderTyp, Byte[] pBuffer, int BufLen, int Lock);
        [DllImport(dllname)] public static extern int TSLF_Write_UniqueXL(int handle, int TransponderTyp, Byte[] pBuffer, int BufLen, int Lock);
        [DllImport(dllname)] public static extern int TSLF_Write_GiS16Bit(int handle, int TransponderTyp, Byte[] pBuffer, int BufLen, int Lock);
        [DllImport(dllname)] public static extern int TSLF_Write_GiS12Bit(int handle, int TransponderTyp, Byte[] pBuffer, int BufLen, int Lock);
        [DllImport(dllname)] public static extern int TSLF_Write_GiS72Bit(int handle, int TransponderTyp, Byte[] pBuffer, int BufLen, int Lock);
        [DllImport(dllname)] public static extern int TSLF_Write_FSK26Bit(int handle, int TransponderTyp, uint FacilityCode, uint CardNr, int Lock);
        [DllImport(dllname)] public static extern int TSLF_Write_FSK34Bit(int handle, int TransponderTyp, uint FacilityCode, uint CardNr, int Lock);
        [DllImport(dllname)] public static extern int TSLF_Write_NC34Bit(int handle, int TransponderTyp, uint FacilityCode, uint CardNr, int Lock);
        [DllImport(dllname)] public static extern int TSLF_Write_FSK35Bit(int handle, int TransponderTyp, uint FacilityCode, uint CardNr, int Lock);
        [DllImport(dllname)] public static extern int TSLF_Write_FSK36Bit(int handle, int TransponderTyp, uint FacilityCode, uint CardNr, uint FixedField, int Lock);
        [DllImport(dllname)] public static extern int TSLF_Write_FSK37Bit(int handle, int TransponderTyp, uint FacilityCode, uint CardNr, int Lock);
        [DllImport(dllname)] public static extern int TSLF_Write_FSK37BitHuge(int handle, int TransponderTyp, Byte[] pCode, int CodeLen, int Lock);
        [DllImport(dllname)] public static extern int TSLF_Write_IDCard37Bit(int handle, int TransponderTyp, uint FacilityCode, uint CardNr, int Lock);
        [DllImport(dllname)] public static extern int TSLF_Write_AWID26Bit(int handle, int TransponderTyp, uint FacilityCode, uint CardNr, int Lock);
        [DllImport(dllname)] public static extern int TSLF_Write_AWID40Bit(int handle, int TransponderTyp, uint FacilityCode, uint CardNr, int Lock);

        [DllImport(dllname)] public static extern int TSLF_Read_TTFData(int handle, int AnswerMode, Byte[] pBuffer, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_Read_Unique(int handle, Byte[] pBuffer, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_Read_FastUnique(int handle, Byte[] pBuffer, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_Read_UniqueXL(int handle, Byte[] pBuffer, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_Read_GiS16Bit(int handle, Byte[] pBuffer, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_Read_GiS12Bit(int handle, Byte[] pBuffer, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_Read_GiS72Bit(int handle, Byte[] pBuffer, int BufLen);

        [DllImport(dllname)] public static extern int TSLF_Read_FSK26Bit(int handle, out uint pFacilityCode, out uint pCardNr);
        [DllImport(dllname)] public static extern int TSLF_Read_FSK34Bit(int handle, out uint pFacilityCode, out uint pCardNr);
        [DllImport(dllname)] public static extern int TSLF_Read_NC34Bit(int handle, out uint pFacilityCode, out uint pCardNr);
        [DllImport(dllname)] public static extern int TSLF_Read_FSK35Bit(int handle, out uint pFacilityCode, out uint pCardNr);
        [DllImport(dllname)] public static extern int TSLF_Read_FSK36Bit(int handle, out uint pFacilityCode, out uint pCardNr, out uint pFixedField);
        [DllImport(dllname)] public static extern int TSLF_Read_FSK37Bit(int handle, out uint pFacilityCode, out uint pCardNr);
        [DllImport(dllname)] public static extern int TSLF_Read_FSK37BitHuge(int handle, Byte[] pCode, int CodeLen);
        [DllImport(dllname)] public static extern int TSLF_Read_IDCard37Bit(int handle, out uint pFacilityCode, out uint pCardNr);
        [DllImport(dllname)] public static extern int TSLF_Read_AWID26Bit(int handle, out uint pFacilityCode, out uint pCardNr);
        [DllImport(dllname)] public static extern int TSLF_Read_AWID40Bit(int handle, out uint pFacilityCode, out uint pCardNr);

        [DllImport(dllname)] public static extern int TSLF_ReadFormattedData(int handle, int TTyp, int ReadType, Byte[] pBuffer, int BufLen);

        [DllImport(dllname)] public static extern int TSLF_ResetTransponder(int handle, int TTyp);

        [DllImport(dllname)] public static extern int TSLF_UID_Request(int PortHandle, int TTyp, Byte[] pUID, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_UID_RequestAC(int PortHandle, int TTyp, Byte[] pUID, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_UID_RequestNext(int PortHandle, int TTyp, Byte[] pUID, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_Select(int PortHandle, int TTyp, Byte[] pSelData, int SelDataLen, Byte[] pConfig, int ConfigLen);
        [DllImport(dllname)] public static extern int TSLF_Authenticate(int handle, int TTyp, Byte[] pKey, int KeyLen, Byte[] pBuffer, int BufLen);

        [DllImport(dllname)] public static extern int TSLF_WakeUp(int handle, int TransponderTyp, Byte[] pPasswort, int PasswortLen);
        [DllImport(dllname)] public static extern int TSLF_WakeUpAndRead(int handle, int TTyp, Byte[] pPasswort, int PasswortLen, Byte[] pBuffer, int BufLen);

        [DllImport(dllname)] public static extern int TSLF_Login(int handle, int TransponderTyp, Byte[] pPW, int nPWLen);
        [DllImport(dllname)] public static extern int TSLF_WritePW(int handle, int TransponderTyp, Byte[] pOldPW, int OldPWLen, Byte[] pNewPW, int NewPWLen);

        [DllImport(dllname)] public static extern int TSLF_Disable(int handle, int TransponderTyp);
        [DllImport(dllname)] public static extern int TSLF_Lock(int handle, int TransponderTyp, int BlockNr);

        [DllImport(dllname)] public static extern int TSLF_GetTagInfo(int PortHandle, int TransponderTyp, Byte[] pSysInfo, int SysInfoLen);
        [DllImport(dllname)] public static extern int TSLF_SetCTune(int handle, int TTyp, int CTuneVal, int bUseValue, int bOne, int bLock, out int pFrequenz);
        [DllImport(dllname)] public static extern int TSLF_AutoTune(int handle, int TTyp, ref int pFrequenz0, ref int pFrequenz1, int bLock);

        [DllImport(dllname)] public static extern int TSLF_WriteParam(int handle, Byte[] pBuffer, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_ReadParam(int handle, Byte[] pBuffer, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_WritePrefix(int handle, Byte[] pBuffer, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_ReadPrefix(int handle, Byte[] pBuffer, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_WriteSuffix(int handle, Byte[] pBuffer, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_ReadSuffix(int handle, Byte[] pBuffer, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_WriteTermix(int handle, Byte[] pBuffer, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_ReadTermix(int handle, Byte[] pBuffer, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_WritePostcode(int handle, Byte[] pBuffer, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_ReadPostcode(int handle, Byte[] pBuffer, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_WriteReadModeParam(int handle, Byte[] pBuffer, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_ReadReadModeParam(int handle, Byte[] pBuffer, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_WriteHitag2Key(int handle, Byte[] pBuffer, int BufLen);
        [DllImport(dllname)] public static extern int TSLF_WriteTagKey(int handle, int TTyp, Byte[] pBuffer, int BufLen);

        // Functions for ISO11784 (Animal code and Waste management code)
        [DllImport(dllname)] public static extern int TSLF_Read_FDXA(int handle, Byte[] pIdNumber, int pIdLen);
        [DllImport(dllname)] public static extern int TSLF_Write_FDXA(int handle, int TTyp, Byte[] pFactoryID, Byte[] pIdNumber, int pIdLen, int Lock);

        [DllImport(dllname)] public static extern int TSLF_Read_FDXB(int handle, out int pCountryCode, Byte[] pBuffer, int BufLen, out int pAnimalFlag, out int pDatenblockFlag, out int pReserved, out int pExtension);
        [DllImport(dllname)] public static extern int TSLF_Write_FDXB(int handle, int TransponderTyp, Byte[] pFactoryID, int CountryCode, Byte[] pIDNummer, int IDNummerLen, int AnimalFlag, int DatenblockFlag, int Reserved, int Extension, int Lock);

        [DllImport(dllname)] public static extern int TSLF_Read_HDX(int handle, out int pCountryCode, Byte[] pBuffer, int BufLen, out int pAnimalFlag, out int pDatenblockFlag, out int pReserved, out int pExtension);
        [DllImport(dllname)] public static extern int TSLF_Write_HDX(int handle, int TransponderTyp, Byte[] pFactoryID, int CountryCode, Byte[] pIDNummer, int IDNummerLen, int AnimalFlag, int DatenblockFlag, int Reserved, int Extension, int Lock);

        [DllImport(dllname)] public static extern int TSLF_Read_EN14803(int handle, out int pManufacturer, out int pSerialNumber);
        [DllImport(dllname)] public static extern int TSLF_Read_EN14803HDX(int handle, out int pManufacturer, out int pSerialNumber);
        [DllImport(dllname)] public static extern int TSLF_Write_EN14803(int handle, int TransponderTyp, Byte[] pFactoryID, int Manufacturer, int SerialNumber, int Lock);

        [DllImport(dllname)] public static extern int TSLF_IsWriteFinished(int handle, Byte[] pFactoryID);

        public GIS_LF_API()
        {
        }
    }
}

