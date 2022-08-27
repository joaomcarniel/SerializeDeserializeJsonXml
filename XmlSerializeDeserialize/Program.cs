// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using SerializeDeserializeJsonXml;
using System.Xml;
using System.Xml.Serialization;

Console.WriteLine("Hello, World!");

//Convertendo XML para um Objeto
var xml = "<ProductModel><produto>tenis</produto><preco>150</preco><quantidade>2</quantidade></ProductModel>";
XmlDocument xmlConfig = new XmlDocument();
xmlConfig.LoadXml(xml);
var jsonProduct = JsonConvert.SerializeXmlNode(xmlConfig);
var xmlObject = JsonConvert.DeserializeObject<ProductModelRoot>(jsonProduct);

XmlSerializer serializer = new XmlSerializer(typeof(ProductModelRoot));
StringWriter retorno = new StringWriter();
serializer.Serialize(retorno, xmlObject);
var ObjectToxml = retorno.ToString();
Console.WriteLine();