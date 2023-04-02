namespace TiendasMásURLMM1089322
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fACTURACIÓNToolStripMenuItem = new ToolStripMenuItem();
            rEPORTESDEFACTURACIÓNToolStripMenuItem = new ToolStripMenuItem();
            sALIRToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Californian FB", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fACTURACIÓNToolStripMenuItem, rEPORTESDEFACTURACIÓNToolStripMenuItem, sALIRToolStripMenuItem });
            menuStrip1.Location = new Point(177, 84);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(453, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fACTURACIÓNToolStripMenuItem
            // 
            fACTURACIÓNToolStripMenuItem.Name = "fACTURACIÓNToolStripMenuItem";
            fACTURACIÓNToolStripMenuItem.Size = new Size(135, 23);
            fACTURACIÓNToolStripMenuItem.Text = "FACTURACIÓN";
            fACTURACIÓNToolStripMenuItem.Click += fACTURACIÓNToolStripMenuItem_Click;
            // 
            // rEPORTESDEFACTURACIÓNToolStripMenuItem
            // 
            rEPORTESDEFACTURACIÓNToolStripMenuItem.Name = "rEPORTESDEFACTURACIÓNToolStripMenuItem";
            rEPORTESDEFACTURACIÓNToolStripMenuItem.Size = new Size(242, 23);
            rEPORTESDEFACTURACIÓNToolStripMenuItem.Text = "REPORTES DE FACTURACIÓN";
            rEPORTESDEFACTURACIÓNToolStripMenuItem.Click += rEPORTESToolStripMenuItem_Click;
            // 
            // sALIRToolStripMenuItem
            // 
            sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            sALIRToolStripMenuItem.Size = new Size(68, 23);
            sALIRToolStripMenuItem.Text = "SALIR ";
            sALIRToolStripMenuItem.Click += SalirToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 192, 0);
            label1.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(322, 9);
            label1.Name = "label1";
            label1.Size = new Size(201, 36);
            label1.TabIndex = 1;
            label1.Text = "Tiendas Más";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Yellow;
            label2.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1, 138);
            label2.Name = "label2";
            label2.Size = new Size(245, 114);
            label2.TabIndex = 2;
            label2.Text = "Productos:\r\n001   Libra de Azúcar   Q.10.80\r\n002   Libra de Arroz    Q.3.80\r\n003   Galleta GAMA    Q.1.10\r\n004   Coca Cola          Q.17.00\r\n005   Libra de Café      Q.50.00";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.OIP;
            pictureBox1.Location = new Point(582, 297);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.OIP__1_;
            pictureBox2.Location = new Point(1, 349);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(214, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FloralWhite;
            label3.Location = new Point(281, 54);
            label3.Name = "label3";
            label3.Size = new Size(280, 21);
            label3.TabIndex = 5;
            label3.Text = "\"Calidad, Variedad y Buena Atención\"";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Yellow;
            label4.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(427, 138);
            label4.Name = "label4";
            label4.Size = new Size(384, 128);
            label4.TabIndex = 6;
            label4.Text = resources.GetString("label4.Text");
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 192, 0);
            label5.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(322, 421);
            label5.Name = "label5";
            label5.Size = new Size(193, 20);
            label5.TabIndex = 7;
            label5.Text = "Mario Maldonado 1089322";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "TiendasMásURL";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fACTURACIÓNToolStripMenuItem;
        private ToolStripMenuItem rEPORTESDEFACTURACIÓNToolStripMenuItem;
        private ToolStripMenuItem sALIRToolStripMenuItem;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}