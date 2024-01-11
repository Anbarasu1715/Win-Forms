namespace PageNation
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
            this.containerPanel = new System.Windows.Forms.Panel();
            this.totalTB = new System.Windows.Forms.TextBox();
            this.previewTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.previewpanel = new System.Windows.Forms.Panel();
            this.warnlbl = new System.Windows.Forms.Label();
            this.showLbl = new System.Windows.Forms.Label();
            this.containerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.containerPanel.Controls.Add(this.previewpanel);
            this.containerPanel.Controls.Add(this.nextBtn);
            this.containerPanel.Controls.Add(this.prevBtn);
            this.containerPanel.Location = new System.Drawing.Point(21, 401);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1000, 100);
            this.containerPanel.TabIndex = 0;
            // 
            // totalTB
            // 
            this.totalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTB.Location = new System.Drawing.Point(877, 189);
            this.totalTB.Multiline = true;
            this.totalTB.Name = "totalTB";
            this.totalTB.Size = new System.Drawing.Size(100, 30);
            this.totalTB.TabIndex = 1;
            // 
            // previewTB
            // 
            this.previewTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewTB.Location = new System.Drawing.Point(878, 239);
            this.previewTB.Multiline = true;
            this.previewTB.Name = "previewTB";
            this.previewTB.Size = new System.Drawing.Size(100, 30);
            this.previewTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(729, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Buttons";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(753, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preview";
            // 
            // createBtn
            // 
            this.createBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Location = new System.Drawing.Point(795, 315);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(158, 31);
            this.createBtn.TabIndex = 5;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.SystemColors.Control;
            this.prevBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevBtn.ForeColor = System.Drawing.Color.Blue;
            this.prevBtn.Location = new System.Drawing.Point(10, 34);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(43, 31);
            this.prevBtn.TabIndex = 0;
            this.prevBtn.Text = "<";
            this.prevBtn.UseVisualStyleBackColor = false;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.SystemColors.Control;
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.ForeColor = System.Drawing.Color.Blue;
            this.nextBtn.Location = new System.Drawing.Point(952, 34);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(43, 31);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.Text = ">";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // previewpanel
            // 
            this.previewpanel.Location = new System.Drawing.Point(80, 0);
            this.previewpanel.Name = "previewpanel";
            this.previewpanel.Size = new System.Drawing.Size(850, 100);
            this.previewpanel.TabIndex = 2;
            // 
            // warnlbl
            // 
            this.warnlbl.AutoSize = true;
            this.warnlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warnlbl.ForeColor = System.Drawing.Color.Red;
            this.warnlbl.Location = new System.Drawing.Point(762, 142);
            this.warnlbl.Name = "warnlbl";
            this.warnlbl.Size = new System.Drawing.Size(0, 24);
            this.warnlbl.TabIndex = 6;
            // 
            // showLbl
            // 
            this.showLbl.AutoSize = true;
            this.showLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.showLbl.Location = new System.Drawing.Point(18, 256);
            this.showLbl.Name = "showLbl";
            this.showLbl.Size = new System.Drawing.Size(0, 25);
            this.showLbl.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 597);
            this.Controls.Add(this.showLbl);
            this.Controls.Add(this.warnlbl);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previewTB);
            this.Controls.Add(this.totalTB);
            this.Controls.Add(this.containerPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.containerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.TextBox totalTB;
        private System.Windows.Forms.TextBox previewTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Panel previewpanel;
        private System.Windows.Forms.Label warnlbl;
        private System.Windows.Forms.Label showLbl;
    }
}

