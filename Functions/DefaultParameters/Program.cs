using System;

void PrintWithPrefix(string thestr, string prefix="")
{
    Console.WriteLine($"{prefix} {thestr}");
}

PrintWithPrefix("Hello there!");
PrintWithPrefix("Hello There!", ">: ");

PrintWithPrefix(prefix: "% ", thestr: "Hello There!");