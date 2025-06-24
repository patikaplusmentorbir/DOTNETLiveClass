

using Polymorphism.Models;

Animal animal = new Animal();

Plant plant = new Plant();

Human human = new Human();


Console.WriteLine("Hayvan İçin :");
animal.Breath();

Console.WriteLine("Bitki İçin :");
plant.Breath();

Console.WriteLine("İnsan için :");
human.Breath();