//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BATCH1_DET_2022
//{
//    internal interface ICar
//    {
//        int GetPrice(string Name);

//    }

//    class Bmw : ICar
//    {
//        int ICar.GetPrice(string Name)
//        {

//            if (Name == "M3")
//                return 1300000;
//            else if (Name == "X7")
//                return 9600000;
//            else
//                return 100000;
//        }
//        class Hyundai : ICar
//        {
//            int ICar.GetPrice(string Name)
//            {

//                if (Name == "Tucson")
//                    return 300000;
//                else if (Name == "creta")
//                    return 900000;
//                else
//                    return 10000;
//            }

//            internal object GetPrice(string v)
//            {
//                throw new NotImplementedException();
//            }
//        }
//        class TestCar
//        {


//            public static void Main()
//            {
//                Hyundai h = new Hyundai();
//                Bmw b = new Bmw();
//                Console.WriteLine($"PRICE FOR Tucson model {h.GetPrice("Tucson")}");
//                Console.WriteLine($"PRICE FOR M3 Model{h.GetPrice("M3")}");
//            }
//        }

//    }
//}



