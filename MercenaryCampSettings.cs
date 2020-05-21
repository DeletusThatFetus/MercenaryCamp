using System.Xml.Serialization;
using ModLib.Definitions;
using ModLib.Definitions.Attributes;
using ModLib.Patches;
using ModLib;

namespace MercenaryCamp
{
    public class MercenaryCampSettings : SettingsBase
    {
        public const string InstanceID = "MercenaryCamp";
        public override string ModName => "Mercenary Camp";
        public override string ModuleFolderName => "MercenaryCamp";
        [XmlElement]
        public override string ID { get; set; } = InstanceID;

        public static Settings Instance
        {
            get
            {
                return (Settings)SettingsDatabase.GetSettings<MercenaryCampSettings>();
            }
        }

        [XmlElement]
        [SettingProperty("Some Multiplier", 1f, 3f, "This is a multiplier")]
        [SettingPropertyGroup("Group 1")]
        public float SomeMultiplier { get; set; } = 1.5f;
        [XmlElement]
        [SettingProperty("Some multiplier Enabled", "Enables SomeMultiplier")]
        [SettingPropertyGroup("Group 1")]
        public bool MultiplierEnabled { get; set; } = true;
        [XmlElement]
        [SettingProperty("Some Other Multiplier", 1f, 3f, "This is another multiplier")]
        [SettingPropertyGroup("Group 2")]
        public float SomeOtherMultiplier { get; set; } = 1.5f;
    }
}