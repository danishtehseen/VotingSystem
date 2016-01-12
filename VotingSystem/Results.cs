using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystem
{
    public partial class Results : Form
    {
        public string password { get; set; }
        public Dictionary<string, int> results { get; set; }// for the candidates
        public int time { get; set; }
        public Results()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            lst_results.Enabled = false;
            btn_save.Enabled = false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_password.Text.Equals(password))
            {
                btn_login.Enabled = false;
                txt_password.Enabled = false;
                lst_results.Enabled = true;
                btn_save.Enabled = true;
                foreach (string item in results.Keys)//shows results
                {
                    lst_results.Items.Add(string.Format("{0} - {1}", item, results[item].ToString()));
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Total Voters: {0}", TotalVoters().ToString()));
            sb.AppendLine("");
            foreach (string item in results.Keys)
            {
                sb.AppendLine(string.Format("{0} - {1}", item, results[item].ToString()));
            }
            sb.AppendLine("----- END -----");
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.DefaultExt = ".txt";
            dialog.FileName = "Voting Results";
            dialog.Filter = "Text File|*.txt";
            dialog.Title = "Save Voting Results";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, sb.ToString());// writes the string to the txt file
            }
        }

        private int TotalVoters()
        {
            int result = 0;
            foreach (var key in results.Keys)
            {
                result += results[key];
            }
            return result;
        }

        private void lst_results_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
