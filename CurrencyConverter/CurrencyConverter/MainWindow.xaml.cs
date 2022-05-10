using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CurrencyConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BindCurrency()
        {
            DataTable dtCurrency = new DataTable();
            dtCurrency.Columns.Add("Text");
            dtCurrency.Columns.Add("Value");

            dtCurrency.Rows.Add("--SELECT--", 0);
            dtCurrency.Rows.Add("EUR", 1);
            dtCurrency.Rows.Add("USD", 75);
        }

        private async Task<string> GetRates()
        {
            var client = new RestClient("https://api.apilayer.com/exchangerates_data/latest?symbols=&base=");

            var request = new RestRequest();
            request.AddHeader("apikey", "orm11MKJCIt2kwBGQiBWOowZgqJdzLSN");

            var response = await client.ExecuteAsync(request);

            var details = JObject.Parse(response.Content);

            Console.WriteLine("result:");
            Console.WriteLine(details["rates"]["CAD"]);

            return response.Content;
        }

        private void Convert_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            lblCurrency.Content = "";
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            
        }
    }
}
