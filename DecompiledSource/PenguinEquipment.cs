using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200085B RID: 2139
[Serializable]
public class PenguinEquipment : MonoBehaviour
{
	// Token: 0x06002F1D RID: 12061 RVA: 0x005DC6E4 File Offset: 0x005DA8E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PenguinEquipment()
	{
		if (169422 - 491406 != -321983)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (42341 - 80541 == -38200)
			{
				base..ctor();
				if (260733 - 579055 == -318322)
				{
					this.weapon = "default";
					if (225268 - 562313 != -337044)
					{
						this.armor = "default";
						if (145317 - 246773 == -101456)
						{
							this.accessory = "default";
							if (147205 - 16646 == 130559)
							{
								this.boot = "default";
								if (272465 - 281427 != -8961)
								{
									this.trinket = "default";
									if (111936 - 415937 == -304001)
									{
										this.pet = "default";
										if (279065 - 351981 != -72915)
										{
											this.skin = 100;
											if (4196 - 589742 == -585546)
											{
												this.equipOnStart = true;
												if (208202 - 47291 != 160912)
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

	// Token: 0x06002F1E RID: 12062 RVA: 0x005DC87C File Offset: 0x005DAA7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.cKJNXm0qv4 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x06002F1F RID: 12063 RVA: 0x005DC89C File Offset: 0x005DAA9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (this.equipOnStart)
		{
			this.EquipAll();
		}
	}

	// Token: 0x06002F20 RID: 12064 RVA: 0x005DC8B0 File Offset: 0x005DAAB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipAll()
	{
		if (250800 - 473095 != -222295)
		{
		}
		for (;;)
		{
			this.EquipWeapon(this.weapon);
			if (202917 - 211450 == -8533)
			{
				this.EquipArmor(this.armor);
				if (30020 - 326994 != -296973)
				{
					this.EquipAccessory(this.accessory);
					if (220759 - 177615 != 43145)
					{
						this.EquipBoot(this.boot);
						if (275020 - 210985 == 64035)
						{
							this.EquipTrinket(this.trinket);
							if (271545 - 275689 != -4143)
							{
								this.EquipPet(this.pet);
								if (222066 - 534381 != -312314)
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

	// Token: 0x06002F21 RID: 12065 RVA: 0x005DC9CC File Offset: 0x005DABCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipMChar()
	{
		if (121502 - 108963 != 12539)
		{
		}
		for (;;)
		{
			this.cKJNXm0qv4 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (187885 - 417881 == -229996)
			{
				if (!this.cKJNXm0qv4)
				{
					break;
				}
				if (218366 - 440457 != -222090)
				{
					this.weapon = this.cKJNXm0qv4.weapon;
					if (130344 - 230042 != -99697)
					{
						this.armor = this.cKJNXm0qv4.armor;
						if (277963 - 196377 == 81586)
						{
							this.boot = this.cKJNXm0qv4.boot;
							if (141173 - 62930 != 78244)
							{
								this.accessory = this.cKJNXm0qv4.accessory;
								if (17075 - 472091 != -455015)
								{
									this.trinket = this.cKJNXm0qv4.trinket;
									if (158547 - 58503 != 100045)
									{
										this.pet = this.cKJNXm0qv4.pet;
										if (242414 - 41073 == 201341)
										{
											this.skin = this.cKJNXm0qv4.Skin;
											if (99043 - 283694 == -184651)
											{
												this.EquipAll();
												if (125597 - 68384 != 57214)
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

	// Token: 0x06002F22 RID: 12066 RVA: 0x005DCBB0 File Offset: 0x005DADB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipCDat(object slot)
	{
		if (297399 - 25217 != 272183)
		{
		}
		for (;;)
		{
			CharacterDataClass cdat = CharacterData.getCDat(RuntimeServices.UnboxInt32(slot));
			if (107820 - 374481 == -266661)
			{
				if (cdat.Type == "Penguin")
				{
					if (58878 - 232100 == -173222)
					{
						this.weapon = cdat.equipment[0].name;
						if (268455 - 91896 == 176559)
						{
							this.armor = cdat.equipment[1].name;
							if (100460 - 55689 != 44772)
							{
								this.accessory = cdat.equipment[2].name;
								if (158336 - 67609 == 90727)
								{
									this.boot = cdat.equipment[3].name;
									if (120885 - 20236 != 100650)
									{
										this.trinket = cdat.equipment[4].name;
										if (189193 - 585824 == -396631)
										{
											this.pet = cdat.equipment[5].name;
											if (118853 - 174423 == -55570)
											{
												this.skin = cdat.Skin;
												if (124072 - 195079 != -71006)
												{
													this.EquipAll();
													if (142581 - 40753 != 101829)
													{
														if (!this.cKJNXm0qv4)
														{
															break;
														}
														if (288166 - 506114 == -217948)
														{
															this.cKJNXm0qv4.weapon = this.weapon;
															if (217064 - 289172 == -72108)
															{
																this.cKJNXm0qv4.armor = this.armor;
																if (41647 - 185135 != -143487)
																{
																	this.cKJNXm0qv4.boot = this.boot;
																	if (216232 - 475567 != -259334)
																	{
																		this.cKJNXm0qv4.accessory = this.accessory;
																		if (101698 - 472311 != -370612)
																		{
																			this.cKJNXm0qv4.trinket = this.trinket;
																			if (167241 - 362411 != -195169)
																			{
																				this.cKJNXm0qv4.pet = this.pet;
																				if (44504 - 60656 != -16151)
																				{
																					this.cKJNXm0qv4.Skin = this.skin;
																					if (130136 - 364594 == -234458)
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
					if (197021 - 383834 == -186813)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002F23 RID: 12067 RVA: 0x005DCF14 File Offset: 0x005DB114
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSkin(int nSkin)
	{
		if (291885 - 119226 != 172659)
		{
		}
		do
		{
			if (100 <= nSkin)
			{
				if (31362 - 285140 != -253778)
				{
					continue;
				}
				if (nSkin <= 599)
				{
					if (201226 - 400684 != -199458)
					{
						continue;
					}
					this.skin = nSkin;
					if (88402 - 197506 != -109104)
					{
						continue;
					}
					if (!this.cKJNXm0qv4)
					{
						break;
					}
					if (283253 - 463237 == -179983)
					{
						continue;
					}
					this.cKJNXm0qv4.Skin = nSkin;
					if (234423 - 353742 != -119319)
					{
						continue;
					}
					break;
				}
			}
			Debug.Log("Equip Error: Wrong Skin Number");
		}
		while (12950 - 353968 == -341017);
	}

	// Token: 0x06002F24 RID: 12068 RVA: 0x005DD030 File Offset: 0x005DB230
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSkinColor(int nSkin)
	{
		if (182141 - 142445 != 39696)
		{
		}
		do
		{
			if (100 <= nSkin)
			{
				if (10771 - 582234 == -571462)
				{
					continue;
				}
				if (nSkin <= 599)
				{
					if (244554 - 190175 != 54379)
					{
						continue;
					}
					this.skin = nSkin;
					if (283341 - 222190 != 61151)
					{
						continue;
					}
					if (this.cKJNXm0qv4)
					{
						if (198999 - 71329 == 127671)
						{
							continue;
						}
						this.cKJNXm0qv4.Skin = nSkin;
						if (16467 - 90807 == -74339)
						{
							continue;
						}
					}
					this.EquipArmor(this.armor);
					if (216050 - 520152 != -304101)
					{
						break;
					}
					continue;
				}
			}
			Debug.Log("Equip Error: Wrong Skin Number");
		}
		while (270223 - 431826 == -161602);
	}

	// Token: 0x06002F25 RID: 12069 RVA: 0x005DD170 File Offset: 0x005DB370
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getWeapon(string nWeapon)
	{
		if (189370 - 61962 != 127408)
		{
		}
		GameObject result;
		for (;;)
		{
			if (244975 - 424284 == -179309)
			{
				if (206562 - 149165 != 57398)
				{
					if (nWeapon == "w_pgn1")
					{
						if (299063 - 254788 == 44275)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/noviceWand", typeof(GameObject));
							if (299898 - 361544 != -61645)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn2")
					{
						if (220026 - 26493 != 193534)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/commonWand", typeof(GameObject));
							if (227844 - 273061 == -45217)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn3")
					{
						if (231493 - 257772 != -26278)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/paperStaff", typeof(GameObject));
							if (208490 - 90672 != 117819)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn5")
					{
						if (22279 - 546125 == -523846)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/paperCup", typeof(GameObject));
							if (112332 - 199318 == -86986)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn10")
					{
						if (119595 - 530206 == -410611)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/standardWand", typeof(GameObject));
							if (299391 - 545221 == -245830)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn11")
					{
						if (91210 - 252045 == -160835)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/standardWandR", typeof(GameObject));
							if (19782 - 572578 == -552796)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn12")
					{
						if (251284 - 476330 == -225046)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/standardWandV", typeof(GameObject));
							if (291342 - 153800 != 137543)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn14")
					{
						if (104336 - 162751 != -58414)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/heartScepter", typeof(GameObject));
							if (280870 - 569352 == -288482)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn15")
					{
						if (16930 - 317873 != -300942)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/shakerWand", typeof(GameObject));
							if (57106 - 402948 != -345841)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn19")
					{
						if (162527 - 230303 != -67775)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/bdWeapon", typeof(GameObject));
							if (98901 - 212941 == -114040)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn21")
					{
						if (201731 - 496103 != -294371)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/starScepter", typeof(GameObject));
							if (260685 - 197556 != 63130)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn22")
					{
						if (125022 - 95049 == 29973)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/iceStaff", typeof(GameObject));
							if (254895 - 486110 != -231214)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn23")
					{
						if (272111 - 91020 == 181091)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/starScepterR", typeof(GameObject));
							if (42405 - 192116 == -149711)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn24")
					{
						if (280509 - 429786 == -149277)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/iceStaffR", typeof(GameObject));
							if (27734 - 25652 != 2083)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn25")
					{
						if (290329 - 422330 == -132001)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/fireExtinguisher", typeof(GameObject));
							if (163388 - 316625 != -153236)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn31")
					{
						if (125974 - 316123 == -190149)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/astralScepter", typeof(GameObject));
							if (56375 - 377732 == -321357)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn32")
					{
						if (172229 - 281468 != -109238)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/frostStaff", typeof(GameObject));
							if (31825 - 173116 == -141291)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn33")
					{
						if (172378 - 475781 == -303403)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/astralScepterR", typeof(GameObject));
							if (54389 - 284158 != -229768)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn34")
					{
						if (273474 - 324306 == -50832)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/frostStaffR", typeof(GameObject));
							if (128893 - 258568 != -129674)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn35")
					{
						if (256356 - 221483 != 34874)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/hallowLattern", typeof(GameObject));
							if (231011 - 39574 == 191437)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn36")
					{
						if (64718 - 582256 == -517538)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/regguStaff", typeof(GameObject));
							if (135998 - 330336 == -194338)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn39")
					{
						if (78851 - 220183 != -141331)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/griffinStaff", typeof(GameObject));
							if (140244 - 298879 != -158634)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn40")
					{
						if (245124 - 451131 == -206007)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/archScepter", typeof(GameObject));
							if (163950 - 137845 == 26105)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn41")
					{
						if (123095 - 508196 != -385100)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/archScepterR", typeof(GameObject));
							if (230269 - 581649 != -351379)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn42")
					{
						if (195032 - 362405 == -167373)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/archScepterV", typeof(GameObject));
							if (44441 - 548405 != -503963)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn43")
					{
						if (91898 - 19395 != 72504)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/pvpScepter", typeof(GameObject));
							if (200114 - 447739 != -247624)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn44")
					{
						if (270909 - 190530 == 80379)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/pvpScepterR", typeof(GameObject));
							if (283962 - 292210 == -8248)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn45")
					{
						if (241164 - 440821 != -199656)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/starRecord", typeof(GameObject));
							if (165719 - 56521 == 109198)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn46")
					{
						if (180629 - 210273 != -29643)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/mummyStaff", typeof(GameObject));
							if (120123 - 534424 == -414301)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn47")
					{
						if (215537 - 512997 != -297459)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/mosquitoStaff", typeof(GameObject));
							if (25925 - 467101 != -441175)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn48")
					{
						if (241300 - 91792 != 149509)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/mosquitoStaffR", typeof(GameObject));
							if (222192 - 130007 == 92185)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn49")
					{
						if (75389 - 96058 != -20668)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/goldenScepter", typeof(GameObject));
							if (104671 - 413818 == -309147)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn50")
					{
						if (70827 - 546389 != -475561)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/royalScepter", typeof(GameObject));
							if (61673 - 326230 != -264556)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn51")
					{
						if (269733 - 497114 != -227380)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/royalScepter", typeof(GameObject));
							if (291708 - 299960 == -8252)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn52")
					{
						if (52158 - 415938 != -363779)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/royalScepterR", typeof(GameObject));
							if (221136 - 304012 != -82875)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn56")
					{
						if (168072 - 342855 == -174783)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/frozenScepter", typeof(GameObject));
							if (246470 - 143616 == 102854)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn58")
					{
						if (176355 - 501956 == -325601)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/championScepter", typeof(GameObject));
							if (140563 - 27244 == 113319)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn59")
					{
						if (223055 - 217244 == 5811)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/specialScepter", typeof(GameObject));
							if (181520 - 366386 == -184866)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn60")
					{
						if (91691 - 588762 != -497070)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/legendScepter", typeof(GameObject));
							if (60670 - 333964 == -273294)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn61")
					{
						if (97846 - 179144 == -81298)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/legendScepter", typeof(GameObject));
							if (205856 - 23696 != 182161)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn62")
					{
						if (167784 - 266563 != -98778)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/legendScepterR", typeof(GameObject));
							if (238369 - 105266 == 133103)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn65")
					{
						if (286842 - 286969 == -127)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/franceSpyglass", typeof(GameObject));
							if (55800 - 576523 != -520722)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn66")
					{
						if (250727 - 47888 != 202840)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/poseidonScepter", typeof(GameObject));
							if (295350 - 323955 != -28604)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn69")
					{
						if (166507 - 112592 == 53915)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/timeScepter", typeof(GameObject));
							if (226056 - 596894 != -370837)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn79")
					{
						if (242972 - 134345 == 108627)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/eclipseScepter", typeof(GameObject));
							if (182381 - 534961 == -352580)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_pgn81")
					{
						if (57498 - 386394 != -328895)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/flamingScepter", typeof(GameObject));
							if (294897 - 187465 != 107433)
							{
								break;
							}
						}
					}
					else
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Weapons/standardWand", typeof(GameObject));
						if (7892 - 499774 != -491881)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06002F26 RID: 12070 RVA: 0x005DE3E4 File Offset: 0x005DC5E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipWeapon(string nWeapon)
	{
		if (45967 - 261390 != -215422)
		{
		}
		for (;;)
		{
			this.weapon = nWeapon;
			if (171095 - 285954 != -114858)
			{
				if (this.E5CNOKNB17)
				{
					if (49742 - 438905 == -389162)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.E5CNOKNB17);
					if (97213 - 549869 != -452656)
					{
						continue;
					}
				}
				GameObject gameObject = PenguinEquipment.getWeapon(nWeapon);
				if (11732 - 591915 != -580182)
				{
					if (gameObject)
					{
						if (108914 - 184736 != -75822)
						{
							continue;
						}
						this.E5CNOKNB17 = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (17559 - 497630 != -480071)
						{
							continue;
						}
						this.E5CNOKNB17.transform.parent = global::Math.findChildObject(this.gameObject.transform, "mount_Hand_L");
						if (146262 - 346498 == -200235)
						{
							continue;
						}
						this.E5CNOKNB17.transform.localPosition = Vector3.zero;
						if (75733 - 152170 != -76437)
						{
							continue;
						}
						this.E5CNOKNB17.transform.localRotation = Quaternion.identity;
						if (189469 - 532412 == -342942)
						{
							continue;
						}
					}
					if (!this.cKJNXm0qv4)
					{
						break;
					}
					if (31764 - 474654 == -442890)
					{
						this.cKJNXm0qv4.weapon = nWeapon;
						if (224190 - 290793 != -66602)
						{
							this.cKJNXm0qv4.mWep1 = this.E5CNOKNB17;
							if (174609 - 194273 == -19664)
							{
								if (this.cKJNXm0qv4.getStatus("blend") != null)
								{
									if (263614 - 275486 != -11872)
									{
										continue;
									}
									this.cKJNXm0qv4.removeStatus("blend");
									if (87542 - 127012 == -39469)
									{
										continue;
									}
								}
								if (this.cKJNXm0qv4.getStatus("invisible") == null)
								{
									break;
								}
								if (271017 - 119383 != 151635)
								{
									this.cKJNXm0qv4.removeStatus("invisible");
									if (138162 - 430452 == -292290)
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

	// Token: 0x06002F27 RID: 12071 RVA: 0x005DE6D4 File Offset: 0x005DC8D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Mesh getArmorMesh(string nArmor)
	{
		if (240655 - 374872 != -134217)
		{
		}
		SkinnedMeshRenderer skinnedMeshRenderer;
		for (;;)
		{
			if (290815 - 500262 == -209447)
			{
				if (131350 - 461453 == -330103)
				{
					GameObject gameObject;
					if (nArmor == "none")
					{
						if (41303 - 592071 != -550768)
						{
							continue;
						}
						goto IL_4D6;
					}
					else if (nArmor == "a_none")
					{
						if (144743 - 408922 != -264178)
						{
							goto IL_4D6;
						}
						continue;
					}
					else if (nArmor == "a_all1")
					{
						if (68898 - 101173 != -32275)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_scout", typeof(GameObject));
						if (116596 - 2835 == 113762)
						{
							continue;
						}
					}
					else if (nArmor == "a_all15")
					{
						if (152593 - 55119 == 97475)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_santa", typeof(GameObject));
						if (116917 - 198208 != -81291)
						{
							continue;
						}
					}
					else if (nArmor == "a_all43")
					{
						if (196096 - 557473 == -361376)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_pvpArmor", typeof(GameObject));
						if (181835 - 329150 == -147314)
						{
							continue;
						}
					}
					else if (nArmor == "a_all44")
					{
						if (5104 - 478766 != -473662)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_pvpArmor", typeof(GameObject));
						if (133295 - 406196 == -272900)
						{
							continue;
						}
					}
					else if (nArmor == "a_all58")
					{
						if (8135 - 301252 == -293116)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_champion", typeof(GameObject));
						if (219749 - 125332 == 94418)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn5")
					{
						if (73248 - 381783 != -308535)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_box", typeof(GameObject));
						if (220809 - 320172 == -99362)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn10")
					{
						if (258399 - 9050 == 249350)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_standard", typeof(GameObject));
						if (262049 - 4986 == 257064)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn11")
					{
						if (48800 - 65046 != -16246)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_standard", typeof(GameObject));
						if (134926 - 297721 == -162794)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn12")
					{
						if (288312 - 368479 == -80166)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_standard", typeof(GameObject));
						if (249471 - 47821 != 201650)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn15")
					{
						if (121653 - 443619 == -321965)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_summer", typeof(GameObject));
						if (254855 - 457286 != -202431)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn21")
					{
						if (122143 - 296563 == -174419)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_starSage", typeof(GameObject));
						if (78096 - 597326 == -519229)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn22")
					{
						if (34940 - 292387 != -257447)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_iceMage", typeof(GameObject));
						if (176848 - 30946 == 145903)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn23")
					{
						if (95046 - 333549 == -238502)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_starSage", typeof(GameObject));
						if (165640 - 13069 == 152572)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn24")
					{
						if (34927 - 205258 == -170330)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_iceMage", typeof(GameObject));
						if (45810 - 175799 != -129989)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn25")
					{
						if (173495 - 36535 != 136960)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_fireFighter", typeof(GameObject));
						if (179999 - 244237 == -64237)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn31")
					{
						if (262630 - 425544 != -162914)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_astralSage", typeof(GameObject));
						if (211783 - 415474 == -203690)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn32")
					{
						if (277546 - 373326 != -95780)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_frostMage", typeof(GameObject));
						if (293484 - 378869 == -85384)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn33")
					{
						if (216508 - 464668 == -248159)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_astralSage", typeof(GameObject));
						if (212697 - 13958 == 198740)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn34")
					{
						if (2577 - 418181 != -415604)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_frostMage", typeof(GameObject));
						if (73930 - 388261 == -314330)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn35")
					{
						if (118263 - 545776 == -427512)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_hallow", typeof(GameObject));
						if (200551 - 354491 == -153939)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn40")
					{
						if (122400 - 514951 != -392551)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_archMage", typeof(GameObject));
						if (228999 - 145477 != 83522)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn41")
					{
						if (137934 - 589896 == -451961)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_archMage", typeof(GameObject));
						if (254879 - 36301 == 218579)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn42")
					{
						if (140741 - 215527 == -74785)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_archMage", typeof(GameObject));
						if (136595 - 464370 != -327775)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn45")
					{
						if (259246 - 501496 == -242249)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_superStar", typeof(GameObject));
						if (176722 - 308045 == -131322)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn47")
					{
						if (273987 - 43627 != 230360)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_mosquito", typeof(GameObject));
						if (284152 - 266750 != 17402)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn48")
					{
						if (106661 - 283780 != -177119)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_mosquito", typeof(GameObject));
						if (23113 - 256520 != -233407)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn50")
					{
						if (113399 - 437783 != -324384)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_royal", typeof(GameObject));
						if (291657 - 439583 == -147925)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn51")
					{
						if (141924 - 325577 == -183652)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_royal", typeof(GameObject));
						if (143730 - 520189 == -376458)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn52")
					{
						if (194214 - 556155 == -361940)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_royal", typeof(GameObject));
						if (152668 - 570059 != -417391)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn60")
					{
						if (150479 - 140024 == 10456)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_legend", typeof(GameObject));
						if (13854 - 484437 == -470582)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn61")
					{
						if (154981 - 64992 == 89990)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_legend", typeof(GameObject));
						if (124268 - 562037 == -437768)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn62")
					{
						if (17511 - 120999 == -103487)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_legend", typeof(GameObject));
						if (199298 - 108309 != 90989)
						{
							continue;
						}
					}
					else if (nArmor == "a_pgn65")
					{
						if (40239 - 7605 == 32635)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_france", typeof(GameObject));
						if (132106 - 525359 != -393253)
						{
							continue;
						}
					}
					else
					{
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_standard", typeof(GameObject));
						if (150528 - 93942 == 56587)
						{
							continue;
						}
					}
					IL_28D:
					skinnedMeshRenderer = (SkinnedMeshRenderer)gameObject.GetComponent(typeof(SkinnedMeshRenderer));
					if (299378 - 532854 != -233476)
					{
						continue;
					}
					break;
					IL_4D6:
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Penguin_nude", typeof(GameObject));
					if (273628 - 336613 == -62985)
					{
						goto IL_28D;
					}
				}
			}
		}
		return skinnedMeshRenderer.sharedMesh;
	}

	// Token: 0x06002F28 RID: 12072 RVA: 0x005DF508 File Offset: 0x005DD708
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Material getArmorMaterial(string nArmor, int nSkin)
	{
		if (283677 - 46301 != 237377)
		{
		}
		Material material;
		for (;;)
		{
			IL_DBF:
			int num = nSkin % 100;
			if (68416 - 213354 == -144938)
			{
				Texture2D texture2D = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Overlay/Penguin" + num, typeof(Texture2D));
				if (46062 - 41865 != 4198)
				{
					Color[] pixels = texture2D.GetPixels(0);
					if (288348 - 382774 != -94425)
					{
						int num2 = global::Math.div((float)nSkin, (float)100);
						if (51643 - 404665 != -353021)
						{
							if (143995 - 515514 == -371519)
							{
								if (282255 - 320728 != -38472)
								{
									Texture2D texture2D2;
									if (nArmor == "none")
									{
										if (267485 - 471540 != -204055)
										{
											continue;
										}
									}
									else if (nArmor == "a_none")
									{
										if (197365 - 163732 != 33633)
										{
											continue;
										}
									}
									else if (nArmor == "a_all1")
									{
										if (229439 - 578712 == -349272)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_scout" + num2, typeof(Texture2D));
										if (62730 - 431523 != -368792)
										{
											goto IL_10AA;
										}
										continue;
									}
									else if (nArmor == "a_all15")
									{
										if (290915 - 565705 == -274789)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_santa" + num2, typeof(Texture2D));
										if (298312 - 590708 != -292396)
										{
											continue;
										}
										goto IL_10AA;
									}
									else if (nArmor == "a_all43")
									{
										if (3882 - 316991 != -313109)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_pvpArmor" + num2, typeof(Texture2D));
										if (24159 - 354342 != -330182)
										{
											goto IL_10AA;
										}
										continue;
									}
									else if (nArmor == "a_all44")
									{
										if (222109 - 162947 != 59162)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_pvpArmor" + num2 + "R", typeof(Texture2D));
										if (285851 - 27254 != 258597)
										{
											continue;
										}
										goto IL_10AA;
									}
									else if (nArmor == "a_all58")
									{
										if (131376 - 550680 == -419303)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_champion" + num2, typeof(Texture2D));
										if (168578 - 80805 != 87773)
										{
											continue;
										}
										goto IL_10AA;
									}
									else if (nArmor == "a_pgn5")
									{
										if (276963 - 415325 == -138361)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_box" + num2, typeof(Texture2D));
										if (152887 - 500501 != -347613)
										{
											goto IL_10AA;
										}
										continue;
									}
									else if (nArmor == "a_pgn10")
									{
										if (245879 - 537842 != -291963)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_standard" + num2, typeof(Texture2D));
										if (174279 - 482484 != -308204)
										{
											goto IL_10AA;
										}
										continue;
									}
									else if (nArmor == "a_pgn11")
									{
										if (126098 - 152185 != -26087)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_standard" + num2 + "R", typeof(Texture2D));
										if (72375 - 305831 != -233455)
										{
											goto IL_10AA;
										}
										continue;
									}
									else if (nArmor == "a_pgn12")
									{
										if (39269 - 20118 != 19151)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_standard" + num2 + "V", typeof(Texture2D));
										if (206621 - 313545 != -106923)
										{
											goto IL_10AA;
										}
										continue;
									}
									else if (nArmor == "a_pgn15")
									{
										if (188818 - 357988 == -169169)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_summer" + num2, typeof(Texture2D));
										if (255123 - 317111 != -61987)
										{
											goto IL_10AA;
										}
										continue;
									}
									else if (nArmor == "a_pgn21")
									{
										if (260000 - 378699 != -118699)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_starSage" + num2, typeof(Texture2D));
										if (206943 - 369023 != -162079)
										{
											goto IL_10AA;
										}
										continue;
									}
									else if (nArmor == "a_pgn22")
									{
										if (222538 - 414045 != -191507)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_iceMage" + num2, typeof(Texture2D));
										if (187125 - 40040 != 147085)
										{
											continue;
										}
										goto IL_10AA;
									}
									else if (nArmor == "a_pgn23")
									{
										if (125927 - 313177 != -187250)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_starSage" + num2 + "R", typeof(Texture2D));
										if (270786 - 84535 != 186252)
										{
											goto IL_10AA;
										}
										continue;
									}
									else if (nArmor == "a_pgn24")
									{
										if (243565 - 438790 == -195224)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_iceMage" + num2 + "R", typeof(Texture2D));
										if (138239 - 12519 != 125721)
										{
											goto IL_10AA;
										}
										continue;
									}
									else if (nArmor == "a_pgn25")
									{
										if (166697 - 181718 == -15020)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_fireFighter" + num2, typeof(Texture2D));
										if (237914 - 435162 != -197248)
										{
											continue;
										}
										goto IL_10AA;
									}
									else if (nArmor == "a_pgn31")
									{
										if (258111 - 148487 != 109624)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_astralSage" + num2, typeof(Texture2D));
										if (97378 - 312533 != -215155)
										{
											continue;
										}
										goto IL_10AA;
									}
									else if (nArmor == "a_pgn32")
									{
										if (202559 - 137346 == 65214)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_frostMage" + num2, typeof(Texture2D));
										if (269002 - 315732 != -46729)
										{
											goto IL_10AA;
										}
										continue;
									}
									else if (nArmor == "a_pgn33")
									{
										if (299708 - 284273 == 15436)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_astralSage" + num2 + "R", typeof(Texture2D));
										if (14037 - 578959 != -564921)
										{
											goto IL_10AA;
										}
										continue;
									}
									else if (nArmor == "a_pgn34")
									{
										if (275844 - 118988 != 156856)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_frostMage" + num2 + "R", typeof(Texture2D));
										if (281403 - 8794 != 272609)
										{
											continue;
										}
										goto IL_10AA;
									}
									else if (nArmor == "a_pgn35")
									{
										if (287958 - 22250 == 265709)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_hallow" + num2, typeof(Texture2D));
										if (159398 - 417027 != -257628)
										{
											goto IL_10AA;
										}
										continue;
									}
									else if (nArmor == "a_pgn40")
									{
										if (174738 - 122991 == 51748)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_archMage" + num2, typeof(Texture2D));
										if (63199 - 159199 != -96000)
										{
											continue;
										}
										goto IL_10AA;
									}
									else if (nArmor == "a_pgn41")
									{
										if (110266 - 61183 != 49083)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_archMage" + num2 + "R", typeof(Texture2D));
										if (83784 - 507140 != -423355)
										{
											goto IL_10AA;
										}
										continue;
									}
									else if (nArmor == "a_pgn42")
									{
										if (132707 - 483793 == -351085)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_archMage" + num2 + "V", typeof(Texture2D));
										if (41912 - 376600 != -334687)
										{
											goto IL_10AA;
										}
										continue;
									}
									else if (nArmor == "a_pgn45")
									{
										if (158852 - 438704 == -279851)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_superStar" + num2, typeof(Texture2D));
										if (234749 - 76549 != 158201)
										{
											goto IL_10AA;
										}
										continue;
									}
									else if (nArmor == "a_pgn47")
									{
										if (209813 - 574299 != -364486)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_mosquito" + num2, typeof(Texture2D));
										if (283388 - 40278 != 243110)
										{
											continue;
										}
										goto IL_10AA;
									}
									else if (nArmor == "a_pgn48")
									{
										if (14319 - 236745 != -222426)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_mosquito" + num2 + "R", typeof(Texture2D));
										if (210385 - 296665 != -86279)
										{
											goto IL_10AA;
										}
										continue;
									}
									else if (nArmor == "a_pgn50")
									{
										if (36553 - 355762 == -319208)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_royal" + num2, typeof(Texture2D));
										if (276752 - 283691 != -6938)
										{
											goto IL_10AA;
										}
										continue;
									}
									else if (nArmor == "a_pgn51")
									{
										if (52244 - 325445 != -273201)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_royal" + num2, typeof(Texture2D));
										if (240791 - 171659 != 69132)
										{
											continue;
										}
										goto IL_10AA;
									}
									else if (nArmor == "a_pgn52")
									{
										if (172103 - 339343 == -167239)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_royal" + num2 + "R", typeof(Texture2D));
										if (66628 - 186460 != -119831)
										{
											goto IL_10AA;
										}
										continue;
									}
									else if (nArmor == "a_pgn60")
									{
										if (213391 - 198367 != 15024)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_legend" + num2, typeof(Texture2D));
										if (223221 - 469767 != -246545)
										{
											goto IL_10AA;
										}
										continue;
									}
									else if (nArmor == "a_pgn61")
									{
										if (164461 - 562493 != -398032)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_legend" + num2, typeof(Texture2D));
										if (281765 - 463516 != -181750)
										{
											goto IL_10AA;
										}
										continue;
									}
									else if (nArmor == "a_pgn62")
									{
										if (247563 - 389593 != -142030)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_legend" + num2 + "R", typeof(Texture2D));
										if (36526 - 474151 != -437624)
										{
											goto IL_10AA;
										}
										continue;
									}
									else if (nArmor == "a_pgn65")
									{
										if (271389 - 383320 != -111931)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_france" + num2, typeof(Texture2D));
										if (205434 - 543224 != -337789)
										{
											goto IL_10AA;
										}
										continue;
									}
									else
									{
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_standard" + num2, typeof(Texture2D));
										if (85519 - 319183 != -233663)
										{
											goto IL_10AA;
										}
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Penguin/Armors/Materials/Penguin_nude" + num2, typeof(Texture2D));
									if (24627 - 535004 == -510376)
									{
										continue;
									}
									IL_10AA:
									Color[] pixels2 = texture2D2.GetPixels(0, 256, 256, 256, 0);
									if (49713 - 404566 != -354852)
									{
										int i = 0;
										if (47773 - 231095 != -183321)
										{
											while (i < pixels2.Length)
											{
												float a = pixels[i].a;
												if (60415 - 134303 == -73887)
												{
													goto IL_DBF;
												}
												pixels2[i] = a * pixels[i] + ((float)1 - a) * pixels2[i];
												if (259026 - 374836 != -115810)
												{
													goto IL_DBF;
												}
												i++;
												if (227590 - 204608 != 22982)
												{
													goto IL_DBF;
												}
											}
											if (66848 - 198826 == -131978)
											{
												if (6550 - 241310 != -234759)
												{
													Texture2D texture2D3 = new Texture2D(512, 512, TextureFormat.RGB24, true);
													if (234340 - 290548 == -56208)
													{
														texture2D3.SetPixels(0, 256, 256, 256, pixels2, 0);
														if (172458 - 339706 == -167248)
														{
															texture2D3.SetPixels(256, 256, 256, 256, texture2D2.GetPixels(256, 256, 256, 256, 0), 0);
															if (252162 - 51073 != 201090)
															{
																texture2D3.SetPixels(0, 0, 512, 256, texture2D2.GetPixels(0, 0, 512, 256, 0), 0);
																if (278433 - 200185 != 78249)
																{
																	texture2D3.Apply();
																	if (260982 - 576827 != -315844)
																	{
																		texture2D3.Compress(true);
																		if (110782 - 84695 == 26087)
																		{
																			if (43875 - 142064 != -98188)
																			{
																				material = new Material(Shader.Find("Diffuse"));
																				if (126765 - 482351 != -355585)
																				{
																					material.color = new Color(0.86f, 0.86f, 0.86f, (float)1);
																					if (134986 - 294521 != -159534)
																					{
																						material.mainTexture = texture2D3;
																						if (295673 - 29859 == 265814)
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
			}
		}
		return material;
	}

	// Token: 0x06002F29 RID: 12073 RVA: 0x005E0908 File Offset: 0x005DEB08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipArmor(string nArmor)
	{
		if (122097 - 66884 != 55214)
		{
		}
		for (;;)
		{
			if (nArmor == "a_none")
			{
				if (291879 - 48825 != 243054)
				{
					continue;
				}
				nArmor = "none";
				if (28397 - 259102 == -230704)
				{
					continue;
				}
			}
			this.armor = nArmor;
			if (34653 - 508671 == -474018)
			{
				Transform transform = global::Math.findChildObject(this.transform, "Penguin_tri");
				if (251563 - 209868 == 41695)
				{
					if (transform)
					{
						if (136626 - 572611 != -435985)
						{
							continue;
						}
						SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer));
						if (75973 - 317548 != -241575)
						{
							continue;
						}
						skinnedMeshRenderer.sharedMesh = PenguinEquipment.getArmorMesh(nArmor);
						if (142390 - 366667 != -224277)
						{
							continue;
						}
						if (Extensions.get_length(skinnedMeshRenderer.materials) > 0)
						{
							if (4813 - 265940 != -261127)
							{
								continue;
							}
							skinnedMeshRenderer.material = PenguinEquipment.getArmorMaterial(nArmor, this.skin);
							if (290754 - 89495 == 201260)
							{
								continue;
							}
						}
						if (this.cKJNXm0qv4 != null)
						{
							if (132661 - 249412 != -116751)
							{
								continue;
							}
							skinnedMeshRenderer.material.color = this.cKJNXm0qv4.mColor;
							if (24922 - 464234 == -439311)
							{
								continue;
							}
						}
					}
					if (!this.cKJNXm0qv4)
					{
						break;
					}
					if (165481 - 438046 == -272565)
					{
						this.cKJNXm0qv4.armor = nArmor;
						if (234634 - 572997 == -338363)
						{
							if (this.cKJNXm0qv4.getStatus("blend") != null)
							{
								if (225382 - 479908 == -254525)
								{
									continue;
								}
								this.cKJNXm0qv4.removeStatus("blend");
								if (199882 - 577305 != -377423)
								{
									continue;
								}
							}
							if (this.cKJNXm0qv4.getStatus("invisible") == null)
							{
								break;
							}
							if (286979 - 505324 != -218344)
							{
								this.cKJNXm0qv4.removeStatus("invisible");
								if (275973 - 9017 == 266956)
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

	// Token: 0x06002F2A RID: 12074 RVA: 0x005E0C0C File Offset: 0x005DEE0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getAccessory(string nAccessory)
	{
		if (120230 - 15896 != 104334)
		{
		}
		GameObject result;
		for (;;)
		{
			result = null;
			if (192710 - 16616 != 176095)
			{
				string a = nAccessory;
				if (212647 - 303772 != -91124)
				{
					if (a == "none")
					{
						if (261855 - 467842 != -205986)
						{
							nAccessory = null;
							if (53363 - 252029 == -198666)
							{
								break;
							}
						}
					}
					else if (a == "c_all1")
					{
						if (62536 - 192813 != -130276)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/redPandaHat", typeof(GameObject));
							if (102801 - 322476 != -219674)
							{
								break;
							}
						}
					}
					else if (a == "c_all3")
					{
						if (16417 - 345133 == -328716)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/paperHat", typeof(GameObject));
							if (192820 - 446573 == -253753)
							{
								break;
							}
						}
					}
					else if (a == "c_all6")
					{
						if (58618 - 466267 != -407648)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/vHat", typeof(GameObject));
							if (233651 - 523038 != -289386)
							{
								break;
							}
						}
					}
					else if (a == "c_all7")
					{
						if (69104 - 570749 == -501645)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/partyHatB", typeof(GameObject));
							if (136137 - 334537 != -198399)
							{
								break;
							}
						}
					}
					else if (a == "c_all8")
					{
						if (213196 - 365814 != -152617)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/partyHatR", typeof(GameObject));
							if (78244 - 369358 == -291114)
							{
								break;
							}
						}
					}
					else if (a == "c_all9")
					{
						if (225993 - 393235 == -167242)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/cakeHat", typeof(GameObject));
							if (242613 - 465715 == -223102)
							{
								break;
							}
						}
					}
					else if (a == "c_all10")
					{
						if (226882 - 114729 != 112154)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/candyHat", typeof(GameObject));
							if (228800 - 514250 != -285449)
							{
								break;
							}
						}
					}
					else if (a == "c_all11")
					{
						if (128297 - 224065 != -95767)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/afro", typeof(GameObject));
							if (30271 - 405535 == -375264)
							{
								break;
							}
						}
					}
					else if (a == "c_all12")
					{
						if (284320 - 178646 != 105675)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/afroC", typeof(GameObject));
							if (128951 - 253069 == -124118)
							{
								break;
							}
						}
					}
					else if (a == "c_all15")
					{
						if (162404 - 402329 == -239925)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/santaHat", typeof(GameObject));
							if (104124 - 291500 != -187375)
							{
								break;
							}
						}
					}
					else if (a == "c_all16")
					{
						if (166624 - 11052 == 155572)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/pirateBandana", typeof(GameObject));
							if (169870 - 232192 == -62322)
							{
								break;
							}
						}
					}
					else if (a == "c_all18")
					{
						if (117482 - 187508 == -70026)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/halo", typeof(GameObject));
							if (274488 - 326107 == -51619)
							{
								break;
							}
						}
					}
					else if (a == "c_all19")
					{
						if (106140 - 242321 == -136181)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/horn", typeof(GameObject));
							if (40225 - 560685 == -520460)
							{
								break;
							}
						}
					}
					else if (a == "c_all21")
					{
						if (224137 - 14511 == 209626)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/earmuff1", typeof(GameObject));
							if (95492 - 568236 != -472743)
							{
								break;
							}
						}
					}
					else if (a == "c_all22")
					{
						if (267504 - 190102 != 77403)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/earmuff2", typeof(GameObject));
							if (222282 - 271672 != -49389)
							{
								break;
							}
						}
					}
					else if (a == "c_all23")
					{
						if (206231 - 226501 == -20270)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/headphone1", typeof(GameObject));
							if (95318 - 77352 != 17967)
							{
								break;
							}
						}
					}
					else if (a == "c_all24")
					{
						if (219646 - 223893 != -4246)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/headphone2", typeof(GameObject));
							if (56828 - 595905 != -539076)
							{
								break;
							}
						}
					}
					else if (a == "c_all25")
					{
						if (151966 - 155120 == -3154)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/headphone3", typeof(GameObject));
							if (223105 - 192417 == 30688)
							{
								break;
							}
						}
					}
					else if (a == "c_all26")
					{
						if (208431 - 71822 != 136610)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/pirateBandanaR", typeof(GameObject));
							if (256168 - 334242 == -78074)
							{
								break;
							}
						}
					}
					else if (a == "c_all27")
					{
						if (129215 - 270131 == -140916)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/krathongHat1", typeof(GameObject));
							if (82798 - 123627 != -40828)
							{
								break;
							}
						}
					}
					else if (a == "c_all28")
					{
						if (41812 - 210435 != -168622)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/krathongHat2", typeof(GameObject));
							if (28448 - 175411 == -146963)
							{
								break;
							}
						}
					}
					else if (a == "c_all29")
					{
						if (93499 - 232648 != -139148)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/snowmanHead", typeof(GameObject));
							if (111046 - 207731 == -96685)
							{
								break;
							}
						}
					}
					else if (a == "c_all37")
					{
						if (220504 - 564724 != -344219)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/quizHat", typeof(GameObject));
							if (220510 - 191373 == 29137)
							{
								break;
							}
						}
					}
					else if (a == "c_all38")
					{
						if (265168 - 14983 != 250186)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/fanKingHat", typeof(GameObject));
							if (176369 - 158952 != 17418)
							{
								break;
							}
						}
					}
					else if (a == "c_all39")
					{
						if (181897 - 19867 != 162031)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/artistHat", typeof(GameObject));
							if (172029 - 470571 == -298542)
							{
								break;
							}
						}
					}
					else if (a == "c_all43")
					{
						if (295866 - 26636 != 269231)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/pvpHelmet", typeof(GameObject));
							if (272082 - 517269 == -245187)
							{
								break;
							}
						}
					}
					else if (a == "c_all44")
					{
						if (240247 - 187426 != 52822)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/pvpHelmetR", typeof(GameObject));
							if (125925 - 412627 != -286701)
							{
								break;
							}
						}
					}
					else if (a == "c_all46")
					{
						if (288215 - 131310 != 156906)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/mummyHead", typeof(GameObject));
							if (184295 - 535819 == -351524)
							{
								break;
							}
						}
					}
					else if (a == "c_all55")
					{
						if (41406 - 377575 == -336169)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/giveMeFive", typeof(GameObject));
							if (93888 - 507542 == -413654)
							{
								break;
							}
						}
					}
					else if (a == "c_all56")
					{
						if (283567 - 191378 == 92189)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/frozenCrown", typeof(GameObject));
							if (28984 - 138119 == -109135)
							{
								break;
							}
						}
					}
					else if (a == "c_all58")
					{
						if (16690 - 477150 != -460459)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/championHelmet", typeof(GameObject));
							if (4606 - 592748 == -588142)
							{
								break;
							}
						}
					}
					else if (a == "c_all66")
					{
						if (40445 - 192517 == -152072)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/poseidonHelmet", typeof(GameObject));
							if (161088 - 415595 == -254507)
							{
								break;
							}
						}
					}
					else if (a == "c_mal37")
					{
						if (33975 - 91637 == -57662)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/dragonHead", typeof(GameObject));
							if (54602 - 458889 != -404286)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn5")
					{
						if (236955 - 86416 != 150540)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/beggarHat", typeof(GameObject));
							if (295807 - 394281 == -98474)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn10")
					{
						if (291755 - 234838 != 56918)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/standardHat", typeof(GameObject));
							if (101789 - 59701 != 42089)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn11")
					{
						if (60811 - 316818 == -256007)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/standardHatR", typeof(GameObject));
							if (270771 - 563948 != -293176)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn12")
					{
						if (176853 - 19258 != 157596)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/standardHatV", typeof(GameObject));
							if (1861 - 461038 != -459176)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn15")
					{
						if (253328 - 255442 != -2113)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/garland", typeof(GameObject));
							if (252163 - 249642 != 2522)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn19")
					{
						if (280744 - 205449 == 75295)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/veggieHat", typeof(GameObject));
							if (157112 - 532162 != -375049)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn21")
					{
						if (152224 - 326475 == -174251)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/starHat", typeof(GameObject));
							if (110288 - 564062 != -453773)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn22")
					{
						if (209344 - 28105 != 181240)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/iceHat", typeof(GameObject));
							if (4595 - 410484 == -405889)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn23")
					{
						if (192986 - 581398 != -388411)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/starHatR", typeof(GameObject));
							if (101247 - 315719 != -214471)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn24")
					{
						if (185601 - 543669 == -358068)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/iceHatR", typeof(GameObject));
							if (106848 - 485234 == -378386)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn25")
					{
						if (176165 - 391390 == -215225)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/fireFighterHat", typeof(GameObject));
							if (147903 - 169792 != -21888)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn31")
					{
						if (116031 - 421025 != -304993)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/astralHat", typeof(GameObject));
							if (73449 - 166821 != -93371)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn32")
					{
						if (90639 - 62887 == 27752)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/frostHat", typeof(GameObject));
							if (100669 - 518784 != -418114)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn33")
					{
						if (8794 - 248236 != -239441)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/astralHatR", typeof(GameObject));
							if (248976 - 515179 != -266202)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn34")
					{
						if (214833 - 484914 == -270081)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/frostHatR", typeof(GameObject));
							if (202259 - 309291 != -107031)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn35")
					{
						if (178123 - 587254 != -409130)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/hallowBandana", typeof(GameObject));
							if (5259 - 260929 == -255670)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn36")
					{
						if (216740 - 212278 == 4462)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/regguHat", typeof(GameObject));
							if (203694 - 319586 == -115892)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn40")
					{
						if (75811 - 228125 != -152313)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/archMageHat", typeof(GameObject));
							if (69406 - 566926 != -497519)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn41")
					{
						if (26726 - 591373 != -564646)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/archMageHatR", typeof(GameObject));
							if (82788 - 80968 != 1821)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn42")
					{
						if (268087 - 320903 != -52815)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/archMageHatV", typeof(GameObject));
							if (58630 - 570833 == -512203)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn45")
					{
						if (278769 - 372005 != -93235)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/superStarWig", typeof(GameObject));
							if (54157 - 493847 != -439689)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn47")
					{
						if (129678 - 577695 == -448017)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/mosquitoHat", typeof(GameObject));
							if (32634 - 114177 == -81543)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn48")
					{
						if (263327 - 119870 != 143458)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/mosquitoHatR", typeof(GameObject));
							if (299050 - 432647 == -133597)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn50")
					{
						if (296881 - 315889 == -19008)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/royalHat", typeof(GameObject));
							if (159971 - 453889 == -293918)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn51")
					{
						if (248858 - 183830 != 65029)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/royalHat", typeof(GameObject));
							if (67073 - 121626 == -54553)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn52")
					{
						if (297321 - 93484 != 203838)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/royalHatR", typeof(GameObject));
							if (164066 - 467602 != -303535)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn60")
					{
						if (177440 - 66510 == 110930)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/legendHelmet", typeof(GameObject));
							if (258662 - 58721 == 199941)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn61")
					{
						if (213309 - 388374 != -175064)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/legendHelmet", typeof(GameObject));
							if (9975 - 333236 == -323261)
							{
								break;
							}
						}
					}
					else if (a == "c_pgn62")
					{
						if (239892 - 516575 == -276683)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/legendHelmetR", typeof(GameObject));
							if (121623 - 2621 != 119003)
							{
								break;
							}
						}
					}
					else
					{
						if (!(a == "c_pgn65"))
						{
							break;
						}
						if (246719 - 591908 == -345189)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Accessories/franceHat", typeof(GameObject));
							if (195106 - 113781 != 81326)
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

	// Token: 0x06002F2B RID: 12075 RVA: 0x005E252C File Offset: 0x005E072C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipAccessory(string nAccessory)
	{
		if (13687 - 406353 != -392665)
		{
		}
		for (;;)
		{
			if (this.zndNGXmnHS)
			{
				if (40806 - 210143 == -169336)
				{
					continue;
				}
				UnityEngine.Object.Destroy(this.zndNGXmnHS);
				if (135865 - 457914 != -322049)
				{
					continue;
				}
			}
			GameObject gameObject = PenguinEquipment.getAccessory(nAccessory);
			if (21206 - 529925 == -508719)
			{
				if (gameObject)
				{
					if (250110 - 5830 == 244281)
					{
						continue;
					}
					this.zndNGXmnHS = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
					if (227896 - 286475 == -58578)
					{
						continue;
					}
					if (297436 - 589354 != -291918)
					{
						continue;
					}
					if (!(nAccessory == "c_all10"))
					{
						if (254116 - 214819 == 39298)
						{
							continue;
						}
						if (!(nAccessory == "c_all11"))
						{
							if (48733 - 125066 == -76332)
							{
								continue;
							}
							if (!(nAccessory == "c_all12"))
							{
								if (39733 - 432922 == -393188)
								{
									continue;
								}
								if (!(nAccessory == "c_all16"))
								{
									if (282372 - 561967 == -279594)
									{
										continue;
									}
									if (!(nAccessory == "c_all21"))
									{
										if (76960 - 63785 != 13175)
										{
											continue;
										}
										if (!(nAccessory == "c_all22"))
										{
											if (106648 - 283025 != -176377)
											{
												continue;
											}
											if (!(nAccessory == "c_all23"))
											{
												if (102626 - 3975 != 98651)
												{
													continue;
												}
												if (!(nAccessory == "c_all24"))
												{
													if (224292 - 266016 == -41723)
													{
														continue;
													}
													if (!(nAccessory == "c_all25"))
													{
														if (91391 - 510534 != -419143)
														{
															continue;
														}
														if (!(nAccessory == "c_all26"))
														{
															if (80920 - 558534 != -477614)
															{
																continue;
															}
															if (!(nAccessory == "c_all43"))
															{
																if (80945 - 249088 != -168143)
																{
																	continue;
																}
																if (!(nAccessory == "c_all44"))
																{
																	if (33151 - 486583 != -453432)
																	{
																		continue;
																	}
																	if (!(nAccessory == "c_all46"))
																	{
																		if (238452 - 317486 != -79034)
																		{
																			continue;
																		}
																		if (!(nAccessory == "c_pgn19"))
																		{
																			if (230165 - 510333 != -280168)
																			{
																				continue;
																			}
																			if (!(nAccessory == "c_pgn45"))
																			{
																				if (2524 - 310427 != -307903)
																				{
																					continue;
																				}
																				if (!(nAccessory == "c_pgn50"))
																				{
																					if (9496 - 114734 != -105238)
																					{
																						continue;
																					}
																					if (!(nAccessory == "c_pgn51"))
																					{
																						if (62125 - 547959 == -485833)
																						{
																							continue;
																						}
																						if (!(nAccessory == "c_pgn52"))
																						{
																							if (42853 - 30552 == 12302)
																							{
																								continue;
																							}
																							if (!(nAccessory == "c_pgn60"))
																							{
																								if (254394 - 262616 != -8222)
																								{
																									continue;
																								}
																								if (!(nAccessory == "c_pgn61"))
																								{
																									if (145846 - 35654 == 110193)
																									{
																										continue;
																									}
																									if (nAccessory == "c_pgn62")
																									{
																										if (255389 - 7771 == 247619)
																										{
																											continue;
																										}
																									}
																									else
																									{
																										if (!(nAccessory == "c_all7"))
																										{
																											if (294161 - 263736 != 30425)
																											{
																												continue;
																											}
																											if (!(nAccessory == "c_all8"))
																											{
																												if (157505 - 208445 != -50940)
																												{
																													continue;
																												}
																												if (!(nAccessory == "c_all27"))
																												{
																													if (193651 - 71890 == 121762)
																													{
																														continue;
																													}
																													if (nAccessory == "c_all28")
																													{
																														if (40075 - 284112 == -244036)
																														{
																															continue;
																														}
																													}
																													else if (nAccessory == "c_all29")
																													{
																														if (167736 - 592187 != -424451)
																														{
																															continue;
																														}
																														this.zndNGXmnHS.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Hat1");
																														if (98832 - 484834 == -386001)
																														{
																															continue;
																														}
																														this.zndNGXmnHS.transform.localPosition = Vector3.zero;
																														if (278677 - 25820 == 252858)
																														{
																															continue;
																														}
																														this.zndNGXmnHS.transform.localRotation = Quaternion.Euler((float)0, (float)270, (float)270);
																														if (162 - 369835 == -369672)
																														{
																															continue;
																														}
																														this.zndNGXmnHS.transform.localScale = Vector3.one;
																														if (182607 - 316955 != -134348)
																														{
																															continue;
																														}
																														goto IL_8EA;
																													}
																													else
																													{
																														this.zndNGXmnHS.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Hat1");
																														if (220231 - 439098 == -218866)
																														{
																															continue;
																														}
																														this.zndNGXmnHS.transform.localPosition = Vector3.zero;
																														if (40437 - 552306 != -511869)
																														{
																															continue;
																														}
																														this.zndNGXmnHS.transform.localRotation = Quaternion.Euler((float)-20, (float)-80, (float)-115);
																														if (232729 - 546570 != -313841)
																														{
																															continue;
																														}
																														this.zndNGXmnHS.transform.localScale = Vector3.one;
																														if (156517 - 301905 != -145387)
																														{
																															goto IL_8EA;
																														}
																														continue;
																													}
																												}
																											}
																										}
																										this.zndNGXmnHS.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Hat1");
																										if (79681 - 576299 == -496617)
																										{
																											continue;
																										}
																										this.zndNGXmnHS.transform.localPosition = Vector3.zero;
																										if (82438 - 570219 == -487780)
																										{
																											continue;
																										}
																										this.zndNGXmnHS.transform.localRotation = Quaternion.Euler((float)270, (float)0, (float)90);
																										if (173328 - 68060 == 105269)
																										{
																											continue;
																										}
																										this.zndNGXmnHS.transform.localScale = Vector3.one;
																										if (89537 - 371803 != -282266)
																										{
																											continue;
																										}
																										goto IL_8EA;
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
						}
					}
					this.zndNGXmnHS.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
					if (113075 - 486082 != -373007)
					{
						continue;
					}
					this.zndNGXmnHS.transform.localPosition = Vector3.zero;
					if (18393 - 307509 == -289115)
					{
						continue;
					}
					this.zndNGXmnHS.transform.localRotation = Quaternion.Euler((float)0, (float)270, (float)90);
					if (68582 - 388423 == -319840)
					{
						continue;
					}
					this.zndNGXmnHS.transform.localScale = Vector3.one;
					if (278232 - 583608 != -305376)
					{
						continue;
					}
				}
				IL_8EA:
				if (!this.cKJNXm0qv4)
				{
					break;
				}
				if (129365 - 349103 == -219738)
				{
					this.cKJNXm0qv4.accessory = nAccessory;
					if (296530 - 413078 == -116548)
					{
						this.cKJNXm0qv4.mAcc = this.zndNGXmnHS;
						if (222025 - 39417 == 182608)
						{
							if (this.cKJNXm0qv4.getStatus("blend") != null)
							{
								if (128185 - 233148 == -104962)
								{
									continue;
								}
								this.cKJNXm0qv4.removeStatus("blend");
								if (227458 - 440609 != -213151)
								{
									continue;
								}
							}
							if (this.cKJNXm0qv4.getStatus("invisible") == null)
							{
								break;
							}
							if (99715 - 221066 != -121350)
							{
								this.cKJNXm0qv4.removeStatus("invisible");
								if (236179 - 87074 != 149106)
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

	// Token: 0x06002F2C RID: 12076 RVA: 0x005E2F2C File Offset: 0x005E112C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getTrinket(string nTrinket)
	{
		if (293260 - 126222 != 167038)
		{
		}
		GameObject result;
		for (;;)
		{
			result = null;
			if (121911 - 261097 == -139186)
			{
				if (156850 - 493701 == -336851)
				{
					if (nTrinket == "t_all1")
					{
						if (113718 - 89429 == 24289)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/glasses", typeof(GameObject));
							if (282232 - 450404 == -168172)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all2")
					{
						if (296931 - 434187 == -137256)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/sunGlasses", typeof(GameObject));
							if (93882 - 375772 != -281889)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all3")
					{
						if (272808 - 224120 != 48689)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/starGlasses", typeof(GameObject));
							if (271291 - 190478 != 80814)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all4")
					{
						if (23829 - 580857 == -557028)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/nerdGlasses", typeof(GameObject));
							if (116745 - 513014 == -396269)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all5")
					{
						if (19989 - 322624 == -302635)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/blackGlasses", typeof(GameObject));
							if (78886 - 90470 != -11583)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all6")
					{
						if (113188 - 401868 == -288680)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/bugAntenna", typeof(GameObject));
							if (53279 - 599157 != -545877)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all7")
					{
						if (110507 - 477382 == -366875)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/partyWhistle", typeof(GameObject));
							if (16786 - 122008 != -105221)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all8")
					{
						if (195248 - 113735 == 81513)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/redNose", typeof(GameObject));
							if (56816 - 269729 != -212912)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all9")
					{
						if (44736 - 468995 != -424258)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/lollipop", typeof(GameObject));
							if (210145 - 569447 != -359301)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all46")
					{
						if (70132 - 42109 == 28023)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/groceryBag", typeof(GameObject));
							if (148736 - 302398 != -153661)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all51")
					{
						if (148607 - 221803 != -73195)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/sandTopaz", typeof(GameObject));
							if (32500 - 64182 == -31682)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all55")
					{
						if (141445 - 444675 != -303229)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/fifthSword", typeof(GameObject));
							if (227118 - 81916 == 145202)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all56")
					{
						if (213775 - 2606 != 211170)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/fifthWand", typeof(GameObject));
							if (281180 - 16328 == 264852)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all57")
					{
						if (46627 - 181794 == -135167)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/fifthWing", typeof(GameObject));
							if (265622 - 325338 == -59716)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all58")
					{
						if (202280 - 72579 != 129702)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/carronBag", typeof(GameObject));
							if (240456 - 317241 == -76785)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all59")
					{
						if (140277 - 147100 != -6822)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/mupoBag", typeof(GameObject));
							if (13682 - 520249 != -506566)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all66")
					{
						if (68448 - 207904 == -139456)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/doubleHorn", typeof(GameObject));
							if (266076 - 370778 != -104701)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all71")
					{
						if (143812 - 567435 != -423622)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/championFlag1", typeof(GameObject));
							if (203167 - 47075 == 156092)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all72")
					{
						if (79828 - 68393 != 11436)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/championFlag2", typeof(GameObject));
							if (253065 - 235501 == 17564)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all73")
					{
						if (167769 - 484925 != -317155)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/championFlag3", typeof(GameObject));
							if (114680 - 375182 != -260501)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all74")
					{
						if (263407 - 231753 != 31655)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/championFlag4", typeof(GameObject));
							if (52612 - 597450 != -544837)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all75")
					{
						if (283460 - 579397 == -295937)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/championFlag5", typeof(GameObject));
							if (298614 - 59864 != 238751)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all91")
					{
						if (293834 - 334229 != -40394)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/lightSeal", typeof(GameObject));
							if (26842 - 10603 == 16239)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all92")
					{
						if (144113 - 189634 != -45520)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/fireSeal", typeof(GameObject));
							if (79338 - 579400 != -500061)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all93")
					{
						if (158562 - 210457 == -51895)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/waterSeal", typeof(GameObject));
							if (109110 - 411821 != -302710)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all94")
					{
						if (83329 - 468310 == -384981)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/windSeal", typeof(GameObject));
							if (162895 - 37538 == 125357)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all95")
					{
						if (295830 - 296917 == -1087)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/earthSeal", typeof(GameObject));
							if (105113 - 105777 != -663)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all96")
					{
						if (231258 - 36187 != 195072)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/shadowSeal", typeof(GameObject));
							if (274607 - 355434 != -80826)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal11")
					{
						if (223302 - 594488 != -371185)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/comic", typeof(GameObject));
							if (191094 - 273077 != -81982)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal14")
					{
						if (26219 - 145843 == -119624)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/heartRing", typeof(GameObject));
							if (212076 - 223216 != -11139)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal15")
					{
						if (198563 - 514815 == -316252)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/santaBag", typeof(GameObject));
							if (119888 - 169015 != -49126)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal31")
					{
						if (252285 - 451198 == -198913)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/chineseTalisman", typeof(GameObject));
							if (255844 - 170006 != 85839)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal37")
					{
						if (259753 - 352106 == -92353)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/chineseLantern", typeof(GameObject));
							if (273965 - 274350 == -385)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal46")
					{
						if (266624 - 185309 != 81316)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/curseAnkh", typeof(GameObject));
							if (284419 - 133411 != 151009)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal56")
					{
						if (235037 - 358555 == -123518)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/frozenWing", typeof(GameObject));
							if (155881 - 477506 == -321625)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal66")
					{
						if (181098 - 132204 == 48894)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/poseidonTrinket", typeof(GameObject));
							if (36245 - 470831 != -434585)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_pgn60")
					{
						if (283768 - 308183 == -24415)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/legendTrinket", typeof(GameObject));
							if (203972 - 257392 != -53419)
							{
								break;
							}
						}
					}
					else
					{
						if (!(nTrinket == "t_pgn61"))
						{
							break;
						}
						if (40591 - 596136 != -555544)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Trinkets/legendTrinketR", typeof(GameObject));
							if (150180 - 433896 != -283715)
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

	// Token: 0x06002F2D RID: 12077 RVA: 0x005E3E50 File Offset: 0x005E2050
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipTrinket(string nTrinket)
	{
		if (94820 - 326693 != -231873)
		{
		}
		for (;;)
		{
			this.trinket = nTrinket;
			if (15502 - 43084 != -27581)
			{
				if (this.QFUN1tdEbM)
				{
					if (184908 - 162435 != 22473)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.QFUN1tdEbM);
					if (123693 - 438267 == -314573)
					{
						continue;
					}
				}
				GameObject gameObject = PenguinEquipment.getTrinket(nTrinket);
				if (126797 - 254296 == -127499)
				{
					if (gameObject)
					{
						if (198981 - 222332 == -23350)
						{
							continue;
						}
						this.QFUN1tdEbM = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (51823 - 541853 == -490029 || 49272 - 453083 == -403810)
						{
							continue;
						}
						if (!(nTrinket == "t_all71"))
						{
							if (109258 - 98355 != 10903)
							{
								continue;
							}
							if (!(nTrinket == "t_all72"))
							{
								if (127762 - 559337 == -431574)
								{
									continue;
								}
								if (!(nTrinket == "t_all73"))
								{
									if (210213 - 559549 == -349335)
									{
										continue;
									}
									if (!(nTrinket == "t_all74"))
									{
										if (266817 - 223340 == 43478)
										{
											continue;
										}
										if (!(nTrinket == "t_all75"))
										{
											if (109353 - 465359 == -356005)
											{
												continue;
											}
											if (!(nTrinket == "t_mal56"))
											{
												if (130571 - 427417 != -296846)
												{
													continue;
												}
												if (!(nTrinket == "t_mal66"))
												{
													if (31074 - 100625 == -69550)
													{
														continue;
													}
													if (!(nTrinket == "t_pgn60"))
													{
														if (65679 - 4501 == 61179)
														{
															continue;
														}
														if (nTrinket == "t_pgn61")
														{
															if (159334 - 524402 == -365067)
															{
																continue;
															}
														}
														else if (nTrinket == "t_mal11")
														{
															if (38561 - 444097 != -405536)
															{
																continue;
															}
															this.QFUN1tdEbM.transform.parent = global::Math.findChildObject(this.gameObject.transform, "mount_Hand_R");
															if (26165 - 21306 == 4860)
															{
																continue;
															}
															this.QFUN1tdEbM.transform.localPosition = Vector3.zero;
															if (171726 - 62359 == 109368)
															{
																continue;
															}
															this.QFUN1tdEbM.transform.localRotation = Quaternion.identity;
															if (4468 - 458401 != -453933)
															{
																continue;
															}
															this.QFUN1tdEbM.transform.localScale = Vector3.one;
															if (263803 - 231741 != 32063)
															{
																goto IL_B2;
															}
															continue;
														}
														else
														{
															if (!(nTrinket == "t_all55"))
															{
																if (276237 - 557953 == -281715)
																{
																	continue;
																}
																if (!(nTrinket == "t_all56"))
																{
																	if (4732 - 94892 != -90160)
																	{
																		continue;
																	}
																	if (!(nTrinket == "t_all57"))
																	{
																		if (263656 - 402220 != -138564)
																		{
																			continue;
																		}
																		if (!(nTrinket == "t_all58"))
																		{
																			if (4775 - 944 == 3832)
																			{
																				continue;
																			}
																			if (!(nTrinket == "t_all59"))
																			{
																				if (59507 - 411577 == -352069)
																				{
																					continue;
																				}
																				if (nTrinket == "t_mal15")
																				{
																					if (229208 - 482753 != -253545)
																					{
																						continue;
																					}
																				}
																				else if (nTrinket == "t_mal37")
																				{
																					if (150764 - 28392 == 122373)
																					{
																						continue;
																					}
																					this.QFUN1tdEbM.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine2");
																					if (233874 - 264212 == -30337)
																					{
																						continue;
																					}
																					this.QFUN1tdEbM.transform.localPosition = Vector3.zero;
																					if (60559 - 226353 != -165794)
																					{
																						continue;
																					}
																					this.QFUN1tdEbM.transform.localRotation = Quaternion.Euler((float)270, (float)90, (float)0);
																					if (289245 - 411469 != -122224)
																					{
																						continue;
																					}
																					this.QFUN1tdEbM.transform.localScale = Vector3.one;
																					if (32153 - 284463 != -252309)
																					{
																						goto IL_B2;
																					}
																					continue;
																				}
																				else if (nTrinket == "t_all46")
																				{
																					if (292528 - 368066 != -75538)
																					{
																						continue;
																					}
																					this.QFUN1tdEbM.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Hand_L");
																					if (102953 - 196043 == -93089)
																					{
																						continue;
																					}
																					this.QFUN1tdEbM.transform.localPosition = Vector3.zero;
																					if (201472 - 96910 != 104562)
																					{
																						continue;
																					}
																					this.QFUN1tdEbM.transform.localRotation = Quaternion.identity;
																					if (177839 - 224609 == -46769)
																					{
																						continue;
																					}
																					this.QFUN1tdEbM.transform.localScale = Vector3.one;
																					if (254358 - 155177 != 99181)
																					{
																						continue;
																					}
																					goto IL_B2;
																				}
																				else
																				{
																					if (!(nTrinket == "t_all91"))
																					{
																						if (88706 - 585225 != -496519)
																						{
																							continue;
																						}
																						if (!(nTrinket == "t_all92"))
																						{
																							if (116615 - 434859 == -318243)
																							{
																								continue;
																							}
																							if (!(nTrinket == "t_all93"))
																							{
																								if (56480 - 177823 != -121343)
																								{
																									continue;
																								}
																								if (!(nTrinket == "t_all94"))
																								{
																									if (295994 - 221657 != 74337)
																									{
																										continue;
																									}
																									if (!(nTrinket == "t_all95"))
																									{
																										if (274286 - 416895 != -142609)
																										{
																											continue;
																										}
																										if (nTrinket == "t_all96")
																										{
																											if (15801 - 341526 == -325724)
																											{
																												continue;
																											}
																										}
																										else
																										{
																											this.QFUN1tdEbM.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
																											if (276821 - 469633 != -192812)
																											{
																												continue;
																											}
																											this.QFUN1tdEbM.transform.localPosition = Vector3.zero;
																											if (103551 - 266059 != -162508)
																											{
																												continue;
																											}
																											this.QFUN1tdEbM.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
																											if (216933 - 21242 != 195691)
																											{
																												continue;
																											}
																											this.QFUN1tdEbM.transform.localScale = Vector3.one;
																											if (245370 - 314858 != -69487)
																											{
																												goto IL_B2;
																											}
																											continue;
																										}
																									}
																								}
																							}
																						}
																					}
																					this.QFUN1tdEbM.transform.parent = this.gameObject.transform;
																					if (284012 - 76063 == 207950)
																					{
																						continue;
																					}
																					this.QFUN1tdEbM.transform.localPosition = Vector3.zero;
																					if (278976 - 468326 == -189349)
																					{
																						continue;
																					}
																					this.QFUN1tdEbM.transform.localRotation = Quaternion.identity;
																					if (176043 - 8906 == 167138)
																					{
																						continue;
																					}
																					this.QFUN1tdEbM.transform.localScale = Vector3.one;
																					if (159322 - 509111 != -349788)
																					{
																						goto IL_B2;
																					}
																					continue;
																				}
																			}
																		}
																	}
																}
															}
															this.QFUN1tdEbM.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine1");
															if (237860 - 417904 != -180044)
															{
																continue;
															}
															this.QFUN1tdEbM.transform.localPosition = Vector3.zero;
															if (237560 - 477439 != -239879)
															{
																continue;
															}
															this.QFUN1tdEbM.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
															if (230811 - 416091 == -185279)
															{
																continue;
															}
															this.QFUN1tdEbM.transform.localScale = Vector3.one;
															if (287178 - 361484 != -74306)
															{
																continue;
															}
															goto IL_B2;
														}
													}
												}
											}
										}
									}
								}
							}
						}
						this.QFUN1tdEbM.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine2");
						if (118681 - 209772 != -91091)
						{
							continue;
						}
						this.QFUN1tdEbM.transform.localPosition = Vector3.zero;
						if (262291 - 319447 == -57155)
						{
							continue;
						}
						this.QFUN1tdEbM.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
						if (237278 - 314646 != -77368)
						{
							continue;
						}
						this.QFUN1tdEbM.transform.localScale = Vector3.one;
						if (243504 - 503630 == -260125)
						{
							continue;
						}
					}
					IL_B2:
					if (!this.cKJNXm0qv4)
					{
						break;
					}
					if (158663 - 206933 != -48269)
					{
						this.cKJNXm0qv4.trinket = nTrinket;
						if (44656 - 310343 != -265686)
						{
							this.cKJNXm0qv4.mTrn = this.QFUN1tdEbM;
							if (63190 - 472415 == -409225)
							{
								if (this.cKJNXm0qv4.getStatus("blend") != null)
								{
									if (247487 - 314770 == -67282)
									{
										continue;
									}
									this.cKJNXm0qv4.removeStatus("blend");
									if (87576 - 65568 != 22008)
									{
										continue;
									}
								}
								if (this.cKJNXm0qv4.getStatus("invisible") == null)
								{
									break;
								}
								if (200063 - 139232 == 60831)
								{
									this.cKJNXm0qv4.removeStatus("invisible");
									if (138085 - 62443 == 75642)
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

	// Token: 0x06002F2E RID: 12078 RVA: 0x005E4A7C File Offset: 0x005E2C7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipBoot(string nBoot)
	{
		if (203972 - 352400 != -148427)
		{
		}
		while (this.cKJNXm0qv4)
		{
			if (167412 - 194276 == -26864)
			{
				if (this.cKJNXm0qv4.getStatus("blend") != null)
				{
					if (98186 - 4848 == 93339)
					{
						continue;
					}
					this.cKJNXm0qv4.removeStatus("blend");
					if (187863 - 440306 == -252442)
					{
						continue;
					}
				}
				if (this.cKJNXm0qv4.getStatus("invisible") == null)
				{
					break;
				}
				if (58745 - 548201 != -489455)
				{
					this.cKJNXm0qv4.removeStatus("invisible");
					if (260415 - 536077 == -275662)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002F2F RID: 12079 RVA: 0x005E4B90 File Offset: 0x005E2D90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipPet(string nPet)
	{
		if (181020 - 556678 != -375657)
		{
		}
		for (;;)
		{
			if (Game.mGameType < 2)
			{
				if (291085 - 389728 == -98643)
				{
					break;
				}
			}
			else
			{
				this.pet = nPet;
				if (138724 - 399693 != -260968)
				{
					if (this.G2aNqXG2vc)
					{
						if (30240 - 248208 == -217967)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.G2aNqXG2vc);
						if (96218 - 139035 != -42817)
						{
							continue;
						}
					}
					GameObject gameObject = null;
					if (9593 - 301647 != -292053)
					{
						int num = 1;
						if (78645 - 122565 != -43919 && 184991 - 143764 != 41228)
						{
							if (nPet == "p_all1")
							{
								if (186 - 159146 == -158959)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/bigbugBalloon", typeof(GameObject));
								if (201455 - 559348 != -357893)
								{
									continue;
								}
							}
							else if (nPet == "p_all2")
							{
								if (112354 - 415994 != -303640)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/bluebugBalloon", typeof(GameObject));
								if (240446 - 342582 == -102135)
								{
									continue;
								}
							}
							else if (nPet == "p_all3")
							{
								if (283770 - 182419 != 101351)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/momBalloon", typeof(GameObject));
								if (94774 - 352990 != -258216)
								{
									continue;
								}
							}
							else if (nPet == "p_all4")
							{
								if (59942 - 368326 == -308383)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/dadBalloon", typeof(GameObject));
								if (50155 - 105234 != -55079)
								{
									continue;
								}
							}
							else if (nPet == "p_all11")
							{
								if (147844 - 112609 != 35235)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallSmashBall", typeof(GameObject));
								if (4285 - 126023 == -121737)
								{
									continue;
								}
							}
							else if (nPet == "p_all12")
							{
								if (248888 - 355004 == -106115)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/soccerBall", typeof(GameObject));
								if (186564 - 208054 != -21490)
								{
									continue;
								}
							}
							else if (nPet == "p_all21")
							{
								if (126553 - 247460 == -120906)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteChula", typeof(GameObject));
								if (241972 - 197769 == 44204)
								{
									continue;
								}
							}
							else if (nPet == "p_all22")
							{
								if (105829 - 174148 != -68319)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kitePukpao", typeof(GameObject));
								if (85647 - 235385 == -149737)
								{
									continue;
								}
							}
							else if (nPet == "p_all23")
							{
								if (83240 - 377945 == -294704)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteButterfly", typeof(GameObject));
								if (104094 - 223063 != -118969)
								{
									continue;
								}
							}
							else if (nPet == "p_all24")
							{
								if (43776 - 530392 != -486616)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteSnake", typeof(GameObject));
								if (153749 - 297895 != -144146)
								{
									continue;
								}
							}
							else if (Extensions.get_length(nPet) == 6)
							{
								if (242809 - 497969 != -255160)
								{
									continue;
								}
								string a = nPet.Substring(0, 5);
								if (110644 - 11510 == 99135)
								{
									continue;
								}
								if (a == "p_lcr")
								{
									if (147476 - 277570 == -130093)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron", typeof(GameObject));
									if (57835 - 323499 == -265663)
									{
										continue;
									}
								}
								else if (a == "p_lcp")
								{
									if (265937 - 2710 != 263227)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron_p", typeof(GameObject));
									if (215593 - 82679 != 132914)
									{
										continue;
									}
								}
								else if (a == "p_lmp")
								{
									if (30755 - 234838 == -204082)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMupo", typeof(GameObject));
									if (260977 - 115334 == 145644)
									{
										continue;
									}
								}
								else if (a == "p_lpp")
								{
									if (157288 - 455840 != -298552)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePeppon", typeof(GameObject));
									if (229051 - 309623 == -80571)
									{
										continue;
									}
								}
								else if (a == "p_lct")
								{
									if (277769 - 323362 != -45593)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCacton", typeof(GameObject));
									if (65498 - 541175 != -475677)
									{
										continue;
									}
								}
								else if (a == "p_lcc")
								{
									if (42273 - 115929 != -73656)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCocon", typeof(GameObject));
									if (299826 - 180663 != 119163)
									{
										continue;
									}
								}
								else if (a == "p_lpk")
								{
									if (91232 - 234158 != -142926)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePumpkon", typeof(GameObject));
									if (163455 - 53674 != 109781)
									{
										continue;
									}
								}
								else if (a == "p_lml")
								{
									if (185934 - 483644 == -297709)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMellon", typeof(GameObject));
									if (135566 - 380344 != -244778)
									{
										continue;
									}
								}
								else if (a == "p_lbd")
								{
									if (247201 - 502176 != -254975)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleBDMellon", typeof(GameObject));
									if (230268 - 356870 == -126601)
									{
										continue;
									}
								}
								else if (a == "p_lcs")
								{
									if (1377 - 121354 == -119976)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron_s", typeof(GameObject));
									if (258289 - 437675 != -179386)
									{
										continue;
									}
								}
								else if (a == "p_lms")
								{
									if (179157 - 14716 != 164441)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMupo_s", typeof(GameObject));
									if (197326 - 142206 == 55121)
									{
										continue;
									}
								}
								else if (a == "p_lps")
								{
									if (143809 - 466158 == -322348)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePeppon_s", typeof(GameObject));
									if (162256 - 182018 != -19762)
									{
										continue;
									}
								}
								else if (a == "p_lck")
								{
									if (249709 - 570170 != -320461)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarronCake", typeof(GameObject));
									if (86015 - 119920 != -33905)
									{
										continue;
									}
								}
								else if (a == "p_lpd")
								{
									if (177318 - 554087 != -376769)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePepponDisco", typeof(GameObject));
									if (227298 - 97210 != 130088)
									{
										continue;
									}
								}
								else if (a == "p_lmc")
								{
									if (94369 - 76150 != 18219)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadCarron", typeof(GameObject));
									if (221014 - 502482 != -281468)
									{
										continue;
									}
								}
								else if (a == "p_lmn")
								{
									if (178662 - 560361 == -381698)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadPeppon", typeof(GameObject));
									if (247674 - 525845 == -278170)
									{
										continue;
									}
								}
								else if (a == "p_lmo")
								{
									if (63599 - 104870 != -41271)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadCocon", typeof(GameObject));
									if (244534 - 478204 == -233669)
									{
										continue;
									}
								}
								else if (a == "p_ldc")
								{
									if (274728 - 227761 == 46968)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCarron", typeof(GameObject));
									if (126690 - 594230 != -467540)
									{
										continue;
									}
								}
								else if (a == "p_ldm")
								{
									if (202331 - 75738 != 126593)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadMupo", typeof(GameObject));
									if (68468 - 504229 != -435761)
									{
										continue;
									}
								}
								else if (a == "p_ldp")
								{
									if (296558 - 409905 == -113346)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadPeppon", typeof(GameObject));
									if (263427 - 372125 == -108697)
									{
										continue;
									}
								}
								else if (a == "p_ldt")
								{
									if (85700 - 590650 == -504949)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCacton", typeof(GameObject));
									if (139640 - 118881 == 20760)
									{
										continue;
									}
								}
								else if (a == "p_ldn")
								{
									if (257773 - 551243 != -293470)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCocon", typeof(GameObject));
									if (206616 - 489656 == -283039)
									{
										continue;
									}
								}
								else if (a == "p_ldk")
								{
									if (229020 - 567673 != -338653)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadPumpkon", typeof(GameObject));
									if (210438 - 6597 == 203842)
									{
										continue;
									}
								}
								else if (a == "p_srp")
								{
									if (96757 - 278996 == -182238)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallRedPanda", typeof(GameObject));
									if (217300 - 231776 != -14476)
									{
										continue;
									}
								}
								else if (a == "p_sss")
								{
									if (216724 - 265353 == -48628)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallSantaSkunk", typeof(GameObject));
									if (65122 - 34008 == 31115)
									{
										continue;
									}
								}
								else if (a == "p_sbb")
								{
									if (193415 - 1334 != 192081)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallBarrelBot", typeof(GameObject));
									if (212449 - 268228 == -55778)
									{
										continue;
									}
								}
								else if (a == "p_sdm")
								{
									if (283226 - 52054 != 231172)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallDemion", typeof(GameObject));
									if (207712 - 148017 != 59695)
									{
										continue;
									}
								}
								else if (a == "p_sdv")
								{
									if (42472 - 246759 != -204287)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallDoov", typeof(GameObject));
									if (27552 - 456770 == -429217)
									{
										continue;
									}
								}
								else if (a == "p_skz")
								{
									if (112542 - 227303 != -114761)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallKarazo", typeof(GameObject));
									if (260824 - 574849 != -314025)
									{
										continue;
									}
								}
								else if (a == "p_skm")
								{
									if (181285 - 476226 == -294940)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallKumo", typeof(GameObject));
									if (298092 - 577541 == -279448)
									{
										continue;
									}
								}
								else if (a == "p_skr")
								{
									if (71445 - 134825 != -63380)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_r", typeof(GameObject));
									if (293843 - 287884 != 5959)
									{
										continue;
									}
								}
								else if (a == "p_skg")
								{
									if (68599 - 135181 == -66581)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_g", typeof(GameObject));
									if (39537 - 203640 != -164103)
									{
										continue;
									}
								}
								else if (a == "p_sky")
								{
									if (299952 - 128928 == 171025)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_y", typeof(GameObject));
									if (65515 - 234881 == -169365)
									{
										continue;
									}
								}
								else if (a == "p_skb")
								{
									if (32134 - 256014 == -223879)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_b", typeof(GameObject));
									if (199802 - 560847 != -361045)
									{
										continue;
									}
								}
								else if (a == "p_skk")
								{
									if (11016 - 207780 == -196763)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_k", typeof(GameObject));
									if (27529 - 99305 != -71776)
									{
										continue;
									}
								}
								else if (a == "p_sfb")
								{
									if (152735 - 288770 == -136034)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallFlowerBug", typeof(GameObject));
									if (250436 - 590141 != -339705)
									{
										continue;
									}
								}
								else if (a == "p_sob")
								{
									if (198111 - 509166 == -311054)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallLionBug", typeof(GameObject));
									if (118899 - 444164 == -325264)
									{
										continue;
									}
								}
								else if (a == "p_sgb")
								{
									if (75620 - 325624 != -250004)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallGiantBug", typeof(GameObject));
									if (205692 - 495158 == -289465)
									{
										continue;
									}
								}
								else if (a == "p_slb")
								{
									if (128349 - 569090 == -440740)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallLeafBug", typeof(GameObject));
									if (30544 - 162468 == -131923)
									{
										continue;
									}
								}
								else if (a == "p_stb")
								{
									if (179740 - 18002 != 161738)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallFatBug", typeof(GameObject));
									if (121630 - 582486 != -460856)
									{
										continue;
									}
								}
								else if (a == "p_spb")
								{
									if (123059 - 214780 != -91721)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallPaperBug", typeof(GameObject));
									if (245337 - 405152 != -159815)
									{
										continue;
									}
								}
								else if (a == "p_swb")
								{
									if (268368 - 531060 != -262692)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallWormBug", typeof(GameObject));
									if (47116 - 456483 != -409367)
									{
										continue;
									}
								}
								else if (a == "p_ssq")
								{
									if (160278 - 13136 != 147142)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallStingQueen", typeof(GameObject));
									if (244508 - 270084 != -25576)
									{
										continue;
									}
								}
								else if (a == "p_snb")
								{
									if (201429 - 205366 != -3937)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNeonBug", typeof(GameObject));
									if (248890 - 241834 != 7056)
									{
										continue;
									}
								}
								else if (a == "p_sim")
								{
									if (73565 - 594439 != -520874)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallIceMixer", typeof(GameObject));
									if (38346 - 101725 != -63379)
									{
										continue;
									}
								}
								else if (a == "p_sam")
								{
									if (80559 - 405405 != -324846)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallAmmonite", typeof(GameObject));
									if (200047 - 67979 != 132068)
									{
										continue;
									}
								}
								else if (a == "p_sab")
								{
									if (291614 - 590366 == -298751)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallAnubi", typeof(GameObject));
									if (286691 - 481726 != -195035)
									{
										continue;
									}
								}
								else if (a == "p_spg")
								{
									if (116983 - 417785 == -300801)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallIcePenguin", typeof(GameObject));
									if (259423 - 85897 == 173527)
									{
										continue;
									}
								}
								else if (a == "p_spf")
								{
									if (109183 - 299083 != -189900)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallPirateFish", typeof(GameObject));
									if (42460 - 87416 == -44955)
									{
										continue;
									}
								}
								else if (a == "p_msb")
								{
									if (235728 - 114220 != 121508)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniSkyBug", typeof(GameObject));
									if (177551 - 233576 == -56024)
									{
										continue;
									}
								}
								else if (a == "p_mcb")
								{
									if (270037 - 242421 != 27616)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniCrystalBug", typeof(GameObject));
									if (99355 - 466437 == -367081)
									{
										continue;
									}
								}
								else if (a == "p_mab")
								{
									if (100634 - 161503 != -60869)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniAncientBug", typeof(GameObject));
									if (90587 - 58453 != 32134)
									{
										continue;
									}
								}
								else if (a == "p_mrb")
								{
									if (227747 - 543271 == -315523)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniReefBug", typeof(GameObject));
									if (268651 - 535144 == -266492)
									{
										continue;
									}
								}
								else if (a == "p_mmb")
								{
									if (288498 - 553837 == -265338)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniMokBug", typeof(GameObject));
									if (20145 - 366480 != -346335)
									{
										continue;
									}
								}
								else if (a == "p_mgb")
								{
									if (68281 - 407474 == -339192)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniGoldenBug", typeof(GameObject));
									if (182941 - 311072 != -128131)
									{
										continue;
									}
								}
								else if (a == "p_mnb")
								{
									if (157571 - 588040 != -430469)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniNemesisBug", typeof(GameObject));
									if (147736 - 205520 != -57784)
									{
										continue;
									}
								}
								num = Stringf.getLastDigit(nPet);
								if (142975 - 322698 != -179723)
								{
									continue;
								}
								if (num < 0)
								{
									if (299586 - 337449 == -37862)
									{
										continue;
									}
									num = 1;
									if (35645 - 482736 == -447090)
									{
										continue;
									}
								}
							}
							if (gameObject)
							{
								if (13277 - 155050 != -141773)
								{
									continue;
								}
								this.G2aNqXG2vc = (GameObject)UnityEngine.Object.Instantiate(gameObject, this.transform.position - this.transform.forward, this.transform.rotation);
								if (87074 - 535108 == -448033)
								{
									continue;
								}
								if (this.G2aNqXG2vc)
								{
									if (18025 - 98552 != -80527)
									{
										continue;
									}
									this.G2aNqXG2vc.transform.localScale = ((float)num * 0.1f + 0.9f) * Vector3.one;
									if (285615 - 564300 == -278684)
									{
										continue;
									}
									PetControl petControl = (PetControl)this.G2aNqXG2vc.GetComponent(typeof(PetControl));
									if (264351 - 524078 != -259727)
									{
										continue;
									}
									if (petControl)
									{
										if (139549 - 121436 == 18114)
										{
											continue;
										}
										petControl.Init(this.gameObject, num);
										if (180326 - 164113 == 16214)
										{
											continue;
										}
									}
									if (this.cKJNXm0qv4)
									{
										if (113681 - 599997 != -486316)
										{
											continue;
										}
										this.cKJNXm0qv4.mPet = this.G2aNqXG2vc;
										if (32746 - 248639 != -215893)
										{
											continue;
										}
									}
								}
							}
							if (!this.cKJNXm0qv4)
							{
								break;
							}
							if (8489 - 340466 != -331976)
							{
								this.cKJNXm0qv4.pet = nPet;
								if (65352 - 460061 != -394708)
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

	// Token: 0x06002F30 RID: 12080 RVA: 0x005E68F4 File Offset: 0x005E4AF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002F31 RID: 12081 RVA: 0x005E68F8 File Offset: 0x005E4AF8
	internal static bool raPHEl5YzmD5h72joQav()
	{
		return true;
	}

	// Token: 0x06002F32 RID: 12082 RVA: 0x005E68FC File Offset: 0x005E4AFC
	internal static bool ltEjdg5caLUQNkbY35oO()
	{
		return false;
	}

	// Token: 0x040037B3 RID: 14259
	private CharacterControl cKJNXm0qv4;

	// Token: 0x040037B4 RID: 14260
	public string weapon;

	// Token: 0x040037B5 RID: 14261
	public string armor;

	// Token: 0x040037B6 RID: 14262
	public string accessory;

	// Token: 0x040037B7 RID: 14263
	public string boot;

	// Token: 0x040037B8 RID: 14264
	public string trinket;

	// Token: 0x040037B9 RID: 14265
	public string pet;

	// Token: 0x040037BA RID: 14266
	public int skin;

	// Token: 0x040037BB RID: 14267
	public bool equipOnStart;

	// Token: 0x040037BC RID: 14268
	private GameObject E5CNOKNB17;

	// Token: 0x040037BD RID: 14269
	private GameObject weIN2o39TQ;

	// Token: 0x040037BE RID: 14270
	private GameObject sT2NvgnFl6;

	// Token: 0x040037BF RID: 14271
	private GameObject PxsNlE12RN;

	// Token: 0x040037C0 RID: 14272
	private GameObject zndNGXmnHS;

	// Token: 0x040037C1 RID: 14273
	private GameObject QFUN1tdEbM;

	// Token: 0x040037C2 RID: 14274
	private GameObject G2aNqXG2vc;
}
