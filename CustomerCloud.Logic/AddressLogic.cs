using AutoMapper;
using CustomerCloud.DTOs;
using CustomerCloud.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCloud.Logic
{
    public class AddressLogic : BaseLogic<AddressEntity, AddressDTO>
    {
        public AddressLogic()
        {
            Mapper.Initialize(
                cfg => cfg.CreateMap<AddressDTO, AddressEntity>()
                );
        }
    }
}
