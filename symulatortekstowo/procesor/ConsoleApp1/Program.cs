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
                            jaka(ax, bx, cx, dx);
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
        static void jaka(string ax, string bx, string cx, string dx) 
        {
            int choice;
            Console.WriteLine("JAKĄ OPERACJĘ CHCESZ WYKONAC?");
            Console.WriteLine("WPISZ -CYFRE- Z PONIŻSZYCH I KLIKNIJ ENTER");
            Console.WriteLine();
            Console.WriteLine(" 1 MOV || 2 XCHG");
            Console.WriteLine();
            choice = int.Parse(Console.ReadLine());
            if (choice == 1) 
            {
                jakiMOV(ax, bx, cx, dx);

            }
            if (choice == 2) 
            {
                jakiXCHG(ax, bx, cx, dx);
            }
         
            Console.WriteLine();

        }
        static void jakiMOV(string ax, string bx, string cx, string dx) 
        {
            string a ="nic";
            string b ="nic";
            Console.WriteLine("JAKA OPERACJE MOV CHCESZ WYKONAC? PRZYKLAD DLA    MOV BX,AX -(1 ENTER 2)    ");
            Console.WriteLine("1-AX 2-BX 3-CX 4-DX");
           int pierwsze= int.Parse(Console.ReadLine());
           int drugie = int.Parse(Console.ReadLine());
            switch (pierwsze)
            {
                case 1: { a = ax; break; }
                case 2: { a = bx; break; }
                case 3: { a = cx; break; }
                case 4: { a = dx; break; }
             
            }
            switch (drugie)
            {
                case 1: { b = ax ;break; }
                case 2: { b = bx ;break; }
                case 3: { b = cx ;break; }
                case 4: { b = dx ;break; }

            }
            MOV(b, a);

        }
        static void jakiXCHG(string ax, string bx, string cx, string dx) 
        {
        
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
        static string MOV(string a, string b) 
        {
            a = b;

            return a;
        }
        static Tuple<string, string> XCHG(string a, string b)
        {

            string temp;
            temp = a;
            a = b;
            b = temp;

          return Tuple.Create(a, b);
        }


    }
}
