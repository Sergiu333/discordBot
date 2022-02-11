using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;


namespace Discord_Bot_Tut
{
    class Program
    {
        DiscordSocketClient client;
        static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();

        private async Task MainAsync()
        {
            client = new DiscordSocketClient();
            client.MessageReceived += CommandsHandler;
            client.Log += Log;

            var token = "OTQxMzE4NTM3NjczMzEwMjYw.YgUNNA.vUCpMc2jS2cqbAMJIDLIjcjG3k4";

            await client.LoginAsync(TokenType.Bot, token);
            await client.StartAsync();

            Console.ReadLine();
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
        

        private Task CommandsHandler(SocketMessage msg)
        {
            if (!msg.Author.IsBot)
                switch (msg.Content)
                {
                    case "zd":
                    {
                        msg.Channel.SendMessageAsync($"zdarova , {msg.Timestamp}");
                        break;
                    }
                    case "random":
                    {
                        Random rnd = new Random();
                        msg.Channel.SendMessageAsync($"nr random {rnd.Next(-1000, 1000)}");
                        break;
                    }
                    case "mateha":
                    {
                        Random rnd = new Random();
                        msg.Channel.SendMessageAsync($"Lectia de Matemateca -> https://meet.google.com/yqi-bdbq-sss");
                        break;
                    }
                    case "info":
                    {
                        Random rnd = new Random();
                        msg.Channel.SendMessageAsync($"Lectia de Informateca -> https://meet.google.com/jiw-qdsq-wux");
                        break;
                    }
                    case "psihologia":
                    {
                        Random rnd = new Random();
                        msg.Channel.SendMessageAsync($"Lectia de Psihologia social-economică -> https://meet.google.com/svg-xsbf-mdc");
                        break;
                    }
                    case "protectia":
                    {
                        Random rnd = new Random();
                        msg.Channel.SendMessageAsync($"Lectia de Protecția Civilă -> https://meet.google.com/rpp-oktv-ozf");
                        break;
                    }
                    case "franceza":
                    {
                        Random rnd = new Random();
                        msg.Channel.SendMessageAsync($"Lectia de Limba franceză -> https://meet.google.com/tux-dajs-wfv");
                        break;
                    }
                    case "fr":
                    {
                        Random rnd = new Random();
                        msg.Channel.SendMessageAsync($"Lectia de Limba franceză -> https://meet.google.com/tux-dajs-wfv");
                        break;
                    }
                    case "jumbei":
                    {
                        Random rnd = new Random();
                        msg.Channel.SendMessageAsync($"Lectia de c# -> https://meet.google.com/erx-kwyc-dtx");
                        break;
                    }
                    case "c#":
                    {
                        Random rnd = new Random();
                        msg.Channel.SendMessageAsync($"Lectia de c# -> https://meet.google.com/erx-kwyc-dtx");
                        break;
                    }
                    case "c++":
                    {
                        Random rnd = new Random();
                        msg.Channel.SendMessageAsync($"Lectia de Utilizarea Tehnicilor Clasice de Programare -> https://meet.google.com/zie-uoid-oxv");
                        break;
                    }
                    case "tehnici de programare":
                    {
                        Random rnd = new Random();
                        msg.Channel.SendMessageAsync($"Lectia de Utilizarea Tehnicilor Clasice de Programare -> https://meet.google.com/zie-uoid-oxv");
                        break;
                    }
                    case "societatea":
                    {
                        Random rnd = new Random();
                        msg.Channel.SendMessageAsync($"Lectia de Educație pentru societate -> https://moodle1.ceiti.md/course/view.php?id=544 aici mai bine intrati pe moodle ca pune absente");
                        break;
                    }
                    case "romana":
                    {
                        Random rnd = new Random();
                        msg.Channel.SendMessageAsync($"Lectia de Limba Romana ->https://meet.google.com/bxy-dxsz-gyk?authuser=0&hl=ro ");
                        break;
                    }
                    case "istoria":
                    {
                        Random rnd = new Random();
                        msg.Channel.SendMessageAsync($"Lectia de Istorie -> https://moodle1.ceiti.md/course/view.php?id=651 aici mai bine intrati pe moodle ca pune absente");
                        break;
                    }
                    case "borito":
                    {
                        Random rnd = new Random();
                        msg.Channel.SendMessageAsync($"Lectia de Fizica ->https://meet.google.com/gkx-ybzc-mim?authuser=0");
                        break;
                    }
                    case "fizica":
                    {
                        Random rnd = new Random();
                        msg.Channel.SendMessageAsync($"Lectia de Fizica ->https://meet.google.com/gkx-ybzc-mim?authuser=0");
                        break;
                    }
                    case "geo":
                    {
                        Random rnd = new Random();
                        msg.Channel.SendMessageAsync($"Lectia de Geografie ->https://meet.google.com/gza-hdbi-esn");
                        break;
                    }
                    case "geografia":
                    {
                        Random rnd = new Random();
                        msg.Channel.SendMessageAsync($"Lectia de Geografie ->https://meet.google.com/gza-hdbi-esn");
                        break;
                    }
                    case "ed fiz":
                    {
                        Random rnd = new Random();
                        msg.Channel.SendMessageAsync($"Lectia de Educatie Fizica ->https://meet.google.com/zyj-vkkx-gek");
                        break;
                    }
                    case "sport":
                    {
                        Random rnd = new Random();
                        msg.Channel.SendMessageAsync($"Lectia de Educatie Fizica ->https://meet.google.com/zyj-vkkx-gek");
                        break;
                    }
                    case "engleza":
                    {
                        Random rnd = new Random();
                        msg.Channel.SendMessageAsync($"Lectia de engleza ->https://meet.google.com/sfc-gpgx-ifk");
                        break;
                    }
                    case "en":
                    {
                        Random rnd = new Random();
                        msg.Channel.SendMessageAsync($"Lectia de engleza ->https://meet.google.com/sfc-gpgx-ifk");
                        break;
                    }
                  
                    case "help":
                    {
                        Random rnd = new Random();
                        msg.Channel.SendMessageAsync($"Comenzile disponibile:\n" +
                                                     $"1: orar\n" +
                                                     $"2: mateha\n" +
                                                     $"3: info\n" +
                                                     $"4: psihologia\n" +
                                                     $"5: protectia\n" +
                                                     $"6: franceza sau fr\n" +
                                                     $"7: jumbei sau c#\n" +
                                                     $"8: tehnici de programare sau c++\n" +
                                                     $"9: societatea\n" +
                                                     $"10: romana\n" +
                                                     $"11: istoria\n" +
                                                     $"12: fizica sau borito\n" +
                                                     $"13: geografia sau geo\n" +
                                                     $"14: ed fiz sau sport\n" +
                                                     $"15: engleza sau en\n" +
                                                     $"16: help sau lectii\n" +
                                                     $"17: ceiti\n" +
                                                     $"18: moodle\n" +
                                                     $"19: vasilisk");
                        
                        break;
                    }
                    case "lectii":
                    {
                        Random rnd = new Random();
                        msg.Channel.SendMessageAsync($"Comenzile disponibile:\n" +
                                                     $"1: orar\n" +
                                                     $"2: mateha\n" +
                                                     $"3: info\n" +
                                                     $"4: psihologia\n" +
                                                     $"5: protectia\n" +
                                                     $"6: franceza sau fr\n" +
                                                     $"7: jumbei sau c#\n" +
                                                     $"8: tehnici de programare sau c++\n" +
                                                     $"9: societatea\n" +
                                                     $"10: romana\n" +
                                                     $"11: istoria\n" +
                                                     $"12: fizica sau borito\n" +
                                                     $"13: geografia sau geo\n" +
                                                     $"14: ed fiz sau sport\n" +
                                                     $"15: engleza sau en\n" +
                                                     $"16: help sau lectii\n" +
                                                     $"17: ceiti\n" +
                                                     $"18: moodle\n" +
                                                     $"19: vasilisk");
                        break;
                    }
                    case "ceiti":
                    {
                        Random rnd = new Random();
                            msg.Channel.SendMessageAsync($"https://ceiti.md/");
                        break;
                    }
                    case "sax":
                    {
                        Random rnd = new Random();
                        msg.Channel.SendMessageAsync($"sasati");
                        break;
                    }
                    case "orar":
                    {
                        
                        msg.Channel.SendMessageAsync($"Orarul lectiilor -> https://orar.ceiti.md/");
                        msg.Channel.SendFileAsync("C:\\Users\\sergiu\\RiderProjects\\discordBot\\discordBot\\img\\orar2.png","Vineri ");
                        msg.Channel.SendFileAsync("C:\\Users\\sergiu\\RiderProjects\\discordBot\\discordBot\\img\\orar.png","Luni");
                       
                        break;
                    }
                    case "moodle":
                    {
                        msg.Channel.SendMessageAsync($"https://moodle1.ceiti.md/login/index.php");
                        break;
                    }
                    case "m4a1s vasilisk":
                    {
                        msg.Channel.SendMessageAsync($"https://steamcommunity.com/market/listings/730/M4A1-S%20%7C%20Basilisk%20%28Field-Tested%29");
                        break;
                    }
                    
                }
            return Task.CompletedTask;
        }
    }
}
