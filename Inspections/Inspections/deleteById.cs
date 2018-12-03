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

        private void button1_Click(object sender, EventArgs e)
        {
            Box box = new Box();
            box.RemoveBox(int.Parse(deleteID.Text));
            
        }
    }
}
