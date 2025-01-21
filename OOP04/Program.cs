using OOP04.Interface_Example02;

namespace OOP04
{
    internal class Program
    {

        #region Interface Ex02
        static void PrintTenNUmbersFromSeries(ISeries series)
        {
            if (series == null)
            {
                return;
            }
            for (int i = 0; i <= 10; i++)
            {
                Console.Write($"{series.Current} \t");
                series.GetNext();
            }
            series.Reset();
            Console.WriteLine();
        }
        #endregion
        static void Main(string[] args)
        {
            #region Interface EXample 01
            // IType reference;
            // Declare for reference of type "IType", containing garbage value
            /// this Reference can refer to an Object of any type Implementing IType Interface
            /// CLR will Allocate 4 unintialized Bytes in Stack for this reference
            /// CLR will allocate 0 Bytes in HEAP

            // reference = new IType(); INVALID
            //reference = new TypeA();
            //reference.MyProperty = 10;
            //reference.MyMethod();
            //reference.Print();
            //TypeA typeA = new TypeA();
            //typeA.MyProperty = 20;
            //typeA.MyMethod();
            //typeA.Print():   // INVALID , can't see this method

            #endregion



            #region Interface Example 02

            //TypeA seriesByTwo = new TypeA();
            //PrintTenNUmbersFromSeries(seriesByTwo);

            //TypeB seriesByThree = new TypeB();
            //PrintTenNUmbersFromSeries(seriesByThree);

            //TypeC seriesByFour = new TypeC();
            //PrintTenNUmbersFromSeries(seriesByThree);
            //
            #endregion


            #region Interface Example 03

            //Airplane airplane = new Airplane();
            //airplane.Speed = 480;
            ////airplane.forward();
            //IMoveable moveable = airplane;
            //moveable.Forward();
            //IFlyable flyable = airplane;
            //flyable.Forward();

            #endregion

        }
    }
}