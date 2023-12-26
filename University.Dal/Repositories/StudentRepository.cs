using Microsoft.EntityFrameworkCore;
using University.Dal.DataContext;
using University.Dal.DataContext.Entities;
using University.Dal.Repositories.Contracts;

namespace University.Dal.Repositories
{
    public class StudentRepository : EfCoreRepository<Student>, IStudentRepository
    {
        private readonly AppDbContext _dbContext;

        public StudentRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
