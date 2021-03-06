﻿using BethanysPieShopHRM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Api.Models
{
    public interface IRegionRepository
    {
        IEnumerable<Region> GetAllRegions();
        Region GetRegionById(int regionId);
        Region AddRegion(Region region);
        Region UpdateRegion(Region region);
        void DeleteRegion(int regionId);
    }
}