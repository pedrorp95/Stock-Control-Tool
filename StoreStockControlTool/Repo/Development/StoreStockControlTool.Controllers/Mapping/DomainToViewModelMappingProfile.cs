using AutoMapper;
using StoreStockControlTool.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VLStoreModel.Model;

namespace StoreStockControlTool.Controllers.Mapping
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<VStockControl, VMStockControl>();
        }
    }
}
