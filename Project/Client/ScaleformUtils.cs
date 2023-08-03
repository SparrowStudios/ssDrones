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

        public static void StartPopMulti(int scaleform, string method) 
            => PushScaleformMovieFunction(scaleform, method);

        public static void EndPopMulti() 
            => PopScaleformMovieFunctionVoid();

        public static void PopMultiString(string value)
            => PushScaleformMovieFunctionParameterString(value);

        public static void PopMultiBool(bool value)
            => PushScaleformMovieFunctionParameterBool(value);

        public static void PopMultiInt(int value)
            => PushScaleformMovieFunctionParameterInt(value);

        public static void PopMultiFloat(float value)
            => PushScaleformMovieFunctionParameterFloat(value);
    }
}
