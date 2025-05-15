using System;
using System.Linq;

public static class Program
{
    public static string SortByDateOfBirthThenLastName(string napis)
    {
        return string.Join("; ",
            from entry in napis.Split(';', StringSplitOptions.RemoveEmptyEntries)
            let parts = entry.Trim().Split(',', StringSplitOptions.RemoveEmptyEntries)
            let nameParts = parts[0].Split(' ', StringSplitOptions.RemoveEmptyEntries)
            let dateOfBirth = DateTime.Parse(parts[1].Trim())
            orderby dateOfBirth, nameParts[1]
            select $"{nameParts[0]} {nameParts[1]}, {dateOfBirth:yyyy-MM-dd}");
    }

    public static void Main()
    {
        string input = "Krzysztof Molenda, 1965-11-20; Jan Kowalski, 1987-01-01; Anna Abacka, 1972-05-20; Józef Kabacki, 2000-01-02; Kazimierz Moksa, 2001-01-02";
        string wynik = SortByDateOfBirthThenLastName(input);
        Console.WriteLine(wynik);
    }
}

//var s = "Krzysztof Molenda, Jan Kowalski, Anna Abacka , Józef Kabacki, Kazimierz Moksa";

//var query = s.Split(',', StringSplitOptions.RemoveEmptyEntries)
//    .Select(ss => ss.Split(' ', StringSplitOptions.RemoveEmptyEntries))
//    .Select(tab => (nazwisko: tab[1], imie: tab[0]))
//    .OrderBy(para => para.nazwisko)
//    .ThenBy(para => para.imie)
//    .Select(para => $"{para.nazwisko} {para.imie}");
////.Select(para => para.Item1 + " " + para.Item2)
////.Order();
//var wynik = string.Join(", ", query);
//Console.WriteLine(wynik);

//var query1 = s.Split(',', StringSplitOptions.RemoveEmptyEntries);
//var query2 = query1.Select(ss => ss.Split(' ', StringSplitOptions.RemoveEmptyEntries));
//var query3 = query2.Select(tab => (tab[1], tab[0]));
//var query4 = query3.Select(para => para.Item1 + " " + para.Item2);
//var query5 = query4.Order();

//var wynik = string.Join(", ", query5);
//Console.WriteLine(wynik);

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