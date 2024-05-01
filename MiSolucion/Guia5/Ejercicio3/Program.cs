using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ca;//cant alumnos
            int nl, nMY=0, nme=0;//numero de libreta, n°libreta mayor, n°libreta menor
            int prom, prMY=0, prme=0;//promedio, promedio mayor, promedio menor
            string alum, alMY="", alme=""; //nombre alumno, nombre mayor, nombre menor

            Console.WriteLine("Ingrese cantidad de alumnos");
            ca = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i<=ca; i++) {

                //solicitar nombre,
                Console.WriteLine(" Ingrese {0}° numero de libreta",i);
                nl = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Ingrese nombre del alumno");
                alum = Console.ReadLine();
                
                Console.WriteLine(" Ingrese promedio del alumno");
                prom = Convert.ToInt32(Console.ReadLine());

                
                if (i == 1)//verificar primera iteracion
                {
                    nMY = nl; nme = nl;
                    prMY = prom; prme = prom;
                    alMY = alum; alme = alum;
                }
                else { //procesar otras operaciones
                    if (prom < prme) {//promedio menor
                        prme = prom;
                        nme =nl;
                        alme =alum;
                    }
                    if(prom > prMY){//promedio MAYOR
                        prMY =prom;
                        nMY =nl;
                        alMY = alum;
                    }

                 
                }


            }

            Console.WriteLine(" Alumno con mayor promedio: {0}\t N° de libreta: {1}\t Promedio: {2}",alMY, nMY, prMY);
            Console.WriteLine(" Alumno con menor promedio: {0}\t N° de libreta: {1}\t Promedio: {2}", alme, nme, prme);
            Console.ReadKey();


        }
    }
}
