using System;
using System.Runtime.InteropServices;
using System.Collections;

namespace FtdEncoder
{
    public enum FTDType : byte
    {
        None = 0x00,
        Ftdc = 0x01,
        Compressed = 0x02
    }

    public enum FTDTag : byte
    {
        None = 0x00,
        Datetime = 0x01,
        CompressMethod = 0x02,
        SessionState = 0x03,
        KeepAlive = 0x04,
        Tradedate = 0x05,
        Target = 0x06
    }

    public class FtdHdr
    {
        public readonly int HdrLength = 4;
        public FTDType Type;
        public byte ExtHdrLength;
        public ushort ContentLength;
    }

    public class FtdExtHdr
    {
        public FTDTag Tag;
        public byte TagLength;
        public byte[] Data;

        public byte[] ToData()
        {
            byte[] buf = new byte[2 + TagLength];
            buf[0] = (byte)Tag;
            buf[1] = TagLength;
            Array.Copy(Data, 0, buf, 2, TagLength);
            throw new NotImplementedException();
        }
    }

    enum PacketChain : byte
    {
        Single =    0x53,    // ascii code for S
        First =     0x46,    // ascii code for F
        InBetween = 0x43,    // ascii code for C
        Last =      0x4c,    // ascii code for L
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

	public class FtdPacket
	{
		public FtdHdr hdr;
		public FtdExtHdr exthdr;
		public byte[] content;

		public FtdPacket()
		{
			hdr = new FtdHdr();
			exthdr = null;
		}

		public byte[] ToData()
		{
            int len = hdr.HdrLength + hdr.ExtHdrLength + hdr.ContentLength;
            byte[] buf = new byte[len];
            buf[0] = (byte)hdr.Type;
            buf[1] = hdr.ExtHdrLength;
            Array.Copy(BitConverter.GetBytes(hdr.ContentLength), 0, buf, 2, 2);
            if (hdr.ExtHdrLength > 0)
            {
                Array.Copy(exthdr.ToData(), 0, buf, 4, hdr.ExtHdrLength);
            }
            Array.Copy(content, 0, buf, 4 + hdr.ExtHdrLength, hdr.ContentLength);
			return buf;
		}
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


