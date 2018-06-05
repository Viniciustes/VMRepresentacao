using System.Text.RegularExpressions;

namespace VMRepresentacao.Domain.Services
{
    public static class OnlyNumbersService
    {
        public static string OnlyNumbers(string number)
        {
            var onlyNumbers = new Regex(@"[^\d]");
            return onlyNumbers.Replace(number, "");
        }
    }
}
