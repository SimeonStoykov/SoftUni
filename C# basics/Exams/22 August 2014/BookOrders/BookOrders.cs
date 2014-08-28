using System;

class BookOrders
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int numberOfPackets = 0;
        int booksPerPacket = 0;
        decimal bookPrice = 0;
        int booksCount = 0;
        decimal totalCost = 0;

        for (int i = 1; i <= N; i++)
        {
            numberOfPackets = int.Parse(Console.ReadLine());
            booksPerPacket = int.Parse(Console.ReadLine());
            bookPrice = decimal.Parse(Console.ReadLine());
            booksCount += numberOfPackets * booksPerPacket;

            if (numberOfPackets >= 10 && numberOfPackets <= 19)
            {
                bookPrice = bookPrice * 0.95m;
            }
            else if (numberOfPackets >= 20 && numberOfPackets <= 29)
            {
                bookPrice = bookPrice * 0.94m;
            }
            else if (numberOfPackets >= 30 && numberOfPackets <= 39)
            {
                bookPrice = bookPrice * 0.93m;
            }
            else if (numberOfPackets >= 40 && numberOfPackets <= 49)
            {
                bookPrice = bookPrice * 0.92m;
            }
            else if (numberOfPackets >= 50 && numberOfPackets <= 59)
            {
                bookPrice = bookPrice * 0.91m;
            }
            else if (numberOfPackets >= 60 && numberOfPackets <= 69)
            {
                bookPrice = bookPrice * 0.90m;
            }
            else if (numberOfPackets >= 70 && numberOfPackets <= 79)
            {
                bookPrice = bookPrice * 0.89m;
            }
            else if (numberOfPackets >= 80 && numberOfPackets <= 89)
            {
                bookPrice = bookPrice * 0.88m;
            }
            else if (numberOfPackets >= 90 && numberOfPackets <= 99)
            {
                bookPrice = bookPrice * 0.87m;
            }
            else if (numberOfPackets >= 100 && numberOfPackets <= 109)
            {
                bookPrice = bookPrice * 0.86m;
            }
            else if (numberOfPackets >= 110)
            {
                bookPrice = bookPrice * 0.85m;
            }

            totalCost += numberOfPackets * booksPerPacket * bookPrice;
        }
               
        Console.WriteLine(booksCount);
        Console.WriteLine("{0:f2}", totalCost);
    }
}