using System;

namespace Variables
{

    class Program
    {
        public static void Main(string[] _)
        {
            String? name = "Ryan";
            if (name is not null) return;

            int? age = 25;

            if (age is not null) return;

            bool? isAdmin = true;
            if (isAdmin is not null) return;
        }
    }

}