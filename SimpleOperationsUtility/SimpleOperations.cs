using System;
using System.Linq;
/// <summary>
/// This library is a test for a Nuget Server. This library is otherwise useless.
/// </summary>
namespace SimpleOperationsUtility
{
    public static class SimpleMath
    {
        public static addType Add<addType>(dynamic x, dynamic y) => (x + y);
        public static subType Subract<subType>(dynamic x, dynamic y) => (x - y);
        public static divType Divide<divType>(dynamic x, dynamic y) => (x / y);
        public static multType Multiply<multType>(dynamic x, dynamic y) => (x * y);
        public static modType Modulus<modType>(dynamic x, dynamic y) => (x % y);
        public static sqrType Square<sqrType>(dynamic x) => (x * x);
        public static sqrRootType SquartRoot<sqrRootType>(dynamic x) => Math.Sqrt(x);
    }

    public static class SimpleStrings
    {
        public static string Concat(string value1, string value2) => ($"{value1} {value2}");
        public static string RemoveWord(string value, string wordToRemove) =>
            (value.Remove(value.IndexOf(wordToRemove), wordToRemove.Count()));
        public static string AddWordToPosition(string value, string wordToAdd, int index) => ($"{value.Insert(index, wordToAdd)} ");
    }
}
