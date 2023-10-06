namespace ColorGuesser
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pbInside = new System.Windows.Forms.PictureBox();
            this.pbOutline = new System.Windows.Forms.PictureBox();
            this.tbR = new System.Windows.Forms.TrackBar();
            this.tbG = new System.Windows.Forms.TrackBar();
            this.tbB = new System.Windows.Forms.TrackBar();
            this.lblR = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblOdp = new System.Windows.Forms.Label();
            this.btnSecretButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbInside)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSecretButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(64, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Guess color";
            // 
            // pbInside
            // 
            this.pbInside.Location = new System.Drawing.Point(96, 80);
            this.pbInside.Name = "pbInside";
            this.pbInside.Size = new System.Drawing.Size(88, 88);
            this.pbInside.TabIndex = 8;
            this.pbInside.TabStop = false;
            // 
            // pbOutline
            // 
            this.pbOutline.Location = new System.Drawing.Point(80, 64);
            this.pbOutline.Name = "pbOutline";
            this.pbOutline.Size = new System.Drawing.Size(120, 120);
            this.pbOutline.TabIndex = 9;
            this.pbOutline.TabStop = false;
            // 
            // tbR
            // 
            this.tbR.Location = new System.Drawing.Point(40, 200);
            this.tbR.Maximum = 255;
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(216, 45);
            this.tbR.TabIndex = 10;
            this.tbR.Tag = "";
            this.tbR.TickFrequency = 10;
            this.tbR.Scroll += new System.EventHandler(this.tbR_Scroll);
            this.tbR.ValueChanged += new System.EventHandler(this.tbR_ValueChanged);
            // 
            // tbG
            // 
            this.tbG.Location = new System.Drawing.Point(40, 256);
            this.tbG.Maximum = 255;
            this.tbG.Name = "tbG";
            this.tbG.Size = new System.Drawing.Size(216, 45);
            this.tbG.TabIndex = 11;
            this.tbG.TickFrequency = 10;
            this.tbG.Scroll += new System.EventHandler(this.tbG_Scroll);
            this.tbG.ValueChanged += new System.EventHandler(this.tbR_ValueChanged);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(40, 312);
            this.tbB.Maximum = 255;
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(216, 45);
            this.tbB.TabIndex = 12;
            this.tbB.TickFrequency = 10;
            this.tbB.Scroll += new System.EventHandler(this.tbB_Scroll);
            this.tbB.ValueChanged += new System.EventHandler(this.tbR_ValueChanged);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(40, 232);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(27, 13);
            this.lblR.TabIndex = 13;
            this.lblR.Text = "R: 0";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(40, 288);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(27, 13);
            this.lblG.TabIndex = 14;
            this.lblG.Text = "G: 0";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(40, 344);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(26, 13);
            this.lblB.TabIndex = 15;
            this.lblB.Text = "B: 0";
            // 
            // lblOdp
            // 
            this.lblOdp.AutoSize = true;
            this.lblOdp.Location = new System.Drawing.Point(8, 384);
            this.lblOdp.Name = "lblOdp";
            this.lblOdp.Size = new System.Drawing.Size(30, 13);
            this.lblOdp.TabIndex = 16;
            this.lblOdp.Text = "RGB";
            // 
            // btnSecretButton
            // 
            this.btnSecretButton.Location = new System.Drawing.Point(0, 384);
            this.btnSecretButton.Name = "btnSecretButton";
            this.btnSecretButton.Size = new System.Drawing.Size(16, 16);
            this.btnSecretButton.TabIndex = 17;
            this.btnSecretButton.TabStop = false;
            this.btnSecretButton.DoubleClick += new System.EventHandler(this.btnSecretButton_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 401);
            this.Controls.Add(this.lblOdp);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbG);
            this.Controls.Add(this.tbR);
            this.Controls.Add(this.pbInside);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbOutline);
            this.Controls.Add(this.btnSecretButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 440);
            this.Name = "Form1";
            this.Text = "Color Guesser";
            ((System.ComponentModel.ISupportInitialize)(this.pbInside)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSecretButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbInside;
        private System.Windows.Forms.PictureBox pbOutline;
        private System.Windows.Forms.TrackBar tbR;
        private System.Windows.Forms.TrackBar tbG;
        private System.Windows.Forms.TrackBar tbB;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblOdp;
        private System.Windows.Forms.PictureBox btnSecretButton;
    }
}

