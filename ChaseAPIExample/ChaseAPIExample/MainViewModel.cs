using Newtonsoft.Json;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace ChaseAPIExample
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string _propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(_propName));
        }

        public RootObject RootObject { get; set; }

        private string snowLevel;
        public string SnowLevel { 
            get => snowLevel;
            set
            {
                snowLevel = value;
                NotifyPropertyChanged();
            }
        }

        private string temp;
        public string Temp
        {
            get => temp;
            set
            {
                temp = value;
                NotifyPropertyChanged();
            }
        }

        private string weatherTime;
        public string WeatherTime
        {
            get => weatherTime;
            set
            {
                weatherTime = value;
                NotifyPropertyChanged();
            }
        }

        private string elevationAndUnitCode;
        public string ElevationAndUnitCode
        {
            get => elevationAndUnitCode;
            set
            {
                elevationAndUnitCode = value;
                NotifyPropertyChanged();
            }
        }

        public string XCoord { get; set; }
        public string YCoord { get; set; }

        public ICommand GetDataForCoordsCMD => new Command(async () =>
        {
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            double yCoord = 0.0;            

            if (!(double.TryParse(XCoord, out double xCoord) && double.TryParse(YCoord, out yCoord)))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Coordinate fields have invalid values.", "OK");
                return;
            }

            try
            {

                var responce = client.DownloadString($"https://api.weather.gov/gridpoints/TOP/{xCoord:0000},{yCoord:0000}");
                RootObject = new RootObject();
                RootObject = JsonConvert.DeserializeObject<RootObject>(responce); // https://api.weather.gov/points/39,-97

                if (RootObject.properties.temperature.values.Count != 0)
                    Temp = RootObject.properties.temperature.values.FirstOrDefault().value.ToString();
                

                if (RootObject.properties.snowLevel.values.Count != 0)
                    SnowLevel = RootObject.properties.snowLevel.values.FirstOrDefault().ToString();
                

                if (RootObject.properties.weather.values?.ElementAt(0)?.validTime != null)
                    WeatherTime = RootObject.properties.weather.values.ElementAt(0).validTime;

                ElevationAndUnitCode = RootObject.properties.elevation.value + " " + RootObject.properties.elevation.unitCode;
            }
            catch
            {
                await App.Current.MainPage.DisplayAlert("Error", "Unable to find the given location.", "OK");
            }
        });
    }
}
