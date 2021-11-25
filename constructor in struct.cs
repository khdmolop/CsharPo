using System;

namespace ConsoleApp16constructorInStruct
{

    struct person
    {
        /*
          الكونستركثر  لازم يحتوي  علي برميتر
         
         */

        public person(string Name, string Address)
        {//لو حذفت البرميتر نيم سوف يعمل مشكله
            //لا يجوز ان اعمل برميتر واعطيه قيمه اختياريه 
            /*
              يجب ان اضع قيم للمتغيرات داخل الكونستركثر 
             */
            _Name = Name;
            this. Address = Address;
        }

        private string _Name;
        public string Address;
        //لا يجوز ان اعمل متغير داخل الستركت واعطيه قيمه

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public void Print() { Console.WriteLine(_Name + ";" + Address); }

    }


    class Program
    {
        static void Main(string[] args)
        {
            person p = new person("omar","giza");
            p.Print();
        }
    }
}
