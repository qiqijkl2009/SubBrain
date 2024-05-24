using System.Collections.Generic;

namespace DataTable
{
    public class GameAction
    {
        public static readonly Dictionary<string, GameActionModel> Data = new()
        {
            {
                "TryToRecall", new GameActionModel
                (
                    "TryToRecall", "努力回忆", new CharacterResource(1), CharacterResource.None,
                    new GameActionUIInfo("努力回忆"),
                    "GetThatEvent", new object[] { "Headache" },
                    null, null
                )
            },
            {
                "GiveUpThinking", new GameActionModel
                (
                    "GiveUpThinking", "放弃思考", new CharacterResource(-1), CharacterResource.None,
                    new GameActionUIInfo("放弃思考"),
                    "GetThatEvent", new object[] { "Headache" },
                    null, null
                )
            },
            {
                "CloseEyes", new GameActionModel
                (
                    "CloseEyes", "闭上眼睛", CharacterResource.None, CharacterResource.None,
                    new GameActionUIInfo("闭上眼睛"),
                    "GetThatEvent", new object[] { "MemoryFlash" },
                    null, null
                )
            },
            {
                "ObserveLeft", new GameActionModel
                (
                    "ObserveLeft", "观察左边", CharacterResource.None, CharacterResource.None,
                    new GameActionUIInfo("观察左边"),
                    "GetThatEvent", new object[] { "GetPhoto" },
                    "GetProps", new object[] { new PropCreator[] { new(Prop.Data["Photo"]) } }
                )
            },
            {
                "ObserveRight", new GameActionModel
                (
                    "ObserveRight", "观察右边", CharacterResource.None, CharacterResource.None,
                    new GameActionUIInfo("观察右边"),
                    "GetThatEvent", new object[] { "GetPressCard" },
                    "GetProps", new object[] { new PropCreator[] { new(Prop.Data["PressCard"]) } }
                )
            },
            {
                "LeaveTheBed", new GameActionModel
                (
                    "LeaveTheBed", "从床上下来", CharacterResource.None, CharacterResource.None,
                    new GameActionUIInfo("从床上下来"),
                    "GetThatEvent", new object[] { "GetOffBed" },
                    null, null
                )
            },
            {
                "WaitAndSee", new GameActionModel
                (
                    "WaitAndSee", "静观其变", CharacterResource.None, CharacterResource.None,
                    new GameActionUIInfo("静观其变"),
                    "GetThatEvent", new object[] { "NurseEnterRoom_WithoutPill" },
                    null, null
                )
            },
            {
                "OpenEyes", new GameActionModel
                (
                    "OpenEyes", "睁开眼睛", CharacterResource.None, CharacterResource.None,
                    new GameActionUIInfo("睁开眼睛"),
                    "GetThatEvent", new object[] { "NurseEnterRoom_WithPill" },
                    null, null
                )
            },
            {
                "ToldWhoAreYou", new GameActionModel
                (
                    "ToldWhoAreYou", "说你是谁", new CharacterResource(-1), CharacterResource.None,
                    new GameActionUIInfo("﹁你是谁﹂"),
                    "GetThatEvent", new object[] { "TalkAboutAmnesia" },
                    null, null
                )
            },
            {
                "ToldHeadache", new GameActionModel
                (
                    "ToldHeadache", "说头很痛", new CharacterResource(1), CharacterResource.None,
                    new GameActionUIInfo("﹁头很痛﹂"),
                    "GetThatEvent", new object[] { "ConcealAmnesia" },
                    null, null
                )
            },
            {
                "TakePills", new GameActionModel
                (
                    "TakePills", "吃药", new CharacterResource(-1), CharacterResource.None,
                    new GameActionUIInfo("吃药"),
                    "GetThatEvent", new object[] { "ComaByPill" },
                    null, null
                )
            },
            {
                "RefuseTakePills", new GameActionModel
                ("RefuseTakePills", "拒绝吃药", CharacterResource.None, CharacterResource.None,
                    new GameActionUIInfo("拒绝"),
                    "GetThatEvent", new object[] { "RefuseTakePills" },
                    null, null
                )
            },
            {
                "PretendToTakePills", new GameActionModel
                (
                    "PretendToTakePills", "假装吃药", new CharacterResource(1), new CharacterResource(2),
                    new GameActionUIInfo("假装吃药"),
                    "GetThatEvent", new object[] { "AfterTakePillsFake" },
                    "GetProps", new object[] { new PropCreator[] { new(Prop.Data["Pill"]) } }
                )
            },
            {
                "Sleep", new GameActionModel
                (
                    "Sleep", "睡觉", new CharacterResource(-1), CharacterResource.None,
                    new GameActionUIInfo("睡觉"),
                    "GetThatEvent", new object[] { "Dream" },
                    null, null
                )
            },
            {
                "SearchSurrounding", new GameActionModel
                (
                    "SearchSurrounding", "搜索周边", CharacterResource.None, CharacterResource.None,
                    new GameActionUIInfo("搜索周边"),
                    "GetThatEvent", new object[] { "BedOrCupboard" },
                    null, null
                )
            },
            {
                "SearchBed", new GameActionModel
                (
                    "SearchBed", "翻找床铺", CharacterResource.None, CharacterResource.None,
                    new GameActionUIInfo("翻找床铺"),
                    "GetThatEvent", new object[] { "GetRecordPen" },
                    "GetProps", new object[] { new PropCreator[] { new(Prop.Data["RecordPen"]) } }
                )
            },
            {
                "SearchCupboard", new GameActionModel
                (
                    "SearchCupboard", "翻找柜子", CharacterResource.None, CharacterResource.None,
                    new GameActionUIInfo("翻找柜子"),
                    "GetThatEvent", new object[] { "GetPatientBook" },
                    "GetProps", new object[] { new PropCreator[] { new(Prop.Data["PatientBook"]) } }
                )
            },
            {
                "TakeItem", new GameActionModel
                (
                    "TakeItem", "收起来", CharacterResource.None, CharacterResource.None,
                    new GameActionUIInfo("收起来"),
                    "GetThatEvent", new object[] { "PlanToTakeAction" },
                    null, null
                )
            },
            {
                "SearchTheRoom", new GameActionModel
                (
                    "SearchTheRoom", "搜索房间", new CharacterResource(1), CharacterResource.None,
                    new GameActionUIInfo("搜索房间"),
                    "GetThatEvent", new object[] { "ToiletOrLocker" },
                    null, null
                )
            },
            {
                "SearchToilet", new GameActionModel
                (
                    "SearchToilet", "卫生间", CharacterResource.None, CharacterResource.None,
                    new GameActionUIInfo("卫生间"),
                    "GetThatEvent", new object[] { "ObserveToilet" },
                    null, null
                )
            },
            {
                "SearchLocker", new GameActionModel
                (
                    "SearchLocker", "储物柜", CharacterResource.None, CharacterResource.None,
                    new GameActionUIInfo("储物柜"),
                    "GetThatEvent", new object[] { "ObserveLocker" },
                    null, null
                )
            },
            {
                "SearchOtherPlace", new GameActionModel
                (
                    "SearchOtherPlace", "查看其他地方", CharacterResource.None, CharacterResource.None,
                    new GameActionUIInfo("查看其他地方"),
                    "GetThatEvent", new object[] { "ObserveWall" },
                    null, null
                )
            },
            {
                "KeepSearching", new GameActionModel
                (
                    "KeepSearching", "继续翻找", new CharacterResource(1), CharacterResource.None,
                    new GameActionUIInfo("继续翻找"),
                    "GetThatEvent", new object[] { "FindPaperPiece" },
                    "GetProps", new object[] { new PropCreator[] { new(Prop.Data["PaperPiece"]) } }
                )
            },
            {
                "FeelConfused", new GameActionModel
                (
                    "FeelConfused", "不明所以", CharacterResource.None, CharacterResource.None,
                    new GameActionUIInfo("不明所以"),
                    "GetThatEvent", new object[] { "ListenToNeighbour" },
                    null, null
                )
            },
            {
                "TakePaperPiece", new GameActionModel
                (
                    "TakePaperPiece", "收起纸条", CharacterResource.None, CharacterResource.None,
                    new GameActionUIInfo("收起纸条"),
                    "GetThatEvent", new object[] { "ListenToNeighbour" },
                    null, null  
                )
            },
            {
                "GoOut", new GameActionModel
                (
                    "GoOut", "直接出门", CharacterResource.None, CharacterResource.None,
                    new GameActionUIInfo("直接出门"),
                    "GetThatEvent", new object[] { "NoOneInCorridor" },
                    null, null
                )
            },
            {
                "大声呼叫",
                new GameActionModel("大声呼叫", "大声呼叫", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("大声呼叫"),
                    "GetThatEvent", new object[] { "GuardCome" },
                    null, null)
            },
            {
                "观察走廊",
                new GameActionModel("观察走廊", "观察走廊", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("观察走廊"),
                    "GetThatEvent", new object[] { "ObserveNeighbour" },
                    null, null)
            },
            {
                "回头",
                new GameActionModel("回头", "回头", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("回头"),
                    "GetThatEvent", new object[] { "End1" },
                    null, null)
            },
            {
                "开一条缝",
                new GameActionModel("开一条缝", "开一条缝", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("开一条缝"),
                    "GetThatEvent", new object[] { "LockInBox" },
                    null, null)
            },
            {
                "不开门",
                new GameActionModel("不开门", "不开门", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("不开门"),
                    "GetThatEvent", new object[] { "ShoutInCorridor" },
                    null, null)
            },
            {
                "回到病房",
                new GameActionModel("回到病房", "回到病房", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("回到病房"),
                    "GetThatEvent", new object[] { "GoBackToOwnRoom" },
                    null, null)
            },
            {
                "逃走",
                new GameActionModel("逃走", "逃走", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("逃走"),
                    "GetThatEvent", new object[] { "RunIntoTheHall" },
                    null, null)
            },
            {
                "观察四周",
                new GameActionModel("观察四周", "观察四周", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("观察四周"),
                    "GetThatEvent", new object[] { "SeeFile" },
                    null, null)
            },
            {
                "逃离",
                new GameActionModel("逃离", "逃离", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("逃离"),
                    "GetThatEvent", new object[] { "AbandonExit" },
                    null, null)
            },
            {
                "捡起来",
                new GameActionModel("捡起来", "捡起来", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("捡起来"),
                    "GetThatEvent", new object[] { "GetFile" },
                    null, null)
            },
            {
                "不捡",
                new GameActionModel("不捡", "不捡", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("不捡"),
                    "GetThatEvent", new object[] { "NotGetFile" },
                    null, null)
            },
            {
                "继续调查",
                new GameActionModel("继续调查", "继续调查", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("继续调查"),
                    "GetThatEvent", new object[] { "HeardOfMissing198" },
                    null, null)
            },
            {
                "返回房间",
                new GameActionModel("返回房间", "返回房间", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("返回房间"),
                    "GetThatEvent", new object[] { "GoBackToOwnRoom" },
                    null, null)
            },
            {
                "继续跟踪",
                new GameActionModel("继续跟踪", "继续跟踪", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("继续跟踪"),
                    "GetThatEvent", new object[] { "LoseTarget" },
                    null, null)
            },
            {
                "调查此处",
                new GameActionModel("调查此处", "调查此处", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("调查此处"),
                    "GetThatEvent", new object[] { "FileRoomLocked" },
                    null, null)
            },
            {
                "尝试开门",
                new GameActionModel("尝试开门", "尝试开门", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("尝试开门"),
                    "GetThatEvent", new object[] { "KeyNotPair" },
                    null, null)
            },
            {
                "进入那个病房",
                new GameActionModel("进入那个病房", "进入那个病房", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("进入那个病房"),
                    "GetThatEvent", new object[] { "PatientInHappiness" },
                    null, null)
            },
            {
                "往左走",
                new GameActionModel("往左走", "往左走", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("往左走"),
                    "GetThatEvent", new object[] { "AnOpenedDoor" },
                    null, null)
            },
            {
                "往右走",
                new GameActionModel("往右走", "往右走", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("往右走"),
                    "GetThatEvent", new object[] { "GoBackToOwnRoom" },
                    null, null)
            },
            {
                "打招呼",
                new GameActionModel("打招呼", "打招呼", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("打招呼"),
                    "GetThatEvent", new object[] { "HideInToilet" },
                    null, null)
            },
            {
                "退出房间",
                new GameActionModel("退出房间", "退出房间", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("退出房间"),
                    "GetThatEvent", new object[] { "GetOutOfTheRoom" },
                    null, null)
            },
            {
                "自我催眠",
                new GameActionModel("自我催眠", "自我催眠", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("自我催眠"),
                    "GetThatEvent", new object[] { "FoundByNurse" },
                    null, null)
            },
            {
                "去马桶呕吐",
                new GameActionModel("去马桶呕吐", "去马桶呕吐", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("去马桶呕吐"),
                    "GetThatEvent", new object[] { "PressFlushButton" },
                    null, null)
            },
            {
                "被带回病房",
                new GameActionModel("被带回病房", "被带回病房", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("被带回病房"),
                    "GetThatEvent", new object[] { "QuestionNurse" },
                    null, null)
            },
            {
                "吃今天的药",
                new GameActionModel("吃今天的药", "吃今天的药", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("吃今天的药"),
                    "GetThatEvent", new object[] { "TalkAboutIllness" },
                    null, null)
            },
            {
                "询问家人情况",
                new GameActionModel("询问家人情况", "询问家人情况", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("询问家人情况"),
                    "GetThatEvent", new object[] { "TalkAboutFamily" },
                    null, null)
            },
            {
                "配合治疗",
                new GameActionModel("配合治疗", "配合治疗", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("配合治疗"),
                    "GetThatEvent", new object[] { "LeaveHospital" },
                    null, null)
            },
            {
                "上前拥抱",
                new GameActionModel("上前拥抱", "上前拥抱", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("上前拥抱"),
                    "GetThatEvent", new object[] { "TalkToHusband" },
                    null, null)
            },
            {
                "与丈夫回家",
                new GameActionModel("与丈夫回家", "与丈夫回家", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("与丈夫回家"),
                    "GetThatEvent", new object[] { "GetPhotoPiece" },
                    null, null)
            },
            {
                "盯着照片看",
                new GameActionModel("盯着照片看", "盯着照片看", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("盯着照片看"),
                    "GetThatEvent", new object[] { "End5" },
                    null, null)
            },
            {
                "找出药物服用",
                new GameActionModel("找出药物服用", "找出药物服用", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("找出药物服用"),
                    "GetThatEvent", new object[] { "End4" },
                    null, null)
            },
            {
                "离开厕所",
                new GameActionModel("离开厕所", "离开厕所", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("离开厕所"),
                    "GetThatEvent", new object[] { "CaughtByGuard" },
                    null, null)
            },
            {
                "感到不安",
                new GameActionModel("感到不安", "感到不安", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("感到不安"),
                    "GetThatEvent", new object[] { "AskToLeave" },
                    null, null)
            },
            {
                "要求拨打电话",
                new GameActionModel("要求拨打电话", "要求拨打电话", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("要求拨打电话"),
                    "GetThatEvent", new object[] { "FamiliarVoice" },
                    null, null)
            },
            {
                "挂断电话",
                new GameActionModel("挂断电话", "挂断电话", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("挂断电话"),
                    "GetThatEvent", new object[] { "AwareOfHelpless" },
                    null, null)
            },
            {
                "假装配合",
                new GameActionModel("假装配合", "假装配合", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("假装配合"),
                    "GetThatEvent", new object[] { "PlanToGetInfomation" },
                    null, null)
            },
            {
                "坐在角落",
                new GameActionModel("坐在角落", "坐在角落", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("坐在角落"),
                    "GetThatEvent", new object[] { "ObservePatientEmotion" },
                    null, null)
            },
            {
                "坐在前排",
                new GameActionModel("坐在前排", "坐在前排", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("坐在前排"),
                    "GetThatEvent", new object[] { "GetMemoryBack" },
                    null, null)
            },
            {
                "回头看向他",
                new GameActionModel("回头看向他", "回头看向他", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("回头看向他"),
                    "GetThatEvent", new object[] { "DontBeAlert" },
                    null, null)
            },
            {
                "前往密室",
                new GameActionModel("前往密室", "前往密室", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("前往密室"),
                    "GetThatEvent", new object[] { "GetIntoSecretRoom" },
                    null, null)
            },
            {
                "开口询问",
                new GameActionModel("开口询问", "开口询问", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("开口询问"),
                    "GetThatEvent", new object[] { "ConfuseTalk" },
                    null, null)
            },
            {
                "“我是布兰妮。”",
                new GameActionModel("“我是布兰妮。”", "“我是布兰妮。”", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("“我是布兰妮。”"),
                    "GetThatEvent", new object[] { "ShowPressCard" },
                    null, null)
            },
            {
                "进一步询问",
                new GameActionModel("进一步询问", "进一步询问", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("进一步询问"),
                    "GetThatEvent", new object[] { "ExplanationFromR" },
                    null, null)
            },
            {
                "“我该怎么做？”",
                new GameActionModel("“我该怎么做？”", "“我该怎么做？”", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("“我该怎么做？”"),
                    "GetThatEvent", new object[] { "HintFromR1" },
                    null, null)
            },
            {
                "尝试把门拉开",
                new GameActionModel("尝试把门拉开", "尝试把门拉开", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("尝试把门拉开"),
                    "GetThatEvent", new object[] { "GuardCome" },
                    null, null)
            },
            {
                "输入2333",
                new GameActionModel("输入2333", "输入2333", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("输入2333"),
                    "GetThatEvent", new object[] { "GuardCome" },
                    null, null)
            },
            {
                "输入8848",
                new GameActionModel("输入8848", "输入8848", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("输入8848"),
                    "GetThatEvent", new object[] { "GuardCome" },
                    null, null)
            },
            {
                "离开档案室",
                new GameActionModel("离开档案室", "离开档案室", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("离开档案室"),
                    "GetThatEvent", new object[] { "BestChanceToRun" },
                    null, null)
            },
            {
                "逃出医院",
                new GameActionModel("逃出医院", "逃出医院", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("逃出医院"),
                    "GetThatEvent", new object[] { "GetOutOfHospital" },
                    null, null)
            },
            {
                "找其他出口",
                new GameActionModel("找其他出口", "找其他出口", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("找其他出口"),
                    "GetThatEvent", new object[] { "GuardCome" },
                    null, null)
            },
            {
                "向他讲述遭遇",
                new GameActionModel("向他讲述遭遇", "向他讲述遭遇", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("向他讲述遭遇"),
                    "GetThatEvent", new object[] { "EnterPress1" },
                    null, null)
            },
            {
                "不知如何反驳",
                new GameActionModel("不知如何反驳", "不知如何反驳", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("不知如何反驳"),
                    "GetThatEvent", new object[] { "GetCaughtToHospital" },
                    null, null)
            },
            {
                "回到医院",
                new GameActionModel("回到医院", "回到医院", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("回到医院"),
                    "GetThatEvent", new object[] { "End2" },
                    null, null)
            },
            {
                "回家",
                new GameActionModel("回家", "回家", CharacterResource.None, CharacterResource.None, new GameActionUIInfo("回家"),
                    "GetThatEvent", new object[] { "HateFather" },
                    null, null)
            },
        };
    }
}