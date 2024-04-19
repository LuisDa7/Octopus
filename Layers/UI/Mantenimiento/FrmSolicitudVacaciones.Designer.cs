namespace Octopus.Layers.UI.Mantenimiento
{
    partial class FrmSolicitudVacaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSolicitudVacaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaSoli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmObserv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCerrarMant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.SuspendLayout();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumPurple;
            this.label5.Location = new System.Drawing.Point(55, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Solicitud de vacaciones";
            // 
            // dtpDesde
            // 
            this.dtpDesde.CalendarFont = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.CalendarMonthBackground = System.Drawing.Color.GhostWhite;
            this.dtpDesde.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Location = new System.Drawing.Point(25, 130);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(274, 33);
            this.dtpDesde.TabIndex = 17;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // dtpHasta
            // 
            this.dtpHasta.CalendarFont = new System.Drawing.Font("Roboto", 15.75F);
            this.dtpHasta.CalendarMonthBackground = System.Drawing.Color.GhostWhite;
            this.dtpHasta.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Location = new System.Drawing.Point(25, 230);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(274, 33);
            this.dtpHasta.TabIndex = 18;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(21, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(21, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fecha hasta";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(45, 394);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 110);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Green;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(171, 394);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 110);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(37, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cantidad de días";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.BackColor = System.Drawing.Color.Transparent;
            this.lblCant.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblCant.Location = new System.Drawing.Point(199, 292);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(19, 19);
            this.lblCant.TabIndex = 24;
            this.lblCant.Text = "0";
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.AllowUserToAddRows = false;
            this.dgvSolicitudes.AllowUserToDeleteRows = false;
            this.dgvSolicitudes.AllowUserToResizeRows = false;
            this.dgvSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSolicitudes.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvSolicitudes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmFechaSoli,
            this.clmFechaDesde,
            this.clmHasta,
            this.clmCantDias,
            this.clmObserv});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSolicitudes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSolicitudes.Location = new System.Drawing.Point(339, 90);
            this.dgvSolicitudes.MultiSelect = false;
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSolicitudes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSolicitudes.RowHeadersVisible = false;
            this.dgvSolicitudes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicitudes.Size = new System.Drawing.Size(474, 414);
            this.dgvSolicitudes.TabIndex = 25;
            this.dgvSolicitudes.SelectionChanged += new System.EventHandler(this.dgvSolicitudes_SelectionChanged);
            // 
            // clmID
            // 
            this.clmID.FillWeight = 60.91368F;
            this.clmID.HeaderText = "Código Solicitud";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            // 
            // clmFechaSoli
            // 
            this.clmFechaSoli.FillWeight = 117.9851F;
            this.clmFechaSoli.HeaderText = "Fecha Solicitud";
            this.clmFechaSoli.Name = "clmFechaSoli";
            this.clmFechaSoli.ReadOnly = true;
            // 
            // clmFechaDesde
            // 
            this.clmFechaDesde.FillWeight = 117.9851F;
            this.clmFechaDesde.HeaderText = "Desde";
            this.clmFechaDesde.Name = "clmFechaDesde";
            this.clmFechaDesde.ReadOnly = true;
            // 
            // clmHasta
            // 
            this.clmHasta.FillWeight = 117.9851F;
            this.clmHasta.HeaderText = "Hasta";
            this.clmHasta.Name = "clmHasta";
            this.clmHasta.ReadOnly = true;
            // 
            // clmCantDias
            // 
            this.clmCantDias.FillWeight = 66.6583F;
            this.clmCantDias.HeaderText = "Cant. Días";
            this.clmCantDias.Name = "clmCantDias";
            this.clmCantDias.ReadOnly = true;
            // 
            // clmObserv
            // 
            this.clmObserv.FillWeight = 118.4723F;
            this.clmObserv.HeaderText = "Observación";
            this.clmObserv.Name = "clmObserv";
            this.clmObserv.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumPurple;
            this.label4.Location = new System.Drawing.Point(392, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tus solicitudes";
            // 
            // btnCerrarMant
            // 
            this.btnCerrarMant.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarMant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarMant.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarMant.ForeColor = System.Drawing.Color.Black;
            this.btnCerrarMant.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarMant.Image")));
            this.btnCerrarMant.Location = new System.Drawing.Point(804, 1);
            this.btnCerrarMant.Name = "btnCerrarMant";
            this.btnCerrarMant.Size = new System.Drawing.Size(35, 34);
            this.btnCerrarMant.TabIndex = 27;
            this.btnCerrarMant.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrarMant.UseVisualStyleBackColor = false;
            this.btnCerrarMant.Click += new System.EventHandler(this.btnCerrarMant_Click);
            // 
            // FrmSolicitudVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(840, 560);
            this.Controls.Add(this.btnCerrarMant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvSolicitudes);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSolicitudVacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud de Vacaciones";
            this.Click += new System.EventHandler(this.FrmSolicitudVacaciones_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCerrarMant;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaSoli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmObserv;
    }
}