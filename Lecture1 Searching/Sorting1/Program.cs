
string[] lines = File.ReadAllLines("sorted_numbers.txt");

// foreach (string line in lines)
//  {
//    Console.WriteLine(line);
//  }
// To read numbers from a file and store them in an array

//

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

Console.WriteLine("Stupid search: Number was " + target + ", guessed in " + guessNumber + " guesses.");


//Linear Search
int count = 0;

for (int i = 0; i < lines.Length; i++)
{
    count = count + 1;
    if (Convert.ToInt32(lines[i]) == target)
    {
        Console.WriteLine("Linear search: Number was " + guess + ", guessed in " + count + " guesses!");
        break;
    }
}


//Binary Search
int low = 0;
int high = lines.Length - 1;
int counter = 1;

int middle = (low + high) / 2;

while (Convert.ToInt32(lines[middle]) != target)
{
    counter = counter + 1;
    if (Convert.ToInt32(lines[middle]) < target)
    {
        low = middle + 1;
    }
    else
    {
        high = middle - 1;
    }
    middle = (low + high) / 2;
    count = count + 1;
}
Console.WriteLine("Binary search: Number was " + guess + ", guessed in " + counter + " guesses!");