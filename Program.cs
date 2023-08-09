using BEK.Classes;

Fruit apple = new Fruit();
apple.price = 120;
apple.name = "Qizil";
apple.quantity = 40;
Console.WriteLine($"Name (Fruit): {apple.name}\n Quantity : {apple.quantity} \n Price :{apple.price} \n ----------");

apple.Price = 7500;
apple.Name = "Red";
apple.Quantity = 25;
Console.WriteLine($"Property (Price) - {apple.Price}");
Console.WriteLine($"Field (price) - {apple.price}");

Console.WriteLine($"Field (quantity) - {apple.quantity}");

Console.WriteLine($"Property (Quantity) - {apple.Quantity} \n --------------");

Fruit pomadoro = new Fruit();
pomadoro.Name = "Pomadoro";
pomadoro.Price = 4000;
pomadoro.Quantity = 23;

Console.WriteLine($"Name (Fruit): {pomadoro.Name} \n Price: {pomadoro.Price} \n Quantity: {pomadoro.Quantity}\n ----------");






Vegetable carrot = new Vegetable();
carrot.Name = "Carrot";
carrot.Price = 1800;
carrot.Quantity = 52;

Console.WriteLine($"Name (Vegetable): {carrot.Name} \n Price: {carrot.Price} \n Quantity: {carrot.Quantity}\n----------");



Flower flower = new Flower();

flower.Name = "Rose";
flower.Price = 15000;
flower.Quantity = 70;
flower.Place ="Ferghana";

Animal bear = new Animal();
bear.Name = "Panda";
bear.Quantity = 0;
bear.Place = "Forest";
bear.Age = 5;

Console.WriteLine($"Name (Flower) : {flower.Name} \n Price : {flower.Price} \n Quantity : {flower.Quantity} \n Place :{flower.Place}\n-------");
Console.WriteLine($"Name (Animal) : {bear.Name} \n Quantity : {bear.Quantity} \n Place :{bear.Place} \n Age :{bear.Age}");



