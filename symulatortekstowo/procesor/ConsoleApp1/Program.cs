using System;

namespace ConsoleApp1
{
    class Program
    {
      


        static void Main()
        {

            
            Random rnd = new Random();
            string ax = "0000";
            string bx = "0000";
            string cx = "0000";
            string dx = "0000";
            while (true)
            {
                operacja();
               
                    int toBase = 16;
                    int op = int.Parse(Console.ReadLine());
                
                Console.WriteLine();
                switch (op) 
                {
                    case 1: 
                        {
                            Console.WriteLine($"AX:{ax}");
                            Console.WriteLine($"BX:{bx}");
                            Console.WriteLine($"CX:{cx}");
                            Console.WriteLine($"DX:{dx}");
                            Console.WriteLine();
                            Console.WriteLine();
                            break;
                        }
                    case 3:
                        {
                            jaka();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("KTORY REJESTR WPISZ");
                            Console.WriteLine(" 1 -ABY ZMIENIC AX");
                            Console.WriteLine(" 2 -ABY ZMIENIC BX");
                            Console.WriteLine(" 3 -ABY ZMIENIC CX");
                            Console.WriteLine(" 4 -ABY ZMIENIC DX");
                            Console.WriteLine(" 5 -RANDOM");
                            Console.WriteLine(" 6- RESET");
                            int ktore = int.Parse(Console.ReadLine());

                            
                            switch (ktore)
                            {
                                case 1:
                                    {
                                        ax=zmianaAX(ax);
                                        

                                        break;


                                    }

                                case 2:
                                    {
                                        bx=zmianaBX(bx);
                                        break;


                                    }

                                case 3:
                                    {
                                        cx=zmianaCX(cx);
                                        break;


                                    }

                                case 4:
                                    {
                                        dx=zmianaDX(dx);
                                            break;


                                    }
                                case 5:
                                    {
                                        ax = String.Format("{0:X}",(rnd.Next(0, 65536)));
                                        bx = String.Format("{0:X}", (rnd.Next(0, 65536)));
                                        cx = String.Format("{0:X}", (rnd.Next(0, 65536)));
                                        dx = String.Format("{0:X}", (rnd.Next(0, 65536)));
                                        Console.WriteLine("WARTOSCI ZOSTALY PODANE METODZIE RANDOM");

                                        break;
                                    }
                                case 6:
                                    {
                                        ax = "0000";
                                        bx = "0000";
                                        cx = "0000";
                                        dx = "0000";
                                        Console.WriteLine( "WARTOSCI SĄ ZRESETOWANE");

                                        break;
                                    }


                            }
                            break;
                        }
                    case 4:
                        {

                            return;
                            
                        }
                   
                }

            }



        }
        
        static void operacja() 
        {
            Console.WriteLine("WITAJ WPISZ:");
            Console.WriteLine(" 1 - BY POKAZAĆ REJESTRY");
            Console.WriteLine(" 2 - BY ZMIENIC REJESTRY");
            Console.WriteLine(" 3 - BY DOKONAĆ OPERACJI NA REJESTRACH");
            Console.WriteLine(" 4 - BY WYJŚĆ");
            
        }
        static void jaka() 
        {
            Console.WriteLine("JAKĄ OPERACJĘ CHCESZ WYKONAC?");
            Console.WriteLine("WPISZ JEDNO Z PONIŻSZYCH I KLIKNIJ ENTER");
            Console.WriteLine();
            Console.WriteLine("MOV AX AX||MOV BX AX||MOV CX AX||MOV DX AX");
            Console.WriteLine("MOV AX BX||MOV BX BX||MOV CX BX||MOV DX BX");
            Console.WriteLine("MOV AX CX||MOV BX CX||MOV CX CX||MOV DX CX");
            Console.WriteLine("MOV AX DX||MOV BX DX||MOV CX DX||MOV DX DX");
            Console.WriteLine();
            Console.WriteLine("XCHG AX AX||XCHG BX AX||XCHG CX AX||XCHG DX AX");
            Console.WriteLine("XCHG AX BX||XCHG BX BX||XCHG CX BX||XCHG DX AB");
            Console.WriteLine("XCHG AX CX||XCHG BX CX||XCHG CX CX||XCHG DX AC");
            Console.WriteLine("XCHG AX DX||XCHG BX DX||XCHG CX DX||XCHG DX DX");
            Console.WriteLine();

        }
        static string zmianaAX(string ax) 
        {
            string stare = ax;
            int a = 0;
            string nowe = ax;
            Console.WriteLine("WPISZ DO AX REJESTRU WARTOSC ");
            try
            {
                nowe = (Console.ReadLine());
                a = (Convert.ToInt32(nowe, 16));

            }

            catch (ArgumentException) { Console.WriteLine("prowadz poprawne dane"); }
           
            if (a > 65536)
            { Console.WriteLine("ZA DUZA LICZBA"); return stare; }
            return nowe;

        }
        static string zmianaBX(string bx)
        {
            string stare = bx;
            int a = 0;
            string nowe = bx;
            Console.WriteLine("WPISZ DO BX REJESTRU WARTOSC ");
            try
            {
                nowe = (Console.ReadLine());
                if (nowe.Length<4)
                {
                    a = (Convert.ToInt32(nowe, 16));
                }
            }
            catch (ArgumentException) { Console.WriteLine("prowadz poprawne dane"); }

            if (a > 65536)
            { Console.WriteLine("ZA DUZA LICZBA"); return stare; }
            return nowe;



            

        }
        static string zmianaCX(string cx)
        {
            string stare = cx;
            int a = 0;
            string nowe = cx;
            Console.WriteLine("WPISZ DO CX REJESTRU WARTOSC ");
            try
            {
                nowe = (Console.ReadLine());
                a = (Convert.ToInt32(nowe, 16));

            }
            catch (ArgumentException) { Console.WriteLine("prowadz poprawne dane"); }

            if (a > 65536)
            { Console.WriteLine("ZA DUZA LICZBA"); return stare; }
            return nowe;

           

        }
        static string zmianaDX(string dx)
        {
            string stare = dx;
            int a = 0;
            string nowe = dx;
            Console.WriteLine("WPISZ DO DX REJESTRU WARTOSC ");
            try
            {
                nowe = (Console.ReadLine());
                a = (Convert.ToInt32(nowe, 16));

            }
            catch (ArgumentException) { Console.WriteLine("prowadz poprawne dane"); }

            if (a > 65536)
            { Console.WriteLine("ZA DUZA LICZBA"); return stare; }
            return nowe;

        }
        
    }
}
