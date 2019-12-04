using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveColors {
    public partial class FiveColors : Form {
        public FiveColors() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.BackColor = System.Drawing.Color.Orange;
        }

        private void purpleButton_Click(object sender, EventArgs e) {
            this.BackColor = System.Drawing.Color.Purple;
        }

        private void whiteButton_Click(object sender, EventArgs e) {
            this.BackColor = System.Drawing.Color.White;
        }

        private void greyButton_Click(object sender, EventArgs e) {
            this.BackColor = System.Drawing.Color.Gray;
        }

        private void blackButton_Click(object sender, EventArgs e) {
            this.BackColor = System.Drawing.Color.Black;
        }
    }
}
