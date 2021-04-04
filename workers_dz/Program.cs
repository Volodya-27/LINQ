using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workers_dz
{
    class Program
    {
        static void Main(string[] args)
        {
            Workers workers = new Workers();
            List<Salary> salary = new List<Salary>(workers.workers.Count);
              
            salary.AddRange(new Salary[] { new Salary { salary_one_semester = 1000, salary_two_semester = 45, id_workers = workers.workers[0].Id} , //прийшлось говнокодити 😁 така умова задачі 😕 я би краще зробив у класі робітника обект типу salary у workers
                new Salary { salary_one_semester = 54, salary_two_semester = 50000, id_workers = workers.workers[1].Id},
                new Salary { salary_one_semester = 7, salary_two_semester = 5406, id_workers = workers.workers[2].Id},
                new Salary { salary_one_semester = 5, salary_two_semester = 454, id_workers = workers.workers[3].Id},
                new Salary { salary_one_semester = 7585, salary_two_semester = 5, id_workers = workers.workers[4].Id},
                new Salary { salary_one_semester = 875, salary_two_semester = 2, id_workers = workers.workers[5].Id },
                new Salary { salary_one_semester = 782, salary_two_semester = 872, id_workers = workers.workers[6].Id} }
                );
            
            //old workers
            var a = from r in workers.workers 
                    where r.dateTimeBirth.Year < (2021-35)                   
                    select r;
            Console.WriteLine("\n\n\nOld workers");
            foreach (var item in a)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.dateTimeBirth.Year + "\n");
            }


            //big sallary two semestr
            var a1 = (from r in salary
                      select r.salary_two_semester).Max();
            foreach (var item in salary)
            {
                if(item.salary_two_semester == a1)
                    Console.WriteLine($"Id workers if big salarry {item.id_workers}");
            }



            //***************************************************************************************************
            //***************************************************************************************************
            //one 
            //big sallary all
            //var tt = salary.Select(f =>  f.salary_one_semester + f.salary_two_semester).Average();
            //var end = from w in salary
            //          where ((w.salary_one_semester + w.salary_two_semester) < tt)
            //          select w;
            //foreach (var item in end)
            //{
            //    for (int i = 0; i < workers.workers.Count; i++)
            //    {
            //        if (item.id_workers == workers.workers[i].Id)
            //            Console.WriteLine($"{workers.workers[i].Name}\t {workers.workers[i].Profession}");
            //    }
            //}


            //--------------------------------------------------------------------------------------------------------
            //two
            var result = salary.Join(salary, p => p.salary_two_semester, t => t.salary_two_semester, (p, t) =>
                new { salary_s = p.salary_one_semester, salary_c = t.salary_two_semester }).Select(p => p.salary_c + p.salary_s).Average();

            var end2 = from w in salary
                      where ((w.salary_one_semester + w.salary_two_semester) < result)
                      select w;

            foreach (var item in end2)
            {
                for (int i = 0; i < workers.workers.Count; i++)
                {
                    if (item.id_workers == workers.workers[i].Id)
                        Console.WriteLine($"{workers.workers[i].Name}\t {workers.workers[i].Profession}");
                }
            }

            //***************************************************************************************************
            //***************************************************************************************************







            Console.ReadKey();
        }
    }
}
