using System;
using System.IO;
using System.Xml;

namespace PracticaDeLaboratorio_UsingDomParserInCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			if (File.Exists("D:/Usuario/Desktop/Universidad/5to Semestre/Construccion de Software/Materia/Segundo Parcial/XMLs/XML_Cliente"))
			{
				XmlDocument doc = new XmlDocument();
				doc.Load("D:/Usuario/Desktop/Universidad/5to Semestre/Construccion de Software/Materia/Segundo Parcial/XMLs/XML_Cliente");
				foreach (XmlNode node in doc.DocumentElement.ChildNodes)
				{
					String id = node.Attributes["id"].Value;
					Console.WriteLine("id: " + id);
					if (node.HasChildNodes)
					{
						for(int i = 0; i < node.ChildNodes.Count; i++)
						{
							Console.WriteLine(node.ChildNodes[i].Name + " : " + node.ChildNodes[i].InnerText);

						}
						Console.WriteLine();
					}
				}
				Console.ReadKey();
			}
			else
			{
				Console.WriteLine("Compruebe que ha ingresado correctamente la ubicación del archivo");
			}
		}
	}
}
