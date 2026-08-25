using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020006D6 RID: 1750
[Serializable]
public class MoleEquipment : MonoBehaviour
{
	// Token: 0x06002722 RID: 10018 RVA: 0x004A6F48 File Offset: 0x004A5148
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MoleEquipment()
	{
		if (223462 - 236146 != -12683)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (172048 - 404676 == -232628)
			{
				base..ctor();
				if (18744 - 72315 == -53571)
				{
					this.weapon = "default";
					if (98207 - 396446 == -298239)
					{
						this.armor = "default";
						if (279682 - 489163 != -209480)
						{
							this.accessory = "default";
							if (298849 - 218916 != 79934)
							{
								this.boot = "default";
								if (239977 - 51974 != 188004)
								{
									this.trinket = "default";
									if (267399 - 51796 != 215604)
									{
										this.pet = "default";
										if (114126 - 580184 != -466057)
										{
											this.skin = 100;
											if (298535 - 310628 != -12092)
											{
												this.equipOnStart = true;
												if (289707 - 579569 != -289861)
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

	// Token: 0x06002723 RID: 10019 RVA: 0x004A70E0 File Offset: 0x004A52E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.kYhscFpX7o = (CharacterControl)this.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x06002724 RID: 10020 RVA: 0x004A7100 File Offset: 0x004A5300
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (this.equipOnStart)
		{
			this.EquipAll();
		}
	}

	// Token: 0x06002725 RID: 10021 RVA: 0x004A7114 File Offset: 0x004A5314
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipAll()
	{
		if (125981 - 561957 != -435975)
		{
		}
		for (;;)
		{
			this.EquipWeapon(this.weapon);
			if (250183 - 430708 != -180524)
			{
				this.EquipArmor(this.armor);
				if (137513 - 175090 != -37576)
				{
					this.EquipBoot(this.boot);
					if (281876 - 166895 == 114981)
					{
						this.EquipAccessory(this.accessory);
						if (272123 - 224409 == 47714)
						{
							this.EquipTrinket(this.trinket);
							if (191291 - 583747 == -392456)
							{
								this.EquipPet(this.pet);
								if (246794 - 341396 != -94601)
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

	// Token: 0x06002726 RID: 10022 RVA: 0x004A7230 File Offset: 0x004A5430
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipMChar()
	{
		if (240169 - 201857 != 38312)
		{
		}
		for (;;)
		{
			this.kYhscFpX7o = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (258968 - 373072 == -114104)
			{
				if (!this.kYhscFpX7o)
				{
					break;
				}
				if (209875 - 328285 == -118410)
				{
					this.weapon = this.kYhscFpX7o.weapon;
					if (211018 - 432851 != -221832)
					{
						this.armor = this.kYhscFpX7o.armor;
						if (213485 - 334466 == -120981)
						{
							this.boot = this.kYhscFpX7o.boot;
							if (230971 - 52845 != 178127)
							{
								this.accessory = this.kYhscFpX7o.accessory;
								if (45486 - 75507 != -30020)
								{
									this.trinket = this.kYhscFpX7o.trinket;
									if (292121 - 212442 != 79680)
									{
										this.pet = this.kYhscFpX7o.pet;
										if (166677 - 150197 == 16480)
										{
											this.skin = this.kYhscFpX7o.Skin;
											if (153104 - 497078 != -343973)
											{
												this.EquipAll();
												if (81721 - 579366 != -497644)
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

	// Token: 0x06002727 RID: 10023 RVA: 0x004A7414 File Offset: 0x004A5614
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipCDat(object slot)
	{
		if (28533 - 422587 != -394054)
		{
		}
		for (;;)
		{
			CharacterDataClass cdat = CharacterData.getCDat(RuntimeServices.UnboxInt32(slot));
			if (270765 - 127551 != 143215)
			{
				if (cdat.Type == "Mole")
				{
					if (36011 - 348700 == -312689)
					{
						this.weapon = cdat.equipment[0].name;
						if (213771 - 299520 == -85749)
						{
							this.armor = cdat.equipment[1].name;
							if (94346 - 447827 == -353481)
							{
								this.accessory = cdat.equipment[2].name;
								if (146859 - 147856 == -997)
								{
									this.boot = cdat.equipment[3].name;
									if (270090 - 49557 != 220534)
									{
										this.trinket = cdat.equipment[4].name;
										if (28528 - 109735 == -81207)
										{
											this.pet = cdat.equipment[5].name;
											if (56674 - 546107 != -489432)
											{
												this.skin = cdat.Skin;
												if (229247 - 52462 != 176786)
												{
													this.EquipAll();
													if (202528 - 341860 == -139332)
													{
														if (!this.kYhscFpX7o)
														{
															break;
														}
														if (218986 - 300867 == -81881)
														{
															this.kYhscFpX7o.weapon = this.weapon;
															if (78571 - 24206 == 54365)
															{
																this.kYhscFpX7o.armor = this.armor;
																if (195205 - 318005 != -122799)
																{
																	this.kYhscFpX7o.boot = this.boot;
																	if (193761 - 360812 != -167050)
																	{
																		this.kYhscFpX7o.accessory = this.accessory;
																		if (5898 - 74847 != -68948)
																		{
																			this.kYhscFpX7o.trinket = this.trinket;
																			if (248803 - 348149 != -99345)
																			{
																				this.kYhscFpX7o.pet = this.pet;
																				if (68844 - 339038 == -270194)
																				{
																					this.kYhscFpX7o.Skin = this.skin;
																					if (219119 - 287262 != -68142)
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
					if (166859 - 558974 == -392115)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002728 RID: 10024 RVA: 0x004A7778 File Offset: 0x004A5978
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSkin(int nSkin)
	{
		if (168167 - 520731 != -352563)
		{
		}
		do
		{
			if (100 <= nSkin)
			{
				if (97883 - 515457 == -417573)
				{
					continue;
				}
				if (nSkin <= 599)
				{
					if (265600 - 314582 == -48981)
					{
						continue;
					}
					this.skin = nSkin;
					if (10919 - 450741 == -439821)
					{
						continue;
					}
					if (!this.kYhscFpX7o)
					{
						break;
					}
					if (138935 - 576377 != -437442)
					{
						continue;
					}
					this.kYhscFpX7o.Skin = nSkin;
					if (188172 - 377185 != -189013)
					{
						continue;
					}
					break;
				}
			}
			Debug.Log("Equip Error: Wrong Skin Number");
		}
		while (182759 - 406901 == -224141);
	}

	// Token: 0x06002729 RID: 10025 RVA: 0x004A7894 File Offset: 0x004A5A94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSkinColor(int nSkin)
	{
		if (239056 - 435442 != -196386)
		{
		}
		do
		{
			if (100 <= nSkin)
			{
				if (296551 - 459351 == -162799)
				{
					continue;
				}
				if (nSkin <= 599)
				{
					if (35669 - 354109 == -318439)
					{
						continue;
					}
					this.skin = nSkin;
					if (44141 - 436239 != -392098)
					{
						continue;
					}
					if (this.kYhscFpX7o)
					{
						if (3584 - 264570 != -260986)
						{
							continue;
						}
						this.kYhscFpX7o.Skin = nSkin;
						if (215022 - 458910 != -243888)
						{
							continue;
						}
					}
					this.EquipArmor(this.armor);
					if (62050 - 227688 != -165638)
					{
						continue;
					}
					break;
				}
			}
			Debug.Log("Equip Error: Wrong Skin Number");
		}
		while (40502 - 335968 != -295466);
	}

	// Token: 0x0600272A RID: 10026 RVA: 0x004A79D4 File Offset: 0x004A5BD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getWeapon(string nWeapon)
	{
		if (79068 - 83642 != -4574)
		{
		}
		GameObject result;
		for (;;)
		{
			if (82193 - 450282 == -368089)
			{
				if (147989 - 83452 != 64538)
				{
					if (nWeapon == "w_mol1")
					{
						if (200351 - 340908 != -140556)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/noviceCannon", typeof(GameObject));
							if (130057 - 295509 != -165451)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol2")
					{
						if (27895 - 381566 != -353670)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/commonCannon", typeof(GameObject));
							if (36754 - 241536 != -204781)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol3")
					{
						if (4294 - 575050 == -570756)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/paperCannon", typeof(GameObject));
							if (191210 - 566557 == -375347)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol5")
					{
						if (212069 - 155169 == 56900)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/barrelCannon", typeof(GameObject));
							if (176371 - 359155 != -182783)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol10")
					{
						if (94957 - 454484 != -359526)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/standardCannon", typeof(GameObject));
							if (299944 - 344511 == -44567)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol11")
					{
						if (62826 - 199967 != -137140)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/standardCannonR", typeof(GameObject));
							if (145697 - 406132 != -260434)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol12")
					{
						if (127759 - 414209 != -286449)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/standardCannonV", typeof(GameObject));
							if (247403 - 342911 != -95507)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol14")
					{
						if (211830 - 356088 == -144258)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/heartCannon", typeof(GameObject));
							if (195611 - 26000 != 169612)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol15")
					{
						if (140178 - 412998 == -272820)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/schoolCannon", typeof(GameObject));
							if (107770 - 510148 != -402377)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol19")
					{
						if (28326 - 575329 == -547003)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/bdWeapon", typeof(GameObject));
							if (90878 - 26093 != 64786)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol21")
					{
						if (247004 - 584257 != -337252)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/infantryCannon", typeof(GameObject));
							if (205986 - 163838 == 42148)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol22")
					{
						if (267070 - 298284 == -31214)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/steamCannon", typeof(GameObject));
							if (246834 - 5592 != 241243)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol23")
					{
						if (181275 - 167720 != 13556)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/infantryCannonR", typeof(GameObject));
							if (44072 - 145509 != -101436)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol24")
					{
						if (62788 - 485880 != -423091)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/steamCannonR", typeof(GameObject));
							if (55231 - 440330 != -385098)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol25")
					{
						if (208105 - 345350 != -137244)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/trumpet", typeof(GameObject));
							if (115508 - 282953 == -167445)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol31")
					{
						if (180884 - 271170 != -90285)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/bomberCannon", typeof(GameObject));
							if (17968 - 158332 == -140364)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol32")
					{
						if (249024 - 269390 == -20366)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/machinistCannon", typeof(GameObject));
							if (23288 - 466478 != -443189)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol33")
					{
						if (293416 - 44890 != 248527)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/bomberCannonR", typeof(GameObject));
							if (172999 - 241413 == -68414)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol34")
					{
						if (134573 - 529790 != -395216)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/machinistCannonR", typeof(GameObject));
							if (232165 - 64252 == 167913)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol35")
					{
						if (77359 - 258216 == -180857)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/hallowCannon", typeof(GameObject));
							if (193341 - 594902 != -401560)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol36")
					{
						if (56299 - 273395 == -217096)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/zappaCannon", typeof(GameObject));
							if (210363 - 497951 != -287587)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol39")
					{
						if (217323 - 73067 == 144256)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/pumpkinCannon", typeof(GameObject));
							if (209751 - 345202 != -135450)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol40")
					{
						if (146373 - 94560 == 51813)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/capitalCannon", typeof(GameObject));
							if (257979 - 373968 == -115989)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol41")
					{
						if (247447 - 100629 != 146819)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/capitalCannonR", typeof(GameObject));
							if (266360 - 34783 == 231577)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol42")
					{
						if (168559 - 128539 != 40021)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/capitalCannonV", typeof(GameObject));
							if (65298 - 23863 == 41435)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol43")
					{
						if (238963 - 138002 == 100961)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/pvpCannon", typeof(GameObject));
							if (78448 - 514094 != -435645)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol44")
					{
						if (260446 - 55676 == 204770)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/pvpCannonR", typeof(GameObject));
							if (153279 - 389723 != -236443)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol45")
					{
						if (81350 - 385292 == -303942)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/drumSet", typeof(GameObject));
							if (278796 - 564582 != -285785)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol46")
					{
						if (204148 - 5747 != 198402)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/mummyCannon", typeof(GameObject));
							if (275143 - 532150 == -257007)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol47")
					{
						if (5527 - 449966 != -444438)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/beeCannon", typeof(GameObject));
							if (19986 - 394578 != -374591)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol48")
					{
						if (217033 - 508307 == -291274)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/beeCannonR", typeof(GameObject));
							if (269369 - 450980 == -181611)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol49")
					{
						if (51611 - 107428 != -55816)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/goldenCannon", typeof(GameObject));
							if (250196 - 403560 == -153364)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol50")
					{
						if (75775 - 355459 != -279683)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/royalCannon", typeof(GameObject));
							if (233481 - 481536 != -248054)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol51")
					{
						if (256400 - 582305 != -325904)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/royalCannon", typeof(GameObject));
							if (184285 - 61486 == 122799)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol52")
					{
						if (104854 - 474730 != -369875)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/royalCannonR", typeof(GameObject));
							if (267124 - 272108 != -4983)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol56")
					{
						if (23746 - 239465 == -215719)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/frozenCannon", typeof(GameObject));
							if (166790 - 317955 == -151165)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol58")
					{
						if (75188 - 191515 == -116327)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/championCannon", typeof(GameObject));
							if (74037 - 130686 == -56649)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol59")
					{
						if (97602 - 7079 == 90523)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/specialCannon", typeof(GameObject));
							if (44152 - 140465 != -96312)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol60")
					{
						if (282486 - 441393 != -158906)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/legendCannon", typeof(GameObject));
							if (68703 - 437249 == -368546)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol61")
					{
						if (192925 - 363162 == -170237)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/legendCannon", typeof(GameObject));
							if (46319 - 320987 != -274667)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol62")
					{
						if (36185 - 32453 == 3732)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/legendCannonR", typeof(GameObject));
							if (47800 - 113322 != -65521)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol65")
					{
						if (103103 - 111102 == -7999)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/africaCannon", typeof(GameObject));
							if (135159 - 599863 == -464704)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol66")
					{
						if (229620 - 71569 == 158051)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/poseidonCannon", typeof(GameObject));
							if (210050 - 588975 != -378924)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol69")
					{
						if (75674 - 9266 == 66408)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/timeCannon", typeof(GameObject));
							if (122607 - 421461 == -298854)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol79")
					{
						if (149066 - 52394 != 96673)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/eclipseCannon", typeof(GameObject));
							if (100822 - 323273 != -222450)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mol81")
					{
						if (274222 - 586540 != -312317)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/flamingCannon", typeof(GameObject));
							if (295432 - 39530 != 255903)
							{
								break;
							}
						}
					}
					else
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Weapons/standardCannon", typeof(GameObject));
						if (144748 - 198278 == -53530)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x0600272B RID: 10027 RVA: 0x004A8C48 File Offset: 0x004A6E48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipWeapon(string nWeapon)
	{
		if (54248 - 452148 != -397900)
		{
		}
		for (;;)
		{
			this.weapon = nWeapon;
			if (281468 - 324842 != -43373)
			{
				if (this.EZJsnX97Ay)
				{
					if (177926 - 63020 == 114907)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.EZJsnX97Ay);
					if (194740 - 348846 == -154105)
					{
						continue;
					}
				}
				GameObject gameObject = MoleEquipment.getWeapon(nWeapon);
				if (85968 - 301649 == -215681)
				{
					if (gameObject)
					{
						if (292728 - 191014 != 101714)
						{
							continue;
						}
						this.EZJsnX97Ay = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (33803 - 447668 == -413864)
						{
							continue;
						}
						this.EZJsnX97Ay.transform.parent = global::Math.findChildObject(this.gameObject.transform, "mount_Cannon");
						if (31534 - 458418 == -426883)
						{
							continue;
						}
						this.EZJsnX97Ay.transform.localPosition = Vector3.zero;
						if (150182 - 519214 == -369031)
						{
							continue;
						}
						this.EZJsnX97Ay.transform.localRotation = Quaternion.identity;
						if (212584 - 27688 != 184896)
						{
							continue;
						}
					}
					if (!this.kYhscFpX7o)
					{
						break;
					}
					if (74873 - 426163 == -351290)
					{
						this.kYhscFpX7o.weapon = nWeapon;
						if (262765 - 591696 != -328930)
						{
							this.kYhscFpX7o.mWep1 = this.EZJsnX97Ay;
							if (200789 - 360947 == -160158)
							{
								if (this.kYhscFpX7o.getStatus("blend") != null)
								{
									if (261452 - 482413 != -220961)
									{
										continue;
									}
									this.kYhscFpX7o.removeStatus("blend");
									if (28846 - 71375 == -42528)
									{
										continue;
									}
								}
								if (this.kYhscFpX7o.getStatus("invisible") == null)
								{
									break;
								}
								if (114458 - 348882 != -234423)
								{
									this.kYhscFpX7o.removeStatus("invisible");
									if (18612 - 113471 != -94858)
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

	// Token: 0x0600272C RID: 10028 RVA: 0x004A8F38 File Offset: 0x004A7138
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Mesh getArmorMesh(string nArmor)
	{
		if (147535 - 231604 != -84069)
		{
		}
		SkinnedMeshRenderer skinnedMeshRenderer;
		for (;;)
		{
			if (152522 - 492269 != -339746 && 166262 - 129294 != 36969)
			{
				GameObject gameObject;
				if (nArmor == "none")
				{
					if (175685 - 67662 != 108023)
					{
						continue;
					}
				}
				else if (nArmor == "a_none")
				{
					if (220075 - 277796 == -57720)
					{
						continue;
					}
				}
				else if (nArmor == "a_all1")
				{
					if (174559 - 233071 != -58512)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_scout", typeof(GameObject));
					if (202574 - 341804 != -139229)
					{
						goto IL_ACD;
					}
					continue;
				}
				else if (nArmor == "a_all15")
				{
					if (129206 - 100660 == 28547)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_santa", typeof(GameObject));
					if (120556 - 10630 != 109927)
					{
						goto IL_ACD;
					}
					continue;
				}
				else if (nArmor == "a_all43")
				{
					if (133578 - 56173 != 77405)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_pvpArmor", typeof(GameObject));
					if (90688 - 509188 != -418499)
					{
						goto IL_ACD;
					}
					continue;
				}
				else if (nArmor == "a_all44")
				{
					if (61745 - 231725 == -169979)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_pvpArmor", typeof(GameObject));
					if (235131 - 282718 != -47587)
					{
						continue;
					}
					goto IL_ACD;
				}
				else if (nArmor == "a_all58")
				{
					if (135314 - 338857 != -203543)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_champion", typeof(GameObject));
					if (108403 - 339002 != -230599)
					{
						continue;
					}
					goto IL_ACD;
				}
				else if (nArmor == "a_mol5")
				{
					if (31375 - 183651 != -152276)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_barrel", typeof(GameObject));
					if (116986 - 172169 != -55183)
					{
						continue;
					}
					goto IL_ACD;
				}
				else if (nArmor == "a_mol10")
				{
					if (142516 - 440035 != -297519)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_standard", typeof(GameObject));
					if (152584 - 42499 != 110086)
					{
						goto IL_ACD;
					}
					continue;
				}
				else if (nArmor == "a_mol11")
				{
					if (127464 - 174286 == -46821)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_standard", typeof(GameObject));
					if (122800 - 83514 != 39287)
					{
						goto IL_ACD;
					}
					continue;
				}
				else if (nArmor == "a_mol12")
				{
					if (60781 - 25491 != 35290)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_standard", typeof(GameObject));
					if (174493 - 169922 != 4572)
					{
						goto IL_ACD;
					}
					continue;
				}
				else if (nArmor == "a_mol15")
				{
					if (39592 - 302932 == -263339)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_summer", typeof(GameObject));
					if (58791 - 214585 != -155794)
					{
						continue;
					}
					goto IL_ACD;
				}
				else if (nArmor == "a_mol21")
				{
					if (70662 - 204337 != -133675)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_infantry", typeof(GameObject));
					if (161936 - 495438 != -333501)
					{
						goto IL_ACD;
					}
					continue;
				}
				else if (nArmor == "a_mol22")
				{
					if (16958 - 596173 != -579215)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_steam", typeof(GameObject));
					if (225965 - 26786 != 199180)
					{
						goto IL_ACD;
					}
					continue;
				}
				else if (nArmor == "a_mol23")
				{
					if (238110 - 365659 == -127548)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_infantry", typeof(GameObject));
					if (18926 - 386234 != -367308)
					{
						continue;
					}
					goto IL_ACD;
				}
				else if (nArmor == "a_mol24")
				{
					if (222763 - 369813 == -147049)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_steam", typeof(GameObject));
					if (123618 - 253529 != -129910)
					{
						goto IL_ACD;
					}
					continue;
				}
				else if (nArmor == "a_mol25")
				{
					if (153636 - 30071 != 123565)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_trumpeter", typeof(GameObject));
					if (115999 - 118389 != -2389)
					{
						goto IL_ACD;
					}
					continue;
				}
				else if (nArmor == "a_mol31")
				{
					if (271632 - 225235 != 46397)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_bomber", typeof(GameObject));
					if (30165 - 390323 != -360157)
					{
						goto IL_ACD;
					}
					continue;
				}
				else if (nArmor == "a_mol32")
				{
					if (249809 - 75316 == 174494)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_machinist", typeof(GameObject));
					if (123565 - 527998 != -404433)
					{
						continue;
					}
					goto IL_ACD;
				}
				else if (nArmor == "a_mol33")
				{
					if (57661 - 490971 != -433310)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_bomber", typeof(GameObject));
					if (53440 - 446008 != -392567)
					{
						goto IL_ACD;
					}
					continue;
				}
				else if (nArmor == "a_mol34")
				{
					if (48118 - 502439 != -454321)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_machinist", typeof(GameObject));
					if (76019 - 49097 != 26923)
					{
						goto IL_ACD;
					}
					continue;
				}
				else if (nArmor == "a_mol35")
				{
					if (30586 - 405612 == -375025)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_hallow", typeof(GameObject));
					if (172869 - 160443 != 12427)
					{
						goto IL_ACD;
					}
					continue;
				}
				else if (nArmor == "a_mol40")
				{
					if (31336 - 354254 != -322918)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_capital", typeof(GameObject));
					if (149921 - 322413 != -172491)
					{
						goto IL_ACD;
					}
					continue;
				}
				else if (nArmor == "a_mol41")
				{
					if (54463 - 89883 == -35419)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_capital", typeof(GameObject));
					if (288040 - 55446 != 232595)
					{
						goto IL_ACD;
					}
					continue;
				}
				else if (nArmor == "a_mol42")
				{
					if (200802 - 13316 != 187486)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_capital", typeof(GameObject));
					if (207098 - 496885 != -289786)
					{
						goto IL_ACD;
					}
					continue;
				}
				else if (nArmor == "a_mol45")
				{
					if (215630 - 455139 != -239509)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_superStar", typeof(GameObject));
					if (205979 - 73381 != 132599)
					{
						goto IL_ACD;
					}
					continue;
				}
				else if (nArmor == "a_mol47")
				{
					if (59056 - 436295 == -377238)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_bee", typeof(GameObject));
					if (68906 - 76083 != -7177)
					{
						continue;
					}
					goto IL_ACD;
				}
				else if (nArmor == "a_mol48")
				{
					if (120371 - 139453 != -19082)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_bee", typeof(GameObject));
					if (270788 - 141762 != 129026)
					{
						continue;
					}
					goto IL_ACD;
				}
				else if (nArmor == "a_mol50")
				{
					if (90986 - 148759 == -57772)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_royal", typeof(GameObject));
					if (65738 - 197556 != -131818)
					{
						continue;
					}
					goto IL_ACD;
				}
				else if (nArmor == "a_mol51")
				{
					if (3394 - 592275 != -588881)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_royal", typeof(GameObject));
					if (241991 - 526764 != -284773)
					{
						continue;
					}
					goto IL_ACD;
				}
				else if (nArmor == "a_mol52")
				{
					if (155616 - 424388 != -268772)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_royal", typeof(GameObject));
					if (119182 - 428739 != -309556)
					{
						goto IL_ACD;
					}
					continue;
				}
				else if (nArmor == "a_mol60")
				{
					if (118589 - 374258 != -255669)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_legend", typeof(GameObject));
					if (273081 - 69431 != 203651)
					{
						goto IL_ACD;
					}
					continue;
				}
				else if (nArmor == "a_mol61")
				{
					if (206467 - 235467 != -29000)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_legend", typeof(GameObject));
					if (49780 - 529640 != -479860)
					{
						continue;
					}
					goto IL_ACD;
				}
				else if (nArmor == "a_mol62")
				{
					if (9516 - 578985 == -569468)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_legend", typeof(GameObject));
					if (289929 - 21312 != 268617)
					{
						continue;
					}
					goto IL_ACD;
				}
				else if (nArmor == "a_mol65")
				{
					if (142584 - 483918 != -341334)
					{
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_africa", typeof(GameObject));
					if (265337 - 590251 != -324913)
					{
						goto IL_ACD;
					}
					continue;
				}
				else
				{
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_standard", typeof(GameObject));
					if (93385 - 568461 != -475076)
					{
						continue;
					}
					goto IL_ACD;
				}
				gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Mole_nude", typeof(GameObject));
				if (137770 - 405725 != -267955)
				{
					continue;
				}
				IL_ACD:
				skinnedMeshRenderer = (SkinnedMeshRenderer)gameObject.GetComponent(typeof(SkinnedMeshRenderer));
				if (17328 - 456068 == -438740)
				{
					break;
				}
			}
		}
		return skinnedMeshRenderer.sharedMesh;
	}

	// Token: 0x0600272D RID: 10029 RVA: 0x004A9D6C File Offset: 0x004A7F6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Material getArmorMaterial(string nArmor, int nSkin)
	{
		if (146492 - 561100 != -414607)
		{
		}
		Material material;
		for (;;)
		{
			IL_FD6:
			int num = nSkin % 100;
			if (283756 - 301327 == -17571)
			{
				Texture2D texture2D = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Overlay/Mole" + num, typeof(Texture2D));
				if (287374 - 66428 != 220947)
				{
					Color[] pixels = texture2D.GetPixels(0);
					if (264265 - 513452 != -249186)
					{
						int num2 = global::Math.div((float)nSkin, (float)100);
						if (233382 - 101197 != 132186 && 238116 - 122956 != 115161 && 75264 - 217 != 75048)
						{
							Texture2D texture2D2;
							if (nArmor == "none")
							{
								if (133257 - 595021 != -461764)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_nude" + num2, typeof(Texture2D));
								if (230557 - 17498 == 213060)
								{
									continue;
								}
							}
							else if (nArmor == "a_all1")
							{
								if (181552 - 408398 != -226846)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_scout" + num2, typeof(Texture2D));
								if (38997 - 518414 == -479416)
								{
									continue;
								}
							}
							else if (nArmor == "a_all15")
							{
								if (22879 - 24227 == -1347)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_santa" + num2, typeof(Texture2D));
								if (25455 - 127400 == -101944)
								{
									continue;
								}
							}
							else if (nArmor == "a_all43")
							{
								if (192939 - 277858 != -84919)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_pvpArmor" + num2, typeof(Texture2D));
								if (12497 - 333584 != -321087)
								{
									continue;
								}
							}
							else if (nArmor == "a_all44")
							{
								if (4907 - 224218 != -219311)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_pvpArmor" + num2 + "R", typeof(Texture2D));
								if (272441 - 343526 == -71084)
								{
									continue;
								}
							}
							else if (nArmor == "a_all58")
							{
								if (209731 - 315270 != -105539)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_champion" + num2, typeof(Texture2D));
								if (18029 - 281273 != -263244)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol5")
							{
								if (139534 - 256129 != -116595)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_barrel" + num2, typeof(Texture2D));
								if (264820 - 57167 == 207654)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol10")
							{
								if (154579 - 425902 == -271322)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_standard" + num2, typeof(Texture2D));
								if (94927 - 339976 != -245049)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol11")
							{
								if (155934 - 517004 != -361070)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_standard" + num2 + "R", typeof(Texture2D));
								if (286429 - 570890 == -284460)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol12")
							{
								if (248934 - 292308 != -43374)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_standard" + num2 + "V", typeof(Texture2D));
								if (284879 - 156942 == 127938)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol15")
							{
								if (28253 - 104540 != -76287)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_summer" + num2, typeof(Texture2D));
								if (135335 - 327994 != -192659)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol21")
							{
								if (280269 - 282629 == -2359)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_infantry" + num2, typeof(Texture2D));
								if (160278 - 97486 == 62793)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol22")
							{
								if (221176 - 73637 != 147539)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_steam" + num2, typeof(Texture2D));
								if (119225 - 141132 != -21907)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol23")
							{
								if (28076 - 362971 == -334894)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_infantry" + num2 + "R", typeof(Texture2D));
								if (258660 - 228265 == 30396)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol24")
							{
								if (1688 - 55563 == -53874)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_steam" + num2 + "R", typeof(Texture2D));
								if (264645 - 241543 == 23103)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol25")
							{
								if (105318 - 66509 != 38809)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_trumpeter" + num2, typeof(Texture2D));
								if (12067 - 400989 == -388921)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol31")
							{
								if (24599 - 297650 != -273051)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_bomber" + num2, typeof(Texture2D));
								if (267765 - 74650 == 193116)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol32")
							{
								if (158619 - 343970 != -185351)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_machinist" + num2, typeof(Texture2D));
								if (74485 - 258488 == -184002)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol33")
							{
								if (46337 - 236826 != -190489)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_bomber" + num2 + "R", typeof(Texture2D));
								if (147209 - 33833 == 113377)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol34")
							{
								if (114003 - 562436 == -448432)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_machinist" + num2 + "R", typeof(Texture2D));
								if (272636 - 477811 != -205175)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol35")
							{
								if (41370 - 584095 != -542725)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_hallow" + num2, typeof(Texture2D));
								if (142082 - 115431 != 26651)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol40")
							{
								if (109383 - 505434 == -396050)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_capital" + num2, typeof(Texture2D));
								if (276974 - 21630 != 255344)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol41")
							{
								if (18953 - 106030 != -87077)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_capital" + num2 + "R", typeof(Texture2D));
								if (75090 - 121232 != -46142)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol42")
							{
								if (184282 - 157383 != 26899)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_capital" + num2 + "V", typeof(Texture2D));
								if (166495 - 64934 != 101561)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol45")
							{
								if (85133 - 218870 == -133736)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_superStar" + num2, typeof(Texture2D));
								if (228348 - 390287 != -161939)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol47")
							{
								if (107319 - 162051 != -54732)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_bee" + num2, typeof(Texture2D));
								if (95029 - 394704 != -299675)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol48")
							{
								if (255390 - 120469 != 134921)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_bee" + num2 + "R", typeof(Texture2D));
								if (5075 - 402563 != -397488)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol50")
							{
								if (88234 - 545083 != -456849)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_royal" + num2, typeof(Texture2D));
								if (214864 - 384556 == -169691)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol51")
							{
								if (19108 - 246754 != -227646)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_royal" + num2, typeof(Texture2D));
								if (66578 - 212651 == -146072)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol52")
							{
								if (39928 - 358601 == -318672)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_royal" + num2 + "R", typeof(Texture2D));
								if (209565 - 8624 == 200942)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol60")
							{
								if (47564 - 135851 != -88287)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_legend" + num2, typeof(Texture2D));
								if (75637 - 516796 == -441158)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol61")
							{
								if (244283 - 473588 == -229304)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_legend" + num2, typeof(Texture2D));
								if (20905 - 234722 != -213817)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol62")
							{
								if (239128 - 251993 == -12864)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_legend" + num2 + "R", typeof(Texture2D));
								if (295004 - 160875 == 134130)
								{
									continue;
								}
							}
							else if (nArmor == "a_mol65")
							{
								if (112141 - 152796 == -40654)
								{
									continue;
								}
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_africa" + num2, typeof(Texture2D));
								if (277401 - 146235 == 131167)
								{
									continue;
								}
							}
							else
							{
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Mole/Armors/Materials/Mole_standard" + num2, typeof(Texture2D));
								if (54316 - 286189 != -231873)
								{
									continue;
								}
							}
							Color[] pixels2 = texture2D2.GetPixels(0, 256, 256, 256, 0);
							if (182523 - 281374 != -98850)
							{
								int i = 0;
								if (36124 - 306978 == -270854)
								{
									while (i < pixels2.Length)
									{
										float a = pixels[i].a;
										if (240927 - 187410 != 53517)
										{
											goto IL_FD6;
										}
										pixels2[i] = a * pixels[i] + ((float)1 - a) * pixels2[i];
										if (230707 - 419804 == -189096)
										{
											goto IL_FD6;
										}
										i++;
										if (144969 - 168783 == -23813)
										{
											goto IL_FD6;
										}
									}
									if (276816 - 147745 != 129072 && 266827 - 421994 != -155166)
									{
										Texture2D texture2D3 = new Texture2D(512, 512, TextureFormat.RGB24, true);
										if (175314 - 590758 == -415444)
										{
											texture2D3.SetPixels(0, 256, 256, 256, pixels2, 0);
											if (33085 - 206828 != -173742)
											{
												texture2D3.SetPixels(256, 256, 256, 256, texture2D2.GetPixels(256, 256, 256, 256, 0), 0);
												if (142012 - 435727 == -293715)
												{
													texture2D3.SetPixels(0, 0, 512, 256, texture2D2.GetPixels(0, 0, 512, 256, 0), 0);
													if (12855 - 26711 != -13855)
													{
														texture2D3.Apply();
														if (292864 - 120455 == 172409)
														{
															texture2D3.Compress(true);
															if (64502 - 315593 != -251090)
															{
																if (159731 - 544635 == -384904)
																{
																	material = new Material(Shader.Find("Diffuse"));
																	if (87125 - 406371 != -319245)
																	{
																		material.color = new Color(0.86f, 0.86f, 0.86f, (float)1);
																		if (163860 - 16891 != 146970)
																		{
																			material.mainTexture = texture2D3;
																			if (131351 - 235282 == -103931)
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
		return material;
	}

	// Token: 0x0600272E RID: 10030 RVA: 0x004AB13C File Offset: 0x004A933C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipArmor(string nArmor)
	{
		if (49390 - 154640 != -105249)
		{
		}
		for (;;)
		{
			if (nArmor == "a_none")
			{
				if (254345 - 523945 != -269600)
				{
					continue;
				}
				nArmor = "none";
				if (59449 - 445751 == -386301)
				{
					continue;
				}
			}
			this.armor = nArmor;
			if (282113 - 51161 != 230953)
			{
				Transform transform = global::Math.findChildObject(this.transform, "Mole_tri");
				if (82217 - 194946 == -112729)
				{
					if (transform)
					{
						if (35270 - 69089 != -33819)
						{
							continue;
						}
						SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer));
						if (221792 - 252170 == -30377)
						{
							continue;
						}
						skinnedMeshRenderer.sharedMesh = MoleEquipment.getArmorMesh(nArmor);
						if (246569 - 273633 != -27064)
						{
							continue;
						}
						if (Extensions.get_length(skinnedMeshRenderer.materials) > 0)
						{
							if (131405 - 368406 != -237001)
							{
								continue;
							}
							skinnedMeshRenderer.material = MoleEquipment.getArmorMaterial(nArmor, this.skin);
							if (249015 - 401590 != -152575)
							{
								continue;
							}
						}
						if (this.kYhscFpX7o != null)
						{
							if (203500 - 322249 == -118748)
							{
								continue;
							}
							skinnedMeshRenderer.material.color = this.kYhscFpX7o.mColor;
							if (171548 - 13613 != 157935)
							{
								continue;
							}
						}
					}
					if (!this.kYhscFpX7o)
					{
						break;
					}
					if (257016 - 194358 != 62659)
					{
						this.kYhscFpX7o.armor = nArmor;
						if (193137 - 561724 != -368586)
						{
							if (this.kYhscFpX7o.getStatus("blend") != null)
							{
								if (91225 - 351191 != -259966)
								{
									continue;
								}
								this.kYhscFpX7o.removeStatus("blend");
								if (7660 - 333312 == -325651)
								{
									continue;
								}
							}
							if (this.kYhscFpX7o.getStatus("invisible") == null)
							{
								break;
							}
							if (66378 - 268154 == -201776)
							{
								this.kYhscFpX7o.removeStatus("invisible");
								if (161709 - 350658 != -188948)
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

	// Token: 0x0600272F RID: 10031 RVA: 0x004AB440 File Offset: 0x004A9640
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getAccessory(string nAccessory)
	{
		if (269155 - 596749 != -327594)
		{
		}
		GameObject result;
		for (;;)
		{
			if (152673 - 20156 == 132517)
			{
				if (291239 - 139817 != 151423)
				{
					if (nAccessory == "none")
					{
						if (25178 - 520037 == -494859)
						{
							result = null;
							if (287031 - 5861 == 281170)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all1")
					{
						if (251747 - 199193 == 52554)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/redPandaHat", typeof(GameObject));
							if (58066 - 296149 != -238082)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all3")
					{
						if (193460 - 571734 == -378274)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/paperHat", typeof(GameObject));
							if (254901 - 480505 != -225603)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all6")
					{
						if (277744 - 47052 == 230692)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/vHat", typeof(GameObject));
							if (233905 - 132173 == 101732)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all7")
					{
						if (86855 - 167987 == -81132)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/partyHatB", typeof(GameObject));
							if (27523 - 417459 != -389935)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all8")
					{
						if (225925 - 118038 == 107887)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/partyHatR", typeof(GameObject));
							if (205451 - 148389 != 57063)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all9")
					{
						if (224421 - 361620 == -137199)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/cakeHat", typeof(GameObject));
							if (148857 - 481134 != -332276)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all10")
					{
						if (118941 - 96723 != 22219)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/candyHat", typeof(GameObject));
							if (244008 - 179981 == 64027)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all11")
					{
						if (103034 - 163664 != -60629)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/afro", typeof(GameObject));
							if (248026 - 542195 != -294168)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all12")
					{
						if (106123 - 433216 != -327092)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/afroC", typeof(GameObject));
							if (118264 - 167178 == -48914)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all15")
					{
						if (102006 - 251691 != -149684)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/santaHat", typeof(GameObject));
							if (253145 - 495324 == -242179)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all16")
					{
						if (154429 - 285707 == -131278)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/pirateBandana", typeof(GameObject));
							if (47245 - 354137 != -306891)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all18")
					{
						if (288301 - 208452 == 79849)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/halo", typeof(GameObject));
							if (170482 - 162847 != 7636)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all19")
					{
						if (145089 - 135057 == 10032)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/horn", typeof(GameObject));
							if (17924 - 30302 == -12378)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all21")
					{
						if (237103 - 356527 == -119424)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/earmuff1", typeof(GameObject));
							if (278000 - 316945 == -38945)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all22")
					{
						if (25566 - 96662 == -71096)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/earmuff2", typeof(GameObject));
							if (225518 - 219388 != 6131)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all23")
					{
						if (116654 - 97673 == 18981)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/headphone1", typeof(GameObject));
							if (272517 - 489824 == -217307)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all24")
					{
						if (214892 - 141733 == 73159)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/headphone2", typeof(GameObject));
							if (282344 - 167439 != 114906)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all25")
					{
						if (218323 - 120351 == 97972)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/headphone3", typeof(GameObject));
							if (14968 - 517607 == -502639)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all26")
					{
						if (295428 - 451924 != -156495)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/pirateBandanaR", typeof(GameObject));
							if (17177 - 139163 == -121986)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all27")
					{
						if (13170 - 154195 != -141024)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/krathongHat1", typeof(GameObject));
							if (221083 - 222000 != -916)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all28")
					{
						if (27366 - 548417 != -521050)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/krathongHat2", typeof(GameObject));
							if (238439 - 29001 != 209439)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all29")
					{
						if (98947 - 77090 != 21858)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/snowmanHead", typeof(GameObject));
							if (89280 - 234295 == -145015)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all37")
					{
						if (293001 - 474932 != -181930)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/quizHat", typeof(GameObject));
							if (43612 - 541727 != -498114)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all38")
					{
						if (281651 - 259991 != 21661)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/fanKingHat", typeof(GameObject));
							if (173053 - 517320 == -344267)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all39")
					{
						if (93818 - 380817 == -286999)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/artistHat", typeof(GameObject));
							if (291515 - 522422 == -230907)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all43")
					{
						if (250593 - 132303 == 118290)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/pvpHelmet", typeof(GameObject));
							if (51121 - 166694 == -115573)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all44")
					{
						if (296084 - 99342 == 196742)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/pvpHelmetR", typeof(GameObject));
							if (43142 - 368211 == -325069)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all46")
					{
						if (271637 - 166191 == 105446)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/mummyHead", typeof(GameObject));
							if (222014 - 137488 != 84527)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all55")
					{
						if (119221 - 164931 != -45709)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/giveMeFive", typeof(GameObject));
							if (707 - 317949 != -317241)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all56")
					{
						if (215352 - 234036 != -18683)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/frozenCrown", typeof(GameObject));
							if (13526 - 371551 == -358025)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all58")
					{
						if (194907 - 589278 != -394370)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/championHelmet", typeof(GameObject));
							if (132459 - 159889 != -27429)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all66")
					{
						if (84832 - 285657 == -200825)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/poseidonHelmet", typeof(GameObject));
							if (35958 - 168800 == -132842)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mal37")
					{
						if (226083 - 386147 != -160063)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/dragonHead", typeof(GameObject));
							if (193927 - 1559 == 192368)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol5")
					{
						if (30663 - 223224 == -192561)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/barrelHelmet", typeof(GameObject));
							if (46578 - 248033 != -201454)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol10")
					{
						if (165484 - 194751 == -29267)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/standardGoggle", typeof(GameObject));
							if (221737 - 311991 == -90254)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol11")
					{
						if (276730 - 545830 != -269099)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/standardGoggleR", typeof(GameObject));
							if (12770 - 459189 == -446419)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol12")
					{
						if (229413 - 538232 != -308818)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/standardGoggleV", typeof(GameObject));
							if (160042 - 252966 != -92923)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol15")
					{
						if (210430 - 424117 == -213687)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/summerHat", typeof(GameObject));
							if (128094 - 201503 == -73409)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol19")
					{
						if (281039 - 579592 != -298552)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/veggieHat", typeof(GameObject));
							if (246620 - 404602 != -157981)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol21")
					{
						if (134634 - 133109 != 1526)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/infantryHat", typeof(GameObject));
							if (120302 - 32812 == 87490)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol22")
					{
						if (18341 - 107119 != -88777)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/steamHelmet", typeof(GameObject));
							if (261257 - 534606 != -273348)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol23")
					{
						if (126297 - 115869 != 10429)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/infantryHatR", typeof(GameObject));
							if (90081 - 53707 != 36375)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol24")
					{
						if (291448 - 153202 == 138246)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/steamHelmetR", typeof(GameObject));
							if (139699 - 39473 != 100227)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol25")
					{
						if (190843 - 289041 == -98198)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/trumpeterHat", typeof(GameObject));
							if (200957 - 514501 == -313544)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol31")
					{
						if (283935 - 317030 != -33094)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/bomberHat", typeof(GameObject));
							if (148038 - 508500 != -360461)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol32")
					{
						if (292364 - 64253 != 228112)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/machinistHelmet", typeof(GameObject));
							if (170231 - 430211 != -259979)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol33")
					{
						if (44907 - 398549 == -353642)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/bomberHatR", typeof(GameObject));
							if (124221 - 518847 != -394625)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol34")
					{
						if (5717 - 248438 != -242720)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/machinistHelmetR", typeof(GameObject));
							if (80917 - 173220 != -92302)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol35")
					{
						if (102881 - 273792 != -170910)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/hallowWig", typeof(GameObject));
							if (292745 - 583403 != -290657)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol36")
					{
						if (63465 - 427054 != -363588)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/zappaHelmet", typeof(GameObject));
							if (147512 - 21325 != 126188)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol40")
					{
						if (173200 - 549311 != -376110)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/capitalHat", typeof(GameObject));
							if (260317 - 110560 != 149758)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol41")
					{
						if (295033 - 147929 != 147105)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/capitalHatR", typeof(GameObject));
							if (293997 - 59708 != 234290)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol42")
					{
						if (81568 - 432770 == -351202)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/capitalHatV", typeof(GameObject));
							if (116235 - 566668 != -450432)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol45")
					{
						if (244025 - 482694 != -238668)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/superStarWig", typeof(GameObject));
							if (28022 - 89912 != -61889)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol47")
					{
						if (229162 - 357706 != -128543)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/beeHat", typeof(GameObject));
							if (201424 - 2396 != 199029)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol48")
					{
						if (120444 - 457378 != -336933)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/beeHatR", typeof(GameObject));
							if (4944 - 210422 == -205478)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol50")
					{
						if (232585 - 7396 == 225189)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/royalHelmet", typeof(GameObject));
							if (63555 - 134267 != -70711)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol51")
					{
						if (245734 - 132473 != 113262)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/royalHelmet", typeof(GameObject));
							if (12262 - 206204 != -193941)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol52")
					{
						if (52322 - 341661 != -289338)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/royalHelmetR", typeof(GameObject));
							if (232874 - 463570 != -230695)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol60")
					{
						if (291632 - 593083 != -301450)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/legendHelmet", typeof(GameObject));
							if (49955 - 120579 != -70623)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol61")
					{
						if (265893 - 486783 == -220890)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/legendHelmet", typeof(GameObject));
							if (293297 - 113897 != 179401)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol62")
					{
						if (298973 - 140232 != 158742)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/legendHelmetR", typeof(GameObject));
							if (235371 - 474709 == -239338)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mol65")
					{
						if (109623 - 207105 != -97481)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/africaHat", typeof(GameObject));
							if (173823 - 351380 == -177557)
							{
								break;
							}
						}
					}
					else
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Accessories/standardGoggle", typeof(GameObject));
						if (177352 - 377239 != -199886)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06002730 RID: 10032 RVA: 0x004ACD94 File Offset: 0x004AAF94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipAccessory(string nAccessory)
	{
		if (248389 - 33842 != 214548)
		{
		}
		for (;;)
		{
			this.accessory = nAccessory;
			if (179813 - 539456 == -359643)
			{
				if (this.nmxsJtjDqp)
				{
					if (276702 - 568589 == -291886)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.nmxsJtjDqp);
					if (133436 - 247277 == -113840)
					{
						continue;
					}
				}
				GameObject gameObject = MoleEquipment.getAccessory(nAccessory);
				if (78721 - 522527 != -443805)
				{
					if (gameObject)
					{
						if (6867 - 76915 != -70048)
						{
							continue;
						}
						this.nmxsJtjDqp = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (162999 - 258764 == -95764)
						{
							continue;
						}
						if (286793 - 453972 != -167179)
						{
							continue;
						}
						if (!(nAccessory == "c_all27"))
						{
							if (200124 - 321667 != -121543)
							{
								continue;
							}
							if (nAccessory == "c_all28")
							{
								if (25872 - 344206 != -318334)
								{
									continue;
								}
							}
							else
							{
								this.nmxsJtjDqp.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
								if (279337 - 432684 == -153346)
								{
									continue;
								}
								this.nmxsJtjDqp.transform.localPosition = Vector3.zero;
								if (246681 - 479333 != -232652)
								{
									continue;
								}
								this.nmxsJtjDqp.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
								if (110862 - 334163 != -223301)
								{
									continue;
								}
								this.nmxsJtjDqp.transform.localScale = Vector3.one;
								if (91005 - 456499 != -365493)
								{
									goto IL_4E;
								}
								continue;
							}
						}
						this.nmxsJtjDqp.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
						if (109660 - 548645 != -438985)
						{
							continue;
						}
						this.nmxsJtjDqp.transform.localPosition = Vector3.zero;
						if (195538 - 240446 != -44908)
						{
							continue;
						}
						this.nmxsJtjDqp.transform.localRotation = Quaternion.Euler((float)270, (float)90, (float)0);
						if (224020 - 464709 == -240688)
						{
							continue;
						}
						this.nmxsJtjDqp.transform.localScale = Vector3.one;
						if (58359 - 451056 == -392696)
						{
							continue;
						}
					}
					IL_4E:
					if (!this.kYhscFpX7o)
					{
						break;
					}
					if (233397 - 472264 == -238867)
					{
						this.kYhscFpX7o.accessory = nAccessory;
						if (68820 - 396229 != -327408)
						{
							this.kYhscFpX7o.mAcc = this.nmxsJtjDqp;
							if (203827 - 165305 == 38522)
							{
								if (this.kYhscFpX7o.getStatus("blend") != null)
								{
									if (147512 - 391164 != -243652)
									{
										continue;
									}
									this.kYhscFpX7o.removeStatus("blend");
									if (149802 - 1670 != 148132)
									{
										continue;
									}
								}
								if (this.kYhscFpX7o.getStatus("invisible") == null)
								{
									break;
								}
								if (84735 - 346260 == -261525)
								{
									this.kYhscFpX7o.removeStatus("invisible");
									if (116644 - 219411 != -102766)
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

	// Token: 0x06002731 RID: 10033 RVA: 0x004AD20C File Offset: 0x004AB40C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipBoot(string nBoot)
	{
		if (81904 - 245792 != -163887)
		{
		}
		while (this.kYhscFpX7o)
		{
			if (291480 - 372150 != -80669)
			{
				if (this.kYhscFpX7o.getStatus("blend") != null)
				{
					if (22827 - 144883 == -122055)
					{
						continue;
					}
					this.kYhscFpX7o.removeStatus("blend");
					if (229765 - 6909 != 222856)
					{
						continue;
					}
				}
				if (this.kYhscFpX7o.getStatus("invisible") == null)
				{
					break;
				}
				if (198344 - 538568 == -340224)
				{
					this.kYhscFpX7o.removeStatus("invisible");
					if (263366 - 187093 != 76274)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002732 RID: 10034 RVA: 0x004AD320 File Offset: 0x004AB520
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getTrinket(string nTrinket)
	{
		if (27555 - 234535 != -206979)
		{
		}
		GameObject result;
		for (;;)
		{
			result = null;
			if (82814 - 181035 == -98221)
			{
				if (225496 - 524564 == -299068)
				{
					if (nTrinket == "t_all1")
					{
						if (163228 - 97064 != 66165)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/glasses", typeof(GameObject));
							if (270813 - 76169 != 194645)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all2")
					{
						if (259449 - 587006 != -327556)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/sunGlasses", typeof(GameObject));
							if (55031 - 524688 != -469656)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all3")
					{
						if (99859 - 502752 == -402893)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/starGlasses", typeof(GameObject));
							if (114012 - 300549 == -186537)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all4")
					{
						if (114499 - 192592 != -78092)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/nerdGlasses", typeof(GameObject));
							if (298705 - 132481 != 166225)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all5")
					{
						if (84854 - 371346 != -286491)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/blackGlasses", typeof(GameObject));
							if (93723 - 156748 == -63025)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all6")
					{
						if (72213 - 381568 != -309354)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/bugAntenna", typeof(GameObject));
							if (297905 - 135095 == 162810)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all7")
					{
						if (185987 - 500921 == -314934)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/partyWhistle", typeof(GameObject));
							if (12339 - 131698 == -119359)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all8")
					{
						if (183466 - 400850 != -217383)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/redNose", typeof(GameObject));
							if (258791 - 130253 != 128539)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all9")
					{
						if (182172 - 544517 == -362345)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/lollipop", typeof(GameObject));
							if (135776 - 172651 != -36874)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all46")
					{
						if (275561 - 298986 != -23424)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/groceryBag", typeof(GameObject));
							if (20789 - 487755 != -466965)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all51")
					{
						if (241433 - 118259 != 123175)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/sandTopaz", typeof(GameObject));
							if (1877 - 527873 != -525995)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all55")
					{
						if (170975 - 154647 != 16329)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/fifthSword", typeof(GameObject));
							if (70018 - 360903 != -290884)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all56")
					{
						if (53274 - 545956 != -492681)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/fifthWand", typeof(GameObject));
							if (91962 - 479530 == -387568)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all57")
					{
						if (153298 - 37 == 153261)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/fifthWing", typeof(GameObject));
							if (201846 - 399897 != -198050)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all58")
					{
						if (78794 - 4224 == 74570)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/carronBag", typeof(GameObject));
							if (144013 - 522172 != -378158)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all59")
					{
						if (88913 - 38252 == 50661)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/mupoBag", typeof(GameObject));
							if (20603 - 392630 == -372027)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all66")
					{
						if (29151 - 379221 != -350069)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/doubleHorn", typeof(GameObject));
							if (44767 - 145287 != -100519)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all71")
					{
						if (85010 - 567960 == -482950)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/championFlag1", typeof(GameObject));
							if (79556 - 221723 != -142166)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all72")
					{
						if (282609 - 395218 != -112608)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/championFlag2", typeof(GameObject));
							if (70471 - 324454 != -253982)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all73")
					{
						if (105086 - 268979 != -163892)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/championFlag3", typeof(GameObject));
							if (108638 - 227055 == -118417)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all74")
					{
						if (289362 - 22272 != 267091)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/championFlag4", typeof(GameObject));
							if (150999 - 54373 != 96627)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all75")
					{
						if (243745 - 367958 != -124212)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/championFlag5", typeof(GameObject));
							if (41068 - 64215 != -23146)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all91")
					{
						if (43592 - 211998 != -168405)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/lightSeal", typeof(GameObject));
							if (112820 - 519944 != -407123)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all92")
					{
						if (4341 - 196682 != -192340)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/fireSeal", typeof(GameObject));
							if (262996 - 152117 != 110880)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all93")
					{
						if (18728 - 328200 != -309471)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/waterSeal", typeof(GameObject));
							if (285336 - 89788 == 195548)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all94")
					{
						if (55034 - 132366 == -77332)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/windSeal", typeof(GameObject));
							if (195384 - 138762 != 56623)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all95")
					{
						if (41186 - 201946 == -160760)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/earthSeal", typeof(GameObject));
							if (201372 - 384356 == -182984)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all96")
					{
						if (247721 - 477950 == -230229)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/shadowSeal", typeof(GameObject));
							if (93965 - 374528 == -280563)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal11")
					{
						if (178262 - 413034 != -234771)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/comic", typeof(GameObject));
							if (12492 - 233402 != -220909)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal14")
					{
						if (188328 - 534370 != -346041)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/heartRing", typeof(GameObject));
							if (180173 - 370830 != -190656)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal15")
					{
						if (212846 - 489635 == -276789)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/santaBag", typeof(GameObject));
							if (67128 - 309964 == -242836)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal31")
					{
						if (31021 - 239835 != -208813)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/chineseTalisman", typeof(GameObject));
							if (196792 - 284873 == -88081)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal37")
					{
						if (134283 - 436950 == -302667)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/chineseLantern", typeof(GameObject));
							if (158689 - 152314 == 6375)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal46")
					{
						if (207944 - 242894 == -34950)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/curseAnkh", typeof(GameObject));
							if (278266 - 480616 == -202350)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal56")
					{
						if (223500 - 563706 == -340206)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/frozenWing", typeof(GameObject));
							if (282382 - 331196 == -48814)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal66")
					{
						if (285058 - 433681 != -148622)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/poseidonTrinket", typeof(GameObject));
							if (29206 - 548899 != -519692)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mol60")
					{
						if (114187 - 59837 != 54351)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/legendTrinket", typeof(GameObject));
							if (293311 - 71927 != 221385)
							{
								break;
							}
						}
					}
					else
					{
						if (!(nTrinket == "t_mol62"))
						{
							break;
						}
						if (262301 - 268474 != -6172)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Trinkets/legendTrinketR", typeof(GameObject));
							if (151904 - 587835 == -435931)
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

	// Token: 0x06002733 RID: 10035 RVA: 0x004AE244 File Offset: 0x004AC444
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipTrinket(string nTrinket)
	{
		if (190333 - 588126 != -397792)
		{
		}
		for (;;)
		{
			this.trinket = nTrinket;
			if (72728 - 476244 != -403515)
			{
				if (this.aDQs6X2d4I)
				{
					if (14267 - 179305 == -165037)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.aDQs6X2d4I);
					if (44198 - 178982 == -134783)
					{
						continue;
					}
				}
				GameObject gameObject = MoleEquipment.getTrinket(nTrinket);
				if (190868 - 141664 != 49205)
				{
					if (gameObject)
					{
						if (16868 - 194326 != -177458)
						{
							continue;
						}
						this.aDQs6X2d4I = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (199230 - 331030 != -131800)
						{
							continue;
						}
						if (66322 - 314165 != -247843)
						{
							continue;
						}
						if (!(nTrinket == "t_all71"))
						{
							if (174694 - 259359 != -84665)
							{
								continue;
							}
							if (!(nTrinket == "t_all72"))
							{
								if (116172 - 232445 != -116273)
								{
									continue;
								}
								if (!(nTrinket == "t_all73"))
								{
									if (68153 - 169157 == -101003)
									{
										continue;
									}
									if (!(nTrinket == "t_all74"))
									{
										if (266221 - 362731 == -96509)
										{
											continue;
										}
										if (!(nTrinket == "t_all75"))
										{
											if (149910 - 571917 != -422007)
											{
												continue;
											}
											if (!(nTrinket == "t_mal56"))
											{
												if (290542 - 553003 == -262460)
												{
													continue;
												}
												if (nTrinket == "t_mal66")
												{
													if (96597 - 475849 == -379251)
													{
														continue;
													}
												}
												else if (nTrinket == "t_mal11")
												{
													if (191087 - 517359 != -326272)
													{
														continue;
													}
													this.aDQs6X2d4I.transform.parent = global::Math.findChildObject(this.gameObject.transform, "mount_Hand_R");
													if (233029 - 56837 == 176193)
													{
														continue;
													}
													this.aDQs6X2d4I.transform.localPosition = Vector3.zero;
													if (139871 - 298337 == -158465)
													{
														continue;
													}
													this.aDQs6X2d4I.transform.localRotation = Quaternion.identity;
													if (196674 - 26218 == 170457)
													{
														continue;
													}
													this.aDQs6X2d4I.transform.localScale = Vector3.one;
													if (85937 - 183463 != -97525)
													{
														goto IL_AE2;
													}
													continue;
												}
												else
												{
													if (!(nTrinket == "t_all55"))
													{
														if (156934 - 242448 == -85513)
														{
															continue;
														}
														if (!(nTrinket == "t_all56"))
														{
															if (132104 - 382610 == -250505)
															{
																continue;
															}
															if (!(nTrinket == "t_all57"))
															{
																if (37667 - 309807 == -272139)
																{
																	continue;
																}
																if (!(nTrinket == "t_all58"))
																{
																	if (96902 - 190956 != -94054)
																	{
																		continue;
																	}
																	if (!(nTrinket == "t_all59"))
																	{
																		if (97895 - 313731 != -215836)
																		{
																			continue;
																		}
																		if (nTrinket == "t_mal15")
																		{
																			if (161519 - 353952 == -192432)
																			{
																				continue;
																			}
																		}
																		else if (nTrinket == "t_mal37")
																		{
																			if (241639 - 512929 == -271289)
																			{
																				continue;
																			}
																			this.aDQs6X2d4I.transform.parent = global::Math.findChildObject(this.gameObject.transform, "UpperBody1");
																			if (41302 - 286678 != -245376)
																			{
																				continue;
																			}
																			this.aDQs6X2d4I.transform.localPosition = Vector3.zero;
																			if (94871 - 316832 == -221960)
																			{
																				continue;
																			}
																			this.aDQs6X2d4I.transform.localRotation = Quaternion.Euler((float)270, (float)90, (float)0);
																			if (224087 - 168061 == 56027)
																			{
																				continue;
																			}
																			this.aDQs6X2d4I.transform.localScale = Vector3.one;
																			if (195761 - 518977 != -323216)
																			{
																				continue;
																			}
																			goto IL_AE2;
																		}
																		else
																		{
																			if (!(nTrinket == "t_mol60"))
																			{
																				if (216918 - 285963 == -69044)
																				{
																					continue;
																				}
																				if (nTrinket == "t_mol62")
																				{
																					if (236014 - 385935 != -149921)
																					{
																						continue;
																					}
																				}
																				else if (nTrinket == "t_all46")
																				{
																					if (268518 - 25550 != 242968)
																					{
																						continue;
																					}
																					this.aDQs6X2d4I.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Hand_L");
																					if (262518 - 38920 == 223599)
																					{
																						continue;
																					}
																					this.aDQs6X2d4I.transform.localPosition = Vector3.zero;
																					if (138305 - 318898 == -180592)
																					{
																						continue;
																					}
																					this.aDQs6X2d4I.transform.localRotation = Quaternion.identity;
																					if (65071 - 252205 == -187133)
																					{
																						continue;
																					}
																					this.aDQs6X2d4I.transform.localScale = 0.8f * Vector3.one;
																					if (16699 - 2325 != 14375)
																					{
																						goto IL_AE2;
																					}
																					continue;
																				}
																				else
																				{
																					if (!(nTrinket == "t_all91"))
																					{
																						if (213025 - 436798 != -223773)
																						{
																							continue;
																						}
																						if (!(nTrinket == "t_all92"))
																						{
																							if (142356 - 330653 == -188296)
																							{
																								continue;
																							}
																							if (!(nTrinket == "t_all93"))
																							{
																								if (40823 - 327426 != -286603)
																								{
																									continue;
																								}
																								if (!(nTrinket == "t_all94"))
																								{
																									if (212330 - 134914 != 77416)
																									{
																										continue;
																									}
																									if (!(nTrinket == "t_all95"))
																									{
																										if (168666 - 434515 == -265848)
																										{
																											continue;
																										}
																										if (nTrinket == "t_all96")
																										{
																											if (110009 - 444183 == -334173)
																											{
																												continue;
																											}
																										}
																										else
																										{
																											this.aDQs6X2d4I.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
																											if (134534 - 97222 == 37313)
																											{
																												continue;
																											}
																											this.aDQs6X2d4I.transform.localPosition = Vector3.zero;
																											if (106584 - 159810 == -53225)
																											{
																												continue;
																											}
																											this.aDQs6X2d4I.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
																											if (190151 - 237475 != -47324)
																											{
																												continue;
																											}
																											this.aDQs6X2d4I.transform.localScale = Vector3.one;
																											if (204455 - 47343 != 157113)
																											{
																												goto IL_AE2;
																											}
																											continue;
																										}
																									}
																								}
																							}
																						}
																					}
																					this.aDQs6X2d4I.transform.parent = this.gameObject.transform;
																					if (13971 - 393904 == -379932)
																					{
																						continue;
																					}
																					this.aDQs6X2d4I.transform.localPosition = Vector3.zero;
																					if (281451 - 365117 == -83665)
																					{
																						continue;
																					}
																					this.aDQs6X2d4I.transform.localRotation = Quaternion.identity;
																					if (16584 - 375003 != -358419)
																					{
																						continue;
																					}
																					this.aDQs6X2d4I.transform.localScale = Vector3.one;
																					if (196873 - 371170 != -174296)
																					{
																						goto IL_AE2;
																					}
																					continue;
																				}
																			}
																			this.aDQs6X2d4I.transform.parent = this.gameObject.transform;
																			if (224232 - 165010 != 59222)
																			{
																				continue;
																			}
																			this.aDQs6X2d4I.transform.localPosition = Vector3.zero;
																			if (105047 - 84966 != 20081)
																			{
																				continue;
																			}
																			this.aDQs6X2d4I.transform.localRotation = Quaternion.Euler((float)0, (float)180, (float)0);
																			if (260831 - 391538 == -130706)
																			{
																				continue;
																			}
																			this.aDQs6X2d4I.transform.localScale = Vector3.one;
																			if (11265 - 176495 != -165230)
																			{
																				continue;
																			}
																			goto IL_AE2;
																		}
																	}
																}
															}
														}
													}
													this.aDQs6X2d4I.transform.parent = global::Math.findChildObject(this.gameObject.transform, "UpperBody2");
													if (260821 - 573311 != -312490)
													{
														continue;
													}
													this.aDQs6X2d4I.transform.localPosition = Vector3.zero;
													if (253176 - 330085 == -76908)
													{
														continue;
													}
													this.aDQs6X2d4I.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
													if (191443 - 75134 != 116309)
													{
														continue;
													}
													this.aDQs6X2d4I.transform.localScale = Vector3.one;
													if (11149 - 165614 != -154464)
													{
														goto IL_AE2;
													}
													continue;
												}
											}
										}
									}
								}
							}
						}
						this.aDQs6X2d4I.transform.parent = global::Math.findChildObject(this.gameObject.transform, "UpperBody1");
						if (197970 - 324645 != -126675)
						{
							continue;
						}
						this.aDQs6X2d4I.transform.localPosition = Vector3.zero;
						if (53067 - 592179 == -539111)
						{
							continue;
						}
						this.aDQs6X2d4I.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
						if (194121 - 484679 == -290557)
						{
							continue;
						}
						this.aDQs6X2d4I.transform.localScale = Vector3.one;
						if (208711 - 86686 == 122026)
						{
							continue;
						}
					}
					IL_AE2:
					if (!this.kYhscFpX7o)
					{
						break;
					}
					if (188941 - 413532 == -224591)
					{
						this.kYhscFpX7o.trinket = nTrinket;
						if (26006 - 227168 != -201161)
						{
							this.kYhscFpX7o.mTrn = this.aDQs6X2d4I;
							if (48065 - 425574 != -377508)
							{
								if (this.kYhscFpX7o.getStatus("blend") != null)
								{
									if (153758 - 324022 != -170264)
									{
										continue;
									}
									this.kYhscFpX7o.removeStatus("blend");
									if (238876 - 560370 != -321494)
									{
										continue;
									}
								}
								if (this.kYhscFpX7o.getStatus("invisible") == null)
								{
									break;
								}
								if (129070 - 74312 == 54758)
								{
									this.kYhscFpX7o.removeStatus("invisible");
									if (102842 - 89122 != 13721)
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

	// Token: 0x06002734 RID: 10036 RVA: 0x004AEF4C File Offset: 0x004AD14C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipPet(string nPet)
	{
		if (178343 - 390690 != -212347)
		{
		}
		for (;;)
		{
			if (Game.mGameType < 2)
			{
				if (214487 - 195742 != 18746)
				{
					break;
				}
			}
			else
			{
				this.pet = nPet;
				if (85434 - 458555 != -373120)
				{
					if (this.tZAst5Stno)
					{
						if (182260 - 544238 != -361978)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.tZAst5Stno);
						if (7590 - 389478 == -381887)
						{
							continue;
						}
					}
					GameObject gameObject = null;
					if (76032 - 351879 == -275847)
					{
						int num = 1;
						if (149595 - 120064 != 29532)
						{
							if (253035 - 350980 == -97945)
							{
								if (nPet == "p_all1")
								{
									if (276877 - 210937 == 65941)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/bigbugBalloon", typeof(GameObject));
									if (36642 - 504340 != -467698)
									{
										continue;
									}
								}
								else if (nPet == "p_all2")
								{
									if (232055 - 598203 == -366147)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/bluebugBalloon", typeof(GameObject));
									if (90387 - 383129 == -292741)
									{
										continue;
									}
								}
								else if (nPet == "p_all3")
								{
									if (75306 - 15569 != 59737)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/momBalloon", typeof(GameObject));
									if (238702 - 369117 == -130414)
									{
										continue;
									}
								}
								else if (nPet == "p_all4")
								{
									if (29783 - 206507 != -176724)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/dadBalloon", typeof(GameObject));
									if (210610 - 585117 == -374506)
									{
										continue;
									}
								}
								else if (nPet == "p_all11")
								{
									if (174273 - 530251 == -355977)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallSmashBall", typeof(GameObject));
									if (200465 - 323522 == -123056)
									{
										continue;
									}
								}
								else if (nPet == "p_all12")
								{
									if (90358 - 234731 != -144373)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/soccerBall", typeof(GameObject));
									if (141089 - 557710 != -416621)
									{
										continue;
									}
								}
								else if (nPet == "p_all21")
								{
									if (55692 - 286321 != -230629)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteChula", typeof(GameObject));
									if (8760 - 64332 == -55571)
									{
										continue;
									}
								}
								else if (nPet == "p_all22")
								{
									if (67552 - 565763 == -498210)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kitePukpao", typeof(GameObject));
									if (281819 - 526348 == -244528)
									{
										continue;
									}
								}
								else if (nPet == "p_all23")
								{
									if (40413 - 115958 == -75544)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteButterfly", typeof(GameObject));
									if (248917 - 44130 == 204788)
									{
										continue;
									}
								}
								else if (nPet == "p_all24")
								{
									if (173007 - 2080 != 170927)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteSnake", typeof(GameObject));
									if (42684 - 391647 != -348963)
									{
										continue;
									}
								}
								else if (Extensions.get_length(nPet) == 6)
								{
									if (234118 - 314552 != -80434)
									{
										continue;
									}
									string a = nPet.Substring(0, 5);
									if (91662 - 468924 != -377262)
									{
										continue;
									}
									if (a == "p_lcr")
									{
										if (246305 - 218001 != 28304)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron", typeof(GameObject));
										if (110373 - 595733 == -485359)
										{
											continue;
										}
									}
									else if (a == "p_lcp")
									{
										if (25649 - 130599 != -104950)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron_p", typeof(GameObject));
										if (150339 - 331377 != -181038)
										{
											continue;
										}
									}
									else if (a == "p_lmp")
									{
										if (142433 - 395233 == -252799)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMupo", typeof(GameObject));
										if (109660 - 291321 == -181660)
										{
											continue;
										}
									}
									else if (a == "p_lpp")
									{
										if (188243 - 229567 != -41324)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePeppon", typeof(GameObject));
										if (257911 - 260112 == -2200)
										{
											continue;
										}
									}
									else if (a == "p_lct")
									{
										if (64096 - 166405 != -102309)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCacton", typeof(GameObject));
										if (133988 - 501058 != -367070)
										{
											continue;
										}
									}
									else if (a == "p_lcc")
									{
										if (50152 - 546569 == -496416)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCocon", typeof(GameObject));
										if (285739 - 434161 == -148421)
										{
											continue;
										}
									}
									else if (a == "p_lpk")
									{
										if (36386 - 175650 != -139264)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePumpkon", typeof(GameObject));
										if (105804 - 83446 == 22359)
										{
											continue;
										}
									}
									else if (a == "p_lml")
									{
										if (241234 - 517327 != -276093)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMellon", typeof(GameObject));
										if (210135 - 399664 == -189528)
										{
											continue;
										}
									}
									else if (a == "p_lbd")
									{
										if (170468 - 390488 != -220020)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleBDMellon", typeof(GameObject));
										if (48133 - 10381 == 37753)
										{
											continue;
										}
									}
									else if (a == "p_lcs")
									{
										if (247731 - 231471 == 16261)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron_s", typeof(GameObject));
										if (95629 - 404408 == -308778)
										{
											continue;
										}
									}
									else if (a == "p_lms")
									{
										if (111753 - 512056 != -400303)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMupo_s", typeof(GameObject));
										if (101028 - 560727 == -459698)
										{
											continue;
										}
									}
									else if (a == "p_lps")
									{
										if (226197 - 134932 != 91265)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePeppon_s", typeof(GameObject));
										if (119938 - 325926 == -205987)
										{
											continue;
										}
									}
									else if (a == "p_lck")
									{
										if (28025 - 426570 == -398544)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarronCake", typeof(GameObject));
										if (96510 - 55489 == 41022)
										{
											continue;
										}
									}
									else if (a == "p_lpd")
									{
										if (229343 - 168151 != 61192)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePepponDisco", typeof(GameObject));
										if (114410 - 12352 == 102059)
										{
											continue;
										}
									}
									else if (a == "p_lmc")
									{
										if (154285 - 543858 != -389573)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadCarron", typeof(GameObject));
										if (255668 - 58441 != 197227)
										{
											continue;
										}
									}
									else if (a == "p_lmn")
									{
										if (263841 - 240104 != 23737)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadPeppon", typeof(GameObject));
										if (25612 - 517384 == -491771)
										{
											continue;
										}
									}
									else if (a == "p_lmo")
									{
										if (75420 - 332683 == -257262)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadCocon", typeof(GameObject));
										if (112044 - 453437 == -341392)
										{
											continue;
										}
									}
									else if (a == "p_ldc")
									{
										if (207214 - 24462 != 182752)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCarron", typeof(GameObject));
										if (179032 - 442641 == -263608)
										{
											continue;
										}
									}
									else if (a == "p_ldm")
									{
										if (183938 - 122783 != 61155)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadMupo", typeof(GameObject));
										if (69257 - 19590 == 49668)
										{
											continue;
										}
									}
									else if (a == "p_ldp")
									{
										if (208428 - 151854 == 56575)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadPeppon", typeof(GameObject));
										if (265806 - 328242 != -62436)
										{
											continue;
										}
									}
									else if (a == "p_ldt")
									{
										if (134924 - 5353 != 129571)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCacton", typeof(GameObject));
										if (183590 - 585071 != -401481)
										{
											continue;
										}
									}
									else if (a == "p_ldn")
									{
										if (115398 - 416471 != -301073)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCocon", typeof(GameObject));
										if (220469 - 52219 == 168251)
										{
											continue;
										}
									}
									else if (a == "p_ldk")
									{
										if (6749 - 401459 == -394709)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadPumpkon", typeof(GameObject));
										if (42869 - 118289 != -75420)
										{
											continue;
										}
									}
									else if (a == "p_srp")
									{
										if (150338 - 7221 != 143117)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallRedPanda", typeof(GameObject));
										if (53550 - 533809 != -480259)
										{
											continue;
										}
									}
									else if (a == "p_sss")
									{
										if (133828 - 482811 == -348982)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallSantaSkunk", typeof(GameObject));
										if (216372 - 190615 == 25758)
										{
											continue;
										}
									}
									else if (a == "p_sbb")
									{
										if (80034 - 539499 == -459464)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallBarrelBot", typeof(GameObject));
										if (211614 - 410041 == -198426)
										{
											continue;
										}
									}
									else if (a == "p_sdm")
									{
										if (44965 - 32659 == 12307)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallDemion", typeof(GameObject));
										if (27754 - 467031 == -439276)
										{
											continue;
										}
									}
									else if (a == "p_sdv")
									{
										if (100890 - 135670 != -34780)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallDoov", typeof(GameObject));
										if (111258 - 426863 != -315605)
										{
											continue;
										}
									}
									else if (a == "p_skz")
									{
										if (217906 - 229646 != -11740)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallKarazo", typeof(GameObject));
										if (199037 - 307594 != -108557)
										{
											continue;
										}
									}
									else if (a == "p_skm")
									{
										if (73777 - 197430 == -123652)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallKumo", typeof(GameObject));
										if (292584 - 225445 == 67140)
										{
											continue;
										}
									}
									else if (a == "p_skr")
									{
										if (46437 - 303346 != -256909)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_r", typeof(GameObject));
										if (147345 - 208507 == -61161)
										{
											continue;
										}
									}
									else if (a == "p_skg")
									{
										if (285792 - 261773 != 24019)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_g", typeof(GameObject));
										if (50887 - 515580 != -464693)
										{
											continue;
										}
									}
									else if (a == "p_sky")
									{
										if (83229 - 22325 == 60905)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_y", typeof(GameObject));
										if (19022 - 290322 == -271299)
										{
											continue;
										}
									}
									else if (a == "p_skb")
									{
										if (130345 - 387849 == -257503)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_b", typeof(GameObject));
										if (31548 - 393039 == -361490)
										{
											continue;
										}
									}
									else if (a == "p_skk")
									{
										if (38271 - 237205 != -198934)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_k", typeof(GameObject));
										if (174173 - 566584 == -392410)
										{
											continue;
										}
									}
									else if (a == "p_sfb")
									{
										if (104068 - 471847 == -367778)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallFlowerBug", typeof(GameObject));
										if (260698 - 580416 != -319718)
										{
											continue;
										}
									}
									else if (a == "p_sob")
									{
										if (278129 - 304012 != -25883)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallLionBug", typeof(GameObject));
										if (236485 - 356153 == -119667)
										{
											continue;
										}
									}
									else if (a == "p_sgb")
									{
										if (220688 - 46057 != 174631)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallGiantBug", typeof(GameObject));
										if (96795 - 299644 == -202848)
										{
											continue;
										}
									}
									else if (a == "p_slb")
									{
										if (232463 - 223658 == 8806)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallLeafBug", typeof(GameObject));
										if (113101 - 196116 != -83015)
										{
											continue;
										}
									}
									else if (a == "p_stb")
									{
										if (45821 - 219573 == -173751)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallFatBug", typeof(GameObject));
										if (154346 - 249381 == -95034)
										{
											continue;
										}
									}
									else if (a == "p_spb")
									{
										if (170814 - 449003 == -278188)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallPaperBug", typeof(GameObject));
										if (251266 - 191058 != 60208)
										{
											continue;
										}
									}
									else if (a == "p_swb")
									{
										if (22592 - 351063 == -328470)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallWormBug", typeof(GameObject));
										if (74688 - 53136 != 21552)
										{
											continue;
										}
									}
									else if (a == "p_ssq")
									{
										if (48182 - 470792 != -422610)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallStingQueen", typeof(GameObject));
										if (250547 - 37974 != 212573)
										{
											continue;
										}
									}
									else if (a == "p_snb")
									{
										if (164780 - 146498 == 18283)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNeonBug", typeof(GameObject));
										if (120416 - 28408 != 92008)
										{
											continue;
										}
									}
									else if (a == "p_sim")
									{
										if (118233 - 20621 == 97613)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallIceMixer", typeof(GameObject));
										if (121074 - 89833 != 31241)
										{
											continue;
										}
									}
									else if (a == "p_sam")
									{
										if (195228 - 171879 == 23350)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallAmmonite", typeof(GameObject));
										if (145764 - 61612 != 84152)
										{
											continue;
										}
									}
									else if (a == "p_sab")
									{
										if (290580 - 373208 != -82628)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallAnubi", typeof(GameObject));
										if (111681 - 56414 != 55267)
										{
											continue;
										}
									}
									else if (a == "p_spg")
									{
										if (267743 - 494631 == -226887)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallIcePenguin", typeof(GameObject));
										if (158500 - 410577 == -252076)
										{
											continue;
										}
									}
									else if (a == "p_spf")
									{
										if (130477 - 526328 == -395850)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallPirateFish", typeof(GameObject));
										if (226260 - 50493 == 175768)
										{
											continue;
										}
									}
									else if (a == "p_msb")
									{
										if (31919 - 150865 == -118945)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniSkyBug", typeof(GameObject));
										if (83328 - 436265 == -352936)
										{
											continue;
										}
									}
									else if (a == "p_mcb")
									{
										if (16499 - 346412 == -329912)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniCrystalBug", typeof(GameObject));
										if (117819 - 471101 == -353281)
										{
											continue;
										}
									}
									else if (a == "p_mab")
									{
										if (17082 - 139661 == -122578)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniAncientBug", typeof(GameObject));
										if (116985 - 566606 != -449621)
										{
											continue;
										}
									}
									else if (a == "p_mrb")
									{
										if (182839 - 225667 == -42827)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniReefBug", typeof(GameObject));
										if (111050 - 553337 != -442287)
										{
											continue;
										}
									}
									else if (a == "p_mmb")
									{
										if (32948 - 207101 != -174153)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniMokBug", typeof(GameObject));
										if (156774 - 277208 == -120433)
										{
											continue;
										}
									}
									else if (a == "p_mgb")
									{
										if (49966 - 340107 != -290141)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniGoldenBug", typeof(GameObject));
										if (255707 - 550465 != -294758)
										{
											continue;
										}
									}
									else if (a == "p_mnb")
									{
										if (12421 - 264068 != -251647)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniNemesisBug", typeof(GameObject));
										if (193216 - 236449 == -43232)
										{
											continue;
										}
									}
									num = Stringf.getLastDigit(nPet);
									if (9932 - 402922 == -392989)
									{
										continue;
									}
									if (num < 0)
									{
										if (214381 - 271460 != -57079)
										{
											continue;
										}
										num = 1;
										if (26484 - 82584 != -56100)
										{
											continue;
										}
									}
								}
								if (gameObject)
								{
									if (34580 - 467888 != -433308)
									{
										continue;
									}
									this.tZAst5Stno = (GameObject)UnityEngine.Object.Instantiate(gameObject, this.transform.position - this.transform.forward, this.transform.rotation);
									if (16852 - 8792 == 8061)
									{
										continue;
									}
									if (this.tZAst5Stno)
									{
										if (243436 - 479408 != -235972)
										{
											continue;
										}
										this.tZAst5Stno.transform.localScale = ((float)num * 0.1f + 0.9f) * Vector3.one;
										if (248342 - 451104 != -202762)
										{
											continue;
										}
										PetControl petControl = (PetControl)this.tZAst5Stno.GetComponent(typeof(PetControl));
										if (72598 - 426252 == -353653)
										{
											continue;
										}
										if (petControl)
										{
											if (147629 - 513750 != -366121)
											{
												continue;
											}
											petControl.Init(this.gameObject, num);
											if (19139 - 442679 != -423540)
											{
												continue;
											}
										}
										if (this.kYhscFpX7o)
										{
											if (122170 - 488680 != -366510)
											{
												continue;
											}
											this.kYhscFpX7o.mPet = this.tZAst5Stno;
											if (254414 - 419243 == -164828)
											{
												continue;
											}
										}
									}
								}
								if (!this.kYhscFpX7o)
								{
									break;
								}
								if (104492 - 182439 != -77946)
								{
									this.kYhscFpX7o.pet = nPet;
									if (189090 - 407066 == -217976)
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

	// Token: 0x06002735 RID: 10037 RVA: 0x004B0CB0 File Offset: 0x004AEEB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002736 RID: 10038 RVA: 0x004B0CB4 File Offset: 0x004AEEB4
	internal static bool OjOfDXhL1D5242IUf6l()
	{
		return true;
	}

	// Token: 0x06002737 RID: 10039 RVA: 0x004B0CB8 File Offset: 0x004AEEB8
	internal static bool Vcb8l7hOq80ybIJTqEX()
	{
		return false;
	}

	// Token: 0x04002BCF RID: 11215
	private CharacterControl kYhscFpX7o;

	// Token: 0x04002BD0 RID: 11216
	public string weapon;

	// Token: 0x04002BD1 RID: 11217
	public string armor;

	// Token: 0x04002BD2 RID: 11218
	public string accessory;

	// Token: 0x04002BD3 RID: 11219
	public string boot;

	// Token: 0x04002BD4 RID: 11220
	public string trinket;

	// Token: 0x04002BD5 RID: 11221
	public string pet;

	// Token: 0x04002BD6 RID: 11222
	public int skin;

	// Token: 0x04002BD7 RID: 11223
	public bool equipOnStart;

	// Token: 0x04002BD8 RID: 11224
	private GameObject EZJsnX97Ay;

	// Token: 0x04002BD9 RID: 11225
	private GameObject v0bsQtlkH7;

	// Token: 0x04002BDA RID: 11226
	private GameObject alBseBK8PS;

	// Token: 0x04002BDB RID: 11227
	private GameObject Y6WsIO179o;

	// Token: 0x04002BDC RID: 11228
	private GameObject nmxsJtjDqp;

	// Token: 0x04002BDD RID: 11229
	private GameObject aDQs6X2d4I;

	// Token: 0x04002BDE RID: 11230
	private GameObject tZAst5Stno;
}
