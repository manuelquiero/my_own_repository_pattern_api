using domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Interfaces
{
    public interface IStudentRepository
    {
        Student GetAll();
        Student Get(int id);
        Student Create(Student student);
        bool Update(int id);
        bool Delete(int id);
    }
}
