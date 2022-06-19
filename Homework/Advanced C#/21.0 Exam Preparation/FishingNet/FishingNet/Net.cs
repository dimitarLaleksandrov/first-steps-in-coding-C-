using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
   public class Net
    {
        private readonly ICollection<Fish> fish;
        public Net(string material, int capacity)
        {
            this.Material = material;
            this.Capacity = capacity;
            this.fish = new List<Fish>();
        }
        public string Material { get; set; }
        public int Capacity { get; set; }

        public int Count => this.fish.Count;
        public IReadOnlyCollection<Fish> Fish => (IReadOnlyCollection<Fish>)this.fish;

        public string AddFish(Fish fish)
        {
            if (string.IsNullOrWhiteSpace(fish.FishType) ||
                fish.Length <= 0 ||
                fish.Weight <= 0)
            {
                return "Invalid fish.";
            }

            if (Fish.Count + 1 > Capacity)
            {
                return "Fishing net is full.";
            }
            this.fish.Add(fish);
            return $"Successfully added {fish.FishType} to the fishing net.";
        }
        public bool ReleaseFish(double weight)
        {
            var fish = this.fish.FirstOrDefault(e => e.Weight == weight);
            if (fish != null)
            {
                return this.fish.Remove(fish);
            }
            return false;
        }
        public Fish GetFish(string fishType)
        {
            var fish = this.fish.FirstOrDefault(e => e.FishType == fishType);
            return fish;
        }

        public Fish GetBiggestFish()
        {
            var longestFish = this.fish.Max(e => e.Length);
            var fish = this.fish.FirstOrDefault(e => e.Length == longestFish);
            return fish;
        }
       
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Into the {this.Material}:");

            foreach (var item in Fish.OrderByDescending(x=> x.Length))
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();

        }
    }
}
