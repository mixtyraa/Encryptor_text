using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace GUI_encryptor
{

    public partial class Form1 : Form
    {
        List<Encryptor> ListEncryptors = new List<Encryptor>();

        public Form1()
        {
            InitializeComponent();
            LoadListEncryptors();
        }

        private void LoadListEncryptors()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("encrypt.xml");
            XmlElement xRoot = xml.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                string name =  null, path = null;
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "name")
                        name = childnode.InnerText;

                    if (childnode.Name == "path")
                        path = childnode.InnerText;

                }
                if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(path))
                    ListEncryptors.Add(new Encryptor(name, path));
            }
            comboBox1.DataSource = ListEncryptors;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "path";
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            if (sender == button1)
            {
                //source_text.Text += comboBox1.SelectedValue;

            }

            if (sender == button2)
            {
                //source_text.Text += comboBox1.SelectedValue;
            }
        }
    }

    public class Encryptor
    {
        public Encryptor(string name, string path)
        {
            Name = name;
            Path = path;
        }
        public string Name { get; }
        public string Path { get; }
    }
}
