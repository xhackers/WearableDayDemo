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

namespace EightBall.iOS
{
	[Register ("RootViewController")]
	partial class RootViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonPrediction { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lastPrediction { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel prediction { get; set; }

		[Action ("buttonPrediction_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void buttonPrediction_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (buttonPrediction != null) {
				buttonPrediction.Dispose ();
				buttonPrediction = null;
			}
			if (lastPrediction != null) {
				lastPrediction.Dispose ();
				lastPrediction = null;
			}
			if (prediction != null) {
				prediction.Dispose ();
				prediction = null;
			}
		}
	}
}
