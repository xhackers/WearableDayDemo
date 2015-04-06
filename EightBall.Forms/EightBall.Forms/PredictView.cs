using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using EightBall.PCL;

namespace EightBall.Forms
{
    public class PredictView: ContentPage
    {
        string lastResult = "";
        Label prediction = new Label();
        Button buttonPredict = new Button();
        Label lastPrediction = new Label();
        
        public PredictView()
        {
            buttonPredict.Text = "Give me a prediction";
            prediction.HorizontalOptions = LayoutOptions.Center;
            lastPrediction.HorizontalOptions = LayoutOptions.Center;
            buttonPredict.Clicked += buttonPredict_Clicked;
            this.Content = new StackLayout()
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
						prediction, buttonPredict, lastPrediction
					}
                };
        }

        void buttonPredict_Clicked(object sender, EventArgs e)
        {
            if (lastResult != "")
                lastPrediction.Text = lastResult;
            Predict predict = new Predict();
            lastResult = predict.GetPrediction();
            prediction.Text = lastResult;
        }
    }
}
