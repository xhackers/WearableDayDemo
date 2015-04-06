using System;

using WatchKit;
using Foundation;

namespace EightBall.WatchApp.WKExtension
{
    public partial class InterfaceController : WKInterfaceController
    {
        string lastResult = "";
        public InterfaceController(IntPtr handle)
            : base(handle)
        {
        }

        public override void Awake(NSObject context)
        {
            base.Awake(context);

            // Configure interface objects here.
            Console.WriteLine("{0} awake with context", this);
        }

        public override void WillActivate()
        {
            // This method is called when the watch view controller is about to be visible to the user.
            Console.WriteLine("{0} will activate", this);
        }

        public override void DidDeactivate()
        {
            // This method is called when the watch view controller is no longer visible to the user.
            Console.WriteLine("{0} did deactivate", this);
        }

        partial void buttonPredict_Activated(WKInterfaceButton sender)
        {
            if (lastResult != "") lastPrediction.SetText(lastResult);
            PCL.Predict predict = new PCL.Predict();
            lastResult = predict.GetPrediction();
            predictionLabel.SetText(lastResult);
        }

      
    }
}

