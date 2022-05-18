using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uts_pemrograman
{
    class Program
    {
        static void Main()
        {
            Console.Title = "UTS PEMROGRAMAN";

            Dosen dosen1 = new Dosen();
            AttDosen dosen2 = new AttDosen();
            AddCourse dosen3 = new AddCourse();

            //input data
            Console.WriteLine("=== Input Data Dosen ===\n");

            Console.Write("ID     : ");
            dosen1.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nama   : ");
            dosen2.Nama = Console.ReadLine();

            Console.Write("NIK    : ");
            dosen2.Nik = Convert.ToInt32(Console.ReadLine());

            Console.Write("Gender : ");
            dosen1.Gender = Console.ReadLine();

            Console.Write("Course : ");
            dosen3.Course = Console.ReadLine();


            //output data
            Console.WriteLine("\n=== Output ===\n");
            Console.WriteLine("ID     : {0}", dosen1.Id);
            Console.WriteLine("Nama   : {0}", dosen2.Nama);
            Console.WriteLine("NIK    : {0}", dosen2.Nik);
            Console.WriteLine("Gender : {0}", dosen1.Gender);
            Console.WriteLine("Course : {0}", dosen3.Course);
            Console.WriteLine();


            Console.ReadKey();

        }

    }
}