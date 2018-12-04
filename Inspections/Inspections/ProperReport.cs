using Inspections.DataBase;
using System;
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
    public partial class ProperReport : Form
    {
        public ProperReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CRUD crud = new CRUD();
                string select = $"";
                crud.Database.ExecuteSqlCommand(select);
                MessageBox.Show("Fazer o select");
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha as datas corretamente!");
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void finalDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void initialDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
