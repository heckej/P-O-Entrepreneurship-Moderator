﻿namespace peno_cluster_moderator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnReportedQA = new System.Windows.Forms.Button();
            this.btnBlacklist = new System.Windows.Forms.Button();
            this.btnBlockedUsers = new System.Windows.Forms.Button();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pnlProfilePicture = new System.Windows.Forms.Panel();
            this.blacklistControl = new peno_cluster_moderator.BlacklistControl();
            this.reportedQAControl = new peno_cluster_moderator.ReportedQAControl();
            this.blockedUsersControl = new peno_cluster_moderator.BlockedUsersControl();
            this.pnlSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReportedQA
            // 
            this.btnReportedQA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnReportedQA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportedQA.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReportedQA.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnReportedQA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnReportedQA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnReportedQA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportedQA.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnReportedQA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReportedQA.Location = new System.Drawing.Point(0, 76);
            this.btnReportedQA.Name = "btnReportedQA";
            this.btnReportedQA.Size = new System.Drawing.Size(210, 28);
            this.btnReportedQA.TabIndex = 2;
            this.btnReportedQA.TabStop = false;
            this.btnReportedQA.Text = "Reported Q&&A";
            this.btnReportedQA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportedQA.UseVisualStyleBackColor = false;
            this.btnReportedQA.Click += new System.EventHandler(this.btnReportedQA_Click);
            // 
            // btnBlacklist
            // 
            this.btnBlacklist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnBlacklist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlacklist.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBlacklist.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnBlacklist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnBlacklist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnBlacklist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlacklist.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnBlacklist.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBlacklist.Location = new System.Drawing.Point(0, 50);
            this.btnBlacklist.Name = "btnBlacklist";
            this.btnBlacklist.Size = new System.Drawing.Size(210, 28);
            this.btnBlacklist.TabIndex = 1;
            this.btnBlacklist.TabStop = false;
            this.btnBlacklist.Text = "Blacklist";
            this.btnBlacklist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlacklist.UseVisualStyleBackColor = false;
            this.btnBlacklist.Click += new System.EventHandler(this.btnBlacklist_Click);
            // 
            // btnBlockedUsers
            // 
            this.btnBlockedUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnBlockedUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlockedUsers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBlockedUsers.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnBlockedUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnBlockedUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnBlockedUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlockedUsers.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnBlockedUsers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBlockedUsers.Location = new System.Drawing.Point(0, 102);
            this.btnBlockedUsers.Name = "btnBlockedUsers";
            this.btnBlockedUsers.Size = new System.Drawing.Size(210, 28);
            this.btnBlockedUsers.TabIndex = 4;
            this.btnBlockedUsers.TabStop = false;
            this.btnBlockedUsers.Text = "Blocked Users";
            this.btnBlockedUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlockedUsers.UseVisualStyleBackColor = false;
            this.btnBlockedUsers.Click += new System.EventHandler(this.btnBlockedUsers_Click);
            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.pnlSummary.Controls.Add(this.lblUserName);
            this.pnlSummary.Controls.Add(this.pnlProfilePicture);
            this.pnlSummary.Controls.Add(this.btnBlacklist);
            this.pnlSummary.Controls.Add(this.btnReportedQA);
            this.pnlSummary.Controls.Add(this.btnBlockedUsers);
            this.pnlSummary.Location = new System.Drawing.Point(0, 0);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(210, 1080);
            this.pnlSummary.TabIndex = 5;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserName.Location = new System.Drawing.Point(49, 12);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(147, 25);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "Hans Adminson";
            // 
            // pnlProfilePicture
            // 
            this.pnlProfilePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlProfilePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlProfilePicture.BackgroundImage")));
            this.pnlProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlProfilePicture.Location = new System.Drawing.Point(3, 3);
            this.pnlProfilePicture.Name = "pnlProfilePicture";
            this.pnlProfilePicture.Size = new System.Drawing.Size(44, 47);
            this.pnlProfilePicture.TabIndex = 6;
            // 
            // blacklistControl
            // 
            this.blacklistControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.blacklistControl.Location = new System.Drawing.Point(210, 0);
            this.blacklistControl.Name = "blacklistControl";
            this.blacklistControl.Size = new System.Drawing.Size(1720, 1080);
            this.blacklistControl.TabIndex = 6;
            this.blacklistControl.Visible = false;
            // 
            // reportedQAControl
            // 
            this.reportedQAControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.reportedQAControl.Location = new System.Drawing.Point(210, 0);
            this.reportedQAControl.Name = "reportedQAControl";
            this.reportedQAControl.Size = new System.Drawing.Size(1720, 1080);
            this.reportedQAControl.TabIndex = 7;
            this.reportedQAControl.Visible = false;
            // 
            // blockedUsersControl
            // 
            this.blockedUsersControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.blockedUsersControl.Location = new System.Drawing.Point(210, 0);
            this.blockedUsersControl.Name = "blockedUsersControl";
            this.blockedUsersControl.Size = new System.Drawing.Size(1720, 1080);
            this.blockedUsersControl.TabIndex = 8;
            this.blockedUsersControl.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 571);
            this.Controls.Add(this.blacklistControl);
            this.Controls.Add(this.reportedQAControl);
            this.Controls.Add(this.blockedUsersControl);
            this.Controls.Add(this.pnlSummary);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Cluster Moderator Panel";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReportedQA;
        private System.Windows.Forms.Button btnBlacklist;
        private System.Windows.Forms.Button btnBlockedUsers;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Panel pnlProfilePicture;
        private System.Windows.Forms.Label lblUserName;
        private BlacklistControl blacklistControl;
        private ReportedQAControl reportedQAControl;
        private BlockedUsersControl blockedUsersControl;
    }
}