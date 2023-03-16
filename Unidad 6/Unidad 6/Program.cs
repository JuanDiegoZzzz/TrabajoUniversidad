using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Abrimos el archivo para escritura
            FileStream fs = new FileStream("test.bin", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            // Escribimos algunos datos en el archivo
            bw.Write("Juan Diego ");
            bw.Write(18);
            bw.Write(true);

            // Cerramos los objetos
            bw.Close();
            fs.Close();

            // Abrimos el archivo para lectura
            FileStream fs2 = new FileStream("test.bin", FileMode.Open);
            BinaryReader br = new BinaryReader(fs2);

            // Leemos los datos del archivo
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadBoolean());

            // Cerramos los objetos
            br.Close();
            fs2.Close();
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error al acceder al archivo: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error inesperado: " + ex.Message);
        }
        Console.ReadKey();
    }
}