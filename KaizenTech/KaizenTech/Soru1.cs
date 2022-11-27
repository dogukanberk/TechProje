using System;

namespace KaizenTech
{
    public class Soru1
    {
        const string chars = "ACDEFGHKLMNPRTXYZ234579";


        private List<string> generateCode()
        {
            var stringChars = new char[8];
            var random = new Random();
            var codeList = new List<string>();

            for (int j = 0; j < 10000; j++)
            {
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];

                }

                var code = new String(stringChars);
                if (codeCheck(codeList ,code))
                {
                    codeList.Add(code);
                }

            }

            return codeList;
        }

        private bool codeCheck(List<string> list , string code)
        {
            var findCode = list.Find(x => x.Contains(code));
            if (findCode != null)
            {
                return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Soru1 p = new Soru1();
            var list = p.generateCode();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            //Console.WriteLine(list);
        }

    }

}