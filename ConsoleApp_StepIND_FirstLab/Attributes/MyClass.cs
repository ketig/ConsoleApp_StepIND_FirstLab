using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ConsoleApp_StepIND_FirstLab.Attributes
{
    internal class MyClass
    {
        [JsonIgnore]
        [Custom]
        [Custom(1)]
        public required string Name { get; set; }

        [JsonIgnore]
        public int Grade { get; set; }

        [JsonPropertyName("student-score")]
        [JsonPropertyOrder(2)]
        [AllowedValues(0, 100)]
        [Range(0, 100)]
        public int StudentScore { get; set; }

        [JsonPropertyName("mail")]
        [JsonPropertyOrder(1)]
        public required string Mail { get; set; }

        public static void Print()
        {
            Console.WriteLine();
        }

        public static void Test()
        {
            MyClass myClass = new MyClass()
            {
                Name = "John Doe",
                Mail = "john@gmail.com",
            };

            CheckAttributes();

            static void CheckAttributes()
            {
                Custom custom = (Custom)Attribute.GetCustomAttribute(typeof(MyClass), typeof(Custom));

                if (custom != null)
                {
                    Console.WriteLine(custom.ToString());
                }
            }
        }
    }
}
