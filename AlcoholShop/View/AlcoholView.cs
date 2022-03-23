using AlcoholShop.Controller;
using AlcoholShop.Model;
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
            this.alcoholTableAdapter.Fill(this.alcoholDBDataSet.Alcohol);
            dgvAlcohol.DataSource = alcoholController.GetAll();
        }

        private void RefreshTable()
        {
            dgvAlcohol.DataSource = alcoholController.GetAll();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Alcohol alcohol = new Alcohol();
            alcohol.Name = txtCreate.Text;
            alcohol.Alcohol_Percent = double.Parse(txtPercent.Text);
            alcohol.Price = int.Parse(txtPrice.Text);
            alcoholController.CreateAlcohol(alcohol);
            RefreshTable();
        }
    }
}
