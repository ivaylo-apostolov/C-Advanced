using System;

namespace _12._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            //(?< customer > (?<=%)[A - Z][a - z]{ 1,} (?=%))
            //(?< product > (?<=<)[\w]{ 1,} (?=>))
            //(?< count > (?<=\|)[\d]{1,}(?=\|))
            //(?<price>[\d]{1,[.]{0,}[\d]{1,}(?=\$))
        }
    }
}
