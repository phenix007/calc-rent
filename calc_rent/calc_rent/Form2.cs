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
        bool save = true;
        public Form2()
        {
            InitializeComponent();
        }
        void savef()
        {
            newflat.number = (int)roomn.Value;
            newflat.area = (int)areanum.Value;
            newflat.inhabitants = (int)hnum.Value;
            newflat.floor = (int)floornum.Value;
            newflat.ren.price = float.Parse(rennum.Text);
            newflat.ren.exists = renc.Checked;
            newflat.cleanup.exists = cleanupc.Checked;
            newflat.elev.exists = elevc.Checked;
            newflat.elev.price = float.Parse(elevnum.Text);
            newflat.heat.exists = heatc.Checked;
            newflat.heat.price = float.Parse(heatnum.Text);
            newflat.misc.exists = miscc.Checked;
            newflat.elec.exists = elec.Checked;
            newflat.elec.metered = elecmeter.Checked;
            newflat.hotwater.exists = hotwater.Checked;
            newflat.hotwater.metered = hotwatermeter.Checked;
            newflat.coldwater.exists = coldwater.Checked;
            newflat.coldwater.metered = coldwatermeter.Checked;
            newflat.gas.exists = gas.Checked;
            newflat.gas.metered = gasmeter.Checked;
            newflat.misc.price = float.Parse(miscnum.Text);
            newflat.cleanup.price = float.Parse(cleanupnum.Text);
        }
        public void getFlat(out Flat inf){
            newflat = new Flat();
            this.Show();
            newflat = new Flat();
            
            while (!done)
                Application.DoEvents();

            savef();
            
            if (save)
                inf = newflat;
            else inf = new Flat();
            this.Close();
        }
        public void editFlat(ref Flat inf)
        {
           
            this.Show();
            newflat = inf;
            roomn.Value = newflat.number;
            areanum.Value = newflat.area;
            hnum.Value = newflat.inhabitants;
            floornum.Value = newflat.floor;
            renc.Checked = newflat.ren.exists;
            rennum.Text = newflat.ren.price.ToString();
            cleanupc.Checked = newflat.cleanup.exists;
            cleanupnum.Text = newflat.cleanup.price.ToString();
            elevc.Checked = newflat.elev.exists;
            elevnum.Text = newflat.elev.price.ToString();
            heatc.Checked = newflat.heat.exists;
            heatnum.Text = newflat.heat.price.ToString();
            miscc.Checked = newflat.misc.exists;
            miscnum.Text = newflat.misc.price.ToString();
            elec.Checked = newflat.elec.exists;
            elecmeter.Checked = newflat.elec.metered;
            hotwater.Checked = newflat.hotwater.exists;
            hotwatermeter.Checked = newflat.hotwater.metered;
            coldwater.Checked = newflat.coldwater.exists;
            coldwatermeter.Checked = newflat.coldwater.metered;
            gas.Checked = newflat.gas.exists;
            gasmeter.Checked = newflat.gas.metered;

            while (!done)
                Application.DoEvents();
            if (save)
                savef();
            this.Close();
        }
        private void Accept_Click(object sender, EventArgs e)
        {
            done = true;
        }

        
        private void renc_CheckedChanged(object sender, EventArgs e)
        {
            rennum.Enabled =renc.Checked;
            
        }

        private void cleanupc_CheckedChanged(object sender, EventArgs e)
        {
            cleanupnum.Enabled = cleanupc.Checked;
            
        }

        private void elevc_CheckedChanged(object sender, EventArgs e)
        {
            elevnum.Enabled = elevc.Checked;
            
        }

       
        private void heatc_CheckedChanged(object sender, EventArgs e)
        {
            
            heatnum.Enabled = heatc.Checked;
        }

       
        private void miscc_CheckedChanged(object sender, EventArgs e)
        {
            
            miscnum.Enabled = miscc.Checked;
        }

   
        private void cancel_Click(object sender, EventArgs e)
        {

            save = false;
            done = true;
        }
    }
}
