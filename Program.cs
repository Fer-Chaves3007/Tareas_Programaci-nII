using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace MenuOpciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion=0;
            int[] placa = new int[14];
            int[] factura = new int[14];
            string[] fecha = new string[14];
            string[] hora = new string[14];
            int[] tipoV = new int[14];
            int[] caseta = new int[14];
            int[] monto = new int[14];
            string[] paga = new string[14];
            int[] vuelto = new int[14];
            
            do
            {
                
                Console.Clear();
                Console.WriteLine("MENU DE OPCIONES");
                Console.WriteLine("\n + " +
                    "\n 1.- Iniciar Vectores." +
                    "\n 2.- Ingresar paso vehicular." +
                    "\n 3.- Consulta de vehículos por numero de placa" + 
                    "\n 4.- Modificar datos vehiculos por numero de placa" +
                    "\n 5.- Reporte todos los dias de los vectores." +
                    "\n 6.- Salir");

                Console.WriteLine("Digite una opcion:");
                opcion = Convert.ToInt32(Console.ReadLine()); 
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Vectores Inicializados");
                        break;
                    case 2:
                        int varios;
                        Console.WriteLine("Cuantos vehiculos desea registrar");
                        varios = int.Parse(Console.ReadLine());
                        
                        for (int i = 0; i < varios; i++)
                        {
                        Console.WriteLine("Digite el numero de factura");
                        factura[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite el numero de placa");
                        placa[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite la fecha");
                        fecha[i] = Console.ReadLine();
                        Console.WriteLine("Digite la hora");
                        hora[i] = Console.ReadLine();
                        Console.WriteLine("Digite el tipo de vehiculo: 1 - Moto, 2 - Vehiculo liviano, 3 - camion o pesado, 4 - autobus");
                        tipoV[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite el numero de caseta: 1, 2, 3");
                        caseta[i] = int.Parse(Console.ReadLine());
                        if (tipoV[i] == 1 )
                        {
                            monto[i] = 500;
                        }
                        else
                        {
                            if (tipoV[i] == 2)
                            {
                                monto[i] = 700;
                            }
                            else
                            {
                                if (tipoV[i] == 3)
                                {
                                    monto[i] = 2700;
                                }
                                else
                                {
                                    if (tipoV[0] == 4)
                                    {
                                        monto[0] = 3700;
                                    }
                                }
                            }
                        }
                        
                        Console.WriteLine("Digite con que desea pagar: Tarjeta, Efectivo");
                        paga[i] = Console.ReadLine();
                        if (paga[i] == "Tarjeta")
                        {
                            vuelto[i] = 0;
                        }
                        else
                        {
                            if (paga[i] == "Efectivo")
                            {
                                Console.WriteLine("Digite la catidad de efectivo pagada");
                                int temp1 = int.Parse(Console.ReadLine());
                                vuelto[i] = temp1 - monto[i];
                            }
                        }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Cuantos vehiculos desea consultar");
                        varios = int.Parse(Console.ReadLine());
                        for (int i = 0; i < varios; i++)
                        {
                        Console.WriteLine("Digite el numero de placa");
                        int temp1 = int.Parse(Console.ReadLine());
                        if (temp1 == placa[i])
                        {
                            Console.WriteLine("\nNumero de Factura:" + factura[i] +
                                "\nNumero de placa:" + " " + placa[i] 
                                + "\nFecha:" + " " + fecha[i]
                                + "\nHora:" + " " + hora[i]
                                + "\nTipo de vehiculo:" + " " + tipoV[i]
                                + "\nNumero de caseta:" + " " + caseta[i]
                                + "\nMonto a pagar:" + " " + monto[i]
                                + "\nPaga con: " + " " + paga[i]
                                + "\nVuelto" + " " + vuelto[i]);
                        }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Cuantos vehiculos desea modificar");
                        varios = int.Parse(Console.ReadLine());
                        
                        for (int i = 0; i < varios; i++)
                        {
                            Console.WriteLine("Digite el numero de placa");
                            int temp = int.Parse(Console.ReadLine());
                            if (placa[i] == temp)
                            {


                                Console.WriteLine("Digite el numero de factura");
                                factura[i] = int.Parse(Console.ReadLine());
                                Console.WriteLine("Digite la fecha");
                                fecha[i] = Console.ReadLine();
                                Console.WriteLine("Digite la hora");
                                hora[i] = Console.ReadLine();
                                Console.WriteLine("Digite el tipo de vehiculo: 1 - Moto, 2 - Vehiculo liviano, 3 - camion o pesado, 4 - autobus");
                                tipoV[i] = int.Parse(Console.ReadLine());
                                Console.WriteLine("Digite el numero de caseta: 1, 2, 3");
                                caseta[i] = int.Parse(Console.ReadLine());
                                if (tipoV[i] == 1)
                                {
                                    monto[i] = 500;
                                }
                                else
                                {
                                    if (tipoV[i] == 2)
                                    {
                                        monto[i] = 700;
                                    }
                                    else
                                    {
                                        if (tipoV[i] == 3)
                                        {
                                            monto[i] = 2700;
                                        }
                                        else
                                        {
                                            if (tipoV[0] == 4)
                                            {
                                                monto[0] = 3700;
                                            }
                                        }
                                    }
                                }

                                Console.WriteLine("Digite con que desea pagar: Tarjeta, Efectivo");
                                paga[i] = Console.ReadLine();
                                if (paga[i] == "Tarjeta")
                                {
                                    vuelto[i] = 0;
                                }
                                else
                                {
                                    if (paga[i] == "Efectivo")
                                    {
                                        Console.WriteLine("Digite la catidad de efectivo pagada");
                                        int temp1 = int.Parse(Console.ReadLine());
                                        vuelto[i] = temp1 - monto[i];
                                    }
                                }
                            }
                            
                        }
                            break;
                    case 5:
                        Console.WriteLine("");
                        Console.WriteLine("Cuantos vehiculos desea consultar");
                        varios = int.Parse(Console.ReadLine());
                        for (int i = 0; i < varios; i++)
                        {
                                Console.WriteLine("\nNumero de Factura:" + factura[i] +
                                    "\nNumero de placa:" + " " + placa[i]
                                    + "\nFecha:" + " " + fecha[i]
                                    + "\nHora:" + " " + hora[i]
                                    + "\nTipo de vehiculo:" + " " + tipoV[i]
                                    + "\nNumero de caseta:" + " " + caseta[i]
                                    + "\nMonto a pagar:" + " " + monto[i]
                                    + "\nPaga con: " + " " + paga[i]
                                    + "\nVuelto" + " " + vuelto[i]);
                        }
                            break;
                    case 6:
                        Console.WriteLine("");
                        break;


                }

                Console.ReadKey();
            } while (opcion !=6);

        }
    }
}
