using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200019C RID: 412
[Serializable]
public class ReefBug : MonoBehaviour
{
	// Token: 0x0600093E RID: 2366 RVA: 0x000F095C File Offset: 0x000EEB5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ReefBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600093F RID: 2367 RVA: 0x000F096C File Offset: 0x000EEB6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (47417 - 536364 != -488946)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (193543 - 146900 == 46643)
			{
				this.mChar.actionState = "standby";
				if (285870 - 53550 != 232321)
				{
					this.mChar.actionTime = Time.time;
					if (190178 - 514351 != -324172)
					{
						this.mChar.myCommand = "none";
						if (170949 - 288636 != -117686)
						{
							GameObject gameObject = global::Math.findChildObject(this.transform, "Head").gameObject;
							if (204883 - 137489 != 67395)
							{
								if (gameObject)
								{
									if (295070 - 595707 != -300636)
									{
										this.mHeadChar = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (96530 - 565446 == -468916)
										{
											break;
										}
									}
								}
								else
								{
									Debug.LogError("Cannot find ReefBugHead CharacterControl");
									if (158941 - 94590 != 64352)
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

	// Token: 0x06000940 RID: 2368 RVA: 0x000F0B0C File Offset: 0x000EED0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (213470 - 299612 != -86141)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (299624 - 6152 == 293473)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (90675 - 455474 != -364799)
				{
					continue;
				}
			}
			if (this.mChar.ActorNr != 0)
			{
				if (75099 - 36871 != 38228)
				{
					continue;
				}
				if (this.mHeadChar)
				{
					if (49575 - 461233 == -411657)
					{
						continue;
					}
					this.mHeadChar.ActorNr = this.mChar.ActorNr + 1;
					if (46284 - 231827 == -185542)
					{
						continue;
					}
					this.mHeadChar.ownerID = this.mChar.ownerID;
					if (143783 - 399820 != -256037)
					{
						continue;
					}
					this.mHeadChar.gameObject.layer = this.gameObject.layer;
					if (271110 - 32209 != 238901)
					{
						continue;
					}
					this.mHeadChar.isPlayer = false;
					if (125517 - 161545 == -36027)
					{
						continue;
					}
					this.mHeadChar.isControlled = false;
					if (147533 - 469587 != -322054)
					{
						continue;
					}
					if (this.mChar.ownerID == PlayerData.UID)
					{
						if (200119 - 599769 != -399650)
						{
							continue;
						}
						this.mHeadChar.isMine = true;
						if (79268 - 479305 != -400037)
						{
							continue;
						}
					}
					else
					{
						this.mHeadChar.isMine = false;
						if (222686 - 509312 == -286625)
						{
							continue;
						}
					}
					if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.mHeadChar.ActorNr], null))
					{
						if (110344 - 497184 == -386839)
						{
							continue;
						}
						Debug.Log("ActorNr: " + this.mHeadChar.ActorNr + " already existed");
						if (154846 - 343839 == -188992)
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
						if (121263 - 581211 == -459947)
						{
							continue;
						}
						UnityEngine.Object.Destroy(obj3);
						if (291919 - 178952 != 112967)
						{
							continue;
						}
					}
					PhotonClient.ActorNrList.Add(this.mHeadChar.ActorNr, this.mHeadChar.gameObject);
					if (287187 - 511605 == -224417)
					{
						continue;
					}
				}
				this.mChar.addTimeOut("nAttack", (float)60);
				if (171328 - 559504 == -388175)
				{
					continue;
				}
				this.mChar.addTimeOut("fallingComet", (float)60);
				if (172575 - 356389 == -183813)
				{
					continue;
				}
			}
			if (!this.mChar)
			{
				break;
			}
			if (289747 - 285771 == 3976)
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
				if (100254 - 377615 == -277361)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000941 RID: 2369 RVA: 0x000F0F94 File Offset: 0x000EF194
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (76328 - 570620 != -494291)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (111529 - 33711 == 77819)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (116026 - 218503 == -102476)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_232;
					}
					if (227812 - 420680 == -192867)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (162580 - 289486 == -126905)
				{
					continue;
				}
			}
			IL_232:
			if (this.mChar.hp <= 0)
			{
				if (169915 - 586003 == -416087)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (83173 - 81570 != 1603)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (183409 - 40422 != 142987)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (294852 - 272102 == 22751)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (82887 - 242340 != -159453)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (283508 - 262290 != 21218)
						{
							continue;
						}
						break;
					}
					else
					{
						this.mChar.hp = 1;
						if (51568 - 430905 != -379336)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.mChar.hp > 0)
			{
				if (8302 - 81989 != -73687)
				{
					continue;
				}
				if (this.mChar.ko <= 0)
				{
					if (117912 - 478355 == -360442)
					{
						continue;
					}
					if (this.mChar.actionState != "ko")
					{
						if (87034 - 519981 == -432946)
						{
							continue;
						}
						if (this.mChar.actionState != "dead")
						{
							if (100355 - 128245 != -27890)
							{
								continue;
							}
							if (this.mChar.isMine)
							{
								if (12135 - 165880 == -153744)
								{
									continue;
								}
								this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
								{
									this.transform.position,
									this.transform.forward
								})));
								if (166681 - 193076 != -26395)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (49001 - 165187 == -116185)
								{
									continue;
								}
								this.mChar.KoEvent();
								if (263655 - 176635 != 87021)
								{
									break;
								}
								continue;
							}
							else
							{
								this.mChar.ko = 1;
								if (160749 - 327238 != -166489)
								{
									continue;
								}
								break;
							}
						}
					}
				}
			}
			if (this.mHeadChar.hp <= 0)
			{
				break;
			}
			if (17765 - 535370 != -517604)
			{
				if (this.mHeadChar.ko > 0)
				{
					break;
				}
				if (248093 - 364046 == -115953)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (160837 - 594593 != -433755)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (215983 - 481145 == -265162)
						{
							if (this.mChar.isMine)
							{
								if (84808 - 305803 == -220995)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (110391 - 530522 != -420130)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (73268 - 586594 == -513326)
										{
											this.mChar.KoEvent();
											if (135600 - 230253 == -94653)
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
								if (64754 - 579328 == -514574)
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

	// Token: 0x06000942 RID: 2370 RVA: 0x000F1548 File Offset: 0x000EF748
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (195225 - 329965 != -134740)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (234768 - 492202 == -257434)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (11787 - 255146 != -243358)
				{
					if (163338 - 584211 == -420873)
					{
						if (ActionName == "RPC_hpTransfer")
						{
							if (171478 - 55843 == 115636)
							{
								continue;
							}
							v = 1;
							if (170673 - 368445 != -197772)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_manaMissile")
						{
							if (231994 - 273340 == -41345)
							{
								continue;
							}
							v = 10;
							if (200631 - 488946 == -288314)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_manaMissile_fire")
						{
							if (51224 - 87860 != -36636)
							{
								continue;
							}
							v = 11;
							if (45906 - 444643 == -398736)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_manaMissile_hit")
						{
							if (162843 - 486146 == -323302)
							{
								continue;
							}
							v = -11;
							if (256826 - 591317 != -334491)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_manaBurn")
						{
							if (139911 - 545703 == -405791)
							{
								continue;
							}
							v = 20;
							if (22500 - 162269 == -139768)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_manaBurn_fire")
						{
							if (239186 - 162022 == 77165)
							{
								continue;
							}
							v = 21;
							if (16568 - 63265 != -46697)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_fallingComets")
						{
							if (88647 - 221746 == -133098)
							{
								continue;
							}
							v = 30;
							if (129227 - 35139 != 94088)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_fallingComets_fire")
						{
							if (218102 - 538807 != -320705)
							{
								continue;
							}
							v = 31;
							if (169509 - 453621 == -284111)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_meteora")
						{
							if (246585 - 257553 == -10967)
							{
								continue;
							}
							v = 40;
							if (259425 - 200468 != 58957)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_meteora_fire")
						{
							if (283039 - 110915 == 172125)
							{
								continue;
							}
							v = 41;
							if (40306 - 535753 == -495446)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (214731 - 441149 == -226417)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (259347 - 334723 == -75376)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (111317 - 581652 == -470335)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (129706 - 522507 == -392801)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (249731 - 481343 != -231611)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (147756 - 299102 != -151345)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (109158 - 329907 != -220748)
											{
												Hashtable hashtable = new Hashtable();
												if (69630 - 172502 != -102871)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (280701 - 307352 == -26651)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (155134 - 96998 != 58137)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (200098 - 81283 == 118815)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (222063 - 52324 != 169740)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (94825 - 72434 != 22392)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (17400 - 18946 == -1546)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (279071 - 95171 != 183901)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (164557 - 158652 == 5905)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (237979 - 92244 == 145735)
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

	// Token: 0x06000943 RID: 2371 RVA: 0x000F1C28 File Offset: 0x000EFE28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (32166 - 304496 != -272330)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (17860 - 305411 != -287550)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (271808 - 13429 != 258380)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (89184 - 76832 == 12352)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (30850 - 307406 == -276556)
						{
							int num3 = num;
							if (211731 - 123857 == 87874)
							{
								if (num3 == 1)
								{
									if (79803 - 365429 == -285626)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (228885 - 179602 != 49284)
										{
											this.StartCoroutine_Auto(this.RPC_hpTransfer(vector, vector2, num2));
											if (49097 - 253202 == -204105)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 10)
								{
									if (192016 - 375908 != -183891)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (238614 - 442133 == -203519)
										{
											this.StartCoroutine_Auto(this.RPC_manaMissile(vector, vector2, num2));
											if (296440 - 464440 != -167999)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (61688 - 287179 != -225490)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (17807 - 61563 == -43756)
										{
											this.RPC_manaMissile_fire(vector, vector2, num2);
											if (41563 - 445162 != -403598)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (168522 - 39395 == 129127)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (188613 - 219043 == -30430)
										{
											this.RPC_manaMissile_hit(vector, vector2, num2);
											if (243816 - 551599 != -307782)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 20)
								{
									if (260801 - 289972 != -29170)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (30572 - 405545 != -374972)
										{
											this.StartCoroutine_Auto(this.RPC_manaBurn(vector, vector2, num2));
											if (195309 - 20419 != 174891)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (270502 - 33543 == 236959)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (13752 - 183066 == -169314)
										{
											this.StartCoroutine_Auto(this.RPC_manaBurn_fire(vector, vector2, num2));
											if (91335 - 386596 != -295260)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 30)
								{
									if (243703 - 503 != 243201)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (75105 - 77427 != -2321)
										{
											this.StartCoroutine_Auto(this.RPC_fallingComets(vector, vector2, num2));
											if (286472 - 32563 == 253909)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (68779 - 244841 != -176061)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (142021 - 476632 != -334610)
										{
											this.StartCoroutine_Auto(this.RPC_fallingComets_fire(vector, vector2, num2));
											if (247319 - 105936 != 141384)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 40)
								{
									if (90953 - 455976 != -365022)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (258283 - 282366 != -24082)
										{
											this.StartCoroutine_Auto(this.RPC_meteora(vector, vector2, num2));
											if (269112 - 33225 == 235887)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 41)
								{
									if (238462 - 25437 == 213025)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (260242 - 593805 != -333562)
										{
											this.StartCoroutine_Auto(this.RPC_meteora_fire(vector, vector2, num2));
											if (124553 - 82678 != 41876)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (178322 - 439589 != -261266)
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

	// Token: 0x06000944 RID: 2372 RVA: 0x000F2298 File Offset: 0x000F0498
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
	}

	// Token: 0x06000945 RID: 2373 RVA: 0x000F229C File Offset: 0x000F049C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (46177 - 195829 != -149651)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (97471 - 171940 == -74469)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (219751 - 335658 != -115906)
				{
					Vector3 vector = a - this.transform.position;
					if (36467 - 321694 != -285226)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (164034 - 239441 == -75407)
						{
							if (64859 - 270382 == -205523)
							{
								if (gameObject)
								{
									if (94134 - 375701 == -281566)
									{
										continue;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (15747 - 594846 == -579098)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (229205 - 183151 == 46055)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (95799 - 92778 != 3021)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (292666 - 200671 != 91996)
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

	// Token: 0x06000946 RID: 2374 RVA: 0x000F24AC File Offset: 0x000F06AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x06000947 RID: 2375 RVA: 0x000F24C4 File Offset: 0x000F06C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000948 RID: 2376 RVA: 0x000F24C8 File Offset: 0x000F06C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_hpTransfer(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ReefBug.$RPC_hpTransfer$16871(this).GetEnumerator();
	}

	// Token: 0x06000949 RID: 2377 RVA: 0x000F24D8 File Offset: 0x000F06D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_manaMissile(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ReefBug.$RPC_manaMissile$16888(this).GetEnumerator();
	}

	// Token: 0x0600094A RID: 2378 RVA: 0x000F24E8 File Offset: 0x000F06E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_manaMissile_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (115170 - 43375 != 71795)
		{
		}
		for (;;)
		{
			object obj2;
			object obj = obj2 = PhotonClient.ActorNrList[tID];
			if (!(obj is GameObject))
			{
				obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
			}
			GameObject gameObject = (GameObject)obj2;
			if (44509 - 295311 == -250802)
			{
				if (!gameObject)
				{
					if (156957 - 282551 != -125593)
					{
						break;
					}
				}
				else
				{
					CharacterControl exists = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (167680 - 275517 == -107837)
					{
						if (!exists)
						{
							if (206328 - 332203 != -125874)
							{
								break;
							}
						}
						else
						{
							GameObject gameObject2 = (GameObject)UnityEngine.Object.Instantiate(this.manaMissile_fire, firePos, Quaternion.LookRotation(fireDir));
							if (153583 - 439341 == -285758)
							{
								ProjectileControl projectileControl = (ProjectileControl)gameObject2.GetComponent(typeof(ProjectileControl));
								if (27738 - 533149 == -505411)
								{
									if (projectileControl)
									{
										if (64798 - 286758 != -221960)
										{
											continue;
										}
										projectileControl.Init(this.mChar.ActorNr);
										if (29756 - 272935 == -243178)
										{
											continue;
										}
										projectileControl.life = (float)8 * this.mChar.rangeMod;
										if (25113 - 96442 != -71329)
										{
											continue;
										}
									}
									ReefBug_manaMissile reefBug_manaMissile = (ReefBug_manaMissile)gameObject2.GetComponent(typeof(ReefBug_manaMissile));
									if (243992 - 426217 == -182225)
									{
										if (reefBug_manaMissile)
										{
											if (180838 - 555189 != -374351)
											{
												continue;
											}
											reefBug_manaMissile.Init(gameObject);
											if (96960 - 184080 != -87120)
											{
												continue;
											}
										}
										else
										{
											Debug.LogError("Missing ManaMissile Script");
											if (68588 - 306555 != -237967)
											{
												continue;
											}
										}
										if (this.yaSQZmCipW >= Time.time)
										{
											break;
										}
										if (35559 - 71691 == -36132)
										{
											this.yaSQZmCipW = Time.time + 0.2f;
											if (78470 - 368297 == -289827)
											{
												if (!this.manaMissile_Fx)
												{
													break;
												}
												if (80139 - 430187 != -350047)
												{
													this.audio.PlayOneShot(this.manaMissile_Fx, 5f);
													if (76553 - 40366 != 36188)
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

	// Token: 0x0600094B RID: 2379 RVA: 0x000F2820 File Offset: 0x000F0A20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_manaMissile_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.manaMissile_hit)
		{
			UnityEngine.Object.Instantiate(this.manaMissile_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x0600094C RID: 2380 RVA: 0x000F284C File Offset: 0x000F0A4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_manaBurn(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ReefBug.$RPC_manaBurn$16899(this).GetEnumerator();
	}

	// Token: 0x0600094D RID: 2381 RVA: 0x000F285C File Offset: 0x000F0A5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_manaBurn_fire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ReefBug.$RPC_manaBurn_fire$16908(tID, this).GetEnumerator();
	}

	// Token: 0x0600094E RID: 2382 RVA: 0x000F286C File Offset: 0x000F0A6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_fallingComets(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ReefBug.$RPC_fallingComets$16916(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x0600094F RID: 2383 RVA: 0x000F287C File Offset: 0x000F0A7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_fallingComets_fire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ReefBug.$RPC_fallingComets_fire$16930(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000950 RID: 2384 RVA: 0x000F288C File Offset: 0x000F0A8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_meteora(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ReefBug.$RPC_meteora$16943(tID, this).GetEnumerator();
	}

	// Token: 0x06000951 RID: 2385 RVA: 0x000F289C File Offset: 0x000F0A9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_meteora_fire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ReefBug.$RPC_meteora_fire$16949(mPos, this).GetEnumerator();
	}

	// Token: 0x06000952 RID: 2386 RVA: 0x000F28AC File Offset: 0x000F0AAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new ReefBug.$RPC_ko$16960(nArray, this).GetEnumerator();
	}

	// Token: 0x06000953 RID: 2387 RVA: 0x000F28BC File Offset: 0x000F0ABC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new ReefBug.$RPC_dead$16967(nArray, this).GetEnumerator();
	}

	// Token: 0x06000954 RID: 2388 RVA: 0x000F28CC File Offset: 0x000F0ACC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000955 RID: 2389 RVA: 0x000F28D0 File Offset: 0x000F0AD0
	internal static bool dZs3jqkARdTj1pth6ku()
	{
		return true;
	}

	// Token: 0x06000956 RID: 2390 RVA: 0x000F28D4 File Offset: 0x000F0AD4
	internal static bool oB5P7dkl6kskem1IIed()
	{
		return false;
	}

	// Token: 0x04000856 RID: 2134
	public CharacterControl mChar;

	// Token: 0x04000857 RID: 2135
	public CharacterControl mHeadChar;

	// Token: 0x04000858 RID: 2136
	public GameObject hpTransfer_ring;

	// Token: 0x04000859 RID: 2137
	public GameObject hpTransfer_line;

	// Token: 0x0400085A RID: 2138
	public GameObject castEffect;

	// Token: 0x0400085B RID: 2139
	public GameObject manaMissile_fire;

	// Token: 0x0400085C RID: 2140
	public AudioClip manaMissile_Fx;

	// Token: 0x0400085D RID: 2141
	private float yaSQZmCipW;

	// Token: 0x0400085E RID: 2142
	public GameObject manaMissile_hit;

	// Token: 0x0400085F RID: 2143
	public GameObject manaBurn;

	// Token: 0x04000860 RID: 2144
	public GameObject fallingComet;

	// Token: 0x04000861 RID: 2145
	public GameObject meteora;

	// Token: 0x04000862 RID: 2146
	public GameObject meteora_ring;

	// Token: 0x04000863 RID: 2147
	public GameObject meteora_hit;

	// Token: 0x04000864 RID: 2148
	public GameObject deadEffect;

	// Token: 0x0200019D RID: 413
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_hpTransfer$16871 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000957 RID: 2391 RVA: 0x000F28D8 File Offset: 0x000F0AD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_hpTransfer$16871(ReefBug self_)
		{
			if (125053 - 371760 != -246707)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (106571 - 306806 != -200234)
				{
					base..ctor();
					if (58044 - 555352 == -497308)
					{
						this.$self_$16887 = self_;
						if (72745 - 115364 != -42618)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x000F2970 File Offset: 0x000F0B70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ReefBug.$RPC_hpTransfer$16871.$(this.$self_$16887);
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x000F2980 File Offset: 0x000F0B80
		internal static bool KRhuvjkyHyRaiNc8x7s()
		{
			return true;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x000F2984 File Offset: 0x000F0B84
		internal static bool WYnpUEkSygDrxKgdLdZ()
		{
			return false;
		}

		// Token: 0x04000865 RID: 2149
		internal ReefBug $self_$16887;

		// Token: 0x0200019E RID: 414
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600095B RID: 2395 RVA: 0x000F2988 File Offset: 0x000F0B88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(ReefBug self_)
			{
				if (42800 - 171338 != -128538)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (185133 - 355090 != -169956)
					{
						base..ctor();
						if (104645 - 68669 != 35977)
						{
							this.$self_$16886 = self_;
							if (16588 - 129422 == -112834)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600095C RID: 2396 RVA: 0x000F2A20 File Offset: 0x000F0C20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (175805 - 137698 != 38107)
				{
				}
				for (;;)
				{
					IL_C6B:
					switch (this._state)
					{
					case 0:
						goto IL_687;
					case 1:
						goto IL_DA0;
					case 2:
						if (this.$self_$16886.mChar.actionState != "attack")
						{
							goto IL_A6B;
						}
						if (48720 - 228415 == -179694)
						{
							continue;
						}
						if (this.$self_$16886.mChar.myCommand != "hpTransfer")
						{
							if (49765 - 362981 != -313215)
							{
								goto Block_61;
							}
							continue;
						}
						else
						{
							this.$mTransferCharList$16872 = new CharacterControl[4];
							if (111306 - 485754 == -374447)
							{
								continue;
							}
							this.$mHpTransferList$16873 = new GameObject[4];
							if (266466 - 241310 != 25156)
							{
								continue;
							}
							this.$mTransferCount$16874 = 0;
							if (110147 - 404501 != -294354)
							{
								continue;
							}
							if (this.$self_$16886.hpTransfer_ring)
							{
								if (251513 - 289097 == -37583)
								{
									continue;
								}
								this.$self_$16886.mChar.createEffect(this.$self_$16886.hpTransfer_ring, this.$self_$16886.transform.position + this.$self_$16886.transform.TransformDirection((float)0, 4.5f, 7.5f), Quaternion.identity);
								if (71285 - 47004 == 24282)
								{
									continue;
								}
							}
							this.$mEnemyList$16875 = GameObject.FindGameObjectsWithTag("Enemy");
							if (266699 - 287074 != -20375)
							{
								continue;
							}
							this.$$11024$16883 = 0;
							if (10116 - 151992 == -141875)
							{
								continue;
							}
							this.$$11025$16884 = this.$mEnemyList$16875;
							if (12922 - 29104 != -16182)
							{
								continue;
							}
							this.$$11026$16885 = this.$$11025$16884.Length;
							if (284832 - 486230 != -201398)
							{
								continue;
							}
							while (this.$$11024$16883 < this.$$11026$16885)
							{
								if (this.$mTransferCount$16874 < 4)
								{
									if (165534 - 27818 != 137716)
									{
										goto IL_C6B;
									}
									if (this.$$11025$16884[this.$$11024$16883].layer == this.$self_$16886.gameObject.layer)
									{
										if (15652 - 331984 == -316331)
										{
											goto IL_C6B;
										}
										this.$mEnemyChar$16877 = (CharacterControl)this.$$11025$16884[this.$$11024$16883].GetComponent(typeof(CharacterControl));
										if (195067 - 262594 == -67526)
										{
											goto IL_C6B;
										}
										if (this.$mEnemyChar$16877)
										{
											if (204602 - 375072 != -170470)
											{
												goto IL_C6B;
											}
											if (!(this.$mEnemyChar$16877.Type == "CoralBug"))
											{
												if (166837 - 526456 != -359619)
												{
													goto IL_C6B;
												}
												if (!(this.$mEnemyChar$16877.Type == "CoralBug2"))
												{
													goto IL_451;
												}
												if (71663 - 156166 == -84502)
												{
													goto IL_C6B;
												}
											}
											if (this.$mEnemyChar$16877.hp > 0)
											{
												if (187779 - 386664 == -198884)
												{
													goto IL_C6B;
												}
												if (this.$mEnemyChar$16877.hp < this.$mEnemyChar$16877.mhp - 100)
												{
													if (261788 - 354730 != -92942)
													{
														goto IL_C6B;
													}
													this.$mTransferCharList$16872[this.$mTransferCount$16874] = this.$mEnemyChar$16877;
													if (14859 - 564385 != -549526)
													{
														goto IL_C6B;
													}
													if (this.$self_$16886.hpTransfer_line)
													{
														if (135360 - 36810 != 98550)
														{
															goto IL_C6B;
														}
														this.$mHpTransfer$16878 = this.$self_$16886.mChar.createEffect(this.$self_$16886.hpTransfer_line, this.$self_$16886.transform.position + this.$self_$16886.transform.TransformDirection((float)0, 4.5f, 7.5f), Quaternion.identity);
														if (98615 - 128564 != -29949)
														{
															goto IL_C6B;
														}
														if (this.$mHpTransfer$16878)
														{
															if (134057 - 39083 != 94974)
															{
																goto IL_C6B;
															}
															this.$mHpTransferList$16873[this.$mTransferCount$16874] = this.$mHpTransfer$16878;
															if (204456 - 579604 != -375148)
															{
																goto IL_C6B;
															}
															this.$mBoltEmitter$16879 = (BoltEmitter)this.$mHpTransfer$16878.GetComponent(typeof(BoltEmitter));
															if (7749 - 252424 != -244675)
															{
																goto IL_C6B;
															}
															if (this.$mBoltEmitter$16879)
															{
																if (282793 - 41123 != 241670)
																{
																	goto IL_C6B;
																}
																this.$mBoltEmitter$16879.TargetCollider = this.$$11025$16884[this.$$11024$16883].collider;
																if (299529 - 315008 != -15479)
																{
																	goto IL_C6B;
																}
															}
														}
													}
													this.$mTransferCount$16874++;
													if (82932 - 264833 != -181901)
													{
														goto IL_C6B;
													}
												}
											}
										}
									}
								}
								IL_451:
								this.$$11024$16883++;
								if (268434 - 311214 != -42780)
								{
									goto IL_C6B;
								}
							}
							if (292037 - 372719 == -80681)
							{
								continue;
							}
							this.$i$16880 = 0;
							if (199513 - 579908 == -380394)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$16886.mChar.actionState != "attack")
						{
							goto IL_65A;
						}
						if (291818 - 412945 != -121127)
						{
							continue;
						}
						if (this.$self_$16886.mChar.myCommand != "hpTransfer")
						{
							if (194776 - 283121 != -88345)
							{
								continue;
							}
							goto IL_65A;
						}
						else
						{
							this.$i$16880++;
							if (236774 - 452884 == -216109)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$16886.mChar.actionState == "attack")
						{
							if (135045 - 82972 == 52074)
							{
								continue;
							}
							if (this.$self_$16886.mChar.myCommand == "hpTransfer")
							{
								if (225094 - 212036 == 13059)
								{
									continue;
								}
								this.$self_$16886.mChar.moveSpeed = (float)0;
								if (47290 - 181458 == -134167)
								{
									continue;
								}
								this.$self_$16886.mChar.actionState = "standby";
								if (29293 - 542109 != -512816)
								{
									continue;
								}
								this.$self_$16886.mChar.actionTime = Time.time;
								if (184760 - 295246 != -110486)
								{
									continue;
								}
								this.$self_$16886.mChar.myCommand = "none";
								if (139590 - 376337 != -236747)
								{
									continue;
								}
								if (!this.$self_$16886.mChar.isMine)
								{
									if (39463 - 390726 == -351262)
									{
										continue;
									}
									this.$self_$16886.mChar.nPosition = this.$self_$16886.transform.position;
									if (16636 - 170075 != -153439)
									{
										continue;
									}
									this.$self_$16886.mChar.oPosition = this.$self_$16886.transform.position;
									if (253871 - 163117 == 90755)
									{
										continue;
									}
									this.$self_$16886.mChar.nDirection = this.$self_$16886.transform.forward;
									if (92140 - 301081 != -208941)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (58986 - 285240 != -226253)
						{
							goto Block_82;
						}
						continue;
					default:
						if (119411 - 506291 != -386879)
						{
							goto IL_687;
						}
						continue;
					}
					if (this.$i$16880 >= 10)
					{
						if (206102 - 10393 != 195709)
						{
							continue;
						}
						goto IL_C1C;
					}
					else
					{
						this.$mTransferDamage$16881 = 0;
						if (163647 - 83241 == 80407)
						{
							continue;
						}
						this.$t$16882 = 0;
						if (67067 - 359079 != -292012)
						{
							continue;
						}
						while (this.$t$16882 < 4)
						{
							if (this.$mTransferCharList$16872[this.$t$16882])
							{
								if (266145 - 6183 != 259962)
								{
									goto IL_C6B;
								}
								if (this.$self_$16886.mChar.isMine)
								{
									if (89280 - 180588 == -91307)
									{
										goto IL_C6B;
									}
									if (this.$mTransferCharList$16872[this.$t$16882].hp < this.$mTransferCharList$16872[this.$t$16882].mhp)
									{
										if (75229 - 266130 == -190900)
										{
											goto IL_C6B;
										}
										this.$mTransferDamage$16881 += 150;
										if (274424 - 136134 == 138291)
										{
											goto IL_C6B;
										}
										this.$mTransferCharList$16872[this.$t$16882].RPC_AddHeal(1, 150, 0, 0, 0, 0, this.$self_$16886.mChar.ActorNr);
										if (40170 - 409217 == -369046)
										{
											goto IL_C6B;
										}
									}
								}
							}
							else if (this.$mHpTransferList$16873[this.$t$16882])
							{
								if (51589 - 124778 == -73188)
								{
									goto IL_C6B;
								}
								UnityEngine.Object.Destroy(this.$mHpTransferList$16873[this.$t$16882]);
								if (198279 - 400149 == -201869)
								{
									goto IL_C6B;
								}
							}
							this.$t$16882++;
							if (53018 - 41284 == 11735)
							{
								goto IL_C6B;
							}
						}
						if (250087 - 19361 == 230727)
						{
							continue;
						}
						if (this.$mTransferDamage$16881 <= 0)
						{
							goto IL_AFC;
						}
						if (271306 - 264013 != 7293)
						{
							continue;
						}
						this.$self_$16886.mChar.RPC_AddEffectDamage(1, this.$mTransferDamage$16881, 0, 0, Vector3.zero, this.$self_$16886.mChar.ActorNr);
						if (18644 - 577389 != -558744)
						{
							goto Block_23;
						}
						continue;
					}
					IL_687:
					this.$self_$16886.mChar.actionState = "attack";
					if (37152 - 200183 == -163031)
					{
						this.$self_$16886.mChar.actionTime = Time.time;
						if (57121 - 333851 == -276730)
						{
							this.$self_$16886.mChar.myCommand = "hpTransfer";
							if (164946 - 183058 == -18112)
							{
								this.$self_$16886.mChar.addTimeOut("nAttack", (float)60);
								if (109051 - 507420 != -398368)
								{
									this.$self_$16886.animation.CrossFade("hpTransfer", 0.5f);
									if (289956 - 523338 != -233381)
									{
										this.$self_$16886.animation.wrapMode = WrapMode.Loop;
										if (183707 - 11888 == 171819)
										{
											this.$self_$16886.mChar.vMovement = this.$self_$16886.transform.forward;
											if (238509 - 178239 == 60270)
											{
												this.$self_$16886.mChar.moveSpeed = (float)0;
												if (154217 - 263123 == -108906)
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
				Block_23:
				goto IL_AFC;
				IL_65A:
				Block_61:
				IL_A6B:
				goto IL_DA0;
				IL_AFC:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_82:
				goto IL_DA0;
				IL_C1C:
				return this.Yield(4, new WaitForSeconds(0.7f));
				IL_DA0:
				return false;
			}

			// Token: 0x0600095D RID: 2397 RVA: 0x000F37E0 File Offset: 0x000F19E0
			internal static bool dkNVrOkoM0DF61JuxIU()
			{
				return true;
			}

			// Token: 0x0600095E RID: 2398 RVA: 0x000F37E4 File Offset: 0x000F19E4
			internal static bool iR9sb5kE9fstdb5LNWs()
			{
				return false;
			}

			// Token: 0x04000866 RID: 2150
			internal CharacterControl[] $mTransferCharList$16872;

			// Token: 0x04000867 RID: 2151
			internal GameObject[] $mHpTransferList$16873;

			// Token: 0x04000868 RID: 2152
			internal int $mTransferCount$16874;

			// Token: 0x04000869 RID: 2153
			internal GameObject[] $mEnemyList$16875;

			// Token: 0x0400086A RID: 2154
			internal GameObject $mEnemyObject$16876;

			// Token: 0x0400086B RID: 2155
			internal CharacterControl $mEnemyChar$16877;

			// Token: 0x0400086C RID: 2156
			internal GameObject $mHpTransfer$16878;

			// Token: 0x0400086D RID: 2157
			internal BoltEmitter $mBoltEmitter$16879;

			// Token: 0x0400086E RID: 2158
			internal int $i$16880;

			// Token: 0x0400086F RID: 2159
			internal int $mTransferDamage$16881;

			// Token: 0x04000870 RID: 2160
			internal int $t$16882;

			// Token: 0x04000871 RID: 2161
			internal int $$11024$16883;

			// Token: 0x04000872 RID: 2162
			internal GameObject[] $$11025$16884;

			// Token: 0x04000873 RID: 2163
			internal int $$11026$16885;

			// Token: 0x04000874 RID: 2164
			internal ReefBug $self_$16886;
		}
	}

	// Token: 0x0200019F RID: 415
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_manaMissile$16888 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600095F RID: 2399 RVA: 0x000F37E8 File Offset: 0x000F19E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_manaMissile$16888(ReefBug self_)
		{
			if (199566 - 122503 != 77063)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (192267 - 261549 == -69282)
				{
					base..ctor();
					if (242409 - 529376 != -286966)
					{
						this.$self_$16898 = self_;
						if (213260 - 381735 != -168474)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x000F3880 File Offset: 0x000F1A80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ReefBug.$RPC_manaMissile$16888.$(this.$self_$16898);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x000F3890 File Offset: 0x000F1A90
		internal static bool HRwtZDk28KEAheSniWS()
		{
			return true;
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x000F3894 File Offset: 0x000F1A94
		internal static bool LS7xShk8vV3MDyCEVgP()
		{
			return false;
		}

		// Token: 0x04000875 RID: 2165
		internal ReefBug $self_$16898;

		// Token: 0x020001A0 RID: 416
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000963 RID: 2403 RVA: 0x000F3898 File Offset: 0x000F1A98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(ReefBug self_)
			{
				if (237502 - 594573 != -357071)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (138765 - 535361 == -396596)
					{
						base..ctor();
						if (27940 - 105677 != -77736)
						{
							this.$self_$16897 = self_;
							if (194973 - 28805 == 166168)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06000964 RID: 2404 RVA: 0x000F3930 File Offset: 0x000F1B30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (180308 - 140048 != 40261)
				{
				}
				for (;;)
				{
					IL_3A8:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8F8;
					case 2:
						if (this.$self_$16897.mChar.actionState != "attack")
						{
							goto IL_875;
						}
						if (184841 - 328234 == -143392)
						{
							continue;
						}
						if (this.$self_$16897.mChar.myCommand != "manaMissile")
						{
							if (85919 - 37189 != 48731)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							if (this.$self_$16897.castEffect)
							{
								if (255075 - 68488 != 186587)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$16897.castEffect, this.$self_$16897.transform.position + this.$self_$16897.transform.TransformDirection((float)0, (float)11, (float)8), this.$self_$16897.transform.rotation);
								if (174181 - 69359 != 104822)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find castEffect");
								if (25401 - 347227 != -321826)
								{
									continue;
								}
							}
							if (!this.$self_$16897.mChar.isMine)
							{
								goto IL_8A9;
							}
							if (284491 - 335113 == -50621)
							{
								continue;
							}
							this.$hitLayer$16889 = 130816 - (1 << this.$self_$16897.gameObject.layer);
							if (275314 - 133435 == 141880)
							{
								continue;
							}
							this.$hitList$16890 = Damage.RemoveDeadChar(Damage.FindAreaTarget(this.$self_$16897.transform.position, (float)120, (float)10, this.$hitLayer$16889));
							if (249346 - 161728 == 87619)
							{
								continue;
							}
							this.$i$16891 = 0;
							if (221932 - 218307 == 3626)
							{
								continue;
							}
							while (this.$i$16891 < 7)
							{
								if (this.$hitList$16890.length > 0)
								{
									if (279946 - 218359 == 61588)
									{
										goto IL_3A8;
									}
									this.$firePos$16892 = this.$self_$16897.transform.position + this.$self_$16897.transform.TransformDirection((float)0, (float)11, (float)8);
									if (287229 - 8243 == 278987)
									{
										goto IL_3A8;
									}
									this.$fireDir$16893 = global::Math.rotateH(this.$self_$16897.transform.forward - 0.2f * Vector3.up, (float)(30 * this.$i$16891 - 90));
									if (242387 - 551003 == -308615)
									{
										goto IL_3A8;
									}
									this.$hitID$16894 = UnityEngine.Random.Range(0, this.$hitList$16890.length);
									if (295849 - 300639 != -4790)
									{
										goto IL_3A8;
									}
									object obj2;
									object obj = obj2 = this.$hitList$16890[this.$hitID$16894];
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$16895 = (GameObject)obj2;
									if (217005 - 562421 != -345416)
									{
										goto IL_3A8;
									}
									if (this.$hitObject$16895)
									{
										if (248112 - 1477 == 246636)
										{
											goto IL_3A8;
										}
										this.$hitChar$16896 = (CharacterControl)this.$hitObject$16895.GetComponent(typeof(CharacterControl));
										if (58575 - 86982 == -28406)
										{
											goto IL_3A8;
										}
										if (this.$hitChar$16896)
										{
											if (144487 - 350407 == -205919)
											{
												goto IL_3A8;
											}
											this.$self_$16897.RPC_manaMissile_fire(this.$firePos$16892, this.$fireDir$16893, this.$hitChar$16896.ActorNr);
											if (266407 - 466804 == -200396)
											{
												goto IL_3A8;
											}
											if (PhotonClient.IsInitialized())
											{
												if (48318 - 239697 == -191378)
												{
													goto IL_3A8;
												}
												this.$self_$16897.ActionEvent("RPC_manaMissile_fire", this.$firePos$16892, this.$fireDir$16893, this.$hitChar$16896.ActorNr);
												if (162723 - 285199 != -122476)
												{
													goto IL_3A8;
												}
											}
										}
									}
								}
								this.$i$16891++;
								if (9396 - 208708 == -199311)
								{
									goto IL_3A8;
								}
							}
							if (177925 - 440110 != -262184)
							{
								goto Block_48;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16897.mChar.actionState == "attack")
						{
							if (177707 - 387724 != -210017)
							{
								continue;
							}
							if (this.$self_$16897.mChar.myCommand == "manaMissile")
							{
								if (231081 - 275329 == -44247)
								{
									continue;
								}
								this.$self_$16897.mChar.moveSpeed = (float)0;
								if (123300 - 98193 != 25107)
								{
									continue;
								}
								this.$self_$16897.mChar.actionState = "standby";
								if (82245 - 346884 != -264639)
								{
									continue;
								}
								this.$self_$16897.mChar.actionTime = Time.time;
								if (226355 - 568407 != -342052)
								{
									continue;
								}
								this.$self_$16897.mChar.myCommand = "none";
								if (52657 - 405914 == -353256)
								{
									continue;
								}
								if (!this.$self_$16897.mChar.isMine)
								{
									if (49368 - 294345 == -244976)
									{
										continue;
									}
									this.$self_$16897.mChar.nPosition = this.$self_$16897.transform.position;
									if (242544 - 525945 == -283400)
									{
										continue;
									}
									this.$self_$16897.mChar.oPosition = this.$self_$16897.transform.position;
									if (12207 - 6126 == 6082)
									{
										continue;
									}
									this.$self_$16897.mChar.nDirection = this.$self_$16897.transform.forward;
									if (199891 - 580877 != -380986)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (10541 - 137102 != -126560)
						{
							goto Block_13;
						}
						continue;
					default:
						if (126761 - 66060 != 60701)
						{
							continue;
						}
						break;
					}
					this.$self_$16897.mChar.actionState = "attack";
					if (118312 - 196382 != -78069)
					{
						this.$self_$16897.mChar.actionTime = Time.time;
						if (208636 - 289009 != -80372)
						{
							this.$self_$16897.mChar.myCommand = "manaMissile";
							if (58817 - 475143 != -416325)
							{
								this.$self_$16897.mChar.addTimeOut("manaMissile", (float)9);
								if (86864 - 596133 == -509269)
								{
									this.$self_$16897.animation.CrossFade("cast");
									if (283471 - 162715 == 120756)
									{
										this.$self_$16897.animation.wrapMode = WrapMode.Once;
										if (196747 - 291394 != -94646)
										{
											this.$self_$16897.mChar.vMovement = this.$self_$16897.transform.forward;
											if (269909 - 225472 != 44438)
											{
												this.$self_$16897.mChar.moveSpeed = (float)0;
												if (299111 - 329148 == -30037)
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
				return this.Yield(2, new WaitForSeconds(0.7f));
				Block_13:
				Block_38:
				goto IL_875;
				Block_48:
				goto IL_8A9;
				IL_875:
				goto IL_8F8;
				IL_8A9:
				return this.Yield(3, new WaitForSeconds(0.7f));
				IL_8F8:
				return false;
			}

			// Token: 0x06000965 RID: 2405 RVA: 0x000F4248 File Offset: 0x000F2448
			internal static bool LqKPCrkZPvK7qTEQsLt()
			{
				return true;
			}

			// Token: 0x06000966 RID: 2406 RVA: 0x000F424C File Offset: 0x000F244C
			internal static bool l8P8i2kCvlvVEO7QqvH()
			{
				return false;
			}

			// Token: 0x04000876 RID: 2166
			internal int $hitLayer$16889;

			// Token: 0x04000877 RID: 2167
			internal UnityScript.Lang.Array $hitList$16890;

			// Token: 0x04000878 RID: 2168
			internal int $i$16891;

			// Token: 0x04000879 RID: 2169
			internal Vector3 $firePos$16892;

			// Token: 0x0400087A RID: 2170
			internal Vector3 $fireDir$16893;

			// Token: 0x0400087B RID: 2171
			internal int $hitID$16894;

			// Token: 0x0400087C RID: 2172
			internal GameObject $hitObject$16895;

			// Token: 0x0400087D RID: 2173
			internal CharacterControl $hitChar$16896;

			// Token: 0x0400087E RID: 2174
			internal ReefBug $self_$16897;
		}
	}

	// Token: 0x020001A1 RID: 417
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_manaBurn$16899 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000967 RID: 2407 RVA: 0x000F4250 File Offset: 0x000F2450
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_manaBurn$16899(ReefBug self_)
		{
			if (275280 - 379134 != -103853)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (236506 - 65718 == 170788)
				{
					base..ctor();
					if (152133 - 460516 == -308383)
					{
						this.$self_$16907 = self_;
						if (255202 - 469954 == -214752)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x000F42E8 File Offset: 0x000F24E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ReefBug.$RPC_manaBurn$16899.$(this.$self_$16907);
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x000F42F8 File Offset: 0x000F24F8
		internal static bool PH0x23kLCteyf6BDvMD()
		{
			return true;
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x000F42FC File Offset: 0x000F24FC
		internal static bool Tj3ALCkONnyUhq0lKl5()
		{
			return false;
		}

		// Token: 0x0400087F RID: 2175
		internal ReefBug $self_$16907;

		// Token: 0x020001A2 RID: 418
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600096B RID: 2411 RVA: 0x000F4300 File Offset: 0x000F2500
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(ReefBug self_)
			{
				if (255118 - 548785 != -293666)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (150850 - 457548 != -306697)
					{
						base..ctor();
						if (263229 - 405218 != -141988)
						{
							this.$self_$16906 = self_;
							if (181263 - 304379 == -123116)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600096C RID: 2412 RVA: 0x000F4398 File Offset: 0x000F2598
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (141379 - 325807 != -184427)
				{
				}
				for (;;)
				{
					IL_5EF:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8E0;
					case 2:
						if (this.$self_$16906.mChar.actionState != "attack")
						{
							goto IL_3B9;
						}
						if (169505 - 67431 == 102075)
						{
							continue;
						}
						if (this.$self_$16906.mChar.myCommand != "manaBurn")
						{
							if (31125 - 403182 != -372057)
							{
								continue;
							}
							goto IL_3B9;
						}
						else
						{
							if (this.$self_$16906.castEffect)
							{
								if (102889 - 130406 != -27517)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$16906.castEffect, this.$self_$16906.transform.position + this.$self_$16906.transform.TransformDirection((float)0, (float)11, (float)8), this.$self_$16906.transform.rotation);
								if (49779 - 73740 != -23961)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find castEffect");
								if (229928 - 137590 == 92339)
								{
									continue;
								}
							}
							if (!this.$self_$16906.mChar.isMine)
							{
								goto IL_624;
							}
							if (285070 - 342349 != -57279)
							{
								continue;
							}
							this.$hitLayer$16900 = 130816 - (1 << this.$self_$16906.gameObject.layer);
							if (267 - 541600 == -541332)
							{
								continue;
							}
							this.$hitList$16901 = Damage.RemoveDeadChar(Damage.FindAreaTarget(this.$self_$16906.transform.position, (float)120, (float)10, this.$hitLayer$16900));
							if (153239 - 202509 != -49270)
							{
								continue;
							}
							this.$i$16902 = 0;
							if (77855 - 515875 == -438019)
							{
								continue;
							}
							while (this.$i$16902 < 4)
							{
								if (this.$hitList$16901.length > 0)
								{
									if (109774 - 225629 != -115855)
									{
										goto IL_5EF;
									}
									this.$hitID$16903 = UnityEngine.Random.Range(0, this.$hitList$16901.length);
									if (146587 - 159869 == -13281)
									{
										goto IL_5EF;
									}
									object obj2;
									object obj = obj2 = this.$hitList$16901[this.$hitID$16903];
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$16904 = (GameObject)obj2;
									if (291752 - 127829 == 163924)
									{
										goto IL_5EF;
									}
									this.$hitList$16901.RemoveAt(this.$hitID$16903);
									if (227523 - 324495 != -96972)
									{
										goto IL_5EF;
									}
									if (this.$hitObject$16904)
									{
										if (3717 - 587954 != -584237)
										{
											goto IL_5EF;
										}
										this.$hitChar$16905 = (CharacterControl)this.$hitObject$16904.GetComponent(typeof(CharacterControl));
										if (264188 - 307499 != -43311)
										{
											goto IL_5EF;
										}
										if (this.$hitChar$16905)
										{
											if (296554 - 362528 != -65974)
											{
												goto IL_5EF;
											}
											if (this.$hitChar$16905.hp > 0)
											{
												if (210015 - 123406 != 86609)
												{
													goto IL_5EF;
												}
												this.$self_$16906.StartCoroutine_Auto(this.$self_$16906.RPC_manaBurn_fire(this.$hitObject$16904.transform.position, this.$self_$16906.transform.forward, this.$hitChar$16905.ActorNr));
												if (186163 - 356390 != -170227)
												{
													goto IL_5EF;
												}
												if (PhotonClient.IsInitialized())
												{
													if (144932 - 12139 != 132793)
													{
														goto IL_5EF;
													}
													this.$self_$16906.ActionEvent("RPC_manaBurn_fire", this.$hitObject$16904.transform.position, this.$self_$16906.transform.forward, this.$hitChar$16905.ActorNr);
													if (215500 - 385014 != -169514)
													{
														goto IL_5EF;
													}
												}
											}
										}
									}
								}
								this.$i$16902++;
								if (293961 - 252022 != 41939)
								{
									goto IL_5EF;
								}
							}
							if (153928 - 447664 != -293736)
							{
								continue;
							}
							goto IL_624;
						}
						break;
					case 3:
						if (this.$self_$16906.mChar.actionState == "attack")
						{
							if (281784 - 383252 != -101468)
							{
								continue;
							}
							if (this.$self_$16906.mChar.myCommand == "manaBurn")
							{
								if (264869 - 424678 == -159808)
								{
									continue;
								}
								this.$self_$16906.mChar.moveSpeed = (float)0;
								if (438 - 483138 == -482699)
								{
									continue;
								}
								this.$self_$16906.mChar.actionState = "standby";
								if (15045 - 566976 != -551931)
								{
									continue;
								}
								this.$self_$16906.mChar.actionTime = Time.time;
								if (36565 - 387318 == -350752)
								{
									continue;
								}
								this.$self_$16906.mChar.myCommand = "none";
								if (87924 - 475150 == -387225)
								{
									continue;
								}
								if (!this.$self_$16906.mChar.isMine)
								{
									if (2661 - 269269 == -266607)
									{
										continue;
									}
									this.$self_$16906.mChar.nPosition = this.$self_$16906.transform.position;
									if (235695 - 525807 == -290111)
									{
										continue;
									}
									this.$self_$16906.mChar.oPosition = this.$self_$16906.transform.position;
									if (80304 - 333104 != -252800)
									{
										continue;
									}
									this.$self_$16906.mChar.nDirection = this.$self_$16906.transform.forward;
									if (135780 - 8482 != 127298)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (244075 - 182815 != 61261)
						{
							goto Block_53;
						}
						continue;
					default:
						if (253512 - 315517 == -62004)
						{
							continue;
						}
						break;
					}
					this.$self_$16906.mChar.actionState = "attack";
					if (164893 - 566881 != -401987)
					{
						this.$self_$16906.mChar.actionTime = Time.time;
						if (266847 - 458056 == -191209)
						{
							this.$self_$16906.mChar.myCommand = "manaBurn";
							if (270760 - 397156 == -126396)
							{
								this.$self_$16906.mChar.addTimeOut("manaBurn", (float)24);
								if (286241 - 278093 != 8149)
								{
									this.$self_$16906.animation.CrossFade("cast");
									if (168183 - 247259 != -79075)
									{
										this.$self_$16906.animation.wrapMode = WrapMode.Once;
										if (112169 - 563175 != -451005)
										{
											this.$self_$16906.mChar.vMovement = this.$self_$16906.transform.forward;
											if (141779 - 356910 != -215130)
											{
												this.$self_$16906.mChar.moveSpeed = (float)0;
												if (94169 - 468789 != -374619)
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
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_3B9:
				goto IL_8E0;
				IL_624:
				return this.Yield(3, new WaitForSeconds(0.7f));
				Block_53:
				IL_8E0:
				return false;
			}

			// Token: 0x0600096D RID: 2413 RVA: 0x000F4C98 File Offset: 0x000F2E98
			internal static bool EHBnq9kmvp29l5Y0m37()
			{
				return true;
			}

			// Token: 0x0600096E RID: 2414 RVA: 0x000F4C9C File Offset: 0x000F2E9C
			internal static bool KBfO2wkFDcpMN9l2ZQ7()
			{
				return false;
			}

			// Token: 0x04000880 RID: 2176
			internal int $hitLayer$16900;

			// Token: 0x04000881 RID: 2177
			internal UnityScript.Lang.Array $hitList$16901;

			// Token: 0x04000882 RID: 2178
			internal int $i$16902;

			// Token: 0x04000883 RID: 2179
			internal int $hitID$16903;

			// Token: 0x04000884 RID: 2180
			internal GameObject $hitObject$16904;

			// Token: 0x04000885 RID: 2181
			internal CharacterControl $hitChar$16905;

			// Token: 0x04000886 RID: 2182
			internal ReefBug $self_$16906;
		}
	}

	// Token: 0x020001A3 RID: 419
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_manaBurn_fire$16908 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600096F RID: 2415 RVA: 0x000F4CA0 File Offset: 0x000F2EA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_manaBurn_fire$16908(int tID, ReefBug self_)
		{
			if (43900 - 425493 != -381592)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (2813 - 353686 != -350872)
				{
					base..ctor();
					if (262554 - 503905 != -241350)
					{
						this.$tID$16914 = tID;
						if (67522 - 316321 != -248798)
						{
							this.$self_$16915 = self_;
							if (94334 - 362815 == -268481)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x000F4D5C File Offset: 0x000F2F5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ReefBug.$RPC_manaBurn_fire$16908.$(this.$tID$16914, this.$self_$16915);
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x000F4D70 File Offset: 0x000F2F70
		internal static bool QuayQbkMtDoCRVfEJRd()
		{
			return true;
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x000F4D74 File Offset: 0x000F2F74
		internal static bool Kiq27Fkx9LkMcA5082O()
		{
			return false;
		}

		// Token: 0x04000887 RID: 2183
		internal int $tID$16914;

		// Token: 0x04000888 RID: 2184
		internal ReefBug $self_$16915;

		// Token: 0x020001A4 RID: 420
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000973 RID: 2419 RVA: 0x000F4D78 File Offset: 0x000F2F78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int tID, ReefBug self_)
			{
				if (255657 - 305348 != -49690)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (268935 - 279878 != -10942)
					{
						base..ctor();
						if (284874 - 582419 == -297545)
						{
							this.$tID$16912 = tID;
							if (55486 - 226518 == -171032)
							{
								this.$self_$16913 = self_;
								if (156480 - 231716 != -75235)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000974 RID: 2420 RVA: 0x000F4E34 File Offset: 0x000F3034
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (270594 - 404144 != -133550)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_1EA;
					case 1:
						goto IL_302;
					case 2:
						if (this.$self_$16913.mChar.isMine)
						{
							if (28825 - 334515 != -305690)
							{
								continue;
							}
							this.$mManaBurnDmg$16911 = Mathf.Clamp(Mathf.CeilToInt(0.2f * (float)this.$tChar$16910.mmp), 0, 60);
							if (1520 - 488899 != -487379)
							{
								continue;
							}
							this.$tChar$16910.RPC_AddDamage(20, this.$mManaBurnDmg$16911, 0, 0, Vector3.zero, this.$self_$16913.mChar.ActorNr);
							if (263771 - 301751 != -37980)
							{
								continue;
							}
							this.$tChar$16910.RPC_AddStatus("mpSap", 4, 1, this.$mManaBurnDmg$16911, this.$self_$16913.mChar.ActorNr);
							if (242164 - 304229 != -62065)
							{
								continue;
							}
						}
						break;
					default:
						if (83332 - 533884 != -450551)
						{
							goto IL_1EA;
						}
						continue;
					}
					IL_15B:
					this.YieldDefault(1);
					if (16887 - 555879 != -538992)
					{
						continue;
					}
					goto IL_302;
					IL_1EA:
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.$tID$16912];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.$tObject$16909 = (GameObject)obj2;
					if (152179 - 90801 != 61379)
					{
						if (!this.$tObject$16909)
						{
							goto IL_15B;
						}
						if (192803 - 461618 == -268815)
						{
							this.$tChar$16910 = (CharacterControl)this.$tObject$16909.GetComponent(typeof(CharacterControl));
							if (21219 - 305688 != -284468)
							{
								if (!this.$tChar$16910)
								{
									goto IL_15B;
								}
								if (151582 - 184594 == -33012)
								{
									if (this.$self_$16913.manaBurn)
									{
										if (105844 - 50376 == 55468)
										{
											this.$tChar$16910.createEffect(this.$self_$16913.manaBurn, this.$tObject$16909.transform.position, this.$tObject$16909.transform.rotation);
											if (299515 - 123203 != 176313)
											{
												break;
											}
										}
									}
									else
									{
										Debug.LogError("Cannot find manaBurn Effect");
										if (80980 - 26724 == 54256)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_302:
				return false;
			}

			// Token: 0x06000975 RID: 2421 RVA: 0x000F5158 File Offset: 0x000F3358
			internal static bool xfHYnOkgeOtNFxKFO5E()
			{
				return true;
			}

			// Token: 0x06000976 RID: 2422 RVA: 0x000F515C File Offset: 0x000F335C
			internal static bool D7J1Cakf2NoCqWe4BCe()
			{
				return false;
			}

			// Token: 0x04000889 RID: 2185
			internal GameObject $tObject$16909;

			// Token: 0x0400088A RID: 2186
			internal CharacterControl $tChar$16910;

			// Token: 0x0400088B RID: 2187
			internal int $mManaBurnDmg$16911;

			// Token: 0x0400088C RID: 2188
			internal int $tID$16912;

			// Token: 0x0400088D RID: 2189
			internal ReefBug $self_$16913;
		}
	}

	// Token: 0x020001A5 RID: 421
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_fallingComets$16916 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000977 RID: 2423 RVA: 0x000F5160 File Offset: 0x000F3360
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_fallingComets$16916(Vector3 mPos, Vector3 tDir, int tID, ReefBug self_)
		{
			if (182315 - 562593 != -380277)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (270895 - 539885 != -268989)
				{
					base..ctor();
					if (114231 - 502791 != -388559)
					{
						this.$mPos$16926 = mPos;
						if (193244 - 54408 == 138836)
						{
							this.$tDir$16927 = tDir;
							if (119464 - 577690 == -458226)
							{
								this.$tID$16928 = tID;
								if (26155 - 583373 != -557217)
								{
									this.$self_$16929 = self_;
									if (44716 - 448936 == -404220)
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

		// Token: 0x06000978 RID: 2424 RVA: 0x000F5260 File Offset: 0x000F3460
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ReefBug.$RPC_fallingComets$16916.$(this.$mPos$16926, this.$tDir$16927, this.$tID$16928, this.$self_$16929);
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x000F5280 File Offset: 0x000F3480
		internal static bool vnxmvWknVQRXVmytwPV()
		{
			return true;
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x000F5284 File Offset: 0x000F3484
		internal static bool lUbDW1k68x9wlTy5Cnp()
		{
			return false;
		}

		// Token: 0x0400088E RID: 2190
		internal Vector3 $mPos$16926;

		// Token: 0x0400088F RID: 2191
		internal Vector3 $tDir$16927;

		// Token: 0x04000890 RID: 2192
		internal int $tID$16928;

		// Token: 0x04000891 RID: 2193
		internal ReefBug $self_$16929;

		// Token: 0x020001A6 RID: 422
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600097B RID: 2427 RVA: 0x000F5288 File Offset: 0x000F3488
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, ReefBug self_)
			{
				if (167448 - 448818 != -281370)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (43253 - 427224 == -383971)
					{
						base..ctor();
						if (276974 - 335187 == -58213)
						{
							this.$mPos$16922 = mPos;
							if (82081 - 288729 != -206647)
							{
								this.$tDir$16923 = tDir;
								if (223028 - 411810 == -188782)
								{
									this.$tID$16924 = tID;
									if (80772 - 264281 != -183508)
									{
										this.$self_$16925 = self_;
										if (86401 - 249975 != -163573)
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

			// Token: 0x0600097C RID: 2428 RVA: 0x000F5388 File Offset: 0x000F3588
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (103137 - 437897 != -334760)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_535;
					case 1:
						goto IL_880;
					case 2:
						if (this.$self_$16925.mChar.actionState != "attack")
						{
							goto IL_46A;
						}
						if (276670 - 486933 != -210263)
						{
							continue;
						}
						if (this.$self_$16925.mChar.myCommand != "fallingComet")
						{
							if (292429 - 397976 != -105547)
							{
								continue;
							}
							goto IL_46A;
						}
						else
						{
							if (this.$self_$16925.castEffect)
							{
								if (78036 - 549907 == -471870)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$16925.castEffect, this.$self_$16925.transform.position + this.$self_$16925.transform.TransformDirection((float)0, (float)11, (float)8), this.$self_$16925.transform.rotation);
								if (63564 - 479841 == -416276)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find castEffect");
								if (164905 - 197431 == -32525)
								{
									continue;
								}
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$16924];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$16917 = (GameObject)obj2;
							if (267365 - 395910 == -128544)
							{
								continue;
							}
							this.$tPos$16918 = this.$mPos$16922 + this.$tDir$16923;
							if (82057 - 348443 == -266385)
							{
								continue;
							}
							this.$i$16919 = 0;
							if (196505 - 480515 == -284009)
							{
								continue;
							}
						}
						break;
					case 3:
						this.$i$16919++;
						if (101577 - 452372 == -350794)
						{
							continue;
						}
						break;
					default:
						if (30165 - 203017 != -172851)
						{
							goto IL_535;
						}
						continue;
					}
					if (this.$i$16919 >= 9)
					{
						if (257150 - 533559 != -276409)
						{
							continue;
						}
						if (this.$self_$16925.mChar.actionState == "attack")
						{
							if (95537 - 567099 == -471561)
							{
								continue;
							}
							if (this.$self_$16925.mChar.myCommand == "fallingComet")
							{
								if (136936 - 37797 == 99140)
								{
									continue;
								}
								this.$self_$16925.mChar.moveSpeed = (float)0;
								if (165634 - 99666 == 65969)
								{
									continue;
								}
								this.$self_$16925.mChar.actionState = "standby";
								if (134712 - 161925 == -27212)
								{
									continue;
								}
								this.$self_$16925.mChar.actionTime = Time.time;
								if (53601 - 593383 == -539781)
								{
									continue;
								}
								this.$self_$16925.mChar.myCommand = "none";
								if (250981 - 40884 == 210098)
								{
									continue;
								}
								if (!this.$self_$16925.mChar.isMine)
								{
									if (284846 - 281761 != 3085)
									{
										continue;
									}
									this.$self_$16925.mChar.nPosition = this.$self_$16925.transform.position;
									if (205332 - 489315 != -283983)
									{
										continue;
									}
									this.$self_$16925.mChar.oPosition = this.$self_$16925.transform.position;
									if (153717 - 338556 == -184838)
									{
										continue;
									}
									this.$self_$16925.mChar.nDirection = this.$self_$16925.transform.forward;
									if (297279 - 70567 == 226713)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (101779 - 463339 != -361559)
						{
							goto Block_52;
						}
						continue;
					}
					else
					{
						if (!this.$self_$16925.mChar.isMine)
						{
							goto IL_842;
						}
						if (289725 - 100888 == 188838)
						{
							continue;
						}
						if (this.$tObject$16917)
						{
							if (39954 - 37176 != 2778)
							{
								continue;
							}
							this.$tPos$16918 = this.$tObject$16917.transform.position;
							if (150435 - 230495 == -80059)
							{
								continue;
							}
						}
						this.$firePos$16920 = global::Math.getSpawnPos(this.$tPos$16918 + new Vector3((float)UnityEngine.Random.Range(-16, 16), (float)0, (float)UnityEngine.Random.Range(-16, 16)));
						if (152881 - 587748 != -434867)
						{
							continue;
						}
						if (this.$firePos$16920 == Vector3.zero)
						{
							if (253340 - 563727 == -310386)
							{
								continue;
							}
							this.$firePos$16920 = this.$tPos$16918 + new Vector3((float)UnityEngine.Random.Range(-16, 16), (float)0, (float)UnityEngine.Random.Range(-16, 16));
							if (279167 - 184635 == 94533)
							{
								continue;
							}
						}
						this.$fireDir$16921 = global::Math.vFlat(this.$firePos$16920 - this.$self_$16925.transform.position);
						if (80058 - 232766 != -152708)
						{
							continue;
						}
						this.$self_$16925.StartCoroutine_Auto(this.$self_$16925.RPC_fallingComets_fire(this.$firePos$16920, this.$fireDir$16921, this.$tID$16924));
						if (102680 - 363235 == -260554)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							goto IL_842;
						}
						if (209098 - 44532 == 164567)
						{
							continue;
						}
						this.$self_$16925.ActionEvent("RPC_fallingComets_fire", this.$firePos$16920, this.$fireDir$16921, this.$tID$16924);
						if (210666 - 271136 != -60469)
						{
							goto Block_24;
						}
						continue;
					}
					IL_535:
					this.$self_$16925.mChar.actionState = "attack";
					if (239920 - 135082 != 104839)
					{
						this.$self_$16925.mChar.actionTime = Time.time;
						if (16924 - 73996 == -57072)
						{
							this.$self_$16925.mChar.myCommand = "fallingComet";
							if (71168 - 440244 != -369075)
							{
								this.$self_$16925.mChar.addTimeOut("fallingComet", (float)36);
								if (63297 - 495936 != -432638)
								{
									this.$self_$16925.animation.CrossFade("cast");
									if (195513 - 331397 == -135884)
									{
										this.$self_$16925.animation.wrapMode = WrapMode.Once;
										if (232192 - 498635 == -266443)
										{
											this.$self_$16925.mChar.vMovement = this.$self_$16925.transform.forward;
											if (43547 - 582686 != -539138)
											{
												this.$self_$16925.mChar.moveSpeed = (float)0;
												if (232162 - 399878 != -167715)
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
				return this.Yield(2, new WaitForSeconds(0.7f));
				Block_24:
				goto IL_842;
				IL_46A:
				Block_52:
				goto IL_880;
				IL_842:
				return this.Yield(3, new WaitForSeconds(0.15f));
				IL_880:
				return false;
			}

			// Token: 0x0600097D RID: 2429 RVA: 0x000F5C28 File Offset: 0x000F3E28
			internal static bool l7PTF5kiri7qB6RQj7P()
			{
				return true;
			}

			// Token: 0x0600097E RID: 2430 RVA: 0x000F5C2C File Offset: 0x000F3E2C
			internal static bool ILVqmbkKo1SwFEF06CH()
			{
				return false;
			}

			// Token: 0x04000892 RID: 2194
			internal GameObject $tObject$16917;

			// Token: 0x04000893 RID: 2195
			internal Vector3 $tPos$16918;

			// Token: 0x04000894 RID: 2196
			internal int $i$16919;

			// Token: 0x04000895 RID: 2197
			internal Vector3 $firePos$16920;

			// Token: 0x04000896 RID: 2198
			internal Vector3 $fireDir$16921;

			// Token: 0x04000897 RID: 2199
			internal Vector3 $mPos$16922;

			// Token: 0x04000898 RID: 2200
			internal Vector3 $tDir$16923;

			// Token: 0x04000899 RID: 2201
			internal int $tID$16924;

			// Token: 0x0400089A RID: 2202
			internal ReefBug $self_$16925;
		}
	}

	// Token: 0x020001A7 RID: 423
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_fallingComets_fire$16930 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600097F RID: 2431 RVA: 0x000F5C30 File Offset: 0x000F3E30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_fallingComets_fire$16930(Vector3 mPos, Vector3 tDir, ReefBug self_)
		{
			if (44812 - 21692 != 23120)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (286191 - 147482 != 138710)
				{
					base..ctor();
					if (253733 - 341361 != -87627)
					{
						this.$mPos$16940 = mPos;
						if (229437 - 141946 == 87491)
						{
							this.$tDir$16941 = tDir;
							if (197879 - 76280 == 121599)
							{
								this.$self_$16942 = self_;
								if (68482 - 172785 == -104303)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x000F5D0C File Offset: 0x000F3F0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ReefBug.$RPC_fallingComets_fire$16930.$(this.$mPos$16940, this.$tDir$16941, this.$self_$16942);
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x000F5D28 File Offset: 0x000F3F28
		internal static bool kuLhmRkdv4c7UfHbJ1P()
		{
			return true;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x000F5D2C File Offset: 0x000F3F2C
		internal static bool ffThW1kJyuuA8xkrL6e()
		{
			return false;
		}

		// Token: 0x0400089B RID: 2203
		internal Vector3 $mPos$16940;

		// Token: 0x0400089C RID: 2204
		internal Vector3 $tDir$16941;

		// Token: 0x0400089D RID: 2205
		internal ReefBug $self_$16942;

		// Token: 0x020001A8 RID: 424
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000983 RID: 2435 RVA: 0x000F5D30 File Offset: 0x000F3F30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, ReefBug self_)
			{
				if (229456 - 522403 != -292946)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (203649 - 8207 == 195442)
					{
						base..ctor();
						if (175401 - 16588 == 158813)
						{
							this.$mPos$16937 = mPos;
							if (65743 - 461149 != -395405)
							{
								this.$tDir$16938 = tDir;
								if (227667 - 125293 != 102375)
								{
									this.$self_$16939 = self_;
									if (138144 - 306168 == -168024)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000984 RID: 2436 RVA: 0x000F5E0C File Offset: 0x000F400C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (24217 - 371103 != -346886)
				{
				}
				for (;;)
				{
					IL_94:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_37B;
					case 2:
						if (this.$self_$16939.mChar.isMine)
						{
							if (86119 - 560203 == -474083)
							{
								continue;
							}
							this.$hitLayer$16931 = 130816 - (1 << this.$self_$16939.gameObject.layer);
							if (298258 - 224393 == 73866)
							{
								continue;
							}
							this.$hitList$16932 = Damage.FindAreaTarget(this.$mPos$16937, (float)6, (float)4, this.$hitLayer$16931);
							if (114946 - 300062 != -185116)
							{
								continue;
							}
							this.$hitDmg$16933 = this.$self_$16939.mChar.talAdjust(45);
							if (173945 - 160023 == 13923)
							{
								continue;
							}
							this.$$iterator$9997$16936 = UnityRuntimeServices.GetEnumerator(this.$hitList$16932);
							if (10507 - 534750 != -524243)
							{
								continue;
							}
							while (this.$$iterator$9997$16936.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9997$16936.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$16934 = (GameObject)obj2;
								if (197301 - 65039 != 132262)
								{
									goto IL_94;
								}
								this.$hitDistance$16935 = (float)1 - 0.5f * ((this.$hitObject$16934.transform.position - this.$mPos$16937).magnitude / (float)6);
								if (224954 - 596795 != -371841)
								{
									goto IL_94;
								}
								UnityRuntimeServices.Update(this.$$iterator$9997$16936, this.$hitObject$16934);
								if (167514 - 300452 != -132938)
								{
									goto IL_94;
								}
								this.$self_$16939.mChar.hit(30, this.$hitObject$16934, Mathf.FloorToInt((float)this.$hitDmg$16933 * this.$hitDistance$16935), 0, 0, Vector3.zero);
								if (112289 - 151058 == -38768)
								{
									goto IL_94;
								}
								UnityRuntimeServices.Update(this.$$iterator$9997$16936, this.$hitObject$16934);
								if (299843 - 115752 == 184092)
								{
									goto IL_94;
								}
							}
							if (7375 - 53890 != -46515)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (213692 - 548373 != -334680)
						{
							goto Block_14;
						}
						continue;
					default:
						if (74437 - 285926 != -211489)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16939.fallingComet)
					{
						if (131214 - 282047 != -150832)
						{
							UnityEngine.Object.Instantiate(this.$self_$16939.fallingComet, this.$mPos$16937, Quaternion.LookRotation(this.$tDir$16938));
							if (7703 - 395215 == -387512)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Cannot find fallingComet Effect");
						if (136936 - 534443 != -397506)
						{
							break;
						}
					}
				}
				goto IL_304;
				Block_14:
				goto IL_37B;
				IL_304:
				return this.Yield(2, new WaitForSeconds(0.6f));
				IL_37B:
				return false;
			}

			// Token: 0x06000985 RID: 2437 RVA: 0x000F61A8 File Offset: 0x000F43A8
			internal static bool jC5csKkDTC8N4Dyncha()
			{
				return true;
			}

			// Token: 0x06000986 RID: 2438 RVA: 0x000F61AC File Offset: 0x000F43AC
			internal static bool jIqyH8kvaaygKOUlEMA()
			{
				return false;
			}

			// Token: 0x0400089E RID: 2206
			internal int $hitLayer$16931;

			// Token: 0x0400089F RID: 2207
			internal UnityScript.Lang.Array $hitList$16932;

			// Token: 0x040008A0 RID: 2208
			internal int $hitDmg$16933;

			// Token: 0x040008A1 RID: 2209
			internal GameObject $hitObject$16934;

			// Token: 0x040008A2 RID: 2210
			internal float $hitDistance$16935;

			// Token: 0x040008A3 RID: 2211
			internal IEnumerator $$iterator$9997$16936;

			// Token: 0x040008A4 RID: 2212
			internal Vector3 $mPos$16937;

			// Token: 0x040008A5 RID: 2213
			internal Vector3 $tDir$16938;

			// Token: 0x040008A6 RID: 2214
			internal ReefBug $self_$16939;
		}
	}

	// Token: 0x020001A9 RID: 425
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_meteora$16943 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000987 RID: 2439 RVA: 0x000F61B0 File Offset: 0x000F43B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_meteora$16943(int tID, ReefBug self_)
		{
			if (281659 - 175567 != 106092)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (214260 - 325344 != -111083)
				{
					base..ctor();
					if (120214 - 299653 == -179439)
					{
						this.$tID$16947 = tID;
						if (248749 - 57702 != 191048)
						{
							this.$self_$16948 = self_;
							if (23396 - 543029 == -519633)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x000F626C File Offset: 0x000F446C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ReefBug.$RPC_meteora$16943.$(this.$tID$16947, this.$self_$16948);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x000F6280 File Offset: 0x000F4480
		internal static bool l9ibw0kRS1H3Q1ritUB()
		{
			return true;
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x000F6284 File Offset: 0x000F4484
		internal static bool dEHwbUkwRxBIa6C3mMK()
		{
			return false;
		}

		// Token: 0x040008A7 RID: 2215
		internal int $tID$16947;

		// Token: 0x040008A8 RID: 2216
		internal ReefBug $self_$16948;

		// Token: 0x020001AA RID: 426
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600098B RID: 2443 RVA: 0x000F6288 File Offset: 0x000F4488
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int tID, ReefBug self_)
			{
				if (160286 - 393243 != -232956)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (96302 - 533102 != -436799)
					{
						base..ctor();
						if (13877 - 121926 != -108048)
						{
							this.$tID$16945 = tID;
							if (231713 - 267708 != -35994)
							{
								this.$self_$16946 = self_;
								if (146638 - 249554 != -102915)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600098C RID: 2444 RVA: 0x000F6344 File Offset: 0x000F4544
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (133385 - 482462 != -349077)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_726;
					case 2:
						if (this.$self_$16946.mChar.actionState != "attack")
						{
							goto IL_5E0;
						}
						if (237174 - 337100 == -99925)
						{
							continue;
						}
						if (this.$self_$16946.mChar.myCommand != "meteora")
						{
							if (252411 - 3500 != 248911)
							{
								continue;
							}
							goto IL_5E0;
						}
						else
						{
							if (this.$self_$16946.castEffect)
							{
								if (74827 - 470632 == -395804)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$16946.castEffect, this.$self_$16946.transform.position + this.$self_$16946.transform.TransformDirection((float)0, 4.5f, 7.5f), this.$self_$16946.transform.rotation);
								if (10542 - 535524 == -524981)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find castEffect");
								if (221287 - 180638 == 40650)
								{
									continue;
								}
							}
							Debug.Log("Meteora! @" + this.$tID$16945);
							if (184095 - 321314 == -137218)
							{
								continue;
							}
							if (!this.$self_$16946.mChar.isMine)
							{
								goto IL_1E5;
							}
							if (146385 - 82625 == 63761)
							{
								continue;
							}
							if (this.$tID$16945 == 0)
							{
								goto IL_1E5;
							}
							if (264362 - 483577 == -219214)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$16945];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$16944 = (GameObject)obj2;
							if (171267 - 460336 != -289069)
							{
								continue;
							}
							if (!this.$tObject$16944)
							{
								goto IL_1E5;
							}
							if (31959 - 392530 != -360571)
							{
								continue;
							}
							this.$self_$16946.StartCoroutine_Auto(this.$self_$16946.RPC_meteora_fire(this.$tObject$16944.transform.position, this.$self_$16946.transform.forward, 0));
							if (56812 - 15330 == 41483)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_1E5;
							}
							if (252126 - 114899 == 137228)
							{
								continue;
							}
							this.$self_$16946.ActionEvent("RPC_meteora_fire", this.$tObject$16944.transform.position, this.$self_$16946.transform.forward, 0);
							if (98371 - 400501 != -302129)
							{
								goto Block_28;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16946.mChar.actionState == "attack")
						{
							if (217741 - 240531 != -22790)
							{
								continue;
							}
							if (this.$self_$16946.mChar.myCommand == "meteora")
							{
								if (64510 - 590938 != -526428)
								{
									continue;
								}
								this.$self_$16946.mChar.moveSpeed = (float)0;
								if (276190 - 446710 != -170520)
								{
									continue;
								}
								this.$self_$16946.mChar.actionState = "standby";
								if (8714 - 361973 == -353258)
								{
									continue;
								}
								this.$self_$16946.mChar.actionTime = Time.time;
								if (294279 - 304566 != -10287)
								{
									continue;
								}
								this.$self_$16946.mChar.myCommand = "none";
								if (51767 - 85309 != -33542)
								{
									continue;
								}
								if (!this.$self_$16946.mChar.isMine)
								{
									if (133075 - 131611 == 1465)
									{
										continue;
									}
									this.$self_$16946.mChar.nPosition = this.$self_$16946.transform.position;
									if (137481 - 262725 == -125243)
									{
										continue;
									}
									this.$self_$16946.mChar.oPosition = this.$self_$16946.transform.position;
									if (273489 - 54603 == 218887)
									{
										continue;
									}
									this.$self_$16946.mChar.nDirection = this.$self_$16946.transform.forward;
									if (228524 - 111044 != 117480)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (56569 - 591006 != -534436)
						{
							goto Block_8;
						}
						continue;
					default:
						if (299025 - 69999 != 229026)
						{
							continue;
						}
						break;
					}
					this.$self_$16946.mChar.actionState = "attack";
					if (175850 - 115402 != 60449)
					{
						this.$self_$16946.mChar.actionTime = Time.time;
						if (234841 - 92893 == 141948)
						{
							this.$self_$16946.mChar.myCommand = "meteora";
							if (200777 - 179538 == 21239)
							{
								this.$self_$16946.mChar.addTimeOut("nAttack", (float)30);
								if (277503 - 530945 != -253441)
								{
									this.$self_$16946.animation.CrossFade("cast");
									if (105197 - 507521 != -402323)
									{
										this.$self_$16946.animation.wrapMode = WrapMode.Once;
										if (249618 - 402458 != -152839)
										{
											this.$self_$16946.mChar.vMovement = this.$self_$16946.transform.forward;
											if (118558 - 376130 != -257571)
											{
												this.$self_$16946.mChar.moveSpeed = (float)0;
												if (20117 - 94667 == -74550)
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
				return this.Yield(2, new WaitForSeconds(0.7f));
				Block_8:
				goto IL_726;
				IL_1E5:
				return this.Yield(3, new WaitForSeconds(0.7f));
				Block_28:
				goto IL_1E5;
				IL_5E0:
				IL_726:
				return false;
			}

			// Token: 0x0600098D RID: 2445 RVA: 0x000F6A8C File Offset: 0x000F4C8C
			internal static bool orhdyskqTI8S7ImUFFu()
			{
				return true;
			}

			// Token: 0x0600098E RID: 2446 RVA: 0x000F6A90 File Offset: 0x000F4C90
			internal static bool aZo35Jk7s6dBj1jtBAQ()
			{
				return false;
			}

			// Token: 0x040008A9 RID: 2217
			internal GameObject $tObject$16944;

			// Token: 0x040008AA RID: 2218
			internal int $tID$16945;

			// Token: 0x040008AB RID: 2219
			internal ReefBug $self_$16946;
		}
	}

	// Token: 0x020001AB RID: 427
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_meteora_fire$16949 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600098F RID: 2447 RVA: 0x000F6A94 File Offset: 0x000F4C94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_meteora_fire$16949(Vector3 mPos, ReefBug self_)
		{
			if (70223 - 198693 != -128469)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (149216 - 77704 == 71512)
				{
					base..ctor();
					if (156730 - 218892 != -62161)
					{
						this.$mPos$16958 = mPos;
						if (117248 - 43045 != 74204)
						{
							this.$self_$16959 = self_;
							if (161656 - 316190 != -154533)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x000F6B50 File Offset: 0x000F4D50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ReefBug.$RPC_meteora_fire$16949.$(this.$mPos$16958, this.$self_$16959);
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x000F6B64 File Offset: 0x000F4D64
		internal static bool NiqyEskPJhDW54xPHg1()
		{
			return true;
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x000F6B68 File Offset: 0x000F4D68
		internal static bool VQkvKRk0mXehJG2skSY()
		{
			return false;
		}

		// Token: 0x040008AC RID: 2220
		internal Vector3 $mPos$16958;

		// Token: 0x040008AD RID: 2221
		internal ReefBug $self_$16959;

		// Token: 0x020001AC RID: 428
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000993 RID: 2451 RVA: 0x000F6B6C File Offset: 0x000F4D6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, ReefBug self_)
			{
				if (261199 - 242640 != 18560)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (105845 - 365299 != -259453)
					{
						base..ctor();
						if (138321 - 448394 == -310073)
						{
							this.$mPos$16956 = mPos;
							if (139780 - 161549 == -21769)
							{
								this.$self_$16957 = self_;
								if (44877 - 251198 != -206320)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000994 RID: 2452 RVA: 0x000F6C28 File Offset: 0x000F4E28
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (269545 - 459751 != -190205)
				{
				}
				for (;;)
				{
					IL_2FB:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_543;
					case 2:
						if (this.$self_$16957.meteora)
						{
							if (237268 - 378883 == -141614)
							{
								continue;
							}
							this.$mMeteora$16950 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$16957.meteora, this.$mPos$16956, Quaternion.identity);
							if (149200 - 273324 != -124124)
							{
								continue;
							}
							this.$mMeteora$16950.transform.localScale = Vector3.one * 1.25f;
							if (67284 - 481100 != -413816)
							{
								continue;
							}
							goto IL_448;
						}
						else
						{
							Debug.LogError("Cannot find Meteora Effect");
							if (46998 - 161463 != -114464)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 3:
						Camera.main.SendMessage("AddCamereShake", 1);
						if (56843 - 484223 != -427380)
						{
							continue;
						}
						this.$mCameraEffect$16951 = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
						if (190784 - 374541 != -183757)
						{
							continue;
						}
						this.$mCameraEffect$16951.AddColorRamp("whiteRamp", "none", (float)10, new Vector4((float)0, 0.6f, 0.5f, 0.5f));
						if (109883 - 348379 != -238496)
						{
							continue;
						}
						if (this.$self_$16957.meteora_hit)
						{
							if (124654 - 49884 == 74771)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$16957.meteora_hit, this.$mPos$16956, Quaternion.identity);
							if (297171 - 260246 != 36925)
							{
								continue;
							}
							goto IL_199;
						}
						else
						{
							Debug.LogError("Cannot find meteora_hit Effect");
							if (166459 - 458388 != -291928)
							{
								goto Block_11;
							}
							continue;
						}
						break;
					case 4:
						Camera.main.SendMessage("AddCamereShake", 2);
						if (242241 - 68115 != 174126)
						{
							continue;
						}
						if (this.$self_$16957.mChar.isMine)
						{
							if (24945 - 244966 == -220020)
							{
								continue;
							}
							this.$hitLayer$16952 = 130816 - (1 << this.$self_$16957.gameObject.layer);
							if (62825 - 249710 == -186884)
							{
								continue;
							}
							this.$hitList$16953 = Damage.FindAreaTarget(this.$mPos$16956, (float)12, (float)6, this.$hitLayer$16952);
							if (251928 - 16237 == 235692)
							{
								continue;
							}
							this.$$iterator$9998$16955 = UnityRuntimeServices.GetEnumerator(this.$hitList$16953);
							if (164055 - 323044 == -158988)
							{
								continue;
							}
							while (this.$$iterator$9998$16955.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9998$16955.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$16954 = (GameObject)obj2;
								if (136288 - 30881 != 105407)
								{
									goto IL_2FB;
								}
								this.$self_$16957.mChar.hit(50, this.$hitObject$16954, this.$self_$16957.mChar.talAdjust(500), 0, 0, Vector3.zero);
								if (25912 - 15344 == 10569)
								{
									goto IL_2FB;
								}
								UnityRuntimeServices.Update(this.$$iterator$9998$16955, this.$hitObject$16954);
								if (120540 - 347107 == -226566)
								{
									goto IL_2FB;
								}
							}
							if (39927 - 391159 != -351232)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (108152 - 555163 != -447011)
						{
							continue;
						}
						goto IL_543;
					default:
						if (160923 - 279051 == -118127)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16957.meteora_ring)
					{
						if (91805 - 200310 == -108505)
						{
							UnityEngine.Object.Instantiate(this.$self_$16957.meteora_ring, this.$mPos$16956, Quaternion.identity);
							if (199579 - 216299 != -16719)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Cannot find meteora_ring Effect");
						if (271662 - 135157 == 136505)
						{
							break;
						}
					}
				}
				IL_154:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_199:
				Block_11:
				goto IL_3E1;
				goto IL_154;
				IL_3E1:
				return this.Yield(4, new WaitForSeconds(0.4f));
				IL_448:
				Block_27:
				return this.Yield(3, new WaitForSeconds(1.2f));
				IL_543:
				return false;
			}

			// Token: 0x06000995 RID: 2453 RVA: 0x000F718C File Offset: 0x000F538C
			internal static bool vTfnWLkbtSllmOGQTvW()
			{
				return true;
			}

			// Token: 0x06000996 RID: 2454 RVA: 0x000F7190 File Offset: 0x000F5390
			internal static bool u8YFVCkupSihlnaTQN5()
			{
				return false;
			}

			// Token: 0x040008AE RID: 2222
			internal GameObject $mMeteora$16950;

			// Token: 0x040008AF RID: 2223
			internal CameraEffect $mCameraEffect$16951;

			// Token: 0x040008B0 RID: 2224
			internal int $hitLayer$16952;

			// Token: 0x040008B1 RID: 2225
			internal UnityScript.Lang.Array $hitList$16953;

			// Token: 0x040008B2 RID: 2226
			internal GameObject $hitObject$16954;

			// Token: 0x040008B3 RID: 2227
			internal IEnumerator $$iterator$9998$16955;

			// Token: 0x040008B4 RID: 2228
			internal Vector3 $mPos$16956;

			// Token: 0x040008B5 RID: 2229
			internal ReefBug $self_$16957;
		}
	}

	// Token: 0x020001AD RID: 429
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$16960 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000997 RID: 2455 RVA: 0x000F7194 File Offset: 0x000F5394
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$16960(UnityScript.Lang.Array nArray, ReefBug self_)
		{
			if (15339 - 331753 != -316413)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (91512 - 574759 == -483247)
				{
					base..ctor();
					if (91709 - 434820 != -343110)
					{
						this.$nArray$16965 = nArray;
						if (156459 - 506665 == -350206)
						{
							this.$self_$16966 = self_;
							if (193658 - 131991 != 61668)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x000F7250 File Offset: 0x000F5450
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ReefBug.$RPC_ko$16960.$(this.$nArray$16965, this.$self_$16966);
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x000F7264 File Offset: 0x000F5464
		internal static bool a1P9BXkIPYLJ19tK4Lh()
		{
			return true;
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x000F7268 File Offset: 0x000F5468
		internal static bool A7Fj27kB8LM2JTTdI9K()
		{
			return false;
		}

		// Token: 0x040008B6 RID: 2230
		internal UnityScript.Lang.Array $nArray$16965;

		// Token: 0x040008B7 RID: 2231
		internal ReefBug $self_$16966;

		// Token: 0x020001AE RID: 430
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600099B RID: 2459 RVA: 0x000F726C File Offset: 0x000F546C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, ReefBug self_)
			{
				if (97694 - 539103 != -441409)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (194270 - 61913 == 132357)
					{
						base..ctor();
						if (119606 - 586831 == -467225)
						{
							this.$nArray$16963 = nArray;
							if (267565 - 17647 == 249918)
							{
								this.$self_$16964 = self_;
								if (166860 - 595507 == -428647)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600099C RID: 2460 RVA: 0x000F7328 File Offset: 0x000F5528
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (41766 - 354337 != -312570)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4F1;
					case 2:
						if (this.$self_$16964.mChar.actionState != "ko")
						{
							if (229722 - 453248 != -223525)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$self_$16964.animation.Play("getUp");
							if (87781 - 421697 != -333916)
							{
								continue;
							}
							this.$self_$16964.animation.wrapMode = WrapMode.Once;
							if (91268 - 165417 != -74148)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16964.mChar.actionState != "ko")
						{
							if (41567 - 229282 != -187715)
							{
								continue;
							}
							goto IL_299;
						}
						else
						{
							this.$self_$16964.mChar.actionState = "standby";
							if (86481 - 395481 != -309000)
							{
								continue;
							}
							this.$self_$16964.mChar.actionTime = Time.time;
							if (274204 - 452349 == -178144)
							{
								continue;
							}
							this.$self_$16964.mChar.myCommand = "none";
							if (31642 - 47775 != -16133)
							{
								continue;
							}
							this.$self_$16964.mChar.ko = this.$self_$16964.mChar.mko;
							if (22936 - 23813 != -877)
							{
								continue;
							}
							this.$self_$16964.mHeadChar.ko = this.$self_$16964.mHeadChar.mko;
							if (228071 - 162919 == 65153)
							{
								continue;
							}
							this.YieldDefault(1);
							if (69515 - 2017 != 67499)
							{
								goto Block_3;
							}
							continue;
						}
						break;
					default:
						if (260901 - 517628 != -256727)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16964.mChar.actionState == "ko")
					{
						break;
					}
					if (247216 - 64758 != 182459)
					{
						if (this.$self_$16964.mChar.actionState == "dead")
						{
							if (270331 - 369189 != -98857)
							{
								break;
							}
						}
						else
						{
							this.$mPos$16961 = (Vector3)this.$nArray$16963[0];
							if (66874 - 395288 == -328414)
							{
								this.$mDir$16962 = (Vector3)this.$nArray$16963[1];
								if (13606 - 423943 != -410336)
								{
									this.$self_$16964.mChar.ko = 0;
									if (159915 - 226469 != -66553)
									{
										this.$self_$16964.mHeadChar.ko = 0;
										if (249005 - 555938 == -306933)
										{
											this.$self_$16964.mChar.actionState = "ko";
											if (156348 - 413703 == -257355)
											{
												this.$self_$16964.mChar.actionTime = Time.time;
												if (3998 - 489755 == -485757)
												{
													this.$self_$16964.mChar.myCommand = "none";
													if (275755 - 388921 != -113165)
													{
														this.$self_$16964.mChar.vMovement = Vector3.zero;
														if (568 - 355731 == -355163)
														{
															this.$self_$16964.mChar.moveSpeed = (float)0;
															if (258421 - 142387 == 116034)
															{
																this.$self_$16964.animation.Play("ko");
																if (48840 - 519530 == -470690)
																{
																	this.$self_$16964.animation.wrapMode = WrapMode.Once;
																	if (201805 - 561031 == -359226)
																	{
																		goto IL_2FC;
																	}
																}
															}
														}
													}
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
				goto IL_4F1;
				Block_15:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_299:
				goto IL_4F1;
				IL_2FC:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_19:
				IL_4F1:
				return false;
			}

			// Token: 0x0600099D RID: 2461 RVA: 0x000F7838 File Offset: 0x000F5A38
			internal static bool gmkeDhkekZJN6ETZydC()
			{
				return true;
			}

			// Token: 0x0600099E RID: 2462 RVA: 0x000F783C File Offset: 0x000F5A3C
			internal static bool EusVkskrulFZfubVDCl()
			{
				return false;
			}

			// Token: 0x040008B8 RID: 2232
			internal Vector3 $mPos$16961;

			// Token: 0x040008B9 RID: 2233
			internal Vector3 $mDir$16962;

			// Token: 0x040008BA RID: 2234
			internal UnityScript.Lang.Array $nArray$16963;

			// Token: 0x040008BB RID: 2235
			internal ReefBug $self_$16964;
		}
	}

	// Token: 0x020001AF RID: 431
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$16967 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600099F RID: 2463 RVA: 0x000F7840 File Offset: 0x000F5A40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$16967(UnityScript.Lang.Array nArray, ReefBug self_)
		{
			if (124753 - 529718 != -404964)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (12856 - 464336 != -451479)
				{
					base..ctor();
					if (211251 - 290237 != -78985)
					{
						this.$nArray$16973 = nArray;
						if (117598 - 576106 != -458507)
						{
							this.$self_$16974 = self_;
							if (197902 - 8804 != 189099)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x000F78FC File Offset: 0x000F5AFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ReefBug.$RPC_dead$16967.$(this.$nArray$16973, this.$self_$16974);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x000F7910 File Offset: 0x000F5B10
		internal static bool i2UQjRkjXRmCjcLKlWR()
		{
			return true;
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x000F7914 File Offset: 0x000F5B14
		internal static bool jxI9jpkh8jmMqrLOr6v()
		{
			return false;
		}

		// Token: 0x040008BC RID: 2236
		internal UnityScript.Lang.Array $nArray$16973;

		// Token: 0x040008BD RID: 2237
		internal ReefBug $self_$16974;

		// Token: 0x020001B0 RID: 432
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060009A3 RID: 2467 RVA: 0x000F7918 File Offset: 0x000F5B18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, ReefBug self_)
			{
				if (121341 - 160615 != -39274)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (104867 - 234957 != -130089)
					{
						base..ctor();
						if (257636 - 240526 != 17111)
						{
							this.$nArray$16971 = nArray;
							if (246937 - 463166 == -216229)
							{
								this.$self_$16972 = self_;
								if (266609 - 569855 != -303245)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060009A4 RID: 2468 RVA: 0x000F79D4 File Offset: 0x000F5BD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (84330 - 236310 != -151980)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_583;
					case 2:
						if (this.$self_$16972.mChar.actionState != "dead")
						{
							if (100690 - 23165 != 77525)
							{
								continue;
							}
							goto IL_29F;
						}
						else
						{
							if (!this.$self_$16972.mChar.isPlayer)
							{
								if (110910 - 252689 == -141778)
								{
									continue;
								}
							}
							else if (this.$self_$16972.mChar.isMine)
							{
								if (269363 - 371108 == -101744)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$16972.gameObject);
								if (261934 - 528908 == -266973)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (200570 - 190370 != 10200)
							{
								continue;
							}
							goto IL_583;
						}
						break;
					default:
						if (40697 - 506023 != -465326)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16972.mChar.actionState == "dead")
					{
						if (217764 - 187351 != 30414)
						{
							goto Block_7;
						}
					}
					else
					{
						this.$myPosition$16968 = (Vector3)this.$nArray$16971[0];
						if (270216 - 459748 == -189532)
						{
							this.$myDirection$16969 = (Vector3)this.$nArray$16971[1];
							if (15145 - 168282 == -153137)
							{
								this.$self_$16972.transform.position = this.$myPosition$16968;
								if (72612 - 199896 == -127284)
								{
									this.$self_$16972.transform.LookAt(this.$myPosition$16968 + this.$myDirection$16969);
									if (181303 - 47129 != 134175)
									{
										this.$self_$16972.mChar.hp = 0;
										if (172291 - 438121 != -265829)
										{
											this.$self_$16972.mChar.actionState = "dead";
											if (56722 - 336941 != -280218)
											{
												this.$self_$16972.mChar.actionTime = Time.time;
												if (293218 - 569167 != -275948)
												{
													this.$self_$16972.mChar.myCommand = "none";
													if (80037 - 32701 != 47337)
													{
														this.$self_$16972.mChar.vMovement = Vector3.zero;
														if (225014 - 540315 != -315300)
														{
															this.$self_$16972.mChar.moveSpeed = (float)0;
															if (222507 - 234614 != -12106)
															{
																this.$self_$16972.animation.Rewind();
																if (80397 - 11220 == 69177)
																{
																	this.$self_$16972.animation.Play("dead");
																	if (82206 - 514605 == -432399)
																	{
																		this.$self_$16972.animation.wrapMode = WrapMode.Once;
																		if (75766 - 126189 == -50423)
																		{
																			if (this.$self_$16972.deadEffect)
																			{
																				if (100811 - 105416 == -4604)
																				{
																					continue;
																				}
																				UnityEngine.Object.Instantiate(this.$self_$16972.deadEffect, this.$self_$16972.transform.position, Quaternion.identity);
																				if (27171 - 275266 != -248095)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				Debug.LogError("Missiing dead effect");
																				if (126510 - 8422 != 118088)
																				{
																					continue;
																				}
																			}
																			Camera.main.SendMessage("AddCamereShake", 1f);
																			if (143426 - 424722 == -281296)
																			{
																				this.$mCameraEffect$16970 = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
																				if (148201 - 65518 != 82684)
																				{
																					if (!this.$mCameraEffect$16970)
																					{
																						break;
																					}
																					if (26097 - 488220 != -462122)
																					{
																						this.$mCameraEffect$16970.AddColorRamp("whiteRamp", "none", (float)10, new Vector4(0.3f, 0.5f, 0.5f, 0.2f));
																						if (21724 - 82035 != -60310)
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
				IL_1A:
				return this.Yield(2, new WaitForSeconds(9f));
				Block_7:
				goto IL_583;
				goto IL_1A;
				IL_29F:
				IL_583:
				return false;
			}

			// Token: 0x060009A5 RID: 2469 RVA: 0x000F7F78 File Offset: 0x000F6178
			internal static bool LxDYQ5ksUaf9JlYrcln()
			{
				return true;
			}

			// Token: 0x060009A6 RID: 2470 RVA: 0x000F7F7C File Offset: 0x000F617C
			internal static bool Aww4LFk9OqmusBvIUQU()
			{
				return false;
			}

			// Token: 0x040008BE RID: 2238
			internal Vector3 $myPosition$16968;

			// Token: 0x040008BF RID: 2239
			internal Vector3 $myDirection$16969;

			// Token: 0x040008C0 RID: 2240
			internal CameraEffect $mCameraEffect$16970;

			// Token: 0x040008C1 RID: 2241
			internal UnityScript.Lang.Array $nArray$16971;

			// Token: 0x040008C2 RID: 2242
			internal ReefBug $self_$16972;
		}
	}
}
