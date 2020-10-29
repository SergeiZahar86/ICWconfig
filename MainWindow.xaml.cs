using System;
using System.Collections.Generic;
using System.IO;
using Thrift.Transport;
using Thrift.Protocol;
using System.Windows.Media;
using System.Windows.Media.Imaging;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ICWconfig
{
    public partial class MainWindow : Window
    {
        TTransport transport;
        public ICWService.Client client;
        public MainWindow()
        {
            this.transport = new TSocket("10.90.90.5", 9090);
            TProtocol proto = new TBinaryProtocol(transport);
            transport.Open();
            this.client = new ICWService.Client(proto);






            InitializeComponent();
            VideoLeft.Source = new Uri("rtsp://10.90.90.5/test.mp4");
            VideoLeft.Play();
        }
        private void StartAttestation_Click(object sender, RoutedEventArgs e)  // начала роботы
        {

        }
        private void change_Left(object sender, RoutedEventArgs e) // изменение координат (Слева)
        {

        }
        private void change_Right(object sender, RoutedEventArgs e) // изменение координат (Справа)
        {

        }


    }
}
