using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>(); //jenerik bi class old için türünüğ yazman lazım yoksa kızar
            isimler.Add("engin");

        }
    }
}
