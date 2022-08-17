using NavalVessels.Core.Contracts;
using NavalVessels.Models;
using NavalVessels.Models.Contracts;
using NavalVessels.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NavalVessels.Core
{
    public class Controller : IController
    {
        private readonly VesselRepository vessels;
        private readonly List<ICaptain> captains;
        public Controller()
        {
            this.vessels = new VesselRepository();
            this.captains = new List<ICaptain>();
        }
        public string AssignCaptain(string selectedCaptainName, string selectedVesselName)
        {
            var capten = captains.FirstOrDefault(c => c.FullName == selectedCaptainName);
            var vessel = vessels.FindByName(selectedVesselName);
            if (capten == null)
            {
                return $"Captain {selectedCaptainName} could not be found.";
            }
            if (vessel == null)
            {
                return $"Vessel {selectedVesselName} could not be found";
            }
            if (vessel.Captain != null)
            {
                return $"Vessel {selectedVesselName} is already occupied.";
            }
            capten.AddVessel(vessel);
            return $"Captain {selectedCaptainName} command vessel {selectedVesselName}.";
        }

        public string AttackVessels(string attackingVesselName, string defendingVesselName)
        {
            throw new NotImplementedException();
        }

        public string CaptainReport(string captainFullName)
        {
            var captain = captains.FirstOrDefault(c => c.FullName == captainFullName);
            return captain.Report();
        }

        public string HireCaptain(string fullName)
        {
            var capten = captains.FirstOrDefault(c => c.FullName == fullName);
            if (capten != null)
            {
                return $"Captain {fullName} is already hired.";
            }
            captains.Add(capten);
            return $"Captain {fullName} is hired.";

        }

        public string ProduceVessel(string name, string vesselType, double mainWeaponCaliber, double speed)
        {
            var vessel = vessels.FindByName(vesselType);
            if (vessel != null)
            {
                return $"{vesselType} vessel {name} is already manufactured.";
            }
            if (vesselType != "Battleship" || vesselType != "Submarine")
            {
                return $"Invalid vessel type.";
            }
            else
            {
                if(vesselType == "Battleship")
                {
                    var vesselB = new Battleship(name, mainWeaponCaliber, speed);
                    vessels.Add(vesselB);
                }
                else
                {
                    var vesselB = new Submarine(name, mainWeaponCaliber, speed);
                    vessels.Add(vesselB);
                }
                return $"{vesselType} {name} is manufactured with the main weapon caliber of {mainWeaponCaliber} inches and a maximum speed of {speed} knots.";
            }
        }

        public string ServiceVessel(string vesselName)
        {
            throw new NotImplementedException();
        }

        public string ToggleSpecialMode(string vesselName)
        {
            var vessel = vessels.Models.FirstOrDefault(v => v.Name == vesselName);
            if (vessel.GetType().Name == "Battleship")
            {
               var vesselTypeB = vessel.
            }
        }

        public string VesselReport(string vesselName)
        {
            var vessel = vessels.FindByName(vesselName);
            return vessel.ToString();
        }
    }
}
