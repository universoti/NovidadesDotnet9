//var carros = new[] { "BMW", "Mercedes", "Audi", "Porsche", "Porsche", "Audi" };

//count 
//var contadorNormal = carros.Count();

//countBy
//var contador = carros.CountBy(x => x);

//foreach (var item in contador)
//{
//    Console.WriteLine($"carro:{item.Key}, Quantidade{item.Value}!");
//}




//Index  -- antes usava o elementAt
//var indiceitem = carros.Index();

//foreach (var item in indiceitem)
//{
//    Console.WriteLine($"Indice:{item.Index} - Valor:{item.Item}");
//}


//Console.WriteLine("Hello, World!");


//AggregateBy
var numeros = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var resultado = numeros.AggregateBy(
keySelector: x => x % 2 == 0 ? "Par" : "Impar",  //agrupa os numeros pares e impares
seed: 0,                                                              //valor inicial para a contagem    
func: (contagem, _) => contagem + 1                                  //incrementa a contagem p/cada elemento
);

foreach (var item in resultado)
{
    Console.WriteLine($"Tipo:{item.Key} - Contagem {item.Value}");
}



//Console.WriteLine("Hello, World!");
