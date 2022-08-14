using Formula1.Models.Contracts;
using Formula1.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Formula1.Repositories
{
    public class PilotRepository : IRepository<IPilot>
    {
        private readonly List<IPilot> models;
        public PilotRepository()
        {
            this.models = new List<IPilot>();
        }
        public IReadOnlyCollection<IPilot> Models => this.models;

        public void Add(IPilot model)
        {
            this.models.Add(model);
        }

        public IPilot FindByName(string name)
        {
            var pilot = this.models.FirstOrDefault(p => p.FullName == name);
            return pilot;
        }

        public bool Remove(IPilot model)
        {
            var removePilot = this.models.Remove(model);
            return removePilot;
        }
    }
}
