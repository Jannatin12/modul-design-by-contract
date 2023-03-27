using modul6_1302213051;
using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tenki no Ko1");
        SayaTubeVideo video1 = new SayaTubeVideo("Tenki no Ko2");
        SayaTubeVideo video2 = new SayaTubeVideo("Tenki no Ko3");
        SayaTubeVideo video3 = new SayaTubeVideo("Tenki no Ko4");
        SayaTubeVideo video4 = new SayaTubeVideo("Tenki no Ko5");
        SayaTubeVideo video5 = new SayaTubeVideo("Tenki no Ko6");
        SayaTubeVideo video6 = new SayaTubeVideo("Tenki no Ko7");
        SayaTubeVideo video7 = new SayaTubeVideo("Tenki no Ko8");
        SayaTubeVideo video8 = new SayaTubeVideo("Tenki no Ko8");
        SayaTubeVideo video9 = new SayaTubeVideo("Tenki no Ko9");
        SayaTubeUser user = new SayaTubeUser("Jannah");

        user.AddVideo(video);
        user.AddVideo(video1);
        user.AddVideo(video2);
        user.AddVideo(video3);
        user.AddVideo(video4);
        user.AddVideo(video5);
        user.AddVideo(video6);
        user.AddVideo(video7);
        user.AddVideo(video8);
        user.AddVideo(video9);

        user.PrintAllVideoPlayCount();
    }
}
