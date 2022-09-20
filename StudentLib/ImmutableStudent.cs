namespace StudentLib;

public readonly record struct ImmutableStudent(int Id, string Name, string Surname, DateTime StartDate, DateTime EndDate, DateTime GraduationDate)
{
    public Status Status {
        get{
            if (GraduationDate < DateTime.Now && GraduationDate == EndDate) return Status.Graduated;
            else if (EndDate < GraduationDate) return Status.Dropout;
            else if (DateTime.Now > StartDate && DateTime.Now < EndDate) return Status.Active;
            else if (DateTime.Now < StartDate) return Status.New;
            throw new Exception();
        }
    }
}