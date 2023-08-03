namespace OOPSampleJuly._03
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
            this.trcRed = new System.Windows.Forms.TrackBar();
            this.trcGreen = new System.Windows.Forms.TrackBar();
            this.trcBlue = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnIsimile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trcRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // trcRed
            // 
            this.trcRed.Location = new System.Drawing.Point(67, 39);
            this.trcRed.Maximum = 255;
            this.trcRed.Name = "trcRed";
            this.trcRed.Size = new System.Drawing.Size(623, 45);
            this.trcRed.TabIndex = 0;
            // 
            // trcGreen
            // 
            this.trcGreen.Location = new System.Drawing.Point(67, 155);
            this.trcGreen.Maximum = 255;
            this.trcGreen.Name = "trcGreen";
            this.trcGreen.Size = new System.Drawing.Size(623, 45);
            this.trcGreen.TabIndex = 1;
            // 
            // trcBlue
            // 
            this.trcBlue.Location = new System.Drawing.Point(67, 299);
            this.trcBlue.Maximum = 255;
            this.trcBlue.Name = "trcBlue";
            this.trcBlue.Size = new System.Drawing.Size(623, 45);
            this.trcBlue.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(723, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "RED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "GREEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(723, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "BLUE";
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(638, 387);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(115, 37);
            this.btnDegistir.TabIndex = 6;
            this.btnDegistir.Text = "Renk Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnIsimile
            // 
            this.btnIsimile.Location = new System.Drawing.Point(432, 387);
            this.btnIsimile.Name = "btnIsimile";
            this.btnIsimile.Size = new System.Drawing.Size(115, 37);
            this.btnIsimile.TabIndex = 7;
            this.btnIsimile.Text = "Renk Değiştir-İsim";
            this.btnIsimile.UseVisualStyleBackColor = true;
            this.btnIsimile.Click += new System.EventHandler(this.btnIsimile_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 387);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 37);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnIsimile);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trcBlue);
            this.Controls.Add(this.trcGreen);
            this.Controls.Add(this.trcRed);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trcRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trcRed;
        private System.Windows.Forms.TrackBar trcGreen;
        private System.Windows.Forms.TrackBar trcBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnIsimile;
        private System.Windows.Forms.TextBox textBox1;
    }
}

