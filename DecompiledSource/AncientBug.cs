using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000004 RID: 4
[Serializable]
public class AncientBug : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AncientBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002060 File Offset: 0x00000260
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (100966 - 487782 != -386816)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (126313 - 296898 != -170584)
			{
				this.mChar.actionState = "standby";
				if (10638 - 110760 != -100121)
				{
					this.mChar.actionTime = Time.time;
					if (219267 - 43677 != 175591)
					{
						this.mChar.myCommand = "none";
						if (296506 - 365432 != -68925)
						{
							GameObject gameObject = global::Math.findChildObject(this.transform, "Head").gameObject;
							if (221780 - 241942 == -20162)
							{
								if (gameObject)
								{
									if (53590 - 351372 != -297782)
									{
										continue;
									}
									this.mHeadChar = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (21113 - 540632 == -519518)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find Head GameObject");
									if (293683 - 477404 == -183720)
									{
										continue;
									}
								}
								GameObject gameObject2 = global::Math.findChildObject(this.transform, "Hand_L").gameObject;
								if (48484 - 121582 != -73097)
								{
									if (gameObject2)
									{
										if (296965 - 97349 == 199617)
										{
											continue;
										}
										this.mLeftHandChar = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
										if (116615 - 505290 == -388674)
										{
											continue;
										}
									}
									else
									{
										Debug.LogError("Cannot find Hand_L GameObject");
										if (196597 - 496778 != -300181)
										{
											continue;
										}
									}
									GameObject gameObject3 = global::Math.findChildObject(this.transform, "Hand_R").gameObject;
									if (92141 - 569107 == -476966)
									{
										if (gameObject3)
										{
											if (36195 - 200420 == -164225)
											{
												this.mRightHandChar = (CharacterControl)gameObject3.GetComponent(typeof(CharacterControl));
												if (181934 - 366337 != -184402)
												{
													break;
												}
											}
										}
										else
										{
											Debug.LogError("Cannot find Hand_R GameObject");
											if (208829 - 96395 == 112434)
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

	// Token: 0x06000003 RID: 3 RVA: 0x00002364 File Offset: 0x00000564
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (36624 - 595142 != -558518)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (21321 - 24913 == -3591)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (82638 - 506514 != -423876)
				{
					continue;
				}
			}
			if (this.mChar.ActorNr != 0)
			{
				if (63049 - 205190 != -142141)
				{
					continue;
				}
				if (this.mHeadChar)
				{
					if (122980 - 129353 == -6372)
					{
						continue;
					}
					this.mHeadChar.ActorNr = this.mChar.ActorNr + 1;
					if (146541 - 357771 == -211229)
					{
						continue;
					}
					this.mHeadChar.ownerID = this.mChar.ownerID;
					if (267988 - 589451 == -321462)
					{
						continue;
					}
					this.mHeadChar.gameObject.layer = this.gameObject.layer;
					if (181484 - 21244 == 160241)
					{
						continue;
					}
					this.mHeadChar.isPlayer = false;
					if (107258 - 111338 == -4079)
					{
						continue;
					}
					this.mHeadChar.isControlled = false;
					if (213122 - 506480 != -293358)
					{
						continue;
					}
					if (this.mChar.ownerID == PlayerData.UID)
					{
						if (23375 - 181906 != -158531)
						{
							continue;
						}
						this.mHeadChar.isMine = true;
						if (46813 - 390494 == -343680)
						{
							continue;
						}
					}
					else
					{
						this.mHeadChar.isMine = false;
						if (141508 - 477481 == -335972)
						{
							continue;
						}
					}
					if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.mHeadChar.ActorNr], null))
					{
						if (201186 - 497809 != -296623)
						{
							continue;
						}
						Debug.Log("ActorNr: " + this.mHeadChar.ActorNr + " already existed");
						if (225668 - 11299 != 214369)
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
						if (209809 - 531632 != -321823)
						{
							continue;
						}
						UnityEngine.Object.Destroy(obj3);
						if (213390 - 169954 == 43437)
						{
							continue;
						}
					}
					PhotonClient.ActorNrList.Add(this.mHeadChar.ActorNr, this.mHeadChar.gameObject);
					if (57547 - 135473 == -77925)
					{
						continue;
					}
				}
				else
				{
					Debug.LogError("Missing Head CharacterControl");
					if (223674 - 201195 == 22480)
					{
						continue;
					}
				}
				if (this.mLeftHandChar)
				{
					if (184345 - 489769 == -305423)
					{
						continue;
					}
					this.mLeftHandChar.ActorNr = this.mChar.ActorNr + 2;
					if (243103 - 87249 == 155855)
					{
						continue;
					}
					this.mLeftHandChar.ownerID = this.mChar.ownerID;
					if (245386 - 325706 == -80319)
					{
						continue;
					}
					this.mLeftHandChar.gameObject.layer = this.gameObject.layer;
					if (238294 - 116297 == 121998)
					{
						continue;
					}
					this.mLeftHandChar.isPlayer = false;
					if (220933 - 429222 == -208288)
					{
						continue;
					}
					this.mLeftHandChar.isControlled = false;
					if (33695 - 365740 == -332044)
					{
						continue;
					}
					if (this.mChar.ownerID == PlayerData.UID)
					{
						if (156577 - 372216 == -215638)
						{
							continue;
						}
						this.mLeftHandChar.isMine = true;
						if (250102 - 430278 == -180175)
						{
							continue;
						}
					}
					else
					{
						this.mLeftHandChar.isMine = false;
						if (96455 - 514360 == -417904)
						{
							continue;
						}
					}
					if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.mLeftHandChar.ActorNr], null))
					{
						if (62135 - 71195 != -9060)
						{
							continue;
						}
						Debug.Log("ActorNr: " + this.mLeftHandChar.ActorNr + " already existed");
						if (73708 - 86657 == -12948)
						{
							continue;
						}
						object obj5;
						object obj4 = obj5 = PhotonClient.ActorNrList[this.mLeftHandChar.ActorNr];
						if (!(obj4 is GameObject))
						{
							obj5 = RuntimeServices.Coerce(obj4, typeof(GameObject));
						}
						GameObject obj6 = (GameObject)obj5;
						if (178349 - 319001 == -140651)
						{
							continue;
						}
						UnityEngine.Object.Destroy(obj6);
						if (60002 - 104495 == -44492)
						{
							continue;
						}
					}
					PhotonClient.ActorNrList.Add(this.mLeftHandChar.ActorNr, this.mLeftHandChar.gameObject);
					if (157130 - 94416 == 62715)
					{
						continue;
					}
				}
				else
				{
					Debug.LogError("Missing Hand_L CharacterControl");
					if (196742 - 329320 != -132578)
					{
						continue;
					}
				}
				if (this.mRightHandChar)
				{
					if (36565 - 376712 != -340147)
					{
						continue;
					}
					this.mRightHandChar.ActorNr = this.mChar.ActorNr + 3;
					if (247893 - 193915 == 53979)
					{
						continue;
					}
					this.mRightHandChar.ownerID = this.mChar.ownerID;
					if (243572 - 200984 == 42589)
					{
						continue;
					}
					this.mRightHandChar.gameObject.layer = this.gameObject.layer;
					if (205748 - 398714 != -192966)
					{
						continue;
					}
					this.mRightHandChar.isPlayer = false;
					if (221249 - 314144 != -92895)
					{
						continue;
					}
					this.mRightHandChar.isControlled = false;
					if (43311 - 591742 != -548431)
					{
						continue;
					}
					if (this.mChar.ownerID == PlayerData.UID)
					{
						if (108095 - 499410 == -391314)
						{
							continue;
						}
						this.mRightHandChar.isMine = true;
						if (263582 - 195034 != 68548)
						{
							continue;
						}
					}
					else
					{
						this.mRightHandChar.isMine = false;
						if (56218 - 398984 == -342765)
						{
							continue;
						}
					}
					if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.mRightHandChar.ActorNr], null))
					{
						if (113004 - 316390 == -203385)
						{
							continue;
						}
						Debug.Log("ActorNr: " + this.mRightHandChar.ActorNr + " already existed");
						if (15553 - 68444 != -52891)
						{
							continue;
						}
						object obj8;
						object obj7 = obj8 = PhotonClient.ActorNrList[this.mRightHandChar.ActorNr];
						if (!(obj7 is GameObject))
						{
							obj8 = RuntimeServices.Coerce(obj7, typeof(GameObject));
						}
						GameObject obj9 = (GameObject)obj8;
						if (269161 - 462487 == -193325)
						{
							continue;
						}
						UnityEngine.Object.Destroy(obj9);
						if (95020 - 481116 == -386095)
						{
							continue;
						}
					}
					PhotonClient.ActorNrList.Add(this.mRightHandChar.ActorNr, this.mRightHandChar.gameObject);
					if (266773 - 71779 != 194994)
					{
						continue;
					}
				}
				else
				{
					Debug.LogError("Missing Hand_R CharacterControl");
					if (271774 - 97980 != 173794)
					{
						continue;
					}
				}
			}
			if (!this.mChar)
			{
				break;
			}
			if (66566 - 333270 != -266703)
			{
				this.mChar.mImmuneList = new UnityScript.Lang.Array(new object[]
				{
					"artCancel",
					"swallow",
					"paralysis",
					"needlePrison",
					"invisible",
					"petrify",
					"snowMan",
					"snowBall",
					"sleep",
					"charm",
					"mindControl",
					"coma"
				});
				if (147503 - 95108 == 52395)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002D94 File Offset: 0x00000F94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (298520 - 274846 != 23675)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (113563 - 284304 == -170740)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (143243 - 207654 == -64410)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_3BB;
					}
					if (184193 - 134466 == 49728)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (287014 - 13727 != 273287)
				{
					continue;
				}
			}
			IL_3BB:
			if (this.mChar.hp > 0)
			{
				goto IL_4A2;
			}
			if (57883 - 372860 != -314977)
			{
				continue;
			}
			if (!(this.mChar.actionState != "dead"))
			{
				goto IL_4A2;
			}
			if (187293 - 322086 == -134792)
			{
				continue;
			}
			if (this.mChar.isMine)
			{
				if (131682 - 281597 != -149915)
				{
					continue;
				}
				this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
				{
					this.transform.position,
					this.transform.forward
				})));
				if (229503 - 166825 != 62678)
				{
					continue;
				}
				if (PhotonClient.IsInitialized())
				{
					if (76682 - 146185 == -69502)
					{
						continue;
					}
					this.mChar.DeadEvent();
					if (291808 - 461334 == -169525)
					{
						continue;
					}
				}
			}
			else
			{
				this.mChar.hp = 1;
				if (173507 - 284140 == -110632)
				{
					continue;
				}
			}
			IL_1A:
			if (!this.mHeadChar)
			{
				break;
			}
			if (113236 - 284544 == -171307)
			{
				continue;
			}
			if (!this.mLeftHandChar)
			{
				break;
			}
			if (141725 - 74885 == 66841)
			{
				continue;
			}
			if (!this.mRightHandChar)
			{
				break;
			}
			if (185431 - 230105 == -44673)
			{
				continue;
			}
			if (this.mHeadChar.hp <= 0)
			{
				if (202036 - 496686 != -294650)
				{
					continue;
				}
				this.mHeadChar.hp = 1;
				if (152746 - 47131 != 105615)
				{
					continue;
				}
			}
			if (this.mLeftHandChar.hp <= 0)
			{
				if (64594 - 272522 != -207928)
				{
					continue;
				}
				this.mLeftHandChar.hp = 1;
				if (278302 - 104030 != 174272)
				{
					continue;
				}
			}
			if (this.mRightHandChar.hp > 0)
			{
				break;
			}
			if (233393 - 474263 == -240869)
			{
				continue;
			}
			this.mRightHandChar.hp = 1;
			if (152022 - 23732 != 128290)
			{
				continue;
			}
			break;
			IL_4A2:
			if (this.mChar.ko > 0)
			{
				goto IL_1A;
			}
			if (40464 - 479347 != -438882)
			{
				if (!this.mChar.isMine)
				{
					goto IL_1A;
				}
				if (235475 - 505123 != -269647)
				{
					if (this.mChar.actionState == "burrow")
					{
						if (191406 - 546533 != -355126)
						{
							this.mChar.ko = 30;
							if (138745 - 298858 != -160112)
							{
								goto IL_1A;
							}
						}
					}
					else
					{
						if (!(this.mChar.actionState != "ko"))
						{
							goto IL_1A;
						}
						if (79027 - 70699 != 8329)
						{
							this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (96298 - 260916 != -164617)
							{
								if (!PhotonClient.IsInitialized())
								{
									goto IL_1A;
								}
								if (82476 - 266549 != -184072)
								{
									this.mChar.KoEvent();
									if (299545 - 421255 == -121710)
									{
										goto IL_1A;
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000005 RID: 5 RVA: 0x000032D4 File Offset: 0x000014D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (249918 - 287674 != -37755)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (68252 - 572878 != -504625)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (247105 - 16744 != 230362)
				{
					if (132816 - 174383 == -41567)
					{
						if (ActionName == "RPC_surface")
						{
							if (148567 - 448279 == -299711)
							{
								continue;
							}
							v = 1;
							if (55263 - 245354 != -190091)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_burrow")
						{
							if (267127 - 335956 != -68829)
							{
								continue;
							}
							v = 2;
							if (143566 - 35806 != 107760)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_turnLeft")
						{
							if (229036 - 404356 == -175319)
							{
								continue;
							}
							v = 3;
							if (260726 - 343490 != -82764)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_turnRight")
						{
							if (139889 - 178966 == -39076)
							{
								continue;
							}
							v = 4;
							if (262746 - 260437 != 2309)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_headSweep")
						{
							if (214271 - 582131 != -367860)
							{
								continue;
							}
							v = 11;
							if (265792 - 348414 == -82621)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_leftSweep")
						{
							if (186460 - 16929 == 169532)
							{
								continue;
							}
							v = 12;
							if (128466 - 47802 != 80664)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_rightSweep")
						{
							if (282902 - 231065 != 51837)
							{
								continue;
							}
							v = 13;
							if (248803 - 257261 == -8457)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_sweep_hit")
						{
							if (77580 - 546471 != -468891)
							{
								continue;
							}
							v = -11;
							if (296902 - 82769 != 214133)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_leftSmash")
						{
							if (48496 - 34212 != 14284)
							{
								continue;
							}
							v = 21;
							if (70411 - 13485 != 56926)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_rightSmash")
						{
							if (289607 - 240975 != 48632)
							{
								continue;
							}
							v = 22;
							if (43372 - 519082 == -475709)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_bodySmash")
						{
							if (171314 - 378835 == -207520)
							{
								continue;
							}
							v = 23;
							if (183566 - 334048 != -150482)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_smash_hit")
						{
							if (76015 - 583815 == -507799)
							{
								continue;
							}
							v = -21;
							if (66218 - 353695 == -287476)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_headPoison")
						{
							if (191750 - 353801 != -162051)
							{
								continue;
							}
							v = 31;
							if (187175 - 132607 == 54569)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_thornStrike")
						{
							if (251234 - 301413 == -50178)
							{
								continue;
							}
							v = 41;
							if (185485 - 220769 == -35283)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_thornStrike_hit")
						{
							if (19845 - 413673 == -393827)
							{
								continue;
							}
							v = -41;
							if (157432 - 554496 == -397063)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (239733 - 577244 != -337510)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (171898 - 474367 == -302469)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (264930 - 33702 != 231229)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (186096 - 551823 == -365727)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (217590 - 181281 == 36309)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (279413 - 142070 != 137344)
											{
												Hashtable hashtable = new Hashtable();
												if (188716 - 133114 == 55602)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (243706 - 80453 == 163253)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (132294 - 29360 != 102935)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (55962 - 291550 == -235588)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (288579 - 491077 != -202497)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (292545 - 11870 == 280675)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (164661 - 247033 == -82372)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (30209 - 306501 == -276292)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (297326 - 520355 == -223029)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (208611 - 567007 != -358395)
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

	// Token: 0x06000006 RID: 6 RVA: 0x00003B04 File Offset: 0x00001D04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (199932 - 379321 != -179389)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (229306 - 430061 != -200754)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (105748 - 598575 == -492827)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (49824 - 359818 == -309994)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (218217 - 418576 != -200358)
						{
							int num3 = num;
							if (202195 - 386173 != -183977)
							{
								if (num3 == 1)
								{
									if (1536 - 592799 == -591263)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (100371 - 94559 != 5813)
										{
											this.StartCoroutine_Auto(this.RPC_surface(vector, vector2, num2));
											if (146316 - 66145 == 80171)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (131803 - 505446 == -373643)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (170742 - 92958 != 77785)
										{
											this.StartCoroutine_Auto(this.RPC_burrow(vector, vector2, num2));
											if (238555 - 456867 == -218312)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 3)
								{
									if (76524 - 4869 == 71655)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (132015 - 205610 == -73595)
										{
											this.StartCoroutine_Auto(this.RPC_turnLeft(vector, vector2, num2));
											if (228849 - 320089 == -91240)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 4)
								{
									if (293838 - 262943 != 30896)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (88130 - 224417 != -136286)
										{
											this.StartCoroutine_Auto(this.RPC_turnRight(vector, vector2, num2));
											if (197417 - 153483 == 43934)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (81500 - 220625 != -139124)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (187236 - 439158 == -251922)
										{
											this.StartCoroutine_Auto(this.RPC_headSweep(vector, vector2, num2));
											if (294629 - 202484 == 92145)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 12)
								{
									if (203343 - 8331 != 195013)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (228734 - 170182 != 58553)
										{
											this.StartCoroutine_Auto(this.RPC_leftSweep(vector, vector2, num2));
											if (206699 - 29698 != 177002)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 13)
								{
									if (119008 - 462081 == -343073)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (182704 - 339544 == -156840)
										{
											this.StartCoroutine_Auto(this.RPC_rightSweep(vector, vector2, num2));
											if (66999 - 528274 != -461274)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (244997 - 328082 == -83085)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (248526 - 304070 != -55543)
										{
											this.RPC_sweep_hit(vector, vector2, num2);
											if (285051 - 436000 == -150949)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (179274 - 356402 == -177128)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (130949 - 111427 != 19523)
										{
											this.StartCoroutine_Auto(this.RPC_leftSmash(vector, vector2, num2));
											if (275917 - 280172 != -4254)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 22)
								{
									if (156286 - 577288 != -421001)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (297614 - 343783 == -46169)
										{
											this.StartCoroutine_Auto(this.RPC_rightSmash(vector, vector2, num2));
											if (252515 - 369874 != -117358)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 23)
								{
									if (220245 - 438331 != -218085)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (234622 - 584400 == -349778)
										{
											this.StartCoroutine_Auto(this.RPC_bodySmash(vector, vector2, num2));
											if (287509 - 330567 != -43057)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -21)
								{
									if (35092 - 195550 == -160458)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (23988 - 358487 == -334499)
										{
											this.RPC_smash_hit(vector, vector2, num2);
											if (214413 - 227932 == -13519)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (153515 - 336418 != -182902)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (145076 - 18440 == 126636)
										{
											this.StartCoroutine_Auto(this.RPC_headPoison(vector, vector2, num2));
											if (135402 - 254229 == -118827)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 41)
								{
									if (243736 - 535649 == -291913)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (297123 - 515314 != -218190)
										{
											this.StartCoroutine_Auto(this.RPC_thornStrike(vector, vector2, num2));
											if (227396 - 230180 != -2783)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -41)
								{
									if (155927 - 65170 != 90758)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (33006 - 562360 == -529354)
										{
											this.RPC_thornStrike_hit(vector, vector2, num2);
											if (7897 - 172085 == -164188)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (32840 - 568249 != -535408)
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

	// Token: 0x06000007 RID: 7 RVA: 0x000043D4 File Offset: 0x000025D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x000043D8 File Offset: 0x000025D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(Vector3 targetPosition, GameObject targetObject)
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x000043DC File Offset: 0x000025DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(Vector3 targetPosition, GameObject targetObject)
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x000043E0 File Offset: 0x000025E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(Vector3 targetPosition, GameObject targetObject)
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x000043E4 File Offset: 0x000025E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_burrow(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new AncientBug.$RPC_burrow$15121(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600000C RID: 12 RVA: 0x000043F4 File Offset: 0x000025F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_surface(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new AncientBug.$RPC_surface$15128(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00004404 File Offset: 0x00002604
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_turnLeft(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new AncientBug.$RPC_turnLeft$15141(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00004414 File Offset: 0x00002614
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_turnRight(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new AncientBug.$RPC_turnRight$15149(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00004424 File Offset: 0x00002624
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_headSweep(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new AncientBug.$RPC_headSweep$15157(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00004434 File Offset: 0x00002634
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_leftSweep(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new AncientBug.$RPC_leftSweep$15169(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00004444 File Offset: 0x00002644
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rightSweep(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new AncientBug.$RPC_rightSweep$15182(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00004454 File Offset: 0x00002654
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_sweep_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (23921 - 262492 != -238570)
		{
		}
		for (;;)
		{
			UnityEngine.Object.Instantiate(this.sweep_hit, hitPos, Quaternion.identity);
			if (91894 - 51439 != 40456)
			{
				if (this.dblc3J7UV >= Time.time)
				{
					break;
				}
				if (46791 - 140913 == -94122)
				{
					this.dblc3J7UV = Time.time + 0.2f;
					if (82336 - 34609 == 47727)
					{
						if (!this.nAttack_hitFx)
						{
							break;
						}
						if (169937 - 458673 == -288736)
						{
							this.audio.PlayOneShot(this.nAttack_hitFx);
							if (192921 - 111963 == 80958)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00004564 File Offset: 0x00002764
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_leftSmash(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new AncientBug.$RPC_leftSmash$15195(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00004574 File Offset: 0x00002774
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rightSmash(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new AncientBug.$RPC_rightSmash$15210(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00004584 File Offset: 0x00002784
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_smash_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.smash_hit, hitPos, Quaternion.Euler((float)270, (float)90, (float)0));
	}

	// Token: 0x06000016 RID: 22 RVA: 0x000045A4 File Offset: 0x000027A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_bodySmash(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new AncientBug.$RPC_bodySmash$15225(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000017 RID: 23 RVA: 0x000045B4 File Offset: 0x000027B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_headPoison(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new AncientBug.$RPC_headPoison$15236(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000045C4 File Offset: 0x000027C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_thornStrike(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new AncientBug.$RPC_thornStrike$15252(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000019 RID: 25 RVA: 0x000045D4 File Offset: 0x000027D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_thornStrike_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.thornStrike_hit, hitPos, Quaternion.identity);
	}

	// Token: 0x0600001A RID: 26 RVA: 0x000045E8 File Offset: 0x000027E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new AncientBug.$RPC_ko$15265(nArray, this).GetEnumerator();
	}

	// Token: 0x0600001B RID: 27 RVA: 0x000045F8 File Offset: 0x000027F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new AncientBug.$RPC_dead$15272(nArray, this).GetEnumerator();
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00004608 File Offset: 0x00002808
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600001D RID: 29 RVA: 0x0000460C File Offset: 0x0000280C
	internal static bool o0pcIxcVrq8Yr1bQJB()
	{
		return true;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00004610 File Offset: 0x00002810
	internal static bool Cf7G9WU5YxyWb8McCD()
	{
		return false;
	}

	// Token: 0x04000038 RID: 56
	public eAncientBugType mType;

	// Token: 0x04000039 RID: 57
	public CharacterControl mChar;

	// Token: 0x0400003A RID: 58
	public CharacterControl mHeadChar;

	// Token: 0x0400003B RID: 59
	public CharacterControl mLeftHandChar;

	// Token: 0x0400003C RID: 60
	public CharacterControl mRightHandChar;

	// Token: 0x0400003D RID: 61
	public GameObject surface_hit;

	// Token: 0x0400003E RID: 62
	public GameObject sweep_hit;

	// Token: 0x0400003F RID: 63
	public AudioClip nAttack_hitFx;

	// Token: 0x04000040 RID: 64
	private float dblc3J7UV;

	// Token: 0x04000041 RID: 65
	public AudioClip smashFx;

	// Token: 0x04000042 RID: 66
	public GameObject smash_hit;

	// Token: 0x04000043 RID: 67
	public GameObject bodySmash;

	// Token: 0x04000044 RID: 68
	public GameObject headPoison;

	// Token: 0x04000045 RID: 69
	public GameObject thornStrike_hit;

	// Token: 0x04000046 RID: 70
	public GameObject deadEffect;

	// Token: 0x02000005 RID: 5
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_burrow$15121 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00004614 File Offset: 0x00002814
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_burrow$15121(Vector3 mPos, Vector3 tDir, AncientBug self_)
		{
			if (96534 - 322685 != -226151)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (195296 - 577375 != -382078)
				{
					base..ctor();
					if (14092 - 337790 != -323697)
					{
						this.$mPos$15125 = mPos;
						if (237285 - 568287 == -331002)
						{
							this.$tDir$15126 = tDir;
							if (32478 - 33158 == -680)
							{
								this.$self_$15127 = self_;
								if (9639 - 399261 != -389621)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000046F0 File Offset: 0x000028F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AncientBug.$RPC_burrow$15121.$(this.$mPos$15125, this.$tDir$15126, this.$self_$15127);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000470C File Offset: 0x0000290C
		internal static bool AXy2HeTIdH7xetG0Of()
		{
			return true;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00004710 File Offset: 0x00002910
		internal static bool Uc43tp3iWIIQSZZkam()
		{
			return false;
		}

		// Token: 0x04000047 RID: 71
		internal Vector3 $mPos$15125;

		// Token: 0x04000048 RID: 72
		internal Vector3 $tDir$15126;

		// Token: 0x04000049 RID: 73
		internal AncientBug $self_$15127;

		// Token: 0x02000006 RID: 6
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000023 RID: 35 RVA: 0x00004714 File Offset: 0x00002914
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, AncientBug self_)
			{
				if (4729 - 242077 != -237347)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (152137 - 481114 == -328977)
					{
						base..ctor();
						if (164067 - 361904 == -197837)
						{
							this.$mPos$15122 = mPos;
							if (150004 - 11353 != 138652)
							{
								this.$tDir$15123 = tDir;
								if (157393 - 37120 == 120273)
								{
									this.$self_$15124 = self_;
									if (136524 - 325665 == -189141)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000024 RID: 36 RVA: 0x000047F0 File Offset: 0x000029F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (20144 - 345963 != -325818)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_428;
					case 2:
						Camera.main.SendMessage("AddCamereShake", 2f);
						if (124214 - 480220 == -356005)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$15124.surface_hit, new Vector3((float)-80, 49.5f, (float)80), Quaternion.identity);
						if (5952 - 362511 != -356558)
						{
							goto Block_18;
						}
						continue;
					case 3:
						if (this.$self_$15124.mChar.actionState == "attack")
						{
							if (178213 - 149998 == 28216)
							{
								continue;
							}
							if (this.$self_$15124.mChar.myCommand == "burrow")
							{
								if (44322 - 91301 != -46979)
								{
									continue;
								}
								this.$self_$15124.transform.position = new Vector3((float)-80, (float)20, (float)80);
								if (259315 - 250728 != 8587)
								{
									continue;
								}
								this.$self_$15124.mChar.actionState = "burrow";
								if (42372 - 440128 != -397756)
								{
									continue;
								}
								this.$self_$15124.mChar.actionTime = Time.time;
								if (186070 - 585848 == -399777)
								{
									continue;
								}
								this.$self_$15124.mChar.myCommand = "none";
								if (287025 - 198757 == 88269)
								{
									continue;
								}
								if (this.$self_$15124.mChar.isMine)
								{
									if (174399 - 36813 == 137587)
									{
										continue;
									}
									Camera.main.SendMessage("onAncientBugBorrow");
									if (122813 - 255454 == -132640)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (251894 - 508031 != -256137)
						{
							continue;
						}
						goto IL_428;
					default:
						if (222064 - 97146 != 124918)
						{
							continue;
						}
						break;
					}
					this.$self_$15124.mChar.actionState = "attack";
					if (198343 - 525987 != -327643)
					{
						this.$self_$15124.mChar.actionTime = Time.time;
						if (204909 - 1729 != 203181)
						{
							this.$self_$15124.mChar.myCommand = "burrow";
							if (205494 - 507787 == -302293)
							{
								this.$self_$15124.mChar.addTimeOut("surface", (float)12);
								if (291459 - 301361 != -9901)
								{
									this.$self_$15124.transform.position = this.$mPos$15122;
									if (5038 - 186799 != -181760)
									{
										this.$self_$15124.transform.LookAt(this.$mPos$15122 + global::Math.vFlat(this.$tDir$15123));
										if (292002 - 359939 != -67936)
										{
											this.$self_$15124.animation.CrossFade("burrow");
											if (79543 - 495178 != -415634)
											{
												this.$self_$15124.animation.wrapMode = WrapMode.Once;
												if (233553 - 317120 == -83567)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_18:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_428:
				return false;
			}

			// Token: 0x06000025 RID: 37 RVA: 0x00004C38 File Offset: 0x00002E38
			internal static bool ETr1y6XpVoXdRI4tlE()
			{
				return true;
			}

			// Token: 0x06000026 RID: 38 RVA: 0x00004C3C File Offset: 0x00002E3C
			internal static bool hdaO0gQJuuq5evrORA()
			{
				return false;
			}

			// Token: 0x0400004A RID: 74
			internal Vector3 $mPos$15122;

			// Token: 0x0400004B RID: 75
			internal Vector3 $tDir$15123;

			// Token: 0x0400004C RID: 76
			internal AncientBug $self_$15124;
		}
	}

	// Token: 0x02000007 RID: 7
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_surface$15128 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00004C40 File Offset: 0x00002E40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_surface$15128(Vector3 mPos, Vector3 tDir, AncientBug self_)
		{
			if (109748 - 387704 != -277955)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (146438 - 52251 != 94188)
				{
					base..ctor();
					if (130091 - 383513 == -253422)
					{
						this.$mPos$15138 = mPos;
						if (92697 - 128595 == -35898)
						{
							this.$tDir$15139 = tDir;
							if (17967 - 339315 == -321348)
							{
								this.$self_$15140 = self_;
								if (227588 - 236441 != -8852)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004D1C File Offset: 0x00002F1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AncientBug.$RPC_surface$15128.$(this.$mPos$15138, this.$tDir$15139, this.$self_$15140);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00004D38 File Offset: 0x00002F38
		internal static bool aXkZqSk5ibGbUAbgF0()
		{
			return true;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00004D3C File Offset: 0x00002F3C
		internal static bool jawRLYGiGMi8uRSyB7()
		{
			return false;
		}

		// Token: 0x0400004D RID: 77
		internal Vector3 $mPos$15138;

		// Token: 0x0400004E RID: 78
		internal Vector3 $tDir$15139;

		// Token: 0x0400004F RID: 79
		internal AncientBug $self_$15140;

		// Token: 0x02000008 RID: 8
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600002B RID: 43 RVA: 0x00004D40 File Offset: 0x00002F40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, AncientBug self_)
			{
				if (101843 - 197528 != -95684)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (123768 - 297381 != -173612)
					{
						base..ctor();
						if (287682 - 266375 != 21308)
						{
							this.$mPos$15135 = mPos;
							if (283494 - 553780 != -270285)
							{
								this.$tDir$15136 = tDir;
								if (248282 - 264136 == -15854)
								{
									this.$self_$15137 = self_;
									if (16559 - 106599 == -90040)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600002C RID: 44 RVA: 0x00004E1C File Offset: 0x0000301C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (171892 - 374052 != -202159)
				{
				}
				for (;;)
				{
					IL_33E:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9D5;
					case 2:
						if (this.$self_$15137.mChar.actionState != "attack")
						{
							goto IL_1A;
						}
						if (258588 - 597477 == -338888)
						{
							continue;
						}
						if (this.$self_$15137.mChar.myCommand != "surface")
						{
							if (237847 - 214169 != 23678)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							this.$hitLayer$15129 = 130816 - (1 << this.$self_$15137.gameObject.layer);
							if (253967 - 392530 != -138563)
							{
								continue;
							}
							this.$hitList$15130 = null;
							if (154268 - 536324 != -382056)
							{
								continue;
							}
							if (!this.$self_$15137.mChar.isMine)
							{
								goto IL_1D1;
							}
							if (242036 - 262221 != -20185)
							{
								continue;
							}
							this.$hitList$15130 = Damage.FindAreaTarget(this.$self_$15137.transform.position, (float)12, (float)6, this.$hitLayer$15129);
							if (77878 - 451356 == -373477)
							{
								continue;
							}
							this.$$iterator$9866$15132 = UnityRuntimeServices.GetEnumerator(this.$hitList$15130);
							if (191830 - 166953 != 24877)
							{
								continue;
							}
							while (this.$$iterator$9866$15132.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9866$15132.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15131 = (GameObject)obj2;
								if (80919 - 280666 == -199746)
								{
									goto IL_33E;
								}
								this.$self_$15137.mChar.hit(99, this.$hitObject$15131, this.$self_$15137.mChar.atk, 5, 0, (float)5 * global::Math.vFlat(this.$hitObject$15131.transform.position - this.$self_$15137.transform.position).normalized);
								if (245043 - 595012 != -349969)
								{
									goto IL_33E;
								}
								UnityRuntimeServices.Update(this.$$iterator$9866$15132, this.$hitObject$15131);
								if (268192 - 527453 != -259261)
								{
									goto IL_33E;
								}
							}
							if (286664 - 482729 != -196065)
							{
								continue;
							}
							this.$mHeal$15133 = 0;
							if (197362 - 402751 == -205388)
							{
								continue;
							}
							this.$$switch$781$15134 = this.$self_$15137.mType;
							if (266155 - 56303 != 209852)
							{
								continue;
							}
							if (this.$$switch$781$15134 == eAncientBugType.AncientBug)
							{
								if (265486 - 567663 == -302176)
								{
									continue;
								}
								this.$mHeal$15133 = 19999 * Mathf.FloorToInt((float)(this.$self_$15137.mHeadChar.hp / this.$self_$15137.mHeadChar.mhp));
								if (40345 - 381116 != -340771)
								{
									continue;
								}
							}
							else if (this.$$switch$781$15134 == eAncientBugType.AncientBug2)
							{
								if (255894 - 351179 != -95285)
								{
									continue;
								}
								this.$mHeal$15133 = 29999 * Mathf.FloorToInt((float)(this.$self_$15137.mHeadChar.hp / this.$self_$15137.mHeadChar.mhp));
								if (215229 - 324167 != -108938)
								{
									continue;
								}
							}
							if (this.$mHeal$15133 <= 0)
							{
								goto IL_1D1;
							}
							if (224220 - 163282 != 60938)
							{
								continue;
							}
							if (this.$self_$15137.mChar)
							{
								if (94711 - 158299 != -63588)
								{
									continue;
								}
								this.$self_$15137.mChar.RPC_AddHeal(1, this.$mHeal$15133, 0, 0, 0, 0, this.$self_$15137.mChar.ActorNr);
								if (126713 - 407284 == -280570)
								{
									continue;
								}
							}
							if (this.$self_$15137.mHeadChar)
							{
								if (76406 - 102741 != -26335)
								{
									continue;
								}
								this.$self_$15137.mHeadChar.RPC_AddHeal(1, this.$mHeal$15133, 0, 0, 0, 0, this.$self_$15137.mChar.ActorNr);
								if (212050 - 253776 != -41726)
								{
									continue;
								}
							}
							if (this.$self_$15137.mLeftHandChar)
							{
								if (56035 - 5294 != 50741)
								{
									continue;
								}
								this.$self_$15137.mLeftHandChar.RPC_AddHeal(1, this.$mHeal$15133, 0, 0, 0, 0, this.$self_$15137.mChar.ActorNr);
								if (250402 - 271117 == -20714)
								{
									continue;
								}
							}
							if (!this.$self_$15137.mRightHandChar)
							{
								goto IL_1D1;
							}
							if (171391 - 103325 == 68067)
							{
								continue;
							}
							this.$self_$15137.mRightHandChar.RPC_AddHeal(1, this.$mHeal$15133, 0, 0, 0, 0, this.$self_$15137.mChar.ActorNr);
							if (214038 - 106707 != 107332)
							{
								goto Block_37;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15137.mChar.actionState == "attack")
						{
							if (37301 - 305319 != -268018)
							{
								continue;
							}
							if (this.$self_$15137.mChar.myCommand == "surface")
							{
								if (23341 - 396513 != -373172)
								{
									continue;
								}
								this.$self_$15137.animation.Play("root");
								if (38769 - 237796 == -199026)
								{
									continue;
								}
								this.$self_$15137.animation.wrapMode = WrapMode.Loop;
								if (119281 - 559950 != -440669)
								{
									continue;
								}
								this.$self_$15137.mChar.actionState = "standby";
								if (158280 - 393867 == -235586)
								{
									continue;
								}
								this.$self_$15137.mChar.actionTime = Time.time;
								if (61919 - 125680 == -63760)
								{
									continue;
								}
								this.$self_$15137.mChar.myCommand = "none";
								if (30424 - 359886 != -329462)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (201860 - 14067 != 187794)
						{
							goto Block_25;
						}
						continue;
					default:
						if (284002 - 44273 == 239730)
						{
							continue;
						}
						break;
					}
					Debug.Log("AncientBug has surfaced!");
					if (35872 - 90543 != -54670)
					{
						this.$self_$15137.mChar.actionState = "attack";
						if (279827 - 43454 != 236374)
						{
							this.$self_$15137.mChar.actionTime = Time.time;
							if (92729 - 545426 != -452696)
							{
								this.$self_$15137.mChar.myCommand = "surface";
								if (279924 - 398306 == -118382)
								{
									this.$self_$15137.mChar.addTimeOut("burrow", (float)90);
									if (199294 - 430577 == -231283)
									{
										this.$self_$15137.transform.position = this.$mPos$15135;
										if (116211 - 181050 == -64839)
										{
											this.$self_$15137.transform.LookAt(this.$mPos$15135 + global::Math.vFlat(this.$tDir$15136));
											if (207837 - 318251 != -110413)
											{
												this.$self_$15137.animation.CrossFade("surface");
												if (269138 - 308261 != -39122)
												{
													this.$self_$15137.animation.wrapMode = WrapMode.Once;
													if (207065 - 11920 != 195146)
													{
														UnityEngine.Object.Instantiate(this.$self_$15137.surface_hit, new Vector3((float)-80, 49.5f, (float)80), Quaternion.identity);
														if (252565 - 578665 == -326100)
														{
															Camera.main.SendMessage("AddCamereShake", 3f);
															if (108324 - 386979 != -278654)
															{
																goto Block_7;
															}
														}
													}
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
				goto IL_9D5;
				Block_7:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_1D1:
				return this.Yield(3, new WaitForSeconds(1.3f));
				Block_25:
				goto IL_9D5;
				Block_37:
				goto IL_1D1;
				IL_9D5:
				return false;
			}

			// Token: 0x0600002D RID: 45 RVA: 0x00005810 File Offset: 0x00003A10
			internal static bool kcZGUkH6x8Q3FMTJJg()
			{
				return true;
			}

			// Token: 0x0600002E RID: 46 RVA: 0x00005814 File Offset: 0x00003A14
			internal static bool TcKkuyWUbSrDJ1wMBU()
			{
				return false;
			}

			// Token: 0x04000050 RID: 80
			internal int $hitLayer$15129;

			// Token: 0x04000051 RID: 81
			internal UnityScript.Lang.Array $hitList$15130;

			// Token: 0x04000052 RID: 82
			internal GameObject $hitObject$15131;

			// Token: 0x04000053 RID: 83
			internal IEnumerator $$iterator$9866$15132;

			// Token: 0x04000054 RID: 84
			internal int $mHeal$15133;

			// Token: 0x04000055 RID: 85
			internal eAncientBugType $$switch$781$15134;

			// Token: 0x04000056 RID: 86
			internal Vector3 $mPos$15135;

			// Token: 0x04000057 RID: 87
			internal Vector3 $tDir$15136;

			// Token: 0x04000058 RID: 88
			internal AncientBug $self_$15137;
		}
	}

	// Token: 0x02000009 RID: 9
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_turnLeft$15141 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00005818 File Offset: 0x00003A18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_turnLeft$15141(Vector3 mPos, Vector3 tDir, AncientBug self_)
		{
			if (134930 - 529904 != -394974)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (190552 - 485537 != -294984)
				{
					base..ctor();
					if (57879 - 164682 == -106803)
					{
						this.$mPos$15146 = mPos;
						if (278200 - 457970 == -179770)
						{
							this.$tDir$15147 = tDir;
							if (135455 - 413502 == -278047)
							{
								this.$self_$15148 = self_;
								if (134977 - 424716 != -289738)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000058F4 File Offset: 0x00003AF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AncientBug.$RPC_turnLeft$15141.$(this.$mPos$15146, this.$tDir$15147, this.$self_$15148);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00005910 File Offset: 0x00003B10
		internal static bool YGou1eAycXJlEx9VYZ()
		{
			return true;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00005914 File Offset: 0x00003B14
		internal static bool TPWy0nlrcrjTQkgImT()
		{
			return false;
		}

		// Token: 0x04000059 RID: 89
		internal Vector3 $mPos$15146;

		// Token: 0x0400005A RID: 90
		internal Vector3 $tDir$15147;

		// Token: 0x0400005B RID: 91
		internal AncientBug $self_$15148;

		// Token: 0x0200000A RID: 10
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000033 RID: 51 RVA: 0x00005918 File Offset: 0x00003B18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, AncientBug self_)
			{
				if (50157 - 106112 != -55955)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (85571 - 27858 == 57713)
					{
						base..ctor();
						if (70729 - 223294 != -152564)
						{
							this.$mPos$15143 = mPos;
							if (283545 - 62428 != 221118)
							{
								this.$tDir$15144 = tDir;
								if (61504 - 261219 != -199714)
								{
									this.$self_$15145 = self_;
									if (297354 - 52271 != 245084)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000034 RID: 52 RVA: 0x000059F4 File Offset: 0x00003BF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (24983 - 301353 != -276369)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_400;
					case 2:
						if (this.$self_$15145.mChar.actionState == "attack")
						{
							if (209220 - 326075 == -116854)
							{
								continue;
							}
							if (this.$self_$15145.mChar.myCommand == "turnLeft")
							{
								if (147796 - 327719 != -179923)
								{
									continue;
								}
								if (this.$tRotation$15142 == this.$self_$15145.transform.rotation)
								{
									if (202361 - 93268 == 109094)
									{
										continue;
									}
									this.$self_$15145.transform.Rotate((float)0, (float)-60, (float)0);
									if (142071 - 377833 == -235761)
									{
										continue;
									}
								}
								this.$self_$15145.animation.Play("root");
								if (42718 - 442685 != -399967)
								{
									continue;
								}
								this.$self_$15145.animation.wrapMode = WrapMode.Loop;
								if (189125 - 88032 != 101093)
								{
									continue;
								}
								this.$self_$15145.mChar.actionState = "standby";
								if (12098 - 421698 != -409600)
								{
									continue;
								}
								this.$self_$15145.mChar.actionTime = Time.time;
								if (264316 - 269557 != -5241)
								{
									continue;
								}
								this.$self_$15145.mChar.myCommand = "none";
								if (123995 - 561510 != -437515)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (83487 - 201577 != -118090)
						{
							continue;
						}
						goto IL_400;
					default:
						if (96494 - 474627 != -378133)
						{
							continue;
						}
						break;
					}
					this.$self_$15145.mChar.actionState = "attack";
					if (640 - 547798 == -547158)
					{
						this.$self_$15145.mChar.actionTime = Time.time;
						if (82108 - 56484 != 25625)
						{
							this.$self_$15145.mChar.myCommand = "turnLeft";
							if (82211 - 314748 != -232536)
							{
								this.$self_$15145.mChar.addTimeOut("turnLeft", (float)1);
								if (69331 - 168242 != -98910)
								{
									this.$self_$15145.transform.position = this.$mPos$15143;
									if (14589 - 289264 == -274675)
									{
										this.$self_$15145.transform.LookAt(this.$mPos$15143 + global::Math.vFlat(this.$tDir$15144));
										if (134077 - 541011 != -406933)
										{
											this.$self_$15145.animation.CrossFade("turnLeft");
											if (197443 - 353089 == -155646)
											{
												this.$self_$15145.animation.wrapMode = WrapMode.Once;
												if (266214 - 400553 == -134339)
												{
													this.$tRotation$15142 = this.$self_$15145.transform.rotation;
													if (142566 - 464349 != -321782)
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
				return this.Yield(2, new WaitForSeconds(1.2f));
				IL_400:
				return false;
			}

			// Token: 0x06000035 RID: 53 RVA: 0x00005E14 File Offset: 0x00004014
			internal static bool kZrChAyfwtIKgcO1md()
			{
				return true;
			}

			// Token: 0x06000036 RID: 54 RVA: 0x00005E18 File Offset: 0x00004018
			internal static bool dDGCALSmHoSvhEGdGY()
			{
				return false;
			}

			// Token: 0x0400005C RID: 92
			internal Quaternion $tRotation$15142;

			// Token: 0x0400005D RID: 93
			internal Vector3 $mPos$15143;

			// Token: 0x0400005E RID: 94
			internal Vector3 $tDir$15144;

			// Token: 0x0400005F RID: 95
			internal AncientBug $self_$15145;
		}
	}

	// Token: 0x0200000B RID: 11
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_turnRight$15149 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00005E1C File Offset: 0x0000401C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_turnRight$15149(Vector3 mPos, Vector3 tDir, AncientBug self_)
		{
			if (158755 - 532327 != -373572)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (257705 - 358679 == -100974)
				{
					base..ctor();
					if (56789 - 412277 != -355487)
					{
						this.$mPos$15154 = mPos;
						if (265805 - 290684 != -24878)
						{
							this.$tDir$15155 = tDir;
							if (153782 - 562528 == -408746)
							{
								this.$self_$15156 = self_;
								if (226224 - 345916 == -119692)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005EF8 File Offset: 0x000040F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AncientBug.$RPC_turnRight$15149.$(this.$mPos$15154, this.$tDir$15155, this.$self_$15156);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00005F14 File Offset: 0x00004114
		internal static bool KXkaQXo80K4rbBIRhP()
		{
			return true;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005F18 File Offset: 0x00004118
		internal static bool p2lRXtEJUcwjBMl8ZI()
		{
			return false;
		}

		// Token: 0x04000060 RID: 96
		internal Vector3 $mPos$15154;

		// Token: 0x04000061 RID: 97
		internal Vector3 $tDir$15155;

		// Token: 0x04000062 RID: 98
		internal AncientBug $self_$15156;

		// Token: 0x0200000C RID: 12
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600003B RID: 59 RVA: 0x00005F1C File Offset: 0x0000411C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, AncientBug self_)
			{
				if (257602 - 78721 != 178881)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (209932 - 585666 != -375733)
					{
						base..ctor();
						if (298543 - 261573 != 36971)
						{
							this.$mPos$15151 = mPos;
							if (242987 - 142295 == 100692)
							{
								this.$tDir$15152 = tDir;
								if (198555 - 404756 == -206201)
								{
									this.$self_$15153 = self_;
									if (236544 - 58358 != 178187)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600003C RID: 60 RVA: 0x00005FF8 File Offset: 0x000041F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (39211 - 279431 != -240220)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_400;
					case 2:
						if (this.$self_$15153.mChar.actionState == "attack")
						{
							if (153486 - 308395 != -154909)
							{
								continue;
							}
							if (this.$self_$15153.mChar.myCommand == "turnRight")
							{
								if (235614 - 316971 == -81356)
								{
									continue;
								}
								if (this.$tRotation$15150 == this.$self_$15153.transform.rotation)
								{
									if (265229 - 224334 != 40895)
									{
										continue;
									}
									this.$self_$15153.transform.Rotate((float)0, (float)60, (float)0);
									if (18726 - 180791 == -162064)
									{
										continue;
									}
								}
								this.$self_$15153.animation.Play("root");
								if (116117 - 440374 != -324257)
								{
									continue;
								}
								this.$self_$15153.animation.wrapMode = WrapMode.Loop;
								if (266271 - 114241 != 152030)
								{
									continue;
								}
								this.$self_$15153.mChar.actionState = "standby";
								if (227935 - 374035 != -146100)
								{
									continue;
								}
								this.$self_$15153.mChar.actionTime = Time.time;
								if (239305 - 13920 == 225386)
								{
									continue;
								}
								this.$self_$15153.mChar.myCommand = "none";
								if (82930 - 81026 == 1905)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (244165 - 421297 != -177132)
						{
							continue;
						}
						goto IL_400;
					default:
						if (55356 - 378664 != -323308)
						{
							continue;
						}
						break;
					}
					this.$self_$15153.mChar.actionState = "attack";
					if (91558 - 316384 != -224825)
					{
						this.$self_$15153.mChar.actionTime = Time.time;
						if (65087 - 263842 == -198755)
						{
							this.$self_$15153.mChar.myCommand = "turnRight";
							if (280692 - 329112 != -48419)
							{
								this.$self_$15153.mChar.addTimeOut("turnRight", (float)1);
								if (282099 - 104460 != 177640)
								{
									this.$self_$15153.transform.position = this.$mPos$15151;
									if (230434 - 584340 == -353906)
									{
										this.$self_$15153.transform.LookAt(this.$mPos$15151 + global::Math.vFlat(this.$tDir$15152));
										if (204502 - 266570 != -62067)
										{
											this.$self_$15153.animation.CrossFade("turnRight");
											if (168503 - 114039 != 54465)
											{
												this.$self_$15153.animation.wrapMode = WrapMode.Once;
												if (52916 - 569216 == -516300)
												{
													this.$tRotation$15150 = this.$self_$15153.transform.rotation;
													if (200927 - 431544 == -230617)
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
				return this.Yield(2, new WaitForSeconds(1.2f));
				IL_400:
				return false;
			}

			// Token: 0x0600003D RID: 61 RVA: 0x00006418 File Offset: 0x00004618
			internal static bool Y5Qljp27LsB1YxWCXx()
			{
				return true;
			}

			// Token: 0x0600003E RID: 62 RVA: 0x0000641C File Offset: 0x0000461C
			internal static bool K0lcCv8xEoehvdA0be()
			{
				return false;
			}

			// Token: 0x04000063 RID: 99
			internal Quaternion $tRotation$15150;

			// Token: 0x04000064 RID: 100
			internal Vector3 $mPos$15151;

			// Token: 0x04000065 RID: 101
			internal Vector3 $tDir$15152;

			// Token: 0x04000066 RID: 102
			internal AncientBug $self_$15153;
		}
	}

	// Token: 0x0200000D RID: 13
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_headSweep$15157 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00006420 File Offset: 0x00004620
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_headSweep$15157(Vector3 mPos, Vector3 tDir, AncientBug self_)
		{
			if (23455 - 88980 != -65525)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (2158 - 126112 != -123953)
				{
					base..ctor();
					if (266315 - 221484 == 44831)
					{
						this.$mPos$15166 = mPos;
						if (250000 - 138562 != 111439)
						{
							this.$tDir$15167 = tDir;
							if (205176 - 489217 == -284041)
							{
								this.$self_$15168 = self_;
								if (263023 - 532420 != -269396)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000064FC File Offset: 0x000046FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AncientBug.$RPC_headSweep$15157.$(this.$mPos$15166, this.$tDir$15167, this.$self_$15168);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00006518 File Offset: 0x00004718
		internal static bool PRIBmRZ0nY8ZU1ijk4()
		{
			return true;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000651C File Offset: 0x0000471C
		internal static bool G9d5bQCxCbgwM3kXM6()
		{
			return false;
		}

		// Token: 0x04000067 RID: 103
		internal Vector3 $mPos$15166;

		// Token: 0x04000068 RID: 104
		internal Vector3 $tDir$15167;

		// Token: 0x04000069 RID: 105
		internal AncientBug $self_$15168;

		// Token: 0x0200000E RID: 14
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000043 RID: 67 RVA: 0x00006520 File Offset: 0x00004720
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, AncientBug self_)
			{
				if (1600 - 484936 != -483335)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (57295 - 517569 == -460274)
					{
						base..ctor();
						if (282924 - 530396 != -247471)
						{
							this.$mPos$15163 = mPos;
							if (93231 - 496607 == -403376)
							{
								this.$tDir$15164 = tDir;
								if (216430 - 306367 != -89936)
								{
									this.$self_$15165 = self_;
									if (86016 - 336999 != -250982)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000044 RID: 68 RVA: 0x000065FC File Offset: 0x000047FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (146942 - 260250 != -113308)
				{
				}
				for (;;)
				{
					IL_5C2:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6AF;
					case 2:
						if (this.$self_$15165.mChar.actionState != "attack")
						{
							goto IL_556;
						}
						if (89950 - 581476 != -491526)
						{
							continue;
						}
						if (this.$self_$15165.mChar.myCommand != "headSweep")
						{
							if (6861 - 168317 != -161456)
							{
								continue;
							}
							goto IL_556;
						}
						else
						{
							this.$hitLayer$15158 = 130816 - (1 << this.$self_$15165.gameObject.layer);
							if (146392 - 412224 == -265831)
							{
								continue;
							}
							this.$hitList$15159 = null;
							if (206035 - 329426 == -123390)
							{
								continue;
							}
							this.$hitDamage$15160 = Mathf.FloorToInt((float)this.$self_$15165.mHeadChar.atk * (0.5f + 0.5f * (float)this.$self_$15165.mHeadChar.hp / (float)this.$self_$15165.mHeadChar.mhp));
							if (279935 - 471486 == -191550)
							{
								continue;
							}
							if (!this.$self_$15165.mChar.isMine)
							{
								goto IL_489;
							}
							if (32546 - 565398 == -532851)
							{
								continue;
							}
							this.$hitList$15159 = Damage.FindRecTarget(this.$self_$15165.transform.position, this.$self_$15165.transform.forward, (float)10, (float)10, (float)20, (float)5, this.$hitLayer$15158);
							if (268477 - 490756 == -222278)
							{
								continue;
							}
							this.$$iterator$9867$15162 = UnityRuntimeServices.GetEnumerator(this.$hitList$15159);
							if (241728 - 543138 != -301410)
							{
								continue;
							}
							while (this.$$iterator$9867$15162.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9867$15162.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15161 = (GameObject)obj2;
								if (59762 - 485325 == -425562)
								{
									goto IL_5C2;
								}
								this.$self_$15165.mChar.hit(99, this.$hitObject$15161, this.$hitDamage$15160, 1, 0, Vector3.zero);
								if (228473 - 25076 != 203397)
								{
									goto IL_5C2;
								}
								UnityRuntimeServices.Update(this.$$iterator$9867$15162, this.$hitObject$15161);
								if (272696 - 370269 == -97572)
								{
									goto IL_5C2;
								}
							}
							if (31 - 270783 != -270751)
							{
								goto IL_489;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15165.mChar.actionState == "attack")
						{
							if (129135 - 210160 == -81024)
							{
								continue;
							}
							if (this.$self_$15165.mChar.myCommand == "headSweep")
							{
								if (175892 - 245426 == -69533)
								{
									continue;
								}
								this.$self_$15165.animation.Play("root");
								if (294502 - 410767 == -116264)
								{
									continue;
								}
								this.$self_$15165.animation.wrapMode = WrapMode.Loop;
								if (68608 - 432410 == -363801)
								{
									continue;
								}
								this.$self_$15165.mChar.actionState = "standby";
								if (210240 - 504739 == -294498)
								{
									continue;
								}
								this.$self_$15165.mChar.actionTime = Time.time;
								if (243702 - 153806 != 89896)
								{
									continue;
								}
								this.$self_$15165.mChar.myCommand = "none";
								if (262236 - 442981 == -180744)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (72515 - 488265 != -415749)
						{
							goto Block_6;
						}
						continue;
					default:
						if (195179 - 462603 != -267424)
						{
							continue;
						}
						break;
					}
					this.$self_$15165.mChar.actionState = "attack";
					if (115105 - 396075 == -280970)
					{
						this.$self_$15165.mChar.actionTime = Time.time;
						if (170933 - 137207 != 33727)
						{
							this.$self_$15165.mChar.myCommand = "headSweep";
							if (81742 - 143269 != -61526)
							{
								this.$self_$15165.mChar.addTimeOut("thornSmash", (float)6);
								if (51126 - 241424 != -190297)
								{
									this.$self_$15165.transform.position = this.$mPos$15163;
									if (214805 - 358616 != -143810)
									{
										this.$self_$15165.transform.LookAt(this.$mPos$15163 + global::Math.vFlat(this.$tDir$15164));
										if (10082 - 508452 == -498370)
										{
											this.$self_$15165.animation.CrossFade("headSweep");
											if (279695 - 122369 != 157327)
											{
												this.$self_$15165.animation.wrapMode = WrapMode.Once;
												if (230882 - 183136 != 47747)
												{
													this.$self_$15165.mChar.vMovement = this.$self_$15165.transform.forward;
													if (164098 - 229341 == -65243)
													{
														this.$self_$15165.mChar.moveSpeed = (float)0;
														if (197477 - 63672 != 133806)
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
				return this.Yield(2, new WaitForSeconds(0.7f));
				Block_6:
				goto IL_6AF;
				IL_489:
				return this.Yield(3, new WaitForSeconds(1.1f));
				IL_556:
				IL_6AF:
				return false;
			}

			// Token: 0x06000045 RID: 69 RVA: 0x00006CCC File Offset: 0x00004ECC
			internal static bool gi7JKJLcWPhvkj01WA()
			{
				return true;
			}

			// Token: 0x06000046 RID: 70 RVA: 0x00006CD0 File Offset: 0x00004ED0
			internal static bool QDWBSxOduRywfEd9vv()
			{
				return false;
			}

			// Token: 0x0400006A RID: 106
			internal int $hitLayer$15158;

			// Token: 0x0400006B RID: 107
			internal UnityScript.Lang.Array $hitList$15159;

			// Token: 0x0400006C RID: 108
			internal int $hitDamage$15160;

			// Token: 0x0400006D RID: 109
			internal GameObject $hitObject$15161;

			// Token: 0x0400006E RID: 110
			internal IEnumerator $$iterator$9867$15162;

			// Token: 0x0400006F RID: 111
			internal Vector3 $mPos$15163;

			// Token: 0x04000070 RID: 112
			internal Vector3 $tDir$15164;

			// Token: 0x04000071 RID: 113
			internal AncientBug $self_$15165;
		}
	}

	// Token: 0x0200000F RID: 15
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_leftSweep$15169 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00006CD4 File Offset: 0x00004ED4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_leftSweep$15169(Vector3 mPos, Vector3 tDir, AncientBug self_)
		{
			if (44923 - 403607 != -358683)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (28074 - 369558 != -341483)
				{
					base..ctor();
					if (77059 - 562682 == -485623)
					{
						this.$mPos$15179 = mPos;
						if (140000 - 132300 != 7701)
						{
							this.$tDir$15180 = tDir;
							if (209978 - 285675 != -75696)
							{
								this.$self_$15181 = self_;
								if (163711 - 178761 == -15050)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00006DB0 File Offset: 0x00004FB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AncientBug.$RPC_leftSweep$15169.$(this.$mPos$15179, this.$tDir$15180, this.$self_$15181);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00006DCC File Offset: 0x00004FCC
		internal static bool M8tt6GmqGaiGd81vOG()
		{
			return true;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00006DD0 File Offset: 0x00004FD0
		internal static bool ay4TuUFfWh5LH9hTeZ()
		{
			return false;
		}

		// Token: 0x04000072 RID: 114
		internal Vector3 $mPos$15179;

		// Token: 0x04000073 RID: 115
		internal Vector3 $tDir$15180;

		// Token: 0x04000074 RID: 116
		internal AncientBug $self_$15181;

		// Token: 0x02000010 RID: 16
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600004B RID: 75 RVA: 0x00006DD4 File Offset: 0x00004FD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, AncientBug self_)
			{
				if (41458 - 500752 != -459293)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (184558 - 438647 == -254089)
					{
						base..ctor();
						if (270890 - 351984 != -81093)
						{
							this.$mPos$15176 = mPos;
							if (1153 - 410977 != -409823)
							{
								this.$tDir$15177 = tDir;
								if (129268 - 414086 != -284817)
								{
									this.$self_$15178 = self_;
									if (225141 - 505199 == -280058)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600004C RID: 76 RVA: 0x00006EB0 File Offset: 0x000050B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (169725 - 160556 != 9169)
				{
				}
				for (;;)
				{
					IL_5B4:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7A5;
					case 2:
						if (this.$self_$15178.mChar.actionState != "attack")
						{
							goto IL_45;
						}
						if (42312 - 174680 == -132367)
						{
							continue;
						}
						if (this.$self_$15178.mChar.myCommand != "leftSweep")
						{
							if (299655 - 5907 != 293749)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							this.$hitLayer$15170 = 130816 - (1 << this.$self_$15178.gameObject.layer);
							if (247976 - 319425 == -71448)
							{
								continue;
							}
							this.$hitList$15171 = null;
							if (294686 - 567622 != -272936)
							{
								continue;
							}
							this.$hitPos$15172 = this.$self_$15178.transform.position + this.$self_$15178.transform.forward;
							if (32779 - 208623 == -175843)
							{
								continue;
							}
							this.$hitDamage$15173 = Mathf.FloorToInt((float)this.$self_$15178.mLeftHandChar.atk * (0.5f + 0.5f * (float)this.$self_$15178.mLeftHandChar.hp / (float)this.$self_$15178.mLeftHandChar.mhp));
							if (239693 - 41147 != 198546)
							{
								continue;
							}
							if (!this.$self_$15178.mChar.isMine)
							{
								goto IL_1AF;
							}
							if (28179 - 364969 == -336789)
							{
								continue;
							}
							this.$hitList$15171 = Damage.FindRecTarget(this.$self_$15178.transform.position, this.$self_$15178.transform.forward, (float)10, (float)10, (float)20, (float)5, this.$hitLayer$15170);
							if (46522 - 226214 != -179692)
							{
								continue;
							}
							this.$$iterator$9868$15175 = UnityRuntimeServices.GetEnumerator(this.$hitList$15171);
							if (77366 - 592491 == -515124)
							{
								continue;
							}
							while (this.$$iterator$9868$15175.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9868$15175.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15174 = (GameObject)obj2;
								if (36128 - 286232 != -250104)
								{
									goto IL_5B4;
								}
								if (this.$self_$15178.mChar.hit(99, this.$hitObject$15174, this.$hitDamage$15173, 3, 0, (float)3 * this.$self_$15178.transform.forward) != 0)
								{
									if (209112 - 33784 != 175328)
									{
										goto IL_5B4;
									}
									this.$self_$15178.RPC_sweep_hit(this.$hitObject$15174.collider.bounds.center, this.$self_$15178.transform.forward, 0);
									if (108714 - 237516 == -128801)
									{
										goto IL_5B4;
									}
									UnityRuntimeServices.Update(this.$$iterator$9868$15175, this.$hitObject$15174);
									if (143150 - 404 == 142747)
									{
										goto IL_5B4;
									}
									this.$self_$15178.ActionEvent("RPC_sweep_hit", this.$hitObject$15174.collider.bounds.center, this.$self_$15178.transform.forward, 0);
									if (254699 - 370849 != -116150)
									{
										goto IL_5B4;
									}
									UnityRuntimeServices.Update(this.$$iterator$9868$15175, this.$hitObject$15174);
									if (107229 - 158337 != -51108)
									{
										goto IL_5B4;
									}
								}
							}
							if (33065 - 157903 != -124837)
							{
								goto Block_20;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15178.mChar.actionState == "attack")
						{
							if (89059 - 555245 == -466185)
							{
								continue;
							}
							if (this.$self_$15178.mChar.myCommand == "leftSweep")
							{
								if (234501 - 284446 == -49944)
								{
									continue;
								}
								this.$self_$15178.animation.Play("root");
								if (51717 - 133763 != -82046)
								{
									continue;
								}
								this.$self_$15178.animation.wrapMode = WrapMode.Loop;
								if (179892 - 439578 != -259686)
								{
									continue;
								}
								this.$self_$15178.mChar.actionState = "standby";
								if (62007 - 441647 == -379639)
								{
									continue;
								}
								this.$self_$15178.mChar.actionTime = Time.time;
								if (255098 - 378090 == -122991)
								{
									continue;
								}
								this.$self_$15178.mChar.myCommand = "none";
								if (12102 - 398963 == -386860)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (55048 - 436706 != -381658)
						{
							continue;
						}
						goto IL_7A5;
					default:
						if (295640 - 463942 != -168302)
						{
							continue;
						}
						break;
					}
					this.$self_$15178.mChar.actionState = "attack";
					if (251827 - 47890 == 203937)
					{
						this.$self_$15178.mChar.actionTime = Time.time;
						if (217731 - 175495 != 42237)
						{
							this.$self_$15178.mChar.myCommand = "leftSweep";
							if (117273 - 441166 != -323892)
							{
								this.$self_$15178.transform.position = this.$mPos$15176;
								if (191625 - 187759 == 3866)
								{
									this.$self_$15178.transform.LookAt(this.$mPos$15176 + global::Math.vFlat(this.$tDir$15177));
									if (6024 - 331175 != -325150)
									{
										this.$self_$15178.animation.CrossFade("leftSweep");
										if (95575 - 272770 != -177194)
										{
											this.$self_$15178.animation.wrapMode = WrapMode.Once;
											if (185042 - 433403 == -248361)
											{
												this.$self_$15178.mChar.vMovement = this.$self_$15178.transform.forward;
												if (103663 - 592450 == -488787)
												{
													this.$self_$15178.mChar.moveSpeed = (float)0;
													if (57183 - 459629 != -402445)
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
				IL_45:
				goto IL_7A5;
				IL_1AF:
				return this.Yield(3, new WaitForSeconds(0.9f));
				Block_16:
				return this.Yield(2, new WaitForSeconds(0.6f));
				Block_20:
				goto IL_1AF;
				Block_25:
				IL_7A5:
				return false;
			}

			// Token: 0x0600004D RID: 77 RVA: 0x00007674 File Offset: 0x00005874
			internal static bool d9wEwgMyjXPJiNAHBU()
			{
				return true;
			}

			// Token: 0x0600004E RID: 78 RVA: 0x00007678 File Offset: 0x00005878
			internal static bool MeAnwfxZvYiROubmpO()
			{
				return false;
			}

			// Token: 0x04000075 RID: 117
			internal int $hitLayer$15170;

			// Token: 0x04000076 RID: 118
			internal UnityScript.Lang.Array $hitList$15171;

			// Token: 0x04000077 RID: 119
			internal Vector3 $hitPos$15172;

			// Token: 0x04000078 RID: 120
			internal int $hitDamage$15173;

			// Token: 0x04000079 RID: 121
			internal GameObject $hitObject$15174;

			// Token: 0x0400007A RID: 122
			internal IEnumerator $$iterator$9868$15175;

			// Token: 0x0400007B RID: 123
			internal Vector3 $mPos$15176;

			// Token: 0x0400007C RID: 124
			internal Vector3 $tDir$15177;

			// Token: 0x0400007D RID: 125
			internal AncientBug $self_$15178;
		}
	}

	// Token: 0x02000011 RID: 17
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rightSweep$15182 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600004F RID: 79 RVA: 0x0000767C File Offset: 0x0000587C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rightSweep$15182(Vector3 mPos, Vector3 tDir, AncientBug self_)
		{
			if (200948 - 547987 != -347039)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (153888 - 541675 == -387787)
				{
					base..ctor();
					if (233820 - 469569 != -235748)
					{
						this.$mPos$15192 = mPos;
						if (202199 - 216159 == -13960)
						{
							this.$tDir$15193 = tDir;
							if (134229 - 316826 != -182596)
							{
								this.$self_$15194 = self_;
								if (78583 - 240203 != -161619)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00007758 File Offset: 0x00005958
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AncientBug.$RPC_rightSweep$15182.$(this.$mPos$15192, this.$tDir$15193, this.$self_$15194);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00007774 File Offset: 0x00005974
		internal static bool QaSn8Wgkm7AXmIBy9W()
		{
			return true;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00007778 File Offset: 0x00005978
		internal static bool Djqa7Pfp1XmWQmllhv()
		{
			return false;
		}

		// Token: 0x0400007E RID: 126
		internal Vector3 $mPos$15192;

		// Token: 0x0400007F RID: 127
		internal Vector3 $tDir$15193;

		// Token: 0x04000080 RID: 128
		internal AncientBug $self_$15194;

		// Token: 0x02000012 RID: 18
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000053 RID: 83 RVA: 0x0000777C File Offset: 0x0000597C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, AncientBug self_)
			{
				if (248324 - 593152 != -344828)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (39661 - 469318 == -429657)
					{
						base..ctor();
						if (173801 - 274528 == -100727)
						{
							this.$mPos$15189 = mPos;
							if (172938 - 291541 != -118602)
							{
								this.$tDir$15190 = tDir;
								if (86044 - 155334 != -69289)
								{
									this.$self_$15191 = self_;
									if (237016 - 540138 != -303121)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000054 RID: 84 RVA: 0x00007858 File Offset: 0x00005A58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (114278 - 201025 != -86747)
				{
				}
				for (;;)
				{
					IL_677:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7A5;
					case 2:
						if (this.$self_$15191.mChar.actionState != "attack")
						{
							goto IL_114;
						}
						if (125461 - 343028 == -217566)
						{
							continue;
						}
						if (this.$self_$15191.mChar.myCommand != "rightSweep")
						{
							if (10287 - 74175 != -63887)
							{
								goto Block_41;
							}
							continue;
						}
						else
						{
							this.$hitLayer$15183 = 130816 - (1 << this.$self_$15191.gameObject.layer);
							if (268011 - 503345 == -235333)
							{
								continue;
							}
							this.$hitList$15184 = null;
							if (257724 - 370830 != -113106)
							{
								continue;
							}
							this.$hitPos$15185 = this.$self_$15191.transform.position + this.$self_$15191.transform.forward;
							if (299182 - 159019 == 140164)
							{
								continue;
							}
							this.$hitDamage$15186 = Mathf.FloorToInt((float)this.$self_$15191.mRightHandChar.atk * (0.5f + 0.5f * (float)this.$self_$15191.mRightHandChar.hp / (float)this.$self_$15191.mRightHandChar.mhp));
							if (198054 - 137884 == 60171)
							{
								continue;
							}
							if (!this.$self_$15191.mChar.isMine)
							{
								goto IL_23A;
							}
							if (172828 - 127037 != 45791)
							{
								continue;
							}
							this.$hitList$15184 = Damage.FindRecTarget(this.$self_$15191.transform.position, this.$self_$15191.transform.forward, (float)10, (float)10, (float)20, (float)5, this.$hitLayer$15183);
							if (235567 - 329730 != -94163)
							{
								continue;
							}
							this.$$iterator$9869$15188 = UnityRuntimeServices.GetEnumerator(this.$hitList$15184);
							if (205939 - 156777 == 49163)
							{
								continue;
							}
							while (this.$$iterator$9869$15188.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9869$15188.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15187 = (GameObject)obj2;
								if (103797 - 53482 != 50315)
								{
									goto IL_677;
								}
								if (this.$self_$15191.mChar.hit(99, this.$hitObject$15187, this.$hitDamage$15186, 3, 0, (float)3 * this.$self_$15191.transform.forward) != 0)
								{
									if (162897 - 162298 == 600)
									{
										goto IL_677;
									}
									this.$self_$15191.RPC_sweep_hit(this.$hitObject$15187.collider.bounds.center, this.$self_$15191.transform.forward, 0);
									if (9739 - 319139 != -309400)
									{
										goto IL_677;
									}
									UnityRuntimeServices.Update(this.$$iterator$9869$15188, this.$hitObject$15187);
									if (6913 - 263912 == -256998)
									{
										goto IL_677;
									}
									this.$self_$15191.ActionEvent("RPC_sweep_hit", this.$hitObject$15187.collider.bounds.center, this.$self_$15191.transform.forward, 0);
									if (261165 - 549181 != -288016)
									{
										goto IL_677;
									}
									UnityRuntimeServices.Update(this.$$iterator$9869$15188, this.$hitObject$15187);
									if (192089 - 356670 == -164580)
									{
										goto IL_677;
									}
								}
							}
							if (90050 - 438429 != -348379)
							{
								continue;
							}
							goto IL_23A;
						}
						break;
					case 3:
						if (this.$self_$15191.mChar.actionState == "attack")
						{
							if (8025 - 579144 == -571118)
							{
								continue;
							}
							if (this.$self_$15191.mChar.myCommand == "rightSweep")
							{
								if (146129 - 416338 != -270209)
								{
									continue;
								}
								this.$self_$15191.animation.Play("root");
								if (137798 - 369892 != -232094)
								{
									continue;
								}
								this.$self_$15191.animation.wrapMode = WrapMode.Loop;
								if (266878 - 80814 == 186065)
								{
									continue;
								}
								this.$self_$15191.mChar.actionState = "standby";
								if (208144 - 415451 == -207306)
								{
									continue;
								}
								this.$self_$15191.mChar.actionTime = Time.time;
								if (169159 - 486058 == -316898)
								{
									continue;
								}
								this.$self_$15191.mChar.myCommand = "none";
								if (48039 - 271807 == -223767)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (98334 - 321494 != -223160)
						{
							continue;
						}
						goto IL_7A5;
					default:
						if (144073 - 132650 != 11423)
						{
							continue;
						}
						break;
					}
					this.$self_$15191.mChar.actionState = "attack";
					if (138397 - 313930 != -175532)
					{
						this.$self_$15191.mChar.actionTime = Time.time;
						if (12278 - 428123 != -415844)
						{
							this.$self_$15191.mChar.myCommand = "rightSweep";
							if (142131 - 382612 == -240481)
							{
								this.$self_$15191.transform.position = this.$mPos$15189;
								if (249257 - 535059 != -285801)
								{
									this.$self_$15191.transform.LookAt(this.$mPos$15189 + global::Math.vFlat(this.$tDir$15190));
									if (61914 - 283390 == -221476)
									{
										this.$self_$15191.animation.CrossFade("rightSweep");
										if (35487 - 304004 == -268517)
										{
											this.$self_$15191.animation.wrapMode = WrapMode.Once;
											if (89695 - 39138 == 50557)
											{
												this.$self_$15191.mChar.vMovement = this.$self_$15191.transform.forward;
												if (271194 - 589644 != -318449)
												{
													this.$self_$15191.mChar.moveSpeed = (float)0;
													if (248315 - 258968 != -10652)
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
				IL_114:
				goto IL_7A5;
				IL_23A:
				return this.Yield(3, new WaitForSeconds(0.9f));
				Block_39:
				return this.Yield(2, new WaitForSeconds(0.6f));
				Block_41:
				IL_7A5:
				return false;
			}

			// Token: 0x06000055 RID: 85 RVA: 0x0000801C File Offset: 0x0000621C
			internal static bool Ljw9wAnAqfvljDZiOn()
			{
				return true;
			}

			// Token: 0x06000056 RID: 86 RVA: 0x00008020 File Offset: 0x00006220
			internal static bool YWYTy46LC2OTmolikJ()
			{
				return false;
			}

			// Token: 0x04000081 RID: 129
			internal int $hitLayer$15183;

			// Token: 0x04000082 RID: 130
			internal UnityScript.Lang.Array $hitList$15184;

			// Token: 0x04000083 RID: 131
			internal Vector3 $hitPos$15185;

			// Token: 0x04000084 RID: 132
			internal int $hitDamage$15186;

			// Token: 0x04000085 RID: 133
			internal GameObject $hitObject$15187;

			// Token: 0x04000086 RID: 134
			internal IEnumerator $$iterator$9869$15188;

			// Token: 0x04000087 RID: 135
			internal Vector3 $mPos$15189;

			// Token: 0x04000088 RID: 136
			internal Vector3 $tDir$15190;

			// Token: 0x04000089 RID: 137
			internal AncientBug $self_$15191;
		}
	}

	// Token: 0x02000013 RID: 19
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_leftSmash$15195 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00008024 File Offset: 0x00006224
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_leftSmash$15195(Vector3 mPos, Vector3 tDir, AncientBug self_)
		{
			if (188735 - 25627 != 163109)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (25238 - 515312 == -490074)
				{
					base..ctor();
					if (9467 - 204979 == -195512)
					{
						this.$mPos$15207 = mPos;
						if (85366 - 532880 != -447513)
						{
							this.$tDir$15208 = tDir;
							if (214448 - 139804 != 74645)
							{
								this.$self_$15209 = self_;
								if (113384 - 79101 != 34284)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00008100 File Offset: 0x00006300
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AncientBug.$RPC_leftSmash$15195.$(this.$mPos$15207, this.$tDir$15208, this.$self_$15209);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000811C File Offset: 0x0000631C
		internal static bool W5PXiHiKxdCOn7WVHG()
		{
			return true;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00008120 File Offset: 0x00006320
		internal static bool e17anOKtU0ZPIkKjYO()
		{
			return false;
		}

		// Token: 0x0400008A RID: 138
		internal Vector3 $mPos$15207;

		// Token: 0x0400008B RID: 139
		internal Vector3 $tDir$15208;

		// Token: 0x0400008C RID: 140
		internal AncientBug $self_$15209;

		// Token: 0x02000014 RID: 20
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600005B RID: 91 RVA: 0x00008124 File Offset: 0x00006324
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, AncientBug self_)
			{
				if (78090 - 325920 != -247829)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (250749 - 336638 != -85888)
					{
						base..ctor();
						if (2598 - 74753 != -72154)
						{
							this.$mPos$15204 = mPos;
							if (299323 - 152740 == 146583)
							{
								this.$tDir$15205 = tDir;
								if (120256 - 582766 != -462509)
								{
									this.$self_$15206 = self_;
									if (26049 - 308872 == -282823)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600005C RID: 92 RVA: 0x00008200 File Offset: 0x00006400
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (51171 - 195743 != -144571)
				{
				}
				for (;;)
				{
					IL_14C:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_AA7;
					case 2:
						if (this.$self_$15206.mChar.actionState != "attack")
						{
							goto IL_711;
						}
						if (165066 - 135976 != 29090)
						{
							continue;
						}
						if (this.$self_$15206.mChar.myCommand != "leftSmash")
						{
							if (194412 - 569925 != -375512)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							this.$hitLayer$15196 = 130816 - (1 << this.$self_$15206.gameObject.layer);
							if (207553 - 137596 != 69957)
							{
								continue;
							}
							this.$hitList$15197 = null;
							if (74424 - 251449 != -177025)
							{
								continue;
							}
							this.$hitPos$15198 = this.$self_$15206.transform.position + this.$self_$15206.transform.TransformDirection((float)-4, (float)0, (float)10);
							if (253160 - 574000 != -320840)
							{
								continue;
							}
							this.$hitDamage$15199 = Mathf.FloorToInt(1.35f * (float)this.$self_$15206.mLeftHandChar.atk * (0.5f + 0.5f * (float)this.$self_$15206.mLeftHandChar.hp / (float)this.$self_$15206.mLeftHandChar.mhp));
							if (24230 - 564068 != -539838)
							{
								continue;
							}
							if (this.$self_$15206.mChar.isMine)
							{
								if (174538 - 551123 == -376584)
								{
									continue;
								}
								this.$hitList$15197 = Damage.FindAreaTarget(this.$hitPos$15198, (float)4, (float)6, this.$hitLayer$15196);
								if (236799 - 512151 == -275351)
								{
									continue;
								}
								this.$$iterator$9870$15201 = UnityRuntimeServices.GetEnumerator(this.$hitList$15197);
								if (56920 - 279742 == -222821)
								{
									continue;
								}
								while (this.$$iterator$9870$15201.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$9870$15201.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$15200 = (GameObject)obj2;
									if (148999 - 511276 != -362277)
									{
										goto IL_14C;
									}
									this.$self_$15206.mChar.hit(99, this.$hitObject$15200, this.$hitDamage$15199, 5, 0, (float)3 * global::Math.vFlat(this.$hitObject$15200.transform.position - this.$hitPos$15198).normalized);
									if (178889 - 482435 == -303545)
									{
										goto IL_14C;
									}
									UnityRuntimeServices.Update(this.$$iterator$9870$15201, this.$hitObject$15200);
									if (166088 - 83848 == 82241)
									{
										goto IL_14C;
									}
								}
								if (25489 - 175279 == -149789)
								{
									continue;
								}
							}
							if (this.$self_$15206.smashFx)
							{
								if (66672 - 111949 == -45276)
								{
									continue;
								}
								this.$self_$15206.audio.PlayOneShot(this.$self_$15206.smashFx);
								if (246447 - 485940 == -239492)
								{
									continue;
								}
							}
							Camera.main.SendMessage("AddCamereShake", 1.2f);
							if (23642 - 403787 != -380145)
							{
								continue;
							}
							goto IL_1B5;
						}
						break;
					case 3:
						if (this.$self_$15206.mChar.actionState != "attack")
						{
							goto IL_4A3;
						}
						if (107584 - 102859 != 4725)
						{
							continue;
						}
						if (this.$self_$15206.mChar.myCommand != "leftSmash")
						{
							if (185783 - 427023 != -241240)
							{
								continue;
							}
							goto IL_4A3;
						}
						else
						{
							if (!this.$self_$15206.mChar.isMine)
							{
								goto IL_389;
							}
							if (236919 - 42464 != 194455)
							{
								continue;
							}
							this.$hitList$15197 = Damage.FindRecTarget(this.$hitPos$15198, this.$self_$15206.transform.forward, (float)16, (float)24, (float)40, (float)5, this.$hitLayer$15196);
							if (29100 - 330687 == -301586)
							{
								continue;
							}
							this.$$iterator$9871$15203 = UnityRuntimeServices.GetEnumerator(this.$hitList$15197);
							if (263227 - 190838 == 72390)
							{
								continue;
							}
							while (this.$$iterator$9871$15203.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$9871$15203.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$15202 = (GameObject)obj4;
								if (234830 - 521888 == -287057)
								{
									goto IL_14C;
								}
								if (this.$self_$15206.mChar.hit(99, this.$hitObject$15202, this.$hitDamage$15199, 5, 0, (float)2 * global::Math.vFlat(this.$hitObject$15202.transform.position - this.$hitPos$15198).normalized) != 0)
								{
									if (223192 - 252519 != -29327)
									{
										goto IL_14C;
									}
									this.$self_$15206.RPC_smash_hit(this.$hitObject$15202.transform.position, this.$self_$15206.transform.forward, 0);
									if (183587 - 327715 != -144128)
									{
										goto IL_14C;
									}
									UnityRuntimeServices.Update(this.$$iterator$9871$15203, this.$hitObject$15202);
									if (74288 - 545161 == -470872)
									{
										goto IL_14C;
									}
									this.$self_$15206.ActionEvent("RPC_smash_hit", this.$hitObject$15202.transform.position, this.$self_$15206.transform.forward, 0);
									if (99650 - 183193 != -83543)
									{
										goto IL_14C;
									}
									UnityRuntimeServices.Update(this.$$iterator$9871$15203, this.$hitObject$15202);
									if (68568 - 91277 == -22708)
									{
										goto IL_14C;
									}
								}
							}
							if (46203 - 12423 != 33781)
							{
								goto Block_61;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$15206.mChar.actionState == "attack")
						{
							if (254711 - 347267 != -92556)
							{
								continue;
							}
							if (this.$self_$15206.mChar.myCommand == "leftSmash")
							{
								if (299512 - 571918 != -272406)
								{
									continue;
								}
								this.$self_$15206.animation.Play("root");
								if (215961 - 553795 == -337833)
								{
									continue;
								}
								this.$self_$15206.animation.wrapMode = WrapMode.Loop;
								if (77996 - 426722 == -348725)
								{
									continue;
								}
								this.$self_$15206.mChar.actionState = "standby";
								if (268897 - 494631 == -225733)
								{
									continue;
								}
								this.$self_$15206.mChar.actionTime = Time.time;
								if (283998 - 438902 != -154904)
								{
									continue;
								}
								this.$self_$15206.mChar.myCommand = "none";
								if (70212 - 24744 == 45469)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (178839 - 569370 != -390531)
						{
							continue;
						}
						goto IL_AA7;
					default:
						if (27284 - 244490 != -217206)
						{
							continue;
						}
						break;
					}
					this.$self_$15206.mChar.actionState = "attack";
					if (98221 - 14125 != 84097)
					{
						this.$self_$15206.mChar.actionTime = Time.time;
						if (253618 - 28767 == 224851)
						{
							this.$self_$15206.mChar.myCommand = "leftSmash";
							if (130549 - 545397 != -414847)
							{
								this.$self_$15206.mChar.addTimeOut("thornSmash", (float)6);
								if (86940 - 43229 == 43711)
								{
									this.$self_$15206.transform.position = this.$mPos$15204;
									if (220554 - 275281 != -54726)
									{
										this.$self_$15206.transform.LookAt(this.$mPos$15204 + global::Math.vFlat(this.$tDir$15205));
										if (282332 - 552493 == -270161)
										{
											this.$self_$15206.animation.CrossFade("leftSmash");
											if (30318 - 331734 != -301415)
											{
												this.$self_$15206.animation.wrapMode = WrapMode.Once;
												if (273314 - 22525 == 250789)
												{
													this.$self_$15206.mChar.vMovement = this.$self_$15206.transform.forward;
													if (47792 - 48577 == -785)
													{
														this.$self_$15206.mChar.moveSpeed = (float)0;
														if (124053 - 4782 == 119271)
														{
															goto IL_7A8;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_1B5:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_18:
				goto IL_711;
				IL_389:
				return this.Yield(4, new WaitForSeconds(1.7f));
				IL_4A3:
				IL_711:
				goto IL_AA7;
				IL_7A8:
				return this.Yield(2, new WaitForSeconds(1.2f));
				Block_61:
				goto IL_389;
				IL_AA7:
				return false;
			}

			// Token: 0x0600005D RID: 93 RVA: 0x00008CC8 File Offset: 0x00006EC8
			internal static bool zNWcmydCUWLx4vV2OT()
			{
				return true;
			}

			// Token: 0x0600005E RID: 94 RVA: 0x00008CCC File Offset: 0x00006ECC
			internal static bool ycoi2jJDuBMtikLFh3()
			{
				return false;
			}

			// Token: 0x0400008D RID: 141
			internal int $hitLayer$15196;

			// Token: 0x0400008E RID: 142
			internal UnityScript.Lang.Array $hitList$15197;

			// Token: 0x0400008F RID: 143
			internal Vector3 $hitPos$15198;

			// Token: 0x04000090 RID: 144
			internal int $hitDamage$15199;

			// Token: 0x04000091 RID: 145
			internal GameObject $hitObject$15200;

			// Token: 0x04000092 RID: 146
			internal IEnumerator $$iterator$9870$15201;

			// Token: 0x04000093 RID: 147
			internal GameObject $hitObject$15202;

			// Token: 0x04000094 RID: 148
			internal IEnumerator $$iterator$9871$15203;

			// Token: 0x04000095 RID: 149
			internal Vector3 $mPos$15204;

			// Token: 0x04000096 RID: 150
			internal Vector3 $tDir$15205;

			// Token: 0x04000097 RID: 151
			internal AncientBug $self_$15206;
		}
	}

	// Token: 0x02000015 RID: 21
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rightSmash$15210 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600005F RID: 95 RVA: 0x00008CD0 File Offset: 0x00006ED0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rightSmash$15210(Vector3 mPos, Vector3 tDir, AncientBug self_)
		{
			if (17926 - 235568 != -217641)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (275297 - 312480 != -37182)
				{
					base..ctor();
					if (152135 - 126604 == 25531)
					{
						this.$mPos$15222 = mPos;
						if (252764 - 454720 != -201955)
						{
							this.$tDir$15223 = tDir;
							if (189272 - 593596 == -404324)
							{
								this.$self_$15224 = self_;
								if (284258 - 174517 != 109742)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00008DAC File Offset: 0x00006FAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AncientBug.$RPC_rightSmash$15210.$(this.$mPos$15222, this.$tDir$15223, this.$self_$15224);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00008DC8 File Offset: 0x00006FC8
		internal static bool vP0sFpDt5AHc42aqhu()
		{
			return true;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00008DCC File Offset: 0x00006FCC
		internal static bool irD8DRv4hIEfcMMtC5()
		{
			return false;
		}

		// Token: 0x04000098 RID: 152
		internal Vector3 $mPos$15222;

		// Token: 0x04000099 RID: 153
		internal Vector3 $tDir$15223;

		// Token: 0x0400009A RID: 154
		internal AncientBug $self_$15224;

		// Token: 0x02000016 RID: 22
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000063 RID: 99 RVA: 0x00008DD0 File Offset: 0x00006FD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, AncientBug self_)
			{
				if (39830 - 340362 != -300532)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (242603 - 16677 != 225927)
					{
						base..ctor();
						if (215595 - 198658 != 16938)
						{
							this.$mPos$15219 = mPos;
							if (152160 - 587774 == -435614)
							{
								this.$tDir$15220 = tDir;
								if (129919 - 110998 == 18921)
								{
									this.$self_$15221 = self_;
									if (158726 - 5799 == 152927)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000064 RID: 100 RVA: 0x00008EAC File Offset: 0x000070AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (192360 - 24998 != 167362)
				{
				}
				for (;;)
				{
					IL_1C6:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_AA6;
					case 2:
						if (this.$self_$15221.mChar.actionState != "attack")
						{
							goto IL_6EA;
						}
						if (269889 - 530761 != -260872)
						{
							continue;
						}
						if (this.$self_$15221.mChar.myCommand != "rightSmash")
						{
							if (233423 - 193651 != 39772)
							{
								continue;
							}
							goto IL_6EA;
						}
						else
						{
							this.$hitLayer$15211 = 130816 - (1 << this.$self_$15221.gameObject.layer);
							if (278661 - 400959 == -122297)
							{
								continue;
							}
							this.$hitList$15212 = null;
							if (130029 - 505399 == -375369)
							{
								continue;
							}
							this.$hitPos$15213 = this.$self_$15221.transform.position + this.$self_$15221.transform.TransformDirection((float)4, (float)0, (float)10);
							if (284148 - 129147 != 155001)
							{
								continue;
							}
							this.$hitDamage$15214 = Mathf.FloorToInt(1.35f * (float)this.$self_$15221.mRightHandChar.atk * (0.5f + 0.5f * (float)this.$self_$15221.mRightHandChar.hp / (float)this.$self_$15221.mRightHandChar.mhp));
							if (291628 - 457523 != -165895)
							{
								continue;
							}
							if (this.$self_$15221.mChar.isMine)
							{
								if (76588 - 227626 == -151037)
								{
									continue;
								}
								this.$hitList$15212 = Damage.FindAreaTarget(this.$hitPos$15213, (float)4, (float)6, this.$hitLayer$15211);
								if (190331 - 138310 == 52022)
								{
									continue;
								}
								this.$$iterator$9872$15216 = UnityRuntimeServices.GetEnumerator(this.$hitList$15212);
								if (230548 - 119397 != 111151)
								{
									continue;
								}
								while (this.$$iterator$9872$15216.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$9872$15216.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$15215 = (GameObject)obj2;
									if (124106 - 179097 == -54990)
									{
										goto IL_1C6;
									}
									this.$self_$15221.mChar.hit(99, this.$hitObject$15215, this.$hitDamage$15214, 5, 0, (float)3 * global::Math.vFlat(this.$hitObject$15215.transform.position - this.$hitPos$15213).normalized);
									if (218902 - 546935 != -328033)
									{
										goto IL_1C6;
									}
									UnityRuntimeServices.Update(this.$$iterator$9872$15216, this.$hitObject$15215);
									if (267953 - 148111 != 119842)
									{
										goto IL_1C6;
									}
								}
								if (22109 - 482644 == -460534)
								{
									continue;
								}
							}
							if (this.$self_$15221.smashFx)
							{
								if (26065 - 549054 == -522988)
								{
									continue;
								}
								this.$self_$15221.audio.PlayOneShot(this.$self_$15221.smashFx);
								if (14834 - 548813 == -533978)
								{
									continue;
								}
							}
							Camera.main.SendMessage("AddCamereShake", 1.2f);
							if (290817 - 415713 != -124895)
							{
								goto Block_50;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15221.mChar.actionState != "attack")
						{
							goto IL_11C;
						}
						if (136495 - 518724 == -382228)
						{
							continue;
						}
						if (this.$self_$15221.mChar.myCommand != "rightSmash")
						{
							if (249428 - 259651 != -10223)
							{
								continue;
							}
							goto IL_11C;
						}
						else
						{
							if (!this.$self_$15221.mChar.isMine)
							{
								goto IL_CD;
							}
							if (209774 - 387771 == -177996)
							{
								continue;
							}
							this.$hitList$15212 = Damage.FindRecTarget(this.$hitPos$15213, this.$self_$15221.transform.forward, (float)16, (float)24, (float)40, (float)5, this.$hitLayer$15211);
							if (221491 - 160 != 221331)
							{
								continue;
							}
							this.$$iterator$9873$15218 = UnityRuntimeServices.GetEnumerator(this.$hitList$15212);
							if (140906 - 469017 == -328110)
							{
								continue;
							}
							while (this.$$iterator$9873$15218.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$9873$15218.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$15217 = (GameObject)obj4;
								if (288250 - 226119 == 62132)
								{
									goto IL_1C6;
								}
								if (this.$self_$15221.mChar.hit(99, this.$hitObject$15217, this.$hitDamage$15214, 5, 0, (float)2 * global::Math.vFlat(this.$hitObject$15217.transform.position - this.$hitPos$15213).normalized) != 0)
								{
									if (128615 - 194721 == -66105)
									{
										goto IL_1C6;
									}
									this.$self_$15221.RPC_smash_hit(this.$hitObject$15217.transform.position, this.$self_$15221.transform.forward, 0);
									if (240116 - 380622 != -140506)
									{
										goto IL_1C6;
									}
									UnityRuntimeServices.Update(this.$$iterator$9873$15218, this.$hitObject$15217);
									if (281684 - 35183 == 246502)
									{
										goto IL_1C6;
									}
									this.$self_$15221.ActionEvent("RPC_smash_hit", this.$hitObject$15217.transform.position, this.$self_$15221.transform.forward, 0);
									if (268493 - 531755 != -263262)
									{
										goto IL_1C6;
									}
									UnityRuntimeServices.Update(this.$$iterator$9873$15218, this.$hitObject$15217);
									if (80355 - 174920 != -94565)
									{
										goto IL_1C6;
									}
								}
							}
							if (199189 - 230372 != -31183)
							{
								continue;
							}
							goto IL_CD;
						}
						break;
					case 4:
						if (this.$self_$15221.mChar.actionState == "attack")
						{
							if (46942 - 182689 == -135746)
							{
								continue;
							}
							if (this.$self_$15221.mChar.myCommand == "rightSmash")
							{
								if (244463 - 336662 == -92198)
								{
									continue;
								}
								this.$self_$15221.animation.Play("root");
								if (90246 - 154768 == -64521)
								{
									continue;
								}
								this.$self_$15221.animation.wrapMode = WrapMode.Loop;
								if (150862 - 508079 != -357217)
								{
									continue;
								}
								this.$self_$15221.mChar.actionState = "standby";
								if (83779 - 85138 != -1359)
								{
									continue;
								}
								this.$self_$15221.mChar.actionTime = Time.time;
								if (160112 - 77620 != 82492)
								{
									continue;
								}
								this.$self_$15221.mChar.myCommand = "none";
								if (202483 - 103843 != 98640)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (39583 - 462416 != -422833)
						{
							continue;
						}
						goto IL_AA6;
					default:
						if (162228 - 2243 != 159985)
						{
							continue;
						}
						break;
					}
					this.$self_$15221.mChar.actionState = "attack";
					if (268892 - 50433 != 218460)
					{
						this.$self_$15221.mChar.actionTime = Time.time;
						if (41419 - 232164 == -190745)
						{
							this.$self_$15221.mChar.myCommand = "rightSmash";
							if (218753 - 209297 != 9457)
							{
								this.$self_$15221.mChar.addTimeOut("thornSmash", (float)3);
								if (164851 - 252849 != -87997)
								{
									this.$self_$15221.transform.position = this.$mPos$15219;
									if (223892 - 190600 != 33293)
									{
										this.$self_$15221.transform.LookAt(this.$mPos$15219 + global::Math.vFlat(this.$tDir$15220));
										if (183439 - 194326 != -10886)
										{
											this.$self_$15221.animation.CrossFade("rightSmash");
											if (78498 - 356910 == -278412)
											{
												this.$self_$15221.animation.wrapMode = WrapMode.Once;
												if (126488 - 476288 == -349800)
												{
													this.$self_$15221.mChar.vMovement = this.$self_$15221.transform.forward;
													if (11961 - 72579 != -60617)
													{
														this.$self_$15221.mChar.moveSpeed = (float)0;
														if (164287 - 112231 != 52057)
														{
															goto Block_17;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_CD:
				return this.Yield(4, new WaitForSeconds(1.7f));
				IL_11C:
				goto IL_AA6;
				Block_17:
				return this.Yield(2, new WaitForSeconds(1.2f));
				IL_6EA:
				goto IL_AA6;
				Block_50:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_AA6:
				return false;
			}

			// Token: 0x06000065 RID: 101 RVA: 0x00009974 File Offset: 0x00007B74
			internal static bool HjOO6BRImbu9EyuInK()
			{
				return true;
			}

			// Token: 0x06000066 RID: 102 RVA: 0x00009978 File Offset: 0x00007B78
			internal static bool TyKrSUwI3rY5jZlvwZ()
			{
				return false;
			}

			// Token: 0x0400009B RID: 155
			internal int $hitLayer$15211;

			// Token: 0x0400009C RID: 156
			internal UnityScript.Lang.Array $hitList$15212;

			// Token: 0x0400009D RID: 157
			internal Vector3 $hitPos$15213;

			// Token: 0x0400009E RID: 158
			internal int $hitDamage$15214;

			// Token: 0x0400009F RID: 159
			internal GameObject $hitObject$15215;

			// Token: 0x040000A0 RID: 160
			internal IEnumerator $$iterator$9872$15216;

			// Token: 0x040000A1 RID: 161
			internal GameObject $hitObject$15217;

			// Token: 0x040000A2 RID: 162
			internal IEnumerator $$iterator$9873$15218;

			// Token: 0x040000A3 RID: 163
			internal Vector3 $mPos$15219;

			// Token: 0x040000A4 RID: 164
			internal Vector3 $tDir$15220;

			// Token: 0x040000A5 RID: 165
			internal AncientBug $self_$15221;
		}
	}

	// Token: 0x02000017 RID: 23
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_bodySmash$15225 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000067 RID: 103 RVA: 0x0000997C File Offset: 0x00007B7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_bodySmash$15225(Vector3 mPos, Vector3 tDir, AncientBug self_)
		{
			if (105905 - 128615 != -22709)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (269628 - 167379 != 102250)
				{
					base..ctor();
					if (68871 - 277978 != -209106)
					{
						this.$mPos$15233 = mPos;
						if (178737 - 321912 != -143174)
						{
							this.$tDir$15234 = tDir;
							if (175686 - 80861 != 94826)
							{
								this.$self_$15235 = self_;
								if (27023 - 508756 != -481732)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00009A58 File Offset: 0x00007C58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AncientBug.$RPC_bodySmash$15225.$(this.$mPos$15233, this.$tDir$15234, this.$self_$15235);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00009A74 File Offset: 0x00007C74
		internal static bool YL8b21qSoA6wegyKfR()
		{
			return true;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00009A78 File Offset: 0x00007C78
		internal static bool X7BWwW7F2K889okRDk()
		{
			return false;
		}

		// Token: 0x040000A6 RID: 166
		internal Vector3 $mPos$15233;

		// Token: 0x040000A7 RID: 167
		internal Vector3 $tDir$15234;

		// Token: 0x040000A8 RID: 168
		internal AncientBug $self_$15235;

		// Token: 0x02000018 RID: 24
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600006B RID: 107 RVA: 0x00009A7C File Offset: 0x00007C7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, AncientBug self_)
			{
				if (241731 - 575046 != -333315)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (278105 - 65315 != 212791)
					{
						base..ctor();
						if (82469 - 82602 != -132)
						{
							this.$mPos$15230 = mPos;
							if (17943 - 422307 == -404364)
							{
								this.$tDir$15231 = tDir;
								if (248469 - 387759 != -139289)
								{
									this.$self_$15232 = self_;
									if (159936 - 235855 != -75918)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600006C RID: 108 RVA: 0x00009B58 File Offset: 0x00007D58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (83406 - 137454 != -54048)
				{
				}
				for (;;)
				{
					IL_1CC:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_73A;
					case 2:
						if (this.$self_$15232.mChar.actionState != "attack")
						{
							goto IL_498;
						}
						if (115748 - 579911 != -464163)
						{
							continue;
						}
						if (this.$self_$15232.mChar.myCommand != "bodySmash")
						{
							if (14636 - 158704 != -144068)
							{
								continue;
							}
							goto IL_498;
						}
						else
						{
							UnityEngine.Object.Instantiate(this.$self_$15232.bodySmash, this.$self_$15232.transform.position - this.$self_$15232.transform.forward, Quaternion.identity);
							if (185838 - 281824 != -95986)
							{
								continue;
							}
							goto IL_93;
						}
						break;
					case 3:
						if (this.$self_$15232.mChar.actionState != "attack")
						{
							goto IL_4F2;
						}
						if (216058 - 301272 != -85214)
						{
							continue;
						}
						if (this.$self_$15232.mChar.myCommand != "bodySmash")
						{
							if (160503 - 463801 != -303297)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							this.$hitLayer$15226 = 130816 - (1 << this.$self_$15232.gameObject.layer);
							if (43587 - 57696 == -14108)
							{
								continue;
							}
							this.$hitList$15227 = null;
							if (136418 - 515992 != -379574)
							{
								continue;
							}
							if (!this.$self_$15232.mChar.isMine)
							{
								goto IL_5B0;
							}
							if (182357 - 392876 == -210518)
							{
								continue;
							}
							this.$hitList$15227 = Damage.FindAreaTarget(this.$self_$15232.transform.position - this.$self_$15232.transform.forward, (float)10, (float)6, this.$hitLayer$15226);
							if (297831 - 304299 == -6467)
							{
								continue;
							}
							this.$$iterator$9874$15229 = UnityRuntimeServices.GetEnumerator(this.$hitList$15227);
							if (280326 - 83092 == 197235)
							{
								continue;
							}
							while (this.$$iterator$9874$15229.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9874$15229.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15228 = (GameObject)obj2;
								if (242330 - 340900 == -98569)
								{
									goto IL_1CC;
								}
								this.$self_$15232.mChar.hit(99, this.$hitObject$15228, this.$self_$15232.mChar.atk, 16, 0, Vector3.zero);
								if (39708 - 379345 == -339636)
								{
									goto IL_1CC;
								}
								UnityRuntimeServices.Update(this.$$iterator$9874$15229, this.$hitObject$15228);
								if (189667 - 345721 != -156054)
								{
									goto IL_1CC;
								}
							}
							if (52162 - 165558 != -113396)
							{
								continue;
							}
							goto IL_5B0;
						}
						break;
					case 4:
						if (this.$self_$15232.mChar.actionState == "attack")
						{
							if (174379 - 378621 != -204242)
							{
								continue;
							}
							if (this.$self_$15232.mChar.myCommand == "bodySmash")
							{
								if (221110 - 160428 != 60682)
								{
									continue;
								}
								this.$self_$15232.animation.Play("root");
								if (35270 - 489225 != -453955)
								{
									continue;
								}
								this.$self_$15232.animation.wrapMode = WrapMode.Loop;
								if (114382 - 435372 == -320989)
								{
									continue;
								}
								this.$self_$15232.mChar.actionState = "standby";
								if (155309 - 149235 != 6074)
								{
									continue;
								}
								this.$self_$15232.mChar.actionTime = Time.time;
								if (249672 - 262140 != -12468)
								{
									continue;
								}
								this.$self_$15232.mChar.myCommand = "none";
								if (74968 - 309498 == -234529)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (125598 - 369303 != -243704)
						{
							goto Block_31;
						}
						continue;
					default:
						if (52077 - 36073 != 16004)
						{
							continue;
						}
						break;
					}
					this.$self_$15232.mChar.actionState = "attack";
					if (225121 - 257956 != -32834)
					{
						this.$self_$15232.mChar.actionTime = Time.time;
						if (5971 - 38050 != -32078)
						{
							this.$self_$15232.mChar.myCommand = "bodySmash";
							if (109311 - 367639 != -258327)
							{
								this.$self_$15232.mChar.addTimeOut("bodySmash", (float)12);
								if (240662 - 402093 != -161430)
								{
									this.$self_$15232.transform.position = this.$mPos$15230;
									if (57005 - 55501 == 1504)
									{
										this.$self_$15232.transform.LookAt(this.$mPos$15230 + global::Math.vFlat(this.$tDir$15231));
										if (167280 - 351708 == -184428)
										{
											this.$self_$15232.animation.CrossFade("bodySmash");
											if (194062 - 494497 == -300435)
											{
												this.$self_$15232.animation.wrapMode = WrapMode.Once;
												if (259468 - 423401 != -163932)
												{
													this.$self_$15232.mChar.vMovement = this.$self_$15232.transform.forward;
													if (84597 - 508941 == -424344)
													{
														this.$self_$15232.mChar.moveSpeed = (float)0;
														if (241310 - 2781 != 238530)
														{
															goto Block_9;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_93:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_9:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_23:
				IL_498:
				IL_4F2:
				Block_31:
				goto IL_73A;
				IL_5B0:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_73A:
				return false;
			}

			// Token: 0x0600006D RID: 109 RVA: 0x0000A2B4 File Offset: 0x000084B4
			internal static bool CDem2EPnHoHa1Y7ZIf()
			{
				return true;
			}

			// Token: 0x0600006E RID: 110 RVA: 0x0000A2B8 File Offset: 0x000084B8
			internal static bool f6ib2M0J4tmNtQ4Do8()
			{
				return false;
			}

			// Token: 0x040000A9 RID: 169
			internal int $hitLayer$15226;

			// Token: 0x040000AA RID: 170
			internal UnityScript.Lang.Array $hitList$15227;

			// Token: 0x040000AB RID: 171
			internal GameObject $hitObject$15228;

			// Token: 0x040000AC RID: 172
			internal IEnumerator $$iterator$9874$15229;

			// Token: 0x040000AD RID: 173
			internal Vector3 $mPos$15230;

			// Token: 0x040000AE RID: 174
			internal Vector3 $tDir$15231;

			// Token: 0x040000AF RID: 175
			internal AncientBug $self_$15232;
		}
	}

	// Token: 0x02000019 RID: 25
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_headPoison$15236 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600006F RID: 111 RVA: 0x0000A2BC File Offset: 0x000084BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_headPoison$15236(Vector3 mPos, Vector3 tDir, AncientBug self_)
		{
			if (91429 - 311937 != -220508)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (232125 - 377354 == -145229)
				{
					base..ctor();
					if (211748 - 487787 == -276039)
					{
						this.$mPos$15249 = mPos;
						if (190972 - 373218 != -182245)
						{
							this.$tDir$15250 = tDir;
							if (165394 - 364691 == -199297)
							{
								this.$self_$15251 = self_;
								if (184920 - 16235 == 168685)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000A398 File Offset: 0x00008598
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AncientBug.$RPC_headPoison$15236.$(this.$mPos$15249, this.$tDir$15250, this.$self_$15251);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000A3B4 File Offset: 0x000085B4
		internal static bool WMGrUubqUqRlJ4FFd1()
		{
			return true;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000A3B8 File Offset: 0x000085B8
		internal static bool NndOWKueXTqUE2ucCV()
		{
			return false;
		}

		// Token: 0x040000B0 RID: 176
		internal Vector3 $mPos$15249;

		// Token: 0x040000B1 RID: 177
		internal Vector3 $tDir$15250;

		// Token: 0x040000B2 RID: 178
		internal AncientBug $self_$15251;

		// Token: 0x0200001A RID: 26
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000073 RID: 115 RVA: 0x0000A3BC File Offset: 0x000085BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, AncientBug self_)
			{
				if (263164 - 51419 != 211745)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (253209 - 413152 != -159942)
					{
						base..ctor();
						if (278235 - 377558 != -99322)
						{
							this.$mPos$15246 = mPos;
							if (259424 - 214541 != 44884)
							{
								this.$tDir$15247 = tDir;
								if (76910 - 367480 != -290569)
								{
									this.$self_$15248 = self_;
									if (61909 - 298938 == -237029)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000074 RID: 116 RVA: 0x0000A498 File Offset: 0x00008698
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (283778 - 571826 != -288047)
				{
				}
				for (;;)
				{
					IL_758:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A7A;
					case 2:
						if (this.$self_$15248.mChar.actionState != "attack")
						{
							goto IL_47B;
						}
						if (64799 - 129850 == -65050)
						{
							continue;
						}
						if (this.$self_$15248.mChar.myCommand != "headPoison")
						{
							if (207143 - 513217 != -306073)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							this.$mHeadCharObject$15237 = this.$self_$15248.mHeadChar.gameObject;
							if (34107 - 422486 != -388379)
							{
								continue;
							}
							this.$mHeadCharPoison$15238 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$15248.headPoison, Vector3.zero, Quaternion.identity);
							if (83850 - 331238 != -247388)
							{
								continue;
							}
							this.$mHeadCharPoison$15238.transform.parent = this.$mHeadCharObject$15237.transform;
							if (26421 - 136444 == -110022)
							{
								continue;
							}
							this.$mHeadCharPoison$15238.transform.localPosition = new Vector3(-3.6f, (float)0, (float)0);
							if (257152 - 344157 == -87004)
							{
								continue;
							}
							this.$mHeadCharPoison$15238.transform.localRotation = Quaternion.Euler((float)0, (float)270, (float)0);
							if (56624 - 355063 == -298438)
							{
								continue;
							}
							this.$mHeadCharPoison$15238.transform.localScale = new Vector3((float)1, (float)1, (float)1);
							if (49057 - 353369 != -304312)
							{
								continue;
							}
							goto IL_65F;
						}
						break;
					case 3:
						if (this.$self_$15248.mChar.actionState != "attack")
						{
							goto IL_71B;
						}
						if (71307 - 567762 != -496455)
						{
							continue;
						}
						if (this.$self_$15248.mChar.myCommand != "headPoison")
						{
							if (3475 - 574412 != -570936)
							{
								goto Block_59;
							}
							continue;
						}
						else
						{
							this.$hitLayer$15239 = 130816 - (1 << this.$self_$15248.gameObject.layer);
							if (29592 - 383100 != -353508)
							{
								continue;
							}
							this.$hitList$15240 = null;
							if (144268 - 240828 != -96560)
							{
								continue;
							}
							this.$hitDamage$15241 = Mathf.FloorToInt((float)this.$self_$15248.mHeadChar.atk * (0.5f + 0.5f * (float)this.$self_$15248.mHeadChar.hp / (float)this.$self_$15248.mHeadChar.mhp));
							if (241489 - 198334 == 43156)
							{
								continue;
							}
							if (!this.$self_$15248.mChar.isMine)
							{
								goto IL_42C;
							}
							if (51156 - 281095 == -229938)
							{
								continue;
							}
							this.$hitList$15240 = Damage.FindRecTarget(this.$self_$15248.transform.position + (float)6 * this.$self_$15248.transform.forward, this.$self_$15248.transform.forward, (float)16, (float)24, (float)40, (float)5, this.$hitLayer$15239);
							if (253685 - 472898 != -219213)
							{
								continue;
							}
							this.$$iterator$9875$15245 = UnityRuntimeServices.GetEnumerator(this.$hitList$15240);
							if (143989 - 278304 != -134315)
							{
								continue;
							}
							while (this.$$iterator$9875$15245.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9875$15245.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15242 = (GameObject)obj2;
								if (90152 - 486734 != -396582)
								{
									goto IL_758;
								}
								if (this.$self_$15248.mChar.hit(99, this.$hitObject$15242, this.$hitDamage$15241, 3, 0, Vector3.zero) != 0)
								{
									if (282538 - 480291 == -197752)
									{
										goto IL_758;
									}
									this.$tChar$15243 = (CharacterControl)this.$hitObject$15242.GetComponent(typeof(CharacterControl));
									if (86389 - 273368 == -186978)
									{
										goto IL_758;
									}
									UnityRuntimeServices.Update(this.$$iterator$9875$15245, this.$hitObject$15242);
									if (103876 - 491944 != -388068)
									{
										goto IL_758;
									}
									if (this.$tChar$15243)
									{
										if (52384 - 201435 != -149051)
										{
											goto IL_758;
										}
										if (this.$self_$15248.mChar.isMine)
										{
											if (281698 - 152091 != 129607)
											{
												goto IL_758;
											}
											this.$$switch$783$15244 = this.$self_$15248.mType;
											if (242018 - 113409 != 128609)
											{
												goto IL_758;
											}
											if (this.$$switch$783$15244 == eAncientBugType.AncientBug)
											{
												if (254833 - 131298 == 123536)
												{
													goto IL_758;
												}
												this.$tChar$15243.RPC_AddStatus("poison", 4, Damage.getDebuff((float)30, this.$self_$15248.mHeadChar.cha, this.$tChar$15243.cha), 0, this.$self_$15248.mHeadChar.ActorNr);
												if (149167 - 34022 == 115146)
												{
													goto IL_758;
												}
											}
											else if (this.$$switch$783$15244 == eAncientBugType.AncientBug2)
											{
												if (30519 - 123431 == -92911)
												{
													goto IL_758;
												}
												this.$tChar$15243.RPC_AddStatus("doom", 3, Damage.getDebuff((float)60, this.$tChar$15243.cha, this.$self_$15248.mChar.cha), 0, this.$self_$15248.mHeadChar.ActorNr);
												if (185966 - 515765 == -329798)
												{
													goto IL_758;
												}
											}
										}
									}
								}
							}
							if (157941 - 371924 != -213983)
							{
								continue;
							}
							goto IL_42C;
						}
						break;
					case 4:
						if (this.$self_$15248.mChar.actionState == "attack")
						{
							if (128178 - 519167 == -390988)
							{
								continue;
							}
							if (this.$self_$15248.mChar.myCommand == "headPoison")
							{
								if (253882 - 440829 != -186947)
								{
									continue;
								}
								this.$self_$15248.animation.Play("root");
								if (97902 - 389817 == -291914)
								{
									continue;
								}
								this.$self_$15248.animation.wrapMode = WrapMode.Loop;
								if (287375 - 596074 != -308699)
								{
									continue;
								}
								this.$self_$15248.mChar.actionState = "standby";
								if (168246 - 399936 != -231690)
								{
									continue;
								}
								this.$self_$15248.mChar.actionTime = Time.time;
								if (116171 - 231547 != -115376)
								{
									continue;
								}
								this.$self_$15248.mChar.myCommand = "none";
								if (219220 - 473404 != -254184)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (181089 - 405383 != -224294)
						{
							continue;
						}
						goto IL_A7A;
					default:
						if (186191 - 110085 != 76106)
						{
							continue;
						}
						break;
					}
					this.$self_$15248.mChar.actionState = "attack";
					if (110726 - 487616 != -376889)
					{
						this.$self_$15248.mChar.actionTime = Time.time;
						if (35698 - 387512 != -351813)
						{
							this.$self_$15248.mChar.myCommand = "headPoison";
							if (34014 - 412822 != -378807)
							{
								this.$self_$15248.mChar.addTimeOut("headPoison", (float)60);
								if (19507 - 133726 == -114219)
								{
									this.$self_$15248.transform.position = this.$mPos$15246;
									if (207918 - 327423 == -119505)
									{
										this.$self_$15248.transform.LookAt(this.$mPos$15246 + global::Math.vFlat(this.$tDir$15247));
										if (75461 - 348305 == -272844)
										{
											this.$self_$15248.animation.CrossFade("headPoison");
											if (289978 - 338615 == -48637)
											{
												this.$self_$15248.animation.wrapMode = WrapMode.Once;
												if (19169 - 263349 == -244180)
												{
													this.$self_$15248.mChar.vMovement = this.$self_$15248.transform.forward;
													if (138756 - 438287 != -299530)
													{
														this.$self_$15248.mChar.moveSpeed = (float)0;
														if (184513 - 499489 != -314975)
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
				return this.Yield(2, new WaitForSeconds(1f));
				Block_28:
				goto IL_47B;
				IL_42C:
				return this.Yield(4, new WaitForSeconds(0.8f));
				IL_47B:
				goto IL_A7A;
				IL_65F:
				return this.Yield(3, new WaitForSeconds((float)1));
				IL_71B:
				Block_59:
				IL_A7A:
				return false;
			}

			// Token: 0x06000075 RID: 117 RVA: 0x0000AF34 File Offset: 0x00009134
			internal static bool HnxFHsI78rfkCJj722()
			{
				return true;
			}

			// Token: 0x06000076 RID: 118 RVA: 0x0000AF38 File Offset: 0x00009138
			internal static bool TohYogBILqlrFGBm9f()
			{
				return false;
			}

			// Token: 0x040000B3 RID: 179
			internal GameObject $mHeadCharObject$15237;

			// Token: 0x040000B4 RID: 180
			internal GameObject $mHeadCharPoison$15238;

			// Token: 0x040000B5 RID: 181
			internal int $hitLayer$15239;

			// Token: 0x040000B6 RID: 182
			internal UnityScript.Lang.Array $hitList$15240;

			// Token: 0x040000B7 RID: 183
			internal int $hitDamage$15241;

			// Token: 0x040000B8 RID: 184
			internal GameObject $hitObject$15242;

			// Token: 0x040000B9 RID: 185
			internal CharacterControl $tChar$15243;

			// Token: 0x040000BA RID: 186
			internal eAncientBugType $$switch$783$15244;

			// Token: 0x040000BB RID: 187
			internal IEnumerator $$iterator$9875$15245;

			// Token: 0x040000BC RID: 188
			internal Vector3 $mPos$15246;

			// Token: 0x040000BD RID: 189
			internal Vector3 $tDir$15247;

			// Token: 0x040000BE RID: 190
			internal AncientBug $self_$15248;
		}
	}

	// Token: 0x0200001B RID: 27
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_thornStrike$15252 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000077 RID: 119 RVA: 0x0000AF3C File Offset: 0x0000913C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_thornStrike$15252(Vector3 mPos, Vector3 tDir, AncientBug self_)
		{
			if (268616 - 486814 != -218197)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (241015 - 546228 == -305213)
				{
					base..ctor();
					if (148350 - 540038 == -391688)
					{
						this.$mPos$15262 = mPos;
						if (63289 - 573748 != -510458)
						{
							this.$tDir$15263 = tDir;
							if (87605 - 265030 != -177424)
							{
								this.$self_$15264 = self_;
								if (25323 - 188838 == -163515)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000B018 File Offset: 0x00009218
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AncientBug.$RPC_thornStrike$15252.$(this.$mPos$15262, this.$tDir$15263, this.$self_$15264);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000B034 File Offset: 0x00009234
		internal static bool QgIj1uemum8k92u5iL()
		{
			return true;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000B038 File Offset: 0x00009238
		internal static bool oZFqbXr89rfimVG7Di()
		{
			return false;
		}

		// Token: 0x040000BF RID: 191
		internal Vector3 $mPos$15262;

		// Token: 0x040000C0 RID: 192
		internal Vector3 $tDir$15263;

		// Token: 0x040000C1 RID: 193
		internal AncientBug $self_$15264;

		// Token: 0x0200001C RID: 28
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600007B RID: 123 RVA: 0x0000B03C File Offset: 0x0000923C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, AncientBug self_)
			{
				if (219563 - 87892 != 131672)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (22951 - 173474 != -150522)
					{
						base..ctor();
						if (197083 - 49918 != 147166)
						{
							this.$mPos$15259 = mPos;
							if (65789 - 592975 != -527185)
							{
								this.$tDir$15260 = tDir;
								if (177272 - 336280 == -159008)
								{
									this.$self_$15261 = self_;
									if (80269 - 592353 != -512083)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600007C RID: 124 RVA: 0x0000B118 File Offset: 0x00009318
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (231951 - 264547 != -32596)
				{
				}
				for (;;)
				{
					IL_CA:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7C1;
					case 2:
						if (this.$self_$15261.mChar.actionState != "attack")
						{
							goto IL_513;
						}
						if (163183 - 139904 != 23279)
						{
							continue;
						}
						if (this.$self_$15261.mChar.myCommand != "thornStrike")
						{
							if (194190 - 110564 != 83627)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$hitLayer$15253 = 130816 - (1 << this.$self_$15261.gameObject.layer);
							if (291902 - 579637 != -287735)
							{
								continue;
							}
							this.$hitList$15254 = null;
							if (211373 - 572242 != -360869)
							{
								continue;
							}
							this.$hitDamage$15255 = this.$self_$15261.mHeadChar.talAdjust(Mathf.FloorToInt((float)(100 + 100 * this.$self_$15261.mHeadChar.hp / this.$self_$15261.mHeadChar.mhp)));
							if (170663 - 524833 == -354169)
							{
								continue;
							}
							this.$hitCount$15256 = 0;
							if (24702 - 347333 == -322630)
							{
								continue;
							}
							if (!this.$self_$15261.mChar.isMine)
							{
								goto IL_718;
							}
							if (7535 - 415596 == -408060)
							{
								continue;
							}
							this.$hitList$15254 = Damage.FindAreaTarget(this.$self_$15261.transform.position, (float)60, (float)6, this.$hitLayer$15253);
							if (237481 - 441600 != -204119)
							{
								continue;
							}
							this.$$iterator$9876$15258 = UnityRuntimeServices.GetEnumerator(this.$hitList$15254);
							if (165003 - 268206 != -103203)
							{
								continue;
							}
							while (this.$$iterator$9876$15258.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9876$15258.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15257 = (GameObject)obj2;
								if (89683 - 401061 != -311378)
								{
									goto IL_CA;
								}
								if (this.$hitCount$15256 < 6)
								{
									if (249335 - 388997 != -139662)
									{
										goto IL_CA;
									}
									if (this.$self_$15261.mChar.hit(99, this.$hitObject$15257, this.$hitDamage$15255, 20, 0, Vector3.zero) != 0)
									{
										if (191012 - 204416 != -13404)
										{
											goto IL_CA;
										}
										this.$hitCount$15256++;
										if (69084 - 233905 == -164820)
										{
											goto IL_CA;
										}
										this.$self_$15261.RPC_thornStrike_hit(this.$hitObject$15257.transform.position, this.$self_$15261.transform.forward, 0);
										if (150521 - 91421 != 59100)
										{
											goto IL_CA;
										}
										UnityRuntimeServices.Update(this.$$iterator$9876$15258, this.$hitObject$15257);
										if (4822 - 23513 == -18690)
										{
											goto IL_CA;
										}
										this.$self_$15261.ActionEvent("RPC_thornStrike_hit", this.$hitObject$15257.transform.position, this.$self_$15261.transform.forward, 0);
										if (215991 - 190787 == 25205)
										{
											goto IL_CA;
										}
										UnityRuntimeServices.Update(this.$$iterator$9876$15258, this.$hitObject$15257);
										if (221133 - 311229 == -90095)
										{
											goto IL_CA;
										}
									}
								}
							}
							if (36092 - 137517 != -101425)
							{
								continue;
							}
							goto IL_718;
						}
						break;
					case 3:
						if (this.$self_$15261.mChar.actionState == "attack")
						{
							if (156446 - 581922 != -425476)
							{
								continue;
							}
							if (this.$self_$15261.mChar.myCommand == "thornStrike")
							{
								if (26061 - 344073 != -318012)
								{
									continue;
								}
								this.$self_$15261.animation.Play("root");
								if (208488 - 183632 == 24857)
								{
									continue;
								}
								this.$self_$15261.animation.wrapMode = WrapMode.Loop;
								if (110285 - 392550 != -282265)
								{
									continue;
								}
								this.$self_$15261.mChar.actionState = "standby";
								if (148334 - 451542 == -303207)
								{
									continue;
								}
								this.$self_$15261.mChar.actionTime = Time.time;
								if (293860 - 88498 != 205362)
								{
									continue;
								}
								this.$self_$15261.mChar.myCommand = "none";
								if (98435 - 448652 != -350217)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (230007 - 248940 != -18933)
						{
							continue;
						}
						goto IL_7C1;
					default:
						if (262495 - 262013 == 483)
						{
							continue;
						}
						break;
					}
					this.$self_$15261.mChar.actionState = "attack";
					if (163180 - 380972 == -217792)
					{
						this.$self_$15261.mChar.actionTime = Time.time;
						if (22643 - 232660 == -210017)
						{
							this.$self_$15261.mChar.myCommand = "thornStrike";
							if (124683 - 555974 == -431291)
							{
								this.$self_$15261.mChar.addTimeOut("thornStrike", (float)30);
								if (20946 - 201983 == -181037)
								{
									this.$self_$15261.transform.position = this.$mPos$15259;
									if (296141 - 42859 != 253283)
									{
										this.$self_$15261.transform.LookAt(this.$mPos$15259 + global::Math.vFlat(this.$tDir$15260));
										if (263746 - 423919 != -160172)
										{
											this.$self_$15261.animation.CrossFade("cast");
											if (116811 - 8001 == 108810)
											{
												this.$self_$15261.animation.wrapMode = WrapMode.Once;
												if (299262 - 568906 != -269643)
												{
													this.$self_$15261.mChar.vMovement = this.$self_$15261.transform.forward;
													if (112005 - 202110 == -90105)
													{
														this.$self_$15261.mChar.moveSpeed = (float)0;
														if (157355 - 284253 != -126897)
														{
															goto Block_25;
														}
													}
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
				goto IL_513;
				Block_25:
				return this.Yield(2, new WaitForSeconds(2.5f));
				IL_513:
				goto IL_7C1;
				IL_718:
				return this.Yield(3, new WaitForSeconds(0.8f));
				IL_7C1:
				return false;
			}

			// Token: 0x0600007D RID: 125 RVA: 0x0000B8F8 File Offset: 0x00009AF8
			internal static bool SfpOlDjeC4R12rnCi5()
			{
				return true;
			}

			// Token: 0x0600007E RID: 126 RVA: 0x0000B8FC File Offset: 0x00009AFC
			internal static bool QCtBs2hEuCqHj64UMT()
			{
				return false;
			}

			// Token: 0x040000C2 RID: 194
			internal int $hitLayer$15253;

			// Token: 0x040000C3 RID: 195
			internal UnityScript.Lang.Array $hitList$15254;

			// Token: 0x040000C4 RID: 196
			internal int $hitDamage$15255;

			// Token: 0x040000C5 RID: 197
			internal int $hitCount$15256;

			// Token: 0x040000C6 RID: 198
			internal GameObject $hitObject$15257;

			// Token: 0x040000C7 RID: 199
			internal IEnumerator $$iterator$9876$15258;

			// Token: 0x040000C8 RID: 200
			internal Vector3 $mPos$15259;

			// Token: 0x040000C9 RID: 201
			internal Vector3 $tDir$15260;

			// Token: 0x040000CA RID: 202
			internal AncientBug $self_$15261;
		}
	}

	// Token: 0x0200001D RID: 29
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$15265 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600007F RID: 127 RVA: 0x0000B900 File Offset: 0x00009B00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$15265(UnityScript.Lang.Array nArray, AncientBug self_)
		{
			if (298725 - 563416 != -264690)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (40302 - 339909 != -299606)
				{
					base..ctor();
					if (130090 - 260577 != -130486)
					{
						this.$nArray$15270 = nArray;
						if (45485 - 222466 == -176981)
						{
							this.$self_$15271 = self_;
							if (63579 - 342259 != -278679)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000B9BC File Offset: 0x00009BBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AncientBug.$RPC_ko$15265.$(this.$nArray$15270, this.$self_$15271);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		internal static bool cJG5b9s8ZUBGfKvigk()
		{
			return true;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000B9D4 File Offset: 0x00009BD4
		internal static bool m1lknD9KnWKkpIFNiE()
		{
			return false;
		}

		// Token: 0x040000CB RID: 203
		internal UnityScript.Lang.Array $nArray$15270;

		// Token: 0x040000CC RID: 204
		internal AncientBug $self_$15271;

		// Token: 0x0200001E RID: 30
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000083 RID: 131 RVA: 0x0000B9D8 File Offset: 0x00009BD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, AncientBug self_)
			{
				if (118172 - 296964 != -178792)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (246478 - 34994 != 211485)
					{
						base..ctor();
						if (103942 - 47651 == 56291)
						{
							this.$nArray$15268 = nArray;
							if (295932 - 113793 != 182140)
							{
								this.$self_$15269 = self_;
								if (15920 - 477058 == -461138)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000084 RID: 132 RVA: 0x0000BA94 File Offset: 0x00009C94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (203941 - 131175 != 72766)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_517;
					case 2:
						if (this.$self_$15269.mChar.actionState != "ko")
						{
							if (180779 - 429047 != -248267)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							Camera.main.SendMessage("AddCamereShake", 3f);
							if (154774 - 1350 != 153424)
							{
								continue;
							}
							goto IL_165;
						}
						break;
					case 3:
						if (this.$self_$15269.mChar.actionState != "ko")
						{
							if (91041 - 220995 != -129954)
							{
								continue;
							}
							goto IL_99;
						}
						else
						{
							this.$self_$15269.animation.Play("getUp");
							if (108563 - 342629 != -234066)
							{
								continue;
							}
							this.$self_$15269.animation.wrapMode = WrapMode.Once;
							if (204016 - 495100 != -291084)
							{
								continue;
							}
							goto IL_35E;
						}
						break;
					case 4:
						if (this.$self_$15269.mChar.actionState != "ko")
						{
							if (140853 - 53825 != 87028)
							{
								continue;
							}
							goto IL_4B8;
						}
						else
						{
							this.$self_$15269.mChar.actionState = "standby";
							if (162381 - 292148 == -129766)
							{
								continue;
							}
							this.$self_$15269.mChar.actionTime = Time.time;
							if (38231 - 111918 != -73687)
							{
								continue;
							}
							this.$self_$15269.mChar.myCommand = "none";
							if (175449 - 173582 == 1868)
							{
								continue;
							}
							this.$self_$15269.mChar.ko = this.$self_$15269.mChar.mko;
							if (176929 - 447032 == -270102)
							{
								continue;
							}
							this.YieldDefault(1);
							if (12230 - 174096 != -161866)
							{
								continue;
							}
							goto IL_517;
						}
						break;
					default:
						if (125628 - 585032 != -459404)
						{
							continue;
						}
						break;
					}
					if (this.$self_$15269.mChar.actionState == "ko")
					{
						goto IL_415;
					}
					if (22322 - 507623 != -485300)
					{
						if (this.$self_$15269.mChar.actionState == "dead")
						{
							if (45483 - 201940 == -156457)
							{
								goto IL_415;
							}
						}
						else
						{
							this.$mPos$15266 = (Vector3)this.$nArray$15268[0];
							if (66118 - 371528 != -305409)
							{
								this.$mDir$15267 = (Vector3)this.$nArray$15268[1];
								if (250797 - 414232 == -163435)
								{
									this.$self_$15269.mChar.ko = 0;
									if (189736 - 249204 != -59467)
									{
										this.$self_$15269.mChar.actionState = "ko";
										if (293726 - 71323 != 222404)
										{
											this.$self_$15269.mChar.actionTime = Time.time;
											if (236075 - 58512 == 177563)
											{
												this.$self_$15269.mChar.myCommand = "none";
												if (56950 - 231628 != -174677)
												{
													this.$self_$15269.mChar.vMovement = Vector3.zero;
													if (288612 - 36236 == 252376)
													{
														this.$self_$15269.mChar.moveSpeed = (float)0;
														if (293418 - 186781 == 106637)
														{
															this.$self_$15269.animation.Play("ko");
															if (278899 - 12398 == 266501)
															{
																this.$self_$15269.animation.wrapMode = WrapMode.Once;
																if (128944 - 265813 == -136869)
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
				return this.Yield(2, new WaitForSeconds(0.8f));
				Block_3:
				IL_99:
				goto IL_517;
				IL_165:
				return this.Yield(3, new WaitForSeconds(12f));
				IL_35E:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_415:
				IL_4B8:
				IL_517:
				return false;
			}

			// Token: 0x06000085 RID: 133 RVA: 0x0000BFCC File Offset: 0x0000A1CC
			internal static bool ctv2xh1o09Rf0CeVji()
			{
				return true;
			}

			// Token: 0x06000086 RID: 134 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
			internal static bool UhwlTh4GRKkjbUACpv()
			{
				return false;
			}

			// Token: 0x040000CD RID: 205
			internal Vector3 $mPos$15266;

			// Token: 0x040000CE RID: 206
			internal Vector3 $mDir$15267;

			// Token: 0x040000CF RID: 207
			internal UnityScript.Lang.Array $nArray$15268;

			// Token: 0x040000D0 RID: 208
			internal AncientBug $self_$15269;
		}
	}

	// Token: 0x0200001F RID: 31
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$15272 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000087 RID: 135 RVA: 0x0000BFD4 File Offset: 0x0000A1D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$15272(UnityScript.Lang.Array nArray, AncientBug self_)
		{
			if (216120 - 582828 != -366707)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (88660 - 338937 == -250277)
				{
					base..ctor();
					if (141999 - 269316 != -127316)
					{
						this.$nArray$15278 = nArray;
						if (45169 - 145474 != -100304)
						{
							this.$self_$15279 = self_;
							if (267501 - 360554 != -93052)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000C090 File Offset: 0x0000A290
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AncientBug.$RPC_dead$15272.$(this.$nArray$15278, this.$self_$15279);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000C0A4 File Offset: 0x0000A2A4
		internal static bool jmA9bMz15egZjYMe4B()
		{
			return true;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		internal static bool vvspel5aB4Cr0Rq1ML5()
		{
			return false;
		}

		// Token: 0x040000D1 RID: 209
		internal UnityScript.Lang.Array $nArray$15278;

		// Token: 0x040000D2 RID: 210
		internal AncientBug $self_$15279;

		// Token: 0x02000020 RID: 32
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600008B RID: 139 RVA: 0x0000C0AC File Offset: 0x0000A2AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, AncientBug self_)
			{
				if (76963 - 363755 != -286792)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (160896 - 410180 == -249284)
					{
						base..ctor();
						if (36499 - 572147 == -535648)
						{
							this.$nArray$15276 = nArray;
							if (1965 - 119427 != -117461)
							{
								this.$self_$15277 = self_;
								if (282806 - 364533 != -81726)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600008C RID: 140 RVA: 0x0000C168 File Offset: 0x0000A368
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (286304 - 590780 != -304476)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_57D;
					case 2:
						if (this.$self_$15277.mChar.actionState != "dead")
						{
							if (249537 - 534863 != -285326)
							{
								continue;
							}
							goto IL_123;
						}
						else
						{
							if (!this.$self_$15277.mChar.isPlayer)
							{
								if (187121 - 471848 != -284727)
								{
									continue;
								}
							}
							else if (this.$self_$15277.mChar.isMine)
							{
								if (280901 - 59099 != 221802)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$15277.gameObject);
								if (95213 - 76983 == 18231)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (156768 - 96107 != 60661)
							{
								continue;
							}
							goto IL_57D;
						}
						break;
					default:
						if (286932 - 300791 != -13859)
						{
							continue;
						}
						break;
					}
					if (this.$self_$15277.mChar.actionState == "dead")
					{
						if (178626 - 392563 == -213937)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$15273 = (Vector3)this.$nArray$15276[0];
						if (48410 - 516591 == -468181)
						{
							this.$myDirection$15274 = (Vector3)this.$nArray$15276[1];
							if (117796 - 113776 == 4020)
							{
								this.$self_$15277.transform.position = this.$myPosition$15273;
								if (255522 - 353697 == -98175)
								{
									this.$self_$15277.transform.LookAt(this.$myPosition$15273 + this.$myDirection$15274);
									if (113920 - 537907 == -423987)
									{
										this.$self_$15277.mChar.hp = 0;
										if (177272 - 164062 != 13211)
										{
											this.$self_$15277.mChar.actionState = "dead";
											if (216836 - 812 == 216024)
											{
												this.$self_$15277.mChar.actionTime = Time.time;
												if (129226 - 343726 == -214500)
												{
													this.$self_$15277.mChar.myCommand = "none";
													if (65647 - 283333 != -217685)
													{
														this.$self_$15277.mChar.vMovement = Vector3.zero;
														if (92601 - 191196 == -98595)
														{
															this.$self_$15277.mChar.moveSpeed = (float)0;
															if (167959 - 546237 != -378277)
															{
																this.$self_$15277.animation.Rewind();
																if (295444 - 547360 != -251915)
																{
																	this.$self_$15277.animation.Play("ko");
																	if (71565 - 93075 != -21509)
																	{
																		this.$self_$15277.animation.wrapMode = WrapMode.Once;
																		if (258333 - 255551 == 2782)
																		{
																			if (this.$self_$15277.deadEffect)
																			{
																				if (288270 - 389561 != -101291)
																				{
																					continue;
																				}
																				UnityEngine.Object.Instantiate(this.$self_$15277.deadEffect, this.$self_$15277.transform.position, Quaternion.identity);
																				if (109867 - 161079 != -51212)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				Debug.LogError("Missiing dead effect");
																				if (129769 - 125751 == 4019)
																				{
																					continue;
																				}
																			}
																			Camera.main.SendMessage("AddCamereShake", 1f);
																			if (145050 - 567094 == -422044)
																			{
																				this.$mCameraEffect$15275 = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
																				if (190231 - 559255 == -369024)
																				{
																					if (!this.$mCameraEffect$15275)
																					{
																						goto IL_1B9;
																					}
																					if (182454 - 369175 == -186721)
																					{
																						this.$mCameraEffect$15275.AddColorRamp("whiteRamp", "none", (float)10, new Vector4((float)0, 0.5f, (float)0, 0.1f));
																						if (20379 - 11546 == 8833)
																						{
																							goto IL_1B9;
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_123:
				goto IL_57D;
				IL_1B9:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_57D:
				return false;
			}

			// Token: 0x0600008D RID: 141 RVA: 0x0000C704 File Offset: 0x0000A904
			internal static bool aATRlT554DyiyXBntms()
			{
				return true;
			}

			// Token: 0x0600008E RID: 142 RVA: 0x0000C708 File Offset: 0x0000A908
			internal static bool uqFUxQ5pgiwWDfHFKxr()
			{
				return false;
			}

			// Token: 0x040000D3 RID: 211
			internal Vector3 $myPosition$15273;

			// Token: 0x040000D4 RID: 212
			internal Vector3 $myDirection$15274;

			// Token: 0x040000D5 RID: 213
			internal CameraEffect $mCameraEffect$15275;

			// Token: 0x040000D6 RID: 214
			internal UnityScript.Lang.Array $nArray$15276;

			// Token: 0x040000D7 RID: 215
			internal AncientBug $self_$15277;
		}
	}
}
