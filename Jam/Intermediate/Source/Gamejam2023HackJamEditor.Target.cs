using UnrealBuildTool;

public class Gamejam2023HackJamEditorTarget : TargetRules
{
	public Gamejam2023HackJamEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Gamejam2023HackJam");
	}
}
