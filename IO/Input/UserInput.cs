using System;
using System.Reflection;
using System.Text;

namespace HELL.IO.Input
{
    public static class UserInput
    {
       

        public static string[] GetCommand()
        {
            return Console.ReadLine().Split();

        }

    }
}
