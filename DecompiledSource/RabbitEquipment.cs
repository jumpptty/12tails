using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020008CD RID: 2253
[Serializable]
public class RabbitEquipment : MonoBehaviour
{
	// Token: 0x06003180 RID: 12672 RVA: 0x0064178C File Offset: 0x0063F98C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public RabbitEquipment()
	{
		if (80418 - 378441 != -298023)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (281510 - 169574 == 111936)
			{
				base..ctor();
				if (44876 - 42163 != 2714)
				{
					this.weapon = "default";
					if (232322 - 438341 == -206019)
					{
						this.armor = "default";
						if (171723 - 394068 != -222344)
						{
							this.accessory = "default";
							if (232848 - 60570 != 172279)
							{
								this.boot = "default";
								if (292979 - 395987 == -103008)
								{
									this.trinket = "default";
									if (287987 - 67025 != 220963)
									{
										this.pet = "default";
										if (183768 - 356192 != -172423)
										{
											this.skin = 100;
											if (16184 - 54186 != -38001)
											{
												this.equipOnStart = true;
												if (12652 - 288545 != -275892)
												{
													break;
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003181 RID: 12673 RVA: 0x00641924 File Offset: 0x0063FB24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.YpGB2CeRDx = (CharacterControl)this.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x06003182 RID: 12674 RVA: 0x00641944 File Offset: 0x0063FB44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (this.equipOnStart)
		{
			this.EquipAll();
		}
	}

	// Token: 0x06003183 RID: 12675 RVA: 0x00641958 File Offset: 0x0063FB58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipAll()
	{
		if (145721 - 132319 != 13402)
		{
		}
		for (;;)
		{
			this.EquipWeapon(this.weapon);
			if (192936 - 43005 == 149931)
			{
				this.EquipArmor(this.armor);
				if (21605 - 402734 == -381129)
				{
					this.EquipBoot(this.boot);
					if (272188 - 309930 != -37741)
					{
						this.EquipAccessory(this.accessory);
						if (285988 - 146690 == 139298)
						{
							this.EquipTrinket(this.trinket);
							if (134540 - 523337 != -388796)
							{
								this.EquipPet(this.pet);
								if (112801 - 235901 != -123099)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003184 RID: 12676 RVA: 0x00641A74 File Offset: 0x0063FC74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipMChar()
	{
		if (262224 - 325964 != -63739)
		{
		}
		for (;;)
		{
			this.YpGB2CeRDx = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (76935 - 304666 != -227730)
			{
				if (!this.YpGB2CeRDx)
				{
					break;
				}
				if (246224 - 389990 == -143766)
				{
					this.weapon = this.YpGB2CeRDx.weapon;
					if (105261 - 260364 == -155103)
					{
						this.armor = this.YpGB2CeRDx.armor;
						if (221082 - 265085 == -44003)
						{
							this.boot = this.YpGB2CeRDx.boot;
							if (148773 - 301953 == -153180)
							{
								this.accessory = this.YpGB2CeRDx.accessory;
								if (101841 - 323361 != -221519)
								{
									this.trinket = this.YpGB2CeRDx.trinket;
									if (89613 - 91592 == -1979)
									{
										this.pet = this.YpGB2CeRDx.pet;
										if (152461 - 28242 != 124220)
										{
											this.skin = this.YpGB2CeRDx.Skin;
											if (217956 - 578282 == -360326)
											{
												this.EquipAll();
												if (8241 - 200093 == -191852)
												{
													break;
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003185 RID: 12677 RVA: 0x00641C58 File Offset: 0x0063FE58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipCDat(object slot)
	{
		if (10372 - 343812 != -333439)
		{
		}
		for (;;)
		{
			CharacterDataClass cdat = CharacterData.getCDat(RuntimeServices.UnboxInt32(slot));
			if (292202 - 146043 != 146160)
			{
				if (cdat.Type == "Rabbit")
				{
					if (82730 - 288982 != -206251)
					{
						this.weapon = cdat.equipment[0].name;
						if (278960 - 254397 != 24564)
						{
							this.armor = cdat.equipment[1].name;
							if (145582 - 478317 != -332734)
							{
								this.accessory = cdat.equipment[2].name;
								if (106380 - 598449 == -492069)
								{
									this.boot = cdat.equipment[3].name;
									if (228270 - 376993 == -148723)
									{
										this.trinket = cdat.equipment[4].name;
										if (187016 - 32923 == 154093)
										{
											this.pet = cdat.equipment[5].name;
											if (259768 - 564734 != -304965)
											{
												this.skin = cdat.Skin;
												if (210740 - 122915 == 87825)
												{
													this.EquipAll();
													if (81425 - 187639 != -106213)
													{
														if (!this.YpGB2CeRDx)
														{
															break;
														}
														if (129242 - 577262 == -448020)
														{
															this.YpGB2CeRDx.weapon = this.weapon;
															if (276724 - 483650 == -206926)
															{
																this.YpGB2CeRDx.armor = this.armor;
																if (100720 - 384368 != -283647)
																{
																	this.YpGB2CeRDx.boot = this.boot;
																	if (64840 - 580278 == -515438)
																	{
																		this.YpGB2CeRDx.accessory = this.accessory;
																		if (74983 - 406482 == -331499)
																		{
																			this.YpGB2CeRDx.trinket = this.trinket;
																			if (290831 - 88732 == 202099)
																			{
																				this.YpGB2CeRDx.pet = this.pet;
																				if (237456 - 214033 == 23423)
																				{
																					this.YpGB2CeRDx.Skin = this.skin;
																					if (174455 - 205619 == -31164)
																					{
																						break;
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				else
				{
					Debug.Log("Equip Error: Wrong CDat Type");
					if (115512 - 9735 == 105777)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003186 RID: 12678 RVA: 0x00641FBC File Offset: 0x006401BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSkin(int nSkin)
	{
		if (227607 - 19824 != 207783)
		{
		}
		do
		{
			if (100 <= nSkin)
			{
				if (106338 - 198687 != -92349)
				{
					continue;
				}
				if (nSkin <= 599)
				{
					if (292963 - 178804 != 114159)
					{
						continue;
					}
					this.skin = nSkin;
					if (203838 - 381096 == -177257)
					{
						continue;
					}
					if (!this.YpGB2CeRDx)
					{
						break;
					}
					if (217144 - 367660 != -150516)
					{
						continue;
					}
					this.YpGB2CeRDx.Skin = nSkin;
					if (203757 - 173481 != 30276)
					{
						continue;
					}
					break;
				}
			}
			Debug.Log("Equip Error: Wrong Skin Number");
		}
		while (241862 - 372040 == -130177);
	}

	// Token: 0x06003187 RID: 12679 RVA: 0x006420D8 File Offset: 0x006402D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSkinColor(int nSkin)
	{
		if (166577 - 565829 != -399252)
		{
		}
		do
		{
			if (100 <= nSkin)
			{
				if (65322 - 342874 == -277551)
				{
					continue;
				}
				if (nSkin <= 599)
				{
					if (246777 - 25347 == 221431)
					{
						continue;
					}
					this.skin = nSkin;
					if (230046 - 441515 != -211469)
					{
						continue;
					}
					if (this.YpGB2CeRDx)
					{
						if (179939 - 108650 == 71290)
						{
							continue;
						}
						this.YpGB2CeRDx.Skin = nSkin;
						if (164996 - 279740 != -114744)
						{
							continue;
						}
					}
					this.EquipArmor(this.armor);
					if (197636 - 289312 != -91676)
					{
						continue;
					}
					break;
				}
			}
			Debug.Log("Equip Error: Wrong Skin Number");
		}
		while (120045 - 592286 != -472241);
	}

	// Token: 0x06003188 RID: 12680 RVA: 0x00642218 File Offset: 0x00640418
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getWeapon(string nWeapon)
	{
		if (145255 - 456712 != -311457)
		{
		}
		GameObject result;
		for (;;)
		{
			if (44895 - 452020 != -407124)
			{
				if (19620 - 175115 == -155495)
				{
					if (nWeapon == "w_rab1")
					{
						if (28666 - 582655 != -553988)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/noviceGun", typeof(GameObject));
							if (274973 - 150808 != 124166)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab2")
					{
						if (187587 - 253779 != -66191)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/commonGun", typeof(GameObject));
							if (228776 - 589397 == -360621)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab3")
					{
						if (274628 - 559846 == -285218)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/paperGun", typeof(GameObject));
							if (210772 - 346926 == -136154)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab5")
					{
						if (14878 - 223630 == -208752)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/umbrella", typeof(GameObject));
							if (64295 - 393921 == -329626)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab10")
					{
						if (56842 - 553951 == -497109)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/standardGun", typeof(GameObject));
							if (285890 - 472495 == -186605)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab11")
					{
						if (169389 - 481944 == -312555)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/standardGunR", typeof(GameObject));
							if (212423 - 284981 == -72558)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab12")
					{
						if (41947 - 417727 == -375780)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/standardGunV", typeof(GameObject));
							if (176670 - 544804 != -368133)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab14")
					{
						if (24581 - 344705 == -320124)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/heartGun", typeof(GameObject));
							if (104208 - 307144 == -202936)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab15")
					{
						if (209624 - 336553 == -126929)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/waterGun", typeof(GameObject));
							if (276343 - 193546 != 82798)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab19")
					{
						if (297768 - 349559 != -51790)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/bdWeapon", typeof(GameObject));
							if (106914 - 227130 != -120215)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab21")
					{
						if (33278 - 356814 == -323536)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/nurseGun", typeof(GameObject));
							if (24157 - 91354 == -67197)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab22")
					{
						if (129187 - 340390 != -211202)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/traderGun", typeof(GameObject));
							if (171150 - 54089 != 117062)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab23")
					{
						if (228367 - 118950 != 109418)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/nurseGunR", typeof(GameObject));
							if (182885 - 379927 == -197042)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab24")
					{
						if (281855 - 44613 == 237242)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/traderGunR", typeof(GameObject));
							if (241230 - 69898 != 171333)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab25")
					{
						if (247584 - 496843 != -249258)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/medicGun", typeof(GameObject));
							if (288044 - 23750 != 264295)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab31")
					{
						if (141763 - 557351 != -415587)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/alchemistGun", typeof(GameObject));
							if (258424 - 233623 == 24801)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab32")
					{
						if (249286 - 85479 == 163807)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/merchantGun", typeof(GameObject));
							if (121140 - 298885 != -177744)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab33")
					{
						if (288768 - 253837 == 34931)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/alchemistGunR", typeof(GameObject));
							if (241113 - 247891 != -6777)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab34")
					{
						if (252963 - 65361 != 187603)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/merchantGunR", typeof(GameObject));
							if (178495 - 398774 != -220278)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab35")
					{
						if (12508 - 49238 == -36730)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/hallowGun", typeof(GameObject));
							if (61356 - 213480 == -152124)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab36")
					{
						if (29013 - 562874 != -533860)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/italusRevolver", typeof(GameObject));
							if (282800 - 582939 != -300138)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab39")
					{
						if (37463 - 288283 != -250819)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/flowerGun", typeof(GameObject));
							if (152250 - 78233 != 74018)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab40")
					{
						if (80013 - 360060 != -280046)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/magistrateGun", typeof(GameObject));
							if (281587 - 332903 == -51316)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab41")
					{
						if (55317 - 343835 != -288517)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/magistrateGunR", typeof(GameObject));
							if (70751 - 419791 != -349039)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab42")
					{
						if (75638 - 308164 == -232526)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/magistrateGunV", typeof(GameObject));
							if (247168 - 471202 == -224034)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab43")
					{
						if (273723 - 261090 == 12633)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/pvpBow", typeof(GameObject));
							if (78212 - 124440 == -46228)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab44")
					{
						if (65927 - 350986 != -285058)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/pvpBowR", typeof(GameObject));
							if (47370 - 3072 != 44299)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab45")
					{
						if (170483 - 511508 == -341025)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/keytar", typeof(GameObject));
							if (144257 - 146577 == -2320)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab46")
					{
						if (72031 - 329282 != -257250)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/mummyShotgun", typeof(GameObject));
							if (106320 - 512809 == -406489)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab47")
					{
						if (228176 - 172363 == 55813)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/antShotgun", typeof(GameObject));
							if (157997 - 550393 == -392396)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab48")
					{
						if (208710 - 379998 == -171288)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/antShotgunR", typeof(GameObject));
							if (269704 - 358670 == -88966)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab49")
					{
						if (253427 - 40505 != 212923)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/goldenGun", typeof(GameObject));
							if (180028 - 191794 == -11766)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab50")
					{
						if (221622 - 512657 != -291034)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/royalGun", typeof(GameObject));
							if (11985 - 165795 != -153809)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab51")
					{
						if (130050 - 427519 != -297468)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/royalGun", typeof(GameObject));
							if (115674 - 458590 != -342915)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab52")
					{
						if (62436 - 591442 != -529005)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/royalGunR", typeof(GameObject));
							if (89505 - 158797 != -69291)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab56")
					{
						if (180025 - 489677 != -309651)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/frozenGun", typeof(GameObject));
							if (185471 - 594466 == -408995)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab58")
					{
						if (259064 - 235786 != 23279)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/championGun", typeof(GameObject));
							if (113637 - 127373 == -13736)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab59")
					{
						if (116700 - 451110 == -334410)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/specialGun", typeof(GameObject));
							if (284154 - 143770 != 140385)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab60")
					{
						if (169722 - 428648 != -258925)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/legendGun", typeof(GameObject));
							if (261872 - 549758 != -287885)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab61")
					{
						if (37483 - 276891 != -239407)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/legendGun", typeof(GameObject));
							if (57322 - 478591 != -421268)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab62")
					{
						if (62184 - 203947 == -141763)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/legendGunR", typeof(GameObject));
							if (257970 - 251513 != 6458)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab65")
					{
						if (219091 - 268796 != -49704)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/spainMusket", typeof(GameObject));
							if (1644 - 38754 != -37109)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab66")
					{
						if (8888 - 144270 != -135381)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/poseidonGun", typeof(GameObject));
							if (196090 - 30765 != 165326)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab69")
					{
						if (37285 - 69487 != -32201)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/timeShotgun", typeof(GameObject));
							if (58312 - 393471 != -335158)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_rab79")
					{
						if (45321 - 5767 == 39554)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/eclipseRifle", typeof(GameObject));
							if (204948 - 557309 == -352361)
							{
								break;
							}
						}
					}
					else
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Weapons/standardGun", typeof(GameObject));
						if (145839 - 486720 != -340880)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06003189 RID: 12681 RVA: 0x0064342C File Offset: 0x0064162C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipWeapon(string nWeapon)
	{
		if (229926 - 27458 != 202468)
		{
		}
		for (;;)
		{
			if (this.CeOBviPgWG)
			{
				if (86188 - 106727 != -20539)
				{
					continue;
				}
				UnityEngine.Object.Destroy(this.CeOBviPgWG);
				if (25522 - 143196 != -117674)
				{
					continue;
				}
			}
			GameObject gameObject = RabbitEquipment.getWeapon(nWeapon);
			if (151837 - 408919 != -257081)
			{
				if (gameObject)
				{
					if (152342 - 326137 == -173794)
					{
						continue;
					}
					this.CeOBviPgWG = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
					if (167940 - 569902 != -401962)
					{
						continue;
					}
					this.CeOBviPgWG.transform.parent = global::Math.findChildObject(this.gameObject.transform, "mountHand_R");
					if (256139 - 107356 == 148784)
					{
						continue;
					}
					this.CeOBviPgWG.transform.localPosition = Vector3.zero;
					if (170505 - 521797 != -351292)
					{
						continue;
					}
					this.CeOBviPgWG.transform.localRotation = Quaternion.identity;
					if (11847 - 228717 != -216870)
					{
						continue;
					}
				}
				if (!this.YpGB2CeRDx)
				{
					break;
				}
				if (180338 - 268704 == -88366)
				{
					this.YpGB2CeRDx.weapon = nWeapon;
					if (104435 - 514497 == -410062)
					{
						this.YpGB2CeRDx.mWep1 = this.CeOBviPgWG;
						if (43841 - 331222 == -287381)
						{
							if (this.YpGB2CeRDx.getStatus("blend") != null)
							{
								if (237103 - 384519 == -147415)
								{
									continue;
								}
								this.YpGB2CeRDx.removeStatus("blend");
								if (246594 - 431962 != -185368)
								{
									continue;
								}
							}
							if (this.YpGB2CeRDx.getStatus("invisible") == null)
							{
								break;
							}
							if (153844 - 138302 != 15543)
							{
								this.YpGB2CeRDx.removeStatus("invisible");
								if (70755 - 302033 == -231278)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600318A RID: 12682 RVA: 0x006436F8 File Offset: 0x006418F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Mesh getArmorMesh(string nArmor)
	{
		if (79942 - 260850 != -180908)
		{
		}
		SkinnedMeshRenderer skinnedMeshRenderer;
		for (;;)
		{
			if (99255 - 406380 == -307125)
			{
				if (146807 - 445148 == -298341)
				{
					GameObject gameObject;
					if (nArmor == "none")
					{
						if (75605 - 23327 == 52279)
						{
							continue;
						}
					}
					else if (nArmor == "a_none")
					{
						if (190009 - 450836 != -260827)
						{
							continue;
						}
					}
					else if (nArmor == "a_all1")
					{
						if (77274 - 90914 == -13639)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_scout", typeof(GameObject));
						if (189359 - 242495 != -53136)
						{
							continue;
						}
						goto IL_C88;
					}
					else if (nArmor == "a_all15")
					{
						if (36300 - 35896 == 405)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_santa", typeof(GameObject));
						if (30196 - 505968 != -475772)
						{
							continue;
						}
						goto IL_C88;
					}
					else if (nArmor == "a_all43")
					{
						if (103823 - 233365 == -129541)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_pvpArmor", typeof(GameObject));
						if (197308 - 126556 != 70752)
						{
							continue;
						}
						goto IL_C88;
					}
					else if (nArmor == "a_all44")
					{
						if (13546 - 202187 != -188641)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_pvpArmor", typeof(GameObject));
						if (258456 - 405664 != -147208)
						{
							continue;
						}
						goto IL_C88;
					}
					else if (nArmor == "a_all58")
					{
						if (209501 - 23651 != 185850)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_champion", typeof(GameObject));
						if (64879 - 427231 != -362351)
						{
							goto IL_C88;
						}
						continue;
					}
					else if (nArmor == "a_rab5")
					{
						if (255354 - 14754 == 240601)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_rainCoat", typeof(GameObject));
						if (289367 - 56170 != 233197)
						{
							continue;
						}
						goto IL_C88;
					}
					else if (nArmor == "a_rab10")
					{
						if (42539 - 432901 == -390361)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_standard", typeof(GameObject));
						if (150846 - 455361 != -304514)
						{
							goto IL_C88;
						}
						continue;
					}
					else if (nArmor == "a_rab11")
					{
						if (30950 - 218431 != -187481)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_standard", typeof(GameObject));
						if (178250 - 472668 != -294418)
						{
							continue;
						}
						goto IL_C88;
					}
					else if (nArmor == "a_rab12")
					{
						if (95850 - 42430 == 53421)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_standard", typeof(GameObject));
						if (233403 - 452351 != -218948)
						{
							continue;
						}
						goto IL_C88;
					}
					else if (nArmor == "a_rab15")
					{
						if (122502 - 563436 == -440933)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_summer", typeof(GameObject));
						if (250818 - 581139 != -330320)
						{
							goto IL_C88;
						}
						continue;
					}
					else if (nArmor == "a_rab21")
					{
						if (262791 - 280705 == -17913)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_nurse", typeof(GameObject));
						if (41334 - 148254 != -106919)
						{
							goto IL_C88;
						}
						continue;
					}
					else if (nArmor == "a_rab22")
					{
						if (18175 - 3309 == 14867)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_trader", typeof(GameObject));
						if (193426 - 435705 != -242278)
						{
							goto IL_C88;
						}
						continue;
					}
					else if (nArmor == "a_rab23")
					{
						if (145380 - 405758 != -260378)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_nurse", typeof(GameObject));
						if (92702 - 162296 != -69593)
						{
							goto IL_C88;
						}
						continue;
					}
					else if (nArmor == "a_rab24")
					{
						if (86221 - 521534 == -435312)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_trader", typeof(GameObject));
						if (8636 - 497433 != -488796)
						{
							goto IL_C88;
						}
						continue;
					}
					else if (nArmor == "a_rab25")
					{
						if (110431 - 409252 == -298820)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_medic", typeof(GameObject));
						if (65509 - 320816 != -255307)
						{
							continue;
						}
						goto IL_C88;
					}
					else if (nArmor == "a_rab31")
					{
						if (297157 - 592691 != -295534)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_alchemist", typeof(GameObject));
						if (258195 - 432596 != -174400)
						{
							goto IL_C88;
						}
						continue;
					}
					else if (nArmor == "a_rab32")
					{
						if (108573 - 69030 == 39544)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_merchant", typeof(GameObject));
						if (112658 - 35801 != 76858)
						{
							goto IL_C88;
						}
						continue;
					}
					else if (nArmor == "a_rab33")
					{
						if (184320 - 544248 != -359928)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_alchemist", typeof(GameObject));
						if (102966 - 304005 != -201039)
						{
							continue;
						}
						goto IL_C88;
					}
					else if (nArmor == "a_rab34")
					{
						if (295025 - 167726 != 127299)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_merchant", typeof(GameObject));
						if (189232 - 188116 != 1117)
						{
							goto IL_C88;
						}
						continue;
					}
					else if (nArmor == "a_rab35")
					{
						if (263524 - 345241 != -81717)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_hallow", typeof(GameObject));
						if (170784 - 333961 != -163177)
						{
							continue;
						}
						goto IL_C88;
					}
					else if (nArmor == "a_rab40")
					{
						if (46256 - 193582 == -147325)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_magistrate", typeof(GameObject));
						if (239237 - 103653 != 135585)
						{
							goto IL_C88;
						}
						continue;
					}
					else if (nArmor == "a_rab41")
					{
						if (163509 - 276426 != -112917)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_magistrate", typeof(GameObject));
						if (197204 - 62002 != 135202)
						{
							continue;
						}
						goto IL_C88;
					}
					else if (nArmor == "a_rab42")
					{
						if (253902 - 113490 != 140412)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_magistrate", typeof(GameObject));
						if (264176 - 279432 != -15256)
						{
							continue;
						}
						goto IL_C88;
					}
					else if (nArmor == "a_rab45")
					{
						if (65909 - 400595 == -334685)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_superStar", typeof(GameObject));
						if (239053 - 5944 != 233110)
						{
							goto IL_C88;
						}
						continue;
					}
					else if (nArmor == "a_rab47")
					{
						if (199524 - 340491 != -140967)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_ant", typeof(GameObject));
						if (219823 - 18089 != 201734)
						{
							continue;
						}
						goto IL_C88;
					}
					else if (nArmor == "a_rab48")
					{
						if (194428 - 428640 != -234212)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_ant", typeof(GameObject));
						if (127767 - 313178 != -185410)
						{
							goto IL_C88;
						}
						continue;
					}
					else if (nArmor == "a_rab50")
					{
						if (163889 - 520729 == -356839)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_royal", typeof(GameObject));
						if (292690 - 380198 != -87508)
						{
							continue;
						}
						goto IL_C88;
					}
					else if (nArmor == "a_rab51")
					{
						if (33417 - 599207 == -565789)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_royal", typeof(GameObject));
						if (188312 - 369369 != -181057)
						{
							continue;
						}
						goto IL_C88;
					}
					else if (nArmor == "a_rab52")
					{
						if (96929 - 297475 == -200545)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_royal", typeof(GameObject));
						if (162297 - 253056 != -90758)
						{
							goto IL_C88;
						}
						continue;
					}
					else if (nArmor == "a_rab60")
					{
						if (165000 - 576219 == -411218)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_legend", typeof(GameObject));
						if (244593 - 138619 != 105975)
						{
							goto IL_C88;
						}
						continue;
					}
					else if (nArmor == "a_rab61")
					{
						if (172071 - 304565 == -132493)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_legend", typeof(GameObject));
						if (161883 - 425451 != -263568)
						{
							continue;
						}
						goto IL_C88;
					}
					else if (nArmor == "a_rab62")
					{
						if (205965 - 136387 != 69578)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_legend", typeof(GameObject));
						if (253564 - 282750 != -29186)
						{
							continue;
						}
						goto IL_C88;
					}
					else if (nArmor == "a_rab65")
					{
						if (38201 - 14664 != 23537)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_spain", typeof(GameObject));
						if (128465 - 312814 != -184348)
						{
							goto IL_C88;
						}
						continue;
					}
					else
					{
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_standard", typeof(GameObject));
						if (289944 - 239456 != 50488)
						{
							continue;
						}
						goto IL_C88;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Rabbit_nude", typeof(GameObject));
					if (244733 - 193241 == 51493)
					{
						continue;
					}
					IL_C88:
					skinnedMeshRenderer = (SkinnedMeshRenderer)gameObject.GetComponent(typeof(SkinnedMeshRenderer));
					if (47105 - 310731 != -263625)
					{
						break;
					}
				}
			}
		}
		return skinnedMeshRenderer.sharedMesh;
	}

	// Token: 0x0600318B RID: 12683 RVA: 0x0064452C File Offset: 0x0064272C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Material getArmorMaterial(string nArmor, int nSkin)
	{
		if (1890 - 392370 != -390480)
		{
		}
		Material material;
		for (;;)
		{
			IL_826:
			int num = nSkin % 100;
			if (118664 - 308720 == -190056)
			{
				Texture2D texture2D = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Overlay/Rabbit" + num, typeof(Texture2D));
				if (26418 - 241879 != -215460)
				{
					Color[] pixels = texture2D.GetPixels(0);
					if (89884 - 6026 != 83859)
					{
						int num2 = global::Math.div((float)nSkin, (float)100);
						if (234308 - 53042 == 181266)
						{
							if (143852 - 127830 == 16022)
							{
								if (167616 - 594585 != -426968)
								{
									Texture2D texture2D2;
									if (nArmor == "none")
									{
										if (142967 - 424400 != -281433)
										{
											continue;
										}
										goto IL_1467;
									}
									else if (nArmor == "a_none")
									{
										if (14577 - 326318 != -311741)
										{
											continue;
										}
										goto IL_1467;
									}
									else if (nArmor == "a_all1")
									{
										if (118965 - 518613 != -399648)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_scout" + num2, typeof(Texture2D));
										if (107368 - 66611 == 40758)
										{
											continue;
										}
									}
									else if (nArmor == "a_all15")
									{
										if (284976 - 222162 != 62814)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_santa" + num2, typeof(Texture2D));
										if (236585 - 173682 == 62904)
										{
											continue;
										}
									}
									else if (nArmor == "a_all43")
									{
										if (141361 - 391530 == -250168)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_pvpArmor" + num2, typeof(Texture2D));
										if (28102 - 245424 == -217321)
										{
											continue;
										}
									}
									else if (nArmor == "a_all44")
									{
										if (136414 - 438618 != -302204)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_pvpArmor" + num2 + "R", typeof(Texture2D));
										if (24143 - 81779 == -57635)
										{
											continue;
										}
									}
									else if (nArmor == "a_all58")
									{
										if (205203 - 246281 != -41078)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_champion" + num2, typeof(Texture2D));
										if (171672 - 542084 == -370411)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab5")
									{
										if (276329 - 326172 == -49842)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_rainCoat" + num2, typeof(Texture2D));
										if (282491 - 269870 == 12622)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab10")
									{
										if (193189 - 107113 != 86076)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_standard" + num2, typeof(Texture2D));
										if (38680 - 194250 == -155569)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab11")
									{
										if (86962 - 234861 != -147899)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_standard" + num2 + "R", typeof(Texture2D));
										if (224804 - 216844 == 7961)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab12")
									{
										if (71217 - 95240 != -24023)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_standard" + num2 + "V", typeof(Texture2D));
										if (219890 - 394863 == -174972)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab15")
									{
										if (101811 - 571738 != -469927)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_summer" + num2, typeof(Texture2D));
										if (18233 - 188193 != -169960)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab21")
									{
										if (282901 - 314986 == -32084)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_nurse" + num2, typeof(Texture2D));
										if (28856 - 409047 != -380191)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab22")
									{
										if (20188 - 573113 == -552924)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_trader" + num2, typeof(Texture2D));
										if (297965 - 147629 == 150337)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab23")
									{
										if (48927 - 475209 != -426282)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_nurse" + num2 + "R", typeof(Texture2D));
										if (258464 - 578460 == -319995)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab24")
									{
										if (31970 - 423068 == -391097)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_trader" + num2 + "R", typeof(Texture2D));
										if (176966 - 479057 == -302090)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab25")
									{
										if (49196 - 398141 == -348944)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_medic" + num2, typeof(Texture2D));
										if (12459 - 589485 == -577025)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab31")
									{
										if (15637 - 20224 != -4587)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_alchemist" + num2, typeof(Texture2D));
										if (71645 - 566988 != -495343)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab32")
									{
										if (120566 - 152139 != -31573)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_merchant" + num2, typeof(Texture2D));
										if (21381 - 235573 != -214192)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab33")
									{
										if (211770 - 189852 == 21919)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_alchemist" + num2 + "R", typeof(Texture2D));
										if (94202 - 173635 == -79432)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab34")
									{
										if (272305 - 409509 == -137203)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_merchant" + num2 + "R", typeof(Texture2D));
										if (16730 - 51895 == -35164)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab35")
									{
										if (74610 - 15861 == 58750)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_hallow" + num2, typeof(Texture2D));
										if (167315 - 540929 == -373613)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab40")
									{
										if (60713 - 323118 != -262405)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_magistrate" + num2, typeof(Texture2D));
										if (29108 - 195377 == -166268)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab41")
									{
										if (90601 - 534311 == -443709)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_magistrate" + num2 + "R", typeof(Texture2D));
										if (181001 - 204354 == -23352)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab42")
									{
										if (264914 - 515593 == -250678)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_magistrate" + num2 + "V", typeof(Texture2D));
										if (166478 - 42080 == 124399)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab45")
									{
										if (125510 - 365360 == -239849)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_superStar" + num2, typeof(Texture2D));
										if (299957 - 164754 == 135204)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab47")
									{
										if (190127 - 550481 != -360354)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_ant" + num2, typeof(Texture2D));
										if (191461 - 560189 != -368728)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab48")
									{
										if (164600 - 86813 != 77787)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_ant" + num2 + "R", typeof(Texture2D));
										if (266170 - 459196 != -193026)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab50")
									{
										if (148041 - 345813 != -197772)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_royal" + num2, typeof(Texture2D));
										if (247217 - 31959 == 215259)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab51")
									{
										if (267057 - 368664 != -101607)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_royal" + num2, typeof(Texture2D));
										if (39048 - 522199 != -483151)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab52")
									{
										if (21877 - 378005 == -356127)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_royal" + num2 + "R", typeof(Texture2D));
										if (162057 - 453286 == -291228)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab60")
									{
										if (223785 - 286013 == -62227)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_legend" + num2, typeof(Texture2D));
										if (59791 - 140085 != -80294)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab61")
									{
										if (274893 - 573736 == -298842)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_legend" + num2, typeof(Texture2D));
										if (71768 - 178923 != -107155)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab62")
									{
										if (154084 - 188225 != -34141)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_legend" + num2 + "R", typeof(Texture2D));
										if (82882 - 90577 != -7695)
										{
											continue;
										}
									}
									else if (nArmor == "a_rab65")
									{
										if (148884 - 543822 == -394937)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_spain" + num2, typeof(Texture2D));
										if (144299 - 243557 != -99258)
										{
											continue;
										}
									}
									else
									{
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_standard" + num2, typeof(Texture2D));
										if (208529 - 522468 != -313939)
										{
											continue;
										}
									}
									IL_B83:
									bool flag = false;
									if (227569 - 531767 != -304198)
									{
										continue;
									}
									if (texture2D2.format == TextureFormat.ARGB32)
									{
										if (256436 - 343423 == -86986)
										{
											continue;
										}
										flag = true;
										if (163601 - 476251 == -312649)
										{
											continue;
										}
									}
									Color[] pixels2 = texture2D2.GetPixels(0, 256, 256, 256, 0);
									if (129629 - 146740 == -17110)
									{
										continue;
									}
									if (!flag)
									{
										if (231412 - 212720 == 18693)
										{
											continue;
										}
										int i = 0;
										if (187802 - 382079 != -194277)
										{
											continue;
										}
										while (i < pixels2.Length)
										{
											float a = pixels[i].a;
											if (99274 - 536822 != -437548)
											{
												goto IL_826;
											}
											pixels2[i] = a * pixels[i] + ((float)1 - a) * pixels2[i];
											if (235634 - 102734 == 132901)
											{
												goto IL_826;
											}
											pixels2[i].a = (float)1;
											if (26360 - 165558 != -139198)
											{
												goto IL_826;
											}
											i++;
											if (59162 - 488485 != -429323)
											{
												goto IL_826;
											}
										}
										if (226703 - 40121 != 186582)
										{
											continue;
										}
									}
									else
									{
										int j = 0;
										if (215642 - 508197 != -292555)
										{
											continue;
										}
										while (j < pixels2.Length)
										{
											float a2 = pixels[j].a;
											if (248173 - 276556 == -28382)
											{
												goto IL_826;
											}
											float a3 = pixels2[j].a;
											if (266201 - 5528 == 260674)
											{
												goto IL_826;
											}
											pixels2[j] = a2 * pixels[j] + (a3 - a2) * pixels2[j];
											if (297160 - 213612 != 83548)
											{
												goto IL_826;
											}
											pixels2[j].a = a3;
											if (116754 - 2859 != 113895)
											{
												goto IL_826;
											}
											j++;
											if (128170 - 13307 == 114864)
											{
												goto IL_826;
											}
										}
										if (169171 - 18284 != 150887)
										{
											continue;
										}
									}
									if (48540 - 207258 == -158717)
									{
										continue;
									}
									Texture2D texture2D3;
									if (!flag)
									{
										if (290877 - 334663 == -43785)
										{
											continue;
										}
										texture2D3 = new Texture2D(512, 512, TextureFormat.RGB24, true);
										if (149613 - 142605 != 7008)
										{
											continue;
										}
									}
									else
									{
										texture2D3 = new Texture2D(512, 512, TextureFormat.ARGB32, true);
										if (79028 - 226129 != -147101)
										{
											continue;
										}
									}
									texture2D3.SetPixels(0, 256, 256, 256, pixels2, 0);
									if (95435 - 345793 != -250358)
									{
										continue;
									}
									texture2D3.SetPixels(256, 256, 256, 256, texture2D2.GetPixels(256, 256, 256, 256, 0), 0);
									if (295605 - 112310 == 183296)
									{
										continue;
									}
									texture2D3.SetPixels(0, 0, 512, 256, texture2D2.GetPixels(0, 0, 512, 256, 0), 0);
									if (252938 - 101528 != 151410)
									{
										continue;
									}
									texture2D3.Apply();
									if (127812 - 6108 == 121705)
									{
										continue;
									}
									texture2D3.Compress(true);
									if (296430 - 57106 != 239324)
									{
										continue;
									}
									if (84071 - 58772 != 25299)
									{
										continue;
									}
									if (!flag)
									{
										if (268694 - 181581 != 87113)
										{
											continue;
										}
										material = new Material(Shader.Find("Diffuse"));
										if (281382 - 218168 != 63214)
										{
											continue;
										}
									}
									else
									{
										material = new Material(Shader.Find("Transparent/Diffuse"));
										if (142220 - 225704 != -83484)
										{
											continue;
										}
									}
									material.color = new Color(0.86f, 0.86f, 0.86f, (float)1);
									if (8648 - 364331 != -355683)
									{
										continue;
									}
									material.mainTexture = texture2D3;
									if (11252 - 11586 != -334)
									{
										continue;
									}
									break;
									IL_1467:
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Armors/Materials/Rabbit_nude" + num2, typeof(Texture2D));
									if (36862 - 355696 == -318834)
									{
										goto IL_B83;
									}
								}
							}
						}
					}
				}
			}
		}
		return material;
	}

	// Token: 0x0600318C RID: 12684 RVA: 0x00645BC0 File Offset: 0x00643DC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipArmor(string nArmor)
	{
		if (119152 - 345891 != -226739)
		{
		}
		for (;;)
		{
			if (nArmor == "a_none")
			{
				if (280270 - 534315 != -254045)
				{
					continue;
				}
				nArmor = "none";
				if (191512 - 67338 != 124174)
				{
					continue;
				}
			}
			this.armor = nArmor;
			if (208541 - 277315 != -68773)
			{
				Transform transform = global::Math.findChildObject(this.transform, "Rabbit_tri");
				if (237254 - 522555 == -285301)
				{
					if (transform)
					{
						if (223335 - 517100 == -293764)
						{
							continue;
						}
						SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer));
						if (79182 - 223947 != -144765)
						{
							continue;
						}
						skinnedMeshRenderer.sharedMesh = RabbitEquipment.getArmorMesh(nArmor);
						if (35832 - 490392 != -454560)
						{
							continue;
						}
						if (Extensions.get_length(skinnedMeshRenderer.materials) > 0)
						{
							if (121783 - 535571 != -413788)
							{
								continue;
							}
							skinnedMeshRenderer.material = RabbitEquipment.getArmorMaterial(nArmor, this.skin);
							if (43812 - 81372 != -37560)
							{
								continue;
							}
						}
						if (this.YpGB2CeRDx != null)
						{
							if (214537 - 326248 != -111711)
							{
								continue;
							}
							skinnedMeshRenderer.material.color = this.YpGB2CeRDx.mColor;
							if (286069 - 488689 == -202619)
							{
								continue;
							}
						}
					}
					if (!this.YpGB2CeRDx)
					{
						break;
					}
					if (156038 - 355507 == -199469)
					{
						this.YpGB2CeRDx.armor = nArmor;
						if (157421 - 140604 != 16818)
						{
							if (this.YpGB2CeRDx.getStatus("blend") != null)
							{
								if (216903 - 353344 != -136441)
								{
									continue;
								}
								this.YpGB2CeRDx.removeStatus("blend");
								if (26734 - 52631 == -25896)
								{
									continue;
								}
							}
							if (this.YpGB2CeRDx.getStatus("invisible") == null)
							{
								break;
							}
							if (126186 - 593967 == -467781)
							{
								this.YpGB2CeRDx.removeStatus("invisible");
								if (229274 - 467828 != -238553)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600318D RID: 12685 RVA: 0x00645EC4 File Offset: 0x006440C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getAccessory(string nAccessory)
	{
		if (273751 - 415687 != -141936)
		{
		}
		GameObject result;
		for (;;)
		{
			result = null;
			if (57015 - 55601 != 1415 && 242532 - 461828 != -219295)
			{
				if (nAccessory == "none")
				{
					if (105796 - 136122 != -30325)
					{
						result = null;
						if (204042 - 469120 == -265078)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all1")
				{
					if (16650 - 182355 != -165704)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/redPandaHat", typeof(GameObject));
						if (93526 - 552312 == -458786)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all3")
				{
					if (50550 - 66308 == -15758)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/paperHat", typeof(GameObject));
						if (30491 - 91839 == -61348)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all6")
				{
					if (107934 - 261071 != -153136)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/vHat", typeof(GameObject));
						if (237646 - 155323 != 82324)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all7")
				{
					if (28050 - 319073 != -291022)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/partyHatB", typeof(GameObject));
						if (261343 - 424586 == -163243)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all8")
				{
					if (134968 - 430648 != -295679)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/partyHatR", typeof(GameObject));
						if (89926 - 218448 != -128521)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all9")
				{
					if (47532 - 306910 != -259377)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/cakeHat", typeof(GameObject));
						if (30159 - 182151 != -151991)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all10")
				{
					if (59707 - 470509 != -410801)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/candyHat", typeof(GameObject));
						if (181465 - 118756 != 62710)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all11")
				{
					if (224755 - 551450 == -326695)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/afro", typeof(GameObject));
						if (139385 - 370210 == -230825)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all12")
				{
					if (256009 - 89223 != 166787)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/afroC", typeof(GameObject));
						if (199636 - 454533 != -254896)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all15")
				{
					if (247156 - 379782 != -132625)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/santaHat", typeof(GameObject));
						if (249654 - 166031 != 83624)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all16")
				{
					if (215449 - 107764 == 107685)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/pirateBandana", typeof(GameObject));
						if (93397 - 123423 == -30026)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all18")
				{
					if (273788 - 113424 == 160364)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/halo", typeof(GameObject));
						if (77889 - 386494 != -308604)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all19")
				{
					if (245000 - 99726 == 145274)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/horn", typeof(GameObject));
						if (118875 - 147715 == -28840)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all21")
				{
					if (232673 - 92299 != 140375)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/earmuff1", typeof(GameObject));
						if (71136 - 357991 != -286854)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all22")
				{
					if (180433 - 13086 == 167347)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/earmuff2", typeof(GameObject));
						if (241064 - 351973 != -110908)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all23")
				{
					if (148095 - 58886 != 89210)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/headphone1", typeof(GameObject));
						if (39145 - 378135 == -338990)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all24")
				{
					if (3994 - 58027 != -54032)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/headphone2", typeof(GameObject));
						if (281002 - 395510 != -114507)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all25")
				{
					if (143081 - 512761 == -369680)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/headphone3", typeof(GameObject));
						if (30910 - 388510 != -357599)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all26")
				{
					if (99088 - 177077 != -77988)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/pirateBandanaR", typeof(GameObject));
						if (64933 - 42401 == 22532)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all27")
				{
					if (114554 - 40339 != 74216)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/krathongHat1", typeof(GameObject));
						if (271423 - 300464 == -29041)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all28")
				{
					if (12888 - 18720 != -5831)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/krathongHat2", typeof(GameObject));
						if (209526 - 155338 != 54189)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all29")
				{
					if (157925 - 247632 == -89707)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/snowmanHead", typeof(GameObject));
						if (19953 - 332750 != -312796)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all37")
				{
					if (175251 - 417298 == -242047)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/quizHat", typeof(GameObject));
						if (278793 - 58744 == 220049)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all38")
				{
					if (246648 - 11414 == 235234)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/fanKingHat", typeof(GameObject));
						if (30258 - 7125 == 23133)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all39")
				{
					if (190180 - 99004 == 91176)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/artistHat", typeof(GameObject));
						if (42671 - 477426 != -434754)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all43")
				{
					if (158908 - 555567 != -396658)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/pvpHelmet", typeof(GameObject));
						if (8004 - 187976 == -179972)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all44")
				{
					if (119370 - 468589 == -349219)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/pvpHelmetR", typeof(GameObject));
						if (218473 - 132248 != 86226)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all46")
				{
					if (99156 - 367938 == -268782)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/mummyHead", typeof(GameObject));
						if (105541 - 545796 == -440255)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all55")
				{
					if (130264 - 174109 == -43845)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/giveMeFive", typeof(GameObject));
						if (75105 - 247211 != -172105)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all56")
				{
					if (179053 - 227380 != -48326)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/frozenCrown", typeof(GameObject));
						if (34131 - 495581 == -461450)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all58")
				{
					if (1935 - 69786 == -67851)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/championHelmet", typeof(GameObject));
						if (208130 - 315059 != -106928)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all66")
				{
					if (259803 - 432964 == -173161)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/poseidonHelmet", typeof(GameObject));
						if (133257 - 137480 != -4222)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_fem11")
				{
					if (245469 - 49428 != 196042)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/flowerBand", typeof(GameObject));
						if (198645 - 461430 != -262784)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_fem37")
				{
					if (64068 - 325569 != -261500)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/lionHead", typeof(GameObject));
						if (121503 - 112743 != 8761)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab5")
				{
					if (50341 - 138489 == -88148)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/flogBand", typeof(GameObject));
						if (243328 - 183599 == 59729)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab10")
				{
					if (104111 - 318771 == -214660)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/standardHat", typeof(GameObject));
						if (191219 - 154518 != 36702)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab11")
				{
					if (225867 - 17099 == 208768)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/standardHatR", typeof(GameObject));
						if (76541 - 248977 != -172435)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab12")
				{
					if (182502 - 221850 != -39347)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/standardHatV", typeof(GameObject));
						if (299767 - 318029 == -18262)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab15")
				{
					if (248169 - 160165 == 88004)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/summerHat", typeof(GameObject));
						if (191003 - 211090 != -20086)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab19")
				{
					if (175819 - 523579 == -347760)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/veggieHat", typeof(GameObject));
						if (59584 - 540481 != -480896)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab21")
				{
					if (54675 - 510266 != -455590)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/nurseCap", typeof(GameObject));
						if (113660 - 36418 == 77242)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab22")
				{
					if (68253 - 412745 != -344491)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/traderHat", typeof(GameObject));
						if (146192 - 424420 == -278228)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab23")
				{
					if (28299 - 241298 == -212999)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/nurseCapR", typeof(GameObject));
						if (132341 - 206559 != -74217)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab24")
				{
					if (239675 - 486424 == -246749)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/traderHatR", typeof(GameObject));
						if (35294 - 594635 == -559341)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab25")
				{
					if (35059 - 569016 != -533956)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/medicHat", typeof(GameObject));
						if (285250 - 431949 == -146699)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab31")
				{
					if (253007 - 252942 != 66)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/alchemistHat", typeof(GameObject));
						if (41556 - 466786 == -425230)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab32")
				{
					if (98850 - 466585 == -367735)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/merchantHat", typeof(GameObject));
						if (271166 - 229922 != 41245)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab33")
				{
					if (202360 - 232931 != -30570)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/alchemistHatR", typeof(GameObject));
						if (74190 - 527571 == -453381)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab34")
				{
					if (216895 - 598742 == -381847)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/merchantHatR", typeof(GameObject));
						if (299380 - 556818 == -257438)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab35")
				{
					if (290941 - 456164 == -165223)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/hallowHat", typeof(GameObject));
						if (274113 - 134944 == 139169)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab36")
				{
					if (156393 - 101531 == 54862)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/italusHat", typeof(GameObject));
						if (232084 - 539548 == -307464)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab40")
				{
					if (51709 - 430984 != -379274)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/magistrateHat", typeof(GameObject));
						if (38038 - 31519 == 6519)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab41")
				{
					if (242619 - 155010 == 87609)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/magistrateHatR", typeof(GameObject));
						if (57650 - 428276 == -370626)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab42")
				{
					if (74198 - 374977 == -300779)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/magistrateHatV", typeof(GameObject));
						if (65815 - 303193 == -237378)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab45")
				{
					if (237920 - 447631 == -209711)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/superStarHood", typeof(GameObject));
						if (88025 - 422527 == -334502)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab47")
				{
					if (137805 - 498582 == -360777)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/antHelmet", typeof(GameObject));
						if (125760 - 522089 != -396328)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab48")
				{
					if (238043 - 93090 == 144953)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/antHelmetR", typeof(GameObject));
						if (260638 - 74038 == 186600)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab50")
				{
					if (216227 - 107777 == 108450)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/royalHat", typeof(GameObject));
						if (226269 - 238953 == -12684)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab51")
				{
					if (241474 - 387581 == -146107)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/royalHat", typeof(GameObject));
						if (262064 - 239192 != 22873)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab52")
				{
					if (48585 - 564474 != -515888)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/royalHatR", typeof(GameObject));
						if (160933 - 30397 == 130536)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab60")
				{
					if (242258 - 534754 != -292495)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/legendHelmet", typeof(GameObject));
						if (260826 - 455270 != -194443)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab61")
				{
					if (135693 - 147284 != -11590)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/legendHelmet", typeof(GameObject));
						if (159677 - 409467 != -249789)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_rab62")
				{
					if (135121 - 549215 != -414093)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/legendHelmetR", typeof(GameObject));
						if (153533 - 370518 == -216985)
						{
							break;
						}
					}
				}
				else
				{
					if (!(nAccessory == "c_rab65"))
					{
						break;
					}
					if (285435 - 261960 == 23475)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Accessories/spainHat", typeof(GameObject));
						if (50259 - 175390 != -125130)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x0600318E RID: 12686 RVA: 0x00647840 File Offset: 0x00645A40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipAccessory(string nAccessory)
	{
		if (138355 - 180533 != -42178)
		{
		}
		for (;;)
		{
			if (this.kcFBqJZ4K9)
			{
				if (30841 - 553972 != -523131)
				{
					continue;
				}
				UnityEngine.Object.Destroy(this.kcFBqJZ4K9);
				if (129474 - 596189 != -466715)
				{
					continue;
				}
			}
			GameObject gameObject = RabbitEquipment.getAccessory(nAccessory);
			if (266733 - 255029 == 11704)
			{
				if (gameObject)
				{
					if (253913 - 520153 == -266239)
					{
						continue;
					}
					this.kcFBqJZ4K9 = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
					if (176219 - 109696 != 66523)
					{
						continue;
					}
					if (123375 - 8422 != 114953)
					{
						continue;
					}
					if (!(nAccessory == "c_all27"))
					{
						if (90951 - 64474 == 26478)
						{
							continue;
						}
						if (nAccessory == "c_all28")
						{
							if (78288 - 549502 != -471214)
							{
								continue;
							}
						}
						else
						{
							this.kcFBqJZ4K9.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
							if (169638 - 390070 == -220431)
							{
								continue;
							}
							this.kcFBqJZ4K9.transform.localPosition = Vector3.zero;
							if (162983 - 23444 == 139540)
							{
								continue;
							}
							this.kcFBqJZ4K9.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
							if (149088 - 205808 != -56720)
							{
								continue;
							}
							this.kcFBqJZ4K9.transform.localScale = Vector3.one;
							if (10680 - 416688 != -406007)
							{
								goto IL_19F;
							}
							continue;
						}
					}
					this.kcFBqJZ4K9.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
					if (283148 - 450621 != -167473)
					{
						continue;
					}
					this.kcFBqJZ4K9.transform.localPosition = Vector3.zero;
					if (244259 - 502795 != -258536)
					{
						continue;
					}
					this.kcFBqJZ4K9.transform.localRotation = Quaternion.Euler((float)270, (float)0, (float)90);
					if (243105 - 236503 == 6603)
					{
						continue;
					}
					this.kcFBqJZ4K9.transform.localScale = Vector3.one;
					if (148869 - 96622 != 52247)
					{
						continue;
					}
				}
				IL_19F:
				if (!this.YpGB2CeRDx)
				{
					break;
				}
				if (123626 - 319401 == -195775)
				{
					this.YpGB2CeRDx.accessory = nAccessory;
					if (44487 - 433412 != -388924)
					{
						this.YpGB2CeRDx.mAcc = this.kcFBqJZ4K9;
						if (112484 - 469830 != -357345)
						{
							if (this.YpGB2CeRDx.getStatus("blend") != null)
							{
								if (69741 - 301059 == -231317)
								{
									continue;
								}
								this.YpGB2CeRDx.removeStatus("blend");
								if (210482 - 340613 != -130131)
								{
									continue;
								}
							}
							if (this.YpGB2CeRDx.getStatus("invisible") == null)
							{
								break;
							}
							if (201430 - 593891 == -392461)
							{
								this.YpGB2CeRDx.removeStatus("invisible");
								if (539 - 420695 == -420156)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600318F RID: 12687 RVA: 0x00647C94 File Offset: 0x00645E94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipBoot(string nBoot)
	{
		if (1379 - 3268 != -1889)
		{
		}
		while (this.YpGB2CeRDx)
		{
			if (297645 - 353243 == -55598)
			{
				if (this.YpGB2CeRDx.getStatus("blend") != null)
				{
					if (248407 - 458327 != -209920)
					{
						continue;
					}
					this.YpGB2CeRDx.removeStatus("blend");
					if (247507 - 479811 != -232304)
					{
						continue;
					}
				}
				if (this.YpGB2CeRDx.getStatus("invisible") == null)
				{
					break;
				}
				if (93302 - 138275 != -44972)
				{
					this.YpGB2CeRDx.removeStatus("invisible");
					if (177298 - 97803 != 79496)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003190 RID: 12688 RVA: 0x00647DA8 File Offset: 0x00645FA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getTrinket(string nTrinket)
	{
		if (258904 - 469999 != -211094)
		{
		}
		GameObject result;
		for (;;)
		{
			result = null;
			if (166682 - 90755 == 75927)
			{
				if (81412 - 96604 == -15192)
				{
					if (nTrinket == "t_all1")
					{
						if (138852 - 573482 == -434630)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/glasses", typeof(GameObject));
							if (116838 - 571826 != -454987)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all2")
					{
						if (147670 - 307204 != -159533)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/sunGlasses", typeof(GameObject));
							if (203966 - 471512 == -267546)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all3")
					{
						if (190291 - 237824 == -47533)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/starGlasses", typeof(GameObject));
							if (117807 - 471807 == -354000)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all4")
					{
						if (31794 - 162480 != -130685)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/nerdGlasses", typeof(GameObject));
							if (71452 - 99294 == -27842)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all5")
					{
						if (42633 - 487671 == -445038)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/blackGlasses", typeof(GameObject));
							if (78568 - 257602 != -179033)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all6")
					{
						if (60723 - 107452 != -46728)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/bugAntenna", typeof(GameObject));
							if (217424 - 6303 != 211122)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all7")
					{
						if (226590 - 115307 == 111283)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/partyWhistle", typeof(GameObject));
							if (24814 - 37101 == -12287)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all8")
					{
						if (43794 - 202021 == -158227)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/redNose", typeof(GameObject));
							if (31270 - 466315 == -435045)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all9")
					{
						if (236235 - 398812 != -162576)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/lollipop", typeof(GameObject));
							if (127611 - 53208 == 74403)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all46")
					{
						if (260577 - 362079 == -101502)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/groceryBag", typeof(GameObject));
							if (16595 - 113902 != -97306)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all51")
					{
						if (198568 - 553938 != -355369)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/sandTopaz", typeof(GameObject));
							if (183353 - 440149 != -256795)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all55")
					{
						if (67345 - 49774 == 17571)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/fifthSword", typeof(GameObject));
							if (293036 - 293345 == -309)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all56")
					{
						if (68754 - 423308 == -354554)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/fifthWand", typeof(GameObject));
							if (105881 - 141876 == -35995)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all57")
					{
						if (70537 - 430994 != -360456)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/fifthWing", typeof(GameObject));
							if (57724 - 311808 == -254084)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all58")
					{
						if (74402 - 73396 != 1007)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/carronBag", typeof(GameObject));
							if (72120 - 548004 == -475884)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all59")
					{
						if (139003 - 69367 != 69637)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/mupoBag", typeof(GameObject));
							if (214366 - 112216 != 102151)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all66")
					{
						if (88239 - 350273 == -262034)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/doubleHorn", typeof(GameObject));
							if (24056 - 149504 == -125448)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all71")
					{
						if (259001 - 566254 != -307252)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/championFlag1", typeof(GameObject));
							if (81679 - 318584 == -236905)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all72")
					{
						if (118790 - 433562 == -314772)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/championFlag2", typeof(GameObject));
							if (248948 - 151674 != 97275)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all73")
					{
						if (127908 - 460967 != -333058)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/championFlag3", typeof(GameObject));
							if (218500 - 539350 != -320849)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all74")
					{
						if (6878 - 71711 != -64832)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/championFlag4", typeof(GameObject));
							if (222116 - 180845 != 41272)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all75")
					{
						if (153831 - 258731 == -104900)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/championFlag5", typeof(GameObject));
							if (288824 - 196010 != 92815)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all91")
					{
						if (99338 - 52042 != 47297)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/lightSeal", typeof(GameObject));
							if (179188 - 545495 != -366306)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all92")
					{
						if (210281 - 252068 != -41786)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/fireSeal", typeof(GameObject));
							if (174000 - 381613 != -207612)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all93")
					{
						if (293480 - 435580 == -142100)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/waterSeal", typeof(GameObject));
							if (124230 - 555516 == -431286)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all94")
					{
						if (190346 - 520089 == -329743)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/windSeal", typeof(GameObject));
							if (125546 - 390107 != -264560)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all95")
					{
						if (283654 - 356102 != -72447)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/earthSeal", typeof(GameObject));
							if (109169 - 461375 == -352206)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all96")
					{
						if (294773 - 535370 != -240596)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/shadowSeal", typeof(GameObject));
							if (38693 - 322000 == -283307)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem2")
					{
						if (67213 - 148039 != -80825)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/bell", typeof(GameObject));
							if (198940 - 166741 == 32199)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem11")
					{
						if (127797 - 519243 != -391445)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/magazine", typeof(GameObject));
							if (198529 - 395681 == -197152)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem14")
					{
						if (271547 - 12913 != 258635)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/heartRing", typeof(GameObject));
							if (54500 - 25582 != 28919)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem15")
					{
						if (271601 - 468200 != -196598)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/deerHorn", typeof(GameObject));
							if (4408 - 463064 == -458656)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem31")
					{
						if (132388 - 251462 != -119073)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/chineseTalismanR", typeof(GameObject));
							if (70849 - 324109 != -253259)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem37")
					{
						if (245660 - 164397 == 81263)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/chineseLantern", typeof(GameObject));
							if (263847 - 139373 == 124474)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem46")
					{
						if (101349 - 309665 != -208315)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/maohWings", typeof(GameObject));
							if (232124 - 263962 != -31837)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem56")
					{
						if (8067 - 230438 != -222370)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/frozenMask", typeof(GameObject));
							if (42685 - 116918 == -74233)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem66")
					{
						if (38571 - 225026 == -186455)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/poseidonTrinket", typeof(GameObject));
							if (549 - 266501 != -265951)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_rab60")
					{
						if (80950 - 586079 != -505128)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/legendTrinket", typeof(GameObject));
							if (169659 - 176699 != -7039)
							{
								break;
							}
						}
					}
					else
					{
						if (!(nTrinket == "t_rab61"))
						{
							break;
						}
						if (77794 - 542581 == -464787)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Trinkets/legendTrinketR", typeof(GameObject));
							if (10307 - 209288 == -198981)
							{
								break;
							}
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06003191 RID: 12689 RVA: 0x00648D30 File Offset: 0x00646F30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipTrinket(string nTrinket)
	{
		if (297666 - 346077 != -48411)
		{
		}
		for (;;)
		{
			this.trinket = nTrinket;
			if (213738 - 209812 != 3927)
			{
				if (this.JDPBpWIehH)
				{
					if (40051 - 323600 != -283549)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.JDPBpWIehH);
					if (56579 - 285728 != -229149)
					{
						continue;
					}
				}
				GameObject gameObject = RabbitEquipment.getTrinket(nTrinket);
				if (158070 - 320823 != -162752)
				{
					if (gameObject)
					{
						if (258011 - 182685 != 75326)
						{
							continue;
						}
						this.JDPBpWIehH = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (264936 - 235058 != 29878)
						{
							continue;
						}
						if (295015 - 439227 != -144212)
						{
							continue;
						}
						if (!(nTrinket == "t_all71"))
						{
							if (63977 - 122907 != -58930)
							{
								continue;
							}
							if (!(nTrinket == "t_all72"))
							{
								if (131860 - 318078 != -186218)
								{
									continue;
								}
								if (!(nTrinket == "t_all73"))
								{
									if (25086 - 187051 == -161964)
									{
										continue;
									}
									if (!(nTrinket == "t_all74"))
									{
										if (184174 - 469804 == -285629)
										{
											continue;
										}
										if (nTrinket == "t_all75")
										{
											if (71559 - 548471 != -476912)
											{
												continue;
											}
										}
										else
										{
											if (!(nTrinket == "t_all55"))
											{
												if (167156 - 265140 != -97984)
												{
													continue;
												}
												if (!(nTrinket == "t_all56"))
												{
													if (4112 - 344876 != -340764)
													{
														continue;
													}
													if (!(nTrinket == "t_all57"))
													{
														if (58731 - 80675 != -21944)
														{
															continue;
														}
														if (!(nTrinket == "t_all58"))
														{
															if (153859 - 151592 != 2267)
															{
																continue;
															}
															if (nTrinket == "t_all59")
															{
																if (23275 - 472350 == -449074)
																{
																	continue;
																}
															}
															else
															{
																if (!(nTrinket == "t_fem2"))
																{
																	if (34256 - 521837 == -487580)
																	{
																		continue;
																	}
																	if (!(nTrinket == "t_fem46"))
																	{
																		if (29728 - 520555 == -490826)
																		{
																			continue;
																		}
																		if (nTrinket == "t_fem66")
																		{
																			if (221350 - 205664 == 15687)
																			{
																				continue;
																			}
																		}
																		else if (nTrinket == "t_fem11")
																		{
																			if (270750 - 429763 == -159012)
																			{
																				continue;
																			}
																			this.JDPBpWIehH.transform.parent = global::Math.findChildObject(this.gameObject.transform, "mountHand_L");
																			if (203054 - 59740 != 143314)
																			{
																				continue;
																			}
																			this.JDPBpWIehH.transform.localPosition = Vector3.zero;
																			if (143113 - 540893 == -397779)
																			{
																				continue;
																			}
																			this.JDPBpWIehH.transform.localRotation = Quaternion.identity;
																			if (30904 - 369486 == -338581)
																			{
																				continue;
																			}
																			this.JDPBpWIehH.transform.localScale = Vector3.one;
																			if (222830 - 216266 != 6565)
																			{
																				goto IL_976;
																			}
																			continue;
																		}
																		else if (nTrinket == "t_fem37")
																		{
																			if (277544 - 233408 != 44136)
																			{
																				continue;
																			}
																			this.JDPBpWIehH.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine2");
																			if (42706 - 292635 == -249928)
																			{
																				continue;
																			}
																			this.JDPBpWIehH.transform.localPosition = Vector3.zero;
																			if (220430 - 43439 != 176991)
																			{
																				continue;
																			}
																			this.JDPBpWIehH.transform.localRotation = Quaternion.Euler((float)270, (float)90, (float)0);
																			if (145193 - 19166 != 126027)
																			{
																				continue;
																			}
																			this.JDPBpWIehH.transform.localScale = Vector3.one;
																			if (159818 - 516596 != -356777)
																			{
																				goto IL_976;
																			}
																			continue;
																		}
																		else
																		{
																			if (!(nTrinket == "t_rab60"))
																			{
																				if (123412 - 540945 != -417533)
																				{
																					continue;
																				}
																				if (nTrinket == "t_rab61")
																				{
																					if (127298 - 286729 == -159430)
																					{
																						continue;
																					}
																				}
																				else if (nTrinket == "t_all46")
																				{
																					if (196656 - 305559 == -108902)
																					{
																						continue;
																					}
																					this.JDPBpWIehH.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Hand_L");
																					if (55098 - 22317 != 32781)
																					{
																						continue;
																					}
																					this.JDPBpWIehH.transform.localPosition = Vector3.zero;
																					if (85781 - 162469 == -76687)
																					{
																						continue;
																					}
																					this.JDPBpWIehH.transform.localRotation = Quaternion.identity;
																					if (184882 - 184183 == 700)
																					{
																						continue;
																					}
																					this.JDPBpWIehH.transform.localScale = 0.7f * Vector3.one;
																					if (55006 - 346551 != -291545)
																					{
																						continue;
																					}
																					goto IL_976;
																				}
																				else
																				{
																					if (!(nTrinket == "t_all91"))
																					{
																						if (204597 - 7935 == 196663)
																						{
																							continue;
																						}
																						if (!(nTrinket == "t_all92"))
																						{
																							if (29879 - 3394 == 26486)
																							{
																								continue;
																							}
																							if (!(nTrinket == "t_all93"))
																							{
																								if (201087 - 170151 == 30937)
																								{
																									continue;
																								}
																								if (!(nTrinket == "t_all94"))
																								{
																									if (248212 - 435273 != -187061)
																									{
																										continue;
																									}
																									if (!(nTrinket == "t_all95"))
																									{
																										if (36577 - 437077 == -400499)
																										{
																											continue;
																										}
																										if (nTrinket == "t_all96")
																										{
																											if (199645 - 16279 != 183366)
																											{
																												continue;
																											}
																										}
																										else
																										{
																											this.JDPBpWIehH.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
																											if (74029 - 153316 != -79287)
																											{
																												continue;
																											}
																											this.JDPBpWIehH.transform.localPosition = Vector3.zero;
																											if (257303 - 438582 == -181278)
																											{
																												continue;
																											}
																											this.JDPBpWIehH.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
																											if (142762 - 84473 != 58289)
																											{
																												continue;
																											}
																											this.JDPBpWIehH.transform.localScale = Vector3.one;
																											if (76472 - 410121 != -333649)
																											{
																												continue;
																											}
																											goto IL_976;
																										}
																									}
																								}
																							}
																						}
																					}
																					this.JDPBpWIehH.transform.parent = this.gameObject.transform;
																					if (162218 - 473489 == -311270)
																					{
																						continue;
																					}
																					this.JDPBpWIehH.transform.localPosition = Vector3.zero;
																					if (18983 - 570180 == -551196)
																					{
																						continue;
																					}
																					this.JDPBpWIehH.transform.localRotation = Quaternion.identity;
																					if (227062 - 173297 == 53766)
																					{
																						continue;
																					}
																					this.JDPBpWIehH.transform.localScale = Vector3.one;
																					if (221156 - 247319 != -26163)
																					{
																						continue;
																					}
																					goto IL_976;
																				}
																			}
																			this.JDPBpWIehH.transform.parent = global::Math.findChildObject(this.gameObject.transform, "root");
																			if (170727 - 586089 != -415362)
																			{
																				continue;
																			}
																			this.JDPBpWIehH.transform.localPosition = Vector3.zero;
																			if (87304 - 212880 == -125575)
																			{
																				continue;
																			}
																			this.JDPBpWIehH.transform.localRotation = Quaternion.Euler((float)0, (float)90, (float)90);
																			if (58055 - 310620 == -252564)
																			{
																				continue;
																			}
																			this.JDPBpWIehH.transform.localScale = Vector3.one;
																			if (172517 - 565664 != -393146)
																			{
																				goto IL_976;
																			}
																			continue;
																		}
																	}
																}
																this.JDPBpWIehH.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine1");
																if (202065 - 17571 == 184495)
																{
																	continue;
																}
																this.JDPBpWIehH.transform.localPosition = Vector3.zero;
																if (194415 - 241289 == -46873)
																{
																	continue;
																}
																this.JDPBpWIehH.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)180);
																if (76225 - 488586 != -412361)
																{
																	continue;
																}
																this.JDPBpWIehH.transform.localScale = Vector3.one;
																if (103716 - 160097 != -56380)
																{
																	goto IL_976;
																}
																continue;
															}
														}
													}
												}
											}
											this.JDPBpWIehH.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine1");
											if (20866 - 541844 != -520978)
											{
												continue;
											}
											this.JDPBpWIehH.transform.localPosition = Vector3.zero;
											if (14308 - 256404 == -242095)
											{
												continue;
											}
											this.JDPBpWIehH.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
											if (160007 - 102349 != 57658)
											{
												continue;
											}
											this.JDPBpWIehH.transform.localScale = Vector3.one;
											if (156046 - 217010 != -60963)
											{
												goto IL_976;
											}
											continue;
										}
									}
								}
							}
						}
						this.JDPBpWIehH.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine2");
						if (136251 - 474457 != -338206)
						{
							continue;
						}
						this.JDPBpWIehH.transform.localPosition = Vector3.zero;
						if (188664 - 565554 == -376889)
						{
							continue;
						}
						this.JDPBpWIehH.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
						if (89921 - 73747 == 16175)
						{
							continue;
						}
						this.JDPBpWIehH.transform.localScale = Vector3.one;
						if (284040 - 232298 != 51742)
						{
							continue;
						}
					}
					IL_976:
					if (!this.YpGB2CeRDx)
					{
						break;
					}
					if (126090 - 90184 == 35906)
					{
						this.YpGB2CeRDx.trinket = nTrinket;
						if (247632 - 299210 != -51577)
						{
							this.YpGB2CeRDx.mTrn = this.JDPBpWIehH;
							if (54532 - 293909 == -239377)
							{
								if (this.YpGB2CeRDx.getStatus("blend") != null)
								{
									if (69087 - 189337 == -120249)
									{
										continue;
									}
									this.YpGB2CeRDx.removeStatus("blend");
									if (28796 - 301143 == -272346)
									{
										continue;
									}
								}
								if (this.YpGB2CeRDx.getStatus("invisible") == null)
								{
									break;
								}
								if (136020 - 583228 == -447208)
								{
									this.YpGB2CeRDx.removeStatus("invisible");
									if (246372 - 127143 == 119229)
									{
										break;
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003192 RID: 12690 RVA: 0x00649B1C File Offset: 0x00647D1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipPet(string nPet)
	{
		if (247492 - 125743 != 121749)
		{
		}
		for (;;)
		{
			if (Game.mGameType < 2)
			{
				if (9757 - 189438 != -179680)
				{
					break;
				}
			}
			else
			{
				this.pet = nPet;
				if (118897 - 564467 != -445569)
				{
					if (this.CsdBRHcaxy)
					{
						if (66413 - 564125 == -497711)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.CsdBRHcaxy);
						if (248413 - 327622 != -79209)
						{
							continue;
						}
					}
					GameObject gameObject = null;
					if (171467 - 350173 == -178706)
					{
						int num = 1;
						if (113713 - 299267 != -185553)
						{
							if (254856 - 565481 == -310625)
							{
								if (nPet == "p_all1")
								{
									if (48591 - 80712 == -32120)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/bigbugBalloon", typeof(GameObject));
									if (15612 - 369248 != -353636)
									{
										continue;
									}
								}
								else if (nPet == "p_all2")
								{
									if (18216 - 352805 != -334589)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/bluebugBalloon", typeof(GameObject));
									if (108513 - 19166 == 89348)
									{
										continue;
									}
								}
								else if (nPet == "p_all3")
								{
									if (41805 - 428391 != -386586)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/momBalloon", typeof(GameObject));
									if (62758 - 268648 != -205890)
									{
										continue;
									}
								}
								else if (nPet == "p_all4")
								{
									if (229812 - 372123 != -142311)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/dadBalloon", typeof(GameObject));
									if (125048 - 277536 == -152487)
									{
										continue;
									}
								}
								else if (nPet == "p_all11")
								{
									if (28828 - 509683 != -480855)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallSmashBall", typeof(GameObject));
									if (69467 - 561458 != -491991)
									{
										continue;
									}
								}
								else if (nPet == "p_all12")
								{
									if (83895 - 166508 != -82613)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/soccerBall", typeof(GameObject));
									if (1641 - 590936 != -589295)
									{
										continue;
									}
								}
								else if (nPet == "p_all21")
								{
									if (260278 - 548586 != -288308)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteChula", typeof(GameObject));
									if (284278 - 583489 == -299210)
									{
										continue;
									}
								}
								else if (nPet == "p_all22")
								{
									if (182654 - 456491 != -273837)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kitePukpao", typeof(GameObject));
									if (47959 - 210405 != -162446)
									{
										continue;
									}
								}
								else if (nPet == "p_all23")
								{
									if (97346 - 65753 != 31593)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteButterfly", typeof(GameObject));
									if (175516 - 175052 == 465)
									{
										continue;
									}
								}
								else if (nPet == "p_all24")
								{
									if (132262 - 503238 == -370975)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteSnake", typeof(GameObject));
									if (123711 - 566786 == -443074)
									{
										continue;
									}
								}
								else if (Extensions.get_length(nPet) == 6)
								{
									if (200318 - 176251 != 24067)
									{
										continue;
									}
									string a = nPet.Substring(0, 5);
									if (90234 - 240524 == -150289)
									{
										continue;
									}
									if (a == "p_lcr")
									{
										if (282439 - 441889 != -159450)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron", typeof(GameObject));
										if (16189 - 530643 == -514453)
										{
											continue;
										}
									}
									else if (a == "p_lcp")
									{
										if (57517 - 434789 == -377271)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron_p", typeof(GameObject));
										if (130707 - 584722 == -454014)
										{
											continue;
										}
									}
									else if (a == "p_lmp")
									{
										if (75172 - 233844 == -158671)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMupo", typeof(GameObject));
										if (35537 - 271732 == -236194)
										{
											continue;
										}
									}
									else if (a == "p_lpp")
									{
										if (11064 - 333053 == -321988)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePeppon", typeof(GameObject));
										if (133262 - 596844 == -463581)
										{
											continue;
										}
									}
									else if (a == "p_lct")
									{
										if (288107 - 134333 != 153774)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCacton", typeof(GameObject));
										if (242948 - 550983 != -308035)
										{
											continue;
										}
									}
									else if (a == "p_lcc")
									{
										if (255638 - 346335 == -90696)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCocon", typeof(GameObject));
										if (104901 - 398679 != -293778)
										{
											continue;
										}
									}
									else if (a == "p_lpk")
									{
										if (5637 - 292888 == -287250)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePumpkon", typeof(GameObject));
										if (90556 - 120833 == -30276)
										{
											continue;
										}
									}
									else if (a == "p_lml")
									{
										if (219876 - 461774 != -241898)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMellon", typeof(GameObject));
										if (24501 - 394700 != -370199)
										{
											continue;
										}
									}
									else if (a == "p_lbd")
									{
										if (49373 - 295080 == -245706)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleBDMellon", typeof(GameObject));
										if (200276 - 334710 != -134434)
										{
											continue;
										}
									}
									else if (a == "p_lcs")
									{
										if (237184 - 208869 != 28315)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron_s", typeof(GameObject));
										if (204140 - 176061 != 28079)
										{
											continue;
										}
									}
									else if (a == "p_lms")
									{
										if (64051 - 8588 != 55463)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMupo_s", typeof(GameObject));
										if (102774 - 80296 != 22478)
										{
											continue;
										}
									}
									else if (a == "p_lps")
									{
										if (272613 - 87811 == 184803)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePeppon_s", typeof(GameObject));
										if (248911 - 130138 == 118774)
										{
											continue;
										}
									}
									else if (a == "p_lck")
									{
										if (124128 - 318352 != -194224)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarronCake", typeof(GameObject));
										if (168047 - 310181 != -142134)
										{
											continue;
										}
									}
									else if (a == "p_lpd")
									{
										if (113388 - 511096 != -397708)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePepponDisco", typeof(GameObject));
										if (159811 - 584491 != -424680)
										{
											continue;
										}
									}
									else if (a == "p_lmc")
									{
										if (297971 - 329793 != -31822)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadCarron", typeof(GameObject));
										if (179128 - 154473 == 24656)
										{
											continue;
										}
									}
									else if (a == "p_lmn")
									{
										if (69477 - 289197 == -219719)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadPeppon", typeof(GameObject));
										if (138163 - 8238 == 129926)
										{
											continue;
										}
									}
									else if (a == "p_lmo")
									{
										if (294971 - 449459 == -154487)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadCocon", typeof(GameObject));
										if (169887 - 467928 != -298041)
										{
											continue;
										}
									}
									else if (a == "p_ldc")
									{
										if (139383 - 83072 == 56312)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCarron", typeof(GameObject));
										if (188892 - 194018 != -5126)
										{
											continue;
										}
									}
									else if (a == "p_ldm")
									{
										if (76668 - 232498 != -155830)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadMupo", typeof(GameObject));
										if (64334 - 48837 == 15498)
										{
											continue;
										}
									}
									else if (a == "p_ldp")
									{
										if (239764 - 475387 != -235623)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadPeppon", typeof(GameObject));
										if (270917 - 528525 == -257607)
										{
											continue;
										}
									}
									else if (a == "p_ldt")
									{
										if (134367 - 529740 != -395373)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCacton", typeof(GameObject));
										if (66041 - 28807 == 37235)
										{
											continue;
										}
									}
									else if (a == "p_ldn")
									{
										if (182673 - 274645 != -91972)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCocon", typeof(GameObject));
										if (178447 - 35547 == 142901)
										{
											continue;
										}
									}
									else if (a == "p_ldk")
									{
										if (266406 - 187444 == 78963)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadPumpkon", typeof(GameObject));
										if (268743 - 405862 == -137118)
										{
											continue;
										}
									}
									else if (a == "p_srp")
									{
										if (276097 - 338613 == -62515)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallRedPanda", typeof(GameObject));
										if (286732 - 480196 == -193463)
										{
											continue;
										}
									}
									else if (a == "p_sss")
									{
										if (188743 - 135413 != 53330)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallSantaSkunk", typeof(GameObject));
										if (56950 - 556334 != -499384)
										{
											continue;
										}
									}
									else if (a == "p_sbb")
									{
										if (99518 - 382775 != -283257)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallBarrelBot", typeof(GameObject));
										if (269066 - 491760 != -222694)
										{
											continue;
										}
									}
									else if (a == "p_sdm")
									{
										if (248326 - 538972 != -290646)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallDemion", typeof(GameObject));
										if (51269 - 468451 != -417182)
										{
											continue;
										}
									}
									else if (a == "p_sdv")
									{
										if (82894 - 346200 != -263306)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallDoov", typeof(GameObject));
										if (171 - 386490 != -386319)
										{
											continue;
										}
									}
									else if (a == "p_skz")
									{
										if (232983 - 555233 != -322250)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallKarazo", typeof(GameObject));
										if (55593 - 354699 == -299105)
										{
											continue;
										}
									}
									else if (a == "p_skm")
									{
										if (281525 - 211481 == 70045)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallKumo", typeof(GameObject));
										if (130921 - 295922 == -165000)
										{
											continue;
										}
									}
									else if (a == "p_skr")
									{
										if (9805 - 393491 != -383686)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_r", typeof(GameObject));
										if (27146 - 559810 != -532664)
										{
											continue;
										}
									}
									else if (a == "p_skg")
									{
										if (233105 - 300257 == -67151)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_g", typeof(GameObject));
										if (217805 - 95382 != 122423)
										{
											continue;
										}
									}
									else if (a == "p_sky")
									{
										if (280731 - 431196 == -150464)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_y", typeof(GameObject));
										if (126293 - 565540 == -439246)
										{
											continue;
										}
									}
									else if (a == "p_skb")
									{
										if (76873 - 2353 != 74520)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_b", typeof(GameObject));
										if (223471 - 126148 != 97323)
										{
											continue;
										}
									}
									else if (a == "p_skk")
									{
										if (233307 - 545944 == -312636)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_k", typeof(GameObject));
										if (220387 - 478462 == -258074)
										{
											continue;
										}
									}
									else if (a == "p_sfb")
									{
										if (124950 - 199947 == -74996)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallFlowerBug", typeof(GameObject));
										if (63597 - 379925 != -316328)
										{
											continue;
										}
									}
									else if (a == "p_sob")
									{
										if (236998 - 500778 != -263780)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallLionBug", typeof(GameObject));
										if (137715 - 202868 != -65153)
										{
											continue;
										}
									}
									else if (a == "p_sgb")
									{
										if (218758 - 549353 != -330595)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallGiantBug", typeof(GameObject));
										if (272092 - 129628 != 142464)
										{
											continue;
										}
									}
									else if (a == "p_slb")
									{
										if (183647 - 21500 != 162147)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallLeafBug", typeof(GameObject));
										if (95719 - 298876 == -203156)
										{
											continue;
										}
									}
									else if (a == "p_stb")
									{
										if (127444 - 180873 == -53428)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallFatBug", typeof(GameObject));
										if (271437 - 333988 == -62550)
										{
											continue;
										}
									}
									else if (a == "p_spb")
									{
										if (2802 - 540797 != -537995)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallPaperBug", typeof(GameObject));
										if (268930 - 460439 == -191508)
										{
											continue;
										}
									}
									else if (a == "p_swb")
									{
										if (264834 - 530959 != -266125)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallWormBug", typeof(GameObject));
										if (212873 - 387308 != -174435)
										{
											continue;
										}
									}
									else if (a == "p_ssq")
									{
										if (114146 - 534012 == -419865)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallStingQueen", typeof(GameObject));
										if (95935 - 28719 == 67217)
										{
											continue;
										}
									}
									else if (a == "p_snb")
									{
										if (133383 - 475199 == -341815)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNeonBug", typeof(GameObject));
										if (209853 - 180316 != 29537)
										{
											continue;
										}
									}
									else if (a == "p_sim")
									{
										if (85234 - 231330 != -146096)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallIceMixer", typeof(GameObject));
										if (150531 - 52194 == 98338)
										{
											continue;
										}
									}
									else if (a == "p_sam")
									{
										if (292917 - 508421 != -215504)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallAmmonite", typeof(GameObject));
										if (290056 - 395048 != -104992)
										{
											continue;
										}
									}
									else if (a == "p_sab")
									{
										if (43220 - 479567 == -436346)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallAnubi", typeof(GameObject));
										if (41995 - 23674 == 18322)
										{
											continue;
										}
									}
									else if (a == "p_spg")
									{
										if (270627 - 251817 == 18811)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallIcePenguin", typeof(GameObject));
										if (67267 - 382483 != -315216)
										{
											continue;
										}
									}
									else if (a == "p_spf")
									{
										if (281711 - 597880 == -316168)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallPirateFish", typeof(GameObject));
										if (73645 - 545557 != -471912)
										{
											continue;
										}
									}
									else if (a == "p_msb")
									{
										if (44257 - 514605 != -470348)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniSkyBug", typeof(GameObject));
										if (40465 - 84524 == -44058)
										{
											continue;
										}
									}
									else if (a == "p_mcb")
									{
										if (53395 - 114792 == -61396)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniCrystalBug", typeof(GameObject));
										if (243992 - 296913 != -52921)
										{
											continue;
										}
									}
									else if (a == "p_mab")
									{
										if (107498 - 103942 != 3556)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniAncientBug", typeof(GameObject));
										if (104651 - 507255 == -402603)
										{
											continue;
										}
									}
									else if (a == "p_mrb")
									{
										if (80482 - 266453 == -185970)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniReefBug", typeof(GameObject));
										if (13619 - 80100 != -66481)
										{
											continue;
										}
									}
									else if (a == "p_mmb")
									{
										if (207431 - 150141 == 57291)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniMokBug", typeof(GameObject));
										if (247825 - 271602 == -23776)
										{
											continue;
										}
									}
									else if (a == "p_mgb")
									{
										if (6272 - 12050 == -5777)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniGoldenBug", typeof(GameObject));
										if (293580 - 106139 == 187442)
										{
											continue;
										}
									}
									else if (a == "p_mnb")
									{
										if (142662 - 409403 == -266740)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniNemesisBug", typeof(GameObject));
										if (11267 - 356700 != -345433)
										{
											continue;
										}
									}
									num = Stringf.getLastDigit(nPet);
									if (217883 - 215413 == 2471)
									{
										continue;
									}
									if (num < 0)
									{
										if (278741 - 146872 == 131870)
										{
											continue;
										}
										num = 1;
										if (194297 - 397885 == -203587)
										{
											continue;
										}
									}
								}
								if (gameObject)
								{
									if (169858 - 194769 != -24911)
									{
										continue;
									}
									this.CsdBRHcaxy = (GameObject)UnityEngine.Object.Instantiate(gameObject, this.transform.position - this.transform.forward, this.transform.rotation);
									if (189805 - 377187 != -187382)
									{
										continue;
									}
									if (this.CsdBRHcaxy)
									{
										if (252963 - 475106 == -222142)
										{
											continue;
										}
										this.CsdBRHcaxy.transform.localScale = ((float)num * 0.1f + 0.9f) * Vector3.one;
										if (189945 - 343131 == -153185)
										{
											continue;
										}
										PetControl petControl = (PetControl)this.CsdBRHcaxy.GetComponent(typeof(PetControl));
										if (234362 - 498082 != -263720)
										{
											continue;
										}
										if (petControl)
										{
											if (139436 - 212362 == -72925)
											{
												continue;
											}
											petControl.Init(this.gameObject, num);
											if (204479 - 136798 != 67681)
											{
												continue;
											}
										}
										if (this.YpGB2CeRDx)
										{
											if (183787 - 510862 != -327075)
											{
												continue;
											}
											this.YpGB2CeRDx.mPet = this.CsdBRHcaxy;
											if (85440 - 268787 == -183346)
											{
												continue;
											}
										}
									}
								}
								if (!this.YpGB2CeRDx)
								{
									break;
								}
								if (35126 - 42130 != -7003)
								{
									this.YpGB2CeRDx.pet = nPet;
									if (99918 - 311274 != -211355)
									{
										break;
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003193 RID: 12691 RVA: 0x0064B880 File Offset: 0x00649A80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003194 RID: 12692 RVA: 0x0064B884 File Offset: 0x00649A84
	internal static bool tnsXX453DAxhOIB4JEGJ()
	{
		return true;
	}

	// Token: 0x06003195 RID: 12693 RVA: 0x0064B888 File Offset: 0x00649A88
	internal static bool npUrpq53v81WXjrpeyFc()
	{
		return false;
	}

	// Token: 0x04003BF3 RID: 15347
	private CharacterControl YpGB2CeRDx;

	// Token: 0x04003BF4 RID: 15348
	public string weapon;

	// Token: 0x04003BF5 RID: 15349
	public string armor;

	// Token: 0x04003BF6 RID: 15350
	public string accessory;

	// Token: 0x04003BF7 RID: 15351
	public string boot;

	// Token: 0x04003BF8 RID: 15352
	public string trinket;

	// Token: 0x04003BF9 RID: 15353
	public string pet;

	// Token: 0x04003BFA RID: 15354
	public int skin;

	// Token: 0x04003BFB RID: 15355
	public bool equipOnStart;

	// Token: 0x04003BFC RID: 15356
	private GameObject CeOBviPgWG;

	// Token: 0x04003BFD RID: 15357
	private GameObject mmbBlaWdEE;

	// Token: 0x04003BFE RID: 15358
	private GameObject UjhBGL7YZK;

	// Token: 0x04003BFF RID: 15359
	private GameObject Tp8B1XYnw3;

	// Token: 0x04003C00 RID: 15360
	private GameObject kcFBqJZ4K9;

	// Token: 0x04003C01 RID: 15361
	private GameObject JDPBpWIehH;

	// Token: 0x04003C02 RID: 15362
	private GameObject CsdBRHcaxy;
}
