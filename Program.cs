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

int qolganMiqdor = 4;
Console.WriteLine($"Qolgan miqdor :{qolganMiqdor}");
int dastlabkiMiqdor = 43;
Console.WriteLine($"Dastlabki miqdor:{dastlabkiMiqdor}");
string placeJoy = "Namangan";
Flower flowerCount = new Flower(shunchaQoldi: qolganMiqdor,firstCount: dastlabkiMiqdor, place: placeJoy );
Console.WriteLine($"Hozirda mavjud :{flowerCount.resultDifference}");
Console.WriteLine("--------------------------");
// How much count ?
string turNomi = "Pomadoro";
Console.WriteLine($"Nomi: {turNomi}");
int hozirgiMiqdor = 3;
Console.WriteLine($"Hozirgi miqdor :{hozirgiMiqdor}");
int sotilganMiqdor = 1;
Vegetable vegetableCountFirstly = new Vegetable(nomi:turNomi,miqdorHozirgi:hozirgiMiqdor, sotilgan: sotilganMiqdor );
Console.WriteLine($"Oldingi miqdor : {vegetableCountFirstly.resultVegetable}");
Console.WriteLine("-----------------");

// How much have got it all fruits?
 string meva = "Mandarin";
 Console.WriteLine($"Meva nomi :{meva}");
 int narx = 6000;
 Console.WriteLine($"Narxi :{narx}.so'm");
 int miqdor = 3;
 Console.WriteLine($"Miqdori:{miqdor}.kg ");
 Console.WriteLine("--------------------");
 Fruit mevalar = new Fruit(nomi:meva, narxi: narx, miqdori: miqdor);
 Console.WriteLine($"Jami:{meva} | {narx}.0 so'm * {miqdor}.0 kg = {mevalar.result}");
Console.WriteLine("--------------------");

// Result all of the vegetable
string sNomi = "Cucumber";
Console.WriteLine($"Sabzavot nomi : {sNomi}");
int hozirgiMiqdori = 35;
Console.WriteLine($"Miqdori :{hozirgiMiqdori}.0 kg");
int sotilganNarx = 2000;
Console.WriteLine($"Narx : {sotilganNarx}.0 so'm ");

Console.WriteLine("------------------");

Vegetable sabzavotlar = new Vegetable(nomi:sNomi,miqdorHozirgi:hozirgiMiqdori,sotilgan:sotilganNarx );
Console.WriteLine($"{sNomi} | {hozirgiMiqdori} * {sotilganNarx} = {sabzavotlar.resultVegetable}");
Console.WriteLine("--------------------------");

// Counting is flower.
int qoldiGul = 17;
Console.WriteLine($"Qolgan gullar: {qoldiGul}");
int dastlabkiGul = 30;
Console.WriteLine($"Dastlabki gullar: {dastlabkiGul}");
string placeJoys = "Oltiariq";
Console.WriteLine($"Joy :{placeJoys}");



Console.WriteLine("-------------------");

Flower gullar = new Flower(shunchaQoldi: qoldiGul, firstCount: dastlabkiGul,place: placeJoys );
Console.WriteLine($"Hozirda qolgan gullar: {qoldiGul}|\n Shundan dastlabki gullar : {dastlabkiGul}\n  Jami :{gullar.resultDifference} ta mavjud");

Console.WriteLine($"O'sgan joyi :{gullar.place}");
Console.WriteLine("-------------------");

int odamYoshi = 24;
Console.WriteLine($"Odam yoshi :{odamYoshi}");
int hayvonAge = 4;
Console.WriteLine($"Hayvon yoshi :{hayvonAge}");
string odamName = "Sardor";

Animal hayvonlarAge = new Animal(myname: odamName,userage: odamYoshi, animalAge: hayvonAge);
Console.WriteLine($"Odam yoshi:{odamYoshi} - Ismi: {odamName} | Hayvon yoshi :{hayvonAge} | Bir biridan farqi: {hayvonlarAge.AgeDifference}");



