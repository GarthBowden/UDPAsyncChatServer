using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UDPAsynchronousChat;

namespace UDPAsyncChatServer
{
    public partial class Form1 : Form
    {
        UDPAsynchronousChatServer mServer;
        
        public Form1()
        {
            mServer = new UDPAsynchronousChatServer();
            mServer.RaiseTextUpdateEvent += TextLogDisplay;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mServer.StartReceivingData();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnSendBroadcast_Click(object sender, EventArgs e)
        {
            
        }

        delegate void TextLogDisplayCallback(object sender, TextUpdateEventArgs e);

        void TextLogDisplay(object sender, TextUpdateEventArgs e)
        {
            if (this.tbOutput.InvokeRequired)
            {
                TextLogDisplayCallback d = new TextLogDisplayCallback(TextLogDisplay);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                tbOutput.AppendText(e.Text + Environment.NewLine);
                Console.WriteLine(e.Text);
            }
        }
    }
}
