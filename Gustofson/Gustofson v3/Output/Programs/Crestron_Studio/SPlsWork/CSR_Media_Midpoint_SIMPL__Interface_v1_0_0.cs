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

namespace CrestronModule_CSR_MEDIA_MIDPOINT_SIMPL__INTERFACE_V1_0_0
{
    public class CrestronModuleClass_CSR_MEDIA_MIDPOINT_SIMPL__INTERFACE_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput MIDPOINTREADY;
        Crestron.Logos.SplusObjects.AnalogInput MIDPOINTID;
        Crestron.Rio.DataStructures.Media.DeviceManagement.MediaMidpointSSharpComponent SIMPLSHARPCOMPONENT;
        object MIDPOINTREADY_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 36;
                SIMPLSHARPCOMPONENT . MidpointReady ( ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object MIDPOINTID_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 41;
            SIMPLSHARPCOMPONENT . SetID ( (int)( MIDPOINTID  .IntValue )) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    MIDPOINTREADY = new Crestron.Logos.SplusObjects.DigitalInput( MIDPOINTREADY__DigitalInput__, this );
    m_DigitalInputList.Add( MIDPOINTREADY__DigitalInput__, MIDPOINTREADY );
    
    MIDPOINTID = new Crestron.Logos.SplusObjects.AnalogInput( MIDPOINTID__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MIDPOINTID__AnalogSerialInput__, MIDPOINTID );
    
    
    MIDPOINTREADY.OnDigitalPush.Add( new InputChangeHandlerWrapper( MIDPOINTREADY_OnPush_0, false ) );
    MIDPOINTID.OnAnalogChange.Add( new InputChangeHandlerWrapper( MIDPOINTID_OnChange_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    SIMPLSHARPCOMPONENT  = new Crestron.Rio.DataStructures.Media.DeviceManagement.MediaMidpointSSharpComponent();
    
    
}

public CrestronModuleClass_CSR_MEDIA_MIDPOINT_SIMPL__INTERFACE_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint MIDPOINTREADY__DigitalInput__ = 0;
const uint MIDPOINTID__AnalogSerialInput__ = 0;

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
