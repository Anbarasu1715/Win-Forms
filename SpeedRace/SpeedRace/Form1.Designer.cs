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
            this.WarningLabel = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.addCarBtn = new System.Windows.Forms.Button();
            this.actionsTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreCardBox = new System.Windows.Forms.RichTextBox();
            this.carSpec1 = new SpeedRace.CarSpec();
            this.racingTrackPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // racingTrackPanel
            // 
            this.racingTrackPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.racingTrackPanel.Controls.Add(this.carSpec1);
            this.racingTrackPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.racingTrackPanel.Location = new System.Drawing.Point(0, 0);
            this.racingTrackPanel.Margin = new System.Windows.Forms.Padding(4);
            this.racingTrackPanel.Name = "racingTrackPanel";
            this.racingTrackPanel.Size = new System.Drawing.Size(705, 870);
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
            this.controlPanel.Location = new System.Drawing.Point(773, 55);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(4);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(400, 777);
            this.controlPanel.TabIndex = 1;
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(119, 556);
            this.WarningLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(0, 29);
            this.WarningLabel.TabIndex = 6;
            this.WarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(124, 700);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(4);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(181, 53);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Reset Cars";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // addCarBtn
            // 
            this.addCarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCarBtn.Location = new System.Drawing.Point(124, 622);
            this.addCarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.Size = new System.Drawing.Size(181, 53);
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
            this.actionsTextBox.Location = new System.Drawing.Point(0, 263);
            this.actionsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.actionsTextBox.Name = "actionsTextBox";
            this.actionsTextBox.ReadOnly = true;
            this.actionsTextBox.Size = new System.Drawing.Size(399, 251);
            this.actionsTextBox.TabIndex = 3;
            this.actionsTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Control Actions";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(137, 16);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(104, 20);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Score Card";
            // 
            // scoreCardBox
            // 
            this.scoreCardBox.BackColor = System.Drawing.SystemColors.Window;
            this.scoreCardBox.CausesValidation = false;
            this.scoreCardBox.Location = new System.Drawing.Point(0, 39);
            this.scoreCardBox.Margin = new System.Windows.Forms.Padding(4);
            this.scoreCardBox.Name = "scoreCardBox";
            this.scoreCardBox.ReadOnly = true;
            this.scoreCardBox.Size = new System.Drawing.Size(399, 170);
            this.scoreCardBox.TabIndex = 0;
            this.scoreCardBox.Text = "";
            this.scoreCardBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.scoreCardBox_KeyDown);
            this.scoreCardBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.scoreCardBox_KeyPress);
            // 
            // carSpec1
            // 
            this.carSpec1.Location = new System.Drawing.Point(12, 148);
            this.carSpec1.Name = "carSpec1";
            this.carSpec1.Size = new System.Drawing.Size(675, 430);
            this.carSpec1.TabIndex = 0;
            this.carSpec1.Visible = false;
            this.carSpec1.Load += new System.EventHandler(this.carSpec1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 870);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.racingTrackPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1231, 917);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1231, 917);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.racingTrackPanel.ResumeLayout(false);
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
        private CarSpec carSpec1;
    }
}

