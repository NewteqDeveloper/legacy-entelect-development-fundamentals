using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.House.Interfaces
{
    public interface IHouse
    {
        void LiveInHouse();
        void UseService(HouseService service);
    }
}
