using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version2
{
    public partial class PaneldeControl : Form
    {
        //System.IO.Ports.SerialPort Port;

        //string SerialBufferRx;


        // System.Windows.Forms.Timer loop;
        List<string> comListados;
        string selectionCOM;
        //List<string> BufferProcesar = new List<string>();
        string raspberry;
        bool isclosed = false;
        //string mensajeProcesado;
        //string sec;
        //string zona;
        //string nodo;
        //string estado;
        public PaneldeControl()
        {
            comListados = new List<string>();
            InitializeComponent();
        }
        //public PaneldeControl(Users user)
        //{
        //    ImagenPerimetro.Image = Image.FromStream(ByteImage(user));

        //}
        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (string com in SerialPort.GetPortNames())
            {
                cmbComSelect.Items.Add(com);
                comListados.Add(com);

            }

        }
        //Evento para una vez cerrado el programa se cierre el puerto        
        private void cmbComSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionCOM = comListados[cmbComSelect.SelectedIndex];
            cfgSerial_Config(selectionCOM);
        }
        private void cfgSerial_Config(string selectionCOM)
        {
            serialPort = new System.IO.Ports.SerialPort();
            serialPort.PortName = selectionCOM;
            //Port = new SerialPort("COM5");
            serialPort.BaudRate = 9600;
            serialPort.Parity = Parity.None;
            //Port.ReceivedBytesThreshold = 1;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.RtsEnable = true;
            //Port.WriteTimeout = 300;
            //Port.ReadTimeout = 3000;
            //Port.Handshake = Handshake.None;
        }

        private void PaneldeControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void cmbComSelect_DropDown(object sender, EventArgs e)
        {
            cmbComSelect.Items.Clear();
            try
            {
                foreach (string com in SerialPort.GetPortNames())
                {
                    cmbComSelect.Items.Add(com);
                    comListados.Add(com);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (selectionCOM == null)
            {
                MessageBox.Show("Seleccione Un Puerto");
                return;
            }
            if (btnConectar.Text == "Conectar")
            {
                try
                {
                    serialPort.Open();
                    btnConectar.Text = "Desconectar";
                    //if (Port.IsOpen)
                    //{
                    serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else if (btnConectar.Text == "Desconectar" && serialPort.IsOpen)
            {
                MessageBox.Show("Cuidado Dejara el Sistema sin Comunicaion");
                MessageBoxButtons msgSerial_Desconectar = MessageBoxButtons.YesNoCancel;
                string message = "Está seguro que Desea Desconectar el Sistema";
                string caption = "Desconexion del Sistema";
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, msgSerial_Desconectar);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        serialPort.Close();
                        btnConectar.Text = "Conectar";
                    }
                    catch { }
                }

            }

        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (serialPort.IsOpen && serialPort.BytesToRead > 0)
            {
                string serialData = serialPort.ReadLine();
                textBox1.Invoke((MethodInvoker)(() =>
                {
                    textBox1.Text = serialData;
                }));
            }
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {

        }
        //bool navExpandir = true;
        //private void timerNav_Tick(object sender, EventArgs e)
        //{
        //    if(navExpandir)
        //    {
        //        flowLayoutPanelMenu.Height -= 10;
        //        if(flowLayoutPanelMenu.Height >= 1038)
        //        {
        //            timerNav.Stop();
        //            navExpandir = false;
        //        }
        //        else
        //        {
        //            flowLayoutPanelMenu.Height += 10;
        //            if(flowLayoutPanelMenu.Height <= 0)
        //            {
        //                timerNav.Stop();
        //                navExpandir=true;
        //            }

        //        }
        //    }
        //}
        bool verNav = true;
        private void pbxMenu_Click(object sender, EventArgs e)
        {
            if (verNav)
            {
                flowLayoutPanelMenu.Show();
                verNav=false;
            }
            else{
                flowLayoutPanelMenu.Hide();
                verNav = true;
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //private byte[] ConvertirImg()
        //{
        //    System.IO.MemoryStream ms = new System.IO.MemoryStream();
        //    ImagenPerimetro.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        //    return ms.GetBuffer();
        //}
        //private MemoryStream ByteImage(Users user)
        //{
        //    byte[] img = (byte[])user.Imagen;
        //    MemoryStream ms = new MemoryStream(img);
        //    return ms;
        //}
    }
}
