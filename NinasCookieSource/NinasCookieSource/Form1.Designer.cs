namespace NinasCookieSource {
    partial class NinasCookieSourceForm {
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
            this.listBoxCookie = new System.Windows.Forms.ListBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxAmount = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.costLbl = new System.Windows.Forms.Label();
            this.deliveryDateLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxCookie
            // 
            this.listBoxCookie.FormattingEnabled = true;
            this.listBoxCookie.Items.AddRange(new object[] {
            "Chocolate Chip",
            "Peanut Butter",
            "Oatmeal Rasin"});
            this.listBoxCookie.Location = new System.Drawing.Point(19, 33);
            this.listBoxCookie.Name = "listBoxCookie";
            this.listBoxCookie.Size = new System.Drawing.Size(120, 95);
            this.listBoxCookie.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(37, 168);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Delivery Date:";
            // 
            // listBoxAmount
            // 
            this.listBoxAmount.FormattingEnabled = true;
            this.listBoxAmount.Items.AddRange(new object[] {
            "One-half",
            "One Dozen",
            "Two Dozen",
            "Three Dozen"});
            this.listBoxAmount.Location = new System.Drawing.Point(162, 33);
            this.listBoxAmount.Name = "listBoxAmount";
            this.listBoxAmount.Size = new System.Drawing.Size(120, 95);
            this.listBoxAmount.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(19, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cookie Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(162, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Show Cost and Delivery Date";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // costLbl
            // 
            this.costLbl.Location = new System.Drawing.Point(92, 372);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(117, 13);
            this.costLbl.TabIndex = 8;
            this.costLbl.Text = "Cost: $XX.XX";
            this.costLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // deliveryDateLbl
            // 
            this.deliveryDateLbl.AutoSize = true;
            this.deliveryDateLbl.Location = new System.Drawing.Point(79, 395);
            this.deliveryDateLbl.Name = "deliveryDateLbl";
            this.deliveryDateLbl.Size = new System.Drawing.Size(143, 13);
            this.deliveryDateLbl.TabIndex = 9;
            this.deliveryDateLbl.Text = "Delivery Date: XX/XX/XXXX";
            // 
            // NinasCookieSourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 422);
            this.Controls.Add(this.deliveryDateLbl);
            this.Controls.Add(this.costLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.listBoxCookie);
            this.Name = "NinasCookieSourceForm";
            this.Text = "The Cookie Source";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCookie;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.Label deliveryDateLbl;
    }
}

