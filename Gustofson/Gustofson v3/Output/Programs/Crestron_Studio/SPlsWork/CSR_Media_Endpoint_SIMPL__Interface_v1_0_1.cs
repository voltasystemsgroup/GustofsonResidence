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

namespace CrestronModule_CSR_MEDIA_ENDPOINT_SIMPL__INTERFACE_V1_0_1
{
    public class CrestronModuleClass_CSR_MEDIA_ENDPOINT_SIMPL__INTERFACE_V1_0_1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput TURNENDPOINTON;
        Crestron.Logos.SplusObjects.DigitalInput STANDBY;
        Crestron.Logos.SplusObjects.DigitalInput ENABLEAUTOMEDIAROUTING;
        Crestron.Logos.SplusObjects.DigitalInput DISABLEAUTOMEDIAROUTING;
        Crestron.Logos.SplusObjects.AnalogInput ENDPOINTID;
        Crestron.Logos.SplusObjects.AnalogInput SETENDPOINTSOURCE;
        Crestron.Logos.SplusObjects.DigitalInput ENDPOINTOFFREQUESTED;
        Crestron.Logos.SplusObjects.DigitalOutput TURNENDPOINTHWOFF;
        Crestron.Logos.SplusObjects.DigitalOutput ENDPOINTON_FB;
        Crestron.Logos.SplusObjects.DigitalOutput ENDPOINTOFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput GROUPVOLUMEUP;
        Crestron.Logos.SplusObjects.DigitalOutput GROUPVOLUMEDOWN;
        Crestron.Logos.SplusObjects.DigitalOutput STANDBYISON;
        Crestron.Logos.SplusObjects.DigitalOutput STANDBYISOFF;
        Crestron.Logos.SplusObjects.DigitalOutput AUTOMEDIAROUTINGISENABLED;
        Crestron.Logos.SplusObjects.DigitalOutput AUTOMEDIAROUTINGISDISABLED;
        Crestron.Logos.SplusObjects.DigitalOutput FORCINGPOWERON;
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
                
                __context__.SourceCodeLine = 63;
                SIMPLSHARPCOMPONENT . TurnEndpointOn ( ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object STANDBY_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 68;
            SIMPLSHARPCOMPONENT . StandbyOn ( ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object ENABLEAUTOMEDIAROUTING_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 73;
        SIMPLSHARPCOMPONENT . EnableAutoMediaRouting ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DISABLEAUTOMEDIAROUTING_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 78;
        SIMPLSHARPCOMPONENT . DisableAutoMediaRouting ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENDPOINTOFFREQUESTED_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 83;
        SIMPLSHARPCOMPONENT . EndpointOffRequested ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENDPOINTID_OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 88;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ENDPOINTIDSET == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 90;
            ENDPOINTIDSET = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 92;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MEDIASUBSYSTEMINITIALIZED == 1))  ) ) 
                {
                __context__.SourceCodeLine = 93;
                SIMPLSHARPCOMPONENT . AssociateSSharpComponent ( (int)( ENDPOINTID  .IntValue )) ; 
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SETENDPOINTSOURCE_OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 99;
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
        
        __context__.SourceCodeLine = 104;
        TURNENDPOINTHWOFF  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 105;
        TURNENDPOINTHWOFF  .Value = (ushort) ( 0 ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATENAMECALLBACK ( SimplSharpString ENDPOINTNAMEFROMSSHARP ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 110;
        ENDPOINTNAME  .UpdateValue ( ENDPOINTNAMEFROMSSHARP  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESELECTEDSOURCEIDCALLBACK ( int SOURCEID ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 115;
        ENDPOINTSOURCE_FB  .Value = (ushort) ( SOURCEID ) ; 
        __context__.SourceCodeLine = 117;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SOURCEID == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 119;
            ENDPOINTON_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 120;
            ENDPOINTOFF_FB  .Value = (ushort) ( 1 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 124;
            ENDPOINTOFF_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 125;
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
        
        __context__.SourceCodeLine = 131;
        ENDPOINTSOURCENAME  .UpdateValue ( SOURCENAMEFROMSSHARP  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATENOWPLAYINGLINE1CALLBACK ( SimplSharpString NOWPLAYINGINFORMATION ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 136;
        ENDPOINTSOURCENOWPLAYINGLINE1  .UpdateValue ( NOWPLAYINGINFORMATION  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATENOWPLAYINGLINE2CALLBACK ( SimplSharpString NOWPLAYINGINFORMATION ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 141;
        ENDPOINTSOURCENOWPLAYINGLINE2  .UpdateValue ( NOWPLAYINGINFORMATION  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEGROUPVOLUMEUPCALLBACK ( int VOLUMEADJUSTMENTSTATE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 146;
        GROUPVOLUMEUP  .Value = (ushort) ( VOLUMEADJUSTMENTSTATE ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEGROUPVOLUMEDOWNCALLBACK ( int VOLUMEADJUSTMENTSTATE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 151;
        GROUPVOLUMEDOWN  .Value = (ushort) ( VOLUMEADJUSTMENTSTATE ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESTANDBYONCALLBACK ( int STANDBYON ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 156;
        STANDBYISON  .Value = (ushort) ( STANDBYON ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESTANDBYOFFCALLBACK ( int STANDBYOFF ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 161;
        STANDBYISOFF  .Value = (ushort) ( STANDBYOFF ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEAUTOMEDIAROUTINGENABLECALLBACK ( int ISENABLED ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 166;
        AUTOMEDIAROUTINGISENABLED  .Value = (ushort) ( ISENABLED ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEAUTOMEDIAROUTINGDISABLECALLBACK ( int ISDISABLED ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 171;
        AUTOMEDIAROUTINGISDISABLED  .Value = (ushort) ( ISDISABLED ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEFORCEPOWERONCALLBACK ( int FORCEPOWERON ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 176;
        FORCINGPOWERON  .Value = (ushort) ( FORCEPOWERON ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void MEDIAINITIALIZATIONCOMPLETEEVENTHANDLER ( object __sender__ /*EventArgs ARGS */) 
    { 
    EventArgs  ARGS  = (EventArgs )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 182;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , TURNHWOFF , TURNHWOFFCALLBACK ) 
        SIMPLSHARPCOMPONENT .turnHWOff  = TURNHWOFFCALLBACK; ; 
        __context__.SourceCodeLine = 184;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATENAME , UPDATENAMECALLBACK ) 
        SIMPLSHARPCOMPONENT .updateName  = UPDATENAMECALLBACK; ; 
        __context__.SourceCodeLine = 185;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATESELECTEDSOURCEID , UPDATESELECTEDSOURCEIDCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateSelectedSourceID  = UPDATESELECTEDSOURCEIDCALLBACK; ; 
        __context__.SourceCodeLine = 186;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATESELECTEDSOURCENAME , UPDATESELECTEDSOURCENAMECALLBACK ) 
        SIMPLSHARPCOMPONENT .updateSelectedSourceName  = UPDATESELECTEDSOURCENAMECALLBACK; ; 
        __context__.SourceCodeLine = 187;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATENOWPLAYINGLINE1 , UPDATENOWPLAYINGLINE1CALLBACK ) 
        SIMPLSHARPCOMPONENT .updateNowPlayingLine1  = UPDATENOWPLAYINGLINE1CALLBACK; ; 
        __context__.SourceCodeLine = 188;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATENOWPLAYINGLINE2 , UPDATENOWPLAYINGLINE2CALLBACK ) 
        SIMPLSHARPCOMPONENT .updateNowPlayingLine2  = UPDATENOWPLAYINGLINE2CALLBACK; ; 
        __context__.SourceCodeLine = 190;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATEGROUPVOLUMEUP , UPDATEGROUPVOLUMEUPCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateGroupVolumeUp  = UPDATEGROUPVOLUMEUPCALLBACK; ; 
        __context__.SourceCodeLine = 191;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATEGROUPVOLUMEDOWN , UPDATEGROUPVOLUMEDOWNCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateGroupVolumeDown  = UPDATEGROUPVOLUMEDOWNCALLBACK; ; 
        __context__.SourceCodeLine = 193;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATESTANDBYON , UPDATESTANDBYONCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateStandbyOn  = UPDATESTANDBYONCALLBACK; ; 
        __context__.SourceCodeLine = 194;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATESTANDBYOFF , UPDATESTANDBYOFFCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateStandbyOff  = UPDATESTANDBYOFFCALLBACK; ; 
        __context__.SourceCodeLine = 196;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATEAUTOMEDIAROUTINGENABLED , UPDATEAUTOMEDIAROUTINGENABLECALLBACK ) 
        SIMPLSHARPCOMPONENT .updateAutoMediaRoutingEnabled  = UPDATEAUTOMEDIAROUTINGENABLECALLBACK; ; 
        __context__.SourceCodeLine = 197;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATEAUTOMEDIAROUTINGDISABLED , UPDATEAUTOMEDIAROUTINGDISABLECALLBACK ) 
        SIMPLSHARPCOMPONENT .updateAutoMediaRoutingDisabled  = UPDATEAUTOMEDIAROUTINGDISABLECALLBACK; ; 
        __context__.SourceCodeLine = 199;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATEFORCEPOWERON , UPDATEFORCEPOWERONCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateForcePowerOn  = UPDATEFORCEPOWERONCALLBACK; ; 
        __context__.SourceCodeLine = 201;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ENDPOINTIDSET == 1))  ) ) 
            {
            __context__.SourceCodeLine = 202;
            SIMPLSHARPCOMPONENT . AssociateSSharpComponent ( (int)( ENDPOINTID  .IntValue )) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 204;
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
        
        __context__.SourceCodeLine = 209;
        ENDPOINTON_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 210;
        ENDPOINTOFF_FB  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 211;
        STANDBYISON  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 212;
        STANDBYISOFF  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 213;
        AUTOMEDIAROUTINGISENABLED  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 214;
        AUTOMEDIAROUTINGISDISABLED  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 215;
        GROUPVOLUMEUP  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 216;
        GROUPVOLUMEDOWN  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 217;
        ENDPOINTSOURCE_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 218;
        FORCINGPOWERON  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 220;
        ENDPOINTNAME  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 221;
        ENDPOINTSOURCENAME  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 222;
        ENDPOINTSOURCENOWPLAYINGLINE1  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 223;
        ENDPOINTSOURCENOWPLAYINGLINE2  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 225;
        ENDPOINTIDSET = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 226;
        MEDIASUBSYSTEMINITIALIZED = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 228;
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
    
    STANDBY = new Crestron.Logos.SplusObjects.DigitalInput( STANDBY__DigitalInput__, this );
    m_DigitalInputList.Add( STANDBY__DigitalInput__, STANDBY );
    
    ENABLEAUTOMEDIAROUTING = new Crestron.Logos.SplusObjects.DigitalInput( ENABLEAUTOMEDIAROUTING__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLEAUTOMEDIAROUTING__DigitalInput__, ENABLEAUTOMEDIAROUTING );
    
    DISABLEAUTOMEDIAROUTING = new Crestron.Logos.SplusObjects.DigitalInput( DISABLEAUTOMEDIAROUTING__DigitalInput__, this );
    m_DigitalInputList.Add( DISABLEAUTOMEDIAROUTING__DigitalInput__, DISABLEAUTOMEDIAROUTING );
    
    ENDPOINTOFFREQUESTED = new Crestron.Logos.SplusObjects.DigitalInput( ENDPOINTOFFREQUESTED__DigitalInput__, this );
    m_DigitalInputList.Add( ENDPOINTOFFREQUESTED__DigitalInput__, ENDPOINTOFFREQUESTED );
    
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
    
    STANDBYISON = new Crestron.Logos.SplusObjects.DigitalOutput( STANDBYISON__DigitalOutput__, this );
    m_DigitalOutputList.Add( STANDBYISON__DigitalOutput__, STANDBYISON );
    
    STANDBYISOFF = new Crestron.Logos.SplusObjects.DigitalOutput( STANDBYISOFF__DigitalOutput__, this );
    m_DigitalOutputList.Add( STANDBYISOFF__DigitalOutput__, STANDBYISOFF );
    
    AUTOMEDIAROUTINGISENABLED = new Crestron.Logos.SplusObjects.DigitalOutput( AUTOMEDIAROUTINGISENABLED__DigitalOutput__, this );
    m_DigitalOutputList.Add( AUTOMEDIAROUTINGISENABLED__DigitalOutput__, AUTOMEDIAROUTINGISENABLED );
    
    AUTOMEDIAROUTINGISDISABLED = new Crestron.Logos.SplusObjects.DigitalOutput( AUTOMEDIAROUTINGISDISABLED__DigitalOutput__, this );
    m_DigitalOutputList.Add( AUTOMEDIAROUTINGISDISABLED__DigitalOutput__, AUTOMEDIAROUTINGISDISABLED );
    
    FORCINGPOWERON = new Crestron.Logos.SplusObjects.DigitalOutput( FORCINGPOWERON__DigitalOutput__, this );
    m_DigitalOutputList.Add( FORCINGPOWERON__DigitalOutput__, FORCINGPOWERON );
    
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
    STANDBY.OnDigitalPush.Add( new InputChangeHandlerWrapper( STANDBY_OnPush_1, false ) );
    ENABLEAUTOMEDIAROUTING.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENABLEAUTOMEDIAROUTING_OnPush_2, false ) );
    DISABLEAUTOMEDIAROUTING.OnDigitalPush.Add( new InputChangeHandlerWrapper( DISABLEAUTOMEDIAROUTING_OnPush_3, false ) );
    ENDPOINTOFFREQUESTED.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENDPOINTOFFREQUESTED_OnPush_4, false ) );
    ENDPOINTID.OnAnalogChange.Add( new InputChangeHandlerWrapper( ENDPOINTID_OnChange_5, false ) );
    SETENDPOINTSOURCE.OnAnalogChange.Add( new InputChangeHandlerWrapper( SETENDPOINTSOURCE_OnChange_6, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    SIMPLSHARPCOMPONENT  = new Crestron.Rio.DataStructures.Media.DistributionComponents.EndpointSSharpComponent();
    
    
}

public CrestronModuleClass_CSR_MEDIA_ENDPOINT_SIMPL__INTERFACE_V1_0_1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint TURNENDPOINTON__DigitalInput__ = 0;
const uint STANDBY__DigitalInput__ = 1;
const uint ENABLEAUTOMEDIAROUTING__DigitalInput__ = 2;
const uint DISABLEAUTOMEDIAROUTING__DigitalInput__ = 3;
const uint ENDPOINTID__AnalogSerialInput__ = 0;
const uint SETENDPOINTSOURCE__AnalogSerialInput__ = 1;
const uint ENDPOINTOFFREQUESTED__DigitalInput__ = 4;
const uint TURNENDPOINTHWOFF__DigitalOutput__ = 0;
const uint ENDPOINTON_FB__DigitalOutput__ = 1;
const uint ENDPOINTOFF_FB__DigitalOutput__ = 2;
const uint GROUPVOLUMEUP__DigitalOutput__ = 3;
const uint GROUPVOLUMEDOWN__DigitalOutput__ = 4;
const uint STANDBYISON__DigitalOutput__ = 5;
const uint STANDBYISOFF__DigitalOutput__ = 6;
const uint AUTOMEDIAROUTINGISENABLED__DigitalOutput__ = 7;
const uint AUTOMEDIAROUTINGISDISABLED__DigitalOutput__ = 8;
const uint FORCINGPOWERON__DigitalOutput__ = 9;
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
