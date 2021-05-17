using System;

namespace ConsoleApp1
{
    class Program
    {
       static string ax = "0000";
       static string bx = "0000";
       static string cx = "0000";
       static string dx = "0000";
       static string AX
        {
            get => ax;

            set
            {
                ax = value;
            }
        }
        static string BX
        {
            get => bx;

            set
            {
                bx = value;
            }
        }
       static string CX
        {
            get => cx;

            set
            {
                cx = value;
            }
        }
       static string DX
        { get=>dx;

          set
            { 
                 dx = value;
            }
        }


        static void Main()
        {

            
            Random rnd = new Random();
            
            while (true)
            {
                operacja();
               
                    
                    int op = int.Parse(Console.ReadLine());
                
                Console.WriteLine();
                switch (op) 
                {
                    case 1: 
                        {
                            Console.WriteLine($"AX:{Program.AX}");
                            Console.WriteLine($"BX:{Program.BX}");
                            Console.WriteLine($"CX:{Program.CX}");
                            Console.WriteLine($"DX:{Program.DX}");
                            Console.WriteLine();
                            Console.WriteLine();
                            break;
                        }
                    case 3:
                        {
                            jaka(Program.AX, Program.BX, Program.CX, Program.DX);
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
                                        Program.AX = zmiana(Program.AX);
                                        

                                        break;


                                    }

                                case 2:
                                    {
                                        Console.WriteLine("WPISZ DO BX REJESTRU WARTOSC ");
                                        Program.BX = zmiana(Program.BX);
                                        break;


                                    }

                                case 3:
                                    {
                                        Console.WriteLine("WPISZ DO CX REJESTRU WARTOSC ");
                                        Program.CX = zmiana(Program.CX);
                                        break;


                                    }

                                case 4:
                                    {
                                        Console.WriteLine("WPISZ DO DX REJESTRU WARTOSC ");
                                        Program.DX = zmiana(Program.DX);
                                        break;


                                    }
                                case 5:
                                    {
                                        Program.AX = String.Format("{0:X}", (rnd.Next(0, 65536)));
                                        Program.BX = String.Format("{0:X}", (rnd.Next(0, 65536)));
                                        Program.CX = String.Format("{0:X}", (rnd.Next(0, 65536)));
                                        Program.DX = String.Format("{0:X}", (rnd.Next(0, 65536)));
                                        Console.WriteLine("WARTOSCI ZOSTALY PODANE METODZIE RANDOM");

                                        break;
                                    }
                                case 6:
                                    {
                                        Program.AX = "0000";
                                        Program.BX = "0000";
                                        Program.CX = "0000";
                                        Program.DX = "0000";
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
                MOV(ax, bx, cx, dx);

            }
            if (choice == 2) 
            {
                jakiXCHG(ax, bx, cx, dx);
            }
         
            Console.WriteLine();

        }

        static void MOV(string ax, string bx, string cx, string dx) 
        {
            
            string druga="";
            Console.WriteLine("JAKA OPERACJE MOV CHCESZ WYKONAC? PRZYKLAD DLA    MOV BX,AX -(1 ENTER 2)    ");
            Console.WriteLine("1-AX 2-BX 3-CX 4-DX");
           int pierwsze= int.Parse(Console.ReadLine());
           int drugie = int.Parse(Console.ReadLine());
          
            switch (drugie)
            {
                case 1: { druga = ax ;break; }
                case 2: { druga = bx ;break; }
                case 3: { druga = cx ;break; }
                case 4: { druga = dx ;break; }

            }
            switch (pierwsze)
            {
                case 1: {
                        Program.AX =druga ;
                       ; break; }
                case 2: {
                        Program.BX = druga;
                        ; break; }
                case 3: {
                        Program.CX = druga;
                        ; break; }
                case 4: {
                        Program.DX = druga;
                        ; break; }

            }


        }

        static void jakiXCHG(string ax, string bx, string cx, string dx) 
        {
            Console.WriteLine("test");
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
