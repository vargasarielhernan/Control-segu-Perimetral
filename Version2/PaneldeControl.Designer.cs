namespace Version2
{
    partial class PaneldeControl
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaneldeControl));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ImagenPerimetro = new System.Windows.Forms.PictureBox();
            this.dgvDatosChip = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Node = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbComSelect = new System.Windows.Forms.ComboBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.btnUsers = new System.Windows.Forms.Button();
            this.NavBar = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.pbxMenu = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.panelNodos = new System.Windows.Forms.Panel();
            this.btnNodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPerimetro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosChip)).BeginInit();
            this.NavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu)).BeginInit();
            this.flowLayoutPanelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelNodos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblTitulo.Location = new System.Drawing.Point(41, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(133, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Securec";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImagenPerimetro
            // 
            this.ImagenPerimetro.Image = ((System.Drawing.Image)(resources.GetObject("ImagenPerimetro.Image")));
            this.ImagenPerimetro.Location = new System.Drawing.Point(992, 79);
            this.ImagenPerimetro.MinimumSize = new System.Drawing.Size(905, 602);
            this.ImagenPerimetro.Name = "ImagenPerimetro";
            this.ImagenPerimetro.Size = new System.Drawing.Size(905, 602);
            this.ImagenPerimetro.TabIndex = 1;
            this.ImagenPerimetro.TabStop = false;
            // 
            // dgvDatosChip
            // 
            this.dgvDatosChip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosChip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Empresa,
            this.Lugar,
            this.Seccion,
            this.State,
            this.Node,
            this.Zone});
            this.dgvDatosChip.Location = new System.Drawing.Point(261, 113);
            this.dgvDatosChip.Name = "dgvDatosChip";
            this.dgvDatosChip.Size = new System.Drawing.Size(725, 602);
            this.dgvDatosChip.TabIndex = 3;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            // 
            // Lugar
            // 
            this.Lugar.HeaderText = "Lugar";
            this.Lugar.Name = "Lugar";
            // 
            // Seccion
            // 
            this.Seccion.HeaderText = "Seccion";
            this.Seccion.Name = "Seccion";
            // 
            // State
            // 
            this.State.HeaderText = "State";
            this.State.Name = "State";
            // 
            // Node
            // 
            this.Node.HeaderText = "Node";
            this.Node.Name = "Node";
            // 
            // Zone
            // 
            this.Zone.HeaderText = "Zone";
            this.Zone.Name = "Zone";
            // 
            // cmbComSelect
            // 
            this.cmbComSelect.FormattingEnabled = true;
            this.cmbComSelect.Location = new System.Drawing.Point(640, 56);
            this.cmbComSelect.Name = "cmbComSelect";
            this.cmbComSelect.Size = new System.Drawing.Size(121, 21);
            this.cmbComSelect.TabIndex = 4;
            this.cmbComSelect.Text = "Seleccionar COM";
            this.cmbComSelect.DropDown += new System.EventHandler(this.cmbComSelect_DropDown);
            this.cmbComSelect.SelectedIndexChanged += new System.EventHandler(this.cmbComSelect_SelectedIndexChanged);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(838, 56);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 49);
            this.textBox1.TabIndex = 6;
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.PortName = "COM5";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(640, 84);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(122, 23);
            this.btnUsers.TabIndex = 7;
            this.btnUsers.Text = "Configuracion Usuario";
            this.btnUsers.UseVisualStyleBackColor = true;
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.White;
            this.NavBar.Controls.Add(this.btnX);
            this.NavBar.Controls.Add(this.pbxMenu);
            this.NavBar.Controls.Add(this.lblTitulo);
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(1918, 40);
            this.NavBar.TabIndex = 8;
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(975, 13);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(75, 23);
            this.btnX.TabIndex = 10;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // pbxMenu
            // 
            this.pbxMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbxMenu.Image")));
            this.pbxMenu.InitialImage = null;
            this.pbxMenu.Location = new System.Drawing.Point(3, 5);
            this.pbxMenu.Name = "pbxMenu";
            this.pbxMenu.Size = new System.Drawing.Size(32, 32);
            this.pbxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxMenu.TabIndex = 9;
            this.pbxMenu.TabStop = false;
            this.pbxMenu.Click += new System.EventHandler(this.pbxMenu_Click);
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.flowLayoutPanelMenu.Controls.Add(this.panel1);
            this.flowLayoutPanelMenu.Controls.Add(this.panelNodos);
            this.flowLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanelMenu.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(200, 1038);
            this.flowLayoutPanelMenu.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnUsuario);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 40);
            this.panel1.TabIndex = 10;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Location = new System.Drawing.Point(-35, -7);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(248, 62);
            this.btnUsuario.TabIndex = 11;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // panelNodos
            // 
            this.panelNodos.BackColor = System.Drawing.SystemColors.Control;
            this.panelNodos.Controls.Add(this.btnNodo);
            this.panelNodos.Location = new System.Drawing.Point(3, 49);
            this.panelNodos.Name = "panelNodos";
            this.panelNodos.Size = new System.Drawing.Size(200, 40);
            this.panelNodos.TabIndex = 12;
            // 
            // btnNodo
            // 
            this.btnNodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnNodo.FlatAppearance.BorderSize = 0;
            this.btnNodo.ForeColor = System.Drawing.Color.White;
            this.btnNodo.Location = new System.Drawing.Point(-35, -10);
            this.btnNodo.Name = "btnNodo";
            this.btnNodo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnNodo.Size = new System.Drawing.Size(248, 62);
            this.btnNodo.TabIndex = 11;
            this.btnNodo.Text = "Nodos";
            this.btnNodo.UseVisualStyleBackColor = false;
            // 
            // PaneldeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 1078);
            this.Controls.Add(this.flowLayoutPanelMenu);
            this.Controls.Add(this.NavBar);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.cmbComSelect);
            this.Controls.Add(this.dgvDatosChip);
            this.Controls.Add(this.ImagenPerimetro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1918, 1078);
            this.Name = "PaneldeControl";
            this.Text = "Seguridad Perimetral";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PaneldeControl_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPerimetro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosChip)).EndInit();
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu)).EndInit();
            this.flowLayoutPanelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelNodos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox ImagenPerimetro;
        private System.Windows.Forms.DataGridView dgvDatosChip;
        private System.Windows.Forms.ComboBox cmbComSelect;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox textBox1;
        //private System.IO.Ports.SerialPort Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Node;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zone;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.PictureBox pbxMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Panel panelNodos;
        private System.Windows.Forms.Button btnNodo;
        private System.Windows.Forms.Button btnX;
    }
}

