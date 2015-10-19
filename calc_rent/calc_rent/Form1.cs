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
        Flat flat;
        public Form1()
        {
            InitializeComponent();
        }

        private void новаяКвартираToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 _new = new Form2();
            this.Enabled = false;
                _new.getFlat(out flat);
                this.Enabled = true;
                this.Focus();
            
        }

        private void редактироватьСвваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 edit = new Form2();
            this.Enabled = false;
            edit.editFlat(ref flat);
            this.Enabled = true;
            this.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
