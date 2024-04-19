namespace Octopus.Layers.UI.Mantenimiento
{
    partial class FrmAsignarDeducPercep
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsignarDeducPercep));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTodas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbFotografia = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvPercep = new System.Windows.Forms.DataGridView();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDeduc = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotografia)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPercep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeduc)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightBlue;
            this.label3.Location = new System.Drawing.Point(35, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Lista de deducciones y percepciones";
            // 
            // dgvTodas
            // 
            this.dgvTodas.AllowUserToAddRows = false;
            this.dgvTodas.AllowUserToDeleteRows = false;
            this.dgvTodas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTodas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTodas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTodas.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dgvTodas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTodas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTodas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTodas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTodas.Location = new System.Drawing.Point(12, 166);
            this.dgvTodas.MultiSelect = false;
            this.dgvTodas.Name = "dgvTodas";
            this.dgvTodas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTodas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTodas.RowHeadersVisible = false;
            this.dgvTodas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTodas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodas.Size = new System.Drawing.Size(400, 456);
            this.dgvTodas.TabIndex = 15;
            this.dgvTodas.SelectionChanged += new System.EventHandler(this.dgvTodas_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightBlue;
            this.label1.Location = new System.Drawing.Point(571, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Lista de deducciones ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightBlue;
            this.label2.Location = new System.Drawing.Point(571, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Lista de percepciones ";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(909, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 34);
            this.btnCerrar.TabIndex = 29;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pbFotografia
            // 
            this.pbFotografia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbFotografia.Image = ((System.Drawing.Image)(resources.GetObject("pbFotografia.Image")));
            this.pbFotografia.Location = new System.Drawing.Point(142, 23);
            this.pbFotografia.Name = "pbFotografia";
            this.pbFotografia.Size = new System.Drawing.Size(98, 93);
            this.pbFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotografia.TabIndex = 30;
            this.pbFotografia.TabStop = false;
            this.pbFotografia.Click += new System.EventHandler(this.pbFotografia_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblNombre.Location = new System.Drawing.Point(246, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(244, 29);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "¡Hola! Toca la imagen";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidos.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblApellidos.Location = new System.Drawing.Point(246, 83);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(317, 33);
            this.lblApellidos.TabIndex = 32;
            this.lblApellidos.Text = "Para seleccionar Usuario";
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Location = new System.Drawing.Point(430, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 188);
            this.panel1.TabIndex = 35;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(12, 102);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(66, 74);
            this.btnEliminar.TabIndex = 36;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(12, 15);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(66, 74);
            this.btnAgregar.TabIndex = 35;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvPercep
            // 
            this.dgvPercep.AllowUserToAddRows = false;
            this.dgvPercep.AllowUserToDeleteRows = false;
            this.dgvPercep.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPercep.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPercep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPercep.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dgvPercep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPercep.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPercep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPercep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNombre,
            this.clmTipoValor,
            this.clmValor,
            this.clmPrioridad});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPercep.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPercep.Location = new System.Drawing.Point(540, 166);
            this.dgvPercep.MultiSelect = false;
            this.dgvPercep.Name = "dgvPercep";
            this.dgvPercep.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPercep.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPercep.RowHeadersVisible = false;
            this.dgvPercep.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPercep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPercep.Size = new System.Drawing.Size(393, 210);
            this.dgvPercep.TabIndex = 36;
            this.dgvPercep.SelectionChanged += new System.EventHandler(this.dgvPercep_SelectionChanged);
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmTipoValor
            // 
            this.clmTipoValor.HeaderText = "Tipo";
            this.clmTipoValor.Name = "clmTipoValor";
            this.clmTipoValor.ReadOnly = true;
            // 
            // clmValor
            // 
            this.clmValor.HeaderText = "Valor";
            this.clmValor.Name = "clmValor";
            this.clmValor.ReadOnly = true;
            // 
            // clmPrioridad
            // 
            this.clmPrioridad.HeaderText = "Prioridad";
            this.clmPrioridad.Name = "clmPrioridad";
            this.clmPrioridad.ReadOnly = true;
            // 
            // dgvDeduc
            // 
            this.dgvDeduc.AllowUserToAddRows = false;
            this.dgvDeduc.AllowUserToDeleteRows = false;
            this.dgvDeduc.AllowUserToResizeRows = false;
            this.dgvDeduc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeduc.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dgvDeduc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDeduc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDeduc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeduc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeduc.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDeduc.Location = new System.Drawing.Point(540, 412);
            this.dgvDeduc.MultiSelect = false;
            this.dgvDeduc.Name = "dgvDeduc";
            this.dgvDeduc.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeduc.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDeduc.RowHeadersVisible = false;
            this.dgvDeduc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDeduc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeduc.Size = new System.Drawing.Size(393, 210);
            this.dgvDeduc.TabIndex = 37;
            this.dgvDeduc.SelectionChanged += new System.EventHandler(this.dgvDeduc_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Prioridad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // FrmAsignarDeducPercep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(945, 634);
            this.Controls.Add(this.dgvDeduc);
            this.Controls.Add(this.dgvPercep);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pbFotografia);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTodas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAsignarDeducPercep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar ";
            this.Click += new System.EventHandler(this.FrmAsignarDeducPercep_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotografia)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPercep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeduc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTodas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pbFotografia;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvPercep;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrioridad;
        private System.Windows.Forms.DataGridView dgvDeduc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}