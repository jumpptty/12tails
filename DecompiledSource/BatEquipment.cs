using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020004ED RID: 1261
[Serializable]
public class BatEquipment : MonoBehaviour
{
	// Token: 0x06001CE2 RID: 7394 RVA: 0x003078B4 File Offset: 0x00305AB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BatEquipment()
	{
		if (3914 - 463750 != -459836)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (293941 - 151972 == 141969)
			{
				base..ctor();
				if (220339 - 538617 != -318277)
				{
					this.weapon = "default";
					if (164081 - 71800 != 92282)
					{
						this.armor = "default";
						if (69483 - 352953 == -283470)
						{
							this.accessory = "default";
							if (21969 - 298759 == -276790)
							{
								this.boot = "default";
								if (30060 - 563953 != -533892)
								{
									this.trinket = "default";
									if (16107 - 83011 != -66903)
									{
										this.pet = "default";
										if (282696 - 24098 != 258599)
										{
											this.skin = 100;
											if (194372 - 325550 != -131177)
											{
												this.equipOnStart = true;
												if (152752 - 482368 == -329616)
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

	// Token: 0x06001CE3 RID: 7395 RVA: 0x00307A4C File Offset: 0x00305C4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.vn7GZjHm2P = (CharacterControl)this.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x06001CE4 RID: 7396 RVA: 0x00307A6C File Offset: 0x00305C6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (this.equipOnStart)
		{
			this.EquipAll();
		}
	}

	// Token: 0x06001CE5 RID: 7397 RVA: 0x00307A80 File Offset: 0x00305C80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipAll()
	{
		if (170818 - 361654 != -190836)
		{
		}
		for (;;)
		{
			this.EquipWeapon(this.weapon);
			if (201340 - 88480 == 112860)
			{
				this.EquipArmor(this.armor);
				if (230228 - 50479 == 179749)
				{
					this.EquipAccessory(this.accessory);
					if (16558 - 284086 != -267527)
					{
						this.EquipBoot(this.boot);
						if (967 - 10629 != -9661)
						{
							this.EquipTrinket(this.trinket);
							if (190698 - 133281 == 57417)
							{
								this.EquipPet(this.pet);
								if (119340 - 46352 != 72989)
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

	// Token: 0x06001CE6 RID: 7398 RVA: 0x00307B9C File Offset: 0x00305D9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipMChar()
	{
		if (98940 - 527299 != -428358)
		{
		}
		for (;;)
		{
			this.vn7GZjHm2P = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (120178 - 218800 == -98622)
			{
				if (!this.vn7GZjHm2P)
				{
					break;
				}
				if (110844 - 194043 != -83198)
				{
					this.weapon = this.vn7GZjHm2P.weapon;
					if (37675 - 480814 == -443139)
					{
						this.armor = this.vn7GZjHm2P.armor;
						if (78447 - 195015 == -116568)
						{
							this.boot = this.vn7GZjHm2P.boot;
							if (150065 - 174381 == -24316)
							{
								this.accessory = this.vn7GZjHm2P.accessory;
								if (11826 - 584401 == -572575)
								{
									this.trinket = this.vn7GZjHm2P.trinket;
									if (25821 - 376194 == -350373)
									{
										this.pet = this.vn7GZjHm2P.pet;
										if (239122 - 371665 == -132543)
										{
											this.skin = this.vn7GZjHm2P.Skin;
											if (143165 - 523098 != -379932)
											{
												this.EquipAll();
												if (109814 - 264829 == -155015)
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

	// Token: 0x06001CE7 RID: 7399 RVA: 0x00307D80 File Offset: 0x00305F80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipCDat(object slot)
	{
		if (43183 - 181718 != -138535)
		{
		}
		for (;;)
		{
			CharacterDataClass cdat = CharacterData.getCDat(RuntimeServices.UnboxInt32(slot));
			if (193328 - 179222 != 14107)
			{
				if (cdat.Type == "Bat")
				{
					if (82300 - 97839 != -15538)
					{
						this.weapon = cdat.equipment[0].name;
						if (58052 - 378924 == -320872)
						{
							this.armor = cdat.equipment[1].name;
							if (151049 - 593994 != -442944)
							{
								this.accessory = cdat.equipment[2].name;
								if (84442 - 531975 != -447532)
								{
									this.boot = cdat.equipment[3].name;
									if (289466 - 471365 == -181899)
									{
										this.trinket = cdat.equipment[4].name;
										if (145192 - 363993 == -218801)
										{
											this.pet = cdat.equipment[5].name;
											if (215142 - 531095 == -315953)
											{
												this.skin = cdat.Skin;
												if (234076 - 460332 != -226255)
												{
													this.EquipAll();
													if (183891 - 411768 == -227877)
													{
														if (!this.vn7GZjHm2P)
														{
															break;
														}
														if (291253 - 137212 != 154042)
														{
															this.vn7GZjHm2P.weapon = this.weapon;
															if (101717 - 538872 != -437154)
															{
																this.vn7GZjHm2P.armor = this.armor;
																if (101477 - 235337 == -133860)
																{
																	this.vn7GZjHm2P.boot = this.boot;
																	if (18754 - 317562 == -298808)
																	{
																		this.vn7GZjHm2P.accessory = this.accessory;
																		if (205721 - 428424 == -222703)
																		{
																			this.vn7GZjHm2P.trinket = this.trinket;
																			if (2066 - 477929 == -475863)
																			{
																				this.vn7GZjHm2P.pet = this.pet;
																				if (62213 - 108793 != -46579)
																				{
																					this.vn7GZjHm2P.Skin = this.skin;
																					if (276030 - 251378 == 24652)
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
					if (155204 - 116940 != 38265)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001CE8 RID: 7400 RVA: 0x003080E4 File Offset: 0x003062E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSkin(int nSkin)
	{
		if (25044 - 510599 != -485554)
		{
		}
		do
		{
			if (100 <= nSkin)
			{
				if (128677 - 302088 != -173411)
				{
					continue;
				}
				if (nSkin <= 599)
				{
					if (276688 - 559509 != -282821)
					{
						continue;
					}
					this.skin = nSkin;
					if (58519 - 4279 == 54241)
					{
						continue;
					}
					if (!this.vn7GZjHm2P)
					{
						break;
					}
					if (100023 - 62667 == 37357)
					{
						continue;
					}
					this.vn7GZjHm2P.Skin = nSkin;
					if (144310 - 593157 != -448847)
					{
						continue;
					}
					break;
				}
			}
			Debug.Log("Equip Error: Wrong Skin Number");
		}
		while (12960 - 207242 == -194281);
	}

	// Token: 0x06001CE9 RID: 7401 RVA: 0x00308200 File Offset: 0x00306400
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSkinColor(int nSkin)
	{
		if (91288 - 382167 != -290878)
		{
		}
		do
		{
			if (100 <= nSkin)
			{
				if (84985 - 128069 != -43084)
				{
					continue;
				}
				if (nSkin <= 599)
				{
					if (259302 - 449102 != -189800)
					{
						continue;
					}
					this.skin = nSkin;
					if (67989 - 482707 != -414718)
					{
						continue;
					}
					if (this.vn7GZjHm2P)
					{
						if (209705 - 406047 != -196342)
						{
							continue;
						}
						this.vn7GZjHm2P.Skin = nSkin;
						if (36811 - 140161 != -103350)
						{
							continue;
						}
					}
					this.EquipArmor(this.armor);
					if (78951 - 39774 != 39178)
					{
						break;
					}
					continue;
				}
			}
			Debug.Log("Equip Error: Wrong Skin Number");
		}
		while (126292 - 496222 == -369929);
	}

	// Token: 0x06001CEA RID: 7402 RVA: 0x00308340 File Offset: 0x00306540
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getWeapon(string nWeapon)
	{
		if (184219 - 275424 != -91205)
		{
		}
		GameObject result;
		for (;;)
		{
			if (60548 - 124902 != -64353 && 65445 - 216457 != -151011)
			{
				if (nWeapon == "w_bat1")
				{
					if (236324 - 136285 != 100040)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/noviceWand", typeof(GameObject));
						if (215262 - 116990 == 98272)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat2")
				{
					if (240019 - 593836 != -353816)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/commonWand", typeof(GameObject));
						if (49679 - 260138 == -210459)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat3")
				{
					if (73221 - 116278 != -43056)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/paperWand", typeof(GameObject));
						if (120660 - 313915 == -193255)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat5")
				{
					if (231234 - 49588 != 181647)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/bathBrush", typeof(GameObject));
						if (43460 - 259021 == -215561)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat10")
				{
					if (10154 - 366219 != -356064)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/standardWand", typeof(GameObject));
						if (268618 - 449773 == -181155)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat11")
				{
					if (223295 - 370925 != -147629)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/standardWandR", typeof(GameObject));
						if (36800 - 592724 != -555923)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat12")
				{
					if (280881 - 469452 != -188570)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/standardWandV", typeof(GameObject));
						if (33105 - 332978 != -299872)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat14")
				{
					if (132475 - 344256 != -211780)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/heartWand", typeof(GameObject));
						if (200169 - 314552 == -114383)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat15")
				{
					if (220619 - 250001 != -29381)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/batWand", typeof(GameObject));
						if (178297 - 117261 != 61037)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat19")
				{
					if (52417 - 358140 != -305722)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/bdWeapon", typeof(GameObject));
						if (247509 - 94045 == 153464)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat21")
				{
					if (225770 - 439038 == -213268)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/warlockWand", typeof(GameObject));
						if (240155 - 181495 == 58660)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat22")
				{
					if (89230 - 579484 != -490253)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/illusionWand", typeof(GameObject));
						if (45502 - 185768 != -140265)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat23")
				{
					if (71082 - 438818 != -367735)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/warlockWandR", typeof(GameObject));
						if (209440 - 485262 == -275822)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat24")
				{
					if (43647 - 190137 == -146490)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/illusionWandR", typeof(GameObject));
						if (47046 - 588656 == -541610)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat25")
				{
					if (74914 - 142726 == -67812)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/teacherStick", typeof(GameObject));
						if (214697 - 531208 == -316511)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat31")
				{
					if (102938 - 173688 == -70750)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/shadowWand", typeof(GameObject));
						if (252065 - 138484 == 113581)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat32")
				{
					if (117671 - 278374 == -160703)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/dreamWand", typeof(GameObject));
						if (207925 - 357403 == -149478)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat33")
				{
					if (13807 - 498058 == -484251)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/shadowWandR", typeof(GameObject));
						if (29962 - 188185 == -158223)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat34")
				{
					if (297223 - 260341 == 36882)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/dreamWandR", typeof(GameObject));
						if (288501 - 1153 != 287349)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat35")
				{
					if (81354 - 117987 == -36633)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/hallowCandle", typeof(GameObject));
						if (140282 - 194913 == -54631)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat36")
				{
					if (134886 - 403586 == -268700)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/lizaWhip", typeof(GameObject));
						if (292951 - 206720 == 86231)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat39")
				{
					if (289760 - 557415 != -267654)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/pinkLatern", typeof(GameObject));
						if (41330 - 481464 != -440133)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat40")
				{
					if (224627 - 432711 == -208084)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/queenWand", typeof(GameObject));
						if (6168 - 485812 != -479643)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat41")
				{
					if (98249 - 178459 == -80210)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/queenWandR", typeof(GameObject));
						if (139277 - 346476 == -207199)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat42")
				{
					if (105216 - 532622 == -427406)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/queenWandV", typeof(GameObject));
						if (253959 - 467585 == -213626)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat43")
				{
					if (161974 - 532883 != -370908)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/pvpWand", typeof(GameObject));
						if (134062 - 166149 != -32086)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat44")
				{
					if (177604 - 503584 != -325979)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/pvpWandR", typeof(GameObject));
						if (110269 - 438635 == -328366)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat45")
				{
					if (145716 - 543640 == -397924)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/starMicrophone", typeof(GameObject));
						if (276108 - 199151 != 76958)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat46")
				{
					if (85910 - 162284 != -76373)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/mummyWand", typeof(GameObject));
						if (229842 - 578682 == -348840)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat47")
				{
					if (254108 - 43173 != 210936)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/butterflyWand", typeof(GameObject));
						if (143529 - 49789 == 93740)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat48")
				{
					if (184096 - 124358 != 59739)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/butterflyWandR", typeof(GameObject));
						if (92637 - 42005 == 50632)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat49")
				{
					if (197276 - 304244 != -106967)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/goldenWand", typeof(GameObject));
						if (174231 - 309031 == -134800)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat50")
				{
					if (53014 - 493828 != -440813)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/royalWand", typeof(GameObject));
						if (180561 - 223461 == -42900)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat51")
				{
					if (292217 - 450910 != -158692)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/royalWand", typeof(GameObject));
						if (82422 - 226008 != -143585)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat52")
				{
					if (26363 - 591917 == -565554)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/royalWandR", typeof(GameObject));
						if (183182 - 267970 == -84788)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat56")
				{
					if (180801 - 302024 == -121223)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/frozenWand", typeof(GameObject));
						if (187553 - 298892 != -111338)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat58")
				{
					if (270857 - 63245 != 207613)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/championRapier", typeof(GameObject));
						if (269024 - 36253 != 232772)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat59")
				{
					if (65437 - 206507 == -141070)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/specialWand", typeof(GameObject));
						if (210618 - 144338 == 66280)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat60")
				{
					if (149660 - 72159 == 77501)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/legendWand", typeof(GameObject));
						if (82775 - 352030 == -269255)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat61")
				{
					if (47696 - 290134 == -242438)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/legendWand", typeof(GameObject));
						if (240881 - 298270 != -57388)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat62")
				{
					if (140569 - 489359 != -348789)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/legendWandR", typeof(GameObject));
						if (32491 - 567276 == -534785)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat65")
				{
					if (56429 - 534882 != -478452)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/japanWagasa", typeof(GameObject));
						if (171449 - 359075 != -187625)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat66")
				{
					if (296069 - 4780 == 291289)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/poseidonWand", typeof(GameObject));
						if (193178 - 270362 != -77183)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat69")
				{
					if (6462 - 234621 != -228158)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/timeWand", typeof(GameObject));
						if (132414 - 249490 == -117076)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat79")
				{
					if (184444 - 71355 == 113089)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/eclipseWand", typeof(GameObject));
						if (32934 - 388036 == -355102)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat81")
				{
					if (164124 - 160243 != 3882)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/flamingWand", typeof(GameObject));
						if (162306 - 250834 == -88528)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat82")
				{
					if (196994 - 78639 == 118355)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/flamingBaton", typeof(GameObject));
						if (129711 - 56137 != 73575)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat83")
				{
					if (241370 - 516033 != -274662)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/flamingRod", typeof(GameObject));
						if (71893 - 118885 != -46991)
						{
							break;
						}
					}
				}
				else if (nWeapon == "w_bat84")
				{
					if (292789 - 34910 == 257879)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/flamingLance", typeof(GameObject));
						if (254530 - 543022 == -288492)
						{
							break;
						}
					}
				}
				else
				{
					result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Weapons/standardWand", typeof(GameObject));
					if (50746 - 249803 == -199057)
					{
						break;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06001CEB RID: 7403 RVA: 0x003096E0 File Offset: 0x003078E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipWeapon(string nWeapon)
	{
		if (65596 - 69279 != -3682)
		{
		}
		for (;;)
		{
			this.weapon = nWeapon;
			if (264672 - 64377 == 200295)
			{
				if (this.S4RGCiXMMu)
				{
					if (241731 - 591303 == -349571)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.S4RGCiXMMu);
					if (191007 - 198837 == -7829)
					{
						continue;
					}
				}
				GameObject gameObject = BatEquipment.getWeapon(nWeapon);
				if (240728 - 371422 == -130694)
				{
					if (gameObject)
					{
						if (103189 - 477877 == -374687)
						{
							continue;
						}
						this.S4RGCiXMMu = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (46988 - 404 != 46584)
						{
							continue;
						}
						this.S4RGCiXMMu.transform.parent = global::Math.findChildObject(this.gameObject.transform, "mount_Hand_L");
						if (91570 - 380142 != -288572)
						{
							continue;
						}
						this.S4RGCiXMMu.transform.localPosition = Vector3.zero;
						if (277988 - 440916 != -162928)
						{
							continue;
						}
						this.S4RGCiXMMu.transform.localRotation = Quaternion.identity;
						if (65739 - 257957 != -192218)
						{
							continue;
						}
					}
					if (!this.vn7GZjHm2P)
					{
						break;
					}
					if (237300 - 123880 != 113421)
					{
						this.vn7GZjHm2P.weapon = nWeapon;
						if (274448 - 509391 != -234942)
						{
							this.vn7GZjHm2P.mWep1 = this.S4RGCiXMMu;
							if (11024 - 262785 != -251760)
							{
								if (this.vn7GZjHm2P.getStatus("blend") != null)
								{
									if (297621 - 429961 == -132339)
									{
										continue;
									}
									this.vn7GZjHm2P.removeStatus("blend");
									if (110545 - 225981 == -115435)
									{
										continue;
									}
								}
								if (this.vn7GZjHm2P.getStatus("invisible") == null)
								{
									break;
								}
								if (112539 - 356941 != -244401)
								{
									this.vn7GZjHm2P.removeStatus("invisible");
									if (32455 - 147511 == -115056)
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

	// Token: 0x06001CEC RID: 7404 RVA: 0x003099D0 File Offset: 0x00307BD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Mesh getArmorMesh(string nArmor)
	{
		if (14114 - 514492 != -500378)
		{
		}
		SkinnedMeshRenderer skinnedMeshRenderer;
		for (;;)
		{
			if (261990 - 320911 == -58921)
			{
				if (231415 - 372600 != -141184)
				{
					GameObject gameObject;
					if (nArmor == "none")
					{
						if (260428 - 502510 != -242081)
						{
							goto IL_962;
						}
						continue;
					}
					else if (nArmor == "a_none")
					{
						if (109954 - 208164 != -98210)
						{
							continue;
						}
						goto IL_962;
					}
					else if (nArmor == "a_all1")
					{
						if (199332 - 455810 != -256478)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_scout", typeof(GameObject));
						if (82769 - 100349 == -17579)
						{
							continue;
						}
					}
					else if (nArmor == "a_all15")
					{
						if (157105 - 474959 == -317853)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_santa", typeof(GameObject));
						if (177308 - 340017 == -162708)
						{
							continue;
						}
					}
					else if (nArmor == "a_all43")
					{
						if (133492 - 327826 == -194333)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_pvpArmor", typeof(GameObject));
						if (151991 - 448273 != -296282)
						{
							continue;
						}
					}
					else if (nArmor == "a_all44")
					{
						if (267693 - 591137 != -323444)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_pvpArmor", typeof(GameObject));
						if (31421 - 323943 == -292521)
						{
							continue;
						}
					}
					else if (nArmor == "a_all58")
					{
						if (20134 - 324199 != -304065)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_champion", typeof(GameObject));
						if (28068 - 273424 != -245356)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat2")
					{
						if (102616 - 516714 == -414097)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_shirt", typeof(GameObject));
						if (194322 - 287388 != -93066)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat5")
					{
						if (73835 - 20032 == 53804)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_bathRobe", typeof(GameObject));
						if (223990 - 329032 != -105042)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat10")
					{
						if (55096 - 325989 != -270893)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_standard", typeof(GameObject));
						if (119333 - 197666 == -78332)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat11")
					{
						if (90922 - 328789 == -237866)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_standard", typeof(GameObject));
						if (269402 - 62306 == 207097)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat12")
					{
						if (23954 - 559251 != -535297)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_standard", typeof(GameObject));
						if (111400 - 456869 == -345468)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat15")
					{
						if (41179 - 6352 != 34827)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_summer", typeof(GameObject));
						if (149782 - 159216 != -9434)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat21")
					{
						if (39846 - 509768 != -469922)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_warlock", typeof(GameObject));
						if (157741 - 377015 != -219274)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat22")
					{
						if (134594 - 105230 == 29365)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_illusionist", typeof(GameObject));
						if (154226 - 85281 == 68946)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat23")
					{
						if (53438 - 275717 == -222278)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_warlock", typeof(GameObject));
						if (146512 - 372701 == -226188)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat24")
					{
						if (121238 - 100940 != 20298)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_illusionist", typeof(GameObject));
						if (217280 - 277763 != -60483)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat25")
					{
						if (73725 - 475368 != -401643)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_teacher", typeof(GameObject));
						if (64140 - 156477 != -92337)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat31")
					{
						if (96042 - 439718 == -343675)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_shadowCaller", typeof(GameObject));
						if (199102 - 224372 != -25270)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat32")
					{
						if (292041 - 234629 == 57413)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_dreamCaster", typeof(GameObject));
						if (121607 - 119528 != 2079)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat33")
					{
						if (229717 - 334562 != -104845)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_shadowCaller", typeof(GameObject));
						if (147973 - 321769 == -173795)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat34")
					{
						if (89381 - 64689 != 24692)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_dreamCaster", typeof(GameObject));
						if (289537 - 349378 != -59841)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat35")
					{
						if (161119 - 557192 == -396072)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_hallow", typeof(GameObject));
						if (159520 - 545681 != -386161)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat40")
					{
						if (289860 - 301514 != -11654)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_queen", typeof(GameObject));
						if (18822 - 107971 != -89149)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat41")
					{
						if (139124 - 60855 != 78269)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_queen", typeof(GameObject));
						if (192350 - 46192 != 146158)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat42")
					{
						if (83311 - 597705 != -514394)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_queen", typeof(GameObject));
						if (266495 - 58957 == 207539)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat45")
					{
						if (35950 - 438340 != -402390)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_superStar", typeof(GameObject));
						if (102207 - 88796 != 13411)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat47")
					{
						if (104034 - 420501 != -316467)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_butterfly", typeof(GameObject));
						if (126204 - 9644 != 116560)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat48")
					{
						if (43207 - 451684 != -408477)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_butterfly", typeof(GameObject));
						if (262810 - 121496 == 141315)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat50")
					{
						if (83132 - 431668 == -348535)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_royal", typeof(GameObject));
						if (188466 - 230319 == -41852)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat51")
					{
						if (116712 - 213483 != -96771)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_royal", typeof(GameObject));
						if (169233 - 120813 == 48421)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat52")
					{
						if (24330 - 470270 != -445940)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_royal", typeof(GameObject));
						if (269351 - 546562 != -277211)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat60")
					{
						if (76662 - 232544 == -155881)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_legend", typeof(GameObject));
						if (17831 - 47794 == -29962)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat61")
					{
						if (215268 - 5963 != 209305)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_legend", typeof(GameObject));
						if (51251 - 30627 == 20625)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat62")
					{
						if (10886 - 455683 == -444796)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_legend", typeof(GameObject));
						if (174775 - 481296 == -306520)
						{
							continue;
						}
					}
					else if (nArmor == "a_bat65")
					{
						if (96941 - 542751 == -445809)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_japan", typeof(GameObject));
						if (270792 - 292921 != -22129)
						{
							continue;
						}
					}
					else
					{
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_standard", typeof(GameObject));
						if (238750 - 413738 == -174987)
						{
							continue;
						}
					}
					IL_1F:
					skinnedMeshRenderer = (SkinnedMeshRenderer)gameObject.GetComponent(typeof(SkinnedMeshRenderer));
					if (26876 - 3926 != 22951)
					{
						break;
					}
					continue;
					IL_962:
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Bat_nude", typeof(GameObject));
					if (295250 - 18669 == 276581)
					{
						goto IL_1F;
					}
				}
			}
		}
		return skinnedMeshRenderer.sharedMesh;
	}

	// Token: 0x06001CED RID: 7405 RVA: 0x0030A868 File Offset: 0x00308A68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Material getArmorMaterial(string nArmor, int nSkin)
	{
		if (112317 - 535261 != -422943)
		{
		}
		Material material;
		for (;;)
		{
			IL_BBE:
			int num = nSkin % 100;
			if (37276 - 303457 == -266181)
			{
				Texture2D texture2D = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Overlay/Bat" + num, typeof(Texture2D));
				if (88887 - 110881 != -21993)
				{
					Color[] pixels = texture2D.GetPixels(0);
					if (41277 - 391926 != -350648)
					{
						int num2 = global::Math.div((float)nSkin, (float)100);
						if (203358 - 165676 == 37682)
						{
							if (84294 - 395314 != -311019 && 210172 - 317784 != -107611)
							{
								Texture2D texture2D2;
								if (nArmor == "none")
								{
									if (136126 - 2645 != 133482)
									{
										goto IL_BDD;
									}
									continue;
								}
								else if (nArmor == "a_none")
								{
									if (111262 - 230656 != -119393)
									{
										goto IL_BDD;
									}
									continue;
								}
								else if (nArmor == "a_all1")
								{
									if (191874 - 234974 == -43099)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_scout" + num2, typeof(Texture2D));
									if (282271 - 336572 == -54300)
									{
										continue;
									}
								}
								else if (nArmor == "a_all15")
								{
									if (108963 - 200714 != -91751)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_santa" + num2, typeof(Texture2D));
									if (165319 - 26581 == 138739)
									{
										continue;
									}
								}
								else if (nArmor == "a_all43")
								{
									if (76504 - 208319 == -131814)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_pvpArmor" + num2, typeof(Texture2D));
									if (66486 - 141008 != -74522)
									{
										continue;
									}
								}
								else if (nArmor == "a_all44")
								{
									if (181219 - 156042 == 25178)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_pvpArmor" + num2 + "R", typeof(Texture2D));
									if (24095 - 412425 == -388329)
									{
										continue;
									}
								}
								else if (nArmor == "a_all58")
								{
									if (167035 - 535139 == -368103)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_champion" + num2, typeof(Texture2D));
									if (222096 - 281366 != -59270)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat2")
								{
									if (157721 - 55217 == 102505)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_shirt" + num2, typeof(Texture2D));
									if (158077 - 426250 == -268172)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat5")
								{
									if (181833 - 135597 != 46236)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_bathRobe" + num2, typeof(Texture2D));
									if (205747 - 236690 == -30942)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat10")
								{
									if (286232 - 472424 != -186192)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_standard" + num2, typeof(Texture2D));
									if (70136 - 474168 == -404031)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat11")
								{
									if (85436 - 446303 != -360867)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_standard" + num2 + "R", typeof(Texture2D));
									if (13093 - 290750 == -277656)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat12")
								{
									if (96492 - 136673 != -40181)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_standard" + num2 + "V", typeof(Texture2D));
									if (209469 - 210215 == -745)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat15")
								{
									if (161776 - 455699 != -293923)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_summer" + num2, typeof(Texture2D));
									if (200022 - 160598 == 39425)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat21")
								{
									if (107220 - 328257 != -221037)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_warlock" + num2, typeof(Texture2D));
									if (239734 - 231173 != 8561)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat22")
								{
									if (18056 - 199525 != -181469)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_illusionist" + num2, typeof(Texture2D));
									if (51789 - 228630 == -176840)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat23")
								{
									if (40998 - 308855 == -267856)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_warlock" + num2 + "R", typeof(Texture2D));
									if (105241 - 359922 != -254681)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat24")
								{
									if (97518 - 283267 == -185748)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_illusionist" + num2 + "R", typeof(Texture2D));
									if (150372 - 250515 == -100142)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat25")
								{
									if (54494 - 86530 != -32036)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_teacher" + num2, typeof(Texture2D));
									if (60362 - 58569 == 1794)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat31")
								{
									if (33181 - 142349 == -109167)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_shadowCaller" + num2, typeof(Texture2D));
									if (183043 - 11527 != 171516)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat32")
								{
									if (175455 - 367614 != -192159)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_dreamCaster" + num2, typeof(Texture2D));
									if (81577 - 51925 != 29652)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat33")
								{
									if (145007 - 507894 == -362886)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_shadowCaller" + num2 + "R", typeof(Texture2D));
									if (134513 - 531906 != -397393)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat34")
								{
									if (204325 - 363809 != -159484)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_dreamCaster" + num2 + "R", typeof(Texture2D));
									if (249359 - 393015 != -143656)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat35")
								{
									if (187228 - 1557 != 185671)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_hallow" + num2, typeof(Texture2D));
									if (83805 - 593626 != -509821)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat40")
								{
									if (190013 - 595387 != -405374)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_queen" + num2, typeof(Texture2D));
									if (229537 - 173313 == 56225)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat41")
								{
									if (116983 - 207392 != -90409)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_queen" + num2 + "R", typeof(Texture2D));
									if (173745 - 254935 != -81190)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat42")
								{
									if (110432 - 489849 != -379417)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_queen" + num2 + "V", typeof(Texture2D));
									if (22154 - 408793 != -386639)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat45")
								{
									if (45601 - 25057 == 20545)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_superStar" + num2, typeof(Texture2D));
									if (292615 - 343441 != -50826)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat47")
								{
									if (255863 - 423736 == -167872)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_butterfly" + num2, typeof(Texture2D));
									if (292994 - 342299 == -49304)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat48")
								{
									if (282884 - 89770 == 193115)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_butterfly" + num2 + "R", typeof(Texture2D));
									if (56707 - 539112 != -482405)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat50")
								{
									if (54141 - 2952 != 51189)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_royal" + num2, typeof(Texture2D));
									if (113155 - 497712 != -384557)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat51")
								{
									if (168990 - 319298 != -150308)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_royal" + num2, typeof(Texture2D));
									if (151200 - 425074 != -273874)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat52")
								{
									if (7386 - 422853 != -415467)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_royal" + num2 + "R", typeof(Texture2D));
									if (152776 - 544582 != -391806)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat60")
								{
									if (63594 - 168073 == -104478)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_legend" + num2, typeof(Texture2D));
									if (122092 - 292720 == -170627)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat61")
								{
									if (58627 - 77229 != -18602)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_legend" + num2, typeof(Texture2D));
									if (198664 - 378789 == -180124)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat62")
								{
									if (15845 - 344896 == -329050)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_legend" + num2 + "R", typeof(Texture2D));
									if (266217 - 457702 != -191485)
									{
										continue;
									}
								}
								else if (nArmor == "a_bat65")
								{
									if (188320 - 81885 == 106436)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_japan" + num2, typeof(Texture2D));
									if (146431 - 159724 != -13293)
									{
										continue;
									}
								}
								else
								{
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_standard" + num2, typeof(Texture2D));
									if (224433 - 225292 != -859)
									{
										continue;
									}
								}
								IL_B69:
								Color[] pixels2 = texture2D2.GetPixels(0, 256, 256, 256, 0);
								if (239702 - 193292 == 46411)
								{
									continue;
								}
								int i = 0;
								if (96 - 343379 == -343282)
								{
									continue;
								}
								while (i < pixels2.Length)
								{
									float a = pixels[i].a;
									if (276490 - 157119 == 119372)
									{
										goto IL_BBE;
									}
									pixels2[i] = a * pixels[i] + ((float)1 - a) * pixels2[i];
									if (207272 - 508963 != -301691)
									{
										goto IL_BBE;
									}
									i++;
									if (93712 - 9476 != 84236)
									{
										goto IL_BBE;
									}
								}
								if (106243 - 396234 != -289991)
								{
									continue;
								}
								if (219716 - 400054 != -180338)
								{
									continue;
								}
								Texture2D texture2D3 = new Texture2D(512, 512, TextureFormat.RGB24, true);
								if (270078 - 417658 == -147579)
								{
									continue;
								}
								texture2D3.SetPixels(0, 256, 256, 256, pixels2, 0);
								if (294194 - 377488 != -83294)
								{
									continue;
								}
								texture2D3.SetPixels(256, 256, 256, 256, texture2D2.GetPixels(256, 256, 256, 256, 0), 0);
								if (3507 - 392278 != -388771)
								{
									continue;
								}
								texture2D3.SetPixels(0, 0, 512, 256, texture2D2.GetPixels(0, 0, 512, 256, 0), 0);
								if (58613 - 451403 == -392789)
								{
									continue;
								}
								texture2D3.Apply();
								if (266348 - 571164 != -304816)
								{
									continue;
								}
								texture2D3.Compress(true);
								if (88802 - 557512 != -468710)
								{
									continue;
								}
								if (155718 - 580959 != -425241)
								{
									continue;
								}
								material = new Material(Shader.Find("Diffuse"));
								if (98124 - 521590 != -423466)
								{
									continue;
								}
								material.color = new Color(0.86f, 0.86f, 0.86f, (float)1);
								if (144761 - 573452 == -428690)
								{
									continue;
								}
								material.mainTexture = texture2D3;
								if (6733 - 156198 != -149464)
								{
									break;
								}
								continue;
								IL_BDD:
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Bat/Armors/Materials/Bat_nude" + num2, typeof(Texture2D));
								if (231886 - 52275 != 179612)
								{
									goto IL_B69;
								}
							}
						}
					}
				}
			}
		}
		return material;
	}

	// Token: 0x06001CEE RID: 7406 RVA: 0x0030BCD8 File Offset: 0x00309ED8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipArmor(string nArmor)
	{
		if (226853 - 241087 != -14234)
		{
		}
		for (;;)
		{
			if (nArmor == "a_none")
			{
				if (194772 - 450936 == -256163)
				{
					continue;
				}
				nArmor = "none";
				if (233743 - 463173 == -229429)
				{
					continue;
				}
			}
			this.armor = nArmor;
			if (189245 - 470224 != -280978)
			{
				Transform transform = global::Math.findChildObject(this.transform, "Bat_tri");
				if (136003 - 149339 == -13336)
				{
					if (transform)
					{
						if (239598 - 477972 != -238374)
						{
							continue;
						}
						SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer));
						if (84899 - 107445 == -22545)
						{
							continue;
						}
						skinnedMeshRenderer.sharedMesh = BatEquipment.getArmorMesh(nArmor);
						if (226322 - 61551 != 164771)
						{
							continue;
						}
						if (Extensions.get_length(skinnedMeshRenderer.materials) > 0)
						{
							if (73287 - 583431 != -510144)
							{
								continue;
							}
							skinnedMeshRenderer.material = BatEquipment.getArmorMaterial(nArmor, this.skin);
							if (204145 - 451994 != -247849)
							{
								continue;
							}
						}
						if (this.vn7GZjHm2P != null)
						{
							if (175156 - 365624 == -190467)
							{
								continue;
							}
							skinnedMeshRenderer.material.color = this.vn7GZjHm2P.mColor;
							if (124250 - 155713 != -31463)
							{
								continue;
							}
						}
					}
					if (!this.vn7GZjHm2P)
					{
						break;
					}
					if (160313 - 514881 != -354567)
					{
						this.vn7GZjHm2P.armor = nArmor;
						if (262743 - 2187 != 260557)
						{
							if (this.vn7GZjHm2P.getStatus("blend") != null)
							{
								if (118152 - 103524 != 14628)
								{
									continue;
								}
								this.vn7GZjHm2P.removeStatus("blend");
								if (191502 - 189882 == 1621)
								{
									continue;
								}
							}
							if (this.vn7GZjHm2P.getStatus("invisible") == null)
							{
								break;
							}
							if (164062 - 286534 != -122471)
							{
								this.vn7GZjHm2P.removeStatus("invisible");
								if (168981 - 536902 != -367920)
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

	// Token: 0x06001CEF RID: 7407 RVA: 0x0030BFDC File Offset: 0x0030A1DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getAccessory(string nAccessory)
	{
		if (117200 - 378909 != -261708)
		{
		}
		GameObject result;
		for (;;)
		{
			result = null;
			if (7662 - 273003 != -265340)
			{
				if (240342 - 313787 == -73445)
				{
					if (nAccessory == "c_all1")
					{
						if (31109 - 248634 != -217524)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/redPandaHat", typeof(GameObject));
							if (298944 - 310510 == -11566)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all3")
					{
						if (167169 - 439540 != -272370)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/paperHat", typeof(GameObject));
							if (82219 - 595721 == -513502)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all6")
					{
						if (294478 - 574472 != -279993)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/vHat", typeof(GameObject));
							if (171474 - 85511 != 85964)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all7")
					{
						if (9955 - 9160 != 796)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/partyHatB", typeof(GameObject));
							if (95596 - 407494 == -311898)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all8")
					{
						if (198663 - 233466 == -34803)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/partyHatR", typeof(GameObject));
							if (39721 - 441004 != -401282)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all9")
					{
						if (66409 - 118558 != -52148)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/cakeHat", typeof(GameObject));
							if (288397 - 350674 == -62277)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all10")
					{
						if (211787 - 321812 != -110024)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/candyHat", typeof(GameObject));
							if (12505 - 268292 == -255787)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all11")
					{
						if (208581 - 536994 == -328413)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/afro", typeof(GameObject));
							if (248971 - 334551 != -85579)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all12")
					{
						if (247962 - 380309 == -132347)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/afroC", typeof(GameObject));
							if (7603 - 53250 == -45647)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all15")
					{
						if (3704 - 534344 == -530640)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/santaHat", typeof(GameObject));
							if (43102 - 257197 != -214094)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all16")
					{
						if (181970 - 301887 != -119916)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/pirateBandana", typeof(GameObject));
							if (275290 - 184770 != 90521)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all18")
					{
						if (197694 - 45267 == 152427)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/halo", typeof(GameObject));
							if (30319 - 93061 == -62742)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all19")
					{
						if (177483 - 274239 == -96756)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/horn", typeof(GameObject));
							if (145266 - 267621 == -122355)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all21")
					{
						if (284634 - 133331 != 151304)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/earmuff1", typeof(GameObject));
							if (69911 - 494843 != -424931)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all22")
					{
						if (194529 - 518499 == -323970)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/earmuff2", typeof(GameObject));
							if (141315 - 76351 != 64965)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all23")
					{
						if (2276 - 484123 != -481846)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/headphone1", typeof(GameObject));
							if (219161 - 113626 != 105536)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all24")
					{
						if (94657 - 486446 == -391789)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/headphone2", typeof(GameObject));
							if (252003 - 426253 != -174249)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all25")
					{
						if (280293 - 227140 != 53154)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/headphone3", typeof(GameObject));
							if (58696 - 386713 != -328016)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all26")
					{
						if (290615 - 278157 == 12458)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/pirateBandanaR", typeof(GameObject));
							if (263746 - 581431 != -317684)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all27")
					{
						if (12173 - 246307 == -234134)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/krathongHat1", typeof(GameObject));
							if (76732 - 189151 != -112418)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all28")
					{
						if (133565 - 537789 == -404224)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/krathongHat2", typeof(GameObject));
							if (35371 - 376158 != -340786)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all29")
					{
						if (26589 - 265150 == -238561)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/snowmanHead", typeof(GameObject));
							if (203180 - 135294 != 67887)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all37")
					{
						if (49299 - 328238 != -278938)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/quizHat", typeof(GameObject));
							if (93733 - 545507 != -451773)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all38")
					{
						if (78756 - 560673 != -481916)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/fanKingHat", typeof(GameObject));
							if (203519 - 174269 == 29250)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all39")
					{
						if (147877 - 322699 != -174821)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/artistHat", typeof(GameObject));
							if (211195 - 173259 != 37937)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all43")
					{
						if (125805 - 66092 == 59713)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/pvpHelmet", typeof(GameObject));
							if (136239 - 474887 != -338647)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all44")
					{
						if (160583 - 554147 != -393563)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/pvpHelmetR", typeof(GameObject));
							if (174255 - 81080 == 93175)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all46")
					{
						if (282622 - 564048 == -281426)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/mummyHead", typeof(GameObject));
							if (114765 - 486233 != -371467)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all55")
					{
						if (17002 - 52679 != -35676)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/giveMeFive", typeof(GameObject));
							if (2194 - 72659 != -70464)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all56")
					{
						if (55603 - 499221 == -443618)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/frozenCrown", typeof(GameObject));
							if (186718 - 85146 == 101572)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all58")
					{
						if (75441 - 279946 == -204505)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/championHelmet", typeof(GameObject));
							if (233128 - 309932 == -76804)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all66")
					{
						if (89279 - 581196 != -491916)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/poseidonHelmet", typeof(GameObject));
							if (223039 - 321396 == -98357)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_fem11")
					{
						if (174548 - 430465 == -255917)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/flowerBand", typeof(GameObject));
							if (240731 - 484502 != -243770)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_fem37")
					{
						if (250930 - 298749 != -47818)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/lionHead", typeof(GameObject));
							if (256900 - 20120 != 236781)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat5")
					{
						if (294148 - 540210 == -246062)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/showerCap", typeof(GameObject));
							if (189472 - 204153 != -14680)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat15")
					{
						if (36055 - 471327 != -435271)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/summerHat", typeof(GameObject));
							if (50808 - 53328 != -2519)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat19")
					{
						if (278803 - 72552 != 206252)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/veggieHat", typeof(GameObject));
							if (150376 - 76909 != 73468)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat21")
					{
						if (226826 - 494225 == -267399)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/warlockHood", typeof(GameObject));
							if (143365 - 482297 != -338931)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat22")
					{
						if (277025 - 81407 == 195618)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/illusionMask", typeof(GameObject));
							if (155392 - 153679 == 1713)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat23")
					{
						if (128866 - 90032 == 38834)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/warlockHoodR", typeof(GameObject));
							if (161716 - 223049 == -61333)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat24")
					{
						if (29192 - 257539 != -228346)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/illusionMaskR", typeof(GameObject));
							if (294842 - 394483 != -99640)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat25")
					{
						if (240602 - 590818 == -350216)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/teacherHat", typeof(GameObject));
							if (202406 - 531826 == -329420)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat31")
					{
						if (257827 - 421127 == -163300)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/shadowHat", typeof(GameObject));
							if (172846 - 202074 != -29227)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat32")
					{
						if (297151 - 359516 == -62365)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/dreamBand", typeof(GameObject));
							if (232148 - 429798 != -197649)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat33")
					{
						if (27556 - 68245 != -40688)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/shadowHatR", typeof(GameObject));
							if (35393 - 49258 == -13865)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat34")
					{
						if (299552 - 295313 == 4239)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/dreamBandR", typeof(GameObject));
							if (218479 - 425994 != -207514)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat35")
					{
						if (20516 - 502922 == -482406)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/hallowCrown", typeof(GameObject));
							if (288085 - 551036 != -262950)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat36")
					{
						if (146896 - 77552 == 69344)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/lizaHood", typeof(GameObject));
							if (121872 - 475053 != -353180)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat40")
					{
						if (228702 - 221850 != 6853)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/queenCrown", typeof(GameObject));
							if (282186 - 271979 != 10208)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat41")
					{
						if (202810 - 135250 != 67561)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/queenCrownR", typeof(GameObject));
							if (299549 - 503394 != -203844)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat42")
					{
						if (9431 - 61116 != -51684)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/queenCrownV", typeof(GameObject));
							if (38089 - 175803 == -137714)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat45")
					{
						if (87752 - 258253 == -170501)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/starGlasses", typeof(GameObject));
							if (253534 - 368633 != -115098)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat47")
					{
						if (175663 - 315106 != -139442)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/butterflyHood", typeof(GameObject));
							if (227503 - 235890 != -8386)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat48")
					{
						if (237472 - 72570 != 164903)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/butterflyHoodR", typeof(GameObject));
							if (209561 - 219067 != -9505)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat50")
					{
						if (127767 - 160721 == -32954)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/royalCirclet", typeof(GameObject));
							if (261814 - 324575 == -62761)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat51")
					{
						if (252736 - 214216 != 38521)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/royalCirclet", typeof(GameObject));
							if (187623 - 108734 != 78890)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat52")
					{
						if (281274 - 317544 != -36269)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/royalCircletR", typeof(GameObject));
							if (190884 - 281898 == -91014)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat60")
					{
						if (110714 - 542585 != -431870)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/legendHelmet", typeof(GameObject));
							if (65223 - 390130 == -324907)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat61")
					{
						if (226969 - 424693 != -197723)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/legendHelmet", typeof(GameObject));
							if (5412 - 424501 == -419089)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_bat62")
					{
						if (146215 - 326106 == -179891)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/legendHelmetR", typeof(GameObject));
							if (183959 - 468790 == -284831)
							{
								break;
							}
						}
					}
					else
					{
						if (!(nAccessory == "c_bat65"))
						{
							break;
						}
						if (266020 - 402159 != -136138)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Accessories/japanSakura", typeof(GameObject));
							if (112227 - 422215 != -309987)
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

	// Token: 0x06001CF0 RID: 7408 RVA: 0x0030D7E4 File Offset: 0x0030B9E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipAccessory(string nAccessory)
	{
		if (57325 - 214823 != -157497)
		{
		}
		for (;;)
		{
			this.accessory = nAccessory;
			if (290063 - 341142 != -51078)
			{
				if (this.oPVGwf2tJW)
				{
					if (191189 - 295453 != -104264)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.oPVGwf2tJW);
					if (183939 - 41568 != 142371)
					{
						continue;
					}
				}
				GameObject gameObject = BatEquipment.getAccessory(nAccessory);
				if (157257 - 402940 != -245682)
				{
					if (gameObject)
					{
						if (207847 - 439169 == -231321)
						{
							continue;
						}
						this.oPVGwf2tJW = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (115344 - 138085 == -22740)
						{
							continue;
						}
						if (261409 - 504945 != -243536)
						{
							continue;
						}
						if (!(nAccessory == "c_all27"))
						{
							if (258055 - 330660 != -72605)
							{
								continue;
							}
							if (nAccessory == "c_all28")
							{
								if (118173 - 73656 != 44517)
								{
									continue;
								}
							}
							else
							{
								this.oPVGwf2tJW.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
								if (27949 - 81059 != -53110)
								{
									continue;
								}
								this.oPVGwf2tJW.transform.localPosition = Vector3.zero;
								if (271762 - 145268 == 126495)
								{
									continue;
								}
								this.oPVGwf2tJW.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
								if (1335 - 520028 != -518693)
								{
									continue;
								}
								this.oPVGwf2tJW.transform.localScale = Vector3.one;
								if (286695 - 546760 != -260064)
								{
									goto IL_D4;
								}
								continue;
							}
						}
						this.oPVGwf2tJW.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
						if (153847 - 217306 == -63458)
						{
							continue;
						}
						this.oPVGwf2tJW.transform.localPosition = Vector3.zero;
						if (181542 - 214573 == -33030)
						{
							continue;
						}
						this.oPVGwf2tJW.transform.localRotation = Quaternion.Euler((float)270, (float)0, (float)90);
						if (200429 - 236622 != -36193)
						{
							continue;
						}
						this.oPVGwf2tJW.transform.localScale = Vector3.one;
						if (171775 - 293306 == -121530)
						{
							continue;
						}
					}
					IL_D4:
					if (!this.vn7GZjHm2P)
					{
						break;
					}
					if (100526 - 332157 != -231630)
					{
						this.vn7GZjHm2P.accessory = nAccessory;
						if (83062 - 191455 != -108392)
						{
							this.vn7GZjHm2P.mAcc = this.oPVGwf2tJW;
							if (286573 - 440617 != -154043)
							{
								if (this.vn7GZjHm2P.getStatus("blend") != null)
								{
									if (169220 - 143006 == 26215)
									{
										continue;
									}
									this.vn7GZjHm2P.removeStatus("blend");
									if (200405 - 31465 == 168941)
									{
										continue;
									}
								}
								if (this.vn7GZjHm2P.getStatus("invisible") == null)
								{
									break;
								}
								if (64127 - 314331 != -250203)
								{
									this.vn7GZjHm2P.removeStatus("invisible");
									if (16943 - 598590 == -581647)
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

	// Token: 0x06001CF1 RID: 7409 RVA: 0x0030DC5C File Offset: 0x0030BE5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipBoot(string nBoot)
	{
		if (126749 - 47237 != 79512)
		{
		}
		while (this.vn7GZjHm2P)
		{
			if (191743 - 320836 == -129093)
			{
				if (this.vn7GZjHm2P.getStatus("blend") != null)
				{
					if (227763 - 353664 != -125901)
					{
						continue;
					}
					this.vn7GZjHm2P.removeStatus("blend");
					if (89130 - 189895 == -100764)
					{
						continue;
					}
				}
				if (this.vn7GZjHm2P.getStatus("invisible") == null)
				{
					break;
				}
				if (289810 - 481420 == -191610)
				{
					this.vn7GZjHm2P.removeStatus("invisible");
					if (298305 - 282861 == 15444)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001CF2 RID: 7410 RVA: 0x0030DD70 File Offset: 0x0030BF70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getTrinket(string nTrinket)
	{
		if (187019 - 73732 != 113287)
		{
		}
		GameObject result;
		for (;;)
		{
			result = null;
			if (18 - 94638 == -94620)
			{
				if (198215 - 428776 == -230561)
				{
					if (nTrinket == "t_all1")
					{
						if (118008 - 551491 == -433483)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/glasses", typeof(GameObject));
							if (233917 - 133376 == 100541)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all2")
					{
						if (111564 - 166821 == -55257)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/sunGlasses", typeof(GameObject));
							if (166314 - 184905 != -18590)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all3")
					{
						if (158333 - 199187 != -40853)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/starGlasses", typeof(GameObject));
							if (54429 - 178799 != -124369)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all4")
					{
						if (42963 - 357060 == -314097)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/nerdGlasses", typeof(GameObject));
							if (35631 - 278942 == -243311)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all5")
					{
						if (210755 - 343309 != -132553)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/blackGlasses", typeof(GameObject));
							if (630 - 265940 == -265310)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all6")
					{
						if (216958 - 580443 != -363484)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/bugAntenna", typeof(GameObject));
							if (239205 - 259135 != -19929)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all7")
					{
						if (42082 - 50583 == -8501)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/partyWhistle", typeof(GameObject));
							if (186459 - 589233 == -402774)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all8")
					{
						if (11757 - 267277 != -255519)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/redNose", typeof(GameObject));
							if (123108 - 90022 == 33086)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all9")
					{
						if (111735 - 211026 != -99290)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/lollipop", typeof(GameObject));
							if (194838 - 113996 != 80843)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all46")
					{
						if (105567 - 534887 != -429319)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/groceryBag", typeof(GameObject));
							if (67663 - 484766 == -417103)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all51")
					{
						if (194869 - 274480 == -79611)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/sandTopaz", typeof(GameObject));
							if (133935 - 362150 != -228214)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all55")
					{
						if (182855 - 436108 != -253252)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/fifthSword", typeof(GameObject));
							if (54630 - 581529 != -526898)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all56")
					{
						if (83103 - 359371 == -276268)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/fifthWand", typeof(GameObject));
							if (231745 - 496499 == -264754)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all57")
					{
						if (154913 - 180476 == -25563)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/fifthWing", typeof(GameObject));
							if (260111 - 496732 != -236620)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all58")
					{
						if (156688 - 549441 == -392753)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/carronBag", typeof(GameObject));
							if (226025 - 556495 == -330470)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all59")
					{
						if (253634 - 60867 != 192768)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/mupoBag", typeof(GameObject));
							if (126269 - 469163 != -342893)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all66")
					{
						if (172425 - 581517 != -409091)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/doubleHorn", typeof(GameObject));
							if (175142 - 41857 != 133286)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all71")
					{
						if (287712 - 458745 != -171032)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/championFlag1", typeof(GameObject));
							if (279666 - 13179 != 266488)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all72")
					{
						if (209701 - 256581 != -46879)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/championFlag2", typeof(GameObject));
							if (57525 - 31993 == 25532)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all73")
					{
						if (46999 - 403903 == -356904)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/championFlag3", typeof(GameObject));
							if (210548 - 156954 == 53594)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all74")
					{
						if (112572 - 325467 != -212894)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/championFlag4", typeof(GameObject));
							if (197937 - 429856 != -231918)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all75")
					{
						if (289945 - 74673 == 215272)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/championFlag5", typeof(GameObject));
							if (174666 - 149961 == 24705)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all91")
					{
						if (179041 - 247671 == -68630)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/lightSeal", typeof(GameObject));
							if (152535 - 212821 == -60286)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all92")
					{
						if (294517 - 127132 != 167386)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/fireSeal", typeof(GameObject));
							if (243852 - 434136 != -190283)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all93")
					{
						if (294608 - 359866 != -65257)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/waterSeal", typeof(GameObject));
							if (150817 - 176210 == -25393)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all94")
					{
						if (5912 - 41858 == -35946)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/windSeal", typeof(GameObject));
							if (296560 - 386472 != -89911)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all95")
					{
						if (167820 - 577517 != -409696)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/earthSeal", typeof(GameObject));
							if (121417 - 186825 != -65407)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all96")
					{
						if (221829 - 136780 == 85049)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/shadowSeal", typeof(GameObject));
							if (56090 - 471276 == -415186)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem2")
					{
						if (36844 - 508727 != -471882)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/bell", typeof(GameObject));
							if (256982 - 158229 == 98753)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem11")
					{
						if (8180 - 323093 == -314913)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/magazine", typeof(GameObject));
							if (250154 - 23674 == 226480)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem14")
					{
						if (27208 - 286942 != -259733)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/heartRing", typeof(GameObject));
							if (182142 - 118576 == 63566)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem15")
					{
						if (217760 - 186817 != 30944)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/deerHorn", typeof(GameObject));
							if (158552 - 399742 == -241190)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem31")
					{
						if (47111 - 482065 != -434953)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/chineseTalismanR", typeof(GameObject));
							if (136041 - 450623 != -314581)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem37")
					{
						if (55430 - 561141 != -505710)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/chineseLantern", typeof(GameObject));
							if (299929 - 434334 != -134404)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem46")
					{
						if (121854 - 68163 != 53692)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/maohWings", typeof(GameObject));
							if (33213 - 391951 != -358737)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem56")
					{
						if (154695 - 85592 != 69104)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/frozenMask", typeof(GameObject));
							if (267258 - 254212 != 13047)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem66")
					{
						if (283831 - 255017 != 28815)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/poseidonTrinket", typeof(GameObject));
							if (70596 - 191315 == -120719)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_bat60")
					{
						if (57964 - 592026 != -534061)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/legendTrinket", typeof(GameObject));
							if (50168 - 395021 == -344853)
							{
								break;
							}
						}
					}
					else
					{
						if (!(nTrinket == "t_bat62"))
						{
							break;
						}
						if (230751 - 349744 == -118993)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Trinkets/legendTrinketR", typeof(GameObject));
							if (206441 - 113454 != 92988)
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

	// Token: 0x06001CF3 RID: 7411 RVA: 0x0030ECF8 File Offset: 0x0030CEF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipTrinket(string nTrinket)
	{
		if (279468 - 440466 != -160998)
		{
		}
		for (;;)
		{
			this.trinket = nTrinket;
			if (195411 - 373485 != -178073)
			{
				if (this.aNtGUeP8tZ)
				{
					if (232241 - 231207 == 1035)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.aNtGUeP8tZ);
					if (19493 - 433036 == -413542)
					{
						continue;
					}
				}
				GameObject gameObject = BatEquipment.getTrinket(nTrinket);
				if (123806 - 250318 == -126512)
				{
					if (gameObject)
					{
						if (910 - 165392 != -164482)
						{
							continue;
						}
						this.aNtGUeP8tZ = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (139695 - 151229 == -11533)
						{
							continue;
						}
						if (142972 - 401300 != -258328)
						{
							continue;
						}
						if (!(nTrinket == "t_all71"))
						{
							if (25268 - 246427 != -221159)
							{
								continue;
							}
							if (!(nTrinket == "t_all72"))
							{
								if (212250 - 522228 == -309977)
								{
									continue;
								}
								if (!(nTrinket == "t_all73"))
								{
									if (203274 - 560129 != -356855)
									{
										continue;
									}
									if (!(nTrinket == "t_all74"))
									{
										if (92366 - 181731 != -89365)
										{
											continue;
										}
										if (nTrinket == "t_all75")
										{
											if (52799 - 561592 == -508792)
											{
												continue;
											}
										}
										else
										{
											if (!(nTrinket == "t_all55"))
											{
												if (203857 - 98002 == 105856)
												{
													continue;
												}
												if (!(nTrinket == "t_all56"))
												{
													if (193433 - 381100 == -187666)
													{
														continue;
													}
													if (!(nTrinket == "t_all57"))
													{
														if (85357 - 254302 == -168944)
														{
															continue;
														}
														if (!(nTrinket == "t_all58"))
														{
															if (169471 - 254375 == -84903)
															{
																continue;
															}
															if (!(nTrinket == "t_all59"))
															{
																if (236700 - 422897 == -186196)
																{
																	continue;
																}
																if (!(nTrinket == "t_fem2"))
																{
																	if (201871 - 312932 != -111061)
																	{
																		continue;
																	}
																	if (!(nTrinket == "t_fem46"))
																	{
																		if (66765 - 320014 == -253248)
																		{
																			continue;
																		}
																		if (nTrinket == "t_fem66")
																		{
																			if (203529 - 219999 == -16469)
																			{
																				continue;
																			}
																		}
																		else if (nTrinket == "t_fem11")
																		{
																			if (185295 - 452178 == -266882)
																			{
																				continue;
																			}
																			this.aNtGUeP8tZ.transform.parent = global::Math.findChildObject(this.gameObject.transform, "mount_Hand_R");
																			if (113964 - 31931 == 82034)
																			{
																				continue;
																			}
																			this.aNtGUeP8tZ.transform.localPosition = Vector3.zero;
																			if (134307 - 43679 != 90628)
																			{
																				continue;
																			}
																			this.aNtGUeP8tZ.transform.localRotation = Quaternion.identity;
																			if (262170 - 268327 != -6157)
																			{
																				continue;
																			}
																			this.aNtGUeP8tZ.transform.localScale = Vector3.one;
																			if (262442 - 453114 != -190671)
																			{
																				goto IL_79C;
																			}
																			continue;
																		}
																		else if (nTrinket == "t_fem37")
																		{
																			if (43552 - 228267 == -184714)
																			{
																				continue;
																			}
																			this.aNtGUeP8tZ.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine1");
																			if (283396 - 313490 == -30093)
																			{
																				continue;
																			}
																			this.aNtGUeP8tZ.transform.localPosition = Vector3.zero;
																			if (15166 - 200342 != -185176)
																			{
																				continue;
																			}
																			this.aNtGUeP8tZ.transform.localRotation = Quaternion.Euler((float)270, (float)90, (float)0);
																			if (14254 - 319984 != -305730)
																			{
																				continue;
																			}
																			this.aNtGUeP8tZ.transform.localScale = Vector3.one;
																			if (184405 - 450712 != -266306)
																			{
																				goto IL_79C;
																			}
																			continue;
																		}
																		else
																		{
																			if (!(nTrinket == "t_bat60"))
																			{
																				if (173613 - 545476 == -371862)
																				{
																					continue;
																				}
																				if (nTrinket == "t_bat62")
																				{
																					if (72701 - 357227 == -284525)
																					{
																						continue;
																					}
																				}
																				else if (nTrinket == "t_all46")
																				{
																					if (82757 - 168037 == -85279)
																					{
																						continue;
																					}
																					this.aNtGUeP8tZ.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Hand_R");
																					if (105681 - 544386 != -438705)
																					{
																						continue;
																					}
																					this.aNtGUeP8tZ.transform.localPosition = Vector3.zero;
																					if (61798 - 69418 == -7619)
																					{
																						continue;
																					}
																					this.aNtGUeP8tZ.transform.localRotation = Quaternion.identity;
																					if (104838 - 419148 != -314310)
																					{
																						continue;
																					}
																					this.aNtGUeP8tZ.transform.localScale = Vector3.one;
																					if (161219 - 229006 != -67786)
																					{
																						goto IL_79C;
																					}
																					continue;
																				}
																				else
																				{
																					if (!(nTrinket == "t_all91"))
																					{
																						if (23298 - 32201 == -8902)
																						{
																							continue;
																						}
																						if (!(nTrinket == "t_all92"))
																						{
																							if (297745 - 526389 != -228644)
																							{
																								continue;
																							}
																							if (!(nTrinket == "t_all93"))
																							{
																								if (7376 - 232007 == -224630)
																								{
																									continue;
																								}
																								if (!(nTrinket == "t_all94"))
																								{
																									if (65758 - 237848 == -172089)
																									{
																										continue;
																									}
																									if (!(nTrinket == "t_all95"))
																									{
																										if (176930 - 164895 != 12035)
																										{
																											continue;
																										}
																										if (nTrinket == "t_all96")
																										{
																											if (50447 - 238922 != -188475)
																											{
																												continue;
																											}
																										}
																										else
																										{
																											this.aNtGUeP8tZ.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
																											if (93350 - 598295 == -504944)
																											{
																												continue;
																											}
																											this.aNtGUeP8tZ.transform.localPosition = Vector3.zero;
																											if (196086 - 406429 == -210342)
																											{
																												continue;
																											}
																											this.aNtGUeP8tZ.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
																											if (82297 - 291806 == -209508)
																											{
																												continue;
																											}
																											this.aNtGUeP8tZ.transform.localScale = Vector3.one;
																											if (271171 - 263473 != 7698)
																											{
																												continue;
																											}
																											goto IL_79C;
																										}
																									}
																								}
																							}
																						}
																					}
																					this.aNtGUeP8tZ.transform.parent = this.gameObject.transform;
																					if (5554 - 179981 != -174427)
																					{
																						continue;
																					}
																					this.aNtGUeP8tZ.transform.localPosition = Vector3.zero;
																					if (60972 - 513135 != -452163)
																					{
																						continue;
																					}
																					this.aNtGUeP8tZ.transform.localRotation = Quaternion.identity;
																					if (199554 - 381207 != -181653)
																					{
																						continue;
																					}
																					this.aNtGUeP8tZ.transform.localScale = Vector3.one;
																					if (80266 - 387127 != -306861)
																					{
																						continue;
																					}
																					goto IL_79C;
																				}
																			}
																			this.aNtGUeP8tZ.transform.parent = this.gameObject.transform;
																			if (93424 - 146887 != -53463)
																			{
																				continue;
																			}
																			this.aNtGUeP8tZ.transform.localPosition = Vector3.zero;
																			if (25685 - 368359 != -342674)
																			{
																				continue;
																			}
																			this.aNtGUeP8tZ.transform.localRotation = Quaternion.identity;
																			if (153573 - 484795 != -331222)
																			{
																				continue;
																			}
																			this.aNtGUeP8tZ.transform.localScale = Vector3.one;
																			if (289008 - 39185 != 249824)
																			{
																				goto IL_79C;
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
											this.aNtGUeP8tZ.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine1");
											if (179125 - 212509 != -33384)
											{
												continue;
											}
											this.aNtGUeP8tZ.transform.localPosition = Vector3.zero;
											if (268063 - 397390 != -129327)
											{
												continue;
											}
											this.aNtGUeP8tZ.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
											if (23541 - 24162 != -621)
											{
												continue;
											}
											this.aNtGUeP8tZ.transform.localScale = Vector3.one;
											if (259498 - 294602 != -35104)
											{
												continue;
											}
											goto IL_79C;
										}
									}
								}
							}
						}
						this.aNtGUeP8tZ.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine2");
						if (77428 - 71041 != 6387)
						{
							continue;
						}
						this.aNtGUeP8tZ.transform.localPosition = Vector3.zero;
						if (232900 - 41247 == 191654)
						{
							continue;
						}
						this.aNtGUeP8tZ.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
						if (243596 - 541813 == -298216)
						{
							continue;
						}
						this.aNtGUeP8tZ.transform.localScale = Vector3.one;
						if (235444 - 574991 == -339546)
						{
							continue;
						}
					}
					IL_79C:
					if (!this.vn7GZjHm2P)
					{
						break;
					}
					if (212914 - 233966 != -21051)
					{
						this.vn7GZjHm2P.trinket = nTrinket;
						if (143572 - 412935 != -269362)
						{
							this.vn7GZjHm2P.mTrn = this.aNtGUeP8tZ;
							if (65858 - 218822 != -152963)
							{
								if (this.vn7GZjHm2P.getStatus("blend") != null)
								{
									if (284742 - 217330 != 67412)
									{
										continue;
									}
									this.vn7GZjHm2P.removeStatus("blend");
									if (171301 - 426568 != -255267)
									{
										continue;
									}
								}
								if (this.vn7GZjHm2P.getStatus("invisible") == null)
								{
									break;
								}
								if (182499 - 232071 != -49571)
								{
									this.vn7GZjHm2P.removeStatus("invisible");
									if (135928 - 124680 == 11248)
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

	// Token: 0x06001CF4 RID: 7412 RVA: 0x0030F9EC File Offset: 0x0030DBEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipPet(string nPet)
	{
		if (87588 - 125616 != -38027)
		{
		}
		for (;;)
		{
			if (Game.mGameType < 2)
			{
				if (79229 - 542314 != -463084)
				{
					break;
				}
			}
			else
			{
				this.pet = nPet;
				if (216392 - 86872 != 129521)
				{
					if (this.z5mGNCft29)
					{
						if (124699 - 559073 != -434374)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.z5mGNCft29);
						if (10229 - 98453 == -88223)
						{
							continue;
						}
					}
					GameObject gameObject = null;
					if (185021 - 150589 == 34432)
					{
						int num = 1;
						if (79069 - 473698 != -394628)
						{
							if (104166 - 515991 == -411825)
							{
								if (nPet == "p_all1")
								{
									if (256904 - 372907 != -116003)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/bigbugBalloon", typeof(GameObject));
									if (260348 - 471647 == -211298)
									{
										continue;
									}
								}
								else if (nPet == "p_all2")
								{
									if (111248 - 488235 != -376987)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/bluebugBalloon", typeof(GameObject));
									if (297807 - 498339 != -200532)
									{
										continue;
									}
								}
								else if (nPet == "p_all3")
								{
									if (209349 - 177646 != 31703)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/momBalloon", typeof(GameObject));
									if (230094 - 223774 == 6321)
									{
										continue;
									}
								}
								else if (nPet == "p_all4")
								{
									if (53862 - 108726 == -54863)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/dadBalloon", typeof(GameObject));
									if (245912 - 185973 != 59939)
									{
										continue;
									}
								}
								else if (nPet == "p_all11")
								{
									if (153500 - 341212 == -187711)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallSmashBall", typeof(GameObject));
									if (193061 - 459328 == -266266)
									{
										continue;
									}
								}
								else if (nPet == "p_all12")
								{
									if (213990 - 537482 != -323492)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/soccerBall", typeof(GameObject));
									if (298718 - 374736 != -76018)
									{
										continue;
									}
								}
								else if (nPet == "p_all21")
								{
									if (226600 - 298884 != -72284)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteChula", typeof(GameObject));
									if (293813 - 504240 != -210427)
									{
										continue;
									}
								}
								else if (nPet == "p_all22")
								{
									if (293598 - 455819 != -162221)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kitePukpao", typeof(GameObject));
									if (220744 - 24545 == 196200)
									{
										continue;
									}
								}
								else if (nPet == "p_all23")
								{
									if (71162 - 271465 == -200302)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteButterfly", typeof(GameObject));
									if (69540 - 477291 != -407751)
									{
										continue;
									}
								}
								else if (nPet == "p_all24")
								{
									if (20228 - 339947 == -319718)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteSnake", typeof(GameObject));
									if (59490 - 140262 == -80771)
									{
										continue;
									}
								}
								else if (Extensions.get_length(nPet) == 6)
								{
									if (165297 - 375598 != -210301)
									{
										continue;
									}
									string a = nPet.Substring(0, 5);
									if (292006 - 63083 == 228924)
									{
										continue;
									}
									if (a == "p_lcr")
									{
										if (81277 - 494184 != -412907)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron", typeof(GameObject));
										if (56080 - 416300 != -360220)
										{
											continue;
										}
									}
									else if (a == "p_lcp")
									{
										if (259458 - 101289 != 158169)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron_p", typeof(GameObject));
										if (166762 - 244009 == -77246)
										{
											continue;
										}
									}
									else if (a == "p_lmp")
									{
										if (224276 - 222589 != 1687)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMupo", typeof(GameObject));
										if (178866 - 93931 != 84935)
										{
											continue;
										}
									}
									else if (a == "p_lpp")
									{
										if (168177 - 57682 != 110495)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePeppon", typeof(GameObject));
										if (247961 - 173646 != 74315)
										{
											continue;
										}
									}
									else if (a == "p_lct")
									{
										if (238090 - 389314 != -151224)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCacton", typeof(GameObject));
										if (240339 - 212458 == 27882)
										{
											continue;
										}
									}
									else if (a == "p_lcc")
									{
										if (199152 - 517413 == -318260)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCocon", typeof(GameObject));
										if (248226 - 564791 != -316565)
										{
											continue;
										}
									}
									else if (a == "p_lpk")
									{
										if (221852 - 527295 == -305442)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePumpkon", typeof(GameObject));
										if (256598 - 534772 != -278174)
										{
											continue;
										}
									}
									else if (a == "p_lml")
									{
										if (1345 - 254792 != -253447)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMellon", typeof(GameObject));
										if (274815 - 460398 != -185583)
										{
											continue;
										}
									}
									else if (a == "p_lbd")
									{
										if (93540 - 429966 == -336425)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleBDMellon", typeof(GameObject));
										if (239561 - 43567 == 195995)
										{
											continue;
										}
									}
									else if (a == "p_lcs")
									{
										if (124942 - 454605 == -329662)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron_s", typeof(GameObject));
										if (80111 - 522951 == -442839)
										{
											continue;
										}
									}
									else if (a == "p_lms")
									{
										if (78877 - 532180 != -453303)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMupo_s", typeof(GameObject));
										if (220271 - 301734 == -81462)
										{
											continue;
										}
									}
									else if (a == "p_lps")
									{
										if (160594 - 324378 != -163784)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePeppon_s", typeof(GameObject));
										if (138841 - 403845 != -265004)
										{
											continue;
										}
									}
									else if (a == "p_lck")
									{
										if (183546 - 131599 == 51948)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarronCake", typeof(GameObject));
										if (5927 - 364037 != -358110)
										{
											continue;
										}
									}
									else if (a == "p_lpd")
									{
										if (121779 - 49446 != 72333)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePepponDisco", typeof(GameObject));
										if (160464 - 429004 == -268539)
										{
											continue;
										}
									}
									else if (a == "p_lmc")
									{
										if (292021 - 72258 == 219764)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadCarron", typeof(GameObject));
										if (102997 - 90426 != 12571)
										{
											continue;
										}
									}
									else if (a == "p_lmn")
									{
										if (81537 - 118319 != -36782)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadPeppon", typeof(GameObject));
										if (129323 - 324630 != -195307)
										{
											continue;
										}
									}
									else if (a == "p_lmo")
									{
										if (17366 - 435105 == -417738)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadCocon", typeof(GameObject));
										if (64070 - 428355 == -364284)
										{
											continue;
										}
									}
									else if (a == "p_ldc")
									{
										if (20786 - 163038 == -142251)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCarron", typeof(GameObject));
										if (218001 - 179988 != 38013)
										{
											continue;
										}
									}
									else if (a == "p_ldm")
									{
										if (158216 - 11787 != 146429)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadMupo", typeof(GameObject));
										if (20489 - 300234 == -279744)
										{
											continue;
										}
									}
									else if (a == "p_ldp")
									{
										if (1093 - 487415 != -486322)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadPeppon", typeof(GameObject));
										if (78548 - 123101 != -44553)
										{
											continue;
										}
									}
									else if (a == "p_ldt")
									{
										if (108660 - 86498 == 22163)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCacton", typeof(GameObject));
										if (40330 - 422095 == -381764)
										{
											continue;
										}
									}
									else if (a == "p_ldn")
									{
										if (227227 - 416449 != -189222)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCocon", typeof(GameObject));
										if (205846 - 211377 != -5531)
										{
											continue;
										}
									}
									else if (a == "p_ldk")
									{
										if (14340 - 367725 != -353385)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadPumpkon", typeof(GameObject));
										if (224757 - 200138 == 24620)
										{
											continue;
										}
									}
									else if (a == "p_srp")
									{
										if (28855 - 598667 != -569812)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallRedPanda", typeof(GameObject));
										if (70177 - 524150 != -453973)
										{
											continue;
										}
									}
									else if (a == "p_sss")
									{
										if (203385 - 310461 == -107075)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallSantaSkunk", typeof(GameObject));
										if (101546 - 320886 == -219339)
										{
											continue;
										}
									}
									else if (a == "p_sbb")
									{
										if (243033 - 376937 != -133904)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallBarrelBot", typeof(GameObject));
										if (202331 - 298288 == -95956)
										{
											continue;
										}
									}
									else if (a == "p_sdm")
									{
										if (31139 - 318833 == -287693)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallDemion", typeof(GameObject));
										if (32550 - 344595 != -312045)
										{
											continue;
										}
									}
									else if (a == "p_sdv")
									{
										if (197982 - 312147 == -114164)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallDoov", typeof(GameObject));
										if (120926 - 224975 == -104048)
										{
											continue;
										}
									}
									else if (a == "p_skz")
									{
										if (1935 - 531394 != -529459)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallKarazo", typeof(GameObject));
										if (148050 - 171204 == -23153)
										{
											continue;
										}
									}
									else if (a == "p_skm")
									{
										if (166668 - 154383 == 12286)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallKumo", typeof(GameObject));
										if (170080 - 500238 == -330157)
										{
											continue;
										}
									}
									else if (a == "p_skr")
									{
										if (260077 - 209393 == 50685)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_r", typeof(GameObject));
										if (150469 - 95227 != 55242)
										{
											continue;
										}
									}
									else if (a == "p_skg")
									{
										if (8086 - 426442 != -418356)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_g", typeof(GameObject));
										if (170004 - 386752 != -216748)
										{
											continue;
										}
									}
									else if (a == "p_sky")
									{
										if (82651 - 165217 != -82566)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_y", typeof(GameObject));
										if (228 - 290882 != -290654)
										{
											continue;
										}
									}
									else if (a == "p_skb")
									{
										if (290743 - 247341 != 43402)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_b", typeof(GameObject));
										if (139675 - 152204 != -12529)
										{
											continue;
										}
									}
									else if (a == "p_skk")
									{
										if (61389 - 466308 == -404918)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_k", typeof(GameObject));
										if (213155 - 348798 == -135642)
										{
											continue;
										}
									}
									else if (a == "p_sfb")
									{
										if (128691 - 592220 != -463529)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallFlowerBug", typeof(GameObject));
										if (174230 - 266985 != -92755)
										{
											continue;
										}
									}
									else if (a == "p_sob")
									{
										if (136393 - 326430 != -190037)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallLionBug", typeof(GameObject));
										if (111839 - 126944 != -15105)
										{
											continue;
										}
									}
									else if (a == "p_sgb")
									{
										if (119206 - 164084 != -44878)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallGiantBug", typeof(GameObject));
										if (208084 - 69660 == 138425)
										{
											continue;
										}
									}
									else if (a == "p_slb")
									{
										if (19976 - 85812 == -65835)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallLeafBug", typeof(GameObject));
										if (232803 - 320256 != -87453)
										{
											continue;
										}
									}
									else if (a == "p_stb")
									{
										if (161005 - 27534 == 133472)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallFatBug", typeof(GameObject));
										if (163240 - 82256 != 80984)
										{
											continue;
										}
									}
									else if (a == "p_spb")
									{
										if (202516 - 159905 != 42611)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallPaperBug", typeof(GameObject));
										if (239760 - 533643 != -293883)
										{
											continue;
										}
									}
									else if (a == "p_swb")
									{
										if (15605 - 4836 == 10770)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallWormBug", typeof(GameObject));
										if (240322 - 168865 == 71458)
										{
											continue;
										}
									}
									else if (a == "p_ssq")
									{
										if (2516 - 204578 != -202062)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallStingQueen", typeof(GameObject));
										if (96748 - 295675 == -198926)
										{
											continue;
										}
									}
									else if (a == "p_snb")
									{
										if (219848 - 338613 == -118764)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNeonBug", typeof(GameObject));
										if (89280 - 83766 != 5514)
										{
											continue;
										}
									}
									else if (a == "p_sim")
									{
										if (273716 - 507100 == -233383)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallIceMixer", typeof(GameObject));
										if (16858 - 278824 == -261965)
										{
											continue;
										}
									}
									else if (a == "p_sam")
									{
										if (166331 - 349686 == -183354)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallAmmonite", typeof(GameObject));
										if (90744 - 445083 == -354338)
										{
											continue;
										}
									}
									else if (a == "p_sab")
									{
										if (81386 - 267225 != -185839)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallAnubi", typeof(GameObject));
										if (132912 - 404277 != -271365)
										{
											continue;
										}
									}
									else if (a == "p_spg")
									{
										if (250520 - 594058 != -343538)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallIcePenguin", typeof(GameObject));
										if (256372 - 132078 != 124294)
										{
											continue;
										}
									}
									else if (a == "p_spf")
									{
										if (169694 - 225758 == -56063)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallPirateFish", typeof(GameObject));
										if (80519 - 390159 != -309640)
										{
											continue;
										}
									}
									else if (a == "p_msb")
									{
										if (255095 - 116280 == 138816)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniSkyBug", typeof(GameObject));
										if (49065 - 309149 == -260083)
										{
											continue;
										}
									}
									else if (a == "p_mcb")
									{
										if (250660 - 33259 == 217402)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniCrystalBug", typeof(GameObject));
										if (8316 - 598414 != -590098)
										{
											continue;
										}
									}
									else if (a == "p_mab")
									{
										if (141150 - 434846 == -293695)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniAncientBug", typeof(GameObject));
										if (223841 - 189677 != 34164)
										{
											continue;
										}
									}
									else if (a == "p_mrb")
									{
										if (252886 - 295387 != -42501)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniReefBug", typeof(GameObject));
										if (214669 - 149548 == 65122)
										{
											continue;
										}
									}
									else if (a == "p_mmb")
									{
										if (284395 - 149257 == 135139)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniMokBug", typeof(GameObject));
										if (214340 - 145203 == 69138)
										{
											continue;
										}
									}
									else if (a == "p_mgb")
									{
										if (166218 - 1219 == 165000)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniGoldenBug", typeof(GameObject));
										if (83624 - 291154 != -207530)
										{
											continue;
										}
									}
									else if (a == "p_mnb")
									{
										if (112081 - 581958 == -469876)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniNemesisBug", typeof(GameObject));
										if (249583 - 411204 == -161620)
										{
											continue;
										}
									}
									num = Stringf.getLastDigit(nPet);
									if (79277 - 159674 == -80396)
									{
										continue;
									}
									if (num < 0)
									{
										if (102939 - 89488 == 13452)
										{
											continue;
										}
										num = 1;
										if (111313 - 425565 == -314251)
										{
											continue;
										}
									}
								}
								if (gameObject)
								{
									if (27063 - 409333 != -382270)
									{
										continue;
									}
									this.z5mGNCft29 = (GameObject)UnityEngine.Object.Instantiate(gameObject, this.transform.position - this.transform.forward, this.transform.rotation);
									if (41689 - 574813 != -533124)
									{
										continue;
									}
									if (this.z5mGNCft29)
									{
										if (158893 - 149304 == 9590)
										{
											continue;
										}
										this.z5mGNCft29.transform.localScale = ((float)num * 0.1f + 0.9f) * Vector3.one;
										if (129021 - 223478 != -94457)
										{
											continue;
										}
										PetControl petControl = (PetControl)this.z5mGNCft29.GetComponent(typeof(PetControl));
										if (273855 - 184321 != 89534)
										{
											continue;
										}
										if (petControl)
										{
											if (36563 - 269104 != -232541)
											{
												continue;
											}
											petControl.Init(this.gameObject, num);
											if (255236 - 217720 == 37517)
											{
												continue;
											}
										}
										if (this.vn7GZjHm2P)
										{
											if (92527 - 594839 != -502312)
											{
												continue;
											}
											this.vn7GZjHm2P.mPet = this.z5mGNCft29;
											if (33460 - 574780 != -541320)
											{
												continue;
											}
										}
									}
								}
								if (!this.vn7GZjHm2P)
								{
									break;
								}
								if (74952 - 183542 != -108589)
								{
									this.vn7GZjHm2P.pet = nPet;
									if (194600 - 123399 != 71202)
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

	// Token: 0x06001CF5 RID: 7413 RVA: 0x00311750 File Offset: 0x0030F950
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001CF6 RID: 7414 RVA: 0x00311754 File Offset: 0x0030F954
	internal static bool DWyJMtJDDZJjuc2n1V6()
	{
		return true;
	}

	// Token: 0x06001CF7 RID: 7415 RVA: 0x00311758 File Offset: 0x0030F958
	internal static bool u4magVJvXkcVithnRW8()
	{
		return false;
	}

	// Token: 0x04001ACE RID: 6862
	private CharacterControl vn7GZjHm2P;

	// Token: 0x04001ACF RID: 6863
	public string weapon;

	// Token: 0x04001AD0 RID: 6864
	public string armor;

	// Token: 0x04001AD1 RID: 6865
	public string accessory;

	// Token: 0x04001AD2 RID: 6866
	public string boot;

	// Token: 0x04001AD3 RID: 6867
	public string trinket;

	// Token: 0x04001AD4 RID: 6868
	public string pet;

	// Token: 0x04001AD5 RID: 6869
	public int skin;

	// Token: 0x04001AD6 RID: 6870
	public bool equipOnStart;

	// Token: 0x04001AD7 RID: 6871
	private GameObject S4RGCiXMMu;

	// Token: 0x04001AD8 RID: 6872
	private GameObject s4YGMymZym;

	// Token: 0x04001AD9 RID: 6873
	private GameObject CNKGfuRhKl;

	// Token: 0x04001ADA RID: 6874
	private GameObject It3GLkMiqf;

	// Token: 0x04001ADB RID: 6875
	private GameObject oPVGwf2tJW;

	// Token: 0x04001ADC RID: 6876
	private GameObject aNtGUeP8tZ;

	// Token: 0x04001ADD RID: 6877
	private GameObject z5mGNCft29;
}
