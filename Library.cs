using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP2WinForms
{
    public class Library
    {
        public string AuthorName = null;
        public string BookName = null;
        public string Anotation = null;
        public string QualificationProperties = null;
        public string Faculty = null;
        public string Department = null;
        public string Position = null;
        public Library() { }
        public Library(string[] data) 
        {
            AuthorName = data[0];
            BookName = data[1];
            Anotation = data[2];
            QualificationProperties = data[3];
            Faculty = data[4];
            Department = data[5];
            Position = data[6];
        }

        public bool Compare(Library library)
        {
            bool check = AuthorName == library.AuthorName &&
                                   BookName == library.BookName &&
                                   Anotation == library.Anotation &&
                                   QualificationProperties == library.QualificationProperties &&
                                   Faculty == library.Faculty &&
                                   Department == library.Department &&
                                   Position == library.Position;
            if (check) return true;
            return false;
        }

    }
}
