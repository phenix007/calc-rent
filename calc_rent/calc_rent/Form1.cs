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
    }
}
