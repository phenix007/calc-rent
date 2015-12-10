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

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.Xml.Serialization.XmlSerializer writer =
                   new System.Xml.Serialization.XmlSerializer(flat.GetType());
                System.IO.StreamWriter file =
                   new System.IO.StreamWriter(sfd.FileName);

                writer.Serialize(file, flat);
                file.Close();
            }
            
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Flat));

                System.IO.StreamReader reader = new System.IO.StreamReader(ofd.FileName);
                flat = (Flat)serializer.Deserialize(reader);
                reader.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Width = 824;
            this.Height = 392;
            itog.Clear();
            itog.AppendText("Вывоз мусора:" + 30 + '\n');
            itog.AppendText("Обслуживание лифта:" + 30 + '\n');
            itog.AppendText("Ремонт здания:" + 70 + '\n');
            elect = Convert.ToSingle(electr.Text) * Convert.ToSingle(textBox5.Text);
            itog.AppendText("За электричество:" + elect.ToString() + '\n');

            if (!GasCB.Checked) gas = Convert.ToSingle(gast.Text);
            else gas = Convert.ToSingle(gast.Text) * Convert.ToSingle(textBox4.Text);
            itog.AppendText("За газ:" + gas.ToString() + '\n');

            if (!HotW.Checked) hwater = Convert.ToSingle(hwatert.Text);
            else hwater = Convert.ToSingle(hwatert.Text) * Convert.ToSingle(textBox3.Text);
            itog.AppendText("За горячую воду:" + hwater.ToString() + '\n');

            if (!ColW.Checked) cwater = Convert.ToSingle(cwatert.Text);
            else cwater = Convert.ToSingle(cwatert.Text) * Convert.ToSingle(textBox2.Text);
            itog.AppendText("За холодную воду:" + cwater.ToString() + '\n');

            otopl = Convert.ToSingle(otoplt.Text) * Convert.ToSingle(pl.Value);
            itog.AppendText("За отопление:" + otopl.ToString() + '\n');
            comm = (otopl + hwater + cwater + gas + elect) * Convert.ToSingle(cH.Value);
            itog.AppendText("Comm:" + comm.ToString() + '\n');
            if ((lift.Checked) && (rubb.Checked) && (rep.Checked))
            {
                result = comm + lif + repair + musor;
                itog.AppendText("Итого(лифт,мусор,газ):" + result.ToString() + '\n');
            }
            else if ((lift.Checked) && (rubb.Checked))
            {
                result = comm + lif + musor;
                itog.AppendText("Итого(лифт,мусор):" + result.ToString() + '\n');
            }
            else if ((lift.Checked) && (rep.Checked))
            {
                result = comm + lif + repair;
                itog.AppendText("Итого(лифт,ремонт):" + result.ToString() + '\n');
            }
            else if ((rubb.Checked) && (rep.Checked))
            {
                result = comm + repair + musor;
                itog.AppendText("Итого(мусор,ремонт):" + result.ToString() + '\n');
            }
            else if (lift.Checked)
            {
                result = comm + lif;
                itog.AppendText("Итого(лифт):" + result.ToString() + '\n');
            }
            else if (rubb.Checked)
            {
                result = comm + musor;
                itog.AppendText("Итого(мусор):" + result.ToString() + '\n');
            }
            else if (rep.Checked)
            {
                result = comm + repair;
                itog.AppendText("Итого(ремонт):" + result.ToString() + '\n');
            }
            else
            {
                result = comm;
                itog.AppendText("Итого():" + result.ToString() + '\n');

            }
        }

    }
}
