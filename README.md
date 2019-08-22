# BPE-AllowCrimesForGroups

A simple addon for [BP: Essentials](https://userr00t.github.io/BP-Essentials/) to allow custom groups commit specific crimes

## Configuration

This example will allow group with name "Robber" bombing and trespassing:
```json
{
  "Groups": {
      "Robber": [ 11, 15 ]
  }
}
```
*Config file can be found in "Plugins" folder after first server start*

## Installation

0. Install BPE (guide can be found [here](https://userr00t.github.io/BP-Essentials/#Installation)) and create some groups.
1. Move "AllowCrimesForGroups.dll" to "Plugins" folder.
2. Run "UniversalUnityHooks.exe" in server folder.
