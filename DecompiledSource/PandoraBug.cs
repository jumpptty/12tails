using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200014D RID: 333
[Serializable]
public class PandoraBug : MonoBehaviour
{
	// Token: 0x0600076C RID: 1900 RVA: 0x000C33F4 File Offset: 0x000C15F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PandoraBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600076D RID: 1901 RVA: 0x000C3404 File Offset: 0x000C1604
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (36336 - 45271 != -8934)
		{
		}
		for (;;)
		{
			this.CuDnkfjYKw = this.transform;
			if (67429 - 96388 == -28959)
			{
				this.XU3nFvWP1y = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (234106 - 406093 == -171987)
				{
					this.XU3nFvWP1y.actionState = "standby";
					if (238554 - 92966 == 145588)
					{
						this.XU3nFvWP1y.actionTime = Time.time;
						if (197325 - 552909 == -355584)
						{
							this.XU3nFvWP1y.myCommand = "none";
							if (54415 - 351039 == -296624)
							{
								if (Game.mGameType != 99)
								{
									break;
								}
								if (218143 - 562129 != -343985)
								{
									this.XU3nFvWP1y.isMine = true;
									if (72579 - 428302 != -355722)
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

	// Token: 0x0600076E RID: 1902 RVA: 0x000C3564 File Offset: 0x000C1764
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (227044 - 245290 != -18246)
		{
		}
		for (;;)
		{
			if (this.XU3nFvWP1y.isControlled)
			{
				if (255926 - 561282 != -305356)
				{
					continue;
				}
				if (!(this.XU3nFvWP1y.actionState == "standby"))
				{
					if (130034 - 400202 != -270168)
					{
						continue;
					}
					if (!(this.XU3nFvWP1y.actionState == "run"))
					{
						goto IL_44;
					}
					if (202548 - 264913 != -62365)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (177027 - 304450 != -127423)
				{
					continue;
				}
			}
			IL_44:
			if (this.XU3nFvWP1y.hp <= 0)
			{
				if (219363 - 403317 != -183954)
				{
					continue;
				}
				if (this.XU3nFvWP1y.actionState != "dead")
				{
					if (240229 - 566655 == -326425)
					{
						continue;
					}
					if (this.XU3nFvWP1y.isMine)
					{
						if (169380 - 400349 != -230969)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (195798 - 287166 == -91367)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (225076 - 451524 == -226447)
						{
							continue;
						}
						this.XU3nFvWP1y.DeadEvent();
						if (176850 - 494849 != -317999)
						{
							continue;
						}
						break;
					}
					else
					{
						this.XU3nFvWP1y.hp = 1;
						if (7183 - 518965 != -511781)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.XU3nFvWP1y.hp <= 0)
			{
				break;
			}
			if (213566 - 440478 != -226911)
			{
				if (this.XU3nFvWP1y.ko > 0)
				{
					break;
				}
				if (81035 - 3198 != 77838)
				{
					if (!(this.XU3nFvWP1y.actionState != "ko"))
					{
						break;
					}
					if (35540 - 258865 != -223324)
					{
						if (!(this.XU3nFvWP1y.actionState != "dead"))
						{
							break;
						}
						if (6294 - 437383 == -431089)
						{
							if (this.XU3nFvWP1y.isMine)
							{
								if (221479 - 186882 != 34598)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (57149 - 288479 != -231329)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (52067 - 149012 == -96945)
										{
											this.XU3nFvWP1y.KoEvent();
											if (192234 - 588516 == -396282)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.XU3nFvWP1y.ko = 1;
								if (125992 - 374549 != -248556)
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

	// Token: 0x0600076F RID: 1903 RVA: 0x000C395C File Offset: 0x000C1B5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (120295 - 581846 != -461550)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (282132 - 410292 != -128159)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (223429 - 172850 != 50580)
				{
					if (289253 - 35881 == 253372)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (132769 - 86629 != 46140)
							{
								continue;
							}
							v = 1;
							if (4616 - 105765 == -101148)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (33839 - 368376 != -334537)
							{
								continue;
							}
							v = -1;
							if (245804 - 484010 != -238206)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_junkDrop")
						{
							if (63632 - 528384 == -464751)
							{
								continue;
							}
							v = 11;
							if (137576 - 92203 == 45374)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_junkDrop_hit")
						{
							if (13428 - 191881 == -178452)
							{
								continue;
							}
							v = -11;
							if (192086 - 9629 != 182457)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (250636 - 131988 != 118648)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (242166 - 57105 == 185061)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (51169 - 476188 == -425019)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (15883 - 279817 != -263933)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (87224 - 99416 == -12192)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (254818 - 529375 != -274556)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (60870 - 289472 == -228602)
											{
												Hashtable hashtable = new Hashtable();
												if (111772 - 540141 != -428368)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (188850 - 581193 == -392343)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (142120 - 560537 == -418417)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (79017 - 37165 == 41852)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (201000 - 311069 == -110069)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (248498 - 204606 != 43893)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (135001 - 485749 != -350747)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (73600 - 505759 == -432159)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (78883 - 34080 != 44804)
																				{
																					PhotonClient.SendEvent(this.XU3nFvWP1y.ActorNr, 74, hashtable, true, true);
																					if (125182 - 400986 == -275804)
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

	// Token: 0x06000770 RID: 1904 RVA: 0x000C3E74 File Offset: 0x000C2074
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (119248 - 319510 != -200261)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (3399 - 273853 != -270453)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (13159 - 143423 != -130263)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (146570 - 375790 == -229220)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (171811 - 281485 != -109673)
						{
							int num3 = num;
							if (93206 - 136977 != -43770)
							{
								if (num3 == 1)
								{
									if (102316 - 196529 == -94213)
									{
										if (this.XU3nFvWP1y.isMine)
										{
											break;
										}
										if (295120 - 502212 == -207092)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (133974 - 90049 != 43926)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (202102 - 164808 == 37294)
									{
										if (this.XU3nFvWP1y.isMine)
										{
											break;
										}
										if (190138 - 376719 != -186580)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (259962 - 294582 != -34619)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (38752 - 191589 != -152836)
									{
										if (this.XU3nFvWP1y.isMine)
										{
											break;
										}
										if (80321 - 546063 == -465742)
										{
											this.StartCoroutine_Auto(this.RPC_junkDrop(vector, vector2, num2));
											if (294720 - 555499 != -260778)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (121236 - 246668 == -125432)
									{
										if (this.XU3nFvWP1y.isMine)
										{
											break;
										}
										if (96408 - 354154 == -257746)
										{
											this.StartCoroutine_Auto(this.RPC_junkDrop_hit(vector, vector2, num2));
											if (114598 - 48307 != 66292)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (48985 - 64960 != -15974)
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

	// Token: 0x06000771 RID: 1905 RVA: 0x000C4200 File Offset: 0x000C2400
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (44563 - 205823 != -161259)
		{
		}
		for (;;)
		{
			float num = this.XU3nFvWP1y.moveSpeed;
			if (91308 - 194240 != -102931)
			{
				float runSpeed = this.XU3nFvWP1y.runSpeed;
				if (198003 - 415538 == -217535)
				{
					Vector3 a = default(Vector3);
					if (780 - 64973 == -64193)
					{
						Vector3 vector = Vector3.zero;
						if (136468 - 93121 == 43347)
						{
							float num2 = (float)0;
							if (51069 - 453362 == -402293)
							{
								if (this.XU3nFvWP1y.isMine)
								{
									if (44060 - 404385 == -360324)
									{
										continue;
									}
									if ((this.XU3nFvWP1y.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (187026 - 267727 == -80700)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (89211 - 53734 != 35477)
										{
											continue;
										}
										a.y = (float)0;
										if (82739 - 36874 != 45865)
										{
											continue;
										}
										a = a.normalized;
										if (271027 - 279151 == -8123)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (1311 - 488626 != -487315)
										{
											continue;
										}
										vector = vector.normalized;
										if (226347 - 122980 == 103368)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (119218 - 352641 == -233422)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (74974 - 311401 == -236426)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (180033 - 272997 != -92964)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (198931 - 129250 == 69682)
														{
															continue;
														}
														this.XU3nFvWP1y.actionState = "run";
														if (85490 - 548189 != -462699)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (145531 - 398702 != -253171)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (252025 - 498992 == -246966)
														{
															continue;
														}
														this.animation.Play("run");
														if (271139 - 184713 != 86426)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (155767 - 360884 != -205117)
														{
															continue;
														}
														goto IL_12E;
													}
												}
											}
										}
										this.XU3nFvWP1y.actionState = "standby";
										if (162485 - 188595 != -26110)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (202958 - 63322 == 139637)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (75488 - 237771 != -162283)
											{
												continue;
											}
											num = (float)0;
											if (195653 - 418478 == -222824)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (222164 - 418556 == -196391)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (84075 - 221437 == -137361)
										{
											continue;
										}
									}
									IL_12E:;
								}
								else
								{
									vector = global::Math.vFlat(this.XU3nFvWP1y.nPosition - this.transform.position);
									if (214363 - 13570 == 200794)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (295275 - 111318 != 183957)
									{
										continue;
									}
									if (this.XU3nFvWP1y.nSpeed != (float)0)
									{
										if (58911 - 279731 == -220819)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (150588 - 357843 != -207255)
											{
												continue;
											}
											this.transform.position = this.XU3nFvWP1y.nPosition;
											if (26500 - 349572 == -323071)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (66627 - 467769 == -401141)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (250090 - 122862 == 127229)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (186353 - 5549 == 180805)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.XU3nFvWP1y.nSpeed, (float)10 * Time.deltaTime);
												if (281828 - 155442 == 126387)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (215489 - 424084 != -208595)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (196229 - 8233 == 187997)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (11616 - 135295 == -123678)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (82304 - 3767 == 78538)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (202060 - 130034 != 72026)
											{
												continue;
											}
										}
										else if (Time.time > this.XU3nFvWP1y.nSpeed + 0.3f)
										{
											if (18712 - 460213 != -441501)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (55836 - 371532 == -315695)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (82961 - 163872 != -80911)
												{
													continue;
												}
												num = (float)0;
												if (173948 - 322632 != -148684)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.XU3nFvWP1y.nDirection);
											if (184929 - 273827 != -88898)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (231844 - 98950 != 132894)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (283176 - 328215 != -45039)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (206265 - 241296 == -35030)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (81326 - 562408 != -481082)
											{
												continue;
											}
											this.transform.position = this.XU3nFvWP1y.nPosition;
											if (193954 - 491597 == -297642)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (240717 - 283254 != -42537)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (135362 - 571483 == -436120)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (7001 - 235736 == -228734)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (86444 - 302327 == -215882)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (28265 - 263988 == -235722)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (23712 - 584812 == -561099)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (172280 - 239674 != -67394)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.XU3nFvWP1y.nDirection);
											if (33098 - 354849 != -321751)
											{
												continue;
											}
											num = (float)0;
											if (92644 - 379670 != -287026)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (78713 - 282556 == -203842)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (34333 - 9395 == 24939)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (69169 - 159564 == -90394)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (219093 - 419052 == -199958)
										{
											continue;
										}
									}
								}
								this.XU3nFvWP1y.vMovement = vector;
								if (248597 - 457351 != -208753)
								{
									this.XU3nFvWP1y.moveSpeed = num;
									if (216843 - 273756 != -56912)
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

	// Token: 0x06000772 RID: 1906 RVA: 0x000C4D64 File Offset: 0x000C2F64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (73964 - 183515 != -109551)
		{
		}
		for (;;)
		{
			if (!this.XU3nFvWP1y.isMine)
			{
				if (153802 - 191109 != -37306)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (139218 - 1486 != 137733)
				{
					Vector3 vector = a - this.transform.position;
					if (17447 - 74991 != -57543)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (15191 - 59526 != -44334)
						{
							CharacterControl characterControl = null;
							if (42534 - 366670 == -324136)
							{
								if (283777 - 321547 == -37770)
								{
									if (gameObject)
									{
										if (128301 - 521225 != -392924)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (278857 - 221092 != 57765)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (237380 - 332799 != -95419)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (163326 - 462051 == -298724)
										{
											continue;
										}
									}
									if (!(this.XU3nFvWP1y.actionState == "standby"))
									{
										if (136817 - 15301 != 121516)
										{
											continue;
										}
										if (!(this.XU3nFvWP1y.actionState == "run"))
										{
											break;
										}
										if (175146 - 529196 != -354050)
										{
											continue;
										}
									}
									if (this.XU3nFvWP1y.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (123441 - 203498 == -80057)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
										if (85354 - 339795 == -254441)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (251351 - 113640 != 137712)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
												if (163853 - 434828 != -270974)
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

	// Token: 0x06000773 RID: 1907 RVA: 0x000C505C File Offset: 0x000C325C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (75550 - 520748 != -445198)
		{
		}
		for (;;)
		{
			if (!this.XU3nFvWP1y.isMine)
			{
				if (212766 - 123493 != 89274)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (30541 - 494669 == -464128)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (91468 - 100313 != -8844)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (174283 - 430910 == -256627)
						{
							CharacterControl characterControl = null;
							if (166563 - 518411 == -351848)
							{
								int tID = 0;
								if (269699 - 289871 == -20172)
								{
									if (gameObject)
									{
										if (260926 - 66090 == 194837)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (51029 - 422750 == -371720)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (20352 - 241236 == -220883)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (87597 - 399357 == -311759)
										{
											continue;
										}
									}
									if (!(this.XU3nFvWP1y.actionState == "standby"))
									{
										if (212224 - 2284 != 209940)
										{
											continue;
										}
										if (!(this.XU3nFvWP1y.actionState == "run"))
										{
											break;
										}
										if (284657 - 335505 != -50848)
										{
											continue;
										}
									}
									if (this.XU3nFvWP1y.isTimeOut("junkDrop") != (float)0)
									{
										break;
									}
									if (202798 - 68077 != 134722)
									{
										this.StartCoroutine_Auto(this.RPC_junkDrop(this.transform.position, vector, tID));
										if (272577 - 101230 == 171347)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (182805 - 433415 != -250609)
											{
												this.ActionEvent("RPC_junkDrop", this.transform.position, vector, tID);
												if (215466 - 524928 != -309461)
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

	// Token: 0x06000774 RID: 1908 RVA: 0x000C535C File Offset: 0x000C355C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000775 RID: 1909 RVA: 0x000C5360 File Offset: 0x000C3560
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PandoraBug.$RPC_nAttack$16549(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000776 RID: 1910 RVA: 0x000C5370 File Offset: 0x000C3570
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (127297 - 362452 != -235155)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (289041 - 360139 != -71097)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (297717 - 135510 != 162208)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (260625 - 177929 == 82696)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000777 RID: 1911 RVA: 0x000C5428 File Offset: 0x000C3628
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_junkDrop(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PandoraBug.$RPC_junkDrop$16561(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06000778 RID: 1912 RVA: 0x000C5438 File Offset: 0x000C3638
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_junkDrop_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		return new PandoraBug.$RPC_junkDrop_hit$16572(hitPos, this).GetEnumerator();
	}

	// Token: 0x06000779 RID: 1913 RVA: 0x000C5448 File Offset: 0x000C3648
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new PandoraBug.$RPC_ko$16581(nArray, this).GetEnumerator();
	}

	// Token: 0x0600077A RID: 1914 RVA: 0x000C5458 File Offset: 0x000C3658
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new PandoraBug.$RPC_dead$16588(nArray, this).GetEnumerator();
	}

	// Token: 0x0600077B RID: 1915 RVA: 0x000C5468 File Offset: 0x000C3668
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x000C546C File Offset: 0x000C366C
	internal static bool adFk6w3q7m1I5II5XBW()
	{
		return true;
	}

	// Token: 0x0600077D RID: 1917 RVA: 0x000C5470 File Offset: 0x000C3670
	internal static bool UJcwex37Ool5L0GU9AU()
	{
		return false;
	}

	// Token: 0x040006D9 RID: 1753
	private Transform CuDnkfjYKw;

	// Token: 0x040006DA RID: 1754
	private CharacterControl XU3nFvWP1y;

	// Token: 0x040006DB RID: 1755
	public GameObject nAttack_ring;

	// Token: 0x040006DC RID: 1756
	public GameObject nAttack_hit;

	// Token: 0x040006DD RID: 1757
	public GameObject junkDrop_ring;

	// Token: 0x040006DE RID: 1758
	public GameObject junkDrop_hit;

	// Token: 0x0200014E RID: 334
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$16549 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600077E RID: 1918 RVA: 0x000C5474 File Offset: 0x000C3674
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$16549(Vector3 mPos, Vector3 tDir, PandoraBug self_)
		{
			if (193119 - 418552 != -225433)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (1195 - 585867 == -584672)
				{
					base..ctor();
					if (122767 - 152599 == -29832)
					{
						this.$mPos$16558 = mPos;
						if (2523 - 268527 != -266003)
						{
							this.$tDir$16559 = tDir;
							if (260143 - 535257 == -275114)
							{
								this.$self_$16560 = self_;
								if (229658 - 580304 != -350645)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x000C5550 File Offset: 0x000C3750
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PandoraBug.$RPC_nAttack$16549.$(this.$mPos$16558, this.$tDir$16559, this.$self_$16560);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x000C556C File Offset: 0x000C376C
		internal static bool BX0wEP3PeRtespobmqr()
		{
			return true;
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x000C5570 File Offset: 0x000C3770
		internal static bool FPxZ0330wnB8i7aBkQQ()
		{
			return false;
		}

		// Token: 0x040006DF RID: 1759
		internal Vector3 $mPos$16558;

		// Token: 0x040006E0 RID: 1760
		internal Vector3 $tDir$16559;

		// Token: 0x040006E1 RID: 1761
		internal PandoraBug $self_$16560;

		// Token: 0x0200014F RID: 335
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000782 RID: 1922 RVA: 0x000C5574 File Offset: 0x000C3774
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PandoraBug self_)
			{
				if (188615 - 119032 != 69584)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (181949 - 392069 != -210119)
					{
						base..ctor();
						if (92159 - 486520 == -394361)
						{
							this.$mPos$16555 = mPos;
							if (227405 - 410391 != -182985)
							{
								this.$tDir$16556 = tDir;
								if (232877 - 247370 == -14493)
								{
									this.$self_$16557 = self_;
									if (191080 - 383586 != -192505)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000783 RID: 1923 RVA: 0x000C5650 File Offset: 0x000C3850
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (250102 - 383547 != -133444)
				{
				}
				for (;;)
				{
					IL_85A:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_92B;
					case 2:
						if (this.$self_$16557.XU3nFvWP1y.actionState != "attack")
						{
							goto IL_6F6;
						}
						if (162789 - 74638 == 88152)
						{
							continue;
						}
						if (this.$self_$16557.XU3nFvWP1y.myCommand != "nAttack")
						{
							if (272045 - 117335 != 154710)
							{
								continue;
							}
							goto IL_6F6;
						}
						else
						{
							if (!this.$self_$16557.XU3nFvWP1y.isMine)
							{
								goto IL_72A;
							}
							if (115485 - 381172 != -265687)
							{
								continue;
							}
							this.$hitLayer$16550 = 130816 - (1 << this.$self_$16557.gameObject.layer);
							if (240926 - 483698 == -242771)
							{
								continue;
							}
							this.$hitList$16551 = Damage.FindRecTarget(this.$self_$16557.transform.position - this.$self_$16557.transform.right, this.$self_$16557.transform.forward, (float)1, (float)1, (float)2, (float)2, this.$hitLayer$16550);
							if (194866 - 492498 == -297631)
							{
								continue;
							}
							this.$$iterator$9976$16554 = UnityRuntimeServices.GetEnumerator(this.$hitList$16551);
							if (173828 - 286821 == -112992)
							{
								continue;
							}
							while (this.$$iterator$9976$16554.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9976$16554.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$16552 = (GameObject)obj2;
								if (3596 - 139406 != -135810)
								{
									goto IL_85A;
								}
								if (this.$self_$16557.XU3nFvWP1y.hit(1, this.$hitObject$16552, this.$self_$16557.XU3nFvWP1y.atk, 5, 0, this.$self_$16557.transform.forward) != 0)
								{
									if (241164 - 156169 == 84996)
									{
										goto IL_85A;
									}
									this.$hitPos$16553 = this.$hitObject$16552.collider.ClosestPointOnBounds(this.$self_$16557.transform.position + Vector3.up);
									if (131318 - 534531 != -403213)
									{
										goto IL_85A;
									}
									UnityRuntimeServices.Update(this.$$iterator$9976$16554, this.$hitObject$16552);
									if (289784 - 566718 != -276934)
									{
										goto IL_85A;
									}
									this.$self_$16557.RPC_nAttack_hit(this.$hitPos$16553, this.$self_$16557.transform.forward, 0);
									if (22757 - 389810 != -367053)
									{
										goto IL_85A;
									}
									if (PhotonClient.IsInitialized())
									{
										if (31431 - 195543 == -164111)
										{
											goto IL_85A;
										}
										this.$self_$16557.ActionEvent("RPC_nAttack_hit", this.$hitPos$16553, this.$self_$16557.transform.forward, 0);
										if (57689 - 431441 == -373751)
										{
											goto IL_85A;
										}
									}
								}
							}
							if (238245 - 93911 != 144334)
							{
								continue;
							}
							goto IL_72A;
						}
						break;
					case 3:
						if (this.$self_$16557.XU3nFvWP1y.actionState != "attack")
						{
							goto IL_264;
						}
						if (236125 - 244778 == -8652)
						{
							continue;
						}
						if (this.$self_$16557.XU3nFvWP1y.myCommand != "nAttack")
						{
							if (205914 - 350083 != -144169)
							{
								continue;
							}
							goto IL_264;
						}
						else
						{
							this.$self_$16557.XU3nFvWP1y.moveSpeed = (float)0;
							if (120122 - 293114 != -172991)
							{
								goto Block_13;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$16557.XU3nFvWP1y.actionState == "attack")
						{
							if (254587 - 426914 == -172326)
							{
								continue;
							}
							if (this.$self_$16557.XU3nFvWP1y.myCommand == "nAttack")
							{
								if (178942 - 440665 != -261723)
								{
									continue;
								}
								this.$self_$16557.XU3nFvWP1y.actionState = "standby";
								if (101572 - 219857 == -118284)
								{
									continue;
								}
								this.$self_$16557.XU3nFvWP1y.actionTime = Time.time;
								if (66195 - 23140 != 43055)
								{
									continue;
								}
								this.$self_$16557.XU3nFvWP1y.myCommand = "none";
								if (255456 - 12415 == 243042)
								{
									continue;
								}
								if (!this.$self_$16557.XU3nFvWP1y.isMine)
								{
									if (243069 - 594146 != -351077)
									{
										continue;
									}
									this.$self_$16557.XU3nFvWP1y.nPosition = this.$self_$16557.transform.position;
									if (13989 - 371290 != -357301)
									{
										continue;
									}
									this.$self_$16557.XU3nFvWP1y.oPosition = this.$self_$16557.transform.position;
									if (260104 - 203205 == 56900)
									{
										continue;
									}
									this.$self_$16557.XU3nFvWP1y.nDirection = this.$self_$16557.transform.forward;
									if (29789 - 233559 != -203770)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (250012 - 340766 != -90754)
						{
							continue;
						}
						goto IL_92B;
					default:
						if (207129 - 134372 == 72758)
						{
							continue;
						}
						break;
					}
					this.$self_$16557.XU3nFvWP1y.actionState = "attack";
					if (263732 - 188801 == 74931)
					{
						this.$self_$16557.XU3nFvWP1y.actionTime = Time.time;
						if (30371 - 341262 == -310891)
						{
							this.$self_$16557.XU3nFvWP1y.myCommand = "nAttack";
							if (229774 - 326984 == -97210)
							{
								this.$self_$16557.XU3nFvWP1y.addTimeOut("nAttack", (float)3);
								if (51122 - 277252 == -226130)
								{
									this.$self_$16557.transform.position = this.$mPos$16555;
									if (48153 - 590695 == -542542)
									{
										this.$self_$16557.transform.LookAt(this.$mPos$16555 + global::Math.vFlat(this.$tDir$16556));
										if (81989 - 501787 == -419798)
										{
											this.$self_$16557.animation.Play("nAttack");
											if (169084 - 233985 != -64900)
											{
												this.$self_$16557.animation.wrapMode = WrapMode.Once;
												if (20546 - 472059 != -451512)
												{
													this.$self_$16557.XU3nFvWP1y.vMovement = this.$self_$16557.transform.forward;
													if (147077 - 108709 != 38369)
													{
														this.$self_$16557.XU3nFvWP1y.moveSpeed = (float)4;
														if (6730 - 272912 == -266182)
														{
															if (this.$self_$16557.nAttack_ring)
															{
																if (64584 - 453406 != -388821)
																{
																	this.$self_$16557.XU3nFvWP1y.createEffect(this.$self_$16557.nAttack_ring, this.$self_$16557.transform.position, this.$self_$16557.transform.rotation);
																	if (171590 - 158841 != 12750)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing nAttack_ring effect");
																if (222681 - 170675 != 52007)
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
				goto IL_4F5;
				IL_264:
				goto IL_92B;
				Block_13:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_4F5:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_6F6:
				goto IL_92B;
				IL_72A:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_92B:
				return false;
			}

			// Token: 0x06000784 RID: 1924 RVA: 0x000C5F9C File Offset: 0x000C419C
			internal static bool mWdJUe3b8usjBnlGixV()
			{
				return true;
			}

			// Token: 0x06000785 RID: 1925 RVA: 0x000C5FA0 File Offset: 0x000C41A0
			internal static bool Rpoo8a3uNeC9t3GcEup()
			{
				return false;
			}

			// Token: 0x040006E2 RID: 1762
			internal int $hitLayer$16550;

			// Token: 0x040006E3 RID: 1763
			internal UnityScript.Lang.Array $hitList$16551;

			// Token: 0x040006E4 RID: 1764
			internal GameObject $hitObject$16552;

			// Token: 0x040006E5 RID: 1765
			internal Vector3 $hitPos$16553;

			// Token: 0x040006E6 RID: 1766
			internal IEnumerator $$iterator$9976$16554;

			// Token: 0x040006E7 RID: 1767
			internal Vector3 $mPos$16555;

			// Token: 0x040006E8 RID: 1768
			internal Vector3 $tDir$16556;

			// Token: 0x040006E9 RID: 1769
			internal PandoraBug $self_$16557;
		}
	}

	// Token: 0x02000150 RID: 336
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_junkDrop$16561 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000786 RID: 1926 RVA: 0x000C5FA4 File Offset: 0x000C41A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_junkDrop$16561(Vector3 mPos, Vector3 tDir, int tID, PandoraBug self_)
		{
			if (8539 - 72098 != -63559)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (206487 - 594225 == -387738)
				{
					base..ctor();
					if (20820 - 146619 == -125799)
					{
						this.$mPos$16568 = mPos;
						if (92015 - 292884 == -200869)
						{
							this.$tDir$16569 = tDir;
							if (128191 - 12458 != 115734)
							{
								this.$tID$16570 = tID;
								if (33274 - 260954 == -227680)
								{
									this.$self_$16571 = self_;
									if (216756 - 307760 == -91004)
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

		// Token: 0x06000787 RID: 1927 RVA: 0x000C60A4 File Offset: 0x000C42A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PandoraBug.$RPC_junkDrop$16561.$(this.$mPos$16568, this.$tDir$16569, this.$tID$16570, this.$self_$16571);
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x000C60C4 File Offset: 0x000C42C4
		internal static bool ERdKjv3IgbOVrUZU3U7()
		{
			return true;
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x000C60C8 File Offset: 0x000C42C8
		internal static bool mqmo533ByZh1USQDpsw()
		{
			return false;
		}

		// Token: 0x040006EA RID: 1770
		internal Vector3 $mPos$16568;

		// Token: 0x040006EB RID: 1771
		internal Vector3 $tDir$16569;

		// Token: 0x040006EC RID: 1772
		internal int $tID$16570;

		// Token: 0x040006ED RID: 1773
		internal PandoraBug $self_$16571;

		// Token: 0x02000151 RID: 337
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600078A RID: 1930 RVA: 0x000C60CC File Offset: 0x000C42CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, PandoraBug self_)
			{
				if (29889 - 114693 != -84804)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (176692 - 310045 == -133353)
					{
						base..ctor();
						if (242088 - 225958 == 16130)
						{
							this.$mPos$16564 = mPos;
							if (219004 - 518483 == -299479)
							{
								this.$tDir$16565 = tDir;
								if (265399 - 177519 == 87880)
								{
									this.$tID$16566 = tID;
									if (130250 - 167174 != -36923)
									{
										this.$self_$16567 = self_;
										if (188997 - 531769 == -342772)
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

			// Token: 0x0600078B RID: 1931 RVA: 0x000C61CC File Offset: 0x000C43CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (106556 - 137564 != -31008)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_79D;
					case 2:
						if (this.$self_$16567.XU3nFvWP1y.actionState != "attack")
						{
							goto IL_D5;
						}
						if (277672 - 590759 == -313086)
						{
							continue;
						}
						if (this.$self_$16567.XU3nFvWP1y.myCommand != "junkDrop")
						{
							if (182167 - 533790 != -351622)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							if (!this.$self_$16567.XU3nFvWP1y.isMine)
							{
								goto IL_234;
							}
							if (11635 - 25856 == -14220)
							{
								continue;
							}
							this.$hitPos$16562 = default(Vector3);
							if (72284 - 212970 != -140686)
							{
								continue;
							}
							if (this.$tID$16566 == 0)
							{
								if (267776 - 410426 == -142649)
								{
									continue;
								}
								this.$hitPos$16562 = global::Math.getSpawnPos(this.$mPos$16564 + this.$tDir$16565);
								if (6560 - 536888 == -530327)
								{
									continue;
								}
							}
							else
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$16566];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$16563 = (GameObject)obj2;
								if (276784 - 77941 != 198843)
								{
									continue;
								}
								if (this.$hitObject$16563)
								{
									if (180607 - 575546 == -394938)
									{
										continue;
									}
									this.$hitPos$16562 = this.$hitObject$16563.transform.position;
									if (59397 - 208608 != -149211)
									{
										continue;
									}
								}
							}
							this.$self_$16567.StartCoroutine_Auto(this.$self_$16567.RPC_junkDrop_hit(this.$hitPos$16562, this.$self_$16567.transform.forward, 0));
							if (168092 - 454492 == -286399)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_234;
							}
							if (114013 - 255373 != -141360)
							{
								continue;
							}
							this.$self_$16567.ActionEvent("RPC_junkDrop_hit", this.$hitPos$16562, this.$self_$16567.transform.forward, 0);
							if (142482 - 181229 != -38747)
							{
								continue;
							}
							goto IL_234;
						}
						break;
					case 3:
						if (this.$self_$16567.XU3nFvWP1y.actionState == "attack")
						{
							if (258944 - 18994 != 239950)
							{
								continue;
							}
							if (this.$self_$16567.XU3nFvWP1y.myCommand == "junkDrop")
							{
								if (97472 - 127636 != -30164)
								{
									continue;
								}
								this.$self_$16567.XU3nFvWP1y.actionState = "standby";
								if (48060 - 39913 != 8147)
								{
									continue;
								}
								this.$self_$16567.XU3nFvWP1y.actionTime = Time.time;
								if (75905 - 299080 != -223175)
								{
									continue;
								}
								this.$self_$16567.XU3nFvWP1y.myCommand = "none";
								if (195844 - 470328 == -274483)
								{
									continue;
								}
								if (!this.$self_$16567.XU3nFvWP1y.isMine)
								{
									if (144987 - 101551 == 43437)
									{
										continue;
									}
									this.$self_$16567.XU3nFvWP1y.nPosition = this.$self_$16567.transform.position;
									if (187057 - 81465 != 105592)
									{
										continue;
									}
									this.$self_$16567.XU3nFvWP1y.oPosition = this.$self_$16567.transform.position;
									if (10063 - 255846 != -245783)
									{
										continue;
									}
									this.$self_$16567.XU3nFvWP1y.nDirection = this.$self_$16567.transform.forward;
									if (9386 - 421486 == -412099)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (144001 - 240631 != -96630)
						{
							continue;
						}
						goto IL_79D;
					default:
						if (231632 - 569246 == -337613)
						{
							continue;
						}
						break;
					}
					this.$self_$16567.XU3nFvWP1y.actionState = "attack";
					if (88881 - 470121 != -381239)
					{
						this.$self_$16567.XU3nFvWP1y.actionTime = Time.time;
						if (203798 - 87486 != 116313)
						{
							this.$self_$16567.XU3nFvWP1y.myCommand = "junkDrop";
							if (127568 - 313353 != -185784)
							{
								this.$self_$16567.XU3nFvWP1y.addTimeOut("junkDrop", (float)6);
								if (184236 - 105655 != 78582)
								{
									this.$self_$16567.transform.position = this.$mPos$16564;
									if (140172 - 195247 != -55074)
									{
										this.$self_$16567.transform.LookAt(this.$mPos$16564 + global::Math.vFlat(this.$tDir$16565));
										if (26784 - 319500 == -292716)
										{
											this.$self_$16567.animation.Play("cast");
											if (231915 - 24036 == 207879)
											{
												this.$self_$16567.animation.wrapMode = WrapMode.Once;
												if (18223 - 597797 != -579573)
												{
													this.$self_$16567.XU3nFvWP1y.vMovement = this.$self_$16567.transform.forward;
													if (29201 - 266611 == -237410)
													{
														this.$self_$16567.XU3nFvWP1y.moveSpeed = (float)0;
														if (85476 - 20698 == 64778)
														{
															if (this.$self_$16567.junkDrop_ring)
															{
																if (157680 - 175379 != -17698)
																{
																	this.$self_$16567.XU3nFvWP1y.createEffect(this.$self_$16567.junkDrop_ring, this.$self_$16567.transform.position, this.$self_$16567.transform.rotation);
																	if (191408 - 173253 == 18155)
																	{
																		goto IL_774;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing junkDrop_ring effect");
																if (52183 - 79078 == -26895)
																{
																	goto IL_520;
																}
															}
														}
													}
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
				goto IL_79D;
				IL_234:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_19:
				goto IL_D5;
				IL_520:
				return this.Yield(2, new WaitForSeconds(1.7f));
				IL_774:
				goto IL_520;
				IL_79D:
				return false;
			}

			// Token: 0x0600078C RID: 1932 RVA: 0x000C6988 File Offset: 0x000C4B88
			internal static bool IankVB3elIqVJOhSfKk()
			{
				return true;
			}

			// Token: 0x0600078D RID: 1933 RVA: 0x000C698C File Offset: 0x000C4B8C
			internal static bool pqaeM63rSLm0v3sa7ZW()
			{
				return false;
			}

			// Token: 0x040006EE RID: 1774
			internal Vector3 $hitPos$16562;

			// Token: 0x040006EF RID: 1775
			internal GameObject $hitObject$16563;

			// Token: 0x040006F0 RID: 1776
			internal Vector3 $mPos$16564;

			// Token: 0x040006F1 RID: 1777
			internal Vector3 $tDir$16565;

			// Token: 0x040006F2 RID: 1778
			internal int $tID$16566;

			// Token: 0x040006F3 RID: 1779
			internal PandoraBug $self_$16567;
		}
	}

	// Token: 0x02000152 RID: 338
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_junkDrop_hit$16572 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600078E RID: 1934 RVA: 0x000C6990 File Offset: 0x000C4B90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_junkDrop_hit$16572(Vector3 hitPos, PandoraBug self_)
		{
			if (206867 - 279436 != -72568)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (107862 - 514335 != -406472)
				{
					base..ctor();
					if (235745 - 456618 != -220872)
					{
						this.$hitPos$16579 = hitPos;
						if (154028 - 41329 == 112699)
						{
							this.$self_$16580 = self_;
							if (283033 - 570060 != -287026)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x000C6A4C File Offset: 0x000C4C4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PandoraBug.$RPC_junkDrop_hit$16572.$(this.$hitPos$16579, this.$self_$16580);
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x000C6A60 File Offset: 0x000C4C60
		internal static bool iqmlJf3jUEOeV6oOAjR()
		{
			return true;
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x000C6A64 File Offset: 0x000C4C64
		internal static bool ytZdRF3hOMBH1GbEHBJ()
		{
			return false;
		}

		// Token: 0x040006F4 RID: 1780
		internal Vector3 $hitPos$16579;

		// Token: 0x040006F5 RID: 1781
		internal PandoraBug $self_$16580;

		// Token: 0x02000153 RID: 339
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000792 RID: 1938 RVA: 0x000C6A68 File Offset: 0x000C4C68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 hitPos, PandoraBug self_)
			{
				if (154903 - 168334 != -13431)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (146086 - 303818 == -157732)
					{
						base..ctor();
						if (278588 - 503665 != -225076)
						{
							this.$hitPos$16577 = hitPos;
							if (40005 - 68613 != -28607)
							{
								this.$self_$16578 = self_;
								if (158764 - 448662 == -289898)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000793 RID: 1939 RVA: 0x000C6B24 File Offset: 0x000C4D24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (66632 - 143196 != -76563)
				{
				}
				for (;;)
				{
					IL_170:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2C9;
					case 2:
						if (this.$self_$16578.XU3nFvWP1y.isMine)
						{
							if (167498 - 66732 == 100767)
							{
								continue;
							}
							this.$hitLayer$16573 = 130816 - (1 << this.$self_$16578.gameObject.layer);
							if (298033 - 12591 == 285443)
							{
								continue;
							}
							this.$hitList$16574 = Damage.FindAreaTarget(this.$hitPos$16577, (float)2, (float)3, this.$hitLayer$16573);
							if (164804 - 525441 != -360637)
							{
								continue;
							}
							this.$$iterator$9977$16576 = UnityRuntimeServices.GetEnumerator(this.$hitList$16574);
							if (197534 - 125431 == 72104)
							{
								continue;
							}
							while (this.$$iterator$9977$16576.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9977$16576.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$16575 = (GameObject)obj2;
								if (123351 - 150041 == -26689)
								{
									goto IL_170;
								}
								this.$self_$16578.XU3nFvWP1y.hit(11, this.$hitObject$16575, this.$self_$16578.XU3nFvWP1y.talAdjust(30), 10, 0, Vector3.zero);
								if (81509 - 148747 == -67237)
								{
									goto IL_170;
								}
								UnityRuntimeServices.Update(this.$$iterator$9977$16576, this.$hitObject$16575);
								if (39270 - 48917 == -9646)
								{
									goto IL_170;
								}
							}
							if (115725 - 203869 != -88144)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (190641 - 463843 != -273202)
						{
							continue;
						}
						goto IL_2C9;
					default:
						if (39836 - 584925 == -545088)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16578.junkDrop_hit)
					{
						if (104211 - 325218 != -221006)
						{
							UnityEngine.Object.Instantiate(this.$self_$16578.junkDrop_hit, this.$hitPos$16577, Quaternion.identity);
							if (128247 - 224456 == -96209)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Cannot find junkDrop_hit effect");
						if (252871 - 136000 == 116871)
						{
							break;
						}
					}
				}
				IL_B3:
				return this.Yield(2, new WaitForSeconds(0.5f));
				goto IL_B3;
				IL_2C9:
				return false;
			}

			// Token: 0x06000794 RID: 1940 RVA: 0x000C6E0C File Offset: 0x000C500C
			internal static bool W63rFa3sQTGCoNs42qJ()
			{
				return true;
			}

			// Token: 0x06000795 RID: 1941 RVA: 0x000C6E10 File Offset: 0x000C5010
			internal static bool JhYnvX39yoRMspn6jYf()
			{
				return false;
			}

			// Token: 0x040006F6 RID: 1782
			internal int $hitLayer$16573;

			// Token: 0x040006F7 RID: 1783
			internal UnityScript.Lang.Array $hitList$16574;

			// Token: 0x040006F8 RID: 1784
			internal GameObject $hitObject$16575;

			// Token: 0x040006F9 RID: 1785
			internal IEnumerator $$iterator$9977$16576;

			// Token: 0x040006FA RID: 1786
			internal Vector3 $hitPos$16577;

			// Token: 0x040006FB RID: 1787
			internal PandoraBug $self_$16578;
		}
	}

	// Token: 0x02000154 RID: 340
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$16581 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000796 RID: 1942 RVA: 0x000C6E14 File Offset: 0x000C5014
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$16581(UnityScript.Lang.Array nArray, PandoraBug self_)
		{
			if (41133 - 576505 != -535371)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (125037 - 309714 != -184676)
				{
					base..ctor();
					if (202001 - 189550 == 12451)
					{
						this.$nArray$16586 = nArray;
						if (293539 - 395741 == -102202)
						{
							this.$self_$16587 = self_;
							if (18479 - 43526 != -25046)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x000C6ED0 File Offset: 0x000C50D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PandoraBug.$RPC_ko$16581.$(this.$nArray$16586, this.$self_$16587);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x000C6EE4 File Offset: 0x000C50E4
		internal static bool xnrYkT31j4260AKL0nG()
		{
			return true;
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x000C6EE8 File Offset: 0x000C50E8
		internal static bool fB7aX334B3kYJXpaXbH()
		{
			return false;
		}

		// Token: 0x040006FC RID: 1788
		internal UnityScript.Lang.Array $nArray$16586;

		// Token: 0x040006FD RID: 1789
		internal PandoraBug $self_$16587;

		// Token: 0x02000155 RID: 341
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600079A RID: 1946 RVA: 0x000C6EEC File Offset: 0x000C50EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, PandoraBug self_)
			{
				if (56483 - 65463 != -8979)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (212611 - 68693 != 143919)
					{
						base..ctor();
						if (38499 - 586679 != -548179)
						{
							this.$nArray$16584 = nArray;
							if (229560 - 115813 == 113747)
							{
								this.$self_$16585 = self_;
								if (35670 - 597376 != -561705)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600079B RID: 1947 RVA: 0x000C6FA8 File Offset: 0x000C51A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (286808 - 292908 != -6100)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_48C;
					case 2:
						if (this.$self_$16585.XU3nFvWP1y.actionState != "ko")
						{
							if (252929 - 100828 != 152101)
							{
								continue;
							}
							goto IL_B4;
						}
						else
						{
							this.$self_$16585.animation.Play("getUp");
							if (208537 - 482544 == -274006)
							{
								continue;
							}
							this.$self_$16585.animation.wrapMode = WrapMode.Once;
							if (149673 - 196813 != -47140)
							{
								continue;
							}
							goto IL_355;
						}
						break;
					case 3:
						if (this.$self_$16585.XU3nFvWP1y.actionState != "ko")
						{
							if (75146 - 587716 != -512570)
							{
								continue;
							}
							goto IL_29F;
						}
						else
						{
							this.$self_$16585.XU3nFvWP1y.actionState = "standby";
							if (101614 - 52355 == 49260)
							{
								continue;
							}
							this.$self_$16585.XU3nFvWP1y.actionTime = Time.time;
							if (270138 - 1148 != 268990)
							{
								continue;
							}
							this.$self_$16585.XU3nFvWP1y.myCommand = "none";
							if (292299 - 136043 != 156256)
							{
								continue;
							}
							this.$self_$16585.XU3nFvWP1y.ko = this.$self_$16585.XU3nFvWP1y.mko;
							if (228285 - 198964 != 29321)
							{
								continue;
							}
							this.YieldDefault(1);
							if (166982 - 76430 != 90553)
							{
								goto Block_20;
							}
							continue;
						}
						break;
					default:
						if (226059 - 463406 != -237347)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16585.XU3nFvWP1y.actionState == "ko")
					{
						break;
					}
					if (264039 - 68539 != 195501)
					{
						if (this.$self_$16585.XU3nFvWP1y.actionState == "dead")
						{
							if (141492 - 62199 != 79294)
							{
								break;
							}
						}
						else
						{
							this.$mPos$16582 = (Vector3)this.$nArray$16584[0];
							if (228045 - 201762 == 26283)
							{
								this.$mDir$16583 = (Vector3)this.$nArray$16584[1];
								if (9668 - 1003 != 8666)
								{
									this.$self_$16585.XU3nFvWP1y.ko = 0;
									if (274897 - 529958 == -255061)
									{
										this.$self_$16585.XU3nFvWP1y.actionState = "ko";
										if (163777 - 454758 == -290981)
										{
											this.$self_$16585.XU3nFvWP1y.actionTime = Time.time;
											if (122962 - 561539 == -438577)
											{
												this.$self_$16585.XU3nFvWP1y.myCommand = "none";
												if (262724 - 529881 != -267156)
												{
													this.$self_$16585.XU3nFvWP1y.vMovement = Vector3.zero;
													if (24749 - 291923 == -267174)
													{
														this.$self_$16585.XU3nFvWP1y.moveSpeed = (float)0;
														if (281575 - 39856 != 241720)
														{
															this.$self_$16585.animation.Play("ko");
															if (128551 - 385592 != -257040)
															{
																this.$self_$16585.animation.wrapMode = WrapMode.Once;
																if (169983 - 247581 == -77598)
																{
																	goto IL_E9;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_B4:
				goto IL_48C;
				IL_E9:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_29F:
				Block_20:
				goto IL_48C;
				IL_355:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_48C:
				return false;
			}

			// Token: 0x0600079C RID: 1948 RVA: 0x000C7454 File Offset: 0x000C5654
			internal static bool D1WwBH3zZ1SpFFVKWyU()
			{
				return true;
			}

			// Token: 0x0600079D RID: 1949 RVA: 0x000C7458 File Offset: 0x000C5658
			internal static bool urMoxqXaHtebZhYvxCj()
			{
				return false;
			}

			// Token: 0x040006FE RID: 1790
			internal Vector3 $mPos$16582;

			// Token: 0x040006FF RID: 1791
			internal Vector3 $mDir$16583;

			// Token: 0x04000700 RID: 1792
			internal UnityScript.Lang.Array $nArray$16584;

			// Token: 0x04000701 RID: 1793
			internal PandoraBug $self_$16585;
		}
	}

	// Token: 0x02000156 RID: 342
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$16588 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600079E RID: 1950 RVA: 0x000C745C File Offset: 0x000C565C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$16588(UnityScript.Lang.Array nArray, PandoraBug self_)
		{
			if (202617 - 365482 != -162864)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (65840 - 375891 != -310050)
				{
					base..ctor();
					if (211577 - 575570 == -363993)
					{
						this.$nArray$16593 = nArray;
						if (84994 - 382911 != -297916)
						{
							this.$self_$16594 = self_;
							if (8408 - 274221 == -265813)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x000C7518 File Offset: 0x000C5718
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PandoraBug.$RPC_dead$16588.$(this.$nArray$16593, this.$self_$16594);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x000C752C File Offset: 0x000C572C
		internal static bool LW8puPX5oCLOOMtjqit()
		{
			return true;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x000C7530 File Offset: 0x000C5730
		internal static bool REyBflXpM3st5KQF44w()
		{
			return false;
		}

		// Token: 0x04000702 RID: 1794
		internal UnityScript.Lang.Array $nArray$16593;

		// Token: 0x04000703 RID: 1795
		internal PandoraBug $self_$16594;

		// Token: 0x02000157 RID: 343
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060007A2 RID: 1954 RVA: 0x000C7534 File Offset: 0x000C5734
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, PandoraBug self_)
			{
				if (198614 - 591102 != -392488)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (267100 - 348237 != -81136)
					{
						base..ctor();
						if (92273 - 477059 == -384786)
						{
							this.$nArray$16591 = nArray;
							if (230576 - 228781 == 1795)
							{
								this.$self_$16592 = self_;
								if (200183 - 292170 == -91987)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060007A3 RID: 1955 RVA: 0x000C75F0 File Offset: 0x000C57F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (41339 - 93594 != -52254)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_42F;
					case 2:
						if (this.$self_$16592.XU3nFvWP1y.actionState != "dead")
						{
							if (88378 - 74534 != 13844)
							{
								continue;
							}
							goto IL_3FB;
						}
						else
						{
							if (!this.$self_$16592.XU3nFvWP1y.isPlayer)
							{
								if (246355 - 481041 == -234685)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$16592.gameObject);
								if (253721 - 451566 != -197845)
								{
									continue;
								}
							}
							else if (this.$self_$16592.XU3nFvWP1y.isMine)
							{
								if (257896 - 51636 != 206260)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$16592.gameObject);
								if (38933 - 258273 != -219340)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (37865 - 471217 != -433351)
							{
								goto Block_8;
							}
							continue;
						}
						break;
					default:
						if (62189 - 76170 != -13981)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16592.XU3nFvWP1y.actionState == "dead")
					{
						if (134728 - 481852 != -347123)
						{
							goto Block_11;
						}
					}
					else
					{
						this.$myPosition$16589 = (Vector3)this.$nArray$16591[0];
						if (288698 - 137364 != 151335)
						{
							this.$myDirection$16590 = (Vector3)this.$nArray$16591[1];
							if (50828 - 10683 != 40146)
							{
								this.$self_$16592.transform.position = this.$myPosition$16589;
								if (246140 - 11652 == 234488)
								{
									this.$self_$16592.transform.LookAt(this.$myPosition$16589 + this.$myDirection$16590);
									if (51876 - 408276 != -356399)
									{
										this.$self_$16592.XU3nFvWP1y.hp = 0;
										if (65210 - 146197 != -80986)
										{
											this.$self_$16592.XU3nFvWP1y.actionState = "dead";
											if (188828 - 437402 != -248573)
											{
												this.$self_$16592.XU3nFvWP1y.actionTime = Time.time;
												if (115978 - 488217 == -372239)
												{
													this.$self_$16592.XU3nFvWP1y.myCommand = "none";
													if (97035 - 335587 != -238551)
													{
														this.$self_$16592.XU3nFvWP1y.vMovement = Vector3.zero;
														if (73287 - 431 != 72857)
														{
															this.$self_$16592.XU3nFvWP1y.moveSpeed = (float)0;
															if (148789 - 34857 == 113932)
															{
																this.$self_$16592.animation.Rewind();
																if (278028 - 108680 != 169349)
																{
																	this.$self_$16592.animation.Play("ko");
																	if (120358 - 326645 == -206287)
																	{
																		this.$self_$16592.animation.wrapMode = WrapMode.Once;
																		if (55734 - 557801 != -502066)
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
				return this.Yield(2, new WaitForSeconds(3f));
				Block_8:
				Block_11:
				IL_3FB:
				IL_42F:
				return false;
			}

			// Token: 0x060007A4 RID: 1956 RVA: 0x000C7A40 File Offset: 0x000C5C40
			internal static bool m2c8bcXVieLqWOcf5nL()
			{
				return true;
			}

			// Token: 0x060007A5 RID: 1957 RVA: 0x000C7A44 File Offset: 0x000C5C44
			internal static bool uZ2uSgXtJRl5mUj2gEm()
			{
				return false;
			}

			// Token: 0x04000704 RID: 1796
			internal Vector3 $myPosition$16589;

			// Token: 0x04000705 RID: 1797
			internal Vector3 $myDirection$16590;

			// Token: 0x04000706 RID: 1798
			internal UnityScript.Lang.Array $nArray$16591;

			// Token: 0x04000707 RID: 1799
			internal PandoraBug $self_$16592;
		}
	}
}
