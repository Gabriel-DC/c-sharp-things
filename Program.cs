using System.Diagnostics;
using c_sharp_things.code.IO;

namespace c_sharp_things
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dir dir = new Dir();

            dir.CreateDirectory("store");
        }
    }
}

