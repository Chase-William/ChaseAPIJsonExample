using AlphaVantage.Net.Stocks.TimeSeries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
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

        public StockDataPoint[] DataPoints { get; set; }

        public IndexInt Index;

        private string highestPrice;
        public string HighestPrice {
            get => highestPrice;
            set
            {
                highestPrice = value;
                NotifyPropertyChanged();
            }
        }
        private string lowestPrice;
        public string LowestPrice {
            get => lowestPrice;
            set
            {
                lowestPrice = value;
                NotifyPropertyChanged();
            }
        }
        private string volume;
        public string Volume {
            get => volume;
            set
            {
                volume = value;
                NotifyPropertyChanged();
            }
        }
        private string time;
        public string Time {
            get => time;
            set
            {
                time = value;
                NotifyPropertyChanged();
            }
        }

        public ICommand NextCMD { get; set; }
       
        public ICommand PreviousCMD { get; set; }

        public MainViewModel(StockDataPoint[] _dataPoints)
        {
            NextCMD = new Command(() => {
                Index.Value++;
                GetDataPoint();
            });
            PreviousCMD = new Command(() => {
                Index.Value--;
                GetDataPoint();
            });
            Index = new IndexInt(_dataPoints.Length - 1);
            DataPoints = _dataPoints;
            GetDataPoint();
        }


        private void GetDataPoint()
        {
            HighestPrice = DataPoints[Index.Value].HighestPrice.ToString();
            LowestPrice = DataPoints[Index.Value].LowestPrice.ToString();
            Volume = DataPoints[Index.Value].Volume.ToString();
            Time = DataPoints[Index.Value].Time.ToString();
        }
    }
}
