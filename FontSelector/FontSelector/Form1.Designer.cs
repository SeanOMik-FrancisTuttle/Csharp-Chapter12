namespace FontSelector {
    partial class Form1 {
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
            this.listBoxFont = new System.Windows.Forms.ListBox();
            this.listBoxSize = new System.Windows.Forms.ListBox();
            this.showBtn = new System.Windows.Forms.Button();
            this.exmapleText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxFont
            // 
            this.listBoxFont.FormattingEnabled = true;
            this.listBoxFont.Items.AddRange(new object[] {
            "Microsoft TaiLe",
            "Microsoft Uighur",
            "Microsoft YaHei",
            "Sylfaen"});
            this.listBoxFont.Location = new System.Drawing.Point(67, 21);
            this.listBoxFont.Name = "listBoxFont";
            this.listBoxFont.Size = new System.Drawing.Size(120, 95);
            this.listBoxFont.TabIndex = 0;
            // 
            // listBoxSize
            // 
            this.listBoxSize.FormattingEnabled = true;
            this.listBoxSize.Items.AddRange(new object[] {
            "18",
            "20",
            "12",
            "8"});
            this.listBoxSize.Location = new System.Drawing.Point(234, 21);
            this.listBoxSize.Name = "listBoxSize";
            this.listBoxSize.Size = new System.Drawing.Size(120, 95);
            this.listBoxSize.TabIndex = 1;
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(173, 122);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(75, 23);
            this.showBtn.TabIndex = 2;
            this.showBtn.Text = "Show Example";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // exmapleText
            // 
            this.exmapleText.AutoSize = true;
            this.exmapleText.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exmapleText.Location = new System.Drawing.Point(176, 159);
            this.exmapleText.Name = "exmapleText";
            this.exmapleText.Size = new System.Drawing.Size(69, 30);
            this.exmapleText.TabIndex = 3;
            this.exmapleText.Text = "Hello";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 207);
            this.Controls.Add(this.exmapleText);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.listBoxSize);
            this.Controls.Add(this.listBoxFont);
            this.Name = "Form1";
            this.Text = "Font Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFont;
        private System.Windows.Forms.ListBox listBoxSize;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Label exmapleText;
    }
}

