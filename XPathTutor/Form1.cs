using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace XPathTutor
{
    public partial class Form1 : Form
    {
        XmlDocument xmlDocument = new XmlDocument();
        XPathNavigator nav;
        XPathNodeIterator NodeIter;

        public Form1()
        {
            InitializeComponent();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath.Text = openFileDialog1.FileName;
            }
        }

        private void loadXML_Click(object sender, EventArgs e)
        {
            Stream fileStream = null;
            try
            {
                if ((fileStream = new FileStream(filePath.Text, FileMode.Open)) != null)
                {
                    using (fileStream)
                    {
                        StreamReader reader = new StreamReader(fileStream);
                        string textXML = reader.ReadToEnd();
                        xmlDocument.LoadXml(textXML);
                        nav = xmlDocument.CreateNavigator();
                        nodeList.Items.Clear();
                        FindAllNodes(nav);
                        if (nodeList.Items.Count > 0)
                        {
                            nodeList.Show();
                            nodeButton.Show();
                        }
                        inputText.Text = FormatXMLText(xmlDocument);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred. Original error: " + ex.Message);
            }
        }

        private string FormatXMLText(XmlDocument document)
        {
            StringWriter stringWriter = new StringWriter();
            XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter);
            xmlTextWriter.Formatting = Formatting.Indented;
            document.WriteContentTo(xmlTextWriter);
            return stringWriter.ToString();
        }

        private void FindAllNodes(XPathNavigator nav)
        {
            XPathNodeIterator iterator = nav.SelectChildren(XPathNodeType.Element);
            while (iterator.MoveNext())
            {
                string nodeName = iterator.Current.Name;
                Console.WriteLine(nodeName);
                if (!nodeList.Items.Contains(nodeName))
                {
                    nodeList.Items.Add(nodeName);
                }
                if (iterator.Current.HasChildren)
                {
                    FindAllNodes(iterator.Current);
                }
            }
        }

        private void FindChildNodes()
        {
            nodeList.Items.Clear();
            filterList.Items.Clear();
            NodeIter = nav.Select(expressionText.Text);
            while (NodeIter.MoveNext())
            {
                XPathNodeIterator iterator = NodeIter.Current.SelectChildren(XPathNodeType.Element);
                while (iterator.MoveNext())
                {
                    string nodeName = iterator.Current.Name;
                    Console.WriteLine(nodeName);
                    if (!nodeList.Items.Contains(nodeName))
                    {
                        nodeList.Items.Add(nodeName);
                    }
                    if (!filterList.Items.Contains(nodeName) && iterator.Current.SelectChildren(XPathNodeType.Element).Count == 0)
                    {
                        filterList.Items.Add(nodeName);
                    }
                }
            }
            XmlNodeList nodes = xmlDocument.SelectNodes(expressionText.Text);
            foreach (XmlNode node in nodes)
            {
                if (node.NodeType == XmlNodeType.Element)
                {
                    XmlAttributeCollection attrs = node.Attributes;
                    foreach (XmlAttribute attr in attrs)
                    {
                        string attrName = "@" + attr.Name;
                        Console.WriteLine(attrName);
                        if (!nodeList.Items.Contains(attrName))
                        {
                            nodeList.Items.Add(attrName);
                        }
                        if (!filterList.Items.Contains(attrName))
                        {
                            filterList.Items.Add(attrName);
                        }
                    }
                }
            }
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(expressionText.Text))
                {
                    MessageBox.Show("Please enter an expression!");
                    return;
                }
                outputText.Text = "";
                xmlDocument.LoadXml(inputText.Text);
                inputText.Text = FormatXMLText(xmlDocument);
                NodeIter = nav.Select(expressionText.Text);
                while (NodeIter.MoveNext())
                {
                    outputText.Text += NodeIter.Current.OuterXml + Environment.NewLine;
                }
                if (string.IsNullOrWhiteSpace(outputText.Text))
                {
                    saveButton.Enabled = false;
                    outputText.Text = "No data to display!";
                }
                else
                {
                    saveButton.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred. Original error: " + ex.Message);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            expressionText.Text = "";
            nodeList.Items.Clear();
            FindAllNodes(nav);
        }

        private void nodeButton_Click(object sender, EventArgs e)
        {
            string selectedNode = nodeList.SelectedItem as string;
            if (string.IsNullOrWhiteSpace(expressionText.Text) || !expressionText.Text.Contains("/"))
            {
                expressionText.Text = "/";
            }
            if (selectedNode == xmlDocument.DocumentElement.Name)
            {
                expressionText.Text += selectedNode;
            }
            else
            {
                expressionText.Text += "/" + selectedNode;
            }
            FindChildNodes();
            IncludeOtherFilters();
        }

        private void IncludeOtherFilters()
        {
            foreach (string function in new string[]{ })
            {
                filterList.Items.Add(function);
            }
            if (filterList.Items.Count > 0)
            {
                filterList.Show();
                filterButton.Show();
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            string selectedNode = filterList.SelectedItem as string;
            if (expressionText.Text.LastIndexOf("/")<expressionText.Text.LastIndexOf("["))
            {
                MessageBox.Show("Please remove previous filter");
                return;
            }
            expressionText.Text += "[" + selectedNode + "]";    
        }
    }
}
