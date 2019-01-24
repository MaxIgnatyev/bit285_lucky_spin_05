using System;
using System.Collections.Generic;

namespace LuckySpin.Models
{
    public class Repository
    {
        List<Spin> spins = new List<Spin>();

        public IEnumerable<Spin> Spins
        {
            get
            {
                return spins;
            }
        }

        public void AddSpins(Spin spin)
        {
            spins.Add(spin);
        }
    }
}
