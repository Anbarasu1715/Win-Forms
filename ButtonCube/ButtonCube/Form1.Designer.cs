namespace ButtonCube
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.addBtn = new System.Windows.Forms.Button();
            this.btnControlPanel = new System.Windows.Forms.Panel();
            this.subBtn = new System.Windows.Forms.Button();
            this.displayLbl = new System.Windows.Forms.Label();
            this.containerUserControl = new ButtonCube.ButtonPanel();
            this.mainPanel.SuspendLayout();
            this.btnControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.btnControlPanel);
            this.mainPanel.Controls.Add(this.containerUserControl);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainPanel.Location = new System.Drawing.Point(-1, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(641, 567);
            this.mainPanel.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(38, 178);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 67);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // btnControlPanel
            // 
            this.btnControlPanel.Controls.Add(this.displayLbl);
            this.btnControlPanel.Controls.Add(this.subBtn);
            this.btnControlPanel.Controls.Add(this.addBtn);
            this.btnControlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnControlPanel.Location = new System.Drawing.Point(0, 0);
            this.btnControlPanel.Name = "btnControlPanel";
            this.btnControlPanel.Size = new System.Drawing.Size(150, 567);
            this.btnControlPanel.TabIndex = 2;
            // 
            // subBtn
            // 
            this.subBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBtn.Location = new System.Drawing.Point(38, 278);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(75, 67);
            this.subBtn.TabIndex = 1;
            this.subBtn.Text = "-";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // displayLbl
            // 
            this.displayLbl.AutoSize = true;
            this.displayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLbl.Location = new System.Drawing.Point(5, 402);
            this.displayLbl.Name = "displayLbl";
            this.displayLbl.Size = new System.Drawing.Size(0, 18);
            this.displayLbl.TabIndex = 2;
            // 
            // containerUserControl
            // 
            this.containerUserControl.Location = new System.Drawing.Point(168, 60);
            this.containerUserControl.Name = "containerUserControl";
            this.containerUserControl.Size = new System.Drawing.Size(450, 450);
            this.containerUserControl.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 567);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.btnControlPanel.ResumeLayout(false);
            this.btnControlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button addBtn;
        private ButtonPanel containerUserControl;
        private System.Windows.Forms.Panel btnControlPanel;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Label displayLbl;
    }
}

