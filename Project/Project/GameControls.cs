using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparrowStudios.Fivem.ssDrones
{
    public enum GameControls
    {
        /// <summary>
        /// Default QWERTY: V
        /// <br/>
        /// Xbox Controller: BACK
        /// </summary>
        INPUT_NEXT_CAMERA = 0,

        /// <summary>
        /// Default QWERTY: MOUSE RIGHT
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_LOOK_LR = 1,

        /// <summary>
        /// Default QWERTY: MOUSE DOWN
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_LOOK_UD = 2,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_LOOK_UP_ONLY = 3,

        /// <summary>
        /// Default QWERTY: MOUSE DOWN
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_LOOK_DOWN_ONLY = 4,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_LOOK_LEFT_ONLY = 5,

        /// <summary>
        /// Default QWERTY: MOUSE RIGHT
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_LOOK_RIGHT_ONLY = 6,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: R3
        /// </summary>
        INPUT_CINEMATIC_SLOWMO = 7,

        /// <summary>
        /// Default QWERTY: S
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_SCRIPTED_FLY_UD = 8,

        /// <summary>
        /// Default QWERTY: D
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_SCRIPTED_FLY_LR = 9,

        /// <summary>
        /// Default QWERTY: PAGEUP
        /// <br/>
        /// Xbox Controller: LT
        /// </summary>
        INPUT_SCRIPTED_FLY_ZUP = 10,

        /// <summary>
        /// Default QWERTY: PAGEDOWN
        /// <br/>
        /// Xbox Controller: RT
        /// </summary>
        INPUT_SCRIPTED_FLY_ZDOWN = 11,

        /// <summary>
        /// Default QWERTY: MOUSE DOWN
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_WEAPON_WHEEL_UD = 12,

        /// <summary>
        /// Default QWERTY: MOUSE RIGHT
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_WEAPON_WHEEL_LR = 13,

        /// <summary>
        /// Default QWERTY: SCROLLWHEEL DOWN
        /// <br/>
        /// Xbox Controller: DPAD RIGHT
        /// </summary>
        INPUT_WEAPON_WHEEL_NEXT = 14,

        /// <summary>
        /// Default QWERTY: SCROLLWHEEL UP
        /// <br/>
        /// Xbox Controller: DPAD LEFT
        /// </summary>
        INPUT_WEAPON_WHEEL_PREV = 15,

        /// <summary>
        /// Default QWERTY: SCROLLWHEEL DOWN
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_SELECT_NEXT_WEAPON = 16,

        /// <summary>
        /// Default QWERTY: SCROLLWHEEL UP
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_SELECT_PREV_WEAPON = 17,

        /// <summary>
        /// Default QWERTY: ENTER / LEFT MOUSE BUTTON / SPACEBAR
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_SKIP_CUTSCENE = 18,

        /// <summary>
        /// Default QWERTY: LEFT ALT
        /// <br/>
        /// Xbox Controller: DPAD DOWN
        /// </summary>
        INPUT_CHARACTER_WHEEL = 19,

        /// <summary>
        /// Default QWERTY: Z
        /// <br/>
        /// Xbox Controller: DPAD DOWN
        /// </summary>
        INPUT_MULTIPLAYER_INFO = 20,

        /// <summary>
        /// Default QWERTY: LEFT SHIFT
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_SPRINT = 21,

        /// <summary>
        /// Default QWERTY: SPACEBAR
        /// <br/>
        /// Xbox Controller: X
        /// </summary>
        INPUT_JUMP = 22,

        /// <summary>
        /// Default QWERTY: F
        /// <br/>
        /// Xbox Controller: Y
        /// </summary>
        INPUT_ENTER = 23,

        /// <summary>
        /// Default QWERTY: LEFT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: RT
        /// </summary>
        INPUT_ATTACK = 24,

        /// <summary>
        /// Default QWERTY: RIGHT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: LT
        /// </summary>
        INPUT_AIM = 25,

        /// <summary>
        /// Default QWERTY: C
        /// <br/>
        /// Xbox Controller: R3
        /// </summary>
        INPUT_LOOK_BEHIND = 26,

        /// <summary>
        /// Default QWERTY: ARROW UP / SCROLLWHEEL BUTTON (PRESS)
        /// <br/>
        /// Xbox Controller: DPAD UP
        /// </summary>
        INPUT_PHONE = 27,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: L3
        /// </summary>
        INPUT_SPECIAL_ABILITY = 28,

        /// <summary>
        /// Default QWERTY: B
        /// <br/>
        /// Xbox Controller: R3
        /// </summary>
        INPUT_SPECIAL_ABILITY_SECONDARY = 29,

        /// <summary>
        /// Default QWERTY: D
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_MOVE_LR = 30,

        /// <summary>
        /// Default QWERTY: S
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_MOVE_UD = 31,

        /// <summary>
        /// Default QWERTY: W
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_MOVE_UP_ONLY = 32,

        /// <summary>
        /// Default QWERTY: S
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_MOVE_DOWN_ONLY = 33,

        /// <summary>
        /// Default QWERTY: A
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_MOVE_LEFT_ONLY = 34,

        /// <summary>
        /// Default QWERTY: D
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_MOVE_RIGHT_ONLY = 35,

        /// <summary>
        /// Default QWERTY: LEFT CTRL
        /// <br/>
        /// Xbox Controller: L3
        /// </summary>
        INPUT_DUCK = 36,

        /// <summary>
        /// Default QWERTY: TAB
        /// <br/>
        /// Xbox Controller: LB
        /// </summary>
        INPUT_SELECT_WEAPON = 37,

        /// <summary>
        /// Default QWERTY: E
        /// <br/>
        /// Xbox Controller: LB
        /// </summary>
        INPUT_PICKUP = 38,

        /// <summary>
        /// Default QWERTY: [
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_SNIPER_ZOOM = 39,

        /// <summary>
        /// Default QWERTY: ]
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_SNIPER_ZOOM_IN_ONLY = 40,

        /// <summary>
        /// Default QWERTY: [
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_SNIPER_ZOOM_OUT_ONLY = 41,

        /// <summary>
        /// Default QWERTY: ]
        /// <br/>
        /// Xbox Controller: DPAD UP
        /// </summary>
        INPUT_SNIPER_ZOOM_IN_SECONDARY = 42,

        /// <summary>
        /// Default QWERTY: [
        /// <br/>
        /// Xbox Controller: DPAD DOWN
        /// </summary>
        INPUT_SNIPER_ZOOM_OUT_SECONDARY = 43,

        /// <summary>
        /// Default QWERTY: Q
        /// <br/>
        /// Xbox Controller: RB
        /// </summary>
        INPUT_COVER = 44,

        /// <summary>
        /// Default QWERTY: R
        /// <br/>
        /// Xbox Controller: B
        /// </summary>
        INPUT_RELOAD = 45,

        /// <summary>
        /// Default QWERTY: E
        /// <br/>
        /// Xbox Controller: DPAD RIGHT
        /// </summary>
        INPUT_TALK = 46,

        /// <summary>
        /// Default QWERTY: G
        /// <br/>
        /// Xbox Controller: DPAD LEFT
        /// </summary>
        INPUT_DETONATE = 47,

        /// <summary>
        /// Default QWERTY: Z
        /// <br/>
        /// Xbox Controller: DPAD DOWN
        /// </summary>
        INPUT_HUD_SPECIAL = 48,

        /// <summary>
        /// Default QWERTY: F
        /// <br/>
        /// Xbox Controller: Y
        /// </summary>
        INPUT_ARREST = 49,

        /// <summary>
        /// Default QWERTY: SCROLLWHEEL DOWN
        /// <br/>
        /// Xbox Controller: R3
        /// </summary>
        INPUT_ACCURATE_AIM = 50,

        /// <summary>
        /// Default QWERTY: E
        /// <br/>
        /// Xbox Controller: DPAD RIGHT
        /// </summary>
        INPUT_CONTEXT = 51,

        /// <summary>
        /// Default QWERTY: Q
        /// <br/>
        /// Xbox Controller: DPAD LEFT
        /// </summary>
        INPUT_CONTEXT_SECONDARY = 52,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: Y
        /// </summary>
        INPUT_WEAPON_SPECIAL = 53,

        /// <summary>
        /// Default QWERTY: E
        /// <br/>
        /// Xbox Controller: DPAD RIGHT
        /// </summary>
        INPUT_WEAPON_SPECIAL_TWO = 54,

        /// <summary>
        /// Default QWERTY: SPACEBAR
        /// <br/>
        /// Xbox Controller: RB
        /// </summary>
        INPUT_DIVE = 55,

        /// <summary>
        /// Default QWERTY: F9
        /// <br/>
        /// Xbox Controller: Y
        /// </summary>
        INPUT_DROP_WEAPON = 56,

        /// <summary>
        /// Default QWERTY: F10
        /// <br/>
        /// Xbox Controller: B
        /// </summary>
        INPUT_DROP_AMMO = 57,

        /// <summary>
        /// Default QWERTY: G
        /// <br/>
        /// Xbox Controller: DPAD LEFT
        /// </summary>
        INPUT_THROW_GRENADE = 58,

        /// <summary>
        /// Default QWERTY: D
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_MOVE_LR = 59,

        /// <summary>
        /// Default QWERTY: LEFT CTRL
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_MOVE_UD = 60,

        /// <summary>
        /// Default QWERTY: LEFT SHIFT
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_MOVE_UP_ONLY = 61,

        /// <summary>
        /// Default QWERTY: LEFT CTRL
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_MOVE_DOWN_ONLY = 62,

        /// <summary>
        /// Default QWERTY: A
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_MOVE_LEFT_ONLY = 63,

        /// <summary>
        /// Default QWERTY: D
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_MOVE_RIGHT_ONLY = 64,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_VEH_SPECIAL = 65,

        /// <summary>
        /// Default QWERTY: MOUSE RIGHT
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_VEH_GUN_LR = 66,

        /// <summary>
        /// Default QWERTY: MOUSE DOWN
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_VEH_GUN_UD = 67,

        /// <summary>
        /// Default QWERTY: RIGHT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: LB
        /// </summary>
        INPUT_VEH_AIM = 68,

        /// <summary>
        /// Default QWERTY: LEFT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: RB
        /// </summary>
        INPUT_VEH_ATTACK = 69,

        /// <summary>
        /// Default QWERTY: RIGHT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_VEH_ATTACK2 = 70,

        /// <summary>
        /// Default QWERTY: W
        /// <br/>
        /// Xbox Controller: RT
        /// </summary>
        INPUT_VEH_ACCELERATE = 71,

        /// <summary>
        /// Default QWERTY: S
        /// <br/>
        /// Xbox Controller: LT
        /// </summary>
        INPUT_VEH_BRAKE = 72,

        /// <summary>
        /// Default QWERTY: X
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_VEH_DUCK = 73,

        /// <summary>
        /// Default QWERTY: H
        /// <br/>
        /// Xbox Controller: DPAD RIGHT
        /// </summary>
        INPUT_VEH_HEADLIGHT = 74,

        /// <summary>
        /// Default QWERTY: F
        /// <br/>
        /// Xbox Controller: Y
        /// </summary>
        INPUT_VEH_EXIT = 75,

        /// <summary>
        /// Default QWERTY: SPACEBAR
        /// <br/>
        /// Xbox Controller: RB
        /// </summary>
        INPUT_VEH_HANDBRAKE = 76,

        /// <summary>
        /// Default QWERTY: W
        /// <br/>
        /// Xbox Controller: LT
        /// </summary>
        INPUT_VEH_HOTWIRE_LEFT = 77,

        /// <summary>
        /// Default QWERTY: S
        /// <br/>
        /// Xbox Controller: RT
        /// </summary>
        INPUT_VEH_HOTWIRE_RIGHT = 78,

        /// <summary>
        /// Default QWERTY: C
        /// <br/>
        /// Xbox Controller: R3
        /// </summary>
        INPUT_VEH_LOOK_BEHIND = 79,

        /// <summary>
        /// Default QWERTY: R
        /// <br/>
        /// Xbox Controller: B
        /// </summary>
        INPUT_VEH_CIN_CAM = 80,

        /// <summary>
        /// Default QWERTY: .
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_VEH_NEXT_RADIO = 81,

        /// <summary>
        /// Default QWERTY: ,
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_VEH_PREV_RADIO = 82,

        /// <summary>
        /// Default QWERTY: =
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_VEH_NEXT_RADIO_TRACK = 83,

        /// <summary>
        /// Default QWERTY: -
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_VEH_PREV_RADIO_TRACK = 84,

        /// <summary>
        /// Default QWERTY: Q
        /// <br/>
        /// Xbox Controller: DPAD LEFT
        /// </summary>
        INPUT_VEH_RADIO_WHEEL = 85,

        /// <summary>
        /// Default QWERTY: E
        /// <br/>
        /// Xbox Controller: L3
        /// </summary>
        INPUT_VEH_HORN = 86,

        /// <summary>
        /// Default QWERTY: W
        /// <br/>
        /// Xbox Controller: RT
        /// </summary>
        INPUT_VEH_FLY_THROTTLE_UP = 87,

        /// <summary>
        /// Default QWERTY: S
        /// <br/>
        /// Xbox Controller: LT
        /// </summary>
        INPUT_VEH_FLY_THROTTLE_DOWN = 88,

        /// <summary>
        /// Default QWERTY: A
        /// <br/>
        /// Xbox Controller: LB
        /// </summary>
        INPUT_VEH_FLY_YAW_LEFT = 89,

        /// <summary>
        /// Default QWERTY: D
        /// <br/>
        /// Xbox Controller: RB
        /// </summary>
        INPUT_VEH_FLY_YAW_RIGHT = 90,

        /// <summary>
        /// Default QWERTY: RIGHT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: LT
        /// </summary>
        INPUT_VEH_PASSENGER_AIM = 91,

        /// <summary>
        /// Default QWERTY: LEFT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: RT
        /// </summary>
        INPUT_VEH_PASSENGER_ATTACK = 92,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: R3
        /// </summary>
        INPUT_VEH_SPECIAL_ABILITY_FRANKLIN = 93,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_VEH_STUNT_UD = 94,

        /// <summary>
        /// Default QWERTY: MOUSE DOWN
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_VEH_CINEMATIC_UD = 95,

        /// <summary>
        /// Default QWERTY: NUMPAD- / SCROLLWHEEL UP
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_VEH_CINEMATIC_UP_ONLY = 96,

        /// <summary>
        /// Default QWERTY: NUMPAD+ / SCROLLWHEEL DOWN
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_VEH_CINEMATIC_DOWN_ONLY = 97,

        /// <summary>
        /// Default QWERTY: MOUSE RIGHT
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_VEH_CINEMATIC_LR = 98,

        /// <summary>
        /// Default QWERTY: SCROLLWHEEL UP
        /// <br/>
        /// Xbox Controller: X
        /// </summary>
        INPUT_VEH_SELECT_NEXT_WEAPON = 99,

        /// <summary>
        /// Default QWERTY: [
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_VEH_SELECT_PREV_WEAPON = 100,

        /// <summary>
        /// Default QWERTY: H
        /// <br/>
        /// Xbox Controller: DPAD RIGHT
        /// </summary>
        INPUT_VEH_ROOF = 101,

        /// <summary>
        /// Default QWERTY: SPACEBAR
        /// <br/>
        /// Xbox Controller: RB
        /// </summary>
        INPUT_VEH_JUMP = 102,

        /// <summary>
        /// Default QWERTY: E
        /// <br/>
        /// Xbox Controller: DPAD RIGHT
        /// </summary>
        INPUT_VEH_GRAPPLING_HOOK = 103,

        /// <summary>
        /// Default QWERTY: H
        /// <br/>
        /// Xbox Controller: DPAD RIGHT
        /// </summary>
        INPUT_VEH_SHUFFLE = 104,

        /// <summary>
        /// Default QWERTY: X
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_VEH_DROP_PROJECTILE = 105,

        /// <summary>
        /// Default QWERTY: LEFT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_VEH_MOUSE_CONTROL_OVERRIDE = 106,

        /// <summary>
        /// Default QWERTY: NUMPAD 6
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_FLY_ROLL_LR = 107,

        /// <summary>
        /// Default QWERTY: NUMPAD 4
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_FLY_ROLL_LEFT_ONLY = 108,

        /// <summary>
        /// Default QWERTY: NUMPAD 6
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_FLY_ROLL_RIGHT_ONLY = 109,

        /// <summary>
        /// Default QWERTY: NUMPAD 5
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_FLY_PITCH_UD = 110,

        /// <summary>
        /// Default QWERTY: NUMPAD 8
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_FLY_PITCH_UP_ONLY = 111,

        /// <summary>
        /// Default QWERTY: NUMPAD 5
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_FLY_PITCH_DOWN_ONLY = 112,

        /// <summary>
        /// Default QWERTY: G
        /// <br/>
        /// Xbox Controller: L3
        /// </summary>
        INPUT_VEH_FLY_UNDERCARRIAGE = 113,

        /// <summary>
        /// Default QWERTY: RIGHT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_VEH_FLY_ATTACK = 114,

        /// <summary>
        /// Default QWERTY: SCROLLWHEEL UP
        /// <br/>
        /// Xbox Controller: DPAD LEFT
        /// </summary>
        INPUT_VEH_FLY_SELECT_NEXT_WEAPON = 115,

        /// <summary>
        /// Default QWERTY: [
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_VEH_FLY_SELECT_PREV_WEAPON = 116,

        /// <summary>
        /// Default QWERTY: NUMPAD 7
        /// <br/>
        /// Xbox Controller: LB
        /// </summary>
        INPUT_VEH_FLY_SELECT_TARGET_LEFT = 117,

        /// <summary>
        /// Default QWERTY: NUMPAD 9
        /// <br/>
        /// Xbox Controller: RB
        /// </summary>
        INPUT_VEH_FLY_SELECT_TARGET_RIGHT = 118,

        /// <summary>
        /// Default QWERTY: E
        /// <br/>
        /// Xbox Controller: DPAD RIGHT
        /// </summary>
        INPUT_VEH_FLY_VERTICAL_FLIGHT_MODE = 119,

        /// <summary>
        /// Default QWERTY: X
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_VEH_FLY_DUCK = 120,

        /// <summary>
        /// Default QWERTY: INSERT
        /// <br/>
        /// Xbox Controller: R3
        /// </summary>
        INPUT_VEH_FLY_ATTACK_CAMERA = 121,

        /// <summary>
        /// Default QWERTY: LEFT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_VEH_FLY_MOUSE_CONTROL_OVERRIDE = 122,

        /// <summary>
        /// Default QWERTY: NUMPAD 6
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_SUB_TURN_LR = 123,

        /// <summary>
        /// Default QWERTY: NUMPAD 4
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_SUB_TURN_LEFT_ONLY = 124,

        /// <summary>
        /// Default QWERTY: NUMPAD 6
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_SUB_TURN_RIGHT_ONLY = 125,

        /// <summary>
        /// Default QWERTY: NUMPAD 5
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_SUB_PITCH_UD = 126,

        /// <summary>
        /// Default QWERTY: NUMPAD 8
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_SUB_PITCH_UP_ONLY = 127,

        /// <summary>
        /// Default QWERTY: NUMPAD 5
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_SUB_PITCH_DOWN_ONLY = 128,

        /// <summary>
        /// Default QWERTY: W
        /// <br/>
        /// Xbox Controller: RT
        /// </summary>
        INPUT_VEH_SUB_THROTTLE_UP = 129,

        /// <summary>
        /// Default QWERTY: S
        /// <br/>
        /// Xbox Controller: LT
        /// </summary>
        INPUT_VEH_SUB_THROTTLE_DOWN = 130,

        /// <summary>
        /// Default QWERTY: LEFT SHIFT
        /// <br/>
        /// Xbox Controller: X
        /// </summary>
        INPUT_VEH_SUB_ASCEND = 131,

        /// <summary>
        /// Default QWERTY: LEFT CTRL
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_VEH_SUB_DESCEND = 132,

        /// <summary>
        /// Default QWERTY: A
        /// <br/>
        /// Xbox Controller: LB
        /// </summary>
        INPUT_VEH_SUB_TURN_HARD_LEFT = 133,

        /// <summary>
        /// Default QWERTY: D
        /// <br/>
        /// Xbox Controller: RB
        /// </summary>
        INPUT_VEH_SUB_TURN_HARD_RIGHT = 134,

        /// <summary>
        /// Default QWERTY: LEFT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_VEH_SUB_MOUSE_CONTROL_OVERRIDE = 135,

        /// <summary>
        /// Default QWERTY: W
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_VEH_PUSHBIKE_PEDAL = 136,

        /// <summary>
        /// Default QWERTY: CAPSLOCK
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_VEH_PUSHBIKE_SPRINT = 137,

        /// <summary>
        /// Default QWERTY: Q
        /// <br/>
        /// Xbox Controller: LT
        /// </summary>
        INPUT_VEH_PUSHBIKE_FRONT_BRAKE = 138,

        /// <summary>
        /// Default QWERTY: S
        /// <br/>
        /// Xbox Controller: RT
        /// </summary>
        INPUT_VEH_PUSHBIKE_REAR_BRAKE = 139,

        /// <summary>
        /// Default QWERTY: R
        /// <br/>
        /// Xbox Controller: B
        /// </summary>
        INPUT_MELEE_ATTACK_LIGHT = 140,

        /// <summary>
        /// Default QWERTY: Q
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_MELEE_ATTACK_HEAVY = 141,

        /// <summary>
        /// Default QWERTY: LEFT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: RT
        /// </summary>
        INPUT_MELEE_ATTACK_ALTERNATE = 142,

        /// <summary>
        /// Default QWERTY: SPACEBAR
        /// <br/>
        /// Xbox Controller: X
        /// </summary>
        INPUT_MELEE_BLOCK = 143,

        /// <summary>
        /// Default QWERTY: F / LEFT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: Y
        /// </summary>
        INPUT_PARACHUTE_DEPLOY = 144,

        /// <summary>
        /// Default QWERTY: F
        /// <br/>
        /// Xbox Controller: Y
        /// </summary>
        INPUT_PARACHUTE_DETACH = 145,

        /// <summary>
        /// Default QWERTY: D
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_PARACHUTE_TURN_LR = 146,

        /// <summary>
        /// Default QWERTY: A
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_PARACHUTE_TURN_LEFT_ONLY = 147,

        /// <summary>
        /// Default QWERTY: D
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_PARACHUTE_TURN_RIGHT_ONLY = 148,

        /// <summary>
        /// Default QWERTY: S
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_PARACHUTE_PITCH_UD = 149,

        /// <summary>
        /// Default QWERTY: W
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_PARACHUTE_PITCH_UP_ONLY = 150,

        /// <summary>
        /// Default QWERTY: S
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_PARACHUTE_PITCH_DOWN_ONLY = 151,

        /// <summary>
        /// Default QWERTY: Q
        /// <br/>
        /// Xbox Controller: LB
        /// </summary>
        INPUT_PARACHUTE_BRAKE_LEFT = 152,

        /// <summary>
        /// Default QWERTY: E
        /// <br/>
        /// Xbox Controller: RB
        /// </summary>
        INPUT_PARACHUTE_BRAKE_RIGHT = 153,

        /// <summary>
        /// Default QWERTY: X
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_PARACHUTE_SMOKE = 154,

        /// <summary>
        /// Default QWERTY: LEFT SHIFT
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_PARACHUTE_PRECISION_LANDING = 155,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_MAP = 156,

        /// <summary>
        /// Default QWERTY: 1
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_SELECT_WEAPON_UNARMED = 157,

        /// <summary>
        /// Default QWERTY: 2
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_SELECT_WEAPON_MELEE = 158,

        /// <summary>
        /// Default QWERTY: 6
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_SELECT_WEAPON_HANDGUN = 159,

        /// <summary>
        /// Default QWERTY: 3
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_SELECT_WEAPON_SHOTGUN = 160,

        /// <summary>
        /// Default QWERTY: 7
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_SELECT_WEAPON_SMG = 161,

        /// <summary>
        /// Default QWERTY: 8
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_SELECT_WEAPON_AUTO_RIFLE = 162,

        /// <summary>
        /// Default QWERTY: 9
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_SELECT_WEAPON_SNIPER = 163,

        /// <summary>
        /// Default QWERTY: 4
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_SELECT_WEAPON_HEAVY = 164,

        /// <summary>
        /// Default QWERTY: 5
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_SELECT_WEAPON_SPECIAL = 165,

        /// <summary>
        /// Default QWERTY: F5
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_SELECT_CHARACTER_MICHAEL = 166,

        /// <summary>
        /// Default QWERTY: F6
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_SELECT_CHARACTER_FRANKLIN = 167,

        /// <summary>
        /// Default QWERTY: F7
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_SELECT_CHARACTER_TREVOR = 168,

        /// <summary>
        /// Default QWERTY: F8 (CONSOLE)
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_SELECT_CHARACTER_MULTIPLAYER = 169,

        /// <summary>
        /// Default QWERTY: F3
        /// <br/>
        /// Xbox Controller: B
        /// </summary>
        INPUT_SAVE_REPLAY_CLIP = 170,

        /// <summary>
        /// Default QWERTY: CAPSLOCK
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_SPECIAL_ABILITY_PC = 171,

        /// <summary>
        /// Default QWERTY: ARROW UP
        /// <br/>
        /// Xbox Controller: DPAD UP
        /// </summary>
        INPUT_CELLPHONE_UP = 172,

        /// <summary>
        /// Default QWERTY: ARROW DOWN
        /// <br/>
        /// Xbox Controller: DPAD DOWN
        /// </summary>
        INPUT_CELLPHONE_DOWN = 173,

        /// <summary>
        /// Default QWERTY: ARROW LEFT
        /// <br/>
        /// Xbox Controller: DPAD LEFT
        /// </summary>
        INPUT_CELLPHONE_LEFT = 174,

        /// <summary>
        /// Default QWERTY: ARROW RIGHT
        /// <br/>
        /// Xbox Controller: DPAD RIGHT
        /// </summary>
        INPUT_CELLPHONE_RIGHT = 175,

        /// <summary>
        /// Default QWERTY: ENTER / LEFT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_CELLPHONE_SELECT = 176,

        /// <summary>
        /// Default QWERTY: BACKSPACE / ESC / RIGHT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: B
        /// </summary>
        INPUT_CELLPHONE_CANCEL = 177,

        /// <summary>
        /// Default QWERTY: DELETE
        /// <br/>
        /// Xbox Controller: Y
        /// </summary>
        INPUT_CELLPHONE_OPTION = 178,

        /// <summary>
        /// Default QWERTY: SPACEBAR
        /// <br/>
        /// Xbox Controller: X
        /// </summary>
        INPUT_CELLPHONE_EXTRA_OPTION = 179,

        /// <summary>
        /// Default QWERTY: SCROLLWHEEL DOWN
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_CELLPHONE_SCROLL_FORWARD = 180,

        /// <summary>
        /// Default QWERTY: SCROLLWHEEL UP
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_CELLPHONE_SCROLL_BACKWARD = 181,

        /// <summary>
        /// Default QWERTY: L
        /// <br/>
        /// Xbox Controller: RT
        /// </summary>
        INPUT_CELLPHONE_CAMERA_FOCUS_LOCK = 182,

        /// <summary>
        /// Default QWERTY: G
        /// <br/>
        /// Xbox Controller: RB
        /// </summary>
        INPUT_CELLPHONE_CAMERA_GRID = 183,

        /// <summary>
        /// Default QWERTY: E
        /// <br/>
        /// Xbox Controller: R3
        /// </summary>
        INPUT_CELLPHONE_CAMERA_SELFIE = 184,

        /// <summary>
        /// Default QWERTY: F
        /// <br/>
        /// Xbox Controller: LB
        /// </summary>
        INPUT_CELLPHONE_CAMERA_DOF = 185,

        /// <summary>
        /// Default QWERTY: X
        /// <br/>
        /// Xbox Controller: L3
        /// </summary>
        INPUT_CELLPHONE_CAMERA_EXPRESSION = 186,

        /// <summary>
        /// Default QWERTY: ARROW DOWN
        /// <br/>
        /// Xbox Controller: DPAD DOWN
        /// </summary>
        INPUT_FRONTEND_DOWN = 187,

        /// <summary>
        /// Default QWERTY: ARROW UP
        /// <br/>
        /// Xbox Controller: DPAD UP
        /// </summary>
        INPUT_FRONTEND_UP = 188,

        /// <summary>
        /// Default QWERTY: ARROW LEFT
        /// <br/>
        /// Xbox Controller: DPAD LEFT
        /// </summary>
        INPUT_FRONTEND_LEFT = 189,

        /// <summary>
        /// Default QWERTY: ARROW RIGHT
        /// <br/>
        /// Xbox Controller: DPAD RIGHT
        /// </summary>
        INPUT_FRONTEND_RIGHT = 190,

        /// <summary>
        /// Default QWERTY: ENTER
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_FRONTEND_RDOWN = 191,

        /// <summary>
        /// Default QWERTY: TAB
        /// <br/>
        /// Xbox Controller: Y
        /// </summary>
        INPUT_FRONTEND_RUP = 192,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: X
        /// </summary>
        INPUT_FRONTEND_RLEFT = 193,

        /// <summary>
        /// Default QWERTY: BACKSPACE
        /// <br/>
        /// Xbox Controller: B
        /// </summary>
        INPUT_FRONTEND_RRIGHT = 194,

        /// <summary>
        /// Default QWERTY: D
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_FRONTEND_AXIS_X = 195,

        /// <summary>
        /// Default QWERTY: S
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_FRONTEND_AXIS_Y = 196,

        /// <summary>
        /// Default QWERTY: ]
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_FRONTEND_RIGHT_AXIS_X = 197,

        /// <summary>
        /// Default QWERTY: SCROLLWHEEL DOWN
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_FRONTEND_RIGHT_AXIS_Y = 198,

        /// <summary>
        /// Default QWERTY: P
        /// <br/>
        /// Xbox Controller: START
        /// </summary>
        INPUT_FRONTEND_PAUSE = 199,

        /// <summary>
        /// Default QWERTY: ESC
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_FRONTEND_PAUSE_ALTERNATE = 200,

        /// <summary>
        /// Default QWERTY: ENTER / NUMPAD ENTER
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_FRONTEND_ACCEPT = 201,

        /// <summary>
        /// Default QWERTY: BACKSPACE / ESC
        /// <br/>
        /// Xbox Controller: B
        /// </summary>
        INPUT_FRONTEND_CANCEL = 202,

        /// <summary>
        /// Default QWERTY: SPACEBAR
        /// <br/>
        /// Xbox Controller: X
        /// </summary>
        INPUT_FRONTEND_X = 203,

        /// <summary>
        /// Default QWERTY: TAB
        /// <br/>
        /// Xbox Controller: Y
        /// </summary>
        INPUT_FRONTEND_Y = 204,

        /// <summary>
        /// Default QWERTY: Q
        /// <br/>
        /// Xbox Controller: LB
        /// </summary>
        INPUT_FRONTEND_LB = 205,

        /// <summary>
        /// Default QWERTY: E
        /// <br/>
        /// Xbox Controller: RB
        /// </summary>
        INPUT_FRONTEND_RB = 206,

        /// <summary>
        /// Default QWERTY: PAGE DOWN
        /// <br/>
        /// Xbox Controller: LT
        /// </summary>
        INPUT_FRONTEND_LT = 207,

        /// <summary>
        /// Default QWERTY: PAGE UP
        /// <br/>
        /// Xbox Controller: RT
        /// </summary>
        INPUT_FRONTEND_RT = 208,

        /// <summary>
        /// Default QWERTY: LEFT SHIFT
        /// <br/>
        /// Xbox Controller: L3
        /// </summary>
        INPUT_FRONTEND_LS = 209,

        /// <summary>
        /// Default QWERTY: LEFT CONTROL
        /// <br/>
        /// Xbox Controller: R3
        /// </summary>
        INPUT_FRONTEND_RS = 210,

        /// <summary>
        /// Default QWERTY: TAB
        /// <br/>
        /// Xbox Controller: RB
        /// </summary>
        INPUT_FRONTEND_LEADERBOARD = 211,

        /// <summary>
        /// Default QWERTY: HOME
        /// <br/>
        /// Xbox Controller: BACK
        /// </summary>
        INPUT_FRONTEND_SOCIAL_CLUB = 212,

        /// <summary>
        /// Default QWERTY: HOME
        /// <br/>
        /// Xbox Controller: RB
        /// </summary>
        INPUT_FRONTEND_SOCIAL_CLUB_SECONDARY = 213,

        /// <summary>
        /// Default QWERTY: DELETE
        /// <br/>
        /// Xbox Controller: X
        /// </summary>
        INPUT_FRONTEND_DELETE = 214,

        /// <summary>
        /// Default QWERTY: ENTER
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_FRONTEND_ENDSCREEN_ACCEPT = 215,

        /// <summary>
        /// Default QWERTY: SPACEBAR
        /// <br/>
        /// Xbox Controller: X
        /// </summary>
        INPUT_FRONTEND_ENDSCREEN_EXPAND = 216,

        /// <summary>
        /// Default QWERTY: CAPSLOCK
        /// <br/>
        /// Xbox Controller: BACK
        /// </summary>
        INPUT_FRONTEND_SELECT = 217,

        /// <summary>
        /// Default QWERTY: D
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_SCRIPT_LEFT_AXIS_X = 218,

        /// <summary>
        /// Default QWERTY: S
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_SCRIPT_LEFT_AXIS_Y = 219,

        /// <summary>
        /// Default QWERTY: MOUSE RIGHT
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_SCRIPT_RIGHT_AXIS_X = 220,

        /// <summary>
        /// Default QWERTY: MOUSE DOWN
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_SCRIPT_RIGHT_AXIS_Y = 221,

        /// <summary>
        /// Default QWERTY: RIGHT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: Y
        /// </summary>
        INPUT_SCRIPT_RUP = 222,

        /// <summary>
        /// Default QWERTY: LEFT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_SCRIPT_RDOWN = 223,

        /// <summary>
        /// Default QWERTY: LEFT CTRL
        /// <br/>
        /// Xbox Controller: X
        /// </summary>
        INPUT_SCRIPT_RLEFT = 224,

        /// <summary>
        /// Default QWERTY: RIGHT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: B
        /// </summary>
        INPUT_SCRIPT_RRIGHT = 225,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: LB
        /// </summary>
        INPUT_SCRIPT_LB = 226,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: RB
        /// </summary>
        INPUT_SCRIPT_RB = 227,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: LT
        /// </summary>
        INPUT_SCRIPT_LT = 228,

        /// <summary>
        /// Default QWERTY: LEFT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: RT
        /// </summary>
        INPUT_SCRIPT_RT = 229,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: L3
        /// </summary>
        INPUT_SCRIPT_LS = 230,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: R3
        /// </summary>
        INPUT_SCRIPT_RS = 231,

        /// <summary>
        /// Default QWERTY: W
        /// <br/>
        /// Xbox Controller: DPAD UP
        /// </summary>
        INPUT_SCRIPT_PAD_UP = 232,

        /// <summary>
        /// Default QWERTY: S
        /// <br/>
        /// Xbox Controller: DPAD DOWN
        /// </summary>
        INPUT_SCRIPT_PAD_DOWN = 233,

        /// <summary>
        /// Default QWERTY: A
        /// <br/>
        /// Xbox Controller: DPAD LEFT
        /// </summary>
        INPUT_SCRIPT_PAD_LEFT = 234,

        /// <summary>
        /// Default QWERTY: D
        /// <br/>
        /// Xbox Controller: DPAD RIGHT
        /// </summary>
        INPUT_SCRIPT_PAD_RIGHT = 235,

        /// <summary>
        /// Default QWERTY: V
        /// <br/>
        /// Xbox Controller: BACK
        /// </summary>
        INPUT_SCRIPT_SELECT = 236,

        /// <summary>
        /// Default QWERTY: LEFT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_CURSOR_ACCEPT = 237,

        /// <summary>
        /// Default QWERTY: RIGHT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_CURSOR_CANCEL = 238,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_CURSOR_X = 239,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_CURSOR_Y = 240,

        /// <summary>
        /// Default QWERTY: SCROLLWHEEL UP
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_CURSOR_SCROLL_UP = 241,

        /// <summary>
        /// Default QWERTY: SCROLLWHEEL DOWN
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_CURSOR_SCROLL_DOWN = 242,

        /// <summary>
        /// Default QWERTY: ~ / `
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_ENTER_CHEAT_CODE = 243,

        /// <summary>
        /// Default QWERTY: M
        /// <br/>
        /// Xbox Controller: BACK
        /// </summary>
        INPUT_INTERACTION_MENU = 244,

        /// <summary>
        /// Default QWERTY: T
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_MP_TEXT_CHAT_ALL = 245,

        /// <summary>
        /// Default QWERTY: Y
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_MP_TEXT_CHAT_TEAM = 246,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_MP_TEXT_CHAT_FRIENDS = 247,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_MP_TEXT_CHAT_CREW = 248,

        /// <summary>
        /// Default QWERTY: N
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_PUSH_TO_TALK = 249,

        /// <summary>
        /// Default QWERTY: R
        /// <br/>
        /// Xbox Controller: L3
        /// </summary>
        INPUT_CREATOR_LS = 250,

        /// <summary>
        /// Default QWERTY: F
        /// <br/>
        /// Xbox Controller: R3
        /// </summary>
        INPUT_CREATOR_RS = 251,

        /// <summary>
        /// Default QWERTY: X
        /// <br/>
        /// Xbox Controller: LT
        /// </summary>
        INPUT_CREATOR_LT = 252,

        /// <summary>
        /// Default QWERTY: C
        /// <br/>
        /// Xbox Controller: RT
        /// </summary>
        INPUT_CREATOR_RT = 253,

        /// <summary>
        /// Default QWERTY: LEFT SHIFT
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_CREATOR_MENU_TOGGLE = 254,

        /// <summary>
        /// Default QWERTY: SPACEBAR
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_CREATOR_ACCEPT = 255,

        /// <summary>
        /// Default QWERTY: DELETE
        /// <br/>
        /// Xbox Controller: X
        /// </summary>
        INPUT_CREATOR_DELETE = 256,

        /// <summary>
        /// Default QWERTY: LEFT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: RT
        /// </summary>
        INPUT_ATTACK2 = 257,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_RAPPEL_JUMP = 258,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: X
        /// </summary>
        INPUT_RAPPEL_LONG_JUMP = 259,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: RT
        /// </summary>
        INPUT_RAPPEL_SMASH_WINDOW = 260,

        /// <summary>
        /// Default QWERTY: SCROLLWHEEL UP
        /// <br/>
        /// Xbox Controller: DPAD LEFT
        /// </summary>
        INPUT_PREV_WEAPON = 261,

        /// <summary>
        /// Default QWERTY: SCROLLWHEEL DOWN
        /// <br/>
        /// Xbox Controller: DPAD RIGHT
        /// </summary>
        INPUT_NEXT_WEAPON = 262,

        /// <summary>
        /// Default QWERTY: R
        /// <br/>
        /// Xbox Controller: B
        /// </summary>
        INPUT_MELEE_ATTACK1 = 263,

        /// <summary>
        /// Default QWERTY: Q
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_MELEE_ATTACK2 = 264,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_WHISTLE = 265,

        /// <summary>
        /// Default QWERTY: D
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_MOVE_LEFT = 266,

        /// <summary>
        /// Default QWERTY: D
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_MOVE_RIGHT = 267,

        /// <summary>
        /// Default QWERTY: S
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_MOVE_UP = 268,

        /// <summary>
        /// Default QWERTY: S
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_MOVE_DOWN = 269,

        /// <summary>
        /// Default QWERTY: MOUSE RIGHT
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_LOOK_LEFT = 270,

        /// <summary>
        /// Default QWERTY: MOUSE RIGHT
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_LOOK_RIGHT = 271,

        /// <summary>
        /// Default QWERTY: MOUSE DOWN
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_LOOK_UP = 272,

        /// <summary>
        /// Default QWERTY: MOUSE DOWN
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_LOOK_DOWN = 273,

        /// <summary>
        /// Default QWERTY: [
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_SNIPER_ZOOM_IN = 274,

        /// <summary>
        /// Default QWERTY: [
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_SNIPER_ZOOM_OUT = 275,

        /// <summary>
        /// Default QWERTY: [
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_SNIPER_ZOOM_IN_ALTERNATE = 276,

        /// <summary>
        /// Default QWERTY: [
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_SNIPER_ZOOM_OUT_ALTERNATE = 277,

        /// <summary>
        /// Default QWERTY: D
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_MOVE_LEFT = 278,

        /// <summary>
        /// Default QWERTY: D
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_MOVE_RIGHT = 279,

        /// <summary>
        /// Default QWERTY: LEFT CTRL
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_MOVE_UP = 280,

        /// <summary>
        /// Default QWERTY: LEFT CTRL
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_MOVE_DOWN = 281,

        /// <summary>
        /// Default QWERTY: MOUSE RIGHT
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_VEH_GUN_LEFT = 282,

        /// <summary>
        /// Default QWERTY: MOUSE RIGHT
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_VEH_GUN_RIGHT = 283,

        /// <summary>
        /// Default QWERTY: MOUSE RIGHT
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_VEH_GUN_UP = 284,

        /// <summary>
        /// Default QWERTY: MOUSE RIGHT
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_VEH_GUN_DOWN = 285,

        /// <summary>
        /// Default QWERTY: MOUSE RIGHT
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_VEH_LOOK_LEFT = 286,

        /// <summary>
        /// Default QWERTY: MOUSE RIGHT
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_VEH_LOOK_RIGHT = 287,

        /// <summary>
        /// Default QWERTY: F1
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_REPLAY_START_STOP_RECORDING = 288,

        /// <summary>
        /// Default QWERTY: F2
        /// <br/>
        /// Xbox Controller: X
        /// </summary>
        INPUT_REPLAY_START_STOP_RECORDING_SECONDARY = 289,

        /// <summary>
        /// Default QWERTY: MOUSE RIGHT
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_SCALED_LOOK_LR = 290,

        /// <summary>
        /// Default QWERTY: MOUSE DOWN
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_SCALED_LOOK_UD = 291,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_SCALED_LOOK_UP_ONLY = 292,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_SCALED_LOOK_DOWN_ONLY = 293,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_SCALED_LOOK_LEFT_ONLY = 294,

        /// <summary>
        /// Default QWERTY: NONE
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_SCALED_LOOK_RIGHT_ONLY = 295,

        /// <summary>
        /// Default QWERTY: DELETE
        /// <br/>
        /// Xbox Controller: X
        /// </summary>
        INPUT_REPLAY_MARKER_DELETE = 296,

        /// <summary>
        /// Default QWERTY: DELETE
        /// <br/>
        /// Xbox Controller: Y
        /// </summary>
        INPUT_REPLAY_CLIP_DELETE = 297,

        /// <summary>
        /// Default QWERTY: SPACEBAR
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_REPLAY_PAUSE = 298,

        /// <summary>
        /// Default QWERTY: ARROW DOWN
        /// <br/>
        /// Xbox Controller: LB
        /// </summary>
        INPUT_REPLAY_REWIND = 299,

        /// <summary>
        /// Default QWERTY: ARROW UP
        /// <br/>
        /// Xbox Controller: RB
        /// </summary>
        INPUT_REPLAY_FFWD = 300,

        /// <summary>
        /// Default QWERTY: M
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_REPLAY_NEWMARKER = 301,

        /// <summary>
        /// Default QWERTY: S
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_REPLAY_RECORD = 302,

        /// <summary>
        /// Default QWERTY: U
        /// <br/>
        /// Xbox Controller: DPAD UP
        /// </summary>
        INPUT_REPLAY_SCREENSHOT = 303,

        /// <summary>
        /// Default QWERTY: H
        /// <br/>
        /// Xbox Controller: R3
        /// </summary>
        INPUT_REPLAY_HIDEHUD = 304,

        /// <summary>
        /// Default QWERTY: B
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_REPLAY_STARTPOINT = 305,

        /// <summary>
        /// Default QWERTY: N
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_REPLAY_ENDPOINT = 306,

        /// <summary>
        /// Default QWERTY: ARROW RIGHT
        /// <br/>
        /// Xbox Controller: DPAD RIGHT
        /// </summary>
        INPUT_REPLAY_ADVANCE = 307,

        /// <summary>
        /// Default QWERTY: ARROW LEFT
        /// <br/>
        /// Xbox Controller: DPAD LEFT
        /// </summary>
        INPUT_REPLAY_BACK = 308,

        /// <summary>
        /// Default QWERTY: T
        /// <br/>
        /// Xbox Controller: DPAD DOWN
        /// </summary>
        INPUT_REPLAY_TOOLS = 309,

        /// <summary>
        /// Default QWERTY: R
        /// <br/>
        /// Xbox Controller: BACK
        /// </summary>
        INPUT_REPLAY_RESTART = 310,

        /// <summary>
        /// Default QWERTY: K
        /// <br/>
        /// Xbox Controller: DPAD DOWN
        /// </summary>
        INPUT_REPLAY_SHOWHOTKEY = 311,

        /// <summary>
        /// Default QWERTY: [
        /// <br/>
        /// Xbox Controller: DPAD LEFT
        /// </summary>
        INPUT_REPLAY_CYCLEMARKERLEFT = 312,

        /// <summary>
        /// Default QWERTY: ]
        /// <br/>
        /// Xbox Controller: DPAD RIGHT
        /// </summary>
        INPUT_REPLAY_CYCLEMARKERRIGHT = 313,

        /// <summary>
        /// Default QWERTY: NUMPAD +
        /// <br/>
        /// Xbox Controller: RB
        /// </summary>
        INPUT_REPLAY_FOVINCREASE = 314,

        /// <summary>
        /// Default QWERTY: NUMPAD -
        /// <br/>
        /// Xbox Controller: LB
        /// </summary>
        INPUT_REPLAY_FOVDECREASE = 315,

        /// <summary>
        /// Default QWERTY: PAGE UP
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_REPLAY_CAMERAUP = 316,

        /// <summary>
        /// Default QWERTY: PAGE DOWN
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_REPLAY_CAMERADOWN = 317,

        /// <summary>
        /// Default QWERTY: F5
        /// <br/>
        /// Xbox Controller: START
        /// </summary>
        INPUT_REPLAY_SAVE = 318,

        /// <summary>
        /// Default QWERTY: C
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_REPLAY_TOGGLETIME = 319,

        /// <summary>
        /// Default QWERTY: V
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_REPLAY_TOGGLETIPS = 320,

        /// <summary>
        /// Default QWERTY: SPACEBAR
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_REPLAY_PREVIEW = 321,

        /// <summary>
        /// Default QWERTY: ESC
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_REPLAY_TOGGLE_TIMELINE = 322,

        /// <summary>
        /// Default QWERTY: X
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_REPLAY_TIMELINE_PICKUP_CLIP = 323,

        /// <summary>
        /// Default QWERTY: C
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_REPLAY_TIMELINE_DUPLICATE_CLIP = 324,

        /// <summary>
        /// Default QWERTY: V
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_REPLAY_TIMELINE_PLACE_CLIP = 325,

        /// <summary>
        /// Default QWERTY: LEFT CTRL
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_REPLAY_CTRL = 326,

        /// <summary>
        /// Default QWERTY: F5
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_REPLAY_TIMELINE_SAVE = 327,

        /// <summary>
        /// Default QWERTY: SPACEBAR
        /// <br/>
        /// Xbox Controller: RT
        /// </summary>
        INPUT_REPLAY_PREVIEW_AUDIO = 328,

        /// <summary>
        /// Default QWERTY: LEFT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_VEH_DRIVE_LOOK = 329,

        /// <summary>
        /// Default QWERTY: RIGHT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_VEH_DRIVE_LOOK2 = 330,

        /// <summary>
        /// Default QWERTY: RIGHT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: NONE
        /// </summary>
        INPUT_VEH_FLY_ATTACK2 = 331,

        /// <summary>
        /// Default QWERTY: MOUSE DOWN
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_RADIO_WHEEL_UD = 332,

        /// <summary>
        /// Default QWERTY: MOUSE RIGHT
        /// <br/>
        /// Xbox Controller: RIGHT STICK
        /// </summary>
        INPUT_RADIO_WHEEL_LR = 333,

        /// <summary>
        /// Default QWERTY: SCROLLWHEEL DOWN
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_SLOWMO_UD = 334,

        /// <summary>
        /// Default QWERTY: SCROLLWHEEL UP
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_SLOWMO_UP_ONLY = 335,

        /// <summary>
        /// Default QWERTY: SCROLLWHEEL DOWN
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_SLOWMO_DOWN_ONLY = 336,

        /// <summary>
        /// Default QWERTY: X
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_VEH_HYDRAULICS_CONTROL_TOGGLE = 337,

        /// <summary>
        /// Default QWERTY: A
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_HYDRAULICS_CONTROL_LEFT = 338,

        /// <summary>
        /// Default QWERTY: D
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_HYDRAULICS_CONTROL_RIGHT = 339,

        /// <summary>
        /// Default QWERTY: LEFT SHIFT
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_HYDRAULICS_CONTROL_UP = 340,

        /// <summary>
        /// Default QWERTY: LEFT CTRL
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_HYDRAULICS_CONTROL_DOWN = 341,

        /// <summary>
        /// Default QWERTY: D
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_HYDRAULICS_CONTROL_UD = 342,

        /// <summary>
        /// Default QWERTY: LEFT CTRL
        /// <br/>
        /// Xbox Controller: LEFT STICK
        /// </summary>
        INPUT_VEH_HYDRAULICS_CONTROL_LR = 343,

        /// <summary>
        /// Default QWERTY: F11
        /// <br/>
        /// Xbox Controller: DPAD RIGHT
        /// </summary>
        INPUT_SWITCH_VISOR = 344,

        /// <summary>
        /// Default QWERTY: X
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_VEH_MELEE_HOLD = 345,

        /// <summary>
        /// Default QWERTY: LEFT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: LB
        /// </summary>
        INPUT_VEH_MELEE_LEFT = 346,

        /// <summary>
        /// Default QWERTY: RIGHT MOUSE BUTTON
        /// <br/>
        /// Xbox Controller: RB
        /// </summary>
        INPUT_VEH_MELEE_RIGHT = 347,

        /// <summary>
        /// Default QWERTY: SCROLLWHEEL BUTTON (PRESS)
        /// <br/>
        /// Xbox Controller: Y
        /// </summary>
        INPUT_MAP_POI = 348,

        /// <summary>
        /// Default QWERTY: TAB
        /// <br/>
        /// Xbox Controller: X
        /// </summary>
        INPUT_REPLAY_SNAPMATIC_PHOTO = 349,

        /// <summary>
        /// Default QWERTY: E
        /// <br/>
        /// Xbox Controller: L3
        /// </summary>
        INPUT_VEH_CAR_JUMP = 350,

        /// <summary>
        /// Default QWERTY: E
        /// <br/>
        /// Xbox Controller: L3
        /// </summary>
        INPUT_VEH_ROCKET_BOOST = 351,

        /// <summary>
        /// Default QWERTY: LEFT SHIFT
        /// <br/>
        /// Xbox Controller: L3
        /// </summary>
        INPUT_VEH_FLY_BOOST = 352,

        /// <summary>
        /// Default QWERTY: SPACEBAR
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_VEH_PARACHUTE = 353,

        /// <summary>
        /// Default QWERTY: X
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_VEH_BIKE_WINGS = 354,

        /// <summary>
        /// Default QWERTY: E
        /// <br/>
        /// Xbox Controller: DPAD RIGHT
        /// </summary>
        INPUT_VEH_FLY_BOMB_BAY = 355,

        /// <summary>
        /// Default QWERTY: E
        /// <br/>
        /// Xbox Controller: DPAD RIGHT
        /// </summary>
        INPUT_VEH_FLY_COUNTER = 356,

        /// <summary>
        /// Default QWERTY: X
        /// <br/>
        /// Xbox Controller: A
        /// </summary>
        INPUT_VEH_TRANSFORM = 357,

        /// <summary>
        /// Default QWERTY: N/A
        /// <br/>
        /// Xbox Controller: RB
        /// </summary>
        INPUT_QUAD_LOCO_REVERSE = 358,

        /// <summary>
        /// Default QWERTY: N/A
        /// <br/>
        /// Xbox Controller: N/A
        /// </summary>
        INPUT_RESPAWN_FASTER = 359,

        /// <summary>
        /// Default QWERTY: N/A
        /// <br/>
        /// Xbox Controller: N/A
        /// </summary>
        INPUT_HUDMARKER_SELECT = 360,
    }
}
