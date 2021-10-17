using LogisticsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogisticsDemo.Services
{
    public interface ICityService
    {
        List<Cities> getCityList();
        Cities getZone(Cities city);

    }
}
