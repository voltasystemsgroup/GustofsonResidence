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

namespace CrestronModule_CSR_MEDIA_TEXTUAL_VOLUME_CONVERTER_V1_0_0
{
    public class CrestronModuleClass_CSR_MEDIA_TEXTUAL_VOLUME_CONVERTER_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput EVALUATEPERCENTAGEVOLUME;
        Crestron.Logos.SplusObjects.DigitalInput HIDEDECIBELDECIMAL;
        Crestron.Logos.SplusObjects.AnalogInput VOLUMEDISPLAYMODE;
        Crestron.Logos.SplusObjects.AnalogInput VOLUMEPERCENTAGEFB;
        Crestron.Logos.SplusObjects.AnalogInput VOLUMEDECIBELFB;
        Crestron.Logos.SplusObjects.AnalogInput DECIBELSTEPSIZE;
        Crestron.Logos.SplusObjects.StringOutput TEXTUALVOLUME;
        short SIGNEDSTEPSIZE = 0;
        short SIGNEDDECIBELVOLUME = 0;
        CrestronString PERCENTAGESTRING;
        CrestronString DECIBELSTRING;
        private void CREATESTRING (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 47;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VOLUMEDISPLAYMODE  .UshortValue == 0))  ) ) 
                {
                __context__.SourceCodeLine = 48;
                MakeString ( TEXTUALVOLUME , "{0}", PERCENTAGESTRING ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 49;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VOLUMEDISPLAYMODE  .UshortValue == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 50;
                    MakeString ( TEXTUALVOLUME , "{0}", DECIBELSTRING ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 51;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VOLUMEDISPLAYMODE  .UshortValue == 2))  ) ) 
                        {
                        __context__.SourceCodeLine = 52;
                        MakeString ( TEXTUALVOLUME , "{0} ({1})", PERCENTAGESTRING , DECIBELSTRING ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 53;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VOLUMEDISPLAYMODE  .UshortValue == 3))  ) ) 
                            {
                            __context__.SourceCodeLine = 54;
                            MakeString ( TEXTUALVOLUME , "{0} ({1})", DECIBELSTRING , PERCENTAGESTRING ) ; 
                            }
                        
                        }
                    
                    }
                
                }
            
            
            }
            
        object EVALUATEPERCENTAGEVOLUME_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                uint LONGVOLUME = 0;
                
                
                __context__.SourceCodeLine = 61;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VOLUMEDISPLAYMODE  .UshortValue != 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 63;
                    LONGVOLUME = (uint) ( (100 * VOLUMEPERCENTAGEFB  .UintValue) ) ; 
                    __context__.SourceCodeLine = 65;
                    MakeString ( PERCENTAGESTRING , "{0:d}%", (short)(LONGVOLUME / 65535)) ; 
                    __context__.SourceCodeLine = 66;
                    CREATESTRING (  __context__  ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object VOLUMEDECIBELFB_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 72;
            SIGNEDSTEPSIZE = (short) ( DECIBELSTEPSIZE  .ShortValue ) ; 
            __context__.SourceCodeLine = 73;
            SIGNEDDECIBELVOLUME = (short) ( VOLUMEDECIBELFB  .ShortValue ) ; 
            __context__.SourceCodeLine = 75;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.ToSignedLongInteger( -( 1 ) ) * SIGNEDSTEPSIZE) < SIGNEDDECIBELVOLUME ) ) && Functions.TestForTrue ( Functions.BoolToInt ( SIGNEDDECIBELVOLUME < 0 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 77;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HIDEDECIBELDECIMAL  .Value == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 78;
                    DECIBELSTRING  .UpdateValue ( "0 dB"  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 80;
                    MakeString ( DECIBELSTRING , "-0.{0:d} dB", (short)Functions.Abs( Mod( SIGNEDDECIBELVOLUME , SIGNEDSTEPSIZE ) )) ; 
                    }
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 84;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HIDEDECIBELDECIMAL  .Value == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 85;
                    MakeString ( DECIBELSTRING , "{0:d} dB", (short)(SIGNEDDECIBELVOLUME / SIGNEDSTEPSIZE)) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 87;
                    MakeString ( DECIBELSTRING , "{0:d}.{1:d} dB", (short)(SIGNEDDECIBELVOLUME / SIGNEDSTEPSIZE), (short)Functions.Abs( Mod( SIGNEDDECIBELVOLUME , SIGNEDSTEPSIZE ) )) ; 
                    }
                
                } 
            
            __context__.SourceCodeLine = 90;
            CREATESTRING (  __context__  ) ; 
            
            
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
        
        __context__.SourceCodeLine = 96;
        PERCENTAGESTRING  .UpdateValue ( "0%"  ) ; 
        __context__.SourceCodeLine = 98;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HIDEDECIBELDECIMAL  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 99;
            DECIBELSTRING  .UpdateValue ( "0 dB"  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 101;
            DECIBELSTRING  .UpdateValue ( "0.0 dB"  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    PERCENTAGESTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    DECIBELSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    
    EVALUATEPERCENTAGEVOLUME = new Crestron.Logos.SplusObjects.DigitalInput( EVALUATEPERCENTAGEVOLUME__DigitalInput__, this );
    m_DigitalInputList.Add( EVALUATEPERCENTAGEVOLUME__DigitalInput__, EVALUATEPERCENTAGEVOLUME );
    
    HIDEDECIBELDECIMAL = new Crestron.Logos.SplusObjects.DigitalInput( HIDEDECIBELDECIMAL__DigitalInput__, this );
    m_DigitalInputList.Add( HIDEDECIBELDECIMAL__DigitalInput__, HIDEDECIBELDECIMAL );
    
    VOLUMEDISPLAYMODE = new Crestron.Logos.SplusObjects.AnalogInput( VOLUMEDISPLAYMODE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( VOLUMEDISPLAYMODE__AnalogSerialInput__, VOLUMEDISPLAYMODE );
    
    VOLUMEPERCENTAGEFB = new Crestron.Logos.SplusObjects.AnalogInput( VOLUMEPERCENTAGEFB__AnalogSerialInput__, this );
    m_AnalogInputList.Add( VOLUMEPERCENTAGEFB__AnalogSerialInput__, VOLUMEPERCENTAGEFB );
    
    VOLUMEDECIBELFB = new Crestron.Logos.SplusObjects.AnalogInput( VOLUMEDECIBELFB__AnalogSerialInput__, this );
    m_AnalogInputList.Add( VOLUMEDECIBELFB__AnalogSerialInput__, VOLUMEDECIBELFB );
    
    DECIBELSTEPSIZE = new Crestron.Logos.SplusObjects.AnalogInput( DECIBELSTEPSIZE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( DECIBELSTEPSIZE__AnalogSerialInput__, DECIBELSTEPSIZE );
    
    TEXTUALVOLUME = new Crestron.Logos.SplusObjects.StringOutput( TEXTUALVOLUME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TEXTUALVOLUME__AnalogSerialOutput__, TEXTUALVOLUME );
    
    
    EVALUATEPERCENTAGEVOLUME.OnDigitalPush.Add( new InputChangeHandlerWrapper( EVALUATEPERCENTAGEVOLUME_OnPush_0, false ) );
    VOLUMEDECIBELFB.OnAnalogChange.Add( new InputChangeHandlerWrapper( VOLUMEDECIBELFB_OnChange_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_CSR_MEDIA_TEXTUAL_VOLUME_CONVERTER_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint EVALUATEPERCENTAGEVOLUME__DigitalInput__ = 0;
const uint HIDEDECIBELDECIMAL__DigitalInput__ = 1;
const uint VOLUMEDISPLAYMODE__AnalogSerialInput__ = 0;
const uint VOLUMEPERCENTAGEFB__AnalogSerialInput__ = 1;
const uint VOLUMEDECIBELFB__AnalogSerialInput__ = 2;
const uint DECIBELSTEPSIZE__AnalogSerialInput__ = 3;
const uint TEXTUALVOLUME__AnalogSerialOutput__ = 0;

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
