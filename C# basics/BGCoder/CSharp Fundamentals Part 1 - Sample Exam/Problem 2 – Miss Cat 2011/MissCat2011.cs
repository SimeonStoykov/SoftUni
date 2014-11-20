using System;

class MissCat2011
{
    static void Main()
    {
        int juryMembers = int.Parse(Console.ReadLine());
        int[] catsNumbers = new int[10];

        for (int i = 0; i < juryMembers; i++)
        {
            int voteFor = int.Parse(Console.ReadLine());
            for (int j = 0; j < catsNumbers.Length; j++)
            {
                if (j + 1 == voteFor)
                {
                    catsNumbers[j]++;
                }
            }
        }

        int maxVote = 0;
        int maxVoteFor = 0;

        for (int i = 0; i < catsNumbers.Length; i++)
        {
            if (catsNumbers[i] > maxVote)
            {
                maxVote = catsNumbers[i];
                maxVoteFor = i + 1;
            }
        }

        Console.WriteLine(maxVoteFor);
    }
}