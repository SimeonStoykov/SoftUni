using System;
using System.Collections.Generic;
using System.Threading;

struct Object
{
    public int x;
    public int y;
    public string c;
    public ConsoleColor color;
}

class FallingRocks
{
    static void PrintOnPosition(int x, int y, string c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
    static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }
    static void Main()
    {
        double speed = 100.0;
        double acceleration = 0.5;
        int playFieldWidth = 15;
        int livesCount = 5;
        Console.BufferHeight = Console.WindowHeight = 25;
        Console.BufferWidth = Console.WindowWidth = 50;
        Object dwarf = new Object();
        dwarf.x = 7;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.c = "(0)";
        dwarf.color = ConsoleColor.Yellow;
        Random randomGenerator = new Random();
        List<Object> objects = new List<Object>();
        string[] r = { "!", "@", "#", "$", "%", "&", "^", "+" };
        int randomObject = randomGenerator.Next(r.Length);

        while (true)
        {            
            speed += acceleration;
            
            if (speed > 400)
            {
                speed = 400;
            }

            bool hitted = false;
            {
                int chance = randomGenerator.Next(0, 101);
                
                if (chance < 10)
                {
                    Object newObject = new Object();
                    newObject.color = ConsoleColor.Cyan;
                    newObject.c = "-";
                    newObject.x = randomGenerator.Next(0, playFieldWidth);
                    newObject.y = 0;
                    objects.Add(newObject);
                }
                else if (chance < 20)
                {
                    Object newObject = new Object();
                    newObject.color = ConsoleColor.Cyan;
                    newObject.c = "*";
                    newObject.x = randomGenerator.Next(0, playFieldWidth);
                    newObject.y = 0;
                    objects.Add(newObject);
                }                   
                else
                {                  
                    Object newObject = new Object();
                    newObject.color = ConsoleColor.Green;
                    newObject.x = randomGenerator.Next(0, playFieldWidth);
                    newObject.y = 0;
                    newObject.c = r[randomObject];
                    objects.Add(newObject);
                }
            }

            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
               
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x - 1 >= 0)
                    {
                        dwarf.x--;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x + 1 < 15)
                    {
                        dwarf.x++;
                    }
                }
            }

            List<Object> newList = new List<Object>();
            for (int i = 0; i < objects.Count; i++)
            {
                Object oldRock = objects[i];
                Object newObject = new Object();
                newObject.x = oldRock.x;
                newObject.y = oldRock.y + 1;
                newObject.c = oldRock.c;
                newObject.color = oldRock.color;

                if (newObject.c == "*" && ((newObject.y == dwarf.y && newObject.x == dwarf.x) ||
                   (newObject.y == dwarf.y && newObject.x == dwarf.x + 1) || 
                   (newObject.y == dwarf.y && newObject.x == dwarf.x + 2)))
                {
                    speed -= 20;
                }

                if (newObject.c == "-" && ((newObject.y == dwarf.y && newObject.x == dwarf.x) ||
                   (newObject.y == dwarf.y && newObject.x == dwarf.x + 1) || 
                   (newObject.y == dwarf.y && newObject.x == dwarf.x + 2)))
                {
                    livesCount++;
                }

                if (newObject.c == r[randomObject] && ((newObject.y == dwarf.y && newObject.x == dwarf.x) || 
                   (newObject.y == dwarf.y && newObject.x == dwarf.x+1) || 
                   (newObject.y == dwarf.y && newObject.x == dwarf.x+2)))
                {
                    livesCount--;
                    hitted = true;
                    speed += 50;
                    if (speed > 400)
                    {
                        speed = 400;
                    }
                    if (livesCount <= 0)
                    {
                        PrintStringOnPosition(20, 10, "GAME OVER!!!", ConsoleColor.Red);
                        PrintStringOnPosition(20, 12, "Press [Enter] to exit...", ConsoleColor.Red);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }

                if (newObject.y < Console.WindowHeight)
                {
                    newList.Add(newObject);
                }
            }
            objects = newList;
            Console.Clear();

            foreach (Object rock in objects)
            {
                PrintOnPosition(rock.x, rock.y, rock.c, rock.color);
            }
            if (hitted)
            {
                Console.Beep();
                objects.Clear();
                PrintOnPosition(dwarf.x, dwarf.y, "X", ConsoleColor.Red);
            }
            else
            {
                PrintOnPosition(dwarf.x, dwarf.y, dwarf.c, dwarf.color);
            }
            PrintStringOnPosition(20, 5, "Lives: " + livesCount, ConsoleColor.White);
            PrintStringOnPosition(20, 7, "Speed: " + speed, ConsoleColor.White);
            Thread.Sleep((int)(600 - speed));
        }
    }
}

