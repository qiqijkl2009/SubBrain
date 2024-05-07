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
                    new GameEventUIInfo("WakeUp", "醒来", "你在医院醒来，头很痛，你似乎丢失了一段记忆"), null,
                    null, null,
                    "GetProps", new object[] { "Test" },
                    null, null)
            },
            {
                "Headache",
                new GameEventModel("Headache", "头痛", new string[] { "吃药" }, new GameActionModel[]
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
                    null, null,
                    null, null)
            },
            {
                "GetPressCard",
                new GameEventModel("GetPressCard", "获得记者证", null, new GameActionModel[]
                    {
                        GameAction.Data["从床上下来"]
                    },
                    new GameEventUIInfo("GetOffBed", "下床", "你在右手边（枕边）发现了一张记者证虽然很简陋, 但证件上记载了一些信息。\n姓名：布兰妮\n职业：新闻记者\n年龄：37\n所属：WHS电视台新闻部\n职业编号：RY19580328\n有一张看不清五官的模糊女人画像"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "GetOffBed",
                new GameEventModel("GetOffBed", "下床", null, new GameActionModel[]
                    {
                        GameAction.Data["静观其变"], GameAction.Data["搜索房间"]
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
                        GameAction.Data["翻找床铺"], GameAction.Data["翻找柜子"]
                    },
                    new GameEventUIInfo("WhichToRummage1", "在房间内翻找", "房间里的东西很少，一眼望去只有枕头下和柜子里收着一些东西。"), null,
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
                    new GameEventUIInfo("WhichToRummage1", "在房间内翻找", "房间里的东西很少，一眼望去只有枕头下和柜子里收着一些东西。"), null,
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
                    new GameEventUIInfo("WhichToRummage3", "在房间内翻找", "放眼望去房间内除了床铺，只有卫生间和储物柜。\n你决定查看这两处是否有关于你身份的线索"), null,
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
                    new GameEventUIInfo("WhichToRummage1", "获得录音笔", "录音笔已存内容：\n1958年3月28日\n今天是我进入医院调查的第1天，希望能找到证据\n1958年4月4日\n我在集体治疗时，打听到了线索，也许我要找的资料就在那里\n1958年4月11日\n该死！进入那地方需要密码，我得想办法再下一次集体治疗前拿到它\n1958年4月18日\n就差一步！！！没想到那个保险箱密码错误3次后竟然会有警报！\n1958年4月20日\n上次的失误导致医院对我的监管升级了，没时间了！我得尽快拿到它！！！\n1958年4月25日\n今天是进入医院的第29天，医生给我换了一种新的药物，吃下这个药物后的我陷入昏迷，当我清醒过来，我在身上发现几处淤青，但对此我毫无记忆...\n1958年4月29日\n我开始变得极度暴躁，连护士将针筒放在盘子上的声音都让我感到愤怒，事情不对我加速了。\n1958年5月2日\n这可能是我最后一次集体治疗，我得将东西藏在那里..."), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "GetPatientRecord1",
                new GameEventModel("GetPatientRecord1", "获得病历本1", null, new GameActionModel[]
                    {
                        GameAction.Data["收起来"]
                    },
                    new GameEventUIInfo("GetPatientRecord1", "获得病历本", "病历本：\n姓名：布兰妮\n年龄：37\n联系人：乔治   关系：夫妻\n入院原因：家族遗传性精神病\n入院时间：1958年3月28日\n治疗记录：患者沉溺于幻想，无法分清现实和幻想世界，在第一阶段保守无效后，经家属同意采取“西格玛”治疗方案"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "GetRecordPen2",
                new GameEventModel("GetRecordPen2", "获得录音笔2", null, new GameActionModel[]
                    {
                        GameAction.Data["思考"]
                    },
                    new GameEventUIInfo("GetRecordPen2", "获得录音笔", "录音笔已存内容：\n1958年3月28日\n今天是我进入医院调查的第1天，希望能找到证据\n1958年4月4日\n我在集体治疗时，打听到了线索，也许我要找的资料就在那里\n1958年4月11日\n该死！进入那地方需要密码，我得想办法再下一次集体治疗前拿到它\n1958年4月18日\n就差一步！！！没想到那个保险箱密码错误3次后竟然会有警报！\n1958年4月20日\n上次的失误导致医院对我的监管升级了，没时间了！我得尽快拿到它！！！\n1958年4月25日\n今天是进入医院的第29天，医生给我换了一种新的药物，吃下这个药物后的我陷入昏迷，当我清醒过来，我在身上发现几处淤青，但对此我毫无记忆...\n1958年4月29日\n我开始变得极度暴躁，连护士将针筒放在盘子上的声音都让我感到愤怒，事情不对我加速了。\n1958年5月2日\n这可能是我最后一次集体治疗，我得将东西藏在那里..."), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "GetPatientRecord2",
                new GameEventModel("GetPatientRecord2", "获得病历本1", null, new GameActionModel[]
                    {
                        GameAction.Data["思考"]
                    },
                    new GameEventUIInfo("GetPatientRecord2", "在房间内翻找", "病历本：\n姓名：布兰妮\n年龄：37\n联系人：乔治   关系：夫妻\n入院原因：家族遗传性精神病\n入院时间：1958年3月28日\n治疗记录：患者沉溺于幻想，无法分清现实和幻想世界，在第一阶段保守无效后，经家属同意采取“西格玛”治疗方案"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "NurseEnterRoom",
                new GameEventModel("NurseEnterRoom", "护士进入房间", null, new GameActionModel[]
                    {
                        GameAction.Data["“你是谁”"], GameAction.Data["“头很痛”"]
                    },
                    new GameEventUIInfo("NurseEnterRoom", "护士进入房间", "你听到门外传来脚步声，有人正在开门。\n门打开后，你看见一位穿着护士服装的女士对你说\n“布兰妮女士，您现在感觉如何”"), null,
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
                        GameAction.Data["睡觉"], GameAction.Data["搜索房间"]
                    },
                    new GameEventUIInfo("TakePill1", "吃药", "看见你吞咽的动作后，护士对你说：“您手术非常成功，医生预计您再进行3次集体治疗就可以做出院测试了，祝您早日康复。”\n说完护士关上了门"), null,
                    null, null,
                    null, null,
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
                    null, null,
                    null, null)
            },
            {
                "Dream",
                new GameEventModel("Dream", "梦境", null, new GameActionModel[]
                    {
                        GameAction.Data["直接出门"]
                    },
                    new GameEventUIInfo("Dream", "梦境", "你对目前的一切感到茫然，信息很杂乱，你术后的大脑开始疲倦，陷入沉睡。\n你睡得并不安稳，你似乎在梦中和某人发生争吵。\n“要不是你 * **，布兰妮不会 * **, 我看你也需要治疗！”\n你从恐惧中惊醒，你隐隐约约觉得这家医院有某种阴谋，于是你打算开始行动起来"), null,
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
                    new GameEventUIInfo("Dream", "梦境", "你对目前的一切感到茫然，信息很杂乱，你术后的大脑开始疲倦，陷入沉睡。\n你睡得并不安稳，你似乎在梦中和某人发生争吵。\n“要不是你 * **，布兰妮不会 * **, 我看你也需要治疗！”\n你从恐惧中惊醒，你隐隐约约觉得这家医院有某种阴谋，于是你打算开始行动起来"), null,
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
                    null, null,
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
                        GameAction.Data["尝试开门"], GameAction.Data["不开门"]
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
                new GameEventModel("ShoutInCorridor", "走廊里的警告", null, new GameActionModel[]
                    {
                        GameAction.Data["逃走"], GameAction.Data["回到病房"]
                    },
                    new GameEventUIInfo("ShoutInCorridor", "走廊里的警告", "你记录下这场惨无人道的现场。\n突然有人从走廊深处走过来, 大喊：“非治疗时间，病人不可以出房间！”\n你下意识想逃走。"), null,
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "End1",
                new GameEventModel("End1", "结局1", null, new GameActionModel[]
                    {
                        
                    },
                    new GameEventUIInfo("End1", "结局", "护士带着警卫人员赶到，你听到：“198号实验体试图逃离病房，精神状态不稳定，建议再次启动西格玛方案”"), null,
                    null, null,
                    "EndGame", null,
                    null, null)
            },
        };
    }
}