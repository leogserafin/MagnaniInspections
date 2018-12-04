using Inspections.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inspections
{
    public partial class RelatorioInspecao : Form
    {
        public RelatorioInspecao()
        {
            InitializeComponent();
        }

        private void reportGenerator_Click(object sender, EventArgs e)
        {
            try
            {
                CRUD crud = new CRUD();
                string select = $"SELECT pole.id FROM dbo.pole WHERE NOT(pole.id IN(SELECT inspection.poleid FROM dbo.inspection WHERE inspection.date >= '{initialDate}'::date AND inspection.date <= '{finalDate}'::date)); ";
                crud.Database.ExecuteSqlCommand(select);
                MessageBox.Show("Mostrar o select");
            }
            catch (Exception)
            {

                MessageBox.Show("Preencha as datas corretamente!");
            }
        }

        private void initialDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void finalDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
