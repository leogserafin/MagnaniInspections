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

        private void insertNewRegister_Click(object sender, EventArgs e)
        {
            if (listTabs.Controls.Contains(polesTab))
            {
                listTabs.Controls.Remove(polesTab);
                typeRegistration.Text = "Poste";
            }
            if (listTabs.Controls.Contains(boxesTab))
            {
                listTabs.Controls.Remove(boxesTab);
                typeRegistration.Text = "Caixa";
            }
            if (listTabs.Controls.Contains(inspectionsTab))
            {
                listTabs.Controls.Remove(inspectionsTab);
                typeRegistration.Text = "Inspeção";
            }
            listTabs.Controls.Add(registerTab);
        }

        private void typeRegistration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeRegistration.Text.Equals("Caixa"))
            {
                boxRegister.Visible = true;
                poleRegister.Visible = false;
                inspectionRegister.Visible = false;
                boxRegister.BringToFront();
            }
            else if (typeRegistration.Text.Equals("Poste"))
            {
                poleIdTextBox.Text = "";
                poleHeightTextBox.Text = "";
                poleMaterialComboBox.Text = "";
                poleLatitudeTextBox.Text = "";
                poleLongitudeTextBox.Text = "";
                poleBoxIdTextBox.Text = "";
                poleRegister.Visible = true;
                boxRegister.Visible = false;
                inspectionRegister.Visible = false;
                poleRegister.BringToFront();
            }
            else if (typeRegistration.Text.Equals("Inspeção"))
            {
                inspectionRegister.Visible = true;
                boxRegister.Visible = false;
                poleRegister.Visible = false;
                inspectionRegister.BringToFront();
            }
        }

    }
}
