
namespace University.Dal.DataContext.Entities;

public class Teacher : Entity
{
    public string Name { get; set; }
    public int DepartmentId { get; set; }   
    public Department? Department { get; set; }
    public virtual ICollection<TeacherGroup>? TeacherGroups { get; set; }
}