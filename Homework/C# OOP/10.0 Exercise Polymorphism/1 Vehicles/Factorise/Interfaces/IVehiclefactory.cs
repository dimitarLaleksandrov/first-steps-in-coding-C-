using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Factorise.Interfaces
{
    using Models;
    public interface IVehiclefactory
    {
        Vehicle CreateVehicle(string vehicleTipe, double fuleQuontity, double fuileConsumpshion);
    }
}
