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

namespace CrestronModule_TIMEDATE_DISPLAY
{
    public class CrestronModuleClass_TIMEDATE_DISPLAY : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.AnalogInput MORNING_HOUR;
        Crestron.Logos.SplusObjects.AnalogInput MORNING_MINUTE;
        Crestron.Logos.SplusObjects.AnalogInput NIGHT_HOUR;
        Crestron.Logos.SplusObjects.AnalogInput NIGHT_MINUTE;
        Crestron.Logos.SplusObjects.DigitalInput REPORT_TIMEINFO;
        private CrestronString GETFORMATTEDTIME (  SplusExecutionContext __context__, ushort IHOURS , ushort IMINUTES , ushort ISECONDS ) 
            { 
            CrestronString STIME;
            STIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 12, this );
            
            
            __context__.SourceCodeLine = 14;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IHOURS == 0))  ) ) 
                {
                __context__.SourceCodeLine = 15;
                MakeString ( STIME , "12:{0:d2}:{1:d2} AM", (short)IMINUTES, (short)ISECONDS) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 16;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHOURS < 12 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 17;
                    MakeString ( STIME , "{0:d}:{1:d2}:{2:d2} AM", (short)IHOURS, (short)IMINUTES, (short)ISECONDS) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 18;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IHOURS == 12))  ) ) 
                        {
                        __context__.SourceCodeLine = 19;
                        MakeString ( STIME , "12:{0:d2}:{1:d2} PM", (short)IMINUTES, (short)ISECONDS) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 21;
                        MakeString ( STIME , "{0:d}:{1:d2}:{2:d2} PM", (short)(IHOURS - 12), (short)IMINUTES, (short)ISECONDS) ; 
                        }
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 23;
            return ( STIME ) ; 
            
            }
            
        object REPORT_TIMEINFO_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 28;
                Print( "\r\nSystem Time/Date info:\r\n") ; 
                __context__.SourceCodeLine = 29;
                Print( "----------------------\r\n") ; 
                __context__.SourceCodeLine = 30;
                Print( "Today's date: {0:d2}/{1:d2}/{2:d}\r\n\r\n", (short)Functions.GetMonthNum(), (short)Functions.GetDateNum(), (short)Functions.GetYearNum()) ; 
                __context__.SourceCodeLine = 31;
                Print( "Current Time: {0}\r\n\r\n", GETFORMATTEDTIME (  __context__ , (ushort)( Functions.GetHourNum() ), (ushort)( Functions.GetMinutesNum() ), (ushort)( Functions.GetSecondsNum() )) ) ; 
                __context__.SourceCodeLine = 32;
                Print( "Sunrise today occurs at {0}\r\n", GETFORMATTEDTIME (  __context__ , (ushort)( MORNING_HOUR  .UshortValue ), (ushort)( MORNING_MINUTE  .UshortValue ), (ushort)( 0 )) ) ; 
                __context__.SourceCodeLine = 33;
                Print( "Sunset today occurs at {0}\r\n", GETFORMATTEDTIME (  __context__ , (ushort)( NIGHT_HOUR  .UshortValue ), (ushort)( NIGHT_MINUTE  .UshortValue ), (ushort)( 0 )) ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        REPORT_TIMEINFO = new Crestron.Logos.SplusObjects.DigitalInput( REPORT_TIMEINFO__DigitalInput__, this );
        m_DigitalInputList.Add( REPORT_TIMEINFO__DigitalInput__, REPORT_TIMEINFO );
        
        MORNING_HOUR = new Crestron.Logos.SplusObjects.AnalogInput( MORNING_HOUR__AnalogSerialInput__, this );
        m_AnalogInputList.Add( MORNING_HOUR__AnalogSerialInput__, MORNING_HOUR );
        
        MORNING_MINUTE = new Crestron.Logos.SplusObjects.AnalogInput( MORNING_MINUTE__AnalogSerialInput__, this );
        m_AnalogInputList.Add( MORNING_MINUTE__AnalogSerialInput__, MORNING_MINUTE );
        
        NIGHT_HOUR = new Crestron.Logos.SplusObjects.AnalogInput( NIGHT_HOUR__AnalogSerialInput__, this );
        m_AnalogInputList.Add( NIGHT_HOUR__AnalogSerialInput__, NIGHT_HOUR );
        
        NIGHT_MINUTE = new Crestron.Logos.SplusObjects.AnalogInput( NIGHT_MINUTE__AnalogSerialInput__, this );
        m_AnalogInputList.Add( NIGHT_MINUTE__AnalogSerialInput__, NIGHT_MINUTE );
        
        
        REPORT_TIMEINFO.OnDigitalPush.Add( new InputChangeHandlerWrapper( REPORT_TIMEINFO_OnPush_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public CrestronModuleClass_TIMEDATE_DISPLAY ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint MORNING_HOUR__AnalogSerialInput__ = 0;
    const uint MORNING_MINUTE__AnalogSerialInput__ = 1;
    const uint NIGHT_HOUR__AnalogSerialInput__ = 2;
    const uint NIGHT_MINUTE__AnalogSerialInput__ = 3;
    const uint REPORT_TIMEINFO__DigitalInput__ = 0;
    
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
