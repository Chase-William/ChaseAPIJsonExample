using System;
using System.Collections.Generic;
using System.ComponentModel;
using AlphaVantage.Net.Stocks;
using System.Threading.Tasks;
using Xamarin.Forms;
using AlphaVantage.Net.Stocks.TimeSeries;
using System.Linq;

namespace ChaseAPIExample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public StockTimeSeries StockTimes { get; set; }
        public StockDataPoint[] DataPoints { get; set; }


        public MainPage()
        {
            InitializeComponent();
            OnGetData();
        }

        private async void OnGetData()
        {
            await GetAlphaVantageStocks();
            BindingContext = new MainViewModel(DataPoints);
        }

        public async Task GetAlphaVantageStocks()
        {
            string apiKey = "EP1MXRA47MWA2Q8N"; 

            var client = new AlphaVantageStocksClient(apiKey);

            // retrieve daily time series for stocks of Apple Inc.:
            StockTimes = await client.RequestDailyTimeSeriesAsync("AAPL", TimeSeriesSize.Compact, adjusted: false);
            DataPoints = StockTimes.DataPoints.ToArray();
        }
    }
}
