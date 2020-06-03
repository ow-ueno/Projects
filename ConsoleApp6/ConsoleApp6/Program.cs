using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    //演習2.1
    class Exam2_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.OutputEncoding = Encoding.UTF8;

            //インスタンスの生成と配列への格納
            //varが便利
            var songs = new List<Song>
            {
                AddSong("aaa","art",232)
                ,AddSong("bbb","art",240)
                ,AddSong("ccc","art",58)
                ,AddSong("ddd","art",310)
                ,AddSong("eee","art",420)
            };

            //2.1.4 コンソール出力
            foreach (Song s in songs)
            {
                Console.WriteLine("曲名は{0}です。アーティストは{1}で、演奏時間は{2:00}:{3:00}です。", s.Title,s.ArtistName,s.Length / 60,s.Length % 60);
            }

            //最後にきちんとコンソールを止める親切設計
            Console.WriteLine("Press Any Key...");
            Console.ReadKey();

        }

        static Song AddSong(string title, string artistname, int length)
        {
            Song song = new Song(title,artistname,length);
            return song;
        }

        //class in class
        class Song
        {
            public string Title { get; set; }
            public string ArtistName { get; set; }
            public int Length { get; set; }

            //コンストラクタ
            public Song(string title, string artistName, int length)
            {
                Title = title;
                ArtistName = artistName;
                Length = length;
            }
        }


    }

}