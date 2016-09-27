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
using System.Windows.Threading;

namespace ScoreManagerPL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            startclock();
            ScoreManagerBL.App.GeraPastas();
        }

        private void startclock()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickevent;
            timer.Start();
        }

        private void tickevent(object sender, EventArgs e)
        {
            cronometroOutput.Text = ScoreManagerBL.Cronometro.Formata();
        }

        private void frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void resultado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void textBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void cronometroIniciar_Click(object sender, RoutedEventArgs e)
        {
            Window popup1 = new Popup("Isto é um popup");
            popup1.Show();

            try
            {
                ScoreManagerBL.Cronometro.Start();
            }
            catch (Exception exc)
            {
                Window popup = new Popup(exc.Message);
                popup.Show();
            }
        }
    }
}
