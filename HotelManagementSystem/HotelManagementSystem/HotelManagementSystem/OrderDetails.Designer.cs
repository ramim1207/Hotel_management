
namespace HotelManagementSystem
{
    partial class OrderDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetails));
            this.pnlOrderDetail = new System.Windows.Forms.Panel();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.btnShowOD = new System.Windows.Forms.Button();
            this.btnLogoutOD = new System.Windows.Forms.Button();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPreviousOrder = new System.Windows.Forms.Button();
            this.pnlOrderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOrderDetail
            // 
            this.pnlOrderDetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlOrderDetail.BackgroundImage")));
            this.pnlOrderDetail.Controls.Add(this.btnPreviousOrder);
            this.pnlOrderDetail.Controls.Add(this.btnShowOD);
            this.pnlOrderDetail.Controls.Add(this.btnLogoutOD);
            this.pnlOrderDetail.Controls.Add(this.dgvOrderDetails);
            this.pnlOrderDetail.Location = new System.Drawing.Point(0, -3);
            this.pnlOrderDetail.Name = "pnlOrderDetail";
            this.pnlOrderDetail.Size = new System.Drawing.Size(993, 618);
            this.pnlOrderDetail.TabIndex = 1;
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AllowUserToAddRows = false;
            this.dgvOrderDetails.AllowUserToDeleteRows = false;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.OrderName});
            this.dgvOrderDetails.Location = new System.Drawing.Point(552, 206);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.ReadOnly = true;
            this.dgvOrderDetails.RowHeadersWidth = 51;
            this.dgvOrderDetails.RowTemplate.Height = 24;
            this.dgvOrderDetails.Size = new System.Drawing.Size(403, 379);
            this.dgvOrderDetails.TabIndex = 2;
            // 
            // btnShowOD
            // 
            this.btnShowOD.BackColor = System.Drawing.Color.DarkRed;
            this.btnShowOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowOD.ForeColor = System.Drawing.Color.White;
            this.btnShowOD.Location = new System.Drawing.Point(361, 380);
            this.btnShowOD.Name = "btnShowOD";
            this.btnShowOD.Size = new System.Drawing.Size(87, 38);
            this.btnShowOD.TabIndex = 4;
            this.btnShowOD.Text = "ShowList";
            this.btnShowOD.UseVisualStyleBackColor = false;
            this.btnShowOD.Click += new System.EventHandler(this.btnShowOD_Click);
            // 
            // btnLogoutOD
            // 
            this.btnLogoutOD.BackColor = System.Drawing.Color.Maroon;
            this.btnLogoutOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutOD.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogoutOD.Location = new System.Drawing.Point(229, 380);
            this.btnLogoutOD.Name = "btnLogoutOD";
            this.btnLogoutOD.Size = new System.Drawing.Size(75, 38);
            this.btnLogoutOD.TabIndex = 3;
            this.btnLogoutOD.Text = "Logout";
            this.btnLogoutOD.UseVisualStyleBackColor = false;
            this.btnLogoutOD.Click += new System.EventHandler(this.btnLogoutOD_Click);
            // 
            // OrderID
            // 
            this.OrderID.DataPropertyName = "OrderID";
            this.OrderID.HeaderText = "Order ID";
            this.OrderID.MinimumWidth = 6;
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            this.OrderID.Width = 125;
            // 
            // OrderName
            // 
            this.OrderName.DataPropertyName = "OrderName";
            this.OrderName.HeaderText = "Order Item Name";
            this.OrderName.MinimumWidth = 6;
            this.OrderName.Name = "OrderName";
            this.OrderName.ReadOnly = true;
            this.OrderName.Width = 125;
            // 
            // btnPreviousOrder
            // 
            this.btnPreviousOrder.Location = new System.Drawing.Point(303, 460);
            this.btnPreviousOrder.Name = "btnPreviousOrder";
            this.btnPreviousOrder.Size = new System.Drawing.Size(85, 37);
            this.btnPreviousOrder.TabIndex = 5;
            this.btnPreviousOrder.Text = "Previous";
            this.btnPreviousOrder.UseVisualStyleBackColor = true;
            this.btnPreviousOrder.Click += new System.EventHandler(this.btnPreviousOrder_Click);
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 613);
            this.Controls.Add(this.pnlOrderDetail);
            this.Name = "OrderDetails";
            this.Text = "OrderDetails";
            this.pnlOrderDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrderDetail;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.Button btnShowOD;
        private System.Windows.Forms.Button btnLogoutOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderName;
        private System.Windows.Forms.Button btnPreviousOrder;
    }
}