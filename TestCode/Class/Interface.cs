using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.Class
{
    public interface IVerhicle
    {
        void Move();
        void StartEngine();
    }

    class Cars : IVerhicle
    {
        public void Move()
        {
            Console.WriteLine("Driving on the ground.");
        }

        public void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }
    }

    class Boat : IVerhicle
    {
        public void Move()
        {
            Console.WriteLine("Sailing on the water.");
        }

        public void StartEngine()
        {
            Console.WriteLine("Boat engine started.");
        }
    }

}
