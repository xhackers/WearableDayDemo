// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace EightBall.WatchApp.WKExtension
{
	[Register ("InterfaceController")]
	partial class InterfaceController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceButton buttonPredict { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceLabel lastPrediction { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceLabel predictionLabel { get; set; }

		[Action ("buttonPredict_Activated:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void buttonPredict_Activated (WatchKit.WKInterfaceButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (buttonPredict != null) {
				buttonPredict.Dispose ();
				buttonPredict = null;
			}
			if (lastPrediction != null) {
				lastPrediction.Dispose ();
				lastPrediction = null;
			}
			if (predictionLabel != null) {
				predictionLabel.Dispose ();
				predictionLabel = null;
			}
		}
	}
}
