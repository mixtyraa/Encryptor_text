using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

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


        private void source_text_TextChanged(object sender, EventArgs e)
        {
            ScriptEngine engine = Python.CreateEngine();
            ScriptScope scope = engine.CreateScope();
            engine.ExecuteFile(comboBox1.SelectedValue.ToString(), scope);
            dynamic ProccessCrypt = scope.GetVariable("ProccessCrypt");
            dynamic result = ProccessCrypt(source_text.Text, text_key.Text, rb_encrypt.Checked);
            processed_text.Text = result.ToString();
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
