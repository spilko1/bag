using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasche;

public class Schoolbag
{
    List<string> _things = new();

    public void add(string thing)
    {
        _things.Add(thing);
    }

    string _color;

    public Schoolbag(string color)
    {
        _color = color;
    }

    public void Print()
    {
        for (int i = 0;i < _things.Count; i++)
        {
            if (_things[i].Substring(0, 1) == "H")
            {
                Console.WriteLine(_things[i]);
            }
        }
    }
}
