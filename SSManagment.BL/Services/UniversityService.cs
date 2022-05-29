

using AutoMapper;
using SSManagement.Data;
using SSManagment.BL.DTOs;
using SSManagment.BL.IServices;
using SSManagment.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SSManagment.BL.Services
{
    public class UniversityService : IUniversityService
    {
        private readonly SSContext _context;
        public IMapper _mapper;

        public UniversityService(SSContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }



        public void Create(UniversityDTO dto)
        {
            var model = _mapper.Map<University>(dto);
            _context.Universities.Add(model);
            _context.SaveChanges();
        }

        public List<UniversityDTO> GetList()
        {
            var universties = _context.Universities.ToList();

            var list = _mapper.Map<List<UniversityDTO>>(universties);
            return list;
        }
    }
}
