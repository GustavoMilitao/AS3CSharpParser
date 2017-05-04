public  class  CharacterCharacteristicsInformations {public  static  const  uint protocolId  = 8 ;public    double experience  = 0 ;public    double experienceLevelFloor  = 0 ;public    double experienceNextLevelFloor  = 0 ;public    double experienceBonusLimit  = 0 ;public    double kamas  = 0 ;public    uint statsPoints  = 0 ;public    uint additionnalPoints  = 0 ;public    uint spellsPoints  = 0 ;public    ActorExtendedAlignmentInformations alignmentInfos  ;public    uint lifePoints  = 0 ;public    uint maxLifePoints  = 0 ;public    uint energyPoints  = 0 ;public    uint maxEnergyPoints  = 0 ;public    int actionPointsCurrent  = 0 ;public    int movementPointsCurrent  = 0 ;public    CharacterBaseCharacteristic initiative  ;public    CharacterBaseCharacteristic prospecting  ;public    CharacterBaseCharacteristic actionPoints  ;public    CharacterBaseCharacteristic movementPoints  ;public    CharacterBaseCharacteristic strength  ;public    CharacterBaseCharacteristic vitality  ;public    CharacterBaseCharacteristic wisdom  ;public    CharacterBaseCharacteristic chance  ;public    CharacterBaseCharacteristic agility  ;public    CharacterBaseCharacteristic intelligence  ;public    CharacterBaseCharacteristic range  ;public    CharacterBaseCharacteristic summonableCreaturesBoost  ;public    CharacterBaseCharacteristic reflect  ;public    CharacterBaseCharacteristic criticalHit  ;public    uint criticalHitWeapon  = 0 ;public    CharacterBaseCharacteristic criticalMiss  ;public    CharacterBaseCharacteristic healBonus  ;public    CharacterBaseCharacteristic allDamagesBonus  ;public    CharacterBaseCharacteristic weaponDamagesBonusPercent  ;public    CharacterBaseCharacteristic damagesBonusPercent  ;public    CharacterBaseCharacteristic trapBonus  ;public    CharacterBaseCharacteristic trapBonusPercent  ;public    CharacterBaseCharacteristic glyphBonusPercent  ;public    CharacterBaseCharacteristic runeBonusPercent  ;public    CharacterBaseCharacteristic permanentDamagePercent  ;public    CharacterBaseCharacteristic tackleBlock  ;public    CharacterBaseCharacteristic tackleEvade  ;public    CharacterBaseCharacteristic PAAttack  ;public    CharacterBaseCharacteristic PMAttack  ;public    CharacterBaseCharacteristic pushDamageBonus  ;public    CharacterBaseCharacteristic criticalDamageBonus  ;public    CharacterBaseCharacteristic neutralDamageBonus  ;public    CharacterBaseCharacteristic earthDamageBonus  ;public    CharacterBaseCharacteristic waterDamageBonus  ;public    CharacterBaseCharacteristic airDamageBonus  ;public    CharacterBaseCharacteristic fireDamageBonus  ;public    CharacterBaseCharacteristic dodgePALostProbability  ;public    CharacterBaseCharacteristic dodgePMLostProbability  ;public    CharacterBaseCharacteristic neutralElementResistPercent  ;public    CharacterBaseCharacteristic earthElementResistPercent  ;public    CharacterBaseCharacteristic waterElementResistPercent  ;public    CharacterBaseCharacteristic airElementResistPercent  ;public    CharacterBaseCharacteristic fireElementResistPercent  ;public    CharacterBaseCharacteristic neutralElementReduction  ;public    CharacterBaseCharacteristic earthElementReduction  ;public    CharacterBaseCharacteristic waterElementReduction  ;public    CharacterBaseCharacteristic airElementReduction  ;public    CharacterBaseCharacteristic fireElementReduction  ;public    CharacterBaseCharacteristic pushDamageReduction  ;public    CharacterBaseCharacteristic criticalDamageReduction  ;public    CharacterBaseCharacteristic pvpNeutralElementResistPercent  ;public    CharacterBaseCharacteristic pvpEarthElementResistPercent  ;public    CharacterBaseCharacteristic pvpWaterElementResistPercent  ;public    CharacterBaseCharacteristic pvpAirElementResistPercent  ;public    CharacterBaseCharacteristic pvpFireElementResistPercent  ;public    CharacterBaseCharacteristic pvpNeutralElementReduction  ;public    CharacterBaseCharacteristic pvpEarthElementReduction  ;public    CharacterBaseCharacteristic pvpWaterElementReduction  ;public    CharacterBaseCharacteristic pvpAirElementReduction  ;public    CharacterBaseCharacteristic pvpFireElementReduction  ;public    CharacterBaseCharacteristic meleeDamageDonePercent  ;public    CharacterBaseCharacteristic meleeDamageReceivedPercent  ;public    CharacterBaseCharacteristic rangedDamageDonePercent  ;public    CharacterBaseCharacteristic rangedDamageReceivedPercent  ;public    CharacterBaseCharacteristic weaponDamageDonePercent  ;public    CharacterBaseCharacteristic weaponDamageReceivedPercent  ;public    CharacterBaseCharacteristic spellDamageDonePercent  ;public    CharacterBaseCharacteristic spellDamageReceivedPercent  ;public    uint probationTime  = 0 ;private    FuncTree _alignmentInfostree  ;private    FuncTree _initiativetree  ;private    FuncTree _prospectingtree  ;private    FuncTree _actionPointstree  ;private    FuncTree _movementPointstree  ;private    FuncTree _strengthtree  ;private    FuncTree _vitalitytree  ;private    FuncTree _wisdomtree  ;private    FuncTree _chancetree  ;private    FuncTree _agilitytree  ;private    FuncTree _intelligencetree  ;private    FuncTree _rangetree  ;private    FuncTree _summonableCreaturesBoosttree  ;private    FuncTree _reflecttree  ;private    FuncTree _criticalHittree  ;private    FuncTree _criticalMisstree  ;private    FuncTree _healBonustree  ;private    FuncTree _allDamagesBonustree  ;private    FuncTree _weaponDamagesBonusPercenttree  ;private    FuncTree _damagesBonusPercenttree  ;private    FuncTree _trapBonustree  ;private    FuncTree _trapBonusPercenttree  ;private    FuncTree _glyphBonusPercenttree  ;private    FuncTree _runeBonusPercenttree  ;private    FuncTree _permanentDamagePercenttree  ;private    FuncTree _tackleBlocktree  ;private    FuncTree _tackleEvadetree  ;private    FuncTree _PAAttacktree  ;private    FuncTree _PMAttacktree  ;private    FuncTree _pushDamageBonustree  ;private    FuncTree _criticalDamageBonustree  ;private    FuncTree _neutralDamageBonustree  ;private    FuncTree _earthDamageBonustree  ;private    FuncTree _waterDamageBonustree  ;private    FuncTree _airDamageBonustree  ;private    FuncTree _fireDamageBonustree  ;private    FuncTree _dodgePALostProbabilitytree  ;private    FuncTree _dodgePMLostProbabilitytree  ;private    FuncTree _neutralElementResistPercenttree  ;private    FuncTree _earthElementResistPercenttree  ;private    FuncTree _waterElementResistPercenttree  ;private    FuncTree _airElementResistPercenttree  ;private    FuncTree _fireElementResistPercenttree  ;private    FuncTree _neutralElementReductiontree  ;private    FuncTree _earthElementReductiontree  ;private    FuncTree _waterElementReductiontree  ;private    FuncTree _airElementReductiontree  ;private    FuncTree _fireElementReductiontree  ;private    FuncTree _pushDamageReductiontree  ;private    FuncTree _criticalDamageReductiontree  ;private    FuncTree _pvpNeutralElementResistPercenttree  ;private    FuncTree _pvpEarthElementResistPercenttree  ;private    FuncTree _pvpWaterElementResistPercenttree  ;private    FuncTree _pvpAirElementResistPercenttree  ;private    FuncTree _pvpFireElementResistPercenttree  ;private    FuncTree _pvpNeutralElementReductiontree  ;private    FuncTree _pvpEarthElementReductiontree  ;private    FuncTree _pvpWaterElementReductiontree  ;private    FuncTree _pvpAirElementReductiontree  ;private    FuncTree _pvpFireElementReductiontree  ;private    FuncTree _meleeDamageDonePercenttree  ;private    FuncTree _meleeDamageReceivedPercenttree  ;private    FuncTree _rangedDamageDonePercenttree  ;private    FuncTree _rangedDamageReceivedPercenttree  ;private    FuncTree _weaponDamageDonePercenttree  ;private    FuncTree _weaponDamageReceivedPercenttree  ;private    FuncTree _spellDamageDonePercenttree  ;private    FuncTree _spellDamageReceivedPercenttree  ;private    FuncTree _spellModificationstree  ;   uint _loc2_  = 0 ;   CharacterSpellModification _loc4_  = null ;   uint _loc2_  = param1.readUnsignedShort() ;   uint _loc3_  = 0 ;public  uint getTypeId (  ) {return 8;
      }
public  void reset (  ) {this.experience = 0;
         this.experienceLevelFloor = 0;
         this.experienceNextLevelFloor = 0;
         this.experienceBonusLimit = 0;
         this.kamas = 0;
         this.statsPoints = 0;
         this.additionnalPoints = 0;
         this.spellsPoints = 0;
         this.alignmentInfos = new ActorExtendedAlignmentInformations();
         this.maxLifePoints = 0;
         this.energyPoints = 0;
         this.maxEnergyPoints = 0;
         this.actionPointsCurrent = 0;
         this.movementPointsCurrent = 0;
         this.initiative = new CharacterBaseCharacteristic();
         this.criticalMiss = new CharacterBaseCharacteristic();
         this.probationTime = 0;
      }
public  void serializeAs_CharacterCharacteristicsInformations ( ICustomDataOutput param1 ) {if(this.experience < 0 || this.experience > 9007199254740990)
         {
            throw new Error("Forbidden value (" + this.experience + ") on element experience.");
         }
         param1.writeVarLong(this.experience);
         if(this.experienceLevelFloor < 0 || this.experienceLevelFloor > 9007199254740990)
         {
            throw new Error("Forbidden value (" + this.experienceLevelFloor + ") on element experienceLevelFloor.");
         }
         param1.writeVarLong(this.experienceLevelFloor);
         if(this.experienceNextLevelFloor < 0 || this.experienceNextLevelFloor > 9007199254740990)
         {
            throw new Error("Forbidden value (" + this.experienceNextLevelFloor + ") on element experienceNextLevelFloor.");
         }
         param1.writeVarLong(this.experienceNextLevelFloor);
         if(this.experienceBonusLimit < 0 || this.experienceBonusLimit > 9007199254740990)
         {
            throw new Error("Forbidden value (" + this.experienceBonusLimit + ") on element experienceBonusLimit.");
         }
         param1.writeVarLong(this.experienceBonusLimit);
         if(this.kamas < 0 || this.kamas > 9007199254740990)
         {
            throw new Error("Forbidden value (" + this.kamas + ") on element kamas.");
         }
         param1.writeVarLong(this.kamas);
         if(this.statsPoints < 0)
         {
            throw new Error("Forbidden value (" + this.statsPoints + ") on element statsPoints.");
         }
         param1.writeVarShort(this.statsPoints);
         if(this.additionnalPoints < 0)
         {
            throw new Error("Forbidden value (" + this.additionnalPoints + ") on element additionnalPoints.");
         }
         param1.writeVarShort(this.additionnalPoints);
         if(this.spellsPoints < 0)
         {
            throw new Error("Forbidden value (" + this.spellsPoints + ") on element spellsPoints.");
         }
         param1.writeVarShort(this.spellsPoints);
         this.alignmentInfos.serializeAs_ActorExtendedAlignmentInformations(param1);
         if(this.lifePoints < 0)
         {
            throw new Error("Forbidden value (" + this.lifePoints + ") on element lifePoints.");
         }
         param1.writeVarInt(this.lifePoints);
         if(this.maxLifePoints < 0)
         {
            throw new Error("Forbidden value (" + this.maxLifePoints + ") on element maxLifePoints.");
         }
         param1.writeVarInt(this.maxLifePoints);
         if(this.energyPoints < 0)
         {
            throw new Error("Forbidden value (" + this.energyPoints + ") on element energyPoints.");
         }
         param1.writeVarShort(this.energyPoints);
         if(this.maxEnergyPoints < 0)
         {
            throw new Error("Forbidden value (" + this.maxEnergyPoints + ") on element maxEnergyPoints.");
         }
         param1.writeVarShort(this.maxEnergyPoints);
         param1.writeVarShort(this.actionPointsCurrent);
         param1.writeVarShort(this.movementPointsCurrent);
         this.initiative.serializeAs_CharacterBaseCharacteristic(param1);
         this.prospecting.serializeAs_CharacterBaseCharacteristic(param1);
         this.actionPoints.serializeAs_CharacterBaseCharacteristic(param1);
         this.movementPoints.serializeAs_CharacterBaseCharacteristic(param1);
         this.strength.serializeAs_CharacterBaseCharacteristic(param1);
         this.vitality.serializeAs_CharacterBaseCharacteristic(param1);
         this.wisdom.serializeAs_CharacterBaseCharacteristic(param1);
         this.chance.serializeAs_CharacterBaseCharacteristic(param1);
         this.agility.serializeAs_CharacterBaseCharacteristic(param1);
         this.intelligence.serializeAs_CharacterBaseCharacteristic(param1);
         this.range.serializeAs_CharacterBaseCharacteristic(param1);
         this.summonableCreaturesBoost.serializeAs_CharacterBaseCharacteristic(param1);
         this.reflect.serializeAs_CharacterBaseCharacteristic(param1);
         this.criticalHit.serializeAs_CharacterBaseCharacteristic(param1);
         if(this.criticalHitWeapon < 0)
         {
            throw new Error("Forbidden value (" + this.criticalHitWeapon + ") on element criticalHitWeapon.");
         }
         param1.writeVarShort(this.criticalHitWeapon);
         this.criticalMiss.serializeAs_CharacterBaseCharacteristic(param1);
         this.healBonus.serializeAs_CharacterBaseCharacteristic(param1);
         this.allDamagesBonus.serializeAs_CharacterBaseCharacteristic(param1);
         this.weaponDamagesBonusPercent.serializeAs_CharacterBaseCharacteristic(param1);
         this.damagesBonusPercent.serializeAs_CharacterBaseCharacteristic(param1);
         this.trapBonus.serializeAs_CharacterBaseCharacteristic(param1);
         this.trapBonusPercent.serializeAs_CharacterBaseCharacteristic(param1);
         this.glyphBonusPercent.serializeAs_CharacterBaseCharacteristic(param1);
         this.runeBonusPercent.serializeAs_CharacterBaseCharacteristic(param1);
         this.permanentDamagePercent.serializeAs_CharacterBaseCharacteristic(param1);
         this.tackleBlock.serializeAs_CharacterBaseCharacteristic(param1);
         this.tackleEvade.serializeAs_CharacterBaseCharacteristic(param1);
         this.PAAttack.serializeAs_CharacterBaseCharacteristic(param1);
         this.PMAttack.serializeAs_CharacterBaseCharacteristic(param1);
         this.pushDamageBonus.serializeAs_CharacterBaseCharacteristic(param1);
         this.criticalDamageBonus.serializeAs_CharacterBaseCharacteristic(param1);
         this.neutralDamageBonus.serializeAs_CharacterBaseCharacteristic(param1);
         this.earthDamageBonus.serializeAs_CharacterBaseCharacteristic(param1);
         this.waterDamageBonus.serializeAs_CharacterBaseCharacteristic(param1);
         this.airDamageBonus.serializeAs_CharacterBaseCharacteristic(param1);
         this.fireDamageBonus.serializeAs_CharacterBaseCharacteristic(param1);
         this.dodgePALostProbability.serializeAs_CharacterBaseCharacteristic(param1);
         this.dodgePMLostProbability.serializeAs_CharacterBaseCharacteristic(param1);
         this.neutralElementResistPercent.serializeAs_CharacterBaseCharacteristic(param1);
         this.earthElementResistPercent.serializeAs_CharacterBaseCharacteristic(param1);
         this.waterElementResistPercent.serializeAs_CharacterBaseCharacteristic(param1);
         this.airElementResistPercent.serializeAs_CharacterBaseCharacteristic(param1);
         this.fireElementResistPercent.serializeAs_CharacterBaseCharacteristic(param1);
         this.neutralElementReduction.serializeAs_CharacterBaseCharacteristic(param1);
         this.earthElementReduction.serializeAs_CharacterBaseCharacteristic(param1);
         this.waterElementReduction.serializeAs_CharacterBaseCharacteristic(param1);
         this.airElementReduction.serializeAs_CharacterBaseCharacteristic(param1);
         this.fireElementReduction.serializeAs_CharacterBaseCharacteristic(param1);
         this.pushDamageReduction.serializeAs_CharacterBaseCharacteristic(param1);
         this.criticalDamageReduction.serializeAs_CharacterBaseCharacteristic(param1);
         this.pvpNeutralElementResistPercent.serializeAs_CharacterBaseCharacteristic(param1);
         this.pvpEarthElementResistPercent.serializeAs_CharacterBaseCharacteristic(param1);
         this.pvpWaterElementResistPercent.serializeAs_CharacterBaseCharacteristic(param1);
         this.pvpAirElementResistPercent.serializeAs_CharacterBaseCharacteristic(param1);
         this.pvpFireElementResistPercent.serializeAs_CharacterBaseCharacteristic(param1);
         this.pvpNeutralElementReduction.serializeAs_CharacterBaseCharacteristic(param1);
         this.pvpEarthElementReduction.serializeAs_CharacterBaseCharacteristic(param1);
         this.pvpWaterElementReduction.serializeAs_CharacterBaseCharacteristic(param1);
         this.pvpAirElementReduction.serializeAs_CharacterBaseCharacteristic(param1);
         this.pvpFireElementReduction.serializeAs_CharacterBaseCharacteristic(param1);
         this.meleeDamageDonePercent.serializeAs_CharacterBaseCharacteristic(param1);
         this.meleeDamageReceivedPercent.serializeAs_CharacterBaseCharacteristic(param1);
         this.rangedDamageDonePercent.serializeAs_CharacterBaseCharacteristic(param1);
         this.rangedDamageReceivedPercent.serializeAs_CharacterBaseCharacteristic(param1);
         this.weaponDamageDonePercent.serializeAs_CharacterBaseCharacteristic(param1);
         this.weaponDamageReceivedPercent.serializeAs_CharacterBaseCharacteristic(param1);
         this.spellDamageDonePercent.serializeAs_CharacterBaseCharacteristic(param1);
         this.spellDamageReceivedPercent.serializeAs_CharacterBaseCharacteristic(param1);
         param1.writeShort(this.spellModifications.length);
         var _loc2_:uint = 0;
         while(_loc2_ < this.spellModifications.length)
         {
            (this.spellModifications[_loc2_] as CharacterSpellModification).serializeAs_CharacterSpellModification(param1);
            _loc2_++;
         }
         if(this.probationTime < 0)
         {
            throw new Error("Forbidden value (" + this.probationTime + ") on element probationTime.");
         }
         param1.writeInt(this.probationTime);
      }
public  void deserializeAs_CharacterCharacteristicsInformations ( ICustomDataInput param1 ) {var _loc4_:CharacterSpellModification = null;
         this._experienceFunc(param1);
         this._experienceLevelFloorFunc(param1);
         this._experienceNextLevelFloorFunc(param1);
         this._experienceBonusLimitFunc(param1);
         this._kamasFunc(param1);
         this._statsPointsFunc(param1);
         this._additionnalPointsFunc(param1);
         this._spellsPointsFunc(param1);
         this.alignmentInfos = new ActorExtendedAlignmentInformations();
         this.alignmentInfos.deserialize(param1);
         this._lifePointsFunc(param1);
         this._maxLifePointsFunc(param1);
         this._energyPointsFunc(param1);
         this._maxEnergyPointsFunc(param1);
         this._actionPointsCurrentFunc(param1);
         this._movementPointsCurrentFunc(param1);
         this.initiative = new CharacterBaseCharacteristic();
         this.initiative.deserialize(param1);
         this.prospecting = new CharacterBaseCharacteristic();
         this.prospecting.deserialize(param1);
         this.actionPoints = new CharacterBaseCharacteristic();
         this.actionPoints.deserialize(param1);
         this.movementPoints = new CharacterBaseCharacteristic();
         this.movementPoints.deserialize(param1);
         this.strength = new CharacterBaseCharacteristic();
         this.strength.deserialize(param1);
         this.vitality = new CharacterBaseCharacteristic();
         this.vitality.deserialize(param1);
         this.wisdom = new CharacterBaseCharacteristic();
         this.wisdom.deserialize(param1);
         this.chance = new CharacterBaseCharacteristic();
         this.chance.deserialize(param1);
         this.agility = new CharacterBaseCharacteristic();
         this.agility.deserialize(param1);
         this.intelligence = new CharacterBaseCharacteristic();
         this.intelligence.deserialize(param1);
         this.range = new CharacterBaseCharacteristic();
         this.range.deserialize(param1);
         this.summonableCreaturesBoost = new CharacterBaseCharacteristic();
         this.summonableCreaturesBoost.deserialize(param1);
         this.reflect = new CharacterBaseCharacteristic();
         this.reflect.deserialize(param1);
         this.criticalHit = new CharacterBaseCharacteristic();
         this.criticalHit.deserialize(param1);
         this._criticalHitWeaponFunc(param1);
         this.criticalMiss = new CharacterBaseCharacteristic();
         this.criticalMiss.deserialize(param1);
         this.healBonus = new CharacterBaseCharacteristic();
         this.healBonus.deserialize(param1);
         this.allDamagesBonus = new CharacterBaseCharacteristic();
         this.allDamagesBonus.deserialize(param1);
         this.weaponDamagesBonusPercent = new CharacterBaseCharacteristic();
         this.weaponDamagesBonusPercent.deserialize(param1);
         this.damagesBonusPercent = new CharacterBaseCharacteristic();
         this.damagesBonusPercent.deserialize(param1);
         this.trapBonus = new CharacterBaseCharacteristic();
         this.trapBonus.deserialize(param1);
         this.trapBonusPercent = new CharacterBaseCharacteristic();
         this.trapBonusPercent.deserialize(param1);
         this.glyphBonusPercent = new CharacterBaseCharacteristic();
         this.glyphBonusPercent.deserialize(param1);
         this.runeBonusPercent = new CharacterBaseCharacteristic();
         this.runeBonusPercent.deserialize(param1);
         this.permanentDamagePercent = new CharacterBaseCharacteristic();
         this.permanentDamagePercent.deserialize(param1);
         this.tackleBlock = new CharacterBaseCharacteristic();
         this.tackleBlock.deserialize(param1);
         this.tackleEvade = new CharacterBaseCharacteristic();
         this.tackleEvade.deserialize(param1);
         this.PAAttack = new CharacterBaseCharacteristic();
         this.PAAttack.deserialize(param1);
         this.PMAttack = new CharacterBaseCharacteristic();
         this.PMAttack.deserialize(param1);
         this.pushDamageBonus = new CharacterBaseCharacteristic();
         this.pushDamageBonus.deserialize(param1);
         this.criticalDamageBonus = new CharacterBaseCharacteristic();
         this.criticalDamageBonus.deserialize(param1);
         this.neutralDamageBonus = new CharacterBaseCharacteristic();
         this.neutralDamageBonus.deserialize(param1);
         this.earthDamageBonus = new CharacterBaseCharacteristic();
         this.earthDamageBonus.deserialize(param1);
         this.waterDamageBonus = new CharacterBaseCharacteristic();
         this.waterDamageBonus.deserialize(param1);
         this.airDamageBonus = new CharacterBaseCharacteristic();
         this.airDamageBonus.deserialize(param1);
         this.fireDamageBonus = new CharacterBaseCharacteristic();
         this.fireDamageBonus.deserialize(param1);
         this.dodgePALostProbability = new CharacterBaseCharacteristic();
         this.dodgePALostProbability.deserialize(param1);
         this.dodgePMLostProbability = new CharacterBaseCharacteristic();
         this.dodgePMLostProbability.deserialize(param1);
         this.neutralElementResistPercent = new CharacterBaseCharacteristic();
         this.neutralElementResistPercent.deserialize(param1);
         this.earthElementResistPercent = new CharacterBaseCharacteristic();
         this.earthElementResistPercent.deserialize(param1);
         this.waterElementResistPercent = new CharacterBaseCharacteristic();
         this.waterElementResistPercent.deserialize(param1);
         this.airElementResistPercent = new CharacterBaseCharacteristic();
         this.airElementResistPercent.deserialize(param1);
         this.fireElementResistPercent = new CharacterBaseCharacteristic();
         this.fireElementResistPercent.deserialize(param1);
         this.neutralElementReduction = new CharacterBaseCharacteristic();
         this.neutralElementReduction.deserialize(param1);
         this.earthElementReduction = new CharacterBaseCharacteristic();
         this.earthElementReduction.deserialize(param1);
         this.waterElementReduction = new CharacterBaseCharacteristic();
         this.waterElementReduction.deserialize(param1);
         this.airElementReduction = new CharacterBaseCharacteristic();
         this.airElementReduction.deserialize(param1);
         this.fireElementReduction = new CharacterBaseCharacteristic();
         this.fireElementReduction.deserialize(param1);
         this.pushDamageReduction = new CharacterBaseCharacteristic();
         this.pushDamageReduction.deserialize(param1);
         this.criticalDamageReduction = new CharacterBaseCharacteristic();
         this.criticalDamageReduction.deserialize(param1);
         this.pvpNeutralElementResistPercent = new CharacterBaseCharacteristic();
         this.pvpNeutralElementResistPercent.deserialize(param1);
         this.pvpEarthElementResistPercent = new CharacterBaseCharacteristic();
         this.pvpEarthElementResistPercent.deserialize(param1);
         this.pvpWaterElementResistPercent = new CharacterBaseCharacteristic();
         this.pvpWaterElementResistPercent.deserialize(param1);
         this.pvpAirElementResistPercent = new CharacterBaseCharacteristic();
         this.pvpAirElementResistPercent.deserialize(param1);
         this.pvpFireElementResistPercent = new CharacterBaseCharacteristic();
         this.pvpFireElementResistPercent.deserialize(param1);
         this.pvpNeutralElementReduction = new CharacterBaseCharacteristic();
         this.pvpNeutralElementReduction.deserialize(param1);
         this.pvpEarthElementReduction = new CharacterBaseCharacteristic();
         this.pvpEarthElementReduction.deserialize(param1);
         this.pvpWaterElementReduction = new CharacterBaseCharacteristic();
         this.pvpWaterElementReduction.deserialize(param1);
         this.pvpAirElementReduction = new CharacterBaseCharacteristic();
         this.pvpAirElementReduction.deserialize(param1);
         this.pvpFireElementReduction = new CharacterBaseCharacteristic();
         this.pvpFireElementReduction.deserialize(param1);
         this.meleeDamageDonePercent = new CharacterBaseCharacteristic();
         this.meleeDamageDonePercent.deserialize(param1);
         this.meleeDamageReceivedPercent = new CharacterBaseCharacteristic();
         this.meleeDamageReceivedPercent.deserialize(param1);
         this.rangedDamageDonePercent = new CharacterBaseCharacteristic();
         this.rangedDamageDonePercent.deserialize(param1);
         this.rangedDamageReceivedPercent = new CharacterBaseCharacteristic();
         this.rangedDamageReceivedPercent.deserialize(param1);
         this.weaponDamageDonePercent = new CharacterBaseCharacteristic();
         this.weaponDamageDonePercent.deserialize(param1);
         this.weaponDamageReceivedPercent = new CharacterBaseCharacteristic();
         this.weaponDamageReceivedPercent.deserialize(param1);
         this.spellDamageDonePercent = new CharacterBaseCharacteristic();
         this.spellDamageDonePercent.deserialize(param1);
         this.spellDamageReceivedPercent = new CharacterBaseCharacteristic();
         this.spellDamageReceivedPercent.deserialize(param1);
         var _loc2_:uint = param1.readUnsignedShort();
         var _loc3_:uint = 0;
         while(_loc3_ < _loc2_)
         {
            _loc4_ = new CharacterSpellModification();
            _loc4_.deserialize(param1);
            this.spellModifications.push(_loc4_);
            _loc3_++;
         }
         this._probationTimeFunc(param1);
      }
public  void deserializeAsyncAs_CharacterCharacteristicsInformations ( FuncTree param1 ) {param1.addChild(this._experienceFunc);
         param1.addChild(this._experienceLevelFloorFunc);
         param1.addChild(this._experienceNextLevelFloorFunc);
         param1.addChild(this._experienceBonusLimitFunc);
         param1.addChild(this._kamasFunc);
         param1.addChild(this._statsPointsFunc);
         param1.addChild(this._additionnalPointsFunc);
         param1.addChild(this._spellsPointsFunc);
         this._alignmentInfostree = param1.addChild(this._alignmentInfostreeFunc);
         param1.addChild(this._lifePointsFunc);
         param1.addChild(this._maxLifePointsFunc);
         param1.addChild(this._energyPointsFunc);
         param1.addChild(this._maxEnergyPointsFunc);
         param1.addChild(this._actionPointsCurrentFunc);
         param1.addChild(this._movementPointsCurrentFunc);
         this._initiativetree = param1.addChild(this._initiativetreeFunc);
         this._prospectingtree = param1.addChild(this._prospectingtreeFunc);
         this._actionPointstree = param1.addChild(this._actionPointstreeFunc);
         this._movementPointstree = param1.addChild(this._movementPointstreeFunc);
         this._strengthtree = param1.addChild(this._strengthtreeFunc);
         this._vitalitytree = param1.addChild(this._vitalitytreeFunc);
         this._wisdomtree = param1.addChild(this._wisdomtreeFunc);
         this._chancetree = param1.addChild(this._chancetreeFunc);
         this._agilitytree = param1.addChild(this._agilitytreeFunc);
         this._intelligencetree = param1.addChild(this._intelligencetreeFunc);
         this._rangetree = param1.addChild(this._rangetreeFunc);
         this._summonableCreaturesBoosttree = param1.addChild(this._summonableCreaturesBoosttreeFunc);
         this._reflecttree = param1.addChild(this._reflecttreeFunc);
         this._criticalHittree = param1.addChild(this._criticalHittreeFunc);
         param1.addChild(this._criticalHitWeaponFunc);
         this._criticalMisstree = param1.addChild(this._criticalMisstreeFunc);
         this._healBonustree = param1.addChild(this._healBonustreeFunc);
         this._allDamagesBonustree = param1.addChild(this._allDamagesBonustreeFunc);
         this._weaponDamagesBonusPercenttree = param1.addChild(this._weaponDamagesBonusPercenttreeFunc);
         this._damagesBonusPercenttree = param1.addChild(this._damagesBonusPercenttreeFunc);
         this._trapBonustree = param1.addChild(this._trapBonustreeFunc);
         this._trapBonusPercenttree = param1.addChild(this._trapBonusPercenttreeFunc);
         this._glyphBonusPercenttree = param1.addChild(this._glyphBonusPercenttreeFunc);
         this._runeBonusPercenttree = param1.addChild(this._runeBonusPercenttreeFunc);
         this._permanentDamagePercenttree = param1.addChild(this._permanentDamagePercenttreeFunc);
         this._tackleBlocktree = param1.addChild(this._tackleBlocktreeFunc);
         this._tackleEvadetree = param1.addChild(this._tackleEvadetreeFunc);
         this._PAAttacktree = param1.addChild(this._PAAttacktreeFunc);
         this._PMAttacktree = param1.addChild(this._PMAttacktreeFunc);
         this._pushDamageBonustree = param1.addChild(this._pushDamageBonustreeFunc);
         this._criticalDamageBonustree = param1.addChild(this._criticalDamageBonustreeFunc);
         this._neutralDamageBonustree = param1.addChild(this._neutralDamageBonustreeFunc);
         this._earthDamageBonustree = param1.addChild(this._earthDamageBonustreeFunc);
         this._waterDamageBonustree = param1.addChild(this._waterDamageBonustreeFunc);
         this._airDamageBonustree = param1.addChild(this._airDamageBonustreeFunc);
         this._fireDamageBonustree = param1.addChild(this._fireDamageBonustreeFunc);
         this._dodgePALostProbabilitytree = param1.addChild(this._dodgePALostProbabilitytreeFunc);
         this._dodgePMLostProbabilitytree = param1.addChild(this._dodgePMLostProbabilitytreeFunc);
         this._neutralElementResistPercenttree = param1.addChild(this._neutralElementResistPercenttreeFunc);
         this._earthElementResistPercenttree = param1.addChild(this._earthElementResistPercenttreeFunc);
         this._waterElementResistPercenttree = param1.addChild(this._waterElementResistPercenttreeFunc);
         this._airElementResistPercenttree = param1.addChild(this._airElementResistPercenttreeFunc);
         this._fireElementResistPercenttree = param1.addChild(this._fireElementResistPercenttreeFunc);
         this._neutralElementReductiontree = param1.addChild(this._neutralElementReductiontreeFunc);
         this._earthElementReductiontree = param1.addChild(this._earthElementReductiontreeFunc);
         this._waterElementReductiontree = param1.addChild(this._waterElementReductiontreeFunc);
         this._airElementReductiontree = param1.addChild(this._airElementReductiontreeFunc);
         this._fireElementReductiontree = param1.addChild(this._fireElementReductiontreeFunc);
         this._pushDamageReductiontree = param1.addChild(this._pushDamageReductiontreeFunc);
         this._criticalDamageReductiontree = param1.addChild(this._criticalDamageReductiontreeFunc);
         this._pvpNeutralElementResistPercenttree = param1.addChild(this._pvpNeutralElementResistPercenttreeFunc);
         this._pvpEarthElementResistPercenttree = param1.addChild(this._pvpEarthElementResistPercenttreeFunc);
         this._pvpWaterElementResistPercenttree = param1.addChild(this._pvpWaterElementResistPercenttreeFunc);
         this._pvpAirElementResistPercenttree = param1.addChild(this._pvpAirElementResistPercenttreeFunc);
         this._pvpFireElementResistPercenttree = param1.addChild(this._pvpFireElementResistPercenttreeFunc);
         this._pvpNeutralElementReductiontree = param1.addChild(this._pvpNeutralElementReductiontreeFunc);
         this._pvpEarthElementReductiontree = param1.addChild(this._pvpEarthElementReductiontreeFunc);
         this._pvpWaterElementReductiontree = param1.addChild(this._pvpWaterElementReductiontreeFunc);
         this._pvpAirElementReductiontree = param1.addChild(this._pvpAirElementReductiontreeFunc);
         this._pvpFireElementReductiontree = param1.addChild(this._pvpFireElementReductiontreeFunc);
         this._meleeDamageDonePercenttree = param1.addChild(this._meleeDamageDonePercenttreeFunc);
         this._meleeDamageReceivedPercenttree = param1.addChild(this._meleeDamageReceivedPercenttreeFunc);
         this._rangedDamageDonePercenttree = param1.addChild(this._rangedDamageDonePercenttreeFunc);
         this._rangedDamageReceivedPercenttree = param1.addChild(this._rangedDamageReceivedPercenttreeFunc);
         this._weaponDamageDonePercenttree = param1.addChild(this._weaponDamageDonePercenttreeFunc);
         this._weaponDamageReceivedPercenttree = param1.addChild(this._weaponDamageReceivedPercenttreeFunc);
         this._spellDamageDonePercenttree = param1.addChild(this._spellDamageDonePercenttreeFunc);
         this._spellDamageReceivedPercenttree = param1.addChild(this._spellDamageReceivedPercenttreeFunc);
         this._spellModificationstree = param1.addChild(this._spellModificationstreeFunc);
         param1.addChild(this._probationTimeFunc);
      }
private  void _experienceLevelFloorFunc ( ICustomDataInput param1 ) {this.experienceLevelFloor = param1.readVarUhLong();
         if(this.experienceLevelFloor < 0 || this.experienceLevelFloor > 9007199254740990)
         {
            throw new Error("Forbidden value (" + this.experienceLevelFloor + ") on element of CharacterCharacteristicsInformations.experienceLevelFloor.");
         }
      }
private  void _experienceBonusLimitFunc ( ICustomDataInput param1 ) {this.experienceBonusLimit = param1.readVarUhLong();
         if(this.experienceBonusLimit < 0 || this.experienceBonusLimit > 9007199254740990)
         {
            throw new Error("Forbidden value (" + this.experienceBonusLimit + ") on element of CharacterCharacteristicsInformations.experienceBonusLimit.");
         }
      }
private  void _statsPointsFunc ( ICustomDataInput param1 ) {this.statsPoints = param1.readVarUhShort();
         if(this.statsPoints < 0)
         {
            throw new Error("Forbidden value (" + this.statsPoints + ") on element of CharacterCharacteristicsInformations.statsPoints.");
         }
      }
private  void _spellsPointsFunc ( ICustomDataInput param1 ) {this.spellsPoints = param1.readVarUhShort();
         if(this.spellsPoints < 0)
         {
            throw new Error("Forbidden value (" + this.spellsPoints + ") on element of CharacterCharacteristicsInformations.spellsPoints.");
         }
      }
private  void _lifePointsFunc ( ICustomDataInput param1 ) {this.lifePoints = param1.readVarUhInt();
         if(this.lifePoints < 0)
         {
            throw new Error("Forbidden value (" + this.lifePoints + ") on element of CharacterCharacteristicsInformations.lifePoints.");
         }
      }
private  void _energyPointsFunc ( ICustomDataInput param1 ) {this.energyPoints = param1.readVarUhShort();
         if(this.energyPoints < 0)
         {
            throw new Error("Forbidden value (" + this.energyPoints + ") on element of CharacterCharacteristicsInformations.energyPoints.");
         }
      }
private  void _actionPointsCurrentFunc ( ICustomDataInput param1 ) {this.actionPointsCurrent = param1.readVarShort();
      }
private  void _initiativetreeFunc ( ICustomDataInput param1 ) {this.initiative = new CharacterBaseCharacteristic();
         this.initiative.deserializeAsync(this._initiativetree);
      }
private  void _actionPointstreeFunc ( ICustomDataInput param1 ) {this.actionPoints = new CharacterBaseCharacteristic();
         this.actionPoints.deserializeAsync(this._actionPointstree);
      }
private  void _strengthtreeFunc ( ICustomDataInput param1 ) {this.strength = new CharacterBaseCharacteristic();
         this.strength.deserializeAsync(this._strengthtree);
      }
private  void _wisdomtreeFunc ( ICustomDataInput param1 ) {this.wisdom = new CharacterBaseCharacteristic();
         this.wisdom.deserializeAsync(this._wisdomtree);
      }
private  void _agilitytreeFunc ( ICustomDataInput param1 ) {this.agility = new CharacterBaseCharacteristic();
         this.agility.deserializeAsync(this._agilitytree);
      }
private  void _rangetreeFunc ( ICustomDataInput param1 ) {this.range = new CharacterBaseCharacteristic();
         this.range.deserializeAsync(this._rangetree);
      }
private  void _reflecttreeFunc ( ICustomDataInput param1 ) {this.reflect = new CharacterBaseCharacteristic();
         this.reflect.deserializeAsync(this._reflecttree);
      }
private  void _criticalHitWeaponFunc ( ICustomDataInput param1 ) {this.criticalHitWeapon = param1.readVarUhShort();
         if(this.criticalHitWeapon < 0)
         {
            throw new Error("Forbidden value (" + this.criticalHitWeapon + ") on element of CharacterCharacteristicsInformations.criticalHitWeapon.");
         }
      }
private  void _healBonustreeFunc ( ICustomDataInput param1 ) {this.healBonus = new CharacterBaseCharacteristic();
         this.healBonus.deserializeAsync(this._healBonustree);
      }
private  void _weaponDamagesBonusPercenttreeFunc ( ICustomDataInput param1 ) {this.weaponDamagesBonusPercent = new CharacterBaseCharacteristic();
         this.weaponDamagesBonusPercent.deserializeAsync(this._weaponDamagesBonusPercenttree);
      }
private  void _trapBonustreeFunc ( ICustomDataInput param1 ) {this.trapBonus = new CharacterBaseCharacteristic();
         this.trapBonus.deserializeAsync(this._trapBonustree);
      }
private  void _glyphBonusPercenttreeFunc ( ICustomDataInput param1 ) {this.glyphBonusPercent = new CharacterBaseCharacteristic();
         this.glyphBonusPercent.deserializeAsync(this._glyphBonusPercenttree);
      }
private  void _permanentDamagePercenttreeFunc ( ICustomDataInput param1 ) {this.permanentDamagePercent = new CharacterBaseCharacteristic();
         this.permanentDamagePercent.deserializeAsync(this._permanentDamagePercenttree);
      }
private  void _tackleEvadetreeFunc ( ICustomDataInput param1 ) {this.tackleEvade = new CharacterBaseCharacteristic();
         this.tackleEvade.deserializeAsync(this._tackleEvadetree);
      }
private  void _PMAttacktreeFunc ( ICustomDataInput param1 ) {this.PMAttack = new CharacterBaseCharacteristic();
         this.PMAttack.deserializeAsync(this._PMAttacktree);
      }
private  void _criticalDamageBonustreeFunc ( ICustomDataInput param1 ) {this.criticalDamageBonus = new CharacterBaseCharacteristic();
         this.criticalDamageBonus.deserializeAsync(this._criticalDamageBonustree);
      }
private  void _earthDamageBonustreeFunc ( ICustomDataInput param1 ) {this.earthDamageBonus = new CharacterBaseCharacteristic();
         this.earthDamageBonus.deserializeAsync(this._earthDamageBonustree);
      }
private  void _airDamageBonustreeFunc ( ICustomDataInput param1 ) {this.airDamageBonus = new CharacterBaseCharacteristic();
         this.airDamageBonus.deserializeAsync(this._airDamageBonustree);
      }
private  void _dodgePALostProbabilitytreeFunc ( ICustomDataInput param1 ) {this.dodgePALostProbability = new CharacterBaseCharacteristic();
         this.dodgePALostProbability.deserializeAsync(this._dodgePALostProbabilitytree);
      }
private  void _neutralElementResistPercenttreeFunc ( ICustomDataInput param1 ) {this.neutralElementResistPercent = new CharacterBaseCharacteristic();
         this.neutralElementResistPercent.deserializeAsync(this._neutralElementResistPercenttree);
      }
private  void _waterElementResistPercenttreeFunc ( ICustomDataInput param1 ) {this.waterElementResistPercent = new CharacterBaseCharacteristic();
         this.waterElementResistPercent.deserializeAsync(this._waterElementResistPercenttree);
      }
private  void _fireElementResistPercenttreeFunc ( ICustomDataInput param1 ) {this.fireElementResistPercent = new CharacterBaseCharacteristic();
         this.fireElementResistPercent.deserializeAsync(this._fireElementResistPercenttree);
      }
private  void _earthElementReductiontreeFunc ( ICustomDataInput param1 ) {this.earthElementReduction = new CharacterBaseCharacteristic();
         this.earthElementReduction.deserializeAsync(this._earthElementReductiontree);
      }
private  void _airElementReductiontreeFunc ( ICustomDataInput param1 ) {this.airElementReduction = new CharacterBaseCharacteristic();
         this.airElementReduction.deserializeAsync(this._airElementReductiontree);
      }
private  void _pushDamageReductiontreeFunc ( ICustomDataInput param1 ) {this.pushDamageReduction = new CharacterBaseCharacteristic();
         this.pushDamageReduction.deserializeAsync(this._pushDamageReductiontree);
      }
private  void _pvpNeutralElementResistPercenttreeFunc ( ICustomDataInput param1 ) {this.pvpNeutralElementResistPercent = new CharacterBaseCharacteristic();
         this.pvpNeutralElementResistPercent.deserializeAsync(this._pvpNeutralElementResistPercenttree);
      }
private  void _pvpWaterElementResistPercenttreeFunc ( ICustomDataInput param1 ) {this.pvpWaterElementResistPercent = new CharacterBaseCharacteristic();
         this.pvpWaterElementResistPercent.deserializeAsync(this._pvpWaterElementResistPercenttree);
      }
private  void _pvpFireElementResistPercenttreeFunc ( ICustomDataInput param1 ) {this.pvpFireElementResistPercent = new CharacterBaseCharacteristic();
         this.pvpFireElementResistPercent.deserializeAsync(this._pvpFireElementResistPercenttree);
      }
private  void _pvpEarthElementReductiontreeFunc ( ICustomDataInput param1 ) {this.pvpEarthElementReduction = new CharacterBaseCharacteristic();
         this.pvpEarthElementReduction.deserializeAsync(this._pvpEarthElementReductiontree);
      }
private  void _pvpAirElementReductiontreeFunc ( ICustomDataInput param1 ) {this.pvpAirElementReduction = new CharacterBaseCharacteristic();
         this.pvpAirElementReduction.deserializeAsync(this._pvpAirElementReductiontree);
      }
private  void _meleeDamageDonePercenttreeFunc ( ICustomDataInput param1 ) {this.meleeDamageDonePercent = new CharacterBaseCharacteristic();
         this.meleeDamageDonePercent.deserializeAsync(this._meleeDamageDonePercenttree);
      }
private  void _rangedDamageDonePercenttreeFunc ( ICustomDataInput param1 ) {this.rangedDamageDonePercent = new CharacterBaseCharacteristic();
         this.rangedDamageDonePercent.deserializeAsync(this._rangedDamageDonePercenttree);
      }
private  void _weaponDamageDonePercenttreeFunc ( ICustomDataInput param1 ) {this.weaponDamageDonePercent = new CharacterBaseCharacteristic();
         this.weaponDamageDonePercent.deserializeAsync(this._weaponDamageDonePercenttree);
      }
private  void _spellDamageDonePercenttreeFunc ( ICustomDataInput param1 ) {this.spellDamageDonePercent = new CharacterBaseCharacteristic();
         this.spellDamageDonePercent.deserializeAsync(this._spellDamageDonePercenttree);
      }
private  void _spellModificationstreeFunc ( ICustomDataInput param1 ) {var _loc2_:uint = param1.readUnsignedShort();
         var _loc3_:uint = 0;
         while(_loc3_ < _loc2_)
         {
            this._spellModificationstree.addChild(this._spellModificationsFunc);
            _loc3_++;
         }
      }
private  void _probationTimeFunc ( ICustomDataInput param1 ) {this.probationTime = param1.readInt();
         if(this.probationTime < 0)
         {
            throw new Error("Forbidden value (" + this.probationTime + ") on element of CharacterCharacteristicsInformations.probationTime.");
         }
      }
}
