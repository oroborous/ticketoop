using System;

namespace TicketOOP.Models
{
    public class Ticket : IEquatable<Ticket>
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public bool Equals(Ticket other)
        {
            return Name == other.Name;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}";
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Ticket) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                // Choose large primes to avoid hashing collisions
                const int hashingBase = (int) 2166136261;
                const int hashingMultiplier = 16777619;

                var hash = hashingBase;
                hash = (hash * hashingMultiplier) ^ (Id?.GetHashCode() ?? 0);
                hash = (hash * hashingMultiplier) ^ (Name?.GetHashCode() ?? 0);

                return hash;
            }
        }
    }
}