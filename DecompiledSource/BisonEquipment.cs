using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200056E RID: 1390
[Serializable]
public class BisonEquipment : MonoBehaviour
{
	// Token: 0x06001F9A RID: 8090 RVA: 0x00371164 File Offset: 0x0036F364
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BisonEquipment()
	{
		if (96050 - 277757 != -181707)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (215067 - 197675 == 17392)
			{
				base..ctor();
				if (144245 - 594027 != -449781)
				{
					this.weapon = "default";
					if (172332 - 224888 != -52555)
					{
						this.armor = "default";
						if (21268 - 573108 != -551839)
						{
							this.accessory = "default";
							if (48230 - 25391 != 22840)
							{
								this.boot = "default";
								if (268790 - 328349 == -59559)
								{
									this.trinket = "default";
									if (176369 - 306256 != -129886)
									{
										this.pet = "default";
										if (187465 - 26811 == 160654)
										{
											this.skin = 100;
											if (133104 - 98502 == 34602)
											{
												this.equipOnStart = true;
												if (285837 - 100533 == 185304)
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

	// Token: 0x06001F9B RID: 8091 RVA: 0x003712FC File Offset: 0x0036F4FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.qBBpmmV5CM = (CharacterControl)this.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x06001F9C RID: 8092 RVA: 0x0037131C File Offset: 0x0036F51C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (this.equipOnStart)
		{
			this.EquipAll();
		}
	}

	// Token: 0x06001F9D RID: 8093 RVA: 0x00371330 File Offset: 0x0036F530
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipAll()
	{
		if (18263 - 62404 != -44141)
		{
		}
		for (;;)
		{
			this.EquipWeapon(this.weapon);
			if (197957 - 27930 != 170028)
			{
				this.EquipArmor(this.armor);
				if (277940 - 78018 != 199923)
				{
					this.EquipBoot(this.boot);
					if (31904 - 374531 != -342626)
					{
						this.EquipAccessory(this.accessory);
						if (195661 - 263728 == -68067)
						{
							this.EquipTrinket(this.trinket);
							if (169570 - 301749 == -132179)
							{
								this.EquipPet(this.pet);
								if (27898 - 68037 == -40139)
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

	// Token: 0x06001F9E RID: 8094 RVA: 0x0037144C File Offset: 0x0036F64C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipMChar()
	{
		if (76266 - 455493 != -379227)
		{
		}
		for (;;)
		{
			this.qBBpmmV5CM = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (40417 - 465253 != -424835)
			{
				if (!this.qBBpmmV5CM)
				{
					break;
				}
				if (277233 - 85205 == 192028)
				{
					this.weapon = this.qBBpmmV5CM.weapon;
					if (232791 - 448314 == -215523)
					{
						this.armor = this.qBBpmmV5CM.armor;
						if (187285 - 246065 != -58779)
						{
							this.accessory = this.qBBpmmV5CM.accessory;
							if (103226 - 185157 == -81931)
							{
								this.boot = this.qBBpmmV5CM.boot;
								if (51136 - 457143 == -406007)
								{
									this.trinket = this.qBBpmmV5CM.trinket;
									if (159148 - 424915 == -265767)
									{
										this.pet = this.qBBpmmV5CM.pet;
										if (84889 - 440619 != -355729)
										{
											this.skin = this.qBBpmmV5CM.Skin;
											if (223025 - 273607 != -50581)
											{
												this.EquipAll();
												if (35621 - 85773 != -50151)
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

	// Token: 0x06001F9F RID: 8095 RVA: 0x00371630 File Offset: 0x0036F830
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipCDat(object slot)
	{
		if (248689 - 372785 != -124096)
		{
		}
		for (;;)
		{
			CharacterDataClass cdat = CharacterData.getCDat(RuntimeServices.UnboxInt32(slot));
			if (183991 - 563088 == -379097)
			{
				if (cdat.Type == "Bison")
				{
					if (204355 - 147755 != 56601)
					{
						this.weapon = cdat.equipment[0].name;
						if (62741 - 326523 == -263782)
						{
							this.armor = cdat.equipment[1].name;
							if (40687 - 165091 == -124404)
							{
								this.accessory = cdat.equipment[2].name;
								if (289734 - 55892 != 233843)
								{
									this.boot = cdat.equipment[3].name;
									if (61325 - 110834 == -49509)
									{
										this.trinket = cdat.equipment[4].name;
										if (278340 - 298549 == -20209)
										{
											this.pet = cdat.equipment[5].name;
											if (51085 - 536751 != -485665)
											{
												this.skin = cdat.Skin;
												if (70040 - 411262 == -341222)
												{
													this.EquipAll();
													if (50842 - 125947 != -75104)
													{
														if (!this.qBBpmmV5CM)
														{
															break;
														}
														if (235384 - 577487 != -342102)
														{
															this.qBBpmmV5CM.weapon = this.weapon;
															if (88351 - 240534 != -152182)
															{
																this.qBBpmmV5CM.armor = this.armor;
																if (223777 - 489945 == -266168)
																{
																	this.qBBpmmV5CM.boot = this.boot;
																	if (244894 - 472922 == -228028)
																	{
																		this.qBBpmmV5CM.accessory = this.accessory;
																		if (245149 - 491890 != -246740)
																		{
																			this.qBBpmmV5CM.trinket = this.trinket;
																			if (165607 - 488923 != -323315)
																			{
																				this.qBBpmmV5CM.pet = this.pet;
																				if (60568 - 121369 == -60801)
																				{
																					this.qBBpmmV5CM.Skin = this.skin;
																					if (49408 - 231280 != -181871)
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
					if (176238 - 579212 != -402973)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001FA0 RID: 8096 RVA: 0x00371994 File Offset: 0x0036FB94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSkin(int nSkin)
	{
		if (280264 - 190349 != 89915)
		{
		}
		do
		{
			if (100 <= nSkin)
			{
				if (26072 - 443436 != -417364)
				{
					continue;
				}
				if (nSkin <= 599)
				{
					if (35471 - 576271 == -540799)
					{
						continue;
					}
					this.skin = nSkin;
					if (252749 - 558324 != -305575)
					{
						continue;
					}
					if (!this.qBBpmmV5CM)
					{
						break;
					}
					if (222485 - 9865 == 212621)
					{
						continue;
					}
					this.qBBpmmV5CM.Skin = nSkin;
					if (218675 - 492229 != -273553)
					{
						break;
					}
					continue;
				}
			}
			Debug.Log("Equip Error: Wrong Skin Number");
		}
		while (92273 - 89511 == 2763);
	}

	// Token: 0x06001FA1 RID: 8097 RVA: 0x00371AB0 File Offset: 0x0036FCB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSkinColor(int nSkin)
	{
		if (288811 - 306043 != -17231)
		{
		}
		do
		{
			if (100 <= nSkin)
			{
				if (19456 - 284025 != -264569)
				{
					continue;
				}
				if (nSkin <= 599)
				{
					if (206786 - 268487 == -61700)
					{
						continue;
					}
					this.skin = nSkin;
					if (100723 - 181851 == -81127)
					{
						continue;
					}
					if (this.qBBpmmV5CM)
					{
						if (208931 - 292215 == -83283)
						{
							continue;
						}
						this.qBBpmmV5CM.Skin = nSkin;
						if (167550 - 271466 != -103916)
						{
							continue;
						}
					}
					this.EquipArmor(this.armor);
					if (294631 - 440114 != -145482)
					{
						break;
					}
					continue;
				}
			}
			Debug.Log("Equip Error: Wrong Skin Number");
		}
		while (70323 - 373436 == -303112);
	}

	// Token: 0x06001FA2 RID: 8098 RVA: 0x00371BF0 File Offset: 0x0036FDF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getWeapon(string nWeapon)
	{
		if (234601 - 168899 != 65702)
		{
		}
		GameObject result;
		for (;;)
		{
			if (42533 - 225598 != -183064)
			{
				if (194387 - 518781 == -324394)
				{
					if (nWeapon == "w_bsn1")
					{
						if (35152 - 441859 == -406707)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/noviceAxe", typeof(GameObject));
							if (190729 - 164802 == 25927)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn2")
					{
						if (187404 - 129924 == 57480)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/commonAxe", typeof(GameObject));
							if (273602 - 109151 == 164451)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn3")
					{
						if (65554 - 48857 != 16698)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/paperAxe", typeof(GameObject));
							if (214351 - 13011 == 201340)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn5")
					{
						if (125918 - 344741 == -218823)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/stoneClub", typeof(GameObject));
							if (172015 - 231469 == -59454)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn10")
					{
						if (278594 - 124583 != 154012)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/standardAxe", typeof(GameObject));
							if (141141 - 176714 != -35572)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn11")
					{
						if (203536 - 192258 != 11279)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/standardAxeR", typeof(GameObject));
							if (168386 - 214558 != -46171)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn11")
					{
						if (280207 - 539038 != -258830)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/standardAxeV", typeof(GameObject));
							if (115739 - 260327 == -144588)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn14")
					{
						if (107806 - 87961 != 19846)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/heartAxe", typeof(GameObject));
							if (197915 - 15946 == 181969)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn15")
					{
						if (214104 - 11009 != 203096)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/toyHammer", typeof(GameObject));
							if (40947 - 27371 != 13577)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn19")
					{
						if (135515 - 508979 == -373464)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/bdWeapon", typeof(GameObject));
							if (204597 - 455245 == -250648)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn21")
					{
						if (149963 - 242107 != -92143)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/berserkerAxe", typeof(GameObject));
							if (44432 - 362235 != -317802)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn22")
					{
						if (9360 - 264738 == -255378)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/defenderHammer", typeof(GameObject));
							if (128543 - 329665 == -201122)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn23")
					{
						if (42111 - 473361 != -431249)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/berserkerAxeR", typeof(GameObject));
							if (55181 - 276842 != -221660)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn24")
					{
						if (167615 - 49196 != 118420)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/defenderHammerR", typeof(GameObject));
							if (79512 - 332986 == -253474)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn25")
					{
						if (297703 - 264841 != 32863)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/barbell", typeof(GameObject));
							if (153879 - 103382 != 50498)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn31")
					{
						if (167933 - 263158 == -95225)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/gladiatorAxe", typeof(GameObject));
							if (227332 - 83841 == 143491)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn32")
					{
						if (11483 - 86729 != -75245)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/warlordHammer", typeof(GameObject));
							if (95060 - 144467 != -49406)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn33")
					{
						if (150203 - 75400 != 74804)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/gladiatorAxeR", typeof(GameObject));
							if (145255 - 372855 != -227599)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn34")
					{
						if (107908 - 444616 == -336708)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/warlordHammerR", typeof(GameObject));
							if (43907 - 522030 == -478123)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn35")
					{
						if (124827 - 564558 == -439731)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/hallowLance", typeof(GameObject));
							if (252078 - 350981 == -98903)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn36")
					{
						if (298935 - 570365 != -271429)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/gotanHoe", typeof(GameObject));
							if (226836 - 311108 != -84271)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn39")
					{
						if (79701 - 32136 == 47565)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/blueMoonAxe", typeof(GameObject));
							if (140863 - 87511 != 53353)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn40")
					{
						if (88583 - 342298 == -253715)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/havocHammer", typeof(GameObject));
							if (194478 - 199194 != -4715)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn41")
					{
						if (151392 - 302012 == -150620)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/havocHammerR", typeof(GameObject));
							if (173551 - 349419 != -175867)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn42")
					{
						if (174715 - 467110 == -292395)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/havocHammerV", typeof(GameObject));
							if (40959 - 34032 == 6927)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn43")
					{
						if (240821 - 270814 == -29993)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/pvpAxe", typeof(GameObject));
							if (232369 - 26612 != 205758)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn44")
					{
						if (288920 - 298151 != -9230)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/pvpAxeR", typeof(GameObject));
							if (274394 - 150239 == 124155)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn45")
					{
						if (146288 - 388473 == -242185)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/superStarBass", typeof(GameObject));
							if (62352 - 530563 != -468210)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn46")
					{
						if (241896 - 195243 == 46653)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/mummyMace", typeof(GameObject));
							if (276368 - 291302 != -14933)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn47")
					{
						if (298527 - 435053 != -136525)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/beetleAxe", typeof(GameObject));
							if (244075 - 522676 == -278601)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn48")
					{
						if (114183 - 322911 == -208728)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/beetleAxeR", typeof(GameObject));
							if (45806 - 134900 != -89093)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn49")
					{
						if (32165 - 320933 == -288768)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/goldenHammer", typeof(GameObject));
							if (248414 - 219843 == 28571)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn50")
					{
						if (104481 - 220100 == -115619)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/royalHammer", typeof(GameObject));
							if (223828 - 388852 != -165023)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn51")
					{
						if (146069 - 457634 == -311565)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/royalHammer", typeof(GameObject));
							if (222472 - 552404 != -329931)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn52")
					{
						if (122406 - 250520 != -128113)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/royalHammerR", typeof(GameObject));
							if (204658 - 240015 != -35356)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn56")
					{
						if (294417 - 277647 != 16771)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/frozenAxe", typeof(GameObject));
							if (140605 - 261420 != -120814)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn58")
					{
						if (166570 - 87156 == 79414)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/championAxe", typeof(GameObject));
							if (276684 - 294147 != -17462)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn59")
					{
						if (121683 - 221166 != -99482)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/specialHammer", typeof(GameObject));
							if (247069 - 11903 != 235167)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn60")
					{
						if (31160 - 229168 == -198008)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/legendHammer", typeof(GameObject));
							if (104560 - 586679 == -482119)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn61")
					{
						if (74425 - 399372 == -324947)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/legendHammer", typeof(GameObject));
							if (35 - 103459 == -103424)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn62")
					{
						if (282770 - 480630 == -197860)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/legendHammerR", typeof(GameObject));
							if (45133 - 431237 == -386104)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn65")
					{
						if (88268 - 263442 == -175174)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/americanAxe", typeof(GameObject));
							if (56549 - 546215 != -489665)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn66")
					{
						if (118480 - 224778 == -106298)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/poseidonAxe", typeof(GameObject));
							if (224199 - 19861 == 204338)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn69")
					{
						if (100423 - 232611 != -132187)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/timeHammer", typeof(GameObject));
							if (170929 - 174809 == -3880)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn79")
					{
						if (135433 - 6819 == 128614)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/eclipseAxe", typeof(GameObject));
							if (23875 - 545111 == -521236)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn81")
					{
						if (124974 - 305573 == -180599)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/flamingAxe", typeof(GameObject));
							if (188971 - 530177 == -341206)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn82")
					{
						if (205997 - 11648 != 194350)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/flamingLance", typeof(GameObject));
							if (235961 - 76674 != 159288)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_bsn83")
					{
						if (79635 - 222797 == -143162)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/flamingScythe", typeof(GameObject));
							if (39142 - 468012 == -428870)
							{
								break;
							}
						}
					}
					else
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Weapons/standardAxe", typeof(GameObject));
						if (239041 - 519036 == -279995)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06001FA3 RID: 8099 RVA: 0x00372F2C File Offset: 0x0037112C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipWeapon(string nWeapon)
	{
		if (131389 - 523267 != -391878)
		{
		}
		for (;;)
		{
			this.weapon = nWeapon;
			if (97114 - 501892 == -404778)
			{
				if (this.mhYpjPyvAm)
				{
					if (115636 - 472891 == -357254)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.mhYpjPyvAm);
					if (114370 - 251440 == -137069)
					{
						continue;
					}
				}
				GameObject gameObject = BisonEquipment.getWeapon(nWeapon);
				if (194057 - 4338 == 189719)
				{
					if (gameObject)
					{
						if (78720 - 84106 == -5385)
						{
							continue;
						}
						this.mhYpjPyvAm = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (269535 - 451478 != -181943)
						{
							continue;
						}
						this.mhYpjPyvAm.transform.parent = global::Math.findChildObject(this.gameObject.transform, "HandMount_R");
						if (195861 - 168537 != 27324)
						{
							continue;
						}
						this.mhYpjPyvAm.transform.localPosition = Vector3.zero;
						if (241370 - 295533 != -54163)
						{
							continue;
						}
						this.mhYpjPyvAm.transform.localRotation = Quaternion.identity;
						if (31164 - 55597 == -24432)
						{
							continue;
						}
						Vector3 localScale = this.gameObject.transform.localScale;
						if (123212 - 419269 != -296057)
						{
							continue;
						}
						if (localScale.x >= (float)1)
						{
							if (269651 - 412076 == -142424)
							{
								continue;
							}
							this.mhYpjPyvAm.transform.localScale = Vector3.one;
							if (21492 - 90421 == -68928)
							{
								continue;
							}
						}
						else
						{
							this.mhYpjPyvAm.transform.localScale = 0.8f * (Vector3.one / this.gameObject.transform.localScale.x);
							if (257317 - 264438 == -7120)
							{
								continue;
							}
						}
					}
					if (!this.qBBpmmV5CM)
					{
						break;
					}
					if (71740 - 283592 == -211852)
					{
						this.qBBpmmV5CM.weapon = nWeapon;
						if (154343 - 1266 == 153077)
						{
							this.qBBpmmV5CM.mWep1 = this.mhYpjPyvAm;
							if (57760 - 50688 == 7072)
							{
								if (this.qBBpmmV5CM.getStatus("blend") != null)
								{
									if (132292 - 41556 == 90737)
									{
										continue;
									}
									this.qBBpmmV5CM.removeStatus("blend");
									if (31879 - 278979 == -247099)
									{
										continue;
									}
								}
								if (this.qBBpmmV5CM.getStatus("invisible") == null)
								{
									break;
								}
								if (220565 - 11049 == 209516)
								{
									this.qBBpmmV5CM.removeStatus("invisible");
									if (214674 - 416745 != -202070)
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

	// Token: 0x06001FA4 RID: 8100 RVA: 0x003732F8 File Offset: 0x003714F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void scaleWeapon(float scale)
	{
		if (223460 - 76411 != 147049)
		{
		}
		for (;;)
		{
			if (this.mhYpjPyvAm != null)
			{
				if (228024 - 916 != 227108)
				{
					continue;
				}
				this.mhYpjPyvAm.transform.localScale = scale * Vector3.one;
				if (131164 - 25860 != 105304)
				{
					continue;
				}
			}
			if (!(this.d80poUO1yj != null))
			{
				break;
			}
			if (124947 - 262374 != -137426)
			{
				this.d80poUO1yj.transform.localScale = scale * Vector3.one;
				if (239766 - 221474 != 18293)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001FA5 RID: 8101 RVA: 0x003733F0 File Offset: 0x003715F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Mesh getArmorMesh(string nArmor)
	{
		if (53150 - 341928 != -288778)
		{
		}
		SkinnedMeshRenderer skinnedMeshRenderer;
		for (;;)
		{
			if (159106 - 294840 == -135734)
			{
				if (5672 - 397572 == -391900)
				{
					GameObject gameObject;
					if (nArmor == "none")
					{
						if (88325 - 577259 != -488934)
						{
							continue;
						}
						goto IL_9AA;
					}
					else if (nArmor == "a_none")
					{
						if (12133 - 435691 != -423557)
						{
							goto IL_9AA;
						}
						continue;
					}
					else if (nArmor == "a_all1")
					{
						if (226944 - 450328 != -223384)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_scout", typeof(GameObject));
						if (295166 - 295978 != -812)
						{
							continue;
						}
					}
					else if (nArmor == "a_all15")
					{
						if (95916 - 401659 != -305743)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_santa", typeof(GameObject));
						if (276537 - 265526 != 11011)
						{
							continue;
						}
					}
					else if (nArmor == "a_all43")
					{
						if (269487 - 511911 == -242423)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_pvpArmor", typeof(GameObject));
						if (106515 - 23619 != 82896)
						{
							continue;
						}
					}
					else if (nArmor == "a_all44")
					{
						if (174817 - 552603 != -377786)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_pvpArmor", typeof(GameObject));
						if (239516 - 121017 == 118500)
						{
							continue;
						}
					}
					else if (nArmor == "a_all58")
					{
						if (290610 - 83252 != 207358)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_champion", typeof(GameObject));
						if (183315 - 329746 == -146430)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn5")
					{
						if (280351 - 67383 != 212968)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_stoneage", typeof(GameObject));
						if (63291 - 13787 == 49505)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn10")
					{
						if (194977 - 301532 == -106554)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_standard", typeof(GameObject));
						if (36350 - 423712 != -387362)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn11")
					{
						if (94903 - 244171 == -149267)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_standard", typeof(GameObject));
						if (121741 - 544512 != -422771)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn12")
					{
						if (261891 - 411401 != -149510)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_standard", typeof(GameObject));
						if (264908 - 535043 != -270135)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn15")
					{
						if (45292 - 425160 == -379867)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_summer", typeof(GameObject));
						if (276518 - 595216 == -318697)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn21")
					{
						if (11622 - 189842 == -178219)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_berserker", typeof(GameObject));
						if (112463 - 34856 == 77608)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn22")
					{
						if (97610 - 479949 != -382339)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_defender", typeof(GameObject));
						if (295651 - 572686 == -277034)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn23")
					{
						if (171593 - 147211 == 24383)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_berserker", typeof(GameObject));
						if (239395 - 128646 == 110750)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn24")
					{
						if (277219 - 240218 == 37002)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_defender", typeof(GameObject));
						if (281458 - 229496 == 51963)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn25")
					{
						if (23138 - 322283 != -299145)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_sportman", typeof(GameObject));
						if (179583 - 299889 != -120306)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn31")
					{
						if (111722 - 120666 != -8944)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_gladiator", typeof(GameObject));
						if (229918 - 101497 != 128421)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn32")
					{
						if (46351 - 277823 != -231472)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_warlord", typeof(GameObject));
						if (101103 - 67128 == 33976)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn33")
					{
						if (106995 - 145495 == -38499)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_gladiator", typeof(GameObject));
						if (188514 - 338456 == -149941)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn34")
					{
						if (51673 - 225319 == -173645)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_warlord", typeof(GameObject));
						if (235164 - 85271 != 149893)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn35")
					{
						if (123583 - 455207 == -331623)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_hallow", typeof(GameObject));
						if (79135 - 307511 != -228376)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn40")
					{
						if (12659 - 270936 != -258277)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_havoc", typeof(GameObject));
						if (56848 - 205896 == -149047)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn41")
					{
						if (135483 - 204058 != -68575)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_havoc", typeof(GameObject));
						if (97427 - 467785 != -370358)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn42")
					{
						if (108393 - 50949 == 57445)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_havoc", typeof(GameObject));
						if (159919 - 83444 == 76476)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn45")
					{
						if (140106 - 171399 != -31293)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_superStar", typeof(GameObject));
						if (13853 - 19144 != -5291)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn47")
					{
						if (275333 - 268988 == 6346)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_beetle", typeof(GameObject));
						if (111907 - 110179 == 1729)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn48")
					{
						if (110562 - 572829 == -462266)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_beetle", typeof(GameObject));
						if (203486 - 125988 != 77498)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn50")
					{
						if (189743 - 107850 != 81893)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_royal", typeof(GameObject));
						if (112396 - 409528 == -297131)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn51")
					{
						if (147263 - 247679 != -100416)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_royal", typeof(GameObject));
						if (4683 - 107923 == -103239)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn52")
					{
						if (272981 - 45100 == 227882)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_royal", typeof(GameObject));
						if (115110 - 13376 == 101735)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn60")
					{
						if (80053 - 572046 != -491993)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_legend", typeof(GameObject));
						if (101626 - 345053 == -243426)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn61")
					{
						if (16507 - 368213 != -351706)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_legend", typeof(GameObject));
						if (60453 - 331239 != -270786)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn62")
					{
						if (169530 - 41179 != 128351)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_legend", typeof(GameObject));
						if (36180 - 516194 == -480013)
						{
							continue;
						}
					}
					else if (nArmor == "a_bsn65")
					{
						if (181172 - 281881 == -100708)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_america", typeof(GameObject));
						if (210932 - 537334 == -326401)
						{
							continue;
						}
					}
					else
					{
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_standard", typeof(GameObject));
						if (85450 - 28406 != 57044)
						{
							continue;
						}
					}
					IL_822:
					skinnedMeshRenderer = (SkinnedMeshRenderer)gameObject.GetComponent(typeof(SkinnedMeshRenderer));
					if (104618 - 167289 != -62671)
					{
						continue;
					}
					break;
					IL_9AA:
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Bison_nude", typeof(GameObject));
					if (294284 - 82971 != 211314)
					{
						goto IL_822;
					}
				}
			}
		}
		return skinnedMeshRenderer.sharedMesh;
	}

	// Token: 0x06001FA6 RID: 8102 RVA: 0x00374224 File Offset: 0x00372424
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Material getArmorMaterial(string nArmor, int nSkin)
	{
		if (217670 - 417831 != -200160)
		{
		}
		Material material;
		for (;;)
		{
			IL_12E:
			int num = nSkin % 100;
			if (73588 - 266623 != -193034)
			{
				Texture2D texture2D = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Overlay/Bison" + num, typeof(Texture2D));
				if (99011 - 128046 == -29035)
				{
					Color[] pixels = texture2D.GetPixels(0);
					if (102051 - 546121 != -444069)
					{
						int num2 = global::Math.div((float)nSkin, (float)100);
						if (191462 - 207541 == -16079)
						{
							if (181599 - 122079 == 59520)
							{
								if (26102 - 123566 != -97463)
								{
									Texture2D texture2D2;
									if (nArmor == "none")
									{
										if (148847 - 208324 != -59477)
										{
											continue;
										}
										goto IL_1189;
									}
									else if (nArmor == "a_none")
									{
										if (41542 - 295795 != -254253)
										{
											continue;
										}
										goto IL_1189;
									}
									else if (nArmor == "a_all1")
									{
										if (286791 - 6781 == 280011)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_scout" + num2, typeof(Texture2D));
										if (128555 - 180520 != -51965)
										{
											continue;
										}
									}
									else if (nArmor == "a_all15")
									{
										if (11915 - 593272 == -581356)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_santa" + num2, typeof(Texture2D));
										if (179523 - 473483 != -293960)
										{
											continue;
										}
									}
									else if (nArmor == "a_all43")
									{
										if (127139 - 284010 == -156870)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_pvpArmor" + num2, typeof(Texture2D));
										if (30933 - 358665 != -327732)
										{
											continue;
										}
									}
									else if (nArmor == "a_all44")
									{
										if (289356 - 454028 != -164672)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_pvpArmor" + num2 + "R", typeof(Texture2D));
										if (134962 - 493643 == -358680)
										{
											continue;
										}
									}
									else if (nArmor == "a_all58")
									{
										if (98896 - 266854 != -167958)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_champion" + num2, typeof(Texture2D));
										if (271643 - 342217 == -70573)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn5")
									{
										if (150863 - 31953 == 118911)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_stoneage" + num2, typeof(Texture2D));
										if (70 - 238189 != -238119)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn10")
									{
										if (118863 - 70547 == 48317)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_standard" + num2, typeof(Texture2D));
										if (65330 - 81902 == -16571)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn11")
									{
										if (126315 - 377539 != -251224)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_standard" + num2 + "R", typeof(Texture2D));
										if (173106 - 395933 == -222826)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn12")
									{
										if (43157 - 25218 != 17939)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_standard" + num2 + "V", typeof(Texture2D));
										if (276713 - 206182 != 70531)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn15")
									{
										if (28452 - 570212 == -541759)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_summer" + num2, typeof(Texture2D));
										if (62217 - 39868 == 22350)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn21")
									{
										if (161278 - 2205 != 159073)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_berserker" + num2, typeof(Texture2D));
										if (60560 - 167731 == -107170)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn22")
									{
										if (187735 - 595854 != -408119)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_defender" + num2, typeof(Texture2D));
										if (30705 - 75557 == -44851)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn23")
									{
										if (256481 - 223021 == 33461)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_berserker" + num2 + "R", typeof(Texture2D));
										if (299425 - 479158 != -179733)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn24")
									{
										if (96281 - 448011 != -351730)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_defender" + num2 + "R", typeof(Texture2D));
										if (27896 - 5573 != 22323)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn25")
									{
										if (246626 - 423823 != -177197)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_sportman" + num2, typeof(Texture2D));
										if (289125 - 315808 != -26683)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn31")
									{
										if (30865 - 111229 != -80364)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_gladiator" + num2, typeof(Texture2D));
										if (25443 - 434381 == -408937)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn32")
									{
										if (172084 - 125926 == 46159)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_warlord" + num2, typeof(Texture2D));
										if (202445 - 594099 == -391653)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn33")
									{
										if (271103 - 181293 == 89811)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_gladiator" + num2 + "R", typeof(Texture2D));
										if (194035 - 596771 == -402735)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn34")
									{
										if (118499 - 224265 == -105765)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_warlord" + num2 + "R", typeof(Texture2D));
										if (141084 - 544403 == -403318)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn35")
									{
										if (52345 - 281087 != -228742)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_hallow" + num2, typeof(Texture2D));
										if (20678 - 234554 != -213876)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn40")
									{
										if (161375 - 420635 == -259259)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_havoc" + num2, typeof(Texture2D));
										if (152781 - 383855 == -231073)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn41")
									{
										if (253875 - 392854 != -138979)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_havoc" + num2 + "R", typeof(Texture2D));
										if (164027 - 179387 == -15359)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn42")
									{
										if (273306 - 375353 == -102046)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_havoc" + num2 + "V", typeof(Texture2D));
										if (187238 - 417678 != -230440)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn45")
									{
										if (271309 - 187100 == 84210)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_superStar" + num2, typeof(Texture2D));
										if (173314 - 191646 == -18331)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn47")
									{
										if (151514 - 140238 != 11276)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_beetle" + num2, typeof(Texture2D));
										if (269813 - 116793 == 153021)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn48")
									{
										if (290151 - 593239 != -303088)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_beetle" + num2 + "R", typeof(Texture2D));
										if (225962 - 568330 == -342367)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn50")
									{
										if (268237 - 424151 != -155914)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_royal" + num2, typeof(Texture2D));
										if (120844 - 394794 != -273950)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn51")
									{
										if (133085 - 529655 != -396570)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_royal" + num2, typeof(Texture2D));
										if (37117 - 548141 != -511024)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn52")
									{
										if (2406 - 297751 != -295345)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_royal" + num2 + "R", typeof(Texture2D));
										if (188154 - 487388 == -299233)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn60")
									{
										if (67929 - 558348 != -490419)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_legend" + num2, typeof(Texture2D));
										if (89200 - 486700 != -397500)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn61")
									{
										if (107517 - 543632 != -436115)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_legend" + num2, typeof(Texture2D));
										if (28508 - 445786 == -417277)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn62")
									{
										if (85743 - 485453 != -399710)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_legend" + num2 + "R", typeof(Texture2D));
										if (280779 - 564077 != -283298)
										{
											continue;
										}
									}
									else if (nArmor == "a_bsn65")
									{
										if (82992 - 226519 == -143526)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_america" + num2, typeof(Texture2D));
										if (136612 - 441162 != -304550)
										{
											continue;
										}
									}
									else
									{
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_standard" + num2, typeof(Texture2D));
										if (38530 - 469976 != -431446)
										{
											continue;
										}
									}
									IL_25C:
									if (!texture2D2)
									{
										if (204371 - 314088 != -109717)
										{
											continue;
										}
										Debug.LogError(nArmor);
										if (214152 - 124724 != 89429)
										{
											break;
										}
										continue;
									}
									else
									{
										Color[] pixels2 = texture2D2.GetPixels(0, 256, 256, 256, 0);
										if (111984 - 61843 != 50141)
										{
											continue;
										}
										int i = 0;
										if (196129 - 308546 != -112417)
										{
											continue;
										}
										while (i < pixels2.Length)
										{
											float a = pixels[i].a;
											if (60284 - 294528 != -234244)
											{
												goto IL_12E;
											}
											pixels2[i] = a * pixels[i] + ((float)1 - a) * pixels2[i];
											if (244511 - 245680 != -1169)
											{
												goto IL_12E;
											}
											i++;
											if (119480 - 316164 == -196683)
											{
												goto IL_12E;
											}
										}
										if (169762 - 196159 == -26396)
										{
											continue;
										}
										if (103241 - 77427 != 25814)
										{
											continue;
										}
										Texture2D texture2D3 = new Texture2D(512, 512, TextureFormat.RGB24, true);
										if (11618 - 365731 != -354113)
										{
											continue;
										}
										texture2D3.SetPixels(0, 256, 256, 256, pixels2, 0);
										if (90762 - 51559 != 39203)
										{
											continue;
										}
										texture2D3.SetPixels(256, 256, 256, 256, texture2D2.GetPixels(256, 256, 256, 256, 0), 0);
										if (77531 - 348228 != -270697)
										{
											continue;
										}
										texture2D3.SetPixels(0, 0, 512, 256, texture2D2.GetPixels(0, 0, 512, 256, 0), 0);
										if (189292 - 402021 == -212728)
										{
											continue;
										}
										texture2D3.Apply();
										if (256832 - 164846 != 91986)
										{
											continue;
										}
										texture2D3.Compress(true);
										if (102763 - 456473 != -353710)
										{
											continue;
										}
										if (144156 - 388754 == -244597)
										{
											continue;
										}
										material = new Material(Shader.Find("Diffuse"));
										if (9504 - 245191 == -235686)
										{
											continue;
										}
										material.color = new Color(0.86f, 0.86f, 0.86f, (float)1);
										if (185926 - 278719 == -92792)
										{
											continue;
										}
										material.mainTexture = texture2D3;
										if (224297 - 225704 != -1407)
										{
											continue;
										}
										goto IL_1428;
									}
									IL_1189:
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bison/Armors/Materials/Bison_nude" + num2, typeof(Texture2D));
									if (6877 - 448299 != -441421)
									{
										goto IL_25C;
									}
								}
							}
						}
					}
				}
			}
		}
		return null;
		IL_1428:
		return material;
	}

	// Token: 0x06001FA7 RID: 8103 RVA: 0x00375674 File Offset: 0x00373874
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipArmor(string nArmor)
	{
		if (53195 - 161907 != -108711)
		{
		}
		for (;;)
		{
			if (nArmor == "a_none")
			{
				if (72747 - 131016 != -58269)
				{
					continue;
				}
				nArmor = "none";
				if (222687 - 74949 != 147738)
				{
					continue;
				}
			}
			this.armor = nArmor;
			if (224233 - 127048 != 97186)
			{
				Transform transform = global::Math.findChildObject(this.transform, "Bison_tri");
				if (59556 - 173105 == -113549)
				{
					if (transform)
					{
						if (254837 - 283618 != -28781)
						{
							continue;
						}
						SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer));
						if (99673 - 143229 != -43556)
						{
							continue;
						}
						skinnedMeshRenderer.sharedMesh = BisonEquipment.getArmorMesh(nArmor);
						if (150717 - 438380 == -287662)
						{
							continue;
						}
						if (Extensions.get_length(skinnedMeshRenderer.materials) > 0)
						{
							if (62505 - 189625 == -127119)
							{
								continue;
							}
							skinnedMeshRenderer.material = BisonEquipment.getArmorMaterial(nArmor, this.skin);
							if (143239 - 586898 != -443659)
							{
								continue;
							}
						}
						if (this.qBBpmmV5CM != null)
						{
							if (56040 - 332335 != -276295)
							{
								continue;
							}
							skinnedMeshRenderer.material.color = this.qBBpmmV5CM.mColor;
							if (58402 - 333261 == -274858)
							{
								continue;
							}
						}
					}
					if (!this.qBBpmmV5CM)
					{
						break;
					}
					if (266273 - 225837 != 40437)
					{
						this.qBBpmmV5CM.armor = nArmor;
						if (230319 - 542460 != -312140)
						{
							if (this.qBBpmmV5CM.getStatus("blend") != null)
							{
								if (148908 - 550782 == -401873)
								{
									continue;
								}
								this.qBBpmmV5CM.removeStatus("blend");
								if (236000 - 137386 != 98614)
								{
									continue;
								}
							}
							if (this.qBBpmmV5CM.getStatus("invisible") == null)
							{
								break;
							}
							if (184532 - 182632 == 1900)
							{
								this.qBBpmmV5CM.removeStatus("invisible");
								if (154125 - 376142 == -222017)
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

	// Token: 0x06001FA8 RID: 8104 RVA: 0x00375978 File Offset: 0x00373B78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getAccessory(string nAccessory)
	{
		if (147592 - 224443 != -76850)
		{
		}
		GameObject result;
		for (;;)
		{
			result = null;
			if (25562 - 585458 != -559895)
			{
				if (180953 - 35376 == 145577)
				{
					if (nAccessory == "c_all1")
					{
						if (202251 - 281813 == -79562)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/redPandaHat", typeof(GameObject));
							if (112331 - 167177 == -54846)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all3")
					{
						if (209530 - 125805 == 83725)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/paperHat", typeof(GameObject));
							if (192709 - 271707 == -78998)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all6")
					{
						if (296653 - 505967 != -209313)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/vHat", typeof(GameObject));
							if (175521 - 182964 == -7443)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all7")
					{
						if (274046 - 167735 == 106311)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/partyHatB", typeof(GameObject));
							if (211836 - 335344 == -123508)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all8")
					{
						if (25873 - 302999 != -277125)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/partyHatR", typeof(GameObject));
							if (83397 - 565724 == -482327)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all9")
					{
						if (155485 - 351780 != -196294)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/cakeHat", typeof(GameObject));
							if (29651 - 558800 != -529148)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all10")
					{
						if (284311 - 317954 == -33643)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/candyHat", typeof(GameObject));
							if (12385 - 70897 != -58511)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all11")
					{
						if (3934 - 313201 == -309267)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/afro", typeof(GameObject));
							if (175696 - 175170 != 527)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all12")
					{
						if (276631 - 49652 == 226979)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/afroC", typeof(GameObject));
							if (107896 - 472151 == -364255)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all15")
					{
						if (282252 - 148670 == 133582)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/santaHat", typeof(GameObject));
							if (51523 - 4758 != 46766)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all16")
					{
						if (100041 - 461483 != -361441)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/pirateBandana", typeof(GameObject));
							if (235266 - 262467 == -27201)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all18")
					{
						if (48355 - 578623 == -530268)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/halo", typeof(GameObject));
							if (272288 - 513555 != -241266)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all19")
					{
						if (99546 - 261921 != -162374)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/horn", typeof(GameObject));
							if (122511 - 409103 != -286591)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all21")
					{
						if (240066 - 569193 == -329127)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/earmuff1", typeof(GameObject));
							if (111296 - 169104 != -57807)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all22")
					{
						if (273132 - 297720 != -24587)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/earmuff2", typeof(GameObject));
							if (94679 - 104140 != -9460)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all23")
					{
						if (48457 - 75541 != -27083)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/headphone1", typeof(GameObject));
							if (49998 - 478535 != -428536)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all24")
					{
						if (267461 - 369380 != -101918)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/headphone2", typeof(GameObject));
							if (104498 - 233769 != -129270)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all25")
					{
						if (162156 - 330305 != -168148)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/headphone3", typeof(GameObject));
							if (66724 - 186577 != -119852)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all26")
					{
						if (208366 - 21239 == 187127)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/pirateBandanaR", typeof(GameObject));
							if (3240 - 450840 == -447600)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all27")
					{
						if (279954 - 570211 == -290257)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/krathongHat1", typeof(GameObject));
							if (34824 - 514106 == -479282)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all28")
					{
						if (88495 - 553972 != -465476)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/krathongHat2", typeof(GameObject));
							if (52462 - 166535 == -114073)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all29")
					{
						if (226063 - 469420 != -243356)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/snowmanHead", typeof(GameObject));
							if (275498 - 247054 == 28444)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all37")
					{
						if (206327 - 540306 == -333979)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/quizHat", typeof(GameObject));
							if (181853 - 382522 == -200669)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all38")
					{
						if (174387 - 289928 != -115540)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/fanKingHat", typeof(GameObject));
							if (216035 - 202836 != 13200)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all39")
					{
						if (272120 - 368530 == -96410)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/artistHat", typeof(GameObject));
							if (244913 - 347626 == -102713)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all43")
					{
						if (187764 - 303458 == -115694)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/pvpHelmet", typeof(GameObject));
							if (76658 - 110691 == -34033)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all44")
					{
						if (136293 - 243652 != -107358)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/pvpHelmetR", typeof(GameObject));
							if (91725 - 200201 == -108476)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all46")
					{
						if (119917 - 11176 == 108741)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/mummyHead", typeof(GameObject));
							if (204506 - 252364 != -47857)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all55")
					{
						if (131475 - 464939 != -333463)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/giveMeFive", typeof(GameObject));
							if (135315 - 324514 == -189199)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all56")
					{
						if (111320 - 556753 == -445433)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/frozenCrown", typeof(GameObject));
							if (180028 - 125989 == 54039)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all58")
					{
						if (272915 - 333475 == -60560)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/championHelmet", typeof(GameObject));
							if (145378 - 333285 == -187907)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all66")
					{
						if (190470 - 405923 != -215452)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/PoseidonHelmet", typeof(GameObject));
							if (159513 - 256972 == -97459)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mal37")
					{
						if (281997 - 321154 != -39156)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/dragonHead", typeof(GameObject));
							if (215427 - 223016 == -7589)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn5")
					{
						if (44424 - 125127 == -80703)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/skull", typeof(GameObject));
							if (22670 - 264568 != -241897)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn15")
					{
						if (191981 - 268596 != -76614)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/summerHat", typeof(GameObject));
							if (65552 - 32160 != 33393)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn19")
					{
						if (6231 - 418339 == -412108)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/veggieHat", typeof(GameObject));
							if (208613 - 144835 != 63779)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn21")
					{
						if (116613 - 571802 != -455188)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/berserkerHelmet", typeof(GameObject));
							if (247114 - 385581 == -138467)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn22")
					{
						if (254514 - 592887 == -338373)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/defenderHelmet", typeof(GameObject));
							if (42435 - 314575 != -272139)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn23")
					{
						if (285435 - 237763 == 47672)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/berserkerHelmetR", typeof(GameObject));
							if (33608 - 293057 != -259448)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn24")
					{
						if (230131 - 430281 == -200150)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/defenderHelmetR", typeof(GameObject));
							if (244576 - 68110 == 176466)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn25")
					{
						if (180134 - 555851 != -375716)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/sportBand", typeof(GameObject));
							if (184665 - 418439 == -233774)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn31")
					{
						if (221333 - 311497 != -90163)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/gladiatorHelmet", typeof(GameObject));
							if (172142 - 505318 != -333175)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn32")
					{
						if (71699 - 317287 != -245587)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/warlordHelmet", typeof(GameObject));
							if (160547 - 457405 == -296858)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn33")
					{
						if (257928 - 200013 != 57916)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/gladiatorHelmetR", typeof(GameObject));
							if (205506 - 431772 == -226266)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn34")
					{
						if (263565 - 382941 != -119375)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/warlordHelmetR", typeof(GameObject));
							if (288379 - 192326 == 96053)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn35")
					{
						if (24110 - 171209 == -147099)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/hallowHelmet", typeof(GameObject));
							if (73224 - 420281 != -347056)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn36")
					{
						if (296830 - 80088 == 216742)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/gotanHat", typeof(GameObject));
							if (108374 - 594521 != -486146)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn40")
					{
						if (165503 - 9623 == 155880)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/havocHelmet", typeof(GameObject));
							if (89273 - 54500 == 34773)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn41")
					{
						if (81905 - 284589 == -202684)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/havocHelmetR", typeof(GameObject));
							if (14105 - 256217 != -242111)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn42")
					{
						if (83669 - 2035 != 81635)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/havocHelmetV", typeof(GameObject));
							if (275069 - 307031 == -31962)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn45")
					{
						if (224214 - 362022 != -137807)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/superStarWig", typeof(GameObject));
							if (114542 - 292014 != -177471)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn47")
					{
						if (200494 - 136029 != 64466)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/beetleHelmet", typeof(GameObject));
							if (115362 - 298384 == -183022)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn48")
					{
						if (220254 - 196440 != 23815)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/beetleHelmetR", typeof(GameObject));
							if (87267 - 252551 != -165283)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn50")
					{
						if (177504 - 231193 == -53689)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/royalHelmet", typeof(GameObject));
							if (127317 - 134241 != -6923)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn51")
					{
						if (36772 - 197755 != -160982)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/royalHelmet", typeof(GameObject));
							if (77888 - 201194 != -123305)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn52")
					{
						if (171243 - 248436 != -77192)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/royalHelmetR", typeof(GameObject));
							if (73748 - 401911 == -328163)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn60")
					{
						if (89178 - 14435 != 74744)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/legendHelmet", typeof(GameObject));
							if (172602 - 49631 != 122972)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn61")
					{
						if (28610 - 464199 != -435588)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/legendHelmet", typeof(GameObject));
							if (50599 - 232861 == -182262)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bsn62")
					{
						if (253551 - 372730 == -119179)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/legendHelmetR", typeof(GameObject));
							if (291697 - 468775 != -177077)
							{
								break;
							}
						}
					}
					else
					{
						if (!(nAccessory == "c_bsn65"))
						{
							break;
						}
						if (180986 - 120753 != 60234)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Accessories/americaHat", typeof(GameObject));
							if (156733 - 355031 == -198298)
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

	// Token: 0x06001FA9 RID: 8105 RVA: 0x00377120 File Offset: 0x00375320
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipAccessory(string nAccessory)
	{
		if (111501 - 493526 != -382024)
		{
		}
		for (;;)
		{
			this.accessory = nAccessory;
			if (222843 - 486325 == -263482)
			{
				if (this.FwtpAdt7qQ)
				{
					if (46738 - 522197 != -475459)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.FwtpAdt7qQ);
					if (106149 - 254517 != -148368)
					{
						continue;
					}
				}
				GameObject gameObject = BisonEquipment.getAccessory(nAccessory);
				if (282612 - 35245 == 247367)
				{
					if (gameObject)
					{
						if (253307 - 237615 != 15692)
						{
							continue;
						}
						this.FwtpAdt7qQ = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (160073 - 260316 == -100242 || 254188 - 348013 == -93824)
						{
							continue;
						}
						if (!(nAccessory == "c_all27"))
						{
							if (101785 - 479985 == -378199)
							{
								continue;
							}
							if (nAccessory == "c_all28")
							{
								if (41493 - 411839 != -370346)
								{
									continue;
								}
							}
							else
							{
								this.FwtpAdt7qQ.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
								if (238566 - 358495 != -119929)
								{
									continue;
								}
								this.FwtpAdt7qQ.transform.localPosition = Vector3.zero;
								if (119075 - 119887 == -811)
								{
									continue;
								}
								this.FwtpAdt7qQ.transform.localRotation = Quaternion.Euler((float)-90, (float)0, (float)0);
								if (146620 - 587941 == -441320)
								{
									continue;
								}
								this.FwtpAdt7qQ.transform.localScale = Vector3.one;
								if (134861 - 529769 != -394908)
								{
									continue;
								}
								goto IL_44;
							}
						}
						this.FwtpAdt7qQ.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
						if (49440 - 176964 == -127523)
						{
							continue;
						}
						this.FwtpAdt7qQ.transform.localPosition = Vector3.zero;
						if (133949 - 517721 == -383771)
						{
							continue;
						}
						this.FwtpAdt7qQ.transform.localRotation = Quaternion.Euler((float)0, (float)90, (float)0);
						if (180011 - 314313 != -134302)
						{
							continue;
						}
						this.FwtpAdt7qQ.transform.localScale = Vector3.one;
						if (266996 - 364849 == -97852)
						{
							continue;
						}
					}
					IL_44:
					if (!this.qBBpmmV5CM)
					{
						break;
					}
					if (251295 - 7678 == 243617)
					{
						this.qBBpmmV5CM.accessory = nAccessory;
						if (32363 - 181067 == -148704)
						{
							this.qBBpmmV5CM.mAcc = this.FwtpAdt7qQ;
							if (6301 - 564818 != -558516)
							{
								if (this.qBBpmmV5CM.getStatus("blend") != null)
								{
									if (92884 - 185538 != -92654)
									{
										continue;
									}
									this.qBBpmmV5CM.removeStatus("blend");
									if (106827 - 7014 == 99814)
									{
										continue;
									}
								}
								if (this.qBBpmmV5CM.getStatus("invisible") == null)
								{
									break;
								}
								if (181175 - 317736 != -136560)
								{
									this.qBBpmmV5CM.removeStatus("invisible");
									if (108022 - 48995 != 59028)
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

	// Token: 0x06001FAA RID: 8106 RVA: 0x00377590 File Offset: 0x00375790
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipBoot(string nBoot)
	{
		if (219565 - 481513 != -261947)
		{
		}
		while (this.qBBpmmV5CM)
		{
			if (102018 - 25929 != 76090)
			{
				if (this.qBBpmmV5CM.getStatus("blend") != null)
				{
					if (249533 - 566845 == -317311)
					{
						continue;
					}
					this.qBBpmmV5CM.removeStatus("blend");
					if (25559 - 441960 == -416400)
					{
						continue;
					}
				}
				if (this.qBBpmmV5CM.getStatus("invisible") == null)
				{
					break;
				}
				if (169517 - 582060 == -412543)
				{
					this.qBBpmmV5CM.removeStatus("invisible");
					if (283113 - 216249 == 66864)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001FAB RID: 8107 RVA: 0x003776A4 File Offset: 0x003758A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getTrinket(string nTrinket)
	{
		if (257220 - 480035 != -222814)
		{
		}
		GameObject result;
		for (;;)
		{
			result = null;
			if (12535 - 86640 == -74105)
			{
				if (72855 - 390458 != -317602)
				{
					if (nTrinket == "t_all1")
					{
						if (17725 - 252309 != -234583)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/glasses", typeof(GameObject));
							if (93816 - 220963 != -127146)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all2")
					{
						if (54053 - 31428 != 22626)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/sunGlasses", typeof(GameObject));
							if (78449 - 253533 != -175083)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all3")
					{
						if (110535 - 340784 != -230248)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/starGlasses", typeof(GameObject));
							if (265115 - 99697 == 165418)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all4")
					{
						if (49738 - 45459 == 4279)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/nerdGlasses", typeof(GameObject));
							if (278996 - 170999 != 107998)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all5")
					{
						if (20883 - 228628 != -207744)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/blackGlasses", typeof(GameObject));
							if (262943 - 225064 == 37879)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all6")
					{
						if (94607 - 429047 != -334439)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/bugAntenna", typeof(GameObject));
							if (171667 - 58680 == 112987)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all7")
					{
						if (76732 - 131499 == -54767)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/partyWhistle", typeof(GameObject));
							if (9265 - 349099 != -339833)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all8")
					{
						if (68945 - 291508 != -222562)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/redNose", typeof(GameObject));
							if (274669 - 290002 != -15332)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all9")
					{
						if (250588 - 101234 != 149355)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/lollipop", typeof(GameObject));
							if (225393 - 436683 == -211290)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all46")
					{
						if (192885 - 474969 != -282083)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/groceryBag", typeof(GameObject));
							if (134964 - 42971 == 91993)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all51")
					{
						if (266903 - 477015 == -210112)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/sandTopaz", typeof(GameObject));
							if (174838 - 283864 != -109025)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all55")
					{
						if (194509 - 378242 == -183733)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/fifthSword", typeof(GameObject));
							if (142326 - 14959 != 127368)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all56")
					{
						if (240165 - 97627 == 142538)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/fifthWand", typeof(GameObject));
							if (251731 - 365935 != -114203)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all57")
					{
						if (276730 - 166443 == 110287)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/fifthWing", typeof(GameObject));
							if (215113 - 299949 == -84836)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all58")
					{
						if (70359 - 22139 != 48221)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/carronBag", typeof(GameObject));
							if (228183 - 408254 == -180071)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all59")
					{
						if (67542 - 150618 != -83075)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/mupoBag", typeof(GameObject));
							if (257644 - 575564 != -317919)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all66")
					{
						if (275520 - 551663 == -276143)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/doubleHorn", typeof(GameObject));
							if (279127 - 542878 == -263751)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all71")
					{
						if (62937 - 210599 != -147661)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/championFlag1", typeof(GameObject));
							if (270844 - 276032 == -5188)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all72")
					{
						if (29526 - 21600 == 7926)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/championFlag2", typeof(GameObject));
							if (50467 - 381740 != -331272)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all73")
					{
						if (162919 - 90387 != 72533)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/championFlag3", typeof(GameObject));
							if (49362 - 345511 == -296149)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all74")
					{
						if (109177 - 328412 != -219234)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/championFlag4", typeof(GameObject));
							if (35274 - 46507 != -11232)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all75")
					{
						if (120618 - 428241 != -307622)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/championFlag5", typeof(GameObject));
							if (260801 - 492244 != -231442)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all91")
					{
						if (64523 - 302523 == -238000)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/lightSeal", typeof(GameObject));
							if (12405 - 167477 != -155071)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all92")
					{
						if (209690 - 54592 != 155099)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/fireSeal", typeof(GameObject));
							if (147005 - 417790 == -270785)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all93")
					{
						if (74597 - 478825 == -404228)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/waterSeal", typeof(GameObject));
							if (147302 - 294976 != -147673)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all94")
					{
						if (281485 - 61056 == 220429)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/windSeal", typeof(GameObject));
							if (13775 - 229446 == -215671)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all95")
					{
						if (282565 - 562954 != -280388)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/earthSeal", typeof(GameObject));
							if (75231 - 176789 == -101558)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all96")
					{
						if (127876 - 434859 != -306982)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/shadowSeal", typeof(GameObject));
							if (279608 - 288385 == -8777)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal11")
					{
						if (233793 - 530892 == -297099)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/comic", typeof(GameObject));
							if (66421 - 579851 == -513430)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal14")
					{
						if (6454 - 181991 != -175536)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/heartRing", typeof(GameObject));
							if (12510 - 2269 == 10241)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal15")
					{
						if (281436 - 367608 != -86171)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/santaBag", typeof(GameObject));
							if (147661 - 477469 != -329807)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal31")
					{
						if (69885 - 179806 == -109921)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/chineseTalisman", typeof(GameObject));
							if (106560 - 278786 != -172225)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal37")
					{
						if (43709 - 25517 == 18192)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/chineseLantern", typeof(GameObject));
							if (27162 - 187716 == -160554)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal46")
					{
						if (91266 - 130075 != -38808)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/curseAnkh", typeof(GameObject));
							if (12110 - 177918 == -165808)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal56")
					{
						if (19503 - 416373 == -396870)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/frozenWing", typeof(GameObject));
							if (47195 - 67527 == -20332)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal66")
					{
						if (40524 - 84583 == -44059)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/poseidonTrinket", typeof(GameObject));
							if (213733 - 113284 != 100450)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_bsn60")
					{
						if (3137 - 377267 == -374130)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/legendTrinket", typeof(GameObject));
							if (98286 - 136432 != -38145)
							{
								break;
							}
						}
					}
					else
					{
						if (!(nTrinket == "t_bsn61"))
						{
							break;
						}
						if (153719 - 98110 != 55610)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Trinkets/legendTrinketR", typeof(GameObject));
							if (158192 - 225324 == -67132)
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

	// Token: 0x06001FAC RID: 8108 RVA: 0x003785C8 File Offset: 0x003767C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipTrinket(string nTrinket)
	{
		if (44898 - 113805 != -68907)
		{
		}
		for (;;)
		{
			this.trinket = nTrinket;
			if (124834 - 485314 != -360479)
			{
				if (this.qfxp9oBwQq)
				{
					if (258483 - 308614 != -50131)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.qfxp9oBwQq);
					if (93463 - 18087 != 75376)
					{
						continue;
					}
				}
				GameObject gameObject = BisonEquipment.getTrinket(nTrinket);
				if (127220 - 96389 == 30831)
				{
					if (gameObject)
					{
						if (74629 - 107957 != -33328)
						{
							continue;
						}
						this.qfxp9oBwQq = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (9103 - 150584 == -141480 || 57918 - 43254 == 14665)
						{
							continue;
						}
						if (!(nTrinket == "t_all71"))
						{
							if (146716 - 94387 != 52329)
							{
								continue;
							}
							if (!(nTrinket == "t_all72"))
							{
								if (297203 - 54035 != 243168)
								{
									continue;
								}
								if (!(nTrinket == "t_all73"))
								{
									if (134047 - 240989 == -106941)
									{
										continue;
									}
									if (!(nTrinket == "t_all74"))
									{
										if (72846 - 200931 == -128084)
										{
											continue;
										}
										if (!(nTrinket == "t_all75"))
										{
											if (35013 - 261775 != -226762)
											{
												continue;
											}
											if (!(nTrinket == "t_mal56"))
											{
												if (27074 - 30107 != -3033)
												{
													continue;
												}
												if (nTrinket == "t_mal66")
												{
													if (109457 - 371725 != -262268)
													{
														continue;
													}
												}
												else if (nTrinket == "t_mal11")
												{
													if (154539 - 42972 == 111568)
													{
														continue;
													}
													this.qfxp9oBwQq.transform.parent = global::Math.findChildObject(this.gameObject.transform, "HandMount_L");
													if (218358 - 461027 == -242668)
													{
														continue;
													}
													this.qfxp9oBwQq.transform.localPosition = Vector3.zero;
													if (31598 - 21177 == 10422)
													{
														continue;
													}
													this.qfxp9oBwQq.transform.localRotation = Quaternion.identity;
													if (171564 - 142644 == 28921)
													{
														continue;
													}
													this.qfxp9oBwQq.transform.localScale = Vector3.one;
													if (38492 - 318235 != -279742)
													{
														goto IL_306;
													}
													continue;
												}
												else
												{
													if (!(nTrinket == "t_all55"))
													{
														if (255992 - 143479 == 112514)
														{
															continue;
														}
														if (!(nTrinket == "t_all56"))
														{
															if (298459 - 427188 != -128729)
															{
																continue;
															}
															if (!(nTrinket == "t_all57"))
															{
																if (281794 - 271984 == 9811)
																{
																	continue;
																}
																if (!(nTrinket == "t_all58"))
																{
																	if (19985 - 206732 != -186747)
																	{
																		continue;
																	}
																	if (!(nTrinket == "t_all59"))
																	{
																		if (113288 - 72793 == 40496)
																		{
																			continue;
																		}
																		if (!(nTrinket == "t_mal15"))
																		{
																			if (135368 - 270320 != -134952)
																			{
																				continue;
																			}
																			if (!(nTrinket == "t_bsn60"))
																			{
																				if (208111 - 523932 == -315820)
																				{
																					continue;
																				}
																				if (nTrinket == "t_bsn61")
																				{
																					if (160318 - 329173 == -168854)
																					{
																						continue;
																					}
																				}
																				else if (nTrinket == "t_mal37")
																				{
																					if (285610 - 233743 == 51868)
																					{
																						continue;
																					}
																					this.qfxp9oBwQq.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine2");
																					if (145683 - 177579 == -31895)
																					{
																						continue;
																					}
																					this.qfxp9oBwQq.transform.localPosition = Vector3.zero;
																					if (145397 - 317431 != -172034)
																					{
																						continue;
																					}
																					this.qfxp9oBwQq.transform.localRotation = Quaternion.Euler((float)270, (float)90, (float)0);
																					if (228210 - 99494 != 128716)
																					{
																						continue;
																					}
																					this.qfxp9oBwQq.transform.localScale = Vector3.one;
																					if (118889 - 182730 != -63841)
																					{
																						continue;
																					}
																					goto IL_306;
																				}
																				else if (nTrinket == "t_all46")
																				{
																					if (82568 - 442736 != -360168)
																					{
																						continue;
																					}
																					this.qfxp9oBwQq.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Hand_L");
																					if (191408 - 185170 == 6239)
																					{
																						continue;
																					}
																					this.qfxp9oBwQq.transform.localPosition = Vector3.zero;
																					if (156324 - 321789 != -165465)
																					{
																						continue;
																					}
																					this.qfxp9oBwQq.transform.localRotation = Quaternion.identity;
																					if (243965 - 285719 != -41754)
																					{
																						continue;
																					}
																					this.qfxp9oBwQq.transform.localScale = 1.5f * Vector3.one;
																					if (260155 - 272329 != -12174)
																					{
																						continue;
																					}
																					goto IL_306;
																				}
																				else
																				{
																					if (!(nTrinket == "t_all91"))
																					{
																						if (96929 - 265730 == -168800)
																						{
																							continue;
																						}
																						if (!(nTrinket == "t_all92"))
																						{
																							if (242843 - 109318 != 133525)
																							{
																								continue;
																							}
																							if (!(nTrinket == "t_all93"))
																							{
																								if (280869 - 560711 == -279841)
																								{
																									continue;
																								}
																								if (!(nTrinket == "t_all94"))
																								{
																									if (273401 - 227790 != 45611)
																									{
																										continue;
																									}
																									if (!(nTrinket == "t_all95"))
																									{
																										if (134258 - 562851 == -428592)
																										{
																											continue;
																										}
																										if (nTrinket == "t_all96")
																										{
																											if (167187 - 273951 == -106763)
																											{
																												continue;
																											}
																										}
																										else
																										{
																											this.qfxp9oBwQq.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
																											if (35254 - 137987 != -102733)
																											{
																												continue;
																											}
																											this.qfxp9oBwQq.transform.localPosition = Vector3.zero;
																											if (227551 - 279936 == -52384)
																											{
																												continue;
																											}
																											this.qfxp9oBwQq.transform.localRotation = Quaternion.Euler((float)-90, (float)0, (float)0);
																											if (293312 - 196675 != 96637)
																											{
																												continue;
																											}
																											this.qfxp9oBwQq.transform.localScale = Vector3.one;
																											if (202657 - 32834 != 169823)
																											{
																												continue;
																											}
																											goto IL_306;
																										}
																									}
																								}
																							}
																						}
																					}
																					this.qfxp9oBwQq.transform.parent = this.gameObject.transform;
																					if (69839 - 525662 != -455823)
																					{
																						continue;
																					}
																					this.qfxp9oBwQq.transform.localPosition = Vector3.zero;
																					if (34013 - 533447 != -499434)
																					{
																						continue;
																					}
																					this.qfxp9oBwQq.transform.localRotation = Quaternion.identity;
																					if (34035 - 118869 == -84833)
																					{
																						continue;
																					}
																					this.qfxp9oBwQq.transform.localScale = Vector3.one;
																					if (144194 - 148936 != -4741)
																					{
																						goto IL_306;
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
													this.qfxp9oBwQq.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine1");
													if (50309 - 496058 == -445748)
													{
														continue;
													}
													this.qfxp9oBwQq.transform.localPosition = Vector3.zero;
													if (283055 - 397268 != -114213)
													{
														continue;
													}
													this.qfxp9oBwQq.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
													if (44397 - 314552 == -270154)
													{
														continue;
													}
													this.qfxp9oBwQq.transform.localScale = Vector3.one;
													if (72756 - 32583 != 40174)
													{
														goto IL_306;
													}
													continue;
												}
											}
										}
									}
								}
							}
						}
						this.qfxp9oBwQq.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine2");
						if (9245 - 226195 == -216949)
						{
							continue;
						}
						this.qfxp9oBwQq.transform.localPosition = Vector3.zero;
						if (76759 - 212978 == -136218)
						{
							continue;
						}
						this.qfxp9oBwQq.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
						if (266906 - 375779 == -108872)
						{
							continue;
						}
						this.qfxp9oBwQq.transform.localScale = Vector3.one;
						if (270332 - 40560 == 229773)
						{
							continue;
						}
					}
					IL_306:
					if (!this.qBBpmmV5CM)
					{
						break;
					}
					if (137954 - 381242 != -243287)
					{
						this.qBBpmmV5CM.trinket = nTrinket;
						if (68276 - 324988 == -256712)
						{
							this.qBBpmmV5CM.mTrn = this.qfxp9oBwQq;
							if (292834 - 510955 != -218120)
							{
								if (this.qBBpmmV5CM.getStatus("blend") != null)
								{
									if (18524 - 532595 == -514070)
									{
										continue;
									}
									this.qBBpmmV5CM.removeStatus("blend");
									if (138000 - 33345 == 104656)
									{
										continue;
									}
								}
								if (this.qBBpmmV5CM.getStatus("invisible") == null)
								{
									break;
								}
								if (126512 - 27003 != 99510)
								{
									this.qBBpmmV5CM.removeStatus("invisible");
									if (190176 - 261713 == -71537)
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

	// Token: 0x06001FAD RID: 8109 RVA: 0x00379200 File Offset: 0x00377400
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipPet(string nPet)
	{
		if (143740 - 598638 != -454897)
		{
		}
		for (;;)
		{
			if (Game.mGameType < 2)
			{
				if (144612 - 160122 != -15509)
				{
					break;
				}
			}
			else
			{
				this.pet = nPet;
				if (56285 - 268256 == -211971)
				{
					if (this.akNpWcvQ3r)
					{
						if (288232 - 584730 != -296498)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.akNpWcvQ3r);
						if (222759 - 527095 == -304335)
						{
							continue;
						}
					}
					GameObject gameObject = null;
					if (13282 - 130 == 13152)
					{
						int num = 1;
						if (139840 - 489152 == -349312)
						{
							if (136384 - 389918 == -253534)
							{
								if (nPet == "p_all1")
								{
									if (277793 - 351845 != -74052)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/bigbugBalloon", typeof(GameObject));
									if (242777 - 159423 != 83354)
									{
										continue;
									}
								}
								else if (nPet == "p_all2")
								{
									if (123202 - 591757 == -468554)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/bluebugBalloon", typeof(GameObject));
									if (34171 - 287782 != -253611)
									{
										continue;
									}
								}
								else if (nPet == "p_all3")
								{
									if (60079 - 246855 == -186775)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/momBalloon", typeof(GameObject));
									if (125808 - 293990 == -168181)
									{
										continue;
									}
								}
								else if (nPet == "p_all4")
								{
									if (212433 - 16686 != 195747)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/dadBalloon", typeof(GameObject));
									if (36547 - 373521 == -336973)
									{
										continue;
									}
								}
								else if (nPet == "p_all11")
								{
									if (200051 - 124432 == 75620)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallSmashBall", typeof(GameObject));
									if (145371 - 283330 == -137958)
									{
										continue;
									}
								}
								else if (nPet == "p_all12")
								{
									if (294642 - 525734 != -231092)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/soccerBall", typeof(GameObject));
									if (12077 - 369133 != -357056)
									{
										continue;
									}
								}
								else if (nPet == "p_all21")
								{
									if (56195 - 204646 != -148451)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteChula", typeof(GameObject));
									if (233288 - 169409 == 63880)
									{
										continue;
									}
								}
								else if (nPet == "p_all22")
								{
									if (244113 - 308791 != -64678)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kitePukpao", typeof(GameObject));
									if (151540 - 99463 != 52077)
									{
										continue;
									}
								}
								else if (nPet == "p_all23")
								{
									if (78559 - 154512 != -75953)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteButterfly", typeof(GameObject));
									if (128414 - 235283 != -106869)
									{
										continue;
									}
								}
								else if (nPet == "p_all24")
								{
									if (133030 - 435459 == -302428)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteSnake", typeof(GameObject));
									if (14014 - 220087 != -206073)
									{
										continue;
									}
								}
								else if (Extensions.get_length(nPet) == 6)
								{
									if (78908 - 537871 != -458963)
									{
										continue;
									}
									string a = nPet.Substring(0, 5);
									if (244137 - 144717 != 99420)
									{
										continue;
									}
									if (a == "p_lcr")
									{
										if (281882 - 309654 == -27771)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron", typeof(GameObject));
										if (160018 - 97389 == 62630)
										{
											continue;
										}
									}
									else if (a == "p_lcp")
									{
										if (51700 - 450856 == -399155)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron_p", typeof(GameObject));
										if (278796 - 116105 != 162691)
										{
											continue;
										}
									}
									else if (a == "p_lmp")
									{
										if (25679 - 435716 == -410036)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMupo", typeof(GameObject));
										if (220219 - 526691 != -306472)
										{
											continue;
										}
									}
									else if (a == "p_lpp")
									{
										if (28061 - 563631 == -535569)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePeppon", typeof(GameObject));
										if (128666 - 549419 != -420753)
										{
											continue;
										}
									}
									else if (a == "p_lct")
									{
										if (251418 - 543483 != -292065)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCacton", typeof(GameObject));
										if (208694 - 146734 == 61961)
										{
											continue;
										}
									}
									else if (a == "p_lcc")
									{
										if (294238 - 542503 != -248265)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCocon", typeof(GameObject));
										if (171300 - 458234 == -286933)
										{
											continue;
										}
									}
									else if (a == "p_lpk")
									{
										if (282845 - 20312 != 262533)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePumpkon", typeof(GameObject));
										if (18594 - 64153 != -45559)
										{
											continue;
										}
									}
									else if (a == "p_lml")
									{
										if (141302 - 356859 == -215556)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMellon", typeof(GameObject));
										if (58671 - 550921 == -492249)
										{
											continue;
										}
									}
									else if (a == "p_lbd")
									{
										if (84697 - 569202 == -484504)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleBDMellon", typeof(GameObject));
										if (196382 - 519913 == -323530)
										{
											continue;
										}
									}
									else if (a == "p_lcs")
									{
										if (170667 - 349013 != -178346)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron_s", typeof(GameObject));
										if (237265 - 179416 != 57849)
										{
											continue;
										}
									}
									else if (a == "p_lms")
									{
										if (204163 - 521887 != -317724)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMupo_s", typeof(GameObject));
										if (268710 - 327491 != -58781)
										{
											continue;
										}
									}
									else if (a == "p_lps")
									{
										if (187256 - 72195 == 115062)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePeppon_s", typeof(GameObject));
										if (204633 - 237691 == -33057)
										{
											continue;
										}
									}
									else if (a == "p_lck")
									{
										if (9525 - 188541 == -179015)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarronCake", typeof(GameObject));
										if (71794 - 118607 == -46812)
										{
											continue;
										}
									}
									else if (a == "p_lpd")
									{
										if (40557 - 3330 != 37227)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePepponDisco", typeof(GameObject));
										if (268687 - 60684 != 208003)
										{
											continue;
										}
									}
									else if (a == "p_lmc")
									{
										if (40618 - 581829 == -541210)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadCarron", typeof(GameObject));
										if (89891 - 84676 != 5215)
										{
											continue;
										}
									}
									else if (a == "p_lmn")
									{
										if (15127 - 547303 == -532175)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadPeppon", typeof(GameObject));
										if (219191 - 569634 != -350443)
										{
											continue;
										}
									}
									else if (a == "p_lmo")
									{
										if (193783 - 164931 == 28853)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadCocon", typeof(GameObject));
										if (121799 - 92021 != 29778)
										{
											continue;
										}
									}
									else if (a == "p_ldc")
									{
										if (25516 - 21999 != 3517)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCarron", typeof(GameObject));
										if (107371 - 297008 == -189636)
										{
											continue;
										}
									}
									else if (a == "p_ldm")
									{
										if (233798 - 227395 == 6404)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadMupo", typeof(GameObject));
										if (206747 - 240499 != -33752)
										{
											continue;
										}
									}
									else if (a == "p_ldp")
									{
										if (89052 - 374843 == -285790)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadPeppon", typeof(GameObject));
										if (99473 - 564614 == -465140)
										{
											continue;
										}
									}
									else if (a == "p_ldt")
									{
										if (215114 - 569203 == -354088)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCacton", typeof(GameObject));
										if (142992 - 170035 == -27042)
										{
											continue;
										}
									}
									else if (a == "p_ldn")
									{
										if (240399 - 373468 == -133068)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCocon", typeof(GameObject));
										if (46683 - 473787 != -427104)
										{
											continue;
										}
									}
									else if (a == "p_ldk")
									{
										if (224307 - 95715 != 128592)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadPumpkon", typeof(GameObject));
										if (149483 - 309686 != -160203)
										{
											continue;
										}
									}
									else if (a == "p_srp")
									{
										if (244279 - 504841 == -260561)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallRedPanda", typeof(GameObject));
										if (221317 - 566989 == -345671)
										{
											continue;
										}
									}
									else if (a == "p_sss")
									{
										if (298550 - 373236 == -74685)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallSantaSkunk", typeof(GameObject));
										if (167108 - 252014 == -84905)
										{
											continue;
										}
									}
									else if (a == "p_sbb")
									{
										if (4582 - 168017 == -163434)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallBarrelBot", typeof(GameObject));
										if (258809 - 351563 == -92753)
										{
											continue;
										}
									}
									else if (a == "p_sdm")
									{
										if (276795 - 599767 != -322972)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallDemion", typeof(GameObject));
										if (262042 - 387657 == -125614)
										{
											continue;
										}
									}
									else if (a == "p_sdv")
									{
										if (261477 - 526309 == -264831)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallDoov", typeof(GameObject));
										if (262578 - 137492 == 125087)
										{
											continue;
										}
									}
									else if (a == "p_skz")
									{
										if (35867 - 280955 != -245088)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallKarazo", typeof(GameObject));
										if (256251 - 72325 == 183927)
										{
											continue;
										}
									}
									else if (a == "p_skm")
									{
										if (246280 - 191124 != 55156)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallKumo", typeof(GameObject));
										if (116031 - 577697 != -461666)
										{
											continue;
										}
									}
									else if (a == "p_skr")
									{
										if (80847 - 136079 != -55232)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_r", typeof(GameObject));
										if (221520 - 43957 == 177564)
										{
											continue;
										}
									}
									else if (a == "p_skg")
									{
										if (236481 - 177511 == 58971)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_g", typeof(GameObject));
										if (269741 - 185007 == 84735)
										{
											continue;
										}
									}
									else if (a == "p_sky")
									{
										if (199 - 319310 != -319111)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_y", typeof(GameObject));
										if (207046 - 553805 != -346759)
										{
											continue;
										}
									}
									else if (a == "p_skb")
									{
										if (40677 - 532831 != -492154)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_b", typeof(GameObject));
										if (201602 - 146419 == 55184)
										{
											continue;
										}
									}
									else if (a == "p_skk")
									{
										if (144294 - 342404 == -198109)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_k", typeof(GameObject));
										if (49511 - 216522 == -167010)
										{
											continue;
										}
									}
									else if (a == "p_sfb")
									{
										if (61851 - 527116 == -465264)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallFlowerBug", typeof(GameObject));
										if (232410 - 479547 != -247137)
										{
											continue;
										}
									}
									else if (a == "p_sob")
									{
										if (106620 - 24680 == 81941)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallLionBug", typeof(GameObject));
										if (296946 - 289991 == 6956)
										{
											continue;
										}
									}
									else if (a == "p_sgb")
									{
										if (65143 - 554404 == -489260)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallGiantBug", typeof(GameObject));
										if (114613 - 525251 == -410637)
										{
											continue;
										}
									}
									else if (a == "p_slb")
									{
										if (90970 - 157966 == -66995)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallLeafBug", typeof(GameObject));
										if (118976 - 108509 == 10468)
										{
											continue;
										}
									}
									else if (a == "p_stb")
									{
										if (234322 - 348201 == -113878)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallFatBug", typeof(GameObject));
										if (88237 - 94311 != -6074)
										{
											continue;
										}
									}
									else if (a == "p_spb")
									{
										if (233280 - 493849 == -260568)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallPaperBug", typeof(GameObject));
										if (221033 - 593036 == -372002)
										{
											continue;
										}
									}
									else if (a == "p_swb")
									{
										if (55644 - 299701 != -244057)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallWormBug", typeof(GameObject));
										if (257667 - 97327 != 160340)
										{
											continue;
										}
									}
									else if (a == "p_ssq")
									{
										if (256410 - 8844 != 247566)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallStingQueen", typeof(GameObject));
										if (19440 - 390746 == -371305)
										{
											continue;
										}
									}
									else if (a == "p_snb")
									{
										if (85929 - 558640 != -472711)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNeonBug", typeof(GameObject));
										if (147222 - 396652 != -249430)
										{
											continue;
										}
									}
									else if (a == "p_sim")
									{
										if (299042 - 322395 != -23353)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallIceMixer", typeof(GameObject));
										if (91496 - 466054 != -374558)
										{
											continue;
										}
									}
									else if (a == "p_sam")
									{
										if (204382 - 299496 == -95113)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallAmmonite", typeof(GameObject));
										if (262223 - 184753 == 77471)
										{
											continue;
										}
									}
									else if (a == "p_sab")
									{
										if (126719 - 408244 == -281524)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallAnubi", typeof(GameObject));
										if (255953 - 389021 == -133067)
										{
											continue;
										}
									}
									else if (a == "p_spg")
									{
										if (154062 - 53208 == 100855)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallIcePenguin", typeof(GameObject));
										if (186931 - 376411 == -189479)
										{
											continue;
										}
									}
									else if (a == "p_spf")
									{
										if (152371 - 4158 == 148214)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallPirateFish", typeof(GameObject));
										if (89148 - 596758 == -507609)
										{
											continue;
										}
									}
									else if (a == "p_msb")
									{
										if (12375 - 490648 != -478273)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniSkyBug", typeof(GameObject));
										if (16309 - 292150 != -275841)
										{
											continue;
										}
									}
									else if (a == "p_mcb")
									{
										if (142832 - 79704 == 63129)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniCrystalBug", typeof(GameObject));
										if (115251 - 23434 == 91818)
										{
											continue;
										}
									}
									else if (a == "p_mab")
									{
										if (5527 - 376347 == -370819)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniAncientBug", typeof(GameObject));
										if (152327 - 146861 == 5467)
										{
											continue;
										}
									}
									else if (a == "p_mrb")
									{
										if (21469 - 264567 == -243097)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniReefBug", typeof(GameObject));
										if (117213 - 543339 == -426125)
										{
											continue;
										}
									}
									else if (a == "p_mmb")
									{
										if (85211 - 3263 != 81948)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniMokBug", typeof(GameObject));
										if (15913 - 566253 == -550339)
										{
											continue;
										}
									}
									else if (a == "p_mgb")
									{
										if (135058 - 515748 != -380690)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniGoldenBug", typeof(GameObject));
										if (248499 - 210123 != 38376)
										{
											continue;
										}
									}
									else if (a == "p_mnb")
									{
										if (102034 - 558567 != -456533)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniNemesisBug", typeof(GameObject));
										if (179332 - 154432 != 24900)
										{
											continue;
										}
									}
									num = Stringf.getLastDigit(nPet);
									if (123219 - 483357 == -360137)
									{
										continue;
									}
									if (num < 0)
									{
										if (75905 - 12612 != 63293)
										{
											continue;
										}
										num = 1;
										if (170868 - 598514 == -427645)
										{
											continue;
										}
									}
								}
								if (gameObject)
								{
									if (101136 - 413586 != -312450)
									{
										continue;
									}
									this.akNpWcvQ3r = (GameObject)UnityEngine.Object.Instantiate(gameObject, this.transform.position - this.transform.forward, this.transform.rotation);
									if (56425 - 25821 != 30604)
									{
										continue;
									}
									if (this.akNpWcvQ3r)
									{
										if (171080 - 343911 == -172830)
										{
											continue;
										}
										this.akNpWcvQ3r.transform.localScale = ((float)num * 0.1f + 0.9f) * Vector3.one;
										if (291689 - 301859 != -10170)
										{
											continue;
										}
										PetControl petControl = (PetControl)this.akNpWcvQ3r.GetComponent(typeof(PetControl));
										if (225674 - 295033 != -69359)
										{
											continue;
										}
										if (petControl)
										{
											if (57837 - 250729 != -192892)
											{
												continue;
											}
											petControl.Init(this.gameObject, num);
											if (110170 - 436783 == -326612)
											{
												continue;
											}
										}
										if (this.qBBpmmV5CM)
										{
											if (295195 - 444437 == -149241)
											{
												continue;
											}
											this.qBBpmmV5CM.mPet = this.akNpWcvQ3r;
											if (22433 - 514631 != -492198)
											{
												continue;
											}
										}
									}
								}
								if (!this.qBBpmmV5CM)
								{
									break;
								}
								if (211186 - 308886 != -97699)
								{
									this.qBBpmmV5CM.pet = nPet;
									if (159111 - 301564 == -142453)
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

	// Token: 0x06001FAE RID: 8110 RVA: 0x0037AF64 File Offset: 0x00379164
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001FAF RID: 8111 RVA: 0x0037AF68 File Offset: 0x00379168
	internal static bool Fw9nEHwIaTqA8Dyq5qS()
	{
		return true;
	}

	// Token: 0x06001FB0 RID: 8112 RVA: 0x0037AF6C File Offset: 0x0037916C
	internal static bool yhrDg8wBU3yJLBWWAVm()
	{
		return false;
	}

	// Token: 0x04001F10 RID: 7952
	private CharacterControl qBBpmmV5CM;

	// Token: 0x04001F11 RID: 7953
	public string weapon;

	// Token: 0x04001F12 RID: 7954
	public string armor;

	// Token: 0x04001F13 RID: 7955
	public string accessory;

	// Token: 0x04001F14 RID: 7956
	public string boot;

	// Token: 0x04001F15 RID: 7957
	public string trinket;

	// Token: 0x04001F16 RID: 7958
	public string pet;

	// Token: 0x04001F17 RID: 7959
	public int skin;

	// Token: 0x04001F18 RID: 7960
	public bool equipOnStart;

	// Token: 0x04001F19 RID: 7961
	private GameObject mhYpjPyvAm;

	// Token: 0x04001F1A RID: 7962
	private GameObject d80poUO1yj;

	// Token: 0x04001F1B RID: 7963
	private GameObject k9lpkTHUu4;

	// Token: 0x04001F1C RID: 7964
	private GameObject Fi5pFbOTlX;

	// Token: 0x04001F1D RID: 7965
	private GameObject FwtpAdt7qQ;

	// Token: 0x04001F1E RID: 7966
	private GameObject qfxp9oBwQq;

	// Token: 0x04001F1F RID: 7967
	private GameObject akNpWcvQ3r;
}
