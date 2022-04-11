using System;

namespace PROJE1
{
    public class Personal
    {

        private string personalname;
        private string personalsurname;

        public string PersonalName
        {
            get { return personalname; }
            set { personalname = value; }
        }
        public string PersonalSurname
        {
            get { return personalsurname; }
            set { personalsurname = value; }
        }

        public class Sozlesmeli : Personal
        {
            int kalanizinsayısı;
            public int Kalanizinsayisi
            {
                get { return kalanizinsayısı; }
                set { kalanizinsayısı = value; }
            }

            public override void showInfo()
            {
                base.showInfo();
                Console.WriteLine($"KALAN İZİN SAYISI: {this.kalanizinsayısı}");
            }
        }

        public class Kadrolu : Personal
        {
            int salary;
            public int Salary { get { return salary; } set { salary = value; } }

            public override void showInfo()
            {
                base.showInfo();
                Console.WriteLine($"MAAŞI: {this.salary}");
            }
        }

        public virtual void showInfo()
        {

            Console.WriteLine($"ADI: {this.personalname}\n" +
                $"SOYADI: {this.personalsurname}");
        }



        static void Main(string[] args)
        {

            Personal personal1 = new Personal();
            personal1.personalname = "Melih";
            personal1.personalsurname = "KAHRAMAN";
            personal1.showInfo();


            Kadrolu kadrolu1 = new Kadrolu
            {
                personalname = "HAKAN",
                personalsurname = "ALTUN",
                Salary = 10
            };
            kadrolu1.showInfo();

            Sozlesmeli sozlesmeli1 = new Sozlesmeli();
            sozlesmeli1.personalname = "FERİDUN";
            sozlesmeli1.personalsurname = "TOY";
            sozlesmeli1.Kalanizinsayisi = 68;
            sozlesmeli1.showInfo();





        }
    }
}

