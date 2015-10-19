using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calc_rent
{
    public partial class Form1 : Form
    {
        Flat newflat;
        public Form1()
        {
            InitializeComponent();
        }

        private void новаяКвартираToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 _new = new Form2();
            
    _new.getFlat(out newflat);
            

        }
    }
}
