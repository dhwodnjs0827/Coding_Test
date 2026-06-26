public class Solution
    {
        public int solution(int[,] signals)
        {
            // 신호등 갯수
            int n = signals.GetLength(0);

            // 모든 신호등의 주기
            int[] periods = new int[n];
            for (int i = 0; i < n; i++)
            {
                // 신호등 주기 = 초록불 시간 + 노란불 시간 + 빨간불 시간
                periods[i] = signals[i, 0] + signals[i, 1] + signals[i, 2];
            }

            // 모든 신호등 주기의 최소공배수
            long totalLCM = 1;
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
        
        /// <summary>
        /// 특정 신호등의 노란불 여부
        /// </summary>
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