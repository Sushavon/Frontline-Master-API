using FrontlineMaster.Entity.Common;
using FrontlineMaster.Interface.Hierarchy;
using FrontlineMaster.Repository.ContextModel;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FrontlineMaster.Repository.Hierarchy
{
    public class CommonRepository : ICommonRepository
    {
        private readonly DBContext _context = null;
        private IConfiguration _configuration = null;
        public int LoggedInUserId;
        public CommonRepository(DBContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
            LoggedInUserId = Int32.Parse(_configuration.GetValue<string>("LoggedInUserid"));
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public async Task<IQueryable<CompanyEntity>> GetAllCompany()
        {
            var result = await Task.Run(() => _context.Company.Where(x => x.IsActive.Value)
            .Select(m => new CompanyEntity
            {
                CompanyId = m.CompanyId,
                CompanyCode = m.CompanyCode,
                CompanyName = m.CompanyName,
                OldCompCode = m.OldCompCode
            }).Distinct().AsQueryable());

            return result;
        }

        public async Task<IQueryable<SBUEntity>> GetAllSbu()
        {
            var result = await Task.Run(() => _context.Sbu.Where(x => x.IsActive.Value)
            .Select(m => new SBUEntity
            {
                SbuId = m.SbuId,
                CompanyId = m.CompanyId,
                SbuCode = m.SbuCode,
                SbuName = m.SbuName
            }).Distinct().AsQueryable());

            return result;
        }

        public async Task<IQueryable<SBUEntity>> GetSbu(int companyId)
        {
            var result = await Task.Run(() => _context.Sbu.Where(x => x.IsActive.Value && x.CompanyId == companyId)
            .Select(m => new SBUEntity
            {
                SbuId = m.SbuId,
                CompanyId = m.CompanyId,
                SbuCode = m.SbuCode,
                SbuName = m.SbuName
            }).Distinct().AsQueryable());

            return result;
        }

        public async Task<IQueryable<DesignationWithGroupEntity>> GetDesignations()
        {
            var result = await Task.Run(() => from des in _context.Desig
                                              join desgrp in _context.DesigGrp on des.DesigId equals desgrp.DesigId
                                              where des.IsActive == true && desgrp.IsActive == true
                                              select new DesignationWithGroupEntity
                                              {
                                                  DesigId = des.DesigId,
                                                  DesigGrpId = desgrp.DesigGrpId,
                                                  DesigCode = des.DesigCode,
                                                  DesigDesc = des.DesigDesc,
                                                  DesigCategory = des.DesigCategory,
                                                  DesigHierarchy = des.DesigHierarchy,
                                                  GroupCode = desgrp.GroupCode,
                                                  SbuId = des.SbuId
                                              });

            return result;
        }

        public async Task<IQueryable<DesignationWithGroupEntity>> GetDesignations(int sbuId)
        {
            var result = await Task.Run(() => from des in _context.Desig
                                              join desgrp in _context.DesigGrp on des.DesigId equals desgrp.DesigId
                                              join sbu in _context.Sbu on des.SbuId equals sbu.SbuId
                                              where des.IsActive == true && desgrp.IsActive == true && sbu.IsActive == true && des.SbuId == sbuId
                                              select new DesignationWithGroupEntity
                                              {
                                                  DesigId = des.DesigId,
                                                  DesigGrpId = desgrp.DesigGrpId,
                                                  DesigCode = des.DesigCode,
                                                  DesigDesc = des.DesigDesc,
                                                  DesigCategory = des.DesigCategory,
                                                  DesigHierarchy = des.DesigHierarchy,
                                                  GroupCode = desgrp.GroupCode,
                                                  SbuId = des.SbuId,
                                                  SbuCode = sbu.SbuCode
                                              });

            return result;
        }

        public async Task<IQueryable<StateEntity>> GetStates(int companyId)
        {
            var result = await Task.Run(() => _context.State.Where(x => x.IsActive.Value && x.CompanyId == companyId)
           .Select(m => new StateEntity
           {
               StateId = m.StateId,
               CompanyId = m.CompanyId,
               StateCode = m.StateCode,
               StateName = m.StateName
           }).Distinct().AsQueryable());

            return result;
        }

        public async Task<IQueryable<CityEntity>> GetCities(int stateId)
        {
            var result = await Task.Run(() => _context.City.Where(x => x.IsActive.Value && x.StateId == stateId)
           .Select(m => new CityEntity
           {
               CityId = m.CityId,
               StateId = m.StateId,
               CityCode = m.CityCode,
               CityName = m.CityName
           }).Distinct().AsQueryable());

            return result;
        }

        public async Task<IQueryable<SpecialityEntity>> GetSpecialities(int companyId)
        {
            var result = await Task.Run(() => _context.Speciality.Where(x => x.IsActive.Value && x.CompanyId == companyId)
          .Select(m => new SpecialityEntity
          {
              SpecialityId = m.SpecialityId,
              CompanyId = m.CompanyId,
              SpecCode = m.SpecCode,
              SpecDesc = m.SpecDesc,
              SpecStatus = m.SpecStatus
          }).Distinct().AsQueryable());


            return result;
        }

        public async Task<IQueryable<TownTypeEntity>> GetTownTypes(int companyId)
        {
            var result = await Task.Run(() => _context.TownType.Where(x => x.IsActive && x.CompanyId == companyId)
         .Select(m => new TownTypeEntity
         {
             TownTypeId = m.TownTypeId,
             CompanyId = m.CompanyId,
             TownTypeCode = m.TownTypeCode,
             TownTypeDesc = m.TownTypeDesc
         }).Distinct().AsQueryable());


            return result;
        }

        public async Task<IQueryable<SecurityQuestionEntity>> GetSecurityQuestions()
        {
            var result = await Task.Run(() => _context.SecurityQuest.Where(x => x.IsActive.Value)
        .Select(m => new SecurityQuestionEntity
        {
            QuestId = m.QuestId,
            QuestLine = m.QuestLine
        }).Distinct().AsQueryable());


            return result;
        }

        public async Task<IQueryable<MemberEntity>> GetMembers()
        {
            var result = await Task.Run(() => _context.Member.Where(x => x.IsActive.Value)
        .Select(m => new MemberEntity
        {
            MemberId = m.MemberId,
            MemberCode = m.MemberCode,
            MemberDesc = m.MemberDesc
        }).Distinct().AsQueryable());


            return result;
        }

        public async Task<IQueryable<McrCategoryEntity>> GetMcrCategories(int desigId)
        {
            var result = await Task.Run(() => _context.McrCategory.Where(x => x.IsActive.Value && x.DesigId == desigId)
        .Select(m => new McrCategoryEntity
        {
            DesigId = m.DesigId,
            McrCategoryId = m.McrCategoryId,
            McrCategory1 = m.McrCategory1
        }).Distinct().AsQueryable());


            return result;
        }

        public async Task<IQueryable<ZoneEntity>> GetZones(int sbuId)
        {
            var result = await Task.Run(() => _context.Zone.Where(x => x.IsActive.Value && x.SbuId == sbuId)
        .Select(m => new ZoneEntity
        {
            ZoneId = m.ZoneId,
            SbuId = m.SbuId,
            ZoneCode = m.ZoneCode,
            ZoneDesc = m.ZoneDesc,
            ZdZoneCode = m.ZdZoneCode
        }).Distinct().AsQueryable());


            return result;
        }

        public async Task<IQueryable<RegionEntity>> GetRegions(int zoneId)
        {
            var result = await Task.Run(() => _context.Region.Where(x => x.IsActive.Value && x.ZoneId == zoneId)
        .Select(m => new RegionEntity
        {
            RegionId = m.RegionId,
            ZoneId = m.ZoneId,
            RegionCode = m.RegionCode,
            RegionDesc = m.RegionDesc,
            ZdRegionCode = m.ZdRegionCode

        }).Distinct().AsQueryable());


            return result;
        }

        public async Task<IQueryable<AreaEntity>> GetAreas(int regionId)
        {
            var result = await Task.Run(() => _context.Area.Where(x => x.IsActive.Value && x.RegionId == regionId)
        .Select(m => new AreaEntity
        {
            AreaId = m.AreaId,
            AreaCode = m.AreaCode,
            AreaDesc = m.AreaDesc,
            ZdAreaCode = m.ZdAreaCode,
            RegionId = m.RegionId

        }).Distinct().AsQueryable());


            return result;
        }

        public async Task<IQueryable<HeadquarterEntity>> GetHeadquarters(int headquarterId)
        {
            var result = await Task.Run(() => _context.Headquarter.Where(x => x.IsActive.Value && x.HeadquarterId == headquarterId)
        .Select(m => new HeadquarterEntity
        {
            HeadquarterId = m.HeadquarterId,
            AreaId = m.AreaId,
            HqCode = m.HqCode,
            HqDesc = m.HqDesc,
            ZdHqCode = m.ZdHqCode

        }).Distinct().AsQueryable());


            return result;
        }

        public async Task<IQueryable<DropReasonEntity>> GetDropReasons()
        {
            var result = await Task.Run(() => _context.DrDropReason.Where(x => x.IsActive.Value)
        .Select(m => new DropReasonEntity
        {
            ReasonCode = m.ReasonCode,
            ReasonDesc = m.ReasonDesc

        }).Distinct().AsQueryable());
            return result;
        }

        public async Task<IQueryable<QualificationEntity>> GetQualifications(int specialityId)
        {
            var result = await Task.Run(() => _context.Qualification.Where(x => x.IsActive.Value && x.SpecId == specialityId)
        .Select(m => new QualificationEntity
        {
            QualiCode = m.QualiCode,
            QualiDesc = m.QualiDesc,
            OldQuali = m.OldQuali,
            QualificationId = m.QualificationId,
            SpecId = m.SpecId

        }).Distinct().AsQueryable());
            return result;
        }

        public async Task<IQueryable<CodeValueEntity>> GetCodeValues(string typeCode)
        {
            var result = await Task.Run(() => _context.CodeValue.Where(x => x.IsActive.Value && x.TypeCode == typeCode).OrderBy(o => o.SeqNo)
        .Select(m => new CodeValueEntity
        {
            CodeValId = m.CodeValId,
            ValCode = m.ValCode,
            ValDesc = m.ValDesc,
            SeqNo = m.SeqNo

        }).Distinct().AsQueryable()); ;
            return result;
        }

        public async Task<List<MenuEntity>> GetMenuItems(int repId, string loginType)
        {
            var result = await Task.Run(() => 
                            _context.MenuEntityItems.FromSqlRaw($"EXEC {_configuration.GetValue<string>("GetMenuItems")} {repId} {loginType}").ToList()
                            );
            return result;
        }
    }
}
