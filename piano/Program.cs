namespace piano
{
    static class Programm
    {
        public static void Main()
        {
            sound();
        }
        public static void sound()
        {
            int[] C = new int[] { 65, 131, 262, 523, 1047 };
            int[] Csharp = new int[] { 69, 139, 277, 554, 1107 };
            int[] D = new int[] { 73, 147, 293, 287, 1175 };
            int[] Eb = new int[] { 77, 155, 311, 622, 1245 };
            int[] E = new int[] { 82, 164, 329, 659, 1319 };
            int[] F = new int[] { 87, 174, 349, 698, 1397 };
            int[] Fsharp = new int[] { 92, 185, 370, 740, 1480 };
            int[] G = new int[] { 98, 196, 329, 784, 1568 };
            int[] Gsharp = new int[] { 103, 207, 415, 840, 1661 };
            int[] A = new int[] { 110, 220, 440, 880, 1760 };
            int[] Bb = new int[] { 116, 233, 466, 932, 1865 };
            int[] B = new int[] { 123, 246, 494, 987, 1976 };
            
            bool end = false;
            
            do
            {
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.Q: 
                        Console.Beep(Csharp[4], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.W:
                            Console.Beep(Eb[4], 200);
                            Console.Clear();
                            break;
                    case ConsoleKey.E:
                            Console.Beep(Fsharp[4],200);
                            Console.Clear();
                            break;
                        case ConsoleKey.R:
                            Console.Beep(Gsharp[4], 200);
                            Console.Clear();
                            break;
                        case ConsoleKey.T:
                            Console.Beep(Bb[4], 200);
                            Console.Clear();
                            break;
                        case ConsoleKey.A:
                            Console.Beep(C[4], 200);
                            Console.Clear();
                            break;
                        case ConsoleKey.S:
                            Console.Beep(D[4], 200);
                            Console.Clear();
                            break;
                        case ConsoleKey.D:
                            Console.Beep(E[4], 200);
                            Console.Clear();
                            break;
                        case ConsoleKey.F:
                            Console.Beep(F[4], 200);
                            Console.Clear();
                            break;
                        case ConsoleKey.G:
                            Console.Beep(G[4], 200);
                            Console.Clear();
                            break;
                        case ConsoleKey.H:
                            Console.Beep(A[4], 200);
                            Console.Clear();
                            break;
                        case ConsoleKey.J:
                            Console.Beep(B[4], 200);
                            Console.Clear();
                            break;
                        case ConsoleKey.Escape:
                            end = true;
                            break;
                }
            } while (!end);
        }
    }
}