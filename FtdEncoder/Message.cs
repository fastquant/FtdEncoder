using System;
using System.ComponentModel;

namespace FtdEncoder.Messages
{
    public class FTDActionFlag : FTDCharType
    {
       [Description("删除"), Category("EnumValue")]
       public static int VAL0 = 0;

       [Description("挂起"), Category("EnumValue")]
       public static int VAL1 = 1;

       [Description("激活"), Category("EnumValue")]
       public static int VAL2 = 2;


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

    public class FTDBoolFlag : FTDCharType
    {
       [Description("真"), Category("EnumValue")]
       public static int VAL1 = 1;

       [Description("假"), Category("EnumValue")]
       public static int VAL0 = 0;


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

    public class FTDClientId : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 8;
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

    public class FTDClientType : FTDCharType
    {
       [Description("自然人"), Category("EnumValue")]
       public static int VAL0 = 0;

       [Description("法人"), Category("EnumValue")]
       public static int VAL1 = 1;


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

    public class FTDConnectionReference : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 5;
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

    public class FTDDataFlowFlag : FTDCharType
    {
       [Description("对话流"), Category("EnumValue")]
       public static int VAL0 = 0;

       [Description("私有流"), Category("EnumValue")]
       public static int VAL1 = 1;

       [Description("广播流"), Category("EnumValue")]
       public static int VAL2 = 2;


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

    public class FTDDate : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 8;
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

    public class FTDDateTime : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 20;
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

    public class FTDDirection : FTDCharType
    {
       [Description("买"), Category("EnumValue")]
       public static int VAL0 = 0;

       [Description("卖"), Category("EnumValue")]
       public static int VAL1 = 1;


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

    public class FTDErrorCode : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 10;
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

    public class FTDForceExitCode : FTDCharType
    {
       [Description("目前应该为0"), Category("EnumValue")]
       public static int VAL0 = 0;


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

    public class FTDHedgeFlag : FTDCharType
    {
       [Description("投机"), Category("EnumValue")]
       public static int VAL1 = 1;

       [Description("套期保值"), Category("EnumValue")]
       public static int VAL3 = 3;


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

    public class FTDInstrumentId : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 10;
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

    public class FTDInstrumentStatus : FTDCharType
    {
       [Description("连续交易"), Category("EnumValue")]
       public static int VAL0 = 0;

       [Description("开盘集合竞价"), Category("EnumValue")]
       public static int VAL1 = 1;

       [Description("收盘集合竞价"), Category("EnumValue")]
       public static int VAL2 = 2;

       [Description("暂停"), Category("EnumValue")]
       public static int VAL3 = 3;

       [Description("非交易"), Category("EnumValue")]
       public static int VAL4 = 4;


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

    public class FTDInstrumentType : FTDCharType
    {
       [Description("目前应该为0"), Category("EnumValue")]
       public static int VAL0 = 0;


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

    public class FTDInstrumentVersion : FTDCharType
    {
       [Description("目前应该为0"), Category("EnumValue")]
       public static int VAL0 = 0;


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

    public class FTDLocalId : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 15;
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

    public class FTDMarketId : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 10;
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

    public class FTDMarketStatus : FTDCharType
    {
       [Description("连续交易"), Category("EnumValue")]
       public static int VAL0 = 0;

       [Description("开盘集合竞价"), Category("EnumValue")]
       public static int VAL1 = 1;

       [Description("收盘集合竞价"), Category("EnumValue")]
       public static int VAL2 = 2;

       [Description("暂停"), Category("EnumValue")]
       public static int VAL3 = 3;

       [Description("非交易"), Category("EnumValue")]
       public static int VAL4 = 4;


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

    public class FTDMatchCondition : FTDCharType
    {
       [Description("即时全部成交"), Category("EnumValue")]
       public static int VAL1 = 1;

       [Description("即时部分成交"), Category("EnumValue")]
       public static int VAL2 = 2;

       [Description("当日有效"), Category("EnumValue")]
       public static int VAL3 = 3;

       [Description("取消前有效"), Category("EnumValue")]
       public static int VAL4 = 4;

       [Description("指定日期前有效"), Category("EnumValue")]
       public static int VAL5 = 5;


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

    public class FTDMatchSession : FTDCharType
    {
       [Description("开盘集合竞价"), Category("EnumValue")]
       public static int VAL1 = 1;

       [Description("连续交易"), Category("EnumValue")]
       public static int VAL2 = 2;

       [Description("开盘集合竞价和连续交易"), Category("EnumValue")]
       public static int VAL3 = 3;

       [Description("收盘集合竞价"), Category("EnumValue")]
       public static int VAL4 = 4;

       [Description("开盘集合竞价和收盘集合竞价"), Category("EnumValue")]
       public static int VAL5 = 5;

       [Description("连续交易和收盘集合竞价"), Category("EnumValue")]
       public static int VAL6 = 6;

       [Description("开盘集合竞价,连续交易和收盘集合竞价"), Category("EnumValue")]
       public static int VAL7 = 7;


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

    public class FTDMatchFlag : FTDCharType
    {
       [Description("同为开仓"), Category("EnumValue")]
       public static int VAL0 = 0;

       [Description("同为平仓"), Category("EnumValue")]
       public static int VAL1 = 1;

       [Description("不同"), Category("EnumValue")]
       public static int VAL2 = 2;


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

    public class FTDMsgRef : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 6;
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

    public class FTDName : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 20;
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

    public class FTDNewsType : FTDStringType
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

    public class FTDNewsUrgency : FTDCharType
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

    public class FTDOffsetFlag : FTDCharType
    {
       [Description("开仓"), Category("EnumValue")]
       public static int VAL0 = 0;

       [Description("平仓"), Category("EnumValue")]
       public static int VAL1 = 1;

       [Description("强平"), Category("EnumValue")]
       public static int VAL2 = 2;

       [Description("强减"), Category("EnumValue")]
       public static int VAL3 = 3;


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

    public class FTDOrderStatus : FTDCharType
    {
       [Description("全部成交"), Category("EnumValue")]
       public static int VAL0 = 0;

       [Description("部分成交还在队列中"), Category("EnumValue")]
       public static int VAL1 = 1;

       [Description("部分成交不在队列中"), Category("EnumValue")]
       public static int VAL2 = 2;

       [Description("未成交还在队列中"), Category("EnumValue")]
       public static int VAL3 = 3;

       [Description("未成交不在队列中"), Category("EnumValue")]
       public static int VAL4 = 4;

       [Description("撤单"), Category("EnumValue")]
       public static int VAL5 = 5;


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

    public class FTDOrderType : FTDCharType
    {
       [Description("限价"), Category("EnumValue")]
       public static int VAL0 = 0;

       [Description("市价"), Category("EnumValue")]
       public static int VAL1 = 1;

       [Description("止损限价"), Category("EnumValue")]
       public static int VAL2 = 2;

       [Description("止损市价"), Category("EnumValue")]
       public static int VAL3 = 3;

       [Description("市价转限价"), Category("EnumValue")]
       public static int VAL4 = 4;

       [Description("最好价格"), Category("EnumValue")]
       public static int VAL5 = 5;

       [Description("均价"), Category("EnumValue")]
       public static int VAL6 = 6;


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

    public class FTDParticipantId : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 8;
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

    public class FTDParticipantType : FTDCharType
    {
       [Description("自营"), Category("EnumValue")]
       public static int VAL0 = 0;

       [Description("经纪"), Category("EnumValue")]
       public static int VAL1 = 1;

       [Description("综合"), Category("EnumValue")]
       public static int VAL2 = 2;

       [Description("特别"), Category("EnumValue")]
       public static int VAL3 = 3;

       [Description("做市商"), Category("EnumValue")]
       public static int VAL4 = 4;


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

    public class FTDPassword : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 40;
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

    public class FTDPercent : FTDFloatType
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
                return 2;
            }
        }
    }

    public class FTDPrice : FTDFloatType
    {

        public override int Length
        {
            get
            {
                return 10;
            }
        }

        public override int Precision
        {
            get
            {
                return 2;
            }
        }
    }

    public class FTDProtocolVersion : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 8;
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

    public class FTDPubStyle : FTDCharType
    {
       [Description("不发布"), Category("EnumValue")]
       public static int VAL0 = 0;

       [Description("发布"), Category("EnumValue")]
       public static int VAL1 = 1;


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

    public class FTDSequenceNo : FTDIntType
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

    public class FTDSequenceSeries : FTDWordType
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

    public class FTDServerAppName : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 20;
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

    public class FTDStopCode : FTDCharType
    {
       [Description("目前应该为0"), Category("EnumValue")]
       public static int VAL0 = 0;


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

    public class FTDSysOrderId : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 20;
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

    public class FTDTime : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 8;
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

    public class FTDTimeOut : FTDNumberType
    {

        public override int Length
        {
            get
            {
                return 3;
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

    public class FTDTimeStamp : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 20;
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

    public class FTDUserId : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 15;
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

    public class FTDTradeId : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 20;
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

    public class FTDTradeRight : FTDCharType
    {
       [Description("完全"), Category("EnumValue")]
       public static int VAL0 = 0;

       [Description("只可平"), Category("EnumValue")]
       public static int VAL1 = 1;

       [Description("不准交易"), Category("EnumValue")]
       public static int VAL2 = 2;


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

    public class FTDUserStatus : FTDCharType
    {
       [Description("目前应该为0"), Category("EnumValue")]
       public static int VAL0 = 0;


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

    public class FTDUserType : FTDCharType
    {
       [Description("目前应该为0"), Category("EnumValue")]
       public static int VAL0 = 0;


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

    public class FTDTradeType : FTDCharType
    {
       [Description("目前应该为0"), Category("EnumValue")]
       public static int VAL0 = 0;


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

    public class FTDValue : FTDFloatType
    {

        public override int Length
        {
            get
            {
                return 14;
            }
        }

        public override int Precision
        {
            get
            {
                return 2;
            }
        }
    }

    public class FTDVolume : FTDIntType
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

    public class FTDVolumeType : FTDCharType
    {
       [Description("增量"), Category("EnumValue")]
       public static int VAL0 = 0;

       [Description("绝对量"), Category("EnumValue")]
       public static int VAL1 = 1;


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

    public class FTDAbstract : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 80;
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

    public class FTDComeFrom : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 20;
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

    public class FTDContent : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 500;
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

    public class FTDCurrency : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 3;
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

    public class FTDErrorText : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 100;
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

    public class FTDForceExitMsg : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 100;
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

    public class FTDFrontId : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 20;
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

    public class FTDFusepoint : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 6;
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

    public class FTDIpAddr : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 20;
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

    public class FTDURLLink : FTDStringType
    {

        public override int Length
        {
            get
            {
                return 200;
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

    public class FTDTimeSpan : FTDNumberType
    {

        public override int Length
        {
            get
            {
                return 200;
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

    [Description("告示域")]
    public class BulletinField : Field
    {
        [Description("消息类型")]
        public FTDNewsType NewsType;

        [Description("紧急程度")]
        public FTDNewsUrgency NewsUrgency;

        [Description("发送时间")]
        public FTDTime SendTime;

        [Description("摘要/说明")]
        public FTDAbstract Abstract;

        [Description("消息来源")]
        public FTDComeFrom ComeFrom;

        [Description("市场编码")]
        public FTDMarketId MarketId;

        [Description("消息正文")]
        public FTDContent Content;

        [Description("此消息的WEB联结")]
        public FTDURLLink URLLink;


        public override ushort FidValue
        {
            get
            {
                return 0x0001;
            }
        }
    }

    [Description("客户域")]
    public class ClientField : Field
    {
        [Description("客户编码")]
        public FTDClientId ClientId;

        [Description("交易会员编码")]
        public FTDParticipantId ParticipantId;

        [Description("客户名称")]
        public FTDName ClientName;

        [Description("客户类别")]
        public FTDClientType ClientType;

        [Description("交易权限")]
        public FTDTradeRight TradeRights;


        public override ushort FidValue
        {
            get
            {
                return 0x0002;
            }
        }
    }

    [Description("会员资金域")]
    public class DepositField : Field
    {
        [Description("交易会员编码")]
        public FTDParticipantId ParticipantId;

        [Description("会员类型")]
        public FTDParticipantType ParticipantType;

        [Description("交易委托日期")]
        public FTDDate TradeDate;

        [Description("初始保证金")]
        public FTDValue InitMargin;

        [Description("买投开仓使用保证金")]
        public FTDValue BuySpecOpenUsedMargin;

        [Description("买保开仓使用保证金")]
        public FTDValue BuyHedgeOpenUsedMargin;

        [Description("卖投开仓使用保证金")]
        public FTDValue SellSpecOpenUsedMargin;

        [Description("卖保开仓使用保证金")]
        public FTDValue SellHedgeOpenUsedMargin;

        [Description("买投平仓盈亏")]
        public FTDValue BuySpecOffsetProfit;

        [Description("买保平仓盈亏")]
        public FTDValue BuyHedgeOffsetProfit;

        [Description("卖投平仓盈亏")]
        public FTDValue SellSpecOffsetProfit;

        [Description("卖保平仓盈亏")]
        public FTDValue SellHedgeOffsetProfit;

        [Description("买投开仓冻结保证金")]
        public FTDValue BuySpecOpenFrozMargin;

        [Description("买保开仓冻结保证金")]
        public FTDValue BuyHedgeOpenFrozMargin;

        [Description("卖投开仓冻结保证金")]
        public FTDValue SellSpecOpenFrozMargin;

        [Description("卖保开仓冻结保证金")]
        public FTDValue SellHedgeOpenFrozMargin;

        [Description("买投平仓返回保证金")]
        public FTDValue BuySpecOffsetMargin;

        [Description("买保平仓返回保证金")]
        public FTDValue BuyHedgeOffsetMargin;

        [Description("卖投平仓返回保证金")]
        public FTDValue SellSpecOffsetMargin;

        [Description("卖保平仓返回保证金")]
        public FTDValue SellHedgeOffsetMargin;

        [Description("买投成交额")]
        public FTDValue BuySpecTurnOver;

        [Description("买保成交额")]
        public FTDValue BuyHedgeTurnOver;

        [Description("卖投成交额")]
        public FTDValue SellSpecTurnOver;

        [Description("卖保成交额")]
        public FTDValue SellHedgeTurnOver;

        [Description("本交易日新增资金")]
        public FTDValue AddValue;

        [Description("本交易日提出资金")]
        public FTDValue DelValue;

        [Description("可用保证金余额")]
        public FTDValue BalanceValue;


        public override ushort FidValue
        {
            get
            {
                return 0x0003;
            }
        }
    }

    [Description("发送信息起始说明域")]
    public class DisseminationstartField : Field
    {
        [Description("序列类别号")]
        public FTDSequenceSeries SequenceSeries;

        [Description("序列号")]
        public FTDSequenceNo SequenceNo;


        public override ushort FidValue
        {
            get
            {
                return 0x0004;
            }
        }
    }

    [Description("错误域")]
    public class ErrorField : Field
    {
        [Description("错误代码")]
        public FTDErrorCode ErrorCode;

        [Description("错误正文")]
        public FTDErrorText ErrorText;

        [Description("时间戳")]
        public FTDTimeStamp TimeStamp;


        public override ushort FidValue
        {
            get
            {
                return 0x0005;
            }
        }
    }

    [Description("错误报单号域")]
    public class ErrorTargetOrderField : Field
    {
        [Description("合同编号")]
        public FTDSysOrderId OrderSysId;

        [Description("委托编号")]
        public FTDLocalId OrderLocalId;


        public override ushort FidValue
        {
            get
            {
                return 0x002D;
            }
        }
    }

    [Description("错误序列号域")]
    public class ErrorTargetSequenceField : Field
    {
        [Description("序列类别号")]
        public FTDSequenceSeries SequenceSeries;

        [Description("序列号")]
        public FTDSequenceNo SequenceNo;


        public override ushort FidValue
        {
            get
            {
                return 0x002E;
            }
        }
    }

    [Description("强制退出域")]
    public class ForceExitField : Field
    {
        [Description("强制退出号")]
        public FTDForceExitCode ForceExitCode;

        [Description("强制退出原因")]
        public FTDForceExitMsg ForceExitMsg;


        public override ushort FidValue
        {
            get
            {
                return 0x0006;
            }
        }
    }

    [Description("合约域")]
    public class InstrumentField : Field
    {
        [Description("市场编码")]
        public FTDMarketId MarketId;

        [Description("合约编码")]
        public FTDInstrumentId InstrumentId;

        [Description("合约版本号")]
        public FTDInstrumentVersion InstrumentVersion;

        [Description("合约名称")]
        public FTDName InstrumentName;

        [Description("输入快捷键")]
        public FTDCharType ShortCutKey;

        [Description("开始交易日")]
        public FTDDate StartTrdDate;

        [Description("最后交易日")]
        public FTDDate EndTrdDate;

        [Description("合约类型")]
        public FTDInstrumentType InstrumentType;

        [Description("最后交割日")]
        public FTDDate EndDelvDate;

        [Description("开始交割日")]
        public FTDDate StartDelvDate;

        [Description("停止交易原因")]
        public FTDStopCode InstrStopCode;

        [Description("交易用的货币")]
        public FTDCurrency Currency;

        [Description("交易权限")]
        public FTDTradeRight TradeRights;

        [Description("可否熔断")]
        public FTDBoolFlag FuseRights;

        [Description("每手乘数")]
        public FTDIntType Unit;

        [Description("最小价位")]
        public FTDPrice Tick;

        [Description("涨停板率")]
        public FTDPercent HighLimitRate;

        [Description("跌停板率")]
        public FTDPercent LowLimitRate;

        [Description("最大可下单手数")]
        public FTDVolume MaxLot;

        [Description("最小可下单手数")]
        public FTDVolume MinLot;

        [Description("竞价阶段合约行情发布方式")]
        public FTDPubStyle Pubstyle;

        [Description("熔断限额")]
        public FTDPrice Fuselimit;

        [Description("熔断最大持续时间")]
        public FTDIntType Fusepersisttime;

        [Description("在该时间点后不可熔断")]
        public FTDFusepoint Fusepoint;

        [Description("熔断标记")]
        public FTDBoolFlag FuseFlag;

        [Description("强平的撮合间隔")]
        public FTDIntType Forcedistime;


        public override ushort FidValue
        {
            get
            {
                return 0x0007;
            }
        }
    }

    [Description("合约状态域")]
    public class InstrumentStatusField : Field
    {
        [Description("合约编码")]
        public FTDInstrumentId InstrumentId;

        [Description("合约交易状态")]
        public FTDInstrumentStatus InstrumentStatus;


        public override ushort FidValue
        {
            get
            {
                return 0x0008;
            }
        }
    }

    [Description("市场状态域")]
    public class MarketStatusField : Field
    {
        [Description("市场编码")]
        public FTDMarketId MarketId;

        [Description("市场交易状态编码")]
        public FTDMarketStatus MarketStatusId;

        [Description("广播模式中的数据序列号")]
        public FTDIntType BroadcastSequenceNo;


        public override ushort FidValue
        {
            get
            {
                return 0x0009;
            }
        }
    }

    [Description("增量成交行情域")]
    public class MarketMatchIncDataField : Field
    {
        [Description("合约编码")]
        public FTDInstrumentId InstrumentId;

        [Description("合约版本号")]
        public FTDInstrumentVersion InstrumentVersion;

        [Description("数量类型")]
        public FTDVolumeType VolumeType;

        [Description("价格")]
        public FTDPrice Price;

        [Description("数量")]
        public FTDVolume Volume;

        [Description("成交双方的性质")]
        public FTDMatchFlag MatchFlag;


        public override ushort FidValue
        {
            get
            {
                return 0x000A;
            }
        }
    }

    [Description("报单操作域")]
    public class OrderActionField : Field
    {
        [Description("报单操作类型码")]
        public FTDActionFlag OrderActionCode;

        [Description("合同编号")]
        public FTDSysOrderId OrderSysId;

        [Description("报单操作本地编号")]
        public FTDLocalId ActionLocalId;

        [Description("合约编码")]
        public FTDInstrumentId InstrumentId;

        [Description("合约版本号")]
        public FTDInstrumentVersion InstrumentVersion;

        [Description("交易员编码")]
        public FTDUserId UserId;


        public override ushort FidValue
        {
            get
            {
                return 0x000B;
            }
        }
    }

    [Description("报单信息域")]
    public class OrderInsertField : Field
    {
        [Description("合同编号")]
        public FTDSysOrderId OrderSysId;

        [Description("委托编号")]
        public FTDLocalId OrderLocalId;

        [Description("交易员编码")]
        public FTDUserId UserId;

        [Description("交易会员编码")]
        public FTDParticipantId ParticipantId;

        [Description("客户编码")]
        public FTDClientId ClientId;

        [Description("合约编码")]
        public FTDInstrumentId InstrumentId;

        [Description("买卖方向")]
        public FTDDirection Direction;

        [Description("开平仓标记")]
        public FTDOffsetFlag OffsetFlag;

        [Description("投保标记")]
        public FTDHedgeFlag HedgeFlag;

        [Description("止损价格")]
        public FTDPrice StopPrice;

        [Description("限价")]
        public FTDPrice LimitPrice;

        [Description("原始总申报数量(以手为单位)")]
        public FTDIntType VolumeTotalOrginal;

        [Description("报单类型")]
        public FTDOrderType OrderType;

        [Description("报单成交属性")]
        public FTDMatchCondition MatchCondition;

        [Description("报单成交时间")]
        public FTDMatchSession MatchSession;

        [Description("有效时间约束")]
        public FTDDate ValidThrough;

        [Description("最小成交量")]
        public FTDVolume MinimalVolume;

        [Description("自动挂起标志")]
        public FTDBoolFlag AutoSuspend;

        [Description("录入时间")]
        public FTDDateTime InsertTime;

        [Description("用户自定义数据。可打印ASCII字符")]
        public FTDMsgRef MessageReference;


        public override ushort FidValue
        {
            get
            {
                return 0x000C;
            }
        }
    }

    [Description("报单行情域")]
    public class MarketOrderDataField : Field
    {
        [Description("合约编码")]
        public FTDInstrumentId InstrumentId;

        [Description("合约版本号")]
        public FTDInstrumentVersion InstrumentVersion;

        [Description("数量类型")]
        public FTDVolumeType VolumeType;

        [Description("买卖方向")]
        public FTDDirection Direction;

        [Description("价格")]
        public FTDPrice Price;

        [Description("数量")]
        public FTDVolume Volume;

        [Description("广播模式中的数据序列号")]
        public FTDIntType BroadcastSequenceNo;


        public override ushort FidValue
        {
            get
            {
                return 0x000D;
            }
        }
    }

    [Description("报单状态域")]
    public class OrderStatusField : Field
    {
        [Description("合同编号")]
        public FTDSysOrderId OrderSysId;

        [Description("委托编号")]
        public FTDLocalId OrderLocalId;

        [Description("交易员编码")]
        public FTDUserId UserId;

        [Description("交易会员编码")]
        public FTDParticipantId ParticipantId;

        [Description("客户编码")]
        public FTDClientId ClientId;

        [Description("合约编码")]
        public FTDInstrumentId InstrumentId;

        [Description("买卖方向")]
        public FTDDirection Direction;

        [Description("开平仓标记")]
        public FTDOffsetFlag OffsetFlag;

        [Description("投保标记")]
        public FTDHedgeFlag HedgeFlag;

        [Description("止损价格")]
        public FTDPrice StopPrice;

        [Description("限价")]
        public FTDPrice LimitPrice;

        [Description("原始总申报数量(以手为单位)")]
        public FTDIntType VolumeTotalOrginal;

        [Description("报单类型")]
        public FTDOrderType OrderType;

        [Description("剩余总申报数量(以手为单位)")]
        public FTDIntType VolumeTotal;

        [Description("报单成交属性")]
        public FTDMatchCondition MatchCondition;

        [Description("报单成交时间")]
        public FTDMatchSession MatchSession;

        [Description("有效时间约束")]
        public FTDDate ValidThrough;

        [Description("最小成交量")]
        public FTDVolume MinimalVolume;

        [Description("自动挂起标志")]
        public FTDBoolFlag AutoSuspend;

        [Description("报单状态")]
        public FTDOrderStatus OrderStatus;

        [Description("录入时间")]
        public FTDDateTime InsertTime;

        [Description("激活时间")]
        public FTDTime ActiveTime;

        [Description("挂起时间")]
        public FTDTime SuspendTime;

        [Description("最后修改时间")]
        public FTDTime UpdateTime;

        [Description("操作交易员编码")]
        public FTDUserId ActiveUserId;

        [Description("保证金")]
        public FTDPrice Margin;

        [Description("强平组号")]
        public FTDLocalId ForceGroupId;

        [Description("最新成交价格")]
        public FTDPrice TradePrice;

        [Description("今成交量")]
        public FTDIntType TradeVolume;

        [Description("用户自定义数据。可打印ASCII字符")]
        public FTDMsgRef MessageReference;


        public override ushort FidValue
        {
            get
            {
                return 0x000E;
            }
        }
    }

    [Description("会员域")]
    public class ParticipantField : Field
    {
        [Description("交易会员编码")]
        public FTDParticipantId ParticipantId;

        [Description("会员名称")]
        public FTDName ParticipantName;

        [Description("会员类型")]
        public FTDParticipantType ParticipantType;

        [Description("会员权限")]
        public FTDTradeRight PartiTrdRight;


        public override ushort FidValue
        {
            get
            {
                return 0x000F;
            }
        }
    }

    [Description("客户持仓域")]
    public class PositionField : Field
    {
        [Description("交易会员编码")]
        public FTDParticipantId ParticipantId;

        [Description("客户编码")]
        public FTDClientId ClientId;

        [Description("合约编码")]
        public FTDInstrumentId InstrumentId;

        [Description("合约版本号")]
        public FTDInstrumentVersion InstrumentVersion;

        [Description("交易委托日期")]
        public FTDDate TradeDate;

        [Description("前买持仓量(保)")]
        public FTDVolume YdBuyHedgePosition;

        [Description("前买持仓量(投)")]
        public FTDVolume YdBuySpecPosition;

        [Description("前卖持仓量(保)")]
        public FTDVolume YdSellHedgePosition;

        [Description("前卖持仓量(投)")]
        public FTDVolume YdSellSpecPosition;

        [Description("买成交量(保)")]
        public FTDVolume BuyHedgeVolume;

        [Description("买成交量(投)")]
        public FTDVolume BuySpecVolume;

        [Description("卖成交量(保)")]
        public FTDVolume SellHedgeVolume;

        [Description("卖成交量(投)")]
        public FTDVolume SellSpecVolume;

        [Description("买开仓量(保)")]
        public FTDVolume BuyHedgePosition;

        [Description("买开仓量(投)")]
        public FTDVolume BuySpecPosition;

        [Description("卖开仓量(保)")]
        public FTDVolume SellHedgePosition;

        [Description("卖开仓量(投)")]
        public FTDVolume SellSpecPosition;

        [Description("买平今量(保)")]
        public FTDVolume BuyOffsHPosition;

        [Description("买平今量(投)")]
        public FTDVolume BuyOffsSPosition;

        [Description("卖平今量(保)")]
        public FTDVolume SellOffsHPosition;

        [Description("卖平今量(投)")]
        public FTDVolume SellOffsSPosition;

        [Description("买平昨量(保)")]
        public FTDVolume YdBuyOffsHPosition;

        [Description("买平昨量(投)")]
        public FTDVolume YdBuyOffsSPosition;

        [Description("卖平昨量(保)")]
        public FTDVolume YdSellOffsHPosition;

        [Description("卖平昨量(投)")]
        public FTDVolume YdSellOffsSPosition;

        [Description("多头开仓冻结持仓手(保)")]
        public FTDVolume LongOpenFrozHPosition;

        [Description("多头开仓冻结持仓手(投)")]
        public FTDVolume LongOpenFrozSPosition;

        [Description("空头开仓冻结持仓手(保)")]
        public FTDVolume ShortOpenFrozHPosition;

        [Description("空头开仓冻结持仓手(投)")]
        public FTDVolume ShortOpenFrozSPosition;

        [Description("多头平仓冻结持仓手(保)")]
        public FTDVolume LongOffsFrozHPosition;

        [Description("多头平仓冻结持仓手(投)")]
        public FTDVolume LongOffsFrozSPosition;

        [Description("空头平仓冻结持仓手(保)")]
        public FTDVolume ShortOffsFrozHPosition;

        [Description("空头平仓冻结持仓手(投)")]
        public FTDVolume ShortOffsFrozSPosition;

        [Description("上日多头平仓冻结持仓手(保)")]
        public FTDVolume YdLongOffsFrozHPosition;

        [Description("上日多头平仓冻结持仓手(投)")]
        public FTDVolume YdLongOffsFrozSPosition;

        [Description("上日空头平仓冻结持仓手(保)")]
        public FTDVolume YdShortOffsFrozHPosition;

        [Description("上日空头平仓冻结持仓手(投)")]
        public FTDVolume YdShortOffsFrozSPosition;


        public override ushort FidValue
        {
            get
            {
                return 0x0010;
            }
        }
    }

    [Description("会员持仓域")]
    public class PPositionField : Field
    {
        [Description("交易会员编码")]
        public FTDParticipantId ParticipantId;

        [Description("合约编码")]
        public FTDInstrumentId InstrumentId;

        [Description("合约版本号")]
        public FTDInstrumentVersion InstrumentVersion;

        [Description("交易委托日期")]
        public FTDDate TradeDate;

        [Description("前买持仓量(保)")]
        public FTDVolume YdBuyHedgePosition;

        [Description("前买持仓量(投)")]
        public FTDVolume YdBuySpecPosition;

        [Description("前卖持仓量(保)")]
        public FTDVolume YdSellHedgePosition;

        [Description("前卖持仓量(投)")]
        public FTDVolume YdSellSpecPosition;

        [Description("买成交量(保)")]
        public FTDVolume BuyHedgeVolume;

        [Description("买成交量(投)")]
        public FTDVolume BuySpecVolume;

        [Description("卖成交量(保)")]
        public FTDVolume SellHedgeVolume;

        [Description("卖成交量(投)")]
        public FTDVolume SellSpecVolume;

        [Description("买开仓量(保)")]
        public FTDVolume BuyHedgePosition;

        [Description("买开仓量(投)")]
        public FTDVolume BuySpecPosition;

        [Description("卖开仓量(保)")]
        public FTDVolume SellHedgePosition;

        [Description("卖开仓量(投)")]
        public FTDVolume SellSpecPosition;

        [Description("买平今量(保)")]
        public FTDVolume BuyOffsHPosition;

        [Description("买平今量(投)")]
        public FTDVolume BuyOffsSPosition;

        [Description("卖平今量(保)")]
        public FTDVolume SellOffsHPosition;

        [Description("卖平今量(投)")]
        public FTDVolume SellOffsSPosition;

        [Description("买平昨量(保)")]
        public FTDVolume YdBuyOffsHPosition;

        [Description("买平昨量(投)")]
        public FTDVolume YdBuyOffsSPosition;

        [Description("卖平昨量(保)")]
        public FTDVolume YdSellOffsHPosition;

        [Description("卖平昨量(投)")]
        public FTDVolume YdSellOffsSPosition;

        [Description("多头开仓冻结持仓手(保)")]
        public FTDVolume LongOpenFrozHPosition;

        [Description("多头开仓冻结持仓手(投)")]
        public FTDVolume LongOpenFrozSPosition;

        [Description("空头开仓冻结持仓手(保)")]
        public FTDVolume ShortOpenFrozHPosition;

        [Description("空头开仓冻结持仓手(投)")]
        public FTDVolume ShortOpenFrozSPosition;

        [Description("多头平仓冻结持仓手(保)")]
        public FTDVolume LongOffsFrozHPosition;

        [Description("多头平仓冻结持仓手(投)")]
        public FTDVolume LongOffsFrozSPosition;

        [Description("空头平仓冻结持仓手(保)")]
        public FTDVolume ShortOffsFrozHPosition;

        [Description("空头平仓冻结持仓手(投)")]
        public FTDVolume ShortOffsFrozSPosition;

        [Description("上日多头平仓冻结持仓手(保)")]
        public FTDVolume YdLongOffsFrozHPosition;

        [Description("上日多头平仓冻结持仓手(投)")]
        public FTDVolume YdLongOffsFrozSPosition;

        [Description("上日空头平仓冻结持仓手(保)")]
        public FTDVolume YdShortOffsFrozHPosition;

        [Description("上日空头平仓冻结持仓手(投)")]
        public FTDVolume YdShortOffsFrozSPosition;


        public override ushort FidValue
        {
            get
            {
                return 0x0011;
            }
        }
    }

    [Description("成交行情变化域")]
    public class MarketMatchDataChgField : Field
    {
        [Description("合约编码")]
        public FTDInstrumentId InstrumentId;

        [Description("合约版本号")]
        public FTDInstrumentVersion InstrumentVersion;

        [Description("开盘价")]
        public FTDPrice OpenPrice;

        [Description("最高价")]
        public FTDPrice HighPrice;

        [Description("最低价")]
        public FTDPrice LowPrice;

        [Description("最新价")]
        public FTDPrice LastPrice;

        [Description("买入价格")]
        public FTDPrice BidPrice;

        [Description("卖出价")]
        public FTDPrice AskPrice;

        [Description("买入数量")]
        public FTDVolume BidLot;

        [Description("卖出数量")]
        public FTDVolume AskLot;

        [Description("数量")]
        public FTDVolume Volume;

        [Description("持仓量")]
        public FTDVolume OpenInterest;


        public override ushort FidValue
        {
            get
            {
                return 0x0012;
            }
        }
    }

    [Description("成交行情域")]
    public class MarketMatchDataField : Field
    {
        [Description("合约编码")]
        public FTDInstrumentId InstrumentId;

        [Description("合约版本号")]
        public FTDInstrumentVersion InstrumentVersion;

        [Description("前收盘价格")]
        public FTDPrice PreClose;

        [Description("前结算价格")]
        public FTDPrice PreSettle;

        [Description("前最后持仓量,双向计算")]
        public FTDVolume PreOpenInterest;

        [Description("开盘价")]
        public FTDPrice OpenPrice;

        [Description("买入价格")]
        public FTDPrice BidPrice;

        [Description("买入数量")]
        public FTDVolume BidLot;

        [Description("卖出价")]
        public FTDPrice AskPrice;

        [Description("卖出数量")]
        public FTDVolume AskLot;

        [Description("最新价")]
        public FTDPrice LastPrice;

        [Description("最后一笔成交手数,双向计算")]
        public FTDVolume LastLot;

        [Description("总成交手数,双向计算")]
        public FTDIntType TradeLot;

        [Description("总成交金额,双向计算")]
        public FTDVolume TradeTurnover;

        [Description("持仓量")]
        public FTDVolume OpenInterest;

        [Description("最高价")]
        public FTDPrice HighPrice;

        [Description("最低价")]
        public FTDPrice LowPrice;

        [Description("收盘价")]
        public FTDPrice ClosePrice;

        [Description("结算价")]
        public FTDPrice SettlePrice;

        [Description("清算价")]
        public FTDPrice ClearPrice;

        [Description("均价")]
        public FTDPrice AveragePrice;

        [Description("历史最高成交价格")]
        public FTDPrice LifeHigh;

        [Description("历史最低成交价格")]
        public FTDPrice LifeLow;

        [Description("涨停板")]
        public FTDPrice HighLimit;

        [Description("跌停板")]
        public FTDPrice LowLimit;

        [Description("总成交量")]
        public FTDVolume TotalVolume;

        [Description("最后修改时间")]
        public FTDTime UpdateTime;

        [Description("是否主动发送成交行情")]
        public FTDBoolFlag MarketMatchDataStatus;

        [Description("发送成交行情记录总数,网络序")]
        public FTDIntType TotalMarketMatchData;

        [Description("广播模式中的数据序列号")]
        public FTDIntType BroadcastSequenceNo;


        public override ushort FidValue
        {
            get
            {
                return 0x0013;
            }
        }
    }

    [Description("客户查询请求域")]
    public class ReqQryClientField : Field
    {
        [Description("交易会员编码")]
        public FTDParticipantId ParticipantId;

        [Description("客户编码")]
        public FTDClientId ClientId;


        public override ushort FidValue
        {
            get
            {
                return 0x0014;
            }
        }
    }

    [Description("会员资金查询域")]
    public class ReqQryDepositField : Field
    {
        [Description("交易会员编码")]
        public FTDParticipantId ParticipantId;


        public override ushort FidValue
        {
            get
            {
                return 0x0015;
            }
        }
    }

    [Description("合约查询请求域")]
    public class ReqQryInstrumentField : Field
    {
        [Description("市场编码")]
        public FTDMarketId MarketId;

        [Description("合约编码")]
        public FTDInstrumentId InstrumentId;


        public override ushort FidValue
        {
            get
            {
                return 0x0016;
            }
        }
    }

    [Description("合约状态查询响应域")]
    public class ReqQryInstrumentStatusField : Field
    {
        [Description("市场编码")]
        public FTDMarketId MarketId;

        [Description("合约编码")]
        public FTDInstrumentId InstrumentId;


        public override ushort FidValue
        {
            get
            {
                return 0x0017;
            }
        }
    }

    [Description("市场查询请求域")]
    public class ReqQryMarketField : Field
    {
        [Description("市场编码")]
        public FTDMarketId MarketId;


        public override ushort FidValue
        {
            get
            {
                return 0x0018;
            }
        }
    }

    [Description("市场状态查询请求域")]
    public class ReqQryMarketStatusField : Field
    {
        [Description("市场编码")]
        public FTDMarketId MarketId;


        public override ushort FidValue
        {
            get
            {
                return 0x0019;
            }
        }
    }

    [Description("报单查询请求域")]
    public class ReqQryOrderField : Field
    {
        [Description("合约编码")]
        public FTDInstrumentId InstrumentId;

        [Description("合约版本号")]
        public FTDInstrumentVersion InstrumentVersion;

        [Description("交易会员编码")]
        public FTDParticipantId ParticipantId;

        [Description("交易员编码")]
        public FTDUserId UserId;

        [Description("客户编码")]
        public FTDClientId ClientId;

        [Description("合同编号")]
        public FTDSysOrderId OrderSysId;


        public override ushort FidValue
        {
            get
            {
                return 0x001A;
            }
        }
    }

    [Description("报单行情查询请求")]
    public class ReqQryMarketOrderDataField : Field
    {
        [Description("合约编码")]
        public FTDInstrumentId InstrumentId;

        [Description("买卖方向")]
        public FTDDirection Direction;


        public override ushort FidValue
        {
            get
            {
                return 0x001B;
            }
        }
    }

    [Description("会员查询请求域")]
    public class ReqQryParticipantField : Field
    {
        [Description("交易会员编码")]
        public FTDParticipantId ParticipantId;


        public override ushort FidValue
        {
            get
            {
                return 0x001C;
            }
        }
    }

    [Description("客户持仓查询请求域")]
    public class ReqQryPositionField : Field
    {
        [Description("交易会员编码")]
        public FTDParticipantId ParticipantId;

        [Description("客户编码")]
        public FTDClientId ClientId;

        [Description("合约编码")]
        public FTDInstrumentId InstrumentId;


        public override ushort FidValue
        {
            get
            {
                return 0x001D;
            }
        }
    }

    [Description("会员持仓查询请求域")]
    public class ReqQryPPositionField : Field
    {
        [Description("交易会员编码")]
        public FTDParticipantId ParticipantId;

        [Description("合约编码")]
        public FTDInstrumentId InstrumentId;


        public override ushort FidValue
        {
            get
            {
                return 0x001E;
            }
        }
    }

    [Description("成交行情查询请求域")]
    public class ReqQryMarketMatchDataField : Field
    {
        [Description("合约编码")]
        public FTDInstrumentId InstrumentId;


        public override ushort FidValue
        {
            get
            {
                return 0x001F;
            }
        }
    }

    [Description("成交查询请求域")]
    public class ReqQryTradeField : Field
    {
        [Description("合约编码")]
        public FTDInstrumentId InstrumentId;

        [Description("合约版本号")]
        public FTDInstrumentVersion InstrumentVersion;

        [Description("交易会员编码")]
        public FTDParticipantId ParticipantId;

        [Description("交易员编码")]
        public FTDUserId UserId;

        [Description("客户编码")]
        public FTDClientId ClientId;

        [Description("合同编号")]
        public FTDSysOrderId OrderSysId;

        [Description("开始时间")]
        public FTDTime StartTime;

        [Description("直到时间")]
        public FTDTime ThroughTime;


        public override ushort FidValue
        {
            get
            {
                return 0x0020;
            }
        }
    }

    [Description("交易员查询域")]
    public class ReqQryUserField : Field
    {
        [Description("交易会员编码")]
        public FTDParticipantId ParticipantId;

        [Description("交易员编码")]
        public FTDUserId UserId;


        public override ushort FidValue
        {
            get
            {
                return 0x0021;
            }
        }
    }

    [Description("交易员在线查询域")]
    public class ReqQryUserLoginField : Field
    {
        [Description("交易会员编码")]
        public FTDParticipantId ParticipantId;

        [Description("交易员编码")]
        public FTDUserId UserId;


        public override ushort FidValue
        {
            get
            {
                return 0x0022;
            }
        }
    }

    [Description("交易员登录请求域")]
    public class ReqUserLoginField : Field
    {
        [Description("数据流名称")]
        public FTDDataFlowFlag DataFlowFlag;

        [Description("交易会员编码")]
        public FTDParticipantId ParticipantId;

        [Description("交易员编码")]
        public FTDUserId UserId;

        [Description("口令")]
        public FTDPassword Password;

        [Description("链路标示")]
        public FTDConnectionReference ConnectionReference;

        [Description("会员应用系统名称")]
        public FTDServerAppName ServerAppName;

        [Description("使用FTD版本号")]
        public FTDProtocolVersion ProtocolVersion;

        [Description("发送监测信号时间间隔")]
        public FTDTimeOut TimeOut;

        [Description("登录者的IP地址")]
        public FTDIpAddr IpAddr;


        public override ushort FidValue
        {
            get
            {
                return 0x0023;
            }
        }
    }

    [Description("交易员退出登录请求域")]
    public class ReqUserLogoutField : Field
    {
        [Description("数据流名称")]
        public FTDDataFlowFlag DataFlowFlag;

        [Description("交易会员编码")]
        public FTDParticipantId ParticipantId;

        [Description("交易员编码")]
        public FTDUserId UserId;


        public override ushort FidValue
        {
            get
            {
                return 0x0024;
            }
        }
    }

    [Description("交易员修改口令请求域")]
    public class ReqUserPasswordUpdateField : Field
    {
        [Description("交易会员编码")]
        public FTDParticipantId ParticipantId;

        [Description("交易员编码")]
        public FTDUserId UserId;

        [Description("新口令")]
        public FTDPassword NewPassword;

        [Description("旧口令")]
        public FTDPassword OldPassword;


        public override ushort FidValue
        {
            get
            {
                return 0x0025;
            }
        }
    }

    [Description("市场域")]
    public class MarketField : Field
    {
        [Description("市场编码")]
        public FTDMarketId MarketId;

        [Description("市场名称")]
        public FTDName MarketName;

        [Description("广播模式序列类别号")]
        public FTDWordType BroadcastSequenceSeries;

        [Description("市场交易类型")]
        public FTDTradeType TradeType;


        public override ushort FidValue
        {
            get
            {
                return 0x0026;
            }
        }
    }

    [Description("交易员登录响应域")]
    public class RspUserLoginField : Field
    {
        [Description("数据流名称")]
        public FTDDataFlowFlag DataFlowFlag;

        [Description("交易会员编码")]
        public FTDParticipantId ParticipantId;

        [Description("交易员编码")]
        public FTDUserId UserId;

        [Description("口令")]
        public FTDPassword Password;

        [Description("交易所系统时间")]
        public FTDDateTime ExchangeDateTime;

        [Description("时区")]
        public FTDTimeSpan TimeSpan;

        [Description("登录者的IP地址")]
        public FTDIpAddr IpAddr;

        [Description("最大报单本地编号")]
        public FTDLocalId MaxOrderLocalId;


        public override ushort FidValue
        {
            get
            {
                return 0x0027;
            }
        }
    }

    [Description("交易员退出登录响应域")]
    public class RspUserLogoutField : Field
    {
        [Description("数据流名称")]
        public FTDDataFlowFlag DataFlowFlag;

        [Description("交易会员编码")]
        public FTDParticipantId ParticipantId;

        [Description("交易员编码")]
        public FTDUserId UserId;

        [Description("交易所系统时间")]
        public FTDDateTime ExchangeDateTime;


        public override ushort FidValue
        {
            get
            {
                return 0x0028;
            }
        }
    }

    [Description("交易员修改口令响应域")]
    public class RspUserPasswordUpdateField : Field
    {
        [Description("交易会员编码")]
        public FTDParticipantId ParticipantId;

        [Description("交易员编码")]
        public FTDUserId UserId;

        [Description("新口令")]
        public FTDPassword NewPassword;


        public override ushort FidValue
        {
            get
            {
                return 0x0029;
            }
        }
    }

    [Description("单边成交回报域")]
    public class TradeInsertSingleField : Field
    {
        [Description("合约编码")]
        public FTDInstrumentId InstrumentId;

        [Description("合约版本号")]
        public FTDInstrumentVersion InstrumentVersion;

        [Description("成交是否被取消")]
        public FTDBoolFlag CancelFlag;

        [Description("取消日期")]
        public FTDDate CancelDate;

        [Description("取消时间")]
        public FTDTime CancelTime;

        [Description("成交编号")]
        public FTDTradeId TradeId;

        [Description("成交日期")]
        public FTDDate MatchDate;

        [Description("成交时间")]
        public FTDTime MatchTime;

        [Description("清算日期")]
        public FTDDate ClearDate;

        [Description("价格")]
        public FTDPrice Price;

        [Description("数量")]
        public FTDVolume Volume;

        [Description("合同编号")]
        public FTDSysOrderId OrderSysId;

        [Description("交易员编码")]
        public FTDUserId UserId;

        [Description("买卖方向")]
        public FTDDirection Direction;

        [Description("开平仓标记")]
        public FTDOffsetFlag OffsetFlag;

        [Description("投保标记")]
        public FTDHedgeFlag HedgeFlag;

        [Description("交易会员编码")]
        public FTDParticipantId ParticipantId;

        [Description("客户编码")]
        public FTDClientId ClientId;

        [Description("委托编号")]
        public FTDLocalId OrderLocalId;


        public override ushort FidValue
        {
            get
            {
                return 0x002A;
            }
        }
    }

    [Description("交易员域")]
    public class UserField : Field
    {
        [Description("交易员编码")]
        public FTDUserId UserId;

        [Description("交易会员编码")]
        public FTDParticipantId ParticipantId;

        [Description("名称")]
        public FTDName Name;

        [Description("是否登录")]
        public FTDBoolFlag IsLogin;

        [Description("交易员状态")]
        public FTDUserStatus UserStatus;

        [Description("交易员类别")]
        public FTDUserType UserType;


        public override ushort FidValue
        {
            get
            {
                return 0x002B;
            }
        }
    }

    [Description("交易员在线域")]
    public class UserLoginField : Field
    {
        [Description("交易会员编码")]
        public FTDParticipantId ParticipantId;

        [Description("交易员编码")]
        public FTDUserId UserId;

        [Description("登录者的IP地址")]
        public FTDIpAddr IpAddr;

        [Description("对话模式在线状态")]
        public FTDBoolFlag DialogStreamStatus;

        [Description("最后一次对话模式登录时间")]
        public FTDDateTime DialogLoginTime;

        [Description("最后一次对话模式退出时间")]
        public FTDDateTime DialogLogoutTime;

        [Description("私有模式的状态")]
        public FTDBoolFlag PrivateStreamStatus;

        [Description("最后一次私有模式登录时间")]
        public FTDDateTime PrivateLoginTime;

        [Description("最后一次私有模式退出时间")]
        public FTDDateTime PrivateLogoutTime;

        [Description("广播模式在线状态")]
        public FTDBoolFlag BroadcastStreamStatus;

        [Description("最后一次广播模式登录时间")]
        public FTDDateTime BroadcastLoginTime;

        [Description("最后一次广播模式退出时间")]
        public FTDDateTime BroadcastLogOutTime;

        [Description("前置机标识")]
        public FTDFrontId FrontId;


        public override ushort FidValue
        {
            get
            {
                return 0x002C;
            }
        }
    }

    [Description("错误响应"), Category("dialog")]
    public class Error : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0001;
            }
        }
    }

    [Description("强制退出"), Category("none")]
    public class ForceExit : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x1005;
            }
        }
    }

    [Description("合约参数改变通知"), Category("broadcast")]
    public class InstrumentChangeNotify : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x2007;
            }
        }
    }

    [Description("合约状态改变通知"), Category("broadcast")]
    public class InstrumentStatusChangeNotify : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x2006;
            }
        }
    }

    [Description("交易所告示广播"), Category("broadcast")]
    public class MarketBulletin : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x2003;
            }
        }
    }

    [Description("市场状态改变通知"), Category("broadcast")]
    public class MarketStatusChangeNotify : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x2005;
            }
        }
    }

    [Description("增量成交行情"), Category("broadcast")]
    public class MarketMatchIncData : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x2002;
            }
        }
    }

    [Description("成交行情"), Category("broadcast")]
    public class MarketMatchData : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x2004;
            }
        }
    }

    [Description("报单确认"), Category("private")]
    public class OrderConfirmation : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x1003;
            }
        }
    }

    [Description("增量报单行情"), Category("broadcast")]
    public class MarketOrderIncData : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x2001;
            }
        }
    }

    [Description("会员告示"), Category("private")]
    public class ParticipantBulletin : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x1002;
            }
        }
    }

    [Description("报单操作请求"), Category("dialog")]
    public class ReqOrderAction : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0004;
            }
        }
    }

    [Description("报单录入"), Category("dialog")]
    public class ReqOrderInsert : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0003;
            }
        }
    }

    [Description("客户信息查询"), Category("dialog")]
    public class ReqQryClient : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x000C;
            }
        }
    }

    [Description("会员资金查询"), Category("dialog")]
    public class ReqQryDeposit : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0008;
            }
        }
    }

    [Description("合约查询"), Category("dialog")]
    public class ReqQryInstrument : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0005;
            }
        }
    }

    [Description("查询合约交易状态请求"), Category("dialog")]
    public class ReqQryInstrumentStatus : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x000E;
            }
        }
    }

    [Description("市场查询请求"), Category("dialog")]
    public class ReqQryMarket : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x000B;
            }
        }
    }

    [Description("查询市场交易状态请求"), Category("dialog")]
    public class ReqQryMarketStatus : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x000D;
            }
        }
    }

    [Description("报单查询"), Category("dialog")]
    public class ReqQryOrder : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0006;
            }
        }
    }

    [Description("报单行情查询请求"), Category("dialog")]
    public class ReqQryMarketOrderData : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0012;
            }
        }
    }

    [Description("会员信息查询"), Category("dialog")]
    public class ReqQryParticipant : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0013;
            }
        }
    }

    [Description("会员客户持仓查询"), Category("dialog")]
    public class ReqQryPosition : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x000A;
            }
        }
    }

    [Description("会员持仓查询"), Category("dialog")]
    public class ReqQryPPosition : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0009;
            }
        }
    }

    [Description("成交行情查询"), Category("dialog")]
    public class ReqQryMarketMatchData : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0002;
            }
        }
    }

    [Description("成交单查询"), Category("dialog")]
    public class ReqQryTrade : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0007;
            }
        }
    }

    [Description("查询交易员请求"), Category("dialog")]
    public class ReqQryUser : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0014;
            }
        }
    }

    [Description("交易员在线查询"), Category("dialog")]
    public class ReqQryUserLogin : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0015;
            }
        }
    }

    [Description("交易员登录请求"), Category("none")]
    public class ReqUserLogin : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0016;
            }
        }
    }

    [Description("交易员登录退出"), Category("none")]
    public class ReqUserLogout : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0017;
            }
        }
    }

    [Description("交易员修改密码"), Category("dialog")]
    public class ReqUserPasswordUpdate : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0018;
            }
        }
    }

    [Description("交易员在线查询应答"), Category("dialog")]
    public class RspQryUserLogin : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0015;
            }
        }
    }

    [Description("报单操作应答"), Category("dialog")]
    public class RspOrderAction : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0004;
            }
        }
    }

    [Description("报单应答"), Category("dialog")]
    public class RspOrderInsert : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0003;
            }
        }
    }

    [Description("客户信息查询应答"), Category("dialog")]
    public class RspQryClient : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x000C;
            }
        }
    }

    [Description("会员资金查询应答"), Category("dialog")]
    public class RspQryDeposit : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0008;
            }
        }
    }

    [Description("合约查询应答"), Category("dialog")]
    public class RspQryInstrument : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0005;
            }
        }
    }

    [Description("查询合约交易状态应答"), Category("dialog")]
    public class RspQryInstrumentStatus : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x000E;
            }
        }
    }

    [Description("市场查询应答"), Category("dialog")]
    public class RspQryMarket : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x000B;
            }
        }
    }

    [Description("查询市场交易状态应答"), Category("dialog")]
    public class RspQryMarketStatus : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x000D;
            }
        }
    }

    [Description("报单查询应答"), Category("dialog")]
    public class RspQryOrder : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0006;
            }
        }
    }

    [Description("报单行情查询应答"), Category("dialog")]
    public class RspQryMarketOrderData : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0012;
            }
        }
    }

    [Description("会员信息查询应答"), Category("dialog")]
    public class RspQryParticipant : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0013;
            }
        }
    }

    [Description("会员客户持仓查询应答"), Category("dialog")]
    public class RspQryPosition : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x000A;
            }
        }
    }

    [Description("会员持仓查询应答"), Category("dialog")]
    public class RspQryPPosition : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0009;
            }
        }
    }

    [Description("成交行情查询应答"), Category("dialog")]
    public class RspQryMarketMatchData : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0002;
            }
        }
    }

    [Description("成交单查询应答"), Category("dialog")]
    public class RspQryTrade : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0007;
            }
        }
    }

    [Description("查询交易员应答"), Category("dialog")]
    public class RspQryUser : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0014;
            }
        }
    }

    [Description("交易员登录应答"), Category("none")]
    public class RspUserLogin : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0016;
            }
        }
    }

    [Description("交易员登录退出应答"), Category("none")]
    public class RspUserLogout : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0017;
            }
        }
    }

    [Description("交易员修改密码应答"), Category("dialog")]
    public class RspUserPasswordUpdate : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x0018;
            }
        }
    }

    [Description("单边成交回报"), Category("private")]
    public class TradeInsertSingle : Packet
    {
        public override ushort TId
        {
            get
            {
                return 0x1001;
            }
        }
    }

}
