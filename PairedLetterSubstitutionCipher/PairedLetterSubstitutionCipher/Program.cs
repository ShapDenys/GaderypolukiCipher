using GaderypolukiCipher;

Console.WriteLine("Write text to encript");

string input = Console.ReadLine();

string output = Cypher.GaderypolukiDictionary(input);

Console.WriteLine("Encrupted text is:  " + output);