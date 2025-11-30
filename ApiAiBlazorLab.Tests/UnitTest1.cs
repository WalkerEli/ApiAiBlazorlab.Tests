namespace ApiAiBlazorLab.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
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
}