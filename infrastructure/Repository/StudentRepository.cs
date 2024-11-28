using domain.Enums;
using domain.Interfaces;
using domain.Models;

namespace infrastructure.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private List<Student> _students = new List<Student>
        {
            new Student { Id = 1, Name = "Hezekiah", Sex = Sex.Male, Age = 27 },
            new Student { Id = 2, Name = "Hunter", Sex = Sex.Male, Age = 14 },
            new Student { Id = 1, Name = "Hansel", Sex = Sex.Male, Age = 29 }
        };
        public async Task<List<Student>> GetAll() => _students;
        
        public async Task<Student> Get(int id) => _students.FirstOrDefault(x => x.Id == id);
        
        public async Task<Student> Create(Student student)
        {
            _students.Add(student);
            return student;
        }

        public bool Update(int id)
        {
            _students.Where(x => x.Id == id).Select(y => new Student
            {
                Name = y.Name,
                Age = y.Age,
                Sex = y.Sex,
            });
            return _students.Any(x => x.Id == id);
        }

        public bool Delete(int id)
        {
            int index = _students.FindIndex(x => x.Id == id);
            _students.RemoveAt(index);
            return !_students.Any(x => x.Id == id);
        }
    }
}
