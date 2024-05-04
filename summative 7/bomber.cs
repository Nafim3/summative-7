using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace summative_7
{
    class Bomber : Character
    {
        public Bomber(string name) : base(name)
        {
            MaxHealthPoints = 8;
            MaxEnergyPoints = 8;
            _healthPoints = MaxHealthPoints;
            _energyPoints = MaxEnergyPoints;
        }

        public void Throwbomb(Character target)
        {
            if (!isKnockedOut && _energyPoints >= 2)
            {
                Console.WriteLine($"{Name} has thrown a bomb at {target.Name}.");
                target.TakeDamage(3); 
                _energyPoints -= 1;
            }
        }

        public void positionmine(Character target)                                                                                              // Override the base Heal for more specific behavior
        {
            if (!isKnockedOut && _energyPoints >= 4)
            {
                Console.WriteLine($"{Name} has set a position mine for {target.Name}.");
                target.TakeDamage(8);
                _energyPoints -= 4;
            }
        }
    }
}
