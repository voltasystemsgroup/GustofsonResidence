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

namespace CrestronModule_CSR_MEDIA_MANAGER_SIMPL__INTERFACE_V1_0_0
{
    public class CrestronModuleClass_CSR_MEDIA_MANAGER_SIMPL__INTERFACE_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput TURNALLROOMSOFF;
        Crestron.Logos.SplusObjects.DigitalInput ACTIVATEINTERRUPTMUTE;
        Crestron.Logos.SplusObjects.DigitalInput TERMINATEINTERRUPTMUTE;
        Crestron.Logos.SplusObjects.AnalogInput MEDIASUBSYSTEMID;
        Crestron.Logos.SplusObjects.StringInput ROUTESTEPINFORMATION;
        Crestron.Logos.SplusObjects.AnalogInput ROUTETOREGISTEREDAUTOMEDIAROUTINGENDPOINTS;
        Crestron.Logos.SplusObjects.AnalogInput UNROUTEFROMREGISTEREDAUTOMEDIAROUTINGENDPOINTS;
        Crestron.Logos.SplusObjects.DigitalOutput INITIALIZATIONCOMPLETE;
        object TURNALLROOMSOFF_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                 MediaSubsystem.AllRoomsOff()  ;  
 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object ACTIVATEINTERRUPTMUTE_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
             MediaSubsystem.RequestInterruptMuteActivation()  ;  
 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object TERMINATEINTERRUPTMUTE_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
         MediaSubsystem.RequestInterruptMuteTermination()  ;  
 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MEDIASUBSYSTEMID_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
         MediaSubsystem.subsystemID  =  (int)( MEDIASUBSYSTEMID  .IntValue )  ;  
 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROUTESTEPINFORMATION_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
         MediaSubsystem.ProcessRouteStep(  ROUTESTEPINFORMATION .ToString() )  ;  
 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROUTETOREGISTEREDAUTOMEDIAROUTINGENDPOINTS_OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
         MediaSubsystem.RouteToRegisteredAutoMediaRoutingEndpoints( (int)( ROUTETOREGISTEREDAUTOMEDIAROUTINGENDPOINTS  .IntValue ) )  ;  
 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UNROUTEFROMREGISTEREDAUTOMEDIAROUTINGENDPOINTS_OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
         MediaSubsystem.UnrouteFromRegisteredAutoMediaRoutingEndpoints( (int)( UNROUTEFROMREGISTEREDAUTOMEDIAROUTINGENDPOINTS  .IntValue ) )  ;  
 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void MEDIAMIDPOINTINITIALIZATIONEVENTHANDLER ( object __sender__ /*EventArgs ARGS */) 
    { 
    EventArgs  ARGS  = (EventArgs )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 77;
        INITIALIZATIONCOMPLETE  .Value = (ushort) ( 1 ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 82;
        INITIALIZATIONCOMPLETE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 84;
        // RegisterEvent( MediaSubsystem , MEDIAMIDPOINTINITIALIZATIONCOMPLETEEVENT , MEDIAMIDPOINTINITIALIZATIONEVENTHANDLER ) 
        try { g_criticalSection.Enter(); MediaSubsystem .MediaMidpointInitializationCompleteEvent  += MEDIAMIDPOINTINITIALIZATIONEVENTHANDLER; } finally { g_criticalSection.Leave(); }
        ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    TURNALLROOMSOFF = new Crestron.Logos.SplusObjects.DigitalInput( TURNALLROOMSOFF__DigitalInput__, this );
    m_DigitalInputList.Add( TURNALLROOMSOFF__DigitalInput__, TURNALLROOMSOFF );
    
    ACTIVATEINTERRUPTMUTE = new Crestron.Logos.SplusObjects.DigitalInput( ACTIVATEINTERRUPTMUTE__DigitalInput__, this );
    m_DigitalInputList.Add( ACTIVATEINTERRUPTMUTE__DigitalInput__, ACTIVATEINTERRUPTMUTE );
    
    TERMINATEINTERRUPTMUTE = new Crestron.Logos.SplusObjects.DigitalInput( TERMINATEINTERRUPTMUTE__DigitalInput__, this );
    m_DigitalInputList.Add( TERMINATEINTERRUPTMUTE__DigitalInput__, TERMINATEINTERRUPTMUTE );
    
    INITIALIZATIONCOMPLETE = new Crestron.Logos.SplusObjects.DigitalOutput( INITIALIZATIONCOMPLETE__DigitalOutput__, this );
    m_DigitalOutputList.Add( INITIALIZATIONCOMPLETE__DigitalOutput__, INITIALIZATIONCOMPLETE );
    
    MEDIASUBSYSTEMID = new Crestron.Logos.SplusObjects.AnalogInput( MEDIASUBSYSTEMID__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MEDIASUBSYSTEMID__AnalogSerialInput__, MEDIASUBSYSTEMID );
    
    ROUTETOREGISTEREDAUTOMEDIAROUTINGENDPOINTS = new Crestron.Logos.SplusObjects.AnalogInput( ROUTETOREGISTEREDAUTOMEDIAROUTINGENDPOINTS__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ROUTETOREGISTEREDAUTOMEDIAROUTINGENDPOINTS__AnalogSerialInput__, ROUTETOREGISTEREDAUTOMEDIAROUTINGENDPOINTS );
    
    UNROUTEFROMREGISTEREDAUTOMEDIAROUTINGENDPOINTS = new Crestron.Logos.SplusObjects.AnalogInput( UNROUTEFROMREGISTEREDAUTOMEDIAROUTINGENDPOINTS__AnalogSerialInput__, this );
    m_AnalogInputList.Add( UNROUTEFROMREGISTEREDAUTOMEDIAROUTINGENDPOINTS__AnalogSerialInput__, UNROUTEFROMREGISTEREDAUTOMEDIAROUTINGENDPOINTS );
    
    ROUTESTEPINFORMATION = new Crestron.Logos.SplusObjects.StringInput( ROUTESTEPINFORMATION__AnalogSerialInput__, 255, this );
    m_StringInputList.Add( ROUTESTEPINFORMATION__AnalogSerialInput__, ROUTESTEPINFORMATION );
    
    
    TURNALLROOMSOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( TURNALLROOMSOFF_OnPush_0, false ) );
    ACTIVATEINTERRUPTMUTE.OnDigitalPush.Add( new InputChangeHandlerWrapper( ACTIVATEINTERRUPTMUTE_OnPush_1, false ) );
    TERMINATEINTERRUPTMUTE.OnDigitalPush.Add( new InputChangeHandlerWrapper( TERMINATEINTERRUPTMUTE_OnPush_2, false ) );
    MEDIASUBSYSTEMID.OnAnalogChange.Add( new InputChangeHandlerWrapper( MEDIASUBSYSTEMID_OnChange_3, false ) );
    ROUTESTEPINFORMATION.OnSerialChange.Add( new InputChangeHandlerWrapper( ROUTESTEPINFORMATION_OnChange_4, false ) );
    ROUTETOREGISTEREDAUTOMEDIAROUTINGENDPOINTS.OnAnalogChange.Add( new InputChangeHandlerWrapper( ROUTETOREGISTEREDAUTOMEDIAROUTINGENDPOINTS_OnChange_5, false ) );
    UNROUTEFROMREGISTEREDAUTOMEDIAROUTINGENDPOINTS.OnAnalogChange.Add( new InputChangeHandlerWrapper( UNROUTEFROMREGISTEREDAUTOMEDIAROUTINGENDPOINTS_OnChange_6, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_CSR_MEDIA_MANAGER_SIMPL__INTERFACE_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint TURNALLROOMSOFF__DigitalInput__ = 0;
const uint ACTIVATEINTERRUPTMUTE__DigitalInput__ = 1;
const uint TERMINATEINTERRUPTMUTE__DigitalInput__ = 2;
const uint MEDIASUBSYSTEMID__AnalogSerialInput__ = 0;
const uint ROUTESTEPINFORMATION__AnalogSerialInput__ = 1;
const uint ROUTETOREGISTEREDAUTOMEDIAROUTINGENDPOINTS__AnalogSerialInput__ = 2;
const uint UNROUTEFROMREGISTEREDAUTOMEDIAROUTINGENDPOINTS__AnalogSerialInput__ = 3;
const uint INITIALIZATIONCOMPLETE__DigitalOutput__ = 0;

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
