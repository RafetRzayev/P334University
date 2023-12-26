
namespace University.Bll.Dtos.Student;

public class StudentDto : Dto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? GroupName { get; set; }
}

public class StudentCreateDto : Dto
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int GroupId { get; set; }
}

public class StudentUpdateDto : Dto
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int GroudId { get; set; }
}
