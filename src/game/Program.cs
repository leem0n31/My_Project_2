using System;

class Program
{
    static void Main()
    {
        string playerName;
        bool hasKey = false;
        bool hasPicklock = false;
        bool foundArtifact1 = false;
        bool foundArtifact2 = false;
        bool foundArtifact3 = false;

        Console.WriteLine("Введите имя вашего персонажа:");
        playerName = Console.ReadLine();

        while (true)
        {
            Console.WriteLine($"n{playerName}, вы просыпаетесь в комнате. Что вы хотите сделать?");
            Console.WriteLine("1. Открыть дверь");
            Console.WriteLine("2. Заглянуть под кровать");
            Console.WriteLine("3. Открыть ящик в углу комнаты");
            Console.WriteLine("4. Открыть вентиляцию");
            Console.WriteLine("5. Взглянуть на тумбочку");
            Console.WriteLine("6. Взглянуть на статую рядом с дверью");
            Console.WriteLine("0. Выйти из игры");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    if (hasPicklock)
                    {
                        Console.WriteLine($"{playerName}, вы успешно открыли дверь и сбежали!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"{playerName}, вам нужна отмычка, чтобы открыть дверь.");
                    }
                    break;

                case "2":
                    if (!foundArtifact1)
                    {
                        Console.WriteLine($"{playerName}, вы нашли первый артефакт под кроватью!");
                        foundArtifact1 = true;
                    }
                    else
                    {
                        Console.WriteLine($"{playerName}, под кроватью больше ничего нет.");
                    }
                    break;

                case "3":
                    if (hasKey)
                    {
                        Console.WriteLine($"{playerName}, вы открыли ящик и нашли отмычку от двери!");
                        hasPicklock = true;
                    }
                    else
                    {
                        Console.WriteLine($"{playerName}, вам нужен ключ от ящика.");
                    }
                    break;

                case "4":
                    if (!foundArtifact2)
                    {
                        Console.WriteLine($"{playerName}, вы открываете вентиляцию...");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine($"Попытка {i + 1}...");
                        }
                        Console.WriteLine($"{playerName}, вы нашли второй артефакт в вентиляции!");
                        foundArtifact2 = true;
                    }
                    else
                    {
                        Console.WriteLine($"{playerName}, в вентиляции больше ничего нет.");
                    }
                    break;

                case "5":
                    if (!foundArtifact3)
                    {
                        Console.WriteLine($"{playerName}, вы нашли третий артефакт на тумбочке!");
                        foundArtifact3 = true;
                    }
                    else
                    {
                        Console.WriteLine($"{playerName}, на тумбочке больше ничего нет.");
                    }
                    break;

                case "6":
                    if (foundArtifact1 && foundArtifact2 && foundArtifact3 && !hasKey)
                    {
                        Console.WriteLine($"{playerName}, вы активировали статую и получили ключ от ящика!");
                        hasKey = true;
                    }
                    else if (hasKey)
                    {
                        Console.WriteLine($"{playerName}, у вас уже есть ключ от ящика.");
                    }
                    else
                    {
                        Console.WriteLine($"{playerName}, вам нужно найти все три артефакта, чтобы активировать статую.");
                    }
                    break;
                case "0":
                    Console.WriteLine("Спасибо за игру!");
                    return;
                default:
                    Console.WriteLine("Неверный выбор, попробуйте снова.");
                    break;
            }
        }
    }
}
