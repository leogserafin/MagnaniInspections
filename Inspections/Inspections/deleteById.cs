using Inspections.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inspections
{

    public partial class deleteById : Form
    {
        private static List<Box> boxesList;

        public deleteById()
        {
            InitializeComponent();
        }


        private void delete_Click(object sender, EventArgs e)
        {
            if (typeToDelete.Text == "Caixa")
            {
                DialogResult dr = MessageBox.Show("Deseja excluir a caixa?", "Excluir", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Box box = new Box();
                    box.Remove(int.Parse(deleteID.Text));
                    this.Dispose();
                }
            }
            else if (typeToDelete.Text == "Poste")
            {
                DialogResult dr = MessageBox.Show("Deseja excluir o poste?", "Excluir", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        Pole pole = new Pole();
                        pole.Remove(int.Parse(deleteID.Text));
                        this.Dispose();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Não foi possível deletar o poste");
                    }
                }
            }
            else if (typeToDelete.Text == "Inspeção")
            {
                DialogResult dr = MessageBox.Show("Deseja excluir o poste?", "Excluir", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Inspection inspection = new Inspection();
                    inspection.Remove(int.Parse(deleteID.Text));
                    this.Dispose();
                }
            }
            else MessageBox.Show("Selecione o tipo de registro a ser excluído");
        }

        private void back_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja cancelar a exclusão?", "Voltar", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
