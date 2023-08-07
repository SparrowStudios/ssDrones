// ssDrones (https://github.com/SparrowStudios/ssDrones)
// Author: Jacob Paulin (JayPaulinCodes)
// Created: Jul 29 2023
// Updated: Aug 7 2023
// 
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SparrowStudios.Fivem.ssDrones
{
    public static class Extensions
    {
        #region Random Extensions
        /// <summary>
        /// Returns a boolean for Random if the percentage is less than the generated double
        /// </summary>
        /// <param name="truePercentage">The percentage to check against. If the generated number is less than this percentage, it will return true</param>
        public static bool NextBool(this Random random, int truePercentage = 50) => random.NextDouble() < truePercentage / 100.0;
        #endregion

        #region String Extensions
        /// <summary>
        /// Splits a word by upper case letters
        /// Ex: splitByCamelCase = ['spit', 'By', 'Camel', 'Case']
        /// </summary>
        public static string[] SplitByCamelCase(this string text)
        {
            StringBuilder builder = new StringBuilder();
            foreach (char c in text)
            {
                if (char.IsUpper(c) && builder.Length > 0)
                {
                    builder.Append(' ');
                }

                builder.Append(c);
            }

            return builder.ToString().Split(' ');
        }

        /// <summary>
        /// Splits the provided string into a list of strings each containings at max the provided length
        /// </summary>
        /// <param name="text">The text to split</param>
        /// <param name="length">The max length of each string</param>
        /// <returns>IEnumerable of the strings</returns>
        public static IEnumerable<string> SplitByLength(this string text, int length)
            => text.Where((x, i) => i % length == 0).Select((x, i) => new string(text.Skip(i * length).Take(length).ToArray())).ToArray();
        #endregion

        #region Float Extensions
        /// <summary>
        /// Converts GTA speed (meters per second) to miles per hour
        /// </summary>
        public static float ConvertToMph(this float msSpeed) => msSpeed * 2.236936f;

        /// <summary>
        /// Converts miles per hour to GTA speed (meters per second)
        /// </summary>
        public static float ConvertFromMph(this float mphSpeed) => mphSpeed * 0.44704f;
        #endregion

        #region Dictionary Extensions
        /// <summary>
        /// Retrieves a value for the specified key
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dict"></param>
        /// <param name="key"></param>
        /// <param name="defaultVal"></param>
        /// <returns></returns>
        public static T GetVal<T>(this IDictionary<string, object> dict, string key, T defaultVal)
        {
            if (dict.ContainsKey(key) && dict[key] is T)
                return (T)dict[key];

            return defaultVal;
        }
        #endregion
    }
}
