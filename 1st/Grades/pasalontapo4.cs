using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class pasalontapo4
    {
        //static void Main(string[] args)
        //{
        //    GradeBook book = new GradeBook("Aido knygos");

        //    book.AddGrade(91f);
        //    book.AddGrade(89.1f);
        //    book.AddGrade(75f);

        //    GradeStatistics stats = book.ComputeStatistics();

        //    //int number = 20;
        //    //WriteBytes(number);
        //    //WriteBytes(stats.AverageGrade);

        //    //WriteNames("aidas", "scotas", "advidas", "davidas");

        //    //book.NameChanged = new NameChangedDelegate(OnNameChanged);
        //    book.NameChanged += OnNameChanged;
        //    book.NameChanged += OnNameChanged;
        //    book.NameChanged += OnNameChanged2;
        //    book.NameChanged -= OnNameChanged; // unsuscribina
        //    //book.NameChanged = new NameChangedDelegate(OnNameChanged2); //isvalys visus kitus kai delegate
        //    //jei eventas jau nebegalima deleguoti per new key word kaip virsui vina eilute, bus eroras
        //    book.Name = "Aido knygs";
        //    WriteNames(book.Name);

        //    Console.WriteLine(stats.AverageGrade);
        //    Console.WriteLine(stats.HighestGrade);
        //    Console.WriteLine(stats.LowestGrade);



        //}

        ////taip susitvarkoma kai eventas teisingas envtu rasymas
        //private static void OnNameChanged2(object sender, NameChangedEventArgs args)
        //{
        //    Console.WriteLine("##########***********############");
        //}

        //private static void OnNameChanged(object sender, NameChangedEventArgs args)
        //{
        //    Console.WriteLine("Name changed from {0} to {1}", args.OldValue, args.NewValue);
        //}



        //// cia prasideda kai su delegate
        ////private static void OnNameChanged2(string oldValue, string newValue)
        ////{
        ////    Console.WriteLine("##########***********############");
        ////}

        ////private static void OnNameChanged(string oldValue, string newValue)
        ////{
        ////    Console.WriteLine("Name changed from {0} to {1}", oldValue, newValue);
        ////}



        //private static void WriteBytes(float value)
        //{
        //    byte[] bytes = BitConverter.GetBytes(value);

        //    WriteByteArray(bytes);
        //}

        //private static void WriteBytes(int value)
        //{
        //    byte[] bytes = BitConverter.GetBytes(value);

        //    WriteByteArray(bytes);
        //}

        //private static void WriteByteArray(byte[] bytes)
        //{
        //    foreach (byte b in bytes)
        //    {
        //        Console.Write("0x{0:X}", b);
        //    }
        //    Console.WriteLine();
        //}

        //private static void WriteNames(params string[] names)
        //{
        //    foreach (string name in names)
        //    {
        //        Console.WriteLine(name);
        //    }
        //}
    }
}
