using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NinasCookieSource {
    public partial class NinasCookieSourceForm : Form {
        public NinasCookieSourceForm() {
            InitializeComponent();
            monthCalendar1.MaxSelectionCount = 1;
        }

        static Dictionary<string, double> _cookie_cost = new Dictionary<string, double> {
            {"Chocolate Chip", 2.50},
            {"Peanut Butter", 3.0},
            {"Oatmeal Rasin", 1.2}
        };

        static Dictionary<string, double> _cookie_amount_cost = new Dictionary<string, double> {
            {"One-half", 2.40},
            {"One Dozen", 2.70},
            {"Two Dozen", 3.20},
            {"Three Dozen", 5.50 }
        };

        private void button1_Click(object sender, EventArgs e) {
            try {
                _cookie_cost.TryGetValue(listBoxCookie.SelectedItem.ToString(), out double base_cost);
                _cookie_amount_cost.TryGetValue(listBoxAmount.SelectedItem.ToString(), out double amount_cost);
                double total_cost = base_cost + amount_cost;

                DateTime date_time = monthCalendar1.SelectionRange.Start.AddDays(3);
                //date_time.AddDays(3);
                costLbl.Text = "Cost: " + total_cost.ToString("C");
                deliveryDateLbl.Text = "Delivery Date: " + date_time.ToString().Substring(0, 10);
            } catch (Exception exception) {

            }
        }
    }
}
