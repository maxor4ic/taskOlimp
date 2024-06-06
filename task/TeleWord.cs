namespace task
{
    public class TeleWord : IMethod
    {
        public List<string> Tele(string tele, List<string> words)
        {
            List<string> newWords = new List<string>();
            Dictionary<char, char[]> alphabet = new Dictionary<char, char[]> 
            {
                {'1', new char[]{'i', 'j' } },
                {'2', new char[]{'a', 'b', 'c' } },
                {'3', new char[]{'d', 'e', 'f' } },
                {'4', new char[]{'g', 'h' } },
                {'5', new char[]{'k', 'l' } },
                {'6', new char[]{'m', 'n' } },
                {'7', new char[]{'p', 'r', 's' } },
                {'8', new char[]{'t', 'u', 'v' } },
                {'9', new char[]{'w', 'x', 'y' } },
                {'0', new char[]{'o', 'q', 'z' } },
            };

            while (tele.Length != 0)
            {
                string tempWord = string.Empty;
                for (int i = 0; i < tele.Length; i++)
                {
                    char[] temp = alphabet[tele[i]];
                    for (int j = 0; j < temp.Length; j++)
                    {
                        for (int n = 0; n < words.Count; n++)
                        {
                            if (i < words[n].Length && words[n][i] == temp[j])
                            {
                                string _temp1 = tempWord + temp[j];
                                string _temp2 = string.Empty;
                                for (int v = 0; words[n][v] != temp[j]; v++)
                                {
                                    _temp2 += words[n][v];
                                }
                                _temp2 += temp[j];

                                if (_temp1 == _temp2)
                                {
                                    tempWord += temp[j];

                                    j = temp.Length;
                                    n = words.Count;
                                }
                            }
                        }
                    }
                }

                for (int m = 0; m < tempWord.Length; m++)
                {
                    tele = tele.Remove(0, 1);
                }
                newWords.Add(tempWord);

                if (tempWord.Length == 0)
                {
                    Console.WriteLine("\nNo solution.");
                    break;
                }
            }

            return newWords;
        }
    }
}
