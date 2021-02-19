using System;

namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            int Mil = 18;
            int Mi = 0;
            int Bm = 0;
            int Qui = 19;
            int Qu = 0;
            int Bq = 0;
            int Doc = 23;
            int Do = 0;
            int BD = 0;
            int Cie = 50;
            int Ci = 0;
            int Bc = 0;
            int Monto = 0;
            int Banco = 0;
            int N = 0;
            int TDP = 37100;

            Console.WriteLine("Bienvenido al cajero, especifique su banco, ");
            Console.WriteLine("Menu ");
            Console.WriteLine("1)FDP INVERSMENTS ");
            Console.WriteLine("2)Otro banco ");
            Banco = Convert.ToInt32(Console.ReadLine());

            switch (Banco) {
                case 1:
                    do { 
                        Console.WriteLine("Puede retirar un monto maximo de 20,000 pesos ");
                    Console.WriteLine("Digite su monto ");
                    Monto = Convert.ToInt32(Console.ReadLine());
                        if (Monto % 100 == 0)
                        {
                            if ((TDP >= 100) && (TDP >= Monto))
                            {
                                if (Monto <= 20000)
                                {
                                    while ((Monto >= 1000) && (Bm < 18))
                                    {
                                        bool pr = ((Monto > 1000) && (Bm < 18));
                                        Monto = Monto - 1000;
                                        Bm++;
                                        Mi++;
                                    }
                                    while ((Monto >= 500) && (Bq < 19))
                                    {
                                        Monto = Monto - 500;
                                        Bq++;
                                        Qu++;
                                    }
                                    while ((Monto >= 200) && (BD < 23))
                                    {
                                        Monto = Monto - 200;
                                        BD++;
                                        Do++;

                                    }
                                    while ((Monto >= 100) && (Bc < 50))
                                    {
                                        Monto = Monto - 100;
                                        Bc++;
                                        Ci++;

                                    }
                                    Console.WriteLine("Usted va a recibir los siguientes billetes {0} de mil, {1} de Quinientos, {2} de Doscientos y {3} de Cien ", Mi, Qu, Do, Ci);
                                    Console.WriteLine("Digite 1 para realizar otra transaccion, digite 2 para salir");
                                    N = Convert.ToInt32(Console.ReadLine());
                                    if (Mil >= Mi)
                                    {
                                        Mil -= Mi;
                                    }
                                    if (Qui >= Qu)
                                    {

                                        Qui -= Qu;
                                    }
                                    if (Doc >= Do)
                                    {
                                        Doc -= Do;
                                    }
                                    if (Cie >= Ci)
                                    {
                                        Cie -= Ci;
                                    }
                                    int TMI = Mi * 1000;
                                    int TQU = Qu * 500;
                                    int TDO = Do * 200;
                                    int TCI = Ci * 100;
                                    int TDR = TMI + TQU + TDO + TCI;
                                    TDP -= TDR;
                                    Mi = 0;
                                    Qu = 0;
                                    Do = 0;
                                    Ci = 0;
                                    Console.WriteLine("Quedan {0} de Mil, {1} de Quinientos, {2} de Doscientos, {3} de Cien", Mil, Qui, Doc, Cie);
                                }
                                else
                                {
                                    Console.WriteLine("El monto digitado es mayor a la cantidad aceptada por transaccion");
                                    Console.WriteLine("Digite 1 para realizar otra transaccion, digite 2 para salir");
                                    N = Convert.ToInt32(Console.ReadLine());
                                }
                            }
                            else
                            {
                                if (TDP >= 100)
                                {
                                    Console.WriteLine("El cajero no tiene suficiente dinero");
                                    Console.WriteLine("Digite 1 para realizar otra transaccion, digite 2 para salir");
                                    N = Convert.ToInt32(Console.ReadLine());
                                }
                                else
                                {
                                    Console.WriteLine("El cajero no tiene dinero");
                                    break;
                                }

                            }
                        }
                        else {
                            Console.WriteLine("Escoja un monto que sea multiplo de 100");
                            Console.WriteLine("Digite 1 para realizar otra transaccion, digite 2 para salir");
                            N = Convert.ToInt32(Console.ReadLine());

                        }
            }while (N != 2) ;
                        break;

                    case 2:
                    do
                    {
                        Console.WriteLine("Puede retirar un monto maximo de 10,000 pesos ");
                        Console.WriteLine("Digite su monto ");
                        Monto = Convert.ToInt32(Console.ReadLine());
                        if (Monto % 100 == 0)
                        {
                            if ((TDP >= 100) && (TDP >= Monto))
                            {
                                if (Monto <= 10000)
                                {
                                    while ((Monto >= 1000) && (Bm < 18))
                                    {
                                        bool pr = ((Monto > 1000) && (Bm < 18));
                                        Monto = Monto - 1000;
                                        Bm++;
                                        Mi++;
                                    }
                                    while ((Monto >= 500) && (Bq < 19))
                                    {
                                        Monto = Monto - 500;
                                        Bq++;
                                        Qu++;
                                    }
                                    while ((Monto >= 200) && (BD < 23))
                                    {
                                        Monto = Monto - 200;
                                        BD++;
                                        Do++;

                                    }
                                    while ((Monto >= 100) && (Bc < 50))
                                    {
                                        Monto = Monto - 100;
                                        Bc++;
                                        Ci++;

                                    }
                                    Console.WriteLine("Usted va a recibir los siguientes billetes {0} de mil, {1} de Quinientos, {2} de Doscientos y {3} de Cien ", Mi, Qu, Do, Ci);
                                    Console.WriteLine("Digite 1 para realizar otra transaccion, digite 2 para salir");
                                    N = Convert.ToInt32(Console.ReadLine());
                                    if (Mil >= Mi)
                                    {
                                        Mil -= Mi;
                                    }
                                    if (Qui >= Qu)
                                    {

                                        Qui -= Qu;
                                    }
                                    if (Doc >= Do)
                                    {
                                        Doc -= Do;
                                    }
                                    if (Cie >= Ci)
                                    {
                                        Cie -= Ci;
                                    }
                                    int TMI = Mi * 1000;
                                    int TQU = Qu * 500;
                                    int TDO = Do * 200;
                                    int TCI = Ci * 100;
                                    int TDR = TMI + TQU + TDO + TCI;
                                    TDP -= TDR;
                                    Mi = 0;
                                    Qu = 0;
                                    Do = 0;
                                    Ci = 0;
                                    Console.WriteLine("Quedan {0} de Mil, {1} de Quinientos, {2} de Doscientos, {3} de Cien", Mil, Qui, Doc, Cie);
                                }
                                else
                                {
                                    Console.WriteLine("El monto digitado es mayor a la cantidad aceptada por transaccion");
                                    Console.WriteLine("Digite 1 para realizar otra transaccion, digite 2 para salir");
                                    N = Convert.ToInt32(Console.ReadLine());
                                }
                            }
                            else
                            {
                                if (TDP >= 100)
                                {
                                    Console.WriteLine("El cajero no tiene suficiente dinero");
                                    Console.WriteLine("Digite 1 para realizar otra transaccion, digite 2 para salir");
                                    N = Convert.ToInt32(Console.ReadLine());
                                }
                                else
                                {
                                    Console.WriteLine("El cajero no tiene dinero");
                                    break;
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("Escoja un monto que sea multiplo de 100");
                            Console.WriteLine("Digite 1 para realizar otra transaccion, digite 2 para salir");
                            N = Convert.ToInt32(Console.ReadLine());

                        }
                    } while (N != 2);
                    break;

             



                }
 







        }
    }
}
