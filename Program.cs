using System.Security.Cryptography;
Console.Clear();

int secret = RandomNumberGenerator.GetInt32(1, 101);
int numeroadi;


Console.WriteLine("--- Adivinhe o Número! ---");

Console.WriteLine("Pensando em um Número...");

Thread.Sleep(1000); 

Console.WriteLine("Okay! Agora... ADIVINHE!");

