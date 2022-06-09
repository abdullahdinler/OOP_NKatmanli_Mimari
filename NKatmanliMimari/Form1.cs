using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace NKatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Listed()
        {
            List<EntityCustomers> listedCustomers = LogicCustomer.LCustomersList();
            dataGridView1.DataSource = listedCustomers;
        }
        private void btn_listed_Click(object sender, EventArgs e)
        {
            Listed();
        }
        EntityCustomers ec = new EntityCustomers();
        private void btn_add_Click(object sender, EventArgs e)
        {
            
            ec.Name = txtname.Text;
            ec.LastName = txtlastname.Text;
            ec.City = txtcity.Text;
            ec.Task = txttask.Text;
            ec.Paying = short.Parse(txtpaying.Text);
            LogicCustomer.llCutomerAdd(ec);

        }

        private void button1_Click(object sender, EventArgs e)
        {
 
            ec.Id = Convert.ToInt16(txtid.Text);
            LogicCustomer.LllCustomerDelet(ec.Id);

            Listed();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtlastname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtcity.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txttask.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtpaying.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            ec.Id = Convert.ToInt16(txtid.Text);
            ec.Name = txtname.Text;
            ec.LastName = txtlastname.Text;
            ec.City = txtcity.Text;
            ec.Task = txttask.Text;
            ec.Paying = short.Parse(txtpaying.Text);
            LogicCustomer.llCustomerUpdate(ec);
            Listed();

        }
    }
}
