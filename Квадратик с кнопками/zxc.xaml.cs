using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace Квадратик_с_кнопками
{
    /// <summary>
    /// Логика взаимодействия для zxc.xaml
    /// </summary>
    public partial class zxc : Window
    {
        string Name;
        string url = "http://api.openweathermap.org/data/2.5/find?q=" + "Taganrog" + "&type=like&APPID=9f35c5c71c6533616869483efc82d207";
        
        public zxc()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Net.WebRequest reqGET = System.Net.WebRequest.Create(url);
            System.Net.WebResponse resp = reqGET.GetResponse();
            System.IO.Stream stream = resp.GetResponseStream();
            System.IO.StreamReader sr = new System.IO.StreamReader(stream);
            var s = sr.ReadToEnd();
            JObject obj = JObject.Parse(s);
            string temp = obj["list"][0]["main"]["temp"].ToString();
            string temp1 = obj["list"][0]["main"]["feels_like"].ToString();
            string temp2 = obj["list"][0]["main"]["temp_min"].ToString();
            string temp3 = obj["list"][0]["main"]["temp_max"].ToString();
            string temp4 = obj["list"][0]["main"]["pressure"].ToString();
            string temp5 = obj["list"][0]["main"]["humidity"].ToString();
            string temp6 = obj["list"][0]["wind"]["speed"].ToString();
            string temp7 = obj["list"][0]["wind"]["deg"].ToString();
            string temp8 = obj["list"][0]["sys"]["country"].ToString();
            double conv = Convert.ToDouble(temp) - 273.15;
            double conv1 = Convert.ToDouble(temp2) - 273.15;
            double conv2 = Convert.ToDouble(temp3) - 273.15;
            double conv3 = Convert.ToDouble(temp1) - 273.15;
            double pres = Convert.ToDouble(temp4) / 133 * 100;
            label1.Content = Math.Ceiling(conv) + "℃";
            label2.Content = Math.Ceiling(conv3) + "℃";
            label3.Content = Math.Ceiling(conv1) + "℃";
            label4.Content = Math.Ceiling(conv2) + "℃";
            label5.Content = Math.Ceiling(pres);
            label6.Content = temp5;
            label7.Content = temp6;
            label8.Content = temp7;
            label9.Content = temp8;

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Name = textbox1.Text;
            url = "http://api.openweathermap.org/data/2.5/find?q=" + Name + "&type=like&APPID=9f35c5c71c6533616869483efc82d207";
        }

        private void Textbox1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            textbox1.Text = " ";
        }
    }
}
