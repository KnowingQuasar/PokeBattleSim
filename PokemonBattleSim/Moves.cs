namespace PokemonBattleSim
{
    public static class Moves
    {
        #region Unique
        /// <summary>
        /// Contains all the unique z-moves as well as the one signifying no effect
        /// </summary>
        public static class UniqueZMoves
        {
            #region Declarations
            /// <summary>
            /// Pikachu exclusive z-move, replaces Volt Tackle (Pikanium-Z)
            /// </summary>
            public static ZMove Catastropika;

            /// <summary>
            /// Eevee exclusive z-move, replaces Last Resort (Eevium-Z)
            /// </summary>
            public static ZMove ExtremeEvoboost;

            /// <summary>
            /// Mew exclusive z-move, replaces Psychic (Mewnium-Z)
            /// </summary>
            public static ZMove GenesisSupernova;

            /// <summary>
            /// Tapu exclusive z-move, replaces Nature's Madness (Tapunium-Z)
            /// </summary>
            public static ZMove GuardianOfAlola;

            /// <summary>
            /// Incineroar exclusive z-move, replaces Darkest Lariat (Incinium-Z)
            /// </summary>
            public static ZMove MaliciousMoonsault;

            /// <summary>
            /// The Z-Move used if the z-form of a move has no additional effects
            /// </summary>
            public static ZMove NO_EFFECT;

            /// <summary>
            /// Primarina exclusive z-move, replaces Sparkling Aria (Primarium-Z)
            /// </summary>
            public static ZMove OceanicOperetta;

            /// <summary>
            /// Snorlax exclusive z-move, replaces Giga Impact (Snorlium-Z)
            /// </summary>
            public static ZMove PulverizingPancake;

            /// <summary>
            /// Decidueye exclusive z-move, replaces Spirit Shackle (Decidium-Z)
            /// </summary>
            public static ZMove SinisterArrowRaid;

            /// <summary>
            /// Marshadow exclusive z-move, replaces Spectral Thief (Marshadium-Z)
            /// </summary>
            public static ZMove SoulStealing7StarStrike;

            /// <summary>
            /// Raichu exclusive z-move, replaces Thunderbolt (Aloraichium-Z)
            /// </summary>
            public static ZMove StokedSparksurfer;

            /// <summary>
            /// Pikachu exclusive z-move, replaces Thunderbolt (Pikashunium-Z)
            /// </summary>
            public static ZMove VoltThunderbolt;
            #endregion

            #region Definition
            static UniqueZMoves()
            {
                Catastropika = new ZMove("Catastropika", 210, null, null);
                ExtremeEvoboost = new ZMove("Extreme Evoboost", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp2, StatChanges.PositiveStatChanges.DefUp2, StatChanges.PositiveStatChanges.SpAtkUp2, StatChanges.PositiveStatChanges.SpDefUp2, StatChanges.PositiveStatChanges.SpdUp2 }, new bool[] { true, true, true, true, true });
                GenesisSupernova = new ZMove("Genesis Supernova", 185, null, null);
                GuardianOfAlola = new ZMove("Guardian of Alola", 0, new Effect[] { Effects.RareEffects.CutCurrHPBy75Pcnt }, new bool[] { false });
                MaliciousMoonsault = new ZMove("Malicious Moonsault", 180, null, null);
                NO_EFFECT = new ZMove("EMPTY", 0, null, null);
                OceanicOperetta = new ZMove("Oceanic Operetta", 195, null, null);
                PulverizingPancake = new ZMove("Pulverizing Pancake", 210, null, null);
                SinisterArrowRaid = new ZMove("Sinister Arrow Raid", 180, null, null);
                SoulStealing7StarStrike = new ZMove("Soul-Stealing 7-Star Strike", 195, null, null);
                StokedSparksurfer = new ZMove("Stoked Sparksurfer", 175, null, null);
                VoltThunderbolt = new ZMove("10,000,000 Volt Thunderbolt", 195, new Effect[] { Effects.GeneralEffects.HighCrit }, new bool[] { true });
            }
            #endregion
        }
        #endregion

        #region Normal
        /// <summary>
        /// All Normal moves
        /// </summary>
        public static class Normal
        {
            #region Normal Z-Moves
            public static ZMove BreakneckBlitz;
            public static ZMove ZAcupressure;
            public static ZMove ZAfterYou;
            public static ZMove ZAttract;
            public static ZMove ZBatonPass;
            public static ZMove ZBellyDrum;
            public static ZMove ZBestow;
            public static ZMove ZBide;
            public static ZMove ZBlock;
            public static ZMove ZCamouflage;
            public static ZMove ZCaptivate;
            public static ZMove ZCelebrate;
            public static ZMove ZConfide;
            public static ZMove ZConversion;
            public static ZMove ZConversion2;
            public static ZMove ZCopycat;
            public static ZMove ZDefenseCurl;
            public static ZMove ZDisable;
            public static ZMove ZDoubleTeam;
            public static ZMove ZEncore;
            public static ZMove ZEndeavor;
            public static ZMove ZEndure;
            public static ZMove ZEntrainment;
            public static ZMove ZFlash;
            public static ZMove ZFocusEnergy;
            public static ZMove ZFollowMe;
            public static ZMove ZForesight;
            public static ZMove ZGlare;
            public static ZMove ZGrowl;
            public static ZMove ZGrowth;
            public static ZMove ZHappyHour;
            public static ZMove ZHarden;
            public static ZMove ZHealBell;
            public static ZMove ZHelpingHand;
            public static ZMove ZHoldHands;
            public static ZMove ZHowl;
            public static ZMove ZLaserFocus;
            public static ZMove ZLeer;
            public static ZMove ZLockOn;
            public static ZMove ZLovelyKiss;
            public static ZMove ZLuckyChant;
            public static ZMove ZMeFirst;
            public static ZMove ZMeanLook;
            public static ZMove ZMilkDrink;
            public static ZMove ZMimic;
            public static ZMove ZMindReader;
            public static ZMove ZMinimize;
            public static ZMove ZMorningSun;
            public static ZMove ZNobleRoar;
            public static ZMove ZOdorSleuth;
            public static ZMove ZPainSplit;
            public static ZMove ZPerishSong;
            public static ZMove ZPlayNice;
            public static ZMove ZProtect;
            public static ZMove ZPsychUp;
            public static ZMove ZRecover;
            public static ZMove ZRecycle;
            public static ZMove ZReflectType;
            public static ZMove ZRefresh;
            public static ZMove ZRoar;
            public static ZMove ZSafeguard;
            public static ZMove ZScaryFace;
            public static ZMove ZScreech;
            public static ZMove ZSharpen;
            public static ZMove ZShellSmash;
            public static ZMove ZSimpleBeam;
            public static ZMove ZSing;
            public static ZMove ZSketch;
            public static ZMove ZSlackOff;
            public static ZMove ZSleepTalk;
            public static ZMove ZSmokescreen;
            public static ZMove ZSoftBoiled;
            public static ZMove ZSplash;
            public static ZMove ZSpotlight;
            public static ZMove ZStockpile;
            public static ZMove ZSubstitute;
            public static ZMove ZSupersonic;
            public static ZMove ZSwagger;
            public static ZMove ZSwallow;
            public static ZMove ZSweetScent;
            public static ZMove ZSwordsDance;
            public static ZMove ZTailWhip;
            public static ZMove ZTearfulLook;
            public static ZMove ZTeeterDance;
            public static ZMove ZTickle;
            public static ZMove ZTransform;
            public static ZMove ZWhirlwind;
            public static ZMove ZWish;
            public static ZMove ZWorkUp;
            public static ZMove ZYawn;
            #endregion

            #region Normal Moves
            public static Move Acupressure;
            public static Move AfterYou;
            public static Move Assist;
            public static Move Attract;
            public static Move Barrage;
            public static Move BatonPass;
            public static Move BellyDrum;
            public static Move Bestow;
            public static Move Bide;
            public static Move Bind;
            public static Move Block;
            public static Move BodySlam;
            public static Move Boomburst;
            public static Move Camouflage;
            public static Move Captivate;
            public static Move Celebrate;
            public static Move ChipAway;
            public static Move CometPunch;
            public static Move Confide;
            public static Move Constrict;
            public static Move Conversion;
            public static Move Conversion2;
            public static Move Copycat;
            public static Move Covet;
            public static Move CrushClaw;
            public static Move CrushGrip;
            public static Move Cut;
            public static Move DefenseCurl;
            public static Move Disable;
            public static Move DizzyPunch;
            public static Move DoubleHit;
            public static Move DoubleSlap;
            public static Move DoubleTeam;
            public static Move DoubleEdge;
            public static Move EchoedVoice;
            public static Move EggBomb;
            public static Move Encore;
            public static Move Endeavor;
            public static Move Endure;
            public static Move Entrainment;
            public static Move Explosion;
            public static Move ExtremeSpeed;
            public static Move Facade;
            public static Move FakeOut;
            public static Move FalseSwipe;
            public static Move Feint;
            public static Move Flail;
            public static Move Flash;
            public static Move FocusEnergy;
            public static Move FollowMe;
            public static Move Foresight;
            public static Move Frustration;
            public static Move FuryAttack;
            public static Move FurySwipes;
            public static Move GigaImpact;
            public static Move Glare;
            public static Move Growl;
            public static Move Growth;
            public static Move Guillotine;
            public static Move HappyHour;
            public static Move Harden;
            public static Move HeadCharge;
            public static Move Headbutt;
            public static Move HealBell;
            public static Move HelpingHand;
            public static Move HiddenPower;
            public static Move HoldBack;
            public static Move HoldHands;
            public static Move HornAttack;
            public static Move HornDrill;
            public static Move Howl;
            public static Move HyperBeam;
            public static Move HyperFang;
            public static Move HyperVoice;
            public static Move Judgement;
            public static Move LaserFocus;
            public static Move LastResort;
            public static Move Leer;
            public static Move LockOn;
            public static Move LovelyKiss;
            public static Move LuckyChant;
            public static Move MeFirst;
            public static Move MeanLook;
            public static Move MegaKick;
            public static Move MegaPunch;
            public static Move Metronome;
            public static Move MilkDrink;
            public static Move Mimic;
            public static Move MindReader;
            public static Move Minimize;
            public static Move MorningSun;
            public static Move MultiAttack;
            public static Move NaturalGift;
            public static Move NaturePower;
            public static Move NobleRoar;
            public static Move OdorSleuth;
            public static Move PainSplit;
            public static Move PayDay;
            public static Move PerishSong;
            public static Move PlayNice;
            public static Move Pound;
            public static Move Present;
            public static Move Protect;
            public static Move PsychUp;
            public static Move QuickAttack;
            public static Move Rage;
            public static Move RapidSpin;
            public static Move RazorWind;
            public static Move Recover;
            public static Move Recycle;
            public static Move ReflectType;
            public static Move Refresh;
            public static Move RelicSong;
            public static Move Retaliate;
            public static Move Return;
            public static Move RevelationDance;
            public static Move Roar;
            public static Move RockClimb;
            public static Move Round;
            public static Move Safeguard;
            public static Move ScaryFace;
            public static Move Scratch;
            public static Move Screech;
            public static Move SecretPower;
            public static Move SelfDestruct;
            public static Move Sharpen;
            public static Move ShellSmash;
            public static Move SimpleBeam;
            public static Move Sing;
            public static Move Sketch;
            public static Move SkullBash;
            public static Move SlackOff;
            public static Move Slam;
            public static Move Slash;
            public static Move SleepTalk;
            public static Move SmellingSalts;
            public static Move Smokescreen;
            public static Move Snore;
            public static Move SoftBoiled;
            public static Move SonicBoom;
            public static Move SpikeCannon;
            public static Move SpitUp;
            public static Move Splash;
            public static Move Spotlight;
            public static Move Stockpile;
            public static Move Stomp;
            public static Move Strength;
            public static Move Struggle;
            public static Move Substitute;
            public static Move SuperFang;
            public static Move Supersonic;
            public static Move Swagger;
            public static Move Swallow;
            public static Move SweetScent;
            public static Move Swift;
            public static Move SwordsDance;
            public static Move Tackle;
            public static Move TailSlap;
            public static Move TailWhip;
            public static Move TakeDown;
            public static Move TearfulLook;
            public static Move TechnoBlast;
            public static Move TeeterDance;
            public static Move Thrash;
            public static Move Tickle;
            public static Move Transform;
            public static Move TriAttack;
            public static Move TrumpCard;
            public static Move Uproar;
            public static Move ViceGrip;
            public static Move WeatherBall;
            public static Move Whirlwind;
            public static Move Wish;
            public static Move WorkUp;
            public static Move Wrap;
            public static Move WringOut;
            public static Move Yawn;
            #endregion

            #region Normal Constructor
            static Normal()
            {
                #region Z-Normal Constructor
                #region A-M
                BreakneckBlitz = new ZMove("Breakneck Blitz", 100, null, null);
                ZAcupressure = new ZMove("Z-Acupressure", 0, new Effect[] { StatChanges.PositiveStatChanges.CritUp1 }, new bool[] { true });
                ZAfterYou = new ZMove("Z-After You", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZAttract = new ZMove("Z-Attract", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZBatonPass = new ZMove("Z-Baton Pass", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZBellyDrum = new ZMove("Z-Belly Drum", 0, new Effect[] { Effects.HealingEffects.HPRestore.FullHPRestore }, new bool[] { true });
                ZBestow = new ZMove("Z-Bestow", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp2 }, new bool[] { true });
                ZBlock = new ZMove("Z-Block", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                ZCamouflage = new ZMove("Z-Camouflage", 0, new Effect[] { StatChanges.PositiveStatChanges.EvasUp1 }, new bool[] { true });
                ZCaptivate = new ZMove("Z-Captivate", 0, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp2 }, new bool[] { true });
                ZCelebrate = new ZMove("Z-Celebrate", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1, StatChanges.PositiveStatChanges.DefUp1, StatChanges.PositiveStatChanges.SpAtkUp1, StatChanges.PositiveStatChanges.SpDefUp1, StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true, true, true, true, true });
                ZConfide = new ZMove("Z-Confide", 0, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp1 }, new bool[] { true });
                ZConversion = new ZMove("Z-Conversion", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1, StatChanges.PositiveStatChanges.DefUp1, StatChanges.PositiveStatChanges.SpAtkUp1, StatChanges.PositiveStatChanges.SpDefUp1, StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true, true, true, true, true });
                ZConversion2 = new ZMove("Z-Conversion2", 0, new Effect[] { Effects.HealingEffects.HPRestore.FullHPRestore }, new bool[] { true });
                ZCopycat = new ZMove("Z-Copycat", 0, new Effect[] { StatChanges.PositiveStatChanges.AccUp1 }, new bool[] { true });
                ZDefenseCurl = new ZMove("Z-Defense Curl", 0, new Effect[] { StatChanges.PositiveStatChanges.AccUp1 }, new bool[] { true });
                ZDisable = new ZMove("Z-Disable", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZDoubleTeam = new ZMove("Z-DoubleTeam", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZEncore = new ZMove("Z-Encore", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZEndure = new ZMove("Z-Endure", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZEntrainment = new ZMove("Z-Entrainment", 0, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp1 }, new bool[] { true });
                ZFlash = new ZMove("Z-Flash", 0, new Effect[] { StatChanges.PositiveStatChanges.EvasUp1 }, new bool[] { true });
                ZFocusEnergy = new ZMove("Z-Focus Energy", 0, new Effect[] { StatChanges.PositiveStatChanges.AccUp1 }, new bool[] { true });
                ZFollowMe = new ZMove("Z-Follow Me", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZForesight = new ZMove("Z-Foresight", 0, new Effect[] { StatChanges.PositiveStatChanges.CritUp1 }, new bool[] { true });
                ZGlare = new ZMove("Z-Glare", 0, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp1 }, new bool[] { true });
                ZGrowl = new ZMove("Z-Growl", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                ZGrowth = new ZMove("Z-Growth", 0, new Effect[] { StatChanges.PositiveStatChanges.SpAtkUp1 }, new bool[] { true });
                ZHappyHour = new ZMove("Z-Happy Hour", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1, StatChanges.PositiveStatChanges.DefUp1, StatChanges.PositiveStatChanges.SpAtkUp1, StatChanges.PositiveStatChanges.SpDefUp1, StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true, true, true, true, true });
                ZHarden = new ZMove("Z-Harden", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                ZHealBell = new ZMove("Z-Heal Bell", 0, new Effect[] { Effects.HealingEffects.HPRestore.FullHPRestore }, new bool[] { true });
                ZHelpingHand = new ZMove("Z-Helping Hand", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZHoldHands = new ZMove("Z-Hold Hands", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1, StatChanges.PositiveStatChanges.DefUp1, StatChanges.PositiveStatChanges.SpAtkUp1, StatChanges.PositiveStatChanges.SpDefUp1, StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true, true, true, true, true });
                ZHowl = new ZMove("Z-Howl", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1 }, new bool[] { true });
                ZLaserFocus = new ZMove("Z-Laser Focus", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1 }, new bool[] { true });
                ZLeer = new ZMove("Z-Leer", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1 }, new bool[] { true });
                ZLockOn = new ZMove("Z-Lock-On", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZLovelyKiss = new ZMove("Z-Lovely Kiss", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZLuckyChant = new ZMove("Z-Lucky Chant", 0, new Effect[] { StatChanges.PositiveStatChanges.EvasUp1 }, new bool[] { true });
                ZMeanLook = new ZMove("Z-Mean Look", 0, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp1 }, new bool[] { true });
                ZMilkDrink = new ZMove("Z-Milk Drink", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZMimic = new ZMove("Z-Mimic", 0, new Effect[] { StatChanges.PositiveStatChanges.AccUp1 }, new bool[] { true });
                ZMindReader = new ZMove("Z-Mind Reader", 0, new Effect[] { StatChanges.PositiveStatChanges.SpAtkUp1 }, new bool[] { true });
                ZMinimize = new ZMove("Z-Minimize", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZMorningSun = new ZMove("Z-Morning Sun", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                #endregion
                #region N-Z
                ZNobleRoar = new ZMove("Z-Noble Roar", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                ZOdorSleuth = new ZMove("Z-Odor Sleuth", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1 }, new bool[] { true });
                ZPainSplit = new ZMove("Z-Pain Split", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                ZPerishSong = new ZMove("Z-Perish Song", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZPlayNice = new ZMove("Z-Play Nice", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                ZProtect = new ZMove("Z-Protect", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZPsychUp = new ZMove("Z-PsychUp", 0, new Effect[] { Effects.HealingEffects.HPRestore.FullHPRestore }, new bool[] { true });
                ZRecover = new ZMove("Z-Recover", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZRecycle = new ZMove("Z-Recycle", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp2 }, new bool[] { true });
                ZReflectType = new ZMove("Z-Reflect Type", 0, new Effect[] { StatChanges.PositiveStatChanges.SpAtkUp1 }, new bool[] { true });
                ZRefresh = new ZMove("Z-Refresh", 0, new Effect[] { Effects.HealingEffects.HPRestore.FullHPRestore }, new bool[] { true });
                ZRoar = new ZMove("Z-Roar", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                ZSafeguard = new ZMove("Z-Safeguard", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZScaryFace = new ZMove("Z-Scary Face", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZScreech = new ZMove("Z-Screech", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1 }, new bool[] { true });
                ZSharpen = new ZMove("Z-Sharpen", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1 }, new bool[] { true });
                ZShellSmash = new ZMove("Z-Shell Smash", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZSing = new ZMove("Z-Sing", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZSketch = new ZMove("Z-Sketch", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1, StatChanges.PositiveStatChanges.DefUp1, StatChanges.PositiveStatChanges.SpAtkUp1, StatChanges.PositiveStatChanges.SpDefUp1, StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true, true, true, true, true });
                ZSlackOff = new ZMove("Z-Slack Off", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZSleepTalk = new ZMove("Z-Sleep Talk", 0, new Effect[] { StatChanges.PositiveStatChanges.CritUp1 }, new bool[] { true });
                ZSmokescreen = new ZMove("Z-Smokescreen", 0, new Effect[] { StatChanges.PositiveStatChanges.EvasUp1 }, new bool[] { true });
                ZSoftBoiled = new ZMove("Z-Soft-Boiled", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZSplash = new ZMove("Z-Splash", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp3 }, new bool[] { true });
                ZSpotlight = new ZMove("Z-Spotlight", 0, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp1 }, new bool[] { true });
                ZStockpile = new ZMove("Z-Stockpile", 0, new Effect[] { Effects.HealingEffects.HPRestore.FullHPRestore }, new bool[] { true });
                ZSubstitute = new ZMove("Z-Substitute", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZSupersonic = new ZMove("Z-Supersonic", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZSwagger = new ZMove("Z-Swagger", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZSwallow = new ZMove("Z-Swallow", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZSweetScent = new ZMove("Z-Sweet Scent", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZSwordsDance = new ZMove("Z-Swords Dance", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZTailWhip = new ZMove("Z-Tail Whip", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1 }, new bool[] { true });
                ZTearfulLook = new ZMove("Z-Tearful Look", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                ZTeeterDance = new ZMove("Z-Teeter Dance", 0, new Effect[] { StatChanges.PositiveStatChanges.SpAtkUp1 }, new bool[] { true });
                ZTickle = new ZMove("Z-Tickle", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                ZTransform = new ZMove("Z-Transform", 0, new Effect[] { Effects.HealingEffects.HPRestore.FullHPRestore }, new bool[] { true });
                ZWhirlwind = new ZMove("Z-Whirlwind", 0, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp1 }, new bool[] { true });
                ZWish = new ZMove("Z-Wish", 0, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp1 }, new bool[] { true });
                ZWorkUp = new ZMove("Z-Work Up", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1 }, new bool[] { true });
                ZYawn = new ZMove("Z-Yawn", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                #endregion
                #endregion

                #region Normal Constructor
                #region A-H
                Acupressure = new Move("Acupressure", Type.Normal, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { Effects.HealingEffects.StatAlterations.RandomStatBuffBy2 }, new bool[] { true }, ZAcupressure, 0);
                AfterYou = new Move("After You", Type.Normal, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.ForceAttackFirstNextTurn }, new bool[] { false }, ZAfterYou, 0);
                Assist = new Move("Assist", Type.Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Effects.DoubleBattleEffects.UseRandomPartnerMove }, new bool[] { true }, UniqueZMoves.NO_EFFECT, 0);
                Attract = new Move("Attract", Type.Normal, 0, 1, 15, 'S', new double[] { 1, 1 }, new Effect[] { Flags.ifOppositeGender, Statuses.VolatileStatuses.Infatuated }, new bool[] { false, false }, ZAttract, 0);
                Barrage = new Move("Barrage", Type.Normal, 15, 0.85, 20, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HitsMultipleTimes }, new bool[] { false }, BreakneckBlitz, 0);
                BatonPass = new Move("Baton Pass", Type.Normal, 0, -1, 40, 'S', new double[] { 1, 1 }, new Effect[] { Effects.GeneralEffects.Switchout, Effects.GeneralEffects.TransferStatsToSwitchout }, new bool[] { true, false }, ZBatonPass, 0);
                BellyDrum = new Move("Belly Drum", Type.Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.BellyDrum }, new bool[] { true }, ZBellyDrum, 0);
                Bestow = new Move("Bestow", Type.Normal, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.TransferItem }, new bool[] { false }, ZBestow, 0);
                Bide = new Move("Bide", Type.Normal, 0, -1, 10, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.Bide }, new bool[] { true }, BreakneckBlitz, 0);
                Bind = new Move("Bind", Type.Normal, 15, 85, 20, 'P', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Bound }, new bool[] { false }, BreakneckBlitz, 0);
                Block = new Move("Block", Type.Normal, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.LegHold }, new bool[] { false }, ZBlock, 0);
                BodySlam = new Move("Body Slam", Type.Normal, 85, 1, 15, 'P', new double[] { 0.3 }, new Effect[] { Statuses.BaseStatuses.Paralysis }, new bool[] { false }, new ZMove(BreakneckBlitz, 160), 0);
                Boomburst = new Move("Boomburst", Type.Normal, 140, 1, 10, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HitAllAdjacent }, new bool[] { false }, new ZMove(BreakneckBlitz, 200), 0);
                Camouflage = new Move("Camouflage", Type.Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.Camo }, new bool[] { true }, ZCamouflage, 0);
                Captivate = new Move("Captivate", Type.Normal, 0, 1, 20, 'S', new double[] { 1, 1 }, new Effect[] { Flags.ifOppositeGender, StatChanges.NegativeStatChanges.AtkDwn2 }, new bool[] { false, false }, ZCaptivate, 0);
                Celebrate = new Move("Celebrate", Type.Normal, 0, -1, 40, 'S', null, null, null, ZCelebrate, 0);
                ChipAway = new Move("Chip Away", Type.Normal, 70, 1, 20, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.IgnoreStatChanges }, new bool[] { true }, new ZMove(BreakneckBlitz, 140), 0);
                CometPunch = new Move("Comet Punch", Type.Normal, 10, 0.85, 15, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HitsMultipleTimes }, new bool[] { true }, BreakneckBlitz, 0);
                Confide = new Move("Confide", Type.Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.SpAtkDwn1 }, new bool[] { false }, ZConfide, 0);
                Constrict = new Move("Constrict", Type.Normal, 10, 1, 35, 'P', new double[] { 0.1 }, new Effect[] { StatChanges.NegativeStatChanges.SpdDwn1 }, new bool[] { false }, BreakneckBlitz, 0);
                Conversion = new Move("Conversion", Type.Normal, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.Conv }, new bool[] { true }, ZConversion, 0);
                Conversion2 = new Move("Conversion2", Type.Normal, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.Conv2 }, new bool[] { true }, ZConversion2, 0);
                Copycat = new Move("Copycat", Type.Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.CopyLastMove }, new bool[] { false }, ZCopycat, 0);
                Covet = new Move("Covet", Type.Normal, 60, 1, 25, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.TransferItem }, new bool[] { true }, new ZMove(BreakneckBlitz, 120), 0);
                CrushClaw = new Move("Crush Claw", Type.Normal, 75, 0.95, 10, 'P', new double[] { 0.5 }, new Effect[] { StatChanges.NegativeStatChanges.DefDwn1 }, new bool[] { false }, new ZMove(BreakneckBlitz, 140), 0);
                CrushGrip = new Move("Crush Grip", Type.Normal, 0, 100, 5, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.MoreHPMoreDmg }, new bool[] { false }, new ZMove(BreakneckBlitz, 190), 0);
                Cut = new Move("Cut", Type.Normal, 50, 0.95, 30, 'P', null, null, null, BreakneckBlitz, 0);
                DefenseCurl = new Move("Defense Curl", Type.Normal, 0, -1, 40, 'S', new double[] { 1, 1 }, new Effect[] { StatChanges.PositiveStatChanges.DefUp1, Statuses.VolatileStatuses.DefenseCurl }, new bool[] { true, true }, ZDefenseCurl, 0);
                Disable = new Move("Disable", Type.Normal, 0, 1, 20, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.Disable }, new bool[] { false }, ZDisable, 0);
                DizzyPunch = new Move("Dizzy Punch", Type.Normal, 70, 1, 10, 'P', new double[] { 0.2 }, new Effect[] { Statuses.VolatileStatuses.Confused }, new bool[] { false }, new ZMove(BreakneckBlitz, 140), 0);
                DoubleSlap = new Move("Double Hit", Type.Normal, 35, 0.9, 10, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HitTwiceOneTurn }, new bool[] { false }, BreakneckBlitz, 0);
                DoubleTeam = new Move("Double Team", Type.Normal, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { StatChanges.PositiveStatChanges.EvasUp1 }, new bool[] { true }, ZDoubleTeam, 0);
                DoubleEdge = new Move("Double-Edge", Type.Normal, 120, 1, 15, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Recoil.ThirdDmgDealt }, new bool[] { true }, new ZMove(BreakneckBlitz, 190), 0);
                EchoedVoice = new Move("Echoed Voice", Type.Normal, 40, 1, 15, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.IncrementalDamageMux }, new bool[] { true }, BreakneckBlitz, 0);
                EggBomb = new Move("Egg Bomb", Type.Normal, 100, 0.75, 10, 'P', null, null, null, new ZMove(BreakneckBlitz, 180), 0);
                Encore = new Move("Encore", Type.Normal, 0, 1, 5, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Encore }, new bool[] { true }, ZEncore, 0);
                Endeavor = new Move("Endeavor", Type.Normal, 0, 1, 5, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.ReduceHPToUsers }, new bool[] { false }, new ZMove(BreakneckBlitz, 160), 0);
                Endure = new Move("Endure", Type.Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Bracing }, new bool[] { true }, ZEndure, 3);
                Entrainment = new Move("Entrainment", Type.Normal, 0, 1, 15, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.CopyAbility }, new bool[] { false }, ZEntrainment, 0);
                Explosion = new Move("Explosion", Type.Normal, 250, 1, 5, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.SelfDestruction }, new bool[] { true }, new ZMove(BreakneckBlitz, 200), 0);
                ExtremeSpeed = new Move("Extreme Speed", Type.Normal, 80, 1, 5, 'P', null, null, null, new ZMove(BreakneckBlitz, 160), 2);
                Facade = new Move("Facade", Type.Normal, 70, 1, 20, 'P', new double[] { 1, 1 }, new Effect[] { Flags.ifAfflicted, Effects.GeneralEffects.DoublePower }, new bool[] { true, true }, new ZMove(BreakneckBlitz, 140), 0);
                FakeOut = new Move("Fake Out", Type.Normal, 40, 1, 10, 'P', new double[] { 1, 1 }, new Effect[] { Flags.ifFirstTurn, Statuses.VolatileStatuses.Flinch }, new bool[] { true, false }, BreakneckBlitz, 3);
                FalseSwipe = new Move("False Swipe", Type.Normal, 40, 1, 40, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.FalseSwipe }, new bool[] { false }, BreakneckBlitz, 0);
                Feint = new Move("Feint", Type.Normal, 30, 1, 10, 'P', new double[] { 1, 1 }, new Effect[] { Flags.ifNoProtection, Effects.GeneralEffects.DealsNoDmg }, new bool[] { false, true }, BreakneckBlitz, 2);
                Flail = new Move("Flail", Type.Normal, 0, 1, 15, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.Flail }, new bool[] { true }, new ZMove(BreakneckBlitz, 160), 0);
                Flash = new Move("Flash", Type.Normal, 0, 1, 20, 'S', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.AccDwn1 }, new bool[] { false }, ZFlash, 0);
                FocusEnergy = new Move("Focus Energy", Type.Normal, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { StatChanges.PositiveStatChanges.CritUp2 }, new bool[] { true }, ZFocusEnergy, 0);
                FollowMe = new Move("Follow Me", Type.Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.CenterofAttention }, new bool[] { true }, ZFollowMe, 3);
                Foresight = new Move("Foresight", Type.Normal, 0, -1, 40, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Identified }, new bool[] { false }, ZForesight, 0);
                Frustration = new Move("Frustration", Type.Normal, 0, 1, 20, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.UnfriendlyMoreDamage }, new bool[] { true }, new ZMove(BreakneckBlitz, 160), 0);
                FuryAttack = new Move("Fury Attack", Type.Normal, 15, 0.85, 20, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HitsMultipleTimes }, new bool[] { false }, BreakneckBlitz, 0);
                FurySwipes = new Move("Fury Swipes", Type.Normal, 18, 0.8, 15, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HitsMultipleTimes }, new bool[] { false }, BreakneckBlitz, 0);
                GigaImpact = new Move("Giga Impact", Type.Normal, 150, 0.9, 5, 'P', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Recharging }, new bool[] { true }, new ZMove(BreakneckBlitz, 200), 0);
                Glare = new Move("Glare", Type.Normal, 0, 1, 30, 'S', new double[] { 1 }, new Effect[] { Statuses.BaseStatuses.Paralysis }, new bool[] { false }, ZGlare, 0);
                Growl = new Move("Growl", Type.Normal, 0, 1, 40, 'S', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.AtkDwn1 }, new bool[] { false }, ZGrowl, 0);
                Growth = new Move("Growth", Type.Normal, 0, -1, 40, 'S', new double[] { 1, 1, 1, 1, 1 }, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1, StatChanges.PositiveStatChanges.SpAtkUp1, Flags.isHarshSunlight, StatChanges.PositiveStatChanges.AtkUp1, StatChanges.PositiveStatChanges.SpAtkUp1 }, new bool[] { true, true, true, true, true }, ZGrowth, 0);
                Guillotine = new Move("Guillotine", Type.Normal, -1, -2, 5, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.OHKO }, new bool[] { false }, new ZMove(BreakneckBlitz, 180), 0);
                HappyHour = new Move("Happy Hour", Type.Normal, 0, -1, 30, 'S', null, null, null, ZHappyHour, 0);
                Harden = new Move("Harden", Type.Normal, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true }, ZHarden, 0);
                HeadCharge = new Move("Head Charge", Type.Normal, 120, 1, 15, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Recoil.QuarterDmgDealt }, new bool[] { true }, new ZMove(BreakneckBlitz, 190), 0);
                Headbutt = new Move("Headbutt", Type.Normal, 70, 1, 15, 'P', new double[] { 0.3 }, new Effect[] { Statuses.VolatileStatuses.Flinch }, new bool[] { false }, new ZMove(BreakneckBlitz, 140), 0);
                HealBell = new Move("Heal Bell", Type.Normal, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { Effects.HealingEffects.StatusCures.HealUserPartyStatus }, new bool[] { false }, ZHealBell, 0);
                HelpingHand = new Move("Helping Hand", Type.Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Effects.DoubleBattleEffects.IncreaseTargetDmg50Pcnt }, new bool[] { false }, ZHelpingHand, 5);
                HiddenPower = new Move("Hidden Power", Type.Normal, 60, 1, 15, 'M', new double[] { 1 }, new Effect[] { Effects.RareEffects.HiddenPower }, new bool[] { true }, new ZMove(BreakneckBlitz, 120), 0);
                HoldBack = new Move("Hold Back", Type.Normal, 40, 1, 40, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.FalseSwipe }, new bool[] { false }, BreakneckBlitz, 0);
                HoldHands = new Move("Hold Hands", Type.Normal, 0, -1, 40, 'S', null, null, null, ZHoldHands, 0);
                HornAttack = new Move("Horn Attack", Type.Normal, 65, 1, 25, 'P', null, null, null, new ZMove(BreakneckBlitz, 120), 0);
                HornDrill = new Move("Horn Drill", Type.Normal, 0, 0, 5, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.OHKO }, new bool[] { false }, new ZMove(BreakneckBlitz, 180), 0);
                Howl = new Move("Howl", Type.Normal, 0, -1, 40, 'S', new double[] { 1 }, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1 }, new bool[] { true }, ZHowl, 0);
                HyperBeam = new Move("Hyper Beam", Type.Normal, 150, 0.9, 5, 'M', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Recharging }, new bool[] { true }, new ZMove(BreakneckBlitz, 200), 0);
                HyperFang = new Move("Hyper Fang", Type.Normal, 80, 0.9, 15, 'P', new double[] { 0.1 }, new Effect[] { Statuses.VolatileStatuses.Flinch }, new bool[] { false }, new ZMove(BreakneckBlitz, 160), 0);
                HyperVoice = new Move("Hyper Voice", Type.Normal, 90, 1, 10, 'M', null, null, null, new ZMove(BreakneckBlitz, 175), 0);
                #endregion
                #region I-R
                Judgement = new Move("Judgement", Type.Normal, 100, 1, 10, 'M', new double[] { 1 }, new Effect[] { Effects.RareEffects.Judgement }, new bool[] { false }, new ZMove(BreakneckBlitz, 180), 0);
                LaserFocus = new Move("Laser Focus", Type.Normal, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.GuaranteedCritNextTurn }, new bool[] { true }, ZLaserFocus, 0);
                LastResort = new Move("Last Resort", Type.Normal, 140, 100, 5, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.LastResort }, new bool[] { false }, new ZMove(BreakneckBlitz, 200), 0);
                Leer = new Move("Leer", Type.Normal, 0, 1, 30, 'S', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.DefDwn1 }, new bool[] { false }, ZLeer, 0);
                LockOn = new Move("Lock-On", Type.Normal, 0, 1, 30, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.TakingAim }, new bool[] { true }, ZLockOn, 0);
                LovelyKiss = new Move("Lovely Kiss", Type.Normal, 0, 0.75, 10, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Confused }, new bool[] { false }, ZLovelyKiss, 0);
                LuckyChant = new Move("Lucky Chant", Type.Normal, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.NoCrits5Turns }, new bool[] { false }, ZLuckyChant, 0);
                MeFirst = new Move("Me First", Type.Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.MeFirst }, new bool[] { false }, ZMeFirst, 0);
                MeanLook = new Move("Mean Look", Type.Normal, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.LegHold }, new bool[] { false }, ZMeanLook, 0);
                MegaKick = new Move("Mega Kick", Type.Normal, 120, 0.75, 5, 'P', null, null, null, new ZMove(BreakneckBlitz, 190), 0);
                MegaPunch = new Move("Mega Punch", Type.Normal, 80, 0.85, 20, 'P', null, null, null, new ZMove(BreakneckBlitz, 160), 0);
                Metronome = new Move("Metronome", Type.Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.Metronome }, new bool[] { true }, UniqueZMoves.NO_EFFECT, 0);
                MilkDrink = new Move("Milk Drink", Type.Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.HealingEffects.HPRestore.HalfHPRestore }, new bool[] { true }, ZMilkDrink, 0);
                Mimic = new Move("Mimic", Type.Normal, 0, -1, 10, 'S', new double[] { 1, 1 }, new Effect[] { Effects.GeneralEffects.CopyLastMove, Effects.RareEffects.RetainCopiedMove }, new bool[] { false, true }, ZMimic, 0);
                MindReader = new Move("Mind Reader", Type.Normal, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.TakingAim }, new bool[] { true }, ZMindReader, 0);
                Minimize = new Move("Minimize", Type.Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { StatChanges.PositiveStatChanges.EvasUp2 }, new bool[] { true }, ZMinimize, 0);
                MorningSun = new Move("Morning Sun", Type.Normal, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.MorningSun }, new bool[] { false }, ZMorningSun, 0);
                MultiAttack = new Move("Multi-Attack", Type.Normal, 90, 1, 10, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.TypeMatchesUser }, new bool[] { false }, new ZMove(BreakneckBlitz, 185), 0);
                NaturalGift = new Move("Natural Gift", Type.Normal, 0, 1, 15, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.NatGift }, new bool[] { true }, new ZMove(BreakneckBlitz, 160), 0);
                NaturePower = new Move("Nature Power", Type.Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.NaturePower }, new bool[] { false }, UniqueZMoves.NO_EFFECT, 0);
                NobleRoar = new Move("Noble Roar", Type.Normal, 0, 1, 30, 'S', new double[] { 1, 1 }, new Effect[] { StatChanges.NegativeStatChanges.AtkDwn1, StatChanges.NegativeStatChanges.SpAtkDwn1 }, new bool[] { false, false }, ZNobleRoar, 0);
                OdorSleuth = new Move("Odor Sleuth", Type.Normal, 0, -1, 40, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Identified }, new bool[] { false }, ZOdorSleuth, 0);
                PainSplit = new Move("Pain Split", Type.Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Split.HP }, new bool[] { true }, ZPainSplit, 0);
                PayDay = new Move("Pay Day", Type.Normal, 40, 1, 20, 'P', null, null, null, BreakneckBlitz, 0);
                PerishSong = new Move("Perish Song", Type.Normal, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.PerishSong }, new bool[] { false }, ZPerishSong, 0);
                PlayNice = new Move("Play Nice", Type.Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.AtkDwn1 }, new bool[] { false }, ZPlayNice, 0);
                Pound = new Move("Pound", Type.Normal, 40, 1, 35, 'P', null, null, null, BreakneckBlitz, 0);
                Present = new Move("Present", Type.Normal, 0, 0.9, 15, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.Present }, new bool[] { false }, BreakneckBlitz, 0);
                Protect = new Move("Protect", Type.Normal, 0, -1, 10, 'S', new double[] { 1, 1, 1 }, new Effect[] { Statuses.VolatileStatuses.Protection, Flags.SameMoveLastTurn, Effects.GeneralEffects.DecreaseAcc50Pcnt }, new bool[] { true, true, true }, ZProtect, 3);
                PsychUp = new Move("Psych Up", Type.Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.CopyStatChanges }, new bool[] { false }, ZPsychUp, 0);
                QuickAttack = new Move("Quick Attack", Type.Normal, 40, 1, 30, 'P', null, null, null, BreakneckBlitz, 1);
                Rage = new Move("Rage", Type.Normal, 20, 1, 20, 'P', new double[] { 1, 1 }, new Effect[] { Flags.isHitBeforeNextMove, StatChanges.PositiveStatChanges.AtkUp1 }, new bool[] { true, true }, BreakneckBlitz, 0);
                RapidSpin = new Move("Rapid Spin", Type.Normal, 20, 1, 40, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.ClearTraps }, new bool[] { true }, BreakneckBlitz, 0);
                RazorWind = new Move("Razor Wind", Type.Normal, 80, 100, 10, 'M', new double[] { 1, 1 }, new Effect[] { Statuses.VolatileStatuses.WhippingUpWhirlwind, Effects.GeneralEffects.HighCrit }, new bool[] { true, true }, new ZMove(BreakneckBlitz, 160), 0);
                Recover = new Move("Recover", Type.Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.HealingEffects.HPRestore.HalfHPRestore }, new bool[] { true }, ZRecover, 0);
                Recycle = new Move("Recycle", Type.Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.Recycle }, new bool[] { true }, ZRecycle, 0);
                ReflectType = new Move("Reflect Type", Type.Normal, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.ReflectType }, new bool[] { true }, ZReflectType, 0);
                Refresh = new Move("Refresh", Type.Normal, 0, -1, 20, 'S', new double[] { 1, 1, 1 }, new Effect[] { Effects.HealingEffects.StatusCures.CureParalysis, Effects.HealingEffects.StatusCures.CurePoison, Effects.HealingEffects.StatusCures.CureBurn }, new bool[] { true, true, true }, ZRefresh, 0);
                RelicSong = new Move("Relic Song", Type.Normal, 75, 1, 10, 'M', new double[] { 0.1 }, new Effect[] { Statuses.BaseStatuses.Sleep }, new bool[] { false }, new ZMove(BreakneckBlitz, 140), 0);
                Retaliate = new Move("Retaliate", Type.Normal, 70, 1, 5, 'P', new double[] { 1, 1 }, new Effect[] { Flags.AllyDiedThisTurn, Effects.GeneralEffects.DoublePower }, new bool[] { true, true }, new ZMove(BreakneckBlitz, 140), 0);
                Return = new Move("Return", Type.Normal, 0, 1, 20, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.FriendlyMoreDmg }, new bool[] { true }, new ZMove(BreakneckBlitz, 160), 0);
                RevelationDance = new Move("Revelation Dance", Type.Normal, 90, 1, 15, 'M', new double[] { 1 }, new Effect[] { Effects.RareEffects.OricorioForme }, new bool[] { true }, new ZMove(BreakneckBlitz, 175), 0);
                Roar = new Move("Roar", Type.Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Switchout }, new bool[] { false }, ZRoar, -6);
                RockClimb = new Move("Rock Climb", Type.Normal, 90, 0.85, 20, 'P', new double[] { 0.2 }, new Effect[] { Statuses.VolatileStatuses.Confused }, new bool[] { false }, new ZMove(BreakneckBlitz, 175), 0);
                Round = new Move("Round", Type.Normal, 60, 1, 15, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.MoveUsedByAllyThisTurn }, new bool[] { true }, new ZMove(BreakneckBlitz, 120), 0);
                #endregion
                #region S-Z
                Safeguard = new Move("Safeguard", Type.Normal, 0, -1, 25, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Safeguard }, new bool[] { true }, ZSafeguard, 0);
                ScaryFace = new Move("Scary Face", Type.Normal, 0, 1, 10, 'S', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.SpdDwn2 }, new bool[] { false }, ZScaryFace, 0);
                Scratch = new Move("Scratch", Type.Normal, 40, 1, 35, 'P', null, null, null, BreakneckBlitz, 0);
                Screech = new Move("Screech", Type.Normal, 0, 0.85, 40, 'S', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.DefDwn2 }, new bool[] { false }, ZScreech, 0);
                SecretPower = new Move("Secret Power", Type.Normal, 70, 1, 20, 'P', new double[] { 0.3 }, new Effect[] { Effects.RareEffects.SecretPwr }, new bool[] { false }, new ZMove(BreakneckBlitz, 140), 0);
                SelfDestruct = new Move("Self-Destruct", Type.Normal, 200, 1, 5, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.SelfDestruction }, new bool[] { false }, new ZMove(BreakneckBlitz, 200), 0);
                Sharpen = new Move("Sharpen", Type.Normal, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1 }, new bool[] { true }, ZSharpen, 0);
                ShellSmash = new Move("Shell Smash", Type.Normal, 0, -1, 15, 'S', new double[] { 1, 1, 1, 1, 1 }, new Effect[] { StatChanges.PositiveStatChanges.AtkUp2, StatChanges.PositiveStatChanges.SpAtkUp2, StatChanges.PositiveStatChanges.SpdUp2, StatChanges.NegativeStatChanges.DefDwn1, StatChanges.NegativeStatChanges.SpDefDwn1 }, new bool[] { true, true, true, true, true }, ZShellSmash, 0);
                SimpleBeam = new Move("Simple Beam", Type.Normal, 0, 1, 15, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.Simple }, new bool[] { false }, ZSimpleBeam, 0);
                Sing = new Move("Sing", Type.Normal, 0, 0.55, 15, 'S', new double[] { 1 }, new Effect[] { Statuses.BaseStatuses.Sleep }, new bool[] { false }, ZSing, 0);
                Sketch = new Move("Sketch", Type.Normal, 0, -1, 1, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.Sketch }, new bool[] { true }, ZSketch, 0);
                SkullBash = new Move("Skull Bash", Type.Normal, 130, 1, 10, 'P', new double[] { 1, 1 }, new Effect[] { StatChanges.PositiveStatChanges.DefUp1, Statuses.VolatileStatuses.Charging }, new bool[] { true, true }, new ZMove(BreakneckBlitz, 195), 0);
                SlackOff = new Move("Slack Off", Type.Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.HealingEffects.HPRestore.HalfHPRestore }, new bool[] { true }, ZSlackOff, 0);
                Slam = new Move("Slam", Type.Normal, 80, 0.75, 20, 'P', null, null, null, new ZMove(BreakneckBlitz, 160), 0);
                Slash = new Move("Slash", Type.Normal, 70, 1, 20, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HighCrit }, new bool[] { true }, new ZMove(BreakneckBlitz, 140), 0);
                SleepTalk = new Move("Sleep Talk", Type.Normal, 0, -1, 10, 'S', new double[] { 1, 1 }, new Effect[] { Flags.isAsleep, Effects.GeneralEffects.UseRandomMove }, new bool[] { true, true }, ZSleepTalk, 0);
                SmellingSalts = new Move("Smelling Salts", Type.Normal, 70, 1, 10, 'P', new double[] { 1, 1 }, new Effect[] { Flags.isParalyzed, Effects.GeneralEffects.DoublePower, Effects.HealingEffects.StatusCures.CureParalysis }, new bool[] { false, true, false }, new ZMove(BreakneckBlitz, 140), 0);
                Smokescreen = new Move("Smokescreen", Type.Normal, 0, 1, 20, 'S', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.AccDwn1 }, new bool[] { false }, ZSmokescreen, 0);
                Snore = new Move("Snore", Type.Normal, 50, 1, 15, 'M', new double[] { 1, 0.3 }, new Effect[] { Flags.isAsleep, Statuses.VolatileStatuses.Flinch }, new bool[] { true, false }, BreakneckBlitz, 0);
                SoftBoiled = new Move("Soft-Boiled", Type.Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.HealingEffects.HPRestore.HalfHPRestore }, new bool[] { true }, ZSoftBoiled, 0);
                SonicBoom = new Move("Sonic Boom", Type.Normal, 20, 0.9, 20, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.DoBPInDmg }, new bool[] { false }, BreakneckBlitz, 0);
                SpikeCannon = new Move("Spike Cannon", Type.Normal, 20, 1, 15, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HitsMultipleTimes }, new bool[] { false }, BreakneckBlitz, 0);
                SpitUp = new Move("Spit Up", Type.Normal, 0, 1, 10, 'M', new double[] { 1 }, new Effect[] { Effects.RareEffects.SpitUp }, new bool[] { true }, BreakneckBlitz, 0);
                Splash = new Move("Splash", Type.Normal, 0, -1, 40, 'S', null, null, null, ZSplash, 0);
                Spotlight = new Move("Spotlight", Type.Normal, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.CenterofAttention }, new bool[] { false }, ZSpotlight, 0);
                Stockpile = new Move("Stockpile", Type.Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.Stockpile }, new bool[] { true }, ZStockpile, 0);
                Stomp = new Move("Stomp", Type.Normal, 65, 1, 20, 'P', new double[] { 0.3 }, new Effect[] { Statuses.VolatileStatuses.Flinch }, new bool[] { false }, new ZMove(BreakneckBlitz, 120), 0);
                Strength = new Move("Strength", Type.Normal, 80, 1, 15, 'P', null, null, null, new ZMove(BreakneckBlitz, 160), 0);
                Struggle = new Move("Struggle", Type.Typeless, 50, -1, -1, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Recoil.QuarterMaxHP }, new bool[] { true }, UniqueZMoves.NO_EFFECT, 0);
                Substitute = new Move("Substitute", Type.Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Substitute }, new bool[] { true }, ZSubstitute, 0);
                SuperFang = new Move("Super Fang", Type.Normal, 0, 0.9, 10, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.DoesHalfTargetHPDmg }, new bool[] { false }, BreakneckBlitz, 0);
                Supersonic = new Move("Supersonic", Type.Normal, 0, 0.55, 20, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Confused }, new bool[] { false }, ZSupersonic, 0);
                Swagger = new Move("Swagger", Type.Normal, 0, 0.85, 15, 'S', new double[] { 1, 1 }, new Effect[] { Statuses.VolatileStatuses.Confused, StatChanges.PositiveStatChanges.AtkUp2 }, new bool[] { false, false }, ZSwagger, 0);
                Swallow = new Move("Swallow", Type.Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.Swallow }, new bool[] { true }, ZSwallow, 0);
                SweetScent = new Move("Sweet Scent", Type.Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.EvasDwn1 }, new bool[] { false }, ZSweetScent, 0);
                Swift = new Move("Swift", Type.Normal, 60, -1, 20, 'P', null, null, null, new ZMove(BreakneckBlitz, 120), 0);
                SwordsDance = new Move("Swords Dance", Type.Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { StatChanges.PositiveStatChanges.AtkUp2 }, new bool[] { true }, ZSwordsDance, 0);
                Tackle = new Move("Tackle", Type.Normal, 40, 1, 35, 'P', null, null, null, BreakneckBlitz, 0);
                TailSlap = new Move("Tail Slap", Type.Normal, 25, 0.85, 10, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HitsMultipleTimes }, new bool[] { false }, new ZMove(BreakneckBlitz, 140), 0);
                TailWhip = new Move("Tail Whip", Type.Normal, 0, 1, 30, 'S', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.DefDwn1 }, new bool[] { false }, ZTailWhip, 0);
                TakeDown = new Move("Take Down", Type.Normal, 90, 0.85, 20, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Recoil.QuarterDmgDealt }, new bool[] { true }, new ZMove(BreakneckBlitz, 175), 0);
                TearfulLook = new Move("Tearful Look", Type.Normal, 0, -1, 20, 'S', new double[] { 1, 1 }, new Effect[] { StatChanges.NegativeStatChanges.AtkDwn1, StatChanges.NegativeStatChanges.SpAtkDwn1 }, new bool[] { false, false }, ZTearfulLook, 0);
                TechnoBlast = new Move("Techno Blast", Type.Normal, 120, 1, 5, 'M', new double[] { 1 }, new Effect[] { Effects.RareEffects.ChangeTypeToDrive }, new bool[] { true }, new ZMove(BreakneckBlitz, 190), 0);
                TeeterDance = new Move("Teeter Dance", Type.Normal, 0, 1, 20, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.ConfuseAll }, new bool[] { true }, ZTeeterDance, 0);
                Thrash = new Move("Thrash", Type.Normal, 120, 1, 10, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.Thrash }, new bool[] { false }, new ZMove(BreakneckBlitz, 190), 0);
                Tickle = new Move("Tickle", Type.Normal, 0, 1, 20, 'S', new double[] { 1, 1 }, new Effect[] { StatChanges.NegativeStatChanges.AtkDwn1, StatChanges.NegativeStatChanges.DefDwn1 }, new bool[] { false, false }, ZTickle, 0);
                Transform = new Move("Transform", Type.Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.Transform }, new bool[] { true }, ZTransform, 0);
                TriAttack = new Move("Tri Attack", Type.Normal, 80, 1, 10, 'M', new double[] { 0.2 }, new Effect[] { Effects.RareEffects.TriAttack }, new bool[] { false }, new ZMove(BreakneckBlitz, 160), 0);
                TrumpCard = new Move("Trump Card", Type.Normal, 0, -1, 5, 'M', new double[] { 1 }, new Effect[] { Effects.RareEffects.TrumpCard }, new bool[] { false }, new ZMove(BreakneckBlitz, 160), 0);
                Uproar = new Move("Uproar", Type.Normal, 90, 1, 10, 'M', new double[] { 1, 1 }, new Effect[] { Effects.GeneralEffects.Repeat3Times, Effects.GeneralEffects.PreventAllSleep }, new bool[] { false, false }, new ZMove(BreakneckBlitz, 175), 0);
                ViceGrip = new Move("Vice Grip", Type.Normal, 55, 1, 30, 'P', null, null, null, BreakneckBlitz, 0);
                WeatherBall = new Move("Weather Ball", Type.Normal, 50, 1, 10, 'M', new double[] { 1, 1, 1 }, new Effect[] { Effects.RareEffects.ChangeTypeToWeather, Flags.isActiveWeather, Effects.GeneralEffects.DoublePower }, new bool[] { true, true, true }, new ZMove(BreakneckBlitz, 160), 0);
                Whirlwind = new Move("Whirlwind", Type.Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Switchout }, new bool[] { false }, ZWhirlwind, -6);
                Wish = new Move("Wish", Type.Normal, 0, -1, 10, 'S', new double[] { 1, 1 }, new Effect[] { Effects.GeneralEffects.Wait.OneTurn, Effects.HealingEffects.HPRestore.HalfHPRestore }, new bool[] { true, true }, ZWish, 0);
                WorkUp = new Move("Work Up", Type.Normal, 0, -1, 30, 'S', new double[] { 1, 1 }, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1, StatChanges.PositiveStatChanges.SpAtkUp1 }, new bool[] { true, true }, ZWorkUp, 0);
                Wrap = new Move("Wrap", Type.Normal, 15, 0.9, 20, 'P', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Bound }, new bool[] { false }, BreakneckBlitz, 0);
                WringOut = new Move("Wring Out", Type.Normal, 0, 1, 5, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.MoreHPMoreDmg }, new bool[] { false }, new ZMove(BreakneckBlitz, 190), 0);
                Yawn = new Move("Yawn", Type.Normal, 0, -1, 10, 'S', new double[] { 1, 1 }, new Effect[] { Effects.GeneralEffects.Wait.OneTurn, Statuses.BaseStatuses.Sleep }, new bool[] { true, false }, ZYawn, 0);
                #endregion
                #endregion
            }
            #endregion
        }
        #endregion

        #region Fire
        /// <summary>
        /// All Fire moves
        /// </summary>
        public static class Fire
        {
            #region Fire Z-Moves
            public static ZMove InfernoOverdrive;
            public static ZMove ZSunnyDay;
            public static ZMove ZWillOWisp;
            #endregion

            #region Fire Moves
            public static Move BlastBurn;
            public static Move BlazeKick;
            public static Move BlueFlare;
            public static Move BurnUp;
            public static Move Ember;
            public static Move Eruption;
            public static Move FieryDance;
            public static Move FireBlast;
            public static Move FireFang;
            public static Move FireLash;
            public static Move FirePledge;
            public static Move FirePunch;
            public static Move FireSpin;
            public static Move FlameBurst;
            public static Move FlameCharge;
            public static Move FlameWheel;
            public static Move Flamethrower;
            public static Move FlareBlitz;
            public static Move FusionFlare;
            public static Move HeatCrash;
            public static Move HeatWave;
            public static Move Incinerate;
            public static Move Inferno;
            public static Move LavaPlume;
            public static Move MagmaStorm;
            public static Move MysticalFire;
            public static Move Overheat;
            public static Move SacredFire;
            public static Move SearingShot;
            public static Move ShellTrap;
            public static Move SunnyDay;
            public static Move VCreate;
            public static Move WillOWisp;
            #endregion

            #region Fire Constructor
            static Fire()
            {
                #region Z-Fire Constructor
                InfernoOverdrive = new ZMove("Inferno Overdrive", 100, null, null);
                ZSunnyDay = new ZMove("Z-Sunny Day", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZWillOWisp = new ZMove("Z-Will-O-Wisp", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1 }, new bool[] { true });
                #endregion

                #region Fire Constructor
                BlastBurn = new Move("Blast Burn", Type.Fire, 150, 0.9, 5, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Recharging }, new bool[] { true }, new ZMove(InfernoOverdrive, 200), 0);
                BlazeKick = new Move("Blaze Kick", Type.Fire, 85, 0.9, 10, 'P', new double[] { 1, 0.1 }, new Effect[] { Effects.GeneralEffects.HighCrit, Statuses.BaseStatuses.Burn }, new bool[] { true, false }, new ZMove(InfernoOverdrive, 160), 0);
                BlueFlare = new Move("Blue Flare", Type.Fire, 130, 0.85, 5, 'M', new double[] { 0.2 }, new Effect[] { Statuses.BaseStatuses.Burn }, new bool[] { false }, new ZMove(InfernoOverdrive, 195), 0);
                BurnUp = new Move("Burn Up", Type.Fire, 130, 1, 5, 'M', new double[] { 1 }, new Effect[] { Effects.RareEffects.BurnUp }, new bool[] { true }, new ZMove(InfernoOverdrive, 195), 0);
                Ember = new Move("Ember", Type.Fire, 40, 1, 25, 'M', new double[] { 0.1 }, new Effect[] { Statuses.BaseStatuses.Burn }, new bool[] { false }, InfernoOverdrive, 0);
                Eruption = new Move("Eruption", Type.Fire, 0, 1, 5, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.EruptionSpout }, new bool[] { false }, new ZMove(InfernoOverdrive, 200), 0);
                FieryDance = new Move("Fiery Dance", Type.Fire, 80, 1, 10, 'M', new double[] { 0.5 }, new Effect[] { StatChanges.PositiveStatChanges.SpAtkUp1 }, new bool[] { true }, new ZMove(InfernoOverdrive, 160), 0);
                FireBlast = new Move("Fire Blast", Type.Fire, 110, 0.85, 5, 'M', new double[] { 0.1 }, new Effect[] { Statuses.BaseStatuses.Burn }, new bool[] { false }, new ZMove(InfernoOverdrive, 185), 0);
                FireFang = new Move("Fire Fang", Type.Fire, 65, 0.95, 15, 'P', new double[] { 0.1, 0.1 }, new Effect[] { Statuses.BaseStatuses.Burn, Statuses.VolatileStatuses.Flinch }, new bool[] { false, false }, new ZMove(InfernoOverdrive, 120), 0);
                FireLash = new Move("Fire Lash", Type.Fire, 80, 1, 15, 'P', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.DefDwn1 }, new bool[] { false }, new ZMove(InfernoOverdrive, 160), 0);
                FirePledge = new Move("Fire Pledge", Type.Fire, 80, 1, 10, 'M', new double[] { 1 }, new Effect[] { Effects.RareEffects.Pledges }, new bool[] { true }, new ZMove(InfernoOverdrive, 160), 0);
                FirePunch = new Move("Fire Punch", Type.Fire, 75, 1, 15, 'P', new double[] { 0.1 }, new Effect[] { Statuses.BaseStatuses.Burn }, new bool[] { false }, new ZMove(InfernoOverdrive, 140), 0);
                FireSpin = new Move("Fire Spin", Type.Fire, 35, 0.85, 15, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HitsMultipleTimes }, new bool[] { false }, InfernoOverdrive, 0);
                FlameBurst = new Move("Flame Burst", Type.Fire, 70, 1, 15, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.SplashDmg }, new bool[] { true }, new ZMove(InfernoOverdrive, 140), 0);
                FlameCharge = new Move("Flame Charge", Type.Fire, 50, 1, 20, 'P', new double[] { 1 }, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true }, InfernoOverdrive, 0);
                FlameWheel = new Move("Flame Wheel", Type.Fire, 60, 1, 25, 'P', new double[] { 0.1 }, new Effect[] { Statuses.BaseStatuses.Burn }, new bool[] { false }, new ZMove(InfernoOverdrive, 120), 0);
                Flamethrower = new Move("Flamethrower", Type.Fire, 90, 1, 15, 'M', new double[] { 0.1 }, new Effect[] { Statuses.BaseStatuses.Burn }, new bool[] { false }, new ZMove(InfernoOverdrive, 175), 0);
                FlareBlitz = new Move("Flare Blitz", Type.Fire, 120, 1, 15, 'P', new double[] { 1, 0.1 }, new Effect[] { Effects.GeneralEffects.Recoil.ThirdDmgDealt, Statuses.BaseStatuses.Burn }, new bool[] { true, false }, new ZMove(InfernoOverdrive, 190), 0);
                FusionFlare = new Move("Fusion Flare", Type.Fire, 100, 1, 5, 'M', new double[] { 1, 1 }, new Effect[] { Flags.FusionBolt, Effects.GeneralEffects.DoublePower }, new bool[] { true, true }, new ZMove(InfernoOverdrive, 180), 0);
                HeatCrash = new Move("Heat Crash", Type.Fire, 0, 1, 10, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HeavierMoreDmg }, new bool[] { false }, new ZMove(InfernoOverdrive, 160), 0);
                HeatWave = new Move("Heat Wave", Type.Fire, 95, 0.9, 10, 'M', new double[] { 0.1 }, new Effect[] { Statuses.BaseStatuses.Burn }, new bool[] { false }, new ZMove(InfernoOverdrive, 175), 0);
                Incinerate = new Move("Incinerate", Type.Fire, 60, 1, 15, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.DestroyHeldBerry }, new bool[] { false }, new ZMove(InfernoOverdrive, 120), 0);
                Inferno = new Move("Inferno", Type.Fire, 100, 0.5, 5, 'M', new double[] { 1 }, new Effect[] { Statuses.BaseStatuses.Burn }, new bool[] { false }, new ZMove(InfernoOverdrive, 180), 0);
                LavaPlume = new Move("Lava Plume", Type.Fire, 80, 1, 15, 'M', new double[] { 0.3 }, new Effect[] { Statuses.BaseStatuses.Burn }, new bool[] { false }, new ZMove(InfernoOverdrive, 160), 0);
                MagmaStorm = new Move("Magma Storm", Type.Fire, 120, 0.75, 5, 'M', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Bound }, new bool[] { false }, new ZMove(InfernoOverdrive, 180), 0);
                MysticalFire = new Move("Mystical Fire", Type.Fire, 75, 1, 10, 'M', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.SpAtkDwn1 }, new bool[] { false }, new ZMove(InfernoOverdrive, 140), 0);
                Overheat = new Move("Overheat", Type.Fire, 130, 0.9, 5, 'M', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.SpAtkDwn2 }, new bool[] { true }, new ZMove(InfernoOverdrive, 195), 0);
                SacredFire = new Move("Sacred Fire", Type.Fire, 100, 0.95, 5, 'P', new double[] { 0.5 }, new Effect[] { Statuses.BaseStatuses.Burn }, new bool[] { false }, new ZMove(InfernoOverdrive, 180), 0);
                SearingShot = new Move("Searing Shot", Type.Fire, 100, 1, 5, 'M', new double[] { 0.3 }, new Effect[] { Statuses.BaseStatuses.Burn }, new bool[] { false }, new ZMove(InfernoOverdrive, 180), 0);
                ShellTrap = new Move("Shell Trap", Type.Fire, 150, 1, 5, 'M', new double[] { 1 }, new Effect[] { Effects.RareEffects.ShellTrap }, new bool[] { false }, new ZMove(InfernoOverdrive, 200), -3);
                SunnyDay = new Move("Sunny Day", Type.Fire, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { Weather.HarshSunlight }, new bool[] { true }, ZSunnyDay, 0);
                VCreate = new Move("V-create", Type.Fire, 180, 0.95, 5, 'P', new double[] { 1, 1, 1 }, new Effect[] { StatChanges.NegativeStatChanges.DefDwn1, StatChanges.NegativeStatChanges.SpDefDwn1, StatChanges.NegativeStatChanges.SpdDwn1 }, new bool[] { true, true, true }, new ZMove(InfernoOverdrive, 220), 0);
                WillOWisp = new Move("Will-O-Wisp", Type.Fire, 0, 0.85, 15, 'S', new double[] { 1 }, new Effect[] { Statuses.BaseStatuses.Burn }, new bool[] { false }, ZWillOWisp, 0);
                #endregion
            }
            #endregion
        }
        #endregion

        #region Water
        /// <summary>
        /// All Water moves
        /// </summary>
        public static class Water
        {
            #region Water Z-Moves
            public static ZMove HydroVortex;
            public static ZMove ZAquaRing;
            public static ZMove ZRainDance;
            public static ZMove ZSoak;
            public static ZMove ZWaterSport;
            public static ZMove ZWithdraw;
            #endregion

            #region Water Moves
            public static Move AquaJet;
            public static Move AquaRing;
            public static Move AquaTail;
            public static Move Brine;
            public static Move Bubble;
            public static Move BubbleBeam;
            public static Move Clamp;
            public static Move Crabhammer;
            public static Move Dive;
            public static Move HydroCannon;
            public static Move HydroPump;
            public static Move Liquidation;
            public static Move MuddyWater;
            public static Move Octazooka;
            public static Move OriginPulse;
            public static Move RainDance;
            public static Move RazorShell;
            public static Move Scald;
            public static Move Soak;
            public static Move SparklingAria;
            public static Move SteamEruption;
            public static Move Surf;
            public static Move WaterGun;
            public static Move WaterPledge;
            public static Move WaterPulse;
            public static Move WaterShruiken;
            public static Move WaterSport;
            public static Move WaterSpout;
            public static Move Waterfall;
            public static Move Whirlpool;
            public static Move Withdraw;
            #endregion

            #region Water Constructor
            static Water()
            {
                #region Z-Water Constructor
                HydroVortex = new ZMove("Hydro Vortex", 100, null, null);
                ZAquaRing = new ZMove("Z-Aqua Ring", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                ZRainDance = new ZMove("Z-Rain Dance", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZSoak = new ZMove("Z-Soak", 0, new Effect[] { StatChanges.PositiveStatChanges.SpAtkUp1 }, new bool[] { true });
                ZWaterSport = new ZMove("Z-Water Sport", 0, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp1 }, new bool[] { true });
                ZWithdraw = new ZMove("Z-Withdraw", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                #endregion

                #region Water Constructor
                AquaJet = new Move("Aqua Jet", Type.Water, 40, 1, 20, 'P', null, null, null, HydroVortex, 1);
                AquaRing = new Move("Aqua Ring", Type.Water, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.AquaRing }, new bool[] { true }, ZAquaRing, 0);
                AquaTail = new Move("Aqua Tail", Type.Water, 90, 0.9, 10, 'P', null, null, null, new ZMove(HydroVortex, 175), 0);
                Brine = new Move("Brine", Type.Water, 65, 1, 10, 'M', new double[] { 1, 1 }, new Effect[] { Flags.OpponentLessThanHalf, Effects.GeneralEffects.DoublePower }, new bool[] { false, true }, new ZMove(HydroVortex, 120), 0);
                Bubble = new Move("Bubble", Type.Water, 40, 1, 30, 'M', new double[] { 0.1 }, new Effect[] { StatChanges.NegativeStatChanges.SpdDwn1 }, new bool[] { false }, HydroVortex, 0);
                BubbleBeam = new Move("Bubble Beam", Type.Water, 65, 1, 20, 'M', new double[] { 0.1 }, new Effect[] { StatChanges.NegativeStatChanges.SpdDwn1 }, new bool[] { false }, new ZMove(HydroVortex, 120), 0);
                Clamp = new Move("Clamp", Type.Water, 35, 0.85, 10, 'P', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Bound }, new bool[] { false }, HydroVortex, 0);
                Crabhammer = new Move("Crabhammer", Type.Water, 100, 0.9, 10, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HighCrit }, new bool[] { true }, new ZMove(HydroVortex, 180), 0);
                Dive = new Move("Dive", Type.Water, 80, 1, 10, 'P', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.SemiInvulnerable }, new bool[] { true }, new ZMove(HydroVortex, 160), 0);
                HydroCannon = new Move("Hydro Cannon", Type.Water, 150, 0.9, 5, 'M', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Recharging }, new bool[] { true }, new ZMove(HydroVortex, 200), 0);
                HydroPump = new Move("Hydro Pump", Type.Water, 110, 0.8, 5, 'M', null, null, null, new ZMove(HydroVortex, 185), 0);
                Liquidation = new Move("Liquidation", Type.Water, 85, 1, 10, 'P', new double[] { 0.2 }, new Effect[] { StatChanges.NegativeStatChanges.DefDwn1 }, new bool[] { false }, new ZMove(HydroVortex, 160), 0);
                MuddyWater = new Move("Muddy Water", Type.Water, 90, 0.85, 10, 'M', new double[] { 0.3 }, new Effect[] { StatChanges.NegativeStatChanges.AccDwn1 }, new bool[] { false }, new ZMove(HydroVortex, 175), 0);
                Octazooka = new Move("Octazooka", Type.Water, 65, 0.85, 10, 'M', new double[] { 0.5 }, new Effect[] { StatChanges.NegativeStatChanges.AccDwn1 }, new bool[] { false }, new ZMove(HydroVortex, 120), 0);
                RainDance = new Move("Rain Dance", Type.Water, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { Weather.Rain }, new bool[] { true }, ZRainDance, 0);
                RazorShell = new Move("Razor Shell", Type.Water, 75, 0.95, 10, 'P', new double[] { 0.5 }, new Effect[] { StatChanges.NegativeStatChanges.DefDwn1 }, new bool[] { false }, new ZMove(HydroVortex, 140), 0);
                Scald = new Move("Scald", Type.Water, 80, 1, 15, 'M', new double[] { 0.3 }, new Effect[] { Statuses.BaseStatuses.Burn }, new bool[] { false }, new ZMove(HydroVortex, 160), 0);
                Soak = new Move("Soak", Type.Water, 0, 1, 20, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.ChangeTargetType.Water }, new bool[] { false }, ZSoak, 0);
                SparklingAria = new Move("Sparkling Aria", Type.Water, 90, 1, 10, 'M', new double[] { 1 }, new Effect[] { Effects.HealingEffects.StatusCures.CureBurn }, new bool[] { false }, new ZMove(HydroVortex, 175), 0);
                SteamEruption = new Move("Steam Eruption", Type.Water, 110, 0.95, 5, 'M', new double[] { 0.3 }, new Effect[] { Statuses.BaseStatuses.Burn }, new bool[] { false }, new ZMove(HydroVortex, 185), 0);
                Surf = new Move("Surf", Type.Water, 90, 1, 15, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HitAllAdjacent }, new bool[] { true }, new ZMove(HydroVortex, 175), 0);
                WaterGun = new Move("Water Gun", Type.Water, 40, 1, 25, 'M', null, null, null, HydroVortex, 0);
                WaterPledge = new Move("Water Pledge", Type.Water, 80, 100, 10, 'M', new double[] { 1 }, new Effect[] { Effects.RareEffects.Pledges }, new bool[] { false }, new ZMove(HydroVortex, 160), 0);
                WaterPulse = new Move("Water Pulse", Type.Water, 60, 1, 20, 'M', new double[] { 0.2 }, new Effect[] { Statuses.VolatileStatuses.Confused }, new bool[] { false }, new ZMove(HydroVortex, 120), 0);
                WaterShruiken = new Move("Water Shruiken", Type.Water, 15, 1, 20, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HitsMultipleTimes }, new bool[] { false }, HydroVortex, 0);
                WaterSport = new Move("Water Sport", Type.Water, 0, -1, 15, 'S', new double[] { 1, 1 }, new Effect[] { Effects.GeneralEffects.Strengthen.Water, Effects.GeneralEffects.Weaken.Fire }, new bool[] { false, false }, ZWaterSport, 0);
                WaterSpout = new Move("Water Spout", Type.Water, 0, 1, 5, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.EruptionSpout }, new bool[] { false }, new ZMove(HydroVortex, 200), 0);
                Waterfall = new Move("Waterfall", Type.Water, 80, 1, 15, 'P', new double[] { 0.2 }, new Effect[] { Statuses.VolatileStatuses.Flinch }, new bool[] { false }, new ZMove(HydroVortex, 160), 0);
                Whirlpool = new Move("Whirlpool", Type.Water, 35, 0.85, 15, 'M', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Bound }, new bool[] { false }, HydroVortex, 0);
                Withdraw = new Move("Withdraw", Type.Water, 0, -1, 40, 'S', new double[] { 1 }, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true }, ZWithdraw, 0);
                #endregion
            }
            #endregion
        }
        #endregion

        #region Electric
        /// <summary>
        /// All Electric moves
        /// </summary>
        public static class Electric
        {
            #region Electric Z-Moves
            public static ZMove GigavoltHavoc;
            public static ZMove ZCharge;
            public static ZMove ZEerieImpulse;
            public static ZMove ZElectricTerrain;
            public static ZMove ZElectrify;
            public static ZMove ZIonDeluge;
            public static ZMove ZMagnetRise;
            public static ZMove ZMagneticFlux;
            public static ZMove ZThunderWave;
            #endregion

            #region Electric Moves
            public static Move BoltStrike;
            public static Move Charge;
            public static Move ChargeBeam;
            public static Move Discharge;
            public static Move EerieImpulse;
            public static Move ElectricTerrain;
            public static Move Electrify;
            public static Move ElectroBall;
            public static Move Electroweb;
            public static Move FusionBolt;
            public static Move IonDeluge;
            public static Move MagnetRise;
            public static Move MagneticFlux;
            public static Move Nuzzle;
            public static Move ParabolicCharge;
            public static Move ShockWave;
            public static Move Spark;
            public static Move Thunder;
            public static Move ThunderFang;
            public static Move ThunderPunch;
            public static Move ThunderShock;
            public static Move ThunderWave;
            public static Move Thunderbolt;
            public static Move VoltSwitch;
            public static Move VoltTackle;
            public static Move WildCharge;
            public static Move ZapCannon;
            public static Move ZingZap;
            #endregion

            #region Electric Constructor
            static Electric()
            {
                #region Z-Electric Constructor
                GigavoltHavoc = new ZMove("Gigavolt Havoc", 100, null, null);
                ZCharge = new ZMove("Z-Charge", 0, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp1 }, new bool[] { true });
                ZEerieImpulse = new ZMove("Z-Eerie Impulse", 0, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp1 }, new bool[] { true });
                ZElectricTerrain = new ZMove("Z-Electric Terrain", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZElectrify = new ZMove("Z-Electrify", 0, new Effect[] { StatChanges.PositiveStatChanges.SpAtkUp1 }, new bool[] { true });
                ZIonDeluge = new ZMove("Z-Ion Deluge", 0, new Effect[] { StatChanges.PositiveStatChanges.SpAtkUp1 }, new bool[] { true });
                ZMagnetRise = new ZMove("Z-Magnet Rise", 0, new Effect[] { StatChanges.PositiveStatChanges.EvasUp1 }, new bool[] { true });
                ZMagneticFlux = new ZMove("Z-Magnetic Flux", 0, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp1 }, new bool[] { true });
                ZThunderWave = new ZMove("Z-Thunder Wave", 0, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp1 }, new bool[] { true });
                #endregion

                #region Electric Constructor
                BoltStrike = new Move("Bolt Strike", Type.Electric, 130, 0.85, 5, 'P', new double[] { 0.2 }, new Effect[] { Statuses.BaseStatuses.Paralysis }, new bool[] { false }, new ZMove(GigavoltHavoc, 195), 0);
                Charge = new Move("Charge", Type.Electric, 0, -1, 20, 'S', new double[] { 1, 1 }, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp1, Effects.RareEffects.Charge }, new bool[] { true, true }, ZCharge, 0);
                ChargeBeam = new Move("Charge Beam", Type.Electric, 50, 0.9, 10, 'M', new double[] { 0.7 }, new Effect[] { StatChanges.PositiveStatChanges.SpAtkUp1 }, new bool[] { true }, GigavoltHavoc, 0);
                Discharge = new Move("Discharge", Type.Electric, 80, 1, 15, 'M', new double[] { 0.3 }, new Effect[] { Statuses.BaseStatuses.Paralysis }, new bool[] { false }, new ZMove(GigavoltHavoc, 160), 0);
                EerieImpulse = new Move("Eerie Impulse", Type.Electric, 0, 1, 15, 'S', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.SpAtkDwn2 }, new bool[] { false }, ZEerieImpulse, 0);
                ElectricTerrain = new Move("Electric Terrain", Type.Electric, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.Terrain.Electric }, new bool[] { true }, ZElectricTerrain, 0);
                Electrify = new Move("Electrify", Type.Electric, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.Electrify }, new bool[] { false }, ZElectrify, 0);
                ElectroBall = new Move("Electro Ball", Type.Electric, -1, 1, 10, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.MoreSpdMoreDmg }, new bool[] { false }, new ZMove(GigavoltHavoc, 160), 0);
                Electroweb = new Move("Electroweb", Type.Electric, 55, 0.95, 15, 'M', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.SpdDwn1 }, new bool[] { false }, GigavoltHavoc, 0);
                FusionBolt = new Move("Fusion Bolt", Type.Electric, 100, 1, 5, 'P', new double[] { 1, 1 }, new Effect[] { Flags.FusionFlare, Effects.GeneralEffects.DoublePower }, new bool[] { true, true }, new ZMove(GigavoltHavoc, 180), 0);
                IonDeluge = new Move("Ion Deluge", Type.Electric, 0, -1, 25, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.IonDeluge }, new bool[] { true }, ZIonDeluge, 0);
                MagnetRise = new Move("Magnet Rise", Type.Electric, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Raised }, new bool[] { true }, ZMagnetRise, 0);
                MagneticFlux = new Move("Magnetic Flux", Type.Electric, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.MagneticLevitation }, new bool[] { true }, ZMagneticFlux, 0);
                Nuzzle = new Move("Nuzzle", Type.Electric, 20, 1, 20, 'P', new double[] { 1 }, new Effect[] { Statuses.BaseStatuses.Paralysis }, new bool[] { false }, GigavoltHavoc, 0);
                ParabolicCharge = new Move("Parabolic Charge", Type.Electric, 65, 1, 20, 'M', new double[] { 1 }, new Effect[] { Effects.HealingEffects.HPRestore.HealHalfDmgInflicted }, new bool[] { true }, new ZMove(GigavoltHavoc, 120), 0);
                ShockWave = new Move("Shock Wave", Type.Electric, 60, -1, 20, 'M', null, null, null, new ZMove(GigavoltHavoc, 120), 0);
                Spark = new Move("Spark", Type.Electric, 65, 1, 20, 'P', new double[] { 0.3 }, new Effect[] { Statuses.BaseStatuses.Paralysis }, new bool[] { false }, new ZMove(GigavoltHavoc, 120), 0);
                Thunder = new Move("Thunder", Type.Electric, 110, 0.7, 10, 'M', new double[] { 0.3, 1, 1 }, new Effect[] { Statuses.BaseStatuses.Paralysis, Effects.GeneralEffects.Ignore.Fly, Effects.RareEffects.Thunder }, new bool[] { false, true, true }, new ZMove(GigavoltHavoc, 185), 0);
                ThunderFang = new Move("Thunder Fang", Type.Electric, 65, 0.95, 15, 'P', new double[] { 0.1, 0.1 }, new Effect[] { Statuses.BaseStatuses.Paralysis, Statuses.VolatileStatuses.Flinch }, new bool[] { false, false }, new ZMove(GigavoltHavoc, 120), 0);
                ThunderPunch = new Move("Thunder Punch", Type.Electric, 75, 1, 15, 'P', new double[] { 0.1 }, new Effect[] { Statuses.BaseStatuses.Paralysis }, new bool[] { false }, new ZMove(GigavoltHavoc, 140), 0);
                ThunderShock = new Move("Thunder Shock", Type.Electric, 40, 1, 30, 'M', new double[] { 0.1 }, new Effect[] { Statuses.BaseStatuses.Paralysis }, new bool[] { false }, GigavoltHavoc, 0);
                ThunderWave = new Move("Thunder Wave", Type.Electric, 0, 0.9, 20, 'S', new double[] { 1 }, new Effect[] { Statuses.BaseStatuses.Paralysis }, new bool[] { false }, ZThunderWave, 0);
                Thunderbolt = new Move("Thunderbolt", Type.Electric, 90, 1, 15, 'M', new double[] { 0.1 }, new Effect[] { Statuses.BaseStatuses.Paralysis }, new bool[] { false }, new ZMove(GigavoltHavoc, 175), 0);
                VoltSwitch = new Move("Volt Switch", Type.Electric, 70, 1, 20, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Switchout }, new bool[] { true }, new ZMove(GigavoltHavoc, 140), 0);
                VoltTackle = new Move("Volt Tackle", Type.Electric, 120, 1, 15, 'P', new double[] { 1, 0.1 }, new Effect[] { Effects.GeneralEffects.Recoil.ThirdDmgDealt, Statuses.BaseStatuses.Paralysis }, new bool[] { true, false }, new ZMove(GigavoltHavoc, 190), 0);
                WildCharge = new Move("Wild Charge", Type.Electric, 90, 1, 15, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Recoil.QuarterDmgDealt }, new bool[] { true }, new ZMove(GigavoltHavoc, 175), 0);
                ZapCannon = new Move("Zap Cannon", Type.Electric, 120, 0.5, 5, 'M', new double[] { 1 }, new Effect[] { Statuses.BaseStatuses.Paralysis }, new bool[] { false }, new ZMove(GigavoltHavoc, 190), 0);
                ZingZap = new Move("Zing Zap", Type.Electric, 80, 1, 10, 'P', new double[] { 0.3 }, new Effect[] { Statuses.VolatileStatuses.Flinch }, new bool[] { false }, new ZMove(GigavoltHavoc, 160), 0);
                #endregion
            }
            #endregion
        }
        #endregion

        #region Grass
        /// <summary>
        /// All Grass moves
        /// </summary>
        public static class Grass
        {
            #region Grass Z-Moves
            public static ZMove BloomDoom;
            public static ZMove ZAromatherapy;
            public static ZMove ZCottonGuard;
            public static ZMove ZCottonSpore;
            public static ZMove ZForestsCurse;
            public static ZMove ZGrassWhistle;
            public static ZMove ZGrassyTerrain;
            public static ZMove ZIngrain;
            public static ZMove ZLeechSeed;
            public static ZMove ZSleepPowder;
            public static ZMove ZSpikyShield;
            public static ZMove ZSpore;
            public static ZMove ZStrengthSap;
            public static ZMove ZStunSpore;
            public static ZMove ZSynthesis;
            public static ZMove ZWorrySeed;
            #endregion

            #region Grass Moves
            public static Move Absorb;
            public static Move Aromatherapy;
            public static Move BulletSeed;
            public static Move CottonGuard;
            public static Move CottonSpore;
            public static Move EnergyBall;
            public static Move ForestsCurse;
            public static Move FrenzyPlant;
            public static Move GigaDrain;
            public static Move GrassKnot;
            public static Move GrassPledge;
            public static Move GrassWhistle;
            public static Move GrassyTerrain;
            public static Move HornLeech;
            public static Move Ingrain;
            public static Move LeafBlade;
            public static Move LeafStorm;
            public static Move LeafTornado;
            public static Move Leafage;
            public static Move LeechSeed;
            public static Move MagicalLeaf;
            public static Move MegaDrain;
            public static Move NeedleArm;
            public static Move PetalBLizzard;
            public static Move PetalDance;
            public static Move PowerWhip;
            public static Move RazorLeaf;
            public static Move SeedBomb;
            public static Move SeedFlare;
            public static Move SleepPowder;
            public static Move SolarBeam;
            public static Move SolarBlade;
            public static Move SpikyShield;
            public static Move Spore;
            public static Move StrengthSap;
            public static Move StunSpore;
            public static Move Synthesis;
            public static Move TropKick;
            public static Move VineWhip;
            public static Move WoodHammer;
            public static Move WorrySeed;
            #endregion

            #region Grass Constructor
            static Grass()
            {
                #region Z-Grass Constructor
                BloomDoom = new ZMove("Bloom Doom", 100, null, null);
                ZAromatherapy = new ZMove("Z-Aromatherapy", 0, new Effect[] { Effects.HealingEffects.HPRestore.FullHPRestore }, new bool[] { true });
                ZCottonGuard = new ZMove("Z-Cotton Guard", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZCottonSpore = new ZMove("Z-Cotton Spore", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZForestsCurse = new ZMove("Z-Forest's Curse", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1, StatChanges.PositiveStatChanges.DefUp1, StatChanges.PositiveStatChanges.SpAtkUp1, StatChanges.PositiveStatChanges.SpDefUp1, StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true, true, true, true, true });
                ZGrassWhistle = new ZMove("Z-Grass Whistle", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZGrassyTerrain = new ZMove("Z-Grassy Terrain", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                ZIngrain = new ZMove("Z-Ingrain", 0, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp1 }, new bool[] { true });
                ZLeechSeed = new ZMove("Z-Leech Seed", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZSleepPowder = new ZMove("Z-Sleep Powder", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZSpikyShield = new ZMove("Z-Spiky Shield", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                ZSpore = new ZMove("Z-Spore", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZStrengthSap = new ZMove("Z-Strengthh Sap", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                ZStunSpore = new ZMove("Z-Stun Spore", 0, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp1 }, new bool[] { true });
                ZSynthesis = new ZMove("Z-Synthesis", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZWorrySeed = new ZMove("Z-Worry Seed", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                #endregion

                #region Grass Constructor
                Absorb = new Move("Absorb", Type.Grass, 20, 1, 25, 'M', new double[] { 1 }, new Effect[] { Effects.HealingEffects.HPRestore.HealHalfDmgInflicted }, new bool[] { true }, BloomDoom, 0);
                Aromatherapy = new Move("Aromatherapy", Type.Grass, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { Effects.HealingEffects.StatusCures.HealUserPartyStatus }, new bool[] { true }, ZAromatherapy, 0);
                BulletSeed = new Move("Bullet Seed", Type.Grass, 25, 1, 30, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HitsMultipleTimes }, new bool[] { false }, new ZMove(BloomDoom, 140), 0);
                CottonGuard = new Move("Cotton Guard", Type.Grass, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { StatChanges.PositiveStatChanges.DefUp3 }, new bool[] { true }, ZCottonGuard, 0);
                CottonSpore = new Move("Cotton Spore", Type.Grass, 0, 1, 40, 'S', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.SpdDwn2 }, new bool[] { false }, ZCottonSpore, 0);
                EnergyBall = new Move("Energy Ball", Type.Grass, 90, 1, 10, 'M', new double[] { 0.1 }, new Effect[] { StatChanges.NegativeStatChanges.SpDefDwn1 }, new bool[] { false }, new ZMove(BloomDoom, 175), 0);
                ForestsCurse = new Move("Forest's Curse", Type.Grass, 0, 1, 20, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.AddTypeToTarget.Grass }, new bool[] { false }, ZForestsCurse, 0);
                FrenzyPlant = new Move("Frenzy Plant", Type.Grass, 150, 0.9, 5, 'M', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Recharging }, new bool[] { true }, new ZMove(BloomDoom, 200), 0);
                GigaDrain = new Move("Giga Drain", Type.Grass, 75, 1, 10, 'M', new double[] { 1 }, new Effect[] { Effects.HealingEffects.HPRestore.HealHalfDmgInflicted }, new bool[] { true }, new ZMove(BloomDoom, 140), 0);
                GrassKnot = new Move("Grass Knot", Type.Grass, -1, 1, 20, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HeavierOppMoreDmg }, new bool[] { false }, new ZMove(BloomDoom, 160), 0);
                GrassPledge = new Move("Grass Pledge", Type.Grass, 80, 1, 10, 'M', new double[] { 1 }, new Effect[] { Effects.RareEffects.Pledges }, new bool[] { false }, new ZMove(BloomDoom, 160), 0);
                GrassWhistle = new Move("Grass Whistle", Type.Grass, 0, 0.55, 15, 'S', new double[] { 1 }, new Effect[] { Statuses.BaseStatuses.Sleep }, new bool[] { false }, ZGrassWhistle, 0);
                GrassyTerrain = new Move("Grassy Terrain", Type.Grass, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.Terrain.Grass }, new bool[] { false }, ZGrassyTerrain, 0);
                HornLeech = new Move("Horn Leech", Type.Grass, 75, 1, 10, 'P', new double[] { 1 }, new Effect[] { Effects.HealingEffects.HPRestore.HealHalfDmgInflicted }, new bool[] { true }, new ZMove(BloomDoom, 140), 0);
                Ingrain = new Move("Ingrain", Type.Grass, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Rooting }, new bool[] { true }, ZIngrain, 0);
                LeafBlade = new Move("Leaf Blade", Type.Grass, 90, 1, 15, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HighCrit }, new bool[] { true }, new ZMove(BloomDoom, 175), 0);
                LeafStorm = new Move("Leaf Storm", Type.Grass, 130, 0.9, 5, 'M', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.SpAtkDwn2 }, new bool[] { true }, new ZMove(BloomDoom, 195), 0);
                LeafTornado = new Move("Leaf Tornado", Type.Grass, 65, 0.9, 10, 'M', new double[] { 0.3 }, new Effect[] { StatChanges.NegativeStatChanges.AccDwn1 }, new bool[] { false }, new ZMove(BloomDoom, 120), 0);
                Leafage = new Move("Leafage", Type.Grass, 40, 1, 40, 'P', null, null, null, BloomDoom, 0);
                LeechSeed = new Move("Leech Seed", Type.Grass, 0, 0.9, 10, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.LeechSeed }, new bool[] { false }, ZLeechSeed, 0);
                MagicalLeaf = new Move("Magical Leaf", Type.Grass, 60, -1, 20, 'M', null, null, null, new ZMove(BloomDoom, 120), 0);
                MegaDrain = new Move("Mega Drain", Type.Grass, 40, 1, 15, 'M', new double[] { 1 }, new Effect[] { Effects.HealingEffects.HPRestore.HealHalfDmgInflicted }, new bool[] { true }, new ZMove(BloomDoom, 120), 0);
                NeedleArm = new Move("Needle Arm", Type.Grass, 60, 1, 15, 'P', new double[] { 0.3 }, new Effect[] { Statuses.VolatileStatuses.Flinch }, new bool[] { false }, new ZMove(BloomDoom, 120), 0);
                PetalBLizzard = new Move("Petal Blizzard", Type.Grass, 120, 1, 10, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HitAllAdjacent }, new bool[] { false }, new ZMove(BloomDoom, 175), 0);
                PetalDance = new Move("Petal Dance", Type.Grass, 120, 1, 10, 'M', new double[] { 1 }, new Effect[] { Effects.RareEffects.Thrash }, new bool[] { true }, new ZMove(BloomDoom, 190), 0);
                PowerWhip = new Move("Power Whip", Type.Grass, 120, 0.85, 10, 'P', null, null, null, new ZMove(BloomDoom, 190), 0);
                RazorLeaf = new Move("Razor Leaf", Type.Grass, 55, 0.95, 25, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HighCrit }, new bool[] { true }, BloomDoom, 0);
                SeedBomb = new Move("Seed Bomb", Type.Grass, 80, 1, 15, 'P', null, null, null, new ZMove(BloomDoom, 160), 0);
                SeedFlare = new Move("Seed Flare", Type.Grass, 120, 0.85, 5, 'M', new double[] { 0.4 }, new Effect[] { StatChanges.NegativeStatChanges.SpDefDwn1 }, new bool[] { false }, new ZMove(BloomDoom, 190), 0);
                SleepPowder = new Move("Sleep Powder", Type.Grass, 0, 0.75, 15, 'S', new double[] { 1 }, new Effect[] { Statuses.BaseStatuses.Sleep }, new bool[] { false }, ZSleepPowder, 0);
                SolarBeam = new Move("Solar Beam", Type.Grass, 120, 1, 10, 'M', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.TakingInSunlight }, new bool[] { true }, new ZMove(BloomDoom, 190), 0);
                SolarBlade = new Move("Solar Blade", Type.Grass, 125, 1, 10, 'P', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.TakingInSunlight }, new bool[] { true }, new ZMove(BloomDoom, 190), 0);
                SpikyShield = new Move("Spiky Shield", Type.Grass, 0, -1, 10, 'S', new double[] { 1, 1, 1 }, new Effect[] { Statuses.VolatileStatuses.Protection, Flags.isHitByPhysMv, Effects.GeneralEffects.Recoil.EighthMaxHP }, new bool[] { true, true, false }, ZSpikyShield, 4);
                Spore = new Move("Spore", Type.Grass, 0, 1, 15, 'S', new double[] { 1 }, new Effect[] { Statuses.BaseStatuses.Sleep }, new bool[] { false }, ZSpore, 0);
                StrengthSap = new Move("Strength Sap", Type.Grass, 0, 1, 10, 'S', new double[] { 1, 1 }, new Effect[] { Effects.HealingEffects.HPRestore.HealTargetAtkStat, StatChanges.NegativeStatChanges.AtkDwn1 }, new bool[] { true, false }, ZStrengthSap, 0);
                StunSpore = new Move("Stun Spore", Type.Grass, 0, 0.75, 30, 'S', new double[] { 1 }, new Effect[] { Statuses.BaseStatuses.Paralysis }, new bool[] { false }, ZStunSpore, 0);
                Synthesis = new Move("Synthesis", Type.Grass, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { Effects.HealingEffects.HPRestore.WeatherBasedHPRestore }, new bool[] { true }, ZSynthesis, 0);
                TropKick = new Move("Trop Kick", Type.Grass, 70, 1, 15, 'P', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.AtkDwn1 }, new bool[] { false }, new ZMove(BloomDoom, 140), 0);
                WoodHammer = new Move("Wood Hammer", Type.Grass, 120, 1, 15, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Recoil.ThirdDmgDealt }, new bool[] { true }, new ZMove(BloomDoom, 190), 0);
                WorrySeed = new Move("Worry Seed", Type.Grass, 0, 1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.ChangeTargetAbilityToInsomnia }, new bool[] { false }, ZWorrySeed, 0);
                #endregion
            }
            #endregion
        }
        #endregion

        #region Ice
        /// <summary>
        /// All Ice moves
        /// </summary>
        public static class Ice
        {
            #region Ice Z-Moves
            public static ZMove SubzeroSlammer;
            public static ZMove ZAuroraVeil;
            public static ZMove ZHail;
            public static ZMove ZHaze;
            public static ZMove ZMist;
            #endregion

            #region Ice Moves
            public static Move AuroraBeam;
            public static Move AuroraVeil;
            public static Move Avalanche;
            public static Move Blizzard;
            public static Move FreezeShock;
            public static Move FreezeDry;
            public static Move FrostBreath;
            public static Move Glaciate;
            public static Move Hail;
            public static Move Haze;
            public static Move IceBall;
            public static Move IceBeam;
            public static Move IceBurn;
            public static Move IceFang;
            public static Move IceHammer;
            public static Move IcePunch;
            public static Move IceShard;
            public static Move IcicleCrash;
            public static Move IcicleSpear;
            public static Move IcyWind;
            public static Move Mist;
            public static Move PowderSnow;
            public static Move SheerCold;
            #endregion

            #region Ice Constructor
            static Ice()
            {
                #region Z-Ice Constructor
                SubzeroSlammer = new ZMove("Subzero Slammer", 120, null, null);
                ZAuroraVeil = new ZMove("Z-Aurora Veil", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZHail = new ZMove("Z-Hail", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZHaze = new ZMove("Z-Haze", 0, new Effect[] { Effects.HealingEffects.HPRestore.FullHPRestore }, new bool[] { true });
                ZMist = new ZMove("Z-Mist", 0, new Effect[] { Effects.HealingEffects.HPRestore.FullHPRestore }, new bool[] { true });
                #endregion

                #region Ice Constructor
                AuroraBeam = new Move("Aurora Beam", Type.Ice, 65, 1, 20, 'M', new double[] { 0.1 }, new Effect[] { StatChanges.NegativeStatChanges.AtkDwn1 }, new bool[] { false }, SubzeroSlammer, 0);
                AuroraVeil = new Move("Aurora Veil", Type.Ice, 0, 1, 20, 'S', new double[] { 1, 1 }, new Effect[] { Effects.GeneralEffects.AttackScreen, Effects.GeneralEffects.SpecialScreen }, new bool[] { true, true }, ZAuroraVeil, 0);
                Avalanche = new Move("Avalanche", Type.Ice, 60, 1, 10, 'P', new double[] { 1, 1 }, new Effect[] { Flags.ifTakenDmgThisTurn, Effects.GeneralEffects.DoublePower }, new bool[] { true }, SubzeroSlammer, 0);
                Blizzard = new Move("Blizzard", Type.Ice, 110, 0.7, 5, 'M', new double[] { 0.1 }, new Effect[] { Statuses.BaseStatuses.Freeze }, new bool[] { false }, new ZMove(SubzeroSlammer, 185), 0);
                FreezeShock = new Move("Freeze Shock", Type.Ice, 140, 0.9, 5, 'P', new double[] { 0.3 }, new Effect[] { Statuses.BaseStatuses.Paralysis }, new bool[] { false }, new ZMove(SubzeroSlammer, 200), 0);
                FreezeDry = new Move("Freeze-Dry", Type.Ice, 70, 1, 20, 'M', new double[] { 0.1, 1 }, new Effect[] { Statuses.BaseStatuses.Freeze, Effects.RareEffects.FreezeDry }, new bool[] { false, true }, new ZMove(SubzeroSlammer, 140), 0);
                FrostBreath = new Move("Frost Breath", Type.Ice, 60, 0.9, 10, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.AllCrit }, new bool[] { true }, SubzeroSlammer, 0);
                Glaciate = new Move("Glaciate", Type.Ice, 65, 0.95, 10, 'M', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.SpdDwn1 }, new bool[] { false }, SubzeroSlammer, 0);
                Hail = new Move("Hail", Type.Ice, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Weather.Hail }, new bool[] { false }, ZHail, 0);
                Haze = new Move("Haze", Type.Ice, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { Effects.HealingEffects.StatAlterations.ResetAllStatChanges }, new bool[] { true }, ZHaze, 0);
                IceBall = new Move("Ice Ball", Type.Ice, 30, 0.9, 20, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.IncrementalDamageMux }, new bool[] { true }, new ZMove(SubzeroSlammer, 100), 0);
                IceBeam = new Move("Ice Beam", Type.Ice, 90, 1, 10, 'M', new double[] { 0.1 }, new Effect[] { Statuses.BaseStatuses.Freeze }, new bool[] { false }, new ZMove(SubzeroSlammer, 175), 0);
                IceBurn = new Move("Ice Burn", Type.Ice, 140, 0.9, 5, 'M', new double[] { 0.3 }, new Effect[] { Statuses.BaseStatuses.Burn }, new bool[] { false }, new ZMove(SubzeroSlammer, 200), 0);
                IceFang = new Move("Ice Fang", Type.Ice, 65, 0.95, 15, 'P', new double[] { 0.1 }, new Effect[] { Statuses.VolatileStatuses.Flinch }, new bool[] { false }, SubzeroSlammer, 0);
                IceHammer = new Move("Ice Hammer", Type.Ice, 100, 0.9, 10, 'P', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.SpdDwn1 }, new bool[] { false }, new ZMove(SubzeroSlammer, 180), 0);
                IcePunch = new Move("Ice Punch", Type.Ice, 75, 1, 15, 'P', new double[] { 0.1 }, new Effect[] { Statuses.BaseStatuses.Freeze }, new bool[] { false }, new ZMove(SubzeroSlammer, 140), 0);
                IceShard = new Move("Ice Shard", Type.Ice, 40, 1, 30, 'P', new double[] { }, new Effect[] { }, new bool[] { }, new ZMove(SubzeroSlammer, 100), 1);
                IcicleCrash = new Move("Icicle Crash", Type.Ice, 85, 0.9, 10, 'P', new double[] { 0.3 }, new Effect[] { Statuses.VolatileStatuses.Flinch }, new bool[] { false }, new ZMove(SubzeroSlammer, 160), 0);
                IcicleSpear = new Move("Icicle Spear", Type.Ice, 25, 1, 30, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HitsMultipleTimes }, new bool[] { true }, new ZMove(SubzeroSlammer, 140), 0);
                IcyWind = new Move("Icy Wind", Type.Ice, 55, 0.95, 15, 'M', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.SpdDwn1 }, new bool[] { false }, new ZMove(SubzeroSlammer, 100), 0);
                Mist = new Move("Mist", Type.Ice, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { Effects.HealingEffects.StatAlterations.PreventStatChanges }, new bool[] { true }, ZMist, 0);
                PowderSnow = new Move("Powder Snow", Type.Ice, 40, 1, 35, 'M', new double[] { 0.1 }, new Effect[] { Statuses.BaseStatuses.Freeze }, new bool[] { false }, new ZMove(SubzeroSlammer, 100), 0);
                SheerCold = new Move("Sheer Cold", Type.Ice, -1, -2, 5, 'M', new double[] { 1 }, new Effect[] { Effects.RareEffects.OHKO }, new bool[] { false }, new ZMove(SubzeroSlammer, 180), 0);
                #endregion
            }
            #endregion
        }
        #endregion

        #region Fighting
        /// <summary>
        /// All Fighting moves
        /// </summary>
        public static class Fighting
        {
            #region Fighting Z-Moves
            public static ZMove AllOutPummeling;
            public static ZMove ZBulkUp;
            public static ZMove ZDetect;
            public static ZMove ZMatBlock;
            public static ZMove ZQuickGuard;
            #endregion

            #region Fighting Moves
            public static Move ArmThrust;
            public static Move AuraSphere;
            public static Move BrickBreak;
            public static Move BulkUp;
            public static Move CircleThrow;
            public static Move CloseCombat;
            public static Move Counter;
            public static Move CrossChop;
            public static Move Detect;
            public static Move DoubleKick;
            public static Move DrainPunch;
            public static Move DynamicPunch;
            public static Move FinalGambit;
            public static Move FlyingPress;
            public static Move FocusBlast;
            public static Move FocusPunch;
            public static Move ForcePalm;
            public static Move HammerArm;
            public static Move HighJumpKick;
            public static Move JumpKick;
            public static Move KarateChop;
            public static Move LowKick;
            public static Move LowSweep;
            public static Move MachPunch;
            public static Move MatBlock;
            public static Move PowerUpPunch;
            public static Move QuickGuard;
            public static Move Revenge;
            public static Move Reversal;
            public static Move RockSmash;
            public static Move RollingKick;
            public static Move SacredSword;
            public static Move SecretSword;
            public static Move SeismicToss;
            public static Move SkyUppercut;
            public static Move StormThrow;
            public static Move Submission;
            public static Move Superpower;
            public static Move TripleKick;
            public static Move VacuumWave;
            public static Move VitalThrow;
            public static Move WakeUpSlap;
            #endregion

            #region Fighting Constructor
            static Fighting()
            {
                #region Z-Fighting Constructor
                AllOutPummeling = new ZMove("All-Out Pummeling", 100, null, null);
                ZBulkUp = new ZMove("Z-Bulk Up", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1 }, new bool[] { true });
                ZDetect = new ZMove("Z-Detect", 0, new Effect[] { StatChanges.PositiveStatChanges.EvasUp1 }, new bool[] { true });
                ZMatBlock = new ZMove("Z-Mat Block", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                ZQuickGuard = new ZMove("Z-Quick Guard", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                #endregion

                #region Fighting Constructor
                ArmThrust = new Move("Arm Thrust", Type.Fighting, 15, 1, 20, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HitsMultipleTimes }, new bool[] { false }, AllOutPummeling, 0);
                AuraSphere = new Move("Aura Sphere", Type.Fighting, 80, -1, 20, 'M', null, null, null, new ZMove(AllOutPummeling, 160), 0);
                BrickBreak = new Move("Brick Break", Type.Fighting, 75, 1, 15, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.BreakScreens }, new bool[] { false }, new ZMove(AllOutPummeling, 140), 0);
                BulkUp = new Move("Bulk Up", Type.Fighting, 0, -1, 20, 'P', new double[] { 1, 1 }, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1, StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true, true }, ZBulkUp, 0);
                CircleThrow = new Move("Circle Throw", Type.Fighting, 60, 0.9, 10, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Switchout }, new bool[] { false }, new ZMove(AllOutPummeling, 120), 0);
                CloseCombat = new Move("Close Combat", Type.Fighting, 120, 1, 5, 'P', new double[] { 1, 1 }, new Effect[] { StatChanges.NegativeStatChanges.DefDwn1, StatChanges.NegativeStatChanges.SpDefDwn1 }, new bool[] { true, true }, new ZMove(AllOutPummeling, 190), 0);
                Counter = new Move("Counter", Type.Fighting, -1, 1, 20, 'P', new double[] { 1, 1 }, new Effect[] { Flags.isHitByPhysMv, Effects.GeneralEffects.CopyLastMove, Effects.GeneralEffects.DoublePower }, new bool[] { true, false, true }, AllOutPummeling, -5);
                CrossChop = new Move("Cross Chop", Type.Fighting, 100, 0.8, 5, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HighCrit }, new bool[] { true }, new ZMove(AllOutPummeling, 180), 0);
                Detect = new Move("Detect", Type.Fighting, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Protection }, new bool[] { true }, ZDetect, 3);
                DoubleKick = new Move("DoubleKick", Type.Fighting, 30, 1, 30, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HitTwiceOneTurn }, new bool[] { false }, AllOutPummeling, 0);
                DynamicPunch = new Move("Dynamic Punch", Type.Fighting, 100, 0.5, 5, 'P', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Confused }, new bool[] { false }, new ZMove(AllOutPummeling, 180), 0);
                FinalGambit = new Move("Final Gambit", Type.Fighting, -1, 1, 5, 'M', new double[] { 1, 1 }, new Effect[] { Effects.RareEffects.DealRemainingHP, Effects.GeneralEffects.SelfDestruction }, new bool[] { false, true }, new ZMove(AllOutPummeling, 180), 0);
                FlyingPress = new Move("Flying Press", Type.Fighting, 100, 0.95, 10, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.FlyingPress }, new bool[] { false }, new ZMove(AllOutPummeling, 120), 0);
                FocusBlast = new Move("Focus Blast", Type.Fighting, 120, 0.7, 5, 'M', new double[] { 0.1 }, new Effect[] { StatChanges.NegativeStatChanges.SpDefDwn1 }, new bool[] { false }, new ZMove(AllOutPummeling, 190), 0);
                FocusPunch = new Move("Focus Punch", Type.Fighting, 150, 1, 20, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.FocusPunch }, new bool[] { true }, new ZMove(AllOutPummeling, 200), -3);
                ForcePalm = new Move("Force Palm", Type.Fighting, 60, 1, 10, 'P', new double[] { 0.3 }, new Effect[] { Statuses.BaseStatuses.Paralysis }, new bool[] { false }, new ZMove(AllOutPummeling, 120), 0);
                HammerArm = new Move("Hammer Arm", Type.Fighting, 100, 0.9, 10, 'P', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.SpdDwn1 }, new bool[] { true }, new ZMove(AllOutPummeling, 180), 0);
                HighJumpKick = new Move("High Jump Kick", Type.Fighting, 130, 0.9, 10, 'P', new double[] { 1, 1 }, new Effect[] { Flags.ifMoveMisses, Effects.GeneralEffects.Recoil.HalfMaxHP }, new bool[] { true, true }, new ZMove(AllOutPummeling, 195), 0);
                JumpKick = new Move("Jump Kick", Type.Fighting, 100, 0.95, 10, 'P', new double[] { 1, 1 }, new Effect[] { Flags.ifMoveMisses, Effects.GeneralEffects.Recoil.HalfMaxHP }, new bool[] { true, true }, new ZMove(AllOutPummeling, 180), 0);
                KarateChop = new Move("Karate Chop", Type.Fighting, 50, 1, 25, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HighCrit }, new bool[] { true }, AllOutPummeling, 0);
                LowKick = new Move("Low Kick", Type.Fighting, -1, 1, 20, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HeavierOppMoreDmg }, new bool[] { false }, new ZMove(AllOutPummeling, 160), 0);
                LowSweep = new Move("Low Sweep", Type.Fighting, 65, 1, 20, 'P', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.SpdDwn1 }, new bool[] { false }, new ZMove(AllOutPummeling, 120), 0);
                MachPunch = new Move("Mach Punch", Type.Fighting, 40, 1, 30, 'P', null, null, null, AllOutPummeling, 1);
                MatBlock = new Move("Mat Block", Type.Fighting, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.TeamProtection }, new bool[] { false }, ZMatBlock, 0);
                PowerUpPunch = new Move("Power-Up Punch", Type.Fighting, 40, 1, 10, 'P', new double[] { 1 }, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1 }, new bool[] { true }, AllOutPummeling, 0);
                QuickGuard = new Move("Quick Guard", Type.Fighting, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.QuickGuard }, new bool[] { false }, ZQuickGuard, 3);
                Revenge = new Move("Revenge", Type.Fighting, 60, 1, 10, 'P', new double[] { 1, 1 }, new Effect[] { Flags.ifTakenDmgThisTurn, Effects.GeneralEffects.DoublePower }, new bool[] { true, true }, new ZMove(AllOutPummeling, 120), -4);
                Reversal = new Move("Reversal", Type.Fighting, -1, 1, 15, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.LessHPMoreDmg }, new bool[] { true }, new ZMove(AllOutPummeling, 160), 0);
                RockSmash = new Move("Rock Smash", Type.Fighting, 40, 1, 15, 'P', new double[] { 0.5 }, new Effect[] { StatChanges.NegativeStatChanges.DefDwn1 }, new bool[] { false }, AllOutPummeling, 0);
                RollingKick = new Move("Rolling Kick", Type.Fighting, 60, 0.85, 15, 'P', new double[] { 0.3 }, new Effect[] { Statuses.VolatileStatuses.Flinch }, new bool[] { false }, new ZMove(AllOutPummeling, 120), 0);
                SacredSword = new Move("Sacred Sword", Type.Fighting, 90, 1, 20, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.IgnoreStatChanges }, new bool[] { true }, new ZMove(AllOutPummeling, 175), 0);
                SecretSword = new Move("Secret Sword", Type.Fighting, 85, 1, 10, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.DmgBasedOnOppositeStat }, new bool[] { false }, new ZMove(AllOutPummeling, 160), 0);
                SeismicToss = new Move("Seismic Toss", Type.Fighting, -1, 1, 20, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.DealsDmgEqualToLvl }, new bool[] { false }, AllOutPummeling, 0);
                SkyUppercut = new Move("Sky Uppercut", Type.Fighting, 85, 0.9, 15, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Ignore.Fly }, new bool[] { false }, new ZMove(AllOutPummeling, 160), 0);
                StormThrow = new Move("Storm Throw", Type.Fighting, 60, 1, 10, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.AllCrit }, new bool[] { false }, new ZMove(AllOutPummeling, 120), 0);
                Submission = new Move("Submission", Type.Fighting, 80, 0.8, 20, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Recoil.QuarterDmgDealt }, new bool[] { true }, new ZMove(AllOutPummeling, 160), 0);
                Superpower = new Move("Superpower", Type.Fighting, 120, 1, 5, 'P', new double[] { 1, 1 }, new Effect[] { StatChanges.NegativeStatChanges.AtkDwn1, StatChanges.NegativeStatChanges.DefDwn1 }, new bool[] { true, true }, new ZMove(AllOutPummeling, 190), 0);
                TripleKick = new Move("Triple Kick", Type.Fighting, -1, 0.9, 10, 'P', new double[] { 1, }, new Effect[] { Effects.RareEffects.TripleKick }, new bool[] { false }, new ZMove(AllOutPummeling, 120), 0);
                VacuumWave = new Move("Vacuum Wave", Type.Fighting, 40, 1, 30, 'M', null, null, null, AllOutPummeling, 1);
                VitalThrow = new Move("Vital Throw", Type.Fighting, 70, -1, 10, 'P', null, null, null, new ZMove(AllOutPummeling, 140), -1);
                WakeUpSlap = new Move("Wake-Up Slap", Type.Fighting, 70, 1, 10, 'P', new double[] { 1, 1, 1 }, new Effect[] { Flags.isAsleep, Effects.GeneralEffects.DoublePower, Effects.HealingEffects.StatusCures.CureSleep }, new bool[] { false, true, false }, new ZMove(AllOutPummeling, 140), 0);
                #endregion
            }
            #endregion
        }
        #endregion

        #region Poison
        /// <summary>
        /// All Poison moves
        /// </summary>
        public static class Poison
        {
            #region Poison Z-Moves
            public static ZMove AcidDownpour;
            public static ZMove ZAcidArmor;
            public static ZMove ZBanefulBunker;
            public static ZMove ZCoil;
            public static ZMove ZGastroAcid;
            public static ZMove ZPoisonGas;
            public static ZMove ZPoisonPowder;
            public static ZMove ZPurify;
            public static ZMove ZToxic;
            public static ZMove ZToxicSpikes;
            public static ZMove ZToxicThread;
            public static ZMove ZVenomDrench;
            #endregion

            #region Poison Moves
            public static Move Acid;
            public static Move AcidArmor;
            public static Move AcidSpray;
            public static Move BanefulBunker;
            public static Move Belch;
            public static Move ClearSmog;
            public static Move Coil;
            public static Move CrossPoison;
            public static Move GastroAcid;
            public static Move GunkShot;
            public static Move PoisonFang;
            public static Move PoisonGas;
            public static Move PoisonJab;
            public static Move PoisonPowder;
            public static Move PoisonSting;
            public static Move PoisonTail;
            public static Move Purify;
            public static Move Sludge;
            public static Move SludgeBomb;
            public static Move SludgeWave;
            public static Move Smog;
            public static Move Toxic;
            public static Move ToxicSpikes;
            public static Move ToxicThread;
            public static Move VenomDrench;
            public static Move Venoshock;
            #endregion

            #region Poison Constructor
            static Poison()
            {
                #region Z-Poison Constructor
                AcidDownpour = new ZMove("Acid Downpour", 100, null, null);
                ZAcidArmor = new ZMove("Z-Acid Armor", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZBanefulBunker = new ZMove("Z-Baneful Bunker", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                ZCoil = new ZMove("Z-Coil", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZGastroAcid = new ZMove("Z-Gastro Acid", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZPoisonGas = new ZMove("Z-Poison Gas", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                ZPoisonPowder = new ZMove("Z-Poison Powder", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                ZPurify = new ZMove("Z-Purify", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1, StatChanges.PositiveStatChanges.DefUp1, StatChanges.PositiveStatChanges.SpAtkUp1, StatChanges.PositiveStatChanges.SpDefUp1, StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true, true, true, true, true });
                ZToxic = new ZMove("Z-Toxic", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                ZToxicSpikes = new ZMove("Z-Toxic Spikes", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                ZToxicThread = new ZMove("Z-Toxic Thread", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZVenomDrench = new ZMove("Z-Venom Drench", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                #endregion

                #region Poison Constructor
                Acid = new Move("Acid", Type.Poison, 40, 1, 30, 'M', new double[] { 0.1 }, new Effect[] { StatChanges.NegativeStatChanges.SpDefDwn1 }, new bool[] { false }, AcidDownpour, 0);
                AcidArmor = new Move("Acid Armor", Type.Poison, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { StatChanges.PositiveStatChanges.DefUp2 }, new bool[] { true }, ZAcidArmor, 0);
                AcidSpray = new Move("Acid Spray", Type.Poison, 40, 1, 20, 'M', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.SpDefDwn2 }, new bool[] { false }, AcidDownpour, 0);
                BanefulBunker = new Move("Baneful Bunker", Type.Poison, 0, -1, 10, 'S', new double[] { 1, 1, 1 }, new Effect[] { Statuses.VolatileStatuses.Protection, Flags.isHitByPhysMv, Statuses.BaseStatuses.Poisoned }, new bool[] { true, true, false }, ZBanefulBunker, 4);
                Belch = new Move("Belch", Type.Poison, 120, 0.9, 10, 'M', new double[] { 1, 1 }, new Effect[] { Flags.NotEatenBerry, Effects.GeneralEffects.DealsNoDmg }, new bool[] { true, true }, new ZMove(AcidDownpour, 190), 0);
                ClearSmog = new Move("Clear Smog", Type.Poison, 50, -1, 15, 'M', new double[] { 1 }, new Effect[] { Effects.HealingEffects.StatAlterations.ResetAllStatChanges }, new bool[] { false }, AcidDownpour, 0);
                Coil = new Move("Coil", Type.Poison, 0, -1, 20, 'S', new double[] { 1, 1, 1 }, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1, StatChanges.PositiveStatChanges.DefUp1, StatChanges.PositiveStatChanges.AccUp1 }, new bool[] { true, true, true }, ZCoil, 0);
                CrossPoison = new Move("Cross Poison", Type.Poison, 70, 1, 20, 'P', new double[] { 1, 0.1 }, new Effect[] { Effects.GeneralEffects.HighCrit, Statuses.BaseStatuses.Poisoned }, new bool[] { true, false }, new ZMove(AcidDownpour, 140), 0);
                GastroAcid = new Move("Gastro Acid", Type.Poison, 0, 1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.RemoveTargetAbilityEffects }, new bool[] { false }, ZGastroAcid, 0);
                GunkShot = new Move("Gunk Shot", Type.Poison, 120, 0.8, 5, 'P', new double[] { 0.3 }, new Effect[] { Statuses.BaseStatuses.Poisoned }, new bool[] { false }, new ZMove(AcidDownpour, 190), 0);
                PoisonFang = new Move("Poison Fang", Type.Poison, 50, 1, 15, 'P', new double[] { 0.5 }, new Effect[] { Statuses.BaseStatuses.BadPoison }, new bool[] { false }, AcidDownpour, 0);
                PoisonGas = new Move("Poison Gas", Type.Poison, 0, 0.9, 40, 'S', new double[] { 1 }, new Effect[] { Statuses.BaseStatuses.Poisoned }, new bool[] { false }, ZPoisonGas, 0);
                PoisonJab = new Move("Poison Jab", Type.Poison, 80, 1, 20, 'P', new double[] { 0.3 }, new Effect[] { Statuses.BaseStatuses.Poisoned }, new bool[] { false }, new ZMove(AcidDownpour, 160), 0);
                PoisonPowder = new Move("Poison Powder", Type.Poison, 0, 0.75, 35, 'S', new double[] { 1 }, new Effect[] { Statuses.BaseStatuses.Poisoned }, new bool[] { false }, ZPoisonPowder, 0);
                PoisonSting = new Move("Poison Sting", Type.Poison, 15, 1, 35, 'P', new double[] { 0.3 }, new Effect[] { Statuses.BaseStatuses.Poisoned }, new bool[] { false }, AcidDownpour, 0);
                PoisonTail = new Move("Poison Tail", Type.Poison, 50, 1, 25, 'P', new double[] { 1, 0.1 }, new Effect[] { Effects.GeneralEffects.HighCrit, Statuses.BaseStatuses.Poisoned }, new bool[] { true, false }, AcidDownpour, 0);
                Purify = new Move("Purify", Type.Poison, 0, -1, 20, 'S', new double[] { 1, 1, 1 }, new Effect[] { Flags.ifAfflicted, Effects.HealingEffects.StatusCures.CureNonVolatile, Effects.HealingEffects.HPRestore.HalfHPRestore }, new bool[] { false, false, true }, ZPurify, 0);
                Sludge = new Move("Sludge", Type.Poison, 65, 1, 20, 'M', new double[] { 0.3 }, new Effect[] { Statuses.BaseStatuses.Poisoned }, new bool[] { false }, new ZMove(AcidDownpour, 120), 0);
                SludgeBomb = new Move("Sludge Bomb", Type.Poison, 90, 1, 10, 'M', new double[] { 0.3 }, new Effect[] { Statuses.BaseStatuses.Poisoned }, new bool[] { false }, new ZMove(AcidDownpour, 175), 0);
                SludgeWave = new Move("Sludge Wave", Type.Poison, 95, 1, 10, 'M', new double[] { 0.1 }, new Effect[] { Statuses.BaseStatuses.Poisoned }, new bool[] { false }, new ZMove(AcidDownpour, 175), 0);
                Smog = new Move("Smog", Type.Poison, 30, 0.7, 20, 'M', new double[] { 0.4 }, new Effect[] { Statuses.BaseStatuses.Poisoned }, new bool[] { false }, AcidDownpour, 0);
                Toxic = new Move("Toxic", Type.Poison, 0, 0.9, 10, 'S', new double[] { 1 }, new Effect[] { Statuses.BaseStatuses.BadPoison }, new bool[] { false }, ZToxic, 0);
                ToxicSpikes = new Move("Toxic Spikes", Type.Poison, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.SetEntryHazards.ToxicSpikes }, new bool[] { false }, ZToxicSpikes, 0);
                ToxicThread = new Move("Toxic Thread", Type.Poison, 0, 1, 20, 'S', new double[] { 1, 1 }, new Effect[] { Statuses.BaseStatuses.Poisoned, StatChanges.NegativeStatChanges.SpdDwn1 }, new bool[] { false, false }, ZToxicThread, 0);
                VenomDrench = new Move("Venom Drench", Type.Poison, 0, 1, 20, 'S', new double[] { 1, 1, 1, 1 }, new Effect[] { Flags.isPoisoned, StatChanges.NegativeStatChanges.AtkDwn1, StatChanges.NegativeStatChanges.SpAtkDwn1, StatChanges.NegativeStatChanges.SpdDwn1 }, new bool[] { false, false, false, false }, ZVenomDrench, 0);
                Venoshock = new Move("Venoshock", Type.Poison, 65, 1, 10, 'M', new double[] { 1, 1 }, new Effect[] { Flags.isPoisoned, Effects.GeneralEffects.DoublePower }, new bool[] { false, true }, new ZMove(AcidDownpour, 120), 0);
                #endregion
            }
            #endregion 
        }
        #endregion

        #region Ground
        /// <summary>
        /// All Ground moves
        /// </summary>
        public static class Ground
        {
            #region Ground Z-Moves
            public static ZMove TectonicRage;
            public static ZMove ZMudSport;
            public static ZMove ZRototiller;
            public static ZMove ZSandAttack;
            public static ZMove ZShoreUp;
            public static ZMove ZSpikes;
            #endregion

            #region Ground Moves
            public static Move BoneClub;
            public static Move BoneRush;
            public static Move Bonemerang;
            public static Move Bulldoze;
            public static Move Dig;
            public static Move DrillRun;
            public static Move EarthPower;
            public static Move Earthquake;
            public static Move Fissure;
            public static Move HighHorsepower;
            public static Move LandsWrath;
            public static Move Magnitude;
            public static Move MudBomb;
            public static Move MudShot;
            public static Move MudSport;
            public static Move MudSlap;
            public static Move PrecipiceBlades;
            public static Move Rototiller;
            public static Move SandAttack;
            public static Move SandTomb;
            public static Move ShoreUp;
            public static Move Spikes;
            public static Move StompingTantrum;
            public static Move ThousandArrows;
            public static Move ThousandWaves;
            #endregion

            #region Ground Constructor
            static Ground()
            {
                #region Z-Ground Constructor
                TectonicRage = new ZMove("Tectonic Rage", 100, null, null);
                ZMudSport = new ZMove("Z-Mud Sport", 0, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp1 }, new bool[] { true });
                ZRototiller = new ZMove("Z-Rototiller", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1 }, new bool[] { true });
                ZSandAttack = new ZMove("Z-Sand Attack", 0, new Effect[] { StatChanges.PositiveStatChanges.EvasUp1 }, new bool[] { true });
                ZShoreUp = new ZMove("Z-Shore Up", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZSpikes = new ZMove("Z-Spikes", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                #endregion

                #region Ground Constructor
                BoneClub = new Move("Bone Club", Type.Ground, 65, 0.85, 20, 'P', new double[] { 0.1 }, new Effect[] { Statuses.VolatileStatuses.Flinch }, new bool[] { false }, new ZMove(TectonicRage, 120), 0);
                BoneRush = new Move("Bone Rush", Type.Ground, 25, 0.9, 10, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HitsMultipleTimes }, new bool[] { false }, new ZMove(TectonicRage, 140), 0);
                Bonemerang = new Move("Bonemerang", Type.Ground, 50, 0.9, 10, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HitTwiceOneTurn }, new bool[] { false }, TectonicRage, 0);
                Bulldoze = new Move("Bulldoze", Type.Ground, 60, 1, 20, 'P', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.SpdDwn1 }, new bool[] { false }, new ZMove(TectonicRage, 120), 0);
                Dig = new Move("Dig", Type.Ground, 80, 1, 10, 'P', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.SemiInvulnerable }, new bool[] { true }, new ZMove(TectonicRage, 160), 0);
                DrillRun = new Move("Drill Run", Type.Ground, 80, 0.95, 10, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HighCrit }, new bool[] { true }, new ZMove(TectonicRage, 160), 0);
                EarthPower = new Move("Earth Power", Type.Ground, 90, 1, 10, 'M', new double[] { 0.1 }, new Effect[] { StatChanges.NegativeStatChanges.SpDefDwn1 }, new bool[] { false }, new ZMove(TectonicRage, 175), 0);
                Earthquake = new Move("Earthquake", Type.Ground, 100, 1, 10, 'P', new double[] { 1, 1 }, new Effect[] { Flags.ifUnderground, Effects.GeneralEffects.DoublePower }, new bool[] { false, true }, new ZMove(TectonicRage, 180), 0);
                Fissure = new Move("Fissure", Type.Ground, -1, -2, 5, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.OHKO }, new bool[] { false }, new ZMove(TectonicRage, 180), 0);
                HighHorsepower = new Move("High Horsepower", Type.Ground, 95, 0.95, 10, 'P', null, null, null, new ZMove(TectonicRage, 175), 0);
                LandsWrath = new Move("Land's Wrath", Type.Ground, 90, 1, 10, 'P', null, null, null, new ZMove(TectonicRage, 185), 0);
                Magnitude = new Move("Magnitude", Type.Ground, -1, 1, 30, 'P', new double[] { 1, 1, 1 }, new Effect[] { Effects.RareEffects.Magnitude, Flags.ifUnderground, Effects.GeneralEffects.DoublePower }, new bool[] { false, false, true }, new ZMove(TectonicRage, 140), 0);
                MudBomb = new Move("Mud Bomb", Type.Ground, 65, 0.85, 10, 'M', new double[] { 0.3 }, new Effect[] { StatChanges.NegativeStatChanges.AccDwn1 }, new bool[] { false }, new ZMove(TectonicRage, 120), 0);
                MudShot = new Move("Mud Shot", Type.Ground, 55, 0.95, 15, 'M', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.SpdDwn1 }, new bool[] { false }, TectonicRage, 0);
                MudSport = new Move("Mud Sport", Type.Ground, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Strengthen.Ground, Effects.GeneralEffects.Weaken.Electric }, new bool[] { false, false }, ZMudSport, 0);
                MudSlap = new Move("Mud-Slap", Type.Ground, 20, 1, 10, 'M', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.AccDwn1 }, new bool[] { false }, TectonicRage, 0);
                PrecipiceBlades = new Move("Precipice Blades", Type.Ground, 120, 0.85, 10, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HitAllFoes }, new bool[] { false }, new ZMove(TectonicRage, 190), 0);
                Rototiller = new Move("Rototiller", Type.Ground, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.Rototiller }, new bool[] { false }, ZRototiller, 0);
                SandAttack = new Move("Sand Attack", Type.Ground, 0, 1, 15, 'S', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.AccDwn1 }, new bool[] { false }, ZSandAttack, 0);
                SandTomb = new Move("Sand Tomb", Type.Ground, 35, 0.85, 15, 'P', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Bound }, new bool[] { false }, TectonicRage, 0);
                ShoreUp = new Move("Shore Up", Type.Ground, 0, -1, 10, 'S', new double[] { 1, 1, 1 }, new Effect[] { Effects.HealingEffects.HPRestore.HalfHPRestore, Flags.isSandstorm, Effects.HealingEffects.HPRestore.SixthHPRestore }, new bool[] { true, true, true }, ZShoreUp, 0);
                Spikes = new Move("Spikes", Type.Ground, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.SetEntryHazards.Spikes }, new bool[] { false }, ZSpikes, 0);
                StompingTantrum = new Move("Stomping Tantrum", Type.Ground, 75, 1, 10, 'P', new double[] { 1, 1 }, new Effect[] { Flags.LastMoveFailed, Effects.GeneralEffects.DoublePower }, new bool[] { true, true }, new ZMove(TectonicRage, 140), 0);
                ThousandArrows = new Move("Thousand Arrows", Type.Ground, 90, 1, 10, 'P', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Grounded }, new bool[] { false }, new ZMove(TectonicRage, 180), 0);
                ThousandWaves = new Move("Thousand Waves", Type.Ground, 90, 1, 10, 'P', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.LegHold }, new bool[] { false }, new ZMove(TectonicRage, 175), 0);
                #endregion

            }
            #endregion
        }
        #endregion

        #region Flying
        /// <summary>
        /// All Flying moves
        /// </summary>
        public static class Flying
        {
            #region Flying Z-Moves
            public static ZMove SupersonicSkystrike;
            public static ZMove ZDefog;
            public static ZMove ZFeatherDance;
            public static ZMove ZMirrorMove;
            public static ZMove ZRoost;
            public static ZMove ZTailwind;
            #endregion

            #region Flying Moves
            public static Move Acrobatics;
            public static Move AerialAce;
            public static Move Aeroblast;
            public static Move AirCutter;
            public static Move AirSlash;
            public static Move BeakBlast;
            public static Move Bounce;
            public static Move BraveBird;
            public static Move Chatter;
            public static Move Defog;
            public static Move DragonAscent;
            public static Move DrillPeck;
            public static Move FeatherDance;
            public static Move Fly;
            public static Move Gust;
            public static Move Hurricane;
            public static Move MirrorMove;
            public static Move OblivionWing;
            public static Move Peck;
            public static Move Pluck;
            public static Move Roost;
            public static Move SkyAttack;
            public static Move SkyDrop;
            public static Move Tailwind;
            public static Move WingAttack;
            #endregion

            #region Flying Constructor
            static Flying()
            {
                #region Z-Flying Constructor
                SupersonicSkystrike = new ZMove("Supersonic Skystrike", 100, null, null);
                ZDefog = new ZMove("Z-Defog", 0, new Effect[] { StatChanges.PositiveStatChanges.AccUp1 }, new bool[] { true });
                ZFeatherDance = new ZMove("Z-Feather Dance", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                ZMirrorMove = new ZMove("Z-Mirror Move", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp2 }, new bool[] { true });
                ZRoost = new ZMove("Z-Roost", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZTailwind = new ZMove("Z-Tailwind", 0, new Effect[] { StatChanges.PositiveStatChanges.CritUp1 }, new bool[] { true });
                #endregion

                #region Flying Constructor
                Acrobatics = new Move("Acrobatics", Type.Flying, 55, 1, 15, 'P', new double[] { 1, 1 }, new Effect[] { Flags.NoHeldItem, Effects.GeneralEffects.DoublePower }, new bool[] { true, true }, SupersonicSkystrike, 0);
                AerialAce = new Move("Aerial Ace", Type.Flying, 60, -1, 20, 'P', null, null, null, new ZMove(SupersonicSkystrike, 120), 0);
                Aeroblast = new Move("Aeroblast", Type.Flying, 100, 0.95, 5, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HighCrit }, new bool[] { true }, new ZMove(SupersonicSkystrike, 180), 0);
                AirCutter = new Move("Air Cutter", Type.Flying, 60, 0.95, 25, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HighCrit }, new bool[] { true }, new ZMove(SupersonicSkystrike, 120), 0);
                AirSlash = new Move("Air Slash", Type.Flying, 75, 0.95, 20, 'M', new double[] { 0.3 }, new Effect[] { Statuses.VolatileStatuses.Flinch }, new bool[] { false }, new ZMove(SupersonicSkystrike, 150), 0);
                BeakBlast = new Move("Beak Blast", Type.Flying, 100, 1, 15, 'P', new double[] { 1, 1 }, new Effect[] { Flags.isHitByPhysMv, Statuses.BaseStatuses.Burn }, new bool[] { true, false }, new ZMove(SupersonicSkystrike, 180), -3);
                Bounce = new Move("Bounce", Type.Flying, 85, 0.85, 5, 'P', new double[] { 1, 0.3 }, new Effect[] { Statuses.VolatileStatuses.SemiInvulnerable, Statuses.BaseStatuses.Paralysis }, new bool[] { true, false }, new ZMove(SupersonicSkystrike, 160), 0);
                BraveBird = new Move("Brave Bird", Type.Flying, 120, 1, 15, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Recoil.ThirdDmgDealt }, new bool[] { false }, new ZMove(SupersonicSkystrike, 190), 0);
                Chatter = new Move("Chatter", Type.Flying, 65, 1, 20, 'M', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Confused }, new bool[] { false }, new ZMove(SupersonicSkystrike, 120), 0);
                Defog = new Move("Defog", Type.Flying, 0, -1, 15, 'S', new double[] { 1, 1 }, new Effect[] { Effects.GeneralEffects.RemoveEntryHazards, Effects.GeneralEffects.BreakScreens }, new bool[] { false, false }, ZDefog, 0);
                DragonAscent = new Move("DragonAscent", Type.Flying, 120, 1, 5, 'P', new double[] { 1, 1 }, new Effect[] { StatChanges.NegativeStatChanges.DefDwn1, StatChanges.NegativeStatChanges.SpDefDwn1 }, new bool[] { true, true }, new ZMove(SupersonicSkystrike, 190), 0);
                DrillPeck = new Move("Drill Peck", Type.Flying, 80, 1, 20, 'P', null, null, null, new ZMove(SupersonicSkystrike, 160), 0);
                FeatherDance = new Move("Feather Dance", Type.Flying, 0, 1, 15, 'S', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.AtkDwn2 }, new bool[] { false }, ZFeatherDance, 0);
                Fly = new Move("Fly", Type.Flying, 90, 0.95, 15, 'P', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.SemiInvulnerable }, new bool[] { true }, new ZMove(SupersonicSkystrike, 175), 0);
                Gust = new Move("Gust", Type.Flying, 40, 1, 35, 'M', new double[] { 1, 1, 1 }, new Effect[] { Flags.ifInAir, Effects.GeneralEffects.Ignore.Fly, Effects.GeneralEffects.DoublePower }, new bool[] { false, true }, SupersonicSkystrike, 0);
                Hurricane = new Move("Hurricane", Type.Flying, 110, 0.7, 10, 'M', new double[] { 0.3 }, new Effect[] { Statuses.VolatileStatuses.Confused }, new bool[] { false }, new ZMove(SupersonicSkystrike, 185), 0);
                MirrorMove = new Move("Mirror Move", Type.Flying, -1, -1, 20, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.UseLastMove }, new bool[] { false }, ZMirrorMove, 0);
                OblivionWing = new Move("Oblivion Wing", Type.Flying, 80, 1, 10, 'M', new double[] { 1 }, new Effect[] { Effects.HealingEffects.HPRestore.ThreeQuarterDmgInflicted }, new bool[] { false }, new ZMove(SupersonicSkystrike, 160), 0);
                Peck = new Move("Peck", Type.Flying, 35, 1, 35, 'P', null, null, null, SupersonicSkystrike, 0);
                Pluck = new Move("Pluck", Type.Flying, 60, 1, 20, 'P', new double[] { 1, 1 }, new Effect[] { Flags.ifTgtHoldBerry, Effects.GeneralEffects.ConsumeItem }, new bool[] { false, false }, new ZMove(SupersonicSkystrike, 120), 0);
                Roost = new Move("Roost", Type.Flying, 0, -1, 10, 'S', new double[] { 1, 1 }, new Effect[] { Effects.HealingEffects.HPRestore.HalfHPRestore, Effects.RareEffects.Roost }, new bool[] { true, true }, ZRoost, 0);
                SkyAttack = new Move("Sky Attack", Type.Flying, 140, 0.9, 5, 'P', new double[] { 1, 0.3 }, new Effect[] { Statuses.VolatileStatuses.Glowing, Statuses.VolatileStatuses.Flinch }, new bool[] { true, false }, new ZMove(SupersonicSkystrike, 200), 0);
                SkyDrop = new Move("Sky Drop", Type.Flying, 60, 1, 10, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.SkyDrop }, new bool[] { false }, new ZMove(SupersonicSkystrike, 120), 0);
                Tailwind = new Move("Tailwind", Type.Flying, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.DoublePartySpeed4turns }, new bool[] { true }, ZTailwind, 0);
                WingAttack = new Move("Wing Attack", Type.Flying, 60, 1, 35, 'P', null, null, null, new ZMove(SupersonicSkystrike, 120), 0);
                #endregion
            }
            #endregion
        }
        #endregion

        #region Psychic
        public static class Psychic
        {
            #region Psychic Z-Moves
            public static ZMove ShatteredPsyche;
            public static ZMove ZAgility;
            public static ZMove ZAllySwitch;
            public static ZMove ZAmnesia;
            public static ZMove ZBarrier;
            public static ZMove ZCalmMind;
            public static ZMove ZCosmicPower;
            public static ZMove ZGravity;
            public static ZMove ZGuardSplit;
            public static ZMove ZGuardSwap;
            public static ZMove ZHealBlock;
            public static ZMove ZHealPulse;
            public static ZMove ZHeartSwap;
            public static ZMove ZHypnosis;
            public static ZMove ZImprison;
            public static ZMove ZInstruct;
            public static ZMove ZKinesis;
            public static ZMove ZLightScreen;
            public static ZMove ZMagicCoat;
            public static ZMove ZMagicRoom;
            public static ZMove ZMeditate;
            public static ZMove ZMiracleEye;
            public static ZMove ZPowerSplit;
            public static ZMove ZPowerSwap;
            public static ZMove ZPowerTrick;
            public static ZMove ZPsychicTerrain;
            public static ZMove ZPsychoShift;
            public static ZMove ZReflect;
            public static ZMove ZRest;
            public static ZMove ZRolePlay;
            public static ZMove ZSkillSwap;
            public static ZMove ZSpeedSwap;
            public static ZMove ZTelekinesis;
            public static ZMove ZTeleport;
            public static ZMove ZTrick;
            public static ZMove ZTrickRoom;
            public static ZMove ZWonderRoom;
            #endregion

            #region Psychic Moves
            public static Move Agility;
            public static Move AllySwitch;
            public static Move Amnesia;
            public static Move Barrier;
            public static Move CalmMind;
            public static Move Confusion;
            public static Move CosmicPower;
            public static Move DreamEater;
            public static Move Extrasensory;
            public static Move FutureSight;
            public static Move Gravity;
            public static Move GuardSplit;
            public static Move GuardSwap;
            public static Move HealBlock;
            public static Move HealPulse;
            public static Move HealingWish;
            public static Move HeartStamp;
            public static Move HeartSwap;
            public static Move HyperspaceHole;
            public static Move Hypnosis;
            public static Move Imprison;
            public static Move Instruct;
            public static Move Kinesis;
            public static Move LightScreen;
            public static Move LunarDance;
            public static Move LusterPurge;
            public static Move MagicCoat;
            public static Move MagicRoom;
            public static Move Meditate;
            public static Move MiracleEye;
            public static Move MirrorCoat;
            public static Move MistBall;
            public static Move PowerSplit;
            public static Move PowerSwap;
            public static Move PowerTrick;
            public static Move PrismaticLaser;
            public static Move Psybeam;
            public static Move psychic;
            public static Move PsychicFangs;
            public static Move PsychicTerrain;
            public static Move PsychoBoost;
            public static Move PsychoCut;
            public static Move PsychoShift;
            public static Move Psyshock;
            public static Move Psystrike;
            public static Move Psywave;
            public static Move Reflect;
            public static Move Rest;
            public static Move RolePlay;
            public static Move SkillSwap;
            public static Move SpeedSwap;
            public static Move StoredPower;
            public static Move Synchronoise;
            public static Move Telekinesis;
            public static Move Teleport;
            public static Move Trick;
            public static Move TrickRoom;
            public static Move WonderRoom;
            public static Move ZenHeadbutt;
            #endregion

            #region Psychic Constructor
            static Psychic()
            {
                #region Z-Psychic Constructor
                ShatteredPsyche = new ZMove("Shattered Psyche", 100, null, null);
                ZAgility = new ZMove("Z-Agility", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZAllySwitch = new ZMove("Z-Ally Switch", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp2 }, new bool[] { true });
                ZAmnesia = new ZMove("Z-Amnesia", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZBarrier = new ZMove("Z-Barrier", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZCalmMind = new ZMove("Z-Calm Mind", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZCosmicPower = new ZMove("Z-Cosmic Power", 0, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp1 }, new bool[] { true });
                ZGravity = new ZMove("Z-Gravity", 0, new Effect[] { StatChanges.PositiveStatChanges.SpAtkUp1 }, new bool[] { true });
                ZGuardSplit = new ZMove("Z-Guard Split", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZGuardSwap = new ZMove("Z-Guard Swap", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZHealBlock = new ZMove("Z-Heal Block", 0, new Effect[] { StatChanges.PositiveStatChanges.SpAtkUp1 }, new bool[] { true });
                ZHealPulse = new ZMove("Z-Heal Pulse", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZHeartSwap = new ZMove("Z-Heart Swap", 0, new Effect[] { StatChanges.PositiveStatChanges.CritUp1 }, new bool[] { true });
                ZHypnosis = new ZMove("Z-Hypnosis", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZImprison = new ZMove("Z-Imprison", 0, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp2 }, new bool[] { true });
                ZInstruct = new ZMove("Z-Instruct", 0, new Effect[] { StatChanges.PositiveStatChanges.SpAtkUp1 }, new bool[] { true });
                ZKinesis = new ZMove("Z-Kinesis", 0, new Effect[] { StatChanges.PositiveStatChanges.EvasUp1 }, new bool[] { true });
                ZLightScreen = new ZMove("Z-Light Screen", 0, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp1 }, new bool[] { true });
                ZMagicCoat = new ZMove("Z-Magic Coat", 0, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp1 }, new bool[] { true });
                ZMagicRoom = new ZMove("Z-Magic Room", 0, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp1 }, new bool[] { true });
                ZMeditate = new ZMove("Z-Meditate", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1 }, new bool[] { true });
                ZMiracleEye = new ZMove("Z-Miracle Eye", 0, new Effect[] { StatChanges.PositiveStatChanges.SpAtkUp1 }, new bool[] { true });
                ZPowerSplit = new ZMove("Z-Power Split", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZPowerSwap = new ZMove("Z-Power Swap", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZPowerTrick = new ZMove("Z-Power Trick", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1 }, new bool[] { true });
                ZPsychicTerrain = new ZMove("Z-Psychic Terrain", 0, new Effect[] { StatChanges.PositiveStatChanges.SpAtkUp1 }, new bool[] { true });
                ZPsychoShift = new ZMove("Z-Psycho Shift", 0, new Effect[] { StatChanges.PositiveStatChanges.SpAtkUp2 }, new bool[] { true });
                ZReflect = new ZMove("Z-Reflect", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                ZRest = new ZMove("Z-Rest", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZRolePlay = new ZMove("Z-Role Play", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZSkillSwap = new ZMove("Z-Skill Swap", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZSpeedSwap = new ZMove("Z-Speed Swap", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZTelekinesis = new ZMove("Z-Telekinesis", 0, new Effect[] { StatChanges.PositiveStatChanges.SpAtkUp1 }, new bool[] { true });
                ZTeleport = new ZMove("Z-Teleport", 0, new Effect[] { Effects.HealingEffects.HPRestore.FullHPRestore }, new bool[] { true });
                ZTrick = new ZMove("Z-Trick", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZTrickRoom = new ZMove("Z-Trick Room", 0, new Effect[] { StatChanges.PositiveStatChanges.AccUp1 }, new bool[] { true });
                ZWonderRoom = new ZMove("Z-Wonder Room", 0, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp1 }, new bool[] { true });
                #endregion

                #region Psychic Constructor
                Agility = new Move("Agility", Type.Psychic, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { StatChanges.PositiveStatChanges.SpdUp2 }, new bool[] { true }, ZAgility, 0);
                AllySwitch = new Move("Ally Switch", Type.Psychic, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.SwitchPlacesAlly }, new bool[] { true }, ZAllySwitch, 0);
                Amnesia = new Move("Amnesia", Type.Psychic, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp2 }, new bool[] { true }, ZAmnesia, 0);
                Barrier = new Move("Barrier", Type.Psychic, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { StatChanges.PositiveStatChanges.DefUp2 }, new bool[] { true }, ZBarrier, 0);
                CalmMind = new Move("Calm Mind", Type.Psychic, 0, -1, 20, 'S', new double[] { 1, 1 }, new Effect[] { StatChanges.PositiveStatChanges.SpAtkUp1, StatChanges.PositiveStatChanges.SpDefUp1 }, new bool[] { true, true }, ZCalmMind, 0);
                Confusion = new Move("Confusion", Type.Psychic, 50, 1, 25, 'M', new double[] { 0.1 }, new Effect[] { Statuses.VolatileStatuses.Confused }, new bool[] { false }, ShatteredPsyche, 0);
                CosmicPower = new Move("Cosmic Power", Type.Psychic, 0, -1, 20, 'S', new double[] { 1, 1 }, new Effect[] { StatChanges.PositiveStatChanges.DefUp1, StatChanges.PositiveStatChanges.SpDefUp1 }, new bool[] { true, true }, ZCosmicPower, 0);
                DreamEater = new Move("Dream Eater", Type.Psychic, 100, 1, 15, 'M', new double[] { 1, 1, 1, 1 }, new Effect[] { Effects.GeneralEffects.DealsNoDmg, Flags.isAsleep, Effects.GeneralEffects.DealsDmg, Effects.HealingEffects.HPRestore.HealHalfDmgInflicted }, new bool[] { true, false, true, true }, new ZMove(ShatteredPsyche, 180), 0);
                Extrasensory = new Move("Extrasensory", Type.Psychic, 80, 1, 20, 'M', new double[] { 0.1 }, new Effect[] { Statuses.VolatileStatuses.Flinch }, new bool[] { false }, new ZMove(ShatteredPsyche, 160), 0);
                FutureSight = new Move("Future Sight", Type.Psychic, 120, 1, 10, 'M', new double[] { 1, 1 }, new Effect[] { Effects.GeneralEffects.Wait.TwoTurns, Effects.GeneralEffects.Ignore.AllProtection }, new bool[] { true, true }, new ZMove(ShatteredPsyche, 190), 0);
                Gravity = new Move("Gravity", Type.Psychic, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.Gravity }, new bool[] { false }, ZGravity, 0);
                GuardSplit = new Move("Guard Split", Type.Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Split.Guard }, new bool[] { true }, ZGuardSplit, 0);
                GuardSwap = new Move("Guard Swap", Type.Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Swap.DefSpDefBoosts }, new bool[] { false }, ZGuardSwap, 0);
                HealBlock = new Move("Heal Block", Type.Psychic, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.HealBlock }, new bool[] { false }, ZHealBlock, 0);
                HealPulse = new Move("Heal Pulse", Type.Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.HealingEffects.HPRestore.HalfHPRestore }, new bool[] { false }, ZHealPulse, 0);
                HealingWish = new Move("Healing Wish", Type.Psychic, 0, -1, 10, 'S', new double[] { 1, 1, 1 }, new Effect[] { Effects.GeneralEffects.SelfDestruction, Effects.HealingEffects.HPRestore.SwitchInFullHeal }, new bool[] { true, true }, UniqueZMoves.NO_EFFECT, 0);
                HeartStamp = new Move("Heart Stamp", Type.Psychic, 60, 1, 25, 'P', new double[] { 0.3 }, new Effect[] { Statuses.VolatileStatuses.Flinch }, new bool[] { false }, new ZMove(ShatteredPsyche, 120), 0);
                HeartSwap = new Move("Heart Swap", Type.Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Swap.StatChanges }, new bool[] { false }, ZHeartSwap, 0);
                HyperspaceHole = new Move("Hyperspace Hole", Type.Psychic, 80, 1, 5, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Ignore.Protection }, new bool[] { true }, new ZMove(ShatteredPsyche, 160), 0);
                Hypnosis = new Move("Hypnosis", Type.Psychic, 0, 0.6, 20, 'S', new double[] { 1 }, new Effect[] { Statuses.BaseStatuses.Sleep }, new bool[] { false }, ZHypnosis, 0);
                Imprison = new Move("Imprison", Type.Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.Imprison }, new bool[] { false }, ZImprison, 0);
                Instruct = new Move("Instruct", Type.Psychic, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.Instruct }, new bool[] { false }, ZInstruct, 0);
                Kinesis = new Move("Kinesis", Type.Psychic, 0, 0.8, 15, 'S', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.AccDwn1 }, new bool[] { false }, ZKinesis, 0);
                LightScreen = new Move("Light Screen", Type.Psychic, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.SpecialScreen }, new bool[] { true }, ZLightScreen, 0);
                LunarDance = new Move("Lunar Dance", Type.Psychic, 0, -1, 10, 'S', new double[] { 1, 1, 1 }, new Effect[] { Effects.GeneralEffects.SelfDestruction, Effects.HealingEffects.HPRestore.SwitchInFullHeal }, new bool[] { true, true }, UniqueZMoves.NO_EFFECT, 0);
                LusterPurge = new Move("Luster Purge", Type.Psychic, 70, 1, 5, 'M', new double[] { 0.5 }, new Effect[] { StatChanges.NegativeStatChanges.SpDefDwn1 }, new bool[] { false }, new ZMove(ShatteredPsyche, 140), 0);
                MagicCoat = new Move("Magic Coat", Type.Psychic, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.MagicCoat }, new bool[] { true }, ZMagicCoat, 0);
                MagicRoom = new Move("Magic Room", Type.Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.MagicRoom }, new bool[] { false }, ZMagicRoom, 0);
                Meditate = new Move("Meditate", Type.Psychic, 0, -1, 40, 'S', new double[] { 1 }, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1 }, new bool[] { true }, ZMeditate, 0);
                MiracleEye = new Move("Miracle Eye", Type.Psychic, 0, -1, 40, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.MiracleEye }, new bool[] { false }, ZMiracleEye, 0);
                MirrorCoat = new Move("Mirror Coat", Type.Psychic, 0, 1, 20, 'M', new double[] { 1, 1, 1 }, new Effect[] { Flags.isHitBySpMv, Effects.GeneralEffects.CopyLastMove, Effects.GeneralEffects.DoublePower}, new bool[] { true, false, true}, ShatteredPsyche, 0);
                MistBall = new Move("Mist Ball", Type.Psychic, 70, 1, 5, 'M', new double[] { 0.5 }, new Effect[] { StatChanges.NegativeStatChanges.SpAtkDwn1 }, new bool[] { false }, new ZMove(ShatteredPsyche, 140), 0);
                PowerSplit = new Move("Power Split", Type.Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Split.Power }, new bool[] { false }, ZPowerSplit, 0);
                PowerTrick = new Move("Power Trick", Type.Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Swap.AtkDef }, new bool[] { true }, ZPowerTrick, 0);
                Psybeam = new Move("Psybeam", Type.Psychic, 65, 1, 20, 'M', new double[] { 0.1 }, new Effect[] { Statuses.VolatileStatuses.Confused }, new bool[] { false }, new ZMove(ShatteredPsyche, 120), 0);
                psychic = new Move("Psychic", Type.Psychic, 90, 1, 10, 'M', new double[] { 0.1 }, new Effect[] { StatChanges.NegativeStatChanges.SpDefDwn1 }, new bool[] { false }, new ZMove(ShatteredPsyche, 175), 0);
                PsychicFangs = new Move("Psychic Fangs", Type.Psychic, 85, 1, 10, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.BreakScreens }, new bool[] { false }, new ZMove(ShatteredPsyche, 160), 0);
                PsychicTerrain = new Move("Psychic Terrain", Type.Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.Terrain.Psychic }, new bool[] { false }, ZPsychicTerrain, 0);
                PsychoBoost = new Move("Psycho Boost", Type.Psychic, 120, 0.9, 5, 'M', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.SpAtkDwn2 }, new bool[] { true }, new ZMove(ShatteredPsyche, 200), 0);
                PsychoCut = new Move("Psycho Cut", Type.Psychic, 70, 1, 20, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HighCrit }, new bool[] { true }, new ZMove(ShatteredPsyche, 140), 0);
                PsychoShift = new Move("Psycho Shift", Type.Psychic, 0, 0.9, 10, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.TransferStatus }, new bool[] { false }, ZPsychoShift, 0);
                Psyshock = new Move("Psyshock", Type.Psychic, 80, 1, 10, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.DmgBasedOnOppositeStat }, new bool[] { false }, new ZMove(ShatteredPsyche, 160), 0);
                Psystrike = new Move("Psystrike", Type.Psychic, 100, 1, 10, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.DmgBasedOnOppositeStat }, new bool[] { false }, new ZMove(ShatteredPsyche, 180), 0);
                Psywave = new Move("Psywave", Type.Psychic, -1, 1, 15, 'M', new double[] { 1 }, new Effect[] { Effects.RareEffects.Psywave }, new bool[] { false }, ShatteredPsyche, 0);
                Reflect = new Move("Reflect", Type.Psychic, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.AttackScreen }, new bool[] { true }, ZReflect, 0);
                Rest = new Move("Rest", Type.Psychic, 0, -1, 10, 'S', new double[] { 1, 1, 1, 1 }, new Effect[] { Effects.HealingEffects.HPRestore.FullHPRestore, Statuses.BaseStatuses.Sleep, Effects.GeneralEffects.Wait.TwoTurns, Effects.HealingEffects.StatusCures.CureSleep }, new bool[] { true, true, true, true }, ZRest, 0);
                RolePlay = new Move("Role Play", Type.Psychic, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.CopyAbility }, new bool[] { true }, ZRolePlay, 0);
                SkillSwap = new Move("Skill Swap", Type.Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Swap.Ability }, new bool[] { false }, ZSkillSwap, 0);
                SpeedSwap = new Move("Speed Swap", Type.Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Swap.Speed }, new bool[] { false }, ZSpeedSwap, 0);
                Synchronoise = new Move("Synchronoise", Type.Psychic, 120, 1, 15, 'M', new double[] { 1 }, new Effect[] { Effects.RareEffects.Synchronoise }, new bool[] { false }, new ZMove(ShatteredPsyche, 190), 0);
                Telekinesis = new Move("Telekinesis", Type.Psychic, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Telekinesis }, new bool[] { true }, ZTelekinesis, 0);
                Teleport = new Move("Teleport", Type.Psychic, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Switchout }, new bool[] { true }, ZTeleport, 0);
                Trick = new Move("Trick", Type.Psychic, 0, 1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Swap.Item }, new bool[] { false }, ZTrick, 0);
                TrickRoom = new Move("Trick Room", Type.Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.TrickRoom }, new bool[] { true }, ZTrickRoom, 0);
                WonderRoom = new Move("Wonder Room", Type.Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.WonderRoom }, new bool[] { false }, ZWonderRoom, 0);
                ZenHeadbutt = new Move("Zen Headbutt", Type.Psychic, 80, 0.9, 15, 'P', new double[] { 0.2 }, new Effect[] { Statuses.VolatileStatuses.Flinch }, new bool[] { false }, new ZMove(ShatteredPsyche, 160), 0);
                #endregion
            }
            #endregion
        }
        #endregion

        #region Rock
        /// <summary>
        /// All Rock moves
        /// </summary>
        public static class Rock
        {
            #region Rock Z-Moves
            public static ZMove ContinentalCrush;
            public static ZMove ZRockPolish;
            public static ZMove ZSandstorm;
            public static ZMove ZStealthRock;
            public static ZMove ZWideGuard;
            #endregion

            #region Rock Moves
            public static Move Accelerock;
            public static Move AncientPower;
            public static Move DiamondStorm;
            public static Move HeadSmash;
            public static Move PowerGem;
            public static Move RockBlast;
            public static Move RockPolish;
            public static Move RockSlide;
            public static Move RockThrow;
            public static Move RockTOmb;
            public static Move RockWrecker;
            public static Move Rollout;
            public static Move Sandstorm;
            public static Move SmackDown;
            public static Move StealthRock;
            public static Move StoneEdge;
            public static Move WideGuard;
            #endregion

            #region Rock Constructor
            static Rock()
            {
                #region Z-Rock Constructor
                ContinentalCrush = new ZMove("Continental Crush", 100, null, null);
                ZRockPolish = new ZMove("Z-Rock Polish", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZSandstorm = new ZMove("Z-Sandstorm", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZStealthRock = new ZMove("Z-Stealth Rock", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                ZWideGuard = new ZMove("Z-Wide Guard", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                #endregion

                #region Rock Constructor
                Accelerock = new Move("Accelerock", Type.Rock, 40, 1, 20, 'P', null, null, null, ContinentalCrush, 1);
                AncientPower = new Move("Ancient Power", Type.Rock, 60, 1, 5, 'M', new double[] { 0.1, 0.1, 0.1, 0.1, 0.1 }, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1, StatChanges.PositiveStatChanges.DefUp1, StatChanges.PositiveStatChanges.SpAtkUp1, StatChanges.PositiveStatChanges.SpDefUp1, StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true, true, true, true, true }, new ZMove(ContinentalCrush, 120), 0);
                DiamondStorm = new Move("Diamond Storm", Type.Rock, 100, 0.95, 5, 'P', new double[] { 0.5 }, new Effect[] { StatChanges.PositiveStatChanges.DefUp2 }, new bool[] { true }, new ZMove(ContinentalCrush, 180), 0);
                HeadSmash = new Move("Head Smash", Type.Rock, 150, 0.8, 5, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Recoil.HalfDmgDealt }, new bool[] { true }, new ZMove(ContinentalCrush, 200), 0);
                PowerGem = new Move("Power Gem", Type.Rock, 80, 1, 20, 'M', null, null, null, new ZMove(ContinentalCrush, 160), 0);
                RockBlast = new Move("Rock Blast", Type.Rock, 25, 0.9, 10, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HitsMultipleTimes }, new bool[] { false }, new ZMove(ContinentalCrush, 140), 0);
                RockPolish = new Move("Rock Polish", Type.Rock, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { StatChanges.PositiveStatChanges.SpdUp2 }, new bool[] { true }, ZRockPolish, 0);
                RockSlide = new Move("Rock Slide", Type.Rock, 75, 0.9, 10, 'P', new double[] { 0.3 }, new Effect[] { Statuses.VolatileStatuses.Flinch }, new bool[] { false }, new ZMove(ContinentalCrush, 140), 0);
                RockThrow = new Move("Rock Throw", Type.Rock, 50, 0.9, 15, 'P', null, null, null, ContinentalCrush, 0);
                RockWrecker = new Move("Rock Wrecker", Type.Rock, 150, 0.9, 5, 'P', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Recharging }, new bool[] { true }, new ZMove(ContinentalCrush, 200), 0);
                Rollout = new Move("Rollotu", Type.Rock, 30, 0.9, 20, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.IncrementalDamageMux }, new bool[] { true }, ContinentalCrush, 0);
                Sandstorm = new Move("Sandstorm", Type.Rock, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Weather.Sandstorm }, new bool[] { false }, ZSandstorm, 0);
                SmackDown = new Move("Smack Down", Type.Rock, 50, 1, 15, 'P', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Grounded }, new bool[] { false }, ContinentalCrush, 0);
                StealthRock = new Move("Stealth Rock", Type.Rock, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.SetEntryHazards.StealthRock }, new bool[] { false }, ZStealthRock, 0);
                StoneEdge = new Move("Stone Edge", Type.Rock, 100, 0.8, 5, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HighCrit }, new bool[] { true }, new ZMove(ContinentalCrush, 180), 0);
                WideGuard = new Move("Wide Guard", Type.Rock, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.WideGuard }, new bool[] { true }, ZWideGuard, 0);
                #endregion
            }
            #endregion
        }
        #endregion

        #region Bug
        /// <summary>
        /// All Bug moves
        /// </summary>
        public static class Bug
        {
            #region Bug Z-Moves
            public static ZMove SavageSpinOut;
            public static ZMove ZDefendOrder;
            public static ZMove ZHealOrder;
            public static ZMove ZPowder;
            public static ZMove ZQuiverDance;
            public static ZMove ZRagePowder;
            public static ZMove ZSpiderWeb;
            public static ZMove ZStickyWeb;
            public static ZMove ZStringShot;
            public static ZMove ZTailGlow;
            #endregion

            #region Bug Moves
            public static Move AttackOrder;
            public static Move BugBite;
            public static Move BugBuzz;
            public static Move DefendOrder;
            public static Move FellStinger;
            public static Move FirstImpression;
            public static Move FuryCutter;
            public static Move HealOrder;
            public static Move Infestation;
            public static Move LeechLife;
            public static Move Lunge;
            public static Move Megahorn;
            public static Move PinMissile;
            public static Move PollenPuff;
            public static Move Powder;
            public static Move QuiverDance;
            public static Move RagePowder;
            public static Move SignalBeam;
            public static Move SilverWind;
            public static Move SpiderWeb;
            public static Move Steamroller;
            public static Move StickyWeb;
            public static Move StringShot;
            public static Move StruggleBug;
            public static Move TailGlow;
            public static Move Twineedle;
            public static Move UTurn;
            public static Move XScissor;
            #endregion

            #region Bug Constructor
            static Bug()
            {
                #region Z-Bug Constructor
                SavageSpinOut = new ZMove("Savage Spin-Out", 100, null, null);
                ZDefendOrder = new ZMove("Z-Defend Order", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                ZHealOrder = new ZMove("Z-Heal Order", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZPowder = new ZMove("Z-Powder", 0, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp2 }, new bool[] { true });
                ZQuiverDance = new ZMove("Z-Quiver Dance", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZRagePowder = new ZMove("Z-Rage Powder", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZSpiderWeb = new ZMove("Z-Spider Web", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });
                ZStickyWeb = new ZMove("Z-Sticky Web", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZStringShot = new ZMove("Z-String Shot", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZTailGlow = new ZMove("Z-Tail Glow", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                #endregion

                #region Bug Constructor
                AttackOrder = new Move("Attack Order", Type.Bug, 90, 1, 15, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HighCrit }, new bool[] { true }, new ZMove(SavageSpinOut, 175), 0);
                BugBite = new Move("Bug Bite", Type.Bug, 60, 1, 20, 'P', new double[] { 1 }, new Effect[] { Flags.ifTgtHoldBerry, Effects.GeneralEffects.ConsumeItem }, new bool[] { false, false }, new ZMove(SavageSpinOut, 120), 0);
                BugBuzz = new Move("Bug Buzz", Type.Bug, 90, 1, 10, 'M', new double[] { 0.1 }, new Effect[] { StatChanges.NegativeStatChanges.SpDefDwn1 }, new bool[] { false }, new ZMove(SavageSpinOut, 175), 0);
                DefendOrder = new Move("Defend Order", Type.Bug, 0, -1, 10, 'S', new double[] { 1, 1 }, new Effect[] { StatChanges.PositiveStatChanges.DefUp1, StatChanges.PositiveStatChanges.SpDefUp1 }, new bool[] { true, true }, ZDefendOrder, 0);
                FellStinger = new Move("Fell Stinger", Type.Bug, 50, 1, 25, 'P', new double[] { 1, 1 }, new Effect[] { Flags.ifTgtFaints, StatChanges.PositiveStatChanges.AtkUp2 }, new bool[] { false, true }, SavageSpinOut, 0);
                FirstImpression = new Move("First Impression", Type.Bug, 90, 1, 10, 'P', new double[] { 1, 1, 1 }, new Effect[] { Effects.GeneralEffects.DealsNoDmg, Flags.ifFirstTurn, Effects.GeneralEffects.DealsDmg }, new bool[] { true, true, true }, new ZMove(SavageSpinOut, 175), 0);
                FuryCutter = new Move("Fury Cutter", Type.Bug, 40, 0.95, 20, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.FuryCutter }, new bool[] { true }, SavageSpinOut, 0);
                HealOrder = new Move("Heal Order", Type.Bug, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.HealingEffects.HPRestore.HalfHPRestore }, new bool[] { true }, ZHealOrder, 0);
                Infestation = new Move("Infestation", Type.Bug, 20, 1, 20, 'M', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Bound }, new bool[] { false }, SavageSpinOut, 0);
                LeechLife = new Move("Leech Life", Type.Bug, 80, 1, 10, 'P', new double[] { 1 }, new Effect[] { Effects.HealingEffects.HPRestore.HealHalfDmgInflicted }, new bool[]{true}, new ZMove(SavageSpinOut, 160), 0);
                Lunge = new Move("Lunge", Type.Bug, 80, 1, 15, 'P', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.AtkDwn1 }, new bool[] { false }, new ZMove(SavageSpinOut, 160), 0);
                Megahorn = new Move("Megahorn", Type.Bug, 120, 0.85, 10, 'P', null, null, null, new ZMove(SavageSpinOut, 190), 0);
                PinMissile = new Move("Pin Missile", Type.Bug, 25, 0.85, 20, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HitsMultipleTimes }, new bool[] { false }, new ZMove(SavageSpinOut, 140), 0);
                PollenPuff = new Move("Pollen Puff", Type.Bug, 90, 1, 15, 'M', new double[] { 1, 1, 1 }, new Effect[] { Flags.tgtIsAlly, Effects.GeneralEffects.DealsNoDmg, Effects.HealingEffects.HPRestore.HalfHPRestore }, new bool[] { false, true, false }, new ZMove(SavageSpinOut, 175), 0);
                Powder = new Move("Powder", Type.Bug, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Powdered }, new bool[] { false }, ZPowder, 1);
                QuiverDance = new Move("Quiver Dance", Type.Bug, 0, -1, 20, 'S', new double[] { 1, 1, 1 }, new Effect[] { StatChanges.PositiveStatChanges.SpAtkUp1, StatChanges.PositiveStatChanges.SpDefUp1, StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true, true, true }, ZQuiverDance, 0);
                RagePowder = new Move("Rage Powder", Type.Bug, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.CenterofAttention }, new bool[] { true }, ZRagePowder, 2);
                SignalBeam = new Move("Signal Beam", Type.Bug, 75, 1, 15, 'M', new double[] { 0.1 }, new Effect[] { Statuses.VolatileStatuses.Confused }, new bool[] { false }, new ZMove(SavageSpinOut, 140), 0);
                SilverWind = new Move("Silver Wind", Type.Bug, 60, 1, 5, 'M', new double[] { 0.1, 0.1, 0.1, 0.1, 0.1 }, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1, StatChanges.PositiveStatChanges.DefUp1, StatChanges.PositiveStatChanges.SpAtkUp1, StatChanges.PositiveStatChanges.SpDefUp1, StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true, true, true, true, true }, new ZMove(SavageSpinOut, 120), 0);
                SpiderWeb = new Move("Spider Web", Type.Bug, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.LegHold }, new bool[] { false }, ZSpiderWeb, 0);
                Steamroller = new Move("Steamroller", Type.Bug, 65, 1, 20, 'P', new double[] { 0.3 }, new Effect[] { Statuses.VolatileStatuses.Flinch }, new bool[] { false }, new ZMove(SavageSpinOut, 120), 0);
                StickyWeb = new Move("Sticky Web", Type.Bug, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.SetEntryHazards.StickyWeb }, new bool[] { false }, ZStickyWeb, 0);
                StringShot = new Move("String Shot", Type.Bug, 0, 0.95, 40, 'S', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.SpdDwn1 }, new bool[] { false }, ZStringShot, 0);
                StruggleBug = new Move("Struggle Bug", Type.Bug, 50, 1, 20, 'M', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.SpAtkDwn1 }, new bool[] { false }, SavageSpinOut, 0);
                TailGlow = new Move("Tail Glow", Type.Bug, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { StatChanges.PositiveStatChanges.AtkUp3 }, new bool[] { true }, ZTailGlow, 0);
                Twineedle = new Move("Twineedle", Type.Bug, 25, 1, 20, 'P', new double[] { 0.2, 1 }, new Effect[] { Statuses.BaseStatuses.Poisoned, Effects.GeneralEffects.HitTwiceOneTurn }, new bool[] { false, false }, SavageSpinOut, 0);
                UTurn = new Move("U-Turn", Type.Bug, 70, 1, 20, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Switchout }, new bool[] { true }, new ZMove(SavageSpinOut, 140), 0);
                XScissor = new Move("X-Scissor", Type.Bug, 80, 1, 15, 'P', null, null, null, new ZMove(SavageSpinOut, 160), 0);
                
                #endregion
            }
            #endregion
        }
        #endregion

        #region Dragon
        public static class Dragon
        {
            #region Dragon Z-Moves
            public static ZMove DevastatingDrake;
            public static ZMove ZDragonDance;
            #endregion

            #region Dragon Moves
            public static Move ClangingScales;
            public static Move CoreEnforcer;
            public static Move DracoMeteor;
            public static Move DragonBreath;
            public static Move DragonClaw;
            public static Move DragonDance;
            public static Move DragonHammer;
            public static Move DragonPulse;
            public static Move DragonRage;
            public static Move DragonRush;
            public static Move DragonTail;
            public static Move DualChop;
            public static Move Outrage;
            public static Move RoarOfTime;
            public static Move SpacialRend;
            public static Move Twister;
            #endregion

            #region Dragon Constructor
            static Dragon()
            {
                #region Z-Dragon Constructor
                DevastatingDrake = new ZMove("Devastating Drake", 100, null, null);
                ZDragonDance = new ZMove("Z-Dragon Dance", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                #endregion

                #region Dragon Constructor
                ClangingScales = new Move("Clanging Scales", Type.Dragon, 110, 1, 5, 'M', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.DefDwn1 }, new bool[] { true }, new ZMove(DevastatingDrake, 185), 0);
                CoreEnforcer = new Move("Core Enforcer", Type.Dragon, 100, 1, 10, 'M', null, null, null, new ZMove(DevastatingDrake, 140), 0);
                DracoMeteor = new Move("Draco Meteor", Type.Dragon, 130, 0.9, 5, 'M', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.SpAtkDwn2 }, new bool[] { true }, new ZMove(DevastatingDrake, 195), 0);
                DragonBreath = new Move("Dragon Breath", Type.Dragon, 60, 1, 20, 'M', new double[] { 0.3 }, new Effect[] { Statuses.BaseStatuses.Paralysis }, new bool[] { false }, new ZMove(DevastatingDrake, 120), 0);
                DragonClaw = new Move("Dragon Claw", Type.Dragon, 80, 1, 15, 'P', null, null, null, new ZMove(DevastatingDrake, 160), 0);
                DragonDance = new Move("Dragon Dance", Type.Dragon, 0, -1, 20, 'S', new double[] { 1, 1 }, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1, StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true, true }, ZDragonDance, 0);
                DragonHammer = new Move("Dragon Hammer", Type.Dragon, 90, 1, 15, 'P', null, null, null, new ZMove(DevastatingDrake, 175), 0);
                DragonPulse = new Move("Dragon Pulse", Type.Dragon, 85, 1, 10, 'M', null, null, null, new ZMove(DevastatingDrake, 160), 0);
                DragonRage = new Move("Dragon Rage", Type.Dragon, 40, 1, 10, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.DoBPInDmg }, new bool[] { false }, DevastatingDrake, 0);
                DragonRush = new Move("Dragon Rush", Type.Dragon, 100, 0.75, 10, 'P', new double[] { 0.2 }, new Effect[] { Statuses.VolatileStatuses.Flinch }, new bool[] { false }, new ZMove(DevastatingDrake, 180), 0);
                DragonTail = new Move("Dragon Tail", Type.Dragon, 60, 0.9, 10, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Switchout }, new bool[] { false }, new ZMove(DevastatingDrake, 120), 0);
                DualChop = new Move("Dual Chop", Type.Dragon, 40, 0.9, 15, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HitTwiceOneTurn }, new bool[] { true }, DevastatingDrake, 0);
                Outrage = new Move("Outrage", Type.Dragon, 120, 1, 10, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.Thrash }, new bool[] { true }, new ZMove(DevastatingDrake, 190), 0);
                RoarOfTime = new Move("Roar of Time", Type.Dragon, 150, 0.9, 5, 'M', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Recharging }, new bool[] { true }, new ZMove(DevastatingDrake, 200), 0);
                SpacialRend = new Move("Spacial Rend", Type.Dragon, 100, 0.95, 5, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HighCrit }, new bool[] { true }, new ZMove(DevastatingDrake, 180), 0);
                Twister = new Move("Twister", Type.Dragon, 40, 1, 20, 'M', new double[] { 1, 1 }, new Effect[] { Flags.ifInAir, Effects.GeneralEffects.DoublePower }, new bool[] { false, true }, DevastatingDrake, 0);
                #endregion
            }
            #endregion
        }
        #endregion

        #region Ghost
        public static class Ghost
        {
            #region Ghost Z-Moves
            public static ZMove NeverEndingNightmare;
            public static ZMove ZConfuseRay;
            public static ZMove ZDestinyBond;
            public static ZMove ZGhostCurse;
            public static ZMove ZGrudge;
            public static ZMove ZNightmare;
            public static ZMove ZNonGhostCurse;
            public static ZMove ZSpite;
            public static ZMove ZTrickOrTreat;
            #endregion

            #region Ghost Moves
            public static Move Astonish;
            public static Move ConfuseRay;
            public static Move DestinyBond;
            public static Move GhostCurse;
            public static Move Grudge;
            public static Move Hex;
            public static Move Lick;
            public static Move MoongeistBeam;
            public static Move NightShade;
            public static Move Nightmare;
            public static Move NonGhostCurse;
            public static Move OminousWind;
            public static Move PhantomForce;
            public static Move ShadowBall;
            public static Move ShadowBone;
            public static Move ShadowClaw;
            public static Move ShadowForce;
            public static Move ShadowPunch;
            public static Move ShadowSneak;
            public static Move SpectralThief;
            public static Move SpiritShackle;
            public static Move Spite;
            public static Move TrickOrTreat;
            #endregion

            #region Ghost Constructor
            static Ghost()
            {
                #region Z-Ghost Constructor
                NeverEndingNightmare = new ZMove("Never-Ending Nightmare", 100, null, null);
                ZConfuseRay = new ZMove("Z-Confuse Ray", 0, new Effect[] { StatChanges.PositiveStatChanges.SpAtkUp1 }, new bool[] { true });
                ZDestinyBond = new ZMove("Z-Destiny Bond", 0, new Effect[] { Statuses.VolatileStatuses.CenterofAttention }, new bool[] { true });
                ZGhostCurse = new ZMove("Z-Curse", 0, new Effect[] { Effects.HealingEffects.HPRestore.FullHPRestore }, new bool[] { true });
                ZGrudge = new ZMove("Z-Grudge", 0, new Effect[] { Statuses.VolatileStatuses.CenterofAttention }, new bool[] { true });
                ZNightmare = new ZMove("Z-Nightmare", 0, new Effect[] { StatChanges.PositiveStatChanges.SpAtkUp1 }, new bool[] { true });
                ZNonGhostCurse = new ZMove("Z-Curse", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1 }, new bool[] { true });
                ZSpite = new ZMove("Z-Spite", 0, new Effect[] { Effects.HealingEffects.HPRestore.FullHPRestore }, new bool[] { true });
                ZTrickOrTreat = new ZMove("Z-Trick-or-Treat", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1, StatChanges.PositiveStatChanges.DefUp1, StatChanges.PositiveStatChanges.SpAtkUp1, StatChanges.PositiveStatChanges.SpDefUp1, StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true, true, true, true, true });
                #endregion

                #region Ghost Constructor
                Astonish = new Move("Astonish", Type.Ghost, 30, 1, 15, 'P', new double[] { 0.3 }, new Effect[] { Statuses.VolatileStatuses.Flinch }, new bool[] { false }, NeverEndingNightmare, 0);
                ConfuseRay = new Move("Confuse Ray", Type.Ghost, 0, 1, 10, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Confused }, new bool[] { false }, ZConfuseRay, 0);
                DestinyBond = new Move("Destiny Bond", Type.Ghost, 0, -1, 5, 'S', new double[] { 1, 1 }, new Effect[] { Statuses.VolatileStatuses.Destiny, Statuses.VolatileStatuses.Destiny }, new bool[] { true, false }, ZDestinyBond, 0);
                GhostCurse = new Move("Curse", Type.Ghost, 0, -1, 10, 'S', new double[] { 1, 1 }, new Effect[] { Effects.GeneralEffects.Recoil.HalfMaxHP, Statuses.VolatileStatuses.Curse }, new bool[] { true, false }, ZGhostCurse, 0);
                Grudge = new Move("Grudge", Type.Ghost, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Grudge }, new bool[] { false }, ZGrudge, 0);
                Hex = new Move("Hex", Type.Ghost, 65, 1, 10, 'M', new double[] { 1, 1 }, new Effect[] { Flags.ifAfflicted, Effects.GeneralEffects.DoublePower }, new bool[] { false, true }, new ZMove(NeverEndingNightmare, 160), 0);
                Lick = new Move("Lick", Type.Ghost, 30, 1, 30, 'P', new double[] { 0.3 }, new Effect[] { Statuses.BaseStatuses.Paralysis }, new bool[] { false }, NeverEndingNightmare, 0);
                MoongeistBeam = new Move("Moongeist Beam", Type.Ghost, 100, 1, 5, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Ignore.Ability }, new bool[] { false }, new ZMove(NeverEndingNightmare, 180), 0);
                Nightmare = new Move("Nightmare", Type.Ghost, 0, 1, 15, 'M', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Nightmare }, new bool[] { false }, ZNightmare, 0);
                NightShade = new Move("Night Shade", Type.Ghost, -1, 1, 15, 'M', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.DealsDmgEqualToLvl }, new bool[] { true }, NeverEndingNightmare, 0);
                NonGhostCurse = new Move("Curse", Type.Ghost, 0, -1, 10, 'S', new double[] { 1, 1, 1 }, new Effect[] { StatChanges.NegativeStatChanges.SpdDwn1, StatChanges.PositiveStatChanges.AtkUp1, StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true, true, true }, ZNonGhostCurse, 0);
                OminousWind = new Move("Ominous Wind", Type.Ghost, 60, 1, 5, 'M', new double[] { 0.1, 0.1, 0.1, 0.1, 0.1 }, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1, StatChanges.PositiveStatChanges.DefUp1, StatChanges.PositiveStatChanges.SpAtkUp1, StatChanges.PositiveStatChanges.SpDefUp1, StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true, true, true, true, true }, new ZMove(NeverEndingNightmare, 120), 0);
                PhantomForce = new Move("Phantom Force", Type.Ghost, 90, 1, 10, 'P', new double[] { 1, 1 }, new Effect[] { Effects.GeneralEffects.Wait.OneTurn, Effects.GeneralEffects.Ignore.Protection }, new bool[] { true, true }, new ZMove(NeverEndingNightmare, 175), 0);
                ShadowBall = new Move("Shadow Ball", Type.Ghost, 80, 1, 15, 'M', new double[] { 0.2 }, new Effect[] { StatChanges.NegativeStatChanges.SpDefDwn1 }, new bool[] { false }, new ZMove(NeverEndingNightmare, 160), 0);
                ShadowBone = new Move("Shadow Bone", Type.Ghost, 85, 1, 10, 'P', new double[] { 0.2 }, new Effect[] { StatChanges.NegativeStatChanges.DefDwn1 }, new bool[] { false }, new ZMove(NeverEndingNightmare, 160), 0);
                ShadowClaw = new Move("Shadow Claw", Type.Ghost, 70, 1, 15, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HighCrit }, new bool[] { true }, new ZMove(NeverEndingNightmare, 140), 0);
                ShadowForce = new Move("Shadow Force", Type.Ghost, 120, 1, 5, 'P', new double[] { 1, 1 }, new Effect[] { Effects.GeneralEffects.Wait.OneTurn, Effects.GeneralEffects.Ignore.Protection }, new bool[] { true, true }, new ZMove(NeverEndingNightmare, 190), 0);
                ShadowPunch = new Move("Shadow Punch", Type.Ghost, 60, -1, 20, 'P', null, null, null, new ZMove(NeverEndingNightmare, 120), 0);
                ShadowSneak = new Move("Shadow Sneak", Type.Ghost, 40, 1, 30, 'P', null, null, null, NeverEndingNightmare, 1);
                SpectralThief = new Move("Spectral Thief", Type.Ghost, 90, 1, 10, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.TransferStatBoosts }, new bool[] { false }, new ZMove(NeverEndingNightmare, 175), 0);
                SpiritShackle = new Move("Spirit Shackle", Type.Ghost, 80, 1, 10, 'P', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.LegHold }, new bool[] { false }, new ZMove(NeverEndingNightmare, 160), 0);
                Spite = new Move("Spite", Type.Ghost, 0, 1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.ReduceLastMoveBy4PP }, new bool[] { false }, ZSpite, 0);
                TrickOrTreat = new Move("Trick-or-Treat", Type.Ghost, 0, 1, 20, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.AddTypeToTarget.Ghost }, new bool[] { false }, ZTrickOrTreat, 0);
                #endregion
            }
            #endregion
        }
        #endregion

        #region Dark
        public static class Dark
        {
            #region Dark Z-Moves
            public static ZMove BlackHoleEclipse;
            public static ZMove ZDarkVoid;
            public static ZMove ZEmbargo;
            public static ZMove ZFakeTears;
            public static ZMove ZFlatter;
            public static ZMove ZHoneClaws;
            public static ZMove ZMemento;
            public static ZMove ZNastyPlot;
            public static ZMove ZPartingShot;
            public static ZMove ZQuash;
            public static ZMove ZSnatch;
            public static ZMove ZSwitcheroo;
            public static ZMove ZTaunt;
            public static ZMove ZTopsyTurvy;
            public static ZMove ZTorment;
            #endregion

            #region Dark Moves
            public static Move Assurance;
            public static Move BeatUp;
            public static Move Bite;
            public static Move BrutalSwing;
            public static Move Crunch;
            public static Move DarkPulse;
            public static Move DarkVoid;
            public static Move DarkestLariat;
            public static Move Embargo;
            public static Move FakeTears;
            public static Move FeintAttack;
            public static Move Flatter;
            public static Move Fling;
            public static Move FoulPlay;
            public static Move HoneClaws;
            public static Move HyperspaceFury;
            public static Move KnockOff;
            public static Move Memento;
            public static Move NastyPlot;
            public static Move NightDaze;
            public static Move NightSlash;
            public static Move PartingShot;
            public static Move Payback;
            public static Move PowerTrip;
            public static Move Punishment;
            public static Move Pursuit;
            public static Move Quash;
            public static Move Snarl;
            public static Move Snatch;
            public static Move SuckerPunch;
            public static Move Switcheroo;
            public static Move Taunt;
            public static Move Thief;
            public static Move ThroatChop;
            public static Move TopsyTurvy;
            public static Move Torment;
            #endregion

            #region Dark Constructor
            static Dark()
            {
                BlackHoleEclipse = new ZMove("Black Hole Eclipse", 100, null, null);
                ZDarkVoid = new ZMove("Z-Dark Void", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZEmbargo = new ZMove("Z-Embargo", 0, new Effect[] { StatChanges.PositiveStatChanges.SpAtkUp1 }, new bool[] { true });
                ZFakeTears = new ZMove("Z-Fake Tears", 0, new Effect[] { StatChanges.PositiveStatChanges.SpAtkUp1 }, new bool[] { true });
                ZFlatter = new ZMove("Z-Flatter", 0, new Effect[] { StatChanges.PositiveStatChanges.SpDefUp1 }, new bool[] { true });
                ZHoneClaws = new ZMove("Z-Hone Claws", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1 }, new bool[] { true });
                ZMemento = new ZMove("Z-Memento", 0, new Effect[] { Effects.HealingEffects.HPRestore.SwitchInFullHeal }, new bool[] { false });
                ZNastyPlot = new ZMove("Z-Nasty Plot", 0, new Effect[] { Effects.HealingEffects.StatAlterations.ResetStatDrops }, new bool[] { true });
                ZPartingShot = new ZMove("Z-Parting Shot", 0, new Effect[] { Effects.HealingEffects.HPRestore.SwitchInFullHeal }, new bool[] { false });
                ZQuash = new ZMove("Z-Quash", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp1 }, new bool[] { true });
                ZSnatch = new ZMove("Z-Snatch", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp2 }, new bool[] { true });
                ZSwitcheroo = new ZMove("Z-Switcheroo", 0, new Effect[] { StatChanges.PositiveStatChanges.SpdUp2 }, new bool[] { true });
                ZTaunt = new ZMove("Z-Taunt", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1 }, new bool[] { true });
                ZTopsyTurvy = new ZMove("Z-Topsy-Turvy", 0, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1 }, new bool[] { true });
                ZTorment = new ZMove("Z-Torment", 0, new Effect[] { StatChanges.PositiveStatChanges.DefUp1 }, new bool[] { true });

                Assurance = new Move("Assurance", Type.Dark, 60, 1, 10, 'P', new double[] { 1 }, new Effect[] { Flags.ifTakenDmgThisTurn, Effects.GeneralEffects.DoublePower }, new bool[] { false, true }, new ZMove(BlackHoleEclipse, 120), 0);
                BeatUp = new Move("Beat Up", Type.Dark, -1, 1, 30, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.BeatUp }, new bool[] { false }, BlackHoleEclipse, 0);
                Bite = new Move("Bite", Type.Dark, 60, 1, 25, 'P', new double[] { 0.3 }, new Effect[] { Statuses.VolatileStatuses.Flinch }, new bool[] { false }, new ZMove(BlackHoleEclipse, 120), 0);
                BrutalSwing = new Move("Brutal Swing", Type.Dark, 60, 1, 20, 'P', null, null, null, new ZMove(BlackHoleEclipse, 120), 0);
                Crunch = new Move("Crunch", Type.Dark, 80, 1, 15, 'P', new double[] { 0.2 }, new Effect[] { StatChanges.NegativeStatChanges.DefDwn1 }, new bool[] { false }, new ZMove(BlackHoleEclipse, 160), 0);
                DarkPulse = new Move("Dark Pulse", Type.Dark, 80, 1, 15, 'M', new double[] { 0.2 }, new Effect[] { Statuses.VolatileStatuses.Flinch }, new bool[] { false }, new ZMove(BlackHoleEclipse, 160), 0);
                DarkVoid = new Move("Dark Void", Type.Dark, 0, 0.5, 10, 'S', new double[] { 1, 1 }, new Effect[] { Effects.GeneralEffects.HitAllFoes, Statuses.BaseStatuses.Sleep }, new bool[] { false, false }, ZDarkVoid, 0);
                DarkestLariat = new Move("Darkest Lariat", Type.Dark, 85, 1, 10, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.IgnoreStatChanges }, new bool[] { false }, new ZMove(BlackHoleEclipse, 160), 0);
                Embargo = new Move("Embargo", Type.Dark, 0, 1, 15, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Embargo }, new bool[] { false }, ZEmbargo, 0);
                FakeTears = new Move("Fake Tears", Type.Dark, 0, 1, 20, 'S', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.SpDefDwn2 }, new bool[] { false }, ZFakeTears, 0);
                FeintAttack = new Move("Feint Attack", Type.Dark, 60, -1, 20, 'P', null, null, null, new ZMove(BlackHoleEclipse, 120), 0);
                Flatter = new Move("Flatter", Type.Dark, 0, 1, 15, 'S', new double[] { 1, 1 }, new Effect[] { Statuses.VolatileStatuses.Confused, StatChanges.PositiveStatChanges.SpAtkUp2 }, new bool[] { false, false }, ZFlatter, 0);
                Fling = new Move("Fling", Type.Dark, -1, 1, 10, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.Fling }, new bool[] { true }, BlackHoleEclipse, 0);
                FoulPlay = new Move("Foul Play", Type.Dark, 95, 1, 15, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.UseTgtAtk }, new bool[] { false }, new ZMove(BlackHoleEclipse, 175), 0);
                HoneClaws = new Move("Hone Claws", Type.Dark, 0, -1, 15, 'S', new double[] { 1, 1 }, new Effect[] { StatChanges.PositiveStatChanges.AtkUp1, StatChanges.PositiveStatChanges.AccUp1 }, new bool[] { true, true }, ZHoneClaws, 0);
                HyperspaceFury = new Move("Hyperspace Fury", Type.Dark, 100, -1, 5, 'P', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.DefDwn1 }, new bool[] { true }, new ZMove(BlackHoleEclipse, 180), 0);
                KnockOff = new Move("Knock Off", Type.Dark, 65, 1, 20, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.KnockOff }, new bool[] { false }, new ZMove(BlackHoleEclipse, 120), 0);
                Memento = new Move("Memento", Type.Dark, 0, 1, 10, 'S', new double[] { 1, 1, 1 }, new Effect[] { Effects.GeneralEffects.SelfDestruction, StatChanges.NegativeStatChanges.AtkDwn2, StatChanges.NegativeStatChanges.SpAtkDwn2 }, new bool[] { true, false, false }, ZMemento, 0);
                NastyPlot = new Move("Nasty Plot", Type.Dark, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { StatChanges.PositiveStatChanges.SpAtkUp2 }, new bool[] { true }, ZNastyPlot, 0);
                NightDaze = new Move("Night Daze", Type.Dark, 85, 0.95, 10, 'M', new double[] { 0.4 }, new Effect[] { StatChanges.NegativeStatChanges.AccDwn1 }, new bool[] { true }, new ZMove(BlackHoleEclipse, 160), 0);
                NightSlash = new Move("Night Slash", Type.Dark, 70, 1, 15, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.HighCrit }, new bool[] { true }, new ZMove(BlackHoleEclipse, 140), 0);
                PartingShot = new Move("Parting Shot", Type.Dark, 0, 1, 20, 'S', new double[] { 1, 1, 1 }, new Effect[] { StatChanges.NegativeStatChanges.AtkDwn1, StatChanges.NegativeStatChanges.SpAtkDwn1, Effects.GeneralEffects.Switchout }, new bool[] { false, false, true }, ZPartingShot, 0);
                Payback = new Move("Payback", Type.Dark, 50, 1, 10, 'P', new double[] { 1, 1 }, new Effect[] { Flags.isHitBeforeNextMove, Effects.GeneralEffects.DoublePower }, new bool[] { true, true }, BlackHoleEclipse, 0);
                PowerTrip = new Move("Power Trip", Type.Dark, 20, 1, 10, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.PowerTrip }, new bool[] { true }, new ZMove(BlackHoleEclipse, 160), 0);
                Punishment = new Move("Punishment", Type.Dark, -1, 1, 5, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.Punishment }, new bool[] { false }, new ZMove(BlackHoleEclipse, 160), 0);
                Pursuit = new Move("Pursuit", Type.Dark, 40, 1, 20, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.Pursuit }, new bool[] { false }, BlackHoleEclipse, 0);
                Quash = new Move("Quash", Type.Dark, 0, 1, 15, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.TgtMvLastThisTurn }, new bool[] { false }, ZQuash, 0);
                Snarl = new Move("Snarl", Type.Dark, 55, 0.95, 15, 'M', new double[] { 1 }, new Effect[] { StatChanges.NegativeStatChanges.SpAtkDwn1 }, new bool[] { false }, BlackHoleEclipse, 0);
                Snatch = new Move("Snatch", Type.Dark, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.CopyNextMove }, new bool[] { false }, ZSnatch, 0);
                SuckerPunch = new Move("Sucker Punch", Type.Dark, 70, 1, 5, 'P', new double[] { 1, 1 }, new Effect[] { Effects.GeneralEffects.DealsNoDmg, Flags.tgtReadyingAttack, Effects.GeneralEffects.DealsDmg }, new bool[] { true, false, true }, new ZMove(BlackHoleEclipse, 140), 0);
                Switcheroo = new Move("Switcheroo", Type.Dark, 0, 1, 15, 'S', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.Swap.Item }, new bool[] { false }, ZSwitcheroo, 0);
                Taunt = new Move("Taunt", Type.Dark, 0, 1, 20, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Taunt }, new bool[] { false }, ZTaunt, 0);
                Thief = new Move("Thief", Type.Dark, 40, 1, 10, 'P', new double[] { 1 }, new Effect[] { Effects.GeneralEffects.TransferItem }, new bool[] { false }, new ZMove(BlackHoleEclipse, 120), 0);
                ThroatChop = new Move("Throat Chop", Type.Dark, 80, 1, 15, 'P', new double[] { 1 }, new Effect[] { Effects.RareEffects.ThroatChop }, new bool[] { false }, new ZMove(BlackHoleEclipse, 160), 0);
                TopsyTurvy = new Move("Topsy-Turvy", Type.Dark, 0, 1, 20, 'S', new double[] { 1 }, new Effect[] { Effects.RareEffects.ReverseStatChanges }, new bool[] { false }, ZTopsyTurvy, 0);
                Torment = new Move("Torment", Type.Dark, 0, 1, 15, 'S', new double[] { 1 }, new Effect[] { Statuses.VolatileStatuses.Torment }, new bool[] { false }, ZTorment, 0);
            }
            #endregion
        }
        #endregion
    }
}
