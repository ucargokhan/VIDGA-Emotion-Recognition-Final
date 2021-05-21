using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIDGACSharpForm
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu newOpen = new MainMenu();
            newOpen.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-T7OFQV6\\SQLEXPRESS1;Initial Catalog=VidgaEmotionRecognition;Integrated Security=True"))
            {
                String query = "INSERT INTO StandartUser (name,surname,email,telNo,job,address,gender,birthDate,pass) VALUES (@name,@surname,@email,@telNo,@job,@address,@gender,@birthDate,@pass)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    //command.Parameters.AddWithValue("@id", "abc");
                    command.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    command.Parameters.AddWithValue("@surname", txtSurname.Text.Trim());
                    command.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    //command.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    command.Parameters.AddWithValue("@telNo", txtTel.Text.Trim());
                    command.Parameters.AddWithValue("@job", txtJob.Text.Trim());
                    command.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                    if (cmbGender.SelectedItem != null)
                    {
                        command.Parameters.AddWithValue("@gender", cmbGender.SelectedItem.ToString());

                    }
                    else
                    {
                        command.Parameters.AddWithValue("@gender", " ");
                    }
                    command.Parameters.AddWithValue("@birthDate", txtBirth.Text.Trim());
                    command.Parameters.AddWithValue("@pass", txtPass.Text.Trim());

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                    {
                        MessageBox.Show("Kayıt Başarısız!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Kaydedildi.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                }
            }
        }

        private void txtSurnaöe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
