using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace RawDataMessage_Interpreter.RawDataMessage
{
    public class RawDataMessage
    {
        private Swf swf = null;
        private List<Class> classes;
        private List<Method> methods;
        private List<Variable> variables;
        public string gameServerTicket = "";

        public RawDataMessage(Swf swf)
        {
            this.swf = swf;
            classes = new List<Class>();
            methods = new List<Method>();
            variables = new List<Variable>();
        }

        public RawDataMessage()
        {
            classes = new List<Class>();
            methods = new List<Method>();
            variables = new List<Variable>();
        }

        public Swf GetSwf()
        {
            return swf;
        }

        public List<Method> GetMethods()
        {
            return methods;
        }

        public List<Variable> GetVariables()
        {
            return variables;
        }

        public static Dictionary<string, string> dictioVarTypes = new Dictionary<string, string>() {
                { "Vector","List" },
                { "Number", "double" },
                { "Array", "ArrayList" },
                { "Boolean", "bool" }
            };

        public static List<String> filesToParse = new List<string>()
        {
            "CharacterBasicMinimalInformations.cs",
            "FightStartingPositions.cs",
            "HumanOptionSkillUse.cs",
            "MonsterBoosts.cs",
            "ArenaRankInfos.cs",
            "JobBookSubscription.cs",
            "DareCriteria.cs",
            "DareInformations.cs",
            "DareReward.cs",
            "DareVersatileInformations.cs",
            "ObjectItemGenericQuantity.cs",
            "ObjectItemGenericQuantityPrice.cs",
            "FinishMoveInformations.cs",
            "HavenBagFurnitureInformation.cs",
            "TaxCollectorMovement.cs",
            "HouseGuildedInformations.cs",
            "HouseInstanceInformations.cs",
            "HouseOnMapInformations.cs",
            "Idol.cs",
            "PartyIdol.cs",
            "IdolsPreset.cs",
            "PaddockGuildedInformations.cs",
            "PaddockInstancesInformations.cs",
            "ShortcutObjectIdolsPreset.cs",
            "AccessoryPreviewErrorEnum.cs",
            "AggressableStatusEnum.cs",
            "AlignmentSideEnum.cs",
            "AllianceRightsBitEnum.cs",
            "BoostableCharacteristicEnum.cs",
            "BreedEnum.cs",
            "BuildTypeEnum.cs",
            "CharacterCreationResultEnum.cs",
            "CharacterDeletionErrorEnum.cs",
            "CharacterInventoryPositionEnum.cs",
            "CharacterRemodelingEnum.cs",
            "CharacterSpellModificationTypeEnum.cs",
            "ChatActivableChannelsEnum.cs",
            "ChatChannelsMultiEnum.cs",
            "ChatErrorEnum.cs",
            "ClientInstallTypeEnum.cs",
            "ClientTechnologyEnum.cs",
            "CompassTypeEnum.cs",
            "ConsoleMessageTypeEnum.cs",
            "CraftResultEnum.cs",
            "DareCriteriaTypeEnum.cs",
            "DareErrorEnum.cs",
            "DebugLevelEnum.cs",
            "DelayedActionTypeEnum.cs",
            "DialogTypeEnum.cs",
            "DirectionsEnum.cs",
            "ExchangeErrorEnum.cs",
            "ExchangeReplayStopReasonEnum.cs",
            "ExchangeTypeEnum.cs",
            "FightDispellableEnum.cs",
            "FightOptionsEnum.cs",
            "FightOutcomeEnum.cs",
            "FightSpellCastCriticalEnum.cs",
            "FightTypeEnum.cs",
            "FighterRefusedReasonEnum.cs",
            "GameActionFightInvisibilityStateEnum.cs",
            "GameActionMarkCellsTypeEnum.cs",
            "GameActionMarkTypeEnum.cs",
            "GameContextEnum.cs",
            "GameHierarchyEnum.cs",
            "GuestLimitationEnum.cs",
            "GuildInformationsTypeEnum.cs",
            "GuildRightsBitEnum.cs",
            "HaapiTokenTypeEnum.cs",
            "HardcoreOrEpicDeathStateEnum.cs",
            "HavenBagDailyLoteryErrorEnum.cs",
            "IdentificationFailureReasonEnum.cs",
            "ListAddFailureEnum.cs",
            "MapObstacleStateEnum.cs",
            "MountEquipedErrorEnum.cs",
            "NicknameErrorEnum.cs",
            "NicknameGeneratingFailureEnum.cs",
            "ObjectErrorEnum.cs",
            "PartStateEnum.cs",
            "PartyJoinErrorEnum.cs",
            "PartyNameErrorEnum.cs",
            "PartyTypeEnum.cs",
            "PlayableBreedEnum.cs",
            "PlayerLifeStatusEnum.cs",
            "PlayerStateEnum.cs",
            "PlayerStatusEnum.cs",
            "PresetDeleteResultEnum.cs",
            "PresetSaveResultEnum.cs",
            "PresetSaveUpdateErrorEnum.cs",
            "PresetUseResultEnum.cs",
            "PrismListenEnum.cs",
            "PrismSetSabotagedRefusedReasonEnum.cs",
            "PrismStateEnum.cs",
            "PvpArenaStepEnum.cs",
            "PvpArenaTypeEnum.cs",
            "SequenceTypeEnum.cs",
            "ServerCompletionEnum.cs",
            "ServerConnectionErrorEnum.cs",
            "ServerStatusEnum.cs",
            "ShortcutBarEnum.cs",
            "SocialContactCategoryEnum.cs",
            "SocialGroupCreationResultEnum.cs",
            "SocialGroupInvitationStateEnum.cs",
            "SocialNoticeErrorEnum.cs",
            "StatisticTypeEnum.cs",
            "StatsUpgradeResultEnum.cs",
            "SubEntityBindingPointCategoryEnum.cs",
            "SubscriptionRequiredEnum.cs",
            "TaxCollectorErrorReasonEnum.cs",
            "TaxCollectorMovementTypeEnum.cs",
            "TaxCollectorStateEnum.cs",
            "TeamEnum.cs",
            "TeamTypeEnum.cs",
            "TeleporterTypeEnum.cs",
            "TextInformationTypeEnum.cs",
            "TreasureHuntDigRequestEnum.cs",
            "TreasureHuntFlagRequestEnum.cs",
            "TreasureHuntFlagStateEnum.cs",
            "TreasureHuntRequestEnum.cs",
            "TreasureHuntTypeEnum.cs",
            "UpdatableMountBoostEnum.cs"
        };

        public List<int> getCheckIntegrityMessage()
        {
            //// Initialize



            //StreamReader sr = new StreamReader(@"D:\DI\Dofus Invoker\types\game\character\characteristic\CharacterCharacteristicsInformations.as");
            //AS humanCheck = new AS();
            //humanCheck.Content = sr.ReadToEnd();
            //humanCheck.FileName = "CharacterCharacteristicsInformations";
            ////humanCheck.Content = Parser.removeUselessThings(humanCheck.Content);
            ////StreamWriter writer = new StreamWriter(humanCheck.FileName + ".cleaned.as");
            ////writer.Write(humanCheck.Content);
            ////writer.Close();
            //classes.AddRange(Parser.getClasses(humanCheck.Content));
            ////methods.AddRange(Parser.getMethods(humanCheck.Content));
            ////variables.AddRange(Parser.getVariables(humanCheck.Content));

            //string converted = Converter.GetFinalCode(classes, String.Join("\"));
            //File.WriteAllText("converted.cs", converted);

            //string directory = Path.GetDirectoryName(swf.GetActionScript()[0].FileName);
            //Directory.Delete(directory, true);

            //return CodeDom.Compiler.Compile(converted) as List<int>;
            return new List<int>();
        }

        public Class getClassByName(string name)
        {
            return this.classes.First(clas => clas.Name == name);
        }

        public Method getMethodByName(string name)
        {
            return methods.First(method => method.Name == name);
        }



        public static void DirSearch(string dir)
        {
            try
            {
                foreach (DirectoryInfo d in (new DirectoryInfo(dir).GetDirectories()))
                {
                    foreach (FileInfo f in d.GetFiles())
                    {
                        WriteNewFile(f);
                    }
                    DirSearch(d.FullName);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

        public static void WriteNewFile(FileInfo f)
        {
            if (filesToParse.Contains(f.Name))
            {
                StreamReader sr = new StreamReader(f.FullName);
                string content = sr.ReadToEnd();
                sr.Close();
                List<Class> classes = new List<Class>();
                classes.AddRange(Parser.getClasses(content));
                string converted = Converter.GetFinalCode(classes, "BlueSheep.Common.Protocol.Types");
                File.WriteAllText(f.FullName, converted);
            }
        }
    }
}
