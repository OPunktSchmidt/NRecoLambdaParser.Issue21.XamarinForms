using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NRecoLambdaParser.Issue21.XamarinForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts

            try
            {
                NReco.Linq.LambdaParser parser = new NReco.Linq.LambdaParser(new NReco.Linq.ValueComparer() { NullComparison = NReco.Linq.ValueComparer.NullComparisonMode.Sql });

                string evalString = "(val1.Contains(val2) || val3.Contains(val4) || val5.Contains(val6) || val7.Contains(val8) || val9.Contains(val10) || val11.Contains(val12) || val13.Contains(val14) || val15.Contains(val16) || val17.Contains(val18) || val19.Contains(val20))";

                System.Collections.Generic.Dictionary<string, object> values = new System.Collections.Generic.Dictionary<string, object>();
                values.Add("val20", "10;");
                values.Add("val17", "2;4;5;7;8;");
                values.Add("val12", "6");
                values.Add("val7", "2;4;5;7;8;");
                values.Add("val2", "1");
                values.Add("val19", "2;4;5;7;8;");
                values.Add("val13", "2;4;5;7;8;");
                values.Add("val8", "4");
                values.Add("val3", "2;4;5;7;8;");
                values.Add("val1", "2;4;5;7;8;");
                values.Add("val5", "2;4;5;7;8;");
                values.Add("val16", "8");
                values.Add("val18", "9");
                values.Add("val14", "7");
                values.Add("val4", "2");
                values.Add("val11", "2;4;5;7;8;");
                values.Add("val9", "2;4;5;7;8;");
                values.Add("val10", "5");
                values.Add("val15", "2;4;5;7;8;");
                values.Add("val6", "3");

                object evalResult = parser.Eval(evalString, values);

                System.Diagnostics.Debugger.Break();
            }
            catch (System.Exception ex)
            {
                System.Diagnostics.Debugger.Break();
            }
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
