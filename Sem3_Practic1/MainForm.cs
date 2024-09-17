using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Practic1
{
    internal class MainForm
    {
        public static void Draw(FileDescriptor fd)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            //1 Строка
            int pathLength = (17 - fd.path.Length / 2) >=0 ? (17 - fd.path.Length / 2) : 0;
            Console.Write("╔═");
            if (pathLength >= 12)
            {
                Console.Write(
                    String.Concat(Enumerable.Repeat("═", 11)) + "╤" +
                    String.Concat(Enumerable.Repeat("═", pathLength - 12))
                    );
                Console.Write(" " + fd.path + " ");
                if (fd.path.Length % 2 != 0)
                {
                    Console.Write(String.Concat(Enumerable.Repeat("═", pathLength - 12 - 1)));
                }
                else
                {
                    Console.Write(String.Concat(Enumerable.Repeat("═", pathLength - 12)));
                }
                Console.Write("╤" + String.Concat(Enumerable.Repeat("═", 11)));
            }
            else
            {
                Console.Write(String.Concat(Enumerable.Repeat("═", pathLength)) + " ");
                if(fd.path.Length > 33)
                {
                    Console.Write(fd.path.Substring(0, 33) + "~");
                }
                else
                {
                    Console.Write(fd.path);
                }
                Console.Write(" " + String.Concat(Enumerable.Repeat("═", pathLength)));
            }
            Console.Write("═╗\n");

            //2 строка
            Console.Write("║");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(fd.path.Substring(0, 2) + "  Name    ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("│");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("    Name    ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("│");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("    Name    ");



            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("║\n");

            //3 - (n-1) строка
            int x = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.Write("║");
                for (int j = 0; j < 3; j++)
                {
                    x = i * 3 + j;
                    if (x < fd.files.Count)
                    {
                        int len = fd.files[x].name.Length + fd.files[x].type.Length;
                        if (len < 12)
                        {
                            Console.Write(fd.files[x].name + String.Concat(Enumerable.Repeat(" ", 12 - len)));
                        }
                        else
                        {
                            if (fd.files[x].type != "folder" && fd.files[x].type != "file")
                                Console.Write(fd.files[x].name.Substring(0, 12 - fd.files[x].type.Length - 2));
                            else
                                Console.Write(fd.files[x].name.Substring(0, 10));
                            Console.Write("~ ");
                        }
                        if (fd.files[x].type != "folder" && fd.files[x].type != "file")
                        {
                            Console.Write(fd.files[x].type);
                        }
                    }
                   
                    else
                    {
                        Console.Write(String.Concat(Enumerable.Repeat(" ", 12)));
                    }
                    if (j != 2)
                        Console.Write("│");

                }
                Console.Write("║\n");
            }

            //n строка
            Console.WriteLine("╟────────────┴────────────┴────────────╢");
            Console.WriteLine(
                "║..             Каталог " + DateTime.Now.Day.ToString() + "." + 
                (DateTime.Now.Month >= 10 ? DateTime.Now.Month.ToString() : "0" + DateTime.Now.Month.ToString()) + 
                "." + DateTime.Now.Year.ToString().Substring(2) + "  " + DateTime.Now.Hour.ToString() + ":" + 
                DateTime.Now.Minute.ToString() +  "║");
            Console.WriteLine("╚══════════════════════════════════════╝");

            Console.ResetColor();

        }
    }
}
