using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.AVFoundation;
using MonoTouch.AudioToolbox;
using MonoTouch.MediaPlayer;
using MonoTouch.ExternalAccessory;

namespace magTechBinding
{
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     PointF Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://docs.xamarin.com/ios/advanced_topics/binding_objective-c_types
	//


	[BaseType (typeof(NSObject))]
	interface uniMag
	{
		[Static]
		[Export ("SDK_version")]
		string SDK_version ();
		
		[Export ("isReaderAttached")]
		bool IsReaderAttached ();
		
		[Export ("getConnectionStatus")]
		bool GetConnectionStatus ();
		
		[Export ("getRunningTask")]
		UmTask GetRunningTask ();
		
		[Export ("getVolumeLevel")]
		float GetVolumeLevel ();
		
		[Export ("setAutoConnect:")]
		void SetAutoConnect (bool autoConnect);
		
		[Export ("setSwipeTimeoutDuration:seconds")]
		bool SetSwipeTimeoutDuration (int seconds);
		
		[Export ("setCmdTimeoutDuration:seconds")]
		bool SetCmdTimeoutDuration (int seconds );
		
		[Export ("setAutoAdjustVolume:b")]
		void SetAutoAdjustVolume (bool b );
		
		[Export ("setDeferredActivateAudioSession:b")]
		void SetDeferredActivateAudioSession (bool b);
		
		[Export ("cancelTask")]
		void CancelTask ();
		
		[Export ("startUniMag:")]
		UmRet StartUniMag (bool start);
		
		[Export ("requestSwipe")]
		UmRet RequestSwipe ();
		
		[Export ("getFlagByte")]
		NSData GetFlagByte ();
		
		[Export ("sendCommandGetVersion")]
		UmRet SendCommandGetVersion ();
		
		[Export ("sendCommandGetSettings")]
		UmRet SendCommandGetSettings ();
		
		[Export ("sendCommandEnableTDES")]
		UmRet SendCommandEnableTDES ();
		
		[Export ("sendCommandEnableAES")]
		UmRet SendCommandEnableAES ();
		
		[Export ("sendCommandDefaultGeneralSettings")]
		UmRet SendCommandDefaultGeneralSettings ();
		
		[Export ("sendCommandGetSerialNumber")]
		UmRet SendCommandGetSerialNumber ();
		
		[Export ("sendCommandGetNextKSN")]
		UmRet SendCommandGetNextKSN ();
		
		[Export ("sendCommandEnableErrNotification")]
		UmRet SendCommandEnableErrNotification ();
		
		[Export ("sendCommandDisableErrNotification")]
		UmRet SendCommandDisableErrNotification ();
		
		[Export ("sendCommandEnableExpDate")]
		UmRet SendCommandEnableExpDate ();
		
		[Export ("sendCommandDisableExpDate")]
		UmRet SendCommandDisableExpDate ();
		
		[Export ("sendCommandEnableForceEncryption")]
		UmRet SendCommandEnableForceEncryption ();
		
		[Export ("sendCommandDisableForceEncryption")]
		UmRet SendCommandDisableForceEncryption ();
		
		[Export ("sendCommandSetPrePAN:prePAN")]
		UmRet SendCommandSetPrePAN (int prePAN);
		
		[Export ("sendCommandClearBuffer")]
		UmRet SendCommandClearBuffer ();
		
		[Export ("getAuthentication")]
		UmRet GetAuthentication ();
				
		[Export ("setFirmwareFile:location")]
		bool SetFirmwareFile (string location);
		
		[Export ("updateFirmware:encrytedBytes")]
		UmRet UpdateFirmware (string encrytedBytes );
		
		[Export ("updateFirmware2:stringwithFile:path")]
		UmRet UpdateFirmware2 (string stringwithFile, string path );
		
		[Static]
		[Export ("enableLogging:enable")]
		void EnableLogging (bool enable );
		
		[Export ("getWave")]
		NSData GetWave ();
		
		[Export ("setWavePath:path")]
		bool SetWavePath (string path );
		
		[Export ("autoDetect:")]
		void AutoDetect (bool autoDetect);
		
		[Export ("promptForConnection:")]
		void PromptForConnection (bool prompt);
		
		[Export ("proceedPoweringUp:proceedPowerUp")]
		UmRet ProceedPoweringUp (bool proceedPowerUp );
		
		[Export ("closeConnection")]
		void CloseConnection ();
		
		[Export ("cancelSwipe")]
		void CancelSwipe ();
	}

}