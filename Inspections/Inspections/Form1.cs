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
        private int lastWindow;
        private enum LastWindow { Box, Pole, Inspection };

        public Form1()
        {
            InitializeComponent();
            listTabs.Controls.Remove(inspectionsTab);
            listTabs.Controls.Remove(boxesTab);
            listTabs.Controls.Remove(registerTab);
            InsertValuesInGrids();
        }

        private void PolesPictureBox_Click(object sender, EventArgs e)
        {
            lastWindow = (int)LastWindow.Pole;
            if (listTabs.Controls.Contains(registerTab))
            {
                DialogResult dr = MessageBox.Show("Deseja cancelar a inclusão?", "Voltar", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    listTabs.Controls.Remove(registerTab);
            }

            if (listTabs.Controls.Contains(boxesTab))
                listTabs.Controls.Remove(boxesTab);

            if (listTabs.Controls.Contains(inspectionsTab))
                listTabs.Controls.Remove(inspectionsTab);

            if (!listTabs.Controls.Contains(polesTab))
            {
                insertNewPictureBox.Image = Properties.Resources.incluir;
                deleteRegisterPictureBox.Image = Properties.Resources.excluir;
                listTabs.Controls.Add(polesTab);
            }
            
        }

        private void InspectionsPictureBox_Click(object sender, EventArgs e)
        {
            lastWindow = (int)LastWindow.Inspection;

            if (listTabs.Controls.Contains(registerTab))
            {
                DialogResult dr = MessageBox.Show("Deseja cancelar a inclusão?", "Voltar", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    listTabs.Controls.Remove(registerTab);
            }

            if (listTabs.Controls.Contains(boxesTab))
                listTabs.Controls.Remove(boxesTab);

            if (listTabs.Controls.Contains(polesTab))
                listTabs.Controls.Remove(polesTab);

            if (!listTabs.Controls.Contains(inspectionsTab))
            {
                deleteRegisterPictureBox.Image = Properties.Resources.excluir;
                insertNewPictureBox.Image = Properties.Resources.incluir;
                listTabs.Controls.Add(inspectionsTab);
            }
            
        }

        private void EnergyBoxPictureBox_Click(object sender, EventArgs e)
        {
            lastWindow = (int)LastWindow.Box;
            if (listTabs.Controls.Contains(registerTab))
            {
                DialogResult dr = MessageBox.Show("Deseja cancelar a inclusão?", "Voltar", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    listTabs.Controls.Remove(registerTab);
            }
            if (listTabs.Controls.Contains(inspectionsTab))
                listTabs.Controls.Remove(inspectionsTab);

            if (listTabs.Controls.Contains(polesTab))
                listTabs.Controls.Remove(polesTab);

            if (!listTabs.Controls.Contains(boxesTab))
            {
                listTabs.Controls.Add(boxesTab);
                deleteRegisterPictureBox.Image = Properties.Resources.excluir;
                insertNewPictureBox.Image = Properties.Resources.incluir;
            }
            
            
        }

        private void InsertValuesInGrids()
        {
            var polesList = from pole in Pole.Poles()
                            orderby pole.Id
                            select new
                            {
                                Código = pole.Id,
                                Altura = pole.Height,
                                pole.Material,
                                Localização = pole.Latitude + ":" + pole.Longitude,
                                Caixa = pole.BoxID
                            };
            poleGridView.DataSource = polesList.ToList();

            var boxesList = from box in Box.Boxes()
                            orderby box.Id
                            select new
                            {
                                Código = box.Id,
                                Tipo = box.GetBoxType(),
                                box.Watts,
                                Localização = box.Latitude + ":" + box.Longitude,

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

        private void InsertNewRegister_Click(object sender, EventArgs e)
        {
            if (!listTabs.Controls.Contains(registerTab))
            {
                deleteRegisterPictureBox.Image = Properties.Resources.voltar;
                insertNewPictureBox.Image = Properties.Resources.salvar;

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
                if (!listTabs.Controls.Contains(registerTab))
                    listTabs.Controls.Add(registerTab);

            }
            else

            {
                if (typeRegistration.Text == "Poste")
                {
                    MessageBox.Show("Poste");
                }
                if (typeRegistration.Text == "Caixa")
                {
                    int boxID = Convert.ToInt32(boxIdTextBox.Text);
                    char boxType = Convert.ToChar(boxTypeComboBox.Text);
                    int boxWatts = Convert.ToInt32(boxWattsTextBox.Text);
                    double boxLat = Convert.ToDouble(boxLatitudeTextBox.Text);
                    double boxLong = Convert.ToDouble(boxLongitudeTextBox.Text);


                }
                if (typeRegistration.Text == "Inspeção")
                {
                    MessageBox.Show("Inspeção");
                }
            }
        }

        private void TypeRegistration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeRegistration.Text.Equals("Caixa"))
            {
                lastWindow = (int)LastWindow.Box;
                boxIdTextBox.Text = "";
                boxTypeComboBox.Text = "[Selecione]";
                boxWattsTextBox.Text = "";
                boxLatitudeTextBox.Text = "";
                boxLongitudeTextBox.Text = "";
                boxRegister.Visible = true;
                poleRegister.Visible = false;
                inspectionRegister.Visible = false;
            }
            else if (typeRegistration.Text.Equals("Poste"))
            {
                lastWindow = (int)LastWindow.Pole;
                poleIdTextBox.Text = "";
                poleHeightTextBox.Text = "";
                poleMaterialComboBox.Text = "";
                poleLatitudeTextBox.Text = "";
                poleLongitudeTextBox.Text = "";
                poleBoxIdTextBox.Text = "";
                poleRegister.Visible = true;
                boxRegister.Visible = false;
                inspectionRegister.Visible = false;
            }
            else if (typeRegistration.Text.Equals("Inspeção"))
            {
                lastWindow = (int)LastWindow.Inspection;
                inspectionPoleIdTextBox.Text = "";
                inspectionSituationComboBox.Text = "[Selecione]";
                inspectionBobComboBox.Text = "[Selecione]";
                inspectionWiringComboBox.Text = "[Selecione]";
                inspectionDate.Text = "";
                inspectionRegister.Visible = true;
                boxRegister.Visible = false;
                poleRegister.Visible = false;
            }
        }

        private void DeleteRegisterPictureBox_Click(object sender, EventArgs e)
        {
            if (listTabs.Controls.Contains(registerTab))
            {
                
                DialogResult dr = MessageBox.Show("Deseja cancelar a inclusão?", "Voltar", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    if (lastWindow == (int)LastWindow.Box)
                    {
                        listTabs.Controls.Add(boxesTab);
                    }
                    if (lastWindow == (int)LastWindow.Pole)
                    {
                        listTabs.Controls.Add(polesTab);
                    }
                    if (lastWindow == (int)LastWindow.Inspection)
                    {
                        listTabs.Controls.Add(inspectionsTab);
                    }
                    listTabs.Controls.Remove(registerTab);
                    insertNewPictureBox.Image = Properties.Resources.incluir;
                    deleteRegisterPictureBox.Image = Properties.Resources.excluir;
                }
            }
        }
    }
}
