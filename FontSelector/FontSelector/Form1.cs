using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontSelector {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        static Dictionary<string, Font> _font_names = new Dictionary<string, Font> {
            {"Microsoft TaiLe", new Font("Microsoft TaiLe", 18)},
            {"Microsoft Uighur", new Font("Microsoft Uighur", 18)},
            {"Microsoft YaHei", new Font("Microsoft YaHei", 18)},
            {"Sylfaen", new Font("Sylfaen", 18)}
        };

        private void showBtn_Click(object sender, EventArgs e) {
            try {
                if (_font_names.TryGetValue(listBoxFont.SelectedItem.ToString(), out Font font)) {
                    exmapleText.Font = new Font(font.Name, int.Parse(listBoxSize.SelectedItem.ToString()));
                }
            } catch (Exception exception) { }
        }
    }
}