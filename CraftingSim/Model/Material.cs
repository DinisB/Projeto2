using System;

namespace CraftingSim.Model
{
    public class Material : IMaterial
    {
        public int Id { get; }
        public string Name { get; }

        public Material(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public bool Equals(IMaterial other)
        {
            if (other is null)
                return false;
            return this.Id == other.Id || string.Equals(this.Name, other.Name, StringComparison.OrdinalIgnoreCase);
        }
    }
}