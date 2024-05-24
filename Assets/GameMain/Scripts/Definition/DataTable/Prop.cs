using System.Collections.Generic;

namespace DataTable
{
    public class Prop
    {
        public static readonly Dictionary<string, PropModel> Data = new()
        {
            {
                "Pill", new PropModel
                (
                    "Pill", "药丸", null, 1,
                    new PropUIInfo("药丸", "药丸"), null,
                    null, null,
                    null, null,
                    "ChangeEvent", new object[] { new[] { "Observation", "End3" }, new[] { "Headache", "HateFather" } },
                    null, null
                )
            },
            {
                "Photo", new PropModel
                (
                    "Photo", "照片", null, 1,
                    new PropUIInfo("照片", "照片"), null,
                    null, null,
                    null, null,
                    "ChangeEvent", new object[] { new[] { "StickPhotoTogether" }, new[] { "GetPhotoPiece" } },
                    null, null
                )
            },
            {
                "PressCard", new PropModel
                (
                    "PressCard", "记者证", null, 1,
                    new PropUIInfo("记者证", "记者证"), null,
                    null, null,
                    null, null,
                    null, null,
                    null, null
                )
            },
            {
                "RecordPen", new PropModel
                (
                    "RecordPen", "录音笔", null, 1,
                    new PropUIInfo("录音笔", "录音笔"), null,
                    null, null,
                    null, null,
                    "ChangeEvent", new object[] { new[] { "RecordTheScene" }, new[] { "LockInBox" } },
                    null, null
                )
            },
            {
                "PatientBook", new PropModel
                (
                    "PatientBook", "病历本", null, 1,
                    new PropUIInfo("笔记本", "病历本"), null,
                    null, null,
                    null, null,
                    "ChangeEvent", new object[] { new[] { "HintFromR2" }, new[] { "ExplanationFromR" } },
                    null, null
                )
            },
            {
                "Key1", new PropModel
                (
                    "Key1", "钥匙1", null, 1,
                    new PropUIInfo("钥匙01", "钥匙"), null,
                    null, null,
                    null, null,
                    "ChangeEvent", new object[] { new[] { "GetOutOfHospital" }, new[] { "AbandonExit" } },
                    null, null
                )
            },
            {
                "Key2", new PropModel
                (
                    "Key2", "钥匙2", null, 1,
                    new PropUIInfo("钥匙02", "钥匙"), null,
                    null, null,
                    null, null,
                    "ChangeEvent", new object[] { new[] { "NeedPassword" }, new[] { "GetIntoSecretRoom" } },
                    null, null
                )
            },
            {
                "ExperimentRecord", new PropModel
                (
                    "ExperimentRecord", "实验记录", null, 1,
                    new PropUIInfo("档案袋", "实验记录"), null,
                    null, null,
                    null, null,
                    "ChangeEvent", new object[] { new[] { "HeadLiner" }, new[] { "EnterPress1" } },
                    null, null
                )
            },
            {
                "PaperPiece", new PropModel
                (
                    "PaperPiece", "纸条", null, 1,
                    new PropUIInfo("纸条", "纸条"), null,
                    null, null,
                    null, null,
                    "ChangeEvent", new object[] { new[] { "Password" }, new[] { "CaughtByGuard" } },
                    null, null
                )
            },
            {
                "Password", new PropModel
                (
                    "Password", "9563", null, 1,
                    new PropUIInfo("纸条", "9563"), null,
                    null, null,
                    null, null,
                    "ChangeEvent", new object[] { new[] { "OpenBox" }, new[] { "NeedPassword" } },
                    null, null
                )
            },
        };
    }
}