namespace SpeedRace
{
    partial class CarSpec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarSpec));
            this.CarSpecPanel = new System.Windows.Forms.Panel();
            this.CarImages = new System.Windows.Forms.PictureBox();
            this.forwardBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CarSpecPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarImages)).BeginInit();
            this.SuspendLayout();
            // 
            // CarSpecPanel
            // 
            this.CarSpecPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CarSpecPanel.Controls.Add(this.countryTextBox);
            this.CarSpecPanel.Controls.Add(this.label3);
            this.CarSpecPanel.Controls.Add(this.playerNameTextBox);
            this.CarSpecPanel.Controls.Add(this.label2);
            this.CarSpecPanel.Controls.Add(this.label1);
            this.CarSpecPanel.Controls.Add(this.textLabel);
            this.CarSpecPanel.Controls.Add(this.button1);
            this.CarSpecPanel.Controls.Add(this.forwardBtn);
            this.CarSpecPanel.Controls.Add(this.CarImages);
            this.CarSpecPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CarSpecPanel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarSpecPanel.Location = new System.Drawing.Point(0, 0);
            this.CarSpecPanel.Name = "CarSpecPanel";
            this.CarSpecPanel.Size = new System.Drawing.Size(637, 367);
            this.CarSpecPanel.TabIndex = 0;
            // 
            // CarImages
            // 
            this.CarImages.Location = new System.Drawing.Point(59, 103);
            this.CarImages.Name = "CarImages";
            this.CarImages.Size = new System.Drawing.Size(109, 149);
            this.CarImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CarImages.TabIndex = 0;
            this.CarImages.TabStop = false;
            this.CarImages.Click += new System.EventHandler(this.CarImages_Click);
            // 
            // forwardBtn
            // 
            this.forwardBtn.Image = ((System.Drawing.Image)(resources.GetObject("forwardBtn.Image")));
            this.forwardBtn.Location = new System.Drawing.Point(125, 258);
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.Size = new System.Drawing.Size(43, 23);
            this.forwardBtn.TabIndex = 1;
            this.forwardBtn.UseVisualStyleBackColor = true;
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(59, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(69, 78);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(93, 19);
            this.textLabel.TabIndex = 3;
            this.textLabel.Text = "Select Car";
            this.textLabel.Click += new System.EventHandler(this.textLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player Name  :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Car Specification";
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(374, 110);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(226, 28);
            this.playerNameTextBox.TabIndex = 6;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(374, 156);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(226, 28);
            this.countryTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Country           :";
            // 
            // CarSpec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CarSpecPanel);
            this.Name = "CarSpec";
            this.Size = new System.Drawing.Size(637, 368);
            this.Load += new System.EventHandler(this.CarSpec_Load);
            this.CarSpecPanel.ResumeLayout(false);
            this.CarSpecPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarImages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CarSpecPanel;
        private System.Windows.Forms.PictureBox CarImages;
        private System.Windows.Forms.Button forwardBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Label label3;
    }
}
