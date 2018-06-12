using System;
using System.Collections.Generic;
using System.Text;

namespace MyClassLibrary
{
    public class Hello
    {
        public static string SayHello(string name) => $"Hello {name}! ({typeof(Hello).Assembly.Location})";
    }
}
