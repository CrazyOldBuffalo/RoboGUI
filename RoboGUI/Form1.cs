using System.IO.Ports;
using System.Web;

namespace RoboGUI
{
    public partial class Form1 : Form
    {
        SerialPort port;
        Thread thread;
        public Form1()
        {
            InitializeComponent();
            btnForward.Enabled = false;
            BtnBack.Enabled = false;
            Rightbtn.Enabled = false;
            LeftBtn.Enabled = false;
            AutoModeOn_Btn.Enabled = false;
            AutoModeOff_Btn.Enabled = false;

            if (port == null)
            {
                port = new SerialPort("COM5", 9600);
                port.Open();
            }
            if (port.IsOpen)
            {
                ReadSerialData();
                this.KeyPreview = true;
                this.KeyDown += new KeyEventHandler(Form1_KeyDown);
                LeftBtn.Enabled = true;
                Rightbtn.Enabled = true; 
                BtnBack.Enabled = true;
                btnForward.Enabled = true;
                AutoModeOn_Btn.Enabled = true;
            }

        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    PortWrite("w");
                    break;
                case Keys.S:
                    PortWrite("s");
                    break;
                case Keys.D:
                    PortWrite("d");
                    break;
                case Keys.A:
                    PortWrite("a");
                    break;
                case Keys.X:
                    PortWrite("x");
                    Form1_Close();
                    break;
                case Keys.G:
                    PortWrite("g");
                    break;
                case Keys.H:
                    PortWrite("h");
                    break;
            }
        }

        private void ReadSerialData()
        {
            try
            {
                thread = new Thread(ReadData);
                thread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void ReadData()
        {
            while (port.IsOpen)
            {
                string msg = port.ReadExisting();
                SerialTextLog(msg);

                Thread.Sleep(1000);
            }
        }

        private delegate void SerialTextLogDelegate(string msg);

        private void SerialTextLog(string msg)
        {
            if (SerialText.InvokeRequired)
            {
                SerialTextLogDelegate STLD = SerialTextLog;
                Invoke(STLD, msg);
            }
            else
            {
                SerialText.AppendText(Environment.NewLine + msg);
                SerialText.ScrollToCaret();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnForward_KeyDown(object sender, KeyEventArgs e)
        {
            if (port.IsOpen && port != null)
            {
                if (e.KeyCode == Keys.W)
                {
                    PortWrite("w");
                }

            }
        }

        private void PortWrite(string v)
        {
            if (port.IsOpen && port != null)
            {
                port.Write(v);
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (port.IsOpen && port != null)
            {
                PortWrite("w");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LeftBtn_Click(object sender, EventArgs e)
        {
            if (port.IsOpen && port != null)
            {
                PortWrite("a");
            }
        }

        private void LeftBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (port.IsOpen && port != null)
            {
                if (e.KeyCode == Keys.A)
                {
                    PortWrite("a");
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Rightbtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (port.IsOpen && port != null)
            {
                if (e.KeyCode == Keys.D)
                {
                    PortWrite("d");
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (port.IsOpen && port != null)
            {
                PortWrite("s");
            }
        }

        private void BtnBack_KeyDown(object sender, KeyEventArgs e)
        {
            if (!port.IsOpen && port != null)
            {
                if (e.KeyCode == Keys.S)
                {
                    PortWrite("s");
                }
            }
        }

        [Obsolete]
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (port.IsOpen && port != null)
            {
                PortWrite("x");
                Form1_Close();
            }
        }

        private void RightBtn_Click(object sender, EventArgs e)
        {
            if (port.IsOpen && port != null)
            {
                PortWrite("d");
            }
        }

        private void Form1_Close()
        {
            port.Close();
            Close();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AutoModeOn_Btn_Click(object sender, EventArgs e)
        {
            PortWrite("g");
            AutoModeOn_Btn.Enabled = false;
            AutoModeOff_Btn.Enabled = true;
        }

        private void AutoModeOff_Btn_Click(object sender, EventArgs e)
        {
            PortWrite("h");
            AutoModeOff_Btn.Enabled = false;
            AutoModeOn_Btn.Enabled = true;
        }
    }


}