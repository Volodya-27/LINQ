using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workers_dz
{
    class Workers: IEnumerable
    {
        public List<Worker> workers = new List<Worker>
        {
            new Worker{Name="Ivan", Id=1, dateTimeBirth = new DateTime(1995,1,12), Profession= "Сleaner", Type_of_education= "waiter"/*, salary = new Salary{salary_one_semester = 300, salary_two_semester= 100,  } */},
            new Worker{Name="Volodya", Id=6, dateTimeBirth = new DateTime(2002,7,27), Profession = "Founder", Type_of_education ="Programer"/*,salary = new Salary{salary_one_semester = 1000000, salary_two_semester= 5000000 } */},
            new Worker{Name="Koil", Id=654, dateTimeBirth = new DateTime(1981,3,15) , Profession= "Teh lid", Type_of_education = "C++ master"/*,salary = new Salary{salary_one_semester = 30000, salary_two_semester= 40000 }*/ },
            new Worker{Name="Igor", Id=64, dateTimeBirth = new DateTime(1991,4,17) , Profession = "Game desiner", Type_of_education = "Desiner"/*,salary = new Salary{salary_one_semester = 20000, salary_two_semester= 60000 } */},
            new Worker{Name="Oleg", Id=77, dateTimeBirth = new DateTime(1985,5,5) , Profession="System administrator", Type_of_education="sys admin"/*,salary = new Salary{salary_one_semester = 1000, salary_two_semester= 5000 }*/ }, 
            new Worker{Name="Dima", Id=33, dateTimeBirth = new DateTime(1982,6,6), Profession ="Data sciens" , Type_of_education="Python master"/*, salary = new Salary{salary_one_semester = 6000, salary_two_semester= 8000 }*/ },
            new Worker{Name="Bodya", Id=22, dateTimeBirth = new DateTime(1999,7,7) , Profession ="Developer", Type_of_education="self-taught"/*, salary = new Salary{salary_one_semester = 11000, salary_two_semester= 15000 }*/},
        };

        public IEnumerator GetEnumerator()
        {
            return workers.GetEnumerator();
        }
    }
}
