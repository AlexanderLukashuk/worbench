using System;

namespace workbench
{
    class Program
    {
        static void Main(string[] args)
        {
            var tool = new Tool();
            var material = new MaterialOfTool();
            
            int sizeOfArrayX = 13;
            int sizeOfArrayY = 7;
            string[,] craftTable =
                    {{"+", "-", "-", "-", "+", "-", "-", "-", "+", "-" , "-", "-", "+"},
                    {"|", " ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|"},
                    {"+", "-", "-", "-", "+", "-", "-", "-", "+", "-" , "-", "-", "+"},
                    {"|", " ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|"},
                    {"+", "-", "-", "-", "+", "-", "-", "-", "+", "-" , "-", "-", "+"},
                    {"|", " ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|"},
                    {"+", "-", "-", "-", "+", "-", "-", "-", "+", "-" , "-", "-", "+"}}; // [13, 7]

            int lineY = 1;
            int lineX = 2;

            string input;
            int menu = -1;
            while (true)
            {
                while (menu < 1 || menu > 2)
                {
                    Console.WriteLine("Выберите опцию:");
                    Console.WriteLine("1)Изготовить");
                    Console.WriteLine("2)Выход");
                    input = Console.ReadLine();
                    menu = int.Parse(input);
                }

                if (menu == 2)
                {
                    break;
                }
                else
                {
                    System.ConsoleKey key;
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Клавиши со стрелочками - передвижение");
                        Console.WriteLine("Пробел - убрать материал");
                        Console.WriteLine("Завершить рецепт");
                        Console.WriteLine("W - дерево");
                        Console.WriteLine("S - камень");
                        Console.WriteLine("I - железо");
                        Console.WriteLine("G - золото");
                        Console.WriteLine("M - мифрил");

                        for (int i = 0; i < sizeOfArrayY; i++)
                        {
                            for (int j = 0; j < sizeOfArrayX; j++)
                            {
                                Console.Write(craftTable[i, j]);
                            }
                            Console.WriteLine();
                        }

                        key = Console.ReadKey().Key;

                        if (key == ConsoleKey.LeftArrow)
                        {
                            if (lineX - 4 > 0)
                            {
                                lineX -= 4;
                            }
                        }
                        else if (key == ConsoleKey.RightArrow)
                        {
                            if (lineX + 4 < sizeOfArrayX)
                            {
                                lineX += 4;
                            }
                        }
                        else if (key == ConsoleKey.UpArrow)
                        {
                            if (lineY - 2 > 0)
                            {
                                lineY -= 2;
                            }
                        }
                        else if (key == ConsoleKey.DownArrow)
                        {
                            if (lineY + 2 < sizeOfArrayY)
                            {
                                lineY += 2;
                            }
                        }
                        else if (key == ConsoleKey.Enter)
                        {
                            if (craftTable[1, 2] == "S" &&
                            craftTable[1, 6] == "S" &&
                            craftTable[1, 10] == "S" &&
                            craftTable[3, 6] == "W" &&
                            craftTable[5, 6] == "W")
                            {
                                tool.Type = "кирка";

                                material.Material = "Каменная";

                                var result = tool + material;
                                Console.WriteLine($"Вы скрафтили предмет - {result.ToolName}");
                                Console.ReadLine();
                                Console.Clear();

                                craftTable[1, 2] = " ";
                                craftTable[1, 6] = " ";
                                craftTable[1, 10] = " ";
                                craftTable[3, 6] = " ";
                                craftTable[5, 6] = " ";
                            }
                            else if (craftTable[1, 2] == "I" &&
                                craftTable[1, 6] == "I" &&
                                craftTable[1, 10] == "I" &&
                                craftTable[3, 6] == "W" &&
                                craftTable[5, 6] == "W")
                            {
                                tool.Type = "кирка";

                                material.Material = "Железная";

                                var result = tool + material;
                                Console.WriteLine($"Вы скрафтили предмет - {result.ToolName}");
                                Console.ReadLine();
                                Console.Clear();

                                craftTable[1, 2] = " ";
                                craftTable[1, 6] = " ";
                                craftTable[1, 10] = " ";
                                craftTable[3, 6] = " ";
                                craftTable[5, 6] = " ";
                            }
                            else if (craftTable[1, 2] == "G" &&
                                craftTable[1, 6] == "G" &&
                                craftTable[1, 10] == "G" &&
                                craftTable[3, 6] == "W" &&
                                craftTable[5, 6] == "W")
                            {
                                tool.Type = "кирка";

                                material.Material = "Золотая";

                                var result = tool + material;
                                Console.WriteLine($"Вы скрафтили предмет - {result.ToolName}");
                                Console.ReadLine();
                                Console.Clear();

                                craftTable[1, 2] = " ";
                                craftTable[1, 6] = " ";
                                craftTable[1, 10] = " ";
                                craftTable[3, 6] = " ";
                                craftTable[5, 6] = " ";
                            }
                            else if (craftTable[1, 2] == "M" &&
                                craftTable[1, 6] == "M" &&
                                craftTable[1, 10] == "M" &&
                                craftTable[3, 6] == "W" &&
                                craftTable[5, 6] == "W")
                            {
                                tool.Type = "кирка";

                                material.Material = "Мифриловая";

                                var result = tool + material;
                                Console.WriteLine($"Вы скрафтили предмет - {result.ToolName}");
                                Console.ReadLine();
                                Console.Clear();

                                craftTable[1, 2] = " ";
                                craftTable[1, 6] = " ";
                                craftTable[1, 10] = " ";
                                craftTable[3, 6] = " ";
                                craftTable[5, 6] = " ";
                            }
                            else if (craftTable[1, 2] == "S" &&
                                craftTable[1, 6] == "S" &&
                                craftTable[3, 2] == "S" &&
                                craftTable[3, 6] == "W" &&
                                craftTable[5, 6] == "W")
                            {
                                tool.Type = "топор";

                                material.Material = "Каменный";

                                var result = tool + material;
                                Console.WriteLine($"Вы скрафтили предмет - {result.ToolName}");
                                Console.ReadLine();
                                Console.Clear();

                                craftTable[1, 2] = " ";
                                craftTable[1, 6] = " ";
                                craftTable[3, 2] = " ";
                                craftTable[3, 6] = " ";
                                craftTable[5, 6] = " ";
                            }
                            else if (craftTable[1, 2] == "I" &&
                                craftTable[1, 6] == "I" &&
                                craftTable[3, 2] == "I" &&
                                craftTable[3, 6] == "W" &&
                                craftTable[5, 6] == "W")
                            {
                                tool.Type = "топор";

                                material.Material = "Железный";

                                var result = tool + material;
                                Console.WriteLine($"Вы скрафтили предмет - {result.ToolName}");
                                Console.ReadLine();
                                Console.Clear();

                                craftTable[1, 2] = " ";
                                craftTable[1, 6] = " ";
                                craftTable[3, 2] = " ";
                                craftTable[3, 6] = " ";
                                craftTable[5, 6] = " ";
                            }
                            else if (craftTable[1, 2] == "G" &&
                                craftTable[1, 6] == "G" &&
                                craftTable[3, 2] == "G" &&
                                craftTable[3, 6] == "W" &&
                                craftTable[5, 6] == "W")
                            {
                                tool.Type = "топор";

                                material.Material = "Золотой";

                                var result = tool + material;
                                Console.WriteLine($"Вы скрафтили предмет - {result.ToolName}");
                                Console.ReadLine();
                                Console.Clear();

                                craftTable[1, 2] = " ";
                                craftTable[1, 6] = " ";
                                craftTable[3, 2] = " ";
                                craftTable[3, 6] = " ";
                                craftTable[5, 6] = " ";
                            }
                            else if (craftTable[1, 2] == "M" &&
                                craftTable[1, 6] == "M" &&
                                craftTable[3, 2] == "M" &&
                                craftTable[3, 6] == "W" &&
                                craftTable[5, 6] == "W")
                            {
                                tool.Type = "топор";

                                material.Material = "Мифриловый";

                                var result = tool + material;
                                Console.WriteLine($"Вы скрафтили предмет - {result.ToolName}");
                                Console.ReadLine();
                                Console.Clear();

                                craftTable[1, 2] = " ";
                                craftTable[1, 6] = " ";
                                craftTable[3, 2] = " ";
                                craftTable[3, 6] = " ";
                                craftTable[5, 6] = " ";
                            }
                            else if (craftTable[1, 6] == "S" &&
                                craftTable[3, 6] == "S" &&
                                craftTable[5, 6] == "W")
                            {
                                tool.Type = "меч";

                                material.Material = "Каменный";

                                var result = tool + material;
                                Console.WriteLine($"Вы скрафтили предмет - {result.ToolName}");
                                Console.ReadLine();
                                Console.Clear();

                                craftTable[1, 6] = " ";
                                craftTable[3, 6] = " ";
                                craftTable[5, 6] = " ";
                            }
                            else if (craftTable[1, 6] == "I" &&
                                craftTable[3, 6] == "I" &&
                                craftTable[5, 6] == "W")
                            {
                                tool.Type = "меч";

                                material.Material = "Железный";

                                var result = tool + material;
                                Console.WriteLine($"Вы скрафтили предмет - {result.ToolName}");
                                Console.ReadLine();
                                Console.Clear();

                                craftTable[1, 6] = " ";
                                craftTable[3, 6] = " ";
                                craftTable[5, 6] = " ";
                            }
                            else if (craftTable[1, 6] == "G" &&
                                craftTable[3, 6] == "G" &&
                                craftTable[5, 6] == "W")
                            {
                                tool.Type = "меч";

                                material.Material = "Золотой";

                                var result = tool + material;
                                Console.WriteLine($"Вы скрафтили предмет - {result.ToolName}");
                                Console.ReadLine();
                                Console.Clear();

                                craftTable[1, 6] = " ";
                                craftTable[3, 6] = " ";
                                craftTable[5, 6] = " ";
                            }
                            else if (craftTable[1, 6] == "M" &&
                                craftTable[3, 6] == "W" &&
                                craftTable[5, 6] == "W")
                            {
                                tool.Type = "меч";

                                material.Material = "Мифриловый";

                                var result = tool + material;
                                Console.WriteLine($"Вы скрафтили предмет - {result.ToolName}");
                                Console.ReadLine();
                                Console.Clear();

                                craftTable[1, 6] = " ";
                                craftTable[3, 6] = " ";
                                craftTable[5, 6] = " ";
                            }
                            else if (craftTable[1, 6] == "S" &&
                                craftTable[3, 6] == "W" &&
                                craftTable[5, 6] == "W")
                            {
                                tool.Type = "лопата";

                                material.Material = "Каменная";

                                var result = tool + material;
                                Console.WriteLine($"Вы скрафтили предмет - {result.ToolName}");
                                Console.ReadLine();
                                Console.Clear();

                                craftTable[1, 6] = " ";
                                craftTable[3, 6] = " ";
                                craftTable[5, 6] = " ";
                            }
                            else if (craftTable[1, 6] == "I" &&
                                craftTable[3, 6] == "I" &&
                                craftTable[5, 6] == "W")
                            {
                                tool.Type = "меч";

                                material.Material = "Железный";

                                var result = tool + material;
                                Console.WriteLine($"Вы скрафтили предмет - {result.ToolName}");
                                Console.ReadLine();
                                Console.Clear();

                                craftTable[1, 6] = " ";
                                craftTable[3, 6] = " ";
                                craftTable[5, 6] = " ";
                            }
                            else if (craftTable[1, 6] == "G" &&
                                craftTable[3, 6] == "G" &&
                                craftTable[5, 6] == "W")
                            {
                                tool.Type = "меч";

                                material.Material = "Золотой";

                                var result = tool + material;
                                Console.WriteLine($"Вы скрафтили предмет - {result.ToolName}");
                                Console.ReadLine();
                                Console.Clear();

                                craftTable[1, 6] = " ";
                                craftTable[3, 6] = " ";
                                craftTable[5, 6] = " ";
                            }
                            else if (craftTable[1, 6] == "M" &&
                                craftTable[3, 6] == "M" &&
                                craftTable[5, 6] == "W")
                            {
                                tool.Type = "меч";

                                material.Material = "Мифриловый";

                                var result = tool + material;
                                Console.WriteLine($"Вы скрафтили предмет - {result.ToolName}");
                                Console.ReadLine();
                                Console.Clear();

                                craftTable[1, 6] = " ";
                                craftTable[3, 6] = " ";
                                craftTable[5, 6] = " ";
                            }
                            else if (craftTable[1, 2] == "S" &&
                                craftTable[1, 6] == "S" &&
                                craftTable[3, 6] == "W" &&
                                craftTable[5, 6] == "W")
                            {
                                tool.Type = "мотыга";

                                material.Material = "Каменная";

                                var result = tool + material;
                                Console.WriteLine($"Вы скрафтили предмет - {result.ToolName}");
                                Console.ReadLine();
                                Console.Clear();

                                craftTable[1, 2] = " ";
                                craftTable[1, 6] = " ";
                                craftTable[3, 6] = " ";
                                craftTable[5, 6] = " ";
                            }
                            else if (craftTable[1, 2] == "I" &&
                                craftTable[1, 6] == "I" &&
                                craftTable[3, 6] == "W" &&
                                craftTable[5, 6] == "W")
                            {
                                tool.Type = "мотыга";

                                material.Material = "Железная";

                                var result = tool + material;
                                Console.WriteLine($"Вы скрафтили предмет - {result.ToolName}");
                                Console.ReadLine();
                                Console.Clear();

                                craftTable[1, 2] = " ";
                                craftTable[1, 6] = " ";
                                craftTable[3, 6] = " ";
                                craftTable[5, 6] = " ";
                            }
                            else if (craftTable[1, 2] == "G" &&
                                craftTable[1, 6] == "G" &&
                                craftTable[3, 6] == "W" &&
                                craftTable[5, 6] == "W")
                            {
                                tool.Type = "мотыга";

                                material.Material = "Золотая";

                                var result = tool + material;
                                Console.WriteLine($"Вы скрафтили предмет - {result.ToolName}");
                                Console.ReadLine();
                                Console.Clear();

                                craftTable[1, 2] = " ";
                                craftTable[1, 6] = " ";
                                craftTable[3, 6] = " ";
                                craftTable[5, 6] = " ";
                            }
                            else if (craftTable[1, 2] == "M" &&
                                craftTable[1, 6] == "M" &&
                                craftTable[3, 6] == "W" &&
                                craftTable[5, 6] == "W")
                            {
                                tool.Type = "мотыга";

                                material.Material = "Мифриловая";

                                var result = tool + material;
                                Console.WriteLine($"Вы скрафтили предмет - {result.ToolName}");
                                Console.ReadLine();
                                Console.Clear();

                                craftTable[1, 2] = " ";
                                craftTable[1, 6] = " ";
                                craftTable[3, 6] = " ";
                                craftTable[5, 6] = " ";
                            }
                            else if (craftTable[1, 6] == "S" &&
                                craftTable[3, 6] == "W" &&
                                craftTable[5, 6] == "W")
                            {
                                tool.Type = "лопата";

                                material.Material = "Каменная";

                                var result = tool + material;
                                Console.WriteLine($"Вы скрафтили предмет - {result.ToolName}");
                                Console.ReadLine();
                                Console.Clear();

                                craftTable[1, 6] = " ";
                                craftTable[3, 6] = " ";
                                craftTable[5, 6] = " ";
                            }
                            else if (craftTable[1, 6] == "I" &&
                                craftTable[3, 6] == "W" &&
                                craftTable[5, 6] == "W")
                            {
                                tool.Type = "лопата";

                                material.Material = "Железная";

                                var result = tool + material;
                                Console.WriteLine($"Вы скрафтили предмет - {result.ToolName}");
                                Console.ReadLine();
                                Console.Clear();

                                craftTable[1, 6] = " ";
                                craftTable[3, 6] = " ";
                                craftTable[5, 6] = " ";
                            }
                            else if (craftTable[1, 6] == "G" &&
                                craftTable[3, 6] == "W" &&
                                craftTable[5, 6] == "W")
                            {
                                tool.Type = "лопата";

                                material.Material = "Золотая";

                                var result = tool + material;
                                Console.WriteLine($"Вы скрафтили предмет - {result.ToolName}");
                                Console.ReadLine();
                                Console.Clear();

                                craftTable[1, 6] = " ";
                                craftTable[3, 6] = " ";
                                craftTable[5, 6] = " ";
                            }
                            else if (craftTable[1, 6] == "M" &&
                                craftTable[3, 6] == "W" &&
                                craftTable[5, 6] == "W")
                            {
                                tool.Type = "лопата";

                                material.Material = "Мифриловая";

                                var result = tool + material;
                                Console.WriteLine($"Вы скрафтили предмет - {result.ToolName}");
                                Console.ReadLine();
                                Console.Clear();

                                craftTable[1, 6] = " ";
                                craftTable[3, 6] = " ";
                                craftTable[5, 6] = " ";
                            }
                            else
                            {
                                Console.WriteLine("Неправильный рецепт");
                                Console.ReadLine();
                                Console.Clear();

                                craftTable[1, 2] = " ";
                                craftTable[1, 6] = " ";
                                craftTable[1, 10] = " ";
                                craftTable[3, 2] = " ";
                                craftTable[3, 6] = " ";
                                craftTable[3, 10] = " ";
                                craftTable[5, 2] = " ";
                                craftTable[5, 6] = " ";
                                craftTable[5, 10] = " ";
                            }
                        }
                        else if (key == ConsoleKey.Escape)
                        {
                            //return;
                            Environment.Exit(0);
                        }

                        if (key == ConsoleKey.W)
                        {
                            craftTable[lineY, lineX] = "W";
                        }
                        else if (key == ConsoleKey.S)
                        {
                            craftTable[lineY, lineX] = "S";
                        }
                        else if (key == ConsoleKey.I)
                        {
                            craftTable[lineY, lineX] = "I";
                        }
                        else if (key == ConsoleKey.G)
                        {
                            craftTable[lineY, lineX] = "G";
                        }
                        else if (key == ConsoleKey.M)
                        {
                            craftTable[lineY, lineX] = "M";
                        }
                        else if (key == ConsoleKey.Spacebar)
                        {
                            craftTable[lineY, lineX] = " ";
                        }
                    }
                }
            }
        }
    }
}
