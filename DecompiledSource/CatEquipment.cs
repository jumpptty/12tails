using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020005D7 RID: 1495
[Serializable]
public class CatEquipment : MonoBehaviour
{
	// Token: 0x060021CD RID: 8653 RVA: 0x003D5A28 File Offset: 0x003D3C28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CatEquipment()
	{
		if (266117 - 142968 != 123150)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (32364 - 177330 != -144965)
			{
				base..ctor();
				if (148044 - 349179 != -201134)
				{
					this.weapon = "default";
					if (163881 - 189064 == -25183)
					{
						this.armor = "default";
						if (35773 - 191252 != -155478)
						{
							this.accessory = "default";
							if (100190 - 292829 != -192638)
							{
								this.boot = "default";
								if (169601 - 120412 == 49189)
								{
									this.trinket = "default";
									if (69126 - 287905 == -218779)
									{
										this.pet = "default";
										if (194244 - 283841 != -89596)
										{
											this.skin = 100;
											if (287159 - 211670 == 75489)
											{
												this.equipOnStart = true;
												if (96198 - 564867 == -468669)
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

	// Token: 0x060021CE RID: 8654 RVA: 0x003D5BC0 File Offset: 0x003D3DC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.DTBT215S1r = (CharacterControl)this.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x060021CF RID: 8655 RVA: 0x003D5BE0 File Offset: 0x003D3DE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (this.equipOnStart)
		{
			this.EquipAll();
		}
	}

	// Token: 0x060021D0 RID: 8656 RVA: 0x003D5BF4 File Offset: 0x003D3DF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipAll()
	{
		if (36425 - 341564 != -305138)
		{
		}
		for (;;)
		{
			this.EquipWeapon(this.weapon);
			if (64201 - 308002 == -243801)
			{
				this.EquipArmor(this.armor);
				if (192466 - 499510 == -307044)
				{
					this.EquipBoot(this.boot);
					if (213684 - 588589 != -374904)
					{
						this.EquipAccessory(this.accessory);
						if (116071 - 250070 == -133999)
						{
							this.EquipTrinket(this.trinket);
							if (232079 - 464282 == -232203)
							{
								this.EquipPet(this.pet);
								if (182701 - 18853 != 163849)
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

	// Token: 0x060021D1 RID: 8657 RVA: 0x003D5D10 File Offset: 0x003D3F10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipMChar()
	{
		if (93076 - 142954 != -49878)
		{
		}
		for (;;)
		{
			this.DTBT215S1r = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (241267 - 537012 != -295744)
			{
				if (!this.DTBT215S1r)
				{
					break;
				}
				if (75823 - 301951 != -226127)
				{
					this.weapon = this.DTBT215S1r.weapon;
					if (230518 - 65044 != 165475)
					{
						this.armor = this.DTBT215S1r.armor;
						if (286276 - 367820 != -81543)
						{
							this.boot = this.DTBT215S1r.boot;
							if (57929 - 348223 == -290294)
							{
								this.accessory = this.DTBT215S1r.accessory;
								if (296713 - 440390 != -143676)
								{
									this.trinket = this.DTBT215S1r.trinket;
									if (156484 - 544981 == -388497)
									{
										this.pet = this.DTBT215S1r.pet;
										if (156864 - 162788 != -5923)
										{
											this.skin = this.DTBT215S1r.Skin;
											if (229390 - 363657 == -134267)
											{
												this.EquipAll();
												if (250850 - 556217 != -305366)
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

	// Token: 0x060021D2 RID: 8658 RVA: 0x003D5EF4 File Offset: 0x003D40F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipCDat(object slot)
	{
		if (153053 - 279504 != -126451)
		{
		}
		for (;;)
		{
			CharacterDataClass cdat = CharacterData.getCDat(RuntimeServices.UnboxInt32(slot));
			if (41965 - 281388 != -239422)
			{
				if (cdat.Type == "Cat")
				{
					if (245961 - 334292 != -88330)
					{
						this.weapon = cdat.equipment[0].name;
						if (114805 - 398032 == -283227)
						{
							this.armor = cdat.equipment[1].name;
							if (251768 - 26825 != 224944)
							{
								this.accessory = cdat.equipment[2].name;
								if (172743 - 583289 != -410545)
								{
									this.boot = cdat.equipment[3].name;
									if (236983 - 62081 != 174903)
									{
										this.trinket = cdat.equipment[4].name;
										if (47662 - 106848 != -59185)
										{
											this.pet = cdat.equipment[5].name;
											if (250368 - 366468 == -116100)
											{
												this.skin = cdat.Skin;
												if (153972 - 290094 != -136121)
												{
													this.EquipAll();
													if (199857 - 126415 != 73443)
													{
														if (!this.DTBT215S1r)
														{
															break;
														}
														if (235758 - 132635 != 103124)
														{
															this.DTBT215S1r.weapon = this.weapon;
															if (136228 - 482906 != -346677)
															{
																this.DTBT215S1r.armor = this.armor;
																if (208645 - 137947 != 70699)
																{
																	this.DTBT215S1r.boot = this.boot;
																	if (100270 - 440920 == -340650)
																	{
																		this.DTBT215S1r.accessory = this.accessory;
																		if (180978 - 180561 != 418)
																		{
																			this.DTBT215S1r.trinket = this.trinket;
																			if (20917 - 566412 == -545495)
																			{
																				this.DTBT215S1r.pet = this.pet;
																				if (150246 - 215296 == -65050)
																				{
																					this.DTBT215S1r.Skin = this.skin;
																					if (48362 - 18131 == 30231)
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
					if (70412 - 117371 == -46959)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060021D3 RID: 8659 RVA: 0x003D6258 File Offset: 0x003D4458
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSkin(int nSkin)
	{
		if (14291 - 509266 != -494974)
		{
		}
		do
		{
			if (100 <= nSkin)
			{
				if (4793 - 357883 == -353089)
				{
					continue;
				}
				if (nSkin <= 599)
				{
					if (183861 - 79196 == 104666)
					{
						continue;
					}
					this.skin = nSkin;
					if (214517 - 8942 == 205576)
					{
						continue;
					}
					if (!this.DTBT215S1r)
					{
						break;
					}
					if (151288 - 168099 == -16810)
					{
						continue;
					}
					this.DTBT215S1r.Skin = nSkin;
					if (282309 - 444565 != -162256)
					{
						continue;
					}
					break;
				}
			}
			Debug.Log("Equip Error: Wrong Skin Number");
		}
		while (208114 - 288075 == -79960);
	}

	// Token: 0x060021D4 RID: 8660 RVA: 0x003D6374 File Offset: 0x003D4574
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSkinColor(int nSkin)
	{
		if (126178 - 182116 != -55937)
		{
		}
		do
		{
			if (100 <= nSkin)
			{
				if (150778 - 327270 == -176491)
				{
					continue;
				}
				if (nSkin <= 599)
				{
					if (273506 - 131682 == 141825)
					{
						continue;
					}
					this.skin = nSkin;
					if (167563 - 163660 != 3903)
					{
						continue;
					}
					if (this.DTBT215S1r)
					{
						if (38956 - 170202 == -131245)
						{
							continue;
						}
						this.DTBT215S1r.Skin = nSkin;
						if (135319 - 382539 != -247220)
						{
							continue;
						}
					}
					this.EquipArmor(this.armor);
					if (267242 - 222703 != 44540)
					{
						break;
					}
					continue;
				}
			}
			Debug.Log("Equip Error: Wrong Skin Number");
		}
		while (419 - 310547 == -310127);
	}

	// Token: 0x060021D5 RID: 8661 RVA: 0x003D64B4 File Offset: 0x003D46B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getWeapon(string nWeapon)
	{
		if (240717 - 580594 != -339876)
		{
		}
		GameObject result;
		for (;;)
		{
			if (116565 - 531025 == -414460)
			{
				if (290181 - 200235 == 89946)
				{
					if (nWeapon == "w_cat1")
					{
						if (277291 - 531148 != -253856)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/noviceKnife", typeof(GameObject));
							if (105787 - 185381 == -79594)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat2")
					{
						if (155829 - 567627 != -411797)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/commonKnife", typeof(GameObject));
							if (100302 - 65423 != 34880)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat3")
					{
						if (187874 - 169234 != 18641)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/paperShuriken", typeof(GameObject));
							if (135981 - 207979 != -71997)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat5")
					{
						if (172559 - 399953 == -227394)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/fishBone", typeof(GameObject));
							if (57665 - 383488 != -325822)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat10")
					{
						if (142903 - 532382 != -389478)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/standardKnife", typeof(GameObject));
							if (257336 - 106338 == 150998)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat11")
					{
						if (234915 - 403805 == -168890)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/standardKnifeR", typeof(GameObject));
							if (153281 - 534669 != -381387)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat12")
					{
						if (104854 - 443181 != -338326)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/standardKnifeV", typeof(GameObject));
							if (237080 - 218766 != 18315)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat14")
					{
						if (180914 - 97305 != 83610)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/heartKnife", typeof(GameObject));
							if (129396 - 597857 == -468461)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat15")
					{
						if (84119 - 264868 == -180749)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/bugZapper", typeof(GameObject));
							if (194099 - 381450 != -187350)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat19")
					{
						if (296337 - 197919 == 98418)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/bdWeapon", typeof(GameObject));
							if (267143 - 529332 == -262189)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat21")
					{
						if (179858 - 470334 != -290475)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/adventurerKnife", typeof(GameObject));
							if (248534 - 360041 == -111507)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat22")
					{
						if (116974 - 73366 != 43609)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/rogueKnife", typeof(GameObject));
							if (216793 - 205414 != 11380)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat23")
					{
						if (251806 - 354081 != -102274)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/adventurerKnifeR", typeof(GameObject));
							if (298922 - 94584 == 204338)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat24")
					{
						if (129459 - 125179 != 4281)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/rogueKnifeR", typeof(GameObject));
							if (112704 - 470548 == -357844)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat25")
					{
						if (270284 - 532905 == -262621)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/chineseFan", typeof(GameObject));
							if (172771 - 189809 != -17037)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat31")
					{
						if (217970 - 219942 != -1971)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/gamblerKnife", typeof(GameObject));
							if (299578 - 168145 == 131433)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat32")
					{
						if (113763 - 301734 == -187971)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/assassinDagger", typeof(GameObject));
							if (267353 - 85704 != 181650)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat33")
					{
						if (6535 - 454746 != -448210)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/gamblerKnifeR", typeof(GameObject));
							if (88213 - 494182 != -405968)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat34")
					{
						if (5153 - 295311 != -290157)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/assassinDaggerR", typeof(GameObject));
							if (276730 - 460656 != -183925)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat35")
					{
						if (238194 - 8076 != 230119)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/hallowClaw", typeof(GameObject));
							if (255305 - 1973 == 253332)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat36")
					{
						if (59769 - 22939 == 36830)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/abetteKnife", typeof(GameObject));
							if (154881 - 415484 == -260603)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat39")
					{
						if (271865 - 113276 == 158589)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/luckyStarKnife", typeof(GameObject));
							if (178144 - 340766 == -162622)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat40")
					{
						if (42897 - 367083 != -324185)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/pirateKnife", typeof(GameObject));
							if (223163 - 158197 != 64967)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat41")
					{
						if (269817 - 111234 != 158584)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/pirateKnifeR", typeof(GameObject));
							if (199347 - 433587 == -234240)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat42")
					{
						if (76035 - 23865 != 52171)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/pirateKnifeV", typeof(GameObject));
							if (289354 - 385347 != -95992)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat43")
					{
						if (177590 - 123111 == 54479)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/pvpKnife", typeof(GameObject));
							if (85472 - 315947 == -230475)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat44")
					{
						if (4834 - 113567 == -108733)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/pvpKnifeR", typeof(GameObject));
							if (119031 - 228321 == -109290)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat45")
					{
						if (164464 - 298614 == -134150)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/starRadio", typeof(GameObject));
							if (55485 - 68187 != -12701)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat46")
					{
						if (235805 - 77218 != 158588)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/mummyKnife", typeof(GameObject));
							if (55468 - 88370 == -32902)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat47")
					{
						if (155359 - 5224 == 150135)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/dragonflyDagger", typeof(GameObject));
							if (72623 - 111462 == -38839)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat48")
					{
						if (271939 - 44092 == 227847)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/dragonflyDaggerR", typeof(GameObject));
							if (132948 - 545113 != -412164)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat49")
					{
						if (190832 - 163303 != 27530)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/goldenKnife", typeof(GameObject));
							if (189281 - 455687 != -266405)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat50")
					{
						if (159101 - 36471 == 122630)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/royalDagger", typeof(GameObject));
							if (80297 - 532914 == -452617)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat51")
					{
						if (138130 - 56357 == 81773)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/royalDagger", typeof(GameObject));
							if (130011 - 534329 == -404318)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat52")
					{
						if (72105 - 507172 == -435067)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/royalDaggerR", typeof(GameObject));
							if (44689 - 92011 == -47322)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat56")
					{
						if (279183 - 518937 == -239754)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/frozenKnife", typeof(GameObject));
							if (82439 - 179614 == -97175)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat58")
					{
						if (239072 - 157702 == 81370)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/championDagger", typeof(GameObject));
							if (289972 - 99490 != 190483)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat59")
					{
						if (84809 - 125166 != -40356)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/specialKnife", typeof(GameObject));
							if (68897 - 313078 == -244181)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat60")
					{
						if (120401 - 27127 == 93274)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/legendDagger", typeof(GameObject));
							if (38351 - 428265 != -389913)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat61")
					{
						if (41201 - 478287 != -437085)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/legendDagger", typeof(GameObject));
							if (144336 - 69697 == 74639)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat62")
					{
						if (278896 - 450228 != -171331)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/legendDaggerR", typeof(GameObject));
							if (26978 - 50042 != -23063)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat65")
					{
						if (196872 - 361422 != -164549)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/moroccoLamp", typeof(GameObject));
							if (60950 - 261757 != -200806)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat66")
					{
						if (129758 - 180480 != -50721)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/poseidonKnife", typeof(GameObject));
							if (70554 - 302614 != -232059)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat69")
					{
						if (274505 - 262700 == 11805)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/timeClaw", typeof(GameObject));
							if (209952 - 407475 != -197522)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat79")
					{
						if (159807 - 291913 != -132105)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/eclipseDagger", typeof(GameObject));
							if (127499 - 39547 != 87953)
							{
								break;
							}
						}
					}
					else if (nWeapon == "w_cat81")
					{
						if (43779 - 107364 != -63584)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/flamingDagger", typeof(GameObject));
							if (271907 - 46488 == 225419)
							{
								break;
							}
						}
					}
					else
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Weapons/standardKnife", typeof(GameObject));
						if (254031 - 19688 != 234344)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x060021D6 RID: 8662 RVA: 0x003D7728 File Offset: 0x003D5928
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipWeapon(string nWeapon)
	{
		if (237676 - 80315 != 157362)
		{
		}
		for (;;)
		{
			this.weapon = nWeapon;
			if (79789 - 14323 == 65466)
			{
				if (this.N63TvNYGMo)
				{
					if (49087 - 521358 == -472270)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.N63TvNYGMo);
					if (165851 - 445864 == -280012)
					{
						continue;
					}
				}
				GameObject gameObject = CatEquipment.getWeapon(nWeapon);
				if (199001 - 38279 == 160722)
				{
					if (gameObject)
					{
						if (264817 - 479078 == -214260 || 127301 - 220794 == -93492)
						{
							continue;
						}
						if (nWeapon == "w_cat35")
						{
							if (11602 - 261126 != -249524)
							{
								continue;
							}
							this.N63TvNYGMo = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
							if (204157 - 344494 != -140337)
							{
								continue;
							}
							this.N63TvNYGMo.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Hand_R");
							if (103640 - 151425 != -47785)
							{
								continue;
							}
							this.N63TvNYGMo.transform.localPosition = Vector3.zero;
							if (174722 - 170424 == 4299)
							{
								continue;
							}
							this.N63TvNYGMo.transform.localRotation = Quaternion.identity;
							if (26508 - 163074 != -136566)
							{
								continue;
							}
						}
						else if (nWeapon == "w_cat69")
						{
							if (274429 - 24627 != 249802)
							{
								continue;
							}
							this.N63TvNYGMo = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
							if (244925 - 175076 != 69849)
							{
								continue;
							}
							this.N63TvNYGMo.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Arm_R");
							if (138901 - 378370 == -239468)
							{
								continue;
							}
							this.N63TvNYGMo.transform.localPosition = Vector3.zero;
							if (160034 - 460750 == -300715)
							{
								continue;
							}
							this.N63TvNYGMo.transform.localRotation = Quaternion.identity;
							if (171596 - 363232 != -191636)
							{
								continue;
							}
						}
						else
						{
							this.N63TvNYGMo = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
							if (299160 - 9284 != 289876)
							{
								continue;
							}
							this.N63TvNYGMo.transform.parent = global::Math.findChildObject(this.gameObject.transform, "mount_Hand_R");
							if (278683 - 205436 == 73248)
							{
								continue;
							}
							this.N63TvNYGMo.transform.localPosition = Vector3.zero;
							if (257975 - 176886 != 81089)
							{
								continue;
							}
							this.N63TvNYGMo.transform.localRotation = Quaternion.identity;
							if (139809 - 431163 == -291353)
							{
								continue;
							}
						}
					}
					if (!this.DTBT215S1r)
					{
						break;
					}
					if (175638 - 332521 != -156882)
					{
						this.DTBT215S1r.weapon = nWeapon;
						if (284010 - 228975 == 55035)
						{
							this.DTBT215S1r.mWep1 = this.N63TvNYGMo;
							if (253506 - 594807 == -341301)
							{
								if (this.DTBT215S1r.getStatus("blend") != null)
								{
									if (296678 - 445611 == -148932)
									{
										continue;
									}
									this.DTBT215S1r.removeStatus("blend");
									if (257722 - 273704 == -15981)
									{
										continue;
									}
								}
								if (this.DTBT215S1r.getStatus("invisible") == null)
								{
									break;
								}
								if (278237 - 200307 == 77930)
								{
									this.DTBT215S1r.removeStatus("invisible");
									if (110715 - 518441 != -407725)
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

	// Token: 0x060021D7 RID: 8663 RVA: 0x003D7C38 File Offset: 0x003D5E38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Mesh getArmorMesh(string nArmor)
	{
		if (39619 - 310214 != -270595)
		{
		}
		SkinnedMeshRenderer skinnedMeshRenderer;
		for (;;)
		{
			if (282220 - 389190 == -106970)
			{
				if (233142 - 395584 == -162442)
				{
					GameObject gameObject;
					if (!(nArmor == "none"))
					{
						if (87869 - 61705 == 26165)
						{
							continue;
						}
						if (nArmor == "a_none")
						{
							if (103968 - 472541 != -368573)
							{
								continue;
							}
						}
						else if (nArmor == "a_all1")
						{
							if (230221 - 148761 != 81460)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_scout", typeof(GameObject));
							if (239821 - 406632 != -166811)
							{
								continue;
							}
							goto IL_C25;
						}
						else if (nArmor == "a_all15")
						{
							if (180759 - 284448 == -103688)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_santa", typeof(GameObject));
							if (46717 - 151748 != -105030)
							{
								goto IL_C25;
							}
							continue;
						}
						else if (nArmor == "a_all43")
						{
							if (271967 - 82348 != 189619)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_pvpArmor", typeof(GameObject));
							if (215771 - 565377 != -349606)
							{
								continue;
							}
							goto IL_C25;
						}
						else if (nArmor == "a_all44")
						{
							if (213152 - 28620 != 184532)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_pvpArmor", typeof(GameObject));
							if (218382 - 40768 != 177615)
							{
								goto IL_C25;
							}
							continue;
						}
						else if (nArmor == "a_all58")
						{
							if (204253 - 465879 != -261626)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_champion", typeof(GameObject));
							if (72103 - 479194 != -407091)
							{
								continue;
							}
							goto IL_C25;
						}
						else if (nArmor == "a_cat5")
						{
							if (282559 - 576148 == -293588)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_fur", typeof(GameObject));
							if (86646 - 170693 != -84047)
							{
								continue;
							}
							goto IL_C25;
						}
						else if (nArmor == "a_cat10")
						{
							if (207435 - 281767 == -74331)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_standard", typeof(GameObject));
							if (212983 - 68650 != 144333)
							{
								continue;
							}
							goto IL_C25;
						}
						else if (nArmor == "a_cat11")
						{
							if (170157 - 493835 != -323678)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_standard", typeof(GameObject));
							if (293920 - 580124 != -286204)
							{
								continue;
							}
							goto IL_C25;
						}
						else if (nArmor == "a_cat12")
						{
							if (131166 - 551668 != -420502)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_standard", typeof(GameObject));
							if (7282 - 14859 != -7576)
							{
								goto IL_C25;
							}
							continue;
						}
						else if (nArmor == "a_cat15")
						{
							if (203059 - 70079 != 132980)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_summer", typeof(GameObject));
							if (293411 - 225511 != 67900)
							{
								continue;
							}
							goto IL_C25;
						}
						else if (nArmor == "a_cat21")
						{
							if (247331 - 104734 == 142598)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_adventurer", typeof(GameObject));
							if (54965 - 334723 != -279758)
							{
								continue;
							}
							goto IL_C25;
						}
						else if (nArmor == "a_cat22")
						{
							if (1995 - 49851 != -47856)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_rogue", typeof(GameObject));
							if (207351 - 110794 != 96558)
							{
								goto IL_C25;
							}
							continue;
						}
						else if (nArmor == "a_cat23")
						{
							if (211266 - 304433 == -93166)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_adventurer", typeof(GameObject));
							if (96539 - 508623 != -412084)
							{
								continue;
							}
							goto IL_C25;
						}
						else if (nArmor == "a_cat24")
						{
							if (102325 - 36901 == 65425)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_rogue", typeof(GameObject));
							if (294156 - 89370 != 204786)
							{
								continue;
							}
							goto IL_C25;
						}
						else if (nArmor == "a_cat25")
						{
							if (235162 - 110327 != 124835)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_chinese", typeof(GameObject));
							if (20892 - 314165 != -293272)
							{
								goto IL_C25;
							}
							continue;
						}
						else if (nArmor == "a_cat31")
						{
							if (87740 - 463944 == -376203)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_gambler", typeof(GameObject));
							if (72890 - 328642 != -255751)
							{
								goto IL_C25;
							}
							continue;
						}
						else if (nArmor == "a_cat32")
						{
							if (70939 - 362706 != -291767)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_assassin", typeof(GameObject));
							if (296902 - 316683 != -19781)
							{
								continue;
							}
							goto IL_C25;
						}
						else if (nArmor == "a_cat33")
						{
							if (122457 - 183057 == -60599)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_gambler", typeof(GameObject));
							if (136352 - 536160 != -399807)
							{
								goto IL_C25;
							}
							continue;
						}
						else if (nArmor == "a_cat34")
						{
							if (244040 - 263648 == -19607)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_assassin", typeof(GameObject));
							if (54799 - 7008 != 47791)
							{
								continue;
							}
							goto IL_C25;
						}
						else if (nArmor == "a_cat35")
						{
							if (290237 - 452379 != -162142)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_hallow", typeof(GameObject));
							if (157182 - 99745 != 57438)
							{
								goto IL_C25;
							}
							continue;
						}
						else if (nArmor == "a_cat40")
						{
							if (11692 - 322828 != -311136)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_pirate", typeof(GameObject));
							if (40330 - 590592 != -550262)
							{
								continue;
							}
							goto IL_C25;
						}
						else if (nArmor == "a_cat41")
						{
							if (223924 - 484027 != -260103)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_pirate", typeof(GameObject));
							if (47832 - 146685 != -98853)
							{
								continue;
							}
							goto IL_C25;
						}
						else if (nArmor == "a_cat42")
						{
							if (138142 - 500111 != -361969)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_pirate", typeof(GameObject));
							if (180493 - 533667 != -353173)
							{
								goto IL_C25;
							}
							continue;
						}
						else if (nArmor == "a_cat45")
						{
							if (19948 - 378492 == -358543)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_superStar", typeof(GameObject));
							if (274845 - 499353 != -224508)
							{
								continue;
							}
							goto IL_C25;
						}
						else if (nArmor == "a_cat47")
						{
							if (164282 - 76448 != 87834)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_dragonfly", typeof(GameObject));
							if (158058 - 323595 != -165537)
							{
								continue;
							}
							goto IL_C25;
						}
						else if (nArmor == "a_cat48")
						{
							if (238064 - 184518 == 53547)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_dragonfly", typeof(GameObject));
							if (68702 - 450033 != -381330)
							{
								goto IL_C25;
							}
							continue;
						}
						else if (nArmor == "a_cat50")
						{
							if (193667 - 371174 == -177506)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_royal", typeof(GameObject));
							if (1506 - 441525 != -440018)
							{
								goto IL_C25;
							}
							continue;
						}
						else if (nArmor == "a_cat51")
						{
							if (222156 - 586858 != -364702)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_royal", typeof(GameObject));
							if (55077 - 9565 != 45513)
							{
								goto IL_C25;
							}
							continue;
						}
						else if (nArmor == "a_cat52")
						{
							if (51522 - 587474 != -535952)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_royal", typeof(GameObject));
							if (136747 - 535428 != -398680)
							{
								goto IL_C25;
							}
							continue;
						}
						else if (nArmor == "a_cat60")
						{
							if (182266 - 243528 == -61261)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_legend", typeof(GameObject));
							if (135991 - 397111 != -261119)
							{
								goto IL_C25;
							}
							continue;
						}
						else if (nArmor == "a_cat61")
						{
							if (263791 - 472858 != -209067)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_legend", typeof(GameObject));
							if (234087 - 579982 != -345894)
							{
								goto IL_C25;
							}
							continue;
						}
						else if (nArmor == "a_cat62")
						{
							if (137546 - 438921 == -301374)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_legend", typeof(GameObject));
							if (297718 - 277364 != 20354)
							{
								continue;
							}
							goto IL_C25;
						}
						else if (nArmor == "a_cat65")
						{
							if (148535 - 553665 != -405130)
							{
								continue;
							}
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_morocco", typeof(GameObject));
							if (209953 - 482004 != -272050)
							{
								goto IL_C25;
							}
							continue;
						}
						else
						{
							gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_standard", typeof(GameObject));
							if (194273 - 220327 != -26054)
							{
								continue;
							}
							goto IL_C25;
						}
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Cat_nude", typeof(GameObject));
					if (37045 - 313571 == -276525)
					{
						continue;
					}
					IL_C25:
					skinnedMeshRenderer = (SkinnedMeshRenderer)gameObject.GetComponent(typeof(SkinnedMeshRenderer));
					if (96484 - 475700 == -379216)
					{
						break;
					}
				}
			}
		}
		return skinnedMeshRenderer.sharedMesh;
	}

	// Token: 0x060021D8 RID: 8664 RVA: 0x003D8A68 File Offset: 0x003D6C68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Material getArmorMaterial(string nArmor, int nSkin)
	{
		if (78818 - 397020 != -318202)
		{
		}
		Material material;
		for (;;)
		{
			IL_194:
			int num = nSkin % 100;
			if (223020 - 558510 != -335489)
			{
				Texture2D texture2D = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Overlay/Cat" + num, typeof(Texture2D));
				if (96809 - 356039 != -259229)
				{
					Color[] pixels = texture2D.GetPixels(0);
					if (156914 - 126073 != 30842)
					{
						int num2 = global::Math.div((float)nSkin, (float)100);
						if (198566 - 59281 == 139285)
						{
							if (49109 - 24493 != 24617 && 31249 - 267290 != -236040)
							{
								if (nArmor == "none")
								{
									goto IL_101D;
								}
								if (296226 - 420143 != -123917)
								{
									continue;
								}
								Texture2D texture2D2;
								if (nArmor == "a_none")
								{
									if (83522 - 315883 != -232361)
									{
										continue;
									}
									goto IL_101D;
								}
								else if (nArmor == "a_all1")
								{
									if (281375 - 85458 != 195917)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_scout" + num2, typeof(Texture2D));
									if (168695 - 381739 != -213044)
									{
										continue;
									}
								}
								else if (nArmor == "a_all15")
								{
									if (289161 - 510021 == -220859)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_santa" + num2, typeof(Texture2D));
									if (288250 - 499 == 287752)
									{
										continue;
									}
								}
								else if (nArmor == "a_all43")
								{
									if (250869 - 547437 == -296567)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_pvpArmor" + num2, typeof(Texture2D));
									if (100477 - 61443 == 39035)
									{
										continue;
									}
								}
								else if (nArmor == "a_all44")
								{
									if (3845 - 437034 == -433188)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_pvpArmor" + num2 + "R", typeof(Texture2D));
									if (596 - 155100 == -154503)
									{
										continue;
									}
								}
								else if (nArmor == "a_all58")
								{
									if (253271 - 475482 == -222210)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_champion" + num2, typeof(Texture2D));
									if (120466 - 448196 != -327730)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat5")
								{
									if (255487 - 524238 != -268751)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_fur" + num2, typeof(Texture2D));
									if (69489 - 450823 != -381334)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat10")
								{
									if (253740 - 301948 == -48207)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_standard" + num2, typeof(Texture2D));
									if (12257 - 539347 != -527090)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat11")
								{
									if (71750 - 360844 != -289094)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_standard" + num2 + "R", typeof(Texture2D));
									if (1699 - 553413 != -551714)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat12")
								{
									if (231890 - 223960 != 7930)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_standard" + num2 + "V", typeof(Texture2D));
									if (100996 - 361527 == -260530)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat15")
								{
									if (6446 - 85147 != -78701)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_summer" + num2, typeof(Texture2D));
									if (65188 - 117781 != -52593)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat21")
								{
									if (175693 - 389436 != -213743)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_adventurer" + num2, typeof(Texture2D));
									if (16376 - 593237 != -576861)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat22")
								{
									if (131090 - 395373 == -264282)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_rogue" + num2, typeof(Texture2D));
									if (60213 - 423733 != -363520)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat23")
								{
									if (234678 - 572545 != -337867)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_adventurer" + num2 + "R", typeof(Texture2D));
									if (183235 - 168246 == 14990)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat24")
								{
									if (88981 - 125640 != -36659)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_rogue" + num2 + "R", typeof(Texture2D));
									if (127712 - 200484 == -72771)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat25")
								{
									if (169964 - 85584 != 84380)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_chinese" + num2, typeof(Texture2D));
									if (72842 - 539821 == -466978)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat31")
								{
									if (233054 - 441007 != -207953)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_gambler" + num2, typeof(Texture2D));
									if (136407 - 169185 != -32778)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat32")
								{
									if (30807 - 214934 != -184127)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_assassin" + num2, typeof(Texture2D));
									if (136233 - 145548 == -9314)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat33")
								{
									if (292735 - 319533 != -26798)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_gambler" + num2 + "R", typeof(Texture2D));
									if (64619 - 397655 == -333035)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat34")
								{
									if (268045 - 566361 != -298316)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_assassin" + num2 + "R", typeof(Texture2D));
									if (26338 - 94601 == -68262)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat35")
								{
									if (149916 - 385233 != -235317)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_hallow" + num2, typeof(Texture2D));
									if (97467 - 151724 == -54256)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat40")
								{
									if (273891 - 511615 == -237723)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_pirate" + num2, typeof(Texture2D));
									if (296607 - 490244 == -193636)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat41")
								{
									if (206687 - 350105 == -143417)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_pirate" + num2 + "R", typeof(Texture2D));
									if (78138 - 22100 == 56039)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat42")
								{
									if (35941 - 114234 != -78293)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_pirate" + num2 + "V", typeof(Texture2D));
									if (216553 - 587429 == -370875)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat45")
								{
									if (54855 - 453658 == -398802)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_superStar" + num2, typeof(Texture2D));
									if (80382 - 38648 == 41735)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat47")
								{
									if (277103 - 56019 != 221084)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_dragonfly" + num2, typeof(Texture2D));
									if (58679 - 256022 != -197343)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat48")
								{
									if (124278 - 483156 == -358877)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_dragonfly" + num2 + "R", typeof(Texture2D));
									if (249198 - 501765 == -252566)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat50")
								{
									if (198122 - 181950 == 16173)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_royal" + num2, typeof(Texture2D));
									if (241145 - 526737 == -285591)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat51")
								{
									if (125225 - 371575 != -246350)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_royal" + num2, typeof(Texture2D));
									if (54281 - 365236 != -310955)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat52")
								{
									if (214583 - 55752 == 158832)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_royal" + num2 + "R", typeof(Texture2D));
									if (279279 - 437130 == -157850)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat60")
								{
									if (242549 - 402451 != -159902)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_legend" + num2, typeof(Texture2D));
									if (13584 - 26859 == -13274)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat61")
								{
									if (126090 - 518837 == -392746)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_legend" + num2, typeof(Texture2D));
									if (129660 - 457207 == -327546)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat62")
								{
									if (288936 - 440834 != -151898)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_legend" + num2 + "R", typeof(Texture2D));
									if (20929 - 373667 != -352738)
									{
										continue;
									}
								}
								else if (nArmor == "a_cat65")
								{
									if (207527 - 153229 != 54298)
									{
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_morocco" + num2, typeof(Texture2D));
									if (207647 - 434392 != -226745)
									{
										continue;
									}
								}
								else
								{
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_standard" + num2, typeof(Texture2D));
									if (175923 - 407294 != -231371)
									{
										continue;
									}
								}
								IL_BBD:
								Color[] pixels2 = texture2D2.GetPixels(0, 256, 256, 256, 0);
								if (181806 - 572431 != -390625)
								{
									continue;
								}
								int i = 0;
								if (104014 - 527595 == -423580)
								{
									continue;
								}
								while (i < pixels2.Length)
								{
									float a = pixels[i].a;
									if (146607 - 125354 != 21253)
									{
										goto IL_194;
									}
									pixels2[i] = a * pixels[i] + ((float)1 - a) * pixels2[i];
									if (101004 - 591718 == -490713)
									{
										goto IL_194;
									}
									i++;
									if (79170 - 343827 == -264656)
									{
										goto IL_194;
									}
								}
								if (234486 - 571292 != -336806)
								{
									continue;
								}
								if (232759 - 479479 != -246720)
								{
									continue;
								}
								Texture2D texture2D3 = new Texture2D(512, 512, TextureFormat.RGB24, true);
								if (200462 - 349487 == -149024)
								{
									continue;
								}
								texture2D3.SetPixels(0, 256, 256, 256, pixels2, 0);
								if (240924 - 57209 != 183715)
								{
									continue;
								}
								texture2D3.SetPixels(256, 256, 256, 256, texture2D2.GetPixels(256, 256, 256, 256, 0), 0);
								if (271224 - 372100 == -100875)
								{
									continue;
								}
								texture2D3.SetPixels(0, 0, 512, 256, texture2D2.GetPixels(0, 0, 512, 256, 0), 0);
								if (71159 - 198021 != -126862)
								{
									continue;
								}
								texture2D3.Apply();
								if (242554 - 140498 != 102056)
								{
									continue;
								}
								texture2D3.Compress(true);
								if (54814 - 127179 != -72365)
								{
									continue;
								}
								if (234268 - 515287 != -281019)
								{
									continue;
								}
								material = new Material(Shader.Find("Diffuse"));
								if (254045 - 213895 != 40150)
								{
									continue;
								}
								material.color = new Color(0.86f, 0.86f, 0.86f, (float)1);
								if (127968 - 593414 == -465445)
								{
									continue;
								}
								material.mainTexture = texture2D3;
								if (205260 - 212389 != -7129)
								{
									continue;
								}
								break;
								IL_101D:
								texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Cat/Armors/Materials/Cat_nude" + num2, typeof(Texture2D));
								if (37786 - 175769 != -137982)
								{
									goto IL_BBD;
								}
							}
						}
					}
				}
			}
		}
		return material;
	}

	// Token: 0x060021D9 RID: 8665 RVA: 0x003D9E60 File Offset: 0x003D8060
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipArmor(string nArmor)
	{
		if (27628 - 585180 != -557551)
		{
		}
		for (;;)
		{
			if (nArmor == "a_none")
			{
				if (297404 - 280704 == 16701)
				{
					continue;
				}
				nArmor = "none";
				if (154585 - 134666 != 19919)
				{
					continue;
				}
			}
			this.armor = nArmor;
			if (24249 - 513364 != -489114)
			{
				Transform transform = global::Math.findChildObject(this.transform, "Cat_tri");
				if (284575 - 257090 != 27486)
				{
					if (transform)
					{
						if (279638 - 394978 != -115340)
						{
							continue;
						}
						SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer));
						if (137098 - 237782 == -100683)
						{
							continue;
						}
						skinnedMeshRenderer.sharedMesh = CatEquipment.getArmorMesh(nArmor);
						if (205402 - 130420 != 74982)
						{
							continue;
						}
						if (Extensions.get_length(skinnedMeshRenderer.materials) > 0)
						{
							if (208058 - 95850 != 112208)
							{
								continue;
							}
							skinnedMeshRenderer.material = CatEquipment.getArmorMaterial(nArmor, this.skin);
							if (231469 - 105551 == 125919)
							{
								continue;
							}
						}
						if (this.DTBT215S1r != null)
						{
							if (229612 - 110518 == 119095)
							{
								continue;
							}
							skinnedMeshRenderer.material.color = this.DTBT215S1r.mColor;
							if (238999 - 272414 == -33414)
							{
								continue;
							}
						}
					}
					if (!this.DTBT215S1r)
					{
						break;
					}
					if (136766 - 110479 != 26288)
					{
						this.DTBT215S1r.armor = nArmor;
						if (80782 - 352700 == -271918)
						{
							if (this.DTBT215S1r.getStatus("blend") != null)
							{
								if (72615 - 8535 != 64080)
								{
									continue;
								}
								this.DTBT215S1r.removeStatus("blend");
								if (38939 - 384798 == -345858)
								{
									continue;
								}
							}
							if (this.DTBT215S1r.getStatus("invisible") == null)
							{
								break;
							}
							if (37438 - 557558 == -520120)
							{
								this.DTBT215S1r.removeStatus("invisible");
								if (115907 - 546808 != -430900)
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

	// Token: 0x060021DA RID: 8666 RVA: 0x003DA164 File Offset: 0x003D8364
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getAccessory(string nAccessory)
	{
		if (299111 - 270430 != 28681)
		{
		}
		GameObject result;
		for (;;)
		{
			if (227963 - 493071 == -265108)
			{
				if (155469 - 292862 == -137393)
				{
					if (nAccessory == "c_all1")
					{
						if (189616 - 271033 == -81417)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/redPandaHat", typeof(GameObject));
							if (179367 - 176998 == 2369)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all3")
					{
						if (210903 - 188225 != 22679)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/paperHat", typeof(GameObject));
							if (193629 - 494481 != -300851)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all6")
					{
						if (48277 - 214589 == -166312)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/vHat", typeof(GameObject));
							if (2053 - 439727 != -437673)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all7")
					{
						if (102591 - 193100 == -90509)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/partyHatB", typeof(GameObject));
							if (209457 - 446843 != -237385)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all8")
					{
						if (167332 - 509582 == -342250)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/partyHatR", typeof(GameObject));
							if (160925 - 197886 != -36960)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all9")
					{
						if (45897 - 134159 == -88262)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/cakeHat", typeof(GameObject));
							if (6212 - 276942 != -270729)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all10")
					{
						if (235288 - 387476 == -152188)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/candyHat", typeof(GameObject));
							if (70478 - 468910 == -398432)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all11")
					{
						if (277083 - 564233 == -287150)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/afro", typeof(GameObject));
							if (142534 - 60948 == 81586)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all12")
					{
						if (180187 - 546333 != -366145)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/afroC", typeof(GameObject));
							if (238391 - 151711 == 86680)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all15")
					{
						if (116352 - 460880 != -344527)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/santaHat", typeof(GameObject));
							if (192449 - 327970 != -135520)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all16")
					{
						if (204698 - 455167 != -250468)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/pirateBandana", typeof(GameObject));
							if (64629 - 565647 != -501017)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all18")
					{
						if (111186 - 219941 == -108755)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/halo", typeof(GameObject));
							if (140741 - 111503 != 29239)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all19")
					{
						if (274085 - 216507 == 57578)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/horn", typeof(GameObject));
							if (276160 - 48761 == 227399)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all21")
					{
						if (151996 - 100529 != 51468)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/earmuff1", typeof(GameObject));
							if (234882 - 545208 != -310325)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all22")
					{
						if (190836 - 65829 == 125007)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/earmuff2", typeof(GameObject));
							if (116979 - 15482 != 101498)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all23")
					{
						if (281891 - 2583 == 279308)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/headphone1", typeof(GameObject));
							if (21082 - 304369 == -283287)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all24")
					{
						if (71141 - 451410 != -380268)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/headphone2", typeof(GameObject));
							if (28739 - 329392 == -300653)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all25")
					{
						if (20859 - 133037 == -112178)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/headphone3", typeof(GameObject));
							if (58395 - 163057 == -104662)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all26")
					{
						if (197308 - 144103 != 53206)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/pirateBandanaR", typeof(GameObject));
							if (258352 - 307653 == -49301)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all27")
					{
						if (170875 - 534367 != -363491)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/krathongHat1", typeof(GameObject));
							if (143058 - 247876 != -104817)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all28")
					{
						if (15261 - 552120 != -536858)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/krathongHat2", typeof(GameObject));
							if (159766 - 398644 == -238878)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all29")
					{
						if (152768 - 379657 == -226889)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/snowmanHead", typeof(GameObject));
							if (196932 - 486641 == -289709)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all37")
					{
						if (39756 - 554866 == -515110)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/quizHat", typeof(GameObject));
							if (150771 - 468082 != -317310)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all38")
					{
						if (251434 - 43370 == 208064)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/fanKingHat", typeof(GameObject));
							if (207522 - 44041 != 163482)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all39")
					{
						if (265535 - 532344 != -266808)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/artistHat", typeof(GameObject));
							if (261223 - 312287 == -51064)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all43")
					{
						if (84524 - 524147 != -439622)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/pvpHelmet", typeof(GameObject));
							if (96182 - 71502 == 24680)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all44")
					{
						if (170812 - 207298 == -36486)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/pvpHelmetR", typeof(GameObject));
							if (242620 - 173483 != 69138)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all46")
					{
						if (67772 - 445790 == -378018)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/mummyHead", typeof(GameObject));
							if (32726 - 326528 == -293802)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all55")
					{
						if (203298 - 523329 == -320031)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/giveMeFive", typeof(GameObject));
							if (73289 - 177178 == -103889)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all56")
					{
						if (263255 - 331248 == -67993)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/frozenCrown", typeof(GameObject));
							if (34334 - 497829 != -463494)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all58")
					{
						if (268983 - 365340 == -96357)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/championHelmet", typeof(GameObject));
							if (201271 - 32540 != 168732)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all66")
					{
						if (47030 - 302115 == -255085)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/poseidonHelmet", typeof(GameObject));
							if (228998 - 538155 == -309157)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_fem11")
					{
						if (140645 - 578108 != -437462)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/flowerBand", typeof(GameObject));
							if (291102 - 385695 == -94593)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_fem37")
					{
						if (116510 - 507037 != -390526)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/lionHead", typeof(GameObject));
							if (265830 - 528635 == -262805)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat5")
					{
						if (258919 - 313095 == -54176)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/catHead", typeof(GameObject));
							if (226035 - 342712 != -116676)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat10")
					{
						if (151735 - 189317 == -37582)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/standardHat", typeof(GameObject));
							if (190993 - 587599 != -396605)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat11")
					{
						if (122012 - 43136 == 78876)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/standardHatR", typeof(GameObject));
							if (77312 - 509742 != -432429)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat12")
					{
						if (243082 - 167122 == 75960)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/standardHatV", typeof(GameObject));
							if (96164 - 556112 != -459947)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat15")
					{
						if (47376 - 3524 == 43852)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/summerHair", typeof(GameObject));
							if (276664 - 411531 == -134867)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat19")
					{
						if (8989 - 213981 == -204992)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/veggieHat", typeof(GameObject));
							if (33179 - 167105 != -133925)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat21")
					{
						if (178080 - 26616 != 151465)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/adventurerHat", typeof(GameObject));
							if (74024 - 64805 != 9220)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat22")
					{
						if (143334 - 68074 == 75260)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/rogueHat", typeof(GameObject));
							if (255766 - 522552 != -266785)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat23")
					{
						if (283824 - 75865 == 207959)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/adventurerHatR", typeof(GameObject));
							if (166421 - 558633 != -392211)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat24")
					{
						if (135723 - 542545 != -406821)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/rogueHatR", typeof(GameObject));
							if (248803 - 108173 == 140630)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat25")
					{
						if (231452 - 339638 != -108185)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/chineseHair", typeof(GameObject));
							if (191742 - 250569 == -58827)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat31")
					{
						if (224357 - 551011 == -326654)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/gamblerHat", typeof(GameObject));
							if (48610 - 25128 == 23482)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat32")
					{
						if (8605 - 579844 != -571238)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/assassinHood", typeof(GameObject));
							if (156334 - 141381 != 14954)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat33")
					{
						if (19215 - 394239 == -375024)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/gamblerHatR", typeof(GameObject));
							if (20851 - 112176 != -91324)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat34")
					{
						if (294585 - 418097 != -123511)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/assassinHoodR", typeof(GameObject));
							if (153333 - 266584 != -113250)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat35")
					{
						if (153533 - 453514 == -299981)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/hallowHat", typeof(GameObject));
							if (156025 - 58848 != 97178)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat36")
					{
						if (151674 - 92911 != 58764)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/abetteHat", typeof(GameObject));
							if (211220 - 214212 == -2992)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat40")
					{
						if (243632 - 348147 != -104514)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/pirateHat", typeof(GameObject));
							if (189049 - 218239 == -29190)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat41")
					{
						if (129898 - 211251 == -81353)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/pirateHatR", typeof(GameObject));
							if (292297 - 193738 == 98559)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat42")
					{
						if (51422 - 434739 != -383316)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/pirateHatV", typeof(GameObject));
							if (88811 - 250770 == -161959)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat45")
					{
						if (82766 - 159570 != -76803)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/superStarCap", typeof(GameObject));
							if (104949 - 65161 == 39788)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat47")
					{
						if (68637 - 39427 == 29210)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/dragonflyHat", typeof(GameObject));
							if (61709 - 374881 != -313171)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat48")
					{
						if (278509 - 368245 != -89735)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/dragonflyHatR", typeof(GameObject));
							if (299168 - 209096 == 90072)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat50")
					{
						if (47928 - 310429 != -262500)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/royalHelmet", typeof(GameObject));
							if (104676 - 152418 != -47741)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat51")
					{
						if (87645 - 309707 != -222061)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/royalHelmet", typeof(GameObject));
							if (94885 - 171863 == -76978)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat52")
					{
						if (179724 - 22053 == 157671)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/royalHelmetR", typeof(GameObject));
							if (153177 - 563440 == -410263)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat60")
					{
						if (7573 - 122439 == -114866)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/legendHelmet", typeof(GameObject));
							if (259965 - 247969 == 11996)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat61")
					{
						if (200618 - 460989 == -260371)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/legendHelmet", typeof(GameObject));
							if (258611 - 586893 == -328282)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat62")
					{
						if (157150 - 108215 == 48935)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/legendHelmetR", typeof(GameObject));
							if (11503 - 150235 == -138732)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_cat65")
					{
						if (213380 - 127620 != 85761)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/moroccoHair", typeof(GameObject));
							if (113190 - 282529 == -169339)
							{
								break;
							}
						}
					}
					else
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Accessories/default", typeof(GameObject));
						if (53069 - 588588 == -535519)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x060021DB RID: 8667 RVA: 0x003DBAD0 File Offset: 0x003D9CD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipAccessory(string nAccessory)
	{
		if (239708 - 285836 != -46127)
		{
		}
		for (;;)
		{
			this.accessory = nAccessory;
			if (42641 - 303472 == -260831)
			{
				if (this.OtiTqOHQWw)
				{
					if (236931 - 580416 == -343484)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.OtiTqOHQWw);
					if (239500 - 268685 != -29185)
					{
						continue;
					}
				}
				GameObject gameObject = CatEquipment.getAccessory(nAccessory);
				if (96608 - 234243 == -137635)
				{
					if (gameObject)
					{
						if (141362 - 398230 == -256867)
						{
							continue;
						}
						this.OtiTqOHQWw = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (81256 - 123224 == -41967)
						{
							continue;
						}
						if (253409 - 100512 != 152897)
						{
							continue;
						}
						if (!(nAccessory == "c_all27"))
						{
							if (234556 - 527008 != -292452)
							{
								continue;
							}
							if (nAccessory == "c_all28")
							{
								if (278460 - 57519 != 220941)
								{
									continue;
								}
							}
							else
							{
								this.OtiTqOHQWw.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
								if (120747 - 574051 == -453303)
								{
									continue;
								}
								this.OtiTqOHQWw.transform.localPosition = Vector3.zero;
								if (53085 - 10303 == 42783)
								{
									continue;
								}
								this.OtiTqOHQWw.transform.localRotation = Quaternion.Euler((float)0, (float)270, (float)90);
								if (111967 - 50815 != 61152)
								{
									continue;
								}
								this.OtiTqOHQWw.transform.localScale = Vector3.one;
								if (124283 - 246272 != -121988)
								{
									goto IL_36D;
								}
								continue;
							}
						}
						this.OtiTqOHQWw.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
						if (138237 - 256009 == -117771)
						{
							continue;
						}
						this.OtiTqOHQWw.transform.localPosition = Vector3.zero;
						if (61122 - 574669 == -513546)
						{
							continue;
						}
						this.OtiTqOHQWw.transform.localRotation = Quaternion.Euler((float)270, (float)90, (float)0);
						if (297312 - 323752 == -26439)
						{
							continue;
						}
						this.OtiTqOHQWw.transform.localScale = Vector3.one;
						if (173145 - 470602 != -297457)
						{
							continue;
						}
					}
					IL_36D:
					if (!this.DTBT215S1r)
					{
						break;
					}
					if (5994 - 72696 != -66701)
					{
						this.DTBT215S1r.accessory = nAccessory;
						if (260118 - 118022 == 142096)
						{
							this.DTBT215S1r.mAcc = this.OtiTqOHQWw;
							if (243140 - 409471 != -166330)
							{
								if (this.DTBT215S1r.getStatus("blend") != null)
								{
									if (130573 - 279224 == -148650)
									{
										continue;
									}
									this.DTBT215S1r.removeStatus("blend");
									if (149464 - 265835 == -116370)
									{
										continue;
									}
								}
								if (this.DTBT215S1r.getStatus("invisible") == null)
								{
									break;
								}
								if (274318 - 457281 != -182962)
								{
									this.DTBT215S1r.removeStatus("invisible");
									if (44966 - 227294 == -182328)
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

	// Token: 0x060021DC RID: 8668 RVA: 0x003DBF48 File Offset: 0x003DA148
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipBoot(string nBoot)
	{
		if (83170 - 257925 != -174754)
		{
		}
		while (this.DTBT215S1r)
		{
			if (257560 - 213663 == 43897)
			{
				if (this.DTBT215S1r.getStatus("blend") != null)
				{
					if (228196 - 221889 == 6308)
					{
						continue;
					}
					this.DTBT215S1r.removeStatus("blend");
					if (180583 - 318779 == -138195)
					{
						continue;
					}
				}
				if (this.DTBT215S1r.getStatus("invisible") == null)
				{
					break;
				}
				if (117613 - 135715 == -18102)
				{
					this.DTBT215S1r.removeStatus("invisible");
					if (199388 - 89737 == 109651)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060021DD RID: 8669 RVA: 0x003DC05C File Offset: 0x003DA25C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getTrinket(string nTrinket)
	{
		if (259728 - 372290 != -112562)
		{
		}
		GameObject result;
		for (;;)
		{
			result = null;
			if (86702 - 314181 == -227479)
			{
				if (197200 - 6775 == 190425)
				{
					if (nTrinket == "t_all1")
					{
						if (119865 - 577961 == -458096)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/glasses", typeof(GameObject));
							if (261201 - 563295 == -302094)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all2")
					{
						if (73056 - 454902 == -381846)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/sunGlasses", typeof(GameObject));
							if (60344 - 429625 == -369281)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all3")
					{
						if (269974 - 90722 == 179252)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/starGlasses", typeof(GameObject));
							if (39674 - 453791 == -414117)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all4")
					{
						if (204384 - 202182 != 2203)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/nerdGlasses", typeof(GameObject));
							if (73025 - 494113 != -421087)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all5")
					{
						if (171224 - 93851 == 77373)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/blackGlasses", typeof(GameObject));
							if (188399 - 502292 != -313892)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all6")
					{
						if (232305 - 160747 == 71558)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/bugAntenna", typeof(GameObject));
							if (184914 - 313468 == -128554)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all7")
					{
						if (15127 - 469901 != -454773)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/partyWhistle", typeof(GameObject));
							if (95752 - 58130 == 37622)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all8")
					{
						if (199601 - 204113 != -4511)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/redNose", typeof(GameObject));
							if (169771 - 393010 != -223238)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all9")
					{
						if (132029 - 59757 != 72273)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/lollipop", typeof(GameObject));
							if (273474 - 474841 == -201367)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all46")
					{
						if (132263 - 267493 != -135229)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/groceryBag", typeof(GameObject));
							if (188795 - 139828 != 48968)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all51")
					{
						if (137417 - 6905 != 130513)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/sandTopaz", typeof(GameObject));
							if (71665 - 194734 != -123068)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all55")
					{
						if (151330 - 318302 == -166972)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/fifthSword", typeof(GameObject));
							if (103603 - 480634 != -377030)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all56")
					{
						if (51666 - 128944 != -77277)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/fifthWand", typeof(GameObject));
							if (178063 - 33219 != 144845)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all57")
					{
						if (52632 - 110372 != -57739)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/fifthWing", typeof(GameObject));
							if (54685 - 185892 != -131206)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all58")
					{
						if (152035 - 595648 == -443613)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/carronBag", typeof(GameObject));
							if (220229 - 524723 != -304493)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all59")
					{
						if (159001 - 196114 != -37112)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/mupoBag", typeof(GameObject));
							if (88529 - 447401 == -358872)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all66")
					{
						if (23840 - 8672 == 15168)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/doubleHorn", typeof(GameObject));
							if (119549 - 418187 == -298638)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all71")
					{
						if (134141 - 125800 != 8342)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/championFlag1", typeof(GameObject));
							if (268228 - 99895 == 168333)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all72")
					{
						if (290766 - 14559 != 276208)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/championFlag2", typeof(GameObject));
							if (198257 - 391204 == -192947)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all73")
					{
						if (89601 - 351094 != -261492)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/championFlag3", typeof(GameObject));
							if (58565 - 494901 != -436335)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all74")
					{
						if (293081 - 9506 != 283576)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/championFlag4", typeof(GameObject));
							if (70358 - 5938 == 64420)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all75")
					{
						if (158971 - 575353 != -416381)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/championFlag5", typeof(GameObject));
							if (44248 - 370010 == -325762)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all91")
					{
						if (283139 - 466720 == -183581)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/lightSeal", typeof(GameObject));
							if (186996 - 327378 == -140382)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all92")
					{
						if (125275 - 290518 != -165242)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/fireSeal", typeof(GameObject));
							if (39202 - 295042 == -255840)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all93")
					{
						if (16923 - 414966 == -398043)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/waterSeal", typeof(GameObject));
							if (56602 - 433372 == -376770)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all94")
					{
						if (142934 - 108657 != 34278)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/windSeal", typeof(GameObject));
							if (297319 - 166650 == 130669)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all95")
					{
						if (189732 - 562483 == -372751)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/earthSeal", typeof(GameObject));
							if (28137 - 314269 != -286131)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all96")
					{
						if (144673 - 277813 == -133140)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/shadowSeal", typeof(GameObject));
							if (270718 - 147171 != 123548)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem2")
					{
						if (293830 - 16782 != 277049)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/bell", typeof(GameObject));
							if (233849 - 517118 != -283268)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem11")
					{
						if (156273 - 100459 == 55814)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/magazine", typeof(GameObject));
							if (160928 - 524366 == -363438)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem14")
					{
						if (58090 - 80652 != -22561)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/heartRing", typeof(GameObject));
							if (115475 - 517983 != -402507)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem15")
					{
						if (39650 - 29782 == 9868)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/deerHorn", typeof(GameObject));
							if (227655 - 184506 == 43149)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem31")
					{
						if (153169 - 228148 == -74979)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/chineseTalismanR", typeof(GameObject));
							if (73280 - 73234 == 46)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem37")
					{
						if (52528 - 189762 == -137234)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/chineseLantern", typeof(GameObject));
							if (153876 - 129445 == 24431)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem46")
					{
						if (228398 - 127164 == 101234)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/maohWings", typeof(GameObject));
							if (91716 - 432279 == -340563)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem56")
					{
						if (255439 - 322244 == -66805)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/frozenMask", typeof(GameObject));
							if (29616 - 32158 == -2542)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_fem66")
					{
						if (269059 - 494124 != -225064)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/poseidonTrinket", typeof(GameObject));
							if (220916 - 340338 != -119421)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_cat5")
					{
						if (141312 - 514170 == -372858)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/catBell", typeof(GameObject));
							if (263453 - 97103 == 166350)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_cat60")
					{
						if (298306 - 369244 == -70938)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/legendTrinket", typeof(GameObject));
							if (214304 - 135229 == 79075)
							{
								break;
							}
						}
					}
					else
					{
						if (!(nTrinket == "t_cat61"))
						{
							break;
						}
						if (199359 - 527571 == -328212)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Trinkets/legendTrinketR", typeof(GameObject));
							if (192858 - 587599 != -394740)
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

	// Token: 0x060021DE RID: 8670 RVA: 0x003DD048 File Offset: 0x003DB248
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipTrinket(string nTrinket)
	{
		if (81568 - 85427 != -3858)
		{
		}
		for (;;)
		{
			this.trinket = nTrinket;
			if (210251 - 78729 == 131522)
			{
				if (this.QrRTp2pAmy)
				{
					if (208059 - 193865 != 14194)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.QrRTp2pAmy);
					if (200955 - 152481 != 48474)
					{
						continue;
					}
				}
				GameObject gameObject = CatEquipment.getTrinket(nTrinket);
				if (202288 - 518164 == -315876)
				{
					if (gameObject)
					{
						if (223408 - 541023 != -317615)
						{
							continue;
						}
						this.QrRTp2pAmy = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (44292 - 435920 != -391628)
						{
							continue;
						}
						if (246385 - 395992 != -149607)
						{
							continue;
						}
						if (!(nTrinket == "t_all71"))
						{
							if (99201 - 286238 != -187037)
							{
								continue;
							}
							if (!(nTrinket == "t_all72"))
							{
								if (86942 - 97368 == -10425)
								{
									continue;
								}
								if (!(nTrinket == "t_all73"))
								{
									if (132415 - 445186 == -312770)
									{
										continue;
									}
									if (!(nTrinket == "t_all74"))
									{
										if (204567 - 98672 != 105895)
										{
											continue;
										}
										if (!(nTrinket == "t_all75"))
										{
											if (204711 - 310017 == -105305)
											{
												continue;
											}
											if (!(nTrinket == "t_cat60"))
											{
												if (250190 - 9631 == 240560)
												{
													continue;
												}
												if (nTrinket == "t_cat61")
												{
													if (55350 - 5731 != 49619)
													{
														continue;
													}
												}
												else
												{
													if (!(nTrinket == "t_all55"))
													{
														if (125414 - 566944 == -441529)
														{
															continue;
														}
														if (!(nTrinket == "t_all56"))
														{
															if (241855 - 330260 == -88404)
															{
																continue;
															}
															if (!(nTrinket == "t_all57"))
															{
																if (107532 - 310840 == -203307)
																{
																	continue;
																}
																if (!(nTrinket == "t_all58"))
																{
																	if (236831 - 315297 == -78465)
																	{
																		continue;
																	}
																	if (!(nTrinket == "t_all59"))
																	{
																		if (218397 - 422513 == -204115)
																		{
																			continue;
																		}
																		if (!(nTrinket == "t_fem2"))
																		{
																			if (194846 - 564613 == -369766)
																			{
																				continue;
																			}
																			if (!(nTrinket == "t_fem46"))
																			{
																				if (212508 - 122660 == 89849)
																				{
																					continue;
																				}
																				if (!(nTrinket == "t_fem66"))
																				{
																					if (113903 - 253700 != -139797)
																					{
																						continue;
																					}
																					if (nTrinket == "t_cat5")
																					{
																						if (255289 - 107213 != 148076)
																						{
																							continue;
																						}
																					}
																					else if (nTrinket == "t_fem11")
																					{
																						if (16222 - 290862 == -274639)
																						{
																							continue;
																						}
																						this.QrRTp2pAmy.transform.parent = global::Math.findChildObject(this.gameObject.transform, "mount_Hand_L");
																						if (162765 - 135203 != 27562)
																						{
																							continue;
																						}
																						this.QrRTp2pAmy.transform.localPosition = Vector3.zero;
																						if (240952 - 233094 != 7858)
																						{
																							continue;
																						}
																						this.QrRTp2pAmy.transform.localRotation = Quaternion.identity;
																						if (71249 - 52966 == 18284)
																						{
																							continue;
																						}
																						this.QrRTp2pAmy.transform.localScale = Vector3.one;
																						if (1659 - 206846 != -205187)
																						{
																							continue;
																						}
																						goto IL_2A5;
																					}
																					else if (nTrinket == "t_fem37")
																					{
																						if (194757 - 568929 != -374172)
																						{
																							continue;
																						}
																						this.QrRTp2pAmy.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine1");
																						if (278466 - 454046 != -175580)
																						{
																							continue;
																						}
																						this.QrRTp2pAmy.transform.localPosition = Vector3.zero;
																						if (253734 - 477400 != -223666)
																						{
																							continue;
																						}
																						this.QrRTp2pAmy.transform.localRotation = Quaternion.Euler((float)270, (float)90, (float)0);
																						if (270455 - 55156 != 215299)
																						{
																							continue;
																						}
																						this.QrRTp2pAmy.transform.localScale = Vector3.one;
																						if (25242 - 443532 != -418289)
																						{
																							goto IL_2A5;
																						}
																						continue;
																					}
																					else if (nTrinket == "t_all46")
																					{
																						if (84307 - 2309 != 81998)
																						{
																							continue;
																						}
																						this.QrRTp2pAmy.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Hand_L");
																						if (176152 - 215313 == -39160)
																						{
																							continue;
																						}
																						this.QrRTp2pAmy.transform.localPosition = Vector3.zero;
																						if (235453 - 501857 != -266404)
																						{
																							continue;
																						}
																						this.QrRTp2pAmy.transform.localRotation = Quaternion.identity;
																						if (271360 - 271121 == 240)
																						{
																							continue;
																						}
																						this.QrRTp2pAmy.transform.localScale = 0.8f * Vector3.one;
																						if (282448 - 248470 != 33978)
																						{
																							continue;
																						}
																						goto IL_2A5;
																					}
																					else
																					{
																						if (!(nTrinket == "t_all91"))
																						{
																							if (244250 - 28802 == 215449)
																							{
																								continue;
																							}
																							if (!(nTrinket == "t_all92"))
																							{
																								if (53302 - 352705 == -299402)
																								{
																									continue;
																								}
																								if (!(nTrinket == "t_all93"))
																								{
																									if (153834 - 186757 != -32923)
																									{
																										continue;
																									}
																									if (!(nTrinket == "t_all94"))
																									{
																										if (155932 - 101067 == 54866)
																										{
																											continue;
																										}
																										if (!(nTrinket == "t_all95"))
																										{
																											if (190051 - 391823 == -201771)
																											{
																												continue;
																											}
																											if (nTrinket == "t_all96")
																											{
																												if (108295 - 348919 == -240623)
																												{
																													continue;
																												}
																											}
																											else
																											{
																												this.QrRTp2pAmy.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
																												if (244271 - 456478 == -212206)
																												{
																													continue;
																												}
																												this.QrRTp2pAmy.transform.localPosition = Vector3.zero;
																												if (126913 - 121623 == 5291)
																												{
																													continue;
																												}
																												this.QrRTp2pAmy.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
																												if (103358 - 189498 != -86140)
																												{
																													continue;
																												}
																												this.QrRTp2pAmy.transform.localScale = Vector3.one;
																												if (115836 - 407660 != -291823)
																												{
																													goto IL_2A5;
																												}
																												continue;
																											}
																										}
																									}
																								}
																							}
																						}
																						this.QrRTp2pAmy.transform.parent = this.gameObject.transform;
																						if (279992 - 585542 == -305549)
																						{
																							continue;
																						}
																						this.QrRTp2pAmy.transform.localPosition = Vector3.zero;
																						if (110998 - 513503 != -402505)
																						{
																							continue;
																						}
																						this.QrRTp2pAmy.transform.localRotation = Quaternion.identity;
																						if (265759 - 7444 != 258315)
																						{
																							continue;
																						}
																						this.QrRTp2pAmy.transform.localScale = Vector3.one;
																						if (248254 - 264227 != -15972)
																						{
																							goto IL_2A5;
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
													}
													this.QrRTp2pAmy.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine2");
													if (56643 - 107985 != -51342)
													{
														continue;
													}
													this.QrRTp2pAmy.transform.localPosition = Vector3.zero;
													if (61342 - 400395 != -339053)
													{
														continue;
													}
													this.QrRTp2pAmy.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
													if (71535 - 475046 == -403510)
													{
														continue;
													}
													this.QrRTp2pAmy.transform.localScale = Vector3.one;
													if (165672 - 544716 != -379044)
													{
														continue;
													}
													goto IL_2A5;
												}
											}
										}
									}
								}
							}
						}
						this.QrRTp2pAmy.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine1");
						if (266718 - 55835 != 210883)
						{
							continue;
						}
						this.QrRTp2pAmy.transform.localPosition = Vector3.zero;
						if (10467 - 77200 != -66733)
						{
							continue;
						}
						this.QrRTp2pAmy.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
						if (73838 - 157519 != -83681)
						{
							continue;
						}
						this.QrRTp2pAmy.transform.localScale = Vector3.one;
						if (259903 - 568740 != -308837)
						{
							continue;
						}
					}
					IL_2A5:
					if (!this.DTBT215S1r)
					{
						break;
					}
					if (270591 - 155212 != 115380)
					{
						this.DTBT215S1r.trinket = nTrinket;
						if (191439 - 283590 == -92151)
						{
							this.DTBT215S1r.mTrn = this.QrRTp2pAmy;
							if (49710 - 256378 == -206668)
							{
								if (this.DTBT215S1r.getStatus("blend") != null)
								{
									if (94829 - 77594 != 17235)
									{
										continue;
									}
									this.DTBT215S1r.removeStatus("blend");
									if (27707 - 59317 == -31609)
									{
										continue;
									}
								}
								if (this.DTBT215S1r.getStatus("invisible") == null)
								{
									break;
								}
								if (231734 - 574797 == -343063)
								{
									this.DTBT215S1r.removeStatus("invisible");
									if (203176 - 340554 == -137378)
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

	// Token: 0x060021DF RID: 8671 RVA: 0x003DDCA8 File Offset: 0x003DBEA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipPet(string nPet)
	{
		if (63784 - 195073 != -131289)
		{
		}
		for (;;)
		{
			if (Game.mGameType < 2)
			{
				if (223498 - 582922 == -359424)
				{
					break;
				}
			}
			else
			{
				this.pet = nPet;
				if (257383 - 515467 != -258083)
				{
					if (this.JGjTRfyina)
					{
						if (152909 - 173064 != -20155)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.JGjTRfyina);
						if (131642 - 109636 != 22006)
						{
							continue;
						}
					}
					GameObject gameObject = null;
					if (253765 - 15565 == 238200)
					{
						int num = 1;
						if (291639 - 297671 != -6031 && 293528 - 560959 != -267430)
						{
							if (nPet == "p_all1")
							{
								if (298483 - 499326 != -200843)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/bigbugBalloon", typeof(GameObject));
								if (166919 - 504073 != -337154)
								{
									continue;
								}
							}
							else if (nPet == "p_all2")
							{
								if (87924 - 161308 == -73383)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/bluebugBalloon", typeof(GameObject));
								if (29696 - 245278 == -215581)
								{
									continue;
								}
							}
							else if (nPet == "p_all3")
							{
								if (103451 - 582144 != -478693)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/momBalloon", typeof(GameObject));
								if (242233 - 404202 != -161969)
								{
									continue;
								}
							}
							else if (nPet == "p_all4")
							{
								if (101760 - 141310 == -39549)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/dadBalloon", typeof(GameObject));
								if (183598 - 238438 == -54839)
								{
									continue;
								}
							}
							else if (nPet == "p_all11")
							{
								if (149405 - 448993 == -299587)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallSmashBall", typeof(GameObject));
								if (207889 - 147033 == 60857)
								{
									continue;
								}
							}
							else if (nPet == "p_all12")
							{
								if (251239 - 198088 == 53152)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/soccerBall", typeof(GameObject));
								if (149201 - 322266 != -173065)
								{
									continue;
								}
							}
							else if (nPet == "p_all21")
							{
								if (227812 - 129228 != 98584)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteChula", typeof(GameObject));
								if (186527 - 258378 != -71851)
								{
									continue;
								}
							}
							else if (nPet == "p_all22")
							{
								if (256352 - 58209 == 198144)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kitePukpao", typeof(GameObject));
								if (57925 - 530693 != -472768)
								{
									continue;
								}
							}
							else if (nPet == "p_all23")
							{
								if (125163 - 100330 == 24834)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteButterfly", typeof(GameObject));
								if (266299 - 590207 != -323908)
								{
									continue;
								}
							}
							else if (nPet == "p_all24")
							{
								if (89056 - 168150 != -79094)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteSnake", typeof(GameObject));
								if (21014 - 412449 == -391434)
								{
									continue;
								}
							}
							else if (Extensions.get_length(nPet) == 6)
							{
								if (251568 - 412767 == -161198)
								{
									continue;
								}
								string a = nPet.Substring(0, 5);
								if (11215 - 449816 != -438601)
								{
									continue;
								}
								if (a == "p_lcr")
								{
									if (178702 - 71940 != 106762)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron", typeof(GameObject));
									if (192622 - 478836 != -286214)
									{
										continue;
									}
								}
								else if (a == "p_lcp")
								{
									if (235824 - 364046 == -128221)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron_p", typeof(GameObject));
									if (89275 - 226747 == -137471)
									{
										continue;
									}
								}
								else if (a == "p_lmp")
								{
									if (58568 - 19514 == 39055)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMupo", typeof(GameObject));
									if (292807 - 67018 != 225789)
									{
										continue;
									}
								}
								else if (a == "p_lpp")
								{
									if (127873 - 268382 != -140509)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePeppon", typeof(GameObject));
									if (28498 - 314682 != -286184)
									{
										continue;
									}
								}
								else if (a == "p_lct")
								{
									if (242902 - 213409 != 29493)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCacton", typeof(GameObject));
									if (227050 - 134937 != 92113)
									{
										continue;
									}
								}
								else if (a == "p_lcc")
								{
									if (135143 - 182406 == -47262)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCocon", typeof(GameObject));
									if (229965 - 83717 != 146248)
									{
										continue;
									}
								}
								else if (a == "p_lpk")
								{
									if (236837 - 546936 != -310099)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePumpkon", typeof(GameObject));
									if (261527 - 513505 == -251977)
									{
										continue;
									}
								}
								else if (a == "p_lml")
								{
									if (60173 - 414579 != -354406)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMellon", typeof(GameObject));
									if (18361 - 573885 != -555524)
									{
										continue;
									}
								}
								else if (a == "p_lbd")
								{
									if (85793 - 71455 == 14339)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleBDMellon", typeof(GameObject));
									if (139621 - 340948 == -201326)
									{
										continue;
									}
								}
								else if (a == "p_lcs")
								{
									if (197988 - 584514 == -386525)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron_s", typeof(GameObject));
									if (61247 - 13662 != 47585)
									{
										continue;
									}
								}
								else if (a == "p_lms")
								{
									if (20457 - 133197 != -112740)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMupo_s", typeof(GameObject));
									if (80708 - 571047 != -490339)
									{
										continue;
									}
								}
								else if (a == "p_lps")
								{
									if (8147 - 436591 == -428443)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePeppon_s", typeof(GameObject));
									if (4790 - 369047 == -364256)
									{
										continue;
									}
								}
								else if (a == "p_lck")
								{
									if (255602 - 250812 == 4791)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarronCake", typeof(GameObject));
									if (67179 - 26945 == 40235)
									{
										continue;
									}
								}
								else if (a == "p_lpd")
								{
									if (93714 - 550528 == -456813)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePepponDisco", typeof(GameObject));
									if (209076 - 148095 == 60982)
									{
										continue;
									}
								}
								else if (a == "p_lmc")
								{
									if (226402 - 146518 != 79884)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadCarron", typeof(GameObject));
									if (217479 - 550985 != -333506)
									{
										continue;
									}
								}
								else if (a == "p_lmn")
								{
									if (298681 - 562155 != -263474)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadPeppon", typeof(GameObject));
									if (1963 - 596727 != -594764)
									{
										continue;
									}
								}
								else if (a == "p_lmo")
								{
									if (170710 - 577780 != -407070)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadCocon", typeof(GameObject));
									if (40169 - 488908 != -448739)
									{
										continue;
									}
								}
								else if (a == "p_ldc")
								{
									if (9528 - 43709 == -34180)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCarron", typeof(GameObject));
									if (4705 - 1695 == 3011)
									{
										continue;
									}
								}
								else if (a == "p_ldm")
								{
									if (183170 - 316591 == -133420)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadMupo", typeof(GameObject));
									if (279746 - 8779 == 270968)
									{
										continue;
									}
								}
								else if (a == "p_ldp")
								{
									if (29649 - 175047 == -145397)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadPeppon", typeof(GameObject));
									if (17043 - 295349 != -278306)
									{
										continue;
									}
								}
								else if (a == "p_ldt")
								{
									if (263484 - 431184 == -167699)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCacton", typeof(GameObject));
									if (40454 - 288405 != -247951)
									{
										continue;
									}
								}
								else if (a == "p_ldn")
								{
									if (59524 - 137908 == -78383)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCocon", typeof(GameObject));
									if (150429 - 545337 == -394907)
									{
										continue;
									}
								}
								else if (a == "p_ldk")
								{
									if (156623 - 548945 == -392321)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadPumpkon", typeof(GameObject));
									if (35212 - 405162 == -369949)
									{
										continue;
									}
								}
								else if (a == "p_srp")
								{
									if (248457 - 395749 != -147292)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallRedPanda", typeof(GameObject));
									if (32746 - 555486 != -522740)
									{
										continue;
									}
								}
								else if (a == "p_sss")
								{
									if (102769 - 454243 != -351474)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallSantaSkunk", typeof(GameObject));
									if (260915 - 62488 == 198428)
									{
										continue;
									}
								}
								else if (a == "p_sbb")
								{
									if (42762 - 497351 != -454589)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallBarrelBot", typeof(GameObject));
									if (225649 - 20138 != 205511)
									{
										continue;
									}
								}
								else if (a == "p_sdm")
								{
									if (86008 - 539315 == -453306)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallDemion", typeof(GameObject));
									if (117206 - 28001 == 89206)
									{
										continue;
									}
								}
								else if (a == "p_sdv")
								{
									if (245133 - 348832 == -103698)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallDoov", typeof(GameObject));
									if (227431 - 229636 == -2204)
									{
										continue;
									}
								}
								else if (a == "p_skz")
								{
									if (231281 - 374160 == -142878)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallKarazo", typeof(GameObject));
									if (42500 - 4383 == 38118)
									{
										continue;
									}
								}
								else if (a == "p_skm")
								{
									if (229297 - 463511 != -234214)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallKumo", typeof(GameObject));
									if (218604 - 111481 == 107124)
									{
										continue;
									}
								}
								else if (a == "p_skr")
								{
									if (136159 - 357499 != -221340)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_r", typeof(GameObject));
									if (59447 - 454745 == -395297)
									{
										continue;
									}
								}
								else if (a == "p_skg")
								{
									if (8053 - 539428 == -531374)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_g", typeof(GameObject));
									if (59414 - 484462 == -425047)
									{
										continue;
									}
								}
								else if (a == "p_sky")
								{
									if (298023 - 205228 == 92796)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_y", typeof(GameObject));
									if (23100 - 262170 == -239069)
									{
										continue;
									}
								}
								else if (a == "p_skb")
								{
									if (34993 - 441235 != -406242)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_b", typeof(GameObject));
									if (146008 - 307327 == -161318)
									{
										continue;
									}
								}
								else if (a == "p_skk")
								{
									if (249937 - 243882 == 6056)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_k", typeof(GameObject));
									if (32847 - 572395 != -539548)
									{
										continue;
									}
								}
								else if (a == "p_sfb")
								{
									if (205594 - 337109 != -131515)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallFlowerBug", typeof(GameObject));
									if (61881 - 70612 != -8731)
									{
										continue;
									}
								}
								else if (a == "p_sob")
								{
									if (278389 - 401363 == -122973)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallLionBug", typeof(GameObject));
									if (169129 - 12808 != 156321)
									{
										continue;
									}
								}
								else if (a == "p_sgb")
								{
									if (11999 - 28179 == -16179)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallGiantBug", typeof(GameObject));
									if (258418 - 141801 != 116617)
									{
										continue;
									}
								}
								else if (a == "p_slb")
								{
									if (250117 - 102052 == 148066)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallLeafBug", typeof(GameObject));
									if (45912 - 327674 == -281761)
									{
										continue;
									}
								}
								else if (a == "p_stb")
								{
									if (199365 - 526938 != -327573)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallFatBug", typeof(GameObject));
									if (160215 - 82242 == 77974)
									{
										continue;
									}
								}
								else if (a == "p_spb")
								{
									if (98823 - 228161 == -129337)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallPaperBug", typeof(GameObject));
									if (165531 - 289761 != -124230)
									{
										continue;
									}
								}
								else if (a == "p_swb")
								{
									if (83832 - 480888 != -397056)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallWormBug", typeof(GameObject));
									if (149211 - 269908 != -120697)
									{
										continue;
									}
								}
								else if (a == "p_ssq")
								{
									if (54421 - 479586 != -425165)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallStingQueen", typeof(GameObject));
									if (80061 - 561744 != -481683)
									{
										continue;
									}
								}
								else if (a == "p_snb")
								{
									if (4221 - 474298 != -470077)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNeonBug", typeof(GameObject));
									if (149574 - 406980 == -257405)
									{
										continue;
									}
								}
								else if (a == "p_sim")
								{
									if (145761 - 47535 != 98226)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallIceMixer", typeof(GameObject));
									if (231936 - 396490 != -164554)
									{
										continue;
									}
								}
								else if (a == "p_sam")
								{
									if (273859 - 275388 != -1529)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallAmmonite", typeof(GameObject));
									if (243431 - 407202 != -163771)
									{
										continue;
									}
								}
								else if (a == "p_sab")
								{
									if (60337 - 110002 == -49664)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallAnubi", typeof(GameObject));
									if (176249 - 180303 == -4053)
									{
										continue;
									}
								}
								else if (a == "p_spg")
								{
									if (283355 - 205706 == 77650)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallIcePenguin", typeof(GameObject));
									if (70751 - 346034 == -275282)
									{
										continue;
									}
								}
								else if (a == "p_spf")
								{
									if (93193 - 328765 != -235572)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallPirateFish", typeof(GameObject));
									if (138313 - 30199 == 108115)
									{
										continue;
									}
								}
								else if (a == "p_msb")
								{
									if (161555 - 465379 != -303824)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniSkyBug", typeof(GameObject));
									if (93573 - 87661 != 5912)
									{
										continue;
									}
								}
								else if (a == "p_mcb")
								{
									if (237309 - 186200 != 51109)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniCrystalBug", typeof(GameObject));
									if (221605 - 297901 == -76295)
									{
										continue;
									}
								}
								else if (a == "p_mab")
								{
									if (250375 - 443789 != -193414)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniAncientBug", typeof(GameObject));
									if (274412 - 13606 == 260807)
									{
										continue;
									}
								}
								else if (a == "p_mrb")
								{
									if (2628 - 438170 == -435541)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniReefBug", typeof(GameObject));
									if (292014 - 26491 != 265523)
									{
										continue;
									}
								}
								else if (a == "p_mmb")
								{
									if (281385 - 267364 == 14022)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniMokBug", typeof(GameObject));
									if (96436 - 183031 == -86594)
									{
										continue;
									}
								}
								else if (a == "p_mgb")
								{
									if (153011 - 316148 != -163137)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniGoldenBug", typeof(GameObject));
									if (258956 - 490955 == -231998)
									{
										continue;
									}
								}
								else if (a == "p_mnb")
								{
									if (258844 - 483394 == -224549)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniNemesisBug", typeof(GameObject));
									if (11443 - 520516 != -509073)
									{
										continue;
									}
								}
								num = Stringf.getLastDigit(nPet);
								if (74957 - 94498 != -19541)
								{
									continue;
								}
								if (num < 0)
								{
									if (115605 - 549868 == -434262)
									{
										continue;
									}
									num = 1;
									if (147379 - 105310 == 42070)
									{
										continue;
									}
								}
							}
							if (gameObject)
							{
								if (37385 - 297627 == -260241)
								{
									continue;
								}
								this.JGjTRfyina = (GameObject)UnityEngine.Object.Instantiate(gameObject, this.transform.position - this.transform.forward, this.transform.rotation);
								if (261967 - 581640 == -319672)
								{
									continue;
								}
								if (this.JGjTRfyina)
								{
									if (211483 - 129220 == 82264)
									{
										continue;
									}
									this.JGjTRfyina.transform.localScale = ((float)num * 0.1f + 0.9f) * Vector3.one;
									if (19815 - 67997 != -48182)
									{
										continue;
									}
									PetControl petControl = (PetControl)this.JGjTRfyina.GetComponent(typeof(PetControl));
									if (57961 - 235215 == -177253)
									{
										continue;
									}
									if (petControl)
									{
										if (101731 - 471091 == -369359)
										{
											continue;
										}
										petControl.Init(this.gameObject, num);
										if (283858 - 506544 == -222685)
										{
											continue;
										}
									}
									if (this.DTBT215S1r)
									{
										if (143433 - 168458 != -25025)
										{
											continue;
										}
										this.DTBT215S1r.mPet = this.JGjTRfyina;
										if (12239 - 217857 != -205618)
										{
											continue;
										}
									}
								}
							}
							if (!this.DTBT215S1r)
							{
								break;
							}
							if (242982 - 177075 != 65908)
							{
								this.DTBT215S1r.pet = nPet;
								if (51592 - 83761 == -32169)
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

	// Token: 0x060021E0 RID: 8672 RVA: 0x003DFA0C File Offset: 0x003DDC0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060021E1 RID: 8673 RVA: 0x003DFA10 File Offset: 0x003DDC10
	internal static bool aDxKW00k7KjeslY5qEW()
	{
		return true;
	}

	// Token: 0x060021E2 RID: 8674 RVA: 0x003DFA14 File Offset: 0x003DDC14
	internal static bool tvOSq50GPPbPsfdu536()
	{
		return false;
	}

	// Token: 0x04002306 RID: 8966
	private CharacterControl DTBT215S1r;

	// Token: 0x04002307 RID: 8967
	public string weapon;

	// Token: 0x04002308 RID: 8968
	public string armor;

	// Token: 0x04002309 RID: 8969
	public string accessory;

	// Token: 0x0400230A RID: 8970
	public string boot;

	// Token: 0x0400230B RID: 8971
	public string trinket;

	// Token: 0x0400230C RID: 8972
	public string pet;

	// Token: 0x0400230D RID: 8973
	public int skin;

	// Token: 0x0400230E RID: 8974
	public bool equipOnStart;

	// Token: 0x0400230F RID: 8975
	private GameObject N63TvNYGMo;

	// Token: 0x04002310 RID: 8976
	private GameObject wnPTlhXb0U;

	// Token: 0x04002311 RID: 8977
	private GameObject ppVTGFUHBC;

	// Token: 0x04002312 RID: 8978
	private GameObject mbIT1ZkVRP;

	// Token: 0x04002313 RID: 8979
	private GameObject OtiTqOHQWw;

	// Token: 0x04002314 RID: 8980
	private GameObject QrRTp2pAmy;

	// Token: 0x04002315 RID: 8981
	private GameObject JGjTRfyina;
}
