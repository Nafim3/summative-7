using summative_7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace summative_7
{

    class Barbarian : Character
    {
        public Barbarian(string name) : base(name)
        {
            MaxHealthPoints = 18;
            MaxEnergyPoints = 12;
            _healthPoints = MaxHealthPoints;
            _energyPoints = MaxEnergyPoints;
        }

        public void SwingAxe(Character target)
        {
            if (!isKnockedOut && _energyPoints >= 3)
            {
                Console.WriteLine($"{Name} the barbarian swung his axe at {target.Name}.");
                target.TakeDamage(3);                                                           
                _energyPoints -= 3;                                                                            
            }
        }
    }
}

