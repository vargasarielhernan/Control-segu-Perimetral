using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        SerialPort Port;
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
            CheckForIllegalCrossThreadCalls = false;

            //loop = new System.Windows.Forms.Timer();
            //loop.Interval = 1000;
            //loop.Tick += Loop_Tick;
            //loop.Start();


        }

        //private void Loop_Tick(object sender, EventArgs e)
        //{
        //    textBox1.Text += raspberry;
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string com in SerialPort.GetPortNames())
            {
                cmbComSelect.Items.Add(com);
                comListados.Add(com);

            }

        }
        //private void infoSerial()
        //{
        //    while (!isclosed)
        //    {
        //        try
        //        {
        //            if (Port.IsOpen)
        //            {
        //                string raspberry = Port.ReadExisting();
        //                textBox1.Invoke(new MethodInvoker(
        //                    delegate
        //                    {
        //                        textBox1.Text += raspberry;
        //                    }
        //                    ));

        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.ToString());
        //        }
        //    }
        //}
        //public void BufSerial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        //{
        //    SerialPort sp = (SerialPort)sender;
        //    string salida =sp.ReadLine();
        //    //string salida = Port.ReadLine();
        //    Form1_AccesoInterrupcion(salida);
        //    //Invoke(new UPDATE_DATOS(Form1_AccesoInterrupcion),salida);
        //}
        //public void Form1_AccesoForm(string accion)
        //{
        //    SerialBufferRx = accion;
        //    if (SerialBufferRx.Count() == 12)
        //    {
        //        textBox1.AppendText(SerialBufferRx);
        //        textBox1.Text = accion;
        //        mensajeProcesado = SerialBufferRx.Trim();

        //        BufferProcesar = mensajeProcesado.Split(',').ToList();

        //        sec = BufferProcesar[0];
        //        estado = BufferProcesar[1];
        //        nodo = BufferProcesar[2];
        //        zona = BufferProcesar[3];
        //        llenarDropDown(sec,estado,nodo,zona);
        //    }

        //}
        //public delegate void UPDATE_DATOS(String Salida);
        //public delegate void DelegadoAcceso(String salida);
        ////Metodo para leer los datos que tira el
        //private void Form1_AccesoInterrupcion(string accion)
        //{
        //    //Creamos una variable delegado que te permita llegar al Form
        //    DelegadoAcceso Accediendo;
        //    Accediendo = new DelegadoAcceso(Form1_AccesoForm);
        //    //Objeto que permita pasar los datos.
        //    object[] arg = { accion };
        //    base.Invoke(Accediendo, arg);
        //}
        //private void btnCargar_Click(object sender, EventArgs e)
        //{
        //    if (Port.IsOpen)
        //    {
        //        Port.DataReceived += new SerialDataReceivedEventHandler(BufSerial_DataReceived);
        //    }
        //}
        //private void llenarDropDown(string sec, string estado, string nodo, string zona)
        //{
        //        int n = dgvDatosChip.Rows.Add();
        //        dgvDatosChip.Rows[n].Cells[0].Value = DateTime.Now;
        //        dgvDatosChip.Rows[n].Cells[3].Value = sec;
        //        dgvDatosChip.Rows[n].Cells[4].Value = estado;
        //        dgvDatosChip.Rows[n].Cells[5].Value = nodo;
        //        dgvDatosChip.Rows[n].Cells[6].Value = zona;
        //}
        //private void EscucharSerial()
        //{
        //    while (IsOpen)
        //    {
        //        try
        //        {
        //            string datosChip = Port.ReadLine();
        //            if (!string.IsNullOrEmpty(datosChip))
        //            {
        //                textBox1.Invoke(new MethodInvoker(
        //                delegate
        //                {
        //                    int n = dgvDatosChip.Rows.Add();
        //                    dgvDatosChip.Rows[n].Cells[0].Value = DateTime.Now;
        //                    dgvDatosChip.Rows[n].Cells[1].Value = datosChip;
        //                    textBox1.Text = datosChip;
        //                }
        //                ));

        //            }
        //        }
        //        catch (Exception ex)
        //        {

        //            MessageBox.Show(ex.Message.ToString());
        //        }
        //    }
        //}
        //Evento para una vez cerrado el programa se cierre el puerto
        
        private void cmbComSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionCOM = comListados[cmbComSelect.SelectedIndex];
            cfgSerial_Config(selectionCOM);
        }
        private void cfgSerial_Config(string selectionCOM)
        {
            Port = new System.IO.Ports.SerialPort();
            Port.PortName = selectionCOM;
            //Port = new SerialPort("COM5");
            Port.BaudRate = 9600;
            Port.Parity = Parity.None;
            //Port.ReceivedBytesThreshold = 1;
            Port.DataBits = 8;
            Port.StopBits = StopBits.One;
            Port.RtsEnable = true;
            //Port.WriteTimeout = 300;
            //Port.ReadTimeout = 3000;
            //Port.Handshake = Handshake.None;
        }
        
        private void PaneldeControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Port.IsOpen)
            {
                Port.Close();
            }
        }
        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            raspberry = Port.ReadLine();
            mostrardatos(raspberry);
            //this.Invoke(new EventHandler(info));
            //string[] substring = raspberry.Split(',');
            //if (substring.Length == 4)
            //{
            //    nodos.Tiempo = DateTime.Now;
            //    nodos.Seccion = substring[0];
            //    nodos.State = substring[1];
            //    nodos.Node = substring[2];
            //    nodos.Zone = substring[3];
            //}
        }
        private void mostrardatos(string datos)
        {
            // Este método muestra los datos recibidos en el TextBox
            if (InvokeRequired)
            {
                Invoke(new Action<string>(mostrardatos), datos);
            }
            else
            {
                textBox1.AppendText(datos + Environment.NewLine); // Agregar los datos al TextBox
            }
        }
        //private void info(object sender, EventArgs e)
        //{
        //    textBox1.AppendText(raspberry);
        //}

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
                //Thread hilo = new Thread(infoSerial);
                //hilo.Start();
                try
                {
                    Port.Open();
                    btnConectar.Text = "Desconectar";
                    Port.DataReceived += Port_DataReceived;
                    //if (Port.IsOpen)
                    //{
                    //    Port.DataReceived += new SerialDataReceivedEventHandler(BufSerial_DataReceived);
                    //}
                    //llenarDropDown();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                //if (Port.IsOpen)
                //{
                //    btnNodo1_RST.Enabled = true;
                //    btnSerial_Enviar.Enabled = true;

                //    btnSerial_Conectar.Text = "Desconectar";
                //    lblSerial_Status.BackColor = Color.Green;
                //    EstablecerZonas();
                //}
            }
            else if (btnConectar.Text == "Desconectar" && Port.IsOpen)
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
                        Port.Close();
                        btnConectar.Text = "Conectar";
                    }
                    catch { }
                }

            }

        }

    }
}
