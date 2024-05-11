namespace SonÇırpınış
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.raketikilabel = new System.Windows.Forms.Label();
            this.raketbirlabel = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.raketiki = new System.Windows.Forms.PictureBox();
            this.raketbir = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raketiki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raketbir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.raketikilabel);
            this.panel1.Controls.Add(this.raketbirlabel);
            this.panel1.Controls.Add(this.ball);
            this.panel1.Controls.Add(this.raketiki);
            this.panel1.Controls.Add(this.raketbir);
            this.panel1.Location = new System.Drawing.Point(58, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 426);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // raketikilabel
            // 
            this.raketikilabel.AutoSize = true;
            this.raketikilabel.Location = new System.Drawing.Point(500, 29);
            this.raketikilabel.Name = "raketikilabel";
            this.raketikilabel.Size = new System.Drawing.Size(17, 20);
            this.raketikilabel.TabIndex = 4;
            this.raketikilabel.Text = "0";
            this.raketikilabel.Click += new System.EventHandler(this.raketikilabel_Click);
            // 
            // raketbirlabel
            // 
            this.raketbirlabel.AutoSize = true;
            this.raketbirlabel.Location = new System.Drawing.Point(181, 29);
            this.raketbirlabel.Name = "raketbirlabel";
            this.raketbirlabel.Size = new System.Drawing.Size(17, 20);
            this.raketbirlabel.TabIndex = 3;
            this.raketbirlabel.Text = "0";
            this.raketbirlabel.Click += new System.EventHandler(this.raketbirlabel_Click);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ball.Location = new System.Drawing.Point(335, 195);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(38, 38);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            this.ball.Click += new System.EventHandler(this.ball_Click);
            // 
            // raketiki
            // 
            this.raketiki.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.raketiki.Location = new System.Drawing.Point(636, 110);
            this.raketiki.Name = "raketiki";
            this.raketiki.Size = new System.Drawing.Size(37, 147);
            this.raketiki.TabIndex = 1;
            this.raketiki.TabStop = false;
            this.raketiki.Click += new System.EventHandler(this.raketiki_Click);
            // 
            // raketbir
            // 
            this.raketbir.BackColor = System.Drawing.Color.Plum;
            this.raketbir.Location = new System.Drawing.Point(32, 110);
            this.raketbir.Name = "raketbir";
            this.raketbir.Size = new System.Drawing.Size(37, 147);
            this.raketbir.TabIndex = 0;
            this.raketbir.TabStop = false;
            this.raketbir.Click += new System.EventHandler(this.raketbir_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raketiki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raketbir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label raketikilabel;
        private Label raketbirlabel;
        private PictureBox ball;
        private PictureBox raketiki;
        private PictureBox raketbir;
        private System.Windows.Forms.Timer timer1;
    }
}