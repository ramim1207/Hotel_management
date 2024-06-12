﻿
namespace HotelManagementSystem
{
    partial class HelplessPeopleDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelplessPeopleDetails));
            this.pnlHelplessPeopleDetail = new System.Windows.Forms.Panel();
            this.dgvHelplessPeopleDetails = new System.Windows.Forms.DataGridView();
            this.btnShowHP = new System.Windows.Forms.Button();
            this.btnLogoutHP = new System.Windows.Forms.Button();
            this.HelplessPeopleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HelplessPeopleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPreviousHelplessPeople = new System.Windows.Forms.Button();
            this.pnlHelplessPeopleDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHelplessPeopleDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHelplessPeopleDetail
            // 
            this.pnlHelplessPeopleDetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHelplessPeopleDetail.BackgroundImage")));
            this.pnlHelplessPeopleDetail.Controls.Add(this.btnPreviousHelplessPeople);
            this.pnlHelplessPeopleDetail.Controls.Add(this.btnShowHP);
            this.pnlHelplessPeopleDetail.Controls.Add(this.btnLogoutHP);
            this.pnlHelplessPeopleDetail.Controls.Add(this.dgvHelplessPeopleDetails);
            this.pnlHelplessPeopleDetail.Location = new System.Drawing.Point(0, -3);
            this.pnlHelplessPeopleDetail.Name = "pnlHelplessPeopleDetail";
            this.pnlHelplessPeopleDetail.Size = new System.Drawing.Size(993, 618);
            this.pnlHelplessPeopleDetail.TabIndex = 1;
            // 
            // dgvHelplessPeopleDetails
            // 
            this.dgvHelplessPeopleDetails.AllowUserToAddRows = false;
            this.dgvHelplessPeopleDetails.AllowUserToDeleteRows = false;
            this.dgvHelplessPeopleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHelplessPeopleDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HelplessPeopleID,
            this.HelplessPeopleName});
            this.dgvHelplessPeopleDetails.Location = new System.Drawing.Point(551, 202);
            this.dgvHelplessPeopleDetails.Name = "dgvHelplessPeopleDetails";
            this.dgvHelplessPeopleDetails.ReadOnly = true;
            this.dgvHelplessPeopleDetails.RowHeadersWidth = 51;
            this.dgvHelplessPeopleDetails.RowTemplate.Height = 24;
            this.dgvHelplessPeopleDetails.Size = new System.Drawing.Size(409, 379);
            this.dgvHelplessPeopleDetails.TabIndex = 2;
            // 
            // btnShowHP
            // 
            this.btnShowHP.Location = new System.Drawing.Point(366, 391);
            this.btnShowHP.Name = "btnShowHP";
            this.btnShowHP.Size = new System.Drawing.Size(83, 38);
            this.btnShowHP.TabIndex = 4;
            this.btnShowHP.Text = "ShowList";
            this.btnShowHP.UseVisualStyleBackColor = true;
            this.btnShowHP.Click += new System.EventHandler(this.btnShowHP_Click);
            // 
            // btnLogoutHP
            // 
            this.btnLogoutHP.Location = new System.Drawing.Point(261, 391);
            this.btnLogoutHP.Name = "btnLogoutHP";
            this.btnLogoutHP.Size = new System.Drawing.Size(75, 30);
            this.btnLogoutHP.TabIndex = 3;
            this.btnLogoutHP.Text = "Logout";
            this.btnLogoutHP.UseVisualStyleBackColor = true;
            this.btnLogoutHP.Click += new System.EventHandler(this.btnLogoutHP_Click);
            // 
            // HelplessPeopleID
            // 
            this.HelplessPeopleID.DataPropertyName = "HelplessPeopleID";
            this.HelplessPeopleID.HeaderText = "Helpless People ID";
            this.HelplessPeopleID.MinimumWidth = 6;
            this.HelplessPeopleID.Name = "HelplessPeopleID";
            this.HelplessPeopleID.ReadOnly = true;
            this.HelplessPeopleID.Width = 125;
            // 
            // HelplessPeopleName
            // 
            this.HelplessPeopleName.DataPropertyName = "HelplessPeopleName";
            this.HelplessPeopleName.HeaderText = "Helpless People Name";
            this.HelplessPeopleName.MinimumWidth = 6;
            this.HelplessPeopleName.Name = "HelplessPeopleName";
            this.HelplessPeopleName.ReadOnly = true;
            this.HelplessPeopleName.Width = 125;
            // 
            // btnPreviousHelplessPeople
            // 
            this.btnPreviousHelplessPeople.Location = new System.Drawing.Point(327, 465);
            this.btnPreviousHelplessPeople.Name = "btnPreviousHelplessPeople";
            this.btnPreviousHelplessPeople.Size = new System.Drawing.Size(85, 37);
            this.btnPreviousHelplessPeople.TabIndex = 5;
            this.btnPreviousHelplessPeople.Text = "Previous";
            this.btnPreviousHelplessPeople.UseVisualStyleBackColor = true;
            this.btnPreviousHelplessPeople.Click += new System.EventHandler(this.btnPreviousHelplessPeople_Click);
            // 
            // HelplessPeopleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 613);
            this.Controls.Add(this.pnlHelplessPeopleDetail);
            this.Name = "HelplessPeopleDetails";
            this.Text = "HelplessPeopleDetails";
            this.pnlHelplessPeopleDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHelplessPeopleDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHelplessPeopleDetail;
        private System.Windows.Forms.DataGridView dgvHelplessPeopleDetails;
        private System.Windows.Forms.Button btnShowHP;
        private System.Windows.Forms.Button btnLogoutHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn HelplessPeopleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HelplessPeopleName;
        private System.Windows.Forms.Button btnPreviousHelplessPeople;
    }
}