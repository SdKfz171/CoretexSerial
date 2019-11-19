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
using System.Windows.Threading;

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

        private int Baudrate;

        private List<Packet> packets;
        public MainWindow()
        {
            InitializeComponent();

            packets = new List<Packet>();
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

            Baudrate = int.Parse(SelectedValue);

        }

        private void ComPortComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ComPortName = ComPortComboBox.SelectedItem.ToString();
            }
            catch (NullReferenceException nre)
            {
                ComPortComboBox.SelectedIndex = 0;
            }
        }


        private string GetHexString(string char_string)
        {
            string hex = string.Empty;
            byte[] bytes = Encoding.Default.GetBytes(char_string);

            foreach (byte data in bytes)
                hex += string.Format("{0:X2}", data) + " ";

            return hex;
        }

        private string ConvertHexToCharString(string hex_string)
        {
            string str = string.Empty;

            string[] splitted_hex_string = hex_string.Split(' ');
            foreach (string hex in splitted_hex_string)
            {
                if (hex == string.Empty)
                    break;

                int value = Convert.ToInt32(hex, 16);
                string stringValue = Char.ConvertFromUtf32(value);
                str += stringValue;
            }

            return str;
        }

        private void HexButton_Checked(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
            {
                if (MainTextBox != null)
                {
                    MainTextBox.Clear();

                    foreach (var packet in packets)
                    {
                        string hex = GetHexString(packet.message);   

                        if (packet.type == true && RecieveStringNoti.IsChecked == true)      // receive
                        {
                            MainTextBox.Text += " <<< " + hex;
                        }
                        else if (packet.type == false && SendStringNoti.IsChecked == true)   // send
                        {
                            MainTextBox.Text += " >>> " + hex;
                        }
                        MainTextBox.Text += Environment.NewLine;
                    }
                }
                if(Transmit_box != null)
                {
                    string prev_string = Transmit_box.Text;
                    Transmit_box.Clear();
                    Transmit_box.Text = GetHexString(prev_string);
                }
            }));
        }

        private void AsciiButton_Checked(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
            {
                if(MainTextBox != null)
                {
                    MainTextBox.Clear();

                    foreach (var packet in packets)
                    {
                        if (packet.type == true && RecieveStringNoti.IsChecked == true)      // receive
                        {
                            MainTextBox.Text += " <<< " + packet.message;
                        }
                        else if (packet.type == false && SendStringNoti.IsChecked == true)   // send
                        {
                            MainTextBox.Text += " >>> " + packet.message;
                        }
                        MainTextBox.Text += Environment.NewLine;
                    }
                }
                if (Transmit_box != null)
                {
                    string prev_string = Transmit_box.Text;
                    Transmit_box.Clear();
                    Transmit_box.Text = ConvertHexToCharString(prev_string);
                }
            }));
        }

        private void SendStringNoti_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RecieveStringNoti_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ComPortComboBox_DropDownOpened(object sender, EventArgs e)
        {
            Debug.WriteLine("Clicked");

            string[] AvailablePorts = SerialPort.GetPortNames();

            ComPortComboBox.Items.Clear();

            foreach (var data in AvailablePorts)
            {
                if (!GetOpenedPortNames().Contains(data))
                {
                    Debug.WriteLine("Available Port : " + data);
                    ComPortComboBox.Items.Add(data);
                }
            }
        }
        private List<string> GetOpenedPortNames()
        {
            List<string> list = new List<string>();

            foreach (var data in SerialPort.GetPortNames())
            {
                try
                {
                    SerialPort testSerial = new SerialPort(data);

                    testSerial.Open();

                    testSerial.Close();
                }
                catch
                {
                    Debug.WriteLine("Not Available Port : " + data);

                    list.Add(data);
                }
            }

            return list;
        }

        private void Connect_Button_Click(object sender, RoutedEventArgs e)
        {
            if(ComPortName != string.Empty && Baudrate > 0)
            {
                serial = new SerialPort();
                serial.BaudRate = Baudrate;
                serial.DataBits = 8;
                serial.StopBits = StopBits.One;
                serial.Parity = Parity.None;
                serial.PortName = ComPortName;

                serial.Open();

                serial.DataReceived += Serial_DataReceived;
                
                Debug.WriteLine("serial open succeed");
            }
        }

        private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string received_data = serial.ReadLine();
            packets.Add(new Packet { type = true, message = received_data });

            if (RecieveStringNoti.IsChecked == true)
            {
                Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
                {
                    if (HexButton.IsChecked == true)
                        MainTextBox.Text += " <<< " + GetHexString(packets.Last().message);
                    else
                        MainTextBox.Text += " <<< " + packets.Last().message;

                    MainTextBox.Text += Environment.NewLine;
                }));
            }
        }

        private void Send_Button_Click(object sender, RoutedEventArgs e)
        {
            string transmit_message = Transmit_box.Text;

            if(HexButton.IsChecked == true)
            {
                string[] splitted_hex_string = transmit_message.Split(' ');

                if (splitted_hex_string.Last() == string.Empty)
                    splitted_hex_string = splitted_hex_string.Take(splitted_hex_string.Length - 1).ToArray();

                byte[] bytes = splitted_hex_string.Select(byte.Parse).ToArray();

                serial.Write(bytes, 0, bytes.Length);
                serial.WriteLine("");

                foreach(var data in bytes)
                {
                    Debug.Write(data + " ");
                }
                Debug.WriteLine("");

                transmit_message = ConvertHexToCharString(transmit_message);
            }
            else
                serial.WriteLine(transmit_message);

            packets.Add(new Packet { type = false, message = transmit_message });

            if (SendStringNoti.IsChecked == true)
            {
                Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
                {   
                    if(HexButton.IsChecked == true)
                        MainTextBox.Text += " >>> " + GetHexString(packets.Last().message);
                    else
                        MainTextBox.Text += " >>> " + packets.Last().message;
                    
                    MainTextBox.Text += Environment.NewLine;
                }));
            }
        }

        private void SendStringNoti_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void RecieveStringNoti_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }
}
