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
    public partial class Analysis : Form
    {

        private static int neutral = 0;
        private static int calm = 0;
        private static int sad = 0;
        private static int happy = 0;
        private static int angry = 0;
        private static int fearful = 0;
        private static int surprised = 0;
        private static int disgust = 0;
        private static int total = 0;


        public Analysis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu newOpen = new MainMenu();
            newOpen.Show();
            this.Hide();
        }

        private void Analysis_Load(object sender, EventArgs e)
        {
            neutral = 0;
            calm = 0;
            sad = 0;
            happy = 0;
            angry = 0;
            fearful = 0;
            surprised = 0;
            disgust = 0;
            total = 0;

            LoadSpeech();
            LoadFace();
            Populate();

        }

        private void LoadSpeech()
        {
            try
            {


                String strConnection = "Data Source=DESKTOP-T7OFQV6\\SQLEXPRESS1;Initial Catalog=VidgaEmotionRecognition;Integrated Security=True";
                SqlConnection con = new SqlConnection(strConnection);

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "select Emotion,dateOfNow,_id from SpeechEmotion order by dateOfNow asc";
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);


                total += dtRecord.Rows.Count;
                foreach (DataRow item in dtRecord.Rows)
                {
                    item["dateOfNow"] = item["dateOfNow"].ToString().Substring(0, 19);
                    #region Counter
                    switch (item["Emotion"])
                    {
                        case "neutral":
                            neutral++;
                            break;

                        case "happy":
                            happy++;
                            break;

                        case "sad":
                            sad++;
                            break;

                        case "angry":
                            angry++;
                            break;

                        case "calm":
                            calm++;
                            break;

                        case "disgust":
                            disgust++;
                            break;

                        case "surprised":
                            surprised++;
                            break;

                        case "fearful":
                            fearful++;
                            break;

                        default:
                            break;
                    }
                    #endregion
                }

                dtRecord.Columns["dateOfNow"].ColumnName = "Kayıt Tarihi";
                dtRecord.Columns["Emotion"].ColumnName = "Duygu";
                dgSes.DataSource = dtRecord;

                List<DataRow> list = dtRecord.AsEnumerable().ToList();
                //IemArray[2] id, ItemArray[1] dateOfNow denk geliyor. Yerleri değişirse update çek.
                var firstDate = list.OrderBy(x => x.ItemArray[2]).Select(x => x.ItemArray[1]).FirstOrDefault();
                var lastDate = list.OrderByDescending(x => x.ItemArray[2]).Select(x => x.ItemArray[1]).FirstOrDefault();

                if (firstDate != null)
                    recordStartTextBox.Text = firstDate.ToString();
                if (lastDate != null)
                    recordFinishedTextBox.Text = lastDate.ToString(); ;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void LoadFace()
        {
            try
            {


                String strConnection = "Data Source=DESKTOP-T7OFQV6\\SQLEXPRESS1;Initial Catalog=VidgaEmotionRecognition;Integrated Security=True";
                SqlConnection con = new SqlConnection(strConnection);

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "select emotion,dateOfNow from FaceEmotion order by dateOfNow asc";
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);


                total += dtRecord.Rows.Count;
                foreach (DataRow item in dtRecord.Rows)
                {
                    item["dateOfNow"] = item["dateOfNow"].ToString().Substring(0, 19);
                    #region Counter
                    switch (item["Emotion"])
                    {
                        case "neutral":
                            neutral++;
                            break;

                        case "happy":
                            happy++;
                            break;

                        case "sad":
                            sad++;
                            break;

                        case "angry":
                            angry++;
                            break;

                        case "calm":
                            calm++;
                            break;

                        case "disgust":
                            disgust++;
                            break;

                        case "surprised":
                            surprised++;
                            break;

                        case "fearful":
                            fearful++;
                            break;

                        default:
                            break;
                    }
                    #endregion
                }

                dtRecord.Columns["dateOfNow"].ColumnName = "Kayıt Tarihi";
                dtRecord.Columns["emotion"].ColumnName = "Duygu";
                dgGoruntu.DataSource = dtRecord;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Populate()
        {
            try
            {
                pbAngry.Minimum = 0;
                pbDisgust.Minimum = 0;
                pbFearful.Minimum = 0;
                pbHappy.Minimum = 0;
                pbNeutral.Minimum = 0;
                pbSad.Minimum = 0;
                pbSuprised.Minimum = 0;

                if (total > 0)
                {
                    pbAngry.Value = angry * 100 / total;
                    pbDisgust.Value = disgust * 100 / total;
                    pbFearful.Value = fearful * 100 / total;
                    pbHappy.Value = happy * 100 / total;
                    pbNeutral.Value = neutral * 100 / total;
                    pbSad.Value = sad * 100 / total;
                    pbSuprised.Value = surprised * 100 / total;
                }

                pbAngry.Maximum = 100;
                pbDisgust.Maximum = 100;
                pbFearful.Maximum = 100;
                pbHappy.Maximum = 100;
                pbNeutral.Maximum = 100;
                pbSad.Maximum = 100;
                pbSuprised.Maximum = 100;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void GetDates()
        {
            try
            {


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgSes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgGoruntu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void recordStartTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
