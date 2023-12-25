
namespace University.Dal.DataContext.Entities;

public class Department : Entity
{
    public string Name { get; set; }
    public virtual ICollection<Teacher>? Teachers { get; set; }
    public virtual ICollection<Group>? Groups { get; set; }  
}
