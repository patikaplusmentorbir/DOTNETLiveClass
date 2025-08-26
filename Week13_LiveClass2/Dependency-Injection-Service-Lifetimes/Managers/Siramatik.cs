using Dependency_Injection_Service_Lifetimes.Services;

namespace Dependency_Injection_Service_Lifetimes.Managers
{
    
    public class Siramatik : ISiramatik
    {
    
        int _count = 0;
        public int SiraNumarasiAl()
        {
          

            return ++_count;

            /*
             _count = _count+1;
            return _count;
            */
             
           
        }
    }
}
