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
                    new GameEventUIInfo("WakeUp", "醒来", "你在医院醒来，头很痛，你似乎丢失了一段记忆"),
                    null, null,
                    null, null,
                    null, null)
            },
            {
                "Headache",
                new GameEventModel("Headache", "头痛", new string[] { "吃药" }, new GameActionModel[]
                    {

                    },
                    new GameEventUIInfo("Headache", "头痛", "你头痛欲裂，无法思考任何任何事情。你完全记不起自己是谁，又为何在此处"),
                    null, null,
                    null, null,
                    null, null)
            },
            //{
            //    "Observation",
            //    new GameEventModel("Observation", "观察", null, new GameActionModel[]
            //        {
            //            GameAction.Data["观察左边"], GameAction.Data["观察右边"]
            //        },
            //        new GameEventUIInfo("Observation", "观察", "过了一段时间，头痛逐渐缓解但你仍然全身乏力，只能躺着休息一会儿。\n你用眼睛观察周围。"),
            //        null, null,
            //        null, null,
            //        null, null)
            //},
            //{
            //    "GetPhoto",
            //    new GameEventModel("GetPhoto", "获得照片", null, new GameActionModel[]
            //        {
            //            GameAction.Data["从床上下来"]
            //        },
            //        new GameEventUIInfo("GetPhoto", "获得照片", "你发现了一对夫妻的合照摆在床头，你发现合照的一角是撕裂的，于是你把里面的照片取了出来，果然这照片并不完整，你想要深入思考却感觉一阵头疼，你只好先把照片折起来放进口袋。"),
            //        null, null,
            //        null, null,
            //        null, null)
            //},
            //{
            //    "GetPressCard",
            //    new GameEventModel("GetPressCard", "获得记者证", null, new GameActionModel[]
            //        {

            //        },
            //        new GameEventUIInfo("GetOffBed", "下床", "你在右手边（枕边）发现了一张记者证虽然很简陋, 但证件上记载了一些信息。\n姓名：布兰妮\n职业：新闻记者\n年龄：37\n所属：WHS电视台新闻部\n职业编号：RY19580328\n有一张看不清五官的模糊女人画像"),
            //        null, null,
            //        null, null,
            //        null, null)
            //},
            //{
            //    "GetOffBed",
            //    new GameEventModel("GetOffBed", "下床", null, new GameActionModel[]
            //        {
            //            GameAction.Data["静观其变"], GameAction.Data["搜索房间"]
            //        },
            //        new GameEventUIInfo("GetOffBed", "下床", "你下床了，整个房间很大，房门紧闭似乎上锁了，房间里除了你没有其他人。"),
            //        null, null,
            //        null, null,
            //        null, null)
            //},
            //{
            //    "WhichToRummage",
            //    new GameEventModel("WhichToRummage", "在房间内翻找", null, new GameActionModel[]
            //        {
            //            GameAction.Data["翻找床铺"], GameAction.Data["翻找柜子"]
            //        },
            //        new GameEventUIInfo("WhichToRummage", "在房间内翻找", "房间里的东西很少，一眼望去只有枕头下和柜子里收着一些东西。"),
            //        null, null,
            //        null, null,
            //        null, null)
            //},
            //{
            //    "NurseEnterRoom",
            //    new GameEventModel("NurseEnterRoom", "护士进入房间", null, new GameActionModel[]
            //        {
            //            GameAction.Data["“你是谁”"], GameAction.Data["“头很痛”"]
            //        },
            //        new GameEventUIInfo("NurseEnterRoom", "护士进入房间", "你听到门外传来脚步声，有人正在开门。\n门打开后，你看见一位穿着护士服装的女士对你说\n“布兰妮女士，您现在感觉如何”"),
            //        null, null,
            //        null, null,
            //        null, null)
            //},
        };
    }
}