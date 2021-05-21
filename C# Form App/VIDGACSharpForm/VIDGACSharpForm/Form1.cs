using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace VIDGACSharpForm
{
    public partial class FormLogin : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        public FormLogin()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            //pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            con = new SqlConnection("Data Source=DESKTOP-T7OFQV6\\SQLEXPRESS1;Initial Catalog=VidgaEmotionRecognition;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select * From UserInfo where username='" + textBoxUsername.Text + "'And password='" + textBoxPassword.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                //MessageBox.Show("Giriş Başarılı.");
                MainMenu newOpen = new MainMenu();
                newOpen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
