using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPlayable player = new Player();
            IRecodable record = new Player();
            player.Play();
            player.Pause();
            player.Stop();

            record.Record();
            record.Pause();
            record.Stop();
            Console.ReadLine();
        }
    }
}
