using Formula1.Core.Contracts;
using Formula1.Models;
using Formula1.Models.Contracts;
using Formula1.Repositories;
using Formula1.Repositories.Contracts;
using Formula1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Formula1.Core
{
    public class Controller : IController
    {
        private PilotRepository pilotRepository;
        private RaceRepository raceRepositor;
        private FormulaOneCarRepository carRepository;
        public Controller()
        {
            this.pilotRepository = new PilotRepository();
            this.raceRepositor = new RaceRepository();
            this.carRepository = new FormulaOneCarRepository();

        }
        public string AddCarToPilot(string pilotName, string carModel)
        {
            var pilot = pilotRepository.FindByName(pilotName);
            var car = carRepository.FindByName(carModel);
            if (pilot == null || pilot.Car != null)
            {
                throw new InvalidOperationException($"Pilot {pilotName} does not exist or has a car.");
            }
            else if (car == null)
            {
                throw new NullReferenceException($"Car {carModel} does not exist.");
            } 
            pilot.AddCar(car);
            carRepository.Remove(car);
            return $"Pilot {pilotName} will drive a {car.GetType().Name} {carModel} car.";
        }

        public string AddPilotToRace(string raceName, string pilotFullName)
        {
            var pilot = pilotRepository.FindByName(pilotFullName);
            var race = raceRepositor.FindByName(raceName);
            var isPilotRcing = raceRepositor.FindByName(raceName).Pilots;
            if(race == null)
            {
                throw new NullReferenceException($"Race {raceName} does not exist.");
            }
            if (pilot == null || !pilot.CanRace || isPilotRcing.Contains(pilot))
            {
                throw new InvalidOperationException($"Can not add pilot {pilotFullName} to the race.");
            }
            race.AddPilot(pilot);
            return $"Pilot {pilotFullName} is added to the {raceName} race.";
        }

        public string CreateCar(string type, string model, int horsepower, double engineDisplacement)
        {
            IFormulaOneCar car;
            if (type == "Ferrari")
            {
                car = new Ferrari(model, horsepower, engineDisplacement);
                if (this.carRepository.Models.Any(cm => cm.Model == model))
                {
                    throw new InvalidOperationException($"Formula one car {model} is already created.");
                }
                carRepository.Add(car);
                return $"Car {type}, model {model} is created.";
            }
            else if (type == "Williams")
            {
                car = new Williams(model, horsepower, engineDisplacement);
                if (this.carRepository.Models.Any(cm => cm.Model == model))
                {
                    throw new InvalidOperationException($"Formula one car {model} is already created.");
                }
                carRepository.Add(car);
                return $"Car {type}, model {model} is created.";
            }
            else
            {
                throw new InvalidOperationException($"Formula one car type {type} is not valid.");
            }                
        }

        public string CreatePilot(string fullName)
        {
            if (pilotRepository.Models.Any(x => x.FullName == fullName))
            {
                throw new InvalidOperationException($"Pilot {fullName} is already created.");
            }
            else
            {
                IPilot pilot = new Pilot(fullName);
                pilotRepository.Add(pilot);
                return $"Pilot {fullName} is created.";
            }
        }
        public string CreateRace(string raceName, int numberOfLaps)
        {
            var race = new Race(raceName, numberOfLaps);
            if (raceRepositor.Models.Any(x => x.RaceName == raceName))
            {
                throw new InvalidOperationException($"Race {raceName} is already created.");
            }
            raceRepositor.Add(race);
            return $"Race {raceName} is created.";
        }

        public string PilotReport()
        {
            var sb = new StringBuilder();
            var pilots = pilotRepository.Models.OrderByDescending(x => x.NumberOfWins).ToList();
            foreach (var pilot in pilots)
            {
                sb.AppendLine(pilot.ToString());
            }
            return sb.ToString().TrimEnd();
        }

        public string RaceReport()
        {
            var sb = new StringBuilder();
            foreach (var race in raceRepositor.Models.Where(x => x.TookPlace == true))
            {
                sb.AppendLine(race.RaceInfo().TrimEnd());
            }
            return sb.ToString().TrimEnd();
        }
        public string StartRace(string raceName)
        {
            var race = raceRepositor.FindByName(raceName);
            if (race == null)
            {
                throw new InvalidOperationException($"Race {raceName} does not exist.");
            }

            if (race.Pilots.Count < 3)
            {
                throw new InvalidOperationException($"Race {raceName} cannot start with less than three participants.");
            }
            if (race.TookPlace == true)
            {
                throw new InvalidOperationException($"Can not execute race {raceName}.");
            }
            var topDrivers = race.Pilots.OrderByDescending(x => x.Car.RaceScoreCalculator(race.NumberOfLaps)).ToList();
            var first = topDrivers[0];
            var second = topDrivers[1];
            var third = topDrivers[2];
            first.WinRace();
            race.TookPlace = true;
            var sb = new StringBuilder();
            sb.AppendLine($"Pilot {first.FullName} wins the {race.RaceName} race.");
            sb.AppendLine($"Pilot {second.FullName} is second in {race.RaceName} race.");
            sb.AppendLine($"Pilot {third.FullName} is third in {race.RaceName} race.");
            return sb.ToString().TrimEnd();
        }
    }
}
