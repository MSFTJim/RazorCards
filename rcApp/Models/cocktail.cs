using System;

namespace rcApp.Models

{
    public class Cocktail : IComparable<Cocktail>, IEquatable<Cocktail>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal Rating { get; set; }
        public string Desc { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;

        public bool Equals(Cocktail other)
        {
            if (other == null) return false;
            return (this.Id.Equals(other.Id));
        }
        public int CompareTo(Cocktail compareItem)
        {
            // A null value means that this object is greater.
            if (compareItem == null)
                return 1;

            else
                return this.Id.CompareTo(compareItem.Id);
        }

        public override string ToString()
        {
            return "Id: " + Id + ", Name: " + Name + ", Price: " + Price + ", Rating: " + Rating;
        }


    }

}