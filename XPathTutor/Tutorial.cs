using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XPathTutor
{
    public partial class Tutorial : Form
    {
        public Tutorial()
        {
            InitializeComponent();
        }

        private void Tutorial_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = XPathTutor.Properties.Resources.tut2;
            textBox1.Text = "This XPath expression selects the document root. The document root is the top of the XML document node hierarchy, it contains all other nodes in the XML document.";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = XPathTutor.Properties.Resources.tut3;
            textBox1.Text = "This XPath expression selects all comment nodes which are children of the document root. In this case there is only one comment '<!-- Edited with XML Spy-->'.";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = XPathTutor.Properties.Resources.tut3;
            textBox1.Text = "This XPath expression selects the 'company' element node which is a child of the document root.In this XML document 'company' is the root element. The root element is the top level of the element hierarchy in the XML document, i.e.it contains all other elements and attributes in the XML document.The document root is not to be confused with the root element";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = XPathTutor.Properties.Resources.tut4;
            textBox1.Text = "This XPath expression selects all 'office' elements which are children of the 'company' element, which in turn is a child element of the document root.";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = XPathTutor.Properties.Resources.tut5;
            textBox1.Text = "This XPath expression selects the second 'office' element which is a child of the 'company' element, which in turn is a child element of the document root. The square brackets indicate a predicate which is used to filter sequences (in this case the sequence of 'office' nodes).'[2]' is short form for '[position() = 2]'.";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = XPathTutor.Properties.Resources.tut6;
            textBox1.Text = "This XPath expression selects the second 'office' element which is a child of the 'company' element, which in turn is a child element of the document root. The square brackets indicate a predicate which is used to filter sequences (in this case the sequence of 'office' nodes).'[2]' is short form for '[position() = 2]'.";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = XPathTutor.Properties.Resources.tut7;
            textBox1.Text = "This XPath expression selects the 'office' element(s) which have an attribute named 'location' with a value equal to 'Boston'.";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = XPathTutor.Properties.Resources.tut8;
            textBox1.Text = "This XPath expression selects all element children of the document root. '*' is an element wildcard.";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = XPathTutor.Properties.Resources.tut9;
            textBox1.Text = "This XPath expression selects all element descendants of the document root.'//' is the abbreviated form of the 'descendant-or-self' axis specifier.";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = XPathTutor.Properties.Resources.tut10;
            textBox1.Text = "This XPath expression selects the text node of the 'age' child element of the context node.";
        }
    }
}
