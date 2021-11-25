using System;

namespace ConsoleApp16struct
{
    /*
      هو ذي ذي الكلاس في كل حاجة الا انة لا
      يستطيع ان يرث من كلاس اخر الا انة  يستطيع
      ان ينفذ اكثر من انترفيس 
   ، ولا  يستطيع ان ينفذ او يرث  ابستراكت  كلاس
    استطيع  ان  اعمل منه اوبجكت
    */

    class Class1 { }
    abstract class class2 { }
    interface i1 { }
    interface i2 { }


    struct Employee:i1,i2
    {
        public int EmpNo;
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public void Print()
        {
            Console.WriteLine("print");
         
        }




    }


    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Print();
        }
    }
}
