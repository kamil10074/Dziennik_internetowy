using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_internetowy.Models
{
    public class Uczniowie
    {
        public int IdUcznia { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Miejsce_zamieszkania { get; set; }
        public int Klasa { get; set; }
    }
}