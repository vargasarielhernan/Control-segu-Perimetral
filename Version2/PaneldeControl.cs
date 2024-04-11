using AccesoDB;
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
        public Thread ReadSerialDataThread;
        public string readserialvalue;
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
            InitializeComponent();
            pConfUsuario.Hide();
            comListados = new List<string>();
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
            serialPort.BaudRate = 115200;
            serialPort.Parity = Parity.None;
            serialPort.ReceivedBytesThreshold = 1;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.RtsEnable = true;
            serialPort.WriteTimeout = 300;
            serialPort.ReadTimeout = 3000;
            serialPort.Handshake = Handshake.None;
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
                    if (serialPort.IsOpen)
                    {
                        ReadSerialData();
                    //serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
                    }
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
        private void ReadSerialData()
        {
            try
            {
                ReadSerialDataThread = new Thread(ReadSerial);
                ReadSerialDataThread.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo leer serial" + e.Message);
                throw;
            }
        }
        private void ReadSerial()
        {
            while(serialPort.IsOpen)
            {
                readserialvalue = serialPort.ReadLine();
                ShowSerialData(readserialvalue);

                //Thread.Sleep(1000);
            }
        }
        public delegate void ShowSerialDatadelegate(string r);
        private void ShowSerialData(string s)
        {
            if (textBox1.InvokeRequired)
            {
                ShowSerialDatadelegate SSDD = ShowSerialData;
                Invoke(SSDD, s);
            }
            else
            {
                textBox1.AppendText(Environment.NewLine + s);
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
            pConfUsuario.Visible = true;
            pConfUsuario.Focus();
            btnUsuario.BackColor = Color.White;
            btnUsuario.ForeColor = Color.Black;
            pConfUsuario.LostFocus += PConfUsuario_LostFocus;
            Users users = new Users();
            AccesoUsuarios us = new AccesoUsuarios();
            users = us.CargarUsuario(Login.IDUsuarioLog);
            txtNombre.Text = users.Name;
            txtContraseña.Text = users.Password;
            txtRol.Text = users.Rol.ToString();

        }

        private void PConfUsuario_LostFocus(object sender, EventArgs e)
        {
            pConfUsuario.Visible = false;
            btnUsuario.BackColor = Color.FromArgb(23, 24, 29);
            btnUsuario.ForeColor = Color.White;
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
                verNav = false;
            }
            else
            {
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
        //private void btnUpload_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFileDialog1 = new OpenFileDialog();
        //    openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif";
        //    openFileDialog1.Title = "Seleccionar imagen";

        //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        try
        //        {
        //            // Mostrar la imagen seleccionada en el PictureBox
        //            pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error al cargar la imagen: " + ex.Message);
        //        }
        //    }
        //}

        //private void btnSaveToDatabase_Click(object sender, EventArgs e)
        //{
        //    if (pictureBox1.Image == null)
        //    {
        //        MessageBox.Show("Por favor, selecciona una imagen primero.");
        //        return;
        //    }

        //    try
        //    {
        //        // Convertir la imagen en un arreglo de bytes
        //        byte[] imageBytes;
        //        using (MemoryStream stream = new MemoryStream())
        //        {
        //            pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
        //            imageBytes = stream.ToArray();
        //        }

        //    }
        //}
    }
}
