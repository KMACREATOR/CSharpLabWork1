using System;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using System.IO;

public abstract class Animal
{
    public string Name { get; set; }
    public string Country { get; set; }
    public bool HideFromOtherAnimals { get; set; }

    public abstract void SayHello();
    public abstract eFavoriteFood GetFavouriteFood();
    public abstract eClassificationAnimal GetClassificationAnimal();
}
public class Cow : Animal
{
    public override void SayHello() => Console.WriteLine("moo");
    public override eFavoriteFood GetFavouriteFood() => eFavoriteFood.Plants;
    public override eClassificationAnimal GetClassificationAnimal() => eClassificationAnimal.Herbivores;
}

public class Lion : Animal
{
    public override void SayHello() => Console.WriteLine("rrr");
    public override eFavoriteFood GetFavouriteFood() => eFavoriteFood.Meat;
    public override eClassificationAnimal GetClassificationAnimal() => eClassificationAnimal.Carnivores;
}

public class Pig : Animal
{
    public override void SayHello() => Console.WriteLine("oink");
    public override eFavoriteFood GetFavouriteFood() => eFavoriteFood.Everything;
    public override eClassificationAnimal GetClassificationAnimal() => eClassificationAnimal.Omnivores;
}

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class CommentAttribute : Attribute
{
    public string Description { get; }

    public CommentAttribute(string description)
    {
        Description = description;
    }
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class CommentAttribute1 : Attribute
    {
        public string Description { get; }

        public CommentAttribute1(string description)
        {
            Description = description;
        }
    }
}

public enum eClassificationAnimal
{
    Herbivores,
    Carnivores,
    Omnivores
}

public enum eFavoriteFood
{
    Meat,
    Plants,
    Everything
}

class Program
{
    static void Main()
    {
        Animal[] animals = { new Cow(), new Lion(), new Pig() };
        XElement xml = new XElement("Animals");

        foreach (var animal in animals)
        {
            var type = animal.GetType();
            var commentAttr = (CommentAttribute)Attribute.GetCustomAttribute(type, typeof(CommentAttribute));

            XElement animalElement = new XElement("Animal",
                new XElement("Type", type.Name),
                new XElement("Country", animal.Country),
                new XElement("HideFromOtherAnimals", animal.HideFromOtherAnimals),
                new XElement("FavoriteFood", animal.GetFavouriteFood()),
                new XElement("Classification", animal.GetClassificationAnimal()),
                new XElement("Comment", commentAttr?.Description)
                );

            xml.Add(animalElement);
        }
        File.WriteAllText("Animals.xml", xml.ToString());
        Console.WriteLine("XML файл создан");
    }
}
