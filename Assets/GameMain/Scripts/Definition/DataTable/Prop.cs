using System.Collections.Generic;

namespace DataTable
{
    public class Prop
    {
        public static Dictionary<string, PropModel> Data = new()
        {
            {
                "Test", new PropModel("Test", "测试", null, 1, new PropUIInfo(), new AddBuffInfo[]
                    {
                        new(Buff.Data["Test"], null, 1, 1)
                    },
                    null, null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "Pill1",
                new PropModel("Pill", "药", null, 1,
                    new PropUIInfo("药丸", "药", null), null,
                    null, null,
                    null, null,
                    "ChangeEvent", new object[] { new string[] { "Observation" }, new string[] { "Headache" } },
                    null, null)
            },
            {
                "Pill2",
                new PropModel("Pill", "药", null, 1,
                    new PropUIInfo("药丸", "药", null), null,
                    null, null,
                    null, null,
                    "ChangeEvent", new object[] { new string[] { "End3" }, new string[] { "HateFather" } },
                    null, null)
            },
            {
                "Photo",
                new PropModel("Photo", "照片", null, 1,
                    new PropUIInfo("照片", "照片", null), null,
                    null, null,
                    null, null,
                    "ChangeEvent", new object[] { new string[] { "StickPhotoTogether" }, new string[] { "GetPhotoPiece" } },
                    null, null)
            },
            {
                "PressCard",
                new PropModel("PressCard", "记者证", null, 1,
                    new PropUIInfo("记者证", "记者证", null), null,
                    null, null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "RecordPen",
                new PropModel("RecordPen", "录音笔", null, 1,
                    new PropUIInfo("录音笔", "录音笔", null), null,
                    null, null,
                    null, null,
                    "ChangeEvent", new object[] { new string[] { "RecordTheScene" }, new string[] { "LockInBox" } },
                    null, null)
            },
            {
                "PatientBook",
                new PropModel("PatientBook", "病历本", null, 1,
                    new PropUIInfo("笔记本", "病历本", null), null,
                    null, null,
                    null, null,
                    "ChangeEvent", new object[] { new string[] { "HintFromR2" }, new string[] { "ExplanationFromR" } },
                    null, null)
            },
            {
                "Key1",
                new PropModel("Key1", "钥匙", null, 1,
                    new PropUIInfo("钥匙01", "钥匙", null), null,
                    null, null,
                    null, null,
                    "ChangeEvent", new object[] { new string[] { "GetOutOfHospital" }, new string[] { "AbandonExit" } },
                    null, null)
            },
            {
                "Key2",
                new PropModel("Key2", "钥匙", null, 1,
                    new PropUIInfo("钥匙02", "钥匙", null), null,
                    null, null,
                    null, null,
                    "ChangeEvent", new object[] { new string[] { "NeedPassword" }, new string[] { "GetIntoSecretRoom" } },
                    null, null)
            },
            {
                "ExperimentRecord",
                new PropModel("ExperimentRecord", "实验记录", null, 1,
                    new PropUIInfo("档案袋", "实验记录", null), null,
                    null, null,
                    null, null,
                    "ChangeEvent", new object[] { new string[] { "HeadLiner" }, new string[] { "EnterPress1" } },
                    null, null)
            },
            {
                "PaperPiece",
                new PropModel("PaperPiece", "纸条", null, 1,
                    new PropUIInfo("纸条", "纸条", null), null,
                    null, null,
                    null, null,
                    "ChangeEvent", new object[] { new string[] { "Password" }, new string[] { "CaughtByGuard" } },
                    null, null)
            },
            {
                "Password",
                new PropModel("Password", "9563", null, 1,
                    new PropUIInfo("纸条", "9563", null), null,
                    null, null,
                    null, null,
                    "ChangeEvent", new object[] { new string[] { "OpenBox" }, new string[] { "NeedPassword" } },
                    null, null)
            },
        };
    }
}