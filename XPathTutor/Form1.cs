﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
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
        SoundPlayer error = new SoundPlayer(XPathTutor.Properties.Resources.error_sound);

        public Form1()
        {
            InitializeComponent();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            openFile.FileName = "";
            openFile.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                filePath.Text = openFile.FileName;
                loadXML.Focus();
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
                        parseButton.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                error.Play();
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
            if (nodeList.Items.Count > 0)
            {
                nodeList.Show();
                nodeButton.Show();
            }
            else
            {
                nodeButton.Hide();
            }
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(expressionText.Text))
                {
                    error.Play();
                    MessageBox.Show("Please enter an expression!");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(inputText.Text))
                {
                    error.Play();
                    MessageBox.Show("Please enter XML!");
                    return;
                }
                outputText.Text = "";
                xmlDocument.LoadXml(inputText.Text);
                nav = xmlDocument.CreateNavigator();
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
                error.Play();
                MessageBox.Show("Error occurred. Original error: " + ex.Message);
            }
        }

        private void nodeButton_Click(object sender, EventArgs e)
        {
            try
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
            catch(Exception ex)
            {
                error.Play();
                MessageBox.Show("Error occurred. Original error: " + ex.Message);
            }
        }

        private void IncludeOtherFilters()
        {
            foreach (string function in new string[] { "text()", "last()", "x" })
            {
                filterList.Items.Add(function);
            }
            filterList.Show();
            filterButton.Show();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            string selectedNode = filterList.SelectedItem as string;
            if (expressionText.Text.LastIndexOf("/") < expressionText.Text.LastIndexOf("["))
            {
                error.Play();
                MessageBox.Show("Please remove previous filter");
                return;
            }
            if (selectedNode == "last()")
            {
                expressionText.Text = "(" + expressionText.Text + ")";
            }
            expressionText.Text += "[" + selectedNode + "]";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Stream myStream;
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFile.FilterIndex = 1;
                saveFile.RestoreDirectory = true;
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFile.OpenFile()) != null)
                    {
                        byte[] bArray = Encoding.UTF8.GetBytes(outputText.Text);
                        foreach (byte b in bArray)
                        {
                            myStream.WriteByte(b);
                        }
                        myStream.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                error.Play();
                MessageBox.Show("Error occurred. Original error: " + ex.Message);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(inputText.Text))
                {
                    error.Play();
                    MessageBox.Show("Please enter XML!");
                    return;
                }
                xmlDocument.LoadXml(inputText.Text);
                nav = xmlDocument.CreateNavigator();
                inputText.Text = FormatXMLText(xmlDocument);
                expressionText.Text = "";
                nodeList.Items.Clear();
                filterList.Items.Clear();
                FindAllNodes(nav);
                if (nodeList.Items.Count > 0)
                {
                    nodeList.Show();
                    nodeButton.Show();
                }
                parseButton.Hide();
            }
            catch (Exception ex)
            {
                error.Play();
                MessageBox.Show("Error occurred. Original error: " + ex.Message);
            }
        }

        private void expressionText_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (xmlDocument.HasChildNodes)
                {
                    string exp = expressionText.Text;
                    if ((exp == "/") || (exp.StartsWith("/") && !exp.EndsWith("/") && !exp.EndsWith("[") && !exp.EndsWith("]") && !exp.EndsWith("@") && !exp.EndsWith("(")))
                    {
                        FindChildNodes();
                        IncludeOtherFilters();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void parseButton_Click(object sender, EventArgs e)
        {
            refreshButton_Click(sender, e);
        }

        private void tutorialButton_Click(object sender, EventArgs e)
        {
            Tutorial tutorial = new Tutorial();
            tutorial.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //browse.BackgroundImage = XPathTutor.Properties.Resources.browse_up;
            //browse.Text = "";
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
