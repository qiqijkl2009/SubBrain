using System.Collections.Generic;

namespace DataTable
{
    public class GameAction
    {
        public static Dictionary<string, GameActionModel> Data = new()
        {
            {
                "努力回忆",
                new GameActionModel("努力回忆", "努力回忆", new CharacterResource(1), CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "Headache" },
                    null, null)
            },
            {
                "放弃思考",
                new GameActionModel("放弃思考", "放弃思考", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "Headache" },
                    null, null)
            },
            {
                "闭上眼睛",
                new GameActionModel("闭上眼睛", "闭上眼睛", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "MemoryFlash" },
                    null, null)
            },
            {
                "观察左边",
                new GameActionModel("观察左边", "观察左边", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "GetPhoto" },
                    null, null)
            },
            {
                "观察右边",
                new GameActionModel("观察右边", "观察右边", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "GetPressCard" },
                    null, null)
            },
            {
                "睁开眼睛",
                new GameActionModel("睁开眼睛", "睁开眼睛", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "NurseEnterRoom1" },
                    null, null)
            },
            {
                "从床上下来",
                new GameActionModel("从床上下来", "从床上下来", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "GetOffBed" },
                    null, null)
            },
            {
                "静观其变",
                new GameActionModel("静观其变", "静观其变", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "NurseEnterRoom2" },
                    null, null)
            },
            {
                "搜索房间1",
                new GameActionModel("搜索房间1", "搜索房间", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "WhichToRummage1" },
                    null, null)
            },
            {
                "搜索房间2",
                new GameActionModel("搜索房间2", "搜索房间", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "WhichToRummage2" },
                    null, null)
            },
            {
                "搜索房间3",
                new GameActionModel("搜索房间2", "搜索房间", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "WhichToRummage3" },
                    null, null)
            },
            {
                "翻找床铺1",
                new GameActionModel("翻找床铺1", "翻找床铺", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "GetRecordPen1" },
                    null, null)
            },
            {
                "翻找柜子1",
                new GameActionModel("翻找柜子1", "翻找柜子", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "GetPatientRecord1" },
                    null, null)
            },
            {
                "翻找床铺2",
                new GameActionModel("翻找床铺2", "翻找床铺", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "GetRecordPen2" },
                    null, null)
            },
            {
                "翻找柜子2",
                new GameActionModel("翻找柜子2", "翻找柜子", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "GetPatientRecord2" },
                    null, null)
            },
            {
                "卫生间",
                new GameActionModel("卫生间", "卫生间", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "ObserveToilet" },
                    null, null)
            },
            {
                "储物柜",
                new GameActionModel("储物柜", "储物柜", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "ObserveCloset" },
                    null, null)
            },
            {
                "收起来",
                new GameActionModel("收起来", "收起来", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "NurseEnterRoom2" },
                    null, null)
            },
            {
                "思考",
                new GameActionModel("思考", "思考", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "PlanToTakeAction" },
                    null, null)
            },
            {
                "“头很痛”1",
                new GameActionModel("“头很痛”1", "“头很痛”", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "ConcealAmnesia1" },
                    null, null)
            },
            {
                "“头很痛”2",
                new GameActionModel("“头很痛”2", "“头很痛”", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "ConcealAmnesia1" },
                    null, null)
            },
            {
                "“你是谁”",
                new GameActionModel("“你是谁”", "“你是谁”", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "TalkAboutAmnesia" },
                    null, null)
            },
            {
                "吃药",
                new GameActionModel("吃药", "吃药", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "ComaByPill" },
                    null, null)
            },
            {
                "拒绝",
                new GameActionModel("拒绝", "拒绝", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "RefusePill" },
                    null, null)
            },
            {
                "假装吃药1",
                new GameActionModel("假装吃药1", "假装吃药", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "TakePill1" },
                    null, null)
            },
            {
                "假装吃药2",
                new GameActionModel("假装吃药2", "假装吃药", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "TakePill2" },
                    null, null)
            },
            {
                "直接出门",
                new GameActionModel("直接出门", "直接出门", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "NoOneInCorridor" },
                    null, null)
            },
            {
                "睡觉",
                new GameActionModel("睡觉", "睡觉", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "Dream" },
                    null, null)
            },
            {
                "查看其他地方",
                new GameActionModel("查看其他地方", "查看其他地方", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "ObserveWall" },
                    null, null)
            },
            {
                "继续翻找",
                new GameActionModel("继续翻找", "继续翻找", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "FindPaperPiece" },
                    null, null)
            },
            {
                "不明所以",
                new GameActionModel("不明所以", "不明所以", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "LisentToNeighbour" },
                    null, null)
            },
            {
                "收起纸条",
                new GameActionModel("收起纸条", "收起纸条", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "LisentToNeighbour" },
                    null, null)
            },
            {
                "大声呼叫",
                new GameActionModel("大声呼叫", "大声呼叫", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "GuardCome" },
                    null, null)
            },
            {
                "观察走廊",
                new GameActionModel("观察走廊", "观察走廊", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "ObserveNeighbour" },
                    null, null)
            },
            {
                "回头",
                new GameActionModel("回头", "回头", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "End1" },
                    null, null)
            },
            {
                "开一条缝",
                new GameActionModel("开一条缝", "开一条缝", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "LockInBox" },
                    null, null)
            },
            {
                "不开门",
                new GameActionModel("不开门", "不开门", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "ShoutInCorridor" },
                    null, null)
            },
            {
                "回到病房",
                new GameActionModel("回到病房", "回到病房", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "GoBackToOwnRoom" },
                    null, null)
            },
            {
                "逃走",
                new GameActionModel("逃走", "逃走", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "RunIntoTheHall" },
                    null, null)
            },
            {
                "观察四周",
                new GameActionModel("观察四周", "观察四周", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "SeeFile" },
                    null, null)
            },
            {
                "逃离",
                new GameActionModel("逃离", "逃离", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "AbandonExit" },
                    null, null)
            },
            {
                "捡起来",
                new GameActionModel("捡起来", "捡起来", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "GetFile" },
                    null, null)
            },
            {
                "不捡",
                new GameActionModel("不捡", "不捡", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "NotGetFile" },
                    null, null)
            },
            {
                "继续调查",
                new GameActionModel("继续调查", "继续调查", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "HeardOfMissing198" },
                    null, null)
            },
            {
                "返回房间",
                new GameActionModel("返回房间", "返回房间", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "GoBackToOwnRoom" },
                    null, null)
            },
            {
                "继续跟踪",
                new GameActionModel("继续跟踪", "继续跟踪", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "LoseTarget" },
                    null, null)
            },
            {
                "调查此处",
                new GameActionModel("调查此处", "调查此处", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "FileRoomLocked" },
                    null, null)
            },
            {
                "尝试开门",
                new GameActionModel("尝试开门", "尝试开门", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "KeyNotPair" },
                    null, null)
            },
            {
                "进入那个病房",
                new GameActionModel("进入那个病房", "进入那个病房", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "PatientInHappiness" },
                    null, null)
            },
            {
                "往左走",
                new GameActionModel("往左走", "往左走", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "AnOpenedDoor" },
                    null, null)
            },
            {
                "往右走",
                new GameActionModel("往右走", "往右走", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "GoBackToOwnRoom" },
                    null, null)
            },
            {
                "打招呼",
                new GameActionModel("打招呼", "打招呼", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "HideInToilet" },
                    null, null)
            },
            {
                "自我催眠",
                new GameActionModel("自我催眠", "自我催眠", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "FoundByNurse" },
                    null, null)
            },
            {
                "去马桶呕吐",
                new GameActionModel("去马桶呕吐", "去马桶呕吐", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "PressFlushButton" },
                    null, null)
            },
            {
                "被带回病房",
                new GameActionModel("被带回病房", "被带回病房", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "QuestionNurse" },
                    null, null)
            },
            {
                "吃今天的药",
                new GameActionModel("吃今天的药", "吃今天的药", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "TalkAboutIllness" },
                    null, null)
            },
            {
                "询问家人情况",
                new GameActionModel("询问家人情况", "询问家人情况", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "TalkAboutFamily" },
                    null, null)
            },
            {
                "配合治疗",
                new GameActionModel("配合治疗", "配合治疗", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "LeaveHospital" },
                    null, null)
            },
            {
                "上前拥抱",
                new GameActionModel("上前拥抱", "上前拥抱", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "TalkToHusband" },
                    null, null)
            },
            {
                "与丈夫回家",
                new GameActionModel("与丈夫回家", "与丈夫回家", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "GetPhotoPiece" },
                    null, null)
            },
            {
                "找出药物服用",
                new GameActionModel("找出药物服用", "找出药物服用", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "End4" },
                    null, null)
            },
            {
                "离开厕所",
                new GameActionModel("离开厕所", "离开厕所", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "CaughtByGuard" },
                    null, null)
            },
            {
                "感到不安",
                new GameActionModel("感到不安", "感到不安", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "AskToLeave" },
                    null, null)
            },
            {
                "要求拨打电话",
                new GameActionModel("要求拨打电话", "要求拨打电话", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "FamiliarVoice" },
                    null, null)
            },
            {
                "挂断电话",
                new GameActionModel("挂断电话", "挂断电话", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "AwareOfHelpless" },
                    null, null)
            },
            {
                "假装配合",
                new GameActionModel("假装配合", "假装配合", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "PlanToGetInfomation" },
                    null, null)
            },
            {
                "坐在角落",
                new GameActionModel("坐在角落", "坐在角落", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "ObservePatientEmotion" },
                    null, null)
            },
            {
                "坐在前排",
                new GameActionModel("坐在前排", "坐在前排", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "GetMemoryBack" },
                    null, null)
            },
            {
                "回头看向他",
                new GameActionModel("回头看向他", "回头看向他", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "DontBeAlert" },
                    null, null)
            },
            {
                "前往密室",
                new GameActionModel("前往密室", "前往密室", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "GetIntoSecretRoom" },
                    null, null)
            },
            {
                "开口询问",
                new GameActionModel("开口询问", "开口询问", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "ConfuseTalk" },
                    null, null)
            },
            {
                "“我是布兰妮。”",
                new GameActionModel("“我是布兰妮。”", "“我是布兰妮。”", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "ShowPressCard" },
                    null, null)
            },
            {
                "进一步询问",
                new GameActionModel("进一步询问", "进一步询问", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "ExplanationFromR" },
                    null, null)
            },
            {
                "“我该怎么做？”",
                new GameActionModel("“我该怎么做？”", "“我该怎么做？”", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "HintFromR1" },
                    null, null)
            },
            {
                "尝试把门拉开",
                new GameActionModel("尝试把门拉开", "尝试把门拉开", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "GuardCome" },
                    null, null)
            },
            {
                "输入2333",
                new GameActionModel("输入2333", "输入2333", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "GuardCome" },
                    null, null)
            },
            {
                "输入8848",
                new GameActionModel("输入8848", "输入8848", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "GuardCome" },
                    null, null)
            },
            {
                "离开档案室",
                new GameActionModel("离开档案室", "离开档案室", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "BestChanceToRun" },
                    null, null)
            },
            {
                "逃出医院",
                new GameActionModel("逃出医院", "逃出医院", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "GetOutOfHospital" },
                    null, null)
            },
            {
                "找其他出口",
                new GameActionModel("找其他出口", "找其他出口", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "GuardCome" },
                    null, null)
            },
            {
                "向他讲述遭遇",
                new GameActionModel("向他讲述遭遇", "向他讲述遭遇", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "EnterPress1" },
                    null, null)
            },
            {
                "不知如何反驳",
                new GameActionModel("不知如何反驳", "不知如何反驳", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "GetCaughtToHospital" },
                    null, null)
            },
            {
                "回到医院",
                new GameActionModel("回到医院", "回到医院", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "End2" },
                    null, null)
            },
            {
                "回家",
                new GameActionModel("回家", "回家", CharacterResource.None, CharacterResource.None, new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "HateFather" },
                    null, null)
            },
        };
    }
}