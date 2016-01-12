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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();// built in constructor
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_candidate.Text.Length != 0)
            {
                lst_candidates.Items.Add(txt_candidate.Text);
                txt_candidate.Clear();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            lst_candidates.Items.Remove(lst_candidates.SelectedItem);
        }

        private void btn_loadVoters_Click(object sender, EventArgs e)
        {
            OpenFileDialog votersdialog = new OpenFileDialog();
            votersdialog.Title = "List of allowed Voters";
            votersdialog.Filter = "Text Files|*.txt";
            if (votersdialog.ShowDialog() == DialogResult.OK)
            {
                var file = votersdialog.FileName; // stores the path of the selected file
                List<string> voters = File.ReadLines(file).ToList();
                foreach (string item in voters)
                {
                    lst_voters.Items.Add(item);
                }
            }
        }

        private void btn_deleteVoter_Click(object sender, EventArgs e)
        {
            lst_voters.Items.Remove(lst_voters.SelectedItem);
        }

        private void btn_startVotingSession_Click(object sender, EventArgs e)
        {
            if ((lst_candidates.Items.Count != 0) && (lst_voters.Items.Count != 0) && (txt_password.Text.Length != 0) && (txt_time.Text.Length != 0)) 
            {
                var votemain = new frm_castVote();// creating new instance
                votemain.password = txt_password.Text;
                votemain.time = Convert.ToInt32(txt_time.Text);
                votemain.voters = new Dictionary<string, bool>();
                foreach (string items in lst_voters.Items)
                {
                    votemain.voters.Add(items, false);
                }
                votemain.results = new Dictionary<string, int>();
                foreach (string items in lst_candidates.Items)
                {
                    votemain.results.Add(items, 0);
                }
                votemain.Show();
                this.Hide();
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_time_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void votersFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
