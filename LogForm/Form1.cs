using LogForm.Logging;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LogForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Log türleri ve namespace'leri tanımlayan sözlük

            //Namespaceleri farklı olan dosyaları belirliyorum. Veriler databaseden geldiği sırada burayı değiştirmeme gerek kalmaz diye düşündüm.

            //Dictionary<string, string> logTypeNamespaceMap = new Dictionary<string, string>
            //{
            //    { "DbLog", "Database" },
            //    { "XmlLog", "File" },
            //    { "JsonLog", "File" },
            //    { "OtherLogType", "SomeOtherNamespace" }
            //};

            string selectedLogType = LogTypeComboBox.SelectedItem.ToString();
            string logMessage = StatusTextBox.Text;

            LoggerFactory loggerFactory = new LoggerFactory();

            // selectedLogType ile uygun namespace'i belirliyoruz
            if (selectedLogType != null)
            {
                ILogger logger = loggerFactory.CreateLogger(selectedLogType);
                LoggerService loggerService = new LoggerService(logger);
                string resultMessage = loggerService.Log(logMessage);

                ResultMessageLabel.Text = resultMessage;
            }
            else
            {
                // Hatalı veya bilinmeyen log tipi seçilirse yapılacak işlemler
                ResultMessageLabel.Text = "Geçersiz log tipi seçildi.";
            }
        }
    }
}
