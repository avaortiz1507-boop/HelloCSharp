namespace StudentRecords
{
   public class Course
  {
    private string _code = string.Empty;
    private string _name = string.Empty;

    public string Code
    {
      get => _code;
      set 
      {
        if (string.IsNullOrWhiteSpace(value))
          throw new ArgumentException("Code cannot be null or empty.");

        _code = value;
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

    public Course(string code, string name)
    {
      Code = code;
      Name = name;
    }
  }
}