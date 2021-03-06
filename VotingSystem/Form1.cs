﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystem
{
    public partial class frm_castVote : Form
    {
        public string password { get; set; }
        public int time { get; set; }
        public Dictionary<string, bool> voters { get; set; }
        public Dictionary<string, int> results { get; set; }
        int count = 0;
        public frm_castVote()
        {
            InitializeComponent();
        }

        private void frm_castVote_Load(object sender, EventArgs e)
        {
            t.Start();
            foreach (string s in results.Keys)
            {
                lst_Candidates.Items.Add(s);
            }
            if (lst_Candidates.Items.Count != 0)
            {
                lst_Candidates.SelectedIndex = 0;
            }
        }

        private void t_Tick(object sender, EventArgs e)
        {
            count++;
            if (count >= time)
            {
                btn_Vote.Enabled = false;
                txt_CNIC.Enabled = false;
                lst_Candidates.Enabled = false;
                FinishVoting();
                t.Stop();
            }
        }

        private void txt_CNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Vote_Click(object sender, EventArgs e)
        {
            if (txt_CNIC.Text.Length != 0)
            {
                string cnic = txt_CNIC.Text;
                //check if cnic is valid
                if (!voters.Keys.Contains(cnic))
                {
                    MessageBox.Show("Invalid CNIC!");
                    return;
                }
                //check if voter has already voted
                if (voters[cnic] == true) { MessageBox.Show("You have already voted!"); return; }
                //if it reaches till here, the user is valid
                string votedFor = lst_Candidates.SelectedItem.ToString();
                results[votedFor]++;
                voters[cnic] = true;
                MessageBox.Show("Vote casted successfully!");
            }
        }

        private void FinishVoting()
        {
            Results result = new Results();
            result.password = this.password;
            result.results = this.results;
            result.time = this.time;
            result.Show(); this.Hide();
        }
    }
}
