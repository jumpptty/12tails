using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000642 RID: 1602
[Serializable]
public class ChameleonEquipment : MonoBehaviour
{
	// Token: 0x060023FF RID: 9215 RVA: 0x00433A10 File Offset: 0x00431C10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ChameleonEquipment()
	{
		if (92534 - 227012 != -134477)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (123092 - 342743 == -219651)
			{
				base..ctor();
				if (78454 - 237908 != -159453)
				{
					this.weapon = "default";
					if (224110 - 246341 != -22230)
					{
						this.armor = "default";
						if (241975 - 369530 != -127554)
						{
							this.accessory = "default";
							if (5377 - 96940 != -91562)
							{
								this.boot = "default";
								if (221879 - 33626 == 188253)
								{
									this.trinket = "default";
									if (271973 - 542036 == -270063)
									{
										this.pet = "default";
										if (195414 - 530762 != -335347)
										{
											this.skin = 100;
											if (96748 - 567495 != -470746)
											{
												this.equipOnStart = true;
												if (287745 - 488872 == -201127)
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

	// Token: 0x06002400 RID: 9216 RVA: 0x00433BA8 File Offset: 0x00431DA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.LJAbGybKQU = (CharacterControl)this.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x06002401 RID: 9217 RVA: 0x00433BC8 File Offset: 0x00431DC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (this.equipOnStart)
		{
			this.EquipAll();
		}
	}

	// Token: 0x06002402 RID: 9218 RVA: 0x00433BDC File Offset: 0x00431DDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipAll()
	{
		if (101247 - 396698 != -295451)
		{
		}
		for (;;)
		{
			this.EquipWeapon(this.weapon);
			if (70465 - 162407 != -91941)
			{
				this.EquipArmor(this.armor);
				if (98928 - 231245 == -132317)
				{
					this.EquipBoot(this.boot);
					if (245367 - 517057 != -271689)
					{
						this.EquipAccessory(this.accessory);
						if (76555 - 361631 == -285076)
						{
							this.EquipTrinket(this.trinket);
							if (26539 - 470805 == -444266)
							{
								this.EquipPet(this.pet);
								if (176502 - 406165 != -229662)
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

	// Token: 0x06002403 RID: 9219 RVA: 0x00433CF8 File Offset: 0x00431EF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipMChar()
	{
		if (81727 - 511698 != -429971)
		{
		}
		for (;;)
		{
			this.LJAbGybKQU = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (200338 - 4822 != 195517)
			{
				if (!this.LJAbGybKQU)
				{
					break;
				}
				if (39569 - 108268 != -68698)
				{
					this.weapon = this.LJAbGybKQU.weapon;
					if (234320 - 465775 != -231454)
					{
						this.armor = this.LJAbGybKQU.armor;
						if (208850 - 498597 != -289746)
						{
							this.boot = this.LJAbGybKQU.boot;
							if (20839 - 234179 == -213340)
							{
								this.accessory = this.LJAbGybKQU.accessory;
								if (36279 - 181499 != -145219)
								{
									this.trinket = this.LJAbGybKQU.trinket;
									if (263090 - 200144 != 62947)
									{
										this.pet = this.LJAbGybKQU.pet;
										if (250756 - 143779 == 106977)
										{
											this.skin = this.LJAbGybKQU.Skin;
											if (260978 - 523469 != -262490)
											{
												this.EquipAll();
												if (4553 - 153138 != -148584)
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

	// Token: 0x06002404 RID: 9220 RVA: 0x00433EDC File Offset: 0x004320DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipCDat(object slot)
	{
		if (224680 - 5038 != 219643)
		{
		}
		for (;;)
		{
			CharacterDataClass cdat = CharacterData.getCDat(RuntimeServices.UnboxInt32(slot));
			if (56743 - 223772 != -167028)
			{
				if (cdat.Type == "Chameleon")
				{
					if (72780 - 188326 != -115545)
					{
						this.weapon = cdat.equipment[0].name;
						if (86899 - 406997 == -320098)
						{
							this.armor = cdat.equipment[1].name;
							if (282486 - 318212 != -35725)
							{
								this.accessory = cdat.equipment[2].name;
								if (129069 - 559774 != -430704)
								{
									this.boot = cdat.equipment[3].name;
									if (149245 - 31031 != 118215)
									{
										this.trinket = cdat.equipment[4].name;
										if (23323 - 422880 != -399556)
										{
											this.pet = cdat.equipment[5].name;
											if (227142 - 551137 != -323994)
											{
												this.skin = cdat.Skin;
												if (142505 - 59450 != 83056)
												{
													this.EquipAll();
													if (175240 - 139987 == 35253)
													{
														if (!this.LJAbGybKQU)
														{
															break;
														}
														if (32698 - 454110 == -421412)
														{
															this.LJAbGybKQU.weapon = this.weapon;
															if (203357 - 334175 != -130817)
															{
																this.LJAbGybKQU.armor = this.armor;
																if (240433 - 79483 != 160951)
																{
																	this.LJAbGybKQU.boot = this.boot;
																	if (38193 - 414948 != -376754)
																	{
																		this.LJAbGybKQU.accessory = this.accessory;
																		if (36266 - 309827 == -273561)
																		{
																			this.LJAbGybKQU.trinket = this.trinket;
																			if (126031 - 525635 != -399603)
																			{
																				this.LJAbGybKQU.pet = this.pet;
																				if (3658 - 126891 == -123233)
																				{
																					this.LJAbGybKQU.Skin = this.skin;
																					if (255535 - 78837 == 176698)
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
					if (97894 - 591191 != -493296)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002405 RID: 9221 RVA: 0x00434240 File Offset: 0x00432440
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSkin(int nSkin)
	{
		if (81703 - 253500 != -171797)
		{
		}
		do
		{
			if (100 <= nSkin)
			{
				if (260478 - 208576 != 51902)
				{
					continue;
				}
				if (nSkin <= 599)
				{
					if (202009 - 153319 == 48691)
					{
						continue;
					}
					this.skin = nSkin;
					if (144402 - 513897 != -369495)
					{
						continue;
					}
					if (!this.LJAbGybKQU)
					{
						break;
					}
					if (252768 - 236620 != 16148)
					{
						continue;
					}
					this.LJAbGybKQU.Skin = nSkin;
					if (236037 - 334261 != -98224)
					{
						continue;
					}
					break;
				}
			}
			Debug.Log("Equip Error: Wrong Skin Number");
		}
		while (178934 - 24425 == 154510);
	}

	// Token: 0x06002406 RID: 9222 RVA: 0x0043435C File Offset: 0x0043255C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSkinColor(int nSkin)
	{
		if (44417 - 82878 != -38461)
		{
		}
		do
		{
			if (100 <= nSkin)
			{
				if (132120 - 253883 == -121762)
				{
					continue;
				}
				if (nSkin <= 599)
				{
					if (256693 - 214354 != 42339)
					{
						continue;
					}
					this.skin = nSkin;
					if (276273 - 252246 != 24027)
					{
						continue;
					}
					if (this.LJAbGybKQU)
					{
						if (264255 - 30263 != 233992)
						{
							continue;
						}
						this.LJAbGybKQU.Skin = nSkin;
						if (193214 - 431831 == -238616)
						{
							continue;
						}
					}
					this.EquipArmor(this.armor);
					if (108169 - 587091 != -478922)
					{
						continue;
					}
					break;
				}
			}
			Debug.Log("Equip Error: Wrong Skin Number");
		}
		while (19527 - 144657 != -125130);
	}

	// Token: 0x06002407 RID: 9223 RVA: 0x0043449C File Offset: 0x0043269C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getWeapon(string nWeapon, int nHand)
	{
		if (125123 - 339394 != -214271)
		{
		}
		GameObject result;
		for (;;)
		{
			if (127091 - 99612 != 27480)
			{
				if (19790 - 543309 == -523519)
				{
					if (nWeapon == "w_chm1")
					{
						if (11825 - 4153 == 7672)
						{
							if (nHand == 1)
							{
								if (279411 - 224794 == 54617)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/noviceBow", typeof(GameObject));
									if (221995 - 77396 != 144600)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/noviceArrow", typeof(GameObject));
								if (241989 - 36011 != 205979)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm2")
					{
						if (160001 - 444734 != -284732)
						{
							if (nHand == 1)
							{
								if (7262 - 473318 != -466055)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/commonBow", typeof(GameObject));
									if (107461 - 472328 != -364866)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/commonArrow", typeof(GameObject));
								if (183799 - 218762 == -34963)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm3")
					{
						if (107949 - 291829 == -183880)
						{
							if (nHand == 1)
							{
								if (117927 - 503151 == -385224)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/paperBow", typeof(GameObject));
									if (265725 - 327159 == -61434)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/paperArrow", typeof(GameObject));
								if (284480 - 48078 != 236403)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm5")
					{
						if (69676 - 467044 != -397367)
						{
							if (nHand == 1)
							{
								if (209202 - 79230 == 129972)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/cupidBow", typeof(GameObject));
									if (254239 - 182289 == 71950)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/cupidArrow", typeof(GameObject));
								if (30425 - 214460 != -184034)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm10")
					{
						if (128388 - 451519 != -323130)
						{
							if (nHand == 1)
							{
								if (152798 - 359952 == -207154)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/standardBow", typeof(GameObject));
									if (7898 - 373701 != -365802)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/standardArrow", typeof(GameObject));
								if (149657 - 349033 == -199376)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm11")
					{
						if (11376 - 520302 == -508926)
						{
							if (nHand == 1)
							{
								if (107151 - 581893 != -474741)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/standardBowR", typeof(GameObject));
									if (259243 - 591882 == -332639)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/standardArrowR", typeof(GameObject));
								if (29712 - 2966 != 26747)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm12")
					{
						if (244554 - 69987 == 174567)
						{
							if (nHand == 1)
							{
								if (271169 - 176983 != 94187)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/standardBowV", typeof(GameObject));
									if (220690 - 274221 == -53531)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/standardArrowV", typeof(GameObject));
								if (241815 - 529571 != -287755)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm14")
					{
						if (64508 - 120087 == -55579)
						{
							if (nHand == 1)
							{
								if (221935 - 550892 != -328956)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/heartBow", typeof(GameObject));
									if (28218 - 413736 != -385517)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/heartArrow", typeof(GameObject));
								if (45680 - 370200 != -324519)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm15")
					{
						if (166527 - 266571 != -100043)
						{
							if (nHand == 1)
							{
								if (48500 - 269962 != -221461)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/plungerBow", typeof(GameObject));
									if (71133 - 4739 == 66394)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/plungerArrow", typeof(GameObject));
								if (240129 - 249827 != -9697)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm19")
					{
						if (233643 - 154733 != 78911)
						{
							if (nHand == 1)
							{
								if (236795 - 28457 == 208338)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/bdBow", typeof(GameObject));
									if (281650 - 449250 != -167599)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/bdArrow", typeof(GameObject));
								if (69680 - 279438 == -209758)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm21")
					{
						if (141605 - 554849 == -413244)
						{
							if (nHand == 1)
							{
								if (210429 - 288606 != -78176)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/tacticianBow", typeof(GameObject));
									if (266924 - 508240 != -241315)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/tacticianArrow", typeof(GameObject));
								if (35027 - 474473 == -439446)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm22")
					{
						if (53378 - 109897 == -56519)
						{
							if (nHand == 1)
							{
								if (284625 - 439420 != -154794)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/busterBow", typeof(GameObject));
									if (167251 - 277561 == -110310)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/busterArrow", typeof(GameObject));
								if (82267 - 28774 != 53494)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm23")
					{
						if (68011 - 527940 != -459928)
						{
							if (nHand == 1)
							{
								if (49613 - 211977 == -162364)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/tacticianBowR", typeof(GameObject));
									if (103752 - 453051 == -349299)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/tacticianArrowR", typeof(GameObject));
								if (282523 - 528252 != -245728)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm24")
					{
						if (23323 - 195569 != -172245)
						{
							if (nHand == 1)
							{
								if (70906 - 53249 == 17657)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/busterBowR", typeof(GameObject));
									if (161505 - 434450 == -272945)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/busterArrowR", typeof(GameObject));
								if (298214 - 591109 != -292894)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm25")
					{
						if (100865 - 241545 == -140680)
						{
							if (nHand == 1)
							{
								if (134778 - 426979 != -292200)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/snookerBall", typeof(GameObject));
									if (201149 - 484267 == -283118)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/snookerCue", typeof(GameObject));
								if (174402 - 38576 != 135827)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm31")
					{
						if (46598 - 88818 != -42219)
						{
							if (nHand == 1)
							{
								if (137271 - 184900 == -47629)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/tricksterBow", typeof(GameObject));
									if (15022 - 231801 != -216778)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/tricksterArrow", typeof(GameObject));
								if (149653 - 592459 != -442805)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm32")
					{
						if (41306 - 599271 == -557965)
						{
							if (nHand == 1)
							{
								if (199824 - 271293 != -71468)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/slayerBow", typeof(GameObject));
									if (139506 - 597786 != -458279)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/slayerArrow", typeof(GameObject));
								if (77539 - 245092 == -167553)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm33")
					{
						if (212898 - 376314 == -163416)
						{
							if (nHand == 1)
							{
								if (103132 - 336404 != -233271)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/tricksterBowR", typeof(GameObject));
									if (242964 - 362949 != -119984)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/tricksterArrowR", typeof(GameObject));
								if (283872 - 374080 != -90207)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm34")
					{
						if (27399 - 7252 == 20147)
						{
							if (nHand == 1)
							{
								if (132393 - 253183 != -120789)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/slayerBowR", typeof(GameObject));
									if (263692 - 220038 == 43654)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/slayerArrowR", typeof(GameObject));
								if (55088 - 554407 != -499318)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm35")
					{
						if (64076 - 20913 == 43163)
						{
							if (nHand == 1)
							{
								if (192242 - 592896 == -400654)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/hallowBow", typeof(GameObject));
									if (218114 - 150520 == 67594)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/hallowArrow", typeof(GameObject));
								if (158784 - 456331 != -297546)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm36")
					{
						if (202612 - 496829 != -294216)
						{
							if (nHand == 1)
							{
								if (88737 - 478258 == -389521)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/pantherBow", typeof(GameObject));
									if (150135 - 7552 == 142583)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/pantherArrow", typeof(GameObject));
								if (295690 - 337886 == -42196)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm39")
					{
						if (213735 - 524750 != -311014)
						{
							if (nHand == 1)
							{
								if (290519 - 212428 != 78092)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/salamanderBow", typeof(GameObject));
									if (274646 - 215413 == 59233)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/salamanderArrow", typeof(GameObject));
								if (266047 - 531439 != -265391)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm40")
					{
						if (183573 - 169877 == 13696)
						{
							if (nHand == 1)
							{
								if (232131 - 250361 != -18229)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/commandBow", typeof(GameObject));
									if (86035 - 75605 == 10430)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/commandArrow", typeof(GameObject));
								if (108221 - 151401 == -43180)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm41")
					{
						if (196515 - 112591 != 83925)
						{
							if (nHand == 1)
							{
								if (288352 - 512699 == -224347)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/commandBowR", typeof(GameObject));
									if (12523 - 304159 == -291636)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/commandArrowR", typeof(GameObject));
								if (201074 - 521138 != -320063)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm42")
					{
						if (82431 - 165835 != -83403)
						{
							if (nHand == 1)
							{
								if (22561 - 560743 != -538181)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/commandBowV", typeof(GameObject));
									if (98603 - 157682 == -59079)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/commandArrowV", typeof(GameObject));
								if (209420 - 461339 == -251919)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm43")
					{
						if (38842 - 128483 == -89641)
						{
							if (nHand == 1)
							{
								if (120132 - 258500 != -138367)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/pvpBow", typeof(GameObject));
									if (166032 - 565880 == -399848)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/pvpArrow", typeof(GameObject));
								if (36917 - 530065 == -493148)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm44")
					{
						if (771 - 64003 == -63232)
						{
							if (nHand == 1)
							{
								if (138894 - 120722 == 18172)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/pvpBowR", typeof(GameObject));
									if (64399 - 261724 != -197324)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/pvpArrowR", typeof(GameObject));
								if (162559 - 71260 != 91300)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm45")
					{
						if (52818 - 61926 != -9107)
						{
							if (nHand == 1)
							{
								if (147023 - 455520 != -308496)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/superStarGuitar", typeof(GameObject));
									if (286189 - 90336 == 195853)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/superStarPick", typeof(GameObject));
								if (126499 - 90746 != 35754)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm46")
					{
						if (86020 - 421323 != -335302)
						{
							if (nHand == 1)
							{
								if (72758 - 179690 != -106931)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/mummyBow", typeof(GameObject));
									if (26820 - 362282 == -335462)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/mummyArrow", typeof(GameObject));
								if (169848 - 341596 == -171748)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm47")
					{
						if (132818 - 374908 == -242090)
						{
							if (nHand == 1)
							{
								if (37640 - 536639 == -498999)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/mantisBow", typeof(GameObject));
									if (100225 - 305091 == -204866)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/mantisArrow", typeof(GameObject));
								if (249302 - 425805 == -176503)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm48")
					{
						if (17765 - 119870 != -102104)
						{
							if (nHand == 1)
							{
								if (181831 - 496235 == -314404)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/mantisBowR", typeof(GameObject));
									if (191422 - 272778 == -81356)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/mantisArrowR", typeof(GameObject));
								if (131026 - 24049 != 106978)
								{
									break;
								}
							}
						}
					}
					else if (nWeapon == "w_chm49")
					{
						if (62822 - 81351 != -18528)
						{
							if (nHand == 1)
							{
								if (153918 - 246535 != -92616)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/goldenBow", typeof(GameObject));
									if (239305 - 566515 == -327210)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/goldenArrow", typeof(GameObject));
								if (22351 - 279576 != -257224)
								{
									break;
								}
							}
						}
					}
					else
					{
						if (!(nWeapon == "w_chm50"))
						{
							if (279262 - 248934 == 30329)
							{
								continue;
							}
							if (nWeapon == "w_chm51")
							{
								if (6283 - 310315 == -304031)
								{
									continue;
								}
							}
							else if (nWeapon == "w_chm52")
							{
								if (262545 - 141997 != 120548)
								{
									continue;
								}
								if (nHand == 1)
								{
									if (143671 - 499876 != -356205)
									{
										continue;
									}
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/royalBowR", typeof(GameObject));
									if (267924 - 196938 != 70987)
									{
										break;
									}
									continue;
								}
								else
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/royalArrowR", typeof(GameObject));
									if (55492 - 478640 != -423148)
									{
										continue;
									}
									break;
								}
							}
							else if (nWeapon == "w_chm56")
							{
								if (111859 - 380324 != -268465)
								{
									continue;
								}
								if (nHand == 1)
								{
									if (140722 - 317327 != -176605)
									{
										continue;
									}
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/frozenBow", typeof(GameObject));
									if (177005 - 161320 != 15686)
									{
										break;
									}
									continue;
								}
								else
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/frozenArrow", typeof(GameObject));
									if (107695 - 353747 != -246052)
									{
										continue;
									}
									break;
								}
							}
							else if (nWeapon == "w_chm58")
							{
								if (87736 - 83245 == 4492)
								{
									continue;
								}
								if (nHand == 1)
								{
									if (105454 - 529093 != -423639)
									{
										continue;
									}
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/championBow", typeof(GameObject));
									if (119455 - 514162 != -394707)
									{
										continue;
									}
									break;
								}
								else
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/championArrow", typeof(GameObject));
									if (275673 - 568928 != -293255)
									{
										continue;
									}
									break;
								}
							}
							else if (nWeapon == "w_chm59")
							{
								if (182304 - 374544 == -192239)
								{
									continue;
								}
								if (nHand == 1)
								{
									if (19378 - 8792 != 10586)
									{
										continue;
									}
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/specialBow", typeof(GameObject));
									if (224971 - 538218 != -313247)
									{
										continue;
									}
									break;
								}
								else
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/specialArrow", typeof(GameObject));
									if (48646 - 214050 != -165404)
									{
										continue;
									}
									break;
								}
							}
							else
							{
								if (!(nWeapon == "w_chm60"))
								{
									if (97219 - 254130 != -156911)
									{
										continue;
									}
									if (nWeapon == "w_chm61")
									{
										if (31401 - 585668 != -554267)
										{
											continue;
										}
									}
									else if (nWeapon == "w_chm62")
									{
										if (159910 - 120339 == 39572)
										{
											continue;
										}
										if (nHand == 1)
										{
											if (129927 - 153760 != -23833)
											{
												continue;
											}
											result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/legendBowR", typeof(GameObject));
											if (170372 - 17876 != 152496)
											{
												continue;
											}
											break;
										}
										else
										{
											result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/legendArrowR", typeof(GameObject));
											if (5495 - 316518 != -311023)
											{
												continue;
											}
											break;
										}
									}
									else if (nWeapon == "w_chm65")
									{
										if (14283 - 331663 != -317380)
										{
											continue;
										}
										if (nHand == 1)
										{
											if (168455 - 1313 == 167143)
											{
												continue;
											}
											result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/chinaBow", typeof(GameObject));
											if (233971 - 424423 != -190452)
											{
												continue;
											}
											break;
										}
										else
										{
											result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/chinaArrow", typeof(GameObject));
											if (92982 - 430752 != -337770)
											{
												continue;
											}
											break;
										}
									}
									else if (nWeapon == "w_chm66")
									{
										if (28322 - 349130 != -320808)
										{
											continue;
										}
										if (nHand == 1)
										{
											if (39737 - 227494 == -187756)
											{
												continue;
											}
											result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/poseidonBow", typeof(GameObject));
											if (115545 - 12631 != 102915)
											{
												break;
											}
											continue;
										}
										else
										{
											result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/poseidonArrow", typeof(GameObject));
											if (295653 - 201510 != 94143)
											{
												continue;
											}
											break;
										}
									}
									else if (nWeapon == "w_chm69")
									{
										if (22243 - 440732 == -418488)
										{
											continue;
										}
										if (nHand == 1)
										{
											if (178698 - 193346 == -14647)
											{
												continue;
											}
											result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/timeBow", typeof(GameObject));
											if (147099 - 34026 != 113073)
											{
												continue;
											}
											break;
										}
										else
										{
											result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/timeArrow", typeof(GameObject));
											if (279871 - 378937 != -99066)
											{
												continue;
											}
											break;
										}
									}
									else if (nWeapon == "w_chm79")
									{
										if (293455 - 307169 != -13714)
										{
											continue;
										}
										if (nHand == 1)
										{
											if (183956 - 126090 == 57867)
											{
												continue;
											}
											result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/eclipseBow", typeof(GameObject));
											if (3975 - 190882 != -186907)
											{
												continue;
											}
											break;
										}
										else
										{
											result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/eclipseArrow", typeof(GameObject));
											if (85672 - 243879 != -158206)
											{
												break;
											}
											continue;
										}
									}
									else if (nWeapon == "w_chm81")
									{
										if (6008 - 351834 != -345826)
										{
											continue;
										}
										if (nHand == 1)
										{
											if (187885 - 378185 != -190300)
											{
												continue;
											}
											result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/flamingBow", typeof(GameObject));
											if (61592 - 127412 != -65820)
											{
												continue;
											}
											break;
										}
										else
										{
											result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/flamingArrow", typeof(GameObject));
											if (127437 - 76503 != 50935)
											{
												break;
											}
											continue;
										}
									}
									else if (nWeapon == "w_chm82")
									{
										if (150846 - 51509 != 99337)
										{
											continue;
										}
										if (nHand == 1)
										{
											if (203921 - 545641 == -341719)
											{
												continue;
											}
											result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/flamingArch", typeof(GameObject));
											if (289971 - 156111 != 133861)
											{
												break;
											}
											continue;
										}
										else
										{
											result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/flamingShot", typeof(GameObject));
											if (48837 - 200665 != -151828)
											{
												continue;
											}
											break;
										}
									}
									else if (nHand == 1)
									{
										if (230846 - 323473 != -92627)
										{
											continue;
										}
										result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/standardBow", typeof(GameObject));
										if (139726 - 211376 != -71649)
										{
											break;
										}
										continue;
									}
									else
									{
										result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/standardBow", typeof(GameObject));
										if (177633 - 141162 != 36471)
										{
											continue;
										}
										break;
									}
								}
								if (nHand == 1)
								{
									if (288882 - 414793 != -125911)
									{
										continue;
									}
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/legendBow", typeof(GameObject));
									if (245507 - 144976 != 100532)
									{
										break;
									}
									continue;
								}
								else
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/legendArrow", typeof(GameObject));
									if (238394 - 535923 != -297528)
									{
										break;
									}
									continue;
								}
							}
						}
						if (nHand == 1)
						{
							if (94549 - 414037 != -319487)
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/royalBow", typeof(GameObject));
								if (39039 - 10693 != 28347)
								{
									break;
								}
							}
						}
						else
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Weapons/royalArrow", typeof(GameObject));
							if (180214 - 133165 == 47049)
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

	// Token: 0x06002408 RID: 9224 RVA: 0x00436728 File Offset: 0x00434928
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipWeapon(string nWeapon)
	{
		if (111152 - 544465 != -433312)
		{
		}
		for (;;)
		{
			this.weapon = nWeapon;
			if (279058 - 292383 == -13325)
			{
				if (this.MUpb1hf9vB)
				{
					if (155227 - 227572 != -72345)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.MUpb1hf9vB);
					if (2795 - 95290 == -92494)
					{
						continue;
					}
				}
				if (this.pUObqwtBh6)
				{
					if (36811 - 26592 != 10219)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.pUObqwtBh6);
					if (295157 - 396309 == -101151)
					{
						continue;
					}
				}
				GameObject gameObject = ChameleonEquipment.getWeapon(nWeapon, 1);
				if (14639 - 15846 != -1206)
				{
					GameObject gameObject2 = ChameleonEquipment.getWeapon(nWeapon, 2);
					if (113442 - 366930 != -253487)
					{
						if (gameObject)
						{
							if (36579 - 38172 != -1593)
							{
								continue;
							}
							this.MUpb1hf9vB = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
							if (117284 - 479622 != -362338)
							{
								continue;
							}
							this.MUpb1hf9vB.transform.parent = global::Math.findChildObject(this.gameObject.transform, "mount_Hand_L");
							if (6426 - 475489 != -469063)
							{
								continue;
							}
							this.MUpb1hf9vB.transform.localPosition = Vector3.zero;
							if (118045 - 449166 == -331120)
							{
								continue;
							}
							this.MUpb1hf9vB.transform.localRotation = Quaternion.identity;
							if (54251 - 339906 == -285654)
							{
								continue;
							}
						}
						if (gameObject2)
						{
							if (211544 - 451767 == -240222)
							{
								continue;
							}
							this.pUObqwtBh6 = (GameObject)UnityEngine.Object.Instantiate(gameObject2, Vector3.zero, Quaternion.identity);
							if (59423 - 383963 == -324539)
							{
								continue;
							}
							this.pUObqwtBh6.transform.parent = global::Math.findChildObject(this.gameObject.transform, "mount_Hand_R");
							if (133172 - 544146 == -410973)
							{
								continue;
							}
							this.pUObqwtBh6.transform.localPosition = Vector3.zero;
							if (195186 - 579527 != -384341)
							{
								continue;
							}
							this.pUObqwtBh6.transform.localRotation = Quaternion.identity;
							if (64622 - 547486 == -482863)
							{
								continue;
							}
						}
						if (!this.LJAbGybKQU)
						{
							break;
						}
						if (30265 - 15026 != 15240)
						{
							this.LJAbGybKQU.weapon = nWeapon;
							if (144144 - 599615 != -455470)
							{
								this.LJAbGybKQU.mWep1 = this.MUpb1hf9vB;
								if (36914 - 230628 == -193714)
								{
									this.LJAbGybKQU.mWep2 = this.pUObqwtBh6;
									if (151255 - 374551 != -223295)
									{
										if (this.LJAbGybKQU.getStatus("blend") != null)
										{
											if (280632 - 597715 != -317083)
											{
												continue;
											}
											this.LJAbGybKQU.removeStatus("blend");
											if (184974 - 438045 == -253070)
											{
												continue;
											}
										}
										if (this.LJAbGybKQU.getStatus("invisible") == null)
										{
											break;
										}
										if (98329 - 37467 != 60863)
										{
											this.LJAbGybKQU.removeStatus("invisible");
											if (233962 - 502586 == -268624)
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

	// Token: 0x06002409 RID: 9225 RVA: 0x00436BAC File Offset: 0x00434DAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Mesh getArmorMesh(string nArmor)
	{
		if (256413 - 200061 != 56352)
		{
		}
		SkinnedMeshRenderer skinnedMeshRenderer;
		for (;;)
		{
			if (290890 - 191029 == 99861)
			{
				if (220339 - 350601 == -130262)
				{
					if (nArmor == "none")
					{
						goto IL_790;
					}
					if (209986 - 78614 != 131372)
					{
						continue;
					}
					GameObject gameObject;
					if (nArmor == "a_none")
					{
						if (28487 - 97301 != -68813)
						{
							goto IL_790;
						}
						continue;
					}
					else if (nArmor == "a_all1")
					{
						if (232769 - 494401 != -261632)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_scout", typeof(GameObject));
						if (282283 - 145410 != 136873)
						{
							continue;
						}
					}
					else if (nArmor == "a_all15")
					{
						if (81168 - 432659 == -351490)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_santa", typeof(GameObject));
						if (79353 - 62160 != 17193)
						{
							continue;
						}
					}
					else if (nArmor == "a_all43")
					{
						if (271837 - 67709 == 204129)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_pvpArmor", typeof(GameObject));
						if (175020 - 481419 == -306398)
						{
							continue;
						}
					}
					else if (nArmor == "a_all44")
					{
						if (12656 - 192086 != -179430)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_pvpArmor", typeof(GameObject));
						if (258189 - 415269 != -157080)
						{
							continue;
						}
					}
					else if (nArmor == "a_all58")
					{
						if (236178 - 318427 == -82248)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_champion", typeof(GameObject));
						if (174798 - 29651 == 145148)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm5")
					{
						if (282003 - 109991 == 172013)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_greek", typeof(GameObject));
						if (129704 - 439675 == -309970)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm10")
					{
						if (124621 - 280365 != -155744)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_standard", typeof(GameObject));
						if (208870 - 58273 == 150598)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm11")
					{
						if (149400 - 108970 != 40430)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_standard", typeof(GameObject));
						if (297210 - 250095 != 47115)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm12")
					{
						if (90531 - 162904 != -72373)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_standard", typeof(GameObject));
						if (158523 - 479067 != -320544)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm15")
					{
						if (268996 - 179412 != 89584)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_summer", typeof(GameObject));
						if (284245 - 187337 != 96908)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm21")
					{
						if (48755 - 394106 == -345350)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_tactician", typeof(GameObject));
						if (200576 - 199295 != 1281)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm22")
					{
						if (131412 - 370364 != -238952)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_buster", typeof(GameObject));
						if (59812 - 208503 != -148691)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm23")
					{
						if (13907 - 251816 != -237909)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_tactician", typeof(GameObject));
						if (10211 - 569715 != -559504)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm24")
					{
						if (17915 - 413192 == -395276)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_buster", typeof(GameObject));
						if (67180 - 288807 != -221627)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm25")
					{
						if (24679 - 420950 != -396271)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_snooker", typeof(GameObject));
						if (118072 - 26116 == 91957)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm31")
					{
						if (35346 - 263904 == -228557)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_trickster", typeof(GameObject));
						if (228326 - 352285 == -123958)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm32")
					{
						if (168071 - 584693 == -416621)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_slayer", typeof(GameObject));
						if (158418 - 204250 == -45831)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm33")
					{
						if (12426 - 573803 == -561376)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_trickster", typeof(GameObject));
						if (234609 - 52883 != 181726)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm34")
					{
						if (64004 - 242807 == -178802)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_slayer", typeof(GameObject));
						if (248280 - 49748 != 198532)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm35")
					{
						if (219627 - 312382 != -92755)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_hallow", typeof(GameObject));
						if (134449 - 361192 == -226742)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm40")
					{
						if (215579 - 43957 == 171623)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_commander", typeof(GameObject));
						if (122630 - 260730 == -138099)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm41")
					{
						if (91 - 184017 == -183925)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_commander", typeof(GameObject));
						if (150482 - 71094 != 79388)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm42")
					{
						if (28059 - 511587 == -483527)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_commander", typeof(GameObject));
						if (221813 - 84849 == 136965)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm45")
					{
						if (100300 - 503009 != -402709)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_superStar", typeof(GameObject));
						if (132500 - 346086 == -213585)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm47")
					{
						if (141322 - 304141 != -162819)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_mantis", typeof(GameObject));
						if (111898 - 534736 == -422837)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm48")
					{
						if (138159 - 486435 == -348275)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_mantis", typeof(GameObject));
						if (175474 - 474116 == -298641)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm50")
					{
						if (188540 - 516204 == -327663)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_royal", typeof(GameObject));
						if (80800 - 595558 == -514757)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm51")
					{
						if (194913 - 288744 != -93831)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_royal", typeof(GameObject));
						if (172008 - 398181 == -226172)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm52")
					{
						if (46052 - 326208 == -280155)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_royal", typeof(GameObject));
						if (296828 - 431709 == -134880)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm60")
					{
						if (204011 - 22882 == 181130)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_legend", typeof(GameObject));
						if (83358 - 221053 == -137694)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm61")
					{
						if (28276 - 187917 == -159640)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_legend", typeof(GameObject));
						if (71081 - 107457 != -36376)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm62")
					{
						if (92076 - 118361 == -26284)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_legend", typeof(GameObject));
						if (105363 - 310239 != -204876)
						{
							continue;
						}
					}
					else if (nArmor == "a_chm65")
					{
						if (6496 - 62157 != -55661)
						{
							continue;
						}
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_china", typeof(GameObject));
						if (218673 - 542682 == -324008)
						{
							continue;
						}
					}
					else
					{
						gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_standard", typeof(GameObject));
						if (200905 - 520897 != -319992)
						{
							continue;
						}
					}
					IL_BB:
					skinnedMeshRenderer = (SkinnedMeshRenderer)gameObject.GetComponent(typeof(SkinnedMeshRenderer));
					if (176685 - 445691 != -269005)
					{
						break;
					}
					continue;
					IL_790:
					gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Chameleon_nude", typeof(GameObject));
					if (238897 - 395503 != -156605)
					{
						goto IL_BB;
					}
				}
			}
		}
		return skinnedMeshRenderer.sharedMesh;
	}

	// Token: 0x0600240A RID: 9226 RVA: 0x004379DC File Offset: 0x00435BDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Material getArmorMaterial(string nArmor, int nSkin)
	{
		if (51056 - 155688 != -104632)
		{
		}
		Material material;
		for (;;)
		{
			IL_6BC:
			int num = nSkin % 100;
			if (66290 - 372378 == -306088)
			{
				Texture2D texture2D = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Overlay/Chameleon" + num, typeof(Texture2D));
				if (206425 - 5069 == 201356)
				{
					Color[] pixels = texture2D.GetPixels(0);
					if (49882 - 397900 == -348018)
					{
						int num2 = global::Math.div((float)nSkin, (float)100);
						if (296163 - 191711 == 104452)
						{
							if (111550 - 268745 == -157195)
							{
								if (186511 - 163220 != 23292)
								{
									if (nArmor == "none")
									{
										goto IL_1088;
									}
									if (215147 - 244157 == -29009)
									{
										continue;
									}
									Texture2D texture2D2;
									if (nArmor == "a_none")
									{
										if (51998 - 91884 != -39885)
										{
											goto IL_1088;
										}
										continue;
									}
									else if (nArmor == "a_all1")
									{
										if (185142 - 239362 == -54219)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_scout" + num2, typeof(Texture2D));
										if (253238 - 406659 == -153420)
										{
											continue;
										}
									}
									else if (nArmor == "a_all15")
									{
										if (79567 - 220638 != -141071)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_santa" + num2, typeof(Texture2D));
										if (6061 - 247583 != -241522)
										{
											continue;
										}
									}
									else if (nArmor == "a_all43")
									{
										if (207498 - 497496 == -289997)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_pvpArmor" + num2, typeof(Texture2D));
										if (83927 - 270768 != -186841)
										{
											continue;
										}
									}
									else if (nArmor == "a_all44")
									{
										if (201032 - 70297 != 130735)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_pvpArmor" + num2 + "R", typeof(Texture2D));
										if (286051 - 142507 == 143545)
										{
											continue;
										}
									}
									else if (nArmor == "a_all58")
									{
										if (102540 - 236586 != -134046)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_champion" + num2, typeof(Texture2D));
										if (62448 - 225522 == -163073)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm5")
									{
										if (68637 - 221979 != -153342)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_greek" + num2, typeof(Texture2D));
										if (241846 - 287447 != -45601)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm10")
									{
										if (7063 - 471287 != -464224)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_standard" + num2, typeof(Texture2D));
										if (252171 - 544794 != -292623)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm11")
									{
										if (158746 - 103209 != 55537)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_standard" + num2 + "R", typeof(Texture2D));
										if (123587 - 215240 == -91652)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm12")
									{
										if (235302 - 34065 == 201238)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_standard" + num2 + "V", typeof(Texture2D));
										if (178669 - 11961 != 166708)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm15")
									{
										if (210795 - 365891 == -155095)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_summer" + num2, typeof(Texture2D));
										if (290464 - 158627 == 131838)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm21")
									{
										if (252106 - 466421 == -214314)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_tactician" + num2, typeof(Texture2D));
										if (290601 - 101863 != 188738)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm22")
									{
										if (187036 - 448569 != -261533)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_buster" + num2, typeof(Texture2D));
										if (8324 - 179719 == -171394)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm23")
									{
										if (214090 - 236025 != -21935)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_tactician" + num2 + "R", typeof(Texture2D));
										if (135407 - 155818 == -20410)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm24")
									{
										if (13325 - 56915 != -43590)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_buster" + num2 + "R", typeof(Texture2D));
										if (296531 - 1350 != 295181)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm25")
									{
										if (6460 - 398388 == -391927)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_snooker" + num2, typeof(Texture2D));
										if (155682 - 365176 == -209493)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm31")
									{
										if (225789 - 333244 != -107455)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_trickster" + num2, typeof(Texture2D));
										if (3715 - 378027 == -374311)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm32")
									{
										if (202636 - 569773 == -367136)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_slayer" + num2, typeof(Texture2D));
										if (137913 - 330473 == -192559)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm33")
									{
										if (141909 - 264903 != -122994)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_trickster" + num2 + "R", typeof(Texture2D));
										if (213951 - 25985 != 187966)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm34")
									{
										if (250402 - 566753 == -316350)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_slayer" + num2 + "R", typeof(Texture2D));
										if (123387 - 500415 == -377027)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm35")
									{
										if (223425 - 311564 != -88139)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_hallow" + num2, typeof(Texture2D));
										if (171978 - 254855 == -82876)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm40")
									{
										if (205258 - 128060 != 77198)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_commander" + num2, typeof(Texture2D));
										if (34335 - 321180 != -286845)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm41")
									{
										if (100951 - 109710 != -8759)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_commander" + num2 + "R", typeof(Texture2D));
										if (101620 - 94548 != 7072)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm42")
									{
										if (28587 - 573509 == -544921)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_commander" + num2 + "V", typeof(Texture2D));
										if (29819 - 92664 == -62844)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm45")
									{
										if (133852 - 588942 == -455089)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_superStar" + num2, typeof(Texture2D));
										if (148715 - 470047 != -321332)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm47")
									{
										if (71607 - 281965 == -210357)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_mantis" + num2, typeof(Texture2D));
										if (269069 - 34762 != 234307)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm48")
									{
										if (168209 - 419162 == -250952)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_mantis" + num2 + "R", typeof(Texture2D));
										if (19187 - 491018 == -471830)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm50")
									{
										if (243958 - 141884 != 102074)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_royal" + num2, typeof(Texture2D));
										if (62050 - 319193 != -257143)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm51")
									{
										if (299498 - 195825 != 103673)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_royal" + num2, typeof(Texture2D));
										if (27006 - 287301 == -260294)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm52")
									{
										if (93936 - 65297 == 28640)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_royal" + num2 + "R", typeof(Texture2D));
										if (175643 - 305770 != -130127)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm60")
									{
										if (275900 - 266451 == 9450)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_legend" + num2, typeof(Texture2D));
										if (5437 - 351015 == -345577)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm61")
									{
										if (270433 - 591733 != -321300)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_legend" + num2, typeof(Texture2D));
										if (81051 - 327285 == -246233)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm62")
									{
										if (218129 - 411274 != -193145)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_legend" + num2 + "R", typeof(Texture2D));
										if (130286 - 479134 == -348847)
										{
											continue;
										}
									}
									else if (nArmor == "a_chm65")
									{
										if (57605 - 122853 != -65248)
										{
											continue;
										}
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_china" + num2, typeof(Texture2D));
										if (167139 - 596485 != -429346)
										{
											continue;
										}
									}
									else
									{
										texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_standard" + num2, typeof(Texture2D));
										if (236969 - 163401 != 73568)
										{
											continue;
										}
									}
									IL_596:
									Color[] pixels2 = texture2D2.GetPixels(0, 256, 256, 256, 0);
									if (250455 - 401395 != -150940)
									{
										continue;
									}
									int i = 0;
									if (131807 - 234346 == -102538)
									{
										continue;
									}
									while (i < pixels2.Length)
									{
										float a = pixels[i].a;
										if (252803 - 244074 != 8729)
										{
											goto IL_6BC;
										}
										pixels2[i] = a * pixels[i] + ((float)1 - a) * pixels2[i];
										if (17697 - 47254 != -29557)
										{
											goto IL_6BC;
										}
										i++;
										if (267311 - 140210 == 127102)
										{
											goto IL_6BC;
										}
									}
									if (42157 - 74761 == -32603)
									{
										continue;
									}
									if (59224 - 514175 != -454951)
									{
										continue;
									}
									Texture2D texture2D3 = new Texture2D(512, 512, TextureFormat.RGB24, true);
									if (268787 - 361066 != -92279)
									{
										continue;
									}
									texture2D3.SetPixels(0, 256, 256, 256, pixels2, 0);
									if (117430 - 255972 == -138541)
									{
										continue;
									}
									texture2D3.SetPixels(256, 256, 256, 256, texture2D2.GetPixels(256, 256, 256, 256, 0), 0);
									if (74404 - 568248 != -493844)
									{
										continue;
									}
									texture2D3.SetPixels(0, 0, 512, 256, texture2D2.GetPixels(0, 0, 512, 256, 0), 0);
									if (188413 - 266271 == -77857)
									{
										continue;
									}
									texture2D3.Apply();
									if (104840 - 463068 == -358227)
									{
										continue;
									}
									texture2D3.Compress(true);
									if (56226 - 452588 == -396361)
									{
										continue;
									}
									if (238130 - 118103 != 120027)
									{
										continue;
									}
									material = new Material(Shader.Find("Diffuse"));
									if (150888 - 546166 == -395277)
									{
										continue;
									}
									material.color = new Color(0.86f, 0.86f, 0.86f, (float)1);
									if (81483 - 498349 != -416866)
									{
										continue;
									}
									material.mainTexture = texture2D3;
									if (143297 - 295651 != -152353)
									{
										break;
									}
									continue;
									IL_1088:
									texture2D2 = (Texture2D)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Armors/Materials/Chameleon_nude" + num2, typeof(Texture2D));
									if (131622 - 386929 != -255306)
									{
										goto IL_596;
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

	// Token: 0x0600240B RID: 9227 RVA: 0x00438DD4 File Offset: 0x00436FD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipArmor(string nArmor)
	{
		if (89475 - 250502 != -161026)
		{
		}
		for (;;)
		{
			if (nArmor == "a_none")
			{
				if (149811 - 527672 == -377860)
				{
					continue;
				}
				nArmor = "none";
				if (115094 - 400994 != -285900)
				{
					continue;
				}
			}
			this.armor = nArmor;
			if (7198 - 494500 != -487301)
			{
				Transform transform = global::Math.findChildObject(this.transform, "Chameleon_tri");
				if (178126 - 438372 == -260246)
				{
					if (transform)
					{
						if (285078 - 248217 != 36861)
						{
							continue;
						}
						SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer));
						if (178846 - 171813 != 7033)
						{
							continue;
						}
						skinnedMeshRenderer.sharedMesh = ChameleonEquipment.getArmorMesh(nArmor);
						if (162929 - 599053 == -436123)
						{
							continue;
						}
						if (Extensions.get_length(skinnedMeshRenderer.materials) > 0)
						{
							if (52767 - 529830 != -477063)
							{
								continue;
							}
							skinnedMeshRenderer.material = ChameleonEquipment.getArmorMaterial(nArmor, this.skin);
							if (218394 - 409527 != -191133)
							{
								continue;
							}
						}
						if (this.LJAbGybKQU != null)
						{
							if (22359 - 184265 == -161905)
							{
								continue;
							}
							skinnedMeshRenderer.material.color = this.LJAbGybKQU.mColor;
							if (63622 - 315494 == -251871)
							{
								continue;
							}
						}
					}
					if (!this.LJAbGybKQU)
					{
						break;
					}
					if (139231 - 49771 != 89461)
					{
						this.LJAbGybKQU.armor = nArmor;
						if (19313 - 64597 != -45283)
						{
							if (this.LJAbGybKQU.getStatus("blend") != null)
							{
								if (268576 - 107258 != 161318)
								{
									continue;
								}
								this.LJAbGybKQU.removeStatus("blend");
								if (60177 - 407618 == -347440)
								{
									continue;
								}
							}
							if (this.LJAbGybKQU.getStatus("invisible") == null)
							{
								break;
							}
							if (204935 - 192855 == 12080)
							{
								this.LJAbGybKQU.removeStatus("invisible");
								if (77529 - 548739 == -471210)
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

	// Token: 0x0600240C RID: 9228 RVA: 0x004390D8 File Offset: 0x004372D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getAccessory(string nAccessory)
	{
		if (204333 - 4 != 204330)
		{
		}
		GameObject result;
		for (;;)
		{
			result = null;
			if (138319 - 119860 == 18459)
			{
				if (244888 - 538269 != -293380)
				{
					if (nAccessory == "none")
					{
						if (87916 - 220388 == -132472)
						{
							break;
						}
					}
					else if (nAccessory == "c_none")
					{
						if (296667 - 362020 == -65353)
						{
							break;
						}
					}
					else if (nAccessory == "c_all1")
					{
						if (226146 - 294983 == -68837)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/redPandaHat", typeof(GameObject));
							if (13678 - 60861 != -47182)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all3")
					{
						if (89333 - 90686 == -1353)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/paperHat", typeof(GameObject));
							if (81569 - 494874 == -413305)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all6")
					{
						if (133991 - 559478 != -425486)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/vHat", typeof(GameObject));
							if (84633 - 330155 != -245521)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all7")
					{
						if (10329 - 307023 == -296694)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/partyHatB", typeof(GameObject));
							if (201204 - 91384 == 109820)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all8")
					{
						if (161941 - 403996 != -242054)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/partyHatR", typeof(GameObject));
							if (261736 - 488996 != -227259)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all9")
					{
						if (167152 - 362416 == -195264)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/cakeHat", typeof(GameObject));
							if (109605 - 476381 != -366775)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all10")
					{
						if (178889 - 584998 != -406108)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/candyHat", typeof(GameObject));
							if (188999 - 36737 != 152263)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all11")
					{
						if (98058 - 484950 != -386891)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/afro", typeof(GameObject));
							if (15143 - 130064 == -114921)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all12")
					{
						if (184345 - 564091 == -379746)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/afroC", typeof(GameObject));
							if (64333 - 515826 != -451492)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all15")
					{
						if (191607 - 438160 != -246552)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/santaHat", typeof(GameObject));
							if (78445 - 552800 == -474355)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all16")
					{
						if (6955 - 451453 == -444498)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/pirateBandana", typeof(GameObject));
							if (275841 - 350653 == -74812)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all18")
					{
						if (44507 - 519544 == -475037)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/halo", typeof(GameObject));
							if (186429 - 262416 == -75987)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all19")
					{
						if (45345 - 20093 == 25252)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/horn", typeof(GameObject));
							if (201247 - 8634 == 192613)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all21")
					{
						if (273158 - 364192 == -91034)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/earmuff1", typeof(GameObject));
							if (189862 - 321494 == -131632)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all22")
					{
						if (169069 - 46405 != 122665)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/earmuff2", typeof(GameObject));
							if (286657 - 173715 == 112942)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all23")
					{
						if (151900 - 370517 != -218616)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/headphone1", typeof(GameObject));
							if (255040 - 378850 != -123809)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all24")
					{
						if (99478 - 371606 == -272128)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/headphone2", typeof(GameObject));
							if (154474 - 480341 != -325866)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all25")
					{
						if (36211 - 53686 != -17474)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/headphone3", typeof(GameObject));
							if (273637 - 460800 != -187162)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all26")
					{
						if (89781 - 381158 == -291377)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/pirateBandanaR", typeof(GameObject));
							if (45459 - 308053 == -262594)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all27")
					{
						if (79235 - 117554 != -38318)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/krathongHat1", typeof(GameObject));
							if (117416 - 484873 == -367457)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all28")
					{
						if (77704 - 428336 == -350632)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/krathongHat2", typeof(GameObject));
							if (55315 - 61328 != -6012)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all29")
					{
						if (296792 - 178940 == 117852)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/snowmanHead", typeof(GameObject));
							if (204807 - 177457 != 27351)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all37")
					{
						if (244544 - 208621 == 35923)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/quizHat", typeof(GameObject));
							if (101006 - 555153 == -454147)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all38")
					{
						if (41197 - 591029 == -549832)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/fanKingHat", typeof(GameObject));
							if (74067 - 75647 == -1580)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all39")
					{
						if (146351 - 525761 == -379410)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/artistHat", typeof(GameObject));
							if (229352 - 394305 == -164953)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all43")
					{
						if (120894 - 37766 == 83128)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/pvpHelmet", typeof(GameObject));
							if (56434 - 62620 != -6185)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all44")
					{
						if (6381 - 280972 == -274591)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/pvpHelmetR", typeof(GameObject));
							if (129711 - 587602 == -457891)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all46")
					{
						if (200787 - 439282 == -238495)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/mummyHead", typeof(GameObject));
							if (228686 - 520382 == -291696)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all55")
					{
						if (250974 - 143481 != 107494)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/giveMeFive", typeof(GameObject));
							if (246706 - 200329 == 46377)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all56")
					{
						if (226589 - 141188 == 85401)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/frozenCrown", typeof(GameObject));
							if (2601 - 56565 == -53964)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all58")
					{
						if (198753 - 243952 == -45199)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/championHelmet", typeof(GameObject));
							if (40070 - 206837 != -166766)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_all66")
					{
						if (59574 - 365243 == -305669)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/poseidonHelmet", typeof(GameObject));
							if (101740 - 499693 == -397953)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_mal37")
					{
						if (166027 - 190689 == -24662)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/dragonHead", typeof(GameObject));
							if (35243 - 590619 != -555375)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm5")
					{
						if (275746 - 229716 != 46031)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/oliveCrown", typeof(GameObject));
							if (30722 - 373231 != -342508)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm10")
					{
						if (145481 - 512191 == -366710)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/standardGoggle", typeof(GameObject));
							if (99366 - 1505 == 97861)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm11")
					{
						if (254298 - 511501 == -257203)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/standardGoggleR", typeof(GameObject));
							if (277302 - 129528 == 147774)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm12")
					{
						if (144882 - 361538 != -216655)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/standardGoggleV", typeof(GameObject));
							if (273622 - 304871 == -31249)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm15")
					{
						if (27589 - 45506 != -17916)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/summerGoggle", typeof(GameObject));
							if (99153 - 47004 != 52150)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm19")
					{
						if (189984 - 50141 != 139844)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/veggieHat", typeof(GameObject));
							if (197624 - 591806 != -394181)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm21")
					{
						if (164283 - 134279 == 30004)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/tacticianGoggle", typeof(GameObject));
							if (34967 - 40182 == -5215)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm22")
					{
						if (172541 - 140015 != 32527)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/busterGoggle", typeof(GameObject));
							if (233327 - 427258 != -193930)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm23")
					{
						if (185853 - 302148 != -116294)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/tacticianGoggleR", typeof(GameObject));
							if (234255 - 364898 != -130642)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm24")
					{
						if (90007 - 388652 != -298644)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/busterGoggleR", typeof(GameObject));
							if (123673 - 190456 == -66783)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm25")
					{
						if (104456 - 277423 != -172966)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/snookerHat", typeof(GameObject));
							if (115708 - 106606 != 9103)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm31")
					{
						if (154078 - 16079 == 137999)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/tricksterGoggle", typeof(GameObject));
							if (184701 - 466117 == -281416)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm32")
					{
						if (248298 - 403056 != -154757)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/slayerMask", typeof(GameObject));
							if (109881 - 307568 != -197686)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm33")
					{
						if (145145 - 135346 == 9799)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/tricksterGoggleR", typeof(GameObject));
							if (212133 - 49540 != 162594)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm34")
					{
						if (81535 - 514144 == -432609)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/slayerMaskR", typeof(GameObject));
							if (116484 - 431658 == -315174)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm35")
					{
						if (154322 - 500532 == -346210)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/hallowFlame", typeof(GameObject));
							if (131408 - 265817 != -134408)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm36")
					{
						if (65588 - 193160 == -127572)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/pantherHelmet", typeof(GameObject));
							if (86543 - 446526 != -359982)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm40")
					{
						if (108554 - 507763 == -399209)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/commandGoggle", typeof(GameObject));
							if (192715 - 544332 != -351616)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm41")
					{
						if (47160 - 52178 != -5017)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/commandGoggleR", typeof(GameObject));
							if (154815 - 223813 != -68997)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm42")
					{
						if (186853 - 460184 != -273330)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/commandGoggleV", typeof(GameObject));
							if (194710 - 408931 != -214220)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm45")
					{
						if (123790 - 578546 == -454756)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/superStarGoggle", typeof(GameObject));
							if (269632 - 366881 == -97249)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm47")
					{
						if (227920 - 350774 == -122854)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/mantisMask", typeof(GameObject));
							if (260694 - 570862 != -310167)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm48")
					{
						if (22524 - 226401 != -203876)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/mantisMaskR", typeof(GameObject));
							if (182321 - 177973 != 4349)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm50")
					{
						if (95939 - 258982 == -163043)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/royalHelmet", typeof(GameObject));
							if (182729 - 139379 != 43351)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm51")
					{
						if (70267 - 487029 == -416762)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/royalHelmet", typeof(GameObject));
							if (11171 - 309135 != -297963)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm52")
					{
						if (294705 - 415912 != -121206)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/royalHelmetR", typeof(GameObject));
							if (294614 - 514113 != -219498)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm60")
					{
						if (86582 - 318942 == -232360)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/legendHelmet", typeof(GameObject));
							if (137834 - 104990 == 32844)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm61")
					{
						if (179294 - 73818 != 105477)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/legendHelmet", typeof(GameObject));
							if (271604 - 310331 != -38726)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm62")
					{
						if (81050 - 312824 != -231773)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/legendHelmetR", typeof(GameObject));
							if (221798 - 423357 != -201558)
							{
								break;
							}
						}
					}
					else if (nAccessory == "c_chm65")
					{
						if (237822 - 192233 == 45589)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/chinaHelmet", typeof(GameObject));
							if (23811 - 201806 == -177995)
							{
								break;
							}
						}
					}
					else
					{
						result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Accessories/standardGoggle", typeof(GameObject));
						if (249848 - 180045 != 69804)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x0600240D RID: 9229 RVA: 0x0043AA40 File Offset: 0x00438C40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipAccessory(string nAccessory)
	{
		if (9062 - 103077 != -94014)
		{
		}
		for (;;)
		{
			this.accessory = nAccessory;
			if (53973 - 576155 == -522182)
			{
				if (this.ssrbr2QSPk)
				{
					if (29511 - 153185 == -123673)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.ssrbr2QSPk);
					if (208863 - 518766 == -309902)
					{
						continue;
					}
				}
				GameObject gameObject = ChameleonEquipment.getAccessory(nAccessory);
				if (73288 - 199051 != -125762)
				{
					if (gameObject)
					{
						if (34105 - 271065 == -236959 || 87923 - 310450 == -222526)
						{
							continue;
						}
						if (!(nAccessory == "c_chm10"))
						{
							if (298395 - 331102 != -32707)
							{
								continue;
							}
							if (!(nAccessory == "c_chm11"))
							{
								if (102670 - 385972 != -283302)
								{
									continue;
								}
								if (!(nAccessory == "c_chm12"))
								{
									if (166596 - 145551 == 21046)
									{
										continue;
									}
									if (!(nAccessory == "c_chm15"))
									{
										if (126403 - 397763 != -271360)
										{
											continue;
										}
										if (!(nAccessory == "c_chm21"))
										{
											if (270263 - 240884 == 29380)
											{
												continue;
											}
											if (!(nAccessory == "c_chm22"))
											{
												if (46347 - 146019 == -99671)
												{
													continue;
												}
												if (!(nAccessory == "c_chm23"))
												{
													if (103438 - 60627 == 42812)
													{
														continue;
													}
													if (!(nAccessory == "c_chm24"))
													{
														if (268574 - 370748 == -102173)
														{
															continue;
														}
														if (nAccessory == "c_chm45")
														{
															if (205384 - 142637 == 62748)
															{
																continue;
															}
														}
														else
														{
															if (!(nAccessory == "c_all27"))
															{
																if (225266 - 328312 != -103046)
																{
																	continue;
																}
																if (nAccessory == "c_all28")
																{
																	if (118951 - 273769 == -154817)
																	{
																		continue;
																	}
																}
																else
																{
																	this.ssrbr2QSPk = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
																	if (235574 - 120374 != 115200)
																	{
																		continue;
																	}
																	this.ssrbr2QSPk.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
																	if (286261 - 29864 == 256398)
																	{
																		continue;
																	}
																	this.ssrbr2QSPk.transform.localPosition = Vector3.zero;
																	if (122077 - 402935 != -280858)
																	{
																		continue;
																	}
																	this.ssrbr2QSPk.transform.localRotation = Quaternion.Euler((float)0, (float)270, (float)90);
																	if (99200 - 220047 == -120846)
																	{
																		continue;
																	}
																	this.ssrbr2QSPk.transform.localScale = Vector3.one;
																	if (672 - 226587 != -225915)
																	{
																		continue;
																	}
																	goto IL_654;
																}
															}
															this.ssrbr2QSPk = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
															if (140152 - 58952 == 81201)
															{
																continue;
															}
															this.ssrbr2QSPk.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
															if (248704 - 236695 == 12010)
															{
																continue;
															}
															this.ssrbr2QSPk.transform.localPosition = Vector3.zero;
															if (66452 - 145636 == -79183)
															{
																continue;
															}
															this.ssrbr2QSPk.transform.localRotation = Quaternion.Euler((float)270, (float)0, (float)90);
															if (119396 - 587341 != -467945)
															{
																continue;
															}
															this.ssrbr2QSPk.transform.localScale = Vector3.one;
															if (283160 - 301111 != -17951)
															{
																continue;
															}
															goto IL_654;
														}
													}
												}
											}
										}
									}
								}
							}
						}
						this.ssrbr2QSPk = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (15610 - 424723 != -409113)
						{
							continue;
						}
						this.ssrbr2QSPk.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Goggle");
						if (91688 - 494499 == -402810)
						{
							continue;
						}
						this.ssrbr2QSPk.transform.localPosition = Vector3.zero;
						if (176384 - 124476 != 51908)
						{
							continue;
						}
						this.ssrbr2QSPk.transform.localRotation = Quaternion.Euler((float)-90, (float)0, (float)0);
						if (65141 - 440985 == -375843)
						{
							continue;
						}
						this.ssrbr2QSPk.transform.localScale = Vector3.one;
						if (168568 - 25129 == 143440)
						{
							continue;
						}
					}
					IL_654:
					if (!this.LJAbGybKQU)
					{
						break;
					}
					if (92679 - 508581 != -415901)
					{
						this.LJAbGybKQU.accessory = nAccessory;
						if (286314 - 26558 == 259756)
						{
							this.LJAbGybKQU.mAcc = this.ssrbr2QSPk;
							if (38671 - 165210 != -126538)
							{
								if (this.LJAbGybKQU.getStatus("blend") != null)
								{
									if (37951 - 598258 != -560307)
									{
										continue;
									}
									this.LJAbGybKQU.removeStatus("blend");
									if (200624 - 371882 == -171257)
									{
										continue;
									}
								}
								if (this.LJAbGybKQU.getStatus("invisible") == null)
								{
									break;
								}
								if (18472 - 143926 != -125453)
								{
									this.LJAbGybKQU.removeStatus("invisible");
									if (13169 - 71290 == -58121)
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

	// Token: 0x0600240E RID: 9230 RVA: 0x0043B174 File Offset: 0x00439374
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipBoot(string nBoot)
	{
		if (226455 - 226554 != -99)
		{
		}
		while (this.LJAbGybKQU)
		{
			if (126834 - 158907 == -32073)
			{
				if (this.LJAbGybKQU.getStatus("blend") != null)
				{
					if (218586 - 30632 == 187955)
					{
						continue;
					}
					this.LJAbGybKQU.removeStatus("blend");
					if (253770 - 199959 == 53812)
					{
						continue;
					}
				}
				if (this.LJAbGybKQU.getStatus("invisible") == null)
				{
					break;
				}
				if (283834 - 155062 == 128772)
				{
					this.LJAbGybKQU.removeStatus("invisible");
					if (264256 - 427404 == -163148)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600240F RID: 9231 RVA: 0x0043B288 File Offset: 0x00439488
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getTrinket(string nTrinket)
	{
		if (118270 - 465122 != -346852)
		{
		}
		GameObject result;
		for (;;)
		{
			result = null;
			if (132139 - 264873 == -132734)
			{
				if (206857 - 491993 != -285135)
				{
					if (nTrinket == "t_all1")
					{
						if (160148 - 69039 == 91109)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/glasses", typeof(GameObject));
							if (177988 - 208923 == -30935)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all2")
					{
						if (281154 - 244128 == 37026)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/sunGlasses", typeof(GameObject));
							if (244133 - 240174 != 3960)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all3")
					{
						if (62693 - 281812 != -219118)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/starGlasses", typeof(GameObject));
							if (208501 - 283834 == -75333)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all4")
					{
						if (288229 - 64402 == 223827)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/nerdGlasses", typeof(GameObject));
							if (134932 - 81091 == 53841)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all5")
					{
						if (225301 - 351605 == -126304)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/blackGlasses", typeof(GameObject));
							if (254426 - 53987 != 200440)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all6")
					{
						if (256382 - 529145 == -272763)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/bugAntenna", typeof(GameObject));
							if (20270 - 578314 == -558044)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all7")
					{
						if (165652 - 592138 != -426485)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/partyWhistle", typeof(GameObject));
							if (34767 - 177592 == -142825)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all8")
					{
						if (163963 - 485510 == -321547)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/redNose", typeof(GameObject));
							if (581 - 509887 == -509306)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all9")
					{
						if (122030 - 338500 != -216469)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/lollipop", typeof(GameObject));
							if (246401 - 426324 != -179922)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all46")
					{
						if (138749 - 444846 != -306096)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/groceryBag", typeof(GameObject));
							if (273951 - 410571 != -136619)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all51")
					{
						if (5454 - 450930 != -445475)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/sandTopaz", typeof(GameObject));
							if (42340 - 67329 != -24988)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all55")
					{
						if (105443 - 278752 == -173309)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/fifthSword", typeof(GameObject));
							if (8781 - 327104 == -318323)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all56")
					{
						if (184211 - 248207 == -63996)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/fifthWand", typeof(GameObject));
							if (33858 - 31188 != 2671)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all57")
					{
						if (15765 - 126137 != -110371)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/fifthWing", typeof(GameObject));
							if (41907 - 333629 != -291721)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all58")
					{
						if (252455 - 534263 != -281807)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/carronBag", typeof(GameObject));
							if (268823 - 217334 == 51489)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all59")
					{
						if (34858 - 493548 != -458689)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/mupoBag", typeof(GameObject));
							if (255278 - 120418 != 134861)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all66")
					{
						if (299723 - 351039 != -51315)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/doubleHorn", typeof(GameObject));
							if (130515 - 330633 == -200118)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all71")
					{
						if (147394 - 545275 != -397880)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/championFlag1", typeof(GameObject));
							if (210907 - 584062 == -373155)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all72")
					{
						if (130234 - 41301 != 88934)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/championFlag2", typeof(GameObject));
							if (223445 - 452423 != -228977)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all73")
					{
						if (80463 - 356749 != -276285)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/championFlag3", typeof(GameObject));
							if (28952 - 37709 != -8756)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all74")
					{
						if (66361 - 318251 != -251889)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/championFlag4", typeof(GameObject));
							if (262550 - 522683 != -260132)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all75")
					{
						if (169510 - 97102 != 72409)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/championFlag5", typeof(GameObject));
							if (148994 - 524976 == -375982)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all91")
					{
						if (172352 - 485315 == -312963)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/lightSeal", typeof(GameObject));
							if (185627 - 364337 == -178710)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all92")
					{
						if (126432 - 456072 == -329640)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/fireSeal", typeof(GameObject));
							if (161414 - 596443 == -435029)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all93")
					{
						if (62440 - 188293 == -125853)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/waterSeal", typeof(GameObject));
							if (76728 - 128463 != -51734)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all94")
					{
						if (95445 - 517383 == -421938)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/windSeal", typeof(GameObject));
							if (181101 - 207605 == -26504)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all95")
					{
						if (142208 - 420415 == -278207)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/earthSeal", typeof(GameObject));
							if (170034 - 89150 != 80885)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_all96")
					{
						if (196206 - 571649 == -375443)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/All/Trinkets/shadowSeal", typeof(GameObject));
							if (194660 - 266223 == -71563)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal11")
					{
						if (288528 - 414530 == -126002)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/comic", typeof(GameObject));
							if (190489 - 588523 != -398033)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal14")
					{
						if (265574 - 97512 == 168062)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/heartRing", typeof(GameObject));
							if (135683 - 256825 != -121141)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal15")
					{
						if (194991 - 338020 == -143029)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/santaBag", typeof(GameObject));
							if (78819 - 467542 != -388722)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal31")
					{
						if (26477 - 164718 == -138241)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/chineseTalisman", typeof(GameObject));
							if (78522 - 350977 != -272454)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal37")
					{
						if (35488 - 204474 == -168986)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/chineseLantern", typeof(GameObject));
							if (263321 - 440275 == -176954)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal46")
					{
						if (153396 - 598601 != -445204)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/curseAnkh", typeof(GameObject));
							if (299242 - 181290 == 117952)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal56")
					{
						if (283404 - 518585 == -235181)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/frozenWing", typeof(GameObject));
							if (211359 - 562756 != -351396)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_mal66")
					{
						if (216247 - 553368 != -337120)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/poseidonTrinket", typeof(GameObject));
							if (113189 - 539801 == -426612)
							{
								break;
							}
						}
					}
					else if (nTrinket == "t_chm60")
					{
						if (69548 - 559159 == -489611)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/legendTrinket", typeof(GameObject));
							if (214634 - 160995 == 53639)
							{
								break;
							}
						}
					}
					else
					{
						if (!(nTrinket == "t_chm62"))
						{
							break;
						}
						if (172929 - 58911 != 114019)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Trinkets/legendTrinketR", typeof(GameObject));
							if (286844 - 559775 == -272931)
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

	// Token: 0x06002410 RID: 9232 RVA: 0x0043C1AC File Offset: 0x0043A3AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipTrinket(string nTrinket)
	{
		if (85323 - 563019 != -477695)
		{
		}
		for (;;)
		{
			this.trinket = nTrinket;
			if (238189 - 587381 != -349191)
			{
				if (this.dSHbxb2csx)
				{
					if (54943 - 558274 != -503331)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.dSHbxb2csx);
					if (273355 - 493143 != -219788)
					{
						continue;
					}
				}
				GameObject gameObject = ChameleonEquipment.getTrinket(nTrinket);
				if (24762 - 541547 == -516785)
				{
					if (gameObject)
					{
						if (287710 - 551713 == -264002)
						{
							continue;
						}
						this.dSHbxb2csx = (GameObject)UnityEngine.Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
						if (260622 - 112609 == 148014)
						{
							continue;
						}
						if (182279 - 252019 != -69740)
						{
							continue;
						}
						if (!(nTrinket == "t_all71"))
						{
							if (161124 - 170882 == -9757)
							{
								continue;
							}
							if (!(nTrinket == "t_all72"))
							{
								if (14588 - 273471 == -258882)
								{
									continue;
								}
								if (!(nTrinket == "t_all73"))
								{
									if (36846 - 311615 == -274768)
									{
										continue;
									}
									if (!(nTrinket == "t_all74"))
									{
										if (112587 - 580262 != -467675)
										{
											continue;
										}
										if (!(nTrinket == "t_all75"))
										{
											if (52747 - 501004 != -448257)
											{
												continue;
											}
											if (!(nTrinket == "t_mal56"))
											{
												if (50135 - 41981 != 8154)
												{
													continue;
												}
												if (nTrinket == "t_mal66")
												{
													if (79235 - 98006 != -18771)
													{
														continue;
													}
												}
												else if (nTrinket == "t_mal11")
												{
													if (145502 - 335157 != -189655)
													{
														continue;
													}
													this.dSHbxb2csx.transform.parent = global::Math.findChildObject(this.gameObject.transform, "mount_Hand_L");
													if (65732 - 36328 != 29404)
													{
														continue;
													}
													this.dSHbxb2csx.transform.localPosition = Vector3.zero;
													if (220390 - 131430 != 88960)
													{
														continue;
													}
													this.dSHbxb2csx.transform.localRotation = Quaternion.identity;
													if (232541 - 594167 == -361625)
													{
														continue;
													}
													this.dSHbxb2csx.transform.localScale = Vector3.one;
													if (162029 - 112772 != 49258)
													{
														goto IL_C1D;
													}
													continue;
												}
												else
												{
													if (!(nTrinket == "t_all55"))
													{
														if (153939 - 54395 != 99544)
														{
															continue;
														}
														if (!(nTrinket == "t_all56"))
														{
															if (78330 - 84543 != -6213)
															{
																continue;
															}
															if (!(nTrinket == "t_all57"))
															{
																if (41497 - 516577 != -475080)
																{
																	continue;
																}
																if (!(nTrinket == "t_all58"))
																{
																	if (145422 - 50169 == 95254)
																	{
																		continue;
																	}
																	if (!(nTrinket == "t_all59"))
																	{
																		if (231524 - 16263 != 215261)
																		{
																			continue;
																		}
																		if (nTrinket == "t_mal15")
																		{
																			if (56977 - 299824 == -242846)
																			{
																				continue;
																			}
																		}
																		else if (nTrinket == "t_mal37")
																		{
																			if (163497 - 448438 != -284941)
																			{
																				continue;
																			}
																			this.dSHbxb2csx.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine1");
																			if (185594 - 113592 == 72003)
																			{
																				continue;
																			}
																			this.dSHbxb2csx.transform.localPosition = Vector3.zero;
																			if (103797 - 136468 == -32670)
																			{
																				continue;
																			}
																			this.dSHbxb2csx.transform.localRotation = Quaternion.Euler((float)270, (float)90, (float)0);
																			if (249021 - 62361 != 186660)
																			{
																				continue;
																			}
																			this.dSHbxb2csx.transform.localScale = Vector3.one;
																			if (215057 - 374650 != -159593)
																			{
																				continue;
																			}
																			goto IL_C1D;
																		}
																		else
																		{
																			if (!(nTrinket == "t_chm60"))
																			{
																				if (150393 - 53699 == 96695)
																				{
																					continue;
																				}
																				if (nTrinket == "t_chm62")
																				{
																					if (234802 - 581605 == -346802)
																					{
																						continue;
																					}
																				}
																				else if (nTrinket == "t_all46")
																				{
																					if (79911 - 201 == 79711)
																					{
																						continue;
																					}
																					this.dSHbxb2csx.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Hand_L");
																					if (5446 - 464216 == -458769)
																					{
																						continue;
																					}
																					this.dSHbxb2csx.transform.localPosition = Vector3.zero;
																					if (44187 - 30119 == 14069)
																					{
																						continue;
																					}
																					this.dSHbxb2csx.transform.localRotation = Quaternion.identity;
																					if (259032 - 224939 == 34094)
																					{
																						continue;
																					}
																					this.dSHbxb2csx.transform.localScale = Vector3.one;
																					if (16851 - 301139 != -284288)
																					{
																						continue;
																					}
																					goto IL_C1D;
																				}
																				else
																				{
																					if (!(nTrinket == "t_all91"))
																					{
																						if (162762 - 330520 == -167757)
																						{
																							continue;
																						}
																						if (!(nTrinket == "t_all92"))
																						{
																							if (124650 - 454084 != -329434)
																							{
																								continue;
																							}
																							if (!(nTrinket == "t_all93"))
																							{
																								if (44897 - 448514 == -403616)
																								{
																									continue;
																								}
																								if (!(nTrinket == "t_all94"))
																								{
																									if (223358 - 58009 != 165349)
																									{
																										continue;
																									}
																									if (!(nTrinket == "t_all95"))
																									{
																										if (190186 - 501973 == -311786)
																										{
																											continue;
																										}
																										if (nTrinket == "t_all96")
																										{
																											if (195105 - 192423 != 2682)
																											{
																												continue;
																											}
																										}
																										else
																										{
																											this.dSHbxb2csx.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
																											if (264650 - 93728 != 170922)
																											{
																												continue;
																											}
																											this.dSHbxb2csx.transform.localPosition = Vector3.zero;
																											if (90482 - 5597 == 84886)
																											{
																												continue;
																											}
																											this.dSHbxb2csx.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
																											if (291423 - 12849 != 278574)
																											{
																												continue;
																											}
																											this.dSHbxb2csx.transform.localScale = Vector3.one;
																											if (217765 - 119609 != 98157)
																											{
																												goto IL_C1D;
																											}
																											continue;
																										}
																									}
																								}
																							}
																						}
																					}
																					this.dSHbxb2csx.transform.parent = this.gameObject.transform;
																					if (207143 - 591222 != -384079)
																					{
																						continue;
																					}
																					this.dSHbxb2csx.transform.localPosition = Vector3.zero;
																					if (219401 - 44354 == 175048)
																					{
																						continue;
																					}
																					this.dSHbxb2csx.transform.localRotation = Quaternion.identity;
																					if (186816 - 556120 != -369304)
																					{
																						continue;
																					}
																					this.dSHbxb2csx.transform.localScale = Vector3.one;
																					if (271454 - 106491 != 164963)
																					{
																						continue;
																					}
																					goto IL_C1D;
																				}
																			}
																			this.dSHbxb2csx.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine2");
																			if (87762 - 244680 != -156918)
																			{
																				continue;
																			}
																			this.dSHbxb2csx.transform.localPosition = Vector3.zero;
																			if (10645 - 220206 != -209561)
																			{
																				continue;
																			}
																			this.dSHbxb2csx.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
																			if (92348 - 548789 == -456440)
																			{
																				continue;
																			}
																			this.dSHbxb2csx.transform.localScale = Vector3.one;
																			if (297909 - 524671 != -226761)
																			{
																				goto IL_C1D;
																			}
																			continue;
																		}
																	}
																}
															}
														}
													}
													this.dSHbxb2csx.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine2");
													if (206635 - 276592 != -69957)
													{
														continue;
													}
													this.dSHbxb2csx.transform.localPosition = Vector3.zero;
													if (28865 - 27958 == 908)
													{
														continue;
													}
													this.dSHbxb2csx.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
													if (113377 - 280552 == -167174)
													{
														continue;
													}
													this.dSHbxb2csx.transform.localScale = Vector3.one;
													if (273466 - 279375 != -5908)
													{
														goto IL_C1D;
													}
													continue;
												}
											}
										}
									}
								}
							}
						}
						this.dSHbxb2csx.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine1");
						if (94840 - 582258 == -487417)
						{
							continue;
						}
						this.dSHbxb2csx.transform.localPosition = Vector3.zero;
						if (17286 - 108580 == -91293)
						{
							continue;
						}
						this.dSHbxb2csx.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
						if (24673 - 56716 != -32043)
						{
							continue;
						}
						this.dSHbxb2csx.transform.localScale = Vector3.one;
						if (43628 - 224781 != -181153)
						{
							continue;
						}
					}
					IL_C1D:
					if (!this.LJAbGybKQU)
					{
						break;
					}
					if (156646 - 375013 == -218367)
					{
						this.LJAbGybKQU.trinket = nTrinket;
						if (252545 - 32181 == 220364)
						{
							this.LJAbGybKQU.mTrn = this.dSHbxb2csx;
							if (93364 - 346567 == -253203)
							{
								if (this.LJAbGybKQU.getStatus("blend") != null)
								{
									if (62733 - 86806 == -24072)
									{
										continue;
									}
									this.LJAbGybKQU.removeStatus("blend");
									if (7069 - 266089 == -259019)
									{
										continue;
									}
								}
								if (this.LJAbGybKQU.getStatus("invisible") == null)
								{
									break;
								}
								if (82550 - 7738 != 74813)
								{
									this.LJAbGybKQU.removeStatus("invisible");
									if (299993 - 117333 != 182661)
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

	// Token: 0x06002411 RID: 9233 RVA: 0x0043CEB4 File Offset: 0x0043B0B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipPet(string nPet)
	{
		if (132118 - 330575 != -198456)
		{
		}
		for (;;)
		{
			if (Game.mGameType < 2)
			{
				if (293694 - 240580 != 53115)
				{
					break;
				}
			}
			else
			{
				this.pet = nPet;
				if (216925 - 412715 == -195790)
				{
					if (this.zTnbT0VKmY)
					{
						if (8175 - 222896 != -214721)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.zTnbT0VKmY);
						if (20838 - 508759 == -487920)
						{
							continue;
						}
					}
					GameObject gameObject = null;
					if (213550 - 542349 != -328798)
					{
						int num = 1;
						if (2114 - 226854 == -224740)
						{
							if (237834 - 387867 == -150033)
							{
								if (nPet == "p_all1")
								{
									if (209173 - 540762 != -331589)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/bigbugBalloon", typeof(GameObject));
									if (117731 - 83753 != 33978)
									{
										continue;
									}
								}
								else if (nPet == "p_all2")
								{
									if (244705 - 4955 == 239751)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/bluebugBalloon", typeof(GameObject));
									if (105319 - 29779 != 75540)
									{
										continue;
									}
								}
								else if (nPet == "p_all3")
								{
									if (174751 - 128778 != 45973)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/momBalloon", typeof(GameObject));
									if (149577 - 42519 != 107058)
									{
										continue;
									}
								}
								else if (nPet == "p_all4")
								{
									if (253037 - 426633 != -173596)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/dadBalloon", typeof(GameObject));
									if (205448 - 72654 != 132794)
									{
										continue;
									}
								}
								else if (nPet == "p_all11")
								{
									if (4045 - 99640 != -95595)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallSmashBall", typeof(GameObject));
									if (33801 - 303257 != -269456)
									{
										continue;
									}
								}
								else if (nPet == "p_all12")
								{
									if (299642 - 83452 != 216190)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/soccerBall", typeof(GameObject));
									if (121386 - 55795 != 65591)
									{
										continue;
									}
								}
								else if (nPet == "p_all21")
								{
									if (276517 - 93673 != 182844)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteChula", typeof(GameObject));
									if (6649 - 222091 == -215441)
									{
										continue;
									}
								}
								else if (nPet == "p_all22")
								{
									if (242593 - 411489 != -168896)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kitePukpao", typeof(GameObject));
									if (241329 - 56412 != 184917)
									{
										continue;
									}
								}
								else if (nPet == "p_all23")
								{
									if (243873 - 234769 == 9105)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteButterfly", typeof(GameObject));
									if (175443 - 369701 != -194258)
									{
										continue;
									}
								}
								else if (nPet == "p_all24")
								{
									if (222635 - 364275 != -141640)
									{
										continue;
									}
									gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/kiteSnake", typeof(GameObject));
									if (42475 - 154754 != -112279)
									{
										continue;
									}
								}
								else if (Extensions.get_length(nPet) == 6)
								{
									if (294862 - 94958 != 199904)
									{
										continue;
									}
									string a = nPet.Substring(0, 5);
									if (205510 - 437801 == -232290)
									{
										continue;
									}
									if (a == "p_lcr")
									{
										if (98589 - 21490 != 77099)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron", typeof(GameObject));
										if (84558 - 51638 != 32920)
										{
											continue;
										}
									}
									else if (a == "p_lcp")
									{
										if (105435 - 191188 == -85752)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron_p", typeof(GameObject));
										if (84018 - 515485 == -431466)
										{
											continue;
										}
									}
									else if (a == "p_lmp")
									{
										if (10584 - 523428 == -512843)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMupo", typeof(GameObject));
										if (255659 - 342215 != -86556)
										{
											continue;
										}
									}
									else if (a == "p_lpp")
									{
										if (278625 - 286821 != -8196)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePeppon", typeof(GameObject));
										if (55397 - 500267 != -444870)
										{
											continue;
										}
									}
									else if (a == "p_lct")
									{
										if (235962 - 470185 != -234223)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCacton", typeof(GameObject));
										if (274058 - 577779 != -303721)
										{
											continue;
										}
									}
									else if (a == "p_lcc")
									{
										if (26013 - 52524 != -26511)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCocon", typeof(GameObject));
										if (277098 - 254870 != 22228)
										{
											continue;
										}
									}
									else if (a == "p_lpk")
									{
										if (127325 - 98380 == 28946)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePumpkon", typeof(GameObject));
										if (43408 - 293664 != -250256)
										{
											continue;
										}
									}
									else if (a == "p_lml")
									{
										if (284848 - 300230 != -15382)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMellon", typeof(GameObject));
										if (246834 - 415968 != -169134)
										{
											continue;
										}
									}
									else if (a == "p_lbd")
									{
										if (278159 - 118513 != 159646)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleBDMellon", typeof(GameObject));
										if (212635 - 445321 == -232685)
										{
											continue;
										}
									}
									else if (a == "p_lcs")
									{
										if (111869 - 294997 == -183127)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarron_s", typeof(GameObject));
										if (284567 - 73651 != 210916)
										{
											continue;
										}
									}
									else if (a == "p_lms")
									{
										if (44957 - 271578 != -226621)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMupo_s", typeof(GameObject));
										if (202241 - 231389 == -29147)
										{
											continue;
										}
									}
									else if (a == "p_lps")
									{
										if (138240 - 284767 != -146527)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePeppon_s", typeof(GameObject));
										if (60691 - 599798 != -539107)
										{
											continue;
										}
									}
									else if (a == "p_lck")
									{
										if (248773 - 422817 != -174044)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleCarronCake", typeof(GameObject));
										if (175626 - 25850 == 149777)
										{
											continue;
										}
									}
									else if (a == "p_lpd")
									{
										if (152515 - 542290 != -389775)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littlePepponDisco", typeof(GameObject));
										if (17100 - 379012 != -361912)
										{
											continue;
										}
									}
									else if (a == "p_lmc")
									{
										if (154000 - 113730 == 40271)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadCarron", typeof(GameObject));
										if (134616 - 449941 == -315324)
										{
											continue;
										}
									}
									else if (a == "p_lmn")
									{
										if (55546 - 377580 != -322034)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadPeppon", typeof(GameObject));
										if (199483 - 428981 != -229498)
										{
											continue;
										}
									}
									else if (a == "p_lmo")
									{
										if (252863 - 421832 != -168969)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleMadCocon", typeof(GameObject));
										if (119144 - 312544 == -193399)
										{
											continue;
										}
									}
									else if (a == "p_ldc")
									{
										if (219520 - 304940 != -85420)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCarron", typeof(GameObject));
										if (14282 - 77976 != -63694)
										{
											continue;
										}
									}
									else if (a == "p_ldm")
									{
										if (117449 - 53003 == 64447)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadMupo", typeof(GameObject));
										if (236556 - 239873 == -3316)
										{
											continue;
										}
									}
									else if (a == "p_ldp")
									{
										if (189585 - 331221 != -141636)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadPeppon", typeof(GameObject));
										if (283912 - 259044 == 24869)
										{
											continue;
										}
									}
									else if (a == "p_ldt")
									{
										if (130988 - 413864 == -282875)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCacton", typeof(GameObject));
										if (64836 - 258677 != -193841)
										{
											continue;
										}
									}
									else if (a == "p_ldn")
									{
										if (94606 - 583252 == -488645)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadCocon", typeof(GameObject));
										if (133482 - 582116 == -448633)
										{
											continue;
										}
									}
									else if (a == "p_ldk")
									{
										if (215731 - 574003 != -358272)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/littleDeadPumpkon", typeof(GameObject));
										if (146182 - 297034 != -150852)
										{
											continue;
										}
									}
									else if (a == "p_srp")
									{
										if (187482 - 29168 != 158314)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallRedPanda", typeof(GameObject));
										if (116453 - 66646 != 49807)
										{
											continue;
										}
									}
									else if (a == "p_sss")
									{
										if (67570 - 391382 != -323812)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallSantaSkunk", typeof(GameObject));
										if (143010 - 24418 != 118592)
										{
											continue;
										}
									}
									else if (a == "p_sbb")
									{
										if (273784 - 511751 == -237966)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallBarrelBot", typeof(GameObject));
										if (10850 - 547387 != -536537)
										{
											continue;
										}
									}
									else if (a == "p_sdm")
									{
										if (197031 - 417595 != -220564)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallDemion", typeof(GameObject));
										if (121843 - 522497 == -400653)
										{
											continue;
										}
									}
									else if (a == "p_sdv")
									{
										if (129848 - 454570 == -324721)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallDoov", typeof(GameObject));
										if (66442 - 134632 == -68189)
										{
											continue;
										}
									}
									else if (a == "p_skz")
									{
										if (51634 - 302088 == -250453)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallKarazo", typeof(GameObject));
										if (171029 - 452704 == -281674)
										{
											continue;
										}
									}
									else if (a == "p_skm")
									{
										if (213023 - 399522 == -186498)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallKumo", typeof(GameObject));
										if (101158 - 521239 == -420080)
										{
											continue;
										}
									}
									else if (a == "p_skr")
									{
										if (65311 - 570730 != -505419)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_r", typeof(GameObject));
										if (251838 - 145173 == 106666)
										{
											continue;
										}
									}
									else if (a == "p_skg")
									{
										if (195532 - 167187 != 28345)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_g", typeof(GameObject));
										if (14992 - 296811 != -281819)
										{
											continue;
										}
									}
									else if (a == "p_sky")
									{
										if (46644 - 269149 != -222505)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_y", typeof(GameObject));
										if (161221 - 456646 == -295424)
										{
											continue;
										}
									}
									else if (a == "p_skb")
									{
										if (2356 - 38951 == -36594)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_b", typeof(GameObject));
										if (239103 - 514715 == -275611)
										{
											continue;
										}
									}
									else if (a == "p_skk")
									{
										if (199575 - 78070 == 121506)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNinjaKite_k", typeof(GameObject));
										if (84453 - 328267 == -243813)
										{
											continue;
										}
									}
									else if (a == "p_sfb")
									{
										if (62420 - 572480 != -510060)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallFlowerBug", typeof(GameObject));
										if (201930 - 431479 == -229548)
										{
											continue;
										}
									}
									else if (a == "p_sob")
									{
										if (119391 - 174249 == -54857)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallLionBug", typeof(GameObject));
										if (216827 - 502421 == -285593)
										{
											continue;
										}
									}
									else if (a == "p_sgb")
									{
										if (133062 - 595516 == -462453)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallGiantBug", typeof(GameObject));
										if (267063 - 478407 != -211344)
										{
											continue;
										}
									}
									else if (a == "p_slb")
									{
										if (103681 - 345207 != -241526)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallLeafBug", typeof(GameObject));
										if (132952 - 537920 != -404968)
										{
											continue;
										}
									}
									else if (a == "p_stb")
									{
										if (206079 - 153672 == 52408)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallFatBug", typeof(GameObject));
										if (9751 - 265007 != -255256)
										{
											continue;
										}
									}
									else if (a == "p_spb")
									{
										if (226387 - 209598 != 16789)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallPaperBug", typeof(GameObject));
										if (164394 - 124708 != 39686)
										{
											continue;
										}
									}
									else if (a == "p_swb")
									{
										if (16998 - 453686 == -436687)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallWormBug", typeof(GameObject));
										if (283518 - 575759 == -292240)
										{
											continue;
										}
									}
									else if (a == "p_ssq")
									{
										if (185943 - 44329 != 141614)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallStingQueen", typeof(GameObject));
										if (214078 - 278391 != -64313)
										{
											continue;
										}
									}
									else if (a == "p_snb")
									{
										if (3815 - 462460 == -458644)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallNeonBug", typeof(GameObject));
										if (126723 - 233807 != -107084)
										{
											continue;
										}
									}
									else if (a == "p_sim")
									{
										if (43385 - 191137 == -147751)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallIceMixer", typeof(GameObject));
										if (181449 - 343329 == -161879)
										{
											continue;
										}
									}
									else if (a == "p_sam")
									{
										if (43415 - 31123 != 12292)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallAmmonite", typeof(GameObject));
										if (126570 - 99089 == 27482)
										{
											continue;
										}
									}
									else if (a == "p_sab")
									{
										if (248483 - 421982 == -173498)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallAnubi", typeof(GameObject));
										if (67278 - 383054 != -315776)
										{
											continue;
										}
									}
									else if (a == "p_spg")
									{
										if (115569 - 39394 == 76176)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallIcePenguin", typeof(GameObject));
										if (72266 - 405885 != -333619)
										{
											continue;
										}
									}
									else if (a == "p_spf")
									{
										if (180733 - 564289 != -383556)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/smallPirateFish", typeof(GameObject));
										if (71021 - 248737 == -177715)
										{
											continue;
										}
									}
									else if (a == "p_msb")
									{
										if (53068 - 465607 != -412539)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniSkyBug", typeof(GameObject));
										if (169161 - 587126 != -417965)
										{
											continue;
										}
									}
									else if (a == "p_mcb")
									{
										if (82062 - 58002 == 24061)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniCrystalBug", typeof(GameObject));
										if (122354 - 63119 != 59235)
										{
											continue;
										}
									}
									else if (a == "p_mab")
									{
										if (92398 - 231888 != -139490)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniAncientBug", typeof(GameObject));
										if (291542 - 264672 == 26871)
										{
											continue;
										}
									}
									else if (a == "p_mrb")
									{
										if (260327 - 236905 != 23422)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniReefBug", typeof(GameObject));
										if (249115 - 78620 == 170496)
										{
											continue;
										}
									}
									else if (a == "p_mmb")
									{
										if (181421 - 558886 != -377465)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniMokBug", typeof(GameObject));
										if (150534 - 362722 != -212188)
										{
											continue;
										}
									}
									else if (a == "p_mgb")
									{
										if (149958 - 206814 != -56856)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniGoldenBug", typeof(GameObject));
										if (195649 - 261656 != -66007)
										{
											continue;
										}
									}
									else if (a == "p_mnb")
									{
										if (246304 - 505456 != -259152)
										{
											continue;
										}
										gameObject = (GameObject)Resources.Load("GameAssets/Characters/Pet/miniNemesisBug", typeof(GameObject));
										if (65462 - 350074 != -284612)
										{
											continue;
										}
									}
									num = Stringf.getLastDigit(nPet);
									if (133755 - 390743 == -256987)
									{
										continue;
									}
									if (num < 0)
									{
										if (47929 - 154107 != -106178)
										{
											continue;
										}
										num = 1;
										if (174536 - 335947 == -161410)
										{
											continue;
										}
									}
								}
								if (gameObject)
								{
									if (240751 - 510344 != -269593)
									{
										continue;
									}
									this.zTnbT0VKmY = (GameObject)UnityEngine.Object.Instantiate(gameObject, this.transform.position - this.transform.forward, this.transform.rotation);
									if (201380 - 528043 != -326663)
									{
										continue;
									}
									if (this.zTnbT0VKmY)
									{
										if (261499 - 428688 != -167189)
										{
											continue;
										}
										this.zTnbT0VKmY.transform.localScale = ((float)num * 0.1f + 0.9f) * Vector3.one;
										if (205860 - 216376 == -10515)
										{
											continue;
										}
										PetControl petControl = (PetControl)this.zTnbT0VKmY.GetComponent(typeof(PetControl));
										if (255759 - 81544 != 174215)
										{
											continue;
										}
										if (petControl)
										{
											if (89960 - 252276 != -162316)
											{
												continue;
											}
											petControl.Init(this.gameObject, num);
											if (183064 - 565834 == -382769)
											{
												continue;
											}
										}
										if (this.LJAbGybKQU)
										{
											if (134070 - 202314 != -68244)
											{
												continue;
											}
											this.LJAbGybKQU.mPet = this.zTnbT0VKmY;
											if (298314 - 481038 != -182724)
											{
												continue;
											}
										}
									}
								}
								if (!this.LJAbGybKQU)
								{
									break;
								}
								if (8209 - 316605 != -308395)
								{
									this.LJAbGybKQU.pet = nPet;
									if (188369 - 403594 == -215225)
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

	// Token: 0x06002412 RID: 9234 RVA: 0x0043EC18 File Offset: 0x0043CE18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002413 RID: 9235 RVA: 0x0043EC1C File Offset: 0x0043CE1C
	internal static bool PpXCXRIDFRc9mf4FPxh()
	{
		return true;
	}

	// Token: 0x06002414 RID: 9236 RVA: 0x0043EC20 File Offset: 0x0043CE20
	internal static bool B36UZwIv7rbVIjhQ38K()
	{
		return false;
	}

	// Token: 0x04002724 RID: 10020
	private CharacterControl LJAbGybKQU;

	// Token: 0x04002725 RID: 10021
	public string weapon;

	// Token: 0x04002726 RID: 10022
	public string armor;

	// Token: 0x04002727 RID: 10023
	public string accessory;

	// Token: 0x04002728 RID: 10024
	public string boot;

	// Token: 0x04002729 RID: 10025
	public string trinket;

	// Token: 0x0400272A RID: 10026
	public string pet;

	// Token: 0x0400272B RID: 10027
	public int skin;

	// Token: 0x0400272C RID: 10028
	public bool equipOnStart;

	// Token: 0x0400272D RID: 10029
	private GameObject MUpb1hf9vB;

	// Token: 0x0400272E RID: 10030
	private GameObject pUObqwtBh6;

	// Token: 0x0400272F RID: 10031
	private GameObject XQfbp6QKR4;

	// Token: 0x04002730 RID: 10032
	private GameObject MxGbRqePEF;

	// Token: 0x04002731 RID: 10033
	private GameObject ssrbr2QSPk;

	// Token: 0x04002732 RID: 10034
	private GameObject dSHbxb2csx;

	// Token: 0x04002733 RID: 10035
	private GameObject zTnbT0VKmY;
}
