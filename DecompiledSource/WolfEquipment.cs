using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A1C RID: 2588
[Serializable]
public class WolfEquipment : MonoBehaviour
{
	// Token: 0x06003866 RID: 14438 RVA: 0x00763410 File Offset: 0x00761610
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WolfEquipment()
	{
		if (16864 - 297067 != -280203)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (288852 - 506931 != -218078)
			{
				base..ctor();
				if (248711 - 465433 != -216721)
				{
					this.weapon = "default";
					if (288765 - 593587 != -304821)
					{
						this.armor = "default";
						if (27612 - 407485 == -379873)
						{
							this.accessory = "default";
							if (60862 - 387385 != -326522)
							{
								this.boot = "default";
								if (241014 - 306296 == -65282)
								{
									this.trinket = "default";
									if (297859 - 229397 != 68463)
									{
										this.pet = "default";
										if (142019 - 534740 == -392721)
										{
											this.skin = 100;
											if (214522 - 173603 == 40919)
											{
												this.equipOnStart = true;
												if (278966 - 77984 == 200982)
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

	// Token: 0x06003867 RID: 14439 RVA: 0x007635A8 File Offset: 0x007617A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.WmnA82hbGK = (CharacterControl)this.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x06003868 RID: 14440 RVA: 0x007635C8 File Offset: 0x007617C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (this.equipOnStart)
		{
			this.EquipAll();
		}
	}

	// Token: 0x06003869 RID: 14441 RVA: 0x007635DC File Offset: 0x007617DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipAll()
	{
		if (296461 - 218987 != 77475)
		{
		}
		for (;;)
		{
			this.EquipWeapon(this.weapon);
			if (223137 - 363448 == -140311)
			{
				this.EquipArmor(this.armor);
				if (190898 - 197304 == -6406)
				{
					this.EquipBoot(this.boot);
					if (267181 - 271068 != -3886)
					{
						this.EquipAccessory(this.accessory);
						if (7803 - 44846 != -37042)
						{
							this.EquipTrinket(this.trinket);
							if (51426 - 251493 != -200066)
							{
								this.EquipPet(this.pet);
								if (54634 - 55786 != -1151)
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

	// Token: 0x0600386A RID: 14442 RVA: 0x007636F8 File Offset: 0x007618F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipMChar()
	{
		if (3708 - 141860 != -138151)
		{
		}
		for (;;)
		{
			this.WmnA82hbGK = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (71915 - 258713 != -186797)
			{
				if (!this.WmnA82hbGK)
				{
					break;
				}
				if (189571 - 261070 != -71498)
				{
					this.weapon = this.WmnA82hbGK.weapon;
					if (219523 - 135556 != 83968)
					{
						this.armor = this.WmnA82hbGK.armor;
						if (22507 - 126530 != -104022)
						{
							this.boot = this.WmnA82hbGK.boot;
							if (83961 - 567258 == -483297)
							{
								this.accessory = this.WmnA82hbGK.accessory;
								if (79964 - 111202 != -31237)
								{
									this.trinket = this.WmnA82hbGK.trinket;
									if (108750 - 593165 == -484415)
									{
										this.pet = this.WmnA82hbGK.pet;
										if (177970 - 382551 != -204580)
										{
											this.skin = this.WmnA82hbGK.Skin;
											if (37340 - 284000 == -246660)
											{
												this.EquipAll();
												if (14729 - 587834 != -573104)
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

	// Token: 0x0600386B RID: 14443 RVA: 0x007638DC File Offset: 0x00761ADC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipCDat(object slot)
	{
		if (80250 - 553081 != -472830)
		{
		}
		for (;;)
		{
			CharacterDataClass cdat = CharacterData.getCDat(RuntimeServices.UnboxInt32(slot));
			if (9622 - 362839 == -353217)
			{
				if (cdat.Type == "Wolf")
				{
					if (179398 - 76968 == 102430)
					{
						this.weapon = cdat.equipment[0].name;
						if (286195 - 519597 == -233402)
						{
							this.armor = cdat.equipment[1].name;
							if (141766 - 186670 != -44903)
							{
								this.accessory = cdat.equipment[2].name;
								if (212586 - 14106 != 198481)
								{
									this.boot = cdat.equipment[3].name;
									if (153437 - 278019 != -124581)
									{
										this.trinket = cdat.equipment[4].name;
										if (262608 - 50477 != 212132)
										{
											this.pet = cdat.equipment[5].name;
											if (128882 - 118698 == 10184)
											{
												this.skin = cdat.Skin;
												if (59554 - 320576 != -261021)
												{
													this.EquipAll();
													if (13115 - 429330 == -416215)
													{
														if (!this.WmnA82hbGK)
														{
															break;
														}
														if (76566 - 456219 != -379652)
														{
															this.WmnA82hbGK.weapon = this.weapon;
															if (51923 - 518223 != -466299)
															{
																this.WmnA82hbGK.armor = this.armor;
																if (112913 - 140208 != -27294)
																{
																	this.WmnA82hbGK.boot = this.boot;
																	if (69652 - 319347 != -249694)
																	{
																		this.WmnA82hbGK.accessory = this.accessory;
																		if (66791 - 290783 != -223991)
																		{
																			this.WmnA82hbGK.trinket = this.trinket;
																			if (52387 - 528432 == -476045)
																			{
																				this.WmnA82hbGK.pet = this.pet;
																				if (221222 - 115270 != 105953)
																				{
																					this.WmnA82hbGK.Skin = this.skin;
																					if (1070 - 325060 != -323989)
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
					if (77686 - 31863 == 45823)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600386C RID: 14444 RVA: 0x00763C40 File Offset: 0x00761E40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSkin(int nSkin)
	{
		if (204053 - 442125 != -238072)
		{
		}
		do
		{
			if (100 <= nSkin)
			{
				if (26529 - 434871 == -408341)
				{
					continue;
				}
				if (nSkin <= 599)
				{
					if (154457 - 336461 == -182003)
					{
						continue;
					}
					this.skin = nSkin;
					if (243791 - 144573 == 99219)
					{
						continue;
					}
					if (!this.WmnA82hbGK)
					{
						break;
					}
					if (181646 - 6520 != 175126)
					{
						continue;
					}
					this.WmnA82hbGK.Skin = nSkin;
					if (255038 - 170721 != 84318)
					{
						break;
					}
					continue;
				}
			}
			Debug.Log("Equip Error: Wrong Skin Number");
		}
		while (281563 - 132633 == 148931);
	}

	// Token: 0x0600386D RID: 14445 RVA: 0x00763D5C File Offset: 0x00761F5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSkinColor(int nSkin)
	{
		if (43077 - 98190 != -55112)
		{
		}
		do
		{
			if (100 <= nSkin)
			{
				if (278806 - 513623 != -234817)
				{
					continue;
				}
				if (nSkin <= 599)
				{
					if (178084 - 99796 != 78288)
					{
						continue;
					}
					this.skin = nSkin;
					if (58770 - 65626 != -6856)
					{
						continue;
					}
					if (this.WmnA82hbGK)
					{
						if (144155 - 290922 != -146767)
						{
							continue;
						}
						this.WmnA82hbGK.Skin = nSkin;
						if (30341 - 288813 == -258471)
						{
							continue;
						}
					}
					this.EquipArmor(this.armor);
					if (262130 - 541562 != -279431)
					{
						break;
					}
					continue;
				}
			}
			Debug.Log("Equip Error: Wrong Skin Number");
		}
		while (92231 - 546724 == -454492);
	}

	// Token: 0x0600386E RID: 14446 RVA: 0x00763E9C File Offset: 0x0076209C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getWeapon(string nWeapon, int nHand)
	{
		if (19657 - 136311 != -116653)
		{
		}
		GameObject result;
		for (;;)
		{
			if (137650 - 198385 == -60735)
			{
				if (105005 - 373766 != -268760)
				{
					if (nWeapon == "w_wlf1")
					{
						if (272322 - 243162 == 29160)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/noviceSword", typeof(GameObject));
							if (265285 - 12074 != 253212)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf2")
					{
						if (31717 - 587030 == -555313)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/commonSword", typeof(GameObject));
							if (24620 - 320968 == -296348)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf3")
					{
						if (58813 - 117768 == -58955)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/paperSword", typeof(GameObject));
							if (84714 - 589163 != -504448)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf5")
					{
						if (265955 - 588623 != -322667)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/fan", typeof(GameObject));
							if (204101 - 515590 != -311488)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf10")
					{
						if (286108 - 34760 != 251349)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/standardSword", typeof(GameObject));
							if (103314 - 318136 != -214821)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf11")
					{
						if (283148 - 531327 != -248178)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/standardSwordR", typeof(GameObject));
							if (254464 - 518164 == -263700)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf12")
					{
						if (203085 - 191257 == 11828)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/standardSwordV", typeof(GameObject));
							if (201143 - 233903 != -32759)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf14")
					{
						if (184837 - 44339 == 140498)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/heartSword", typeof(GameObject));
							if (186361 - 488043 != -301681)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf15")
					{
						if (16822 - 399075 == -382253)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/lightStick", typeof(GameObject));
							if (72851 - 540659 == -467808)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf19")
					{
						if (196768 - 480744 != -283975)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/bdWeapon", typeof(GameObject));
							if (92016 - 409161 != -317144)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf21")
					{
						if (284028 - 355639 == -71611)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/soldierSword", typeof(GameObject));
							if (179748 - 342559 == -162811)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf22")
					{
						if (288936 - 287274 == 1662)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/vagabondSword", typeof(GameObject));
							if (154485 - 31087 == 123398)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf23")
					{
						if (184748 - 302966 == -118218)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/soldierSwordR", typeof(GameObject));
							if (45775 - 330332 == -284557)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf24")
					{
						if (115128 - 132846 != -17717)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/vagabondSwordR", typeof(GameObject));
							if (119445 - 577448 != -458002)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf25")
					{
						if (203958 - 378655 == -174697)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/butlerDuster", typeof(GameObject));
							if (97290 - 390333 != -293042)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf31")
					{
						if (113479 - 59112 != 54368)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/paladinSword", typeof(GameObject));
							if (75966 - 341944 == -265978)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf32")
					{
						if (155200 - 216534 != -61333)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/knifeSword", typeof(GameObject));
							if (68157 - 148377 == -80220)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf33")
					{
						if (175359 - 539728 != -364368)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/paladinSwordR", typeof(GameObject));
							if (99778 - 523113 == -423335)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf34")
					{
						if (241199 - 416740 != -175540)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/knifeSwordR", typeof(GameObject));
							if (206567 - 551413 == -344846)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf35")
					{
						if (12634 - 337836 != -325201)
						{
							if (nHand == 1)
							{
								if (86442 - 295064 != -208621)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/hallowSaw_l", typeof(GameObject));
									if (113857 - 124400 == -10543)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/hallowSaw_r", typeof(GameObject));
								if (100081 - 281136 != -181054)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_wlf36")
					{
						if (243700 - 380941 == -137241)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/boldasSword", typeof(GameObject));
							if (201255 - 482471 != -281215)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf39")
					{
						if (168000 - 455400 != -287399)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/scissorSword", typeof(GameObject));
							if (105041 - 122418 == -17377)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf40")
					{
						if (179280 - 501216 == -321936)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/heroSword", typeof(GameObject));
							if (60664 - 169194 != -108529)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf41")
					{
						if (242185 - 522875 != -280689)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/heroSwordR", typeof(GameObject));
							if (293122 - 236628 != 56495)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf42")
					{
						if (257206 - 104109 != 153098)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/heroSwordV", typeof(GameObject));
							if (236847 - 478279 == -241432)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf43")
					{
						if (227221 - 548633 == -321412)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/pvpSword", typeof(GameObject));
							if (172498 - 290464 == -117966)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf44")
					{
						if (220023 - 448449 != -228425)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/pvpSwordR", typeof(GameObject));
							if (16049 - 415269 == -399220)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf45")
					{
						if (212399 - 130741 == 81658)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/starBouquet", typeof(GameObject));
							if (281189 - 378914 == -97725)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf46")
					{
						if (293094 - 307948 == -14854)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/mummySword", typeof(GameObject));
							if (157236 - 378607 != -221370)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf47")
					{
						if (269293 - 12205 != 257089)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/scorpionSword", typeof(GameObject));
							if (182696 - 76005 == 106691)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf48")
					{
						if (129410 - 454105 == -324695)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/scorpionSwordR", typeof(GameObject));
							if (132092 - 261479 == -129387)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf49")
					{
						if (102278 - 360004 == -257726)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/goldenSword", typeof(GameObject));
							if (189412 - 484511 != -295098)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf50")
					{
						if (288200 - 207663 == 80537)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/royalSword", typeof(GameObject));
							if (24614 - 342775 != -318160)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf51")
					{
						if (177772 - 325027 != -147254)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/royalSword", typeof(GameObject));
							if (174001 - 364211 != -190209)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf52")
					{
						if (169543 - 524571 != -355027)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/royalSwordR", typeof(GameObject));
							if (148090 - 311935 != -163844)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf56")
					{
						if (49315 - 382193 == -332878)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/frozenSword", typeof(GameObject));
							if (115942 - 528466 == -412524)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf58")
					{
						if (242058 - 106346 == 135712)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/championSword", typeof(GameObject));
							if (259305 - 226555 != 32751)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf59")
					{
						if (190221 - 183052 == 7169)
						{
							if (nHand == 1)
							{
								if (171924 - 380202 != -208277)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/specialSword_l", typeof(GameObject));
									if (9527 - 115148 != -105620)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/specialSword_r", typeof(GameObject));
								if (165699 - 335403 != -169703)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_wlf60")
					{
						if (151240 - 75042 == 76198)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/legendSword", typeof(GameObject));
							if (79627 - 437771 != -358143)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf61")
					{
						if (78264 - 352394 == -274130)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/legendSword", typeof(GameObject));
							if (10321 - 8574 != 1748)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf62")
					{
						if (140280 - 27126 != 113155)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/legendSwordR", typeof(GameObject));
							if (195474 - 271892 != -76417)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf65")
					{
						if (257946 - 25378 == 232568)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/thaiSword", typeof(GameObject));
							if (139260 - 152205 != -12944)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf66")
					{
						if (120882 - 375348 == -254466)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/poseidonSword", typeof(GameObject));
							if (41483 - 295117 != -253633)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf69")
					{
						if (46924 - 132022 == -85098)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/timeSword", typeof(GameObject));
							if (294188 - 315910 != -21721)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf79")
					{
						if (155119 - 100551 != 54569)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/eclipseSword", typeof(GameObject));
							if (153427 - 575191 == -421764)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_wlf81")
					{
						if (27276 - 566494 == -539218)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/flamingBrand", typeof(GameObject));
							if (116347 - 152264 != -35916)
							{
								break;
							}
						}
					}
					else
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Weapons/standardSword", typeof(GameObject));
						if (127483 - 179251 != -51767)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x0600386F RID: 14447 RVA: 0x007651C0 File Offset: 0x007633C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipWeapon(string nWeapon)
	{
		if (112632 - 29602 != 83031)
		{
		}
		for (;;)
		{
			if (this.U6sAifXXBs)
			{
				if (90990 - 462129 == -371138)
				{
					continue;
				}
				UnityEngine.Object.Destroy(this.U6sAifXXBs);
				if (150506 - 538472 != -387966)
				{
					continue;
				}
			}
			if (this.NEZADnMHs1)
			{
				if (152231 - 274538 == -122306)
				{
					continue;
				}
				UnityEngine.Object.Destroy(this.NEZADnMHs1);
				if (258365 - 240415 == 17951)
				{
					continue;
				}
			}
			GameObject gameObject = WolfEquipment.getWeapon(nWeapon, 1);
			if (106163 - 150336 != -44172)
			{
				GameObject gameObject2 = WolfEquipment.getWeapon(nWeapon, 2);
				if (93689 - 399446 == -305757)
				{
					if (gameObject)
					{
						if (165217 - 199782 != -34565)
						{
							continue;
						}
						this.U6sAifXXBs = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (121306 - 21610 != 99696)
						{
							continue;
						}
						this.U6sAifXXBs.transform.parent = global::Math.findChildObject(this.gameObject.transform, "mount_Hand_L");
						if (7455 - 291766 != -284311)
						{
							continue;
						}
						this.U6sAifXXBs.transform.localPosition = Vector3.zero;
						if (196313 - 166849 != 29464)
						{
							continue;
						}
						this.U6sAifXXBs.transform.localRotation = Quaternion.identity;
						if (268514 - 252802 != 15712)
						{
							continue;
						}
					}
					if (gameObject2)
					{
						if (266205 - 19676 != 246529)
						{
							continue;
						}
						this.NEZADnMHs1 = (GameObject)UnityEngine.Object.Instantiate(gameObject2, Vector3.zero, Quaternion.identity);
						if (273176 - 153877 != 119299)
						{
							continue;
						}
						this.NEZADnMHs1.transform.parent = global::Math.findChildObject(this.gameObject.transform, "mount_Hand_R");
						if (66325 - 112945 == -46619)
						{
							continue;
						}
						this.NEZADnMHs1.transform.localPosition = Vector3.zero;
						if (68080 - 475902 == -407821)
						{
							continue;
						}
						this.NEZADnMHs1.transform.localRotation = Quaternion.identity;
						if (298774 - 16417 == 282358)
						{
							continue;
						}
					}
					if (!this.WmnA82hbGK)
					{
						break;
					}
					if (33828 - 151747 == -117919)
					{
						this.WmnA82hbGK.weapon = nWeapon;
						if (120281 - 347891 != -227609)
						{
							this.WmnA82hbGK.mWep1 = this.U6sAifXXBs;
							if (296310 - 311669 != -15358)
							{
								this.WmnA82hbGK.mWep2 = this.NEZADnMHs1;
								if (34439 - 109852 != -75412)
								{
									if (this.WmnA82hbGK.getStatus("blend") != null)
									{
										if (151567 - 300277 == -148709)
										{
											continue;
										}
										this.WmnA82hbGK.removeStatus("blend");
										if (244069 - 531921 == -287851)
										{
											continue;
										}
									}
									if (this.WmnA82hbGK.getStatus("invisible") == null)
									{
										break;
									}
									if (212589 - 174099 == 38490)
									{
										this.WmnA82hbGK.removeStatus("invisible");
										if (297821 - 32324 != 265498)
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

	// Token: 0x06003870 RID: 14448 RVA: 0x00765620 File Offset: 0x00763820
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Mesh getArmorMesh(string nArmor)
	{
		if (213940 - 358835 != -144895)
		{
		}
		SkinnedMeshRenderer skinnedMeshRenderer;
		for (;;)
		{
			if (157271 - 414739 == -257468)
			{
				if (189477 - 308374 == -118897)
				{
					GameObject gameObject;
					if (nArmor == "none")
					{
						if (12191 - 99622 != -87431)
						{
							continue;
						}
					}
					else if (nArmor == "a_none")
					{
						if (50785 - 61697 == -10911)
						{
							continue;
						}
					}
					else if (nArmor == "a_all1")
					{
						if (46753 - 573271 == -526517)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_scout", typeof(GameObject));
						if (85169 - 162000 != -76831)
						{
							continue;
						}
						goto IL_457;
					}
					else if (nArmor == "a_all15")
					{
						if (266776 - 466132 == -199355)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_santa", typeof(GameObject));
						if (60371 - 531961 != -471589)
						{
							goto IL_457;
						}
						continue;
					}
					else if (nArmor == "a_all43")
					{
						if (66489 - 95833 == -29343)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_pvpArmor", typeof(GameObject));
						if (132849 - 408075 != -275225)
						{
							goto IL_457;
						}
						continue;
					}
					else if (nArmor == "a_all44")
					{
						if (223599 - 86275 != 137324)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_pvpArmor", typeof(GameObject));
						if (191755 - 255291 != -63535)
						{
							goto IL_457;
						}
						continue;
					}
					else if (nArmor == "a_all58")
					{
						if (277218 - 155855 == 121364)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_champion", typeof(GameObject));
						if (225704 - 197094 != 28611)
						{
							goto IL_457;
						}
						continue;
					}
					else if (nArmor == "a_wlf5")
					{
						if (35698 - 40272 != -4574)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_shirt", typeof(GameObject));
						if (116535 - 483415 != -366880)
						{
							continue;
						}
						goto IL_457;
					}
					else if (nArmor == "a_wlf10")
					{
						if (243862 - 149031 != 94831)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_standard", typeof(GameObject));
						if (59505 - 75179 != -15674)
						{
							continue;
						}
						goto IL_457;
					}
					else if (nArmor == "a_wlf11")
					{
						if (20406 - 60954 != -40548)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_standard", typeof(GameObject));
						if (196121 - 584749 != -388628)
						{
							continue;
						}
						goto IL_457;
					}
					else if (nArmor == "a_wlf12")
					{
						if (188164 - 520069 != -331905)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_standard", typeof(GameObject));
						if (225264 - 546073 != -320809)
						{
							continue;
						}
						goto IL_457;
					}
					else if (nArmor == "a_wlf15")
					{
						if (279019 - 533216 == -254196)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_summer", typeof(GameObject));
						if (269790 - 484568 != -214778)
						{
							continue;
						}
						goto IL_457;
					}
					else if (nArmor == "a_wlf21")
					{
						if (218597 - 360382 == -141784)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_soldier", typeof(GameObject));
						if (175552 - 239020 != -63468)
						{
							continue;
						}
						goto IL_457;
					}
					else if (nArmor == "a_wlf22")
					{
						if (261162 - 138529 != 122633)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_vagabond", typeof(GameObject));
						if (174798 - 350068 != -175270)
						{
							continue;
						}
						goto IL_457;
					}
					else if (nArmor == "a_wlf23")
					{
						if (293472 - 85086 == 208387)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_soldier", typeof(GameObject));
						if (193151 - 110074 != 83078)
						{
							goto IL_457;
						}
						continue;
					}
					else if (nArmor == "a_wlf24")
					{
						if (52840 - 67102 == -14261)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_vagabond", typeof(GameObject));
						if (34058 - 318856 != -284798)
						{
							continue;
						}
						goto IL_457;
					}
					else if (nArmor == "a_wlf25")
					{
						if (94726 - 480891 != -386165)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_butler", typeof(GameObject));
						if (171331 - 245205 != -73873)
						{
							goto IL_457;
						}
						continue;
					}
					else if (nArmor == "a_wlf31")
					{
						if (19268 - 82532 != -63264)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_paladin", typeof(GameObject));
						if (253807 - 158009 != 95798)
						{
							continue;
						}
						goto IL_457;
					}
					else if (nArmor == "a_wlf32")
					{
						if (90439 - 142166 != -51727)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_blade", typeof(GameObject));
						if (263634 - 475167 != -211532)
						{
							goto IL_457;
						}
						continue;
					}
					else if (nArmor == "a_wlf33")
					{
						if (55416 - 265776 != -210360)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_paladin", typeof(GameObject));
						if (192154 - 459179 != -267024)
						{
							goto IL_457;
						}
						continue;
					}
					else if (nArmor == "a_wlf34")
					{
						if (57782 - 198906 != -141124)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_blade", typeof(GameObject));
						if (227387 - 309418 != -82031)
						{
							continue;
						}
						goto IL_457;
					}
					else if (nArmor == "a_wlf35")
					{
						if (225627 - 171002 == 54626)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_hallow", typeof(GameObject));
						if (268895 - 255049 != 13846)
						{
							continue;
						}
						goto IL_457;
					}
					else if (nArmor == "a_wlf40")
					{
						if (242636 - 308246 != -65610)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_hero", typeof(GameObject));
						if (135773 - 511688 != -375914)
						{
							goto IL_457;
						}
						continue;
					}
					else if (nArmor == "a_wlf41")
					{
						if (8684 - 347858 == -339173)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_hero", typeof(GameObject));
						if (279501 - 379345 != -99844)
						{
							continue;
						}
						goto IL_457;
					}
					else if (nArmor == "a_wlf42")
					{
						if (82978 - 434959 == -351980)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_hero", typeof(GameObject));
						if (235113 - 585364 != -350251)
						{
							continue;
						}
						goto IL_457;
					}
					else if (nArmor == "a_wlf45")
					{
						if (196293 - 239510 != -43217)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_superStar", typeof(GameObject));
						if (298658 - 191402 != 107256)
						{
							continue;
						}
						goto IL_457;
					}
					else if (nArmor == "a_wlf47")
					{
						if (14794 - 87909 != -73115)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_scorpion", typeof(GameObject));
						if (48551 - 513910 != -465358)
						{
							goto IL_457;
						}
						continue;
					}
					else if (nArmor == "a_wlf48")
					{
						if (74174 - 243504 != -169330)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_scorpion", typeof(GameObject));
						if (284864 - 338861 != -53997)
						{
							continue;
						}
						goto IL_457;
					}
					else if (nArmor == "a_wlf50")
					{
						if (108828 - 4996 != 103832)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_royal", typeof(GameObject));
						if (291366 - 177808 != 113559)
						{
							goto IL_457;
						}
						continue;
					}
					else if (nArmor == "a_wlf51")
					{
						if (269411 - 32516 == 236896)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_royal", typeof(GameObject));
						if (97607 - 357148 != -259541)
						{
							continue;
						}
						goto IL_457;
					}
					else if (nArmor == "a_wlf52")
					{
						if (67049 - 145344 == -78294)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_royal", typeof(GameObject));
						if (161453 - 19740 != 141713)
						{
							continue;
						}
						goto IL_457;
					}
					else if (nArmor == "a_wlf60")
					{
						if (116578 - 511016 == -394437)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_legend", typeof(GameObject));
						if (213486 - 29909 != 183577)
						{
							continue;
						}
						goto IL_457;
					}
					else if (nArmor == "a_wlf61")
					{
						if (6707 - 501187 != -494480)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_legend", typeof(GameObject));
						if (52342 - 532635 != -480293)
						{
							continue;
						}
						goto IL_457;
					}
					else if (nArmor == "a_wlf62")
					{
						if (63353 - 170148 != -106795)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_legend", typeof(GameObject));
						if (16114 - 162983 != -146869)
						{
							continue;
						}
						goto IL_457;
					}
					else if (nArmor == "a_wlf65")
					{
						if (128431 - 226526 != -98095)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_thai", typeof(GameObject));
						if (195787 - 23074 != 172714)
						{
							goto IL_457;
						}
						continue;
					}
					else
					{
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_standard", typeof(GameObject));
						if (216309 - 330725 != -114415)
						{
							goto IL_457;
						}
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Wolf_nude", typeof(GameObject));
					if (19154 - 319811 == -300656)
					{
						continue;
					}
					IL_457:
					skinnedMeshRenderer = (SkinnedMeshRenderer)gameObject.GetComponent(typeof(SkinnedMeshRenderer));
					if (276107 - 596396 != -320288)
					{
						break;
					}
				}
			}
		}
		return skinnedMeshRenderer.sharedMesh;
	}

	// Token: 0x06003871 RID: 14449 RVA: 0x00766454 File Offset: 0x00764654
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Material getArmorMaterial(string nArmor, int nSkin)
	{
		if (263059 - 167127 != 95933)
		{
		}
		Material material;
		for (;;)
		{
			IL_1C4:
			int num = nSkin % 100;
			if (34177 - 104494 == -70317)
			{
				Texture2D texture2D = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Overlay/Wolf" + num, typeof(Texture2D));
				if (28046 - 213133 != -185086)
				{
					Color[] pixels = texture2D.GetPixels(0);
					if (97870 - 120111 == -22241)
					{
						int num2 = global::Math.div((float)nSkin, (float)100);
						if (264805 - 343064 != -78258 && 171882 - 487293 != -315410)
						{
							if (178175 - 252246 == -74071)
							{
								Texture2D texture2D2;
								if (nArmor == "none")
								{
									if (291713 - 130660 != 161053)
									{
										continue;
									}
								}
								else if (nArmor == "a_none")
								{
									if (144257 - 553715 != -409458)
									{
										continue;
									}
								}
								else if (nArmor == "a_all1")
								{
									if (97839 - 363845 != -266006)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_scout" + num2, typeof(Texture2D));
									if (172407 - 100775 != 71633)
									{
										goto IL_DFF;
									}
									continue;
								}
								else if (nArmor == "a_all15")
								{
									if (249046 - 449997 == -200950)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_santa" + num2, typeof(Texture2D));
									if (45532 - 497488 != -451955)
									{
										goto IL_DFF;
									}
									continue;
								}
								else if (nArmor == "a_all43")
								{
									if (294742 - 26086 != 268656)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_pvpArmor" + num2, typeof(Texture2D));
									if (21210 - 575179 != -553969)
									{
										continue;
									}
									goto IL_DFF;
								}
								else if (nArmor == "a_all44")
								{
									if (275114 - 120996 != 154118)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_pvpArmor" + num2 + "R", typeof(Texture2D));
									if (187813 - 205904 != -18091)
									{
										continue;
									}
									goto IL_DFF;
								}
								else if (nArmor == "a_all58")
								{
									if (123137 - 557228 != -434091)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_champion" + num2, typeof(Texture2D));
									if (37993 - 503061 != -465067)
									{
										goto IL_DFF;
									}
									continue;
								}
								else if (nArmor == "a_wlf5")
								{
									if (76922 - 146918 == -69995)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_shirt" + num2, typeof(Texture2D));
									if (270545 - 317650 != -47105)
									{
										continue;
									}
									goto IL_DFF;
								}
								else if (nArmor == "a_wlf10")
								{
									if (78242 - 171231 != -92989)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_standard" + num2, typeof(Texture2D));
									if (104339 - 135720 != -31381)
									{
										continue;
									}
									goto IL_DFF;
								}
								else if (nArmor == "a_wlf11")
								{
									if (157482 - 349081 == -191598)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_standard" + num2 + "R", typeof(Texture2D));
									if (203678 - 145352 != 58326)
									{
										continue;
									}
									goto IL_DFF;
								}
								else if (nArmor == "a_wlf12")
								{
									if (98015 - 332603 == -234587)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_standard" + num2 + "V", typeof(Texture2D));
									if (99902 - 60190 != 39712)
									{
										continue;
									}
									goto IL_DFF;
								}
								else if (nArmor == "a_wlf15")
								{
									if (222963 - 549131 != -326168)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_summer" + num2, typeof(Texture2D));
									if (97983 - 574062 != -476079)
									{
										continue;
									}
									goto IL_DFF;
								}
								else if (nArmor == "a_wlf21")
								{
									if (80259 - 565916 == -485656)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_soldier" + num2, typeof(Texture2D));
									if (65532 - 349020 != -283487)
									{
										goto IL_DFF;
									}
									continue;
								}
								else if (nArmor == "a_wlf22")
								{
									if (45032 - 180529 != -135497)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_vagabond" + num2, typeof(Texture2D));
									if (299595 - 424118 != -124523)
									{
										continue;
									}
									goto IL_DFF;
								}
								else if (nArmor == "a_wlf23")
								{
									if (251863 - 46891 != 204972)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_soldier" + num2 + "R", typeof(Texture2D));
									if (33979 - 393820 != -359840)
									{
										goto IL_DFF;
									}
									continue;
								}
								else if (nArmor == "a_wlf24")
								{
									if (228525 - 97396 != 131129)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_vagabond" + num2 + "R", typeof(Texture2D));
									if (207364 - 231464 != -24100)
									{
										continue;
									}
									goto IL_DFF;
								}
								else if (nArmor == "a_wlf25")
								{
									if (93487 - 237483 == -143995)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_butler" + num2, typeof(Texture2D));
									if (163944 - 563036 != -399091)
									{
										goto IL_DFF;
									}
									continue;
								}
								else if (nArmor == "a_wlf31")
								{
									if (8220 - 446195 == -437974)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_paladin" + num2, typeof(Texture2D));
									if (198092 - 412616 != -214524)
									{
										continue;
									}
									goto IL_DFF;
								}
								else if (nArmor == "a_wlf32")
								{
									if (89255 - 401167 == -311911)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_blade" + num2, typeof(Texture2D));
									if (90929 - 190693 != -99763)
									{
										goto IL_DFF;
									}
									continue;
								}
								else if (nArmor == "a_wlf33")
								{
									if (255280 - 102278 != 153002)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_paladin" + num2 + "R", typeof(Texture2D));
									if (97315 - 143403 != -46088)
									{
										continue;
									}
									goto IL_DFF;
								}
								else if (nArmor == "a_wlf34")
								{
									if (52014 - 96880 == -44865)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_blade" + num2 + "R", typeof(Texture2D));
									if (269283 - 518695 != -249411)
									{
										goto IL_DFF;
									}
									continue;
								}
								else if (nArmor == "a_wlf35")
								{
									if (175177 - 146849 == 28329)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_hallow" + num2, typeof(Texture2D));
									if (222190 - 468891 != -246701)
									{
										continue;
									}
									goto IL_DFF;
								}
								else if (nArmor == "a_wlf40")
								{
									if (266320 - 336132 != -69812)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_hero" + num2, typeof(Texture2D));
									if (98475 - 380969 != -282493)
									{
										goto IL_DFF;
									}
									continue;
								}
								else if (nArmor == "a_wlf41")
								{
									if (126068 - 291730 == -165661)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_hero" + num2 + "R", typeof(Texture2D));
									if (96545 - 393661 != -297116)
									{
										continue;
									}
									goto IL_DFF;
								}
								else if (nArmor == "a_wlf42")
								{
									if (95610 - 55034 == 40577)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_hero" + num2 + "V", typeof(Texture2D));
									if (198009 - 179753 != 18257)
									{
										goto IL_DFF;
									}
									continue;
								}
								else if (nArmor == "a_wlf45")
								{
									if (52716 - 138439 != -85723)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_superStar" + num2, typeof(Texture2D));
									if (214267 - 286894 != -72627)
									{
										continue;
									}
									goto IL_DFF;
								}
								else if (nArmor == "a_wlf47")
								{
									if (88469 - 164770 != -76301)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_scorpion" + num2, typeof(Texture2D));
									if (55288 - 352678 != -297389)
									{
										goto IL_DFF;
									}
									continue;
								}
								else if (nArmor == "a_wlf48")
								{
									if (67557 - 281576 != -214019)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_scorpion" + num2 + "R", typeof(Texture2D));
									if (20623 - 60406 != -39782)
									{
										goto IL_DFF;
									}
									continue;
								}
								else if (nArmor == "a_wlf50")
								{
									if (253773 - 3429 == 250345)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_royal" + num2, typeof(Texture2D));
									if (81905 - 565065 != -483159)
									{
										goto IL_DFF;
									}
									continue;
								}
								else if (nArmor == "a_wlf51")
								{
									if (187584 - 453846 == -266261)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_royal" + num2, typeof(Texture2D));
									if (184041 - 408768 != -224727)
									{
										continue;
									}
									goto IL_DFF;
								}
								else if (nArmor == "a_wlf52")
								{
									if (134433 - 323970 == -189536)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_royal" + num2 + "R", typeof(Texture2D));
									if (30735 - 496787 != -466051)
									{
										goto IL_DFF;
									}
									continue;
								}
								else if (nArmor == "a_wlf60")
								{
									if (288257 - 145946 != 142311)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_legend" + num2, typeof(Texture2D));
									if (192687 - 315961 != -123273)
									{
										goto IL_DFF;
									}
									continue;
								}
								else if (nArmor == "a_wlf61")
								{
									if (139487 - 435842 != -296355)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_legend" + num2, typeof(Texture2D));
									if (35850 - 197768 != -161917)
									{
										goto IL_DFF;
									}
									continue;
								}
								else if (nArmor == "a_wlf62")
								{
									if (47424 - 324830 == -277405)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_legend" + num2 + "R", typeof(Texture2D));
									if (149491 - 353852 != -204361)
									{
										continue;
									}
									goto IL_DFF;
								}
								else if (nArmor == "a_wlf65")
								{
									if (266995 - 64400 != 202595)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_thai" + num2, typeof(Texture2D));
									if (126750 - 148928 != -22177)
									{
										goto IL_DFF;
									}
									continue;
								}
								else
								{
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_standard" + num2, typeof(Texture2D));
									if (13873 - 108962 != -95089)
									{
										continue;
									}
									goto IL_DFF;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Wolf/Armors/Materials/Wolf_nude" + num2, typeof(Texture2D));
								if (169093 - 76083 == 93011)
								{
									continue;
								}
								IL_DFF:
								Color[] pixels2 = texture2D2.GetPixels(0, 256, 256, 256, 0);
								if (136465 - 475640 != -339174)
								{
									int i = 0;
									if (250870 - 132929 != 117942)
									{
										while (i < pixels2.Length)
										{
											float a = pixels[i].a;
											if (244460 - 368691 == -124230)
											{
												goto IL_1C4;
											}
											pixels2[i] = a * pixels[i] + ((float)1 - a) * pixels2[i];
											if (52707 - 85528 == -32820)
											{
												goto IL_1C4;
											}
											i++;
											if (207201 - 181812 != 25389)
											{
												goto IL_1C4;
											}
										}
										if (278538 - 80362 == 198176)
										{
											if (259744 - 181644 == 78100)
											{
												Texture2D texture2D3 = new Texture2D(512, 512, TextureFormat.RGB24, true);
												if (173354 - 296758 != -123403)
												{
													texture2D3.SetPixels(0, 256, 256, 256, pixels2, 0);
													if (219604 - 164516 != 55089)
													{
														texture2D3.SetPixels(256, 256, 256, 256, texture2D2.GetPixels(256, 256, 256, 256, 0), 0);
														if (65300 - 388250 == -322950)
														{
															texture2D3.SetPixels(0, 0, 512, 256, texture2D2.GetPixels(0, 0, 512, 256, 0), 0);
															if (31593 - 537381 != -505787)
															{
																texture2D3.Apply();
																if (10026 - 442428 != -432401)
																{
																	texture2D3.Compress(true);
																	if (288247 - 335609 != -47361 && 221455 - 329197 != -107741)
																	{
																		material = new Material(Shader.Find("Diffuse"));
																		if (167466 - 596154 == -428688)
																		{
																			material.color = new Color(0.86f, 0.86f, 0.86f, (float)1);
																			if (268358 - 205136 == 63222)
																			{
																				material.mainTexture = texture2D3;
																				if (178889 - 302313 != -123423)
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
		}
		return material;
	}

	// Token: 0x06003872 RID: 14450 RVA: 0x0076784C File Offset: 0x00765A4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipArmor(string nArmor)
	{
		if (97241 - 125764 != -28522)
		{
		}
		for (;;)
		{
			if (nArmor == "a_none")
			{
				if (126270 - 561353 == -435082)
				{
					continue;
				}
				nArmor = "none";
				if (279381 - 311585 != -32204)
				{
					continue;
				}
			}
			this.armor = nArmor;
			if (219325 - 250451 != -31125)
			{
				Transform transform = global::Math.findChildObject(this.transform, "Wolf_tri");
				if (180538 - 231156 != -50617)
				{
					if (transform)
					{
						if (67705 - 513449 != -445744)
						{
							continue;
						}
						SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer));
						if (290628 - 576077 != -285449)
						{
							continue;
						}
						skinnedMeshRenderer.sharedMesh = WolfEquipment.getArmorMesh(nArmor);
						if (222940 - 151986 != 70954)
						{
							continue;
						}
						if (Extensions.get_length(skinnedMeshRenderer.materials) > 0)
						{
							if (53843 - 234350 != -180507)
							{
								continue;
							}
							skinnedMeshRenderer.material = WolfEquipment.getArmorMaterial(nArmor, this.skin);
							if (143436 - 461816 != -318380)
							{
								continue;
							}
						}
						if (this.WmnA82hbGK != null)
						{
							if (93122 - 11722 == 81401)
							{
								continue;
							}
							skinnedMeshRenderer.material.color = this.WmnA82hbGK.mColor;
							if (278834 - 48997 != 229837)
							{
								continue;
							}
						}
					}
					if (!this.WmnA82hbGK)
					{
						break;
					}
					if (154012 - 556274 != -402261)
					{
						this.WmnA82hbGK.armor = nArmor;
						if (246607 - 119837 == 126770)
						{
							if (this.WmnA82hbGK.getStatus("blend") != null)
							{
								if (121843 - 127999 == -6155)
								{
									continue;
								}
								this.WmnA82hbGK.removeStatus("blend");
								if (205573 - 1556 == 204018)
								{
									continue;
								}
							}
							if (this.WmnA82hbGK.getStatus("invisible") == null)
							{
								break;
							}
							if (229096 - 30589 == 198507)
							{
								this.WmnA82hbGK.removeStatus("invisible");
								if (109682 - 244495 != -134812)
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

	// Token: 0x06003873 RID: 14451 RVA: 0x00767B50 File Offset: 0x00765D50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getAccessory(string nAccessory)
	{
		if (219852 - 49164 != 170689)
		{
		}
		GameObject result;
		for (;;)
		{
			result = null;
			if (80153 - 80228 == -75)
			{
				if (37530 - 170799 == -133269)
				{
					if (nAccessory == "c_all1")
					{
						if (222803 - 400418 == -177615)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/redPandaHat", typeof(GameObject));
							if (191002 - 69737 != 121266)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all3")
					{
						if (51027 - 228228 != -177200)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/paperHat", typeof(GameObject));
							if (105960 - 95691 != 10270)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all6")
					{
						if (260524 - 522680 != -262155)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/vHat", typeof(GameObject));
							if (28019 - 176362 != -148342)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all7")
					{
						if (119463 - 136936 == -17473)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/partyHatB", typeof(GameObject));
							if (223187 - 196677 == 26510)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all8")
					{
						if (20908 - 35818 != -14909)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/partyHatR", typeof(GameObject));
							if (67301 - 343752 != -276450)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all9")
					{
						if (17936 - 161188 == -143252)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/cakeHat", typeof(GameObject));
							if (199757 - 504689 == -304932)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all10")
					{
						if (223927 - 439160 == -215233)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/candyHat", typeof(GameObject));
							if (64836 - 85931 == -21095)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all11")
					{
						if (162432 - 77422 == 85010)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/afro", typeof(GameObject));
							if (18263 - 211000 != -192736)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all12")
					{
						if (8587 - 392016 != -383428)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/afroC", typeof(GameObject));
							if (24316 - 417713 == -393397)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all15")
					{
						if (209761 - 208628 != 1134)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/santaHat", typeof(GameObject));
							if (41465 - 248421 != -206955)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all16")
					{
						if (73612 - 30844 != 42769)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/pirateBandana", typeof(GameObject));
							if (8762 - 447512 == -438750)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all18")
					{
						if (288709 - 83464 == 205245)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/halo", typeof(GameObject));
							if (126152 - 266104 != -139951)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all19")
					{
						if (217645 - 541523 == -323878)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/horn", typeof(GameObject));
							if (147505 - 34745 == 112760)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all21")
					{
						if (189675 - 87480 == 102195)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/earmuff1", typeof(GameObject));
							if (235967 - 416402 == -180435)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all22")
					{
						if (258854 - 475417 != -216562)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/earmuff2", typeof(GameObject));
							if (80686 - 313444 != -232757)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all23")
					{
						if (9213 - 343859 == -334646)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/headphone1", typeof(GameObject));
							if (109759 - 444318 == -334559)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all24")
					{
						if (261970 - 468799 == -206829)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/headphone2", typeof(GameObject));
							if (191883 - 74486 == 117397)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all25")
					{
						if (11336 - 165642 == -154306)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/headphone3", typeof(GameObject));
							if (47668 - 157570 != -109901)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all26")
					{
						if (126236 - 94954 != 31283)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/pirateBandanaR", typeof(GameObject));
							if (233787 - 248883 == -15096)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all27")
					{
						if (213929 - 329687 != -115757)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/krathongHat1", typeof(GameObject));
							if (123519 - 418126 != -294606)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all28")
					{
						if (274951 - 439196 != -164244)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/krathongHat2", typeof(GameObject));
							if (193065 - 183710 != 9356)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all29")
					{
						if (72112 - 236024 == -163912)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/snowmanHead", typeof(GameObject));
							if (111642 - 99213 != 12430)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all37")
					{
						if (72834 - 166729 == -93895)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/quizHat", typeof(GameObject));
							if (76832 - 169693 == -92861)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all38")
					{
						if (86823 - 325059 != -238235)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/fanKingHat", typeof(GameObject));
							if (268611 - 58733 == 209878)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all39")
					{
						if (103586 - 27586 != 76001)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/artistHat", typeof(GameObject));
							if (4042 - 291237 != -287194)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all43")
					{
						if (287995 - 259607 != 28389)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/pvpHelmet", typeof(GameObject));
							if (12228 - 568669 != -556440)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all44")
					{
						if (94145 - 77986 == 16159)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/pvpHelmetR", typeof(GameObject));
							if (226775 - 81713 == 145062)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all46")
					{
						if (84605 - 354429 != -269823)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/mummyHead", typeof(GameObject));
							if (255881 - 2464 != 253418)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all55")
					{
						if (162323 - 303920 != -141596)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/giveMeFive", typeof(GameObject));
							if (235994 - 231918 == 4076)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all56")
					{
						if (188933 - 235366 == -46433)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/frozenCrown", typeof(GameObject));
							if (109135 - 121929 == -12794)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all58")
					{
						if (233690 - 369265 != -135574)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/championHelmet", typeof(GameObject));
							if (170379 - 10484 == 159895)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all66")
					{
						if (106907 - 499568 == -392661)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/poseidonHelmet", typeof(GameObject));
							if (117377 - 555789 != -438411)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mal37")
					{
						if (69027 - 45128 != 23900)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/dragonHead", typeof(GameObject));
							if (240470 - 481810 == -241340)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf1")
					{
						if (186956 - 469262 == -282306)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/simpleBandana", typeof(GameObject));
							if (119398 - 420132 == -300734)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf5")
					{
						if (36696 - 233547 == -196851)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/fcBandana", typeof(GameObject));
							if (205590 - 122378 == 83212)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf10")
					{
						if (260035 - 32249 != 227787)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/simpleBandana", typeof(GameObject));
							if (1352 - 564897 == -563545)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf11")
					{
						if (79848 - 297810 == -217962)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/simpleBandanaR", typeof(GameObject));
							if (186252 - 451215 == -264963)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf12")
					{
						if (174621 - 276729 != -102107)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/simpleBandanaV", typeof(GameObject));
							if (89131 - 478903 == -389772)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf15")
					{
						if (235619 - 593755 != -358135)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/summerGlasses", typeof(GameObject));
							if (199408 - 68338 == 131070)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf19")
					{
						if (267947 - 13194 != 254754)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/veggieHat", typeof(GameObject));
							if (59149 - 543575 != -484425)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf21")
					{
						if (12533 - 568148 == -555615)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/soldierHelmet", typeof(GameObject));
							if (15588 - 354706 != -339117)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf22")
					{
						if (145654 - 62794 != 82861)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/vagabondBandana", typeof(GameObject));
							if (204020 - 314040 != -110019)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf23")
					{
						if (288680 - 371724 == -83044)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/soldierHelmetR", typeof(GameObject));
							if (225812 - 335140 == -109328)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf24")
					{
						if (37298 - 192777 == -155479)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/vagabondBandanaR", typeof(GameObject));
							if (143171 - 461530 != -318358)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf25")
					{
						if (126138 - 270629 == -144491)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/butlerCap", typeof(GameObject));
							if (110143 - 106949 == 3194)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf31")
					{
						if (222974 - 25751 == 197223)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/paladinHelmet", typeof(GameObject));
							if (42515 - 428611 != -386095)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf32")
					{
						if (198008 - 414884 != -216875)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/bladeBandana", typeof(GameObject));
							if (154943 - 338491 == -183548)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf33")
					{
						if (243457 - 575685 != -332227)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/paladinHelmetR", typeof(GameObject));
							if (224003 - 263538 != -39534)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf34")
					{
						if (76753 - 478977 == -402224)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/bladeBandanaR", typeof(GameObject));
							if (169541 - 90895 != 78647)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf35")
					{
						if (185356 - 245352 != -59995)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/hallowMask", typeof(GameObject));
							if (63861 - 575212 != -511350)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf36")
					{
						if (142904 - 437394 == -294490)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/ligerMask", typeof(GameObject));
							if (68264 - 481715 != -413450)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf40")
					{
						if (74807 - 3578 == 71229)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/heroHelmet", typeof(GameObject));
							if (246448 - 155475 == 90973)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf41")
					{
						if (161989 - 121681 != 40309)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/heroHelmetR", typeof(GameObject));
							if (223348 - 555753 == -332405)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf42")
					{
						if (165157 - 327849 == -162692)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/heroHelmetV", typeof(GameObject));
							if (242347 - 139253 == 103094)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf45")
					{
						if (241250 - 262294 == -21044)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/superStarHat", typeof(GameObject));
							if (232744 - 585990 != -353245)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf47")
					{
						if (139849 - 256607 == -116758)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/scorpionHelmet", typeof(GameObject));
							if (20464 - 492996 == -472532)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf48")
					{
						if (293651 - 206723 != 86929)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/scorpionHelmetR", typeof(GameObject));
							if (7527 - 199266 != -191738)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf50")
					{
						if (219792 - 521500 == -301708)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/royalHelmet", typeof(GameObject));
							if (221237 - 273180 == -51943)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf51")
					{
						if (112729 - 331887 == -219158)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/royalHelmet", typeof(GameObject));
							if (178661 - 245667 == -67006)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf52")
					{
						if (171465 - 383528 != -212062)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/royalHelmetR", typeof(GameObject));
							if (186333 - 312939 != -126605)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf60")
					{
						if (223750 - 98150 != 125601)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/legendHelmet", typeof(GameObject));
							if (293226 - 140878 == 152348)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf61")
					{
						if (62468 - 34551 != 27918)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/legendHelmet", typeof(GameObject));
							if (128948 - 97659 == 31289)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_wlf62")
					{
						if (6682 - 78566 == -71884)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/legendHelmetR", typeof(GameObject));
							if (90951 - 506004 != -415052)
							{
								break;
							}
						}
					}
					else
					{
						if (!(nAccessory == "c_wlf65"))
						{
							break;
						}
						if (197597 - 404 == 197193)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Accessories/thaiHelmet", typeof(GameObject));
							if (199316 - 555038 == -355722)
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

	// Token: 0x06003874 RID: 14452 RVA: 0x00769484 File Offset: 0x00767684
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipAccessory(string nAccessory)
	{
		if (221648 - 314163 != -92515)
		{
		}
		for (;;)
		{
			this.accessory = nAccessory;
			if (150987 - 82472 != 68516)
			{
				if (this.iSEAoSOxyj)
				{
					if (296480 - 450148 != -153668)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.iSEAoSOxyj);
					if (197221 - 403644 == -206422)
					{
						continue;
					}
				}
				GameObject gameObject = WolfEquipment.getAccessory(nAccessory);
				if (298070 - 26224 == 271846)
				{
					if (gameObject)
					{
						if (291238 - 500672 == -209433)
						{
							continue;
						}
						this.iSEAoSOxyj = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (81444 - 332161 == -250716)
						{
							continue;
						}
						if (78064 - 582473 != -504409)
						{
							continue;
						}
						if (!(nAccessory == "c_all27"))
						{
							if (223311 - 52150 != 171161)
							{
								continue;
							}
							if (nAccessory == "c_all28")
							{
								if (158012 - 151286 != 6726)
								{
									continue;
								}
							}
							else
							{
								this.iSEAoSOxyj.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
								if (70840 - 470762 != -399922)
								{
									continue;
								}
								this.iSEAoSOxyj.transform.localPosition = Vector3.zero;
								if (6968 - 382076 == -375107)
								{
									continue;
								}
								this.iSEAoSOxyj.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
								if (195921 - 119149 != 76772)
								{
									continue;
								}
								this.iSEAoSOxyj.transform.localScale = Vector3.one;
								if (233323 - 68689 != 164634)
								{
									continue;
								}
								goto IL_38D;
							}
						}
						this.iSEAoSOxyj.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
						if (264479 - 498745 == -234265)
						{
							continue;
						}
						this.iSEAoSOxyj.transform.localPosition = Vector3.zero;
						if (31007 - 281325 != -250318)
						{
							continue;
						}
						this.iSEAoSOxyj.transform.localRotation = Quaternion.Euler((float)270, (float)0, (float)90);
						if (37461 - 401906 != -364445)
						{
							continue;
						}
						this.iSEAoSOxyj.transform.localScale = Vector3.one;
						if (22836 - 416031 != -393195)
						{
							continue;
						}
					}
					IL_38D:
					if (!this.WmnA82hbGK)
					{
						break;
					}
					if (134003 - 239740 == -105737)
					{
						this.WmnA82hbGK.accessory = nAccessory;
						if (283028 - 184906 != 98123)
						{
							this.WmnA82hbGK.mAcc = this.iSEAoSOxyj;
							if (110262 - 327581 != -217318)
							{
								if (this.WmnA82hbGK.getStatus("blend") != null)
								{
									if (289402 - 39688 != 249714)
									{
										continue;
									}
									this.WmnA82hbGK.removeStatus("blend");
									if (32646 - 176021 != -143375)
									{
										continue;
									}
								}
								if (this.WmnA82hbGK.getStatus("invisible") == null)
								{
									break;
								}
								if (199496 - 253865 != -54368)
								{
									this.WmnA82hbGK.removeStatus("invisible");
									if (218203 - 573591 == -355388)
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

	// Token: 0x06003875 RID: 14453 RVA: 0x007698FC File Offset: 0x00767AFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipBoot(string nBoot)
	{
		if (288869 - 480296 != -191427)
		{
		}
		while (this.WmnA82hbGK)
		{
			if (94346 - 383064 == -288718)
			{
				if (this.WmnA82hbGK.getStatus("blend") != null)
				{
					if (70853 - 291639 == -220785)
					{
						continue;
					}
					this.WmnA82hbGK.removeStatus("blend");
					if (161182 - 13974 == 147209)
					{
						continue;
					}
				}
				if (this.WmnA82hbGK.getStatus("invisible") == null)
				{
					break;
				}
				if (265234 - 144897 != 120338)
				{
					this.WmnA82hbGK.removeStatus("invisible");
					if (146405 - 123277 == 23128)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003876 RID: 14454 RVA: 0x00769A10 File Offset: 0x00767C10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getTrinket(string nTrinket)
	{
		if (20828 - 534131 != -513302)
		{
		}
		GameObject result;
		for (;;)
		{
			result = null;
			if (109214 - 292063 != -182848)
			{
				if (255174 - 48449 == 206725)
				{
					if (nTrinket == "t_all1")
					{
						if (211452 - 345579 == -134127)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/glasses", typeof(GameObject));
							if (37316 - 108431 == -71115)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all2")
					{
						if (29447 - 434025 != -404577)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/sunGlasses", typeof(GameObject));
							if (162259 - 348469 == -186210)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all3")
					{
						if (152653 - 434466 != -281812)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/starGlasses", typeof(GameObject));
							if (264139 - 295870 != -31730)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all4")
					{
						if (248449 - 11149 != 237301)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/nerdGlasses", typeof(GameObject));
							if (223211 - 299270 == -76059)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all5")
					{
						if (104597 - 106691 != -2093)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/blackGlasses", typeof(GameObject));
							if (294640 - 409554 == -114914)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all6")
					{
						if (258742 - 183136 == 75606)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/bugAntenna", typeof(GameObject));
							if (291812 - 290823 != 990)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all7")
					{
						if (253715 - 139473 != 114243)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/partyWhistle", typeof(GameObject));
							if (237283 - 48967 == 188316)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all8")
					{
						if (43676 - 126443 != -82766)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/redNose", typeof(GameObject));
							if (241638 - 456001 != -214362)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all9")
					{
						if (235960 - 342250 != -106289)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/lollipop", typeof(GameObject));
							if (754 - 61869 != -61114)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all46")
					{
						if (68028 - 68323 == -295)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/groceryBag", typeof(GameObject));
							if (201053 - 585094 != -384040)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all51")
					{
						if (285331 - 523909 == -238578)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/sandTopaz", typeof(GameObject));
							if (20575 - 148998 != -128422)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all55")
					{
						if (273480 - 334671 == -61191)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/fifthSword", typeof(GameObject));
							if (253389 - 468394 != -215004)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all56")
					{
						if (102672 - 150318 != -47645)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/fifthWand", typeof(GameObject));
							if (98572 - 550831 != -452258)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all57")
					{
						if (250700 - 251252 == -552)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/fifthWing", typeof(GameObject));
							if (46654 - 304178 == -257524)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all58")
					{
						if (91565 - 47980 != 43586)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/carronBag", typeof(GameObject));
							if (90588 - 55110 == 35478)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all59")
					{
						if (201896 - 325520 == -123624)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/mupoBag", typeof(GameObject));
							if (187514 - 159953 == 27561)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all66")
					{
						if (151663 - 134181 == 17482)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/doubleHorn", typeof(GameObject));
							if (197848 - 269712 == -71864)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all71")
					{
						if (274195 - 539425 != -265229)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/championFlag1", typeof(GameObject));
							if (245879 - 557960 != -312080)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all72")
					{
						if (133052 - 94490 != 38563)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/championFlag2", typeof(GameObject));
							if (197826 - 355434 != -157607)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all73")
					{
						if (245401 - 14079 != 231323)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/championFlag3", typeof(GameObject));
							if (239939 - 207594 == 32345)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all74")
					{
						if (116831 - 196315 != -79483)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/championFlag4", typeof(GameObject));
							if (125823 - 356879 == -231056)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all75")
					{
						if (249579 - 173888 == 75691)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/championFlag5", typeof(GameObject));
							if (54210 - 127953 == -73743)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all91")
					{
						if (207312 - 328407 == -121095)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/lightSeal", typeof(GameObject));
							if (54528 - 522905 != -468376)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all92")
					{
						if (118724 - 274105 == -155381)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/fireSeal", typeof(GameObject));
							if (4563 - 62899 != -58335)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all93")
					{
						if (258463 - 577503 == -319040)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/waterSeal", typeof(GameObject));
							if (282147 - 215648 != 66500)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all94")
					{
						if (247730 - 141830 == 105900)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/windSeal", typeof(GameObject));
							if (241089 - 119708 != 121382)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all95")
					{
						if (277042 - 580742 != -303699)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/earthSeal", typeof(GameObject));
							if (249569 - 297968 != -48398)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all96")
					{
						if (10585 - 237155 == -226570)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/shadowSeal", typeof(GameObject));
							if (51006 - 227896 != -176889)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal11")
					{
						if (14108 - 45503 != -31394)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/comic", typeof(GameObject));
							if (136969 - 97981 == 38988)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal14")
					{
						if (13463 - 272390 != -258926)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/heartRing", typeof(GameObject));
							if (242478 - 105401 != 137078)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal15")
					{
						if (221514 - 81691 == 139823)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/santaBag", typeof(GameObject));
							if (249586 - 217735 == 31851)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal31")
					{
						if (62677 - 133843 == -71166)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/chineseTalisman", typeof(GameObject));
							if (82262 - 345713 != -263450)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal37")
					{
						if (57017 - 533475 != -476457)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/chineseLantern", typeof(GameObject));
							if (290128 - 587593 != -297464)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal46")
					{
						if (137122 - 71676 == 65446)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/curseAnkh", typeof(GameObject));
							if (157044 - 537823 != -380778)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal56")
					{
						if (231080 - 197648 != 33433)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/frozenWing", typeof(GameObject));
							if (288204 - 414874 != -126669)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal66")
					{
						if (109172 - 495544 != -386371)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/poseidonTrinket", typeof(GameObject));
							if (79931 - 192072 != -112140)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all71")
					{
						if (233200 - 94390 == 138810)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/championFlag1", typeof(GameObject));
							if (254640 - 536787 == -282147)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_wlf60")
					{
						if (276625 - 254357 == 22268)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/legendTrinket", typeof(GameObject));
							if (8317 - 311429 == -303112)
							{
								break;
							}
						}
					}
					else
					{
						if (!(nTrinket == "t_wlf62"))
						{
							break;
						}
						if (126869 - 405173 == -278304)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Trinkets/legendTrinketR", typeof(GameObject));
							if (86206 - 141296 != -55089)
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

	// Token: 0x06003877 RID: 14455 RVA: 0x0076A998 File Offset: 0x00768B98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipTrinket(string nTrinket)
	{
		if (71598 - 484967 != -413369)
		{
		}
		for (;;)
		{
			this.trinket = nTrinket;
			if (162807 - 265939 != -103131)
			{
				if (this.H3ZAkyppMf)
				{
					if (229690 - 77153 != 152537)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.H3ZAkyppMf);
					if (85335 - 323186 != -237851)
					{
						continue;
					}
				}
				GameObject gameObject = WolfEquipment.getTrinket(nTrinket);
				if (19135 - 502665 == -483530)
				{
					if (gameObject)
					{
						if (78278 - 571203 == -492924)
						{
							continue;
						}
						this.H3ZAkyppMf = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (83122 - 237486 != -154364)
						{
							continue;
						}
						if (109498 - 246206 == -136707)
						{
							continue;
						}
						if (!(nTrinket == "t_all71"))
						{
							if (1655 - 522660 != -521005)
							{
								continue;
							}
							if (!(nTrinket == "t_all72"))
							{
								if (139342 - 138354 != 988)
								{
									continue;
								}
								if (!(nTrinket == "t_all73"))
								{
									if (222661 - 574808 != -352147)
									{
										continue;
									}
									if (!(nTrinket == "t_all74"))
									{
										if (64009 - 307441 != -243432)
										{
											continue;
										}
										if (!(nTrinket == "t_all75"))
										{
											if (126028 - 387168 == -261139)
											{
												continue;
											}
											if (!(nTrinket == "t_mal56"))
											{
												if (239960 - 592805 == -352844)
												{
													continue;
												}
												if (nTrinket == "t_mal66")
												{
													if (142716 - 350379 != -207663)
													{
														continue;
													}
												}
												else if (nTrinket == "t_mal11")
												{
													if (165938 - 353121 != -187183)
													{
														continue;
													}
													this.H3ZAkyppMf.transform.parent = global::Math.findChildObject(this.gameObject.transform, "mount_Hand_L");
													if (22036 - 189977 == -167940)
													{
														continue;
													}
													this.H3ZAkyppMf.transform.localPosition = Vector3.zero;
													if (191192 - 523377 != -332185)
													{
														continue;
													}
													this.H3ZAkyppMf.transform.localRotation = Quaternion.identity;
													if (207506 - 92488 != 115018)
													{
														continue;
													}
													this.H3ZAkyppMf.transform.localScale = Vector3.one;
													if (294771 - 523934 != -229163)
													{
														continue;
													}
													goto IL_8D8;
												}
												else
												{
													if (!(nTrinket == "t_all55"))
													{
														if (46493 - 346223 == -299729)
														{
															continue;
														}
														if (!(nTrinket == "t_all56"))
														{
															if (100954 - 48658 == 52297)
															{
																continue;
															}
															if (!(nTrinket == "t_all57"))
															{
																if (58943 - 176166 == -117222)
																{
																	continue;
																}
																if (!(nTrinket == "t_all58"))
																{
																	if (67011 - 247448 == -180436)
																	{
																		continue;
																	}
																	if (!(nTrinket == "t_all59"))
																	{
																		if (43410 - 248631 == -205220)
																		{
																			continue;
																		}
																		if (!(nTrinket == "t_mal15"))
																		{
																			if (47499 - 199382 != -151883)
																			{
																				continue;
																			}
																			if (!(nTrinket == "t_wlf60"))
																			{
																				if (235365 - 381329 != -145964)
																				{
																					continue;
																				}
																				if (nTrinket == "t_wlf62")
																				{
																					if (52655 - 92619 == -39963)
																					{
																						continue;
																					}
																				}
																				else if (nTrinket == "t_mal37")
																				{
																					if (21030 - 529508 != -508478)
																					{
																						continue;
																					}
																					this.H3ZAkyppMf.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine2");
																					if (114832 - 526684 == -411851)
																					{
																						continue;
																					}
																					this.H3ZAkyppMf.transform.localPosition = Vector3.zero;
																					if (260784 - 199536 == 61249)
																					{
																						continue;
																					}
																					this.H3ZAkyppMf.transform.localRotation = Quaternion.Euler((float)270, (float)90, (float)0);
																					if (240523 - 207718 == 32806)
																					{
																						continue;
																					}
																					this.H3ZAkyppMf.transform.localScale = Vector3.one;
																					if (159127 - 419269 != -260141)
																					{
																						goto IL_8D8;
																					}
																					continue;
																				}
																				else if (nTrinket == "t_all46")
																				{
																					if (182941 - 197688 != -14747)
																					{
																						continue;
																					}
																					this.H3ZAkyppMf.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Hand_R");
																					if (133114 - 30566 != 102548)
																					{
																						continue;
																					}
																					this.H3ZAkyppMf.transform.localPosition = Vector3.zero;
																					if (92540 - 316876 != -224336)
																					{
																						continue;
																					}
																					this.H3ZAkyppMf.transform.localRotation = Quaternion.identity;
																					if (149944 - 334933 != -184989)
																					{
																						continue;
																					}
																					this.H3ZAkyppMf.transform.localScale = Vector3.one;
																					if (271486 - 15766 != 255720)
																					{
																						continue;
																					}
																					goto IL_8D8;
																				}
																				else
																				{
																					if (!(nTrinket == "t_all91"))
																					{
																						if (142870 - 468530 != -325660)
																						{
																							continue;
																						}
																						if (!(nTrinket == "t_all92"))
																						{
																							if (159498 - 384992 == -225493)
																							{
																								continue;
																							}
																							if (!(nTrinket == "t_all93"))
																							{
																								if (157680 - 503376 == -345695)
																								{
																									continue;
																								}
																								if (!(nTrinket == "t_all94"))
																								{
																									if (245828 - 133578 == 112251)
																									{
																										continue;
																									}
																									if (!(nTrinket == "t_all95"))
																									{
																										if (184064 - 233934 != -49870)
																										{
																											continue;
																										}
																										if (nTrinket == "t_all96")
																										{
																											if (211010 - 383830 != -172820)
																											{
																												continue;
																											}
																										}
																										else
																										{
																											this.H3ZAkyppMf.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
																											if (248672 - 285806 != -37134)
																											{
																												continue;
																											}
																											this.H3ZAkyppMf.transform.localPosition = Vector3.zero;
																											if (77417 - 28540 != 48877)
																											{
																												continue;
																											}
																											this.H3ZAkyppMf.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
																											if (86382 - 326215 != -239833)
																											{
																												continue;
																											}
																											this.H3ZAkyppMf.transform.localScale = Vector3.one;
																											if (118302 - 373079 != -254777)
																											{
																												continue;
																											}
																											goto IL_8D8;
																										}
																									}
																								}
																							}
																						}
																					}
																					this.H3ZAkyppMf.transform.parent = this.gameObject.transform;
																					if (10004 - 457536 != -447532)
																					{
																						continue;
																					}
																					this.H3ZAkyppMf.transform.localPosition = Vector3.zero;
																					if (225807 - 309622 == -83814)
																					{
																						continue;
																					}
																					this.H3ZAkyppMf.transform.localRotation = Quaternion.identity;
																					if (120266 - 84811 != 35455)
																					{
																						continue;
																					}
																					this.H3ZAkyppMf.transform.localScale = Vector3.one;
																					if (267521 - 317402 != -49880)
																					{
																						goto IL_8D8;
																					}
																					continue;
																				}
																			}
																		}
																	}
																}
															}
														}
													}
													this.H3ZAkyppMf.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine1");
													if (162177 - 495363 == -333185)
													{
														continue;
													}
													this.H3ZAkyppMf.transform.localPosition = Vector3.zero;
													if (58631 - 357253 != -298622)
													{
														continue;
													}
													this.H3ZAkyppMf.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
													if (93925 - 79834 != 14091)
													{
														continue;
													}
													this.H3ZAkyppMf.transform.localScale = Vector3.one;
													if (134693 - 38882 != 95811)
													{
														continue;
													}
													goto IL_8D8;
												}
											}
										}
									}
								}
							}
						}
						this.H3ZAkyppMf.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine2");
						if (260008 - 530889 == -270880)
						{
							continue;
						}
						this.H3ZAkyppMf.transform.localPosition = Vector3.zero;
						if (190533 - 301051 != -110518)
						{
							continue;
						}
						this.H3ZAkyppMf.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
						if (219087 - 405311 == -186223)
						{
							continue;
						}
						this.H3ZAkyppMf.transform.localScale = Vector3.one;
						if (76956 - 209730 != -132774)
						{
							continue;
						}
					}
					IL_8D8:
					if (!this.WmnA82hbGK)
					{
						break;
					}
					if (55948 - 503803 != -447854)
					{
						this.WmnA82hbGK.trinket = nTrinket;
						if (261633 - 2069 != 259565)
						{
							this.WmnA82hbGK.mTrn = this.H3ZAkyppMf;
							if (201491 - 228420 != -26928)
							{
								if (this.WmnA82hbGK.getStatus("blend") != null)
								{
									if (225616 - 547235 == -321618)
									{
										continue;
									}
									this.WmnA82hbGK.removeStatus("blend");
									if (33425 - 547226 == -513800)
									{
										continue;
									}
								}
								if (this.WmnA82hbGK.getStatus("invisible") == null)
								{
									break;
								}
								if (55129 - 67838 == -12709)
								{
									this.WmnA82hbGK.removeStatus("invisible");
									if (110158 - 96616 != 13543)
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

	// Token: 0x06003878 RID: 14456 RVA: 0x0076B5C4 File Offset: 0x007697C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipPet(string nPet)
	{
		if (160358 - 106778 != 53580)
		{
		}
		for (;;)
		{
			if (Game.mGameType < 2)
			{
				if (226578 - 596299 != -369720)
				{
					break;
				}
			}
			else
			{
				this.pet = nPet;
				if (64544 - 115010 == -50466)
				{
					if (this.OlZAF9O2KQ)
					{
						if (75917 - 545896 != -469979)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.OlZAF9O2KQ);
						if (139682 - 275153 == -135470)
						{
							continue;
						}
					}
					GameObject gameObject = null;
					if (68693 - 520108 == -451415)
					{
						int num = 1;
						if (143179 - 417815 == -274636)
						{
							if (55476 - 137683 != -82206)
							{
								if (nPet == "p_all1")
								{
									if (81424 - 495904 != -414480)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/bigbugBalloon", typeof(GameObject));
									if (17369 - 340256 == -322886)
									{
										continue;
									}
								}
								else if (nPet == "p_all2")
								{
									if (101043 - 477074 != -376031)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/bluebugBalloon", typeof(GameObject));
									if (20614 - 330988 == -310373)
									{
										continue;
									}
								}
								else if (nPet == "p_all3")
								{
									if (280156 - 162042 == 118115)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/momBalloon", typeof(GameObject));
									if (296710 - 361532 == -64821)
									{
										continue;
									}
								}
								else if (nPet == "p_all4")
								{
									if (15090 - 289388 != -274298)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/dadBalloon", typeof(GameObject));
									if (232837 - 486053 != -253216)
									{
										continue;
									}
								}
								else if (nPet == "p_all11")
								{
									if (141455 - 149456 == -8000)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallSmashBall", typeof(GameObject));
									if (104962 - 325224 != -220262)
									{
										continue;
									}
								}
								else if (nPet == "p_all12")
								{
									if (154807 - 205243 != -50436)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/soccerBall", typeof(GameObject));
									if (26972 - 155863 != -128891)
									{
										continue;
									}
								}
								else if (nPet == "p_all21")
								{
									if (31124 - 111862 != -80738)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteChula", typeof(GameObject));
									if (298632 - 370897 == -72264)
									{
										continue;
									}
								}
								else if (nPet == "p_all22")
								{
									if (123774 - 140676 == -16901)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kitePukpao", typeof(GameObject));
									if (40157 - 442929 == -402771)
									{
										continue;
									}
								}
								else if (nPet == "p_all23")
								{
									if (193874 - 382209 != -188335)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteButterfly", typeof(GameObject));
									if (187074 - 434166 != -247092)
									{
										continue;
									}
								}
								else if (nPet == "p_all24")
								{
									if (272963 - 261360 != 11603)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteSnake", typeof(GameObject));
									if (122367 - 559683 == -437315)
									{
										continue;
									}
								}
								else if (Extensions.get_length(nPet) == 6)
								{
									if (15177 - 131440 != -116263)
									{
										continue;
									}
									string a = nPet.Substring(0, 5);
									if (255926 - 174458 != 81468)
									{
										continue;
									}
									if (a == "p_lcr")
									{
										if (101332 - 404167 != -302835)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron", typeof(GameObject));
										if (120543 - 570308 != -449765)
										{
											continue;
										}
									}
									else if (a == "p_lcp")
									{
										if (192314 - 102822 != 89492)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron_p", typeof(GameObject));
										if (118688 - 67987 == 50702)
										{
											continue;
										}
									}
									else if (a == "p_lmp")
									{
										if (261756 - 310158 != -48402)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMupo", typeof(GameObject));
										if (52084 - 58516 != -6432)
										{
											continue;
										}
									}
									else if (a == "p_lpp")
									{
										if (275527 - 203504 == 72024)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePeppon", typeof(GameObject));
										if (16837 - 27575 != -10738)
										{
											continue;
										}
									}
									else if (a == "p_lct")
									{
										if (89375 - 416098 != -326723)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCacton", typeof(GameObject));
										if (2818 - 253719 != -250901)
										{
											continue;
										}
									}
									else if (a == "p_lcc")
									{
										if (261228 - 531866 != -270638)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCocon", typeof(GameObject));
										if (219445 - 125105 != 94340)
										{
											continue;
										}
									}
									else if (a == "p_lpk")
									{
										if (185288 - 113880 != 71408)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePumpkon", typeof(GameObject));
										if (132834 - 19926 == 112909)
										{
											continue;
										}
									}
									else if (a == "p_lml")
									{
										if (2107 - 377330 != -375223)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMellon", typeof(GameObject));
										if (184330 - 595833 != -411503)
										{
											continue;
										}
									}
									else if (a == "p_lbd")
									{
										if (113076 - 375646 != -262570)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleBDMellon", typeof(GameObject));
										if (254169 - 205511 != 48658)
										{
											continue;
										}
									}
									else if (a == "p_lcs")
									{
										if (213850 - 183489 != 30361)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron_s", typeof(GameObject));
										if (277142 - 435937 == -158794)
										{
											continue;
										}
									}
									else if (a == "p_lms")
									{
										if (266554 - 588785 != -322231)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMupo_s", typeof(GameObject));
										if (21457 - 216895 != -195438)
										{
											continue;
										}
									}
									else if (a == "p_lps")
									{
										if (297946 - 352105 == -54158)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePeppon_s", typeof(GameObject));
										if (91764 - 178115 != -86351)
										{
											continue;
										}
									}
									else if (a == "p_lck")
									{
										if (224665 - 306156 == -81490)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarronCake", typeof(GameObject));
										if (177762 - 339895 == -162132)
										{
											continue;
										}
									}
									else if (a == "p_lpd")
									{
										if (57541 - 77060 == -19518)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePepponDisco", typeof(GameObject));
										if (153338 - 233067 != -79729)
										{
											continue;
										}
									}
									else if (a == "p_lmc")
									{
										if (275075 - 379908 == -104832)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadCarron", typeof(GameObject));
										if (213131 - 317376 == -104244)
										{
											continue;
										}
									}
									else if (a == "p_lmn")
									{
										if (199730 - 535145 != -335415)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadPeppon", typeof(GameObject));
										if (164440 - 210357 == -45916)
										{
											continue;
										}
									}
									else if (a == "p_lmo")
									{
										if (229633 - 512671 == -283037)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadCocon", typeof(GameObject));
										if (146623 - 71844 != 74779)
										{
											continue;
										}
									}
									else if (a == "p_ldc")
									{
										if (84206 - 472861 == -388654)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCarron", typeof(GameObject));
										if (274074 - 278000 != -3926)
										{
											continue;
										}
									}
									else if (a == "p_ldm")
									{
										if (137545 - 373327 != -235782)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadMupo", typeof(GameObject));
										if (247796 - 216752 == 31045)
										{
											continue;
										}
									}
									else if (a == "p_ldp")
									{
										if (110792 - 44279 != 66513)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadPeppon", typeof(GameObject));
										if (173276 - 348811 != -175535)
										{
											continue;
										}
									}
									else if (a == "p_ldt")
									{
										if (269619 - 345885 != -76266)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCacton", typeof(GameObject));
										if (212497 - 474037 != -261540)
										{
											continue;
										}
									}
									else if (a == "p_ldn")
									{
										if (156175 - 348498 != -192323)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCocon", typeof(GameObject));
										if (251989 - 288202 == -36212)
										{
											continue;
										}
									}
									else if (a == "p_ldk")
									{
										if (290722 - 262251 == 28472)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadPumpkon", typeof(GameObject));
										if (58440 - 233082 != -174642)
										{
											continue;
										}
									}
									else if (a == "p_srp")
									{
										if (274097 - 105625 == 168473)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallRedPanda", typeof(GameObject));
										if (109423 - 358596 != -249173)
										{
											continue;
										}
									}
									else if (a == "p_sss")
									{
										if (104259 - 587439 == -483179)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallSantaSkunk", typeof(GameObject));
										if (107821 - 438714 == -330892)
										{
											continue;
										}
									}
									else if (a == "p_sbb")
									{
										if (31118 - 202374 == -171255)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallBarrelBot", typeof(GameObject));
										if (51661 - 168260 != -116599)
										{
											continue;
										}
									}
									else if (a == "p_sdm")
									{
										if (246946 - 195021 != 51925)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallDemion", typeof(GameObject));
										if (244572 - 488055 == -243482)
										{
											continue;
										}
									}
									else if (a == "p_sdv")
									{
										if (13156 - 164816 == -151659)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallDoov", typeof(GameObject));
										if (207784 - 252101 == -44316)
										{
											continue;
										}
									}
									else if (a == "p_skz")
									{
										if (121024 - 407839 != -286815)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallKarazo", typeof(GameObject));
										if (6525 - 193900 == -187374)
										{
											continue;
										}
									}
									else if (a == "p_skm")
									{
										if (92980 - 450337 != -357357)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallKumo", typeof(GameObject));
										if (92283 - 449978 == -357694)
										{
											continue;
										}
									}
									else if (a == "p_skr")
									{
										if (53740 - 373954 == -320213)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_r", typeof(GameObject));
										if (39417 - 489993 != -450576)
										{
											continue;
										}
									}
									else if (a == "p_skg")
									{
										if (257718 - 556870 == -299151)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_g", typeof(GameObject));
										if (280442 - 261710 != 18732)
										{
											continue;
										}
									}
									else if (a == "p_sky")
									{
										if (113407 - 569682 == -456274)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_y", typeof(GameObject));
										if (208899 - 525728 != -316829)
										{
											continue;
										}
									}
									else if (a == "p_skb")
									{
										if (78639 - 539496 != -460857)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_b", typeof(GameObject));
										if (29122 - 305173 == -276050)
										{
											continue;
										}
									}
									else if (a == "p_skk")
									{
										if (155839 - 195549 == -39709)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_k", typeof(GameObject));
										if (156612 - 517028 == -360415)
										{
											continue;
										}
									}
									else if (a == "p_sfb")
									{
										if (187116 - 149237 != 37879)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallFlowerBug", typeof(GameObject));
										if (228320 - 146701 == 81620)
										{
											continue;
										}
									}
									else if (a == "p_sob")
									{
										if (227948 - 399180 == -171231)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallLionBug", typeof(GameObject));
										if (23506 - 579668 == -556161)
										{
											continue;
										}
									}
									else if (a == "p_sgb")
									{
										if (232563 - 400735 != -168172)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallGiantBug", typeof(GameObject));
										if (220643 - 506823 != -286180)
										{
											continue;
										}
									}
									else if (a == "p_slb")
									{
										if (266237 - 66109 != 200128)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallLeafBug", typeof(GameObject));
										if (198040 - 484466 == -286425)
										{
											continue;
										}
									}
									else if (a == "p_stb")
									{
										if (162822 - 502004 == -339181)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallFatBug", typeof(GameObject));
										if (244442 - 492263 != -247821)
										{
											continue;
										}
									}
									else if (a == "p_spb")
									{
										if (222903 - 500257 != -277354)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallPaperBug", typeof(GameObject));
										if (283209 - 598921 == -315711)
										{
											continue;
										}
									}
									else if (a == "p_swb")
									{
										if (281640 - 225461 != 56179)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallWormBug", typeof(GameObject));
										if (235296 - 346397 != -111101)
										{
											continue;
										}
									}
									else if (a == "p_ssq")
									{
										if (211907 - 124732 == 87176)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallStingQueen", typeof(GameObject));
										if (80863 - 260661 != -179798)
										{
											continue;
										}
									}
									else if (a == "p_snb")
									{
										if (228671 - 304653 != -75982)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNeonBug", typeof(GameObject));
										if (149465 - 403483 == -254017)
										{
											continue;
										}
									}
									else if (a == "p_sim")
									{
										if (218132 - 373129 != -154997)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallIceMixer", typeof(GameObject));
										if (51562 - 337312 == -285749)
										{
											continue;
										}
									}
									else if (a == "p_sam")
									{
										if (205029 - 290011 != -84982)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallAmmonite", typeof(GameObject));
										if (25856 - 44828 != -18972)
										{
											continue;
										}
									}
									else if (a == "p_sab")
									{
										if (265504 - 279808 != -14304)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallAnubi", typeof(GameObject));
										if (226969 - 379432 == -152462)
										{
											continue;
										}
									}
									else if (a == "p_spg")
									{
										if (140093 - 467435 != -327342)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallIcePenguin", typeof(GameObject));
										if (66395 - 38493 == 27903)
										{
											continue;
										}
									}
									else if (a == "p_spf")
									{
										if (230016 - 447027 == -217010)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallPirateFish", typeof(GameObject));
										if (14615 - 578262 != -563647)
										{
											continue;
										}
									}
									else if (a == "p_msb")
									{
										if (167916 - 161138 != 6778)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniSkyBug", typeof(GameObject));
										if (194715 - 239242 == -44526)
										{
											continue;
										}
									}
									else if (a == "p_mcb")
									{
										if (238142 - 108870 == 129273)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniCrystalBug", typeof(GameObject));
										if (252372 - 401369 != -148997)
										{
											continue;
										}
									}
									else if (a == "p_mab")
									{
										if (133184 - 287842 == -154657)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniAncientBug", typeof(GameObject));
										if (42332 - 228935 != -186603)
										{
											continue;
										}
									}
									else if (a == "p_mrb")
									{
										if (117610 - 442076 != -324466)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniReefBug", typeof(GameObject));
										if (29292 - 370765 != -341473)
										{
											continue;
										}
									}
									else if (a == "p_mmb")
									{
										if (269363 - 11173 != 258190)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniMokBug", typeof(GameObject));
										if (193948 - 363456 == -169507)
										{
											continue;
										}
									}
									else if (a == "p_mgb")
									{
										if (163718 - 99194 != 64524)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniGoldenBug", typeof(GameObject));
										if (133232 - 218180 == -84947)
										{
											continue;
										}
									}
									else if (a == "p_mnb")
									{
										if (61212 - 481084 != -419872)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniNemesisBug", typeof(GameObject));
										if (77571 - 356235 == -278663)
										{
											continue;
										}
									}
									num = Stringf.getLastDigit(nPet);
									if (152975 - 186871 == -33895)
									{
										continue;
									}
									if (num < 0)
									{
										if (274609 - 92759 == 181851)
										{
											continue;
										}
										num = 1;
										if (118991 - 85187 != 33804)
										{
											continue;
										}
									}
								}
								if (gameObject)
								{
									if (49720 - 73451 != -23731)
									{
										continue;
									}
									this.OlZAF9O2KQ = (GameObject)UnityEngine.Object.Instantiate(gameObject, this.transform.position - this.transform.forward, this.transform.rotation);
									if (121508 - 76132 != 45376)
									{
										continue;
									}
									if (this.OlZAF9O2KQ)
									{
										if (218768 - 383320 != -164552)
										{
											continue;
										}
										this.OlZAF9O2KQ.transform.localScale = ((float)num * 0.1f + 0.9f) * Vector3.one;
										if (189519 - 259729 == -70209)
										{
											continue;
										}
										PetControl petControl = (PetControl)this.OlZAF9O2KQ.GetComponent(typeof(PetControl));
										if (146952 - 47849 != 99103)
										{
											continue;
										}
										if (petControl)
										{
											if (59335 - 295537 != -236202)
											{
												continue;
											}
											petControl.Init(this.gameObject, num);
											if (116004 - 153950 == -37945)
											{
												continue;
											}
										}
										if (this.WmnA82hbGK)
										{
											if (187503 - 108386 != 79117)
											{
												continue;
											}
											this.WmnA82hbGK.mPet = this.OlZAF9O2KQ;
											if (178933 - 144883 == 34051)
											{
												continue;
											}
										}
									}
								}
								if (!this.WmnA82hbGK)
								{
									break;
								}
								if (120134 - 289754 == -169620)
								{
									this.WmnA82hbGK.pet = nPet;
									if (193339 - 518048 == -324709)
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

	// Token: 0x06003879 RID: 14457 RVA: 0x0076D328 File Offset: 0x0076B528
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600387A RID: 14458 RVA: 0x0076D32C File Offset: 0x0076B52C
	internal static bool Cfwi7i5omg10VqmW14Ow()
	{
		return true;
	}

	// Token: 0x0600387B RID: 14459 RVA: 0x0076D330 File Offset: 0x0076B530
	internal static bool NtUuKN5oFNcejAjoFMAP()
	{
		return false;
	}

	// Token: 0x04004728 RID: 18216
	private CharacterControl WmnA82hbGK;

	// Token: 0x04004729 RID: 18217
	public string weapon;

	// Token: 0x0400472A RID: 18218
	public string armor;

	// Token: 0x0400472B RID: 18219
	public string accessory;

	// Token: 0x0400472C RID: 18220
	public string boot;

	// Token: 0x0400472D RID: 18221
	public string trinket;

	// Token: 0x0400472E RID: 18222
	public string pet;

	// Token: 0x0400472F RID: 18223
	public int skin;

	// Token: 0x04004730 RID: 18224
	public bool equipOnStart;

	// Token: 0x04004731 RID: 18225
	private GameObject U6sAifXXBs;

	// Token: 0x04004732 RID: 18226
	private GameObject NEZADnMHs1;

	// Token: 0x04004733 RID: 18227
	private GameObject rRgAme96rv;

	// Token: 0x04004734 RID: 18228
	private GameObject HnEAjPTOPr;

	// Token: 0x04004735 RID: 18229
	private GameObject iSEAoSOxyj;

	// Token: 0x04004736 RID: 18230
	private GameObject H3ZAkyppMf;

	// Token: 0x04004737 RID: 18231
	private GameObject OlZAF9O2KQ;
}
