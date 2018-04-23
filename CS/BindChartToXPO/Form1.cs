using System;
using System.Windows.Forms;
using DevExpress.Xpo;
// ...

namespace BindChartToXPO {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            for (int i = 1; i < 11; i++) {
                SeriesRecord record = new SeriesRecord();
                record.ArgumentMember = "Item " + i.ToString();
                record.ValueMember = i;
                xpCollection1.Add(record);
            }
        }

        public class SeriesRecord : XPObject {
            public string ArgumentMember;
            public int ValueMember;
        }

    }
}