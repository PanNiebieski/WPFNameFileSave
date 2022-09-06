using System.IO;
using System.Windows;

namespace WPFNameFileSave
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnConfim_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("Hi_My_Name_Is.txt"))
            {
                writer.Write("Zapisuje tekst");
                writer.WriteLine("Zapisuje tekst i tworze znak nowej lini");
                writer.WriteLine(tb_Name.Text);
                writer.WriteLine(tb_SurName.Text);
            }
        }
    }
}
