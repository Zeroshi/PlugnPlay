using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;

namespace UITest
{
    [TestFixture]
    public class Tests
    {
        AndroidApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            // TODO: If the Android app being tested is included in the solution then open
            // the Unit Tests window, right click Test Apps, select Add App Project
            // and select the app projects that should be tested.
            app = ConfigureApp
                .Android
                // TODO: Update this path to point to your Android app and uncomment the
                // code if the app is not included in the solution.
                //.ApkFile(@"C:\Users\Ganesh\Source\Repos\MyFirstProject\x-Platform\x-Platform\x_Platform.Android\bin\Release\x_Platform.Android.apk")
                .InstalledApp("x_Platform.Android")
                .StartApp();
        }

        [Test]
        public void Btn_Click()
        {
            //app.Repl();
            app.WaitForElement(c => c.Button("Click Here"));
           app.Tap(c => c.Button("Click Here"));

        }
    }
    }

    

