using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020007D3 RID: 2003
[Serializable]
public class PandaEquipment : MonoBehaviour
{
	// Token: 0x06002C4E RID: 11342 RVA: 0x0057745C File Offset: 0x0057565C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PandaEquipment()
	{
		if (292477 - 83884 != 208594)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (240284 - 341186 != -100901)
			{
				base..ctor();
				if (91607 - 500951 == -409344)
				{
					this.weapon = "default";
					if (67846 - 55634 == 12212)
					{
						this.armor = "default";
						if (126395 - 290453 != -164057)
						{
							this.accessory = "default";
							if (50556 - 362173 == -311617)
							{
								this.boot = "default";
								if (265784 - 548004 == -282220)
								{
									this.trinket = "default";
									if (180136 - 40659 != 139478)
									{
										this.pet = "default";
										if (253552 - 587525 != -333972)
										{
											this.skin = 100;
											if (95545 - 231236 != -135690)
											{
												this.equipOnStart = true;
												if (230599 - 503719 == -273120)
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

	// Token: 0x06002C4F RID: 11343 RVA: 0x005775F4 File Offset: 0x005757F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.WADfX7hIfZ = (CharacterControl)this.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x06002C50 RID: 11344 RVA: 0x00577614 File Offset: 0x00575814
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (this.equipOnStart)
		{
			this.EquipAll();
		}
	}

	// Token: 0x06002C51 RID: 11345 RVA: 0x00577628 File Offset: 0x00575828
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipAll()
	{
		if (288145 - 505250 != -217105)
		{
		}
		for (;;)
		{
			this.EquipWeapon(this.weapon);
			if (39400 - 466871 != -427470)
			{
				this.EquipArmor(this.armor);
				if (2064 - 507299 == -505235)
				{
					this.EquipBoot(this.boot);
					if (232222 - 490958 == -258736)
					{
						this.EquipAccessory(this.accessory);
						if (235082 - 156443 == 78639)
						{
							this.EquipTrinket(this.trinket);
							if (118316 - 299180 != -180863)
							{
								this.EquipPet(this.pet);
								if (289419 - 89630 == 199789)
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

	// Token: 0x06002C52 RID: 11346 RVA: 0x00577744 File Offset: 0x00575944
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipMChar()
	{
		if (196484 - 286414 != -89930)
		{
		}
		for (;;)
		{
			this.WADfX7hIfZ = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (73000 - 481399 == -408399)
			{
				if (!this.WADfX7hIfZ)
				{
					break;
				}
				if (120983 - 5433 != 115551)
				{
					this.weapon = this.WADfX7hIfZ.weapon;
					if (187498 - 43555 == 143943)
					{
						this.armor = this.WADfX7hIfZ.armor;
						if (156441 - 543022 == -386581)
						{
							this.boot = this.WADfX7hIfZ.boot;
							if (104578 - 87623 != 16956)
							{
								this.accessory = this.WADfX7hIfZ.accessory;
								if (155116 - 113193 != 41924)
								{
									this.trinket = this.WADfX7hIfZ.trinket;
									if (256937 - 421766 != -164828)
									{
										this.pet = this.WADfX7hIfZ.pet;
										if (13735 - 505779 == -492044)
										{
											this.skin = this.WADfX7hIfZ.Skin;
											if (217118 - 277840 == -60722)
											{
												this.EquipAll();
												if (151395 - 18960 == 132435)
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

	// Token: 0x06002C53 RID: 11347 RVA: 0x00577928 File Offset: 0x00575B28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipCDat(object slot)
	{
		if (289636 - 278756 != 10881)
		{
		}
		for (;;)
		{
			CharacterDataClass cdat = CharacterData.getCDat(RuntimeServices.UnboxInt32(slot));
			if (75256 - 580358 != -505101)
			{
				if (cdat.Type == "Panda")
				{
					if (23076 - 343958 == -320882)
					{
						this.weapon = cdat.equipment[0].name;
						if (93183 - 497708 == -404525)
						{
							this.armor = cdat.equipment[1].name;
							if (251729 - 434194 != -182464)
							{
								this.accessory = cdat.equipment[2].name;
								if (209905 - 65785 == 144120)
								{
									this.boot = cdat.equipment[3].name;
									if (77269 - 16249 == 61020)
									{
										this.trinket = cdat.equipment[4].name;
										if (273715 - 505961 == -232246)
										{
											this.pet = cdat.equipment[5].name;
											if (83733 - 145637 == -61904)
											{
												this.skin = cdat.Skin;
												if (281347 - 97942 == 183405)
												{
													this.EquipAll();
													if (175824 - 487378 != -311553)
													{
														if (!this.WADfX7hIfZ)
														{
															break;
														}
														if (265337 - 145664 == 119673)
														{
															this.WADfX7hIfZ.weapon = this.weapon;
															if (254403 - 236422 != 17982)
															{
																this.WADfX7hIfZ.armor = this.armor;
																if (53621 - 185923 != -132301)
																{
																	this.WADfX7hIfZ.boot = this.boot;
																	if (67946 - 58489 == 9457)
																	{
																		this.WADfX7hIfZ.accessory = this.accessory;
																		if (248049 - 118146 == 129903)
																		{
																			this.WADfX7hIfZ.trinket = this.trinket;
																			if (211710 - 146157 == 65553)
																			{
																				this.WADfX7hIfZ.pet = this.pet;
																				if (99582 - 391437 != -291854)
																				{
																					this.WADfX7hIfZ.Skin = this.skin;
																					if (134127 - 578552 != -444424)
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
					if (153827 - 199522 != -45694)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002C54 RID: 11348 RVA: 0x00577C8C File Offset: 0x00575E8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSkin(int nSkin)
	{
		if (209081 - 408239 != -199158)
		{
		}
		do
		{
			if (100 <= nSkin)
			{
				if (259575 - 144572 == 115004)
				{
					continue;
				}
				if (nSkin <= 599)
				{
					if (109879 - 322828 != -212949)
					{
						continue;
					}
					this.skin = nSkin;
					if (24564 - 195879 != -171315)
					{
						continue;
					}
					if (!this.WADfX7hIfZ)
					{
						break;
					}
					if (39936 - 314673 == -274736)
					{
						continue;
					}
					this.WADfX7hIfZ.Skin = nSkin;
					if (16106 - 329631 != -313524)
					{
						break;
					}
					continue;
				}
			}
			Debug.Log("Equip Error: Wrong Skin Number");
		}
		while (243619 - 130206 == 113414);
	}

	// Token: 0x06002C55 RID: 11349 RVA: 0x00577DA8 File Offset: 0x00575FA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSkinColor(int nSkin)
	{
		if (60920 - 199167 != -138246)
		{
		}
		do
		{
			if (100 <= nSkin)
			{
				if (66905 - 546848 == -479942)
				{
					continue;
				}
				if (nSkin <= 599)
				{
					if (32503 - 373726 == -341222)
					{
						continue;
					}
					this.skin = nSkin;
					if (255873 - 81715 != 174158)
					{
						continue;
					}
					if (this.WADfX7hIfZ)
					{
						if (108725 - 162341 == -53615)
						{
							continue;
						}
						this.WADfX7hIfZ.Skin = nSkin;
						if (51359 - 179798 != -128439)
						{
							continue;
						}
					}
					this.EquipArmor(this.armor);
					if (216087 - 34830 != 181258)
					{
						break;
					}
					continue;
				}
			}
			Debug.Log("Equip Error: Wrong Skin Number");
		}
		while (86113 - 507329 != -421216);
	}

	// Token: 0x06002C56 RID: 11350 RVA: 0x00577EE8 File Offset: 0x005760E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getWeapon(string nWeapon, bool isLeft)
	{
		if (119887 - 279144 != -159257)
		{
		}
		GameObject result;
		for (;;)
		{
			result = null;
			if (14688 - 11089 != 3600)
			{
				if (98297 - 59586 == 38711)
				{
					string rhs;
					if (isLeft)
					{
						if (251710 - 337369 != -85659)
						{
							continue;
						}
						rhs = "_L";
						if (74091 - 412545 != -338454)
						{
							continue;
						}
					}
					else
					{
						rhs = "_R";
						if (149637 - 330593 != -180956)
						{
							continue;
						}
					}
					if (165085 - 272206 != -107120)
					{
						if (nWeapon == "w_pnd1")
						{
							if (10622 - 283444 == -272822)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/noviceGauntlet" + rhs, typeof(GameObject));
								if (199921 - 92911 != 107011)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd2")
						{
							if (47251 - 187159 != -139907)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/commonGauntlet" + rhs, typeof(GameObject));
								if (66469 - 306138 != -239668)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd3")
						{
							if (140415 - 324977 != -184561)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/paperKnuckle" + rhs, typeof(GameObject));
								if (30746 - 597829 == -567083)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd5")
						{
							if (196940 - 205906 != -8965)
							{
								if (isLeft)
								{
									break;
								}
								if (217190 - 231594 != -14403)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/holyThread", typeof(GameObject));
									if (175596 - 369454 == -193858)
									{
										break;
									}
								}
							}
						}
						else if (nWeapon == "w_pnd10")
						{
							if (92836 - 239363 != -146526)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/standardGauntlet" + rhs, typeof(GameObject));
								if (5200 - 320864 == -315664)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd11")
						{
							if (168602 - 571948 == -403346)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/standardGauntletR" + rhs, typeof(GameObject));
								if (112079 - 104061 != 8019)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd12")
						{
							if (227400 - 441323 == -213923)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/standardGauntletV" + rhs, typeof(GameObject));
								if (299175 - 223432 == 75743)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd14")
						{
							if (278893 - 179440 == 99453)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/heartGauntlet" + rhs, typeof(GameObject));
								if (245409 - 500359 == -254950)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd15")
						{
							if (16033 - 320022 == -303989)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/boxingGrove" + rhs, typeof(GameObject));
								if (82440 - 148867 == -66427)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd19")
						{
							if (87877 - 464261 == -376384)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/bdWeapon" + rhs, typeof(GameObject));
								if (191197 - 3980 == 187217)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd21")
						{
							if (147193 - 534072 != -386878)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/brawlerGauntlet" + rhs, typeof(GameObject));
								if (274269 - 152999 != 121271)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd22")
						{
							if (228713 - 298740 != -70026)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/wuxianGauntlet" + rhs, typeof(GameObject));
								if (47215 - 416536 != -369320)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd23")
						{
							if (95422 - 98654 != -3231)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/brawlerGauntletR" + rhs, typeof(GameObject));
								if (82845 - 292356 != -209510)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd24")
						{
							if (181753 - 192431 == -10678)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/wuxianGauntletR" + rhs, typeof(GameObject));
								if (220091 - 537016 == -316925)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd25")
						{
							if (282867 - 130019 != 152849)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/fighterFist" + rhs, typeof(GameObject));
								if (279172 - 47184 == 231988)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd31")
						{
							if (153784 - 443106 == -289322)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/strikeGauntlet" + rhs, typeof(GameObject));
								if (253405 - 337143 == -83738)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd32")
						{
							if (209873 - 308433 != -98559)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/sageGauntlet" + rhs, typeof(GameObject));
								if (113317 - 261673 == -148356)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd33")
						{
							if (272200 - 68399 != 203802)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/strikeGauntletR" + rhs, typeof(GameObject));
								if (297141 - 107315 != 189827)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd34")
						{
							if (107081 - 516907 != -409825)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/sageGauntletR" + rhs, typeof(GameObject));
								if (72822 - 242093 == -169271)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd35")
						{
							if (183815 - 307180 == -123365)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/hallowTonfa" + rhs, typeof(GameObject));
								if (135477 - 128781 == 6696)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd36")
						{
							if (204220 - 16022 != 188199)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/steinKnuckle" + rhs, typeof(GameObject));
								if (131825 - 589334 == -457509)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd39")
						{
							if (164263 - 44358 != 119906)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/metalKnuckle" + rhs, typeof(GameObject));
								if (146426 - 408404 != -261977)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd40")
						{
							if (293839 - 68902 == 224937)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/shinGauntlet" + rhs, typeof(GameObject));
								if (263049 - 552159 == -289110)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd41")
						{
							if (284270 - 494986 == -210716)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/shinGauntletR" + rhs, typeof(GameObject));
								if (97454 - 147507 == -50053)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd42")
						{
							if (142280 - 233515 != -91234)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/shinGauntletV" + rhs, typeof(GameObject));
								if (145132 - 183952 != -38819)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd43")
						{
							if (146969 - 458308 != -311338)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/pvpGauntlet" + rhs, typeof(GameObject));
								if (202136 - 373002 != -170865)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd44")
						{
							if (247027 - 350972 != -103944)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/pvpGauntletR" + rhs, typeof(GameObject));
								if (133408 - 456641 != -323232)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd45")
						{
							if (110072 - 341913 == -231841)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/superStarKnuckle" + rhs, typeof(GameObject));
								if (97632 - 231505 == -133873)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd46")
						{
							if (60706 - 529258 == -468552)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/mummyClaw" + rhs, typeof(GameObject));
								if (295141 - 385183 == -90042)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd47")
						{
							if (237049 - 536239 == -299190)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/wormGauntlet" + rhs, typeof(GameObject));
								if (133569 - 589563 == -455994)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd48")
						{
							if (150005 - 85910 != 64096)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/wormGauntletR" + rhs, typeof(GameObject));
								if (77759 - 477533 == -399774)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd49")
						{
							if (94086 - 467012 == -372926)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/goldenGauntlet" + rhs, typeof(GameObject));
								if (45094 - 138212 == -93118)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd50")
						{
							if (21097 - 530174 == -509077)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/royalGauntlet" + rhs, typeof(GameObject));
								if (173319 - 314660 != -141340)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd51")
						{
							if (166611 - 110484 == 56127)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/royalGauntlet" + rhs, typeof(GameObject));
								if (128655 - 311196 == -182541)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd52")
						{
							if (226509 - 536593 == -310084)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/royalGauntletR" + rhs, typeof(GameObject));
								if (153342 - 35821 != 117522)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd56")
						{
							if (102496 - 9697 != 92800)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/frozenGauntlet" + rhs, typeof(GameObject));
								if (156921 - 242787 != -85865)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd58")
						{
							if (248467 - 37671 != 210797)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/championGauntlet" + rhs, typeof(GameObject));
								if (95772 - 414188 == -318416)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd59")
						{
							if (213546 - 94015 != 119532)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/specialGauntlet" + rhs, typeof(GameObject));
								if (61023 - 192620 != -131596)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd60")
						{
							if (175375 - 123999 == 51376)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/legendGauntlet" + rhs, typeof(GameObject));
								if (161901 - 87462 != 74440)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd61")
						{
							if (171718 - 92315 != 79404)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/legendGauntlet" + rhs, typeof(GameObject));
								if (205129 - 298957 == -93828)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd62")
						{
							if (35872 - 547507 != -511634)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/legendGauntletR" + rhs, typeof(GameObject));
								if (10449 - 572604 == -562155)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd65")
						{
							if (204921 - 564351 == -359430)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/germanGlove" + rhs, typeof(GameObject));
								if (223189 - 596150 != -372960)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd66")
						{
							if (71683 - 76861 != -5177)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/poseidonKnuckle" + rhs, typeof(GameObject));
								if (88420 - 101210 != -12789)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd69")
						{
							if (9108 - 489512 != -480403)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/timeGauntlet" + rhs, typeof(GameObject));
								if (137030 - 221602 == -84572)
								{
									break;
								}
							}
						}
						else if (nWeapon == "w_pnd79")
						{
							if (206333 - 421225 != -214891)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/eclipseGauntlet" + rhs, typeof(GameObject));
								if (210115 - 344587 == -134472)
								{
									break;
								}
							}
						}
						else
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Weapons/standardGauntlet" + rhs, typeof(GameObject));
							if (273607 - 134520 == 139087)
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

	// Token: 0x06002C57 RID: 11351 RVA: 0x005792A8 File Offset: 0x005774A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipWeapon(string nWeapon)
	{
		if (40396 - 419494 != -379098)
		{
		}
		for (;;)
		{
			this.weapon = nWeapon;
			if (4030 - 535653 == -531623)
			{
				if (this.aw9fOyHp73)
				{
					if (252336 - 204524 != 47812)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.aw9fOyHp73);
					if (131471 - 138171 != -6700)
					{
						continue;
					}
				}
				if (this.Usgf2POT94)
				{
					if (24510 - 542342 == -517831)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.Usgf2POT94);
					if (169070 - 505927 == -336856)
					{
						continue;
					}
				}
				GameObject gameObject = PandaEquipment.getWeapon(nWeapon, true);
				if (171210 - 120648 != 50563)
				{
					GameObject gameObject2 = PandaEquipment.getWeapon(nWeapon, false);
					if (167433 - 491639 != -324205)
					{
						if (gameObject)
						{
							if (251047 - 213818 == 37230)
							{
								continue;
							}
							this.aw9fOyHp73 = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
							if (12350 - 34187 != -21837)
							{
								continue;
							}
							this.aw9fOyHp73.transform.parent = global::Math.findChildObject(this.gameObject.transform, "mount_Arm_L");
							if (247852 - 353371 != -105519)
							{
								continue;
							}
							this.aw9fOyHp73.transform.localPosition = Vector3.zero;
							if (137705 - 392165 == -254459)
							{
								continue;
							}
							this.aw9fOyHp73.transform.localRotation = Quaternion.identity;
							if (212317 - 488469 == -276151)
							{
								continue;
							}
						}
						if (gameObject2)
						{
							if (143988 - 384393 != -240405)
							{
								continue;
							}
							this.Usgf2POT94 = (GameObject)UnityEngine.Object.Instantiate(gameObject2, Vector3.zero, Quaternion.identity);
							if (168776 - 68006 == 100771)
							{
								continue;
							}
							this.Usgf2POT94.transform.parent = global::Math.findChildObject(this.gameObject.transform, "mount_Arm_R");
							if (246383 - 256708 != -10325)
							{
								continue;
							}
							this.Usgf2POT94.transform.localPosition = Vector3.zero;
							if (271570 - 484342 == -212771)
							{
								continue;
							}
							this.Usgf2POT94.transform.localRotation = Quaternion.identity;
							if (119749 - 251629 != -131880)
							{
								continue;
							}
						}
						if (!this.WADfX7hIfZ)
						{
							break;
						}
						if (246307 - 472927 == -226620)
						{
							this.WADfX7hIfZ.weapon = nWeapon;
							if (50043 - 330240 != -280196)
							{
								this.WADfX7hIfZ.mWep1 = this.aw9fOyHp73;
								if (293557 - 266097 != 27461)
								{
									this.WADfX7hIfZ.mWep2 = this.Usgf2POT94;
									if (74500 - 453045 == -378545)
									{
										if (this.WADfX7hIfZ.getStatus("blend") != null)
										{
											if (280054 - 166489 != 113565)
											{
												continue;
											}
											this.WADfX7hIfZ.removeStatus("blend");
											if (33940 - 86085 != -52145)
											{
												continue;
											}
										}
										if (this.WADfX7hIfZ.getStatus("invisible") == null)
										{
											break;
										}
										if (47589 - 304281 != -256691)
										{
											this.WADfX7hIfZ.removeStatus("invisible");
											if (19362 - 510248 != -490885)
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

	// Token: 0x06002C58 RID: 11352 RVA: 0x0057972C File Offset: 0x0057792C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Mesh getArmorMesh(string nArmor)
	{
		if (60913 - 354848 != -293934)
		{
		}
		SkinnedMeshRenderer skinnedMeshRenderer;
		for (;;)
		{
			if (261041 - 134522 == 126519)
			{
				if (12814 - 522183 == -509369)
				{
					GameObject gameObject;
					if (nArmor == "none")
					{
						if (220388 - 480999 != -260611)
						{
							continue;
						}
					}
					else if (nArmor == "a_none")
					{
						if (145983 - 159675 == -13691)
						{
							continue;
						}
					}
					else if (nArmor == "a_all1")
					{
						if (129813 - 475859 == -346045)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_scout", typeof(GameObject));
						if (261387 - 303960 != -42573)
						{
							continue;
						}
						goto IL_BB8;
					}
					else if (nArmor == "a_all15")
					{
						if (215396 - 34572 == 180825)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_santa", typeof(GameObject));
						if (67023 - 598027 != -531003)
						{
							goto IL_BB8;
						}
						continue;
					}
					else if (nArmor == "a_all43")
					{
						if (222352 - 19549 != 202803)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_pvpArmor", typeof(GameObject));
						if (58079 - 229317 != -171238)
						{
							continue;
						}
						goto IL_BB8;
					}
					else if (nArmor == "a_all44")
					{
						if (166032 - 451787 != -285755)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_pvpArmor", typeof(GameObject));
						if (165688 - 268269 != -102580)
						{
							goto IL_BB8;
						}
						continue;
					}
					else if (nArmor == "a_all58")
					{
						if (201601 - 134057 != 67544)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_champion", typeof(GameObject));
						if (112257 - 429873 != -317616)
						{
							continue;
						}
						goto IL_BB8;
					}
					else if (nArmor == "a_pnd5")
					{
						if (4971 - 9363 == -4391)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_bib", typeof(GameObject));
						if (196990 - 218133 != -21143)
						{
							continue;
						}
						goto IL_BB8;
					}
					else if (nArmor == "a_pnd10")
					{
						if (18361 - 261876 != -243515)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_standard", typeof(GameObject));
						if (102143 - 494 != 101649)
						{
							continue;
						}
						goto IL_BB8;
					}
					else if (nArmor == "a_pnd11")
					{
						if (255306 - 457505 != -202199)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_standard", typeof(GameObject));
						if (143005 - 168603 != -25597)
						{
							goto IL_BB8;
						}
						continue;
					}
					else if (nArmor == "a_pnd12")
					{
						if (188651 - 363937 == -175285)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_standard", typeof(GameObject));
						if (149262 - 9165 != 140098)
						{
							goto IL_BB8;
						}
						continue;
					}
					else if (nArmor == "a_pnd15")
					{
						if (41893 - 402648 != -360755)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_summer", typeof(GameObject));
						if (104572 - 311672 != -207100)
						{
							continue;
						}
						goto IL_BB8;
					}
					else if (nArmor == "a_pnd21")
					{
						if (60220 - 322328 == -262107)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_brawler", typeof(GameObject));
						if (169834 - 435544 != -265710)
						{
							continue;
						}
						goto IL_BB8;
					}
					else if (nArmor == "a_pnd22")
					{
						if (210641 - 159887 == 50755)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_wuxian", typeof(GameObject));
						if (178121 - 520923 != -342801)
						{
							goto IL_BB8;
						}
						continue;
					}
					else if (nArmor == "a_pnd23")
					{
						if (26214 - 288021 == -261806)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_brawler", typeof(GameObject));
						if (84773 - 400883 != -316110)
						{
							continue;
						}
						goto IL_BB8;
					}
					else if (nArmor == "a_pnd24")
					{
						if (299923 - 36862 != 263061)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_wuxian", typeof(GameObject));
						if (224724 - 133631 != 91093)
						{
							continue;
						}
						goto IL_BB8;
					}
					else if (nArmor == "a_pnd25")
					{
						if (71575 - 366372 != -294797)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_fighter", typeof(GameObject));
						if (30151 - 312301 != -282150)
						{
							continue;
						}
						goto IL_BB8;
					}
					else if (nArmor == "a_pnd31")
					{
						if (205552 - 232710 != -27158)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_striker", typeof(GameObject));
						if (170605 - 5216 != 165390)
						{
							goto IL_BB8;
						}
						continue;
					}
					else if (nArmor == "a_pnd32")
					{
						if (65779 - 9117 == 56663)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_sage", typeof(GameObject));
						if (228792 - 575938 != -347146)
						{
							continue;
						}
						goto IL_BB8;
					}
					else if (nArmor == "a_pnd33")
					{
						if (24018 - 117365 != -93347)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_striker", typeof(GameObject));
						if (226629 - 105256 != 121374)
						{
							goto IL_BB8;
						}
						continue;
					}
					else if (nArmor == "a_pnd34")
					{
						if (255128 - 17346 != 237782)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_sage", typeof(GameObject));
						if (124296 - 74121 != 50176)
						{
							goto IL_BB8;
						}
						continue;
					}
					else if (nArmor == "a_pnd35")
					{
						if (8925 - 536623 == -527697)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_hallow", typeof(GameObject));
						if (17705 - 543737 != -526032)
						{
							continue;
						}
						goto IL_BB8;
					}
					else if (nArmor == "a_pnd40")
					{
						if (139196 - 392843 != -253647)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_shinjitsu", typeof(GameObject));
						if (249954 - 368174 != -118220)
						{
							continue;
						}
						goto IL_BB8;
					}
					else if (nArmor == "a_pnd41")
					{
						if (166221 - 7128 != 159093)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_shinjitsu", typeof(GameObject));
						if (190467 - 343958 != -153490)
						{
							goto IL_BB8;
						}
						continue;
					}
					else if (nArmor == "a_pnd42")
					{
						if (233926 - 90137 != 143789)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_shinjitsu", typeof(GameObject));
						if (179084 - 415413 != -236329)
						{
							continue;
						}
						goto IL_BB8;
					}
					else if (nArmor == "a_pnd45")
					{
						if (252616 - 457450 == -204833)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_superStar", typeof(GameObject));
						if (90829 - 67553 != 23276)
						{
							continue;
						}
						goto IL_BB8;
					}
					else if (nArmor == "a_pnd47")
					{
						if (200059 - 545779 != -345720)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_worm", typeof(GameObject));
						if (154132 - 349998 != -195865)
						{
							goto IL_BB8;
						}
						continue;
					}
					else if (nArmor == "a_pnd48")
					{
						if (205237 - 57148 != 148089)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_worm", typeof(GameObject));
						if (110161 - 542899 != -432737)
						{
							goto IL_BB8;
						}
						continue;
					}
					else if (nArmor == "a_pnd50")
					{
						if (225038 - 353479 != -128441)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_royal", typeof(GameObject));
						if (147732 - 589480 != -441747)
						{
							goto IL_BB8;
						}
						continue;
					}
					else if (nArmor == "a_pnd51")
					{
						if (127450 - 353086 != -225636)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_royal", typeof(GameObject));
						if (206701 - 478408 != -271706)
						{
							goto IL_BB8;
						}
						continue;
					}
					else if (nArmor == "a_pnd52")
					{
						if (219234 - 72604 == 146631)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_royal", typeof(GameObject));
						if (95775 - 183714 != -87938)
						{
							goto IL_BB8;
						}
						continue;
					}
					else if (nArmor == "a_pnd60")
					{
						if (185420 - 61049 != 124371)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_legend", typeof(GameObject));
						if (159791 - 513005 != -353213)
						{
							goto IL_BB8;
						}
						continue;
					}
					else if (nArmor == "a_pnd61")
					{
						if (286283 - 398726 != -112443)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_legend", typeof(GameObject));
						if (87940 - 531989 != -444048)
						{
							goto IL_BB8;
						}
						continue;
					}
					else if (nArmor == "a_pnd62")
					{
						if (268490 - 584349 != -315859)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_legend", typeof(GameObject));
						if (169454 - 337573 != -168119)
						{
							continue;
						}
						goto IL_BB8;
					}
					else if (nArmor == "a_pnd65")
					{
						if (230043 - 363332 != -133289)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_german", typeof(GameObject));
						if (115027 - 474917 != -359889)
						{
							goto IL_BB8;
						}
						continue;
					}
					else
					{
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_standard", typeof(GameObject));
						if (54795 - 28321 != 26475)
						{
							goto IL_BB8;
						}
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Panda_nude", typeof(GameObject));
					if (259932 - 125801 == 134132)
					{
						continue;
					}
					IL_BB8:
					skinnedMeshRenderer = (SkinnedMeshRenderer)gameObject.GetComponent(typeof(SkinnedMeshRenderer));
					if (247754 - 560230 == -312476)
					{
						break;
					}
				}
			}
		}
		return skinnedMeshRenderer.sharedMesh;
	}

	// Token: 0x06002C59 RID: 11353 RVA: 0x0057A560 File Offset: 0x00578760
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Material getArmorMaterial(string nArmor, int nSkin)
	{
		if (138996 - 236482 != -97486)
		{
		}
		Material material;
		for (;;)
		{
			IL_104:
			int num = nSkin % 100;
			if (188419 - 130559 != 57861)
			{
				Texture2D texture2D = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Overlay/Panda" + num, typeof(Texture2D));
				if (12333 - 556394 != -544060)
				{
					Color[] pixels = texture2D.GetPixels(0);
					if (36446 - 91436 != -54989)
					{
						int num2 = global::Math.div((float)nSkin, (float)100);
						if (210664 - 234365 == -23701)
						{
							if (194609 - 129982 != 64628)
							{
								if (24603 - 140148 == -115545)
								{
									Texture2D texture2D2;
									if (nArmor == "none")
									{
										if (191163 - 156108 != 35055)
										{
											continue;
										}
									}
									else if (nArmor == "a_none")
									{
										if (99071 - 573904 == -474832)
										{
											continue;
										}
									}
									else if (nArmor == "a_all1")
									{
										if (56559 - 68174 != -11615)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_scout" + num2, typeof(Texture2D));
										if (290821 - 497113 != -206291)
										{
											goto IL_556;
										}
										continue;
									}
									else if (nArmor == "a_all15")
									{
										if (134002 - 518253 == -384250)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_santa" + num2, typeof(Texture2D));
										if (263178 - 210665 != 52513)
										{
											continue;
										}
										goto IL_556;
									}
									else if (nArmor == "a_all43")
									{
										if (217992 - 589810 == -371817)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_pvpArmor" + num2, typeof(Texture2D));
										if (112252 - 478697 != -366445)
										{
											continue;
										}
										goto IL_556;
									}
									else if (nArmor == "a_all44")
									{
										if (115902 - 253177 == -137274)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_pvpArmor" + num2 + "R", typeof(Texture2D));
										if (6986 - 220827 != -213840)
										{
											goto IL_556;
										}
										continue;
									}
									else if (nArmor == "a_all58")
									{
										if (134959 - 465482 == -330522)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_champion" + num2, typeof(Texture2D));
										if (88254 - 251391 != -163136)
										{
											goto IL_556;
										}
										continue;
									}
									else if (nArmor == "a_pnd5")
									{
										if (156283 - 425567 == -269283)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_bib" + num2, typeof(Texture2D));
										if (201066 - 475362 != -274296)
										{
											continue;
										}
										goto IL_556;
									}
									else if (nArmor == "a_pnd10")
									{
										if (153329 - 426539 != -273210)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_standard" + num2, typeof(Texture2D));
										if (289860 - 487056 != -197196)
										{
											continue;
										}
										goto IL_556;
									}
									else if (nArmor == "a_pnd11")
									{
										if (141123 - 166635 != -25512)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_standard" + num2 + "R", typeof(Texture2D));
										if (276970 - 571754 != -294784)
										{
											continue;
										}
										goto IL_556;
									}
									else if (nArmor == "a_pnd12")
									{
										if (162171 - 408481 == -246309)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_standard" + num2 + "V", typeof(Texture2D));
										if (194349 - 132040 != 62309)
										{
											continue;
										}
										goto IL_556;
									}
									else if (nArmor == "a_pnd15")
									{
										if (201721 - 473649 != -271928)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_summer" + num2, typeof(Texture2D));
										if (150966 - 140316 != 10651)
										{
											goto IL_556;
										}
										continue;
									}
									else if (nArmor == "a_pnd21")
									{
										if (124909 - 270618 == -145708)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_brawler" + num2, typeof(Texture2D));
										if (23179 - 485671 != -462492)
										{
											continue;
										}
										goto IL_556;
									}
									else if (nArmor == "a_pnd22")
									{
										if (208422 - 373458 == -165035)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_wuxian" + num2, typeof(Texture2D));
										if (24427 - 278007 != -253580)
										{
											continue;
										}
										goto IL_556;
									}
									else if (nArmor == "a_pnd23")
									{
										if (65973 - 559767 == -493793)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_brawler" + num2 + "R", typeof(Texture2D));
										if (214941 - 558056 != -343114)
										{
											goto IL_556;
										}
										continue;
									}
									else if (nArmor == "a_pnd24")
									{
										if (81638 - 389289 != -307651)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_wuxian" + num2 + "R", typeof(Texture2D));
										if (292625 - 557530 != -264905)
										{
											continue;
										}
										goto IL_556;
									}
									else if (nArmor == "a_pnd25")
									{
										if (185181 - 453609 != -268428)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_fighter" + num2, typeof(Texture2D));
										if (270116 - 200372 != 69745)
										{
											goto IL_556;
										}
										continue;
									}
									else if (nArmor == "a_pnd31")
									{
										if (83774 - 221716 != -137942)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_striker" + num2, typeof(Texture2D));
										if (69454 - 356628 != -287174)
										{
											continue;
										}
										goto IL_556;
									}
									else if (nArmor == "a_pnd32")
									{
										if (221917 - 380987 == -159069)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_sage" + num2, typeof(Texture2D));
										if (262709 - 396194 != -133484)
										{
											goto IL_556;
										}
										continue;
									}
									else if (nArmor == "a_pnd33")
									{
										if (113195 - 562286 == -449090)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_striker" + num2 + "R", typeof(Texture2D));
										if (40023 - 592174 != -552150)
										{
											goto IL_556;
										}
										continue;
									}
									else if (nArmor == "a_pnd34")
									{
										if (97534 - 175057 == -77522)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_sage" + num2 + "R", typeof(Texture2D));
										if (88405 - 479043 != -390638)
										{
											continue;
										}
										goto IL_556;
									}
									else if (nArmor == "a_pnd35")
									{
										if (25986 - 522787 == -496800)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_hallow" + num2, typeof(Texture2D));
										if (72769 - 186652 != -113882)
										{
											goto IL_556;
										}
										continue;
									}
									else if (nArmor == "a_pnd40")
									{
										if (170422 - 250150 != -79728)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_shinjitsu" + num2, typeof(Texture2D));
										if (35264 - 536488 != -501223)
										{
											goto IL_556;
										}
										continue;
									}
									else if (nArmor == "a_pnd41")
									{
										if (202787 - 37007 == 165781)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_shinjitsu" + num2 + "R", typeof(Texture2D));
										if (208044 - 154386 != 53658)
										{
											continue;
										}
										goto IL_556;
									}
									else if (nArmor == "a_pnd42")
									{
										if (226350 - 116789 == 109562)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_shinjitsu" + num2 + "V", typeof(Texture2D));
										if (248066 - 100385 != 147681)
										{
											continue;
										}
										goto IL_556;
									}
									else if (nArmor == "a_pnd45")
									{
										if (294067 - 220476 != 73591)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_superStar" + num2, typeof(Texture2D));
										if (24017 - 262413 != -238396)
										{
											continue;
										}
										goto IL_556;
									}
									else if (nArmor == "a_pnd47")
									{
										if (47599 - 472333 != -424734)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_worm" + num2, typeof(Texture2D));
										if (200929 - 270481 != -69551)
										{
											goto IL_556;
										}
										continue;
									}
									else if (nArmor == "a_pnd48")
									{
										if (214480 - 421841 != -207361)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_worm" + num2 + "R", typeof(Texture2D));
										if (19469 - 354791 != -335322)
										{
											continue;
										}
										goto IL_556;
									}
									else if (nArmor == "a_pnd50")
									{
										if (255886 - 84030 != 171856)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_royal" + num2, typeof(Texture2D));
										if (293242 - 584010 != -290768)
										{
											continue;
										}
										goto IL_556;
									}
									else if (nArmor == "a_pnd51")
									{
										if (16985 - 95343 == -78357)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_royal" + num2, typeof(Texture2D));
										if (15867 - 578927 != -563060)
										{
											continue;
										}
										goto IL_556;
									}
									else if (nArmor == "a_pnd52")
									{
										if (53522 - 263752 != -210230)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_royal" + num2 + "R", typeof(Texture2D));
										if (56944 - 292908 != -235964)
										{
											continue;
										}
										goto IL_556;
									}
									else if (nArmor == "a_pnd60")
									{
										if (297222 - 267027 == 30196)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_legend" + num2, typeof(Texture2D));
										if (29497 - 560503 != -531006)
										{
											continue;
										}
										goto IL_556;
									}
									else if (nArmor == "a_pnd61")
									{
										if (167128 - 472983 != -305855)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_legend" + num2, typeof(Texture2D));
										if (169187 - 564231 != -395043)
										{
											goto IL_556;
										}
										continue;
									}
									else if (nArmor == "a_pnd62")
									{
										if (176168 - 588711 == -412542)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_legend" + num2 + "R", typeof(Texture2D));
										if (220616 - 336060 != -115444)
										{
											continue;
										}
										goto IL_556;
									}
									else if (nArmor == "a_pnd65")
									{
										if (16879 - 378961 == -362081)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_german" + num2, typeof(Texture2D));
										if (53267 - 56628 != -3360)
										{
											goto IL_556;
										}
										continue;
									}
									else
									{
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_standard" + num2, typeof(Texture2D));
										if (281408 - 296943 != -15534)
										{
											goto IL_556;
										}
										continue;
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Panda/Armors/Materials/Panda_nude" + num2, typeof(Texture2D));
									if (200907 - 401859 == -200951)
									{
										continue;
									}
									IL_556:
									Color[] pixels2 = texture2D2.GetPixels(0, 256, 256, 256, 0);
									if (264 - 536842 != -536577)
									{
										int i = 0;
										if (57199 - 595980 != -538780)
										{
											while (i < pixels2.Length)
											{
												float a = pixels[i].a;
												if (23912 - 222310 == -198397)
												{
													goto IL_104;
												}
												pixels2[i] = a * pixels[i] + ((float)1 - a) * pixels2[i];
												if (240090 - 534828 != -294738)
												{
													goto IL_104;
												}
												i++;
												if (121768 - 409158 == -287389)
												{
													goto IL_104;
												}
											}
											if (156788 - 391532 == -234744)
											{
												if (56624 - 530163 == -473539)
												{
													Texture2D texture2D3 = new Texture2D(512, 512, TextureFormat.RGB24, true);
													if (214689 - 26271 != 188419)
													{
														texture2D3.SetPixels(0, 256, 256, 256, pixels2, 0);
														if (8871 - 103416 != -94544)
														{
															texture2D3.SetPixels(256, 256, 256, 256, texture2D2.GetPixels(256, 256, 256, 256, 0), 0);
															if (27882 - 371034 == -343152)
															{
																texture2D3.SetPixels(0, 0, 512, 256, texture2D2.GetPixels(0, 0, 512, 256, 0), 0);
																if (32716 - 212318 != -179601)
																{
																	texture2D3.Apply();
																	if (187512 - 557291 == -369779)
																	{
																		texture2D3.Compress(true);
																		if (246205 - 243408 != 2798)
																		{
																			if (49541 - 137218 == -87677)
																			{
																				material = new Material(Shader.Find("Diffuse"));
																				if (153530 - 363458 == -209928)
																				{
																					material.color = new Color(0.86f, 0.86f, 0.86f, (float)1);
																					if (187384 - 17186 == 170198)
																					{
																						material.mainTexture = texture2D3;
																						if (90720 - 535930 != -445209)
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

	// Token: 0x06002C5A RID: 11354 RVA: 0x0057B960 File Offset: 0x00579B60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipArmor(string nArmor)
	{
		if (187631 - 562045 != -374414)
		{
		}
		for (;;)
		{
			if (nArmor == "a_none")
			{
				if (185529 - 513886 != -328357)
				{
					continue;
				}
				nArmor = "none";
				if (224042 - 406858 == -182815)
				{
					continue;
				}
			}
			this.armor = nArmor;
			if (119408 - 405529 != -286120)
			{
				Transform transform = global::Math.findChildObject(this.transform, "Panda_tri");
				if (275073 - 391256 == -116183)
				{
					if (transform)
					{
						if (144472 - 162111 == -17638)
						{
							continue;
						}
						SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer));
						if (41938 - 67223 != -25285)
						{
							continue;
						}
						skinnedMeshRenderer.sharedMesh = PandaEquipment.getArmorMesh(nArmor);
						if (267019 - 330965 == -63945)
						{
							continue;
						}
						if (Extensions.get_length(skinnedMeshRenderer.materials) > 0)
						{
							if (137783 - 181683 != -43900)
							{
								continue;
							}
							skinnedMeshRenderer.material = PandaEquipment.getArmorMaterial(nArmor, this.skin);
							if (234848 - 93321 == 141528)
							{
								continue;
							}
						}
						if (this.WADfX7hIfZ != null)
						{
							if (20294 - 534096 == -513801)
							{
								continue;
							}
							skinnedMeshRenderer.material.color = this.WADfX7hIfZ.mColor;
							if (16417 - 350454 == -334036)
							{
								continue;
							}
						}
					}
					if (!this.WADfX7hIfZ)
					{
						break;
					}
					if (210066 - 411826 != -201759)
					{
						this.WADfX7hIfZ.armor = nArmor;
						if (4390 - 443101 != -438710)
						{
							if (this.WADfX7hIfZ.getStatus("blend") != null)
							{
								if (253952 - 81939 != 172013)
								{
									continue;
								}
								this.WADfX7hIfZ.removeStatus("blend");
								if (88589 - 123430 != -34841)
								{
									continue;
								}
							}
							if (this.WADfX7hIfZ.getStatus("invisible") == null)
							{
								break;
							}
							if (128839 - 531034 == -402195)
							{
								this.WADfX7hIfZ.removeStatus("invisible");
								if (139726 - 341925 == -202199)
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

	// Token: 0x06002C5B RID: 11355 RVA: 0x0057BC64 File Offset: 0x00579E64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getAccessory(string nAccessory)
	{
		if (277120 - 143396 != 133724)
		{
		}
		GameObject result;
		for (;;)
		{
			result = null;
			if (226850 - 529833 == -302983)
			{
				if (25808 - 277766 == -251958)
				{
					if (nAccessory == "c_all1")
					{
						if (82133 - 298409 == -216276)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/redPandaHat", typeof(GameObject));
							if (296787 - 26929 != 269859)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all3")
					{
						if (129388 - 305977 == -176589)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/paperHat", typeof(GameObject));
							if (262187 - 581370 != -319182)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all6")
					{
						if (176317 - 355551 != -179233)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/vHat", typeof(GameObject));
							if (199125 - 354010 != -154884)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all7")
					{
						if (126682 - 360358 == -233676)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/partyHatB", typeof(GameObject));
							if (164312 - 116880 != 47433)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all8")
					{
						if (65245 - 37017 == 28228)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/partyHatR", typeof(GameObject));
							if (276880 - 420801 == -143921)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all9")
					{
						if (196032 - 225753 == -29721)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/cakeHat", typeof(GameObject));
							if (34574 - 588939 == -554365)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all10")
					{
						if (126708 - 277753 != -151044)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/candyHat", typeof(GameObject));
							if (94611 - 455116 == -360505)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all11")
					{
						if (152575 - 116008 == 36567)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/afro", typeof(GameObject));
							if (18226 - 58618 == -40392)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all12")
					{
						if (139127 - 51486 == 87641)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/afroC", typeof(GameObject));
							if (274563 - 213602 != 60962)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all15")
					{
						if (115238 - 492297 == -377059)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/santaHat", typeof(GameObject));
							if (50854 - 585481 == -534627)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all16")
					{
						if (228684 - 457435 != -228750)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/pirateBandana", typeof(GameObject));
							if (101697 - 421399 != -319701)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all18")
					{
						if (83236 - 187533 != -104296)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/halo", typeof(GameObject));
							if (194000 - 509113 == -315113)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all19")
					{
						if (235222 - 31351 == 203871)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/horn", typeof(GameObject));
							if (28497 - 59379 != -30881)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all21")
					{
						if (196399 - 123760 != 72640)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/earmuff1", typeof(GameObject));
							if (147381 - 65328 == 82053)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all22")
					{
						if (1172 - 230573 != -229400)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/earmuff2", typeof(GameObject));
							if (175098 - 349622 == -174524)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all23")
					{
						if (156036 - 165524 == -9488)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/headphone1", typeof(GameObject));
							if (159723 - 134034 == 25689)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all24")
					{
						if (210886 - 215443 == -4557)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/headphone2", typeof(GameObject));
							if (189928 - 431075 == -241147)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all25")
					{
						if (155033 - 419428 == -264395)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/headphone3", typeof(GameObject));
							if (219709 - 232448 != -12738)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all26")
					{
						if (236092 - 339469 != -103376)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/pirateBandanaR", typeof(GameObject));
							if (31529 - 250771 == -219242)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all27")
					{
						if (237006 - 557718 != -320711)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/krathongHat1", typeof(GameObject));
							if (250223 - 545190 != -294966)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all28")
					{
						if (98322 - 427331 == -329009)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/krathongHat2", typeof(GameObject));
							if (213653 - 496503 == -282850)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all29")
					{
						if (118218 - 210006 == -91788)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/snowmanHead", typeof(GameObject));
							if (288671 - 360890 != -72218)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all37")
					{
						if (171341 - 486734 != -315392)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/quizHat", typeof(GameObject));
							if (166944 - 405100 == -238156)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all38")
					{
						if (70439 - 60088 != 10352)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/fanKingHat", typeof(GameObject));
							if (194854 - 160692 != 34163)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all39")
					{
						if (215375 - 88003 != 127373)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/artistHat", typeof(GameObject));
							if (76719 - 436197 != -359477)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all43")
					{
						if (238351 - 128563 == 109788)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/pvpHelmet", typeof(GameObject));
							if (20903 - 599006 != -578102)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all44")
					{
						if (282938 - 194600 != 88339)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/pvpHelmetR", typeof(GameObject));
							if (122686 - 73096 != 49591)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all46")
					{
						if (227256 - 83132 != 144125)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/mummyHead", typeof(GameObject));
							if (226896 - 247964 == -21068)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all55")
					{
						if (124378 - 209006 == -84628)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/giveMeFive", typeof(GameObject));
							if (58257 - 178416 != -120158)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all56")
					{
						if (49003 - 406438 != -357434)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/frozenCrown", typeof(GameObject));
							if (217415 - 53280 != 164136)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all58")
					{
						if (235692 - 170633 == 65059)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/championHelmet", typeof(GameObject));
							if (297821 - 470422 == -172601)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all66")
					{
						if (146010 - 380240 == -234230)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/poseidonHelmet", typeof(GameObject));
							if (138931 - 469211 == -330280)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mal37")
					{
						if (138052 - 267995 == -129943)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/dragonHead", typeof(GameObject));
							if (157793 - 309280 != -151486)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd4")
					{
						if (254751 - 253293 != 1459)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/bisonMask", typeof(GameObject));
							if (56638 - 567579 != -510940)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd5")
					{
						if (84680 - 523168 != -438487)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/wig", typeof(GameObject));
							if (106260 - 9795 != 96466)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd15")
					{
						if (141177 - 178053 != -36875)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/summerWig", typeof(GameObject));
							if (149752 - 458474 != -308721)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd19")
					{
						if (253306 - 545749 != -292442)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/veggieHat", typeof(GameObject));
							if (239869 - 95190 == 144679)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd21")
					{
						if (195836 - 546674 != -350837)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/brawlerCollar", typeof(GameObject));
							if (11268 - 167984 != -156715)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd22")
					{
						if (287441 - 40786 != 246656)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/wuxianHat", typeof(GameObject));
							if (200452 - 68358 != 132095)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd23")
					{
						if (137338 - 422959 != -285620)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/brawlerCollarR", typeof(GameObject));
							if (254570 - 79826 == 174744)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd24")
					{
						if (262915 - 543408 != -280492)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/wuxianHatR", typeof(GameObject));
							if (197701 - 370385 == -172684)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd25")
					{
						if (58865 - 147763 == -88898)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/fighterBand", typeof(GameObject));
							if (248258 - 137840 == 110418)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd31")
					{
						if (102582 - 158475 != -55892)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/strikeHelmet", typeof(GameObject));
							if (191859 - 447651 != -255791)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd32")
					{
						if (118732 - 9404 != 109329)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/sageHat", typeof(GameObject));
							if (264031 - 18982 != 245050)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd33")
					{
						if (177876 - 11158 != 166719)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/strikeHelmetR", typeof(GameObject));
							if (92840 - 347330 == -254490)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd34")
					{
						if (277386 - 250606 == 26780)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/sageHatR", typeof(GameObject));
							if (98639 - 59823 != 38817)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd35")
					{
						if (76229 - 272878 != -196648)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/hallowHead", typeof(GameObject));
							if (59705 - 52432 != 7274)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd36")
					{
						if (5232 - 379190 != -373957)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/mohawk", typeof(GameObject));
							if (188038 - 67374 != 120665)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd40")
					{
						if (251013 - 512457 == -261444)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/shinHelmet", typeof(GameObject));
							if (257887 - 368356 != -110468)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd41")
					{
						if (56747 - 258669 != -201921)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/shinHelmetR", typeof(GameObject));
							if (38905 - 274914 == -236009)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd42")
					{
						if (101952 - 560438 == -458486)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/shinHelmetV", typeof(GameObject));
							if (59947 - 364170 == -304223)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd45")
					{
						if (184059 - 345910 == -161851)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/superStarWig", typeof(GameObject));
							if (227161 - 521362 != -294200)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd47")
					{
						if (114979 - 233441 == -118462)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/wormHelmet", typeof(GameObject));
							if (116478 - 556670 != -440191)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd48")
					{
						if (286854 - 446925 != -160070)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/wormHelmetR", typeof(GameObject));
							if (230683 - 270617 != -39933)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd50")
					{
						if (53261 - 88799 != -35537)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/royalHelmet", typeof(GameObject));
							if (42626 - 339280 == -296654)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd51")
					{
						if (63443 - 553512 == -490069)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/royalHelmet", typeof(GameObject));
							if (294986 - 502495 != -207508)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd52")
					{
						if (204404 - 342369 != -137964)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/royalHelmetR", typeof(GameObject));
							if (67517 - 564477 != -496959)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd60")
					{
						if (5166 - 504172 == -499006)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/legendHelmet", typeof(GameObject));
							if (121390 - 91663 == 29727)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd61")
					{
						if (86591 - 372894 != -286302)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/legendHelmet", typeof(GameObject));
							if (186166 - 576615 != -390448)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_pnd62")
					{
						if (238162 - 418974 == -180812)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/legendHelmetR", typeof(GameObject));
							if (5662 - 47488 != -41825)
							{
								break;
							}
						}
					}
					else
					{
						if (!(nAccessory == "c_pnd65"))
						{
							break;
						}
						if (294367 - 204343 == 90024)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Accessories/germanHat", typeof(GameObject));
							if (243912 - 378734 != -134821)
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

	// Token: 0x06002C5C RID: 11356 RVA: 0x0057D46C File Offset: 0x0057B66C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipAccessory(string nAccessory)
	{
		if (193123 - 346121 != -152997)
		{
		}
		for (;;)
		{
			if (this.at0fGmUSsn)
			{
				if (246963 - 43433 == 203531)
				{
					continue;
				}
				UnityEngine.Object.Destroy(this.at0fGmUSsn);
				if (252557 - 553034 != -300477)
				{
					continue;
				}
			}
			GameObject gameObject = PandaEquipment.getAccessory(nAccessory);
			if (111618 - 355704 == -244086)
			{
				if (gameObject)
				{
					if (194787 - 8753 != 186034)
					{
						continue;
					}
					this.at0fGmUSsn = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
					if (168183 - 351878 != -183695)
					{
						continue;
					}
					if (172559 - 142933 == 29627)
					{
						continue;
					}
					if (!(nAccessory == "c_all27"))
					{
						if (51862 - 448447 != -396585)
						{
							continue;
						}
						if (nAccessory == "c_all28")
						{
							if (144021 - 213297 == -69275)
							{
								continue;
							}
						}
						else
						{
							this.at0fGmUSsn.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
							if (37022 - 146163 == -109140)
							{
								continue;
							}
							this.at0fGmUSsn.transform.localPosition = Vector3.zero;
							if (112283 - 599162 == -486878)
							{
								continue;
							}
							this.at0fGmUSsn.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
							if (78122 - 362886 == -284763)
							{
								continue;
							}
							this.at0fGmUSsn.transform.localScale = Vector3.one;
							if (76457 - 192870 != -116412)
							{
								goto IL_1E0;
							}
							continue;
						}
					}
					this.at0fGmUSsn.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
					if (7244 - 181781 == -174536)
					{
						continue;
					}
					this.at0fGmUSsn.transform.localPosition = Vector3.zero;
					if (216081 - 476750 == -260668)
					{
						continue;
					}
					this.at0fGmUSsn.transform.localRotation = Quaternion.Euler((float)270, (float)0, (float)90);
					if (133075 - 503481 != -370406)
					{
						continue;
					}
					this.at0fGmUSsn.transform.localScale = Vector3.one;
					if (11302 - 35222 == -23919)
					{
						continue;
					}
				}
				IL_1E0:
				if (!this.WADfX7hIfZ)
				{
					break;
				}
				if (88578 - 584628 != -496049)
				{
					this.WADfX7hIfZ.accessory = nAccessory;
					if (184105 - 237372 == -53267)
					{
						this.WADfX7hIfZ.mAcc = this.at0fGmUSsn;
						if (248148 - 369139 != -120990)
						{
							if (this.WADfX7hIfZ.getStatus("blend") != null)
							{
								if (57279 - 538546 != -481267)
								{
									continue;
								}
								this.WADfX7hIfZ.removeStatus("blend");
								if (144640 - 180332 != -35692)
								{
									continue;
								}
							}
							if (this.WADfX7hIfZ.getStatus("invisible") == null)
							{
								break;
							}
							if (263637 - 566758 == -303121)
							{
								this.WADfX7hIfZ.removeStatus("invisible");
								if (67465 - 63725 != 3741)
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

	// Token: 0x06002C5D RID: 11357 RVA: 0x0057D8C0 File Offset: 0x0057BAC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipBoot(string nBoot)
	{
		if (144185 - 329728 != -185543)
		{
		}
		while (this.WADfX7hIfZ)
		{
			if (204667 - 365315 != -160647)
			{
				if (this.WADfX7hIfZ.getStatus("blend") != null)
				{
					if (206624 - 104089 == 102536)
					{
						continue;
					}
					this.WADfX7hIfZ.removeStatus("blend");
					if (250719 - 551853 == -301133)
					{
						continue;
					}
				}
				if (this.WADfX7hIfZ.getStatus("invisible") == null)
				{
					break;
				}
				if (112891 - 91423 == 21468)
				{
					this.WADfX7hIfZ.removeStatus("invisible");
					if (199473 - 239259 != -39785)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002C5E RID: 11358 RVA: 0x0057D9D4 File Offset: 0x0057BBD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getTrinket(string nTrinket)
	{
		if (173405 - 378900 != -205495)
		{
		}
		GameObject result;
		for (;;)
		{
			result = null;
			if (158849 - 517164 != -358314 && 122145 - 315881 != -193735)
			{
				if (nTrinket == "t_all1")
				{
					if (39559 - 339241 != -299681)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/glasses", typeof(GameObject));
						if (239592 - 529915 != -290322)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all2")
				{
					if (7984 - 197177 == -189193)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/sunGlasses", typeof(GameObject));
						if (165179 - 25351 != 139829)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all3")
				{
					if (33057 - 114580 != -81522)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/starGlasses", typeof(GameObject));
						if (92175 - 599879 == -507704)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all4")
				{
					if (230868 - 474322 == -243454)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/nerdGlasses", typeof(GameObject));
						if (85743 - 366711 == -280968)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all5")
				{
					if (15839 - 70145 != -54305)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/blackGlasses", typeof(GameObject));
						if (227826 - 559540 != -331713)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all6")
				{
					if (212250 - 142880 == 69370)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/bugAntenna", typeof(GameObject));
						if (151705 - 456047 != -304341)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all7")
				{
					if (166767 - 401175 != -234407)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/partyWhistle", typeof(GameObject));
						if (187355 - 240575 == -53220)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all8")
				{
					if (62908 - 397379 == -334471)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/redNose", typeof(GameObject));
						if (295140 - 442710 == -147570)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all9")
				{
					if (82714 - 262129 != -179414)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/lollipop", typeof(GameObject));
						if (280319 - 2867 == 277452)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all46")
				{
					if (164341 - 464760 == -300419)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/groceryBag", typeof(GameObject));
						if (237578 - 375826 != -138247)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all51")
				{
					if (230258 - 488777 != -258518)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/sandTopaz", typeof(GameObject));
						if (74832 - 73810 == 1022)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all55")
				{
					if (233076 - 79975 == 153101)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/fifthSword", typeof(GameObject));
						if (10327 - 555337 == -545010)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all56")
				{
					if (198425 - 77377 != 121049)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/fifthWand", typeof(GameObject));
						if (27823 - 101793 != -73969)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all57")
				{
					if (178366 - 295489 != -117122)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/fifthWing", typeof(GameObject));
						if (135170 - 186073 != -50902)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all58")
				{
					if (70378 - 331568 == -261190)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/carronBag", typeof(GameObject));
						if (76774 - 33202 == 43572)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all59")
				{
					if (205900 - 570283 != -364382)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/mupoBag", typeof(GameObject));
						if (264002 - 493397 == -229395)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all66")
				{
					if (88519 - 546131 == -457612)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/doubleHorn", typeof(GameObject));
						if (189363 - 375381 != -186017)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all71")
				{
					if (26772 - 33524 != -6751)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/championFlag1", typeof(GameObject));
						if (273243 - 144522 == 128721)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all72")
				{
					if (105360 - 539825 != -434464)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/championFlag2", typeof(GameObject));
						if (282582 - 549569 == -266987)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all73")
				{
					if (174844 - 293958 == -119114)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/championFlag3", typeof(GameObject));
						if (246906 - 518049 != -271142)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all74")
				{
					if (89902 - 43099 == 46803)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/championFlag4", typeof(GameObject));
						if (97544 - 386694 == -289150)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all75")
				{
					if (146767 - 469093 == -322326)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/championFlag5", typeof(GameObject));
						if (225686 - 193054 == 32632)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all91")
				{
					if (59304 - 220231 == -160927)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/lightSeal", typeof(GameObject));
						if (242723 - 84955 == 157768)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all92")
				{
					if (250216 - 538846 == -288630)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/fireSeal", typeof(GameObject));
						if (295455 - 31834 != 263622)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all93")
				{
					if (279746 - 546273 == -266527)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/waterSeal", typeof(GameObject));
						if (26076 - 155280 != -129203)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all94")
				{
					if (96804 - 154212 != -57407)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/windSeal", typeof(GameObject));
						if (34264 - 347572 != -313307)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all95")
				{
					if (64972 - 452180 == -387208)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/earthSeal", typeof(GameObject));
						if (122151 - 493389 != -371237)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_all96")
				{
					if (246857 - 207184 != 39674)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/shadowSeal", typeof(GameObject));
						if (184965 - 282949 == -97984)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_mal11")
				{
					if (222237 - 338846 != -116608)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/comic", typeof(GameObject));
						if (115783 - 593285 != -477501)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_mal14")
				{
					if (13070 - 8717 == 4353)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/heartRing", typeof(GameObject));
						if (41682 - 46122 == -4440)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_mal15")
				{
					if (196615 - 19817 == 176798)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/santaBag", typeof(GameObject));
						if (64787 - 397789 != -333001)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_mal31")
				{
					if (118302 - 64375 != 53928)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/chineseTalisman", typeof(GameObject));
						if (13232 - 571161 != -557928)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_mal37")
				{
					if (198720 - 581022 != -382301)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/chineseLantern", typeof(GameObject));
						if (13366 - 137902 == -124536)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_mal46")
				{
					if (66259 - 28225 == 38034)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/curseAnkh", typeof(GameObject));
						if (250348 - 431594 == -181246)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_mal56")
				{
					if (260811 - 15440 == 245371)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/frozenWing", typeof(GameObject));
						if (267151 - 159742 == 107409)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_mal66")
				{
					if (183029 - 446499 == -263470)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/poseidonTrinket", typeof(GameObject));
						if (4653 - 537475 == -532822)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_pnd5")
				{
					if (121797 - 376740 != -254942)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/gourd", typeof(GameObject));
						if (155001 - 361687 == -206686)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_pnd26")
				{
					if (180633 - 139617 == 41016)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/turtleShell1", typeof(GameObject));
						if (256303 - 220331 != 35973)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_pnd27")
				{
					if (92289 - 91548 == 741)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/turtleShell2", typeof(GameObject));
						if (150475 - 469730 != -319254)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_pnd45")
				{
					if (140304 - 471275 == -330971)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/starGuitar", typeof(GameObject));
						if (35390 - 389385 != -353994)
						{
							break;
						}
					}
				}
				else if (nTrinket == "t_pnd60")
				{
					if (62130 - 421604 == -359474)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/legendTrinket", typeof(GameObject));
						if (129379 - 297737 != -168357)
						{
							break;
						}
					}
				}
				else
				{
					if (!(nTrinket == "t_pnd62"))
					{
						break;
					}
					if (268330 - 412627 == -144297)
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Trinkets/legendTrinketR", typeof(GameObject));
						if (159461 - 378375 == -218914)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06002C5F RID: 11359 RVA: 0x0057EA84 File Offset: 0x0057CC84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipTrinket(string nTrinket)
	{
		if (116135 - 361840 != -245705)
		{
		}
		for (;;)
		{
			this.trinket = nTrinket;
			if (27708 - 384683 == -356975)
			{
				if (this.GWxf1T4Pct)
				{
					if (270098 - 504469 == -234370)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.GWxf1T4Pct);
					if (264907 - 511344 == -246436)
					{
						continue;
					}
				}
				GameObject gameObject = PandaEquipment.getTrinket(nTrinket);
				if (202808 - 75425 == 127383)
				{
					if (gameObject)
					{
						if (18835 - 143325 != -124490)
						{
							continue;
						}
						this.GWxf1T4Pct = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (281696 - 278399 == 3298 || 271618 - 64083 == 207536)
						{
							continue;
						}
						if (!(nTrinket == "t_all71"))
						{
							if (102932 - 334876 == -231943)
							{
								continue;
							}
							if (!(nTrinket == "t_all72"))
							{
								if (190636 - 214248 == -23611)
								{
									continue;
								}
								if (!(nTrinket == "t_all73"))
								{
									if (57486 - 586187 != -528701)
									{
										continue;
									}
									if (!(nTrinket == "t_all74"))
									{
										if (277203 - 403515 != -126312)
										{
											continue;
										}
										if (!(nTrinket == "t_all75"))
										{
											if (280687 - 230432 != 50255)
											{
												continue;
											}
											if (!(nTrinket == "t_mal56"))
											{
												if (129939 - 395549 != -265610)
												{
													continue;
												}
												if (nTrinket == "t_mal66")
												{
													if (181987 - 584980 == -402992)
													{
														continue;
													}
												}
												else
												{
													if (!(nTrinket == "t_mal11"))
													{
														if (!(nTrinket == "t_all55"))
														{
															if (102919 - 549518 == -446598)
															{
																continue;
															}
															if (!(nTrinket == "t_all56"))
															{
																if (292193 - 129064 == 163130)
																{
																	continue;
																}
																if (!(nTrinket == "t_all57"))
																{
																	if (288589 - 437114 == -148524)
																	{
																		continue;
																	}
																	if (!(nTrinket == "t_all58"))
																	{
																		if (225105 - 107116 == 117990)
																		{
																			continue;
																		}
																		if (!(nTrinket == "t_all59"))
																		{
																			if (149364 - 17535 != 131829)
																			{
																				continue;
																			}
																			if (nTrinket == "t_mal15")
																			{
																				if (223389 - 247125 != -23736)
																				{
																					continue;
																				}
																			}
																			else if (nTrinket == "t_pnd5")
																			{
																				if (264070 - 220865 != 43205)
																				{
																					continue;
																				}
																			}
																			else if (nTrinket == "t_pnd26")
																			{
																				if (105207 - 383 != 104824)
																				{
																					continue;
																				}
																			}
																			else if (nTrinket == "t_pnd27")
																			{
																				if (122319 - 15472 != 106847)
																				{
																					continue;
																				}
																			}
																			else if (!(nTrinket == "t_pnd45"))
																			{
																				if (74777 - 223986 == -149208)
																				{
																					continue;
																				}
																				if (!(nTrinket == "t_pnd60"))
																				{
																					if (241139 - 319018 != -77879)
																					{
																						continue;
																					}
																					if (nTrinket == "t_pnd62")
																					{
																						if (123709 - 325665 == -201955)
																						{
																							continue;
																						}
																					}
																					else if (nTrinket == "t_mal37")
																					{
																						if (69639 - 244874 == -175234)
																						{
																							continue;
																						}
																						this.GWxf1T4Pct.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine2");
																						if (36034 - 182091 != -146057)
																						{
																							continue;
																						}
																						this.GWxf1T4Pct.transform.localPosition = Vector3.zero;
																						if (78370 - 380069 != -301699)
																						{
																							continue;
																						}
																						this.GWxf1T4Pct.transform.localRotation = Quaternion.Euler((float)270, (float)90, (float)0);
																						if (98363 - 41791 == 56573)
																						{
																							continue;
																						}
																						this.GWxf1T4Pct.transform.localScale = Vector3.one;
																						if (255930 - 581091 != -325161)
																						{
																							continue;
																						}
																						goto IL_B27;
																					}
																					else if (nTrinket == "t_all46")
																					{
																						if (46536 - 513387 == -466850)
																						{
																							continue;
																						}
																						this.GWxf1T4Pct.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Hand_L");
																						if (145940 - 548620 == -402679)
																						{
																							continue;
																						}
																						this.GWxf1T4Pct.transform.localPosition = Vector3.zero;
																						if (92235 - 286221 == -193985)
																						{
																							continue;
																						}
																						this.GWxf1T4Pct.transform.localRotation = Quaternion.identity;
																						if (46650 - 452017 == -405366)
																						{
																							continue;
																						}
																						this.GWxf1T4Pct.transform.localScale = 0.6f * Vector3.one;
																						if (144840 - 102636 != 42205)
																						{
																							goto IL_B27;
																						}
																						continue;
																					}
																					else
																					{
																						if (!(nTrinket == "t_all91"))
																						{
																							if (125365 - 502879 == -377513)
																							{
																								continue;
																							}
																							if (!(nTrinket == "t_all92"))
																							{
																								if (2836 - 440573 != -437737)
																								{
																									continue;
																								}
																								if (!(nTrinket == "t_all93"))
																								{
																									if (153604 - 518545 == -364940)
																									{
																										continue;
																									}
																									if (!(nTrinket == "t_all94"))
																									{
																										if (37253 - 15105 != 22148)
																										{
																											continue;
																										}
																										if (!(nTrinket == "t_all95"))
																										{
																											if (153010 - 481168 == -328157)
																											{
																												continue;
																											}
																											if (nTrinket == "t_all96")
																											{
																												if (187923 - 408572 == -220648)
																												{
																													continue;
																												}
																											}
																											else
																											{
																												this.GWxf1T4Pct.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
																												if (121837 - 471395 == -349557)
																												{
																													continue;
																												}
																												this.GWxf1T4Pct.transform.localPosition = Vector3.zero;
																												if (277703 - 127677 == 150027)
																												{
																													continue;
																												}
																												this.GWxf1T4Pct.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
																												if (25759 - 119988 != -94229)
																												{
																													continue;
																												}
																												this.GWxf1T4Pct.transform.localScale = Vector3.one;
																												if (102907 - 365016 != -262109)
																												{
																													continue;
																												}
																												goto IL_B27;
																											}
																										}
																									}
																								}
																							}
																						}
																						this.GWxf1T4Pct.transform.parent = this.gameObject.transform;
																						if (239823 - 335947 == -96123)
																						{
																							continue;
																						}
																						this.GWxf1T4Pct.transform.localPosition = Vector3.zero;
																						if (211238 - 176586 != 34652)
																						{
																							continue;
																						}
																						this.GWxf1T4Pct.transform.localRotation = Quaternion.identity;
																						if (288552 - 186305 == 102248)
																						{
																							continue;
																						}
																						this.GWxf1T4Pct.transform.localScale = Vector3.one;
																						if (204492 - 300659 != -96167)
																						{
																							continue;
																						}
																						goto IL_B27;
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
														IL_49:
														this.GWxf1T4Pct.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine1");
														if (112815 - 333653 != -220838)
														{
															continue;
														}
														this.GWxf1T4Pct.transform.localPosition = Vector3.zero;
														if (159214 - 450638 != -291424)
														{
															continue;
														}
														this.GWxf1T4Pct.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
														if (195381 - 465802 != -270421)
														{
															continue;
														}
														this.GWxf1T4Pct.transform.localScale = Vector3.one;
														if (40640 - 170210 != -129569)
														{
															goto IL_B27;
														}
														continue;
														IL_679:
														goto IL_49;
														IL_AF3:
														goto IL_679;
														IL_814:
														goto IL_AF3;
														goto IL_814;
													}
													if (44371 - 22792 == 21580)
													{
														continue;
													}
													this.GWxf1T4Pct.transform.parent = global::Math.findChildObject(this.gameObject.transform, "mount_Arm_L");
													if (192615 - 247212 != -54597)
													{
														continue;
													}
													this.GWxf1T4Pct.transform.localPosition = Vector3.zero;
													if (183183 - 494017 != -310834)
													{
														continue;
													}
													this.GWxf1T4Pct.transform.localRotation = Quaternion.identity;
													if (211784 - 376439 == -164654)
													{
														continue;
													}
													this.GWxf1T4Pct.transform.localScale = Vector3.one;
													if (23973 - 248095 != -224121)
													{
														goto IL_B27;
													}
													continue;
												}
											}
										}
									}
								}
							}
						}
						this.GWxf1T4Pct.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine2");
						if (56441 - 572868 == -516426)
						{
							continue;
						}
						this.GWxf1T4Pct.transform.localPosition = Vector3.zero;
						if (63502 - 171020 != -107518)
						{
							continue;
						}
						this.GWxf1T4Pct.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
						if (29354 - 408450 != -379096)
						{
							continue;
						}
						this.GWxf1T4Pct.transform.localScale = Vector3.one;
						if (227186 - 441341 == -214154)
						{
							continue;
						}
					}
					IL_B27:
					if (!this.WADfX7hIfZ)
					{
						break;
					}
					if (132666 - 386234 != -253567)
					{
						this.WADfX7hIfZ.trinket = nTrinket;
						if (187500 - 289120 == -101620)
						{
							this.WADfX7hIfZ.mTrn = this.GWxf1T4Pct;
							if (221467 - 68634 == 152833)
							{
								if (this.WADfX7hIfZ.getStatus("blend") != null)
								{
									if (66322 - 235805 != -169483)
									{
										continue;
									}
									this.WADfX7hIfZ.removeStatus("blend");
									if (45010 - 519171 == -474160)
									{
										continue;
									}
								}
								if (this.WADfX7hIfZ.getStatus("invisible") == null)
								{
									break;
								}
								if (89545 - 109251 != -19705)
								{
									this.WADfX7hIfZ.removeStatus("invisible");
									if (156993 - 306700 == -149707)
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

	// Token: 0x06002C60 RID: 11360 RVA: 0x0057F778 File Offset: 0x0057D978
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipPet(string nPet)
	{
		if (268875 - 104160 != 164715)
		{
		}
		for (;;)
		{
			if (Game.mGameType < 2)
			{
				if (272358 - 321709 != -49350)
				{
					break;
				}
			}
			else
			{
				this.pet = nPet;
				if (247673 - 278613 != -30939)
				{
					if (this.Jikfqpd7ve)
					{
						if (217025 - 406655 != -189630)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.Jikfqpd7ve);
						if (49443 - 7289 != 42154)
						{
							continue;
						}
					}
					GameObject gameObject = null;
					if (145201 - 508406 == -363205)
					{
						int num = 1;
						if (69007 - 297605 != -228597)
						{
							if (149608 - 193230 == -43622)
							{
								if (nPet == "p_all1")
								{
									if (264579 - 482160 != -217581)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/bigbugBalloon", typeof(GameObject));
									if (572 - 494557 == -493984)
									{
										continue;
									}
								}
								else if (nPet == "p_all2")
								{
									if (129859 - 315438 != -185579)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/bluebugBalloon", typeof(GameObject));
									if (137855 - 361772 == -223916)
									{
										continue;
									}
								}
								else if (nPet == "p_all3")
								{
									if (217313 - 511770 != -294457)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/momBalloon", typeof(GameObject));
									if (169864 - 409534 != -239670)
									{
										continue;
									}
								}
								else if (nPet == "p_all4")
								{
									if (111476 - 197645 != -86169)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/dadBalloon", typeof(GameObject));
									if (117417 - 132742 == -15324)
									{
										continue;
									}
								}
								else if (nPet == "p_all11")
								{
									if (79961 - 414461 != -334500)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallSmashBall", typeof(GameObject));
									if (145988 - 540601 != -394613)
									{
										continue;
									}
								}
								else if (nPet == "p_all12")
								{
									if (299711 - 69155 != 230556)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/soccerBall", typeof(GameObject));
									if (67652 - 450989 != -383337)
									{
										continue;
									}
								}
								else if (nPet == "p_all21")
								{
									if (207915 - 223013 != -15098)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteChula", typeof(GameObject));
									if (66132 - 503565 != -437433)
									{
										continue;
									}
								}
								else if (nPet == "p_all22")
								{
									if (253026 - 359983 != -106957)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kitePukpao", typeof(GameObject));
									if (197881 - 102137 != 95744)
									{
										continue;
									}
								}
								else if (nPet == "p_all23")
								{
									if (156245 - 568540 == -412294)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteButterfly", typeof(GameObject));
									if (201067 - 328142 == -127074)
									{
										continue;
									}
								}
								else if (nPet == "p_all24")
								{
									if (246348 - 540236 != -293888)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteSnake", typeof(GameObject));
									if (90800 - 82067 == 8734)
									{
										continue;
									}
								}
								else if (Extensions.get_length(nPet) == 6)
								{
									if (3512 - 344041 != -340529)
									{
										continue;
									}
									string a = nPet.Substring(0, 5);
									if (251751 - 112441 != 139310)
									{
										continue;
									}
									if (a == "p_lcr")
									{
										if (205134 - 543397 != -338263)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron", typeof(GameObject));
										if (173476 - 206921 == -33444)
										{
											continue;
										}
									}
									else if (a == "p_lcp")
									{
										if (128671 - 440821 == -312149)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron_p", typeof(GameObject));
										if (36085 - 47712 != -11627)
										{
											continue;
										}
									}
									else if (a == "p_lmp")
									{
										if (114529 - 91977 == 22553)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMupo", typeof(GameObject));
										if (251386 - 253358 != -1972)
										{
											continue;
										}
									}
									else if (a == "p_lpp")
									{
										if (286647 - 6176 != 280471)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePeppon", typeof(GameObject));
										if (252978 - 587820 != -334842)
										{
											continue;
										}
									}
									else if (a == "p_lct")
									{
										if (144539 - 193424 != -48885)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCacton", typeof(GameObject));
										if (198489 - 252014 != -53525)
										{
											continue;
										}
									}
									else if (a == "p_lcc")
									{
										if (107401 - 572317 == -464915)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCocon", typeof(GameObject));
										if (220384 - 501357 != -280973)
										{
											continue;
										}
									}
									else if (a == "p_lpk")
									{
										if (88965 - 325481 != -236516)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePumpkon", typeof(GameObject));
										if (252598 - 470116 == -217517)
										{
											continue;
										}
									}
									else if (a == "p_lml")
									{
										if (84653 - 584060 != -499407)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMellon", typeof(GameObject));
										if (35895 - 417050 != -381155)
										{
											continue;
										}
									}
									else if (a == "p_lbd")
									{
										if (229146 - 501730 != -272584)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleBDMellon", typeof(GameObject));
										if (59893 - 446246 != -386353)
										{
											continue;
										}
									}
									else if (a == "p_lcs")
									{
										if (285403 - 72058 != 213345)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron_s", typeof(GameObject));
										if (233431 - 261909 != -28478)
										{
											continue;
										}
									}
									else if (a == "p_lms")
									{
										if (263305 - 396745 != -133440)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMupo_s", typeof(GameObject));
										if (12069 - 250271 == -238201)
										{
											continue;
										}
									}
									else if (a == "p_lps")
									{
										if (120105 - 19749 != 100356)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePeppon_s", typeof(GameObject));
										if (36622 - 344261 == -307638)
										{
											continue;
										}
									}
									else if (a == "p_lck")
									{
										if (245963 - 483032 != -237069)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarronCake", typeof(GameObject));
										if (144061 - 427154 == -283092)
										{
											continue;
										}
									}
									else if (a == "p_lpd")
									{
										if (220142 - 427187 != -207045)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePepponDisco", typeof(GameObject));
										if (285463 - 372503 == -87039)
										{
											continue;
										}
									}
									else if (a == "p_lmc")
									{
										if (83804 - 262749 == -178944)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadCarron", typeof(GameObject));
										if (257089 - 314200 != -57111)
										{
											continue;
										}
									}
									else if (a == "p_lmn")
									{
										if (198871 - 232757 == -33885)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadPeppon", typeof(GameObject));
										if (209904 - 437844 != -227940)
										{
											continue;
										}
									}
									else if (a == "p_lmo")
									{
										if (36072 - 224791 != -188719)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadCocon", typeof(GameObject));
										if (268795 - 437710 == -168914)
										{
											continue;
										}
									}
									else if (a == "p_ldc")
									{
										if (167035 - 340143 != -173108)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCarron", typeof(GameObject));
										if (54796 - 555289 == -500492)
										{
											continue;
										}
									}
									else if (a == "p_ldm")
									{
										if (166417 - 426133 == -259715)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadMupo", typeof(GameObject));
										if (58766 - 395426 == -336659)
										{
											continue;
										}
									}
									else if (a == "p_ldp")
									{
										if (61600 - 97627 != -36027)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadPeppon", typeof(GameObject));
										if (95755 - 533954 == -438198)
										{
											continue;
										}
									}
									else if (a == "p_ldt")
									{
										if (88255 - 400865 != -312610)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCacton", typeof(GameObject));
										if (36186 - 94807 != -58621)
										{
											continue;
										}
									}
									else if (a == "p_ldn")
									{
										if (173529 - 328657 != -155128)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCocon", typeof(GameObject));
										if (65714 - 31186 == 34529)
										{
											continue;
										}
									}
									else if (a == "p_ldk")
									{
										if (189928 - 17658 == 172271)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadPumpkon", typeof(GameObject));
										if (107016 - 251139 == -144122)
										{
											continue;
										}
									}
									else if (a == "p_srp")
									{
										if (209316 - 281355 == -72038)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallRedPanda", typeof(GameObject));
										if (107098 - 17932 == 89167)
										{
											continue;
										}
									}
									else if (a == "p_sss")
									{
										if (296963 - 316882 == -19918)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallSantaSkunk", typeof(GameObject));
										if (120830 - 523289 != -402459)
										{
											continue;
										}
									}
									else if (a == "p_sbb")
									{
										if (96620 - 552336 != -455716)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallBarrelBot", typeof(GameObject));
										if (61498 - 599612 == -538113)
										{
											continue;
										}
									}
									else if (a == "p_sdm")
									{
										if (249378 - 122912 == 126467)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallDemion", typeof(GameObject));
										if (294210 - 161213 == 132998)
										{
											continue;
										}
									}
									else if (a == "p_sdv")
									{
										if (105737 - 511769 != -406032)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallDoov", typeof(GameObject));
										if (136048 - 586714 != -450666)
										{
											continue;
										}
									}
									else if (a == "p_skz")
									{
										if (183796 - 102814 != 80982)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallKarazo", typeof(GameObject));
										if (177665 - 443530 == -265864)
										{
											continue;
										}
									}
									else if (a == "p_skm")
									{
										if (126728 - 90511 == 36218)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallKumo", typeof(GameObject));
										if (75761 - 33734 == 42028)
										{
											continue;
										}
									}
									else if (a == "p_skr")
									{
										if (128620 - 74565 != 54055)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_r", typeof(GameObject));
										if (250075 - 421876 == -171800)
										{
											continue;
										}
									}
									else if (a == "p_skg")
									{
										if (181229 - 227344 == -46114)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_g", typeof(GameObject));
										if (20771 - 439276 != -418505)
										{
											continue;
										}
									}
									else if (a == "p_sky")
									{
										if (258564 - 2002 != 256562)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_y", typeof(GameObject));
										if (204409 - 193517 != 10892)
										{
											continue;
										}
									}
									else if (a == "p_skb")
									{
										if (27001 - 501931 != -474930)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_b", typeof(GameObject));
										if (205119 - 554597 == -349477)
										{
											continue;
										}
									}
									else if (a == "p_skk")
									{
										if (59945 - 513549 == -453603)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_k", typeof(GameObject));
										if (196264 - 410926 == -214661)
										{
											continue;
										}
									}
									else if (a == "p_sfb")
									{
										if (80262 - 128763 != -48501)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallFlowerBug", typeof(GameObject));
										if (185494 - 127543 == 57952)
										{
											continue;
										}
									}
									else if (a == "p_sob")
									{
										if (32202 - 477951 != -445749)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallLionBug", typeof(GameObject));
										if (48666 - 541830 != -493164)
										{
											continue;
										}
									}
									else if (a == "p_sgb")
									{
										if (2293 - 43255 == -40961)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallGiantBug", typeof(GameObject));
										if (69018 - 367819 != -298801)
										{
											continue;
										}
									}
									else if (a == "p_slb")
									{
										if (14641 - 66342 == -51700)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallLeafBug", typeof(GameObject));
										if (43442 - 519861 != -476419)
										{
											continue;
										}
									}
									else if (a == "p_stb")
									{
										if (127395 - 507967 != -380572)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallFatBug", typeof(GameObject));
										if (31486 - 510657 == -479170)
										{
											continue;
										}
									}
									else if (a == "p_spb")
									{
										if (254552 - 113261 != 141291)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallPaperBug", typeof(GameObject));
										if (95599 - 128557 != -32958)
										{
											continue;
										}
									}
									else if (a == "p_swb")
									{
										if (78644 - 328557 != -249913)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallWormBug", typeof(GameObject));
										if (42789 - 318082 == -275292)
										{
											continue;
										}
									}
									else if (a == "p_ssq")
									{
										if (24820 - 98554 == -73733)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallStingQueen", typeof(GameObject));
										if (88583 - 109230 == -20646)
										{
											continue;
										}
									}
									else if (a == "p_snb")
									{
										if (42183 - 492757 == -450573)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNeonBug", typeof(GameObject));
										if (158771 - 216382 == -57610)
										{
											continue;
										}
									}
									else if (a == "p_sim")
									{
										if (169722 - 580050 == -410327)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallIceMixer", typeof(GameObject));
										if (89786 - 284370 == -194583)
										{
											continue;
										}
									}
									else if (a == "p_sam")
									{
										if (168449 - 119953 == 48497)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallAmmonite", typeof(GameObject));
										if (279120 - 344889 != -65769)
										{
											continue;
										}
									}
									else if (a == "p_sab")
									{
										if (69963 - 377071 != -307108)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallAnubi", typeof(GameObject));
										if (39619 - 317663 == -278043)
										{
											continue;
										}
									}
									else if (a == "p_spg")
									{
										if (135194 - 98510 == 36685)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallIcePenguin", typeof(GameObject));
										if (299320 - 225934 != 73386)
										{
											continue;
										}
									}
									else if (a == "p_spf")
									{
										if (95128 - 568884 == -473755)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallPirateFish", typeof(GameObject));
										if (39207 - 59459 != -20252)
										{
											continue;
										}
									}
									else if (a == "p_msb")
									{
										if (106394 - 516671 == -410276)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniSkyBug", typeof(GameObject));
										if (189344 - 398536 == -209191)
										{
											continue;
										}
									}
									else if (a == "p_mcb")
									{
										if (274685 - 516607 != -241922)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniCrystalBug", typeof(GameObject));
										if (201272 - 260773 == -59500)
										{
											continue;
										}
									}
									else if (a == "p_mab")
									{
										if (107775 - 572911 != -465136)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniAncientBug", typeof(GameObject));
										if (38977 - 462184 != -423207)
										{
											continue;
										}
									}
									else if (a == "p_mrb")
									{
										if (195290 - 337862 != -142572)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniReefBug", typeof(GameObject));
										if (66652 - 416269 != -349617)
										{
											continue;
										}
									}
									else if (a == "p_mmb")
									{
										if (129664 - 198098 == -68433)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniMokBug", typeof(GameObject));
										if (269507 - 392976 == -123468)
										{
											continue;
										}
									}
									else if (a == "p_mgb")
									{
										if (21112 - 75680 != -54568)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniGoldenBug", typeof(GameObject));
										if (123245 - 214667 != -91422)
										{
											continue;
										}
									}
									else if (a == "p_mnb")
									{
										if (30190 - 102409 == -72218)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniNemesisBug", typeof(GameObject));
										if (37746 - 76787 != -39041)
										{
											continue;
										}
									}
									num = Stringf.getLastDigit(nPet);
									if (261274 - 190580 != 70694)
									{
										continue;
									}
									if (num < 0)
									{
										if (80765 - 134726 == -53960)
										{
											continue;
										}
										num = 1;
										if (9079 - 60904 != -51825)
										{
											continue;
										}
									}
								}
								if (gameObject)
								{
									if (176382 - 249490 != -73108)
									{
										continue;
									}
									this.Jikfqpd7ve = (GameObject)UnityEngine.Object.Instantiate(gameObject, this.transform.position - this.transform.forward, this.transform.rotation);
									if (40037 - 410952 != -370915)
									{
										continue;
									}
									if (this.Jikfqpd7ve)
									{
										if (120815 - 51589 == 69227)
										{
											continue;
										}
										this.Jikfqpd7ve.transform.localScale = ((float)num * 0.1f + 0.9f) * Vector3.one;
										if (82968 - 538477 == -455508)
										{
											continue;
										}
										PetControl petControl = (PetControl)this.Jikfqpd7ve.GetComponent(typeof(PetControl));
										if (34894 - 142210 != -107316)
										{
											continue;
										}
										if (petControl)
										{
											if (124538 - 152254 != -27716)
											{
												continue;
											}
											petControl.Init(this.gameObject, num);
											if (277887 - 400449 == -122561)
											{
												continue;
											}
										}
										if (this.WADfX7hIfZ)
										{
											if (293698 - 65657 == 228042)
											{
												continue;
											}
											this.WADfX7hIfZ.mPet = this.Jikfqpd7ve;
											if (210687 - 422643 == -211955)
											{
												continue;
											}
										}
									}
								}
								if (!this.WADfX7hIfZ)
								{
									break;
								}
								if (150822 - 285396 == -134574)
								{
									this.WADfX7hIfZ.pet = nPet;
									if (265786 - 597681 != -331894)
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

	// Token: 0x06002C61 RID: 11361 RVA: 0x005814DC File Offset: 0x0057F6DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002C62 RID: 11362 RVA: 0x005814E0 File Offset: 0x0057F6E0
	internal static bool gBbOXG5pi1MGm899UY3x()
	{
		return true;
	}

	// Token: 0x06002C63 RID: 11363 RVA: 0x005814E4 File Offset: 0x0057F6E4
	internal static bool teyeOW5pKvht1sD5wuJL()
	{
		return false;
	}

	// Token: 0x04003386 RID: 13190
	private CharacterControl WADfX7hIfZ;

	// Token: 0x04003387 RID: 13191
	public string weapon;

	// Token: 0x04003388 RID: 13192
	public string armor;

	// Token: 0x04003389 RID: 13193
	public string accessory;

	// Token: 0x0400338A RID: 13194
	public string boot;

	// Token: 0x0400338B RID: 13195
	public string trinket;

	// Token: 0x0400338C RID: 13196
	public string pet;

	// Token: 0x0400338D RID: 13197
	public int skin;

	// Token: 0x0400338E RID: 13198
	public bool equipOnStart;

	// Token: 0x0400338F RID: 13199
	private GameObject aw9fOyHp73;

	// Token: 0x04003390 RID: 13200
	private GameObject Usgf2POT94;

	// Token: 0x04003391 RID: 13201
	private GameObject zjNfvQotjH;

	// Token: 0x04003392 RID: 13202
	private GameObject N8UflheO9q;

	// Token: 0x04003393 RID: 13203
	private GameObject at0fGmUSsn;

	// Token: 0x04003394 RID: 13204
	private GameObject GWxf1T4Pct;

	// Token: 0x04003395 RID: 13205
	private GameObject Jikfqpd7ve;
}
