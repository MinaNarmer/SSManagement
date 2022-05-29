
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SSManagement.Data;
using SSManagment.BL.DTOs;
using SSManagment.BL.IServices;
using SSManagment.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SSManagment.BL.Services
{
    public class StudentService : IStudentService
    {
        private readonly SSContext _context;
        public IMapper _mapper;

        //DbSet<Student> repo;

        //public StudentService(SSContext context)
        //{
        //    _context = context;
        //}

        public StudentDTO GetById(int id)
        {
            var student = _context.Students.FirstOrDefaultAsync(x => x.Id == id);
            var dto = _mapper.Map<StudentDTO>(student);
            return dto;

        }
        public void Create(StudentDTO dto)
        {
            var model = _mapper.Map<Student>(dto);
            _context.Students.Add(model);
            _context.SaveChanges();
        }

        public bool Update(StudentDTO student)
        {
            var model = _mapper.Map<Student>(student);
            _context.Students.Update(model);
            _context.SaveChanges();
            return true;
        }
        public bool Delete(int id)
        {
            var model = _context.Students.Find(id);
            _context.Students.Remove(model);
            return true;
        }

        public List<StudentDTO> GetList()
        {
        var students = _context.Students.ToList();

            var list = _mapper.Map<List<StudentDTO>>(students);   
            return list;
        }
    }
}
