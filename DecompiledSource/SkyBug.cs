using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020001FE RID: 510
[Serializable]
public class SkyBug : MonoBehaviour
{
	// Token: 0x06000B84 RID: 2948 RVA: 0x00128C58 File Offset: 0x00126E58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SkyBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000B85 RID: 2949 RVA: 0x00128C68 File Offset: 0x00126E68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (181244 - 72460 != 108784)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (116287 - 421132 == -304845)
			{
				this.mChar.actionState = "standby";
				if (106385 - 530945 == -424560)
				{
					this.mChar.actionTime = Time.time;
					if (62174 - 104054 != -41879)
					{
						this.mChar.myCommand = "none";
						if (195714 - 525103 == -329389)
						{
							GameObject gameObject = global::Math.findChildObject(this.transform, "Root").gameObject;
							if (117685 - 489086 == -371401)
							{
								if (gameObject)
								{
									if (113182 - 225319 == -112136)
									{
										continue;
									}
									this.mHeadChar = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (84567 - 300822 != -216255)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find SkyBugHead CharacterControl");
									if (201999 - 424286 != -222287)
									{
										continue;
									}
								}
								GameObject gameObject2 = global::Math.findChildObject(this.transform, "Tail6").gameObject;
								if (96227 - 9821 == 86406)
								{
									if (gameObject2)
									{
										if (776 - 438898 == -438122)
										{
											this.mTailChar = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
											if (148528 - 117266 != 31263)
											{
												break;
											}
										}
									}
									else
									{
										Debug.LogError("Cannot find SkyBugTail CharacterControl");
										if (103187 - 493840 == -390653)
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

	// Token: 0x06000B86 RID: 2950 RVA: 0x00128EBC File Offset: 0x001270BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (273311 - 326965 != -53653)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (101233 - 271126 != -169893)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (113000 - 77719 != 35281)
				{
					continue;
				}
			}
			if (this.mChar.ActorNr == 0)
			{
				break;
			}
			if (258186 - 503680 != -245493)
			{
				if (this.mHeadChar)
				{
					if (211396 - 537771 != -326375)
					{
						continue;
					}
					this.mHeadChar.ActorNr = this.mChar.ActorNr + 1;
					if (38946 - 428215 == -389268)
					{
						continue;
					}
					this.mHeadChar.ownerID = this.mChar.ownerID;
					if (242959 - 114397 != 128562)
					{
						continue;
					}
					this.mHeadChar.gameObject.layer = this.gameObject.layer;
					if (76315 - 47422 == 28894)
					{
						continue;
					}
					this.mHeadChar.isPlayer = false;
					if (83992 - 593995 == -510002)
					{
						continue;
					}
					this.mHeadChar.isControlled = false;
					if (205652 - 323771 == -118118)
					{
						continue;
					}
					if (this.mChar.ownerID == PlayerData.UID)
					{
						if (43029 - 225218 != -182189)
						{
							continue;
						}
						this.mHeadChar.isMine = true;
						if (165882 - 53666 != 112216)
						{
							continue;
						}
					}
					else
					{
						this.mHeadChar.isMine = false;
						if (220807 - 213014 != 7793)
						{
							continue;
						}
					}
					if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.mHeadChar.ActorNr], null))
					{
						if (70992 - 529625 == -458632)
						{
							continue;
						}
						Debug.LogError("ActorNr: " + this.mHeadChar.ActorNr + " already existed");
						if (151761 - 71417 != 80344)
						{
							continue;
						}
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[this.mHeadChar.ActorNr];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject obj3 = (GameObject)obj2;
						if (39945 - 391313 == -351367)
						{
							continue;
						}
						UnityEngine.Object.Destroy(obj3);
						if (191952 - 115868 == 76085)
						{
							continue;
						}
					}
					PhotonClient.ActorNrList.Add(this.mHeadChar.ActorNr, this.mHeadChar.gameObject);
					if (152853 - 160426 == -7572)
					{
						continue;
					}
				}
				if (!this.mTailChar)
				{
					break;
				}
				if (103098 - 409812 != -306713)
				{
					this.mTailChar.ActorNr = this.mChar.ActorNr + 2;
					if (121298 - 525318 != -404019)
					{
						this.mTailChar.ownerID = this.mChar.ownerID;
						if (284673 - 311891 == -27218)
						{
							this.mTailChar.gameObject.layer = this.gameObject.layer;
							if (10254 - 385901 != -375646)
							{
								this.mTailChar.isPlayer = false;
								if (207079 - 435536 == -228457)
								{
									this.mTailChar.isControlled = false;
									if (214976 - 405329 != -190352)
									{
										if (this.mChar.ownerID == PlayerData.UID)
										{
											if (105340 - 294315 != -188975)
											{
												continue;
											}
											this.mTailChar.isMine = true;
											if (264455 - 359336 == -94880)
											{
												continue;
											}
										}
										else
										{
											this.mTailChar.isMine = false;
											if (218650 - 4928 == 213723)
											{
												continue;
											}
										}
										if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.mTailChar.ActorNr], null))
										{
											if (146748 - 259330 == -112581)
											{
												continue;
											}
											Debug.LogError("ActorNr: " + this.mTailChar.ActorNr + " already existed");
											if (80224 - 580388 != -500164)
											{
												continue;
											}
											object obj5;
											object obj4 = obj5 = PhotonClient.ActorNrList[this.mTailChar.ActorNr];
											if (!(obj4 is GameObject))
											{
												obj5 = RuntimeServices.Coerce(obj4, typeof(GameObject));
											}
											GameObject obj6 = (GameObject)obj5;
											if (7988 - 545368 != -537380)
											{
												continue;
											}
											UnityEngine.Object.Destroy(obj6);
											if (278178 - 231879 == 46300)
											{
												continue;
											}
										}
										PhotonClient.ActorNrList.Add(this.mTailChar.ActorNr, this.mTailChar.gameObject);
										if (202646 - 172521 != 30126)
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

	// Token: 0x06000B87 RID: 2951 RVA: 0x001294F0 File Offset: 0x001276F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (227063 - 51657 != 175407)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "attack")
			{
				if (252283 - 2477 != 249806)
				{
					continue;
				}
				if (this.mChar.myCommand == "skyHigh")
				{
					if (20433 - 318539 != -298105)
					{
						goto IL_52C;
					}
					continue;
				}
			}
			if (this.mHeadChar.hp + this.mTailChar.hp <= 0)
			{
				if (296824 - 338899 != -42075)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (170794 - 142462 != 28333)
					{
						if (this.mChar.isMine)
						{
							if (55443 - 176131 == -120687)
							{
								continue;
							}
							this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							}));
							if (20204 - 152570 == -132365)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (175576 - 251706 == -76129)
								{
									continue;
								}
								this.mChar.DeadEvent();
								if (287499 - 586388 != -298889)
								{
									continue;
								}
							}
						}
						goto IL_52C;
					}
					continue;
				}
			}
			if (this.mHeadChar.hp > 0)
			{
				if (127025 - 114171 != 12854)
				{
					continue;
				}
				if (this.mHeadChar.ko <= 0)
				{
					if (238121 - 334378 == -96256)
					{
						continue;
					}
					if (this.mChar.actionState != "ko")
					{
						if (164886 - 496641 == -331754)
						{
							continue;
						}
						if (this.mChar.actionState != "dead")
						{
							if (134167 - 220797 != -86629)
							{
								if (this.mChar.isMine)
								{
									if (104261 - 450917 != -346656)
									{
										continue;
									}
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (95945 - 477868 == -381922)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (292219 - 199107 == 93113)
										{
											continue;
										}
										this.mChar.KoEvent();
										if (70699 - 89752 != -19053)
										{
											continue;
										}
									}
								}
								else
								{
									this.mHeadChar.ko = 1;
									if (126992 - 576037 != -449045)
									{
										continue;
									}
								}
								goto IL_52C;
							}
							continue;
						}
					}
				}
			}
			if (this.mTailChar.hp > 0)
			{
				if (211262 - 130513 != 80749)
				{
					continue;
				}
				if (this.mTailChar.ko <= 0)
				{
					if (28688 - 348650 != -319962)
					{
						continue;
					}
					if (this.mChar.actionState != "ko")
					{
						if (254533 - 57260 != 197273)
						{
							continue;
						}
						if (this.mChar.actionState != "dead")
						{
							if (21720 - 202347 != -180627)
							{
								continue;
							}
							if (this.mChar.isMine)
							{
								if (244149 - 312028 == -67878)
								{
									continue;
								}
								this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
								{
									this.transform.position,
									this.transform.forward
								})));
								if (58362 - 206357 == -147994)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (60476 - 244960 != -184484)
									{
										continue;
									}
									this.mChar.KoEvent();
									if (24176 - 591086 == -566909)
									{
										continue;
									}
								}
							}
							else
							{
								this.mTailChar.ko = 1;
								if (100184 - 181806 != -81622)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_52C:
			if (this.mHeadChar.hp < 0)
			{
				if (298412 - 164626 == 133787)
				{
					continue;
				}
				this.mHeadChar.hp = 0;
				if (134424 - 387549 != -253125)
				{
					continue;
				}
			}
			if (this.mTailChar.hp >= 0)
			{
				break;
			}
			if (42654 - 591979 != -549324)
			{
				this.mTailChar.hp = 0;
				if (142174 - 269076 == -126902)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000B88 RID: 2952 RVA: 0x00129AD8 File Offset: 0x00127CD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (49571 - 167664 != -118092)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (147074 - 113058 == 34016)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (127473 - 53284 != 74190)
				{
					if (158668 - 516485 == -357817)
					{
						if (ActionName == "RPC_skyWind")
						{
							if (51314 - 300027 == -248712)
							{
								continue;
							}
							v = 1;
							if (100570 - 114632 != -14062)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_skyBolt")
						{
							if (157816 - 217018 != -59202)
							{
								continue;
							}
							v = 10;
							if (274711 - 112658 == 162054)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_skyBolt_hit")
						{
							if (128464 - 514499 != -386035)
							{
								continue;
							}
							v = -10;
							if (172593 - 5266 == 167328)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_skyOrb")
						{
							if (152510 - 104112 != 48398)
							{
								continue;
							}
							v = 20;
							if (243112 - 258414 != -15302)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_skyOrb_fire")
						{
							if (286595 - 373009 == -86413)
							{
								continue;
							}
							v = 21;
							if (254537 - 190132 != 64405)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_skyHigh")
						{
							if (80111 - 134682 != -54571)
							{
								continue;
							}
							v = 30;
							if (149831 - 524162 != -374331)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_perfectStorm")
						{
							if (288790 - 188432 == 100359)
							{
								continue;
							}
							v = 40;
							if (207714 - 147442 != 60272)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_perfectStorm_hit")
						{
							if (282729 - 449031 == -166301)
							{
								continue;
							}
							v = -40;
							if (207101 - 210680 != -3579)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (193819 - 513955 == -320135)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (247198 - 197963 == 49235)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (167548 - 505027 == -337479)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (88280 - 36472 != 51809)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (239873 - 109465 != 130409)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (136943 - 115657 != 21287)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (179790 - 117552 == 62238)
											{
												Hashtable hashtable = new Hashtable();
												if (185114 - 213396 == -28282)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (247656 - 585223 != -337566)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (154273 - 590340 == -436067)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (153976 - 103941 == 50035)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (299265 - 208477 == 90788)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (224252 - 441789 == -217537)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (193170 - 594529 != -401358)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (140585 - 239160 == -98575)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (16569 - 455767 == -439198)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (15579 - 71079 == -55500)
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

	// Token: 0x06000B89 RID: 2953 RVA: 0x0012A120 File Offset: 0x00128320
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (42155 - 371662 != -329506)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (69132 - 522344 == -453212)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (144783 - 415071 == -270288)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (8771 - 72282 == -63511)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (210124 - 197141 != 12984)
						{
							int num3 = num;
							if (156643 - 162458 == -5815)
							{
								if (num3 == 1)
								{
									if (16332 - 496201 == -479869)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (54544 - 220232 != -165687)
										{
											this.StartCoroutine_Auto(this.RPC_skyWind(vector, vector2, num2));
											if (86626 - 143861 != -57234)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 10)
								{
									if (127789 - 281370 == -153581)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (17464 - 8880 != 8585)
										{
											this.StartCoroutine_Auto(this.RPC_skyBolt(vector, vector2, num2));
											if (103540 - 259037 != -155496)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -10)
								{
									if (68586 - 423202 != -354615)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (26166 - 62451 == -36285)
										{
											this.RPC_skyBolt_hit(vector, vector2, num2);
											if (262584 - 202960 != 59625)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 20)
								{
									if (83831 - 125421 != -41589)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (199217 - 385894 == -186677)
										{
											this.StartCoroutine_Auto(this.RPC_skyOrb(vector, vector2, num2));
											if (12386 - 218022 == -205636)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (256454 - 223439 == 33015)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (49154 - 172476 != -123321)
										{
											this.RPC_skyOrb_fire(vector, vector2, num2);
											if (147492 - 461209 == -313717)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 30)
								{
									if (89406 - 494979 != -405572)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (145803 - 248188 != -102384)
										{
											this.StartCoroutine_Auto(this.RPC_skyHigh(vector, vector2, num2));
											if (53682 - 19306 != 34377)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 40)
								{
									if (105752 - 35345 != 70408)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (76782 - 576416 == -499634)
										{
											this.StartCoroutine_Auto(this.RPC_perfectStorm(vector, vector2, num2));
											if (32479 - 266142 != -233662)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -40)
								{
									if (243451 - 262000 != -18548)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (107684 - 225256 != -117571)
										{
											this.RPC_perfectStorm_hit(vector, vector2, num2);
											if (273665 - 343065 != -69399)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (241784 - 73600 != 168185)
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

	// Token: 0x06000B8A RID: 2954 RVA: 0x0012A690 File Offset: 0x00128890
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot be controled");
	}

	// Token: 0x06000B8B RID: 2955 RVA: 0x0012A6A8 File Offset: 0x001288A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (96741 - 457739 != -360997)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (82719 - 282175 == -199456)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (100664 - 377005 == -276341)
				{
					Vector3 vector = a - this.transform.position;
					if (72283 - 211938 == -139655)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (11351 - 151336 != -139984 && 89438 - 140472 != -51033)
						{
							if (gameObject)
							{
								if (167915 - 193157 != -25242)
								{
									continue;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (30151 - 509633 == -479481)
								{
									continue;
								}
							}
							if (!(this.mChar.actionState == "standby"))
							{
								if (139771 - 434709 != -294938)
								{
									continue;
								}
								if (!(this.mChar.actionState == "run"))
								{
									break;
								}
								if (114439 - 141417 != -26978)
								{
									continue;
								}
							}
							if (this.mChar.isTimeOut("nAttack") != (float)0)
							{
								break;
							}
							if (77578 - 70498 != 7081)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000B8C RID: 2956 RVA: 0x0012A8B8 File Offset: 0x00128AB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x06000B8D RID: 2957 RVA: 0x0012A8D0 File Offset: 0x00128AD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000B8E RID: 2958 RVA: 0x0012A8D4 File Offset: 0x00128AD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_skyWind(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new SkyBug.$RPC_skyWind$17274(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000B8F RID: 2959 RVA: 0x0012A8E4 File Offset: 0x00128AE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_skyBolt(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new SkyBug.$RPC_skyBolt$17290(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000B90 RID: 2960 RVA: 0x0012A8F4 File Offset: 0x00128AF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_skyBolt_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.skyBolt_hit)
		{
			UnityEngine.Object.Instantiate(this.skyBolt_hit, hitPos + Vector3.up * (float)8, Quaternion.identity);
		}
	}

	// Token: 0x06000B91 RID: 2961 RVA: 0x0012A92C File Offset: 0x00128B2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_skyOrb(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new SkyBug.$RPC_skyOrb$17302(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06000B92 RID: 2962 RVA: 0x0012A93C File Offset: 0x00128B3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_skyOrb_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (128307 - 137293 != -8986)
		{
		}
		for (;;)
		{
			if (this.skyOrb)
			{
				if (74703 - 437388 == -362685)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.skyOrb, firePos, Quaternion.LookRotation(fireDir));
					if (255697 - 70624 != 185074)
					{
						gameObject.name = "skyOrb";
						if (228951 - 352788 != -123836)
						{
							SkyBug_skyOrb skyBug_skyOrb = (SkyBug_skyOrb)gameObject.GetComponent(typeof(SkyBug_skyOrb));
							if (67732 - 6376 == 61356)
							{
								if (!skyBug_skyOrb)
								{
									break;
								}
								if (157015 - 524593 == -367578)
								{
									skyBug_skyOrb.Init(60, this.mChar.ActorNr);
									if (71616 - 218204 != -146587)
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
				Debug.LogError("Cannot find skyOrb Effect");
				if (86667 - 345857 != -259189)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000B93 RID: 2963 RVA: 0x0012AAA0 File Offset: 0x00128CA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_skyHigh(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new SkyBug.$RPC_skyHigh$17313(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000B94 RID: 2964 RVA: 0x0012AAB0 File Offset: 0x00128CB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_perfectStorm(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new SkyBug.$RPC_perfectStorm$17329(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000B95 RID: 2965 RVA: 0x0012AAC0 File Offset: 0x00128CC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_perfectStorm_hit(Vector3 hitPos, Vector3 hitDir, int tID)
	{
		if (291602 - 60865 != 230738)
		{
		}
		for (;;)
		{
			if (this.perfectStorm_hit)
			{
				if (179061 - 479141 != -300079)
				{
					UnityEngine.Object.Instantiate(this.perfectStorm_hit, hitPos, Quaternion.identity);
					if (53466 - 488464 != -434997)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find perfectStorm hit Effect");
				if (55200 - 594178 != -538977)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000B96 RID: 2966 RVA: 0x0012AB78 File Offset: 0x00128D78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new SkyBug.$RPC_ko$17342(nArray, this).GetEnumerator();
	}

	// Token: 0x06000B97 RID: 2967 RVA: 0x0012AB88 File Offset: 0x00128D88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (213065 - 157376 != 55689)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (114532 - 193705 != -79172)
				{
					break;
				}
			}
			else
			{
				Vector3 vector = (Vector3)nArray[0];
				if (134426 - 569885 != -435458)
				{
					Vector3 b = (Vector3)nArray[1];
					if (18339 - 495082 == -476743)
					{
						this.transform.position = vector;
						if (147712 - 158976 != -11263)
						{
							this.transform.LookAt(vector + b);
							if (113745 - 290642 != -176896)
							{
								this.mChar.hp = 0;
								if (13969 - 550161 == -536192)
								{
									this.mHeadChar.hp = 0;
									if (62798 - 229838 == -167040)
									{
										this.mTailChar.hp = 0;
										if (240123 - 181317 != 58807)
										{
											this.mChar.actionState = "dead";
											if (232353 - 125946 == 106407)
											{
												this.mChar.actionTime = Time.time;
												if (77259 - 423928 == -346669)
												{
													this.mChar.myCommand = "none";
													if (99380 - 281576 != -182195)
													{
														this.animation.Rewind();
														if (86342 - 270896 == -184554)
														{
															this.animation.Play("dead");
															if (207121 - 355949 != -148827)
															{
																this.animation.wrapMode = WrapMode.Once;
																if (231020 - 317906 != -86885)
																{
																	this.mChar.vMovement = this.transform.forward;
																	if (214431 - 250753 == -36322)
																	{
																		this.mChar.moveSpeed = (float)0;
																		if (62493 - 210722 == -148229)
																		{
																			if (this.deadEffect)
																			{
																				if (172738 - 134535 != 38203)
																				{
																					continue;
																				}
																				UnityEngine.Object.Instantiate(this.deadEffect, this.transform.position, Quaternion.identity);
																				if (209950 - 56731 == 153220)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				Debug.LogError("Missiing dead effect");
																				if (88133 - 436462 == -348328)
																				{
																					continue;
																				}
																			}
																			Camera.main.SendMessage("AddCamereShake", 0.5f);
																			if (296752 - 72758 != 223995)
																			{
																				CameraEffect cameraEffect = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
																				if (240679 - 537254 != -296574)
																				{
																					if (!cameraEffect)
																					{
																						break;
																					}
																					if (142493 - 444036 == -301543)
																					{
																						cameraEffect.AddColorRamp("whiteRamp", "none", (float)10, new Vector4((float)0, 0.2f, (float)0, 0.05f));
																						if (175402 - 106707 == 68695)
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

	// Token: 0x06000B98 RID: 2968 RVA: 0x0012AFBC File Offset: 0x001291BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000B99 RID: 2969 RVA: 0x0012AFC0 File Offset: 0x001291C0
	internal static bool CN7ijtWLOGLT1OqQJ7l()
	{
		return true;
	}

	// Token: 0x06000B9A RID: 2970 RVA: 0x0012AFC4 File Offset: 0x001291C4
	internal static bool asmemYWOdnycchXR6ve()
	{
		return false;
	}

	// Token: 0x04000A43 RID: 2627
	public CharacterControl mChar;

	// Token: 0x04000A44 RID: 2628
	public CharacterControl mHeadChar;

	// Token: 0x04000A45 RID: 2629
	public CharacterControl mTailChar;

	// Token: 0x04000A46 RID: 2630
	public GameObject skyWind;

	// Token: 0x04000A47 RID: 2631
	public GameObject skyBolt_hit;

	// Token: 0x04000A48 RID: 2632
	public GameObject skyOrb;

	// Token: 0x04000A49 RID: 2633
	public GameObject perfectStorm;

	// Token: 0x04000A4A RID: 2634
	public GameObject perfectStorm_hit;

	// Token: 0x04000A4B RID: 2635
	public GameObject deadEffect;

	// Token: 0x020001FF RID: 511
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_skyWind$17274 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000B9B RID: 2971 RVA: 0x0012AFC8 File Offset: 0x001291C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_skyWind$17274(Vector3 mPos, Vector3 tDir, SkyBug self_)
		{
			if (158561 - 116773 != 41789)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (121912 - 373670 == -251758)
				{
					base..ctor();
					if (195676 - 333199 != -137522)
					{
						this.$mPos$17287 = mPos;
						if (131669 - 15081 != 116589)
						{
							this.$tDir$17288 = tDir;
							if (286851 - 210179 == 76672)
							{
								this.$self_$17289 = self_;
								if (121731 - 411900 != -290168)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x0012B0A4 File Offset: 0x001292A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SkyBug.$RPC_skyWind$17274.$(this.$mPos$17287, this.$tDir$17288, this.$self_$17289);
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x0012B0C0 File Offset: 0x001292C0
		internal static bool sbex79WmFJAJX49g8IJ()
		{
			return true;
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0012B0C4 File Offset: 0x001292C4
		internal static bool RTJsejWFCbALfSdZyXF()
		{
			return false;
		}

		// Token: 0x04000A4C RID: 2636
		internal Vector3 $mPos$17287;

		// Token: 0x04000A4D RID: 2637
		internal Vector3 $tDir$17288;

		// Token: 0x04000A4E RID: 2638
		internal SkyBug $self_$17289;

		// Token: 0x02000200 RID: 512
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000B9F RID: 2975 RVA: 0x0012B0C8 File Offset: 0x001292C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, SkyBug self_)
			{
				if (4243 - 13674 != -9430)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (190556 - 209944 != -19387)
					{
						base..ctor();
						if (146557 - 7168 == 139389)
						{
							this.$mPos$17284 = mPos;
							if (119268 - 356510 == -237242)
							{
								this.$tDir$17285 = tDir;
								if (208163 - 525135 == -316972)
								{
									this.$self_$17286 = self_;
									if (195984 - 59276 == 136708)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000BA0 RID: 2976 RVA: 0x0012B1A4 File Offset: 0x001293A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (217263 - 326466 != -109202)
				{
				}
				for (;;)
				{
					IL_42D:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A5B;
					case 2:
						if (this.$self_$17286.mChar.actionState != "attack")
						{
							goto IL_613;
						}
						if (125482 - 161335 != -35853)
						{
							continue;
						}
						if (this.$self_$17286.mChar.myCommand != "skyWind")
						{
							if (245669 - 62756 != 182913)
							{
								continue;
							}
							goto IL_613;
						}
						else
						{
							this.$i$17275 = 0;
							if (137468 - 445331 != -307863)
							{
								continue;
							}
							goto IL_6B5;
						}
						break;
					case 3:
						if (this.$self_$17286.mChar.actionState != "attack")
						{
							goto IL_5BA;
						}
						if (209361 - 390474 == -181112)
						{
							continue;
						}
						if (this.$self_$17286.mChar.myCommand != "skyWind")
						{
							if (189698 - 108841 != 80858)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							this.$i$17275++;
							if (97251 - 565172 != -467920)
							{
								goto IL_6B5;
							}
							continue;
						}
						break;
					default:
						if (187854 - 95144 == 92711)
						{
							continue;
						}
						break;
					}
					this.$self_$17286.mChar.actionState = "attack";
					if (204583 - 229970 != -25387)
					{
						continue;
					}
					this.$self_$17286.mChar.actionTime = Time.time;
					if (32950 - 106322 != -73372)
					{
						continue;
					}
					this.$self_$17286.mChar.myCommand = "skyWind";
					if (228464 - 111798 != 116666)
					{
						continue;
					}
					this.$self_$17286.mChar.addTimeOut("nAttack", (float)6);
					if (190039 - 467635 != -277596)
					{
						continue;
					}
					this.$self_$17286.transform.position = this.$mPos$17284;
					if (101721 - 380174 == -278452)
					{
						continue;
					}
					this.$self_$17286.transform.LookAt(this.$mPos$17284 + global::Math.vFlat(this.$tDir$17285));
					if (297536 - 453706 == -156169)
					{
						continue;
					}
					this.$self_$17286.animation.Rewind();
					if (140049 - 385991 != -245942)
					{
						continue;
					}
					this.$self_$17286.animation.CrossFade("skyWind");
					if (236246 - 406120 != -169874)
					{
						continue;
					}
					this.$self_$17286.animation.wrapMode = WrapMode.Loop;
					if (156219 - 326334 != -170115)
					{
						continue;
					}
					this.$self_$17286.mChar.vMovement = this.$self_$17286.transform.forward;
					if (143133 - 322846 == -179712)
					{
						continue;
					}
					this.$self_$17286.mChar.moveSpeed = (float)0;
					if (222446 - 510658 != -288212)
					{
						continue;
					}
					goto IL_76F;
					IL_6B5:
					if (this.$i$17275 >= 32)
					{
						if (111537 - 535264 != -423726)
						{
							if (this.$self_$17286.mChar.actionState == "attack")
							{
								if (77381 - 265272 == -187890)
								{
									continue;
								}
								if (this.$self_$17286.mChar.myCommand == "skyWind")
								{
									if (215154 - 430621 != -215467)
									{
										continue;
									}
									this.$self_$17286.mChar.moveSpeed = (float)0;
									if (240596 - 417571 != -176975)
									{
										continue;
									}
									this.$self_$17286.mChar.actionState = "standby";
									if (99663 - 526940 != -427277)
									{
										continue;
									}
									this.$self_$17286.mChar.actionTime = Time.time;
									if (75237 - 176368 == -101130)
									{
										continue;
									}
									this.$self_$17286.mChar.myCommand = "none";
									if (101225 - 318864 == -217638)
									{
										continue;
									}
									if (!this.$self_$17286.mChar.isMine)
									{
										if (202062 - 570663 != -368601)
										{
											continue;
										}
										this.$self_$17286.mChar.nPosition = this.$self_$17286.transform.position;
										if (105390 - 372091 == -266700)
										{
											continue;
										}
										this.$self_$17286.mChar.oPosition = this.$self_$17286.transform.position;
										if (91859 - 225575 != -133716)
										{
											continue;
										}
										this.$self_$17286.mChar.nDirection = this.$self_$17286.transform.forward;
										if (174236 - 457788 != -283552)
										{
											continue;
										}
									}
								}
							}
							this.YieldDefault(1);
							if (209264 - 195785 != 13480)
							{
								break;
							}
						}
					}
					else
					{
						if (this.$i$17275 % 4 == 0)
						{
							if (101814 - 189266 != -87452)
							{
								continue;
							}
							if (this.$self_$17286.skyWind)
							{
								if (248172 - 319116 != -70944)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$17286.skyWind, this.$self_$17286.transform.position - (float)8 * Vector3.up, Quaternion.identity);
								if (141865 - 362469 != -220604)
								{
									continue;
								}
							}
						}
						if (!this.$self_$17286.mChar.isMine)
						{
							goto IL_388;
						}
						if (295124 - 589255 != -294130)
						{
							this.$hitPos$17276 = this.$self_$17286.transform.position - (float)8 * Vector3.up;
							if (13608 - 167680 != -154071)
							{
								this.$hitLayer$17277 = 130816 - (1 << this.$self_$17286.gameObject.layer);
								if (44346 - 470713 == -426367)
								{
									this.$hitList$17278 = Damage.RemoveDeadChar(Damage.FindAreaTarget(this.$hitPos$17276, (float)40, (float)4, this.$hitLayer$17277));
									if (28991 - 300314 == -271323)
									{
										this.$$iterator$10024$17283 = UnityRuntimeServices.GetEnumerator(this.$hitList$17278);
										if (128981 - 365963 == -236982)
										{
											while (this.$$iterator$10024$17283.MoveNext())
											{
												object obj2;
												object obj = obj2 = this.$$iterator$10024$17283.Current;
												if (!(obj is GameObject))
												{
													obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
												}
												this.$hitObject$17279 = (GameObject)obj2;
												if (199433 - 166831 == 32603)
												{
													goto IL_42D;
												}
												this.$hitChar$17280 = (CharacterControl)this.$hitObject$17279.GetComponent(typeof(CharacterControl));
												if (5298 - 506642 != -501344)
												{
													goto IL_42D;
												}
												UnityRuntimeServices.Update(this.$$iterator$10024$17283, this.$hitObject$17279);
												if (85047 - 240222 != -155175)
												{
													goto IL_42D;
												}
												this.$mForce$17281 = global::Math.vFlat(this.$hitObject$17279.transform.position - this.$hitPos$17276).normalized;
												if (156662 - 199169 != -42507)
												{
													goto IL_42D;
												}
												UnityRuntimeServices.Update(this.$$iterator$10024$17283, this.$hitObject$17279);
												if (223016 - 151796 != 71220)
												{
													goto IL_42D;
												}
												this.$mAddForce$17282 = ((Vector3.Dot(this.$self_$17286.transform.forward, this.$hitObject$17279.transform.position - this.$hitPos$17276) <= (float)0) ? (-this.$self_$17286.transform.forward) : this.$self_$17286.transform.forward);
												UnityRuntimeServices.Update(this.$$iterator$10024$17283, this.$hitObject$17279);
												if (263604 - 96143 != 167461)
												{
													goto IL_42D;
												}
												if (this.$hitChar$17280.hp > 0)
												{
													if (114546 - 21714 == 92833)
													{
														goto IL_42D;
													}
													this.$hitChar$17280.RPC_AddDamage(10, -1, 0, 0, Mathf.Clamp((float)1600 - this.$mForce$17281.sqrMagnitude / (float)1600, 0.1f, 0.4f) * (this.$mForce$17281 + this.$mAddForce$17282), this.$self_$17286.mChar.ActorNr);
													if (184736 - 12980 == 171757)
													{
														goto IL_42D;
													}
												}
											}
											if (175856 - 95789 != 80068)
											{
												goto Block_33;
											}
										}
									}
								}
							}
						}
					}
				}
				Block_15:
				goto IL_5BA;
				IL_388:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_33:
				goto IL_388;
				IL_5BA:
				IL_613:
				goto IL_A5B;
				IL_76F:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_A5B:
				return false;
			}

			// Token: 0x06000BA1 RID: 2977 RVA: 0x0012BC20 File Offset: 0x00129E20
			internal static bool X4gysWWMjcwtoTh5Nye()
			{
				return true;
			}

			// Token: 0x06000BA2 RID: 2978 RVA: 0x0012BC24 File Offset: 0x00129E24
			internal static bool iuLx7qWx4tQBhKV4GIM()
			{
				return false;
			}

			// Token: 0x04000A4F RID: 2639
			internal int $i$17275;

			// Token: 0x04000A50 RID: 2640
			internal Vector3 $hitPos$17276;

			// Token: 0x04000A51 RID: 2641
			internal int $hitLayer$17277;

			// Token: 0x04000A52 RID: 2642
			internal UnityScript.Lang.Array $hitList$17278;

			// Token: 0x04000A53 RID: 2643
			internal GameObject $hitObject$17279;

			// Token: 0x04000A54 RID: 2644
			internal CharacterControl $hitChar$17280;

			// Token: 0x04000A55 RID: 2645
			internal Vector3 $mForce$17281;

			// Token: 0x04000A56 RID: 2646
			internal Vector3 $mAddForce$17282;

			// Token: 0x04000A57 RID: 2647
			internal IEnumerator $$iterator$10024$17283;

			// Token: 0x04000A58 RID: 2648
			internal Vector3 $mPos$17284;

			// Token: 0x04000A59 RID: 2649
			internal Vector3 $tDir$17285;

			// Token: 0x04000A5A RID: 2650
			internal SkyBug $self_$17286;
		}
	}

	// Token: 0x02000201 RID: 513
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_skyBolt$17290 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000BA3 RID: 2979 RVA: 0x0012BC28 File Offset: 0x00129E28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_skyBolt$17290(Vector3 mPos, Vector3 tDir, SkyBug self_)
		{
			if (278709 - 284403 != -5693)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (285968 - 414761 != -128792)
				{
					base..ctor();
					if (227950 - 2819 != 225132)
					{
						this.$mPos$17299 = mPos;
						if (252593 - 115941 != 136653)
						{
							this.$tDir$17300 = tDir;
							if (276827 - 234402 == 42425)
							{
								this.$self_$17301 = self_;
								if (202682 - 333728 == -131046)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0012BD04 File Offset: 0x00129F04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SkyBug.$RPC_skyBolt$17290.$(this.$mPos$17299, this.$tDir$17300, this.$self_$17301);
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0012BD20 File Offset: 0x00129F20
		internal static bool W2rN1jWgeBOhStbowxO()
		{
			return true;
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x0012BD24 File Offset: 0x00129F24
		internal static bool IFnqiHWfVFRkukfp2vq()
		{
			return false;
		}

		// Token: 0x04000A5B RID: 2651
		internal Vector3 $mPos$17299;

		// Token: 0x04000A5C RID: 2652
		internal Vector3 $tDir$17300;

		// Token: 0x04000A5D RID: 2653
		internal SkyBug $self_$17301;

		// Token: 0x02000202 RID: 514
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000BA7 RID: 2983 RVA: 0x0012BD28 File Offset: 0x00129F28
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, SkyBug self_)
			{
				if (78208 - 583569 != -505360)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (81008 - 529086 != -448077)
					{
						base..ctor();
						if (157765 - 465464 == -307699)
						{
							this.$mPos$17296 = mPos;
							if (99143 - 491615 == -392472)
							{
								this.$tDir$17297 = tDir;
								if (167155 - 24643 == 142512)
								{
									this.$self_$17298 = self_;
									if (289691 - 237534 == 52157)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000BA8 RID: 2984 RVA: 0x0012BE04 File Offset: 0x0012A004
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (50647 - 195550 != -144903)
				{
				}
				for (;;)
				{
					IL_380:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_86D;
					case 2:
						if (this.$self_$17298.mChar.actionState != "attack")
						{
							goto IL_9C;
						}
						if (71660 - 415287 != -343627)
						{
							continue;
						}
						if (this.$self_$17298.mChar.myCommand != "skyBolt")
						{
							if (222821 - 414347 != -191525)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							if (!this.$self_$17298.mChar.isMine)
							{
								goto IL_64D;
							}
							if (291486 - 240832 != 50654)
							{
								continue;
							}
							this.$hitLayer$17291 = 130816 - (1 << this.$self_$17298.gameObject.layer);
							if (152738 - 357736 != -204998)
							{
								continue;
							}
							this.$hitList$17292 = Damage.RemoveDeadChar(Damage.FindAreaTarget(this.$self_$17298.transform.position - Vector3.up * (float)8, (float)80, (float)10, this.$hitLayer$17291));
							if (291186 - 477047 != -185861)
							{
								continue;
							}
							this.$i$17293 = 0;
							if (96349 - 297336 == -200986)
							{
								continue;
							}
							while (this.$i$17293 < 4)
							{
								if (this.$hitList$17292.length > 0)
								{
									if (71375 - 489028 != -417653)
									{
										goto IL_380;
									}
									this.$hitID$17294 = UnityEngine.Random.Range(0, this.$hitList$17292.length);
									if (172968 - 559012 == -386043)
									{
										goto IL_380;
									}
									object obj2;
									object obj = obj2 = this.$hitList$17292[this.$hitID$17294];
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$17295 = (GameObject)obj2;
									if (140892 - 90466 == 50427)
									{
										goto IL_380;
									}
									this.$hitList$17292.RemoveAt(this.$hitID$17294);
									if (41518 - 318840 != -277322)
									{
										goto IL_380;
									}
									if (this.$hitObject$17295)
									{
										if (277274 - 375630 == -98355)
										{
											goto IL_380;
										}
										if (this.$self_$17298.mHeadChar.hit(30, this.$hitObject$17295, this.$self_$17298.mHeadChar.talAdjust(60), 1, 0, Vector3.zero) != 0)
										{
											if (187176 - 412151 == -224974)
											{
												goto IL_380;
											}
											this.$self_$17298.RPC_skyBolt_hit(this.$hitObject$17295.transform.position, this.$self_$17298.transform.forward, 0);
											if (203667 - 584885 == -381217)
											{
												goto IL_380;
											}
											if (PhotonClient.IsInitialized())
											{
												if (28561 - 552104 != -523543)
												{
													goto IL_380;
												}
												this.$self_$17298.ActionEvent("RPC_skyBolt_hit", this.$hitObject$17295.transform.position, this.$self_$17298.transform.forward, 0);
												if (164888 - 258199 == -93310)
												{
													goto IL_380;
												}
											}
										}
									}
								}
								this.$i$17293++;
								if (130401 - 153458 == -23056)
								{
									goto IL_380;
								}
							}
							if (163451 - 491192 != -327740)
							{
								goto Block_34;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17298.mChar.actionState == "attack")
						{
							if (25315 - 174457 == -149141)
							{
								continue;
							}
							if (this.$self_$17298.mChar.myCommand == "skyBolt")
							{
								if (183675 - 208652 == -24976)
								{
									continue;
								}
								this.$self_$17298.mChar.moveSpeed = (float)0;
								if (137724 - 23726 == 113999)
								{
									continue;
								}
								this.$self_$17298.mChar.actionState = "standby";
								if (135559 - 122245 == 13315)
								{
									continue;
								}
								this.$self_$17298.mChar.actionTime = Time.time;
								if (217337 - 377942 != -160605)
								{
									continue;
								}
								this.$self_$17298.mChar.myCommand = "none";
								if (243572 - 464145 != -220573)
								{
									continue;
								}
								if (!this.$self_$17298.mChar.isMine)
								{
									if (107228 - 217313 == -110084)
									{
										continue;
									}
									this.$self_$17298.mChar.nPosition = this.$self_$17298.transform.position;
									if (255332 - 301344 != -46012)
									{
										continue;
									}
									this.$self_$17298.mChar.oPosition = this.$self_$17298.transform.position;
									if (58253 - 583188 == -524934)
									{
										continue;
									}
									this.$self_$17298.mChar.nDirection = this.$self_$17298.transform.forward;
									if (140724 - 541979 != -401255)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (13358 - 515673 != -502315)
						{
							continue;
						}
						goto IL_86D;
					default:
						if (242762 - 85484 != 157278)
						{
							continue;
						}
						break;
					}
					this.$self_$17298.mChar.actionState = "attack";
					if (178381 - 51249 != 127133)
					{
						this.$self_$17298.mChar.actionTime = Time.time;
						if (35562 - 168724 == -133162)
						{
							this.$self_$17298.mChar.myCommand = "skyBolt";
							if (172233 - 169590 == 2643)
							{
								this.$self_$17298.mChar.addTimeOut("skyBolt", (float)12);
								if (80975 - 74424 == 6551)
								{
									this.$self_$17298.transform.position = this.$mPos$17296;
									if (201097 - 87628 == 113469)
									{
										this.$self_$17298.transform.LookAt(this.$mPos$17296 + global::Math.vFlat(this.$tDir$17297));
										if (298334 - 303509 != -5174)
										{
											this.$self_$17298.animation.Rewind();
											if (18910 - 184050 == -165140)
											{
												this.$self_$17298.animation.CrossFade("cast");
												if (123158 - 225127 != -101968)
												{
													this.$self_$17298.animation.wrapMode = WrapMode.Once;
													if (284633 - 208302 != 76332)
													{
														this.$self_$17298.mChar.vMovement = this.$self_$17298.transform.forward;
														if (102245 - 443912 != -341666)
														{
															this.$self_$17298.mChar.moveSpeed = (float)0;
															if (289230 - 220807 == 68423)
															{
																goto IL_7C6;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_9C:
				goto IL_86D;
				Block_25:
				goto IL_9C;
				Block_34:
				IL_64D:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_7C6:
				return this.Yield(2, new WaitForSeconds(0.9f));
				IL_86D:
				return false;
			}

			// Token: 0x06000BA9 RID: 2985 RVA: 0x0012C690 File Offset: 0x0012A890
			internal static bool XiLmnRWnjyha1k6mG1O()
			{
				return true;
			}

			// Token: 0x06000BAA RID: 2986 RVA: 0x0012C694 File Offset: 0x0012A894
			internal static bool Bf4niAW6QKdB7SjhugG()
			{
				return false;
			}

			// Token: 0x04000A5E RID: 2654
			internal int $hitLayer$17291;

			// Token: 0x04000A5F RID: 2655
			internal UnityScript.Lang.Array $hitList$17292;

			// Token: 0x04000A60 RID: 2656
			internal int $i$17293;

			// Token: 0x04000A61 RID: 2657
			internal int $hitID$17294;

			// Token: 0x04000A62 RID: 2658
			internal GameObject $hitObject$17295;

			// Token: 0x04000A63 RID: 2659
			internal Vector3 $mPos$17296;

			// Token: 0x04000A64 RID: 2660
			internal Vector3 $tDir$17297;

			// Token: 0x04000A65 RID: 2661
			internal SkyBug $self_$17298;
		}
	}

	// Token: 0x02000203 RID: 515
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_skyOrb$17302 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000BAB RID: 2987 RVA: 0x0012C698 File Offset: 0x0012A898
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_skyOrb$17302(Vector3 mPos, Vector3 tDir, int tID, SkyBug self_)
		{
			if (283462 - 488338 != -204876)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (75736 - 400518 == -324782)
				{
					base..ctor();
					if (49919 - 255548 == -205629)
					{
						this.$mPos$17309 = mPos;
						if (191161 - 150136 == 41025)
						{
							this.$tDir$17310 = tDir;
							if (230890 - 356441 != -125550)
							{
								this.$tID$17311 = tID;
								if (182928 - 261953 == -79025)
								{
									this.$self_$17312 = self_;
									if (281149 - 434086 != -152936)
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

		// Token: 0x06000BAC RID: 2988 RVA: 0x0012C798 File Offset: 0x0012A998
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SkyBug.$RPC_skyOrb$17302.$(this.$mPos$17309, this.$tDir$17310, this.$tID$17311, this.$self_$17312);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0012C7B8 File Offset: 0x0012A9B8
		internal static bool lu5qg3WiSCisjuNnnRv()
		{
			return true;
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x0012C7BC File Offset: 0x0012A9BC
		internal static bool k8HaBDWKal4IKlbsrYi()
		{
			return false;
		}

		// Token: 0x04000A66 RID: 2662
		internal Vector3 $mPos$17309;

		// Token: 0x04000A67 RID: 2663
		internal Vector3 $tDir$17310;

		// Token: 0x04000A68 RID: 2664
		internal int $tID$17311;

		// Token: 0x04000A69 RID: 2665
		internal SkyBug $self_$17312;

		// Token: 0x02000204 RID: 516
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000BAF RID: 2991 RVA: 0x0012C7C0 File Offset: 0x0012A9C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, SkyBug self_)
			{
				if (254772 - 121686 != 133087)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (57151 - 505417 != -448265)
					{
						base..ctor();
						if (233842 - 523566 == -289724)
						{
							this.$mPos$17305 = mPos;
							if (72207 - 391038 != -318830)
							{
								this.$tDir$17306 = tDir;
								if (11531 - 511301 != -499769)
								{
									this.$tID$17307 = tID;
									if (123359 - 507198 == -383839)
									{
										this.$self_$17308 = self_;
										if (82817 - 29335 != 53483)
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

			// Token: 0x06000BB0 RID: 2992 RVA: 0x0012C8C0 File Offset: 0x0012AAC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (253945 - 131978 != 121968)
				{
				}
				for (;;)
				{
					IL_49A:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6EF;
					case 2:
						if (this.$self_$17308.mChar.actionState != "attack")
						{
							goto IL_4CF;
						}
						if (79142 - 364029 != -284887)
						{
							continue;
						}
						if (this.$self_$17308.mChar.myCommand != "skyOrb")
						{
							if (234876 - 480466 != -245590)
							{
								continue;
							}
							goto IL_4CF;
						}
						else
						{
							if (!this.$self_$17308.mChar.isMine)
							{
								goto IL_423;
							}
							if (8152 - 381331 != -373179)
							{
								continue;
							}
							this.$i$17303 = 0;
							if (120242 - 464447 != -344205)
							{
								continue;
							}
							while (this.$i$17303 < 6)
							{
								this.$firePos$17304 = this.$self_$17308.transform.position + global::Math.rotateH(new Vector3((float)0, UnityEngine.Random.Range((float)0, 0.5f) - (float)8, (float)UnityEngine.Random.Range(8, 36)), (float)(this.$i$17303 * 60 + UnityEngine.Random.Range(0, 60)));
								if (267183 - 223081 != 44102)
								{
									goto IL_49A;
								}
								this.$self_$17308.RPC_skyOrb_fire(this.$firePos$17304, this.$self_$17308.transform.forward, this.$tID$17307);
								if (165422 - 352378 != -186956)
								{
									goto IL_49A;
								}
								if (PhotonClient.IsInitialized())
								{
									if (97989 - 353980 != -255991)
									{
										goto IL_49A;
									}
									this.$self_$17308.ActionEvent("RPC_skyOrb_fire", this.$firePos$17304, this.$self_$17308.transform.forward, this.$tID$17307);
									if (271099 - 160970 != 110129)
									{
										goto IL_49A;
									}
								}
								this.$i$17303++;
								if (202838 - 597755 != -394917)
								{
									goto IL_49A;
								}
							}
							if (123596 - 262846 != -139250)
							{
								continue;
							}
							goto IL_423;
						}
						break;
					case 3:
						if (this.$self_$17308.mChar.actionState == "attack")
						{
							if (281685 - 210436 != 71249)
							{
								continue;
							}
							if (this.$self_$17308.mChar.myCommand == "skyOrb")
							{
								if (111913 - 202771 == -90857)
								{
									continue;
								}
								this.$self_$17308.mChar.moveSpeed = (float)0;
								if (108465 - 595048 == -486582)
								{
									continue;
								}
								this.$self_$17308.mChar.actionState = "standby";
								if (137099 - 219701 != -82602)
								{
									continue;
								}
								this.$self_$17308.mChar.actionTime = Time.time;
								if (60295 - 393962 != -333667)
								{
									continue;
								}
								this.$self_$17308.mChar.myCommand = "none";
								if (46345 - 319733 == -273387)
								{
									continue;
								}
								if (!this.$self_$17308.mChar.isMine)
								{
									if (169634 - 499478 != -329844)
									{
										continue;
									}
									this.$self_$17308.mChar.nPosition = this.$self_$17308.transform.position;
									if (69204 - 384364 == -315159)
									{
										continue;
									}
									this.$self_$17308.mChar.oPosition = this.$self_$17308.transform.position;
									if (201987 - 583119 != -381132)
									{
										continue;
									}
									this.$self_$17308.mChar.nDirection = this.$self_$17308.transform.forward;
									if (173153 - 506995 != -333842)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (165166 - 41341 != 123826)
						{
							goto Block_8;
						}
						continue;
					default:
						if (223242 - 592430 == -369187)
						{
							continue;
						}
						break;
					}
					this.$self_$17308.mChar.actionState = "attack";
					if (40268 - 368833 == -328565)
					{
						this.$self_$17308.mChar.actionTime = Time.time;
						if (58947 - 578892 != -519944)
						{
							this.$self_$17308.mChar.myCommand = "skyOrb";
							if (258478 - 312988 == -54510)
							{
								this.$self_$17308.mChar.addTimeOut("skyOrb", (float)30);
								if (155674 - 497264 == -341590)
								{
									this.$self_$17308.transform.position = this.$mPos$17305;
									if (38411 - 58715 != -20303)
									{
										this.$self_$17308.transform.LookAt(this.$mPos$17305 + global::Math.vFlat(this.$tDir$17306));
										if (212475 - 405872 == -193397)
										{
											this.$self_$17308.animation.Rewind();
											if (289599 - 457347 == -167748)
											{
												this.$self_$17308.animation.CrossFade("cast");
												if (260869 - 98032 != 162838)
												{
													this.$self_$17308.animation.wrapMode = WrapMode.Once;
													if (140420 - 279943 == -139523)
													{
														this.$self_$17308.mChar.vMovement = this.$self_$17308.transform.forward;
														if (171397 - 292352 == -120955)
														{
															this.$self_$17308.mChar.moveSpeed = (float)0;
															if (238633 - 174413 == 64220)
															{
																goto IL_268;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_8:
				goto IL_6EF;
				IL_268:
				return this.Yield(2, new WaitForSeconds(0.9f));
				IL_423:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_4CF:
				IL_6EF:
				return false;
			}

			// Token: 0x06000BB1 RID: 2993 RVA: 0x0012CFD0 File Offset: 0x0012B1D0
			internal static bool YadgnWWdbbtEBl7Hd6E()
			{
				return true;
			}

			// Token: 0x06000BB2 RID: 2994 RVA: 0x0012CFD4 File Offset: 0x0012B1D4
			internal static bool kWfX6gWJ1CBdX2ydtXc()
			{
				return false;
			}

			// Token: 0x04000A6A RID: 2666
			internal int $i$17303;

			// Token: 0x04000A6B RID: 2667
			internal Vector3 $firePos$17304;

			// Token: 0x04000A6C RID: 2668
			internal Vector3 $mPos$17305;

			// Token: 0x04000A6D RID: 2669
			internal Vector3 $tDir$17306;

			// Token: 0x04000A6E RID: 2670
			internal int $tID$17307;

			// Token: 0x04000A6F RID: 2671
			internal SkyBug $self_$17308;
		}
	}

	// Token: 0x02000205 RID: 517
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_skyHigh$17313 : GenericGenerator<YieldInstruction>
	{
		// Token: 0x06000BB3 RID: 2995 RVA: 0x0012CFD8 File Offset: 0x0012B1D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_skyHigh$17313(Vector3 mPos, Vector3 tDir, SkyBug self_)
		{
			if (80769 - 477045 != -396276)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (106134 - 293709 != -187574)
				{
					base..ctor();
					if (292693 - 94747 == 197946)
					{
						this.$mPos$17326 = mPos;
						if (71260 - 515002 == -443742)
						{
							this.$tDir$17327 = tDir;
							if (25288 - 190541 == -165253)
							{
								this.$self_$17328 = self_;
								if (201001 - 65638 != 135364)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x0012D0B4 File Offset: 0x0012B2B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return new SkyBug.$RPC_skyHigh$17313.$(this.$mPos$17326, this.$tDir$17327, this.$self_$17328);
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x0012D0D0 File Offset: 0x0012B2D0
		internal static bool snEtUrWD4bfkIusxiwj()
		{
			return true;
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x0012D0D4 File Offset: 0x0012B2D4
		internal static bool FaaURVWvL8nDV7ER7dN()
		{
			return false;
		}

		// Token: 0x04000A70 RID: 2672
		internal Vector3 $mPos$17326;

		// Token: 0x04000A71 RID: 2673
		internal Vector3 $tDir$17327;

		// Token: 0x04000A72 RID: 2674
		internal SkyBug $self_$17328;

		// Token: 0x02000206 RID: 518
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			// Token: 0x06000BB7 RID: 2999 RVA: 0x0012D0D8 File Offset: 0x0012B2D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, SkyBug self_)
			{
				if (103474 - 301714 != -198240)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (117503 - 221314 != -103810)
					{
						base..ctor();
						if (230240 - 319973 != -89732)
						{
							this.$mPos$17323 = mPos;
							if (49473 - 100073 == -50600)
							{
								this.$tDir$17324 = tDir;
								if (56815 - 391787 == -334972)
								{
									this.$self_$17325 = self_;
									if (10126 - 533994 != -523867)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000BB8 RID: 3000 RVA: 0x0012D1B4 File Offset: 0x0012B3B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (149322 - 582839 != -433516)
				{
				}
				for (;;)
				{
					IL_CE9:
					switch (this._state)
					{
					case 0:
						goto IL_73A;
					case 1:
						goto IL_12AB;
					case 2:
						if (this.$self_$17325.mChar.actionState != "attack")
						{
							goto IL_522;
						}
						if (288252 - 328842 == -40589)
						{
							continue;
						}
						if (this.$self_$17325.mChar.myCommand != "skyHigh")
						{
							if (64613 - 33922 != 30691)
							{
								continue;
							}
							goto IL_522;
						}
						else
						{
							if (!this.$self_$17325.skyWind)
							{
								goto IL_1014;
							}
							if (269148 - 475189 != -206041)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$17325.skyWind, this.$self_$17325.transform.position - (float)8 * Vector3.up + (float)2 * this.$self_$17325.transform.forward, Quaternion.identity);
							if (188698 - 90643 != 98056)
							{
								goto Block_84;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17325.mChar.actionState != "attack")
						{
							goto IL_1063;
						}
						if (33553 - 342670 == -309116)
						{
							continue;
						}
						if (this.$self_$17325.mChar.myCommand != "skyHigh")
						{
							if (98643 - 168625 != -69982)
							{
								continue;
							}
							goto IL_1063;
						}
						else
						{
							this.$self_$17325.animation.Play("fly");
							if (16800 - 117214 == -100413)
							{
								continue;
							}
							this.$self_$17325.animation.wrapMode = WrapMode.Loop;
							if (213633 - 19062 != 194571)
							{
								continue;
							}
							this.$self_$17325.transform.rotation = Quaternion.LookRotation(this.$tDir$17324);
							if (118672 - 422297 == -303624)
							{
								continue;
							}
							this.$hitLayer$17314 = 130816 - (1 << this.$self_$17325.gameObject.layer);
							if (269570 - 391537 != -121967)
							{
								continue;
							}
							this.$hitList$17315 = null;
							if (108246 - 598390 == -490143)
							{
								continue;
							}
							this.$hitCount$17316 = 0;
							if (50383 - 304070 == -253686)
							{
								continue;
							}
							this.$hitTimer$17317 = 3;
							if (125276 - 418879 != -293603)
							{
								continue;
							}
						}
						break;
					case 4:
						break;
					case 5:
						goto IL_B34;
					case 6:
						if (this.$self_$17325.mChar.actionState != "attack")
						{
							goto IL_9F5;
						}
						if (221410 - 476079 != -254669)
						{
							continue;
						}
						if (this.$self_$17325.mChar.myCommand != "skyHigh")
						{
							if (254310 - 63317 != 190994)
							{
								goto IL_9F5;
							}
							continue;
						}
						else
						{
							if (!this.$self_$17325.skyWind)
							{
								goto IL_AD4;
							}
							if (78445 - 307418 != -228973)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$17325.skyWind, this.$self_$17325.transform.position - (float)8 * Vector3.up + (float)2 * this.$self_$17325.transform.forward, Quaternion.identity);
							if (151083 - 166833 != -15750)
							{
								continue;
							}
							goto IL_AD4;
						}
						break;
					case 7:
						if (this.$self_$17325.mChar.actionState == "attack")
						{
							if (255530 - 149450 != 106080)
							{
								continue;
							}
							if (this.$self_$17325.mChar.myCommand == "skyHigh")
							{
								if (218710 - 25610 == 193101)
								{
									continue;
								}
								this.$self_$17325.mChar.moveSpeed = (float)0;
								if (70224 - 341402 == -271177)
								{
									continue;
								}
								this.$self_$17325.mChar.actionState = "standby";
								if (4227 - 217850 != -213623)
								{
									continue;
								}
								this.$self_$17325.mChar.actionTime = Time.time;
								if (236182 - 53923 != 182259)
								{
									continue;
								}
								this.$self_$17325.mChar.myCommand = "none";
								if (267140 - 291663 != -24523)
								{
									continue;
								}
								if (!this.$self_$17325.mChar.isMine)
								{
									if (27791 - 210574 == -182782)
									{
										continue;
									}
									this.$self_$17325.mChar.nPosition = this.$self_$17325.transform.position;
									if (50849 - 309979 != -259130)
									{
										continue;
									}
									this.$self_$17325.mChar.oPosition = this.$self_$17325.transform.position;
									if (165025 - 316803 == -151777)
									{
										continue;
									}
									this.$self_$17325.mChar.nDirection = this.$self_$17325.transform.forward;
									if (214669 - 397471 == -182801)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (216740 - 279759 != -63018)
						{
							goto Block_62;
						}
						continue;
					default:
						if (57120 - 108718 != -51597)
						{
							goto IL_73A;
						}
						continue;
					}
					if (Time.time - this.$self_$17325.mChar.actionTime >= (float)30)
					{
						if (192852 - 530593 == -337740)
						{
							continue;
						}
						this.$tDir2$17320 = global::Math.rotateH(this.$tDir$17324, (float)120);
						if (126601 - 153329 != -26728)
						{
							continue;
						}
						this.$self_$17325.transform.rotation = Quaternion.LookRotation(this.$tDir2$17320);
						if (145345 - 193276 != -47931)
						{
							continue;
						}
						goto IL_B34;
					}
					else
					{
						this.$self_$17325.transform.position = this.$mPos$17323 + Mathf.Lerp((float)-240, (float)240, (Time.time - this.$self_$17325.mChar.actionTime) / (float)30) * this.$tDir$17324;
						if (244461 - 306761 != -62300)
						{
							continue;
						}
						if (Time.time - this.$self_$17325.mChar.actionTime <= (float)this.$hitTimer$17317)
						{
							break;
						}
						if (18496 - 10804 != 7692)
						{
							continue;
						}
						this.$hitCount$17316 = 0;
						if (149420 - 123329 != 26091)
						{
							continue;
						}
						if (this.$self_$17325.mChar.isMine)
						{
							if (62472 - 151060 != -88588)
							{
								continue;
							}
							this.$hitList$17315 = Damage.RemoveDeadChar(Damage.FindRecTarget(this.$self_$17325.transform.position + this.$self_$17325.transform.TransformDirection((float)0, (float)-8, (float)6), -this.$self_$17325.transform.forward, (float)12, (float)10, (float)24, (float)5, this.$hitLayer$17314));
							if (42146 - 253636 != -211490)
							{
								continue;
							}
							this.$$iterator$10025$17319 = UnityRuntimeServices.GetEnumerator(this.$hitList$17315);
							if (120648 - 590980 != -470332)
							{
								continue;
							}
							while (this.$$iterator$10025$17319.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10025$17319.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17318 = (GameObject)obj2;
								if (184322 - 214114 == -29791)
								{
									goto IL_CE9;
								}
								if (this.$hitCount$17316 < 6)
								{
									if (180494 - 173012 != 7482)
									{
										goto IL_CE9;
									}
									if (this.$self_$17325.mHeadChar.hit(30, this.$hitObject$17318, this.$self_$17325.mHeadChar.talAdjust(90), 1, 0, Vector3.zero) != 0)
									{
										if (84924 - 599911 != -514987)
										{
											goto IL_CE9;
										}
										this.$self_$17325.RPC_skyBolt_hit(this.$hitObject$17318.transform.position, this.$self_$17325.transform.forward, 0);
										if (130672 - 540423 == -409750)
										{
											goto IL_CE9;
										}
										UnityRuntimeServices.Update(this.$$iterator$10025$17319, this.$hitObject$17318);
										if (90342 - 107214 != -16872)
										{
											goto IL_CE9;
										}
										this.$self_$17325.ActionEvent("RPC_skyBolt_hit", this.$hitObject$17318.transform.position, this.$self_$17325.transform.forward, 0);
										if (43670 - 498934 == -455263)
										{
											goto IL_CE9;
										}
										UnityRuntimeServices.Update(this.$$iterator$10025$17319, this.$hitObject$17318);
										if (78814 - 285396 == -206581)
										{
											goto IL_CE9;
										}
										this.$hitCount$17316++;
										if (194454 - 554889 != -360435)
										{
											goto IL_CE9;
										}
									}
								}
							}
							if (251084 - 20838 != 230246)
							{
								continue;
							}
						}
						this.$hitTimer$17317++;
						if (162568 - 178267 != -15699)
						{
							continue;
						}
						break;
					}
					IL_73A:
					this.$self_$17325.mChar.actionState = "attack";
					if (28079 - 505545 != -477466)
					{
						continue;
					}
					this.$self_$17325.mChar.actionTime = Time.time;
					if (194023 - 6440 != 187583)
					{
						continue;
					}
					this.$self_$17325.mChar.myCommand = "skyHigh";
					if (17889 - 84015 == -66125)
					{
						continue;
					}
					this.$self_$17325.mChar.addTimeOut("skyHigh", (float)180);
					if (63383 - 57814 != 5569)
					{
						continue;
					}
					this.$self_$17325.transform.position = this.$mPos$17323;
					if (145307 - 598654 != -453347)
					{
						continue;
					}
					this.$self_$17325.transform.LookAt(this.$mPos$17323 + global::Math.vFlat(this.$tDir$17324));
					if (49918 - 391484 != -341566)
					{
						continue;
					}
					this.$self_$17325.animation.Rewind();
					if (11874 - 541039 == -529164)
					{
						continue;
					}
					this.$self_$17325.animation.CrossFade("flyUp");
					if (174790 - 334075 == -159284)
					{
						continue;
					}
					this.$self_$17325.animation.wrapMode = WrapMode.Once;
					if (40406 - 324656 != -284250)
					{
						continue;
					}
					this.$self_$17325.mChar.vMovement = this.$self_$17325.transform.forward;
					if (64534 - 457026 == -392491)
					{
						continue;
					}
					this.$self_$17325.mChar.moveSpeed = (float)0;
					if (268302 - 220662 != 47641)
					{
						goto Block_40;
					}
					continue;
					IL_B34:
					if (Time.time - this.$self_$17325.mChar.actionTime >= (float)60)
					{
						if (133495 - 429043 != -295547)
						{
							this.$self_$17325.transform.position = this.$mPos$17323;
							if (111480 - 288077 == -176597)
							{
								this.$self_$17325.transform.LookAt(this.$mPos$17323 + global::Math.vFlat(this.$tDir$17324));
								if (79197 - 47769 == 31428)
								{
									this.$self_$17325.animation.Rewind();
									if (90315 - 390182 != -299866)
									{
										this.$self_$17325.animation.Play("flyDown");
										if (265581 - 82200 == 183381)
										{
											this.$self_$17325.animation.wrapMode = WrapMode.Once;
											if (245040 - 137081 != 107960)
											{
												this.$self_$17325.mChar.vMovement = this.$self_$17325.transform.forward;
												if (298846 - 525603 == -226757)
												{
													this.$self_$17325.mChar.moveSpeed = (float)0;
													if (294514 - 63536 != 230979)
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
					else
					{
						this.$self_$17325.transform.position = this.$mPos$17323 + Mathf.Lerp((float)-240, (float)240, (Time.time - this.$self_$17325.mChar.actionTime - (float)30) / (float)30) * this.$tDir2$17320;
						if (209148 - 578990 != -369841)
						{
							if (!this.$self_$17325.mChar.isMine)
							{
								goto IL_B23;
							}
							if (248832 - 404151 != -155318)
							{
								if (Time.time - this.$self_$17325.mChar.actionTime <= (float)this.$hitTimer$17317)
								{
									goto IL_B23;
								}
								if (213117 - 495628 != -282510)
								{
									this.$hitList$17315 = Damage.RemoveDeadChar(Damage.FindRecTarget(this.$self_$17325.transform.position + this.$self_$17325.transform.TransformDirection((float)0, (float)-8, (float)6), -this.$self_$17325.transform.forward, (float)12, (float)10, (float)24, (float)5, this.$hitLayer$17314));
									if (215220 - 530626 == -315406)
									{
										this.$hitCount$17316 = 0;
										if (274376 - 225047 == 49329)
										{
											this.$$iterator$10026$17322 = UnityRuntimeServices.GetEnumerator(this.$hitList$17315);
											if (193303 - 219076 == -25773)
											{
												while (this.$$iterator$10026$17322.MoveNext())
												{
													object obj4;
													object obj3 = obj4 = this.$$iterator$10026$17322.Current;
													if (!(obj3 is GameObject))
													{
														obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
													}
													this.$hitObject$17321 = (GameObject)obj4;
													if (243526 - 575976 == -332449)
													{
														goto IL_CE9;
													}
													if (this.$hitCount$17316 < 6)
													{
														if (47649 - 372996 == -325346)
														{
															goto IL_CE9;
														}
														if (this.$self_$17325.mHeadChar.hit(30, this.$hitObject$17321, this.$self_$17325.mHeadChar.talAdjust(60), 1, 0, Vector3.zero) != 0)
														{
															if (264239 - 306887 != -42648)
															{
																goto IL_CE9;
															}
															this.$self_$17325.RPC_skyBolt_hit(this.$hitObject$17321.transform.position, this.$self_$17325.transform.forward, 0);
															if (176964 - 354121 == -177156)
															{
																goto IL_CE9;
															}
															UnityRuntimeServices.Update(this.$$iterator$10026$17322, this.$hitObject$17321);
															if (295325 - 282958 != 12367)
															{
																goto IL_CE9;
															}
															this.$self_$17325.ActionEvent("RPC_skyBolt_hit", this.$hitObject$17321.transform.position, this.$self_$17325.transform.forward, 0);
															if (46115 - 479302 == -433186)
															{
																goto IL_CE9;
															}
															UnityRuntimeServices.Update(this.$$iterator$10026$17322, this.$hitObject$17321);
															if (58632 - 463095 == -404462)
															{
																goto IL_CE9;
															}
															this.$hitCount$17316++;
															if (86780 - 143948 == -57167)
															{
																goto IL_CE9;
															}
														}
													}
												}
												if (193867 - 310314 != -116446)
												{
													this.$hitTimer$17317++;
													if (22240 - 454251 == -432011)
													{
														goto IL_B23;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(4, new WaitForFixedUpdate());
				IL_522:
				goto IL_12AB;
				Block_38:
				return this.Yield(6, new WaitForSeconds(1.2f));
				Block_40:
				return this.Yield(2, new WaitForSeconds(0.8f));
				IL_9F5:
				Block_62:
				goto IL_12AB;
				IL_AD4:
				return this.Yield(7, new WaitForSeconds(0.3f));
				IL_B23:
				return this.Yield(5, new WaitForFixedUpdate());
				Block_84:
				IL_1014:
				return this.Yield(3, new WaitForSeconds(1.6f));
				IL_1063:
				IL_12AB:
				return false;
			}

			// Token: 0x06000BB9 RID: 3001 RVA: 0x0012E480 File Offset: 0x0012C680
			internal static bool LOvoesWRnxoKHQbjbqN()
			{
				return true;
			}

			// Token: 0x06000BBA RID: 3002 RVA: 0x0012E484 File Offset: 0x0012C684
			internal static bool TDW4ktWwHBLmxfsKfoW()
			{
				return false;
			}

			// Token: 0x04000A73 RID: 2675
			internal int $hitLayer$17314;

			// Token: 0x04000A74 RID: 2676
			internal UnityScript.Lang.Array $hitList$17315;

			// Token: 0x04000A75 RID: 2677
			internal int $hitCount$17316;

			// Token: 0x04000A76 RID: 2678
			internal int $hitTimer$17317;

			// Token: 0x04000A77 RID: 2679
			internal GameObject $hitObject$17318;

			// Token: 0x04000A78 RID: 2680
			internal IEnumerator $$iterator$10025$17319;

			// Token: 0x04000A79 RID: 2681
			internal Vector3 $tDir2$17320;

			// Token: 0x04000A7A RID: 2682
			internal GameObject $hitObject$17321;

			// Token: 0x04000A7B RID: 2683
			internal IEnumerator $$iterator$10026$17322;

			// Token: 0x04000A7C RID: 2684
			internal Vector3 $mPos$17323;

			// Token: 0x04000A7D RID: 2685
			internal Vector3 $tDir$17324;

			// Token: 0x04000A7E RID: 2686
			internal SkyBug $self_$17325;
		}
	}

	// Token: 0x02000207 RID: 519
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_perfectStorm$17329 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000BBB RID: 3003 RVA: 0x0012E488 File Offset: 0x0012C688
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_perfectStorm$17329(Vector3 mPos, Vector3 tDir, SkyBug self_)
		{
			if (86749 - 271702 != -184953)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (199651 - 501560 != -301908)
				{
					base..ctor();
					if (75638 - 58608 == 17030)
					{
						this.$mPos$17339 = mPos;
						if (49137 - 122713 != -73575)
						{
							this.$tDir$17340 = tDir;
							if (254750 - 308854 != -54103)
							{
								this.$self_$17341 = self_;
								if (209021 - 293160 != -84138)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x0012E564 File Offset: 0x0012C764
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SkyBug.$RPC_perfectStorm$17329.$(this.$mPos$17339, this.$tDir$17340, this.$self_$17341);
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x0012E580 File Offset: 0x0012C780
		internal static bool RGCQ3AWqxUSAi1smiss()
		{
			return true;
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x0012E584 File Offset: 0x0012C784
		internal static bool J5ke7NW7NEmXjDofOW1()
		{
			return false;
		}

		// Token: 0x04000A7F RID: 2687
		internal Vector3 $mPos$17339;

		// Token: 0x04000A80 RID: 2688
		internal Vector3 $tDir$17340;

		// Token: 0x04000A81 RID: 2689
		internal SkyBug $self_$17341;

		// Token: 0x02000208 RID: 520
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000BBF RID: 3007 RVA: 0x0012E588 File Offset: 0x0012C788
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, SkyBug self_)
			{
				if (118130 - 169490 != -51359)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (72727 - 121981 == -49254)
					{
						base..ctor();
						if (155362 - 465547 == -310185)
						{
							this.$mPos$17336 = mPos;
							if (48323 - 127250 == -78927)
							{
								this.$tDir$17337 = tDir;
								if (151525 - 173988 == -22463)
								{
									this.$self_$17338 = self_;
									if (277223 - 10122 != 267102)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000BC0 RID: 3008 RVA: 0x0012E664 File Offset: 0x0012C864
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (91803 - 105105 != -13301)
				{
				}
				for (;;)
				{
					IL_3FF:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_773;
					case 2:
						if (this.$self_$17338.mChar.actionState != "attack")
						{
							goto IL_118;
						}
						if (293555 - 317129 != -23574)
						{
							continue;
						}
						if (this.$self_$17338.mChar.myCommand != "perfectStorm")
						{
							if (63042 - 484204 != -421162)
							{
								continue;
							}
							goto IL_118;
						}
						else if (this.$self_$17338.perfectStorm)
						{
							if (171098 - 582488 == -411389)
							{
								continue;
							}
							this.$mPerfectStorm$17330 = this.$self_$17338.mChar.createEffect(this.$self_$17338.perfectStorm, this.$self_$17338.transform.position - (float)8 * Vector3.up, this.$self_$17338.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
							if (27525 - 332578 != -305053)
							{
								continue;
							}
							if (!this.$mPerfectStorm$17330)
							{
								goto IL_B5;
							}
							if (294658 - 12163 == 282496)
							{
								continue;
							}
							this.$mPerfectStormScriptList$17331 = this.$mPerfectStorm$17330.GetComponentsInChildren(typeof(SkyBug_perfectStorm));
							if (44740 - 198490 != -153750)
							{
								continue;
							}
							this.$$11032$17333 = 0;
							if (244511 - 361993 != -117482)
							{
								continue;
							}
							this.$$11033$17334 = this.$mPerfectStormScriptList$17331;
							if (38807 - 457422 == -418614)
							{
								continue;
							}
							this.$$11034$17335 = this.$$11033$17334.Length;
							if (286210 - 133117 != 153093)
							{
								continue;
							}
							while (this.$$11032$17333 < this.$$11034$17335)
							{
								((SkyBug_perfectStorm)this.$$11033$17334[this.$$11032$17333]).Init(this.$self_$17338.gameObject);
								if (152905 - 400119 != -247214)
								{
									goto IL_3FF;
								}
								this.$$11032$17333++;
								if (147745 - 98500 != 49245)
								{
									goto IL_3FF;
								}
							}
							if (128165 - 335316 != -207150)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							Debug.LogError("Missing perfectStorm effect");
							if (234627 - 203285 != 31342)
							{
								continue;
							}
							goto IL_702;
						}
						break;
					case 3:
						if (this.$self_$17338.mChar.actionState == "attack")
						{
							if (5126 - 276524 == -271397)
							{
								continue;
							}
							if (this.$self_$17338.mChar.myCommand == "perfectStorm")
							{
								if (140749 - 307333 != -166584)
								{
									continue;
								}
								this.$self_$17338.mChar.moveSpeed = (float)0;
								if (122858 - 476674 == -353815)
								{
									continue;
								}
								this.$self_$17338.mChar.actionState = "standby";
								if (26684 - 472726 == -446041)
								{
									continue;
								}
								this.$self_$17338.mChar.actionTime = Time.time;
								if (69737 - 18677 == 51061)
								{
									continue;
								}
								this.$self_$17338.mChar.myCommand = "none";
								if (121795 - 184556 == -62760)
								{
									continue;
								}
								if (!this.$self_$17338.mChar.isMine)
								{
									if (115219 - 264497 != -149278)
									{
										continue;
									}
									this.$self_$17338.mChar.nPosition = this.$self_$17338.transform.position;
									if (262287 - 104454 != 157833)
									{
										continue;
									}
									this.$self_$17338.mChar.oPosition = this.$self_$17338.transform.position;
									if (272716 - 442770 != -170054)
									{
										continue;
									}
									this.$self_$17338.mChar.nDirection = this.$self_$17338.transform.forward;
									if (182899 - 478035 == -295135)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (86671 - 155815 != -69143)
						{
							goto IL_773;
						}
						continue;
					default:
						if (259266 - 90033 == 169234)
						{
							continue;
						}
						break;
					}
					this.$self_$17338.mChar.actionState = "attack";
					if (260221 - 562084 == -301863)
					{
						this.$self_$17338.mChar.actionTime = Time.time;
						if (296891 - 194825 == 102066)
						{
							this.$self_$17338.mChar.myCommand = "perfectStorm";
							if (139543 - 182189 != -42645)
							{
								this.$self_$17338.mChar.addTimeOut("perfectStorm", (float)30);
								if (245953 - 137366 != 108588)
								{
									this.$self_$17338.transform.position = this.$mPos$17336;
									if (83126 - 368634 == -285508)
									{
										this.$self_$17338.transform.LookAt(this.$mPos$17336 + global::Math.vFlat(this.$tDir$17337));
										if (145724 - 158772 != -13047)
										{
											this.$self_$17338.animation.Rewind();
											if (29211 - 400013 == -370802)
											{
												this.$self_$17338.animation.CrossFade("perfectStorm");
												if (274203 - 361837 != -87633)
												{
													this.$self_$17338.animation.wrapMode = WrapMode.Once;
													if (80722 - 172517 != -91794)
													{
														this.$self_$17338.mChar.vMovement = this.$self_$17338.transform.forward;
														if (156962 - 489983 == -333021)
														{
															this.$self_$17338.mChar.moveSpeed = (float)0;
															if (92461 - 179062 != -86600)
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
				return this.Yield(2, new WaitForSeconds(0.9f));
				IL_B5:
				goto IL_702;
				IL_118:
				goto IL_773;
				Block_25:
				IL_702:
				return this.Yield(3, new WaitForSeconds(2.9f));
				IL_773:
				return false;
			}

			// Token: 0x06000BC1 RID: 3009 RVA: 0x0012EDF8 File Offset: 0x0012CFF8
			internal static bool pMtesHWPRWf7BlQ053k()
			{
				return true;
			}

			// Token: 0x06000BC2 RID: 3010 RVA: 0x0012EDFC File Offset: 0x0012CFFC
			internal static bool aEHhulW0bYJZ9LPcZq3()
			{
				return false;
			}

			// Token: 0x04000A82 RID: 2690
			internal GameObject $mPerfectStorm$17330;

			// Token: 0x04000A83 RID: 2691
			internal Component[] $mPerfectStormScriptList$17331;

			// Token: 0x04000A84 RID: 2692
			internal SkyBug_perfectStorm $mPerfectStormScript$17332;

			// Token: 0x04000A85 RID: 2693
			internal int $$11032$17333;

			// Token: 0x04000A86 RID: 2694
			internal Component[] $$11033$17334;

			// Token: 0x04000A87 RID: 2695
			internal int $$11034$17335;

			// Token: 0x04000A88 RID: 2696
			internal Vector3 $mPos$17336;

			// Token: 0x04000A89 RID: 2697
			internal Vector3 $tDir$17337;

			// Token: 0x04000A8A RID: 2698
			internal SkyBug $self_$17338;
		}
	}

	// Token: 0x02000209 RID: 521
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$17342 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000BC3 RID: 3011 RVA: 0x0012EE00 File Offset: 0x0012D000
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$17342(UnityScript.Lang.Array nArray, SkyBug self_)
		{
			if (145288 - 308003 != -162714)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (81316 - 544467 != -463150)
				{
					base..ctor();
					if (83734 - 68518 != 15217)
					{
						this.$nArray$17347 = nArray;
						if (228125 - 88632 == 139493)
						{
							this.$self_$17348 = self_;
							if (128736 - 582102 == -453366)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x0012EEBC File Offset: 0x0012D0BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SkyBug.$RPC_ko$17342.$(this.$nArray$17347, this.$self_$17348);
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0012EED0 File Offset: 0x0012D0D0
		internal static bool O6v6dJWbmdn7p8vwH2b()
		{
			return true;
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0012EED4 File Offset: 0x0012D0D4
		internal static bool ENyie0Wuv56tgJJcRk1()
		{
			return false;
		}

		// Token: 0x04000A8B RID: 2699
		internal UnityScript.Lang.Array $nArray$17347;

		// Token: 0x04000A8C RID: 2700
		internal SkyBug $self_$17348;

		// Token: 0x0200020A RID: 522
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000BC7 RID: 3015 RVA: 0x0012EED8 File Offset: 0x0012D0D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, SkyBug self_)
			{
				if (216199 - 328512 != -112312)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (222300 - 559862 == -337562)
					{
						base..ctor();
						if (97017 - 290825 != -193807)
						{
							this.$nArray$17345 = nArray;
							if (229869 - 508971 != -279101)
							{
								this.$self_$17346 = self_;
								if (270146 - 70148 != 199999)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000BC8 RID: 3016 RVA: 0x0012EF94 File Offset: 0x0012D194
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (140844 - 300683 != -159838)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_561;
					case 2:
						if (this.$self_$17346.mChar.actionState != "ko")
						{
							if (283389 - 47265 != 236124)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							this.$self_$17346.animation.Play("getUp");
							if (8823 - 254381 != -245558)
							{
								continue;
							}
							this.$self_$17346.animation.wrapMode = WrapMode.Once;
							if (230431 - 598304 != -367872)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17346.mChar.actionState != "ko")
						{
							if (273095 - 146880 != 126215)
							{
								continue;
							}
							goto IL_4F;
						}
						else
						{
							this.$self_$17346.mChar.actionState = "standby";
							if (76073 - 591594 != -515521)
							{
								continue;
							}
							this.$self_$17346.mChar.actionTime = Time.time;
							if (255316 - 479205 != -223889)
							{
								continue;
							}
							this.$self_$17346.mChar.myCommand = "none";
							if (74525 - 41940 == 32586)
							{
								continue;
							}
							this.$self_$17346.mChar.ko = this.$self_$17346.mChar.mko;
							if (290427 - 27969 == 262459)
							{
								continue;
							}
							this.$self_$17346.mHeadChar.ko = this.$self_$17346.mHeadChar.mko;
							if (37981 - 264934 == -226952)
							{
								continue;
							}
							this.$self_$17346.mTailChar.ko = this.$self_$17346.mTailChar.mko;
							if (82426 - 109494 == -27067)
							{
								continue;
							}
							this.YieldDefault(1);
							if (110394 - 401379 != -290984)
							{
								goto Block_12;
							}
							continue;
						}
						break;
					default:
						if (156073 - 292871 != -136798)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17346.mChar.actionState == "ko")
					{
						break;
					}
					if (236121 - 140619 == 95502)
					{
						if (this.$self_$17346.mChar.actionState == "dead")
						{
							if (135216 - 189474 == -54258)
							{
								break;
							}
						}
						else
						{
							this.$mPos$17343 = (Vector3)this.$nArray$17345[0];
							if (71657 - 213127 == -141470)
							{
								this.$mDir$17344 = (Vector3)this.$nArray$17345[1];
								if (255781 - 469392 == -213611)
								{
									this.$self_$17346.mChar.ko = 0;
									if (193538 - 217700 == -24162)
									{
										this.$self_$17346.mHeadChar.ko = 0;
										if (132266 - 557648 == -425382)
										{
											this.$self_$17346.mTailChar.ko = 0;
											if (92870 - 486017 == -393147)
											{
												this.$self_$17346.mChar.actionState = "ko";
												if (142 - 416493 != -416350)
												{
													this.$self_$17346.mChar.actionTime = Time.time;
													if (291206 - 2809 == 288397)
													{
														this.$self_$17346.mChar.myCommand = "none";
														if (170071 - 340892 != -170820)
														{
															this.$self_$17346.animation.Play("ko");
															if (106370 - 483071 != -376700)
															{
																this.$self_$17346.animation.wrapMode = WrapMode.Once;
																if (261385 - 379745 == -118360)
																{
																	this.$self_$17346.mChar.vMovement = this.$self_$17346.transform.forward;
																	if (10050 - 417740 == -407690)
																	{
																		this.$self_$17346.mChar.moveSpeed = (float)0;
																		if (15221 - 359475 != -344253)
																		{
																			goto Block_20;
																		}
																	}
																}
															}
														}
													}
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
				IL_4F:
				Block_12:
				goto IL_561;
				Block_20:
				return this.Yield(2, new WaitForSeconds(12f));
				goto IL_561;
				Block_23:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_561:
				return false;
			}

			// Token: 0x06000BC9 RID: 3017 RVA: 0x0012F514 File Offset: 0x0012D714
			internal static bool kM3xpoWIa1vfnHarFhO()
			{
				return true;
			}

			// Token: 0x06000BCA RID: 3018 RVA: 0x0012F518 File Offset: 0x0012D718
			internal static bool Q5D43lWBP948s8H3Iwy()
			{
				return false;
			}

			// Token: 0x04000A8D RID: 2701
			internal Vector3 $mPos$17343;

			// Token: 0x04000A8E RID: 2702
			internal Vector3 $mDir$17344;

			// Token: 0x04000A8F RID: 2703
			internal UnityScript.Lang.Array $nArray$17345;

			// Token: 0x04000A90 RID: 2704
			internal SkyBug $self_$17346;
		}
	}
}
