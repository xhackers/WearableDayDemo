Eight ball
----------
This is a demo app built for Wearables Day at XHackers event

Story
-----
Eight Ball [ http://www.amazon.com/Mattel-30188-Magic-8-Ball/dp/B00001ZWV7 ] is a fun toy. You think of a question and shake the eight bll and it gives a random answer like "Yes definitely", "Ask again later", "My reply is no".

Solution
--------
1. Create a EightBall solution [Ref 1.png]
2. Create a simple Eight Ball Classic Xamarin Android App project, add label to show latest prediction, button to get prediction and another label to show last prediction.
3. Extract the business logic in to a PCL project and add that PCL Dll as reference to Android project and test.
4. Create an Eight Ball Classic Xamarin iOS App project and add PCL as a reference dll. Create two labels and a button and wire the events and test.
5. Create an Eight Ball Classic Windows Phone App project and adding PCL as a reference dll. Create two labels and a button and wire the events and test.
6. Create a PCL based Xamarin Forms Project and add PCL as a reference dll. Create two labels and a button and wire the events and test Android, iOS and WP8 projects.
7. Create a WatchKit App project that refers Classic Xamarin iOS project. Add reference of WatchKit Extension project in Classic Xamarin iOS project and Add a reference of WatchKit App project in WatchKit Extension project.
8. Create a WatchKit App project that refers Xamarin Forms iOS project.  Add reference of WatchKit Extension project in Xamarin Forms iOS project and Add a reference of WatchKit App project in WatchKit Extension project. [Ref 2.png]
9. From the info.plist screen of iOS project, copy the 'bundle identifier' in Xamarin Studio ('identifier' in Visual Studio). [Ref 3.png / 4.png ]
10. Go to corresponding iOS WatchKit App project, and open info.plist file, paste the corresponding iOS application's 'bundle identifier'/'identifier' in 'Companion App project Id' field in Visual Studio. In Xamarin Studio it is not required.
11. In Visual Studio, in 'identifier' field, remove existing text and paste 'bundle identifier'/'identifier' and append '.watchkitapp' to it. In Xamarin Studio, it is 'bundle identifier' field. This will be WatchKit App project's bundle identifier.
12. Go to corresponding ios WatchKit Extension App project project, and open info.plist file, in 'WKApp Bundle Id field' (Same in Visual Studio and Xamarin Studio), update with WatchKit App project's bundle identifier. In 'Bundle identifier'(Xamarin Studio)/'Identifier'(Visual Studio) field, update it with corresponding iOS project's bunder identifier, appended with '.watchkitextension'.
13. Check the references of iOS project, WatchKit project and WatchKit Extension project. iOS project should reference the WatchKit Extension project and WatchKit Extension project should reference WatchKit project.
14. Create two labels and a button like before in WatchKit Storyboard. Notice that Actions and Outlets are created in interfaceController file in corresponding WatchKit Extension project.
15. Make iOS project as start up project and deploy to simulator. This wil deploy the watchkitapp to watch simulator.
16. Make WatchKit Extension as start up project and run the solution. You will now see the app running in Watch simulator. [Ref 5.png]



