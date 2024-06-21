namespace AutoOrders
{
    partial class SetStateOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonUpdateStatus = new System.Windows.Forms.Button();
            this.textBoxOrderDetails = new System.Windows.Forms.TextBox();
            this.client = new System.Windows.Forms.TextBox();
            this.idOrder = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(12, 11);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrders.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOrders.Size = new System.Drawing.Size(883, 300);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.SelectionChanged += new System.EventHandler(this.dataGridViewOrders_SelectionChanged);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(901, 90);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(200, 21);
            this.comboBoxStatus.TabIndex = 1;
            // 
            // buttonUpdateStatus
            // 
            this.buttonUpdateStatus.Location = new System.Drawing.Point(901, 117);
            this.buttonUpdateStatus.Name = "buttonUpdateStatus";
            this.buttonUpdateStatus.Size = new System.Drawing.Size(200, 23);
            this.buttonUpdateStatus.TabIndex = 2;
            this.buttonUpdateStatus.Text = "Update Status";
            this.buttonUpdateStatus.UseVisualStyleBackColor = true;
            this.buttonUpdateStatus.Click += new System.EventHandler(this.buttonUpdateStatus_Click);
            // 
            // textBoxOrderDetails
            // 
            this.textBoxOrderDetails.Location = new System.Drawing.Point(901, 64);
            this.textBoxOrderDetails.Name = "textBoxOrderDetails";
            this.textBoxOrderDetails.ReadOnly = true;
            this.textBoxOrderDetails.Size = new System.Drawing.Size(200, 20);
            this.textBoxOrderDetails.TabIndex = 3;
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(901, 37);
            this.client.Name = "client";
            this.client.ReadOnly = true;
            this.client.Size = new System.Drawing.Size(200, 20);
            this.client.TabIndex = 4;
            // 
            // idOrder
            // 
            this.idOrder.Location = new System.Drawing.Point(901, 12);
            this.idOrder.Name = "idOrder";
            this.idOrder.ReadOnly = true;
            this.idOrder.Size = new System.Drawing.Size(200, 20);
            this.idOrder.TabIndex = 5;
            // 
            // SetStateOrders
            // 
            this.ClientSize = new System.Drawing.Size(1113, 324);
            this.Controls.Add(this.idOrder);
            this.Controls.Add(this.client);
            this.Controls.Add(this.textBoxOrderDetails);
            this.Controls.Add(this.buttonUpdateStatus);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.dataGridViewOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SetStateOrders";
            this.Text = "Order Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonUpdateStatus;
        private System.Windows.Forms.TextBox textBoxOrderDetails;
        #endregion

        private System.Windows.Forms.TextBox client;
        private System.Windows.Forms.TextBox idOrder;
    }
}