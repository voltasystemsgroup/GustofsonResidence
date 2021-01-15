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
using Crestron.Rio.DataStructures.Media.UserInterfaces;
using Crestron.Rio.DataStructures.Media.Routing;
using Crestron.Rio.DataStructures.Media;
using Crestron.Rio.DataStructures.Media.DistributionComponents;
using Crestron.Rio.DataStructures.Media.DeviceManagement;
using Crestron.MediaSubsystem.Common;
using Crestron.Rio.System;
using Crestron.Rio.DataStructures;

namespace CrestronModule_CSR_MEDIA_SOURCE_SIMPL__INTERFACE_V1_0_0
{
    public class CrestronModuleClass_CSR_MEDIA_SOURCE_SIMPL__INTERFACE_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        Crestron.Logos.SplusObjects.AnalogInput SOURCEID;
        Crestron.Logos.SplusObjects.StringInput NOWPLAYINGLINE1;
        Crestron.Logos.SplusObjects.StringInput NOWPLAYINGLINE2;
        Crestron.Logos.SplusObjects.DigitalOutput SOURCEISINUSE;
        Crestron.Logos.SplusObjects.DigitalOutput SOURCESELECTED;
        Crestron.Logos.SplusObjects.DigitalOutput NEXT1;
        Crestron.Logos.SplusObjects.DigitalOutput NEXT2;
        Crestron.Logos.SplusObjects.DigitalOutput PREVIOUS1;
        Crestron.Logos.SplusObjects.DigitalOutput PREVIOUS2;
        Crestron.Logos.SplusObjects.DigitalOutput START;
        Crestron.Logos.SplusObjects.DigitalOutput STOP;
        Crestron.Logos.SplusObjects.DigitalOutput REPRESS;
        Crestron.Rio.DataStructures.Media.DistributionComponents.MediaSourceSSharpComponent SIMPLSHARPCOMPONENT;
        ushort SOURCEIDSET = 0;
        ushort MEDIASUBSYSTEMINITIALIZED = 0;
        object SOURCEID_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 51;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SOURCEIDSET == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 53;
                    SOURCEIDSET = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 55;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MEDIASUBSYSTEMINITIALIZED == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 57;
                        SIMPLSHARPCOMPONENT . AssociateSSharpComponent ( (int)( SOURCEID  .IntValue )) ; 
                        __context__.SourceCodeLine = 59;
                        SIMPLSHARPCOMPONENT . SetNowPlayingLine1 ( NOWPLAYINGLINE1 .ToString()) ; 
                        __context__.SourceCodeLine = 60;
                        SIMPLSHARPCOMPONENT . SetNowPlayingLine2 ( NOWPLAYINGLINE2 .ToString()) ; 
                        } 
                    
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object NOWPLAYINGLINE1_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 67;
            SIMPLSHARPCOMPONENT . SetNowPlayingLine1 ( NOWPLAYINGLINE1 .ToString()) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object NOWPLAYINGLINE2_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 72;
        SIMPLSHARPCOMPONENT . SetNowPlayingLine2 ( NOWPLAYINGLINE2 .ToString()) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void UPDATESOURCEUSAGECALLBACK ( int USAGESTATE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 77;
        SOURCEISINUSE  .Value = (ushort) ( USAGESTATE ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESOURCESELECTEDCALLBACK ( ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 82;
        SOURCESELECTED  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 83;
        SOURCESELECTED  .Value = (ushort) ( 0 ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESOURCENEXT1COMMANDCALLBACK ( int COMMANDSTATE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 88;
        NEXT1  .Value = (ushort) ( COMMANDSTATE ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESOURCENEXT2COMMANDCALLBACK ( int COMMANDSTATE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 93;
        NEXT2  .Value = (ushort) ( COMMANDSTATE ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESOURCEPREVIOUS1COMMANDCALLBACK ( int COMMANDSTATE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 98;
        PREVIOUS1  .Value = (ushort) ( COMMANDSTATE ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESOURCEPREVIOUS2COMMANDCALLBACK ( int COMMANDSTATE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 103;
        PREVIOUS2  .Value = (ushort) ( COMMANDSTATE ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESOURCEREPRESSCOMMANDCALLBACK ( int COMMANDSTATE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 108;
        REPRESS  .Value = (ushort) ( COMMANDSTATE ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESOURCESTARTCOMMANDCALLBACK ( ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 113;
        START  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 114;
        START  .Value = (ushort) ( 0 ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESOURCESTOPCOMMANDCALLBACK ( ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 119;
        STOP  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 120;
        STOP  .Value = (ushort) ( 0 ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void MEDIAINITIALIZATIONCOMPLETEEVENTHANDLER ( object __sender__ /*EventArgs ARGS */) 
    { 
    EventArgs  ARGS  = (EventArgs )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 125;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATESOURCEUSAGE , UPDATESOURCEUSAGECALLBACK ) 
        SIMPLSHARPCOMPONENT .updateSourceUsage  = UPDATESOURCEUSAGECALLBACK; ; 
        __context__.SourceCodeLine = 126;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATESOURCESELECTED , UPDATESOURCESELECTEDCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateSourceSelected  = UPDATESOURCESELECTEDCALLBACK; ; 
        __context__.SourceCodeLine = 127;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATESOURCENEXT1COMMAND , UPDATESOURCENEXT1COMMANDCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateSourceNext1Command  = UPDATESOURCENEXT1COMMANDCALLBACK; ; 
        __context__.SourceCodeLine = 128;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATESOURCENEXT2COMMAND , UPDATESOURCENEXT2COMMANDCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateSourceNext2Command  = UPDATESOURCENEXT2COMMANDCALLBACK; ; 
        __context__.SourceCodeLine = 129;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATESOURCEPREVIOUS1COMMAND , UPDATESOURCEPREVIOUS1COMMANDCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateSourcePrevious1Command  = UPDATESOURCEPREVIOUS1COMMANDCALLBACK; ; 
        __context__.SourceCodeLine = 130;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATESOURCEPREVIOUS2COMMAND , UPDATESOURCEPREVIOUS2COMMANDCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateSourcePrevious2Command  = UPDATESOURCEPREVIOUS2COMMANDCALLBACK; ; 
        __context__.SourceCodeLine = 131;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATESOURCEREPRESSCOMMAND , UPDATESOURCEREPRESSCOMMANDCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateSourceRePressCommand  = UPDATESOURCEREPRESSCOMMANDCALLBACK; ; 
        __context__.SourceCodeLine = 132;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATESOURCESTARTCOMMAND , UPDATESOURCESTARTCOMMANDCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateSourceStartCommand  = UPDATESOURCESTARTCOMMANDCALLBACK; ; 
        __context__.SourceCodeLine = 133;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATESOURCESTOPCOMMAND , UPDATESOURCESTOPCOMMANDCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateSourceStopCommand  = UPDATESOURCESTOPCOMMANDCALLBACK; ; 
        __context__.SourceCodeLine = 135;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SOURCEIDSET == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 137;
            SIMPLSHARPCOMPONENT . AssociateSSharpComponent ( (int)( SOURCEID  .IntValue )) ; 
            __context__.SourceCodeLine = 139;
            SIMPLSHARPCOMPONENT . SetNowPlayingLine1 ( NOWPLAYINGLINE1 .ToString()) ; 
            __context__.SourceCodeLine = 140;
            SIMPLSHARPCOMPONENT . SetNowPlayingLine2 ( NOWPLAYINGLINE2 .ToString()) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 144;
            MEDIASUBSYSTEMINITIALIZED = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 150;
        SOURCEISINUSE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 151;
        SOURCESELECTED  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 152;
        NEXT1  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 153;
        NEXT2  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 154;
        PREVIOUS1  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 155;
        PREVIOUS2  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 156;
        START  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 157;
        STOP  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 158;
        REPRESS  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 160;
        // RegisterEvent( MediaSubsystem , MEDIAINITIALIZATIONCOMPLETEEVENT , MEDIAINITIALIZATIONCOMPLETEEVENTHANDLER ) 
        try { g_criticalSection.Enter(); MediaSubsystem .MediaInitializationCompleteEvent  += MEDIAINITIALIZATIONCOMPLETEEVENTHANDLER; } finally { g_criticalSection.Leave(); }
        ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    SOURCEISINUSE = new Crestron.Logos.SplusObjects.DigitalOutput( SOURCEISINUSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SOURCEISINUSE__DigitalOutput__, SOURCEISINUSE );
    
    SOURCESELECTED = new Crestron.Logos.SplusObjects.DigitalOutput( SOURCESELECTED__DigitalOutput__, this );
    m_DigitalOutputList.Add( SOURCESELECTED__DigitalOutput__, SOURCESELECTED );
    
    NEXT1 = new Crestron.Logos.SplusObjects.DigitalOutput( NEXT1__DigitalOutput__, this );
    m_DigitalOutputList.Add( NEXT1__DigitalOutput__, NEXT1 );
    
    NEXT2 = new Crestron.Logos.SplusObjects.DigitalOutput( NEXT2__DigitalOutput__, this );
    m_DigitalOutputList.Add( NEXT2__DigitalOutput__, NEXT2 );
    
    PREVIOUS1 = new Crestron.Logos.SplusObjects.DigitalOutput( PREVIOUS1__DigitalOutput__, this );
    m_DigitalOutputList.Add( PREVIOUS1__DigitalOutput__, PREVIOUS1 );
    
    PREVIOUS2 = new Crestron.Logos.SplusObjects.DigitalOutput( PREVIOUS2__DigitalOutput__, this );
    m_DigitalOutputList.Add( PREVIOUS2__DigitalOutput__, PREVIOUS2 );
    
    START = new Crestron.Logos.SplusObjects.DigitalOutput( START__DigitalOutput__, this );
    m_DigitalOutputList.Add( START__DigitalOutput__, START );
    
    STOP = new Crestron.Logos.SplusObjects.DigitalOutput( STOP__DigitalOutput__, this );
    m_DigitalOutputList.Add( STOP__DigitalOutput__, STOP );
    
    REPRESS = new Crestron.Logos.SplusObjects.DigitalOutput( REPRESS__DigitalOutput__, this );
    m_DigitalOutputList.Add( REPRESS__DigitalOutput__, REPRESS );
    
    SOURCEID = new Crestron.Logos.SplusObjects.AnalogInput( SOURCEID__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SOURCEID__AnalogSerialInput__, SOURCEID );
    
    NOWPLAYINGLINE1 = new Crestron.Logos.SplusObjects.StringInput( NOWPLAYINGLINE1__AnalogSerialInput__, 255, this );
    m_StringInputList.Add( NOWPLAYINGLINE1__AnalogSerialInput__, NOWPLAYINGLINE1 );
    
    NOWPLAYINGLINE2 = new Crestron.Logos.SplusObjects.StringInput( NOWPLAYINGLINE2__AnalogSerialInput__, 255, this );
    m_StringInputList.Add( NOWPLAYINGLINE2__AnalogSerialInput__, NOWPLAYINGLINE2 );
    
    
    SOURCEID.OnAnalogChange.Add( new InputChangeHandlerWrapper( SOURCEID_OnChange_0, false ) );
    NOWPLAYINGLINE1.OnSerialChange.Add( new InputChangeHandlerWrapper( NOWPLAYINGLINE1_OnChange_1, false ) );
    NOWPLAYINGLINE2.OnSerialChange.Add( new InputChangeHandlerWrapper( NOWPLAYINGLINE2_OnChange_2, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    SIMPLSHARPCOMPONENT  = new Crestron.Rio.DataStructures.Media.DistributionComponents.MediaSourceSSharpComponent();
    
    
}

public CrestronModuleClass_CSR_MEDIA_SOURCE_SIMPL__INTERFACE_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint SOURCEID__AnalogSerialInput__ = 0;
const uint NOWPLAYINGLINE1__AnalogSerialInput__ = 1;
const uint NOWPLAYINGLINE2__AnalogSerialInput__ = 2;
const uint SOURCEISINUSE__DigitalOutput__ = 0;
const uint SOURCESELECTED__DigitalOutput__ = 1;
const uint NEXT1__DigitalOutput__ = 2;
const uint NEXT2__DigitalOutput__ = 3;
const uint PREVIOUS1__DigitalOutput__ = 4;
const uint PREVIOUS2__DigitalOutput__ = 5;
const uint START__DigitalOutput__ = 6;
const uint STOP__DigitalOutput__ = 7;
const uint REPRESS__DigitalOutput__ = 8;

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
