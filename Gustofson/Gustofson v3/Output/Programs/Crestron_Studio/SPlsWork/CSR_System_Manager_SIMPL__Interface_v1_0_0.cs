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

namespace CrestronModule_CSR_SYSTEM_MANAGER_SIMPL__INTERFACE_V1_0_0
{
    public class CrestronModuleClass_CSR_SYSTEM_MANAGER_SIMPL__INTERFACE_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.StringInput FILENAME;
        Crestron.Logos.SplusObjects.StringInput UUID;
        public override object FunctionMain (  object __obj__ ) 
            { 
            try
            {
                SplusExecutionContext __context__ = SplusFunctionMainStartCode();
                
                __context__.SourceCodeLine = 31;
                WaitForInitializationComplete ( ) ; 
                __context__.SourceCodeLine = 32;
                 SystemManager.Settings.Initialize(  FILENAME .ToSimplSharpString() ,  UUID .ToSimplSharpString() )  ;  
 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler(); }
            return __obj__;
            }
            
        
        public override void LogosSplusInitialize()
        {
            _SplusNVRAM = new SplusNVRAM( this );
            
            FILENAME = new Crestron.Logos.SplusObjects.StringInput( FILENAME__AnalogSerialInput__, 255, this );
            m_StringInputList.Add( FILENAME__AnalogSerialInput__, FILENAME );
            
            UUID = new Crestron.Logos.SplusObjects.StringInput( UUID__AnalogSerialInput__, 255, this );
            m_StringInputList.Add( UUID__AnalogSerialInput__, UUID );
            
            
            
            _SplusNVRAM.PopulateCustomAttributeList( true );
            
            NVRAM = _SplusNVRAM;
            
        }
        
        public override void LogosSimplSharpInitialize()
        {
            
            
        }
        
        public CrestronModuleClass_CSR_SYSTEM_MANAGER_SIMPL__INTERFACE_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
        
        
        
        
        const uint FILENAME__AnalogSerialInput__ = 0;
        const uint UUID__AnalogSerialInput__ = 1;
        
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
