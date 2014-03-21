using System.Windows.Forms;
namespace Labo1
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
            if (MessageBox.Show("Fermer la fenêtre", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.panelDessin = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(36, 26);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(225, 50);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(591, 26);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(225, 50);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // panelDessin
            // 
            this.panelDessin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelDessin.Location = new System.Drawing.Point(36, 89);
            this.panelDessin.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.panelDessin.Name = "panelDessin";
            this.panelDessin.Size = new System.Drawing.Size(780, 453);
            this.panelDessin.TabIndex = 2;
            this.panelDessin.Click += new System.EventHandler(this.panelDessin_Click);
            this.panelDessin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDessin_Paint);
            this.panelDessin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDessin_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 568);
            this.Controls.Add(this.panelDessin);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonClose);
            this.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private Button buttonOpen;
        private Panel panelDessin;
    }
}

