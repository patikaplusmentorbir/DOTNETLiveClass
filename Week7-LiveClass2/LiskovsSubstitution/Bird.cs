using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovsSubstitution
{
    public interface IBird
    {
        void Move();

    }

    public class Sparrow : IBird
    {
        public void Move()
        {
            Console.WriteLine("Papağan uçuyor.");
        }
    }

    public class Penguin : IBird
    {
        public void Move()
        {
            Console.WriteLine("Penguen koşuyor.");
        }
    }
}
