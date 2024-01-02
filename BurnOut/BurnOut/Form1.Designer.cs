namespace BurnOut
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
            this.startBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreCardLabel = new System.Windows.Forms.Label();
            this.trackPanel = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.trackPanel);
            this.mainPanel.Controls.Add(this.controlPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(767, 634);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Resize += new System.EventHandler(this.mainPanel_Resize);
            // 
            // controlPanel
            // 
            this.controlPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.controlPanel.Controls.Add(this.scoreCardLabel);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Controls.Add(this.stopBtn);
            this.controlPanel.Controls.Add(this.pauseBtn);
            this.controlPanel.Controls.Add(this.startBtn);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlPanel.Location = new System.Drawing.Point(453, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(314, 634);
            this.controlPanel.TabIndex = 0;
            this.controlPanel.Resize += new System.EventHandler(this.controlPanel_Resize);
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(110, 342);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(93, 33);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            // 
            // pauseBtn
            // 
            this.pauseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseBtn.Location = new System.Drawing.Point(110, 401);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(93, 33);
            this.pauseBtn.TabIndex = 1;
            this.pauseBtn.Text = "Pause";
            this.pauseBtn.UseVisualStyleBackColor = true;
            // 
            // stopBtn
            // 
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.Location = new System.Drawing.Point(110, 461);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(93, 33);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score";
            // 
            // scoreCardLabel
            // 
            this.scoreCardLabel.AutoSize = true;
            this.scoreCardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreCardLabel.Location = new System.Drawing.Point(147, 105);
            this.scoreCardLabel.Name = "scoreCardLabel";
            this.scoreCardLabel.Size = new System.Drawing.Size(21, 24);
            this.scoreCardLabel.TabIndex = 4;
            this.scoreCardLabel.Text = "0";
            this.scoreCardLabel.TextChanged += new System.EventHandler(this.scoreCardLabel_TextChanged);
            // 
            // trackPanel
            // 
            this.trackPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trackPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.trackPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.trackPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.trackPanel.Location = new System.Drawing.Point(0, 0);
            this.trackPanel.Name = "trackPanel";
            this.trackPanel.Size = new System.Drawing.Size(457, 634);
            this.trackPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 634);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Label scoreCardLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Panel trackPanel;
    }
}

