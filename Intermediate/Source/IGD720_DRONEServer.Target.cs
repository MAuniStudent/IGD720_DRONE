using UnrealBuildTool;

public class IGD720_DRONEServerTarget : TargetRules
{
	public IGD720_DRONEServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("IGD720_DRONE");
	}
}
