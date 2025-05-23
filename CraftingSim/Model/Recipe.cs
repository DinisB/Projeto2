using System;
using System.Collections.Generic;

namespace CraftingSim.Model
{
    public class Recipe : IRecipe
    {
        public string Name { get; }
        public IReadOnlyDictionary<IMaterial, int> RequiredMaterials { get; }
        public double SuccessRate { get; }

        public Recipe(string name, IDictionary<IMaterial, int> requiredMaterials, double successRate)
        {
            Name = name;
            RequiredMaterials = new Dictionary<IMaterial, int>(requiredMaterials);
            SuccessRate = successRate;
        }

        public int CompareTo(IRecipe other)
        {
            if (other == null) return 1;
            return string.Compare(this.Name, other.Name, StringComparison.OrdinalIgnoreCase);
        }
    }
}