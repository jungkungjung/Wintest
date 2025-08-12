using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.Class
{
    internal class firstInterface
    {
        public interface Imoveable
        {
            void Walk();
            void Run();
        }

        public class Person : Imoveable
        {
            public void Walk()
            {
                Console.WriteLine("คนเดิน 2 ขา");
            }
            public void Run()
            {
                Console.WriteLine("คนวิ่ง 2 ขา");
            }
        }

        public class Cat : Imoveable
        {
            public void Walk()
            {
                Console.WriteLine("แมวเดิน 2 ขา");
            }
            public void Run()
            {
                Console.WriteLine("แมววิ่ง 2 ขา");
            }
        }
    }
}
