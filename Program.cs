using System;
using System.Linq;
using System.Reflection.Metadata;
using HELL.Entities.Heroes;
using HELL.IO.Input;

namespace HELL
{
    public class Program
    {
        static void Main(string[] args)
        {
                new Commands.CommandManager().ProcessCommand();
                
        }
    }
}
