using UnrealBuildTool;

public class Gamejam2023HackJamClientTarget : TargetRules
{
	public Gamejam2023HackJamClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Gamejam2023HackJam");
	}
}
