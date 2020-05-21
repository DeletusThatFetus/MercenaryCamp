# Purpose

A Mount & Blade II: Bannerlord mod that introduces mercenary parties into the
game that will periodically make camp with the intention of selling mercenary
units in exchange for coin. Mercenary Companies can be seen wandering the map
and can be interacted with like normal parties. Occasionally, these parties will
make camp at towns and villages at which point they will provide their services
to the player. The cost of these units can be positively and negatively affected
by the players Charm stat, as well as their relation to said Mercenary Company.

When a Recruiter has setup shop in a town/village they will take control of a
stall and can be interacted with at that stall, or directly through the town
center notables tab like any other merchant.

# Dependencies
* [ModLib](https://www.nexusmods.com/mountandblade2bannerlord/mods/592)

# Mod Conflicts

There shouldn't be any conflicts with existing mods, unless someone
significantly alters town/village interactions from the Vanilla experience.

# Development Process

## Development Tools
* [Visual Studio Community Edition](https://visualstudio.microsoft.com/)
* [JetBrains dotPeek](https://www.jetbrains.com/decompiler/)

## First Time Setup
If you wish to mirror this repository or simply help with bug fixes, you will
need to update the .csproj file and change the following code line to match your
game directory.

```xml
<GameFolder>Your\Path\To\Mount &amp; Blade II Bannerlord</GameFolder>
```

# Change Log
- Initial Release 1.0.0
