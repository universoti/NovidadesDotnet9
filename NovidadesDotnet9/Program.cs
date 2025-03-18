// See https://aka.ms/new-console-template for more information

//Coutby
//var carros = new[] {"BMW","Mercedes","Audi","Porsche","Porsche","Audi"};
//var contador = carros.CountBy(x => x);
//var indiceitem = carros.Index();
//Console.ReadLine();

//Agregateby ver depois
var numeros=new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var resultado = numeros.AggregateBy(
keySelector: x => x % 2 == 0?"Par":"Impar",  //agrupa os numeros pares e impares
seed:0,                                                              //valor inicial para a contagem    
func: (contagem, _) =>contagem + 1                                  //incrementa a contagem p/cada elemento
);

foreach (var item in resultado)
{
    Console.WriteLine($"Tipo:{item.Key} - Contagem {item.Value}");
}
