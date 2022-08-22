using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VicMarket.Application.Dtos;
using VicMarket.Application.Validators.Generic;
using VicMarket.Domain.Entities;

namespace VicMarket.Application.Validators
{
    public class UserValidator : BaseValidator<UserDto>
    {
        public UserValidator()
        {

        }
    }
}
