﻿/*
 *  Tee ohjelma, joka kysyy etunimesi ja sukunimesi. Ohjelma
 *  yhdistää nimet yhdeksi merkkijonoksi ja tulostaa ne
 *  lopuksi naytölle.
 *  
 *  
 *  a) Kayta cstring-kirjastoa (C:n merkkitaulukot)
 *  tehdäksesi merkkijonojen yhdistämisen
 *  b) Kayta string-kirjastoa (C++:n merkkijonot)
 *  tehdäksesi merkkijonojen yhdistämisen  TEE, JOS ON AIKAA
 *  
 *  Esimerkki
 *  Anna etunimi: Aku
 *  Anna sukunimi: Ankka
 *  Nimesi oli: Aku Ankka
 */

using System;

namespace Harj13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ei tee kauheasti järkeä C#:lla mutta tehdän silti...
            Console.WriteLine("Anna etunimi");
            string etunimi = Console.ReadLine();

            Console.WriteLine("Anna sukunimi");
            string sukunimi = Console.ReadLine();

            Console.WriteLine($"Nimesi oli: {etunimi} {sukunimi}");
        }
    }
}
