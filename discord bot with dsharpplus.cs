using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using DSharpPlus;
using DSharpPlus.EventArgs;


namespace Discord_Botu

{
    class Program
    {
        static DiscordClient discord;
        private static object e;

        static void Main(string[] args)
        {
            MainAsync(args).ConfigureAwait(false).GetAwaiter().GetResult();
        }
        static async Task MainAsync(string[] args)
        {

            discord = new DiscordClient(new DiscordConfiguration
            {
                Token = "your.bot.token",
                TokenType = TokenType.Bot
            });


                      discord.MessageCreated += async e =>
            {

                {
                     
                    // This block of code responds to what you write
                    if (e.Message.Content.ToLower() == "I'm going to bed")
                    {
                        e.Message.RespondAsync("Good Night");
                    }
                }

            };

            await discord.ConnectAsync();
            await Task.Delay(-1);


        }

        private static Task async(DiscordClient sender, MessageCreateEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
