namespace DynamicContent
{
    partial class LetterTUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.Btn2);
            this.mainPanel.Controls.Add(this.btn1);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(300, 300);
            this.mainPanel.TabIndex = 0;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Lime;
            this.btn1.Location = new System.Drawing.Point(34, 42);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(235, 45);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.Lime;
            this.Btn2.Location = new System.Drawing.Point(120, 85);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(60, 181);
            this.Btn2.TabIndex = 1;
            this.Btn2.UseVisualStyleBackColor = false;
            // 
            // LetterTUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "LetterTUC";
            this.Size = new System.Drawing.Size(300, 300);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button btn1;
    }
}
