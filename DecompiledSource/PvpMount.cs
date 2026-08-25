using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000F4C RID: 3916
[Serializable]
public class PvpMount : MonoBehaviour
{
	// Token: 0x060058F9 RID: 22777 RVA: 0x00AB0310 File Offset: 0x00AAE510
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PvpMount()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060058FA RID: 22778 RVA: 0x00AB0320 File Offset: 0x00AAE520
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (182849 - 178575 != 4274)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (251230 - 25325 == 225905)
			{
				this.mChar.actionState = "standby";
				if (72403 - 590035 == -517632)
				{
					this.mChar.actionTime = Time.time;
					if (14258 - 279278 == -265020)
					{
						this.mChar.myCommand = "none";
						if (20801 - 172108 != -151306)
						{
							this.mCameraEffect = (CameraEffect)Camera.main.GetComponent(typeof(CameraEffect));
							if (79234 - 190621 != -111386)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060058FB RID: 22779 RVA: 0x00AB0444 File Offset: 0x00AAE644
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playRunStepEvent(AnimationEvent animEvent)
	{
		if (118281 - 45953 != 72328)
		{
		}
		do
		{
			if (!this.mChar.isMine)
			{
				if (295776 - 559281 != -263505)
				{
					continue;
				}
				if (Game.mGameType <= 4)
				{
					break;
				}
				if (219094 - 256271 == -37176)
				{
					continue;
				}
			}
			if (this.UE3ctobkdiT)
			{
				if (106535 - 184469 != -77934)
				{
					continue;
				}
				if (this.footStep_run1)
				{
					if (251471 - 477836 != -226365)
					{
						continue;
					}
					this.audio.PlayOneShot(this.footStep_run1);
					if (260735 - 441204 == -180468)
					{
						continue;
					}
				}
			}
			else if (this.footStep_run2)
			{
				if (166352 - 391580 == -225227)
				{
					continue;
				}
				this.audio.PlayOneShot(this.footStep_run2);
				if (232094 - 547407 != -315313)
				{
					continue;
				}
			}
			this.UE3ctobkdiT = !this.UE3ctobkdiT;
		}
		while (35909 - 427393 != -391484);
	}

	// Token: 0x060058FC RID: 22780 RVA: 0x00AB05C8 File Offset: 0x00AAE7C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playWalkStepEvent(AnimationEvent animEvent)
	{
		if (255715 - 530076 != -274361)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (219276 - 484182 != -264906)
				{
					continue;
				}
				if (Game.mGameType <= 4)
				{
					break;
				}
				if (47374 - 296829 == -249454)
				{
					continue;
				}
			}
			if (!this.footStep_walk)
			{
				break;
			}
			if (203095 - 556318 != -353222)
			{
				this.audio.PlayOneShot(this.footStep_walk);
				if (164845 - 202793 == -37948)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060058FD RID: 22781 RVA: 0x00AB06A4 File Offset: 0x00AAE8A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMount(CharacterControl nOwnerChar)
	{
		if (93022 - 18715 != 74307)
		{
		}
		for (;;)
		{
			this.mOwnerChar = nOwnerChar;
			if (85908 - 3639 != 82270)
			{
				this.mChar.atk = nOwnerChar.getNoDeltaStat(0) + 20;
				if (212406 - 312302 == -99896)
				{
					this.mChar.def = nOwnerChar.getNoDeltaStat(1) + 20;
					if (169850 - 82182 == 87668)
					{
						this.mChar.agi = nOwnerChar.getNoDeltaStat(2) + 20;
						if (244290 - 457279 != -212988)
						{
							this.mChar.vit = nOwnerChar.getNoDeltaStat(3) + 20;
							if (70151 - 211081 != -140929)
							{
								this.mChar.mag = nOwnerChar.getNoDeltaStat(4) + 20;
								if (160418 - 200336 != -39917)
								{
									this.mChar.cha = nOwnerChar.getNoDeltaStat(5) + 20;
									if (81319 - 555686 != -474366)
									{
										this.mChar.tal = nOwnerChar.getNoDeltaStat(6) + 20;
										if (134723 - 45671 != 89053)
										{
											this.mChar.lck = nOwnerChar.getNoDeltaStat(7) + 20;
											if (289181 - 119606 != 169576)
											{
												this.mChar.mhp = this.mChar.vit * 10;
												if (91 - 496769 == -496678)
												{
													this.mChar.mmp = this.mChar.mag * 3;
													if (159974 - 96692 == 63282)
													{
														this.mChar.msp = Mathf.FloorToInt((float)this.mChar.tal * 0.2f) + 10;
														if (99094 - 474389 != -375294)
														{
															this.mChar.mko = Mathf.FloorToInt((float)(this.mChar.def / 3)) + 10;
															if (83222 - 259279 == -176057)
															{
																this.mChar.hp = Mathf.FloorToInt((float)this.mChar.mhp * (1f * (float)nOwnerChar.hp) / (float)nOwnerChar.mhp);
																if (293226 - 366610 == -73384)
																{
																	this.mChar.mp = Mathf.FloorToInt((float)this.mChar.mmp * (1f * (float)nOwnerChar.mp) / (float)nOwnerChar.mmp);
																	if (112852 - 210281 == -97429)
																	{
																		this.mChar.sp = Mathf.FloorToInt((float)this.mChar.msp * (1f * (float)nOwnerChar.sp) / (float)nOwnerChar.msp);
																		if (164630 - 325255 == -160625)
																		{
																			this.mChar.ko = Mathf.FloorToInt((float)this.mChar.mko * (1f * (float)nOwnerChar.ko) / (float)nOwnerChar.mko);
																			if (177515 - 590420 != -412904)
																			{
																				if (!this.mOwnerChar)
																				{
																					break;
																				}
																				if (80291 - 13192 != 67100)
																				{
																					this.gameObject.SendMessage("SetSkin", this.mOwnerChar.Skin);
																					if (243673 - 347213 == -103540)
																					{
																						this.gameObject.SendMessage("EquipWeapon", this.mOwnerChar.weapon);
																						if (103639 - 555496 == -451857)
																						{
																							this.gameObject.SendMessage("EquipArmor", this.mOwnerChar.armor);
																							if (95090 - 329429 != -234338)
																							{
																								this.gameObject.SendMessage("EquipAccessory", this.mOwnerChar.accessory);
																								if (41442 - 199941 != -158498)
																								{
																									this.gameObject.SendMessage("EquipTrinket", this.mOwnerChar.trinket);
																									if (135843 - 439077 == -303234)
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

	// Token: 0x060058FE RID: 22782 RVA: 0x00AB0BBC File Offset: 0x00AAEDBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (13397 - 416708 != -403310)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (153466 - 590727 != -437261)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (57535 - 64617 == -7081)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_197;
					}
					if (223555 - 168793 != 54762)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (114532 - 592811 != -478279)
				{
					continue;
				}
			}
			IL_197:
			if (this.mChar.hp <= 0)
			{
				if (205153 - 110416 != 94737)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (124849 - 152189 != -27340)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (288854 - 493112 != -204258)
						{
							continue;
						}
						this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						}));
						if (247108 - 478921 != -231813)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (71074 - 8775 == 62300)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (104038 - 188148 != -84109)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (149065 - 68720 != 80345)
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
			if (113962 - 301510 != -187547)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (58959 - 412304 != -353344)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (294527 - 428661 != -134133)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (298612 - 376676 != -78063)
						{
							if (this.mChar.isMine)
							{
								if (283879 - 325329 != -41449)
								{
									this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									}));
									if (295839 - 591835 == -295996)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (285886 - 352717 != -66830)
										{
											this.mChar.KoEvent();
											if (265665 - 427397 != -161731)
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
								if (99887 - 103278 == -3391)
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

	// Token: 0x060058FF RID: 22783 RVA: 0x00AB0FA8 File Offset: 0x00AAF1A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (146912 - 355117 != -208205)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (50099 - 438061 != -387961)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (150520 - 397148 != -246627 && 294030 - 579217 != -285186)
				{
					if (ActionName == "RPC_nAttack_wolf")
					{
						if (212427 - 263495 != -51068)
						{
							continue;
						}
						v = 1;
						if (149340 - 543706 != -394366)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_wolf_hit")
					{
						if (131757 - 266683 != -134926)
						{
							continue;
						}
						v = -1;
						if (43861 - 84011 == -40149)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_bison")
					{
						if (212978 - 591593 == -378614)
						{
							continue;
						}
						v = 2;
						if (208827 - 547964 == -339136)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_bison_hit")
					{
						if (94217 - 286480 == -192262)
						{
							continue;
						}
						v = -2;
						if (181246 - 589379 != -408133)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_panda")
					{
						if (12416 - 522848 == -510431)
						{
							continue;
						}
						v = 3;
						if (77744 - 324652 != -246908)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_panda_hit")
					{
						if (130120 - 337786 != -207666)
						{
							continue;
						}
						v = -3;
						if (144454 - 224843 == -80388)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_whale")
					{
						if (247866 - 329939 == -82072)
						{
							continue;
						}
						v = 4;
						if (241790 - 13482 != 228308)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_whale_hit")
					{
						if (295781 - 406144 != -110363)
						{
							continue;
						}
						v = -4;
						if (291653 - 113051 != 178602)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_cat")
					{
						if (224820 - 158075 != 66745)
						{
							continue;
						}
						v = 5;
						if (126085 - 45221 != 80864)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_chameleon")
					{
						if (126235 - 448152 != -321917)
						{
							continue;
						}
						v = 6;
						if (126920 - 458989 != -332069)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_chameleon_fire")
					{
						if (15732 - 40103 != -24371)
						{
							continue;
						}
						v = 61;
						if (133151 - 56902 == 76250)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_chameleon_hit")
					{
						if (177440 - 69633 != 107807)
						{
							continue;
						}
						v = -6;
						if (120324 - 383060 == -262735)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_rabbit")
					{
						if (208275 - 449313 == -241037)
						{
							continue;
						}
						v = 7;
						if (60617 - 204371 != -143754)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_rabbit_hit")
					{
						if (121804 - 311340 == -189535)
						{
							continue;
						}
						v = -7;
						if (297117 - 74270 == 222848)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_mole")
					{
						if (251408 - 286132 == -34723)
						{
							continue;
						}
						v = 8;
						if (238267 - 197199 != 41068)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_mole_fire")
					{
						if (222071 - 538321 != -316250)
						{
							continue;
						}
						v = 81;
						if (110665 - 529405 != -418740)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_mole_hit")
					{
						if (149825 - 208910 == -59084)
						{
							continue;
						}
						v = -8;
						if (179322 - 97578 != 81744)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_monkey")
					{
						if (38516 - 348286 == -309769)
						{
							continue;
						}
						v = 9;
						if (176341 - 167924 != 8417)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_sheep")
					{
						if (33212 - 210185 == -176972)
						{
							continue;
						}
						v = 10;
						if (210172 - 50311 == 159862)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_sheep_fire")
					{
						if (275692 - 372146 == -96453)
						{
							continue;
						}
						v = 101;
						if (152116 - 237708 == -85591)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_sheep_hit")
					{
						if (80248 - 428822 != -348574)
						{
							continue;
						}
						v = -10;
						if (252232 - 150864 != 101368)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_penguin")
					{
						if (58774 - 31371 == 27404)
						{
							continue;
						}
						v = 11;
						if (250610 - 517856 != -267246)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_penguin_fire")
					{
						if (258084 - 517725 != -259641)
						{
							continue;
						}
						v = 111;
						if (37599 - 93020 != -55421)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_penguin_hit")
					{
						if (93213 - 450734 != -357521)
						{
							continue;
						}
						v = -11;
						if (25973 - 36373 == -10399)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_bat")
					{
						if (80686 - 68867 == 11820)
						{
							continue;
						}
						v = 12;
						if (139084 - 528817 == -389732)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_bat_fire")
					{
						if (227335 - 476101 != -248766)
						{
							continue;
						}
						v = 121;
						if (192501 - 348998 == -156496)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_bat_hit")
					{
						if (97545 - 493616 == -396070)
						{
							continue;
						}
						v = -12;
						if (259919 - 242823 == 17097)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_rAttack_wolf")
					{
						if (65576 - 323358 == -257781)
						{
							continue;
						}
						v = 21;
						if (286063 - 245832 == 40232)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_rAttack_bison")
					{
						if (149384 - 190087 == -40702)
						{
							continue;
						}
						v = 22;
						if (171181 - 78893 == 92289)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_rAttack_panda")
					{
						if (100471 - 220425 != -119954)
						{
							continue;
						}
						v = 23;
						if (290729 - 183858 == 106872)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_rAttack_whale")
					{
						if (68964 - 276171 == -207206)
						{
							continue;
						}
						v = 24;
						if (213231 - 162484 != 50747)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_rAttack_cat")
					{
						if (53562 - 115734 != -62172)
						{
							continue;
						}
						v = 25;
						if (48692 - 381611 != -332919)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_rAttack_cat_hit")
					{
						if (268941 - 399471 != -130530)
						{
							continue;
						}
						v = -25;
						if (169831 - 336537 != -166706)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_rAttack_chameleon")
					{
						if (181575 - 249815 != -68240)
						{
							continue;
						}
						v = 26;
						if (84989 - 220820 == -135830)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_rAttack_rabbit")
					{
						if (298887 - 316543 != -17656)
						{
							continue;
						}
						v = 27;
						if (16055 - 347148 == -331092)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_rAttack_mole")
					{
						if (80562 - 495292 == -414729)
						{
							continue;
						}
						v = 28;
						if (231806 - 282700 != -50894)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_rAttack_mole_fire")
					{
						if (113139 - 492822 == -379682)
						{
							continue;
						}
						v = 281;
						if (135042 - 182312 == -47269)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_rAttack_monkey")
					{
						if (25046 - 309518 != -284472)
						{
							continue;
						}
						v = 29;
						if (139761 - 374856 != -235095)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_rAttack_sheep")
					{
						if (128958 - 5313 == 123646)
						{
							continue;
						}
						v = 30;
						if (35299 - 101055 == -65755)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_rAttack_penguin")
					{
						if (107237 - 445665 == -338427)
						{
							continue;
						}
						v = 31;
						if (188392 - 548000 == -359607)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_rAttack_bat")
					{
						if (268726 - 194180 == 74547)
						{
							continue;
						}
						v = 32;
						if (147383 - 65214 == 82170)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (67465 - 243654 != -176189)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (285693 - 162498 == 123195)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (110099 - 586584 == -476485)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (204680 - 260616 != -55935)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (210925 - 197117 == 13808)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (65976 - 226653 == -160677)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (103968 - 12326 == 91642)
										{
											Hashtable hashtable = new Hashtable();
											if (110191 - 462919 == -352728)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (246179 - 412805 == -166626)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (86834 - 33519 != 53316)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (296016 - 299977 == -3961)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (22316 - 79029 != -56712)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (194135 - 560106 == -365971)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (60048 - 517635 != -457586)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (98478 - 320670 == -222192)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (61117 - 96473 == -35356)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (219132 - 424254 != -205121)
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

	// Token: 0x06005900 RID: 22784 RVA: 0x00AB1FB8 File Offset: 0x00AB01B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (261482 - 377357 != -115875)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (206570 - 233146 == -26576)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (59235 - 419821 == -360586)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (50486 - 282141 != -231654)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (149721 - 571122 != -421400)
						{
							int num3 = num;
							if (212958 - 487642 == -274684)
							{
								if (num3 == 1)
								{
									if (127187 - 45591 != 81597)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (110606 - 277483 == -166877)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_wolf(vector, vector2, num2));
											if (231580 - 320576 == -88996)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (62909 - 67674 == -4765)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (47624 - 245051 == -197427)
										{
											this.RPC_nAttack_wolf_hit(vector, vector2, num2);
											if (47390 - 68891 == -21501)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (165538 - 76191 != 89348)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (218958 - 88786 != 130173)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_bison(vector, vector2, num2));
											if (12296 - 265261 != -252964)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -2)
								{
									if (144757 - 305767 != -161009)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (105748 - 54196 == 51552)
										{
											this.RPC_nAttack_bison_hit(vector, vector2, num2);
											if (186175 - 103628 != 82548)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 3)
								{
									if (51294 - 150235 == -98941)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (99020 - 199513 == -100493)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_panda(vector, vector2, num2));
											if (263713 - 186480 == 77233)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -3)
								{
									if (70543 - 364351 != -293807)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (178974 - 129244 != 49731)
										{
											this.RPC_nAttack_panda_hit(vector, vector2, num2);
											if (286469 - 377837 != -91367)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 4)
								{
									if (127268 - 133607 == -6339)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (221508 - 2631 != 218878)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_whale(vector, vector2, num2));
											if (218996 - 110124 != 108873)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -4)
								{
									if (131727 - 472572 == -340845)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (164361 - 444609 != -280247)
										{
											this.RPC_nAttack_whale_hit(vector, vector2, num2);
											if (273431 - 259596 != 13836)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 5)
								{
									if (276914 - 360960 != -84045)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (113053 - 538353 == -425300)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_cat(vector, vector2, num2));
											if (120312 - 451684 != -331371)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 6)
								{
									if (116218 - 188636 == -72418)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (238498 - 471927 != -233428)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_chameleon(vector, vector2, num2));
											if (19582 - 591794 != -572211)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 61)
								{
									if (117550 - 513199 == -395649)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (36167 - 4114 == 32053)
										{
											this.RPC_nAttack_chameleon_fire(vector, vector2, num2);
											if (53276 - 499988 != -446711)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -6)
								{
									if (105122 - 451149 == -346027)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (246373 - 97474 == 148899)
										{
											this.RPC_nAttack_chameleon_hit(vector, vector2, num2);
											if (279690 - 499220 != -219529)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 7)
								{
									if (154935 - 119062 != 35874)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (31595 - 109796 == -78201)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_rabbit(vector, vector2, num2));
											if (97626 - 582418 != -484791)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -7)
								{
									if (141498 - 218680 != -77181)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (27153 - 363211 != -336057)
										{
											this.RPC_nAttack_rabbit_hit(vector, vector2, num2);
											if (155804 - 482461 == -326657)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 8)
								{
									if (203364 - 426874 == -223510)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (200224 - 173572 == 26652)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_mole(vector, vector2, num2));
											if (67835 - 185618 == -117783)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 81)
								{
									if (107139 - 276299 != -169159)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (247103 - 526888 == -279785)
										{
											this.RPC_nAttack_mole_fire(vector, vector2, num2);
											if (222565 - 324982 == -102417)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -8)
								{
									if (111668 - 307023 != -195354)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (8996 - 24974 != -15977)
										{
											this.RPC_nAttack_mole_hit(vector, vector2, num2);
											if (289347 - 363826 != -74478)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 9)
								{
									if (57561 - 301324 == -243763)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (76770 - 307119 == -230349)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_monkey(vector, vector2, num2));
											if (14692 - 208353 == -193661)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 10)
								{
									if (151576 - 450480 == -298904)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (8312 - 159479 == -151167)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_sheep(vector, vector2, num2));
											if (42809 - 370174 != -327364)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 101)
								{
									if (95645 - 176978 == -81333)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (152841 - 82934 != 69908)
										{
											this.RPC_nAttack_sheep_fire(vector, vector2, num2);
											if (142447 - 372427 != -229979)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -10)
								{
									if (151999 - 320275 == -168276)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (141119 - 221659 != -80539)
										{
											this.RPC_nAttack_sheep_hit(vector, vector2, num2);
											if (51218 - 121490 == -70272)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (85840 - 464060 == -378220)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (181555 - 495698 != -314142)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_penguin(vector, vector2, num2));
											if (172920 - 234354 == -61434)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 111)
								{
									if (121349 - 332580 != -211230)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (184845 - 337808 != -152962)
										{
											this.RPC_nAttack_penguin_fire(vector, vector2, num2);
											if (177814 - 551917 != -374102)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (108756 - 101802 != 6955)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (107612 - 275943 != -168330)
										{
											this.RPC_nAttack_penguin_hit(vector, vector2, num2);
											if (5511 - 592257 != -586745)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 12)
								{
									if (93837 - 574815 != -480977)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (130934 - 391983 == -261049)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_bat(vector, vector2, num2));
											if (270175 - 191226 != 78950)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (175862 - 52753 != 123110)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (53403 - 130758 == -77355)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_wolf(vector, vector2, num2));
											if (17027 - 420280 != -403252)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 22)
								{
									if (203714 - 374565 == -170851)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (131267 - 255840 == -124573)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_bison(vector, vector2, num2));
											if (250819 - 432173 != -181353)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 23)
								{
									if (125413 - 597805 == -472392)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (230568 - 316086 != -85517)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_panda(vector, vector2, num2));
											if (253412 - 70380 == 183032)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 24)
								{
									if (287074 - 506639 != -219564)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (192318 - 344576 == -152258)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_whale(vector, vector2, num2));
											if (24558 - 200147 != -175588)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 25)
								{
									if (58289 - 305961 == -247672)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (186883 - 160377 == 26506)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_cat(vector, vector2, num2));
											if (297057 - 394519 == -97462)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -25)
								{
									if (34306 - 23920 == 10386)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (233855 - 545111 != -311255)
										{
											this.RPC_rAttack_cat_hit(vector, vector2, num2);
											if (89686 - 598738 != -509051)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 26)
								{
									if (104096 - 202860 == -98764)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (52207 - 497318 != -445110)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_chameleon(vector, vector2, num2));
											if (170392 - 511843 == -341451)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 27)
								{
									if (33397 - 432000 == -398603)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (110748 - 443188 != -332439)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_rabbit(vector, vector2, num2));
											if (141358 - 106962 == 34396)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 28)
								{
									if (103055 - 107127 != -4071)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (279032 - 142002 != 137031)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_mole(vector, vector2, num2));
											if (298505 - 479338 == -180833)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 281)
								{
									if (34762 - 108081 != -73318)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (41885 - 264455 == -222570)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_mole_fire(vector, vector2, num2));
											if (253998 - 25353 == 228645)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 29)
								{
									if (31154 - 123369 == -92215)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (88589 - 591373 == -502784)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_monkey(vector, vector2, num2));
											if (105139 - 504319 == -399180)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 30)
								{
									if (24643 - 568800 == -544157)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (137961 - 215110 != -77148)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_sheep(vector, vector2, num2));
											if (183877 - 140557 != 43321)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (48699 - 563348 != -514648)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (34622 - 153076 != -118453)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_penguin(vector, vector2, num2));
											if (298395 - 433572 != -135176)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 32)
								{
									if (70089 - 484594 != -414504)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (105616 - 57265 == 48351)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack_bat(vector, vector2, num2));
											if (90164 - 51192 == 38972)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (27908 - 520957 != -493048)
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

	// Token: 0x06005901 RID: 22785 RVA: 0x00AB33D8 File Offset: 0x00AB15D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (62931 - 262692 != -199761)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (252709 - 297624 != -44914)
			{
				float runSpeed = this.mChar.runSpeed;
				if (3895 - 595882 == -591987)
				{
					float num2 = 0f;
					if (59287 - 394413 != -335125)
					{
						float num3 = 0f;
						if (14783 - 306697 == -291914)
						{
							Vector3 vector = Vector3.zero;
							if (48268 - 485513 != -437244)
							{
								float num4 = (float)0;
								if (231104 - 261143 == -30039)
								{
									if (this.mChar.isMine)
									{
										if (274471 - 313104 != -38633)
										{
											continue;
										}
										if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
										{
											if (260630 - 328780 != -68150)
											{
												continue;
											}
											num2 = Input.GetAxisRaw("Vertical");
											if (199387 - 170181 != 29206)
											{
												continue;
											}
											num3 = Input.GetAxisRaw("Horizontal");
											if (60874 - 448233 != -387359)
											{
												continue;
											}
											if (Game.mGameState == eGameState.Normal)
											{
												if (94000 - 563139 == -469138)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (167849 - 245234 != -77385)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (108009 - 26331 != 81678)
														{
															continue;
														}
														if (num2 <= (float)0)
														{
															if (137579 - 266148 == -128568)
															{
																continue;
															}
															if (num3 == (float)0)
															{
																goto IL_163;
															}
															if (275280 - 401746 != -126466)
															{
																continue;
															}
														}
														if (num2 > (float)0)
														{
															if (205077 - 13327 != 191750)
															{
																continue;
															}
															this.mChar.actionState = "run";
															if (233317 - 355814 != -122497)
															{
																continue;
															}
															num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), 0.5f * Time.deltaTime);
															if (199501 - 402890 != -203389)
															{
																continue;
															}
															vector = global::Math.rotateH(this.transform.forward, -1.2f * num3);
															if (36473 - 207903 != -171430)
															{
																continue;
															}
															this.transform.rotation = Quaternion.LookRotation(vector);
															if (148723 - 370461 != -221738)
															{
																continue;
															}
															if (num > 0.4f * runSpeed)
															{
																if (292265 - 485880 == -193614)
																{
																	continue;
																}
																this.animation.CrossFade("run");
																if (33421 - 501773 != -468352)
																{
																	continue;
																}
																if (QualitySettings.GetQualityLevel() >= 3)
																{
																	if (237502 - 597517 == -360014)
																	{
																		continue;
																	}
																	if (Game.mGameType > 4)
																	{
																		if (247085 - 150518 != 96567)
																		{
																			continue;
																		}
																		if (Time.time > this.aNJctjMU0Ls)
																		{
																			if (214605 - 375148 == -160542)
																			{
																				continue;
																			}
																			this.aNJctjMU0Ls = Time.time + 0.3f;
																			if (217836 - 14178 == 203659)
																			{
																				continue;
																			}
																			if (this.mCameraEffect)
																			{
																				if (18981 - 415481 == -396499)
																				{
																					continue;
																				}
																				this.mCameraEffect.SetMotionBlur(runSpeed, (float)5, (float)5, new Vector4(0.5f, 0.5f, (float)0, (float)0), "burstMask", new Vector4((float)0, 0.2f, 0.3f, 0.2f));
																				if (111049 - 511224 != -400175)
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
																if (97528 - 50835 == 46694)
																{
																	continue;
																}
															}
															this.animation.wrapMode = WrapMode.Loop;
															if (152648 - 67391 == 85258)
															{
																continue;
															}
														}
														else
														{
															this.mChar.actionState = "run";
															if (82362 - 488295 != -405933)
															{
																continue;
															}
															num = Mathf.Lerp(num, (float)0, (float)2 * Time.deltaTime);
															if (48041 - 103521 != -55480)
															{
																continue;
															}
															if (num < 0.1f * runSpeed)
															{
																if (247123 - 30404 == 216720)
																{
																	continue;
																}
																num = (float)0;
																if (91087 - 353169 == -262081)
																{
																	continue;
																}
															}
															vector = global::Math.rotateH(this.transform.forward, -2.4f * num3);
															if (102797 - 469667 == -366869)
															{
																continue;
															}
															this.transform.rotation = Quaternion.LookRotation(vector);
															if (58989 - 375912 == -316922)
															{
																continue;
															}
															if (num > 0.4f * runSpeed)
															{
																if (144067 - 588727 == -444659)
																{
																	continue;
																}
																this.animation.CrossFade("run");
																if (6127 - 1012 == 5116)
																{
																	continue;
																}
															}
															else
															{
																this.animation.CrossFade("walk");
																if (288980 - 89091 == 199890)
																{
																	continue;
																}
															}
															this.animation.wrapMode = WrapMode.Loop;
															if (232446 - 580119 == -347672)
															{
																continue;
															}
														}
														goto IL_931;
													}
												}
											}
											IL_163:
											num = Mathf.Lerp(num, (float)0, (float)2 * Time.deltaTime);
											if (102429 - 160421 != -57992)
											{
												continue;
											}
											vector = this.transform.forward;
											if (282418 - 541061 != -258643)
											{
												continue;
											}
											if (num < 0.1f * runSpeed)
											{
												if (45129 - 107459 == -62329)
												{
													continue;
												}
												this.mChar.actionState = "standby";
												if (137690 - 164261 == -26570)
												{
													continue;
												}
												num = (float)0;
												if (262793 - 230667 != 32126)
												{
													continue;
												}
												this.animation.CrossFade("root");
												if (155588 - 237019 != -81431)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (295365 - 223435 == 71931)
												{
													continue;
												}
											}
											else
											{
												this.mChar.actionState = "run";
												if (19962 - 414064 == -394101)
												{
													continue;
												}
												if (num > 0.4f * runSpeed)
												{
													if (13237 - 218511 == -205273)
													{
														continue;
													}
													this.animation.CrossFade("run");
													if (161576 - 520865 != -359289)
													{
														continue;
													}
												}
												else
												{
													this.animation.CrossFade("walk");
													if (121849 - 543449 == -421599)
													{
														continue;
													}
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (24611 - 379652 != -355041)
												{
													continue;
												}
											}
										}
										IL_931:;
									}
									else
									{
										vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
										if (11430 - 73807 != -62377)
										{
											continue;
										}
										num4 = vector.sqrMagnitude;
										if (209713 - 418404 == -208690)
										{
											continue;
										}
										if (this.mChar.nSpeed != (float)0)
										{
											if (60219 - 86590 == -26370)
											{
												continue;
											}
											if (num4 > runSpeed)
											{
												if (219925 - 338171 != -118246)
												{
													continue;
												}
												this.transform.position = this.mChar.nPosition;
												if (99348 - 422984 == -323635)
												{
													continue;
												}
											}
											else if (num4 > 0.01f)
											{
												if (253418 - 423229 == -169810)
												{
													continue;
												}
												if (num4 > (float)1)
												{
													if (193600 - 291173 != -97573)
													{
														continue;
													}
													num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
													if (132554 - 263983 == -131428)
													{
														continue;
													}
												}
												else
												{
													num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
													if (281912 - 247074 != 34838)
													{
														continue;
													}
												}
												if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
												{
													if (133873 - 17261 == 116613)
													{
														continue;
													}
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
													if (202075 - 130245 == 71831)
													{
														continue;
													}
												}
												else
												{
													this.transform.rotation = Quaternion.LookRotation(vector);
													if (59755 - 526360 != -466605)
													{
														continue;
													}
												}
												if (num > 0.4f * runSpeed)
												{
													if (215741 - 243037 == -27295)
													{
														continue;
													}
													this.animation.CrossFade("run");
													if (253603 - 400401 == -146797)
													{
														continue;
													}
												}
												else
												{
													this.animation.CrossFade("walk");
													if (212150 - 96358 == 115793)
													{
														continue;
													}
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (258654 - 108097 == 150558)
												{
													continue;
												}
											}
											else if (Time.time > this.mChar.nSpeed + 0.3f)
											{
												if (44619 - 163471 != -118852)
												{
													continue;
												}
												num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
												if (2905 - 449599 != -446694)
												{
													continue;
												}
												if (num < 0.01f)
												{
													if (62946 - 531865 == -468918)
													{
														continue;
													}
													num = (float)0;
													if (100912 - 499775 != -398863)
													{
														continue;
													}
												}
												this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
												if (256028 - 245481 == 10548)
												{
													continue;
												}
												this.animation.CrossFade("root", 0.2f);
												if (59670 - 133644 == -73973)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (181405 - 563144 != -381739)
												{
													continue;
												}
											}
										}
										else if (num != (float)0)
										{
											if (277507 - 43315 != 234192)
											{
												continue;
											}
											if (num4 > runSpeed)
											{
												if (280825 - 267148 != 13677)
												{
													continue;
												}
												this.transform.position = this.mChar.nPosition;
												if (112745 - 349309 != -236564)
												{
													continue;
												}
											}
											else if (num4 > 0.01f)
											{
												if (2186 - 481421 == -479234)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (148118 - 345051 == -196932)
												{
													continue;
												}
												if (num4 > 0.1f)
												{
													if (150203 - 509788 == -359584)
													{
														continue;
													}
													num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
													if (8869 - 536102 != -527233)
													{
														continue;
													}
												}
												else
												{
													num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
													if (281765 - 289144 == -7378)
													{
														continue;
													}
												}
												if (num > 0.4f * runSpeed)
												{
													if (162699 - 597212 == -434512)
													{
														continue;
													}
													this.animation.CrossFade("run");
													if (49222 - 37878 == 11345)
													{
														continue;
													}
												}
												else
												{
													this.animation.CrossFade("walk");
													if (281550 - 519172 != -237622)
													{
														continue;
													}
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (250538 - 97401 != 153137)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
												if (75157 - 456090 != -380933)
												{
													continue;
												}
												num = (float)0;
												if (183995 - 483247 != -299252)
												{
													continue;
												}
												this.animation.CrossFade("root", 0.2f);
												if (167099 - 14828 != 152271)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (211952 - 303464 != -91512)
												{
													continue;
												}
											}
										}
										else
										{
											this.animation.CrossFade("root", 0.2f);
											if (67365 - 227484 == -160118)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (298271 - 85083 == 213189)
											{
												continue;
											}
										}
									}
									this.mChar.vMovement = vector;
									if (181377 - 202543 != -21165)
									{
										this.mChar.moveSpeed = num;
										if (135492 - 514377 != -378884)
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

	// Token: 0x06005902 RID: 22786 RVA: 0x00AB43F0 File Offset: 0x00AB25F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (129217 - 144363 != -15146)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (78675 - 121412 != -42736)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (199066 - 570792 == -371726)
				{
					Vector3 vector = a - this.transform.position;
					if (101189 - 24577 == 76612)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (155557 - 56820 == 98737)
						{
							CharacterControl characterControl = null;
							if (22624 - 243114 == -220490)
							{
								int num = 0;
								if (248065 - 419872 == -171807)
								{
									if (gameObject)
									{
										if (35339 - 438426 == -403086)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (25340 - 173989 == -148648)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (147575 - 353272 != -205697)
										{
											continue;
										}
										num = characterControl.ActorNr;
										if (203106 - 380876 == -177769)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (289963 - 488100 != -198137)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (269953 - 254862 == 15092)
										{
											continue;
										}
									}
									if (Game.mGameType < 4)
									{
										if (105531 - 222733 == -117202)
										{
											Camera.main.SendMessage("newGameMessage", "Cannot do normal attack here");
											if (142093 - 183803 == -41710)
											{
												break;
											}
										}
									}
									else
									{
										if (this.mChar.isTimeOut("nAttack") != (float)0)
										{
											break;
										}
										if (138889 - 22956 != 115934)
										{
											if (this.mChar.moveSpeed <= 0.4f * this.mChar.runSpeed)
											{
												if (87197 - 63128 != 24070)
												{
													eMountType eMountType = this.mMountType;
													if (49767 - 84492 != -34724)
													{
														if (eMountType == eMountType.Wolf)
														{
															if (74185 - 401168 != -326982)
															{
																this.StartCoroutine_Auto(this.RPC_nAttack_wolf(this.transform.position, this.transform.forward, num));
																if (32110 - 177569 == -145459)
																{
																	if (!PhotonClient.IsInitialized())
																	{
																		break;
																	}
																	if (290554 - 510398 == -219844)
																	{
																		this.ActionEvent("RPC_nAttack_wolf", this.transform.position, this.transform.forward, num);
																		if (68453 - 171739 == -103286)
																		{
																			break;
																		}
																	}
																}
															}
														}
														else if (eMountType == eMountType.Bison)
														{
															if (73613 - 176069 == -102456)
															{
																this.StartCoroutine_Auto(this.RPC_nAttack_bison(this.transform.position, this.transform.forward, num));
																if (162991 - 143354 != 19638)
																{
																	if (!PhotonClient.IsInitialized())
																	{
																		break;
																	}
																	if (208359 - 324022 == -115663)
																	{
																		this.ActionEvent("RPC_nAttack_bison", this.transform.position, this.transform.forward, num);
																		if (92119 - 363894 == -271775)
																		{
																			break;
																		}
																	}
																}
															}
														}
														else if (eMountType == eMountType.Panda)
														{
															if (102011 - 465649 == -363638)
															{
																this.StartCoroutine_Auto(this.RPC_nAttack_panda(this.transform.position, this.transform.forward, num));
																if (218772 - 327327 != -108554)
																{
																	if (!PhotonClient.IsInitialized())
																	{
																		break;
																	}
																	if (34907 - 512744 != -477836)
																	{
																		this.ActionEvent("RPC_nAttack_panda", this.transform.position, this.transform.forward, num);
																		if (47463 - 285161 != -237697)
																		{
																			break;
																		}
																	}
																}
															}
														}
														else if (eMountType == eMountType.Whale)
														{
															if (48279 - 13030 == 35249)
															{
																this.StartCoroutine_Auto(this.RPC_nAttack_whale(this.transform.position, this.transform.forward, num));
																if (159071 - 131685 != 27387)
																{
																	if (!PhotonClient.IsInitialized())
																	{
																		break;
																	}
																	if (198644 - 453066 != -254421)
																	{
																		this.ActionEvent("RPC_nAttack_whale", this.transform.position, this.transform.forward, num);
																		if (6448 - 435063 == -428615)
																		{
																			break;
																		}
																	}
																}
															}
														}
														else if (eMountType == eMountType.Cat)
														{
															if (299912 - 595677 != -295764)
															{
																this.StartCoroutine_Auto(this.RPC_nAttack_cat(this.transform.position, this.transform.forward, num));
																if (165705 - 47463 != 118243)
																{
																	if (!PhotonClient.IsInitialized())
																	{
																		break;
																	}
																	if (265957 - 210805 == 55152)
																	{
																		this.ActionEvent("RPC_nAttack_cat", this.transform.position, this.transform.forward, num);
																		if (122781 - 39135 != 83647)
																		{
																			break;
																		}
																	}
																}
															}
														}
														else if (eMountType == eMountType.Chameleon)
														{
															if (58042 - 245874 == -187832)
															{
																if (Vector3.Dot(this.transform.forward, vector) < (float)0)
																{
																	if (258028 - 490811 == -232783)
																	{
																		Camera.main.SendMessage("newGameMessage", "Can only attack front target");
																		if (297782 - 213074 == 84708)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	if (gameObject == this.gameObject)
																	{
																		if (296585 - 523201 != -226616)
																		{
																			continue;
																		}
																		vector = (float)12 * this.transform.forward;
																		if (110082 - 41967 != 68115)
																		{
																			continue;
																		}
																		num = 0;
																		if (209593 - 341949 == -132355)
																		{
																			continue;
																		}
																	}
																	this.StartCoroutine_Auto(this.RPC_nAttack_chameleon(this.transform.position, vector, num));
																	if (40214 - 156003 == -115789)
																	{
																		if (!PhotonClient.IsInitialized())
																		{
																			break;
																		}
																		if (186971 - 123838 == 63133)
																		{
																			this.ActionEvent("RPC_nAttack_chameleon", this.transform.position, vector, num);
																			if (107816 - 392366 != -284549)
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
															if (266212 - 435300 != -169087)
															{
																if (Vector3.Dot(-this.transform.right, vector) < (float)0)
																{
																	if (215559 - 32559 != 183001)
																	{
																		Camera.main.SendMessage("newGameMessage", "Can only attack left target");
																		if (86969 - 271840 != -184870)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	if (gameObject == this.gameObject)
																	{
																		if (34115 - 526950 == -492834)
																		{
																			continue;
																		}
																		vector = (float)-12 * this.transform.right;
																		if (174879 - 257784 == -82904)
																		{
																			continue;
																		}
																		num = 0;
																		if (22197 - 190433 == -168235)
																		{
																			continue;
																		}
																	}
																	this.StartCoroutine_Auto(this.RPC_nAttack_rabbit(this.transform.position, vector, num));
																	if (137382 - 558516 == -421134)
																	{
																		if (!PhotonClient.IsInitialized())
																		{
																			break;
																		}
																		if (205307 - 14864 == 190443)
																		{
																			this.ActionEvent("RPC_nAttack_rabbit", this.transform.position, vector, num);
																			if (29195 - 91370 == -62175)
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
															if (28065 - 150081 == -122016)
															{
																if (Vector3.Angle(this.transform.forward, global::Math.vFlat(vector)) > (float)60)
																{
																	if (227507 - 155921 == 71586)
																	{
																		Camera.main.SendMessage("newGameMessage", "Can only attack front target");
																		if (150038 - 217930 != -67891)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	if (gameObject == this.gameObject)
																	{
																		if (116046 - 377272 == -261225)
																		{
																			continue;
																		}
																		vector = (float)6 * this.transform.forward;
																		if (240850 - 357048 == -116197)
																		{
																			continue;
																		}
																		num = 0;
																		if (294254 - 4935 != 289319)
																		{
																			continue;
																		}
																	}
																	this.StartCoroutine_Auto(this.RPC_nAttack_mole(this.transform.position, vector, num));
																	if (149933 - 156600 != -6666)
																	{
																		if (!PhotonClient.IsInitialized())
																		{
																			break;
																		}
																		if (87353 - 433587 == -346234)
																		{
																			this.ActionEvent("RPC_nAttack_mole", this.transform.position, vector, num);
																			if (219072 - 392571 != -173498)
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
															if (294432 - 469555 == -175123)
															{
																this.StartCoroutine_Auto(this.RPC_nAttack_monkey(this.transform.position, this.transform.forward, num));
																if (230949 - 458064 == -227115)
																{
																	if (!PhotonClient.IsInitialized())
																	{
																		break;
																	}
																	if (13660 - 196408 == -182748)
																	{
																		this.ActionEvent("RPC_nAttack_monkey", this.transform.position, this.transform.forward, num);
																		if (152440 - 470607 != -318166)
																		{
																			break;
																		}
																	}
																}
															}
														}
														else if (eMountType == eMountType.Sheep)
														{
															if (280401 - 464049 == -183648)
															{
																if (Vector3.Angle(this.transform.forward, global::Math.vFlat(vector)) > (float)90)
																{
																	if (231039 - 74519 != 156521)
																	{
																		Camera.main.SendMessage("newGameMessage", "Can only attack front target");
																		if (210617 - 179145 != 31473)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	this.StartCoroutine_Auto(this.RPC_nAttack_sheep(this.transform.position, vector, num));
																	if (126001 - 21263 != 104739)
																	{
																		if (!PhotonClient.IsInitialized())
																		{
																			break;
																		}
																		if (148898 - 149437 != -538)
																		{
																			this.ActionEvent("RPC_nAttack_sheep", this.transform.position, vector, num);
																			if (252715 - 492493 == -239778)
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
															if (19213 - 575891 == -556678)
															{
																if (Vector3.Angle(this.transform.forward, global::Math.vFlat(vector)) > (float)60)
																{
																	if (35725 - 93516 != -57790)
																	{
																		Camera.main.SendMessage("newGameMessage", "Can only attack front target");
																		if (162277 - 280195 != -117917)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	if (gameObject == this.gameObject)
																	{
																		if (105608 - 74588 == 31021)
																		{
																			continue;
																		}
																		vector = (float)12 * this.transform.forward;
																		if (27382 - 435908 == -408525)
																		{
																			continue;
																		}
																		num = 0;
																		if (136983 - 328894 == -191910)
																		{
																			continue;
																		}
																	}
																	this.StartCoroutine_Auto(this.RPC_nAttack_penguin(this.transform.position, vector, num));
																	if (138884 - 90100 == 48784)
																	{
																		if (!PhotonClient.IsInitialized())
																		{
																			break;
																		}
																		if (146469 - 53370 != 93100)
																		{
																			this.ActionEvent("RPC_nAttack_penguin", this.transform.position, vector, num);
																			if (295123 - 229133 == 65990)
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
															if (208357 - 599261 != -390903)
															{
																if (Vector3.Angle(this.transform.forward, global::Math.vFlat(vector)) > (float)60)
																{
																	if (79554 - 340562 == -261008)
																	{
																		Camera.main.SendMessage("newGameMessage", "Can only attack front target");
																		if (115577 - 129412 != -13834)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	if (gameObject == this.gameObject)
																	{
																		if (47666 - 172362 != -124696)
																		{
																			continue;
																		}
																		vector = (float)12 * this.transform.forward;
																		if (288159 - 437704 != -149545)
																		{
																			continue;
																		}
																		num = 0;
																		if (74210 - 528789 != -454579)
																		{
																			continue;
																		}
																	}
																	this.StartCoroutine_Auto(this.RPC_nAttack_bat(this.transform.position, vector, num));
																	if (164967 - 110350 != 54618)
																	{
																		if (!PhotonClient.IsInitialized())
																		{
																			break;
																		}
																		if (213715 - 55944 != 157772)
																		{
																			this.ActionEvent("RPC_nAttack_bat", this.transform.position, vector, num);
																			if (243272 - 333980 == -90708)
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
												if (53077 - 217749 != -164671)
												{
													Camera.main.SendMessage("newGameMessage", "Not enough speed to run attack");
													if (40590 - 210200 != -169609)
													{
														break;
													}
												}
											}
											else
											{
												eMountType eMountType2 = this.mMountType;
												if (170635 - 401327 != -230691)
												{
													if (eMountType2 == eMountType.Wolf)
													{
														if (142869 - 127935 == 14934)
														{
															this.StartCoroutine_Auto(this.RPC_rAttack_wolf(this.transform.position, this.transform.forward, num));
															if (229966 - 558187 != -328220)
															{
																if (!PhotonClient.IsInitialized())
																{
																	break;
																}
																if (31744 - 127499 != -95754)
																{
																	this.ActionEvent("RPC_rAttack_wolf", this.transform.position, this.transform.forward, num);
																	if (259956 - 268259 == -8303)
																	{
																		break;
																	}
																}
															}
														}
													}
													else if (eMountType2 == eMountType.Bison)
													{
														if (279081 - 339241 != -60159)
														{
															this.StartCoroutine_Auto(this.RPC_rAttack_bison(this.transform.position, this.transform.forward, num));
															if (215686 - 236241 != -20554)
															{
																if (!PhotonClient.IsInitialized())
																{
																	break;
																}
																if (206216 - 291879 != -85662)
																{
																	this.ActionEvent("RPC_rAttack_bison", this.transform.position, this.transform.forward, num);
																	if (93574 - 92018 != 1557)
																	{
																		break;
																	}
																}
															}
														}
													}
													else if (eMountType2 == eMountType.Panda)
													{
														if (127314 - 561646 != -434331)
														{
															this.StartCoroutine_Auto(this.RPC_rAttack_panda(this.transform.position, this.transform.forward, num));
															if (215227 - 585294 == -370067)
															{
																if (!PhotonClient.IsInitialized())
																{
																	break;
																}
																if (68655 - 463989 != -395333)
																{
																	this.ActionEvent("RPC_rAttack_panda", this.transform.position, this.transform.forward, num);
																	if (214381 - 143968 == 70413)
																	{
																		break;
																	}
																}
															}
														}
													}
													else if (eMountType2 == eMountType.Whale)
													{
														if (136125 - 151887 != -15761)
														{
															this.StartCoroutine_Auto(this.RPC_rAttack_whale(this.transform.position, this.transform.forward, num));
															if (170675 - 405413 != -234737)
															{
																if (!PhotonClient.IsInitialized())
																{
																	break;
																}
																if (89021 - 599139 == -510118)
																{
																	this.ActionEvent("RPC_rAttack_whale", this.transform.position, this.transform.forward, num);
																	if (141573 - 324255 == -182682)
																	{
																		break;
																	}
																}
															}
														}
													}
													else if (eMountType2 == eMountType.Cat)
													{
														if (179030 - 361386 != -182355)
														{
															if (Vector3.Dot(this.transform.forward, vector) < (float)0)
															{
																if (151632 - 131194 == 20438)
																{
																	Camera.main.SendMessage("newGameMessage", "Can only attack front target");
																	if (144426 - 524257 != -379830)
																	{
																		break;
																	}
																}
															}
															else
															{
																if (gameObject == this.gameObject)
																{
																	if (40697 - 400286 == -359588)
																	{
																		continue;
																	}
																	vector = (float)12 * this.transform.forward;
																	if (132047 - 300305 == -168257)
																	{
																		continue;
																	}
																	num = 0;
																	if (87169 - 170274 == -83104)
																	{
																		continue;
																	}
																}
																this.StartCoroutine_Auto(this.RPC_rAttack_cat(this.transform.position, vector, num));
																if (9697 - 188068 == -178371)
																{
																	if (!PhotonClient.IsInitialized())
																	{
																		break;
																	}
																	if (290104 - 480163 != -190058)
																	{
																		this.ActionEvent("RPC_rAttack_cat", this.transform.position, vector, num);
																		if (271231 - 231573 != 39659)
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
														if (102237 - 102157 != 81)
														{
															if (num != 0)
															{
																if (200262 - 32534 == 167729)
																{
																	continue;
																}
																if (gameObject == this.gameObject)
																{
																	if (94421 - 513567 != -419146)
																	{
																		continue;
																	}
																}
																else if (Vector3.Dot(this.transform.forward, vector) < (float)0)
																{
																	if (250508 - 488197 != -237689)
																	{
																		continue;
																	}
																	Camera.main.SendMessage("newGameMessage", "Can only attack front target");
																	if (136405 - 305576 != -169171)
																	{
																		continue;
																	}
																	break;
																}
																else
																{
																	this.StartCoroutine_Auto(this.RPC_rAttack_chameleon(this.transform.position, this.transform.forward, num));
																	if (76680 - 13606 == 63075)
																	{
																		continue;
																	}
																	if (!PhotonClient.IsInitialized())
																	{
																		break;
																	}
																	if (68007 - 6638 != 61369)
																	{
																		continue;
																	}
																	this.ActionEvent("RPC_rAttack_chameleon", this.transform.position, this.transform.forward, num);
																	if (217255 - 451149 != -233893)
																	{
																		break;
																	}
																	continue;
																}
															}
															Camera.main.SendMessage("newGameMessage", "No target selected");
															if (140989 - 448786 == -307797)
															{
																break;
															}
														}
													}
													else if (eMountType2 == eMountType.Rabbit)
													{
														if (25268 - 330691 != -305422)
														{
															if (Vector3.Dot(-this.transform.right, vector) < (float)0)
															{
																if (60187 - 391274 == -331087)
																{
																	Camera.main.SendMessage("newGameMessage", "Can only attack left target");
																	if (26254 - 462115 == -435861)
																	{
																		break;
																	}
																}
															}
															else
															{
																if (gameObject == this.gameObject)
																{
																	if (125311 - 166680 != -41369)
																	{
																		continue;
																	}
																	vector = (float)-12 * this.transform.right;
																	if (99590 - 176022 != -76432)
																	{
																		continue;
																	}
																	num = 0;
																	if (212747 - 148304 != 64443)
																	{
																		continue;
																	}
																}
																this.StartCoroutine_Auto(this.RPC_rAttack_rabbit(this.transform.position, vector, num));
																if (228303 - 105826 == 122477)
																{
																	if (!PhotonClient.IsInitialized())
																	{
																		break;
																	}
																	if (289169 - 436758 != -147588)
																	{
																		this.ActionEvent("RPC_rAttack_rabbit", this.transform.position, vector, num);
																		if (196857 - 150068 == 46789)
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
														if (88138 - 30749 != 57390)
														{
															this.StartCoroutine_Auto(this.RPC_rAttack_mole(this.transform.position, vector, num));
															if (187762 - 213880 != -26117)
															{
																if (!PhotonClient.IsInitialized())
																{
																	break;
																}
																if (232723 - 403840 == -171117)
																{
																	this.ActionEvent("RPC_rAttack_mole", this.transform.position, vector, num);
																	if (299185 - 308747 == -9562)
																	{
																		break;
																	}
																}
															}
														}
													}
													else if (eMountType2 == eMountType.Monkey)
													{
														if (13257 - 309816 != -296558)
														{
															this.StartCoroutine_Auto(this.RPC_rAttack_monkey(this.transform.position, this.transform.forward, num));
															if (189943 - 97235 == 92708)
															{
																if (!PhotonClient.IsInitialized())
																{
																	break;
																}
																if (19626 - 66470 != -46843)
																{
																	this.ActionEvent("RPC_rAttack_monkey", this.transform.position, this.transform.forward, num);
																	if (159276 - 256662 == -97386)
																	{
																		break;
																	}
																}
															}
														}
													}
													else if (eMountType2 == eMountType.Sheep)
													{
														if (244350 - 8850 == 235500)
														{
															this.StartCoroutine_Auto(this.RPC_rAttack_sheep(this.transform.position, this.transform.forward, num));
															if (199275 - 228445 != -29169)
															{
																if (!PhotonClient.IsInitialized())
																{
																	break;
																}
																if (27605 - 523557 != -495951)
																{
																	this.ActionEvent("RPC_rAttack_sheep", this.transform.position, this.transform.forward, num);
																	if (137658 - 39377 != 98282)
																	{
																		break;
																	}
																}
															}
														}
													}
													else if (eMountType2 == eMountType.Penguin)
													{
														if (63221 - 598159 == -534938)
														{
															this.StartCoroutine_Auto(this.RPC_rAttack_penguin(this.transform.position, this.transform.forward, num));
															if (137277 - 505666 == -368389)
															{
																if (!PhotonClient.IsInitialized())
																{
																	break;
																}
																if (113895 - 114873 == -978)
																{
																	this.ActionEvent("RPC_rAttack_penguin", this.transform.position, this.transform.forward, num);
																	if (227518 - 87619 == 139899)
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
														if (241096 - 146580 != 94517)
														{
															this.StartCoroutine_Auto(this.RPC_rAttack_bat(this.transform.position, this.transform.forward, num));
															if (14008 - 84963 != -70954)
															{
																if (!PhotonClient.IsInitialized())
																{
																	break;
																}
																if (259728 - 277709 != -17980)
																{
																	this.ActionEvent("RPC_rAttack_bat", this.transform.position, this.transform.forward, num);
																	if (111593 - 353864 != -242270)
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

	// Token: 0x06005903 RID: 22787 RVA: 0x00AB610C File Offset: 0x00AB430C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x06005904 RID: 22788 RVA: 0x00AB6124 File Offset: 0x00AB4324
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06005905 RID: 22789 RVA: 0x00AB6128 File Offset: 0x00AB4328
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_wolf(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PvpMount.$RPC_nAttack_wolf$35149(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005906 RID: 22790 RVA: 0x00AB6138 File Offset: 0x00AB4338
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_wolf(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PvpMount.$RPC_rAttack_wolf$35162(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005907 RID: 22791 RVA: 0x00AB6148 File Offset: 0x00AB4348
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_wolf_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (184984 - 293339 != -108354)
		{
		}
		for (;;)
		{
			if (!this.pS2ctW7a5Lp)
			{
				if (132495 - 148953 != -16458)
				{
					continue;
				}
				this.pS2ctW7a5Lp = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/wolf_nAttack_hit", typeof(GameObject));
				if (187367 - 260775 == -73407)
				{
					continue;
				}
			}
			if (this.pS2ctW7a5Lp)
			{
				if (155989 - 7015 == 148975)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.pS2ctW7a5Lp, hitPos, this.transform.rotation);
				if (209825 - 493269 == -283443)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (187114 - 177036 == 10079)
				{
					continue;
				}
			}
			if (this.Rm7ctyRpCa1 >= Time.time)
			{
				break;
			}
			if (156603 - 167188 != -10584)
			{
				this.Rm7ctyRpCa1 = Time.time + 0.2f;
				if (16368 - 366854 != -350485)
				{
					if (!this.FcWctuAj6Yt)
					{
						if (164439 - 147120 == 17320)
						{
							continue;
						}
						this.FcWctuAj6Yt = (AudioClip)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Sounds/wolf_nAttack_hit", typeof(AudioClip));
						if (197941 - 431239 != -233298)
						{
							continue;
						}
					}
					if (this.FcWctuAj6Yt)
					{
						if (195950 - 169039 == 26911)
						{
							this.audio.PlayOneShot(this.FcWctuAj6Yt, 1f);
							if (291533 - 559644 != -268110)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Missing wolf_nAttack_hitFx sounds");
						if (207979 - 294079 != -86099)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005908 RID: 22792 RVA: 0x00AB63A4 File Offset: 0x00AB45A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_bison(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PvpMount.$RPC_nAttack_bison$35180(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005909 RID: 22793 RVA: 0x00AB63B4 File Offset: 0x00AB45B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_bison(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PvpMount.$RPC_rAttack_bison$35192(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600590A RID: 22794 RVA: 0x00AB63C4 File Offset: 0x00AB45C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_bison_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (257474 - 330164 != -72690)
		{
		}
		for (;;)
		{
			if (!this.equcX5UfXbU)
			{
				if (276918 - 314830 == -37911)
				{
					continue;
				}
				this.equcX5UfXbU = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/bison_nAttack_hit", typeof(GameObject));
				if (250165 - 205650 != 44515)
				{
					continue;
				}
			}
			if (this.equcX5UfXbU)
			{
				if (265642 - 590240 == -324597)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.equcX5UfXbU, hitPos, this.transform.rotation);
				if (260855 - 185505 == 75351)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (139162 - 259999 == -120836)
				{
					continue;
				}
			}
			if (this.HM2cXngAR4K >= Time.time)
			{
				break;
			}
			if (108012 - 93780 != 14233)
			{
				this.HM2cXngAR4K = Time.time + 0.2f;
				if (276832 - 558343 != -281510)
				{
					if (!this.c0AcXcP4kOm)
					{
						if (231079 - 596251 != -365172)
						{
							continue;
						}
						this.c0AcXcP4kOm = (AudioClip)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Sounds/bison_nAttack_hit", typeof(AudioClip));
						if (149552 - 140510 != 9042)
						{
							continue;
						}
					}
					if (this.c0AcXcP4kOm)
					{
						if (2082 - 335203 == -333121)
						{
							this.audio.PlayOneShot(this.c0AcXcP4kOm, 1f);
							if (4745 - 144673 != -139927)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Missing bison_nAttack_hitFx sounds");
						if (293880 - 364819 == -70939)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600590B RID: 22795 RVA: 0x00AB6620 File Offset: 0x00AB4820
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_panda(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PvpMount.$RPC_nAttack_panda$35204(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600590C RID: 22796 RVA: 0x00AB6630 File Offset: 0x00AB4830
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_panda_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (18409 - 67183 != -48773)
		{
		}
		for (;;)
		{
			if (!this.mawcXIlM9H5)
			{
				if (284709 - 191372 == 93338)
				{
					continue;
				}
				this.mawcXIlM9H5 = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/panda_nAttack_hit");
				if (154106 - 555949 == -401842)
				{
					continue;
				}
			}
			if (this.mawcXIlM9H5)
			{
				if (24206 - 371195 == -346989)
				{
					UnityEngine.Object.Instantiate(this.mawcXIlM9H5, hitPos, this.transform.rotation);
					if (255006 - 568365 == -313359)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (290495 - 579334 != -288838)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600590D RID: 22797 RVA: 0x00AB6748 File Offset: 0x00AB4948
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_panda(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PvpMount.$RPC_rAttack_panda$35217(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600590E RID: 22798 RVA: 0x00AB6758 File Offset: 0x00AB4958
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_whale(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PvpMount.$RPC_nAttack_whale$35229(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600590F RID: 22799 RVA: 0x00AB6768 File Offset: 0x00AB4968
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_whale_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (126604 - 476712 != -350107)
		{
		}
		for (;;)
		{
			if (!this.VCBcXOrnI4J)
			{
				if (157889 - 383196 == -225306)
				{
					continue;
				}
				this.VCBcXOrnI4J = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/whale_nAttack_hit");
				if (101553 - 30073 == 71481)
				{
					continue;
				}
			}
			if (this.VCBcXOrnI4J)
			{
				if (144304 - 244007 != -99702)
				{
					UnityEngine.Object.Instantiate(this.VCBcXOrnI4J, hitPos, this.transform.rotation);
					if (254565 - 443312 == -188747)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (2114 - 29036 != -26921)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005910 RID: 22800 RVA: 0x00AB6880 File Offset: 0x00AB4A80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_whale(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PvpMount.$RPC_rAttack_whale$35241(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005911 RID: 22801 RVA: 0x00AB6890 File Offset: 0x00AB4A90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_cat(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PvpMount.$RPC_nAttack_cat$35253(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005912 RID: 22802 RVA: 0x00AB68A0 File Offset: 0x00AB4AA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_cat(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PvpMount.$RPC_rAttack_cat$35264(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06005913 RID: 22803 RVA: 0x00AB68B0 File Offset: 0x00AB4AB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_rAttack_cat_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (209875 - 69269 != 140607)
		{
		}
		for (;;)
		{
			if (!this.BZkcXp1C3mr)
			{
				if (204596 - 379694 != -175098)
				{
					continue;
				}
				this.BZkcXp1C3mr = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/cat_rAttack_hit");
				if (277009 - 579083 != -302074)
				{
					continue;
				}
			}
			if (this.BZkcXp1C3mr)
			{
				if (284557 - 45365 != 239193)
				{
					UnityEngine.Object.Instantiate(this.BZkcXp1C3mr, hitPos, this.transform.rotation);
					if (235592 - 408760 != -173167)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (165279 - 26669 != 138611)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005914 RID: 22804 RVA: 0x00AB69C8 File Offset: 0x00AB4BC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_chameleon(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PvpMount.$RPC_nAttack_chameleon$35281(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06005915 RID: 22805 RVA: 0x00AB69D8 File Offset: 0x00AB4BD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_chameleon(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PvpMount.$RPC_rAttack_chameleon$35306(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06005916 RID: 22806 RVA: 0x00AB69E8 File Offset: 0x00AB4BE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_chameleon_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (1362 - 520222 != -518859)
		{
		}
		for (;;)
		{
			if (!this.zZVcXrxbaBo)
			{
				if (82095 - 25938 == 56158)
				{
					continue;
				}
				this.zZVcXrxbaBo = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/chameleon_nAttack_fire");
				if (97263 - 286474 == -189210)
				{
					continue;
				}
			}
			if (this.zZVcXrxbaBo)
			{
				if (75758 - 544787 == -469029)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.zZVcXrxbaBo, firePos, Quaternion.LookRotation(fireDir));
					if (117244 - 24794 != 92451)
					{
						ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
						if (159657 - 321837 != -162179)
						{
							projectileControl.Init(this.mChar.ActorNr);
							if (160249 - 559750 != -399500)
							{
								projectileControl.life = 0.8f;
								if (179390 - 541901 == -362511)
								{
									PvpMount_chameleon_nAttack pvpMount_chameleon_nAttack = (PvpMount_chameleon_nAttack)gameObject.GetComponent(typeof(PvpMount_chameleon_nAttack));
									if (215104 - 329941 == -114837)
									{
										if (!pvpMount_chameleon_nAttack)
										{
											break;
										}
										if (228409 - 15036 == 213373)
										{
											pvpMount_chameleon_nAttack.Init(this.gameObject);
											if (299338 - 286148 == 13190)
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
				if (102730 - 496536 != -393805)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005917 RID: 22807 RVA: 0x00AB6BFC File Offset: 0x00AB4DFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_chameleon_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (24235 - 563788 != -539552)
		{
		}
		for (;;)
		{
			if (!this.G6GcXxrMaIp)
			{
				if (193611 - 459100 != -265489)
				{
					continue;
				}
				this.G6GcXxrMaIp = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/chameleon_nAttack_hit");
				if (20189 - 28565 == -8375)
				{
					continue;
				}
			}
			if (this.G6GcXxrMaIp)
			{
				if (254699 - 69580 == 185119)
				{
					UnityEngine.Object.Instantiate(this.G6GcXxrMaIp, hitPos, this.transform.rotation);
					if (51290 - 181896 == -130606)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (163915 - 310041 == -146126)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005918 RID: 22808 RVA: 0x00AB6D14 File Offset: 0x00AB4F14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_rabbit(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PvpMount.$RPC_nAttack_rabbit$35335(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06005919 RID: 22809 RVA: 0x00AB6D24 File Offset: 0x00AB4F24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_rabbit_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (214683 - 59420 != 155263)
		{
		}
		for (;;)
		{
			if (!this.aQqcX3LP7fZ)
			{
				if (285235 - 502768 != -217533)
				{
					continue;
				}
				this.aQqcX3LP7fZ = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/rabbit_nAttack_hit");
				if (271147 - 75621 == 195527)
				{
					continue;
				}
			}
			if (this.aQqcX3LP7fZ)
			{
				if (222743 - 189940 == 32803)
				{
					UnityEngine.Object.Instantiate(this.aQqcX3LP7fZ, hitPos, this.transform.rotation);
					if (283510 - 504404 != -220893)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (173218 - 32466 == 140752)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600591A RID: 22810 RVA: 0x00AB6E3C File Offset: 0x00AB503C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_rabbit(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PvpMount.$RPC_rAttack_rabbit$35358(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x0600591B RID: 22811 RVA: 0x00AB6E4C File Offset: 0x00AB504C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_mole(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PvpMount.$RPC_nAttack_mole$35381(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x0600591C RID: 22812 RVA: 0x00AB6E5C File Offset: 0x00AB505C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_mole_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (129143 - 202182 != -73038)
		{
		}
		for (;;)
		{
			if (!this.mPhcXds3HTo)
			{
				if (39192 - 488324 == -449131)
				{
					continue;
				}
				this.mPhcXds3HTo = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/mole_nAttack_fire");
				if (162894 - 91514 != 71380)
				{
					continue;
				}
			}
			if (this.mPhcXds3HTo)
			{
				if (276885 - 225600 != 51286)
				{
					Quaternion rotation = Quaternion.LookRotation(global::Math.getTrajectoryVector(firePos, firePos + fireDir, (float)15));
					if (183074 - 155385 != 27690)
					{
						GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.mPhcXds3HTo, firePos, rotation);
						if (282924 - 389303 != -106378)
						{
							ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
							if (120668 - 583097 == -462429)
							{
								projectileControl.Init(this.mChar.ActorNr);
								if (102102 - 571184 == -469082)
								{
									projectileControl.life = (float)10 * this.mChar.rangeMod;
									if (243692 - 369782 != -126089)
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
				if (64208 - 234208 == -170000)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600591D RID: 22813 RVA: 0x00AB7028 File Offset: 0x00AB5228
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_mole_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (61192 - 112633 != -51441)
		{
		}
		for (;;)
		{
			if (!this.ek2cXgnSFXD)
			{
				if (58901 - 437987 == -379085)
				{
					continue;
				}
				this.ek2cXgnSFXD = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/mole_nAttack_hit");
				if (265095 - 475242 != -210147)
				{
					continue;
				}
			}
			if (this.ek2cXgnSFXD)
			{
				if (276355 - 414266 == -137911)
				{
					UnityEngine.Object.Instantiate(this.ek2cXgnSFXD, hitPos, this.transform.rotation);
					if (2909 - 298665 != -295755)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (63895 - 545665 == -481770)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600591E RID: 22814 RVA: 0x00AB7140 File Offset: 0x00AB5340
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_mole(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PvpMount.$RPC_rAttack_mole$35396(mPos, this).GetEnumerator();
	}

	// Token: 0x0600591F RID: 22815 RVA: 0x00AB7150 File Offset: 0x00AB5350
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_mole_fire(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		return new PvpMount.$RPC_rAttack_mole_fire$35401(hitPos, this).GetEnumerator();
	}

	// Token: 0x06005920 RID: 22816 RVA: 0x00AB7160 File Offset: 0x00AB5360
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_monkey(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PvpMount.$RPC_nAttack_monkey$35410(mPos, this).GetEnumerator();
	}

	// Token: 0x06005921 RID: 22817 RVA: 0x00AB7170 File Offset: 0x00AB5370
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_monkey_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (48326 - 399112 != -350786)
		{
		}
		for (;;)
		{
			if (!this.DeZcX74EFtl)
			{
				if (283451 - 115503 == 167949)
				{
					continue;
				}
				this.DeZcX74EFtl = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/monkey_nAttack_hit");
				if (88813 - 440748 != -351935)
				{
					continue;
				}
			}
			if (this.DeZcX74EFtl)
			{
				if (227096 - 464409 == -237313)
				{
					UnityEngine.Object.Instantiate(this.DeZcX74EFtl, hitPos, this.transform.rotation);
					if (275829 - 288319 != -12489)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (15593 - 56419 == -40826)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005922 RID: 22818 RVA: 0x00AB7288 File Offset: 0x00AB5488
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_monkey(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PvpMount.$RPC_rAttack_monkey$35421(mPos, this).GetEnumerator();
	}

	// Token: 0x06005923 RID: 22819 RVA: 0x00AB7298 File Offset: 0x00AB5498
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_sheep(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PvpMount.$RPC_nAttack_sheep$35431(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06005924 RID: 22820 RVA: 0x00AB72A8 File Offset: 0x00AB54A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_sheep_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (214481 - 22801 != 191681)
		{
		}
		for (;;)
		{
			if (!this.np3cXL4K2f5)
			{
				if (209214 - 126412 == 82803)
				{
					continue;
				}
				this.np3cXL4K2f5 = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/sheep_nAttack_fire", typeof(GameObject));
				if (208439 - 149414 != 59025)
				{
					continue;
				}
			}
			if (this.np3cXL4K2f5)
			{
				if (165409 - 485373 != -319963)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.np3cXL4K2f5, firePos, Quaternion.LookRotation(fireDir));
					if (115429 - 520948 == -405519)
					{
						ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
						if (135580 - 40926 == 94654)
						{
							projectileControl.Init(this.mChar.ActorNr);
							if (10146 - 575702 == -565556)
							{
								projectileControl.life = (float)5 * this.mChar.rangeMod;
								if (3361 - 186366 != -183004)
								{
									GameObject tObject = null;
									if (167585 - 296355 == -128770)
									{
										if (tID != 0)
										{
											if (206482 - 119550 == 86933)
											{
												continue;
											}
											if (tID != this.mChar.ActorNr)
											{
												if (153565 - 387832 != -234267)
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
												if (60001 - 539462 != -479461)
												{
													continue;
												}
											}
										}
										PvpMount_sheep_nAttack pvpMount_sheep_nAttack = (PvpMount_sheep_nAttack)gameObject.GetComponent(typeof(PvpMount_sheep_nAttack));
										if (147746 - 503838 == -356092)
										{
											if (!pvpMount_sheep_nAttack)
											{
												break;
											}
											if (120282 - 316733 != -196450)
											{
												pvpMount_sheep_nAttack.Init(tObject);
												if (250202 - 346056 == -95854)
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
				if (234724 - 42022 != 192703)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005925 RID: 22821 RVA: 0x00AB7578 File Offset: 0x00AB5778
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_sheep_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (49821 - 326417 != -276596)
		{
		}
		for (;;)
		{
			if (!this.iNTcXw4LI7F)
			{
				if (80791 - 271262 == -190470)
				{
					continue;
				}
				this.iNTcXw4LI7F = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/sheep_nAttack_hit", typeof(GameObject));
				if (148066 - 421781 != -273715)
				{
					continue;
				}
			}
			if (this.iNTcXw4LI7F)
			{
				if (142356 - 476062 != -333705)
				{
					UnityEngine.Object.Instantiate(this.iNTcXw4LI7F, hitPos, this.transform.rotation);
					if (261104 - 280406 == -19302)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (117098 - 461415 != -344316)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005926 RID: 22822 RVA: 0x00AB7698 File Offset: 0x00AB5898
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_sheep(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PvpMount.$RPC_rAttack_sheep$35443(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005927 RID: 22823 RVA: 0x00AB76A8 File Offset: 0x00AB58A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_penguin(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PvpMount.$RPC_nAttack_penguin$35455(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005928 RID: 22824 RVA: 0x00AB76B8 File Offset: 0x00AB58B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_penguin_fire(Vector3 firePos, Vector3 fireDir, int targetID)
	{
		if (94679 - 542808 != -448129)
		{
		}
		for (;;)
		{
			if (!this.mgVcXPo1KmV)
			{
				if (87631 - 156169 == -68537)
				{
					continue;
				}
				this.mgVcXPo1KmV = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/penguin_nAttack_fire", typeof(GameObject));
				if (129212 - 70429 == 58784)
				{
					continue;
				}
			}
			if (this.mgVcXPo1KmV)
			{
				if (175963 - 562092 != -386128)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.mgVcXPo1KmV, firePos, Quaternion.FromToRotation(Vector3.forward, fireDir));
					if (239130 - 238545 == 585)
					{
						ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
						if (223115 - 10165 != 212951)
						{
							projectileControl.Init(this.mChar.ActorNr);
							if (207717 - 106945 != 100773)
							{
								projectileControl.life = 1.4f * this.mChar.rangeMod;
								if (187691 - 50391 == 137300)
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
				if (227685 - 103350 != 124336)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005929 RID: 22825 RVA: 0x00AB786C File Offset: 0x00AB5A6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_penguin_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (156801 - 400345 != -243544)
		{
		}
		for (;;)
		{
			if (!this.nSbcXSEXfl6)
			{
				if (126432 - 300341 != -173909)
				{
					continue;
				}
				this.nSbcXSEXfl6 = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/penguin_nAttack_hit", typeof(GameObject));
				if (74080 - 170682 != -96602)
				{
					continue;
				}
			}
			if (this.nSbcXSEXfl6)
			{
				if (6170 - 305836 == -299666)
				{
					UnityEngine.Object.Instantiate(this.nSbcXSEXfl6, hitPos, this.transform.rotation);
					if (299708 - 537812 != -238103)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (240390 - 113077 == 127313)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600592A RID: 22826 RVA: 0x00AB798C File Offset: 0x00AB5B8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_penguin(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PvpMount.$RPC_rAttack_penguin$35465(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600592B RID: 22827 RVA: 0x00AB799C File Offset: 0x00AB5B9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_bat(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PvpMount.$RPC_nAttack_bat$35476(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600592C RID: 22828 RVA: 0x00AB79AC File Offset: 0x00AB5BAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_bat_fire(Vector3 firePos, Vector3 fireDir, int targetID)
	{
		if (220531 - 85025 != 135507)
		{
		}
		for (;;)
		{
			IL_207:
			if (!this.Np1cXis6dr1)
			{
				if (145828 - 449545 == -303716)
				{
					continue;
				}
				this.Np1cXis6dr1 = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/bat_nAttack_fire", typeof(GameObject));
				if (164677 - 276197 != -111520)
				{
					continue;
				}
			}
			if (this.Np1cXis6dr1)
			{
				if (69442 - 311376 != -241934)
				{
					continue;
				}
				Quaternion lhs = Quaternion.FromToRotation(Vector3.forward, fireDir);
				if (285984 - 451332 == -165347)
				{
					continue;
				}
				int num = 0;
				if (42671 - 307265 != -264594)
				{
					continue;
				}
				Vector3 eulerAngles = lhs.eulerAngles;
				if (47526 - 150563 != -103037)
				{
					continue;
				}
				float num2 = eulerAngles.z = (float)num;
				if (7977 - 218392 == -210414)
				{
					continue;
				}
				if (79751 - 130017 != -50266)
				{
					continue;
				}
				Vector3 vector = lhs.eulerAngles = eulerAngles;
				if (263649 - 474872 == -211222 || 188657 - 357299 == -168641)
				{
					continue;
				}
				int i = -1;
				if (232182 - 303712 != -71530)
				{
					continue;
				}
				while (i <= 1)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.Np1cXis6dr1, firePos + (float)i * this.transform.right, lhs * Quaternion.Euler((float)0, (float)(i * 15), (float)0));
					if (116550 - 405455 != -288905)
					{
						goto IL_207;
					}
					ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
					if (297547 - 134282 != 163265)
					{
						goto IL_207;
					}
					projectileControl.Init(this.mChar.ActorNr);
					if (130238 - 496162 == -365923)
					{
						goto IL_207;
					}
					projectileControl.life = 1.25f * this.mChar.rangeMod;
					if (24865 - 233016 != -208151)
					{
						goto IL_207;
					}
					i++;
					if (248388 - 284825 == -36436)
					{
						goto IL_207;
					}
				}
				if (267502 - 367469 == -99966)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Cannot find bat_nAttack_fire effect");
				if (4273 - 451062 != -446789)
				{
					continue;
				}
			}
			if (!this.OtxcXDuwC9m)
			{
				if (68250 - 43236 == 25015)
				{
					continue;
				}
				this.OtxcXDuwC9m = (AudioClip)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Sounds/bat_nAttack", typeof(AudioClip));
				if (215337 - 229433 == -14095)
				{
					continue;
				}
			}
			if (this.OtxcXDuwC9m)
			{
				if (161155 - 123514 == 37641)
				{
					this.audio.PlayOneShot(this.OtxcXDuwC9m);
					if (131961 - 522105 != -390143)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find bat_nAttack_fireFx sound");
				if (243219 - 238783 != 4437)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600592D RID: 22829 RVA: 0x00AB7DB0 File Offset: 0x00AB5FB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_bat_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (226773 - 522529 != -295755)
		{
		}
		for (;;)
		{
			if (!this.TJ1cXmlPoko)
			{
				if (105150 - 305634 == -200483)
				{
					continue;
				}
				this.TJ1cXmlPoko = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/bat_nAttack_hit");
				if (107642 - 503899 != -396257)
				{
					continue;
				}
			}
			if (this.TJ1cXmlPoko)
			{
				if (131192 - 531104 != -399911)
				{
					UnityEngine.Object.Instantiate(this.TJ1cXmlPoko, hitPos, this.transform.rotation);
					if (43225 - 491429 == -448204)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (252939 - 543641 == -290702)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600592E RID: 22830 RVA: 0x00AB7EC8 File Offset: 0x00AB60C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack_bat(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PvpMount.$RPC_rAttack_bat$35486(mPos, this).GetEnumerator();
	}

	// Token: 0x0600592F RID: 22831 RVA: 0x00AB7ED8 File Offset: 0x00AB60D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
		if (147923 - 291513 != -143590)
		{
		}
		while (!(this.mChar.actionState == "ko"))
		{
			if (71077 - 338999 == -267922)
			{
				if (this.mChar.actionState == "dead")
				{
					if (103397 - 220088 == -116691)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = (Vector3)nArray[0];
					if (131009 - 552005 == -420996)
					{
						Vector3 b = (Vector3)nArray[1];
						if (174096 - 391169 == -217073)
						{
							this.transform.position = vector;
							if (60792 - 508226 != -447433)
							{
								this.transform.LookAt(vector + b);
								if (242899 - 597079 != -354179)
								{
									this.mChar.actionState = "ko";
									if (289753 - 22534 == 267219)
									{
										this.mChar.actionTime = Time.time;
										if (92605 - 425791 == -333186)
										{
											this.mChar.myCommand = "none";
											if (215437 - 501832 != -286394)
											{
												this.mChar.vMovement = Vector3.zero;
												if (93312 - 184508 != -91195)
												{
													this.mChar.moveSpeed = (float)0;
													if (106174 - 53848 != 52327)
													{
														this.mChar.removeStatus("mount");
														if (104276 - 492308 == -388032)
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

	// Token: 0x06005930 RID: 22832 RVA: 0x00AB8120 File Offset: 0x00AB6320
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (216371 - 141973 != 74399)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (178736 - 132467 == 46269)
				{
					break;
				}
			}
			else
			{
				Vector3 vector = (Vector3)nArray[0];
				if (20670 - 384474 == -363804)
				{
					Vector3 b = (Vector3)nArray[1];
					if (54000 - 80175 == -26175)
					{
						this.transform.position = vector;
						if (156522 - 37319 == 119203)
						{
							this.transform.LookAt(vector + b);
							if (105264 - 211226 == -105962)
							{
								this.mChar.actionState = "dead";
								if (28587 - 515128 != -486540)
								{
									this.mChar.actionTime = Time.time;
									if (267263 - 498186 != -230922)
									{
										this.mChar.myCommand = "none";
										if (192757 - 462611 != -269853)
										{
											this.mChar.vMovement = Vector3.zero;
											if (124602 - 98738 != 25865)
											{
												this.mChar.moveSpeed = (float)0;
												if (82169 - 421430 == -339261)
												{
													this.mChar.removeStatus("mount");
													if (105989 - 553223 == -447234)
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

	// Token: 0x06005931 RID: 22833 RVA: 0x00AB8334 File Offset: 0x00AB6534
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005932 RID: 22834 RVA: 0x00AB8338 File Offset: 0x00AB6538
	internal static bool pule9qppyCg75KKMrQeT()
	{
		return true;
	}

	// Token: 0x06005933 RID: 22835 RVA: 0x00AB833C File Offset: 0x00AB653C
	internal static bool p5pDJXppSqdVwYYGc03A()
	{
		return false;
	}

	// Token: 0x040061B7 RID: 25015
	public CharacterControl mChar;

	// Token: 0x040061B8 RID: 25016
	public CharacterControl mOwnerChar;

	// Token: 0x040061B9 RID: 25017
	public CameraEffect mCameraEffect;

	// Token: 0x040061BA RID: 25018
	public eMountType mMountType;

	// Token: 0x040061BB RID: 25019
	private float aNJctjMU0Ls;

	// Token: 0x040061BC RID: 25020
	public AudioClip footStep_run1;

	// Token: 0x040061BD RID: 25021
	public AudioClip footStep_run2;

	// Token: 0x040061BE RID: 25022
	private bool UE3ctobkdiT;

	// Token: 0x040061BF RID: 25023
	public AudioClip footStep_walk;

	// Token: 0x040061C0 RID: 25024
	private GameObject ilxctkHokxc;

	// Token: 0x040061C1 RID: 25025
	private AudioClip dUsctFa0M0r;

	// Token: 0x040061C2 RID: 25026
	private GameObject pHEctAc0Q04;

	// Token: 0x040061C3 RID: 25027
	private AudioClip tiCct9UhtNP;

	// Token: 0x040061C4 RID: 25028
	private GameObject pS2ctW7a5Lp;

	// Token: 0x040061C5 RID: 25029
	private AudioClip FcWctuAj6Yt;

	// Token: 0x040061C6 RID: 25030
	private float Rm7ctyRpCa1;

	// Token: 0x040061C7 RID: 25031
	private GameObject llPctVpCM0b;

	// Token: 0x040061C8 RID: 25032
	private AudioClip zVTcthFka7f;

	// Token: 0x040061C9 RID: 25033
	private GameObject mGUctK8xkBq;

	// Token: 0x040061CA RID: 25034
	private AudioClip jrfctzOka3Y;

	// Token: 0x040061CB RID: 25035
	private GameObject equcX5UfXbU;

	// Token: 0x040061CC RID: 25036
	private AudioClip c0AcXcP4kOm;

	// Token: 0x040061CD RID: 25037
	private float HM2cXngAR4K;

	// Token: 0x040061CE RID: 25038
	private AudioClip FuPcXQHsEjH;

	// Token: 0x040061CF RID: 25039
	private AudioClip BUncXeSXb1j;

	// Token: 0x040061D0 RID: 25040
	private GameObject mawcXIlM9H5;

	// Token: 0x040061D1 RID: 25041
	private GameObject YgbcXJdQfA0;

	// Token: 0x040061D2 RID: 25042
	private AudioClip e36cX6PIYbJ;

	// Token: 0x040061D3 RID: 25043
	private GameObject GLMcXtZvLOd;

	// Token: 0x040061D4 RID: 25044
	private AudioClip J9ycXXX8b5y;

	// Token: 0x040061D5 RID: 25045
	private GameObject VCBcXOrnI4J;

	// Token: 0x040061D6 RID: 25046
	private GameObject HWtcX2HtlFN;

	// Token: 0x040061D7 RID: 25047
	private AudioClip hHfcXvhD0XV;

	// Token: 0x040061D8 RID: 25048
	private GameObject OYLcXlljUcF;

	// Token: 0x040061D9 RID: 25049
	private AudioClip a8rcXGoMXbu;

	// Token: 0x040061DA RID: 25050
	private GameObject GX5cX1IxnIo;

	// Token: 0x040061DB RID: 25051
	private AudioClip kNkcXqfhWTR;

	// Token: 0x040061DC RID: 25052
	private GameObject BZkcXp1C3mr;

	// Token: 0x040061DD RID: 25053
	private GameObject o0scXR8Hv1T;

	// Token: 0x040061DE RID: 25054
	private GameObject zZVcXrxbaBo;

	// Token: 0x040061DF RID: 25055
	private GameObject G6GcXxrMaIp;

	// Token: 0x040061E0 RID: 25056
	private GameObject sd2cXTZgAV6;

	// Token: 0x040061E1 RID: 25057
	private AudioClip u5jcXYigD5V;

	// Token: 0x040061E2 RID: 25058
	private GameObject aQqcX3LP7fZ;

	// Token: 0x040061E3 RID: 25059
	private AudioClip TrwcXbbvxbb;

	// Token: 0x040061E4 RID: 25060
	private GameObject mPhcXds3HTo;

	// Token: 0x040061E5 RID: 25061
	private GameObject ek2cXgnSFXD;

	// Token: 0x040061E6 RID: 25062
	private GameObject N53cXahB684;

	// Token: 0x040061E7 RID: 25063
	private GameObject McLcX4f8dXQ;

	// Token: 0x040061E8 RID: 25064
	private AudioClip nTscXsackeF;

	// Token: 0x040061E9 RID: 25065
	private AudioClip yOZcXHIOh0G;

	// Token: 0x040061EA RID: 25066
	private GameObject DeZcX74EFtl;

	// Token: 0x040061EB RID: 25067
	private GameObject dbGcXZnlCB4;

	// Token: 0x040061EC RID: 25068
	private AudioClip V1xcXCwoSXV;

	// Token: 0x040061ED RID: 25069
	private GameObject MDWcXMDXHvd;

	// Token: 0x040061EE RID: 25070
	private AudioClip i6acXf8Bove;

	// Token: 0x040061EF RID: 25071
	private GameObject np3cXL4K2f5;

	// Token: 0x040061F0 RID: 25072
	private GameObject iNTcXw4LI7F;

	// Token: 0x040061F1 RID: 25073
	private GameObject wyGcXU3qx3e;

	// Token: 0x040061F2 RID: 25074
	private AudioClip Ev7cXN0TgYg;

	// Token: 0x040061F3 RID: 25075
	private AudioClip PLCcXEok4wE;

	// Token: 0x040061F4 RID: 25076
	private GameObject mgVcXPo1KmV;

	// Token: 0x040061F5 RID: 25077
	private GameObject nSbcXSEXfl6;

	// Token: 0x040061F6 RID: 25078
	private GameObject zg1cXBFBNCy;

	// Token: 0x040061F7 RID: 25079
	private AudioClip doycX0E6EEc;

	// Token: 0x040061F8 RID: 25080
	private AudioClip wVxcX8qFmjk;

	// Token: 0x040061F9 RID: 25081
	private GameObject Np1cXis6dr1;

	// Token: 0x040061FA RID: 25082
	private AudioClip OtxcXDuwC9m;

	// Token: 0x040061FB RID: 25083
	private GameObject TJ1cXmlPoko;

	// Token: 0x040061FC RID: 25084
	private GameObject YkccXjdEE5J;

	// Token: 0x040061FD RID: 25085
	private AudioClip cR9cXoho9sy;

	// Token: 0x02000F4D RID: 3917
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_wolf$35149 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005934 RID: 22836 RVA: 0x00AB8340 File Offset: 0x00AB6540
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_wolf$35149(Vector3 mPos, Vector3 tDir, PvpMount self_)
		{
			if (223785 - 488899 != -265114)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (299420 - 572034 == -272614)
				{
					base..ctor();
					if (244385 - 87031 == 157354)
					{
						this.$mPos$35159 = mPos;
						if (260094 - 215037 != 45058)
						{
							this.$tDir$35160 = tDir;
							if (229041 - 331403 != -102361)
							{
								this.$self_$35161 = self_;
								if (89934 - 60439 != 29496)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005935 RID: 22837 RVA: 0x00AB841C File Offset: 0x00AB661C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PvpMount.$RPC_nAttack_wolf$35149.$(this.$mPos$35159, this.$tDir$35160, this.$self_$35161);
		}

		// Token: 0x06005936 RID: 22838 RVA: 0x00AB8438 File Offset: 0x00AB6638
		internal static bool WDPKTCppoiERARRVo0hE()
		{
			return true;
		}

		// Token: 0x06005937 RID: 22839 RVA: 0x00AB843C File Offset: 0x00AB663C
		internal static bool Vn4K4KppENpvEDCVkOaH()
		{
			return false;
		}

		// Token: 0x040061FE RID: 25086
		internal Vector3 $mPos$35159;

		// Token: 0x040061FF RID: 25087
		internal Vector3 $tDir$35160;

		// Token: 0x04006200 RID: 25088
		internal PvpMount $self_$35161;

		// Token: 0x02000F4E RID: 3918
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005938 RID: 22840 RVA: 0x00AB8440 File Offset: 0x00AB6640
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PvpMount self_)
			{
				if (295549 - 348151 != -52602)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (281416 - 343343 != -61926)
					{
						base..ctor();
						if (6272 - 501587 != -495314)
						{
							this.$mPos$35156 = mPos;
							if (263558 - 125663 == 137895)
							{
								this.$tDir$35157 = tDir;
								if (93411 - 352676 == -259265)
								{
									this.$self_$35158 = self_;
									if (53093 - 492333 != -439239)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005939 RID: 22841 RVA: 0x00AB851C File Offset: 0x00AB671C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (110507 - 567818 != -457311)
				{
				}
				for (;;)
				{
					IL_447:
					switch (this._state)
					{
					case 0:
						goto IL_903;
					case 1:
						goto IL_B0A;
					case 2:
						if (this.$self_$35158.mChar.actionState != "attack")
						{
							if (276123 - 395955 != -119831)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							if (!this.$self_$35158.ilxctkHokxc)
							{
								if (87751 - 375071 != -287320)
								{
									continue;
								}
								this.$self_$35158.ilxctkHokxc = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/wolf_nAttack", typeof(GameObject));
								if (190330 - 535701 != -345371)
								{
									continue;
								}
							}
							if (this.$self_$35158.ilxctkHokxc)
							{
								if (88171 - 439493 == -351321)
								{
									continue;
								}
								this.$self_$35158.mChar.createEffect(this.$self_$35158.ilxctkHokxc, this.$self_$35158.transform.position, this.$self_$35158.transform.rotation);
								if (112582 - 451541 != -338959)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find nAttack_wolf effect");
								if (259659 - 121734 == 137926)
								{
									continue;
								}
							}
							this.$i$35150 = 0;
							if (60870 - 268299 != -207429)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$35158.mChar.actionState != "attack")
						{
							if (79100 - 589154 != -510054)
							{
								continue;
							}
							goto IL_171;
						}
						else
						{
							if (this.$self_$35158.mChar.isMine)
							{
								if (155754 - 132263 == 23492)
								{
									continue;
								}
								this.$hitLayer$35151 = 130816 - (1 << this.$self_$35158.gameObject.layer);
								if (289020 - 139878 == 149143)
								{
									continue;
								}
								this.$hitList$35152 = Damage.FindRecTarget(this.$self_$35158.transform.position, this.$self_$35158.transform.forward, (float)1, (float)1, (float)3, (float)3, this.$hitLayer$35151);
								if (299736 - 7439 == 292298)
								{
									continue;
								}
								this.$$iterator$10556$35155 = UnityRuntimeServices.GetEnumerator(this.$hitList$35152);
								if (198735 - 233386 == -34650)
								{
									continue;
								}
								while (this.$$iterator$10556$35155.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10556$35155.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$35153 = (GameObject)obj2;
									if (223241 - 387448 == -164206)
									{
										goto IL_447;
									}
									if (this.$self_$35158.mChar.hit(1, this.$hitObject$35153, (int)(0.75f * (float)this.$self_$35158.mChar.atk), 1, 0, 0.3f * this.$self_$35158.transform.forward) != 0)
									{
										if (114542 - 75314 == 39229)
										{
											goto IL_447;
										}
										this.$hitPos$35154 = this.$hitObject$35153.collider.ClosestPointOnBounds(this.$self_$35158.transform.position + (float)2 * Vector3.up);
										if (263147 - 263004 != 143)
										{
											goto IL_447;
										}
										UnityRuntimeServices.Update(this.$$iterator$10556$35155, this.$hitObject$35153);
										if (239199 - 166152 == 73048)
										{
											goto IL_447;
										}
										this.$self_$35158.RPC_nAttack_wolf_hit(this.$hitPos$35154, this.$self_$35158.transform.forward, 0);
										if (50604 - 20388 != 30216)
										{
											goto IL_447;
										}
										this.$self_$35158.ActionEvent("RPC_nAttack_wolf_hit", this.$hitPos$35154, this.$self_$35158.transform.forward, 0);
										if (281269 - 407926 == -126656)
										{
											goto IL_447;
										}
									}
								}
								if (210679 - 232961 == -22281)
								{
									continue;
								}
							}
							this.$i$35150++;
							if (263654 - 260262 != 3392)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$35158.mChar.actionState == "attack")
						{
							if (231795 - 252944 != -21149)
							{
								continue;
							}
							if (this.$self_$35158.mChar.myCommand == "nAttack")
							{
								if (30058 - 447716 == -417657)
								{
									continue;
								}
								this.$self_$35158.mChar.actionState = "standby";
								if (262591 - 478104 != -215513)
								{
									continue;
								}
								this.$self_$35158.mChar.actionTime = Time.time;
								if (134045 - 29534 == 104512)
								{
									continue;
								}
								this.$self_$35158.mChar.myCommand = "none";
								if (258420 - 435305 == -176884)
								{
									continue;
								}
								if (!this.$self_$35158.mChar.isMine)
								{
									if (226052 - 139300 == 86753)
									{
										continue;
									}
									this.$self_$35158.mChar.nPosition = this.$self_$35158.transform.position;
									if (277538 - 6175 == 271364)
									{
										continue;
									}
									this.$self_$35158.mChar.oPosition = this.$self_$35158.transform.position;
									if (253492 - 374474 == -120981)
									{
										continue;
									}
									this.$self_$35158.mChar.nDirection = this.$self_$35158.transform.forward;
									if (247421 - 320637 != -73216)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (150556 - 156320 != -5763)
						{
							goto Block_31;
						}
						continue;
					default:
						if (80718 - 296251 != -215532)
						{
							goto IL_903;
						}
						continue;
					}
					if (this.$i$35150 < 2)
					{
						goto IL_5E0;
					}
					if (261978 - 524367 != -262388)
					{
						goto Block_33;
					}
					continue;
					IL_903:
					this.$self_$35158.mChar.actionState = "attack";
					if (37612 - 256947 == -219335)
					{
						this.$self_$35158.mChar.actionTime = Time.time;
						if (116834 - 317715 != -200880)
						{
							this.$self_$35158.mChar.myCommand = "nAttack";
							if (201351 - 222758 == -21407)
							{
								this.$self_$35158.mChar.addTimeOut("nAttack", 1.5f);
								if (198203 - 328806 == -130603)
								{
									this.$self_$35158.transform.position = this.$mPos$35156;
									if (84487 - 567372 == -482885)
									{
										this.$self_$35158.transform.LookAt(this.$mPos$35156 + global::Math.vFlat(this.$tDir$35157));
										if (146637 - 565680 != -419042)
										{
											this.$self_$35158.animation.CrossFade("nAttack", 0.2f);
											if (172995 - 535927 == -362932)
											{
												this.$self_$35158.animation.wrapMode = WrapMode.Once;
												if (252913 - 447637 == -194724)
												{
													this.$self_$35158.mChar.vMovement = this.$self_$35158.transform.forward;
													if (61606 - 262016 != -200409)
													{
														this.$self_$35158.mChar.moveSpeed = (float)0;
														if (192907 - 1289 != 191619)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																goto IL_4AB;
															}
															if (235069 - 315403 != -80333)
															{
																if (!this.$self_$35158.mChar.isMine)
																{
																	if (178017 - 528200 != -350183)
																	{
																		continue;
																	}
																	if (Game.mGameType <= 4)
																	{
																		goto IL_4AB;
																	}
																	if (143435 - 408324 != -264889)
																	{
																		continue;
																	}
																	if (Game.mTeam != this.$self_$35158.mChar.mOriginalLayer - 7)
																	{
																		goto IL_4AB;
																	}
																	if (52647 - 282045 != -229398)
																	{
																		continue;
																	}
																}
																if (!this.$self_$35158.dUsctFa0M0r)
																{
																	if (107591 - 71037 == 36555)
																	{
																		continue;
																	}
																	this.$self_$35158.dUsctFa0M0r = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Wolf/Voices/nAttack2", typeof(AudioClip));
																	if (117828 - 158222 != -40394)
																	{
																		continue;
																	}
																}
																if (this.$self_$35158.dUsctFa0M0r)
																{
																	if (208292 - 422457 != -214164)
																	{
																		goto Block_40;
																	}
																}
																else
																{
																	Debug.LogError("Cannot find wolf_nAttack voice");
																	if (44004 - 234389 == -190385)
																	{
																		goto IL_4AB;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_171:
				goto IL_B0A;
				IL_4AB:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_28:
				Block_31:
				goto IL_B0A;
				Block_33:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_5E0:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_40:
				this.$self_$35158.audio.PlayOneShot(this.$self_$35158.dUsctFa0M0r, (!this.$self_$35158.mChar.isMine) ? 0.75f : ((float)1));
				goto IL_4AB;
				IL_B0A:
				return false;
			}

			// Token: 0x0600593A RID: 22842 RVA: 0x00AB9048 File Offset: 0x00AB7248
			internal static bool js4nnlpp2GIQZBIfBRkP()
			{
				return true;
			}

			// Token: 0x0600593B RID: 22843 RVA: 0x00AB904C File Offset: 0x00AB724C
			internal static bool VbAdLlpp8bQXDyVH1lW4()
			{
				return false;
			}

			// Token: 0x04006201 RID: 25089
			internal int $i$35150;

			// Token: 0x04006202 RID: 25090
			internal int $hitLayer$35151;

			// Token: 0x04006203 RID: 25091
			internal UnityScript.Lang.Array $hitList$35152;

			// Token: 0x04006204 RID: 25092
			internal GameObject $hitObject$35153;

			// Token: 0x04006205 RID: 25093
			internal Vector3 $hitPos$35154;

			// Token: 0x04006206 RID: 25094
			internal IEnumerator $$iterator$10556$35155;

			// Token: 0x04006207 RID: 25095
			internal Vector3 $mPos$35156;

			// Token: 0x04006208 RID: 25096
			internal Vector3 $tDir$35157;

			// Token: 0x04006209 RID: 25097
			internal PvpMount $self_$35158;
		}
	}

	// Token: 0x02000F4F RID: 3919
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_wolf$35162 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600593C RID: 22844 RVA: 0x00AB9050 File Offset: 0x00AB7250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_wolf$35162(Vector3 mPos, Vector3 tDir, PvpMount self_)
		{
			if (276526 - 48858 != 227668)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (197940 - 307581 == -109641)
				{
					base..ctor();
					if (91363 - 376018 != -284654)
					{
						this.$mPos$35177 = mPos;
						if (17849 - 580099 == -562250)
						{
							this.$tDir$35178 = tDir;
							if (120117 - 420237 != -300119)
							{
								this.$self_$35179 = self_;
								if (247877 - 424755 != -176877)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600593D RID: 22845 RVA: 0x00AB912C File Offset: 0x00AB732C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PvpMount.$RPC_rAttack_wolf$35162.$(this.$mPos$35177, this.$tDir$35178, this.$self_$35179);
		}

		// Token: 0x0600593E RID: 22846 RVA: 0x00AB9148 File Offset: 0x00AB7348
		internal static bool uAJxmkppZhMhdHdfn4Jy()
		{
			return true;
		}

		// Token: 0x0600593F RID: 22847 RVA: 0x00AB914C File Offset: 0x00AB734C
		internal static bool r2jYsmppCKF5kBwJXMnG()
		{
			return false;
		}

		// Token: 0x0400620A RID: 25098
		internal Vector3 $mPos$35177;

		// Token: 0x0400620B RID: 25099
		internal Vector3 $tDir$35178;

		// Token: 0x0400620C RID: 25100
		internal PvpMount $self_$35179;

		// Token: 0x02000F50 RID: 3920
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005940 RID: 22848 RVA: 0x00AB9150 File Offset: 0x00AB7350
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PvpMount self_)
			{
				if (68914 - 100663 != -31749)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (265917 - 399832 != -133914)
					{
						base..ctor();
						if (135611 - 462953 != -327341)
						{
							this.$mPos$35174 = mPos;
							if (156152 - 115105 == 41047)
							{
								this.$tDir$35175 = tDir;
								if (157673 - 7754 == 149919)
								{
									this.$self_$35176 = self_;
									if (142240 - 365925 == -223685)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005941 RID: 22849 RVA: 0x00AB922C File Offset: 0x00AB742C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (259297 - 330164 != -70867)
				{
				}
				for (;;)
				{
					IL_114:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_E42;
					case 2:
						if (this.$self_$35176.mChar.actionState != "attack")
						{
							if (185439 - 277945 != -92505)
							{
								goto Block_45;
							}
							continue;
						}
						else
						{
							this.$self_$35176.mChar.moveSpeed = (float)16;
							if (61453 - 163247 == -101793)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("pvoice", 1) != 0)
							{
								if (132644 - 453415 != -320771)
								{
									continue;
								}
								if (!this.$self_$35176.mChar.isMine)
								{
									if (164465 - 281472 != -117007)
									{
										continue;
									}
									if (Game.mGameType <= 4)
									{
										goto IL_D7E;
									}
									if (84881 - 288130 == -203248)
									{
										continue;
									}
									if (Game.mTeam != this.$self_$35176.mChar.mOriginalLayer - 7)
									{
										goto IL_D7E;
									}
									if (28343 - 85742 != -57399)
									{
										continue;
									}
								}
								if (!this.$self_$35176.tiCct9UhtNP)
								{
									if (98616 - 118294 == -19677)
									{
										continue;
									}
									this.$self_$35176.tiCct9UhtNP = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Wolf/Voices/nAttack4", typeof(AudioClip));
									if (284208 - 371143 != -86935)
									{
										continue;
									}
								}
								if (this.$self_$35176.tiCct9UhtNP)
								{
									if (134776 - 413987 == -279210)
									{
										continue;
									}
									this.$self_$35176.audio.PlayOneShot(this.$self_$35176.tiCct9UhtNP, (!this.$self_$35176.mChar.isMine) ? 0.75f : ((float)1));
								}
								else
								{
									Debug.LogError("Cannot find wolf_rAttack voice");
									if (285275 - 342584 != -57309)
									{
										continue;
									}
								}
							}
							IL_D7E:
							this.$ignoreLayer$35163 = 130818;
							if (20518 - 358330 == -337811)
							{
								continue;
							}
							this.$ignoreList$35164 = Damage.FindRecTarget(this.$self_$35176.transform.position, this.$self_$35176.transform.forward, (float)2, (float)2, (float)10, (float)2, this.$ignoreLayer$35163);
							if (124180 - 251385 == -127204)
							{
								continue;
							}
							this.$$iterator$10562$35166 = UnityRuntimeServices.GetEnumerator(this.$ignoreList$35164);
							if (121541 - 421566 != -300025)
							{
								continue;
							}
							while (this.$$iterator$10562$35166.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10562$35166.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$ignoreObject$35165 = (GameObject)obj2;
								if (24918 - 471471 != -446553)
								{
									goto IL_114;
								}
								if (this.$ignoreObject$35165)
								{
									if (10557 - 1346 != 9211)
									{
										goto IL_114;
									}
									if (this.$self_$35176.gameObject != this.$ignoreObject$35165)
									{
										if (288319 - 554353 != -266034)
										{
											goto IL_114;
										}
										Physics.IgnoreCollision(this.$self_$35176.gameObject.collider, this.$ignoreObject$35165.collider, true);
										if (174210 - 76880 == 97331)
										{
											goto IL_114;
										}
										UnityRuntimeServices.Update(this.$$iterator$10562$35166, this.$ignoreObject$35165);
										if (282413 - 82533 != 199880)
										{
											goto IL_114;
										}
									}
								}
							}
							if (181019 - 361680 == -180660)
							{
								continue;
							}
							if (!this.$self_$35176.pHEctAc0Q04)
							{
								if (90691 - 47565 == 43127)
								{
									continue;
								}
								this.$self_$35176.pHEctAc0Q04 = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/wolf_rAttack", typeof(GameObject));
								if (240551 - 371118 == -130566)
								{
									continue;
								}
							}
							if (this.$self_$35176.pHEctAc0Q04)
							{
								if (192223 - 151913 != 40310)
								{
									continue;
								}
								this.$self_$35176.mChar.createEffect(this.$self_$35176.pHEctAc0Q04, this.$self_$35176.transform.position, this.$self_$35176.transform.rotation);
								if (21667 - 321809 != -300141)
								{
									goto Block_32;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find rAttack_wolf effect");
								if (156039 - 295228 != -139188)
								{
									goto Block_40;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$35176.mChar.actionState != "attack")
						{
							if (54009 - 341674 != -287665)
							{
								continue;
							}
							goto IL_27A;
						}
						else
						{
							this.$self_$35176.mChar.moveSpeed = (float)8;
							if (280358 - 274854 == 5505)
							{
								continue;
							}
							this.$$iterator$10563$35168 = UnityRuntimeServices.GetEnumerator(this.$ignoreList$35164);
							if (227335 - 467165 != -239830)
							{
								continue;
							}
							while (this.$$iterator$10563$35168.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10563$35168.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$ignoreObject$35167 = (GameObject)obj4;
								if (78372 - 271848 != -193476)
								{
									goto IL_114;
								}
								if (this.$ignoreObject$35167)
								{
									if (62756 - 266354 == -203597)
									{
										goto IL_114;
									}
									if (this.$self_$35176.gameObject != this.$ignoreObject$35167)
									{
										if (164667 - 496759 != -332092)
										{
											goto IL_114;
										}
										Physics.IgnoreCollision(this.$self_$35176.gameObject.collider, this.$ignoreObject$35167.collider, false);
										if (201722 - 101 != 201621)
										{
											goto IL_114;
										}
										UnityRuntimeServices.Update(this.$$iterator$10563$35168, this.$ignoreObject$35167);
										if (93985 - 536375 == -442389)
										{
											goto IL_114;
										}
									}
								}
							}
							if (46148 - 552085 != -505937)
							{
								continue;
							}
							if (!this.$self_$35176.mChar.isMine)
							{
								goto IL_69B;
							}
							if (256217 - 579039 != -322822)
							{
								continue;
							}
							this.$hitLayer$35169 = 130816 - (1 << this.$self_$35176.gameObject.layer);
							if (74099 - 584750 == -510650)
							{
								continue;
							}
							this.$hitList$35170 = Damage.FindRecTarget(this.$self_$35176.transform.position - (float)4 * this.$self_$35176.transform.forward, this.$self_$35176.transform.forward, (float)2, (float)2, (float)6, (float)3, this.$hitLayer$35169);
							if (198945 - 184482 == 14464)
							{
								continue;
							}
							this.$$iterator$10564$35173 = UnityRuntimeServices.GetEnumerator(this.$hitList$35170);
							if (112337 - 498885 == -386547)
							{
								continue;
							}
							while (this.$$iterator$10564$35173.MoveNext())
							{
								object obj6;
								object obj5 = obj6 = this.$$iterator$10564$35173.Current;
								if (!(obj5 is GameObject))
								{
									obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
								}
								this.$hitObject$35171 = (GameObject)obj6;
								if (81101 - 582481 == -501379)
								{
									goto IL_114;
								}
								if (this.$self_$35176.mChar.hit(21, this.$hitObject$35171, (int)(1.5f * (float)this.$self_$35176.mChar.atk), 1, 0, Vector3.zero) != 0)
								{
									if (4134 - 529320 != -525186)
									{
										goto IL_114;
									}
									this.$hitPos$35172 = this.$hitObject$35171.collider.ClosestPointOnBounds(this.$self_$35176.transform.position + (float)2 * Vector3.up);
									if (89332 - 281074 == -191741)
									{
										goto IL_114;
									}
									UnityRuntimeServices.Update(this.$$iterator$10564$35173, this.$hitObject$35171);
									if (288067 - 258849 == 29219)
									{
										goto IL_114;
									}
									this.$self_$35176.RPC_nAttack_wolf_hit(this.$hitPos$35172, this.$self_$35176.transform.forward, 0);
									if (180072 - 542573 == -362500)
									{
										goto IL_114;
									}
									this.$self_$35176.ActionEvent("RPC_nAttack_wolf_hit", this.$hitPos$35172, this.$self_$35176.transform.forward, 0);
									if (25126 - 466226 == -441099)
									{
										goto IL_114;
									}
								}
							}
							if (52474 - 447969 != -395495)
							{
								continue;
							}
							goto IL_69B;
						}
						break;
					case 4:
						if (this.$self_$35176.mChar.actionState == "attack")
						{
							if (278906 - 581758 == -302851)
							{
								continue;
							}
							if (this.$self_$35176.mChar.myCommand == "rAttack")
							{
								if (75346 - 192972 == -117625)
								{
									continue;
								}
								this.$self_$35176.mChar.actionState = "standby";
								if (241972 - 488109 == -246136)
								{
									continue;
								}
								this.$self_$35176.mChar.actionTime = Time.time;
								if (84986 - 213758 == -128771)
								{
									continue;
								}
								this.$self_$35176.mChar.myCommand = "none";
								if (19110 - 274633 != -255523)
								{
									continue;
								}
								if (!this.$self_$35176.mChar.isMine)
								{
									if (185235 - 587971 != -402736)
									{
										continue;
									}
									this.$self_$35176.mChar.nPosition = this.$self_$35176.transform.position;
									if (43723 - 114524 != -70801)
									{
										continue;
									}
									this.$self_$35176.mChar.oPosition = this.$self_$35176.transform.position;
									if (207372 - 558359 == -350986)
									{
										continue;
									}
									this.$self_$35176.mChar.nDirection = this.$self_$35176.transform.forward;
									if (185793 - 315528 == -129734)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (191447 - 239713 != -48266)
						{
							continue;
						}
						goto IL_E42;
					default:
						if (92667 - 414059 != -321392)
						{
							continue;
						}
						break;
					}
					this.$self_$35176.mChar.actionState = "attack";
					if (153377 - 203233 == -49856)
					{
						this.$self_$35176.mChar.actionTime = Time.time;
						if (96737 - 520920 == -424183)
						{
							this.$self_$35176.mChar.myCommand = "rAttack";
							if (75793 - 277690 != -201896)
							{
								this.$self_$35176.mChar.addTimeOut("nAttack", 2f);
								if (80300 - 258323 == -178023)
								{
									this.$self_$35176.transform.position = this.$mPos$35174;
									if (175090 - 528540 == -353450)
									{
										this.$self_$35176.transform.LookAt(this.$mPos$35174 + global::Math.vFlat(this.$tDir$35175));
										if (97161 - 333501 != -236339)
										{
											this.$self_$35176.animation.CrossFade("rAttack", 0.2f);
											if (188805 - 438332 != -249526)
											{
												this.$self_$35176.animation.wrapMode = WrapMode.Once;
												if (269160 - 403628 != -134467)
												{
													this.$self_$35176.mChar.vMovement = this.$self_$35176.transform.forward;
													if (60330 - 410806 != -350475)
													{
														this.$self_$35176.mChar.moveSpeed = (float)8;
														if (135732 - 365561 == -229829)
														{
															goto IL_64C;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_27A:
				goto IL_E42;
				IL_39B:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_32:
				Block_40:
				goto IL_39B;
				IL_64C:
				return this.Yield(2, new WaitForSeconds(0.4f));
				Block_45:
				goto IL_E42;
				IL_69B:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_E42:
				return false;
			}

			// Token: 0x06005942 RID: 22850 RVA: 0x00ABA090 File Offset: 0x00AB8290
			internal static bool eTkbGappLVZYkVOtsMhh()
			{
				return true;
			}

			// Token: 0x06005943 RID: 22851 RVA: 0x00ABA094 File Offset: 0x00AB8294
			internal static bool KwJoJbppO2CksGIOvQ86()
			{
				return false;
			}

			// Token: 0x0400620D RID: 25101
			internal int $ignoreLayer$35163;

			// Token: 0x0400620E RID: 25102
			internal UnityScript.Lang.Array $ignoreList$35164;

			// Token: 0x0400620F RID: 25103
			internal GameObject $ignoreObject$35165;

			// Token: 0x04006210 RID: 25104
			internal IEnumerator $$iterator$10562$35166;

			// Token: 0x04006211 RID: 25105
			internal GameObject $ignoreObject$35167;

			// Token: 0x04006212 RID: 25106
			internal IEnumerator $$iterator$10563$35168;

			// Token: 0x04006213 RID: 25107
			internal int $hitLayer$35169;

			// Token: 0x04006214 RID: 25108
			internal UnityScript.Lang.Array $hitList$35170;

			// Token: 0x04006215 RID: 25109
			internal GameObject $hitObject$35171;

			// Token: 0x04006216 RID: 25110
			internal Vector3 $hitPos$35172;

			// Token: 0x04006217 RID: 25111
			internal IEnumerator $$iterator$10564$35173;

			// Token: 0x04006218 RID: 25112
			internal Vector3 $mPos$35174;

			// Token: 0x04006219 RID: 25113
			internal Vector3 $tDir$35175;

			// Token: 0x0400621A RID: 25114
			internal PvpMount $self_$35176;
		}
	}

	// Token: 0x02000F51 RID: 3921
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_bison$35180 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005944 RID: 22852 RVA: 0x00ABA098 File Offset: 0x00AB8298
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_bison$35180(Vector3 mPos, Vector3 tDir, PvpMount self_)
		{
			if (73342 - 541663 != -468320)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (60063 - 381046 == -320983)
				{
					base..ctor();
					if (212229 - 333625 == -121396)
					{
						this.$mPos$35189 = mPos;
						if (124641 - 31646 == 92995)
						{
							this.$tDir$35190 = tDir;
							if (131347 - 588839 != -457491)
							{
								this.$self_$35191 = self_;
								if (117963 - 445363 == -327400)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005945 RID: 22853 RVA: 0x00ABA174 File Offset: 0x00AB8374
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PvpMount.$RPC_nAttack_bison$35180.$(this.$mPos$35189, this.$tDir$35190, this.$self_$35191);
		}

		// Token: 0x06005946 RID: 22854 RVA: 0x00ABA190 File Offset: 0x00AB8390
		internal static bool pUa4j6ppmJl3Jme3KY15()
		{
			return true;
		}

		// Token: 0x06005947 RID: 22855 RVA: 0x00ABA194 File Offset: 0x00AB8394
		internal static bool ErQXGjppFFxp9XxA9v6Q()
		{
			return false;
		}

		// Token: 0x0400621B RID: 25115
		internal Vector3 $mPos$35189;

		// Token: 0x0400621C RID: 25116
		internal Vector3 $tDir$35190;

		// Token: 0x0400621D RID: 25117
		internal PvpMount $self_$35191;

		// Token: 0x02000F52 RID: 3922
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005948 RID: 22856 RVA: 0x00ABA198 File Offset: 0x00AB8398
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PvpMount self_)
			{
				if (55960 - 298938 != -242978)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (63207 - 71741 != -8533)
					{
						base..ctor();
						if (49521 - 225152 != -175630)
						{
							this.$mPos$35186 = mPos;
							if (154075 - 435814 == -281739)
							{
								this.$tDir$35187 = tDir;
								if (271871 - 424501 != -152629)
								{
									this.$self_$35188 = self_;
									if (295442 - 526192 == -230750)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005949 RID: 22857 RVA: 0x00ABA274 File Offset: 0x00AB8474
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (270164 - 425199 != -155035)
				{
				}
				for (;;)
				{
					IL_44F:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_B0F;
					case 2:
						if (this.$self_$35188.mChar.actionState != "attack")
						{
							if (281630 - 124967 != 156663)
							{
								continue;
							}
							goto IL_56E;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_48C;
							}
							if (227309 - 397757 == -170447)
							{
								continue;
							}
							if (!this.$self_$35188.mChar.isMine)
							{
								if (89294 - 186681 == -97386)
								{
									continue;
								}
								if (Game.mGameType <= 4)
								{
									goto IL_48C;
								}
								if (57425 - 543833 == -486407)
								{
									continue;
								}
								if (Game.mTeam != this.$self_$35188.mChar.mOriginalLayer - 7)
								{
									goto IL_48C;
								}
								if (186113 - 396845 != -210732)
								{
									continue;
								}
							}
							if (!this.$self_$35188.zVTcthFka7f)
							{
								if (179606 - 332938 == -153331)
								{
									continue;
								}
								this.$self_$35188.zVTcthFka7f = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Bison/Voices/nAttack1", typeof(AudioClip));
								if (103907 - 516348 != -412441)
								{
									continue;
								}
							}
							if (this.$self_$35188.zVTcthFka7f)
							{
								if (167363 - 300027 != -132663)
								{
									goto Block_68;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find bison_nAttack voice");
								if (261113 - 506634 != -245520)
								{
									goto Block_62;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$35188.mChar.actionState != "attack")
						{
							if (50686 - 294479 != -243792)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							if (!this.$self_$35188.llPctVpCM0b)
							{
								if (282708 - 523947 != -241239)
								{
									continue;
								}
								this.$self_$35188.llPctVpCM0b = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/bison_nAttack", typeof(GameObject));
								if (276450 - 559643 != -283193)
								{
									continue;
								}
							}
							if (this.$self_$35188.llPctVpCM0b)
							{
								if (106735 - 328893 == -222157)
								{
									continue;
								}
								this.$self_$35188.mChar.createEffect(this.$self_$35188.llPctVpCM0b, this.$self_$35188.transform.position, this.$self_$35188.transform.rotation);
								if (34052 - 531632 != -497579)
								{
									goto Block_22;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find nAttack_bison effect");
								if (267282 - 336223 != -68941)
								{
									continue;
								}
								goto IL_61B;
							}
						}
						break;
					case 4:
						if (this.$self_$35188.mChar.actionState != "attack")
						{
							if (80118 - 14882 != 65236)
							{
								continue;
							}
							goto IL_23E;
						}
						else
						{
							if (!this.$self_$35188.mChar.isMine)
							{
								goto IL_5CC;
							}
							if (157661 - 119472 == 38190)
							{
								continue;
							}
							this.$hitLayer$35181 = 130816 - (1 << this.$self_$35188.gameObject.layer);
							if (297454 - 128469 != 168985)
							{
								continue;
							}
							this.$hitList$35182 = Damage.FindRecTarget(this.$self_$35188.transform.position, this.$self_$35188.transform.forward, (float)3, (float)3, (float)3, (float)3, this.$hitLayer$35181);
							if (124128 - 27114 != 97014)
							{
								continue;
							}
							this.$$iterator$10557$35185 = UnityRuntimeServices.GetEnumerator(this.$hitList$35182);
							if (33591 - 51002 != -17411)
							{
								continue;
							}
							while (this.$$iterator$10557$35185.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10557$35185.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$35183 = (GameObject)obj2;
								if (24878 - 206265 != -181387)
								{
									goto IL_44F;
								}
								if (this.$self_$35188.mChar.hit(2, this.$hitObject$35183, this.$self_$35188.mChar.atk, 1, 0, Vector3.zero) != 0)
								{
									if (157261 - 164978 == -7716)
									{
										goto IL_44F;
									}
									this.$hitPos$35184 = this.$hitObject$35183.collider.ClosestPointOnBounds(this.$self_$35188.transform.position + (float)2 * Vector3.up);
									if (456 - 53521 == -53064)
									{
										goto IL_44F;
									}
									UnityRuntimeServices.Update(this.$$iterator$10557$35185, this.$hitObject$35183);
									if (108665 - 159012 == -50346)
									{
										goto IL_44F;
									}
									this.$self_$35188.RPC_nAttack_bison_hit(this.$hitPos$35184, this.$self_$35188.transform.forward, 0);
									if (86249 - 465894 != -379645)
									{
										goto IL_44F;
									}
									this.$self_$35188.ActionEvent("RPC_nAttack_bison_hit", this.$hitPos$35184, this.$self_$35188.transform.forward, 0);
									if (4592 - 315299 == -310706)
									{
										goto IL_44F;
									}
								}
							}
							if (267906 - 444640 != -176733)
							{
								goto Block_47;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$35188.mChar.actionState != "attack")
						{
							if (149154 - 269177 != -120022)
							{
								goto Block_37;
							}
							continue;
						}
						else
						{
							if (this.$self_$35188.mChar.actionState == "attack")
							{
								if (61669 - 264874 == -203204)
								{
									continue;
								}
								if (this.$self_$35188.mChar.myCommand == "nAttack")
								{
									if (205704 - 237208 != -31504)
									{
										continue;
									}
									this.$self_$35188.mChar.actionState = "standby";
									if (90663 - 384721 == -294057)
									{
										continue;
									}
									this.$self_$35188.mChar.actionTime = Time.time;
									if (226849 - 226714 == 136)
									{
										continue;
									}
									this.$self_$35188.mChar.myCommand = "none";
									if (66640 - 242544 != -175904)
									{
										continue;
									}
									if (!this.$self_$35188.mChar.isMine)
									{
										if (280575 - 133711 != 146864)
										{
											continue;
										}
										this.$self_$35188.mChar.nPosition = this.$self_$35188.transform.position;
										if (90932 - 466274 != -375342)
										{
											continue;
										}
										this.$self_$35188.mChar.oPosition = this.$self_$35188.transform.position;
										if (201679 - 81849 != 119830)
										{
											continue;
										}
										this.$self_$35188.mChar.nDirection = this.$self_$35188.transform.forward;
										if (12717 - 250555 == -237837)
										{
											continue;
										}
									}
								}
							}
							this.YieldDefault(1);
							if (60251 - 547230 != -486978)
							{
								goto Block_63;
							}
							continue;
						}
						break;
					default:
						if (109784 - 547332 != -437548)
						{
							continue;
						}
						break;
					}
					this.$self_$35188.mChar.actionState = "attack";
					if (70634 - 49878 != 20757)
					{
						this.$self_$35188.mChar.actionTime = Time.time;
						if (235729 - 465625 == -229896)
						{
							this.$self_$35188.mChar.myCommand = "nAttack";
							if (291380 - 34088 == 257292)
							{
								this.$self_$35188.mChar.addTimeOut("nAttack", 1.5f);
								if (204675 - 298062 == -93387)
								{
									this.$self_$35188.transform.position = this.$mPos$35186;
									if (86828 - 384913 != -298084)
									{
										this.$self_$35188.transform.LookAt(this.$mPos$35186 + global::Math.vFlat(this.$tDir$35187));
										if (251871 - 82935 == 168936)
										{
											this.$self_$35188.animation.CrossFade("nAttack", 0.2f);
											if (34620 - 440617 != -405996)
											{
												this.$self_$35188.animation.wrapMode = WrapMode.Once;
												if (13406 - 150728 == -137322)
												{
													this.$self_$35188.mChar.vMovement = this.$self_$35188.transform.forward;
													if (164352 - 7999 != 156354)
													{
														this.$self_$35188.mChar.moveSpeed = (float)0;
														if (259877 - 401938 != -142060)
														{
															goto Block_69;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_23E:
				goto IL_B0F;
				Block_22:
				goto IL_61B;
				IL_48C:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_27:
				IL_56E:
				goto IL_B0F;
				IL_5CC:
				return this.Yield(5, new WaitForSeconds(0.2f));
				Block_37:
				goto IL_B0F;
				IL_61B:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_47:
				goto IL_5CC;
				Block_62:
				goto IL_48C;
				Block_63:
				goto IL_B0F;
				Block_68:
				this.$self_$35188.audio.PlayOneShot(this.$self_$35188.zVTcthFka7f, (!this.$self_$35188.mChar.isMine) ? 0.75f : ((float)1));
				goto IL_48C;
				Block_69:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_B0F:
				return false;
			}

			// Token: 0x0600594A RID: 22858 RVA: 0x00ABADA4 File Offset: 0x00AB8FA4
			internal static bool jQdN3vppMQaoLGQOyTeO()
			{
				return true;
			}

			// Token: 0x0600594B RID: 22859 RVA: 0x00ABADA8 File Offset: 0x00AB8FA8
			internal static bool S2fNMnppxxij4GrxiH4d()
			{
				return false;
			}

			// Token: 0x0400621E RID: 25118
			internal int $hitLayer$35181;

			// Token: 0x0400621F RID: 25119
			internal UnityScript.Lang.Array $hitList$35182;

			// Token: 0x04006220 RID: 25120
			internal GameObject $hitObject$35183;

			// Token: 0x04006221 RID: 25121
			internal Vector3 $hitPos$35184;

			// Token: 0x04006222 RID: 25122
			internal IEnumerator $$iterator$10557$35185;

			// Token: 0x04006223 RID: 25123
			internal Vector3 $mPos$35186;

			// Token: 0x04006224 RID: 25124
			internal Vector3 $tDir$35187;

			// Token: 0x04006225 RID: 25125
			internal PvpMount $self_$35188;
		}
	}

	// Token: 0x02000F53 RID: 3923
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_bison$35192 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600594C RID: 22860 RVA: 0x00ABADAC File Offset: 0x00AB8FAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_bison$35192(Vector3 mPos, Vector3 tDir, PvpMount self_)
		{
			if (255760 - 164473 != 91288)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (270266 - 451803 == -181537)
				{
					base..ctor();
					if (280950 - 31666 == 249284)
					{
						this.$mPos$35201 = mPos;
						if (43254 - 146095 == -102841)
						{
							this.$tDir$35202 = tDir;
							if (51735 - 150408 != -98672)
							{
								this.$self_$35203 = self_;
								if (67160 - 136815 == -69655)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600594D RID: 22861 RVA: 0x00ABAE88 File Offset: 0x00AB9088
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PvpMount.$RPC_rAttack_bison$35192.$(this.$mPos$35201, this.$tDir$35202, this.$self_$35203);
		}

		// Token: 0x0600594E RID: 22862 RVA: 0x00ABAEA4 File Offset: 0x00AB90A4
		internal static bool c5cSdVppgwe4Jl3YvHkM()
		{
			return true;
		}

		// Token: 0x0600594F RID: 22863 RVA: 0x00ABAEA8 File Offset: 0x00AB90A8
		internal static bool Iq9xCgppfYvGoqnc6xVU()
		{
			return false;
		}

		// Token: 0x04006226 RID: 25126
		internal Vector3 $mPos$35201;

		// Token: 0x04006227 RID: 25127
		internal Vector3 $tDir$35202;

		// Token: 0x04006228 RID: 25128
		internal PvpMount $self_$35203;

		// Token: 0x02000F54 RID: 3924
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005950 RID: 22864 RVA: 0x00ABAEAC File Offset: 0x00AB90AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PvpMount self_)
			{
				if (188637 - 326768 != -138130)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (84159 - 79774 != 4386)
					{
						base..ctor();
						if (98927 - 350924 == -251997)
						{
							this.$mPos$35198 = mPos;
							if (170924 - 365687 == -194763)
							{
								this.$tDir$35199 = tDir;
								if (202047 - 534424 == -332377)
								{
									this.$self_$35200 = self_;
									if (113209 - 368908 != -255698)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005951 RID: 22865 RVA: 0x00ABAF88 File Offset: 0x00AB9188
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (139521 - 499456 != -359934)
				{
				}
				for (;;)
				{
					IL_98:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_AC6;
					case 2:
						if (this.$self_$35200.mChar.actionState != "attack")
						{
							if (53611 - 592861 != -539250)
							{
								continue;
							}
							goto IL_1AF;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_D5;
							}
							if (285811 - 83709 == 202103)
							{
								continue;
							}
							if (!this.$self_$35200.mChar.isMine)
							{
								if (58790 - 531865 == -473074)
								{
									continue;
								}
								if (Game.mGameType <= 4)
								{
									goto IL_D5;
								}
								if (217147 - 516923 == -299775)
								{
									continue;
								}
								if (Game.mTeam != this.$self_$35200.mChar.mOriginalLayer - 7)
								{
									goto IL_D5;
								}
								if (148904 - 382622 == -233717)
								{
									continue;
								}
							}
							if (!this.$self_$35200.jrfctzOka3Y)
							{
								if (183473 - 237637 == -54163)
								{
									continue;
								}
								this.$self_$35200.jrfctzOka3Y = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Bison/Voices/nAttack1", typeof(AudioClip));
								if (204895 - 415220 != -210325)
								{
									continue;
								}
							}
							if (this.$self_$35200.jrfctzOka3Y)
							{
								if (81666 - 102170 != -20504)
								{
									continue;
								}
								goto IL_750;
							}
							else
							{
								Debug.LogError("Cannot find bison_rAttack voice");
								if (243154 - 23119 != 220035)
								{
									continue;
								}
								goto IL_D5;
							}
						}
						break;
					case 3:
						if (this.$self_$35200.mChar.actionState != "attack")
						{
							if (157177 - 393128 != -235951)
							{
								continue;
							}
							goto IL_407;
						}
						else
						{
							if (!this.$self_$35200.mGUctK8xkBq)
							{
								if (2985 - 286918 == -283932)
								{
									continue;
								}
								this.$self_$35200.mGUctK8xkBq = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/bison_rAttack", typeof(GameObject));
								if (202812 - 482919 == -280106)
								{
									continue;
								}
							}
							if (this.$self_$35200.mGUctK8xkBq)
							{
								if (87845 - 225298 != -137453)
								{
									continue;
								}
								this.$self_$35200.mChar.createEffect(this.$self_$35200.mGUctK8xkBq, this.$self_$35200.transform.position, this.$self_$35200.transform.rotation);
								if (26487 - 554136 != -527649)
								{
									continue;
								}
								goto IL_6ED;
							}
							else
							{
								Debug.LogError("Cannot find rAttack_bison effect");
								if (96238 - 348051 != -251813)
								{
									continue;
								}
								goto IL_938;
							}
						}
						break;
					case 4:
						if (this.$self_$35200.mChar.actionState != "attack")
						{
							if (74876 - 341494 != -266617)
							{
								goto Block_61;
							}
							continue;
						}
						else
						{
							if (!this.$self_$35200.mChar.isMine)
							{
								goto IL_A19;
							}
							if (64102 - 77727 == -13624)
							{
								continue;
							}
							this.$hitLayer$35193 = 130816 - (1 << this.$self_$35200.gameObject.layer);
							if (188953 - 29258 == 159696)
							{
								continue;
							}
							this.$hitList$35194 = Damage.FindAreaTarget(this.$self_$35200.transform.position, (float)8, (float)3, this.$hitLayer$35193);
							if (106587 - 38172 == 68416)
							{
								continue;
							}
							this.$$iterator$10565$35197 = UnityRuntimeServices.GetEnumerator(this.$hitList$35194);
							if (71043 - 462405 != -391362)
							{
								continue;
							}
							while (this.$$iterator$10565$35197.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10565$35197.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$35195 = (GameObject)obj2;
								if (35376 - 522077 != -486701)
								{
									goto IL_98;
								}
								if (this.$self_$35200.mChar.hit(22, this.$hitObject$35195, (int)(1.6f * (float)this.$self_$35200.mChar.atk), 1, 0, Vector3.zero) != 0)
								{
									if (195797 - 135084 == 60714)
									{
										goto IL_98;
									}
									this.$hitPos$35196 = this.$hitObject$35195.collider.ClosestPointOnBounds(this.$self_$35200.transform.position + (float)2 * Vector3.up);
									if (45857 - 84783 != -38926)
									{
										goto IL_98;
									}
									UnityRuntimeServices.Update(this.$$iterator$10565$35197, this.$hitObject$35195);
									if (86221 - 230032 == -143810)
									{
										goto IL_98;
									}
									this.$self_$35200.RPC_nAttack_bison_hit(this.$hitPos$35196, this.$self_$35200.transform.forward, 0);
									if (112321 - 332172 == -219850)
									{
										goto IL_98;
									}
									this.$self_$35200.ActionEvent("RPC_nAttack_bison_hit", this.$hitPos$35196, this.$self_$35200.transform.forward, 0);
									if (42715 - 419324 != -376609)
									{
										goto IL_98;
									}
								}
							}
							if (1428 - 446219 != -444791)
							{
								continue;
							}
							goto IL_A19;
						}
						break;
					case 5:
						if (this.$self_$35200.mChar.actionState == "attack")
						{
							if (223309 - 298842 == -75532)
							{
								continue;
							}
							if (this.$self_$35200.mChar.myCommand == "rAttack")
							{
								if (134316 - 433909 != -299593)
								{
									continue;
								}
								this.$self_$35200.mChar.actionState = "standby";
								if (1244 - 367685 != -366441)
								{
									continue;
								}
								this.$self_$35200.mChar.actionTime = Time.time;
								if (94054 - 111896 == -17841)
								{
									continue;
								}
								this.$self_$35200.mChar.myCommand = "none";
								if (230178 - 315462 != -85284)
								{
									continue;
								}
								if (!this.$self_$35200.mChar.isMine)
								{
									if (18106 - 337921 == -319814)
									{
										continue;
									}
									this.$self_$35200.mChar.nPosition = this.$self_$35200.transform.position;
									if (167481 - 63749 != 103732)
									{
										continue;
									}
									this.$self_$35200.mChar.oPosition = this.$self_$35200.transform.position;
									if (112752 - 431497 != -318745)
									{
										continue;
									}
									this.$self_$35200.mChar.nDirection = this.$self_$35200.transform.forward;
									if (13104 - 492568 == -479463)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (232306 - 431642 != -199336)
						{
							continue;
						}
						goto IL_AC6;
					default:
						if (5212 - 13699 == -8486)
						{
							continue;
						}
						break;
					}
					this.$self_$35200.mChar.actionState = "attack";
					if (103448 - 469907 != -366458)
					{
						this.$self_$35200.mChar.actionTime = Time.time;
						if (41841 - 185750 != -143908)
						{
							this.$self_$35200.mChar.myCommand = "rAttack";
							if (66683 - 435621 != -368937)
							{
								this.$self_$35200.mChar.addTimeOut("nAttack", 1.5f);
								if (25449 - 52142 == -26693)
								{
									this.$self_$35200.transform.position = this.$mPos$35198;
									if (155878 - 105397 != 50482)
									{
										this.$self_$35200.transform.LookAt(this.$mPos$35198 + global::Math.vFlat(this.$tDir$35199));
										if (141926 - 519110 == -377184)
										{
											this.$self_$35200.animation.CrossFade("rAttack", 0.2f);
											if (267225 - 298476 != -31250)
											{
												this.$self_$35200.animation.wrapMode = WrapMode.Once;
												if (109673 - 588590 != -478916)
												{
													this.$self_$35200.mChar.vMovement = this.$self_$35200.transform.forward;
													if (256510 - 122505 != 134006)
													{
														this.$self_$35200.mChar.moveSpeed = (float)8;
														if (11696 - 486386 == -474690)
														{
															goto IL_3B8;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_D5:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_1AF:
				goto IL_AC6;
				IL_3B8:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_407:
				goto IL_AC6;
				IL_6ED:
				goto IL_938;
				IL_750:
				this.$self_$35200.audio.PlayOneShot(this.$self_$35200.jrfctzOka3Y, (!this.$self_$35200.mChar.isMine) ? 0.75f : ((float)1));
				goto IL_D5;
				IL_938:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_61:
				goto IL_AC6;
				IL_A19:
				return this.Yield(5, new WaitForSeconds(0.3f));
				IL_AC6:
				return false;
			}

			// Token: 0x06005952 RID: 22866 RVA: 0x00ABBA70 File Offset: 0x00AB9C70
			internal static bool NI8Zn9ppnq4NGnCgNo49()
			{
				return true;
			}

			// Token: 0x06005953 RID: 22867 RVA: 0x00ABBA74 File Offset: 0x00AB9C74
			internal static bool tLP3gWpp6OfmMkyHWkST()
			{
				return false;
			}

			// Token: 0x04006229 RID: 25129
			internal int $hitLayer$35193;

			// Token: 0x0400622A RID: 25130
			internal UnityScript.Lang.Array $hitList$35194;

			// Token: 0x0400622B RID: 25131
			internal GameObject $hitObject$35195;

			// Token: 0x0400622C RID: 25132
			internal Vector3 $hitPos$35196;

			// Token: 0x0400622D RID: 25133
			internal IEnumerator $$iterator$10565$35197;

			// Token: 0x0400622E RID: 25134
			internal Vector3 $mPos$35198;

			// Token: 0x0400622F RID: 25135
			internal Vector3 $tDir$35199;

			// Token: 0x04006230 RID: 25136
			internal PvpMount $self_$35200;
		}
	}

	// Token: 0x02000F55 RID: 3925
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_panda$35204 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005954 RID: 22868 RVA: 0x00ABBA78 File Offset: 0x00AB9C78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_panda$35204(Vector3 mPos, Vector3 tDir, PvpMount self_)
		{
			if (133570 - 484250 != -350679)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (181568 - 141541 != 40028)
				{
					base..ctor();
					if (138681 - 254261 != -115579)
					{
						this.$mPos$35214 = mPos;
						if (298154 - 119979 != 178176)
						{
							this.$tDir$35215 = tDir;
							if (207799 - 94686 == 113113)
							{
								this.$self_$35216 = self_;
								if (208363 - 351242 == -142879)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005955 RID: 22869 RVA: 0x00ABBB54 File Offset: 0x00AB9D54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PvpMount.$RPC_nAttack_panda$35204.$(this.$mPos$35214, this.$tDir$35215, this.$self_$35216);
		}

		// Token: 0x06005956 RID: 22870 RVA: 0x00ABBB70 File Offset: 0x00AB9D70
		internal static bool cafuDSppiuUc9NhwaUnw()
		{
			return true;
		}

		// Token: 0x06005957 RID: 22871 RVA: 0x00ABBB74 File Offset: 0x00AB9D74
		internal static bool wIe2qXppKlPcmfFGM0Rr()
		{
			return false;
		}

		// Token: 0x04006231 RID: 25137
		internal Vector3 $mPos$35214;

		// Token: 0x04006232 RID: 25138
		internal Vector3 $tDir$35215;

		// Token: 0x04006233 RID: 25139
		internal PvpMount $self_$35216;

		// Token: 0x02000F56 RID: 3926
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005958 RID: 22872 RVA: 0x00ABBB78 File Offset: 0x00AB9D78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PvpMount self_)
			{
				if (2907 - 102000 != -99093)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (272815 - 118861 != 153955)
					{
						base..ctor();
						if (82078 - 457961 != -375882)
						{
							this.$mPos$35211 = mPos;
							if (138591 - 233515 != -94923)
							{
								this.$tDir$35212 = tDir;
								if (196832 - 478471 == -281639)
								{
									this.$self_$35213 = self_;
									if (91838 - 219701 == -127863)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005959 RID: 22873 RVA: 0x00ABBC54 File Offset: 0x00AB9E54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (98358 - 562471 != -464113)
				{
				}
				for (;;)
				{
					IL_549:
					switch (this._state)
					{
					case 0:
						goto IL_78D;
					case 1:
						goto IL_AE3;
					case 2:
						if (this.$self_$35213.mChar.actionState != "attack")
						{
							if (246557 - 140571 != 105987)
							{
								goto Block_60;
							}
							continue;
						}
						else
						{
							if (!this.$self_$35213.FuPcXQHsEjH)
							{
								if (103384 - 376246 != -272862)
								{
									continue;
								}
								this.$self_$35213.FuPcXQHsEjH = (AudioClip)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Sounds/panda_nAttack", typeof(AudioClip));
								if (94672 - 480624 == -385951)
								{
									continue;
								}
							}
							if (this.$self_$35213.FuPcXQHsEjH)
							{
								if (115548 - 295574 == -180025)
								{
									continue;
								}
								this.$self_$35213.audio.PlayOneShot(this.$self_$35213.FuPcXQHsEjH, 1f);
								if (206060 - 6459 == 199602)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing panda_nAttackFx sounds");
								if (140646 - 231366 != -90720)
								{
									continue;
								}
							}
							if (PlayerPrefs.GetInt("pvoice", 1) != 0)
							{
								if (71482 - 228215 == -156732)
								{
									continue;
								}
								if (!this.$self_$35213.mChar.isMine)
								{
									if (54562 - 562375 != -507813)
									{
										continue;
									}
									if (Game.mGameType <= 4)
									{
										goto IL_3CD;
									}
									if (279958 - 437205 == -157246)
									{
										continue;
									}
									if (Game.mTeam != this.$self_$35213.mChar.mOriginalLayer - 7)
									{
										goto IL_3CD;
									}
									if (136521 - 423109 != -286588)
									{
										continue;
									}
								}
								if (!this.$self_$35213.BUncXeSXb1j)
								{
									if (22456 - 363778 == -341321)
									{
										continue;
									}
									this.$self_$35213.BUncXeSXb1j = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Panda/Voices/nAttack1", typeof(AudioClip));
									if (291796 - 388154 == -96357)
									{
										continue;
									}
								}
								if (this.$self_$35213.BUncXeSXb1j)
								{
									if (98517 - 193325 != -94808)
									{
										continue;
									}
									this.$self_$35213.audio.PlayOneShot(this.$self_$35213.BUncXeSXb1j, (!this.$self_$35213.mChar.isMine) ? 0.75f : ((float)1));
								}
								else
								{
									Debug.LogError("Cannot find panda_nAttack_vc voice");
									if (55224 - 565584 == -510359)
									{
										continue;
									}
								}
							}
							IL_3CD:
							this.$i$35205 = 0;
							if (29914 - 130134 == -100219)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$35213.mChar.actionState != "attack")
						{
							if (157076 - 394774 != -237697)
							{
								goto Block_43;
							}
							continue;
						}
						else
						{
							if (this.$self_$35213.mChar.isMine)
							{
								if (241664 - 17594 != 224070)
								{
									continue;
								}
								this.$hitLayer$35206 = 130816 - (1 << this.$self_$35213.gameObject.layer);
								if (63404 - 136284 != -72880)
								{
									continue;
								}
								this.$hitList$35207 = Damage.FindRecTarget(this.$self_$35213.transform.position, this.$self_$35213.transform.forward, (float)1, (float)1, (float)3, (float)3, this.$hitLayer$35206);
								if (292922 - 52027 == 240896)
								{
									continue;
								}
								this.$$iterator$10558$35210 = UnityRuntimeServices.GetEnumerator(this.$hitList$35207);
								if (162620 - 518474 == -355853)
								{
									continue;
								}
								while (this.$$iterator$10558$35210.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10558$35210.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$35208 = (GameObject)obj2;
									if (242180 - 233257 == 8924)
									{
										goto IL_549;
									}
									if (this.$self_$35213.mChar.hit(1, this.$hitObject$35208, this.$self_$35213.mChar.atk, 1, 0, 0.3f * this.$self_$35213.transform.forward) != 0)
									{
										if (275868 - 257112 == 18757)
										{
											goto IL_549;
										}
										this.$hitPos$35209 = this.$hitObject$35208.collider.ClosestPointOnBounds(this.$self_$35213.transform.position + (float)2 * Vector3.up);
										if (59611 - 364874 == -305262)
										{
											goto IL_549;
										}
										UnityRuntimeServices.Update(this.$$iterator$10558$35210, this.$hitObject$35208);
										if (57571 - 563630 == -506058)
										{
											goto IL_549;
										}
										this.$self_$35213.RPC_nAttack_panda_hit(this.$hitPos$35209, this.$self_$35213.transform.forward, 0);
										if (6287 - 119588 == -113300)
										{
											goto IL_549;
										}
										this.$self_$35213.ActionEvent("RPC_nAttack_panda_hit", this.$hitPos$35209, this.$self_$35213.transform.forward, 0);
										if (264868 - 26885 == 237984)
										{
											goto IL_549;
										}
									}
								}
								if (202648 - 238812 == -36163)
								{
									continue;
								}
							}
							this.$i$35205++;
							if (136393 - 415079 != -278686)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$35213.mChar.actionState == "attack")
						{
							if (119634 - 1132 != 118502)
							{
								continue;
							}
							if (this.$self_$35213.mChar.myCommand == "nAttack")
							{
								if (70139 - 546073 != -475934)
								{
									continue;
								}
								this.$self_$35213.mChar.actionState = "standby";
								if (96281 - 432709 == -336427)
								{
									continue;
								}
								this.$self_$35213.mChar.actionTime = Time.time;
								if (52604 - 127842 != -75238)
								{
									continue;
								}
								this.$self_$35213.mChar.myCommand = "none";
								if (107791 - 251661 == -143869)
								{
									continue;
								}
								if (!this.$self_$35213.mChar.isMine)
								{
									if (207230 - 113051 == 94180)
									{
										continue;
									}
									this.$self_$35213.mChar.nPosition = this.$self_$35213.transform.position;
									if (67517 - 135455 == -67937)
									{
										continue;
									}
									this.$self_$35213.mChar.oPosition = this.$self_$35213.transform.position;
									if (263432 - 125890 != 137542)
									{
										continue;
									}
									this.$self_$35213.mChar.nDirection = this.$self_$35213.transform.forward;
									if (33677 - 384193 == -350515)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (12933 - 564237 != -551303)
						{
							goto Block_62;
						}
						continue;
					default:
						if (181829 - 446938 != -265109)
						{
							continue;
						}
						goto IL_78D;
					}
					if (this.$i$35205 < 2)
					{
						goto IL_67D;
					}
					if (200361 - 457655 != -257294)
					{
						continue;
					}
					break;
					IL_78D:
					this.$self_$35213.mChar.actionState = "attack";
					if (113944 - 418047 == -304103)
					{
						this.$self_$35213.mChar.actionTime = Time.time;
						if (226571 - 292728 == -66157)
						{
							this.$self_$35213.mChar.myCommand = "nAttack";
							if (216186 - 453985 != -237798)
							{
								this.$self_$35213.mChar.addTimeOut("nAttack", (float)2);
								if (273022 - 310327 == -37305)
								{
									this.$self_$35213.transform.position = this.$mPos$35211;
									if (91134 - 269621 == -178487)
									{
										this.$self_$35213.transform.LookAt(this.$mPos$35211 + global::Math.vFlat(this.$tDir$35212));
										if (270579 - 335447 == -64868)
										{
											this.$self_$35213.animation.CrossFade("nAttack", 0.2f);
											if (236296 - 15889 == 220407)
											{
												this.$self_$35213.animation.wrapMode = WrapMode.Once;
												if (266811 - 123236 != 143576)
												{
													this.$self_$35213.mChar.vMovement = this.$self_$35213.transform.forward;
													if (108432 - 488683 != -380250)
													{
														this.$self_$35213.mChar.moveSpeed = (float)0;
														if (279643 - 322654 != -43010)
														{
															goto Block_38;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(4, new WaitForSeconds(0.4f));
				Block_38:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_67D:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_43:
				Block_60:
				Block_62:
				IL_AE3:
				return false;
			}

			// Token: 0x0600595A RID: 22874 RVA: 0x00ABC758 File Offset: 0x00ABA958
			internal static bool cs5ohLppdSknZCTJPRa2()
			{
				return true;
			}

			// Token: 0x0600595B RID: 22875 RVA: 0x00ABC75C File Offset: 0x00ABA95C
			internal static bool ESEqNnppJ9d08CTdfFT7()
			{
				return false;
			}

			// Token: 0x04006234 RID: 25140
			internal int $i$35205;

			// Token: 0x04006235 RID: 25141
			internal int $hitLayer$35206;

			// Token: 0x04006236 RID: 25142
			internal UnityScript.Lang.Array $hitList$35207;

			// Token: 0x04006237 RID: 25143
			internal GameObject $hitObject$35208;

			// Token: 0x04006238 RID: 25144
			internal Vector3 $hitPos$35209;

			// Token: 0x04006239 RID: 25145
			internal IEnumerator $$iterator$10558$35210;

			// Token: 0x0400623A RID: 25146
			internal Vector3 $mPos$35211;

			// Token: 0x0400623B RID: 25147
			internal Vector3 $tDir$35212;

			// Token: 0x0400623C RID: 25148
			internal PvpMount $self_$35213;
		}
	}

	// Token: 0x02000F57 RID: 3927
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_panda$35217 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600595C RID: 22876 RVA: 0x00ABC760 File Offset: 0x00ABA960
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_panda$35217(Vector3 mPos, Vector3 tDir, PvpMount self_)
		{
			if (32293 - 143767 != -111474)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (239859 - 381410 != -141550)
				{
					base..ctor();
					if (178482 - 88582 != 89901)
					{
						this.$mPos$35226 = mPos;
						if (172975 - 289154 != -116178)
						{
							this.$tDir$35227 = tDir;
							if (260564 - 349445 != -88880)
							{
								this.$self_$35228 = self_;
								if (70179 - 103997 != -33817)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600595D RID: 22877 RVA: 0x00ABC83C File Offset: 0x00ABAA3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PvpMount.$RPC_rAttack_panda$35217.$(this.$mPos$35226, this.$tDir$35227, this.$self_$35228);
		}

		// Token: 0x0600595E RID: 22878 RVA: 0x00ABC858 File Offset: 0x00ABAA58
		internal static bool BKq69QppDHHj45ZrGsWE()
		{
			return true;
		}

		// Token: 0x0600595F RID: 22879 RVA: 0x00ABC85C File Offset: 0x00ABAA5C
		internal static bool MhpCnpppv0oHZPj3sZ5f()
		{
			return false;
		}

		// Token: 0x0400623D RID: 25149
		internal Vector3 $mPos$35226;

		// Token: 0x0400623E RID: 25150
		internal Vector3 $tDir$35227;

		// Token: 0x0400623F RID: 25151
		internal PvpMount $self_$35228;

		// Token: 0x02000F58 RID: 3928
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005960 RID: 22880 RVA: 0x00ABC860 File Offset: 0x00ABAA60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PvpMount self_)
			{
				if (289492 - 293476 != -3983)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (7440 - 424254 == -416814)
					{
						base..ctor();
						if (96527 - 370547 != -274019)
						{
							this.$mPos$35223 = mPos;
							if (181139 - 149698 != 31442)
							{
								this.$tDir$35224 = tDir;
								if (55738 - 79218 != -23479)
								{
									this.$self_$35225 = self_;
									if (38598 - 333409 == -294811)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005961 RID: 22881 RVA: 0x00ABC93C File Offset: 0x00ABAB3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (30591 - 107363 != -76772)
				{
				}
				for (;;)
				{
					IL_83C:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A07;
					case 2:
						if (this.$self_$35225.mChar.actionState != "attack")
						{
							if (280078 - 42514 != 237565)
							{
								goto Block_33;
							}
							continue;
						}
						else
						{
							if (!this.$self_$35225.YgbcXJdQfA0)
							{
								if (283007 - 528255 != -245248)
								{
									continue;
								}
								this.$self_$35225.YgbcXJdQfA0 = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/panda_rAttack", typeof(GameObject));
								if (97918 - 218576 != -120658)
								{
									continue;
								}
							}
							if (this.$self_$35225.YgbcXJdQfA0)
							{
								if (204468 - 323215 != -118747)
								{
									continue;
								}
								this.$self_$35225.mChar.createEffect(this.$self_$35225.YgbcXJdQfA0, this.$self_$35225.transform.position, this.$self_$35225.transform.rotation);
								if (41237 - 211615 != -170378)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find panda_rAttack effect");
								if (46216 - 318175 != -271959)
								{
									continue;
								}
							}
							this.$i$35218 = 0;
							if (89495 - 552961 != -463466)
							{
								continue;
							}
							goto IL_6CF;
						}
						break;
					case 3:
						if (this.$self_$35225.mChar.actionState != "attack")
						{
							if (280018 - 202542 != 77477)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							if (this.$self_$35225.mChar.isMine)
							{
								if (270912 - 341565 != -70653)
								{
									continue;
								}
								this.$hitLayer$35219 = 130816 - (1 << this.$self_$35225.gameObject.layer);
								if (192031 - 94985 != 97046)
								{
									continue;
								}
								this.$hitList$35220 = Damage.FindAreaTarget(this.$self_$35225.transform.position, (float)6, (float)3, this.$hitLayer$35219);
								if (49875 - 240225 == -190349)
								{
									continue;
								}
								this.$$iterator$10566$35222 = UnityRuntimeServices.GetEnumerator(this.$hitList$35220);
								if (247734 - 313545 == -65810)
								{
									continue;
								}
								while (this.$$iterator$10566$35222.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10566$35222.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$35221 = (GameObject)obj2;
									if (260576 - 149139 == 111438)
									{
										goto IL_83C;
									}
									this.$self_$35225.mChar.hit(1, this.$hitObject$35221, this.$self_$35225.mChar.atk, 1, 0, Vector3.zero);
									if (65429 - 128031 != -62602)
									{
										goto IL_83C;
									}
									UnityRuntimeServices.Update(this.$$iterator$10566$35222, this.$hitObject$35221);
									if (36422 - 301331 == -264908)
									{
										goto IL_83C;
									}
								}
								if (239044 - 263467 != -24423)
								{
									continue;
								}
							}
							this.$i$35218++;
							if (111782 - 174424 != -62641)
							{
								goto IL_6CF;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$35225.mChar.actionState == "attack")
						{
							if (82060 - 496573 == -414512)
							{
								continue;
							}
							if (this.$self_$35225.mChar.myCommand == "rAttack")
							{
								if (22049 - 239770 != -217721)
								{
									continue;
								}
								this.$self_$35225.mChar.actionState = "standby";
								if (273296 - 299239 == -25942)
								{
									continue;
								}
								this.$self_$35225.mChar.actionTime = Time.time;
								if (78866 - 70643 == 8224)
								{
									continue;
								}
								this.$self_$35225.mChar.myCommand = "none";
								if (33361 - 136732 == -103370)
								{
									continue;
								}
								if (!this.$self_$35225.mChar.isMine)
								{
									if (124395 - 471622 == -347226)
									{
										continue;
									}
									this.$self_$35225.mChar.nPosition = this.$self_$35225.transform.position;
									if (34422 - 155772 == -121349)
									{
										continue;
									}
									this.$self_$35225.mChar.oPosition = this.$self_$35225.transform.position;
									if (69206 - 511401 == -442194)
									{
										continue;
									}
									this.$self_$35225.mChar.nDirection = this.$self_$35225.transform.forward;
									if (183915 - 499778 == -315862)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (238609 - 523457 != -284848)
						{
							continue;
						}
						goto IL_A07;
					default:
						if (64015 - 587210 != -523195)
						{
							continue;
						}
						break;
					}
					this.$self_$35225.mChar.actionState = "attack";
					if (30 - 124565 != -124535)
					{
						continue;
					}
					this.$self_$35225.mChar.actionTime = Time.time;
					if (155003 - 416652 != -261649)
					{
						continue;
					}
					this.$self_$35225.mChar.myCommand = "rAttack";
					if (100086 - 584986 != -484900)
					{
						continue;
					}
					this.$self_$35225.mChar.addTimeOut("nAttack", 1.5f);
					if (273419 - 598453 == -325033)
					{
						continue;
					}
					this.$self_$35225.transform.position = this.$mPos$35223;
					if (176959 - 573985 != -397026)
					{
						continue;
					}
					this.$self_$35225.transform.LookAt(this.$mPos$35223 + global::Math.vFlat(this.$tDir$35224));
					if (42527 - 435314 != -392787)
					{
						continue;
					}
					this.$self_$35225.animation.CrossFade("rAttack", 0.2f);
					if (12452 - 298187 == -285734)
					{
						continue;
					}
					this.$self_$35225.animation.wrapMode = WrapMode.Once;
					if (194396 - 406022 == -211625)
					{
						continue;
					}
					this.$self_$35225.mChar.vMovement = this.$self_$35225.transform.forward;
					if (45448 - 338502 == -293053)
					{
						continue;
					}
					this.$self_$35225.mChar.moveSpeed = (float)8;
					if (219761 - 520983 != -301222)
					{
						continue;
					}
					if (PlayerPrefs.GetInt("pvoice", 1) == 0)
					{
						goto IL_4C6;
					}
					if (202230 - 100814 == 101417)
					{
						continue;
					}
					if (!this.$self_$35225.mChar.isMine)
					{
						if (12229 - 97657 != -85428)
						{
							continue;
						}
						if (Game.mGameType <= 4)
						{
							goto IL_4C6;
						}
						if (173930 - 529844 == -355913)
						{
							continue;
						}
						if (Game.mTeam != this.$self_$35225.mChar.mOriginalLayer - 7)
						{
							goto IL_4C6;
						}
						if (116624 - 402929 != -286305)
						{
							continue;
						}
					}
					if (!this.$self_$35225.e36cX6PIYbJ)
					{
						if (53168 - 239898 != -186730)
						{
							continue;
						}
						this.$self_$35225.e36cX6PIYbJ = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Panda/Voices/nAttack3", typeof(AudioClip));
						if (51224 - 563332 != -512108)
						{
							continue;
						}
					}
					if (this.$self_$35225.e36cX6PIYbJ)
					{
						if (7247 - 365756 != -358508)
						{
							goto Block_28;
						}
						continue;
					}
					else
					{
						Debug.LogError("Cannot find panda_rAttack_vc voice");
						if (249340 - 393759 != -144419)
						{
							continue;
						}
						goto IL_4C6;
					}
					IL_6CF:
					if (this.$i$35218 < 2)
					{
						break;
					}
					if (2135 - 162425 != -160289)
					{
						goto Block_46;
					}
				}
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_18:
				goto IL_A07;
				Block_28:
				this.$self_$35225.audio.PlayOneShot(this.$self_$35225.e36cX6PIYbJ, (!this.$self_$35225.mChar.isMine) ? 0.75f : ((float)1));
				IL_4C6:
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_33:
				goto IL_A07;
				Block_46:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_A07:
				return false;
			}

			// Token: 0x06005962 RID: 22882 RVA: 0x00ABD364 File Offset: 0x00ABB564
			internal static bool AFknVOppRAExMiQfCi32()
			{
				return true;
			}

			// Token: 0x06005963 RID: 22883 RVA: 0x00ABD368 File Offset: 0x00ABB568
			internal static bool HGhJrLppwjVWuoAaM1nG()
			{
				return false;
			}

			// Token: 0x04006240 RID: 25152
			internal int $i$35218;

			// Token: 0x04006241 RID: 25153
			internal int $hitLayer$35219;

			// Token: 0x04006242 RID: 25154
			internal UnityScript.Lang.Array $hitList$35220;

			// Token: 0x04006243 RID: 25155
			internal GameObject $hitObject$35221;

			// Token: 0x04006244 RID: 25156
			internal IEnumerator $$iterator$10566$35222;

			// Token: 0x04006245 RID: 25157
			internal Vector3 $mPos$35223;

			// Token: 0x04006246 RID: 25158
			internal Vector3 $tDir$35224;

			// Token: 0x04006247 RID: 25159
			internal PvpMount $self_$35225;
		}
	}

	// Token: 0x02000F59 RID: 3929
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_whale$35229 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005964 RID: 22884 RVA: 0x00ABD36C File Offset: 0x00ABB56C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_whale$35229(Vector3 mPos, Vector3 tDir, PvpMount self_)
		{
			if (143653 - 437754 != -294101)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (266862 - 119842 != 147021)
				{
					base..ctor();
					if (271743 - 481563 == -209820)
					{
						this.$mPos$35238 = mPos;
						if (124754 - 351849 == -227095)
						{
							this.$tDir$35239 = tDir;
							if (263766 - 105913 == 157853)
							{
								this.$self_$35240 = self_;
								if (27374 - 196200 != -168825)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005965 RID: 22885 RVA: 0x00ABD448 File Offset: 0x00ABB648
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PvpMount.$RPC_nAttack_whale$35229.$(this.$mPos$35238, this.$tDir$35239, this.$self_$35240);
		}

		// Token: 0x06005966 RID: 22886 RVA: 0x00ABD464 File Offset: 0x00ABB664
		internal static bool GwLnlwppqrbmpoRhJJBR()
		{
			return true;
		}

		// Token: 0x06005967 RID: 22887 RVA: 0x00ABD468 File Offset: 0x00ABB668
		internal static bool eaNPFbpp76cmBQvp5pgr()
		{
			return false;
		}

		// Token: 0x04006248 RID: 25160
		internal Vector3 $mPos$35238;

		// Token: 0x04006249 RID: 25161
		internal Vector3 $tDir$35239;

		// Token: 0x0400624A RID: 25162
		internal PvpMount $self_$35240;

		// Token: 0x02000F5A RID: 3930
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005968 RID: 22888 RVA: 0x00ABD46C File Offset: 0x00ABB66C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PvpMount self_)
			{
				if (234719 - 257293 != -22574)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (120513 - 573411 != -452897)
					{
						base..ctor();
						if (103441 - 325340 == -221899)
						{
							this.$mPos$35235 = mPos;
							if (225320 - 416581 != -191260)
							{
								this.$tDir$35236 = tDir;
								if (299722 - 33349 != 266374)
								{
									this.$self_$35237 = self_;
									if (236010 - 104664 != 131347)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005969 RID: 22889 RVA: 0x00ABD548 File Offset: 0x00ABB748
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (153361 - 259161 != -105799)
				{
				}
				for (;;)
				{
					IL_64F:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_AAC;
					case 2:
						if (this.$self_$35237.mChar.actionState != "attack")
						{
							if (136315 - 381592 != -245277)
							{
								continue;
							}
							goto IL_30D;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) != 0)
							{
								if (82864 - 391448 == -308583)
								{
									continue;
								}
								if (!this.$self_$35237.mChar.isMine)
								{
									if (191202 - 198460 != -7258)
									{
										continue;
									}
									if (Game.mGameType <= 4)
									{
										goto IL_53F;
									}
									if (52500 - 471691 != -419191)
									{
										continue;
									}
									if (Game.mTeam != this.$self_$35237.mChar.mOriginalLayer - 7)
									{
										goto IL_53F;
									}
									if (173443 - 521877 != -348434)
									{
										continue;
									}
								}
								if (!this.$self_$35237.J9ycXXX8b5y)
								{
									if (216955 - 93541 == 123415)
									{
										continue;
									}
									this.$self_$35237.J9ycXXX8b5y = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Whale/Voices/nAttack1", typeof(AudioClip));
									if (239546 - 231909 != 7637)
									{
										continue;
									}
								}
								if (this.$self_$35237.J9ycXXX8b5y)
								{
									if (165459 - 34496 == 130964)
									{
										continue;
									}
									this.$self_$35237.audio.PlayOneShot(this.$self_$35237.J9ycXXX8b5y, (!this.$self_$35237.mChar.isMine) ? 0.75f : ((float)1));
								}
								else
								{
									Debug.LogError("Cannot find whale_nAttack voice");
									if (193124 - 375132 != -182008)
									{
										continue;
									}
								}
							}
							IL_53F:
							if (!this.$self_$35237.GLMcXtZvLOd)
							{
								if (247011 - 42246 == 204766)
								{
									continue;
								}
								this.$self_$35237.GLMcXtZvLOd = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/whale_nAttack", typeof(GameObject));
								if (32344 - 332449 != -300105)
								{
									continue;
								}
							}
							if (this.$self_$35237.GLMcXtZvLOd)
							{
								if (284586 - 84806 != 199780)
								{
									continue;
								}
								this.$self_$35237.mChar.createEffect(this.$self_$35237.GLMcXtZvLOd, this.$self_$35237.transform.position, this.$self_$35237.transform.rotation);
								if (208806 - 316645 != -107838)
								{
									goto Block_7;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find whale_nAttack effect");
								if (110878 - 360557 != -249679)
								{
									continue;
								}
								goto IL_A5D;
							}
						}
						break;
					case 3:
						if (this.$self_$35237.mChar.actionState != "attack")
						{
							if (219245 - 23611 != 195634)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							if (!this.$self_$35237.mChar.isMine)
							{
								goto IL_1F7;
							}
							if (109202 - 188164 == -78961)
							{
								continue;
							}
							this.$hitLayer$35230 = 130816 - (1 << this.$self_$35237.gameObject.layer);
							if (138259 - 200692 != -62433)
							{
								continue;
							}
							this.$hitList$35231 = Damage.FindRecTarget(this.$self_$35237.transform.position, this.$self_$35237.transform.forward, (float)4, (float)3, (float)4, (float)4, this.$hitLayer$35230);
							if (268880 - 178100 == 90781)
							{
								continue;
							}
							this.$$iterator$10559$35234 = UnityRuntimeServices.GetEnumerator(this.$hitList$35231);
							if (230599 - 409583 == -178983)
							{
								continue;
							}
							while (this.$$iterator$10559$35234.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10559$35234.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$35232 = (GameObject)obj2;
								if (102220 - 398575 == -296354)
								{
									goto IL_64F;
								}
								if (this.$self_$35237.mChar.hit(24, this.$hitObject$35232, this.$self_$35237.mChar.atk, 1, 0, 0.5f * (this.$hitObject$35232.transform.position - this.$self_$35237.transform.position).normalized) != 0)
								{
									if (12101 - 336879 == -324777)
									{
										goto IL_64F;
									}
									this.$hitPos$35233 = this.$hitObject$35232.collider.ClosestPointOnBounds(this.$self_$35237.transform.position + (float)2 * Vector3.up);
									if (299403 - 245287 == 54117)
									{
										goto IL_64F;
									}
									UnityRuntimeServices.Update(this.$$iterator$10559$35234, this.$hitObject$35232);
									if (58837 - 83138 == -24300)
									{
										goto IL_64F;
									}
									this.$self_$35237.RPC_nAttack_whale_hit(this.$hitPos$35233, this.$self_$35237.transform.forward, 0);
									if (879 - 362637 == -361757)
									{
										goto IL_64F;
									}
									this.$self_$35237.ActionEvent("RPC_nAttack_whale_hit", this.$hitPos$35233, this.$self_$35237.transform.forward, 0);
									if (99629 - 197349 == -97719)
									{
										goto IL_64F;
									}
								}
							}
							if (99564 - 81868 != 17697)
							{
								goto Block_21;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$35237.mChar.actionState == "attack")
						{
							if (181341 - 298526 != -117185)
							{
								continue;
							}
							if (this.$self_$35237.mChar.myCommand == "nAttack")
							{
								if (244449 - 447165 == -202715)
								{
									continue;
								}
								this.$self_$35237.mChar.actionState = "standby";
								if (213119 - 384205 == -171085)
								{
									continue;
								}
								this.$self_$35237.mChar.actionTime = Time.time;
								if (262135 - 335777 == -73641)
								{
									continue;
								}
								this.$self_$35237.mChar.myCommand = "none";
								if (112209 - 8679 == 103531)
								{
									continue;
								}
								if (!this.$self_$35237.mChar.isMine)
								{
									if (218656 - 542582 != -323926)
									{
										continue;
									}
									this.$self_$35237.mChar.nPosition = this.$self_$35237.transform.position;
									if (197822 - 378265 == -180442)
									{
										continue;
									}
									this.$self_$35237.mChar.oPosition = this.$self_$35237.transform.position;
									if (156060 - 211468 == -55407)
									{
										continue;
									}
									this.$self_$35237.mChar.nDirection = this.$self_$35237.transform.forward;
									if (55349 - 573174 != -517825)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (56345 - 464099 != -407753)
						{
							goto Block_8;
						}
						continue;
					default:
						if (271389 - 354263 == -82873)
						{
							continue;
						}
						break;
					}
					this.$self_$35237.mChar.actionState = "attack";
					if (138529 - 76808 != 61722)
					{
						this.$self_$35237.mChar.actionTime = Time.time;
						if (42658 - 531576 == -488918)
						{
							this.$self_$35237.mChar.myCommand = "nAttack";
							if (53679 - 147736 == -94057)
							{
								this.$self_$35237.mChar.addTimeOut("nAttack", 1.5f);
								if (177285 - 486562 == -309277)
								{
									this.$self_$35237.transform.position = this.$mPos$35235;
									if (50878 - 585471 == -534593)
									{
										this.$self_$35237.transform.LookAt(this.$mPos$35235 + global::Math.vFlat(this.$tDir$35236));
										if (192480 - 515078 == -322598)
										{
											this.$self_$35237.animation.CrossFade("nAttack", 0.2f);
											if (83484 - 531168 != -447683)
											{
												this.$self_$35237.animation.wrapMode = WrapMode.Once;
												if (259260 - 265587 != -6326)
												{
													this.$self_$35237.mChar.vMovement = this.$self_$35237.transform.forward;
													if (275080 - 500451 == -225371)
													{
														this.$self_$35237.mChar.moveSpeed = (float)0;
														if (115094 - 250937 != -135842)
														{
															goto Block_43;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_1A:
				goto IL_AAC;
				Block_7:
				goto IL_A5D;
				Block_8:
				goto IL_AAC;
				IL_1F7:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_21:
				goto IL_1F7;
				IL_30D:
				goto IL_AAC;
				Block_43:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_A5D:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_AAC:
				return false;
			}

			// Token: 0x0600596A RID: 22890 RVA: 0x00ABE014 File Offset: 0x00ABC214
			internal static bool rAOTm0ppPmOp0tmaR6yu()
			{
				return true;
			}

			// Token: 0x0600596B RID: 22891 RVA: 0x00ABE018 File Offset: 0x00ABC218
			internal static bool RlZdqfpp0DnVoSEnHDYL()
			{
				return false;
			}

			// Token: 0x0400624B RID: 25163
			internal int $hitLayer$35230;

			// Token: 0x0400624C RID: 25164
			internal UnityScript.Lang.Array $hitList$35231;

			// Token: 0x0400624D RID: 25165
			internal GameObject $hitObject$35232;

			// Token: 0x0400624E RID: 25166
			internal Vector3 $hitPos$35233;

			// Token: 0x0400624F RID: 25167
			internal IEnumerator $$iterator$10559$35234;

			// Token: 0x04006250 RID: 25168
			internal Vector3 $mPos$35235;

			// Token: 0x04006251 RID: 25169
			internal Vector3 $tDir$35236;

			// Token: 0x04006252 RID: 25170
			internal PvpMount $self_$35237;
		}
	}

	// Token: 0x02000F5B RID: 3931
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_whale$35241 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600596C RID: 22892 RVA: 0x00ABE01C File Offset: 0x00ABC21C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_whale$35241(Vector3 mPos, Vector3 tDir, PvpMount self_)
		{
			if (127460 - 160953 != -33492)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (157127 - 474802 == -317675)
				{
					base..ctor();
					if (156956 - 401709 == -244753)
					{
						this.$mPos$35250 = mPos;
						if (251637 - 107135 == 144502)
						{
							this.$tDir$35251 = tDir;
							if (139575 - 285861 == -146286)
							{
								this.$self_$35252 = self_;
								if (208857 - 41633 == 167224)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600596D RID: 22893 RVA: 0x00ABE0F8 File Offset: 0x00ABC2F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PvpMount.$RPC_rAttack_whale$35241.$(this.$mPos$35250, this.$tDir$35251, this.$self_$35252);
		}

		// Token: 0x0600596E RID: 22894 RVA: 0x00ABE114 File Offset: 0x00ABC314
		internal static bool V6GmLFppbSJ6a8E7kl0c()
		{
			return true;
		}

		// Token: 0x0600596F RID: 22895 RVA: 0x00ABE118 File Offset: 0x00ABC318
		internal static bool xvDU6qppu7hxIyhYcEtA()
		{
			return false;
		}

		// Token: 0x04006253 RID: 25171
		internal Vector3 $mPos$35250;

		// Token: 0x04006254 RID: 25172
		internal Vector3 $tDir$35251;

		// Token: 0x04006255 RID: 25173
		internal PvpMount $self_$35252;

		// Token: 0x02000F5C RID: 3932
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005970 RID: 22896 RVA: 0x00ABE11C File Offset: 0x00ABC31C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PvpMount self_)
			{
				if (240706 - 461860 != -221154)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (293990 - 34171 == 259819)
					{
						base..ctor();
						if (69006 - 137056 == -68050)
						{
							this.$mPos$35247 = mPos;
							if (275039 - 464392 == -189353)
							{
								this.$tDir$35248 = tDir;
								if (42638 - 204106 != -161467)
								{
									this.$self_$35249 = self_;
									if (9301 - 130628 == -121327)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005971 RID: 22897 RVA: 0x00ABE1F8 File Offset: 0x00ABC3F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (99077 - 63326 != 35751)
				{
				}
				for (;;)
				{
					IL_2E1:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_AA7;
					case 2:
						if (this.$self_$35249.mChar.actionState != "attack")
						{
							if (128858 - 208302 != -79444)
							{
								continue;
							}
							goto IL_8D6;
						}
						else
						{
							if (!this.$self_$35249.HWtcX2HtlFN)
							{
								if (67481 - 582499 == -515017)
								{
									continue;
								}
								this.$self_$35249.HWtcX2HtlFN = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/whale_rAttack", typeof(GameObject));
								if (113609 - 573157 != -459548)
								{
									continue;
								}
							}
							if (this.$self_$35249.HWtcX2HtlFN)
							{
								if (10393 - 589848 == -579454)
								{
									continue;
								}
								this.$self_$35249.mChar.createEffect(this.$self_$35249.HWtcX2HtlFN, this.$self_$35249.transform.position, this.$self_$35249.transform.rotation);
								if (264912 - 56931 != 207982)
								{
									goto Block_34;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find whale_rAttack effect");
								if (291344 - 255057 != 36287)
								{
									continue;
								}
								goto IL_78B;
							}
						}
						break;
					case 3:
						if (this.$self_$35249.mChar.actionState != "attack")
						{
							if (179816 - 327718 != -147901)
							{
								goto Block_49;
							}
							continue;
						}
						else
						{
							if (!this.$self_$35249.mChar.isMine)
							{
								goto IL_675;
							}
							if (224043 - 399894 == -175850)
							{
								continue;
							}
							this.$hitLayer$35242 = 130816 - (1 << this.$self_$35249.gameObject.layer);
							if (152233 - 164533 != -12300)
							{
								continue;
							}
							this.$hitList$35243 = Damage.FindRecTarget(this.$self_$35249.transform.position + this.$self_$35249.transform.right, this.$self_$35249.transform.forward, 1.5f, 1.5f, (float)8, (float)4, this.$hitLayer$35242);
							if (94877 - 561246 == -466368)
							{
								continue;
							}
							this.$$iterator$10567$35246 = UnityRuntimeServices.GetEnumerator(this.$hitList$35243);
							if (1391 - 530667 == -529275)
							{
								continue;
							}
							while (this.$$iterator$10567$35246.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10567$35246.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$35244 = (GameObject)obj2;
								if (241246 - 178915 != 62331)
								{
									goto IL_2E1;
								}
								if (this.$self_$35249.mChar.hit(2, this.$hitObject$35244, (int)(2.2f * (float)this.$self_$35249.mChar.atk), 1, 0, this.$self_$35249.transform.forward) != 0)
								{
									if (284755 - 503106 != -218351)
									{
										goto IL_2E1;
									}
									this.$hitPos$35245 = this.$hitObject$35244.collider.ClosestPointOnBounds(this.$self_$35249.transform.position + (float)2 * Vector3.up);
									if (128141 - 266377 == -138235)
									{
										goto IL_2E1;
									}
									UnityRuntimeServices.Update(this.$$iterator$10567$35246, this.$hitObject$35244);
									if (153889 - 98203 != 55686)
									{
										goto IL_2E1;
									}
									this.$self_$35249.RPC_nAttack_bison_hit(this.$hitPos$35245, this.$self_$35249.transform.forward, 0);
									if (128529 - 232688 == -104158)
									{
										goto IL_2E1;
									}
									this.$self_$35249.ActionEvent("RPC_nAttack_bison_hit", this.$hitPos$35245, this.$self_$35249.transform.forward, 0);
									if (120853 - 238755 == -117901)
									{
										goto IL_2E1;
									}
								}
							}
							if (147115 - 66261 != 80855)
							{
								goto Block_64;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$35249.mChar.actionState == "attack")
						{
							if (195763 - 348951 != -153188)
							{
								continue;
							}
							if (this.$self_$35249.mChar.myCommand == "rAttack")
							{
								if (239726 - 827 != 238899)
								{
									continue;
								}
								this.$self_$35249.mChar.actionState = "standby";
								if (228763 - 317968 != -89205)
								{
									continue;
								}
								this.$self_$35249.mChar.actionTime = Time.time;
								if (182076 - 547948 == -365871)
								{
									continue;
								}
								this.$self_$35249.mChar.myCommand = "none";
								if (178180 - 588675 == -410494)
								{
									continue;
								}
								if (!this.$self_$35249.mChar.isMine)
								{
									if (55649 - 501665 == -446015)
									{
										continue;
									}
									this.$self_$35249.mChar.nPosition = this.$self_$35249.transform.position;
									if (167370 - 167586 == -215)
									{
										continue;
									}
									this.$self_$35249.mChar.oPosition = this.$self_$35249.transform.position;
									if (288723 - 555829 != -267106)
									{
										continue;
									}
									this.$self_$35249.mChar.nDirection = this.$self_$35249.transform.forward;
									if (239115 - 146113 != 93002)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (222336 - 105212 != 117124)
						{
							continue;
						}
						goto IL_AA7;
					default:
						if (69507 - 113062 == -43554)
						{
							continue;
						}
						break;
					}
					this.$self_$35249.mChar.actionState = "attack";
					if (100201 - 556449 != -456247)
					{
						this.$self_$35249.mChar.actionTime = Time.time;
						if (7891 - 208693 != -200801)
						{
							this.$self_$35249.mChar.myCommand = "rAttack";
							if (239654 - 51400 == 188254)
							{
								this.$self_$35249.mChar.addTimeOut("nAttack", 1.5f);
								if (100780 - 346847 != -246066)
								{
									this.$self_$35249.transform.position = this.$mPos$35247;
									if (114927 - 473079 == -358152)
									{
										this.$self_$35249.transform.LookAt(this.$mPos$35247 + global::Math.vFlat(this.$tDir$35248));
										if (122586 - 356944 == -234358)
										{
											this.$self_$35249.animation.CrossFade("rAttack", 0.2f);
											if (273477 - 212121 == 61356)
											{
												this.$self_$35249.animation.wrapMode = WrapMode.Once;
												if (264516 - 539599 == -275083)
												{
													this.$self_$35249.mChar.vMovement = this.$self_$35249.transform.forward;
													if (26501 - 118236 == -91735)
													{
														this.$self_$35249.mChar.moveSpeed = (float)8;
														if (144222 - 316438 != -172215)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																break;
															}
															if (158870 - 267367 != -108496)
															{
																if (!this.$self_$35249.mChar.isMine)
																{
																	if (80670 - 178277 != -97607)
																	{
																		continue;
																	}
																	if (Game.mGameType <= 4)
																	{
																		break;
																	}
																	if (159637 - 283568 != -123931)
																	{
																		continue;
																	}
																	if (Game.mTeam != this.$self_$35249.mChar.mOriginalLayer - 7)
																	{
																		break;
																	}
																	if (13910 - 169358 != -155448)
																	{
																		continue;
																	}
																}
																if (!this.$self_$35249.hHfcXvhD0XV)
																{
																	if (141096 - 315275 != -174179)
																	{
																		continue;
																	}
																	this.$self_$35249.hHfcXvhD0XV = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Whale/Voices/nAttack3", typeof(AudioClip));
																	if (76347 - 2758 != 73589)
																	{
																		continue;
																	}
																}
																if (this.$self_$35249.hHfcXvhD0XV)
																{
																	if (122120 - 61559 == 60561)
																	{
																		goto IL_610;
																	}
																}
																else
																{
																	Debug.LogError("Cannot find whale_rAttack voice");
																	if (106558 - 374112 != -267553)
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
				IL_4CD:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_34:
				goto IL_78B;
				IL_610:
				this.$self_$35249.audio.PlayOneShot(this.$self_$35249.hHfcXvhD0XV, (!this.$self_$35249.mChar.isMine) ? 0.75f : ((float)1));
				goto IL_4CD;
				IL_675:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_78B:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_49:
				IL_8D6:
				goto IL_AA7;
				Block_64:
				goto IL_675;
				IL_AA7:
				return false;
			}

			// Token: 0x06005972 RID: 22898 RVA: 0x00ABECC0 File Offset: 0x00ABCEC0
			internal static bool oNdx1gppIpqQQ4M1EY2d()
			{
				return true;
			}

			// Token: 0x06005973 RID: 22899 RVA: 0x00ABECC4 File Offset: 0x00ABCEC4
			internal static bool wu5Om8ppBoOVF27BrAii()
			{
				return false;
			}

			// Token: 0x04006256 RID: 25174
			internal int $hitLayer$35242;

			// Token: 0x04006257 RID: 25175
			internal UnityScript.Lang.Array $hitList$35243;

			// Token: 0x04006258 RID: 25176
			internal GameObject $hitObject$35244;

			// Token: 0x04006259 RID: 25177
			internal Vector3 $hitPos$35245;

			// Token: 0x0400625A RID: 25178
			internal IEnumerator $$iterator$10567$35246;

			// Token: 0x0400625B RID: 25179
			internal Vector3 $mPos$35247;

			// Token: 0x0400625C RID: 25180
			internal Vector3 $tDir$35248;

			// Token: 0x0400625D RID: 25181
			internal PvpMount $self_$35249;
		}
	}

	// Token: 0x02000F5D RID: 3933
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_cat$35253 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005974 RID: 22900 RVA: 0x00ABECC8 File Offset: 0x00ABCEC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_cat$35253(Vector3 mPos, Vector3 tDir, PvpMount self_)
		{
			if (279448 - 293228 != -13780)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (111714 - 7799 != 103916)
				{
					base..ctor();
					if (115541 - 371298 == -255757)
					{
						this.$mPos$35261 = mPos;
						if (97890 - 570840 != -472949)
						{
							this.$tDir$35262 = tDir;
							if (270866 - 562844 != -291977)
							{
								this.$self_$35263 = self_;
								if (215185 - 183307 != 31879)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005975 RID: 22901 RVA: 0x00ABEDA4 File Offset: 0x00ABCFA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PvpMount.$RPC_nAttack_cat$35253.$(this.$mPos$35261, this.$tDir$35262, this.$self_$35263);
		}

		// Token: 0x06005976 RID: 22902 RVA: 0x00ABEDC0 File Offset: 0x00ABCFC0
		internal static bool f8pb42ppejl2syKK7qnl()
		{
			return true;
		}

		// Token: 0x06005977 RID: 22903 RVA: 0x00ABEDC4 File Offset: 0x00ABCFC4
		internal static bool DXf2Z0ppraSrJ1NBHsVB()
		{
			return false;
		}

		// Token: 0x0400625E RID: 25182
		internal Vector3 $mPos$35261;

		// Token: 0x0400625F RID: 25183
		internal Vector3 $tDir$35262;

		// Token: 0x04006260 RID: 25184
		internal PvpMount $self_$35263;

		// Token: 0x02000F5E RID: 3934
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005978 RID: 22904 RVA: 0x00ABEDC8 File Offset: 0x00ABCFC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PvpMount self_)
			{
				if (72106 - 195858 != -123752)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (50697 - 97101 != -46403)
					{
						base..ctor();
						if (58462 - 31148 == 27314)
						{
							this.$mPos$35258 = mPos;
							if (93531 - 234544 != -141012)
							{
								this.$tDir$35259 = tDir;
								if (181924 - 198335 != -16410)
								{
									this.$self_$35260 = self_;
									if (194281 - 483243 == -288962)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005979 RID: 22905 RVA: 0x00ABEEA4 File Offset: 0x00ABD0A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (56452 - 306565 != -250113)
				{
				}
				for (;;)
				{
					IL_29B:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A63;
					case 2:
						if (this.$self_$35260.mChar.actionState != "attack")
						{
							if (237688 - 265630 != -27941)
							{
								goto Block_44;
							}
							continue;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_511;
							}
							if (82079 - 42213 == 39867)
							{
								continue;
							}
							if (!this.$self_$35260.mChar.isMine)
							{
								if (120112 - 273153 != -153041)
								{
									continue;
								}
								if (Game.mGameType <= 4)
								{
									goto IL_511;
								}
								if (94036 - 451854 == -357817)
								{
									continue;
								}
								if (Game.mTeam != this.$self_$35260.mChar.mOriginalLayer - 7)
								{
									goto IL_511;
								}
								if (252074 - 268450 != -16376)
								{
									continue;
								}
							}
							if (!this.$self_$35260.a8rcXGoMXbu)
							{
								if (45765 - 87715 != -41950)
								{
									continue;
								}
								this.$self_$35260.a8rcXGoMXbu = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Cat/Voices/nAttack1", typeof(AudioClip));
								if (24555 - 221267 == -196711)
								{
									continue;
								}
							}
							if (this.$self_$35260.a8rcXGoMXbu)
							{
								if (61314 - 303395 != -242080)
								{
									goto Block_66;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find  cat_nAttack voice");
								if (35003 - 439467 != -404464)
								{
									continue;
								}
								goto IL_511;
							}
						}
						break;
					case 3:
						if (this.$self_$35260.mChar.actionState != "attack")
						{
							if (250834 - 147576 != 103258)
							{
								continue;
							}
							goto IL_7F;
						}
						else
						{
							if (!this.$self_$35260.OYLcXlljUcF)
							{
								if (209196 - 132655 != 76541)
								{
									continue;
								}
								this.$self_$35260.OYLcXlljUcF = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/cat_nAttack", typeof(GameObject));
								if (194674 - 22631 != 172043)
								{
									continue;
								}
							}
							if (this.$self_$35260.OYLcXlljUcF)
							{
								if (97043 - 31381 != 65662)
								{
									continue;
								}
								this.$self_$35260.mChar.createEffect(this.$self_$35260.OYLcXlljUcF, this.$self_$35260.transform.position, this.$self_$35260.transform.rotation);
								if (109472 - 276300 != -166827)
								{
									goto Block_58;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find cat_nAttack effect");
								if (156438 - 330881 != -174442)
								{
									goto Block_31;
								}
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$35260.mChar.actionState != "attack")
						{
							if (84664 - 131986 != -47322)
							{
								continue;
							}
							goto IL_4B4;
						}
						else
						{
							if (!this.$self_$35260.mChar.isMine)
							{
								goto IL_5BE;
							}
							if (66545 - 327980 != -261435)
							{
								continue;
							}
							this.$hitLayer$35254 = 130816 - (1 << this.$self_$35260.gameObject.layer);
							if (60103 - 180788 == -120684)
							{
								continue;
							}
							this.$hitList$35255 = Damage.FindAreaTarget(this.$self_$35260.transform.position, (float)7, (float)3, this.$hitLayer$35254);
							if (236286 - 429873 == -193586)
							{
								continue;
							}
							this.$$iterator$10560$35257 = UnityRuntimeServices.GetEnumerator(this.$hitList$35255);
							if (149538 - 439368 != -289830)
							{
								continue;
							}
							while (this.$$iterator$10560$35257.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10560$35257.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$35256 = (GameObject)obj2;
								if (208827 - 47541 == 161287)
								{
									goto IL_29B;
								}
								this.$self_$35260.mChar.hit(1, this.$hitObject$35256, (int)(0.75f * (float)this.$self_$35260.mChar.atk), 1, 0, 0.5f * (this.$hitObject$35256.transform.position - this.$self_$35260.transform.position).normalized);
								if (47211 - 5256 == 41956)
								{
									goto IL_29B;
								}
								UnityRuntimeServices.Update(this.$$iterator$10560$35257, this.$hitObject$35256);
								if (119777 - 13194 == 106584)
								{
									goto IL_29B;
								}
							}
							if (31619 - 489500 != -457881)
							{
								continue;
							}
							goto IL_5BE;
						}
						break;
					case 5:
						if (this.$self_$35260.mChar.actionState != "attack")
						{
							if (237274 - 24683 != 212591)
							{
								continue;
							}
							goto IL_136;
						}
						else
						{
							if (this.$self_$35260.mChar.actionState == "attack")
							{
								if (159493 - 322454 == -162960)
								{
									continue;
								}
								if (this.$self_$35260.mChar.myCommand == "nAttack")
								{
									if (168001 - 473175 != -305174)
									{
										continue;
									}
									this.$self_$35260.mChar.actionState = "standby";
									if (44174 - 171239 != -127065)
									{
										continue;
									}
									this.$self_$35260.mChar.actionTime = Time.time;
									if (66469 - 345368 != -278899)
									{
										continue;
									}
									this.$self_$35260.mChar.myCommand = "none";
									if (221387 - 167664 != 53723)
									{
										continue;
									}
									if (!this.$self_$35260.mChar.isMine)
									{
										if (170101 - 288895 == -118793)
										{
											continue;
										}
										this.$self_$35260.mChar.nPosition = this.$self_$35260.transform.position;
										if (284314 - 214874 == 69441)
										{
											continue;
										}
										this.$self_$35260.mChar.oPosition = this.$self_$35260.transform.position;
										if (223502 - 391001 == -167498)
										{
											continue;
										}
										this.$self_$35260.mChar.nDirection = this.$self_$35260.transform.forward;
										if (37886 - 209464 != -171578)
										{
											continue;
										}
									}
								}
							}
							this.YieldDefault(1);
							if (190475 - 92398 != 98078)
							{
								goto Block_12;
							}
							continue;
						}
						break;
					default:
						if (181478 - 473071 != -291593)
						{
							continue;
						}
						break;
					}
					this.$self_$35260.mChar.actionState = "attack";
					if (233381 - 434435 != -201053)
					{
						this.$self_$35260.mChar.actionTime = Time.time;
						if (238544 - 138097 == 100447)
						{
							this.$self_$35260.mChar.myCommand = "nAttack";
							if (286823 - 170009 != 116815)
							{
								this.$self_$35260.mChar.addTimeOut("nAttack", 1.5f);
								if (111180 - 393152 != -281971)
								{
									this.$self_$35260.transform.position = this.$mPos$35258;
									if (239881 - 260447 == -20566)
									{
										this.$self_$35260.transform.LookAt(this.$mPos$35258 + global::Math.vFlat(this.$tDir$35259));
										if (240911 - 355317 != -114405)
										{
											this.$self_$35260.animation.CrossFade("nAttack", 0.2f);
											if (146903 - 112264 != 34640)
											{
												this.$self_$35260.animation.wrapMode = WrapMode.Once;
												if (189127 - 4221 != 184907)
												{
													this.$self_$35260.mChar.vMovement = this.$self_$35260.transform.forward;
													if (228878 - 299173 != -70294)
													{
														this.$self_$35260.mChar.moveSpeed = (float)0;
														if (245715 - 248839 != -3123)
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
				IL_7F:
				IL_136:
				Block_12:
				goto IL_A63;
				Block_18:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_32F:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_4B4:
				goto IL_A63;
				Block_31:
				goto IL_32F;
				IL_511:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_5BE:
				return this.Yield(5, new WaitForSeconds(0.3f));
				Block_44:
				goto IL_A63;
				Block_58:
				goto IL_32F;
				Block_66:
				this.$self_$35260.audio.PlayOneShot(this.$self_$35260.a8rcXGoMXbu, (!this.$self_$35260.mChar.isMine) ? 0.75f : ((float)1));
				goto IL_511;
				IL_A63:
				return false;
			}

			// Token: 0x0600597A RID: 22906 RVA: 0x00ABF928 File Offset: 0x00ABDB28
			internal static bool tRdkouppjrSTM6abFZw9()
			{
				return true;
			}

			// Token: 0x0600597B RID: 22907 RVA: 0x00ABF92C File Offset: 0x00ABDB2C
			internal static bool nalHlXpph0GsVrH8S9F8()
			{
				return false;
			}

			// Token: 0x04006261 RID: 25185
			internal int $hitLayer$35254;

			// Token: 0x04006262 RID: 25186
			internal UnityScript.Lang.Array $hitList$35255;

			// Token: 0x04006263 RID: 25187
			internal GameObject $hitObject$35256;

			// Token: 0x04006264 RID: 25188
			internal IEnumerator $$iterator$10560$35257;

			// Token: 0x04006265 RID: 25189
			internal Vector3 $mPos$35258;

			// Token: 0x04006266 RID: 25190
			internal Vector3 $tDir$35259;

			// Token: 0x04006267 RID: 25191
			internal PvpMount $self_$35260;
		}
	}

	// Token: 0x02000F5F RID: 3935
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_cat$35264 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600597C RID: 22908 RVA: 0x00ABF930 File Offset: 0x00ABDB30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_cat$35264(Vector3 mPos, Vector3 tDir, int tID, PvpMount self_)
		{
			if (212623 - 258463 != -45840)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (123090 - 222941 == -99851)
				{
					base..ctor();
					if (22 - 88927 != -88904)
					{
						this.$mPos$35277 = mPos;
						if (201354 - 328950 == -127596)
						{
							this.$tDir$35278 = tDir;
							if (231242 - 590894 != -359651)
							{
								this.$tID$35279 = tID;
								if (49219 - 269298 == -220079)
								{
									this.$self_$35280 = self_;
									if (232804 - 557512 != -324707)
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

		// Token: 0x0600597D RID: 22909 RVA: 0x00ABFA30 File Offset: 0x00ABDC30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PvpMount.$RPC_rAttack_cat$35264.$(this.$mPos$35277, this.$tDir$35278, this.$tID$35279, this.$self_$35280);
		}

		// Token: 0x0600597E RID: 22910 RVA: 0x00ABFA50 File Offset: 0x00ABDC50
		internal static bool AoeC3MppsPGCgcRWFva0()
		{
			return true;
		}

		// Token: 0x0600597F RID: 22911 RVA: 0x00ABFA54 File Offset: 0x00ABDC54
		internal static bool MkhpnSpp9KEVc7UlbvgE()
		{
			return false;
		}

		// Token: 0x04006268 RID: 25192
		internal Vector3 $mPos$35277;

		// Token: 0x04006269 RID: 25193
		internal Vector3 $tDir$35278;

		// Token: 0x0400626A RID: 25194
		internal int $tID$35279;

		// Token: 0x0400626B RID: 25195
		internal PvpMount $self_$35280;

		// Token: 0x02000F60 RID: 3936
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005980 RID: 22912 RVA: 0x00ABFA58 File Offset: 0x00ABDC58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, PvpMount self_)
			{
				if (145140 - 229380 != -84239)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (38012 - 333310 == -295298)
					{
						base..ctor();
						if (46098 - 285833 != -239734)
						{
							this.$mPos$35273 = mPos;
							if (166045 - 60188 != 105858)
							{
								this.$tDir$35274 = tDir;
								if (25236 - 37697 == -12461)
								{
									this.$tID$35275 = tID;
									if (164793 - 491961 != -327167)
									{
										this.$self_$35276 = self_;
										if (272003 - 365087 != -93083)
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

			// Token: 0x06005981 RID: 22913 RVA: 0x00ABFB58 File Offset: 0x00ABDD58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (108409 - 472075 != -363665)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_C67;
					case 2:
						if (this.$self_$35276.mChar.actionState != "attack")
						{
							if (133381 - 295362 != -161980)
							{
								goto Block_49;
							}
							continue;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_36A;
							}
							if (211780 - 170300 == 41481)
							{
								continue;
							}
							if (!this.$self_$35276.mChar.isMine)
							{
								if (43579 - 188872 == -145292)
								{
									continue;
								}
								if (Game.mGameType <= 4)
								{
									goto IL_36A;
								}
								if (145252 - 524211 == -378958)
								{
									continue;
								}
								if (Game.mTeam != this.$self_$35276.mChar.mOriginalLayer - 7)
								{
									goto IL_36A;
								}
								if (266900 - 33903 == 232998)
								{
									continue;
								}
							}
							if (!this.$self_$35276.kNkcXqfhWTR)
							{
								if (299141 - 51968 != 247173)
								{
									continue;
								}
								this.$self_$35276.kNkcXqfhWTR = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Cat/Voices/nAttack4", typeof(AudioClip));
								if (21736 - 471979 != -450243)
								{
									continue;
								}
							}
							if (this.$self_$35276.kNkcXqfhWTR)
							{
								if (269792 - 352572 != -82780)
								{
									continue;
								}
								goto IL_64F;
							}
							else
							{
								Debug.LogError("Cannot find  cat_rAttack voice");
								if (24228 - 139168 != -114939)
								{
									goto Block_41;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$35276.mChar.actionState != "attack")
						{
							if (73186 - 183002 != -109816)
							{
								continue;
							}
							goto IL_529;
						}
						else
						{
							if (!this.$tObject$35266)
							{
								goto IL_20A;
							}
							if (261777 - 297172 == -35394)
							{
								continue;
							}
							this.$tPos$35265 = this.$tObject$35266.collider.bounds.center;
							if (192213 - 248755 != -56542)
							{
								continue;
							}
							goto IL_20A;
						}
						break;
					case 4:
						if (this.$self_$35276.mChar.actionState != "attack")
						{
							if (28818 - 341267 != -312448)
							{
								goto Block_13;
							}
							continue;
						}
						else
						{
							this.$firePos$35267 = this.$self_$35276.transform.position + this.$self_$35276.transform.TransformDirection((float)0, 2.2f, 1.2f);
							if (190458 - 16847 != 173611)
							{
								continue;
							}
							this.$fireDir$35268 = (this.$tPos$35265 - this.$firePos$35267).normalized;
							if (176943 - 12802 == 164142)
							{
								continue;
							}
							if (Vector3.Dot(this.$self_$35276.transform.forward, this.$fireDir$35268) < (float)0)
							{
								if (143239 - 7851 != 135388)
								{
									continue;
								}
								this.$fireDir$35268 = ((float)6 * this.$self_$35276.transform.forward - Vector3.up).normalized;
								if (145722 - 521886 != -376164)
								{
									continue;
								}
							}
							this.$fireRot$35269 = Quaternion.FromToRotation(Vector3.forward, this.$fireDir$35268);
							if (61970 - 313024 == -251053)
							{
								continue;
							}
							if (!this.$self_$35276.GX5cX1IxnIo)
							{
								if (198019 - 338013 == -139993)
								{
									continue;
								}
								this.$self_$35276.GX5cX1IxnIo = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/cat_rAttack", typeof(GameObject));
								if (235082 - 413430 == -178347)
								{
									continue;
								}
							}
							if (this.$self_$35276.GX5cX1IxnIo)
							{
								if (2328 - 66804 != -64476)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$35276.GX5cX1IxnIo, this.$firePos$35267, this.$fireRot$35269);
								if (155278 - 227293 != -72015)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find cat_rAttack effect");
								if (195023 - 100269 == 94755)
								{
									continue;
								}
							}
							if (!this.$self_$35276.mChar.isMine)
							{
								goto IL_746;
							}
							if (54458 - 499553 != -445095)
							{
								continue;
							}
							this.$hitLayer$35270 = ~((1 << this.$self_$35276.gameObject.layer) + 2 + 4);
							if (180263 - 271542 != -91279)
							{
								continue;
							}
							this.$hit$35271 = default(RaycastHit);
							if (234469 - 469901 != -235432)
							{
								continue;
							}
							if (!Physics.Raycast(this.$firePos$35267, this.$fireDir$35268, out this.$hit$35271, (float)40, this.$hitLayer$35270))
							{
								goto IL_746;
							}
							if (287866 - 359205 == -71338)
							{
								continue;
							}
							this.$self_$35276.RPC_rAttack_cat_hit(this.$hit$35271.point, this.$self_$35276.transform.forward, 0);
							if (165982 - 192310 != -26328)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (231274 - 197227 != 34047)
								{
									continue;
								}
								this.$self_$35276.ActionEvent("RPC_rAttack_cat_hit", this.$hit$35271.point, this.$self_$35276.transform.forward, 0);
								if (163821 - 357823 == -194001)
								{
									continue;
								}
							}
							this.$hitObject$35272 = this.$hit$35271.collider.gameObject;
							if (250484 - 10224 != 240260)
							{
								continue;
							}
							if (!this.$hitObject$35272)
							{
								goto IL_746;
							}
							if (49056 - 17201 != 31855)
							{
								continue;
							}
							this.$self_$35276.mChar.hit(25, this.$hitObject$35272, (int)(1.5f * (float)this.$self_$35276.mChar.atk), 3, 0, this.$self_$35276.transform.forward);
							if (165563 - 151027 != 14536)
							{
								continue;
							}
							goto IL_746;
						}
						break;
					case 5:
						if (this.$self_$35276.mChar.actionState == "attack")
						{
							if (86996 - 582421 != -495425)
							{
								continue;
							}
							if (this.$self_$35276.mChar.myCommand == "rAttack")
							{
								if (201469 - 11432 == 190038)
								{
									continue;
								}
								this.$self_$35276.mChar.actionState = "standby";
								if (118818 - 338591 == -219772)
								{
									continue;
								}
								this.$self_$35276.mChar.actionTime = Time.time;
								if (19563 - 202116 != -182553)
								{
									continue;
								}
								this.$self_$35276.mChar.myCommand = "none";
								if (177867 - 28053 == 149815)
								{
									continue;
								}
								if (!this.$self_$35276.mChar.isMine)
								{
									if (79766 - 557120 != -477354)
									{
										continue;
									}
									this.$self_$35276.mChar.nPosition = this.$self_$35276.transform.position;
									if (291414 - 130438 == 160977)
									{
										continue;
									}
									this.$self_$35276.mChar.oPosition = this.$self_$35276.transform.position;
									if (157502 - 66140 == 91363)
									{
										continue;
									}
									this.$self_$35276.mChar.nDirection = this.$self_$35276.transform.forward;
									if (105242 - 547679 == -442436)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (271275 - 474704 != -203428)
						{
							goto Block_27;
						}
						continue;
					default:
						if (236659 - 314486 != -77827)
						{
							continue;
						}
						break;
					}
					this.$tPos$35265 = this.$mPos$35273 + this.$tDir$35274;
					if (256483 - 328076 != -71592)
					{
						this.$tObject$35266 = null;
						if (16493 - 132334 != -115840)
						{
							if (this.$tID$35275 != 0)
							{
								if (76690 - 505984 == -429293)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$35275];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$35266 = (GameObject)obj2;
								if (218922 - 266438 == -47515)
								{
									continue;
								}
							}
							this.$self_$35276.mChar.actionState = "attack";
							if (54407 - 54647 == -240)
							{
								this.$self_$35276.mChar.actionTime = Time.time;
								if (64147 - 275017 != -210869)
								{
									this.$self_$35276.mChar.myCommand = "rAttack";
									if (43864 - 585139 == -541275)
									{
										this.$self_$35276.mChar.addTimeOut("nAttack", 1.5f);
										if (225048 - 353199 != -128150)
										{
											this.$self_$35276.transform.position = this.$mPos$35273;
											if (35041 - 319865 != -284823)
											{
												this.$self_$35276.animation.CrossFade("rAttack", 0.2f);
												if (72346 - 59349 == 12997)
												{
													this.$self_$35276.animation.wrapMode = WrapMode.Once;
													if (41517 - 593757 != -552239)
													{
														this.$self_$35276.mChar.vMovement = this.$self_$35276.transform.forward;
														if (56864 - 299562 != -242697)
														{
															this.$self_$35276.mChar.moveSpeed = (float)8;
															if (150082 - 306112 != -156029)
															{
																goto Block_66;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_20A:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_13:
				goto IL_C67;
				IL_36A:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_27:
				IL_529:
				goto IL_C67;
				IL_64F:
				this.$self_$35276.audio.PlayOneShot(this.$self_$35276.kNkcXqfhWTR, (!this.$self_$35276.mChar.isMine) ? 0.75f : ((float)1));
				Block_41:
				goto IL_36A;
				IL_746:
				return this.Yield(5, new WaitForSeconds(0.2f));
				Block_49:
				goto IL_C67;
				Block_66:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_C67:
				return false;
			}

			// Token: 0x06005982 RID: 22914 RVA: 0x00AC07E0 File Offset: 0x00ABE9E0
			internal static bool a0EdP8pp1IbHdf0sDiaO()
			{
				return true;
			}

			// Token: 0x06005983 RID: 22915 RVA: 0x00AC07E4 File Offset: 0x00ABE9E4
			internal static bool QphCmNpp4sCbXFfEcu4b()
			{
				return false;
			}

			// Token: 0x0400626C RID: 25196
			internal Vector3 $tPos$35265;

			// Token: 0x0400626D RID: 25197
			internal GameObject $tObject$35266;

			// Token: 0x0400626E RID: 25198
			internal Vector3 $firePos$35267;

			// Token: 0x0400626F RID: 25199
			internal Vector3 $fireDir$35268;

			// Token: 0x04006270 RID: 25200
			internal Quaternion $fireRot$35269;

			// Token: 0x04006271 RID: 25201
			internal int $hitLayer$35270;

			// Token: 0x04006272 RID: 25202
			internal RaycastHit $hit$35271;

			// Token: 0x04006273 RID: 25203
			internal GameObject $hitObject$35272;

			// Token: 0x04006274 RID: 25204
			internal Vector3 $mPos$35273;

			// Token: 0x04006275 RID: 25205
			internal Vector3 $tDir$35274;

			// Token: 0x04006276 RID: 25206
			internal int $tID$35275;

			// Token: 0x04006277 RID: 25207
			internal PvpMount $self_$35276;
		}
	}

	// Token: 0x02000F61 RID: 3937
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_chameleon$35281 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005984 RID: 22916 RVA: 0x00AC07E8 File Offset: 0x00ABE9E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_chameleon$35281(Vector3 mPos, Vector3 tDir, int tID, PvpMount self_)
		{
			if (142142 - 322659 != -180517)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (226253 - 529773 == -303520)
				{
					base..ctor();
					if (186259 - 489808 != -303548)
					{
						this.$mPos$35302 = mPos;
						if (71166 - 86384 != -15217)
						{
							this.$tDir$35303 = tDir;
							if (67138 - 490406 != -423267)
							{
								this.$tID$35304 = tID;
								if (7511 - 249279 != -241767)
								{
									this.$self_$35305 = self_;
									if (29979 - 209119 != -179139)
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

		// Token: 0x06005985 RID: 22917 RVA: 0x00AC08E8 File Offset: 0x00ABEAE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PvpMount.$RPC_nAttack_chameleon$35281.$(this.$mPos$35302, this.$tDir$35303, this.$tID$35304, this.$self_$35305);
		}

		// Token: 0x06005986 RID: 22918 RVA: 0x00AC0908 File Offset: 0x00ABEB08
		internal static bool rctSQsppzTZqKaSfrH8M()
		{
			return true;
		}

		// Token: 0x06005987 RID: 22919 RVA: 0x00AC090C File Offset: 0x00ABEB0C
		internal static bool hyqckmpVaNGiS6f1aZIB()
		{
			return false;
		}

		// Token: 0x04006278 RID: 25208
		internal Vector3 $mPos$35302;

		// Token: 0x04006279 RID: 25209
		internal Vector3 $tDir$35303;

		// Token: 0x0400627A RID: 25210
		internal int $tID$35304;

		// Token: 0x0400627B RID: 25211
		internal PvpMount $self_$35305;

		// Token: 0x02000F62 RID: 3938
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005988 RID: 22920 RVA: 0x00AC0910 File Offset: 0x00ABEB10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, PvpMount self_)
			{
				if (118519 - 139966 != -21446)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (6450 - 282537 != -276086)
					{
						base..ctor();
						if (267047 - 561345 == -294298)
						{
							this.$mPos$35298 = mPos;
							if (129018 - 316428 == -187410)
							{
								this.$tDir$35299 = tDir;
								if (285937 - 210647 != 75291)
								{
									this.$tID$35300 = tID;
									if (116511 - 354156 == -237645)
									{
										this.$self_$35301 = self_;
										if (88352 - 170649 == -82297)
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

			// Token: 0x06005989 RID: 22921 RVA: 0x00AC0A10 File Offset: 0x00ABEC10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (53421 - 562430 != -509008)
				{
				}
				for (;;)
				{
					IL_E72:
					switch (this._state)
					{
					case 0:
						goto IL_B7D;
					case 1:
						goto IL_116F;
					case 2:
						goto IL_9FA;
					case 3:
						if (this.$self_$35301.mChar.actionState != "attack")
						{
							if (56683 - 321556 != -264873)
							{
								continue;
							}
							goto IL_495;
						}
						else
						{
							this.$self_$35301.animation.CrossFade("root", 0.1f);
							if (196943 - 256397 == -59453)
							{
								continue;
							}
							this.$self_$35301.animation.wrapMode = WrapMode.Loop;
							if (167985 - 188618 == -20632)
							{
								continue;
							}
							this.$mActionTimer$35285 = Time.time;
							if (67713 - 263071 == -195357)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$35301.mChar.actionState != "attack")
						{
							if (219425 - 280512 != -61087)
							{
								continue;
							}
							goto IL_CB;
						}
						break;
					default:
						if (210791 - 112370 != 98422)
						{
							goto IL_B7D;
						}
						continue;
					}
					if (Time.time >= this.$mActionTimer$35285 + 0.1f)
					{
						if (130986 - 85088 == 45899)
						{
							continue;
						}
						if (this.$self_$35301.mChar.getStatus("invisible") == null)
						{
							if (72787 - 232955 == -160167)
							{
								continue;
							}
							this.$$11556$35295 = 0;
							if (77392 - 356360 == -278967)
							{
								continue;
							}
							this.$$11557$35296 = this.$mWepRendererList$35287;
							if (46262 - 114051 != -67789)
							{
								continue;
							}
							this.$$11558$35297 = this.$$11557$35296.Length;
							if (236658 - 146319 != 90339)
							{
								continue;
							}
							while (this.$$11556$35295 < this.$$11558$35297)
							{
								((Renderer)this.$$11557$35296[this.$$11556$35295]).enabled = true;
								if (32302 - 161051 == -128748)
								{
									goto IL_E72;
								}
								this.$$11556$35295++;
								if (104877 - 467205 == -362327)
								{
									goto IL_E72;
								}
							}
							if (205007 - 3382 == 201626)
							{
								continue;
							}
						}
						if (this.$self_$35301.mChar.actionState == "attack")
						{
							if (45571 - 28802 == 16770)
							{
								continue;
							}
							if (this.$self_$35301.mChar.myCommand == "nAttack")
							{
								if (173375 - 404371 != -230996)
								{
									continue;
								}
								this.$self_$35301.mChar.actionState = "standby";
								if (52317 - 103290 != -50973)
								{
									continue;
								}
								this.$self_$35301.mChar.actionTime = Time.time;
								if (216308 - 420560 != -204252)
								{
									continue;
								}
								this.$self_$35301.mChar.myCommand = "none";
								if (209427 - 377894 == -168466)
								{
									continue;
								}
								if (!this.$self_$35301.mChar.isMine)
								{
									if (270086 - 538465 != -268379)
									{
										continue;
									}
									this.$self_$35301.mChar.nPosition = this.$self_$35301.transform.position;
									if (169230 - 441019 != -271789)
									{
										continue;
									}
									this.$self_$35301.mChar.oPosition = this.$self_$35301.transform.position;
									if (110095 - 326606 != -216511)
									{
										continue;
									}
									this.$self_$35301.mChar.nDirection = this.$self_$35301.transform.forward;
									if (284494 - 137122 == 147373)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (155288 - 193138 != -37849)
						{
							break;
						}
						continue;
					}
					else
					{
						if (this.$mSpine1$35283)
						{
							if (287396 - 332157 != -44761)
							{
								continue;
							}
							Vector3 localEulerAngles = this.$mSpine1$35283.localEulerAngles;
							if (16655 - 36992 == -20336)
							{
								continue;
							}
							if (localEulerAngles.y < (float)180)
							{
								if (176817 - 104193 == 72625)
								{
									continue;
								}
								this.$mSpine1$35283.localEulerAngles = Vector3.Slerp(this.$mSpine1$35283.localEulerAngles, new Vector3(2.5f, (float)-3, (float)272), (float)5 * (Time.time - this.$mActionTimer$35285));
								if (75238 - 462270 == -387031)
								{
									continue;
								}
							}
							else
							{
								this.$mSpine1$35283.localEulerAngles = Vector3.Slerp(this.$mSpine1$35283.localEulerAngles, new Vector3(2.5f, (float)357, (float)272), (float)5 * (Time.time - this.$mActionTimer$35285));
								if (153546 - 231677 == -78130)
								{
									continue;
								}
							}
						}
						if (!this.$mSpine2$35284)
						{
							goto IL_6D5;
						}
						if (50569 - 374748 == -324178)
						{
							continue;
						}
						Vector3 localEulerAngles2 = this.$mSpine2$35284.localEulerAngles;
						if (56966 - 83072 == -26105)
						{
							continue;
						}
						if (localEulerAngles2.x < (float)180)
						{
							if (41573 - 578005 != -536432)
							{
								continue;
							}
							this.$mSpine2$35284.localEulerAngles = Vector3.Slerp(this.$mSpine2$35284.localEulerAngles, new Vector3(2.15f, 2.8f, 9.7f), (float)5 * (Time.time - this.$mActionTimer$35285));
							if (21113 - 596914 != -575800)
							{
								goto Block_98;
							}
							continue;
						}
						else
						{
							this.$mSpine2$35284.localEulerAngles = Vector3.Slerp(this.$mSpine2$35284.localEulerAngles, new Vector3(362.15f, 2.8f, 9.71f), (float)5 * (Time.time - this.$mActionTimer$35285));
							if (67815 - 20047 != 47768)
							{
								continue;
							}
							goto IL_6D5;
						}
					}
					IL_9FA:
					if (Time.time >= this.$mActionTimer$35285 + 0.2f)
					{
						if (9301 - 443158 == -433856)
						{
							continue;
						}
						this.$mWepRendererList$35287 = this.$self_$35301.mChar.mWep2.GetComponentsInChildren(typeof(Renderer));
						if (58905 - 177458 != -118553)
						{
							continue;
						}
						this.$$11552$35292 = 0;
						if (173604 - 318447 == -144842)
						{
							continue;
						}
						this.$$11553$35293 = this.$mWepRendererList$35287;
						if (1577 - 429239 == -427661)
						{
							continue;
						}
						this.$$11554$35294 = this.$$11553$35293.Length;
						if (100215 - 340779 != -240564)
						{
							continue;
						}
						while (this.$$11552$35292 < this.$$11554$35294)
						{
							((Renderer)this.$$11553$35293[this.$$11552$35292]).enabled = false;
							if (141853 - 37474 == 104380)
							{
								goto IL_E72;
							}
							this.$$11552$35292++;
							if (110062 - 166078 != -56016)
							{
								goto IL_E72;
							}
						}
						if (13105 - 29452 != -16347)
						{
							continue;
						}
						if (!this.$self_$35301.mChar.isMine)
						{
							goto IL_238;
						}
						if (22996 - 260139 != -237143)
						{
							continue;
						}
						if (Game.mGameType <= 4)
						{
							goto IL_238;
						}
						if (69245 - 496968 != -427723)
						{
							continue;
						}
						if (this.$tDir$35299.magnitude < (float)4)
						{
							if (292753 - 271947 == 20807)
							{
								continue;
							}
							this.$tDir$35299 = (float)4 * this.$tDir$35299.normalized;
							if (273442 - 353013 != -79571)
							{
								continue;
							}
						}
						if (Vector3.Angle(global::Math.vFlat(this.$tDir$35299), this.$self_$35301.transform.right) < (float)90)
						{
							if (148029 - 86102 != 61927)
							{
								continue;
							}
							this.$targetDeg$35286 *= -1;
							if (79030 - 415707 == -336676)
							{
								continue;
							}
						}
						this.$firePos$35289 = this.$self_$35301.transform.position + global::Math.rotateH(this.$self_$35301.transform.TransformDirection((float)0, 2.5f, (float)2), (float)this.$targetDeg$35286);
						if (244701 - 41030 == 203672)
						{
							continue;
						}
						this.$fireDir$35290 = this.$tDir$35299 - this.$self_$35301.transform.TransformDirection(global::Math.rotateH(new Vector3((float)0, 2.5f, (float)2), (float)this.$targetDeg$35286));
						if (89069 - 531203 == -442133)
						{
							continue;
						}
						this.$self_$35301.RPC_nAttack_chameleon_fire(this.$firePos$35289, this.$fireDir$35290, 0);
						if (290567 - 428958 != -138391)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							goto IL_238;
						}
						if (192259 - 469847 == -277587)
						{
							continue;
						}
						this.$self_$35301.ActionEvent("RPC_nAttack_chameleon_fire", this.$firePos$35289, this.$fireDir$35290, 0);
						if (49888 - 569014 != -519125)
						{
							goto Block_109;
						}
						continue;
					}
					else if (this.$self_$35301.mChar.actionState != "attack")
					{
						if (77940 - 513455 != -435514)
						{
							break;
						}
						continue;
					}
					else
					{
						if (this.$tObject$35282)
						{
							if (212522 - 536101 != -323579)
							{
								continue;
							}
							this.$tDir$35299 = this.$tObject$35282.collider.bounds.center - this.$self_$35301.transform.position;
							if (129974 - 24314 != 105660)
							{
								continue;
							}
						}
						this.$targetDeg$35286 = (int)Mathf.Clamp(Vector3.Angle(global::Math.vFlat(this.$tDir$35299), this.$self_$35301.transform.forward), (float)0, (float)120);
						if (251607 - 567468 == -315860)
						{
							continue;
						}
						if (Vector3.Angle(global::Math.vFlat(this.$tDir$35299), -this.$self_$35301.transform.right) < (float)90)
						{
							if (175378 - 526199 == -350820)
							{
								continue;
							}
							if (this.$mSpine1$35283)
							{
								if (253769 - 29174 != 224595)
								{
									continue;
								}
								this.$mSpine1$35283.localEulerAngles = Vector3.Slerp(new Vector3(2.5f, (float)357, (float)272), new Vector3((float)0, (float)360 - 0.5f * (float)this.$targetDeg$35286, (float)270), (float)5 * (Time.time - this.$mActionTimer$35285));
								if (150828 - 143537 != 7291)
								{
									continue;
								}
							}
							if (!this.$mSpine2$35284)
							{
								goto IL_BD1;
							}
							if (125321 - 180553 != -55232)
							{
								continue;
							}
							this.$mSpine2$35284.localEulerAngles = Vector3.Slerp(new Vector3(2.15f, 2.8f, 9.71f), new Vector3(0.5f * (float)this.$targetDeg$35286, (float)0, (float)0), (float)5 * (Time.time - this.$mActionTimer$35285));
							if (80278 - 396721 != -316443)
							{
								continue;
							}
							goto IL_BD1;
						}
						else
						{
							if (this.$mSpine1$35283)
							{
								if (165644 - 451605 != -285961)
								{
									continue;
								}
								this.$mSpine1$35283.localEulerAngles = Vector3.Slerp(new Vector3(2.5f, (float)-3, (float)272), new Vector3((float)0, 0.5f * (float)this.$targetDeg$35286, (float)270), (float)5 * (Time.time - this.$mActionTimer$35285));
								if (280334 - 411752 == -131417)
								{
									continue;
								}
							}
							if (!this.$mSpine2$35284)
							{
								goto IL_9EE;
							}
							if (56558 - 228277 == -171718)
							{
								continue;
							}
							this.$mSpine2$35284.localEulerAngles = Vector3.Slerp(new Vector3(362.15f, 2.8f, 9.71f), new Vector3((float)360 - 0.5f * (float)this.$targetDeg$35286, (float)0, (float)0), (float)5 * (Time.time - this.$mActionTimer$35285));
							if (24270 - 147164 != -122894)
							{
								continue;
							}
							goto IL_9EE;
						}
					}
					IL_B7D:
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.$tID$35300];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.$tObject$35282 = (GameObject)obj2;
					if (182977 - 109086 != 73892)
					{
						this.$self_$35301.mChar.actionState = "attack";
						if (7886 - 313870 == -305984)
						{
							this.$self_$35301.mChar.actionTime = Time.time;
							if (45350 - 578095 == -532745)
							{
								this.$self_$35301.mChar.myCommand = "nAttack";
								if (46982 - 360281 != -313298)
								{
									this.$self_$35301.mChar.addTimeOut("nAttack", 0.6f);
									if (59543 - 377051 != -317507)
									{
										this.$self_$35301.transform.position = this.$mPos$35298;
										if (150243 - 470399 == -320156)
										{
											this.$self_$35301.animation.Rewind();
											if (137637 - 218364 != -80726)
											{
												this.$self_$35301.animation.Play("nAttack");
												if (59799 - 515932 != -456132)
												{
													this.$self_$35301.animation.wrapMode = WrapMode.Once;
													if (134765 - 286073 == -151308)
													{
														this.$self_$35301.mChar.vMovement = this.$self_$35301.transform.forward;
														if (36035 - 257474 == -221439)
														{
															this.$self_$35301.mChar.moveSpeed = (float)0;
															if (145327 - 234350 != -89022)
															{
																this.$mSpine1$35283 = global::Math.findChildObject(this.$self_$35301.gameObject.transform, "Spine1");
																if (36282 - 282922 == -246640)
																{
																	this.$mSpine2$35284 = global::Math.findChildObject(this.$self_$35301.gameObject.transform, "Spine2");
																	if (21280 - 443793 == -422513)
																	{
																		this.$mActionTimer$35285 = Time.time;
																		if (50493 - 296231 != -245737)
																		{
																			goto IL_9FA;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_CB:
				goto IL_116F;
				IL_238:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_495:
				goto IL_116F;
				IL_6D5:
				return this.YieldDefault(4);
				goto IL_116F;
				IL_9EE:
				return this.YieldDefault(2);
				IL_BD1:
				goto IL_9EE;
				Block_98:
				goto IL_6D5;
				goto IL_116F;
				Block_109:
				goto IL_238;
				IL_116F:
				return false;
			}

			// Token: 0x0600598A RID: 22922 RVA: 0x00AC1BA0 File Offset: 0x00ABFDA0
			internal static bool xlBwcApV5ftQYNlEiK91()
			{
				return true;
			}

			// Token: 0x0600598B RID: 22923 RVA: 0x00AC1BA4 File Offset: 0x00ABFDA4
			internal static bool NNtg0opVpHxE4t5QZPwW()
			{
				return false;
			}

			// Token: 0x0400627C RID: 25212
			internal GameObject $tObject$35282;

			// Token: 0x0400627D RID: 25213
			internal Transform $mSpine1$35283;

			// Token: 0x0400627E RID: 25214
			internal Transform $mSpine2$35284;

			// Token: 0x0400627F RID: 25215
			internal float $mActionTimer$35285;

			// Token: 0x04006280 RID: 25216
			internal int $targetDeg$35286;

			// Token: 0x04006281 RID: 25217
			internal Component[] $mWepRendererList$35287;

			// Token: 0x04006282 RID: 25218
			internal Renderer $mWepRendererer$35288;

			// Token: 0x04006283 RID: 25219
			internal Vector3 $firePos$35289;

			// Token: 0x04006284 RID: 25220
			internal Vector3 $fireDir$35290;

			// Token: 0x04006285 RID: 25221
			internal Renderer $mWepRendererer$35291;

			// Token: 0x04006286 RID: 25222
			internal int $$11552$35292;

			// Token: 0x04006287 RID: 25223
			internal Component[] $$11553$35293;

			// Token: 0x04006288 RID: 25224
			internal int $$11554$35294;

			// Token: 0x04006289 RID: 25225
			internal int $$11556$35295;

			// Token: 0x0400628A RID: 25226
			internal Component[] $$11557$35296;

			// Token: 0x0400628B RID: 25227
			internal int $$11558$35297;

			// Token: 0x0400628C RID: 25228
			internal Vector3 $mPos$35298;

			// Token: 0x0400628D RID: 25229
			internal Vector3 $tDir$35299;

			// Token: 0x0400628E RID: 25230
			internal int $tID$35300;

			// Token: 0x0400628F RID: 25231
			internal PvpMount $self_$35301;
		}
	}

	// Token: 0x02000F63 RID: 3939
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_chameleon$35306 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600598C RID: 22924 RVA: 0x00AC1BA8 File Offset: 0x00ABFDA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_chameleon$35306(Vector3 mPos, Vector3 tDir, int tID, PvpMount self_)
		{
			if (250333 - 584976 != -334642)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (116781 - 165989 == -49208)
				{
					base..ctor();
					if (48450 - 267964 != -219513)
					{
						this.$mPos$35331 = mPos;
						if (129450 - 311346 == -181896)
						{
							this.$tDir$35332 = tDir;
							if (168016 - 203284 != -35267)
							{
								this.$tID$35333 = tID;
								if (125134 - 58787 != 66348)
								{
									this.$self_$35334 = self_;
									if (98895 - 299206 == -200311)
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

		// Token: 0x0600598D RID: 22925 RVA: 0x00AC1CA8 File Offset: 0x00ABFEA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PvpMount.$RPC_rAttack_chameleon$35306.$(this.$mPos$35331, this.$tDir$35332, this.$tID$35333, this.$self_$35334);
		}

		// Token: 0x0600598E RID: 22926 RVA: 0x00AC1CC8 File Offset: 0x00ABFEC8
		internal static bool hQAYnHpVVMkjV4WHSf2O()
		{
			return true;
		}

		// Token: 0x0600598F RID: 22927 RVA: 0x00AC1CCC File Offset: 0x00ABFECC
		internal static bool aYZCIQpVtKgyBBp0Ca9w()
		{
			return false;
		}

		// Token: 0x04006290 RID: 25232
		internal Vector3 $mPos$35331;

		// Token: 0x04006291 RID: 25233
		internal Vector3 $tDir$35332;

		// Token: 0x04006292 RID: 25234
		internal int $tID$35333;

		// Token: 0x04006293 RID: 25235
		internal PvpMount $self_$35334;

		// Token: 0x02000F64 RID: 3940
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005990 RID: 22928 RVA: 0x00AC1CD0 File Offset: 0x00ABFED0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, PvpMount self_)
			{
				if (212802 - 186068 != 26735)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (190724 - 403401 == -212677)
					{
						base..ctor();
						if (171942 - 120210 == 51732)
						{
							this.$mPos$35327 = mPos;
							if (290723 - 378148 != -87424)
							{
								this.$tDir$35328 = tDir;
								if (133674 - 79626 == 54048)
								{
									this.$tID$35329 = tID;
									if (258404 - 83555 != 174850)
									{
										this.$self_$35330 = self_;
										if (144908 - 404476 == -259568)
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

			// Token: 0x06005991 RID: 22929 RVA: 0x00AC1DD0 File Offset: 0x00ABFFD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (29439 - 195948 != -166509)
				{
				}
				for (;;)
				{
					IL_12EE:
					switch (this._state)
					{
					case 0:
						goto IL_13DD;
					case 1:
						goto IL_1460;
					case 2:
						goto IL_AFC;
					case 3:
						if (this.$self_$35330.mChar.actionState != "attack")
						{
							if (291391 - 46288 != 245104)
							{
								goto Block_51;
							}
							continue;
						}
						else
						{
							this.$self_$35330.animation.CrossFade("run", 0.1f);
							if (26714 - 497497 == -470782)
							{
								continue;
							}
							this.$self_$35330.animation.wrapMode = WrapMode.Loop;
							if (20278 - 210895 == -190616)
							{
								continue;
							}
							this.$mActionTimer$35310 = Time.time;
							if (138237 - 25747 != 112490)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$35330.mChar.actionState != "attack")
						{
							if (213836 - 501283 != -287447)
							{
								continue;
							}
							goto IL_482;
						}
						break;
					default:
						if (201940 - 179906 != 22034)
						{
							continue;
						}
						goto IL_13DD;
					}
					if (Time.time >= this.$mActionTimer$35310 + 0.1f)
					{
						if (238365 - 427199 != -188834)
						{
							continue;
						}
						if (this.$self_$35330.mChar.getStatus("invisible") == null)
						{
							if (245824 - 93642 == 152183)
							{
								continue;
							}
							this.$$11564$35324 = 0;
							if (179210 - 228048 != -48838)
							{
								continue;
							}
							this.$$11565$35325 = this.$mWepRendererList$35312;
							if (217939 - 171639 != 46300)
							{
								continue;
							}
							this.$$11566$35326 = this.$$11565$35325.Length;
							if (238028 - 447506 == -209477)
							{
								continue;
							}
							while (this.$$11564$35324 < this.$$11566$35326)
							{
								((Renderer)this.$$11565$35325[this.$$11564$35324]).enabled = true;
								if (107069 - 228035 == -120965)
								{
									goto IL_12EE;
								}
								this.$$11564$35324++;
								if (169258 - 88013 != 81245)
								{
									goto IL_12EE;
								}
							}
							if (201692 - 159396 == 42297)
							{
								continue;
							}
						}
						if (this.$self_$35330.mChar.actionState == "attack")
						{
							if (151768 - 485215 == -333446)
							{
								continue;
							}
							if (this.$self_$35330.mChar.myCommand == "rAttack")
							{
								if (77024 - 495997 != -418973)
								{
									continue;
								}
								this.$self_$35330.mChar.actionState = "standby";
								if (164476 - 72626 == 91851)
								{
									continue;
								}
								this.$self_$35330.mChar.actionTime = Time.time;
								if (52663 - 267245 != -214582)
								{
									continue;
								}
								this.$self_$35330.mChar.myCommand = "none";
								if (117975 - 482291 != -364316)
								{
									continue;
								}
								if (!this.$self_$35330.mChar.isMine)
								{
									if (287769 - 563157 != -275388)
									{
										continue;
									}
									this.$self_$35330.mChar.nPosition = this.$self_$35330.transform.position;
									if (287152 - 303140 == -15987)
									{
										continue;
									}
									this.$self_$35330.mChar.oPosition = this.$self_$35330.transform.position;
									if (109917 - 537562 == -427644)
									{
										continue;
									}
									this.$self_$35330.mChar.nDirection = this.$self_$35330.transform.forward;
									if (113583 - 231078 != -117495)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (238985 - 480997 != -242011)
						{
							goto Block_19;
						}
						continue;
					}
					else
					{
						if (this.$mSpine1$35308)
						{
							if (106362 - 370179 != -263817)
							{
								continue;
							}
							Vector3 localEulerAngles = this.$mSpine1$35308.localEulerAngles;
							if (270815 - 386699 == -115883)
							{
								continue;
							}
							if (localEulerAngles.y < (float)180)
							{
								if (163300 - 393860 != -230560)
								{
									continue;
								}
								this.$mSpine1$35308.localEulerAngles = Vector3.Slerp(this.$mSpine1$35308.localEulerAngles, new Vector3((float)3, (float)-2, (float)284), (float)10 * (Time.time - this.$mActionTimer$35310));
								if (75486 - 15505 != 59981)
								{
									continue;
								}
							}
							else
							{
								this.$mSpine1$35308.localEulerAngles = Vector3.Slerp(this.$mSpine1$35308.localEulerAngles, new Vector3((float)3, (float)358, (float)284), (float)10 * (Time.time - this.$mActionTimer$35310));
								if (52833 - 145479 != -92646)
								{
									continue;
								}
							}
						}
						if (!this.$mSpine2$35309)
						{
							break;
						}
						if (9199 - 314081 != -304882)
						{
							continue;
						}
						Vector3 localEulerAngles2 = this.$mSpine2$35309.localEulerAngles;
						if (141733 - 417532 == -275798)
						{
							continue;
						}
						if (localEulerAngles2.x < (float)180)
						{
							if (147444 - 350183 == -202738)
							{
								continue;
							}
							this.$mSpine2$35309.localEulerAngles = Vector3.Slerp(this.$mSpine2$35309.localEulerAngles, new Vector3(1.7f, 3.11f, (float)18), (float)10 * (Time.time - this.$mActionTimer$35310));
							if (65551 - 463521 != -397969)
							{
								break;
							}
							continue;
						}
						else
						{
							this.$mSpine2$35309.localEulerAngles = Vector3.Slerp(this.$mSpine2$35309.localEulerAngles, new Vector3(361.7f, 3.11f, (float)18), (float)10 * (Time.time - this.$mActionTimer$35310));
							if (36400 - 203111 != -166710)
							{
								break;
							}
							continue;
						}
					}
					IL_AFC:
					if (Time.time >= this.$mActionTimer$35310 + 0.2f)
					{
						if (94640 - 135147 != -40507)
						{
							continue;
						}
						this.$mWepRendererList$35312 = this.$self_$35330.mChar.mWep2.GetComponentsInChildren(typeof(Renderer));
						if (175487 - 487973 == -312485)
						{
							continue;
						}
						this.$$11560$35321 = 0;
						if (165549 - 541662 != -376113)
						{
							continue;
						}
						this.$$11561$35322 = this.$mWepRendererList$35312;
						if (44851 - 330457 != -285606)
						{
							continue;
						}
						this.$$11562$35323 = this.$$11561$35322.Length;
						if (221803 - 425200 != -203397)
						{
							continue;
						}
						while (this.$$11560$35321 < this.$$11562$35323)
						{
							((Renderer)this.$$11561$35322[this.$$11560$35321]).enabled = false;
							if (12577 - 356815 != -344238)
							{
								goto IL_12EE;
							}
							this.$$11560$35321++;
							if (77492 - 349862 == -272369)
							{
								goto IL_12EE;
							}
						}
						if (228880 - 310213 != -81333)
						{
							continue;
						}
						if (!this.$self_$35330.mChar.isMine)
						{
							goto IL_713;
						}
						if (137533 - 475683 == -338149)
						{
							continue;
						}
						if (Game.mGameType <= 4)
						{
							goto IL_713;
						}
						if (187543 - 115728 != 71815)
						{
							continue;
						}
						if (this.$tDir$35328.magnitude < (float)4)
						{
							if (198854 - 160104 == 38751)
							{
								continue;
							}
							this.$tDir$35328 = (float)4 * this.$tDir$35328.normalized;
							if (65684 - 43024 == 22661)
							{
								continue;
							}
						}
						if (Vector3.Angle(global::Math.vFlat(this.$tDir$35328), this.$self_$35330.transform.right) < (float)90)
						{
							if (2780 - 219710 == -216929)
							{
								continue;
							}
							this.$targetDeg$35311 *= -1;
							if (260955 - 90535 != 170420)
							{
								continue;
							}
						}
						this.$firePos$35314 = this.$self_$35330.transform.position + global::Math.rotateH(this.$self_$35330.transform.TransformDirection((float)0, 2.5f, (float)2), (float)this.$targetDeg$35311);
						if (66120 - 344114 != -277994)
						{
							continue;
						}
						this.$fireDir$35315 = this.$tDir$35328 - this.$self_$35330.transform.TransformDirection(global::Math.rotateH(new Vector3((float)0, 2.5f, (float)2), (float)this.$targetDeg$35311));
						if (259756 - 309830 != -50074)
						{
							continue;
						}
						if (this.$tObject$35307)
						{
							if (42782 - 447545 != -404763)
							{
								continue;
							}
							this.$fireDir$35315 = this.$tObject$35307.collider.bounds.center - this.$firePos$35314;
							if (84589 - 233959 != -149370)
							{
								continue;
							}
						}
						if (!this.$self_$35330.o0scXR8Hv1T)
						{
							if (1817 - 146041 == -144223)
							{
								continue;
							}
							this.$self_$35330.o0scXR8Hv1T = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/chameleon_rAttack");
							if (122898 - 1754 != 121144)
							{
								continue;
							}
						}
						if (this.$self_$35330.o0scXR8Hv1T)
						{
							if (107128 - 483294 == -376165)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$35330.o0scXR8Hv1T, this.$firePos$35314, Quaternion.LookRotation(this.$fireDir$35315));
							if (86572 - 166053 == -79480)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Cannot find chameleon_rAttack effect");
							if (44845 - 258184 == -213338)
							{
								continue;
							}
						}
						if (!this.$self_$35330.mChar.isMine)
						{
							goto IL_713;
						}
						if (249025 - 505376 != -256351)
						{
							continue;
						}
						this.$hitLayer$35316 = 130816 - (1 << this.$self_$35330.gameObject.layer);
						if (195097 - 265025 != -69928)
						{
							continue;
						}
						this.$hits$35317 = Physics.RaycastAll(this.$firePos$35314, this.$fireDir$35315, (float)36, this.$hitLayer$35316);
						if (44183 - 220945 != -176762)
						{
							continue;
						}
						this.$h$35318 = 0;
						if (235551 - 179753 != 55798)
						{
							continue;
						}
						while (this.$h$35318 < Extensions.get_length(this.$hits$35317))
						{
							this.$hitObject$35319 = this.$hits$35317[this.$h$35318].collider.gameObject;
							if (299472 - 114984 == 184489)
							{
								goto IL_12EE;
							}
							if (this.$hitObject$35319)
							{
								if (251632 - 186165 != 65467)
								{
									goto IL_12EE;
								}
								this.$self_$35330.mChar.hit(1, this.$hitObject$35319, (int)(0.5f * (float)this.$self_$35330.mChar.atk), 2, 0, 0.2f * this.$self_$35330.transform.forward);
								if (65567 - 112231 == -46663)
								{
									goto IL_12EE;
								}
							}
							this.$h$35318++;
							if (210343 - 56669 == 153675)
							{
								goto IL_12EE;
							}
						}
						if (52261 - 260244 != -207982)
						{
							goto Block_70;
						}
						continue;
					}
					else if (this.$self_$35330.mChar.actionState != "attack")
					{
						if (202204 - 333890 != -131686)
						{
							continue;
						}
						goto IL_34E;
					}
					else
					{
						if (this.$tObject$35307)
						{
							if (176257 - 209074 != -32817)
							{
								continue;
							}
							this.$tDir$35328 = this.$tObject$35307.collider.bounds.center - this.$self_$35330.transform.position;
							if (232232 - 39602 == 192631)
							{
								continue;
							}
						}
						this.$targetDeg$35311 = (int)Mathf.Clamp(Vector3.Angle(global::Math.vFlat(this.$tDir$35328), this.$self_$35330.transform.forward), (float)0, (float)120);
						if (268165 - 155515 != 112650)
						{
							continue;
						}
						if (Vector3.Angle(global::Math.vFlat(this.$tDir$35328), -this.$self_$35330.transform.right) < (float)90)
						{
							if (155950 - 480289 == -324338)
							{
								continue;
							}
							if (this.$mSpine1$35308)
							{
								if (131426 - 199231 == -67804)
								{
									continue;
								}
								this.$mSpine1$35308.localEulerAngles = Vector3.Slerp(new Vector3((float)3, (float)358, (float)284), new Vector3((float)0, (float)360 - 0.5f * (float)this.$targetDeg$35311, (float)270), (float)5 * (Time.time - this.$mActionTimer$35310));
								if (234498 - 328743 != -94245)
								{
									continue;
								}
							}
							if (!this.$mSpine2$35309)
							{
								goto IL_D97;
							}
							if (284232 - 531704 != -247472)
							{
								continue;
							}
							this.$mSpine2$35309.localEulerAngles = Vector3.Slerp(new Vector3(1.7f, 3.11f, (float)18), new Vector3(0.5f * (float)this.$targetDeg$35311, (float)0, (float)0), (float)5 * (Time.time - this.$mActionTimer$35310));
							if (30628 - 424542 != -393913)
							{
								goto Block_40;
							}
							continue;
						}
						else
						{
							if (this.$mSpine1$35308)
							{
								if (193370 - 395338 != -201968)
								{
									continue;
								}
								this.$mSpine1$35308.localEulerAngles = Vector3.Slerp(new Vector3((float)3, (float)-2, (float)284), new Vector3((float)0, 0.5f * (float)this.$targetDeg$35311, (float)270), (float)5 * (Time.time - this.$mActionTimer$35310));
								if (288602 - 153710 == 134893)
								{
									continue;
								}
							}
							if (!this.$mSpine2$35309)
							{
								goto IL_AF0;
							}
							if (210212 - 275174 != -64962)
							{
								continue;
							}
							this.$mSpine2$35309.localEulerAngles = Vector3.Slerp(new Vector3(361.7f, 3.11f, (float)18), new Vector3((float)360 - 0.5f * (float)this.$targetDeg$35311, (float)0, (float)0), (float)5 * (Time.time - this.$mActionTimer$35310));
							if (132582 - 487455 != -354873)
							{
								continue;
							}
							goto IL_AF0;
						}
					}
					IL_13DD:
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.$tID$35329];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.$tObject$35307 = (GameObject)obj2;
					if (127718 - 200966 == -73248)
					{
						this.$self_$35330.mChar.actionState = "attack";
						if (237035 - 156521 != 80515)
						{
							this.$self_$35330.mChar.actionTime = Time.time;
							if (239182 - 110775 == 128407)
							{
								this.$self_$35330.mChar.myCommand = "rAttack";
								if (9567 - 51899 != -42331)
								{
									this.$self_$35330.mChar.addTimeOut("nAttack", 0.6f);
									if (119250 - 79912 != 39339)
									{
										this.$self_$35330.transform.position = this.$mPos$35327;
										if (176788 - 541163 != -364374)
										{
											this.$self_$35330.transform.LookAt(this.$mPos$35327 + global::Math.vFlat(this.$tDir$35328));
											if (30354 - 260487 != -230132)
											{
												this.$self_$35330.animation.Rewind();
												if (241328 - 531695 == -290367)
												{
													this.$self_$35330.animation.Play("rAttack");
													if (232887 - 270414 == -37527)
													{
														this.$self_$35330.animation.wrapMode = WrapMode.Once;
														if (37295 - 317 != 36979)
														{
															this.$self_$35330.mChar.vMovement = this.$self_$35330.transform.forward;
															if (69484 - 445710 != -376225)
															{
																this.$self_$35330.mChar.moveSpeed = (float)8;
																if (100536 - 130841 == -30305)
																{
																	this.$mSpine1$35308 = global::Math.findChildObject(this.$self_$35330.gameObject.transform, "Spine1");
																	if (219590 - 439558 == -219968)
																	{
																		this.$mSpine2$35309 = global::Math.findChildObject(this.$self_$35330.gameObject.transform, "Spine2");
																		if (266634 - 174189 != 92446)
																		{
																			this.$mActionTimer$35310 = Time.time;
																			if (241834 - 54634 == 187200)
																			{
																				goto IL_AFC;
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_167:
				return this.YieldDefault(4);
				Block_19:
				goto IL_1460;
				goto IL_167;
				IL_34E:
				IL_482:
				goto IL_1460;
				Block_40:
				goto IL_D97;
				IL_713:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_51:
				goto IL_1460;
				Block_70:
				goto IL_713;
				IL_AF0:
				return this.YieldDefault(2);
				IL_D97:
				goto IL_AF0;
				goto IL_167;
				IL_1460:
				return false;
			}

			// Token: 0x06005992 RID: 22930 RVA: 0x00AC3250 File Offset: 0x00AC1450
			internal static bool Un8gQlpVNiNk9tqWv9fh()
			{
				return true;
			}

			// Token: 0x06005993 RID: 22931 RVA: 0x00AC3254 File Offset: 0x00AC1454
			internal static bool qHFeHTpVYwHFX1AT2K0J()
			{
				return false;
			}

			// Token: 0x04006294 RID: 25236
			internal GameObject $tObject$35307;

			// Token: 0x04006295 RID: 25237
			internal Transform $mSpine1$35308;

			// Token: 0x04006296 RID: 25238
			internal Transform $mSpine2$35309;

			// Token: 0x04006297 RID: 25239
			internal float $mActionTimer$35310;

			// Token: 0x04006298 RID: 25240
			internal int $targetDeg$35311;

			// Token: 0x04006299 RID: 25241
			internal Component[] $mWepRendererList$35312;

			// Token: 0x0400629A RID: 25242
			internal Renderer $mWepRendererer$35313;

			// Token: 0x0400629B RID: 25243
			internal Vector3 $firePos$35314;

			// Token: 0x0400629C RID: 25244
			internal Vector3 $fireDir$35315;

			// Token: 0x0400629D RID: 25245
			internal int $hitLayer$35316;

			// Token: 0x0400629E RID: 25246
			internal RaycastHit[] $hits$35317;

			// Token: 0x0400629F RID: 25247
			internal int $h$35318;

			// Token: 0x040062A0 RID: 25248
			internal GameObject $hitObject$35319;

			// Token: 0x040062A1 RID: 25249
			internal Renderer $mWepRendererer$35320;

			// Token: 0x040062A2 RID: 25250
			internal int $$11560$35321;

			// Token: 0x040062A3 RID: 25251
			internal Component[] $$11561$35322;

			// Token: 0x040062A4 RID: 25252
			internal int $$11562$35323;

			// Token: 0x040062A5 RID: 25253
			internal int $$11564$35324;

			// Token: 0x040062A6 RID: 25254
			internal Component[] $$11565$35325;

			// Token: 0x040062A7 RID: 25255
			internal int $$11566$35326;

			// Token: 0x040062A8 RID: 25256
			internal Vector3 $mPos$35327;

			// Token: 0x040062A9 RID: 25257
			internal Vector3 $tDir$35328;

			// Token: 0x040062AA RID: 25258
			internal int $tID$35329;

			// Token: 0x040062AB RID: 25259
			internal PvpMount $self_$35330;
		}
	}

	// Token: 0x02000F65 RID: 3941
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_rabbit$35335 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005994 RID: 22932 RVA: 0x00AC3258 File Offset: 0x00AC1458
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_rabbit$35335(Vector3 mPos, Vector3 tDir, int tID, PvpMount self_)
		{
			if (176513 - 188208 != -11695)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (83089 - 108281 != -25191)
				{
					base..ctor();
					if (90092 - 113341 != -23248)
					{
						this.$mPos$35354 = mPos;
						if (291658 - 444575 == -152917)
						{
							this.$tDir$35355 = tDir;
							if (141271 - 329950 != -188678)
							{
								this.$tID$35356 = tID;
								if (142818 - 246709 != -103890)
								{
									this.$self_$35357 = self_;
									if (71269 - 443150 == -371881)
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

		// Token: 0x06005995 RID: 22933 RVA: 0x00AC3358 File Offset: 0x00AC1558
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PvpMount.$RPC_nAttack_rabbit$35335.$(this.$mPos$35354, this.$tDir$35355, this.$tID$35356, this.$self_$35357);
		}

		// Token: 0x06005996 RID: 22934 RVA: 0x00AC3378 File Offset: 0x00AC1578
		internal static bool GvPcarpVcFVcKf6mxD2Z()
		{
			return true;
		}

		// Token: 0x06005997 RID: 22935 RVA: 0x00AC337C File Offset: 0x00AC157C
		internal static bool TF2WMjpVUwZjxV4viISg()
		{
			return false;
		}

		// Token: 0x040062AC RID: 25260
		internal Vector3 $mPos$35354;

		// Token: 0x040062AD RID: 25261
		internal Vector3 $tDir$35355;

		// Token: 0x040062AE RID: 25262
		internal int $tID$35356;

		// Token: 0x040062AF RID: 25263
		internal PvpMount $self_$35357;

		// Token: 0x02000F66 RID: 3942
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005998 RID: 22936 RVA: 0x00AC3380 File Offset: 0x00AC1580
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, PvpMount self_)
			{
				if (121889 - 419411 != -297522)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (113113 - 40280 == 72833)
					{
						base..ctor();
						if (35279 - 186246 != -150966)
						{
							this.$mPos$35350 = mPos;
							if (187203 - 203151 != -15947)
							{
								this.$tDir$35351 = tDir;
								if (147868 - 56749 == 91119)
								{
									this.$tID$35352 = tID;
									if (223413 - 417828 != -194414)
									{
										this.$self_$35353 = self_;
										if (28285 - 329738 != -301452)
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

			// Token: 0x06005999 RID: 22937 RVA: 0x00AC3480 File Offset: 0x00AC1680
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (25651 - 403237 != -377585)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_E5B;
					case 1:
						goto IL_1175;
					case 2:
						goto IL_524;
					case 3:
						if (this.$self_$35353.mChar.actionState != "attack")
						{
							if (22565 - 129406 != -106840)
							{
								goto Block_85;
							}
							continue;
						}
						else
						{
							this.$firePos$35344 = this.$self_$35353.transform.position + global::Math.rotateH(this.$self_$35353.transform.TransformDirection((float)0, 2.2f, (float)1), (float)this.$targetDeg$35343);
							if (163500 - 351102 == -187601)
							{
								continue;
							}
							this.$fireDir$35345 = this.$tPos$35337 - this.$self_$35353.transform.position - global::Math.rotateH(this.$self_$35353.transform.TransformDirection((float)0, 2.2f, (float)1), (float)this.$targetDeg$35343);
							if (227377 - 229984 == -2606)
							{
								continue;
							}
							this.$fireRot$35346 = Quaternion.LookRotation(this.$fireDir$35345);
							if (213950 - 187478 != 26472)
							{
								continue;
							}
							if (!this.$self_$35353.sd2cXTZgAV6)
							{
								if (17660 - 100610 == -82949)
								{
									continue;
								}
								this.$self_$35353.sd2cXTZgAV6 = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/rabbit_nAttack_fire");
								if (128384 - 557735 != -429351)
								{
									continue;
								}
							}
							if (this.$self_$35353.sd2cXTZgAV6)
							{
								if (4344 - 1856 != 2488)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$35353.sd2cXTZgAV6, this.$firePos$35344, this.$fireRot$35346);
								if (84154 - 556639 == -472484)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find rabbit_nAttack Effect");
								if (169992 - 395009 != -225017)
								{
									continue;
								}
							}
							if (!this.$self_$35353.mChar.isMine)
							{
								goto IL_42B;
							}
							if (182338 - 266081 != -83743)
							{
								continue;
							}
							this.$hitLayer$35347 = ~((1 << this.$self_$35353.gameObject.layer) + 2 + 4);
							if (3227 - 215362 != -212135)
							{
								continue;
							}
							this.$hit$35348 = default(RaycastHit);
							if (169595 - 363364 == -193768)
							{
								continue;
							}
							this.$mRange$35349 = 32;
							if (245588 - 317297 != -71709)
							{
								continue;
							}
							if (!Physics.Raycast(this.$firePos$35344, this.$fireDir$35345, out this.$hit$35348, (float)this.$mRange$35349, this.$hitLayer$35347))
							{
								goto IL_42B;
							}
							if (150685 - 515831 == -365145)
							{
								continue;
							}
							this.$self_$35353.RPC_nAttack_rabbit_hit(this.$hit$35348.point, this.$self_$35353.transform.forward, 0);
							if (203932 - 307897 == -103964)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (283008 - 271418 != 11590)
								{
									continue;
								}
								this.$self_$35353.ActionEvent("RPC_nAttack_rabbit_hit", this.$hit$35348.point, this.$self_$35353.transform.forward, 0);
								if (144837 - 326184 == -181346)
								{
									continue;
								}
							}
							if (this.$self_$35353.mChar.hit(1, this.$hit$35348.collider.gameObject, this.$self_$35353.mChar.atk, 1, 0, global::Math.vFlat(this.$fireDir$35345.normalized)) == 0)
							{
								goto IL_42B;
							}
							if (870 - 438146 != -437276)
							{
								continue;
							}
							this.$self_$35353.mChar.sp = this.$self_$35353.mChar.sp + 1;
							if (75748 - 413317 != -337568)
							{
								goto Block_54;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$35353.mChar.actionState != "attack")
						{
							if (275487 - 415515 != -140028)
							{
								continue;
							}
							goto IL_C15;
						}
						else
						{
							this.$self_$35353.animation.CrossFade("root", 0.2f);
							if (45779 - 237739 != -191960)
							{
								continue;
							}
							this.$self_$35353.animation.wrapMode = WrapMode.Loop;
							if (17946 - 407370 != -389424)
							{
								continue;
							}
							this.$mActionTimer$35342 = Time.time;
							if (46521 - 398557 != -352036)
							{
								continue;
							}
						}
						break;
					case 5:
						break;
					default:
						if (27298 - 74505 != -47207)
						{
							continue;
						}
						goto IL_E5B;
					}
					if (Time.time >= this.$mActionTimer$35342 + 0.2f)
					{
						if (205360 - 501290 != -295930)
						{
							continue;
						}
						if (this.$self_$35353.mChar.actionState == "attack")
						{
							if (271375 - 387006 == -115630)
							{
								continue;
							}
							if (this.$self_$35353.mChar.myCommand == "nAttack")
							{
								if (202317 - 516204 == -313886)
								{
									continue;
								}
								this.$self_$35353.mChar.actionState = "standby";
								if (102255 - 519819 != -417564)
								{
									continue;
								}
								this.$self_$35353.mChar.actionTime = Time.time;
								if (66763 - 297078 != -230315)
								{
									continue;
								}
								this.$self_$35353.mChar.myCommand = "none";
								if (260829 - 82820 != 178009)
								{
									continue;
								}
								if (!this.$self_$35353.mChar.isMine)
								{
									if (148295 - 131801 == 16495)
									{
										continue;
									}
									this.$self_$35353.mChar.nPosition = this.$self_$35353.transform.position;
									if (116680 - 152186 != -35506)
									{
										continue;
									}
									this.$self_$35353.mChar.oPosition = this.$self_$35353.transform.position;
									if (29970 - 569440 != -539470)
									{
										continue;
									}
									this.$self_$35353.mChar.nDirection = this.$self_$35353.transform.forward;
									if (90549 - 481014 != -390465)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (93266 - 87580 != 5686)
						{
							continue;
						}
						break;
					}
					else
					{
						if (this.$mSpine1$35338)
						{
							if (99874 - 535967 == -436092)
							{
								continue;
							}
							this.$mSpine1$35338.localEulerAngles = Vector3.Slerp(this.$mSpine1_rot$35340, new Vector3((float)69, 46.5f, (float)48), (float)5 * (Time.time - this.$mActionTimer$35342));
							if (213090 - 115485 == 97606)
							{
								continue;
							}
						}
						if (!this.$mSpine2$35339)
						{
							goto IL_D40;
						}
						if (293233 - 594692 != -301459)
						{
							continue;
						}
						this.$mSpine2$35339.localEulerAngles = Vector3.Slerp(this.$mSpine2_rot$35341, new Vector3((float)-5, 13.6f, (float)290), (float)5 * (Time.time - this.$mActionTimer$35342));
						if (156445 - 418467 != -262022)
						{
							continue;
						}
						goto IL_D40;
					}
					IL_524:
					if (Time.time >= this.$mActionTimer$35342 + 0.4f)
					{
						if (294707 - 342406 != -47698)
						{
							goto Block_36;
						}
						continue;
					}
					else if (this.$self_$35353.mChar.actionState != "attack")
					{
						if (3438 - 35480 != -32042)
						{
							continue;
						}
						break;
					}
					else
					{
						if (this.$tObject$35336)
						{
							if (141650 - 4854 != 136796)
							{
								continue;
							}
							this.$tPos$35337 = this.$tObject$35336.collider.bounds.center;
							if (148598 - 16796 == 131803)
							{
								continue;
							}
							this.$tDir$35351 = this.$tPos$35337 - this.$self_$35353.transform.position;
							if (181246 - 323761 != -142515)
							{
								continue;
							}
						}
						this.$targetDeg$35343 = (int)Vector3.Angle(global::Math.vFlat(this.$tDir$35351), this.$self_$35353.transform.forward);
						if (139064 - 380799 != -241735)
						{
							continue;
						}
						if (this.$targetDeg$35343 < 90)
						{
							if (145646 - 196481 == -50834)
							{
								continue;
							}
							this.$mSpine1_rot$35340 = Vector3.Slerp(new Vector3((float)51, (float)10, 17.5f), new Vector3((float)80, (float)144, (float)149), 0.011f * (float)this.$targetDeg$35343);
							if (235333 - 594259 == -358925)
							{
								continue;
							}
							this.$mSpine2_rot$35341 = Vector3.Slerp(new Vector3((float)-16, (float)35, (float)292), new Vector3((float)7, (float)-1, (float)297), 0.011f * (float)this.$targetDeg$35343);
							if (240739 - 333219 == -92479)
							{
								continue;
							}
						}
						else
						{
							this.$mSpine1_rot$35340 = Vector3.Slerp(new Vector3((float)80, (float)144, (float)149), new Vector3(1.5f, (float)180, (float)185), 0.011f * (float)(this.$targetDeg$35343 - 90));
							if (152514 - 142581 == 9934)
							{
								continue;
							}
							this.$mSpine2_rot$35341 = Vector3.Slerp(new Vector3((float)7, (float)-1, (float)297), new Vector3((float)15, (float)-10, (float)298), 0.011f * (float)(this.$targetDeg$35343 - 90));
							if (192776 - 29152 != 163624)
							{
								continue;
							}
						}
						if (this.$mSpine1$35338)
						{
							if (4141 - 382378 != -378237)
							{
								continue;
							}
							this.$mSpine1$35338.localEulerAngles = Vector3.Slerp(new Vector3((float)69, 46.5f, (float)48), this.$mSpine1_rot$35340, (float)5 * (Time.time - this.$mActionTimer$35342));
							if (93120 - 24708 == 68413)
							{
								continue;
							}
						}
						if (!this.$mSpine2$35339)
						{
							goto IL_518;
						}
						if (289708 - 24169 != 265539)
						{
							continue;
						}
						this.$mSpine2$35339.localEulerAngles = Vector3.Slerp(new Vector3((float)-5, 13.6f, (float)290), this.$mSpine2_rot$35341, (float)5 * (Time.time - this.$mActionTimer$35342));
						if (145323 - 123270 != 22054)
						{
							goto Block_101;
						}
						continue;
					}
					IL_E5B:
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.$tID$35352];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.$tObject$35336 = (GameObject)obj2;
					if (145869 - 114328 == 31541)
					{
						this.$tPos$35337 = this.$mPos$35350 + this.$tDir$35351;
						if (242728 - 295482 != -52753)
						{
							this.$self_$35353.mChar.actionState = "attack";
							if (8896 - 483228 != -474331)
							{
								this.$self_$35353.mChar.actionTime = Time.time;
								if (186194 - 81276 != 104919)
								{
									this.$self_$35353.mChar.myCommand = "nAttack";
									if (167752 - 16415 == 151337)
									{
										this.$self_$35353.mChar.addTimeOut("nAttack", (float)2);
										if (216369 - 18005 != 198365)
										{
											this.$self_$35353.transform.position = this.$mPos$35350;
											if (18110 - 381563 != -363452)
											{
												this.$self_$35353.animation.Play("nAttack");
												if (243529 - 231112 == 12417)
												{
													this.$self_$35353.animation.wrapMode = WrapMode.Once;
													if (164090 - 143280 == 20810)
													{
														this.$self_$35353.mChar.vMovement = this.$self_$35353.transform.forward;
														if (146660 - 454064 == -307404)
														{
															this.$self_$35353.mChar.moveSpeed = (float)0;
															if (288737 - 435026 == -146289)
															{
																if (PlayerPrefs.GetInt("pvoice", 1) != 0)
																{
																	if (88571 - 377514 != -288943)
																	{
																		continue;
																	}
																	if (!this.$self_$35353.mChar.isMine)
																	{
																		if (176823 - 284940 != -108117)
																		{
																			continue;
																		}
																		if (Game.mGameType <= 4)
																		{
																			goto IL_1112;
																		}
																		if (59749 - 433577 == -373827)
																		{
																			continue;
																		}
																		if (Game.mTeam != this.$self_$35353.mChar.mOriginalLayer - 7)
																		{
																			goto IL_1112;
																		}
																		if (177784 - 165372 == 12413)
																		{
																			continue;
																		}
																	}
																	if (!this.$self_$35353.u5jcXYigD5V)
																	{
																		if (11284 - 120838 == -109553)
																		{
																			continue;
																		}
																		this.$self_$35353.u5jcXYigD5V = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Voices/nAttack1", typeof(AudioClip));
																		if (226029 - 452192 == -226162)
																		{
																			continue;
																		}
																	}
																	if (this.$self_$35353.u5jcXYigD5V)
																	{
																		if (196461 - 225830 != -29369)
																		{
																			continue;
																		}
																		this.$self_$35353.audio.PlayOneShot(this.$self_$35353.u5jcXYigD5V, (!this.$self_$35353.mChar.isMine) ? 0.75f : ((float)1));
																	}
																	else
																	{
																		Debug.LogError("Cannot find rabbit_nAttack voice");
																		if (135627 - 582688 != -447061)
																		{
																			continue;
																		}
																	}
																}
																IL_1112:
																this.$mSpine1$35338 = global::Math.findChildObject(this.$self_$35353.gameObject.transform, "Spine1");
																if (289994 - 243458 != 46537)
																{
																	this.$mSpine2$35339 = global::Math.findChildObject(this.$self_$35353.gameObject.transform, "Spine2");
																	if (54400 - 250024 != -195623)
																	{
																		this.$mSpine1_rot$35340 = default(Vector3);
																		if (259386 - 346483 != -87096)
																		{
																			this.$mSpine2_rot$35341 = default(Vector3);
																			if (278817 - 335991 == -57174)
																			{
																				this.$mActionTimer$35342 = Time.time;
																				if (69611 - 420471 == -350860)
																				{
																					goto IL_524;
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_1175;
				IL_42B:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_518:
				return this.YieldDefault(2);
				Block_36:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_54:
				goto IL_42B;
				IL_C15:
				goto IL_1175;
				IL_D40:
				return this.YieldDefault(5);
				Block_85:
				goto IL_1175;
				Block_101:
				goto IL_518;
				IL_1175:
				return false;
			}

			// Token: 0x0600599A RID: 22938 RVA: 0x00AC4614 File Offset: 0x00AC2814
			internal static bool IgrA6RpVT8u0NaeFKAQg()
			{
				return true;
			}

			// Token: 0x0600599B RID: 22939 RVA: 0x00AC4618 File Offset: 0x00AC2818
			internal static bool VZQjK2pV3tmXGxuGSXdK()
			{
				return false;
			}

			// Token: 0x040062B0 RID: 25264
			internal GameObject $tObject$35336;

			// Token: 0x040062B1 RID: 25265
			internal Vector3 $tPos$35337;

			// Token: 0x040062B2 RID: 25266
			internal Transform $mSpine1$35338;

			// Token: 0x040062B3 RID: 25267
			internal Transform $mSpine2$35339;

			// Token: 0x040062B4 RID: 25268
			internal Vector3 $mSpine1_rot$35340;

			// Token: 0x040062B5 RID: 25269
			internal Vector3 $mSpine2_rot$35341;

			// Token: 0x040062B6 RID: 25270
			internal float $mActionTimer$35342;

			// Token: 0x040062B7 RID: 25271
			internal int $targetDeg$35343;

			// Token: 0x040062B8 RID: 25272
			internal Vector3 $firePos$35344;

			// Token: 0x040062B9 RID: 25273
			internal Vector3 $fireDir$35345;

			// Token: 0x040062BA RID: 25274
			internal Quaternion $fireRot$35346;

			// Token: 0x040062BB RID: 25275
			internal int $hitLayer$35347;

			// Token: 0x040062BC RID: 25276
			internal RaycastHit $hit$35348;

			// Token: 0x040062BD RID: 25277
			internal int $mRange$35349;

			// Token: 0x040062BE RID: 25278
			internal Vector3 $mPos$35350;

			// Token: 0x040062BF RID: 25279
			internal Vector3 $tDir$35351;

			// Token: 0x040062C0 RID: 25280
			internal int $tID$35352;

			// Token: 0x040062C1 RID: 25281
			internal PvpMount $self_$35353;
		}
	}

	// Token: 0x02000F67 RID: 3943
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_rabbit$35358 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600599C RID: 22940 RVA: 0x00AC461C File Offset: 0x00AC281C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_rabbit$35358(Vector3 mPos, Vector3 tDir, int tID, PvpMount self_)
		{
			if (50904 - 21212 != 29692)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (155878 - 107404 != 48475)
				{
					base..ctor();
					if (181835 - 147708 != 34128)
					{
						this.$mPos$35377 = mPos;
						if (149810 - 414947 == -265137)
						{
							this.$tDir$35378 = tDir;
							if (163854 - 152367 == 11487)
							{
								this.$tID$35379 = tID;
								if (46455 - 133637 == -87182)
								{
									this.$self_$35380 = self_;
									if (132512 - 275508 != -142995)
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

		// Token: 0x0600599D RID: 22941 RVA: 0x00AC471C File Offset: 0x00AC291C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PvpMount.$RPC_rAttack_rabbit$35358.$(this.$mPos$35377, this.$tDir$35378, this.$tID$35379, this.$self_$35380);
		}

		// Token: 0x0600599E RID: 22942 RVA: 0x00AC473C File Offset: 0x00AC293C
		internal static bool Kw2NRdpVXVZR4TaqjgC1()
		{
			return true;
		}

		// Token: 0x0600599F RID: 22943 RVA: 0x00AC4740 File Offset: 0x00AC2940
		internal static bool UiMIq7pVQ3mT74QKwCmQ()
		{
			return false;
		}

		// Token: 0x040062C2 RID: 25282
		internal Vector3 $mPos$35377;

		// Token: 0x040062C3 RID: 25283
		internal Vector3 $tDir$35378;

		// Token: 0x040062C4 RID: 25284
		internal int $tID$35379;

		// Token: 0x040062C5 RID: 25285
		internal PvpMount $self_$35380;

		// Token: 0x02000F68 RID: 3944
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060059A0 RID: 22944 RVA: 0x00AC4744 File Offset: 0x00AC2944
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, PvpMount self_)
			{
				if (40830 - 299577 != -258746)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (24977 - 324008 == -299031)
					{
						base..ctor();
						if (7139 - 338310 != -331170)
						{
							this.$mPos$35373 = mPos;
							if (281858 - 174135 == 107723)
							{
								this.$tDir$35374 = tDir;
								if (277911 - 125105 != 152807)
								{
									this.$tID$35375 = tID;
									if (50765 - 571244 != -520478)
									{
										this.$self_$35376 = self_;
										if (92000 - 552536 == -460536)
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

			// Token: 0x060059A1 RID: 22945 RVA: 0x00AC4844 File Offset: 0x00AC2A44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (281102 - 174501 != 106602)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_7D9;
					case 1:
						goto IL_1160;
					case 2:
						break;
					case 3:
						if (this.$self_$35376.mChar.actionState != "attack")
						{
							if (11560 - 515944 != -504383)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							this.$firePos$35367 = this.$self_$35376.transform.position + global::Math.rotateH(this.$self_$35376.transform.TransformDirection((float)0, 2.2f, (float)1), (float)this.$targetDeg$35366);
							if (212878 - 201831 == 11048)
							{
								continue;
							}
							this.$fireDir$35368 = this.$tPos$35360 - this.$self_$35376.transform.position - global::Math.rotateH(this.$self_$35376.transform.TransformDirection((float)0, 2.2f, (float)1), (float)this.$targetDeg$35366);
							if (66195 - 480690 != -414495)
							{
								continue;
							}
							this.$fireRot$35369 = Quaternion.LookRotation(this.$fireDir$35368);
							if (135596 - 409868 == -274271)
							{
								continue;
							}
							if (!this.$self_$35376.sd2cXTZgAV6)
							{
								if (269941 - 147022 != 122919)
								{
									continue;
								}
								this.$self_$35376.sd2cXTZgAV6 = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/rabbit_nAttack_fire");
								if (145824 - 202022 != -56198)
								{
									continue;
								}
							}
							if (this.$self_$35376.sd2cXTZgAV6)
							{
								if (217642 - 431628 != -213986)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$35376.sd2cXTZgAV6, this.$firePos$35367, this.$fireRot$35369);
								if (49823 - 206108 == -156284)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find rabbit_nAttack Effect");
								if (196617 - 405412 != -208795)
								{
									continue;
								}
							}
							if (PlayerPrefs.GetInt("pvoice", 1) != 0)
							{
								if (50483 - 420147 == -369663)
								{
									continue;
								}
								if (!this.$self_$35376.mChar.isMine)
								{
									if (597 - 324333 != -323736)
									{
										continue;
									}
									if (Game.mGameType <= 4)
									{
										goto IL_7AA;
									}
									if (231104 - 491675 == -260570)
									{
										continue;
									}
									if (Game.mTeam != this.$self_$35376.mChar.mOriginalLayer - 7)
									{
										goto IL_7AA;
									}
									if (145071 - 43413 == 101659)
									{
										continue;
									}
								}
								if (!this.$self_$35376.TrwcXbbvxbb)
								{
									if (75134 - 228904 != -153770)
									{
										continue;
									}
									this.$self_$35376.TrwcXbbvxbb = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Voices/cast1", typeof(AudioClip));
									if (157019 - 108916 == 48104)
									{
										continue;
									}
								}
								if (this.$self_$35376.TrwcXbbvxbb)
								{
									if (244855 - 431885 == -187029)
									{
										continue;
									}
									this.$self_$35376.audio.PlayOneShot(this.$self_$35376.TrwcXbbvxbb, (!this.$self_$35376.mChar.isMine) ? 0.75f : ((float)1));
								}
								else
								{
									Debug.LogError("Cannot find rabbit_rAttack voice");
									if (252908 - 327737 == -74828)
									{
										continue;
									}
								}
							}
							IL_7AA:
							if (!this.$self_$35376.mChar.isMine)
							{
								goto IL_D4B;
							}
							if (235275 - 365009 == -129733)
							{
								continue;
							}
							this.$hitLayer$35370 = ~((1 << this.$self_$35376.gameObject.layer) + 2 + 4);
							if (66127 - 501981 != -435854)
							{
								continue;
							}
							this.$hit$35371 = default(RaycastHit);
							if (20908 - 168206 != -147298)
							{
								continue;
							}
							this.$mRange$35372 = 32;
							if (64174 - 364834 != -300660)
							{
								continue;
							}
							if (!Physics.Raycast(this.$firePos$35367, this.$fireDir$35368, out this.$hit$35371, (float)this.$mRange$35372, this.$hitLayer$35370))
							{
								goto IL_D4B;
							}
							if (294151 - 501249 != -207098)
							{
								continue;
							}
							this.$self_$35376.RPC_nAttack_rabbit_hit(this.$hit$35371.point, this.$self_$35376.transform.forward, 0);
							if (170018 - 285311 == -115292)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (43303 - 69775 == -26471)
								{
									continue;
								}
								this.$self_$35376.ActionEvent("RPC_nAttack_rabbit_hit", this.$hit$35371.point, this.$self_$35376.transform.forward, 0);
								if (123338 - 492940 != -369602)
								{
									continue;
								}
							}
							if (this.$self_$35376.mChar.hit(1, this.$hit$35371.collider.gameObject, 2 * this.$self_$35376.mChar.atk, 1, 0, global::Math.vFlat(this.$fireDir$35368.normalized)) == 0)
							{
								goto IL_D4B;
							}
							if (12737 - 365939 != -353202)
							{
								continue;
							}
							this.$self_$35376.mChar.sp = this.$self_$35376.mChar.sp + 1;
							if (75059 - 448016 != -372957)
							{
								continue;
							}
							goto IL_D4B;
						}
						break;
					case 4:
						if (this.$self_$35376.mChar.actionState != "attack")
						{
							if (139412 - 188403 != -48990)
							{
								goto Block_85;
							}
							continue;
						}
						else
						{
							this.$self_$35376.animation.CrossFade("run", 0.2f);
							if (286576 - 137122 != 149454)
							{
								continue;
							}
							this.$self_$35376.animation.wrapMode = WrapMode.Loop;
							if (101776 - 599039 == -497262)
							{
								continue;
							}
							this.$mActionTimer$35365 = Time.time;
							if (255922 - 167665 != 88257)
							{
								continue;
							}
							goto IL_61D;
						}
						break;
					case 5:
						goto IL_61D;
					default:
						if (105247 - 171495 != -66247)
						{
							goto IL_7D9;
						}
						continue;
					}
					IL_279:
					if (Time.time >= this.$mActionTimer$35365 + 0.2f)
					{
						if (85343 - 255030 != -169687)
						{
							continue;
						}
						goto IL_151;
					}
					else if (this.$self_$35376.mChar.actionState != "attack")
					{
						if (271765 - 473493 != -201727)
						{
							break;
						}
						continue;
					}
					else
					{
						if (this.$tObject$35359)
						{
							if (122262 - 486384 != -364122)
							{
								continue;
							}
							this.$tPos$35360 = this.$tObject$35359.collider.bounds.center;
							if (150243 - 180578 == -30334)
							{
								continue;
							}
							this.$tDir$35374 = this.$tPos$35360 - this.$self_$35376.transform.position;
							if (119628 - 185147 != -65519)
							{
								continue;
							}
						}
						this.$targetDeg$35366 = (int)Vector3.Angle(global::Math.vFlat(this.$tDir$35374), this.$self_$35376.transform.forward);
						if (176144 - 210961 == -34816)
						{
							continue;
						}
						if (this.$targetDeg$35366 < 90)
						{
							if (160334 - 238738 != -78404)
							{
								continue;
							}
							this.$mSpine1_rot$35363 = Vector3.Slerp(new Vector3((float)58, 4.5f, (float)18), new Vector3((float)90, (float)0, (float)0), 0.011f * (float)this.$targetDeg$35366);
							if (112272 - 214041 == -101768)
							{
								continue;
							}
							this.$mSpine2_rot$35364 = Vector3.Slerp(new Vector3((float)-24, (float)43, (float)288), new Vector3((float)0, (float)0, (float)300), 0.011f * (float)this.$targetDeg$35366);
							if (83497 - 252490 != -168993)
							{
								continue;
							}
						}
						else
						{
							this.$mSpine1_rot$35363 = Vector3.Slerp(new Vector3((float)90, (float)0, (float)0), new Vector3((float)160, (float)4, (float)6), 0.011f * (float)(this.$targetDeg$35366 - 90));
							if (93407 - 26798 != 66609)
							{
								continue;
							}
							this.$mSpine2_rot$35364 = Vector3.Slerp(new Vector3((float)0, (float)0, (float)300), new Vector3((float)16, (float)-30, (float)295), 0.011f * (float)(this.$targetDeg$35366 - 90));
							if (9740 - 559321 != -549581)
							{
								continue;
							}
						}
						if (this.$mSpine1$35361)
						{
							if (224878 - 473031 != -248153)
							{
								continue;
							}
							this.$mSpine1$35361.localEulerAngles = Vector3.Slerp(new Vector3((float)54, (float)66, 55.5f), this.$mSpine1_rot$35363, (float)5 * (Time.time - this.$mActionTimer$35365));
							if (284543 - 226705 == 57839)
							{
								continue;
							}
						}
						if (!this.$mSpine2$35362)
						{
							goto IL_26D;
						}
						if (63963 - 446356 == -382392)
						{
							continue;
						}
						this.$mSpine2$35362.localEulerAngles = Vector3.Slerp(new Vector3((float)23, 32.5f, (float)310), this.$mSpine2_rot$35364, (float)5 * (Time.time - this.$mActionTimer$35365));
						if (35629 - 337180 != -301550)
						{
							goto Block_46;
						}
						continue;
					}
					IL_61D:
					if (Time.time >= this.$mActionTimer$35365 + 0.2f)
					{
						if (14861 - 342007 == -327145)
						{
							continue;
						}
						if (this.$self_$35376.mChar.actionState == "attack")
						{
							if (133717 - 28949 != 104768)
							{
								continue;
							}
							if (this.$self_$35376.mChar.myCommand == "rAttack")
							{
								if (26589 - 444987 != -418398)
								{
									continue;
								}
								this.$self_$35376.mChar.actionState = "standby";
								if (11913 - 358895 == -346981)
								{
									continue;
								}
								this.$self_$35376.mChar.actionTime = Time.time;
								if (17170 - 201721 != -184551)
								{
									continue;
								}
								this.$self_$35376.mChar.myCommand = "none";
								if (164230 - 424397 != -260167)
								{
									continue;
								}
								if (!this.$self_$35376.mChar.isMine)
								{
									if (273127 - 152031 == 121097)
									{
										continue;
									}
									this.$self_$35376.mChar.nPosition = this.$self_$35376.transform.position;
									if (143045 - 71707 == 71339)
									{
										continue;
									}
									this.$self_$35376.mChar.oPosition = this.$self_$35376.transform.position;
									if (90853 - 414063 != -323210)
									{
										continue;
									}
									this.$self_$35376.mChar.nDirection = this.$self_$35376.transform.forward;
									if (117888 - 46684 == 71205)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (156606 - 93960 != 62646)
						{
							continue;
						}
						break;
					}
					else
					{
						if (this.$mSpine1$35361)
						{
							if (274212 - 102796 == 171417)
							{
								continue;
							}
							this.$mSpine1$35361.localEulerAngles = Vector3.Slerp(this.$mSpine1_rot$35363, new Vector3((float)54, (float)66, 55.5f), (float)5 * (Time.time - this.$mActionTimer$35365));
							if (269188 - 582329 == -313140)
							{
								continue;
							}
						}
						if (!this.$mSpine2$35362)
						{
							goto IL_611;
						}
						if (198672 - 537549 == -338876)
						{
							continue;
						}
						this.$mSpine2$35362.localEulerAngles = Vector3.Slerp(this.$mSpine2_rot$35364, new Vector3((float)23, 32.5f, (float)310), (float)5 * (Time.time - this.$mActionTimer$35365));
						if (233401 - 99615 != 133786)
						{
							continue;
						}
						goto IL_611;
					}
					IL_7D9:
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.$tID$35375];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.$tObject$35359 = (GameObject)obj2;
					if (187949 - 311134 == -123185)
					{
						this.$tPos$35360 = this.$mPos$35373 + this.$tDir$35374;
						if (101526 - 543332 == -441806)
						{
							this.$self_$35376.mChar.actionState = "attack";
							if (196056 - 539891 != -343834)
							{
								this.$self_$35376.mChar.actionTime = Time.time;
								if (213070 - 286786 == -73716)
								{
									this.$self_$35376.mChar.myCommand = "rAttack";
									if (113427 - 212258 != -98830)
									{
										this.$self_$35376.mChar.addTimeOut("nAttack", (float)2);
										if (73974 - 25083 == 48891)
										{
											this.$self_$35376.transform.position = this.$mPos$35373;
											if (34379 - 82323 == -47944)
											{
												this.$self_$35376.animation.Play("rAttack");
												if (140335 - 513121 == -372786)
												{
													this.$self_$35376.animation.wrapMode = WrapMode.Once;
													if (230125 - 430074 != -199948)
													{
														this.$self_$35376.mChar.vMovement = this.$self_$35376.transform.forward;
														if (53151 - 51702 != 1450)
														{
															this.$self_$35376.mChar.moveSpeed = (float)8;
															if (171248 - 241344 != -70095)
															{
																this.$mSpine1$35361 = global::Math.findChildObject(this.$self_$35376.gameObject.transform, "Spine1");
																if (67134 - 386088 != -318953)
																{
																	this.$mSpine2$35362 = global::Math.findChildObject(this.$self_$35376.gameObject.transform, "Spine2");
																	if (1992 - 276490 != -274497)
																	{
																		this.$mSpine1_rot$35363 = default(Vector3);
																		if (84216 - 520594 != -436377)
																		{
																			this.$mSpine2_rot$35364 = default(Vector3);
																			if (47106 - 312662 != -265555)
																			{
																				this.$mActionTimer$35365 = Time.time;
																				if (112983 - 511380 == -398397)
																				{
																					goto IL_279;
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_1160;
				IL_151:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_11:
				goto IL_1160;
				IL_26D:
				return this.YieldDefault(2);
				IL_611:
				return this.YieldDefault(5);
				Block_46:
				goto IL_26D;
				IL_D4B:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_85:
				IL_1160:
				return false;
			}

			// Token: 0x060059A2 RID: 22946 RVA: 0x00AC59C4 File Offset: 0x00AC3BC4
			internal static bool xOdePjpVklxRCJQ5YvXe()
			{
				return true;
			}

			// Token: 0x060059A3 RID: 22947 RVA: 0x00AC59C8 File Offset: 0x00AC3BC8
			internal static bool PeipbGpVGV7y82Xq1DxI()
			{
				return false;
			}

			// Token: 0x040062C6 RID: 25286
			internal GameObject $tObject$35359;

			// Token: 0x040062C7 RID: 25287
			internal Vector3 $tPos$35360;

			// Token: 0x040062C8 RID: 25288
			internal Transform $mSpine1$35361;

			// Token: 0x040062C9 RID: 25289
			internal Transform $mSpine2$35362;

			// Token: 0x040062CA RID: 25290
			internal Vector3 $mSpine1_rot$35363;

			// Token: 0x040062CB RID: 25291
			internal Vector3 $mSpine2_rot$35364;

			// Token: 0x040062CC RID: 25292
			internal float $mActionTimer$35365;

			// Token: 0x040062CD RID: 25293
			internal int $targetDeg$35366;

			// Token: 0x040062CE RID: 25294
			internal Vector3 $firePos$35367;

			// Token: 0x040062CF RID: 25295
			internal Vector3 $fireDir$35368;

			// Token: 0x040062D0 RID: 25296
			internal Quaternion $fireRot$35369;

			// Token: 0x040062D1 RID: 25297
			internal int $hitLayer$35370;

			// Token: 0x040062D2 RID: 25298
			internal RaycastHit $hit$35371;

			// Token: 0x040062D3 RID: 25299
			internal int $mRange$35372;

			// Token: 0x040062D4 RID: 25300
			internal Vector3 $mPos$35373;

			// Token: 0x040062D5 RID: 25301
			internal Vector3 $tDir$35374;

			// Token: 0x040062D6 RID: 25302
			internal int $tID$35375;

			// Token: 0x040062D7 RID: 25303
			internal PvpMount $self_$35376;
		}
	}

	// Token: 0x02000F69 RID: 3945
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_mole$35381 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060059A4 RID: 22948 RVA: 0x00AC59CC File Offset: 0x00AC3BCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_mole$35381(Vector3 mPos, Vector3 tDir, int tID, PvpMount self_)
		{
			if (39548 - 287510 != -247962)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (58919 - 560264 != -501344)
				{
					base..ctor();
					if (219858 - 417147 == -197289)
					{
						this.$mPos$35392 = mPos;
						if (277880 - 413561 != -135680)
						{
							this.$tDir$35393 = tDir;
							if (74140 - 104197 == -30057)
							{
								this.$tID$35394 = tID;
								if (22678 - 33815 != -11136)
								{
									this.$self_$35395 = self_;
									if (117530 - 393326 == -275796)
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

		// Token: 0x060059A5 RID: 22949 RVA: 0x00AC5ACC File Offset: 0x00AC3CCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PvpMount.$RPC_nAttack_mole$35381.$(this.$mPos$35392, this.$tDir$35393, this.$tID$35394, this.$self_$35395);
		}

		// Token: 0x060059A6 RID: 22950 RVA: 0x00AC5AEC File Offset: 0x00AC3CEC
		internal static bool Q6HUJIpVHuDYgfSKq2ug()
		{
			return true;
		}

		// Token: 0x060059A7 RID: 22951 RVA: 0x00AC5AF0 File Offset: 0x00AC3CF0
		internal static bool dtMT5GpVWC3y49VOfuSb()
		{
			return false;
		}

		// Token: 0x040062D8 RID: 25304
		internal Vector3 $mPos$35392;

		// Token: 0x040062D9 RID: 25305
		internal Vector3 $tDir$35393;

		// Token: 0x040062DA RID: 25306
		internal int $tID$35394;

		// Token: 0x040062DB RID: 25307
		internal PvpMount $self_$35395;

		// Token: 0x02000F6A RID: 3946
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060059A8 RID: 22952 RVA: 0x00AC5AF4 File Offset: 0x00AC3CF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, PvpMount self_)
			{
				if (97083 - 448238 != -351154)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (144786 - 549830 != -405043)
					{
						base..ctor();
						if (172179 - 301585 == -129406)
						{
							this.$mPos$35388 = mPos;
							if (187971 - 215187 == -27216)
							{
								this.$tDir$35389 = tDir;
								if (85672 - 521851 == -436179)
								{
									this.$tID$35390 = tID;
									if (194607 - 125807 != 68801)
									{
										this.$self_$35391 = self_;
										if (168683 - 405437 == -236754)
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

			// Token: 0x060059A9 RID: 22953 RVA: 0x00AC5BF4 File Offset: 0x00AC3DF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (19318 - 540149 != -520831)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7E6;
					case 2:
						if (this.$self_$35391.mChar.actionState != "attack")
						{
							if (277241 - 276165 != 1076)
							{
								continue;
							}
							goto IL_16C;
						}
						else
						{
							if (!this.$self_$35391.mChar.isMine)
							{
								goto IL_5AD;
							}
							if (41517 - 257327 == -215809)
							{
								continue;
							}
							if (Game.mGameType <= 4)
							{
								goto IL_5AD;
							}
							if (133352 - 145401 != -12049)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$35390];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$35382 = (GameObject)obj2;
							if (265085 - 473186 == -208100)
							{
								continue;
							}
							this.$tPos$35383 = this.$mPos$35388 + this.$tDir$35389;
							if (275084 - 411543 != -136459)
							{
								continue;
							}
							if (this.$tObject$35382)
							{
								if (27287 - 49202 == -21914)
								{
									continue;
								}
								this.$tPos$35383 = this.$tObject$35382.collider.bounds.center;
								if (26796 - 168837 == -142040)
								{
									continue;
								}
							}
							this.$fireOffset$35384 = this.$self_$35391.transform.TransformDirection(new Vector3(0.2f, 2.7f, 0.32f));
							if (83295 - 448039 != -364744)
							{
								continue;
							}
							this.$firePoint$35385 = global::Math.findChildObject(this.$self_$35391.mChar.mWep1.transform, "firePoint");
							if (92246 - 399591 != -307345)
							{
								continue;
							}
							if (this.$firePoint$35385)
							{
								if (108292 - 397428 == -289135)
								{
									continue;
								}
								this.$fireOffset$35384 = this.$firePoint$35385.transform.position - this.$self_$35391.transform.position;
								if (206966 - 400324 != -193358)
								{
									continue;
								}
							}
							this.$firePos$35386 = this.$self_$35391.transform.position + this.$fireOffset$35384;
							if (189014 - 570387 != -381373)
							{
								continue;
							}
							this.$fireDir$35387 = this.$tPos$35383 - this.$self_$35391.transform.position - this.$fireOffset$35384;
							if (103563 - 411787 == -308223)
							{
								continue;
							}
							this.$self_$35391.RPC_nAttack_mole_fire(this.$firePos$35386, this.$fireDir$35387, 0);
							if (256481 - 298841 != -42360)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_5AD;
							}
							if (60408 - 3089 == 57320)
							{
								continue;
							}
							this.$self_$35391.ActionEvent("RPC_nAttack_mole_fire", this.$firePos$35386, this.$fireDir$35387, 0);
							if (227836 - 344637 != -116800)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$35391.mChar.actionState != "attack")
						{
							if (94531 - 484338 != -389806)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							if (this.$self_$35391.mChar.actionState == "attack")
							{
								if (236939 - 481830 == -244890)
								{
									continue;
								}
								if (this.$self_$35391.mChar.myCommand == "nAttack")
								{
									if (28334 - 196260 == -167925)
									{
										continue;
									}
									this.$self_$35391.mChar.actionState = "standby";
									if (287747 - 300855 == -13107)
									{
										continue;
									}
									this.$self_$35391.mChar.actionTime = Time.time;
									if (227080 - 260989 == -33908)
									{
										continue;
									}
									this.$self_$35391.mChar.myCommand = "none";
									if (185465 - 257490 == -72024)
									{
										continue;
									}
									if (!this.$self_$35391.mChar.isMine)
									{
										if (91643 - 482468 != -390825)
										{
											continue;
										}
										this.$self_$35391.mChar.nPosition = this.$self_$35391.transform.position;
										if (107997 - 332336 == -224338)
										{
											continue;
										}
										this.$self_$35391.mChar.oPosition = this.$self_$35391.transform.position;
										if (21679 - 30170 != -8491)
										{
											continue;
										}
										this.$self_$35391.mChar.nDirection = this.$self_$35391.transform.forward;
										if (225583 - 495828 != -270245)
										{
											continue;
										}
									}
								}
							}
							this.YieldDefault(1);
							if (283754 - 472084 != -188329)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					default:
						if (267330 - 47450 == 219881)
						{
							continue;
						}
						break;
					}
					this.$self_$35391.mChar.actionState = "attack";
					if (193518 - 431967 != -238448)
					{
						this.$self_$35391.mChar.actionTime = Time.time;
						if (97502 - 526091 != -428588)
						{
							this.$self_$35391.mChar.myCommand = "nAttack";
							if (255945 - 47944 != 208002)
							{
								this.$self_$35391.mChar.addTimeOut("nAttack", 1f);
								if (144727 - 526420 != -381692)
								{
									this.$self_$35391.transform.position = this.$mPos$35388;
									if (40655 - 209885 != -169229)
									{
										this.$self_$35391.animation.CrossFade("nAttack", 0.2f);
										if (235005 - 225415 != 9591)
										{
											this.$self_$35391.animation.wrapMode = WrapMode.Once;
											if (151912 - 12424 != 139489)
											{
												this.$self_$35391.mChar.vMovement = this.$self_$35391.transform.forward;
												if (174217 - 59095 != 115123)
												{
													this.$self_$35391.mChar.moveSpeed = (float)0;
													if (207738 - 278171 != -70432)
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
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_16C:
				Block_19:
				goto IL_7E6;
				Block_26:
				IL_5AD:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_38:
				IL_7E6:
				return false;
			}

			// Token: 0x060059AA RID: 22954 RVA: 0x00AC63FC File Offset: 0x00AC45FC
			internal static bool XfVGCYpVA1Roeba5tbGW()
			{
				return true;
			}

			// Token: 0x060059AB RID: 22955 RVA: 0x00AC6400 File Offset: 0x00AC4600
			internal static bool JTMPN9pVlco4brQZB10R()
			{
				return false;
			}

			// Token: 0x040062DC RID: 25308
			internal GameObject $tObject$35382;

			// Token: 0x040062DD RID: 25309
			internal Vector3 $tPos$35383;

			// Token: 0x040062DE RID: 25310
			internal Vector3 $fireOffset$35384;

			// Token: 0x040062DF RID: 25311
			internal Transform $firePoint$35385;

			// Token: 0x040062E0 RID: 25312
			internal Vector3 $firePos$35386;

			// Token: 0x040062E1 RID: 25313
			internal Vector3 $fireDir$35387;

			// Token: 0x040062E2 RID: 25314
			internal Vector3 $mPos$35388;

			// Token: 0x040062E3 RID: 25315
			internal Vector3 $tDir$35389;

			// Token: 0x040062E4 RID: 25316
			internal int $tID$35390;

			// Token: 0x040062E5 RID: 25317
			internal PvpMount $self_$35391;
		}
	}

	// Token: 0x02000F6B RID: 3947
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_mole$35396 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060059AC RID: 22956 RVA: 0x00AC6404 File Offset: 0x00AC4604
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_mole$35396(Vector3 mPos, PvpMount self_)
		{
			if (9641 - 510360 != -500719)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (259574 - 12753 == 246821)
				{
					base..ctor();
					if (6136 - 524948 == -518812)
					{
						this.$mPos$35399 = mPos;
						if (106279 - 439565 != -333285)
						{
							this.$self_$35400 = self_;
							if (138633 - 385957 == -247324)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060059AD RID: 22957 RVA: 0x00AC64C0 File Offset: 0x00AC46C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PvpMount.$RPC_rAttack_mole$35396.$(this.$mPos$35399, this.$self_$35400);
		}

		// Token: 0x060059AE RID: 22958 RVA: 0x00AC64D4 File Offset: 0x00AC46D4
		internal static bool EYXJxNpVyZolfWIJW1Ow()
		{
			return true;
		}

		// Token: 0x060059AF RID: 22959 RVA: 0x00AC64D8 File Offset: 0x00AC46D8
		internal static bool e79g70pVS7gNLo72gwSM()
		{
			return false;
		}

		// Token: 0x040062E6 RID: 25318
		internal Vector3 $mPos$35399;

		// Token: 0x040062E7 RID: 25319
		internal PvpMount $self_$35400;

		// Token: 0x02000F6C RID: 3948
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060059B0 RID: 22960 RVA: 0x00AC64DC File Offset: 0x00AC46DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, PvpMount self_)
			{
				if (65889 - 403101 != -337211)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (242677 - 135387 == 107290)
					{
						base..ctor();
						if (293594 - 358989 != -65394)
						{
							this.$mPos$35397 = mPos;
							if (56149 - 338483 == -282334)
							{
								this.$self_$35398 = self_;
								if (183412 - 533655 != -350242)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060059B1 RID: 22961 RVA: 0x00AC6598 File Offset: 0x00AC4798
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (291197 - 595381 != -304184)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_523;
					case 2:
						if (this.$self_$35398.mChar.actionState != "attack")
						{
							if (118106 - 518668 != -400562)
							{
								continue;
							}
							goto IL_316;
						}
						else
						{
							if (!this.$self_$35398.mChar.isMine)
							{
								goto IL_1A;
							}
							if (140255 - 205826 == -65570)
							{
								continue;
							}
							if (Game.mGameType <= 4)
							{
								goto IL_1A;
							}
							if (201523 - 386116 != -184593)
							{
								continue;
							}
							this.$self_$35398.StartCoroutine_Auto(this.$self_$35398.RPC_rAttack_mole_fire(this.$self_$35398.transform.position, this.$self_$35398.transform.forward, 0));
							if (154482 - 348196 == -193713)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_1A;
							}
							if (194774 - 443146 != -248372)
							{
								continue;
							}
							this.$self_$35398.ActionEvent("RPC_rAttack_mole_fire", this.$self_$35398.transform.position, this.$self_$35398.transform.forward, 0);
							if (75105 - 183428 != -108323)
							{
								continue;
							}
							goto IL_1A;
						}
						break;
					case 3:
						if (this.$self_$35398.mChar.actionState == "attack")
						{
							if (28552 - 527133 == -498580)
							{
								continue;
							}
							if (this.$self_$35398.mChar.myCommand == "rAttack")
							{
								if (8824 - 576049 != -567225)
								{
									continue;
								}
								this.$self_$35398.mChar.actionState = "standby";
								if (140392 - 180086 == -39693)
								{
									continue;
								}
								this.$self_$35398.mChar.actionTime = Time.time;
								if (290110 - 552801 != -262691)
								{
									continue;
								}
								this.$self_$35398.mChar.myCommand = "none";
								if (281792 - 286868 == -5075)
								{
									continue;
								}
								if (!this.$self_$35398.mChar.isMine)
								{
									if (25398 - 189997 == -164598)
									{
										continue;
									}
									this.$self_$35398.mChar.nPosition = this.$self_$35398.transform.position;
									if (79981 - 120331 == -40349)
									{
										continue;
									}
									this.$self_$35398.mChar.oPosition = this.$self_$35398.transform.position;
									if (182051 - 523144 != -341093)
									{
										continue;
									}
									this.$self_$35398.mChar.nDirection = this.$self_$35398.transform.forward;
									if (187106 - 471242 == -284135)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (214844 - 284257 != -69413)
						{
							continue;
						}
						goto IL_523;
					default:
						if (132312 - 228576 == -96263)
						{
							continue;
						}
						break;
					}
					this.$self_$35398.mChar.actionState = "attack";
					if (112469 - 258342 == -145873)
					{
						this.$self_$35398.mChar.actionTime = Time.time;
						if (7964 - 343738 != -335773)
						{
							this.$self_$35398.mChar.myCommand = "rAttack";
							if (206690 - 545786 != -339095)
							{
								this.$self_$35398.mChar.addTimeOut("nAttack", 0.5f);
								if (175780 - 85262 != 90519)
								{
									this.$self_$35398.transform.position = this.$mPos$35397;
									if (227822 - 397668 != -169845)
									{
										this.$self_$35398.mChar.vMovement = this.$self_$35398.transform.forward;
										if (272517 - 260023 == 12494)
										{
											this.$self_$35398.mChar.moveSpeed = (float)8;
											if (209332 - 132989 == 76343)
											{
												goto IL_10C;
											}
										}
									}
								}
							}
						}
					}
				}
				IL_1A:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_10C:
				return this.Yield(2, new WaitForSeconds(0.1f));
				IL_316:
				IL_523:
				return false;
			}

			// Token: 0x060059B2 RID: 22962 RVA: 0x00AC6ADC File Offset: 0x00AC4CDC
			internal static bool jvIxCBpVoJESWav2KoQ9()
			{
				return true;
			}

			// Token: 0x060059B3 RID: 22963 RVA: 0x00AC6AE0 File Offset: 0x00AC4CE0
			internal static bool zDojIppVEdYuPoqgmXmA()
			{
				return false;
			}

			// Token: 0x040062E8 RID: 25320
			internal Vector3 $mPos$35397;

			// Token: 0x040062E9 RID: 25321
			internal PvpMount $self_$35398;
		}
	}

	// Token: 0x02000F6D RID: 3949
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_mole_fire$35401 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060059B4 RID: 22964 RVA: 0x00AC6AE4 File Offset: 0x00AC4CE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_mole_fire$35401(Vector3 hitPos, PvpMount self_)
		{
			if (7453 - 15428 != -7975)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (219211 - 224467 != -5255)
				{
					base..ctor();
					if (98304 - 345411 == -247107)
					{
						this.$hitPos$35408 = hitPos;
						if (22642 - 206181 == -183539)
						{
							this.$self_$35409 = self_;
							if (3691 - 308307 == -304616)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060059B5 RID: 22965 RVA: 0x00AC6BA0 File Offset: 0x00AC4DA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PvpMount.$RPC_rAttack_mole_fire$35401.$(this.$hitPos$35408, this.$self_$35409);
		}

		// Token: 0x060059B6 RID: 22966 RVA: 0x00AC6BB4 File Offset: 0x00AC4DB4
		internal static bool MAXO4UpV2iqFJ6mj3ktY()
		{
			return true;
		}

		// Token: 0x060059B7 RID: 22967 RVA: 0x00AC6BB8 File Offset: 0x00AC4DB8
		internal static bool hOlYO2pV8WZ3gQ3qiw98()
		{
			return false;
		}

		// Token: 0x040062EA RID: 25322
		internal Vector3 $hitPos$35408;

		// Token: 0x040062EB RID: 25323
		internal PvpMount $self_$35409;

		// Token: 0x02000F6E RID: 3950
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060059B8 RID: 22968 RVA: 0x00AC6BBC File Offset: 0x00AC4DBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 hitPos, PvpMount self_)
			{
				if (238264 - 273764 != -35499)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (167163 - 471647 == -304484)
					{
						base..ctor();
						if (127771 - 472785 == -345014)
						{
							this.$hitPos$35406 = hitPos;
							if (284190 - 523682 == -239492)
							{
								this.$self_$35407 = self_;
								if (146988 - 365686 == -218698)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060059B9 RID: 22969 RVA: 0x00AC6C78 File Offset: 0x00AC4E78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (178032 - 236821 != -58789)
				{
				}
				for (;;)
				{
					IL_FE:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_463;
					case 2:
						if (!this.$self_$35407.McLcX4f8dXQ)
						{
							if (174481 - 543770 == -369288)
							{
								continue;
							}
							this.$self_$35407.McLcX4f8dXQ = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/mole_rAttack_hit");
							if (111861 - 498435 == -386573)
							{
								continue;
							}
						}
						if (this.$self_$35407.McLcX4f8dXQ)
						{
							if (169018 - 253096 == -84077)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$35407.McLcX4f8dXQ, this.$hitPos$35406, Quaternion.identity);
							if (121162 - 82922 != 38240)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Cannot find mole_rAttack_hit effect");
							if (198161 - 556605 != -358444)
							{
								continue;
							}
						}
						if (this.$self_$35407.mChar.isMine)
						{
							if (187823 - 450350 != -262527)
							{
								continue;
							}
							this.$hitLayer$35402 = 130816 - (1 << this.$self_$35407.gameObject.layer);
							if (138731 - 529960 != -391229)
							{
								continue;
							}
							this.$hitList$35403 = Damage.FindAreaTarget(this.$hitPos$35406 - 0.5f * Vector3.up, (float)4, (float)3, this.$hitLayer$35402);
							if (231794 - 378828 == -147033)
							{
								continue;
							}
							this.$$iterator$10568$35405 = UnityRuntimeServices.GetEnumerator(this.$hitList$35403);
							if (125334 - 482323 != -356989)
							{
								continue;
							}
							while (this.$$iterator$10568$35405.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10568$35405.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$35404 = (GameObject)obj2;
								if (86213 - 442311 == -356097)
								{
									goto IL_FE;
								}
								this.$self_$35407.mChar.hit(1, this.$hitObject$35404, (int)(1.5f * (float)this.$self_$35407.mChar.atk), 1, 0, global::Math.vFlat(this.$hitObject$35404.transform.position - this.$hitPos$35406).normalized);
								if (295690 - 132560 == 163131)
								{
									goto IL_FE;
								}
								UnityRuntimeServices.Update(this.$$iterator$10568$35405, this.$hitObject$35404);
								if (69966 - 194160 == -124193)
								{
									goto IL_FE;
								}
							}
							if (38241 - 432056 == -393814)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (225640 - 563176 != -337535)
						{
							goto Block_11;
						}
						continue;
					default:
						if (27002 - 520446 != -493444)
						{
							continue;
						}
						break;
					}
					if (!this.$self_$35407.N53cXahB684)
					{
						if (188231 - 525729 != -337498)
						{
							continue;
						}
						this.$self_$35407.N53cXahB684 = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/mole_rAttack_fire");
						if (125945 - 122474 == 3472)
						{
							continue;
						}
					}
					if (this.$self_$35407.N53cXahB684)
					{
						if (241964 - 257290 == -15326)
						{
							UnityEngine.Object.Instantiate(this.$self_$35407.N53cXahB684, this.$hitPos$35406, Quaternion.Euler((float)270, (float)90, (float)0));
							if (4471 - 8802 != -4330)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Cannot find mole_rAttack_fire effect");
						if (283088 - 277633 != 5456)
						{
							break;
						}
					}
				}
				IL_12F:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_11:
				goto IL_463;
				goto IL_12F;
				IL_463:
				return false;
			}

			// Token: 0x060059BA RID: 22970 RVA: 0x00AC70FC File Offset: 0x00AC52FC
			internal static bool RJ23capVZIfDgIWNnxwd()
			{
				return true;
			}

			// Token: 0x060059BB RID: 22971 RVA: 0x00AC7100 File Offset: 0x00AC5300
			internal static bool OMRfg4pVCwfsvNfLaVsv()
			{
				return false;
			}

			// Token: 0x040062EC RID: 25324
			internal int $hitLayer$35402;

			// Token: 0x040062ED RID: 25325
			internal UnityScript.Lang.Array $hitList$35403;

			// Token: 0x040062EE RID: 25326
			internal GameObject $hitObject$35404;

			// Token: 0x040062EF RID: 25327
			internal IEnumerator $$iterator$10568$35405;

			// Token: 0x040062F0 RID: 25328
			internal Vector3 $hitPos$35406;

			// Token: 0x040062F1 RID: 25329
			internal PvpMount $self_$35407;
		}
	}

	// Token: 0x02000F6F RID: 3951
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_monkey$35410 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060059BC RID: 22972 RVA: 0x00AC7104 File Offset: 0x00AC5304
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_monkey$35410(Vector3 mPos, PvpMount self_)
		{
			if (275413 - 347143 != -71729)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (234685 - 9510 != 225176)
				{
					base..ctor();
					if (217593 - 260734 != -43140)
					{
						this.$mPos$35419 = mPos;
						if (270488 - 114504 != 155985)
						{
							this.$self_$35420 = self_;
							if (178328 - 580747 == -402419)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060059BD RID: 22973 RVA: 0x00AC71C0 File Offset: 0x00AC53C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PvpMount.$RPC_nAttack_monkey$35410.$(this.$mPos$35419, this.$self_$35420);
		}

		// Token: 0x060059BE RID: 22974 RVA: 0x00AC71D4 File Offset: 0x00AC53D4
		internal static bool KtSMTGpVLAfYW52ypFIP()
		{
			return true;
		}

		// Token: 0x060059BF RID: 22975 RVA: 0x00AC71D8 File Offset: 0x00AC53D8
		internal static bool L2qnLepVOt9Jwd7sof0b()
		{
			return false;
		}

		// Token: 0x040062F2 RID: 25330
		internal Vector3 $mPos$35419;

		// Token: 0x040062F3 RID: 25331
		internal PvpMount $self_$35420;

		// Token: 0x02000F70 RID: 3952
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060059C0 RID: 22976 RVA: 0x00AC71DC File Offset: 0x00AC53DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, PvpMount self_)
			{
				if (16132 - 356923 != -340791)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (182684 - 428620 == -245936)
					{
						base..ctor();
						if (198563 - 106712 != 91852)
						{
							this.$mPos$35417 = mPos;
							if (20341 - 148808 == -128467)
							{
								this.$self_$35418 = self_;
								if (167242 - 158368 != 8875)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060059C1 RID: 22977 RVA: 0x00AC7298 File Offset: 0x00AC5498
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (40344 - 370911 != -330566)
				{
				}
				for (;;)
				{
					IL_90:
					switch (this._state)
					{
					case 0:
						goto IL_82F;
					case 1:
						goto IL_AD7;
					case 2:
						if (this.$self_$35418.mChar.actionState != "attack")
						{
							if (269637 - 303193 != -33555)
							{
								goto Block_48;
							}
							continue;
						}
						else
						{
							if (!this.$self_$35418.nTscXsackeF)
							{
								if (3367 - 217312 == -213944)
								{
									continue;
								}
								this.$self_$35418.nTscXsackeF = (AudioClip)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Sounds/monkey_nAttack", typeof(AudioClip));
								if (259473 - 79918 == 179556)
								{
									continue;
								}
							}
							if (this.$self_$35418.nTscXsackeF)
							{
								if (220480 - 129348 != 91132)
								{
									continue;
								}
								this.$self_$35418.audio.PlayOneShot(this.$self_$35418.nTscXsackeF, 1f);
								if (100029 - 478246 != -378217)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing monkey_nAttackFx sounds");
								if (62108 - 444855 == -382746)
								{
									continue;
								}
							}
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_538;
							}
							if (280794 - 85592 == 195203)
							{
								continue;
							}
							if (Game.mGameType <= 4)
							{
								goto IL_538;
							}
							if (213306 - 439054 != -225748)
							{
								continue;
							}
							if (Game.mTeam != this.$self_$35418.mChar.mOriginalLayer - 7)
							{
								goto IL_538;
							}
							if (266990 - 297820 != -30830)
							{
								continue;
							}
							if (!this.$self_$35418.yOZcXHIOh0G)
							{
								if (162556 - 486951 == -324394)
								{
									continue;
								}
								this.$self_$35418.yOZcXHIOh0G = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Monkey/Voices/nAttack1", typeof(AudioClip));
								if (223441 - 329164 == -105722)
								{
									continue;
								}
							}
							if (this.$self_$35418.yOZcXHIOh0G)
							{
								if (154907 - 243745 != -88837)
								{
									goto Block_67;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find monkey_nAttack voice");
								if (187798 - 214064 != -26265)
								{
									goto Block_21;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$35418.mChar.actionState != "attack")
						{
							if (53635 - 312833 != -259198)
							{
								continue;
							}
							goto IL_809;
						}
						else
						{
							this.$i$35411 = 0;
							if (91683 - 163445 == -71761)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$35418.mChar.actionState != "attack")
						{
							if (252341 - 295169 != -42827)
							{
								goto Block_44;
							}
							continue;
						}
						else
						{
							if (this.$self_$35418.mChar.isMine)
							{
								if (29985 - 245668 != -215683)
								{
									continue;
								}
								this.$hitLayer$35412 = 130816 - (1 << this.$self_$35418.gameObject.layer);
								if (96238 - 585495 != -489257)
								{
									continue;
								}
								this.$hitList$35413 = Damage.FindRecTarget(this.$self_$35418.transform.position, this.$self_$35418.transform.forward, (float)1, (float)1, (float)3, (float)3, this.$hitLayer$35412);
								if (279651 - 152164 == 127488)
								{
									continue;
								}
								this.$$iterator$10561$35416 = UnityRuntimeServices.GetEnumerator(this.$hitList$35413);
								if (88361 - 417450 != -329089)
								{
									continue;
								}
								while (this.$$iterator$10561$35416.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10561$35416.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$35414 = (GameObject)obj2;
									if (218173 - 467861 != -249688)
									{
										goto IL_90;
									}
									if (this.$self_$35418.mChar.hit(1, this.$hitObject$35414, (int)(0.7f * (float)this.$self_$35418.mChar.atk), 1, 0, 0.3f * this.$self_$35418.transform.forward) != 0)
									{
										if (16236 - 488659 != -472423)
										{
											goto IL_90;
										}
										this.$hitPos$35415 = this.$hitObject$35414.collider.ClosestPointOnBounds(this.$self_$35418.transform.position + (float)2 * Vector3.up);
										if (73362 - 536594 != -463232)
										{
											goto IL_90;
										}
										UnityRuntimeServices.Update(this.$$iterator$10561$35416, this.$hitObject$35414);
										if (53601 - 457633 != -404032)
										{
											goto IL_90;
										}
										this.$self_$35418.RPC_nAttack_monkey_hit(this.$hitPos$35415, this.$self_$35418.transform.forward, 0);
										if (220890 - 287812 != -66922)
										{
											goto IL_90;
										}
										this.$self_$35418.ActionEvent("RPC_nAttack_monkey_hit", this.$hitPos$35415, this.$self_$35418.transform.forward, 0);
										if (124537 - 88100 != 36437)
										{
											goto IL_90;
										}
									}
								}
								if (10952 - 184484 == -173531)
								{
									continue;
								}
							}
							this.$i$35411++;
							if (26044 - 512550 != -486506)
							{
								continue;
							}
						}
						break;
					case 5:
						if (this.$self_$35418.mChar.actionState == "attack")
						{
							if (175222 - 226626 != -51404)
							{
								continue;
							}
							if (this.$self_$35418.mChar.myCommand == "nAttack")
							{
								if (72925 - 310410 == -237484)
								{
									continue;
								}
								this.$self_$35418.mChar.actionState = "standby";
								if (59847 - 515052 == -455204)
								{
									continue;
								}
								this.$self_$35418.mChar.actionTime = Time.time;
								if (145422 - 452698 != -307276)
								{
									continue;
								}
								this.$self_$35418.mChar.myCommand = "none";
								if (44991 - 537110 == -492118)
								{
									continue;
								}
								if (!this.$self_$35418.mChar.isMine)
								{
									if (284985 - 580519 == -295533)
									{
										continue;
									}
									this.$self_$35418.mChar.nPosition = this.$self_$35418.transform.position;
									if (65379 - 437766 == -372386)
									{
										continue;
									}
									this.$self_$35418.mChar.oPosition = this.$self_$35418.transform.position;
									if (186926 - 586578 != -399652)
									{
										continue;
									}
									this.$self_$35418.mChar.nDirection = this.$self_$35418.transform.forward;
									if (59169 - 438664 == -379494)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (266825 - 146273 != 120553)
						{
							goto Block_46;
						}
						continue;
					default:
						if (297809 - 427703 != -129893)
						{
							goto IL_82F;
						}
						continue;
					}
					if (this.$i$35411 < 2)
					{
						goto IL_6E0;
					}
					if (73212 - 532513 != -459300)
					{
						goto Block_26;
					}
					continue;
					IL_82F:
					this.$self_$35418.mChar.actionState = "attack";
					if (72425 - 472501 != -400075)
					{
						this.$self_$35418.mChar.actionTime = Time.time;
						if (154987 - 500989 == -346002)
						{
							this.$self_$35418.mChar.myCommand = "nAttack";
							if (289320 - 295812 == -6492)
							{
								this.$self_$35418.mChar.addTimeOut("nAttack", 1.5f);
								if (297399 - 46338 == 251061)
								{
									this.$self_$35418.transform.position = this.$mPos$35417;
									if (100258 - 353977 == -253719)
									{
										this.$self_$35418.animation.CrossFade("nAttack", 0.2f);
										if (196247 - 370220 == -173973)
										{
											this.$self_$35418.animation.wrapMode = WrapMode.Once;
											if (217240 - 397630 != -180389)
											{
												this.$self_$35418.mChar.vMovement = this.$self_$35418.transform.forward;
												if (25715 - 402319 == -376604)
												{
													this.$self_$35418.mChar.moveSpeed = (float)0;
													if (36250 - 314494 != -278243)
													{
														goto Block_62;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_21:
				goto IL_538;
				Block_26:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_538:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_6E0:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_44:
				Block_46:
				Block_48:
				IL_809:
				goto IL_AD7;
				Block_62:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_67:
				this.$self_$35418.audio.PlayOneShot(this.$self_$35418.yOZcXHIOh0G, (!this.$self_$35418.mChar.isMine) ? 0.75f : ((float)1));
				goto IL_538;
				IL_AD7:
				return false;
			}

			// Token: 0x060059C2 RID: 22978 RVA: 0x00AC7D90 File Offset: 0x00AC5F90
			internal static bool LASu1npVmAyfRKTQuZsN()
			{
				return true;
			}

			// Token: 0x060059C3 RID: 22979 RVA: 0x00AC7D94 File Offset: 0x00AC5F94
			internal static bool nK7pZApVF87dbtKMwMeZ()
			{
				return false;
			}

			// Token: 0x040062F4 RID: 25332
			internal int $i$35411;

			// Token: 0x040062F5 RID: 25333
			internal int $hitLayer$35412;

			// Token: 0x040062F6 RID: 25334
			internal UnityScript.Lang.Array $hitList$35413;

			// Token: 0x040062F7 RID: 25335
			internal GameObject $hitObject$35414;

			// Token: 0x040062F8 RID: 25336
			internal Vector3 $hitPos$35415;

			// Token: 0x040062F9 RID: 25337
			internal IEnumerator $$iterator$10561$35416;

			// Token: 0x040062FA RID: 25338
			internal Vector3 $mPos$35417;

			// Token: 0x040062FB RID: 25339
			internal PvpMount $self_$35418;
		}
	}

	// Token: 0x02000F71 RID: 3953
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_monkey$35421 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060059C4 RID: 22980 RVA: 0x00AC7D98 File Offset: 0x00AC5F98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_monkey$35421(Vector3 mPos, PvpMount self_)
		{
			if (2662 - 464526 != -461864)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (66452 - 53042 != 13411)
				{
					base..ctor();
					if (289546 - 247029 != 42518)
					{
						this.$mPos$35429 = mPos;
						if (43207 - 265354 != -222146)
						{
							this.$self_$35430 = self_;
							if (262065 - 31450 != 230616)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060059C5 RID: 22981 RVA: 0x00AC7E54 File Offset: 0x00AC6054
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PvpMount.$RPC_rAttack_monkey$35421.$(this.$mPos$35429, this.$self_$35430);
		}

		// Token: 0x060059C6 RID: 22982 RVA: 0x00AC7E68 File Offset: 0x00AC6068
		internal static bool y3Ohb6pVMryQg3bCwsjF()
		{
			return true;
		}

		// Token: 0x060059C7 RID: 22983 RVA: 0x00AC7E6C File Offset: 0x00AC606C
		internal static bool oqNHiLpVx2c4SJIswMDP()
		{
			return false;
		}

		// Token: 0x040062FC RID: 25340
		internal Vector3 $mPos$35429;

		// Token: 0x040062FD RID: 25341
		internal PvpMount $self_$35430;

		// Token: 0x02000F72 RID: 3954
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060059C8 RID: 22984 RVA: 0x00AC7E70 File Offset: 0x00AC6070
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, PvpMount self_)
			{
				if (136155 - 59818 != 76337)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (99783 - 216446 != -116662)
					{
						base..ctor();
						if (211018 - 488552 != -277533)
						{
							this.$mPos$35427 = mPos;
							if (235654 - 563478 != -327823)
							{
								this.$self_$35428 = self_;
								if (206749 - 461319 == -254570)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060059C9 RID: 22985 RVA: 0x00AC7F2C File Offset: 0x00AC612C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (23756 - 599475 != -575719)
				{
				}
				for (;;)
				{
					IL_6E3:
					switch (this._state)
					{
					case 0:
						goto IL_885;
					case 1:
						goto IL_97D;
					case 2:
						if (this.$self_$35428.mChar.actionState != "attack")
						{
							if (96436 - 516103 != -419667)
							{
								continue;
							}
							goto IL_1A8;
						}
						else
						{
							if (!this.$self_$35428.dbGcXZnlCB4)
							{
								if (273364 - 556310 != -282946)
								{
									continue;
								}
								this.$self_$35428.dbGcXZnlCB4 = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/monkey_rAttack", typeof(GameObject));
								if (147132 - 449195 != -302063)
								{
									continue;
								}
							}
							if (this.$self_$35428.dbGcXZnlCB4)
							{
								if (249746 - 464003 != -214257)
								{
									continue;
								}
								this.$self_$35428.mChar.createEffect(this.$self_$35428.dbGcXZnlCB4, this.$self_$35428.transform.position, this.$self_$35428.transform.rotation);
								if (243222 - 551984 == -308761)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find monkey_rAttack effect");
								if (21782 - 438920 != -417138)
								{
									continue;
								}
							}
							if (PlayerPrefs.GetInt("pvoice", 1) != 0)
							{
								if (131971 - 490357 == -358385)
								{
									continue;
								}
								if (Game.mGameType > 4)
								{
									if (135972 - 543885 == -407912)
									{
										continue;
									}
									if (Game.mTeam == this.$self_$35428.mChar.mOriginalLayer - 7)
									{
										if (292623 - 413096 != -120473)
										{
											continue;
										}
										if (!this.$self_$35428.V1xcXCwoSXV)
										{
											if (172936 - 472323 == -299386)
											{
												continue;
											}
											this.$self_$35428.V1xcXCwoSXV = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Monkey/Voices/cast", typeof(AudioClip));
											if (246439 - 494625 == -248185)
											{
												continue;
											}
										}
										if (this.$self_$35428.V1xcXCwoSXV)
										{
											if (20833 - 373654 == -352820)
											{
												continue;
											}
											this.$self_$35428.audio.PlayOneShot(this.$self_$35428.V1xcXCwoSXV, (!this.$self_$35428.mChar.isMine) ? 0.75f : ((float)1));
										}
										else
										{
											Debug.LogError("Cannot find monkey_rAttack voice");
											if (236581 - 526816 == -290234)
											{
												continue;
											}
										}
									}
								}
							}
							this.$i$35422 = 0;
							if (55485 - 579684 == -524198)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$35428.mChar.actionState != "attack")
						{
							if (146941 - 362809 != -215867)
							{
								goto Block_51;
							}
							continue;
						}
						else
						{
							if (this.$self_$35428.mChar.isMine)
							{
								if (25691 - 278327 != -252636)
								{
									continue;
								}
								this.$hitLayer$35423 = 130816 - (1 << this.$self_$35428.gameObject.layer);
								if (89688 - 140299 != -50611)
								{
									continue;
								}
								this.$hitList$35424 = Damage.FindAreaTarget(this.$self_$35428.transform.position, (float)6, (float)3, this.$hitLayer$35423);
								if (99691 - 221781 == -122089)
								{
									continue;
								}
								this.$$iterator$10569$35426 = UnityRuntimeServices.GetEnumerator(this.$hitList$35424);
								if (192005 - 285410 != -93405)
								{
									continue;
								}
								while (this.$$iterator$10569$35426.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10569$35426.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$35425 = (GameObject)obj2;
									if (191637 - 453706 == -262068)
									{
										goto IL_6E3;
									}
									this.$self_$35428.mChar.hit(1, this.$hitObject$35425, this.$self_$35428.mChar.talAdjust(30), 1, 0, Vector3.zero);
									if (51722 - 417169 != -365447)
									{
										goto IL_6E3;
									}
									UnityRuntimeServices.Update(this.$$iterator$10569$35426, this.$hitObject$35425);
									if (10172 - 142159 != -131987)
									{
										goto IL_6E3;
									}
								}
								if (274483 - 344886 == -70402)
								{
									continue;
								}
							}
							this.$i$35422++;
							if (154204 - 389810 != -235606)
							{
								continue;
							}
						}
						break;
					default:
						if (221158 - 312029 != -90871)
						{
							continue;
						}
						goto IL_885;
					}
					if (this.$i$35422 < 5)
					{
						goto IL_74D;
					}
					if (5736 - 122768 == -117031)
					{
						continue;
					}
					if (this.$self_$35428.mChar.actionState == "attack")
					{
						if (248192 - 598711 == -350518)
						{
							continue;
						}
						if (this.$self_$35428.mChar.myCommand == "rAttack")
						{
							if (27316 - 355525 != -328209)
							{
								continue;
							}
							this.$self_$35428.mChar.actionState = "standby";
							if (250682 - 433968 != -183286)
							{
								continue;
							}
							this.$self_$35428.mChar.actionTime = Time.time;
							if (213844 - 116520 != 97324)
							{
								continue;
							}
							this.$self_$35428.mChar.myCommand = "none";
							if (241659 - 412008 != -170349)
							{
								continue;
							}
							if (!this.$self_$35428.mChar.isMine)
							{
								if (164217 - 587496 == -423278)
								{
									continue;
								}
								this.$self_$35428.mChar.nPosition = this.$self_$35428.transform.position;
								if (275936 - 246973 == 28964)
								{
									continue;
								}
								this.$self_$35428.mChar.oPosition = this.$self_$35428.transform.position;
								if (14331 - 218563 != -204232)
								{
									continue;
								}
								this.$self_$35428.mChar.nDirection = this.$self_$35428.transform.forward;
								if (129212 - 427408 == -298195)
								{
									continue;
								}
							}
						}
					}
					this.YieldDefault(1);
					if (288498 - 334365 != -45867)
					{
						continue;
					}
					break;
					IL_885:
					this.$self_$35428.mChar.actionState = "attack";
					if (5916 - 299424 != -293507)
					{
						this.$self_$35428.mChar.actionTime = Time.time;
						if (72446 - 216124 == -143678)
						{
							this.$self_$35428.mChar.myCommand = "rAttack";
							if (112200 - 570659 != -458458)
							{
								this.$self_$35428.mChar.addTimeOut("nAttack", (float)5);
								if (264101 - 176362 != 87740)
								{
									this.$self_$35428.transform.position = this.$mPos$35427;
									if (120406 - 246735 != -126328)
									{
										this.$self_$35428.animation.CrossFade("rAttack", 0.2f);
										if (45278 - 434526 == -389248)
										{
											this.$self_$35428.animation.wrapMode = WrapMode.Once;
											if (232856 - 589445 == -356589)
											{
												this.$self_$35428.mChar.vMovement = this.$self_$35428.transform.forward;
												if (218277 - 522055 != -303777)
												{
													this.$self_$35428.mChar.moveSpeed = (float)8;
													if (14723 - 405398 == -390675)
													{
														goto IL_37B;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_1A8:
				goto IL_97D;
				IL_37B:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_74D:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_51:
				IL_97D:
				return false;
			}

			// Token: 0x060059CA RID: 22986 RVA: 0x00AC88C8 File Offset: 0x00AC6AC8
			internal static bool X3yFwcpVgxMdwXZQjYki()
			{
				return true;
			}

			// Token: 0x060059CB RID: 22987 RVA: 0x00AC88CC File Offset: 0x00AC6ACC
			internal static bool jTHn6lpVfCsqsOmfFMtE()
			{
				return false;
			}

			// Token: 0x040062FE RID: 25342
			internal int $i$35422;

			// Token: 0x040062FF RID: 25343
			internal int $hitLayer$35423;

			// Token: 0x04006300 RID: 25344
			internal UnityScript.Lang.Array $hitList$35424;

			// Token: 0x04006301 RID: 25345
			internal GameObject $hitObject$35425;

			// Token: 0x04006302 RID: 25346
			internal IEnumerator $$iterator$10569$35426;

			// Token: 0x04006303 RID: 25347
			internal Vector3 $mPos$35427;

			// Token: 0x04006304 RID: 25348
			internal PvpMount $self_$35428;
		}
	}

	// Token: 0x02000F73 RID: 3955
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_sheep$35431 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060059CC RID: 22988 RVA: 0x00AC88D0 File Offset: 0x00AC6AD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_sheep$35431(Vector3 mPos, Vector3 tDir, int tID, PvpMount self_)
		{
			if (128700 - 135547 != -6847)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (248995 - 77536 != 171460)
				{
					base..ctor();
					if (79942 - 223117 == -143175)
					{
						this.$mPos$35439 = mPos;
						if (266986 - 65450 == 201536)
						{
							this.$tDir$35440 = tDir;
							if (197947 - 550129 == -352182)
							{
								this.$tID$35441 = tID;
								if (162823 - 263148 == -100325)
								{
									this.$self_$35442 = self_;
									if (3102 - 7834 != -4731)
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

		// Token: 0x060059CD RID: 22989 RVA: 0x00AC89D0 File Offset: 0x00AC6BD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PvpMount.$RPC_nAttack_sheep$35431.$(this.$mPos$35439, this.$tDir$35440, this.$tID$35441, this.$self_$35442);
		}

		// Token: 0x060059CE RID: 22990 RVA: 0x00AC89F0 File Offset: 0x00AC6BF0
		internal static bool GsmvqKpVnPqMbkETXqtF()
		{
			return true;
		}

		// Token: 0x060059CF RID: 22991 RVA: 0x00AC89F4 File Offset: 0x00AC6BF4
		internal static bool BFBqN8pV6JwZWtlFO8Rp()
		{
			return false;
		}

		// Token: 0x04006305 RID: 25349
		internal Vector3 $mPos$35439;

		// Token: 0x04006306 RID: 25350
		internal Vector3 $tDir$35440;

		// Token: 0x04006307 RID: 25351
		internal int $tID$35441;

		// Token: 0x04006308 RID: 25352
		internal PvpMount $self_$35442;

		// Token: 0x02000F74 RID: 3956
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060059D0 RID: 22992 RVA: 0x00AC89F8 File Offset: 0x00AC6BF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, PvpMount self_)
			{
				if (62930 - 450817 != -387887)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (149708 - 488113 != -338404)
					{
						base..ctor();
						if (136915 - 22027 == 114888)
						{
							this.$mPos$35435 = mPos;
							if (95767 - 319871 == -224104)
							{
								this.$tDir$35436 = tDir;
								if (61481 - 382117 == -320636)
								{
									this.$tID$35437 = tID;
									if (30101 - 362756 == -332655)
									{
										this.$self_$35438 = self_;
										if (37212 - 281339 != -244126)
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

			// Token: 0x060059D1 RID: 22993 RVA: 0x00AC8AF8 File Offset: 0x00AC6CF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (172199 - 470264 != -298064)
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
						if (this.$self_$35438.mChar.actionState != "attack")
						{
							if (120690 - 592915 != -472225)
							{
								continue;
							}
							goto IL_CE;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) != 0)
							{
								if (70430 - 416851 != -346421)
								{
									continue;
								}
								if (!this.$self_$35438.mChar.isMine)
								{
									if (102136 - 388501 != -286365)
									{
										continue;
									}
									if (Game.mGameType <= 4)
									{
										goto IL_224;
									}
									if (255910 - 479972 != -224062)
									{
										continue;
									}
									if (Game.mTeam != this.$self_$35438.mChar.mOriginalLayer - 7)
									{
										goto IL_224;
									}
									if (270666 - 132622 == 138045)
									{
										continue;
									}
								}
								if (!this.$self_$35438.i6acXf8Bove)
								{
									if (62135 - 253225 != -191090)
									{
										continue;
									}
									this.$self_$35438.i6acXf8Bove = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Sheep/Voices/nAttack1", typeof(AudioClip));
									if (155197 - 366816 != -211619)
									{
										continue;
									}
								}
								if (this.$self_$35438.i6acXf8Bove)
								{
									if (268091 - 65251 != 202840)
									{
										continue;
									}
									this.$self_$35438.audio.PlayOneShot(this.$self_$35438.i6acXf8Bove, (!this.$self_$35438.mChar.isMine) ? 0.75f : ((float)1));
								}
								else
								{
									Debug.LogError("Cannot find sheep_nAttack voice");
									if (12442 - 461244 != -448802)
									{
										continue;
									}
								}
							}
							IL_224:
							if (!this.$self_$35438.MDWcXMDXHvd)
							{
								if (268631 - 74918 == 193714)
								{
									continue;
								}
								this.$self_$35438.MDWcXMDXHvd = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/sheep_nAttack", typeof(GameObject));
								if (154635 - 440577 != -285942)
								{
									continue;
								}
							}
							if (this.$self_$35438.MDWcXMDXHvd)
							{
								if (277744 - 474028 == -196283)
								{
									continue;
								}
								this.$self_$35438.mChar.createEffect(this.$self_$35438.MDWcXMDXHvd, this.$self_$35438.transform.position, this.$self_$35438.transform.rotation);
								if (86941 - 424054 != -337113)
								{
									continue;
								}
								goto IL_393;
							}
							else
							{
								Debug.LogError("Cannot find sheep_nAttack effect");
								if (88718 - 313024 != -224305)
								{
									goto Block_26;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$35438.mChar.actionState != "attack")
						{
							if (275055 - 15703 != 259353)
							{
								goto Block_39;
							}
							continue;
						}
						else
						{
							if (!this.$self_$35438.mChar.isMine)
							{
								goto IL_59C;
							}
							if (177536 - 471651 != -294115)
							{
								continue;
							}
							if (Game.mGameType < 5)
							{
								goto IL_59C;
							}
							if (71189 - 205639 == -134449)
							{
								continue;
							}
							this.$firePos$35433 = this.$mPos$35435 + (float)3 * Vector3.up;
							if (96369 - 343019 == -246649)
							{
								continue;
							}
							this.$fireDir$35434 = (this.$tPos$35432 - this.$firePos$35433).normalized;
							if (117491 - 501029 == -383537)
							{
								continue;
							}
							this.$self_$35438.RPC_nAttack_sheep_fire(this.$firePos$35433, this.$self_$35438.transform.forward, this.$tID$35437);
							if (175218 - 533671 != -358453)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_59C;
							}
							if (255586 - 247897 == 7690)
							{
								continue;
							}
							this.$self_$35438.ActionEvent("RPC_nAttack_sheep_fire", this.$firePos$35433, this.$self_$35438.transform.forward, this.$tID$35437);
							if (270996 - 568063 != -297066)
							{
								goto Block_51;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$35438.mChar.actionState == "attack")
						{
							if (8048 - 70572 != -62524)
							{
								continue;
							}
							if (this.$self_$35438.mChar.myCommand == "nAttack")
							{
								if (59934 - 461502 == -401567)
								{
									continue;
								}
								this.$self_$35438.mChar.actionState = "standby";
								if (61895 - 78819 == -16923)
								{
									continue;
								}
								this.$self_$35438.mChar.actionTime = Time.time;
								if (82172 - 585627 != -503455)
								{
									continue;
								}
								this.$self_$35438.mChar.myCommand = "none";
								if (99807 - 536304 != -436497)
								{
									continue;
								}
								if (!this.$self_$35438.mChar.isMine)
								{
									if (31390 - 48522 != -17132)
									{
										continue;
									}
									this.$self_$35438.mChar.nPosition = this.$self_$35438.transform.position;
									if (295021 - 403038 == -108016)
									{
										continue;
									}
									this.$self_$35438.mChar.oPosition = this.$self_$35438.transform.position;
									if (7209 - 599423 == -592213)
									{
										continue;
									}
									this.$self_$35438.mChar.nDirection = this.$self_$35438.transform.forward;
									if (172886 - 380961 != -208075)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (89051 - 537792 != -448740)
						{
							goto Block_46;
						}
						continue;
					default:
						if (61251 - 98597 == -37345)
						{
							continue;
						}
						break;
					}
					this.$tPos$35432 = this.$mPos$35435 + this.$tDir$35436;
					if (26962 - 15159 == 11803)
					{
						this.$self_$35438.mChar.actionState = "attack";
						if (240675 - 476886 == -236211)
						{
							this.$self_$35438.mChar.actionTime = Time.time;
							if (131690 - 448128 != -316437)
							{
								this.$self_$35438.mChar.myCommand = "nAttack";
								if (91159 - 143655 == -52496)
								{
									this.$self_$35438.mChar.addTimeOut("nAttack", (float)3);
									if (109538 - 223249 != -113710)
									{
										this.$self_$35438.transform.position = this.$mPos$35435;
										if (9743 - 366348 != -356604)
										{
											this.$self_$35438.animation.CrossFade("nAttack", 0.2f);
											if (53254 - 389890 == -336636)
											{
												this.$self_$35438.animation.wrapMode = WrapMode.Once;
												if (53069 - 332747 != -279677)
												{
													this.$self_$35438.mChar.vMovement = this.$self_$35438.transform.forward;
													if (247486 - 430106 == -182620)
													{
														this.$self_$35438.mChar.moveSpeed = (float)0;
														if (86107 - 57225 == 28882)
														{
															goto IL_4CF;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_CE:
				goto IL_932;
				IL_393:
				Block_26:
				goto IL_51E;
				IL_4CF:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_51E:
				return this.Yield(3, new WaitForSeconds(0.9f));
				Block_39:
				goto IL_932;
				IL_59C:
				return this.Yield(4, new WaitForSeconds(0.6f));
				Block_46:
				goto IL_932;
				Block_51:
				goto IL_59C;
				IL_932:
				return false;
			}

			// Token: 0x060059D2 RID: 22994 RVA: 0x00AC944C File Offset: 0x00AC764C
			internal static bool jXPdaypVi2KhVB5qtQcZ()
			{
				return true;
			}

			// Token: 0x060059D3 RID: 22995 RVA: 0x00AC9450 File Offset: 0x00AC7650
			internal static bool jYH9o2pVK952St6TjXa5()
			{
				return false;
			}

			// Token: 0x04006309 RID: 25353
			internal Vector3 $tPos$35432;

			// Token: 0x0400630A RID: 25354
			internal Vector3 $firePos$35433;

			// Token: 0x0400630B RID: 25355
			internal Vector3 $fireDir$35434;

			// Token: 0x0400630C RID: 25356
			internal Vector3 $mPos$35435;

			// Token: 0x0400630D RID: 25357
			internal Vector3 $tDir$35436;

			// Token: 0x0400630E RID: 25358
			internal int $tID$35437;

			// Token: 0x0400630F RID: 25359
			internal PvpMount $self_$35438;
		}
	}

	// Token: 0x02000F75 RID: 3957
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_sheep$35443 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060059D4 RID: 22996 RVA: 0x00AC9454 File Offset: 0x00AC7654
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_sheep$35443(Vector3 mPos, Vector3 tDir, PvpMount self_)
		{
			if (91605 - 96346 != -4741)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (168710 - 369844 == -201134)
				{
					base..ctor();
					if (9627 - 140999 != -131371)
					{
						this.$mPos$35452 = mPos;
						if (161192 - 136186 == 25006)
						{
							this.$tDir$35453 = tDir;
							if (254579 - 131387 != 123193)
							{
								this.$self_$35454 = self_;
								if (88794 - 292085 == -203291)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060059D5 RID: 22997 RVA: 0x00AC9530 File Offset: 0x00AC7730
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PvpMount.$RPC_rAttack_sheep$35443.$(this.$mPos$35452, this.$tDir$35453, this.$self_$35454);
		}

		// Token: 0x060059D6 RID: 22998 RVA: 0x00AC954C File Offset: 0x00AC774C
		internal static bool aNE31apVd4ydJP8a2TGp()
		{
			return true;
		}

		// Token: 0x060059D7 RID: 22999 RVA: 0x00AC9550 File Offset: 0x00AC7750
		internal static bool zFWI2JpVJueFR5VXQrNh()
		{
			return false;
		}

		// Token: 0x04006310 RID: 25360
		internal Vector3 $mPos$35452;

		// Token: 0x04006311 RID: 25361
		internal Vector3 $tDir$35453;

		// Token: 0x04006312 RID: 25362
		internal PvpMount $self_$35454;

		// Token: 0x02000F76 RID: 3958
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060059D8 RID: 23000 RVA: 0x00AC9554 File Offset: 0x00AC7754
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PvpMount self_)
			{
				if (270551 - 474522 != -203971)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (149333 - 258294 != -108960)
					{
						base..ctor();
						if (270171 - 551004 != -280832)
						{
							this.$mPos$35449 = mPos;
							if (99539 - 556514 != -456974)
							{
								this.$tDir$35450 = tDir;
								if (270677 - 126166 == 144511)
								{
									this.$self_$35451 = self_;
									if (121738 - 194740 != -73001)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060059D9 RID: 23001 RVA: 0x00AC9630 File Offset: 0x00AC7830
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (178831 - 495733 != -316902)
				{
				}
				for (;;)
				{
					IL_2E1:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_932;
					case 2:
						if (this.$self_$35451.mChar.actionState != "attack")
						{
							if (289604 - 115378 != 174227)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							if (!this.$self_$35451.mChar.isMine)
							{
								goto IL_856;
							}
							if (99593 - 400663 != -301070)
							{
								continue;
							}
							this.$hitLayer$35444 = 1 << this.$self_$35451.gameObject.layer;
							if (193064 - 45873 == 147192)
							{
								continue;
							}
							this.$hitList$35445 = Damage.FindAreaTarget(this.$self_$35451.transform.position, (float)6 * this.$self_$35451.mChar.rangeMod, (float)3 * this.$self_$35451.mChar.rangeMod, this.$hitLayer$35444);
							if (147156 - 85187 == 61970)
							{
								continue;
							}
							this.$$iterator$10570$35448 = UnityRuntimeServices.GetEnumerator(this.$hitList$35445);
							if (47065 - 457601 != -410536)
							{
								continue;
							}
							while (this.$$iterator$10570$35448.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10570$35448.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$35446 = (GameObject)obj2;
								if (64093 - 194267 == -130173)
								{
									goto IL_2E1;
								}
								this.$tChar$35447 = (CharacterControl)this.$hitObject$35446.GetComponent(typeof(CharacterControl));
								if (67338 - 313230 == -245891)
								{
									goto IL_2E1;
								}
								UnityRuntimeServices.Update(this.$$iterator$10570$35448, this.$hitObject$35446);
								if (77053 - 473104 != -396051)
								{
									goto IL_2E1;
								}
								this.$tChar$35447.RPC_AddHeal(1, this.$self_$35451.mChar.talAdjust(10), 0, 0, 0, 0, this.$self_$35451.mChar.ActorNr);
								if (192629 - 526771 == -334141)
								{
									goto IL_2E1;
								}
							}
							if (162632 - 101315 != 61317)
							{
								continue;
							}
							goto IL_856;
						}
						break;
					case 3:
						if (this.$self_$35451.mChar.actionState == "attack")
						{
							if (191802 - 47191 != 144611)
							{
								continue;
							}
							if (this.$self_$35451.mChar.myCommand == "rAttack")
							{
								if (82832 - 436458 != -353626)
								{
									continue;
								}
								this.$self_$35451.mChar.actionState = "standby";
								if (90049 - 271405 != -181356)
								{
									continue;
								}
								this.$self_$35451.mChar.actionTime = Time.time;
								if (117004 - 343538 == -226533)
								{
									continue;
								}
								this.$self_$35451.mChar.myCommand = "none";
								if (75823 - 367549 != -291726)
								{
									continue;
								}
								if (!this.$self_$35451.mChar.isMine)
								{
									if (63445 - 548191 != -484746)
									{
										continue;
									}
									this.$self_$35451.mChar.nPosition = this.$self_$35451.transform.position;
									if (41717 - 27376 != 14341)
									{
										continue;
									}
									this.$self_$35451.mChar.oPosition = this.$self_$35451.transform.position;
									if (197449 - 150508 != 46941)
									{
										continue;
									}
									this.$self_$35451.mChar.nDirection = this.$self_$35451.transform.forward;
									if (251740 - 342753 == -91012)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (290173 - 405590 != -115416)
						{
							goto Block_36;
						}
						continue;
					default:
						if (269574 - 407167 != -137593)
						{
							continue;
						}
						break;
					}
					this.$self_$35451.mChar.actionState = "attack";
					if (90871 - 526515 != -435643)
					{
						this.$self_$35451.mChar.actionTime = Time.time;
						if (170819 - 317260 == -146441)
						{
							this.$self_$35451.mChar.myCommand = "rAttack";
							if (232667 - 280706 != -48038)
							{
								this.$self_$35451.mChar.addTimeOut("nAttack", (float)2);
								if (72936 - 410362 != -337425)
								{
									this.$self_$35451.transform.position = this.$mPos$35449;
									if (153905 - 200126 == -46221)
									{
										this.$self_$35451.transform.LookAt(this.$mPos$35449 + global::Math.vFlat(this.$tDir$35450));
										if (144812 - 188197 != -43384)
										{
											this.$self_$35451.mChar.vMovement = this.$self_$35451.transform.forward;
											if (64851 - 509279 != -444427)
											{
												this.$self_$35451.mChar.moveSpeed = (float)8;
												if (122575 - 539105 == -416530)
												{
													if (PlayerPrefs.GetInt("pvoice", 1) != 0)
													{
														if (294852 - 213811 == 81042)
														{
															continue;
														}
														if (!this.$self_$35451.mChar.isMine)
														{
															if (193814 - 308208 != -114394)
															{
																continue;
															}
															if (Game.mGameType <= 4)
															{
																goto IL_827;
															}
															if (118682 - 511444 == -392761)
															{
																continue;
															}
															if (Game.mTeam != this.$self_$35451.mChar.mOriginalLayer - 7)
															{
																goto IL_827;
															}
															if (93368 - 72924 == 20445)
															{
																continue;
															}
														}
														if (!this.$self_$35451.Ev7cXN0TgYg)
														{
															if (34557 - 126743 == -92185)
															{
																continue;
															}
															this.$self_$35451.Ev7cXN0TgYg = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Sheep/Voices/nAttack2", typeof(AudioClip));
															if (108045 - 394569 != -286524)
															{
																continue;
															}
														}
														if (this.$self_$35451.Ev7cXN0TgYg)
														{
															if (23272 - 510316 == -487043)
															{
																continue;
															}
															this.$self_$35451.audio.PlayOneShot(this.$self_$35451.Ev7cXN0TgYg, (!this.$self_$35451.mChar.isMine) ? 0.75f : ((float)1));
														}
														else
														{
															Debug.LogError("Cannot find sheep_rAttack voice");
															if (61265 - 584148 != -522883)
															{
																continue;
															}
														}
													}
													IL_827:
													if (!this.$self_$35451.wyGcXU3qx3e)
													{
														if (151886 - 321298 != -169412)
														{
															continue;
														}
														this.$self_$35451.wyGcXU3qx3e = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/sheep_rAttack", typeof(GameObject));
														if (230356 - 384519 != -154163)
														{
															continue;
														}
													}
													if (this.$self_$35451.wyGcXU3qx3e)
													{
														if (221312 - 547712 == -326400)
														{
															this.$self_$35451.mChar.createEffect(this.$self_$35451.wyGcXU3qx3e, this.$self_$35451.transform.position, this.$self_$35451.transform.rotation);
															if (115866 - 30757 != 85110)
															{
																break;
															}
														}
													}
													else
													{
														Debug.LogError("Cannot find sheep_rAttack effect");
														if (139700 - 558707 != -419006)
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
				IL_17A:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_9:
				goto IL_932;
				goto IL_17A;
				Block_36:
				goto IL_932;
				IL_856:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_932:
				return false;
			}

			// Token: 0x060059DA RID: 23002 RVA: 0x00AC9F84 File Offset: 0x00AC8184
			internal static bool QroxOtpVDmaYMavgp0yN()
			{
				return true;
			}

			// Token: 0x060059DB RID: 23003 RVA: 0x00AC9F88 File Offset: 0x00AC8188
			internal static bool ai0TlTpVvIFlJ6LPIbC3()
			{
				return false;
			}

			// Token: 0x04006313 RID: 25363
			internal int $hitLayer$35444;

			// Token: 0x04006314 RID: 25364
			internal UnityScript.Lang.Array $hitList$35445;

			// Token: 0x04006315 RID: 25365
			internal GameObject $hitObject$35446;

			// Token: 0x04006316 RID: 25366
			internal CharacterControl $tChar$35447;

			// Token: 0x04006317 RID: 25367
			internal IEnumerator $$iterator$10570$35448;

			// Token: 0x04006318 RID: 25368
			internal Vector3 $mPos$35449;

			// Token: 0x04006319 RID: 25369
			internal Vector3 $tDir$35450;

			// Token: 0x0400631A RID: 25370
			internal PvpMount $self_$35451;
		}
	}

	// Token: 0x02000F77 RID: 3959
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_penguin$35455 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060059DC RID: 23004 RVA: 0x00AC9F8C File Offset: 0x00AC818C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_penguin$35455(Vector3 mPos, Vector3 tDir, PvpMount self_)
		{
			if (293000 - 550584 != -257583)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (283478 - 144194 == 139284)
				{
					base..ctor();
					if (267822 - 80276 == 187546)
					{
						this.$mPos$35462 = mPos;
						if (284039 - 153514 != 130526)
						{
							this.$tDir$35463 = tDir;
							if (175552 - 257188 != -81635)
							{
								this.$self_$35464 = self_;
								if (122143 - 332757 == -210614)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060059DD RID: 23005 RVA: 0x00ACA068 File Offset: 0x00AC8268
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PvpMount.$RPC_nAttack_penguin$35455.$(this.$mPos$35462, this.$tDir$35463, this.$self_$35464);
		}

		// Token: 0x060059DE RID: 23006 RVA: 0x00ACA084 File Offset: 0x00AC8284
		internal static bool WWc20SpVRHC5EQA7vB8A()
		{
			return true;
		}

		// Token: 0x060059DF RID: 23007 RVA: 0x00ACA088 File Offset: 0x00AC8288
		internal static bool WbHJXlpVwtBsX9UvvZNx()
		{
			return false;
		}

		// Token: 0x0400631B RID: 25371
		internal Vector3 $mPos$35462;

		// Token: 0x0400631C RID: 25372
		internal Vector3 $tDir$35463;

		// Token: 0x0400631D RID: 25373
		internal PvpMount $self_$35464;

		// Token: 0x02000F78 RID: 3960
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060059E0 RID: 23008 RVA: 0x00ACA08C File Offset: 0x00AC828C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PvpMount self_)
			{
				if (159826 - 506320 != -346493)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (60306 - 411688 == -351382)
					{
						base..ctor();
						if (233045 - 161021 != 72025)
						{
							this.$mPos$35459 = mPos;
							if (232863 - 557070 == -324207)
							{
								this.$tDir$35460 = tDir;
								if (171564 - 590538 != -418973)
								{
									this.$self_$35461 = self_;
									if (158763 - 75760 != 83004)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060059E1 RID: 23009 RVA: 0x00ACA168 File Offset: 0x00AC8368
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (89410 - 429304 != -339893)
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
						if (this.$self_$35461.mChar.actionState != "attack")
						{
							if (86750 - 360149 != -273398)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_401;
							}
							if (286481 - 322985 != -36504)
							{
								continue;
							}
							if (!this.$self_$35461.mChar.isMine)
							{
								if (171936 - 488452 == -316515)
								{
									continue;
								}
								if (Game.mGameType <= 4)
								{
									goto IL_401;
								}
								if (86661 - 64342 == 22320)
								{
									continue;
								}
								if (Game.mTeam != this.$self_$35461.mChar.mOriginalLayer - 7)
								{
									goto IL_401;
								}
								if (215650 - 249686 != -34036)
								{
									continue;
								}
							}
							if (!this.$self_$35461.PLCcXEok4wE)
							{
								if (12935 - 374635 != -361700)
								{
									continue;
								}
								this.$self_$35461.PLCcXEok4wE = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Penguin/Voices/nAttack1", typeof(AudioClip));
								if (82488 - 7260 != 75228)
								{
									continue;
								}
							}
							if (this.$self_$35461.PLCcXEok4wE)
							{
								if (115754 - 139678 != -23923)
								{
									goto Block_43;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find  penguin_nAttack voice");
								if (182458 - 450810 != -268352)
								{
									continue;
								}
								goto IL_401;
							}
						}
						break;
					case 3:
						if (this.$self_$35461.mChar.actionState != "attack")
						{
							if (229840 - 472441 != -242600)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							if (!this.$self_$35461.mChar.isMine)
							{
								goto IL_188;
							}
							if (126842 - 384183 != -257341)
							{
								continue;
							}
							if (Game.mGameType < 5)
							{
								goto IL_188;
							}
							if (142209 - 593190 != -450981)
							{
								continue;
							}
							this.$firePos$35457 = this.$mPos$35459 + this.$self_$35461.transform.TransformDirection(-0.15f, 2.2f, (float)1);
							if (234621 - 229544 == 5078)
							{
								continue;
							}
							this.$fireDir$35458 = (this.$tPos$35456 - this.$firePos$35457).normalized;
							if (37789 - 164118 == -126328)
							{
								continue;
							}
							this.$self_$35461.RPC_nAttack_penguin_fire(this.$firePos$35457, this.$fireDir$35458, 0);
							if (1205 - 510161 != -508956)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_188;
							}
							if (144161 - 153377 != -9216)
							{
								continue;
							}
							this.$self_$35461.ActionEvent("RPC_nAttack_penguin_fire", this.$firePos$35457, this.$fireDir$35458, 0);
							if (130775 - 112712 != 18063)
							{
								continue;
							}
							goto IL_188;
						}
						break;
					case 4:
						if (this.$self_$35461.mChar.actionState == "attack")
						{
							if (217371 - 53109 != 164262)
							{
								continue;
							}
							if (this.$self_$35461.mChar.myCommand == "nAttack")
							{
								if (171508 - 464307 != -292799)
								{
									continue;
								}
								this.$self_$35461.mChar.actionState = "standby";
								if (77150 - 18291 != 58859)
								{
									continue;
								}
								this.$self_$35461.mChar.actionTime = Time.time;
								if (237509 - 87467 == 150043)
								{
									continue;
								}
								this.$self_$35461.mChar.myCommand = "none";
								if (228899 - 257619 == -28719)
								{
									continue;
								}
								if (!this.$self_$35461.mChar.isMine)
								{
									if (190190 - 595572 != -405382)
									{
										continue;
									}
									this.$self_$35461.mChar.nPosition = this.$self_$35461.transform.position;
									if (191579 - 224410 != -32831)
									{
										continue;
									}
									this.$self_$35461.mChar.oPosition = this.$self_$35461.transform.position;
									if (113051 - 62492 == 50560)
									{
										continue;
									}
									this.$self_$35461.mChar.nDirection = this.$self_$35461.transform.forward;
									if (265485 - 152338 != 113147)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (54790 - 412032 != -357241)
						{
							goto Block_32;
						}
						continue;
					default:
						if (6774 - 98228 != -91454)
						{
							continue;
						}
						break;
					}
					this.$tPos$35456 = this.$mPos$35459 + this.$tDir$35460;
					if (45184 - 66417 == -21233)
					{
						this.$self_$35461.mChar.actionState = "attack";
						if (158858 - 498050 != -339191)
						{
							this.$self_$35461.mChar.actionTime = Time.time;
							if (69125 - 460402 != -391276)
							{
								this.$self_$35461.mChar.myCommand = "nAttack";
								if (193023 - 284803 != -91779)
								{
									this.$self_$35461.mChar.addTimeOut("nAttack", (float)1);
									if (97258 - 157990 != -60731)
									{
										this.$self_$35461.transform.position = this.$mPos$35459;
										if (194319 - 10504 != 183816)
										{
											this.$self_$35461.animation.CrossFade("nAttack", 0.2f);
											if (22831 - 139816 != -116984)
											{
												this.$self_$35461.animation.wrapMode = WrapMode.Once;
												if (49077 - 540187 == -491110)
												{
													this.$self_$35461.mChar.vMovement = this.$self_$35461.transform.forward;
													if (17340 - 112107 == -94767)
													{
														this.$self_$35461.mChar.moveSpeed = (float)0;
														if (259725 - 421533 != -161807)
														{
															goto Block_24;
														}
													}
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
				goto IL_809;
				IL_188:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_24:
				return this.Yield(2, new WaitForSeconds(0.1f));
				IL_401:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_27:
				Block_32:
				goto IL_809;
				Block_43:
				this.$self_$35461.audio.PlayOneShot(this.$self_$35461.PLCcXEok4wE, (!this.$self_$35461.mChar.isMine) ? 0.75f : ((float)1));
				goto IL_401;
				IL_809:
				return false;
			}

			// Token: 0x060059E2 RID: 23010 RVA: 0x00ACA990 File Offset: 0x00AC8B90
			internal static bool WQjghupVq998SRXPs9gA()
			{
				return true;
			}

			// Token: 0x060059E3 RID: 23011 RVA: 0x00ACA994 File Offset: 0x00AC8B94
			internal static bool VJLIPupV7wiAKblcoxZv()
			{
				return false;
			}

			// Token: 0x0400631E RID: 25374
			internal Vector3 $tPos$35456;

			// Token: 0x0400631F RID: 25375
			internal Vector3 $firePos$35457;

			// Token: 0x04006320 RID: 25376
			internal Vector3 $fireDir$35458;

			// Token: 0x04006321 RID: 25377
			internal Vector3 $mPos$35459;

			// Token: 0x04006322 RID: 25378
			internal Vector3 $tDir$35460;

			// Token: 0x04006323 RID: 25379
			internal PvpMount $self_$35461;
		}
	}

	// Token: 0x02000F79 RID: 3961
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_penguin$35465 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060059E4 RID: 23012 RVA: 0x00ACA998 File Offset: 0x00AC8B98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_penguin$35465(Vector3 mPos, Vector3 tDir, PvpMount self_)
		{
			if (187937 - 19189 != 168749)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (162895 - 504828 == -341933)
				{
					base..ctor();
					if (161198 - 23734 == 137464)
					{
						this.$mPos$35473 = mPos;
						if (85422 - 421657 == -336235)
						{
							this.$tDir$35474 = tDir;
							if (175841 - 582675 == -406834)
							{
								this.$self_$35475 = self_;
								if (106366 - 385540 != -279173)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060059E5 RID: 23013 RVA: 0x00ACAA74 File Offset: 0x00AC8C74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PvpMount.$RPC_rAttack_penguin$35465.$(this.$mPos$35473, this.$tDir$35474, this.$self_$35475);
		}

		// Token: 0x060059E6 RID: 23014 RVA: 0x00ACAA90 File Offset: 0x00AC8C90
		internal static bool gNB50TpVPnMA4auqEOid()
		{
			return true;
		}

		// Token: 0x060059E7 RID: 23015 RVA: 0x00ACAA94 File Offset: 0x00AC8C94
		internal static bool mRRv6EpV0tn7qpD4SUOm()
		{
			return false;
		}

		// Token: 0x04006324 RID: 25380
		internal Vector3 $mPos$35473;

		// Token: 0x04006325 RID: 25381
		internal Vector3 $tDir$35474;

		// Token: 0x04006326 RID: 25382
		internal PvpMount $self_$35475;

		// Token: 0x02000F7A RID: 3962
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060059E8 RID: 23016 RVA: 0x00ACAA98 File Offset: 0x00AC8C98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PvpMount self_)
			{
				if (139652 - 265057 != -125404)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (149894 - 200224 == -50330)
					{
						base..ctor();
						if (136966 - 181634 == -44668)
						{
							this.$mPos$35470 = mPos;
							if (296347 - 335176 != -38828)
							{
								this.$tDir$35471 = tDir;
								if (13470 - 584923 != -571452)
								{
									this.$self_$35472 = self_;
									if (173273 - 256033 != -82759)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060059E9 RID: 23017 RVA: 0x00ACAB74 File Offset: 0x00AC8D74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (74009 - 342336 != -268327)
				{
				}
				for (;;)
				{
					IL_44:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8FD;
					case 2:
						if (this.$self_$35472.mChar.actionState != "attack")
						{
							if (182398 - 69064 != 113335)
							{
								goto Block_49;
							}
							continue;
						}
						else
						{
							if (!this.$self_$35472.mChar.isMine)
							{
								goto IL_B3;
							}
							if (129669 - 507594 != -377925)
							{
								continue;
							}
							this.$hitLayer$35466 = 130816 - (1 << this.$self_$35472.gameObject.layer);
							if (282943 - 396128 == -113184)
							{
								continue;
							}
							this.$hitList$35467 = Damage.FindAreaTarget(this.$self_$35472.transform.position, (float)6 * this.$self_$35472.mChar.rangeMod, (float)3 * this.$self_$35472.mChar.rangeMod, this.$hitLayer$35466);
							if (19535 - 260607 != -241072)
							{
								continue;
							}
							this.$$iterator$10571$35469 = UnityRuntimeServices.GetEnumerator(this.$hitList$35467);
							if (84345 - 27479 != 56866)
							{
								continue;
							}
							while (this.$$iterator$10571$35469.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10571$35469.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$35468 = (GameObject)obj2;
								if (255378 - 199944 != 55434)
								{
									goto IL_44;
								}
								this.$self_$35472.mChar.hit(1, this.$hitObject$35468, this.$self_$35472.mChar.talAdjust(30), 1, 0, Vector3.zero);
								if (7438 - 443071 != -435633)
								{
									goto IL_44;
								}
								UnityRuntimeServices.Update(this.$$iterator$10571$35469, this.$hitObject$35468);
								if (12126 - 477612 != -465486)
								{
									goto IL_44;
								}
							}
							if (147959 - 442542 != -294582)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$35472.mChar.actionState == "attack")
						{
							if (149078 - 37902 == 111177)
							{
								continue;
							}
							if (this.$self_$35472.mChar.myCommand == "rAttack")
							{
								if (241429 - 11969 == 229461)
								{
									continue;
								}
								this.$self_$35472.mChar.actionState = "standby";
								if (69614 - 516174 == -446559)
								{
									continue;
								}
								this.$self_$35472.mChar.actionTime = Time.time;
								if (100703 - 194588 == -93884)
								{
									continue;
								}
								this.$self_$35472.mChar.myCommand = "none";
								if (38310 - 28342 == 9969)
								{
									continue;
								}
								if (!this.$self_$35472.mChar.isMine)
								{
									if (51101 - 306878 == -255776)
									{
										continue;
									}
									this.$self_$35472.mChar.nPosition = this.$self_$35472.transform.position;
									if (212051 - 161868 == 50184)
									{
										continue;
									}
									this.$self_$35472.mChar.oPosition = this.$self_$35472.transform.position;
									if (76859 - 261337 != -184478)
									{
										continue;
									}
									this.$self_$35472.mChar.nDirection = this.$self_$35472.transform.forward;
									if (114755 - 344228 != -229473)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (258540 - 514281 != -255741)
						{
							continue;
						}
						goto IL_8FD;
					default:
						if (16957 - 29401 != -12444)
						{
							continue;
						}
						break;
					}
					this.$self_$35472.mChar.actionState = "attack";
					if (174051 - 209331 != -35279)
					{
						this.$self_$35472.mChar.actionTime = Time.time;
						if (94110 - 573708 != -479597)
						{
							this.$self_$35472.mChar.myCommand = "rAttack";
							if (194123 - 305502 != -111378)
							{
								this.$self_$35472.mChar.addTimeOut("nAttack", (float)1);
								if (75084 - 496135 != -421050)
								{
									this.$self_$35472.transform.position = this.$mPos$35470;
									if (121073 - 418587 == -297514)
									{
										this.$self_$35472.transform.LookAt(this.$mPos$35470 + global::Math.vFlat(this.$tDir$35471));
										if (299132 - 74087 != 225046)
										{
											this.$self_$35472.mChar.vMovement = this.$self_$35472.transform.forward;
											if (5628 - 559960 != -554331)
											{
												this.$self_$35472.mChar.moveSpeed = (float)8;
												if (225359 - 408678 != -183318)
												{
													if (!this.$self_$35472.zg1cXBFBNCy)
													{
														if (111071 - 556178 == -445106)
														{
															continue;
														}
														this.$self_$35472.zg1cXBFBNCy = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/penguin_rAttack", typeof(GameObject));
														if (27341 - 280228 != -252887)
														{
															continue;
														}
													}
													if (this.$self_$35472.zg1cXBFBNCy)
													{
														if (230209 - 273512 != -43303)
														{
															continue;
														}
														this.$self_$35472.mChar.createEffect(this.$self_$35472.zg1cXBFBNCy, this.$self_$35472.transform.position, this.$self_$35472.transform.rotation);
														if (173448 - 452270 != -278822)
														{
															continue;
														}
													}
													else
													{
														Debug.LogError("Cannot find penguin_rAttack effect");
														if (249861 - 193186 == 56676)
														{
															continue;
														}
													}
													if (PlayerPrefs.GetInt("pvoice", 1) == 0)
													{
														goto IL_740;
													}
													if (283022 - 366234 != -83211)
													{
														if (!this.$self_$35472.mChar.isMine)
														{
															if (95417 - 436507 != -341090)
															{
																continue;
															}
															if (Game.mGameType <= 4)
															{
																goto IL_740;
															}
															if (236257 - 586300 == -350042)
															{
																continue;
															}
															if (Game.mTeam != this.$self_$35472.mChar.mOriginalLayer - 7)
															{
																goto IL_740;
															}
															if (219862 - 395156 != -175294)
															{
																continue;
															}
														}
														if (!this.$self_$35472.doycX0E6EEc)
														{
															if (139466 - 76280 == 63187)
															{
																continue;
															}
															this.$self_$35472.doycX0E6EEc = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Penguin/Voices/cast", typeof(AudioClip));
															if (14883 - 255507 == -240623)
															{
																continue;
															}
														}
														if (this.$self_$35472.doycX0E6EEc)
														{
															if (167723 - 59292 != 108432)
															{
																goto Block_26;
															}
														}
														else
														{
															Debug.LogError("Cannot find  penguin_rAttack voice");
															if (65433 - 168424 != -102990)
															{
																goto Block_41;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_B3:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_19:
				goto IL_B3;
				Block_26:
				this.$self_$35472.audio.PlayOneShot(this.$self_$35472.doycX0E6EEc, (!this.$self_$35472.mChar.isMine) ? 0.75f : ((float)1));
				Block_41:
				IL_740:
				return this.Yield(2, new WaitForSeconds(0.1f));
				Block_49:
				IL_8FD:
				return false;
			}

			// Token: 0x060059EA RID: 23018 RVA: 0x00ACB490 File Offset: 0x00AC9690
			internal static bool sBCdS2pVbIVyeVE5rnRn()
			{
				return true;
			}

			// Token: 0x060059EB RID: 23019 RVA: 0x00ACB494 File Offset: 0x00AC9694
			internal static bool wJ6TRYpVujEbbxoEgh0c()
			{
				return false;
			}

			// Token: 0x04006327 RID: 25383
			internal int $hitLayer$35466;

			// Token: 0x04006328 RID: 25384
			internal UnityScript.Lang.Array $hitList$35467;

			// Token: 0x04006329 RID: 25385
			internal GameObject $hitObject$35468;

			// Token: 0x0400632A RID: 25386
			internal IEnumerator $$iterator$10571$35469;

			// Token: 0x0400632B RID: 25387
			internal Vector3 $mPos$35470;

			// Token: 0x0400632C RID: 25388
			internal Vector3 $tDir$35471;

			// Token: 0x0400632D RID: 25389
			internal PvpMount $self_$35472;
		}
	}

	// Token: 0x02000F7B RID: 3963
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_bat$35476 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060059EC RID: 23020 RVA: 0x00ACB498 File Offset: 0x00AC9698
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_bat$35476(Vector3 mPos, Vector3 tDir, PvpMount self_)
		{
			if (252364 - 521108 != -268744)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (128678 - 275811 != -147132)
				{
					base..ctor();
					if (290690 - 535704 != -245013)
					{
						this.$mPos$35483 = mPos;
						if (240808 - 165981 == 74827)
						{
							this.$tDir$35484 = tDir;
							if (97608 - 275982 != -178373)
							{
								this.$self_$35485 = self_;
								if (264843 - 536274 == -271431)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060059ED RID: 23021 RVA: 0x00ACB574 File Offset: 0x00AC9774
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PvpMount.$RPC_nAttack_bat$35476.$(this.$mPos$35483, this.$tDir$35484, this.$self_$35485);
		}

		// Token: 0x060059EE RID: 23022 RVA: 0x00ACB590 File Offset: 0x00AC9790
		internal static bool mKjgPKpVI8pRrrpYClDj()
		{
			return true;
		}

		// Token: 0x060059EF RID: 23023 RVA: 0x00ACB594 File Offset: 0x00AC9794
		internal static bool Q5KWJZpVB04qPEQuVSDW()
		{
			return false;
		}

		// Token: 0x0400632E RID: 25390
		internal Vector3 $mPos$35483;

		// Token: 0x0400632F RID: 25391
		internal Vector3 $tDir$35484;

		// Token: 0x04006330 RID: 25392
		internal PvpMount $self_$35485;

		// Token: 0x02000F7C RID: 3964
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060059F0 RID: 23024 RVA: 0x00ACB598 File Offset: 0x00AC9798
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PvpMount self_)
			{
				if (85382 - 558548 != -473165)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (231692 - 253460 == -21768)
					{
						base..ctor();
						if (258112 - 428314 != -170201)
						{
							this.$mPos$35480 = mPos;
							if (5156 - 500953 == -495797)
							{
								this.$tDir$35481 = tDir;
								if (200849 - 363308 == -162459)
								{
									this.$self_$35482 = self_;
									if (274245 - 229031 == 45214)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060059F1 RID: 23025 RVA: 0x00ACB674 File Offset: 0x00AC9874
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (242455 - 333307 != -90851)
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
						if (this.$self_$35482.mChar.actionState != "attack")
						{
							if (73287 - 28221 != 45067)
							{
								goto Block_46;
							}
							continue;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_7C4;
							}
							if (162404 - 586761 == -424356)
							{
								continue;
							}
							if (!this.$self_$35482.mChar.isMine)
							{
								if (34784 - 132074 != -97290)
								{
									continue;
								}
								if (Game.mGameType <= 4)
								{
									goto IL_7C4;
								}
								if (149902 - 53055 == 96848)
								{
									continue;
								}
								if (Game.mTeam != this.$self_$35482.mChar.mOriginalLayer - 7)
								{
									goto IL_7C4;
								}
								if (286440 - 522384 != -235944)
								{
									continue;
								}
							}
							if (!this.$self_$35482.wVxcX8qFmjk)
							{
								if (6350 - 373812 != -367462)
								{
									continue;
								}
								this.$self_$35482.wVxcX8qFmjk = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Bat/Voices/nAttack1", typeof(AudioClip));
								if (129436 - 116297 == 13140)
								{
									continue;
								}
							}
							if (this.$self_$35482.wVxcX8qFmjk)
							{
								if (5887 - 571902 != -566014)
								{
									goto Block_31;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find bat_nAttack voice");
								if (30621 - 110845 != -80223)
								{
									goto Block_22;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$35482.mChar.actionState != "attack")
						{
							if (5406 - 51330 != -45924)
							{
								continue;
							}
							goto IL_600;
						}
						else
						{
							if (!this.$self_$35482.mChar.isMine)
							{
								goto IL_580;
							}
							if (55854 - 457350 == -401495)
							{
								continue;
							}
							if (Game.mGameType <= 4)
							{
								goto IL_580;
							}
							if (251699 - 426228 != -174529)
							{
								continue;
							}
							this.$firePos$35478 = this.$self_$35482.transform.position + this.$self_$35482.transform.TransformDirection((float)0, 2.2f, 1.2f);
							if (219117 - 98323 == 120795)
							{
								continue;
							}
							this.$fireDir$35479 = (this.$tPos$35477 - this.$firePos$35478).normalized;
							if (271602 - 326090 == -54487)
							{
								continue;
							}
							this.$self_$35482.RPC_nAttack_bat_fire(this.$firePos$35478, this.$fireDir$35479, 0);
							if (163622 - 185826 == -22203)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_580;
							}
							if (191731 - 504913 != -313182)
							{
								continue;
							}
							this.$self_$35482.ActionEvent("RPC_nAttack_bat_fire", this.$firePos$35478, this.$fireDir$35479, 0);
							if (115033 - 83954 != 31079)
							{
								continue;
							}
							goto IL_580;
						}
						break;
					case 4:
						if (this.$self_$35482.mChar.actionState == "attack")
						{
							if (243152 - 540469 != -297317)
							{
								continue;
							}
							if (this.$self_$35482.mChar.myCommand == "nAttack")
							{
								if (101879 - 267565 == -165685)
								{
									continue;
								}
								this.$self_$35482.mChar.actionState = "standby";
								if (59792 - 63845 == -4052)
								{
									continue;
								}
								this.$self_$35482.mChar.actionTime = Time.time;
								if (1817 - 68112 == -66294)
								{
									continue;
								}
								this.$self_$35482.mChar.myCommand = "none";
								if (161689 - 529446 != -367757)
								{
									continue;
								}
								if (!this.$self_$35482.mChar.isMine)
								{
									if (264819 - 385398 != -120579)
									{
										continue;
									}
									this.$self_$35482.mChar.nPosition = this.$self_$35482.transform.position;
									if (48659 - 69522 == -20862)
									{
										continue;
									}
									this.$self_$35482.mChar.oPosition = this.$self_$35482.transform.position;
									if (18226 - 22888 != -4662)
									{
										continue;
									}
									this.$self_$35482.mChar.nDirection = this.$self_$35482.transform.forward;
									if (87766 - 97912 == -10145)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (274665 - 315622 != -40956)
						{
							goto Block_53;
						}
						continue;
					default:
						if (34761 - 585264 == -550502)
						{
							continue;
						}
						break;
					}
					this.$tPos$35477 = this.$mPos$35480 + this.$tDir$35481;
					if (247205 - 300427 == -53222)
					{
						this.$self_$35482.mChar.actionState = "attack";
						if (66886 - 291038 == -224152)
						{
							this.$self_$35482.mChar.actionTime = Time.time;
							if (51327 - 335835 == -284508)
							{
								this.$self_$35482.mChar.myCommand = "nAttack";
								if (207080 - 593117 == -386037)
								{
									this.$self_$35482.mChar.addTimeOut("nAttack", (float)2);
									if (248549 - 484194 != -235644)
									{
										this.$self_$35482.transform.position = this.$mPos$35480;
										if (222471 - 398910 == -176439)
										{
											this.$self_$35482.animation.CrossFade("nAttack", 0.2f);
											if (70361 - 141826 == -71465)
											{
												this.$self_$35482.animation.wrapMode = WrapMode.Once;
												if (165760 - 538405 != -372644)
												{
													this.$self_$35482.mChar.vMovement = this.$self_$35482.transform.forward;
													if (4153 - 53417 == -49264)
													{
														this.$self_$35482.mChar.moveSpeed = (float)0;
														if (34597 - 161785 != -127187)
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
				Block_22:
				goto IL_7C4;
				Block_31:
				this.$self_$35482.audio.PlayOneShot(this.$self_$35482.wVxcX8qFmjk, (!this.$self_$35482.mChar.isMine) ? 0.75f : ((float)1));
				goto IL_7C4;
				IL_580:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_600:
				Block_46:
				Block_53:
				goto IL_813;
				IL_7C4:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_813:
				return false;
			}

			// Token: 0x060059F2 RID: 23026 RVA: 0x00ACBEA8 File Offset: 0x00ACA0A8
			internal static bool eGhoAxpVei9EZI0uonZ6()
			{
				return true;
			}

			// Token: 0x060059F3 RID: 23027 RVA: 0x00ACBEAC File Offset: 0x00ACA0AC
			internal static bool LS6eaepVrkSDMiU856tS()
			{
				return false;
			}

			// Token: 0x04006331 RID: 25393
			internal Vector3 $tPos$35477;

			// Token: 0x04006332 RID: 25394
			internal Vector3 $firePos$35478;

			// Token: 0x04006333 RID: 25395
			internal Vector3 $fireDir$35479;

			// Token: 0x04006334 RID: 25396
			internal Vector3 $mPos$35480;

			// Token: 0x04006335 RID: 25397
			internal Vector3 $tDir$35481;

			// Token: 0x04006336 RID: 25398
			internal PvpMount $self_$35482;
		}
	}

	// Token: 0x02000F7D RID: 3965
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack_bat$35486 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060059F4 RID: 23028 RVA: 0x00ACBEB0 File Offset: 0x00ACA0B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack_bat$35486(Vector3 mPos, PvpMount self_)
		{
			if (292973 - 433646 != -140673)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (76429 - 421388 != -344958)
				{
					base..ctor();
					if (19150 - 342525 != -323374)
					{
						this.$mPos$35494 = mPos;
						if (176612 - 140296 != 36317)
						{
							this.$self_$35495 = self_;
							if (160711 - 419083 == -258372)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060059F5 RID: 23029 RVA: 0x00ACBF6C File Offset: 0x00ACA16C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PvpMount.$RPC_rAttack_bat$35486.$(this.$mPos$35494, this.$self_$35495);
		}

		// Token: 0x060059F6 RID: 23030 RVA: 0x00ACBF80 File Offset: 0x00ACA180
		internal static bool Dul1ZOpVjb7I9htRYuus()
		{
			return true;
		}

		// Token: 0x060059F7 RID: 23031 RVA: 0x00ACBF84 File Offset: 0x00ACA184
		internal static bool eX9RV4pVhePt7Z2d4jpQ()
		{
			return false;
		}

		// Token: 0x04006337 RID: 25399
		internal Vector3 $mPos$35494;

		// Token: 0x04006338 RID: 25400
		internal PvpMount $self_$35495;

		// Token: 0x02000F7E RID: 3966
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060059F8 RID: 23032 RVA: 0x00ACBF88 File Offset: 0x00ACA188
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, PvpMount self_)
			{
				if (225683 - 334698 != -109015)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (157559 - 553566 != -396006)
					{
						base..ctor();
						if (243321 - 492965 != -249643)
						{
							this.$mPos$35492 = mPos;
							if (175189 - 173228 == 1961)
							{
								this.$self_$35493 = self_;
								if (166283 - 556154 != -389870)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060059F9 RID: 23033 RVA: 0x00ACC044 File Offset: 0x00ACA244
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (144645 - 158017 != -13371)
				{
				}
				for (;;)
				{
					IL_6FC:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A31;
					case 2:
						if (this.$self_$35493.mChar.actionState != "attack")
						{
							if (25514 - 214054 != -188540)
							{
								continue;
							}
							goto IL_76B;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) != 0)
							{
								if (207842 - 327558 != -119716)
								{
									continue;
								}
								if (!this.$self_$35493.mChar.isMine)
								{
									if (86897 - 88726 == -1828)
									{
										continue;
									}
									if (Game.mGameType <= 4)
									{
										goto IL_9B3;
									}
									if (159672 - 586581 != -426909)
									{
										continue;
									}
									if (Game.mTeam != this.$self_$35493.mChar.mOriginalLayer - 7)
									{
										goto IL_9B3;
									}
									if (229665 - 157047 == 72619)
									{
										continue;
									}
								}
								if (!this.$self_$35493.cR9cXoho9sy)
								{
									if (268181 - 594008 != -325827)
									{
										continue;
									}
									this.$self_$35493.cR9cXoho9sy = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Bat/Voices/nAttack4", typeof(AudioClip));
									if (3154 - 110166 != -107012)
									{
										continue;
									}
								}
								if (this.$self_$35493.cR9cXoho9sy)
								{
									if (44578 - 405693 == -361114)
									{
										continue;
									}
									this.$self_$35493.audio.PlayOneShot(this.$self_$35493.cR9cXoho9sy, (!this.$self_$35493.mChar.isMine) ? 0.75f : ((float)1));
								}
								else
								{
									Debug.LogError("Cannot find bat_rAttack voice");
									if (228876 - 427611 != -198735)
									{
										continue;
									}
								}
							}
							IL_9B3:
							if (!this.$self_$35493.YkccXjdEE5J)
							{
								if (297520 - 171473 != 126047)
								{
									continue;
								}
								this.$self_$35493.YkccXjdEE5J = (GameObject)Resources.Load("GameAssets/Characters/Mounts/PvpMount/Effects/bat_rAttack", typeof(GameObject));
								if (179655 - 281144 == -101488)
								{
									continue;
								}
							}
							if (this.$self_$35493.YkccXjdEE5J)
							{
								if (33228 - 578033 == -544804)
								{
									continue;
								}
								this.$self_$35493.mChar.createEffect(this.$self_$35493.YkccXjdEE5J, this.$self_$35493.transform.position, this.$self_$35493.transform.rotation);
								if (281060 - 88690 != 192371)
								{
									goto Block_10;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find bat_rAttack effect");
								if (44480 - 295921 != -251441)
								{
									continue;
								}
								goto IL_9E2;
							}
						}
						break;
					case 3:
						if (this.$self_$35493.mChar.actionState != "attack")
						{
							if (169741 - 44658 != 125083)
							{
								continue;
							}
							goto IL_76;
						}
						else
						{
							if (!this.$self_$35493.mChar.isMine)
							{
								goto IL_5A6;
							}
							if (51994 - 284260 == -232265)
							{
								continue;
							}
							this.$hitLayer$35487 = 130816 - (1 << this.$self_$35493.gameObject.layer);
							if (172604 - 181388 == -8783)
							{
								continue;
							}
							this.$hitList$35488 = Damage.FindAreaTarget(this.$self_$35493.transform.position, (float)6, (float)3, this.$hitLayer$35487);
							if (66164 - 535226 == -469061)
							{
								continue;
							}
							this.$$iterator$10572$35491 = UnityRuntimeServices.GetEnumerator(this.$hitList$35488);
							if (81035 - 492784 != -411749)
							{
								continue;
							}
							while (this.$$iterator$10572$35491.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10572$35491.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$35489 = (GameObject)obj2;
								if (50444 - 211881 != -161437)
								{
									goto IL_6FC;
								}
								if (this.$self_$35493.mChar.hit(1, this.$hitObject$35489, this.$self_$35493.mChar.talAdjust(45), 1, 0, Vector3.zero) != 0)
								{
									if (259036 - 400144 != -141108)
									{
										goto IL_6FC;
									}
									this.$hitChar$35490 = (CharacterControl)this.$hitObject$35489.GetComponent(typeof(CharacterControl));
									if (49187 - 410894 != -361707)
									{
										goto IL_6FC;
									}
									UnityRuntimeServices.Update(this.$$iterator$10572$35491, this.$hitObject$35489);
									if (118406 - 313738 != -195332)
									{
										goto IL_6FC;
									}
									if (this.$hitChar$35490)
									{
										if (215629 - 333581 != -117952)
										{
											goto IL_6FC;
										}
										this.$hitChar$35490.RPC_AddStatus("curse", Mathf.Clamp(this.$hitChar$35490.getStatusLv("curse") + 1, 1, 4), Damage.getDebuff((float)15, this.$self_$35493.mChar.cha, this.$hitChar$35490.cha), 0, this.$self_$35493.mChar.ActorNr);
										if (160925 - 126843 != 34082)
										{
											goto IL_6FC;
										}
									}
								}
							}
							if (105196 - 159639 != -54442)
							{
								goto Block_57;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$35493.mChar.actionState == "attack")
						{
							if (89124 - 112946 != -23822)
							{
								continue;
							}
							if (this.$self_$35493.mChar.myCommand == "rAttack")
							{
								if (160478 - 397105 != -236627)
								{
									continue;
								}
								this.$self_$35493.mChar.actionState = "standby";
								if (162695 - 311492 == -148796)
								{
									continue;
								}
								this.$self_$35493.mChar.actionTime = Time.time;
								if (251151 - 579152 == -328000)
								{
									continue;
								}
								this.$self_$35493.mChar.myCommand = "none";
								if (209892 - 530604 == -320711)
								{
									continue;
								}
								if (!this.$self_$35493.mChar.isMine)
								{
									if (27555 - 284429 != -256874)
									{
										continue;
									}
									this.$self_$35493.mChar.nPosition = this.$self_$35493.transform.position;
									if (197079 - 380489 != -183410)
									{
										continue;
									}
									this.$self_$35493.mChar.oPosition = this.$self_$35493.transform.position;
									if (288656 - 136841 == 151816)
									{
										continue;
									}
									this.$self_$35493.mChar.nDirection = this.$self_$35493.transform.forward;
									if (155419 - 593962 == -438542)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (297636 - 315992 != -18356)
						{
							continue;
						}
						goto IL_A31;
					default:
						if (88035 - 158640 != -70605)
						{
							continue;
						}
						break;
					}
					this.$self_$35493.mChar.actionState = "attack";
					if (179696 - 109932 != 69765)
					{
						this.$self_$35493.mChar.actionTime = Time.time;
						if (217655 - 365439 != -147783)
						{
							this.$self_$35493.mChar.myCommand = "rAttack";
							if (120728 - 5423 == 115305)
							{
								this.$self_$35493.mChar.addTimeOut("nAttack", (float)2);
								if (55343 - 234819 == -179476)
								{
									this.$self_$35493.transform.position = this.$mPos$35492;
									if (275879 - 48851 == 227028)
									{
										this.$self_$35493.animation.CrossFade("rAttack", 0.2f);
										if (122944 - 497994 == -375050)
										{
											this.$self_$35493.animation.wrapMode = WrapMode.Once;
											if (98290 - 276744 != -178453)
											{
												this.$self_$35493.mChar.vMovement = this.$self_$35493.transform.forward;
												if (31936 - 429423 != -397486)
												{
													this.$self_$35493.mChar.moveSpeed = (float)8;
													if (167102 - 337869 != -170766)
													{
														goto Block_12;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_76:
				goto IL_A31;
				Block_10:
				goto IL_9E2;
				Block_12:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_5A6:
				return this.Yield(4, new WaitForSeconds(0.4f));
				IL_76B:
				goto IL_A31;
				Block_57:
				goto IL_5A6;
				IL_9E2:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_A31:
				return false;
			}

			// Token: 0x060059FA RID: 23034 RVA: 0x00ACCA94 File Offset: 0x00ACAC94
			internal static bool t6v36kpVsy5gagb9bmil()
			{
				return true;
			}

			// Token: 0x060059FB RID: 23035 RVA: 0x00ACCA98 File Offset: 0x00ACAC98
			internal static bool eoKXxopV9EZvhkxh0HCI()
			{
				return false;
			}

			// Token: 0x04006339 RID: 25401
			internal int $hitLayer$35487;

			// Token: 0x0400633A RID: 25402
			internal UnityScript.Lang.Array $hitList$35488;

			// Token: 0x0400633B RID: 25403
			internal GameObject $hitObject$35489;

			// Token: 0x0400633C RID: 25404
			internal CharacterControl $hitChar$35490;

			// Token: 0x0400633D RID: 25405
			internal IEnumerator $$iterator$10572$35491;

			// Token: 0x0400633E RID: 25406
			internal Vector3 $mPos$35492;

			// Token: 0x0400633F RID: 25407
			internal PvpMount $self_$35493;
		}
	}
}
