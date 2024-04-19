namespace Octopus.Layers.UI.Mantenimiento
{
    partial class FrmRevisarSolicitudes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRevisarSolicitudes));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmColab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaSoli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmObserv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrarMant = new System.Windows.Forms.Button();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
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
            this.clmColab,
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
            this.dgvSolicitudes.Location = new System.Drawing.Point(71, 48);
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
            this.dgvSolicitudes.Size = new System.Drawing.Size(699, 363);
            this.dgvSolicitudes.TabIndex = 26;
            this.dgvSolicitudes.SelectionChanged += new System.EventHandler(this.dgvSolicitudes_SelectionChanged);
            // 
            // clmID
            // 
            this.clmID.FillWeight = 53.2995F;
            this.clmID.HeaderText = "Código Solicitud";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            // 
            // clmColab
            // 
            this.clmColab.FillWeight = 187.4494F;
            this.clmColab.HeaderText = "Colaborador";
            this.clmColab.Name = "clmColab";
            this.clmColab.ReadOnly = true;
            // 
            // clmFechaSoli
            // 
            this.clmFechaSoli.FillWeight = 91.85021F;
            this.clmFechaSoli.HeaderText = "Fecha Solicitud";
            this.clmFechaSoli.Name = "clmFechaSoli";
            this.clmFechaSoli.ReadOnly = true;
            // 
            // clmFechaDesde
            // 
            this.clmFechaDesde.FillWeight = 91.85021F;
            this.clmFechaDesde.HeaderText = "Desde";
            this.clmFechaDesde.Name = "clmFechaDesde";
            this.clmFechaDesde.ReadOnly = true;
            // 
            // clmHasta
            // 
            this.clmHasta.FillWeight = 91.85021F;
            this.clmHasta.HeaderText = "Hasta";
            this.clmHasta.Name = "clmHasta";
            this.clmHasta.ReadOnly = true;
            // 
            // clmCantDias
            // 
            this.clmCantDias.FillWeight = 91.85021F;
            this.clmCantDias.HeaderText = "Cantidad Días";
            this.clmCantDias.Name = "clmCantDias";
            this.clmCantDias.ReadOnly = true;
            // 
            // clmObserv
            // 
            this.clmObserv.FillWeight = 91.85021F;
            this.clmObserv.HeaderText = "Observación";
            this.clmObserv.Name = "clmObserv";
            this.clmObserv.ReadOnly = true;
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
            this.btnCerrarMant.TabIndex = 28;
            this.btnCerrarMant.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrarMant.UseVisualStyleBackColor = false;
            this.btnCerrarMant.Click += new System.EventHandler(this.btnCerrarMant_Click);
            // 
            // btnAprobar
            // 
            this.btnAprobar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(182)))), ((int)(((byte)(27)))));
            this.btnAprobar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAprobar.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobar.ForeColor = System.Drawing.Color.White;
            this.btnAprobar.Image = ((System.Drawing.Image)(resources.GetObject("btnAprobar.Image")));
            this.btnAprobar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAprobar.Location = new System.Drawing.Point(430, 439);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(156, 82);
            this.btnAprobar.TabIndex = 29;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAprobar.UseVisualStyleBackColor = false;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(236, 439);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(156, 82);
            this.btnBorrar.TabIndex = 30;
            this.btnBorrar.Text = "Rechazar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumPurple;
            this.label5.Location = new System.Drawing.Point(335, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "Revisar Solicitudes";
            // 
            // FrmRevisarSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(840, 560);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.btnCerrarMant);
            this.Controls.Add(this.dgvSolicitudes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRevisarSolicitudes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRevisarSolicitudes";
            this.Load += new System.EventHandler(this.FrmRevisarSolicitudes_Load);
            this.Click += new System.EventHandler(this.FrmRevisarSolicitudes_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.Button btnCerrarMant;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmColab;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaSoli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmObserv;
    }
}