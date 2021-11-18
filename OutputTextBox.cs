using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LabOOP2WinForms
{
    public partial class OutputTextBox : Form
    {
        private XMLSearcher _mainForm = null;
        public OutputTextBox(Form callingForm)
        {
            _mainForm = callingForm as XMLSearcher;
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(1000, 0);
        }
        public void Printer()
        {
            Output.Clear();
            int i = 1;
            Console.WriteLine("Alg+");
            foreach (Library pr in _mainForm.final)
            {
                Output.AppendText(i++ + "." + "\n");
                Output.AppendText("Author name: " + pr.AuthorName + "\n");
                Output.AppendText("Book name: " + pr.BookName + "\n");
                Output.AppendText("Anotation: " + pr.Anotation + "\n");
                Output.AppendText("Qualification properties: " + pr.QualificationProperties + "\n");
                Output.AppendText("Faculty: " + pr.Faculty + "\n");
                Output.AppendText("Department: " + pr.Department + "\n");
                Output.AppendText("Position:  " + pr.Position + "\n");
            }
        }
        public void ClearFunction() => Output.Clear();
    }
}
