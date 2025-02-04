using System.Net.Sockets;
using System.Text;
using Microsoft.VisualBasic;

namespace ClientGUI
{
    public partial class Form1 : Form
    {
        string hostName = "FRANKLIN-LAPTOP";
        int port = 16000;
        int bufferSize = 1024;
        TcpClient client;
        NetworkStream stream;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Enter name:");
            _Connect(name);
        }
        public void _Connect(string name)
        {
            client = new TcpClient(hostName, port);
            stream = client.GetStream();

            _SendMessage(name);
            //byte[] nameBytes = new byte[bufferSize];
            //nameBytes = Encoding.UTF8.GetBytes(name);

            //stream.Write(nameBytes, 0, nameBytes.Length);
            backgroundWorker1.RunWorkerAsync();
        }

        private void send_Click(object sender, EventArgs e)
        {
            string msg = formatBox.Text;
            formatBox.Text = String.Empty;
            _SendMessage(msg);
        }
        public void _SendMessage(string msg)
        {
            byte[] msgBytes = new byte[bufferSize];
            msgBytes = Encoding.UTF8.GetBytes(msg);
            stream.Write(msgBytes, 0, msgBytes.Length);
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                int msgLength = client.Available;

                if (msgLength > 0)
                {
                    while (msgLength > 0)
                    {
                        byte[] msgBytes = new byte[1024];
                        string msg = string.Empty;

                        client.GetStream().Read(msgBytes, 0, msgBytes.Length);
                        msg = Encoding.UTF8.GetString(msgBytes).Trim();
                        Invoke(new Action(() => displayBox.AppendText(msg)));

                        Thread.Sleep(100);
                    }
                }
            }
        }
        //private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        //{
        //    Interaction.MsgBox("scanning");
        //    while (true)
        //    {
        //        int msgLength = client.Available;

        //        if (msgLength > 0)
        //        {
        //            byte[] msgBytes = new byte[msgLength];
        //            string msg = string.Empty;

        //            client.GetStream().Read(msgBytes, 0, msgBytes.Length);
        //            msg = Encoding.UTF8.GetString(msgBytes);
        //            Interaction.MsgBox(msg);
        //            Invoke(new Action(() => displayBox.AppendText(msg + Environment.NewLine)));

        //            Thread.Sleep(100);
        //        }
        //    }
        //}

    }
}
