using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Швейная_Фабрика
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AddUser_but_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            this.Hide();
            user.Show();
        }
    }
}
