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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ImagenPerimetro = new System.Windows.Forms.PictureBox();
            this.PanelDeNodos = new System.Windows.Forms.Panel();
            this.lblNodos = new System.Windows.Forms.Label();
            this.Port = new System.IO.Ports.SerialPort(this.components);
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
            this.btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPerimetro)).BeginInit();
            this.PanelDeNodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosChip)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblTitulo.Location = new System.Drawing.Point(566, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(133, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Securec";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImagenPerimetro
            // 
            this.ImagenPerimetro.Location = new System.Drawing.Point(261, 79);
            this.ImagenPerimetro.Name = "ImagenPerimetro";
            this.ImagenPerimetro.Size = new System.Drawing.Size(900, 602);
            this.ImagenPerimetro.TabIndex = 1;
            this.ImagenPerimetro.TabStop = false;
            // 
            // PanelDeNodos
            // 
            this.PanelDeNodos.Controls.Add(this.lblNodos);
            this.PanelDeNodos.Location = new System.Drawing.Point(13, 79);
            this.PanelDeNodos.Name = "PanelDeNodos";
            this.PanelDeNodos.Size = new System.Drawing.Size(242, 602);
            this.PanelDeNodos.TabIndex = 2;
            // 
            // lblNodos
            // 
            this.lblNodos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNodos.AutoSize = true;
            this.lblNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblNodos.Location = new System.Drawing.Point(58, 4);
            this.lblNodos.Name = "lblNodos";
            this.lblNodos.Size = new System.Drawing.Size(85, 29);
            this.lblNodos.TabIndex = 0;
            this.lblNodos.Text = "Nodos";
            // 
            // Port
            // 
            this.Port.PortName = "COM5";
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
            this.dgvDatosChip.Location = new System.Drawing.Point(261, 690);
            this.dgvDatosChip.Name = "dgvDatosChip";
            this.dgvDatosChip.Size = new System.Drawing.Size(900, 150);
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
            this.cmbComSelect.Location = new System.Drawing.Point(13, 24);
            this.cmbComSelect.Name = "cmbComSelect";
            this.cmbComSelect.Size = new System.Drawing.Size(121, 21);
            this.cmbComSelect.TabIndex = 4;
            this.cmbComSelect.Text = "Seleccionar COM";
            this.cmbComSelect.DropDown += new System.EventHandler(this.cmbComSelect_DropDown);
            this.cmbComSelect.SelectedIndexChanged += new System.EventHandler(this.cmbComSelect_SelectedIndexChanged);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(141, 22);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 6;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(261, 51);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // PaneldeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 852);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.cmbComSelect);
            this.Controls.Add(this.dgvDatosChip);
            this.Controls.Add(this.PanelDeNodos);
            this.Controls.Add(this.ImagenPerimetro);
            this.Controls.Add(this.lblTitulo);
            this.Name = "PaneldeControl";
            this.Text = "Seguridad Perimetral";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PaneldeControl_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPerimetro)).EndInit();
            this.PanelDeNodos.ResumeLayout(false);
            this.PanelDeNodos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosChip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox ImagenPerimetro;
        private System.Windows.Forms.Panel PanelDeNodos;
        private System.Windows.Forms.Label lblNodos;
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
        private System.Windows.Forms.Button btnCargar;
    }
}

