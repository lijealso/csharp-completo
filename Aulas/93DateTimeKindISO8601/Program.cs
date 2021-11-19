// See https://aka.ms/new-console-template for more information

DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

Console.WriteLine("d1: " + d1);
Console.WriteLine("d1 Kind: " + d1.Kind);
Console.WriteLine("d1 to local: " + d1.ToLocalTime());
Console.WriteLine("d1 to UTC: " + d1.ToUniversalTime());

// ISO 8601

DateTime d4 = DateTime.Parse("2000-08-15 13:05:58");
DateTime d5 = DateTime.Parse("2000-08-15T13:05:58Z");

Console.WriteLine(d4);
Console.WriteLine(d5);


