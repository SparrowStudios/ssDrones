using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparrowStudios.Fivem.Project
{
    public static class Constants
    {
        public static class Commands
        {
            public const string PING = "ping";
        }

        public static class Events
        {
            private const string PREFIX = "SparrowStudios:Project:";

            public static class Client
            {
                public const string PONG = PREFIX + "Pong";
            }

            public static class Server
            {
                public const string PING = PREFIX + "Ping";
            }
        }
    }
}
