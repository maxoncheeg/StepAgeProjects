using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace SHARPex19_1.Forms
{
    public partial class FormAddOrder : Form
    {
        public FormAddOrder()
        {
            InitializeComponent();

            textBoxWayToFile.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) 
                || numericUpDownPrice.Value == 0 
                || numericUpDownWeight.Value == 0 
                || (checkBoxImage.Checked && string.IsNullOrEmpty(textBoxWayToFile.Text)))
                return;

            if(textBoxName.Text[0] >= 48 && textBoxName.Text[0] <= 57)
            {
                MessageBox.Show("Название заказа не должно начинаться с цифры!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            XmlDocument document = new XmlDocument();
            List<string> ordersName = new List<string>();
            document.Load("orders.xml");

            foreach (XmlNode item in document.DocumentElement.ChildNodes)
                ordersName.Add(item.FirstChild.Value);

            if (ordersName.Contains(textBoxName.Text)) return;

            XmlNode main = document.CreateElement(textBoxName.Text),
                    weight = document.CreateElement("Price"),
                    price = document.CreateElement("Weight"),
                    textWeight = document.CreateTextNode($"{numericUpDownWeight.Value}g."),
                    textPrice = document.CreateTextNode($"{numericUpDownPrice.Value}$");

            weight.AppendChild(textWeight);
            price.AppendChild(textPrice);

            if (checkBoxImage.Checked)
            {
                main.Attributes.Append(document.CreateAttribute("Image"));
                main.Attributes[0].Value = textBoxWayToFile.Text;
            }

            main.AppendChild(weight);
            main.AppendChild(price);

            document.DocumentElement.AppendChild(main);
            document.Save("orders.xml");

            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxImage_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxImage.Checked) textBoxWayToFile.Enabled = true;
            else textBoxWayToFile.Enabled = false;
        }
    }
}
