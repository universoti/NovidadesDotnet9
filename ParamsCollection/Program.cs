
//ColecaoNumeros(1, 2, 3, 4, 5);
//ColecaoNumeros(new List<int> { 1, 2, 3, 4, 5 });
ColecaoNumeros(Enumerable.Range (6,4 ));


//antes teria que converter para toArray
//coleçoes de qualquer tipo


//listas,Ienumerable,colection, etc
//static void ColecaoNumeros(params int[] numeros)
//{
//    foreach (var item in numeros)
//    {
//        Console.WriteLine(item);
//    }
//}


//static void ColecaoNumeros(params List<int> numeros)
//{
//    foreach (var item in numeros)
//    {
//        Console.WriteLine(item);
//    }
//}


static void ColecaoNumeros(params IEnumerable<int> numeros)
{
    foreach (var item in numeros)
    {
        Console.WriteLine(item);
    }
}