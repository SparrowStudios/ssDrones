using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

namespace SparrowStudios.Fivem.ssDrones.Client
{
    public static class ScaleformUtils
    {
        public static async Task<int> LoadMove(string name)
        {
            int scaleform = RequestScaleformMovie(name);
            while (!HasScaleformMovieLoaded(scaleform))
            {
                await BaseScript.Delay(0);
            }
            return scaleform;
        }

        public static void PopFloat(int scaleform, string method, float value)
        {
            PushScaleformMovieFunction(scaleform, method);
            PushScaleformMovieFunctionParameterFloat(value);
            PopScaleformMovieFunctionVoid();
        }

        public static void PopInt(int scaleform, string method, int value)
        {
            PushScaleformMovieFunction(scaleform, method);
            PushScaleformMovieFunctionParameterInt(value);
            PopScaleformMovieFunctionVoid();
        }

        public static void PopBool(int scaleform, string method, bool value)
        {
            PushScaleformMovieFunction(scaleform, method);
            PushScaleformMovieFunctionParameterBool(value);
            PopScaleformMovieFunctionVoid();
        }

        public static int PopRet(int scaleform, string method)
        {
            PushScaleformMovieFunction(scaleform, method);
            return PopScaleformMovieFunction();
        }

        public static void PopVoid(int scaleform, string method)
        {
            PushScaleformMovieFunction(scaleform, method);
            PopScaleformMovieFunctionVoid();
        }

        public static void PopMulti(int scaleform, string method, params object[] args)
        {
            PushScaleformMovieFunction(scaleform, method);

            foreach (var arg in args)
            {
                if (arg.GetType() == typeof(int))
                {
                    PushScaleformMovieFunctionParameterInt((int)arg);
                }
                else if(arg.GetType() == typeof(string))
                {
                    PushScaleformMovieFunctionParameterString((string)arg);
                }
                else if(arg.GetType() == typeof(bool))
                {
                    PushScaleformMovieFunctionParameterBool((bool)arg);
                }
                else if(arg.GetType() == typeof(float))
                {
                    PushScaleformMovieFunctionParameterFloat((float)arg);
                }
            }

            PopScaleformMovieFunctionVoid();
        }
    }
}
