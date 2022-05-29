using SSManagment.BL.DTOs;
using System.Collections.Generic;

namespace SSManagment.BL.IServices
{
    public interface IStudentService
    {
        StudentDTO GetById(int id);
        List<StudentDTO> GetList();
        void Create(StudentDTO dto);
        bool Update(StudentDTO student);
        bool Delete(int id);
    }
}
