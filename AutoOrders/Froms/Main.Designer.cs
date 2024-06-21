namespace AutoOrders
{
    partial class Main
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
            this.buttonFormMenedger = new System.Windows.Forms.Button();
            this.buttonFormOrder = new System.Windows.Forms.Button();
            this.buttonListOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFormMenedger
            // 
            this.buttonFormMenedger.Enabled = false;
            this.buttonFormMenedger.Location = new System.Drawing.Point(12, 12);
            this.buttonFormMenedger.Name = "buttonFormMenedger";
            this.buttonFormMenedger.Size = new System.Drawing.Size(196, 23);
            this.buttonFormMenedger.TabIndex = 0;
            this.buttonFormMenedger.Text = "Форма менеджера";
            this.buttonFormMenedger.UseVisualStyleBackColor = true;
            this.buttonFormMenedger.Click += new System.EventHandler(this.buttonFormMenedger_Click);
            // 
            // buttonFormOrder
            // 
            this.buttonFormOrder.Enabled = false;
            this.buttonFormOrder.Location = new System.Drawing.Point(12, 41);
            this.buttonFormOrder.Name = "buttonFormOrder";
            this.buttonFormOrder.Size = new System.Drawing.Size(196, 23);
            this.buttonFormOrder.TabIndex = 1;
            this.buttonFormOrder.Text = "Форма заявления";
            this.buttonFormOrder.UseVisualStyleBackColor = true;
            this.buttonFormOrder.Click += new System.EventHandler(this.buttonFormOrder_Click);
            // 
            // buttonListOrder
            // 
            this.buttonListOrder.Enabled = false;
            this.buttonListOrder.Location = new System.Drawing.Point(12, 70);
            this.buttonListOrder.Name = "buttonListOrder";
            this.buttonListOrder.Size = new System.Drawing.Size(196, 23);
            this.buttonListOrder.TabIndex = 2;
            this.buttonListOrder.Text = "Список зявлений";
            this.buttonListOrder.UseVisualStyleBackColor = true;
            this.buttonListOrder.Click += new System.EventHandler(this.buttonListOrder_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 108);
            this.Controls.Add(this.buttonListOrder);
            this.Controls.Add(this.buttonFormOrder);
            this.Controls.Add(this.buttonFormMenedger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFormMenedger;
        private System.Windows.Forms.Button buttonFormOrder;
        private System.Windows.Forms.Button buttonListOrder;
    }
}