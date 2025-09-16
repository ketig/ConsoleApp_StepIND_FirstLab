// Github
// Warning
// File

using ConsoleApp_StepIND_FirstLab.Serialization;
using System.Text.Json;
using System.Xml.Serialization;

Student student = new Student
{
    Name = "John",
    LastName = "Doe",
    BirthDate = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    University = "Some University",
    Courses =
    [
        new() { Title = "Mathematics", Credits = 3, Professor = "Dr. Smith" },
        new() { Title = "Physics", Credits = 4, Professor = "Dr. Johnson" }
    ]
};

string directory = @"C:\Users\User\Downloads";
string fileXML = "smthXML.xml";
string fileJson = "smthJson.json";
string pathXML = Path.Combine(directory, fileXML);
string pathJson = Path.Combine(directory, fileJson);

XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));

using (FileStream stream = new FileStream(pathXML, FileMode.Create))
{
    xmlSerializer.Serialize(stream, student);
    Console.WriteLine("Wrote!");
}

using (FileStream stream = new FileStream(pathXML, FileMode.Open))
{
    Student student1 = (Student)xmlSerializer.Deserialize(stream);
    Console.WriteLine($"Name: {student1.Name}, LastName: {student1.LastName}, BirthDate: {student1.BirthDate}, University: {student1.University}");
}

var options = new JsonSerializerOptions
{
    WriteIndented = true,
    DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
};


string jsonString = JsonSerializer.Serialize(student, options);
Console.WriteLine(jsonString);

File.WriteAllText(pathJson, jsonString);
Console.WriteLine("Wrote Json!");

string jsonStringFromFile = File.ReadAllText(pathJson);
Student student2 = JsonSerializer.Deserialize<Student>(jsonStringFromFile);

Console.WriteLine(student2);