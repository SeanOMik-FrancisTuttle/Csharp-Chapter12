using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealer {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        static Dictionary<string, Form> _car_form = new Dictionary<string, Form> {
            {"Ford Probe", new FordProbeForm()},
            {"Pontiac Firebird", new PontiacFirebirdForm()},
            {"Honda Civic", new HondaCivicFord()}
        };

        private void viewCarBtn_Click(object sender, EventArgs e) {
            try {
                if (_car_form.TryGetValue(carListbox.SelectedItem.ToString(), out Form form)) {
                    form.Show();
                }
            }
            catch (Exception exception) { }
        }
    }
}
