// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using SerializeDeserializeJsonXml;


//Convertendo Json para um Objeto
var json = "{\"produto\":\"tenis\",\"preco\":150.00,\"quantidade\":2}";
var jsonObject = JsonConvert.DeserializeObject<ProductModel>(json);
var ObjectToJson = JsonConvert.SerializeObject(jsonObject);
Console.WriteLine();


