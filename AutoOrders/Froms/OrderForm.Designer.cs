using System.Windows.Forms;

namespace AutoOrders
{
    partial class OrderForm
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
            this.labelSalon = new System.Windows.Forms.Label();
            this.comboBoxSalon = new System.Windows.Forms.ComboBox();
            this.labelResponsible = new System.Windows.Forms.Label();
            this.comboBoxResponsible = new System.Windows.Forms.ComboBox();
            this.labelInfoSource = new System.Windows.Forms.Label();
            this.comboBoxInfoSource = new System.Windows.Forms.ComboBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.labelSearchClient = new System.Windows.Forms.Label();
            this.textPhoneClient = new System.Windows.Forms.TextBox();
            this.labelClientType = new System.Windows.Forms.Label();
            this.radioButtonIndividual = new System.Windows.Forms.RadioButton();
            this.radioButtonBusiness = new System.Windows.Forms.RadioButton();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.textBoxMidName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.checkBoxAgreeDataProcessing = new System.Windows.Forms.CheckBox();
            this.checkBoxAgreeSMS = new System.Windows.Forms.CheckBox();
            this.checkBoxAgreeSurveys = new System.Windows.Forms.CheckBox();
            this.buttonResetUser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFindClient = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxColorCar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTypeVizit = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSalon
            // 
            this.labelSalon.Location = new System.Drawing.Point(6, 21);
            this.labelSalon.Name = "labelSalon";
            this.labelSalon.Size = new System.Drawing.Size(100, 17);
            this.labelSalon.TabIndex = 0;
            this.labelSalon.Text = "Салон";
            // 
            // comboBoxSalon
            // 
            this.comboBoxSalon.Location = new System.Drawing.Point(6, 41);
            this.comboBoxSalon.Name = "comboBoxSalon";
            this.comboBoxSalon.Size = new System.Drawing.Size(200, 21);
            this.comboBoxSalon.TabIndex = 1;
            // 
            // labelResponsible
            // 
            this.labelResponsible.Location = new System.Drawing.Point(226, 21);
            this.labelResponsible.Name = "labelResponsible";
            this.labelResponsible.Size = new System.Drawing.Size(100, 17);
            this.labelResponsible.TabIndex = 2;
            this.labelResponsible.Text = "Ответственный";
            // 
            // comboBoxResponsible
            // 
            this.comboBoxResponsible.Location = new System.Drawing.Point(226, 41);
            this.comboBoxResponsible.Name = "comboBoxResponsible";
            this.comboBoxResponsible.Size = new System.Drawing.Size(200, 21);
            this.comboBoxResponsible.TabIndex = 3;
            // 
            // labelInfoSource
            // 
            this.labelInfoSource.Location = new System.Drawing.Point(9, 70);
            this.labelInfoSource.Name = "labelInfoSource";
            this.labelInfoSource.Size = new System.Drawing.Size(138, 17);
            this.labelInfoSource.TabIndex = 4;
            this.labelInfoSource.Text = "Источник информации";
            // 
            // comboBoxInfoSource
            // 
            this.comboBoxInfoSource.Items.AddRange(new object[] {
            "Знакомые",
            "интернет",
            "интернет - Сайт дилера"});
            this.comboBoxInfoSource.Location = new System.Drawing.Point(9, 89);
            this.comboBoxInfoSource.Name = "comboBoxInfoSource";
            this.comboBoxInfoSource.Size = new System.Drawing.Size(197, 21);
            this.comboBoxInfoSource.TabIndex = 5;
            // 
            // labelBrand
            // 
            this.labelBrand.Location = new System.Drawing.Point(6, 26);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(100, 17);
            this.labelBrand.TabIndex = 10;
            this.labelBrand.Text = "Бренд";
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.Location = new System.Drawing.Point(6, 46);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(200, 21);
            this.comboBoxBrand.TabIndex = 11;
            this.comboBoxBrand.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBrand_SelectedIndexChanged);
            // 
            // labelModel
            // 
            this.labelModel.Location = new System.Drawing.Point(6, 70);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(100, 17);
            this.labelModel.TabIndex = 12;
            this.labelModel.Text = "Модель";
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.Location = new System.Drawing.Point(6, 90);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(200, 21);
            this.comboBoxModel.TabIndex = 13;
            // 
            // labelSearchClient
            // 
            this.labelSearchClient.Location = new System.Drawing.Point(15, 20);
            this.labelSearchClient.Name = "labelSearchClient";
            this.labelSearchClient.Size = new System.Drawing.Size(133, 17);
            this.labelSearchClient.TabIndex = 17;
            this.labelSearchClient.Text = "Поиск клиента - номер";
            // 
            // textPhoneClient
            // 
            this.textPhoneClient.Location = new System.Drawing.Point(15, 40);
            this.textPhoneClient.Name = "textPhoneClient";
            this.textPhoneClient.Size = new System.Drawing.Size(200, 20);
            this.textPhoneClient.TabIndex = 18;
            // 
            // labelClientType
            // 
            this.labelClientType.Location = new System.Drawing.Point(239, 194);
            this.labelClientType.Name = "labelClientType";
            this.labelClientType.Size = new System.Drawing.Size(100, 17);
            this.labelClientType.TabIndex = 19;
            this.labelClientType.Text = "Тип клиента";
            // 
            // radioButtonIndividual
            // 
            this.radioButtonIndividual.Checked = true;
            this.radioButtonIndividual.Location = new System.Drawing.Point(330, 214);
            this.radioButtonIndividual.Name = "radioButtonIndividual";
            this.radioButtonIndividual.Size = new System.Drawing.Size(119, 24);
            this.radioButtonIndividual.TabIndex = 20;
            this.radioButtonIndividual.TabStop = true;
            this.radioButtonIndividual.Text = "Индивидуальный";
            // 
            // radioButtonBusiness
            // 
            this.radioButtonBusiness.Location = new System.Drawing.Point(235, 214);
            this.radioButtonBusiness.Name = "radioButtonBusiness";
            this.radioButtonBusiness.Size = new System.Drawing.Size(89, 24);
            this.radioButtonBusiness.TabIndex = 21;
            this.radioButtonBusiness.Text = "Бизнес";
            // 
            // labelLastName
            // 
            this.labelLastName.Location = new System.Drawing.Point(239, 17);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(100, 17);
            this.labelLastName.TabIndex = 22;
            this.labelLastName.Text = "Фамилия";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(239, 37);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(200, 20);
            this.textBoxLastName.TabIndex = 23;
            // 
            // labelFirstName
            // 
            this.labelFirstName.Location = new System.Drawing.Point(239, 60);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(100, 17);
            this.labelFirstName.TabIndex = 24;
            this.labelFirstName.Text = "Имя";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(239, 77);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(200, 20);
            this.textBoxFirstName.TabIndex = 25;
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.Location = new System.Drawing.Point(239, 100);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(100, 17);
            this.labelPatronymic.TabIndex = 26;
            this.labelPatronymic.Text = "Отчество";
            // 
            // textBoxMidName
            // 
            this.textBoxMidName.Location = new System.Drawing.Point(239, 117);
            this.textBoxMidName.Name = "textBoxMidName";
            this.textBoxMidName.Size = new System.Drawing.Size(200, 20);
            this.textBoxMidName.TabIndex = 27;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(239, 157);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 20);
            this.textBoxEmail.TabIndex = 31;
            // 
            // checkBoxAgreeDataProcessing
            // 
            this.checkBoxAgreeDataProcessing.Location = new System.Drawing.Point(6, 131);
            this.checkBoxAgreeDataProcessing.Name = "checkBoxAgreeDataProcessing";
            this.checkBoxAgreeDataProcessing.Size = new System.Drawing.Size(200, 36);
            this.checkBoxAgreeDataProcessing.TabIndex = 36;
            this.checkBoxAgreeDataProcessing.Text = "Согласие на обработку персональных данных";
            // 
            // checkBoxAgreeSMS
            // 
            this.checkBoxAgreeSMS.Location = new System.Drawing.Point(6, 168);
            this.checkBoxAgreeSMS.Name = "checkBoxAgreeSMS";
            this.checkBoxAgreeSMS.Size = new System.Drawing.Size(218, 36);
            this.checkBoxAgreeSMS.TabIndex = 37;
            this.checkBoxAgreeSMS.Text = "Согласие на получение смс рассылки";
            // 
            // checkBoxAgreeSurveys
            // 
            this.checkBoxAgreeSurveys.Location = new System.Drawing.Point(6, 102);
            this.checkBoxAgreeSurveys.Name = "checkBoxAgreeSurveys";
            this.checkBoxAgreeSurveys.Size = new System.Drawing.Size(210, 24);
            this.checkBoxAgreeSurveys.TabIndex = 38;
            this.checkBoxAgreeSurveys.Text = "Согласие на проведение опросов";
            // 
            // buttonResetUser
            // 
            this.buttonResetUser.Location = new System.Drawing.Point(6, 220);
            this.buttonResetUser.Name = "buttonResetUser";
            this.buttonResetUser.Size = new System.Drawing.Size(75, 23);
            this.buttonResetUser.TabIndex = 39;
            this.buttonResetUser.Text = "Сбросить";
            this.buttonResetUser.Click += new System.EventHandler(this.buttonResetUser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFindClient);
            this.groupBox1.Controls.Add(this.buttonResetUser);
            this.groupBox1.Controls.Add(this.textPhoneClient);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.textBoxMidName);
            this.groupBox1.Controls.Add(this.labelPatronymic);
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Controls.Add(this.labelFirstName);
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Controls.Add(this.labelLastName);
            this.groupBox1.Controls.Add(this.checkBoxAgreeDataProcessing);
            this.groupBox1.Controls.Add(this.checkBoxAgreeSMS);
            this.groupBox1.Controls.Add(this.labelSearchClient);
            this.groupBox1.Controls.Add(this.checkBoxAgreeSurveys);
            this.groupBox1.Controls.Add(this.radioButtonBusiness);
            this.groupBox1.Controls.Add(this.radioButtonIndividual);
            this.groupBox1.Controls.Add(this.labelClientType);
            this.groupBox1.Location = new System.Drawing.Point(459, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 256);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Клиент";
            // 
            // buttonFindClient
            // 
            this.buttonFindClient.Location = new System.Drawing.Point(15, 67);
            this.buttonFindClient.Name = "buttonFindClient";
            this.buttonFindClient.Size = new System.Drawing.Size(75, 23);
            this.buttonFindClient.TabIndex = 40;
            this.buttonFindClient.Text = "Найти";
            this.buttonFindClient.UseVisualStyleBackColor = true;
            this.buttonFindClient.Click += new System.EventHandler(this.buttonFindClient_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.Location = new System.Drawing.Point(239, 140);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(100, 17);
            this.labelEmail.TabIndex = 30;
            this.labelEmail.Text = "Email";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxColorCar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxModel);
            this.groupBox2.Controls.Add(this.labelModel);
            this.groupBox2.Controls.Add(this.comboBoxBrand);
            this.groupBox2.Controls.Add(this.labelBrand);
            this.groupBox2.Location = new System.Drawing.Point(236, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 171);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Автомобиль";
            // 
            // comboBoxColorCar
            // 
            this.comboBoxColorCar.Location = new System.Drawing.Point(6, 137);
            this.comboBoxColorCar.Name = "comboBoxColorCar";
            this.comboBoxColorCar.Size = new System.Drawing.Size(200, 21);
            this.comboBoxColorCar.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Цвет";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comboBoxTypeVizit);
            this.groupBox3.Controls.Add(this.labelInfoSource);
            this.groupBox3.Controls.Add(this.comboBoxInfoSource);
            this.groupBox3.Location = new System.Drawing.Point(13, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 119);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Доп. информация";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Форма обращения";
            // 
            // comboBoxTypeVizit
            // 
            this.comboBoxTypeVizit.Items.AddRange(new object[] {
            "Звонок",
            "Посещение"});
            this.comboBoxTypeVizit.Location = new System.Drawing.Point(9, 46);
            this.comboBoxTypeVizit.Name = "comboBoxTypeVizit";
            this.comboBoxTypeVizit.Size = new System.Drawing.Size(197, 21);
            this.comboBoxTypeVizit.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonCreateOrder);
            this.groupBox4.Location = new System.Drawing.Point(12, 221);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(218, 49);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Действия";
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Location = new System.Drawing.Point(6, 19);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateOrder.TabIndex = 40;
            this.buttonCreateOrder.Text = "Создать";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBoxSalon);
            this.groupBox5.Controls.Add(this.comboBoxResponsible);
            this.groupBox5.Controls.Add(this.labelResponsible);
            this.groupBox5.Controls.Add(this.labelSalon);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(441, 82);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Отвественный";
            // 
            // OrderForm
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(927, 278);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OrderForm";
            this.Text = "Добавление Клиента - Reception";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Label labelSalon;
        private ComboBox comboBoxSalon;
        private Label labelResponsible;
        private ComboBox comboBoxResponsible;
        private Label labelInfoSource;
        private ComboBox comboBoxInfoSource;
        private Label labelBrand;
        private ComboBox comboBoxBrand;
        private Label labelModel;
        private ComboBox comboBoxModel;
        private Label labelSearchClient;
        private TextBox textPhoneClient;
        private Label labelClientType;
        private RadioButton radioButtonIndividual;
        private RadioButton radioButtonBusiness;
        private Label labelLastName;
        private TextBox textBoxLastName;
        private Label labelFirstName;
        private TextBox textBoxFirstName;
        private Label labelPatronymic;
        private TextBox textBoxMidName;
        private TextBox textBoxEmail;
        private CheckBox checkBoxAgreeDataProcessing;
        private CheckBox checkBoxAgreeSMS;
        private CheckBox checkBoxAgreeSurveys;
        private Button buttonResetUser;

        #endregion

        private GroupBox groupBox1;
        private Button buttonFindClient;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private ComboBox comboBoxTypeVizit;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label labelEmail;
        private Button buttonCreateOrder;
        private ComboBox comboBoxColorCar;
        private Label label2;
    }
}