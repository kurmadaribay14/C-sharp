namespace lesson8
{
    public class Marine:Soldier
    {
        string _name;
        string _id;

        string _ship;
        public Marine(string name, string ship,string id)
        {
            _name = name;
            _ship = ship;
            _id = id;
        }
        public override string ToString()
        {
            return _ship;
        }
    }
}