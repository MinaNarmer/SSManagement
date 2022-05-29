using SSManagment.BL.DTOs;
using System.Collections.Generic;

namespace SSManagment.BL.IServices
{
    public interface IUniversityService
    {
        List<UniversityDTO> GetList();
        void Create(UniversityDTO dto);
    }
}
