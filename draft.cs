using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP2WinForms
{
    class draft
    {
        /*
        public void xDocumentConstructor()
        {
            var doc = new XDocument(
                new XElement("libraryDatabase",
                             new XElement("book",
                                          new XAttribute("BK_ID", "1"),
                                          new XAttribute("BK_NAME", "Програмування"),
                            new XAttribute("BK_INFO", "Інформація про Програмування"),
                                          new XAttribute("BK_DC", "1"),
                                          new XAttribute("DC_NAME", "ПРОГРАМУВАННЯ"),
                                          new XElement("author",
                                                       new XAttribute("AU_ID", "1"),
                                                     new XAttribute("AU_NAME", "Зубенко В.В.")),
                                          new XElement("author",
                                                       new XAttribute("AU_ID", "2"),
                                                  new XAttribute("AU_NAME", "Омельчук Л.Л."))),
                              new XElement("book",
                                          new XAttribute("BK_ID", "2"),
                                          new XAttribute("BK_NAME", "Математична логiка"),
                                          new XAttribute("BK_INFO", "Інформація про МЛ"),
                                          new XAttribute("BK_DC", "2"),
                                          new XAttribute("DC_NAME", "Логiка"),
                                          new XElement("author",
                                                       new XAttribute("AU_ID", "3"),
                                               new XAttribute("AU_NAME", "Нiкiтченко М.С.")),
                                          new XElement("author",
                                                       new XAttribute("AU_ID", "4"),
                                                 new XAttribute("AU_NAME", "Шкiльняк С.С."))),
                               new XElement("book",
                                          new XAttribute("BK_ID", "3"),
                                        new XAttribute("BK_NAME", "Програмна iнженерiя"),
               new XAttribute("BK_INFO", "Інформація про Програмну iнженерiю"),
                                          new XAttribute("BK_DC", "1"),
                                          new XAttribute("DC_NAME", "ПРОГРАМУВАННЯ"),
                                          new XElement("author",
                                                       new XAttribute("AU_ID", "5"),
                                               new XAttribute("AU_NAME", "Лавріщева К.М.")))
                          ));

            doc.Save(DOMModel.getFilePath("XDocumentTest.xml"));
            Console.WriteLine("XDocument Saved");
        }
*/
        //public void lINQQuery()
        //{
        //    var doc = XDocument.Load(DOMModel.getFilePath("XDocumentTest.xml"));
        //    var result = (from book in doc.Descendants("book")
        //                  where book.Attribute("BK_ID").Value == "1"
        //                  select new
        //                  {
        //                      bk_id = (int)book.Attribute("BK_ID"),
        //                      bk_name = (string)book.Attribute("BK_NAME"),
        //                      bk_info = (string)book.Attribute("BK_INFO"),
        //                      bk_dc = (int)book.Attribute("BK_DC"),
        //                      dc_name = (string)book.Attribute("DC_NAME")
        //                  }).FirstOrDefault();
        //    Console.WriteLine(string.Format("BK_ID:{0}\nBK_NAME:{1} \nBK_INFO:{2} \nDC_NAME:{3}",
        //                    result.bk_id, result.bk_name, result.bk_info, result.dc_name));
        //}
        //public void lINQQuery1()
        //{
        //    var doc = XDocument.Load(DOMModel.getFilePath("XDocumentTest.xml"));
        //    var result = (from book in doc.Descendants("book")
        //                  where book.Attribute("BK_DC").Value == "1"
        //                  select new
        //                  {
        //                      bk_id = (int)book.Attribute("BK_ID"),
        //                      bk_name = (string)book.Attribute("BK_NAME"),
        //                      bk_info = (string)book.Attribute("BK_INFO"),
        //                      bk_dc = (int)book.Attribute("BK_DC"),
        //                      dc_name = (string)book.Attribute("DC_NAME")
        //                  }).ToList();
        //    foreach (var b in result)
        //    {
        //        Console.WriteLine(string.Format("BK_ID:{0}\nBK_NAME:{1} \nBK_INFO:{2} \nDC_NAME:{3}",
        //        b.bk_id, b.bk_name, b.bk_info, b.dc_name));
        //    }
        //}

        //public void lINQQuery2()
        //{
        //    var doc = XDocument.Load(DOMModel.getFilePath("XDocumentTest.xml"));
        //    var result = (from book in doc.Descendants("book")
        //                  where book.Descendants("author").Attributes("AU_ID").Any(z => z.Value == "4")
        //                  select new
        //                  {
        //                      bk_dc = (int)book.Attribute("BK_DC"),
        //                      dc_name = (string)book.Attribute("DC_NAME")
        //                  }).Distinct().ToList();
        //    foreach (var b in result)
        //    {
        //        Console.WriteLine(string.Format("BK_DC:{0}\nDC_NAME:{1}",
        //        b.bk_dc, b.dc_name));
        //    }
        //}


        //DOMModel

        //public List<Library> Algorithm (Library problem, string pathn)
        //{
        //    List<List<Library>> information = new List<List<Library>>();
        //    try
        //    {
        //        if (problem._authorName != null) information.Add(SearchByParams("Book", "AU", problem._authorName, doc, 1));
        //        if (problem._anotation != null) information.Add(SearchByParams("Book", "AN", problem._anotation, doc, 1));
        //        if (problem.BookName != null) information.Add(SearchByParams("Book", "BK_NAME", problem.BookName, doc, 1));
        //        if (problem._qualificationProperties != null) information.Add(SearchByParams("Book", "PUB", problem._qualificationProperties, doc, 1));
        //        if (problem.Faculty != null) information.Add(SearchByParams("Book", "FAC", problem.Faculty, doc, 1));
        //        if (problem.Department != null) information.Add(SearchByParams("Book", "DE", problem.Department, doc, 1));
        //        if (problem.Position != null) information.Add(SearchByParams("Book", "POS", problem.Position, doc, 1));
        //    }
        //    catch (IndexOutOfRangeException ex) { throw new IndexOutOfRangeException(); }
        //    return Cross(information);
        //}

        //public static List<Library> SearchByParams(string nodename, string val, string param, XmlDocument doc, int n)
        //{
        //    List<Library> problems = new List<Library>();
        //    if (param != String.Empty && param != null)
        //    {
        //        switch (n)
        //        {
        //            case 0:
        //                {
        //                    XmlNodeList elems = doc.SelectNodes("//" + nodename + "[@" + val + "=\"" + param + "\"]");
        //                    try
        //                    {
        //                        foreach (XmlNode e in elems)
        //                        {
        //                            XmlNodeList list1 = e.ChildNodes;
        //                            foreach (XmlNode el in list1)
        //                                problems.Add(Info(el));
        //                        }
        //                    }
        //                    catch { }
        //                    return problems;
        //                }
        //            case 1:
        //                {
        //                    XmlNodeList elems = doc.SelectNodes("//" + nodename + "[@" + val + "=\"" + param + "\"]");
        //                    try
        //                    {
        //                        foreach (XmlNode el in elems)
        //                            problems.Add(Info(el));

        //                    }
        //                    catch { }
        //                    return problems;

        //                }
        //            default: break;
        //        }
        //    }
        //    return AllProblems(doc);
        //}
        //public static List<Library> AllProblems(XmlDocument doc)
        //{
        //    throw new NotImplementedException();
        //}
        //public static Library Info(XmlNode node)
        //{
        //    Library nw = new Library();

        //    nw._authorName = node.Attributes.GetNamedItem("AU").Value;
        //    nw._anotation = node.Attributes.GetNamedItem("AN").Value;
        //    nw.BookName = node.Attributes.GetNamedItem("BK_NAME").Value;
        //    nw._qualificationProperties = node.Attributes.GetNamedItem("PUB").Value;
        //    nw.Faculty = node.Attributes.GetNamedItem("FAC").Value;
        //    nw.Department = node.Attributes.GetNamedItem("DE").Value;
        //    nw.Position = node.Attributes.GetNamedItem("POS").Value;
        //    return nw;
        //}
        //public static List<Library> Cross(List<List<Library>> list)
        //{
        //    throw new NotImplementedException();
        //}





        //    public static void RecurseNodes(XmlNode node, int level, StringBuilder sb)
        //    {
        //        sb.AppendFormat("{0,-2} Type:{1,-9} Name:{2,-13} Attr:",
        //        level, node.NodeType, node.Name);
        //        foreach (XmlAttribute attr in node.Attributes)
        //        {
        //            sb.AppendFormat("{0}={1} ", attr.Name, attr.Value);
        //        }
        //        sb.AppendLine();
        //        foreach (XmlNode n in node.ChildNodes)
        //        {
        //            RecurseNodes(n, level + 1, sb);
        //        }
        //    }
        //    public static void RecurseNodes(XmlNode node)
        //    {
        //        var sb = new StringBuilder();
        //        //починаємо рекурсивний перегляд з рівня 0
        //        RecurseNodes(node, 0, sb);
        //        //друкуємо сформований рядок
        //        Console.WriteLine(sb.ToString());
        //    }
        //    public static void CreateAndSaveXmlDocument()
        //    {
        //        //Створення нового XmlDocument
        //        var xmlDoc = new XmlDocument();
        //        XmlElement el;
        //        int childCounter;
        //        int grandChildCounter;
        //        //Створення xml декларації
        //        xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null));
        //        //Створення кореневого елементу і додавання його в документ
        //        el = xmlDoc.CreateElement("MyRoot");
        //        xmlDoc.AppendChild(el);
        //        for (childCounter = 1; childCounter <= 3; childCounter++) //дочірні елементи
        //        {
        //            XmlElement childelmt;
        //            XmlAttribute childattr;
        //            //Створенння дочірніх елементів з ID
        //            childelmt = xmlDoc.CreateElement("MyChild");
        //            childattr = xmlDoc.CreateAttribute("ID");
        //            childattr.Value = childCounter.ToString();
        //            childelmt.Attributes.Append(childattr);
        //            //Додавання елементу в кореневий елемент
        //            el.AppendChild(childelmt);
        //            for (grandChildCounter = 1; grandChildCounter <= 4; grandChildCounter++)
        //            {
        //                //Створення дочірніх вузлів для дочірніх вузлів  
        //                XmlElement grandchilde;
        //                XmlAttribute grandchildeattr;
        //                grandchilde = xmlDoc.CreateElement("MyGrandChild");
        //                grandchildeattr = xmlDoc.CreateAttribute("NAME");
        //                grandchildeattr.Value = childattr.Value + " " + grandChildCounter.ToString();
        //                grandchilde.Attributes.Append(grandchildeattr);
        //                childelmt.AppendChild(grandchilde);
        //            }
        //        }
        //        xmlDoc.Save(getFilePath("XmlDocumentTest.xml"));
        //        Console.WriteLine("XmlDocumentTest.xml Created\r\n");
        //    }
        //    //Шлях на робочий стіл
        

        //    public static void searchingInXmlDocument()
        //    {
        //        var xmlDoc = new XmlDocument();
        //        xmlDoc.Load(getFilePath("XmlDocumentTest.xml"));
        //        var node = xmlDoc.SelectSingleNode("//Book[@BK_NAME='A']");
        //        RecurseNodes(node);
        //    }

        //    public static void getElementsByTagName()
        //    {
        //        var xmlDoc = new XmlDocument();
        //        xmlDoc.Load(getFilePath("XmlDocumentTest.xml"));
        //        var elmts = xmlDoc.GetElementsByTagName("author");
        //        var sb = new StringBuilder();
        //        foreach (XmlNode node in elmts)
        //        {
        //            RecurseNodes(node, 0, sb);
        //        }
        //        Console.WriteLine(sb.ToString());
        //    }
        //    public static void selectNodesTool()
        //    {
        //        var xmlDoc = new XmlDocument();
        //        xmlDoc.Load(getFilePath("XmlDocumentTest.xml"));
        //        var elmts = xmlDoc.SelectNodes("//author");
        //        var sb = new StringBuilder();
        //        foreach (XmlNode node in elmts)
        //        {
        //            RecurseNodes(node, 0, sb);
        //        }
        //        Console.WriteLine(sb.ToString());
        //    }


    }
}
