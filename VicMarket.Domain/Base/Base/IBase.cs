using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VicMarket.Domain.BaseModel.Base
{
    public interface IBase
    {
        int Id { get; set; }
        bool Deleted { get; set; }
    }
}
