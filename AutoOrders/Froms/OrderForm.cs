using AutoOrders.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AutoOrders
{
    public partial class OrderForm : Form
    {

        private Client client = new Client();

        public OrderForm()
        {
            InitializeComponent();
            comboBoxSalon.Items.AddRange(Salon.GetSalons().ToArray());
            comboBoxSalon.SelectedIndex = 0;

            comboBoxBrand.Items.AddRange(BrandCar.GetBrands().ToArray());
            comboBoxBrand.SelectedIndex = 0;

            comboBoxResponsible.Items.AddRange(MenedgerUser.GetMenedgers().ToArray());
            comboBoxResponsible.SelectedIndex = 0;

            comboBoxColorCar.Items.AddRange(ColorCar.GetColors().ToArray());
            comboBoxColorCar.SelectedIndex = 0;

            comboBoxTypeVizit.SelectedIndex = 0;
            comboBoxInfoSource.SelectedIndex = 0;
        }

        private void ComboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            BrandCar brand = (BrandCar)comboBoxBrand.SelectedItem;
            comboBoxModel.Items.Clear();
            comboBoxModel.Items.AddRange(ModelCar.GetModels(brand.Id).ToArray());
            comboBoxModel.SelectedIndex = 0;
        }

        private void buttonResetUser_Click(object sender, EventArgs e)
        {
            client = new Client();
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is RadioButton radioButton)
                {
                    bool isChecked = radioButton.Checked;
                    radioButton.Checked = false;
                }
                else if (ctrl is CheckBox checkBox)
                {
                    bool isChecked = checkBox.Checked;
                    checkBox.Checked = false;
                }
                else if (ctrl is TextBox textBox)
                {
                    string textValue = textBox.Text;
                    textBox.Text = "";
                }
            }
        }

        private void buttonFindClient_Click(object sender, EventArgs e)
        {
            var phone = textPhoneClient.Text;

            var users = Client.GetClientByPhone(phone);

            if(users.Count() == 0) {
                MessageBox.Show("Пользователь с данным номером не найден");
                buttonResetUser_Click(null,null);
                textPhoneClient.Text = phone;
                return;
            }

            client = users[0];

            textBoxLastName.Text = client.LastName;
            textBoxFirstName.Text = client.FirstName;
            textBoxMidName.Text = client.MiddleName;

            textBoxEmail.Text = client.Email;

            if(client.IsBusinessClient)
            {
                radioButtonIndividual.Checked = false;
                radioButtonBusiness.Checked = true;
            }
            else
            {
                radioButtonIndividual.Checked = true;
                radioButtonBusiness.Checked = false;
            }

            checkBoxAgreeSurveys.Checked = client.CompletedSurvey;
            checkBoxAgreeDataProcessing.Checked = client.HasPersonalData;
            checkBoxAgreeSMS.Checked = client.CanSendSMS;
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            InputClient();
            Order order = new Order();

            order.Salon = (Salon)comboBoxSalon.SelectedItem;
            order.Menedger = (MenedgerUser)comboBoxResponsible.SelectedItem;

            order.TypeVizit = (string)comboBoxTypeVizit.SelectedItem;
            order.How_found = (string)comboBoxInfoSource.SelectedItem;

            order.BrandCar = (BrandCar)comboBoxBrand.SelectedItem;
            order.ModelCar = (ModelCar)comboBoxModel.SelectedItem;
            order.ColorCar = (ColorCar)comboBoxColorCar.SelectedItem;

            order.Client = this.client;

            order.Create();
        }
        private void InputClient()
        {
            client.Phone = textPhoneClient.Text;

            client.CompletedSurvey = checkBoxAgreeSurveys.Checked;
            client.CanSendSMS = checkBoxAgreeSMS.Checked;
            client.HasPersonalData = checkBoxAgreeDataProcessing.Checked;

            client.LastName = textBoxLastName.Text;
            client.FirstName = textBoxFirstName.Text;
            client.MiddleName = textBoxMidName.Text;

            client.Email = textBoxEmail.Text;


            client.IsBusinessClient = radioButtonBusiness.Checked;

        }
    }
}
