public class Solution
    {
        public int solution(int[,] signals)
        {
            int n = signals.GetLength(0);

            int[] periods = new int[n];
            for (int i = 0; i < n; i++)
            {
                periods[i] = signals[i, 0] + signals[i, 1] + signals[i, 2];
            }

            long totalLCM = 1L;
            for (int i = 0; i < n; i++)
            {
                totalLCM = LCM(totalLCM, periods[i]);
            }

            for (long t = 1; t <= totalLCM; t++)
            {
                bool allYellow = true;
                for (int i = 0; i < n; i++)
                {
                    if (!IsYellow(signals, i, t))
                    {
                        allYellow = false;
                        break;
                    }
                }

                if (allYellow)
                {
                    return (int)t;
                }
            }
            
            return -1;
        }

        private bool IsYellow(int[,] signals, int i, long t)
        {
            int Green = signals[i, 0];
            int Yellow = signals[i, 1];
            int Red = signals[i, 2];
            
            int period = Green + Yellow + Red;
            long pos = (t - 1) % period;
            return pos >= Green && pos < Green + Yellow;
        }

        /// <summary>
        /// 최대공약수
        /// </summary>
        private static long GCD(long a, long b)
        {
            while (b != 0)
            {
                (a, b) = (b, a % b);
            }
            
            return a;
        }

        /// <summary>
        /// 최소공배수
        /// </summary>
        private static long LCM(long a, long b)
        {
            return a * b /  GCD(a, b);
        }
    }