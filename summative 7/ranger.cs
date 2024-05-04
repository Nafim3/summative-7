using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace summative_7
{
    class Ranger : Character
    {
        private int NumberOfArrows = 10;

        public Ranger(string name) : base(name)
        {
            MaxHealthPoints = 10;
            MaxEnergyPoints = 8;
            _healthPoints = MaxHealthPoints;
            _energyPoints = MaxEnergyPoints;
        }

        public void FireArrows(Character target)
        {
            if (!isKnockedOut && NumberOfArrows > 0 && _energyPoints >= 1)
            {
                Console.WriteLine($"{Name} the ranger shot an arrow at {target.Name}.");
                target.TakeDamage(1);                                                                                               
                NumberOfArrows--;
                _energyPoints -= 1;
            }
        }
    }
}
