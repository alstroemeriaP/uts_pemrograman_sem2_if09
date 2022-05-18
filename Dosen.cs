using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uts_pemrograman
{
    public class Dosen
    {
        public Dosen()
        {

        }
        public Dosen(int Id, string gender)
        {
            this.Id = Id;
            Gender = gender;
        }

        public int Id { get; set; }
        public string? Gender { get; set; }

    }
    public class AttDosen
    {
        public AttDosen()
        {

        }
        public AttDosen(string nama, int nik)
        {
            Nama = nama;
            Nik = nik;
        }
        public int Nik { get; set; }
        public string? Nama { get; set; }
    }

    public class AddCourse
    {
        public AddCourse()
        {

        }
        public AddCourse(string course)
        {
            Course = course;
        }
        public string? Course { get; set; }
    }
}
