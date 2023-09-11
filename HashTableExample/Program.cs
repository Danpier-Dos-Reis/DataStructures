// See https://aka.ms/new-console-template for more information

using HashTableExample.Models;
using System.Collections;

Hashtable heroestable = new Hashtable();

SuperHero[] heroes = {
    new SuperHero(1,"Super Man","Fly, Strenght, Laser"),
    new SuperHero(2,"Wonder Woman", "Fly, Strenght"),
    new SuperHero(3,"Flash","Speed Force"),
    new SuperHero(4,"Grenn Lantern","DoSomething"),
    new SuperHero(5,"Goku","Fly, Kamekameha, Teletransportation"),
    new SuperHero(6,"Naruto","Rasengan, Kagebushin no Jutsu")
};

//Adding SuperHeroes to hashtable
foreach (var hero in heroes) { heroestable.Add(hero.Id , hero); }

//Get an superHero from hashtable
SuperHero newGoku = (SuperHero)heroestable[5];

//hashtable contain the number 10 like a key?
string contain10 = heroestable.Contains(10) == true ? "yes":"no";

Console.WriteLine($"Table Selection => Id: {newGoku.Id}, Name: {newGoku.Name}" +
                                            $"\n\tPowers => {newGoku.Powers}" +Environment.NewLine);
Console.WriteLine($"table contain the 10 key? \n\t  R => {contain10}");