using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveColors2 {
    public partial class fiveColors2 : Form {
        public fiveColors2() {
            InitializeComponent();
        }

        private void orangeRadio_CheckedChanged(object sender, EventArgs e) {
            this.BackColor = System.Drawing.Color.Orange;
        }

        private void purpleRadio_CheckedChanged(object sender, EventArgs e) {
            this.BackColor = System.Drawing.Color.Purple;
        }

        private void whiteRadio_CheckedChanged(object sender, EventArgs e) {
            this.BackColor = System.Drawing.Color.White;
        }

        private void blackRadio_CheckedChanged(object sender, EventArgs e) {
            this.BackColor = System.Drawing.Color.Black;
        }

        private void greenRadio_CheckedChanged(object sender, EventArgs e) {
            this.BackColor = System.Drawing.Color.Green;
        }
    }
}
