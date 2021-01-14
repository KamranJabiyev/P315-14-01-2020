using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TupleThreadTask
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tuple,ValueTuple
            #region Tuple-reference
            //Tuple<int, string, string> person = new Tuple<int, string, string>(1, "Fikret", "Javadov");
            //var person = Tuple.Create(1, "Fikret", "Jvadov",4,5,6,7,8);
            //Console.WriteLine(person.Rest.Item1);
            #endregion
            #region ValueTuple - value
            //ValueTuple<int, string, string> person = (1, "Fikret", "Javadov");
            //(int,string,string) person= (1, "Fikret", "Javadov");
            //Console.WriteLine(person.Item1);
            //var person = (Id: 1, Name: "Fikret", Surname: "Javadov");
            //Console.WriteLine(person.Surname);
            #endregion
            #endregion

            #region Thread
            //Loop1();
            //Loop2();

            //Thread thread1 = new Thread(Loop1);
            //Thread thread2 = new Thread(Loop2);
            //thread1.Start();
            ////thread1.Join();
            //thread2.Start();
            //Console.WriteLine("P315");
            #endregion
        }
        #region Thread
        static void Loop1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(0);
                Console.WriteLine($"Loop1: {i}");
            }
        }

        static void Loop2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(1);
                Console.WriteLine($"Loop2: {i}");
            }
        }
        #endregion

        #region Tuple,ValueTuple
        static (int, string, string) GetPerson()
        {
            return (Id: 1, FirstName: "Bill", LastName: "Gates");
        }

        //static Person GetPerson()
        //{
        //    return new Person { Id = 1, Name = "Tural", Surname = "Alesgerov" };
        //}
        #endregion
    }

    #region Tuple,ValueTuple
    //class Person
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Surname { get; set; }
    //}
    #endregion
}
