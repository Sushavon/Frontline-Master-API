using FrontlineMaster.Entity.Hierarchy;
using FrontlineMaster.Interface.Hierarchy;
using FrontlineMaster.Repository.ContextModel;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FrontlineMaster.Repository.Hierarchy
{
    public class HierarchyRepository : IHierarchyRepository
    {
        private readonly DBContext _context = null;
        private IConfiguration _configuration = null;
        public int LoggedInUserId;
        public HierarchyRepository(DBContext context, IConfiguration configuration)
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
    }
}
