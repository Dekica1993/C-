

using HomeworksClass11;
using Newtonsoft.Json;

string folderPath = "../../../OurData";

string filePath = folderPath + "/ourFile.json";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
};

if (!File.Exists(filePath))
{
    File.Create(filePath).Close();
};

void WriteToJson (string json)
{
    using (StreamWriter sw = new StreamWriter((filePath)))
    {
        Console.WriteLine("Enter a Name");
        string textInputName = Console.ReadLine();
        Console.WriteLine("Enter a Age");
        string textInputAge = Console.ReadLine();
        Console.WriteLine("Enter a Color");
        string textInputColor = Console.ReadLine();
        sw.WriteLine(textInputName);
        sw.WriteLine(textInputAge);
        sw.WriteLine(textInputColor);
        sw.WriteLine(json);

    }
}

void ReadFromJson()
{
    using (StreamReader sr = new StreamReader(filePath))
    {
        string text = sr.ReadToEnd();
        Console.WriteLine(text);
        
    }
}



Dog kuce = new Dog()
{
    Name = "Aeron",
    Age = 4,
    Color = "Gold"

};

ReadFromJson();


string kuceSerializedNewtonsoftJson = JsonConvert.SerializeObject(kuce);
WriteToJson(kuceSerializedNewtonsoftJson);

Dog kuceDesirealizedNewtonsoftJson = JsonConvert.DeserializeObject<Dog>(kuceSerializedNewtonsoftJson);


Console.WriteLine(kuceDesirealizedNewtonsoftJson.Name.ToString());
Console.WriteLine(kuceDesirealizedNewtonsoftJson.Age);
Console.WriteLine(kuceDesirealizedNewtonsoftJson.Color);

