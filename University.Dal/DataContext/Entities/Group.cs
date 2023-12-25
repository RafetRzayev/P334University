
namespace University.Dal.DataContext.Entities;

public class Group : Entity
{
    public string Name { get; set; }
    public virtual ICollection<Student>? Students { get; set; }
    public virtual ICollection<TeacherGroup>? GroupTeachers { get; set; }
}
