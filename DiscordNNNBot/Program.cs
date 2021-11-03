using System;
using System.Diagnostics;
using System.Text;
using System.IO;
using DSharpPlus.Entities;

namespace DiscordTTSBot
{
    class Program
    {
        public static Bot bot;
        
        static void Main(string[] args)
        {
            bot = new Bot();
            bot.RunAsync().GetAwaiter().GetResult();
        }
    }
}
