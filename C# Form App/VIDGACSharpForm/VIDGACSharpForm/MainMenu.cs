using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using IronPython.Hosting;



namespace VIDGACSharpForm
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
        }

        

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "C:\\Users\\Gokhan\\source\\repos\\VIDGACSharpForm\\VIDGACSharpForm\\start.bat";

            ProcessStartInfo ProcessInfo;
            Process Process;

            ProcessInfo = new ProcessStartInfo("cmd.exe", "/K " + strCmdText);
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = true;

            Process = Process.Start(ProcessInfo);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            AddAdmin newOpen = new AddAdmin();
            newOpen.Show();
            this.Hide();
        }

        private void buttonSubject_Click(object sender, EventArgs e)
        {
            AddUser newOpen = new AddUser();
            newOpen.Show();
            this.Hide();
        }

        private void buttonAnalysis_Click(object sender, EventArgs e)
        {
            Analysis newOpen = new Analysis();
            newOpen.Show();
            this.Hide();
        }

        private void buttonCredits_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/ucargokhan/VIDGA-Emotion-Recognition-Final/blob/main/README.md");
            Process.Start(sInfo);
        }
    }
}
