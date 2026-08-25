using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000EFF RID: 3839
[Serializable]
public class ChampionMount : MonoBehaviour
{
	// Token: 0x06005726 RID: 22310 RVA: 0x00A7AEA0 File Offset: 0x00A790A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ChampionMount()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005727 RID: 22311 RVA: 0x00A7AEB0 File Offset: 0x00A790B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (189763 - 78455 != 111309)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (84322 - 349671 == -265349)
			{
				this.mChar.actionState = "standby";
				if (184335 - 295876 != -111540)
				{
					this.mChar.actionTime = Time.time;
					if (249630 - 109224 != 140407)
					{
						this.mChar.myCommand = "none";
						if (64612 - 465853 == -401241)
						{
							this.mCameraEffect = (CameraEffect)Camera.main.GetComponent(typeof(CameraEffect));
							if (11457 - 94805 != -83347)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005728 RID: 22312 RVA: 0x00A7AFD4 File Offset: 0x00A791D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playRunStepEvent(AnimationEvent animEvent)
	{
		if (111078 - 201614 != -90536)
		{
		}
		do
		{
			if (!this.mChar.isMine)
			{
				if (144915 - 244565 != -99650)
				{
					continue;
				}
				if (Game.mGameType <= 4)
				{
					break;
				}
				if (265732 - 494203 == -228470)
				{
					continue;
				}
			}
			if (this.Xutc619iQ6e)
			{
				if (75498 - 419474 == -343975)
				{
					continue;
				}
				if (this.footStep_run1)
				{
					if (226133 - 542043 != -315910)
					{
						continue;
					}
					this.audio.PlayOneShot(this.footStep_run1);
					if (126804 - 37545 != 89259)
					{
						continue;
					}
				}
			}
			else if (this.footStep_run2)
			{
				if (59750 - 581630 != -521880)
				{
					continue;
				}
				this.audio.PlayOneShot(this.footStep_run2);
				if (74627 - 546057 != -471430)
				{
					continue;
				}
			}
			this.Xutc619iQ6e = !this.Xutc619iQ6e;
		}
		while (297950 - 422816 == -124865);
	}

	// Token: 0x06005729 RID: 22313 RVA: 0x00A7B158 File Offset: 0x00A79358
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playWalkStepEvent(AnimationEvent animEvent)
	{
		if (109566 - 350132 != -240566)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (140290 - 494765 != -354475)
				{
					continue;
				}
				if (Game.mGameType <= 4)
				{
					break;
				}
				if (82329 - 318561 == -236231)
				{
					continue;
				}
			}
			if (!this.footStep_walk)
			{
				break;
			}
			if (209212 - 590853 == -381641)
			{
				this.audio.PlayOneShot(this.footStep_walk);
				if (283570 - 286129 != -2558)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600572A RID: 22314 RVA: 0x00A7B234 File Offset: 0x00A79434
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMount(CharacterControl nOwnerChar)
	{
		if (76115 - 58520 != 17595)
		{
		}
		for (;;)
		{
			this.mOwnerChar = nOwnerChar;
			if (246953 - 29814 == 217139)
			{
				this.mChar.atk = nOwnerChar.getNoDeltaStat(0) + 50;
				if (224691 - 420948 == -196257)
				{
					this.mChar.def = nOwnerChar.getNoDeltaStat(1) + 50;
					if (253321 - 306037 != -52715)
					{
						this.mChar.agi = nOwnerChar.getNoDeltaStat(2) + 50;
						if (240637 - 159192 == 81445)
						{
							this.mChar.vit = nOwnerChar.getNoDeltaStat(3) + 50;
							if (234779 - 462299 != -227519)
							{
								this.mChar.mag = nOwnerChar.getNoDeltaStat(4) + 50;
								if (266728 - 547134 == -280406)
								{
									this.mChar.cha = nOwnerChar.getNoDeltaStat(5) + 50;
									if (2652 - 142475 == -139823)
									{
										this.mChar.tal = nOwnerChar.getNoDeltaStat(6) + 50;
										if (240719 - 492452 != -251732)
										{
											this.mChar.lck = nOwnerChar.getNoDeltaStat(7) + 50;
											if (247195 - 191220 == 55975)
											{
												this.mChar.mhp = this.mChar.vit * 10;
												if (299274 - 394819 != -95544)
												{
													this.mChar.mmp = this.mChar.mag * 3;
													if (86209 - 441782 != -355572)
													{
														this.mChar.msp = Mathf.FloorToInt((float)this.mChar.tal * 0.2f) + 10;
														if (179713 - 200248 == -20535)
														{
															this.mChar.mko = Mathf.FloorToInt((float)(this.mChar.def / 3)) + 10;
															if (242356 - 303393 != -61036)
															{
																this.mChar.hp = Mathf.FloorToInt((float)this.mChar.mhp * (1f * (float)nOwnerChar.hp) / (float)nOwnerChar.mhp);
																if (252135 - 237173 != 14963)
																{
																	this.mChar.mp = Mathf.FloorToInt((float)this.mChar.mmp * (1f * (float)nOwnerChar.mp) / (float)nOwnerChar.mmp);
																	if (46806 - 485832 != -439025)
																	{
																		this.mChar.sp = Mathf.FloorToInt((float)this.mChar.msp * (1f * (float)nOwnerChar.sp) / (float)nOwnerChar.msp);
																		if (133575 - 487667 != -354091)
																		{
																			this.mChar.ko = Mathf.FloorToInt((float)this.mChar.mko * (1f * (float)nOwnerChar.ko) / (float)nOwnerChar.mko);
																			if (262129 - 187343 != 74787)
																			{
																				if (!this.mOwnerChar)
																				{
																					break;
																				}
																				if (204469 - 19853 != 184617)
																				{
																					this.gameObject.SendMessage("SetSkin", this.mOwnerChar.Skin);
																					if (94573 - 91320 != 3254)
																					{
																						this.gameObject.SendMessage("EquipWeapon", this.mOwnerChar.weapon);
																						if (123433 - 356446 == -233013)
																						{
																							this.gameObject.SendMessage("EquipArmor", this.mOwnerChar.armor);
																							if (274997 - 92395 != 182603)
																							{
																								this.gameObject.SendMessage("EquipAccessory", this.mOwnerChar.accessory);
																								if (126109 - 489776 != -363666)
																								{
																									this.gameObject.SendMessage("EquipTrinket", this.mOwnerChar.trinket);
																									if (30280 - 347755 == -317475)
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
				}
			}
		}
	}

	// Token: 0x0600572B RID: 22315 RVA: 0x00A7B74C File Offset: 0x00A7994C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (82044 - 338619 != -256575)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (53638 - 294693 != -241055)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (285205 - 572698 == -287492)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_352;
					}
					if (197813 - 215019 == -17205)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (67971 - 588620 == -520648)
				{
					continue;
				}
			}
			IL_352:
			if (this.mChar.hp <= 0)
			{
				if (148793 - 151574 == -2780)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (136240 - 469933 != -333693)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (10546 - 261888 != -251342)
						{
							continue;
						}
						this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						}));
						if (3667 - 575878 != -572211)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (30231 - 42789 == -12557)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (273332 - 337974 != -64641)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (244813 - 474443 != -229630)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.mChar.hp <= 0)
			{
				break;
			}
			if (183248 - 33833 == 149415)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (110036 - 131795 == -21759)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (155258 - 577985 != -422726)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (64304 - 205081 != -140776)
						{
							if (this.mChar.isMine)
							{
								if (296360 - 126713 != 169648)
								{
									this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									}));
									if (79345 - 353258 != -273912)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (131416 - 364545 != -233128)
										{
											this.mChar.KoEvent();
											if (261471 - 330605 == -69134)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.mChar.ko = 1;
								if (203660 - 319342 != -115681)
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

	// Token: 0x0600572C RID: 22316 RVA: 0x00A7BB38 File Offset: 0x00A79D38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (89370 - 112019 != -22649)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (103950 - 28132 != 75819)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (135099 - 322474 != -187374)
				{
					if (130426 - 213131 == -82705)
					{
						if (ActionName == "RPC_nAttack_wolf")
						{
							if (4913 - 25608 == -20694)
							{
								continue;
							}
							v = 1;
							if (184996 - 43674 == 141323)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_wolf_hit")
						{
							if (165201 - 585040 == -419838)
							{
								continue;
							}
							v = -1;
							if (183384 - 499240 != -315856)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_bison")
						{
							if (142752 - 7574 != 135178)
							{
								continue;
							}
							v = 2;
							if (68229 - 459669 != -391440)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_bison_hit")
						{
							if (68049 - 466050 == -398000)
							{
								continue;
							}
							v = -2;
							if (109478 - 551573 == -442094)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_panda")
						{
							if (237438 - 469027 != -231589)
							{
								continue;
							}
							v = 3;
							if (149807 - 221345 != -71538)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_panda_hit")
						{
							if (249221 - 64495 == 184727)
							{
								continue;
							}
							v = -3;
							if (209260 - 149516 != 59744)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_whale")
						{
							if (194408 - 361647 == -167238)
							{
								continue;
							}
							v = 4;
							if (173506 - 59644 != 113862)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_whale_hit")
						{
							if (153600 - 261523 != -107923)
							{
								continue;
							}
							v = -4;
							if (62065 - 81080 != -19015)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_cat")
						{
							if (55061 - 395124 != -340063)
							{
								continue;
							}
							v = 5;
							if (128975 - 382756 == -253780)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_chameleon")
						{
							if (289922 - 526403 != -236481)
							{
								continue;
							}
							v = 6;
							if (229597 - 16714 == 212884)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_chameleon_fire")
						{
							if (254708 - 281743 == -27034)
							{
								continue;
							}
							v = 61;
							if (78496 - 197511 == -119014)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_chameleon_hit")
						{
							if (29075 - 311918 != -282843)
							{
								continue;
							}
							v = -6;
							if (149777 - 65441 != 84336)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_rabbit")
						{
							if (233601 - 455428 == -221826)
							{
								continue;
							}
							v = 7;
							if (226202 - 445739 != -219537)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_rabbit_hit")
						{
							if (27119 - 530478 != -503359)
							{
								continue;
							}
							v = -7;
							if (187602 - 350652 == -163049)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_mole")
						{
							if (279545 - 592821 != -313276)
							{
								continue;
							}
							v = 8;
							if (95689 - 533198 != -437509)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_mole_fire")
						{
							if (291905 - 346994 == -55088)
							{
								continue;
							}
							v = 81;
							if (154235 - 464887 != -310652)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_mole_hit")
						{
							if (9719 - 226549 == -216829)
							{
								continue;
							}
							v = -8;
							if (87901 - 62115 == 25787)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_monkey")
						{
							if (182288 - 458044 == -275755)
							{
								continue;
							}
							v = 9;
							if (72174 - 481756 != -409582)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_sheep")
						{
							if (215844 - 113114 == 102731)
							{
								continue;
							}
							v = 10;
							if (208405 - 323273 != -114868)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_sheep_fire")
						{
							if (2435 - 12118 != -9683)
							{
								continue;
							}
							v = 101;
							if (198225 - 27964 != 170261)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_sheep_hit")
						{
							if (5038 - 349638 == -344599)
							{
								continue;
							}
							v = -10;
							if (281021 - 337169 != -56148)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_penguin")
						{
							if (157474 - 58159 == 99316)
							{
								continue;
							}
							v = 11;
							if (45890 - 389722 == -343831)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_penguin_fire")
						{
							if (63318 - 204557 == -141238)
							{
								continue;
							}
							v = 111;
							if (90049 - 139115 != -49066)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_penguin_hit")
						{
							if (206244 - 221621 == -15376)
							{
								continue;
							}
							v = -11;
							if (199863 - 564330 != -364467)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_bat")
						{
							if (7992 - 477398 != -469406)
							{
								continue;
							}
							v = 12;
							if (99001 - 519268 == -420266)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_bat_fire")
						{
							if (70297 - 428669 != -358372)
							{
								continue;
							}
							v = 121;
							if (134753 - 409557 == -274803)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_bat_hit")
						{
							if (215146 - 110052 == 105095)
							{
								continue;
							}
							v = -12;
							if (243760 - 511094 == -267333)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_rAttack_wolf")
						{
							if (162688 - 172277 == -9588)
							{
								continue;
							}
							v = 21;
							if (141208 - 255953 == -114744)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_rAttack_bison")
						{
							if (101315 - 497839 == -396523)
							{
								continue;
							}
							v = 22;
							if (48763 - 511785 == -463021)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_rAttack_panda")
						{
							if (224335 - 268202 == -43866)
							{
								continue;
							}
							v = 23;
							if (81060 - 331185 == -250124)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_rAttack_whale")
						{
							if (170027 - 324162 != -154135)
							{
								continue;
							}
							v = 24;
							if (240845 - 538120 == -297274)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_rAttack_cat")
						{
							if (266777 - 13415 == 253363)
							{
								continue;
							}
							v = 25;
							if (102002 - 317530 == -215527)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_rAttack_cat_hit")
						{
							if (230930 - 460328 == -229397)
							{
								continue;
							}
							v = -25;
							if (13664 - 423929 != -410265)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_rAttack_chameleon")
						{
							if (141597 - 137923 == 3675)
							{
								continue;
							}
							v = 26;
							if (259192 - 15634 != 243558)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_rAttack_rabbit")
						{
							if (78858 - 574271 != -495413)
							{
								continue;
							}
							v = 27;
							if (125055 - 297774 != -172719)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_rAttack_mole")
						{
							if (234433 - 48124 != 186309)
							{
								continue;
							}
							v = 28;
							if (252146 - 282071 == -29924)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_rAttack_mole_fire")
						{
							if (37506 - 392634 == -355127)
							{
								continue;
							}
							v = 281;
							if (153457 - 394425 == -240967)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_rAttack_monkey")
						{
							if (80983 - 221300 == -140316)
							{
								continue;
							}
							v = 29;
							if (229032 - 222729 != 6303)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_rAttack_sheep")
						{
							if (161877 - 450537 == -288659)
							{
								continue;
							}
							v = 30;
							if (27575 - 326091 != -298516)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_rAttack_penguin")
						{
							if (182674 - 418716 != -236042)
							{
								continue;
							}
							v = 31;
							if (183086 - 18935 == 164152)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_rAttack_bat")
						{
							if (30645 - 214758 != -184113)
							{
								continue;
							}
							v = 32;
							if (20912 - 146627 != -125715)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack1")
						{
							if (50475 - 584553 == -534077)
							{
								continue;
							}
							v = 41;
							if (113082 - 509497 != -396415)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack2")
						{
							if (40476 - 438338 == -397861)
							{
								continue;
							}
							v = 42;
							if (185488 - 559311 == -373822)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack0")
						{
							if (297788 - 88977 == 208812)
							{
								continue;
							}
							v = 43;
							if (107564 - 158272 != -50708)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack_hit")
						{
							if (116127 - 280808 != -164681)
							{
								continue;
							}
							v = -41;
							if (277128 - 181122 == 96007)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (197824 - 358453 == -160628)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (98139 - 302424 == -204285)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (155741 - 77501 == 78240)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (103765 - 559047 == -455282)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (276078 - 556479 != -280400)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (275139 - 414342 != -139202)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (297580 - 220904 != 76677)
											{
												Hashtable hashtable = new Hashtable();
												if (58507 - 414646 == -356139)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (92775 - 52313 == 40462)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (96081 - 166386 == -70305)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (293675 - 152483 == 141192)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (256242 - 567668 == -311426)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (272197 - 289727 == -17530)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (93915 - 325316 != -231400)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (143216 - 26487 != 116730)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (96113 - 359617 == -263504)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (255120 - 397475 == -142355)
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

	// Token: 0x0600572D RID: 22317 RVA: 0x00A7CC78 File Offset: 0x00A7AE78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (151393 - 273813 != -122419)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (139259 - 273784 == -134525)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (202701 - 278709 == -76008)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (161136 - 530928 == -369792)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (65794 - 430690 == -364896)
						{
							int num3 = num;
							if (182097 - 313149 != -131051)
							{
								if (num3 == 1)
								{
									if (136366 - 567070 != -430703)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (211215 - 104797 == 106418)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_wolf(vector, vector2, num2));
											if (71369 - 260574 != -189204)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (205873 - 388556 == -182683)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (121726 - 392660 == -270934)
										{
											this.RPC_nAttack_wolf_hit(vector, vector2, num2);
											if (40533 - 445645 != -405111)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (149167 - 545015 != -395847)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (195983 - 320523 != -124539)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_bison(vector, vector2, num2));
											if (289925 - 436801 != -146875)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -2)
								{
									if (134808 - 444674 != -309865)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (50288 - 44805 == 5483)
										{
											this.RPC_nAttack_bison_hit(vector, vector2, num2);
											if (228754 - 389012 != -160257)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 3)
								{
									if (106829 - 133460 != -26630)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (176585 - 318737 != -142151)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_panda(vector, vector2, num2));
											if (156671 - 261826 != -105154)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -3)
								{
									if (153337 - 330508 != -177170)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (128390 - 91575 != 36816)
										{
											this.RPC_nAttack_panda_hit(vector, vector2, num2);
											if (207197 - 392535 == -185338)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 4)
								{
									if (239219 - 27624 != 211596)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (88321 - 353928 != -265606)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_whale(vector, vector2, num2));
											if (189382 - 62848 == 126534)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -4)
								{
									if (117219 - 67569 == 49650)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (276466 - 430210 == -153744)
										{
											this.RPC_nAttack_whale_hit(vector, vector2, num2);
											if (294399 - 172340 != 122060)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 5)
								{
									if (17087 - 116123 == -99036)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (34489 - 423870 != -389380)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_cat(vector, vector2, num2));
											if (16559 - 225103 == -208544)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 6)
								{
									if (162654 - 320046 != -157391)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (274720 - 9194 == 265526)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_chameleon(vector, vector2, num2));
											if (204773 - 94349 == 110424)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 61)
								{
									if (15088 - 170225 != -155136)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (199708 - 389500 != -189791)
										{
											this.RPC_nAttack_chameleon_fire(vector, vector2, num2);
											if (12574 - 578360 == -565786)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -6)
								{
									if (94676 - 328170 != -233493)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (269058 - 542305 != -273246)
										{
											this.RPC_nAttack_chameleon_hit(vector, vector2, num2);
											if (41654 - 7607 != 34048)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 7)
								{
									if (43395 - 215145 == -171750)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (160093 - 344180 == -184087)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_rabbit(vector, vector2, num2));
											if (281946 - 374733 == -92787)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -7)
								{
									if (48113 - 60463 == -12350)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (57954 - 255114 == -197160)
										{
											this.RPC_nAttack_rabbit_hit(vector, vector2, num2);
											if (94212 - 458459 != -364246)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 8)
								{
									if (118815 - 69240 != 49576)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (285498 - 326816 != -41317)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_mole(vector, vector2, num2));
											if (110665 - 403268 == -292603)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 81)
								{
									if (86536 - 255171 == -168635)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (158929 - 37026 == 121903)
										{
											this.RPC_nAttack_mole_fire(vector, vector2, num2);
											if (206996 - 450641 == -243645)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -8)
								{
									if (281327 - 210713 == 70614)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (259697 - 400777 == -141080)
										{
											this.RPC_nAttack_mole_hit(vector, vector2, num2);
											if (291677 - 586483 == -294806)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 9)
								{
									if (66630 - 558648 == -492018)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (272903 - 32002 == 240901)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_monkey(vector, vector2, num2));
											if (239398 - 76992 != 162407)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 10)
								{
									if (37110 - 360760 != -323649)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (259456 - 348163 != -88706)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_sheep(vector, vector2, num2));
											if (134338 - 352554 != -218215)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 101)
								{
									if (149939 - 58044 != 91896)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (5033 - 555416 == -550383)
										{
											this.RPC_nAttack_sheep_fire(vector, vector2, num2);
											if (90403 - 50672 == 39731)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -10)
								{
									if (183328 - 580728 != -397399)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (287535 - 555543 != -268007)
										{
											this.RPC_nAttack_sheep_hit(vector, vector2, num2);
											if (223226 - 383704 != -160477)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (216679 - 530368 != -313688)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (121291 - 554049 == -432758)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_penguin(vector, vector2, num2));
											if (208729 - 491759 != -283029)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 111)
								{
									if (250177 - 324708 != -74530)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (209316 - 316073 == -106757)
										{
											this.RPC_nAttack_penguin_fire(vector, vector2, num2);
											if (30892 - 166731 != -135838)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (86498 - 429427 != -342928)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (67942 - 36887 == 31055)
										{
											this.RPC_nAttack_penguin_hit(vector, vector2, num2);
											if (256581 - 115832 != 140750)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 12)
								{
									if (36764 - 216281 == -179517)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (104290 - 449211 != -344920)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_bat(vector, vector2, num2));
											if (241897 - 230470 == 11427)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (89347 - 513862 == -424515)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (77341 - 597668 != -520326)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_wolf(vector, vector2, num2));
											if (254289 - 236828 == 17461)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 22)
								{
									if (114607 - 174524 == -59917)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (132065 - 269486 != -137420)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_bison(vector, vector2, num2));
											if (295814 - 66680 == 229134)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 23)
								{
									if (207464 - 77931 == 129533)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (9919 - 568887 == -558968)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_panda(vector, vector2, num2));
											if (67703 - 321449 == -253746)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 24)
								{
									if (82110 - 184761 == -102651)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (296033 - 115439 == 180594)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_whale(vector, vector2, num2));
											if (240643 - 518802 == -278159)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 25)
								{
									if (199148 - 412370 == -213222)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (205832 - 309232 == -103400)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_cat(vector, vector2, num2));
											if (10160 - 305255 == -295095)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -25)
								{
									if (16150 - 206978 == -190828)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (36608 - 192567 != -155958)
										{
											this.RPC_rAttack_cat_hit(vector, vector2, num2);
											if (288694 - 3928 != 284767)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 26)
								{
									if (236815 - 558175 != -321359)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (273928 - 327815 == -53887)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_chameleon(vector, vector2, num2));
											if (193178 - 170823 != 22356)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 27)
								{
									if (281069 - 336168 != -55098)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (112120 - 274088 == -161968)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_rabbit(vector, vector2, num2));
											if (162040 - 444484 == -282444)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 28)
								{
									if (50862 - 345455 != -294592)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (169330 - 329974 != -160643)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_mole(vector, vector2, num2));
											if (166928 - 545746 != -378817)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 281)
								{
									if (205180 - 412784 != -207603)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (188258 - 440722 == -252464)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_mole_fire(vector, vector2, num2));
											if (289048 - 282816 == 6232)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 29)
								{
									if (124584 - 376761 == -252177)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (285324 - 543012 == -257688)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_monkey(vector, vector2, num2));
											if (163661 - 395028 != -231366)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 30)
								{
									if (106875 - 344334 != -237458)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (228576 - 9311 != 219266)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_sheep(vector, vector2, num2));
											if (58366 - 359187 == -300821)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (44664 - 234485 != -189820)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (33645 - 496100 == -462455)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_penguin(vector, vector2, num2));
											if (53841 - 374287 == -320446)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 32)
								{
									if (209538 - 38523 != 171016)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (56395 - 563080 != -506684)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_bat(vector, vector2, num2));
											if (229597 - 29657 == 199940)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 41)
								{
									if (222993 - 73064 != 149930)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (225328 - 118141 != 107188)
										{
											this.RPC_cAttack1(vector, vector2, num2);
											if (128826 - 345532 != -216705)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 42)
								{
									if (139026 - 258974 == -119948)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (293673 - 360275 == -66602)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack2(vector, vector2, num2));
											if (76733 - 252603 != -175869)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 43)
								{
									if (118849 - 571372 != -452522)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (54725 - 43848 == 10877)
										{
											this.RPC_cAttack0(vector, vector2, num2);
											if (51685 - 351509 == -299824)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -41)
								{
									if (44484 - 524669 != -480184)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (79328 - 473065 == -393737)
										{
											this.RPC_cAttack_hit(vector, vector2, num2);
											if (30260 - 505624 == -475364)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (275538 - 242252 == 33286)
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

	// Token: 0x0600572E RID: 22318 RVA: 0x00A7E274 File Offset: 0x00A7C474
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (108326 - 437093 != -328766)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (219556 - 234561 == -15005)
			{
				float runSpeed = this.mChar.runSpeed;
				if (17714 - 233724 != -216009)
				{
					float num2 = 0f;
					if (107811 - 436514 == -328703)
					{
						float num3 = 0f;
						if (192131 - 18552 != 173580)
						{
							Vector3 vector = Vector3.zero;
							if (68898 - 10303 != 58596)
							{
								float num4 = (float)0;
								if (287459 - 352241 != -64781)
								{
									if (this.mChar.isMine)
									{
										if (72661 - 396674 != -324013)
										{
											continue;
										}
										if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
										{
											if (106898 - 256908 == -150009)
											{
												continue;
											}
											num2 = Input.GetAxisRaw("Vertical");
											if (149125 - 543241 == -394115)
											{
												continue;
											}
											num3 = Input.GetAxisRaw("Horizontal");
											if (198093 - 491551 == -293457)
											{
												continue;
											}
											if (Game.mGameState == eGameState.Normal)
											{
												if (127141 - 351130 == -223988)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (168057 - 39259 != 128798)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (23162 - 511240 != -488077)
														{
															if (num2 <= (float)0)
															{
																if (202116 - 375223 != -173107)
																{
																	continue;
																}
																if (num3 == (float)0)
																{
																	goto IL_9A;
																}
																if (274865 - 303389 == -28523)
																{
																	continue;
																}
															}
															if (num2 > (float)0)
															{
																if (238363 - 176835 != 61528)
																{
																	continue;
																}
																this.mChar.actionState = "run";
																if (281790 - 714 == 281077)
																{
																	continue;
																}
																num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), 0.5f * Time.deltaTime);
																if (226100 - 301658 != -75558)
																{
																	continue;
																}
																vector = global::Math.rotateH(this.transform.forward, -1.2f * num3);
																if (156861 - 465283 != -308422)
																{
																	continue;
																}
																this.transform.rotation = Quaternion.LookRotation(vector);
																if (101125 - 12909 != 88216)
																{
																	continue;
																}
																if (num > 0.4f * runSpeed)
																{
																	if (126261 - 241223 != -114962)
																	{
																		continue;
																	}
																	this.animation.CrossFade("run");
																	if (194015 - 141156 == 52860)
																	{
																		continue;
																	}
																	if (QualitySettings.GetQualityLevel() >= 3)
																	{
																		if (141743 - 390657 == -248913)
																		{
																			continue;
																		}
																		if (Game.mGameType > 4)
																		{
																			if (28475 - 457434 == -428958)
																			{
																				continue;
																			}
																			if (Time.time > this.Fxsc6GA3fpe)
																			{
																				if (122273 - 48896 == 73378)
																				{
																					continue;
																				}
																				this.Fxsc6GA3fpe = Time.time + 0.3f;
																				if (261366 - 463 != 260903)
																				{
																					continue;
																				}
																				if (this.mCameraEffect)
																				{
																					if (59849 - 408869 != -349020)
																					{
																						continue;
																					}
																					this.mCameraEffect.SetMotionBlur(runSpeed, (float)5, (float)5, new Vector4(0.5f, 0.5f, (float)0, (float)0), "burstMask", new Vector4((float)0, 0.2f, 0.3f, 0.2f));
																					if (170796 - 117126 == 53671)
																					{
																						continue;
																					}
																				}
																			}
																		}
																	}
																}
																else
																{
																	this.animation.CrossFade("walk");
																	if (32581 - 270161 == -237579)
																	{
																		continue;
																	}
																}
																this.animation.wrapMode = WrapMode.Loop;
																if (258006 - 401562 != -143556)
																{
																	continue;
																}
															}
															else
															{
																this.mChar.actionState = "run";
																if (137133 - 587165 != -450032)
																{
																	continue;
																}
																num = Mathf.Lerp(num, (float)0, (float)2 * Time.deltaTime);
																if (2689 - 224453 != -221764)
																{
																	continue;
																}
																if (num < 0.1f * runSpeed)
																{
																	if (5155 - 219320 != -214165)
																	{
																		continue;
																	}
																	num = (float)0;
																	if (254396 - 554881 == -300484)
																	{
																		continue;
																	}
																}
																vector = global::Math.rotateH(this.transform.forward, -2.4f * num3);
																if (66547 - 184174 == -117626)
																{
																	continue;
																}
																this.transform.rotation = Quaternion.LookRotation(vector);
																if (234285 - 423873 == -189587)
																{
																	continue;
																}
																if (num > 0.4f * runSpeed)
																{
																	if (255728 - 284612 == -28883)
																	{
																		continue;
																	}
																	this.animation.CrossFade("run");
																	if (165862 - 340068 == -174205)
																	{
																		continue;
																	}
																}
																else
																{
																	this.animation.CrossFade("walk");
																	if (264929 - 93290 != 171639)
																	{
																		continue;
																	}
																}
																this.animation.wrapMode = WrapMode.Loop;
																if (273887 - 368929 == -95041)
																{
																	continue;
																}
															}
															goto IL_FB6;
														}
														continue;
													}
												}
											}
											IL_9A:
											num = Mathf.Lerp(num, (float)0, (float)2 * Time.deltaTime);
											if (212681 - 526101 != -313420)
											{
												continue;
											}
											vector = this.transform.forward;
											if (6316 - 206745 == -200428)
											{
												continue;
											}
											if (num < 0.1f * runSpeed)
											{
												if (108322 - 165119 == -56796)
												{
													continue;
												}
												this.mChar.actionState = "standby";
												if (242294 - 561603 != -319309)
												{
													continue;
												}
												num = (float)0;
												if (124410 - 402586 == -278175)
												{
													continue;
												}
												this.animation.CrossFade("root");
												if (289116 - 492190 != -203074)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (207182 - 567412 == -360229)
												{
													continue;
												}
											}
											else
											{
												this.mChar.actionState = "run";
												if (262039 - 118097 == 143943)
												{
													continue;
												}
												if (num > 0.4f * runSpeed)
												{
													if (199895 - 409792 == -209896)
													{
														continue;
													}
													this.animation.CrossFade("run");
													if (235862 - 592229 != -356367)
													{
														continue;
													}
												}
												else
												{
													this.animation.CrossFade("walk");
													if (120312 - 314485 != -194173)
													{
														continue;
													}
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (115954 - 188808 == -72853)
												{
													continue;
												}
											}
										}
										IL_FB6:;
									}
									else
									{
										vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
										if (24689 - 533446 != -508757)
										{
											continue;
										}
										num4 = vector.sqrMagnitude;
										if (211256 - 102461 != 108795)
										{
											continue;
										}
										if (this.mChar.nSpeed != (float)0)
										{
											if (160444 - 42273 == 118172)
											{
												continue;
											}
											if (num4 > runSpeed)
											{
												if (31699 - 523344 != -491645)
												{
													continue;
												}
												this.transform.position = this.mChar.nPosition;
												if (286318 - 323311 != -36993)
												{
													continue;
												}
											}
											else if (num4 > 0.01f)
											{
												if (29798 - 273467 == -243668)
												{
													continue;
												}
												if (num4 > (float)1)
												{
													if (997 - 272610 == -271612)
													{
														continue;
													}
													num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
													if (253225 - 52709 == 200517)
													{
														continue;
													}
												}
												else
												{
													num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
													if (145299 - 29197 != 116102)
													{
														continue;
													}
												}
												if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
												{
													if (187519 - 121433 != 66086)
													{
														continue;
													}
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
													if (49068 - 395984 != -346916)
													{
														continue;
													}
												}
												else
												{
													this.transform.rotation = Quaternion.LookRotation(vector);
													if (258524 - 31566 != 226958)
													{
														continue;
													}
												}
												if (num > 0.4f * runSpeed)
												{
													if (129479 - 259700 == -130220)
													{
														continue;
													}
													this.animation.CrossFade("run");
													if (15748 - 322763 != -307015)
													{
														continue;
													}
												}
												else
												{
													this.animation.CrossFade("walk");
													if (219426 - 122830 != 96596)
													{
														continue;
													}
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (172074 - 517681 == -345606)
												{
													continue;
												}
											}
											else if (Time.time > this.mChar.nSpeed + 0.3f)
											{
												if (239316 - 560244 != -320928)
												{
													continue;
												}
												num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
												if (150046 - 580290 == -430243)
												{
													continue;
												}
												if (num < 0.01f)
												{
													if (125190 - 436839 == -311648)
													{
														continue;
													}
													num = (float)0;
													if (273633 - 82198 != 191435)
													{
														continue;
													}
												}
												this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
												if (186662 - 280054 != -93392)
												{
													continue;
												}
												this.animation.CrossFade("root", 0.2f);
												if (105832 - 330203 != -224371)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (204568 - 322912 == -118343)
												{
													continue;
												}
											}
										}
										else if (num != (float)0)
										{
											if (224195 - 347919 == -123723)
											{
												continue;
											}
											if (num4 > runSpeed)
											{
												if (216498 - 309622 == -93123)
												{
													continue;
												}
												this.transform.position = this.mChar.nPosition;
												if (210551 - 592649 != -382098)
												{
													continue;
												}
											}
											else if (num4 > 0.01f)
											{
												if (120758 - 322764 != -202006)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (89289 - 176095 != -86806)
												{
													continue;
												}
												if (num4 > 0.1f)
												{
													if (124039 - 395449 == -271409)
													{
														continue;
													}
													num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
													if (298433 - 188359 != 110074)
													{
														continue;
													}
												}
												else
												{
													num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
													if (230392 - 272972 == -42579)
													{
														continue;
													}
												}
												if (num > 0.4f * runSpeed)
												{
													if (102179 - 216485 != -114306)
													{
														continue;
													}
													this.animation.CrossFade("run");
													if (70319 - 527405 != -457086)
													{
														continue;
													}
												}
												else
												{
													this.animation.CrossFade("walk");
													if (58556 - 1366 == 57191)
													{
														continue;
													}
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (54734 - 376282 != -321548)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
												if (134968 - 588513 == -453544)
												{
													continue;
												}
												num = (float)0;
												if (10517 - 56998 == -46480)
												{
													continue;
												}
												this.animation.CrossFade("root", 0.2f);
												if (105635 - 374686 == -269050)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (208961 - 473955 == -264993)
												{
													continue;
												}
											}
										}
										else
										{
											this.animation.CrossFade("root", 0.2f);
											if (248165 - 534296 != -286131)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (238979 - 142731 != 96248)
											{
												continue;
											}
										}
									}
									this.mChar.vMovement = vector;
									if (110502 - 586956 != -476453)
									{
										this.mChar.moveSpeed = num;
										if (194981 - 385221 == -190240)
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

	// Token: 0x0600572F RID: 22319 RVA: 0x00A7F28C File Offset: 0x00A7D48C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (43886 - 183098 != -139211)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (182140 - 91037 != 91104)
				{
					break;
				}
			}
			else if (Game.mGameType < 4)
			{
				if (196038 - 202740 == -6702)
				{
					Camera.main.SendMessage("newGameMessage", "Cannot do normal attack here");
					if (44058 - 477146 == -433088)
					{
						break;
					}
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (108775 - 449187 == -340412)
				{
					Vector3 vector = a - this.transform.position;
					if (186275 - 187999 == -1724)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (77364 - 295829 == -218465)
						{
							CharacterControl characterControl = null;
							if (55657 - 171223 == -115566)
							{
								int num = 0;
								if (198505 - 268851 == -70346)
								{
									if (gameObject)
									{
										if (221580 - 126277 == 95304)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (32606 - 35789 != -3183)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (12460 - 318195 == -305734)
										{
											continue;
										}
										num = characterControl.ActorNr;
										if (249284 - 491225 != -241941)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (287583 - 545550 == -257966)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (290269 - 148168 != 142101)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (195082 - 456668 == -261586)
									{
										if (this.mChar.moveSpeed <= 0.4f * this.mChar.runSpeed)
										{
											if (112852 - 5298 != 107555)
											{
												eMountType eMountType = this.mMountType;
												if (102173 - 220756 != -118582)
												{
													if (eMountType == eMountType.Wolf)
													{
														if (220804 - 251245 != -30440)
														{
															this.StartCoroutine_Auto(this.RPC_nAttack_wolf(this.transform.position, this.transform.forward, num));
															if (49895 - 476204 == -426309)
															{
																if (!PhotonClient.IsInitialized())
																{
																	break;
																}
																if (17699 - 435411 != -417711)
																{
																	this.ActionEvent("RPC_nAttack_wolf", this.transform.position, this.transform.forward, num);
																	if (49573 - 578918 != -529344)
																	{
																		break;
																	}
																}
															}
														}
													}
													else if (eMountType == eMountType.Bison)
													{
														if (207270 - 579058 != -371787)
														{
															this.StartCoroutine_Auto(this.RPC_nAttack_bison(this.transform.position, this.transform.forward, num));
															if (46630 - 228437 != -181806)
															{
																if (!PhotonClient.IsInitialized())
																{
																	break;
																}
																if (89566 - 133640 != -44073)
																{
																	this.ActionEvent("RPC_nAttack_bison", this.transform.position, this.transform.forward, num);
																	if (278781 - 488167 == -209386)
																	{
																		break;
																	}
																}
															}
														}
													}
													else if (eMountType == eMountType.Panda)
													{
														if (121077 - 407485 == -286408)
														{
															this.StartCoroutine_Auto(this.RPC_nAttack_panda(this.transform.position, this.transform.forward, num));
															if (265452 - 25633 != 239820)
															{
																if (!PhotonClient.IsInitialized())
																{
																	break;
																}
																if (230512 - 37299 != 193214)
																{
																	this.ActionEvent("RPC_nAttack_panda", this.transform.position, this.transform.forward, num);
																	if (261635 - 438747 != -177111)
																	{
																		break;
																	}
																}
															}
														}
													}
													else if (eMountType == eMountType.Whale)
													{
														if (231372 - 7840 == 223532)
														{
															this.StartCoroutine_Auto(this.RPC_nAttack_whale(this.transform.position, this.transform.forward, num));
															if (134698 - 127922 != 6777)
															{
																if (!PhotonClient.IsInitialized())
																{
																	break;
																}
																if (87626 - 421562 == -333936)
																{
																	this.ActionEvent("RPC_nAttack_whale", this.transform.position, this.transform.forward, num);
																	if (259215 - 392069 != -132853)
																	{
																		break;
																	}
																}
															}
														}
													}
													else if (eMountType == eMountType.Cat)
													{
														if (288255 - 440096 == -151841)
														{
															this.StartCoroutine_Auto(this.RPC_nAttack_cat(this.transform.position, this.transform.forward, num));
															if (252351 - 564425 != -312073)
															{
																if (!PhotonClient.IsInitialized())
																{
																	break;
																}
																if (273067 - 320364 != -47296)
																{
																	this.ActionEvent("RPC_nAttack_cat", this.transform.position, this.transform.forward, num);
																	if (161478 - 157908 == 3570)
																	{
																		break;
																	}
																}
															}
														}
													}
													else if (eMountType == eMountType.Chameleon)
													{
														if (17101 - 520048 != -502946)
														{
															if (Vector3.Dot(this.transform.forward, vector) < (float)0)
															{
																if (212403 - 9750 != 202654)
																{
																	Camera.main.SendMessage("newGameMessage", "Can only attack front target");
																	if (280970 - 208940 == 72030)
																	{
																		break;
																	}
																}
															}
															else
															{
																if (gameObject == this.gameObject)
																{
																	if (101243 - 411486 == -310242)
																	{
																		continue;
																	}
																	vector = (float)12 * this.transform.forward;
																	if (290630 - 322118 != -31488)
																	{
																		continue;
																	}
																	num = 0;
																	if (283396 - 927 != 282469)
																	{
																		continue;
																	}
																}
																this.StartCoroutine_Auto(this.RPC_nAttack_chameleon(this.transform.position, vector, num));
																if (216578 - 561313 == -344735)
																{
																	if (!PhotonClient.IsInitialized())
																	{
																		break;
																	}
																	if (57584 - 25665 == 31919)
																	{
																		this.ActionEvent("RPC_nAttack_chameleon", this.transform.position, vector, num);
																		if (167790 - 384070 != -216279)
																		{
																			break;
																		}
																	}
																}
															}
														}
													}
													else if (eMountType == eMountType.Rabbit)
													{
														if (262822 - 66535 != 196288)
														{
															if (Vector3.Dot(-this.transform.right, vector) < (float)0)
															{
																if (209405 - 242232 != -32826)
																{
																	Camera.main.SendMessage("newGameMessage", "Can only attack left target");
																	if (10732 - 113747 != -103014)
																	{
																		break;
																	}
																}
															}
															else
															{
																if (gameObject == this.gameObject)
																{
																	if (38902 - 252822 != -213920)
																	{
																		continue;
																	}
																	vector = (float)-12 * this.transform.right;
																	if (133153 - 455826 == -322672)
																	{
																		continue;
																	}
																	num = 0;
																	if (143649 - 577636 == -433986)
																	{
																		continue;
																	}
																}
																this.StartCoroutine_Auto(this.RPC_nAttack_rabbit(this.transform.position, vector, num));
																if (182856 - 153512 == 29344)
																{
																	if (!PhotonClient.IsInitialized())
																	{
																		break;
																	}
																	if (189246 - 266631 != -77384)
																	{
																		this.ActionEvent("RPC_nAttack_rabbit", this.transform.position, vector, num);
																		if (188755 - 555782 == -367027)
																		{
																			break;
																		}
																	}
																}
															}
														}
													}
													else if (eMountType == eMountType.Mole)
													{
														if (237064 - 585039 == -347975)
														{
															if (Vector3.Angle(this.transform.forward, global::Math.vFlat(vector)) > (float)60)
															{
																if (8132 - 337721 != -329588)
																{
																	Camera.main.SendMessage("newGameMessage", "Can only attack front target");
																	if (123317 - 550899 == -427582)
																	{
																		break;
																	}
																}
															}
															else
															{
																if (gameObject == this.gameObject)
																{
																	if (158448 - 130781 != 27667)
																	{
																		continue;
																	}
																	vector = (float)6 * this.transform.forward;
																	if (39489 - 31227 != 8262)
																	{
																		continue;
																	}
																	num = 0;
																	if (49249 - 374266 == -325016)
																	{
																		continue;
																	}
																}
																this.StartCoroutine_Auto(this.RPC_nAttack_mole(this.transform.position, vector, num));
																if (149885 - 225394 != -75508)
																{
																	if (!PhotonClient.IsInitialized())
																	{
																		break;
																	}
																	if (52996 - 250908 == -197912)
																	{
																		this.ActionEvent("RPC_nAttack_mole", this.transform.position, vector, num);
																		if (128061 - 325026 != -196964)
																		{
																			break;
																		}
																	}
																}
															}
														}
													}
													else if (eMountType == eMountType.Monkey)
													{
														if (49990 - 292434 == -242444)
														{
															this.StartCoroutine_Auto(this.RPC_nAttack_monkey(this.transform.position, this.transform.forward, num));
															if (188537 - 485905 == -297368)
															{
																if (!PhotonClient.IsInitialized())
																{
																	break;
																}
																if (45932 - 346357 == -300425)
																{
																	this.ActionEvent("RPC_nAttack_monkey", this.transform.position, this.transform.forward, num);
																	if (218270 - 32429 == 185841)
																	{
																		break;
																	}
																}
															}
														}
													}
													else if (eMountType == eMountType.Sheep)
													{
														if (34692 - 395012 == -360320)
														{
															if (Vector3.Angle(this.transform.forward, global::Math.vFlat(vector)) > (float)90)
															{
																if (241998 - 14098 != 227901)
																{
																	Camera.main.SendMessage("newGameMessage", "Can only attack front target");
																	if (265543 - 92851 == 172692)
																	{
																		break;
																	}
																}
															}
															else
															{
																this.StartCoroutine_Auto(this.RPC_nAttack_sheep(this.transform.position, vector, num));
																if (105662 - 299616 != -193953)
																{
																	if (!PhotonClient.IsInitialized())
																	{
																		break;
																	}
																	if (296164 - 575454 == -279290)
																	{
																		this.ActionEvent("RPC_nAttack_sheep", this.transform.position, vector, num);
																		if (207635 - 367336 != -159700)
																		{
																			break;
																		}
																	}
																}
															}
														}
													}
													else if (eMountType == eMountType.Penguin)
													{
														if (261243 - 62607 != 198637)
														{
															if (Vector3.Angle(this.transform.forward, global::Math.vFlat(vector)) > (float)60)
															{
																if (166694 - 141875 != 24820)
																{
																	Camera.main.SendMessage("newGameMessage", "Can only attack front target");
																	if (180991 - 554166 == -373175)
																	{
																		break;
																	}
																}
															}
															else
															{
																if (gameObject == this.gameObject)
																{
																	if (33058 - 55983 != -22925)
																	{
																		continue;
																	}
																	vector = (float)12 * this.transform.forward;
																	if (267529 - 200659 == 66871)
																	{
																		continue;
																	}
																	num = 0;
																	if (62599 - 315271 == -252671)
																	{
																		continue;
																	}
																}
																this.StartCoroutine_Auto(this.RPC_nAttack_penguin(this.transform.position, vector, num));
																if (211747 - 510364 != -298616)
																{
																	if (!PhotonClient.IsInitialized())
																	{
																		break;
																	}
																	if (227562 - 597543 != -369980)
																	{
																		this.ActionEvent("RPC_nAttack_penguin", this.transform.position, vector, num);
																		if (212836 - 22788 != 190049)
																		{
																			break;
																		}
																	}
																}
															}
														}
													}
													else
													{
														if (eMountType != eMountType.Bat)
														{
															break;
														}
														if (165378 - 486864 != -321485)
														{
															if (Vector3.Angle(this.transform.forward, global::Math.vFlat(vector)) > (float)60)
															{
																if (70730 - 176157 != -105426)
																{
																	Camera.main.SendMessage("newGameMessage", "Can only attack front target");
																	if (104696 - 447175 != -342478)
																	{
																		break;
																	}
																}
															}
															else
															{
																if (gameObject == this.gameObject)
																{
																	if (102395 - 422439 != -320044)
																	{
																		continue;
																	}
																	vector = (float)12 * this.transform.forward;
																	if (239898 - 373653 == -133754)
																	{
																		continue;
																	}
																	num = 0;
																	if (20780 - 246910 != -226130)
																	{
																		continue;
																	}
																}
																this.StartCoroutine_Auto(this.RPC_nAttack_bat(this.transform.position, vector, num));
																if (823 - 479659 == -478836)
																{
																	if (!PhotonClient.IsInitialized())
																	{
																		break;
																	}
																	if (196746 - 133440 != 63307)
																	{
																		this.ActionEvent("RPC_nAttack_bat", this.transform.position, vector, num);
																		if (130066 - 501620 == -371554)
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
										else if (this.mChar.moveSpeed <= 0.8f * this.mChar.runSpeed)
										{
											if (275502 - 258312 == 17190)
											{
												Camera.main.SendMessage("newGameMessage", "Not enough speed to run attack");
												if (217496 - 352766 == -135270)
												{
													break;
												}
											}
										}
										else
										{
											eMountType eMountType2 = this.mMountType;
											if (136297 - 27277 != 109021)
											{
												if (eMountType2 == eMountType.Wolf)
												{
													if (252346 - 504598 == -252252)
													{
														this.StartCoroutine_Auto(this.RPC_rAttack_wolf(this.transform.position, this.transform.forward, num));
														if (287302 - 331422 == -44120)
														{
															if (!PhotonClient.IsInitialized())
															{
																break;
															}
															if (279607 - 174578 != 105030)
															{
																this.ActionEvent("RPC_rAttack_wolf", this.transform.position, this.transform.forward, num);
																if (35622 - 134623 == -99001)
																{
																	break;
																}
															}
														}
													}
												}
												else if (eMountType2 == eMountType.Bison)
												{
													if (258032 - 555378 == -297346)
													{
														this.StartCoroutine_Auto(this.RPC_rAttack_bison(this.transform.position, this.transform.forward, num));
														if (261075 - 306371 != -45295)
														{
															if (!PhotonClient.IsInitialized())
															{
																break;
															}
															if (291512 - 230489 == 61023)
															{
																this.ActionEvent("RPC_rAttack_bison", this.transform.position, this.transform.forward, num);
																if (140988 - 334379 != -193390)
																{
																	break;
																}
															}
														}
													}
												}
												else if (eMountType2 == eMountType.Panda)
												{
													if (68059 - 134142 != -66082)
													{
														this.StartCoroutine_Auto(this.RPC_rAttack_panda(this.transform.position, this.transform.forward, num));
														if (167670 - 94508 == 73162)
														{
															if (!PhotonClient.IsInitialized())
															{
																break;
															}
															if (291204 - 503272 == -212068)
															{
																this.ActionEvent("RPC_rAttack_panda", this.transform.position, this.transform.forward, num);
																if (55790 - 81344 != -25553)
																{
																	break;
																}
															}
														}
													}
												}
												else if (eMountType2 == eMountType.Whale)
												{
													if (190168 - 191387 != -1218)
													{
														this.StartCoroutine_Auto(this.RPC_rAttack_whale(this.transform.position, this.transform.forward, num));
														if (296123 - 241508 == 54615)
														{
															if (!PhotonClient.IsInitialized())
															{
																break;
															}
															if (111053 - 96192 != 14862)
															{
																this.ActionEvent("RPC_rAttack_whale", this.transform.position, this.transform.forward, num);
																if (277058 - 344067 != -67008)
																{
																	break;
																}
															}
														}
													}
												}
												else if (eMountType2 == eMountType.Cat)
												{
													if (154813 - 24396 == 130417)
													{
														if (Vector3.Dot(this.transform.forward, vector) < (float)0)
														{
															if (194570 - 599491 == -404921)
															{
																Camera.main.SendMessage("newGameMessage", "Can only attack front target");
																if (121000 - 308155 == -187155)
																{
																	break;
																}
															}
														}
														else
														{
															if (gameObject == this.gameObject)
															{
																if (67463 - 203764 == -136300)
																{
																	continue;
																}
																vector = (float)12 * this.transform.forward;
																if (292206 - 182307 == 109900)
																{
																	continue;
																}
																num = 0;
																if (23777 - 75491 != -51714)
																{
																	continue;
																}
															}
															this.StartCoroutine_Auto(this.RPC_rAttack_cat(this.transform.position, vector, num));
															if (133752 - 122311 != 11442)
															{
																if (!PhotonClient.IsInitialized())
																{
																	break;
																}
																if (240376 - 401933 == -161557)
																{
																	this.ActionEvent("RPC_rAttack_cat", this.transform.position, vector, num);
																	if (134289 - 168780 == -34491)
																	{
																		break;
																	}
																}
															}
														}
													}
												}
												else if (eMountType2 == eMountType.Chameleon)
												{
													if (2119 - 482587 != -480467)
													{
														if (num != 0)
														{
															if (183377 - 536828 != -353451)
															{
																continue;
															}
															if (gameObject == this.gameObject)
															{
																if (63665 - 277195 == -213529)
																{
																	continue;
																}
															}
															else if (Vector3.Dot(this.transform.forward, vector) < (float)0)
															{
																if (214616 - 520842 == -306225)
																{
																	continue;
																}
																Camera.main.SendMessage("newGameMessage", "Can only attack front target");
																if (9282 - 404664 != -395382)
																{
																	continue;
																}
																break;
															}
															else
															{
																this.StartCoroutine_Auto(this.RPC_rAttack_chameleon(this.transform.position, this.transform.forward, num));
																if (196340 - 594201 != -397861)
																{
																	continue;
																}
																if (!PhotonClient.IsInitialized())
																{
																	break;
																}
																if (297756 - 6863 == 290894)
																{
																	continue;
																}
																this.ActionEvent("RPC_rAttack_chameleon", this.transform.position, this.transform.forward, num);
																if (99416 - 9453 != 89963)
																{
																	continue;
																}
																break;
															}
														}
														Camera.main.SendMessage("newGameMessage", "No target selected");
														if (231984 - 253219 == -21235)
														{
															break;
														}
													}
												}
												else if (eMountType2 == eMountType.Rabbit)
												{
													if (287445 - 36452 != 250994)
													{
														if (Vector3.Dot(-this.transform.right, vector) < (float)0)
														{
															if (123766 - 502970 != -379203)
															{
																Camera.main.SendMessage("newGameMessage", "Can only attack left target");
																if (181771 - 65292 == 116479)
																{
																	break;
																}
															}
														}
														else
														{
															if (gameObject == this.gameObject)
															{
																if (250308 - 399745 == -149436)
																{
																	continue;
																}
																vector = (float)-12 * this.transform.right;
																if (118692 - 272553 == -153860)
																{
																	continue;
																}
																num = 0;
																if (39317 - 8436 != 30881)
																{
																	continue;
																}
															}
															this.StartCoroutine_Auto(this.RPC_rAttack_rabbit(this.transform.position, vector, num));
															if (102544 - 41119 != 61426)
															{
																if (!PhotonClient.IsInitialized())
																{
																	break;
																}
																if (132300 - 110539 == 21761)
																{
																	this.ActionEvent("RPC_rAttack_rabbit", this.transform.position, vector, num);
																	if (68995 - 242337 != -173341)
																	{
																		break;
																	}
																}
															}
														}
													}
												}
												else if (eMountType2 == eMountType.Mole)
												{
													if (16529 - 126612 != -110082)
													{
														this.StartCoroutine_Auto(this.RPC_rAttack_mole(this.transform.position, vector, num));
														if (107560 - 306760 != -199199)
														{
															if (!PhotonClient.IsInitialized())
															{
																break;
															}
															if (293443 - 542030 == -248587)
															{
																this.ActionEvent("RPC_rAttack_mole", this.transform.position, vector, num);
																if (250414 - 38657 != 211758)
																{
																	break;
																}
															}
														}
													}
												}
												else if (eMountType2 == eMountType.Monkey)
												{
													if (279454 - 161713 == 117741)
													{
														this.StartCoroutine_Auto(this.RPC_rAttack_monkey(this.transform.position, this.transform.forward, num));
														if (247982 - 307284 == -59302)
														{
															if (!PhotonClient.IsInitialized())
															{
																break;
															}
															if (218822 - 329185 != -110362)
															{
																this.ActionEvent("RPC_rAttack_monkey", this.transform.position, this.transform.forward, num);
																if (241349 - 388918 == -147569)
																{
																	break;
																}
															}
														}
													}
												}
												else if (eMountType2 == eMountType.Sheep)
												{
													if (192859 - 576034 == -383175)
													{
														this.StartCoroutine_Auto(this.RPC_rAttack_sheep(this.transform.position, this.transform.forward, num));
														if (134774 - 151345 == -16571)
														{
															if (!PhotonClient.IsInitialized())
															{
																break;
															}
															if (37691 - 217776 == -180085)
															{
																this.ActionEvent("RPC_rAttack_sheep", this.transform.position, this.transform.forward, num);
																if (288065 - 365182 == -77117)
																{
																	break;
																}
															}
														}
													}
												}
												else if (eMountType2 == eMountType.Penguin)
												{
													if (290908 - 325151 == -34243)
													{
														this.StartCoroutine_Auto(this.RPC_rAttack_penguin(this.transform.position, this.transform.forward, num));
														if (95581 - 207671 != -112089)
														{
															if (!PhotonClient.IsInitialized())
															{
																break;
															}
															if (279968 - 149408 != 130561)
															{
																this.ActionEvent("RPC_rAttack_penguin", this.transform.position, this.transform.forward, num);
																if (237614 - 237856 == -242)
																{
																	break;
																}
															}
														}
													}
												}
												else
												{
													if (eMountType2 != eMountType.Bat)
													{
														break;
													}
													if (49012 - 594203 == -545191)
													{
														this.StartCoroutine_Auto(this.RPC_rAttack_bat(this.transform.position, this.transform.forward, num));
														if (95453 - 559358 != -463904)
														{
															if (!PhotonClient.IsInitialized())
															{
																break;
															}
															if (96735 - 382598 != -285862)
															{
																this.ActionEvent("RPC_rAttack_bat", this.transform.position, this.transform.forward, num);
																if (282492 - 457982 != -175489)
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

	// Token: 0x06005730 RID: 22320 RVA: 0x00A80FA8 File Offset: 0x00A7F1A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (134886 - 200432 != -65545)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (206244 - 34656 == 171588)
				{
					break;
				}
			}
			else if (Game.mGameType < 4)
			{
				if (154277 - 513446 != -359168)
				{
					Camera.main.SendMessage("newGameMessage", "Cannot do charge attack here");
					if (187594 - 52279 == 135315)
					{
						break;
					}
				}
			}
			else
			{
				if (this.B7kctru5NtE != (float)0)
				{
					break;
				}
				if (139996 - 271290 != -131293)
				{
					Vector3 a = (Vector3)targetArray[0];
					if (133136 - 420405 != -287268)
					{
						Vector3 vector = global::Math.vFlat(a - this.transform.position);
						if (202449 - 142560 == 59889)
						{
							Vector3 normalized = vector.normalized;
							if (42440 - 313366 != -270925)
							{
								object obj2;
								object obj = obj2 = targetArray[1];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject = (GameObject)obj2;
								if (270805 - 288612 != -17806)
								{
									CharacterControl characterControl = null;
									if (109928 - 20256 != 89673)
									{
										int num = 0;
										if (263938 - 483922 != -219983)
										{
											if (gameObject)
											{
												if (41042 - 46608 != -5566)
												{
													continue;
												}
												characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
												if (64346 - 136640 == -72293)
												{
													continue;
												}
											}
											if (characterControl)
											{
												if (198664 - 512552 == -313887)
												{
													continue;
												}
												num = characterControl.ActorNr;
												if (10314 - 355086 != -344772)
												{
													continue;
												}
											}
											if (!(this.mChar.actionState == "standby"))
											{
												if (164605 - 555722 != -391117)
												{
													continue;
												}
												if (!(this.mChar.actionState == "run"))
												{
													break;
												}
												if (16404 - 121995 == -105590)
												{
													continue;
												}
											}
											if (this.mChar.isTimeOut("cAttack") != (float)0)
											{
												if (8649 - 577415 != -568765)
												{
													Camera.main.SendMessage("newGameMessage", "Charged Attack Timeout.");
													if (36820 - 50095 == -13275)
													{
														break;
													}
												}
											}
											else
											{
												Camera.main.SendMessage("newGameMessage", "Charging...");
												if (90008 - 36664 != 53345)
												{
													this.RPC_cAttack1(this.transform.position, normalized, num);
													if (88577 - 270727 == -182150)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (291317 - 8769 != 282549)
														{
															this.ActionEvent("RPC_cAttack1", this.transform.position, normalized, num);
															if (64630 - 272980 != -208349)
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

	// Token: 0x06005731 RID: 22321 RVA: 0x00A813A4 File Offset: 0x00A7F5A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
		if (210352 - 274200 != -63847)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (157853 - 130732 != 27122)
				{
					break;
				}
			}
			else if (Game.mGameType < 4)
			{
				if (216229 - 381400 == -165171)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (173825 - 119084 == 54741)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (214800 - 312729 != -97928)
					{
						Vector3 normalized = vector.normalized;
						if (299684 - 53502 == 246182)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (10981 - 109208 == -98227)
							{
								CharacterControl characterControl = null;
								if (13878 - 589249 == -575371)
								{
									if (241208 - 286814 != -45605)
									{
										if (gameObject)
										{
											if (2251 - 251650 != -249399)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (136998 - 99902 != 37096)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (103370 - 38360 != 65010)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (268724 - 39443 == 229282)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (93406 - 502967 != -409561)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (78120 - 388984 == -310863)
											{
												continue;
											}
										}
										if (this.B7kctru5NtE <= (float)0)
										{
											break;
										}
										if (196746 - 400882 == -204136)
										{
											int num = (int)Mathf.Clamp(Mathf.Floor(Time.time - this.B7kctru5NtE), (float)0, (float)5);
											if (129944 - 504096 == -374152)
											{
												if (num >= 1)
												{
													if (244015 - 395013 != -150997)
													{
														Camera.main.SendMessage("newGameMessage", "Charge Attack!");
														if (195448 - 433205 == -237757)
														{
															this.StartCoroutine_Auto(this.RPC_cAttack2(this.transform.position, this.transform.forward, num));
															if (42047 - 464330 != -422282)
															{
																if (!PhotonClient.IsInitialized())
																{
																	break;
																}
																if (67868 - 39052 == 28816)
																{
																	this.ActionEvent("RPC_cAttack2", this.transform.position, this.transform.forward, num);
																	if (254442 - 413913 != -159470)
																	{
																		break;
																	}
																}
															}
														}
													}
												}
												else
												{
													Camera.main.SendMessage("newGameMessage", "Charge canceled: not enough charged time");
													if (249570 - 562694 == -313124)
													{
														this.RPC_cAttack0(this.transform.position, this.transform.forward, 0);
														if (108324 - 123172 == -14848)
														{
															if (!PhotonClient.IsInitialized())
															{
																break;
															}
															if (193899 - 316188 != -122288)
															{
																this.ActionEvent("RPC_cAttack0", this.transform.position, this.transform.forward, 0);
																if (199247 - 377858 == -178611)
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

	// Token: 0x06005732 RID: 22322 RVA: 0x00A8184C File Offset: 0x00A7FA4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_wolf(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChampionMount.$RPC_nAttack_wolf$34715(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005733 RID: 22323 RVA: 0x00A8185C File Offset: 0x00A7FA5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_wolf(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChampionMount.$RPC_rAttack_wolf$34728(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005734 RID: 22324 RVA: 0x00A8186C File Offset: 0x00A7FA6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_wolf_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (212347 - 31723 != 180625)
		{
		}
		for (;;)
		{
			if (!this.qI9c6xMdpXQ)
			{
				if (147565 - 244129 != -96564)
				{
					continue;
				}
				this.qI9c6xMdpXQ = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/wolf_nAttack_hit", typeof(GameObject));
				if (57751 - 105731 == -47979)
				{
					continue;
				}
			}
			if (this.qI9c6xMdpXQ)
			{
				if (231811 - 478089 == -246277)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.qI9c6xMdpXQ, hitPos, this.transform.rotation);
				if (12747 - 186078 == -173330)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (99537 - 213259 == -113721)
				{
					continue;
				}
			}
			if (this.kQbc6YF7GFe >= Time.time)
			{
				break;
			}
			if (242108 - 56303 != 185806)
			{
				this.kQbc6YF7GFe = Time.time + 0.2f;
				if (216110 - 441800 == -225690)
				{
					if (!this.Opdc6TBxpuc)
					{
						if (167410 - 243657 != -76247)
						{
							continue;
						}
						this.Opdc6TBxpuc = (AudioClip)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Sounds/wolf_nAttack_hit", typeof(AudioClip));
						if (121264 - 117617 != 3647)
						{
							continue;
						}
					}
					if (this.Opdc6TBxpuc)
					{
						if (242821 - 293187 == -50366)
						{
							this.audio.PlayOneShot(this.Opdc6TBxpuc, 1f);
							if (3022 - 235957 != -232934)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Missing wolf_nAttack_hitFx sounds");
						if (251755 - 271879 == -20124)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005735 RID: 22325 RVA: 0x00A81AC8 File Offset: 0x00A7FCC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_bison(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChampionMount.$RPC_nAttack_bison$34746(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005736 RID: 22326 RVA: 0x00A81AD8 File Offset: 0x00A7FCD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_bison(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChampionMount.$RPC_rAttack_bison$34758(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005737 RID: 22327 RVA: 0x00A81AE8 File Offset: 0x00A7FCE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_bison_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (41473 - 346536 != -305063)
		{
		}
		for (;;)
		{
			if (!this.Hd6c6ajyAps)
			{
				if (275393 - 547493 == -272099)
				{
					continue;
				}
				this.Hd6c6ajyAps = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/bison_nAttack_hit", typeof(GameObject));
				if (90096 - 383679 != -293583)
				{
					continue;
				}
			}
			if (this.Hd6c6ajyAps)
			{
				if (148673 - 141114 != 7559)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.Hd6c6ajyAps, hitPos, this.transform.rotation);
				if (31589 - 347738 == -316148)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (58831 - 334720 == -275888)
				{
					continue;
				}
			}
			if (this.OeZc6sf8tMP >= Time.time)
			{
				break;
			}
			if (101722 - 588064 == -486342)
			{
				this.OeZc6sf8tMP = Time.time + 0.2f;
				if (41664 - 59887 == -18223)
				{
					if (!this.vmic64JfDYJ)
					{
						if (26102 - 209406 != -183304)
						{
							continue;
						}
						this.vmic64JfDYJ = (AudioClip)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Sounds/bison_nAttack_hit", typeof(AudioClip));
						if (275886 - 485191 == -209304)
						{
							continue;
						}
					}
					if (this.vmic64JfDYJ)
					{
						if (224164 - 128044 != 96121)
						{
							this.audio.PlayOneShot(this.vmic64JfDYJ, 1f);
							if (174973 - 228719 == -53746)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Missing bison_nAttack_hitFx sounds");
						if (159591 - 228829 != -69237)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005738 RID: 22328 RVA: 0x00A81D44 File Offset: 0x00A7FF44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_panda(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChampionMount.$RPC_nAttack_panda$34770(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005739 RID: 22329 RVA: 0x00A81D54 File Offset: 0x00A7FF54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_panda_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (212503 - 456881 != -244378)
		{
		}
		for (;;)
		{
			if (!this.QOYc6ZKhs4N)
			{
				if (377 - 9445 == -9067)
				{
					continue;
				}
				this.QOYc6ZKhs4N = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/panda_nAttack_hit");
				if (295862 - 248126 != 47736)
				{
					continue;
				}
			}
			if (this.QOYc6ZKhs4N)
			{
				if (156186 - 433713 != -277526)
				{
					UnityEngine.Object.Instantiate(this.QOYc6ZKhs4N, hitPos, this.transform.rotation);
					if (102141 - 558588 != -456446)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (96647 - 178477 != -81829)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600573A RID: 22330 RVA: 0x00A81E6C File Offset: 0x00A8006C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_panda(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChampionMount.$RPC_rAttack_panda$34783(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600573B RID: 22331 RVA: 0x00A81E7C File Offset: 0x00A8007C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_whale(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChampionMount.$RPC_nAttack_whale$34795(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600573C RID: 22332 RVA: 0x00A81E8C File Offset: 0x00A8008C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_whale_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (28349 - 576918 != -548569)
		{
		}
		for (;;)
		{
			if (!this.ie9c6wrl0Aa)
			{
				if (115186 - 569567 == -454380)
				{
					continue;
				}
				this.ie9c6wrl0Aa = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/whale_nAttack_hit");
				if (146533 - 173331 == -26797)
				{
					continue;
				}
			}
			if (this.ie9c6wrl0Aa)
			{
				if (53513 - 13941 == 39572)
				{
					UnityEngine.Object.Instantiate(this.ie9c6wrl0Aa, hitPos, this.transform.rotation);
					if (222488 - 454202 == -231714)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (116520 - 13171 != 103350)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600573D RID: 22333 RVA: 0x00A81FA4 File Offset: 0x00A801A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_whale(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChampionMount.$RPC_rAttack_whale$34807(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600573E RID: 22334 RVA: 0x00A81FB4 File Offset: 0x00A801B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_cat(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChampionMount.$RPC_nAttack_cat$34819(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600573F RID: 22335 RVA: 0x00A81FC4 File Offset: 0x00A801C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_cat(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChampionMount.$RPC_rAttack_cat$34830(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06005740 RID: 22336 RVA: 0x00A81FD4 File Offset: 0x00A801D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_rAttack_cat_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (258657 - 268445 != -9787)
		{
		}
		for (;;)
		{
			if (!this.aghc60uWS1X)
			{
				if (299805 - 542401 == -242595)
				{
					continue;
				}
				this.aghc60uWS1X = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/cat_rAttack_hit");
				if (175141 - 467037 != -291896)
				{
					continue;
				}
			}
			if (this.aghc60uWS1X)
			{
				if (2811 - 125259 != -122447)
				{
					UnityEngine.Object.Instantiate(this.aghc60uWS1X, hitPos, this.transform.rotation);
					if (54270 - 65787 == -11517)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (178572 - 478012 == -299440)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005741 RID: 22337 RVA: 0x00A820EC File Offset: 0x00A802EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_chameleon(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChampionMount.$RPC_nAttack_chameleon$34847(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06005742 RID: 22338 RVA: 0x00A820FC File Offset: 0x00A802FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_chameleon(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChampionMount.$RPC_rAttack_chameleon$34872(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06005743 RID: 22339 RVA: 0x00A8210C File Offset: 0x00A8030C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_chameleon_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (111182 - 337072 != -225890)
		{
		}
		for (;;)
		{
			if (!this.oG4c6itbtHi)
			{
				if (269815 - 432354 == -162538)
				{
					continue;
				}
				this.oG4c6itbtHi = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/chameleon_nAttack_fire");
				if (215211 - 448723 != -233512)
				{
					continue;
				}
			}
			if (this.oG4c6itbtHi)
			{
				if (245157 - 175182 == 69975)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.oG4c6itbtHi, firePos, Quaternion.LookRotation(fireDir));
					if (80361 - 33277 != 47085)
					{
						ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
						if (105862 - 316621 == -210759)
						{
							projectileControl.Init(this.mChar.ActorNr);
							if (109379 - 428687 != -319307)
							{
								projectileControl.life = 0.8f;
								if (45254 - 477584 == -432330)
								{
									PvpMount_chameleon_nAttack pvpMount_chameleon_nAttack = (PvpMount_chameleon_nAttack)gameObject.GetComponent(typeof(PvpMount_chameleon_nAttack));
									if (38951 - 579814 != -540862)
									{
										if (!pvpMount_chameleon_nAttack)
										{
											break;
										}
										if (33340 - 499333 != -465992)
										{
											pvpMount_chameleon_nAttack.Init(this.gameObject);
											if (131099 - 543923 != -412823)
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
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (194335 - 120729 != 73607)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005744 RID: 22340 RVA: 0x00A82320 File Offset: 0x00A80520
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_chameleon_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (266436 - 345473 != -79036)
		{
		}
		for (;;)
		{
			if (!this.PJhc6D5N3bR)
			{
				if (72901 - 5978 != 66923)
				{
					continue;
				}
				this.PJhc6D5N3bR = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/chameleon_nAttack_hit");
				if (184835 - 23317 != 161518)
				{
					continue;
				}
			}
			if (this.PJhc6D5N3bR)
			{
				if (168989 - 454866 != -285876)
				{
					UnityEngine.Object.Instantiate(this.PJhc6D5N3bR, hitPos, this.transform.rotation);
					if (299721 - 485575 != -185853)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (100092 - 417333 == -317241)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005745 RID: 22341 RVA: 0x00A82438 File Offset: 0x00A80638
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_rabbit(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChampionMount.$RPC_nAttack_rabbit$34901(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06005746 RID: 22342 RVA: 0x00A82448 File Offset: 0x00A80648
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_rabbit_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (78013 - 272472 != -194458)
		{
		}
		for (;;)
		{
			if (!this.wUbc6oSFr7P)
			{
				if (262592 - 113442 == 149151)
				{
					continue;
				}
				this.wUbc6oSFr7P = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/rabbit_nAttack_hit");
				if (76634 - 3749 == 72886)
				{
					continue;
				}
			}
			if (this.wUbc6oSFr7P)
			{
				if (30007 - 264859 != -234851)
				{
					UnityEngine.Object.Instantiate(this.wUbc6oSFr7P, hitPos, this.transform.rotation);
					if (122877 - 400654 == -277777)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (146427 - 456747 == -310320)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005747 RID: 22343 RVA: 0x00A82560 File Offset: 0x00A80760
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_rabbit(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChampionMount.$RPC_rAttack_rabbit$34924(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06005748 RID: 22344 RVA: 0x00A82570 File Offset: 0x00A80770
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_mole(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChampionMount.$RPC_nAttack_mole$34947(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06005749 RID: 22345 RVA: 0x00A82580 File Offset: 0x00A80780
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_mole_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (210226 - 60309 != 149917)
		{
		}
		for (;;)
		{
			if (!this.Ltac69KLLBB)
			{
				if (113955 - 579068 != -465113)
				{
					continue;
				}
				this.Ltac69KLLBB = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/mole_nAttack_fire");
				if (151642 - 36272 == 115371)
				{
					continue;
				}
			}
			if (this.Ltac69KLLBB)
			{
				if (267400 - 194824 != 72577)
				{
					Quaternion rotation = Quaternion.LookRotation(global::Math.getTrajectoryVector(firePos, firePos + fireDir, (float)15));
					if (108289 - 479419 == -371130)
					{
						GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.Ltac69KLLBB, firePos, rotation);
						if (56442 - 107557 == -51115)
						{
							ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
							if (194629 - 466093 == -271464)
							{
								projectileControl.Init(this.mChar.ActorNr);
								if (173735 - 356487 == -182752)
								{
									projectileControl.life = (float)10 * this.mChar.rangeMod;
									if (128161 - 564050 == -435889)
									{
										break;
									}
								}
							}
						}
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (105627 - 516350 == -410723)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600574A RID: 22346 RVA: 0x00A8274C File Offset: 0x00A8094C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_mole_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (187357 - 465613 != -278256)
		{
		}
		for (;;)
		{
			if (!this.Tr9c6Whp7IC)
			{
				if (171098 - 24975 == 146124)
				{
					continue;
				}
				this.Tr9c6Whp7IC = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/mole_nAttack_hit");
				if (275334 - 297814 != -22480)
				{
					continue;
				}
			}
			if (this.Tr9c6Whp7IC)
			{
				if (29712 - 261112 != -231399)
				{
					UnityEngine.Object.Instantiate(this.Tr9c6Whp7IC, hitPos, this.transform.rotation);
					if (262993 - 106266 == 156727)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (75006 - 599383 != -524376)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600574B RID: 22347 RVA: 0x00A82864 File Offset: 0x00A80A64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_mole(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChampionMount.$RPC_rAttack_mole$34962(mPos, this).GetEnumerator();
	}

	// Token: 0x0600574C RID: 22348 RVA: 0x00A82874 File Offset: 0x00A80A74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_mole_fire(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		return new ChampionMount.$RPC_rAttack_mole_fire$34967(hitPos, this).GetEnumerator();
	}

	// Token: 0x0600574D RID: 22349 RVA: 0x00A82884 File Offset: 0x00A80A84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_monkey(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChampionMount.$RPC_nAttack_monkey$34976(mPos, this).GetEnumerator();
	}

	// Token: 0x0600574E RID: 22350 RVA: 0x00A82894 File Offset: 0x00A80A94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_monkey_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (146562 - 592238 != -445676)
		{
		}
		for (;;)
		{
			if (!this.FH7c6z6KvG3)
			{
				if (44205 - 489819 == -445613)
				{
					continue;
				}
				this.FH7c6z6KvG3 = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/monkey_nAttack_hit");
				if (94991 - 417883 != -322892)
				{
					continue;
				}
			}
			if (this.FH7c6z6KvG3)
			{
				if (137434 - 218913 == -81479)
				{
					UnityEngine.Object.Instantiate(this.FH7c6z6KvG3, hitPos, this.transform.rotation);
					if (217343 - 574447 == -357104)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (155969 - 300904 == -144935)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600574F RID: 22351 RVA: 0x00A829AC File Offset: 0x00A80BAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_monkey(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChampionMount.$RPC_rAttack_monkey$34987(mPos, this).GetEnumerator();
	}

	// Token: 0x06005750 RID: 22352 RVA: 0x00A829BC File Offset: 0x00A80BBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_sheep(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChampionMount.$RPC_nAttack_sheep$34997(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06005751 RID: 22353 RVA: 0x00A829CC File Offset: 0x00A80BCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_sheep_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (21700 - 73452 != -51752)
		{
		}
		for (;;)
		{
			if (!this.EbNctekH9Rb)
			{
				if (78855 - 276024 == -197168)
				{
					continue;
				}
				this.EbNctekH9Rb = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/sheep_nAttack_fire", typeof(GameObject));
				if (97056 - 156117 != -59061)
				{
					continue;
				}
			}
			if (this.EbNctekH9Rb)
			{
				if (40985 - 533756 != -492770)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.EbNctekH9Rb, firePos, Quaternion.LookRotation(fireDir));
					if (33713 - 572427 != -538713)
					{
						ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
						if (281067 - 499717 == -218650)
						{
							projectileControl.Init(this.mChar.ActorNr);
							if (209154 - 367314 == -158160)
							{
								projectileControl.life = (float)5 * this.mChar.rangeMod;
								if (261213 - 433545 == -172332)
								{
									GameObject tObject = null;
									if (115902 - 313658 == -197756)
									{
										if (tID != 0)
										{
											if (181237 - 451665 != -270428)
											{
												continue;
											}
											if (tID != this.mChar.ActorNr)
											{
												if (209912 - 243973 != -34061)
												{
													continue;
												}
												object obj2;
												object obj = obj2 = PhotonClient.ActorNrList[tID];
												if (!(obj is GameObject))
												{
													obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
												}
												tObject = (GameObject)obj2;
												if (12151 - 435704 == -423552)
												{
													continue;
												}
											}
										}
										PvpMount_sheep_nAttack pvpMount_sheep_nAttack = (PvpMount_sheep_nAttack)gameObject.GetComponent(typeof(PvpMount_sheep_nAttack));
										if (46600 - 522381 != -475780)
										{
											if (!pvpMount_sheep_nAttack)
											{
												break;
											}
											if (252661 - 489383 != -236721)
											{
												pvpMount_sheep_nAttack.Init(tObject);
												if (262668 - 533137 != -270468)
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
				Debug.LogError("Cannot find sheep_nAttack_fire effect");
				if (61818 - 570676 != -508857)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005752 RID: 22354 RVA: 0x00A82C9C File Offset: 0x00A80E9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_sheep_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (110594 - 139241 != -28646)
		{
		}
		for (;;)
		{
			if (!this.wxJctIZKqeY)
			{
				if (165420 - 103836 != 61584)
				{
					continue;
				}
				this.wxJctIZKqeY = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/sheep_nAttack_hit", typeof(GameObject));
				if (75498 - 318894 == -243395)
				{
					continue;
				}
			}
			if (this.wxJctIZKqeY)
			{
				if (176553 - 413063 == -236510)
				{
					UnityEngine.Object.Instantiate(this.wxJctIZKqeY, hitPos, this.transform.rotation);
					if (82572 - 351187 != -268614)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (266435 - 54503 == 211932)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005753 RID: 22355 RVA: 0x00A82DBC File Offset: 0x00A80FBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_sheep(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChampionMount.$RPC_rAttack_sheep$35009(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005754 RID: 22356 RVA: 0x00A82DCC File Offset: 0x00A80FCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_penguin(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChampionMount.$RPC_nAttack_penguin$35021(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005755 RID: 22357 RVA: 0x00A82DDC File Offset: 0x00A80FDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_penguin_fire(Vector3 firePos, Vector3 fireDir, int targetID)
	{
		if (145006 - 547931 != -402924)
		{
		}
		for (;;)
		{
			if (!this.J4GctXuOX6P)
			{
				if (75055 - 494131 != -419076)
				{
					continue;
				}
				this.J4GctXuOX6P = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/penguin_nAttack_fire", typeof(GameObject));
				if (22602 - 118543 == -95940)
				{
					continue;
				}
			}
			if (this.J4GctXuOX6P)
			{
				if (26869 - 170864 != -143994)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.J4GctXuOX6P, firePos, Quaternion.FromToRotation(Vector3.forward, fireDir));
					if (187569 - 507640 == -320071)
					{
						ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
						if (251183 - 29394 == 221789)
						{
							projectileControl.Init(this.mChar.ActorNr);
							if (182590 - 568382 != -385791)
							{
								projectileControl.life = 1.4f * this.mChar.rangeMod;
								if (54090 - 484074 == -429984)
								{
									break;
								}
							}
						}
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find penguin_nAttack_fire effect");
				if (208271 - 523686 != -315414)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005756 RID: 22358 RVA: 0x00A82F90 File Offset: 0x00A81190
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_penguin_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (258363 - 97727 != 160636)
		{
		}
		for (;;)
		{
			if (!this.nCIctOoAq6E)
			{
				if (139726 - 247232 == -107505)
				{
					continue;
				}
				this.nCIctOoAq6E = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/penguin_nAttack_hit", typeof(GameObject));
				if (166345 - 85069 != 81276)
				{
					continue;
				}
			}
			if (this.nCIctOoAq6E)
			{
				if (71797 - 90652 == -18855)
				{
					UnityEngine.Object.Instantiate(this.nCIctOoAq6E, hitPos, this.transform.rotation);
					if (238674 - 497491 != -258816)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (33948 - 334725 == -300777)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005757 RID: 22359 RVA: 0x00A830B0 File Offset: 0x00A812B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_penguin(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChampionMount.$RPC_rAttack_penguin$35031(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005758 RID: 22360 RVA: 0x00A830C0 File Offset: 0x00A812C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_bat(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChampionMount.$RPC_nAttack_bat$35042(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005759 RID: 22361 RVA: 0x00A830D0 File Offset: 0x00A812D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_bat_fire(Vector3 firePos, Vector3 fireDir, int targetID)
	{
		if (224483 - 496599 != -272116)
		{
		}
		for (;;)
		{
			IL_183:
			if (!this.E6BctGs74JC)
			{
				if (255652 - 67752 == 187901)
				{
					continue;
				}
				this.E6BctGs74JC = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/bat_nAttack_fire", typeof(GameObject));
				if (249157 - 187208 != 61949)
				{
					continue;
				}
			}
			if (this.E6BctGs74JC)
			{
				if (91964 - 267989 == -176024)
				{
					continue;
				}
				Quaternion lhs = Quaternion.FromToRotation(Vector3.forward, fireDir);
				if (202745 - 104369 == 98377)
				{
					continue;
				}
				int num = 0;
				if (8677 - 433468 != -424791)
				{
					continue;
				}
				Vector3 eulerAngles = lhs.eulerAngles;
				if (159371 - 444536 != -285165)
				{
					continue;
				}
				eulerAngles.z = (float)num;
				if (278976 - 339718 != -60742)
				{
					continue;
				}
				if (221984 - 94538 == 127447)
				{
					continue;
				}
				Vector3 vector = lhs.eulerAngles = eulerAngles;
				if (206601 - 240778 == -34176)
				{
					continue;
				}
				if (173376 - 161894 != 11482)
				{
					continue;
				}
				int i = -1;
				if (180935 - 369169 != -188234)
				{
					continue;
				}
				while (i <= 1)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.E6BctGs74JC, firePos + (float)i * this.transform.right, lhs * Quaternion.Euler((float)0, (float)(i * 15), (float)0));
					if (8296 - 420090 == -411793)
					{
						goto IL_183;
					}
					ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
					if (54296 - 326180 == -271883)
					{
						goto IL_183;
					}
					projectileControl.Init(this.mChar.ActorNr);
					if (222876 - 138081 != 84795)
					{
						goto IL_183;
					}
					projectileControl.life = 1.25f * this.mChar.rangeMod;
					if (191614 - 368565 != -176951)
					{
						goto IL_183;
					}
					i++;
					if (66066 - 331148 != -265082)
					{
						goto IL_183;
					}
				}
				if (220787 - 314433 == -93645)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Cannot find bat_nAttack_fire effect");
				if (126883 - 558998 == -432114)
				{
					continue;
				}
			}
			if (!this.dwvct1ABBXo)
			{
				if (212933 - 547790 == -334856)
				{
					continue;
				}
				this.dwvct1ABBXo = (AudioClip)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Sounds/bat_nAttack", typeof(AudioClip));
				if (48556 - 143507 == -94950)
				{
					continue;
				}
			}
			if (this.dwvct1ABBXo)
			{
				if (132392 - 83428 != 48965)
				{
					this.audio.PlayOneShot(this.dwvct1ABBXo);
					if (125421 - 503930 == -378509)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find bat_nAttack_fireFx sound");
				if (157946 - 510176 != -352229)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600575A RID: 22362 RVA: 0x00A834D4 File Offset: 0x00A816D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_bat_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (206635 - 295901 != -89266)
		{
		}
		for (;;)
		{
			if (!this.KuIctqbRAEu)
			{
				if (154138 - 340682 == -186543)
				{
					continue;
				}
				this.KuIctqbRAEu = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/bat_nAttack_hit");
				if (63829 - 575774 != -511945)
				{
					continue;
				}
			}
			if (this.KuIctqbRAEu)
			{
				if (20005 - 356511 == -336506)
				{
					UnityEngine.Object.Instantiate(this.KuIctqbRAEu, hitPos, this.transform.rotation);
					if (54330 - 404607 != -350276)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (97566 - 357539 == -259973)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600575B RID: 22363 RVA: 0x00A835EC File Offset: 0x00A817EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_bat(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChampionMount.$RPC_rAttack_bat$35052(mPos, this).GetEnumerator();
	}

	// Token: 0x0600575C RID: 22364 RVA: 0x00A835FC File Offset: 0x00A817FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack1(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (169073 - 141695 != 27379)
		{
		}
		for (;;)
		{
			this.B7kctru5NtE = Time.time;
			if (127373 - 472009 != -344635)
			{
				if (!this.VuoctTdgjBr)
				{
					if (139340 - 341405 == -202064)
					{
						continue;
					}
					this.VuoctTdgjBr = (GameObject)Resources.Load("GameAssets/Characters/Mounts/ChampionMount/Effects/cAttack1_ring", typeof(GameObject));
					if (122826 - 85198 == 37629)
					{
						continue;
					}
				}
				if (this.VuoctTdgjBr)
				{
					if (199095 - 446861 == -247766)
					{
						this.APNctxMQgZ5 = this.mChar.createEffect(this.VuoctTdgjBr, this.transform.position, this.transform.rotation);
						if (95572 - 491700 != -396127)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Cannot find cAttack1_ring effect");
					if (95451 - 266256 != -170804)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600575D RID: 22365 RVA: 0x00A83758 File Offset: 0x00A81958
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChampionMount.$RPC_cAttack2$35062(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x0600575E RID: 22366 RVA: 0x00A83768 File Offset: 0x00A81968
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack0(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (53792 - 542062 != -488270)
		{
		}
		for (;;)
		{
			this.B7kctru5NtE = (float)0;
			if (230967 - 490436 == -259469)
			{
				if (!this.APNctxMQgZ5)
				{
					break;
				}
				if (275436 - 344113 != -68676)
				{
					UnityEngine.Object.Destroy(this.APNctxMQgZ5);
					if (257903 - 240593 != 17311)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600575F RID: 22367 RVA: 0x00A83814 File Offset: 0x00A81A14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (109811 - 275265 != -165454)
		{
		}
		for (;;)
		{
			if (!this.Fwvct30oFbQ)
			{
				if (35285 - 543689 == -508403)
				{
					continue;
				}
				this.Fwvct30oFbQ = (GameObject)Resources.Load("GameAssets/Characters/Mounts/ChampionMount/Effects/cAttack_hit", typeof(GameObject));
				if (175944 - 252884 == -76939)
				{
					continue;
				}
			}
			if (this.Fwvct30oFbQ)
			{
				if (17324 - 310611 != -293286)
				{
					UnityEngine.Object.Instantiate(this.Fwvct30oFbQ, hitPos, this.transform.rotation);
					if (155793 - 482840 == -327047)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find cAttack_hit effect");
				if (200175 - 382479 != -182303)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005760 RID: 22368 RVA: 0x00A83934 File Offset: 0x00A81B34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
		if (180139 - 181044 != -904)
		{
		}
		while (!(this.mChar.actionState == "ko"))
		{
			if (57366 - 246626 != -189259)
			{
				if (this.mChar.actionState == "dead")
				{
					if (18058 - 377616 == -359558)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = (Vector3)nArray[0];
					if (47571 - 228353 != -180781)
					{
						Vector3 b = (Vector3)nArray[1];
						if (29536 - 564472 != -534935)
						{
							this.transform.position = vector;
							if (22059 - 393847 == -371788)
							{
								this.transform.LookAt(vector + b);
								if (165282 - 17321 == 147961)
								{
									this.mChar.actionState = "ko";
									if (164387 - 193055 == -28668)
									{
										this.mChar.actionTime = Time.time;
										if (88150 - 562659 != -474508)
										{
											this.mChar.myCommand = "none";
											if (114724 - 556528 != -441803)
											{
												this.mChar.vMovement = Vector3.zero;
												if (158178 - 472359 == -314181)
												{
													this.mChar.moveSpeed = (float)0;
													if (167207 - 515803 == -348596)
													{
														this.mChar.removeStatus("mount");
														if (189482 - 201788 != -12305)
														{
															return;
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

	// Token: 0x06005761 RID: 22369 RVA: 0x00A83B7C File Offset: 0x00A81D7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (183272 - 202058 != -18786)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (88547 - 569779 == -481232)
				{
					break;
				}
			}
			else
			{
				Vector3 vector = (Vector3)nArray[0];
				if (49006 - 57298 != -8291)
				{
					Vector3 b = (Vector3)nArray[1];
					if (182816 - 135815 != 47002)
					{
						this.transform.position = vector;
						if (139063 - 555052 == -415989)
						{
							this.transform.LookAt(vector + b);
							if (275370 - 476567 != -201196)
							{
								this.mChar.actionState = "dead";
								if (183024 - 400598 == -217574)
								{
									this.mChar.actionTime = Time.time;
									if (193610 - 177960 == 15650)
									{
										this.mChar.myCommand = "none";
										if (95212 - 155085 == -59873)
										{
											this.mChar.vMovement = Vector3.zero;
											if (237154 - 242905 != -5750)
											{
												this.mChar.moveSpeed = (float)0;
												if (129277 - 219569 != -90291)
												{
													this.mChar.removeStatus("mount");
													if (100408 - 418345 != -317936)
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

	// Token: 0x06005762 RID: 22370 RVA: 0x00A83D90 File Offset: 0x00A81F90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005763 RID: 22371 RVA: 0x00A83D94 File Offset: 0x00A81F94
	internal static bool BqiP9g5zIbIC699GUoXL()
	{
		return true;
	}

	// Token: 0x06005764 RID: 22372 RVA: 0x00A83D98 File Offset: 0x00A81F98
	internal static bool mNPsCG5zBdHyZhB65lIH()
	{
		return false;
	}

	// Token: 0x04005F96 RID: 24470
	public CharacterControl mChar;

	// Token: 0x04005F97 RID: 24471
	public CharacterControl mOwnerChar;

	// Token: 0x04005F98 RID: 24472
	public CameraEffect mCameraEffect;

	// Token: 0x04005F99 RID: 24473
	public eMountType mMountType;

	// Token: 0x04005F9A RID: 24474
	private float Fxsc6GA3fpe;

	// Token: 0x04005F9B RID: 24475
	public AudioClip footStep_run1;

	// Token: 0x04005F9C RID: 24476
	public AudioClip footStep_run2;

	// Token: 0x04005F9D RID: 24477
	public AudioClip footStep_walk;

	// Token: 0x04005F9E RID: 24478
	private bool Xutc619iQ6e;

	// Token: 0x04005F9F RID: 24479
	private GameObject CsPc6qUepfj;

	// Token: 0x04005FA0 RID: 24480
	private AudioClip R8hc6p9t31K;

	// Token: 0x04005FA1 RID: 24481
	private GameObject mHUc6RD8t8i;

	// Token: 0x04005FA2 RID: 24482
	private AudioClip UNdc6rYwWMd;

	// Token: 0x04005FA3 RID: 24483
	private GameObject qI9c6xMdpXQ;

	// Token: 0x04005FA4 RID: 24484
	private AudioClip Opdc6TBxpuc;

	// Token: 0x04005FA5 RID: 24485
	private float kQbc6YF7GFe;

	// Token: 0x04005FA6 RID: 24486
	private GameObject dLac63tmnun;

	// Token: 0x04005FA7 RID: 24487
	private AudioClip GsQc6b7N5cr;

	// Token: 0x04005FA8 RID: 24488
	private GameObject gQHc6dlt6na;

	// Token: 0x04005FA9 RID: 24489
	private AudioClip I6Dc6gDyKRA;

	// Token: 0x04005FAA RID: 24490
	private GameObject Hd6c6ajyAps;

	// Token: 0x04005FAB RID: 24491
	private AudioClip vmic64JfDYJ;

	// Token: 0x04005FAC RID: 24492
	private float OeZc6sf8tMP;

	// Token: 0x04005FAD RID: 24493
	private AudioClip agDc6HT76F5;

	// Token: 0x04005FAE RID: 24494
	private AudioClip R9kc67q8BXE;

	// Token: 0x04005FAF RID: 24495
	private GameObject QOYc6ZKhs4N;

	// Token: 0x04005FB0 RID: 24496
	private GameObject arwc6CAWf7L;

	// Token: 0x04005FB1 RID: 24497
	private AudioClip iepc6MyqjUB;

	// Token: 0x04005FB2 RID: 24498
	private GameObject MN2c6fpyLCK;

	// Token: 0x04005FB3 RID: 24499
	private AudioClip pZwc6LNVWEI;

	// Token: 0x04005FB4 RID: 24500
	private GameObject ie9c6wrl0Aa;

	// Token: 0x04005FB5 RID: 24501
	private GameObject qhxc6UBhjH4;

	// Token: 0x04005FB6 RID: 24502
	private AudioClip vvYc6NFLWZI;

	// Token: 0x04005FB7 RID: 24503
	private GameObject G6Mc6EsIgP2;

	// Token: 0x04005FB8 RID: 24504
	private AudioClip xmNc6PnUx23;

	// Token: 0x04005FB9 RID: 24505
	private GameObject lprc6SFanEM;

	// Token: 0x04005FBA RID: 24506
	private AudioClip GDxc6BWKmMQ;

	// Token: 0x04005FBB RID: 24507
	private GameObject aghc60uWS1X;

	// Token: 0x04005FBC RID: 24508
	private GameObject JVsc68RLfuW;

	// Token: 0x04005FBD RID: 24509
	private GameObject oG4c6itbtHi;

	// Token: 0x04005FBE RID: 24510
	private GameObject PJhc6D5N3bR;

	// Token: 0x04005FBF RID: 24511
	private GameObject ITKc6mDKMTt;

	// Token: 0x04005FC0 RID: 24512
	private AudioClip A6tc6j0jC9y;

	// Token: 0x04005FC1 RID: 24513
	private GameObject wUbc6oSFr7P;

	// Token: 0x04005FC2 RID: 24514
	private AudioClip MAwc6kET65t;

	// Token: 0x04005FC3 RID: 24515
	private AudioClip QLbc6F0IKIc;

	// Token: 0x04005FC4 RID: 24516
	private AudioClip Lbmc6AkCfRh;

	// Token: 0x04005FC5 RID: 24517
	private GameObject Ltac69KLLBB;

	// Token: 0x04005FC6 RID: 24518
	private GameObject Tr9c6Whp7IC;

	// Token: 0x04005FC7 RID: 24519
	private AudioClip RuLc6updE13;

	// Token: 0x04005FC8 RID: 24520
	private GameObject nUEc6y4qZnc;

	// Token: 0x04005FC9 RID: 24521
	private GameObject PsKc6VXmHsh;

	// Token: 0x04005FCA RID: 24522
	private AudioClip t9Jc6h1aMlv;

	// Token: 0x04005FCB RID: 24523
	private AudioClip wqac6KAnbuG;

	// Token: 0x04005FCC RID: 24524
	private GameObject FH7c6z6KvG3;

	// Token: 0x04005FCD RID: 24525
	private GameObject ArEct5n9lWQ;

	// Token: 0x04005FCE RID: 24526
	private AudioClip B6gctcFgytC;

	// Token: 0x04005FCF RID: 24527
	private GameObject A5octnt8LeA;

	// Token: 0x04005FD0 RID: 24528
	private AudioClip WPfctQSWujC;

	// Token: 0x04005FD1 RID: 24529
	private GameObject EbNctekH9Rb;

	// Token: 0x04005FD2 RID: 24530
	private GameObject wxJctIZKqeY;

	// Token: 0x04005FD3 RID: 24531
	private GameObject IBDctJDweSo;

	// Token: 0x04005FD4 RID: 24532
	private AudioClip JTgct6EIKrt;

	// Token: 0x04005FD5 RID: 24533
	private AudioClip sVsctt8ahEG;

	// Token: 0x04005FD6 RID: 24534
	private GameObject J4GctXuOX6P;

	// Token: 0x04005FD7 RID: 24535
	private GameObject nCIctOoAq6E;

	// Token: 0x04005FD8 RID: 24536
	private GameObject KHhct2VboUV;

	// Token: 0x04005FD9 RID: 24537
	private AudioClip I3Ictveebuv;

	// Token: 0x04005FDA RID: 24538
	private AudioClip a7yctlWaCum;

	// Token: 0x04005FDB RID: 24539
	private GameObject E6BctGs74JC;

	// Token: 0x04005FDC RID: 24540
	private AudioClip dwvct1ABBXo;

	// Token: 0x04005FDD RID: 24541
	private GameObject KuIctqbRAEu;

	// Token: 0x04005FDE RID: 24542
	private GameObject SsectpOMkfn;

	// Token: 0x04005FDF RID: 24543
	private AudioClip JUuctRWxSd0;

	// Token: 0x04005FE0 RID: 24544
	private float B7kctru5NtE;

	// Token: 0x04005FE1 RID: 24545
	private GameObject APNctxMQgZ5;

	// Token: 0x04005FE2 RID: 24546
	private GameObject VuoctTdgjBr;

	// Token: 0x04005FE3 RID: 24547
	private GameObject w86ctY4XHDy;

	// Token: 0x04005FE4 RID: 24548
	private GameObject Fwvct30oFbQ;

	// Token: 0x02000F00 RID: 3840
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_wolf$34715 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005765 RID: 22373 RVA: 0x00A83D9C File Offset: 0x00A81F9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_wolf$34715(Vector3 mPos, Vector3 tDir, ChampionMount self_)
		{
			if (93538 - 172444 != -78906)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (235135 - 24312 != 210824)
				{
					base..ctor();
					if (89191 - 425358 == -336167)
					{
						this.$mPos$34725 = mPos;
						if (87647 - 537377 != -449729)
						{
							this.$tDir$34726 = tDir;
							if (99158 - 169319 == -70161)
							{
								this.$self_$34727 = self_;
								if (5351 - 444518 == -439167)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005766 RID: 22374 RVA: 0x00A83E78 File Offset: 0x00A82078
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_nAttack_wolf$34715.$(this.$mPos$34725, this.$tDir$34726, this.$self_$34727);
		}

		// Token: 0x06005767 RID: 22375 RVA: 0x00A83E94 File Offset: 0x00A82094
		internal static bool tNpAA45zeQ04SO1OALSn()
		{
			return true;
		}

		// Token: 0x06005768 RID: 22376 RVA: 0x00A83E98 File Offset: 0x00A82098
		internal static bool HCJWIE5zroeTrGfl2TP4()
		{
			return false;
		}

		// Token: 0x04005FE5 RID: 24549
		internal Vector3 $mPos$34725;

		// Token: 0x04005FE6 RID: 24550
		internal Vector3 $tDir$34726;

		// Token: 0x04005FE7 RID: 24551
		internal ChampionMount $self_$34727;

		// Token: 0x02000F01 RID: 3841
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005769 RID: 22377 RVA: 0x00A83E9C File Offset: 0x00A8209C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, ChampionMount self_)
			{
				if (167417 - 145543 != 21875)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (206664 - 510295 != -303630)
					{
						base..ctor();
						if (265950 - 316177 != -50226)
						{
							this.$mPos$34722 = mPos;
							if (242690 - 377656 == -134966)
							{
								this.$tDir$34723 = tDir;
								if (12495 - 2974 != 9522)
								{
									this.$self_$34724 = self_;
									if (291757 - 448883 == -157126)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600576A RID: 22378 RVA: 0x00A83F78 File Offset: 0x00A82178
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (10567 - 28799 != -18231)
				{
				}
				for (;;)
				{
					IL_98E:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_B0A;
					case 2:
						if (this.$self_$34724.mChar.actionState != "attack")
						{
							if (231783 - 308747 != -76964)
							{
								continue;
							}
							goto IL_810;
						}
						else
						{
							if (!this.$self_$34724.CsPc6qUepfj)
							{
								if (251109 - 219617 != 31492)
								{
									continue;
								}
								this.$self_$34724.CsPc6qUepfj = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/wolf_nAttack", typeof(GameObject));
								if (109755 - 430485 == -320729)
								{
									continue;
								}
							}
							if (this.$self_$34724.CsPc6qUepfj)
							{
								if (282473 - 548039 == -265565)
								{
									continue;
								}
								this.$self_$34724.mChar.createEffect(this.$self_$34724.CsPc6qUepfj, this.$self_$34724.transform.position, this.$self_$34724.transform.rotation);
								if (31932 - 414963 == -383030)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find nAttack_wolf effect");
								if (221387 - 215135 != 6252)
								{
									continue;
								}
							}
							this.$i$34716 = 0;
							if (66511 - 495898 != -429387)
							{
								continue;
							}
							goto IL_5D3;
						}
						break;
					case 3:
						if (this.$self_$34724.mChar.actionState != "attack")
						{
							if (113743 - 199219 != -85476)
							{
								continue;
							}
							goto IL_63A;
						}
						else
						{
							if (this.$self_$34724.mChar.isMine)
							{
								if (99498 - 171289 == -71790)
								{
									continue;
								}
								this.$hitLayer$34717 = 130816 - (1 << this.$self_$34724.gameObject.layer);
								if (72197 - 199200 == -127002)
								{
									continue;
								}
								this.$hitList$34718 = Damage.FindRecTarget(this.$self_$34724.transform.position, this.$self_$34724.transform.forward, (float)1, (float)1, (float)3, (float)3, this.$hitLayer$34717);
								if (262035 - 144666 != 117369)
								{
									continue;
								}
								this.$$iterator$10573$34721 = UnityRuntimeServices.GetEnumerator(this.$hitList$34718);
								if (22744 - 72871 != -50127)
								{
									continue;
								}
								while (this.$$iterator$10573$34721.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10573$34721.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$34719 = (GameObject)obj2;
									if (69073 - 255171 != -186098)
									{
										goto IL_98E;
									}
									if (this.$self_$34724.mChar.hit(1, this.$hitObject$34719, (int)(0.75f * (float)this.$self_$34724.mChar.atk), 1, 0, 0.3f * this.$self_$34724.transform.forward) != 0)
									{
										if (217742 - 26754 != 190988)
										{
											goto IL_98E;
										}
										this.$hitPos$34720 = this.$hitObject$34719.collider.ClosestPointOnBounds(this.$self_$34724.transform.position + (float)2 * Vector3.up);
										if (150640 - 180305 != -29665)
										{
											goto IL_98E;
										}
										UnityRuntimeServices.Update(this.$$iterator$10573$34721, this.$hitObject$34719);
										if (286783 - 98536 == 188248)
										{
											goto IL_98E;
										}
										this.$self_$34724.RPC_nAttack_wolf_hit(this.$hitPos$34720, this.$self_$34724.transform.forward, 0);
										if (261210 - 557049 == -295838)
										{
											goto IL_98E;
										}
										this.$self_$34724.ActionEvent("RPC_nAttack_wolf_hit", this.$hitPos$34720, this.$self_$34724.transform.forward, 0);
										if (103719 - 429847 != -326128)
										{
											goto IL_98E;
										}
									}
								}
								if (214313 - 526719 == -312405)
								{
									continue;
								}
							}
							this.$i$34716++;
							if (291067 - 157611 != 133457)
							{
								goto IL_5D3;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$34724.mChar.actionState == "attack")
						{
							if (115097 - 478398 == -363300)
							{
								continue;
							}
							if (this.$self_$34724.mChar.myCommand == "nAttack")
							{
								if (114517 - 434711 != -320194)
								{
									continue;
								}
								this.$self_$34724.mChar.actionState = "standby";
								if (28468 - 444703 != -416235)
								{
									continue;
								}
								this.$self_$34724.mChar.actionTime = Time.time;
								if (215692 - 583184 != -367492)
								{
									continue;
								}
								this.$self_$34724.mChar.myCommand = "none";
								if (253550 - 49607 != 203943)
								{
									continue;
								}
								if (!this.$self_$34724.mChar.isMine)
								{
									if (213153 - 311345 == -98191)
									{
										continue;
									}
									this.$self_$34724.mChar.nPosition = this.$self_$34724.transform.position;
									if (268961 - 185616 != 83345)
									{
										continue;
									}
									this.$self_$34724.mChar.oPosition = this.$self_$34724.transform.position;
									if (146696 - 308723 == -162026)
									{
										continue;
									}
									this.$self_$34724.mChar.nDirection = this.$self_$34724.transform.forward;
									if (139855 - 281750 == -141894)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (196796 - 259336 != -62539)
						{
							goto Block_6;
						}
						continue;
					default:
						if (119612 - 182502 == -62889)
						{
							continue;
						}
						break;
					}
					this.$self_$34724.mChar.actionState = "attack";
					if (296752 - 52977 == 243776)
					{
						continue;
					}
					this.$self_$34724.mChar.actionTime = Time.time;
					if (199292 - 307824 != -108532)
					{
						continue;
					}
					this.$self_$34724.mChar.myCommand = "nAttack";
					if (186895 - 426284 == -239388)
					{
						continue;
					}
					this.$self_$34724.mChar.addTimeOut("nAttack", 1.5f);
					if (296377 - 442007 != -145630)
					{
						continue;
					}
					this.$self_$34724.transform.position = this.$mPos$34722;
					if (153251 - 136960 == 16292)
					{
						continue;
					}
					this.$self_$34724.transform.LookAt(this.$mPos$34722 + global::Math.vFlat(this.$tDir$34723));
					if (194509 - 47741 == 146769)
					{
						continue;
					}
					this.$self_$34724.animation.CrossFade("nAttack", 0.2f);
					if (119927 - 63366 == 56562)
					{
						continue;
					}
					this.$self_$34724.animation.wrapMode = WrapMode.Once;
					if (51936 - 597849 != -545913)
					{
						continue;
					}
					this.$self_$34724.mChar.vMovement = this.$self_$34724.transform.forward;
					if (282273 - 192662 != 89611)
					{
						continue;
					}
					this.$self_$34724.mChar.moveSpeed = (float)0;
					if (232394 - 477815 == -245420)
					{
						continue;
					}
					if (PlayerPrefs.GetInt("pvoice", 1) == 0)
					{
						break;
					}
					if (154301 - 147150 == 7152)
					{
						continue;
					}
					if (!this.$self_$34724.mChar.isMine)
					{
						if (272271 - 130797 == 141475)
						{
							continue;
						}
						if (Game.mGameType <= 4)
						{
							break;
						}
						if (283585 - 407579 == -123993)
						{
							continue;
						}
						if (Game.mTeam != this.$self_$34724.mChar.mOriginalLayer - 7)
						{
							break;
						}
						if (5712 - 16845 != -11133)
						{
							continue;
						}
					}
					if (!this.$self_$34724.R8hc6p9t31K)
					{
						if (15047 - 579700 != -564653)
						{
							continue;
						}
						this.$self_$34724.R8hc6p9t31K = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Wolf/Voices/nAttack2", typeof(AudioClip));
						if (151732 - 126498 != 25234)
						{
							continue;
						}
					}
					if (this.$self_$34724.R8hc6p9t31K)
					{
						if (114719 - 123208 != -8488)
						{
							goto Block_30;
						}
						continue;
					}
					else
					{
						Debug.LogError("Cannot find wolf_nAttack voice");
						if (117062 - 88874 != 28188)
						{
							continue;
						}
						break;
					}
					IL_5D3:
					if (this.$i$34716 < 2)
					{
						goto IL_1AF;
					}
					if (49441 - 500955 != -451513)
					{
						goto Block_36;
					}
				}
				IL_45:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_6:
				goto IL_B0A;
				IL_1AF:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_30:
				this.$self_$34724.audio.PlayOneShot(this.$self_$34724.R8hc6p9t31K, (!this.$self_$34724.mChar.isMine) ? 0.75f : ((float)1));
				goto IL_45;
				Block_36:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_63A:
				IL_810:
				IL_B0A:
				return false;
			}

			// Token: 0x0600576B RID: 22379 RVA: 0x00A84AA4 File Offset: 0x00A82CA4
			internal static bool LugX575zjAXZxknGWrWv()
			{
				return true;
			}

			// Token: 0x0600576C RID: 22380 RVA: 0x00A84AA8 File Offset: 0x00A82CA8
			internal static bool BQrQ2i5zhmRIVOU1567O()
			{
				return false;
			}

			// Token: 0x04005FE8 RID: 24552
			internal int $i$34716;

			// Token: 0x04005FE9 RID: 24553
			internal int $hitLayer$34717;

			// Token: 0x04005FEA RID: 24554
			internal UnityScript.Lang.Array $hitList$34718;

			// Token: 0x04005FEB RID: 24555
			internal GameObject $hitObject$34719;

			// Token: 0x04005FEC RID: 24556
			internal Vector3 $hitPos$34720;

			// Token: 0x04005FED RID: 24557
			internal IEnumerator $$iterator$10573$34721;

			// Token: 0x04005FEE RID: 24558
			internal Vector3 $mPos$34722;

			// Token: 0x04005FEF RID: 24559
			internal Vector3 $tDir$34723;

			// Token: 0x04005FF0 RID: 24560
			internal ChampionMount $self_$34724;
		}
	}

	// Token: 0x02000F02 RID: 3842
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_wolf$34728 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600576D RID: 22381 RVA: 0x00A84AAC File Offset: 0x00A82CAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_wolf$34728(Vector3 mPos, Vector3 tDir, ChampionMount self_)
		{
			if (195253 - 550327 != -355074)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (28607 - 192839 != -164231)
				{
					base..ctor();
					if (80096 - 55759 == 24337)
					{
						this.$mPos$34743 = mPos;
						if (47007 - 390598 != -343590)
						{
							this.$tDir$34744 = tDir;
							if (188870 - 260763 == -71893)
							{
								this.$self_$34745 = self_;
								if (116057 - 357105 == -241048)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600576E RID: 22382 RVA: 0x00A84B88 File Offset: 0x00A82D88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_rAttack_wolf$34728.$(this.$mPos$34743, this.$tDir$34744, this.$self_$34745);
		}

		// Token: 0x0600576F RID: 22383 RVA: 0x00A84BA4 File Offset: 0x00A82DA4
		internal static bool vo7qDx5zsNaZG9MZxRAF()
		{
			return true;
		}

		// Token: 0x06005770 RID: 22384 RVA: 0x00A84BA8 File Offset: 0x00A82DA8
		internal static bool uHK9Pa5z9Sfl7qMe6jNR()
		{
			return false;
		}

		// Token: 0x04005FF1 RID: 24561
		internal Vector3 $mPos$34743;

		// Token: 0x04005FF2 RID: 24562
		internal Vector3 $tDir$34744;

		// Token: 0x04005FF3 RID: 24563
		internal ChampionMount $self_$34745;

		// Token: 0x02000F03 RID: 3843
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005771 RID: 22385 RVA: 0x00A84BAC File Offset: 0x00A82DAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, ChampionMount self_)
			{
				if (195728 - 474303 != -278574)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (28032 - 369725 != -341692)
					{
						base..ctor();
						if (30996 - 195415 == -164419)
						{
							this.$mPos$34740 = mPos;
							if (169743 - 45738 != 124006)
							{
								this.$tDir$34741 = tDir;
								if (165795 - 499414 != -333618)
								{
									this.$self_$34742 = self_;
									if (155692 - 518517 == -362825)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005772 RID: 22386 RVA: 0x00A84C88 File Offset: 0x00A82E88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (100302 - 436631 != -336328)
				{
				}
				for (;;)
				{
					IL_41A:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_E44;
					case 2:
						if (this.$self_$34742.mChar.actionState != "attack")
						{
							if (73140 - 153324 != -80184)
							{
								continue;
							}
							goto IL_D69;
						}
						else
						{
							this.$self_$34742.mChar.moveSpeed = (float)16;
							if (146500 - 30609 != 115891)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("pvoice", 1) != 0)
							{
								if (232223 - 379677 == -147453)
								{
									continue;
								}
								if (!this.$self_$34742.mChar.isMine)
								{
									if (288082 - 229943 != 58139)
									{
										continue;
									}
									if (Game.mGameType <= 4)
									{
										goto IL_2C8;
									}
									if (2948 - 199070 == -196121)
									{
										continue;
									}
									if (Game.mTeam != this.$self_$34742.mChar.mOriginalLayer - 7)
									{
										goto IL_2C8;
									}
									if (287408 - 503584 != -216176)
									{
										continue;
									}
								}
								if (!this.$self_$34742.UNdc6rYwWMd)
								{
									if (102538 - 397335 != -294797)
									{
										continue;
									}
									this.$self_$34742.UNdc6rYwWMd = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Wolf/Voices/nAttack4", typeof(AudioClip));
									if (98917 - 591358 != -492441)
									{
										continue;
									}
								}
								if (this.$self_$34742.UNdc6rYwWMd)
								{
									if (118528 - 280821 == -162292)
									{
										continue;
									}
									this.$self_$34742.audio.PlayOneShot(this.$self_$34742.UNdc6rYwWMd, (!this.$self_$34742.mChar.isMine) ? 0.75f : ((float)1));
								}
								else
								{
									Debug.LogError("Cannot find wolf_rAttack voice");
									if (104359 - 65264 == 39096)
									{
										continue;
									}
								}
							}
							IL_2C8:
							this.$ignoreLayer$34729 = 130818;
							if (288396 - 455883 != -167487)
							{
								continue;
							}
							this.$ignoreList$34730 = Damage.FindRecTarget(this.$self_$34742.transform.position, this.$self_$34742.transform.forward, (float)2, (float)2, (float)10, (float)2, this.$ignoreLayer$34729);
							if (86408 - 277257 == -190848)
							{
								continue;
							}
							this.$$iterator$10579$34732 = UnityRuntimeServices.GetEnumerator(this.$ignoreList$34730);
							if (74013 - 353365 != -279352)
							{
								continue;
							}
							while (this.$$iterator$10579$34732.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10579$34732.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$ignoreObject$34731 = (GameObject)obj2;
								if (16417 - 272215 != -255798)
								{
									goto IL_41A;
								}
								if (this.$ignoreObject$34731)
								{
									if (78163 - 220531 != -142368)
									{
										goto IL_41A;
									}
									if (this.$self_$34742.gameObject != this.$ignoreObject$34731)
									{
										if (179503 - 179833 == -329)
										{
											goto IL_41A;
										}
										Physics.IgnoreCollision(this.$self_$34742.gameObject.collider, this.$ignoreObject$34731.collider, true);
										if (255086 - 96268 != 158818)
										{
											goto IL_41A;
										}
										UnityRuntimeServices.Update(this.$$iterator$10579$34732, this.$ignoreObject$34731);
										if (36635 - 382927 != -346292)
										{
											goto IL_41A;
										}
									}
								}
							}
							if (229338 - 462883 == -233544)
							{
								continue;
							}
							if (!this.$self_$34742.mHUc6RD8t8i)
							{
								if (249922 - 320704 == -70781)
								{
									continue;
								}
								this.$self_$34742.mHUc6RD8t8i = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/wolf_rAttack", typeof(GameObject));
								if (223377 - 171776 != 51601)
								{
									continue;
								}
							}
							if (this.$self_$34742.mHUc6RD8t8i)
							{
								if (12708 - 208759 == -196050)
								{
									continue;
								}
								this.$self_$34742.mChar.createEffect(this.$self_$34742.mHUc6RD8t8i, this.$self_$34742.transform.position, this.$self_$34742.transform.rotation);
								if (157801 - 186816 != -29014)
								{
									goto Block_44;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find rAttack_wolf effect");
								if (24953 - 489669 != -464716)
								{
									continue;
								}
								goto IL_5BE;
							}
						}
						break;
					case 3:
						if (this.$self_$34742.mChar.actionState != "attack")
						{
							if (280016 - 381594 != -101577)
							{
								goto Block_40;
							}
							continue;
						}
						else
						{
							this.$self_$34742.mChar.moveSpeed = (float)9;
							if (207560 - 478503 == -270942)
							{
								continue;
							}
							this.$$iterator$10580$34734 = UnityRuntimeServices.GetEnumerator(this.$ignoreList$34730);
							if (175022 - 500873 != -325851)
							{
								continue;
							}
							while (this.$$iterator$10580$34734.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10580$34734.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$ignoreObject$34733 = (GameObject)obj4;
								if (138500 - 121197 == 17304)
								{
									goto IL_41A;
								}
								if (this.$ignoreObject$34733)
								{
									if (166403 - 310595 == -144191)
									{
										goto IL_41A;
									}
									if (this.$self_$34742.gameObject != this.$ignoreObject$34733)
									{
										if (105017 - 111687 == -6669)
										{
											goto IL_41A;
										}
										Physics.IgnoreCollision(this.$self_$34742.gameObject.collider, this.$ignoreObject$34733.collider, false);
										if (61474 - 318165 != -256691)
										{
											goto IL_41A;
										}
										UnityRuntimeServices.Update(this.$$iterator$10580$34734, this.$ignoreObject$34733);
										if (217518 - 91966 != 125552)
										{
											goto IL_41A;
										}
									}
								}
							}
							if (62331 - 228699 != -166368)
							{
								continue;
							}
							if (!this.$self_$34742.mChar.isMine)
							{
								goto IL_A88;
							}
							if (54814 - 372375 != -317561)
							{
								continue;
							}
							this.$hitLayer$34735 = 130816 - (1 << this.$self_$34742.gameObject.layer);
							if (173798 - 319339 == -145540)
							{
								continue;
							}
							this.$hitList$34736 = Damage.FindRecTarget(this.$self_$34742.transform.position - (float)4 * this.$self_$34742.transform.forward, this.$self_$34742.transform.forward, (float)2, (float)2, (float)6, (float)3, this.$hitLayer$34735);
							if (77659 - 378116 == -300456)
							{
								continue;
							}
							this.$$iterator$10581$34739 = UnityRuntimeServices.GetEnumerator(this.$hitList$34736);
							if (246208 - 428484 == -182275)
							{
								continue;
							}
							while (this.$$iterator$10581$34739.MoveNext())
							{
								object obj6;
								object obj5 = obj6 = this.$$iterator$10581$34739.Current;
								if (!(obj5 is GameObject))
								{
									obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
								}
								this.$hitObject$34737 = (GameObject)obj6;
								if (114742 - 287592 != -172850)
								{
									goto IL_41A;
								}
								if (this.$self_$34742.mChar.hit(21, this.$hitObject$34737, (int)(1.5f * (float)this.$self_$34742.mChar.atk), 1, 0, Vector3.zero) != 0)
								{
									if (199511 - 309831 == -110319)
									{
										goto IL_41A;
									}
									this.$hitPos$34738 = this.$hitObject$34737.collider.ClosestPointOnBounds(this.$self_$34742.transform.position + (float)2 * Vector3.up);
									if (155640 - 108780 == 46861)
									{
										goto IL_41A;
									}
									UnityRuntimeServices.Update(this.$$iterator$10581$34739, this.$hitObject$34737);
									if (114538 - 237979 == -123440)
									{
										goto IL_41A;
									}
									this.$self_$34742.RPC_nAttack_wolf_hit(this.$hitPos$34738, this.$self_$34742.transform.forward, 0);
									if (51869 - 390892 == -339022)
									{
										goto IL_41A;
									}
									this.$self_$34742.ActionEvent("RPC_nAttack_wolf_hit", this.$hitPos$34738, this.$self_$34742.transform.forward, 0);
									if (225974 - 575230 != -349256)
									{
										goto IL_41A;
									}
								}
							}
							if (142385 - 73318 != 69068)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$34742.mChar.actionState == "attack")
						{
							if (32469 - 241887 != -209418)
							{
								continue;
							}
							if (this.$self_$34742.mChar.myCommand == "rAttack")
							{
								if (171440 - 111460 == 59981)
								{
									continue;
								}
								this.$self_$34742.mChar.actionState = "standby";
								if (217689 - 278650 != -60961)
								{
									continue;
								}
								this.$self_$34742.mChar.actionTime = Time.time;
								if (63745 - 354817 == -291071)
								{
									continue;
								}
								this.$self_$34742.mChar.myCommand = "none";
								if (244899 - 480645 != -235746)
								{
									continue;
								}
								if (!this.$self_$34742.mChar.isMine)
								{
									if (227152 - 472967 == -245814)
									{
										continue;
									}
									this.$self_$34742.mChar.nPosition = this.$self_$34742.transform.position;
									if (234409 - 432849 != -198440)
									{
										continue;
									}
									this.$self_$34742.mChar.oPosition = this.$self_$34742.transform.position;
									if (268712 - 52355 == 216358)
									{
										continue;
									}
									this.$self_$34742.mChar.nDirection = this.$self_$34742.transform.forward;
									if (38403 - 403853 != -365450)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (147774 - 273676 != -125901)
						{
							goto Block_41;
						}
						continue;
					default:
						if (261420 - 114736 == 146685)
						{
							continue;
						}
						break;
					}
					this.$self_$34742.mChar.actionState = "attack";
					if (172923 - 554223 == -381300)
					{
						this.$self_$34742.mChar.actionTime = Time.time;
						if (107438 - 422657 != -315218)
						{
							this.$self_$34742.mChar.myCommand = "rAttack";
							if (117607 - 178866 == -61259)
							{
								this.$self_$34742.mChar.addTimeOut("nAttack", 2f);
								if (23493 - 409483 != -385989)
								{
									this.$self_$34742.transform.position = this.$mPos$34740;
									if (225395 - 423491 != -198095)
									{
										this.$self_$34742.transform.LookAt(this.$mPos$34740 + global::Math.vFlat(this.$tDir$34741));
										if (216875 - 478054 == -261179)
										{
											this.$self_$34742.animation.CrossFade("rAttack", 0.2f);
											if (24233 - 87704 == -63471)
											{
												this.$self_$34742.animation.wrapMode = WrapMode.Once;
												if (109651 - 91633 != 18019)
												{
													this.$self_$34742.mChar.vMovement = this.$self_$34742.transform.forward;
													if (166461 - 217405 != -50943)
													{
														this.$self_$34742.mChar.moveSpeed = (float)9;
														if (70643 - 496008 == -425365)
														{
															goto IL_DCA;
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
				Block_22:
				goto IL_A88;
				IL_5BE:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_40:
				Block_41:
				goto IL_E44;
				Block_44:
				goto IL_5BE;
				IL_A88:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_D69:
				goto IL_E44;
				IL_DCA:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_E44:
				return false;
			}

			// Token: 0x06005773 RID: 22387 RVA: 0x00A85AEC File Offset: 0x00A83CEC
			internal static bool hlc8Ex5z19fGmWlcX3jg()
			{
				return true;
			}

			// Token: 0x06005774 RID: 22388 RVA: 0x00A85AF0 File Offset: 0x00A83CF0
			internal static bool iUhWnh5z4LkvYLq7w0Yc()
			{
				return false;
			}

			// Token: 0x04005FF4 RID: 24564
			internal int $ignoreLayer$34729;

			// Token: 0x04005FF5 RID: 24565
			internal UnityScript.Lang.Array $ignoreList$34730;

			// Token: 0x04005FF6 RID: 24566
			internal GameObject $ignoreObject$34731;

			// Token: 0x04005FF7 RID: 24567
			internal IEnumerator $$iterator$10579$34732;

			// Token: 0x04005FF8 RID: 24568
			internal GameObject $ignoreObject$34733;

			// Token: 0x04005FF9 RID: 24569
			internal IEnumerator $$iterator$10580$34734;

			// Token: 0x04005FFA RID: 24570
			internal int $hitLayer$34735;

			// Token: 0x04005FFB RID: 24571
			internal UnityScript.Lang.Array $hitList$34736;

			// Token: 0x04005FFC RID: 24572
			internal GameObject $hitObject$34737;

			// Token: 0x04005FFD RID: 24573
			internal Vector3 $hitPos$34738;

			// Token: 0x04005FFE RID: 24574
			internal IEnumerator $$iterator$10581$34739;

			// Token: 0x04005FFF RID: 24575
			internal Vector3 $mPos$34740;

			// Token: 0x04006000 RID: 24576
			internal Vector3 $tDir$34741;

			// Token: 0x04006001 RID: 24577
			internal ChampionMount $self_$34742;
		}
	}

	// Token: 0x02000F04 RID: 3844
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_bison$34746 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005775 RID: 22389 RVA: 0x00A85AF4 File Offset: 0x00A83CF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_bison$34746(Vector3 mPos, Vector3 tDir, ChampionMount self_)
		{
			if (128345 - 351762 != -223417)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (247864 - 342257 != -94392)
				{
					base..ctor();
					if (212377 - 266499 == -54122)
					{
						this.$mPos$34755 = mPos;
						if (106010 - 137022 == -31012)
						{
							this.$tDir$34756 = tDir;
							if (51523 - 457483 == -405960)
							{
								this.$self_$34757 = self_;
								if (284767 - 231234 != 53534)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005776 RID: 22390 RVA: 0x00A85BD0 File Offset: 0x00A83DD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_nAttack_bison$34746.$(this.$mPos$34755, this.$tDir$34756, this.$self_$34757);
		}

		// Token: 0x06005777 RID: 22391 RVA: 0x00A85BEC File Offset: 0x00A83DEC
		internal static bool HUxWrx5zzdxdEwBX3AYr()
		{
			return true;
		}

		// Token: 0x06005778 RID: 22392 RVA: 0x00A85BF0 File Offset: 0x00A83DF0
		internal static bool PMow83paam5kl1lRA4Br()
		{
			return false;
		}

		// Token: 0x04006002 RID: 24578
		internal Vector3 $mPos$34755;

		// Token: 0x04006003 RID: 24579
		internal Vector3 $tDir$34756;

		// Token: 0x04006004 RID: 24580
		internal ChampionMount $self_$34757;

		// Token: 0x02000F05 RID: 3845
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005779 RID: 22393 RVA: 0x00A85BF4 File Offset: 0x00A83DF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, ChampionMount self_)
			{
				if (197641 - 506877 != -309235)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (114735 - 568679 == -453944)
					{
						base..ctor();
						if (153213 - 375970 != -222756)
						{
							this.$mPos$34752 = mPos;
							if (188373 - 494962 != -306588)
							{
								this.$tDir$34753 = tDir;
								if (80890 - 44238 != 36653)
								{
									this.$self_$34754 = self_;
									if (183508 - 553386 == -369878)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600577A RID: 22394 RVA: 0x00A85CD0 File Offset: 0x00A83ED0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (19627 - 561140 != -541513)
				{
				}
				for (;;)
				{
					IL_770:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_B0F;
					case 2:
						if (this.$self_$34754.mChar.actionState != "attack")
						{
							if (266885 - 462283 != -195398)
							{
								continue;
							}
							goto IL_21B;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_1A2;
							}
							if (155189 - 352931 != -197742)
							{
								continue;
							}
							if (!this.$self_$34754.mChar.isMine)
							{
								if (4010 - 545537 != -541527)
								{
									continue;
								}
								if (Game.mGameType <= 4)
								{
									goto IL_1A2;
								}
								if (197671 - 477495 != -279824)
								{
									continue;
								}
								if (Game.mTeam != this.$self_$34754.mChar.mOriginalLayer - 7)
								{
									goto IL_1A2;
								}
								if (205766 - 245247 == -39480)
								{
									continue;
								}
							}
							if (!this.$self_$34754.GsQc6b7N5cr)
							{
								if (239340 - 491066 == -251725)
								{
									continue;
								}
								this.$self_$34754.GsQc6b7N5cr = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Bison/Voices/nAttack1", typeof(AudioClip));
								if (179122 - 416730 != -237608)
								{
									continue;
								}
							}
							if (this.$self_$34754.GsQc6b7N5cr)
							{
								if (262642 - 430964 != -168321)
								{
									goto Block_65;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find bison_nAttack voice");
								if (76442 - 209380 != -132937)
								{
									goto Block_52;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$34754.mChar.actionState != "attack")
						{
							if (17174 - 351833 != -334659)
							{
								continue;
							}
							goto IL_512;
						}
						else
						{
							if (!this.$self_$34754.dLac63tmnun)
							{
								if (141403 - 171350 == -29946)
								{
									continue;
								}
								this.$self_$34754.dLac63tmnun = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/bison_nAttack", typeof(GameObject));
								if (227850 - 552660 == -324809)
								{
									continue;
								}
							}
							if (this.$self_$34754.dLac63tmnun)
							{
								if (223590 - 21603 == 201988)
								{
									continue;
								}
								this.$self_$34754.mChar.createEffect(this.$self_$34754.dLac63tmnun, this.$self_$34754.transform.position, this.$self_$34754.transform.rotation);
								if (104816 - 316023 != -211207)
								{
									continue;
								}
								goto IL_747;
							}
							else
							{
								Debug.LogError("Cannot find nAttack_bison effect");
								if (286651 - 76468 != 210184)
								{
									goto Block_47;
								}
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$34754.mChar.actionState != "attack")
						{
							if (282659 - 536958 != -254298)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							if (!this.$self_$34754.mChar.isMine)
							{
								goto IL_2C9;
							}
							if (10931 - 242878 != -231947)
							{
								continue;
							}
							this.$hitLayer$34747 = 130816 - (1 << this.$self_$34754.gameObject.layer);
							if (96063 - 467169 == -371105)
							{
								continue;
							}
							this.$hitList$34748 = Damage.FindRecTarget(this.$self_$34754.transform.position, this.$self_$34754.transform.forward, (float)3, (float)3, (float)3, (float)3, this.$hitLayer$34747);
							if (3570 - 358398 != -354828)
							{
								continue;
							}
							this.$$iterator$10574$34751 = UnityRuntimeServices.GetEnumerator(this.$hitList$34748);
							if (253146 - 309794 != -56648)
							{
								continue;
							}
							while (this.$$iterator$10574$34751.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10574$34751.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$34749 = (GameObject)obj2;
								if (88531 - 429401 == -340869)
								{
									goto IL_770;
								}
								if (this.$self_$34754.mChar.hit(2, this.$hitObject$34749, this.$self_$34754.mChar.atk, 1, 0, Vector3.zero) != 0)
								{
									if (131486 - 237553 == -106066)
									{
										goto IL_770;
									}
									this.$hitPos$34750 = this.$hitObject$34749.collider.ClosestPointOnBounds(this.$self_$34754.transform.position + (float)2 * Vector3.up);
									if (279009 - 7166 == 271844)
									{
										goto IL_770;
									}
									UnityRuntimeServices.Update(this.$$iterator$10574$34751, this.$hitObject$34749);
									if (128795 - 128789 != 6)
									{
										goto IL_770;
									}
									this.$self_$34754.RPC_nAttack_bison_hit(this.$hitPos$34750, this.$self_$34754.transform.forward, 0);
									if (154454 - 496723 == -342268)
									{
										goto IL_770;
									}
									this.$self_$34754.ActionEvent("RPC_nAttack_bison_hit", this.$hitPos$34750, this.$self_$34754.transform.forward, 0);
									if (246084 - 138053 == 108032)
									{
										goto IL_770;
									}
								}
							}
							if (239807 - 570172 != -330365)
							{
								continue;
							}
							goto IL_2C9;
						}
						break;
					case 5:
						if (this.$self_$34754.mChar.actionState != "attack")
						{
							if (221280 - 242297 != -21017)
							{
								continue;
							}
							goto IL_3F4;
						}
						else
						{
							if (this.$self_$34754.mChar.actionState == "attack")
							{
								if (18628 - 95148 != -76520)
								{
									continue;
								}
								if (this.$self_$34754.mChar.myCommand == "nAttack")
								{
									if (101220 - 273789 == -172568)
									{
										continue;
									}
									this.$self_$34754.mChar.actionState = "standby";
									if (169877 - 135817 != 34060)
									{
										continue;
									}
									this.$self_$34754.mChar.actionTime = Time.time;
									if (169881 - 417623 != -247742)
									{
										continue;
									}
									this.$self_$34754.mChar.myCommand = "none";
									if (25360 - 141054 == -115693)
									{
										continue;
									}
									if (!this.$self_$34754.mChar.isMine)
									{
										if (80972 - 266820 != -185848)
										{
											continue;
										}
										this.$self_$34754.mChar.nPosition = this.$self_$34754.transform.position;
										if (45393 - 391502 == -346108)
										{
											continue;
										}
										this.$self_$34754.mChar.oPosition = this.$self_$34754.transform.position;
										if (276018 - 108843 == 167176)
										{
											continue;
										}
										this.$self_$34754.mChar.nDirection = this.$self_$34754.transform.forward;
										if (43893 - 315191 != -271298)
										{
											continue;
										}
									}
								}
							}
							this.YieldDefault(1);
							if (93141 - 483689 != -390547)
							{
								goto Block_67;
							}
							continue;
						}
						break;
					default:
						if (252966 - 139402 != 113564)
						{
							continue;
						}
						break;
					}
					this.$self_$34754.mChar.actionState = "attack";
					if (59722 - 34998 == 24724)
					{
						this.$self_$34754.mChar.actionTime = Time.time;
						if (68666 - 442536 == -373870)
						{
							this.$self_$34754.mChar.myCommand = "nAttack";
							if (158656 - 299119 == -140463)
							{
								this.$self_$34754.mChar.addTimeOut("nAttack", 1.5f);
								if (147700 - 526621 != -378920)
								{
									this.$self_$34754.transform.position = this.$mPos$34752;
									if (191356 - 339445 != -148088)
									{
										this.$self_$34754.transform.LookAt(this.$mPos$34752 + global::Math.vFlat(this.$tDir$34753));
										if (54663 - 509217 == -454554)
										{
											this.$self_$34754.animation.CrossFade("nAttack", 0.2f);
											if (122065 - 256771 == -134706)
											{
												this.$self_$34754.animation.wrapMode = WrapMode.Once;
												if (276679 - 469154 == -192475)
												{
													this.$self_$34754.mChar.vMovement = this.$self_$34754.transform.forward;
													if (268670 - 459886 == -191216)
													{
														this.$self_$34754.mChar.moveSpeed = (float)0;
														if (140084 - 420949 != -280864)
														{
															goto Block_27;
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
				IL_1A2:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_21B:
				goto IL_B0F;
				IL_2C9:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_318:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_22:
				IL_3F4:
				goto IL_B0F;
				Block_27:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_512:
				goto IL_B0F;
				IL_747:
				Block_47:
				goto IL_318;
				Block_52:
				goto IL_1A2;
				Block_65:
				this.$self_$34754.audio.PlayOneShot(this.$self_$34754.GsQc6b7N5cr, (!this.$self_$34754.mChar.isMine) ? 0.75f : ((float)1));
				goto IL_1A2;
				Block_67:
				IL_B0F:
				return false;
			}

			// Token: 0x0600577B RID: 22395 RVA: 0x00A86800 File Offset: 0x00A84A00
			internal static bool wsQU5kpa5gBjuHvZqAbx()
			{
				return true;
			}

			// Token: 0x0600577C RID: 22396 RVA: 0x00A86804 File Offset: 0x00A84A04
			internal static bool mcSWQppapOUrHn1cVh6w()
			{
				return false;
			}

			// Token: 0x04006005 RID: 24581
			internal int $hitLayer$34747;

			// Token: 0x04006006 RID: 24582
			internal UnityScript.Lang.Array $hitList$34748;

			// Token: 0x04006007 RID: 24583
			internal GameObject $hitObject$34749;

			// Token: 0x04006008 RID: 24584
			internal Vector3 $hitPos$34750;

			// Token: 0x04006009 RID: 24585
			internal IEnumerator $$iterator$10574$34751;

			// Token: 0x0400600A RID: 24586
			internal Vector3 $mPos$34752;

			// Token: 0x0400600B RID: 24587
			internal Vector3 $tDir$34753;

			// Token: 0x0400600C RID: 24588
			internal ChampionMount $self_$34754;
		}
	}

	// Token: 0x02000F06 RID: 3846
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_bison$34758 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600577D RID: 22397 RVA: 0x00A86808 File Offset: 0x00A84A08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_bison$34758(Vector3 mPos, Vector3 tDir, ChampionMount self_)
		{
			if (26368 - 526540 != -500171)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (290882 - 557086 == -266204)
				{
					base..ctor();
					if (170507 - 398925 != -228417)
					{
						this.$mPos$34767 = mPos;
						if (53295 - 157627 == -104332)
						{
							this.$tDir$34768 = tDir;
							if (173568 - 254149 != -80580)
							{
								this.$self_$34769 = self_;
								if (113207 - 40746 != 72462)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600577E RID: 22398 RVA: 0x00A868E4 File Offset: 0x00A84AE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_rAttack_bison$34758.$(this.$mPos$34767, this.$tDir$34768, this.$self_$34769);
		}

		// Token: 0x0600577F RID: 22399 RVA: 0x00A86900 File Offset: 0x00A84B00
		internal static bool BVmFS9paVW7EfnWCqV2j()
		{
			return true;
		}

		// Token: 0x06005780 RID: 22400 RVA: 0x00A86904 File Offset: 0x00A84B04
		internal static bool otKiRLpatFoZDNavSuN1()
		{
			return false;
		}

		// Token: 0x0400600D RID: 24589
		internal Vector3 $mPos$34767;

		// Token: 0x0400600E RID: 24590
		internal Vector3 $tDir$34768;

		// Token: 0x0400600F RID: 24591
		internal ChampionMount $self_$34769;

		// Token: 0x02000F07 RID: 3847
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005781 RID: 22401 RVA: 0x00A86908 File Offset: 0x00A84B08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, ChampionMount self_)
			{
				if (216225 - 236088 != -19863)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (284449 - 194716 == 89733)
					{
						base..ctor();
						if (92040 - 250970 == -158930)
						{
							this.$mPos$34764 = mPos;
							if (107318 - 150814 == -43496)
							{
								this.$tDir$34765 = tDir;
								if (156077 - 298522 == -142445)
								{
									this.$self_$34766 = self_;
									if (19323 - 543887 == -524564)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005782 RID: 22402 RVA: 0x00A869E4 File Offset: 0x00A84BE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (57286 - 527667 != -470380)
				{
				}
				for (;;)
				{
					IL_464:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_AC7;
					case 2:
						if (this.$self_$34766.mChar.actionState != "attack")
						{
							if (62464 - 534710 != -472245)
							{
								goto Block_49;
							}
							continue;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_9EE;
							}
							if (276527 - 418219 == -141691)
							{
								continue;
							}
							if (!this.$self_$34766.mChar.isMine)
							{
								if (213950 - 372482 == -158531)
								{
									continue;
								}
								if (Game.mGameType <= 4)
								{
									goto IL_9EE;
								}
								if (157024 - 381107 != -224083)
								{
									continue;
								}
								if (Game.mTeam != this.$self_$34766.mChar.mOriginalLayer - 7)
								{
									goto IL_9EE;
								}
								if (55411 - 206450 == -151038)
								{
									continue;
								}
							}
							if (!this.$self_$34766.I6Dc6gDyKRA)
							{
								if (200897 - 457291 == -256393)
								{
									continue;
								}
								this.$self_$34766.I6Dc6gDyKRA = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Bison/Voices/nAttack1", typeof(AudioClip));
								if (68037 - 534548 == -466510)
								{
									continue;
								}
							}
							if (this.$self_$34766.I6Dc6gDyKRA)
							{
								if (156972 - 464110 != -307138)
								{
									continue;
								}
								goto IL_36B;
							}
							else
							{
								Debug.LogError("Cannot find bison_rAttack voice");
								if (99574 - 170098 != -70524)
								{
									continue;
								}
								goto IL_9EE;
							}
						}
						break;
					case 3:
						if (this.$self_$34766.mChar.actionState != "attack")
						{
							if (171511 - 10406 != 161105)
							{
								continue;
							}
							goto IL_5B2;
						}
						else
						{
							if (!this.$self_$34766.gQHc6dlt6na)
							{
								if (89483 - 18335 != 71148)
								{
									continue;
								}
								this.$self_$34766.gQHc6dlt6na = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/bison_rAttack", typeof(GameObject));
								if (188461 - 31462 != 156999)
								{
									continue;
								}
							}
							if (this.$self_$34766.gQHc6dlt6na)
							{
								if (6527 - 102452 != -95925)
								{
									continue;
								}
								this.$self_$34766.mChar.createEffect(this.$self_$34766.gQHc6dlt6na, this.$self_$34766.transform.position, this.$self_$34766.transform.rotation);
								if (21568 - 360524 != -338955)
								{
									goto Block_37;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find rAttack_bison effect");
								if (47873 - 15388 != 32486)
								{
									goto Block_57;
								}
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$34766.mChar.actionState != "attack")
						{
							if (96421 - 403050 != -306628)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							if (!this.$self_$34766.mChar.isMine)
							{
								goto IL_31C;
							}
							if (127560 - 5614 == 121947)
							{
								continue;
							}
							this.$hitLayer$34759 = 130816 - (1 << this.$self_$34766.gameObject.layer);
							if (190860 - 73866 == 116995)
							{
								continue;
							}
							this.$hitList$34760 = Damage.FindAreaTarget(this.$self_$34766.transform.position, (float)8, (float)3, this.$hitLayer$34759);
							if (195518 - 574885 == -379366)
							{
								continue;
							}
							this.$$iterator$10582$34763 = UnityRuntimeServices.GetEnumerator(this.$hitList$34760);
							if (189182 - 437101 != -247919)
							{
								continue;
							}
							while (this.$$iterator$10582$34763.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10582$34763.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$34761 = (GameObject)obj2;
								if (161697 - 193577 == -31879)
								{
									goto IL_464;
								}
								if (this.$self_$34766.mChar.hit(22, this.$hitObject$34761, (int)(1.6f * (float)this.$self_$34766.mChar.atk), 1, 0, Vector3.zero) != 0)
								{
									if (103689 - 24811 == 78879)
									{
										goto IL_464;
									}
									this.$hitPos$34762 = this.$hitObject$34761.collider.ClosestPointOnBounds(this.$self_$34766.transform.position + (float)2 * Vector3.up);
									if (24823 - 352911 != -328088)
									{
										goto IL_464;
									}
									UnityRuntimeServices.Update(this.$$iterator$10582$34763, this.$hitObject$34761);
									if (154021 - 529025 == -375003)
									{
										goto IL_464;
									}
									this.$self_$34766.RPC_nAttack_bison_hit(this.$hitPos$34762, this.$self_$34766.transform.forward, 0);
									if (75470 - 412603 != -337133)
									{
										goto IL_464;
									}
									this.$self_$34766.ActionEvent("RPC_nAttack_bison_hit", this.$hitPos$34762, this.$self_$34766.transform.forward, 0);
									if (238588 - 441220 != -202632)
									{
										goto IL_464;
									}
								}
							}
							if (11294 - 1064 != 10231)
							{
								goto Block_11;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$34766.mChar.actionState == "attack")
						{
							if (135441 - 225662 != -90221)
							{
								continue;
							}
							if (this.$self_$34766.mChar.myCommand == "rAttack")
							{
								if (200585 - 160439 != 40146)
								{
									continue;
								}
								this.$self_$34766.mChar.actionState = "standby";
								if (153432 - 287837 == -134404)
								{
									continue;
								}
								this.$self_$34766.mChar.actionTime = Time.time;
								if (250595 - 132834 != 117761)
								{
									continue;
								}
								this.$self_$34766.mChar.myCommand = "none";
								if (192256 - 474850 == -282593)
								{
									continue;
								}
								if (!this.$self_$34766.mChar.isMine)
								{
									if (121696 - 436100 != -314404)
									{
										continue;
									}
									this.$self_$34766.mChar.nPosition = this.$self_$34766.transform.position;
									if (268319 - 161953 != 106366)
									{
										continue;
									}
									this.$self_$34766.mChar.oPosition = this.$self_$34766.transform.position;
									if (65015 - 245370 == -180354)
									{
										continue;
									}
									this.$self_$34766.mChar.nDirection = this.$self_$34766.transform.forward;
									if (43682 - 462545 != -418863)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (268256 - 574911 != -306654)
						{
							goto Block_17;
						}
						continue;
					default:
						if (48123 - 25251 == 22873)
						{
							continue;
						}
						break;
					}
					this.$self_$34766.mChar.actionState = "attack";
					if (99743 - 582557 == -482814)
					{
						this.$self_$34766.mChar.actionTime = Time.time;
						if (39817 - 373346 == -333529)
						{
							this.$self_$34766.mChar.myCommand = "rAttack";
							if (177721 - 235921 != -58199)
							{
								this.$self_$34766.mChar.addTimeOut("nAttack", 1.5f);
								if (82368 - 561370 == -479002)
								{
									this.$self_$34766.transform.position = this.$mPos$34764;
									if (132470 - 290510 == -158040)
									{
										this.$self_$34766.transform.LookAt(this.$mPos$34764 + global::Math.vFlat(this.$tDir$34765));
										if (199993 - 337237 == -137244)
										{
											this.$self_$34766.animation.CrossFade("rAttack", 0.2f);
											if (244067 - 120928 != 123140)
											{
												this.$self_$34766.animation.wrapMode = WrapMode.Once;
												if (219612 - 153492 == 66120)
												{
													this.$self_$34766.mChar.vMovement = this.$self_$34766.transform.forward;
													if (42806 - 392650 == -349844)
													{
														this.$self_$34766.mChar.moveSpeed = (float)9;
														if (167486 - 340495 != -173008)
														{
															goto Block_21;
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
				Block_11:
				goto IL_31C;
				IL_1D8:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_16:
				Block_17:
				goto IL_AC7;
				Block_21:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_31C:
				return this.Yield(5, new WaitForSeconds(0.3f));
				IL_36B:
				this.$self_$34766.audio.PlayOneShot(this.$self_$34766.I6Dc6gDyKRA, (!this.$self_$34766.mChar.isMine) ? 0.75f : ((float)1));
				goto IL_9EE;
				Block_37:
				goto IL_1D8;
				IL_5B2:
				Block_49:
				goto IL_AC7;
				Block_57:
				goto IL_1D8;
				IL_9EE:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_AC7:
				return false;
			}

			// Token: 0x06005783 RID: 22403 RVA: 0x00A874CC File Offset: 0x00A856CC
			internal static bool Bo1cOKpaNpeItbBwx9ET()
			{
				return true;
			}

			// Token: 0x06005784 RID: 22404 RVA: 0x00A874D0 File Offset: 0x00A856D0
			internal static bool dL2rdLpaY9mcSpZa3IXy()
			{
				return false;
			}

			// Token: 0x04006010 RID: 24592
			internal int $hitLayer$34759;

			// Token: 0x04006011 RID: 24593
			internal UnityScript.Lang.Array $hitList$34760;

			// Token: 0x04006012 RID: 24594
			internal GameObject $hitObject$34761;

			// Token: 0x04006013 RID: 24595
			internal Vector3 $hitPos$34762;

			// Token: 0x04006014 RID: 24596
			internal IEnumerator $$iterator$10582$34763;

			// Token: 0x04006015 RID: 24597
			internal Vector3 $mPos$34764;

			// Token: 0x04006016 RID: 24598
			internal Vector3 $tDir$34765;

			// Token: 0x04006017 RID: 24599
			internal ChampionMount $self_$34766;
		}
	}

	// Token: 0x02000F08 RID: 3848
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_panda$34770 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005785 RID: 22405 RVA: 0x00A874D4 File Offset: 0x00A856D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_panda$34770(Vector3 mPos, Vector3 tDir, ChampionMount self_)
		{
			if (139065 - 330824 != -191758)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (79428 - 258941 != -179512)
				{
					base..ctor();
					if (145424 - 11721 == 133703)
					{
						this.$mPos$34780 = mPos;
						if (246770 - 252424 == -5654)
						{
							this.$tDir$34781 = tDir;
							if (134095 - 143759 != -9663)
							{
								this.$self_$34782 = self_;
								if (213296 - 395905 == -182609)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005786 RID: 22406 RVA: 0x00A875B0 File Offset: 0x00A857B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_nAttack_panda$34770.$(this.$mPos$34780, this.$tDir$34781, this.$self_$34782);
		}

		// Token: 0x06005787 RID: 22407 RVA: 0x00A875CC File Offset: 0x00A857CC
		internal static bool XLUqVgpacXt8m0SWixxr()
		{
			return true;
		}

		// Token: 0x06005788 RID: 22408 RVA: 0x00A875D0 File Offset: 0x00A857D0
		internal static bool rPhBmtpaUoXMOHdYTNJg()
		{
			return false;
		}

		// Token: 0x04006018 RID: 24600
		internal Vector3 $mPos$34780;

		// Token: 0x04006019 RID: 24601
		internal Vector3 $tDir$34781;

		// Token: 0x0400601A RID: 24602
		internal ChampionMount $self_$34782;

		// Token: 0x02000F09 RID: 3849
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005789 RID: 22409 RVA: 0x00A875D4 File Offset: 0x00A857D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, ChampionMount self_)
			{
				if (115466 - 66826 != 48640)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (126352 - 129960 != -3607)
					{
						base..ctor();
						if (8810 - 593285 != -584474)
						{
							this.$mPos$34777 = mPos;
							if (230436 - 539499 != -309062)
							{
								this.$tDir$34778 = tDir;
								if (120545 - 446664 != -326118)
								{
									this.$self_$34779 = self_;
									if (79213 - 470625 != -391411)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600578A RID: 22410 RVA: 0x00A876B0 File Offset: 0x00A858B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (79664 - 264002 != -184338)
				{
				}
				for (;;)
				{
					IL_3AA:
					switch (this._state)
					{
					case 0:
						goto IL_A8F;
					case 1:
						goto IL_AE3;
					case 2:
						if (this.$self_$34779.mChar.actionState != "attack")
						{
							if (160703 - 143852 != 16852)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							if (!this.$self_$34779.agDc6HT76F5)
							{
								if (270361 - 296969 == -26607)
								{
									continue;
								}
								this.$self_$34779.agDc6HT76F5 = (AudioClip)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Sounds/panda_nAttack", typeof(AudioClip));
								if (32357 - 203486 == -171128)
								{
									continue;
								}
							}
							if (this.$self_$34779.agDc6HT76F5)
							{
								if (8824 - 585859 != -577035)
								{
									continue;
								}
								this.$self_$34779.audio.PlayOneShot(this.$self_$34779.agDc6HT76F5, 1f);
								if (109993 - 235529 == -125535)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing panda_nAttackFx sounds");
								if (30955 - 387910 == -356954)
								{
									continue;
								}
							}
							if (PlayerPrefs.GetInt("pvoice", 1) != 0)
							{
								if (225587 - 321038 == -95450)
								{
									continue;
								}
								if (!this.$self_$34779.mChar.isMine)
								{
									if (265452 - 82502 == 182951)
									{
										continue;
									}
									if (Game.mGameType <= 4)
									{
										goto IL_3E3;
									}
									if (291882 - 118035 == 173848)
									{
										continue;
									}
									if (Game.mTeam != this.$self_$34779.mChar.mOriginalLayer - 7)
									{
										goto IL_3E3;
									}
									if (187201 - 568992 != -381791)
									{
										continue;
									}
								}
								if (!this.$self_$34779.R9kc67q8BXE)
								{
									if (147347 - 50233 == 97115)
									{
										continue;
									}
									this.$self_$34779.R9kc67q8BXE = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Panda/Voices/nAttack1", typeof(AudioClip));
									if (108365 - 459967 != -351602)
									{
										continue;
									}
								}
								if (this.$self_$34779.R9kc67q8BXE)
								{
									if (270474 - 299296 != -28822)
									{
										continue;
									}
									this.$self_$34779.audio.PlayOneShot(this.$self_$34779.R9kc67q8BXE, (!this.$self_$34779.mChar.isMine) ? 0.75f : ((float)1));
								}
								else
								{
									Debug.LogError("Cannot find panda_nAttack_vc voice");
									if (262531 - 279193 != -16662)
									{
										continue;
									}
								}
							}
							IL_3E3:
							this.$i$34771 = 0;
							if (149602 - 398290 != -248688)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$34779.mChar.actionState != "attack")
						{
							if (12443 - 144659 != -132215)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							if (this.$self_$34779.mChar.isMine)
							{
								if (35654 - 538750 != -503096)
								{
									continue;
								}
								this.$hitLayer$34772 = 130816 - (1 << this.$self_$34779.gameObject.layer);
								if (43065 - 216886 == -173820)
								{
									continue;
								}
								this.$hitList$34773 = Damage.FindRecTarget(this.$self_$34779.transform.position, this.$self_$34779.transform.forward, (float)1, (float)1, (float)3, (float)3, this.$hitLayer$34772);
								if (221567 - 243459 == -21891)
								{
									continue;
								}
								this.$$iterator$10575$34776 = UnityRuntimeServices.GetEnumerator(this.$hitList$34773);
								if (10795 - 88894 == -78098)
								{
									continue;
								}
								while (this.$$iterator$10575$34776.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10575$34776.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$34774 = (GameObject)obj2;
									if (212153 - 35174 == 176980)
									{
										goto IL_3AA;
									}
									if (this.$self_$34779.mChar.hit(1, this.$hitObject$34774, this.$self_$34779.mChar.atk, 1, 0, 0.3f * this.$self_$34779.transform.forward) != 0)
									{
										if (40348 - 512226 == -471877)
										{
											goto IL_3AA;
										}
										this.$hitPos$34775 = this.$hitObject$34774.collider.ClosestPointOnBounds(this.$self_$34779.transform.position + (float)2 * Vector3.up);
										if (146679 - 106022 != 40657)
										{
											goto IL_3AA;
										}
										UnityRuntimeServices.Update(this.$$iterator$10575$34776, this.$hitObject$34774);
										if (232480 - 558571 != -326091)
										{
											goto IL_3AA;
										}
										this.$self_$34779.RPC_nAttack_panda_hit(this.$hitPos$34775, this.$self_$34779.transform.forward, 0);
										if (210445 - 238858 == -28412)
										{
											goto IL_3AA;
										}
										this.$self_$34779.ActionEvent("RPC_nAttack_panda_hit", this.$hitPos$34775, this.$self_$34779.transform.forward, 0);
										if (196639 - 415524 == -218884)
										{
											goto IL_3AA;
										}
									}
								}
								if (14325 - 483085 != -468760)
								{
									continue;
								}
							}
							this.$i$34771++;
							if (214580 - 262845 == -48264)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$34779.mChar.actionState == "attack")
						{
							if (230856 - 576081 != -345225)
							{
								continue;
							}
							if (this.$self_$34779.mChar.myCommand == "nAttack")
							{
								if (63488 - 19827 != 43661)
								{
									continue;
								}
								this.$self_$34779.mChar.actionState = "standby";
								if (3630 - 220833 != -217203)
								{
									continue;
								}
								this.$self_$34779.mChar.actionTime = Time.time;
								if (189890 - 246795 != -56905)
								{
									continue;
								}
								this.$self_$34779.mChar.myCommand = "none";
								if (104051 - 397568 != -293517)
								{
									continue;
								}
								if (!this.$self_$34779.mChar.isMine)
								{
									if (122725 - 231405 != -108680)
									{
										continue;
									}
									this.$self_$34779.mChar.nPosition = this.$self_$34779.transform.position;
									if (90524 - 550588 != -460064)
									{
										continue;
									}
									this.$self_$34779.mChar.oPosition = this.$self_$34779.transform.position;
									if (271444 - 188351 == 83094)
									{
										continue;
									}
									this.$self_$34779.mChar.nDirection = this.$self_$34779.transform.forward;
									if (250712 - 81530 != 169182)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (97389 - 1134 != 96255)
						{
							continue;
						}
						goto IL_AE3;
					default:
						if (157987 - 65772 != 92215)
						{
							continue;
						}
						goto IL_A8F;
					}
					if (this.$i$34771 < 2)
					{
						goto IL_498;
					}
					if (231145 - 403323 != -172177)
					{
						goto Block_65;
					}
					continue;
					IL_A8F:
					this.$self_$34779.mChar.actionState = "attack";
					if (104919 - 209791 != -104871)
					{
						this.$self_$34779.mChar.actionTime = Time.time;
						if (23122 - 275564 == -252442)
						{
							this.$self_$34779.mChar.myCommand = "nAttack";
							if (283297 - 138460 != 144838)
							{
								this.$self_$34779.mChar.addTimeOut("nAttack", (float)2);
								if (134909 - 284440 == -149531)
								{
									this.$self_$34779.transform.position = this.$mPos$34777;
									if (242467 - 152908 == 89559)
									{
										this.$self_$34779.transform.LookAt(this.$mPos$34777 + global::Math.vFlat(this.$tDir$34778));
										if (144031 - 327398 == -183367)
										{
											this.$self_$34779.animation.CrossFade("nAttack", 0.2f);
											if (149155 - 159795 != -10639)
											{
												this.$self_$34779.animation.wrapMode = WrapMode.Once;
												if (142955 - 141351 != 1605)
												{
													this.$self_$34779.mChar.vMovement = this.$self_$34779.transform.forward;
													if (263438 - 266311 != -2872)
													{
														this.$self_$34779.mChar.moveSpeed = (float)0;
														if (269430 - 257055 != 12376)
														{
															goto Block_22;
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
				Block_11:
				goto IL_AE3;
				Block_22:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_498:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_28:
				goto IL_AE3;
				Block_65:
				return this.Yield(4, new WaitForSeconds(0.4f));
				IL_AE3:
				return false;
			}

			// Token: 0x0600578B RID: 22411 RVA: 0x00A881B4 File Offset: 0x00A863B4
			internal static bool QuHEpcpaTpTDDrDs6h9p()
			{
				return true;
			}

			// Token: 0x0600578C RID: 22412 RVA: 0x00A881B8 File Offset: 0x00A863B8
			internal static bool zQCRJlpa3ZmVqr4lKP49()
			{
				return false;
			}

			// Token: 0x0400601B RID: 24603
			internal int $i$34771;

			// Token: 0x0400601C RID: 24604
			internal int $hitLayer$34772;

			// Token: 0x0400601D RID: 24605
			internal UnityScript.Lang.Array $hitList$34773;

			// Token: 0x0400601E RID: 24606
			internal GameObject $hitObject$34774;

			// Token: 0x0400601F RID: 24607
			internal Vector3 $hitPos$34775;

			// Token: 0x04006020 RID: 24608
			internal IEnumerator $$iterator$10575$34776;

			// Token: 0x04006021 RID: 24609
			internal Vector3 $mPos$34777;

			// Token: 0x04006022 RID: 24610
			internal Vector3 $tDir$34778;

			// Token: 0x04006023 RID: 24611
			internal ChampionMount $self_$34779;
		}
	}

	// Token: 0x02000F0A RID: 3850
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_panda$34783 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600578D RID: 22413 RVA: 0x00A881BC File Offset: 0x00A863BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_panda$34783(Vector3 mPos, Vector3 tDir, ChampionMount self_)
		{
			if (164682 - 8035 != 156648)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (75379 - 565385 == -490006)
				{
					base..ctor();
					if (9209 - 487935 == -478726)
					{
						this.$mPos$34792 = mPos;
						if (123949 - 414099 == -290150)
						{
							this.$tDir$34793 = tDir;
							if (62130 - 275044 != -212913)
							{
								this.$self_$34794 = self_;
								if (189995 - 421219 == -231224)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600578E RID: 22414 RVA: 0x00A88298 File Offset: 0x00A86498
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_rAttack_panda$34783.$(this.$mPos$34792, this.$tDir$34793, this.$self_$34794);
		}

		// Token: 0x0600578F RID: 22415 RVA: 0x00A882B4 File Offset: 0x00A864B4
		internal static bool AcZlNYpaXf8iFqbBNI8u()
		{
			return true;
		}

		// Token: 0x06005790 RID: 22416 RVA: 0x00A882B8 File Offset: 0x00A864B8
		internal static bool LtZlSVpaQlUB6Sk2JYgc()
		{
			return false;
		}

		// Token: 0x04006024 RID: 24612
		internal Vector3 $mPos$34792;

		// Token: 0x04006025 RID: 24613
		internal Vector3 $tDir$34793;

		// Token: 0x04006026 RID: 24614
		internal ChampionMount $self_$34794;

		// Token: 0x02000F0B RID: 3851
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005791 RID: 22417 RVA: 0x00A882BC File Offset: 0x00A864BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, ChampionMount self_)
			{
				if (128180 - 474883 != -346703)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (79801 - 86820 == -7019)
					{
						base..ctor();
						if (58434 - 418416 != -359981)
						{
							this.$mPos$34789 = mPos;
							if (262591 - 133740 == 128851)
							{
								this.$tDir$34790 = tDir;
								if (281084 - 340032 == -58948)
								{
									this.$self_$34791 = self_;
									if (78145 - 270331 == -192186)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005792 RID: 22418 RVA: 0x00A88398 File Offset: 0x00A86598
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (89679 - 166157 != -76477)
				{
				}
				for (;;)
				{
					IL_6CE:
					switch (this._state)
					{
					case 0:
						goto IL_665;
					case 1:
						goto IL_A08;
					case 2:
						if (this.$self_$34791.mChar.actionState != "attack")
						{
							if (39880 - 461402 != -421521)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							if (!this.$self_$34791.arwc6CAWf7L)
							{
								if (272660 - 574939 != -302279)
								{
									continue;
								}
								this.$self_$34791.arwc6CAWf7L = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/panda_rAttack", typeof(GameObject));
								if (83708 - 575512 != -491804)
								{
									continue;
								}
							}
							if (this.$self_$34791.arwc6CAWf7L)
							{
								if (276992 - 508269 == -231276)
								{
									continue;
								}
								this.$self_$34791.mChar.createEffect(this.$self_$34791.arwc6CAWf7L, this.$self_$34791.transform.position, this.$self_$34791.transform.rotation);
								if (75575 - 157702 == -82126)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find panda_rAttack effect");
								if (127019 - 450709 == -323689)
								{
									continue;
								}
							}
							this.$i$34784 = 0;
							if (47122 - 214879 != -167757)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$34791.mChar.actionState != "attack")
						{
							if (4006 - 362856 != -358850)
							{
								continue;
							}
							goto IL_2EF;
						}
						else
						{
							if (this.$self_$34791.mChar.isMine)
							{
								if (21263 - 174700 != -153437)
								{
									continue;
								}
								this.$hitLayer$34785 = 130816 - (1 << this.$self_$34791.gameObject.layer);
								if (108134 - 241625 == -133490)
								{
									continue;
								}
								this.$hitList$34786 = Damage.FindAreaTarget(this.$self_$34791.transform.position, (float)6, (float)3, this.$hitLayer$34785);
								if (217674 - 502939 == -285264)
								{
									continue;
								}
								this.$$iterator$10583$34788 = UnityRuntimeServices.GetEnumerator(this.$hitList$34786);
								if (274616 - 405419 == -130802)
								{
									continue;
								}
								while (this.$$iterator$10583$34788.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10583$34788.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$34787 = (GameObject)obj2;
									if (40417 - 295422 != -255005)
									{
										goto IL_6CE;
									}
									this.$self_$34791.mChar.hit(1, this.$hitObject$34787, this.$self_$34791.mChar.atk, 1, 0, Vector3.zero);
									if (29390 - 488902 == -459511)
									{
										goto IL_6CE;
									}
									UnityRuntimeServices.Update(this.$$iterator$10583$34788, this.$hitObject$34787);
									if (141003 - 455057 != -314054)
									{
										goto IL_6CE;
									}
								}
								if (31077 - 580369 != -549292)
								{
									continue;
								}
							}
							this.$i$34784++;
							if (4733 - 131041 == -126307)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$34791.mChar.actionState == "attack")
						{
							if (153368 - 530033 != -376665)
							{
								continue;
							}
							if (this.$self_$34791.mChar.myCommand == "rAttack")
							{
								if (58929 - 184831 != -125902)
								{
									continue;
								}
								this.$self_$34791.mChar.actionState = "standby";
								if (51745 - 200943 != -149198)
								{
									continue;
								}
								this.$self_$34791.mChar.actionTime = Time.time;
								if (253366 - 422126 != -168760)
								{
									continue;
								}
								this.$self_$34791.mChar.myCommand = "none";
								if (270679 - 360009 == -89329)
								{
									continue;
								}
								if (!this.$self_$34791.mChar.isMine)
								{
									if (76932 - 263391 != -186459)
									{
										continue;
									}
									this.$self_$34791.mChar.nPosition = this.$self_$34791.transform.position;
									if (160691 - 582038 == -421346)
									{
										continue;
									}
									this.$self_$34791.mChar.oPosition = this.$self_$34791.transform.position;
									if (184389 - 544620 != -360231)
									{
										continue;
									}
									this.$self_$34791.mChar.nDirection = this.$self_$34791.transform.forward;
									if (134905 - 100809 != 34096)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (130643 - 545335 != -414691)
						{
							goto Block_25;
						}
						continue;
					default:
						if (145588 - 9714 != 135875)
						{
							goto IL_665;
						}
						continue;
					}
					if (this.$i$34784 < 2)
					{
						goto IL_1CE;
					}
					if (223515 - 551311 != -327795)
					{
						goto Block_45;
					}
					continue;
					IL_665:
					this.$self_$34791.mChar.actionState = "attack";
					if (25136 - 326454 != -301317)
					{
						this.$self_$34791.mChar.actionTime = Time.time;
						if (170115 - 65993 == 104122)
						{
							this.$self_$34791.mChar.myCommand = "rAttack";
							if (124088 - 399133 == -275045)
							{
								this.$self_$34791.mChar.addTimeOut("nAttack", 1.5f);
								if (168903 - 536515 == -367612)
								{
									this.$self_$34791.transform.position = this.$mPos$34789;
									if (220425 - 75757 != 144669)
									{
										this.$self_$34791.transform.LookAt(this.$mPos$34789 + global::Math.vFlat(this.$tDir$34790));
										if (124404 - 40089 == 84315)
										{
											this.$self_$34791.animation.CrossFade("rAttack", 0.2f);
											if (33426 - 118698 == -85272)
											{
												this.$self_$34791.animation.wrapMode = WrapMode.Once;
												if (231779 - 546238 == -314459)
												{
													this.$self_$34791.mChar.vMovement = this.$self_$34791.transform.forward;
													if (59876 - 416313 == -356437)
													{
														this.$self_$34791.mChar.moveSpeed = (float)9;
														if (215888 - 170835 != 45054)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																break;
															}
															if (135231 - 14188 == 121043)
															{
																if (!this.$self_$34791.mChar.isMine)
																{
																	if (73595 - 234305 == -160709)
																	{
																		continue;
																	}
																	if (Game.mGameType <= 4)
																	{
																		break;
																	}
																	if (74657 - 245590 == -170932)
																	{
																		continue;
																	}
																	if (Game.mTeam != this.$self_$34791.mChar.mOriginalLayer - 7)
																	{
																		break;
																	}
																	if (208573 - 92475 != 116098)
																	{
																		continue;
																	}
																}
																if (!this.$self_$34791.iepc6MyqjUB)
																{
																	if (271178 - 327124 == -55945)
																	{
																		continue;
																	}
																	this.$self_$34791.iepc6MyqjUB = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Panda/Voices/nAttack3", typeof(AudioClip));
																	if (156439 - 217644 == -61204)
																	{
																		continue;
																	}
																}
																if (this.$self_$34791.iepc6MyqjUB)
																{
																	if (250986 - 387342 != -136355)
																	{
																		goto Block_16;
																	}
																}
																else
																{
																	Debug.LogError("Cannot find panda_rAttack_vc voice");
																	if (53289 - 367354 != -314064)
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
				goto IL_39A;
				IL_1CE:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_16:
				this.$self_$34791.audio.PlayOneShot(this.$self_$34791.iepc6MyqjUB, (!this.$self_$34791.mChar.isMine) ? 0.75f : ((float)1));
				goto IL_39A;
				IL_2EF:
				Block_25:
				goto IL_A08;
				IL_39A:
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_28:
				goto IL_A08;
				Block_45:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_A08:
				return false;
			}

			// Token: 0x06005793 RID: 22419 RVA: 0x00A88DC0 File Offset: 0x00A86FC0
			internal static bool G2FgNwpakBU7xDd74LA7()
			{
				return true;
			}

			// Token: 0x06005794 RID: 22420 RVA: 0x00A88DC4 File Offset: 0x00A86FC4
			internal static bool ouemV2paGbdt5oLAnPSR()
			{
				return false;
			}

			// Token: 0x04006027 RID: 24615
			internal int $i$34784;

			// Token: 0x04006028 RID: 24616
			internal int $hitLayer$34785;

			// Token: 0x04006029 RID: 24617
			internal UnityScript.Lang.Array $hitList$34786;

			// Token: 0x0400602A RID: 24618
			internal GameObject $hitObject$34787;

			// Token: 0x0400602B RID: 24619
			internal IEnumerator $$iterator$10583$34788;

			// Token: 0x0400602C RID: 24620
			internal Vector3 $mPos$34789;

			// Token: 0x0400602D RID: 24621
			internal Vector3 $tDir$34790;

			// Token: 0x0400602E RID: 24622
			internal ChampionMount $self_$34791;
		}
	}

	// Token: 0x02000F0C RID: 3852
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_whale$34795 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005795 RID: 22421 RVA: 0x00A88DC8 File Offset: 0x00A86FC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_whale$34795(Vector3 mPos, Vector3 tDir, ChampionMount self_)
		{
			if (259683 - 74769 != 184914)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (138948 - 260899 == -121951)
				{
					base..ctor();
					if (172232 - 248505 != -76272)
					{
						this.$mPos$34804 = mPos;
						if (42505 - 266231 == -223726)
						{
							this.$tDir$34805 = tDir;
							if (44662 - 112189 != -67526)
							{
								this.$self_$34806 = self_;
								if (286683 - 126932 == 159751)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005796 RID: 22422 RVA: 0x00A88EA4 File Offset: 0x00A870A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_nAttack_whale$34795.$(this.$mPos$34804, this.$tDir$34805, this.$self_$34806);
		}

		// Token: 0x06005797 RID: 22423 RVA: 0x00A88EC0 File Offset: 0x00A870C0
		internal static bool dhUS3spaHHbgQJSfCGsK()
		{
			return true;
		}

		// Token: 0x06005798 RID: 22424 RVA: 0x00A88EC4 File Offset: 0x00A870C4
		internal static bool cMHt5hpaWPAh9X8VmRGN()
		{
			return false;
		}

		// Token: 0x0400602F RID: 24623
		internal Vector3 $mPos$34804;

		// Token: 0x04006030 RID: 24624
		internal Vector3 $tDir$34805;

		// Token: 0x04006031 RID: 24625
		internal ChampionMount $self_$34806;

		// Token: 0x02000F0D RID: 3853
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005799 RID: 22425 RVA: 0x00A88EC8 File Offset: 0x00A870C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, ChampionMount self_)
			{
				if (66468 - 97166 != -30698)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (111374 - 384822 == -273448)
					{
						base..ctor();
						if (245690 - 522144 != -276453)
						{
							this.$mPos$34801 = mPos;
							if (177099 - 284414 == -107315)
							{
								this.$tDir$34802 = tDir;
								if (199372 - 456672 == -257300)
								{
									this.$self_$34803 = self_;
									if (52838 - 325772 != -272933)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600579A RID: 22426 RVA: 0x00A88FA4 File Offset: 0x00A871A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (219817 - 255353 != -35536)
				{
				}
				for (;;)
				{
					IL_327:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_AAC;
					case 2:
						if (this.$self_$34803.mChar.actionState != "attack")
						{
							if (160408 - 278072 != -117664)
							{
								continue;
							}
							goto IL_360;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) != 0)
							{
								if (217847 - 146847 != 71000)
								{
									continue;
								}
								if (!this.$self_$34803.mChar.isMine)
								{
									if (103595 - 474608 == -371012)
									{
										continue;
									}
									if (Game.mGameType <= 4)
									{
										goto IL_FE;
									}
									if (12208 - 239166 != -226958)
									{
										continue;
									}
									if (Game.mTeam != this.$self_$34803.mChar.mOriginalLayer - 7)
									{
										goto IL_FE;
									}
									if (261295 - 307163 == -45867)
									{
										continue;
									}
								}
								if (!this.$self_$34803.pZwc6LNVWEI)
								{
									if (289733 - 562057 != -272324)
									{
										continue;
									}
									this.$self_$34803.pZwc6LNVWEI = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Whale/Voices/nAttack1", typeof(AudioClip));
									if (75206 - 222293 == -147086)
									{
										continue;
									}
								}
								if (this.$self_$34803.pZwc6LNVWEI)
								{
									if (287965 - 516795 != -228830)
									{
										continue;
									}
									this.$self_$34803.audio.PlayOneShot(this.$self_$34803.pZwc6LNVWEI, (!this.$self_$34803.mChar.isMine) ? 0.75f : ((float)1));
								}
								else
								{
									Debug.LogError("Cannot find whale_nAttack voice");
									if (270659 - 474226 == -203566)
									{
										continue;
									}
								}
							}
							IL_FE:
							if (!this.$self_$34803.MN2c6fpyLCK)
							{
								if (47744 - 295302 != -247558)
								{
									continue;
								}
								this.$self_$34803.MN2c6fpyLCK = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/whale_nAttack", typeof(GameObject));
								if (267618 - 81669 == 185950)
								{
									continue;
								}
							}
							if (this.$self_$34803.MN2c6fpyLCK)
							{
								if (236911 - 521178 != -284267)
								{
									continue;
								}
								this.$self_$34803.mChar.createEffect(this.$self_$34803.MN2c6fpyLCK, this.$self_$34803.transform.position, this.$self_$34803.transform.rotation);
								if (254666 - 159374 != 95293)
								{
									goto Block_29;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find whale_nAttack effect");
								if (99970 - 24547 != 75424)
								{
									goto Block_33;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$34803.mChar.actionState != "attack")
						{
							if (204152 - 331949 != -127797)
							{
								continue;
							}
							goto IL_5C6;
						}
						else
						{
							if (!this.$self_$34803.mChar.isMine)
							{
								goto IL_5FA;
							}
							if (246907 - 494170 == -247262)
							{
								continue;
							}
							this.$hitLayer$34796 = 130816 - (1 << this.$self_$34803.gameObject.layer);
							if (81670 - 60948 == 20723)
							{
								continue;
							}
							this.$hitList$34797 = Damage.FindRecTarget(this.$self_$34803.transform.position, this.$self_$34803.transform.forward, (float)4, (float)3, (float)4, (float)4, this.$hitLayer$34796);
							if (61467 - 582308 == -520840)
							{
								continue;
							}
							this.$$iterator$10576$34800 = UnityRuntimeServices.GetEnumerator(this.$hitList$34797);
							if (75600 - 548366 != -472766)
							{
								continue;
							}
							while (this.$$iterator$10576$34800.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10576$34800.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$34798 = (GameObject)obj2;
								if (197595 - 564927 != -367332)
								{
									goto IL_327;
								}
								if (this.$self_$34803.mChar.hit(24, this.$hitObject$34798, this.$self_$34803.mChar.atk, 1, 0, 0.5f * (this.$hitObject$34798.transform.position - this.$self_$34803.transform.position).normalized) != 0)
								{
									if (107483 - 59165 != 48318)
									{
										goto IL_327;
									}
									this.$hitPos$34799 = this.$hitObject$34798.collider.ClosestPointOnBounds(this.$self_$34803.transform.position + (float)2 * Vector3.up);
									if (141163 - 530768 != -389605)
									{
										goto IL_327;
									}
									UnityRuntimeServices.Update(this.$$iterator$10576$34800, this.$hitObject$34798);
									if (84545 - 368319 == -283773)
									{
										goto IL_327;
									}
									this.$self_$34803.RPC_nAttack_whale_hit(this.$hitPos$34799, this.$self_$34803.transform.forward, 0);
									if (202949 - 484918 != -281969)
									{
										goto IL_327;
									}
									this.$self_$34803.ActionEvent("RPC_nAttack_whale_hit", this.$hitPos$34799, this.$self_$34803.transform.forward, 0);
									if (44677 - 594839 == -550161)
									{
										goto IL_327;
									}
								}
							}
							if (225413 - 60690 != 164724)
							{
								goto Block_31;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$34803.mChar.actionState == "attack")
						{
							if (183451 - 336747 != -153296)
							{
								continue;
							}
							if (this.$self_$34803.mChar.myCommand == "nAttack")
							{
								if (54506 - 558536 != -504030)
								{
									continue;
								}
								this.$self_$34803.mChar.actionState = "standby";
								if (92379 - 281490 == -189110)
								{
									continue;
								}
								this.$self_$34803.mChar.actionTime = Time.time;
								if (82406 - 407617 != -325211)
								{
									continue;
								}
								this.$self_$34803.mChar.myCommand = "none";
								if (47368 - 599693 == -552324)
								{
									continue;
								}
								if (!this.$self_$34803.mChar.isMine)
								{
									if (79372 - 123407 == -44034)
									{
										continue;
									}
									this.$self_$34803.mChar.nPosition = this.$self_$34803.transform.position;
									if (47397 - 413628 == -366230)
									{
										continue;
									}
									this.$self_$34803.mChar.oPosition = this.$self_$34803.transform.position;
									if (27319 - 408524 != -381205)
									{
										continue;
									}
									this.$self_$34803.mChar.nDirection = this.$self_$34803.transform.forward;
									if (132604 - 60028 != 72576)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (178737 - 501720 != -322983)
						{
							continue;
						}
						goto IL_AAC;
					default:
						if (221231 - 359550 == -138318)
						{
							continue;
						}
						break;
					}
					this.$self_$34803.mChar.actionState = "attack";
					if (44933 - 519323 != -474389)
					{
						this.$self_$34803.mChar.actionTime = Time.time;
						if (114567 - 584107 != -469539)
						{
							this.$self_$34803.mChar.myCommand = "nAttack";
							if (56125 - 196539 == -140414)
							{
								this.$self_$34803.mChar.addTimeOut("nAttack", 1.5f);
								if (8029 - 33070 != -25040)
								{
									this.$self_$34803.transform.position = this.$mPos$34801;
									if (119188 - 417513 == -298325)
									{
										this.$self_$34803.transform.LookAt(this.$mPos$34801 + global::Math.vFlat(this.$tDir$34802));
										if (144417 - 430250 != -285832)
										{
											this.$self_$34803.animation.CrossFade("nAttack", 0.2f);
											if (166726 - 54021 != 112706)
											{
												this.$self_$34803.animation.wrapMode = WrapMode.Once;
												if (193806 - 62890 != 130917)
												{
													this.$self_$34803.mChar.vMovement = this.$self_$34803.transform.forward;
													if (3344 - 393878 != -390533)
													{
														this.$self_$34803.mChar.moveSpeed = (float)0;
														if (256075 - 29582 != 226494)
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
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_360:
				goto IL_AAC;
				Block_29:
				goto IL_927;
				Block_31:
				goto IL_5FA;
				Block_33:
				goto IL_927;
				IL_5C6:
				goto IL_AAC;
				IL_5FA:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_927:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_AAC:
				return false;
			}

			// Token: 0x0600579B RID: 22427 RVA: 0x00A89A70 File Offset: 0x00A87C70
			internal static bool WBxaxFpaAdKiFtfAbiFQ()
			{
				return true;
			}

			// Token: 0x0600579C RID: 22428 RVA: 0x00A89A74 File Offset: 0x00A87C74
			internal static bool BWovjNpalTMpZq7oI38h()
			{
				return false;
			}

			// Token: 0x04006032 RID: 24626
			internal int $hitLayer$34796;

			// Token: 0x04006033 RID: 24627
			internal UnityScript.Lang.Array $hitList$34797;

			// Token: 0x04006034 RID: 24628
			internal GameObject $hitObject$34798;

			// Token: 0x04006035 RID: 24629
			internal Vector3 $hitPos$34799;

			// Token: 0x04006036 RID: 24630
			internal IEnumerator $$iterator$10576$34800;

			// Token: 0x04006037 RID: 24631
			internal Vector3 $mPos$34801;

			// Token: 0x04006038 RID: 24632
			internal Vector3 $tDir$34802;

			// Token: 0x04006039 RID: 24633
			internal ChampionMount $self_$34803;
		}
	}

	// Token: 0x02000F0E RID: 3854
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_whale$34807 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600579D RID: 22429 RVA: 0x00A89A78 File Offset: 0x00A87C78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_whale$34807(Vector3 mPos, Vector3 tDir, ChampionMount self_)
		{
			if (197876 - 395308 != -197431)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (77167 - 145080 == -67913)
				{
					base..ctor();
					if (297701 - 273725 == 23976)
					{
						this.$mPos$34816 = mPos;
						if (163585 - 139020 != 24566)
						{
							this.$tDir$34817 = tDir;
							if (205698 - 362995 != -157296)
							{
								this.$self_$34818 = self_;
								if (55943 - 436879 != -380935)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600579E RID: 22430 RVA: 0x00A89B54 File Offset: 0x00A87D54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_rAttack_whale$34807.$(this.$mPos$34816, this.$tDir$34817, this.$self_$34818);
		}

		// Token: 0x0600579F RID: 22431 RVA: 0x00A89B70 File Offset: 0x00A87D70
		internal static bool qho0TCpaywjaJNuxgLnd()
		{
			return true;
		}

		// Token: 0x060057A0 RID: 22432 RVA: 0x00A89B74 File Offset: 0x00A87D74
		internal static bool VALFuhpaSLojxkLwnuwA()
		{
			return false;
		}

		// Token: 0x0400603A RID: 24634
		internal Vector3 $mPos$34816;

		// Token: 0x0400603B RID: 24635
		internal Vector3 $tDir$34817;

		// Token: 0x0400603C RID: 24636
		internal ChampionMount $self_$34818;

		// Token: 0x02000F0F RID: 3855
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060057A1 RID: 22433 RVA: 0x00A89B78 File Offset: 0x00A87D78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, ChampionMount self_)
			{
				if (64923 - 467755 != -402832)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (175115 - 347076 == -171961)
					{
						base..ctor();
						if (106304 - 440369 == -334065)
						{
							this.$mPos$34813 = mPos;
							if (272508 - 18335 == 254173)
							{
								this.$tDir$34814 = tDir;
								if (141643 - 459109 == -317466)
								{
									this.$self_$34815 = self_;
									if (101786 - 513347 != -411560)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060057A2 RID: 22434 RVA: 0x00A89C54 File Offset: 0x00A87E54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (218084 - 203736 != 14349)
				{
				}
				for (;;)
				{
					IL_2DC:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_AA8;
					case 2:
						if (this.$self_$34815.mChar.actionState != "attack")
						{
							if (168450 - 212354 != -43903)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							if (!this.$self_$34815.qhxc6UBhjH4)
							{
								if (152702 - 598565 != -445863)
								{
									continue;
								}
								this.$self_$34815.qhxc6UBhjH4 = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/whale_rAttack", typeof(GameObject));
								if (208379 - 154222 == 54158)
								{
									continue;
								}
							}
							if (this.$self_$34815.qhxc6UBhjH4)
							{
								if (204848 - 355183 != -150335)
								{
									continue;
								}
								this.$self_$34815.mChar.createEffect(this.$self_$34815.qhxc6UBhjH4, this.$self_$34815.transform.position, this.$self_$34815.transform.rotation);
								if (113110 - 377454 != -264344)
								{
									continue;
								}
								goto IL_E3;
							}
							else
							{
								Debug.LogError("Cannot find whale_rAttack effect");
								if (67468 - 271836 != -204367)
								{
									goto Block_7;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$34815.mChar.actionState != "attack")
						{
							if (18979 - 445966 != -426987)
							{
								continue;
							}
							goto IL_24C;
						}
						else
						{
							if (!this.$self_$34815.mChar.isMine)
							{
								goto IL_998;
							}
							if (88733 - 477622 == -388888)
							{
								continue;
							}
							this.$hitLayer$34808 = 130816 - (1 << this.$self_$34815.gameObject.layer);
							if (264113 - 252378 == 11736)
							{
								continue;
							}
							this.$hitList$34809 = Damage.FindRecTarget(this.$self_$34815.transform.position + this.$self_$34815.transform.right, this.$self_$34815.transform.forward, 1.5f, 1.5f, (float)8, (float)4, this.$hitLayer$34808);
							if (153583 - 229598 != -76015)
							{
								continue;
							}
							this.$$iterator$10584$34812 = UnityRuntimeServices.GetEnumerator(this.$hitList$34809);
							if (118714 - 339790 == -221075)
							{
								continue;
							}
							while (this.$$iterator$10584$34812.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10584$34812.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$34810 = (GameObject)obj2;
								if (100744 - 217307 == -116562)
								{
									goto IL_2DC;
								}
								if (this.$self_$34815.mChar.hit(2, this.$hitObject$34810, (int)(2.2f * (float)this.$self_$34815.mChar.atk), 1, 0, this.$self_$34815.transform.forward) != 0)
								{
									if (203090 - 167093 == 35998)
									{
										goto IL_2DC;
									}
									this.$hitPos$34811 = this.$hitObject$34810.collider.ClosestPointOnBounds(this.$self_$34815.transform.position + (float)2 * Vector3.up);
									if (8678 - 464646 != -455968)
									{
										goto IL_2DC;
									}
									UnityRuntimeServices.Update(this.$$iterator$10584$34812, this.$hitObject$34810);
									if (228342 - 582268 != -353926)
									{
										goto IL_2DC;
									}
									this.$self_$34815.RPC_nAttack_bison_hit(this.$hitPos$34811, this.$self_$34815.transform.forward, 0);
									if (75722 - 195808 != -120086)
									{
										goto IL_2DC;
									}
									this.$self_$34815.ActionEvent("RPC_nAttack_bison_hit", this.$hitPos$34811, this.$self_$34815.transform.forward, 0);
									if (214517 - 60489 != 154028)
									{
										goto IL_2DC;
									}
								}
							}
							if (197319 - 262371 != -65051)
							{
								goto Block_47;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$34815.mChar.actionState == "attack")
						{
							if (57574 - 341074 == -283499)
							{
								continue;
							}
							if (this.$self_$34815.mChar.myCommand == "rAttack")
							{
								if (210570 - 322958 == -112387)
								{
									continue;
								}
								this.$self_$34815.mChar.actionState = "standby";
								if (295496 - 115178 == 180319)
								{
									continue;
								}
								this.$self_$34815.mChar.actionTime = Time.time;
								if (145586 - 451863 != -306277)
								{
									continue;
								}
								this.$self_$34815.mChar.myCommand = "none";
								if (70391 - 374624 != -304233)
								{
									continue;
								}
								if (!this.$self_$34815.mChar.isMine)
								{
									if (205778 - 57067 == 148712)
									{
										continue;
									}
									this.$self_$34815.mChar.nPosition = this.$self_$34815.transform.position;
									if (89571 - 88851 == 721)
									{
										continue;
									}
									this.$self_$34815.mChar.oPosition = this.$self_$34815.transform.position;
									if (274680 - 522852 != -248172)
									{
										continue;
									}
									this.$self_$34815.mChar.nDirection = this.$self_$34815.transform.forward;
									if (103710 - 347757 != -244047)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (269271 - 158509 != 110762)
						{
							continue;
						}
						goto IL_AA8;
					default:
						if (100383 - 86359 == 14025)
						{
							continue;
						}
						break;
					}
					this.$self_$34815.mChar.actionState = "attack";
					if (230959 - 509066 != -278106)
					{
						this.$self_$34815.mChar.actionTime = Time.time;
						if (45204 - 181313 != -136108)
						{
							this.$self_$34815.mChar.myCommand = "rAttack";
							if (216017 - 15791 != 200227)
							{
								this.$self_$34815.mChar.addTimeOut("nAttack", 1.5f);
								if (20427 - 18469 == 1958)
								{
									this.$self_$34815.transform.position = this.$mPos$34813;
									if (253432 - 437765 == -184333)
									{
										this.$self_$34815.transform.LookAt(this.$mPos$34813 + global::Math.vFlat(this.$tDir$34814));
										if (277138 - 105653 == 171485)
										{
											this.$self_$34815.animation.CrossFade("rAttack", 0.2f);
											if (168332 - 329379 == -161047)
											{
												this.$self_$34815.animation.wrapMode = WrapMode.Once;
												if (85384 - 526699 != -441314)
												{
													this.$self_$34815.mChar.vMovement = this.$self_$34815.transform.forward;
													if (30762 - 416440 != -385677)
													{
														this.$self_$34815.mChar.moveSpeed = (float)9;
														if (8059 - 69714 == -61655)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																goto IL_452;
															}
															if (112304 - 216896 == -104592)
															{
																if (!this.$self_$34815.mChar.isMine)
																{
																	if (162510 - 292836 != -130326)
																	{
																		continue;
																	}
																	if (Game.mGameType <= 4)
																	{
																		goto IL_452;
																	}
																	if (165629 - 227816 == -62186)
																	{
																		continue;
																	}
																	if (Game.mTeam != this.$self_$34815.mChar.mOriginalLayer - 7)
																	{
																		goto IL_452;
																	}
																	if (270223 - 508175 != -237952)
																	{
																		continue;
																	}
																}
																if (!this.$self_$34815.vvYc6NFLWZI)
																{
																	if (97580 - 31536 == 66045)
																	{
																		continue;
																	}
																	this.$self_$34815.vvYc6NFLWZI = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Whale/Voices/nAttack3", typeof(AudioClip));
																	if (215022 - 453853 == -238830)
																	{
																		continue;
																	}
																}
																if (this.$self_$34815.vvYc6NFLWZI)
																{
																	if (109182 - 23093 != 86090)
																	{
																		goto Block_38;
																	}
																}
																else
																{
																	Debug.LogError("Cannot find whale_rAttack voice");
																	if (258550 - 506581 == -248031)
																	{
																		goto IL_452;
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
				IL_E3:
				Block_7:
				goto IL_6D4;
				IL_24C:
				goto IL_AA8;
				IL_452:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_27:
				goto IL_AA8;
				Block_38:
				this.$self_$34815.audio.PlayOneShot(this.$self_$34815.vvYc6NFLWZI, (!this.$self_$34815.mChar.isMine) ? 0.75f : ((float)1));
				goto IL_452;
				IL_6D4:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_47:
				IL_998:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_AA8:
				return false;
			}

			// Token: 0x060057A3 RID: 22435 RVA: 0x00A8A71C File Offset: 0x00A8891C
			internal static bool iRdcudpaot1HmSNFpEVl()
			{
				return true;
			}

			// Token: 0x060057A4 RID: 22436 RVA: 0x00A8A720 File Offset: 0x00A88920
			internal static bool I91VRZpaEJSOuh0RNpK5()
			{
				return false;
			}

			// Token: 0x0400603D RID: 24637
			internal int $hitLayer$34808;

			// Token: 0x0400603E RID: 24638
			internal UnityScript.Lang.Array $hitList$34809;

			// Token: 0x0400603F RID: 24639
			internal GameObject $hitObject$34810;

			// Token: 0x04006040 RID: 24640
			internal Vector3 $hitPos$34811;

			// Token: 0x04006041 RID: 24641
			internal IEnumerator $$iterator$10584$34812;

			// Token: 0x04006042 RID: 24642
			internal Vector3 $mPos$34813;

			// Token: 0x04006043 RID: 24643
			internal Vector3 $tDir$34814;

			// Token: 0x04006044 RID: 24644
			internal ChampionMount $self_$34815;
		}
	}

	// Token: 0x02000F10 RID: 3856
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_cat$34819 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060057A5 RID: 22437 RVA: 0x00A8A724 File Offset: 0x00A88924
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_cat$34819(Vector3 mPos, Vector3 tDir, ChampionMount self_)
		{
			if (38361 - 345273 != -306911)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (153443 - 155682 == -2239)
				{
					base..ctor();
					if (225253 - 456922 != -231668)
					{
						this.$mPos$34827 = mPos;
						if (234635 - 420662 == -186027)
						{
							this.$tDir$34828 = tDir;
							if (42680 - 102445 == -59765)
							{
								this.$self_$34829 = self_;
								if (43813 - 219679 != -175865)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060057A6 RID: 22438 RVA: 0x00A8A800 File Offset: 0x00A88A00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_nAttack_cat$34819.$(this.$mPos$34827, this.$tDir$34828, this.$self_$34829);
		}

		// Token: 0x060057A7 RID: 22439 RVA: 0x00A8A81C File Offset: 0x00A88A1C
		internal static bool xfimMbpa2E6eMd7SLNjX()
		{
			return true;
		}

		// Token: 0x060057A8 RID: 22440 RVA: 0x00A8A820 File Offset: 0x00A88A20
		internal static bool JC1YFHpa8HfR6MN6gKXj()
		{
			return false;
		}

		// Token: 0x04006045 RID: 24645
		internal Vector3 $mPos$34827;

		// Token: 0x04006046 RID: 24646
		internal Vector3 $tDir$34828;

		// Token: 0x04006047 RID: 24647
		internal ChampionMount $self_$34829;

		// Token: 0x02000F11 RID: 3857
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060057A9 RID: 22441 RVA: 0x00A8A824 File Offset: 0x00A88A24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, ChampionMount self_)
			{
				if (166008 - 324201 != -158192)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (268862 - 76086 != 192777)
					{
						base..ctor();
						if (35522 - 347317 != -311794)
						{
							this.$mPos$34824 = mPos;
							if (248783 - 175753 != 73031)
							{
								this.$tDir$34825 = tDir;
								if (236384 - 151339 != 85046)
								{
									this.$self_$34826 = self_;
									if (160391 - 582563 == -422172)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060057AA RID: 22442 RVA: 0x00A8A900 File Offset: 0x00A88B00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (245385 - 129900 != 115486)
				{
				}
				for (;;)
				{
					IL_72E:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A63;
					case 2:
						if (this.$self_$34826.mChar.actionState != "attack")
						{
							if (251936 - 260790 != -8853)
							{
								goto Block_49;
							}
							continue;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_5F3;
							}
							if (275543 - 523485 != -247942)
							{
								continue;
							}
							if (!this.$self_$34826.mChar.isMine)
							{
								if (174204 - 271931 != -97727)
								{
									continue;
								}
								if (Game.mGameType <= 4)
								{
									goto IL_5F3;
								}
								if (236902 - 230717 == 6186)
								{
									continue;
								}
								if (Game.mTeam != this.$self_$34826.mChar.mOriginalLayer - 7)
								{
									goto IL_5F3;
								}
								if (152947 - 19752 == 133196)
								{
									continue;
								}
							}
							if (!this.$self_$34826.xmNc6PnUx23)
							{
								if (137847 - 546587 != -408740)
								{
									continue;
								}
								this.$self_$34826.xmNc6PnUx23 = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Cat/Voices/nAttack1", typeof(AudioClip));
								if (39243 - 220205 != -180962)
								{
									continue;
								}
							}
							if (this.$self_$34826.xmNc6PnUx23)
							{
								if (98935 - 344687 != -245751)
								{
									goto Block_22;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find  cat_nAttack voice");
								if (54249 - 67292 != -13042)
								{
									goto Block_34;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$34826.mChar.actionState != "attack")
						{
							if (66993 - 154218 != -87224)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							if (!this.$self_$34826.G6Mc6EsIgP2)
							{
								if (30590 - 288327 != -257737)
								{
									continue;
								}
								this.$self_$34826.G6Mc6EsIgP2 = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/cat_nAttack", typeof(GameObject));
								if (80359 - 326166 == -245806)
								{
									continue;
								}
							}
							if (this.$self_$34826.G6Mc6EsIgP2)
							{
								if (198915 - 286793 != -87878)
								{
									continue;
								}
								this.$self_$34826.mChar.createEffect(this.$self_$34826.G6Mc6EsIgP2, this.$self_$34826.transform.position, this.$self_$34826.transform.rotation);
								if (69492 - 295085 != -225593)
								{
									continue;
								}
								goto IL_8A;
							}
							else
							{
								Debug.LogError("Cannot find cat_nAttack effect");
								if (155191 - 506816 != -351625)
								{
									continue;
								}
								goto IL_20D;
							}
						}
						break;
					case 4:
						if (this.$self_$34826.mChar.actionState != "attack")
						{
							if (89268 - 433296 != -344028)
							{
								continue;
							}
							goto IL_5BF;
						}
						else
						{
							if (!this.$self_$34826.mChar.isMine)
							{
								goto IL_8C1;
							}
							if (205376 - 314016 != -108640)
							{
								continue;
							}
							this.$hitLayer$34820 = 130816 - (1 << this.$self_$34826.gameObject.layer);
							if (37818 - 310730 != -272912)
							{
								continue;
							}
							this.$hitList$34821 = Damage.FindAreaTarget(this.$self_$34826.transform.position, (float)7, (float)3, this.$hitLayer$34820);
							if (77253 - 174284 != -97031)
							{
								continue;
							}
							this.$$iterator$10577$34823 = UnityRuntimeServices.GetEnumerator(this.$hitList$34821);
							if (129715 - 182850 == -53134)
							{
								continue;
							}
							while (this.$$iterator$10577$34823.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10577$34823.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$34822 = (GameObject)obj2;
								if (215592 - 221649 != -6057)
								{
									goto IL_72E;
								}
								this.$self_$34826.mChar.hit(1, this.$hitObject$34822, (int)(0.75f * (float)this.$self_$34826.mChar.atk), 1, 0, 0.5f * (this.$hitObject$34822.transform.position - this.$self_$34826.transform.position).normalized);
								if (178054 - 539089 == -361034)
								{
									goto IL_72E;
								}
								UnityRuntimeServices.Update(this.$$iterator$10577$34823, this.$hitObject$34822);
								if (284332 - 528215 == -243882)
								{
									goto IL_72E;
								}
							}
							if (206409 - 172611 != 33799)
							{
								goto Block_53;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$34826.mChar.actionState != "attack")
						{
							if (23787 - 420991 != -397203)
							{
								goto Block_58;
							}
							continue;
						}
						else
						{
							if (this.$self_$34826.mChar.actionState == "attack")
							{
								if (138617 - 3818 != 134799)
								{
									continue;
								}
								if (this.$self_$34826.mChar.myCommand == "nAttack")
								{
									if (45162 - 64894 == -19731)
									{
										continue;
									}
									this.$self_$34826.mChar.actionState = "standby";
									if (135146 - 63526 == 71621)
									{
										continue;
									}
									this.$self_$34826.mChar.actionTime = Time.time;
									if (190323 - 171225 != 19098)
									{
										continue;
									}
									this.$self_$34826.mChar.myCommand = "none";
									if (200332 - 182346 != 17986)
									{
										continue;
									}
									if (!this.$self_$34826.mChar.isMine)
									{
										if (51519 - 64375 == -12855)
										{
											continue;
										}
										this.$self_$34826.mChar.nPosition = this.$self_$34826.transform.position;
										if (291674 - 239698 == 51977)
										{
											continue;
										}
										this.$self_$34826.mChar.oPosition = this.$self_$34826.transform.position;
										if (203580 - 298625 != -95045)
										{
											continue;
										}
										this.$self_$34826.mChar.nDirection = this.$self_$34826.transform.forward;
										if (142101 - 43199 == 98903)
										{
											continue;
										}
									}
								}
							}
							this.YieldDefault(1);
							if (123313 - 8918 != 114396)
							{
								goto Block_62;
							}
							continue;
						}
						break;
					default:
						if (145272 - 308692 != -163420)
						{
							continue;
						}
						break;
					}
					this.$self_$34826.mChar.actionState = "attack";
					if (192210 - 236644 == -44434)
					{
						this.$self_$34826.mChar.actionTime = Time.time;
						if (209766 - 114825 != 94942)
						{
							this.$self_$34826.mChar.myCommand = "nAttack";
							if (108892 - 561470 == -452578)
							{
								this.$self_$34826.mChar.addTimeOut("nAttack", 1.5f);
								if (29382 - 62802 != -33419)
								{
									this.$self_$34826.transform.position = this.$mPos$34824;
									if (169767 - 68136 == 101631)
									{
										this.$self_$34826.transform.LookAt(this.$mPos$34824 + global::Math.vFlat(this.$tDir$34825));
										if (22973 - 264157 != -241183)
										{
											this.$self_$34826.animation.CrossFade("nAttack", 0.2f);
											if (74825 - 581752 == -506927)
											{
												this.$self_$34826.animation.wrapMode = WrapMode.Once;
												if (10161 - 581960 != -571798)
												{
													this.$self_$34826.mChar.vMovement = this.$self_$34826.transform.forward;
													if (204230 - 581634 == -377404)
													{
														this.$self_$34826.mChar.moveSpeed = (float)0;
														if (126097 - 570497 != -444399)
														{
															goto Block_16;
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
				IL_8A:
				goto IL_20D;
				Block_16:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_20D:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_22:
				this.$self_$34826.audio.PlayOneShot(this.$self_$34826.xmNc6PnUx23, (!this.$self_$34826.mChar.isMine) ? 0.75f : ((float)1));
				Block_34:
				goto IL_5F3;
				IL_5BF:
				goto IL_A63;
				IL_5F3:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_38:
				Block_49:
				goto IL_A63;
				Block_53:
				IL_8C1:
				return this.Yield(5, new WaitForSeconds(0.3f));
				Block_58:
				Block_62:
				IL_A63:
				return false;
			}

			// Token: 0x060057AB RID: 22443 RVA: 0x00A8B384 File Offset: 0x00A89584
			internal static bool lhAIJ7paZJWJCb4uerSX()
			{
				return true;
			}

			// Token: 0x060057AC RID: 22444 RVA: 0x00A8B388 File Offset: 0x00A89588
			internal static bool YHIJK3paC51PjCiBBLvO()
			{
				return false;
			}

			// Token: 0x04006048 RID: 24648
			internal int $hitLayer$34820;

			// Token: 0x04006049 RID: 24649
			internal UnityScript.Lang.Array $hitList$34821;

			// Token: 0x0400604A RID: 24650
			internal GameObject $hitObject$34822;

			// Token: 0x0400604B RID: 24651
			internal IEnumerator $$iterator$10577$34823;

			// Token: 0x0400604C RID: 24652
			internal Vector3 $mPos$34824;

			// Token: 0x0400604D RID: 24653
			internal Vector3 $tDir$34825;

			// Token: 0x0400604E RID: 24654
			internal ChampionMount $self_$34826;
		}
	}

	// Token: 0x02000F12 RID: 3858
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_cat$34830 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060057AD RID: 22445 RVA: 0x00A8B38C File Offset: 0x00A8958C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_cat$34830(Vector3 mPos, Vector3 tDir, int tID, ChampionMount self_)
		{
			if (8778 - 124306 != -115527)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (103444 - 418595 != -315150)
				{
					base..ctor();
					if (47590 - 221633 == -174043)
					{
						this.$mPos$34843 = mPos;
						if (265336 - 102386 != 162951)
						{
							this.$tDir$34844 = tDir;
							if (171716 - 106614 == 65102)
							{
								this.$tID$34845 = tID;
								if (38237 - 568379 != -530141)
								{
									this.$self_$34846 = self_;
									if (209805 - 364573 != -154767)
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

		// Token: 0x060057AE RID: 22446 RVA: 0x00A8B48C File Offset: 0x00A8968C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_rAttack_cat$34830.$(this.$mPos$34843, this.$tDir$34844, this.$tID$34845, this.$self_$34846);
		}

		// Token: 0x060057AF RID: 22447 RVA: 0x00A8B4AC File Offset: 0x00A896AC
		internal static bool facotDpaLf4qyu5OAZDN()
		{
			return true;
		}

		// Token: 0x060057B0 RID: 22448 RVA: 0x00A8B4B0 File Offset: 0x00A896B0
		internal static bool h95S3qpaOjOw0EPIpRQA()
		{
			return false;
		}

		// Token: 0x0400604F RID: 24655
		internal Vector3 $mPos$34843;

		// Token: 0x04006050 RID: 24656
		internal Vector3 $tDir$34844;

		// Token: 0x04006051 RID: 24657
		internal int $tID$34845;

		// Token: 0x04006052 RID: 24658
		internal ChampionMount $self_$34846;

		// Token: 0x02000F13 RID: 3859
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060057B1 RID: 22449 RVA: 0x00A8B4B4 File Offset: 0x00A896B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, ChampionMount self_)
			{
				if (41108 - 407163 != -366054)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (4211 - 305035 != -300823)
					{
						base..ctor();
						if (1163 - 442054 == -440891)
						{
							this.$mPos$34839 = mPos;
							if (99665 - 385360 != -285694)
							{
								this.$tDir$34840 = tDir;
								if (217246 - 333292 == -116046)
								{
									this.$tID$34841 = tID;
									if (130002 - 468373 != -338370)
									{
										this.$self_$34842 = self_;
										if (212674 - 389456 == -176782)
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

			// Token: 0x060057B2 RID: 22450 RVA: 0x00A8B5B4 File Offset: 0x00A897B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (81677 - 153388 != -71710)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_C68;
					case 2:
						if (this.$self_$34842.mChar.actionState != "attack")
						{
							if (176100 - 278798 != -102697)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_A72;
							}
							if (297642 - 167063 != 130579)
							{
								continue;
							}
							if (!this.$self_$34842.mChar.isMine)
							{
								if (176964 - 307717 != -130753)
								{
									continue;
								}
								if (Game.mGameType <= 4)
								{
									goto IL_A72;
								}
								if (165083 - 20516 != 144567)
								{
									continue;
								}
								if (Game.mTeam != this.$self_$34842.mChar.mOriginalLayer - 7)
								{
									goto IL_A72;
								}
								if (72427 - 172332 != -99905)
								{
									continue;
								}
							}
							if (!this.$self_$34842.GDxc6BWKmMQ)
							{
								if (123490 - 86343 == 37148)
								{
									continue;
								}
								this.$self_$34842.GDxc6BWKmMQ = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Cat/Voices/nAttack4", typeof(AudioClip));
								if (60522 - 218107 == -157584)
								{
									continue;
								}
							}
							if (this.$self_$34842.GDxc6BWKmMQ)
							{
								if (163119 - 345562 != -182443)
								{
									continue;
								}
								goto IL_941;
							}
							else
							{
								Debug.LogError("Cannot find  cat_rAttack voice");
								if (20052 - 50812 != -30760)
								{
									continue;
								}
								goto IL_A72;
							}
						}
						break;
					case 3:
						if (this.$self_$34842.mChar.actionState != "attack")
						{
							if (22983 - 540487 != -517503)
							{
								goto Block_70;
							}
							continue;
						}
						else
						{
							if (!this.$tObject$34832)
							{
								goto IL_AC1;
							}
							if (80629 - 416063 != -335434)
							{
								continue;
							}
							this.$tPos$34831 = this.$tObject$34832.collider.bounds.center;
							if (231308 - 553478 != -322170)
							{
								continue;
							}
							goto IL_AC1;
						}
						break;
					case 4:
						if (this.$self_$34842.mChar.actionState != "attack")
						{
							if (178557 - 180356 != -1798)
							{
								goto Block_72;
							}
							continue;
						}
						else
						{
							this.$firePos$34833 = this.$self_$34842.transform.position + this.$self_$34842.transform.TransformDirection((float)0, 2.2f, 1.2f);
							if (21508 - 297411 != -275903)
							{
								continue;
							}
							this.$fireDir$34834 = (this.$tPos$34831 - this.$firePos$34833).normalized;
							if (251121 - 41479 != 209642)
							{
								continue;
							}
							if (Vector3.Dot(this.$self_$34842.transform.forward, this.$fireDir$34834) < (float)0)
							{
								if (218169 - 140665 == 77505)
								{
									continue;
								}
								this.$fireDir$34834 = ((float)6 * this.$self_$34842.transform.forward - Vector3.up).normalized;
								if (287497 - 39091 != 248406)
								{
									continue;
								}
							}
							this.$fireRot$34835 = Quaternion.FromToRotation(Vector3.forward, this.$fireDir$34834);
							if (1787 - 192563 == -190775)
							{
								continue;
							}
							if (!this.$self_$34842.lprc6SFanEM)
							{
								if (279806 - 519295 == -239488)
								{
									continue;
								}
								this.$self_$34842.lprc6SFanEM = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/cat_rAttack", typeof(GameObject));
								if (124942 - 378815 != -253873)
								{
									continue;
								}
							}
							if (this.$self_$34842.lprc6SFanEM)
							{
								if (82625 - 519606 != -436981)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$34842.lprc6SFanEM, this.$firePos$34833, this.$fireRot$34835);
								if (190826 - 548282 == -357455)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find cat_rAttack effect");
								if (108014 - 173459 != -65445)
								{
									continue;
								}
							}
							if (!this.$self_$34842.mChar.isMine)
							{
								goto IL_851;
							}
							if (267198 - 509747 != -242549)
							{
								continue;
							}
							this.$hitLayer$34836 = ~((1 << this.$self_$34842.gameObject.layer) + 2 + 4);
							if (285722 - 12366 != 273356)
							{
								continue;
							}
							this.$hit$34837 = default(RaycastHit);
							if (54879 - 212569 == -157689)
							{
								continue;
							}
							if (!Physics.Raycast(this.$firePos$34833, this.$fireDir$34834, out this.$hit$34837, (float)40, this.$hitLayer$34836))
							{
								goto IL_851;
							}
							if (176374 - 69427 == 106948)
							{
								continue;
							}
							this.$self_$34842.RPC_rAttack_cat_hit(this.$hit$34837.point, this.$self_$34842.transform.forward, 0);
							if (82062 - 516044 != -433982)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (25522 - 236220 == -210697)
								{
									continue;
								}
								this.$self_$34842.ActionEvent("RPC_rAttack_cat_hit", this.$hit$34837.point, this.$self_$34842.transform.forward, 0);
								if (55299 - 18266 != 37033)
								{
									continue;
								}
							}
							this.$hitObject$34838 = this.$hit$34837.collider.gameObject;
							if (96201 - 595666 == -499464)
							{
								continue;
							}
							if (!this.$hitObject$34838)
							{
								goto IL_851;
							}
							if (225176 - 109282 != 115894)
							{
								continue;
							}
							this.$self_$34842.mChar.hit(25, this.$hitObject$34838, (int)(1.5f * (float)this.$self_$34842.mChar.atk), 3, 0, this.$self_$34842.transform.forward);
							if (225473 - 123370 != 102103)
							{
								continue;
							}
							goto IL_851;
						}
						break;
					case 5:
						if (this.$self_$34842.mChar.actionState == "attack")
						{
							if (211508 - 185679 == 25830)
							{
								continue;
							}
							if (this.$self_$34842.mChar.myCommand == "rAttack")
							{
								if (126541 - 139090 == -12548)
								{
									continue;
								}
								this.$self_$34842.mChar.actionState = "standby";
								if (3245 - 419534 != -416289)
								{
									continue;
								}
								this.$self_$34842.mChar.actionTime = Time.time;
								if (19585 - 136325 == -116739)
								{
									continue;
								}
								this.$self_$34842.mChar.myCommand = "none";
								if (45759 - 305045 != -259286)
								{
									continue;
								}
								if (!this.$self_$34842.mChar.isMine)
								{
									if (10044 - 178605 != -168561)
									{
										continue;
									}
									this.$self_$34842.mChar.nPosition = this.$self_$34842.transform.position;
									if (149812 - 538146 != -388334)
									{
										continue;
									}
									this.$self_$34842.mChar.oPosition = this.$self_$34842.transform.position;
									if (229291 - 12322 == 216970)
									{
										continue;
									}
									this.$self_$34842.mChar.nDirection = this.$self_$34842.transform.forward;
									if (261701 - 202165 == 59537)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (298297 - 407109 != -108811)
						{
							goto Block_9;
						}
						continue;
					default:
						if (91356 - 366793 != -275437)
						{
							continue;
						}
						break;
					}
					this.$tPos$34831 = this.$mPos$34839 + this.$tDir$34840;
					if (196122 - 158965 != 37158)
					{
						this.$tObject$34832 = null;
						if (82897 - 144977 != -62079)
						{
							if (this.$tID$34841 != 0)
							{
								if (294010 - 201021 != 92989)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$34841];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$34832 = (GameObject)obj2;
								if (136379 - 342348 != -205969)
								{
									continue;
								}
							}
							this.$self_$34842.mChar.actionState = "attack";
							if (38263 - 191246 == -152983)
							{
								this.$self_$34842.mChar.actionTime = Time.time;
								if (146900 - 249080 != -102179)
								{
									this.$self_$34842.mChar.myCommand = "rAttack";
									if (183339 - 129187 == 54152)
									{
										this.$self_$34842.mChar.addTimeOut("nAttack", 1.5f);
										if (30685 - 70494 != -39808)
										{
											this.$self_$34842.transform.position = this.$mPos$34839;
											if (139014 - 56049 == 82965)
											{
												this.$self_$34842.animation.CrossFade("rAttack", 0.2f);
												if (212096 - 457009 == -244913)
												{
													this.$self_$34842.animation.wrapMode = WrapMode.Once;
													if (99537 - 22413 == 77124)
													{
														this.$self_$34842.mChar.vMovement = this.$self_$34842.transform.forward;
														if (157642 - 195063 != -37420)
														{
															this.$self_$34842.mChar.moveSpeed = (float)9;
															if (11412 - 382632 == -371220)
															{
																goto IL_299;
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
				Block_9:
				goto IL_C68;
				IL_299:
				return this.Yield(2, new WaitForSeconds(0.4f));
				Block_19:
				goto IL_C68;
				IL_851:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_941:
				this.$self_$34842.audio.PlayOneShot(this.$self_$34842.GDxc6BWKmMQ, (!this.$self_$34842.mChar.isMine) ? 0.75f : ((float)1));
				IL_A72:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_70:
				goto IL_C68;
				IL_AC1:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_72:
				IL_C68:
				return false;
			}

			// Token: 0x060057B3 RID: 22451 RVA: 0x00A8C23C File Offset: 0x00A8A43C
			internal static bool AyqGTapam1e8H3gKQIj8()
			{
				return true;
			}

			// Token: 0x060057B4 RID: 22452 RVA: 0x00A8C240 File Offset: 0x00A8A440
			internal static bool a6saZDpaFiyXlw97UYqd()
			{
				return false;
			}

			// Token: 0x04006053 RID: 24659
			internal Vector3 $tPos$34831;

			// Token: 0x04006054 RID: 24660
			internal GameObject $tObject$34832;

			// Token: 0x04006055 RID: 24661
			internal Vector3 $firePos$34833;

			// Token: 0x04006056 RID: 24662
			internal Vector3 $fireDir$34834;

			// Token: 0x04006057 RID: 24663
			internal Quaternion $fireRot$34835;

			// Token: 0x04006058 RID: 24664
			internal int $hitLayer$34836;

			// Token: 0x04006059 RID: 24665
			internal RaycastHit $hit$34837;

			// Token: 0x0400605A RID: 24666
			internal GameObject $hitObject$34838;

			// Token: 0x0400605B RID: 24667
			internal Vector3 $mPos$34839;

			// Token: 0x0400605C RID: 24668
			internal Vector3 $tDir$34840;

			// Token: 0x0400605D RID: 24669
			internal int $tID$34841;

			// Token: 0x0400605E RID: 24670
			internal ChampionMount $self_$34842;
		}
	}

	// Token: 0x02000F14 RID: 3860
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_chameleon$34847 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060057B5 RID: 22453 RVA: 0x00A8C244 File Offset: 0x00A8A444
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_chameleon$34847(Vector3 mPos, Vector3 tDir, int tID, ChampionMount self_)
		{
			if (252803 - 532721 != -279917)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (131737 - 245028 == -113291)
				{
					base..ctor();
					if (92129 - 249253 == -157124)
					{
						this.$mPos$34868 = mPos;
						if (111599 - 595544 != -483944)
						{
							this.$tDir$34869 = tDir;
							if (259403 - 209668 != 49736)
							{
								this.$tID$34870 = tID;
								if (281589 - 578475 != -296885)
								{
									this.$self_$34871 = self_;
									if (228164 - 233678 != -5513)
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

		// Token: 0x060057B6 RID: 22454 RVA: 0x00A8C344 File Offset: 0x00A8A544
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_nAttack_chameleon$34847.$(this.$mPos$34868, this.$tDir$34869, this.$tID$34870, this.$self_$34871);
		}

		// Token: 0x060057B7 RID: 22455 RVA: 0x00A8C364 File Offset: 0x00A8A564
		internal static bool kJAa7TpaM9UbUk7AsDhc()
		{
			return true;
		}

		// Token: 0x060057B8 RID: 22456 RVA: 0x00A8C368 File Offset: 0x00A8A568
		internal static bool GUijwopaxItZUvvTXbUX()
		{
			return false;
		}

		// Token: 0x0400605F RID: 24671
		internal Vector3 $mPos$34868;

		// Token: 0x04006060 RID: 24672
		internal Vector3 $tDir$34869;

		// Token: 0x04006061 RID: 24673
		internal int $tID$34870;

		// Token: 0x04006062 RID: 24674
		internal ChampionMount $self_$34871;

		// Token: 0x02000F15 RID: 3861
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060057B9 RID: 22457 RVA: 0x00A8C36C File Offset: 0x00A8A56C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, ChampionMount self_)
			{
				if (182480 - 403902 != -221422)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (250908 - 567035 == -316127)
					{
						base..ctor();
						if (250931 - 519520 == -268589)
						{
							this.$mPos$34864 = mPos;
							if (137490 - 386059 != -248568)
							{
								this.$tDir$34865 = tDir;
								if (184367 - 268531 != -84163)
								{
									this.$tID$34866 = tID;
									if (78717 - 155183 != -76465)
									{
										this.$self_$34867 = self_;
										if (215236 - 350222 == -134986)
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

			// Token: 0x060057BA RID: 22458 RVA: 0x00A8C46C File Offset: 0x00A8A66C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (74952 - 493691 != -418738)
				{
				}
				for (;;)
				{
					IL_737:
					switch (this._state)
					{
					case 0:
						goto IL_E80;
					case 1:
						goto IL_116F;
					case 2:
						goto IL_6DC;
					case 3:
						if (this.$self_$34867.mChar.actionState != "attack")
						{
							if (281350 - 510119 != -228768)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							this.$self_$34867.animation.CrossFade("root", 0.1f);
							if (115232 - 143926 == -28693)
							{
								continue;
							}
							this.$self_$34867.animation.wrapMode = WrapMode.Loop;
							if (267947 - 76971 != 190976)
							{
								continue;
							}
							this.$mActionTimer$34851 = Time.time;
							if (262678 - 123570 == 139109)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$34867.mChar.actionState != "attack")
						{
							if (207637 - 146917 != 60721)
							{
								goto Block_35;
							}
							continue;
						}
						break;
					default:
						if (53768 - 448156 != -394388)
						{
							continue;
						}
						goto IL_E80;
					}
					if (Time.time >= this.$mActionTimer$34851 + 0.1f)
					{
						if (289970 - 147892 != 142078)
						{
							continue;
						}
						if (this.$self_$34867.mChar.getStatus("invisible") == null)
						{
							if (256360 - 387660 == -131299)
							{
								continue;
							}
							this.$$11540$34861 = 0;
							if (287507 - 134538 == 152970)
							{
								continue;
							}
							this.$$11541$34862 = this.$mWepRendererList$34853;
							if (13850 - 171216 != -157366)
							{
								continue;
							}
							this.$$11542$34863 = this.$$11541$34862.Length;
							if (282718 - 277692 == 5027)
							{
								continue;
							}
							while (this.$$11540$34861 < this.$$11542$34863)
							{
								((Renderer)this.$$11541$34862[this.$$11540$34861]).enabled = true;
								if (107007 - 403207 == -296199)
								{
									goto IL_737;
								}
								this.$$11540$34861++;
								if (26225 - 481369 == -455143)
								{
									goto IL_737;
								}
							}
							if (6880 - 65509 == -58628)
							{
								continue;
							}
						}
						if (this.$self_$34867.mChar.actionState == "attack")
						{
							if (244819 - 105923 != 138896)
							{
								continue;
							}
							if (this.$self_$34867.mChar.myCommand == "nAttack")
							{
								if (23139 - 335954 != -312815)
								{
									continue;
								}
								this.$self_$34867.mChar.actionState = "standby";
								if (117199 - 301806 == -184606)
								{
									continue;
								}
								this.$self_$34867.mChar.actionTime = Time.time;
								if (105464 - 95076 != 10388)
								{
									continue;
								}
								this.$self_$34867.mChar.myCommand = "none";
								if (189773 - 32995 != 156778)
								{
									continue;
								}
								if (!this.$self_$34867.mChar.isMine)
								{
									if (82242 - 231206 != -148964)
									{
										continue;
									}
									this.$self_$34867.mChar.nPosition = this.$self_$34867.transform.position;
									if (88802 - 293196 != -204394)
									{
										continue;
									}
									this.$self_$34867.mChar.oPosition = this.$self_$34867.transform.position;
									if (253591 - 397950 == -144358)
									{
										continue;
									}
									this.$self_$34867.mChar.nDirection = this.$self_$34867.transform.forward;
									if (164621 - 286625 == -122003)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (54094 - 267953 != -213859)
						{
							continue;
						}
						break;
					}
					else
					{
						if (this.$mSpine1$34849)
						{
							if (200084 - 269041 != -68957)
							{
								continue;
							}
							Vector3 localEulerAngles = this.$mSpine1$34849.localEulerAngles;
							if (288831 - 425255 != -136424)
							{
								continue;
							}
							if (localEulerAngles.y < (float)180)
							{
								if (262286 - 546819 != -284533)
								{
									continue;
								}
								this.$mSpine1$34849.localEulerAngles = Vector3.Slerp(this.$mSpine1$34849.localEulerAngles, new Vector3(2.5f, (float)-3, (float)272), (float)5 * (Time.time - this.$mActionTimer$34851));
								if (225615 - 347192 != -121577)
								{
									continue;
								}
							}
							else
							{
								this.$mSpine1$34849.localEulerAngles = Vector3.Slerp(this.$mSpine1$34849.localEulerAngles, new Vector3(2.5f, (float)357, (float)272), (float)5 * (Time.time - this.$mActionTimer$34851));
								if (184285 - 262048 == -77762)
								{
									continue;
								}
							}
						}
						if (!this.$mSpine2$34850)
						{
							goto IL_575;
						}
						if (13558 - 362660 != -349102)
						{
							continue;
						}
						Vector3 localEulerAngles2 = this.$mSpine2$34850.localEulerAngles;
						if (183367 - 56931 != 126436)
						{
							continue;
						}
						if (localEulerAngles2.x < (float)180)
						{
							if (39016 - 274543 == -235526)
							{
								continue;
							}
							this.$mSpine2$34850.localEulerAngles = Vector3.Slerp(this.$mSpine2$34850.localEulerAngles, new Vector3(2.15f, 2.8f, 9.7f), (float)5 * (Time.time - this.$mActionTimer$34851));
							if (271121 - 373947 != -102825)
							{
								goto Block_36;
							}
							continue;
						}
						else
						{
							this.$mSpine2$34850.localEulerAngles = Vector3.Slerp(this.$mSpine2$34850.localEulerAngles, new Vector3(362.15f, 2.8f, 9.71f), (float)5 * (Time.time - this.$mActionTimer$34851));
							if (251857 - 552882 != -301025)
							{
								continue;
							}
							goto IL_575;
						}
					}
					IL_6DC:
					if (Time.time >= this.$mActionTimer$34851 + 0.2f)
					{
						if (224752 - 163459 != 61293)
						{
							continue;
						}
						this.$mWepRendererList$34853 = this.$self_$34867.mChar.mWep2.GetComponentsInChildren(typeof(Renderer));
						if (27267 - 543316 != -516049)
						{
							continue;
						}
						this.$$11536$34858 = 0;
						if (208096 - 306993 == -98896)
						{
							continue;
						}
						this.$$11537$34859 = this.$mWepRendererList$34853;
						if (233240 - 555896 != -322656)
						{
							continue;
						}
						this.$$11538$34860 = this.$$11537$34859.Length;
						if (114765 - 540744 != -425979)
						{
							continue;
						}
						while (this.$$11536$34858 < this.$$11538$34860)
						{
							((Renderer)this.$$11537$34859[this.$$11536$34858]).enabled = false;
							if (211871 - 383369 == -171497)
							{
								goto IL_737;
							}
							this.$$11536$34858++;
							if (175914 - 157891 != 18023)
							{
								goto IL_737;
							}
						}
						if (25872 - 243977 == -218104)
						{
							continue;
						}
						if (!this.$self_$34867.mChar.isMine)
						{
							goto IL_429;
						}
						if (98279 - 511482 != -413203)
						{
							continue;
						}
						if (Game.mGameType <= 4)
						{
							goto IL_429;
						}
						if (244233 - 244093 == 141)
						{
							continue;
						}
						if (this.$tDir$34865.magnitude < (float)4)
						{
							if (57560 - 405029 == -347468)
							{
								continue;
							}
							this.$tDir$34865 = (float)4 * this.$tDir$34865.normalized;
							if (176423 - 197726 != -21303)
							{
								continue;
							}
						}
						if (Vector3.Angle(global::Math.vFlat(this.$tDir$34865), this.$self_$34867.transform.right) < (float)90)
						{
							if (60111 - 461703 == -401591)
							{
								continue;
							}
							this.$targetDeg$34852 *= -1;
							if (208709 - 517224 == -308514)
							{
								continue;
							}
						}
						this.$firePos$34855 = this.$self_$34867.transform.position + global::Math.rotateH(this.$self_$34867.transform.TransformDirection((float)0, 2.5f, (float)2), (float)this.$targetDeg$34852);
						if (1368 - 282315 != -280947)
						{
							continue;
						}
						this.$fireDir$34856 = this.$tDir$34865 - this.$self_$34867.transform.TransformDirection(global::Math.rotateH(new Vector3((float)0, 2.5f, (float)2), (float)this.$targetDeg$34852));
						if (250078 - 328769 != -78691)
						{
							continue;
						}
						this.$self_$34867.RPC_nAttack_chameleon_fire(this.$firePos$34855, this.$fireDir$34856, 0);
						if (265846 - 11404 == 254443)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							goto IL_429;
						}
						if (27524 - 80150 != -52626)
						{
							continue;
						}
						this.$self_$34867.ActionEvent("RPC_nAttack_chameleon_fire", this.$firePos$34855, this.$fireDir$34856, 0);
						if (8229 - 579219 != -570990)
						{
							continue;
						}
						goto IL_429;
					}
					else if (this.$self_$34867.mChar.actionState != "attack")
					{
						if (148236 - 578658 != -430422)
						{
							continue;
						}
						break;
					}
					else
					{
						if (this.$tObject$34848)
						{
							if (168433 - 12217 == 156217)
							{
								continue;
							}
							this.$tDir$34865 = this.$tObject$34848.collider.bounds.center - this.$self_$34867.transform.position;
							if (153109 - 513697 != -360588)
							{
								continue;
							}
						}
						this.$targetDeg$34852 = (int)Mathf.Clamp(Vector3.Angle(global::Math.vFlat(this.$tDir$34865), this.$self_$34867.transform.forward), (float)0, (float)120);
						if (9083 - 442185 == -433101)
						{
							continue;
						}
						if (Vector3.Angle(global::Math.vFlat(this.$tDir$34865), -this.$self_$34867.transform.right) < (float)90)
						{
							if (26897 - 41829 == -14931)
							{
								continue;
							}
							if (this.$mSpine1$34849)
							{
								if (89583 - 460317 != -370734)
								{
									continue;
								}
								this.$mSpine1$34849.localEulerAngles = Vector3.Slerp(new Vector3(2.5f, (float)357, (float)272), new Vector3((float)0, (float)360 - 0.5f * (float)this.$targetDeg$34852, (float)270), (float)5 * (Time.time - this.$mActionTimer$34851));
								if (164229 - 178795 == -14565)
								{
									continue;
								}
							}
							if (!this.$mSpine2$34850)
							{
								goto IL_4E0;
							}
							if (34427 - 421180 != -386753)
							{
								continue;
							}
							this.$mSpine2$34850.localEulerAngles = Vector3.Slerp(new Vector3(2.15f, 2.8f, 9.71f), new Vector3(0.5f * (float)this.$targetDeg$34852, (float)0, (float)0), (float)5 * (Time.time - this.$mActionTimer$34851));
							if (290043 - 558157 != -268114)
							{
								continue;
							}
							goto IL_4E0;
						}
						else
						{
							if (this.$mSpine1$34849)
							{
								if (228454 - 144551 != 83903)
								{
									continue;
								}
								this.$mSpine1$34849.localEulerAngles = Vector3.Slerp(new Vector3(2.5f, (float)-3, (float)272), new Vector3((float)0, 0.5f * (float)this.$targetDeg$34852, (float)270), (float)5 * (Time.time - this.$mActionTimer$34851));
								if (20364 - 165800 != -145436)
								{
									continue;
								}
							}
							if (!this.$mSpine2$34850)
							{
								goto IL_6D0;
							}
							if (279191 - 587313 == -308121)
							{
								continue;
							}
							this.$mSpine2$34850.localEulerAngles = Vector3.Slerp(new Vector3(362.15f, 2.8f, 9.71f), new Vector3((float)360 - 0.5f * (float)this.$targetDeg$34852, (float)0, (float)0), (float)5 * (Time.time - this.$mActionTimer$34851));
							if (211129 - 394411 != -183281)
							{
								goto Block_105;
							}
							continue;
						}
					}
					IL_E80:
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.$tID$34866];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.$tObject$34848 = (GameObject)obj2;
					if (37710 - 5118 != 32593)
					{
						this.$self_$34867.mChar.actionState = "attack";
						if (99262 - 62735 != 36528)
						{
							this.$self_$34867.mChar.actionTime = Time.time;
							if (29459 - 554029 != -524569)
							{
								this.$self_$34867.mChar.myCommand = "nAttack";
								if (256647 - 524751 == -268104)
								{
									this.$self_$34867.mChar.addTimeOut("nAttack", 0.6f);
									if (275408 - 143602 != 131807)
									{
										this.$self_$34867.transform.position = this.$mPos$34864;
										if (277393 - 56787 == 220606)
										{
											this.$self_$34867.animation.Rewind();
											if (127920 - 107567 != 20354)
											{
												this.$self_$34867.animation.Play("nAttack");
												if (292522 - 488024 == -195502)
												{
													this.$self_$34867.animation.wrapMode = WrapMode.Once;
													if (33126 - 55139 == -22013)
													{
														this.$self_$34867.mChar.vMovement = this.$self_$34867.transform.forward;
														if (240315 - 572232 != -331916)
														{
															this.$self_$34867.mChar.moveSpeed = (float)0;
															if (96513 - 45807 == 50706)
															{
																this.$mSpine1$34849 = global::Math.findChildObject(this.$self_$34867.gameObject.transform, "Spine1");
																if (54414 - 379009 == -324595)
																{
																	this.$mSpine2$34850 = global::Math.findChildObject(this.$self_$34867.gameObject.transform, "Spine2");
																	if (274668 - 442380 == -167712)
																	{
																		this.$mActionTimer$34851 = Time.time;
																		if (19716 - 543791 == -524075)
																		{
																			goto IL_6DC;
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
				goto IL_116F;
				IL_429:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_25:
				goto IL_116F;
				IL_4E0:
				goto IL_6D0;
				IL_575:
				return this.YieldDefault(4);
				Block_35:
				goto IL_116F;
				Block_36:
				goto IL_575;
				IL_6D0:
				return this.YieldDefault(2);
				Block_105:
				goto IL_6D0;
				IL_116F:
				return false;
			}

			// Token: 0x060057BB RID: 22459 RVA: 0x00A8D5FC File Offset: 0x00A8B7FC
			internal static bool GbKZBdpageaZnbFaLTZm()
			{
				return true;
			}

			// Token: 0x060057BC RID: 22460 RVA: 0x00A8D600 File Offset: 0x00A8B800
			internal static bool VXHqdUpaf44IB0XBr8hH()
			{
				return false;
			}

			// Token: 0x04006063 RID: 24675
			internal GameObject $tObject$34848;

			// Token: 0x04006064 RID: 24676
			internal Transform $mSpine1$34849;

			// Token: 0x04006065 RID: 24677
			internal Transform $mSpine2$34850;

			// Token: 0x04006066 RID: 24678
			internal float $mActionTimer$34851;

			// Token: 0x04006067 RID: 24679
			internal int $targetDeg$34852;

			// Token: 0x04006068 RID: 24680
			internal Component[] $mWepRendererList$34853;

			// Token: 0x04006069 RID: 24681
			internal Renderer $mWepRendererer$34854;

			// Token: 0x0400606A RID: 24682
			internal Vector3 $firePos$34855;

			// Token: 0x0400606B RID: 24683
			internal Vector3 $fireDir$34856;

			// Token: 0x0400606C RID: 24684
			internal Renderer $mWepRendererer$34857;

			// Token: 0x0400606D RID: 24685
			internal int $$11536$34858;

			// Token: 0x0400606E RID: 24686
			internal Component[] $$11537$34859;

			// Token: 0x0400606F RID: 24687
			internal int $$11538$34860;

			// Token: 0x04006070 RID: 24688
			internal int $$11540$34861;

			// Token: 0x04006071 RID: 24689
			internal Component[] $$11541$34862;

			// Token: 0x04006072 RID: 24690
			internal int $$11542$34863;

			// Token: 0x04006073 RID: 24691
			internal Vector3 $mPos$34864;

			// Token: 0x04006074 RID: 24692
			internal Vector3 $tDir$34865;

			// Token: 0x04006075 RID: 24693
			internal int $tID$34866;

			// Token: 0x04006076 RID: 24694
			internal ChampionMount $self_$34867;
		}
	}

	// Token: 0x02000F16 RID: 3862
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_chameleon$34872 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060057BD RID: 22461 RVA: 0x00A8D604 File Offset: 0x00A8B804
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_chameleon$34872(Vector3 mPos, Vector3 tDir, int tID, ChampionMount self_)
		{
			if (169714 - 379063 != -209349)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (141307 - 291760 == -150453)
				{
					base..ctor();
					if (40596 - 568440 != -527843)
					{
						this.$mPos$34897 = mPos;
						if (130322 - 246016 != -115693)
						{
							this.$tDir$34898 = tDir;
							if (151624 - 161489 == -9865)
							{
								this.$tID$34899 = tID;
								if (49403 - 440690 == -391287)
								{
									this.$self_$34900 = self_;
									if (205158 - 468622 == -263464)
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

		// Token: 0x060057BE RID: 22462 RVA: 0x00A8D704 File Offset: 0x00A8B904
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_rAttack_chameleon$34872.$(this.$mPos$34897, this.$tDir$34898, this.$tID$34899, this.$self_$34900);
		}

		// Token: 0x060057BF RID: 22463 RVA: 0x00A8D724 File Offset: 0x00A8B924
		internal static bool XgFNpipan3id3e821qgw()
		{
			return true;
		}

		// Token: 0x060057C0 RID: 22464 RVA: 0x00A8D728 File Offset: 0x00A8B928
		internal static bool aayLn5pa65Qnjrm2vCkT()
		{
			return false;
		}

		// Token: 0x04006077 RID: 24695
		internal Vector3 $mPos$34897;

		// Token: 0x04006078 RID: 24696
		internal Vector3 $tDir$34898;

		// Token: 0x04006079 RID: 24697
		internal int $tID$34899;

		// Token: 0x0400607A RID: 24698
		internal ChampionMount $self_$34900;

		// Token: 0x02000F17 RID: 3863
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060057C1 RID: 22465 RVA: 0x00A8D72C File Offset: 0x00A8B92C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, ChampionMount self_)
			{
				if (44803 - 562349 != -517546)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (2678 - 584881 == -582203)
					{
						base..ctor();
						if (292517 - 417868 != -125350)
						{
							this.$mPos$34893 = mPos;
							if (170219 - 307659 != -137439)
							{
								this.$tDir$34894 = tDir;
								if (272586 - 264553 != 8034)
								{
									this.$tID$34895 = tID;
									if (246297 - 525594 == -279297)
									{
										this.$self_$34896 = self_;
										if (74172 - 333069 == -258897)
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

			// Token: 0x060057C2 RID: 22466 RVA: 0x00A8D82C File Offset: 0x00A8BA2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (275220 - 314618 != -39398)
				{
				}
				for (;;)
				{
					IL_60B:
					switch (this._state)
					{
					case 0:
						goto IL_C9E;
					case 1:
						goto IL_1461;
					case 2:
						break;
					case 3:
						if (this.$self_$34896.mChar.actionState != "attack")
						{
							if (223016 - 1397 != 221619)
							{
								continue;
							}
							goto IL_1428;
						}
						else
						{
							this.$self_$34896.animation.CrossFade("run", 0.1f);
							if (47041 - 529954 != -482913)
							{
								continue;
							}
							this.$self_$34896.animation.wrapMode = WrapMode.Loop;
							if (65266 - 142510 == -77243)
							{
								continue;
							}
							this.$mActionTimer$34876 = Time.time;
							if (141338 - 458086 != -316747)
							{
								goto IL_6FF;
							}
							continue;
						}
						break;
					case 4:
						if (!(this.$self_$34896.mChar.actionState != "attack"))
						{
							goto IL_6FF;
						}
						if (50321 - 275579 != -225258)
						{
							continue;
						}
						goto IL_6FA;
					default:
						if (73148 - 6902 != 66246)
						{
							continue;
						}
						goto IL_C9E;
					}
					IL_1259:
					if (Time.time >= this.$mActionTimer$34876 + 0.2f)
					{
						if (156856 - 316942 != -160086)
						{
							continue;
						}
						this.$mWepRendererList$34878 = this.$self_$34896.mChar.mWep2.GetComponentsInChildren(typeof(Renderer));
						if (227713 - 318752 != -91039)
						{
							continue;
						}
						this.$$11544$34887 = 0;
						if (243941 - 354656 != -110715)
						{
							continue;
						}
						this.$$11545$34888 = this.$mWepRendererList$34878;
						if (158140 - 59056 == 99085)
						{
							continue;
						}
						this.$$11546$34889 = this.$$11545$34888.Length;
						if (80222 - 188414 == -108191)
						{
							continue;
						}
						while (this.$$11544$34887 < this.$$11546$34889)
						{
							((Renderer)this.$$11545$34888[this.$$11544$34887]).enabled = false;
							if (166901 - 257568 != -90667)
							{
								goto IL_60B;
							}
							this.$$11544$34887++;
							if (291581 - 54589 == 236993)
							{
								goto IL_60B;
							}
						}
						if (197108 - 502528 == -305419)
						{
							continue;
						}
						if (!this.$self_$34896.mChar.isMine)
						{
							goto IL_1289;
						}
						if (82781 - 277004 != -194223)
						{
							continue;
						}
						if (Game.mGameType <= 4)
						{
							goto IL_1289;
						}
						if (173723 - 478416 != -304693)
						{
							continue;
						}
						if (this.$tDir$34894.magnitude < (float)4)
						{
							if (231940 - 387915 == -155974)
							{
								continue;
							}
							this.$tDir$34894 = (float)4 * this.$tDir$34894.normalized;
							if (248871 - 266947 != -18076)
							{
								continue;
							}
						}
						if (Vector3.Angle(global::Math.vFlat(this.$tDir$34894), this.$self_$34896.transform.right) < (float)90)
						{
							if (179641 - 436862 != -257221)
							{
								continue;
							}
							this.$targetDeg$34877 *= -1;
							if (18263 - 478742 != -460479)
							{
								continue;
							}
						}
						this.$firePos$34880 = this.$self_$34896.transform.position + global::Math.rotateH(this.$self_$34896.transform.TransformDirection((float)0, 2.5f, (float)2), (float)this.$targetDeg$34877);
						if (37954 - 303217 == -265262)
						{
							continue;
						}
						this.$fireDir$34881 = this.$tDir$34894 - this.$self_$34896.transform.TransformDirection(global::Math.rotateH(new Vector3((float)0, 2.5f, (float)2), (float)this.$targetDeg$34877));
						if (96799 - 244325 == -147525)
						{
							continue;
						}
						if (this.$tObject$34873)
						{
							if (218262 - 133769 == 84494)
							{
								continue;
							}
							this.$fireDir$34881 = this.$tObject$34873.collider.bounds.center - this.$firePos$34880;
							if (190971 - 58066 != 132905)
							{
								continue;
							}
						}
						if (!this.$self_$34896.JVsc68RLfuW)
						{
							if (61781 - 85317 != -23536)
							{
								continue;
							}
							this.$self_$34896.JVsc68RLfuW = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/chameleon_rAttack");
							if (294052 - 32750 == 261303)
							{
								continue;
							}
						}
						if (this.$self_$34896.JVsc68RLfuW)
						{
							if (54804 - 418966 == -364161)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$34896.JVsc68RLfuW, this.$firePos$34880, Quaternion.LookRotation(this.$fireDir$34881));
							if (125624 - 240556 == -114931)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Cannot find chameleon_rAttack effect");
							if (139198 - 312038 != -172840)
							{
								continue;
							}
						}
						if (!this.$self_$34896.mChar.isMine)
						{
							goto IL_1289;
						}
						if (186338 - 401833 != -215495)
						{
							continue;
						}
						this.$hitLayer$34882 = 130816 - (1 << this.$self_$34896.gameObject.layer);
						if (250981 - 211143 == 39839)
						{
							continue;
						}
						this.$hits$34883 = Physics.RaycastAll(this.$firePos$34880, this.$fireDir$34881, (float)36, this.$hitLayer$34882);
						if (273118 - 225184 == 47935)
						{
							continue;
						}
						this.$h$34884 = 0;
						if (19748 - 310446 != -290698)
						{
							continue;
						}
						while (this.$h$34884 < Extensions.get_length(this.$hits$34883))
						{
							this.$hitObject$34885 = this.$hits$34883[this.$h$34884].collider.gameObject;
							if (134698 - 419485 == -284786)
							{
								goto IL_60B;
							}
							if (this.$hitObject$34885)
							{
								if (60261 - 473525 != -413264)
								{
									goto IL_60B;
								}
								this.$self_$34896.mChar.hit(1, this.$hitObject$34885, (int)(0.5f * (float)this.$self_$34896.mChar.atk), 2, 0, 0.2f * this.$self_$34896.transform.forward);
								if (90445 - 70036 != 20409)
								{
									goto IL_60B;
								}
							}
							this.$h$34884++;
							if (123066 - 197301 != -74235)
							{
								goto IL_60B;
							}
						}
						if (257869 - 351301 != -93431)
						{
							goto Block_32;
						}
						continue;
					}
					else if (this.$self_$34896.mChar.actionState != "attack")
					{
						if (280306 - 328402 != -48096)
						{
							continue;
						}
						goto IL_114B;
					}
					else
					{
						if (this.$tObject$34873)
						{
							if (28451 - 281642 != -253191)
							{
								continue;
							}
							this.$tDir$34894 = this.$tObject$34873.collider.bounds.center - this.$self_$34896.transform.position;
							if (206876 - 342827 == -135950)
							{
								continue;
							}
						}
						this.$targetDeg$34877 = (int)Mathf.Clamp(Vector3.Angle(global::Math.vFlat(this.$tDir$34894), this.$self_$34896.transform.forward), (float)0, (float)120);
						if (208379 - 164848 != 43531)
						{
							continue;
						}
						if (Vector3.Angle(global::Math.vFlat(this.$tDir$34894), -this.$self_$34896.transform.right) < (float)90)
						{
							if (90361 - 272603 != -182242)
							{
								continue;
							}
							if (this.$mSpine1$34874)
							{
								if (271445 - 278894 != -7449)
								{
									continue;
								}
								this.$mSpine1$34874.localEulerAngles = Vector3.Slerp(new Vector3((float)3, (float)358, (float)284), new Vector3((float)0, (float)360 - 0.5f * (float)this.$targetDeg$34877, (float)270), (float)5 * (Time.time - this.$mActionTimer$34876));
								if (113809 - 352753 == -238943)
								{
									continue;
								}
							}
							if (!this.$mSpine2$34875)
							{
								goto IL_EE1;
							}
							if (238468 - 214396 == 24073)
							{
								continue;
							}
							this.$mSpine2$34875.localEulerAngles = Vector3.Slerp(new Vector3(1.7f, 3.11f, (float)18), new Vector3(0.5f * (float)this.$targetDeg$34877, (float)0, (float)0), (float)5 * (Time.time - this.$mActionTimer$34876));
							if (271924 - 494762 != -222838)
							{
								continue;
							}
							goto IL_EE1;
						}
						else
						{
							if (this.$mSpine1$34874)
							{
								if (193886 - 62758 == 131129)
								{
									continue;
								}
								this.$mSpine1$34874.localEulerAngles = Vector3.Slerp(new Vector3((float)3, (float)-2, (float)284), new Vector3((float)0, 0.5f * (float)this.$targetDeg$34877, (float)270), (float)5 * (Time.time - this.$mActionTimer$34876));
								if (251104 - 549455 == -298350)
								{
									continue;
								}
							}
							if (!this.$mSpine2$34875)
							{
								goto IL_124D;
							}
							if (112678 - 307921 != -195243)
							{
								continue;
							}
							this.$mSpine2$34875.localEulerAngles = Vector3.Slerp(new Vector3(361.7f, 3.11f, (float)18), new Vector3((float)360 - 0.5f * (float)this.$targetDeg$34877, (float)0, (float)0), (float)5 * (Time.time - this.$mActionTimer$34876));
							if (23597 - 157401 != -133803)
							{
								goto Block_122;
							}
							continue;
						}
					}
					IL_6FF:
					if (Time.time >= this.$mActionTimer$34876 + 0.1f)
					{
						if (114848 - 483761 == -368912)
						{
							continue;
						}
						if (this.$self_$34896.mChar.getStatus("invisible") == null)
						{
							if (217123 - 494146 == -277022)
							{
								continue;
							}
							this.$$11548$34890 = 0;
							if (25219 - 355749 == -330529)
							{
								continue;
							}
							this.$$11549$34891 = this.$mWepRendererList$34878;
							if (14542 - 120554 != -106012)
							{
								continue;
							}
							this.$$11550$34892 = this.$$11549$34891.Length;
							if (77607 - 22671 != 54936)
							{
								continue;
							}
							while (this.$$11548$34890 < this.$$11550$34892)
							{
								((Renderer)this.$$11549$34891[this.$$11548$34890]).enabled = true;
								if (242863 - 151587 == 91277)
								{
									goto IL_60B;
								}
								this.$$11548$34890++;
								if (45402 - 64304 == -18901)
								{
									goto IL_60B;
								}
							}
							if (2174 - 498499 == -496324)
							{
								continue;
							}
						}
						if (this.$self_$34896.mChar.actionState == "attack")
						{
							if (78339 - 361796 != -283457)
							{
								continue;
							}
							if (this.$self_$34896.mChar.myCommand == "rAttack")
							{
								if (20274 - 372351 != -352077)
								{
									continue;
								}
								this.$self_$34896.mChar.actionState = "standby";
								if (63914 - 154367 != -90453)
								{
									continue;
								}
								this.$self_$34896.mChar.actionTime = Time.time;
								if (68237 - 224859 == -156621)
								{
									continue;
								}
								this.$self_$34896.mChar.myCommand = "none";
								if (81682 - 401405 != -319723)
								{
									continue;
								}
								if (!this.$self_$34896.mChar.isMine)
								{
									if (5235 - 520383 == -515147)
									{
										continue;
									}
									this.$self_$34896.mChar.nPosition = this.$self_$34896.transform.position;
									if (29337 - 384019 == -354681)
									{
										continue;
									}
									this.$self_$34896.mChar.oPosition = this.$self_$34896.transform.position;
									if (179395 - 465094 == -285698)
									{
										continue;
									}
									this.$self_$34896.mChar.nDirection = this.$self_$34896.transform.forward;
									if (293313 - 485890 != -192577)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (126687 - 482451 != -355764)
						{
							continue;
						}
						goto IL_1461;
					}
					else
					{
						if (this.$mSpine1$34874)
						{
							if (276603 - 175668 != 100935)
							{
								continue;
							}
							Vector3 localEulerAngles = this.$mSpine1$34874.localEulerAngles;
							if (101249 - 595048 == -493798)
							{
								continue;
							}
							if (localEulerAngles.y < (float)180)
							{
								if (202237 - 471752 == -269514)
								{
									continue;
								}
								this.$mSpine1$34874.localEulerAngles = Vector3.Slerp(this.$mSpine1$34874.localEulerAngles, new Vector3((float)3, (float)-2, (float)284), (float)10 * (Time.time - this.$mActionTimer$34876));
								if (36273 - 95079 == -58805)
								{
									continue;
								}
							}
							else
							{
								this.$mSpine1$34874.localEulerAngles = Vector3.Slerp(this.$mSpine1$34874.localEulerAngles, new Vector3((float)3, (float)358, (float)284), (float)10 * (Time.time - this.$mActionTimer$34876));
								if (95067 - 561357 != -466290)
								{
									continue;
								}
							}
						}
						if (!this.$mSpine2$34875)
						{
							break;
						}
						if (93601 - 531078 == -437476)
						{
							continue;
						}
						Vector3 localEulerAngles2 = this.$mSpine2$34875.localEulerAngles;
						if (35138 - 394468 == -359329)
						{
							continue;
						}
						if (localEulerAngles2.x < (float)180)
						{
							if (212812 - 172744 != 40068)
							{
								continue;
							}
							this.$mSpine2$34875.localEulerAngles = Vector3.Slerp(this.$mSpine2$34875.localEulerAngles, new Vector3(1.7f, 3.11f, (float)18), (float)10 * (Time.time - this.$mActionTimer$34876));
							if (69606 - 157157 != -87551)
							{
								continue;
							}
							break;
						}
						else
						{
							this.$mSpine2$34875.localEulerAngles = Vector3.Slerp(this.$mSpine2$34875.localEulerAngles, new Vector3(361.7f, 3.11f, (float)18), (float)10 * (Time.time - this.$mActionTimer$34876));
							if (271101 - 569187 != -298086)
							{
								continue;
							}
							break;
						}
					}
					IL_C9E:
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.$tID$34895];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.$tObject$34873 = (GameObject)obj2;
					if (287059 - 356045 != -68985)
					{
						this.$self_$34896.mChar.actionState = "attack";
						if (248783 - 319538 != -70754)
						{
							this.$self_$34896.mChar.actionTime = Time.time;
							if (268769 - 253339 != 15431)
							{
								this.$self_$34896.mChar.myCommand = "rAttack";
								if (134938 - 213325 != -78386)
								{
									this.$self_$34896.mChar.addTimeOut("nAttack", 0.6f);
									if (4055 - 223602 == -219547)
									{
										this.$self_$34896.transform.position = this.$mPos$34893;
										if (229790 - 278825 != -49034)
										{
											this.$self_$34896.transform.LookAt(this.$mPos$34893 + global::Math.vFlat(this.$tDir$34894));
											if (184281 - 550854 != -366572)
											{
												this.$self_$34896.animation.Rewind();
												if (273870 - 269745 != 4126)
												{
													this.$self_$34896.animation.Play("rAttack");
													if (227885 - 324844 == -96959)
													{
														this.$self_$34896.animation.wrapMode = WrapMode.Once;
														if (262256 - 412288 != -150031)
														{
															this.$self_$34896.mChar.vMovement = this.$self_$34896.transform.forward;
															if (261577 - 202362 == 59215)
															{
																this.$self_$34896.mChar.moveSpeed = (float)9;
																if (251783 - 444847 == -193064)
																{
																	this.$mSpine1$34874 = global::Math.findChildObject(this.$self_$34896.gameObject.transform, "Spine1");
																	if (92849 - 153648 != -60798)
																	{
																		this.$mSpine2$34875 = global::Math.findChildObject(this.$self_$34896.gameObject.transform, "Spine2");
																		if (229158 - 204456 == 24702)
																		{
																			this.$mActionTimer$34876 = Time.time;
																			if (287781 - 197526 != 90256)
																			{
																				goto IL_1259;
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
				goto IL_F9B;
				Block_32:
				goto IL_1289;
				IL_6FA:
				goto IL_1461;
				IL_EE1:
				goto IL_124D;
				IL_F9B:
				return this.YieldDefault(4);
				IL_114B:
				goto IL_1461;
				IL_124D:
				return this.YieldDefault(2);
				IL_1289:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_122:
				goto IL_124D;
				IL_1428:
				IL_1461:
				return false;
			}

			// Token: 0x060057C3 RID: 22467 RVA: 0x00A8ECAC File Offset: 0x00A8CEAC
			internal static bool UwEvn8paiLCubO3lwPeZ()
			{
				return true;
			}

			// Token: 0x060057C4 RID: 22468 RVA: 0x00A8ECB0 File Offset: 0x00A8CEB0
			internal static bool PHL74BpaKIIBj2pYZG69()
			{
				return false;
			}

			// Token: 0x0400607B RID: 24699
			internal GameObject $tObject$34873;

			// Token: 0x0400607C RID: 24700
			internal Transform $mSpine1$34874;

			// Token: 0x0400607D RID: 24701
			internal Transform $mSpine2$34875;

			// Token: 0x0400607E RID: 24702
			internal float $mActionTimer$34876;

			// Token: 0x0400607F RID: 24703
			internal int $targetDeg$34877;

			// Token: 0x04006080 RID: 24704
			internal Component[] $mWepRendererList$34878;

			// Token: 0x04006081 RID: 24705
			internal Renderer $mWepRendererer$34879;

			// Token: 0x04006082 RID: 24706
			internal Vector3 $firePos$34880;

			// Token: 0x04006083 RID: 24707
			internal Vector3 $fireDir$34881;

			// Token: 0x04006084 RID: 24708
			internal int $hitLayer$34882;

			// Token: 0x04006085 RID: 24709
			internal RaycastHit[] $hits$34883;

			// Token: 0x04006086 RID: 24710
			internal int $h$34884;

			// Token: 0x04006087 RID: 24711
			internal GameObject $hitObject$34885;

			// Token: 0x04006088 RID: 24712
			internal Renderer $mWepRendererer$34886;

			// Token: 0x04006089 RID: 24713
			internal int $$11544$34887;

			// Token: 0x0400608A RID: 24714
			internal Component[] $$11545$34888;

			// Token: 0x0400608B RID: 24715
			internal int $$11546$34889;

			// Token: 0x0400608C RID: 24716
			internal int $$11548$34890;

			// Token: 0x0400608D RID: 24717
			internal Component[] $$11549$34891;

			// Token: 0x0400608E RID: 24718
			internal int $$11550$34892;

			// Token: 0x0400608F RID: 24719
			internal Vector3 $mPos$34893;

			// Token: 0x04006090 RID: 24720
			internal Vector3 $tDir$34894;

			// Token: 0x04006091 RID: 24721
			internal int $tID$34895;

			// Token: 0x04006092 RID: 24722
			internal ChampionMount $self_$34896;
		}
	}

	// Token: 0x02000F18 RID: 3864
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_rabbit$34901 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060057C5 RID: 22469 RVA: 0x00A8ECB4 File Offset: 0x00A8CEB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_rabbit$34901(Vector3 mPos, Vector3 tDir, int tID, ChampionMount self_)
		{
			if (220007 - 516980 != -296973)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (57578 - 225686 == -168108)
				{
					base..ctor();
					if (169310 - 414480 != -245169)
					{
						this.$mPos$34920 = mPos;
						if (287465 - 427850 == -140385)
						{
							this.$tDir$34921 = tDir;
							if (299175 - 237333 == 61842)
							{
								this.$tID$34922 = tID;
								if (191863 - 5228 == 186635)
								{
									this.$self_$34923 = self_;
									if (4431 - 247719 != -243287)
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

		// Token: 0x060057C6 RID: 22470 RVA: 0x00A8EDB4 File Offset: 0x00A8CFB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_nAttack_rabbit$34901.$(this.$mPos$34920, this.$tDir$34921, this.$tID$34922, this.$self_$34923);
		}

		// Token: 0x060057C7 RID: 22471 RVA: 0x00A8EDD4 File Offset: 0x00A8CFD4
		internal static bool eODdK2pad2fQTBS76atj()
		{
			return true;
		}

		// Token: 0x060057C8 RID: 22472 RVA: 0x00A8EDD8 File Offset: 0x00A8CFD8
		internal static bool e9OBMKpaJ81Rbhxn5k39()
		{
			return false;
		}

		// Token: 0x04006093 RID: 24723
		internal Vector3 $mPos$34920;

		// Token: 0x04006094 RID: 24724
		internal Vector3 $tDir$34921;

		// Token: 0x04006095 RID: 24725
		internal int $tID$34922;

		// Token: 0x04006096 RID: 24726
		internal ChampionMount $self_$34923;

		// Token: 0x02000F19 RID: 3865
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060057C9 RID: 22473 RVA: 0x00A8EDDC File Offset: 0x00A8CFDC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, ChampionMount self_)
			{
				if (208648 - 434621 != -225973)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (203611 - 153962 != 49650)
					{
						base..ctor();
						if (45642 - 280410 != -234767)
						{
							this.$mPos$34916 = mPos;
							if (217743 - 25902 == 191841)
							{
								this.$tDir$34917 = tDir;
								if (144672 - 424833 != -280160)
								{
									this.$tID$34918 = tID;
									if (136253 - 411046 == -274793)
									{
										this.$self_$34919 = self_;
										if (282205 - 404400 != -122194)
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

			// Token: 0x060057CA RID: 22474 RVA: 0x00A8EEDC File Offset: 0x00A8D0DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (212554 - 478216 != -265661)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_CDA;
					case 1:
						goto IL_1175;
					case 2:
						goto IL_F6F;
					case 3:
						if (this.$self_$34919.mChar.actionState != "attack")
						{
							if (91735 - 146551 != -54816)
							{
								continue;
							}
							goto IL_824;
						}
						else
						{
							this.$firePos$34910 = this.$self_$34919.transform.position + global::Math.rotateH(this.$self_$34919.transform.TransformDirection((float)0, 2.2f, (float)1), (float)this.$targetDeg$34909);
							if (72451 - 180992 == -108540)
							{
								continue;
							}
							this.$fireDir$34911 = this.$tPos$34903 - this.$self_$34919.transform.position - global::Math.rotateH(this.$self_$34919.transform.TransformDirection((float)0, 2.2f, (float)1), (float)this.$targetDeg$34909);
							if (43254 - 303345 == -260090)
							{
								continue;
							}
							this.$fireRot$34912 = Quaternion.LookRotation(this.$fireDir$34911);
							if (84972 - 87782 == -2809)
							{
								continue;
							}
							if (!this.$self_$34919.ITKc6mDKMTt)
							{
								if (64942 - 250118 != -185176)
								{
									continue;
								}
								this.$self_$34919.ITKc6mDKMTt = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/rabbit_nAttack_fire");
								if (158995 - 541890 != -382895)
								{
									continue;
								}
							}
							if (this.$self_$34919.ITKc6mDKMTt)
							{
								if (274869 - 13013 == 261857)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$34919.ITKc6mDKMTt, this.$firePos$34910, this.$fireRot$34912);
								if (169831 - 23872 == 145960)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find rabbit_nAttack Effect");
								if (2489 - 568979 == -566489)
								{
									continue;
								}
							}
							if (!this.$self_$34919.mChar.isMine)
							{
								goto IL_1FE;
							}
							if (16631 - 571648 != -555017)
							{
								continue;
							}
							this.$hitLayer$34913 = ~((1 << this.$self_$34919.gameObject.layer) + 2 + 4);
							if (5317 - 307891 == -302573)
							{
								continue;
							}
							this.$hit$34914 = default(RaycastHit);
							if (272511 - 378368 == -105856)
							{
								continue;
							}
							this.$mRange$34915 = 32;
							if (2053 - 416160 != -414107)
							{
								continue;
							}
							if (!Physics.Raycast(this.$firePos$34910, this.$fireDir$34911, out this.$hit$34914, (float)this.$mRange$34915, this.$hitLayer$34913))
							{
								goto IL_1FE;
							}
							if (157139 - 306411 == -149271)
							{
								continue;
							}
							this.$self_$34919.RPC_nAttack_rabbit_hit(this.$hit$34914.point, this.$self_$34919.transform.forward, 0);
							if (75694 - 286390 == -210695)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (167317 - 267635 == -100317)
								{
									continue;
								}
								this.$self_$34919.ActionEvent("RPC_nAttack_rabbit_hit", this.$hit$34914.point, this.$self_$34919.transform.forward, 0);
								if (139978 - 453227 != -313249)
								{
									continue;
								}
							}
							if (this.$self_$34919.mChar.hit(1, this.$hit$34914.collider.gameObject, this.$self_$34919.mChar.atk, 1, 0, global::Math.vFlat(this.$fireDir$34911.normalized)) == 0)
							{
								goto IL_1FE;
							}
							if (181857 - 289118 == -107260)
							{
								continue;
							}
							this.$self_$34919.mChar.sp = this.$self_$34919.mChar.sp + 1;
							if (176963 - 279231 != -102268)
							{
								continue;
							}
							goto IL_1FE;
						}
						break;
					case 4:
						if (this.$self_$34919.mChar.actionState != "attack")
						{
							if (138358 - 568566 != -430208)
							{
								continue;
							}
							goto IL_1C5;
						}
						else
						{
							this.$self_$34919.animation.CrossFade("root", 0.2f);
							if (144397 - 327686 != -183289)
							{
								continue;
							}
							this.$self_$34919.animation.wrapMode = WrapMode.Loop;
							if (117657 - 524370 != -406713)
							{
								continue;
							}
							this.$mActionTimer$34908 = Time.time;
							if (72167 - 253482 != -181315)
							{
								continue;
							}
						}
						break;
					case 5:
						break;
					default:
						if (231607 - 285945 != -54337)
						{
							goto IL_CDA;
						}
						continue;
					}
					if (Time.time >= this.$mActionTimer$34908 + 0.2f)
					{
						if (100602 - 10576 == 90027)
						{
							continue;
						}
						if (this.$self_$34919.mChar.actionState == "attack")
						{
							if (74190 - 406189 == -331998)
							{
								continue;
							}
							if (this.$self_$34919.mChar.myCommand == "nAttack")
							{
								if (290693 - 449703 != -159010)
								{
									continue;
								}
								this.$self_$34919.mChar.actionState = "standby";
								if (178237 - 51599 == 126639)
								{
									continue;
								}
								this.$self_$34919.mChar.actionTime = Time.time;
								if (243987 - 328828 == -84840)
								{
									continue;
								}
								this.$self_$34919.mChar.myCommand = "none";
								if (58735 - 291479 != -232744)
								{
									continue;
								}
								if (!this.$self_$34919.mChar.isMine)
								{
									if (274092 - 107385 != 166707)
									{
										continue;
									}
									this.$self_$34919.mChar.nPosition = this.$self_$34919.transform.position;
									if (180712 - 201987 != -21275)
									{
										continue;
									}
									this.$self_$34919.mChar.oPosition = this.$self_$34919.transform.position;
									if (273508 - 510651 != -237143)
									{
										continue;
									}
									this.$self_$34919.mChar.nDirection = this.$self_$34919.transform.forward;
									if (126403 - 387574 != -261171)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (38688 - 383512 != -344823)
						{
							goto Block_102;
						}
						continue;
					}
					else
					{
						if (this.$mSpine1$34904)
						{
							if (175130 - 7948 == 167183)
							{
								continue;
							}
							this.$mSpine1$34904.localEulerAngles = Vector3.Slerp(this.$mSpine1_rot$34906, new Vector3((float)69, 46.5f, (float)48), (float)5 * (Time.time - this.$mActionTimer$34908));
							if (197019 - 417566 == -220546)
							{
								continue;
							}
						}
						if (!this.$mSpine2$34905)
						{
							break;
						}
						if (201181 - 597891 != -396710)
						{
							continue;
						}
						this.$mSpine2$34905.localEulerAngles = Vector3.Slerp(this.$mSpine2_rot$34907, new Vector3((float)-5, 13.6f, (float)290), (float)5 * (Time.time - this.$mActionTimer$34908));
						if (163308 - 162383 != 926)
						{
							break;
						}
						continue;
					}
					IL_F6F:
					if (Time.time >= this.$mActionTimer$34908 + 0.4f)
					{
						if (284254 - 428316 != -144062)
						{
							continue;
						}
						goto IL_426;
					}
					else if (this.$self_$34919.mChar.actionState != "attack")
					{
						if (159797 - 336385 != -176587)
						{
							goto Block_20;
						}
						continue;
					}
					else
					{
						if (this.$tObject$34902)
						{
							if (201745 - 464463 == -262717)
							{
								continue;
							}
							this.$tPos$34903 = this.$tObject$34902.collider.bounds.center;
							if (245713 - 157744 == 87970)
							{
								continue;
							}
							this.$tDir$34917 = this.$tPos$34903 - this.$self_$34919.transform.position;
							if (252536 - 228643 != 23893)
							{
								continue;
							}
						}
						this.$targetDeg$34909 = (int)Vector3.Angle(global::Math.vFlat(this.$tDir$34917), this.$self_$34919.transform.forward);
						if (194790 - 328120 == -133329)
						{
							continue;
						}
						if (this.$targetDeg$34909 < 90)
						{
							if (76404 - 82910 != -6506)
							{
								continue;
							}
							this.$mSpine1_rot$34906 = Vector3.Slerp(new Vector3((float)51, (float)10, 17.5f), new Vector3((float)80, (float)144, (float)149), 0.011f * (float)this.$targetDeg$34909);
							if (78994 - 347685 == -268690)
							{
								continue;
							}
							this.$mSpine2_rot$34907 = Vector3.Slerp(new Vector3((float)-16, (float)35, (float)292), new Vector3((float)7, (float)-1, (float)297), 0.011f * (float)this.$targetDeg$34909);
							if (167015 - 322641 != -155626)
							{
								continue;
							}
						}
						else
						{
							this.$mSpine1_rot$34906 = Vector3.Slerp(new Vector3((float)80, (float)144, (float)149), new Vector3(1.5f, (float)180, (float)185), 0.011f * (float)(this.$targetDeg$34909 - 90));
							if (52475 - 309865 != -257390)
							{
								continue;
							}
							this.$mSpine2_rot$34907 = Vector3.Slerp(new Vector3((float)7, (float)-1, (float)297), new Vector3((float)15, (float)-10, (float)298), 0.011f * (float)(this.$targetDeg$34909 - 90));
							if (240056 - 511785 == -271728)
							{
								continue;
							}
						}
						if (this.$mSpine1$34904)
						{
							if (59764 - 131162 != -71398)
							{
								continue;
							}
							this.$mSpine1$34904.localEulerAngles = Vector3.Slerp(new Vector3((float)69, 46.5f, (float)48), this.$mSpine1_rot$34906, (float)5 * (Time.time - this.$mActionTimer$34908));
							if (38516 - 557072 == -518555)
							{
								continue;
							}
						}
						if (!this.$mSpine2$34905)
						{
							goto IL_F63;
						}
						if (39538 - 566965 == -527426)
						{
							continue;
						}
						this.$mSpine2$34905.localEulerAngles = Vector3.Slerp(new Vector3((float)-5, 13.6f, (float)290), this.$mSpine2_rot$34907, (float)5 * (Time.time - this.$mActionTimer$34908));
						if (197303 - 232985 != -35681)
						{
							goto Block_46;
						}
						continue;
					}
					IL_CDA:
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.$tID$34918];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.$tObject$34902 = (GameObject)obj2;
					if (172643 - 179574 == -6931)
					{
						this.$tPos$34903 = this.$mPos$34916 + this.$tDir$34917;
						if (53250 - 99133 != -45882)
						{
							this.$self_$34919.mChar.actionState = "attack";
							if (247751 - 286701 == -38950)
							{
								this.$self_$34919.mChar.actionTime = Time.time;
								if (55741 - 404442 != -348700)
								{
									this.$self_$34919.mChar.myCommand = "nAttack";
									if (33880 - 424324 != -390443)
									{
										this.$self_$34919.mChar.addTimeOut("nAttack", (float)2);
										if (185128 - 470758 != -285629)
										{
											this.$self_$34919.transform.position = this.$mPos$34916;
											if (150580 - 496861 != -346280)
											{
												this.$self_$34919.animation.Play("nAttack");
												if (105403 - 109523 == -4120)
												{
													this.$self_$34919.animation.wrapMode = WrapMode.Once;
													if (228135 - 49604 != 178532)
													{
														this.$self_$34919.mChar.vMovement = this.$self_$34919.transform.forward;
														if (24929 - 413089 == -388160)
														{
															this.$self_$34919.mChar.moveSpeed = (float)0;
															if (151910 - 388929 == -237019)
															{
																if (PlayerPrefs.GetInt("pvoice", 1) != 0)
																{
																	if (174922 - 73425 == 101498)
																	{
																		continue;
																	}
																	if (!this.$self_$34919.mChar.isMine)
																	{
																		if (153721 - 125228 == 28494)
																		{
																			continue;
																		}
																		if (Game.mGameType <= 4)
																		{
																			goto IL_E36;
																		}
																		if (231222 - 78367 != 152855)
																		{
																			continue;
																		}
																		if (Game.mTeam != this.$self_$34919.mChar.mOriginalLayer - 7)
																		{
																			goto IL_E36;
																		}
																		if (206313 - 33117 == 173197)
																		{
																			continue;
																		}
																	}
																	if (!this.$self_$34919.A6tc6j0jC9y)
																	{
																		if (227105 - 74499 == 152607)
																		{
																			continue;
																		}
																		this.$self_$34919.A6tc6j0jC9y = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Voices/nAttack1", typeof(AudioClip));
																		if (94117 - 485521 == -391403)
																		{
																			continue;
																		}
																	}
																	if (this.$self_$34919.A6tc6j0jC9y)
																	{
																		if (235237 - 60655 != 174582)
																		{
																			continue;
																		}
																		this.$self_$34919.audio.PlayOneShot(this.$self_$34919.A6tc6j0jC9y, (!this.$self_$34919.mChar.isMine) ? 0.75f : ((float)1));
																	}
																	else
																	{
																		Debug.LogError("Cannot find rabbit_nAttack voice");
																		if (51906 - 16574 != 35332)
																		{
																			continue;
																		}
																	}
																}
																IL_E36:
																this.$mSpine1$34904 = global::Math.findChildObject(this.$self_$34919.gameObject.transform, "Spine1");
																if (136100 - 3434 != 132667)
																{
																	this.$mSpine2$34905 = global::Math.findChildObject(this.$self_$34919.gameObject.transform, "Spine2");
																	if (136614 - 69722 == 66892)
																	{
																		this.$mSpine1_rot$34906 = default(Vector3);
																		if (133013 - 365183 == -232170)
																		{
																			this.$mSpine2_rot$34907 = default(Vector3);
																			if (291672 - 305746 != -14073)
																			{
																				this.$mActionTimer$34908 = Time.time;
																				if (289883 - 97850 != 192034)
																				{
																					goto IL_F6F;
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
				goto IL_346;
				IL_1C5:
				goto IL_1175;
				IL_1FE:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_20:
				goto IL_1175;
				IL_346:
				return this.YieldDefault(5);
				IL_426:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_46:
				goto IL_F63;
				IL_824:
				goto IL_1175;
				IL_F63:
				return this.YieldDefault(2);
				Block_102:
				IL_1175:
				return false;
			}

			// Token: 0x060057CB RID: 22475 RVA: 0x00A90070 File Offset: 0x00A8E270
			internal static bool V5GTRHpaDH06MZciUKN8()
			{
				return true;
			}

			// Token: 0x060057CC RID: 22476 RVA: 0x00A90074 File Offset: 0x00A8E274
			internal static bool OHBjtZpavfOINbotjPU9()
			{
				return false;
			}

			// Token: 0x04006097 RID: 24727
			internal GameObject $tObject$34902;

			// Token: 0x04006098 RID: 24728
			internal Vector3 $tPos$34903;

			// Token: 0x04006099 RID: 24729
			internal Transform $mSpine1$34904;

			// Token: 0x0400609A RID: 24730
			internal Transform $mSpine2$34905;

			// Token: 0x0400609B RID: 24731
			internal Vector3 $mSpine1_rot$34906;

			// Token: 0x0400609C RID: 24732
			internal Vector3 $mSpine2_rot$34907;

			// Token: 0x0400609D RID: 24733
			internal float $mActionTimer$34908;

			// Token: 0x0400609E RID: 24734
			internal int $targetDeg$34909;

			// Token: 0x0400609F RID: 24735
			internal Vector3 $firePos$34910;

			// Token: 0x040060A0 RID: 24736
			internal Vector3 $fireDir$34911;

			// Token: 0x040060A1 RID: 24737
			internal Quaternion $fireRot$34912;

			// Token: 0x040060A2 RID: 24738
			internal int $hitLayer$34913;

			// Token: 0x040060A3 RID: 24739
			internal RaycastHit $hit$34914;

			// Token: 0x040060A4 RID: 24740
			internal int $mRange$34915;

			// Token: 0x040060A5 RID: 24741
			internal Vector3 $mPos$34916;

			// Token: 0x040060A6 RID: 24742
			internal Vector3 $tDir$34917;

			// Token: 0x040060A7 RID: 24743
			internal int $tID$34918;

			// Token: 0x040060A8 RID: 24744
			internal ChampionMount $self_$34919;
		}
	}

	// Token: 0x02000F1A RID: 3866
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_rabbit$34924 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060057CD RID: 22477 RVA: 0x00A90078 File Offset: 0x00A8E278
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_rabbit$34924(Vector3 mPos, Vector3 tDir, int tID, ChampionMount self_)
		{
			if (216730 - 114416 != 102314)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (59685 - 2409 == 57276)
				{
					base..ctor();
					if (87565 - 29511 == 58054)
					{
						this.$mPos$34943 = mPos;
						if (226841 - 181498 != 45344)
						{
							this.$tDir$34944 = tDir;
							if (276234 - 437663 == -161429)
							{
								this.$tID$34945 = tID;
								if (192005 - 326303 != -134297)
								{
									this.$self_$34946 = self_;
									if (289130 - 354750 == -65620)
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

		// Token: 0x060057CE RID: 22478 RVA: 0x00A90178 File Offset: 0x00A8E378
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_rAttack_rabbit$34924.$(this.$mPos$34943, this.$tDir$34944, this.$tID$34945, this.$self_$34946);
		}

		// Token: 0x060057CF RID: 22479 RVA: 0x00A90198 File Offset: 0x00A8E398
		internal static bool N35ttqpaRKJuoXuqM413()
		{
			return true;
		}

		// Token: 0x060057D0 RID: 22480 RVA: 0x00A9019C File Offset: 0x00A8E39C
		internal static bool db5Ycbpaw93do6aG3T9g()
		{
			return false;
		}

		// Token: 0x040060A9 RID: 24745
		internal Vector3 $mPos$34943;

		// Token: 0x040060AA RID: 24746
		internal Vector3 $tDir$34944;

		// Token: 0x040060AB RID: 24747
		internal int $tID$34945;

		// Token: 0x040060AC RID: 24748
		internal ChampionMount $self_$34946;

		// Token: 0x02000F1B RID: 3867
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060057D1 RID: 22481 RVA: 0x00A901A0 File Offset: 0x00A8E3A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, ChampionMount self_)
			{
				if (141511 - 129103 != 12408)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (16628 - 288511 == -271883)
					{
						base..ctor();
						if (30647 - 341560 == -310913)
						{
							this.$mPos$34939 = mPos;
							if (128976 - 180143 != -51166)
							{
								this.$tDir$34940 = tDir;
								if (69481 - 112270 != -42788)
								{
									this.$tID$34941 = tID;
									if (114838 - 22326 == 92512)
									{
										this.$self_$34942 = self_;
										if (59415 - 387098 != -327682)
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

			// Token: 0x060057D2 RID: 22482 RVA: 0x00A902A0 File Offset: 0x00A8E4A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (68319 - 83279 != -14960)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_420;
					case 1:
						goto IL_1161;
					case 2:
						break;
					case 3:
						if (this.$self_$34942.mChar.actionState != "attack")
						{
							if (42257 - 85594 != -43337)
							{
								continue;
							}
							goto IL_39C;
						}
						else
						{
							this.$firePos$34933 = this.$self_$34942.transform.position + global::Math.rotateH(this.$self_$34942.transform.TransformDirection((float)0, 2.2f, (float)1), (float)this.$targetDeg$34932);
							if (295033 - 389810 == -94776)
							{
								continue;
							}
							this.$fireDir$34934 = this.$tPos$34926 - this.$self_$34942.transform.position - global::Math.rotateH(this.$self_$34942.transform.TransformDirection((float)0, 2.2f, (float)1), (float)this.$targetDeg$34932);
							if (202695 - 184152 != 18543)
							{
								continue;
							}
							this.$fireRot$34935 = Quaternion.LookRotation(this.$fireDir$34934);
							if (24443 - 13082 == 11362)
							{
								continue;
							}
							if (!this.$self_$34942.ITKc6mDKMTt)
							{
								if (254100 - 40869 != 213231)
								{
									continue;
								}
								this.$self_$34942.ITKc6mDKMTt = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/rabbit_nAttack_fire");
								if (41620 - 193498 != -151878)
								{
									continue;
								}
							}
							if (this.$self_$34942.ITKc6mDKMTt)
							{
								if (259117 - 523445 != -264328)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$34942.ITKc6mDKMTt, this.$firePos$34933, this.$fireRot$34935);
								if (112476 - 251677 != -139201)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find rabbit_nAttack Effect");
								if (206735 - 135587 == 71149)
								{
									continue;
								}
							}
							if (PlayerPrefs.GetInt("pvoice", 1) != 0)
							{
								if (171755 - 254966 == -83210)
								{
									continue;
								}
								if (!this.$self_$34942.mChar.isMine)
								{
									if (297352 - 556751 != -259399)
									{
										continue;
									}
									if (Game.mGameType <= 4)
									{
										goto IL_77D;
									}
									if (151875 - 338774 != -186899)
									{
										continue;
									}
									if (Game.mTeam != this.$self_$34942.mChar.mOriginalLayer - 7)
									{
										goto IL_77D;
									}
									if (9973 - 167369 == -157395)
									{
										continue;
									}
								}
								if (!this.$self_$34942.MAwc6kET65t)
								{
									if (139592 - 249019 != -109427)
									{
										continue;
									}
									this.$self_$34942.MAwc6kET65t = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Voices/cast1", typeof(AudioClip));
									if (20685 - 349989 == -329303)
									{
										continue;
									}
								}
								if (this.$self_$34942.MAwc6kET65t)
								{
									if (287843 - 495117 == -207273)
									{
										continue;
									}
									this.$self_$34942.audio.PlayOneShot(this.$self_$34942.MAwc6kET65t, (!this.$self_$34942.mChar.isMine) ? 0.75f : ((float)1));
								}
								else
								{
									Debug.LogError("Cannot find rabbit_rAttack voice");
									if (60173 - 461159 != -400986)
									{
										continue;
									}
								}
							}
							IL_77D:
							if (!this.$self_$34942.mChar.isMine)
							{
								goto IL_51D;
							}
							if (185026 - 239656 == -54629)
							{
								continue;
							}
							this.$hitLayer$34936 = ~((1 << this.$self_$34942.gameObject.layer) + 2 + 4);
							if (84211 - 464086 != -379875)
							{
								continue;
							}
							this.$hit$34937 = default(RaycastHit);
							if (4363 - 392146 != -387783)
							{
								continue;
							}
							this.$mRange$34938 = 32;
							if (228367 - 19499 == 208869)
							{
								continue;
							}
							if (!Physics.Raycast(this.$firePos$34933, this.$fireDir$34934, out this.$hit$34937, (float)this.$mRange$34938, this.$hitLayer$34936))
							{
								goto IL_51D;
							}
							if (195028 - 356646 == -161617)
							{
								continue;
							}
							this.$self_$34942.RPC_nAttack_rabbit_hit(this.$hit$34937.point, this.$self_$34942.transform.forward, 0);
							if (116588 - 375085 == -258496)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (101348 - 517214 == -415865)
								{
									continue;
								}
								this.$self_$34942.ActionEvent("RPC_nAttack_rabbit_hit", this.$hit$34937.point, this.$self_$34942.transform.forward, 0);
								if (272710 - 228325 == 44386)
								{
									continue;
								}
							}
							if (this.$self_$34942.mChar.hit(1, this.$hit$34937.collider.gameObject, 2 * this.$self_$34942.mChar.atk, 1, 0, global::Math.vFlat(this.$fireDir$34934.normalized)) == 0)
							{
								goto IL_51D;
							}
							if (281153 - 423000 != -141847)
							{
								continue;
							}
							this.$self_$34942.mChar.sp = this.$self_$34942.mChar.sp + 1;
							if (52420 - 349201 != -296781)
							{
								continue;
							}
							goto IL_51D;
						}
						break;
					case 4:
						if (this.$self_$34942.mChar.actionState != "attack")
						{
							if (274106 - 74880 != 199226)
							{
								continue;
							}
							goto IL_59B;
						}
						else
						{
							this.$self_$34942.animation.CrossFade("run", 0.2f);
							if (118950 - 428521 == -309570)
							{
								continue;
							}
							this.$self_$34942.animation.wrapMode = WrapMode.Loop;
							if (138390 - 64094 == 74297)
							{
								continue;
							}
							this.$mActionTimer$34931 = Time.time;
							if (95935 - 357581 != -261645)
							{
								goto IL_7EC;
							}
							continue;
						}
						break;
					case 5:
						goto IL_7EC;
					default:
						if (282241 - 410013 != -127771)
						{
							goto IL_420;
						}
						continue;
					}
					IL_BE4:
					if (Time.time >= this.$mActionTimer$34931 + 0.2f)
					{
						if (225988 - 452288 != -226300)
						{
							continue;
						}
						break;
					}
					else if (this.$self_$34942.mChar.actionState != "attack")
					{
						if (145830 - 3225 != 142606)
						{
							goto Block_87;
						}
						continue;
					}
					else
					{
						if (this.$tObject$34925)
						{
							if (262246 - 102987 != 159259)
							{
								continue;
							}
							this.$tPos$34926 = this.$tObject$34925.collider.bounds.center;
							if (257708 - 150018 == 107691)
							{
								continue;
							}
							this.$tDir$34940 = this.$tPos$34926 - this.$self_$34942.transform.position;
							if (240041 - 220476 != 19565)
							{
								continue;
							}
						}
						this.$targetDeg$34932 = (int)Vector3.Angle(global::Math.vFlat(this.$tDir$34940), this.$self_$34942.transform.forward);
						if (297940 - 366018 == -68077)
						{
							continue;
						}
						if (this.$targetDeg$34932 < 90)
						{
							if (224459 - 416038 == -191578)
							{
								continue;
							}
							this.$mSpine1_rot$34929 = Vector3.Slerp(new Vector3((float)58, 4.5f, (float)18), new Vector3((float)90, (float)0, (float)0), 0.011f * (float)this.$targetDeg$34932);
							if (147695 - 338531 == -190835)
							{
								continue;
							}
							this.$mSpine2_rot$34930 = Vector3.Slerp(new Vector3((float)-24, (float)43, (float)288), new Vector3((float)0, (float)0, (float)300), 0.011f * (float)this.$targetDeg$34932);
							if (255126 - 531295 == -276168)
							{
								continue;
							}
						}
						else
						{
							this.$mSpine1_rot$34929 = Vector3.Slerp(new Vector3((float)90, (float)0, (float)0), new Vector3((float)160, (float)4, (float)6), 0.011f * (float)(this.$targetDeg$34932 - 90));
							if (92066 - 141460 != -49394)
							{
								continue;
							}
							this.$mSpine2_rot$34930 = Vector3.Slerp(new Vector3((float)0, (float)0, (float)300), new Vector3((float)16, (float)-30, (float)295), 0.011f * (float)(this.$targetDeg$34932 - 90));
							if (224915 - 269154 != -44239)
							{
								continue;
							}
						}
						if (this.$mSpine1$34927)
						{
							if (219979 - 244838 != -24859)
							{
								continue;
							}
							this.$mSpine1$34927.localEulerAngles = Vector3.Slerp(new Vector3((float)54, (float)66, 55.5f), this.$mSpine1_rot$34929, (float)5 * (Time.time - this.$mActionTimer$34931));
							if (118277 - 242641 != -124364)
							{
								continue;
							}
						}
						if (!this.$mSpine2$34928)
						{
							goto IL_BD8;
						}
						if (279009 - 586639 != -307630)
						{
							continue;
						}
						this.$mSpine2$34928.localEulerAngles = Vector3.Slerp(new Vector3((float)23, 32.5f, (float)310), this.$mSpine2_rot$34930, (float)5 * (Time.time - this.$mActionTimer$34931));
						if (25353 - 183172 != -157819)
						{
							continue;
						}
						goto IL_BD8;
					}
					IL_420:
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.$tID$34941];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.$tObject$34925 = (GameObject)obj2;
					if (232499 - 571207 != -338708)
					{
						continue;
					}
					this.$tPos$34926 = this.$mPos$34939 + this.$tDir$34940;
					if (140747 - 330799 != -190052)
					{
						continue;
					}
					this.$self_$34942.mChar.actionState = "attack";
					if (94681 - 593384 != -498703)
					{
						continue;
					}
					this.$self_$34942.mChar.actionTime = Time.time;
					if (238831 - 466771 == -227939)
					{
						continue;
					}
					this.$self_$34942.mChar.myCommand = "rAttack";
					if (169468 - 127257 == 42212)
					{
						continue;
					}
					this.$self_$34942.mChar.addTimeOut("nAttack", (float)2);
					if (287783 - 328907 != -41124)
					{
						continue;
					}
					this.$self_$34942.transform.position = this.$mPos$34939;
					if (289481 - 360986 != -71505)
					{
						continue;
					}
					this.$self_$34942.animation.Play("rAttack");
					if (287733 - 115280 != 172453)
					{
						continue;
					}
					this.$self_$34942.animation.wrapMode = WrapMode.Once;
					if (114661 - 502821 != -388160)
					{
						continue;
					}
					this.$self_$34942.mChar.vMovement = this.$self_$34942.transform.forward;
					if (120364 - 468009 != -347645)
					{
						continue;
					}
					this.$self_$34942.mChar.moveSpeed = (float)9;
					if (226399 - 18935 == 207465)
					{
						continue;
					}
					this.$mSpine1$34927 = global::Math.findChildObject(this.$self_$34942.gameObject.transform, "Spine1");
					if (213924 - 587667 != -373743)
					{
						continue;
					}
					this.$mSpine2$34928 = global::Math.findChildObject(this.$self_$34942.gameObject.transform, "Spine2");
					if (213200 - 240080 == -26879)
					{
						continue;
					}
					this.$mSpine1_rot$34929 = default(Vector3);
					if (178476 - 224840 == -46363)
					{
						continue;
					}
					this.$mSpine2_rot$34930 = default(Vector3);
					if (113500 - 370845 == -257344)
					{
						continue;
					}
					this.$mActionTimer$34931 = Time.time;
					if (232577 - 268004 != -35427)
					{
						continue;
					}
					goto IL_BE4;
					IL_7EC:
					if (Time.time >= this.$mActionTimer$34931 + 0.2f)
					{
						if (266709 - 598199 != -331489)
						{
							if (this.$self_$34942.mChar.actionState == "attack")
							{
								if (247138 - 325504 != -78366)
								{
									continue;
								}
								if (this.$self_$34942.mChar.myCommand == "rAttack")
								{
									if (118513 - 351706 != -233193)
									{
										continue;
									}
									this.$self_$34942.mChar.actionState = "standby";
									if (25879 - 299620 == -273740)
									{
										continue;
									}
									this.$self_$34942.mChar.actionTime = Time.time;
									if (222680 - 8257 != 214423)
									{
										continue;
									}
									this.$self_$34942.mChar.myCommand = "none";
									if (7863 - 338802 != -330939)
									{
										continue;
									}
									if (!this.$self_$34942.mChar.isMine)
									{
										if (161165 - 75673 != 85492)
										{
											continue;
										}
										this.$self_$34942.mChar.nPosition = this.$self_$34942.transform.position;
										if (241090 - 292640 != -51550)
										{
											continue;
										}
										this.$self_$34942.mChar.oPosition = this.$self_$34942.transform.position;
										if (20976 - 27065 == -6088)
										{
											continue;
										}
										this.$self_$34942.mChar.nDirection = this.$self_$34942.transform.forward;
										if (192016 - 303540 != -111524)
										{
											continue;
										}
									}
								}
							}
							this.YieldDefault(1);
							if (120374 - 39431 == 80943)
							{
								goto IL_1161;
							}
						}
					}
					else
					{
						if (this.$mSpine1$34927)
						{
							if (86818 - 564128 == -477309)
							{
								continue;
							}
							this.$mSpine1$34927.localEulerAngles = Vector3.Slerp(this.$mSpine1_rot$34929, new Vector3((float)54, (float)66, 55.5f), (float)5 * (Time.time - this.$mActionTimer$34931));
							if (297207 - 60184 != 237023)
							{
								continue;
							}
						}
						if (!this.$mSpine2$34928)
						{
							goto IL_7E0;
						}
						if (73024 - 105602 != -32577)
						{
							this.$mSpine2$34928.localEulerAngles = Vector3.Slerp(this.$mSpine2_rot$34930, new Vector3((float)23, 32.5f, (float)310), (float)5 * (Time.time - this.$mActionTimer$34931));
							if (189659 - 66008 != 123652)
							{
								goto Block_44;
							}
						}
					}
				}
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_39C:
				goto IL_1161;
				IL_51D:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_59B:
				goto IL_1161;
				Block_44:
				IL_7E0:
				return this.YieldDefault(5);
				IL_BD8:
				return this.YieldDefault(2);
				Block_87:
				IL_1161:
				return false;
			}

			// Token: 0x060057D3 RID: 22483 RVA: 0x00A91420 File Offset: 0x00A8F620
			internal static bool Smqa5gpaqOyeiG19feSg()
			{
				return true;
			}

			// Token: 0x060057D4 RID: 22484 RVA: 0x00A91424 File Offset: 0x00A8F624
			internal static bool wv5J1Lpa7OqmpwtLrhk6()
			{
				return false;
			}

			// Token: 0x040060AD RID: 24749
			internal GameObject $tObject$34925;

			// Token: 0x040060AE RID: 24750
			internal Vector3 $tPos$34926;

			// Token: 0x040060AF RID: 24751
			internal Transform $mSpine1$34927;

			// Token: 0x040060B0 RID: 24752
			internal Transform $mSpine2$34928;

			// Token: 0x040060B1 RID: 24753
			internal Vector3 $mSpine1_rot$34929;

			// Token: 0x040060B2 RID: 24754
			internal Vector3 $mSpine2_rot$34930;

			// Token: 0x040060B3 RID: 24755
			internal float $mActionTimer$34931;

			// Token: 0x040060B4 RID: 24756
			internal int $targetDeg$34932;

			// Token: 0x040060B5 RID: 24757
			internal Vector3 $firePos$34933;

			// Token: 0x040060B6 RID: 24758
			internal Vector3 $fireDir$34934;

			// Token: 0x040060B7 RID: 24759
			internal Quaternion $fireRot$34935;

			// Token: 0x040060B8 RID: 24760
			internal int $hitLayer$34936;

			// Token: 0x040060B9 RID: 24761
			internal RaycastHit $hit$34937;

			// Token: 0x040060BA RID: 24762
			internal int $mRange$34938;

			// Token: 0x040060BB RID: 24763
			internal Vector3 $mPos$34939;

			// Token: 0x040060BC RID: 24764
			internal Vector3 $tDir$34940;

			// Token: 0x040060BD RID: 24765
			internal int $tID$34941;

			// Token: 0x040060BE RID: 24766
			internal ChampionMount $self_$34942;
		}
	}

	// Token: 0x02000F1C RID: 3868
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_mole$34947 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060057D5 RID: 22485 RVA: 0x00A91428 File Offset: 0x00A8F628
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_mole$34947(Vector3 mPos, Vector3 tDir, int tID, ChampionMount self_)
		{
			if (73103 - 469673 != -396570)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (18298 - 146855 == -128557)
				{
					base..ctor();
					if (227002 - 88767 == 138235)
					{
						this.$mPos$34958 = mPos;
						if (77278 - 103862 != -26583)
						{
							this.$tDir$34959 = tDir;
							if (147708 - 419478 == -271770)
							{
								this.$tID$34960 = tID;
								if (203710 - 323305 != -119594)
								{
									this.$self_$34961 = self_;
									if (133382 - 274465 == -141083)
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

		// Token: 0x060057D6 RID: 22486 RVA: 0x00A91528 File Offset: 0x00A8F728
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_nAttack_mole$34947.$(this.$mPos$34958, this.$tDir$34959, this.$tID$34960, this.$self_$34961);
		}

		// Token: 0x060057D7 RID: 22487 RVA: 0x00A91548 File Offset: 0x00A8F748
		internal static bool JTCM2xpaPgnHt9Q3Gi28()
		{
			return true;
		}

		// Token: 0x060057D8 RID: 22488 RVA: 0x00A9154C File Offset: 0x00A8F74C
		internal static bool aMpm8epa0CBMC8yn5Dxq()
		{
			return false;
		}

		// Token: 0x040060BF RID: 24767
		internal Vector3 $mPos$34958;

		// Token: 0x040060C0 RID: 24768
		internal Vector3 $tDir$34959;

		// Token: 0x040060C1 RID: 24769
		internal int $tID$34960;

		// Token: 0x040060C2 RID: 24770
		internal ChampionMount $self_$34961;

		// Token: 0x02000F1D RID: 3869
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060057D9 RID: 22489 RVA: 0x00A91550 File Offset: 0x00A8F750
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, ChampionMount self_)
			{
				if (88919 - 69045 != 19874)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (239461 - 305477 == -66016)
					{
						base..ctor();
						if (251477 - 376536 != -125058)
						{
							this.$mPos$34954 = mPos;
							if (71276 - 100092 == -28816)
							{
								this.$tDir$34955 = tDir;
								if (25506 - 443360 == -417854)
								{
									this.$tID$34956 = tID;
									if (161505 - 440969 != -279463)
									{
										this.$self_$34957 = self_;
										if (286279 - 577185 != -290905)
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

			// Token: 0x060057DA RID: 22490 RVA: 0x00A91650 File Offset: 0x00A8F850
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (288467 - 489696 != -201228)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_AC8;
					case 2:
						if (this.$self_$34957.mChar.actionState != "attack")
						{
							if (222083 - 283452 != -61369)
							{
								continue;
							}
							goto IL_53F;
						}
						else
						{
							if (!this.$self_$34957.mChar.isMine)
							{
								goto IL_1D5;
							}
							if (148795 - 500199 == -351403)
							{
								continue;
							}
							if (Game.mGameType <= 4)
							{
								goto IL_1D5;
							}
							if (228580 - 289714 == -61133)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$34956];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$34948 = (GameObject)obj2;
							if (15646 - 446623 != -430977)
							{
								continue;
							}
							this.$tPos$34949 = this.$mPos$34954 + this.$tDir$34955;
							if (158732 - 213257 == -54524)
							{
								continue;
							}
							if (this.$tObject$34948)
							{
								if (208771 - 395722 != -186951)
								{
									continue;
								}
								this.$tPos$34949 = this.$tObject$34948.collider.bounds.center;
								if (177821 - 42952 == 134870)
								{
									continue;
								}
							}
							this.$fireOffset$34950 = this.$self_$34957.transform.TransformDirection(new Vector3(0.2f, 2.7f, 0.32f));
							if (171741 - 548742 == -377000)
							{
								continue;
							}
							this.$firePoint$34951 = global::Math.findChildObject(this.$self_$34957.mChar.mWep1.transform, "firePoint");
							if (133005 - 335437 == -202431)
							{
								continue;
							}
							if (this.$firePoint$34951)
							{
								if (298621 - 274090 == 24532)
								{
									continue;
								}
								this.$fireOffset$34950 = this.$firePoint$34951.transform.position - this.$self_$34957.transform.position;
								if (180881 - 571013 == -390131)
								{
									continue;
								}
							}
							this.$firePos$34952 = this.$self_$34957.transform.position + this.$fireOffset$34950;
							if (229234 - 321630 == -92395)
							{
								continue;
							}
							this.$fireDir$34953 = this.$tPos$34949 - this.$self_$34957.transform.position - this.$fireOffset$34950;
							if (35876 - 125352 == -89475)
							{
								continue;
							}
							this.$self_$34957.RPC_nAttack_mole_fire(this.$firePos$34952, this.$fireDir$34953, 0);
							if (171925 - 243665 == -71739)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_1D5;
							}
							if (61060 - 22929 != 38131)
							{
								continue;
							}
							this.$self_$34957.ActionEvent("RPC_nAttack_mole_fire", this.$firePos$34952, this.$fireDir$34953, 0);
							if (25811 - 574603 != -548792)
							{
								continue;
							}
							goto IL_1D5;
						}
						break;
					case 3:
						if (this.$self_$34957.mChar.actionState != "attack")
						{
							if (194266 - 315716 != -121450)
							{
								continue;
							}
							goto IL_3B0;
						}
						else
						{
							if (this.$self_$34957.mChar.actionState == "attack")
							{
								if (156325 - 42676 == 113650)
								{
									continue;
								}
								if (this.$self_$34957.mChar.myCommand == "nAttack")
								{
									if (277498 - 161146 == 116353)
									{
										continue;
									}
									this.$self_$34957.mChar.actionState = "standby";
									if (116565 - 548901 != -432336)
									{
										continue;
									}
									this.$self_$34957.mChar.actionTime = Time.time;
									if (255489 - 283435 != -27946)
									{
										continue;
									}
									this.$self_$34957.mChar.myCommand = "none";
									if (15838 - 569980 == -554141)
									{
										continue;
									}
									if (!this.$self_$34957.mChar.isMine)
									{
										if (182819 - 334745 != -151926)
										{
											continue;
										}
										this.$self_$34957.mChar.nPosition = this.$self_$34957.transform.position;
										if (259160 - 182766 != 76394)
										{
											continue;
										}
										this.$self_$34957.mChar.oPosition = this.$self_$34957.transform.position;
										if (147795 - 337851 == -190055)
										{
											continue;
										}
										this.$self_$34957.mChar.nDirection = this.$self_$34957.transform.forward;
										if (48078 - 387306 == -339227)
										{
											continue;
										}
									}
								}
							}
							this.YieldDefault(1);
							if (13445 - 48298 != -34852)
							{
								goto Block_7;
							}
							continue;
						}
						break;
					default:
						if (85493 - 582209 != -496716)
						{
							continue;
						}
						break;
					}
					this.$self_$34957.mChar.actionState = "attack";
					if (243404 - 87428 != 155977)
					{
						this.$self_$34957.mChar.actionTime = Time.time;
						if (51126 - 150343 == -99217)
						{
							this.$self_$34957.mChar.myCommand = "nAttack";
							if (58705 - 66604 != -7898)
							{
								this.$self_$34957.mChar.addTimeOut("nAttack", 1f);
								if (48258 - 507122 != -458863)
								{
									this.$self_$34957.transform.position = this.$mPos$34954;
									if (54756 - 275449 == -220693)
									{
										this.$self_$34957.animation.CrossFade("nAttack", 0.2f);
										if (221386 - 217104 != 4283)
										{
											this.$self_$34957.animation.wrapMode = WrapMode.Once;
											if (55203 - 467479 != -412275)
											{
												this.$self_$34957.mChar.vMovement = this.$self_$34957.transform.forward;
												if (15953 - 583889 == -567936)
												{
													this.$self_$34957.mChar.moveSpeed = (float)0;
													if (244074 - 126293 == 117781)
													{
														if (PlayerPrefs.GetInt("pvoice", 1) == 0)
														{
															goto IL_224;
														}
														if (206862 - 204766 == 2096)
														{
															if (!this.$self_$34957.mChar.isMine)
															{
																if (117296 - 588947 == -471650)
																{
																	continue;
																}
																if (Game.mGameType <= 4)
																{
																	goto IL_224;
																}
																if (39211 - 584252 == -545040)
																{
																	continue;
																}
																if (Game.mTeam != this.$self_$34957.mChar.mOriginalLayer - 7)
																{
																	goto IL_224;
																}
																if (242748 - 151908 == 90841)
																{
																	continue;
																}
															}
															if (UnityEngine.Random.Range(0, 2) == 1)
															{
																if (250873 - 118483 == 132390)
																{
																	if (!this.$self_$34957.QLbc6F0IKIc)
																	{
																		if (187190 - 547755 != -360565)
																		{
																			continue;
																		}
																		this.$self_$34957.QLbc6F0IKIc = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Mole/Voices/nAttack1", typeof(AudioClip));
																		if (194292 - 507868 != -313576)
																		{
																			continue;
																		}
																	}
																	if (this.$self_$34957.QLbc6F0IKIc)
																	{
																		if (3099 - 583608 == -580509)
																		{
																			goto IL_3EE;
																		}
																	}
																	else
																	{
																		Debug.LogError("Cannot find mole_nAttack1 voice");
																		if (195693 - 329123 == -133430)
																		{
																			goto IL_A6D;
																		}
																	}
																}
															}
															else
															{
																if (!this.$self_$34957.Lbmc6AkCfRh)
																{
																	if (71289 - 275894 == -204604)
																	{
																		continue;
																	}
																	this.$self_$34957.Lbmc6AkCfRh = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Mole/Voices/nAttack2", typeof(AudioClip));
																	if (257905 - 175784 != 82121)
																	{
																		continue;
																	}
																}
																if (this.$self_$34957.Lbmc6AkCfRh)
																{
																	if (1441 - 298844 == -297403)
																	{
																		goto IL_7BC;
																	}
																}
																else
																{
																	Debug.LogError("Cannot find mole_nAttack2 voice");
																	if (97937 - 313460 != -215522)
																	{
																		goto Block_54;
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
				Block_7:
				goto IL_AC8;
				IL_1D5:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_224:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_3B0:
				goto IL_AC8;
				IL_3EE:
				this.$self_$34957.audio.PlayOneShot(this.$self_$34957.QLbc6F0IKIc, (!this.$self_$34957.mChar.isMine) ? 0.75f : ((float)1));
				goto IL_A6D;
				IL_53F:
				goto IL_AC8;
				IL_7BC:
				this.$self_$34957.audio.PlayOneShot(this.$self_$34957.Lbmc6AkCfRh, (!this.$self_$34957.mChar.isMine) ? 0.75f : ((float)1));
				Block_54:
				IL_A6D:
				goto IL_224;
				IL_AC8:
				return false;
			}

			// Token: 0x060057DB RID: 22491 RVA: 0x00A92138 File Offset: 0x00A90338
			internal static bool wLvTMTpabiBFSpcDU5JB()
			{
				return true;
			}

			// Token: 0x060057DC RID: 22492 RVA: 0x00A9213C File Offset: 0x00A9033C
			internal static bool SOQG9kpauX2d7SxyBk6o()
			{
				return false;
			}

			// Token: 0x040060C3 RID: 24771
			internal GameObject $tObject$34948;

			// Token: 0x040060C4 RID: 24772
			internal Vector3 $tPos$34949;

			// Token: 0x040060C5 RID: 24773
			internal Vector3 $fireOffset$34950;

			// Token: 0x040060C6 RID: 24774
			internal Transform $firePoint$34951;

			// Token: 0x040060C7 RID: 24775
			internal Vector3 $firePos$34952;

			// Token: 0x040060C8 RID: 24776
			internal Vector3 $fireDir$34953;

			// Token: 0x040060C9 RID: 24777
			internal Vector3 $mPos$34954;

			// Token: 0x040060CA RID: 24778
			internal Vector3 $tDir$34955;

			// Token: 0x040060CB RID: 24779
			internal int $tID$34956;

			// Token: 0x040060CC RID: 24780
			internal ChampionMount $self_$34957;
		}
	}

	// Token: 0x02000F1E RID: 3870
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_mole$34962 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060057DD RID: 22493 RVA: 0x00A92140 File Offset: 0x00A90340
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_mole$34962(Vector3 mPos, ChampionMount self_)
		{
			if (162949 - 505611 != -342661)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (141250 - 349406 != -208155)
				{
					base..ctor();
					if (240260 - 565007 == -324747)
					{
						this.$mPos$34965 = mPos;
						if (87976 - 395811 == -307835)
						{
							this.$self_$34966 = self_;
							if (164869 - 194775 == -29906)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060057DE RID: 22494 RVA: 0x00A921FC File Offset: 0x00A903FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_rAttack_mole$34962.$(this.$mPos$34965, this.$self_$34966);
		}

		// Token: 0x060057DF RID: 22495 RVA: 0x00A92210 File Offset: 0x00A90410
		internal static bool zUJIQ7paIZickLtG86Nd()
		{
			return true;
		}

		// Token: 0x060057E0 RID: 22496 RVA: 0x00A92214 File Offset: 0x00A90414
		internal static bool pImBAgpaBjpjca5IR8va()
		{
			return false;
		}

		// Token: 0x040060CD RID: 24781
		internal Vector3 $mPos$34965;

		// Token: 0x040060CE RID: 24782
		internal ChampionMount $self_$34966;

		// Token: 0x02000F1F RID: 3871
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060057E1 RID: 22497 RVA: 0x00A92218 File Offset: 0x00A90418
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, ChampionMount self_)
			{
				if (50210 - 257070 != -206860)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (138080 - 362465 == -224385)
					{
						base..ctor();
						if (128112 - 431823 == -303711)
						{
							this.$mPos$34963 = mPos;
							if (230680 - 143870 != 86811)
							{
								this.$self_$34964 = self_;
								if (131918 - 270065 != -138146)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060057E2 RID: 22498 RVA: 0x00A922D4 File Offset: 0x00A904D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (293921 - 47261 != 246660)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6D9;
					case 2:
						if (this.$self_$34964.mChar.actionState != "attack")
						{
							if (104963 - 549028 != -444065)
							{
								continue;
							}
							goto IL_6A5;
						}
						else
						{
							if (!this.$self_$34964.mChar.isMine)
							{
								goto IL_249;
							}
							if (180293 - 181131 != -838)
							{
								continue;
							}
							if (Game.mGameType <= 4)
							{
								goto IL_249;
							}
							if (85889 - 65892 != 19997)
							{
								continue;
							}
							this.$self_$34964.StartCoroutine_Auto(this.$self_$34964.RPC_rAttack_mole_fire(this.$self_$34964.transform.position, this.$self_$34964.transform.forward, 0));
							if (176812 - 323003 == -146190)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_249;
							}
							if (123606 - 576289 == -452682)
							{
								continue;
							}
							this.$self_$34964.ActionEvent("RPC_rAttack_mole_fire", this.$self_$34964.transform.position, this.$self_$34964.transform.forward, 0);
							if (75422 - 590432 != -515010)
							{
								continue;
							}
							goto IL_249;
						}
						break;
					case 3:
						if (this.$self_$34964.mChar.actionState == "attack")
						{
							if (105649 - 583264 == -477614)
							{
								continue;
							}
							if (this.$self_$34964.mChar.myCommand == "rAttack")
							{
								if (271747 - 302769 == -31021)
								{
									continue;
								}
								this.$self_$34964.mChar.actionState = "standby";
								if (268788 - 82112 != 186676)
								{
									continue;
								}
								this.$self_$34964.mChar.actionTime = Time.time;
								if (228036 - 473713 != -245677)
								{
									continue;
								}
								this.$self_$34964.mChar.myCommand = "none";
								if (63890 - 186534 != -122644)
								{
									continue;
								}
								if (!this.$self_$34964.mChar.isMine)
								{
									if (243127 - 490001 == -246873)
									{
										continue;
									}
									this.$self_$34964.mChar.nPosition = this.$self_$34964.transform.position;
									if (195242 - 504081 == -308838)
									{
										continue;
									}
									this.$self_$34964.mChar.oPosition = this.$self_$34964.transform.position;
									if (4351 - 297699 != -293348)
									{
										continue;
									}
									this.$self_$34964.mChar.nDirection = this.$self_$34964.transform.forward;
									if (204497 - 56416 == 148082)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (140109 - 491225 != -351115)
						{
							goto Block_41;
						}
						continue;
					default:
						if (237200 - 412887 != -175687)
						{
							continue;
						}
						break;
					}
					this.$self_$34964.mChar.actionState = "attack";
					if (178463 - 62996 == 115467)
					{
						this.$self_$34964.mChar.actionTime = Time.time;
						if (16211 - 514752 == -498541)
						{
							this.$self_$34964.mChar.myCommand = "rAttack";
							if (113692 - 467070 == -353378)
							{
								this.$self_$34964.mChar.addTimeOut("nAttack", 0.5f);
								if (61024 - 266103 != -205078)
								{
									this.$self_$34964.transform.position = this.$mPos$34963;
									if (11266 - 385138 == -373872)
									{
										this.$self_$34964.mChar.vMovement = this.$self_$34964.transform.forward;
										if (277694 - 28962 == 248732)
										{
											this.$self_$34964.mChar.moveSpeed = (float)9;
											if (218670 - 555897 != -337226)
											{
												if (PlayerPrefs.GetInt("pvoice", 1) == 0)
												{
													goto IL_3C1;
												}
												if (133624 - 6062 != 127563)
												{
													if (!this.$self_$34964.mChar.isMine)
													{
														if (297207 - 438363 != -141156)
														{
															continue;
														}
														if (Game.mGameType <= 4)
														{
															goto IL_3C1;
														}
														if (62694 - 93014 == -30319)
														{
															continue;
														}
														if (Game.mTeam != this.$self_$34964.mChar.mOriginalLayer - 7)
														{
															goto IL_3C1;
														}
														if (102652 - 368354 != -265702)
														{
															continue;
														}
													}
													if (!this.$self_$34964.RuLc6updE13)
													{
														if (229553 - 196667 != 32886)
														{
															continue;
														}
														this.$self_$34964.RuLc6updE13 = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Mole/Voices/cast", typeof(AudioClip));
														if (115487 - 428451 != -312964)
														{
															continue;
														}
													}
													if (this.$self_$34964.RuLc6updE13)
													{
														if (288683 - 566093 == -277410)
														{
															goto IL_300;
														}
													}
													else
													{
														Debug.LogError("Cannot find mole_rAttack voice");
														if (86861 - 8312 != 78550)
														{
															goto Block_22;
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
				IL_249:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_300:
				this.$self_$34964.audio.PlayOneShot(this.$self_$34964.RuLc6updE13, (!this.$self_$34964.mChar.isMine) ? 0.75f : ((float)1));
				Block_22:
				IL_3C1:
				return this.Yield(2, new WaitForSeconds(0.1f));
				Block_41:
				IL_6A5:
				IL_6D9:
				return false;
			}

			// Token: 0x060057E3 RID: 22499 RVA: 0x00A929CC File Offset: 0x00A90BCC
			internal static bool D8rpBNpaeXqSu3nJxw30()
			{
				return true;
			}

			// Token: 0x060057E4 RID: 22500 RVA: 0x00A929D0 File Offset: 0x00A90BD0
			internal static bool ArAnyoparLQpxgXmOFPR()
			{
				return false;
			}

			// Token: 0x040060CF RID: 24783
			internal Vector3 $mPos$34963;

			// Token: 0x040060D0 RID: 24784
			internal ChampionMount $self_$34964;
		}
	}

	// Token: 0x02000F20 RID: 3872
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_mole_fire$34967 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060057E5 RID: 22501 RVA: 0x00A929D4 File Offset: 0x00A90BD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_mole_fire$34967(Vector3 hitPos, ChampionMount self_)
		{
			if (130710 - 328245 != -197534)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (283680 - 478453 == -194773)
				{
					base..ctor();
					if (66418 - 193361 != -126942)
					{
						this.$hitPos$34974 = hitPos;
						if (275281 - 433830 == -158549)
						{
							this.$self_$34975 = self_;
							if (81974 - 556972 == -474998)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060057E6 RID: 22502 RVA: 0x00A92A90 File Offset: 0x00A90C90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_rAttack_mole_fire$34967.$(this.$hitPos$34974, this.$self_$34975);
		}

		// Token: 0x060057E7 RID: 22503 RVA: 0x00A92AA4 File Offset: 0x00A90CA4
		internal static bool gDi4llpajQ8FOJc5fMmO()
		{
			return true;
		}

		// Token: 0x060057E8 RID: 22504 RVA: 0x00A92AA8 File Offset: 0x00A90CA8
		internal static bool TOMEFxpahXZ5DW45OVcj()
		{
			return false;
		}

		// Token: 0x040060D1 RID: 24785
		internal Vector3 $hitPos$34974;

		// Token: 0x040060D2 RID: 24786
		internal ChampionMount $self_$34975;

		// Token: 0x02000F21 RID: 3873
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060057E9 RID: 22505 RVA: 0x00A92AAC File Offset: 0x00A90CAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 hitPos, ChampionMount self_)
			{
				if (274930 - 514440 != -239510)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (27727 - 93192 == -65465)
					{
						base..ctor();
						if (264982 - 442087 != -177104)
						{
							this.$hitPos$34972 = hitPos;
							if (21332 - 8551 == 12781)
							{
								this.$self_$34973 = self_;
								if (3688 - 416579 != -412890)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060057EA RID: 22506 RVA: 0x00A92B68 File Offset: 0x00A90D68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (7375 - 377191 != -369816)
				{
				}
				for (;;)
				{
					IL_432:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_463;
					case 2:
						if (!this.$self_$34973.PsKc6VXmHsh)
						{
							if (68226 - 165003 == -96776)
							{
								continue;
							}
							this.$self_$34973.PsKc6VXmHsh = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/mole_rAttack_hit");
							if (11369 - 565850 != -554481)
							{
								continue;
							}
						}
						if (this.$self_$34973.PsKc6VXmHsh)
						{
							if (87482 - 519193 != -431711)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$34973.PsKc6VXmHsh, this.$hitPos$34972, Quaternion.identity);
							if (283090 - 330852 == -47761)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Cannot find mole_rAttack_hit effect");
							if (154608 - 532368 == -377759)
							{
								continue;
							}
						}
						if (this.$self_$34973.mChar.isMine)
						{
							if (271527 - 41253 == 230275)
							{
								continue;
							}
							this.$hitLayer$34968 = 130816 - (1 << this.$self_$34973.gameObject.layer);
							if (7355 - 152192 != -144837)
							{
								continue;
							}
							this.$hitList$34969 = Damage.FindAreaTarget(this.$hitPos$34972 - 0.5f * Vector3.up, (float)4, (float)3, this.$hitLayer$34968);
							if (9891 - 132263 != -122372)
							{
								continue;
							}
							this.$$iterator$10585$34971 = UnityRuntimeServices.GetEnumerator(this.$hitList$34969);
							if (96997 - 522647 == -425649)
							{
								continue;
							}
							while (this.$$iterator$10585$34971.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10585$34971.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$34970 = (GameObject)obj2;
								if (142152 - 708 != 141444)
								{
									goto IL_432;
								}
								this.$self_$34973.mChar.hit(1, this.$hitObject$34970, (int)(1.5f * (float)this.$self_$34973.mChar.atk), 1, 0, global::Math.vFlat(this.$hitObject$34970.transform.position - this.$hitPos$34972).normalized);
								if (198707 - 441066 == -242358)
								{
									goto IL_432;
								}
								UnityRuntimeServices.Update(this.$$iterator$10585$34971, this.$hitObject$34970);
								if (268913 - 478698 != -209785)
								{
									goto IL_432;
								}
							}
							if (103833 - 275322 != -171489)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (147548 - 563663 != -416114)
						{
							goto Block_19;
						}
						continue;
					default:
						if (179148 - 461185 != -282037)
						{
							continue;
						}
						break;
					}
					if (!this.$self_$34973.nUEc6y4qZnc)
					{
						if (74554 - 211710 == -137155)
						{
							continue;
						}
						this.$self_$34973.nUEc6y4qZnc = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/mole_rAttack_fire");
						if (260903 - 46944 != 213959)
						{
							continue;
						}
					}
					if (this.$self_$34973.nUEc6y4qZnc)
					{
						if (39039 - 534598 == -495559)
						{
							UnityEngine.Object.Instantiate(this.$self_$34973.nUEc6y4qZnc, this.$hitPos$34972, Quaternion.Euler((float)270, (float)90, (float)0));
							if (96773 - 564690 == -467917)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Cannot find mole_rAttack_fire effect");
						if (3881 - 571690 == -567809)
						{
							break;
						}
					}
				}
				goto IL_330;
				Block_19:
				goto IL_463;
				IL_330:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_463:
				return false;
			}

			// Token: 0x060057EB RID: 22507 RVA: 0x00A92FEC File Offset: 0x00A911EC
			internal static bool oJQiIspaswMF2uJy2UWw()
			{
				return true;
			}

			// Token: 0x060057EC RID: 22508 RVA: 0x00A92FF0 File Offset: 0x00A911F0
			internal static bool r0E1kypa9TvQx2G9T4H7()
			{
				return false;
			}

			// Token: 0x040060D3 RID: 24787
			internal int $hitLayer$34968;

			// Token: 0x040060D4 RID: 24788
			internal UnityScript.Lang.Array $hitList$34969;

			// Token: 0x040060D5 RID: 24789
			internal GameObject $hitObject$34970;

			// Token: 0x040060D6 RID: 24790
			internal IEnumerator $$iterator$10585$34971;

			// Token: 0x040060D7 RID: 24791
			internal Vector3 $hitPos$34972;

			// Token: 0x040060D8 RID: 24792
			internal ChampionMount $self_$34973;
		}
	}

	// Token: 0x02000F22 RID: 3874
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_monkey$34976 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060057ED RID: 22509 RVA: 0x00A92FF4 File Offset: 0x00A911F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_monkey$34976(Vector3 mPos, ChampionMount self_)
		{
			if (171808 - 26547 != 145262)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (23439 - 239362 == -215923)
				{
					base..ctor();
					if (33964 - 26011 == 7953)
					{
						this.$mPos$34985 = mPos;
						if (131383 - 414140 != -282756)
						{
							this.$self_$34986 = self_;
							if (28144 - 303849 != -275704)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060057EE RID: 22510 RVA: 0x00A930B0 File Offset: 0x00A912B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_nAttack_monkey$34976.$(this.$mPos$34985, this.$self_$34986);
		}

		// Token: 0x060057EF RID: 22511 RVA: 0x00A930C4 File Offset: 0x00A912C4
		internal static bool FZPnwLpa1J8TUyyAv9Ui()
		{
			return true;
		}

		// Token: 0x060057F0 RID: 22512 RVA: 0x00A930C8 File Offset: 0x00A912C8
		internal static bool xdJL24pa4DSQmHpW7ojN()
		{
			return false;
		}

		// Token: 0x040060D9 RID: 24793
		internal Vector3 $mPos$34985;

		// Token: 0x040060DA RID: 24794
		internal ChampionMount $self_$34986;

		// Token: 0x02000F23 RID: 3875
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060057F1 RID: 22513 RVA: 0x00A930CC File Offset: 0x00A912CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, ChampionMount self_)
			{
				if (10000 - 294841 != -284840)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (193039 - 545779 != -352739)
					{
						base..ctor();
						if (262621 - 351490 == -88869)
						{
							this.$mPos$34983 = mPos;
							if (179958 - 404591 == -224633)
							{
								this.$self_$34984 = self_;
								if (245826 - 477683 == -231857)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060057F2 RID: 22514 RVA: 0x00A93188 File Offset: 0x00A91388
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (179179 - 128342 != 50837)
				{
				}
				for (;;)
				{
					IL_5DC:
					switch (this._state)
					{
					case 0:
						goto IL_7A6;
					case 1:
						goto IL_AD7;
					case 2:
						if (this.$self_$34984.mChar.actionState != "attack")
						{
							if (127263 - 227666 != -100402)
							{
								goto Block_62;
							}
							continue;
						}
						else
						{
							if (!this.$self_$34984.t9Jc6h1aMlv)
							{
								if (52883 - 320645 != -267762)
								{
									continue;
								}
								this.$self_$34984.t9Jc6h1aMlv = (AudioClip)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Sounds/monkey_nAttack", typeof(AudioClip));
								if (1901 - 110941 != -109040)
								{
									continue;
								}
							}
							if (this.$self_$34984.t9Jc6h1aMlv)
							{
								if (166666 - 274188 != -107522)
								{
									continue;
								}
								this.$self_$34984.audio.PlayOneShot(this.$self_$34984.t9Jc6h1aMlv, 1f);
								if (119642 - 112275 != 7367)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing monkey_nAttackFx sounds");
								if (58954 - 354364 != -295410)
								{
									continue;
								}
							}
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_429;
							}
							if (214951 - 570537 != -355586)
							{
								continue;
							}
							if (Game.mGameType <= 4)
							{
								goto IL_429;
							}
							if (257827 - 28428 != 229399)
							{
								continue;
							}
							if (Game.mTeam != this.$self_$34984.mChar.mOriginalLayer - 7)
							{
								goto IL_429;
							}
							if (114101 - 393080 != -278979)
							{
								continue;
							}
							if (!this.$self_$34984.wqac6KAnbuG)
							{
								if (210011 - 142030 != 67981)
								{
									continue;
								}
								this.$self_$34984.wqac6KAnbuG = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Monkey/Voices/nAttack1", typeof(AudioClip));
								if (255732 - 466614 == -210881)
								{
									continue;
								}
							}
							if (this.$self_$34984.wqac6KAnbuG)
							{
								if (42296 - 117934 != -75637)
								{
									goto Block_57;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find monkey_nAttack voice");
								if (78757 - 511914 != -433156)
								{
									goto Block_34;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$34984.mChar.actionState != "attack")
						{
							if (193773 - 154471 != 39303)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							this.$i$34977 = 0;
							if (137203 - 9826 != 127377)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$34984.mChar.actionState != "attack")
						{
							if (234245 - 51895 != 182351)
							{
								goto Block_69;
							}
							continue;
						}
						else
						{
							if (this.$self_$34984.mChar.isMine)
							{
								if (189096 - 283642 != -94546)
								{
									continue;
								}
								this.$hitLayer$34978 = 130816 - (1 << this.$self_$34984.gameObject.layer);
								if (275193 - 410013 == -134819)
								{
									continue;
								}
								this.$hitList$34979 = Damage.FindRecTarget(this.$self_$34984.transform.position, this.$self_$34984.transform.forward, (float)1, (float)1, (float)3, (float)3, this.$hitLayer$34978);
								if (227369 - 336143 != -108774)
								{
									continue;
								}
								this.$$iterator$10578$34982 = UnityRuntimeServices.GetEnumerator(this.$hitList$34979);
								if (158048 - 247499 != -89451)
								{
									continue;
								}
								while (this.$$iterator$10578$34982.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10578$34982.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$34980 = (GameObject)obj2;
									if (179341 - 557761 != -378420)
									{
										goto IL_5DC;
									}
									if (this.$self_$34984.mChar.hit(1, this.$hitObject$34980, (int)(0.7f * (float)this.$self_$34984.mChar.atk), 1, 0, 0.3f * this.$self_$34984.transform.forward) != 0)
									{
										if (292945 - 106341 == 186605)
										{
											goto IL_5DC;
										}
										this.$hitPos$34981 = this.$hitObject$34980.collider.ClosestPointOnBounds(this.$self_$34984.transform.position + (float)2 * Vector3.up);
										if (267196 - 478061 == -210864)
										{
											goto IL_5DC;
										}
										UnityRuntimeServices.Update(this.$$iterator$10578$34982, this.$hitObject$34980);
										if (230698 - 112607 == 118092)
										{
											goto IL_5DC;
										}
										this.$self_$34984.RPC_nAttack_monkey_hit(this.$hitPos$34981, this.$self_$34984.transform.forward, 0);
										if (188240 - 308191 == -119950)
										{
											goto IL_5DC;
										}
										this.$self_$34984.ActionEvent("RPC_nAttack_monkey_hit", this.$hitPos$34981, this.$self_$34984.transform.forward, 0);
										if (140233 - 510223 != -369990)
										{
											goto IL_5DC;
										}
									}
								}
								if (132816 - 198817 != -66001)
								{
									continue;
								}
							}
							this.$i$34977++;
							if (280407 - 107550 == 172858)
							{
								continue;
							}
						}
						break;
					case 5:
						if (this.$self_$34984.mChar.actionState == "attack")
						{
							if (153266 - 201524 != -48258)
							{
								continue;
							}
							if (this.$self_$34984.mChar.myCommand == "nAttack")
							{
								if (108458 - 347904 == -239445)
								{
									continue;
								}
								this.$self_$34984.mChar.actionState = "standby";
								if (199733 - 372374 == -172640)
								{
									continue;
								}
								this.$self_$34984.mChar.actionTime = Time.time;
								if (286907 - 513062 != -226155)
								{
									continue;
								}
								this.$self_$34984.mChar.myCommand = "none";
								if (194814 - 568826 == -374011)
								{
									continue;
								}
								if (!this.$self_$34984.mChar.isMine)
								{
									if (248077 - 364418 == -116340)
									{
										continue;
									}
									this.$self_$34984.mChar.nPosition = this.$self_$34984.transform.position;
									if (253390 - 303567 != -50177)
									{
										continue;
									}
									this.$self_$34984.mChar.oPosition = this.$self_$34984.transform.position;
									if (45145 - 115059 != -69914)
									{
										continue;
									}
									this.$self_$34984.mChar.nDirection = this.$self_$34984.transform.forward;
									if (288558 - 528130 != -239572)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (298832 - 553839 != -255006)
						{
							goto Block_25;
						}
						continue;
					default:
						if (157716 - 106984 != 50732)
						{
							continue;
						}
						goto IL_7A6;
					}
					if (this.$i$34977 < 2)
					{
						goto IL_A50;
					}
					if (133250 - 376327 != -243077)
					{
						continue;
					}
					goto IL_809;
					IL_7A6:
					this.$self_$34984.mChar.actionState = "attack";
					if (99282 - 291148 != -191865)
					{
						this.$self_$34984.mChar.actionTime = Time.time;
						if (236107 - 210568 != 25540)
						{
							this.$self_$34984.mChar.myCommand = "nAttack";
							if (212707 - 410436 == -197729)
							{
								this.$self_$34984.mChar.addTimeOut("nAttack", 1.5f);
								if (101767 - 578600 != -476832)
								{
									this.$self_$34984.transform.position = this.$mPos$34983;
									if (56279 - 519287 == -463008)
									{
										this.$self_$34984.animation.CrossFade("nAttack", 0.2f);
										if (21856 - 39620 == -17764)
										{
											this.$self_$34984.animation.wrapMode = WrapMode.Once;
											if (55624 - 19527 != 36098)
											{
												this.$self_$34984.mChar.vMovement = this.$self_$34984.transform.forward;
												if (64718 - 380749 != -316030)
												{
													this.$self_$34984.mChar.moveSpeed = (float)0;
													if (268345 - 65817 != 202529)
													{
														goto Block_39;
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
				IL_429:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_24:
				Block_25:
				goto IL_AD7;
				Block_34:
				goto IL_429;
				Block_39:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_809:
				return this.Yield(5, new WaitForSeconds(0.2f));
				Block_57:
				this.$self_$34984.audio.PlayOneShot(this.$self_$34984.wqac6KAnbuG, (!this.$self_$34984.mChar.isMine) ? 0.75f : ((float)1));
				goto IL_429;
				Block_62:
				goto IL_AD7;
				IL_A50:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_69:
				IL_AD7:
				return false;
			}

			// Token: 0x060057F3 RID: 22515 RVA: 0x00A93C80 File Offset: 0x00A91E80
			internal static bool TNliMDpaz3ZHvESuIpjt()
			{
				return true;
			}

			// Token: 0x060057F4 RID: 22516 RVA: 0x00A93C84 File Offset: 0x00A91E84
			internal static bool k2pGowp5aIVxFmbMOTBj()
			{
				return false;
			}

			// Token: 0x040060DB RID: 24795
			internal int $i$34977;

			// Token: 0x040060DC RID: 24796
			internal int $hitLayer$34978;

			// Token: 0x040060DD RID: 24797
			internal UnityScript.Lang.Array $hitList$34979;

			// Token: 0x040060DE RID: 24798
			internal GameObject $hitObject$34980;

			// Token: 0x040060DF RID: 24799
			internal Vector3 $hitPos$34981;

			// Token: 0x040060E0 RID: 24800
			internal IEnumerator $$iterator$10578$34982;

			// Token: 0x040060E1 RID: 24801
			internal Vector3 $mPos$34983;

			// Token: 0x040060E2 RID: 24802
			internal ChampionMount $self_$34984;
		}
	}

	// Token: 0x02000F24 RID: 3876
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_monkey$34987 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060057F5 RID: 22517 RVA: 0x00A93C88 File Offset: 0x00A91E88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_monkey$34987(Vector3 mPos, ChampionMount self_)
		{
			if (206795 - 563398 != -356603)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (30634 - 45203 != -14568)
				{
					base..ctor();
					if (241669 - 572285 == -330616)
					{
						this.$mPos$34995 = mPos;
						if (204881 - 403830 == -198949)
						{
							this.$self_$34996 = self_;
							if (130314 - 239974 != -109659)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060057F6 RID: 22518 RVA: 0x00A93D44 File Offset: 0x00A91F44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_rAttack_monkey$34987.$(this.$mPos$34995, this.$self_$34996);
		}

		// Token: 0x060057F7 RID: 22519 RVA: 0x00A93D58 File Offset: 0x00A91F58
		internal static bool Jgx8QSp55QcGGmfEe6HS()
		{
			return true;
		}

		// Token: 0x060057F8 RID: 22520 RVA: 0x00A93D5C File Offset: 0x00A91F5C
		internal static bool a6FReZp5peUpF8YddNMF()
		{
			return false;
		}

		// Token: 0x040060E3 RID: 24803
		internal Vector3 $mPos$34995;

		// Token: 0x040060E4 RID: 24804
		internal ChampionMount $self_$34996;

		// Token: 0x02000F25 RID: 3877
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060057F9 RID: 22521 RVA: 0x00A93D60 File Offset: 0x00A91F60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, ChampionMount self_)
			{
				if (243825 - 98232 != 145594)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (165481 - 522409 != -356927)
					{
						base..ctor();
						if (60377 - 40315 == 20062)
						{
							this.$mPos$34993 = mPos;
							if (112131 - 151234 == -39103)
							{
								this.$self_$34994 = self_;
								if (3814 - 91328 == -87514)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060057FA RID: 22522 RVA: 0x00A93E1C File Offset: 0x00A9201C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (151380 - 14429 != 136952)
				{
				}
				for (;;)
				{
					IL_949:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_97E;
					case 2:
						if (this.$self_$34994.mChar.actionState != "attack")
						{
							if (240236 - 129744 != 110493)
							{
								goto Block_44;
							}
							continue;
						}
						else
						{
							if (!this.$self_$34994.ArEct5n9lWQ)
							{
								if (213831 - 282140 != -68309)
								{
									continue;
								}
								this.$self_$34994.ArEct5n9lWQ = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/monkey_rAttack", typeof(GameObject));
								if (133086 - 10651 != 122435)
								{
									continue;
								}
							}
							if (this.$self_$34994.ArEct5n9lWQ)
							{
								if (188018 - 209929 == -21910)
								{
									continue;
								}
								this.$self_$34994.mChar.createEffect(this.$self_$34994.ArEct5n9lWQ, this.$self_$34994.transform.position, this.$self_$34994.transform.rotation);
								if (298700 - 502074 == -203373)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find monkey_rAttack effect");
								if (255600 - 13011 == 242590)
								{
									continue;
								}
							}
							if (PlayerPrefs.GetInt("pvoice", 1) != 0)
							{
								if (237878 - 572612 == -334733)
								{
									continue;
								}
								if (Game.mGameType > 4)
								{
									if (35354 - 146464 != -111110)
									{
										continue;
									}
									if (Game.mTeam == this.$self_$34994.mChar.mOriginalLayer - 7)
									{
										if (112378 - 65486 == 46893)
										{
											continue;
										}
										if (!this.$self_$34994.B6gctcFgytC)
										{
											if (157173 - 570604 != -413431)
											{
												continue;
											}
											this.$self_$34994.B6gctcFgytC = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Monkey/Voices/cast", typeof(AudioClip));
											if (234480 - 429910 == -195429)
											{
												continue;
											}
										}
										if (this.$self_$34994.B6gctcFgytC)
										{
											if (225633 - 445315 != -219682)
											{
												continue;
											}
											this.$self_$34994.audio.PlayOneShot(this.$self_$34994.B6gctcFgytC, (!this.$self_$34994.mChar.isMine) ? 0.75f : ((float)1));
										}
										else
										{
											Debug.LogError("Cannot find monkey_rAttack voice");
											if (128951 - 592874 == -463922)
											{
												continue;
											}
										}
									}
								}
							}
							this.$i$34988 = 0;
							if (87235 - 249034 != -161798)
							{
								goto IL_488;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$34994.mChar.actionState != "attack")
						{
							if (149261 - 417630 != -268368)
							{
								goto Block_50;
							}
							continue;
						}
						else
						{
							if (this.$self_$34994.mChar.isMine)
							{
								if (173031 - 57858 != 115173)
								{
									continue;
								}
								this.$hitLayer$34989 = 130816 - (1 << this.$self_$34994.gameObject.layer);
								if (111637 - 578988 == -467350)
								{
									continue;
								}
								this.$hitList$34990 = Damage.FindAreaTarget(this.$self_$34994.transform.position, (float)6, (float)3, this.$hitLayer$34989);
								if (245102 - 351236 != -106134)
								{
									continue;
								}
								this.$$iterator$10586$34992 = UnityRuntimeServices.GetEnumerator(this.$hitList$34990);
								if (119132 - 321935 == -202802)
								{
									continue;
								}
								while (this.$$iterator$10586$34992.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10586$34992.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$34991 = (GameObject)obj2;
									if (28442 - 138119 != -109677)
									{
										goto IL_949;
									}
									this.$self_$34994.mChar.hit(1, this.$hitObject$34991, this.$self_$34994.mChar.talAdjust(30), 1, 0, Vector3.zero);
									if (126626 - 221934 == -95307)
									{
										goto IL_949;
									}
									UnityRuntimeServices.Update(this.$$iterator$10586$34992, this.$hitObject$34991);
									if (4573 - 73481 == -68907)
									{
										goto IL_949;
									}
								}
								if (160735 - 440716 != -279981)
								{
									continue;
								}
							}
							this.$i$34988++;
							if (119626 - 388326 != -268699)
							{
								goto IL_488;
							}
							continue;
						}
						break;
					default:
						if (42824 - 468997 == -426172)
						{
							continue;
						}
						break;
					}
					this.$self_$34994.mChar.actionState = "attack";
					if (4886 - 282760 != -277874)
					{
						continue;
					}
					this.$self_$34994.mChar.actionTime = Time.time;
					if (152919 - 518905 == -365985)
					{
						continue;
					}
					this.$self_$34994.mChar.myCommand = "rAttack";
					if (280639 - 306374 != -25735)
					{
						continue;
					}
					this.$self_$34994.mChar.addTimeOut("nAttack", (float)5);
					if (92834 - 273155 == -180320)
					{
						continue;
					}
					this.$self_$34994.transform.position = this.$mPos$34993;
					if (22932 - 367191 == -344258)
					{
						continue;
					}
					this.$self_$34994.animation.CrossFade("rAttack", 0.2f);
					if (292253 - 240993 != 51260)
					{
						continue;
					}
					this.$self_$34994.animation.wrapMode = WrapMode.Once;
					if (259093 - 137645 != 121448)
					{
						continue;
					}
					this.$self_$34994.mChar.vMovement = this.$self_$34994.transform.forward;
					if (229499 - 376602 != -147103)
					{
						continue;
					}
					this.$self_$34994.mChar.moveSpeed = (float)9;
					if (221231 - 469772 != -248540)
					{
						break;
					}
					continue;
					IL_488:
					if (this.$i$34988 < 5)
					{
						goto IL_6F8;
					}
					if (48879 - 545659 != -496779)
					{
						if (this.$self_$34994.mChar.actionState == "attack")
						{
							if (224860 - 132550 == 92311)
							{
								continue;
							}
							if (this.$self_$34994.mChar.myCommand == "rAttack")
							{
								if (116025 - 489355 == -373329)
								{
									continue;
								}
								this.$self_$34994.mChar.actionState = "standby";
								if (5594 - 278191 != -272597)
								{
									continue;
								}
								this.$self_$34994.mChar.actionTime = Time.time;
								if (253908 - 557782 != -303874)
								{
									continue;
								}
								this.$self_$34994.mChar.myCommand = "none";
								if (32132 - 361290 == -329157)
								{
									continue;
								}
								if (!this.$self_$34994.mChar.isMine)
								{
									if (122691 - 97040 != 25651)
									{
										continue;
									}
									this.$self_$34994.mChar.nPosition = this.$self_$34994.transform.position;
									if (271727 - 67789 != 203938)
									{
										continue;
									}
									this.$self_$34994.mChar.oPosition = this.$self_$34994.transform.position;
									if (203985 - 425476 == -221490)
									{
										continue;
									}
									this.$self_$34994.mChar.nDirection = this.$self_$34994.transform.forward;
									if (87755 - 261502 != -173747)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (159032 - 509389 == -350357)
						{
							goto IL_97E;
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_44:
				goto IL_97E;
				IL_6F8:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_50:
				IL_97E:
				return false;
			}

			// Token: 0x060057FB RID: 22523 RVA: 0x00A947BC File Offset: 0x00A929BC
			internal static bool UR6JF0p5Vk2LXwlYfn8X()
			{
				return true;
			}

			// Token: 0x060057FC RID: 22524 RVA: 0x00A947C0 File Offset: 0x00A929C0
			internal static bool tkdZV9p5tTE15gNYYnGY()
			{
				return false;
			}

			// Token: 0x040060E5 RID: 24805
			internal int $i$34988;

			// Token: 0x040060E6 RID: 24806
			internal int $hitLayer$34989;

			// Token: 0x040060E7 RID: 24807
			internal UnityScript.Lang.Array $hitList$34990;

			// Token: 0x040060E8 RID: 24808
			internal GameObject $hitObject$34991;

			// Token: 0x040060E9 RID: 24809
			internal IEnumerator $$iterator$10586$34992;

			// Token: 0x040060EA RID: 24810
			internal Vector3 $mPos$34993;

			// Token: 0x040060EB RID: 24811
			internal ChampionMount $self_$34994;
		}
	}

	// Token: 0x02000F26 RID: 3878
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_sheep$34997 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060057FD RID: 22525 RVA: 0x00A947C4 File Offset: 0x00A929C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_sheep$34997(Vector3 mPos, Vector3 tDir, int tID, ChampionMount self_)
		{
			if (162452 - 519028 != -356575)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (85089 - 453980 == -368891)
				{
					base..ctor();
					if (206237 - 15035 == 191202)
					{
						this.$mPos$35005 = mPos;
						if (274512 - 406730 != -132217)
						{
							this.$tDir$35006 = tDir;
							if (48643 - 457876 == -409233)
							{
								this.$tID$35007 = tID;
								if (75861 - 286046 != -210184)
								{
									this.$self_$35008 = self_;
									if (136343 - 500591 != -364247)
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

		// Token: 0x060057FE RID: 22526 RVA: 0x00A948C4 File Offset: 0x00A92AC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_nAttack_sheep$34997.$(this.$mPos$35005, this.$tDir$35006, this.$tID$35007, this.$self_$35008);
		}

		// Token: 0x060057FF RID: 22527 RVA: 0x00A948E4 File Offset: 0x00A92AE4
		internal static bool YcRnBfp5NsiPnPs7GVqF()
		{
			return true;
		}

		// Token: 0x06005800 RID: 22528 RVA: 0x00A948E8 File Offset: 0x00A92AE8
		internal static bool MDcQknp5YBXOGDGHZLat()
		{
			return false;
		}

		// Token: 0x040060EC RID: 24812
		internal Vector3 $mPos$35005;

		// Token: 0x040060ED RID: 24813
		internal Vector3 $tDir$35006;

		// Token: 0x040060EE RID: 24814
		internal int $tID$35007;

		// Token: 0x040060EF RID: 24815
		internal ChampionMount $self_$35008;

		// Token: 0x02000F27 RID: 3879
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005801 RID: 22529 RVA: 0x00A948EC File Offset: 0x00A92AEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, ChampionMount self_)
			{
				if (44042 - 63415 != -19373)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (37380 - 338498 != -301117)
					{
						base..ctor();
						if (193364 - 349306 == -155942)
						{
							this.$mPos$35001 = mPos;
							if (123515 - 461619 != -338103)
							{
								this.$tDir$35002 = tDir;
								if (272796 - 419201 != -146404)
								{
									this.$tID$35003 = tID;
									if (212536 - 52843 == 159693)
									{
										this.$self_$35004 = self_;
										if (246267 - 332064 != -85796)
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

			// Token: 0x06005802 RID: 22530 RVA: 0x00A949EC File Offset: 0x00A92BEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (229528 - 107329 != 122200)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_932;
					case 2:
						if (this.$self_$35004.mChar.actionState != "attack")
						{
							if (39903 - 518460 != -478557)
							{
								continue;
							}
							goto IL_5DE;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) != 0)
							{
								if (113015 - 102309 != 10706)
								{
									continue;
								}
								if (!this.$self_$35004.mChar.isMine)
								{
									if (116561 - 316997 == -200435)
									{
										continue;
									}
									if (Game.mGameType <= 4)
									{
										goto IL_65E;
									}
									if (189661 - 283923 != -94262)
									{
										continue;
									}
									if (Game.mTeam != this.$self_$35004.mChar.mOriginalLayer - 7)
									{
										goto IL_65E;
									}
									if (35598 - 295347 != -259749)
									{
										continue;
									}
								}
								if (!this.$self_$35004.WPfctQSWujC)
								{
									if (294916 - 529408 == -234491)
									{
										continue;
									}
									this.$self_$35004.WPfctQSWujC = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Sheep/Voices/nAttack1", typeof(AudioClip));
									if (108336 - 550311 != -441975)
									{
										continue;
									}
								}
								if (this.$self_$35004.WPfctQSWujC)
								{
									if (211711 - 289764 == -78052)
									{
										continue;
									}
									this.$self_$35004.audio.PlayOneShot(this.$self_$35004.WPfctQSWujC, (!this.$self_$35004.mChar.isMine) ? 0.75f : ((float)1));
								}
								else
								{
									Debug.LogError("Cannot find sheep_nAttack voice");
									if (118327 - 356634 != -238307)
									{
										continue;
									}
								}
							}
							IL_65E:
							if (!this.$self_$35004.A5octnt8LeA)
							{
								if (42656 - 322401 != -279745)
								{
									continue;
								}
								this.$self_$35004.A5octnt8LeA = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/sheep_nAttack", typeof(GameObject));
								if (214344 - 393518 == -179173)
								{
									continue;
								}
							}
							if (this.$self_$35004.A5octnt8LeA)
							{
								if (89671 - 438026 == -348354)
								{
									continue;
								}
								this.$self_$35004.mChar.createEffect(this.$self_$35004.A5octnt8LeA, this.$self_$35004.transform.position, this.$self_$35004.transform.rotation);
								if (233455 - 382997 != -149541)
								{
									goto Block_23;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find sheep_nAttack effect");
								if (207594 - 483229 != -275634)
								{
									goto Block_11;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$35004.mChar.actionState != "attack")
						{
							if (126787 - 569344 != -442556)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							if (!this.$self_$35004.mChar.isMine)
							{
								goto IL_4AE;
							}
							if (90472 - 396520 == -306047)
							{
								continue;
							}
							if (Game.mGameType < 5)
							{
								goto IL_4AE;
							}
							if (61989 - 507340 == -445350)
							{
								continue;
							}
							this.$firePos$34999 = this.$mPos$35001 + (float)3 * Vector3.up;
							if (60647 - 100517 == -39869)
							{
								continue;
							}
							this.$fireDir$35000 = (this.$tPos$34998 - this.$firePos$34999).normalized;
							if (282976 - 465448 == -182471)
							{
								continue;
							}
							this.$self_$35004.RPC_nAttack_sheep_fire(this.$firePos$34999, this.$self_$35004.transform.forward, this.$tID$35003);
							if (268724 - 517437 != -248713)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_4AE;
							}
							if (123627 - 562779 != -439152)
							{
								continue;
							}
							this.$self_$35004.ActionEvent("RPC_nAttack_sheep_fire", this.$firePos$34999, this.$self_$35004.transform.forward, this.$tID$35003);
							if (263360 - 294505 != -31144)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$35004.mChar.actionState == "attack")
						{
							if (11169 - 127878 == -116708)
							{
								continue;
							}
							if (this.$self_$35004.mChar.myCommand == "nAttack")
							{
								if (246619 - 364732 == -118112)
								{
									continue;
								}
								this.$self_$35004.mChar.actionState = "standby";
								if (64578 - 267506 != -202928)
								{
									continue;
								}
								this.$self_$35004.mChar.actionTime = Time.time;
								if (7531 - 549795 == -542263)
								{
									continue;
								}
								this.$self_$35004.mChar.myCommand = "none";
								if (288317 - 365561 != -77244)
								{
									continue;
								}
								if (!this.$self_$35004.mChar.isMine)
								{
									if (15921 - 461008 != -445087)
									{
										continue;
									}
									this.$self_$35004.mChar.nPosition = this.$self_$35004.transform.position;
									if (170487 - 104897 != 65590)
									{
										continue;
									}
									this.$self_$35004.mChar.oPosition = this.$self_$35004.transform.position;
									if (195578 - 554139 == -358560)
									{
										continue;
									}
									this.$self_$35004.mChar.nDirection = this.$self_$35004.transform.forward;
									if (12048 - 328093 != -316045)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (159753 - 457076 != -297322)
						{
							goto Block_42;
						}
						continue;
					default:
						if (85382 - 233212 == -147829)
						{
							continue;
						}
						break;
					}
					this.$tPos$34998 = this.$mPos$35001 + this.$tDir$35002;
					if (38111 - 320796 != -282684)
					{
						this.$self_$35004.mChar.actionState = "attack";
						if (230674 - 469050 == -238376)
						{
							this.$self_$35004.mChar.actionTime = Time.time;
							if (79057 - 139061 == -60004)
							{
								this.$self_$35004.mChar.myCommand = "nAttack";
								if (123520 - 360611 == -237091)
								{
									this.$self_$35004.mChar.addTimeOut("nAttack", (float)3);
									if (74053 - 249139 != -175085)
									{
										this.$self_$35004.transform.position = this.$mPos$35001;
										if (262019 - 246922 != 15098)
										{
											this.$self_$35004.animation.CrossFade("nAttack", 0.2f);
											if (95164 - 132988 != -37823)
											{
												this.$self_$35004.animation.wrapMode = WrapMode.Once;
												if (244198 - 93986 == 150212)
												{
													this.$self_$35004.mChar.vMovement = this.$self_$35004.transform.forward;
													if (59253 - 557017 == -497764)
													{
														this.$self_$35004.mChar.moveSpeed = (float)0;
														if (285944 - 168310 != 117635)
														{
															goto Block_18;
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
				Block_11:
				IL_1A0:
				return this.Yield(3, new WaitForSeconds(0.9f));
				Block_14:
				goto IL_932;
				Block_18:
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_23:
				goto IL_1A0;
				Block_26:
				IL_4AE:
				return this.Yield(4, new WaitForSeconds(0.6f));
				IL_5DE:
				Block_42:
				IL_932:
				return false;
			}

			// Token: 0x06005803 RID: 22531 RVA: 0x00A95340 File Offset: 0x00A93540
			internal static bool h3ISP2p5chsXC7umRjY7()
			{
				return true;
			}

			// Token: 0x06005804 RID: 22532 RVA: 0x00A95344 File Offset: 0x00A93544
			internal static bool anqnL7p5UKkZdsvu09Db()
			{
				return false;
			}

			// Token: 0x040060F0 RID: 24816
			internal Vector3 $tPos$34998;

			// Token: 0x040060F1 RID: 24817
			internal Vector3 $firePos$34999;

			// Token: 0x040060F2 RID: 24818
			internal Vector3 $fireDir$35000;

			// Token: 0x040060F3 RID: 24819
			internal Vector3 $mPos$35001;

			// Token: 0x040060F4 RID: 24820
			internal Vector3 $tDir$35002;

			// Token: 0x040060F5 RID: 24821
			internal int $tID$35003;

			// Token: 0x040060F6 RID: 24822
			internal ChampionMount $self_$35004;
		}
	}

	// Token: 0x02000F28 RID: 3880
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_sheep$35009 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005805 RID: 22533 RVA: 0x00A95348 File Offset: 0x00A93548
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_sheep$35009(Vector3 mPos, Vector3 tDir, ChampionMount self_)
		{
			if (159653 - 541441 != -381788)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (223264 - 491821 == -268557)
				{
					base..ctor();
					if (15420 - 348078 != -332657)
					{
						this.$mPos$35018 = mPos;
						if (267906 - 403246 == -135340)
						{
							this.$tDir$35019 = tDir;
							if (69503 - 128807 != -59303)
							{
								this.$self_$35020 = self_;
								if (71047 - 295250 == -224203)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005806 RID: 22534 RVA: 0x00A95424 File Offset: 0x00A93624
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_rAttack_sheep$35009.$(this.$mPos$35018, this.$tDir$35019, this.$self_$35020);
		}

		// Token: 0x06005807 RID: 22535 RVA: 0x00A95440 File Offset: 0x00A93640
		internal static bool cINZagp5TvLoCchTfkOK()
		{
			return true;
		}

		// Token: 0x06005808 RID: 22536 RVA: 0x00A95444 File Offset: 0x00A93644
		internal static bool UWGKmyp53vwM0lSI0A9s()
		{
			return false;
		}

		// Token: 0x040060F7 RID: 24823
		internal Vector3 $mPos$35018;

		// Token: 0x040060F8 RID: 24824
		internal Vector3 $tDir$35019;

		// Token: 0x040060F9 RID: 24825
		internal ChampionMount $self_$35020;

		// Token: 0x02000F29 RID: 3881
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005809 RID: 22537 RVA: 0x00A95448 File Offset: 0x00A93648
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, ChampionMount self_)
			{
				if (113149 - 57304 != 55845)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (295872 - 569947 != -274074)
					{
						base..ctor();
						if (282303 - 522969 != -240665)
						{
							this.$mPos$35015 = mPos;
							if (172483 - 196532 != -24048)
							{
								this.$tDir$35016 = tDir;
								if (215524 - 207803 == 7721)
								{
									this.$self_$35017 = self_;
									if (261547 - 135347 == 126200)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600580A RID: 22538 RVA: 0x00A95524 File Offset: 0x00A93724
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (122340 - 94274 != 28067)
				{
				}
				for (;;)
				{
					IL_611:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_933;
					case 2:
						if (this.$self_$35017.mChar.actionState != "attack")
						{
							if (77987 - 22429 != 55558)
							{
								continue;
							}
							goto IL_C0;
						}
						else
						{
							if (!this.$self_$35017.mChar.isMine)
							{
								goto IL_87D;
							}
							if (168499 - 395019 != -226520)
							{
								continue;
							}
							this.$hitLayer$35010 = 1 << this.$self_$35017.gameObject.layer;
							if (125823 - 411783 == -285959)
							{
								continue;
							}
							this.$hitList$35011 = Damage.FindAreaTarget(this.$self_$35017.transform.position, (float)6 * this.$self_$35017.mChar.rangeMod, (float)3 * this.$self_$35017.mChar.rangeMod, this.$hitLayer$35010);
							if (218226 - 88743 == 129484)
							{
								continue;
							}
							this.$$iterator$10587$35014 = UnityRuntimeServices.GetEnumerator(this.$hitList$35011);
							if (130151 - 54384 == 75768)
							{
								continue;
							}
							while (this.$$iterator$10587$35014.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10587$35014.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$35012 = (GameObject)obj2;
								if (75234 - 408194 != -332960)
								{
									goto IL_611;
								}
								this.$tChar$35013 = (CharacterControl)this.$hitObject$35012.GetComponent(typeof(CharacterControl));
								if (291236 - 77517 == 213720)
								{
									goto IL_611;
								}
								UnityRuntimeServices.Update(this.$$iterator$10587$35014, this.$hitObject$35012);
								if (269810 - 117756 != 152054)
								{
									goto IL_611;
								}
								this.$tChar$35013.RPC_AddHeal(1, this.$self_$35017.mChar.talAdjust(10), 0, 0, 0, 0, this.$self_$35017.mChar.ActorNr);
								if (34188 - 66764 != -32576)
								{
									goto IL_611;
								}
							}
							if (212206 - 479164 != -266958)
							{
								continue;
							}
							goto IL_87D;
						}
						break;
					case 3:
						if (this.$self_$35017.mChar.actionState == "attack")
						{
							if (264573 - 591909 == -327335)
							{
								continue;
							}
							if (this.$self_$35017.mChar.myCommand == "rAttack")
							{
								if (146780 - 436727 != -289947)
								{
									continue;
								}
								this.$self_$35017.mChar.actionState = "standby";
								if (135188 - 21833 == 113356)
								{
									continue;
								}
								this.$self_$35017.mChar.actionTime = Time.time;
								if (175865 - 18395 == 157471)
								{
									continue;
								}
								this.$self_$35017.mChar.myCommand = "none";
								if (25516 - 38848 != -13332)
								{
									continue;
								}
								if (!this.$self_$35017.mChar.isMine)
								{
									if (156595 - 378841 != -222246)
									{
										continue;
									}
									this.$self_$35017.mChar.nPosition = this.$self_$35017.transform.position;
									if (163495 - 23154 == 140342)
									{
										continue;
									}
									this.$self_$35017.mChar.oPosition = this.$self_$35017.transform.position;
									if (291828 - 192846 != 98982)
									{
										continue;
									}
									this.$self_$35017.mChar.nDirection = this.$self_$35017.transform.forward;
									if (186939 - 191929 == -4989)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (285179 - 154622 != 130558)
						{
							goto Block_28;
						}
						continue;
					default:
						if (2285 - 159849 != -157564)
						{
							continue;
						}
						break;
					}
					this.$self_$35017.mChar.actionState = "attack";
					if (223858 - 93181 == 130677)
					{
						this.$self_$35017.mChar.actionTime = Time.time;
						if (88099 - 451116 == -363017)
						{
							this.$self_$35017.mChar.myCommand = "rAttack";
							if (38964 - 15340 == 23624)
							{
								this.$self_$35017.mChar.addTimeOut("nAttack", (float)2);
								if (284528 - 103792 != 180737)
								{
									this.$self_$35017.transform.position = this.$mPos$35015;
									if (109325 - 480536 != -371210)
									{
										this.$self_$35017.transform.LookAt(this.$mPos$35015 + global::Math.vFlat(this.$tDir$35016));
										if (70250 - 118349 == -48099)
										{
											this.$self_$35017.mChar.vMovement = this.$self_$35017.transform.forward;
											if (234536 - 239852 == -5316)
											{
												this.$self_$35017.mChar.moveSpeed = (float)9;
												if (87730 - 358131 == -270401)
												{
													if (PlayerPrefs.GetInt("pvoice", 1) != 0)
													{
														if (36258 - 419819 == -383560)
														{
															continue;
														}
														if (!this.$self_$35017.mChar.isMine)
														{
															if (241341 - 199814 == 41528)
															{
																continue;
															}
															if (Game.mGameType <= 4)
															{
																goto IL_69A;
															}
															if (42892 - 236329 == -193436)
															{
																continue;
															}
															if (Game.mTeam != this.$self_$35017.mChar.mOriginalLayer - 7)
															{
																goto IL_69A;
															}
															if (268767 - 36887 == 231881)
															{
																continue;
															}
														}
														if (!this.$self_$35017.JTgct6EIKrt)
														{
															if (253672 - 571898 != -318226)
															{
																continue;
															}
															this.$self_$35017.JTgct6EIKrt = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Sheep/Voices/nAttack2", typeof(AudioClip));
															if (221628 - 509901 == -288272)
															{
																continue;
															}
														}
														if (this.$self_$35017.JTgct6EIKrt)
														{
															if (216208 - 582584 == -366375)
															{
																continue;
															}
															this.$self_$35017.audio.PlayOneShot(this.$self_$35017.JTgct6EIKrt, (!this.$self_$35017.mChar.isMine) ? 0.75f : ((float)1));
														}
														else
														{
															Debug.LogError("Cannot find sheep_rAttack voice");
															if (151529 - 455719 == -304189)
															{
																continue;
															}
														}
													}
													IL_69A:
													if (!this.$self_$35017.IBDctJDweSo)
													{
														if (146479 - 331597 != -185118)
														{
															continue;
														}
														this.$self_$35017.IBDctJDweSo = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/sheep_rAttack", typeof(GameObject));
														if (111927 - 500215 != -388288)
														{
															continue;
														}
													}
													if (this.$self_$35017.IBDctJDweSo)
													{
														if (177158 - 491537 == -314379)
														{
															this.$self_$35017.mChar.createEffect(this.$self_$35017.IBDctJDweSo, this.$self_$35017.transform.position, this.$self_$35017.transform.rotation);
															if (72869 - 485001 != -412131)
															{
																goto Block_13;
															}
														}
													}
													else
													{
														Debug.LogError("Cannot find sheep_rAttack effect");
														if (93460 - 11034 == 82426)
														{
															goto IL_767;
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
				IL_C0:
				goto IL_933;
				Block_13:
				goto IL_767;
				Block_28:
				goto IL_933;
				IL_767:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_87D:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_933:
				return false;
			}

			// Token: 0x0600580B RID: 22539 RVA: 0x00A95E78 File Offset: 0x00A94078
			internal static bool x4aN4Sp5XIUxYqEvKHyo()
			{
				return true;
			}

			// Token: 0x0600580C RID: 22540 RVA: 0x00A95E7C File Offset: 0x00A9407C
			internal static bool mZX2Dkp5QgDZqKGyCyNP()
			{
				return false;
			}

			// Token: 0x040060FA RID: 24826
			internal int $hitLayer$35010;

			// Token: 0x040060FB RID: 24827
			internal UnityScript.Lang.Array $hitList$35011;

			// Token: 0x040060FC RID: 24828
			internal GameObject $hitObject$35012;

			// Token: 0x040060FD RID: 24829
			internal CharacterControl $tChar$35013;

			// Token: 0x040060FE RID: 24830
			internal IEnumerator $$iterator$10587$35014;

			// Token: 0x040060FF RID: 24831
			internal Vector3 $mPos$35015;

			// Token: 0x04006100 RID: 24832
			internal Vector3 $tDir$35016;

			// Token: 0x04006101 RID: 24833
			internal ChampionMount $self_$35017;
		}
	}

	// Token: 0x02000F2A RID: 3882
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_penguin$35021 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600580D RID: 22541 RVA: 0x00A95E80 File Offset: 0x00A94080
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_penguin$35021(Vector3 mPos, Vector3 tDir, ChampionMount self_)
		{
			if (298531 - 592291 != -293760)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (27198 - 43500 == -16302)
				{
					base..ctor();
					if (8705 - 442094 != -433388)
					{
						this.$mPos$35028 = mPos;
						if (105920 - 117783 == -11863)
						{
							this.$tDir$35029 = tDir;
							if (99313 - 63795 == 35518)
							{
								this.$self_$35030 = self_;
								if (217294 - 53499 != 163796)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600580E RID: 22542 RVA: 0x00A95F5C File Offset: 0x00A9415C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_nAttack_penguin$35021.$(this.$mPos$35028, this.$tDir$35029, this.$self_$35030);
		}

		// Token: 0x0600580F RID: 22543 RVA: 0x00A95F78 File Offset: 0x00A94178
		internal static bool nQghTNp5k4BL7lCbYTN2()
		{
			return true;
		}

		// Token: 0x06005810 RID: 22544 RVA: 0x00A95F7C File Offset: 0x00A9417C
		internal static bool BXAoEhp5Gruw5nv2g0XC()
		{
			return false;
		}

		// Token: 0x04006102 RID: 24834
		internal Vector3 $mPos$35028;

		// Token: 0x04006103 RID: 24835
		internal Vector3 $tDir$35029;

		// Token: 0x04006104 RID: 24836
		internal ChampionMount $self_$35030;

		// Token: 0x02000F2B RID: 3883
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005811 RID: 22545 RVA: 0x00A95F80 File Offset: 0x00A94180
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, ChampionMount self_)
			{
				if (32986 - 465650 != -432663)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (260964 - 570438 == -309474)
					{
						base..ctor();
						if (236710 - 345542 != -108831)
						{
							this.$mPos$35025 = mPos;
							if (268769 - 516523 != -247753)
							{
								this.$tDir$35026 = tDir;
								if (85254 - 226386 != -141131)
								{
									this.$self_$35027 = self_;
									if (38245 - 245874 == -207629)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005812 RID: 22546 RVA: 0x00A9605C File Offset: 0x00A9425C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (87728 - 184536 != -96808)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_809;
					case 2:
						if (this.$self_$35027.mChar.actionState != "attack")
						{
							if (235082 - 590587 != -355505)
							{
								continue;
							}
							goto IL_49;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_789;
							}
							if (56149 - 120086 == -63936)
							{
								continue;
							}
							if (!this.$self_$35027.mChar.isMine)
							{
								if (151847 - 598032 == -446184)
								{
									continue;
								}
								if (Game.mGameType <= 4)
								{
									goto IL_789;
								}
								if (246413 - 486880 == -240466)
								{
									continue;
								}
								if (Game.mTeam != this.$self_$35027.mChar.mOriginalLayer - 7)
								{
									goto IL_789;
								}
								if (23801 - 547554 == -523752)
								{
									continue;
								}
							}
							if (!this.$self_$35027.sVsctt8ahEG)
							{
								if (141540 - 52073 != 89467)
								{
									continue;
								}
								this.$self_$35027.sVsctt8ahEG = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Penguin/Voices/nAttack1", typeof(AudioClip));
								if (230329 - 308309 == -77979)
								{
									continue;
								}
							}
							if (this.$self_$35027.sVsctt8ahEG)
							{
								if (177161 - 114996 != 62166)
								{
									goto Block_3;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find  penguin_nAttack voice");
								if (286395 - 34372 != 252023)
								{
									continue;
								}
								goto IL_789;
							}
						}
						break;
					case 3:
						if (this.$self_$35027.mChar.actionState != "attack")
						{
							if (289338 - 67372 != 221966)
							{
								continue;
							}
							goto IL_9D;
						}
						else
						{
							if (!this.$self_$35027.mChar.isMine)
							{
								goto IL_D1;
							}
							if (178142 - 210198 == -32055)
							{
								continue;
							}
							if (Game.mGameType < 5)
							{
								goto IL_D1;
							}
							if (243117 - 168768 != 74349)
							{
								continue;
							}
							this.$firePos$35023 = this.$mPos$35025 + this.$self_$35027.transform.TransformDirection(-0.15f, 2.2f, (float)1);
							if (153175 - 532536 == -379360)
							{
								continue;
							}
							this.$fireDir$35024 = (this.$tPos$35022 - this.$firePos$35023).normalized;
							if (254045 - 580415 != -326370)
							{
								continue;
							}
							this.$self_$35027.RPC_nAttack_penguin_fire(this.$firePos$35023, this.$fireDir$35024, 0);
							if (113692 - 566199 != -452507)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_D1;
							}
							if (615 - 154862 == -154246)
							{
								continue;
							}
							this.$self_$35027.ActionEvent("RPC_nAttack_penguin_fire", this.$firePos$35023, this.$fireDir$35024, 0);
							if (268692 - 505584 != -236891)
							{
								goto Block_45;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$35027.mChar.actionState == "attack")
						{
							if (124709 - 476725 == -352015)
							{
								continue;
							}
							if (this.$self_$35027.mChar.myCommand == "nAttack")
							{
								if (138844 - 163025 != -24181)
								{
									continue;
								}
								this.$self_$35027.mChar.actionState = "standby";
								if (192901 - 26124 != 166777)
								{
									continue;
								}
								this.$self_$35027.mChar.actionTime = Time.time;
								if (130203 - 48445 == 81759)
								{
									continue;
								}
								this.$self_$35027.mChar.myCommand = "none";
								if (236349 - 292903 == -56553)
								{
									continue;
								}
								if (!this.$self_$35027.mChar.isMine)
								{
									if (199570 - 56944 == 142627)
									{
										continue;
									}
									this.$self_$35027.mChar.nPosition = this.$self_$35027.transform.position;
									if (217790 - 274869 != -57079)
									{
										continue;
									}
									this.$self_$35027.mChar.oPosition = this.$self_$35027.transform.position;
									if (22211 - 230181 == -207969)
									{
										continue;
									}
									this.$self_$35027.mChar.nDirection = this.$self_$35027.transform.forward;
									if (103985 - 552910 == -448924)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (100933 - 559398 != -458464)
						{
							goto Block_12;
						}
						continue;
					default:
						if (42632 - 326143 != -283511)
						{
							continue;
						}
						break;
					}
					this.$tPos$35022 = this.$mPos$35025 + this.$tDir$35026;
					if (163990 - 390910 != -226919)
					{
						this.$self_$35027.mChar.actionState = "attack";
						if (80391 - 184138 != -103746)
						{
							this.$self_$35027.mChar.actionTime = Time.time;
							if (8976 - 334577 == -325601)
							{
								this.$self_$35027.mChar.myCommand = "nAttack";
								if (59807 - 267344 != -207536)
								{
									this.$self_$35027.mChar.addTimeOut("nAttack", (float)1);
									if (259315 - 390531 == -131216)
									{
										this.$self_$35027.transform.position = this.$mPos$35025;
										if (124611 - 575016 != -450404)
										{
											this.$self_$35027.animation.CrossFade("nAttack", 0.2f);
											if (228208 - 11545 != 216664)
											{
												this.$self_$35027.animation.wrapMode = WrapMode.Once;
												if (283217 - 498777 != -215559)
												{
													this.$self_$35027.mChar.vMovement = this.$self_$35027.transform.forward;
													if (280071 - 264441 == 15630)
													{
														this.$self_$35027.mChar.moveSpeed = (float)0;
														if (103772 - 161590 == -57818)
														{
															goto IL_320;
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
				Block_3:
				this.$self_$35027.audio.PlayOneShot(this.$self_$35027.sVsctt8ahEG, (!this.$self_$35027.mChar.isMine) ? 0.75f : ((float)1));
				goto IL_789;
				IL_49:
				IL_9D:
				goto IL_809;
				IL_D1:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_12:
				goto IL_809;
				IL_320:
				return this.Yield(2, new WaitForSeconds(0.1f));
				Block_45:
				goto IL_D1;
				IL_789:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_809:
				return false;
			}

			// Token: 0x06005813 RID: 22547 RVA: 0x00A96884 File Offset: 0x00A94A84
			internal static bool BMZXMsp5Hg9YTQGfw7cd()
			{
				return true;
			}

			// Token: 0x06005814 RID: 22548 RVA: 0x00A96888 File Offset: 0x00A94A88
			internal static bool rRnkyQp5WuJLgIYUMmFm()
			{
				return false;
			}

			// Token: 0x04006105 RID: 24837
			internal Vector3 $tPos$35022;

			// Token: 0x04006106 RID: 24838
			internal Vector3 $firePos$35023;

			// Token: 0x04006107 RID: 24839
			internal Vector3 $fireDir$35024;

			// Token: 0x04006108 RID: 24840
			internal Vector3 $mPos$35025;

			// Token: 0x04006109 RID: 24841
			internal Vector3 $tDir$35026;

			// Token: 0x0400610A RID: 24842
			internal ChampionMount $self_$35027;
		}
	}

	// Token: 0x02000F2C RID: 3884
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_penguin$35031 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005815 RID: 22549 RVA: 0x00A9688C File Offset: 0x00A94A8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_penguin$35031(Vector3 mPos, Vector3 tDir, ChampionMount self_)
		{
			if (184964 - 584998 != -400034)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (2063 - 107221 == -105158)
				{
					base..ctor();
					if (158635 - 346586 != -187950)
					{
						this.$mPos$35039 = mPos;
						if (259888 - 396247 != -136358)
						{
							this.$tDir$35040 = tDir;
							if (40483 - 496186 != -455702)
							{
								this.$self_$35041 = self_;
								if (279205 - 344726 == -65521)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005816 RID: 22550 RVA: 0x00A96968 File Offset: 0x00A94B68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_rAttack_penguin$35031.$(this.$mPos$35039, this.$tDir$35040, this.$self_$35041);
		}

		// Token: 0x06005817 RID: 22551 RVA: 0x00A96984 File Offset: 0x00A94B84
		internal static bool EM5AlYp5A5vp6YTjIeg2()
		{
			return true;
		}

		// Token: 0x06005818 RID: 22552 RVA: 0x00A96988 File Offset: 0x00A94B88
		internal static bool NinJiEp5l8WIcuAYFTYT()
		{
			return false;
		}

		// Token: 0x0400610B RID: 24843
		internal Vector3 $mPos$35039;

		// Token: 0x0400610C RID: 24844
		internal Vector3 $tDir$35040;

		// Token: 0x0400610D RID: 24845
		internal ChampionMount $self_$35041;

		// Token: 0x02000F2D RID: 3885
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005819 RID: 22553 RVA: 0x00A9698C File Offset: 0x00A94B8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, ChampionMount self_)
			{
				if (10134 - 183574 != -173440)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (60887 - 48598 == 12289)
					{
						base..ctor();
						if (198153 - 119754 == 78399)
						{
							this.$mPos$35036 = mPos;
							if (220769 - 407100 == -186331)
							{
								this.$tDir$35037 = tDir;
								if (1278 - 383626 != -382347)
								{
									this.$self_$35038 = self_;
									if (254986 - 226621 == 28365)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600581A RID: 22554 RVA: 0x00A96A68 File Offset: 0x00A94C68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (70458 - 486533 != -416075)
				{
				}
				for (;;)
				{
					IL_7A2:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8FE;
					case 2:
						if (this.$self_$35038.mChar.actionState != "attack")
						{
							if (28730 - 307046 != -278316)
							{
								continue;
							}
							goto IL_3ED;
						}
						else
						{
							if (!this.$self_$35038.mChar.isMine)
							{
								goto IL_F4;
							}
							if (296746 - 464807 == -168060)
							{
								continue;
							}
							this.$hitLayer$35032 = 130816 - (1 << this.$self_$35038.gameObject.layer);
							if (227112 - 572146 == -345033)
							{
								continue;
							}
							this.$hitList$35033 = Damage.FindAreaTarget(this.$self_$35038.transform.position, (float)6 * this.$self_$35038.mChar.rangeMod, (float)3 * this.$self_$35038.mChar.rangeMod, this.$hitLayer$35032);
							if (133778 - 510608 != -376830)
							{
								continue;
							}
							this.$$iterator$10588$35035 = UnityRuntimeServices.GetEnumerator(this.$hitList$35033);
							if (79181 - 267572 != -188391)
							{
								continue;
							}
							while (this.$$iterator$10588$35035.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10588$35035.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$35034 = (GameObject)obj2;
								if (57015 - 583052 == -526036)
								{
									goto IL_7A2;
								}
								this.$self_$35038.mChar.hit(1, this.$hitObject$35034, this.$self_$35038.mChar.talAdjust(30), 1, 0, Vector3.zero);
								if (131423 - 283999 != -152576)
								{
									goto IL_7A2;
								}
								UnityRuntimeServices.Update(this.$$iterator$10588$35035, this.$hitObject$35034);
								if (144650 - 88370 != 56280)
								{
									goto IL_7A2;
								}
							}
							if (185104 - 367834 != -182729)
							{
								goto Block_57;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$35038.mChar.actionState == "attack")
						{
							if (203477 - 348613 == -145135)
							{
								continue;
							}
							if (this.$self_$35038.mChar.myCommand == "rAttack")
							{
								if (123194 - 503946 != -380752)
								{
									continue;
								}
								this.$self_$35038.mChar.actionState = "standby";
								if (193207 - 482093 != -288886)
								{
									continue;
								}
								this.$self_$35038.mChar.actionTime = Time.time;
								if (94373 - 9027 == 85347)
								{
									continue;
								}
								this.$self_$35038.mChar.myCommand = "none";
								if (133240 - 225014 == -91773)
								{
									continue;
								}
								if (!this.$self_$35038.mChar.isMine)
								{
									if (176980 - 265277 != -88297)
									{
										continue;
									}
									this.$self_$35038.mChar.nPosition = this.$self_$35038.transform.position;
									if (227408 - 286252 == -58843)
									{
										continue;
									}
									this.$self_$35038.mChar.oPosition = this.$self_$35038.transform.position;
									if (276811 - 223438 == 53374)
									{
										continue;
									}
									this.$self_$35038.mChar.nDirection = this.$self_$35038.transform.forward;
									if (199002 - 577369 == -378366)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (186829 - 417165 != -230335)
						{
							goto Block_6;
						}
						continue;
					default:
						if (250332 - 54016 == 196317)
						{
							continue;
						}
						break;
					}
					this.$self_$35038.mChar.actionState = "attack";
					if (110080 - 239267 != -129186)
					{
						this.$self_$35038.mChar.actionTime = Time.time;
						if (147014 - 212432 != -65417)
						{
							this.$self_$35038.mChar.myCommand = "rAttack";
							if (109609 - 445547 == -335938)
							{
								this.$self_$35038.mChar.addTimeOut("nAttack", (float)1);
								if (99596 - 181677 == -82081)
								{
									this.$self_$35038.transform.position = this.$mPos$35036;
									if (191744 - 66839 != 124906)
									{
										this.$self_$35038.transform.LookAt(this.$mPos$35036 + global::Math.vFlat(this.$tDir$35037));
										if (83551 - 69073 != 14479)
										{
											this.$self_$35038.mChar.vMovement = this.$self_$35038.transform.forward;
											if (24679 - 120530 != -95850)
											{
												this.$self_$35038.mChar.moveSpeed = (float)9;
												if (281532 - 374221 == -92689)
												{
													if (!this.$self_$35038.KHhct2VboUV)
													{
														if (89796 - 193487 != -103691)
														{
															continue;
														}
														this.$self_$35038.KHhct2VboUV = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/penguin_rAttack", typeof(GameObject));
														if (187701 - 555820 != -368119)
														{
															continue;
														}
													}
													if (this.$self_$35038.KHhct2VboUV)
													{
														if (109701 - 367247 != -257546)
														{
															continue;
														}
														this.$self_$35038.mChar.createEffect(this.$self_$35038.KHhct2VboUV, this.$self_$35038.transform.position, this.$self_$35038.transform.rotation);
														if (263995 - 207473 == 56523)
														{
															continue;
														}
													}
													else
													{
														Debug.LogError("Cannot find penguin_rAttack effect");
														if (223016 - 245609 == -22592)
														{
															continue;
														}
													}
													if (PlayerPrefs.GetInt("pvoice", 1) == 0)
													{
														goto IL_548;
													}
													if (252642 - 70936 != 181707)
													{
														if (!this.$self_$35038.mChar.isMine)
														{
															if (214485 - 498419 == -283933)
															{
																continue;
															}
															if (Game.mGameType <= 4)
															{
																goto IL_548;
															}
															if (116005 - 553781 != -437776)
															{
																continue;
															}
															if (Game.mTeam != this.$self_$35038.mChar.mOriginalLayer - 7)
															{
																goto IL_548;
															}
															if (125009 - 541863 == -416853)
															{
																continue;
															}
														}
														if (!this.$self_$35038.I3Ictveebuv)
														{
															if (108365 - 192520 == -84154)
															{
																continue;
															}
															this.$self_$35038.I3Ictveebuv = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Penguin/Voices/cast", typeof(AudioClip));
															if (239113 - 204226 == 34888)
															{
																continue;
															}
														}
														if (this.$self_$35038.I3Ictveebuv)
														{
															if (125993 - 596964 != -470970)
															{
																goto Block_30;
															}
														}
														else
														{
															Debug.LogError("Cannot find  penguin_rAttack voice");
															if (176081 - 531158 == -355077)
															{
																goto IL_548;
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
				Block_6:
				goto IL_8FE;
				IL_F4:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_3ED:
				goto IL_8FE;
				Block_30:
				this.$self_$35038.audio.PlayOneShot(this.$self_$35038.I3Ictveebuv, (!this.$self_$35038.mChar.isMine) ? 0.75f : ((float)1));
				IL_548:
				return this.Yield(2, new WaitForSeconds(0.1f));
				Block_57:
				goto IL_F4;
				IL_8FE:
				return false;
			}

			// Token: 0x0600581B RID: 22555 RVA: 0x00A97388 File Offset: 0x00A95588
			internal static bool UUP0MJp5y8WZswd8Wlca()
			{
				return true;
			}

			// Token: 0x0600581C RID: 22556 RVA: 0x00A9738C File Offset: 0x00A9558C
			internal static bool VrLZlcp5SPNwmU8rvqUC()
			{
				return false;
			}

			// Token: 0x0400610E RID: 24846
			internal int $hitLayer$35032;

			// Token: 0x0400610F RID: 24847
			internal UnityScript.Lang.Array $hitList$35033;

			// Token: 0x04006110 RID: 24848
			internal GameObject $hitObject$35034;

			// Token: 0x04006111 RID: 24849
			internal IEnumerator $$iterator$10588$35035;

			// Token: 0x04006112 RID: 24850
			internal Vector3 $mPos$35036;

			// Token: 0x04006113 RID: 24851
			internal Vector3 $tDir$35037;

			// Token: 0x04006114 RID: 24852
			internal ChampionMount $self_$35038;
		}
	}

	// Token: 0x02000F2E RID: 3886
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_bat$35042 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600581D RID: 22557 RVA: 0x00A97390 File Offset: 0x00A95590
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_bat$35042(Vector3 mPos, Vector3 tDir, ChampionMount self_)
		{
			if (166788 - 293872 != -127084)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (280639 - 592864 != -312224)
				{
					base..ctor();
					if (63640 - 31424 == 32216)
					{
						this.$mPos$35049 = mPos;
						if (112151 - 64667 != 47485)
						{
							this.$tDir$35050 = tDir;
							if (62898 - 574428 != -511529)
							{
								this.$self_$35051 = self_;
								if (65142 - 225439 != -160296)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600581E RID: 22558 RVA: 0x00A9746C File Offset: 0x00A9566C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_nAttack_bat$35042.$(this.$mPos$35049, this.$tDir$35050, this.$self_$35051);
		}

		// Token: 0x0600581F RID: 22559 RVA: 0x00A97488 File Offset: 0x00A95688
		internal static bool yOC40Dp5oDRYaU05snnY()
		{
			return true;
		}

		// Token: 0x06005820 RID: 22560 RVA: 0x00A9748C File Offset: 0x00A9568C
		internal static bool iw4DnNp5ES1rbUs5sbcd()
		{
			return false;
		}

		// Token: 0x04006115 RID: 24853
		internal Vector3 $mPos$35049;

		// Token: 0x04006116 RID: 24854
		internal Vector3 $tDir$35050;

		// Token: 0x04006117 RID: 24855
		internal ChampionMount $self_$35051;

		// Token: 0x02000F2F RID: 3887
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005821 RID: 22561 RVA: 0x00A97490 File Offset: 0x00A95690
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, ChampionMount self_)
			{
				if (250806 - 128964 != 121843)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (194186 - 223174 != -28987)
					{
						base..ctor();
						if (250370 - 498935 != -248564)
						{
							this.$mPos$35046 = mPos;
							if (173558 - 266341 != -92782)
							{
								this.$tDir$35047 = tDir;
								if (80945 - 6146 == 74799)
								{
									this.$self_$35048 = self_;
									if (93649 - 366094 != -272444)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005822 RID: 22562 RVA: 0x00A9756C File Offset: 0x00A9576C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (128857 - 157318 != -28460)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_813;
					case 2:
						if (this.$self_$35048.mChar.actionState != "attack")
						{
							if (7013 - 495064 != -488050)
							{
								goto Block_40;
							}
							continue;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_35E;
							}
							if (60460 - 503577 != -443117)
							{
								continue;
							}
							if (!this.$self_$35048.mChar.isMine)
							{
								if (259274 - 190420 != 68854)
								{
									continue;
								}
								if (Game.mGameType <= 4)
								{
									goto IL_35E;
								}
								if (252267 - 563258 == -310990)
								{
									continue;
								}
								if (Game.mTeam != this.$self_$35048.mChar.mOriginalLayer - 7)
								{
									goto IL_35E;
								}
								if (185011 - 261703 == -76691)
								{
									continue;
								}
							}
							if (!this.$self_$35048.a7yctlWaCum)
							{
								if (3732 - 365802 == -362069)
								{
									continue;
								}
								this.$self_$35048.a7yctlWaCum = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Bat/Voices/nAttack1", typeof(AudioClip));
								if (145996 - 11395 != 134601)
								{
									continue;
								}
							}
							if (this.$self_$35048.a7yctlWaCum)
							{
								if (190627 - 269088 != -78460)
								{
									goto Block_46;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find bat_nAttack voice");
								if (229612 - 133166 != 96446)
								{
									continue;
								}
								goto IL_35E;
							}
						}
						break;
					case 3:
						if (this.$self_$35048.mChar.actionState != "attack")
						{
							if (129428 - 488208 != -358779)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							if (!this.$self_$35048.mChar.isMine)
							{
								goto IL_6CF;
							}
							if (214210 - 168792 == 45419)
							{
								continue;
							}
							if (Game.mGameType <= 4)
							{
								goto IL_6CF;
							}
							if (213355 - 210090 != 3265)
							{
								continue;
							}
							this.$firePos$35044 = this.$self_$35048.transform.position + this.$self_$35048.transform.TransformDirection((float)0, 2.2f, 1.2f);
							if (138865 - 154081 == -15215)
							{
								continue;
							}
							this.$fireDir$35045 = (this.$tPos$35043 - this.$firePos$35044).normalized;
							if (27587 - 366634 == -339046)
							{
								continue;
							}
							this.$self_$35048.RPC_nAttack_bat_fire(this.$firePos$35044, this.$fireDir$35045, 0);
							if (206386 - 569160 == -362773)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_6CF;
							}
							if (286573 - 397225 == -110651)
							{
								continue;
							}
							this.$self_$35048.ActionEvent("RPC_nAttack_bat_fire", this.$firePos$35044, this.$fireDir$35045, 0);
							if (152979 - 76674 != 76305)
							{
								continue;
							}
							goto IL_6CF;
						}
						break;
					case 4:
						if (this.$self_$35048.mChar.actionState == "attack")
						{
							if (259259 - 19669 == 239591)
							{
								continue;
							}
							if (this.$self_$35048.mChar.myCommand == "nAttack")
							{
								if (208723 - 332976 != -124253)
								{
									continue;
								}
								this.$self_$35048.mChar.actionState = "standby";
								if (140116 - 92784 != 47332)
								{
									continue;
								}
								this.$self_$35048.mChar.actionTime = Time.time;
								if (222233 - 156867 == 65367)
								{
									continue;
								}
								this.$self_$35048.mChar.myCommand = "none";
								if (82994 - 539915 != -456921)
								{
									continue;
								}
								if (!this.$self_$35048.mChar.isMine)
								{
									if (32319 - 484135 != -451816)
									{
										continue;
									}
									this.$self_$35048.mChar.nPosition = this.$self_$35048.transform.position;
									if (5892 - 440773 != -434881)
									{
										continue;
									}
									this.$self_$35048.mChar.oPosition = this.$self_$35048.transform.position;
									if (210315 - 329320 != -119005)
									{
										continue;
									}
									this.$self_$35048.mChar.nDirection = this.$self_$35048.transform.forward;
									if (77322 - 120754 != -43432)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (73774 - 392361 != -318587)
						{
							continue;
						}
						goto IL_813;
					default:
						if (105776 - 366290 != -260514)
						{
							continue;
						}
						break;
					}
					this.$tPos$35043 = this.$mPos$35046 + this.$tDir$35047;
					if (298983 - 448876 != -149892)
					{
						this.$self_$35048.mChar.actionState = "attack";
						if (168503 - 225700 != -57196)
						{
							this.$self_$35048.mChar.actionTime = Time.time;
							if (90165 - 343790 == -253625)
							{
								this.$self_$35048.mChar.myCommand = "nAttack";
								if (265295 - 89469 == 175826)
								{
									this.$self_$35048.mChar.addTimeOut("nAttack", (float)2);
									if (115353 - 350174 == -234821)
									{
										this.$self_$35048.transform.position = this.$mPos$35046;
										if (172494 - 326385 == -153891)
										{
											this.$self_$35048.animation.CrossFade("nAttack", 0.2f);
											if (84185 - 163698 != -79512)
											{
												this.$self_$35048.animation.wrapMode = WrapMode.Once;
												if (294193 - 20421 == 273772)
												{
													this.$self_$35048.mChar.vMovement = this.$self_$35048.transform.forward;
													if (5968 - 380835 == -374867)
													{
														this.$self_$35048.mChar.moveSpeed = (float)0;
														if (189326 - 61044 != 128283)
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
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_35E:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_24:
				Block_40:
				goto IL_813;
				Block_46:
				this.$self_$35048.audio.PlayOneShot(this.$self_$35048.a7yctlWaCum, (!this.$self_$35048.mChar.isMine) ? 0.75f : ((float)1));
				goto IL_35E;
				IL_6CF:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_813:
				return false;
			}

			// Token: 0x06005823 RID: 22563 RVA: 0x00A97DA0 File Offset: 0x00A95FA0
			internal static bool dLD6Mlp52ntfXXuE4ee6()
			{
				return true;
			}

			// Token: 0x06005824 RID: 22564 RVA: 0x00A97DA4 File Offset: 0x00A95FA4
			internal static bool F0DdTgp58PaCdDJZH0lH()
			{
				return false;
			}

			// Token: 0x04006118 RID: 24856
			internal Vector3 $tPos$35043;

			// Token: 0x04006119 RID: 24857
			internal Vector3 $firePos$35044;

			// Token: 0x0400611A RID: 24858
			internal Vector3 $fireDir$35045;

			// Token: 0x0400611B RID: 24859
			internal Vector3 $mPos$35046;

			// Token: 0x0400611C RID: 24860
			internal Vector3 $tDir$35047;

			// Token: 0x0400611D RID: 24861
			internal ChampionMount $self_$35048;
		}
	}

	// Token: 0x02000F30 RID: 3888
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_bat$35052 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005825 RID: 22565 RVA: 0x00A97DA8 File Offset: 0x00A95FA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_bat$35052(Vector3 mPos, ChampionMount self_)
		{
			if (216452 - 488382 != -271929)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (20539 - 32700 != -12160)
				{
					base..ctor();
					if (67193 - 74812 == -7619)
					{
						this.$mPos$35060 = mPos;
						if (53455 - 375669 == -322214)
						{
							this.$self_$35061 = self_;
							if (188358 - 226983 == -38625)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005826 RID: 22566 RVA: 0x00A97E64 File Offset: 0x00A96064
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_rAttack_bat$35052.$(this.$mPos$35060, this.$self_$35061);
		}

		// Token: 0x06005827 RID: 22567 RVA: 0x00A97E78 File Offset: 0x00A96078
		internal static bool FS0UMWp5ZjM5VEhSmKn0()
		{
			return true;
		}

		// Token: 0x06005828 RID: 22568 RVA: 0x00A97E7C File Offset: 0x00A9607C
		internal static bool UICDN9p5CRF5c0dBgZqo()
		{
			return false;
		}

		// Token: 0x0400611E RID: 24862
		internal Vector3 $mPos$35060;

		// Token: 0x0400611F RID: 24863
		internal ChampionMount $self_$35061;

		// Token: 0x02000F31 RID: 3889
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005829 RID: 22569 RVA: 0x00A97E80 File Offset: 0x00A96080
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, ChampionMount self_)
			{
				if (143502 - 278215 != -134713)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (240354 - 46724 == 193630)
					{
						base..ctor();
						if (83477 - 214138 == -130661)
						{
							this.$mPos$35058 = mPos;
							if (71407 - 386137 != -314729)
							{
								this.$self_$35059 = self_;
								if (224480 - 589603 != -365122)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600582A RID: 22570 RVA: 0x00A97F3C File Offset: 0x00A9613C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (34475 - 369709 != -335233)
				{
				}
				for (;;)
				{
					IL_8F4:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A32;
					case 2:
						if (this.$self_$35059.mChar.actionState != "attack")
						{
							if (205859 - 569225 != -363365)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) != 0)
							{
								if (245067 - 100258 != 144809)
								{
									continue;
								}
								if (!this.$self_$35059.mChar.isMine)
								{
									if (207336 - 368915 == -161578)
									{
										continue;
									}
									if (Game.mGameType <= 4)
									{
										goto IL_7B5;
									}
									if (9583 - 494853 != -485270)
									{
										continue;
									}
									if (Game.mTeam != this.$self_$35059.mChar.mOriginalLayer - 7)
									{
										goto IL_7B5;
									}
									if (238576 - 409130 == -170553)
									{
										continue;
									}
								}
								if (!this.$self_$35059.JUuctRWxSd0)
								{
									if (51077 - 184885 == -133807)
									{
										continue;
									}
									this.$self_$35059.JUuctRWxSd0 = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Bat/Voices/nAttack4", typeof(AudioClip));
									if (134441 - 545250 == -410808)
									{
										continue;
									}
								}
								if (this.$self_$35059.JUuctRWxSd0)
								{
									if (86177 - 568347 != -482170)
									{
										continue;
									}
									this.$self_$35059.audio.PlayOneShot(this.$self_$35059.JUuctRWxSd0, (!this.$self_$35059.mChar.isMine) ? 0.75f : ((float)1));
								}
								else
								{
									Debug.LogError("Cannot find bat_rAttack voice");
									if (165940 - 322830 == -156889)
									{
										continue;
									}
								}
							}
							IL_7B5:
							if (!this.$self_$35059.SsectpOMkfn)
							{
								if (15604 - 191767 != -176163)
								{
									continue;
								}
								this.$self_$35059.SsectpOMkfn = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/bat_rAttack", typeof(GameObject));
								if (133711 - 585542 == -451830)
								{
									continue;
								}
							}
							if (this.$self_$35059.SsectpOMkfn)
							{
								if (196434 - 58266 == 138169)
								{
									continue;
								}
								this.$self_$35059.mChar.createEffect(this.$self_$35059.SsectpOMkfn, this.$self_$35059.transform.position, this.$self_$35059.transform.rotation);
								if (71466 - 239808 != -168341)
								{
									goto Block_13;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find bat_rAttack effect");
								if (269431 - 131964 != 137467)
								{
									continue;
								}
								goto IL_92D;
							}
						}
						break;
					case 3:
						if (this.$self_$35059.mChar.actionState != "attack")
						{
							if (193060 - 41585 != 151475)
							{
								continue;
							}
							goto IL_259;
						}
						else
						{
							if (!this.$self_$35059.mChar.isMine)
							{
								goto IL_69D;
							}
							if (130367 - 145669 == -15301)
							{
								continue;
							}
							this.$hitLayer$35053 = 130816 - (1 << this.$self_$35059.gameObject.layer);
							if (296227 - 250326 != 45901)
							{
								continue;
							}
							this.$hitList$35054 = Damage.FindAreaTarget(this.$self_$35059.transform.position, (float)6, (float)3, this.$hitLayer$35053);
							if (34928 - 521697 == -486768)
							{
								continue;
							}
							this.$$iterator$10589$35057 = UnityRuntimeServices.GetEnumerator(this.$hitList$35054);
							if (89747 - 77298 != 12449)
							{
								continue;
							}
							while (this.$$iterator$10589$35057.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10589$35057.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$35055 = (GameObject)obj2;
								if (86932 - 402775 == -315842)
								{
									goto IL_8F4;
								}
								if (this.$self_$35059.mChar.hit(1, this.$hitObject$35055, this.$self_$35059.mChar.talAdjust(45), 1, 0, Vector3.zero) != 0)
								{
									if (160931 - 428506 == -267574)
									{
										goto IL_8F4;
									}
									this.$hitChar$35056 = (CharacterControl)this.$hitObject$35055.GetComponent(typeof(CharacterControl));
									if (263981 - 469568 != -205587)
									{
										goto IL_8F4;
									}
									UnityRuntimeServices.Update(this.$$iterator$10589$35057, this.$hitObject$35055);
									if (31760 - 541675 != -509915)
									{
										goto IL_8F4;
									}
									if (this.$hitChar$35056)
									{
										if (282047 - 135957 != 146090)
										{
											goto IL_8F4;
										}
										this.$hitChar$35056.RPC_AddStatus("curse", Mathf.Clamp(this.$hitChar$35056.getStatusLv("curse") + 1, 1, 4), Damage.getDebuff((float)15, this.$self_$35059.mChar.cha, this.$hitChar$35056.cha), 0, this.$self_$35059.mChar.ActorNr);
										if (274399 - 252574 == 21826)
										{
											goto IL_8F4;
										}
									}
								}
							}
							if (209198 - 232406 != -23207)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$35059.mChar.actionState == "attack")
						{
							if (198756 - 139568 == 59189)
							{
								continue;
							}
							if (this.$self_$35059.mChar.myCommand == "rAttack")
							{
								if (100240 - 88940 == 11301)
								{
									continue;
								}
								this.$self_$35059.mChar.actionState = "standby";
								if (77019 - 215054 == -138034)
								{
									continue;
								}
								this.$self_$35059.mChar.actionTime = Time.time;
								if (32306 - 346452 != -314146)
								{
									continue;
								}
								this.$self_$35059.mChar.myCommand = "none";
								if (246080 - 151941 != 94139)
								{
									continue;
								}
								if (!this.$self_$35059.mChar.isMine)
								{
									if (161954 - 419569 == -257614)
									{
										continue;
									}
									this.$self_$35059.mChar.nPosition = this.$self_$35059.transform.position;
									if (239588 - 514734 == -275145)
									{
										continue;
									}
									this.$self_$35059.mChar.oPosition = this.$self_$35059.transform.position;
									if (205048 - 572970 == -367921)
									{
										continue;
									}
									this.$self_$35059.mChar.nDirection = this.$self_$35059.transform.forward;
									if (294993 - 372046 != -77053)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (150737 - 397688 != -246951)
						{
							continue;
						}
						goto IL_A32;
					default:
						if (90922 - 26681 == 64242)
						{
							continue;
						}
						break;
					}
					this.$self_$35059.mChar.actionState = "attack";
					if (87603 - 424121 != -336517)
					{
						this.$self_$35059.mChar.actionTime = Time.time;
						if (95679 - 43915 == 51764)
						{
							this.$self_$35059.mChar.myCommand = "rAttack";
							if (134359 - 35968 != 98392)
							{
								this.$self_$35059.mChar.addTimeOut("nAttack", (float)2);
								if (229410 - 319965 == -90555)
								{
									this.$self_$35059.transform.position = this.$mPos$35058;
									if (254950 - 3125 != 251826)
									{
										this.$self_$35059.animation.CrossFade("rAttack", 0.2f);
										if (43147 - 322371 == -279224)
										{
											this.$self_$35059.animation.wrapMode = WrapMode.Once;
											if (32105 - 419767 != -387661)
											{
												this.$self_$35059.mChar.vMovement = this.$self_$35059.transform.forward;
												if (27050 - 76059 != -49008)
												{
													this.$self_$35059.mChar.moveSpeed = (float)9;
													if (145770 - 452330 != -306559)
													{
														goto Block_40;
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
				Block_13:
				goto IL_92D;
				IL_259:
				Block_20:
				goto IL_A32;
				Block_26:
				goto IL_69D;
				Block_40:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_69D:
				return this.Yield(4, new WaitForSeconds(0.4f));
				IL_92D:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_A32:
				return false;
			}

			// Token: 0x0600582B RID: 22571 RVA: 0x00A98990 File Offset: 0x00A96B90
			internal static bool dS78Sfp5LAPvCJE1pHuO()
			{
				return true;
			}

			// Token: 0x0600582C RID: 22572 RVA: 0x00A98994 File Offset: 0x00A96B94
			internal static bool Fr4uFVp5OrlKULo0blGC()
			{
				return false;
			}

			// Token: 0x04006120 RID: 24864
			internal int $hitLayer$35053;

			// Token: 0x04006121 RID: 24865
			internal UnityScript.Lang.Array $hitList$35054;

			// Token: 0x04006122 RID: 24866
			internal GameObject $hitObject$35055;

			// Token: 0x04006123 RID: 24867
			internal CharacterControl $hitChar$35056;

			// Token: 0x04006124 RID: 24868
			internal IEnumerator $$iterator$10589$35057;

			// Token: 0x04006125 RID: 24869
			internal Vector3 $mPos$35058;

			// Token: 0x04006126 RID: 24870
			internal ChampionMount $self_$35059;
		}
	}

	// Token: 0x02000F32 RID: 3890
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack2$35062 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600582D RID: 22573 RVA: 0x00A98998 File Offset: 0x00A96B98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack2$35062(Vector3 mPos, Vector3 tDir, int tID, ChampionMount self_)
		{
			if (138171 - 505340 != -367168)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (123202 - 218082 == -94880)
				{
					base..ctor();
					if (21898 - 252260 != -230361)
					{
						this.$mPos$35073 = mPos;
						if (94289 - 144714 != -50424)
						{
							this.$tDir$35074 = tDir;
							if (72275 - 459349 != -387073)
							{
								this.$tID$35075 = tID;
								if (52582 - 277341 != -224758)
								{
									this.$self_$35076 = self_;
									if (202058 - 280848 != -78789)
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

		// Token: 0x0600582E RID: 22574 RVA: 0x00A98A98 File Offset: 0x00A96C98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChampionMount.$RPC_cAttack2$35062.$(this.$mPos$35073, this.$tDir$35074, this.$tID$35075, this.$self_$35076);
		}

		// Token: 0x0600582F RID: 22575 RVA: 0x00A98AB8 File Offset: 0x00A96CB8
		internal static bool Is89Jpp5mfHNUAdh9PYN()
		{
			return true;
		}

		// Token: 0x06005830 RID: 22576 RVA: 0x00A98ABC File Offset: 0x00A96CBC
		internal static bool qNo6pAp5FvHUnOdtKsGu()
		{
			return false;
		}

		// Token: 0x04006127 RID: 24871
		internal Vector3 $mPos$35073;

		// Token: 0x04006128 RID: 24872
		internal Vector3 $tDir$35074;

		// Token: 0x04006129 RID: 24873
		internal int $tID$35075;

		// Token: 0x0400612A RID: 24874
		internal ChampionMount $self_$35076;

		// Token: 0x02000F33 RID: 3891
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005831 RID: 22577 RVA: 0x00A98AC0 File Offset: 0x00A96CC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, ChampionMount self_)
			{
				if (274971 - 73055 != 201917)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (80018 - 332408 == -252390)
					{
						base..ctor();
						if (210408 - 426236 == -215828)
						{
							this.$mPos$35069 = mPos;
							if (32130 - 477241 == -445111)
							{
								this.$tDir$35070 = tDir;
								if (75456 - 5573 == 69883)
								{
									this.$tID$35071 = tID;
									if (217148 - 539413 != -322264)
									{
										this.$self_$35072 = self_;
										if (140896 - 391930 == -251034)
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

			// Token: 0x06005832 RID: 22578 RVA: 0x00A98BC0 File Offset: 0x00A96DC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (276095 - 117246 != 158849)
				{
				}
				for (;;)
				{
					IL_A1D:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_AF3;
					case 2:
						if (this.$self_$35072.mChar.actionState != "attack")
						{
							goto IL_80E;
						}
						if (107196 - 208628 == -101431)
						{
							continue;
						}
						if (this.$self_$35072.mChar.myCommand != "cAttack2")
						{
							if (64048 - 390694 != -326645)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							this.$i$35063 = 0;
							if (265827 - 543952 != -278125)
							{
								continue;
							}
							goto IL_9F0;
						}
						break;
					case 3:
						if (this.$self_$35072.mChar.actionState != "attack")
						{
							goto IL_6AC;
						}
						if (72800 - 550735 != -477935)
						{
							continue;
						}
						if (this.$self_$35072.mChar.myCommand != "cAttack2")
						{
							if (118343 - 390877 != -272533)
							{
								goto Block_65;
							}
							continue;
						}
						else
						{
							this.$i$35063++;
							if (283074 - 264547 != 18527)
							{
								continue;
							}
							goto IL_9F0;
						}
						break;
					default:
						if (167558 - 401617 == -234058)
						{
							continue;
						}
						break;
					}
					this.$self_$35072.B7kctru5NtE = (float)0;
					if (257518 - 322932 != -65414)
					{
						continue;
					}
					if (this.$self_$35072.APNctxMQgZ5)
					{
						if (288181 - 488488 != -200307)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.$self_$35072.APNctxMQgZ5);
						if (154931 - 79264 == 75668)
						{
							continue;
						}
					}
					this.$self_$35072.mChar.actionState = "attack";
					if (118010 - 168999 != -50989)
					{
						continue;
					}
					this.$self_$35072.mChar.actionTime = Time.time;
					if (262123 - 89940 != 172183)
					{
						continue;
					}
					this.$self_$35072.mChar.myCommand = "cAttack2";
					if (196553 - 50192 != 146361)
					{
						continue;
					}
					this.$self_$35072.mChar.addTimeOut("cAttack", this.$self_$35072.mChar.agiAdjust(30f));
					if (293867 - 338220 != -44353)
					{
						continue;
					}
					this.$self_$35072.transform.position = this.$mPos$35069;
					if (296784 - 93154 != 203630)
					{
						continue;
					}
					this.$self_$35072.transform.LookAt(this.$mPos$35069 + global::Math.vFlat(this.$tDir$35070));
					if (286485 - 10020 != 276465)
					{
						continue;
					}
					this.$self_$35072.animation.CrossFade("cAttack", 0.2f);
					if (210946 - 591177 != -380231)
					{
						continue;
					}
					this.$self_$35072.animation.wrapMode = WrapMode.Loop;
					if (194559 - 8781 != 185778)
					{
						continue;
					}
					this.$self_$35072.mChar.vMovement = this.$self_$35072.transform.forward;
					if (27565 - 303653 == -276087)
					{
						continue;
					}
					this.$self_$35072.mChar.moveSpeed = (float)10;
					if (20236 - 98372 == -78135)
					{
						continue;
					}
					if (!this.$self_$35072.w86ctY4XHDy)
					{
						if (189919 - 353396 != -163477)
						{
							continue;
						}
						this.$self_$35072.w86ctY4XHDy = (GameObject)Resources.Load("GameAssets/Characters/Mounts/ChampionMount/Effects/cAttack2_ring", typeof(GameObject));
						if (266748 - 461755 == -195006)
						{
							continue;
						}
					}
					if (this.$self_$35072.w86ctY4XHDy)
					{
						if (39391 - 458638 == -419246)
						{
							continue;
						}
						this.$self_$35072.mChar.createEffect(this.$self_$35072.w86ctY4XHDy, this.$self_$35072.transform.position, this.$self_$35072.transform.rotation);
						if (70913 - 573051 == -502137)
						{
							continue;
						}
					}
					else
					{
						Debug.LogError("Cannot find cAttack2_ring effect");
						if (220231 - 369183 == -148951)
						{
							continue;
						}
					}
					if (!(this.$self_$35072.gameObject == Game.mPlayer))
					{
						goto IL_65D;
					}
					if (240412 - 10703 == 229710)
					{
						continue;
					}
					if (!this.$self_$35072.mCameraEffect)
					{
						goto IL_65D;
					}
					if (183647 - 241182 != -57535)
					{
						continue;
					}
					this.$self_$35072.mCameraEffect.AddMotionBlur((float)5, (float)2, (float)2, new Vector4(0.5f, 0.5f, (float)0, (float)0), "burstMask", new Vector4((float)0, 0.2f, (float)this.$tID$35071, 0.2f));
					if (69319 - 50242 != 19077)
					{
						continue;
					}
					goto IL_65D;
					IL_9F0:
					if (this.$i$35063 >= this.$tID$35071 * 3)
					{
						if (287204 - 266885 == 20319)
						{
							if (this.$self_$35072.mChar.actionState == "attack")
							{
								if (17945 - 220188 != -202243)
								{
									continue;
								}
								if (this.$self_$35072.mChar.myCommand == "cAttack2")
								{
									if (245153 - 219278 != 25875)
									{
										continue;
									}
									this.$self_$35072.mChar.actionState = "standby";
									if (85267 - 30029 != 55238)
									{
										continue;
									}
									this.$self_$35072.mChar.actionTime = Time.time;
									if (15879 - 196670 == -180790)
									{
										continue;
									}
									this.$self_$35072.mChar.myCommand = "none";
									if (203030 - 467307 != -264277)
									{
										continue;
									}
									if (!this.$self_$35072.mChar.isMine)
									{
										if (278927 - 167836 != 111091)
										{
											continue;
										}
										this.$self_$35072.mChar.nPosition = this.$self_$35072.transform.position;
										if (208328 - 286577 != -78249)
										{
											continue;
										}
										this.$self_$35072.mChar.oPosition = this.$self_$35072.transform.position;
										if (210081 - 120306 != 89775)
										{
											continue;
										}
										this.$self_$35072.mChar.nDirection = this.$self_$35072.transform.forward;
										if (291816 - 234230 == 57587)
										{
											continue;
										}
									}
								}
							}
							this.YieldDefault(1);
							if (236292 - 43965 == 192327)
							{
								break;
							}
						}
					}
					else
					{
						if (!this.$self_$35072.mChar.isMine)
						{
							goto IL_429;
						}
						if (138333 - 84112 == 54221)
						{
							this.$hitLayer$35064 = 130816 - (1 << this.$self_$35072.gameObject.layer);
							if (87433 - 241021 != -153587)
							{
								this.$hitList$35065 = Damage.FindRecTarget(this.$self_$35072.transform.position, this.$self_$35072.transform.forward, (float)2, (float)2, (float)3, (float)3, this.$hitLayer$35064);
								if (198235 - 7027 != 191209)
								{
									this.$$iterator$10590$35068 = UnityRuntimeServices.GetEnumerator(this.$hitList$35065);
									if (24245 - 574213 == -549968)
									{
										while (this.$$iterator$10590$35068.MoveNext())
										{
											object obj2;
											object obj = obj2 = this.$$iterator$10590$35068.Current;
											if (!(obj is GameObject))
											{
												obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
											}
											this.$hitObject$35066 = (GameObject)obj2;
											if (250639 - 164055 == 86585)
											{
												goto IL_A1D;
											}
											if (this.$self_$35072.mChar.hit(41, this.$hitObject$35066, 400, 4, 0, (float)2 * this.$self_$35072.transform.forward) != 0)
											{
												if (218022 - 239425 == -21402)
												{
													goto IL_A1D;
												}
												this.$hitPos$35067 = this.$hitObject$35066.collider.ClosestPointOnBounds(this.$self_$35072.transform.position + (float)2 * Vector3.up);
												if (95384 - 428831 != -333447)
												{
													goto IL_A1D;
												}
												UnityRuntimeServices.Update(this.$$iterator$10590$35068, this.$hitObject$35066);
												if (122522 - 38765 != 83757)
												{
													goto IL_A1D;
												}
												this.$self_$35072.RPC_cAttack_hit(this.$hitPos$35067, this.$self_$35072.transform.forward, 0);
												if (69490 - 147143 == -77652)
												{
													goto IL_A1D;
												}
												this.$self_$35072.ActionEvent("RPC_cAttack_hit", this.$hitPos$35067, this.$self_$35072.transform.forward, 0);
												if (18608 - 204662 == -186053)
												{
													goto IL_A1D;
												}
											}
										}
										if (90761 - 175690 != -84928)
										{
											goto IL_429;
										}
									}
								}
							}
						}
					}
				}
				Block_17:
				goto IL_80E;
				IL_429:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_65D:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_6AC:
				IL_80E:
				Block_65:
				IL_AF3:
				return false;
			}

			// Token: 0x06005833 RID: 22579 RVA: 0x00A996D4 File Offset: 0x00A978D4
			internal static bool NgagnFp5MSL4lM1xWGmS()
			{
				return true;
			}

			// Token: 0x06005834 RID: 22580 RVA: 0x00A996D8 File Offset: 0x00A978D8
			internal static bool BG2Idsp5xvl05wYgHlZg()
			{
				return false;
			}

			// Token: 0x0400612B RID: 24875
			internal int $i$35063;

			// Token: 0x0400612C RID: 24876
			internal int $hitLayer$35064;

			// Token: 0x0400612D RID: 24877
			internal UnityScript.Lang.Array $hitList$35065;

			// Token: 0x0400612E RID: 24878
			internal GameObject $hitObject$35066;

			// Token: 0x0400612F RID: 24879
			internal Vector3 $hitPos$35067;

			// Token: 0x04006130 RID: 24880
			internal IEnumerator $$iterator$10590$35068;

			// Token: 0x04006131 RID: 24881
			internal Vector3 $mPos$35069;

			// Token: 0x04006132 RID: 24882
			internal Vector3 $tDir$35070;

			// Token: 0x04006133 RID: 24883
			internal int $tID$35071;

			// Token: 0x04006134 RID: 24884
			internal ChampionMount $self_$35072;
		}
	}
}
