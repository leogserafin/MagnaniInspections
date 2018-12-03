using Inspections.DataBase;
using Inspections.Entities;
using System;
using System.Windows.Forms;

namespace Inspections
{
    public partial class deleteById : Form
    {

        public deleteById()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja excluir o item?", "Excluir", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Box box = new Box();
                box.RemoveBox(int.Parse(deleteID.Text));
                this.Dispose();
            }
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
