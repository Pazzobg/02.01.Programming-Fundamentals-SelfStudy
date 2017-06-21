namespace _03.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Animals
    {
        public static void Main()
        {
            var dogs = new Dictionary<string, Dog>();
            var cats = new Dictionary<string, Cat>();
            var snakes = new Dictionary<string, Snake>();

            string line = Console.ReadLine();

            while (line != "I'm your Huckleberry")
            {
                string[] input = line.Split(' ');

                if (input[0] != "talk")
                {
                    string animalClass = input[0];
                    string name = input[1];
                    int age = int.Parse(input[2]);
                    int parameter = int.Parse(input[3]);

                    switch (animalClass)
                    {
                        case "Dog":
                            var currentDog = new Dog
                            {
                                Name = name,
                                Age = age,
                                NumberOfLegs = parameter
                            };

                            dogs.Add(name, currentDog);
                            break;
                        case "Cat":
                            var currentCat = new Cat
                            {
                                Name = name,
                                Age = age,
                                IQ = parameter
                            };

                            cats.Add(name, currentCat);
                            break;
                        case "Snake":
                            var currentSnake = new Snake
                            {
                                Name = name,
                                Age = age,
                                CrueltyCoefficient = parameter
                            };

                            snakes.Add(name, currentSnake);
                            break;
                    }
                }
                else
                {
                    string talkingAnimal = input[1];

                    if (dogs.ContainsKey(talkingAnimal))
                    {
                        var dog = dogs.Values.Where(x => x.Name == talkingAnimal).ToArray();    // my solution
                        dog[0].ProduceSound();
                        // dogs[talkingAnimal].ProduceSound();                      alternative solutiuon :)
                    }
                    else if (cats.ContainsKey(talkingAnimal))
                    {
                        var cat = cats.Values.Where(x => x.Name == talkingAnimal).ToArray();
                        cat[0].ProduceSound();
                    }
                    else
                    {
                        var snake = snakes.Values.Where(x => x.Name == talkingAnimal).ToArray();
                        snake[0].ProduceSound();
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var kvp in dogs)
            {
                var dog = kvp.Value;
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }

            foreach (var kvp in cats)
            {
                var cat = kvp.Value;
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IQ}");
            }

            foreach (var kvp in snakes)
            {
                var snake = kvp.Value;
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }
        }
    }
}
