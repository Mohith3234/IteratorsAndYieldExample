using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndYieldExample
{
    public class Sample
    {
        List<int> list=new List<int>() { 10,20,30,40};
        public IEnumerable<int> Method()
        {
            int sum = 0;
           foreach(int i in list)
            {
                sum += i;
                yield return sum;
            }
        }
    }
    
    class Program
    {
        static void Main()
        {
            Sample sample = new Sample();
            var enumarable1=sample.Method();
            //call automatically until the end of the method
            foreach(var item in enumarable1)
            {
                Console.WriteLine(item);
            }
            //var enumerator1 = enumarable1.GetEnumerator();
            //enumerator1.MoveNext();
            //Console.WriteLine(enumerator1.Current); 
            //enumerator1.MoveNext();
            //Console.WriteLine(enumerator1.Current);
            Console.ReadKey();
        }
    }
}
