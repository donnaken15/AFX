using System;
using System.Threading;

namespace aphexconother
{
    class Program
    {
        static string[] asm = new string[11];

        static Random random = new Random();

        static float progress = 892.2057531365686f;

        static object choose(params object[] choices)
        {
            return choices[random.Next(0, choices.Length)];
        }

        static string prefix()
        {
            return (string)choose(choose("byte", "word", "dword", "fword", "pword", "qword", "tbyte", "tword", "dqword", "xword", "qqword", "yword", "dqqword", "zword")
                            + " " + choose("ptr ", ""));
        }
        
        static string reg()
        {
            return (string)(choose((string)choose("e", "r") + choose(choose('a', 'b', 'c', 'd') + "x"), "s" + choose("i", "p"), "bp", "di", choose("a","b","c","d").ToString()+choose("l","h").ToString(), choose("e","c","s","d","f","g")+"s", "cr" + choose(0, 2, 3, 4).ToString(), "dr" + choose(0, 1, 2, 3, 6, 7).ToString(), "st" + random.Next(0, 8).ToString(), choose(choose(null, "x", "y", "s") + "mm", "k") + random.Next(0, 8).ToString(), "bnd" + random.Next(0, 4).ToString(), "r" + random.Next(0, 16).ToString()));
        }

        static string val()
        {
            return (choose("$" + random.Next(0, 0x7FFFFFFF).ToString("X"), random.Next(0, 0x7FFFFFFF), random.Next(0, 255), random.Next(0, 255), random.Next(0, 2))).ToString();
        }

        static string assembly()
        {
            switch (random.Next(0, 4))
            {
                case 0:
                    return (string)choose("nop", "hlt", "ret"+choose(null,"n","f"));
                case 1:
                    return (string)choose("db " + choose("'"+(choose("APHEX TWIN", "ERROR GET (%d):',$d,$d,'%s") + "',0"), val()), (string)choose("d","r")+choose("b","w","u","d","p","f","q","t") + " " + val());
                case 2:
                    return choose("mov", "add", "sub", "cmp", "sh"+choose("l","r"), "sar", (string)choose(null, "i") + choose("mul", "div"), "mov" +choose("s", "z")+choose(null, "x")) + " " +
                        prefix() + choose(choose(choose(reg(), val()), "[" + choose(reg(), val()) + "]") + ", " + choose(val(), "[" + val() + "]"), reg() + ", " + val());
                case 3:
                    return (string)choose((string)choose(null, "i") + choose("mul", "div"), "push", "pop", "call", choose("in", "de")+"c", "lea", "j"+choose(null,"n")+choose(choose("a", "ae"), choose("b", "be"), "c", "e", choose("g", "ge"), choose("l", "le"), "o", choose("p", "pe", "po"), "s", "z", "cxz")) + " " +
                        prefix() + choose(choose(choose(reg(), val()), "[" + choose(reg(), val()) + "]"));
                case 4:
                    return (string)choose(null, "i") + choose("mul", "div") + " " +
                        prefix() + choose(choose(choose(reg(), val()), "[" + choose(reg(), val()) + "]"));
                default:
                    return null;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(
@"
  ┌───────────────────────────┐
  │                           │
  │                           │
  │                           │
  ├───────────────────────────┤
  │                           │
  │                           │
  │                           │
  │                           │
  │                           │
  │                           │
  │                           │
  │                           │
  │                           │
  │                           │
  │                           │
  ├──────────────────────┬────┤
  │                      │   %│
  └──────────────────────┴────┘");
            while (true)
            {
                progress += 0.08988888888888888f;
                //progress += 0.66666666666f;
                //progress += random.Next(-12,50)/75f;
                if (progress >= 998) progress = 0;
                Console.CursorVisible = true;
                Console.CursorLeft = 5;
                Console.CursorTop = 3;
                Console.Write("12/31/2019 11:59:" + DateTime.UtcNow.Second.ToString("00") + "." + DateTime.UtcNow.Millisecond.ToString("000"));
                Console.CursorTop = Console.WindowHeight - 3;
                if (progress < 940)
                {
                    Console.CursorLeft = 3;
                    for (int i = 0; i < 22; i++)
                        Console.Write(" ");
                    Console.CursorLeft = 3;
                    for (int i = 0; i < (progress / 45.4) + 0.75; i++)
                        Console.Write("░");
                    Console.CursorLeft = 3;
                    for (int i = 0; i < (progress / 45.4) + 0.5; i++)
                        Console.Write("▒");
                    Console.CursorLeft = 3;
                    for (int i = 0; i < (progress / 45.4) + 0.25; i++)
                        Console.Write("▓");
                }
                Console.CursorLeft = 3;
                for (int i = 0; i < progress / 45.4; i++)
                    Console.Write("█");
                Console.CursorLeft = Console.WindowWidth - 7;
                Console.Write(progress.ToString("000"));
                asm[0] = asm[1];
                asm[1] = asm[2];
                asm[2] = asm[3];
                asm[3] = asm[4];
                asm[4] = asm[5];
                asm[5] = asm[6];
                asm[6] = asm[7];
                asm[7] = asm[8];
                asm[8] = asm[9];
                asm[9] = asm[10];
                asm[10] = assembly();
                Console.SetCursorPosition(6, Console.WindowHeight - 15);
                Console.Write(string.Format("{0,-24}", asm[0]).Substring(0, 24));
                Console.SetCursorPosition(6, Console.WindowHeight - 14);
                Console.Write(string.Format("{0,-24}", asm[1]).Substring(0, 24));
                Console.SetCursorPosition(6, Console.WindowHeight - 13);
                Console.Write(string.Format("{0,-24}", asm[2]).Substring(0, 24));
                Console.SetCursorPosition(6, Console.WindowHeight - 12);
                Console.Write(string.Format("{0,-24}", asm[3]).Substring(0, 24));
                Console.SetCursorPosition(6, Console.WindowHeight - 11);
                Console.Write(string.Format("{0,-24}", asm[4]).Substring(0, 24));
                Console.SetCursorPosition(6, Console.WindowHeight - 10);
                Console.Write(string.Format("{0,-24}", asm[5]).Substring(0, 24));
                Console.SetCursorPosition(6, Console.WindowHeight - 9);
                Console.Write(string.Format("{0,-24}", asm[6]).Substring(0, 24));
                Console.SetCursorPosition(6, Console.WindowHeight - 8);
                Console.Write(string.Format("{0,-24}", asm[7]).Substring(0, 24));
                Console.SetCursorPosition(6, Console.WindowHeight - 7);
                Console.Write(string.Format("{0,-24}", asm[8]).Substring(0, 24));
                Console.SetCursorPosition(6, Console.WindowHeight - 6);
                Console.Write(string.Format("{0,-24}", asm[9]).Substring(0, 24));
                Console.SetCursorPosition(6, Console.WindowHeight - 5);
                Console.Write(string.Format("{0,-24}", asm[10]).Substring(0, 24));
                Console.CursorVisible = false;
                Thread.Sleep(new TimeSpan(100000));
            }
        }
    }
}
