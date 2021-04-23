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
                                        Console.WriteLine("WPISZ DO AX REJESTRU WARTOSC ");
                                        ax =zmiana(ax);
                                        

                                        break;


                                    }

                                case 2:
                                    {
                                        Console.WriteLine("WPISZ DO BX REJESTRU WARTOSC ");
                                        bx =zmiana(bx);
                                        break;


                                    }

                                case 3:
                                    {
                                        Console.WriteLine("WPISZ DO CX REJESTRU WARTOSC ");
                                        cx =zmiana(cx);
                                        break;


                                    }

                                case 4:
                                    {
                                        Console.WriteLine("WPISZ DO DX REJESTRU WARTOSC ");
                                        dx =zmiana(dx);
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
            Console.WriteLine("WPISZ -CYFRE- Z PONIŻSZYCH I KLIKNIJ ENTER");
            Console.WriteLine();
            Console.WriteLine(" 01 MOV AX AX|| 11 MOV BX AX|| 21 MOV CX AX|| 31 MOV DX AX");
            Console.WriteLine(" 02 MOV AX BX|| 12 MOV BX BX|| 22 MOV CX BX|| 32 MOV DX BX");
            Console.WriteLine(" 03 MOV AX CX|| 13 MOV BX CX|| 23 MOV CX CX|| 33 MOV DX CX");
            Console.WriteLine(" 04 MOV AX DX|| 14 MOV BX DX|| 24 MOV CX DX|| 35 MOV DX DX");
            Console.WriteLine();
            Console.WriteLine(" 001 XCHG AX AX|| 101 XCHG BX AX|| 201 XCHG CX AX|| 301 XCHG DX AX");
            Console.WriteLine(" 002 XCHG AX BX|| 102 XCHG BX BX|| 202 XCHG CX BX|| 302 XCHG DX AB");
            Console.WriteLine(" 003 XCHG AX CX|| 103 XCHG BX CX|| 203 XCHG CX CX|| 303 XCHG DX AC");
            Console.WriteLine(" 004 XCHG AX DX|| 104 XCHG BX DX|| 204 XCHG CX DX|| 304 XCHG DX DX");
            Console.WriteLine();

        }
        static string zmiana(string x) 
        {
            string stare = x;
            int a = 0;
            string nowe =   x;
           
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
