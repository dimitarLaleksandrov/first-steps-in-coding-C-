using AquaShop.Models.Decorations.Contracts;
using AquaShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Repositories
{
    public class DecorationRepository : IRepository<IDecoration>
    {
        private readonly ICollection<IDecoration> models;
        public DecorationRepository()
        {
            this.models = new HashSet<IDecoration>();
        }
        public IReadOnlyCollection<IDecoration> Models => (IReadOnlyCollection<IDecoration>)this.models;

        public void Add(IDecoration model)
        {
            this.models.Add(model);
        }
        public bool Remove(IDecoration model)
        {
            var isItRemoved = false;
            if (this.models.Contains(model))
            {
                this.models.Remove(model);
                isItRemoved = true;
            }
            return isItRemoved;
        }

        public IDecoration FindByType(string type)
        {
            var findedType = this.models.FirstOrDefault(t => t.GetType().Name == type);
            return findedType;
        }
    }
}
