using System.Collections.Generic;

namespace DataTable
{
    public class GameEvent
    {
        public static Dictionary<string, GameEventModel> Data = new()
        {
            {
                "WakeUp",
                new GameEventModel("WakeUp", "醒来", null, new GameActionModel[]
                    {
                        GameAction.Data["努力回忆"], GameAction.Data["放弃思考"]
                    },
                    new GameEventUIInfo("WakeUp", "醒来", "你在医院醒来，头很痛，你似乎丢失了一段记忆。"), "WakeUp",
                    null, null,
                    "GetProps", new object[] { new PropCreator[] { new PropCreator(Prop.Data["Pill1"], true) } },
                    null, null)
            },
            {
                "Headache",
                new GameEventModel("Headache", "头痛", null, new GameActionModel[]
                    {
                        GameAction.Data["闭上眼睛"]
                    },
                    new GameEventUIInfo("Headache", "头痛", "你头痛欲裂，无法思考任何任何事情。你完全记不起自己是谁，又为何在此处"), null,
                    null, null,
                    null, null,
                    null , null)
            },
            {
                "Observation",
                new GameEventModel("Observation", "观察", null, new GameActionModel[]
                    {
                        GameAction.Data["观察左边"], GameAction.Data["观察右边"]
                    },
                    new GameEventUIInfo("Observation", "观察", "过了一段时间，头痛逐渐缓解但你仍然全身乏力，只能躺着休息一会儿。\n你用眼睛观察周围。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "MemoryFlash",
                new GameEventModel("MemoryFlash", "记忆闪回", null, new GameActionModel[]
                    {
                        GameAction.Data["睁开眼睛"]
                    },
                    new GameEventUIInfo("MemoryFlash", "记忆闪回", "你眼前闪过一些画面，似乎是某个治疗场景。\n但头痛超过你的承受阈值，你昏迷过去，直到开门声。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "GetPhoto",
                new GameEventModel("GetPhoto", "获得照片", null, new GameActionModel[]
                    {
                        GameAction.Data["从床上下来"]
                    },
                    new GameEventUIInfo("GetPhoto", "获得照片", "你发现了一对夫妻的合照摆在床头，你发现合照的一角是撕裂的，于是你把里面的照片取了出来，果然这照片并不完整，你想要深入思考却感觉一阵头疼，你只好先把照片折起来放进口袋。"), null,
                    null, null,
                    "GetProps", new object[] { new PropCreator[] { new PropCreator(Prop.Data["Photo"], true) } },
                    null, null)
            },
            {
                "GetPressCard",
                new GameEventModel("GetPressCard", "获得记者证", null, new GameActionModel[]
                    {
                        GameAction.Data["从床上下来"]
                    },
                    new GameEventUIInfo("GetOffBed", "下床", "你在右手边（枕边）发现了一张记者证。虽然很简陋, 但证件上记载了一些信息。\n姓名：布兰妮\n职业：新闻记者\n年龄：37\n所属：WHS电视台新闻部\n职业编号：RY19580328\n有一张看不清五官的模糊女人画像"), null,
                    null, null,
                    "GetProps", new object[] { new PropCreator[] { new PropCreator(Prop.Data["PressCard"], true) } },
                    null, null)
            },
            {
                "GetOffBed",
                new GameEventModel("GetOffBed", "下床", null, new GameActionModel[]
                    {
                        GameAction.Data["静观其变"], GameAction.Data["搜索房间1"]
                    },
                    new GameEventUIInfo("GetOffBed", "下床", "你下床了，整个房间很大，房门紧闭似乎上锁了，房间里除了你没有其他人。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "WhichToRummage1",
                new GameEventModel("WhichToRummage1", "在房间内翻找", null, new GameActionModel[]
                    {
                        GameAction.Data["翻找床铺1"], GameAction.Data["翻找柜子1"]
                    },
                    new GameEventUIInfo("WhichToRummage", "在房间内翻找", "房间里的东西很少，一眼望去只有枕头下和柜子里收着一些东西。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "WhichToRummage2",
                new GameEventModel("WhichToRummage2", "在房间内翻找1", null, new GameActionModel[]
                    {
                        GameAction.Data["翻找床铺2"], GameAction.Data["翻找柜子2"]
                    },
                    new GameEventUIInfo("WhichToRummage", "在房间内翻找", "房间里的东西很少，一眼望去只有枕头下和柜子里收着一些东西。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "WhichToRummage3",
                new GameEventModel("WhichToRummage3", "在房间内翻找2", null, new GameActionModel[]
                    {
                        GameAction.Data["卫生间"], GameAction.Data["储物柜"]
                    },
                    new GameEventUIInfo("WhichToRummage", "在房间内翻找", "放眼望去房间内除了床铺，只有卫生间和储物柜。\n你决定查看这两处是否有关于你身份的线索"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "GetRecordPen1",
                new GameEventModel("GetRecordPen1", "获得录音笔1", null, new GameActionModel[]
                    {
                        GameAction.Data["收起来"]
                    },
                    new GameEventUIInfo("GetRecordPen", "获得录音笔", "录音笔已存内容：\n1958年3月28日\n今天是我进入医院调查的第1天，希望能找到证据\n1958年4月4日\n我在集体治疗时，打听到了线索，也许我要找的资料就在那里\n1958年4月11日\n该死！进入那地方需要密码，我得想办法再下一次集体治疗前拿到它\n1958年4月18日\n就差一步！！！没想到那个保险箱密码错误3次后竟然会有警报！\n1958年4月20日\n上次的失误导致医院对我的监管升级了，没时间了！我得尽快拿到它！！！\n1958年4月25日\n今天是进入医院的第29天，医生给我换了一种新的药物，吃下这个药物后的我陷入昏迷，当我清醒过来，我在身上发现几处淤青，但对此我毫无记忆...\n1958年4月29日\n我开始变得极度暴躁，连护士将针筒放在盘子上的声音都让我感到愤怒，事情不对我加速了。\n1958年5月2日\n这可能是我最后一次集体治疗，我得将东西藏在那里..."), null,
                    null, null,
                    "GetProps", new object[] { new PropCreator[] { new PropCreator(Prop.Data["RecordPen"], true) } },
                    null, null)
            },
            {
                "GetPatientRecord1",
                new GameEventModel("GetPatientRecord1", "获得病历本1", null, new GameActionModel[]
                    {
                        GameAction.Data["收起来"]
                    },
                    new GameEventUIInfo("GetPatientRecord", "获得病历本", "病历本：\n姓名：布兰妮\n年龄：37\n联系人：乔治   关系：夫妻\n入院原因：家族遗传性精神病\n入院时间：1958年3月28日\n治疗记录：患者沉溺于幻想，无法分清现实和幻想世界，在第一阶段保守无效后，经家属同意采取“西格玛”治疗方案"), null,
                    null, null,
                    "GetProps", new object[] { new PropCreator[] { new PropCreator(Prop.Data["PatientBook"], true) } },
                    null, null)
            },
            {
                "GetRecordPen2",
                new GameEventModel("GetRecordPen2", "获得录音笔2", null, new GameActionModel[]
                    {
                        GameAction.Data["思考"]
                    },
                    new GameEventUIInfo("GetRecordPen", "获得录音笔", "录音笔已存内容：\n1958年3月28日\n今天是我进入医院调查的第1天，希望能找到证据\n1958年4月4日\n我在集体治疗时，打听到了线索，也许我要找的资料就在那里\n1958年4月11日\n该死！进入那地方需要密码，我得想办法再下一次集体治疗前拿到它\n1958年4月18日\n就差一步！！！没想到那个保险箱密码错误3次后竟然会有警报！\n1958年4月20日\n上次的失误导致医院对我的监管升级了，没时间了！我得尽快拿到它！！！\n1958年4月25日\n今天是进入医院的第29天，医生给我换了一种新的药物，吃下这个药物后的我陷入昏迷，当我清醒过来，我在身上发现几处淤青，但对此我毫无记忆...\n1958年4月29日\n我开始变得极度暴躁，连护士将针筒放在盘子上的声音都让我感到愤怒，事情不对我加速了。\n1958年5月2日\n这可能是我最后一次集体治疗，我得将东西藏在那里..."), null,
                    null, null,
                    "GetProps", new object[] { new PropCreator[] { new PropCreator(Prop.Data["RecordPen"], true) } },
                    null, null)
            },
            {
                "GetPatientRecord2",
                new GameEventModel("GetPatientRecord2", "获得病历本1", null, new GameActionModel[]
                    {
                        GameAction.Data["思考"]
                    },
                    new GameEventUIInfo("GetPatientRecord", "在房间内翻找", "病历本：\n姓名：布兰妮\n年龄：37\n联系人：乔治   关系：夫妻\n入院原因：家族遗传性精神病\n入院时间：1958年3月28日\n治疗记录：患者沉溺于幻想，无法分清现实和幻想世界，在第一阶段保守无效后，经家属同意采取“西格玛”治疗方案"), null,
                    null, null,
                    "GetProps", new object[] { new PropCreator[] { new PropCreator(Prop.Data["PatientBook"], true) } },
                    null, null)
            },
            {
                "NurseEnterRoom1",
                new GameEventModel("NurseEnterRoom", "护士进入房间", null, new GameActionModel[]
                    {
                        GameAction.Data["“头很痛”1"]
                    },
                    new GameEventUIInfo("NurseEnterRoom", "护士进入房间", "你看见一位穿着护士服装的女士对你说：\n“布兰妮女士，您现在感觉如何”"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "NurseEnterRoom2",
                new GameEventModel("NurseEnterRoom", "护士进入房间", null, new GameActionModel[]
                    {
                        GameAction.Data["“你是谁”"], GameAction.Data["“头很痛”2"]
                    },
                    new GameEventUIInfo("NurseEnterRoom", "护士进入房间", "你听到门外传来脚步声，有人正在开门。\n门打开后，你看见一位穿着护士服装的女士对你说：\n“布兰妮女士，您现在感觉如何”"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "TalkAboutAmnesia",
                new GameEventModel("TalkAboutAmnesia", "告知失忆", null, new GameActionModel[]
                    {
                        GameAction.Data["吃药"], GameAction.Data["拒绝"]
                    },
                    new GameEventUIInfo("TalkAboutAmnesia", "告知失忆", "你选择告知失忆的事情。\n护士并不奇怪你的问题，她对你说：“我是福音医院的护士，今天是您手术后醒来的第一天，这是您今天需要吃的药。”"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "ConcealAmnesia1",
                new GameEventModel("ConcealAmnesia1", "隐瞒失忆", null, new GameActionModel[]
                    {
                        GameAction.Data["拒绝"], GameAction.Data["假装吃药1"]
                    },
                    new GameEventUIInfo("ConcealAmnesia1", "隐瞒失忆", "你选择隐瞒失忆的事情。\n护士将手中的托盘递给你，她对你说：\n“布兰妮女士，您术后刚恢复意识，头痛的情况很正常，这是您今日份的药物，它会缓解您头痛的情况”"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "ConcealAmnesia2",
                new GameEventModel("ConcealAmnesia2", "隐瞒失忆", null, new GameActionModel[]
                    {
                        GameAction.Data["吃药"], GameAction.Data["假装吃药2"]
                    },
                    new GameEventUIInfo("ConcealAmnesia2", "隐瞒失忆", "你选择隐瞒失忆的事情。\n护士将手中的托盘递给你，她对你说：\n“布兰妮女士，您术后刚恢复意识，头痛的情况很正常，这是您今日份的药物，它会缓解您头痛的情况”"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "RefusePill",
                new GameEventModel("RefusePill", "拒绝吃药", null, new GameActionModel[]
                    {
                        GameAction.Data["吃药"]
                    },
                    new GameEventUIInfo("RefusePill", "拒绝吃药", "你拒绝吃药，护士情绪并未产生波动，她对你说：“布兰妮女士，这个药物能缓解您手术产生的副作用，是治疗中的关键，请您按照医嘱吃药”"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "ComaByPill",
                new GameEventModel("ComaByPill", "陷入昏迷", null, new GameActionModel[]
                    {
                        GameAction.Data["直接出门"]
                    },
                    new GameEventUIInfo("ComaByPill", "陷入昏迷", "药物很快让你陷入昏迷。\n你被隔壁传来的人声惊醒。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "TakePill1",
                new GameEventModel("TakePill1", "吃药1", null, new GameActionModel[]
                    {
                        GameAction.Data["睡觉"]
                    },
                    new GameEventUIInfo("TakePill1", "吃药", "看见你吞咽的动作后，护士对你说：“您手术非常成功，医生预计您再进行3次集体治疗就可以做出院测试了，祝您早日康复。”\n说完护士关上了门"), null,
                    null, null,
                    "GetProps", new object[] { new PropCreator[] { new PropCreator(Prop.Data["Pill2"], true) } },
                    null, null)
            },
            {
                "TakePill2",
                new GameEventModel("TakePill2", "吃药2", null, new GameActionModel[]
                    {
                        GameAction.Data["睡觉"]
                    },
                    new GameEventUIInfo("TakePill2", "吃药", "看见你吞咽的动作后，护士对你说：“您手术非常成功，医生预计您再进行3次集体治疗就可以做出院测试了，祝您早日康复。”\n说完护士关上了门"), null,
                    null, null,
                    "GetProps", new object[] { new PropCreator[] { new PropCreator(Prop.Data["Pill2"], true) } },
                    null, null)
            },
            {
                "PlanToTakeAction",
                new GameEventModel("PlanToTakeAction", "准备行动", null, new GameActionModel[]
                    {
                        GameAction.Data["直接出门"], GameAction.Data["搜索房间3"]
                    },
                    new GameEventUIInfo("PlanToTakeAction", "准备行动", "你看见一位穿着护士服装的女士对你说：\n“布兰妮女士，您现在感觉如何？”"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "Dream",
                new GameEventModel("Dream", "梦境", null, new GameActionModel[]
                    {
                        GameAction.Data["直接出门"]
                    },
                    new GameEventUIInfo("Dream", "梦境", "你对目前的一切感到茫然，信息很杂乱，你术后的大脑开始疲倦，陷入沉睡。\n你睡得并不安稳，你似乎在梦中和某人发生争吵。\n“要不是你 * **，布兰妮不会 * **, 我看你也需要治疗！”\n你从恐惧中惊醒，你隐隐约约觉得这家医院有某种阴谋，于是你打算开始行动起来。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "ObserveToilet",
                new GameEventModel("ObserveToilet", "观察卫生间", null, new GameActionModel[]
                    {
                        GameAction.Data["查看其他地方"], GameAction.Data["继续翻找"]
                    },
                    new GameEventUIInfo("ObserveToilet", "观察卫生间", "你发现厕所安装镜子的地方什么都没有。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "ObserveCloset",
                new GameEventModel("ObserveCloset", "观察储物柜", null, new GameActionModel[]
                    {
                        GameAction.Data["查看其他地方"], GameAction.Data["继续翻找"]
                    },
                    new GameEventUIInfo("ObserveCloset", "观察储物柜", "柜子里除了简单的衣物似乎什么都没有。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "ObserveWall",
                new GameEventModel("ObserveWall", "观察墙", null, new GameActionModel[]
                    {
                        GameAction.Data["不明所以"]
                    },
                    new GameEventUIInfo("ObserveWall", "观察墙", "你发现墙上刻了一些日期的印记和模糊无法辨识的字迹，\n“look------mirror”。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "FindPaperPiece",
                new GameEventModel("FindPaperPiece", "发现纸条", null, new GameActionModel[]
                    {
                        GameAction.Data["收起纸条"]
                    },
                    new GameEventUIInfo("FindPaperPiece", "发现纸条", "在柜门底部的夹缝中，你发现了一张纸条，上面有串奇怪的字符。"), null,
                    null, null,
                     "GetProps", new object[] { new PropCreator[] { new PropCreator(Prop.Data["PaperPiece"], true) } },
                    null, null)
            },
            {
                "LisentToNeighbour",
                new GameEventModel("LisentToNeighbour", "隔壁的声音", null, new GameActionModel[]
                    {
                        GameAction.Data["直接出门"]
                    },
                    new GameEventUIInfo("LisentToNeighbour", "隔壁的声音", "你回到房间门口，想仔细倾听隔壁是否有动静。\n隔壁好像传出来一丝人的叫喊声。\n你决定走出房门，想尽快知道隔壁在发生什么。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "NoOneInCorridor",
                new GameEventModel("NoOneInCorridor", "无人走廊", null, new GameActionModel[]
                    {
                        GameAction.Data["大声呼叫"], GameAction.Data["观察走廊"]
                    },
                    new GameEventUIInfo("NoOneInCorridor", "无人走廊", "你看见走廊空无一人，你很疑惑，因为这跟自己印象中人满为患的医院区别很大"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "GuardCome",
                new GameEventModel("GuardCome", "护士警卫赶到", null, new GameActionModel[]
                    {
                        GameAction.Data["回头"]
                    },
                    new GameEventUIInfo("GuardCome", "护士警卫赶到", "护士带着警卫人员赶到，你听到：“198号实验体试图逃离病房，精神状态不稳定，建议再次启动西格玛方案”"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "ObserveNeighbour",
                new GameEventModel("ObserveNeighbour", "观察隔壁房间", null, new GameActionModel[]
                    {
                        GameAction.Data["开一条缝"], GameAction.Data["不开门"]
                    },
                    new GameEventUIInfo("ObserveNeighbour", "观察隔壁房间", "你轻手轻脚走到隔壁病房门口处，门紧闭着。\n你想打开一点点，透过门缝观察"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "LockInBox",
                new GameEventModel("LockInBox", "锁在箱子里", null, new GameActionModel[]
                    {
                        GameAction.Data["回到病房"]
                    },
                    new GameEventUIInfo("LockInBox", "锁在箱子里", "你透过门缝看见一群病人被锁在奇怪的箱子里，他们时而发抖，时而惨叫。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "ShoutInCorridor",
                new GameEventModel("ShoutInCorridor", "走廊里的警告", null, new GameActionModel[]
                    {
                        GameAction.Data["回到病房"]
                    },
                    new GameEventUIInfo("ShoutInCorridor", "走廊里的警告", "突然有人从走廊深处走过来，大喊“非治疗时间，病人不可以出房间！”\n你下意识想逃走。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "RecordTheScene",
                new GameEventModel("RecordTheScene", "记录现场", null, new GameActionModel[]
                    {
                        GameAction.Data["逃走"], GameAction.Data["回到病房"]
                    },
                    new GameEventUIInfo("RecordTheScene", "记录现场", "你记录下这场惨无人道的现场。\n突然有人从走廊深处走过来, 大喊：“非治疗时间，病人不可以出房间！”\n你下意识想逃走。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "RunIntoTheHall",
                new GameEventModel("RunIntoTheHall", "逃进大房间", null, new GameActionModel[]
                    {
                        GameAction.Data["观察四周"]
                    },
                    new GameEventUIInfo("RunIntoTheHall", "逃进大房间", "你逃到了一间很空旷的房间，你发现这间房的中间有一个手术台，四周还有散落的血迹，但奇怪的是周围有很多观展的座位。\n听到身后传来的脚步声，你无暇多想，马上躲进座位之间。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "GoBackToOwnRoom",
                new GameEventModel("GoBackToOwnRoom", "回到自己的病房", null, new GameActionModel[]
                    {
                        GameAction.Data["逃离"]
                    },
                    new GameEventUIInfo("GoBackToOwnRoom", "回到自己的病房", "你回到了自己的病房内，整理目前的信息。\n通过枕边简陋的证件推测你之前可能是一名记者，这里特殊的治疗方案很可能就是导致你记忆缺失的原因。\n你得想办法离开这个鬼地方。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "SeeFile",
                new GameEventModel("SeeFile", "发现文件", null, new GameActionModel[]
                    {
                        GameAction.Data["捡起来"], GameAction.Data["不捡"]
                    },
                    new GameEventUIInfo("SeeFile", "发现文件", "你透过座位之间的缝隙看见在一滩血迹旁散落着一堆文件，虽然很难辨识，但你依然能看到“脑额叶切除实验”。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "GetFile",
                new GameEventModel("GetFile", "获得文件", null, new GameActionModel[]
                    {
                        GameAction.Data["继续调查"], GameAction.Data["返回房间"]
                    },
                    new GameEventUIInfo("GetFile", "获得文件", "等到脚步声渐渐远去，你整理好刚才发现的文件，发现里面夹了一把钥匙，你收起钥匙，起身准备离开。"), null,
                    null, null,
                    "GetProps", new object[] { new PropCreator[] { new PropCreator(Prop.Data["Key1"], true) } },
                    null, null)
            },
            {
                "NotGetFile",
                new GameEventModel("NotGetFile", "没获得文件", null, new GameActionModel[]
                    {
                        GameAction.Data["继续调查"], GameAction.Data["返回房间"]
                    },
                    new GameEventUIInfo("NotGetFile", "没获得文件", "等到脚步声渐渐远去，你起身准备离开。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "HeardOfMissing198",
                new GameEventModel("HeardOfMissing198", "198号实验体不见", null, new GameActionModel[]
                    {
                        GameAction.Data["继续跟踪"], GameAction.Data["调查此处"]
                    },
                    new GameEventUIInfo("HeardOfMissing198", "198号实验体不见", "你听到有人说:“我们的198号实验体不见了，立马进行全院搜查，这个实验体脑电波异常活跃，是一个非常优质的实验体。还有，今天158号实验体反应异常，我们需要采取西格玛方案。”\n你还想听到更多消息，但突然路过了有着精致房门的房间。\n你在思考是否放弃跟踪，调查此处。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "FileRoomLocked",
                new GameEventModel("FileRoomLocked", "档案室", null, new GameActionModel[]
                    {
                        GameAction.Data["尝试开门"]
                    },
                    new GameEventUIInfo("FileRoomLocked", "档案室", "根据门牌上的信息，这个房间是档案室。\n你发现档案室的门是锁着的。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "LoseTarget",
                new GameEventModel("LoseTarget", "丢失目标", null, new GameActionModel[]
                    {
                        GameAction.Data["进入那个病房"]
                    },
                    new GameEventUIInfo("LoseTarget", "丢失目标", "你突然跟丢了前方的人，你只好继续再走廊探索。\n发现有一个病房的门是敞开着的。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "KeyNotPair",
                new GameEventModel("KeyNotPair", "钥匙不匹配", null, new GameActionModel[]
                    {
                        GameAction.Data["往左走"], GameAction.Data["往右走"]
                    },
                    new GameEventUIInfo("KeyNotPair", "钥匙不匹配", "没有匹配的钥匙。\n除非用暴力方法，否则无法打开门锁，你不想打草惊蛇。\n你继续沿着走廊向里走，你来到一个分岔口。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "AnOpenedDoor",
                new GameEventModel("AnOpenedDoor", "开着的门", null, new GameActionModel[]
                    {
                        GameAction.Data["进入那个病房"]
                    },
                    new GameEventUIInfo("AnOpenedDoor", "开着的门", "你顺着左边的走廊继续向前走，发现有一个病房的门是敞开着的。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "PatientInHappiness",
                new GameEventModel("PatientInHappiness", "幸福的病人", null, new GameActionModel[]
                    {
                        GameAction.Data["打招呼"]
                    },
                    new GameEventUIInfo("PatientInHappiness", "幸福的病人", "里面干净且空旷，墙壁很白，虽然是个病房，但丝毫没有使用过的痕迹，仿佛是昨天才装修好。\n病床上躺着一位病人，全身被绷带绑着，只有脸部露了出来。\n病人一直在微笑，看上去沉浸在幸福中。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "HideInToilet",
                new GameEventModel("HideInToilet", "躲进厕所", null, new GameActionModel[]
                    {
                        GameAction.Data["自我催眠"], GameAction.Data["去马桶呕吐"]
                    },
                    new GameEventUIInfo("HideInToilet", "躲进厕所", "你想上前打招呼，身后却传来护士的脚步声，便赶紧躲进了厕所。\n你看见护士环视一圈后对床上的病人说：”先生，你今天的手术很成功哦，我们的西格玛方案还是很有效的，你之前的症状都消失了。”病人并没有回应，还是非常呆滞的笑，“嗯，就是现在反应有些迟钝，但基本已经痊愈......”\n你听到她的自言自语的声音逐渐远去，你感觉一阵眩晕。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "FoundByNurse",
                new GameEventModel("FoundByNurse", "被护士找到", null, new GameActionModel[]
                    {
                        GameAction.Data["被带回病房"]
                    },
                    new GameEventUIInfo("FoundByNurse", "被护士找到", "你安定了下来，心想：可能这就是治疗成功的样子吧。\n突然有护士走进来，对你说：“布兰妮女士，你怎么在这呀，快回到自己的床位。”"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "QuestionNurse",
                new GameEventModel("QuestionNurse", "询问护士", null, new GameActionModel[]
                    {
                        GameAction.Data["吃今天的药"]
                    },
                    new GameEventUIInfo("QuestionNurse", "询问护士", "你向护士打听自己为何会在此处住院。\n护士将药物递给你，对你说：“我知道你有很多疑惑，但今天的吃药时间到了，你该吃药了。”"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "TalkAboutIllness",
                new GameEventModel("TalkAboutIllness", "了解病情", null, new GameActionModel[]
                    {
                        GameAction.Data["询问家人情况"]
                    },
                    new GameEventUIInfo("TalkAboutIllness", "了解病情", "护士看见你吃药后，开始详细讲述你的经历：\n你患有先天精神障碍，在年轻的时候症状不明显，但到了中年有时候会产生幻觉，并伴随被害妄想，因此你的丈夫决定把你托付给医院进行治疗，你的记者证也是你在入院的时候随手画的。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "TalkAboutFamily",
                new GameEventModel("TalkAboutFamily", "家人情况", null, new GameActionModel[]
                    {
                        GameAction.Data["配合治疗"]
                    },
                    new GameEventUIInfo("TalkAboutFamily", "家人情况", "护士告诉你，因为是封闭治疗，在完成治疗前无法与家人见面。\n之后都是一些医疗术语，你并没有听进去。\n听护士讲述完毕，你心里的疑惑少了许多，发现原来自己只是病了，只要好好接受治疗就能够重新见到家人。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "LeaveHospital",
                new GameEventModel("LeaveHospital", "出院", null, new GameActionModel[]
                    {
                        GameAction.Data["上前拥抱"]
                    },
                    new GameEventUIInfo("LeaveHospital", "出院", "日子一天天过去，有一天，医生对你说，你的各项条件都符合正常指标，可以出院了。\n你在医院门口重新见到了你的丈夫，虽然样子有点记不清了，但你掏出口袋里的照片偷偷看了一眼，你发现他确实就是合照中的丈夫。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "TalkToHusband",
                new GameEventModel("TalkToHusband", "与丈夫交谈", null, new GameActionModel[]
                    {
                        GameAction.Data["与丈夫回家"]
                    },
                    new GameEventUIInfo("TalkToHusband", "与丈夫交谈", "他满怀欣喜的抱着你,哭泣着对你说：“一年过去了, 你终于痊愈了, 我就知道这个方案能够成功...”。\n你坐上了回家的车，你隐约听见车外护士对丈夫嘱咐：“不要....镜子.........尖锐物品。今年内还需要继续吃药。”"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "GetPhotoPiece",
                new GameEventModel("GetPhotoPiece", "找到照片碎片", null, new GameActionModel[]
                    {

                    },
                    new GameEventUIInfo("GetPhotoPiece", "找到照片碎片", "有一天...\n你在打扫房间的时候，偶然间在床的夹缝里，发现了被撕碎的照片碎片。\n碎片上是一个小女孩。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "StickPhotoTogether",
                new GameEventModel("StickPhotoTogether", "拼合照片", null, new GameActionModel[]
                    {
                        GameAction.Data["找出药物服用"]
                    },
                    new GameEventUIInfo("StickPhotoTogether", "拼合照片", "你翻出从医院带回家的照片，发现这两者拼起来严丝合缝，拼好的照片中，是一副一家三口合照，完整的。\n看到照片的那刻，你久违的又开始头痛起来。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "PressFlushButton",
                new GameEventModel("PressFlushButton", "按下抽水按钮", null, new GameActionModel[]
                    {
                        GameAction.Data["离开厕所"]
                    },
                    new GameEventUIInfo("PressFlushButton", "按下抽水按钮", "你按下抽水按钮时，听见水箱中有敲击声。\n打开蓄水箱的盖子，你发现了一把钥匙。"), null,
                    null, null,
                    "GetProps", new object[] { new PropCreator[] { new PropCreator(Prop.Data["Key2"], true) } },
                    null, null)
            },
            {
                "CaughtByGuard",
                new GameEventModel("CaughtByGuard", "被警卫抓住", null, new GameActionModel[]
                    {
                        GameAction.Data["配合治疗"]
                    },
                    new GameEventUIInfo("CaughtByGuard", "被警卫抓住", "在路上，你被巡查的警卫抓住，警卫将你压回病房，并给你强制喂入药物。\n药物开始生效，你逐渐平静下来，眼前的一切物件都在向中间聚拢。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "Password",
                new GameEventModel("Password", "密码", null, new GameActionModel[]
                    {
                        GameAction.Data["感到不安"]
                    },
                    new GameEventUIInfo("Password", "密码", "你意识到之前发现的纸条上写的内容了，那是一串4位数的密码：“9563”"), null,
                    null, null,
                    "GetProps", new object[] { new PropCreator[] { new PropCreator(Prop.Data["Password"], true) } },
                    null, null)
            },
            {
                "AskToLeave",
                new GameEventModel("AskToLeave", "要求离开", null, new GameActionModel[]
                    {
                        GameAction.Data["询问家人情况"],GameAction.Data["要求拨打电话"]
                    },
                    new GameEventUIInfo("AskToLeave", "要求离开", "发生的一切都在刺激你的神经，你不明白为什么独自一人在医院经历这些，希望家人能带你逃离这个地方，你要求医院联系你的家人。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "FamiliarVoice",
                new GameEventModel("FamiliarVoice", "熟悉的声音", null, new GameActionModel[]
                    {
                        GameAction.Data["挂断电话"]
                    },
                    new GameEventUIInfo("FamiliarVoice", "熟悉的声音", "你听到电话里男人的声音熟悉但令你厌恶：“亲爱的，我也想尽快和你见面，但你病了必须得配合治疗，不要任性了，好好听医生的话，等你病好了我就来接你回家。”"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "AwareOfHelpless",
                new GameEventModel("AwareOfHelpless", "表面配合", null, new GameActionModel[]
                    {
                        GameAction.Data["假装配合"]
                    },
                    new GameEventUIInfo("AwareOfHelpless", "表面配合", "你明白寻求丈夫的帮助是无用的，你决定自己展开逃离计划。\n你表面上配合医院的治疗，暗地将每天要吃的药物藏起来。虽然不吃药头会痛，但你潜意识告诉你，这个药有问题。\n你不想变成那个房间里的病人那样"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "PlanToGetInfomation",
                new GameEventModel("PlanToGetInfomation", "第一次集体治疗", null, new GameActionModel[]
                    {
                        GameAction.Data["坐在角落"], GameAction.Data["坐在前排"]
                    },
                    new GameEventUIInfo("PlanToGetInfomation", "表面配合", "在此期间，你观察者每天医护人员进来查岗的时间。你回忆起之前的线索，打算利用第一次集体治疗打探更多的消息。\n很快，第一次集体治疗开始了。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "ObservePatientEmotion",
                new GameEventModel("ObservePatientEmotion", "观察周围病人", null, new GameActionModel[]
                    {
                        GameAction.Data["回头看向他"]
                    },
                    new GameEventUIInfo("ObservePatientEmotion", "观察周围病人", "你观察周围病人的神情，你总觉得在收集资料期间有人帮过你，希望这次集体治疗能找到那个人。\n过了一会儿有人在你身边坐下了，她对你说：“真幸运啊，没想到你接受西格玛方案后，还能意识清醒的坐在这里，艾莉莎小姐。”"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "GetMemoryBack",
                new GameEventModel("GetMemoryBack", "记忆复苏", null, new GameActionModel[]
                    {
                        GameAction.Data["前往密室"]
                    },
                    new GameEventUIInfo("GetMemoryBack", "记忆复苏", "你看着眼前正在进行的实验，熟悉的场景不断刺激你的大脑。\n你想起来，你并不是布兰妮，那是你母亲的名字，她也是这家医院的病人，是你的父亲将她安排在医院治疗，但在治疗中不幸身亡。\n你确实是名记者，为了调查母亲的死因，你假意顺从父亲的意愿来到医院，藏匿在病房中的纸条是拿到证据的关键密码。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "DontBeAlert",
                new GameEventModel("DontBeAlert", "不要这么警惕", null, new GameActionModel[]
                    {
                        GameAction.Data["开口询问"]
                    },
                    new GameEventUIInfo("DontBeAlert", "不要这么警惕", "“不要这么警惕的看着我，我叫R，你要知道我们目标一致，都是希望这家医院彻底消失。”"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "ConfuseTalk",
                new GameEventModel("ConfuseTalk", "疑惑", null, new GameActionModel[]
                    {
                        GameAction.Data["“我是布兰妮。”"]
                    },
                    new GameEventUIInfo("ConfuseTalk", "疑惑", "你很疑惑，“艾莉莎小姐？你在说我吗？”\n那人愣了下，笑道：“看来西格玛方案让你的脑袋出了点小问题。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "ShowPressCard",
                new GameEventModel("ShowPressCard", "出示记者证", null, new GameActionModel[]
                    {
                        GameAction.Data["进一步询问"]
                    },
                    new GameEventUIInfo("ShowPressCard", "出示记者证", "你给她出示你醒来时发现的记者证，她摇了摇头，开始阐述你们在医院相遇的经历和计划。\n你并不是布兰妮，那是你母亲的名字，她也是这家医院的病人，是你的父亲将她安排在医院治疗，但在治疗中不幸身亡。\n你确实是名记者，为了调查母亲的死因，你假意顺从父亲的意愿来到医院。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "ExplanationFromR",
                new GameEventModel("ExplanationFromR", "R的解释", null, new GameActionModel[]
                    {
                        GameAction.Data["“我该怎么做？”"]
                    },
                    new GameEventUIInfo("ExplanationFromR", "R的解释", "你仍然很疑惑，为什么她选择帮助你。\nR女士叹了口气，解释道：她温柔善良的恋人被家人送到这里治疗“同性”问题，最终不堪折磨选择自杀，她潜伏进来就是为了曝光这家医院名为医疗实际用人体进行各种非人实验。\n所谓的西格玛计划，就是将人开颅去除部分脑额叶，如果侥幸没死在手术中，后续配合药物将人变成听话的“乖孩子”。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "HintFromR1",
                new GameEventModel("HintFromR1", "R提供的线索1", null, new GameActionModel[]
                    {
                        GameAction.Data["前往密室"]
                    },
                    new GameEventUIInfo("HintFromR", "R提供的线索", "“真正的治疗资料全都藏在病房深处的密室中。我会在这次集体治疗给你争取时间，你必须尽快拿到资料逃出去。”"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "HintFromR2",
                new GameEventModel("HintFromR2", "R提供的线索2", null, new GameActionModel[]
                    {
                        GameAction.Data["前往密室"]
                    },
                    new GameEventUIInfo("HintFromR", "R提供的线索", "你出示病房中发现的病历本，但R女士笑道：“没错，你入院后的表现太活跃了，医院判定你危险程度较高实施了西格玛计划，但你手上的病历本并非真实，真正的治疗资料全都藏在病房深处的密室中。我会在这次集体治疗给你争取时间，你必须尽快拿到资料逃出去。”"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "GetIntoSecretRoom",
                new GameEventModel("GetIntoSecretRoom", "进入密室", null, new GameActionModel[]
                    {
                        GameAction.Data["尝试把门拉开"]
                    },
                    new GameEventUIInfo("GetIntoSecretRoom", "进入密室", "根据你这段时间针对巡查人员的观察，你避开人群来到密室门口，发现就是上次上锁的档案室。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "NeedPassword",
                new GameEventModel("NeedPassword", "需要密码", null, new GameActionModel[]
                    {
                        GameAction.Data["输入2333"], GameAction.Data["输入8848"]
                    },
                    new GameEventUIInfo("NeedPassword", "需要密码", "你进入了档案室，离母亲的治疗档案就差一步，但真实档案被放在保险箱中，你需要密码。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "OpenBox",
                new GameEventModel("OpenBox", "打开保险箱", null, new GameActionModel[]
                    {
                        GameAction.Data["离开档案室"]
                    },
                    new GameEventUIInfo("OpenBox", "打开保险箱", "你打开保险箱，里面有各种实验的数据和照片，你在里面看到了你的母亲布兰妮的治疗照片。\n你的头又开始剧烈的疼痛，但你知道只有逃出去，曝光这一切，才能结束掉所有的错误。"), null,
                    null, null,
                    "GetProps", new object[] { new PropCreator[] { new PropCreator(Prop.Data["ExperimentRecord"], true) } },
                    null, null)
            },
            {
                "BestChanceToRun",
                new GameEventModel("BestChanceToRun", "最佳时机", null, new GameActionModel[]
                    {
                        GameAction.Data["逃出医院"]
                    },
                    new GameEventUIInfo("BestChanceToRun", "最佳时机", "似乎有人在给你打掩护，没人发现你中途离开的问题。\n集体治疗结束，人潮涌动，你知道这是你逃离医院的最佳时机。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "AbandonExit",
                new GameEventModel("AbandonExit", "废弃出口", null, new GameActionModel[]
                    {
                        GameAction.Data["找其他出口"]
                    },
                    new GameEventUIInfo("AbandonExit", "废弃出口", "你摸索到医院荒废的紧急出口的位置，发现门上锁了。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "GetOutOfHospital",
                new GameEventModel("GetOutOfHospital", "逃出医院", null, new GameActionModel[]
                    {
                        GameAction.Data["向他讲述遭遇"]
                    },
                    new GameEventUIInfo("GetOutOfHospital", "逃出医院", "你逃出医院，找到记者证上那家报社地点，利用记者证你进入了报社内部，慌张之间，被自称是你领导的人叫住。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "EnterPress1",
                new GameEventModel("EnterPress1", "进入报社", null, new GameActionModel[]
                    {
                        GameAction.Data["不知如何反驳"]
                    },
                    new GameEventUIInfo("EnterPress1", "进入报社", "你像自称是你领导的人讲述了医院发生的一切，领导看着你疯疯癫癫的样子有些震怒地吼道：“艾丽莎，没想到你为了报复医院编了这么离奇的故事，你不能因为你母亲布兰妮在这家医院去世就对它怀恨在心！我看你真的病了，艾丽莎，你看看你现在的样子！你不会真的是从医院跑出来的吧？！”"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "GetCaughtToHospital",
                new GameEventModel("GetCaughtToHospital", "进入报社", null, new GameActionModel[]
                    {
                        GameAction.Data["回到医院"]
                    },
                    new GameEventUIInfo("GetCaughtToHospital", "进入报社", "你不知如何反驳，今天发生的一切已经使你的体力和精神都到达了极限，头又开始剧烈的疼痛，你痛苦的蜷缩在地上。\n领导也吓坏了，让其他人给医院致电，将你带回医院。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "HeadLiner",
                new GameEventModel("HeadLiner", "头条新闻", null, new GameActionModel[]
                    {
                        GameAction.Data["回家"]
                    },
                    new GameEventUIInfo("HeadLiner", "头条新闻", "领导查看资料后冷静下来，明白这是劲爆的大独家，让你赶紧整理资料登上明日报纸首页头条新闻。果然，这条新闻引爆了原本安宁的小镇，每天都有成群的人们集结在医院门前抗议，最终医院被政府查封，原有的病人被转移到正规医院接受治疗。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "HateFather",
                new GameEventModel("HateFather", "无法原谅", null, new GameActionModel[]
                    {
                        GameAction.Data["回家"]
                    },
                    new GameEventUIInfo("HateFather", "无法原谅", "你认为一切都是父亲的逃避和自大造成的，是他将母亲亲手送进地狱，又企图将你进行改造成母亲。\n你无法原谅他，虽然医院关门了，但你手上还藏有医院的非法药物"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "End1",
                new GameEventModel("End1", "结局1", null, new GameActionModel[]
                    {

                    },
                    new GameEventUIInfo("End1", "结局", "之后的记忆非常模糊，你觉得自己应该在这个病房一直待着，永远..."), null,
                    null, null,
                    "EndGame", null,
                    null, null)
            },
            {
                "End2",
                new GameEventModel("End2", "结局2", null, new GameActionModel[]
                    {

                    },
                    new GameEventUIInfo("End2", "结局", "医院发现了你的调查，加强了对你的管控，并认为你需要再次进行西格玛治疗。之后的记忆非常模糊，你觉得自己应该在这个病房一直待着，永远..."), null,
                    null, null,
                    "EndGame", null,
                    null, null)
            },
            {
                "End3",
                new GameEventModel("End3", "结局3", null, new GameActionModel[]
                    {

                    },
                    new GameEventUIInfo("End3", "结局", "你偷偷回到家中，将在医院藏匿的药丸放入父亲每晚都会喝的酒中，药物和酒精混合下让父亲产生幻觉，在夜晚从阳台坠落身亡。"), null,
                    null, null,
                    "EndGame", null,
                    null, null)
            },
            {
                "End4",
                new GameEventModel("End4", "结局4", null, new GameActionModel[]
                    {

                    },
                    new GameEventUIInfo("End4", "结局", "你盯着照片里两个女人神似的脸，不由得陷入了长久的沉默，没有疑惑也没有恐惧，只是沉默。"), null,
                    null, null,
                    "EndGame", null,
                    null, null)
            },
        };
    }
}