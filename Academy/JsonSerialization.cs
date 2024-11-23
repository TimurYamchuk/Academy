using Newtonsoft.Json;
using System.IO;

public class JsonSerialization
{
    public static void SaveToJson(AcademicGroup group, string filePath)
    {
        string json = JsonConvert.SerializeObject(group, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    public static AcademicGroup LoadFromJson(string filePath)
    {
        string json = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<AcademicGroup>(json);
    }
}
