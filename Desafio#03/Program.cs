﻿// Abaixo segue um exemplo de código que você pode ou não utilizar
/*using System;

class DIO {

  static void Main(string[] args) {

    double pi, raio, volume;
    pi = 3.14159;
 //TODO: Complete os espaços em branco com uma possível solução para o desafio     
    raio = double.Parse(Console.ReadLine());
    volume = pi * (        ) * Math.Pow( raio , 3 );
    
    Console.WriteLine($"VOLUME =       ");
  }
}*/

 double pi, raio, volume;
 pi = 3.14159;
 //TODO: Complete os espaços em branco com uma possível solução para o desafio     
raio = double.Parse(Console.ReadLine());
volume = pi * (4 / 3.0) * Math.Pow( raio , 3 );
    
Console.WriteLine($"VOLUME = {volume:F3}");