namespace VotingSystem
{
    partial class frm_castVote
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_Candidates = new System.Windows.Forms.ListBox();
            this.txt_CNIC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Vote = new System.Windows.Forms.Button();
            this.t = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voting System";
            // 
            // lst_Candidates
            // 
            this.lst_Candidates.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Candidates.FormattingEnabled = true;
            this.lst_Candidates.ItemHeight = 24;
            this.lst_Candidates.Location = new System.Drawing.Point(17, 94);
            this.lst_Candidates.Name = "lst_Candidates";
            this.lst_Candidates.Size = new System.Drawing.Size(534, 220);
            this.lst_Candidates.TabIndex = 1;
            this.lst_Candidates.SelectedIndexChanged += new System.EventHandler(this.lst_Candidates_SelectedIndexChanged);
            // 
            // txt_CNIC
            // 
            this.txt_CNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CNIC.Location = new System.Drawing.Point(78, 56);
            this.txt_CNIC.Name = "txt_CNIC";
            this.txt_CNIC.Size = new System.Drawing.Size(473, 29);
            this.txt_CNIC.TabIndex = 2;
            this.txt_CNIC.TextChanged += new System.EventHandler(this.txt_CNIC_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "CNIC";
            // 
            // btn_Vote
            // 
            this.btn_Vote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Vote.Location = new System.Drawing.Point(17, 320);
            this.btn_Vote.Name = "btn_Vote";
            this.btn_Vote.Size = new System.Drawing.Size(534, 43);
            this.btn_Vote.TabIndex = 4;
            this.btn_Vote.Text = "VOTE";
            this.btn_Vote.UseVisualStyleBackColor = true;
            this.btn_Vote.Click += new System.EventHandler(this.btn_Vote_Click);
            // 
            // t
            // 
            this.t.Interval = 1000;
            this.t.Tick += new System.EventHandler(this.t_Tick);
            // 
            // frm_castVote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 371);
            this.Controls.Add(this.btn_Vote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_CNIC);
            this.Controls.Add(this.lst_Candidates);
            this.Controls.Add(this.label1);
            this.Name = "frm_castVote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cast your Vote";
            this.Load += new System.EventHandler(this.frm_castVote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_Candidates;
        private System.Windows.Forms.TextBox txt_CNIC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Vote;
        private System.Windows.Forms.Timer t;
    }
}

