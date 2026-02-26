using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Quic;

// README.md를 읽고 코드를 작성하세요.


FruitPriceList fruitPriceList = new FruitPriceList(5);
class FruitPriceList
{
    private string[] _names;
    private int[] _prices;
    private int _count = 0;

    public FruitPriceList(int capacity)
    {
        _names = new string[capacity];
        _prices = new int[capacity];
        
    }

    public int this[string name]
    {
        get {
                if( _names == null)
                {
                return -1;
                }
                return _prices[_count];
            }
    }
    
    public string this[int index]
    {
        get {
            if (index >= _count)
                return "";
            
                return _names[index];
            }
       
    }
}

