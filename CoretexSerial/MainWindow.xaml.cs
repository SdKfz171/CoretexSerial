using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO.Ports;
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

namespace CoretexSerial
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public SerialPort serial;

        private string ComPortName;

        private Hashtable hashtable;

        public MainWindow()
        {
            InitializeComponent();

            //serial = new SerialPort();
            //serial.BaudRate = 9600;
            //serial.DataBits = 8;
            //serial.StopBits = StopBits.One;
            //serial.Parity = Parity.None;
            //serial.PortName = ComPortName;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button SelectedButton = (Button)sender;

            if (SelectedButton.Content.Equals("문자열 전송하기"))
            {
                MainTextBox.Visibility = Visibility.Visible;
                SerialResultBlock.Visibility = Visibility.Collapsed;
            }

            else if(SelectedButton.Content.Equals("시리얼 모니터 띄우기"))
            {
                SerialResultBlock.Visibility = Visibility.Visible;
                MainTextBox.Visibility = Visibility.Collapsed;
            }
        }

        private void BaudLateComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string SelectedValue = ((ComboBoxItem)BaudLateComboBox.SelectedValue).Content.ToString();

            MainTextBox.Text += SelectedValue + " Selected\t";
            SerialResultBlock.Text += SelectedValue + " Selected\t";
            

        }

        private void ComPortComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void StateButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HexButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void AsciiButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void SendStringNoti_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RecieveStringNoti_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ComPortComboBox_GotFocus(object sender, RoutedEventArgs e)
        {
            hashtable = new Hashtable();
            var observableCollection = new ObservableCollection<string>();

            foreach (string port in SerialPort.GetPortNames())
            {
                hashtable.Add(port.Replace("USB", ""), port);

            }
            
            foreach(DictionaryEntry entry in hashtable)
            {
                observableCollection.Add((string)entry.Value);
                Debug.WriteLine((string)entry.Value);
            }

            

            ComPortComboBox.ItemsSource = observableCollection;
        }
    }
}
