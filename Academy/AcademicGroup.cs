[Serializable]
public class AcademicGroup
{
    public string GroupName { get; set; }
    public List<Student> Students { get; set; }

    public AcademicGroup(string groupName)
    {
        GroupName = groupName;
        Students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }
}
