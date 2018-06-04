namespace lesson8
{
    public class Sniper
    {
        string _name;

        string _automatic;
        public Sniper(string name, string automatic)
        {
            _name = name;
            _automatic = automatic;
        }
        public override string ToString()
        {
            return _automatic;
        }
    }
}