
namespace Xarvis
{
    partial class Voice_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Voice_System));
            this.btnEnableVoice = new System.Windows.Forms.Button();
            this.richVoiceText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnableVoice
            // 
            this.btnEnableVoice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEnableVoice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEnableVoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnEnableVoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnableVoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEnableVoice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnableVoice.Location = new System.Drawing.Point(385, 426);
            this.btnEnableVoice.Name = "btnEnableVoice";
            this.btnEnableVoice.Size = new System.Drawing.Size(299, 70);
            this.btnEnableVoice.TabIndex = 0;
            this.btnEnableVoice.Text = "Enable/Disable Voice";
            this.btnEnableVoice.UseVisualStyleBackColor = false;
            this.btnEnableVoice.Click += new System.EventHandler(this.btnEnableVoice_Click);
            // 
            // richVoiceText
            // 
            this.richVoiceText.AutoWordSelection = true;
            this.richVoiceText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richVoiceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richVoiceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.richVoiceText.ForeColor = System.Drawing.SystemColors.Control;
            this.richVoiceText.Location = new System.Drawing.Point(326, 127);
            this.richVoiceText.Name = "richVoiceText";
            this.richVoiceText.Size = new System.Drawing.Size(411, 231);
            this.richVoiceText.TabIndex = 1;
            this.richVoiceText.Text = "";
            this.richVoiceText.TextChanged += new System.EventHandler(this.richVoiceText_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Panel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 63);
            this.label2.TabIndex = 3;
            this.label2.Text = "About";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 63);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bluetooth";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 63);
            this.label4.TabIndex = 5;
            this.label4.Text = "Browse";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 63);
            this.label5.TabIndex = 6;
            this.label5.Text = "Play Music";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(871, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 63);
            this.label6.TabIndex = 7;
            this.label6.Text = "Setting";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(871, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 63);
            this.label7.TabIndex = 8;
            this.label7.Text = "Folder";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(871, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 63);
            this.label8.TabIndex = 9;
            this.label8.Text = "Wi-Fi";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(871, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 63);
            this.label9.TabIndex = 10;
            this.label9.Text = "Volume";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(871, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 63);
            this.label10.TabIndex = 11;
            this.label10.Text = "Task Manager";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(871, 407);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 63);
            this.label11.TabIndex = 12;
            this.label11.Text = "Performance";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 371);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 63);
            this.label12.TabIndex = 13;
            this.label12.Text = "Uninstall";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 446);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 63);
            this.label13.TabIndex = 14;
            this.label13.Text = "Recycle";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(341, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(377, 63);
            this.label14.TabIndex = 15;
            this.label14.Text = "Click For Instruction";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // Voice_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 508);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richVoiceText);
            this.Controls.Add(this.btnEnableVoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Voice_System";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voice_System";
            this.Load += new System.EventHandler(this.Voice_System_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnableVoice;
        private System.Windows.Forms.RichTextBox richVoiceText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}