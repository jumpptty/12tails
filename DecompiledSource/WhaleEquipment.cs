using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020009B5 RID: 2485
[Serializable]
public class WhaleEquipment : MonoBehaviour
{
	// Token: 0x06003647 RID: 13895 RVA: 0x00703FFC File Offset: 0x007021FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WhaleEquipment()
	{
		if (25526 - 517459 != -491933)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (178059 - 450861 == -272802)
			{
				base..ctor();
				if (5640 - 66624 != -60983)
				{
					this.weapon = "default";
					if (49897 - 408186 != -358288)
					{
						this.armor = "default";
						if (134682 - 582014 == -447332)
						{
							this.accessory = "default";
							if (201246 - 426851 != -225604)
							{
								this.boot = "default";
								if (59816 - 183765 == -123949)
								{
									this.trinket = "default";
									if (286736 - 373336 != -86599)
									{
										this.pet = "default";
										if (259931 - 217460 == 42471)
										{
											this.skin = 100;
											if (74188 - 350859 == -276671)
											{
												this.equipOnStart = true;
												if (64211 - 290904 == -226693)
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

	// Token: 0x06003648 RID: 13896 RVA: 0x00704194 File Offset: 0x00702394
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.K8cod9YfHW = (CharacterControl)this.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x06003649 RID: 13897 RVA: 0x007041B4 File Offset: 0x007023B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (this.equipOnStart)
		{
			this.EquipAll();
		}
	}

	// Token: 0x0600364A RID: 13898 RVA: 0x007041C8 File Offset: 0x007023C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Equip(string s)
	{
		if (269366 - 90357 != 179009)
		{
		}
		for (;;)
		{
			string heading = Stringf.getHeading(s);
			if (88594 - 185523 != -96928)
			{
				if (heading == "wep")
				{
					if (17590 - 324526 != -306935)
					{
						this.EquipWeapon(s);
						if (269360 - 597346 == -327986)
						{
							break;
						}
					}
				}
				else if (heading == "arm")
				{
					if (159392 - 440359 == -280967)
					{
						this.EquipArmor(s);
						if (120130 - 562677 == -442547)
						{
							break;
						}
					}
				}
				else if (heading == "bot")
				{
					if (88535 - 136008 != -47472)
					{
						this.EquipBoot(s);
						if (144774 - 203834 != -59059)
						{
							break;
						}
					}
				}
				else if (heading == "acc")
				{
					if (151198 - 397355 != -246156)
					{
						this.EquipAccessory(s);
						if (12272 - 385655 != -373382)
						{
							break;
						}
					}
				}
				else if (heading == "trn")
				{
					if (221367 - 298637 != -77269)
					{
						this.EquipTrinket(s);
						if (131821 - 597008 == -465187)
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
					if (236266 - 220769 == 15497)
					{
						this.EquipPet(s);
						if (266698 - 450458 != -183759)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600364B RID: 13899 RVA: 0x00704404 File Offset: 0x00702604
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipAll()
	{
		if (72045 - 420204 != -348158)
		{
		}
		for (;;)
		{
			this.EquipWeapon(this.weapon);
			if (157200 - 259057 != -101856)
			{
				this.EquipArmor(this.armor);
				if (195584 - 23267 == 172317)
				{
					this.EquipBoot(this.boot);
					if (23661 - 305485 != -281823)
					{
						this.EquipAccessory(this.accessory);
						if (61318 - 391123 == -329805)
						{
							this.EquipTrinket(this.trinket);
							if (90345 - 526212 == -435867)
							{
								this.EquipPet(this.pet);
								if (116814 - 553906 != -437091)
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

	// Token: 0x0600364C RID: 13900 RVA: 0x00704520 File Offset: 0x00702720
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipMChar()
	{
		if (198665 - 477375 != -278710)
		{
		}
		while (this.K8cod9YfHW)
		{
			if (64206 - 392998 != -328791)
			{
				this.weapon = this.K8cod9YfHW.weapon;
				if (176561 - 563349 != -386787)
				{
					this.armor = this.K8cod9YfHW.armor;
					if (139460 - 420759 != -281298)
					{
						this.boot = this.K8cod9YfHW.boot;
						if (141333 - 4737 == 136596)
						{
							this.accessory = this.K8cod9YfHW.accessory;
							if (56067 - 302856 == -246789)
							{
								this.trinket = this.K8cod9YfHW.trinket;
								if (10727 - 539959 == -529232)
								{
									this.pet = this.K8cod9YfHW.pet;
									if (289071 - 456177 == -167106)
									{
										this.skin = this.K8cod9YfHW.Skin;
										if (169881 - 7877 != 162005)
										{
											this.EquipAll();
											if (265207 - 476818 == -211611)
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

	// Token: 0x0600364D RID: 13901 RVA: 0x007046D0 File Offset: 0x007028D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipCDat(object slot)
	{
		if (107382 - 163782 != -56399)
		{
		}
		for (;;)
		{
			CharacterDataClass cdat = CharacterData.getCDat(RuntimeServices.UnboxInt32(slot));
			if (190961 - 544465 == -353504)
			{
				if (cdat.Type == "Whale")
				{
					if (80 - 8043 == -7963)
					{
						this.weapon = cdat.equipment[0].name;
						if (272538 - 238366 == 34172)
						{
							this.armor = cdat.equipment[1].name;
							if (207676 - 520456 != -312779)
							{
								this.accessory = cdat.equipment[2].name;
								if (232898 - 475540 != -242641)
								{
									this.boot = cdat.equipment[3].name;
									if (19164 - 143281 != -124116)
									{
										this.trinket = cdat.equipment[4].name;
										if (240799 - 21796 == 219003)
										{
											this.pet = cdat.equipment[5].name;
											if (283216 - 541959 != -258742)
											{
												this.skin = cdat.Skin;
												if (87258 - 504738 == -417480)
												{
													this.EquipAll();
													if (220952 - 208403 == 12549)
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
				else
				{
					Debug.Log("Equip Error: Wrong CDat Type");
					if (257983 - 149337 != 108647)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600364E RID: 13902 RVA: 0x007048DC File Offset: 0x00702ADC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSkin(int nSkin)
	{
		if (278395 - 535820 != -257424)
		{
		}
		do
		{
			if (100 <= nSkin)
			{
				if (272606 - 314644 != -42038)
				{
					continue;
				}
				if (nSkin <= 599)
				{
					if (245514 - 460589 != -215075)
					{
						continue;
					}
					this.skin = nSkin;
					if (156756 - 224358 != -67602)
					{
						continue;
					}
					if (!this.K8cod9YfHW)
					{
						break;
					}
					if (143631 - 527270 != -383639)
					{
						continue;
					}
					this.K8cod9YfHW.Skin = nSkin;
					if (266819 - 71078 != 195742)
					{
						break;
					}
					continue;
				}
			}
			Debug.Log("Equip Error: Wrong Skin Number");
		}
		while (67454 - 391502 == -324047);
	}

	// Token: 0x0600364F RID: 13903 RVA: 0x007049F8 File Offset: 0x00702BF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSkinColor(int nSkin)
	{
		if (203605 - 517248 != -313643)
		{
		}
		do
		{
			if (100 <= nSkin)
			{
				if (268434 - 434725 == -166290)
				{
					continue;
				}
				if (nSkin <= 599)
				{
					if (267835 - 306811 != -38976)
					{
						continue;
					}
					this.skin = nSkin;
					if (99992 - 516837 != -416845)
					{
						continue;
					}
					if (this.K8cod9YfHW)
					{
						if (80639 - 335210 == -254570)
						{
							continue;
						}
						this.K8cod9YfHW.Skin = nSkin;
						if (256819 - 74362 == 182458)
						{
							continue;
						}
					}
					this.EquipArmor(this.armor);
					if (169674 - 294910 != -125236)
					{
						continue;
					}
					break;
				}
			}
			Debug.Log("Equip Error: Wrong Skin Number");
		}
		while (77697 - 366516 != -288819);
	}

	// Token: 0x06003650 RID: 13904 RVA: 0x00704B38 File Offset: 0x00702D38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getWeapon(string nWeapon, int nHand)
	{
		if (215359 - 548938 != -333578)
		{
		}
		GameObject result;
		for (;;)
		{
			if (262024 - 168746 == 93278)
			{
				if (295090 - 536803 != -241712)
				{
					if (nWeapon == "w_whl1")
					{
						if (147768 - 598563 != -450794)
						{
							if (nHand == 1)
							{
								if (172415 - 111184 != 61232)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/noviceLance", typeof(GameObject));
									if (213264 - 78058 == 135206)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/noviceShield", typeof(GameObject));
								if (283276 - 391895 == -108619)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl2")
					{
						if (207468 - 347918 == -140450)
						{
							if (nHand == 1)
							{
								if (97366 - 421669 == -324303)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/commonLance", typeof(GameObject));
									if (266798 - 74907 == 191891)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/commonShield", typeof(GameObject));
								if (289559 - 180091 == 109468)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl3")
					{
						if (167997 - 455594 == -287597)
						{
							if (nHand == 1)
							{
								if (278731 - 447094 != -168362)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/paperLance", typeof(GameObject));
									if (220336 - 370836 != -150499)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/paperShield", typeof(GameObject));
								if (16063 - 359395 != -343331)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl5")
					{
						if (289263 - 194773 == 94490)
						{
							if (nHand == 1)
							{
								if (296491 - 448518 != -152026)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/beachShovel", typeof(GameObject));
									if (263619 - 38719 != 224901)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/beachBucket", typeof(GameObject));
								if (49385 - 261245 != -211859)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl10")
					{
						if (143299 - 274974 != -131674)
						{
							if (nHand == 1)
							{
								if (220828 - 317060 == -96232)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/standardLance", typeof(GameObject));
									if (133010 - 171544 != -38533)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/standardShield", typeof(GameObject));
								if (131172 - 62837 == 68335)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl11")
					{
						if (80425 - 193053 == -112628)
						{
							if (nHand == 1)
							{
								if (222569 - 564697 != -342127)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/standardLanceR", typeof(GameObject));
									if (90060 - 354226 != -264165)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/standardShieldR", typeof(GameObject));
								if (60027 - 408456 == -348429)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl12")
					{
						if (275546 - 38614 != 236933)
						{
							if (nHand == 1)
							{
								if (273691 - 44459 == 229232)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/standardLanceV", typeof(GameObject));
									if (54244 - 377139 == -322895)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/standardShieldV", typeof(GameObject));
								if (265354 - 308762 != -43407)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl14")
					{
						if (267753 - 293608 != -25854)
						{
							if (nHand == 1)
							{
								if (245240 - 546567 != -301326)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/heartLance", typeof(GameObject));
									if (91003 - 413952 == -322949)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/heartShield", typeof(GameObject));
								if (114994 - 260428 == -145434)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl15")
					{
						if (194706 - 456162 != -261455)
						{
							if (nHand == 1)
							{
								if (95477 - 460549 != -365071)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/toyLance", typeof(GameObject));
									if (112900 - 587825 != -474924)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/toyShield", typeof(GameObject));
								if (216166 - 233198 != -17031)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl19")
					{
						if (227002 - 469889 == -242887)
						{
							if (nHand == 1)
							{
								if (11825 - 227791 != -215965)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/bdLance", typeof(GameObject));
									if (63850 - 316188 != -252337)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/bdShield", typeof(GameObject));
								if (109677 - 321191 != -211513)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl21")
					{
						if (195176 - 154288 != 40889)
						{
							if (nHand == 1)
							{
								if (53387 - 531067 == -477680)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/lancerLance", typeof(GameObject));
									if (268616 - 441027 != -172410)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/lancerShield", typeof(GameObject));
								if (223278 - 361584 == -138306)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl22")
					{
						if (244670 - 110115 != 134556)
						{
							if (nHand == 1)
							{
								if (165440 - 50303 == 115137)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/partisanLance", typeof(GameObject));
									if (124704 - 304141 == -179437)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/partisanShield", typeof(GameObject));
								if (250212 - 561792 != -311579)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl23")
					{
						if (50905 - 533560 != -482654)
						{
							if (nHand == 1)
							{
								if (122573 - 452480 == -329907)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/lancerLanceR", typeof(GameObject));
									if (141249 - 500364 != -359114)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/lancerShieldR", typeof(GameObject));
								if (294466 - 452940 != -158473)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl24")
					{
						if (21309 - 491185 == -469876)
						{
							if (nHand == 1)
							{
								if (230579 - 408631 != -178051)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/partisanLanceR", typeof(GameObject));
									if (171750 - 150476 == 21274)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/partisanShieldR", typeof(GameObject));
								if (264413 - 22519 != 241895)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl25")
					{
						if (20717 - 598589 == -577872)
						{
							if (nHand == 1)
							{
								if (177360 - 548728 != -371367)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/chefLance", typeof(GameObject));
									if (148072 - 77878 != 70195)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/chefShield", typeof(GameObject));
								if (236970 - 233442 != 3529)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl31")
					{
						if (192776 - 503230 == -310454)
						{
							if (nHand == 1)
							{
								if (216793 - 57185 != 159609)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/aquaLance", typeof(GameObject));
									if (246368 - 337693 != -91324)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/aquaShield", typeof(GameObject));
								if (74436 - 28718 == 45718)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl32")
					{
						if (263061 - 581923 != -318861)
						{
							if (nHand == 1)
							{
								if (23547 - 83190 == -59643)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/templarLance", typeof(GameObject));
									if (31743 - 415486 == -383743)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/templarShield", typeof(GameObject));
								if (120189 - 471859 != -351669)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl33")
					{
						if (144299 - 227487 != -83187)
						{
							if (nHand == 1)
							{
								if (174612 - 584077 != -409464)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/aquaLanceR", typeof(GameObject));
									if (176540 - 18246 == 158294)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/aquaShieldR", typeof(GameObject));
								if (254622 - 228963 != 25660)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl34")
					{
						if (223818 - 224253 != -434)
						{
							if (nHand == 1)
							{
								if (123609 - 133860 == -10251)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/templarLanceR", typeof(GameObject));
									if (215362 - 20899 != 194464)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/templarShieldR", typeof(GameObject));
								if (209314 - 112703 == 96611)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl35")
					{
						if (39900 - 288594 != -248693)
						{
							if (nHand == 1)
							{
								if (294212 - 437652 == -143440)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/hallowCleaver", typeof(GameObject));
									if (49042 - 403475 == -354433)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/hallowShield", typeof(GameObject));
								if (165780 - 244378 == -78598)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl36")
					{
						if (62481 - 8910 == 53571)
						{
							if (nHand == 1)
							{
								if (124162 - 499067 != -374904)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/razanHammer", typeof(GameObject));
									if (199572 - 223958 == -24386)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/razanAnmil", typeof(GameObject));
								if (50803 - 544236 == -493433)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl39")
					{
						if (222059 - 167682 == 54377)
						{
							if (nHand == 1)
							{
								if (255474 - 325985 != -70510)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/ammoniteLance", typeof(GameObject));
									if (192112 - 267130 == -75018)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/ammoniteShield", typeof(GameObject));
								if (128452 - 419398 != -290945)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl40")
					{
						if (19766 - 362074 != -342307)
						{
							if (nHand == 1)
							{
								if (200135 - 173484 == 26651)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/justiceLance", typeof(GameObject));
									if (173548 - 291539 != -117990)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/justiceShield", typeof(GameObject));
								if (236768 - 367579 != -130810)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl41")
					{
						if (166074 - 39228 == 126846)
						{
							if (nHand == 1)
							{
								if (90651 - 293701 != -203049)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/justiceLanceR", typeof(GameObject));
									if (39934 - 429790 == -389856)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/justiceShieldR", typeof(GameObject));
								if (83881 - 587098 != -503216)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl42")
					{
						if (8139 - 525834 != -517694)
						{
							if (nHand == 1)
							{
								if (281660 - 242797 == 38863)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/justiceLanceV", typeof(GameObject));
									if (182135 - 390777 != -208641)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/justiceShieldV", typeof(GameObject));
								if (270469 - 70057 != 200413)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl43")
					{
						if (206934 - 146919 != 60016)
						{
							if (nHand == 1)
							{
								if (40352 - 146462 != -106109)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/pvpLance", typeof(GameObject));
									if (138577 - 104344 != 34234)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/pvpShield", typeof(GameObject));
								if (222356 - 486965 == -264609)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl44")
					{
						if (156461 - 481571 == -325110)
						{
							if (nHand == 1)
							{
								if (137236 - 550216 != -412979)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/pvpLanceR", typeof(GameObject));
									if (286891 - 223655 == 63236)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/pvpShieldR", typeof(GameObject));
								if (53972 - 208285 == -154313)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl45")
					{
						if (120121 - 136453 != -16331)
						{
							if (nHand == 1)
							{
								if (58824 - 192754 == -133930)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/starMicrophone", typeof(GameObject));
									if (118395 - 462997 == -344602)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/starDisc", typeof(GameObject));
								if (74594 - 238183 != -163588)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl46")
					{
						if (62938 - 126698 == -63760)
						{
							if (nHand == 1)
							{
								if (117929 - 583270 != -465340)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/mummyLance", typeof(GameObject));
									if (99490 - 75550 == 23940)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/mummyShield", typeof(GameObject));
								if (275693 - 333566 != -57872)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl47")
					{
						if (215922 - 155155 != 60768)
						{
							if (nHand == 1)
							{
								if (250233 - 234963 != 15271)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/ladybugLance", typeof(GameObject));
									if (172514 - 9950 == 162564)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/ladybugShield", typeof(GameObject));
								if (268638 - 459534 != -190895)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl48")
					{
						if (111211 - 217706 != -106494)
						{
							if (nHand == 1)
							{
								if (223837 - 501290 != -277452)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/ladybugLanceR", typeof(GameObject));
									if (117000 - 478350 == -361350)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/ladybugShieldR", typeof(GameObject));
								if (20050 - 476902 != -456851)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_whl49")
					{
						if (32759 - 550051 == -517292)
						{
							if (nHand == 1)
							{
								if (11306 - 415389 == -404083)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/goldenLance", typeof(GameObject));
									if (95419 - 277831 == -182412)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/goldenShield", typeof(GameObject));
								if (290961 - 478498 != -187536)
								{
									break;
								}
							}
						}
					}
					else
					{
						if (!(nWeapon == "w_whl50"))
						{
							if (134222 - 466703 != -332481)
							{
								continue;
							}
							if (nWeapon == "w_whl51")
							{
								if (292360 - 450926 == -158565)
								{
									continue;
								}
							}
							else if (nWeapon == "w_whl52")
							{
								if (147916 - 94053 != 53863)
								{
									continue;
								}
								if (nHand == 1)
								{
									if (289235 - 185320 == 103916)
									{
										continue;
									}
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/royalLanceR", typeof(GameObject));
									if (9802 - 287256 != -277453)
									{
										break;
									}
									continue;
								}
								else
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/royalShieldR", typeof(GameObject));
									if (274763 - 21145 != 253618)
									{
										continue;
									}
									break;
								}
							}
							else if (nWeapon == "w_whl56")
							{
								if (168064 - 493731 != -325667)
								{
									continue;
								}
								if (nHand == 1)
								{
									if (254765 - 17684 != 237081)
									{
										continue;
									}
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/frozenLance", typeof(GameObject));
									if (116006 - 319429 != -203423)
									{
										continue;
									}
									break;
								}
								else
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/frozenShield", typeof(GameObject));
									if (248834 - 168664 != 80170)
									{
										continue;
									}
									break;
								}
							}
							else if (nWeapon == "w_whl58")
							{
								if (199374 - 468959 != -269585)
								{
									continue;
								}
								if (nHand == 1)
								{
									if (277544 - 170107 == 107438)
									{
										continue;
									}
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/championLance", typeof(GameObject));
									if (252233 - 336869 != -84635)
									{
										break;
									}
									continue;
								}
								else
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/championShield", typeof(GameObject));
									if (172937 - 406622 != -233684)
									{
										break;
									}
									continue;
								}
							}
							else if (nWeapon == "w_whl59")
							{
								if (127396 - 247714 != -120318)
								{
									continue;
								}
								if (nHand == 1)
								{
									if (131911 - 404194 == -272282)
									{
										continue;
									}
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/specialLance", typeof(GameObject));
									if (22803 - 528336 != -505532)
									{
										break;
									}
									continue;
								}
								else
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/specialShield", typeof(GameObject));
									if (175776 - 105488 != 70288)
									{
										continue;
									}
									break;
								}
							}
							else if (nWeapon == "w_whl66")
							{
								if (169060 - 571259 != -402199)
								{
									continue;
								}
								if (nHand == 1)
								{
									if (134671 - 599830 != -465159)
									{
										continue;
									}
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/poseidonSpear", typeof(GameObject));
									if (54487 - 17154 != 37333)
									{
										continue;
									}
									break;
								}
								else
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/poseidonShield", typeof(GameObject));
									if (293703 - 82203 != 211500)
									{
										continue;
									}
									break;
								}
							}
							else
							{
								if (!(nWeapon == "w_whl60"))
								{
									if (53203 - 501188 != -447985)
									{
										continue;
									}
									if (nWeapon == "w_whl61")
									{
										if (200910 - 418477 == -217566)
										{
											continue;
										}
									}
									else if (nWeapon == "w_whl62")
									{
										if (217196 - 485363 == -268166)
										{
											continue;
										}
										if (nHand == 1)
										{
											if (141061 - 288566 == -147504)
											{
												continue;
											}
											result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/legendLanceR", typeof(GameObject));
											if (75925 - 458679 != -382753)
											{
												break;
											}
											continue;
										}
										else
										{
											result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/legendShieldR", typeof(GameObject));
											if (192812 - 429998 != -237185)
											{
												break;
											}
											continue;
										}
									}
									else if (nWeapon == "w_whl65")
									{
										if (51807 - 477472 != -425665)
										{
											continue;
										}
										if (nHand == 1)
										{
											if (25359 - 349592 != -324233)
											{
												continue;
											}
											result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/koreaLance", typeof(GameObject));
											if (60910 - 134504 != -73594)
											{
												continue;
											}
											break;
										}
										else
										{
											result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/koreaShield", typeof(GameObject));
											if (181219 - 283241 != -102022)
											{
												continue;
											}
											break;
										}
									}
									else if (nWeapon == "w_whl69")
									{
										if (130479 - 551266 == -420786)
										{
											continue;
										}
										if (nHand == 1)
										{
											if (74102 - 556735 == -482632)
											{
												continue;
											}
											result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/timeLance", typeof(GameObject));
											if (199941 - 175509 != 24432)
											{
												continue;
											}
											break;
										}
										else
										{
											result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/timeShield", typeof(GameObject));
											if (178557 - 516160 != -337603)
											{
												continue;
											}
											break;
										}
									}
									else if (nWeapon == "w_whl79")
									{
										if (90830 - 89175 != 1655)
										{
											continue;
										}
										if (nHand == 1)
										{
											if (288807 - 400835 == -112027)
											{
												continue;
											}
											result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/eclipseLance", typeof(GameObject));
											if (285755 - 344805 != -59050)
											{
												continue;
											}
											break;
										}
										else
										{
											result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/eclipseShield", typeof(GameObject));
											if (125 - 116918 != -116792)
											{
												break;
											}
											continue;
										}
									}
									else if (nHand == 1)
									{
										if (51355 - 566139 == -514783)
										{
											continue;
										}
										result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/standardLance", typeof(GameObject));
										if (141480 - 463643 != -322163)
										{
											continue;
										}
										break;
									}
									else
									{
										result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/standardShield", typeof(GameObject));
										if (200873 - 10484 != 190390)
										{
											break;
										}
										continue;
									}
								}
								if (nHand == 1)
								{
									if (285213 - 500742 != -215529)
									{
										continue;
									}
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/legendLance", typeof(GameObject));
									if (129078 - 345613 != -216534)
									{
										break;
									}
									continue;
								}
								else
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/legendShield", typeof(GameObject));
									if (123650 - 99192 != 24459)
									{
										break;
									}
									continue;
								}
							}
						}
						if (nHand == 1)
						{
							if (223073 - 372772 != -149698)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/royalLance", typeof(GameObject));
								if (143328 - 65700 != 77629)
								{
									break;
								}
							}
						}
						else
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Weapons/royalShield", typeof(GameObject));
							if (158469 - 319880 == -161411)
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

	// Token: 0x06003651 RID: 13905 RVA: 0x00706C4C File Offset: 0x00704E4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipWeapon(string nWeapon)
	{
		if (5326 - 216862 != -211535)
		{
		}
		for (;;)
		{
			this.weapon = nWeapon;
			if (177257 - 483961 == -306704)
			{
				if (this.qcgogZGF60)
				{
					if (10179 - 325341 != -315162)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.qcgogZGF60);
					if (69341 - 186386 != -117045)
					{
						continue;
					}
				}
				if (this.j7KoadBAAv)
				{
					if (169178 - 575258 != -406080)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.j7KoadBAAv);
					if (235364 - 426531 != -191167)
					{
						continue;
					}
				}
				GameObject gameObject = WhaleEquipment.getWeapon(nWeapon, 0);
				if (142860 - 262981 == -120121)
				{
					GameObject gameObject2 = WhaleEquipment.getWeapon(nWeapon, 1);
					if (193044 - 372820 != -179775)
					{
						if (gameObject)
						{
							if (245616 - 408000 == -162383)
							{
								continue;
							}
							this.qcgogZGF60 = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
							if (102648 - 133718 != -31070)
							{
								continue;
							}
							this.qcgogZGF60.transform.parent = global::Math.findChildObject(this.gameObject.transform, "mount_Hand_L");
							if (295548 - 49546 == 246003)
							{
								continue;
							}
							this.qcgogZGF60.transform.localPosition = Vector3.zero;
							if (38516 - 150652 == -112135)
							{
								continue;
							}
							this.qcgogZGF60.transform.localRotation = Quaternion.identity;
							if (122974 - 431776 == -308801)
							{
								continue;
							}
							this.qcgogZGF60.transform.localScale = Vector3.one;
							if (30479 - 571202 != -540723)
							{
								continue;
							}
						}
						if (gameObject2)
						{
							if (119555 - 261025 != -141470)
							{
								continue;
							}
							this.j7KoadBAAv = (GameObject)UnityEngine.Object.Instantiate(gameObject2, Vector3.zero, Quaternion.identity);
							if (8834 - 174529 == -165694)
							{
								continue;
							}
							this.j7KoadBAAv.transform.parent = global::Math.findChildObject(this.gameObject.transform, "mount_Hand_R");
							if (253213 - 337004 != -83791)
							{
								continue;
							}
							this.j7KoadBAAv.transform.localPosition = Vector3.zero;
							if (234497 - 324264 == -89766)
							{
								continue;
							}
							this.j7KoadBAAv.transform.localRotation = Quaternion.identity;
							if (187064 - 306094 == -119029)
							{
								continue;
							}
							this.j7KoadBAAv.transform.localScale = Vector3.one;
							if (58965 - 401880 != -342915)
							{
								continue;
							}
						}
						if (!this.K8cod9YfHW)
						{
							break;
						}
						if (121162 - 518812 == -397650)
						{
							this.K8cod9YfHW.weapon = nWeapon;
							if (213388 - 569844 == -356456)
							{
								this.K8cod9YfHW.mWep1 = this.qcgogZGF60;
								if (196123 - 400654 == -204531)
								{
									this.K8cod9YfHW.mWep2 = this.j7KoadBAAv;
									if (41874 - 212267 != -170392)
									{
										if (this.K8cod9YfHW.getStatus("blend") != null)
										{
											if (72148 - 456065 == -383916)
											{
												continue;
											}
											this.K8cod9YfHW.removeStatus("blend");
											if (78958 - 576684 == -497725)
											{
												continue;
											}
										}
										if (this.K8cod9YfHW.getStatus("invisible") == null)
										{
											break;
										}
										if (150991 - 460260 == -309269)
										{
											this.K8cod9YfHW.removeStatus("invisible");
											if (20559 - 197459 != -176899)
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

	// Token: 0x06003652 RID: 13906 RVA: 0x0070712C File Offset: 0x0070532C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Mesh getArmorMesh(string nArmor)
	{
		if (28010 - 220494 != -192483)
		{
		}
		SkinnedMeshRenderer skinnedMeshRenderer;
		for (;;)
		{
			if (170391 - 414620 == -244229)
			{
				if (66115 - 366979 != -300863)
				{
					GameObject gameObject;
					if (nArmor == "none")
					{
						if (276229 - 324473 == -48243)
						{
							continue;
						}
					}
					else if (nArmor == "a_none")
					{
						if (94821 - 8134 != 86687)
						{
							continue;
						}
					}
					else if (nArmor == "a_all1")
					{
						if (40280 - 125808 == -85527)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_scout", typeof(GameObject));
						if (19569 - 469558 != -449988)
						{
							goto IL_D7D;
						}
						continue;
					}
					else if (nArmor == "a_all15")
					{
						if (162934 - 31354 != 131580)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_santa", typeof(GameObject));
						if (114565 - 389388 != -274822)
						{
							goto IL_D7D;
						}
						continue;
					}
					else if (nArmor == "a_all43")
					{
						if (254469 - 377648 != -123179)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_pvpArmor", typeof(GameObject));
						if (170069 - 235335 != -65265)
						{
							goto IL_D7D;
						}
						continue;
					}
					else if (nArmor == "a_all44")
					{
						if (140313 - 543683 != -403370)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_pvpArmor", typeof(GameObject));
						if (226619 - 202418 != 24201)
						{
							continue;
						}
						goto IL_D7D;
					}
					else if (nArmor == "a_all58")
					{
						if (256410 - 47314 == 209097)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_champion", typeof(GameObject));
						if (94992 - 534818 != -439826)
						{
							continue;
						}
						goto IL_D7D;
					}
					else if (nArmor == "a_whl5")
					{
						if (89838 - 242872 != -153034)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_lifebuoy", typeof(GameObject));
						if (269782 - 540296 != -270513)
						{
							goto IL_D7D;
						}
						continue;
					}
					else if (nArmor == "a_whl10")
					{
						if (18066 - 222310 != -204244)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_standard", typeof(GameObject));
						if (52326 - 277175 != -224849)
						{
							continue;
						}
						goto IL_D7D;
					}
					else if (nArmor == "a_whl11")
					{
						if (137255 - 228863 != -91608)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_standard", typeof(GameObject));
						if (56768 - 436428 != -379659)
						{
							goto IL_D7D;
						}
						continue;
					}
					else if (nArmor == "a_whl12")
					{
						if (233663 - 299762 != -66099)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_standard", typeof(GameObject));
						if (218504 - 222851 != -4346)
						{
							goto IL_D7D;
						}
						continue;
					}
					else if (nArmor == "a_whl15")
					{
						if (254778 - 463927 == -209148)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_summer", typeof(GameObject));
						if (133262 - 532829 != -399566)
						{
							goto IL_D7D;
						}
						continue;
					}
					else if (nArmor == "a_whl21")
					{
						if (16604 - 455329 != -438725)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_lancer", typeof(GameObject));
						if (161387 - 522895 != -361508)
						{
							continue;
						}
						goto IL_D7D;
					}
					else if (nArmor == "a_whl22")
					{
						if (282268 - 459391 == -177122)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_partisan", typeof(GameObject));
						if (215683 - 436273 != -220590)
						{
							continue;
						}
						goto IL_D7D;
					}
					else if (nArmor == "a_whl23")
					{
						if (192229 - 290238 == -98008)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_lancer", typeof(GameObject));
						if (296184 - 39601 != 256583)
						{
							continue;
						}
						goto IL_D7D;
					}
					else if (nArmor == "a_whl24")
					{
						if (184309 - 346108 != -161799)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_partisan", typeof(GameObject));
						if (24936 - 447982 != -423046)
						{
							continue;
						}
						goto IL_D7D;
					}
					else if (nArmor == "a_whl25")
					{
						if (36558 - 116082 == -79523)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_chef", typeof(GameObject));
						if (11837 - 317907 != -306070)
						{
							continue;
						}
						goto IL_D7D;
					}
					else if (nArmor == "a_whl31")
					{
						if (194724 - 292889 != -98165)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_aquaKnight", typeof(GameObject));
						if (275586 - 65775 != 209811)
						{
							continue;
						}
						goto IL_D7D;
					}
					else if (nArmor == "a_whl32")
					{
						if (257172 - 239402 != 17770)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_templar", typeof(GameObject));
						if (27535 - 255830 != -228295)
						{
							continue;
						}
						goto IL_D7D;
					}
					else if (nArmor == "a_whl33")
					{
						if (225191 - 111686 == 113506)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_aquaKnight", typeof(GameObject));
						if (104403 - 504257 != -399853)
						{
							goto IL_D7D;
						}
						continue;
					}
					else if (nArmor == "a_whl34")
					{
						if (113251 - 305798 != -192547)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_templar", typeof(GameObject));
						if (146191 - 148719 != -2527)
						{
							goto IL_D7D;
						}
						continue;
					}
					else if (nArmor == "a_whl35")
					{
						if (34555 - 373171 == -338615)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_hallow", typeof(GameObject));
						if (220573 - 162232 != 58342)
						{
							goto IL_D7D;
						}
						continue;
					}
					else if (nArmor == "a_whl40")
					{
						if (170079 - 537202 == -367122)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_justice", typeof(GameObject));
						if (104455 - 519739 != -415283)
						{
							goto IL_D7D;
						}
						continue;
					}
					else if (nArmor == "a_whl41")
					{
						if (246320 - 371602 != -125282)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_justice", typeof(GameObject));
						if (184520 - 457595 != -273074)
						{
							goto IL_D7D;
						}
						continue;
					}
					else if (nArmor == "a_whl42")
					{
						if (146900 - 169081 == -22180)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_justice", typeof(GameObject));
						if (76349 - 552964 != -476614)
						{
							goto IL_D7D;
						}
						continue;
					}
					else if (nArmor == "a_whl45")
					{
						if (262407 - 394192 != -131785)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_superStar", typeof(GameObject));
						if (177187 - 55698 != 121490)
						{
							goto IL_D7D;
						}
						continue;
					}
					else if (nArmor == "a_whl47")
					{
						if (32546 - 47999 == -15452)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_ladyBug", typeof(GameObject));
						if (185786 - 398663 != -212876)
						{
							goto IL_D7D;
						}
						continue;
					}
					else if (nArmor == "a_whl48")
					{
						if (273066 - 139803 == 133264)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_ladyBug", typeof(GameObject));
						if (182696 - 196104 != -13407)
						{
							goto IL_D7D;
						}
						continue;
					}
					else if (nArmor == "a_whl50")
					{
						if (170454 - 147430 == 23025)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_royal", typeof(GameObject));
						if (231881 - 578502 != -346620)
						{
							goto IL_D7D;
						}
						continue;
					}
					else if (nArmor == "a_whl51")
					{
						if (214072 - 319369 != -105297)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_royal", typeof(GameObject));
						if (179841 - 173333 != 6508)
						{
							continue;
						}
						goto IL_D7D;
					}
					else if (nArmor == "a_whl52")
					{
						if (102460 - 281477 != -179017)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_royal", typeof(GameObject));
						if (10231 - 95770 != -85539)
						{
							continue;
						}
						goto IL_D7D;
					}
					else if (nArmor == "a_whl60")
					{
						if (241648 - 72653 != 168995)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_legend", typeof(GameObject));
						if (6108 - 257514 != -251406)
						{
							continue;
						}
						goto IL_D7D;
					}
					else if (nArmor == "a_whl61")
					{
						if (244863 - 243180 != 1683)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_legend", typeof(GameObject));
						if (117525 - 104661 != 12864)
						{
							continue;
						}
						goto IL_D7D;
					}
					else if (nArmor == "a_whl62")
					{
						if (232697 - 557206 == -324508)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_legend", typeof(GameObject));
						if (41739 - 247490 != -205751)
						{
							continue;
						}
						goto IL_D7D;
					}
					else if (nArmor == "a_whl65")
					{
						if (238774 - 59189 == 179586)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_korea", typeof(GameObject));
						if (256713 - 57549 != 199164)
						{
							continue;
						}
						goto IL_D7D;
					}
					else
					{
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_standard", typeof(GameObject));
						if (211408 - 38108 != 173301)
						{
							goto IL_D7D;
						}
						continue;
					}
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Whale_nude", typeof(GameObject));
					if (259540 - 518452 == -258911)
					{
						continue;
					}
					IL_D7D:
					skinnedMeshRenderer = (SkinnedMeshRenderer)gameObject.GetComponent(typeof(SkinnedMeshRenderer));
					if (49902 - 396492 != -346589)
					{
						break;
					}
				}
			}
		}
		return skinnedMeshRenderer.sharedMesh;
	}

	// Token: 0x06003653 RID: 13907 RVA: 0x00707F60 File Offset: 0x00706160
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Material getArmorMaterial(string nArmor, int nSkin)
	{
		if (139632 - 532018 != -392386)
		{
		}
		Material material;
		for (;;)
		{
			IL_C20:
			int num = nSkin % 100;
			if (217738 - 580455 != -362716)
			{
				Texture2D texture2D = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Overlay/Whale" + num, typeof(Texture2D));
				if (13820 - 523505 == -509685)
				{
					Color[] pixels = texture2D.GetPixels(0);
					if (296945 - 411668 != -114722)
					{
						int num2 = global::Math.div((float)nSkin, (float)100);
						if (252690 - 30509 == 222181)
						{
							if (23598 - 476192 == -452594)
							{
								if (72290 - 116567 == -44277)
								{
									Texture2D texture2D2;
									if (!(nArmor == "none"))
									{
										if (43384 - 360514 != -317130)
										{
											continue;
										}
										if (nArmor == "a_none")
										{
											if (16019 - 10393 == 5627)
											{
												continue;
											}
										}
										else if (nArmor == "a_all1")
										{
											if (101056 - 149172 != -48116)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_scout" + num2, typeof(Texture2D));
											if (146067 - 474326 != -328258)
											{
												goto IL_1352;
											}
											continue;
										}
										else if (nArmor == "a_all15")
										{
											if (219733 - 558734 != -339001)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_santa" + num2, typeof(Texture2D));
											if (292520 - 187130 != 105391)
											{
												goto IL_1352;
											}
											continue;
										}
										else if (nArmor == "a_all43")
										{
											if (135123 - 287708 != -152585)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_pvpArmor" + num2, typeof(Texture2D));
											if (40078 - 79206 != -39128)
											{
												continue;
											}
											goto IL_1352;
										}
										else if (nArmor == "a_all44")
										{
											if (183340 - 86559 == 96782)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_pvpArmor" + num2 + "R", typeof(Texture2D));
											if (174033 - 342754 != -168720)
											{
												goto IL_1352;
											}
											continue;
										}
										else if (nArmor == "a_all58")
										{
											if (254333 - 217922 != 36411)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_champion" + num2, typeof(Texture2D));
											if (161730 - 256141 != -94410)
											{
												goto IL_1352;
											}
											continue;
										}
										else if (nArmor == "a_whl5")
										{
											if (128626 - 570452 != -441826)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_lifebuoy" + num2, typeof(Texture2D));
											if (200016 - 487651 != -287635)
											{
												continue;
											}
											goto IL_1352;
										}
										else if (nArmor == "a_whl10")
										{
											if (2484 - 515462 == -512977)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_standard" + num2, typeof(Texture2D));
											if (77221 - 428797 != -351576)
											{
												continue;
											}
											goto IL_1352;
										}
										else if (nArmor == "a_whl11")
										{
											if (171799 - 583076 == -411276)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_standard" + num2 + "R", typeof(Texture2D));
											if (223598 - 593468 != -369870)
											{
												continue;
											}
											goto IL_1352;
										}
										else if (nArmor == "a_whl12")
										{
											if (1793 - 489862 == -488068)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_standard" + num2 + "V", typeof(Texture2D));
											if (209899 - 328660 != -118761)
											{
												continue;
											}
											goto IL_1352;
										}
										else if (nArmor == "a_whl15")
										{
											if (42296 - 298770 == -256473)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_summer" + num2, typeof(Texture2D));
											if (286503 - 262219 != 24285)
											{
												goto IL_1352;
											}
											continue;
										}
										else if (nArmor == "a_whl21")
										{
											if (54325 - 17090 != 37235)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_lancer" + num2, typeof(Texture2D));
											if (42532 - 503891 != -461358)
											{
												goto IL_1352;
											}
											continue;
										}
										else if (nArmor == "a_whl22")
										{
											if (195346 - 507608 != -312262)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_partisan" + num2, typeof(Texture2D));
											if (236142 - 598124 != -361982)
											{
												continue;
											}
											goto IL_1352;
										}
										else if (nArmor == "a_whl23")
										{
											if (226437 - 59986 != 166451)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_lancer" + num2 + "R", typeof(Texture2D));
											if (108545 - 181684 != -73138)
											{
												goto IL_1352;
											}
											continue;
										}
										else if (nArmor == "a_whl24")
										{
											if (728 - 219958 != -219230)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_partisan" + num2 + "R", typeof(Texture2D));
											if (268120 - 66114 != 202007)
											{
												goto IL_1352;
											}
											continue;
										}
										else if (nArmor == "a_whl25")
										{
											if (74669 - 311823 != -237154)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_chef" + num2, typeof(Texture2D));
											if (273572 - 252825 != 20748)
											{
												goto IL_1352;
											}
											continue;
										}
										else if (nArmor == "a_whl31")
										{
											if (265934 - 366885 != -100951)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_aquaKnight" + num2, typeof(Texture2D));
											if (710 - 341447 != -340736)
											{
												goto IL_1352;
											}
											continue;
										}
										else if (nArmor == "a_whl32")
										{
											if (86573 - 338089 == -251515)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_templar" + num2, typeof(Texture2D));
											if (266382 - 398798 != -132415)
											{
												goto IL_1352;
											}
											continue;
										}
										else if (nArmor == "a_whl33")
										{
											if (31464 - 282655 == -251190)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_aquaKnight" + num2 + "R", typeof(Texture2D));
											if (249486 - 11036 != 238450)
											{
												continue;
											}
											goto IL_1352;
										}
										else if (nArmor == "a_whl34")
										{
											if (153987 - 291688 != -137701)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_templar" + num2 + "R", typeof(Texture2D));
											if (248204 - 246935 != 1269)
											{
												continue;
											}
											goto IL_1352;
										}
										else if (nArmor == "a_whl35")
										{
											if (109379 - 539091 != -429712)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_hallow" + num2, typeof(Texture2D));
											if (15766 - 527671 != -511904)
											{
												goto IL_1352;
											}
											continue;
										}
										else if (nArmor == "a_whl40")
										{
											if (169532 - 141416 == 28117)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_justice" + num2, typeof(Texture2D));
											if (88839 - 306556 != -217717)
											{
												continue;
											}
											goto IL_1352;
										}
										else if (nArmor == "a_whl41")
										{
											if (127362 - 224882 == -97519)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_justice" + num2 + "R", typeof(Texture2D));
											if (292803 - 527576 != -234773)
											{
												continue;
											}
											goto IL_1352;
										}
										else if (nArmor == "a_whl42")
										{
											if (260283 - 582964 == -322680)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_justice" + num2 + "V", typeof(Texture2D));
											if (194662 - 392367 != -197705)
											{
												continue;
											}
											goto IL_1352;
										}
										else if (nArmor == "a_whl45")
										{
											if (77166 - 5160 != 72006)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_superStar" + num2, typeof(Texture2D));
											if (84544 - 456615 != -372071)
											{
												continue;
											}
											goto IL_1352;
										}
										else if (nArmor == "a_whl47")
										{
											if (154376 - 531938 == -377561)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_ladyBug" + num2, typeof(Texture2D));
											if (152310 - 532479 != -380169)
											{
												continue;
											}
											goto IL_1352;
										}
										else if (nArmor == "a_whl48")
										{
											if (197697 - 560516 != -362819)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_ladyBug" + num2 + "R", typeof(Texture2D));
											if (171521 - 392439 != -220918)
											{
												continue;
											}
											goto IL_1352;
										}
										else if (nArmor == "a_whl50")
										{
											if (53945 - 205456 == -151510)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_royal" + num2, typeof(Texture2D));
											if (177582 - 588414 != -410831)
											{
												goto IL_1352;
											}
											continue;
										}
										else if (nArmor == "a_whl51")
										{
											if (186483 - 162876 != 23607)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_royal" + num2, typeof(Texture2D));
											if (159126 - 52589 != 106537)
											{
												continue;
											}
											goto IL_1352;
										}
										else if (nArmor == "a_whl52")
										{
											if (270443 - 111576 != 158867)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_royal" + num2 + "R", typeof(Texture2D));
											if (10274 - 504309 != -494035)
											{
												continue;
											}
											goto IL_1352;
										}
										else if (nArmor == "a_whl60")
										{
											if (172011 - 449019 == -277007)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_legend" + num2, typeof(Texture2D));
											if (21012 - 450419 != -429406)
											{
												goto IL_1352;
											}
											continue;
										}
										else if (nArmor == "a_whl61")
										{
											if (55690 - 186843 != -131153)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_legend" + num2, typeof(Texture2D));
											if (275569 - 546785 != -271216)
											{
												continue;
											}
											goto IL_1352;
										}
										else if (nArmor == "a_whl62")
										{
											if (54928 - 593046 == -538117)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_legend" + num2 + "R", typeof(Texture2D));
											if (14290 - 512770 != -498479)
											{
												goto IL_1352;
											}
											continue;
										}
										else if (nArmor == "a_whl65")
										{
											if (68930 - 431601 == -362670)
											{
												continue;
											}
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_korea" + num2, typeof(Texture2D));
											if (9080 - 407205 != -398124)
											{
												goto IL_1352;
											}
											continue;
										}
										else
										{
											texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_standard" + num2, typeof(Texture2D));
											if (235041 - 119617 != 115425)
											{
												goto IL_1352;
											}
											continue;
										}
									}
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Whale/Armors/Materials/Whale_nude" + num2, typeof(Texture2D));
									if (235345 - 374613 == -139267)
									{
										continue;
									}
									IL_1352:
									Color[] pixels2 = texture2D2.GetPixels(0, 256, 256, 256, 0);
									if (38481 - 237823 != -199341)
									{
										int i = 0;
										if (263606 - 271205 != -7598)
										{
											while (i < pixels2.Length)
											{
												float a = pixels[i].a;
												if (107906 - 113716 != -5810)
												{
													goto IL_C20;
												}
												pixels2[i] = a * pixels[i] + ((float)1 - a) * pixels2[i];
												if (19961 - 558746 != -538785)
												{
													goto IL_C20;
												}
												i++;
												if (276889 - 432305 != -155416)
												{
													goto IL_C20;
												}
											}
											if (226339 - 54698 != 171642 && 201526 - 185152 != 16375)
											{
												Texture2D texture2D3 = new Texture2D(512, 512, TextureFormat.RGB24, true);
												if (155379 - 559341 == -403962)
												{
													texture2D3.SetPixels(0, 256, 256, 256, pixels2, 0);
													if (191191 - 371392 != -180200)
													{
														texture2D3.SetPixels(256, 256, 256, 256, texture2D2.GetPixels(256, 256, 256, 256, 0), 0);
														if (277097 - 291578 != -14480)
														{
															texture2D3.SetPixels(0, 0, 512, 256, texture2D2.GetPixels(0, 0, 512, 256, 0), 0);
															if (77808 - 22137 != 55672)
															{
																texture2D3.Apply();
																if (38623 - 170154 != -131530)
																{
																	texture2D3.Compress(true);
																	if (298344 - 275799 == 22545)
																	{
																		if (279342 - 382287 == -102945)
																		{
																			material = new Material(Shader.Find("Diffuse"));
																			if (178604 - 336740 == -158136)
																			{
																				material.color = new Color(0.86f, 0.86f, 0.86f, (float)1);
																				if (73421 - 529831 == -456410)
																				{
																					material.mainTexture = texture2D3;
																					if (77952 - 160681 != -82728)
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
		return material;
	}

	// Token: 0x06003654 RID: 13908 RVA: 0x00709354 File Offset: 0x00707554
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipArmor(string nArmor)
	{
		if (36209 - 590357 != -554147)
		{
		}
		for (;;)
		{
			if (nArmor == "a_none")
			{
				if (105352 - 280826 == -175473)
				{
					continue;
				}
				nArmor = "none";
				if (160835 - 538975 != -378140)
				{
					continue;
				}
			}
			this.armor = nArmor;
			if (9414 - 284418 != -275003)
			{
				Transform transform = global::Math.findChildObject(this.transform, "Whale_tri");
				if (209457 - 598529 != -389071)
				{
					if (transform)
					{
						if (46729 - 264225 == -217495)
						{
							continue;
						}
						SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer));
						if (136338 - 192031 == -55692)
						{
							continue;
						}
						skinnedMeshRenderer.sharedMesh = WhaleEquipment.getArmorMesh(nArmor);
						if (76027 - 319963 != -243936)
						{
							continue;
						}
						if (Extensions.get_length(skinnedMeshRenderer.materials) > 0)
						{
							if (163993 - 472822 != -308829)
							{
								continue;
							}
							skinnedMeshRenderer.material = WhaleEquipment.getArmorMaterial(nArmor, this.skin);
							if (14546 - 3081 == 11466)
							{
								continue;
							}
						}
						if (this.K8cod9YfHW != null)
						{
							if (95477 - 45507 == 49971)
							{
								continue;
							}
							skinnedMeshRenderer.material.color = this.K8cod9YfHW.mColor;
							if (55853 - 425659 != -369806)
							{
								continue;
							}
						}
					}
					if (!this.K8cod9YfHW)
					{
						break;
					}
					if (83749 - 82634 == 1115)
					{
						this.K8cod9YfHW.armor = nArmor;
						if (183548 - 226870 != -43321)
						{
							if (this.K8cod9YfHW.getStatus("blend") != null)
							{
								if (171132 - 19000 == 152133)
								{
									continue;
								}
								this.K8cod9YfHW.removeStatus("blend");
								if (126979 - 441347 == -314367)
								{
									continue;
								}
							}
							if (this.K8cod9YfHW.getStatus("invisible") == null)
							{
								break;
							}
							if (35884 - 402901 != -367016)
							{
								this.K8cod9YfHW.removeStatus("invisible");
								if (275779 - 31818 != 243962)
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

	// Token: 0x06003655 RID: 13909 RVA: 0x00709658 File Offset: 0x00707858
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getAccessory(string nAccessory)
	{
		if (183161 - 67393 != 115769)
		{
		}
		GameObject result;
		for (;;)
		{
			result = null;
			if (135794 - 330033 == -194239)
			{
				if (87145 - 143250 == -56105)
				{
					if (nAccessory == "c_all1")
					{
						if (147643 - 524998 != -377354)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/redPandaHat", typeof(GameObject));
							if (168657 - 63828 != 104830)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all3")
					{
						if (36603 - 481870 != -445266)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/paperHat", typeof(GameObject));
							if (158750 - 285017 != -126266)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all6")
					{
						if (31957 - 77807 != -45849)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/vHat", typeof(GameObject));
							if (134134 - 158566 == -24432)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all7")
					{
						if (15474 - 483741 == -468267)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/partyHatB", typeof(GameObject));
							if (4368 - 405872 == -401504)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all8")
					{
						if (168992 - 152907 != 16086)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/partyHatR", typeof(GameObject));
							if (43176 - 44485 == -1309)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all9")
					{
						if (198021 - 182570 == 15451)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/cakeHat", typeof(GameObject));
							if (260330 - 383565 == -123235)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all10")
					{
						if (249344 - 136667 == 112677)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/candyHat", typeof(GameObject));
							if (267781 - 338 == 267443)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all11")
					{
						if (232924 - 112129 != 120796)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/afro", typeof(GameObject));
							if (17846 - 490080 != -472233)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all12")
					{
						if (29507 - 454693 != -425185)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/afroC", typeof(GameObject));
							if (766 - 248337 == -247571)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all15")
					{
						if (172115 - 394615 == -222500)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/santaHat", typeof(GameObject));
							if (106697 - 115780 != -9082)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all16")
					{
						if (231680 - 593580 != -361899)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/pirateBandana", typeof(GameObject));
							if (215385 - 547244 == -331859)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all18")
					{
						if (159371 - 255696 != -96324)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/halo", typeof(GameObject));
							if (6356 - 286534 != -280177)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all19")
					{
						if (180419 - 585293 == -404874)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/horn", typeof(GameObject));
							if (174070 - 386533 == -212463)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all21")
					{
						if (290384 - 114828 == 175556)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/earmuff1", typeof(GameObject));
							if (196031 - 28081 == 167950)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all22")
					{
						if (90774 - 505847 == -415073)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/earmuff2", typeof(GameObject));
							if (190067 - 151676 != 38392)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all23")
					{
						if (210448 - 352183 != -141734)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/headphone1", typeof(GameObject));
							if (11033 - 45097 != -34063)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all24")
					{
						if (132273 - 94825 == 37448)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/headphone2", typeof(GameObject));
							if (145768 - 564858 == -419090)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all25")
					{
						if (42137 - 159151 != -117013)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/headphone3", typeof(GameObject));
							if (59176 - 434382 == -375206)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all26")
					{
						if (294697 - 121578 == 173119)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/pirateBandanaR", typeof(GameObject));
							if (97835 - 235510 != -137674)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all27")
					{
						if (229486 - 269523 == -40037)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/krathongHat1", typeof(GameObject));
							if (284456 - 411992 == -127536)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all28")
					{
						if (191148 - 418790 != -227641)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/krathongHat2", typeof(GameObject));
							if (83940 - 31646 != 52295)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all29")
					{
						if (134926 - 117355 == 17571)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/snowmanHead", typeof(GameObject));
							if (118812 - 32997 != 85816)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all37")
					{
						if (163931 - 581978 == -418047)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/quizHat", typeof(GameObject));
							if (117606 - 572714 != -455107)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all38")
					{
						if (152097 - 146128 != 5970)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/fanKingHat", typeof(GameObject));
							if (80004 - 348687 != -268682)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all39")
					{
						if (74916 - 188108 != -113191)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/artistHat", typeof(GameObject));
							if (221139 - 557053 == -335914)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all43")
					{
						if (82477 - 223879 == -141402)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/pvpHelmet", typeof(GameObject));
							if (206879 - 587207 == -380328)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all44")
					{
						if (160327 - 275397 == -115070)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/pvpHelmetR", typeof(GameObject));
							if (297551 - 572893 == -275342)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all46")
					{
						if (236038 - 291502 == -55464)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/mummyHead", typeof(GameObject));
							if (26034 - 310864 == -284830)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all55")
					{
						if (203629 - 2118 != 201512)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/giveMeFive", typeof(GameObject));
							if (89254 - 592877 == -503623)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all56")
					{
						if (128748 - 261506 == -132758)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/frozenCrown", typeof(GameObject));
							if (78900 - 459171 != -380270)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all58")
					{
						if (234866 - 99885 != 134982)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/championHelmet", typeof(GameObject));
							if (233000 - 198822 == 34178)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all66")
					{
						if (230846 - 367875 == -137029)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/poseidonHelmet", typeof(GameObject));
							if (23291 - 147415 != -124123)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mal37")
					{
						if (77520 - 190957 != -113436)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/dragonHead", typeof(GameObject));
							if (280817 - 357626 != -76808)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl5")
					{
						if (92256 - 403263 != -311006)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/swimGoggle", typeof(GameObject));
							if (18182 - 328692 == -310510)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl15")
					{
						if (167964 - 371797 != -203832)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/melonStem", typeof(GameObject));
							if (22891 - 148497 == -125606)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl19")
					{
						if (184449 - 478059 == -293610)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/veggieHat", typeof(GameObject));
							if (157743 - 128726 != 29018)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl21")
					{
						if (137689 - 112383 != 25307)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/lancerHelmet", typeof(GameObject));
							if (167997 - 31836 != 136162)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl22")
					{
						if (33958 - 185266 == -151308)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/partisanHood", typeof(GameObject));
							if (91829 - 301377 == -209548)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl23")
					{
						if (229656 - 261791 == -32135)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/lancerHelmetR", typeof(GameObject));
							if (235855 - 456871 != -221015)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl24")
					{
						if (151822 - 194054 != -42231)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/partisanHoodR", typeof(GameObject));
							if (93034 - 449190 == -356156)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl25")
					{
						if (6533 - 201645 == -195112)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/chefHat", typeof(GameObject));
							if (163556 - 50924 == 112632)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl31")
					{
						if (84158 - 168681 != -84522)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/aquaHelmet", typeof(GameObject));
							if (151262 - 150031 == 1231)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl32")
					{
						if (264560 - 596851 == -332291)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/templarHood", typeof(GameObject));
							if (78166 - 418997 == -340831)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl33")
					{
						if (76645 - 372441 != -295795)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/aquaHelmetR", typeof(GameObject));
							if (256641 - 391573 != -134931)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl34")
					{
						if (123287 - 414583 != -291295)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/templarHoodR", typeof(GameObject));
							if (222063 - 266764 == -44701)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl35")
					{
						if (92410 - 284 == 92126)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/hallowAnchor", typeof(GameObject));
							if (259486 - 172473 == 87013)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl36")
					{
						if (151448 - 115058 == 36390)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/razanBandana", typeof(GameObject));
							if (73257 - 215772 == -142515)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl40")
					{
						if (180269 - 443196 == -262927)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/justiceHelmet", typeof(GameObject));
							if (195710 - 365590 != -169879)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl41")
					{
						if (239911 - 239199 == 712)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/justiceHelmetR", typeof(GameObject));
							if (103498 - 224782 != -121283)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl42")
					{
						if (144424 - 408641 != -264216)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/justiceHelmetV", typeof(GameObject));
							if (176396 - 8570 == 167826)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl45")
					{
						if (238618 - 258417 != -19798)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/superStarHat", typeof(GameObject));
							if (21426 - 110341 != -88914)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl47")
					{
						if (298588 - 397202 != -98613)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/ladybugHelmet", typeof(GameObject));
							if (77797 - 528681 != -450883)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl48")
					{
						if (166134 - 502347 == -336213)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/ladybugHelmetR", typeof(GameObject));
							if (132134 - 506467 == -374333)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl50")
					{
						if (214277 - 484054 == -269777)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/royalHelmet", typeof(GameObject));
							if (153268 - 582172 == -428904)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl51")
					{
						if (248503 - 15218 != 233286)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/royalHelmet", typeof(GameObject));
							if (69812 - 369936 == -300124)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl52")
					{
						if (263405 - 185549 != 77857)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/royalHelmetR", typeof(GameObject));
							if (228463 - 32748 != 195716)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl60")
					{
						if (80523 - 81413 != -889)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/legendHelmet", typeof(GameObject));
							if (111159 - 407996 == -296837)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl61")
					{
						if (284046 - 275519 != 8528)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/legendHelmet", typeof(GameObject));
							if (179484 - 294009 != -114524)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_whl62")
					{
						if (33294 - 455892 != -422597)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/legendHelmetR", typeof(GameObject));
							if (251201 - 300917 != -49715)
							{
								break;
							}
						}
					}
					else
					{
						if (!(nAccessory == "c_whl65"))
						{
							break;
						}
						if (174409 - 370781 != -196371)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Accessories/koreaHat", typeof(GameObject));
							if (171449 - 386501 != -215051)
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

	// Token: 0x06003656 RID: 13910 RVA: 0x0070AE00 File Offset: 0x00709000
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipAccessory(string nAccessory)
	{
		if (89028 - 518092 != -429064)
		{
		}
		for (;;)
		{
			this.accessory = nAccessory;
			if (259601 - 196871 != 62731)
			{
				if (this.LR2oH99c1X)
				{
					if (190875 - 173007 != 17868)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.LR2oH99c1X);
					if (147328 - 497251 != -349923)
					{
						continue;
					}
				}
				GameObject gameObject = WhaleEquipment.getAccessory(nAccessory);
				if (45014 - 357047 != -312032)
				{
					if (gameObject)
					{
						if (7467 - 253219 == -245751)
						{
							continue;
						}
						this.LR2oH99c1X = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (275760 - 53667 == 222094 || 227744 - 410450 == -182705)
						{
							continue;
						}
						if (!(nAccessory == "c_all27"))
						{
							if (237053 - 421323 != -184270)
							{
								continue;
							}
							if (nAccessory == "c_all28")
							{
								if (227655 - 152773 == 74883)
								{
									continue;
								}
							}
							else
							{
								this.LR2oH99c1X.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
								if (243568 - 369243 == -125674)
								{
									continue;
								}
								this.LR2oH99c1X.transform.localPosition = Vector3.zero;
								if (34437 - 38358 == -3920)
								{
									continue;
								}
								this.LR2oH99c1X.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
								if (267390 - 559472 != -292082)
								{
									continue;
								}
								this.LR2oH99c1X.transform.localScale = Vector3.one;
								if (110828 - 512808 != -401979)
								{
									goto IL_103;
								}
								continue;
							}
						}
						this.LR2oH99c1X.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
						if (129853 - 332800 != -202947)
						{
							continue;
						}
						this.LR2oH99c1X.transform.localPosition = Vector3.zero;
						if (270776 - 595532 != -324756)
						{
							continue;
						}
						this.LR2oH99c1X.transform.localRotation = Quaternion.Euler((float)270, (float)0, (float)90);
						if (272469 - 337225 != -64756)
						{
							continue;
						}
						this.LR2oH99c1X.transform.localScale = Vector3.one;
						if (130259 - 321823 != -191564)
						{
							continue;
						}
					}
					IL_103:
					if (!this.K8cod9YfHW)
					{
						break;
					}
					if (152968 - 176305 == -23337)
					{
						this.K8cod9YfHW.accessory = nAccessory;
						if (129423 - 411731 == -282308)
						{
							this.K8cod9YfHW.mAcc = this.LR2oH99c1X;
							if (144599 - 366764 != -222164)
							{
								if (this.K8cod9YfHW.getStatus("blend") != null)
								{
									if (116468 - 135510 == -19041)
									{
										continue;
									}
									this.K8cod9YfHW.removeStatus("blend");
									if (82167 - 119940 == -37772)
									{
										continue;
									}
								}
								if (this.K8cod9YfHW.getStatus("invisible") == null)
								{
									break;
								}
								if (66905 - 342213 == -275308)
								{
									this.K8cod9YfHW.removeStatus("invisible");
									if (49180 - 407826 == -358646)
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

	// Token: 0x06003657 RID: 13911 RVA: 0x0070B278 File Offset: 0x00709478
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipBoot(string nBoot)
	{
		if (247138 - 542558 != -295419)
		{
		}
		while (this.K8cod9YfHW)
		{
			if (119470 - 351626 != -232155)
			{
				if (this.K8cod9YfHW.getStatus("blend") != null)
				{
					if (107913 - 405207 != -297294)
					{
						continue;
					}
					this.K8cod9YfHW.removeStatus("blend");
					if (49539 - 468107 == -418567)
					{
						continue;
					}
				}
				if (this.K8cod9YfHW.getStatus("invisible") == null)
				{
					break;
				}
				if (8647 - 66722 != -58074)
				{
					this.K8cod9YfHW.removeStatus("invisible");
					if (41988 - 103805 != -61816)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003658 RID: 13912 RVA: 0x0070B38C File Offset: 0x0070958C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getTrinket(string nTrinket)
	{
		if (147540 - 189244 != -41703)
		{
		}
		GameObject result;
		for (;;)
		{
			result = null;
			if (234986 - 305355 == -70369)
			{
				if (270285 - 8372 != 261914)
				{
					if (nTrinket == "t_all1")
					{
						if (137148 - 428009 == -290861)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/glasses", typeof(GameObject));
							if (100166 - 237995 != -137828)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all2")
					{
						if (124880 - 569272 != -444391)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/sunGlasses", typeof(GameObject));
							if (139080 - 373571 == -234491)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all3")
					{
						if (188573 - 383963 != -195389)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/starGlasses", typeof(GameObject));
							if (150921 - 271646 != -120724)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all4")
					{
						if (78106 - 322548 != -244441)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/nerdGlasses", typeof(GameObject));
							if (66096 - 182866 == -116770)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all5")
					{
						if (130327 - 260015 != -129687)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/blackGlasses", typeof(GameObject));
							if (274046 - 117204 != 156843)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all6")
					{
						if (107116 - 226915 == -119799)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/bugAntenna", typeof(GameObject));
							if (43138 - 150555 != -107416)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all7")
					{
						if (285597 - 394560 == -108963)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/partyWhistle", typeof(GameObject));
							if (56979 - 259780 != -202800)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all8")
					{
						if (260056 - 51662 != 208395)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/redNose", typeof(GameObject));
							if (145732 - 565320 == -419588)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all9")
					{
						if (160832 - 102853 == 57979)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/lollipop", typeof(GameObject));
							if (154197 - 585124 != -430926)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all46")
					{
						if (241074 - 547697 == -306623)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/groceryBag", typeof(GameObject));
							if (84367 - 114237 != -29869)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all51")
					{
						if (525 - 424337 == -423812)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/sandTopaz", typeof(GameObject));
							if (291900 - 258479 != 33422)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all55")
					{
						if (78122 - 36709 == 41413)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/fifthSword", typeof(GameObject));
							if (263507 - 569254 != -305746)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all56")
					{
						if (49081 - 94223 == -45142)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/fifthWand", typeof(GameObject));
							if (63858 - 34848 == 29010)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all57")
					{
						if (203256 - 252383 == -49127)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/fifthWing", typeof(GameObject));
							if (91685 - 255151 == -163466)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all58")
					{
						if (200430 - 7041 != 193390)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/carronBag", typeof(GameObject));
							if (79538 - 410399 == -330861)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all59")
					{
						if (50342 - 346688 == -296346)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/mupoBag", typeof(GameObject));
							if (112617 - 527752 == -415135)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all66")
					{
						if (144136 - 505139 != -361002)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/doubleHorn", typeof(GameObject));
							if (56815 - 417735 != -360919)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all71")
					{
						if (68479 - 488844 != -420364)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/championFlag1", typeof(GameObject));
							if (102787 - 41812 == 60975)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all72")
					{
						if (103558 - 441100 != -337541)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/championFlag2", typeof(GameObject));
							if (60357 - 374422 != -314064)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all73")
					{
						if (110032 - 236261 == -126229)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/championFlag3", typeof(GameObject));
							if (108378 - 90336 == 18042)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all74")
					{
						if (289921 - 278510 != 11412)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/championFlag4", typeof(GameObject));
							if (90374 - 322164 != -231789)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all75")
					{
						if (8720 - 448408 != -439687)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/championFlag5", typeof(GameObject));
							if (111433 - 491705 == -380272)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all91")
					{
						if (248383 - 125848 == 122535)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/lightSeal", typeof(GameObject));
							if (109931 - 108439 == 1492)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all92")
					{
						if (48501 - 9040 == 39461)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/fireSeal", typeof(GameObject));
							if (52257 - 65650 != -13392)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all93")
					{
						if (51075 - 432937 == -381862)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/waterSeal", typeof(GameObject));
							if (108992 - 514551 == -405559)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all94")
					{
						if (273624 - 440200 == -166576)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/windSeal", typeof(GameObject));
							if (179737 - 304081 != -124343)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all95")
					{
						if (282872 - 249494 == 33378)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/earthSeal", typeof(GameObject));
							if (18264 - 557335 != -539070)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all96")
					{
						if (16294 - 418561 != -402266)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/shadowSeal", typeof(GameObject));
							if (239097 - 591223 != -352125)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal11")
					{
						if (6595 - 575023 == -568428)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/comic", typeof(GameObject));
							if (263856 - 530177 != -266320)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal14")
					{
						if (265087 - 150786 == 114301)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/heartRing", typeof(GameObject));
							if (211753 - 599036 != -387282)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal15")
					{
						if (149622 - 206575 != -56952)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/santaBag", typeof(GameObject));
							if (59697 - 93664 != -33966)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal31")
					{
						if (235499 - 270541 != -35041)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/chineseTalisman", typeof(GameObject));
							if (231219 - 377387 == -146168)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal37")
					{
						if (33490 - 407586 == -374096)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/chineseLantern", typeof(GameObject));
							if (215797 - 9397 != 206401)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal46")
					{
						if (181696 - 33898 == 147798)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/curseAnkh", typeof(GameObject));
							if (12521 - 563857 != -551335)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal56")
					{
						if (145482 - 28752 != 116731)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/frozenWing", typeof(GameObject));
							if (276083 - 445962 != -169878)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal66")
					{
						if (47265 - 281436 == -234171)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/poseidonTrinket", typeof(GameObject));
							if (15445 - 336696 == -321251)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_whl60")
					{
						if (28306 - 236000 != -207693)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/legendTrinket", typeof(GameObject));
							if (59162 - 53714 == 5448)
							{
								break;
							}
						}
					}
					else
					{
						if (!(nTrinket == "t_whl62"))
						{
							break;
						}
						if (118705 - 424845 == -306140)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Trinkets/legendTrinketR", typeof(GameObject));
							if (54670 - 55608 == -938)
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

	// Token: 0x06003659 RID: 13913 RVA: 0x0070C2B0 File Offset: 0x0070A4B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipTrinket(string nTrinket)
	{
		if (78124 - 273258 != -195133)
		{
		}
		for (;;)
		{
			this.trinket = nTrinket;
			if (276059 - 594657 != -318597)
			{
				if (this.ycOo78J7nm)
				{
					if (92004 - 122991 == -30986)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.ycOo78J7nm);
					if (284761 - 396576 == -111814)
					{
						continue;
					}
				}
				GameObject gameObject = WhaleEquipment.getTrinket(nTrinket);
				if (237252 - 454668 != -217415)
				{
					if (gameObject)
					{
						if (38606 - 183289 != -144683)
						{
							continue;
						}
						this.ycOo78J7nm = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (122139 - 463690 == -341550 || 238607 - 259948 == -21340)
						{
							continue;
						}
						if (!(nTrinket == "t_all71"))
						{
							if (287551 - 515315 == -227763)
							{
								continue;
							}
							if (!(nTrinket == "t_all72"))
							{
								if (178199 - 247515 != -69316)
								{
									continue;
								}
								if (!(nTrinket == "t_all73"))
								{
									if (102607 - 178490 == -75882)
									{
										continue;
									}
									if (!(nTrinket == "t_all74"))
									{
										if (171408 - 444577 != -273169)
										{
											continue;
										}
										if (!(nTrinket == "t_all75"))
										{
											if (253597 - 259635 != -6038)
											{
												continue;
											}
											if (!(nTrinket == "t_mal56"))
											{
												if (261643 - 147765 != 113878)
												{
													continue;
												}
												if (nTrinket == "t_mal66")
												{
													if (275790 - 45764 == 230027)
													{
														continue;
													}
												}
												else if (nTrinket == "t_mal11")
												{
													if (159600 - 290882 != -131282)
													{
														continue;
													}
													this.ycOo78J7nm.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Hand_R");
													if (68989 - 135996 == -67006)
													{
														continue;
													}
													this.ycOo78J7nm.transform.localPosition = Vector3.zero;
													if (183987 - 188255 != -4268)
													{
														continue;
													}
													this.ycOo78J7nm.transform.localRotation = Quaternion.identity;
													if (250914 - 186227 == 64688)
													{
														continue;
													}
													this.ycOo78J7nm.transform.localScale = Vector3.one;
													if (282314 - 486503 != -204189)
													{
														continue;
													}
													goto IL_7E4;
												}
												else
												{
													if (!(nTrinket == "t_all55"))
													{
														if (58098 - 304948 == -246849)
														{
															continue;
														}
														if (!(nTrinket == "t_all56"))
														{
															if (69004 - 354233 != -285229)
															{
																continue;
															}
															if (!(nTrinket == "t_all57"))
															{
																if (82054 - 256595 != -174541)
																{
																	continue;
																}
																if (!(nTrinket == "t_all58"))
																{
																	if (18743 - 228995 != -210252)
																	{
																		continue;
																	}
																	if (!(nTrinket == "t_all59"))
																	{
																		if (91053 - 426726 != -335673)
																		{
																			continue;
																		}
																		if (!(nTrinket == "t_mal15"))
																		{
																			if (190024 - 281529 == -91504)
																			{
																				continue;
																			}
																			if (!(nTrinket == "t_whl60"))
																			{
																				if (140083 - 547409 == -407325)
																				{
																					continue;
																				}
																				if (nTrinket == "t_whl62")
																				{
																					if (109723 - 241373 == -131649)
																					{
																						continue;
																					}
																				}
																				else if (nTrinket == "t_mal37")
																				{
																					if (248911 - 380903 != -131992)
																					{
																						continue;
																					}
																					this.ycOo78J7nm.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine2");
																					if (282328 - 57340 == 224989)
																					{
																						continue;
																					}
																					this.ycOo78J7nm.transform.localPosition = Vector3.zero;
																					if (266544 - 187455 != 79089)
																					{
																						continue;
																					}
																					this.ycOo78J7nm.transform.localRotation = Quaternion.Euler((float)270, (float)90, (float)0);
																					if (200131 - 494851 != -294720)
																					{
																						continue;
																					}
																					this.ycOo78J7nm.transform.localScale = Vector3.one;
																					if (251441 - 167862 != 83580)
																					{
																						goto IL_7E4;
																					}
																					continue;
																				}
																				else if (nTrinket == "t_all46")
																				{
																					if (206852 - 535463 != -328611)
																					{
																						continue;
																					}
																					this.ycOo78J7nm.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Hand_R");
																					if (222883 - 42548 == 180336)
																					{
																						continue;
																					}
																					this.ycOo78J7nm.transform.localPosition = Vector3.zero;
																					if (277916 - 523325 == -245408)
																					{
																						continue;
																					}
																					this.ycOo78J7nm.transform.localRotation = Quaternion.identity;
																					if (32499 - 469425 != -436926)
																					{
																						continue;
																					}
																					this.ycOo78J7nm.transform.localScale = 1.2f * Vector3.one;
																					if (25184 - 494186 != -469001)
																					{
																						goto IL_7E4;
																					}
																					continue;
																				}
																				else
																				{
																					if (!(nTrinket == "t_all91"))
																					{
																						if (200839 - 194891 == 5949)
																						{
																							continue;
																						}
																						if (!(nTrinket == "t_all92"))
																						{
																							if (241462 - 274593 == -33130)
																							{
																								continue;
																							}
																							if (!(nTrinket == "t_all93"))
																							{
																								if (299576 - 188552 == 111025)
																								{
																									continue;
																								}
																								if (!(nTrinket == "t_all94"))
																								{
																									if (165153 - 244175 == -79021)
																									{
																										continue;
																									}
																									if (!(nTrinket == "t_all95"))
																									{
																										if (98154 - 404048 != -305894)
																										{
																											continue;
																										}
																										if (nTrinket == "t_all96")
																										{
																											if (40168 - 225791 != -185623)
																											{
																												continue;
																											}
																										}
																										else
																										{
																											this.ycOo78J7nm.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
																											if (118571 - 292969 == -174397)
																											{
																												continue;
																											}
																											this.ycOo78J7nm.transform.localPosition = Vector3.zero;
																											if (230908 - 493804 == -262895)
																											{
																												continue;
																											}
																											this.ycOo78J7nm.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
																											if (170833 - 6996 != 163837)
																											{
																												continue;
																											}
																											this.ycOo78J7nm.transform.localScale = Vector3.one;
																											if (236496 - 225668 != 10829)
																											{
																												goto IL_7E4;
																											}
																											continue;
																										}
																									}
																								}
																							}
																						}
																					}
																					this.ycOo78J7nm.transform.parent = this.gameObject.transform;
																					if (69769 - 108841 != -39072)
																					{
																						continue;
																					}
																					this.ycOo78J7nm.transform.localPosition = Vector3.zero;
																					if (102170 - 91059 != 11111)
																					{
																						continue;
																					}
																					this.ycOo78J7nm.transform.localRotation = Quaternion.identity;
																					if (188951 - 326571 != -137620)
																					{
																						continue;
																					}
																					this.ycOo78J7nm.transform.localScale = Vector3.one;
																					if (107118 - 46411 != 60708)
																					{
																						goto IL_7E4;
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
													this.ycOo78J7nm.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine1");
													if (273438 - 447315 != -173877)
													{
														continue;
													}
													this.ycOo78J7nm.transform.localPosition = Vector3.zero;
													if (274879 - 409545 == -134665)
													{
														continue;
													}
													this.ycOo78J7nm.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
													if (113464 - 23125 != 90339)
													{
														continue;
													}
													this.ycOo78J7nm.transform.localScale = Vector3.one;
													if (281766 - 11625 != 270142)
													{
														goto IL_7E4;
													}
													continue;
												}
											}
										}
									}
								}
							}
						}
						this.ycOo78J7nm.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine2");
						if (25557 - 161961 == -136403)
						{
							continue;
						}
						this.ycOo78J7nm.transform.localPosition = Vector3.zero;
						if (11749 - 242614 == -230864)
						{
							continue;
						}
						this.ycOo78J7nm.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
						if (172220 - 406670 != -234450)
						{
							continue;
						}
						this.ycOo78J7nm.transform.localScale = Vector3.one;
						if (110693 - 293306 != -182613)
						{
							continue;
						}
					}
					IL_7E4:
					if (!this.K8cod9YfHW)
					{
						break;
					}
					if (19664 - 381315 == -361651)
					{
						this.K8cod9YfHW.trinket = nTrinket;
						if (84627 - 237950 == -153323)
						{
							this.K8cod9YfHW.mTrn = this.ycOo78J7nm;
							if (160162 - 282843 != -122680)
							{
								if (this.K8cod9YfHW.getStatus("blend") != null)
								{
									if (170625 - 282446 == -111820)
									{
										continue;
									}
									this.K8cod9YfHW.removeStatus("blend");
									if (39185 - 291186 == -252000)
									{
										continue;
									}
								}
								if (this.K8cod9YfHW.getStatus("invisible") == null)
								{
									break;
								}
								if (45916 - 314540 != -268623)
								{
									this.K8cod9YfHW.removeStatus("invisible");
									if (97999 - 3432 != 94568)
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

	// Token: 0x0600365A RID: 13914 RVA: 0x0070CEE8 File Offset: 0x0070B0E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipPet(string nPet)
	{
		if (89099 - 490170 != -401071)
		{
		}
		for (;;)
		{
			if (Game.mGameType < 2)
			{
				if (192579 - 398163 == -205584)
				{
					break;
				}
			}
			else
			{
				this.pet = nPet;
				if (26746 - 74191 != -47444)
				{
					if (this.jTpoZ2U7Ra)
					{
						if (87059 - 473716 != -386657)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.jTpoZ2U7Ra);
						if (179490 - 301907 != -122417)
						{
							continue;
						}
					}
					GameObject gameObject = null;
					if (93378 - 312446 == -219068)
					{
						int num = 1;
						if (257372 - 533090 == -275718)
						{
							if (87568 - 260044 != -172475)
							{
								if (nPet == "p_all1")
								{
									if (96875 - 499390 == -402514)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/bigbugBalloon", typeof(GameObject));
									if (39838 - 85527 == -45688)
									{
										continue;
									}
								}
								else if (nPet == "p_all2")
								{
									if (270536 - 112901 == 157636)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/bluebugBalloon", typeof(GameObject));
									if (292971 - 454119 != -161148)
									{
										continue;
									}
								}
								else if (nPet == "p_all3")
								{
									if (291601 - 17520 != 274081)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/momBalloon", typeof(GameObject));
									if (115916 - 116612 != -696)
									{
										continue;
									}
								}
								else if (nPet == "p_all4")
								{
									if (120642 - 201217 != -80575)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/dadBalloon", typeof(GameObject));
									if (172672 - 227311 == -54638)
									{
										continue;
									}
								}
								else if (nPet == "p_all11")
								{
									if (70496 - 247729 != -177233)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallSmashBall", typeof(GameObject));
									if (112744 - 70850 != 41894)
									{
										continue;
									}
								}
								else if (nPet == "p_all12")
								{
									if (181295 - 187566 != -6271)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/soccerBall", typeof(GameObject));
									if (231791 - 588194 != -356403)
									{
										continue;
									}
								}
								else if (nPet == "p_all21")
								{
									if (131560 - 545356 != -413796)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteChula", typeof(GameObject));
									if (236144 - 385220 != -149076)
									{
										continue;
									}
								}
								else if (nPet == "p_all22")
								{
									if (235796 - 43567 == 192230)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kitePukpao", typeof(GameObject));
									if (296508 - 300781 == -4272)
									{
										continue;
									}
								}
								else if (nPet == "p_all23")
								{
									if (288500 - 78491 == 210010)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteButterfly", typeof(GameObject));
									if (238847 - 156897 == 81951)
									{
										continue;
									}
								}
								else if (nPet == "p_all24")
								{
									if (196668 - 549651 != -352983)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteSnake", typeof(GameObject));
									if (103013 - 240347 == -137333)
									{
										continue;
									}
								}
								else if (Extensions.get_length(nPet) == 6)
								{
									if (23833 - 298564 != -274731)
									{
										continue;
									}
									string a = nPet.Substring(0, 5);
									if (111310 - 582220 == -470909)
									{
										continue;
									}
									if (a == "p_lcr")
									{
										if (41256 - 367963 != -326707)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron", typeof(GameObject));
										if (9770 - 336741 == -326970)
										{
											continue;
										}
									}
									else if (a == "p_lcp")
									{
										if (288978 - 182750 != 106228)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron_p", typeof(GameObject));
										if (245752 - 538007 != -292255)
										{
											continue;
										}
									}
									else if (a == "p_lmp")
									{
										if (138705 - 25236 == 113470)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMupo", typeof(GameObject));
										if (298711 - 256391 != 42320)
										{
											continue;
										}
									}
									else if (a == "p_lpp")
									{
										if (121145 - 398799 == -277653)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePeppon", typeof(GameObject));
										if (299972 - 365625 != -65653)
										{
											continue;
										}
									}
									else if (a == "p_lct")
									{
										if (59873 - 69800 == -9926)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCacton", typeof(GameObject));
										if (62418 - 437190 != -374772)
										{
											continue;
										}
									}
									else if (a == "p_lcc")
									{
										if (163421 - 381520 != -218099)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCocon", typeof(GameObject));
										if (29673 - 32209 == -2535)
										{
											continue;
										}
									}
									else if (a == "p_lpk")
									{
										if (278876 - 242072 != 36804)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePumpkon", typeof(GameObject));
										if (235060 - 545842 != -310782)
										{
											continue;
										}
									}
									else if (a == "p_lml")
									{
										if (296870 - 362526 != -65656)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMellon", typeof(GameObject));
										if (9988 - 203315 == -193326)
										{
											continue;
										}
									}
									else if (a == "p_lbd")
									{
										if (168330 - 397307 != -228977)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleBDMellon", typeof(GameObject));
										if (128076 - 451739 == -323662)
										{
											continue;
										}
									}
									else if (a == "p_lcs")
									{
										if (101663 - 259984 == -158320)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron_s", typeof(GameObject));
										if (245247 - 309355 == -64107)
										{
											continue;
										}
									}
									else if (a == "p_lms")
									{
										if (233389 - 109579 != 123810)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMupo_s", typeof(GameObject));
										if (21187 - 338304 == -317116)
										{
											continue;
										}
									}
									else if (a == "p_lps")
									{
										if (226089 - 263768 != -37679)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePeppon_s", typeof(GameObject));
										if (87815 - 538798 == -450982)
										{
											continue;
										}
									}
									else if (a == "p_lck")
									{
										if (186612 - 397475 != -210863)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarronCake", typeof(GameObject));
										if (72519 - 194875 == -122355)
										{
											continue;
										}
									}
									else if (a == "p_lpd")
									{
										if (73288 - 44645 == 28644)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePepponDisco", typeof(GameObject));
										if (101630 - 134286 == -32655)
										{
											continue;
										}
									}
									else if (a == "p_lmc")
									{
										if (230333 - 220580 == 9754)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadCarron", typeof(GameObject));
										if (149492 - 492904 == -343411)
										{
											continue;
										}
									}
									else if (a == "p_lmn")
									{
										if (73797 - 470223 == -396425)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadPeppon", typeof(GameObject));
										if (269886 - 45442 == 224445)
										{
											continue;
										}
									}
									else if (a == "p_lmo")
									{
										if (292833 - 270581 != 22252)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadCocon", typeof(GameObject));
										if (26051 - 594795 == -568743)
										{
											continue;
										}
									}
									else if (a == "p_ldc")
									{
										if (284396 - 143302 == 141095)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCarron", typeof(GameObject));
										if (95643 - 506316 != -410673)
										{
											continue;
										}
									}
									else if (a == "p_ldm")
									{
										if (123002 - 501278 != -378276)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadMupo", typeof(GameObject));
										if (236616 - 43246 == 193371)
										{
											continue;
										}
									}
									else if (a == "p_ldp")
									{
										if (207066 - 124384 != 82682)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadPeppon", typeof(GameObject));
										if (216154 - 364157 != -148003)
										{
											continue;
										}
									}
									else if (a == "p_ldt")
									{
										if (134649 - 205887 == -71237)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCacton", typeof(GameObject));
										if (107225 - 70248 == 36978)
										{
											continue;
										}
									}
									else if (a == "p_ldn")
									{
										if (105792 - 591133 != -485341)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCocon", typeof(GameObject));
										if (34402 - 269952 == -235549)
										{
											continue;
										}
									}
									else if (a == "p_ldk")
									{
										if (73222 - 585766 == -512543)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadPumpkon", typeof(GameObject));
										if (158394 - 237369 != -78975)
										{
											continue;
										}
									}
									else if (a == "p_srp")
									{
										if (229140 - 27250 != 201890)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallRedPanda", typeof(GameObject));
										if (33039 - 361931 == -328891)
										{
											continue;
										}
									}
									else if (a == "p_sss")
									{
										if (230020 - 199003 != 31017)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallSantaSkunk", typeof(GameObject));
										if (186402 - 71795 != 114607)
										{
											continue;
										}
									}
									else if (a == "p_sbb")
									{
										if (207347 - 406548 == -199200)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallBarrelBot", typeof(GameObject));
										if (177212 - 212393 != -35181)
										{
											continue;
										}
									}
									else if (a == "p_sdm")
									{
										if (122596 - 137053 == -14456)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallDemion", typeof(GameObject));
										if (128035 - 548221 != -420186)
										{
											continue;
										}
									}
									else if (a == "p_sdv")
									{
										if (286354 - 351022 == -64667)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallDoov", typeof(GameObject));
										if (77858 - 262068 == -184209)
										{
											continue;
										}
									}
									else if (a == "p_skz")
									{
										if (298219 - 135026 != 163193)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallKarazo", typeof(GameObject));
										if (22681 - 123593 != -100912)
										{
											continue;
										}
									}
									else if (a == "p_skm")
									{
										if (3028 - 467352 != -464324)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallKumo", typeof(GameObject));
										if (270861 - 170961 == 99901)
										{
											continue;
										}
									}
									else if (a == "p_skr")
									{
										if (231767 - 128473 != 103294)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_r", typeof(GameObject));
										if (181769 - 255967 != -74198)
										{
											continue;
										}
									}
									else if (a == "p_skg")
									{
										if (26743 - 255520 != -228777)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_g", typeof(GameObject));
										if (93328 - 475624 != -382296)
										{
											continue;
										}
									}
									else if (a == "p_sky")
									{
										if (286239 - 384970 != -98731)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_y", typeof(GameObject));
										if (68559 - 520752 == -452192)
										{
											continue;
										}
									}
									else if (a == "p_skb")
									{
										if (189384 - 342512 == -153127)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_b", typeof(GameObject));
										if (32664 - 241026 != -208362)
										{
											continue;
										}
									}
									else if (a == "p_skk")
									{
										if (45711 - 451802 != -406091)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_k", typeof(GameObject));
										if (193294 - 335733 == -142438)
										{
											continue;
										}
									}
									else if (a == "p_sfb")
									{
										if (126264 - 152233 == -25968)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallFlowerBug", typeof(GameObject));
										if (181061 - 17169 == 163893)
										{
											continue;
										}
									}
									else if (a == "p_sob")
									{
										if (216320 - 111698 != 104622)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallLionBug", typeof(GameObject));
										if (28546 - 71614 != -43068)
										{
											continue;
										}
									}
									else if (a == "p_sgb")
									{
										if (93243 - 430001 == -336757)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallGiantBug", typeof(GameObject));
										if (48195 - 554011 != -505816)
										{
											continue;
										}
									}
									else if (a == "p_slb")
									{
										if (62849 - 58561 != 4288)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallLeafBug", typeof(GameObject));
										if (167850 - 427584 != -259734)
										{
											continue;
										}
									}
									else if (a == "p_stb")
									{
										if (29600 - 181953 == -152352)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallFatBug", typeof(GameObject));
										if (266670 - 547950 != -281280)
										{
											continue;
										}
									}
									else if (a == "p_spb")
									{
										if (87595 - 491980 != -404385)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallPaperBug", typeof(GameObject));
										if (184294 - 103423 == 80872)
										{
											continue;
										}
									}
									else if (a == "p_swb")
									{
										if (217703 - 136345 != 81358)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallWormBug", typeof(GameObject));
										if (125071 - 534094 == -409022)
										{
											continue;
										}
									}
									else if (a == "p_ssq")
									{
										if (293246 - 157847 != 135399)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallStingQueen", typeof(GameObject));
										if (233646 - 509046 != -275400)
										{
											continue;
										}
									}
									else if (a == "p_snb")
									{
										if (78341 - 308073 == -229731)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNeonBug", typeof(GameObject));
										if (218131 - 128505 != 89626)
										{
											continue;
										}
									}
									else if (a == "p_sim")
									{
										if (46806 - 316126 == -269319)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallIceMixer", typeof(GameObject));
										if (74147 - 338611 == -264463)
										{
											continue;
										}
									}
									else if (a == "p_sam")
									{
										if (229774 - 501914 == -272139)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallAmmonite", typeof(GameObject));
										if (292065 - 398510 != -106445)
										{
											continue;
										}
									}
									else if (a == "p_sab")
									{
										if (234338 - 549076 == -314737)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallAnubi", typeof(GameObject));
										if (29168 - 71863 == -42694)
										{
											continue;
										}
									}
									else if (a == "p_spg")
									{
										if (168874 - 354146 != -185272)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallIcePenguin", typeof(GameObject));
										if (168605 - 467085 != -298480)
										{
											continue;
										}
									}
									else if (a == "p_spf")
									{
										if (82443 - 478060 != -395617)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallPirateFish", typeof(GameObject));
										if (239137 - 160431 == 78707)
										{
											continue;
										}
									}
									else if (a == "p_msb")
									{
										if (88192 - 12134 == 76059)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniSkyBug", typeof(GameObject));
										if (118892 - 79142 != 39750)
										{
											continue;
										}
									}
									else if (a == "p_mcb")
									{
										if (89984 - 328418 == -238433)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniCrystalBug", typeof(GameObject));
										if (144575 - 290681 != -146106)
										{
											continue;
										}
									}
									else if (a == "p_mab")
									{
										if (50245 - 394077 != -343832)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniAncientBug", typeof(GameObject));
										if (122595 - 152471 != -29876)
										{
											continue;
										}
									}
									else if (a == "p_mrb")
									{
										if (111104 - 519432 != -408328)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniReefBug", typeof(GameObject));
										if (185536 - 431891 != -246355)
										{
											continue;
										}
									}
									else if (a == "p_mmb")
									{
										if (135800 - 289291 != -153491)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniMokBug", typeof(GameObject));
										if (20356 - 270400 != -250044)
										{
											continue;
										}
									}
									else if (a == "p_mgb")
									{
										if (171242 - 287970 == -116727)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniGoldenBug", typeof(GameObject));
										if (36915 - 337494 != -300579)
										{
											continue;
										}
									}
									else if (a == "p_mnb")
									{
										if (217941 - 387385 == -169443)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniNemesisBug", typeof(GameObject));
										if (282177 - 357172 != -74995)
										{
											continue;
										}
									}
									num = Stringf.getLastDigit(nPet);
									if (284877 - 202243 == 82635)
									{
										continue;
									}
									if (num < 0)
									{
										if (53347 - 64756 != -11409)
										{
											continue;
										}
										num = 1;
										if (103574 - 163584 == -60009)
										{
											continue;
										}
									}
								}
								if (gameObject)
								{
									if (163123 - 452500 == -289376)
									{
										continue;
									}
									this.jTpoZ2U7Ra = (GameObject)UnityEngine.Object.Instantiate(gameObject, this.transform.position - this.transform.forward, this.transform.rotation);
									if (293413 - 540562 != -247149)
									{
										continue;
									}
									if (this.jTpoZ2U7Ra)
									{
										if (139986 - 311437 != -171451)
										{
											continue;
										}
										this.jTpoZ2U7Ra.transform.localScale = ((float)num * 0.1f + 0.9f) * Vector3.one;
										if (15050 - 524399 == -509348)
										{
											continue;
										}
										PetControl petControl = (PetControl)this.jTpoZ2U7Ra.GetComponent(typeof(PetControl));
										if (221316 - 35029 == 186288)
										{
											continue;
										}
										if (petControl)
										{
											if (200078 - 480047 == -279968)
											{
												continue;
											}
											petControl.Init(this.gameObject, num);
											if (150606 - 574125 == -423518)
											{
												continue;
											}
										}
										if (this.K8cod9YfHW)
										{
											if (255739 - 295767 != -40028)
											{
												continue;
											}
											this.K8cod9YfHW.mPet = this.jTpoZ2U7Ra;
											if (200325 - 394522 == -194196)
											{
												continue;
											}
										}
									}
								}
								if (!this.K8cod9YfHW)
								{
									break;
								}
								if (144789 - 217030 != -72240)
								{
									this.K8cod9YfHW.pet = nPet;
									if (99738 - 152328 != -52589)
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

	// Token: 0x0600365B RID: 13915 RVA: 0x0070EC4C File Offset: 0x0070CE4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void scaleWeapon(float scale)
	{
		if (287101 - 241829 != 45272)
		{
		}
		for (;;)
		{
			if (this.qcgogZGF60 != null)
			{
				if (220906 - 434821 == -213914)
				{
					continue;
				}
				this.qcgogZGF60.transform.localScale = new Vector3(scale, scale, scale);
				if (222073 - 35493 != 186580)
				{
					continue;
				}
			}
			if (!(this.j7KoadBAAv != null))
			{
				break;
			}
			if (290073 - 183288 == 106785)
			{
				this.j7KoadBAAv.transform.localScale = new Vector3(scale, scale, scale);
				if (212683 - 299011 != -86327)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600365C RID: 13916 RVA: 0x0070ED40 File Offset: 0x0070CF40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600365D RID: 13917 RVA: 0x0070ED44 File Offset: 0x0070CF44
	internal static bool oRxBmC5lTJQ1Od109wI6()
	{
		return true;
	}

	// Token: 0x0600365E RID: 13918 RVA: 0x0070ED48 File Offset: 0x0070CF48
	internal static bool eqCt4Q5l33nSCS8dk0Rh()
	{
		return false;
	}

	// Token: 0x04004388 RID: 17288
	private CharacterControl K8cod9YfHW;

	// Token: 0x04004389 RID: 17289
	public string weapon;

	// Token: 0x0400438A RID: 17290
	public string armor;

	// Token: 0x0400438B RID: 17291
	public string accessory;

	// Token: 0x0400438C RID: 17292
	public string boot;

	// Token: 0x0400438D RID: 17293
	public string trinket;

	// Token: 0x0400438E RID: 17294
	public string pet;

	// Token: 0x0400438F RID: 17295
	public int skin;

	// Token: 0x04004390 RID: 17296
	public bool equipOnStart;

	// Token: 0x04004391 RID: 17297
	private GameObject qcgogZGF60;

	// Token: 0x04004392 RID: 17298
	private GameObject j7KoadBAAv;

	// Token: 0x04004393 RID: 17299
	private GameObject ca3o4bxVu4;

	// Token: 0x04004394 RID: 17300
	private GameObject hASosgO1re;

	// Token: 0x04004395 RID: 17301
	private GameObject LR2oH99c1X;

	// Token: 0x04004396 RID: 17302
	private GameObject ycOo78J7nm;

	// Token: 0x04004397 RID: 17303
	private GameObject jTpoZ2U7Ra;
}
