using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VicMarket.Domain.BaseModel.BaseEntityDto;

namespace VicMarket.Application.Dtos
{
    public class UserDto : BaseEntityDto
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
