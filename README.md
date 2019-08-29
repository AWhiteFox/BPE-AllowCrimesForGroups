# BPE-AllowCrimesForGroups

A simple addon for [BP: Essentials](https://userr00t.github.io/BP-Essentials/) to allow custom groups commit specific crimes

## Configuration

This example will allow group with name "Robber" bombing and trespassing and contraband for everyone:
```json
{
  "Permissions": {
      "Robber": [ 11, 15 ],
      "*": [ 5 ]
  }
}
```
*Config file can be found in "Plugins" folder after first server start*

**IDs:**
```
Obstruction = 1;
Intoxication = 2;
Intimidation = 3;
DUI = 4;
Contraband = 5;
AutoTheft = 6;
Theft = 7;
Assault = 8;
PrisonBreak = 9;
ArmedAssault = 10;
Bombing = 11;
Robbery = 12;
Murder = 13;
NoLicense = 14;
Trespassing = 15;
```

## Installation

0. Install BPE (guide can be found [here](https://userr00t.github.io/BP-Essentials/#Installation)) and create some groups.
1. Move "AllowCrimesForGroups.dll" to "Plugins" folder.
2. Run "UniversalUnityHooks.exe" in server folder.
