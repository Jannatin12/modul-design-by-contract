using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213051
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            this.id = new Random().Next(10000, 99999);
            if (title.Length > 200 || title == null)
                throw new ArgumentException("Judul tidak boleh kosong dan tidak lebih dari 200");
            this.title = "Review Film " + title + " oleh Jannah";
            this.playCount = 0;
        }

        public string GetTitle()
        {
            return title;
        }

        public void IncreasePlayCount(int count)
        {
            if(count > 25000000)
            {
                throw new ArgumentException("Tidak boleh melebihi batas");
            }
            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException)
            {
                throw new ArgumentException("Play count melebihi batas");
            }

            if(count < 0)
            {
                throw new ArgumentException("Tidak boleh negatif");
            }
            try
            {
                checked { this.playCount -= count; }
            }
            catch (NullReferenceException)
            {
                throw new ArgumentException("Bernilai negatif");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID video: " + id);
            Console.WriteLine("Judul video: " + title);
            Console.WriteLine("Play count: " + playCount);
        }
    }
}
