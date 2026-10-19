// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Titanfall2Gauntlet : ModuleRules
{
	public Titanfall2Gauntlet(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Titanfall2Gauntlet",
			"Titanfall2Gauntlet/Variant_Horror",
			"Titanfall2Gauntlet/Variant_Horror/UI",
			"Titanfall2Gauntlet/Variant_Shooter",
			"Titanfall2Gauntlet/Variant_Shooter/AI",
			"Titanfall2Gauntlet/Variant_Shooter/UI",
			"Titanfall2Gauntlet/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
