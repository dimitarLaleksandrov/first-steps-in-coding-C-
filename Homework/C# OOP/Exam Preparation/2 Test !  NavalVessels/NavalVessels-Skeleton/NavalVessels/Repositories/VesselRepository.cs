using NavalVessels.Repositories.Contracts;
using NavalVessels.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NavalVessels.Repositories
{
    public class VesselRepository : IRepository<IVersion>
    {
        private readonly List<IVersion> models;
        public VesselRepository()
        {
            this.models = new List<IVersion>();
        }
        public IReadOnlyCollection<IVersion> Models
        {
            get { return this.models; }
        }

        public void Add(IVersion model)
        {
            models.Add(model);
        }

        public IVersion FindByName(string name)
        {
            var veslle = models.Where(v => v.Name == name);
            return (IVersion)veslle;
        }

        public bool Remove(IVersion model)
        {
            var removevessel = this.models.Remove(model);
            return removevessel;
        }
    }
}
