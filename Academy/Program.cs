namespace Academy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            {
                // Создание академической группы
                AcademicGroup group = new AcademicGroup("Group A");
                group.AddStudent(new Student("Ivanov", 22, "Computer Science"));
                group.AddStudent(new Student("Petrov", 21, "Mathematics"));

                // Сериализация в JSON
                JsonSerialization.SaveToJson(group, "group.json");
                AcademicGroup loadedGroupJson = JsonSerialization.LoadFromJson("group.json");
                Console.WriteLine("Loaded from JSON:");
                Console.WriteLine(loadedGroupJson.GroupName);

                // Сериализация в XML
                XmlSerialization.SaveToXml(group, "group.xml");
                AcademicGroup loadedGroupXml = XmlSerialization.LoadFromXml("group.xml");
                Console.WriteLine("Loaded from XML:");
                Console.WriteLine(loadedGroupXml.GroupName);
            }
        }
    }
    }


