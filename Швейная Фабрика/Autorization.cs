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
        //Дом
        //const string con = @"Data Source=ПК-ПК\SQLEXPRESS;Initial Catalog=Fabrika;Integrated Security=True";
        //Учеба
        const string con = @"Data Source=rt-1kk-pc3;Initial Catalog=Fabrika;Persist Security Info=True;User ID=sa;Password=11";
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
                string role_ = "";
                string role = $"SELECT Роль FROM Пользователь WHERE Логин = '{LoginTextBox.Text}'";
                SqlCommand myRole = new SqlCommand(role, connection);
                SqlDataReader myRole_Read = myRole.ExecuteReader();
                while (myRole_Read.Read())
                {
                    role_ = myRole_Read[0].ToString();
                }
                myRole_Read.Close();

                if (role_ == "admin")
                {
                    AdminPanel adm = new AdminPanel();
                    this.Hide();
                    adm.Show();
                }
               /* switch (role_)
                {
                    case "admin":
                        AdminPanel adm = new AdminPanel();
                        this.Hide();
                        adm.Show();
                        MessageBox.Show("adm");
                        break;

                    case "provider":

                        break;

                    case "manager":

                        break;

                    case "client":

                        break;
                }
                */

                


                }

                else
                {
                label4.Visible = true;
                }

            connection.Close();
            
        }

      
    }
}
