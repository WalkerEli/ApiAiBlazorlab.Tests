using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAiBlazorLab.Tests
{
    public static class TextUtilities

    {

        public static string NormalizeFact(string? fact)

        {

            if (string.IsNullOrWhiteSpace(fact))

                return "No fact available.";


            fact = fact.Trim();


            return fact.EndsWith(".") ? fact : fact + ".";

        }

    }
}
