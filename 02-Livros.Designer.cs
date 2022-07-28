namespace livros
{
    partial class frmLivros
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
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.radContraCapa = new System.Windows.Forms.RadioButton();
            this.radCapa = new System.Windows.Forms.RadioButton();
            this.lblLivros = new System.Windows.Forms.Label();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.radFic = new System.Windows.Forms.RadioButton();
            this.radHQ = new System.Windows.Forms.RadioButton();
            this.radTerror = new System.Windows.Forms.RadioButton();
            this.radRomance = new System.Windows.Forms.RadioButton();
            this.pnlGenero = new System.Windows.Forms.Panel();
            this.lblGenero4 = new System.Windows.Forms.Label();
            this.lblGenero3 = new System.Windows.Forms.Label();
            this.lblGenero1 = new System.Windows.Forms.Label();
            this.lblGenero2 = new System.Windows.Forms.Label();
            this.picImagem04 = new System.Windows.Forms.PictureBox();
            this.picImagem03 = new System.Windows.Forms.PictureBox();
            this.picImagem02 = new System.Windows.Forms.PictureBox();
            this.picImagem01 = new System.Windows.Forms.PictureBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEspaco = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.grpInfo.SuspendLayout();
            this.grpGenero.SuspendLayout();
            this.pnlGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem01)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInfo
            // 
            this.grpInfo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.grpInfo.Controls.Add(this.radContraCapa);
            this.grpInfo.Controls.Add(this.radCapa);
            this.grpInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpInfo.Font = new System.Drawing.Font("Roboto Condensed", 14F);
            this.grpInfo.Location = new System.Drawing.Point(1, 73);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(15, 9, 9, 9);
            this.grpInfo.Size = new System.Drawing.Size(180, 132);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Informações";
            this.grpInfo.Enter += new System.EventHandler(this.grpInfo_Enter);
            // 
            // radContraCapa
            // 
            this.radContraCapa.AutoSize = true;
            this.radContraCapa.Font = new System.Drawing.Font("Roboto Condensed", 10F);
            this.radContraCapa.Location = new System.Drawing.Point(18, 65);
            this.radContraCapa.Name = "radContraCapa";
            this.radContraCapa.Size = new System.Drawing.Size(96, 23);
            this.radContraCapa.TabIndex = 0;
            this.radContraCapa.Text = "Contra Capa";
            this.radContraCapa.UseVisualStyleBackColor = true;
            this.radContraCapa.CheckedChanged += new System.EventHandler(this.radContraCapa_CheckedChanged);
            // 
            // radCapa
            // 
            this.radCapa.AutoSize = true;
            this.radCapa.Font = new System.Drawing.Font("Roboto Condensed", 10F);
            this.radCapa.Location = new System.Drawing.Point(18, 37);
            this.radCapa.Name = "radCapa";
            this.radCapa.Size = new System.Drawing.Size(56, 23);
            this.radCapa.TabIndex = 0;
            this.radCapa.Text = "Capa";
            this.radCapa.UseVisualStyleBackColor = true;
            this.radCapa.CheckedChanged += new System.EventHandler(this.radCapa_CheckedChanged);
            // 
            // lblLivros
            // 
            this.lblLivros.BackColor = System.Drawing.Color.Teal;
            this.lblLivros.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLivros.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.lblLivros.ForeColor = System.Drawing.Color.Transparent;
            this.lblLivros.Location = new System.Drawing.Point(0, 0);
            this.lblLivros.Name = "lblLivros";
            this.lblLivros.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lblLivros.Size = new System.Drawing.Size(800, 73);
            this.lblLivros.TabIndex = 1;
            this.lblLivros.Text = "Livros";
            this.lblLivros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLivros.Click += new System.EventHandler(this.lblLivros_Click);
            // 
            // grpGenero
            // 
            this.grpGenero.BackColor = System.Drawing.Color.LightSeaGreen;
            this.grpGenero.Controls.Add(this.radFic);
            this.grpGenero.Controls.Add(this.radHQ);
            this.grpGenero.Controls.Add(this.radTerror);
            this.grpGenero.Controls.Add(this.radRomance);
            this.grpGenero.Font = new System.Drawing.Font("Roboto Condensed", 14F);
            this.grpGenero.Location = new System.Drawing.Point(1, 198);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Padding = new System.Windows.Forms.Padding(15, 9, 9, 9);
            this.grpGenero.Size = new System.Drawing.Size(180, 265);
            this.grpGenero.TabIndex = 1;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Gênero";
            this.grpGenero.Enter += new System.EventHandler(this.grpGenero_Enter);
            // 
            // radFic
            // 
            this.radFic.AutoSize = true;
            this.radFic.Font = new System.Drawing.Font("Roboto Condensed", 10F);
            this.radFic.Location = new System.Drawing.Point(18, 94);
            this.radFic.Name = "radFic";
            this.radFic.Size = new System.Drawing.Size(118, 23);
            this.radFic.TabIndex = 0;
            this.radFic.Text = "Ficção Científica";
            this.radFic.UseVisualStyleBackColor = true;
            this.radFic.CheckedChanged += new System.EventHandler(this.radFic_CheckedChanged);
            // 
            // radHQ
            // 
            this.radHQ.AutoSize = true;
            this.radHQ.BackColor = System.Drawing.Color.LightSeaGreen;
            this.radHQ.Font = new System.Drawing.Font("Roboto Condensed", 10F);
            this.radHQ.Location = new System.Drawing.Point(18, 123);
            this.radHQ.Name = "radHQ";
            this.radHQ.Size = new System.Drawing.Size(44, 23);
            this.radHQ.TabIndex = 0;
            this.radHQ.Text = "HQ";
            this.radHQ.UseVisualStyleBackColor = false;
            this.radHQ.CheckedChanged += new System.EventHandler(this.radHQ_CheckedChanged);
            // 
            // radTerror
            // 
            this.radTerror.AutoSize = true;
            this.radTerror.Font = new System.Drawing.Font("Roboto Condensed", 10F);
            this.radTerror.Location = new System.Drawing.Point(18, 65);
            this.radTerror.Name = "radTerror";
            this.radTerror.Size = new System.Drawing.Size(60, 23);
            this.radTerror.TabIndex = 0;
            this.radTerror.Text = "Terror";
            this.radTerror.UseVisualStyleBackColor = true;
            this.radTerror.CheckedChanged += new System.EventHandler(this.radTerror_CheckedChanged);
            // 
            // radRomance
            // 
            this.radRomance.AutoSize = true;
            this.radRomance.Font = new System.Drawing.Font("Roboto Condensed", 10F);
            this.radRomance.Location = new System.Drawing.Point(18, 37);
            this.radRomance.Name = "radRomance";
            this.radRomance.Size = new System.Drawing.Size(79, 23);
            this.radRomance.TabIndex = 0;
            this.radRomance.Text = "Românce";
            this.radRomance.UseVisualStyleBackColor = true;
            this.radRomance.CheckedChanged += new System.EventHandler(this.radRomance_CheckedChanged);
            // 
            // pnlGenero
            // 
            this.pnlGenero.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlGenero.Controls.Add(this.lblGenero4);
            this.pnlGenero.Controls.Add(this.lblGenero3);
            this.pnlGenero.Controls.Add(this.lblGenero1);
            this.pnlGenero.Controls.Add(this.lblGenero2);
            this.pnlGenero.Controls.Add(this.picImagem04);
            this.pnlGenero.Controls.Add(this.picImagem03);
            this.pnlGenero.Controls.Add(this.picImagem02);
            this.pnlGenero.Controls.Add(this.picImagem01);
            this.pnlGenero.Controls.Add(this.lblGenero);
            this.pnlGenero.Location = new System.Drawing.Point(169, 73);
            this.pnlGenero.Name = "pnlGenero";
            this.pnlGenero.Size = new System.Drawing.Size(631, 377);
            this.pnlGenero.TabIndex = 2;
            this.pnlGenero.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGenero_Paint);
            // 
            // lblGenero4
            // 
            this.lblGenero4.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.lblGenero4.ForeColor = System.Drawing.Color.Transparent;
            this.lblGenero4.Location = new System.Drawing.Point(480, 292);
            this.lblGenero4.Name = "lblGenero4";
            this.lblGenero4.Size = new System.Drawing.Size(120, 42);
            this.lblGenero4.TabIndex = 2;
            this.lblGenero4.Text = "Gênero 4";
            this.lblGenero4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenero3
            // 
            this.lblGenero3.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.lblGenero3.ForeColor = System.Drawing.Color.Transparent;
            this.lblGenero3.Location = new System.Drawing.Point(328, 292);
            this.lblGenero3.Name = "lblGenero3";
            this.lblGenero3.Size = new System.Drawing.Size(120, 42);
            this.lblGenero3.TabIndex = 2;
            this.lblGenero3.Text = "Gênero 3";
            this.lblGenero3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenero1
            // 
            this.lblGenero1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.lblGenero1.ForeColor = System.Drawing.Color.Transparent;
            this.lblGenero1.Location = new System.Drawing.Point(24, 292);
            this.lblGenero1.Name = "lblGenero1";
            this.lblGenero1.Size = new System.Drawing.Size(120, 42);
            this.lblGenero1.TabIndex = 2;
            this.lblGenero1.Text = "Gênero 1";
            this.lblGenero1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGenero1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGenero2
            // 
            this.lblGenero2.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.lblGenero2.ForeColor = System.Drawing.Color.Transparent;
            this.lblGenero2.Location = new System.Drawing.Point(176, 292);
            this.lblGenero2.Name = "lblGenero2";
            this.lblGenero2.Size = new System.Drawing.Size(120, 42);
            this.lblGenero2.TabIndex = 2;
            this.lblGenero2.Text = "Gênero 2";
            this.lblGenero2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picImagem04
            // 
            this.picImagem04.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picImagem04.Location = new System.Drawing.Point(474, 65);
            this.picImagem04.Name = "picImagem04";
            this.picImagem04.Size = new System.Drawing.Size(136, 193);
            this.picImagem04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem04.TabIndex = 1;
            this.picImagem04.TabStop = false;
            // 
            // picImagem03
            // 
            this.picImagem03.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picImagem03.Location = new System.Drawing.Point(322, 65);
            this.picImagem03.Name = "picImagem03";
            this.picImagem03.Size = new System.Drawing.Size(136, 193);
            this.picImagem03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem03.TabIndex = 1;
            this.picImagem03.TabStop = false;
            // 
            // picImagem02
            // 
            this.picImagem02.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picImagem02.Location = new System.Drawing.Point(170, 65);
            this.picImagem02.Name = "picImagem02";
            this.picImagem02.Size = new System.Drawing.Size(136, 193);
            this.picImagem02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem02.TabIndex = 1;
            this.picImagem02.TabStop = false;
            // 
            // picImagem01
            // 
            this.picImagem01.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picImagem01.Location = new System.Drawing.Point(18, 65);
            this.picImagem01.Name = "picImagem01";
            this.picImagem01.Size = new System.Drawing.Size(136, 193);
            this.picImagem01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem01.TabIndex = 1;
            this.picImagem01.TabStop = false;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.SlateGray;
            this.lblGenero.Font = new System.Drawing.Font("Roboto Condensed", 20F, System.Drawing.FontStyle.Bold);
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(18, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(92, 35);
            this.lblGenero.TabIndex = 0;
            this.lblGenero.Text = "Gênero";
            // 
            // lblEspaco
            // 
            this.lblEspaco.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblEspaco.Location = new System.Drawing.Point(-27, 73);
            this.lblEspaco.Name = "lblEspaco";
            this.lblEspaco.Size = new System.Drawing.Size(35, 377);
            this.lblEspaco.TabIndex = 3;
            this.lblEspaco.Text = " ";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Crimson;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Roboto Condensed", 7.4F, System.Drawing.FontStyle.Bold);
            this.btnFechar.Location = new System.Drawing.Point(758, 29);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(20, 23);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightBlue;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Roboto Condensed", 8F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Location = new System.Drawing.Point(703, 29);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(49, 23);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblEspaco);
            this.Controls.Add(this.pnlGenero);
            this.Controls.Add(this.grpGenero);
            this.Controls.Add(this.lblLivros);
            this.Controls.Add(this.grpInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livros";
            this.Load += new System.EventHandler(this.frmLivros_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.pnlGenero.ResumeLayout(false);
            this.pnlGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem01)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.RadioButton radContraCapa;
        private System.Windows.Forms.RadioButton radCapa;
        private System.Windows.Forms.Label lblLivros;
        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.RadioButton radFic;
        private System.Windows.Forms.RadioButton radTerror;
        private System.Windows.Forms.RadioButton radRomance;
        private System.Windows.Forms.RadioButton radHQ;
        private System.Windows.Forms.Panel pnlGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.PictureBox picImagem04;
        private System.Windows.Forms.PictureBox picImagem03;
        private System.Windows.Forms.PictureBox picImagem02;
        private System.Windows.Forms.PictureBox picImagem01;
        private System.Windows.Forms.Label lblGenero4;
        private System.Windows.Forms.Label lblGenero3;
        private System.Windows.Forms.Label lblGenero1;
        private System.Windows.Forms.Label lblGenero2;
        private System.Windows.Forms.Label lblEspaco;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLogout;
    }
}