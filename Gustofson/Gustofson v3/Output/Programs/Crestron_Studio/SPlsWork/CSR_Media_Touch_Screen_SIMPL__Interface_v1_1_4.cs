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

namespace CrestronModule_CSR_MEDIA_TOUCH_SCREEN_SIMPL__INTERFACE_V1_1_4
{
    public class CrestronModuleClass_CSR_MEDIA_TOUCH_SCREEN_SIMPL__INTERFACE_V1_1_4 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput ROOMON;
        Crestron.Logos.SplusObjects.DigitalInput ROOMOFF;
        Crestron.Logos.SplusObjects.DigitalInput ALLROOMSOFF;
        Crestron.Logos.SplusObjects.DigitalInput ROOMSSHARINGSOURCEOFF;
        Crestron.Logos.SplusObjects.DigitalInput SELECTEDENDPOINTOFF;
        Crestron.Logos.SplusObjects.DigitalInput REQUESTSOURCESELECT;
        Crestron.Logos.SplusObjects.DigitalInput REQUESTSTANDARDSOURCESELECT;
        Crestron.Logos.SplusObjects.DigitalInput REQUESTADVANCEDSOURCESELECT;
        Crestron.Logos.SplusObjects.DigitalInput REQUESTROOMSELECT;
        Crestron.Logos.SplusObjects.DigitalInput REQUESTSOURCESHARE;
        Crestron.Logos.SplusObjects.DigitalInput REQUESTACTIVESOURCE;
        Crestron.Logos.SplusObjects.DigitalInput REQUESTMEDIAHOME;
        Crestron.Logos.SplusObjects.DigitalInput REQUESTSELECTEDENDPOINTACTIVESOURCE;
        Crestron.Logos.SplusObjects.DigitalInput REQUESTEDSOURCEPAGEISVALID;
        Crestron.Logos.SplusObjects.DigitalInput SOURCESHAREALL;
        Crestron.Logos.SplusObjects.DigitalInput DISMISSACTIVEPAGE;
        Crestron.Logos.SplusObjects.AnalogInput TOUCHSCREENID;
        Crestron.Logos.SplusObjects.AnalogInput REQUESTROOMCONTROL;
        Crestron.Logos.SplusObjects.AnalogInput SOURCELISTITEMCLICKED;
        Crestron.Logos.SplusObjects.AnalogInput ENDPOINTLISTITEMCLICKED;
        Crestron.Logos.SplusObjects.AnalogInput ACTIVESOURCELISTITEMCLICKED;
        Crestron.Logos.SplusObjects.AnalogInput ROOMLISTITEMCLICKED;
        Crestron.Logos.SplusObjects.DigitalOutput TOUCHSCREENINITIALIZED;
        Crestron.Logos.SplusObjects.DigitalOutput MEDIAINITIALIZATIONINPOGRESS;
        Crestron.Logos.SplusObjects.DigitalOutput ROOMISON;
        Crestron.Logos.SplusObjects.DigitalOutput ROOMISOFF;
        Crestron.Logos.SplusObjects.DigitalOutput AUDIOENDPOINTISON;
        Crestron.Logos.SplusObjects.DigitalOutput ROOMHASACTIVESOURCE;
        Crestron.Logos.SplusObjects.DigitalOutput SELECTEDENDPOINTHASACTIVESOURCE;
        Crestron.Logos.SplusObjects.DigitalOutput SHOWSOURCESELECT;
        Crestron.Logos.SplusObjects.DigitalOutput SHOWADVANCEDSOURCESELECT;
        Crestron.Logos.SplusObjects.DigitalOutput SHOWROOMSELECT;
        Crestron.Logos.SplusObjects.DigitalOutput SHOWSOURCESHARE;
        Crestron.Logos.SplusObjects.DigitalOutput SHOWACTIVESOURCESELECT;
        Crestron.Logos.SplusObjects.DigitalOutput ANYMEDIAPAGEACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput SHOWSOURCESELECTBUTTON;
        Crestron.Logos.SplusObjects.DigitalOutput SHOWADVANCEDSOURCESELECTBUTTON;
        Crestron.Logos.SplusObjects.DigitalOutput SHOWROOMSELECTBUTTON;
        Crestron.Logos.SplusObjects.DigitalOutput SHOWSOURCESHAREBUTTON;
        Crestron.Logos.SplusObjects.AnalogOutput SELECTEDROOMID;
        Crestron.Logos.SplusObjects.AnalogOutput ROOMEQUIPMENTIDTOCONNECT;
        Crestron.Logos.SplusObjects.AnalogOutput ROOMSOURCE;
        Crestron.Logos.SplusObjects.AnalogOutput AUDIOSOURCE;
        Crestron.Logos.SplusObjects.AnalogOutput PRIMARYVIDEOSOURCE;
        Crestron.Logos.SplusObjects.AnalogOutput SOURCEPAGETOSHOW;
        Crestron.Logos.SplusObjects.AnalogOutput SOURCELISTITEMCOUNT;
        Crestron.Logos.SplusObjects.AnalogOutput ENDPOINTLISTITEMCOUNT;
        Crestron.Logos.SplusObjects.AnalogOutput ACTIVESOURCELISTITEMCOUNT;
        Crestron.Logos.SplusObjects.AnalogOutput ROOMLISTITEMCOUNT;
        Crestron.Logos.SplusObjects.StringOutput ROOMNAME;
        Crestron.Logos.SplusObjects.StringOutput SOURCENAME;
        Crestron.Logos.SplusObjects.StringOutput SOURCENOWPLAYINGLINE1;
        Crestron.Logos.SplusObjects.StringOutput SOURCENOWPLAYINGLINE2;
        Crestron.Logos.SplusObjects.StringOutput SOURCEBUTTONLABEL;
        Crestron.Logos.SplusObjects.StringOutput AUDIOENDPOINTNAME;
        Crestron.Logos.SplusObjects.StringOutput AUDIOSOURCENAME;
        Crestron.Logos.SplusObjects.StringOutput PRIMARYVIDEOENDPOINTNAME;
        Crestron.Logos.SplusObjects.StringOutput PRIMARYVIDEOSOURCENAME;
        Crestron.Logos.SplusObjects.StringOutput SOURCELISTSELECTEDSOURCENAME;
        Crestron.Logos.SplusObjects.StringOutput SELECTEDENDPOINTNAME;
        Crestron.Logos.SplusObjects.StringOutput SELECTEDENDPOINTACTIVESOURCENAME;
        Crestron.Logos.SplusObjects.StringOutput SELECTEDENDPOINTACTIVESOURCEICON;
        Crestron.Logos.SplusObjects.StringOutput CONTROLLEDSOURCENAME;
        Crestron.Logos.SplusObjects.StringOutput CONTROLLEDSOURCEICON;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> SOURCELISTITEMSELECTED;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> ENDPOINTLISTITEMENABLED;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> SOURCESHARINGLISTITEMENABLED;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> ALTERNATEVIDEOSOURCE;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> ALTERNATEVIDEOENDPOINTNAME;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> ALTERNATEVIDEOSOURCENAME;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SOURCELISTITEMNAME;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SOURCELISTICONFILENAME;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> ENDPOINTLISTITEMNAME;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> ENDPOINTLISTSOURCENAME;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> ENDPOINTLISTICONFILENAME;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> ACTIVESOURCELISTITEMNAME;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> ACTIVESOURCELISTICONFILENAME;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> ROOMLISTITEMNAME;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> ROOMLISTSOURCENAME;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SOURCESHARINGLISTICONFILENAME;
        UShortParameter ADVANCEDSOURCESELECTIONBUTTONBEHAVIOR;
        Crestron.Rio.DataStructures.Media.UserInterfaces.MediaTouchScreenSSharpComponent MEDIAUI;
        Crestron.Rio.DataStructures.Media.UserInterfaces.DynamicMediaUserInterface DYNAMICMEDIAUI;
        ushort TOUCHSCREENIDSET = 0;
        ushort MEDIASUBSYSTEMINITIALIZED = 0;
        object ROOMON_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 132;
                MEDIAUI . TurnRoomOn ( ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object ROOMOFF_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 137;
            MEDIAUI . TurnRoomOff ( ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object ALLROOMSOFF_OnPush_2 ( Object __EventInfo__ )

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

object ROOMSSHARINGSOURCEOFF_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 147;
        MEDIAUI . TurnOffAllRoomsWithCurrentSource ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECTEDENDPOINTOFF_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 152;
        MEDIAUI . TurnSelectedEndpointOff ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REQUESTSOURCESELECT_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 157;
        MEDIAUI . RequestSourceSelectionPage ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REQUESTSTANDARDSOURCESELECT_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 162;
        MEDIAUI . RequestStandardSourceSelectionPage ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REQUESTADVANCEDSOURCESELECT_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 167;
        MEDIAUI . RequestAdvancedSourceSelectionPage ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REQUESTROOMSELECT_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 172;
        MEDIAUI . RequestRoomSelectionPage ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REQUESTSOURCESHARE_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 177;
        MEDIAUI . RequestSourceSharingPage ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REQUESTACTIVESOURCE_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 182;
        MEDIAUI . RequestActiveSourceControl ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REQUESTMEDIAHOME_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 187;
        MEDIAUI . RequestMediaHomePage ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REQUESTSELECTEDENDPOINTACTIVESOURCE_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 192;
        MEDIAUI . RequestSelectedEndpointActiveSourcePage ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REQUESTEDSOURCEPAGEISVALID_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 197;
        MEDIAUI . SourceControlPageVerified ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCESHAREALL_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 202;
        MEDIAUI . ShareSourceWithAll ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DISMISSACTIVEPAGE_OnRelease_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 207;
        MEDIAUI . DismissActivePage ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TOUCHSCREENID_OnChange_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 212;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TOUCHSCREENIDSET == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 214;
            TOUCHSCREENIDSET = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 217;
            DYNAMICMEDIAUI . Initialize ( (int)( TOUCHSCREENID  .IntValue )) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REQUESTROOMCONTROL_OnChange_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 223;
        MEDIAUI . RequestRoomControl ( (int)( REQUESTROOMCONTROL  .IntValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCELISTITEMCLICKED_OnChange_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 228;
        MEDIAUI . SourceListItemSelected ( (int)( (SOURCELISTITEMCLICKED  .IntValue - 1) )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENDPOINTLISTITEMCLICKED_OnChange_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 233;
        MEDIAUI . EndpointListItemSelected ( (int)( (ENDPOINTLISTITEMCLICKED  .IntValue - 1) )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ACTIVESOURCELISTITEMCLICKED_OnChange_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 238;
        MEDIAUI . ActiveSourcesListItemSelected ( (int)( (ACTIVESOURCELISTITEMCLICKED  .IntValue - 1) )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOMLISTITEMCLICKED_OnChange_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 243;
        MEDIAUI . RoomListItemSelected ( (int)( (ROOMLISTITEMCLICKED  .IntValue - 1) )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void TOUCHSCREENINITIALIZEDCALLBACK ( ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 248;
        TOUCHSCREENINITIALIZED  .Value = (ushort) ( 1 ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void MEDIAMIDPOINTSINITIALIZEDCALLBACK ( ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 253;
        MEDIAINITIALIZATIONINPOGRESS  .Value = (ushort) ( 0 ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void CONNECTNEWROOMCALLBACK ( int NEWROOMCROSSPOINTID ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 258;
        ROOMEQUIPMENTIDTOCONNECT  .Value = (ushort) ( Functions.LowWord( (uint)( NEWROOMCROSSPOINTID ) ) ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void SETROOMONFEEDBACKCALLBACK ( ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 263;
        ROOMISOFF  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 264;
        ROOMISON  .Value = (ushort) ( 1 ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void SETROOMOFFFEEDBACKCALLBACK ( ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 269;
        ROOMISON  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 270;
        ROOMISOFF  .Value = (ushort) ( 1 ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESELECTEDROOMIDCALLBACK ( int ROOMID ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 275;
        SELECTEDROOMID  .Value = (ushort) ( Functions.LowWord( (uint)( ROOMID ) ) ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESELECTEDSOURCEIDCALLBACK ( int SOURCEID ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 280;
        ROOMSOURCE  .Value = (ushort) ( Functions.LowWord( (uint)( SOURCEID ) ) ) ; 
        __context__.SourceCodeLine = 282;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SOURCEID > 0 ))  ) ) 
            {
            __context__.SourceCodeLine = 283;
            ROOMHASACTIVESOURCE  .Value = (ushort) ( 1 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 285;
            ROOMHASACTIVESOURCE  .Value = (ushort) ( 0 ) ; 
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESELECTEDROOMNAMECALLBACK ( SimplSharpString ROOMNAMEFROMSSHARP ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 290;
        ROOMNAME  .UpdateValue ( ROOMNAMEFROMSSHARP  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESELECTEDSOURCENAMECALLBACK ( SimplSharpString SOURCENAMEFROMSSHARP ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 295;
        SOURCENAME  .UpdateValue ( SOURCENAMEFROMSSHARP  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATENOWPLAYINGLINE1CALLBACK ( SimplSharpString NOWPLAYINGINFORMATION ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 300;
        SOURCENOWPLAYINGLINE1  .UpdateValue ( NOWPLAYINGINFORMATION  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATENOWPLAYINGLINE2CALLBACK ( SimplSharpString NOWPLAYINGINFORMATION ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 305;
        SOURCENOWPLAYINGLINE2  .UpdateValue ( NOWPLAYINGINFORMATION  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESOURCEDISPLAYNAMECALLBACK ( SimplSharpString SOURCENAME ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 310;
        SOURCEBUTTONLABEL  .UpdateValue ( SOURCENAME  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEAUDIOENDPOINTSOURCEIDCALLBACK ( int SOURCEID ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 315;
        AUDIOSOURCE  .Value = (ushort) ( Functions.LowWord( (uint)( SOURCEID ) ) ) ; 
        __context__.SourceCodeLine = 317;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SOURCEID > 0 ))  ) ) 
            {
            __context__.SourceCodeLine = 318;
            AUDIOENDPOINTISON  .Value = (ushort) ( 1 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 320;
            AUDIOENDPOINTISON  .Value = (ushort) ( 0 ) ; 
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEAUDIOENDPOINTNAMECALLBACK ( SimplSharpString ENDPOINTNAME ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 325;
        AUDIOENDPOINTNAME  .UpdateValue ( ENDPOINTNAME  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEAUDIOENDPOINTSOURCENAMECALLBACK ( SimplSharpString SOURCENAME ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 330;
        AUDIOSOURCENAME  .UpdateValue ( SOURCENAME  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEPRIMARYVIDEOENDPOINTSOURCEIDCALLBACK ( int SOURCEID ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 336;
        PRIMARYVIDEOSOURCE  .Value = (ushort) ( Functions.LowWord( (uint)( SOURCEID ) ) ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEPRIMARYVIDEOENDPOINTNAMECALLBACK ( SimplSharpString ENDPOINTNAME ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 341;
        PRIMARYVIDEOENDPOINTNAME  .UpdateValue ( ENDPOINTNAME  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEPRIMARYVIDEOENDPOINTSOURCENAMECALLBACK ( SimplSharpString SOURCENAME ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 346;
        PRIMARYVIDEOSOURCENAME  .UpdateValue ( SOURCENAME  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEALTERNATEVIDEOENDPOINTSOURCEIDBYINDEXCALLBACK ( int [] TEMP ) 
    { 
    ushort INDEX = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 356;
        INDEX = (ushort) ( Functions.LowWord( (uint)( TEMP[ 0 ] ) ) ) ; 
        __context__.SourceCodeLine = 358;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEX < 3 ))  ) ) 
            {
            __context__.SourceCodeLine = 359;
            ALTERNATEVIDEOSOURCE [ (INDEX + 1)]  .Value = (ushort) ( Functions.LowWord( (uint)( TEMP[ 1 ] ) ) ) ; 
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEALTERNATEVIDEOENDPOINTNAMEBYINDEXCALLBACK ( int INDEX , SimplSharpString ENDPOINTNAME ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 364;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEX < 3 ))  ) ) 
            {
            __context__.SourceCodeLine = 365;
            ALTERNATEVIDEOENDPOINTNAME [ (INDEX + 1)]  .UpdateValue ( ENDPOINTNAME  .ToString()  ) ; 
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEALTERNATEVIDEOENDPOINTSOURCENAMEBYINDEXCALLBACK ( int INDEX , SimplSharpString SOURCENAME ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 370;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEX < 3 ))  ) ) 
            {
            __context__.SourceCodeLine = 371;
            ALTERNATEVIDEOSOURCENAME [ (INDEX + 1)]  .UpdateValue ( SOURCENAME  .ToString()  ) ; 
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void CLEARREMAININGALTERNATEVIDEOENDPOINTSCALLBACK ( int ITEMCOUNT ) 
    { 
    ushort I = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 378;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITEMCOUNT < 3 ))  ) ) 
            { 
            __context__.SourceCodeLine = 380;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( (ITEMCOUNT + 1) ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)3; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 382;
                ALTERNATEVIDEOSOURCE [ I]  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 383;
                ALTERNATEVIDEOENDPOINTNAME [ I]  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 384;
                ALTERNATEVIDEOSOURCENAME [ I]  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 380;
                } 
            
            } 
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEROOMLISTROOMNAMEBYINDEXCALLBACK ( int INDEX , SimplSharpString ROOMNAME ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 392;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEX < 100 ))  ) ) 
            {
            __context__.SourceCodeLine = 393;
            ROOMLISTITEMNAME [ (INDEX + 1)]  .UpdateValue ( ROOMNAME  .ToString()  ) ; 
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEROOMLISTSOURCENAMEBYINDEXCALLBACK ( int INDEX , SimplSharpString SOURCENAME ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 398;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEX < 100 ))  ) ) 
            {
            __context__.SourceCodeLine = 399;
            ROOMLISTSOURCENAME [ (INDEX + 1)]  .UpdateValue ( SOURCENAME  .ToString()  ) ; 
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESOURCESHARINGLISTACTIVESOURCECOMPARISONBYINDEXCALLBACK ( int INDEX , SimplSharpString ICONFILENAME ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 404;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEX < 100 ))  ) ) 
            {
            __context__.SourceCodeLine = 405;
            SOURCESHARINGLISTICONFILENAME [ (INDEX + 1)]  .UpdateValue ( ICONFILENAME  .ToString()  ) ; 
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESOURCESHARINGLISTSELECTIONENABLEDBYINDEXCALLBACK ( int [] TEMP ) 
    { 
    ushort INDEX = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 414;
        INDEX = (ushort) ( Functions.LowWord( (uint)( TEMP[ 0 ] ) ) ) ; 
        __context__.SourceCodeLine = 416;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEX < 100 ))  ) ) 
            {
            __context__.SourceCodeLine = 417;
            SOURCESHARINGLISTITEMENABLED [ (INDEX + 1)]  .Value = (ushort) ( Functions.LowWord( (uint)( TEMP[ 1 ] ) ) ) ; 
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEROOMLISTITEMCOUNTCALLBACK ( int ITEMCOUNT ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 422;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITEMCOUNT <= 100 ))  ) ) 
            {
            __context__.SourceCodeLine = 423;
            ROOMLISTITEMCOUNT  .Value = (ushort) ( Functions.LowWord( (uint)( ITEMCOUNT ) ) ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 425;
            ROOMLISTITEMCOUNT  .Value = (ushort) ( 100 ) ; 
            }
        
        __context__.SourceCodeLine = 427;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITEMCOUNT > 0 ))  ) ) 
            {
            __context__.SourceCodeLine = 428;
            SHOWROOMSELECTBUTTON  .Value = (ushort) ( 1 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 430;
            SHOWROOMSELECTBUTTON  .Value = (ushort) ( 0 ) ; 
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESOURCESHARINGBUTTONVISIBILITYCALLBACK ( int VISIBILITYSTATE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 435;
        SHOWSOURCESHAREBUTTON  .Value = (ushort) ( Functions.LowWord( (uint)( VISIBILITYSTATE ) ) ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESOURCELISTSOURCENAMEBYINDEXCALLBACK ( int INDEX , SimplSharpString SOURCENAME ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 440;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEX < 100 ))  ) ) 
            {
            __context__.SourceCodeLine = 441;
            SOURCELISTITEMNAME [ (INDEX + 1)]  .UpdateValue ( SOURCENAME  .ToString()  ) ; 
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESOURCELISTICONBYINDEXCALLBACK ( int INDEX , SimplSharpString SOURCEICONFILENAME ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 446;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEX < 100 ))  ) ) 
            {
            __context__.SourceCodeLine = 447;
            SOURCELISTICONFILENAME [ (INDEX + 1)]  .UpdateValue ( SOURCEICONFILENAME  .ToString()  ) ; 
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESOURCELISTITEMCOUNTCALLBACK ( int ITEMCOUNT ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 452;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITEMCOUNT <= 100 ))  ) ) 
            {
            __context__.SourceCodeLine = 453;
            SOURCELISTITEMCOUNT  .Value = (ushort) ( Functions.LowWord( (uint)( ITEMCOUNT ) ) ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 455;
            SOURCELISTITEMCOUNT  .Value = (ushort) ( 100 ) ; 
            }
        
        __context__.SourceCodeLine = 457;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITEMCOUNT > 0 ))  ) ) 
            {
            __context__.SourceCodeLine = 458;
            SHOWSOURCESELECTBUTTON  .Value = (ushort) ( 1 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 460;
            SHOWSOURCESELECTBUTTON  .Value = (ushort) ( 0 ) ; 
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESOURCELISTITEMACTIVEBYINDEXCALLBACK ( int [] TEMP ) 
    { 
    ushort INDEX = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 469;
        INDEX = (ushort) ( Functions.LowWord( (uint)( TEMP[ 0 ] ) ) ) ; 
        __context__.SourceCodeLine = 471;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEX < 100 ))  ) ) 
            {
            __context__.SourceCodeLine = 472;
            SOURCELISTITEMSELECTED [ (INDEX + 1)]  .Value = (ushort) ( Functions.LowWord( (uint)( TEMP[ 1 ] ) ) ) ; 
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESOURCELISTSELECTEDSOURCENAMECALLBACK ( SimplSharpString SOURCENAME ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 477;
        SOURCELISTSELECTEDSOURCENAME  .UpdateValue ( SOURCENAME  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEENDPOINTLISTNAMEBYINDEXCALLBACK ( int INDEX , SimplSharpString ENDPOINTNAME ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 482;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEX < 5 ))  ) ) 
            {
            __context__.SourceCodeLine = 483;
            ENDPOINTLISTITEMNAME [ (INDEX + 1)]  .UpdateValue ( ENDPOINTNAME  .ToString()  ) ; 
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEENDPOINTLISTSOURCENAMEBYINDEXCALLBACK ( int INDEX , SimplSharpString SOURCENAME ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 488;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEX < 5 ))  ) ) 
            {
            __context__.SourceCodeLine = 489;
            ENDPOINTLISTSOURCENAME [ (INDEX + 1)]  .UpdateValue ( SOURCENAME  .ToString()  ) ; 
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEENDPOINTLISTSOURCECOMPARISONBYINDEXCALLBACK ( int INDEX , SimplSharpString ICONFILENAME ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 494;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEX < 5 ))  ) ) 
            {
            __context__.SourceCodeLine = 495;
            ENDPOINTLISTICONFILENAME [ (INDEX + 1)]  .UpdateValue ( ICONFILENAME  .ToString()  ) ; 
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEENDPOINTLISTSELECTIONENABLEDBYINDEXCALLBACK ( int [] TEMP ) 
    { 
    ushort INDEX = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 504;
        INDEX = (ushort) ( Functions.LowWord( (uint)( TEMP[ 0 ] ) ) ) ; 
        __context__.SourceCodeLine = 506;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEX < 5 ))  ) ) 
            {
            __context__.SourceCodeLine = 507;
            ENDPOINTLISTITEMENABLED [ (INDEX + 1)]  .Value = (ushort) ( Functions.LowWord( (uint)( TEMP[ 1 ] ) ) ) ; 
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEENDPOINTLISTITEMCOUNTCALLBACK ( int ITEMCOUNT ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 512;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITEMCOUNT <= 5 ))  ) ) 
            {
            __context__.SourceCodeLine = 513;
            ENDPOINTLISTITEMCOUNT  .Value = (ushort) ( Functions.LowWord( (uint)( ITEMCOUNT ) ) ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 515;
            ENDPOINTLISTITEMCOUNT  .Value = (ushort) ( 5 ) ; 
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESHOWADVANCEDSOURCESELECTBUTTONCALLBACK ( int ENABLE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 520;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ENABLE == 0) ) || Functions.TestForTrue ( Functions.BoolToInt (ENABLE == 1) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 521;
            SHOWADVANCEDSOURCESELECTBUTTON  .Value = (ushort) ( Functions.LowWord( (uint)( ENABLE ) ) ) ; 
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEACTIVESOURCELISTSOURCENAMEBYINDEXCALLBACK ( int INDEX , SimplSharpString SOURCENAME ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 526;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEX < 5 ))  ) ) 
            {
            __context__.SourceCodeLine = 527;
            ACTIVESOURCELISTITEMNAME [ (INDEX + 1)]  .UpdateValue ( SOURCENAME  .ToString()  ) ; 
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEACTIVESOURCELISTSOURCEICONBYINDEXCALLBACK ( int INDEX , SimplSharpString SOURCEICONFILENAME ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 532;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEX < 5 ))  ) ) 
            {
            __context__.SourceCodeLine = 533;
            ACTIVESOURCELISTICONFILENAME [ (INDEX + 1)]  .UpdateValue ( SOURCEICONFILENAME  .ToString()  ) ; 
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEACTIVESOURCELISTITEMCOUNTCALLBACK ( int ITEMCOUNT ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 538;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITEMCOUNT <= 5 ))  ) ) 
            {
            __context__.SourceCodeLine = 539;
            ACTIVESOURCELISTITEMCOUNT  .Value = (ushort) ( Functions.LowWord( (uint)( ITEMCOUNT ) ) ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 541;
            ACTIVESOURCELISTITEMCOUNT  .Value = (ushort) ( 5 ) ; 
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESOURCESELECTIONVISIBILITYCALLBACK ( int VISIBILITYSTATE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 547;
        SHOWSOURCESELECT  .Value = (ushort) ( Functions.LowWord( (uint)( VISIBILITYSTATE ) ) ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEADVANCEDSOURCESELECTIONVISIBILITYCALLBACK ( int VISIBILITYSTATE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 552;
        SHOWADVANCEDSOURCESELECT  .Value = (ushort) ( Functions.LowWord( (uint)( VISIBILITYSTATE ) ) ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEROOMSELECTIONVISIBILITYCALLBACK ( int VISIBILITYSTATE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 557;
        SHOWROOMSELECT  .Value = (ushort) ( Functions.LowWord( (uint)( VISIBILITYSTATE ) ) ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESOURCESHARINGVISIBILITYCALLBACK ( int VISIBILITYSTATE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 562;
        SHOWSOURCESHARE  .Value = (ushort) ( Functions.LowWord( (uint)( VISIBILITYSTATE ) ) ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEACTIVESOURCESELECTIONVISIBILITYCALLBACK ( int VISIBILITYSTATE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 567;
        SHOWACTIVESOURCESELECT  .Value = (ushort) ( Functions.LowWord( (uint)( VISIBILITYSTATE ) ) ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEREQUESTEDSOURCECONTROLPAGECALLBACK ( int SOURCEID ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 572;
        SOURCEPAGETOSHOW  .Value = (ushort) ( Functions.LowWord( (uint)( SOURCEID ) ) ) ; 
        __context__.SourceCodeLine = 573;
        Functions.ProcessLogic ( ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEMEDIAPAGEACTIVECALLBACK ( int ACTIVITYSTATE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 578;
        ANYMEDIAPAGEACTIVE  .Value = (ushort) ( Functions.LowWord( (uint)( ACTIVITYSTATE ) ) ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESELECTEDENDPOINTNAMECALLBACK ( SimplSharpString ENDPOINTNAME ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 583;
        SELECTEDENDPOINTNAME  .UpdateValue ( ENDPOINTNAME  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESELECTEDENDPOINTACTIVESOURCENAMECALLBACK ( SimplSharpString SOURCENAME ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 588;
        SELECTEDENDPOINTACTIVESOURCENAME  .UpdateValue ( SOURCENAME  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESELECTEDENDPOINTACTIVESOURCEICONCALLBACK ( SimplSharpString SOURCEICON ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 593;
        SELECTEDENDPOINTACTIVESOURCEICON  .UpdateValue ( SOURCEICON  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESELECTEDENDPOINTHASACTIVESOURCECALLBACK ( int STATE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 598;
        SELECTEDENDPOINTHASACTIVESOURCE  .Value = (ushort) ( Functions.LowWord( (uint)( STATE ) ) ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATECONTROLLEDSOURCENAMECALLBACK ( SimplSharpString SOURCENAME ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 603;
        CONTROLLEDSOURCENAME  .UpdateValue ( SOURCENAME  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATECONTROLLEDSOURCEICONCALLBACK ( SimplSharpString SOURCEICON ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 608;
        CONTROLLEDSOURCEICON  .UpdateValue ( SOURCEICON  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void REGISTERDELEGATES ( ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 613;
        MEDIAUI =DYNAMICMEDIAUI.mediaUIComponent; 
        __context__.SourceCodeLine = 615;
        // RegisterDelegate( MEDIAUI , TOUCHSCREENINITIALIZED , TOUCHSCREENINITIALIZEDCALLBACK ) 
        MEDIAUI .touchScreenInitialized  = TOUCHSCREENINITIALIZEDCALLBACK; ; 
        __context__.SourceCodeLine = 616;
        // RegisterDelegate( MEDIAUI , MEDIAMIDPOINTSINITIALIZED , MEDIAMIDPOINTSINITIALIZEDCALLBACK ) 
        MEDIAUI .mediaMidpointsInitialized  = MEDIAMIDPOINTSINITIALIZEDCALLBACK; ; 
        __context__.SourceCodeLine = 618;
        // RegisterDelegate( MEDIAUI , CONNECTNEWROOM , CONNECTNEWROOMCALLBACK ) 
        MEDIAUI .connectNewRoom  = CONNECTNEWROOMCALLBACK; ; 
        __context__.SourceCodeLine = 620;
        // RegisterDelegate( MEDIAUI , SETROOMONFEEDBACK , SETROOMONFEEDBACKCALLBACK ) 
        MEDIAUI .setRoomOnFeedback  = SETROOMONFEEDBACKCALLBACK; ; 
        __context__.SourceCodeLine = 621;
        // RegisterDelegate( MEDIAUI , SETROOMOFFFEEDBACK , SETROOMOFFFEEDBACKCALLBACK ) 
        MEDIAUI .setRoomOffFeedback  = SETROOMOFFFEEDBACKCALLBACK; ; 
        __context__.SourceCodeLine = 622;
        // RegisterDelegate( MEDIAUI , UPDATESELECTEDROOMID , UPDATESELECTEDROOMIDCALLBACK ) 
        MEDIAUI .updateSelectedRoomID  = UPDATESELECTEDROOMIDCALLBACK; ; 
        __context__.SourceCodeLine = 623;
        // RegisterDelegate( MEDIAUI , UPDATESELECTEDSOURCEID , UPDATESELECTEDSOURCEIDCALLBACK ) 
        MEDIAUI .updateSelectedSourceID  = UPDATESELECTEDSOURCEIDCALLBACK; ; 
        __context__.SourceCodeLine = 624;
        // RegisterDelegate( MEDIAUI , UPDATESELECTEDROOMNAME , UPDATESELECTEDROOMNAMECALLBACK ) 
        MEDIAUI .updateSelectedRoomName  = UPDATESELECTEDROOMNAMECALLBACK; ; 
        __context__.SourceCodeLine = 625;
        // RegisterDelegate( MEDIAUI , UPDATESELECTEDSOURCENAME , UPDATESELECTEDSOURCENAMECALLBACK ) 
        MEDIAUI .updateSelectedSourceName  = UPDATESELECTEDSOURCENAMECALLBACK; ; 
        __context__.SourceCodeLine = 626;
        // RegisterDelegate( MEDIAUI , UPDATENOWPLAYINGLINE1 , UPDATENOWPLAYINGLINE1CALLBACK ) 
        MEDIAUI .updateNowPlayingLine1  = UPDATENOWPLAYINGLINE1CALLBACK; ; 
        __context__.SourceCodeLine = 627;
        // RegisterDelegate( MEDIAUI , UPDATENOWPLAYINGLINE2 , UPDATENOWPLAYINGLINE2CALLBACK ) 
        MEDIAUI .updateNowPlayingLine2  = UPDATENOWPLAYINGLINE2CALLBACK; ; 
        __context__.SourceCodeLine = 629;
        // RegisterDelegate( MEDIAUI , UPDATESELECTEDENDPOINTNAME , UPDATESELECTEDENDPOINTNAMECALLBACK ) 
        MEDIAUI .updateSelectedEndpointName  = UPDATESELECTEDENDPOINTNAMECALLBACK; ; 
        __context__.SourceCodeLine = 630;
        // RegisterDelegate( MEDIAUI , UPDATESELECTEDENDPOINTACTIVESOURCENAME , UPDATESELECTEDENDPOINTACTIVESOURCENAMECALLBACK ) 
        MEDIAUI .updateSelectedEndpointActiveSourceName  = UPDATESELECTEDENDPOINTACTIVESOURCENAMECALLBACK; ; 
        __context__.SourceCodeLine = 631;
        // RegisterDelegate( MEDIAUI , UPDATESELECTEDENDPOINTACTIVESOURCEICON , UPDATESELECTEDENDPOINTACTIVESOURCEICONCALLBACK ) 
        MEDIAUI .updateSelectedEndpointActiveSourceIcon  = UPDATESELECTEDENDPOINTACTIVESOURCEICONCALLBACK; ; 
        __context__.SourceCodeLine = 632;
        // RegisterDelegate( MEDIAUI , UPDATESELECTEDENDPOINTHASACTIVESOURCE , UPDATESELECTEDENDPOINTHASACTIVESOURCECALLBACK ) 
        MEDIAUI .updateSelectedEndpointHasActiveSource  = UPDATESELECTEDENDPOINTHASACTIVESOURCECALLBACK; ; 
        __context__.SourceCodeLine = 634;
        // RegisterDelegate( MEDIAUI , UPDATESOURCEDISPLAYNAME , UPDATESOURCEDISPLAYNAMECALLBACK ) 
        MEDIAUI .updateSourceDisplayName  = UPDATESOURCEDISPLAYNAMECALLBACK; ; 
        __context__.SourceCodeLine = 635;
        // RegisterDelegate( MEDIAUI , UPDATECONTROLLEDSOURCENAME , UPDATECONTROLLEDSOURCENAMECALLBACK ) 
        MEDIAUI .updateControlledSourceName  = UPDATECONTROLLEDSOURCENAMECALLBACK; ; 
        __context__.SourceCodeLine = 636;
        // RegisterDelegate( MEDIAUI , UPDATECONTROLLEDSOURCEICON , UPDATECONTROLLEDSOURCEICONCALLBACK ) 
        MEDIAUI .updateControlledSourceIcon  = UPDATECONTROLLEDSOURCEICONCALLBACK; ; 
        __context__.SourceCodeLine = 638;
        // RegisterDelegate( MEDIAUI , UPDATEAUDIOENDPOINTSOURCEID , UPDATEAUDIOENDPOINTSOURCEIDCALLBACK ) 
        MEDIAUI .updateAudioEndpointSourceID  = UPDATEAUDIOENDPOINTSOURCEIDCALLBACK; ; 
        __context__.SourceCodeLine = 639;
        // RegisterDelegate( MEDIAUI , UPDATEAUDIOENDPOINTNAME , UPDATEAUDIOENDPOINTNAMECALLBACK ) 
        MEDIAUI .updateAudioEndpointName  = UPDATEAUDIOENDPOINTNAMECALLBACK; ; 
        __context__.SourceCodeLine = 640;
        // RegisterDelegate( MEDIAUI , UPDATEAUDIOENDPOINTSOURCENAME , UPDATEAUDIOENDPOINTSOURCENAMECALLBACK ) 
        MEDIAUI .updateAudioEndpointSourceName  = UPDATEAUDIOENDPOINTSOURCENAMECALLBACK; ; 
        __context__.SourceCodeLine = 642;
        // RegisterDelegate( MEDIAUI , UPDATEPRIMARYVIDEOENDPOINTSOURCEID , UPDATEPRIMARYVIDEOENDPOINTSOURCEIDCALLBACK ) 
        MEDIAUI .updatePrimaryVideoEndpointSourceID  = UPDATEPRIMARYVIDEOENDPOINTSOURCEIDCALLBACK; ; 
        __context__.SourceCodeLine = 643;
        // RegisterDelegate( MEDIAUI , UPDATEPRIMARYVIDEOENDPOINTNAME , UPDATEPRIMARYVIDEOENDPOINTNAMECALLBACK ) 
        MEDIAUI .updatePrimaryVideoEndpointName  = UPDATEPRIMARYVIDEOENDPOINTNAMECALLBACK; ; 
        __context__.SourceCodeLine = 644;
        // RegisterDelegate( MEDIAUI , UPDATEPRIMARYVIDEOENDPOINTSOURCENAME , UPDATEPRIMARYVIDEOENDPOINTSOURCENAMECALLBACK ) 
        MEDIAUI .updatePrimaryVideoEndpointSourceName  = UPDATEPRIMARYVIDEOENDPOINTSOURCENAMECALLBACK; ; 
        __context__.SourceCodeLine = 646;
        // RegisterDelegate( MEDIAUI , UPDATEALTERNATEVIDEOENDPOINTSOURCEIDBYINDEX , UPDATEALTERNATEVIDEOENDPOINTSOURCEIDBYINDEXCALLBACK ) 
        MEDIAUI .updateAlternateVideoEndpointSourceIDByIndex  = UPDATEALTERNATEVIDEOENDPOINTSOURCEIDBYINDEXCALLBACK; ; 
        __context__.SourceCodeLine = 647;
        // RegisterDelegate( MEDIAUI , UPDATEALTERNATEVIDEOENDPOINTNAMEBYINDEX , UPDATEALTERNATEVIDEOENDPOINTNAMEBYINDEXCALLBACK ) 
        MEDIAUI .updateAlternateVideoEndpointNameByIndex  = UPDATEALTERNATEVIDEOENDPOINTNAMEBYINDEXCALLBACK; ; 
        __context__.SourceCodeLine = 648;
        // RegisterDelegate( MEDIAUI , UPDATEALTERNATEVIDEOENDPOINTSOURCENAMEBYINDEX , UPDATEALTERNATEVIDEOENDPOINTSOURCENAMEBYINDEXCALLBACK ) 
        MEDIAUI .updateAlternateVideoEndpointSourceNameByIndex  = UPDATEALTERNATEVIDEOENDPOINTSOURCENAMEBYINDEXCALLBACK; ; 
        __context__.SourceCodeLine = 649;
        // RegisterDelegate( MEDIAUI , CLEARREMAININGALTERNATEVIDEOENDPOINTS , CLEARREMAININGALTERNATEVIDEOENDPOINTSCALLBACK ) 
        MEDIAUI .clearRemainingAlternateVideoEndpoints  = CLEARREMAININGALTERNATEVIDEOENDPOINTSCALLBACK; ; 
        __context__.SourceCodeLine = 651;
        // RegisterDelegate( MEDIAUI , UPDATEROOMLISTROOMNAMEBYINDEX , UPDATEROOMLISTROOMNAMEBYINDEXCALLBACK ) 
        MEDIAUI .updateRoomListRoomNameByIndex  = UPDATEROOMLISTROOMNAMEBYINDEXCALLBACK; ; 
        __context__.SourceCodeLine = 652;
        // RegisterDelegate( MEDIAUI , UPDATEROOMLISTSOURCENAMEBYINDEX , UPDATEROOMLISTSOURCENAMEBYINDEXCALLBACK ) 
        MEDIAUI .updateRoomListSourceNameByIndex  = UPDATEROOMLISTSOURCENAMEBYINDEXCALLBACK; ; 
        __context__.SourceCodeLine = 653;
        // RegisterDelegate( MEDIAUI , UPDATESOURCESHARINGLISTACTIVESOURCECOMPARISONBYINDEX , UPDATESOURCESHARINGLISTACTIVESOURCECOMPARISONBYINDEXCALLBACK ) 
        MEDIAUI .updateSourceSharingListActiveSourceComparisonByIndex  = UPDATESOURCESHARINGLISTACTIVESOURCECOMPARISONBYINDEXCALLBACK; ; 
        __context__.SourceCodeLine = 654;
        // RegisterDelegate( MEDIAUI , UPDATESOURCESHARINGLISTSELECTIONENABLEDBYINDEX , UPDATESOURCESHARINGLISTSELECTIONENABLEDBYINDEXCALLBACK ) 
        MEDIAUI .updateSourceSharingListSelectionEnabledByIndex  = UPDATESOURCESHARINGLISTSELECTIONENABLEDBYINDEXCALLBACK; ; 
        __context__.SourceCodeLine = 655;
        // RegisterDelegate( MEDIAUI , UPDATEROOMLISTITEMCOUNT , UPDATEROOMLISTITEMCOUNTCALLBACK ) 
        MEDIAUI .updateRoomListItemCount  = UPDATEROOMLISTITEMCOUNTCALLBACK; ; 
        __context__.SourceCodeLine = 656;
        // RegisterDelegate( MEDIAUI , UPDATESOURCESHARINGBUTTONVISIBILITY , UPDATESOURCESHARINGBUTTONVISIBILITYCALLBACK ) 
        MEDIAUI .updateSourceSharingButtonVisibility  = UPDATESOURCESHARINGBUTTONVISIBILITYCALLBACK; ; 
        __context__.SourceCodeLine = 658;
        // RegisterDelegate( MEDIAUI , UPDATESOURCELISTSOURCENAMEBYINDEX , UPDATESOURCELISTSOURCENAMEBYINDEXCALLBACK ) 
        MEDIAUI .updateSourceListSourceNameByIndex  = UPDATESOURCELISTSOURCENAMEBYINDEXCALLBACK; ; 
        __context__.SourceCodeLine = 659;
        // RegisterDelegate( MEDIAUI , UPDATESOURCELISTICONBYINDEX , UPDATESOURCELISTICONBYINDEXCALLBACK ) 
        MEDIAUI .updateSourceListIconByIndex  = UPDATESOURCELISTICONBYINDEXCALLBACK; ; 
        __context__.SourceCodeLine = 660;
        // RegisterDelegate( MEDIAUI , UPDATESOURCELISTITEMCOUNT , UPDATESOURCELISTITEMCOUNTCALLBACK ) 
        MEDIAUI .updateSourceListItemCount  = UPDATESOURCELISTITEMCOUNTCALLBACK; ; 
        __context__.SourceCodeLine = 661;
        // RegisterDelegate( MEDIAUI , UPDATESOURCELISTITEMACTIVEBYINDEX , UPDATESOURCELISTITEMACTIVEBYINDEXCALLBACK ) 
        MEDIAUI .updateSourceListItemActiveByIndex  = UPDATESOURCELISTITEMACTIVEBYINDEXCALLBACK; ; 
        __context__.SourceCodeLine = 662;
        // RegisterDelegate( MEDIAUI , UPDATESOURCELISTSELECTEDSOURCENAME , UPDATESOURCELISTSELECTEDSOURCENAMECALLBACK ) 
        MEDIAUI .updateSourceListSelectedSourceName  = UPDATESOURCELISTSELECTEDSOURCENAMECALLBACK; ; 
        __context__.SourceCodeLine = 664;
        // RegisterDelegate( MEDIAUI , UPDATEENDPOINTLISTNAMEBYINDEX , UPDATEENDPOINTLISTNAMEBYINDEXCALLBACK ) 
        MEDIAUI .updateEndpointListNameByIndex  = UPDATEENDPOINTLISTNAMEBYINDEXCALLBACK; ; 
        __context__.SourceCodeLine = 665;
        // RegisterDelegate( MEDIAUI , UPDATEENDPOINTLISTSOURCENAMEBYINDEX , UPDATEENDPOINTLISTSOURCENAMEBYINDEXCALLBACK ) 
        MEDIAUI .updateEndpointListSourceNameByIndex  = UPDATEENDPOINTLISTSOURCENAMEBYINDEXCALLBACK; ; 
        __context__.SourceCodeLine = 666;
        // RegisterDelegate( MEDIAUI , UPDATEENDPOINTLISTSOURCECOMPARISONBYINDEX , UPDATEENDPOINTLISTSOURCECOMPARISONBYINDEXCALLBACK ) 
        MEDIAUI .updateEndpointListSourceComparisonByIndex  = UPDATEENDPOINTLISTSOURCECOMPARISONBYINDEXCALLBACK; ; 
        __context__.SourceCodeLine = 667;
        // RegisterDelegate( MEDIAUI , UPDATEENDPOINTLISTSELECTIONENABLEDBYINDEX , UPDATEENDPOINTLISTSELECTIONENABLEDBYINDEXCALLBACK ) 
        MEDIAUI .updateEndpointListSelectionEnabledByIndex  = UPDATEENDPOINTLISTSELECTIONENABLEDBYINDEXCALLBACK; ; 
        __context__.SourceCodeLine = 668;
        // RegisterDelegate( MEDIAUI , UPDATEENDPOINTLISTITEMCOUNT , UPDATEENDPOINTLISTITEMCOUNTCALLBACK ) 
        MEDIAUI .updateEndpointListItemCount  = UPDATEENDPOINTLISTITEMCOUNTCALLBACK; ; 
        __context__.SourceCodeLine = 669;
        // RegisterDelegate( MEDIAUI , UPDATESHOWADVANCEDSOURCESELECTBUTTON , UPDATESHOWADVANCEDSOURCESELECTBUTTONCALLBACK ) 
        MEDIAUI .updateShowAdvancedSourceSelectButton  = UPDATESHOWADVANCEDSOURCESELECTBUTTONCALLBACK; ; 
        __context__.SourceCodeLine = 672;
        // RegisterDelegate( MEDIAUI , UPDATEACTIVESOURCELISTSOURCENAMEBYINDEX , UPDATEACTIVESOURCELISTSOURCENAMEBYINDEXCALLBACK ) 
        MEDIAUI .updateActiveSourceListSourceNameByIndex  = UPDATEACTIVESOURCELISTSOURCENAMEBYINDEXCALLBACK; ; 
        __context__.SourceCodeLine = 673;
        // RegisterDelegate( MEDIAUI , UPDATEACTIVESOURCELISTSOURCEICONBYINDEX , UPDATEACTIVESOURCELISTSOURCEICONBYINDEXCALLBACK ) 
        MEDIAUI .updateActiveSourceListSourceIconByIndex  = UPDATEACTIVESOURCELISTSOURCEICONBYINDEXCALLBACK; ; 
        __context__.SourceCodeLine = 674;
        // RegisterDelegate( MEDIAUI , UPDATEACTIVESOURCELISTITEMCOUNT , UPDATEACTIVESOURCELISTITEMCOUNTCALLBACK ) 
        MEDIAUI .updateActiveSourceListItemCount  = UPDATEACTIVESOURCELISTITEMCOUNTCALLBACK; ; 
        __context__.SourceCodeLine = 676;
        // RegisterDelegate( MEDIAUI , UPDATESOURCESELECTIONVISIBILITY , UPDATESOURCESELECTIONVISIBILITYCALLBACK ) 
        MEDIAUI .updateSourceSelectionVisibility  = UPDATESOURCESELECTIONVISIBILITYCALLBACK; ; 
        __context__.SourceCodeLine = 677;
        // RegisterDelegate( MEDIAUI , UPDATEADVANCEDSOURCESELECTIONVISIBILITY , UPDATEADVANCEDSOURCESELECTIONVISIBILITYCALLBACK ) 
        MEDIAUI .updateAdvancedSourceSelectionVisibility  = UPDATEADVANCEDSOURCESELECTIONVISIBILITYCALLBACK; ; 
        __context__.SourceCodeLine = 678;
        // RegisterDelegate( MEDIAUI , UPDATEROOMSELECTIONVISIBILITY , UPDATEROOMSELECTIONVISIBILITYCALLBACK ) 
        MEDIAUI .updateRoomSelectionVisibility  = UPDATEROOMSELECTIONVISIBILITYCALLBACK; ; 
        __context__.SourceCodeLine = 679;
        // RegisterDelegate( MEDIAUI , UPDATESOURCESHARINGVISIBILITY , UPDATESOURCESHARINGVISIBILITYCALLBACK ) 
        MEDIAUI .updateSourceSharingVisibility  = UPDATESOURCESHARINGVISIBILITYCALLBACK; ; 
        __context__.SourceCodeLine = 680;
        // RegisterDelegate( MEDIAUI , UPDATEACTIVESOURCESELECTIONVISIBILITY , UPDATEACTIVESOURCESELECTIONVISIBILITYCALLBACK ) 
        MEDIAUI .updateActiveSourceSelectionVisibility  = UPDATEACTIVESOURCESELECTIONVISIBILITYCALLBACK; ; 
        __context__.SourceCodeLine = 681;
        // RegisterDelegate( MEDIAUI , UPDATEREQUESTEDSOURCECONTROLPAGE , UPDATEREQUESTEDSOURCECONTROLPAGECALLBACK ) 
        MEDIAUI .updateRequestedSourceControlPage  = UPDATEREQUESTEDSOURCECONTROLPAGECALLBACK; ; 
        __context__.SourceCodeLine = 682;
        // RegisterDelegate( MEDIAUI , UPDATEMEDIAPAGEACTIVE , UPDATEMEDIAPAGEACTIVECALLBACK ) 
        MEDIAUI .updateMediaPageActive  = UPDATEMEDIAPAGEACTIVECALLBACK; ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void MEDIAINITIALIZATIONCOMPLETEEVENTHANDLER ( object __sender__ /*EventArgs ARGS */) 
    { 
    EventArgs  ARGS  = (EventArgs )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 691;
        DYNAMICMEDIAUI . Initialize ( (int)( TOUCHSCREENID  .IntValue )) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 696;
        TOUCHSCREENINITIALIZED  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 697;
        MEDIAINITIALIZATIONINPOGRESS  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 699;
        // RegisterDelegate( DYNAMICMEDIAUI , REGISTERSIMPLDELEGATES , REGISTERDELEGATES ) 
        DYNAMICMEDIAUI .RegisterSimplDelegates  = REGISTERDELEGATES; ; 
        __context__.SourceCodeLine = 701;
        SOURCELISTITEMNAME [ 1]  .UpdateValue ( "No Available Selection"  ) ; 
        __context__.SourceCodeLine = 702;
        SOURCELISTICONFILENAME [ 1]  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 704;
        ENDPOINTLISTITEMNAME [ 1]  .UpdateValue ( "No Available Selection"  ) ; 
        __context__.SourceCodeLine = 705;
        ENDPOINTLISTSOURCENAME [ 1]  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 706;
        ENDPOINTLISTICONFILENAME [ 1]  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 707;
        ENDPOINTLISTITEMENABLED [ 1]  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 709;
        ACTIVESOURCELISTITEMNAME [ 1]  .UpdateValue ( "No Available Selection"  ) ; 
        __context__.SourceCodeLine = 710;
        ACTIVESOURCELISTICONFILENAME [ 1]  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 712;
        ROOMLISTITEMNAME [ 1]  .UpdateValue ( "No Available Selection"  ) ; 
        __context__.SourceCodeLine = 713;
        ROOMLISTSOURCENAME [ 1]  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 714;
        SOURCESHARINGLISTICONFILENAME [ 1]  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 715;
        SOURCESHARINGLISTITEMENABLED [ 1]  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 717;
        SOURCELISTITEMCOUNT  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 718;
        ENDPOINTLISTITEMCOUNT  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 719;
        ACTIVESOURCELISTITEMCOUNT  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 720;
        ROOMLISTITEMCOUNT  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 722;
        // RegisterEvent( MediaSubsystem , MEDIAINITIALIZATIONCOMPLETEEVENT , MEDIAINITIALIZATIONCOMPLETEEVENTHANDLER ) 
        try { g_criticalSection.Enter(); MediaSubsystem .MediaInitializationCompleteEvent  += MEDIAINITIALIZATIONCOMPLETEEVENTHANDLER; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 724;
        TOUCHSCREENIDSET = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 725;
        MEDIASUBSYSTEMINITIALIZED = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 727;
        AUDIOENDPOINTISON  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 728;
        ROOMHASACTIVESOURCE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 730;
        SHOWSOURCESELECTBUTTON  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 731;
        SHOWROOMSELECTBUTTON  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 732;
        SHOWSOURCESHAREBUTTON  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 734;
        SOURCELISTITEMCOUNT  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 735;
        ENDPOINTLISTITEMCOUNT  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 736;
        ACTIVESOURCELISTITEMCOUNT  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 737;
        ROOMLISTITEMCOUNT  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 739;
        MEDIAUI . SetAdvancedSourceSelectionButtonBehavior ( (ushort)( ADVANCEDSOURCESELECTIONBUTTONBEHAVIOR  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    ROOMON = new Crestron.Logos.SplusObjects.DigitalInput( ROOMON__DigitalInput__, this );
    m_DigitalInputList.Add( ROOMON__DigitalInput__, ROOMON );
    
    ROOMOFF = new Crestron.Logos.SplusObjects.DigitalInput( ROOMOFF__DigitalInput__, this );
    m_DigitalInputList.Add( ROOMOFF__DigitalInput__, ROOMOFF );
    
    ALLROOMSOFF = new Crestron.Logos.SplusObjects.DigitalInput( ALLROOMSOFF__DigitalInput__, this );
    m_DigitalInputList.Add( ALLROOMSOFF__DigitalInput__, ALLROOMSOFF );
    
    ROOMSSHARINGSOURCEOFF = new Crestron.Logos.SplusObjects.DigitalInput( ROOMSSHARINGSOURCEOFF__DigitalInput__, this );
    m_DigitalInputList.Add( ROOMSSHARINGSOURCEOFF__DigitalInput__, ROOMSSHARINGSOURCEOFF );
    
    SELECTEDENDPOINTOFF = new Crestron.Logos.SplusObjects.DigitalInput( SELECTEDENDPOINTOFF__DigitalInput__, this );
    m_DigitalInputList.Add( SELECTEDENDPOINTOFF__DigitalInput__, SELECTEDENDPOINTOFF );
    
    REQUESTSOURCESELECT = new Crestron.Logos.SplusObjects.DigitalInput( REQUESTSOURCESELECT__DigitalInput__, this );
    m_DigitalInputList.Add( REQUESTSOURCESELECT__DigitalInput__, REQUESTSOURCESELECT );
    
    REQUESTSTANDARDSOURCESELECT = new Crestron.Logos.SplusObjects.DigitalInput( REQUESTSTANDARDSOURCESELECT__DigitalInput__, this );
    m_DigitalInputList.Add( REQUESTSTANDARDSOURCESELECT__DigitalInput__, REQUESTSTANDARDSOURCESELECT );
    
    REQUESTADVANCEDSOURCESELECT = new Crestron.Logos.SplusObjects.DigitalInput( REQUESTADVANCEDSOURCESELECT__DigitalInput__, this );
    m_DigitalInputList.Add( REQUESTADVANCEDSOURCESELECT__DigitalInput__, REQUESTADVANCEDSOURCESELECT );
    
    REQUESTROOMSELECT = new Crestron.Logos.SplusObjects.DigitalInput( REQUESTROOMSELECT__DigitalInput__, this );
    m_DigitalInputList.Add( REQUESTROOMSELECT__DigitalInput__, REQUESTROOMSELECT );
    
    REQUESTSOURCESHARE = new Crestron.Logos.SplusObjects.DigitalInput( REQUESTSOURCESHARE__DigitalInput__, this );
    m_DigitalInputList.Add( REQUESTSOURCESHARE__DigitalInput__, REQUESTSOURCESHARE );
    
    REQUESTACTIVESOURCE = new Crestron.Logos.SplusObjects.DigitalInput( REQUESTACTIVESOURCE__DigitalInput__, this );
    m_DigitalInputList.Add( REQUESTACTIVESOURCE__DigitalInput__, REQUESTACTIVESOURCE );
    
    REQUESTMEDIAHOME = new Crestron.Logos.SplusObjects.DigitalInput( REQUESTMEDIAHOME__DigitalInput__, this );
    m_DigitalInputList.Add( REQUESTMEDIAHOME__DigitalInput__, REQUESTMEDIAHOME );
    
    REQUESTSELECTEDENDPOINTACTIVESOURCE = new Crestron.Logos.SplusObjects.DigitalInput( REQUESTSELECTEDENDPOINTACTIVESOURCE__DigitalInput__, this );
    m_DigitalInputList.Add( REQUESTSELECTEDENDPOINTACTIVESOURCE__DigitalInput__, REQUESTSELECTEDENDPOINTACTIVESOURCE );
    
    REQUESTEDSOURCEPAGEISVALID = new Crestron.Logos.SplusObjects.DigitalInput( REQUESTEDSOURCEPAGEISVALID__DigitalInput__, this );
    m_DigitalInputList.Add( REQUESTEDSOURCEPAGEISVALID__DigitalInput__, REQUESTEDSOURCEPAGEISVALID );
    
    SOURCESHAREALL = new Crestron.Logos.SplusObjects.DigitalInput( SOURCESHAREALL__DigitalInput__, this );
    m_DigitalInputList.Add( SOURCESHAREALL__DigitalInput__, SOURCESHAREALL );
    
    DISMISSACTIVEPAGE = new Crestron.Logos.SplusObjects.DigitalInput( DISMISSACTIVEPAGE__DigitalInput__, this );
    m_DigitalInputList.Add( DISMISSACTIVEPAGE__DigitalInput__, DISMISSACTIVEPAGE );
    
    TOUCHSCREENINITIALIZED = new Crestron.Logos.SplusObjects.DigitalOutput( TOUCHSCREENINITIALIZED__DigitalOutput__, this );
    m_DigitalOutputList.Add( TOUCHSCREENINITIALIZED__DigitalOutput__, TOUCHSCREENINITIALIZED );
    
    MEDIAINITIALIZATIONINPOGRESS = new Crestron.Logos.SplusObjects.DigitalOutput( MEDIAINITIALIZATIONINPOGRESS__DigitalOutput__, this );
    m_DigitalOutputList.Add( MEDIAINITIALIZATIONINPOGRESS__DigitalOutput__, MEDIAINITIALIZATIONINPOGRESS );
    
    ROOMISON = new Crestron.Logos.SplusObjects.DigitalOutput( ROOMISON__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOMISON__DigitalOutput__, ROOMISON );
    
    ROOMISOFF = new Crestron.Logos.SplusObjects.DigitalOutput( ROOMISOFF__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOMISOFF__DigitalOutput__, ROOMISOFF );
    
    AUDIOENDPOINTISON = new Crestron.Logos.SplusObjects.DigitalOutput( AUDIOENDPOINTISON__DigitalOutput__, this );
    m_DigitalOutputList.Add( AUDIOENDPOINTISON__DigitalOutput__, AUDIOENDPOINTISON );
    
    ROOMHASACTIVESOURCE = new Crestron.Logos.SplusObjects.DigitalOutput( ROOMHASACTIVESOURCE__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOMHASACTIVESOURCE__DigitalOutput__, ROOMHASACTIVESOURCE );
    
    SELECTEDENDPOINTHASACTIVESOURCE = new Crestron.Logos.SplusObjects.DigitalOutput( SELECTEDENDPOINTHASACTIVESOURCE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SELECTEDENDPOINTHASACTIVESOURCE__DigitalOutput__, SELECTEDENDPOINTHASACTIVESOURCE );
    
    SHOWSOURCESELECT = new Crestron.Logos.SplusObjects.DigitalOutput( SHOWSOURCESELECT__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHOWSOURCESELECT__DigitalOutput__, SHOWSOURCESELECT );
    
    SHOWADVANCEDSOURCESELECT = new Crestron.Logos.SplusObjects.DigitalOutput( SHOWADVANCEDSOURCESELECT__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHOWADVANCEDSOURCESELECT__DigitalOutput__, SHOWADVANCEDSOURCESELECT );
    
    SHOWROOMSELECT = new Crestron.Logos.SplusObjects.DigitalOutput( SHOWROOMSELECT__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHOWROOMSELECT__DigitalOutput__, SHOWROOMSELECT );
    
    SHOWSOURCESHARE = new Crestron.Logos.SplusObjects.DigitalOutput( SHOWSOURCESHARE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHOWSOURCESHARE__DigitalOutput__, SHOWSOURCESHARE );
    
    SHOWACTIVESOURCESELECT = new Crestron.Logos.SplusObjects.DigitalOutput( SHOWACTIVESOURCESELECT__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHOWACTIVESOURCESELECT__DigitalOutput__, SHOWACTIVESOURCESELECT );
    
    ANYMEDIAPAGEACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( ANYMEDIAPAGEACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( ANYMEDIAPAGEACTIVE__DigitalOutput__, ANYMEDIAPAGEACTIVE );
    
    SHOWSOURCESELECTBUTTON = new Crestron.Logos.SplusObjects.DigitalOutput( SHOWSOURCESELECTBUTTON__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHOWSOURCESELECTBUTTON__DigitalOutput__, SHOWSOURCESELECTBUTTON );
    
    SHOWADVANCEDSOURCESELECTBUTTON = new Crestron.Logos.SplusObjects.DigitalOutput( SHOWADVANCEDSOURCESELECTBUTTON__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHOWADVANCEDSOURCESELECTBUTTON__DigitalOutput__, SHOWADVANCEDSOURCESELECTBUTTON );
    
    SHOWROOMSELECTBUTTON = new Crestron.Logos.SplusObjects.DigitalOutput( SHOWROOMSELECTBUTTON__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHOWROOMSELECTBUTTON__DigitalOutput__, SHOWROOMSELECTBUTTON );
    
    SHOWSOURCESHAREBUTTON = new Crestron.Logos.SplusObjects.DigitalOutput( SHOWSOURCESHAREBUTTON__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHOWSOURCESHAREBUTTON__DigitalOutput__, SHOWSOURCESHAREBUTTON );
    
    SOURCELISTITEMSELECTED = new InOutArray<DigitalOutput>( 100, this );
    for( uint i = 0; i < 100; i++ )
    {
        SOURCELISTITEMSELECTED[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( SOURCELISTITEMSELECTED__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( SOURCELISTITEMSELECTED__DigitalOutput__ + i, SOURCELISTITEMSELECTED[i+1] );
    }
    
    ENDPOINTLISTITEMENABLED = new InOutArray<DigitalOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        ENDPOINTLISTITEMENABLED[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( ENDPOINTLISTITEMENABLED__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( ENDPOINTLISTITEMENABLED__DigitalOutput__ + i, ENDPOINTLISTITEMENABLED[i+1] );
    }
    
    SOURCESHARINGLISTITEMENABLED = new InOutArray<DigitalOutput>( 100, this );
    for( uint i = 0; i < 100; i++ )
    {
        SOURCESHARINGLISTITEMENABLED[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( SOURCESHARINGLISTITEMENABLED__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( SOURCESHARINGLISTITEMENABLED__DigitalOutput__ + i, SOURCESHARINGLISTITEMENABLED[i+1] );
    }
    
    TOUCHSCREENID = new Crestron.Logos.SplusObjects.AnalogInput( TOUCHSCREENID__AnalogSerialInput__, this );
    m_AnalogInputList.Add( TOUCHSCREENID__AnalogSerialInput__, TOUCHSCREENID );
    
    REQUESTROOMCONTROL = new Crestron.Logos.SplusObjects.AnalogInput( REQUESTROOMCONTROL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( REQUESTROOMCONTROL__AnalogSerialInput__, REQUESTROOMCONTROL );
    
    SOURCELISTITEMCLICKED = new Crestron.Logos.SplusObjects.AnalogInput( SOURCELISTITEMCLICKED__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SOURCELISTITEMCLICKED__AnalogSerialInput__, SOURCELISTITEMCLICKED );
    
    ENDPOINTLISTITEMCLICKED = new Crestron.Logos.SplusObjects.AnalogInput( ENDPOINTLISTITEMCLICKED__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ENDPOINTLISTITEMCLICKED__AnalogSerialInput__, ENDPOINTLISTITEMCLICKED );
    
    ACTIVESOURCELISTITEMCLICKED = new Crestron.Logos.SplusObjects.AnalogInput( ACTIVESOURCELISTITEMCLICKED__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ACTIVESOURCELISTITEMCLICKED__AnalogSerialInput__, ACTIVESOURCELISTITEMCLICKED );
    
    ROOMLISTITEMCLICKED = new Crestron.Logos.SplusObjects.AnalogInput( ROOMLISTITEMCLICKED__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ROOMLISTITEMCLICKED__AnalogSerialInput__, ROOMLISTITEMCLICKED );
    
    SELECTEDROOMID = new Crestron.Logos.SplusObjects.AnalogOutput( SELECTEDROOMID__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SELECTEDROOMID__AnalogSerialOutput__, SELECTEDROOMID );
    
    ROOMEQUIPMENTIDTOCONNECT = new Crestron.Logos.SplusObjects.AnalogOutput( ROOMEQUIPMENTIDTOCONNECT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ROOMEQUIPMENTIDTOCONNECT__AnalogSerialOutput__, ROOMEQUIPMENTIDTOCONNECT );
    
    ROOMSOURCE = new Crestron.Logos.SplusObjects.AnalogOutput( ROOMSOURCE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ROOMSOURCE__AnalogSerialOutput__, ROOMSOURCE );
    
    AUDIOSOURCE = new Crestron.Logos.SplusObjects.AnalogOutput( AUDIOSOURCE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( AUDIOSOURCE__AnalogSerialOutput__, AUDIOSOURCE );
    
    PRIMARYVIDEOSOURCE = new Crestron.Logos.SplusObjects.AnalogOutput( PRIMARYVIDEOSOURCE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( PRIMARYVIDEOSOURCE__AnalogSerialOutput__, PRIMARYVIDEOSOURCE );
    
    SOURCEPAGETOSHOW = new Crestron.Logos.SplusObjects.AnalogOutput( SOURCEPAGETOSHOW__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SOURCEPAGETOSHOW__AnalogSerialOutput__, SOURCEPAGETOSHOW );
    
    SOURCELISTITEMCOUNT = new Crestron.Logos.SplusObjects.AnalogOutput( SOURCELISTITEMCOUNT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SOURCELISTITEMCOUNT__AnalogSerialOutput__, SOURCELISTITEMCOUNT );
    
    ENDPOINTLISTITEMCOUNT = new Crestron.Logos.SplusObjects.AnalogOutput( ENDPOINTLISTITEMCOUNT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ENDPOINTLISTITEMCOUNT__AnalogSerialOutput__, ENDPOINTLISTITEMCOUNT );
    
    ACTIVESOURCELISTITEMCOUNT = new Crestron.Logos.SplusObjects.AnalogOutput( ACTIVESOURCELISTITEMCOUNT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ACTIVESOURCELISTITEMCOUNT__AnalogSerialOutput__, ACTIVESOURCELISTITEMCOUNT );
    
    ROOMLISTITEMCOUNT = new Crestron.Logos.SplusObjects.AnalogOutput( ROOMLISTITEMCOUNT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ROOMLISTITEMCOUNT__AnalogSerialOutput__, ROOMLISTITEMCOUNT );
    
    ALTERNATEVIDEOSOURCE = new InOutArray<AnalogOutput>( 3, this );
    for( uint i = 0; i < 3; i++ )
    {
        ALTERNATEVIDEOSOURCE[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( ALTERNATEVIDEOSOURCE__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( ALTERNATEVIDEOSOURCE__AnalogSerialOutput__ + i, ALTERNATEVIDEOSOURCE[i+1] );
    }
    
    ROOMNAME = new Crestron.Logos.SplusObjects.StringOutput( ROOMNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ROOMNAME__AnalogSerialOutput__, ROOMNAME );
    
    SOURCENAME = new Crestron.Logos.SplusObjects.StringOutput( SOURCENAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCENAME__AnalogSerialOutput__, SOURCENAME );
    
    SOURCENOWPLAYINGLINE1 = new Crestron.Logos.SplusObjects.StringOutput( SOURCENOWPLAYINGLINE1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCENOWPLAYINGLINE1__AnalogSerialOutput__, SOURCENOWPLAYINGLINE1 );
    
    SOURCENOWPLAYINGLINE2 = new Crestron.Logos.SplusObjects.StringOutput( SOURCENOWPLAYINGLINE2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCENOWPLAYINGLINE2__AnalogSerialOutput__, SOURCENOWPLAYINGLINE2 );
    
    SOURCEBUTTONLABEL = new Crestron.Logos.SplusObjects.StringOutput( SOURCEBUTTONLABEL__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCEBUTTONLABEL__AnalogSerialOutput__, SOURCEBUTTONLABEL );
    
    AUDIOENDPOINTNAME = new Crestron.Logos.SplusObjects.StringOutput( AUDIOENDPOINTNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( AUDIOENDPOINTNAME__AnalogSerialOutput__, AUDIOENDPOINTNAME );
    
    AUDIOSOURCENAME = new Crestron.Logos.SplusObjects.StringOutput( AUDIOSOURCENAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( AUDIOSOURCENAME__AnalogSerialOutput__, AUDIOSOURCENAME );
    
    PRIMARYVIDEOENDPOINTNAME = new Crestron.Logos.SplusObjects.StringOutput( PRIMARYVIDEOENDPOINTNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PRIMARYVIDEOENDPOINTNAME__AnalogSerialOutput__, PRIMARYVIDEOENDPOINTNAME );
    
    PRIMARYVIDEOSOURCENAME = new Crestron.Logos.SplusObjects.StringOutput( PRIMARYVIDEOSOURCENAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PRIMARYVIDEOSOURCENAME__AnalogSerialOutput__, PRIMARYVIDEOSOURCENAME );
    
    SOURCELISTSELECTEDSOURCENAME = new Crestron.Logos.SplusObjects.StringOutput( SOURCELISTSELECTEDSOURCENAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCELISTSELECTEDSOURCENAME__AnalogSerialOutput__, SOURCELISTSELECTEDSOURCENAME );
    
    SELECTEDENDPOINTNAME = new Crestron.Logos.SplusObjects.StringOutput( SELECTEDENDPOINTNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SELECTEDENDPOINTNAME__AnalogSerialOutput__, SELECTEDENDPOINTNAME );
    
    SELECTEDENDPOINTACTIVESOURCENAME = new Crestron.Logos.SplusObjects.StringOutput( SELECTEDENDPOINTACTIVESOURCENAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SELECTEDENDPOINTACTIVESOURCENAME__AnalogSerialOutput__, SELECTEDENDPOINTACTIVESOURCENAME );
    
    SELECTEDENDPOINTACTIVESOURCEICON = new Crestron.Logos.SplusObjects.StringOutput( SELECTEDENDPOINTACTIVESOURCEICON__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SELECTEDENDPOINTACTIVESOURCEICON__AnalogSerialOutput__, SELECTEDENDPOINTACTIVESOURCEICON );
    
    CONTROLLEDSOURCENAME = new Crestron.Logos.SplusObjects.StringOutput( CONTROLLEDSOURCENAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONTROLLEDSOURCENAME__AnalogSerialOutput__, CONTROLLEDSOURCENAME );
    
    CONTROLLEDSOURCEICON = new Crestron.Logos.SplusObjects.StringOutput( CONTROLLEDSOURCEICON__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONTROLLEDSOURCEICON__AnalogSerialOutput__, CONTROLLEDSOURCEICON );
    
    ALTERNATEVIDEOENDPOINTNAME = new InOutArray<StringOutput>( 3, this );
    for( uint i = 0; i < 3; i++ )
    {
        ALTERNATEVIDEOENDPOINTNAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( ALTERNATEVIDEOENDPOINTNAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( ALTERNATEVIDEOENDPOINTNAME__AnalogSerialOutput__ + i, ALTERNATEVIDEOENDPOINTNAME[i+1] );
    }
    
    ALTERNATEVIDEOSOURCENAME = new InOutArray<StringOutput>( 3, this );
    for( uint i = 0; i < 3; i++ )
    {
        ALTERNATEVIDEOSOURCENAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( ALTERNATEVIDEOSOURCENAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( ALTERNATEVIDEOSOURCENAME__AnalogSerialOutput__ + i, ALTERNATEVIDEOSOURCENAME[i+1] );
    }
    
    SOURCELISTITEMNAME = new InOutArray<StringOutput>( 100, this );
    for( uint i = 0; i < 100; i++ )
    {
        SOURCELISTITEMNAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SOURCELISTITEMNAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SOURCELISTITEMNAME__AnalogSerialOutput__ + i, SOURCELISTITEMNAME[i+1] );
    }
    
    SOURCELISTICONFILENAME = new InOutArray<StringOutput>( 100, this );
    for( uint i = 0; i < 100; i++ )
    {
        SOURCELISTICONFILENAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SOURCELISTICONFILENAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SOURCELISTICONFILENAME__AnalogSerialOutput__ + i, SOURCELISTICONFILENAME[i+1] );
    }
    
    ENDPOINTLISTITEMNAME = new InOutArray<StringOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        ENDPOINTLISTITEMNAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( ENDPOINTLISTITEMNAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( ENDPOINTLISTITEMNAME__AnalogSerialOutput__ + i, ENDPOINTLISTITEMNAME[i+1] );
    }
    
    ENDPOINTLISTSOURCENAME = new InOutArray<StringOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        ENDPOINTLISTSOURCENAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( ENDPOINTLISTSOURCENAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( ENDPOINTLISTSOURCENAME__AnalogSerialOutput__ + i, ENDPOINTLISTSOURCENAME[i+1] );
    }
    
    ENDPOINTLISTICONFILENAME = new InOutArray<StringOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        ENDPOINTLISTICONFILENAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( ENDPOINTLISTICONFILENAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( ENDPOINTLISTICONFILENAME__AnalogSerialOutput__ + i, ENDPOINTLISTICONFILENAME[i+1] );
    }
    
    ACTIVESOURCELISTITEMNAME = new InOutArray<StringOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        ACTIVESOURCELISTITEMNAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( ACTIVESOURCELISTITEMNAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( ACTIVESOURCELISTITEMNAME__AnalogSerialOutput__ + i, ACTIVESOURCELISTITEMNAME[i+1] );
    }
    
    ACTIVESOURCELISTICONFILENAME = new InOutArray<StringOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        ACTIVESOURCELISTICONFILENAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( ACTIVESOURCELISTICONFILENAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( ACTIVESOURCELISTICONFILENAME__AnalogSerialOutput__ + i, ACTIVESOURCELISTICONFILENAME[i+1] );
    }
    
    ROOMLISTITEMNAME = new InOutArray<StringOutput>( 100, this );
    for( uint i = 0; i < 100; i++ )
    {
        ROOMLISTITEMNAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( ROOMLISTITEMNAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( ROOMLISTITEMNAME__AnalogSerialOutput__ + i, ROOMLISTITEMNAME[i+1] );
    }
    
    ROOMLISTSOURCENAME = new InOutArray<StringOutput>( 100, this );
    for( uint i = 0; i < 100; i++ )
    {
        ROOMLISTSOURCENAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( ROOMLISTSOURCENAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( ROOMLISTSOURCENAME__AnalogSerialOutput__ + i, ROOMLISTSOURCENAME[i+1] );
    }
    
    SOURCESHARINGLISTICONFILENAME = new InOutArray<StringOutput>( 100, this );
    for( uint i = 0; i < 100; i++ )
    {
        SOURCESHARINGLISTICONFILENAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SOURCESHARINGLISTICONFILENAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SOURCESHARINGLISTICONFILENAME__AnalogSerialOutput__ + i, SOURCESHARINGLISTICONFILENAME[i+1] );
    }
    
    ADVANCEDSOURCESELECTIONBUTTONBEHAVIOR = new UShortParameter( ADVANCEDSOURCESELECTIONBUTTONBEHAVIOR__Parameter__, this );
    m_ParameterList.Add( ADVANCEDSOURCESELECTIONBUTTONBEHAVIOR__Parameter__, ADVANCEDSOURCESELECTIONBUTTONBEHAVIOR );
    
    
    ROOMON.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOMON_OnPush_0, false ) );
    ROOMOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOMOFF_OnPush_1, false ) );
    ALLROOMSOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( ALLROOMSOFF_OnPush_2, false ) );
    ROOMSSHARINGSOURCEOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOMSSHARINGSOURCEOFF_OnPush_3, false ) );
    SELECTEDENDPOINTOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECTEDENDPOINTOFF_OnPush_4, false ) );
    REQUESTSOURCESELECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( REQUESTSOURCESELECT_OnPush_5, false ) );
    REQUESTSTANDARDSOURCESELECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( REQUESTSTANDARDSOURCESELECT_OnPush_6, false ) );
    REQUESTADVANCEDSOURCESELECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( REQUESTADVANCEDSOURCESELECT_OnPush_7, false ) );
    REQUESTROOMSELECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( REQUESTROOMSELECT_OnPush_8, false ) );
    REQUESTSOURCESHARE.OnDigitalPush.Add( new InputChangeHandlerWrapper( REQUESTSOURCESHARE_OnPush_9, false ) );
    REQUESTACTIVESOURCE.OnDigitalPush.Add( new InputChangeHandlerWrapper( REQUESTACTIVESOURCE_OnPush_10, false ) );
    REQUESTMEDIAHOME.OnDigitalPush.Add( new InputChangeHandlerWrapper( REQUESTMEDIAHOME_OnPush_11, false ) );
    REQUESTSELECTEDENDPOINTACTIVESOURCE.OnDigitalPush.Add( new InputChangeHandlerWrapper( REQUESTSELECTEDENDPOINTACTIVESOURCE_OnPush_12, false ) );
    REQUESTEDSOURCEPAGEISVALID.OnDigitalPush.Add( new InputChangeHandlerWrapper( REQUESTEDSOURCEPAGEISVALID_OnPush_13, false ) );
    SOURCESHAREALL.OnDigitalPush.Add( new InputChangeHandlerWrapper( SOURCESHAREALL_OnPush_14, false ) );
    DISMISSACTIVEPAGE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( DISMISSACTIVEPAGE_OnRelease_15, false ) );
    TOUCHSCREENID.OnAnalogChange.Add( new InputChangeHandlerWrapper( TOUCHSCREENID_OnChange_16, false ) );
    REQUESTROOMCONTROL.OnAnalogChange.Add( new InputChangeHandlerWrapper( REQUESTROOMCONTROL_OnChange_17, false ) );
    SOURCELISTITEMCLICKED.OnAnalogChange.Add( new InputChangeHandlerWrapper( SOURCELISTITEMCLICKED_OnChange_18, false ) );
    ENDPOINTLISTITEMCLICKED.OnAnalogChange.Add( new InputChangeHandlerWrapper( ENDPOINTLISTITEMCLICKED_OnChange_19, false ) );
    ACTIVESOURCELISTITEMCLICKED.OnAnalogChange.Add( new InputChangeHandlerWrapper( ACTIVESOURCELISTITEMCLICKED_OnChange_20, false ) );
    ROOMLISTITEMCLICKED.OnAnalogChange.Add( new InputChangeHandlerWrapper( ROOMLISTITEMCLICKED_OnChange_21, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    MEDIAUI  = new Crestron.Rio.DataStructures.Media.UserInterfaces.MediaTouchScreenSSharpComponent();
    DYNAMICMEDIAUI  = new Crestron.Rio.DataStructures.Media.UserInterfaces.DynamicMediaUserInterface();
    
    
}

public CrestronModuleClass_CSR_MEDIA_TOUCH_SCREEN_SIMPL__INTERFACE_V1_1_4 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint ROOMON__DigitalInput__ = 0;
const uint ROOMOFF__DigitalInput__ = 1;
const uint ALLROOMSOFF__DigitalInput__ = 2;
const uint ROOMSSHARINGSOURCEOFF__DigitalInput__ = 3;
const uint SELECTEDENDPOINTOFF__DigitalInput__ = 4;
const uint REQUESTSOURCESELECT__DigitalInput__ = 5;
const uint REQUESTSTANDARDSOURCESELECT__DigitalInput__ = 6;
const uint REQUESTADVANCEDSOURCESELECT__DigitalInput__ = 7;
const uint REQUESTROOMSELECT__DigitalInput__ = 8;
const uint REQUESTSOURCESHARE__DigitalInput__ = 9;
const uint REQUESTACTIVESOURCE__DigitalInput__ = 10;
const uint REQUESTMEDIAHOME__DigitalInput__ = 11;
const uint REQUESTSELECTEDENDPOINTACTIVESOURCE__DigitalInput__ = 12;
const uint REQUESTEDSOURCEPAGEISVALID__DigitalInput__ = 13;
const uint SOURCESHAREALL__DigitalInput__ = 14;
const uint DISMISSACTIVEPAGE__DigitalInput__ = 15;
const uint TOUCHSCREENID__AnalogSerialInput__ = 0;
const uint REQUESTROOMCONTROL__AnalogSerialInput__ = 1;
const uint SOURCELISTITEMCLICKED__AnalogSerialInput__ = 2;
const uint ENDPOINTLISTITEMCLICKED__AnalogSerialInput__ = 3;
const uint ACTIVESOURCELISTITEMCLICKED__AnalogSerialInput__ = 4;
const uint ROOMLISTITEMCLICKED__AnalogSerialInput__ = 5;
const uint TOUCHSCREENINITIALIZED__DigitalOutput__ = 0;
const uint MEDIAINITIALIZATIONINPOGRESS__DigitalOutput__ = 1;
const uint ROOMISON__DigitalOutput__ = 2;
const uint ROOMISOFF__DigitalOutput__ = 3;
const uint AUDIOENDPOINTISON__DigitalOutput__ = 4;
const uint ROOMHASACTIVESOURCE__DigitalOutput__ = 5;
const uint SELECTEDENDPOINTHASACTIVESOURCE__DigitalOutput__ = 6;
const uint SHOWSOURCESELECT__DigitalOutput__ = 7;
const uint SHOWADVANCEDSOURCESELECT__DigitalOutput__ = 8;
const uint SHOWROOMSELECT__DigitalOutput__ = 9;
const uint SHOWSOURCESHARE__DigitalOutput__ = 10;
const uint SHOWACTIVESOURCESELECT__DigitalOutput__ = 11;
const uint ANYMEDIAPAGEACTIVE__DigitalOutput__ = 12;
const uint SHOWSOURCESELECTBUTTON__DigitalOutput__ = 13;
const uint SHOWADVANCEDSOURCESELECTBUTTON__DigitalOutput__ = 14;
const uint SHOWROOMSELECTBUTTON__DigitalOutput__ = 15;
const uint SHOWSOURCESHAREBUTTON__DigitalOutput__ = 16;
const uint SELECTEDROOMID__AnalogSerialOutput__ = 0;
const uint ROOMEQUIPMENTIDTOCONNECT__AnalogSerialOutput__ = 1;
const uint ROOMSOURCE__AnalogSerialOutput__ = 2;
const uint AUDIOSOURCE__AnalogSerialOutput__ = 3;
const uint PRIMARYVIDEOSOURCE__AnalogSerialOutput__ = 4;
const uint SOURCEPAGETOSHOW__AnalogSerialOutput__ = 5;
const uint SOURCELISTITEMCOUNT__AnalogSerialOutput__ = 6;
const uint ENDPOINTLISTITEMCOUNT__AnalogSerialOutput__ = 7;
const uint ACTIVESOURCELISTITEMCOUNT__AnalogSerialOutput__ = 8;
const uint ROOMLISTITEMCOUNT__AnalogSerialOutput__ = 9;
const uint ROOMNAME__AnalogSerialOutput__ = 10;
const uint SOURCENAME__AnalogSerialOutput__ = 11;
const uint SOURCENOWPLAYINGLINE1__AnalogSerialOutput__ = 12;
const uint SOURCENOWPLAYINGLINE2__AnalogSerialOutput__ = 13;
const uint SOURCEBUTTONLABEL__AnalogSerialOutput__ = 14;
const uint AUDIOENDPOINTNAME__AnalogSerialOutput__ = 15;
const uint AUDIOSOURCENAME__AnalogSerialOutput__ = 16;
const uint PRIMARYVIDEOENDPOINTNAME__AnalogSerialOutput__ = 17;
const uint PRIMARYVIDEOSOURCENAME__AnalogSerialOutput__ = 18;
const uint SOURCELISTSELECTEDSOURCENAME__AnalogSerialOutput__ = 19;
const uint SELECTEDENDPOINTNAME__AnalogSerialOutput__ = 20;
const uint SELECTEDENDPOINTACTIVESOURCENAME__AnalogSerialOutput__ = 21;
const uint SELECTEDENDPOINTACTIVESOURCEICON__AnalogSerialOutput__ = 22;
const uint CONTROLLEDSOURCENAME__AnalogSerialOutput__ = 23;
const uint CONTROLLEDSOURCEICON__AnalogSerialOutput__ = 24;
const uint SOURCELISTITEMSELECTED__DigitalOutput__ = 17;
const uint ENDPOINTLISTITEMENABLED__DigitalOutput__ = 117;
const uint SOURCESHARINGLISTITEMENABLED__DigitalOutput__ = 122;
const uint ALTERNATEVIDEOSOURCE__AnalogSerialOutput__ = 25;
const uint ALTERNATEVIDEOENDPOINTNAME__AnalogSerialOutput__ = 28;
const uint ALTERNATEVIDEOSOURCENAME__AnalogSerialOutput__ = 31;
const uint SOURCELISTITEMNAME__AnalogSerialOutput__ = 34;
const uint SOURCELISTICONFILENAME__AnalogSerialOutput__ = 134;
const uint ENDPOINTLISTITEMNAME__AnalogSerialOutput__ = 234;
const uint ENDPOINTLISTSOURCENAME__AnalogSerialOutput__ = 239;
const uint ENDPOINTLISTICONFILENAME__AnalogSerialOutput__ = 244;
const uint ACTIVESOURCELISTITEMNAME__AnalogSerialOutput__ = 249;
const uint ACTIVESOURCELISTICONFILENAME__AnalogSerialOutput__ = 254;
const uint ROOMLISTITEMNAME__AnalogSerialOutput__ = 259;
const uint ROOMLISTSOURCENAME__AnalogSerialOutput__ = 359;
const uint SOURCESHARINGLISTICONFILENAME__AnalogSerialOutput__ = 459;
const uint ADVANCEDSOURCESELECTIONBUTTONBEHAVIOR__Parameter__ = 10;

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
