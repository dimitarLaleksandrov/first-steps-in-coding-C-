using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
            Renovators = new List<Renovator>();
        }
        private List<Renovator> renovators;
        private string name;
        private int neededRenovators;
        private string project;
        public List<Renovator> Renovators
        {
            get { return renovators; }
            set { renovators = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int NeededRenovators
        {
            get { return neededRenovators; }
            set
            {
                neededRenovators = value;
            }
        }
        public string Project
        {
            get { return project; }
            set
            {
                project = value;
            }
        }
        public int Count { get { return Renovators.Count; } }
        public string AddRenovator(Renovator renovator)
        {
            if(string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
            {
                return $"Invalid renovator's information.";
            }
            else if(renovators.Count >= NeededRenovators)
            {
                return $"Renovators are no more needed.";
            }
             else if( renovator.Rate > 350)
            {
                return $"Invalid renovator's rate.";
            }
            else
            {
                Renovators.Add(renovator);
                return $"Successfully added {renovator.Name} to the catalog.";
            } 
        }
        public bool RemoveRenovator(string name)
        {
            bool isItRemove = false;
            var ren = new List<Renovator>(Renovators);
            foreach (var item in ren)
            {
                if(item.Name == name)
                {
                    Renovators.Remove(item);
                    isItRemove = true;
                }
            }
            return isItRemove;
        }
        public int RemoveRenovatorBySpecialty(string type)
        {
            int count = 0;
            var ren = new List<Renovator>(Renovators);
            foreach (var item in ren)
            {
                if (item.Type == type)
                {
                    Renovators.Remove(item);
                    count++;
                }
            }
            return count;
        }
        public Renovator HireRenovator(string name)
        {
            var ren = new List<Renovator>(Renovators);
            foreach (var item in ren)
            {
                if (item.Name == Name)
                {
                    item.Hired = true;
                    return item;
                }
            }
            return null;
        }
        public List<Renovator> PayRenovators(int days)
        {
            var ren = new List<Renovator>(Renovators.Where(d => d.Days >= days));
            return ren;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            var ren = new List<Renovator>(Renovators.Where(h => h.Hired == false));
            sb.AppendLine($"Renovators available for Project {Project}:");
            foreach (var item in ren)
            {
                sb.AppendLine(string.Join(" ", item));
            }
            return sb.ToString();
        }
    }
}
