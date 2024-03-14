//// task 1 
//int n;

//Console.WriteLine("Ededi daxil edin: ");
//n = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"{n} x {i} = {n * i}");
//}

// task 2 --create string array with the following names  {"Vahid" , "Nicat", "Guler", "Gozel" , "Ulduz" , "Famil" , "Dadas" , "Vagif" , "Umid " , "Durna"};
// print the words that contain letter "u"
// after them add new array.
// after using that new array values ,  replace the letter "u" with the letter "e" after again print. Don't use metods


string[] array = { "Vahid", "Nicat", "Guler", "Gozel", "Ulduz", "Famil", "Dadas", "Vagif", "Umid", "Durna" };
string[] newArray = new string[array.Length]; 

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Contains('u')) 
    {
        Console.WriteLine(array[i]);
        newArray[count] = array[i].Replace('u', 'e');
        count++;
    }
}

    
if (count > 0)
{
    Console.WriteLine("\n deyisilen sozler :");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(newArray[i]);
    }
}
else
{
    Console.WriteLine("bele  bir soz yoxdur ");
}


