using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoOrders
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            buttonFormMenedger.Enabled = false;
            buttonFormOrder.Enabled = false;
            buttonListOrder.Enabled = false;
            buttonListUsers.Enabled = false;

            switch (Session.Role) {
                case 1:
                    buttonFormOrder.Enabled = true;
                    buttonListOrder.Enabled = true;
                    buttonListUsers.Enabled = true;
                    break;
                case 2:
                    buttonFormMenedger.Enabled = true;
                    break;
            }
        }

        private void buttonFormMenedger_Click(object sender, EventArgs e)
        {
            var form = new SetStateOrders();
            form.FormClosed += OnFormClosed;
            form.Show();
            this.Hide(); // Hide the login form
        }

        private void buttonFormOrder_Click(object sender, EventArgs e)
        {
            var form = new OrderForm();
            form.FormClosed += OnFormClosed;
            form.Show();
            this.Hide(); // Hide the login form
        }

        private void buttonListOrder_Click(object sender, EventArgs e)
        {
            var form = new ListOrders();
            form.FormClosed += OnFormClosed;
            form.Show();
            this.Hide(); // Hide the login form
        }

        private void buttonListUsers_Click(object sender, EventArgs e)
        {
            var form = new ListClients();
            form.FormClosed += OnFormClosed;
            form.Show();
            this.Hide(); // Hide the login form
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
