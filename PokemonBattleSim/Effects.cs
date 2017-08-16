namespace PokemonBattleSim
{
    #region Effects
    /// <summary>
    /// Standard effects found while battling
    /// </summary>
    public static class Effects
    {
        #region Move Effects
        /// <summary>
        /// Effects specific to moves
        /// </summary>
        public static class MoveEffects
        {
            #region Declarations
            /// <summary>
            /// Represents a move being a critical hit 100% of the time
            /// </summary>
            public static Effect AllCrit;

            /// <summary>
            /// Represents the effects of Reflect (halving damage from Atks)
            /// </summary>
            public static Effect AttackScreen;

            /// <summary>
            /// Clears the effects of Reflect and Light Screen
            /// </summary>
            public static Effect BreakScreens;

            /// <summary>
            /// Represents a move that needs a turn to charge
            /// </summary>
            public static Effect Charge1Turn;

            /// <summary>
            /// Clears all traps and seeds from user's side of the field
            /// </summary>
            public static Effect ClearTraps;

            /// <summary>
            /// Confuses all pokemon on the field
            /// </summary>
            public static Effect ConfuseAll;

            /// <summary>
            /// Copies the ability of the target
            /// </summary>
            public static Effect CopyAbility;

            /// <summary>
            /// Copy the target's last move
            /// </summary>
            public static Effect CopyLastMove;

            /// <summary>
            /// Copies the target's stat changes
            /// </summary>
            public static Effect CopyStatChanges;

            /// <summary>
            /// Consumes the target's (or user's) item
            /// </summary>
            public static Effect ConsumeItem;

            /// <summary>
            /// Deals damage equal to the level of the user
            /// </summary>
            public static Effect DealsDmgEqualToLvl;

            /// <summary>
            /// Causes the move to do NO damage
            /// </summary>
            public static Effect DealsNoDmg;

            /// <summary>
            /// Decreases accuracy to 50%
            /// </summary>
            public static Effect DecreaseAcc50Pcnt;

            /// <summary>
            /// Destroys the target's held berry
            /// </summary>
            public static Effect DestroyHeldBerry;

            /// <summary>
            /// Deals damage based on the opposite defense stat (i.e. a physical move depends on Sp. Def, not Def)
            /// </summary>
            public static Effect DmgBasedOnOppositeStat;

            /// <summary>
            /// Do exactly the power in damage
            /// </summary>
            public static Effect DoBPInDmg;

            /// <summary>
            /// Move does half of the target's current HP
            /// </summary>
            public static Effect DoesHalfTargetHPDmg;

            /// <summary>
            /// Doubles a move's power
            /// </summary>
            public static Effect DoublePower;

            /// <summary>
            /// Very similar to MoreHPMoreDm. User does more damage the more HP they have currently. Formula is as follows:
            /// Power = 150 x (CurrHP/MaxHP)
            /// </summary>
            public static Effect EruptionSpout;

            /// <summary>
            /// Forces a pokemon to attack first
            /// </summary>
            public static Effect ForceAttackFirstNextTurn;

            /// <summary>
            /// Guarantees a crit on the user's next turn
            /// </summary>
            public static Effect GuaranteedCritNextTurn;

            /// <summary>
            /// The heavier the user is compared to the target, the more damage it does. Formula is as follows:
            /// r = UserWeight/TargetWeight
            ///
            /// Ratio(r)    | Power
            /// -------------------
            /// 5 =< r      | 120
            /// 4 <= r < 5  | 100
            /// 3 <= r < 4  | 80
            /// 2 <= r < 3  | 60
            /// r < 2       | 40
            /// </summary>
            public static Effect HeavierMoreDmg;

            /// <summary>
            /// The heavier the opponent the more damage the move does:
            /// Weight (kg) | Power
            /// -----------------------
            /// 0.1-9.9     | 20
            /// 10.0-24.9   | 40
            /// 25.0-49.9   | 60
            /// 50.0-99.9   | 80
            /// 100.0-199.9 | 100
            /// 200.0+      | 120
            /// </summary>
            public static Effect HeavierOppMoreDmg;

            /// <summary>
            /// Changes the crit ratio of a move from 1/16 to 1/8
            /// </summary>
            public static Effect HighCrit;

            /// <summary>
            /// The move hits all adjacent pokemon
            /// </summary>
            public static Effect HitAllAdjacent;

            /// <summary>
            /// The move hits all foes on the field
            /// </summary>
            public static Effect HitAllFoes;

            /// <summary>
            /// Represents a move hitting multiple times in one turn
            /// </summary>
            public static Effect HitsMultipleTimes;

            /// <summary>
            /// Represents whether a move hits twice in one turn or not
            /// </summary>
            public static Effect HitTwiceOneTurn;

            /// <summary>
            /// Ignore a semi-invuln state
            /// </summary>
            public static class Ignore
            {
                /// <summary>
                /// Ignore the semi-invuln state of fly
                /// </summary>
                public static Effect Fly;
                /// <summary>
                /// Ignore the semi-invuln state of dig
                /// </summary>
                public static Effect Dig;
                /// <summary>
                /// Ignore the semi-invuln state of dive
                /// </summary>
                public static Effect Dive;

                static Ignore()
                {
                    Fly = new Effect("IgnoreFly", "Ignores the semi-invulunerable state given by fly");
                    Dig = new Effect("IgnoreDig", "Ignores the semi-invulnerable state given by Dig");
                    Dive = new Effect("IgnoreDive", "Ignores the semi-invulnerable state given by Dive");
                }
            }

            /// <summary>
            /// The move ignores any and all stat changes on the opponent
            /// </summary>
            public static Effect IgnoreStatChanges;

            /// <summary>
            /// Represents a move being incrementally multiplied over several turns
            /// </summary>
            public static Effect IncrementalDamageMux;

            /// <summary>
            /// The lower the user's HP, the more damage the move does as per the following table:
            /// HP(%)    | Power
            /// ----------------
            /// 70.1-100 | 20
            /// 35.1-70  | 40
            /// 20.1-35  | 80
            /// 10.1-20  | 100
            /// 4.1-10   | 150
            /// 0-4      | 200
            /// </summary>
            public static Effect LessHPMoreDmg;

            /// <summary>
            /// Used for calculating damage done by Crush Grip and Wring Out: 120 x (Target's Curr HP / Target's Max HP)
            /// </summary>
            public static Effect MoreHPMoreDmg;

            /// <summary>
            /// Deals more damage the faster the user is compared to the opponent. Formula is as follows:
            /// r = UserSpeed/TargetSpeed
            ///
            /// Ratio(r)    | Power
            /// -------------------
            /// 4 <= r      | 150
            /// 3 <= r < 4  | 120
            /// 2 <= r < 3  | 80
            /// 1 <= r < 2  | 60
            /// r < 1       | 40
            /// </summary>
            public static Effect MoreSpdMoreDmg;

            /// <summary>
            /// If another ally used the move before the user, it will do double damage and execute directly after the ally using Round
            /// </summary>
            public static Effect MoveUsedByAllyThisTurn;

            /// <summary>
            /// Prevents any pokemon from sleeping while move is being used
            /// </summary>
            public static Effect PreventAllSleep;

            /// <summary>
            /// Reduces HP of the target to the user
            /// </summary>
            public static Effect ReduceHPToUsers;

            /// <summary>
            /// Move repeats 3 times
            /// </summary>
            public static Effect Repeat3Times;

            /// <summary>
            /// Removes all entry hazards
            /// </summary>
            public static Effect RemoveEntryHazards;

            /// <summary>
            /// User faints
            /// </summary>
            public static Effect SelfDestruction;

            /// <summary>
            /// Set up an entry hazard
            /// </summary>
            public static class SetEntryHazards
            {
                /// <summary>
                /// Damages incoming opponents. Additional uses of this move will do more damage. Only affects GROUNDED pkmn.
                /// </summary>
                public static Effect Spikes;

                /// <summary>
                /// Damages incoming opponents. Affected by type matchups.
                /// </summary>
                public static Effect StealthRock;

                /// <summary>
                /// Reduces Speed of incoming opponents by 1 stage. Only affects grounded pkmn
                /// </summary>
                public static Effect StickyWeb;

                /// <summary>
                /// Poisons incoming opponents. A second use of this move causes the pkmn to be badly poisoned. Only affects grounded pkmn. Poison and Steel type pkmn are immune.
                /// </summary>
                public static Effect ToxicSpikes;

                static SetEntryHazards()
                {
                    Spikes = new Effect("SetSpikes", "Damages incoming opponents. Additional uses of this move will do more damage. Only affects grounded Pokémon.");
                    StealthRock = new Effect("SetStealthRock", "Damages incoming opponents. Affected by type matchups.");
                    StickyWeb = new Effect("SetStickyWeb", "Reduces Speed of incoming opponents by one stage. Only affects grounded Pokémon.");
                    ToxicSpikes = new Effect("SetToxicSpikes", "Poisons incoming opponents. A second use of this move causes the Pokémon to be badly poisoned. Only affects grounded Pokémon. Poison-type and Steel-type Pokémon are immune.");
                }
            }

            /// <summary>
            /// Represents the effects of Light Screen (halving damage from Sp.Atks)
            /// </summary>
            public static Effect SpecialScreen;

            /// <summary>
            /// The move does 1/16 of maximum health in splash dmg to all adjacent pokemon 
            /// </summary>
            public static Effect SplashDmg;

            /// <summary>
            /// Represents when a pokemon is to be switched out
            /// </summary>
            public static Effect Switchout;

            /// <summary>
            /// Transfers the holder's item to target
            /// </summary>
            public static Effect TransferItem;

            /// <summary>
            /// Transfers stats to the switched in pokemon
            /// </summary>
            public static Effect TransferStatsToSwitchout;

            /// <summary>
            /// The type of the move matches the user's type
            /// </summary>
            public static Effect TypeMatchesUser;

            /// <summary>
            /// Uses the last move of the target
            /// </summary>
            public static Effect UseLastMove;

            /// <summary>
            /// Use a random move of the user
            /// </summary>
            public static Effect UseRandomMove;

            /// <summary>
            /// Represents if a move causes recoil
            /// </summary>
            public static class Recoil
            {
                /// <summary>
                /// User (or target) takes 1/8 of its max HP as recoil
                /// </summary>
                public static Effect EighthMaxHP;

                /// <summary>
                /// User takes 1/2 of its current HP as recoil
                /// </summary>
                public static Effect HalfCurrHP;

                /// <summary>
                /// User takes 1/2 of its max HP as recoil
                /// </summary>
                public static Effect HalfMaxHP;

                /// <summary>
                /// User takes 1/2 of the dmg dealt as recoil
                /// </summary>
                public static Effect HalfDmgDealt;

                /// <summary>
                /// User takes 1/4 of the dmg dealt as recoil
                /// </summary>
                public static Effect QuarterDmgDealt;

                /// <summary>
                /// User takes 1/4 of its maximum HP as recoil
                /// </summary>
                public static Effect QuarterMaxHP;

                /// <summary>
                /// User takes 1/3 of the dmg dealt as recoil
                /// </summary>
                public static Effect ThirdDmgDealt;

                static Recoil()
                {
                    EighthMaxHP = new Effect("EighthMaxHP", "User (or target), takes 1/8 of max HP as recoil damage");
                    QuarterDmgDealt = new Effect("QuarterDmgDealt", "User takes 1/4 of the dmg dealt by its move as recoil");
                    ThirdDmgDealt = new Effect("ThirdDmgDealt", "User takes 1/3 of the dmg dealt by its move as recoil");
                    HalfMaxHP = new Effect("HalfMaxHP", "User takes 1/2 of its maximum HP as recoil dmg");
                    HalfDmgDealt = new Effect("HalfDmgDealt", "User takes 1/2 of the dmg dealt by its move as recoil");
                    QuarterMaxHP = new Effect("QuarterMaxHP", "User takes 1/4 of its max HP as recoil dmg");
                    HalfCurrHP = new Effect("HalfCurrHP", "User takes 1/2 of its current HP as recoil dmg");
                }
            }
            /// <summary>
            /// Strengthens a move type by 50%
            /// </summary>
            public static class Strengthen
            {
                /// <summary>
                /// Strengthens water type moves by 50%
                /// </summary>
                public static Effect Water;
                /// <summary>
                /// Strengthens ground type moves by 50%
                /// </summary>
                public static Effect Ground;

                static Strengthen()
                {
                    Water = new Effect("PlusWater", "Strengthens Water type moves by 50%");
                    Ground = new Effect("PlusGround", "Strengthens Ground type moves by 50%");
                }
            }
            /// <summary>
            /// Represents a wait before a move executes
            /// </summary>
            public static class Wait
            {
                /// <summary>
                /// Wait 1 turn before execution
                /// </summary>
                public static Effect OneTurn;
                /// <summary>
                /// Wait 2 turns before execution
                /// </summary>
                public static Effect TwoTurns;

                static Wait()
                {
                    OneTurn = new Effect("Move executes after the passing of 1 turn", "The move will execute after 1 turn in addition to the effects of the used move");
                    TwoTurns = new Effect("Move executes after the passing of 2 turns", "The move will execute after 2 turns in addition to the effects of the used move");
                }
            }
            /// <summary>
            /// Changes the target's type
            /// </summary>
            public static class ChangeTargetType
            {
                /// <summary>
                /// Changes target's type to Water
                /// </summary>
                public static Effect Water;

                static ChangeTargetType()
                {
                    Water = new Effect("ChangeWater", "Changes the target's type to Water");
                }
            }
            /// <summary>
            /// Adds a type to the target
            /// </summary>
            public static class AddTypeToTarget
            {
                public static Effect Grass;
                public static Effect Ghost;
                
                static AddTypeToTarget()
                {
                    Grass = new Effect("AddGrass", "Adds the Grass type to the target in addition to its other types");
                    Ghost = new Effect("AddGhost", "Adds the Ghost type to the target in addition to its other types");
                }
            }
            /// <summary>
            /// Weakens moves of specific types by 50%
            /// </summary>
            public static class Weaken
            {
                /// <summary>
                /// Weakens Fire type moves' power by 50%
                /// </summary>
                public static Effect Fire;
                /// <summary>
                /// Weakens Electric type moves' power by 50%
                /// </summary>
                public static Effect Electric;

                static Weaken()
                {
                    Fire = new Effect("WeakenFire", "Weakens Fire type moves' power by 50%");
                    Electric = new Effect("WeakenEle", "Weakens Electric type moves' power by 50%");
                }
            }
            #endregion

            #region Definitions
            static MoveEffects()
            {
                AllCrit = new Effect("100% Crit Rate", "The attack is guaranteed to be a critical hit.");
                AttackScreen = new Effect("Attack Screen", "Halves damage from physical moves.");
                BreakScreens = new Effect("Break Screens", "Clears the effects of Reflect and Light Screen");
                Charge1Turn = new Effect("Charge 1 turn", "The attack will take 1 turn to charge before activation.");
                ClearTraps = new Effect("Clears traps from the user's side of the field", "Removes effects of any binding moves, leech seeds, and entry hazards from the field");
                ConfuseAll = new Effect("Confuses all pokemon on the battlefield", "Confuses all pokemon on the battlefield, including the user");
                ConsumeItem = new Effect("ConsumeItem", "Consumes the target or user's item if possible");
                CopyAbility = new Effect("Copies the ability of the target", "Copies the ability of the target pokemon");
                CopyLastMove = new Effect("Copy the opponent's last move", "Copies the opponent's last used move");
                CopyStatChanges = new Effect("Copy the target's stat changes", "Copies the target's stat changes, both positive and negative");
                DealsDmgEqualToLvl = new Effect("DmgEqToLvl", "Deals damage equal to the level of the user");
                DealsNoDmg = new Effect("doNoDmg", "Damage will be prevented if this flag is not ignored");
                DecreaseAcc50Pcnt = new Effect("Decreases the accuracy of the move to 50%", "Decreases the accuracy of the move to 50%");
                DestroyHeldBerry = new Effect("DestroyHeldBerry", "Destroy the target's held berry");
                DmgBasedOnOppositeStat = new Effect("DmgOppStat", "Deals damage based on the opposite stat. Physical moves operate on Sp. Defense and Special moves operate on Defense");
                DoBPInDmg = new Effect("Do exactly the power of the move in HP to the target", "Do exactly the BP number in damage to the target. For example, 20BP would translate to 20 raw damage, 40BP would translate to 40 damage, etc");
                DoesHalfTargetHPDmg = new Effect("Move halves target's current HP", "Move does damage equal to half of the target's current HP");
                DoublePower = new Effect("Doubles the power of the move", "A move with this effect will do double its normal damage");
                EruptionSpout = new Effect("User does more damage the more HP the user has", "The move does more damage the more HP they have at time of execution");
                ForceAttackFirstNextTurn = new Effect("Target attacks first next turn", "Forces the target to attack first next turn");
                GuaranteedCritNextTurn = new Effect("Guarantees the next move will crit", "The next move used will result in a critical hit");
                HeavierMoreDmg = new Effect("HeavierMoreDmg", "The heavier the user is compared to the target, the more damage the move does on execution");
                HeavierOppMoreDmg = new Effect("HeavierOppMoreDmg", "The heavier the opponent is, the more damage th emove does one execution");
                HighCrit = new Effect("Raises critical ratio", "Raises crit ratio from 1/16 to 1/8");
                HitAllAdjacent = new Effect("Hits all adjacent pokemon", "The move will hit all adjacent pokemon including allies");
                HitAllFoes = new Effect("HitAllFoes", "Hits all foes on the battlefield at time of execution");
                HitsMultipleTimes = new Effect("Hits Multiple Times", "The attack hits 2-5 times.");
                HitTwiceOneTurn = new Effect("Hits twice in one turn", "The move will strike twice in one turn");
                IgnoreStatChanges = new Effect("Ignore opponent's stat changes", "The move will ignore all of the opponent's stat changes");
                IncrementalDamageMux = new Effect("Incremental Damage Multiplier", "The attack's damage is multiplied by 2 for 1-5 turns");
                LessHPMoreDmg = new Effect("LessHPMoreDmg", "The lower the user's HP on execution, the more damage the move does");
                MoreHPMoreDmg = new Effect("More powerful when opponent has higher HP", "The higher the opponent's HP, the more damage the move does. Formula: 120 x (Target Curr HP / Target Max HP");
                MoreSpdMoreDmg = new Effect("MoreSpdMoreDmg", "The higher the speed of the user compared to the opponent, the higher the move's base power");
                MoveUsedByAllyThisTurn = new Effect("Extra effects if the same move has been used by an ally this turn", "Doubles power and is used right after an ally uses the same move");
                PreventAllSleep = new Effect("Prevents pokemon from sleeping", "Prevents all pokemon on the battlefield from sleeping while the move is being used");
                ReduceHPToUsers = new Effect("Reduces HP of the target to the user's", "The move will reduce the HP of the target to your current HP");
                Repeat3Times = new Effect("Repeats move 3 times", "Repeats the move 3 times");
                SelfDestruction = new Effect("User faints", "Move causes the user to faint");
                SpecialScreen = new Effect("Special Screen", "Halves damage from special moves.");
                SplashDmg = new Effect("Deals 1/16 maximum health to all adjacent pokemon", "Deals 1/16 max HP to all adjacent pokemon in typeless splash damage. Can affect user if move targets an adjacent ally");
                Switchout = new Effect("Switches pokemon out", "Pokemon gets switched out for anothe in party");
                TransferItem = new Effect("Transfer item to target", "Transfers the user's held item to the target pokemon");
                TransferStatsToSwitchout = new Effect("Passes stat changes to switched in pokemon", "Passes any and all stat changes to switched in pokemon");
                TypeMatchesUser = new Effect("Type of the move matches the user", "The type of the move matches the user");
                UseLastMove = new Effect("UseLastMv", "Uses the last move of the targt");
                UseRandomMove = new Effect("Use a random move of the user", "Uses a random move of the use in addition to any other effects of the move itself");
            }
            #endregion
        }
        #endregion

        #region Double Battle Effects
        public static class DoubleBattleEffects
        {
            #region Declarations
            /// <summary>
            /// Increases the damage of target's next move by 50%
            /// </summary>
            public static Effect IncreaseTargetDmg50Pcnt;

            /// <summary>
            /// Uses a random move of target ally
            /// </summary>
            public static Effect UseRandomPartnerMove;
            #endregion

            #region Definitions
            static DoubleBattleEffects()
            {
                IncreaseTargetDmg50Pcnt = new Effect("Increase the damage of target ally's next move by 50%", "Increases the damage of the target ally's next move by 50% or 1.5x the damage");
                UseRandomPartnerMove = new Effect("Use one of partner's moves", "Uses a random move of the partner pokemon. Only works in double battles.");
            }
            #endregion
        }
        #endregion

        #region Healing Effects
        /// <summary>
        /// Represents healing and/or curative effects
        /// </summary>
        public static class HealingEffects
        {
            
            #region HP Restore
            /// <summary>
            /// All HP Restore effects
            /// </summary>
            public static class HPRestore
            {
                #region Declarations
                /// <summary>
                /// Represents a full HP restore
                /// </summary>
                public static Effect FullHPRestore;

                /// <summary>
                /// Restore half the user's HP
                /// </summary>
                public static Effect HalfHPRestore;

                /// <summary>
                /// Heals half the damage inflicted by the move
                /// </summary>
                public static Effect HealHalfDmgInflicted;

                /// <summary>
                /// Heals an amount equal to the target's attack stat
                /// </summary>
                public static Effect HealTargetAtkStat;

                /// <summary>
                /// Restores 1/6 of the user's HP
                /// </summary>
                public static Effect SixthHPRestore;

                /// <summary>
                /// Heals for 75% of the dmg done
                /// </summary>
                public static Effect ThreeQuarterDmgInflicted;

                /// <summary>
                /// Heals varying amounts based on weather
                /// </summary>
                public static Effect WeatherBasedHPRestore;
                #endregion

                #region Definitions
                static HPRestore()
                {
                    FullHPRestore = new Effect("FullHPRestore", "Restores HP to full");
                    HalfHPRestore = new Effect("HalfHPRestore", "Restores half of the user's HP");
                    HealHalfDmgInflicted = new Effect("HealHalfDmgDone", "Restores an amount of HP equal to half the damage inflicted by the move");
                    HealTargetAtkStat = new Effect("HealTgtAtkStat", "Heals for an amount equal to the target's attack stat, including any and all stat changes to the target");
                    SixthHPRestore = new Effect("SixthHPRestore", "Heals one sixth of the user's HP");
                    ThreeQuarterDmgInflicted = new Effect("ThreeQtrDmgInf", "Heals for 75% of the damage done");
                    WeatherBasedHPRestore = new Effect("WthrHPRestore", "Heals for varying amounts based on the weather");
                }
                #endregion
            }
            #endregion

            #region Stat Alterations
            /// <summary>
            /// Represents all stat alterations. Restores and Buffs.
            /// </summary>
            public static class StatAlterations
            {
                #region Declarations
                /// <summary>
                /// Represents a prevention in stat changes made upon the user
                /// </summary>
                public static Effect PreventStatChanges;

                /// <summary>
                /// Represents a random stat change increase by 2
                /// </summary>
                public static Effect RandomStatBuffBy2;

                /// <summary>
                /// Represents a full stat change reset across all pkmn on the field
                /// </summary>
                public static Effect ResetAllStatChanges;

                /// <summary>
                /// Resets all stat drops applied to the user
                /// </summary>
                public static Effect ResetStatDrops;
                #endregion

                #region Definitions
                static StatAlterations()
                {
                    PreventStatChanges = new Effect("PreventStatChanges", "Prevents stat changes for 5 turns on the user");
                    RandomStatBuffBy2 = new Effect("RandoStatBuffBy2", "Increases a random stat (incl Evasion and Accuracy) by 2 stages");
                    ResetAllStatChanges = new Effect("ResetAllStatChanges", "Resets all Pokemon on the battlefield's stat changes.");
                    ResetStatDrops = new Effect("ResetStatDrops", "Resets any and all stat drops");
                }
                #endregion
            }
            #endregion

            #region Status Cures
            /// <summary>
            /// Contains all status condition cures
            /// </summary>
            public static class StatusCures
            {
                #region Declarations
                /// <summary>
                /// Cures burn
                /// </summary>
                public static Effect CureBurn;

                /// <summary>
                /// Cures all non-volatile status effects
                /// </summary>
                public static Effect CureNonVolatile;

                /// <summary>
                /// Cures paralysis
                /// </summary>
                public static Effect CureParalysis;

                /// <summary>
                /// Cures poison
                /// </summary>
                public static Effect CurePoison;

                /// <summary>
                /// Cures sleep
                /// </summary>
                public static Effect CureSleep;

                /// <summary>
                /// Heals the status conditions of the user's party
                /// </summary>
                public static Effect HealUserPartyStatus;
                #endregion

                #region Definitions
                static StatusCures()
                {
                    CureBurn = new Effect("CureBurn", "Cures the burn status effect");
                    CureNonVolatile = new Effect("CureNonVolatile", "Cures all non-volatile statuses from the target");
                    CureParalysis = new Effect("CureParalysis", "Cures the paralysis status effect");
                    CurePoison = new Effect("CurePoison", "Cures the poison and bad poison status effects");
                    CureSleep = new Effect("CureSleep", "Cures the sleep status effect");
                    HealUserPartyStatus = new Effect("HealPartyStatus", "Heal the status conditions of the user's party (both in battle and out), allies, and the user itself.");
                }
                #endregion
            }
            #endregion
        }
        #endregion

        #region Rare Effects
        /// <summary>
        /// Effects occurring very rarely
        /// </summary>
        public static class RareEffects
        {
            #region Declarations
            /// <summary>
            /// Represents the move Belly Drum's ability to halve HP and maxes Attack
            /// </summary>
            public static Effect BellyDrum;

            /// <summary>
            /// Represents the effect of the move Bide
            /// </summary>
            public static Effect Bide;

            /// <summary>
            /// After use, changes the user's type to typeless. Cannot be used if the user is not a Fire type.
            /// </summary>
            public static Effect BurnUp;

            /// <summary>
            /// Represents the effect of the move Camouflage
            /// </summary>
            public static Effect Camo;

            /// <summary>
            /// Changes the target's ability to insomnia
            /// </summary>
            public static Effect ChangeTargetAbilityToInsomnia;

            /// <summary>
            /// Cancels out the effect of the opponent's Ability
            /// </summary>
            public static Effect RemoveTargetAbilityEffects;

            /// <summary>
            /// Changes the move's type to that of the held drive
            /// </summary>
            public static Effect ChangeTypeToDrive;

            /// <summary>
            /// Changes type based on weather:
            /// Bright Sunlight (or harsh) - Fire
            /// Heavy Rain (or torrent) - Water
            /// Sandstorm - Rock
            /// Hailstorm - Ice
            /// Fog - stays Normal (still doubles)
            /// </summary>
            public static Effect ChangeTypeToWeather;

            /// <summary>
            /// Doubles the power of the next move if it is an Electric type
            /// </summary>
            public static Effect Charge;

            /// <summary>
            /// Represents the effect of the move Conversion
            /// </summary>
            public static Effect Conv;

            /// <summary>
            /// Represents the effect of the move Conversion2
            /// </summary>
            public static Effect Conv2;

            /// <summary>
            /// Cuts the target's current HP by 75%
            /// </summary>
            public static Effect CutCurrHPBy75Pcnt;

            /// <summary>
            /// Deals damage equal to the amount of remaining HP of the user.
            /// </summary>
            public static Effect DealRemainingHP;

            /// <summary>
            /// Represents the move Disable's effect
            /// </summary>
            public static Effect Disable;

            /// <summary>
            /// Doubles the user's party's speed for 4 turns
            /// </summary>
            public static Effect DoublePartySpeed4turns;

            /// <summary>
            /// Changes the target's move type to electric if it has not already attacked
            /// </summary>
            public static Effect Electrify;

            /// <summary>
            /// Reduces HP to, at most, 1
            /// </summary>
            public static Effect FalseSwipe;

            /// <summary>
            /// One of the more complicated effects. Formula is as follows:
            /// N = 48 x CurrHP / MaxHP
            /// Then the value "N" is used to determine the base power:
            ///   Ratio (N)   |    HP(%)    |Power|
            /// -----------------------------------
            ///  0 <= N < 2   |   0-4.16    | 200 |
            ///  2 <= N < 4   | 4.17-10.41  | 150 |
            ///  5 <= N < 9   | 10.42-20.82 | 100 |
            /// 10 <= N < 16  | 20.83-35.41 | 80  |
            /// 17 <= N < 32  | 35.42-68.74 | 40  |
            /// 33 <= N <= 48 | 68.75-100   | 20  |
            /// </summary>
            public static Effect Flail;

            /// <summary>
            /// Move deals damage as both a fighting and a flying move. Type effectiveness table is as follows:
            /// 2x : Normal, Grass, Ice, Fighting, Dark
            /// 1x : Water, FIre, Ground, Rock, Bug, Steel, Dragon
            /// 1/2x : Electric Poison, Flying, Psychic, Fairy
            /// 0x : Ghost
            /// </summary>
            public static Effect FlyingPress;

            /// <summary>
            /// Starts focusing at the beginning of turn. If hit by a damaging move before a -3 priority move would execute, the move fails.
            /// </summary>
            public static Effect FocusPunch;

            /// <summary>
            /// Represents the move Freeze-Dry's ability to be super-effective against Water types
            /// </summary>
            public static Effect FreezeDry;

            /// <summary>
            /// The friendlier the pokemon is towards the user, the more damage. Formula is as follows:
            /// Base Power = Friendship/2.5
            /// </summary>
            public static Effect FriendlyMoreDmg;

            /// <summary>
            /// This move is very complicated to describe. It only does 60 damage, but its type is math'd out via a complex formula:
            /// 
            /// HP_type = floor[((a + 2b + 4c + 8d + 16e + 32f) x 15) / 63]
            /// Where a, b, c, d, e, f are the least significant bits of their repsective IVs (use x % 2 to find if odd) if odd, lsb is 1 and 0 o.w.
            /// a - HP | b, c - Atk, Def | d - Spd | e, f - Sp Atk, Sp Def
            /// 
            /// Then you apply this number (HP_type) to the following list
            /// 0 - Fighting | 1 - Flying | 2 - Poison | 3 - Ground | 4 - Rock | 5 - Bug | 6 - Ghost | 7 - Steel |
            /// 8 - Fire | 9 - Water | 10 - Grass | 11 - Electric | 12 - Psychic | 13 - Ice | 14 - Dragon | 15 - Dark
            /// 
            /// The move is NEVER Normal or Fairy
            /// </summary>
            public static Effect HiddenPower;

            /// <summary>
            /// Changes Normal type moves to Electric type
            /// </summary>
            public static Effect IonDeluge;

            /// <summary>
            /// Type of the move changes to the plate the Arceus has equipped
            /// </summary>
            public static Effect Judgement;

            /// <summary>
            /// Move can only be used when all other moves are exhausted
            /// </summary>
            public static Effect LastResort;

            /// <summary>
            /// The base power of Magnitude is one of 7 random values with varying probabilities according to the following table:
            /// Magnitude   | Prob  | Power
            /// ---------------------------
            /// 4           | 5%    | 10
            /// 5           | 10%   | 30
            /// 6           | 20%   | 50
            /// 7           | 30%   | 70
            /// 8           | 20%   | 90
            /// 9           | 10%   | 110
            /// 10          | 5%    | 150
            /// </summary>
            public static Effect Magnitude;

            /// <summary>
            /// User copies the opponent's attack with 1.5x dmg
            /// </summary>
            public static Effect MeFirst;

            /// <summary>
            /// Use any random move in the game
            /// </summary>
            public static Effect Metronome;

            /// <summary>
            /// Morning Sun restores the user's current HP based on the weather in the battle. 
            /// During no weather it restores ½ total HP, during harsh sunlight it restores ⅔ total HP, and during other weather it restores ¼ total HP.
            /// </summary>
            public static Effect MorningSun;

            /// <summary>
            /// Natural Gift's power and type depend on the user's held berry
            /// Type     | 60 BP          | 70 BP     | 80BP      |
            /// ---------------------------------------------------
            /// Normal   | Chilan         |           |           |
            /// Fire     | Cheri, Occa    | Bluk      | Watmel    |
            /// Water    | Chesto, Passho | Nanab     | Durin     |
            /// Electric | Pecha, Wacan   | Wepear    | Belue     |
            /// Grass    | Rawst, Rindo   | Pinap     | Liechi    |
            /// Ice      | Aspear, Yache  | Pomeg     | Ganion    |
            /// Fighting | Leppa, Chople  | Kelpsy    | Salac     |
            /// Poison   | Oran, Kebia    | Qualot    | Petaya    |
            /// Ground   | Persim, Shuca  | Hondew    | Apicot    |
            /// Flying   | Lum, Coba      | Grepa     | Lansat    |
            /// Psychic  | Sitrus, Payapa | Tamato    | Starf     |
            /// Bug      | Figy, Tanga    | Cornn     | Enigma    |
            /// Rock     | Wiki, Charti   | Magost    | Micle     |
            /// Ghost    | Mago, Kasib    | Rabuta    | Custap    |
            /// Dragon   | Aguav, Haban   | Nomel     | Jaboca    |
            /// Dark     | Iapapa, Colbur | Spelon    | Rowap     |
            /// Steel    | Razz, Babiri   | Pamtre    |           |
            /// </summary>
            public static Effect NatGift;

            /// <summary>
            /// Nature power "transforms" into a move based on the terrain
            /// Wi-fi battles - Tri Attack
            /// Grassy Terrain - Energy Ball
            /// Misty Terrain - Moonblast
            /// Electric Terrain - Thunderbolt
            /// </summary>
            public static Effect NaturePower;

            /// <summary>
            /// Makes the target unable to crit for 5 turns
            /// </summary>
            public static Effect NoCrits5Turns;

            /// <summary>
            /// Represents the ability for a move to OHKO. Formula for accuracy is as follows:
            /// UserLevel - TargetLevel + 30
            /// </summary>
            public static Effect OHKO;

            /// <summary>
            /// Type of the move is determined by the Oricorio forme
            /// </summary>
            public static Effect OricorioForme;

            /// <summary>
            /// The user's and opponent's HP becomes the average of both
            /// </summary>
            public static Effect PainSplit;

            /// <summary>
            /// Fire Pledge deals damage at base power 80. If a teammate uses Grass Pledge or Water Pledge in the same turn, the moves combine into one attack of base power 160 and added effects appear.
            /// The faster Pokemon moves first but waits for the other Pokemon to make their move.When the slower Pledge user moves, the combo attack hits the Pokemon the slower user was targeting.
            /// 
            /// If Fire Pledge is used with Grass Pledge, the move animation shows Fire Pledge and a sea of fire envelops the foe's team is created that damages opponents 1⁄8 of their maximum HP each turn, for 4 turns.
            /// If Fire Pledge is used with Water Pledge, the move animation shows Water Pledge and a rainbow appears in the sky on your team's side that doubles the chance of moves' secondary effects occurring for 4 turns.
            /// </summary>
            public static Effect Pledges;

            /// <summary>
            /// Either damages or heals the target. Probability of effects is as follows:
            /// Dmg w/40bp - 40%
            /// Dmg w/80bp - 30%
            /// Dmg w/120bp - 10%
            /// Heal 1/4 target's max HP - 20%
            /// </summary>
            public static Effect Present;

            /// <summary>
            /// Blocks moves for the team with increased priority during the turn it's used
            /// </summary>
            public static Effect QuickGuard;

            /// <summary>
            /// User's used held item is restored
            /// </summary>
            public static Effect Recycle;

            /// <summary>
            /// User becomes the target's type
            /// </summary>
            public static Effect ReflectType;

            /// <summary>
            /// Retains the copied move (replaces the move that caused the copying) with ONLY 5 pp remaining
            /// </summary>
            public static Effect RetainCopiedMove;

            /// <summary>
            /// User loses the Flying type until end of turn. If the pkmn is dual type it reduces to the otther type, if it's pure Flying it becomes Normal type.
            /// </summary>
            public static Effect Roost;

            /// <summary>
            /// Raises the Atk and SpAtk of Grass types pkmn
            /// </summary>
            public static Effect Rototiller;

            /// <summary>
            /// Deals dmg and has an additional 30% of a different effect based on location
            /// Std or Electric Terrain - paralysis
            /// Grassy Terrain - sleep
            /// Misty Terrain - lowers SpAtk by 1 stage
            /// Psychic Terrain - lowers Spd by 1 stage
            /// </summary>
            public static Effect SecretPwr;

            /// <summary>
            /// User creates a trap at the beginning of turn (before moves with any positive priority). Then at the time of a -3 priority move's execution, if the user has been hit by a physical move, it will inflict damage.
            /// </summary>
            public static Effect ShellTrap;

            /// <summary>
            /// Changes the target's ability to Simple
            /// </summary>
            public static Effect Simple;

            /// <summary>
            /// Copies a move in totality (PP, dmg, acc, etc)
            /// </summary>
            public static Effect Sketch;

            /// <summary>
            /// Sky Drop takes the target inot the air on the first turn then drops them on the second turn. Just like Fly in terms of moves effective on it. Will NOT work if the target is Flying or Raised, if Gravity is in effect, the target is holding an Iron Ball, or behind a Substitute
            /// </summary>
            public static Effect SkyDrop;

            /// <summary>
            /// Deals varying damage based on the stockpile level (only goes to 3): 
            /// Stockpile 1 - 100 bp
            /// Stockpile 2 - 200 bp
            /// Stockpile 3 - 300 bp
            /// </summary>
            public static Effect SpitUp;

            /// <summary>
            /// Store energy up to 3 times. Each stockpile raises users's Def and Sp Def by 1 stage. Move fails if stockpile reaches 3.
            /// </summary>
            public static Effect Stockpile;

            /// <summary>
            /// Heals the user by varying percents of the user's HP based on the stockpile level:
            /// Stockpile 1 - 25%
            /// Stockpile 2 - 50%
            /// Stockpile 3 - 100%
            /// </summary>
            public static Effect Swallow;

            /// <summary>
            /// User repeats the move for 2-3 turns, cannot switch out, and then becomes confused. If it was disrupted by paralysis or missing, it will stop swinging and no confusion.
            /// </summary>
            public static Effect Thrash;

            /// <summary>
            /// If raining, ignores acc checks, if heavy sunlight, drops acc to 50%.
            /// </summary>
            public static Effect Thunder;

            /// <summary>
            /// User becomes an exact copy of the target pokemon
            /// </summary>
            public static Effect Transform;

            /// <summary>
            /// 20% chance of incurring 1 of 3 statuses (poison, paralysis, freeze)
            /// </summary>
            public static Effect TriAttack;

            /// <summary>
            /// Strikes three times with each kick's base damage increasing.
            /// 10 + 20 + 30, so 60 in total
            /// </summary>
            public static Effect TripleKick;

            /// <summary>
            /// Inflicts more damage the fewer PP the move has remaining. Dmg is calc'd by what the PP would be AFTER the move executes.
            /// PP Left | Power
            /// ---------------
            ///   >= 4  |  40
            ///    3    |  50
            ///    2    |  60
            ///    1    |  80
            ///    0    | 200
            /// </summary>
            public static Effect TrumpCard;

            /// <summary>
            /// The move does more damage if the pokemon is more unfriendly. Formula: 
            /// Power = (255-Friendship) / 2.5
            /// </summary>
            public static Effect UnfriendlyMoreDamage;

            /// <summary>
            /// Changes the terrain of the battlefield
            /// </summary>
            public static class Terrain
            {
                /// <summary>
                /// Represents the Electric Terrain
                /// </summary>
                public static Effect Electric;

                /// <summary>
                /// Represents the Grassy Terrain
                /// </summary>
                public static Effect Grass;

                static Terrain()
                {
                    Electric = new Effect("EleTerrain", "Increase the power of Electric moves by 50% and prevents GROUNDED pokemon from sleeping for 5 turns");
                    Grass = new Effect("GrassTerrain", "Increase the power of Grass moves by 50% and restores 1/16 maximum HP to all GROUNDED pokemon on the battlefield each turn");
                }
            }
            #endregion

            #region Definitions
            static RareEffects()
            {
                BellyDrum = new Effect("BellyDrum", "Removes half of the target's max HP and maxes the Attack stat.");
                Bide = new Effect("Bide", "User takes damage for two turns then strikes back with double the amount of damage received.");
                BurnUp = new Effect("BurnUp", "User's type changes to typeless after use. Cannot be used if the user is not a fire type");
                Camo = new Effect("Camo", "Changes user's type according to location");
                ChangeTargetAbilityToInsomnia = new Effect("WorrySeed", "Changes target's ability to Insomnia");
                ChangeTypeToDrive = new Effect("TypeToDrive", "Changes the move's type to the type of the user's held Drive");
                ChangeTypeToWeather = new Effect("TypeToWeather", "Changes the move's type based on the weather");
                Charge = new Effect("Charge", "Doubles the power of the next move if it's an Electric type move");
                Conv = new Effect("Conv", "Changes user's type to that of it's first listed move");
                Conv2 = new Effect("Conv2", "User changes type to become resistant to opponent's last used move");
                CutCurrHPBy75Pcnt = new Effect("CutMajHP", "Removes 75% of the target's remaining HP");
                DealRemainingHP = new Effect("DealRemainHP", "Deals damage equal to the remaining HP of the user");
                DoublePartySpeed4turns = new Effect("DblPtySpd4Turns", "Doubles the user's party's speed for 4 turns");
                Disable = new Effect("Disable", "Opponent can't use it's last attack for 1-8 turns");
                Electrify = new Effect("Electrify", "Changes the type of the target's move to electric if it has not already attacked this turn");
                FalseSwipe = new Effect("FalseSwipe", "Can only deal enough damage to reduce target HP to 1 and cannot K.O.");
                Flail = new Effect("Flail", "Deals more damage the lower the user's HP");
                FlyingPress = new Effect("FlyingPress", "Deals damage as both a Fighting and Flying type move");
                FocusPunch = new Effect("FocusPunch", "Charges punch at beginning of turn, if the user is hit by a damaging move before a -3 priority move would execute, the move fails.");
                FreezeDry = new Effect("FreezeDry", "This move is super-effective on water types in addition to its normal type-matchups.");
                FriendlyMoreDmg = new Effect("MoreFriendMoreDmg", "The friendlier the pokemon is towards the user, the more damage the move does");
                HiddenPower = new Effect("HiddenPwr", "The move's type depends on the IVs of the user");
                IonDeluge = new Effect("Ion Deluge", "Changes Normal type moves to Electric type");
                Judgement = new Effect("Judgement", "Arceus' exclusive move. Type changes to the the equipped plate's type");
                LastResort = new Effect("LastResort", "Move can only be used after all others have been exhausted");
                Magnitude = new Effect("Magnitude", "The base power of Magnitude is one of 7 random values with differing probabilities");
                MeFirst = new Effect("MeFirst", "Copies target's move to use the following turn with 1.5 the damage");
                Metronome = new Effect("Metronome", "Use any move in the game at random");
                MorningSun = new Effect("MorningSun", "Restores the user's HP based on the weather in the battle");
                NatGift = new Effect("Natural Gift", "Damage and type vary with the held berry");
                NaturePower = new Effect("NaturePwr", "Move transforms into different move based on terrain");
                NoCrits5Turns = new Effect("NoCrits", "The target's moves cannot crit for 5 turns");
                OHKO = new Effect("OHKO", "It's a one-hit KO!");
                OricorioForme = new Effect("OricorioForme", "The type of the move is determined by the Oricorio's forme");
                PainSplit = new Effect("PainSplit", "User's and opponent's HP becomes the average of both");
                Pledges = new Effect("Pledges", "The move does more damage and has other effects if Water or Grass Pledge are used in the same turn");
                Present = new Effect("Present", "Either damages or heals the target");
                QuickGuard = new Effect("QuickGuard", "Blocks increased priority moves from doing damage to the user and its team");
                Recycle = new Effect("Recycle", "User's used held item is restored");
                ReflectType = new Effect("ReflectType", "User becomes the target's type");
                RemoveTargetAbilityEffects = new Effect("RmvTgtAbility", "Cancels out the effect of the opponent's Ability");
                RetainCopiedMove = new Effect("RetainCopied", "Replace the move that caused the copying");
                Roost = new Effect("Roost", "User loses the Flying type until end of turn");
                Rototiller = new Effect("Rototiller", "Raises the Atk and SpAtk of Grass types by 1 stage");
                SecretPwr = new Effect("SecretPwr", "Deals dmg and has a chance to do a different effect based on location");
                ShellTrap = new Effect("ShellTrap", "User sets a trap at the very beginning of a turn, then at thee time of a -3 priority move executing if the user has been hit by a physical move, then it will inflict damage. Otherwise, it will do 0 damage.");
                Simple = new Effect("Simple", "Changes the target's ability to Simple");
                Sketch = new Effect("Sketch", "Copies the target opponent's last move in totality");
                SkyDrop = new Effect("SkyDrop", "Represents the move Sky Drop");
                SpitUp = new Effect("SpitUp", "Deals varying dmg based on stockpile level");
                Swallow = new Effect("Swallow", "Heals the user by varying percents of HP based on the stockpile level");
                Thrash = new Effect("Thrash", "User swings 2-3 times and becomes confused after completion");
                Thunder = new Effect("Thunder", "Weather effects of the move thunder");
                Transform = new Effect("Transform", "User becomes an exat copy of target pokemon, copying moves, stats, stat changes, species, type, cry, etc");
                TriAttack = new Effect("TriAttack", "20% chance of proc'ing either burn, paralysis, or freeze");
                TripleKick = new Effect("TripleKick", "Move deals damage and will stirke 3 times, with each kick's damage doing increasing damage. Starts at 10 then goes 20 then 30, for a total of 60");
                TrumpCard = new Effect("TrumpCard", "Inflicts more damage when fewer PP is remaining. Damage is calc'd based on the PP remaining AFTER execution");
                UnfriendlyMoreDamage = new Effect("MoreUnfriendlyMoreDmg", "The more unfriendly the user is toward the player, the more damage the move does.");
            }
            #endregion
        }
        #endregion
    }
    #endregion

    #region Flags
    public static class Flags
    {
        #region Declarations
        /// <summary>
        /// If the user had an ally that died this turn
        /// </summary>
        public static Effect AllyDiedThisTurn;

        /// <summary>
        /// Doubles power if fusion bolt is used in the same turn
        /// </summary>
        public static Effect FusionBolt;

        /// <summary>
        /// Doubles power if Fusion Flare is used in the same turn
        /// </summary>
        public static Effect FusionFlare;

        /// <summary>
        /// If afflicted by status condition
        /// </summary>
        public static Effect ifAfflicted;

        /// <summary>
        /// If the target is underground (from the move Dig)
        /// </summary>
        public static Effect ifUnderground;

        /// <summary>
        /// If it is the first turn the pokemon appears in
        /// </summary>
        public static Effect ifFirstTurn;

        /// <summary>
        /// If the target is in the air (from Bounce or Fly)
        /// </summary>
        public static Effect ifInAir;

        /// <summary>
        /// If the move misses
        /// </summary>
        public static Effect ifMoveMisses;

        /// <summary>
        /// If the move Protect or Detect has NOT been used
        /// </summary>
        public static Effect ifNoProtection;

        /// <summary>
        /// Effects following this flag only occur if the pokemon on the other team if of the opposite gender
        /// </summary>
        public static Effect ifOppositeGender;

        /// <summary>
        /// If the user has taken damage this turn
        /// </summary>
        public static Effect ifTakenDmgThisTurn;

        /// <summary>
        /// If the target is holding a berry
        /// </summary>
        public static Effect ifTgtHoldBerry;

        /// <summary>
        /// If there is a weather effect other than clear skies
        /// </summary>
        public static Effect isActiveWeather;

        /// <summary>
        /// If the target is asleep
        /// </summary>
        public static Effect isAsleep;

        /// <summary>
        /// If there is Harsh Sunlight the move has extra effects
        /// </summary>
        public static Effect isHarshSunlight;

        /// <summary>
        /// If it is raining on the battlefield
        /// </summary>
        public static Effect isRaining;

        /// <summary>
        /// If the user is hit before using another move
        /// </summary>
        public static Effect isHitBeforeNextMove;

        /// <summary>
        /// If the user is hit by a physical move 
        /// </summary>
        public static Effect isHitByPhysMv;

        /// <summary>
        /// If the target is paralyzed
        /// </summary>
        public static Effect isParalyzed;

        /// <summary>
        /// If the target is poisoned
        /// </summary>
        public static Effect isPoisoned;

        /// <summary>
        /// If the weather is sandstorm
        /// </summary>
        public static Effect isSandstorm;

        /// <summary>
        /// If the pokemon's last move failed
        /// </summary>
        public static Effect LastMoveFailed;

        /// <summary>
        /// If the target does not have a held item
        /// </summary>
        public static Effect NoHeldItem;

        /// <summary>
        /// If the user has not consumed a berry. Consuming a berry includes eating, via Bug Bite, Pluck, or being hit by Fling
        /// </summary>
        public static Effect NotEatenBerry;

        /// <summary>
        /// If the opponent is under or at 50% HP
        /// </summary>
        public static Effect OpponentLessThanHalf;

        /// <summary>
        /// If the same move was used the turn before
        /// </summary>
        public static Effect SameMoveLastTurn;
        #endregion

        #region Definitions
        static Flags()
        {
            AllyDiedThisTurn = new Effect("AllyDied", "If the user has an ally that died the turn the move is used, it has additional/different effects");
            FusionBolt = new Effect("FusionBolt", "If the move Fusion Bolt is used on the same turn by an ally, the move Fusion Flare will double in power");
            FusionFlare = new Effect("FusionFlare", "If the move Fusion Flare is used on the same turn by an ally, the move Fusion Bolt will double in power");
            ifAfflicted = new Effect("ifAfflicted", "If the user is afflicted by a status condition, the effects of the move will trigger");
            ifFirstTurn = new Effect("if1stTurn", "If it is the first turn the pokemon has been rotated in (i.e. match starting, switched in, etc), the move's effects will trigger");
            ifInAir = new Effect("ifInAir", "If the target is in air (from Bounce or Fly), the move has extra effects");
            ifMoveMisses = new Effect("ifMoveMisses", "If the move misses, it has extra effects");
            ifNoProtection = new Effect("ifNoProtect", "Used mostly for the move Feint, fires the effects of moves if the moves Detect or Protect have not been used this turn");
            ifOppositeGender = new Effect("ifOppGender", "If the target is the opposite gender, enact effects. Otherwise, move fails.");
            ifTakenDmgThisTurn = new Effect("ifDmgTurn", "If the user has taken damage this turn the move will have extra effects");
            ifTgtHoldBerry = new Effect("ifTgtBerry", "If the target is holding a berry, the move has extra effects");
            ifUnderground = new Effect("ifDug", "If the target is underground (from the effects of Dig)");
            isActiveWeather = new Effect("IsWeather", "If sunlight, fog, hail, sandstorm, or other weather effect active, move has extra effects");
            isAsleep = new Effect("If the target is asleep move has extra effects", "The move will have extra effects if the user is asleep");
            isHarshSunlight = new Effect("isHarshSunlight", "If a move has extra effects/no recharge time when there is harsh sunlight, then the effects will go off iff there is harsh sunlight");
            isHitBeforeNextMove = new Effect("isHitBeforeNxtMove", "If the user is hit by a move before using another move");
            isHitByPhysMv = new Effect("isHitByPhysMv", "If the user is hit by a physical move, extra effects occur");
            isParalyzed = new Effect("isParalyzed", "The move will have extra effects if the user is paralyzed");
            isPoisoned = new Effect("isPoisoned", "The move will have extra effects if the user is poisoned");
            isRaining = new Effect("isRain", "The move will have extra effects if it is raining");
            isSandstorm = new Effect("isSandstorm", "The move will have extra effects if the battlefield is under a sandstorm");
            LastMoveFailed = new Effect("LastMoveFailed", "The move will have extra effects if the user's last move failed");
            NoHeldItem = new Effect("NoHeldItem", "The move will have extra effects if the target (or user) does not have a held item");
            NotEatenBerry = new Effect("NoEatBerry", "The move will have extra effects if the user has eaten a berry this match");
            OpponentLessThanHalf = new Effect("OppLessHalf", "If the opponent is at or less than 50% HP, then the move has extra effects");
            SameMoveLastTurn = new Effect("SameMvLastTurn", "If the move to be used was used the turn before, it has additional effects");
        }
        #endregion
    }
    #endregion

    #region Stat Changes
    public static class StatChanges
    {
        #region Stat Change
        /// <summary>
        /// Repesents a change in stats in either user or target
        /// </summary>
        public class StatChange : Effect
        {
            /// <summary>
            /// The number to change the stat by
            /// </summary>
            public int change;
            /// <summary>
            /// The stat to be changed
            /// </summary>
            public Stat stat;

            public StatChange(string n, string d, Stat stat, int change) : base(n, d)
            {
                this.stat = stat;
                this.change = change;
            }
        }
        #endregion

        #region Positive Stat Changes
        /// <summary>
        /// Represents positive stat changes
        /// </summary>
        public static class PositiveStatChanges
        {
            public static StatChange AtkUp1;
            public static StatChange AtkUp2;
            public static StatChange AtkUp3;
            public static StatChange AtkMax;
            /// <summary>
            /// Raise Attack by 2 stages if move causes K.O.
            /// </summary>
            public static StatChange AtkUp2IfKnockout;
            /// <summary>
            /// Maxes Attack if the move crits
            /// </summary>
            public static StatChange AtkMaxIfCrit;

            public static StatChange DefUp1;
            public static StatChange DefUp2;
            public static StatChange DefUp3;

            public static StatChange SpAtkUp1;
            public static StatChange SpAtkUp2;
            public static StatChange SpAtkUp3;

            public static StatChange SpDefUp1;
            public static StatChange SpDefUp2;

            public static StatChange SpdUp1;
            public static StatChange SpdUp2;

            public static StatChange EvasUp1;
            public static StatChange EvasUp2;

            public static StatChange AccUp1;
            public static StatChange AccUp2;

            public static StatChange CritUp1;
            public static StatChange CritUp2;

            static PositiveStatChanges()
            {
                AtkUp1 = new StatChange("Attack raised by 1", "Raises Attack by 1 stage", Stats.Atk, 1);
                AtkUp2 = new StatChange("Attack raised by 2", "Raises Attack by 2 stages", Stats.Atk, 2);
                AtkUp3 = new StatChange("Attack raised by 3", "Raises Attack by 3 stages", Stats.Atk, 3);
                AtkUp2IfKnockout = new StatChange("Attack raised by 2", "Raises Attack by 2 stages if the move causes a K.O.", Stats.Atk, 2);
                AtkMaxIfCrit = new StatChange("Attack is maximized!", "Raises Attack to maximum stage if the move crits.", Stats.Atk, 6);

                DefUp1 = new StatChange("Defense raised by 1", "Raises Defense by 1 stage", Stats.Def, 1);
                DefUp2 = new StatChange("Defense raised by 2", "Raises Defense by 2 stages", Stats.Def, 2);
                DefUp3 = new StatChange("Defense raised by 3", "Raises Defense by 3 stages", Stats.Def, 3);

                SpAtkUp1 = new StatChange("Sp. Attack raised by 1", "Raises Special Attack by 1 stage", Stats.SpAtk, 1);
                SpAtkUp2 = new StatChange("Sp. Attack raised by 2", "Raises Special Attack by 2 stages", Stats.SpAtk, 2);
                SpAtkUp3 = new StatChange("Sp. Attack raised by 3", "Raises Special Attack by 3 stages", Stats.SpAtk, 3);

                SpDefUp1 = new StatChange("Sp. Defense raised by 1", "Raises Special Defense by 1 stage", Stats.SpDef, 1);
                SpDefUp2 = new StatChange("Sp. Defense raised by 2", "Raises Special Defense by 2 stages", Stats.SpDef, 2);

                SpdUp1 = new StatChange("Speed raised by 1", "Raises Speed by 1 stage", Stats.Spd, 1);
                SpdUp2 = new StatChange("Speed raised by 2", "Raises Speed by 2 stages", Stats.Spd, 2);

                EvasUp1 = new StatChange("Evasion raised by 1", "Raises Evasion by 1 stage", Stats.Evasion, 1);
                EvasUp2 = new StatChange("Evasion raised by 2", "Raises Evasion by 2 stages", Stats.Evasion, 2);

                AccUp1 = new StatChange("Accuracy raised by 1", "Raises Accuracy by 1 stage", Stats.Accuracy, 1);
                AccUp2 = new StatChange("Accuracy raised by 2", "Raises Accuracy by 2 stages", Stats.Accuracy, 2);

                CritUp1 = new StatChange("Crit raised by 1", "Raises Critical Hit Ratio by 1 stage", Stats.Crit, 1);
                CritUp2 = new StatChange("Crit raised by 2", "Raises Critical Hit Ratio by 2 stages", Stats.Crit, 2);
            }
        }
        #endregion

        #region Negative Stat Change
        /// <summary>
        /// Represents negative stat changes
        /// </summary>
        public static class NegativeStatChanges
        {
            public static StatChange AtkDwn1;
            public static StatChange AtkDwn2;

            public static StatChange DefDwn1;
            public static StatChange DefDwn2;

            public static StatChange SpAtkDwn1;
            public static StatChange SpAtkDwn2;

            public static StatChange SpDefDwn1;
            public static StatChange SpDefDwn2;

            public static StatChange SpdDwn1;
            public static StatChange SpdDwn2;

            public static StatChange EvasDwn1;
            public static StatChange EvasDwn2;

            public static StatChange AccDwn1;

            static NegativeStatChanges()
            {
                AtkDwn1 = new StatChange("Attack lowered by 1", "Lowers Attack by 1 stage", Stats.Atk, -1);
                AtkDwn2 = new StatChange("Attack lowered by 2", "Lowers Attack by 2 stages", Stats.Atk, -2);

                DefDwn1 = new StatChange("Defense lowered by 1", "Lowers Defense by 1 stage", Stats.Def, -1);
                DefDwn2 = new StatChange("Defense lowered by 2", "Lowers Defense by 2 stages", Stats.Def, -2);

                SpAtkDwn1 = new StatChange("Sp. Attack lowered by 1", "Lowers Special Attack by 1 stage", Stats.SpAtk, -1);
                SpAtkDwn2 = new StatChange("Sp. Attack lowered by 2", "Lowers Special Attack by 2 stages", Stats.SpAtk, -2);

                SpDefDwn1 = new StatChange("Sp. Defense lowered by 1", "Lowers Special Defense by 1 stage", Stats.SpDef, -1);
                SpDefDwn2 = new StatChange("Sp. Defense lowered by 2", "Lowers Special Defense by 2 stages", Stats.SpDef, -2);

                EvasDwn1 = new StatChange("Evasion lowered by 1", "Lowers Evasion by 1 stage", Stats.Evasion, -1);
                EvasDwn2 = new StatChange("Evasion lowered by 2", "Lowers Evasion by 2 stages", Stats.Evasion, -2);

                AccDwn1 = new StatChange("Accuracy lowered by 1", "Lowers Accuracy by 1 stage", Stats.Accuracy, -1);
            }
        }
        #endregion
    }
    #endregion 

    #region Statuses
    public static class Statuses
    {
        #region Base Statuses
        /// <summary>
        /// The 6 major status effects
        /// </summary>
        public static class BaseStatuses
        {
            /// <summary>
            /// Represents the badly poisoned status effect
            /// </summary>
            public static Effect BadPoison;

            /// <summary>
            /// Represents the burn status effect
            /// </summary>
            public static Effect Burn;

            /// <summary>
            /// Represents the frozen status effect
            /// </summary>
            public static Effect Freeze;

            /// <summary>
            /// Represents the paralysis status effect
            /// </summary>
            public static Effect Paralysis;

            /// <summary>
            /// Represents the poisoned status effect
            /// </summary>
            public static Effect Poisoned;

            /// <summary>
            /// Represents the sleep status effect
            /// </summary>
            public static Effect Sleep;

            static BaseStatuses()
            {
                Freeze = new Effect("Freeze", "The Pokemon is frozen and cannot attack. There is a 20% chance that the pokemon will thaw.");
                Burn = new Effect("Burn", "The Pokemon is burned and loses 1/8 of its maximum health and deals 1/2 damage with physical attacks.");
                Paralysis = new Effect("Paralysis", "The Pokemon is paralyzed and has a 25% chance of not being able to attack.");
                Sleep = new Effect("Sleep", "The Pokemon is slept from 1 to 3 turns and cannot attack.");
                Poisoned = new Effect("Poisoned", "The Pokemon is poisoned and loses 1/8 of its maximum HP at the end of every turn.");
                BadPoison = new Effect("Badly Poisoned", "The Pokemon is badly poisoned and loses 1/16 of its maximum HP plus another 1/16 every turn thereafter (1/16 the first turn, 1/8 the second, etc).");
            }
        }
        #endregion

        #region Volatile Statuses
        /// <summary>
        /// The volatile statuses
        /// </summary>
        public static class VolatileStatuses
        {
            #region Definitions
            /// <summary>
            /// Represents the aqua ring effect
            /// </summary>
            public static Effect AquaRing;

            /// <summary>
            /// Represents the bound status effect
            /// </summary>
            public static Effect Bound;

            /// <summary>
            /// Represents the bracing effect
            /// </summary>
            public static Effect Bracing;

            /// <summary>
            /// Represents the center-of-attention effect
            /// </summary>
            public static Effect CenterofAttention;

            /// <summary>
            /// Represents the charging effect
            /// </summary>
            public static Effect Charging;

            /// <summary>
            /// Represents the confused status effect
            /// </summary>
            public static Effect Confused;

            /// <summary>
            /// Represents the curse status effect
            /// </summary>
            public static Effect Curse;

            /// <summary>
            /// Represents the defense-curl effect
            /// </summary>
            public static Effect DefenseCurl;

            /// <summary>
            /// Represents the embargo status effect
            /// </summary>
            public static Effect Embargo;

            /// <summary>
            /// Represents the encore status effect
            /// </summary>
            public static Effect Encore;

            /// <summary>
            /// Represents the flinch status effect
            /// </summary>
            public static Effect Flinch;

            /// <summary>
            /// Represents the glowing effect
            /// </summary>
            public static Effect Glowing;

            /// <summary>
            /// Represents the grounded effect
            /// </summary>
            public static Effect Grounded;

            /// <summary>
            /// Represents the heal-block status effect
            /// </summary>
            public static Effect HealBlock;

            /// <summary>
            /// Represents the identified status effect
            /// </summary>
            public static Effect Identified;

            /// <summary>
            /// Represents the infatuated status effect
            /// </summary>
            public static Effect Infatuated;

            /// <summary>
            /// Represents the seeded status effect
            /// </summary>
            public static Effect LeechSeed;

            /// <summary>
            /// Represents the leghold status effect (not being able to switch out)
            /// </summary>
            public static Effect LegHold;

            /// <summary>
            /// Represents the magic-coat effect
            /// </summary>
            public static Effect MagicCoat;

            /// <summary>
            /// Represents the magnetic levitation effect
            /// </summary>
            public static Effect MagneticLevitation;

            /// <summary>
            /// Represents the minimize effect
            /// </summary>
            public static Effect Minimize;

            /// <summary>
            /// Represents the nightmare status effect
            /// </summary>
            public static Effect Nightmare;

            /// <summary>
            /// Represents the persish-song status effect
            /// </summary>
            public static Effect PerishSong;

            /// <summary>
            /// Represents the protection effect
            /// </summary>
            public static Effect Protection;

            /// <summary>
            /// Represents the raised status effect
            /// </summary>
            public static Effect Raised;

            /// <summary>
            /// Represents the recharging effect
            /// </summary>
            public static Effect Recharging;

            /// <summary>
            /// Represents the rooting effect
            /// </summary>
            public static Effect Rooting;

            /// <summary>
            /// Represents the safeguard effect
            /// </summary>
            public static Effect Safeguard;

            /// <summary>
            /// Represents the semi-invulnerable effect
            /// </summary>
            public static Effect SemiInvulnerable;

            /// <summary>
            /// Represents the substitute effect
            /// </summary>
            public static Effect Substitute;

            /// <summary>
            /// Represents the taking-aim effect
            /// </summary>
            public static Effect TakingAim;

            /// <summary>
            /// Represents the takin-in-sunlight effect
            /// </summary>
            public static Effect TakingInSunlight;

            /// <summary>
            /// Represents the taunt status effect
            /// </summary>
            public static Effect Taunt;

            /// <summary>
            /// Represents the team-protection effect
            /// </summary>
            public static Effect TeamProtection;

            /// <summary>
            /// Represents the telekinesis status effect
            /// </summary>
            public static Effect Telekinesis;

            /// <summary>
            /// Represents the tormented status effect
            /// </summary>
            public static Effect Torment;

            /// <summary>
            /// Represents the whipping-up-a-whirlwind effect
            /// </summary>
            public static Effect WhippingUpWhirlwind;

            /// <summary>
            /// Represents the withdrawing effect
            /// </summary>
            public static Effect Withdrawing;
            #endregion

            #region Declarations
            static VolatileStatuses()
            {
                AquaRing = new Effect("Aqua Ring", "The Pokemon surrounds itself with a veil of water, restoring 1/16th of its maximum HP.");
                Bound = new Effect("Bound", "The Pokemon is bound and will lose 1/8 of its maximum HP at the end of each turn.");
                CenterofAttention = new Effect("Center of Attention", "The Pokemon becomes the Center of Attention, forcing opponents to target it.");
                Charging = new Effect("Charging", "The Pokemon is charging up a move to hit on the next turn");
                Confused = new Effect("Confused", "The Pokemon is confused and will hit itself rather than its opponent 33% of the time.");
                Curse = new Effect("Curse", "The Pokemon is cursed and will lose 1/4 of its maximum HP at the end of each turn.");
                DefenseCurl = new Effect("Defense Curl", "The moves Rollout and Ice Ball deal double damage for this Pokemon.");
                Embargo = new Effect("Embargo", "The Pokemon is embargoed and is unable to use its held item.");
                Encore = new Effect("Encore", "The Pokemon is being encored for 3 turns and will repeat its last attack.");
                Flinch = new Effect("Flinch", "The Pokemon is flinching and cannot attack for the turn in which it is being flinched.");
                Glowing = new Effect("Glowing", "The Pokemon is cloaked in light for one-turn and cannot attack.");
                Grounded = new Effect("Grounded", "The Pokemon is now susceptible to Ground, Terrain, Areana Trap");
                HealBlock = new Effect("Heal Block", "The Pokemon is blocked from healing and cannot heal or be healed for 5 turns.");
                Identified = new Effect("Identified", "The Pokemon is identified and has all of its evasion modifiers ignored. Additionally, all no-effect type matchups will do normal damage.");
                Infatuated = new Effect("Infatuated", "The Pokemon is infatuated and cannot attack 50% of the time.");
                LeechSeed = new Effect("Leech Seed", "The Pokemon is seeded and loses 1/8 of its maximum health at the end of every turn.");
                LegHold = new Effect("LegHold", "The Pokemon is held in place and cannot escape!");
                MagicCoat = new Effect("Magic Coat", "The Pokemon shrouds itself in a coat that reflects most statuses inflicted upon it or its side of the field back to the user.");
                MagneticLevitation = new Effect("Magnetic Levitation", "The Pokemon levitates via Magnet Rise and becomes immune to ground-based attacks.");
                Minimize = new Effect("Minimize", "The Pokemon raises its evasion by 2 stages, but takes double damage from some moves.");
                Nightmare = new Effect("Nightmare", "The Pokemon is under the effects of a nightmare and loses 1/4 of its maximum HP at the end of every turn if asleep.");
                PerishSong = new Effect("Perish Song", "The Pokemon has heard a perishing song and will wil faint in 3 turns if not switched out.");
                Protection = new Effect("Protection", "The Pokemon is protected from most damaging and status moves.");
                Raised = new Effect("Raised", "The Pokemon is raised above the ground and is immune to Ground type moves and terrain moves");
                Recharging = new Effect("Recharging", "The Pokemon is recharging from using a powerful move and cannot attack for 1 turn");
                Rooting = new Effect("Rooting", "The Pokemon plants its roots, restoring 1/16th of its maximum HP and cannot switch-out");
                Safeguard = new Effect("Safeguard", "The user's party is protected from status conditions");
                SemiInvulnerable = new Effect("Semi-Invulnerable", "The Pokemon is invulnerable to most attacks for 1 turn.");
                Substitute = new Effect("Substitute", "The Pokemon converts 1/4 of its total HP into a substitute that absorbs damage until it breaks and cannot be affected by status conditions.");
                TakingAim = new Effect("Taking Aim", "The Pokemon is taking aim. Its next attack will hit regardless of accuracy.");
                TakingInSunlight = new Effect("Taking in Sunlight", "The Pokemon is absorbing sunlight and cannot attck for 1 turn.");
                Taunt = new Effect("Taunt", "The Pokemon is taunted and cannot use status moves for 3 turns.");
                TeamProtection = new Effect("Team Protection", "The Pokemon protects both it and its allies from specific moves.");
                Telekinesis = new Effect("Telekinesis", "The Pokemon is telekinetically elevated and becomes immune to Ground-type moves, Spikes, Toxic Spikes, and Arena Trap.");
                Torment = new Effect("Torment", "The Pokemon is tormented and cannot use the same move twice in a row.");
                WhippingUpWhirlwind = new Effect("Whipping up a Whirlwind", "The Pokemon is readying a whirlwind. It cannot attack for 1 turn.");
                Withdrawing = new Effect("Withdrawing", "The Pokemon is readying a bash with its skull. It cannot attack for 1 turn.");
            }
            #endregion
        }
        #endregion
    }
    #endregion

    #region Weather
    public static class Weather
    {
        #region Declarations
        /// <summary>
        /// Represents clear skies weather
        /// </summary>
        public static Effect ClearSkies;

        /// <summary>
        /// Represents extra-harsh sunlight weather
        /// </summary>
        public static Effect ExHarshSunlight;

        /// <summary>
        /// Represents hail weather
        /// </summary>
        public static Effect Hail;

        /// <summary>
        /// Represents harsh sunlight weather
        /// </summary>
        public static Effect HarshSunlight;

        /// <summary>
        /// Represents heavy-rain weather
        /// </summary>
        public static Effect HeavyRain;

        /// <summary>
        /// Represents mysterious air current weather
        /// </summary>
        public static Effect OddCurrent;

        /// <summary>
        /// Represents rain weather
        /// </summary>
        public static Effect Rain;

        /// <summary>
        /// Represents sandstorm weather
        /// </summary>
        public static Effect Sandstorm;
        #endregion

        #region Definitions
        static Weather()
        {
            ClearSkies = new Effect("Clear Skies", "Absence of weather.");
            ExHarshSunlight = new Effect("Extremely Harsh Sunlight", "Sunlight shines heavily on the battlefield.");
            Hail = new Effect("Hail", "Pelting hail falls on the battlefield");
            HarshSunlight = new Effect("Harsh Sunlight", "Strong sunlight shines on the battlefield.");
            HeavyRain = new Effect("Heavy Rain", "Rain falls chaotically on the battlefield.");
            OddCurrent = new Effect("Mysterious Air Current", "A strong air current blows across the battlefield.");
            Rain = new Effect("Rain", "Rain falls on the battlefield.");
            Sandstorm = new Effect("Sandstorm", "Stinging sand whips across the battlefield.");
        }
        #endregion
    }
    #endregion
}
