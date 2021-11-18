
namespace LabOOP2WinForms
{
    partial class XMLSearcher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DOMButton = new System.Windows.Forms.RadioButton();
            this.LINQButton = new System.Windows.Forms.RadioButton();
            this.AuthorName = new System.Windows.Forms.CheckBox();
            this.BookName = new System.Windows.Forms.CheckBox();
            this.Faculty = new System.Windows.Forms.CheckBox();
            this.Transform = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.AuthorNameBox = new System.Windows.Forms.TextBox();
            this.BookNameBox = new System.Windows.Forms.TextBox();
            this.AnotationBox = new System.Windows.Forms.TextBox();
            this.Anotation = new System.Windows.Forms.CheckBox();
            this.QualificationProperties = new System.Windows.Forms.CheckBox();
            this.Position = new System.Windows.Forms.CheckBox();
            this.Department = new System.Windows.Forms.CheckBox();
            this.QualificationBox = new System.Windows.Forms.TextBox();
            this.FacultyBox = new System.Windows.Forms.TextBox();
            this.DepartmentBox = new System.Windows.Forms.TextBox();
            this.PositionBox = new System.Windows.Forms.TextBox();
            this.SAXButton = new System.Windows.Forms.RadioButton();
            this.Status = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.Label();
            this.InputField = new System.Windows.Forms.TextBox();
            this.FileLoader = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DOMButton
            // 
            this.DOMButton.AutoSize = true;
            this.DOMButton.Location = new System.Drawing.Point(66, 385);
            this.DOMButton.Name = "DOMButton";
            this.DOMButton.Size = new System.Drawing.Size(113, 24);
            this.DOMButton.TabIndex = 0;
            this.DOMButton.TabStop = true;
            this.DOMButton.Text = "DOM Search";
            this.DOMButton.UseVisualStyleBackColor = true;
            // 
            // LINQButton
            // 
            this.LINQButton.AutoSize = true;
            this.LINQButton.Location = new System.Drawing.Point(66, 433);
            this.LINQButton.Name = "LINQButton";
            this.LINQButton.Size = new System.Drawing.Size(111, 24);
            this.LINQButton.TabIndex = 1;
            this.LINQButton.TabStop = true;
            this.LINQButton.Text = "LINQ Search";
            this.LINQButton.UseVisualStyleBackColor = true;
            // 
            // AuthorName
            // 
            this.AuthorName.AutoSize = true;
            this.AuthorName.Location = new System.Drawing.Point(63, 14);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(120, 24);
            this.AuthorName.TabIndex = 3;
            this.AuthorName.Text = "Author Name";
            this.AuthorName.UseVisualStyleBackColor = true;
            // 
            // BookName
            // 
            this.BookName.AutoSize = true;
            this.BookName.Location = new System.Drawing.Point(63, 61);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(109, 24);
            this.BookName.TabIndex = 4;
            this.BookName.Text = "Book Name";
            this.BookName.UseVisualStyleBackColor = true;
            // 
            // Faculty
            // 
            this.Faculty.AutoSize = true;
            this.Faculty.Location = new System.Drawing.Point(63, 217);
            this.Faculty.Name = "Faculty";
            this.Faculty.Size = new System.Drawing.Size(76, 24);
            this.Faculty.TabIndex = 5;
            this.Faculty.Text = "Faculty";
            this.Faculty.UseVisualStyleBackColor = true;
            // 
            // Transform
            // 
            this.Transform.Location = new System.Drawing.Point(66, 514);
            this.Transform.Name = "Transform";
            this.Transform.Size = new System.Drawing.Size(244, 29);
            this.Transform.TabIndex = 6;
            this.Transform.Text = "Перетворити у HTML";
            this.Transform.UseVisualStyleBackColor = true;
            this.Transform.Click += new System.EventHandler(this.Transform_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(205, 433);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(105, 29);
            this.Search.TabIndex = 8;
            this.Search.Text = "пошук";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // AuthorNameBox
            // 
            this.AuthorNameBox.Location = new System.Drawing.Point(269, 14);
            this.AuthorNameBox.Name = "AuthorNameBox";
            this.AuthorNameBox.Size = new System.Drawing.Size(125, 27);
            this.AuthorNameBox.TabIndex = 9;
            // 
            // BookNameBox
            // 
            this.BookNameBox.Location = new System.Drawing.Point(269, 61);
            this.BookNameBox.Name = "BookNameBox";
            this.BookNameBox.Size = new System.Drawing.Size(125, 27);
            this.BookNameBox.TabIndex = 10;
            // 
            // AnotationBox
            // 
            this.AnotationBox.Location = new System.Drawing.Point(269, 107);
            this.AnotationBox.Name = "AnotationBox";
            this.AnotationBox.Size = new System.Drawing.Size(125, 27);
            this.AnotationBox.TabIndex = 11;
            // 
            // Anotation
            // 
            this.Anotation.AutoSize = true;
            this.Anotation.Location = new System.Drawing.Point(63, 109);
            this.Anotation.Name = "Anotation";
            this.Anotation.Size = new System.Drawing.Size(97, 24);
            this.Anotation.TabIndex = 12;
            this.Anotation.Text = "Anotation";
            this.Anotation.UseVisualStyleBackColor = true;
            // 
            // QualificationProperties
            // 
            this.QualificationProperties.AutoSize = true;
            this.QualificationProperties.Location = new System.Drawing.Point(63, 166);
            this.QualificationProperties.Name = "QualificationProperties";
            this.QualificationProperties.Size = new System.Drawing.Size(188, 24);
            this.QualificationProperties.TabIndex = 13;
            this.QualificationProperties.Text = "Qualification properties";
            this.QualificationProperties.UseVisualStyleBackColor = true;
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Location = new System.Drawing.Point(63, 315);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(83, 24);
            this.Position.TabIndex = 14;
            this.Position.Text = "Position";
            this.Position.UseVisualStyleBackColor = true;
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Location = new System.Drawing.Point(63, 265);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(111, 24);
            this.Department.TabIndex = 16;
            this.Department.Text = "Department";
            this.Department.UseVisualStyleBackColor = true;
            // 
            // QualificationBox
            // 
            this.QualificationBox.Location = new System.Drawing.Point(269, 166);
            this.QualificationBox.Name = "QualificationBox";
            this.QualificationBox.Size = new System.Drawing.Size(125, 27);
            this.QualificationBox.TabIndex = 17;
            // 
            // FacultyBox
            // 
            this.FacultyBox.Location = new System.Drawing.Point(269, 214);
            this.FacultyBox.Name = "FacultyBox";
            this.FacultyBox.Size = new System.Drawing.Size(125, 27);
            this.FacultyBox.TabIndex = 19;
            // 
            // DepartmentBox
            // 
            this.DepartmentBox.Location = new System.Drawing.Point(269, 265);
            this.DepartmentBox.Name = "DepartmentBox";
            this.DepartmentBox.Size = new System.Drawing.Size(125, 27);
            this.DepartmentBox.TabIndex = 20;
            // 
            // PositionBox
            // 
            this.PositionBox.Location = new System.Drawing.Point(269, 315);
            this.PositionBox.Name = "PositionBox";
            this.PositionBox.Size = new System.Drawing.Size(125, 27);
            this.PositionBox.TabIndex = 21;
            // 
            // SAXButton
            // 
            this.SAXButton.AutoSize = true;
            this.SAXButton.Location = new System.Drawing.Point(205, 385);
            this.SAXButton.Name = "SAXButton";
            this.SAXButton.Size = new System.Drawing.Size(105, 24);
            this.SAXButton.TabIndex = 22;
            this.SAXButton.TabStop = true;
            this.SAXButton.Text = "SAX Search";
            this.SAXButton.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(753, 123);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(172, 20);
            this.Status.TabIndex = 23;
            this.Status.Text = "Статус: файл не обрано";
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Location = new System.Drawing.Point(543, 71);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(136, 20);
            this.FileName.TabIndex = 24;
            this.FileName.Text = "Введіть ім\'я файлу";
            // 
            // InputField
            // 
            this.InputField.Location = new System.Drawing.Point(543, 120);
            this.InputField.Name = "InputField";
            this.InputField.Size = new System.Drawing.Size(143, 27);
            this.InputField.TabIndex = 25;
            // 
            // FileLoader
            // 
            this.FileLoader.Location = new System.Drawing.Point(543, 176);
            this.FileLoader.Name = "FileLoader";
            this.FileLoader.Size = new System.Drawing.Size(143, 29);
            this.FileLoader.TabIndex = 26;
            this.FileLoader.Text = "Відкрити файл";
            this.FileLoader.UseVisualStyleBackColor = true;
            this.FileLoader.Click += new System.EventHandler(this.FileLoader_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(536, 514);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(143, 29);
            this.HelpButton.TabIndex = 28;
            this.HelpButton.Text = "Довідка";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 29);
            this.button1.TabIndex = 29;
            this.button1.Text = "Очистити поле";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // XMLSearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 720);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.FileLoader);
            this.Controls.Add(this.InputField);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.SAXButton);
            this.Controls.Add(this.PositionBox);
            this.Controls.Add(this.DepartmentBox);
            this.Controls.Add(this.FacultyBox);
            this.Controls.Add(this.QualificationBox);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.QualificationProperties);
            this.Controls.Add(this.Anotation);
            this.Controls.Add(this.AnotationBox);
            this.Controls.Add(this.BookNameBox);
            this.Controls.Add(this.AuthorNameBox);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Transform);
            this.Controls.Add(this.Faculty);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.AuthorName);
            this.Controls.Add(this.LINQButton);
            this.Controls.Add(this.DOMButton);
            this.Name = "XMLSearcher";
            this.Text = "Обробщик файлів";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton DOMButton;
        private System.Windows.Forms.RadioButton LINQButton;
        private System.Windows.Forms.CheckBox AuthorName;
        private System.Windows.Forms.CheckBox BookName;
        private System.Windows.Forms.CheckBox Faculty;
        private System.Windows.Forms.Button Transform;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox AuthorNameBox;
        private System.Windows.Forms.TextBox BookNameBox;
        private System.Windows.Forms.TextBox AnotationBox;
        private System.Windows.Forms.CheckBox Anotation;
        private System.Windows.Forms.CheckBox QualificationProperties;
        private System.Windows.Forms.CheckBox Position;
        private System.Windows.Forms.CheckBox Department;
        private System.Windows.Forms.TextBox QualificationBox;
        private System.Windows.Forms.TextBox FacultyBox;
        private System.Windows.Forms.TextBox DepartmentBox;
        private System.Windows.Forms.TextBox PositionBox;
        private System.Windows.Forms.RadioButton SAXButton;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.TextBox InputField;
        private System.Windows.Forms.Button FileLoader;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button button1;
    }
}

