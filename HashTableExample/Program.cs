// See https://aka.ms/new-console-template for more information

using HashTableExample.Models;
using System.Collections;

Dictionary<int, SuperHero> heroestable = new Dictionary<int, SuperHero>();

SuperHero[] heroes = {
    new SuperHero(1,"Super Man","Fly, Strenght, Laser"),
    new SuperHero(2,"Wonder Woman", "Fly, Strenght"),
    new SuperHero(3,"Flash","Speed Force"),
    new SuperHero(4,"Green Lantern","DoSomething"),
    new SuperHero(5,"Goku","Fly, Kamekameha, Teletransportation"),
    new SuperHero(6,"Naruto","Rasengan, Kagebushin no Jutsu")
};

//Adding SuperHeroes to Dictionary
foreach (var hero in heroes) { heroestable.Add(hero.Id, hero); }

//Get an superHero from Dictionary
SuperHero newGoku = (SuperHero)heroestable[6];

//Dictionary contain the number 10 like a key?
string contain10 = heroestable.ContainsKey(10) == true ? "yes" : "no";

//Are Flash in the Dictionary?
SuperHero flash = new SuperHero(3, "Flash", "Speed Force");
string containValue = heroestable.ContainsValue(flash) == true ? "yes" : "no";

Console.WriteLine($"Table Selection => Id: {newGoku.Id}, Name: {newGoku.Name}" +
                                            $"\n\tPowers => {newGoku.Powers}" + Environment.NewLine);
Console.WriteLine($"table contain the 10 key? \n\t  R => {contain10}" + Environment.NewLine);
Console.WriteLine($"Are Flash in the table?" + $"\n\tR => {containValue}");