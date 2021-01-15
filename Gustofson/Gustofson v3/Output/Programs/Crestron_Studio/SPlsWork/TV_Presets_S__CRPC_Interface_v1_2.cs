using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;
using Crestron.CRPC.CIPDirectTransport;
using Crestron.CRPC;
using Crestron.CRPC.Common;
using CRPCConnectionHelper;
using Crestron.TV_Presets.User_Interfaces;
using Crestron.TV_Presets.File_Manager;
using Crestron.TV_Presets;
using AppHelperClasses;
using Crestron.AppHelperClasses;

namespace CrestronModule_TV_PRESETS_S__CRPC_INTERFACE_V1_2
{
    public class CrestronModuleClass_TV_PRESETS_S__CRPC_INTERFACE_V1_2 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.AnalogInput PROFILESELECTED;
        Crestron.Logos.SplusObjects.AnalogInput ETHERNETADAPTERID;
        Crestron.Logos.SplusObjects.AnalogInput CIP_PORT;
        Crestron.Logos.SplusObjects.BufferInput FROMTVPRESETS;
        Crestron.Logos.SplusObjects.StringOutput TOTVPRESETS;
        Crestron.Logos.SplusObjects.StringOutput CHANNELSELECTED;
        Crestron.TV_Presets.User_Interfaces.TVPresetCrpcInitialization TVPRESETINITIALIZATION;
        Crestron.TV_Presets.User_Interfaces.TVPresetsCrpcInterface TVPRESETCRPC;
        ushort INITIALIZED = 0;
        CrestronString TAGIN;
        private void REGDELEGATES (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 43;
            // RegisterDelegate( TVPRESETINITIALIZATION , MESSAGEOUT , SENDSTREAM ) 
            TVPRESETINITIALIZATION .MessageOut  = SENDSTREAM; ; 
            __context__.SourceCodeLine = 44;
            // RegisterDelegate( TVPRESETCRPC , CHANNELSELECTED , CHANNELSELECTEDSPLUS ) 
            TVPRESETCRPC .ChannelSelected  = CHANNELSELECTEDSPLUS; ; 
            
            }
            
        public void SENDSTREAM ( SimplSharpString STREAMOUT ) 
            { 
            CrestronString S;
            S  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 50;
                S  =  ( STREAMOUT  .ToString()  )  .ToString() ; 
                __context__.SourceCodeLine = 52;
                TOTVPRESETS  .UpdateValue ( S  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void CHANNELSELECTEDSPLUS ( SimplSharpString CHANNEL ) 
            { 
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 57;
                CHANNELSELECTED  .UpdateValue ( CHANNEL  .ToString()  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        object PROFILESELECTED_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 62;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( PROFILESELECTED  .UshortValue > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 63;
                    TVPRESETCRPC . SelectProfile ( (ushort)( (PROFILESELECTED  .UshortValue - 1) )) ; 
                    }
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object FROMTVPRESETS_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            CrestronString CLIENTCRPCDATA;
            CLIENTCRPCDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 65534, this );
            
            CrestronString TEMPSTRING;
            TEMPSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 65534, this );
            
            CrestronString TEMPLENGTH;
            TEMPLENGTH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
            
            uint COMMANDLENGTH = 0;
            
            CrestronString HEADER;
            HEADER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            
            
            __context__.SourceCodeLine = 74;
            if ( Functions.TestForTrue  ( ( INITIALIZED)  ) ) 
                { 
                __context__.SourceCodeLine = 76;
                while ( Functions.TestForTrue  ( ( 1)  ) ) 
                    { 
                    __context__.SourceCodeLine = 78;
                    HEADER  .UpdateValue ( Functions.Gather ( 8, FROMTVPRESETS )  ) ; 
                    __context__.SourceCodeLine = 80;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Atoi( Functions.Left( HEADER , (int)( 1 ) ) ) == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 82;
                        GenerateUserError ( "CRPC Version 1 Detected.  Please Upgrade Core 3 Controls.") ; 
                        __context__.SourceCodeLine = 83;
                        Functions.ClearBuffer ( FROMTVPRESETS ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 85;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Atoi( Functions.Left( HEADER , (int)( 1 ) ) ) == 2))  ) ) 
                            { 
                            __context__.SourceCodeLine = 88;
                            TEMPLENGTH  .UpdateValue ( Functions.Right ( HEADER ,  (int) ( 4 ) )  ) ; 
                            __context__.SourceCodeLine = 89;
                            COMMANDLENGTH = (uint) ( Functions.HextoL( TEMPLENGTH ) ) ; 
                            __context__.SourceCodeLine = 90;
                            TEMPSTRING  .UpdateValue ( Functions.Gather ( Functions.LowWord( (uint)( COMMANDLENGTH ) ), FROMTVPRESETS )  ) ; 
                            __context__.SourceCodeLine = 92;
                            TEMPSTRING  .UpdateValue ( HEADER + TEMPSTRING  ) ; 
                            __context__.SourceCodeLine = 93;
                            if ( Functions.TestForTrue  ( ( INITIALIZED)  ) ) 
                                { 
                                __context__.SourceCodeLine = 95;
                                CLIENTCRPCDATA  .UpdateValue ( Functions.Right ( TEMPSTRING ,  (int) ( (Functions.Length( TEMPSTRING ) - 3) ) )  ) ; 
                                __context__.SourceCodeLine = 96;
                                MakeString ( TEMPSTRING , "{0:d}{1}{2}", (short)2, TAGIN , CLIENTCRPCDATA ) ; 
                                __context__.SourceCodeLine = 97;
                                TVPRESETINITIALIZATION . MessageIn ( TEMPSTRING .ToString()) ; 
                                } 
                            
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 102;
                            GenerateUserError ( "TV Presets CRPC UI: Unable to process client CRPC message.  Version: {0:d}, Header:{1}", (short)Functions.Atoi( Functions.Left( HEADER , (int)( 1 ) ) ), HEADER ) ; 
                            __context__.SourceCodeLine = 103;
                            Functions.ClearBuffer ( FROMTVPRESETS ) ; 
                            } 
                        
                        }
                    
                    __context__.SourceCodeLine = 76;
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 110;
                Functions.ClearBuffer ( FROMTVPRESETS ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
public override object FunctionMain (  object __obj__ ) 
    { 
    int GENERATEDTAG = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 118;
        INITIALIZED = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 119;
        REGDELEGATES (  __context__  ) ; 
        __context__.SourceCodeLine = 121;
        GENERATEDTAG = (int) ( CRPCJoinTagGenerator.GetNewTag() ) ; 
        __context__.SourceCodeLine = 122;
        MakeString ( TAGIN , "{0:X2}", GENERATEDTAG) ; 
        __context__.SourceCodeLine = 123;
        TVPRESETCRPC . SelectProfile ( (ushort)( 0 )) ; 
        __context__.SourceCodeLine = 124;
        TVPRESETCRPC . LoadURLs ( ) ; 
        __context__.SourceCodeLine = 125;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 126;
        TVPRESETINITIALIZATION . InitializeTVPresetsCrpc ( (ushort)( CIP_PORT  .UshortValue ), (ushort)( ETHERNETADAPTERID  .UshortValue ), TVPRESETCRPC) ; 
        __context__.SourceCodeLine = 127;
        TVPRESETCRPC . adapterID = (ushort) ( ETHERNETADAPTERID  .UshortValue ) ; 
        __context__.SourceCodeLine = 128;
        INITIALIZED = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    TAGIN  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
    
    PROFILESELECTED = new Crestron.Logos.SplusObjects.AnalogInput( PROFILESELECTED__AnalogSerialInput__, this );
    m_AnalogInputList.Add( PROFILESELECTED__AnalogSerialInput__, PROFILESELECTED );
    
    ETHERNETADAPTERID = new Crestron.Logos.SplusObjects.AnalogInput( ETHERNETADAPTERID__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ETHERNETADAPTERID__AnalogSerialInput__, ETHERNETADAPTERID );
    
    CIP_PORT = new Crestron.Logos.SplusObjects.AnalogInput( CIP_PORT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CIP_PORT__AnalogSerialInput__, CIP_PORT );
    
    TOTVPRESETS = new Crestron.Logos.SplusObjects.StringOutput( TOTVPRESETS__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TOTVPRESETS__AnalogSerialOutput__, TOTVPRESETS );
    
    CHANNELSELECTED = new Crestron.Logos.SplusObjects.StringOutput( CHANNELSELECTED__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CHANNELSELECTED__AnalogSerialOutput__, CHANNELSELECTED );
    
    FROMTVPRESETS = new Crestron.Logos.SplusObjects.BufferInput( FROMTVPRESETS__AnalogSerialInput__, 65534, this );
    m_StringInputList.Add( FROMTVPRESETS__AnalogSerialInput__, FROMTVPRESETS );
    
    
    PROFILESELECTED.OnAnalogChange.Add( new InputChangeHandlerWrapper( PROFILESELECTED_OnChange_0, false ) );
    FROMTVPRESETS.OnSerialChange.Add( new InputChangeHandlerWrapper( FROMTVPRESETS_OnChange_1, true ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    TVPRESETINITIALIZATION  = new Crestron.TV_Presets.User_Interfaces.TVPresetCrpcInitialization();
    TVPRESETCRPC  = new Crestron.TV_Presets.User_Interfaces.TVPresetsCrpcInterface();
    
    
}

public CrestronModuleClass_TV_PRESETS_S__CRPC_INTERFACE_V1_2 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint PROFILESELECTED__AnalogSerialInput__ = 0;
const uint ETHERNETADAPTERID__AnalogSerialInput__ = 1;
const uint CIP_PORT__AnalogSerialInput__ = 2;
const uint FROMTVPRESETS__AnalogSerialInput__ = 3;
const uint TOTVPRESETS__AnalogSerialOutput__ = 0;
const uint CHANNELSELECTED__AnalogSerialOutput__ = 1;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
