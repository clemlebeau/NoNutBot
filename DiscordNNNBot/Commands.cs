using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DiscordTTSBot
{
    class Commands : BaseCommandModule
    {
        [Command("progress")]
        public async Task Progress(CommandContext ctx)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine($"{now.Day},{now.Hour},{now.Minute}");
            await ctx.Channel.SendMessageAsync($"Current progress: **{Math.Floor((((float)now.Day - 1) + (((float)now.Hour + (float)now.Minute/60)/24))/30*10000)/100}**%").ConfigureAwait(false);
        }
    }
}
