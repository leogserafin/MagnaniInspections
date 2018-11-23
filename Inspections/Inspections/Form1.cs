using System;
using Inspections.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inspections
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            listTabs.Controls.Remove(inspectionsTab);
            listTabs.Controls.Remove(boxesTab);

            var polesList = from pole in Pole.Poles()
                       orderby pole.id
                       select new
                       {
                           Código = pole.id,
                           Altura = pole.height,
                           Material = pole.material,
                           Localização = pole.latitude + ":" + pole.longitude,
                           Caixa = pole.boxID
                       };
            poleGridView.DataSource = polesList.ToList();

        }

        private void polesPictureBox_Click(object sender, EventArgs e)
        {
            listTabs.Controls.Remove(boxesTab);
            listTabs.Controls.Remove(inspectionsTab);
            listTabs.Controls.Remove(polesTab);
            listTabs.Controls.Add(polesTab);
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void inspectionsPictureBox_Click(object sender, EventArgs e)
        {
            listTabs.Controls.Remove(boxesTab);
            listTabs.Controls.Remove(polesTab);
            listTabs.Controls.Remove(inspectionsTab);
            listTabs.Controls.Add(inspectionsTab);
        }

        private void energyBoxPictureBox_Click(object sender, EventArgs e)
        {
            listTabs.Controls.Remove(polesTab);
            listTabs.Controls.Remove(inspectionsTab);
            listTabs.Controls.Remove(boxesTab);
            listTabs.Controls.Add(boxesTab);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
