// Scramble Method
//A scramble method is also known as a randomizer
//The scramble method is the exact opposite of a sorting method
// It takes the items in the list and assigns them to a random index
// Shuffles the list 'l', and assigns the items of 'l' to a random index

public static void Scramble(List<double> l)
{
    // Create a 'Random' object
    Random randomNumberGenerator = new Random();

    for (int i = 0; i < l.Count; i++)
    {
        int randomIndex = randomNumberGenerator.Next(0,l.count);
        
        // swap the item @ 'i' with 'randomIndex'
        double copy = l[i];
        l[i] = l[randomIndex];
        l[randomIndex] = copy;

    }

}