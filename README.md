
<div align="center">
	<h1>Project Reloaded (Mod Template)</h1>
	<img src="https://i.imgur.com/BjPn7rU.png" width="150" align="center" />
	<br/> <br/>
	<strong>All your mods are belong to us.</strong>
	<p>C# based universal mod loader framework compatible with arbitrary processes.</p>
</div>


# About This Project

This is a Reloaded Mod Loader mod that provides Discord Rich Presence support for Shadow The Hedgehog Players on Dolphin.

![Example](https://raw.githubusercontent.com/sewer56lol/ShadowTheHedgehog-RPC/master/Example.png)

This project has no reliance/dependency on Dolphin and should hopefully work with just about any version of the emulator.

## How to Use

A. Setup a game profile in Reloaded that launches Dolphin Emulator.

![Example](https://i.imgur.com/nOZ0Kvd.png)

B. Install and enable the mod like a regular Reloaded mod.
C. Launch/Attach (to) Dolphin using Reloaded.

## Summary of how it works (Technical)

A. For the current process, the Reloaded mod obtains the mapping of all available memory pages using Reloaded's `ReloadedProcess.GetPages();` function.

B. Validate whether the page belongs to emulated (GameCube) memory by checking the following factors:

- If Region Size is 0x2000000 (GC RAM size), and page type is mapped (to a file).
- Check if page is backed by physical memory with `QueryWorkingSetEx` with the valid flag/bit of `PSAPI_WORKING_SET_EX_BLOCK.Flags`.

C. Work with GameCube memory. The GC memory base address 0x80000000 corresponds to our own obtained page address. 

Before sending any updates we should also validate that the Game ID (i.e. GUPE8P) matches - such that we don't send false info if the user is playing another game.

Of course this description is simplified; but it should help you get started.

## Extra Credits

- **Tybis/LimblessVector**: Provided many of the memory addresses used to create this and was my co-photographer for thumbnails.
