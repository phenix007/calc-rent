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
    public partial class Form2 : Form
    {
        Flat newflat;
        bool done = false;
        public Form2()
        {
            InitializeComponent();
        }
        public void getFlat(out Flat inf){
            newflat = new Flat();
            this.Show();
            newflat = new Flat();
            
            while (!done)
                Application.DoEvents();
            inf = newflat;
            this.Dispose();
        }
        public void editFlat(ref Flat inf)
        {
           
            this.Show();
            newflat = inf;
            elevc.Checked = true;
            while (!done)
                Application.DoEvents();
            this.Dispose();
        }
        private void Accept_Click(object sender, EventArgs e)
        {
            done = true;
        }

        private void roomn_ValueChanged(object sender, EventArgs e)
        {
            newflat.number = (int)roomn.Value;
        }

        private void areanum_ValueChanged(object sender, EventArgs e)
        {
            newflat.area = (int)areanum.Value;
        }

        private void hnum_ValueChanged(object sender, EventArgs e)
        {
            newflat.inhabitants = (int)hnum.Value;
        }

        private void floornum_ValueChanged(object sender, EventArgs e)
        {
            newflat.floor = (int)floornum.Value;
        }

        private void rennum_ValueChanged(object sender, EventArgs e)
        {
            newflat.ren.price = (int)rennum.Value;
        }

        private void renc_CheckedChanged(object sender, EventArgs e)
        {
            rennum.Enabled =renc.Checked;
            newflat.ren.exists = renc.Checked;
        }

        private void cleanupc_CheckedChanged(object sender, EventArgs e)
        {
            cleanupnum.Enabled = cleanupc.Checked;
            newflat.cleanup.exists = cleanupc.Checked;
        }

        private void elevc_CheckedChanged(object sender, EventArgs e)
        {
            elevnum.Enabled = elevc.Checked;
            newflat.elev.exists = elevc.Checked;
        }

        private void elevnum_ValueChanged(object sender, EventArgs e)
        {
            newflat.elev.price =(int) elevnum.Value;
        }

        private void heatc_CheckedChanged(object sender, EventArgs e)
        {
            newflat.heat.exists = heatc.Checked;
            heatnum.Enabled = heatc.Checked;
        }

        private void heatnum_ValueChanged(object sender, EventArgs e)
        {
            newflat.heat.price = (int)heatnum.Value;
        }

        private void miscc_CheckedChanged(object sender, EventArgs e)
        {
            newflat.misc.exists = miscc.Checked;
            miscnum.Enabled = miscc.Checked;
        }

        private void elec_CheckedChanged(object sender, EventArgs e)
        {
            newflat.elec.exists = elec.Checked;
        }

        private void elecmeter_CheckedChanged(object sender, EventArgs e)
        {
            newflat.elec.metered = elecmeter.Checked;
        }

        private void hotwater_CheckedChanged(object sender, EventArgs e)
        {
            newflat.hotwater.exists = hotwater.Checked;
        }

        private void hotwatermeter_CheckedChanged(object sender, EventArgs e)
        {
            newflat.hotwater.metered = hotwatermeter.Checked;
        }

        private void coldwater_CheckedChanged(object sender, EventArgs e)
        {
            newflat.coldwater.exists = coldwater.Checked;
        }

        private void coldwatermeter_CheckedChanged(object sender, EventArgs e)
        {
            newflat.coldwater.metered = coldwatermeter.Checked;
        }

        private void gas_CheckedChanged(object sender, EventArgs e)
        {
            newflat.gas.exists = gas.Checked;
        }

        private void gasmeter_CheckedChanged(object sender, EventArgs e)
        {
            newflat.gas.metered = gasmeter.Checked;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void miscnum_ValueChanged(object sender, EventArgs e)
        {
            newflat.misc.price = (int)miscnum.Value;
        }

        private void cleanupnum_ValueChanged(object sender, EventArgs e)
        {
            newflat.cleanup.price = (int)cleanupnum.Value;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
