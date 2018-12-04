using System;
using Inspections.Entities;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Inspections
{

    public partial class MainForm : Form
    {
        private int lastWindow;
        private enum Window { Box, Pole, Inspection };
        private const int BOX = 0;
        private const int POLE = 1;
        private const int INSPECTION = 2;


        public MainForm()
        { 
            InitializeComponent();
            listTabs.Controls.Remove(inspectionsTab);
            listTabs.Controls.Remove(polesTab);
            listTabs.Controls.Remove(registerTab);
            InsertValuesInGrids(Window.Box);
        }

        private void PolesPictureBox_Click(object sender, EventArgs e)
        {
            InsertValuesInGrids(Window.Pole);
            lastWindow = (int)Window.Pole;
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
            lastWindow = (int)Window.Inspection;
            InsertValuesInGrids(Window.Inspection);

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
            lastWindow = (int)Window.Box;
            InsertValuesInGrids(Window.Box);

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

        private void InsertValuesInGrids(Window window)
        {
            if (window == Window.Pole)
            {
                var polesList = from pole in Pole.Poles()
                                orderby pole.id
                                select new
                                {
                                    Código = pole.id,
                                    Altura = pole.height + "cm",
                                    Material = pole.GetMaterial(),
                                    Localização = pole.latitude + ":" + pole.longitude,
                                    Caixa = pole.boxid
                                };
                poleGridView.DataSource = polesList.ToList();
            }

            if (window == Window.Box)
            {
                var boxesList = from box in Box.Boxes()
                                orderby box.id
                                select new
                                {
                                    Código = box.id,
                                    Tipo = box.GetBoxType(),
                                    Watts = box.watts,
                                    Localização = box.latitude + ":" + box.longitude,

                                };
                boxGridView.DataSource = boxesList.ToList();
            }

            if (window == Window.Inspection)
            {
                var inspectionsList = from inspection in Inspection.Inspections()
                                      orderby inspection.id
                                      select new
                                      {
                                          Código = inspection.id,
                                          Estado = inspection.polesituation,
                                          Fiação = inspection.polewiring,
                                          Prumo = inspection.bob,
                                          Data = inspection.date,
                                          Poste = inspection.poleid
                                      };
                inspectionGridView.DataSource = inspectionsList.ToList();
            }
        }

        private void InsertNewRegister_Click(object sender, EventArgs e)
        {
            bool existsId = false;
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
                    try
                    {
                        Pole pole = new Pole
                        {
                            id = int.Parse(poleIdTextBox.Text)
                        };

                        if (pole.existsId(pole.id))
                        {
                            throw new Exception();
                        }

                        if (poleMaterialComboBox.Text == "Concreto")
                            pole.material = "C";
                        else if (poleMaterialComboBox.Text == "Metal")
                            pole.material = "F";
                        else if((poleMaterialComboBox.Text == "Madeira"))
                            pole.material = "M";
                        pole.height = int.Parse(poleHeightTextBox.Text);
                        pole.latitude = poleLatitudeTextBox.Text;
                        pole.longitude = poleLongitudeTextBox.Text;
                        pole.boxid = int.Parse(poleBoxIdTextBox.Text);

                        pole.InsertPole(pole);

                        DialogResult dr = MessageBox.Show("Poste cadastrado com sucesso! " +
                            "\nDeseja cadastrar outro poste?", "Cadastro", MessageBoxButtons.YesNo);
                        if (dr != DialogResult.Yes)
                        {
                            listTabs.Controls.Remove(registerTab);
                            listTabs.Controls.Add(polesTab);
                        }

                    }
                    catch(Exception ex)
                    {
                        if (existsId)
                            MessageBox.Show("Já existe um poste cadastrada com esta etiqueta!"); 
                        else
                            MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        InsertValuesInGrids(Window.Pole);
                    }
                }
                if (typeRegistration.Text == "Caixa")
                {
                    try
                    {
                        var box = new Box
                        {
                            id = int.Parse(boxIdTextBox.Text)
                        };

                        if (box.existsId(box.id))
                        {
                            throw new Exception();
                        }

                        if (boxTypeComboBox.Text == "Externa")
                            box.boxtype = "E";
                        if (boxTypeComboBox.Text == "Subterrânea")
                            box.boxtype = "S";

                        box.watts = Convert.ToInt32(boxWattsTextBox.Text);
                        box.latitude = boxLatitudeTextBox.Text;
                        box.longitude = boxLongitudeTextBox.Text;

                        box.InsertBox(box);

                        DialogResult dr = MessageBox.Show("Caixa cadastrada com sucesso! " +
                            "\nDeseja cadastrar outra caixa?", "Cadastro", MessageBoxButtons.YesNo);
                        if (dr != DialogResult.Yes)
                        {
                            listTabs.Controls.Remove(registerTab);
                            listTabs.Controls.Add(boxesTab);
                        }
                    }
                    catch (Exception ex)
                    {
                        if (existsId)
                            MessageBox.Show("Já existe uma caixa cadastrada com esta etiqueta!");
                        else
                            MessageBox.Show("Verifique os dados informados!");
                    }
                    finally
                    {
                        InsertValuesInGrids(Window.Box);
                    }
                }
                if (typeRegistration.Text == "Inspeção")
                {
                    try
                    {
                        var inspection = new Inspection()
                        {
                            id = int.Parse(inspectionPoleIdTextBox.Text)
                        };

                        if (inspection.existsId(inspection.id))
                        {
                            existsId = true;
                            throw new Exception();
                        }

                        if (inspectionSituationComboBox.Text == "Conservado")
                        {
                            inspection.polesituation = true;
                        }
                        else
                        {
                            inspection.polesituation = false;
                        }
                        if(inspectionBobComboBox.Text == "Alinhado")
                        {
                            inspection.bob = true;
                        }
                        else
                        {
                            inspection.bob = false;
                        }
                        if(inspectionWiringComboBox.Text == "Conservada")
                        {
                            inspection.polewiring = true;
                        }
                        else
                        {
                            inspection.polewiring = false;
                        }
                        inspection.date = DateTime.Parse(inspectionDate.Text);

                        inspection.InsertInspection(inspection);

                        DialogResult dr = MessageBox.Show("Inspeção cadastrada com sucesso! " +
                            "\nDeseja cadastrar outra inspeção?", "Cadastro", MessageBoxButtons.YesNo);
                        if (dr != DialogResult.Yes)
                        {
                            listTabs.Controls.Remove(registerTab);
                            listTabs.Controls.Add(inspectionsTab);
                        }
                    }
                    catch (Exception ex)
                    {
                        if (existsId)
                            MessageBox.Show("Já existe uma inspeção cadastrada com esta ID!");
                        else
                            MessageBox.Show("Verifique os dados informados!");
                    }
                    finally
                    {
                        InsertValuesInGrids(Window.Inspection);
                    }
                }

                TypeRegistration_SelectedIndexChanged(sender, e);
            }
        }

        private void TypeRegistration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeRegistration.Text.Equals("Caixa"))
            {
                lastWindow = (int)Window.Box;
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
                lastWindow = (int)Window.Pole;
                poleIdTextBox.Text = "";
                poleHeightTextBox.Text = "";
                poleMaterialComboBox.Text = "[Selecione]";
                poleLatitudeTextBox.Text = "";
                poleLongitudeTextBox.Text = "";
                poleBoxIdTextBox.Text = "";
                poleRegister.Visible = true;
                boxRegister.Visible = false;
                inspectionRegister.Visible = false;
            }
            else if (typeRegistration.Text.Equals("Inspeção"))
            {
                lastWindow = (int)Window.Inspection;
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
                    if (lastWindow == (int)Window.Box)
                    {
                        listTabs.Controls.Add(boxesTab);
                    }
                    if (lastWindow == (int)Window.Pole)
                    {
                        listTabs.Controls.Add(polesTab);
                    }
                    if (lastWindow == (int)Window.Inspection)
                    {
                        listTabs.Controls.Add(inspectionsTab);
                    }
                    listTabs.Controls.Remove(registerTab);
                    insertNewPictureBox.Image = Properties.Resources.incluir;
                    deleteRegisterPictureBox.Image = Properties.Resources.excluir;
                }
            }
            else
            {
                deleteById deleteById = new deleteById();
                deleteById.ShowDialog();
                InsertValuesInGrids(Window.Box);
            }
        }

        private void reportsPictureBox_Click(object sender, EventArgs e)
        {
            ReportForm novoForm = new ReportForm();
            novoForm.Show();
        }
    }
}
