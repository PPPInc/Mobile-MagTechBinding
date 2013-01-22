using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("IDTECH_UniMag.a", LinkTarget.ArmV6 | LinkTarget.ArmV7 | LinkTarget.Simulator, ForceLoad = true,  Frameworks = "AVFoundation AudioToolbox MediaPlayer ExternalAccessory MessageUI Foundation")]
