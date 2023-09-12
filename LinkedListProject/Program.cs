// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
using System.Collections.Generic;
using LinkedListProject;

public class Program
{
    public static void Main()
    {
        LinkedList<string> InitialList = new LinkedList<string>();

        var listaPokemons = Engine.GetPokemons();
        var listaHeroes = Engine.GetMarvelHeroes();

        foreach (var item in listaPokemons) {
            InitialList.AddLast(item.Name);

            if (InitialList.Count == 3) { InitialList.AddBefore(InitialList.Last , listaHeroes[0].Name);}
            if (InitialList.Count == 4) { InitialList.AddBefore(InitialList.First, listaHeroes[1].Name); }
            if (InitialList.Count == 7) { InitialList.AddAfter(InitialList.Find("Pichu"), listaHeroes[3].Name); }
        }

        var valor = InitialList.Find("Spider Man").Value;

        Console.Write(valor);
    }
}