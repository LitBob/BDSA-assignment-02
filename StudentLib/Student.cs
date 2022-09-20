namespace StudentLib;

public class Student
{
    
    public int Id {get; init;}
    public string GivenName {get; set;} 
    public string Surname {get; set;}
    public Status Status 
    {
        get{
            if (GraduationDate < DateTime.Now && GraduationDate == EndDate) return Status.Graduated;
            else if (EndDate < GraduationDate) return Status.Dropout;
            else if (DateTime.Now > StartDate && DateTime.Now < EndDate) return Status.Active;
            else if (DateTime.Now < StartDate) return Status.New;
            throw new Exception();
        }
    }
    public DateTime StartDate {get; set;}
    public DateTime EndDate {get; set;}
    public DateTime GraduationDate {get; set;}

    public string ToString(){
        return "ID: " + Id + ", Name: " + Surname + ", " + GivenName + ", Status: " + Status;
    }
}
