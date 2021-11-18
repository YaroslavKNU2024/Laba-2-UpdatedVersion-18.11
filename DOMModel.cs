using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace LabOOP2WinForms
{
    public class DOMModel : XMLProcessor
    {

        private XmlDocument _doc = new XmlDocument();
        private bool _valid = true;
        private string _authorName = null;
        private string _anotation = null;
        private string _qualificationProperties = null;
        private string _bookName = null;
        private string _faculty = null;
        private string _department = null;
        private string _position = null;
        private bool _breakCycle = false;

        public DOMModel(string path)
        {
            _doc.Load(path);
        }
        private List<Library> AddToList(List<Library> result)
        {
            if (_authorName != "")
            {
                Library _myLibrary = new Library();
                _myLibrary.AuthorName = _authorName;
                _myLibrary.Anotation = _anotation;
                _myLibrary.QualificationProperties = _qualificationProperties;
                _myLibrary.BookName = _bookName;
                _myLibrary.Faculty = _faculty;
                _myLibrary.Department = _department;
                _myLibrary.Position = _position;

                result.Add(_myLibrary);
            }
            return result;
        }

        private void MakeNull() {
            _valid = true;
            _authorName = null;
            _anotation = null;
            _qualificationProperties = null;
            _bookName = null;
            _faculty = null;
            _department = null;
            _position = null;
        }

        private void ResolveAuthorNames(XmlAttribute attribute, Library library)
        {
            if (library.AuthorName == null || (attribute.Value.Equals(library.AuthorName) || library.AuthorName.Equals(String.Empty)))
                _authorName = attribute.Value;
            else _breakCycle = true;
        }
        
        private void ResolveAnotations(XmlAttribute attribute, Library library)
        {
            if (library.Anotation == null || (attribute.Value.Equals(library.Anotation) || library.Anotation.Equals(String.Empty)))
                _anotation = attribute.Value;
            else _breakCycle = true;
        }
        
        private void ResolveQualificationProperties(XmlAttribute attribute, Library library)
        {
            if (library.QualificationProperties == null || (attribute.Value.Equals(library.QualificationProperties) || library.QualificationProperties.Equals(String.Empty)))
                _qualificationProperties = attribute.Value;
            else _breakCycle = true;
        }
        
        private void ResolveBookNames(XmlAttribute attribute, Library library)
        {
            if (library.BookName == null || (attribute.Value.Equals(library.BookName) || library.BookName.Equals(String.Empty)))
                _bookName = attribute.Value;
            else _breakCycle = true;
        }
        
        private void ResolveFaculties(XmlAttribute attribute, Library library)
        {
            if (library.Faculty == null || (attribute.Value.Equals(library.Faculty) || library.Faculty.Equals(String.Empty)))
                _faculty = attribute.Value;
            else _breakCycle = true;
        }

        private void ResolveDepartments(XmlAttribute attribute, Library library)
        {
            if (library.Department == null || (attribute.Value.Equals(library.Department) || library.Department.Equals(String.Empty)))
                _department = attribute.Value;
            else
                _breakCycle = true;
        }
        
        private void ResolvePositions(XmlAttribute attribute, Library library)
        {
            if (library.Position == null || (attribute.Value.Equals(library.Position) || library.Position.Equals(String.Empty)))
                _position = attribute.Value;
            else
                _breakCycle = true;
        }

        private void LoopThroughTheNode(Library library, XmlAttributeCollection ChildAttributes)
        {
            foreach (XmlAttribute attribute in ChildAttributes)
            {
                if (attribute.Name.Equals("AU"))
                    ResolveAuthorNames(attribute, library);
                else if (attribute.Name.Equals("AN"))
                    ResolveAnotations(attribute, library);
                else if (attribute.Name.Equals("PUB"))
                    ResolveQualificationProperties(attribute, library);
                else if (attribute.Name.Equals("BK_NAME"))
                    ResolveBookNames(attribute, library);
                else if (attribute.Name.Equals("FAC"))
                    ResolveFaculties(attribute, library);
                else if (attribute.Name.Equals("DE"))
                    ResolveDepartments(attribute, library);
                else if (attribute.Name.Equals("POS"))
                    ResolvePositions(attribute, library);

                if (_breakCycle)
                {
                    _valid = false;
                    _breakCycle = false;
                    return;
                }
            }
        }


        public List<Library> Algorithm(Library library, string path)
        {
            List<Library> result = new List<Library>();

            XmlNode node = _doc.DocumentElement;
            foreach (XmlNode ChildNode in node.ChildNodes)
            {
                MakeNull();
                try
                {
                    LoopThroughTheNode(library, ChildNode.Attributes);
                    if (_valid) 
                        result = AddToList(result);
                }
                catch (NullReferenceException) { return result; }
            }
            return AddToList(result);
        }
    }
}
