using System;
using System.Collections.Generic;

namespace _NetCoreConsolePlayground
{
    public class People
    {
        public static CuriousGeorge CuriousGeorge = new CuriousGeorge();
        public static Bolita Bolita = new Bolita();

        public static List<Person> AllPeople = new List<Person>()
        {
            CuriousGeorge, Bolita
        };
    }
}
