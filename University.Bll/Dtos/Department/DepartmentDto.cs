using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Bll.Dtos.Department
{
    public class DepartmentDto : Dto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class DepartmentCreateDto : Dto
    {
        public string Name { get; set; }
    }

    public class DepartmentUpdateDto : Dto
    {
        public string Name { get; set; }
    }
}
