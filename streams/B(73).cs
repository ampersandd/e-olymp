using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Olymp
{
    class Program
    {

        public class gtr
        {
            public int[,] capacity = new int[n, n];
            public long[,] flow = new long[n, n];
            int[] color = new int[n];
            int[] pred = new int[n];
            int head, tail;
            int[] q = new int[n];
            int WHITE = 0;
            int GREY = 1;
            int BLACK = 2;
            long min(long x, long y)
            {
                if (x < y) return x; else return y;
            }
            void enque(int x)
            {
                q[tail] = x;
                tail++;
                color[x] = GREY;
            }
            int deque()
            {
                int x = q[head];
                head++;
                color[x] = BLACK;
                return x;
            }
            int bfs(int start, int end)
            {
                int u;
                for (int i = 0; i < n; i++)
                    color[i] = WHITE;
                for (int i = 0; i < n; i++)
                {
                    pred[i] = 0;
                }
                head = 0;
                tail = 0;
                enque(start);
                pred[start] = -1;
                while (head != tail)
                {
                    u = deque();
                    for (int v = 0; v < n; v++)
                    {
                        if (color[v] == WHITE && (capacity[u, v] - flow[u, v]) > 0)
                        {
                            enque(v);
                            pred[v] = u;
                        }
                    }
                }
                if (color[end] == BLACK)
                    return 0;
                else return 1;
            }
            public void path(int vv)
            {
                if (vv != 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (i == vv && pred[i] != -1)
                        {
                            delta = min(delta, (capacity[pred[i], i] - flow[pred[i], i]));
                            path(pred[i]);
                            flow[pred[i], i] += delta;
                            flow[i, pred[i]] -= delta;
                        }
                    }

                }
            }
            public long max_flow()
            {
                long maxflow = 0;
                while (bfs(0, n - 1) == 0)
                {
                    delta = long.MaxValue;
                    path(n - 1);
                    maxflow += delta;
                }
                return maxflow;
            }
        }

        static long delta = long.MaxValue;
        static int n;
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(new char[] { ' ' });
            n = Convert.ToInt32(s[0]);
            int m = Convert.ToInt32(s[1]);

            gtr t = new gtr();
            for (int i = 0; i < m; i++)
            {
                string[] s2 = Console.ReadLine().Split(new char[] { ' ' });
                t.capacity[Convert.ToInt32(s2[0]) - 1, Convert.ToInt32(s2[1]) - 1] = Convert.ToInt32(s2[2]);

            }

            Console.WriteLine(t.max_flow());
            Console.ReadKey();
        }
    }
}