using System;

public struct Color
{
    public byte R { get; set; }
    public byte G { get; set; }
    public byte B { get; set; }

    // Конструктор
    public Color(byte r, byte g, byte b)
    {
        // Проверка значений (0-255)
        if (r < 0 || r > 255 || g < 0 || g > 255 || b < 0 || b > 255)
        {
            throw new ArgumentOutOfRangeException("Цветовые компоненты должны быть в диапазоне от 0 до 255.");
        }
        R = r;
        G = g;
        B = b;
    }

    // Переопределение ToString()
    public override string ToString()
    {
        return $"RGB({R}, {G}, {B})";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Пример вывода из задания
        var c1 = new Color(255, 128, 0);
        var c2 = c1; // Присваивание struct приводит к копированию значений
        c2.R = 100; // Изменяем только копию

        Console.WriteLine($"c1: {c1}"); // Ожидаем: RGB(255, 128, 0)
        Console.WriteLine($"c2: {c2}"); // Ожидаем: RGB(100, 128, 0)

        // Демонстрация того, что оригинал не изменился
        Console.WriteLine("\nДемонстрация того, что оригинал не изменился:");
        Console.WriteLine($"Оригинальный c1: {c1}");
        Console.WriteLine($"Измененный c2: {c2}");
    }
}

