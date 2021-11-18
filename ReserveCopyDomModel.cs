//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Xml;

//namespace LabOOP2WinForms
//{
//    public class DOMModel : XMLProcessor
//    {

//        private XmlDocument _doc = new XmlDocument();
//        private bool _valid = true;
//        private string _authorName = null;
//        private string _anotation = null;
//        private string _qualificationProperties = null;
//        private string _bookName = null;
//        private string _faculty = null;
//        private string _department = null;
//        private string _position = null;
//        private bool _breakCycle = false;

//        public DOMModel(string path)
//        {
//            _doc.Load(path);
//        }
//        private List<Library> AddToList(List<Library> result)
//        {
//            if (_authorName != "")
//            {
//                Library _myLibrary = new Library();
//                _myLibrary.AuthorName = _authorName;
//                _myLibrary.Anotation = _anotation;
//                _myLibrary.QualificationProperties = _qualificationProperties;
//                _myLibrary.BookName = _bookName;
//                _myLibrary.Faculty = _faculty;
//                _myLibrary.Department = _department;
//                _myLibrary.Position = _position;

//                result.Add(_myLibrary);
//            }
//            return result;
//        }

//        private void MakeNull()
//        {
//            _valid = true;
//            _authorName = null;
//            _anotation = null;
//            _qualificationProperties = null;
//            _bookName = null;
//            _faculty = null;
//            _department = null;
//            _position = null;
//        }


//        public List<Library> Algorithm(Library problem, string path)
//        {
//            List<Library> result = new List<Library>();

//            XmlNode node = _doc.DocumentElement;
//            foreach (XmlNode ChildNode in node.ChildNodes)
//            {
//                MakeNull();
//                try
//                {
//                    foreach (XmlAttribute attribute in ChildNode.Attributes)
//                    {
//                        if (attribute.Name.Equals("AU"))
//                        {
//                            if (problem.AuthorName == null || (attribute.Value.Equals(problem.AuthorName) || problem.AuthorName.Equals(String.Empty)))
//                                _authorName = attribute.Value;
//                            //else
//                            //{
//                            //    _valid = false;
//                            //    break;
//                            //}
//                            else _breakCycle = true;

//                        }
//                        else if (attribute.Name.Equals("AN"))
//                        {
//                            if (problem.Anotation == null || (attribute.Value.Equals(problem.Anotation) || problem.Anotation.Equals(String.Empty)))
//                                _anotation = attribute.Value;
//                            //else
//                            //{
//                            //    _valid = false;
//                            //    break;
//                            //}
//                            else _breakCycle = true;

//                        }
//                        else if (attribute.Name.Equals("PUB"))
//                        {
//                            if (problem.QualificationProperties == null || (attribute.Value.Equals(problem.QualificationProperties) || problem.QualificationProperties.Equals(String.Empty)))
//                                _qualificationProperties = attribute.Value;
//                            //else
//                            //{
//                            //    _valid = false;
//                            //    break;
//                            //}
//                            else _breakCycle = true;

//                        }
//                        else if (attribute.Name.Equals("BK_NAME"))
//                        {
//                            if (problem.BookName == null || (attribute.Value.Equals(problem.BookName) || problem.BookName.Equals(String.Empty)))
//                                _bookName = attribute.Value;
//                            //else
//                            //{
//                            //    _valid = false;
//                            //    break;
//                            //}
//                            else _breakCycle = true;

//                        }
//                        else if (attribute.Name.Equals("FAC"))
//                        {
//                            if (problem.Faculty == null || (attribute.Value.Equals(problem.Faculty) || problem.Faculty.Equals(String.Empty)))
//                                _faculty = attribute.Value;
//                            //else
//                            //{
//                            //    _valid = false;
//                            //    break;
//                            else _breakCycle = true;
//                            //}
//                        }
//                        else if (attribute.Name.Equals("DE"))
//                        {
//                            if (problem.Department == null || (attribute.Value.Equals(problem.Department) || problem.Department.Equals(String.Empty)))
//                                _department = attribute.Value;
//                            //else
//                            //{
//                            //    _valid = false;
//                            //    break;
//                            //}
//                            else _breakCycle = true;

//                        }
//                        else if (attribute.Name.Equals("POS"))
//                        {
//                            if (problem.Position == null || (attribute.Value.Equals(problem.Position) || problem.Position.Equals(String.Empty)))
//                                _position = attribute.Value;
//                            else _breakCycle = true;
//                            //{
//                            //    _valid = false;
//                            //    break;
//                            //}
//                        }
//                        if (_breakCycle)
//                        {
//                            _valid = false;
//                            _breakCycle = false;
//                            break;
//                        }
//                    }
//                    if (_valid)
//                        result = AddToList(result);
//                }
//                catch (NullReferenceException)
//                {
//                    return result;
//                }
//            }
//            return AddToList(result);

//        }

//        public static string getFilePath(string fileName)
//        {
//            return Path.Combine(Environment.GetFolderPath(
//            Environment.SpecialFolder.Desktop), fileName);
//        }
//public static string getFilePath(string fileName)
//{
//    return Path.Combine(Environment.GetFolderPath(
//    Environment.SpecialFolder.Desktop), fileName);
//}

//    }
//}







//SAXModel

//var sb = new StringBuilder();

//var xmlReader = new
//XmlTextReader(DOMModel.getFilePath("Library.xml"));

//while (xmlReader.Read())
//{
//    switch (xmlReader.NodeType)
//    {
//        case XmlNodeType.XmlDeclaration:
//        case XmlNodeType.Element:
//        case XmlNodeType.Comment:
//            if (xmlReader.Name == "IVAN" || xmlReader.Value == "IVAN")
//            {
//                sb.AppendFormat("{0}: {1} = {2}",
//    xmlReader.NodeType,
//            xmlReader.Name,
//            xmlReader.Value);
//                sb.AppendLine();
//            }
//            break;

//        case XmlNodeType.Text:
//            sb.AppendFormat(" - Value: {0}", xmlReader.Value);
//            sb.AppendLine();
//            break;
//    }
//    if (xmlReader.HasAttributes)
//    {
//        while (xmlReader.MoveToNextAttribute())
//        {
//            if (xmlReader.Name == "IVAN" || xmlReader.Value == "IVAN")
//            {
//                sb.AppendFormat(" - Attribute: {0} = {1}",
//                xmlReader.Name,
//                xmlReader.Value);
//                sb.AppendLine();
//            }
//        }
//    }
//}
//xmlReader.Close();
//Console.WriteLine(sb.ToString());