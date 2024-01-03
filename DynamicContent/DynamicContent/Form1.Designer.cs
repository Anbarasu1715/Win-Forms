namespace DynamicContent
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
            this.controlPanel = new System.Windows.Forms.Panel();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.removeBtnPanel = new System.Windows.Forms.Panel();
            this.addBtnPanel = new System.Windows.Forms.Panel();
            this.wLbl = new System.Windows.Forms.Label();
            this.widthTB = new System.Windows.Forms.TextBox();
            this.warnLbl = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.removeBtnPanel.SuspendLayout();
            this.addBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.displayPanel);
            this.mainPanel.Controls.Add(this.controlPanel);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(884, 661);
            this.mainPanel.TabIndex = 0;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.warnLbl);
            this.controlPanel.Controls.Add(this.widthTB);
            this.controlPanel.Controls.Add(this.wLbl);
            this.controlPanel.Controls.Add(this.addBtnPanel);
            this.controlPanel.Controls.Add(this.removeBtnPanel);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(250, 661);
            this.controlPanel.TabIndex = 0;
            // 
            // displayPanel
            // 
            this.displayPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.displayPanel.Location = new System.Drawing.Point(250, 0);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(634, 661);
            this.displayPanel.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(34, 17);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(176, 55);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Location = new System.Drawing.Point(34, 19);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(176, 55);
            this.removeBtn.TabIndex = 1;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // removeBtnPanel
            // 
            this.removeBtnPanel.Controls.Add(this.removeBtn);
            this.removeBtnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.removeBtnPanel.Location = new System.Drawing.Point(0, 575);
            this.removeBtnPanel.Name = "removeBtnPanel";
            this.removeBtnPanel.Size = new System.Drawing.Size(250, 86);
            this.removeBtnPanel.TabIndex = 2;
            // 
            // addBtnPanel
            // 
            this.addBtnPanel.Controls.Add(this.addBtn);
            this.addBtnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addBtnPanel.Location = new System.Drawing.Point(0, 483);
            this.addBtnPanel.Name = "addBtnPanel";
            this.addBtnPanel.Size = new System.Drawing.Size(250, 92);
            this.addBtnPanel.TabIndex = 3;
            // 
            // wLbl
            // 
            this.wLbl.AutoSize = true;
            this.wLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wLbl.Location = new System.Drawing.Point(12, 359);
            this.wLbl.Name = "wLbl";
            this.wLbl.Size = new System.Drawing.Size(65, 20);
            this.wLbl.TabIndex = 5;
            this.wLbl.Text = "Width :";
            // 
            // widthTB
            // 
            this.widthTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthTB.Location = new System.Drawing.Point(90, 359);
            this.widthTB.Name = "widthTB";
            this.widthTB.Size = new System.Drawing.Size(139, 22);
            this.widthTB.TabIndex = 7;
            // 
            // warnLbl
            // 
            this.warnLbl.AutoSize = true;
            this.warnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warnLbl.ForeColor = System.Drawing.Color.Red;
            this.warnLbl.Location = new System.Drawing.Point(37, 436);
            this.warnLbl.Name = "warnLbl";
            this.warnLbl.Size = new System.Drawing.Size(0, 16);
            this.warnLbl.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.removeBtnPanel.ResumeLayout(false);
            this.addBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel removeBtnPanel;
        private System.Windows.Forms.Panel addBtnPanel;
        private System.Windows.Forms.Label wLbl;
        private System.Windows.Forms.TextBox widthTB;
        private System.Windows.Forms.Label warnLbl;
    }
}

