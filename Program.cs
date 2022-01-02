using System;
using System.Collections.Generic;

//namespace Program
//{
//    enum speedInterface { USB2, USB3 }
//    abstract class Storage
//    {
//        public string Company { get; set; }
//        public string ModelNumber { get; set; }
//        public float Capacity { get; set; }
//        public speedInterface speed { get; set; }
//        public float Count(float size)
//        {
//            return size / Capacity;
//        }
//        abstract public override string ToString();

//    }

//    class DVD : Storage
//    {
//        public DVD(string _Company, string _ModelNumber, float _Capacity)
//        {
//            Company = _Company;
//            ModelNumber = _ModelNumber;
//            Capacity = _Capacity;
//        }

//        public override string ToString()
//        {
//            return
//                "Company:" + " " + Company +
//                "Model Number:" + " " + ModelNumber +
//                "Capacity:" + " " + Capacity +
//                "Speed Interface" + " " + speed;
//        }

//    }

//    class FlashDrive : Storage
//    {
//        public FlashDrive(string _Company, string _ModelNumber, float _Capacity)
//        {
//            Company = _Company;
//            ModelNumber = _ModelNumber;
//            Capacity = _Capacity;
//        }

//        public override string ToString()
//        {
//            return
//                "Company:" + " " + Company +
//                "Model Number:" + " " + ModelNumber +
//                "Capacity:" + " " + Capacity +
//                "Speed Interface" + " " + speed;
//        }


//    }

//    class ExternalHDD : Storage
//    {
//        public ExternalHDD()
//        {

//        }

//        public struct Partition
//        {
//            float Size;
//            string Name;
//        }

//        int CountPartitions { get; set; }
//        Partition[] PartitionHDD { get; set; }

//        public override string ToString()
//        {
//            return
//               "Company:" + " " + Company +
//               "Model Number:" + " " + ModelNumber +
//               "Capacity:" + " " + Capacity +
//               "Speed Interface" + " " + speed;
//        }
//    }


//    class Program
//    {
//        static void Main(string[] args)
//        {

//        }
//    }
//}


namespace Program
{
    public abstract class Tank
    {
        public UInt16 Armour;
        public UInt16 Agility;
        public UInt16 Firepower;


        public void Print()
        {
            Console.WriteLine(
                $"\nFirepower: {Firepower}\n" +
                $"Agility: {Agility}\n" +
                $"Armour: {Armour}\n\n");
        }
    }

    class T34 : Tank
    {
        public T34()
        {
            Random rnd = new Random();

            Armour = Convert.ToUInt16(rnd.Next(1, 80));
            Agility = Convert.ToUInt16(rnd.Next(1, 120));
            Firepower = Convert.ToUInt16(rnd.Next(1, 90));
        }

        public static Tank operator *(T34 Ally, Panther Axis)
        {
            if
                 ((Ally.Agility > Axis.Agility && Ally.Armour > Axis.Armour) ||
                 (Ally.Firepower > Axis.Firepower && Ally.Armour > Axis.Firepower) ||
                 ((Ally.Armour > Axis.Armour && Ally.Agility > Axis.Agility) ||
                 (Ally.Armour > Axis.Armour && Ally.Agility > Axis.Agility && Ally.Firepower > Axis.Firepower)))
            {
                Console.WriteLine("Ally wins.");
                return Ally;
            }

            Console.WriteLine("Axis wins.");
            return Axis;
        }
    }

    class Panther : Tank
    {
        public Panther()
        {
            Random rnd = new Random();

            Armour = Convert.ToUInt16(rnd.Next(1, 130));
            Agility = Convert.ToUInt16(rnd.Next(1, 90));
            Firepower = Convert.ToUInt16(rnd.Next(1, 90));
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            List<T34> Allies = new List<T34>();
            List<Panther> Axis = new List<Panther>();

            for (int i = 0; i < 5; i++)
            {
                Allies.Add(new T34());
                Axis.Add(new Panther());
            }

            for (int i = 0; i < 5; i++)
            {
                var Tank = Allies[i] * Axis[i];
                Tank.Print();
            }
        }
    }

}