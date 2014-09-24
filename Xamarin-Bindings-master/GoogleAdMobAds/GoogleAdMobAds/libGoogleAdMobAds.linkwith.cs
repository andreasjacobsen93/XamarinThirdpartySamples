using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libGoogleAdMobAds.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true)]
