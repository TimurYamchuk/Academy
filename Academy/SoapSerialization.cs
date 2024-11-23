using SoapCore;
using System;
using System.ServiceModel;

[ServiceContract]
public interface IAcademyService
{
    [OperationContract]
    string GetStudentInfo(int studentId);
}

public class AcademyService : IAcademyService
{
    public string GetStudentInfo(int studentId)
    {
        return $"Student info for ID: {studentId}";
    }
}
