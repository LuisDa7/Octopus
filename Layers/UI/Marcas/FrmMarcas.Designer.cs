namespace Octopus.Layers.UI.Marcas
{
    partial class FrmMarcas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarcas));
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCorregir = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblCorregir = new System.Windows.Forms.Label();
            this.lblCargadas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.AllowUserToAddRows = false;
            this.dgvMarcas.AllowUserToDeleteRows = false;
            this.dgvMarcas.AllowUserToResizeRows = false;
            this.dgvMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarcas.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvMarcas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMarcas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNombre,
            this.clmFecha,
            this.clmEntrada,
            this.clmSalida,
            this.clmCantHoras});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMarcas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMarcas.Location = new System.Drawing.Point(322, 54);
            this.dgvMarcas.MultiSelect = false;
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarcas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMarcas.RowHeadersVisible = false;
            this.dgvMarcas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(479, 491);
            this.dgvMarcas.TabIndex = 27;
            // 
            // clmNombre
            // 
            this.clmNombre.FillWeight = 97.77209F;
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmFecha
            // 
            this.clmFecha.FillWeight = 97.77209F;
            this.clmFecha.HeaderText = "Fecha ";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            // 
            // clmEntrada
            // 
            this.clmEntrada.FillWeight = 97.77209F;
            this.clmEntrada.HeaderText = "Entrada";
            this.clmEntrada.Name = "clmEntrada";
            this.clmEntrada.ReadOnly = true;
            // 
            // clmSalida
            // 
            this.clmSalida.FillWeight = 97.77209F;
            this.clmSalida.HeaderText = "Salida";
            this.clmSalida.Name = "clmSalida";
            this.clmSalida.ReadOnly = true;
            // 
            // clmCantHoras
            // 
            this.clmCantHoras.FillWeight = 44.19078F;
            this.clmCantHoras.HeaderText = "Cant. Horas";
            this.clmCantHoras.Name = "clmCantHoras";
            this.clmCantHoras.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumPurple;
            this.label5.Location = new System.Drawing.Point(345, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "Control De Marcas";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(803, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 34);
            this.btnCerrar.TabIndex = 33;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrarMant_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.IndianRed;
            this.btnBorrar.Enabled = false;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.Location = new System.Drawing.Point(108, 396);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(116, 111);
            this.btnBorrar.TabIndex = 44;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCorregir
            // 
            this.btnCorregir.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCorregir.Enabled = false;
            this.btnCorregir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCorregir.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorregir.ForeColor = System.Drawing.Color.White;
            this.btnCorregir.Image = ((System.Drawing.Image)(resources.GetObject("btnCorregir.Image")));
            this.btnCorregir.Location = new System.Drawing.Point(50, 251);
            this.btnCorregir.Name = "btnCorregir";
            this.btnCorregir.Size = new System.Drawing.Size(127, 123);
            this.btnCorregir.TabIndex = 43;
            this.btnCorregir.Text = "Corregir";
            this.btnCorregir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCorregir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCorregir.UseVisualStyleBackColor = false;
            this.btnCorregir.Click += new System.EventHandler(this.btnCorregir_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.Image")));
            this.btnCargar.Location = new System.Drawing.Point(136, 84);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(141, 144);
            this.btnCargar.TabIndex = 45;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblCorregir
            // 
            this.lblCorregir.AutoSize = true;
            this.lblCorregir.BackColor = System.Drawing.Color.Transparent;
            this.lblCorregir.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorregir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblCorregir.Location = new System.Drawing.Point(318, 32);
            this.lblCorregir.Name = "lblCorregir";
            this.lblCorregir.Size = new System.Drawing.Size(296, 19);
            this.lblCorregir.TabIndex = 46;
            this.lblCorregir.Text = "Parece que hay que corregir las marcas";
            this.lblCorregir.Visible = false;
            // 
            // lblCargadas
            // 
            this.lblCargadas.AutoSize = true;
            this.lblCargadas.BackColor = System.Drawing.Color.Transparent;
            this.lblCargadas.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCargadas.Location = new System.Drawing.Point(318, 32);
            this.lblCargadas.Name = "lblCargadas";
            this.lblCargadas.Size = new System.Drawing.Size(208, 19);
            this.lblCargadas.TabIndex = 47;
            this.lblCargadas.Text = "Las marcas están cargadas";
            this.lblCargadas.Visible = false;
            // 
            // FrmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(840, 560);
            this.Controls.Add(this.lblCargadas);
            this.Controls.Add(this.lblCorregir);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCorregir);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvMarcas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantHoras;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCorregir;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblCorregir;
        private System.Windows.Forms.Label lblCargadas;
    }
}