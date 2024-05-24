using JKFrame;
 using UnityEngine;

namespace R
{
 
    public static class DefaultLocalGroup
    {

    } 
    public static class Audio
    {
 
        public static AudioClip InGame { get => ResSystem.LoadAsset<AudioClip>("InGame"); } 
        public static AudioClip MainMenu { get => ResSystem.LoadAsset<AudioClip>("MainMenu"); } 
        public static AudioClip ui_select_card_03 { get => ResSystem.LoadAsset<AudioClip>("ui_select_card_03"); } 
        public static AudioClip ui_select_card_02 { get => ResSystem.LoadAsset<AudioClip>("ui_select_card_02"); } 
        public static AudioClip ui_select_card_01 { get => ResSystem.LoadAsset<AudioClip>("ui_select_card_01"); } 
        public static AudioClip ui_03 { get => ResSystem.LoadAsset<AudioClip>("ui_03"); } 
        public static AudioClip ui_02 { get => ResSystem.LoadAsset<AudioClip>("ui_02"); } 
        public static AudioClip ui_01 { get => ResSystem.LoadAsset<AudioClip>("ui_01"); } 
        public static AudioClip ConcealAmnesia1 { get => ResSystem.LoadAsset<AudioClip>("ConcealAmnesia1"); } 
        public static AudioClip FileRoomLocked { get => ResSystem.LoadAsset<AudioClip>("FileRoomLocked"); } 
        public static AudioClip Headache { get => ResSystem.LoadAsset<AudioClip>("Headache"); } 
        public static AudioClip HeardOfMissing198 { get => ResSystem.LoadAsset<AudioClip>("HeardOfMissing198"); } 
        public static AudioClip HintFromR { get => ResSystem.LoadAsset<AudioClip>("HintFromR"); } 
        public static AudioClip ObserveCloset { get => ResSystem.LoadAsset<AudioClip>("ObserveCloset"); } 
        public static AudioClip ObserveToilet { get => ResSystem.LoadAsset<AudioClip>("ObserveToilet"); } 
        public static AudioClip PressFlushButton { get => ResSystem.LoadAsset<AudioClip>("PressFlushButton"); } 
        public static AudioClip RecordTheScene { get => ResSystem.LoadAsset<AudioClip>("RecordTheScene"); } 
        public static AudioClip ShoutInCorridor { get => ResSystem.LoadAsset<AudioClip>("ShoutInCorridor"); } 
        public static AudioClip WakeUp { get => ResSystem.LoadAsset<AudioClip>("WakeUp"); }
    } 
    public static class Texture
    {
 
        public static Texture2D AbandonExit { get => ResSystem.LoadAsset<Texture2D>("AbandonExit"); }  
        public static Sprite AbandonExit_AbandonExit { get => ResSystem.LoadAsset<Sprite>("AbandonExit[AbandonExit]"); } 
        public static Texture2D 录音笔 { get => ResSystem.LoadAsset<Texture2D>("录音笔"); }  
        public static Sprite 录音笔_录音笔 { get => ResSystem.LoadAsset<Sprite>("录音笔[录音笔]"); } 
        public static Texture2D 摄影机 { get => ResSystem.LoadAsset<Texture2D>("摄影机"); }  
        public static Sprite 摄影机_摄影机 { get => ResSystem.LoadAsset<Sprite>("摄影机[摄影机]"); } 
        public static Texture2D 档案袋 { get => ResSystem.LoadAsset<Texture2D>("档案袋"); }  
        public static Sprite 档案袋_档案袋 { get => ResSystem.LoadAsset<Sprite>("档案袋[档案袋]"); } 
        public static Texture2D 照片 { get => ResSystem.LoadAsset<Texture2D>("照片"); }  
        public static Sprite 照片_照片 { get => ResSystem.LoadAsset<Sprite>("照片[照片]"); } 
        public static Texture2D 电击枪 { get => ResSystem.LoadAsset<Texture2D>("电击枪"); }  
        public static Sprite 电击枪_电击枪 { get => ResSystem.LoadAsset<Sprite>("电击枪[电击枪]"); } 
        public static Texture2D 笔记本 { get => ResSystem.LoadAsset<Texture2D>("笔记本"); }  
        public static Sprite 笔记本_笔记本 { get => ResSystem.LoadAsset<Sprite>("笔记本[笔记本]"); } 
        public static Texture2D 纸条 { get => ResSystem.LoadAsset<Texture2D>("纸条"); }  
        public static Sprite 纸条_纸条 { get => ResSystem.LoadAsset<Sprite>("纸条[纸条]"); } 
        public static Texture2D 药丸 { get => ResSystem.LoadAsset<Texture2D>("药丸"); }  
        public static Sprite 药丸_药丸 { get => ResSystem.LoadAsset<Sprite>("药丸[药丸]"); } 
        public static Texture2D 记者证 { get => ResSystem.LoadAsset<Texture2D>("记者证"); }  
        public static Sprite 记者证_记者证 { get => ResSystem.LoadAsset<Sprite>("记者证[记者证]"); } 
        public static Texture2D 钥匙01 { get => ResSystem.LoadAsset<Texture2D>("钥匙01"); }  
        public static Sprite 钥匙01_钥匙01 { get => ResSystem.LoadAsset<Sprite>("钥匙01[钥匙01]"); } 
        public static Texture2D 钥匙02 { get => ResSystem.LoadAsset<Texture2D>("钥匙02"); }  
        public static Sprite 钥匙02_钥匙02 { get => ResSystem.LoadAsset<Sprite>("钥匙02[钥匙02]"); } 
        public static Texture2D AnOpenedDoor { get => ResSystem.LoadAsset<Texture2D>("AnOpenedDoor"); }  
        public static Sprite AnOpenedDoor_AnOpenedDoor { get => ResSystem.LoadAsset<Sprite>("AnOpenedDoor[AnOpenedDoor]"); } 
        public static Texture2D AskToLeave { get => ResSystem.LoadAsset<Texture2D>("AskToLeave"); }  
        public static Sprite AskToLeave_AskToLeave { get => ResSystem.LoadAsset<Sprite>("AskToLeave[AskToLeave]"); } 
        public static Texture2D AwareOfHelpless { get => ResSystem.LoadAsset<Texture2D>("AwareOfHelpless"); }  
        public static Sprite AwareOfHelpless_AwareOfHelpless { get => ResSystem.LoadAsset<Sprite>("AwareOfHelpless[AwareOfHelpless]"); } 
        public static Texture2D BackToOwnRoom { get => ResSystem.LoadAsset<Texture2D>("BackToOwnRoom"); }  
        public static Sprite BackToOwnRoom_BackToOwnRoom { get => ResSystem.LoadAsset<Sprite>("BackToOwnRoom[BackToOwnRoom]"); } 
        public static Texture2D BestChanceToRun { get => ResSystem.LoadAsset<Texture2D>("BestChanceToRun"); }  
        public static Sprite BestChanceToRun_BestChanceToRun { get => ResSystem.LoadAsset<Sprite>("BestChanceToRun[BestChanceToRun]"); } 
        public static Texture2D CaughtByGuard { get => ResSystem.LoadAsset<Texture2D>("CaughtByGuard"); }  
        public static Sprite CaughtByGuard_CaughtByGuard { get => ResSystem.LoadAsset<Sprite>("CaughtByGuard[CaughtByGuard]"); } 
        public static Texture2D ComaByPill { get => ResSystem.LoadAsset<Texture2D>("ComaByPill"); }  
        public static Sprite ComaByPill_ComaByPill { get => ResSystem.LoadAsset<Sprite>("ComaByPill[ComaByPill]"); } 
        public static Texture2D ConcealAmnesia1 { get => ResSystem.LoadAsset<Texture2D>("ConcealAmnesia1"); }  
        public static Sprite ConcealAmnesia1_ConcealAmnesia1 { get => ResSystem.LoadAsset<Sprite>("ConcealAmnesia1[ConcealAmnesia1]"); } 
        public static Texture2D ConcealAmnesia2 { get => ResSystem.LoadAsset<Texture2D>("ConcealAmnesia2"); }  
        public static Sprite ConcealAmnesia2_ConcealAmnesia2 { get => ResSystem.LoadAsset<Sprite>("ConcealAmnesia2[ConcealAmnesia2]"); } 
        public static Texture2D ConfuseTalk { get => ResSystem.LoadAsset<Texture2D>("ConfuseTalk"); }  
        public static Sprite ConfuseTalk_ConfuseTalk { get => ResSystem.LoadAsset<Sprite>("ConfuseTalk[ConfuseTalk]"); } 
        public static Texture2D DontBeAlert { get => ResSystem.LoadAsset<Texture2D>("DontBeAlert"); }  
        public static Sprite DontBeAlert_DontBeAlert { get => ResSystem.LoadAsset<Sprite>("DontBeAlert[DontBeAlert]"); } 
        public static Texture2D Dream { get => ResSystem.LoadAsset<Texture2D>("Dream"); }  
        public static Sprite Dream_Dream { get => ResSystem.LoadAsset<Sprite>("Dream[Dream]"); } 
        public static Texture2D End1 { get => ResSystem.LoadAsset<Texture2D>("End1"); }  
        public static Sprite End1_End1 { get => ResSystem.LoadAsset<Sprite>("End1[End1]"); } 
        public static Texture2D End2 { get => ResSystem.LoadAsset<Texture2D>("End2"); }  
        public static Sprite End2_End2 { get => ResSystem.LoadAsset<Sprite>("End2[End2]"); } 
        public static Texture2D End3 { get => ResSystem.LoadAsset<Texture2D>("End3"); }  
        public static Sprite End3_End3 { get => ResSystem.LoadAsset<Sprite>("End3[End3]"); } 
        public static Texture2D End4 { get => ResSystem.LoadAsset<Texture2D>("End4"); }  
        public static Sprite End4_End4 { get => ResSystem.LoadAsset<Sprite>("End4[End4]"); } 
        public static Texture2D EnterPress1 { get => ResSystem.LoadAsset<Texture2D>("EnterPress1"); }  
        public static Sprite EnterPress1_EnterPress1 { get => ResSystem.LoadAsset<Sprite>("EnterPress1[EnterPress1]"); } 
        public static Texture2D ExplanationFromR { get => ResSystem.LoadAsset<Texture2D>("ExplanationFromR"); }  
        public static Sprite ExplanationFromR_ExplanationFromR { get => ResSystem.LoadAsset<Sprite>("ExplanationFromR[ExplanationFromR]"); } 
        public static Texture2D FakePressCard { get => ResSystem.LoadAsset<Texture2D>("FakePressCard"); }  
        public static Sprite FakePressCard_FakePressCard { get => ResSystem.LoadAsset<Sprite>("FakePressCard[FakePressCard]"); } 
        public static Texture2D FamiliarVoice { get => ResSystem.LoadAsset<Texture2D>("FamiliarVoice"); }  
        public static Sprite FamiliarVoice_FamiliarVoice { get => ResSystem.LoadAsset<Sprite>("FamiliarVoice[FamiliarVoice]"); } 
        public static Texture2D FileRoomLocked { get => ResSystem.LoadAsset<Texture2D>("FileRoomLocked"); }  
        public static Sprite FileRoomLocked_FileRoomLocked { get => ResSystem.LoadAsset<Sprite>("FileRoomLocked[FileRoomLocked]"); } 
        public static Texture2D FindPaperPiece { get => ResSystem.LoadAsset<Texture2D>("FindPaperPiece"); }  
        public static Sprite FindPaperPiece_FindPaperPiece { get => ResSystem.LoadAsset<Sprite>("FindPaperPiece[FindPaperPiece]"); } 
        public static Texture2D FoundByNurse { get => ResSystem.LoadAsset<Texture2D>("FoundByNurse"); }  
        public static Sprite FoundByNurse_FoundByNurse { get => ResSystem.LoadAsset<Sprite>("FoundByNurse[FoundByNurse]"); } 
        public static Texture2D GetCaughtToHospital { get => ResSystem.LoadAsset<Texture2D>("GetCaughtToHospital"); }  
        public static Sprite GetCaughtToHospital_GetCaughtToHospital { get => ResSystem.LoadAsset<Sprite>("GetCaughtToHospital[GetCaughtToHospital]"); } 
        public static Texture2D GetFile { get => ResSystem.LoadAsset<Texture2D>("GetFile"); }  
        public static Sprite GetFile_GetFile { get => ResSystem.LoadAsset<Sprite>("GetFile[GetFile]"); } 
        public static Texture2D GetIntoSecretRoom { get => ResSystem.LoadAsset<Texture2D>("GetIntoSecretRoom"); }  
        public static Sprite GetIntoSecretRoom_GetIntoSecretRoom { get => ResSystem.LoadAsset<Sprite>("GetIntoSecretRoom[GetIntoSecretRoom]"); } 
        public static Texture2D GetMemoryBack { get => ResSystem.LoadAsset<Texture2D>("GetMemoryBack"); }  
        public static Sprite GetMemoryBack_GetMemoryBack { get => ResSystem.LoadAsset<Sprite>("GetMemoryBack[GetMemoryBack]"); } 
        public static Texture2D GetOffBed { get => ResSystem.LoadAsset<Texture2D>("GetOffBed"); }  
        public static Sprite GetOffBed_GetOffBed { get => ResSystem.LoadAsset<Sprite>("GetOffBed[GetOffBed]"); } 
        public static Texture2D GetOutOfHospital { get => ResSystem.LoadAsset<Texture2D>("GetOutOfHospital"); }  
        public static Sprite GetOutOfHospital_GetOutOfHospital { get => ResSystem.LoadAsset<Sprite>("GetOutOfHospital[GetOutOfHospital]"); } 
        public static Texture2D GetPhoto { get => ResSystem.LoadAsset<Texture2D>("GetPhoto"); }  
        public static Sprite GetPhoto_GetPhoto { get => ResSystem.LoadAsset<Sprite>("GetPhoto[GetPhoto]"); } 
        public static Texture2D GetPhotoPiece { get => ResSystem.LoadAsset<Texture2D>("GetPhotoPiece"); }  
        public static Sprite GetPhotoPiece_GetPhotoPiece { get => ResSystem.LoadAsset<Sprite>("GetPhotoPiece[GetPhotoPiece]"); } 
        public static Texture2D GetPressCard { get => ResSystem.LoadAsset<Texture2D>("GetPressCard"); }  
        public static Sprite GetPressCard_GetPressCard { get => ResSystem.LoadAsset<Sprite>("GetPressCard[GetPressCard]"); } 
        public static Texture2D GoBackToOwnRoom { get => ResSystem.LoadAsset<Texture2D>("GoBackToOwnRoom"); }  
        public static Sprite GoBackToOwnRoom_GoBackToOwnRoom { get => ResSystem.LoadAsset<Sprite>("GoBackToOwnRoom[GoBackToOwnRoom]"); } 
        public static Texture2D GuardCome { get => ResSystem.LoadAsset<Texture2D>("GuardCome"); }  
        public static Sprite GuardCome_GuardCome { get => ResSystem.LoadAsset<Sprite>("GuardCome[GuardCome]"); } 
        public static Texture2D HateFather { get => ResSystem.LoadAsset<Texture2D>("HateFather"); }  
        public static Sprite HateFather_HateFather { get => ResSystem.LoadAsset<Sprite>("HateFather[HateFather]"); } 
        public static Texture2D Headache { get => ResSystem.LoadAsset<Texture2D>("Headache"); }  
        public static Sprite Headache_Headache { get => ResSystem.LoadAsset<Sprite>("Headache[Headache]"); } 
        public static Texture2D HeadLiner { get => ResSystem.LoadAsset<Texture2D>("HeadLiner"); }  
        public static Sprite HeadLiner_HeadLiner { get => ResSystem.LoadAsset<Sprite>("HeadLiner[HeadLiner]"); } 
        public static Texture2D HeardOfMissing198 { get => ResSystem.LoadAsset<Texture2D>("HeardOfMissing198"); }  
        public static Sprite HeardOfMissing198_HeardOfMissing198 { get => ResSystem.LoadAsset<Sprite>("HeardOfMissing198[HeardOfMissing198]"); } 
        public static Texture2D HideInToilet { get => ResSystem.LoadAsset<Texture2D>("HideInToilet"); }  
        public static Sprite HideInToilet_HideInToilet { get => ResSystem.LoadAsset<Sprite>("HideInToilet[HideInToilet]"); } 
        public static Texture2D HintFromR { get => ResSystem.LoadAsset<Texture2D>("HintFromR"); }  
        public static Sprite HintFromR_HintFromR { get => ResSystem.LoadAsset<Sprite>("HintFromR[HintFromR]"); } 
        public static Texture2D KeyNotPair { get => ResSystem.LoadAsset<Texture2D>("KeyNotPair"); }  
        public static Sprite KeyNotPair_KeyNotPair { get => ResSystem.LoadAsset<Sprite>("KeyNotPair[KeyNotPair]"); } 
        public static Texture2D LeaveHospital { get => ResSystem.LoadAsset<Texture2D>("LeaveHospital"); }  
        public static Sprite LeaveHospital_LeaveHospital { get => ResSystem.LoadAsset<Sprite>("LeaveHospital[LeaveHospital]"); } 
        public static Texture2D LisentToNeighbour { get => ResSystem.LoadAsset<Texture2D>("LisentToNeighbour"); }  
        public static Sprite LisentToNeighbour_LisentToNeighbour { get => ResSystem.LoadAsset<Sprite>("LisentToNeighbour[LisentToNeighbour]"); } 
        public static Texture2D LockInBox { get => ResSystem.LoadAsset<Texture2D>("LockInBox"); }  
        public static Sprite LockInBox_LockInBox { get => ResSystem.LoadAsset<Sprite>("LockInBox[LockInBox]"); } 
        public static Texture2D LoseTarget { get => ResSystem.LoadAsset<Texture2D>("LoseTarget"); }  
        public static Sprite LoseTarget_LoseTarget { get => ResSystem.LoadAsset<Sprite>("LoseTarget[LoseTarget]"); } 
        public static Texture2D MemoryFlash { get => ResSystem.LoadAsset<Texture2D>("MemoryFlash"); }  
        public static Sprite MemoryFlash_MemoryFlash { get => ResSystem.LoadAsset<Sprite>("MemoryFlash[MemoryFlash]"); } 
        public static Texture2D NeedPassword { get => ResSystem.LoadAsset<Texture2D>("NeedPassword"); }  
        public static Sprite NeedPassword_NeedPassword { get => ResSystem.LoadAsset<Sprite>("NeedPassword[NeedPassword]"); } 
        public static Texture2D NoOneInCorridor { get => ResSystem.LoadAsset<Texture2D>("NoOneInCorridor"); }  
        public static Sprite NoOneInCorridor_NoOneInCorridor { get => ResSystem.LoadAsset<Sprite>("NoOneInCorridor[NoOneInCorridor]"); } 
        public static Texture2D NurseEnterRoom { get => ResSystem.LoadAsset<Texture2D>("NurseEnterRoom"); }  
        public static Sprite NurseEnterRoom_NurseEnterRoom { get => ResSystem.LoadAsset<Sprite>("NurseEnterRoom[NurseEnterRoom]"); } 
        public static Texture2D Observation { get => ResSystem.LoadAsset<Texture2D>("Observation"); }  
        public static Sprite Observation_Observation { get => ResSystem.LoadAsset<Sprite>("Observation[Observation]"); } 
        public static Texture2D ObserveCloset { get => ResSystem.LoadAsset<Texture2D>("ObserveCloset"); }  
        public static Sprite ObserveCloset_ObserveCloset { get => ResSystem.LoadAsset<Sprite>("ObserveCloset[ObserveCloset]"); } 
        public static Texture2D ObserveNeighbour { get => ResSystem.LoadAsset<Texture2D>("ObserveNeighbour"); }  
        public static Sprite ObserveNeighbour_ObserveNeighbour { get => ResSystem.LoadAsset<Sprite>("ObserveNeighbour[ObserveNeighbour]"); } 
        public static Texture2D ObservePatientEmotion { get => ResSystem.LoadAsset<Texture2D>("ObservePatientEmotion"); }  
        public static Sprite ObservePatientEmotion_ObservePatientEmotion { get => ResSystem.LoadAsset<Sprite>("ObservePatientEmotion[ObservePatientEmotion]"); } 
        public static Texture2D ObserveToilet { get => ResSystem.LoadAsset<Texture2D>("ObserveToilet"); }  
        public static Sprite ObserveToilet_ObserveToilet { get => ResSystem.LoadAsset<Sprite>("ObserveToilet[ObserveToilet]"); } 
        public static Texture2D ObserveWall { get => ResSystem.LoadAsset<Texture2D>("ObserveWall"); }  
        public static Sprite ObserveWall_ObserveWall { get => ResSystem.LoadAsset<Sprite>("ObserveWall[ObserveWall]"); } 
        public static Texture2D OpenBox { get => ResSystem.LoadAsset<Texture2D>("OpenBox"); }  
        public static Sprite OpenBox_OpenBox { get => ResSystem.LoadAsset<Sprite>("OpenBox[OpenBox]"); } 
        public static Texture2D Password { get => ResSystem.LoadAsset<Texture2D>("Password"); }  
        public static Sprite Password_Password { get => ResSystem.LoadAsset<Sprite>("Password[Password]"); } 
        public static Texture2D PatientInHappiness { get => ResSystem.LoadAsset<Texture2D>("PatientInHappiness"); }  
        public static Sprite PatientInHappiness_PatientInHappiness { get => ResSystem.LoadAsset<Sprite>("PatientInHappiness[PatientInHappiness]"); } 
        public static Texture2D PlanToGetInfomation { get => ResSystem.LoadAsset<Texture2D>("PlanToGetInfomation"); }  
        public static Sprite PlanToGetInfomation_PlanToGetInfomation { get => ResSystem.LoadAsset<Sprite>("PlanToGetInfomation[PlanToGetInfomation]"); } 
        public static Texture2D PlanToTakeAction { get => ResSystem.LoadAsset<Texture2D>("PlanToTakeAction"); }  
        public static Sprite PlanToTakeAction_PlanToTakeAction { get => ResSystem.LoadAsset<Sprite>("PlanToTakeAction[PlanToTakeAction]"); } 
        public static Texture2D PressFlushButton { get => ResSystem.LoadAsset<Texture2D>("PressFlushButton"); }  
        public static Sprite PressFlushButton_PressFlushButton { get => ResSystem.LoadAsset<Sprite>("PressFlushButton[PressFlushButton]"); } 
        public static Texture2D QuestionNurse { get => ResSystem.LoadAsset<Texture2D>("QuestionNurse"); }  
        public static Sprite QuestionNurse_QuestionNurse { get => ResSystem.LoadAsset<Sprite>("QuestionNurse[QuestionNurse]"); } 
        public static Texture2D RecordTheScene { get => ResSystem.LoadAsset<Texture2D>("RecordTheScene"); }  
        public static Sprite RecordTheScene_RecordTheScene { get => ResSystem.LoadAsset<Sprite>("RecordTheScene[RecordTheScene]"); } 
        public static Texture2D RefusePill { get => ResSystem.LoadAsset<Texture2D>("RefusePill"); }  
        public static Sprite RefusePill_RefusePill { get => ResSystem.LoadAsset<Sprite>("RefusePill[RefusePill]"); } 
        public static Texture2D RunIntoTheHall { get => ResSystem.LoadAsset<Texture2D>("RunIntoTheHall"); }  
        public static Sprite RunIntoTheHall_RunIntoTheHall { get => ResSystem.LoadAsset<Sprite>("RunIntoTheHall[RunIntoTheHall]"); } 
        public static Texture2D SeeFile { get => ResSystem.LoadAsset<Texture2D>("SeeFile"); }  
        public static Sprite SeeFile_SeeFile { get => ResSystem.LoadAsset<Sprite>("SeeFile[SeeFile]"); } 
        public static Texture2D ShoutInCorridor { get => ResSystem.LoadAsset<Texture2D>("ShoutInCorridor"); }  
        public static Sprite ShoutInCorridor_ShoutInCorridor { get => ResSystem.LoadAsset<Sprite>("ShoutInCorridor[ShoutInCorridor]"); } 
        public static Texture2D ShowPressCard { get => ResSystem.LoadAsset<Texture2D>("ShowPressCard"); }  
        public static Sprite ShowPressCard_ShowPressCard { get => ResSystem.LoadAsset<Sprite>("ShowPressCard[ShowPressCard]"); } 
        public static Texture2D StickPhotoTogether { get => ResSystem.LoadAsset<Texture2D>("StickPhotoTogether"); }  
        public static Sprite StickPhotoTogether_StickPhotoTogether { get => ResSystem.LoadAsset<Sprite>("StickPhotoTogether[StickPhotoTogether]"); } 
        public static Texture2D TakePill1 { get => ResSystem.LoadAsset<Texture2D>("TakePill1"); }  
        public static Sprite TakePill1_TakePill1 { get => ResSystem.LoadAsset<Sprite>("TakePill1[TakePill1]"); } 
        public static Texture2D TakePill2 { get => ResSystem.LoadAsset<Texture2D>("TakePill2"); }  
        public static Sprite TakePill2_TakePill2 { get => ResSystem.LoadAsset<Sprite>("TakePill2[TakePill2]"); } 
        public static Texture2D TalkAboutAmnesia { get => ResSystem.LoadAsset<Texture2D>("TalkAboutAmnesia"); }  
        public static Sprite TalkAboutAmnesia_TalkAboutAmnesia { get => ResSystem.LoadAsset<Sprite>("TalkAboutAmnesia[TalkAboutAmnesia]"); } 
        public static Texture2D TalkAboutFamily { get => ResSystem.LoadAsset<Texture2D>("TalkAboutFamily"); }  
        public static Sprite TalkAboutFamily_TalkAboutFamily { get => ResSystem.LoadAsset<Sprite>("TalkAboutFamily[TalkAboutFamily]"); } 
        public static Texture2D TalkAboutIllness { get => ResSystem.LoadAsset<Texture2D>("TalkAboutIllness"); }  
        public static Sprite TalkAboutIllness_TalkAboutIllness { get => ResSystem.LoadAsset<Sprite>("TalkAboutIllness[TalkAboutIllness]"); } 
        public static Texture2D TalkToHusband { get => ResSystem.LoadAsset<Texture2D>("TalkToHusband"); }  
        public static Sprite TalkToHusband_TalkToHusband { get => ResSystem.LoadAsset<Sprite>("TalkToHusband[TalkToHusband]"); } 
        public static Texture2D WakeUp { get => ResSystem.LoadAsset<Texture2D>("WakeUp"); }  
        public static Sprite WakeUp_WakeUp { get => ResSystem.LoadAsset<Sprite>("WakeUp[WakeUp]"); } 
        public static Texture2D WhichToRummage { get => ResSystem.LoadAsset<Texture2D>("WhichToRummage"); }  
        public static Sprite WhichToRummage_WhichToRummage { get => ResSystem.LoadAsset<Sprite>("WhichToRummage[WhichToRummage]"); } 
        public static Texture2D GetRecordPen { get => ResSystem.LoadAsset<Texture2D>("GetRecordPen"); }  
        public static Sprite GetRecordPen_GetRecordPen { get => ResSystem.LoadAsset<Sprite>("GetRecordPen[GetRecordPen]"); } 
        public static Texture2D GetPatientRecord { get => ResSystem.LoadAsset<Texture2D>("GetPatientRecord"); }  
        public static Sprite GetPatientRecord_GetPatientRecord { get => ResSystem.LoadAsset<Sprite>("GetPatientRecord[GetPatientRecord]"); } 
        public static Texture2D GetOutOfTheRoom { get => ResSystem.LoadAsset<Texture2D>("GetOutOfTheRoom"); }  
        public static Sprite GetOutOfTheRoom_GetOutOfTheRoom { get => ResSystem.LoadAsset<Sprite>("GetOutOfTheRoom[GetOutOfTheRoom]"); } 
        public static Texture2D EventPanel { get => ResSystem.LoadAsset<Texture2D>("EventPanel"); }  
        public static Sprite EventPanel_EventPanel { get => ResSystem.LoadAsset<Sprite>("EventPanel[EventPanel]"); } 
        public static Texture2D Prop_Background_Unselected { get => ResSystem.LoadAsset<Texture2D>("Prop_Background_Unselected"); }  
        public static Sprite Prop_Background_Unselected_Prop_Background_Unselected { get => ResSystem.LoadAsset<Sprite>("Prop_Background_Unselected[Prop_Background_Unselected]"); } 
        public static Texture2D Prop_Background_Selected { get => ResSystem.LoadAsset<Texture2D>("Prop_Background_Selected"); }  
        public static Sprite Prop_Background_Selected_Prop_Background_Selected { get => ResSystem.LoadAsset<Sprite>("Prop_Background_Selected[Prop_Background_Selected]"); }
    } 
    public static class Card
    {
 
        public static GameObject ActionCard { get => ResSystem.LoadAsset<GameObject>("ActionCard"); }  
        public static GameObject ActionCard_GameObject(Transform parent = null,string keyName=null,bool autoRelease = true)
        {
            return ResSystem.InstantiateGameObject("ActionCard", parent, keyName,autoRelease);
        } 
        public static GameObject PropCard { get => ResSystem.LoadAsset<GameObject>("PropCard"); }  
        public static GameObject PropCard_GameObject(Transform parent = null,string keyName=null,bool autoRelease = true)
        {
            return ResSystem.InstantiateGameObject("PropCard", parent, keyName,autoRelease);
        }
    } 
    public static class UI
    {
 
        public static GameObject MainMenuWindow { get => ResSystem.LoadAsset<GameObject>("MainMenuWindow"); }  
        public static GameObject MainMenuWindow_GameObject(Transform parent = null,string keyName=null,bool autoRelease = true)
        {
            return ResSystem.InstantiateGameObject("MainMenuWindow", parent, keyName,autoRelease);
        } 
        public static GameObject AboutUsWindow { get => ResSystem.LoadAsset<GameObject>("AboutUsWindow"); }  
        public static GameObject AboutUsWindow_GameObject(Transform parent = null,string keyName=null,bool autoRelease = true)
        {
            return ResSystem.InstantiateGameObject("AboutUsWindow", parent, keyName,autoRelease);
        } 
        public static GameObject FadeWindow { get => ResSystem.LoadAsset<GameObject>("FadeWindow"); }  
        public static GameObject FadeWindow_GameObject(Transform parent = null,string keyName=null,bool autoRelease = true)
        {
            return ResSystem.InstantiateGameObject("FadeWindow", parent, keyName,autoRelease);
        } 
        public static GameObject GameOverWindow { get => ResSystem.LoadAsset<GameObject>("GameOverWindow"); }  
        public static GameObject GameOverWindow_GameObject(Transform parent = null,string keyName=null,bool autoRelease = true)
        {
            return ResSystem.InstantiateGameObject("GameOverWindow", parent, keyName,autoRelease);
        } 
        public static Texture2D Image_MainMenu { get => ResSystem.LoadAsset<Texture2D>("Image_MainMenu"); }  
        public static Sprite Image_MainMenu_Image_MainMenu { get => ResSystem.LoadAsset<Sprite>("Image_MainMenu[Image_MainMenu]"); } 
        public static Texture2D Image_AboutUs { get => ResSystem.LoadAsset<Texture2D>("Image_AboutUs"); }  
        public static Sprite Image_AboutUs_Image_AboutUs { get => ResSystem.LoadAsset<Sprite>("Image_AboutUs[Image_AboutUs]"); } 
        public static Texture2D Button_Cancel { get => ResSystem.LoadAsset<Texture2D>("Button_Cancel"); }  
        public static Sprite Button_Cancel_Button_Cancel { get => ResSystem.LoadAsset<Sprite>("Button_Cancel[Button_Cancel]"); } 
        public static Texture2D Button_Background { get => ResSystem.LoadAsset<Texture2D>("Button_Background"); }  
        public static Sprite Button_Background_Button_Background { get => ResSystem.LoadAsset<Sprite>("Button_Background[Button_Background]"); } 
        public static Texture2D FrameMask { get => ResSystem.LoadAsset<Texture2D>("FrameMask"); }  
        public static Sprite FrameMask_FrameMask { get => ResSystem.LoadAsset<Sprite>("FrameMask[FrameMask]"); }
    }
}