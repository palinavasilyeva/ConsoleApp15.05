var s = "Krzysztof Molenda, Jan Kowalski, Anna Abacka , Józef Kabacki, Kazimierz Moksa";

var query1 = s.Split(',', StringSplitOptions.RemoveEmptyEntries);
var query2 = query1.Select(ss => ss.Split(' ', StringSplitOptions.RemoveEmptyEntries));
var query3 = query2.Select(tab => (tab[1], tab[0]));
var query4 = query3.Select(para => para.Item1 + " " + para.Item2);
var query5 = query4.Order();

var wynik = string.Join(", ", query5);
Console.WriteLine(wynik);

//var query1 = s.Split(',', StringSplitOptions.RemoveEmptyEntries);

//var query2 = new List<string[]>();
//foreach (var x in query1)
//{
//    var temp = x.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//    query2.Add(temp);
//}

//var query3 = new List<ValueTuple<string, string>>();
//foreach (var x in query2)
//{
//    query3.Add((x[1], x[0]));
//}

//var query4 = new List<string>();
//foreach (var x in query3)
//{
//    query4.Add(x.Item1 + " " + x.Item2);
//}

//query4.Sort();

//var query5 = string.Join(", ", query4);
//Console.WriteLine(query5);

//foreach (var x in query1)
//{
//    Console.WriteLine(x);
//}