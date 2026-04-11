namespace StudentRecords
{
  
  public class Enrollment
  {
    public Student Student { get; }
    public Course Course { get; }

    public Enrollment(Student student, Course course)
    {
      Student = student;
      Course = course ;
    }

    public override string ToString()
    {
      return $"{Student.Name} is enrolled in {Course.Name} (Code: {Course.Code})";
    }
  }
}