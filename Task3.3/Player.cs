using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3
{
    internal class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Play");
        }

        public void Record()
        {
            Console.WriteLine("Record");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Pause of recording");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Stop of recording");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Pause of playing");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Stop of playing");
        }
    }
}
