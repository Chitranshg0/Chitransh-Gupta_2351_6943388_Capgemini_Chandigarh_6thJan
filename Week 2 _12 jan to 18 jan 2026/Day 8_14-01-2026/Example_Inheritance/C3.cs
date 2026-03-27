using System;
using System.Collections.Generic;
using System.Text;

namespace Example_Inheritance
{
    internal class C3: Inter1 , Inter2
    {
        void Inter1.f1()
        {
            Console.WriteLine("this is overriding function of inter1 and inter2 interfaces");
        }
       void Inter2.f1()
        {
            Console.WriteLine("this is overriding function of inter1 and inter2 interfaces……..");
        }
    }
}
