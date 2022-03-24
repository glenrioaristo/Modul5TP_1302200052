using System;

namespace TPmodul5_1302200052
{
    internal class program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – glen rio aristo");
            video.IncreasePlayCount(18);
            video.PrintVideoDetails();
        }
    }
}