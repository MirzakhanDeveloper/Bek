using BEK.Classes;

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

int Age = 6;
Animal ari = new Animal(myname:"Mirzomddin",userage: Age, animalAge: 2);
Console.WriteLine($"Age diiderence :{ari.AgeDifference}");
Console.WriteLine($"Name :{ari.Name}\n ------------");

// Did yo have got your flowers?

Console.WriteLine("qolgan miqdor :");
int qolganMiqdor = 4;
Console.WriteLine("dastlabki miqdor:");
int dastlabkiMiqdor = 43;
Flower flowerCount = new Flower(shunchaQoldi: qolganMiqdor,firstCount: dastlabkiMiqdor);
Console.WriteLine($"Hozirda mavjud :{flowerCount.resultDifference}");
Console.WriteLine("--------------------------");
// How much count ?
Console.Write("Nomi: ");
string turNomi = Console.ReadLine();
Console.Write("Hozirgi miqdor :");
int hozirgiMiqdor = Convert.ToInt32(Console.ReadLine());
int sotilganMiqdor = 1;
Vegetable vegetableCountFirstly = new Vegetable(nomi:turNomi,miqdorHozirgi:hozirgiMiqdor, sotilgan: sotilganMiqdor );
Console.WriteLine($"Oldingi miqdor : {vegetableCountFirstly.oldingiMiqdor}");


