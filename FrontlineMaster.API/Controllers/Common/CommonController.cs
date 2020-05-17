using FrontlineMaster.API.Controllers.Base;
using FrontlineMaster.Entity.Hierarchy;
using FrontlineMaster.Interface.Hierarchy;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace FrontlineMaster.API.Controllers.FamilyDetails
{

    [Route("api/[controller]")]
    [ApiController]
    public class CommonController : BaseController
    {
        private readonly ICommonService _hierarchyService = null;

        public CommonController(ICommonService hierarchyService)
        {
            _hierarchyService = hierarchyService;
        }


        [HttpGet("GetAllCompany")]
        public async Task<List<CompanyEntity>> GetAllPersonalDetails()
        {
            return await _hierarchyService.GetAllCompany();
        }


        [HttpGet("GetAllSbu")]
        public async Task<List<SBUEntity>> GetAllSbu()
        {
            return await _hierarchyService.GetAllSbu();
        }

        [HttpGet("GetSbu")]
        public async Task<List<SBUEntity>> GetSbu(CompanyEntity company)
        {
            return await _hierarchyService.GetSbu(company.CompanyId);
        }

        [HttpGet("GetAllDesignations")]
        public async Task<List<DesignationWithGroupEntity>> GetAllDesignations()
        {
            return await _hierarchyService.GetDesignations();
        }

        [HttpGet("GetDesignations")]
        public async Task<List<DesignationWithGroupEntity>> GetDesignations(SBUEntity sbu)
        {
            return await _hierarchyService.GetDesignations(sbu.SbuId);
        }

        [HttpGet("GetStates")]
        public async Task<List<StateEntity>> GetStates(CompanyEntity company)
        {
            return await _hierarchyService.GetStates(company.CompanyId);
        }

        [HttpGet("GetCities")]
        public async Task<List<CityEntity>> GetCities(StateEntity state)
        {
            return await _hierarchyService.GetCities(state.StateId);
        }

        [HttpGet("GetSpecialities")]
        public async Task<List<SpecialityEntity>> GetSpecialities(CompanyEntity company)
        {
            return await _hierarchyService.GetSpecialities(company.CompanyId);
        }

        [HttpGet("GetTownTypes")]
        public async Task<List<TownTypeEntity>> GetTownTypes(CompanyEntity company)
        {
            return await _hierarchyService.GetTownTypes(company.CompanyId);
        }

        [HttpGet("GetSecurityQuestions")]
        public async Task<List<SecurityQuestionEntity>> GetSecurityQuestions()
        {
            return await _hierarchyService.GetSecurityQuestions();
        }

    }
}
