using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace df_df.World
{
    class Level
    {
        public int[][] floor { get; set; }
        int dwidth = 20;
        int dheight = 20;

        public Level()
        {
            init();
        }

        public void init()
        {
            floor = new int[dwidth][];
            for (int a = 0; a < floor.Length; a++)
            {
                floor[a] = new int[dheight];
            }

            for (int x = 0; x < floor.Length; x++)
            {
                for (int y = 0; y < floor[x].Length; y++)
                {
                    floor[x][y] = y;
                }
            }
        }
    }
}