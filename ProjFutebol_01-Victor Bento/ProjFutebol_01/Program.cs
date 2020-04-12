using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFutebol_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int Repetir;
            do
            {
                Time time1 = new Time(" America ");
                Time time2 = new Time(" BOA ");

                Time time3 = new Time(" Atletico ");
                Time time4 = new Time(" Cruzeiro ");


                Partida p1 = new Partida(DateTime.Now, time1, time2);
                p1.jogar();
                Console.WriteLine(p1.getPalacar());

                Partida p2 = new Partida(DateTime.Now, time3, time4);
                p2.jogar();
                Console.WriteLine(p2.getPalacar());

                Partida p3 = new Partida(DateTime.Now, time1, time3);
                p3.jogar();
                Console.WriteLine(p3.getPalacar());

                Partida p4 = new Partida(DateTime.Now, time2, time4);
                p4.jogar();
                Console.WriteLine(p4.getPalacar());


                Console.WriteLine(time1.getStatus());
                Console.WriteLine(time2.getStatus());
                Console.WriteLine(time3.getStatus());
                Console.WriteLine(time4.getStatus());

                Console.Write("\n\n   > [Você quer repetir o processo?] <\n\n");
                Console.WriteLine("   [1] - SIM");
                Console.WriteLine("   [2] - NÃO");
                Repetir = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (Repetir)
                {
                    case 1:
                        Time time1a = new Time("America");
                        Time time2a = new Time("BOA");

                        Time time3a = new Time("Atletico");
                        Time time4a = new Time("Cruzeiro");



                        Partida p1a = new Partida(DateTime.Now, time1a, time2a);
                        p1a.jogar();
                        Console.WriteLine(p1a.getPalacar());

                        Partida p2a = new Partida(DateTime.Now, time3a, time4a);
                        p2a.jogar();
                        Console.WriteLine(p2a.getPalacar());

                        Partida p3a = new Partida(DateTime.Now, time1a, time3a);
                        p3a.jogar();
                        Console.WriteLine(p3a.getPalacar());

                        Partida p4a = new Partida(DateTime.Now, time2a, time4a);
                        p4a.jogar();
                        Console.WriteLine(p4a.getPalacar());


                        Console.WriteLine(time1a.getStatus());
                        Console.WriteLine(time2a.getStatus());
                        Console.WriteLine(time3a.getStatus());
                        Console.WriteLine(time4a.getStatus());
                        Console.WriteLine(" \n FINALIZADO ");
                        Console.ReadKey();
                        break;

                    case 2:

                        break;

                }
                break;
            } while (Repetir != 2);

        }
    }
}
