using System.IO;
using System.Xml.Serialization;

public class XmlSerialization
{
    public static void SaveToXml(AcademicGroup group, string filePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(AcademicGroup));
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            serializer.Serialize(writer, group);
        }
    }

    public static AcademicGroup LoadFromXml(string filePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(AcademicGroup));
        using (StreamReader reader = new StreamReader(filePath))
        {
            return (AcademicGroup)serializer.Deserialize(reader);
        }
    }
}
