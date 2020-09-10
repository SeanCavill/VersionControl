try{
    int num = Console.ReadLine("Enter a number: ");
}
catch{
    Console.WriteLine("That is not a number");
}

Console.WriteLine($"Your number minus one is {num-1} :)");