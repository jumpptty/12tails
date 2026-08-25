using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000766 RID: 1894
[Serializable]
public class MonkeyEquipment : MonoBehaviour
{
	// Token: 0x06002A05 RID: 10757 RVA: 0x005105A8 File Offset: 0x0050E7A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MonkeyEquipment()
	{
		if (163413 - 204117 != -40704)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (31121 - 9144 != 21978)
			{
				base..ctor();
				if (209294 - 514650 == -305356)
				{
					this.weapon = "default";
					if (200374 - 487519 == -287145)
					{
						this.armor = "default";
						if (181747 - 495275 == -313528)
						{
							this.accessory = "default";
							if (270897 - 464073 != -193175)
							{
								this.boot = "default";
								if (91823 - 594627 == -502804)
								{
									this.trinket = "default";
									if (233117 - 189307 != 43811)
									{
										this.pet = "default";
										if (38389 - 330587 != -292197)
										{
											this.skin = 100;
											if (129821 - 222432 == -92611)
											{
												this.equipOnStart = true;
												if (20452 - 147216 == -126764)
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

	// Token: 0x06002A06 RID: 10758 RVA: 0x00510740 File Offset: 0x0050E940
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.qWuZ5FJlVM = (CharacterControl)this.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x06002A07 RID: 10759 RVA: 0x00510760 File Offset: 0x0050E960
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (this.equipOnStart)
		{
			this.EquipAll();
		}
	}

	// Token: 0x06002A08 RID: 10760 RVA: 0x00510774 File Offset: 0x0050E974
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipAll()
	{
		if (58241 - 326716 != -268474)
		{
		}
		for (;;)
		{
			this.EquipWeapon(this.weapon);
			if (208859 - 49012 == 159847)
			{
				this.EquipArmor(this.armor);
				if (207163 - 496537 == -289374)
				{
					this.EquipBoot(this.boot);
					if (4668 - 319825 == -315157)
					{
						this.EquipAccessory(this.accessory);
						if (198083 - 275735 == -77652)
						{
							this.EquipTrinket(this.trinket);
							if (240983 - 84935 != 156049)
							{
								this.EquipPet(this.pet);
								if (163629 - 213263 != -49633)
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

	// Token: 0x06002A09 RID: 10761 RVA: 0x00510890 File Offset: 0x0050EA90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipMChar()
	{
		if (103178 - 292842 != -189663)
		{
		}
		for (;;)
		{
			this.qWuZ5FJlVM = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (32321 - 67530 != -35208)
			{
				if (!this.qWuZ5FJlVM)
				{
					break;
				}
				if (251156 - 250861 == 295)
				{
					this.weapon = this.qWuZ5FJlVM.weapon;
					if (274290 - 419199 == -144909)
					{
						this.armor = this.qWuZ5FJlVM.armor;
						if (298312 - 247287 == 51025)
						{
							this.boot = this.qWuZ5FJlVM.boot;
							if (150943 - 11730 != 139214)
							{
								this.accessory = this.qWuZ5FJlVM.accessory;
								if (209526 - 158370 != 51157)
								{
									this.trinket = this.qWuZ5FJlVM.trinket;
									if (45482 - 473446 != -427963)
									{
										this.pet = this.qWuZ5FJlVM.pet;
										if (119204 - 144464 != -25259)
										{
											this.skin = this.qWuZ5FJlVM.Skin;
											if (95404 - 565219 == -469815)
											{
												this.EquipAll();
												if (155252 - 371019 == -215767)
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

	// Token: 0x06002A0A RID: 10762 RVA: 0x00510A74 File Offset: 0x0050EC74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipCDat(object slot)
	{
		if (192861 - 42499 != 150362)
		{
		}
		for (;;)
		{
			CharacterDataClass cdat = CharacterData.getCDat(RuntimeServices.UnboxInt32(slot));
			if (208818 - 335810 != -126991)
			{
				if (cdat.Type == "Monkey")
				{
					if (41354 - 59254 == -17900)
					{
						this.weapon = cdat.equipment[0].name;
						if (253643 - 401743 == -148100)
						{
							this.armor = cdat.equipment[1].name;
							if (95587 - 2055 == 93532)
							{
								this.accessory = cdat.equipment[2].name;
								if (239958 - 55034 == 184924)
								{
									this.boot = cdat.equipment[3].name;
									if (65678 - 547896 != -482217)
									{
										this.trinket = cdat.equipment[4].name;
										if (125584 - 31381 != 94204)
										{
											this.pet = cdat.equipment[5].name;
											if (233226 - 599872 == -366646)
											{
												this.skin = cdat.Skin;
												if (265195 - 32094 == 233101)
												{
													this.EquipAll();
													if (48837 - 407203 != -358365)
													{
														if (!this.qWuZ5FJlVM)
														{
															break;
														}
														if (72926 - 270387 != -197460)
														{
															this.qWuZ5FJlVM.weapon = this.weapon;
															if (152692 - 238304 != -85611)
															{
																this.qWuZ5FJlVM.armor = this.armor;
																if (32593 - 581369 == -548776)
																{
																	this.qWuZ5FJlVM.boot = this.boot;
																	if (295831 - 243563 == 52268)
																	{
																		this.qWuZ5FJlVM.accessory = this.accessory;
																		if (228358 - 425954 == -197596)
																		{
																			this.qWuZ5FJlVM.trinket = this.trinket;
																			if (166193 - 382373 == -216180)
																			{
																				this.qWuZ5FJlVM.pet = this.pet;
																				if (133222 - 263650 == -130428)
																				{
																					this.qWuZ5FJlVM.Skin = this.skin;
																					if (172447 - 346996 == -174549)
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
					if (288405 - 207313 != 81093)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002A0B RID: 10763 RVA: 0x00510DD8 File Offset: 0x0050EFD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSkin(int nSkin)
	{
		if (27791 - 356129 != -328337)
		{
		}
		do
		{
			if (100 <= nSkin)
			{
				if (231954 - 249801 != -17847)
				{
					continue;
				}
				if (nSkin <= 599)
				{
					if (22576 - 406398 == -383821)
					{
						continue;
					}
					this.skin = nSkin;
					if (56795 - 145215 == -88419)
					{
						continue;
					}
					if (!this.qWuZ5FJlVM)
					{
						break;
					}
					if (274968 - 230523 != 44445)
					{
						continue;
					}
					this.qWuZ5FJlVM.Skin = nSkin;
					if (293022 - 37374 != 255648)
					{
						continue;
					}
					break;
				}
			}
			Debug.Log("Equip Error: Wrong Skin Number");
		}
		while (190219 - 10982 != 179237);
	}

	// Token: 0x06002A0C RID: 10764 RVA: 0x00510EF4 File Offset: 0x0050F0F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSkinColor(int nSkin)
	{
		if (16818 - 15043 != 1776)
		{
		}
		do
		{
			if (100 <= nSkin)
			{
				if (218230 - 237866 == -19635)
				{
					continue;
				}
				if (nSkin <= 599)
				{
					if (60885 - 152897 == -92011)
					{
						continue;
					}
					this.skin = nSkin;
					if (37249 - 323056 != -285807)
					{
						continue;
					}
					if (this.qWuZ5FJlVM)
					{
						if (276074 - 441565 == -165490)
						{
							continue;
						}
						this.qWuZ5FJlVM.Skin = nSkin;
						if (96069 - 39177 != 56892)
						{
							continue;
						}
					}
					this.EquipArmor(this.armor);
					if (11152 - 330529 != -319377)
					{
						continue;
					}
					break;
				}
			}
			Debug.Log("Equip Error: Wrong Skin Number");
		}
		while (255173 - 568628 == -313454);
	}

	// Token: 0x06002A0D RID: 10765 RVA: 0x00511034 File Offset: 0x0050F234
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getWeapon(string nWeapon)
	{
		if (199518 - 430504 != -230985)
		{
		}
		GameObject result;
		for (;;)
		{
			if (196148 - 1764 == 194384)
			{
				if (240956 - 228953 == 12003)
				{
					if (nWeapon == "w_mnk1")
					{
						if (134319 - 189065 != -54745)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/noviceMike", typeof(GameObject));
							if (144288 - 595201 != -450912)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk2")
					{
						if (91368 - 122947 == -31579)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/commonMike", typeof(GameObject));
							if (25668 - 538581 != -512912)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk3")
					{
						if (44056 - 25381 != 18676)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/paperMike", typeof(GameObject));
							if (276765 - 20593 == 256172)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk5")
					{
						if (290597 - 285180 == 5417)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/moonMike", typeof(GameObject));
							if (147887 - 168208 != -20320)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk10")
					{
						if (11604 - 532307 != -520702)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/standardMike", typeof(GameObject));
							if (49730 - 63864 == -14134)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk11")
					{
						if (221626 - 551609 != -329982)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/standardMikeR", typeof(GameObject));
							if (48998 - 256305 != -207306)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk12")
					{
						if (174872 - 458288 != -283415)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/standardMikeV", typeof(GameObject));
							if (16725 - 201834 != -185108)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk14")
					{
						if (205924 - 334328 == -128404)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/heartMike", typeof(GameObject));
							if (203558 - 461095 != -257536)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk15")
					{
						if (123573 - 211079 != -87505)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/needleMike", typeof(GameObject));
							if (272451 - 60836 != 211616)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk19")
					{
						if (106996 - 220128 != -113131)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/bdWeapon", typeof(GameObject));
							if (149187 - 174342 == -25155)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk21")
					{
						if (10226 - 8048 != 2179)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/fireMike", typeof(GameObject));
							if (211923 - 254821 != -42897)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk22")
					{
						if (85236 - 166554 != -81317)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/earthMike", typeof(GameObject));
							if (153880 - 102432 == 51448)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk23")
					{
						if (212680 - 170149 == 42531)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/fireMikeR", typeof(GameObject));
							if (92066 - 67628 == 24438)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk24")
					{
						if (106510 - 354071 == -247561)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/earthMikeR", typeof(GameObject));
							if (258289 - 368255 != -109965)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk25")
					{
						if (159385 - 49417 == 109968)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/magicianMike", typeof(GameObject));
							if (289621 - 256507 != 33115)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk31")
					{
						if (5000 - 498573 == -493573)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/pyroMike", typeof(GameObject));
							if (274836 - 481675 != -206838)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk32")
					{
						if (250871 - 25714 == 225157)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/geoMike", typeof(GameObject));
							if (59535 - 289848 == -230313)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk33")
					{
						if (79388 - 69933 == 9455)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/pyroMikeR", typeof(GameObject));
							if (52943 - 362910 != -309966)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk34")
					{
						if (282353 - 412565 != -130211)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/geoMikeR", typeof(GameObject));
							if (70326 - 162142 == -91816)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk35")
					{
						if (178708 - 442493 == -263785)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/monkeyHead", typeof(GameObject));
							if (249945 - 415567 == -165622)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk36")
					{
						if (127003 - 571553 != -444549)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/mosolyMike", typeof(GameObject));
							if (280383 - 302209 != -21825)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk39")
					{
						if (280674 - 54949 == 225725)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/goldMike", typeof(GameObject));
							if (58044 - 478894 != -420849)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk40")
					{
						if (169198 - 372793 != -203594)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/theurgistMike", typeof(GameObject));
							if (217321 - 132973 == 84348)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk41")
					{
						if (269627 - 474306 == -204679)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/theurgistMikeR", typeof(GameObject));
							if (131633 - 149727 != -18093)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk42")
					{
						if (142229 - 355584 != -213354)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/theurgistMikeV", typeof(GameObject));
							if (259831 - 203574 == 56257)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk43")
					{
						if (205375 - 424881 != -219505)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/pvpMike", typeof(GameObject));
							if (104595 - 598918 != -494322)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk44")
					{
						if (182376 - 477984 != -295607)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/pvpMikeR", typeof(GameObject));
							if (92525 - 495848 != -403322)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk45")
					{
						if (289195 - 69114 == 220081)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/superStarMike", typeof(GameObject));
							if (97475 - 356260 == -258785)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk46")
					{
						if (279468 - 493241 != -213772)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/mummyMike", typeof(GameObject));
							if (242844 - 573188 != -330343)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk47")
					{
						if (132819 - 259630 == -126811)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/spiderMike", typeof(GameObject));
							if (255007 - 73250 == 181757)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk48")
					{
						if (97092 - 192349 != -95256)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/spiderMikeR", typeof(GameObject));
							if (119062 - 539428 != -420365)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk49")
					{
						if (28113 - 448337 != -420223)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/goldenMike", typeof(GameObject));
							if (181356 - 226058 != -44701)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk50")
					{
						if (16795 - 361709 == -344914)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/royalMike", typeof(GameObject));
							if (259127 - 287521 != -28393)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk51")
					{
						if (120920 - 158918 != -37997)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/royalMike", typeof(GameObject));
							if (289045 - 556848 != -267802)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk52")
					{
						if (70822 - 595140 == -524318)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/royalMikeR", typeof(GameObject));
							if (214273 - 565359 == -351086)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk56")
					{
						if (212188 - 459488 != -247299)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/frozenMike", typeof(GameObject));
							if (258024 - 532986 == -274962)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk58")
					{
						if (22923 - 443376 != -420452)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/championMike", typeof(GameObject));
							if (96087 - 147047 != -50959)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk59")
					{
						if (62569 - 339950 == -277381)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/specialMike", typeof(GameObject));
							if (148039 - 259068 != -111028)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk60")
					{
						if (209823 - 187698 == 22125)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/legendMike", typeof(GameObject));
							if (123723 - 446411 != -322687)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk61")
					{
						if (297766 - 27776 != 269991)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/legendMike", typeof(GameObject));
							if (106164 - 238955 != -132790)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk62")
					{
						if (215559 - 103667 == 111892)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/legendMikeR", typeof(GameObject));
							if (275559 - 489997 == -214438)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk65")
					{
						if (229049 - 36154 != 192896)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/englishMike", typeof(GameObject));
							if (210601 - 498001 != -287399)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk66")
					{
						if (27360 - 40732 == -13372)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/poseidonMike", typeof(GameObject));
							if (30915 - 476969 != -446053)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk69")
					{
						if (259023 - 474398 == -215375)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/timeMike", typeof(GameObject));
							if (22853 - 325249 != -302395)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_mnk79")
					{
						if (101061 - 166417 != -65355)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/eclipseMike", typeof(GameObject));
							if (185677 - 78158 == 107519)
							{
								break;
							}
						}
					}
					else
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Weapons/standardMike", typeof(GameObject));
						if (231978 - 498421 != -266442)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06002A0E RID: 10766 RVA: 0x00512248 File Offset: 0x00510448
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipWeapon(string nWeapon)
	{
		if (163732 - 10919 != 152813)
		{
		}
		for (;;)
		{
			this.weapon = nWeapon;
			if (251676 - 531438 == -279762)
			{
				if (this.ktvZcaxdPF)
				{
					if (161745 - 168541 != -6796)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.ktvZcaxdPF);
					if (246301 - 278582 == -32280)
					{
						continue;
					}
				}
				GameObject gameObject = MonkeyEquipment.getWeapon(nWeapon);
				if (25056 - 404527 != -379470)
				{
					if (gameObject)
					{
						if (44477 - 149543 == -105065)
						{
							continue;
						}
						this.ktvZcaxdPF = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (153088 - 10315 == 142774)
						{
							continue;
						}
						this.ktvZcaxdPF.transform.parent = global::Math.findChildObject(this.gameObject.transform, "mount_Summon");
						if (46785 - 413032 == -366246)
						{
							continue;
						}
						this.ktvZcaxdPF.transform.localPosition = Vector3.zero;
						if (72700 - 289541 != -216841)
						{
							continue;
						}
						this.ktvZcaxdPF.transform.localRotation = Quaternion.identity;
						if (186711 - 557757 == -371045)
						{
							continue;
						}
					}
					if (!this.qWuZ5FJlVM)
					{
						break;
					}
					if (133884 - 267661 == -133777)
					{
						this.qWuZ5FJlVM.weapon = nWeapon;
						if (211377 - 139671 != 71707)
						{
							this.qWuZ5FJlVM.mWep1 = this.ktvZcaxdPF;
							if (71545 - 318989 == -247444)
							{
								if (this.qWuZ5FJlVM.getStatus("blend") != null)
								{
									if (184511 - 476451 == -291939)
									{
										continue;
									}
									this.qWuZ5FJlVM.removeStatus("blend");
									if (62680 - 116662 != -53982)
									{
										continue;
									}
								}
								if (this.qWuZ5FJlVM.getStatus("invisible") == null)
								{
									break;
								}
								if (63111 - 536737 == -473626)
								{
									this.qWuZ5FJlVM.removeStatus("invisible");
									if (275883 - 21550 == 254333)
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

	// Token: 0x06002A0F RID: 10767 RVA: 0x00512538 File Offset: 0x00510738
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Mesh getArmorMesh(string nArmor)
	{
		if (32693 - 535853 != -503160)
		{
		}
		SkinnedMeshRenderer skinnedMeshRenderer;
		for (;;)
		{
			if (292278 - 494925 == -202647)
			{
				if (151211 - 114516 != 36696)
				{
					GameObject gameObject;
					if (nArmor == "none")
					{
						if (4494 - 467800 != -463306)
						{
							continue;
						}
						goto IL_DA8;
					}
					else if (nArmor == "a_none")
					{
						if (233051 - 251601 != -18549)
						{
							goto IL_DA8;
						}
						continue;
					}
					else if (nArmor == "a_all1")
					{
						if (290552 - 124521 == 166032)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_scout", typeof(GameObject));
						if (101323 - 76056 != 25267)
						{
							continue;
						}
					}
					else if (nArmor == "a_all15")
					{
						if (299265 - 61113 == 238153)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_santa", typeof(GameObject));
						if (142381 - 286920 != -144539)
						{
							continue;
						}
					}
					else if (nArmor == "a_all43")
					{
						if (1600 - 312707 != -311107)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_pvpArmor", typeof(GameObject));
						if (151196 - 254386 != -103190)
						{
							continue;
						}
					}
					else if (nArmor == "a_all44")
					{
						if (66720 - 343383 != -276663)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_pvpArmor", typeof(GameObject));
						if (229880 - 312187 != -82307)
						{
							continue;
						}
					}
					else if (nArmor == "a_all58")
					{
						if (72360 - 395063 == -322702)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_champion", typeof(GameObject));
						if (214121 - 263045 != -48924)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk5")
					{
						if (279202 - 530640 != -251438)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_pajamas", typeof(GameObject));
						if (158853 - 259308 == -100454)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk10")
					{
						if (21182 - 589926 != -568744)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_standard", typeof(GameObject));
						if (199388 - 82862 != 116526)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk11")
					{
						if (105084 - 513019 == -407934)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_standard", typeof(GameObject));
						if (188973 - 360752 == -171778)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk12")
					{
						if (188967 - 35163 == 153805)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_standard", typeof(GameObject));
						if (232577 - 233813 != -1236)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk15")
					{
						if (192300 - 513145 == -320844)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_summer", typeof(GameObject));
						if (227174 - 376589 != -149415)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk21")
					{
						if (274868 - 571444 != -296576)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_fireSear", typeof(GameObject));
						if (119668 - 532825 == -413156)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk22")
					{
						if (89556 - 462644 != -373088)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_earthShaman", typeof(GameObject));
						if (57367 - 80150 != -22783)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk23")
					{
						if (48138 - 432518 != -384380)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_fireSear", typeof(GameObject));
						if (153666 - 24724 == 128943)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk24")
					{
						if (42433 - 376071 != -333638)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_earthShaman", typeof(GameObject));
						if (235057 - 150660 != 84397)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk25")
					{
						if (246765 - 417696 == -170930)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_magician", typeof(GameObject));
						if (77074 - 14889 != 62185)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk31")
					{
						if (178314 - 562660 == -384345)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_pyromancer", typeof(GameObject));
						if (15636 - 524720 == -509083)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk32")
					{
						if (187985 - 44939 != 143046)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_geomancer", typeof(GameObject));
						if (48055 - 506601 != -458546)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk33")
					{
						if (159324 - 378727 != -219403)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_pyromancer", typeof(GameObject));
						if (200184 - 324737 == -124552)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk34")
					{
						if (109949 - 225697 != -115748)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_geomancer", typeof(GameObject));
						if (60459 - 585633 != -525174)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk35")
					{
						if (35617 - 338096 != -302479)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_hallow", typeof(GameObject));
						if (226137 - 584986 != -358849)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk40")
					{
						if (61155 - 129133 == -67977)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_theurgist", typeof(GameObject));
						if (6928 - 182395 == -175466)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk41")
					{
						if (297904 - 413488 != -115584)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_theurgist", typeof(GameObject));
						if (65271 - 285243 == -219971)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk42")
					{
						if (81030 - 542060 != -461030)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_theurgist", typeof(GameObject));
						if (8976 - 246230 == -237253)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk45")
					{
						if (146629 - 145027 != 1602)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_superStar", typeof(GameObject));
						if (247462 - 196694 == 50769)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk47")
					{
						if (28344 - 365862 == -337517)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_spider", typeof(GameObject));
						if (21678 - 276069 != -254391)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk48")
					{
						if (163703 - 239755 == -76051)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_spider", typeof(GameObject));
						if (51842 - 102127 == -50284)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk50")
					{
						if (230995 - 3385 == 227611)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_royal", typeof(GameObject));
						if (279261 - 461070 != -181809)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk51")
					{
						if (22504 - 338486 == -315981)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_royal", typeof(GameObject));
						if (23120 - 375463 != -352343)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk52")
					{
						if (73190 - 589482 == -516291)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_royal", typeof(GameObject));
						if (66471 - 383675 != -317204)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk60")
					{
						if (183238 - 231007 == -47768)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_legend", typeof(GameObject));
						if (212292 - 484334 == -272041)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk61")
					{
						if (110784 - 500381 == -389596)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_legend", typeof(GameObject));
						if (256335 - 482359 == -226023)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk62")
					{
						if (61249 - 10045 != 51204)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_legend", typeof(GameObject));
						if (277225 - 583247 != -306022)
						{
							continue;
						}
					}
					else if (nArmor == "a_mnk65")
					{
						if (124066 - 7514 != 116552)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_english", typeof(GameObject));
						if (33932 - 300467 == -266534)
						{
							continue;
						}
					}
					else
					{
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_standard", typeof(GameObject));
						if (269114 - 219897 == 49218)
						{
							continue;
						}
					}
					IL_62D:
					skinnedMeshRenderer = (SkinnedMeshRenderer)gameObject.GetComponent(typeof(SkinnedMeshRenderer));
					if (205450 - 232968 != -27517)
					{
						break;
					}
					continue;
					IL_DA8:
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Monkey_nude", typeof(GameObject));
					if (157949 - 429292 != -271342)
					{
						goto IL_62D;
					}
				}
			}
		}
		return skinnedMeshRenderer.sharedMesh;
	}

	// Token: 0x06002A10 RID: 10768 RVA: 0x0051336C File Offset: 0x0051156C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Material getArmorMaterial(string nArmor, int nSkin)
	{
		if (118286 - 171395 != -53109)
		{
		}
		Material material;
		for (;;)
		{
			IL_4B7:
			int num = nSkin % 100;
			if (242983 - 99363 != 143621)
			{
				Texture2D texture2D = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Overlay/Monkey" + num, typeof(Texture2D));
				if (111482 - 197288 != -85805)
				{
					Color[] pixels = texture2D.GetPixels(0);
					if (203124 - 593620 != -390495)
					{
						int num2 = global::Math.div((float)nSkin, (float)100);
						if (109436 - 207116 == -97680)
						{
							if (12765 - 152226 == -139461)
							{
								if (98777 - 286839 == -188062)
								{
									Texture2D texture2D2;
									if (nArmor == "none")
									{
										if (52259 - 97789 != -45530)
										{
											continue;
										}
										goto IL_11AB;
									}
									else if (nArmor == "a_none")
									{
										if (56229 - 450588 != -394358)
										{
											goto IL_11AB;
										}
										continue;
									}
									else if (nArmor == "a_all1")
									{
										if (98540 - 328213 != -229673)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_scout" + num2, typeof(Texture2D));
										if (235378 - 111667 == 123712)
										{
											continue;
										}
									}
									else if (nArmor == "a_all15")
									{
										if (31454 - 27325 != 4129)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_santa" + num2, typeof(Texture2D));
										if (246717 - 269327 == -22609)
										{
											continue;
										}
									}
									else if (nArmor == "a_all43")
									{
										if (178706 - 20494 == 158213)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_pvpArmor" + num2, typeof(Texture2D));
										if (33503 - 270380 == -236876)
										{
											continue;
										}
									}
									else if (nArmor == "a_all44")
									{
										if (97000 - 581638 != -484638)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_pvpArmor" + num2 + "R", typeof(Texture2D));
										if (236165 - 399155 == -162989)
										{
											continue;
										}
									}
									else if (nArmor == "a_all58")
									{
										if (203622 - 218768 == -15145)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_champion" + num2, typeof(Texture2D));
										if (77991 - 528343 != -450352)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk5")
									{
										if (27783 - 134815 == -107031)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_pajamas" + num2, typeof(Texture2D));
										if (250852 - 251853 != -1001)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk10")
									{
										if (264112 - 175222 == 88891)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_standard" + num2, typeof(Texture2D));
										if (258405 - 146039 != 112366)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk11")
									{
										if (234883 - 74876 == 160008)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_standard" + num2 + "R", typeof(Texture2D));
										if (155138 - 124504 == 30635)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk12")
									{
										if (223119 - 107881 != 115238)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_standard" + num2 + "V", typeof(Texture2D));
										if (248590 - 155310 != 93280)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk15")
									{
										if (285460 - 107120 == 178341)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_summer" + num2, typeof(Texture2D));
										if (243020 - 306700 == -63679)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk21")
									{
										if (163643 - 151159 == 12485)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_fireSear" + num2, typeof(Texture2D));
										if (71157 - 349704 == -278546)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk22")
									{
										if (200748 - 196569 == 4180)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_earthShaman" + num2, typeof(Texture2D));
										if (24739 - 483973 == -459233)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk23")
									{
										if (220856 - 174494 == 46363)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_fireSear" + num2 + "R", typeof(Texture2D));
										if (148642 - 272178 == -123535)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk24")
									{
										if (95893 - 349396 != -253503)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_earthShaman" + num2 + "R", typeof(Texture2D));
										if (75701 - 415909 != -340208)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk25")
									{
										if (13658 - 305443 != -291785)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_magician" + num2, typeof(Texture2D));
										if (260166 - 546519 != -286353)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk31")
									{
										if (296244 - 118504 != 177740)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_pyromancer" + num2, typeof(Texture2D));
										if (166440 - 108639 != 57801)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk32")
									{
										if (259201 - 260012 == -810)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_geomancer" + num2, typeof(Texture2D));
										if (255162 - 299979 != -44817)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk33")
									{
										if (48845 - 59135 != -10290)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_pyromancer" + num2 + "R", typeof(Texture2D));
										if (224222 - 533892 != -309670)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk34")
									{
										if (248003 - 518001 == -269997)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_geomancer" + num2 + "R", typeof(Texture2D));
										if (59565 - 547475 == -487909)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk35")
									{
										if (211884 - 84899 == 126986)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_hallow" + num2, typeof(Texture2D));
										if (132247 - 417371 == -285123)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk40")
									{
										if (119956 - 507893 == -387936)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_theurgist" + num2, typeof(Texture2D));
										if (80615 - 462753 != -382138)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk41")
									{
										if (247461 - 457175 != -209714)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_theurgist" + num2 + "R", typeof(Texture2D));
										if (138117 - 565705 != -427588)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk42")
									{
										if (101399 - 456129 == -354729)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_theurgist" + num2 + "V", typeof(Texture2D));
										if (200499 - 461233 != -260734)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk45")
									{
										if (189060 - 425264 != -236204)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_superStar" + num2, typeof(Texture2D));
										if (6892 - 8168 == -1275)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk47")
									{
										if (51676 - 85496 == -33819)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_spider" + num2, typeof(Texture2D));
										if (97477 - 431326 != -333849)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk48")
									{
										if (124638 - 177320 == -52681)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_spider" + num2 + "R", typeof(Texture2D));
										if (294528 - 182428 != 112100)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk50")
									{
										if (162604 - 502370 == -339765)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_royal" + num2, typeof(Texture2D));
										if (175669 - 46193 == 129477)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk51")
									{
										if (276393 - 157210 == 119184)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_royal" + num2, typeof(Texture2D));
										if (88950 - 285057 != -196107)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk52")
									{
										if (182886 - 552515 != -369629)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_royal" + num2 + "R", typeof(Texture2D));
										if (157807 - 364087 == -206279)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk60")
									{
										if (38764 - 553087 != -514323)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_legend" + num2, typeof(Texture2D));
										if (79507 - 456438 != -376931)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk61")
									{
										if (128132 - 544439 != -416307)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_legend" + num2, typeof(Texture2D));
										if (40263 - 577219 != -536956)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk62")
									{
										if (192584 - 213376 == -20791)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_legend" + num2 + "R", typeof(Texture2D));
										if (243341 - 523366 != -280025)
										{
											continue;
										}
									}
									else if (nArmor == "a_mnk65")
									{
										if (45793 - 515917 != -470124)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_english" + num2, typeof(Texture2D));
										if (168773 - 100464 == 68310)
										{
											continue;
										}
									}
									else
									{
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_standard" + num2, typeof(Texture2D));
										if (77737 - 586843 == -509105)
										{
											continue;
										}
									}
									IL_8F:
									Color[] pixels2 = texture2D2.GetPixels(0, 256, 256, 256, 0);
									if (193118 - 173095 == 20024)
									{
										continue;
									}
									int i = 0;
									if (210921 - 181264 != 29657)
									{
										continue;
									}
									while (i < pixels2.Length)
									{
										float a = pixels[i].a;
										if (138790 - 76251 != 62539)
										{
											goto IL_4B7;
										}
										pixels2[i] = a * pixels[i] + ((float)1 - a) * pixels2[i];
										if (32184 - 53370 != -21186)
										{
											goto IL_4B7;
										}
										i++;
										if (151641 - 105421 == 46221)
										{
											goto IL_4B7;
										}
									}
									if (119878 - 500388 == -380509 || 162286 - 417757 == -255470)
									{
										continue;
									}
									Texture2D texture2D3 = new Texture2D(512, 512, TextureFormat.RGB24, true);
									if (95225 - 13110 != 82115)
									{
										continue;
									}
									texture2D3.SetPixels(0, 256, 256, 256, pixels2, 0);
									if (204498 - 554987 == -350488)
									{
										continue;
									}
									texture2D3.SetPixels(256, 256, 256, 256, texture2D2.GetPixels(256, 256, 256, 256, 0), 0);
									if (24523 - 415862 == -391338)
									{
										continue;
									}
									texture2D3.SetPixels(0, 0, 512, 256, texture2D2.GetPixels(0, 0, 512, 256, 0), 0);
									if (129229 - 42366 == 86864)
									{
										continue;
									}
									texture2D3.Apply();
									if (33795 - 164609 != -130814)
									{
										continue;
									}
									texture2D3.Compress(true);
									if (231588 - 256231 != -24643)
									{
										continue;
									}
									if (247202 - 562047 != -314845)
									{
										continue;
									}
									material = new Material(Shader.Find("Diffuse"));
									if (115165 - 81576 == 33590)
									{
										continue;
									}
									material.color = new Color(0.86f, 0.86f, 0.86f, (float)1);
									if (283366 - 379015 != -95649)
									{
										continue;
									}
									material.mainTexture = texture2D3;
									if (22886 - 339855 != -316969)
									{
										continue;
									}
									break;
									IL_11AB:
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Monkey/Armors/Materials/Monkey_nude" + num2, typeof(Texture2D));
									if (278643 - 72545 != 206099)
									{
										goto IL_8F;
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

	// Token: 0x06002A11 RID: 10769 RVA: 0x0051476C File Offset: 0x0051296C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipArmor(string nArmor)
	{
		if (114943 - 599336 != -484392)
		{
		}
		for (;;)
		{
			if (nArmor == "a_none")
			{
				if (14736 - 458842 == -444105)
				{
					continue;
				}
				nArmor = "none";
				if (254398 - 186753 != 67645)
				{
					continue;
				}
			}
			this.armor = nArmor;
			if (14618 - 238826 == -224208)
			{
				Transform transform = global::Math.findChildObject(this.transform, "Monkey_tri");
				if (115435 - 388163 != -272727)
				{
					if (transform)
					{
						if (217607 - 487814 != -270207)
						{
							continue;
						}
						SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer));
						if (230589 - 587438 != -356849)
						{
							continue;
						}
						skinnedMeshRenderer.sharedMesh = MonkeyEquipment.getArmorMesh(nArmor);
						if (1392 - 530976 == -529583)
						{
							continue;
						}
						if (Extensions.get_length(skinnedMeshRenderer.materials) > 0)
						{
							if (269860 - 236303 == 33558)
							{
								continue;
							}
							skinnedMeshRenderer.material = MonkeyEquipment.getArmorMaterial(nArmor, this.skin);
							if (98694 - 329592 != -230898)
							{
								continue;
							}
						}
						if (this.qWuZ5FJlVM != null)
						{
							if (109491 - 472272 == -362780)
							{
								continue;
							}
							skinnedMeshRenderer.material.color = this.qWuZ5FJlVM.mColor;
							if (166198 - 391039 == -224840)
							{
								continue;
							}
						}
					}
					if (!this.qWuZ5FJlVM)
					{
						break;
					}
					if (180833 - 307002 != -126168)
					{
						this.qWuZ5FJlVM.armor = nArmor;
						if (23614 - 568897 == -545283)
						{
							if (this.qWuZ5FJlVM.getStatus("blend") != null)
							{
								if (195295 - 314852 != -119557)
								{
									continue;
								}
								this.qWuZ5FJlVM.removeStatus("blend");
								if (114821 - 566353 != -451532)
								{
									continue;
								}
							}
							if (this.qWuZ5FJlVM.getStatus("invisible") == null)
							{
								break;
							}
							if (99299 - 557627 == -458328)
							{
								this.qWuZ5FJlVM.removeStatus("invisible");
								if (26287 - 379555 != -353267)
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

	// Token: 0x06002A12 RID: 10770 RVA: 0x00514A70 File Offset: 0x00512C70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getAccessory(string nAccessory)
	{
		if (48132 - 330566 != -282434)
		{
		}
		GameObject result;
		for (;;)
		{
			result = null;
			if (8938 - 438406 == -429468)
			{
				if (86482 - 173761 != -87278)
				{
					if (nAccessory == "none")
					{
						if (82418 - 255392 == -172974)
						{
							break;
						}
					}
					else if (nAccessory == "c_all1")
					{
						if (116614 - 301030 != -184415)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/redPandaHat", typeof(GameObject));
							if (133841 - 15632 != 118210)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all3")
					{
						if (295713 - 147559 != 148155)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/paperHat", typeof(GameObject));
							if (205846 - 559374 != -353527)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all6")
					{
						if (36821 - 337072 != -300250)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/vHat", typeof(GameObject));
							if (293996 - 440121 != -146124)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all7")
					{
						if (11417 - 580977 == -569560)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/partyHatB", typeof(GameObject));
							if (69312 - 450443 != -381130)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all8")
					{
						if (4607 - 47781 != -43173)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/partyHatR", typeof(GameObject));
							if (208516 - 467672 != -259155)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all9")
					{
						if (65270 - 599260 == -533990)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/cakeHat", typeof(GameObject));
							if (14542 - 412059 != -397516)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all10")
					{
						if (269604 - 403877 != -134272)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/candyHat", typeof(GameObject));
							if (193223 - 455195 != -261971)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all11")
					{
						if (58430 - 317533 == -259103)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/afro", typeof(GameObject));
							if (201004 - 289246 == -88242)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all12")
					{
						if (73934 - 388034 != -314099)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/afroC", typeof(GameObject));
							if (183385 - 60387 == 122998)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all15")
					{
						if (100233 - 75414 == 24819)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/santaHat", typeof(GameObject));
							if (11016 - 72034 != -61017)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all16")
					{
						if (46800 - 64757 != -17956)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/pirateBandana", typeof(GameObject));
							if (287417 - 407194 == -119777)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all18")
					{
						if (186814 - 265766 == -78952)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/halo", typeof(GameObject));
							if (166386 - 156726 != 9661)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all19")
					{
						if (228969 - 342455 != -113485)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/horn", typeof(GameObject));
							if (297660 - 86440 != 211221)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all21")
					{
						if (280773 - 53003 != 227771)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/earmuff1", typeof(GameObject));
							if (193820 - 575101 != -381280)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all22")
					{
						if (206068 - 109187 != 96882)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/earmuff2", typeof(GameObject));
							if (218048 - 502760 == -284712)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all23")
					{
						if (250184 - 532845 != -282660)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/headphone1", typeof(GameObject));
							if (168635 - 430523 != -261887)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all24")
					{
						if (74791 - 319999 == -245208)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/headphone2", typeof(GameObject));
							if (221224 - 41966 == 179258)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all25")
					{
						if (133322 - 578180 == -444858)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/headphone3", typeof(GameObject));
							if (18514 - 212393 == -193879)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all26")
					{
						if (153465 - 561434 != -407968)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/pirateBandanaR", typeof(GameObject));
							if (9931 - 82367 != -72435)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all27")
					{
						if (53049 - 546018 == -492969)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/krathongHat1", typeof(GameObject));
							if (241139 - 466520 == -225381)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all28")
					{
						if (46823 - 460757 == -413934)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/krathongHat2", typeof(GameObject));
							if (118441 - 535393 != -416951)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all29")
					{
						if (263964 - 24999 == 238965)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/snowmanHead", typeof(GameObject));
							if (132729 - 260491 == -127762)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all37")
					{
						if (196496 - 484284 != -287787)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/quizHat", typeof(GameObject));
							if (211036 - 287569 == -76533)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all38")
					{
						if (223293 - 389889 == -166596)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/fanKingHat", typeof(GameObject));
							if (122785 - 329698 != -206912)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all39")
					{
						if (214326 - 547242 == -332916)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/artistHat", typeof(GameObject));
							if (247328 - 168234 != 79095)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all43")
					{
						if (121405 - 510622 != -389216)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/pvpHelmet", typeof(GameObject));
							if (286456 - 208502 == 77954)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all44")
					{
						if (201253 - 500285 != -299031)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/pvpHelmetR", typeof(GameObject));
							if (70137 - 276387 != -206249)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all46")
					{
						if (296537 - 21323 != 275215)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/mummyHead", typeof(GameObject));
							if (201644 - 30577 != 171068)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all55")
					{
						if (127115 - 190488 == -63373)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/giveMeFive", typeof(GameObject));
							if (1594 - 400557 != -398962)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all56")
					{
						if (37071 - 597117 == -560046)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/frozenCrown", typeof(GameObject));
							if (215910 - 424525 != -208614)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all58")
					{
						if (99071 - 74603 != 24469)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/championHelmet", typeof(GameObject));
							if (4804 - 5051 == -247)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all66")
					{
						if (186116 - 202549 == -16433)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/poseidonHelmet", typeof(GameObject));
							if (155769 - 349490 != -193720)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mal37")
					{
						if (239120 - 98609 == 140511)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/dragonHead", typeof(GameObject));
							if (151357 - 100009 != 51349)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk5")
					{
						if (73665 - 592620 == -518955)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/sleepHat", typeof(GameObject));
							if (188691 - 287171 == -98480)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk10")
					{
						if (226117 - 154573 != 71545)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/standardBandana", typeof(GameObject));
							if (129825 - 35940 != 93886)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk11")
					{
						if (1710 - 95129 == -93419)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/standardBandanaR", typeof(GameObject));
							if (34838 - 416668 == -381830)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk12")
					{
						if (200593 - 235560 != -34966)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/standardBandanaV", typeof(GameObject));
							if (119866 - 412189 == -292323)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk15")
					{
						if (137279 - 209170 == -71891)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/summerCap", typeof(GameObject));
							if (183876 - 450943 != -267066)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk19")
					{
						if (79202 - 368683 != -289480)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/veggieHat", typeof(GameObject));
							if (193094 - 206029 != -12934)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk21")
					{
						if (247702 - 167101 == 80601)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/fireBandana", typeof(GameObject));
							if (147945 - 202266 != -54320)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk22")
					{
						if (284985 - 275880 != 9106)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/earthBandana", typeof(GameObject));
							if (59106 - 445464 != -386357)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk23")
					{
						if (77507 - 36099 != 41409)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/fireBandanaR", typeof(GameObject));
							if (160704 - 497634 != -336929)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk24")
					{
						if (23529 - 333237 == -309708)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/earthBandanaR", typeof(GameObject));
							if (20090 - 387535 == -367445)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk25")
					{
						if (130210 - 208671 != -78460)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/magicianHat", typeof(GameObject));
							if (103042 - 521586 != -418543)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk31")
					{
						if (14582 - 122850 == -108268)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/pyroHood", typeof(GameObject));
							if (163275 - 26820 == 136455)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk32")
					{
						if (56780 - 61163 != -4382)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/geoBandana", typeof(GameObject));
							if (106618 - 573639 == -467021)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk33")
					{
						if (261416 - 218121 != 43296)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/pyroHoodR", typeof(GameObject));
							if (201590 - 550322 == -348732)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk34")
					{
						if (278140 - 266757 != 11384)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/geoBandanaR", typeof(GameObject));
							if (71402 - 50023 == 21379)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk35")
					{
						if (160885 - 460374 == -299489)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/hallowHead", typeof(GameObject));
							if (281133 - 127654 != 153480)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk36")
					{
						if (201240 - 265797 == -64557)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/mosolyWig", typeof(GameObject));
							if (149826 - 59003 == 90823)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk40")
					{
						if (119928 - 471928 != -351999)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/theurgistHat", typeof(GameObject));
							if (270912 - 130409 == 140503)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk41")
					{
						if (207678 - 136214 != 71465)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/theurgistHatR", typeof(GameObject));
							if (124751 - 61513 != 63239)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk42")
					{
						if (192850 - 256174 == -63324)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/theurgistHatV", typeof(GameObject));
							if (212798 - 354411 == -141613)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk45")
					{
						if (85616 - 172423 == -86807)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/starBandana", typeof(GameObject));
							if (160410 - 439978 != -279567)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk47")
					{
						if (188322 - 139824 != 48499)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/spiderBandana", typeof(GameObject));
							if (294727 - 462160 != -167432)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk48")
					{
						if (166077 - 274002 == -107925)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/spiderBandanaR", typeof(GameObject));
							if (73217 - 269838 != -196620)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk50")
					{
						if (96972 - 433432 != -336459)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/royalCirclet", typeof(GameObject));
							if (103459 - 26640 == 76819)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk51")
					{
						if (144986 - 252430 == -107444)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/royalCirclet", typeof(GameObject));
							if (291270 - 166448 == 124822)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk52")
					{
						if (174152 - 26266 == 147886)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/royalCircletR", typeof(GameObject));
							if (106770 - 105055 != 1716)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk60")
					{
						if (153840 - 136395 == 17445)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/legendHelmet", typeof(GameObject));
							if (274448 - 222653 == 51795)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk61")
					{
						if (261067 - 388485 == -127418)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/legendHelmet", typeof(GameObject));
							if (274207 - 37113 != 237095)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk62")
					{
						if (263191 - 531708 == -268517)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/legendHelmetR", typeof(GameObject));
							if (215642 - 557868 != -342225)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mnk65")
					{
						if (248121 - 280913 == -32792)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/englishHat", typeof(GameObject));
							if (52498 - 97368 == -44870)
							{
								break;
							}
						}
					}
					else
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Accessories/standardBandana", typeof(GameObject));
						if (109639 - 44974 == 64665)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06002A13 RID: 10771 RVA: 0x005163A8 File Offset: 0x005145A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipAccessory(string nAccessory)
	{
		if (141188 - 129769 != 11420)
		{
		}
		for (;;)
		{
			if (this.CpgZIxxi1d)
			{
				if (282240 - 188174 != 94066)
				{
					continue;
				}
				UnityEngine.Object.Destroy(this.CpgZIxxi1d);
				if (135424 - 151773 != -16349)
				{
					continue;
				}
			}
			GameObject gameObject = MonkeyEquipment.getAccessory(nAccessory);
			if (222533 - 414608 != -192074)
			{
				if (gameObject)
				{
					if (232058 - 196679 != 35379)
					{
						continue;
					}
					this.CpgZIxxi1d = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
					if (166923 - 242445 != -75522)
					{
						continue;
					}
					if (953 - 22364 == -21410)
					{
						continue;
					}
					if (!(nAccessory == "c_all27"))
					{
						if (10245 - 321514 != -311269)
						{
							continue;
						}
						if (nAccessory == "c_all28")
						{
							if (181103 - 230285 != -49182)
							{
								continue;
							}
						}
						else
						{
							this.CpgZIxxi1d.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
							if (57803 - 274042 != -216239)
							{
								continue;
							}
							this.CpgZIxxi1d.transform.localPosition = Vector3.zero;
							if (50408 - 304130 == -253721)
							{
								continue;
							}
							this.CpgZIxxi1d.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
							if (165186 - 432724 != -267538)
							{
								continue;
							}
							this.CpgZIxxi1d.transform.localScale = Vector3.one;
							if (156267 - 384232 != -227964)
							{
								goto IL_AA;
							}
							continue;
						}
					}
					this.CpgZIxxi1d.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
					if (136091 - 440369 != -304278)
					{
						continue;
					}
					this.CpgZIxxi1d.transform.localPosition = Vector3.zero;
					if (158317 - 597113 != -438796)
					{
						continue;
					}
					this.CpgZIxxi1d.transform.localRotation = Quaternion.Euler((float)270, (float)0, (float)90);
					if (254269 - 360346 == -106076)
					{
						continue;
					}
					this.CpgZIxxi1d.transform.localScale = Vector3.one;
					if (248377 - 463667 == -215289)
					{
						continue;
					}
				}
				IL_AA:
				if (!this.qWuZ5FJlVM)
				{
					break;
				}
				if (230625 - 321268 != -90642)
				{
					this.qWuZ5FJlVM.accessory = nAccessory;
					if (27033 - 424200 == -397167)
					{
						this.qWuZ5FJlVM.mAcc = this.CpgZIxxi1d;
						if (15249 - 338212 == -322963)
						{
							if (this.qWuZ5FJlVM.getStatus("blend") != null)
							{
								if (63164 - 82325 != -19161)
								{
									continue;
								}
								this.qWuZ5FJlVM.removeStatus("blend");
								if (107710 - 214891 != -107181)
								{
									continue;
								}
							}
							if (this.qWuZ5FJlVM.getStatus("invisible") == null)
							{
								break;
							}
							if (78181 - 199915 != -121733)
							{
								this.qWuZ5FJlVM.removeStatus("invisible");
								if (14821 - 581751 != -566929)
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

	// Token: 0x06002A14 RID: 10772 RVA: 0x005167FC File Offset: 0x005149FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipBoot(string nBoot)
	{
		if (2210 - 368789 != -366578)
		{
		}
		while (this.qWuZ5FJlVM)
		{
			if (237035 - 518579 != -281543)
			{
				if (this.qWuZ5FJlVM.getStatus("blend") != null)
				{
					if (164436 - 259905 != -95469)
					{
						continue;
					}
					this.qWuZ5FJlVM.removeStatus("blend");
					if (54406 - 107911 != -53505)
					{
						continue;
					}
				}
				if (this.qWuZ5FJlVM.getStatus("invisible") == null)
				{
					break;
				}
				if (225441 - 313702 != -88260)
				{
					this.qWuZ5FJlVM.removeStatus("invisible");
					if (130964 - 403334 == -272370)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002A15 RID: 10773 RVA: 0x00516910 File Offset: 0x00514B10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getTrinket(string nTrinket)
	{
		if (215513 - 171316 != 44197)
		{
		}
		GameObject result;
		for (;;)
		{
			result = null;
			if (34632 - 355461 != -320828 && 64126 - 164083 != -99956)
			{
				if (nTrinket == "t_all1")
				{
					if (176758 - 238084 == -61326)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/glasses", typeof(GameObject));
						if (25415 - 108384 != -82968)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all2")
				{
					if (187485 - 27047 == 160438)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/sunGlasses", typeof(GameObject));
						if (39651 - 207563 == -167912)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all3")
				{
					if (174425 - 13448 != 160978)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/starGlasses", typeof(GameObject));
						if (170078 - 433702 != -263623)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all4")
				{
					if (116743 - 532338 != -415594)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/nerdGlasses", typeof(GameObject));
						if (55883 - 436591 != -380707)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all5")
				{
					if (252612 - 285497 != -32884)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/blackGlasses", typeof(GameObject));
						if (39476 - 277379 == -237903)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all6")
				{
					if (176280 - 478105 != -301824)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/bugAntenna", typeof(GameObject));
						if (210307 - 180901 != 29407)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all7")
				{
					if (21994 - 46486 != -24491)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/partyWhistle", typeof(GameObject));
						if (4985 - 114240 != -109254)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all8")
				{
					if (249879 - 510102 == -260223)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/redNose", typeof(GameObject));
						if (214146 - 426375 != -212228)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all9")
				{
					if (206254 - 557953 != -351698)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/lollipop", typeof(GameObject));
						if (44520 - 342844 != -298323)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all46")
				{
					if (285976 - 141458 != 144519)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/groceryBag", typeof(GameObject));
						if (151083 - 116294 == 34789)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all51")
				{
					if (280107 - 27469 == 252638)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/sandTopaz", typeof(GameObject));
						if (97804 - 334246 == -236442)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all55")
				{
					if (232173 - 132201 != 99973)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/fifthSword", typeof(GameObject));
						if (284271 - 482585 != -198313)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all56")
				{
					if (226842 - 342960 == -116118)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/fifthWand", typeof(GameObject));
						if (56575 - 234960 != -178384)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all57")
				{
					if (28050 - 72688 != -44637)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/fifthWing", typeof(GameObject));
						if (269215 - 328424 == -59209)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all58")
				{
					if (40842 - 41449 == -607)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/carronBag", typeof(GameObject));
						if (136198 - 311937 == -175739)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all59")
				{
					if (165779 - 115888 == 49891)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/mupoBag", typeof(GameObject));
						if (146556 - 165773 != -19216)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all66")
				{
					if (30802 - 60534 == -29732)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/doubleHorn", typeof(GameObject));
						if (183277 - 452938 == -269661)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all71")
				{
					if (148159 - 485426 != -337266)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/championFlag1", typeof(GameObject));
						if (48917 - 135480 != -86562)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all72")
				{
					if (152273 - 208130 != -55856)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/championFlag2", typeof(GameObject));
						if (32754 - 74202 != -41447)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all73")
				{
					if (238435 - 176763 != 61673)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/championFlag3", typeof(GameObject));
						if (112669 - 69301 != 43369)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all74")
				{
					if (268021 - 406922 != -138900)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/championFlag4", typeof(GameObject));
						if (212556 - 531395 != -318838)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all75")
				{
					if (218613 - 8236 == 210377)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/championFlag5", typeof(GameObject));
						if (179472 - 163682 != 15791)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all91")
				{
					if (212548 - 71620 != 140929)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/lightSeal", typeof(GameObject));
						if (68788 - 263042 == -194254)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all92")
				{
					if (271857 - 162914 != 108944)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/fireSeal", typeof(GameObject));
						if (122096 - 256749 == -134653)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all93")
				{
					if (263262 - 24254 != 239009)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/waterSeal", typeof(GameObject));
						if (249899 - 9 != 249891)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all94")
				{
					if (4220 - 104550 == -100330)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/windSeal", typeof(GameObject));
						if (98737 - 314204 != -215466)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all95")
				{
					if (53765 - 275614 != -221848)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/earthSeal", typeof(GameObject));
						if (185811 - 440221 == -254410)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all96")
				{
					if (23758 - 569736 != -545977)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/shadowSeal", typeof(GameObject));
						if (237336 - 561165 == -323829)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_mal11")
				{
					if (196762 - 212622 == -15860)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/comic", typeof(GameObject));
						if (118661 - 582928 == -464267)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_mal14")
				{
					if (230219 - 411113 != -180893)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/heartRing", typeof(GameObject));
						if (267153 - 312941 == -45788)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_mal15")
				{
					if (52742 - 28611 != 24132)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/santaBag", typeof(GameObject));
						if (220327 - 367455 == -147128)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_mal31")
				{
					if (205087 - 18933 != 186155)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/chineseTalisman", typeof(GameObject));
						if (54572 - 337693 == -283121)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_mal37")
				{
					if (106362 - 598470 != -492107)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/chineseLantern", typeof(GameObject));
						if (218666 - 582448 == -363782)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_mal46")
				{
					if (216429 - 450877 == -234448)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/curseAnkh", typeof(GameObject));
						if (56526 - 577319 != -520792)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_mal56")
				{
					if (156956 - 206248 == -49292)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/frozenWing", typeof(GameObject));
						if (146060 - 315620 != -169559)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_mal66")
				{
					if (65280 - 188976 != -123695)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/poseidonTrinket", typeof(GameObject));
						if (155950 - 55907 == 100043)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_mnk45")
				{
					if (15366 - 94102 != -78735)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/starGuitar", typeof(GameObject));
						if (140338 - 366841 == -226503)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_mnk60")
				{
					if (177399 - 554901 == -377502)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/legendTrinket", typeof(GameObject));
						if (108520 - 452018 != -343497)
						{
							break;
						}
					}
				}
				else
				{
					if (!(nTrinket == "t_mnk61"))
					{
						break;
					}
					if (186223 - 48986 != 137238)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Trinkets/legendTrinketR", typeof(GameObject));
						if (171684 - 162439 != 9246)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06002A16 RID: 10774 RVA: 0x00517898 File Offset: 0x00515A98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipTrinket(string nTrinket)
	{
		if (120683 - 146368 != -25685)
		{
		}
		for (;;)
		{
			this.trinket = nTrinket;
			if (125933 - 492673 != -366739)
			{
				if (this.KSuZJmh9a6)
				{
					if (97057 - 332375 == -235317)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.KSuZJmh9a6);
					if (260570 - 57094 != 203476)
					{
						continue;
					}
				}
				GameObject gameObject = MonkeyEquipment.getTrinket(nTrinket);
				if (234595 - 455769 != -221173)
				{
					if (gameObject)
					{
						if (50100 - 230666 == -180565)
						{
							continue;
						}
						this.KSuZJmh9a6 = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (148416 - 187887 == -39470 || 142565 - 97455 == 45111)
						{
							continue;
						}
						if (!(nTrinket == "t_all71"))
						{
							if (155273 - 458017 == -302743)
							{
								continue;
							}
							if (!(nTrinket == "t_all72"))
							{
								if (86127 - 480464 == -394336)
								{
									continue;
								}
								if (!(nTrinket == "t_all73"))
								{
									if (204238 - 41010 == 163229)
									{
										continue;
									}
									if (!(nTrinket == "t_all74"))
									{
										if (59971 - 508070 == -448098)
										{
											continue;
										}
										if (!(nTrinket == "t_all75"))
										{
											if (31834 - 151904 == -120069)
											{
												continue;
											}
											if (!(nTrinket == "t_mal15"))
											{
												if (171839 - 512975 != -341136)
												{
													continue;
												}
												if (!(nTrinket == "t_mal56"))
												{
													if (287313 - 262635 == 24679)
													{
														continue;
													}
													if (nTrinket == "t_mal66")
													{
														if (9973 - 357992 == -348018)
														{
															continue;
														}
													}
													else if (nTrinket == "t_mal11")
													{
														if (105229 - 570478 == -465248)
														{
															continue;
														}
														this.KSuZJmh9a6.transform.parent = global::Math.findChildObject(this.gameObject.transform, "mount_Hand_R");
														if (259613 - 511434 == -251820)
														{
															continue;
														}
														this.KSuZJmh9a6.transform.localPosition = Vector3.zero;
														if (42245 - 418065 == -375819)
														{
															continue;
														}
														this.KSuZJmh9a6.transform.localRotation = Quaternion.identity;
														if (279023 - 407974 != -128951)
														{
															continue;
														}
														this.KSuZJmh9a6.transform.localScale = Vector3.one;
														if (8578 - 87746 != -79168)
														{
															continue;
														}
														goto IL_A10;
													}
													else
													{
														if (!(nTrinket == "t_all55"))
														{
															if (298167 - 279762 == 18406)
															{
																continue;
															}
															if (!(nTrinket == "t_all56"))
															{
																if (22809 - 341429 != -318620)
																{
																	continue;
																}
																if (!(nTrinket == "t_all57"))
																{
																	if (260243 - 286880 == -26636)
																	{
																		continue;
																	}
																	if (!(nTrinket == "t_all58"))
																	{
																		if (112859 - 91502 != 21357)
																		{
																			continue;
																		}
																		if (!(nTrinket == "t_all59"))
																		{
																			if (79228 - 202163 == -122934)
																			{
																				continue;
																			}
																			if (nTrinket == "t_mnk45")
																			{
																				if (11796 - 352648 == -340851)
																				{
																					continue;
																				}
																			}
																			else if (nTrinket == "t_mal37")
																			{
																				if (240758 - 478629 != -237871)
																				{
																					continue;
																				}
																				this.KSuZJmh9a6.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine2");
																				if (30456 - 153848 != -123392)
																				{
																					continue;
																				}
																				this.KSuZJmh9a6.transform.localPosition = Vector3.zero;
																				if (189024 - 193696 == -4671)
																				{
																					continue;
																				}
																				this.KSuZJmh9a6.transform.localRotation = Quaternion.Euler((float)270, (float)90, (float)0);
																				if (227321 - 16065 == 211257)
																				{
																					continue;
																				}
																				this.KSuZJmh9a6.transform.localScale = Vector3.one;
																				if (70555 - 87451 != -16895)
																				{
																					goto IL_A10;
																				}
																				continue;
																			}
																			else
																			{
																				if (!(nTrinket == "t_mnk60"))
																				{
																					if (132819 - 537688 != -404869)
																					{
																						continue;
																					}
																					if (nTrinket == "t_mnk61")
																					{
																						if (241477 - 19058 == 222420)
																						{
																							continue;
																						}
																					}
																					else if (nTrinket == "t_all46")
																					{
																						if (140722 - 218275 != -77553)
																						{
																							continue;
																						}
																						this.KSuZJmh9a6.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Hand_R");
																						if (100782 - 317376 != -216594)
																						{
																							continue;
																						}
																						this.KSuZJmh9a6.transform.localPosition = Vector3.zero;
																						if (124412 - 149832 != -25420)
																						{
																							continue;
																						}
																						this.KSuZJmh9a6.transform.localRotation = Quaternion.identity;
																						if (49203 - 42284 != 6919)
																						{
																							continue;
																						}
																						this.KSuZJmh9a6.transform.localScale = 0.8f * Vector3.one;
																						if (152807 - 185328 != -32520)
																						{
																							goto IL_A10;
																						}
																						continue;
																					}
																					else
																					{
																						if (!(nTrinket == "t_all91"))
																						{
																							if (256052 - 269610 == -13557)
																							{
																								continue;
																							}
																							if (!(nTrinket == "t_all92"))
																							{
																								if (118356 - 163505 != -45149)
																								{
																									continue;
																								}
																								if (!(nTrinket == "t_all93"))
																								{
																									if (281739 - 258783 == 22957)
																									{
																										continue;
																									}
																									if (!(nTrinket == "t_all94"))
																									{
																										if (139551 - 488570 == -349018)
																										{
																											continue;
																										}
																										if (!(nTrinket == "t_all95"))
																										{
																											if (31914 - 454566 != -422652)
																											{
																												continue;
																											}
																											if (nTrinket == "t_all96")
																											{
																												if (38343 - 535934 != -497591)
																												{
																													continue;
																												}
																											}
																											else
																											{
																												this.KSuZJmh9a6.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
																												if (242633 - 376054 == -133420)
																												{
																													continue;
																												}
																												this.KSuZJmh9a6.transform.localPosition = Vector3.zero;
																												if (246307 - 290737 != -44430)
																												{
																													continue;
																												}
																												this.KSuZJmh9a6.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
																												if (39872 - 312689 == -272816)
																												{
																													continue;
																												}
																												this.KSuZJmh9a6.transform.localScale = Vector3.one;
																												if (199990 - 438361 != -238371)
																												{
																													continue;
																												}
																												goto IL_A10;
																											}
																										}
																									}
																								}
																							}
																						}
																						this.KSuZJmh9a6.transform.parent = this.gameObject.transform;
																						if (235721 - 94948 != 140773)
																						{
																							continue;
																						}
																						this.KSuZJmh9a6.transform.localPosition = Vector3.zero;
																						if (94578 - 398422 != -303844)
																						{
																							continue;
																						}
																						this.KSuZJmh9a6.transform.localRotation = Quaternion.identity;
																						if (170219 - 239663 != -69444)
																						{
																							continue;
																						}
																						this.KSuZJmh9a6.transform.localScale = Vector3.one;
																						if (257914 - 162444 != 95471)
																						{
																							goto IL_A10;
																						}
																						continue;
																					}
																				}
																				this.KSuZJmh9a6.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine2");
																				if (68248 - 319507 != -251259)
																				{
																					continue;
																				}
																				this.KSuZJmh9a6.transform.localPosition = Vector3.zero;
																				if (108278 - 335565 != -227287)
																				{
																					continue;
																				}
																				this.KSuZJmh9a6.transform.localRotation = Quaternion.Euler((float)270, (float)90, (float)0);
																				if (162519 - 582716 != -420197)
																				{
																					continue;
																				}
																				this.KSuZJmh9a6.transform.localScale = Vector3.one;
																				if (206921 - 181800 != 25122)
																				{
																					goto IL_A10;
																				}
																				continue;
																			}
																		}
																	}
																}
															}
														}
														this.KSuZJmh9a6.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine1");
														if (114901 - 560366 != -445465)
														{
															continue;
														}
														this.KSuZJmh9a6.transform.localPosition = Vector3.zero;
														if (260835 - 506457 != -245622)
														{
															continue;
														}
														this.KSuZJmh9a6.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
														if (249709 - 397064 != -147355)
														{
															continue;
														}
														this.KSuZJmh9a6.transform.localScale = Vector3.one;
														if (23301 - 244107 != -220806)
														{
															continue;
														}
														goto IL_A10;
													}
												}
											}
										}
									}
								}
							}
						}
						this.KSuZJmh9a6.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine2");
						if (49137 - 125008 != -75871)
						{
							continue;
						}
						this.KSuZJmh9a6.transform.localPosition = Vector3.zero;
						if (11658 - 192630 == -180971)
						{
							continue;
						}
						this.KSuZJmh9a6.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
						if (296963 - 232439 != 64524)
						{
							continue;
						}
						this.KSuZJmh9a6.transform.localScale = Vector3.one;
						if (225061 - 281400 != -56339)
						{
							continue;
						}
					}
					IL_A10:
					if (!this.qWuZ5FJlVM)
					{
						break;
					}
					if (248944 - 138555 != 110390)
					{
						this.qWuZ5FJlVM.trinket = nTrinket;
						if (139337 - 503605 == -364268)
						{
							this.qWuZ5FJlVM.mTrn = this.KSuZJmh9a6;
							if (298265 - 442377 != -144111)
							{
								if (this.qWuZ5FJlVM.getStatus("blend") != null)
								{
									if (192582 - 271182 != -78600)
									{
										continue;
									}
									this.qWuZ5FJlVM.removeStatus("blend");
									if (43553 - 116197 == -72643)
									{
										continue;
									}
								}
								if (this.qWuZ5FJlVM.getStatus("invisible") == null)
								{
									break;
								}
								if (149300 - 22413 == 126887)
								{
									this.qWuZ5FJlVM.removeStatus("invisible");
									if (168836 - 502723 == -333887)
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

	// Token: 0x06002A17 RID: 10775 RVA: 0x005185D4 File Offset: 0x005167D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipPet(string nPet)
	{
		if (183206 - 90249 != 92958)
		{
		}
		for (;;)
		{
			if (Game.mGameType < 2)
			{
				if (2628 - 110211 != -107582)
				{
					break;
				}
			}
			else
			{
				this.pet = nPet;
				if (229858 - 128464 != 101395)
				{
					if (this.am9Z6duBWp)
					{
						if (116886 - 328802 == -211915)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.am9Z6duBWp);
						if (37502 - 421725 != -384223)
						{
							continue;
						}
					}
					GameObject gameObject = null;
					if (93120 - 249292 != -156171)
					{
						int num = 1;
						if (70045 - 467100 == -397055)
						{
							if (60044 - 86185 != -26140)
							{
								if (nPet == "p_all1")
								{
									if (264059 - 121965 != 142094)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/bigbugBalloon", typeof(GameObject));
									if (29461 - 220047 == -190585)
									{
										continue;
									}
								}
								else if (nPet == "p_all2")
								{
									if (216042 - 303181 == -87138)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/bluebugBalloon", typeof(GameObject));
									if (16210 - 257676 != -241466)
									{
										continue;
									}
								}
								else if (nPet == "p_all3")
								{
									if (43645 - 306703 == -263057)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/momBalloon", typeof(GameObject));
									if (105761 - 328121 == -222359)
									{
										continue;
									}
								}
								else if (nPet == "p_all4")
								{
									if (176567 - 121781 != 54786)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/dadBalloon", typeof(GameObject));
									if (14930 - 463345 == -448414)
									{
										continue;
									}
								}
								else if (nPet == "p_all11")
								{
									if (55405 - 485772 == -430366)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallSmashBall", typeof(GameObject));
									if (8930 - 50505 != -41575)
									{
										continue;
									}
								}
								else if (nPet == "p_all12")
								{
									if (140274 - 318146 != -177872)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/soccerBall", typeof(GameObject));
									if (112804 - 326263 != -213459)
									{
										continue;
									}
								}
								else if (nPet == "p_all21")
								{
									if (110991 - 100571 != 10420)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteChula", typeof(GameObject));
									if (174497 - 284104 == -109606)
									{
										continue;
									}
								}
								else if (nPet == "p_all22")
								{
									if (245353 - 284624 == -39270)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kitePukpao", typeof(GameObject));
									if (144662 - 208376 != -63714)
									{
										continue;
									}
								}
								else if (nPet == "p_all23")
								{
									if (216922 - 182252 != 34670)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteButterfly", typeof(GameObject));
									if (271905 - 325767 == -53861)
									{
										continue;
									}
								}
								else if (nPet == "p_all24")
								{
									if (169979 - 179948 != -9969)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteSnake", typeof(GameObject));
									if (180293 - 255702 == -75408)
									{
										continue;
									}
								}
								else if (Extensions.get_length(nPet) == 6)
								{
									if (138708 - 80005 == 58704)
									{
										continue;
									}
									string a = nPet.Substring(0, 5);
									if (192937 - 134505 != 58432)
									{
										continue;
									}
									if (a == "p_lcr")
									{
										if (153307 - 132961 == 20347)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron", typeof(GameObject));
										if (56980 - 92079 == -35098)
										{
											continue;
										}
									}
									else if (a == "p_lcp")
									{
										if (245789 - 66198 != 179591)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron_p", typeof(GameObject));
										if (289881 - 480817 == -190935)
										{
											continue;
										}
									}
									else if (a == "p_lmp")
									{
										if (30075 - 6774 == 23302)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMupo", typeof(GameObject));
										if (100623 - 65788 != 34835)
										{
											continue;
										}
									}
									else if (a == "p_lpp")
									{
										if (114077 - 510003 == -395925)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePeppon", typeof(GameObject));
										if (22337 - 430913 == -408575)
										{
											continue;
										}
									}
									else if (a == "p_lct")
									{
										if (196294 - 477406 != -281112)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCacton", typeof(GameObject));
										if (255842 - 272992 != -17150)
										{
											continue;
										}
									}
									else if (a == "p_lcc")
									{
										if (180591 - 480997 == -300405)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCocon", typeof(GameObject));
										if (241118 - 301596 == -60477)
										{
											continue;
										}
									}
									else if (a == "p_lpk")
									{
										if (84052 - 305611 != -221559)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePumpkon", typeof(GameObject));
										if (149238 - 568360 == -419121)
										{
											continue;
										}
									}
									else if (a == "p_lml")
									{
										if (19032 - 380363 == -361330)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMellon", typeof(GameObject));
										if (287623 - 25759 == 261865)
										{
											continue;
										}
									}
									else if (a == "p_lbd")
									{
										if (134489 - 14490 != 119999)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleBDMellon", typeof(GameObject));
										if (148301 - 39081 != 109220)
										{
											continue;
										}
									}
									else if (a == "p_lcs")
									{
										if (81327 - 215800 == -134472)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron_s", typeof(GameObject));
										if (26580 - 228801 == -202220)
										{
											continue;
										}
									}
									else if (a == "p_lms")
									{
										if (156173 - 541061 != -384888)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMupo_s", typeof(GameObject));
										if (294212 - 211048 == 83165)
										{
											continue;
										}
									}
									else if (a == "p_lps")
									{
										if (112751 - 542108 == -429356)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePeppon_s", typeof(GameObject));
										if (38588 - 577927 != -539339)
										{
											continue;
										}
									}
									else if (a == "p_lck")
									{
										if (159562 - 468145 == -308582)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarronCake", typeof(GameObject));
										if (7708 - 464257 != -456549)
										{
											continue;
										}
									}
									else if (a == "p_lpd")
									{
										if (136181 - 495330 != -359149)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePepponDisco", typeof(GameObject));
										if (131920 - 408425 != -276505)
										{
											continue;
										}
									}
									else if (a == "p_lmc")
									{
										if (206690 - 199313 != 7377)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadCarron", typeof(GameObject));
										if (10243 - 438837 != -428594)
										{
											continue;
										}
									}
									else if (a == "p_lmn")
									{
										if (285811 - 50852 != 234959)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadPeppon", typeof(GameObject));
										if (45934 - 563748 == -517813)
										{
											continue;
										}
									}
									else if (a == "p_lmo")
									{
										if (252349 - 236299 == 16051)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadCocon", typeof(GameObject));
										if (264416 - 308869 != -44453)
										{
											continue;
										}
									}
									else if (a == "p_ldc")
									{
										if (248691 - 79593 == 169099)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCarron", typeof(GameObject));
										if (51614 - 162476 != -110862)
										{
											continue;
										}
									}
									else if (a == "p_ldm")
									{
										if (192239 - 492649 != -300410)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadMupo", typeof(GameObject));
										if (126448 - 350107 == -223658)
										{
											continue;
										}
									}
									else if (a == "p_ldp")
									{
										if (108367 - 33956 != 74411)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadPeppon", typeof(GameObject));
										if (255256 - 186644 != 68612)
										{
											continue;
										}
									}
									else if (a == "p_ldt")
									{
										if (113818 - 122522 != -8704)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCacton", typeof(GameObject));
										if (87568 - 101472 == -13903)
										{
											continue;
										}
									}
									else if (a == "p_ldn")
									{
										if (294729 - 293247 == 1483)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCocon", typeof(GameObject));
										if (49795 - 500296 == -450500)
										{
											continue;
										}
									}
									else if (a == "p_ldk")
									{
										if (115166 - 392788 == -277621)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadPumpkon", typeof(GameObject));
										if (214079 - 527139 != -313060)
										{
											continue;
										}
									}
									else if (a == "p_srp")
									{
										if (223227 - 287243 != -64016)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallRedPanda", typeof(GameObject));
										if (272458 - 417617 != -145159)
										{
											continue;
										}
									}
									else if (a == "p_sss")
									{
										if (165600 - 374998 != -209398)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallSantaSkunk", typeof(GameObject));
										if (249888 - 508829 == -258940)
										{
											continue;
										}
									}
									else if (a == "p_sbb")
									{
										if (5824 - 129537 != -123713)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallBarrelBot", typeof(GameObject));
										if (7525 - 450815 == -443289)
										{
											continue;
										}
									}
									else if (a == "p_sdm")
									{
										if (108773 - 11876 != 96897)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallDemion", typeof(GameObject));
										if (272558 - 138844 == 133715)
										{
											continue;
										}
									}
									else if (a == "p_sdv")
									{
										if (61678 - 276698 != -215020)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallDoov", typeof(GameObject));
										if (48484 - 46070 != 2414)
										{
											continue;
										}
									}
									else if (a == "p_skz")
									{
										if (197872 - 293900 == -96027)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallKarazo", typeof(GameObject));
										if (148239 - 59250 == 88990)
										{
											continue;
										}
									}
									else if (a == "p_skm")
									{
										if (109602 - 521201 == -411598)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallKumo", typeof(GameObject));
										if (193970 - 453246 != -259276)
										{
											continue;
										}
									}
									else if (a == "p_skr")
									{
										if (136817 - 589467 == -452649)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_r", typeof(GameObject));
										if (184665 - 551583 == -366917)
										{
											continue;
										}
									}
									else if (a == "p_skg")
									{
										if (78379 - 285044 == -206664)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_g", typeof(GameObject));
										if (192536 - 573352 == -380815)
										{
											continue;
										}
									}
									else if (a == "p_sky")
									{
										if (9065 - 455115 == -446049)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_y", typeof(GameObject));
										if (86233 - 403773 == -317539)
										{
											continue;
										}
									}
									else if (a == "p_skb")
									{
										if (260567 - 93002 == 167566)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_b", typeof(GameObject));
										if (30527 - 26523 != 4004)
										{
											continue;
										}
									}
									else if (a == "p_skk")
									{
										if (152783 - 598773 == -445989)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_k", typeof(GameObject));
										if (80813 - 467866 == -387052)
										{
											continue;
										}
									}
									else if (a == "p_sfb")
									{
										if (255043 - 106937 != 148106)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallFlowerBug", typeof(GameObject));
										if (119407 - 387529 == -268121)
										{
											continue;
										}
									}
									else if (a == "p_sob")
									{
										if (35407 - 196848 != -161441)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallLionBug", typeof(GameObject));
										if (243792 - 281892 == -38099)
										{
											continue;
										}
									}
									else if (a == "p_sgb")
									{
										if (50113 - 415623 != -365510)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallGiantBug", typeof(GameObject));
										if (229131 - 569771 != -340640)
										{
											continue;
										}
									}
									else if (a == "p_slb")
									{
										if (15981 - 586606 != -570625)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallLeafBug", typeof(GameObject));
										if (183606 - 325992 != -142386)
										{
											continue;
										}
									}
									else if (a == "p_stb")
									{
										if (180329 - 261561 == -81231)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallFatBug", typeof(GameObject));
										if (185519 - 24526 == 160994)
										{
											continue;
										}
									}
									else if (a == "p_spb")
									{
										if (273730 - 29576 != 244154)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallPaperBug", typeof(GameObject));
										if (55158 - 256652 != -201494)
										{
											continue;
										}
									}
									else if (a == "p_swb")
									{
										if (21774 - 428005 != -406231)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallWormBug", typeof(GameObject));
										if (154289 - 122673 != 31616)
										{
											continue;
										}
									}
									else if (a == "p_ssq")
									{
										if (149827 - 426166 == -276338)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallStingQueen", typeof(GameObject));
										if (55286 - 301519 == -246232)
										{
											continue;
										}
									}
									else if (a == "p_snb")
									{
										if (20130 - 197241 != -177111)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNeonBug", typeof(GameObject));
										if (110601 - 82763 != 27838)
										{
											continue;
										}
									}
									else if (a == "p_sim")
									{
										if (171855 - 466200 == -294344)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallIceMixer", typeof(GameObject));
										if (188412 - 1238 == 187175)
										{
											continue;
										}
									}
									else if (a == "p_sam")
									{
										if (94967 - 472701 != -377734)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallAmmonite", typeof(GameObject));
										if (260833 - 524758 != -263925)
										{
											continue;
										}
									}
									else if (a == "p_sab")
									{
										if (157022 - 463614 == -306591)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallAnubi", typeof(GameObject));
										if (59874 - 164606 == -104731)
										{
											continue;
										}
									}
									else if (a == "p_spg")
									{
										if (228533 - 184798 != 43735)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallIcePenguin", typeof(GameObject));
										if (62366 - 547211 != -484845)
										{
											continue;
										}
									}
									else if (a == "p_spf")
									{
										if (170963 - 236487 == -65523)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallPirateFish", typeof(GameObject));
										if (14780 - 316930 == -302149)
										{
											continue;
										}
									}
									else if (a == "p_msb")
									{
										if (8682 - 556184 != -547502)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniSkyBug", typeof(GameObject));
										if (273804 - 398926 != -125122)
										{
											continue;
										}
									}
									else if (a == "p_mcb")
									{
										if (51029 - 559269 == -508239)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniCrystalBug", typeof(GameObject));
										if (184117 - 555636 != -371519)
										{
											continue;
										}
									}
									else if (a == "p_mab")
									{
										if (288594 - 305060 != -16466)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniAncientBug", typeof(GameObject));
										if (277037 - 134414 != 142623)
										{
											continue;
										}
									}
									else if (a == "p_mrb")
									{
										if (160199 - 215411 != -55212)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniReefBug", typeof(GameObject));
										if (71893 - 48533 != 23360)
										{
											continue;
										}
									}
									else if (a == "p_mmb")
									{
										if (139576 - 300465 == -160888)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniMokBug", typeof(GameObject));
										if (54178 - 334046 == -279867)
										{
											continue;
										}
									}
									else if (a == "p_mgb")
									{
										if (2185 - 567608 != -565423)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniGoldenBug", typeof(GameObject));
										if (164841 - 242391 == -77549)
										{
											continue;
										}
									}
									else if (a == "p_mnb")
									{
										if (266915 - 149544 != 117371)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniNemesisBug", typeof(GameObject));
										if (267867 - 81992 == 185876)
										{
											continue;
										}
									}
									num = Stringf.getLastDigit(nPet);
									if (76694 - 1670 == 75025)
									{
										continue;
									}
									if (num < 0)
									{
										if (15489 - 516119 != -500630)
										{
											continue;
										}
										num = 1;
										if (262690 - 187868 == 74823)
										{
											continue;
										}
									}
								}
								if (gameObject)
								{
									if (47280 - 309702 == -262421)
									{
										continue;
									}
									this.am9Z6duBWp = (GameObject)UnityEngine.Object.Instantiate(gameObject, this.transform.position - this.transform.forward, this.transform.rotation);
									if (120282 - 330410 != -210128)
									{
										continue;
									}
									if (this.am9Z6duBWp)
									{
										if (256465 - 369361 == -112895)
										{
											continue;
										}
										this.am9Z6duBWp.transform.localScale = ((float)num * 0.1f + 0.9f) * Vector3.one;
										if (258870 - 469447 != -210577)
										{
											continue;
										}
										PetControl petControl = (PetControl)this.am9Z6duBWp.GetComponent(typeof(PetControl));
										if (170685 - 274736 != -104051)
										{
											continue;
										}
										if (petControl)
										{
											if (12948 - 404385 != -391437)
											{
												continue;
											}
											petControl.Init(this.gameObject, num);
											if (290611 - 358841 == -68229)
											{
												continue;
											}
										}
										if (this.qWuZ5FJlVM)
										{
											if (272485 - 582805 == -310319)
											{
												continue;
											}
											this.qWuZ5FJlVM.mPet = this.am9Z6duBWp;
											if (154928 - 165610 != -10682)
											{
												continue;
											}
										}
									}
								}
								if (!this.qWuZ5FJlVM)
								{
									break;
								}
								if (26661 - 129092 == -102431)
								{
									this.qWuZ5FJlVM.pet = nPet;
									if (232334 - 487646 != -255311)
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

	// Token: 0x06002A18 RID: 10776 RVA: 0x0051A338 File Offset: 0x00518538
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002A19 RID: 10777 RVA: 0x0051A33C File Offset: 0x0051853C
	internal static bool GGkRWlzNwgWVnpW23LN()
	{
		return true;
	}

	// Token: 0x06002A1A RID: 10778 RVA: 0x0051A340 File Offset: 0x00518540
	internal static bool N7QY8wzYv4T74LdUxZf()
	{
		return false;
	}

	// Token: 0x04002F9A RID: 12186
	private CharacterControl qWuZ5FJlVM;

	// Token: 0x04002F9B RID: 12187
	public string weapon;

	// Token: 0x04002F9C RID: 12188
	public string armor;

	// Token: 0x04002F9D RID: 12189
	public string accessory;

	// Token: 0x04002F9E RID: 12190
	public string boot;

	// Token: 0x04002F9F RID: 12191
	public string trinket;

	// Token: 0x04002FA0 RID: 12192
	public string pet;

	// Token: 0x04002FA1 RID: 12193
	public int skin;

	// Token: 0x04002FA2 RID: 12194
	public bool equipOnStart;

	// Token: 0x04002FA3 RID: 12195
	private GameObject ktvZcaxdPF;

	// Token: 0x04002FA4 RID: 12196
	private GameObject CNcZnVDSbq;

	// Token: 0x04002FA5 RID: 12197
	private GameObject fWXZQPT1t4;

	// Token: 0x04002FA6 RID: 12198
	private GameObject g7kZeeQDLM;

	// Token: 0x04002FA7 RID: 12199
	private GameObject CpgZIxxi1d;

	// Token: 0x04002FA8 RID: 12200
	private GameObject KSuZJmh9a6;

	// Token: 0x04002FA9 RID: 12201
	private GameObject am9Z6duBWp;
}
