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
            this.browse = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadXML = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.inputText = new System.Windows.Forms.TextBox();
            this.expressionText = new System.Windows.Forms.TextBox();
            this.nodeList = new System.Windows.Forms.ComboBox();
            this.filterList = new System.Windows.Forms.ComboBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.executeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.hint = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.nodeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browse
            // 
            this.browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.Location = new System.Drawing.Point(750, 20);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(100, 40);
            this.browse.TabIndex = 0;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // filePath
            // 
            this.filePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePath.Location = new System.Drawing.Point(148, 25);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(582, 30);
            this.filePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path";
            // 
            // loadXML
            // 
            this.loadXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadXML.Location = new System.Drawing.Point(865, 20);
            this.loadXML.Name = "loadXML";
            this.loadXML.Size = new System.Drawing.Size(100, 40);
            this.loadXML.TabIndex = 3;
            this.loadXML.Text = "Load";
            this.loadXML.UseVisualStyleBackColor = true;
            this.loadXML.Click += new System.EventHandler(this.loadXML_Click);
            // 
            // inputText
            // 
            this.inputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputText.Location = new System.Drawing.Point(95, 95);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.inputText.Size = new System.Drawing.Size(450, 380);
            this.inputText.TabIndex = 4;
            this.inputText.WordWrap = false;
            // 
            // expressionText
            // 
            this.expressionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expressionText.Location = new System.Drawing.Point(630, 585);
            this.expressionText.Name = "expressionText";
            this.expressionText.Size = new System.Drawing.Size(450, 35);
            this.expressionText.TabIndex = 5;
            // 
            // nodeList
            // 
            this.nodeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.nodeList.FormattingEnabled = true;
            this.nodeList.Location = new System.Drawing.Point(95, 500);
            this.nodeList.Name = "nodeList";
            this.nodeList.Size = new System.Drawing.Size(200, 130);
            this.nodeList.TabIndex = 6;
            this.nodeList.Visible = false;
            // 
            // filterList
            // 
            this.filterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.filterList.FormattingEnabled = true;
            this.filterList.Location = new System.Drawing.Point(344, 500);
            this.filterList.Name = "filterList";
            this.filterList.Size = new System.Drawing.Size(200, 130);
            this.filterList.TabIndex = 7;
            this.filterList.Visible = false;
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(801, 634);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(110, 40);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // executeButton
            // 
            this.executeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeButton.Location = new System.Drawing.Point(972, 634);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(110, 40);
            this.executeButton.TabIndex = 11;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(980, 20);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 40);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(630, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(450, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Expression Builder";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hint
            // 
            this.hint.Location = new System.Drawing.Point(630, 530);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(450, 45);
            this.hint.TabIndex = 16;
            this.hint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(630, 634);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(110, 40);
            this.refreshButton.TabIndex = 8;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // outputText
            // 
            this.outputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputText.Location = new System.Drawing.Point(630, 95);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputText.Size = new System.Drawing.Size(450, 380);
            this.outputText.TabIndex = 10;
            this.outputText.WordWrap = false;
            // 
            // filterButton
            // 
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.Location = new System.Drawing.Point(389, 634);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(110, 40);
            this.filterButton.TabIndex = 17;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Visible = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // nodeButton
            // 
            this.nodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodeButton.Location = new System.Drawing.Point(140, 634);
            this.nodeButton.Name = "nodeButton";
            this.nodeButton.Size = new System.Drawing.Size(110, 40);
            this.nodeButton.TabIndex = 18;
            this.nodeButton.Text = "Node";
            this.nodeButton.UseVisualStyleBackColor = true;
            this.nodeButton.Visible = false;
            this.nodeButton.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1178, 844);
            this.Controls.Add(this.nodeButton);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.hint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.filterList);
            this.Controls.Add(this.nodeList);
            this.Controls.Add(this.expressionText);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.loadXML);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.browse);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 900);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "XPathTutor";
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
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label hint;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button nodeButton;
    }
}

