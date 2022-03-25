using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace TPmodul5_1302200052
{
    internal class SayaTubeVideo
    {
        private int id, playCount;
        private string title;

        public SayaTubeVideo(string title)
        {
            this.title = title;
            var a = this.title.Substring(0, Math.Min(100, this.title.Length));
            Contract.Requires(this.title != null);
            String number = "";
            Random rnd = new Random();
            id = rnd.Next(1, 100000);
            number += id.ToString("D5");
            playCount = 0;
        }

        public void IncreasePlayCount(int x)
        {
            if (x <= 10000000)
            {
                for (playCount = 0; playCount <= x; playCount++)
                {

                }
                int z = 0;
                try
                {
                    z = checked(x + 10);
                }
                catch (System.OverflowException e)
                {
                    Console.WriteLine("Check : " + e.ToString());
                    Console.WriteLine("Melebihi batas input");
                }
            }

        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID :"+id +", Judul :"+ title +", Jumlah play :"+ playCount);
        }
    }
}
