using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPmodul5_1302200052
{
    internal class SayaTubeVideo
    {
        private int id, playCount;
        private string title;

        public SayaTubeVideo (string title)
        {

            this.title = title;
            playCount = 0;

            Random rndm = new Random();
            id = rndm.Next(10000,99999);//returns random integers < 10
            
          
        }

        public void IncreasePlayCount(int x)
        {
            playCount = x;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID :"+id +", Judul :"+ title +", Jumlah play :"+ playCount);
        }
    }
}
