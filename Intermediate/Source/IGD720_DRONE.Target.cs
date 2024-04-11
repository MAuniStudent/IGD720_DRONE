using UnrealBuildTool;

public class IGD720_DRONETarget : TargetRules
{
	public IGD720_DRONETarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("IGD720_DRONE");
	}
}
