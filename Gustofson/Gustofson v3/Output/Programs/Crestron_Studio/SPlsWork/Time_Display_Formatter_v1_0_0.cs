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

namespace CrestronModule_TIME_DISPLAY_FORMATTER_V1_0_0
{
    public class CrestronModuleClass_TIME_DISPLAY_FORMATTER_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.AnalogInput INPUTTIME;
        Crestron.Logos.SplusObjects.AnalogInput INPUTTIMEUNITS;
        Crestron.Logos.SplusObjects.AnalogInput DISPLAYMODE;
        Crestron.Logos.SplusObjects.StringOutput TIMESTRING;
        CrestronString OUTPUTSTRING;
        private void FORMATSTRING (  SplusExecutionContext __context__ ) 
            { 
            CrestronString TEMPSTRING;
            TEMPSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            
            
            __context__.SourceCodeLine = 48;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INPUTTIME  .UshortValue == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 50;
                switch ((int)DISPLAYMODE  .UshortValue)
                
                    { 
                    case 2 : 
                    
                        { 
                        __context__.SourceCodeLine = 54;
                        TEMPSTRING  .UpdateValue ( "00:00:00"  ) ; 
                        __context__.SourceCodeLine = 55;
                        break ; 
                        } 
                    
                    goto case 1 ;
                    case 1 : 
                    
                        { 
                        } 
                    
                    goto default;
                    default : 
                    
                        { 
                        __context__.SourceCodeLine = 61;
                        TEMPSTRING  .UpdateValue ( "00:00"  ) ; 
                        __context__.SourceCodeLine = 62;
                        break ; 
                        } 
                    break;
                    
                    } 
                    
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 68;
                switch ((int)INPUTTIMEUNITS  .UshortValue)
                
                    { 
                    case 1 : 
                    
                        { 
                        __context__.SourceCodeLine = 72;
                        switch ((int)DISPLAYMODE  .UshortValue)
                        
                            { 
                            case 2 : 
                            
                                { 
                                __context__.SourceCodeLine = 77;
                                MakeString ( TEMPSTRING , "00:{0:d2}:{1:d2}", (short)(INPUTTIME  .UshortValue / 60000), (short)(Mod( INPUTTIME  .UshortValue , 60000 ) / 1000)) ; 
                                __context__.SourceCodeLine = 79;
                                break ; 
                                } 
                            
                            goto case 1 ;
                            case 1 : 
                            
                                { 
                                } 
                            
                            goto default;
                            default : 
                            
                                { 
                                __context__.SourceCodeLine = 86;
                                MakeString ( TEMPSTRING , "{0:d2}:{1:d2}", (short)(INPUTTIME  .UshortValue / 60000), (short)(Mod( INPUTTIME  .UshortValue , 60000 ) / 1000)) ; 
                                __context__.SourceCodeLine = 89;
                                break ; 
                                } 
                            break;
                            
                            } 
                            
                        
                        __context__.SourceCodeLine = 93;
                        break ; 
                        } 
                    
                    goto case 3 ;
                    case 3 : 
                    
                        { 
                        __context__.SourceCodeLine = 98;
                        switch ((int)DISPLAYMODE  .UshortValue)
                        
                            { 
                            case 2 : 
                            
                                { 
                                __context__.SourceCodeLine = 103;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( 0 < INPUTTIME  .UshortValue ) ) && Functions.TestForTrue ( Functions.BoolToInt ( INPUTTIME  .UshortValue <= 5999 ) )) ))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 104;
                                    MakeString ( TEMPSTRING , "{0:d2}:{1:d2}:00", (short)(INPUTTIME  .UshortValue / 60), (short)Mod( INPUTTIME  .UshortValue , 60 )) ; 
                                    }
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 106;
                                    TEMPSTRING  .UpdateValue ( "00:00:00"  ) ; 
                                    }
                                
                                __context__.SourceCodeLine = 108;
                                break ; 
                                } 
                            
                            goto case 1 ;
                            case 1 : 
                            
                                { 
                                } 
                            
                            goto default;
                            default : 
                            
                                { 
                                __context__.SourceCodeLine = 115;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( 0 < INPUTTIME  .UshortValue ) ) && Functions.TestForTrue ( Functions.BoolToInt ( INPUTTIME  .UshortValue <= 99 ) )) ))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 116;
                                    MakeString ( TEMPSTRING , "{0:d2}:00", (short)INPUTTIME  .UshortValue) ; 
                                    }
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 118;
                                    TEMPSTRING  .UpdateValue ( "00:00"  ) ; 
                                    }
                                
                                __context__.SourceCodeLine = 120;
                                break ; 
                                } 
                            break;
                            
                            } 
                            
                        
                        __context__.SourceCodeLine = 124;
                        break ; 
                        } 
                    
                    goto case 4 ;
                    case 4 : 
                    
                        { 
                        __context__.SourceCodeLine = 129;
                        switch ((int)DISPLAYMODE  .UshortValue)
                        
                            { 
                            case 2 : 
                            
                                { 
                                __context__.SourceCodeLine = 134;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( 0 < INPUTTIME  .UshortValue ) ) && Functions.TestForTrue ( Functions.BoolToInt ( INPUTTIME  .UshortValue <= 99 ) )) ))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 135;
                                    MakeString ( TEMPSTRING , "{0:d2}:00:00", (short)INPUTTIME  .UshortValue) ; 
                                    }
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 137;
                                    TEMPSTRING  .UpdateValue ( "00:00:00"  ) ; 
                                    }
                                
                                __context__.SourceCodeLine = 139;
                                break ; 
                                } 
                            
                            goto case 1 ;
                            case 1 : 
                            
                                { 
                                } 
                            
                            goto default;
                            default : 
                            
                                { 
                                __context__.SourceCodeLine = 145;
                                TEMPSTRING  .UpdateValue ( "00:00"  ) ; 
                                __context__.SourceCodeLine = 146;
                                break ; 
                                } 
                            break;
                            
                            } 
                            
                        
                        __context__.SourceCodeLine = 150;
                        break ; 
                        } 
                    
                    goto case 2 ;
                    case 2 : 
                    
                        { 
                        } 
                    
                    goto default;
                    default : 
                    
                        { 
                        __context__.SourceCodeLine = 156;
                        switch ((int)DISPLAYMODE  .UshortValue)
                        
                            { 
                            case 2 : 
                            
                                { 
                                __context__.SourceCodeLine = 161;
                                MakeString ( TEMPSTRING , "{0:d2}:{1:d2}:{2:d2}", (short)(INPUTTIME  .UshortValue / 3600), (short)(Mod( INPUTTIME  .UshortValue , 3600 ) / 60), (short)Mod( INPUTTIME  .UshortValue , 60 )) ; 
                                __context__.SourceCodeLine = 163;
                                break ; 
                                } 
                            
                            goto case 1 ;
                            case 1 : 
                            
                                { 
                                } 
                            
                            goto default;
                            default : 
                            
                                { 
                                __context__.SourceCodeLine = 170;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( 0 < INPUTTIME  .UshortValue ) ) && Functions.TestForTrue ( Functions.BoolToInt ( INPUTTIME  .UshortValue <= 5999 ) )) ))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 171;
                                    MakeString ( TEMPSTRING , "{0:d2}:{1:d2}", (short)(INPUTTIME  .UshortValue / 60), (short)Mod( INPUTTIME  .UshortValue , 60 )) ; 
                                    }
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 173;
                                    TEMPSTRING  .UpdateValue ( "00:00"  ) ; 
                                    }
                                
                                __context__.SourceCodeLine = 175;
                                break ; 
                                } 
                            break;
                            
                            } 
                            
                        
                        __context__.SourceCodeLine = 179;
                        break ; 
                        } 
                    break;
                    
                    } 
                    
                
                } 
            
            __context__.SourceCodeLine = 184;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSTRING != OUTPUTSTRING))  ) ) 
                { 
                __context__.SourceCodeLine = 186;
                OUTPUTSTRING  .UpdateValue ( TEMPSTRING  ) ; 
                __context__.SourceCodeLine = 187;
                TIMESTRING  .UpdateValue ( TEMPSTRING  ) ; 
                } 
            
            
            }
            
        object INPUTTIME_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 193;
                FORMATSTRING (  __context__  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object INPUTTIMEUNITS_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 198;
            FORMATSTRING (  __context__  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object DISPLAYMODE_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 203;
        FORMATSTRING (  __context__  ) ; 
        
        
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
        
        __context__.SourceCodeLine = 208;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 209;
        FORMATSTRING (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    OUTPUTSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    
    INPUTTIME = new Crestron.Logos.SplusObjects.AnalogInput( INPUTTIME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( INPUTTIME__AnalogSerialInput__, INPUTTIME );
    
    INPUTTIMEUNITS = new Crestron.Logos.SplusObjects.AnalogInput( INPUTTIMEUNITS__AnalogSerialInput__, this );
    m_AnalogInputList.Add( INPUTTIMEUNITS__AnalogSerialInput__, INPUTTIMEUNITS );
    
    DISPLAYMODE = new Crestron.Logos.SplusObjects.AnalogInput( DISPLAYMODE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( DISPLAYMODE__AnalogSerialInput__, DISPLAYMODE );
    
    TIMESTRING = new Crestron.Logos.SplusObjects.StringOutput( TIMESTRING__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TIMESTRING__AnalogSerialOutput__, TIMESTRING );
    
    
    INPUTTIME.OnAnalogChange.Add( new InputChangeHandlerWrapper( INPUTTIME_OnChange_0, false ) );
    INPUTTIMEUNITS.OnAnalogChange.Add( new InputChangeHandlerWrapper( INPUTTIMEUNITS_OnChange_1, false ) );
    DISPLAYMODE.OnAnalogChange.Add( new InputChangeHandlerWrapper( DISPLAYMODE_OnChange_2, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_TIME_DISPLAY_FORMATTER_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint INPUTTIME__AnalogSerialInput__ = 0;
const uint INPUTTIMEUNITS__AnalogSerialInput__ = 1;
const uint DISPLAYMODE__AnalogSerialInput__ = 2;
const uint TIMESTRING__AnalogSerialOutput__ = 0;

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
