using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface IWorker
    {
        void Work();
    }
    public interface IEather
    {
        void Eat();
    }
    internal class HumanWorker : IWorker, IEather
    {
        public void Eat()
        {
            Console.WriteLine("İnsan yemek yiyor.");
        }

        public void Work()
        {
            Console.WriteLine("İnsan çalışıyor.");
        }
    }

    internal class RobotWorker : IWorker
    {
  
        public void Work()
        {
            Console.WriteLine("Robot çalışıyor.");
        }
    }
}
