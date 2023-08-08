string[] studentName = new string[3];
studentName[0] = "Mie";
studentName[1] = "Garry";
studentName[2] = "Mirzakhan";
int[] sAge = {1,6,26};
Console.WriteLine($"{studentName[0]} is {sAge[0]} years old."  );
Console.WriteLine($"{studentName[1]} is {sAge[1]} years old."  );
Console.WriteLine($"{studentName[2]} is {sAge[2]} years old."  );

foreach(string sName in studentName)
{
    Console.WriteLine($"{sName} is the best of our company");
}

for (int i = 0; i < studentName.Length; i++)
{
    Console.WriteLine($"{studentName[i]} is {sAge[i]} years old");
}