//Write a text file - Version-1
using System;
using System.IO;
namespace readwriteapp
{
    class Filescsharp
    {
        [STAThread]
        static void Main(string[] args)
        {
            String linea;
            Boolean encontrado = false;
            try
            {   
                //Ruta del documento de texto donde se escribe
                //Agregar
                //StreamWriter sw = File.AppendText("Test.txt");


                //Sobreescribir
                StreamWriter sw = new StreamWriter("Test.txt");
                
                //Escribir linea en documento
                sw.WriteLine("Escritura 1");
                //Escribir otra linea en documento
                sw.WriteLine("ISV0101");                
                //Cerrar archivo
                sw.Close();

                //Ruta del documento de texto a leer
                StreamReader sr = new StreamReader("Test.txt");
                //Leer primer linea
                linea = sr.ReadLine();
                //Continuar leyendo hasta el final del archivo
                while (linea != null)
                {
                    if(linea == "ISV0101")
                        encontrado = true;                    
                    //Escribir linea en consola
                    Console.WriteLine(linea);
                    //Leer linea siguiente
                    linea = sr.ReadLine();
                }
                //Cerrar archivo
                sr.Close();
                Console.ReadLine();
                if(encontrado == true)
                    Console.WriteLine("Si existe");
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Bloque final.");
            }
        }
    }
}