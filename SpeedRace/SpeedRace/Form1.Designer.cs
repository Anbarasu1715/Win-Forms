namespace SpeedRace
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
            this.racingTrackPanel = new System.Windows.Forms.Panel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.addCarBtn = new System.Windows.Forms.Button();
            this.actionsTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreCardBox = new System.Windows.Forms.RichTextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.userControl12 = new SpeedRace.UserControl1();
            this.userControl11 = new SpeedRace.UserControl1();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // racingTrackPanel
            // 
            this.racingTrackPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.racingTrackPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.racingTrackPanel.Location = new System.Drawing.Point(0, 0);
            this.racingTrackPanel.Name = "racingTrackPanel";
            this.racingTrackPanel.Size = new System.Drawing.Size(529, 715);
            this.racingTrackPanel.TabIndex = 0;
            this.racingTrackPanel.Click += new System.EventHandler(this.racingTrackPanel_Click);
            this.racingTrackPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.racingTrackPanel_Paint);
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.WarningLabel);
            this.controlPanel.Controls.Add(this.resetBtn);
            this.controlPanel.Controls.Add(this.addCarBtn);
            this.controlPanel.Controls.Add(this.actionsTextBox);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Controls.Add(this.scoreLabel);
            this.controlPanel.Controls.Add(this.scoreCardBox);
            this.controlPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlPanel.Location = new System.Drawing.Point(580, 45);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(300, 631);
            this.controlPanel.TabIndex = 1;
            // 
            // addCarBtn
            // 
            this.addCarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCarBtn.Location = new System.Drawing.Point(93, 505);
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.Size = new System.Drawing.Size(136, 43);
            this.addCarBtn.TabIndex = 4;
            this.addCarBtn.Text = "Create Car";
            this.addCarBtn.UseVisualStyleBackColor = true;
            this.addCarBtn.Click += new System.EventHandler(this.addCarBtn_Click);
            // 
            // actionsTextBox
            // 
            this.actionsTextBox.BackColor = System.Drawing.Color.OrangeRed;
            this.actionsTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.actionsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionsTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.actionsTextBox.Location = new System.Drawing.Point(0, 214);
            this.actionsTextBox.Name = "actionsTextBox";
            this.actionsTextBox.ReadOnly = true;
            this.actionsTextBox.Size = new System.Drawing.Size(300, 205);
            this.actionsTextBox.TabIndex = 3;
            this.actionsTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Control Actions";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(103, 13);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(86, 16);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Score Card";
            // 
            // scoreCardBox
            // 
            this.scoreCardBox.BackColor = System.Drawing.SystemColors.Window;
            this.scoreCardBox.CausesValidation = false;
            this.scoreCardBox.Location = new System.Drawing.Point(0, 32);
            this.scoreCardBox.Name = "scoreCardBox";
            this.scoreCardBox.ReadOnly = true;
            this.scoreCardBox.Size = new System.Drawing.Size(300, 139);
            this.scoreCardBox.TabIndex = 0;
            this.scoreCardBox.Text = "";
            this.scoreCardBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.scoreCardBox_KeyDown);
            this.scoreCardBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.scoreCardBox_KeyPress);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(93, 569);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(136, 43);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Reset Cars";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(89, 452);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(0, 24);
            this.WarningLabel.TabIndex = 6;
            this.WarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userControl12
            // 
            this.userControl12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl12.DisplayName = "Charles";
            this.userControl12.Location = new System.Drawing.Point(548, 89);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(287, 152);
            this.userControl12.TabIndex = 3;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl11.DisplayName = "anbu";
            this.userControl11.Location = new System.Drawing.Point(548, 368);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(287, 152);
            this.userControl11.TabIndex = 2;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 715);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.racingTrackPanel);
            this.MaximumSize = new System.Drawing.Size(928, 754);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(928, 754);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel racingTrackPanel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.RichTextBox scoreCardBox;
        private System.Windows.Forms.RichTextBox actionsTextBox;
        private System.Windows.Forms.Button addCarBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label WarningLabel;
        private UserControl1 userControl11;
        private UserControl1 userControl12;
    }
}

