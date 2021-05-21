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
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }

        private void AddAdmin_Load(object sender, EventArgs e)
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
            if (!String.IsNullOrEmpty(txtUsername.Text.Trim()) && !String.IsNullOrEmpty(txtPass.Text.Trim()))
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-T7OFQV6\\SQLEXPRESS1;Initial Catalog=VidgaEmotionRecognition;Integrated Security=True"))
                {
                    String query = "INSERT INTO UserInfo (username,password) VALUES (@username,@password)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                        command.Parameters.AddWithValue("@password", txtPass.Text.Trim());

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                            MessageBox.Show("Kayıt Başarısız!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            MessageBox.Show("Kullanıcı Kaydedildi.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre boş olamaz.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
