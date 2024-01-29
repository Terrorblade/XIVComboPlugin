using System;

namespace PrincessRTFM.XIVComboVX.Attributes;

[AttributeUsage(AttributeTargets.Field)]
internal class ConflictsAttribute: Attribute {
	public CustomComboPreset[] Conflicts { get; }
	internal ConflictsAttribute(params CustomComboPreset[] conflictingPresets) => this.Conflicts = conflictingPresets;
}
