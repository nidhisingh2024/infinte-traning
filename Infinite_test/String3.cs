<<<<<<< HEAD
﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class String3

    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(1, 2, 3));
            Console.WriteLine(test(1, 3, 2));
            Console.WriteLine(test(1, 1, 1));
            Console.WriteLine(test(1, 2, 2));
            Console.ReadLine();

        }
        public static int test(int a, int b, int c)
        {
            var max = Math.Max(a, Math.Max(b, c));
            return max;
        }
    }
=======
﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class String3

    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(1, 2, 3));
            Console.WriteLine(test(1, 3, 2));
            Console.WriteLine(test(1, 1, 1));
            Console.WriteLine(test(1, 2, 2));
            Console.ReadLine();

        }
        public static int test(int a, int b, int c)
        {
            var max = Math.Max(a, Math.Max(b, c));
            return max;
        }
    }
>>>>>>> 65be0c565eaecd9c1173176cb72f5a4e99a0d14e
}