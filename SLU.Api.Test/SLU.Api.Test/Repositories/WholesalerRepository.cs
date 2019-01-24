﻿using SLU.Api.Test.Core.Repositories;
using SLU.Api.Test.Data.Entities;

namespace SLU.Api.Test.Repositories
{
    public class WholesalerRepository : RepositoryBase<WholesalerEntity>
    {
        public WholesalerRepository() : base("wholesaler.json")
        {

        }
    }
}