using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //}
       
       
            public static void Main()
            {
                // Student collection
                IList<Employee> EmployeeTable = new List<Employee>() {
                new Employee() { empno = 7369, ename = "Smith",job= "clerk", mgr = 7902, hiredate =Convert.ToDateTime("6/13/1993"), sal=800,comm=0, deptno = 20} ,
                new Employee() { empno = 7499, ename = "Allen",job= "Salesman", mgr = 7698, hiredate =Convert.ToDateTime("8/15/1998"), sal=1600,comm=300, deptno = 30} ,
                new Employee() { empno = 7521, ename = "Ward",job= "Salesman", mgr = 7698, hiredate =Convert.ToDateTime("3/26/1996"), sal=1250,comm=500, deptno = 30} ,
                new Employee() { empno = 7566, ename = "Jones",job= "Manager", mgr = 7839, hiredate =Convert.ToDateTime("10/31/1995"), sal=2975,comm=0, deptno = 20} ,
                new Employee() { empno = 7698, ename = "Blake",job= "Manager", mgr = 7839, hiredate =Convert.ToDateTime("6/11/1992"), sal=2850,comm=0, deptno = 30} ,
                new Employee() { empno = 7782, ename = "Clark",job= "Manager", mgr = 7839, hiredate =Convert.ToDateTime("5/14/1993"), sal=2450,comm=0, deptno = 10} ,
                new Employee() { empno = 7788, ename = "Scott",job= "Analyst", mgr = 7566, hiredate =Convert.ToDateTime("3/5/1996"), sal=3000,comm=0, deptno = 20} ,
                new Employee() { empno = 7839, ename = "King",job= "President", mgr =null, hiredate =Convert.ToDateTime("6/9/1990"), sal=5000,comm=0, deptno = 10} ,
                new Employee() { empno = 7844, ename = "Turner",job= "Salesman", mgr = 7698, hiredate =Convert.ToDateTime("6/4/1995"), sal=1500,comm=0, deptno = 30} ,
                new Employee() { empno = 7876, ename = "KING Adams",job= "Clerk", mgr = 7788, hiredate =Convert.ToDateTime("6/4/1999"), sal=1100,comm=0, deptno = 20},
                new Employee() { empno = 7900, ename = "James",job= "Clerk", mgr = 7698, hiredate =Convert.ToDateTime("6/23/2000"), sal=950,comm=0, deptno = 30} ,
                new Employee() { empno = 7934, ename = "Miller",job= "Clerk", mgr = 7782, hiredate =Convert.ToDateTime("1/21/2000"), sal=1300,comm=0, deptno = 10},
                new Employee() { empno = 7902, ename = "Ford",job= "Analyst", mgr = 7566, hiredate =Convert.ToDateTime("12/5/1997"), sal=3000,comm=0, deptno = 20} ,
                new Employee() { empno = 7654, ename = "Martin",job= "Salesman", mgr = 7698, hiredate =Convert.ToDateTime("12/5/1998"), sal=1250,comm=1400, deptno = 30} ,

            };
                IList<Department> DepartmentTable = new List<Department>(){
            new Department(){deptno=10,deptname="Accounting",location="New York"},
            new Department(){deptno=20,deptname="Research",location="Dallas"},
            new Department(){deptno=30,deptname="Sales",location="Chicago"},
            new Department(){deptno=40,deptname="Operations",location="Boston"},
        };



            //Extension method query H
            var query1 = EmployeeTable.Join(DepartmentTable, s => s.deptno, d => d.deptno, (s, d) => new { s.deptno, s.sal, d.deptname });
            {

                var query2 = query1.GroupBy(s => s.deptname)
                       .OrderByDescending(s => s.Key);
                foreach (var group in query2)
                {
                    Console.WriteLine(group.Key);
                    foreach (var sal in group.OrderByDescending(c => c.sal).Take(1))
                    {
                        Console.WriteLine($"\t{sal.sal}");
                    }
                }
            }
            Console.ReadLine();



            //Query G
            //var query3 = EmployeeTable.Join(DepartmentTable, s => s.deptno, d => d.deptno, (s, d) => new { s.ename, s.deptno, d.location });
            //var temp = query3.Where(e => e.location == "New York");
            //foreach (var item in temp)
            //{
            //    Console.WriteLine(item.ename);

            //}
            //Console.ReadLine();



            ////Query F
            //var query2 = EmployeeTable.Where(s => s.job == "Manager").Average(x => x.sal);
            //Console.WriteLine($"The average Manager's Salary is:{query2}");
            //Console.ReadLine();



            ////Query E
            //var today = Convert.ToDateTime(DateTime.Today);
            //var query = EmployeeTable.OrderBy(c => c.hiredate);

            //foreach (var s in query)
            //{

            //    var x = (s.hiredate - today).TotalDays;
            //    double y = x / 365;
            //    Console.WriteLine(s.ename + "-" + y + "years");
            //}
            //Console.ReadLine();



            ////Query D
            //var result = EmployeeTable.OrderByDescending(s => s.sal).First();
            //Console.WriteLine($"Employee with highest salary is :\t{result.ename}");
            //Console.ReadLine();



            ////Query C
            //var queryc=EmployeeTable.OrderBy(e => e.ename);
            //foreach (var item in queryc)
            //{
            //    Console.WriteLine(item.ename);
            //}
            //Console.ReadLine();


            ////Query B
            //var result = EmployeeTable.Where(e => e.deptno == 20)
            //                           .Take(1).ToList();
            //foreach(var str in result)
            //{
            //    Console.WriteLine(str.ename);
            //}
            //Console.ReadLine();



            ////Query A
            //var querya = EmployeeTable.Where(e => e.ename.StartsWith("KING"));
            //Console.WriteLine("The employee names that start with KING are as follows:");
            //foreach (var item in querya)
            //{
            //    Console.WriteLine($"\t{item.ename}");

            //}
            //Console.ReadLine();


        }



    }

    
}