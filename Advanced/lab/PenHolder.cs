using System;
using System.Collections;

namespace lab
{
    public class PenHolder
    {
        Pen[] _pens;
        
        public PenHolder()
        {
            _pens = new Pen[6];
            _pens[0] = new BluePen() { _color = "blue", _hardness = "HB", _price = 10$ };
            _pens[1] = new BluePen() { _color = "blue", _hardness = "HB", _price = 10$ };
            _pens[2] = new YellowPen() { _color = "yellow", _hardness = "H", _price = 15$ };
            _pens[3] = new YellowPen() { _color = "yellow", _hardness = "H", _price = 15$ };
            _pens[4] = new GreenPen() { _color = "green", _hardness = "B", _price = 20$};
            _pens[5] = new GreenPen() { _color = "green", _hardness = "B", _price = 20$};
            /*_pens[6] = new BluePen() { _color = "BluePen", _hardness = "HB", _price = 1 };
            _pens[7] = new GreenPen() { _color = "GreenPen", _hardness = "B", _price = 20$};
            _pens[8] = new YellowPen() { _color = "YellowPen", _hardness = "H", _price = 15$ };
            _pens[9] = new BluePen() { _color = "BluePen", _hardness = "HB", _price = 1 }*/;
            
            Array.Sort(_pens);
        }
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < _pens.Length; i++)
            {
                yield return _pens[i];
            }
        }
    }
}