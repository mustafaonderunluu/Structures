using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            Console.WriteLine(sehirler.Count);

            MyList<int> sehirler2 = new MyList<int>();  //generic değildir 
            sehirler2.Add(54);



            MyList <string>sehirler3= new MyList<string>();
            sehirler3.Add("ankara");
            Console.WriteLine(sehirler3.Count);
            Console.ReadLine();
        }
    }
    class MyList<T>
    {

        T[] _array;
        T[] _temparray;
        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T item) {
            _temparray= _array;
            _array = new T[_array.Length + 1];

            for (int i = 0; i < _temparray.Length; i++) {



                _array[i] = _temparray[i];
            }
            _array[_array.Length - 1] = item;
        
        }
        

        public int Count
        {
            get { return _array.Length; }
            
        }

    }
}
