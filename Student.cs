namespace StudentRecords
{
   public class Student
  {
    private int _id = 0;
    private string _name = string.Empty;
    private readonly List<Enrollment> _enrollments = new List<Enrollment>();

    public int Id
    {
      get => _id;
      set
      {
        if (value <= 0)
          throw new ArgumentException("ID must be a positive integer.");

        _id = value;
      }
    }
    public string Name
    {
      get => _name;
      set
      {
        if (string.IsNullOrWhiteSpace(value))
          throw new ArgumentException("Name cannot be null or empty.");

        _name = value;
      }
    }

    public IReadOnlyList<Enrollment> Enrollments => _enrollments.AsReadOnly();

    public Student(int id, string name)
    {
      Id = id;
      Name = name;
    }

    public void EnrollInCourse(Course course)
    {
      if (course == null)
        throw new ArgumentNullException(nameof(course), "Course cannot be null.");

      var enrollment = new Enrollment(this, course);
      _enrollments.Add(enrollment);
    }
  }
}