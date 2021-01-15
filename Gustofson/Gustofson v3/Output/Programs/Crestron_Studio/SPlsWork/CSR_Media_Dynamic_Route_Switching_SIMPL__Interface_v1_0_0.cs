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

namespace CrestronModule_CSR_MEDIA_DYNAMIC_ROUTE_SWITCHING_SIMPL__INTERFACE_V1_0_0
{
    public class CrestronModuleClass_CSR_MEDIA_DYNAMIC_ROUTE_SWITCHING_SIMPL__INTERFACE_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        Crestron.Logos.SplusObjects.AnalogInput DROUTPUTSIGNALID;
        Crestron.Logos.SplusObjects.AnalogInput DRMIDPOINTID;
        Crestron.Logos.SplusObjects.AnalogInput SOURCE_FB;
        Crestron.Logos.SplusObjects.AnalogOutput INPUTTOSELECT;
        ushort MEDIASUBSYSTEMINITIALIZED = 0;
        private void SENDSOURCEFEEDBACKTODYNAMICROUTING (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 40;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MEDIASUBSYSTEMINITIALIZED == 1))  ) ) 
                {
                __context__.SourceCodeLine = 41;
                 DynamicRouting.UpdateFeedback( (int)( DRMIDPOINTID  .IntValue ) , (int)( DROUTPUTSIGNALID  .IntValue ) , (int)( SOURCE_FB  .IntValue ) )  ;  
 
                }
            
            
            }
            
        object SOURCE_FB_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 46;
                SENDSOURCEFEEDBACKTODYNAMICROUTING (  __context__  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    public void SWITCHCOMMANDHANDLER ( object __sender__ /*Crestron.Rio.DataStructures.Media.Routing.DeviceRouteEventArgs ARGS */) 
        { 
        DeviceRouteEventArgs  ARGS  = (DeviceRouteEventArgs )__sender__;
        try
        {
            SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
            
            __context__.SourceCodeLine = 52;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DROUTPUTSIGNALID  .UshortValue == ARGS.outputSignalID))  ) ) 
                {
                __context__.SourceCodeLine = 53;
                INPUTTOSELECT  .Value = (ushort) ( ARGS.inputNumber ) ; 
                }
            
            
            
        }
        finally { ObjectFinallyHandler(); }
        }
        
    public void MEDIAINITIALIZATIONCOMPLETEEVENTHANDLER ( object __sender__ /*EventArgs ARGS */) 
        { 
        EventArgs  ARGS  = (EventArgs )__sender__;
        try
        {
            SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
            
            __context__.SourceCodeLine = 58;
            MEDIASUBSYSTEMINITIALIZED = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 60;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SOURCE_FB  .UshortValue != 0))  ) ) 
                {
                __context__.SourceCodeLine = 61;
                SENDSOURCEFEEDBACKTODYNAMICROUTING (  __context__  ) ; 
                }
            
            
            
        }
        finally { ObjectFinallyHandler(); }
        }
        
    public override object FunctionMain (  object __obj__ ) 
        { 
        try
        {
            SplusExecutionContext __context__ = SplusFunctionMainStartCode();
            
            __context__.SourceCodeLine = 67;
            MEDIASUBSYSTEMINITIALIZED = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 69;
            // RegisterEvent( DynamicRouting , DEVICEROUTEEVENT , SWITCHCOMMANDHANDLER ) 
            try { g_criticalSection.Enter(); DynamicRouting .DeviceRouteEvent  += SWITCHCOMMANDHANDLER; } finally { g_criticalSection.Leave(); }
            ; 
            __context__.SourceCodeLine = 71;
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
        
        DROUTPUTSIGNALID = new Crestron.Logos.SplusObjects.AnalogInput( DROUTPUTSIGNALID__AnalogSerialInput__, this );
        m_AnalogInputList.Add( DROUTPUTSIGNALID__AnalogSerialInput__, DROUTPUTSIGNALID );
        
        DRMIDPOINTID = new Crestron.Logos.SplusObjects.AnalogInput( DRMIDPOINTID__AnalogSerialInput__, this );
        m_AnalogInputList.Add( DRMIDPOINTID__AnalogSerialInput__, DRMIDPOINTID );
        
        SOURCE_FB = new Crestron.Logos.SplusObjects.AnalogInput( SOURCE_FB__AnalogSerialInput__, this );
        m_AnalogInputList.Add( SOURCE_FB__AnalogSerialInput__, SOURCE_FB );
        
        INPUTTOSELECT = new Crestron.Logos.SplusObjects.AnalogOutput( INPUTTOSELECT__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( INPUTTOSELECT__AnalogSerialOutput__, INPUTTOSELECT );
        
        
        SOURCE_FB.OnAnalogChange.Add( new InputChangeHandlerWrapper( SOURCE_FB_OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public CrestronModuleClass_CSR_MEDIA_DYNAMIC_ROUTE_SWITCHING_SIMPL__INTERFACE_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint DROUTPUTSIGNALID__AnalogSerialInput__ = 0;
    const uint DRMIDPOINTID__AnalogSerialInput__ = 1;
    const uint SOURCE_FB__AnalogSerialInput__ = 2;
    const uint INPUTTOSELECT__AnalogSerialOutput__ = 0;
    
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
