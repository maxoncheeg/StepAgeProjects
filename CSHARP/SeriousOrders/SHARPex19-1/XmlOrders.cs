using SHARPex19_1.Forms;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;


namespace SHARPex19_1
{
    static class XmlOrders
    {
        public static void CheckFile()
        {
            if (!File.Exists("orders.xml"))
            {
                XmlTextWriter writer = new XmlTextWriter("orders.xml", Encoding.UTF32);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();

                writer.WriteStartElement("Order");

                writer.WriteStartElement("EliteTea");
                writer.WriteAttributeString("Image", "eliteTea.jpg");
                writer.WriteElementString("Weight", "50g.");
                writer.WriteElementString("Price", "100$");
                writer.WriteEndElement();

                writer.WriteStartElement("ToyCar");
                writer.WriteAttributeString("Image", "megaCar.jpg");
                writer.WriteElementString("Weight", "100g.");
                writer.WriteElementString("Price", "5$");
                writer.WriteEndElement();

                writer.WriteStartElement("ChristmasTree");
                writer.WriteAttributeString("Image", "tree.jpeg");
                writer.WriteElementString("Weight", "5000g.");
                writer.WriteElementString("Price", "48$");
                writer.WriteEndElement();

                writer.WriteStartElement("Dragon");
                writer.WriteAttributeString("Image", "dragon.jpg");
                writer.WriteElementString("Weight", "50g.");
                writer.WriteElementString("Price", "70$");
                writer.WriteEndElement();

                writer.Close();
            }
        }

        public static void GetOrdersName(ListBox listBox)
        {
            listBox.Items.Clear();
            XmlDocument document = new XmlDocument();
            document.Load("orders.xml");

            XmlNode node = document.DocumentElement;

            foreach(XmlNode item in node.ChildNodes)
                listBox.Items.Add(item.Name);
        }

        public static void ShowOrder(string orderName)
        {
            XmlDocument document = new XmlDocument();
            document.Load("orders.xml");

            XmlNode node = document.DocumentElement;

            foreach (XmlNode item in node.ChildNodes)
                if(item.Name == orderName)
                {
                    try
                    {
                        FormShowOrder form = new FormShowOrder(item.Name, item.ChildNodes[0].FirstChild.Value, item.ChildNodes[1].FirstChild.Value, item.Attributes[0].Value);

                        form.ShowDialog();
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно открыть изображение или изображения нет!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        FormShowOrder form = new FormShowOrder(item.Name, item.ChildNodes[0].FirstChild.Value, item.ChildNodes[1].FirstChild.Value);

                        form.ShowDialog();
                    }

                    return;
                }
        }

        public static void AddOrder()
        {
            FormAddOrder form = new FormAddOrder();

            form.ShowDialog();
        }

        public static void DeleteOrder(string orderName)
        {
            XmlDocument document = new XmlDocument();
            document.Load("orders.xml");

            foreach (XmlNode item in document.DocumentElement.ChildNodes)
                if (item.Name == orderName)
                {
                    document.DocumentElement.RemoveChild(item);
                    break;
                }

            document.Save("orders.xml");
        }
    }
}
