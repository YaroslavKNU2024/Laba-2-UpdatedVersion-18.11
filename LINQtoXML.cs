using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LabOOP2WinForms
{
    public class LINQtoXML: XMLProcessor
    {
        List<Library> result= new List<Library>();
        XDocument doc = new XDocument();
        public LINQtoXML(string path)
        {
            doc = XDocument.Load(@path);
        }
        public List<Library> Algorithm (Library library, string path)
        {
            List<XElement> match = (from value in doc.Descendants("Book")
                                     where
                                     (library.BookName == null || library.BookName == value.Attribute("BK_NAME").Value) &&
                                     (library.AuthorName == null || library.AuthorName == value.Attribute("AU").Value) &&
                                     (library.Anotation == null || library.Anotation == value.Attribute("AN").Value) &&
                                     (library.QualificationProperties == null || library.QualificationProperties == value.Attribute("PUB").Value) &&
                                    (library.Faculty == null || library.Faculty == value.Attribute("FAC").Value) &&
                                    (library.Department == null || library.Department == value.Attribute("DE").Value) &&
                                    (library.Position == null || library.Position == value.Attribute("POS").Value)
                                     select value).ToList();

            foreach (XElement obj in match)
            {
                Library prob = new Library();
                prob.BookName = obj.Attribute("BK_NAME").Value;
                prob.AuthorName = obj.Attribute("AU").Value;
                prob.Anotation = obj.Attribute("AN").Value;
                prob.QualificationProperties = obj.Attribute("PUB").Value;
                prob.Faculty = obj.Attribute("FAC").Value;
                prob.Department = obj.Attribute("DE").Value;
                prob.Position = obj.Attribute("POS").Value;
                //if (prob.BookName != "" && prob.AuthorName != "" && prob.Anotation != "" && prob.QualificationProperties != "" &&
                //    prob.Faculty != "" && prob.Department != "" && prob.Position != "")
                        result.Add(prob);
            }
            return result;
        }
    }
}
