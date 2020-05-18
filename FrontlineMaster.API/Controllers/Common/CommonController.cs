using FrontlineMaster.API.Controllers.Base;
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

        [HttpGet("GetSbu/{companyId}")]
        public async Task<IActionResult> GetSbu(int companyId)
        {
            var result = await _hierarchyService.GetSbu(companyId);
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

        [HttpGet("GetDesignations/{sbuId}")]
        public async Task<IActionResult> GetDesignations(int sbuId)
        {
            var result = await _hierarchyService.GetDesignations(sbuId);
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetStates/{companyId}")]
        public async Task<IActionResult> GetStates(int companyId)
        {
            var result = await _hierarchyService.GetStates(companyId);
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetCities/{stateId}")]
        public async Task<IActionResult> GetCities(int stateId)
        {
            var result = await _hierarchyService.GetCities(stateId);
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetSpecialities/{companyId}")]
        public async Task<IActionResult> GetSpecialities(int companyId)
        {
            var result = await _hierarchyService.GetSpecialities(companyId);
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetTownTypes/{companyId}")]
        public async Task<IActionResult> GetTownTypes(int companyId)
        {
            var result = await _hierarchyService.GetTownTypes(companyId);
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

        [HttpGet("GetMcrCategories/{designation}")]
        public async Task<IActionResult> GetMcrCategories(int designationId)
        {
            var result = await _hierarchyService.GetMcrCategories(designationId);
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetZones/{sbuId}")]
        public async Task<IActionResult> GetZones(int sbuId)
        {
            var result = await _hierarchyService.GetZones(sbuId);
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetRegions/{zoneId}")]
        public async Task<IActionResult> GetRegions(int zoneId)
        {
            var result = await _hierarchyService.GetRegions(zoneId);
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetAreas/{regionId}")]
        public async Task<IActionResult> GetAreas(int regionId)
        {
            var result = await _hierarchyService.GetAreas(regionId);
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

        [HttpGet("GetHeadquarters/{areaId}")]
        public async Task<IActionResult> GetHeadquarters(int areaId)
        {
            var result = await _hierarchyService.GetHeadquarters(areaId);
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

        [HttpGet("GetQualifications/{specialityId}")]
        public async Task<IActionResult> GetQualifications(int specialityId)
        {
            var result = await _hierarchyService.GetQualifications(specialityId);
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
            var result = await _hierarchyService.GetMenuItems(repId, loginType);
            if (result != null && result.Count > 0)
                return Ok(result);
            return NoContent();
        }

    }
}
