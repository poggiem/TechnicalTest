﻿using ConsoleApp1;

var people  = PersonProcessor.PeopleBuilder();

var results = PersonProcessor.GetTotalGoodPersonPoints(people);

Console.WriteLine($"Total good person points: {results}");
Console.ReadLine();
