
namespace University.Bll.ViewModels.Student;

public class StudentDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? GroupName { get; set; }
}

public class StudentCreateDto
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int GroudId { get; set; }
}

public class StudentUpdateDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int GroudId { get; set; }
}
