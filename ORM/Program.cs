namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Must Know
            //var x = 4;
            // int, list<int>, student, list<student>

            // object initializer
            //Student s1 = new Student()
            //{
            //    Age = 12,
            //    FName = "Men3m",
            //    LName = "Ali",
            //    Id = 1
            //};
            ////s1.Id = 12;


            //Student s2 = new Student() { Id = 1};
            ////s2.Id = 1;
            //s2.Age = 13;
            //s2.FName = "Men3m";
            //s2.LName = "Ali";

            // Anonymous Object: object has no structure
            // used for projection
            // var objName = new {
            //     id = 12
            // }

            //var std = new
            //{
            //    id = 11,
            //    fullName = "Men3m Anwar",
            //    Age = 30
            //};


            // Anonymous Method:
            // function without name
            // function on the fly
            // used when you want to use delegate

            //// 1.  lambda expressions
            //Func<int, int, int> myDel1 = (x, y) => x + y;

            //// 2. delegate keyword
            //Func<int, int, int> myDel2 = delegate (int x, int y)
            //{
            //    return x + y;
            //};

            // 5. Extension Method
            #endregion


            var sss = new Student() { Id = 5, FName = "Youssef", LName = "Maurice", Age = 20, DeptId = 1 }; 
            List<Student> sts = new List<Student>()
            {
                new Student(){Id = 2, FName = "Fahd",    LName ="Dyaa", Age = 22, DeptId = 1, Subjects = new List<Subject> { new Subject() { Id = 1, Name = "C#", Duration = 36 }, new Subject() { Id = 2, Name = "APIs", Duration = 36 }, new Subject() { Id = 3, Name = "DB", Duration = 40 } } },       //idx = 0
                new Student(){Id = 6, FName = "Basmaa",  LName ="Ahmed", Age = 21, DeptId = 2, Subjects = new List<Subject> { new Subject() { Id = 1, Name = "EF", Duration = 36 }, new Subject() { Id = 2, Name = "LINQ", Duration = 40 } }  },    //idx = 1
                new Student(){Id = 1, FName = "Farah",    LName ="Hani", Age = 20, DeptId = 2, Subjects = new List<Subject> { new Subject() { Id = 1, Name = "C#", Duration = 36 }, new Subject() { Id = 2, Name = "EF", Duration = 40 } }  },      //idx = 2
                new Student(){Id = 3, FName = "Ahmed",  LName ="Eid", Age = 23, DeptId = 1, Subjects = new List<Subject> { new Subject() { Id = 1, Name = "Linq", Duration = 36 }, new Subject() { Id = 2, Name = "DB", Duration = 40 } } },       //idx = 3
                new Student(){Id = 4, FName = "Shrouk",  LName ="Hany", Age = 20, DeptId = 1, Subjects = new List<Subject> { new Subject() { Id = 1, Name = "MVC", Duration = 36 }, new Subject() { Id = 2, Name = "APIs", Duration = 40 } } },     //idx = 4
                new Student(){Id = 7, FName = "Youssef",  LName ="Rageh", Age = 21, DeptId = 2, Subjects = new List<Subject> { new Subject() { Id = 1, Name = "ES6", Duration = 36 }, new Subject() { Id = 2, Name = "JS", Duration = 40 } } },   //idx = 5
                //sss,
                //sss
                new Student() { Id = 5, FName = "Youssef", LName = "Maurice", Age = 20, DeptId = 1, Subjects = new List<Subject> { new Subject() { Id = 1, Name = "Angular", Duration = 36 } } },
                //new Student() { Id = 5, FName = "Youssef", LName = "Maurice", Age = 20, DeptId = 1 }
            };

            #region LINQ
            // Before Linq
            //var result = new List<Student>();
            //foreach(var st in sts)
            //{
            //    if(st.Age >= 21)
            //    {
            //        result.Add(st);
            //    }
            //}

            //foreach(var st in result)
            //{
            //    Console.WriteLine(st);
            //}

            //Console.WriteLine("\n-------------------------------\n");

            // After Linq
            //var q1 = Enumerable.Where(sts, delegate (Student st)
            //{
            //    return st.Age >= 21;
            //});

            //var q2 = Enumerable.Where(sts, st => st.Age >= 21);

            //var q3 = sts.Where(st => st.Age >= 21);

            //var q4 = sts.Select(s => new
            //{
            //    FullName = $"{s.FName} {s.LName}",
            //    s.Age
            //});

            //var q5 = Enumerable.Select(sts, delegate (Student s)
            //{
            //    return new
            //    {
            //        FullName = $"{s.FName} {s.LName}",
            //        s.Age
            //    };
            //});

            //var q6 = Enumerable.Select(sts, s => new {
            //    FullName = $"{s.FName} {s.LName}",
            //    s.Age
            //});

            //var q7 = sts.Where(s => s.Age >= 21).Select(s => new
            //{
            //    FullName = $"{s.FName} {s.LName}",
            //    s.Age
            //});


            //var q8 = Enumerable.Where(sts, s => s.Age >= 21);
            //var q9 = Enumerable.Select(q8, s => new
            //{
            //    FullName = $"{s.FName} {s.LName}",
            //    s.Age
            //});


            // Method Chaining
            //var q10 = Enumerable.Select(Enumerable.Where(sts, s => s.Age >= 21), s => new
            //{
            //    FullName = $"{s.FName} {s.LName}",
            //    s.Age
            //});


            // LINQ
            // Methods Expressions
            //var q11 = sts.Where(s => s.Age >= 21).Select(s => new
            //{
            //    FullName = $"{s.FName} {s.LName}",
            //    s.Age
            //});

            // Query Expressions
            //var q12 = from s in sts
            //          where s.Age >= 21
            //          select s.FName;

            //var q13 = from s in sts
            //          where s.Age >= 21
            //          select new {
            //              FullName = $"{s.FName} {s.LName}",
            //              s.Age
            //          };
            //foreach (var item in q13)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Query Exection

            //var q14 = sts.Where(s => s.Age >= 21).ToList();  // imediate execution
            //var q14 = sts.Where(s => s.Age >= 21);             // deferred execution

            //sts.Add(new Student() { Id = 7, FName = "Yousef", LName = "Ibrahim", Age = 24 });

            //foreach (var item in q14)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("\n-------------------------------\n");
            //sts.Add(new Student() { Id = 8, FName = "Mariam", LName = "Ahmed", Age = 21 });

            //foreach (var item in q14)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region First, Last, Single, .....

            //var q15 = sts.Where(s => s.Id == 3);
            //foreach (var item in q15)
            //{
            //    Console.WriteLine(item);
            //}

            //var q16 = sts.Where(s => s.Age == 21).Single();
            //var q17 = sts.Where(s => s.Age == 30).Single();
            //var q18 = sts.Where(s => s.Id == 3).Single();
            //var q19 = sts.Where(st => st.Age == 30).SingleOrDefault();
            //var q20 = sts.Where(st => st.Age == 21).SingleOrDefault();
            //Console.WriteLine(q20);

            //var q21 = sts.Where(s => s.Age == 21).First();
            //var q22 = sts.Where(s => s.Age == 21).Last();

            //var q23 = sts.Where(s => s.Age == 30).First();
            //var q24 = sts.Where(s => s.Age == 21).FirstOrDefault();

            //var q25 = sts.Where(s => s.Age == 30).FirstOrDefault();
            //var q26 = sts.Where(s => s.Age == 21).LastOrDefault();

            //Console.WriteLine(q23);


            //var q27 = sts.Where(s => s.Age >= 21).Select(s => s.FName);
            //var q28 = sts.Select(s => s.FName).Where(s => s.Contains('B'));

            //foreach(var x in q28)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion

            #region Count, Sum, Min, Max, ...
            //var q29 = sts.Count();
            //Console.WriteLine(q29);

            //var q30 = sts.Average(s => s.Age);
            //Console.WriteLine(q30);

            //var q31 = sts.Max(s => s.Age);
            //Console.WriteLine(q31);

            //var q32 = sts.Min(s => s.Age);
            //Console.WriteLine(q32);
            #endregion

            #region Take, Skip, TakeWhile, SkipWhile, TakeLast

            //var q33 = sts.Take(2);
            //var q34 = sts.Skip(2);
            //var q35 = sts.Skip(2).Take(1);
            //var q37 = sts.Take(3).Last();
            //Console.WriteLine(q38);
            //var q38 = sts.TakeLast(4);
            //var q38 = sts.SkipLast(4);
            //var q39 = sts.TaleWhile(s=>s.Age>=21);
            //var q40 = sts.SkipWhile(s=>s.Age>=21);
            //foreach (var st in q40)
            //{
            //    Console.WriteLine(st);
            //}

            //var q36 = sts.ElementAt(3);
            //Console.WriteLine(q36);
            #endregion

            #region Order By, OrderByDescending, ThenBy, ThenByDescending
            //var q43 = sts.OrderBy(s => s.Id);
            //foreach(var s in q43)
            //{
            //    Console.WriteLine(s);
            //}
            //Console.WriteLine("-------------------------");

            //foreach(var s in sts)
            //{
            //    Console.WriteLine(s);
            //}

            // order by fname asc, age decs, id asc
            //var q44 = sts.OrderByDescending(s => s.FName).ThenBy(s => s.Age);

            //foreach (var s in q44)
            //{
            //    Console.WriteLine(s);
            //}
            //var q45 = sts.OrderBy(s => s.FName).ThenByDescending(s => s.Age).ThenBy(s => s.Id);
            //Console.WriteLine("0--------------------------------");

            //foreach (var s in q45)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion

            #region Group By
            //var q46 = sts.GroupBy(s => s.DeptId);  // act as dictionary
            //foreach (var item in q46)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var s in item)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}

            //var q466 = sts.GroupBy(s => s.DeptId).ToDictionary(kvp => kvp.Key, kvp => kvp.ToList());
            //foreach (var item in q466)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var s in item.Value)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}

            #endregion

            #region Select Many
            //var q47 = sts.Select(s => new { s.FName, s.Subjects });
            //foreach(var item in q47)
            //{
            //    Console.WriteLine(item);
            //}

            // flatten array subject
            // 1 sub
            // x sub
            //var q48 = sts.SelectMany(s => s.Subjects, (std, sub) => new
            //{
            //    std.Id,
            //    SubId = sub.Id,
            //    sub.Duration,
            //    std.FName,
            //    sub.Name,
            //});

            //foreach (var x in q48)
            //{
            //    Console.WriteLine($"StdId = {x.Id}, SubId = {x.SubId}, StdName = {x.FName}, SubName = {x.Name}, Course Duration = {x.Duration} Hours.");

            //Console.WriteLine(x.Id);
            //Console.WriteLine(x.FName);
            //Console.WriteLine(x.Name);
            //Console.WriteLine(x.Duration);
            //Console.WriteLine(x.SubId);
            //}


            //List<string> names = [ "ahmed", "ali", "ola", "sara" ];
            //List<int> nums = [1, 7, 2, 6, 3];

            //var q50 = names.SelectMany(n => nums, (name, num) => new
            //{
            //    output = $"{name} - {num}"
            //});

            //foreach(var x in q50)
            //{
            //    Console.WriteLine(x.output);
            //}
            #endregion

            #region Set Operations
            //List<string> names = [ "ahmed", "ali", "ola", "sara", "ali" ];
            //var q51 = names.Distinct();
            //foreach(var x in q51)
            //    Console.WriteLine(x);

            //var q52 = sts.Distinct(new StudentComparer());
            //foreach (var x in q52)
            //    Console.WriteLine(x);

            #endregion
        }
    }
}
