using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace LabOOP2WinForms
{
    public class SAXSearch: XMLProcessor
    {
        List<Library> information = new List<Library>();
        XmlReader _reader;
        
        public SAXSearch(string path)
        {
            _reader = new XmlTextReader(path);
        }
        public List<Library> Algorithm(Library library, string path)
        {
            information.Clear();
            List<Library> result = new List<Library>();
            while (_reader.Read())
            {
                if (_reader.Name == "Book")
                {
                    Library pb = new Library();
                    if (_reader.HasAttributes)
                    {
                        while(_reader.MoveToNextAttribute())
                        {
                            if (_reader.Name == "AU")
                                pb.AuthorName = _reader.Value;
                            else if (_reader.Name == "AN")
                                pb.Anotation = _reader.Value;
                            else if (_reader.Name == "PUB")
                                pb.QualificationProperties = _reader.Value;
                            else if (_reader.Name == "BK_NAME")
                                pb.BookName = _reader.Value;
                            else if (_reader.Name == "DE")
                                pb.Department = _reader.Value;
                            else if (_reader.Name == "FAC")
                                pb.Faculty = _reader.Value;
                            else if (_reader.Name == "POS")
                                pb.Position = _reader.Value;
                        }
                    }
                    bool CheckIfAllAreNull = (pb.AuthorName == null && pb.Anotation == null && pb.BookName == null && pb.QualificationProperties == null &&
                                                               pb.Department == null && pb.Faculty == null && pb.Position == null);
                    if (!CheckIfAllAreNull)
                        result.Add(pb);
                }
            }

            information = Filter(result, library);
            return information;
        }
        public List<Library> Filter(List<Library> allLibraries, Library param)
        {
            List<Library> result = new List<Library>();
            if (allLibraries != null)
            {
                foreach(Library e in allLibraries)
                {
                    try
                    {
                        //bool CheckIfAllBlank =
                        //    param.AuthorName == null && param.Anotation == null && param.BookName == null && 
                        //    param.QualificationProperties == null && param.Department == null && param.Faculty == null && 
                        //    param.Position == null;
                        if (
                            (param.AuthorName == null || e.AuthorName == param.AuthorName) &&
                            (param.Anotation == null || e.Anotation == param.Anotation) &&
                            (param.BookName == null || e.BookName == param.BookName) &&
                            (param.QualificationProperties == null || e.QualificationProperties == param.QualificationProperties) &&
                            (param.Department == null || e.Department == param.Department) &&
                            (param.Faculty == null || e.Faculty == param.Faculty) &&
                            (param.Position == null || e.Position == param.Position)
                            )
                            result.Add(e);
                    }
                    catch (NullReferenceException) { 
                        MessageBox.Show("ERROR ACCESSING NULLPTR");
                    }
                }
            }
            return result;
        }
    }
}
