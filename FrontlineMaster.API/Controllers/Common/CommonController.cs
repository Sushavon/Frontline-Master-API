using FrontlineMaster.API.Controllers.Base;
using FrontlineMaster.Entity.Common;
using FrontlineMaster.Interface.Hierarchy;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> GetAllPersonalDetails()
        {
            var result = await _hierarchyService.GetAllCompany();
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }


        [HttpGet("GetAllSbu")]
        public async Task<IActionResult> GetAllSbu()
        {
            var result = await _hierarchyService.GetAllSbu();
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetSbu")]
        public async Task<IActionResult> GetSbu(CompanyEntity company)
        {
            var result = await _hierarchyService.GetSbu(company.CompanyId);
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetAllDesignations")]
        public async Task<IActionResult> GetAllDesignations()
        {
            var result = await _hierarchyService.GetDesignations();
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetDesignations")]
        public async Task<IActionResult> GetDesignations(SBUEntity sbu)
        {
            var result = await _hierarchyService.GetDesignations(sbu.SbuId);
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetStates")]
        public async Task<IActionResult> GetStates(CompanyEntity company)
        {
            var result = await _hierarchyService.GetStates(company.CompanyId);
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetCities")]
        public async Task<IActionResult> GetCities(StateEntity state)
        {
            var result = await _hierarchyService.GetCities(state.StateId);
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetSpecialities")]
        public async Task<IActionResult> GetSpecialities(CompanyEntity company)
        {
            var result = await _hierarchyService.GetSpecialities(company.CompanyId);
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetTownTypes")]
        public async Task<IActionResult> GetTownTypes(CompanyEntity company)
        {
            var result = await _hierarchyService.GetTownTypes(company.CompanyId);
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetSecurityQuestions")]
        public async Task<IActionResult> GetSecurityQuestions()
        {
            var result = await _hierarchyService.GetSecurityQuestions();
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetMembers")]
        public async Task<IActionResult> GetMembers()
        {
            var result = await _hierarchyService.GetMembers();
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetMcrCategories")]
        public async Task<IActionResult> GetMcrCategories(DesignationWithGroupEntity designation)
        {
            var result = await _hierarchyService.GetMcrCategories(designation.DesigId);
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetZones")]
        public async Task<IActionResult> GetZones(SBUEntity sbu)
        {
            var result = await _hierarchyService.GetZones(sbu.SbuId);
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetRegions")]
        public async Task<IActionResult> GetRegions(ZoneEntity zone)
        {
            var result = await _hierarchyService.GetRegions(zone.ZoneId);
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetAreas")]
        public async Task<IActionResult> GetAreas(RegionEntity region)
        {
            var result = await _hierarchyService.GetAreas(region.RegionId);
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetHeadquarters")]
        public async Task<IActionResult> GetHeadquarters(AreaEntity area)
        {
            var result = await _hierarchyService.GetHeadquarters(area.AreaId);
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetDropReasons")]
        public async Task<IActionResult> GetDropReasons()
        {
            var result = await _hierarchyService.GetDropReasons();
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetQualifications")]
        public async Task<IActionResult> GetQualifications(SpecialityEntity speciality)
        {
            var result = await _hierarchyService.GetQualifications(speciality.SpecialityId);
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetCodeValues/{typeCode}")]
        public async Task<IActionResult> GetCodeValues(string typeCode)
        {
            var result = await _hierarchyService.GetCodeValues(typeCode);
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetMenuItems/{repId}/{loginType}")]
        public async Task<IActionResult> GetMenuItems(int repId, string loginType)
        {
            var result = await _hierarchyService.GetMenuItems(repId,loginType);
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

    }
}
