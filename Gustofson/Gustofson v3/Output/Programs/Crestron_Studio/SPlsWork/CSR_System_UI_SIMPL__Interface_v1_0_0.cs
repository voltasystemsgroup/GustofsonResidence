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
using Crestron.Rio.System;
using Crestron.Rio.DataStructures.Media.Routing;
using Crestron.Rio.DataStructures;
using Crestron.Rio.DataStructures.Media;

namespace CrestronModule_CSR_SYSTEM_UI_SIMPL__INTERFACE_V1_0_0
{
    public class CrestronModuleClass_CSR_SYSTEM_UI_SIMPL__INTERFACE_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput REQUEST_HOME_SCREEN;
        Crestron.Logos.SplusObjects.DigitalInput REQUEST_STARTUP_SUBSYTEM;
        Crestron.Logos.SplusObjects.DigitalInput REQUEST_PERSISTENT_SUBSYSTEM;
        Crestron.Logos.SplusObjects.AnalogInput PANEL_ID;
        Crestron.Logos.SplusObjects.AnalogInput HOMESCREEN_ITEM_SELECTED;
        Crestron.Logos.SplusObjects.AnalogInput SUBPAGEFLIP_REQUESTED;
        Crestron.Logos.SplusObjects.DigitalOutput INITIALIZED;
        Crestron.Logos.SplusObjects.DigitalOutput SHOW_HOME_SCREEN;
        Crestron.Logos.SplusObjects.AnalogOutput FLIP_TO_SUBPAGE;
        Crestron.Logos.SplusObjects.AnalogOutput NUM_HOME_SCREEN_LIST_ITEMS;
        Crestron.Logos.SplusObjects.AnalogOutput ACTIONTYPE;
        Crestron.Logos.SplusObjects.AnalogOutput ACTIONITEM;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> HOMESCREEN_LIST_ICONFILENAME;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> HOMESCREEN_LIST_LABEL;
        Crestron.Rio.System.SystemUIHelper UIMANAGER;
        ushort HOMESCREENLISTITEMCOUNT = 0;
        ushort SUBSYSTEMCOUNT = 0;
        private void REGDELEGATES (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 57;
            // RegisterDelegate( UIMANAGER , UPDATEHOMESCREEN , HOMESCREENSUBPAGESTATUS ) 
            UIMANAGER .UpdateHomeScreen  = HOMESCREENSUBPAGESTATUS; ; 
            __context__.SourceCodeLine = 58;
            // RegisterDelegate( UIMANAGER , TRIGGERSUBPAGE , SUBPAGEREQUESTHANDLER ) 
            UIMANAGER .TriggerSubpage  = SUBPAGEREQUESTHANDLER; ; 
            __context__.SourceCodeLine = 59;
            // RegisterDelegate( UIMANAGER , TRIGGERACTION , ACTIONREQUESTHANDLER ) 
            UIMANAGER .TriggerAction  = ACTIONREQUESTHANDLER; ; 
            
            }
            
        public void HOMESCREENSUBPAGESTATUS ( ushort SHOW ) 
            { 
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 64;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SHOW == 1) ) && Functions.TestForTrue ( Functions.BoolToInt ( FLIP_TO_SUBPAGE  .Value > 0 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 66;
                    FLIP_TO_SUBPAGE  .Value = (ushort) ( 0 ) ; 
                    } 
                
                __context__.SourceCodeLine = 69;
                SHOW_HOME_SCREEN  .Value = (ushort) ( SHOW ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ACTIONREQUESTHANDLER ( ushort _ACTIONTYPE , ushort _ACTIONITEM ) 
            { 
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 74;
                ACTIONTYPE  .Value = (ushort) ( _ACTIONTYPE ) ; 
                __context__.SourceCodeLine = 75;
                Functions.ProcessLogic ( ) ; 
                __context__.SourceCodeLine = 76;
                ACTIONITEM  .Value = (ushort) ( _ACTIONITEM ) ; 
                __context__.SourceCodeLine = 79;
                ACTIONTYPE  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 80;
                ACTIONITEM  .Value = (ushort) ( 0 ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void SUBPAGEREQUESTHANDLER ( ushort SUBPAGEJOINREQUESTED ) 
            { 
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 86;
                FLIP_TO_SUBPAGE  .Value = (ushort) ( SUBPAGEJOINREQUESTED ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        private void POPULATEHOMESCREENLIST (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            CrestronString LABEL;
            LABEL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            
            CrestronString ICONFILENAME;
            ICONFILENAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            
            
            __context__.SourceCodeLine = 95;
            HOMESCREENLISTITEMCOUNT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 98;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (UIMANAGER.SystemReady == 0))  ) ) 
                {
                __context__.SourceCodeLine = 99;
                Functions.Delay (  (int) ( 500 ) ) ; 
                __context__.SourceCodeLine = 98;
                }
            
            __context__.SourceCodeLine = 101;
            HOMESCREENLISTITEMCOUNT = (ushort) ( UIMANAGER.GetNumberofHomeScreenItems( (ushort)( PANEL_ID  .UshortValue ) ) ) ; 
            __context__.SourceCodeLine = 103;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( HOMESCREENLISTITEMCOUNT > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 105;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)(HOMESCREENLISTITEMCOUNT - 1); 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 107;
                    LABEL  .UpdateValue ( UIMANAGER . GetListItemLabel ( (ushort)( PANEL_ID  .UshortValue ), (ushort)( I ))  ) ; 
                    __context__.SourceCodeLine = 108;
                    ICONFILENAME  .UpdateValue ( UIMANAGER . GetListItemIcon ( (ushort)( PANEL_ID  .UshortValue ), (ushort)( I ))  ) ; 
                    __context__.SourceCodeLine = 110;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( I > 31 ))  ) ) 
                        {
                        __context__.SourceCodeLine = 111;
                        break ; 
                        }
                    
                    __context__.SourceCodeLine = 113;
                    HOMESCREEN_LIST_ICONFILENAME [ (I + 1)]  .UpdateValue ( ICONFILENAME  ) ; 
                    __context__.SourceCodeLine = 114;
                    HOMESCREEN_LIST_LABEL [ (I + 1)]  .UpdateValue ( LABEL  ) ; 
                    __context__.SourceCodeLine = 105;
                    } 
                
                } 
            
            __context__.SourceCodeLine = 117;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( HOMESCREENLISTITEMCOUNT < 32 ))  ) ) 
                { 
                __context__.SourceCodeLine = 119;
                NUM_HOME_SCREEN_LIST_ITEMS  .Value = (ushort) ( HOMESCREENLISTITEMCOUNT ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 123;
                NUM_HOME_SCREEN_LIST_ITEMS  .Value = (ushort) ( 32 ) ; 
                } 
            
            __context__.SourceCodeLine = 126;
            INITIALIZED  .Value = (ushort) ( 1 ) ; 
            
            }
            
        object REQUEST_HOME_SCREEN_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 132;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SHOW_HOME_SCREEN  .Value == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 134;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FLIP_TO_SUBPAGE  .Value > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 136;
                        FLIP_TO_SUBPAGE  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 137;
                        SHOW_HOME_SCREEN  .Value = (ushort) ( 1 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 141;
                        UIMANAGER . RequestHomeScreen ( ) ; 
                        } 
                    
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object REQUEST_STARTUP_SUBSYTEM_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 148;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (UIMANAGER.SystemReady == 0))  ) ) 
                {
                __context__.SourceCodeLine = 149;
                return  this ; 
                }
            
            __context__.SourceCodeLine = 151;
            UIMANAGER . TriggerStartupSubsystem ( ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object REQUEST_PERSISTENT_SUBSYSTEM_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 157;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (UIMANAGER.SystemReady == 0))  ) ) 
            {
            __context__.SourceCodeLine = 158;
            return  this ; 
            }
        
        __context__.SourceCodeLine = 160;
        UIMANAGER . TriggerPersistentSubsystem ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SUBPAGEFLIP_REQUESTED_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort PAGEFLIP = 0;
        
        
        __context__.SourceCodeLine = 167;
        PAGEFLIP = (ushort) ( SUBPAGEFLIP_REQUESTED  .UshortValue ) ; 
        __context__.SourceCodeLine = 169;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (UIMANAGER.SystemReady == 0))  ) ) 
            {
            __context__.SourceCodeLine = 170;
            return  this ; 
            }
        
        __context__.SourceCodeLine = 173;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SHOW_HOME_SCREEN  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 175;
            SHOW_HOME_SCREEN  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 176;
            FLIP_TO_SUBPAGE  .Value = (ushort) ( PAGEFLIP ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 181;
            UIMANAGER . RequestSubpage ( (ushort)( PAGEFLIP )) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HOMESCREEN_ITEM_SELECTED_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort ITEMSELECTED = 0;
        ushort CUSTOMITEM = 0;
        
        
        __context__.SourceCodeLine = 188;
        ITEMSELECTED = (ushort) ( HOMESCREEN_ITEM_SELECTED  .UshortValue ) ; 
        __context__.SourceCodeLine = 190;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (UIMANAGER.SystemReady == 0))  ) ) 
            {
            __context__.SourceCodeLine = 191;
            return  this ; 
            }
        
        __context__.SourceCodeLine = 194;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITEMSELECTED <= HOMESCREENLISTITEMCOUNT ))  ) ) 
            { 
            __context__.SourceCodeLine = 197;
            UIMANAGER . HomeScreenItemSelected ( (ushort)( ITEMSELECTED ), (ushort)( PANEL_ID  .UshortValue )) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 201;
            GenerateUserNotice ( "CSR System UI was unable to find a match for the Home Screen Item Selected: {0:d}", (short)ITEMSELECTED) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    ushort I = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 214;
        UIMANAGER . Initialize ( ) ; 
        __context__.SourceCodeLine = 215;
        REGDELEGATES (  __context__  ) ; 
        __context__.SourceCodeLine = 216;
        HOMESCREENLISTITEMCOUNT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 217;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 220;
        UIMANAGER . Register ( (int)( PANEL_ID  .IntValue )) ; 
        __context__.SourceCodeLine = 223;
        POPULATEHOMESCREENLIST (  __context__  ) ; 
        __context__.SourceCodeLine = 225;
        SHOW_HOME_SCREEN  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 228;
        UIMANAGER . TriggerStartupSubsystem ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    REQUEST_HOME_SCREEN = new Crestron.Logos.SplusObjects.DigitalInput( REQUEST_HOME_SCREEN__DigitalInput__, this );
    m_DigitalInputList.Add( REQUEST_HOME_SCREEN__DigitalInput__, REQUEST_HOME_SCREEN );
    
    REQUEST_STARTUP_SUBSYTEM = new Crestron.Logos.SplusObjects.DigitalInput( REQUEST_STARTUP_SUBSYTEM__DigitalInput__, this );
    m_DigitalInputList.Add( REQUEST_STARTUP_SUBSYTEM__DigitalInput__, REQUEST_STARTUP_SUBSYTEM );
    
    REQUEST_PERSISTENT_SUBSYSTEM = new Crestron.Logos.SplusObjects.DigitalInput( REQUEST_PERSISTENT_SUBSYSTEM__DigitalInput__, this );
    m_DigitalInputList.Add( REQUEST_PERSISTENT_SUBSYSTEM__DigitalInput__, REQUEST_PERSISTENT_SUBSYSTEM );
    
    INITIALIZED = new Crestron.Logos.SplusObjects.DigitalOutput( INITIALIZED__DigitalOutput__, this );
    m_DigitalOutputList.Add( INITIALIZED__DigitalOutput__, INITIALIZED );
    
    SHOW_HOME_SCREEN = new Crestron.Logos.SplusObjects.DigitalOutput( SHOW_HOME_SCREEN__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHOW_HOME_SCREEN__DigitalOutput__, SHOW_HOME_SCREEN );
    
    PANEL_ID = new Crestron.Logos.SplusObjects.AnalogInput( PANEL_ID__AnalogSerialInput__, this );
    m_AnalogInputList.Add( PANEL_ID__AnalogSerialInput__, PANEL_ID );
    
    HOMESCREEN_ITEM_SELECTED = new Crestron.Logos.SplusObjects.AnalogInput( HOMESCREEN_ITEM_SELECTED__AnalogSerialInput__, this );
    m_AnalogInputList.Add( HOMESCREEN_ITEM_SELECTED__AnalogSerialInput__, HOMESCREEN_ITEM_SELECTED );
    
    SUBPAGEFLIP_REQUESTED = new Crestron.Logos.SplusObjects.AnalogInput( SUBPAGEFLIP_REQUESTED__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SUBPAGEFLIP_REQUESTED__AnalogSerialInput__, SUBPAGEFLIP_REQUESTED );
    
    FLIP_TO_SUBPAGE = new Crestron.Logos.SplusObjects.AnalogOutput( FLIP_TO_SUBPAGE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( FLIP_TO_SUBPAGE__AnalogSerialOutput__, FLIP_TO_SUBPAGE );
    
    NUM_HOME_SCREEN_LIST_ITEMS = new Crestron.Logos.SplusObjects.AnalogOutput( NUM_HOME_SCREEN_LIST_ITEMS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( NUM_HOME_SCREEN_LIST_ITEMS__AnalogSerialOutput__, NUM_HOME_SCREEN_LIST_ITEMS );
    
    ACTIONTYPE = new Crestron.Logos.SplusObjects.AnalogOutput( ACTIONTYPE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ACTIONTYPE__AnalogSerialOutput__, ACTIONTYPE );
    
    ACTIONITEM = new Crestron.Logos.SplusObjects.AnalogOutput( ACTIONITEM__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ACTIONITEM__AnalogSerialOutput__, ACTIONITEM );
    
    HOMESCREEN_LIST_ICONFILENAME = new InOutArray<StringOutput>( 32, this );
    for( uint i = 0; i < 32; i++ )
    {
        HOMESCREEN_LIST_ICONFILENAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( HOMESCREEN_LIST_ICONFILENAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( HOMESCREEN_LIST_ICONFILENAME__AnalogSerialOutput__ + i, HOMESCREEN_LIST_ICONFILENAME[i+1] );
    }
    
    HOMESCREEN_LIST_LABEL = new InOutArray<StringOutput>( 32, this );
    for( uint i = 0; i < 32; i++ )
    {
        HOMESCREEN_LIST_LABEL[i+1] = new Crestron.Logos.SplusObjects.StringOutput( HOMESCREEN_LIST_LABEL__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( HOMESCREEN_LIST_LABEL__AnalogSerialOutput__ + i, HOMESCREEN_LIST_LABEL[i+1] );
    }
    
    
    REQUEST_HOME_SCREEN.OnDigitalPush.Add( new InputChangeHandlerWrapper( REQUEST_HOME_SCREEN_OnPush_0, false ) );
    REQUEST_STARTUP_SUBSYTEM.OnDigitalPush.Add( new InputChangeHandlerWrapper( REQUEST_STARTUP_SUBSYTEM_OnPush_1, false ) );
    REQUEST_PERSISTENT_SUBSYSTEM.OnDigitalPush.Add( new InputChangeHandlerWrapper( REQUEST_PERSISTENT_SUBSYSTEM_OnPush_2, false ) );
    SUBPAGEFLIP_REQUESTED.OnAnalogChange.Add( new InputChangeHandlerWrapper( SUBPAGEFLIP_REQUESTED_OnChange_3, false ) );
    HOMESCREEN_ITEM_SELECTED.OnAnalogChange.Add( new InputChangeHandlerWrapper( HOMESCREEN_ITEM_SELECTED_OnChange_4, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    UIMANAGER  = new Crestron.Rio.System.SystemUIHelper();
    
    
}

public CrestronModuleClass_CSR_SYSTEM_UI_SIMPL__INTERFACE_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint REQUEST_HOME_SCREEN__DigitalInput__ = 0;
const uint REQUEST_STARTUP_SUBSYTEM__DigitalInput__ = 1;
const uint REQUEST_PERSISTENT_SUBSYSTEM__DigitalInput__ = 2;
const uint PANEL_ID__AnalogSerialInput__ = 0;
const uint HOMESCREEN_ITEM_SELECTED__AnalogSerialInput__ = 1;
const uint SUBPAGEFLIP_REQUESTED__AnalogSerialInput__ = 2;
const uint INITIALIZED__DigitalOutput__ = 0;
const uint SHOW_HOME_SCREEN__DigitalOutput__ = 1;
const uint FLIP_TO_SUBPAGE__AnalogSerialOutput__ = 0;
const uint NUM_HOME_SCREEN_LIST_ITEMS__AnalogSerialOutput__ = 1;
const uint ACTIONTYPE__AnalogSerialOutput__ = 2;
const uint ACTIONITEM__AnalogSerialOutput__ = 3;
const uint HOMESCREEN_LIST_ICONFILENAME__AnalogSerialOutput__ = 4;
const uint HOMESCREEN_LIST_LABEL__AnalogSerialOutput__ = 36;

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
