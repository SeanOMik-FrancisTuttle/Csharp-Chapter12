namespace FiveColors {
    partial class FiveColors {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.orangeButton = new System.Windows.Forms.Button();
            this.purpleButton = new System.Windows.Forms.Button();
            this.whiteButton = new System.Windows.Forms.Button();
            this.greyButton = new System.Windows.Forms.Button();
            this.blackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orangeButton
            // 
            this.orangeButton.Location = new System.Drawing.Point(61, 13);
            this.orangeButton.Name = "orangeButton";
            this.orangeButton.Size = new System.Drawing.Size(75, 23);
            this.orangeButton.TabIndex = 0;
            this.orangeButton.Text = "Orange";
            this.orangeButton.UseVisualStyleBackColor = true;
            this.orangeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // purpleButton
            // 
            this.purpleButton.Location = new System.Drawing.Point(61, 42);
            this.purpleButton.Name = "purpleButton";
            this.purpleButton.Size = new System.Drawing.Size(75, 23);
            this.purpleButton.TabIndex = 1;
            this.purpleButton.Text = "Purple";
            this.purpleButton.UseVisualStyleBackColor = true;
            this.purpleButton.Click += new System.EventHandler(this.purpleButton_Click);
            // 
            // whiteButton
            // 
            this.whiteButton.Location = new System.Drawing.Point(61, 71);
            this.whiteButton.Name = "whiteButton";
            this.whiteButton.Size = new System.Drawing.Size(75, 23);
            this.whiteButton.TabIndex = 2;
            this.whiteButton.Text = "White";
            this.whiteButton.UseVisualStyleBackColor = true;
            this.whiteButton.Click += new System.EventHandler(this.whiteButton_Click);
            // 
            // greyButton
            // 
            this.greyButton.Location = new System.Drawing.Point(61, 100);
            this.greyButton.Name = "greyButton";
            this.greyButton.Size = new System.Drawing.Size(75, 23);
            this.greyButton.TabIndex = 3;
            this.greyButton.Text = "Grey";
            this.greyButton.UseVisualStyleBackColor = true;
            this.greyButton.Click += new System.EventHandler(this.greyButton_Click);
            // 
            // blackButton
            // 
            this.blackButton.Location = new System.Drawing.Point(61, 129);
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(75, 23);
            this.blackButton.TabIndex = 4;
            this.blackButton.Text = "Black";
            this.blackButton.UseVisualStyleBackColor = true;
            this.blackButton.Click += new System.EventHandler(this.blackButton_Click);
            // 
            // FiveColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(196, 164);
            this.Controls.Add(this.blackButton);
            this.Controls.Add(this.greyButton);
            this.Controls.Add(this.whiteButton);
            this.Controls.Add(this.purpleButton);
            this.Controls.Add(this.orangeButton);
            this.Name = "FiveColors";
            this.Text = "Five Colors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button orangeButton;
        private System.Windows.Forms.Button purpleButton;
        private System.Windows.Forms.Button whiteButton;
        private System.Windows.Forms.Button greyButton;
        private System.Windows.Forms.Button blackButton;
    }
}

