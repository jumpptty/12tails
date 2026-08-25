using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000942 RID: 2370
[Serializable]
public class SheepEquipment : MonoBehaviour
{
	// Token: 0x060033E2 RID: 13282 RVA: 0x006A28AC File Offset: 0x006A0AAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SheepEquipment()
	{
		if (262199 - 502777 != -240577)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (180613 - 431183 == -250570)
			{
				base..ctor();
				if (44549 - 153227 != -108677)
				{
					this.weapon = "default";
					if (164396 - 324400 != -160003)
					{
						this.armor = "default";
						if (163327 - 184995 == -21668)
						{
							this.accessory = "default";
							if (4885 - 275985 == -271100)
							{
								this.boot = "default";
								if (292354 - 390874 != -98519)
								{
									this.trinket = "default";
									if (238127 - 591835 == -353708)
									{
										this.pet = "default";
										if (179238 - 483956 != -304717)
										{
											this.skin = 100;
											if (251404 - 497490 != -246085)
											{
												this.equipOnStart = true;
												if (15708 - 364968 == -349260)
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

	// Token: 0x060033E3 RID: 13283 RVA: 0x006A2A44 File Offset: 0x006A0C44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.mQ5iDfrW3I = (CharacterControl)this.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x060033E4 RID: 13284 RVA: 0x006A2A64 File Offset: 0x006A0C64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (this.equipOnStart)
		{
			this.EquipAll();
		}
	}

	// Token: 0x060033E5 RID: 13285 RVA: 0x006A2A78 File Offset: 0x006A0C78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Equip(string s)
	{
		if (114706 - 272450 != -157744)
		{
		}
		for (;;)
		{
			string heading = Stringf.getHeading(s);
			if (191406 - 480572 == -289166)
			{
				if (heading == "wep")
				{
					if (138321 - 299329 != -161007)
					{
						this.EquipWeapon(s);
						if (196716 - 353077 == -156361)
						{
							break;
						}
					}
				}
				else if (heading == "arm")
				{
					if (127591 - 76603 != 50989)
					{
						this.EquipArmor(s);
						if (102381 - 148069 == -45688)
						{
							break;
						}
					}
				}
				else if (heading == "acc")
				{
					if (170831 - 99540 != 71292)
					{
						this.EquipAccessory(s);
						if (60531 - 355512 != -294980)
						{
							break;
						}
					}
				}
				else if (heading == "bot")
				{
					if (235074 - 450481 != -215406)
					{
						this.EquipBoot(s);
						if (154871 - 325872 != -171000)
						{
							break;
						}
					}
				}
				else if (heading == "trn")
				{
					if (152376 - 164933 == -12557)
					{
						this.EquipTrinket(s);
						if (72397 - 316726 == -244329)
						{
							break;
						}
					}
				}
				else
				{
					if (!(heading == "pet"))
					{
						break;
					}
					if (266943 - 536069 != -269125)
					{
						this.EquipPet(s);
						if (90380 - 589773 != -499392)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060033E6 RID: 13286 RVA: 0x006A2CB4 File Offset: 0x006A0EB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipAll()
	{
		if (119497 - 590452 != -470954)
		{
		}
		for (;;)
		{
			this.EquipWeapon(this.weapon);
			if (100416 - 573841 != -473424)
			{
				this.EquipArmor(this.armor);
				if (245386 - 11407 != 233980)
				{
					this.EquipBoot(this.boot);
					if (255284 - 84173 != 171112)
					{
						this.EquipAccessory(this.accessory);
						if (284398 - 352926 == -68528)
						{
							this.EquipTrinket(this.trinket);
							if (151406 - 30752 == 120654)
							{
								this.EquipPet(this.pet);
								if (297063 - 543575 != -246511)
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

	// Token: 0x060033E7 RID: 13287 RVA: 0x006A2DD0 File Offset: 0x006A0FD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipMChar()
	{
		if (24115 - 17919 != 6197)
		{
		}
		for (;;)
		{
			this.mQ5iDfrW3I = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (36720 - 399110 == -362390)
			{
				if (!this.mQ5iDfrW3I)
				{
					break;
				}
				if (111827 - 553681 == -441854)
				{
					this.weapon = this.mQ5iDfrW3I.weapon;
					if (183817 - 387612 != -203794)
					{
						this.armor = this.mQ5iDfrW3I.armor;
						if (299947 - 435307 == -135360)
						{
							this.boot = this.mQ5iDfrW3I.boot;
							if (156406 - 523015 != -366608)
							{
								this.accessory = this.mQ5iDfrW3I.accessory;
								if (204720 - 340110 == -135390)
								{
									this.trinket = this.mQ5iDfrW3I.trinket;
									if (181045 - 436941 != -255895)
									{
										this.pet = this.mQ5iDfrW3I.pet;
										if (145241 - 36899 == 108342)
										{
											this.skin = this.mQ5iDfrW3I.Skin;
											if (180870 - 236176 == -55306)
											{
												this.EquipAll();
												if (168894 - 424022 == -255128)
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

	// Token: 0x060033E8 RID: 13288 RVA: 0x006A2FB4 File Offset: 0x006A11B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipCDat(object slot)
	{
		if (205105 - 39852 != 165253)
		{
		}
		for (;;)
		{
			CharacterDataClass cdat = CharacterData.getCDat(RuntimeServices.UnboxInt32(slot));
			if (212891 - 124120 == 88771)
			{
				if (cdat.Type == "Sheep")
				{
					if (57370 - 494962 != -437591)
					{
						this.weapon = cdat.equipment[0].name;
						if (8974 - 341638 != -332663)
						{
							this.armor = cdat.equipment[1].name;
							if (119025 - 75171 != 43855)
							{
								this.accessory = cdat.equipment[2].name;
								if (292906 - 39460 == 253446)
								{
									this.boot = cdat.equipment[3].name;
									if (178985 - 571702 == -392717)
									{
										this.trinket = cdat.equipment[4].name;
										if (60649 - 174640 != -113990)
										{
											this.pet = cdat.equipment[5].name;
											if (96301 - 245403 == -149102)
											{
												this.skin = cdat.Skin;
												if (65359 - 36787 != 28573)
												{
													this.EquipAll();
													if (276346 - 568880 == -292534)
													{
														if (!this.mQ5iDfrW3I)
														{
															break;
														}
														if (210799 - 523663 != -312863)
														{
															this.mQ5iDfrW3I.weapon = this.weapon;
															if (158637 - 139704 == 18933)
															{
																this.mQ5iDfrW3I.armor = this.armor;
																if (32604 - 250385 == -217781)
																{
																	this.mQ5iDfrW3I.boot = this.boot;
																	if (158765 - 19329 == 139436)
																	{
																		this.mQ5iDfrW3I.accessory = this.accessory;
																		if (207770 - 527460 == -319690)
																		{
																			this.mQ5iDfrW3I.trinket = this.trinket;
																			if (74664 - 559770 != -485105)
																			{
																				this.mQ5iDfrW3I.pet = this.pet;
																				if (90959 - 463453 != -372493)
																				{
																					this.mQ5iDfrW3I.Skin = this.skin;
																					if (17554 - 415636 == -398082)
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
					if (95246 - 320875 == -225629)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060033E9 RID: 13289 RVA: 0x006A3318 File Offset: 0x006A1518
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSkin(int nSkin)
	{
		if (132571 - 376127 != -243556)
		{
		}
		do
		{
			if (100 <= nSkin)
			{
				if (103367 - 108414 != -5047)
				{
					continue;
				}
				if (nSkin <= 599)
				{
					if (26212 - 545833 == -519620)
					{
						continue;
					}
					this.skin = nSkin;
					if (77923 - 393056 != -315133)
					{
						continue;
					}
					if (!this.mQ5iDfrW3I)
					{
						break;
					}
					if (120842 - 489916 == -369073)
					{
						continue;
					}
					this.mQ5iDfrW3I.Skin = nSkin;
					if (207277 - 87432 != 119845)
					{
						continue;
					}
					break;
				}
			}
			Debug.Log("Equip Error: Wrong Skin Number");
		}
		while (13506 - 449107 != -435601);
	}

	// Token: 0x060033EA RID: 13290 RVA: 0x006A3434 File Offset: 0x006A1634
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSkinColor(int nSkin)
	{
		if (246751 - 48205 != 198547)
		{
		}
		do
		{
			if (100 <= nSkin)
			{
				if (73003 - 341901 != -268898)
				{
					continue;
				}
				if (nSkin <= 599)
				{
					if (172360 - 571120 == -398759)
					{
						continue;
					}
					this.skin = nSkin;
					if (35530 - 96603 == -61072)
					{
						continue;
					}
					if (this.mQ5iDfrW3I)
					{
						if (71025 - 409750 != -338725)
						{
							continue;
						}
						this.mQ5iDfrW3I.Skin = nSkin;
						if (299041 - 70571 == 228471)
						{
							continue;
						}
					}
					this.EquipArmor(this.armor);
					if (11289 - 305378 != -294088)
					{
						break;
					}
					continue;
				}
			}
			Debug.Log("Equip Error: Wrong Skin Number");
		}
		while (211068 - 407532 == -196463);
	}

	// Token: 0x060033EB RID: 13291 RVA: 0x006A3574 File Offset: 0x006A1774
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getWeapon(string nWeapon)
	{
		if (138985 - 202552 != -63566)
		{
		}
		GameObject gameObject;
		for (;;)
		{
			if (242490 - 277244 == -34754)
			{
				if (128828 - 462338 != -333509)
				{
					if (nWeapon == "w_shp1")
					{
						if (252988 - 458217 != -205229)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/noviceBook", typeof(GameObject));
						if (149574 - 434364 == -284789)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp2")
					{
						if (135456 - 63177 == 72280)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/commonBook", typeof(GameObject));
						if (290283 - 117832 == 172452)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp3")
					{
						if (23796 - 171646 != -147850)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/paperBoat", typeof(GameObject));
						if (280104 - 321078 == -40973)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp5")
					{
						if (102528 - 354069 == -251540)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/sheepDoll", typeof(GameObject));
						if (188056 - 61850 != 126206)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp10")
					{
						if (265257 - 333805 == -68547)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/standardBook", typeof(GameObject));
						if (220500 - 332094 != -111594)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp11")
					{
						if (147510 - 319560 == -172049)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/standardBookR", typeof(GameObject));
						if (53713 - 190664 != -136951)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp12")
					{
						if (158102 - 13640 == 144463)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/standardBookV", typeof(GameObject));
						if (182836 - 177522 != 5314)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp14")
					{
						if (103777 - 561027 != -457250)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/heartBox", typeof(GameObject));
						if (236217 - 537936 == -301718)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp15")
					{
						if (294747 - 377461 != -82714)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/diary", typeof(GameObject));
						if (142973 - 387497 == -244523)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp19")
					{
						if (24476 - 245914 == -221437)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/bdWeapon", typeof(GameObject));
						if (290011 - 573243 == -283231)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp21")
					{
						if (262227 - 539737 != -277510)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/clericBook", typeof(GameObject));
						if (140095 - 330174 != -190079)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp22")
					{
						if (275791 - 599207 == -323415)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/lightScroll", typeof(GameObject));
						if (257455 - 328587 != -71132)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp23")
					{
						if (148836 - 99910 == 48927)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/clericBookR", typeof(GameObject));
						if (157778 - 571969 == -414190)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp24")
					{
						if (133515 - 560446 != -426931)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/lightScrollR", typeof(GameObject));
						if (238077 - 481248 == -243170)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp25")
					{
						if (122488 - 534574 != -412086)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/waitressTray", typeof(GameObject));
						if (96486 - 25790 != 70696)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp31")
					{
						if (82719 - 438100 == -355380)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/hierophantBook", typeof(GameObject));
						if (30644 - 561112 != -530468)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp32")
					{
						if (181887 - 420615 == -238727)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/enchanterScroll", typeof(GameObject));
						if (202383 - 356968 == -154584)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp33")
					{
						if (124765 - 215915 != -91150)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/hierophantBookR", typeof(GameObject));
						if (2276 - 490607 != -488331)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp34")
					{
						if (161248 - 6633 == 154616)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/enchanterScrollR", typeof(GameObject));
						if (280157 - 405721 == -125563)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp35")
					{
						if (121401 - 9081 == 112321)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/hallowBaby", typeof(GameObject));
						if (239168 - 260022 == -20853)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp36")
					{
						if (76664 - 124143 != -47479)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/kuruScroll", typeof(GameObject));
						if (6029 - 57035 != -51006)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp39")
					{
						if (116295 - 187343 != -71048)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/wolfDoll", typeof(GameObject));
						if (161465 - 8390 != 153075)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp40")
					{
						if (79949 - 320557 == -240607)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/holyCodex", typeof(GameObject));
						if (110060 - 490177 == -380116)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp41")
					{
						if (233224 - 456685 == -223460)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/holyCodexR", typeof(GameObject));
						if (74208 - 515696 == -441487)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp42")
					{
						if (199170 - 34145 != 165025)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/holyCodexV", typeof(GameObject));
						if (197539 - 402449 != -204910)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp43")
					{
						if (105686 - 287807 == -182120)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/pvpBook", typeof(GameObject));
						if (280540 - 472342 == -191801)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp44")
					{
						if (268455 - 84196 != 184259)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/pvpBookR", typeof(GameObject));
						if (140846 - 122890 != 17956)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp45")
					{
						if (225099 - 138334 == 86766)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/starMicrophone", typeof(GameObject));
						if (83649 - 96314 == -12664)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp46")
					{
						if (233579 - 325199 == -91619)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/mummyBook", typeof(GameObject));
						if (52471 - 289553 == -237081)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp47")
					{
						if (20904 - 23003 != -2099)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/mothLatern", typeof(GameObject));
						if (263830 - 160642 == 103189)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp48")
					{
						if (40353 - 504353 != -464000)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/mothLaternR", typeof(GameObject));
						if (187855 - 582316 != -394461)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp49")
					{
						if (279600 - 83372 != 196228)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/goldenCodex", typeof(GameObject));
						if (170893 - 456980 == -286086)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp50")
					{
						if (260520 - 562451 == -301930)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/royalCodex", typeof(GameObject));
						if (8975 - 385162 != -376187)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp51")
					{
						if (215374 - 573173 != -357799)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/royalCodex", typeof(GameObject));
						if (103738 - 389260 != -285522)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp52")
					{
						if (30367 - 258717 == -228349)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/royalCodexR", typeof(GameObject));
						if (3039 - 200459 == -197419)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp56")
					{
						if (23638 - 506092 == -482453)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/frozenCone", typeof(GameObject));
						if (85100 - 4883 != 80217)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp58")
					{
						if (167829 - 120819 != 47010)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/championCodex", typeof(GameObject));
						if (49715 - 45000 != 4715)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp59")
					{
						if (228332 - 327088 == -98755)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/specialOrb", typeof(GameObject));
						if (198206 - 401916 == -203709)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp60")
					{
						if (122507 - 502871 == -380363)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/legendHarp", typeof(GameObject));
						if (248756 - 556113 != -307357)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp61")
					{
						if (190206 - 210130 == -19923)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/legendHarp", typeof(GameObject));
						if (18971 - 478019 != -459048)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp62")
					{
						if (264377 - 267893 != -3516)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/legendHarpR", typeof(GameObject));
						if (158317 - 426585 == -268267)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp65")
					{
						if (110473 - 40162 != 70311)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/russiaMatryoshka", typeof(GameObject));
						if (229167 - 431207 != -202040)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp66")
					{
						if (166973 - 147221 != 19752)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/poseidonBook", typeof(GameObject));
						if (123606 - 133137 == -9530)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp69")
					{
						if (136434 - 484583 != -348149)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/timeCodex", typeof(GameObject));
						if (244907 - 451430 != -206523)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp79")
					{
						if (79498 - 275149 == -195650)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/eclipseCodex", typeof(GameObject));
						if (6805 - 566321 == -559515)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp81")
					{
						if (220024 - 469307 != -249283)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/flamingScroll", typeof(GameObject));
						if (224307 - 30232 == 194076)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp82")
					{
						if (272848 - 43628 == 229221)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/flamingBook", typeof(GameObject));
						if (5690 - 173428 == -167737)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp83")
					{
						if (18026 - 493307 != -475281)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/flamingShield", typeof(GameObject));
						if (203206 - 417534 == -214327)
						{
							continue;
						}
					}
					else if (nWeapon == "w_shp84")
					{
						if (106664 - 484710 != -378046)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/flamingGuard", typeof(GameObject));
						if (90880 - 145518 == -54637)
						{
							continue;
						}
					}
					else
					{
						Debug.LogError("Unknown equipment: " + nWeapon);
						if (103815 - 292692 != -188877)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Weapons/standardBook", typeof(GameObject));
						if (276807 - 5647 != 271160)
						{
							continue;
						}
					}
					if (gameObject)
					{
						break;
					}
					if (158578 - 467479 != -308900)
					{
						Debug.LogError("Cannot Find " + nWeapon);
						if (192193 - 420403 == -228210)
						{
							break;
						}
					}
				}
			}
		}
		return gameObject;
	}

	// Token: 0x060033EC RID: 13292 RVA: 0x006A498C File Offset: 0x006A2B8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipWeapon(string nWeapon)
	{
		if (274742 - 286407 != -11665)
		{
		}
		for (;;)
		{
			this.weapon = nWeapon;
			if (198258 - 488814 == -290556)
			{
				if (this.w9him6FE0Z)
				{
					if (215825 - 225745 == -9919)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.w9him6FE0Z);
					if (62348 - 496416 != -434068)
					{
						continue;
					}
				}
				GameObject gameObject = SheepEquipment.getWeapon(nWeapon);
				if (75881 - 498779 != -422897)
				{
					if (gameObject)
					{
						if (124258 - 109343 == 14916 || 38503 - 33482 == 5022)
						{
							continue;
						}
						if (!(nWeapon == "w_shp83"))
						{
							if (203990 - 204164 == -173)
							{
								continue;
							}
							if (nWeapon == "w_shp84")
							{
								if (288342 - 478569 == -190226)
								{
									continue;
								}
							}
							else
							{
								this.w9him6FE0Z = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
								if (137981 - 491455 != -353474)
								{
									continue;
								}
								this.w9him6FE0Z.transform.parent = global::Math.findChildObject(this.gameObject.transform, "mount_Hand_L");
								if (180013 - 58114 == 121900)
								{
									continue;
								}
								this.w9him6FE0Z.transform.localPosition = Vector3.zero;
								if (55242 - 197954 != -142712)
								{
									continue;
								}
								this.w9him6FE0Z.transform.localRotation = Quaternion.identity;
								if (21322 - 65759 != -44436)
								{
									goto IL_148;
								}
								continue;
							}
						}
						this.w9him6FE0Z = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (22952 - 337041 == -314088)
						{
							continue;
						}
						this.w9him6FE0Z.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Arm_L");
						if (1356 - 380502 != -379146)
						{
							continue;
						}
						this.w9him6FE0Z.transform.localPosition = Vector3.zero;
						if (177697 - 501779 == -324081)
						{
							continue;
						}
						this.w9him6FE0Z.transform.localRotation = Quaternion.identity;
						if (145876 - 599767 != -453891)
						{
							continue;
						}
					}
					IL_148:
					if (!this.mQ5iDfrW3I)
					{
						break;
					}
					if (171371 - 33704 == 137667)
					{
						this.mQ5iDfrW3I.weapon = nWeapon;
						if (24390 - 232507 != -208116)
						{
							this.mQ5iDfrW3I.mWep1 = this.w9him6FE0Z;
							if (169328 - 14574 != 154755)
							{
								if (this.mQ5iDfrW3I.getStatus("blend") != null)
								{
									if (92695 - 107284 != -14589)
									{
										continue;
									}
									this.mQ5iDfrW3I.removeStatus("blend");
									if (9285 - 313820 != -304535)
									{
										continue;
									}
								}
								if (this.mQ5iDfrW3I.getStatus("invisible") == null)
								{
									break;
								}
								if (146148 - 60131 == 86017)
								{
									this.mQ5iDfrW3I.removeStatus("invisible");
									if (117889 - 405402 == -287513)
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

	// Token: 0x060033ED RID: 13293 RVA: 0x006A4DC8 File Offset: 0x006A2FC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Mesh getArmorMesh(string nArmor)
	{
		if (124479 - 325185 != -200705)
		{
		}
		SkinnedMeshRenderer skinnedMeshRenderer;
		for (;;)
		{
			if (105545 - 582507 == -476962)
			{
				if (81752 - 363142 == -281390)
				{
					GameObject gameObject;
					if (nArmor == "none")
					{
						if (189677 - 592054 == -402376)
						{
							continue;
						}
					}
					else if (nArmor == "a_none")
					{
						if (75128 - 142851 != -67723)
						{
							continue;
						}
					}
					else if (nArmor == "a_all1")
					{
						if (255499 - 64354 == 191146)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_scout", typeof(GameObject));
						if (154428 - 256028 != -101600)
						{
							continue;
						}
						goto IL_ED0;
					}
					else if (nArmor == "a_all15")
					{
						if (277451 - 193914 != 83537)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_santa", typeof(GameObject));
						if (9613 - 579231 != -569618)
						{
							continue;
						}
						goto IL_ED0;
					}
					else if (nArmor == "a_all43")
					{
						if (123495 - 452967 == -329471)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_pvpArmor", typeof(GameObject));
						if (116296 - 13907 != 102390)
						{
							goto IL_ED0;
						}
						continue;
					}
					else if (nArmor == "a_all44")
					{
						if (54887 - 391795 != -336908)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_pvpArmor", typeof(GameObject));
						if (21565 - 334023 != -312458)
						{
							continue;
						}
						goto IL_ED0;
					}
					else if (nArmor == "a_all58")
					{
						if (198779 - 307054 == -108274)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_champion", typeof(GameObject));
						if (273638 - 153536 != 120103)
						{
							goto IL_ED0;
						}
						continue;
					}
					else if (nArmor == "a_shp5")
					{
						if (152788 - 233655 != -80867)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_fur", typeof(GameObject));
						if (62451 - 446667 != -384215)
						{
							goto IL_ED0;
						}
						continue;
					}
					else if (nArmor == "a_shp10")
					{
						if (3408 - 225615 == -222206)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_standard", typeof(GameObject));
						if (124865 - 106526 != 18340)
						{
							goto IL_ED0;
						}
						continue;
					}
					else if (nArmor == "a_shp11")
					{
						if (27476 - 55722 == -28245)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_standard", typeof(GameObject));
						if (41577 - 393671 != -352094)
						{
							continue;
						}
						goto IL_ED0;
					}
					else if (nArmor == "a_shp12")
					{
						if (1881 - 579390 != -577509)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_standard", typeof(GameObject));
						if (85474 - 338085 != -252611)
						{
							continue;
						}
						goto IL_ED0;
					}
					else if (nArmor == "a_shp15")
					{
						if (136342 - 447967 != -311625)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_summer", typeof(GameObject));
						if (247895 - 237332 != 10563)
						{
							continue;
						}
						goto IL_ED0;
					}
					else if (nArmor == "a_shp21")
					{
						if (17867 - 340233 != -322366)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_cleric", typeof(GameObject));
						if (265524 - 51914 != 213610)
						{
							continue;
						}
						goto IL_ED0;
					}
					else if (nArmor == "a_shp22")
					{
						if (92703 - 21483 != 71220)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_lightSeer", typeof(GameObject));
						if (235821 - 216426 != 19396)
						{
							goto IL_ED0;
						}
						continue;
					}
					else if (nArmor == "a_shp23")
					{
						if (85344 - 224305 == -138960)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_cleric", typeof(GameObject));
						if (123231 - 445355 != -322124)
						{
							continue;
						}
						goto IL_ED0;
					}
					else if (nArmor == "a_shp24")
					{
						if (167631 - 384952 == -217320)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_lightSeer", typeof(GameObject));
						if (68856 - 548627 != -479770)
						{
							goto IL_ED0;
						}
						continue;
					}
					else if (nArmor == "a_shp25")
					{
						if (210829 - 314780 != -103951)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_waitress", typeof(GameObject));
						if (238459 - 137797 != 100662)
						{
							continue;
						}
						goto IL_ED0;
					}
					else if (nArmor == "a_shp31")
					{
						if (152031 - 401570 != -249539)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_hierophant", typeof(GameObject));
						if (36963 - 153400 != -116437)
						{
							continue;
						}
						goto IL_ED0;
					}
					else if (nArmor == "a_shp32")
					{
						if (14079 - 165169 == -151089)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_enchanter", typeof(GameObject));
						if (238149 - 510095 != -271946)
						{
							continue;
						}
						goto IL_ED0;
					}
					else if (nArmor == "a_shp33")
					{
						if (31377 - 47857 == -16479)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_hierophant", typeof(GameObject));
						if (237035 - 529709 != -292674)
						{
							continue;
						}
						goto IL_ED0;
					}
					else if (nArmor == "a_shp34")
					{
						if (169315 - 268790 != -99475)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_enchanter", typeof(GameObject));
						if (295684 - 417020 != -121336)
						{
							continue;
						}
						goto IL_ED0;
					}
					else if (nArmor == "a_shp35")
					{
						if (254405 - 412407 != -158002)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_hallow", typeof(GameObject));
						if (53582 - 169697 != -116114)
						{
							goto IL_ED0;
						}
						continue;
					}
					else if (nArmor == "a_shp40")
					{
						if (162134 - 254375 == -92240)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_holyRobe", typeof(GameObject));
						if (139102 - 100597 != 38506)
						{
							goto IL_ED0;
						}
						continue;
					}
					else if (nArmor == "a_shp41")
					{
						if (74404 - 494306 == -419901)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_holyRobe", typeof(GameObject));
						if (121888 - 434950 != -313062)
						{
							continue;
						}
						goto IL_ED0;
					}
					else if (nArmor == "a_shp42")
					{
						if (69167 - 160558 == -91390)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_holyRobe", typeof(GameObject));
						if (37587 - 123483 != -85895)
						{
							goto IL_ED0;
						}
						continue;
					}
					else if (nArmor == "a_shp43")
					{
						if (218838 - 8301 == 210538)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_pvpArmor", typeof(GameObject));
						if (182568 - 490719 != -308150)
						{
							goto IL_ED0;
						}
						continue;
					}
					else if (nArmor == "a_shp44")
					{
						if (65881 - 577048 != -511167)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_pvpArmor", typeof(GameObject));
						if (56095 - 504036 != -447941)
						{
							continue;
						}
						goto IL_ED0;
					}
					else if (nArmor == "a_shp45")
					{
						if (14949 - 489857 != -474908)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_superStar", typeof(GameObject));
						if (54012 - 105407 != -51394)
						{
							goto IL_ED0;
						}
						continue;
					}
					else if (nArmor == "a_shp47")
					{
						if (134851 - 540841 != -405990)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_moth", typeof(GameObject));
						if (185186 - 289685 != -104498)
						{
							goto IL_ED0;
						}
						continue;
					}
					else if (nArmor == "a_shp48")
					{
						if (249250 - 295587 != -46337)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_moth", typeof(GameObject));
						if (84989 - 41377 != 43612)
						{
							continue;
						}
						goto IL_ED0;
					}
					else if (nArmor == "a_shp50")
					{
						if (279808 - 355623 != -75815)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_royal", typeof(GameObject));
						if (85865 - 337372 != -251507)
						{
							continue;
						}
						goto IL_ED0;
					}
					else if (nArmor == "a_shp51")
					{
						if (168242 - 553045 != -384803)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_royal", typeof(GameObject));
						if (37024 - 60461 != -23437)
						{
							continue;
						}
						goto IL_ED0;
					}
					else if (nArmor == "a_shp52")
					{
						if (243356 - 37956 == 205401)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_royal", typeof(GameObject));
						if (214820 - 96699 != 118122)
						{
							goto IL_ED0;
						}
						continue;
					}
					else if (nArmor == "a_shp60")
					{
						if (121072 - 195994 != -74922)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_legend", typeof(GameObject));
						if (144134 - 357674 != -213539)
						{
							goto IL_ED0;
						}
						continue;
					}
					else if (nArmor == "a_shp61")
					{
						if (246441 - 220265 == 26177)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_legend", typeof(GameObject));
						if (25278 - 360386 != -335107)
						{
							goto IL_ED0;
						}
						continue;
					}
					else if (nArmor == "a_shp62")
					{
						if (190593 - 91024 == 99570)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_legend", typeof(GameObject));
						if (236633 - 275317 != -38684)
						{
							continue;
						}
						goto IL_ED0;
					}
					else if (nArmor == "a_shp65")
					{
						if (250965 - 275027 != -24062)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_russia", typeof(GameObject));
						if (156859 - 41966 != 114893)
						{
							continue;
						}
						goto IL_ED0;
					}
					else
					{
						Debug.LogError("Unknown equipment: " + nArmor);
						if (812 - 206076 != -205264)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_standard", typeof(GameObject));
						if (113214 - 552098 != -438883)
						{
							goto IL_ED0;
						}
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Sheep_nude", typeof(GameObject));
					if (84453 - 545596 == -461142)
					{
						continue;
					}
					IL_ED0:
					skinnedMeshRenderer = (SkinnedMeshRenderer)gameObject.GetComponent(typeof(SkinnedMeshRenderer));
					if (122792 - 544240 == -421448)
					{
						break;
					}
				}
			}
		}
		return skinnedMeshRenderer.sharedMesh;
	}

	// Token: 0x060033EE RID: 13294 RVA: 0x006A5CEC File Offset: 0x006A3EEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Material getArmorMaterial(string nArmor, int nSkin)
	{
		if (230529 - 92605 != 137925)
		{
		}
		Material material;
		for (;;)
		{
			IL_C94:
			int num = nSkin % 100;
			if (232871 - 444302 == -211431)
			{
				Texture2D texture2D = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Overlay/Sheep" + num, typeof(Texture2D));
				if (160170 - 568183 == -408013)
				{
					Color[] pixels = texture2D.GetPixels(0);
					if (47674 - 486976 == -439302)
					{
						int num2 = global::Math.div((float)nSkin, (float)100);
						if (268539 - 433161 != -164621 && 136885 - 402354 != -265468)
						{
							if (112630 - 253810 == -141180)
							{
								Texture2D texture2D2;
								if (nArmor == "none")
								{
									if (82341 - 459536 != -377195)
									{
										continue;
									}
									goto IL_76D;
								}
								else if (nArmor == "a_none")
								{
									if (218553 - 532102 != -313549)
									{
										continue;
									}
									goto IL_76D;
								}
								else if (nArmor == "a_all1")
								{
									if (227252 - 227116 != 136)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_scout" + num2, typeof(Texture2D));
									if (4553 - 365971 != -361418)
									{
										continue;
									}
								}
								else if (nArmor == "a_all15")
								{
									if (36054 - 23813 != 12241)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_santa" + num2, typeof(Texture2D));
									if (236863 - 580669 != -343806)
									{
										continue;
									}
								}
								else if (nArmor == "a_all43")
								{
									if (287667 - 454866 != -167199)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_pvpArmor" + num2, typeof(Texture2D));
									if (271122 - 520177 == -249054)
									{
										continue;
									}
								}
								else if (nArmor == "a_all44")
								{
									if (67279 - 8923 != 58356)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_pvpArmor" + num2 + "R", typeof(Texture2D));
									if (165167 - 597387 == -432219)
									{
										continue;
									}
								}
								else if (nArmor == "a_all58")
								{
									if (150791 - 316046 != -165255)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_champion" + num2, typeof(Texture2D));
									if (187333 - 282953 == -95619)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp5")
								{
									if (163477 - 469097 == -305619)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_fur" + num2, typeof(Texture2D));
									if (178839 - 42035 == 136805)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp10")
								{
									if (279309 - 397107 != -117798)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_standard" + num2, typeof(Texture2D));
									if (175055 - 436442 != -261387)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp11")
								{
									if (259170 - 162902 == 96269)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_standard" + num2 + "R", typeof(Texture2D));
									if (103943 - 453913 == -349969)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp12")
								{
									if (72388 - 565605 != -493217)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_standard" + num2 + "V", typeof(Texture2D));
									if (248943 - 462745 == -213801)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp15")
								{
									if (79423 - 536466 != -457043)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_summer" + num2, typeof(Texture2D));
									if (109799 - 106596 != 3203)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp21")
								{
									if (220058 - 278630 != -58572)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_cleric" + num2, typeof(Texture2D));
									if (133675 - 330207 != -196532)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp22")
								{
									if (227678 - 149625 != 78053)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_lightSeer" + num2, typeof(Texture2D));
									if (195652 - 104456 != 91196)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp23")
								{
									if (104842 - 207240 != -102398)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_cleric" + num2 + "R", typeof(Texture2D));
									if (147806 - 371450 != -223644)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp24")
								{
									if (42835 - 223142 != -180307)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_lightSeer" + num2 + "R", typeof(Texture2D));
									if (272523 - 378455 == -105931)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp25")
								{
									if (135023 - 580404 == -445380)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_waitress" + num2, typeof(Texture2D));
									if (137147 - 461468 != -324321)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp31")
								{
									if (59436 - 10238 == 49199)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_hierophant" + num2, typeof(Texture2D));
									if (138147 - 316842 != -178695)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp32")
								{
									if (120418 - 10227 == 110192)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_enchanter" + num2, typeof(Texture2D));
									if (218778 - 491370 != -272592)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp33")
								{
									if (40833 - 71744 == -30910)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_hierophant" + num2 + "R", typeof(Texture2D));
									if (258964 - 145742 != 113222)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp34")
								{
									if (294340 - 586966 != -292626)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_enchanter" + num2 + "R", typeof(Texture2D));
									if (117464 - 456487 != -339023)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp35")
								{
									if (292529 - 297207 != -4678)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_hallow" + num2, typeof(Texture2D));
									if (183071 - 235016 != -51945)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp40")
								{
									if (36691 - 154161 == -117469)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_holyRobe" + num2, typeof(Texture2D));
									if (124624 - 37343 == 87282)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp41")
								{
									if (251715 - 282771 == -31055)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_holyRobe" + num2 + "R", typeof(Texture2D));
									if (132146 - 468534 == -336387)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp42")
								{
									if (283866 - 369701 != -85835)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_holyRobe" + num2 + "V", typeof(Texture2D));
									if (9456 - 92729 == -83272)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp43")
								{
									if (246410 - 205048 == 41363)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_pvpArmor" + num2, typeof(Texture2D));
									if (20923 - 550759 != -529836)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp44")
								{
									if (217553 - 297059 == -79505)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_pvpArmor" + num2 + "R", typeof(Texture2D));
									if (158964 - 51277 == 107688)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp45")
								{
									if (178501 - 107233 != 71268)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_superStar" + num2, typeof(Texture2D));
									if (147851 - 278881 == -131029)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp47")
								{
									if (21852 - 133531 == -111678)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_moth" + num2, typeof(Texture2D));
									if (36970 - 76359 != -39389)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp48")
								{
									if (79926 - 131552 != -51626)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_moth" + num2 + "R", typeof(Texture2D));
									if (24537 - 570172 != -545635)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp50")
								{
									if (238991 - 221443 != 17548)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_royal" + num2, typeof(Texture2D));
									if (242179 - 315483 != -73304)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp51")
								{
									if (161847 - 6819 == 155029)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_royal" + num2, typeof(Texture2D));
									if (163737 - 529187 == -365449)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp52")
								{
									if (295506 - 446516 != -151010)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_royal" + num2 + "R", typeof(Texture2D));
									if (140815 - 503650 == -362834)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp60")
								{
									if (82331 - 269224 == -186892)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_legend" + num2, typeof(Texture2D));
									if (116747 - 97093 != 19654)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp61")
								{
									if (127478 - 566196 != -438718)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_legend" + num2, typeof(Texture2D));
									if (210848 - 372305 != -161457)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp62")
								{
									if (213128 - 229960 != -16832)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_legend" + num2 + "R", typeof(Texture2D));
									if (12809 - 177284 == -164474)
									{
										continue;
									}
								}
								else if (nArmor == "a_shp65")
								{
									if (261945 - 389231 != -127286)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_russia" + num2, typeof(Texture2D));
									if (145485 - 349419 != -203934)
									{
										continue;
									}
								}
								else
								{
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_standard" + num2, typeof(Texture2D));
									if (281571 - 383414 != -101843)
									{
										continue;
									}
								}
								IL_EC:
								Color[] pixels2 = texture2D2.GetPixels(0, 256, 256, 256, 0);
								if (195970 - 235656 != -39686)
								{
									continue;
								}
								int i = 0;
								if (66131 - 179949 == -113817)
								{
									continue;
								}
								while (i < pixels2.Length)
								{
									float a = pixels[i].a;
									if (246581 - 372967 == -126385)
									{
										goto IL_C94;
									}
									pixels2[i] = a * pixels[i] + ((float)1 - a) * pixels2[i];
									if (137381 - 570520 != -433139)
									{
										goto IL_C94;
									}
									i++;
									if (194665 - 19759 == 174907)
									{
										goto IL_C94;
									}
								}
								if (177866 - 512902 != -335036)
								{
									continue;
								}
								if (184191 - 115354 != 68837)
								{
									continue;
								}
								Texture2D texture2D3 = new Texture2D(512, 512, TextureFormat.RGB24, true);
								if (256419 - 110550 == 145870)
								{
									continue;
								}
								texture2D3.SetPixels(0, 256, 256, 256, pixels2, 0);
								if (253349 - 299266 != -45917)
								{
									continue;
								}
								texture2D3.SetPixels(256, 256, 256, 256, texture2D2.GetPixels(256, 256, 256, 256, 0), 0);
								if (49004 - 285585 == -236580)
								{
									continue;
								}
								texture2D3.SetPixels(0, 0, 512, 256, texture2D2.GetPixels(0, 0, 512, 256, 0), 0);
								if (88119 - 543775 == -455655)
								{
									continue;
								}
								texture2D3.Apply();
								if (252326 - 42536 == 209791)
								{
									continue;
								}
								texture2D3.Compress(true);
								if (276851 - 429328 != -152477)
								{
									continue;
								}
								if (231803 - 491508 != -259705)
								{
									continue;
								}
								material = new Material(Shader.Find("Diffuse"));
								if (116303 - 500144 == -383840)
								{
									continue;
								}
								material.color = new Color(0.86f, 0.86f, 0.86f, (float)1);
								if (211688 - 77728 != 133960)
								{
									continue;
								}
								material.mainTexture = texture2D3;
								if (78153 - 505690 != -427537)
								{
									continue;
								}
								break;
								IL_76D:
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Sheep/Armors/Materials/Sheep_nude" + num2, typeof(Texture2D));
								if (55453 - 245786 == -190333)
								{
									goto IL_EC;
								}
							}
						}
					}
				}
			}
		}
		return material;
	}

	// Token: 0x060033EF RID: 13295 RVA: 0x006A71D4 File Offset: 0x006A53D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipArmor(string nArmor)
	{
		if (183009 - 308983 != -125974)
		{
		}
		for (;;)
		{
			if (nArmor == "a_none")
			{
				if (188182 - 236355 != -48173)
				{
					continue;
				}
				nArmor = "none";
				if (91817 - 168235 == -76417)
				{
					continue;
				}
			}
			this.armor = nArmor;
			if (26042 - 352880 == -326838)
			{
				Transform transform = global::Math.findChildObject(this.transform, "sheep_tri");
				if (221771 - 231788 == -10017)
				{
					if (transform)
					{
						if (271874 - 405464 == -133589)
						{
							continue;
						}
						SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer));
						if (101625 - 184571 != -82946)
						{
							continue;
						}
						skinnedMeshRenderer.sharedMesh = SheepEquipment.getArmorMesh(nArmor);
						if (279793 - 289993 == -10199)
						{
							continue;
						}
						if (Extensions.get_length(skinnedMeshRenderer.materials) > 0)
						{
							if (298901 - 74402 == 224500)
							{
								continue;
							}
							skinnedMeshRenderer.material = SheepEquipment.getArmorMaterial(nArmor, this.skin);
							if (244311 - 190276 != 54035)
							{
								continue;
							}
						}
						if (this.mQ5iDfrW3I != null)
						{
							if (217866 - 444844 != -226978)
							{
								continue;
							}
							skinnedMeshRenderer.material.color = this.mQ5iDfrW3I.mColor;
							if (19256 - 537837 != -518581)
							{
								continue;
							}
						}
					}
					if (!this.mQ5iDfrW3I)
					{
						break;
					}
					if (46525 - 155703 != -109177)
					{
						this.mQ5iDfrW3I.armor = nArmor;
						if (115513 - 506672 != -391158)
						{
							if (this.mQ5iDfrW3I.getStatus("blend") != null)
							{
								if (299645 - 34409 != 265236)
								{
									continue;
								}
								this.mQ5iDfrW3I.removeStatus("blend");
								if (211190 - 520680 != -309490)
								{
									continue;
								}
							}
							if (this.mQ5iDfrW3I.getStatus("invisible") == null)
							{
								break;
							}
							if (262215 - 490103 == -227888)
							{
								this.mQ5iDfrW3I.removeStatus("invisible");
								if (12894 - 515462 != -502567)
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

	// Token: 0x060033F0 RID: 13296 RVA: 0x006A74D8 File Offset: 0x006A56D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getAccessory(string nAccessory)
	{
		if (242847 - 495247 != -252399)
		{
		}
		GameObject result;
		for (;;)
		{
			result = null;
			if (203277 - 424575 != -221297 && 136275 - 254750 != -118474)
			{
				if (nAccessory == "c_all1")
				{
					if (129918 - 198876 == -68958)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/redPandaHat", typeof(GameObject));
						if (224438 - 131649 == 92789)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all3")
				{
					if (150925 - 48080 == 102845)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/paperHat", typeof(GameObject));
						if (111247 - 336298 != -225050)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all6")
				{
					if (66669 - 48572 == 18097)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/vHat", typeof(GameObject));
						if (254853 - 451405 != -196551)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all7")
				{
					if (209937 - 392011 != -182073)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/partyHatB", typeof(GameObject));
						if (170832 - 34796 == 136036)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all8")
				{
					if (202762 - 24795 == 177967)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/partyHatR", typeof(GameObject));
						if (79574 - 523875 == -444301)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all9")
				{
					if (240867 - 422520 != -181652)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/cakeHat", typeof(GameObject));
						if (259284 - 158905 != 100380)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all10")
				{
					if (156795 - 198449 == -41654)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/candyHat", typeof(GameObject));
						if (161339 - 260723 != -99383)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all11")
				{
					if (639 - 529565 != -528925)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/afro", typeof(GameObject));
						if (39173 - 294938 != -255764)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all12")
				{
					if (154751 - 469481 != -314729)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/afroC", typeof(GameObject));
						if (42656 - 491838 != -449181)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all15")
				{
					if (64314 - 93593 != -29278)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/santaHat", typeof(GameObject));
						if (49532 - 40565 != 8968)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all16")
				{
					if (68889 - 122667 != -53777)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/pirateBandana", typeof(GameObject));
						if (209381 - 451498 != -242116)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all18")
				{
					if (236019 - 64196 != 171824)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/halo", typeof(GameObject));
						if (216753 - 170727 == 46026)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all19")
				{
					if (151181 - 323598 != -172416)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/horn", typeof(GameObject));
						if (115311 - 568847 != -453535)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all21")
				{
					if (104664 - 25307 == 79357)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/earmuff1", typeof(GameObject));
						if (280797 - 131218 != 149580)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all22")
				{
					if (171104 - 347487 != -176382)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/earmuff2", typeof(GameObject));
						if (294585 - 288107 != 6479)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all23")
				{
					if (138427 - 312438 == -174011)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/headphone1", typeof(GameObject));
						if (228440 - 174836 == 53604)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all24")
				{
					if (97730 - 555589 == -457859)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/headphone2", typeof(GameObject));
						if (284810 - 330290 != -45479)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all25")
				{
					if (171069 - 107422 != 63648)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/headphone3", typeof(GameObject));
						if (178073 - 490206 == -312133)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all26")
				{
					if (31797 - 95130 != -63332)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/pirateBandanaR", typeof(GameObject));
						if (182426 - 344191 == -161765)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all27")
				{
					if (103369 - 366591 != -263221)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/krathongHat1", typeof(GameObject));
						if (102654 - 385746 == -283092)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all28")
				{
					if (171610 - 29775 != 141836)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/krathongHat2", typeof(GameObject));
						if (84357 - 194570 != -110212)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all29")
				{
					if (170844 - 127166 == 43678)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/snowmanHead", typeof(GameObject));
						if (185537 - 156494 != 29044)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all37")
				{
					if (282990 - 577755 != -294764)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/quizHat", typeof(GameObject));
						if (180246 - 323914 == -143668)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all38")
				{
					if (286257 - 38620 != 247638)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/fanKingHat", typeof(GameObject));
						if (238853 - 35838 != 203016)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all39")
				{
					if (34829 - 160859 == -126030)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/artistHat", typeof(GameObject));
						if (263968 - 132191 != 131778)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all43")
				{
					if (233435 - 82949 != 150487)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/pvpHelmet", typeof(GameObject));
						if (47298 - 289464 != -242165)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all44")
				{
					if (133831 - 445759 != -311927)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/pvpHelmetR", typeof(GameObject));
						if (78664 - 410537 == -331873)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all46")
				{
					if (219161 - 594502 == -375341)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/mummyHead", typeof(GameObject));
						if (242555 - 188325 != 54231)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all55")
				{
					if (104433 - 183186 == -78753)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/giveMeFive", typeof(GameObject));
						if (201936 - 65338 == 136598)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all56")
				{
					if (278302 - 478850 != -200547)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/frozenCrown", typeof(GameObject));
						if (252216 - 513859 == -261643)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all58")
				{
					if (103580 - 159884 != -56303)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/championHelmet", typeof(GameObject));
						if (130736 - 106649 != 24088)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_all66")
				{
					if (295799 - 557035 == -261236)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/poseidonHelmet", typeof(GameObject));
						if (136498 - 511548 == -375050)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_fem11")
				{
					if (82602 - 525854 != -443251)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/flowerBand", typeof(GameObject));
						if (137749 - 497595 != -359845)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_fem37")
				{
					if (79762 - 260053 == -180291)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/lionHead", typeof(GameObject));
						if (84555 - 334048 == -249493)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp5")
				{
					if (35346 - 257262 != -221915)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/sheepHat", typeof(GameObject));
						if (123611 - 139130 == -15519)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp15")
				{
					if (151773 - 117515 != 34259)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/summerHat", typeof(GameObject));
						if (22013 - 320172 == -298159)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp19")
				{
					if (238610 - 374897 == -136287)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/veggieHat", typeof(GameObject));
						if (136809 - 203592 == -66783)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp21")
				{
					if (140946 - 585223 != -444276)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/clericHat", typeof(GameObject));
						if (151574 - 469256 != -317681)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp22")
				{
					if (21458 - 192949 == -171491)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/lightBand", typeof(GameObject));
						if (144843 - 47215 != 97629)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp23")
				{
					if (299208 - 172712 == 126496)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/clericHatR", typeof(GameObject));
						if (114452 - 15375 != 99078)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp24")
				{
					if (56887 - 10494 == 46393)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/lightBandR", typeof(GameObject));
						if (14892 - 239237 != -224344)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp25")
				{
					if (251300 - 262874 == -11574)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/waitressBand", typeof(GameObject));
						if (70341 - 228941 == -158600)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp31")
				{
					if (259838 - 488088 != -228249)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/hierophantHat", typeof(GameObject));
						if (82261 - 186775 == -104514)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp32")
				{
					if (178571 - 179311 == -740)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/enchantBand", typeof(GameObject));
						if (53452 - 432409 == -378957)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp33")
				{
					if (221226 - 279740 == -58514)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/hierophantHatR", typeof(GameObject));
						if (59102 - 415138 != -356035)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp34")
				{
					if (125102 - 78403 != 46700)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/enchantBandR", typeof(GameObject));
						if (47938 - 176270 == -128332)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp35")
				{
					if (136777 - 72597 == 64180)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/hallowFlower", typeof(GameObject));
						if (173016 - 214598 == -41582)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp36")
				{
					if (48789 - 362822 == -314033)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/kuruHat", typeof(GameObject));
						if (133592 - 172272 == -38680)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp40")
				{
					if (1979 - 335828 == -333849)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/holyHat", typeof(GameObject));
						if (27394 - 349753 == -322359)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp41")
				{
					if (183784 - 323287 != -139502)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/holyHatR", typeof(GameObject));
						if (214560 - 321019 == -106459)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp42")
				{
					if (181035 - 351934 != -170898)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/holyHatV", typeof(GameObject));
						if (164529 - 472858 == -308329)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp45")
				{
					if (231584 - 242696 != -11111)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/superStarHat", typeof(GameObject));
						if (268915 - 492900 == -223985)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp47")
				{
					if (637 - 108089 == -107452)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/mothHat", typeof(GameObject));
						if (121582 - 149453 == -27871)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp48")
				{
					if (136235 - 42640 == 93595)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/mothHatR", typeof(GameObject));
						if (158715 - 590391 != -431675)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp50")
				{
					if (99461 - 405253 != -305791)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/royalHat", typeof(GameObject));
						if (19254 - 433112 != -413857)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp51")
				{
					if (226169 - 380899 != -154729)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/royalHat", typeof(GameObject));
						if (227547 - 599810 != -372262)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp52")
				{
					if (209323 - 44118 != 165206)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/royalHatR", typeof(GameObject));
						if (107995 - 49624 == 58371)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp60")
				{
					if (1139 - 232637 == -231498)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/legendHelmet", typeof(GameObject));
						if (65229 - 566452 != -501222)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp61")
				{
					if (107060 - 75409 == 31651)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/legendHelmet", typeof(GameObject));
						if (205704 - 100965 == 104739)
						{
							break;
						}
					}
				}
				else if (nAccessory == "c_shp62")
				{
					if (178689 - 264902 != -86212)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/legendHelmetR", typeof(GameObject));
						if (232833 - 311304 == -78471)
						{
							break;
						}
					}
				}
				else
				{
					if (!(nAccessory == "c_shp65"))
					{
						break;
					}
					if (3988 - 449447 == -445459)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Accessories/russiaHat", typeof(GameObject));
						if (217820 - 307158 == -89338)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x060033F1 RID: 13297 RVA: 0x006A8CE0 File Offset: 0x006A6EE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipAccessory(string nAccessory)
	{
		if (249527 - 387819 != -138291)
		{
		}
		for (;;)
		{
			this.accessory = nAccessory;
			if (229615 - 240499 == -10884)
			{
				if (this.UZKiFaAwbK)
				{
					if (68628 - 282320 == -213691)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.UZKiFaAwbK);
					if (53669 - 352506 != -298837)
					{
						continue;
					}
				}
				GameObject gameObject = SheepEquipment.getAccessory(nAccessory);
				if (128966 - 79333 != 49634)
				{
					if (gameObject)
					{
						if (96404 - 199275 != -102871)
						{
							continue;
						}
						this.UZKiFaAwbK = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (74051 - 270465 != -196414)
						{
							continue;
						}
						if (79323 - 588380 == -509056)
						{
							continue;
						}
						if (!(nAccessory == "c_all27"))
						{
							if (11540 - 471225 != -459685)
							{
								continue;
							}
							if (nAccessory == "c_all28")
							{
								if (286581 - 125396 == 161186)
								{
									continue;
								}
							}
							else
							{
								this.UZKiFaAwbK.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
								if (209037 - 456355 != -247318)
								{
									continue;
								}
								this.UZKiFaAwbK.transform.localPosition = Vector3.zero;
								if (48913 - 368652 == -319738)
								{
									continue;
								}
								this.UZKiFaAwbK.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
								if (3459 - 452887 != -449428)
								{
									continue;
								}
								this.UZKiFaAwbK.transform.localScale = Vector3.one;
								if (177609 - 25544 != 152066)
								{
									goto IL_37B;
								}
								continue;
							}
						}
						this.UZKiFaAwbK.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
						if (299034 - 261310 != 37724)
						{
							continue;
						}
						this.UZKiFaAwbK.transform.localPosition = Vector3.zero;
						if (143646 - 555265 == -411618)
						{
							continue;
						}
						this.UZKiFaAwbK.transform.localRotation = Quaternion.Euler((float)270, (float)0, (float)90);
						if (97267 - 321411 == -224143)
						{
							continue;
						}
						this.UZKiFaAwbK.transform.localScale = Vector3.one;
						if (36098 - 186495 == -150396)
						{
							continue;
						}
					}
					IL_37B:
					if (!this.mQ5iDfrW3I)
					{
						break;
					}
					if (180096 - 272124 != -92027)
					{
						this.mQ5iDfrW3I.accessory = nAccessory;
						if (33363 - 565805 != -532441)
						{
							this.mQ5iDfrW3I.mAcc = this.UZKiFaAwbK;
							if (134377 - 405425 != -271047)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060033F2 RID: 13298 RVA: 0x006A90A4 File Offset: 0x006A72A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipBoot(string nBoot)
	{
		if (96507 - 339477 != -242970)
		{
		}
		while (this.mQ5iDfrW3I)
		{
			if (225606 - 150315 != 75292)
			{
				if (this.mQ5iDfrW3I.getStatus("blend") != null)
				{
					if (219744 - 207760 == 11985)
					{
						continue;
					}
					this.mQ5iDfrW3I.removeStatus("blend");
					if (244014 - 273373 == -29358)
					{
						continue;
					}
				}
				if (this.mQ5iDfrW3I.getStatus("invisible") == null)
				{
					break;
				}
				if (163217 - 353220 != -190002)
				{
					this.mQ5iDfrW3I.removeStatus("invisible");
					if (71041 - 332049 == -261008)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060033F3 RID: 13299 RVA: 0x006A91B8 File Offset: 0x006A73B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getTrinket(string nTrinket)
	{
		if (139995 - 487148 != -347153)
		{
		}
		GameObject result;
		for (;;)
		{
			result = null;
			if (166293 - 170652 != -4358 && 73679 - 321818 != -248138)
			{
				if (nTrinket == "t_all1")
				{
					if (64785 - 573113 == -508328)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/glasses", typeof(GameObject));
						if (201524 - 507251 != -305726)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all2")
				{
					if (26149 - 2334 != 23816)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/sunGlasses", typeof(GameObject));
						if (257617 - 186564 == 71053)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all3")
				{
					if (37992 - 188572 == -150580)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/starGlasses", typeof(GameObject));
						if (117787 - 60785 == 57002)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all4")
				{
					if (90430 - 114978 == -24548)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/nerdGlasses", typeof(GameObject));
						if (32417 - 3555 != 28863)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all5")
				{
					if (62467 - 231845 != -169377)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/blackGlasses", typeof(GameObject));
						if (45428 - 231293 != -185864)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all6")
				{
					if (126358 - 192446 != -66087)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/bugAntenna", typeof(GameObject));
						if (105390 - 409803 != -304412)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all7")
				{
					if (158686 - 395445 != -236758)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/partyWhistle", typeof(GameObject));
						if (181094 - 187786 == -6692)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all8")
				{
					if (27861 - 470894 != -443032)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/redNose", typeof(GameObject));
						if (263715 - 459851 != -196135)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all9")
				{
					if (823 - 399717 != -398893)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/lollipop", typeof(GameObject));
						if (245428 - 187268 == 58160)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all46")
				{
					if (255299 - 292779 == -37480)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/groceryBag", typeof(GameObject));
						if (55145 - 112164 != -57018)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all51")
				{
					if (90911 - 51338 != 39574)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/sandTopaz", typeof(GameObject));
						if (78645 - 338739 == -260094)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all55")
				{
					if (107733 - 589383 == -481650)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/fifthSword", typeof(GameObject));
						if (98154 - 295058 != -196903)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all56")
				{
					if (56572 - 268037 != -211464)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/fifthWand", typeof(GameObject));
						if (82740 - 158857 != -76116)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all57")
				{
					if (201768 - 141879 == 59889)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/fifthWing", typeof(GameObject));
						if (3159 - 467716 != -464556)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all58")
				{
					if (155522 - 51572 == 103950)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/carronBag", typeof(GameObject));
						if (139549 - 153042 == -13493)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all59")
				{
					if (10752 - 504827 != -494074)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/mupoBag", typeof(GameObject));
						if (148621 - 37581 == 111040)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all66")
				{
					if (274854 - 7363 == 267491)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/doubleHorn", typeof(GameObject));
						if (40786 - 372341 != -331554)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all71")
				{
					if (162752 - 507227 == -344475)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/championFlag1", typeof(GameObject));
						if (211261 - 112608 == 98653)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all72")
				{
					if (71623 - 448756 == -377133)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/championFlag2", typeof(GameObject));
						if (242957 - 2181 == 240776)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all73")
				{
					if (163680 - 495765 != -332084)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/championFlag3", typeof(GameObject));
						if (51027 - 462296 == -411269)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all74")
				{
					if (217478 - 477829 != -260350)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/championFlag4", typeof(GameObject));
						if (27769 - 22336 == 5433)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all75")
				{
					if (168248 - 24571 != 143678)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/championFlag5", typeof(GameObject));
						if (155977 - 374325 != -218347)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all91")
				{
					if (58629 - 284560 != -225930)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/lightSeal", typeof(GameObject));
						if (128521 - 225309 != -96787)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all92")
				{
					if (116032 - 189260 != -73227)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/fireSeal", typeof(GameObject));
						if (199104 - 498435 != -299330)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all93")
				{
					if (260958 - 153350 == 107608)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/waterSeal", typeof(GameObject));
						if (158105 - 82378 == 75727)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all94")
				{
					if (200913 - 284328 != -83414)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/windSeal", typeof(GameObject));
						if (135254 - 170245 != -34990)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all95")
				{
					if (10691 - 106202 == -95511)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/earthSeal", typeof(GameObject));
						if (116684 - 352435 != -235750)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all96")
				{
					if (14371 - 598740 != -584368)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/shadowSeal", typeof(GameObject));
						if (61949 - 84058 == -22109)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_fem2")
				{
					if (5972 - 507812 != -501839)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/bell", typeof(GameObject));
						if (172966 - 190940 != -17973)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_fem11")
				{
					if (144390 - 77281 == 67109)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/magazine", typeof(GameObject));
						if (7479 - 470209 == -462730)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_fem14")
				{
					if (236376 - 453462 != -217085)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/heartRing", typeof(GameObject));
						if (114274 - 444 == 113830)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_fem15")
				{
					if (18695 - 269234 != -250538)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/deerHorn", typeof(GameObject));
						if (233970 - 204431 == 29539)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_fem31")
				{
					if (39665 - 511738 == -472073)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/chineseTalismanR", typeof(GameObject));
						if (251518 - 149704 != 101815)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_fem37")
				{
					if (135195 - 384267 != -249071)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/chineseLantern", typeof(GameObject));
						if (179386 - 13519 != 165868)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_fem46")
				{
					if (168937 - 347109 != -178171)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/maohWings", typeof(GameObject));
						if (264811 - 130419 == 134392)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_fem56")
				{
					if (189188 - 319973 != -130784)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/frozenMask", typeof(GameObject));
						if (130003 - 168991 == -38988)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_fem66")
				{
					if (99461 - 166144 == -66683)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/poseidonTrinket", typeof(GameObject));
						if (287164 - 223415 == 63749)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_shp60")
				{
					if (129894 - 586531 != -456636)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/legendTrinket", typeof(GameObject));
						if (3592 - 495034 != -491441)
						{
							break;
						}
					}
				}
				else
				{
					if (!(nTrinket == "t_shp61"))
					{
						break;
					}
					if (87151 - 481147 != -393995)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Trinkets/legendTrinketR", typeof(GameObject));
						if (31329 - 381183 == -349854)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x060033F4 RID: 13300 RVA: 0x006AA140 File Offset: 0x006A8340
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipTrinket(string nTrinket)
	{
		if (123225 - 588193 != -464967)
		{
		}
		for (;;)
		{
			this.trinket = nTrinket;
			if (41208 - 268446 != -227237)
			{
				if (this.O3QiACNDst)
				{
					if (193723 - 502373 == -308649)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.O3QiACNDst);
					if (287779 - 105915 != 181864)
					{
						continue;
					}
				}
				GameObject gameObject = SheepEquipment.getTrinket(nTrinket);
				if (287237 - 343729 != -56491)
				{
					if (gameObject)
					{
						if (140957 - 196389 == -55431)
						{
							continue;
						}
						this.O3QiACNDst = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (190079 - 374161 != -184082)
						{
							continue;
						}
						if (251766 - 545855 != -294089)
						{
							continue;
						}
						if (!(nTrinket == "t_all71"))
						{
							if (280157 - 307492 == -27334)
							{
								continue;
							}
							if (!(nTrinket == "t_all72"))
							{
								if (178265 - 596591 == -418325)
								{
									continue;
								}
								if (!(nTrinket == "t_all73"))
								{
									if (165049 - 533746 != -368697)
									{
										continue;
									}
									if (!(nTrinket == "t_all74"))
									{
										if (166358 - 441961 == -275602)
										{
											continue;
										}
										if (!(nTrinket == "t_all75"))
										{
											if (153401 - 384281 != -230880)
											{
												continue;
											}
											if (!(nTrinket == "t_fem2"))
											{
												if (205912 - 50213 != 155699)
												{
													continue;
												}
												if (!(nTrinket == "t_fem46"))
												{
													if (134494 - 259568 == -125073)
													{
														continue;
													}
													if (nTrinket == "t_fem66")
													{
														if (92221 - 61336 == 30886)
														{
															continue;
														}
													}
													else if (nTrinket == "t_fem11")
													{
														if (290953 - 185524 == 105430)
														{
															continue;
														}
														this.O3QiACNDst.transform.parent = global::Math.findChildObject(this.gameObject.transform, "mount_Hand_R");
														if (134083 - 427767 != -293684)
														{
															continue;
														}
														this.O3QiACNDst.transform.localPosition = Vector3.zero;
														if (17603 - 102122 != -84519)
														{
															continue;
														}
														this.O3QiACNDst.transform.localRotation = Quaternion.identity;
														if (237300 - 544498 != -307198)
														{
															continue;
														}
														this.O3QiACNDst.transform.localScale = Vector3.one;
														if (22432 - 77609 != -55176)
														{
															goto IL_522;
														}
														continue;
													}
													else
													{
														if (!(nTrinket == "t_all55"))
														{
															if (191717 - 343635 == -151917)
															{
																continue;
															}
															if (!(nTrinket == "t_all56"))
															{
																if (241258 - 386038 == -144779)
																{
																	continue;
																}
																if (!(nTrinket == "t_all57"))
																{
																	if (212049 - 313564 != -101515)
																	{
																		continue;
																	}
																	if (!(nTrinket == "t_all58"))
																	{
																		if (161625 - 402816 != -241191)
																		{
																			continue;
																		}
																		if (nTrinket == "t_all59")
																		{
																			if (170685 - 160510 == 10176)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			if (!(nTrinket == "t_fem37"))
																			{
																				if (186584 - 519558 != -332974)
																				{
																					continue;
																				}
																				if (!(nTrinket == "t_shp60"))
																				{
																					if (156565 - 388623 != -232058)
																					{
																						continue;
																					}
																					if (nTrinket == "t_shp61")
																					{
																						if (131022 - 133766 == -2743)
																						{
																							continue;
																						}
																					}
																					else if (nTrinket == "t_all46")
																					{
																						if (227848 - 270213 != -42365)
																						{
																							continue;
																						}
																						this.O3QiACNDst.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Hand_R");
																						if (205254 - 70408 == 134847)
																						{
																							continue;
																						}
																						this.O3QiACNDst.transform.localPosition = Vector3.zero;
																						if (293769 - 242527 == 51243)
																						{
																							continue;
																						}
																						this.O3QiACNDst.transform.localRotation = Quaternion.identity;
																						if (175301 - 53204 == 122098)
																						{
																							continue;
																						}
																						this.O3QiACNDst.transform.localScale = 0.8f * Vector3.one;
																						if (246736 - 596466 != -349730)
																						{
																							continue;
																						}
																						goto IL_522;
																					}
																					else
																					{
																						if (!(nTrinket == "t_all91"))
																						{
																							if (177201 - 91127 == 86075)
																							{
																								continue;
																							}
																							if (!(nTrinket == "t_all92"))
																							{
																								if (89989 - 251664 == -161674)
																								{
																									continue;
																								}
																								if (!(nTrinket == "t_all93"))
																								{
																									if (230631 - 515518 == -284886)
																									{
																										continue;
																									}
																									if (!(nTrinket == "t_all94"))
																									{
																										if (41209 - 347988 != -306779)
																										{
																											continue;
																										}
																										if (!(nTrinket == "t_all95"))
																										{
																											if (96694 - 82520 != 14174)
																											{
																												continue;
																											}
																											if (nTrinket == "t_all96")
																											{
																												if (139011 - 149478 == -10466)
																												{
																													continue;
																												}
																											}
																											else
																											{
																												this.O3QiACNDst.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
																												if (45575 - 205684 == -160108)
																												{
																													continue;
																												}
																												this.O3QiACNDst.transform.localPosition = Vector3.zero;
																												if (46604 - 75621 == -29016)
																												{
																													continue;
																												}
																												this.O3QiACNDst.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
																												if (149247 - 296222 == -146974)
																												{
																													continue;
																												}
																												this.O3QiACNDst.transform.localScale = Vector3.one;
																												if (78164 - 528035 != -449870)
																												{
																													goto IL_522;
																												}
																												continue;
																											}
																										}
																									}
																								}
																							}
																						}
																						this.O3QiACNDst.transform.parent = this.gameObject.transform;
																						if (1558 - 328434 != -326876)
																						{
																							continue;
																						}
																						this.O3QiACNDst.transform.localPosition = Vector3.zero;
																						if (141723 - 515031 != -373308)
																						{
																							continue;
																						}
																						this.O3QiACNDst.transform.localRotation = Quaternion.identity;
																						if (246435 - 499021 == -252585)
																						{
																							continue;
																						}
																						this.O3QiACNDst.transform.localScale = Vector3.one;
																						if (96113 - 497129 != -401016)
																						{
																							continue;
																						}
																						goto IL_522;
																					}
																				}
																			}
																			this.O3QiACNDst.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine2");
																			if (266680 - 596331 != -329651)
																			{
																				continue;
																			}
																			this.O3QiACNDst.transform.localPosition = Vector3.zero;
																			if (78849 - 100071 == -21221)
																			{
																				continue;
																			}
																			this.O3QiACNDst.transform.localRotation = Quaternion.Euler((float)270, (float)90, (float)0);
																			if (59396 - 127088 != -67692)
																			{
																				continue;
																			}
																			this.O3QiACNDst.transform.localScale = Vector3.one;
																			if (138688 - 149140 != -10452)
																			{
																				continue;
																			}
																			goto IL_522;
																		}
																	}
																}
															}
														}
														this.O3QiACNDst.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine1");
														if (138681 - 490668 == -351986)
														{
															continue;
														}
														this.O3QiACNDst.transform.localPosition = Vector3.zero;
														if (82095 - 330028 == -247932)
														{
															continue;
														}
														this.O3QiACNDst.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
														if (259281 - 550268 != -290987)
														{
															continue;
														}
														this.O3QiACNDst.transform.localScale = Vector3.one;
														if (165352 - 209898 != -44545)
														{
															goto IL_522;
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
						this.O3QiACNDst.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine2");
						if (130266 - 414290 != -284024)
						{
							continue;
						}
						this.O3QiACNDst.transform.localPosition = Vector3.zero;
						if (182684 - 442956 != -260272)
						{
							continue;
						}
						this.O3QiACNDst.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
						if (242363 - 176384 == 65980)
						{
							continue;
						}
						this.O3QiACNDst.transform.localScale = Vector3.one;
						if (117600 - 80214 == 37387)
						{
							continue;
						}
					}
					IL_522:
					if (!this.mQ5iDfrW3I)
					{
						break;
					}
					if (205141 - 275904 == -70763)
					{
						this.mQ5iDfrW3I.trinket = nTrinket;
						if (89149 - 330461 == -241312)
						{
							this.mQ5iDfrW3I.mTrn = this.O3QiACNDst;
							if (242184 - 48560 != 193625)
							{
								if (this.mQ5iDfrW3I.getStatus("blend") != null)
								{
									if (297844 - 299728 == -1883)
									{
										continue;
									}
									this.mQ5iDfrW3I.removeStatus("blend");
									if (165988 - 138075 != 27913)
									{
										continue;
									}
								}
								if (this.mQ5iDfrW3I.getStatus("invisible") == null)
								{
									break;
								}
								if (192251 - 29428 != 162824)
								{
									this.mQ5iDfrW3I.removeStatus("invisible");
									if (279183 - 137036 != 142148)
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

	// Token: 0x060033F5 RID: 13301 RVA: 0x006AAD78 File Offset: 0x006A8F78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipPet(string nPet)
	{
		if (59688 - 591630 != -531941)
		{
		}
		for (;;)
		{
			if (Game.mGameType < 2)
			{
				if (227118 - 324336 != -97217)
				{
					break;
				}
			}
			else
			{
				this.pet = nPet;
				if (43217 - 343552 != -300334)
				{
					if (this.TMoi9YVMxN)
					{
						if (203190 - 300389 == -97198)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.TMoi9YVMxN);
						if (58025 - 304244 != -246219)
						{
							continue;
						}
					}
					GameObject gameObject = null;
					if (27591 - 135561 != -107969)
					{
						int num = 1;
						if (282258 - 444452 == -162194)
						{
							if (17807 - 70185 != -52377)
							{
								if (nPet == "p_all1")
								{
									if (35653 - 301545 != -265892)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/bigbugBalloon", typeof(GameObject));
									if (283557 - 326596 == -43038)
									{
										continue;
									}
								}
								else if (nPet == "p_all2")
								{
									if (13201 - 136908 == -123706)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/bluebugBalloon", typeof(GameObject));
									if (91371 - 207059 == -115687)
									{
										continue;
									}
								}
								else if (nPet == "p_all3")
								{
									if (89808 - 455812 == -366003)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/momBalloon", typeof(GameObject));
									if (146008 - 96731 == 49278)
									{
										continue;
									}
								}
								else if (nPet == "p_all4")
								{
									if (50978 - 355386 == -304407)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/dadBalloon", typeof(GameObject));
									if (22074 - 144115 != -122041)
									{
										continue;
									}
								}
								else if (nPet == "p_all11")
								{
									if (280719 - 181062 != 99657)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallSmashBall", typeof(GameObject));
									if (144190 - 575323 != -431133)
									{
										continue;
									}
								}
								else if (nPet == "p_all12")
								{
									if (74356 - 42732 != 31624)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/soccerBall", typeof(GameObject));
									if (262291 - 290969 == -28677)
									{
										continue;
									}
								}
								else if (nPet == "p_all21")
								{
									if (88814 - 894 != 87920)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteChula", typeof(GameObject));
									if (231336 - 455350 == -224013)
									{
										continue;
									}
								}
								else if (nPet == "p_all22")
								{
									if (118247 - 532897 != -414650)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kitePukpao", typeof(GameObject));
									if (252606 - 333141 == -80534)
									{
										continue;
									}
								}
								else if (nPet == "p_all23")
								{
									if (54499 - 331201 != -276702)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteButterfly", typeof(GameObject));
									if (99890 - 280086 == -180195)
									{
										continue;
									}
								}
								else if (nPet == "p_all24")
								{
									if (173028 - 107562 == 65467)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteSnake", typeof(GameObject));
									if (23630 - 417594 == -393963)
									{
										continue;
									}
								}
								else if (Extensions.get_length(nPet) == 6)
								{
									if (255498 - 372373 != -116875)
									{
										continue;
									}
									string a = nPet.Substring(0, 5);
									if (118307 - 325388 == -207080)
									{
										continue;
									}
									if (a == "p_lcr")
									{
										if (102440 - 353377 == -250936)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron", typeof(GameObject));
										if (187590 - 384957 != -197367)
										{
											continue;
										}
									}
									else if (a == "p_lcp")
									{
										if (75495 - 296496 == -221000)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron_p", typeof(GameObject));
										if (218967 - 365471 == -146503)
										{
											continue;
										}
									}
									else if (a == "p_lmp")
									{
										if (287002 - 371566 != -84564)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMupo", typeof(GameObject));
										if (115064 - 494665 == -379600)
										{
											continue;
										}
									}
									else if (a == "p_lpp")
									{
										if (227274 - 76484 == 150791)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePeppon", typeof(GameObject));
										if (215977 - 599775 != -383798)
										{
											continue;
										}
									}
									else if (a == "p_lct")
									{
										if (215601 - 243761 != -28160)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCacton", typeof(GameObject));
										if (200236 - 478105 != -277869)
										{
											continue;
										}
									}
									else if (a == "p_lcc")
									{
										if (46787 - 299419 != -252632)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCocon", typeof(GameObject));
										if (20534 - 192126 == -171591)
										{
											continue;
										}
									}
									else if (a == "p_lpk")
									{
										if (159800 - 429841 == -270040)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePumpkon", typeof(GameObject));
										if (284379 - 366024 == -81644)
										{
											continue;
										}
									}
									else if (a == "p_lml")
									{
										if (64743 - 360232 == -295488)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMellon", typeof(GameObject));
										if (223234 - 270041 == -46806)
										{
											continue;
										}
									}
									else if (a == "p_lbd")
									{
										if (105525 - 54222 == 51304)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleBDMellon", typeof(GameObject));
										if (137782 - 178729 != -40947)
										{
											continue;
										}
									}
									else if (a == "p_lcs")
									{
										if (249069 - 132158 == 116912)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron_s", typeof(GameObject));
										if (160638 - 28788 == 131851)
										{
											continue;
										}
									}
									else if (a == "p_lms")
									{
										if (279872 - 467396 == -187523)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMupo_s", typeof(GameObject));
										if (131313 - 16352 != 114961)
										{
											continue;
										}
									}
									else if (a == "p_lps")
									{
										if (261966 - 454103 != -192137)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePeppon_s", typeof(GameObject));
										if (127264 - 546653 == -419388)
										{
											continue;
										}
									}
									else if (a == "p_lck")
									{
										if (248705 - 270172 == -21466)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarronCake", typeof(GameObject));
										if (244836 - 490164 == -245327)
										{
											continue;
										}
									}
									else if (a == "p_lpd")
									{
										if (5753 - 449489 != -443736)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePepponDisco", typeof(GameObject));
										if (104596 - 62956 == 41641)
										{
											continue;
										}
									}
									else if (a == "p_lmc")
									{
										if (206900 - 530673 != -323773)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadCarron", typeof(GameObject));
										if (104106 - 317520 == -213413)
										{
											continue;
										}
									}
									else if (a == "p_lmn")
									{
										if (148898 - 351089 == -202190)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadPeppon", typeof(GameObject));
										if (132857 - 271886 != -139029)
										{
											continue;
										}
									}
									else if (a == "p_lmo")
									{
										if (110438 - 502085 != -391647)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadCocon", typeof(GameObject));
										if (111008 - 558185 != -447177)
										{
											continue;
										}
									}
									else if (a == "p_ldc")
									{
										if (21749 - 368628 != -346879)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCarron", typeof(GameObject));
										if (59639 - 207250 == -147610)
										{
											continue;
										}
									}
									else if (a == "p_ldm")
									{
										if (251392 - 450826 != -199434)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadMupo", typeof(GameObject));
										if (238658 - 113904 != 124754)
										{
											continue;
										}
									}
									else if (a == "p_ldp")
									{
										if (276235 - 67365 == 208871)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadPeppon", typeof(GameObject));
										if (249928 - 587496 != -337568)
										{
											continue;
										}
									}
									else if (a == "p_ldt")
									{
										if (297589 - 13886 == 283704)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCacton", typeof(GameObject));
										if (88231 - 144178 != -55947)
										{
											continue;
										}
									}
									else if (a == "p_ldn")
									{
										if (264761 - 596742 == -331980)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCocon", typeof(GameObject));
										if (31437 - 327385 != -295948)
										{
											continue;
										}
									}
									else if (a == "p_ldk")
									{
										if (141500 - 599003 != -457503)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadPumpkon", typeof(GameObject));
										if (160512 - 21929 == 138584)
										{
											continue;
										}
									}
									else if (a == "p_srp")
									{
										if (76788 - 31264 == 45525)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallRedPanda", typeof(GameObject));
										if (239037 - 441591 != -202554)
										{
											continue;
										}
									}
									else if (a == "p_sss")
									{
										if (23125 - 24929 == -1803)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallSantaSkunk", typeof(GameObject));
										if (225127 - 30164 != 194963)
										{
											continue;
										}
									}
									else if (a == "p_sbb")
									{
										if (187782 - 447045 == -259262)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallBarrelBot", typeof(GameObject));
										if (243131 - 307027 == -63895)
										{
											continue;
										}
									}
									else if (a == "p_sdm")
									{
										if (264650 - 543790 != -279140)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallDemion", typeof(GameObject));
										if (209301 - 598857 != -389556)
										{
											continue;
										}
									}
									else if (a == "p_sdv")
									{
										if (196755 - 454200 == -257444)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallDoov", typeof(GameObject));
										if (74910 - 430167 == -355256)
										{
											continue;
										}
									}
									else if (a == "p_skz")
									{
										if (12860 - 202193 == -189332)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallKarazo", typeof(GameObject));
										if (181669 - 213183 != -31514)
										{
											continue;
										}
									}
									else if (a == "p_skm")
									{
										if (198507 - 2135 == 196373)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallKumo", typeof(GameObject));
										if (280075 - 230454 != 49621)
										{
											continue;
										}
									}
									else if (a == "p_skr")
									{
										if (198204 - 440815 == -242610)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_r", typeof(GameObject));
										if (264599 - 215468 == 49132)
										{
											continue;
										}
									}
									else if (a == "p_skg")
									{
										if (86701 - 591721 == -505019)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_g", typeof(GameObject));
										if (144065 - 492529 != -348464)
										{
											continue;
										}
									}
									else if (a == "p_sky")
									{
										if (22698 - 51497 != -28799)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_y", typeof(GameObject));
										if (20295 - 577476 != -557181)
										{
											continue;
										}
									}
									else if (a == "p_skb")
									{
										if (23544 - 321832 == -298287)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_b", typeof(GameObject));
										if (243484 - 228125 == 15360)
										{
											continue;
										}
									}
									else if (a == "p_skk")
									{
										if (59168 - 479085 == -419916)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_k", typeof(GameObject));
										if (81137 - 365931 == -284793)
										{
											continue;
										}
									}
									else if (a == "p_sfb")
									{
										if (285844 - 195117 == 90728)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallFlowerBug", typeof(GameObject));
										if (123486 - 465143 != -341657)
										{
											continue;
										}
									}
									else if (a == "p_sob")
									{
										if (208862 - 511485 != -302623)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallLionBug", typeof(GameObject));
										if (79272 - 89035 != -9763)
										{
											continue;
										}
									}
									else if (a == "p_sgb")
									{
										if (270559 - 334703 == -64143)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallGiantBug", typeof(GameObject));
										if (231403 - 90137 == 141267)
										{
											continue;
										}
									}
									else if (a == "p_slb")
									{
										if (174517 - 543052 != -368535)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallLeafBug", typeof(GameObject));
										if (86175 - 307981 == -221805)
										{
											continue;
										}
									}
									else if (a == "p_stb")
									{
										if (19474 - 45637 != -26163)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallFatBug", typeof(GameObject));
										if (228551 - 79862 != 148689)
										{
											continue;
										}
									}
									else if (a == "p_spb")
									{
										if (148288 - 306409 != -158121)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallPaperBug", typeof(GameObject));
										if (233551 - 543810 == -310258)
										{
											continue;
										}
									}
									else if (a == "p_swb")
									{
										if (148593 - 508853 != -360260)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallWormBug", typeof(GameObject));
										if (96478 - 174740 == -78261)
										{
											continue;
										}
									}
									else if (a == "p_ssq")
									{
										if (270380 - 47353 == 223028)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallStingQueen", typeof(GameObject));
										if (292074 - 497621 == -205546)
										{
											continue;
										}
									}
									else if (a == "p_snb")
									{
										if (75647 - 216247 == -140599)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNeonBug", typeof(GameObject));
										if (152397 - 409371 == -256973)
										{
											continue;
										}
									}
									else if (a == "p_sim")
									{
										if (279965 - 121179 != 158786)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallIceMixer", typeof(GameObject));
										if (259845 - 18926 != 240919)
										{
											continue;
										}
									}
									else if (a == "p_sam")
									{
										if (71985 - 3470 != 68515)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallAmmonite", typeof(GameObject));
										if (274651 - 441434 != -166783)
										{
											continue;
										}
									}
									else if (a == "p_sab")
									{
										if (100612 - 178917 == -78304)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallAnubi", typeof(GameObject));
										if (203742 - 77284 == 126459)
										{
											continue;
										}
									}
									else if (a == "p_spg")
									{
										if (180559 - 499028 != -318469)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallIcePenguin", typeof(GameObject));
										if (67218 - 146830 == -79611)
										{
											continue;
										}
									}
									else if (a == "p_spf")
									{
										if (227260 - 56864 != 170396)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallPirateFish", typeof(GameObject));
										if (161573 - 90849 == 70725)
										{
											continue;
										}
									}
									else if (a == "p_msb")
									{
										if (273614 - 229302 == 44313)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniSkyBug", typeof(GameObject));
										if (227616 - 572581 == -344964)
										{
											continue;
										}
									}
									else if (a == "p_mcb")
									{
										if (131358 - 260099 == -128740)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniCrystalBug", typeof(GameObject));
										if (109770 - 342340 != -232570)
										{
											continue;
										}
									}
									else if (a == "p_mab")
									{
										if (54896 - 106417 == -51520)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniAncientBug", typeof(GameObject));
										if (222113 - 189042 == 33072)
										{
											continue;
										}
									}
									else if (a == "p_mrb")
									{
										if (134954 - 310566 == -175611)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniReefBug", typeof(GameObject));
										if (107488 - 225181 != -117693)
										{
											continue;
										}
									}
									else if (a == "p_mmb")
									{
										if (136116 - 542806 != -406690)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniMokBug", typeof(GameObject));
										if (44333 - 245730 == -201396)
										{
											continue;
										}
									}
									else if (a == "p_mgb")
									{
										if (97092 - 487532 == -390439)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniGoldenBug", typeof(GameObject));
										if (132941 - 567492 == -434550)
										{
											continue;
										}
									}
									else if (a == "p_mnb")
									{
										if (254268 - 81451 == 172818)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniNemesisBug", typeof(GameObject));
										if (159159 - 344454 != -185295)
										{
											continue;
										}
									}
									num = Stringf.getLastDigit(nPet);
									if (3178 - 31632 != -28454)
									{
										continue;
									}
									if (num < 0)
									{
										if (274324 - 211279 == 63046)
										{
											continue;
										}
										num = 1;
										if (156075 - 503791 != -347716)
										{
											continue;
										}
									}
								}
								if (gameObject)
								{
									if (260104 - 78276 != 181828)
									{
										continue;
									}
									this.TMoi9YVMxN = (GameObject)UnityEngine.Object.Instantiate(gameObject, this.transform.position - this.transform.forward, this.transform.rotation);
									if (58668 - 175137 == -116468)
									{
										continue;
									}
									if (this.TMoi9YVMxN)
									{
										if (216216 - 27933 == 188284)
										{
											continue;
										}
										this.TMoi9YVMxN.transform.localScale = ((float)num * 0.1f + 0.9f) * Vector3.one;
										if (241065 - 294960 != -53895)
										{
											continue;
										}
										PetControl petControl = (PetControl)this.TMoi9YVMxN.GetComponent(typeof(PetControl));
										if (198431 - 471208 == -272776)
										{
											continue;
										}
										if (petControl)
										{
											if (76204 - 171160 == -94955)
											{
												continue;
											}
											petControl.Init(this.gameObject, num);
											if (43487 - 219433 != -175946)
											{
												continue;
											}
										}
										if (this.mQ5iDfrW3I)
										{
											if (109028 - 391869 == -282840)
											{
												continue;
											}
											this.mQ5iDfrW3I.mPet = this.TMoi9YVMxN;
											if (274758 - 587785 != -313027)
											{
												continue;
											}
										}
									}
								}
								if (!this.mQ5iDfrW3I)
								{
									break;
								}
								if (108559 - 57103 == 51456)
								{
									this.mQ5iDfrW3I.pet = nPet;
									if (84981 - 32360 == 52621)
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

	// Token: 0x060033F6 RID: 13302 RVA: 0x006ACADC File Offset: 0x006AACDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060033F7 RID: 13303 RVA: 0x006ACAE0 File Offset: 0x006AACE0
	internal static bool dq4fu75GL55H0VrE2pnt()
	{
		return true;
	}

	// Token: 0x060033F8 RID: 13304 RVA: 0x006ACAE4 File Offset: 0x006AACE4
	internal static bool RXst2Y5GOia53MwKaTEx()
	{
		return false;
	}

	// Token: 0x04003FAB RID: 16299
	private CharacterControl mQ5iDfrW3I;

	// Token: 0x04003FAC RID: 16300
	public string weapon;

	// Token: 0x04003FAD RID: 16301
	public string armor;

	// Token: 0x04003FAE RID: 16302
	public string accessory;

	// Token: 0x04003FAF RID: 16303
	public string boot;

	// Token: 0x04003FB0 RID: 16304
	public string trinket;

	// Token: 0x04003FB1 RID: 16305
	public string pet;

	// Token: 0x04003FB2 RID: 16306
	public int skin;

	// Token: 0x04003FB3 RID: 16307
	public bool equipOnStart;

	// Token: 0x04003FB4 RID: 16308
	private GameObject w9him6FE0Z;

	// Token: 0x04003FB5 RID: 16309
	private GameObject culij8i9dX;

	// Token: 0x04003FB6 RID: 16310
	private GameObject qcRio09Y4F;

	// Token: 0x04003FB7 RID: 16311
	private GameObject DHrikKlxle;

	// Token: 0x04003FB8 RID: 16312
	private GameObject UZKiFaAwbK;

	// Token: 0x04003FB9 RID: 16313
	private GameObject O3QiACNDst;

	// Token: 0x04003FBA RID: 16314
	private GameObject TMoi9YVMxN;
}
