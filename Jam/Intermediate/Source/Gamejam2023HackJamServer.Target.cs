using UnrealBuildTool;

public class Gamejam2023HackJamServerTarget : TargetRules
{
	public Gamejam2023HackJamServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Gamejam2023HackJam");
	}
}
