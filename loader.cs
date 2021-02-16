using System;
using System.Threading;
using HarmonyLib;
var harmonyVersion = Harmony.VersionInfo(out var myVersion);

[HarmonyPatch("Setup")]

public class Setup {
 
	public static void Main() 
	{
		var harmony = new Harmony("com.non.weetanks.loader");
		Debug.Log("------------------------------");
		Debug.Log("---- Wee Tanks Mod Loader ----");
		Debug.Log("-- Using Harmony version " + version + " --");
		Debug.Log("------------------------------");
		Debug.Log("--- Loading Harmony mods...---");
		Harmony.PatchAll();
		Debug.Log("------------------------------");
	}
 
}