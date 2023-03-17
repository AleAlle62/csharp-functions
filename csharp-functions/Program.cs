//funzione StampaArray
Console.WriteLine("PRIMA FUNZIONE");

Console.WriteLine("stampo array");
printArray(new[] {2, 5, 7, 9, 3});

void printArray(int[] array)
{
    Console.WriteLine(arrayToString(array));
}
string arrayToString(int[] array)
{
    var result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        result += array[i].ToString();

        if (i < array.Length - 1)
        {
            result += ",";
        }
    }
    result += "]";
    return result;
}



//funzione Elevato al quadrato

Console.WriteLine("SECONDA FUNZIONE");

int numeroDaElevare = 6;
var numeroQuadrato = Quadrato(numeroDaElevare);
Console.WriteLine(numeroQuadrato);

int Quadrato(int number)
{
    return number * number;
}



//funzione dell'array al quadrato


Console.WriteLine("TERZA FUNZIONE");

int[] QuadratoArray(int[] inputArray)
{
    int[] quadratoArray = new int[inputArray.Length];
    for (int i = 0; i < inputArray.Length; i++)
    {
        quadratoArray[i] = inputArray[i] * inputArray[i];
    }
    return quadratoArray;
}
int[] esempioArray = { 1, 2, 3, 4, 5 };
int[] arrayQuadrato = QuadratoArray(esempioArray);


//array originale
string arrayString = string.Join(", ", esempioArray);
Console.WriteLine("array originale: " + arrayString);


//array elevato
string arrString = string.Join(", ", arrayQuadrato);
Console.WriteLine("array elevato: " + arrString);




//funzione somma elementi 

Console.WriteLine("QUARTA FUNZIONE");


int[] numeri = { 1, 2, 3, 4, 5 };
int somma = 0;
foreach (int numero in numeri)
{
    somma += numero;
}
Console.WriteLine("La somma degli elementi dell'array e': " + somma);



