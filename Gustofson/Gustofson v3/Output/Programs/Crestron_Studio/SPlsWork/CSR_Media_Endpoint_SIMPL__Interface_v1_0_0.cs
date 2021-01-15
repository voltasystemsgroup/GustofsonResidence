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

namespace CrestronModule_CSR_MEDIA_ENDPOINT_SIMPL__INTERFACE_V1_0_0
{
    public class CrestronModuleClass_CSR_MEDIA_ENDPOINT_SIMPL__INTERFACE_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput TURNENDPOINTON;
        Crestron.Logos.SplusObjects.AnalogInput ENDPOINTID;
        Crestron.Logos.SplusObjects.AnalogInput SETENDPOINTSOURCE;
        Crestron.Logos.SplusObjects.DigitalOutput TURNENDPOINTHWOFF;
        Crestron.Logos.SplusObjects.DigitalOutput ENDPOINTON_FB;
        Crestron.Logos.SplusObjects.DigitalOutput ENDPOINTOFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput GROUPVOLUMEUP;
        Crestron.Logos.SplusObjects.DigitalOutput GROUPVOLUMEDOWN;
        Crestron.Logos.SplusObjects.AnalogOutput ENDPOINTSOURCE_FB;
        Crestron.Logos.SplusObjects.StringOutput ENDPOINTNAME;
        Crestron.Logos.SplusObjects.StringOutput ENDPOINTSOURCENAME;
        Crestron.Logos.SplusObjects.StringOutput ENDPOINTSOURCENOWPLAYINGLINE1;
        Crestron.Logos.SplusObjects.StringOutput ENDPOINTSOURCENOWPLAYINGLINE2;
        Crestron.Rio.DataStructures.Media.DistributionComponents.EndpointSSharpComponent SIMPLSHARPCOMPONENT;
        ushort ENDPOINTIDSET = 0;
        ushort MEDIASUBSYSTEMINITIALIZED = 0;
        object TURNENDPOINTON_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 53;
                SIMPLSHARPCOMPONENT . TurnEndpointOn ( ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object ENDPOINTID_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 58;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ENDPOINTIDSET == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 60;
                ENDPOINTIDSET = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 62;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MEDIASUBSYSTEMINITIALIZED == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 63;
                    SIMPLSHARPCOMPONENT . AssociateSSharpComponent ( (int)( ENDPOINTID  .IntValue )) ; 
                    }
                
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SETENDPOINTSOURCE_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 69;
        SIMPLSHARPCOMPONENT . SetEndpointSource ( (int)( SETENDPOINTSOURCE  .IntValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void TURNHWOFFCALLBACK ( ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 74;
        TURNENDPOINTHWOFF  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 75;
        TURNENDPOINTHWOFF  .Value = (ushort) ( 0 ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATENAMECALLBACK ( SimplSharpString ENDPOINTNAMEFROMSSHARP ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 80;
        ENDPOINTNAME  .UpdateValue ( ENDPOINTNAMEFROMSSHARP  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESELECTEDSOURCEIDCALLBACK ( int SOURCEID ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 85;
        ENDPOINTSOURCE_FB  .Value = (ushort) ( SOURCEID ) ; 
        __context__.SourceCodeLine = 87;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SOURCEID == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 89;
            ENDPOINTON_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 90;
            ENDPOINTOFF_FB  .Value = (ushort) ( 1 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 94;
            ENDPOINTOFF_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 95;
            ENDPOINTON_FB  .Value = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESELECTEDSOURCENAMECALLBACK ( SimplSharpString SOURCENAMEFROMSSHARP ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 101;
        ENDPOINTSOURCENAME  .UpdateValue ( SOURCENAMEFROMSSHARP  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATENOWPLAYINGLINE1CALLBACK ( SimplSharpString NOWPLAYINGINFORMATION ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 106;
        ENDPOINTSOURCENOWPLAYINGLINE1  .UpdateValue ( NOWPLAYINGINFORMATION  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATENOWPLAYINGLINE2CALLBACK ( SimplSharpString NOWPLAYINGINFORMATION ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 111;
        ENDPOINTSOURCENOWPLAYINGLINE2  .UpdateValue ( NOWPLAYINGINFORMATION  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEGROUPVOLUMEUPCALLBACK ( int VOLUMEADJUSTMENTSTATE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 116;
        GROUPVOLUMEUP  .Value = (ushort) ( VOLUMEADJUSTMENTSTATE ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEGROUPVOLUMEDOWNCALLBACK ( int VOLUMEADJUSTMENTSTATE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 121;
        GROUPVOLUMEDOWN  .Value = (ushort) ( VOLUMEADJUSTMENTSTATE ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void MEDIAINITIALIZATIONCOMPLETEEVENTHANDLER ( object __sender__ /*EventArgs ARGS */) 
    { 
    EventArgs  ARGS  = (EventArgs )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 126;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , TURNHWOFF , TURNHWOFFCALLBACK ) 
        SIMPLSHARPCOMPONENT .turnHWOff  = TURNHWOFFCALLBACK; ; 
        __context__.SourceCodeLine = 128;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATENAME , UPDATENAMECALLBACK ) 
        SIMPLSHARPCOMPONENT .updateName  = UPDATENAMECALLBACK; ; 
        __context__.SourceCodeLine = 129;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATESELECTEDSOURCEID , UPDATESELECTEDSOURCEIDCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateSelectedSourceID  = UPDATESELECTEDSOURCEIDCALLBACK; ; 
        __context__.SourceCodeLine = 130;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATESELECTEDSOURCENAME , UPDATESELECTEDSOURCENAMECALLBACK ) 
        SIMPLSHARPCOMPONENT .updateSelectedSourceName  = UPDATESELECTEDSOURCENAMECALLBACK; ; 
        __context__.SourceCodeLine = 131;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATENOWPLAYINGLINE1 , UPDATENOWPLAYINGLINE1CALLBACK ) 
        SIMPLSHARPCOMPONENT .updateNowPlayingLine1  = UPDATENOWPLAYINGLINE1CALLBACK; ; 
        __context__.SourceCodeLine = 132;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATENOWPLAYINGLINE2 , UPDATENOWPLAYINGLINE2CALLBACK ) 
        SIMPLSHARPCOMPONENT .updateNowPlayingLine2  = UPDATENOWPLAYINGLINE2CALLBACK; ; 
        __context__.SourceCodeLine = 134;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATEGROUPVOLUMEUP , UPDATEGROUPVOLUMEUPCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateGroupVolumeUp  = UPDATEGROUPVOLUMEUPCALLBACK; ; 
        __context__.SourceCodeLine = 135;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATEGROUPVOLUMEDOWN , UPDATEGROUPVOLUMEDOWNCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateGroupVolumeDown  = UPDATEGROUPVOLUMEDOWNCALLBACK; ; 
        __context__.SourceCodeLine = 137;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ENDPOINTIDSET == 1))  ) ) 
            {
            __context__.SourceCodeLine = 138;
            SIMPLSHARPCOMPONENT . AssociateSSharpComponent ( (int)( ENDPOINTID  .IntValue )) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 140;
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
        
        __context__.SourceCodeLine = 145;
        ENDPOINTON_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 146;
        ENDPOINTOFF_FB  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 147;
        GROUPVOLUMEUP  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 148;
        GROUPVOLUMEDOWN  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 149;
        ENDPOINTSOURCE_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 151;
        ENDPOINTNAME  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 152;
        ENDPOINTSOURCENAME  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 153;
        ENDPOINTSOURCENOWPLAYINGLINE1  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 154;
        ENDPOINTSOURCENOWPLAYINGLINE2  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 156;
        ENDPOINTIDSET = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 157;
        MEDIASUBSYSTEMINITIALIZED = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 159;
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
    
    TURNENDPOINTON = new Crestron.Logos.SplusObjects.DigitalInput( TURNENDPOINTON__DigitalInput__, this );
    m_DigitalInputList.Add( TURNENDPOINTON__DigitalInput__, TURNENDPOINTON );
    
    TURNENDPOINTHWOFF = new Crestron.Logos.SplusObjects.DigitalOutput( TURNENDPOINTHWOFF__DigitalOutput__, this );
    m_DigitalOutputList.Add( TURNENDPOINTHWOFF__DigitalOutput__, TURNENDPOINTHWOFF );
    
    ENDPOINTON_FB = new Crestron.Logos.SplusObjects.DigitalOutput( ENDPOINTON_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( ENDPOINTON_FB__DigitalOutput__, ENDPOINTON_FB );
    
    ENDPOINTOFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( ENDPOINTOFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( ENDPOINTOFF_FB__DigitalOutput__, ENDPOINTOFF_FB );
    
    GROUPVOLUMEUP = new Crestron.Logos.SplusObjects.DigitalOutput( GROUPVOLUMEUP__DigitalOutput__, this );
    m_DigitalOutputList.Add( GROUPVOLUMEUP__DigitalOutput__, GROUPVOLUMEUP );
    
    GROUPVOLUMEDOWN = new Crestron.Logos.SplusObjects.DigitalOutput( GROUPVOLUMEDOWN__DigitalOutput__, this );
    m_DigitalOutputList.Add( GROUPVOLUMEDOWN__DigitalOutput__, GROUPVOLUMEDOWN );
    
    ENDPOINTID = new Crestron.Logos.SplusObjects.AnalogInput( ENDPOINTID__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ENDPOINTID__AnalogSerialInput__, ENDPOINTID );
    
    SETENDPOINTSOURCE = new Crestron.Logos.SplusObjects.AnalogInput( SETENDPOINTSOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SETENDPOINTSOURCE__AnalogSerialInput__, SETENDPOINTSOURCE );
    
    ENDPOINTSOURCE_FB = new Crestron.Logos.SplusObjects.AnalogOutput( ENDPOINTSOURCE_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ENDPOINTSOURCE_FB__AnalogSerialOutput__, ENDPOINTSOURCE_FB );
    
    ENDPOINTNAME = new Crestron.Logos.SplusObjects.StringOutput( ENDPOINTNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ENDPOINTNAME__AnalogSerialOutput__, ENDPOINTNAME );
    
    ENDPOINTSOURCENAME = new Crestron.Logos.SplusObjects.StringOutput( ENDPOINTSOURCENAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ENDPOINTSOURCENAME__AnalogSerialOutput__, ENDPOINTSOURCENAME );
    
    ENDPOINTSOURCENOWPLAYINGLINE1 = new Crestron.Logos.SplusObjects.StringOutput( ENDPOINTSOURCENOWPLAYINGLINE1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ENDPOINTSOURCENOWPLAYINGLINE1__AnalogSerialOutput__, ENDPOINTSOURCENOWPLAYINGLINE1 );
    
    ENDPOINTSOURCENOWPLAYINGLINE2 = new Crestron.Logos.SplusObjects.StringOutput( ENDPOINTSOURCENOWPLAYINGLINE2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ENDPOINTSOURCENOWPLAYINGLINE2__AnalogSerialOutput__, ENDPOINTSOURCENOWPLAYINGLINE2 );
    
    
    TURNENDPOINTON.OnDigitalPush.Add( new InputChangeHandlerWrapper( TURNENDPOINTON_OnPush_0, false ) );
    ENDPOINTID.OnAnalogChange.Add( new InputChangeHandlerWrapper( ENDPOINTID_OnChange_1, false ) );
    SETENDPOINTSOURCE.OnAnalogChange.Add( new InputChangeHandlerWrapper( SETENDPOINTSOURCE_OnChange_2, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    SIMPLSHARPCOMPONENT  = new Crestron.Rio.DataStructures.Media.DistributionComponents.EndpointSSharpComponent();
    
    
}

public CrestronModuleClass_CSR_MEDIA_ENDPOINT_SIMPL__INTERFACE_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint TURNENDPOINTON__DigitalInput__ = 0;
const uint ENDPOINTID__AnalogSerialInput__ = 0;
const uint SETENDPOINTSOURCE__AnalogSerialInput__ = 1;
const uint TURNENDPOINTHWOFF__DigitalOutput__ = 0;
const uint ENDPOINTON_FB__DigitalOutput__ = 1;
const uint ENDPOINTOFF_FB__DigitalOutput__ = 2;
const uint GROUPVOLUMEUP__DigitalOutput__ = 3;
const uint GROUPVOLUMEDOWN__DigitalOutput__ = 4;
const uint ENDPOINTSOURCE_FB__AnalogSerialOutput__ = 0;
const uint ENDPOINTNAME__AnalogSerialOutput__ = 1;
const uint ENDPOINTSOURCENAME__AnalogSerialOutput__ = 2;
const uint ENDPOINTSOURCENOWPLAYINGLINE1__AnalogSerialOutput__ = 3;
const uint ENDPOINTSOURCENOWPLAYINGLINE2__AnalogSerialOutput__ = 4;

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
