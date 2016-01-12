namespace VotingSystem
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lst_candidates = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.votersFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lst_voters = new System.Windows.Forms.ListBox();
            this.txt_candidate = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_loadVoters = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_startVotingSession = new System.Windows.Forms.Button();
            this.btn_deleteVoter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Panel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(115, 66);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(238, 29);
            this.txt_password.TabIndex = 2;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Candidates";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lst_candidates
            // 
            this.lst_candidates.FormattingEnabled = true;
            this.lst_candidates.ItemHeight = 24;
            this.lst_candidates.Location = new System.Drawing.Point(16, 134);
            this.lst_candidates.Name = "lst_candidates";
            this.lst_candidates.Size = new System.Drawing.Size(258, 172);
            this.lst_candidates.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Voters";
            // 
            // votersFileDialog
            // 
            this.votersFileDialog.FileName = "openFileDialog1";
            this.votersFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.votersFileDialog_FileOk);
            // 
            // lst_voters
            // 
            this.lst_voters.FormattingEnabled = true;
            this.lst_voters.ItemHeight = 24;
            this.lst_voters.Location = new System.Drawing.Point(293, 134);
            this.lst_voters.Name = "lst_voters";
            this.lst_voters.Size = new System.Drawing.Size(258, 196);
            this.lst_voters.TabIndex = 6;
            // 
            // txt_candidate
            // 
            this.txt_candidate.Location = new System.Drawing.Point(16, 312);
            this.txt_candidate.Name = "txt_candidate";
            this.txt_candidate.Size = new System.Drawing.Size(258, 29);
            this.txt_candidate.TabIndex = 7;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(145, 345);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(129, 29);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_loadVoters
            // 
            this.btn_loadVoters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadVoters.Location = new System.Drawing.Point(293, 345);
            this.btn_loadVoters.Name = "btn_loadVoters";
            this.btn_loadVoters.Size = new System.Drawing.Size(157, 29);
            this.btn_loadVoters.TabIndex = 10;
            this.btn_loadVoters.Text = "Load from File";
            this.btn_loadVoters.UseVisualStyleBackColor = true;
            this.btn_loadVoters.Click += new System.EventHandler(this.btn_loadVoters_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(16, 345);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(123, 29);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_startVotingSession
            // 
            this.btn_startVotingSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startVotingSession.Location = new System.Drawing.Point(16, 383);
            this.btn_startVotingSession.Name = "btn_startVotingSession";
            this.btn_startVotingSession.Size = new System.Drawing.Size(534, 38);
            this.btn_startVotingSession.TabIndex = 12;
            this.btn_startVotingSession.Text = "Start Voting Session";
            this.btn_startVotingSession.UseVisualStyleBackColor = true;
            this.btn_startVotingSession.Click += new System.EventHandler(this.btn_startVotingSession_Click);
            // 
            // btn_deleteVoter
            // 
            this.btn_deleteVoter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteVoter.Location = new System.Drawing.Point(456, 345);
            this.btn_deleteVoter.Name = "btn_deleteVoter";
            this.btn_deleteVoter.Size = new System.Drawing.Size(95, 29);
            this.btn_deleteVoter.TabIndex = 13;
            this.btn_deleteVoter.Text = "Delete";
            this.btn_deleteVoter.UseVisualStyleBackColor = true;
            this.btn_deleteVoter.Click += new System.EventHandler(this.btn_deleteVoter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Expire in:";
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(466, 66);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(60, 29);
            this.txt_time.TabIndex = 15;
            this.txt_time.TextChanged += new System.EventHandler(this.txt_time_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "s";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 433);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_deleteVoter);
            this.Controls.Add(this.btn_startVotingSession);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_loadVoters);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_candidate);
            this.Controls.Add(this.lst_voters);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lst_candidates);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lst_candidates;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog votersFileDialog;
        private System.Windows.Forms.ListBox lst_voters;
        private System.Windows.Forms.TextBox txt_candidate;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_loadVoters;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_startVotingSession;
        private System.Windows.Forms.Button btn_deleteVoter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.Label label6;
    }
}