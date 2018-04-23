using System;
using System.Windows.Forms;

namespace RepOverrideRtfFormatting {
    public partial class Form1 : Form {
        private XtraReport1 report = new XtraReport1();
        
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            report.OverrideRtfFormatting = checkBox1.Checked;
            report.CreateDocument();
            report.ShowPreviewDialog();
        }
    }
}