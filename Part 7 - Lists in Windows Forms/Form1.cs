using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_7___Lists_in_Windows_Forms
{
    public partial class frmUsingLists : Form
    {
        List<int> numbers = new List<int>();
        List<string> heros = new List<string>();
        Random generator = new Random();

        public frmUsingLists()
        {
            InitializeComponent();
        }

        private void frmUsingLists_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));

            IstNumbers.DataSource = numbers;

            heros.Add("superman");
            heros.Add("batman");

            IstHeroes.DataSource = heros;
        }

        private void btnSort1_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            IstNumbers.DataSource = null;
            IstNumbers.DataSource = numbers;

            lblStatus.Text = ("Status: Numbers Sorted");
        }

        private void btnSort2_Click(object sender, EventArgs e)
        {
            heros.Sort();
            lblStatus.Text = ("Status: Heros Sorted");
        }

        private void btnNewList1_Click(object sender, EventArgs e)
        {
            numbers.Clear();

            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));

            IstNumbers.DataSource = null;
            IstNumbers.DataSource = numbers;

            lblStatus.Text = ("Status: New Number List");

        }

        private void btnNewList2_Click(object sender, EventArgs e)
        {
            heros.Clear();

            heros.Add("superman");
            heros.Add("batman");

            IstHeroes.DataSource = heros;

            lblStatus.Text = ("Status: New Hero List");
        }

        private void btnRemoveNumber_Click(object sender, EventArgs e)
        {
            if(IstNumbers.SelectedIndex >= 0)
            {
                numbers.RemoveAt(IstNumbers.SelectedIndex);

                IstNumbers.DataSource = null;
                IstNumbers.DataSource = numbers;

                lblStatus.Text = ("Status: Removed a Number");
            }
            else
            {
                lblStatus.Text = ("Status: You Don't Have a Number Selected");
            }
            
        }

        private void btnRemoveAllNumber_Click(object sender, EventArgs e)
        {
            numbers.Clear();

            IstNumbers.DataSource = null;
            IstNumbers.DataSource = numbers;

            lblStatus.Text = ("Status: Removed all Numbers");
        }

        private void btnRemoveHero_Click(object sender, EventArgs e)
        {

            heros.Remove((string)(txtRemoveHero.Text));

            IstHeroes.DataSource = null;
            
        }
    }
}
