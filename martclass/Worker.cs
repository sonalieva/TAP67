using System;
using System.Collections.Generic;
using System.Text;

namespace martclass
{
    class Worker:Person
    {
        
       
        public Worker(double money,int time,string name,string surname,int age):base(name,surname,age)
        {
            double Salary = Money * Time;
           
            Console.WriteLine(Salary);
        }
        public double Money;
        public int Time;
        public double Salary;
    }
}
