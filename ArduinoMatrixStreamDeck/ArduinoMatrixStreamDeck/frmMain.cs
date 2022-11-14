using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoMatrixStreamDeck
{
    public partial class frmMain : Form
    {
        string TeclaPresionada = "";
        public frmMain()
        {
            InitializeComponent();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (serialPort1.BytesToRead > 0)
            {
                try
                {
                    // El texto recibido debe tener un formato de variable:valor\n
                    string TextoRecibido = serialPort1.ReadLine();
                    if (TextoRecibido.Length > 0)
                    {
                        string[] TextoSegmentado = TextoRecibido.Split(':','\r');
                        // TextoSegmentado para el ejemplo de formato quedaría así:
                        //       TextoSegmentado[0] = "Tecla"
                        //       TextoSegmentado[1] = "A"
                        //       TextoSegmentado[2] = ""

                        if (TextoSegmentado.Length == 3)
                        {
                            string NombreVariable = TextoSegmentado[0];
                            string ValorVariable = TextoSegmentado[1];

                            if (NombreVariable == "ZizouKey")
                            {
                                TeclaPresionada = ValorVariable;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Open();
                    if (!serialPort1.IsOpen)
                    {
                        MessageBox.Show("No se logró estable cer comunicación con la báscula en el puerto " +
                            serialPort1.PortName);
                        this.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se logró establecer comunicación con la báscula en el puerto " +
                        serialPort1.PortName + "\nDetalles:\n" + ex.Message);
                    this.Dispose();
                }  
            }
            else
            {
                MessageBox.Show("El pruerto " + serialPort1.PortName +
                        " ya se encuentra abierto por otra aplicación.");
                this.Dispose();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (TeclaPresionada != "")
            {
                switch (TeclaPresionada)
                {
                    case "0":
                        checkBox0.Checked = true;
                        SendKeys.SendWait("^%+0");
                        break;
                    case "1":
                        checkBox1.Checked = true;
                        SendKeys.SendWait("^%+1");
                        break;
                    case "2":
                        checkBox2.Checked = true;
                        SendKeys.SendWait("^%+2");
                        break;
                    case "3":
                        checkBox3.Checked = true;
                        SendKeys.SendWait("^%+3");
                        break;
                    case "4":
                        checkBox4.Checked = true;
                        SendKeys.SendWait("^%+4");
                        break;
                    case "5":
                        checkBox5.Checked = true;
                        SendKeys.SendWait("^%+5");
                        break;
                    case "6":
                        checkBox6.Checked = true;
                        SendKeys.SendWait("^%+6");
                        break;
                    case "7":
                        checkBox7.Checked = true;
                        SendKeys.SendWait("^%+7");
                        break;
                    case "8":
                        checkBox8.Checked = true;
                        SendKeys.SendWait("^%+8");
                        break;
                    case "9":
                        checkBox9.Checked = true;
                        SendKeys.SendWait("^%+9");
                        break;
                    case "A":
                        checkBoxA.Checked = true;
                        SendKeys.SendWait("^%{F5}");
                        break;
                    case "B":
                        checkBoxB.Checked = true;
                        SendKeys.SendWait("^%{F6}");
                        break;
                    case "C":
                        checkBoxC.Checked = true;
                        SendKeys.SendWait("^%{F7}");
                        break;
                    case "D":
                        checkBoxD.Checked = true;
                        SendKeys.SendWait("^%{F8}");
                        break;
                    case "*":
                        chkAsterisco.Checked = true;
                        SendKeys.SendWait("^%{F9}");
                        break;
                    case "#":
                        chkNumeral.Checked = true;
                        SendKeys.SendWait("^%+#");
                        break;
                    default:
                        break;
                }
                TeclaPresionada = "";
                tmrClearScreen.Start();
            }
            timer1.Enabled = true;
        }

        private void tmrClearScreen_Tick(object sender, EventArgs e)
        {
            foreach (Control cntrl in tableLayoutPanel1.Controls)
            {
                if (cntrl is CheckBox)
                {
                    ((CheckBox)cntrl).Checked = false;
                }
            }
            tmrClearScreen.Stop();
        }
    }
}
