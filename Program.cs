﻿using BEK.Classes;

Fruit apple = new ()
{
    price = 120,
    name = "Qizil",
    quantity = 40
};





Fruit piece = new ()
{
    price = 0,
    name = "s",
    quantity = 0    
};

Console.WriteLine($"Piece - {piece.price}-{piece.name}-{piece.quantity}");



Console.WriteLine($"Name (Fruit): {apple.name}\n Quantity : {apple.quantity} \n Price :{apple.price} \n ----------");

apple.Price = 7500;
apple.Name = "Red";
apple.Quantity = 25;
Console.WriteLine($"Property (Price) - {apple.Price}");
Console.WriteLine($"Field (price) - {apple.price}");

Console.WriteLine($"Field (quantity) - {apple.quantity}");

Console.WriteLine($"Property (Quantity) - {apple.Quantity} \n --------------");

Fruit pomadoro = new ()
{
     Price = 4000,
     Name = "Pomadoro",
     Quantity = 23
};
Console.WriteLine($"Name (Fruit): {pomadoro.Name} \n Price: {pomadoro.Price} \n Quantity: {pomadoro.Quantity}\n ----------");






Vegetable carrot = new ()
{
    Name = "Carrot",
    Price = 1800,
    Quantity = 52
};
Console.WriteLine($"Name (Vegetable): {carrot.Name} \n Price: {carrot.Price} \n Quantity: {carrot.Quantity}\n----------");



Flower flower = new ()
{
    Name = "Rose",
    Price = 15000,
    Quantity = 70,
    Place ="Ferghana"
};

Animal bear = new ()
{
    Name = "Panda",
    Quantity = 0,
    Place = "Forest",
    Age = 5
};

Console.WriteLine($"Name (Flower) : {flower.Name} \n Price : {flower.Price} \n Quantity : {flower.Quantity} \n Place :{flower.Place}\n-------");
Console.WriteLine($"Name (Animal) : {bear.Name} \n Quantity : {bear.Quantity} \n Place :{bear.Place} \n Age :{bear.Age}");





