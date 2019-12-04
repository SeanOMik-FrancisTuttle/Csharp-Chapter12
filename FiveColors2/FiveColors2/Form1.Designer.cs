namespace FiveColors2 {
    partial class fiveColors2 {
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
            this.orangeRadio = new System.Windows.Forms.RadioButton();
            this.purpleRadio = new System.Windows.Forms.RadioButton();
            this.whiteRadio = new System.Windows.Forms.RadioButton();
            this.greenRadio = new System.Windows.Forms.RadioButton();
            this.blackRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orangeRadio
            // 
            this.orangeRadio.AutoSize = true;
            this.orangeRadio.ForeColor = System.Drawing.Color.Red;
            this.orangeRadio.Location = new System.Drawing.Point(82, 25);
            this.orangeRadio.Name = "orangeRadio";
            this.orangeRadio.Size = new System.Drawing.Size(60, 17);
            this.orangeRadio.TabIndex = 0;
            this.orangeRadio.TabStop = true;
            this.orangeRadio.Text = "Orange";
            this.orangeRadio.UseVisualStyleBackColor = true;
            this.orangeRadio.CheckedChanged += new System.EventHandler(this.orangeRadio_CheckedChanged);
            // 
            // purpleRadio
            // 
            this.purpleRadio.AutoSize = true;
            this.purpleRadio.ForeColor = System.Drawing.Color.Red;
            this.purpleRadio.Location = new System.Drawing.Point(82, 48);
            this.purpleRadio.Name = "purpleRadio";
            this.purpleRadio.Size = new System.Drawing.Size(55, 17);
            this.purpleRadio.TabIndex = 1;
            this.purpleRadio.TabStop = true;
            this.purpleRadio.Text = "Purple";
            this.purpleRadio.UseVisualStyleBackColor = true;
            this.purpleRadio.CheckedChanged += new System.EventHandler(this.purpleRadio_CheckedChanged);
            // 
            // whiteRadio
            // 
            this.whiteRadio.AutoSize = true;
            this.whiteRadio.ForeColor = System.Drawing.Color.Red;
            this.whiteRadio.Location = new System.Drawing.Point(82, 71);
            this.whiteRadio.Name = "whiteRadio";
            this.whiteRadio.Size = new System.Drawing.Size(53, 17);
            this.whiteRadio.TabIndex = 2;
            this.whiteRadio.TabStop = true;
            this.whiteRadio.Text = "White";
            this.whiteRadio.UseVisualStyleBackColor = true;
            this.whiteRadio.CheckedChanged += new System.EventHandler(this.whiteRadio_CheckedChanged);
            // 
            // greenRadio
            // 
            this.greenRadio.AutoSize = true;
            this.greenRadio.ForeColor = System.Drawing.Color.Red;
            this.greenRadio.Location = new System.Drawing.Point(82, 117);
            this.greenRadio.Name = "greenRadio";
            this.greenRadio.Size = new System.Drawing.Size(54, 17);
            this.greenRadio.TabIndex = 3;
            this.greenRadio.TabStop = true;
            this.greenRadio.Text = "Green";
            this.greenRadio.UseVisualStyleBackColor = true;
            this.greenRadio.CheckedChanged += new System.EventHandler(this.greenRadio_CheckedChanged);
            // 
            // blackRadio
            // 
            this.blackRadio.AutoSize = true;
            this.blackRadio.ForeColor = System.Drawing.Color.Red;
            this.blackRadio.Location = new System.Drawing.Point(82, 94);
            this.blackRadio.Name = "blackRadio";
            this.blackRadio.Size = new System.Drawing.Size(52, 17);
            this.blackRadio.TabIndex = 4;
            this.blackRadio.TabStop = true;
            this.blackRadio.Text = "Black";
            this.blackRadio.UseVisualStyleBackColor = true;
            this.blackRadio.CheckedChanged += new System.EventHandler(this.blackRadio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.orangeRadio);
            this.groupBox1.Controls.Add(this.blackRadio);
            this.groupBox1.Controls.Add(this.purpleRadio);
            this.groupBox1.Controls.Add(this.greenRadio);
            this.groupBox1.Controls.Add(this.whiteRadio);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(20, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 159);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Color";
            // 
            // fiveColors2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 174);
            this.Controls.Add(this.groupBox1);
            this.Name = "fiveColors2";
            this.Text = "Five Colors 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton orangeRadio;
        private System.Windows.Forms.RadioButton purpleRadio;
        private System.Windows.Forms.RadioButton whiteRadio;
        private System.Windows.Forms.RadioButton greenRadio;
        private System.Windows.Forms.RadioButton blackRadio;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

