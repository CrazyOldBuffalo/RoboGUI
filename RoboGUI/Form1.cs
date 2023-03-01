using System.IO.Ports;
using System.Web;

namespace RoboGUI
{
    public partial class Form1 : Form
    {
        // Creation of 2 variable used throughout the form
        // Port opens a port to use with the serial
        // Thread is used by the text box for constantly updating
        SerialPort port;
        Thread thread;
        public Form1()
        {
            // Starts the form and disables buttons until port is Open
            InitializeComponent();
            btnForward.Enabled = false;
            BtnBack.Enabled = false;
            Rightbtn.Enabled = false;
            LeftBtn.Enabled = false;
            AutoModeOn_Btn.Enabled = false;
            AutoModeOff_Btn.Enabled = false;

            // Creates a new port on Serial COM5 with Baudrate of 9600 and Opens it
            if (port == null)
            {
                port = new SerialPort("COM5", 9600);
                port.Open();
            }
            // When port is open, start the Reading from the Serial
            // Activate keypreview for keyboard presses
            // Start an EventHandler for the Keyboard presses
            // Activate the buttons
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

        // Switch case for processing the keypresses
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
                    AutoModeOn_Btn.Enabled = false;
                    AutoModeOff_Btn.Enabled = true;
                    break;
                case Keys.H:
                    PortWrite("h");
                    AutoModeOn_Btn.Enabled = true;
                    AutoModeOff_Btn.Enabled = false;
                    break;
            }
        }

        // Starts a thread for reading the serial data coming from the zumo
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

        // Get the message from the started thread by reading
        // Append the message to the textbox and sleep to add a delay
        private void ReadData()
        {
            while (port.IsOpen)
            {
                string msg = port.ReadExisting();
                SerialTextLog(msg);

                Thread.Sleep(1000);
            }
        }

        // Delegate Invoking method for the Text
        private delegate void SerialTextLogDelegate(string msg);

        // Adds the text to the text box after creating a delegate and Invoking if this is needed from the text box
        // Scrolls the text box to the last typed data
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

        // Ignore
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // Writes the command received from the btnClick events or keypresses to the port for the zumo to receive
        private void PortWrite(string v)
        {
            if (port.IsOpen && port != null)
            {
                port.Write(v);
            }
        }

        // Write to the port with w for forward when the button is clicked
        private void btnForward_Click(object sender, EventArgs e)
        {
            if (port.IsOpen && port != null)
            {
                PortWrite("w");
            }
        }

        //Ignore
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Write to the port with a for left when the button is clicked
        private void LeftBtn_Click(object sender, EventArgs e)
        {
            if (port.IsOpen && port != null)
            {
                PortWrite("a");
            }
        }

        // ignore
        private void button1_Click(object sender, EventArgs e)
        {

        }

        // if backward button is clicked write s to the port for backwards
        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (port.IsOpen && port != null)
            {
                PortWrite("s");
            }
        }

        // Close the form and write x to the zumo to exit the code
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (port.IsOpen && port != null)
            {
                PortWrite("x");
                Form1_Close();
            }
        }

        // Write d to the zumo when the right button is clicked
        private void RightBtn_Click(object sender, EventArgs e)
        {
            if (port.IsOpen && port != null)
            {
                PortWrite("d");
            }
        }

        // close the port and the form
        private void Form1_Close()
        {
            port.Close();
            Close();
        }

        // ignore
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Write g to the Zumo to activate auto mode when the button is clicked
        // Disable the on button and activate the off button
        private void AutoModeOn_Btn_Click(object sender, EventArgs e)
        {
            PortWrite("g");
            AutoModeOn_Btn.Enabled = false;
            AutoModeOff_Btn.Enabled = true;
        }

        // Write h to the Zumo to de-activate auto mode when the button is clicked
        // Disable the off button and activate the on button
        private void AutoModeOff_Btn_Click(object sender, EventArgs e)
        {
            PortWrite("h");
            AutoModeOff_Btn.Enabled = false;
            AutoModeOn_Btn.Enabled = true;
        }
    }


}