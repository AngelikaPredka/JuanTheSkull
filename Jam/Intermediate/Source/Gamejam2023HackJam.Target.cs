using UnrealBuildTool;

public class Gamejam2023HackJamTarget : TargetRules
{
	public Gamejam2023HackJamTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Gamejam2023HackJam");
	}
}
