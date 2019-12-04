namespace CarDealer {
    partial class MainForm {
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
            this.carListbox = new System.Windows.Forms.ListBox();
            this.viewCarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // carListbox
            // 
            this.carListbox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.carListbox.FormattingEnabled = true;
            this.carListbox.ItemHeight = 19;
            this.carListbox.Items.AddRange(new object[] {
            "Ford Probe",
            "Pontiac Firebird",
            "Honda Civic"});
            this.carListbox.Location = new System.Drawing.Point(33, 25);
            this.carListbox.Name = "carListbox";
            this.carListbox.Size = new System.Drawing.Size(120, 80);
            this.carListbox.TabIndex = 0;
            // 
            // viewCarBtn
            // 
            this.viewCarBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.viewCarBtn.Location = new System.Drawing.Point(55, 117);
            this.viewCarBtn.Name = "viewCarBtn";
            this.viewCarBtn.Size = new System.Drawing.Size(77, 37);
            this.viewCarBtn.TabIndex = 1;
            this.viewCarBtn.Text = "View Car";
            this.viewCarBtn.UseVisualStyleBackColor = true;
            this.viewCarBtn.Click += new System.EventHandler(this.viewCarBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 178);
            this.Controls.Add(this.viewCarBtn);
            this.Controls.Add(this.carListbox);
            this.Name = "MainForm";
            this.Text = "Car Dealer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox carListbox;
        private System.Windows.Forms.Button viewCarBtn;
    }
}

