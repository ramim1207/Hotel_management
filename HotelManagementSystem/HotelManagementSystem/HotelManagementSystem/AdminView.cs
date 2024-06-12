using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
        }

     

        private void btnAdminformMenu_Click(object sender, EventArgs e)
        {
            Category cate = new Category();
            cate.Show();
        }

        private void AdminView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void showInfoToolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void showInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Select * from VolunteerTable;
        }
        
    }
}
