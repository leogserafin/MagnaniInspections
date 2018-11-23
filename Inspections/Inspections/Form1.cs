﻿using System;
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
            listTabs.Controls.Remove(registerTab);

            insertValuesInGrids();
        }

        private void polesPictureBox_Click(object sender, EventArgs e)
        {
            listTabs.Controls.Remove(boxesTab);
            listTabs.Controls.Remove(inspectionsTab);
            listTabs.Controls.Remove(polesTab);
            listTabs.Controls.Remove(registerTab);
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
            listTabs.Controls.Remove(registerTab);
            listTabs.Controls.Add(inspectionsTab);
        }

        private void energyBoxPictureBox_Click(object sender, EventArgs e)
        {
            listTabs.Controls.Remove(polesTab);
            listTabs.Controls.Remove(inspectionsTab);
            listTabs.Controls.Remove(boxesTab);
            listTabs.Controls.Remove(registerTab);
            listTabs.Controls.Add(boxesTab);
        }

        private void insertValuesInGrids()
        {
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

            var boxesList = from box in Box.Boxes()
                            orderby box.id
                            select new
                            {
                                Código = box.id,
                                Tipo = box.type,
                                Watts = box.watts,
                                Localização = box.latitude + ":" + box.longitude,

                            };
            boxGridView.DataSource = boxesList.ToList();

            var inspectionsList = from inspection in Inspection.Inspections()
                                  orderby inspection.id
                                  select new
                                  {
                                      Código = inspection.id,
                                      Estado = inspection.poleSituation,
                                      Fiação = inspection.poleWiring,
                                      Prumo = inspection.bob,
                                      Data = inspection.date

                                  };
            inspectionGridView.DataSource = inspectionsList.ToList();
        }

        private void insertNewPole_Click(object sender, EventArgs e)
        {
            listTabs.Controls.Remove(polesTab);
            listTabs.Controls.Remove(inspectionsTab);
            listTabs.Controls.Remove(boxesTab);
            listTabs.Controls.Add(registerTab);
        }
    }
}
