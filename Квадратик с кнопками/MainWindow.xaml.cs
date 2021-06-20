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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Drawing;

namespace Квадратик_с_кнопками
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] allfiles;
        int countFiles = 0;
        DateTime datenow;
        public void showAllNotes()
        {
            allfiles = Directory.GetFiles(Environment.CurrentDirectory + "\\notes", "*.txt");
            foreach(string onlyName in allfiles)
            {
                allfiles[countFiles] = System.IO.Path.GetFileNameWithoutExtension(onlyName);
                listbox1.Items.Insert(countFiles, allfiles[countFiles]);
                countFiles++;
            }
            countFiles = 0;
        }
        public void changeBackground()
        {
            Bitmap bitmap;
            if(datenow.Month == 1 || datenow.Month == 2 || datenow.Month == 12)
            {
                bitmap = Properties.Resources.winter;
                calendar.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(0xEE, 0xE0, 0xFF, 0xFF));
            }
            else if (datenow.Month >= 3 && datenow.Month <= 5)
            {
                bitmap = Properties.Resources.spring;
                calendar.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(0xEE, 0xFF, 0xC0, 0xCB));
            }
            else if (datenow.Month >= 6 && datenow.Month <= 8)
            {
                bitmap = Properties.Resources.summer;
                calendar.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(0xEE, 98, 0xFB, 98));
            }
            else
            {
                  bitmap = Properties.Resources.autumn;
                  calendar.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(0xEE, 0xFF, 0xD7, 00));
            }
            MemoryStream ms = new MemoryStream();
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            ms.Seek(0, SeekOrigin.Begin);
            image.StreamSource = ms;
            image.EndInit();
            imgBrush.ImageSource = image;
        }
        public MainWindow()
        {
            InitializeComponent();
            datenow = DateTime.Now;
            label1.Content = DateTime.Now;
            showAllNotes();
            changeBackground();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewNote newNote = new NewNote(this);
            newNote.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            zxc Zxc = new zxc();
            this.Hide();
            Zxc.ShowDialog();
            this.Close();
        }

        private void listbox1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string data = File.ReadAllText(Environment.CurrentDirectory + "\\notes\\" + listbox1.SelectedItem.ToString() + ".txt");
            textbox1.Text = data;
        }

    }
}
