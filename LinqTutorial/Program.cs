using System;
using System.Collections.Generic;
using System.Linq;
using LinqTutorial.MethodSyntax;

namespace LinqTutorial
{
    public static class StringExtensions
    {
        public static int GetCountOfLines(this string input)
        {
            return input.Split("\n").Length;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            //METHOD SYNTAX

            //Any.Run();
            //All.Run();
            //Count.Run();
            //Contains.Run();
            //OrderBy.Run();
            //MinMax.Run();
            //Average.Run();
            //Sum.Run();
            //ElementAt.Run();
            //FirstLast.Run();
            //SingleElement.Run();
            //Where.Run();
            //Take.Run();
            //Skip.Run();
            //OfType.Run();
            //Distinct.Run();
            //PrependAppend.Run();
            //ConcatUnion.Run();
            //TypeSwitching.Run();
            //Select.Run();
            //SelectMany.Run();
            //GeneratingNewCollection.Run();
            //GroupBy.Run();
            //IntersectExcept.Run();
            //Joins.Run();
            //Aggregate.Run();
            //Zip.Run();

            //QUERY SYNTAX

            //OrderBy.QuerySyntax.Run();
            //Where.QuerySyntax.Run();
            //Select.QuerySyntax.Run();
            //SelectMany.QuerySyntax.Run();
            //GroupBy.QuerySyntax.Run();
            //Joins.QuerySyntax.Run();

            //OTHERS
            //DotNet6Improvements.Run();

            /*            var words = new[] { "a", "bb", "ccc", "dddd" };
                        var wordsLongerThan2Letters = words.Where(word => word.Length > 2);

                        var multilineString = @"
                                                Lorem ipsum dolor sit amet,
                                                consectetur adipiscing elit.
                                                Quisque ultrices non mi quis molestie.
                                                Maecenas hendrerit sagittis risus.
                                                Cras quis orci eget risus mattis egestas quis sit amet metus.
                                                Ut eget tellus eget nunc efficitur lacinia et non purus.
                                                Quisque eu ultrices eros, at ornare lectus.";

                        var countOfLines = multilineString.GetCountOfLines();*/

            var numbers = new List<int> { 5, 3, 7, 1, 2, 4 };
            var numbersWith10 = numbers.Append(6);
            Console.WriteLine("Numbers: " + string.Join(", ", numbersWith10));

            Console.ReadKey();
        }
    }
}