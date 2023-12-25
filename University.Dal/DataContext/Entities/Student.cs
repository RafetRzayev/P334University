
namespace University.Dal.DataContext.Entities;

public class Student : Entity
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int GroupId { get; set; }
    public Group? Group { get; set; }
}
