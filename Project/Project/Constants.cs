using SparrowStudios.Fivem.ssDrones.Models;
using System.Collections.Generic;

namespace SparrowStudios.Fivem.ssDrones
{
    public static class Constants
    {
        public static class Commands
        {
            public const string DRONE = "drone";
        }

        public static class Events
        {
            private const string PREFIX = "SparrowStudios:ssDrones:";

            public static class Client
            {
                public const string DRONE_COMMAND = PREFIX + "DroneCommand";
            }

            public static class Server
            {
                public const string PING = PREFIX + "Ping";
            }
        }

        public static class Drones
        {
            public static readonly IList<Drone> List = new List<Drone>()
            {
                BasitDrone
            };

            public static Drone BasitDrone = new DroneBuilder()
                .SetName("Basit Drone")
                .SetModel("ch_prop_casino_drone_02a")
                .EnableInfared()
                .EnableNightVision()
                .SetSpeed(1.0f)
                .SetAgility(1.0f)
                .SetRange(250.0f)
                .Build();
        }

        public static class Controls
        {
            public static class Movement
            {
                public static DroneControl FORWARD = new DroneControl("Move Forward", (int)GameControls.INPUT_MOVE_UP_ONLY);
                public static DroneControl BACKWARDS = new DroneControl("Move Backwards", (int)GameControls.INPUT_MOVE_DOWN_ONLY);
                public static DroneControl LEFT = new DroneControl("Move Left", (int)GameControls.INPUT_MOVE_LEFT_ONLY);
                public static DroneControl RIGHT = new DroneControl("Move Right", (int)GameControls.INPUT_MOVE_RIGHT_ONLY);
                public static DroneControl DOWN = new DroneControl("Move Down", (int)GameControls.INPUT_SPRINT);
                public static DroneControl UP = new DroneControl("Move Up", (int)GameControls.INPUT_JUMP);
            }

            public static class Camera
            {
                public static DroneControl UP = new DroneControl("Camera Up", (int)GameControls.INPUT_VEH_FLY_PITCH_UP_ONLY);
                public static DroneControl DOWN = new DroneControl("Camera Down", (int)GameControls.INPUT_VEH_FLY_PITCH_UP_ONLY);
                public static DroneControl LEFT = new DroneControl("Camera Left", (int)GameControls.INPUT_VEH_FLY_ROLL_LEFT_ONLY);
                public static DroneControl RIGHT = new DroneControl("Camera Right", (int)GameControls.INPUT_VEH_FLY_ROLL_RIGHT_ONLY);
                public static DroneControl CENTER = new DroneControl("Camera Center", (int)GameControls.INPUT_FRONTEND_DELETE);
            }

            public static class Heading
            {
                public static DroneControl RIGHT = new DroneControl("Heading Right", (int)GameControls.INPUT_CONTEXT);
                public static DroneControl LEFT = new DroneControl("Heading Left", (int)GameControls.INPUT_CONTEXT_SECONDARY);
            }

            public static class Zoom
            {
                public static DroneControl OUT = new DroneControl("Zoom Out", (int)GameControls.INPUT_SELECT_NEXT_WEAPON);
                public static DroneControl IN = new DroneControl("Zoom In", (int)GameControls.INPUT_SELECT_PREV_WEAPON);
            }

            public static DroneControl TOGGLE_NIGHTVISION = new DroneControl("Toggle Nightvision", (int)GameControls.INPUT_MELEE_ATTACK_LIGHT);
            public static DroneControl TOGGLE_INFARED = new DroneControl("Toggle Infared", (int)GameControls.INPUT_VEH_EXIT);
            public static DroneControl DISCONNECT = new DroneControl("Disconnect", (int)GameControls.INPUT_FRONTEND_PAUSE_ALTERNATE);
        }
    }
}
