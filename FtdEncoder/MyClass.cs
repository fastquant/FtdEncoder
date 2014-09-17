using System;
using System.Runtime.InteropServices;

namespace FtdEncoder
{
    //    public class MyClass
    //    {
    //        public MyClass()
    //        {
    //        }
    //    }

    enum FtdType : byte
    {
        None = 0x00,
        Ftdc = 0x01,
        Compressed = 0x02
    }

    enum FtdTag : byte
    {
        None = 0x00,
        Datetime = 0x01,
        CompressMethod = 0x02,
        SessionState = 0x03,
        KeepAlive = 0x04,
        TradeDate = 0x05,
        Target = 0x06
    }

    public class FtdHdr
    {
        public byte Type;
        public byte ExtLength;

    }

    public class FtdExtHdr
    {
    }

    enum PacketChain : byte
    {
        Single = 0x53,
        // S
        First = 0x46,
        // F,
        InBetween = 0x43,
        // C
        Last = 0x4c,
        // L
    }

    public class FtdcHdr
    {
        public byte Version;
        public uint TransactionId;
        public byte Chain;
        public ushort SequenceSeries;
        public uint SequenceNumber;
        public ushort FieldCount;
        public ushort ContentLength;
    }

    public class FtdcDataEntry
    {
        public int FieldId;
        public ushort FieldLength;
        public byte[] DataItem;
    }

    public enum FtdDataType
    {
        Char,
        Float,
        Int,
        Number,
        String,
        Word
    }
}

namespace FtdEncoder.Messages
{

    public enum BaseType
    {
        Char,
        Float,
        Int,
        Number,
        String,
        Word
    }

    public abstract class FTDType
    {
        public virtual int Length { get { throw new NotImplementedException(); } }

        public virtual int Precision { get { throw new NotImplementedException(); } }
    }

    public class FTDCharType : FTDType
    {
        public override int Length
        { 
            get
            {
                return 1;
            }
        }

        public override int Precision
        { 
            get
            {
                return 0;
            }
        }
    }

    public class FTDIntType : FTDType
    {
        public override int Length
        { 
            get
            {
                return 4;
            }
        }

        public override int Precision
        { 
            get
            {
                return 0;
            }
        }
    }

    public class FTDNumberType : FTDType
    {
        public override int Length
        { 
            get
            {
                throw new NotImplementedException();
            }
        }

        public override int Precision
        { 
            get
            {
                return 0;
            }
        }
    }

    public class FTDFloatType : FTDType
    {
        public override int Length
        { 
            get
            {
                throw new NotImplementedException();
            }
        }

        public override int Precision
        { 
            get
            {
                throw new NotImplementedException();
            }
        }
    }

    public class FTDStringType : FTDType
    {
        public override int Length
        { 
            get
            {
                throw new NotImplementedException(); 
            }
        }

        public override int Precision
        { 
            get
            {
                return 0;
            }
        }
    }

    public class FTDWordType : FTDType
    {
        public override int Length
        { 
            get
            {
                return 2;
            }
        }

        public override int Precision
        { 
            get
            {
                return 0;
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }

        public Type Type { get; set; }

        public string Comment { get; set; }
    }

    public abstract class Field
    {
        public virtual ushort FidValue { get { throw new NotImplementedException(); } }
    }

    public abstract class Packet
    {
        public virtual ushort TId { get { throw new NotImplementedException(); } }

        public void ToData()
        {
        }
    }
}


