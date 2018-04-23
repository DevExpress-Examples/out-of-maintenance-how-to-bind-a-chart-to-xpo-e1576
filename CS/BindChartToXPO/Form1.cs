using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;

namespace BindChartToXPO {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            for (int i = 1; i < 11; i++) {
                SeriesRecord record = new SeriesRecord();
                record.Argument = "Item " + i.ToString();
                record.Value = i;
                xpCollection1.Add(record);
            }

        }
    }

    public class SeriesRecord : XPObject {
        public string Argument;
        public int Value;
    }

}
