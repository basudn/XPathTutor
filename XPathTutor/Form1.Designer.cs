namespace XPathTutor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.browse = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadXML = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.inputText = new System.Windows.Forms.TextBox();
            this.expressionText = new System.Windows.Forms.TextBox();
            this.nodeList = new System.Windows.Forms.ComboBox();
            this.filterList = new System.Windows.Forms.ComboBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.expLabel = new System.Windows.Forms.Label();
            this.hint = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.nodeButton = new System.Windows.Forms.Button();
            this.parseButton = new System.Windows.Forms.Button();
            this.tutorialButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.Transparent;
            this.browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.Location = new System.Drawing.Point(455, 11);
            this.browse.Margin = new System.Windows.Forms.Padding(2);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(108, 47);
            this.browse.TabIndex = 0;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // filePath
            // 
            this.filePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePath.Location = new System.Drawing.Point(99, 16);
            this.filePath.Margin = new System.Windows.Forms.Padding(2);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(352, 23);
            this.filePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path";
            // 
            // loadXML
            // 
            this.loadXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadXML.Location = new System.Drawing.Point(567, 12);
            this.loadXML.Margin = new System.Windows.Forms.Padding(2);
            this.loadXML.Name = "loadXML";
            this.loadXML.Size = new System.Drawing.Size(99, 45);
            this.loadXML.TabIndex = 3;
            this.loadXML.Text = "Load";
            this.loadXML.UseVisualStyleBackColor = true;
            this.loadXML.Click += new System.EventHandler(this.loadXML_Click);
            // 
            // inputText
            // 
            this.inputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputText.Location = new System.Drawing.Point(63, 62);
            this.inputText.Margin = new System.Windows.Forms.Padding(2);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.inputText.Size = new System.Drawing.Size(301, 249);
            this.inputText.TabIndex = 4;
            this.inputText.WordWrap = false;
            // 
            // expressionText
            // 
            this.expressionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expressionText.Location = new System.Drawing.Point(420, 380);
            this.expressionText.Margin = new System.Windows.Forms.Padding(2);
            this.expressionText.Name = "expressionText";
            this.expressionText.Size = new System.Drawing.Size(301, 26);
            this.expressionText.TabIndex = 5;
            this.expressionText.WordWrap = false;
            this.expressionText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.expressionText_KeyUp);
            // 
            // nodeList
            // 
            this.nodeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.nodeList.FormattingEnabled = true;
            this.nodeList.Location = new System.Drawing.Point(63, 325);
            this.nodeList.Margin = new System.Windows.Forms.Padding(2);
            this.nodeList.Name = "nodeList";
            this.nodeList.Size = new System.Drawing.Size(134, 86);
            this.nodeList.TabIndex = 6;
            this.nodeList.Visible = false;
            // 
            // filterList
            // 
            this.filterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.filterList.FormattingEnabled = true;
            this.filterList.Location = new System.Drawing.Point(230, 325);
            this.filterList.Margin = new System.Windows.Forms.Padding(2);
            this.filterList.Name = "filterList";
            this.filterList.Size = new System.Drawing.Size(134, 86);
            this.filterList.TabIndex = 7;
            this.filterList.Visible = false;
            // 
            // executeButton
            // 
            this.executeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeButton.Location = new System.Drawing.Point(648, 412);
            this.executeButton.Margin = new System.Windows.Forms.Padding(2);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(74, 26);
            this.executeButton.TabIndex = 11;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(670, 13);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(85, 44);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // expLabel
            // 
            this.expLabel.BackColor = System.Drawing.Color.Transparent;
            this.expLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expLabel.Location = new System.Drawing.Point(420, 325);
            this.expLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.expLabel.Name = "expLabel";
            this.expLabel.Size = new System.Drawing.Size(300, 15);
            this.expLabel.TabIndex = 15;
            this.expLabel.Text = "Expression Builder";
            this.expLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hint
            // 
            this.hint.BackColor = System.Drawing.Color.Transparent;
            this.hint.Location = new System.Drawing.Point(420, 344);
            this.hint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(300, 29);
            this.hint.TabIndex = 16;
            this.hint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(420, 412);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(74, 26);
            this.refreshButton.TabIndex = 8;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // outputText
            // 
            this.outputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputText.Location = new System.Drawing.Point(420, 62);
            this.outputText.Margin = new System.Windows.Forms.Padding(2);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputText.Size = new System.Drawing.Size(301, 249);
            this.outputText.TabIndex = 10;
            this.outputText.WordWrap = false;
            // 
            // filterButton
            // 
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.Location = new System.Drawing.Point(260, 412);
            this.filterButton.Margin = new System.Windows.Forms.Padding(2);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(74, 26);
            this.filterButton.TabIndex = 17;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Visible = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // nodeButton
            // 
            this.nodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodeButton.Location = new System.Drawing.Point(93, 412);
            this.nodeButton.Margin = new System.Windows.Forms.Padding(2);
            this.nodeButton.Name = "nodeButton";
            this.nodeButton.Size = new System.Drawing.Size(74, 26);
            this.nodeButton.TabIndex = 18;
            this.nodeButton.Text = "Node";
            this.nodeButton.UseVisualStyleBackColor = true;
            this.nodeButton.Visible = false;
            this.nodeButton.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // parseButton
            // 
            this.parseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parseButton.Location = new System.Drawing.Point(177, 325);
            this.parseButton.Margin = new System.Windows.Forms.Padding(2);
            this.parseButton.Name = "parseButton";
            this.parseButton.Size = new System.Drawing.Size(74, 26);
            this.parseButton.TabIndex = 19;
            this.parseButton.Text = "Parse";
            this.parseButton.UseVisualStyleBackColor = true;
            this.parseButton.Click += new System.EventHandler(this.parseButton_Click);
            // 
            // tutorialButton
            // 
            this.tutorialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialButton.Location = new System.Drawing.Point(534, 412);
            this.tutorialButton.Margin = new System.Windows.Forms.Padding(2);
            this.tutorialButton.Name = "tutorialButton";
            this.tutorialButton.Size = new System.Drawing.Size(74, 26);
            this.tutorialButton.TabIndex = 20;
            this.tutorialButton.Text = "Tutorial";
            this.tutorialButton.UseVisualStyleBackColor = true;
            this.tutorialButton.Click += new System.EventHandler(this.tutorialButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = " ©2016 Debayan Basu, Vijay Jain, Sushant Karnik";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::XPathTutor.Properties.Resources.xpath;
            this.pictureBox1.Location = new System.Drawing.Point(208, 474);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(423, 474);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::XPathTutor.Properties.Resources.white_wallpaper_18;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 558);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tutorialButton);
            this.Controls.Add(this.parseButton);
            this.Controls.Add(this.nodeButton);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.hint);
            this.Controls.Add(this.expLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.filterList);
            this.Controls.Add(this.nodeList);
            this.Controls.Add(this.expressionText);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.loadXML);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.browse);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(806, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(806, 597);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XPathTutor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loadXML;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.TextBox expressionText;
        private System.Windows.Forms.ComboBox nodeList;
        private System.Windows.Forms.ComboBox filterList;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label expLabel;
        private System.Windows.Forms.Label hint;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button nodeButton;
        private System.Windows.Forms.Button parseButton;
        private System.Windows.Forms.Button tutorialButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

