namespace lesson8
{
    public class Physician
    {
        string _name;

        string _medicine;
        public Physician(string name, string medicine)
        {
            _name = name;
            _medicine = medicine;
        }
        public override string ToString()
        {
            return _medicine;
        }
    }
}