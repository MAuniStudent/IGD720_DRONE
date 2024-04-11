using UnrealBuildTool;

public class IGD720_DRONEEditorTarget : TargetRules
{
	public IGD720_DRONEEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("IGD720_DRONE");
	}
}
