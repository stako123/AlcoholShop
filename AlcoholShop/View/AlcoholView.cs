using AlcoholShop.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlcoholShop.View
{
    public partial class AlcoholView : Form
    {
        AlcoholDBController alcoholController = new AlcoholDBController();
        public AlcoholView()
        {
            InitializeComponent();
        }

        private void AlcoholView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alcoholDBDataSet.Alcohol' table. You can move, or remove it, as needed.
            this.alcoholTableAdapter.Fill(this.alcoholDBDataSet.Alcohol);
            dgvAlcohol.DataSource = alcoholController.GetAll();
        }
    }
}
