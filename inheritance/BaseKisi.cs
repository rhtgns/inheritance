using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace inheritance
{
    public class BaseKisi
    {


        public string Name { get; set; }


        public string SurName { get; set; }

        public void ReadNameSurname()
        {
            Console.WriteLine($" Name :{Name} , Surname : {SurName} ");
        }
    }     
        
        public class Student : BaseKisi 
        {

            public int StudentNo { get; set; }
            
            //burda kullanıcıdan gelen isim soy isimleri yazdırıyortuz

             public void ReadNameSurnameStudent() 
           { 
             ReadNameSurname();



            Console.WriteLine($"ogrenci no: {StudentNo}");
        }
           

           
       

        }
        public class Teacher : BaseKisi
        {
         
         public double TeacherSalary {  get; set; }




        // Maaş bilgisi, Ad ve Soyad bilgilerini konsola yazdıralım

         public void ReadTeacherInfo()
        {
            ReadNameSurname();

            Console.WriteLine($" maas :{TeacherSalary}");
        }

    }

}

