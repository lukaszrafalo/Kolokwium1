﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOLO
{
    class Napastnik:Pilkarz
    {
        
        public Napastnik(string imie, string nazwisko, int numerNaKoszulce)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.numerNaKoszulce = numerNaKoszulce;
        }
    
    

    


        public string ToString()
        {
            return "Napastnik:";
        }
    }
}
