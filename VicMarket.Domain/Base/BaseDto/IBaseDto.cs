using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VicMarket.Domain.Base.BaseDto
{
    public interface IBaseDto
    {
        int? Id { get; set; }   
        bool Deleted { get; set; }  
    }
}
