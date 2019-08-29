﻿/*
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

using System.Collections.Generic;

namespace BPE_AllowCrimesForGroups
{
    public class Variables
    {
        public Dictionary<string, byte[]> Permissions { get; set; } = new Dictionary<string, byte[]>();
    }
}
