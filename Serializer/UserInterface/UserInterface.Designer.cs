namespace UserInterface
{
    partial class UserInterface
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
            this.labelInputFile = new System.Windows.Forms.Label();
            this.textBoxInputFile = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelSourceFile = new System.Windows.Forms.Label();
            this.listBoxSourceFiles = new System.Windows.Forms.ListBox();
            this.buttonXml = new System.Windows.Forms.Button();
            this.buttonHtml = new System.Windows.Forms.Button();
            this.buttonOutputFolder = new System.Windows.Forms.Button();
            this.textBoxOutputFolder = new System.Windows.Forms.TextBox();
            this.OutputPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInputFile
            // 
            this.labelInputFile.AutoSize = true;
            this.labelInputFile.Location = new System.Drawing.Point(63, 53);
            this.labelInputFile.Name = "labelInputFile";
            this.labelInputFile.Size = new System.Drawing.Size(50, 13);
            this.labelInputFile.TabIndex = 1;
            this.labelInputFile.Text = "Input File";
            // 
            // textBoxInputFile
            // 
            this.textBoxInputFile.Location = new System.Drawing.Point(132, 50);
            this.textBoxInputFile.Name = "textBoxInputFile";
            this.textBoxInputFile.Size = new System.Drawing.Size(264, 20);
            this.textBoxInputFile.TabIndex = 2;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(132, 95);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(112, 23);
            this.buttonBrowse.TabIndex = 3;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(284, 95);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelSourceFile
            // 
            this.labelSourceFile.AutoSize = true;
            this.labelSourceFile.Location = new System.Drawing.Point(48, 160);
            this.labelSourceFile.Name = "labelSourceFile";
            this.labelSourceFile.Size = new System.Drawing.Size(65, 13);
            this.labelSourceFile.TabIndex = 5;
            this.labelSourceFile.Text = "Source Files";
            // 
            // listBoxSourceFiles
            // 
            this.listBoxSourceFiles.FormattingEnabled = true;
            this.listBoxSourceFiles.Location = new System.Drawing.Point(132, 160);
            this.listBoxSourceFiles.Name = "listBoxSourceFiles";
            this.listBoxSourceFiles.Size = new System.Drawing.Size(264, 199);
            this.listBoxSourceFiles.TabIndex = 6;
            // 
            // buttonXml
            // 
            this.buttonXml.Location = new System.Drawing.Point(132, 474);
            this.buttonXml.Name = "buttonXml";
            this.buttonXml.Size = new System.Drawing.Size(264, 23);
            this.buttonXml.TabIndex = 7;
            this.buttonXml.Text = "Convert to XML";
            this.buttonXml.UseVisualStyleBackColor = true;
            this.buttonXml.Click += new System.EventHandler(this.buttonXml_Click);
            // 
            // buttonHtml
            // 
            this.buttonHtml.Location = new System.Drawing.Point(132, 519);
            this.buttonHtml.Name = "buttonHtml";
            this.buttonHtml.Size = new System.Drawing.Size(264, 23);
            this.buttonHtml.TabIndex = 8;
            this.buttonHtml.Text = "Convert to HTML";
            this.buttonHtml.UseVisualStyleBackColor = true;
            this.buttonHtml.Click += new System.EventHandler(this.buttonHtml_Click);
            // 
            // buttonOutputFolder
            // 
            this.buttonOutputFolder.Location = new System.Drawing.Point(132, 563);
            this.buttonOutputFolder.Name = "buttonOutputFolder";
            this.buttonOutputFolder.Size = new System.Drawing.Size(264, 23);
            this.buttonOutputFolder.TabIndex = 9;
            this.buttonOutputFolder.Text = "Open Output Folder";
            this.buttonOutputFolder.UseVisualStyleBackColor = true;
            // 
            // textBoxOutputFolder
            // 
            this.textBoxOutputFolder.Location = new System.Drawing.Point(132, 422);
            this.textBoxOutputFolder.Name = "textBoxOutputFolder";
            this.textBoxOutputFolder.Size = new System.Drawing.Size(264, 20);
            this.textBoxOutputFolder.TabIndex = 10;
            // 
            // OutputPath
            // 
            this.OutputPath.AutoSize = true;
            this.OutputPath.Location = new System.Drawing.Point(49, 425);
            this.OutputPath.Name = "OutputPath";
            this.OutputPath.Size = new System.Drawing.Size(64, 13);
            this.OutputPath.TabIndex = 11;
            this.OutputPath.Text = "Output Path";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 622);
            this.Controls.Add(this.OutputPath);
            this.Controls.Add(this.textBoxOutputFolder);
            this.Controls.Add(this.buttonOutputFolder);
            this.Controls.Add(this.buttonHtml);
            this.Controls.Add(this.buttonXml);
            this.Controls.Add(this.listBoxSourceFiles);
            this.Controls.Add(this.labelSourceFile);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxInputFile);
            this.Controls.Add(this.labelInputFile);
            this.Name = "UserInterface";
            this.Text = "Serializer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInputFile;
        private System.Windows.Forms.TextBox textBoxInputFile;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelSourceFile;
        private System.Windows.Forms.ListBox listBoxSourceFiles;
        private System.Windows.Forms.Button buttonXml;
        private System.Windows.Forms.Button buttonHtml;
        private System.Windows.Forms.Button buttonOutputFolder;
        private System.Windows.Forms.TextBox textBoxOutputFolder;
        private System.Windows.Forms.Label OutputPath;
    }
}

