using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Швейная_Фабрика
{
   
    public partial class FormAutoriz : Form
    {
        
        const string con = @"Data Source=ПК-ПК\SQLEXPRESS;Initial Catalog=Fabrika;Integrated Security=True";
        SqlConnection connection = new SqlConnection(con);
        
        public FormAutoriz()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*';
            
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            connection.Open();
             
            DataTable table = new DataTable();
            String loginUser = LoginTextBox.Text;
            String passUser = PasswordTextBox.Text;
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("SELECT * FROM Пользователь WHERE Логин = @uL  AND Пароль = @pU ", connection);
            command.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@pU", SqlDbType.VarChar).Value = passUser;
            adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                label4.Visible = false;

                MessageBox.Show("Da");
                }
                else
                {
                label4.Visible = true;
                }

            connection.Close();
            
        }

      
    }
}
