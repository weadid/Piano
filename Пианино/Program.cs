using System;
using System.Net.Http.Headers;

namespace Пианино
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Клавиша A - до");
                Console.WriteLine("Клавиша W - до#");
                Console.WriteLine("Клавиша S - ре");
                Console.WriteLine("Клавиша E - ре#");
                Console.WriteLine("Клавиша D - ми");
                Console.WriteLine("Клавиша F - фа");
                Console.WriteLine("Клавиша T - фа#");
                Console.WriteLine("Клавиша G - соль");
                Console.WriteLine("Клавиша Y - соль#");
                Console.WriteLine("Клавиша H - ля");
                Console.WriteLine("Клавиша U - ля#");
                Console.WriteLine("Клавиша J - си");
                Console.WriteLine("Клавиша Escape - выбрать другую октаву");
                Console.WriteLine("Выберите октаву: ");
                ConsoleKeyInfo octave = Console.ReadKey();
                Console.WriteLine(octave.Key);

                if (octave.Key == ConsoleKey.F4)
                {
                    Console.WriteLine("Октава 4");
                    int[] fourOctave = new int[] { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
                    Notes(fourOctave);
                    
                }
                else if (octave.Key == ConsoleKey.F5)
                {
                    Console.WriteLine("Октава 5");
                    int[] faiveOctave = new int[] { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 };
                    Notes(faiveOctave);
                    
                }
                else if (octave.Key == ConsoleKey.F6)
                {
                    Console.WriteLine("Октава 6");
                    int[] sixOctave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
                    Notes(sixOctave);
                }
                else if (octave.Key == ConsoleKey.F7)
                {
                    Console.WriteLine("Октава 7");
                    int[] sevenOctave = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
                    Notes(sevenOctave);
                }
                else if (octave.Key == ConsoleKey.F8)
                {
                    Console.WriteLine("Октава 8");
                    int[] eightOctave = new int[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
                    Notes(eightOctave);
                }
               
            }

        }
       
        static void Notes(int[] freqs)
        {
            while (true)
            {
                ConsoleKeyInfo clavisha = Console.ReadKey();
                Console.WriteLine(clavisha.Key);
                Console.Clear();
                if (clavisha.Key == ConsoleKey.A)
                {
                    Console.Beep(freqs[0], 500);
                    Console.Clear();
                }
                else if (clavisha.Key == ConsoleKey.W)
                {
                    Console.Beep(freqs[1], 500);
                    Console.Clear();
                }
                else if (clavisha.Key == ConsoleKey.S)
                {
                    Console.Beep(freqs[2], 500);
                    Console.Clear();
                }
                else if (clavisha.Key == ConsoleKey.E)
                {
                    Console.Beep(freqs[3], 500);
                    Console.Clear();
                }
                else if (clavisha.Key == ConsoleKey.D)
                {
                    Console.Beep(freqs[4], 500);
                    Console.Clear();
                }
                else if (clavisha.Key == ConsoleKey.F)
                {
                    Console.Beep(freqs[5], 500);
                    Console.Clear();
                }
                else if (clavisha.Key == ConsoleKey.T)
                {
                    Console.Beep(freqs[6], 500);
                    Console.Clear();
                }
                else if (clavisha.Key == ConsoleKey.G)
                {
                    Console.Beep(freqs[7], 500);
                    Console.Clear();
                }
                else if (clavisha.Key == ConsoleKey.Y)
                {
                    Console.Beep(freqs[8], 500);
                    Console.Clear();
                }
                else if (clavisha.Key == ConsoleKey.H)
                {
                    Console.Beep(freqs[9], 500);
                    Console.Clear();
                }
                else if (clavisha.Key == ConsoleKey.U)
                {
                    Console.Beep(freqs[10], 500);
                    Console.Clear();
                }
                else if (clavisha.Key == ConsoleKey.J)
                {
                    Console.Beep(freqs[11], 500);
                    Console.Clear();
                }
                else if (clavisha.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }

    }
}