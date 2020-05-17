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
    public class HierarchyController : BaseController
    {
        private readonly IHierarchyService _hierarchyService = null;

        public HierarchyController(IHierarchyService hierarchyService)
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

        //[HttpGet("GetAllPersonalDetailSP")]
        //public async Task<List<PersonalDetailEntity>> GetAllPersonalDetailSP()
        //{
        //    var query = new SearchEntity();
        //    return await _personalDetailService.FindSP(query);
        //}

        //[HttpPost("AddPersonalDetail")]
        //public async Task<ApiResponse> AddPersonalDetail(PersonalDetailEntity entity)
        //{
        //    var result = await _personalDetailService.Add(entity);
        //    if (result)
        //    {
        //        return new ApiResponse
        //        {
        //            Messsage = "Successfully Added",
        //            Status = Status.Success.ToString()
        //        };
        //    }

        //    return new ApiResponse
        //    {
        //        Messsage = "Some error ,failed to add member",
        //        Status = Status.Failed.ToString()
        //    };
        //}

        //[HttpPut("UpdatePersonalDetail")]
        //public async Task<ApiResponse> UpdatePersonalDetail(PersonalDetailEntity entity)
        //{
        //    var result = await _personalDetailService.Update(entity);
        //    if (result)
        //    {
        //        return new ApiResponse
        //        {
        //            Messsage = "Successfully Updated",
        //            Status = Status.Success.ToString()
        //        };
        //    }

        //    return new ApiResponse
        //    {
        //        Messsage = "Some error ,failed to update member",
        //        Status = Status.Failed.ToString()
        //    };
        //}

        //[HttpDelete("DeletePersonalDetail")]
        //public async Task<ApiResponse> DeletePersonalDetail(PersonalDetailEntity entity)
        //{
        //    var result = await _personalDetailService.Delete(entity);
        //    if (result)
        //    {
        //        return new ApiResponse
        //        {
        //            Messsage = "Successfully Deleted",
        //            Status = Status.Success.ToString()
        //        };
        //    }

        //    return new ApiResponse
        //    {
        //        Messsage = "Some error ,failed to delete member",
        //        Status = Status.Failed.ToString()
        //    };
        //}

        //[HttpGet("GetAllMember")]
        //public async Task<List<MemberEntity>> GetAllMember()
        //{
        //    return await _personalDetailService.GetAllMember();
        //}
        //protected virtual void Dispose()
        //{
        //    if (_personalDetailService != null)
        //    {
        //        _personalDetailService.Dispose();
        //    }
        //}

    }
}
