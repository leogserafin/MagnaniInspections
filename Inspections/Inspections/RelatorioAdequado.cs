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
    public partial class RelatorioAdequado : Form
    {
        public RelatorioAdequado()
        {
            InitializeComponent();
        }

        private void reportGenerator_Click(object sender, EventArgs e)
        {
            try
            {
                CRUD crud = new CRUD();
                string select = $"SELECT TO_CHAR(i.date, 'TMMonth') as mes, TO_CHAR(i.date, 'YYYY') as ano, CASE WHEN i.polesituation = 't' THEN COUNT(i.poleid) END AS adequados, CASE WHEN i.polesituation = 'f' THEN COUNT(i.poleid) END AS inadequados FROM dbo.pole p INNER JOIN dbo.inspection i ON(i.poleid = p.id) GROUP BY 1, i.polesituation, 2";
                crud.Database.ExecuteSqlCommand(select);
                MessageBox.Show("Mostrar o select");
            }
            catch (Exception)
            {

                MessageBox.Show("Preencha as datas corretamente!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
