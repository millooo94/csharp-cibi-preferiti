//Array cibi preferiti

var foods = new string[] { "Lasagne alla bolognese", "Pasta all'amatriciana", "Hamburger", "Cipollina", "Arancino", "Pizza", "Salsiccia", "Kebab", "Parmigiana"};

//Lunghezza classifica

var rankingLength = foods.Length;

//Classifica

Console.WriteLine("Classifica:");

for (int i = 0; i < foods.Length; i++)
{
    Console.WriteLine((i + 1) + ". " + foods[i]);
}

//#PrimoInClassifica

var first = foods[0];

//#UltimoInClassifica
var last = foods[foods.Length - 1];

//#MetaClassifica

var middleIndex = foods.Length / 2;

var medium1 = "";
var medium2 = "";

if(foods.Length > 0)
{
    if (foods.Length % 2 == 0)
    {
        medium1 = foods[middleIndex];
        medium2 = ", " + foods[middleIndex - 1];
    }
    else
    {
        medium1 = foods[middleIndex];
    }
}

Console.WriteLine($"Ranking Length: {rankingLength}");
Console.WriteLine($"Favorite Food: {first}");
Console.WriteLine($"Less Favorite Food: {last}");
Console.WriteLine($"Medium Ranking Food: {medium1}{medium2}");
Console.ReadLine();
