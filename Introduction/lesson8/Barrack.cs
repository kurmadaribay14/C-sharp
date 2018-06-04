using System;
using System.Collections;

namespace lesson8
{
    
    public class BarrackEnumarator 
    {
        Soldier[] _ss;
        int _index = -1; 
        public object Current 
        {
            get{return _ss[_index];}
        }

        public bool MoveNext()
        {
            if(_index<_ss.Length-1)
            {
                _index++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
     public class Barrack
    {
        Soldier[] _ss;

        public Barrack()
        {
            _ss[0] = new Soldier("Tom",1);
            _ss[1] = new Soldier("Dan",2);
            _ss[1]= new Soldier("Ban",3);
        }

        public IEnumerator GetEnumerator()
        {
          //  return new BarrackEnumerator(_ss);
          for(int i=0;i<_ss.Length;i++)
            yield return _ss;
        }
        
    }
}