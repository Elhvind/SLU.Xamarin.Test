using SLU.ApiTest.DataAccess.Models;
using SLU.ApiTest.DataAccess.Repositories;
using SLU.ApiTest.DataAccess.Repositories.Interfaces;
using SLU.ApiTest.Models.Wholesalers;
using SLU.ApiTest.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SLU.ApiTest.Services
{
    public class WholesalerService : IWholesalerService
    {
        private readonly IWholesalerRepository _wholesalerRepository;

        public WholesalerService()
        {
            _wholesalerRepository = new WholesalerRepository();
        }

        public ICollection<WholesalerDTO> GetAllWholesalers()
        {
            var allWholesalers = _wholesalerRepository
                .GetAll()?
                .Select(ConvertToDTO)
                .ToList();

            return allWholesalers ?? new List<WholesalerDTO>();
        }

        public WholesalerDTO GetWholesaler(int id)
        {
            var wholesaler = _wholesalerRepository.Get(id);
            return ConvertToDTO(wholesaler);
        }

        public int CreateWholesaler(WholesalerDTO wholesaler)
        {
            var wholesalerEntity = new WholesalerEntity
            {
                Name = wholesaler.Name,
                LogoUrl = wholesaler.LogoUrl
            };

            return _wholesalerRepository.Create(wholesalerEntity);
        }

        public bool UpdateWholesaler(int id, WholesalerDTO wholesaler)
        {
            if (wholesaler == null)
                return false;

            var wholesalerToUpdate = _wholesalerRepository.Get(id);
            if (wholesalerToUpdate == null)
                return false;

            wholesalerToUpdate.Name = wholesaler.Name;
            wholesalerToUpdate.LogoUrl = wholesaler.LogoUrl;

            return _wholesalerRepository.Update(id, wholesalerToUpdate);
        }

        public bool DeleteWholesaler(int id)
        {
            return _wholesalerRepository.Delete(id);
        }

        private WholesalerDTO ConvertToDTO(WholesalerEntity wholesaler)
        {
            if (wholesaler == null)
                return null;

            //TODO: Use AutoMapper instead of custom mapping
            return new WholesalerDTO
            {
                Id = wholesaler.Id,
                Name = wholesaler.Name,
                LogoUrl = wholesaler.LogoUrl
            };
        }
    }
}