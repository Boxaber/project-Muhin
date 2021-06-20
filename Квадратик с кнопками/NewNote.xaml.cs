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
using System.IO;

namespace Квадратик_с_кнопками
{
    /// <summary>
    /// Логика взаимодействия для NewNote.xaml
    /// </summary>
    public partial class NewNote : Window
    {
        MainWindow mainWindow;
        public NewNote(MainWindow lastWindow)
        {
            mainWindow = lastWindow;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(textbox1.Text.Length > 0 && textbox2.Text.Length > 0)
            {
                if (File.Exists(Environment.CurrentDirectory + "\\notes\\" + textbox1.Text + ".txt"))
                    File.Create(Environment.CurrentDirectory + "\\notes\\" + textbox1.Text + ".txt").Close();
                File.WriteAllText(Environment.CurrentDirectory + "\\notes\\" + textbox1.Text + ".txt", textbox2.Text);
                mainWindow.listbox1.Items.Clear();
                mainWindow.showAllNotes();
                this.Close();
            }
            else
            {
                MessageBox.Show("Сударь, вы дурак!");
            }
        }
    }
}
