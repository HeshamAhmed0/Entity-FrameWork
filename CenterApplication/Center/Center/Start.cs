using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Center.SelectStatement;
using Center.Transaction;

namespace Center
{
    internal class Start
    {
        int Input;
        public void Decition()
        {
            Console.WriteLine("Please Choose What Do You Want ");
            Console.WriteLine("1 :: Insert");
            Console.WriteLine("2 :: Select");
            Input = int.Parse(Console.ReadLine());
            if (Input == 1)
            {
                InsertSection();
            }
            else if (Input == 2)
            {
                Console.Clear();
                SelectFromDatabase selectFromDatabase = new SelectFromDatabase();
                selectFromDatabase.Select();
            }

        }
        public void InsertSection()
        {

            Console.Clear();
            Console.WriteLine("1 :: InsertIntoConstructor");
            Console.WriteLine("2 :: InsertIntoDepartment");
            Console.WriteLine("3 :: InsertIntoStudent");
            Input = int.Parse(Console.ReadLine());
            Console.Clear() ;
            if (Input == 1)
            {
                InsertIntoConstructor.InserConstructor();
            }
            else if (Input == 2)
            {
                InsertIntoDepartment.InsertDepartment();
            }
            else if (Input == 3)
            {
                InsertIntoStudents.InsertStudent();
            }
            else
            {
                Console.WriteLine("You Choosen Is Not Correct Please Choose Correct Choosen");
                InsertSection();
            }
            AnotherDescition();

        }
        public void AnotherDescition()
        {
            Console.WriteLine("Do You Want Another Desction " +
                              "1 :: Yes " +
                              "2 :: No");
            Console.Write("You Choosen Is : ");
            Input = int.Parse(Console.ReadLine());
            if (Input == 1)
            {
                Decition();
            }
            else
            {
                Console.WriteLine("See You Soon");
            }
        }
    }
}
