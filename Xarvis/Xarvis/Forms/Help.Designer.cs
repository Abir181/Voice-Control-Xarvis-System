
namespace Xarvis
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.pnlHelp = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHelp
            // 
            this.pnlHelp.AutoSize = true;
            this.pnlHelp.Controls.Add(this.label1);
            this.pnlHelp.Location = new System.Drawing.Point(0, -1);
            this.pnlHelp.Name = "pnlHelp";
            this.pnlHelp.Size = new System.Drawing.Size(808, 451);
            this.pnlHelp.TabIndex = 0;
            this.pnlHelp.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHelp_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instraction";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.pnlHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Help";
            this.Text = "Help";
            this.pnlHelp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHelp;
        private System.Windows.Forms.Label label1;
    }
}