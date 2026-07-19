public class Solution
        {
            public bool solution(string s)
            {
                int length = s.Length;
                if (length == 6 || length == 4)
                {
                    foreach (char c in s)
                    {
                        if (c < '0' || c > '9')
                        {
                            return false;
                        }
                    }

                    return true;
                }
                return false;
            }
        }