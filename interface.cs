using System;

namespace ConsoleApp15
{
    using System;

    namespace interface_
    {
        interface DB1
        {
            string connectionString { get; set; }
            void Add();
            void Edit();

        }


        interface DB2
        {
            void Delete();
        }

        class Class1
        {

        }


        class Class2
        {

        }


        class Class3
        {

        }


        class MyDB : Class1, DB1, DB2
        {
            private string _connectionString;
             string DB1.connectionString
            {
                get { return _connectionString; }
                set { _connectionString = value; }

            }

            void DB1.Add()
            {
                Console.WriteLine("Add");
            }

            void DB1.Edit()
            {
                Console.WriteLine("Edit");
            }

            void DB2.Delete()
            {
                Console.WriteLine("Delete");
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                MyDB d = new MyDB();
                DB1 db1 = new MyDB();
                db1.connectionString = "MyConn";
                Console.WriteLine(db1.connectionString);
                db1.Add();

                DB2 db2 = new MyDB();
                db2.Delete();
            }
        }
    }

}
