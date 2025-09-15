
using System.Runtime;

string[] lines = File.ReadAllLines("sorted_numbers.txt");

// foreach (string line in lines)
//  {
//    Console.WriteLine(line);
//  }
// To read numbers from a file and store them in an array

Random rand = new Random();

int target = rand.Next(Convert.ToInt32(lines[0]), Convert.ToInt32(lines[lines.Length - 1]) + 1);

Console.WriteLine("Targeted number: " + target);

int guess = rand.Next(Convert.ToInt32(lines[0]), Convert.ToInt32(lines[lines.Length - 1]) + 1);

int guessNumber = 1;

while (guess != target)
{
    guess = rand.Next(Convert.ToInt32(lines[0]), Convert.ToInt32(lines[lines.Length - 1]) + 1);

    guessNumber++;

}

Console.WriteLine("Found the number " + target + " in " + guessNumber + " guesses.");