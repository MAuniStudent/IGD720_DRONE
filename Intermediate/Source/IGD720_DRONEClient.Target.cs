using UnrealBuildTool;

public class IGD720_DRONEClientTarget : TargetRules
{
	public IGD720_DRONEClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("IGD720_DRONE");
	}
}
