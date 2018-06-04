using System;
using System.Collections;

namespace lesson8
{

    public class SoldierPriceAscendingCaomparer:IComparer
    {
        public int Compare(object x, object y)
        {
            Soldier leftSoldier = x as Soldier;
            Soldier rightSoldier = x as Soldier;
            return leftSoldier._id = rightSoldier._id;
        }
        
    }
    public class Soldier:IComparable
    {
        string _person;
        public int _id;
        public Soldier(string person, int id)
        {
            _person = person;
            _id = id;
        }

        public int CompareTo(object obj)
        {
            Soldier otherSoldier = obj as Soldier;
            return otherSoldier._id = _id;
        }

        public override string ToString()
        {
            return _person;
        }
    }
}