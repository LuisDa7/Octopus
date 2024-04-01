namespace Octopus.Layers.UI.MenuAdministrador
{
    partial class FrmMantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenimiento));
            this.pnlMantenimiento = new System.Windows.Forms.Panel();
            this.btnCerrarMant = new System.Windows.Forms.Button();
            this.btnDeducPercep = new System.Windows.Forms.Button();
            this.btnColaborador = new System.Windows.Forms.Button();
            this.btnPuestos = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pnlMantenimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMantenimiento
            // 
            this.pnlMantenimiento.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlMantenimiento.Controls.Add(this.btnCerrarMant);
            this.pnlMantenimiento.Controls.Add(this.btnDeducPercep);
            this.pnlMantenimiento.Controls.Add(this.btnColaborador);
            this.pnlMantenimiento.Controls.Add(this.btnPuestos);
            this.pnlMantenimiento.Location = new System.Drawing.Point(7, 6);
            this.pnlMantenimiento.Name = "pnlMantenimiento";
            this.pnlMantenimiento.Size = new System.Drawing.Size(540, 248);
            this.pnlMantenimiento.TabIndex = 18;
            // 
            // btnCerrarMant
            // 
            this.btnCerrarMant.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarMant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarMant.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarMant.ForeColor = System.Drawing.Color.Black;
            this.btnCerrarMant.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarMant.Image")));
            this.btnCerrarMant.Location = new System.Drawing.Point(502, 3);
            this.btnCerrarMant.Name = "btnCerrarMant";
            this.btnCerrarMant.Size = new System.Drawing.Size(35, 34);
            this.btnCerrarMant.TabIndex = 5;
            this.btnCerrarMant.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrarMant.UseVisualStyleBackColor = false;
            this.btnCerrarMant.Click += new System.EventHandler(this.btnCerrarMant_Click);
            // 
            // btnDeducPercep
            // 
            this.btnDeducPercep.BackColor = System.Drawing.Color.White;
            this.btnDeducPercep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeducPercep.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeducPercep.ForeColor = System.Drawing.Color.Black;
            this.btnDeducPercep.Image = ((System.Drawing.Image)(resources.GetObject("btnDeducPercep.Image")));
            this.btnDeducPercep.Location = new System.Drawing.Point(363, 50);
            this.btnDeducPercep.Name = "btnDeducPercep";
            this.btnDeducPercep.Size = new System.Drawing.Size(145, 145);
            this.btnDeducPercep.TabIndex = 4;
            this.btnDeducPercep.Text = "Deducciones y Percepciones";
            this.btnDeducPercep.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeducPercep.UseVisualStyleBackColor = false;
            this.btnDeducPercep.Click += new System.EventHandler(this.btnDeducPercep_Click);
            // 
            // btnColaborador
            // 
            this.btnColaborador.BackColor = System.Drawing.Color.White;
            this.btnColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColaborador.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColaborador.ForeColor = System.Drawing.Color.Black;
            this.btnColaborador.Image = ((System.Drawing.Image)(resources.GetObject("btnColaborador.Image")));
            this.btnColaborador.Location = new System.Drawing.Point(192, 50);
            this.btnColaborador.Name = "btnColaborador";
            this.btnColaborador.Size = new System.Drawing.Size(145, 145);
            this.btnColaborador.TabIndex = 3;
            this.btnColaborador.Text = "Colaboradores";
            this.btnColaborador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnColaborador.UseVisualStyleBackColor = false;
            this.btnColaborador.Click += new System.EventHandler(this.btnColaborador_Click);
            // 
            // btnPuestos
            // 
            this.btnPuestos.BackColor = System.Drawing.Color.White;
            this.btnPuestos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPuestos.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuestos.ForeColor = System.Drawing.Color.Black;
            this.btnPuestos.Image = ((System.Drawing.Image)(resources.GetObject("btnPuestos.Image")));
            this.btnPuestos.Location = new System.Drawing.Point(24, 50);
            this.btnPuestos.Name = "btnPuestos";
            this.btnPuestos.Size = new System.Drawing.Size(145, 145);
            this.btnPuestos.TabIndex = 2;
            this.btnPuestos.Text = "Puestos";
            this.btnPuestos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPuestos.UseVisualStyleBackColor = false;
            this.btnPuestos.Click += new System.EventHandler(this.btnPuestos_Click);
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
            // timer3
            // 
            this.timer3.Interval = 30;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // FrmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(554, 261);
            this.Controls.Add(this.pnlMantenimiento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento";
            this.pnlMantenimiento.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMantenimiento;
        private System.Windows.Forms.Button btnCerrarMant;
        private System.Windows.Forms.Button btnDeducPercep;
        private System.Windows.Forms.Button btnColaborador;
        private System.Windows.Forms.Button btnPuestos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}