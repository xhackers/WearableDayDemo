using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using EightBall.PCL;
namespace EightBall.Droid
{
    [Activity(Label = "EightBall.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        string lastResult = "";
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

             Button predict = FindViewById<Button>(Resource.Id.buttonPredict);

            predict.Click += predict_Click;
        }

        void predict_Click(object sender, EventArgs e)
        {
            Predict predict = new Predict();
            if(lastResult!="")
            {
                TextView lastPrediction = FindViewById<TextView>(Resource.Id.lastPrediction);
                lastPrediction.Text = lastResult;
            }
            lastResult = predict.GetPrediction();
            TextView currentPrediction = FindViewById<TextView>(Resource.Id.predictionText);
            currentPrediction.Text = lastResult;
        }
    }
}

