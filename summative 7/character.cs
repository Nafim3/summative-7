// See https://aka.ms/new-console-template for more information

using summative_7;


Ranger rangerobj = new Ranger("Azad");
Barbarian barbarianobj = new Barbarian("Rasel");
Bomber bomberobj = new Bomber("Akib");

barbarianobj.SwingAxe(rangerobj);
rangerobj.FireArrows(barbarianobj);
bomberobj.positionmine(rangerobj);

public class Character
{
    public string Name { get; protected set; }
    protected int MaxHealthPoints { get; set; }
    protected int MaxEnergyPoints { get; set; }
    protected int _healthPoints;
    protected int _energyPoints;

    public Character(string name)
    {
        Name = name;
    }

    public bool isKnockedOut
    {
        get 
        {
            return _healthPoints <= 0; 
        }
    }

    public void TakeDamage(int damage)
    {
        _healthPoints -= damage;

        if (_healthPoints < 0)
        {
            _healthPoints = 0;
        }
    }

    public void Rest()
    {
        if (!isKnockedOut)
        {
            _energyPoints = MaxEnergyPoints;
            _healthPoints = MaxHealthPoints;
        }
    }

}