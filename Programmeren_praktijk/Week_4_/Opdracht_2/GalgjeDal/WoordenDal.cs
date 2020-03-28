using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalgjeDal
{
    public class WoordenDal
    {
        public List<string> GetAll()
        {
            List<string> x = new List<string>();
            x.AddRange(new string[] {"antiparticle", "atom", "duality", "electron", "cosmology", "geodesic", "mass", "neutrino", "neutron",
                                     "nucleus", "photon", "positron", "proton", "pulsar", "quantum", "quark", "radar", "radioactivity", "singularity", "spectrum"});

            return x;
        }
    }
}
