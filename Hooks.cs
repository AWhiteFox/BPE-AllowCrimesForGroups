/*
    This file is part of BPE-AllowCrimesForGroups.

    BPE-AllowCrimesForGroups is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    BPE-AllowCrimesForGroups is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with BPE-AllowCrimesForGroups.  If not, see <https://www.gnu.org/licenses/>.
 */

using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using UnityEngine;
using UniversalUnityHooks;

namespace BPE_AllowCrimesForGroups
{
    public class Hooks
    {
        private static readonly string ConfigFilePath = Path.Combine("Plugins", "AllowCrimesForGroups-Settings.json");
        private static Variables Vars = new Variables();

        [Hook("SvManager.StartServer")]
        public static void StartServer(SvManager svManager)
        {
            Debug.Log("Initializing AllowCrimesForGroups...");
            if (File.Exists(ConfigFilePath))
            {
                try { Vars = JsonConvert.DeserializeObject<Variables>(File.ReadAllText(ConfigFilePath)); }
                catch (Exception) { Debug.Log($"[ERROR] Can't deserialize {ConfigFilePath}. Using default values."); }
            }
            else
            {
                Debug.Log("Config file for AllowCrimesForGroups not found. Creating one...");
                File.WriteAllText(ConfigFilePath, JsonConvert.SerializeObject(Vars, Formatting.Indented));
            }
        }

        [Hook("SvPlayer.SvAddCrime")]
        public static bool SvAddCrime(SvPlayer player, ref byte crime, ref ShEntity entity)
        {
            foreach (var group in BP_Essentials.Variables.Groups.Where(x => x.Value.Users.Contains(player.player.username)))
            {
                if (IsAllowedForGroup(group.Key, crime) || IsAllowedForEveryone(crime))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsAllowedForGroup(string group, byte crime) =>
            Vars.Permissions.TryGetValue(group, out byte[] x) && x.Contains(crime);

        public static bool IsAllowedForEveryone(byte crime) =>
            Vars.Permissions.TryGetValue("*", out byte[] x) && x.Contains(crime);
    }
}
