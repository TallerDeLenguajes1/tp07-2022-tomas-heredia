using System;
using ejercicio1;

int NTareas;
string[] descripciones = {"Peronista", "marxista","Furro"};
List<Tareas> TPendientes = new List<Tareas>();
List<Tareas> TCompletadas = new List<Tareas>();


Console.WriteLine("Pasame la cantidad de tareas papu ");
NTareas = Int32.Parse(Console.ReadLine());

for (int i = 0; i < NTareas; i++)
{
    Random aleatorio = new Random();
    Tareas auxiliar = new Tareas(i+1,descripciones[aleatorio.Next(0,descripciones.Length)],aleatorio.Next(10,100));
    TPendientes.Add(auxiliar);
}

