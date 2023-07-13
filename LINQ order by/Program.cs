using System;
using System.Linq;
using System.Collections.Generic;

//ref link:https://www.youtube.com/watch?v=JT7FZvgMDfo&list=PL90AF0EFFEF782D27&index=15
// Order by-- doesnt contain the estability of the source

static class MainClass
{
    static void Main()
    {
        var result =
            from c in DB.Customers
            orderby c.Country descending, c.ContactName descending
            select c;
        foreach (var c in result)
            Console.WriteLine(c.Country + " " + c.ContactName);
        
        var result2 =
            //from c in DB.Customers
            DB.Customers
                .OrderbyDescending(c => c.Country)
                //.ThenBy(c => c.ContactName);
                .OrderBy(c => c.ContactName); 
        foreach (var c in result2)
            Console.WriteLine(c.Country  + " " + c.ContactName);
    }
}