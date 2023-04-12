using FarmKurs.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmKurs.Views
{
    public partial class NavigateForm : Form
    {
        private readonly DatabaseFactory factory;

        public NavigateForm(DatabaseFactory factory)
        {
            InitializeComponent();

            this.factory = factory;
        }

        private void button_ToMaterials_MouseClick(object sender, MouseEventArgs e)
        {
            new MaterialsForm(factory).Show(this);
        }

        private void button_ToEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            new EmployeeForm(factory).Show(this);
        }

        private void button_ToTypeProducts_MouseClick(object sender, MouseEventArgs e)
        {
            new TypeProductForm(factory).Show(this);
        }

        private void button_ToLab_MouseClick(object sender, MouseEventArgs e)
        {
            new LaboratoryForm(factory).Show(this);
        }

        private void button_ToProducts_MouseClick(object sender, MouseEventArgs e)
        {
            new ProductsForm(factory).Show(this);
        }
    }
}
