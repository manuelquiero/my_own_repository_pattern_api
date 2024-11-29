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
            new Student { Id = 3, Name = "Hansel", Sex = Sex.Male, Age = 29 }
        };
        public async Task<List<Student>> GetAll() => _students;
        
        public async Task<Student> Get(int id) => _students.FirstOrDefault(x => x.Id == id);
        
        public async Task<Student> Create(Student student)
        {
            _students.Add(student);
            return student;
        }

        public async Task<Student> Update(Student student)
        {
            var selectedStudent = _students.FirstOrDefault(x => x.Id == student.Id);
            if(selectedStudent != null)
            {
                selectedStudent.Name = student.Name;
                selectedStudent.Age = student.Age;
                selectedStudent.Sex = student.Sex;
            }

            return _students.FirstOrDefault(y => y.Id == student.Id);
        }

        public async Task<bool> Delete(int id)
        {
            int index = _students.FindIndex(x => x.Id == id);
            _students.RemoveAt(index);
            return !_students.Any(x => x.Id == id);
        }
    }
}
