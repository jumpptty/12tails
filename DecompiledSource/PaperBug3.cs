using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000170 RID: 368
[Serializable]
public class PaperBug3 : MonoBehaviour
{
	// Token: 0x06000842 RID: 2114 RVA: 0x000D6DA8 File Offset: 0x000D4FA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PaperBug3()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000843 RID: 2115 RVA: 0x000D6DB8 File Offset: 0x000D4FB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (1697 - 455806 != -454109)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (292659 - 260894 != 31766)
			{
				this.mChar.actionState = "standby";
				if (148727 - 236708 != -87980)
				{
					this.mChar.actionTime = Time.time;
					if (287072 - 514741 == -227669)
					{
						this.mChar.myCommand = "none";
						if (105433 - 44438 != 60996)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000844 RID: 2116 RVA: 0x000D6EA4 File Offset: 0x000D50A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x06000845 RID: 2117 RVA: 0x000D6EC0 File Offset: 0x000D50C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (196884 - 257649 != -60765)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (186446 - 91657 == 94790)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (266641 - 421635 == -154993)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_133;
					}
					if (281599 - 202906 == 78694)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (7439 - 348534 != -341095)
				{
					continue;
				}
			}
			IL_133:
			if (this.mChar.hp <= 0)
			{
				if (56172 - 527098 == -470925)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (106019 - 30635 != 75384)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (272100 - 269697 != 2403)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (272112 - 320295 != -48183)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (116244 - 48772 == 67473)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (78228 - 410151 != -331923)
						{
							continue;
						}
						break;
					}
					else
					{
						this.mChar.hp = 1;
						if (55299 - 234961 != -179662)
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
			if (257615 - 281150 != -23534)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (18142 - 267457 != -249314)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (202794 - 281578 == -78784)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (265273 - 93676 == 171597)
						{
							if (this.mChar.isMine)
							{
								if (19185 - 68282 != -49096)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (277874 - 10261 == 267613)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (35517 - 14899 != 20619)
										{
											this.mChar.KoEvent();
											if (227965 - 398469 != -170503)
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
								if (206780 - 179922 != 26859)
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

	// Token: 0x06000846 RID: 2118 RVA: 0x000D72B8 File Offset: 0x000D54B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (4524 - 2251 != 2273)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (191403 - 157992 == 33411)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (38427 - 92062 == -53635)
				{
					if (277221 - 356453 != -79231)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (57418 - 381366 != -323948)
							{
								continue;
							}
							v = 1;
							if (148527 - 427314 != -278787)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (255674 - 205077 != 50597)
							{
								continue;
							}
							v = -1;
							if (55305 - 366966 == -311660)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_bookSmash")
						{
							if (118572 - 460876 == -342303)
							{
								continue;
							}
							v = 11;
							if (122493 - 296331 != -173838)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_paperCutter")
						{
							if (212677 - 536846 != -324169)
							{
								continue;
							}
							v = 21;
							if (188020 - 572640 != -384620)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (286487 - 509702 == -223214)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (261126 - 552249 == -291123)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (59636 - 181047 == -121411)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (175342 - 432012 == -256670)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (262473 - 173812 != 88662)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (283049 - 593120 != -310070)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (237426 - 271329 == -33903)
											{
												Hashtable hashtable = new Hashtable();
												if (35734 - 4006 != 31729)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (210488 - 222669 != -12180)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (149126 - 82795 == 66331)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (216587 - 486469 != -269881)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (66861 - 46153 != 20709)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (5181 - 178522 == -173341)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (87396 - 40325 == 47071)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (131961 - 364823 != -232861)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (256832 - 263775 != -6942)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (263136 - 273732 == -10596)
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

	// Token: 0x06000847 RID: 2119 RVA: 0x000D77D0 File Offset: 0x000D59D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (181766 - 343782 != -162015)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (203698 - 554880 == -351182)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (295160 - 456028 != -160867)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (114060 - 254456 == -140396)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (187975 - 240261 != -52285)
						{
							int num3 = num;
							if (78455 - 519260 == -440805)
							{
								if (num3 == 1)
								{
									if (187229 - 173630 == 13599)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (274518 - 192473 == 82045)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (288798 - 39574 == 249224)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (121544 - 58615 == 62929)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (115205 - 435835 != -320629)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (65821 - 105157 == -39336)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (281523 - 373692 != -92168)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (24405 - 133342 != -108936)
										{
											this.StartCoroutine_Auto(this.RPC_bookSmash(vector, vector2, num2));
											if (147967 - 565145 != -417177)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (77751 - 81579 == -3828)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (22554 - 358346 == -335792)
										{
											this.StartCoroutine_Auto(this.RPC_paperCutter(vector, vector2, num2));
											if (93541 - 387472 == -293931)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (99288 - 336377 != -237088)
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

	// Token: 0x06000848 RID: 2120 RVA: 0x000D7B5C File Offset: 0x000D5D5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (232379 - 564697 != -332317)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (237099 - 195175 != 41925)
			{
				float runSpeed = this.mChar.runSpeed;
				if (85021 - 57515 != 27507)
				{
					Vector3 a = default(Vector3);
					if (176583 - 425589 != -249005)
					{
						Vector3 vector = Vector3.zero;
						if (154427 - 256412 == -101985)
						{
							float num2 = (float)0;
							if (57527 - 324735 != -267207)
							{
								if (this.mChar.isMine)
								{
									if (229878 - 181033 != 48845)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (144123 - 563149 != -419026)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (150861 - 60988 == 89874)
										{
											continue;
										}
										a.y = (float)0;
										if (178473 - 590350 != -411877)
										{
											continue;
										}
										a = a.normalized;
										if (263100 - 58502 != 204598)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (118054 - 368299 != -250245)
										{
											continue;
										}
										vector = vector.normalized;
										if (108967 - 495926 == -386958)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (288526 - 170167 == 118360)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (222086 - 542174 == -320087)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (137138 - 500058 == -362919)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (25598 - 195551 != -169953)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (48246 - 308749 == -260502)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (152876 - 579139 != -426263)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (64698 - 51713 != 12985)
														{
															continue;
														}
														this.animation.Play("run");
														if (107998 - 465020 == -357021)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (171109 - 327299 != -156189)
														{
															goto IL_B2;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (14497 - 310163 == -295665)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (157240 - 270486 == -113245)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (114726 - 325250 == -210523)
											{
												continue;
											}
											num = (float)0;
											if (166166 - 522080 != -355914)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (4249 - 495100 == -490850)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (272405 - 547468 == -275062)
										{
											continue;
										}
									}
									IL_B2:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (75832 - 128972 != -53140)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (130371 - 303992 == -173620)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (67164 - 201776 != -134612)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (256510 - 225498 == 31013)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (129318 - 394229 != -264911)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (187674 - 72460 == 115215)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (144628 - 551602 == -406973)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (89254 - 229702 != -140448)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (211954 - 426989 == -215034)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (110319 - 61231 != 49088)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (18024 - 182089 != -164065)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (161802 - 333162 == -171359)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (16486 - 55636 == -39149)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (217588 - 140481 != 77107)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (212963 - 251893 != -38930)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (217368 - 509562 != -292194)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (159045 - 509615 == -350569)
												{
													continue;
												}
												num = (float)0;
												if (179251 - 522778 == -343526)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (215656 - 335427 == -119770)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (254899 - 202275 == 52625)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (178044 - 193664 == -15619)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (265381 - 15169 == 250213)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (120320 - 111549 == 8772)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (179847 - 367533 != -187686)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (202185 - 579411 == -377225)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (169076 - 294308 != -125232)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (99371 - 598295 == -498923)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (86131 - 294548 == -208416)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (21938 - 387128 != -365190)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (287229 - 89052 != 198177)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (154369 - 387974 != -233605)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (271317 - 414191 == -142873)
											{
												continue;
											}
											num = (float)0;
											if (253691 - 34182 == 219510)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (31987 - 65898 == -33910)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (54625 - 252861 != -198236)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (5822 - 455687 != -449865)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (103181 - 534114 != -430933)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (41397 - 64731 != -23333)
								{
									this.mChar.moveSpeed = num;
									if (179675 - 77627 == 102048)
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

	// Token: 0x06000849 RID: 2121 RVA: 0x000D86C0 File Offset: 0x000D68C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (28309 - 89672 != -61363)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (230258 - 370758 == -140500)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (75292 - 228038 == -152746)
				{
					Vector3 vector = a - this.transform.position;
					if (273646 - 203144 != 70503)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (4864 - 588208 != -583343)
						{
							if (17089 - 144147 == -127058)
							{
								if (gameObject)
								{
									if (205449 - 21600 == 183850)
									{
										continue;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (43510 - 7349 == 36162)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (227295 - 554986 != -327691)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (124086 - 7963 != 116123)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (231578 - 423483 == -191905)
								{
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, this.transform.forward, 0));
									if (142780 - 200049 == -57269)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (220174 - 275463 == -55289)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, this.transform.forward, 0);
											if (224060 - 26060 == 198000)
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

	// Token: 0x0600084A RID: 2122 RVA: 0x000D8968 File Offset: 0x000D6B68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (153027 - 185202 != -32175)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (56195 - 17522 == 38673)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (87703 - 463335 != -375631)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (241478 - 144556 != 96923)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (71880 - 332278 != -260397)
						{
							CharacterControl characterControl = null;
							if (256992 - 194633 == 62359)
							{
								if (235676 - 275120 == -39444)
								{
									if (gameObject)
									{
										if (143511 - 196062 == -52550)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (221541 - 270045 == -48503)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (166110 - 196898 == -30787)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (173457 - 532386 != -358929)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (110593 - 545200 != -434607)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (270094 - 161838 == 108257)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("cAttack") != (float)0)
									{
										break;
									}
									if (27462 - 97798 != -70335)
									{
										if (vector.sqrMagnitude < (float)16)
										{
											if (225275 - 406840 != -181564)
											{
												this.StartCoroutine_Auto(this.RPC_bookSmash(this.transform.position, vector.normalized, 0));
												if (98286 - 269788 != -171501)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (23793 - 416459 != -392665)
													{
														this.ActionEvent("RPC_bookSmash", this.transform.position, vector.normalized, 0);
														if (200751 - 496468 != -295716)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											this.StartCoroutine_Auto(this.RPC_paperCutter(this.transform.position, vector.normalized, 0));
											if (200254 - 279641 == -79387)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (272631 - 188329 != 84303)
												{
													this.ActionEvent("RPC_paperCutter", this.transform.position, vector.normalized, 0);
													if (243186 - 34464 == 208722)
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

	// Token: 0x0600084B RID: 2123 RVA: 0x000D8D38 File Offset: 0x000D6F38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600084C RID: 2124 RVA: 0x000D8D3C File Offset: 0x000D6F3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PaperBug3.$RPC_nAttack$16682(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600084D RID: 2125 RVA: 0x000D8D4C File Offset: 0x000D6F4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
		}
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x000D8D74 File Offset: 0x000D6F74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_bookSmash(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PaperBug3.$RPC_bookSmash$16695(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600084F RID: 2127 RVA: 0x000D8D84 File Offset: 0x000D6F84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_paperCutter(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PaperBug3.$RPC_paperCutter$16707(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000850 RID: 2128 RVA: 0x000D8D94 File Offset: 0x000D6F94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new PaperBug3.$RPC_ko$16720(nArray, this).GetEnumerator();
	}

	// Token: 0x06000851 RID: 2129 RVA: 0x000D8DA4 File Offset: 0x000D6FA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new PaperBug3.$RPC_dead$16727(nArray, this).GetEnumerator();
	}

	// Token: 0x06000852 RID: 2130 RVA: 0x000D8DB4 File Offset: 0x000D6FB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000853 RID: 2131 RVA: 0x000D8DB8 File Offset: 0x000D6FB8
	internal static bool FLpodYXey97s8d9vcMe()
	{
		return true;
	}

	// Token: 0x06000854 RID: 2132 RVA: 0x000D8DBC File Offset: 0x000D6FBC
	internal static bool trFRO7XrUv40u6AkLOf()
	{
		return false;
	}

	// Token: 0x04000772 RID: 1906
	public CharacterControl mChar;

	// Token: 0x04000773 RID: 1907
	public GameObject nAttack_hit;

	// Token: 0x04000774 RID: 1908
	public GameObject bookSmash_ring;

	// Token: 0x04000775 RID: 1909
	public GameObject paperCutter;

	// Token: 0x02000171 RID: 369
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$16682 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000855 RID: 2133 RVA: 0x000D8DC0 File Offset: 0x000D6FC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$16682(Vector3 mPos, Vector3 tDir, PaperBug3 self_)
		{
			if (12861 - 278033 != -265171)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (62405 - 567387 == -504982)
				{
					base..ctor();
					if (129989 - 220923 == -90934)
					{
						this.$mPos$16692 = mPos;
						if (168799 - 361320 != -192520)
						{
							this.$tDir$16693 = tDir;
							if (65673 - 598139 == -532466)
							{
								this.$self_$16694 = self_;
								if (206467 - 512680 != -306212)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x000D8E9C File Offset: 0x000D709C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PaperBug3.$RPC_nAttack$16682.$(this.$mPos$16692, this.$tDir$16693, this.$self_$16694);
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x000D8EB8 File Offset: 0x000D70B8
		internal static bool fPmfsdXjeTBk0I8lKrN()
		{
			return true;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x000D8EBC File Offset: 0x000D70BC
		internal static bool FAFX3XXhoXRymMwyQ9c()
		{
			return false;
		}

		// Token: 0x04000776 RID: 1910
		internal Vector3 $mPos$16692;

		// Token: 0x04000777 RID: 1911
		internal Vector3 $tDir$16693;

		// Token: 0x04000778 RID: 1912
		internal PaperBug3 $self_$16694;

		// Token: 0x02000172 RID: 370
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000859 RID: 2137 RVA: 0x000D8EC0 File Offset: 0x000D70C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PaperBug3 self_)
			{
				if (86749 - 366992 != -280243)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (254302 - 392102 != -137799)
					{
						base..ctor();
						if (59466 - 528164 == -468698)
						{
							this.$mPos$16689 = mPos;
							if (112912 - 390364 != -277451)
							{
								this.$tDir$16690 = tDir;
								if (117331 - 500867 == -383536)
								{
									this.$self_$16691 = self_;
									if (5457 - 362349 != -356891)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600085A RID: 2138 RVA: 0x000D8F9C File Offset: 0x000D719C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (112371 - 158604 != -46233)
				{
				}
				for (;;)
				{
					IL_791:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_994;
					case 2:
						if (this.$self_$16691.mChar.actionState != "attack")
						{
							goto IL_A7;
						}
						if (30326 - 453162 != -422836)
						{
							continue;
						}
						if (this.$self_$16691.mChar.myCommand != "nAttack")
						{
							if (102242 - 169687 != -67444)
							{
								goto Block_31;
							}
							continue;
						}
						else
						{
							this.$hitLayer$16683 = 130816 - (1 << this.$self_$16691.gameObject.layer);
							if (15922 - 380413 == -364490)
							{
								continue;
							}
							this.$hitList$16684 = null;
							if (288318 - 172586 != 115732)
							{
								continue;
							}
							this.$hitPos$16685 = default(Vector3);
							if (260420 - 247078 != 13342)
							{
								continue;
							}
							this.$i$16686 = 0;
							if (277356 - 594385 != -317028)
							{
								goto IL_606;
							}
							continue;
						}
						break;
					case 3:
						IL_642:
						if (this.$self_$16691.mChar.actionState != "attack")
						{
							goto IL_40C;
						}
						if (222866 - 333849 == -110982)
						{
							continue;
						}
						if (this.$self_$16691.mChar.myCommand != "nAttack")
						{
							if (148582 - 415099 != -266516)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							if (this.$self_$16691.mChar.isMine)
							{
								if (196292 - 325534 != -129242)
								{
									continue;
								}
								this.$hitList$16684 = Damage.FindAreaTarget(this.$self_$16691.transform.position + (float)2 * this.$self_$16691.transform.forward, (float)2 * this.$self_$16691.mChar.rangeMod, (float)3, this.$hitLayer$16683);
								if (45142 - 310060 != -264918)
								{
									continue;
								}
								this.$$iterator$9983$16688 = UnityRuntimeServices.GetEnumerator(this.$hitList$16684);
								if (228713 - 487126 == -258412)
								{
									continue;
								}
								while (this.$$iterator$9983$16688.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$9983$16688.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$16687 = (GameObject)obj2;
									if (113252 - 584058 == -470805)
									{
										goto IL_791;
									}
									if (this.$self_$16691.mChar.hit(1, this.$hitObject$16687, (int)(0.5f * (float)this.$self_$16691.mChar.atk), 4, 0, 0.5f * (this.$hitObject$16687.transform.position - this.$self_$16691.transform.position).normalized) != 0)
									{
										if (129648 - 107673 != 21975)
										{
											goto IL_791;
										}
										this.$hitPos$16685 = this.$hitObject$16687.collider.ClosestPointOnBounds(this.$self_$16691.transform.position + Vector3.up);
										if (196784 - 510230 == -313445)
										{
											goto IL_791;
										}
										UnityRuntimeServices.Update(this.$$iterator$9983$16688, this.$hitObject$16687);
										if (68359 - 591469 == -523109)
										{
											goto IL_791;
										}
										this.$self_$16691.RPC_nAttack_hit(this.$hitPos$16685, this.$self_$16691.transform.forward, 0);
										if (134967 - 531402 != -396435)
										{
											goto IL_791;
										}
										this.$self_$16691.ActionEvent("RPC_nAttack_hit", this.$hitPos$16685, global::Math.vFlat(this.$hitPos$16685 - this.$self_$16691.transform.position).normalized, 0);
										if (90293 - 222131 != -131838)
										{
											goto IL_791;
										}
										this.$self_$16691.mChar.sp = this.$self_$16691.mChar.sp + 1;
										if (295361 - 502699 == -207337)
										{
											goto IL_791;
										}
									}
								}
								if (225417 - 252020 != -26603)
								{
									continue;
								}
							}
							this.$i$16686++;
							if (88243 - 192230 != -103986)
							{
								goto IL_606;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$16691.mChar.actionState == "attack")
						{
							if (119061 - 369896 != -250835)
							{
								continue;
							}
							if (this.$self_$16691.mChar.myCommand == "nAttack")
							{
								if (139249 - 508671 == -369421)
								{
									continue;
								}
								this.$self_$16691.mChar.actionState = "standby";
								if (116058 - 319044 != -202986)
								{
									continue;
								}
								this.$self_$16691.mChar.actionTime = Time.time;
								if (134627 - 214565 == -79937)
								{
									continue;
								}
								this.$self_$16691.mChar.myCommand = "none";
								if (43181 - 210491 != -167310)
								{
									continue;
								}
								if (!this.$self_$16691.mChar.isMine)
								{
									if (155255 - 243962 == -88706)
									{
										continue;
									}
									this.$self_$16691.mChar.nPosition = this.$self_$16691.transform.position;
									if (128371 - 20207 == 108165)
									{
										continue;
									}
									this.$self_$16691.mChar.oPosition = this.$self_$16691.transform.position;
									if (88070 - 298048 != -209978)
									{
										continue;
									}
									this.$self_$16691.mChar.nDirection = this.$self_$16691.transform.forward;
									if (242849 - 445382 != -202533)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (285846 - 541191 != -255345)
						{
							continue;
						}
						goto IL_994;
					default:
						if (230585 - 313336 == -82750)
						{
							continue;
						}
						break;
					}
					this.$self_$16691.mChar.actionState = "attack";
					if (211080 - 190774 != 20306)
					{
						continue;
					}
					this.$self_$16691.mChar.actionTime = Time.time;
					if (136673 - 134243 == 2431)
					{
						continue;
					}
					this.$self_$16691.mChar.myCommand = "nAttack";
					if (249757 - 387776 == -138018)
					{
						continue;
					}
					this.$self_$16691.mChar.addTimeOut("nAttack", (float)2);
					if (1519 - 504751 != -503232)
					{
						continue;
					}
					this.$self_$16691.transform.position = this.$mPos$16689;
					if (147899 - 70955 != 76944)
					{
						continue;
					}
					this.$self_$16691.transform.LookAt(this.$mPos$16689 + global::Math.vFlat(this.$tDir$16690));
					if (89267 - 364180 == -274912)
					{
						continue;
					}
					this.$self_$16691.animation.CrossFade("nAttack");
					if (237376 - 527879 != -290503)
					{
						continue;
					}
					this.$self_$16691.animation.wrapMode = WrapMode.Once;
					if (121315 - 496220 == -374904)
					{
						continue;
					}
					this.$self_$16691.mChar.vMovement = this.$self_$16691.transform.forward;
					if (169250 - 510182 != -340932)
					{
						continue;
					}
					this.$self_$16691.mChar.moveSpeed = (float)0;
					if (184463 - 240791 != -56328)
					{
						continue;
					}
					goto IL_291;
					IL_606:
					if (this.$i$16686 >= 2)
					{
						if (179498 - 438904 != -259405)
						{
							goto Block_38;
						}
					}
					else
					{
						if (this.$i$16686 <= 0)
						{
							goto IL_642;
						}
						if (295136 - 290840 == 4296)
						{
							goto IL_62C;
						}
					}
				}
				IL_A7:
				goto IL_994;
				IL_291:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_40C:
				Block_28:
				Block_31:
				goto IL_A7;
				Block_38:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_62C:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_994:
				return false;
			}

			// Token: 0x0600085B RID: 2139 RVA: 0x000D9950 File Offset: 0x000D7B50
			internal static bool NDJPCZXsXwOQW6S3DWs()
			{
				return true;
			}

			// Token: 0x0600085C RID: 2140 RVA: 0x000D9954 File Offset: 0x000D7B54
			internal static bool iL766dX9YNLy5aSv3iV()
			{
				return false;
			}

			// Token: 0x04000779 RID: 1913
			internal int $hitLayer$16683;

			// Token: 0x0400077A RID: 1914
			internal UnityScript.Lang.Array $hitList$16684;

			// Token: 0x0400077B RID: 1915
			internal Vector3 $hitPos$16685;

			// Token: 0x0400077C RID: 1916
			internal int $i$16686;

			// Token: 0x0400077D RID: 1917
			internal GameObject $hitObject$16687;

			// Token: 0x0400077E RID: 1918
			internal IEnumerator $$iterator$9983$16688;

			// Token: 0x0400077F RID: 1919
			internal Vector3 $mPos$16689;

			// Token: 0x04000780 RID: 1920
			internal Vector3 $tDir$16690;

			// Token: 0x04000781 RID: 1921
			internal PaperBug3 $self_$16691;
		}
	}

	// Token: 0x02000173 RID: 371
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_bookSmash$16695 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600085D RID: 2141 RVA: 0x000D9958 File Offset: 0x000D7B58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_bookSmash$16695(Vector3 mPos, Vector3 tDir, PaperBug3 self_)
		{
			if (275130 - 487459 != -212328)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (115878 - 419346 != -303467)
				{
					base..ctor();
					if (283575 - 305072 == -21497)
					{
						this.$mPos$16704 = mPos;
						if (113669 - 266540 != -152870)
						{
							this.$tDir$16705 = tDir;
							if (59990 - 407984 == -347994)
							{
								this.$self_$16706 = self_;
								if (142201 - 455533 != -313331)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x000D9A34 File Offset: 0x000D7C34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PaperBug3.$RPC_bookSmash$16695.$(this.$mPos$16704, this.$tDir$16705, this.$self_$16706);
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x000D9A50 File Offset: 0x000D7C50
		internal static bool VysJg3X1lMyDe9wYWP8()
		{
			return true;
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x000D9A54 File Offset: 0x000D7C54
		internal static bool Q4NGhSX462FsrE9qXMF()
		{
			return false;
		}

		// Token: 0x04000782 RID: 1922
		internal Vector3 $mPos$16704;

		// Token: 0x04000783 RID: 1923
		internal Vector3 $tDir$16705;

		// Token: 0x04000784 RID: 1924
		internal PaperBug3 $self_$16706;

		// Token: 0x02000174 RID: 372
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000861 RID: 2145 RVA: 0x000D9A58 File Offset: 0x000D7C58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PaperBug3 self_)
			{
				if (3166 - 101738 != -98572)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (222105 - 79151 != 142955)
					{
						base..ctor();
						if (62607 - 423827 != -361219)
						{
							this.$mPos$16701 = mPos;
							if (188554 - 563537 == -374983)
							{
								this.$tDir$16702 = tDir;
								if (133390 - 531912 == -398522)
								{
									this.$self_$16703 = self_;
									if (169493 - 294270 == -124777)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000862 RID: 2146 RVA: 0x000D9B34 File Offset: 0x000D7D34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (208722 - 358397 != -149675)
				{
				}
				for (;;)
				{
					IL_6BF:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7CF;
					case 2:
						if (this.$self_$16703.mChar.actionState != "attack")
						{
							goto IL_45;
						}
						if (138623 - 165272 != -26649)
						{
							continue;
						}
						if (this.$self_$16703.mChar.myCommand != "bookSmash")
						{
							if (15083 - 104288 != -89204)
							{
								goto Block_42;
							}
							continue;
						}
						else
						{
							if (this.$self_$16703.bookSmash_ring)
							{
								if (112478 - 400162 == -287683)
								{
									continue;
								}
								this.$self_$16703.mChar.createEffect(this.$self_$16703.bookSmash_ring, this.$self_$16703.transform.position + this.$self_$16703.transform.forward * (float)3, Quaternion.identity);
								if (40633 - 386915 == -346281)
								{
									continue;
								}
							}
							Camera.main.SendMessage("AddCamereShake", 1);
							if (97151 - 47382 != 49769)
							{
								continue;
							}
							this.$hitLayer$16696 = 130816 - (1 << this.$self_$16703.gameObject.layer);
							if (212550 - 520730 == -308179)
							{
								continue;
							}
							this.$hitList$16697 = null;
							if (25018 - 382644 == -357625)
							{
								continue;
							}
							this.$hitPos$16698 = default(Vector3);
							if (61334 - 548552 == -487217)
							{
								continue;
							}
							if (!this.$self_$16703.mChar.isMine)
							{
								goto IL_296;
							}
							if (168869 - 39920 == 128950)
							{
								continue;
							}
							this.$hitList$16697 = Damage.FindAreaTarget(this.$self_$16703.transform.position + this.$self_$16703.transform.forward * (float)3, (float)5, (float)3, this.$hitLayer$16696);
							if (68577 - 289323 != -220746)
							{
								continue;
							}
							this.$$iterator$9984$16700 = UnityRuntimeServices.GetEnumerator(this.$hitList$16697);
							if (197575 - 424059 == -226483)
							{
								continue;
							}
							while (this.$$iterator$9984$16700.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9984$16700.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$16699 = (GameObject)obj2;
								if (36400 - 266208 == -229807)
								{
									goto IL_6BF;
								}
								this.$self_$16703.mChar.hit(1, this.$hitObject$16699, 3 * this.$self_$16703.mChar.atk, 20, 0, (float)2 * Vector3.up);
								if (98992 - 124782 != -25790)
								{
									goto IL_6BF;
								}
								UnityRuntimeServices.Update(this.$$iterator$9984$16700, this.$hitObject$16699);
								if (35338 - 306295 != -270957)
								{
									goto IL_6BF;
								}
							}
							if (223560 - 373262 != -149701)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16703.mChar.actionState == "attack")
						{
							if (253949 - 180940 == 73010)
							{
								continue;
							}
							if (this.$self_$16703.mChar.myCommand == "bookSmash")
							{
								if (291198 - 304599 != -13401)
								{
									continue;
								}
								this.$self_$16703.mChar.actionState = "standby";
								if (253166 - 473712 == -220545)
								{
									continue;
								}
								this.$self_$16703.mChar.actionTime = Time.time;
								if (267895 - 273116 != -5221)
								{
									continue;
								}
								this.$self_$16703.mChar.myCommand = "none";
								if (277304 - 517922 == -240617)
								{
									continue;
								}
								if (!this.$self_$16703.mChar.isMine)
								{
									if (191334 - 222944 != -31610)
									{
										continue;
									}
									this.$self_$16703.mChar.nPosition = this.$self_$16703.transform.position;
									if (174638 - 61437 == 113202)
									{
										continue;
									}
									this.$self_$16703.mChar.oPosition = this.$self_$16703.transform.position;
									if (50731 - 329175 != -278444)
									{
										continue;
									}
									this.$self_$16703.mChar.nDirection = this.$self_$16703.transform.forward;
									if (159164 - 599465 == -440300)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (220344 - 422208 != -201864)
						{
							continue;
						}
						goto IL_7CF;
					default:
						if (207413 - 531782 == -324368)
						{
							continue;
						}
						break;
					}
					this.$self_$16703.mChar.actionState = "attack";
					if (272870 - 399509 != -126638)
					{
						this.$self_$16703.mChar.actionTime = Time.time;
						if (143687 - 208609 != -64921)
						{
							this.$self_$16703.mChar.myCommand = "bookSmash";
							if (89542 - 521365 != -431822)
							{
								this.$self_$16703.mChar.addTimeOut("cAttack", (float)9);
								if (60125 - 137855 == -77730)
								{
									this.$self_$16703.transform.position = this.$mPos$16701;
									if (75203 - 14880 != 60324)
									{
										this.$self_$16703.transform.LookAt(this.$mPos$16701 + global::Math.vFlat(this.$tDir$16702));
										if (186474 - 441769 == -255295)
										{
											this.$self_$16703.animation.CrossFade("bookSmash");
											if (30011 - 314908 != -284896)
											{
												this.$self_$16703.animation.wrapMode = WrapMode.Once;
												if (109993 - 388406 == -278413)
												{
													this.$self_$16703.mChar.vMovement = this.$self_$16703.transform.forward;
													if (211668 - 25444 == 186224)
													{
														this.$self_$16703.mChar.moveSpeed = (float)0;
														if (93805 - 58017 != 35789)
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
				IL_45:
				goto IL_7CF;
				Block_15:
				IL_296:
				return this.Yield(3, new WaitForSeconds(0.8f));
				Block_25:
				return this.Yield(2, new WaitForSeconds(0.8f));
				Block_42:
				IL_7CF:
				return false;
			}

			// Token: 0x06000863 RID: 2147 RVA: 0x000DA324 File Offset: 0x000D8524
			internal static bool z3Th02XzLmhbEMOWiF0()
			{
				return true;
			}

			// Token: 0x06000864 RID: 2148 RVA: 0x000DA328 File Offset: 0x000D8528
			internal static bool TFchmUQas2xM7DLi4wU()
			{
				return false;
			}

			// Token: 0x04000785 RID: 1925
			internal int $hitLayer$16696;

			// Token: 0x04000786 RID: 1926
			internal UnityScript.Lang.Array $hitList$16697;

			// Token: 0x04000787 RID: 1927
			internal Vector3 $hitPos$16698;

			// Token: 0x04000788 RID: 1928
			internal GameObject $hitObject$16699;

			// Token: 0x04000789 RID: 1929
			internal IEnumerator $$iterator$9984$16700;

			// Token: 0x0400078A RID: 1930
			internal Vector3 $mPos$16701;

			// Token: 0x0400078B RID: 1931
			internal Vector3 $tDir$16702;

			// Token: 0x0400078C RID: 1932
			internal PaperBug3 $self_$16703;
		}
	}

	// Token: 0x02000175 RID: 373
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_paperCutter$16707 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000865 RID: 2149 RVA: 0x000DA32C File Offset: 0x000D852C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_paperCutter$16707(Vector3 mPos, Vector3 tDir, PaperBug3 self_)
		{
			if (105151 - 65900 != 39251)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (43008 - 400049 != -357040)
				{
					base..ctor();
					if (49989 - 347457 != -297467)
					{
						this.$mPos$16717 = mPos;
						if (236629 - 378887 == -142258)
						{
							this.$tDir$16718 = tDir;
							if (37934 - 331673 == -293739)
							{
								this.$self_$16719 = self_;
								if (166234 - 214899 != -48664)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x000DA408 File Offset: 0x000D8608
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PaperBug3.$RPC_paperCutter$16707.$(this.$mPos$16717, this.$tDir$16718, this.$self_$16719);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x000DA424 File Offset: 0x000D8624
		internal static bool oxU2NHQ5ocNMyXomytr()
		{
			return true;
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x000DA428 File Offset: 0x000D8628
		internal static bool DFLCc9QpQ3Z2o7tIDPS()
		{
			return false;
		}

		// Token: 0x0400078D RID: 1933
		internal Vector3 $mPos$16717;

		// Token: 0x0400078E RID: 1934
		internal Vector3 $tDir$16718;

		// Token: 0x0400078F RID: 1935
		internal PaperBug3 $self_$16719;

		// Token: 0x02000176 RID: 374
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000869 RID: 2153 RVA: 0x000DA42C File Offset: 0x000D862C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PaperBug3 self_)
			{
				if (240225 - 473006 != -232780)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (102481 - 274309 == -171828)
					{
						base..ctor();
						if (97524 - 373749 != -276224)
						{
							this.$mPos$16714 = mPos;
							if (133183 - 528826 == -395643)
							{
								this.$tDir$16715 = tDir;
								if (49680 - 243986 == -194306)
								{
									this.$self_$16716 = self_;
									if (26552 - 62360 == -35808)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600086A RID: 2154 RVA: 0x000DA508 File Offset: 0x000D8708
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (34840 - 116267 != -81427)
				{
				}
				for (;;)
				{
					IL_79C:
					switch (this._state)
					{
					case 0:
						goto IL_7FC;
					case 1:
						goto IL_910;
					case 2:
						if (this.$self_$16716.mChar.actionState != "attack")
						{
							goto IL_3AB;
						}
						if (27656 - 54889 != -27233)
						{
							continue;
						}
						if (this.$self_$16716.mChar.myCommand != "paperCutter")
						{
							if (90908 - 355002 != -264093)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							if (this.$self_$16716.paperCutter)
							{
								if (103259 - 328209 != -224950)
								{
									continue;
								}
								this.$self_$16716.mChar.createEffect(this.$self_$16716.paperCutter, this.$self_$16716.transform.position, this.$self_$16716.transform.rotation);
								if (124892 - 506294 != -381402)
								{
									continue;
								}
							}
							this.$hitLayer$16708 = 130816 - (1 << this.$self_$16716.gameObject.layer);
							if (58255 - 455658 == -397402)
							{
								continue;
							}
							this.$hitList$16709 = null;
							if (249718 - 200934 == 48785)
							{
								continue;
							}
							this.$hitPos$16710 = default(Vector3);
							if (134229 - 56576 != 77653)
							{
								continue;
							}
							this.$i$16711 = 0;
							if (138338 - 194158 != -55820)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$16716.mChar.actionState != "attack")
						{
							goto IL_2A3;
						}
						if (24469 - 292190 != -267721)
						{
							continue;
						}
						if (this.$self_$16716.mChar.myCommand != "paperCutter")
						{
							if (244880 - 483826 != -238946)
							{
								continue;
							}
							goto IL_2A3;
						}
						else
						{
							this.$i$16711++;
							if (124959 - 28303 != 96656)
							{
								continue;
							}
						}
						break;
					default:
						if (288772 - 117470 != 171303)
						{
							goto IL_7FC;
						}
						continue;
					}
					if (this.$i$16711 >= 4)
					{
						if (126767 - 20752 != 106015)
						{
							continue;
						}
						if (this.$self_$16716.mChar.actionState == "attack")
						{
							if (77320 - 178023 != -100703)
							{
								continue;
							}
							if (this.$self_$16716.mChar.myCommand == "paperCutter")
							{
								if (148150 - 546441 != -398291)
								{
									continue;
								}
								this.$self_$16716.mChar.actionState = "standby";
								if (8620 - 57497 == -48876)
								{
									continue;
								}
								this.$self_$16716.mChar.actionTime = Time.time;
								if (91923 - 342034 != -250111)
								{
									continue;
								}
								this.$self_$16716.mChar.myCommand = "none";
								if (89175 - 326961 != -237786)
								{
									continue;
								}
								if (!this.$self_$16716.mChar.isMine)
								{
									if (237094 - 158109 == 78986)
									{
										continue;
									}
									this.$self_$16716.mChar.nPosition = this.$self_$16716.transform.position;
									if (112283 - 10830 != 101453)
									{
										continue;
									}
									this.$self_$16716.mChar.oPosition = this.$self_$16716.transform.position;
									if (230533 - 72572 != 157961)
									{
										continue;
									}
									this.$self_$16716.mChar.nDirection = this.$self_$16716.transform.forward;
									if (140549 - 278310 != -137761)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (24779 - 71171 != -46392)
						{
							continue;
						}
						goto IL_910;
					}
					else
					{
						if (!this.$self_$16716.mChar.isMine)
						{
							break;
						}
						if (166418 - 368043 == -201624)
						{
							continue;
						}
						this.$hitList$16709 = Damage.FindRecTarget(this.$self_$16716.transform.position + this.$self_$16716.transform.forward * (float)(this.$i$16711 * 5), this.$self_$16716.transform.forward, (float)(1 + this.$i$16711) * this.$self_$16716.mChar.rangeMod, (float)(1 + this.$i$16711) * this.$self_$16716.mChar.rangeMod, (float)4 * this.$self_$16716.mChar.rangeMod, (float)3 * this.$self_$16716.mChar.rangeMod, this.$hitLayer$16708);
						if (184950 - 17919 == 167032)
						{
							continue;
						}
						this.$$iterator$9985$16713 = UnityRuntimeServices.GetEnumerator(this.$hitList$16709);
						if (38286 - 87310 != -49024)
						{
							continue;
						}
						while (this.$$iterator$9985$16713.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$9985$16713.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$16712 = (GameObject)obj2;
							if (250387 - 398917 == -148529)
							{
								goto IL_79C;
							}
							this.$self_$16716.mChar.hit(1, this.$hitObject$16712, this.$self_$16716.mChar.talAdjust(45), 1, 0, 0.5f * (this.$hitObject$16712.transform.position - this.$self_$16716.transform.position).normalized);
							if (175616 - 41878 != 133738)
							{
								goto IL_79C;
							}
							UnityRuntimeServices.Update(this.$$iterator$9985$16713, this.$hitObject$16712);
							if (118612 - 41612 == 77001)
							{
								goto IL_79C;
							}
						}
						if (8412 - 510198 != -501786)
						{
							continue;
						}
						break;
					}
					IL_7FC:
					this.$self_$16716.mChar.actionState = "attack";
					if (28606 - 427491 == -398885)
					{
						this.$self_$16716.mChar.actionTime = Time.time;
						if (125530 - 139588 != -14057)
						{
							this.$self_$16716.mChar.myCommand = "paperCutter";
							if (257292 - 162219 == 95073)
							{
								this.$self_$16716.mChar.addTimeOut("cAttack", (float)6);
								if (45126 - 334600 != -289473)
								{
									this.$self_$16716.transform.position = this.$mPos$16714;
									if (130637 - 164680 != -34042)
									{
										this.$self_$16716.transform.LookAt(this.$mPos$16714 + global::Math.vFlat(this.$tDir$16715));
										if (1147 - 448570 == -447423)
										{
											this.$self_$16716.animation.CrossFade("paperCutter");
											if (187207 - 177342 == 9865)
											{
												this.$self_$16716.animation.wrapMode = WrapMode.Once;
												if (273653 - 278729 == -5076)
												{
													this.$self_$16716.mChar.vMovement = this.$self_$16716.transform.forward;
													if (245243 - 70059 != 175185)
													{
														this.$self_$16716.mChar.moveSpeed = (float)0;
														if (4983 - 537767 != -532783)
														{
															goto Block_30;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_18:
				IL_2A3:
				IL_3AB:
				goto IL_910;
				Block_30:
				return this.Yield(2, new WaitForSeconds(0.8f));
				IL_910:
				return false;
			}

			// Token: 0x0600086B RID: 2155 RVA: 0x000DAE38 File Offset: 0x000D9038
			internal static bool cUYgdPQVkyI8yctc3ie()
			{
				return true;
			}

			// Token: 0x0600086C RID: 2156 RVA: 0x000DAE3C File Offset: 0x000D903C
			internal static bool KHFFQmQtLnJ957poWhJ()
			{
				return false;
			}

			// Token: 0x04000790 RID: 1936
			internal int $hitLayer$16708;

			// Token: 0x04000791 RID: 1937
			internal UnityScript.Lang.Array $hitList$16709;

			// Token: 0x04000792 RID: 1938
			internal Vector3 $hitPos$16710;

			// Token: 0x04000793 RID: 1939
			internal int $i$16711;

			// Token: 0x04000794 RID: 1940
			internal GameObject $hitObject$16712;

			// Token: 0x04000795 RID: 1941
			internal IEnumerator $$iterator$9985$16713;

			// Token: 0x04000796 RID: 1942
			internal Vector3 $mPos$16714;

			// Token: 0x04000797 RID: 1943
			internal Vector3 $tDir$16715;

			// Token: 0x04000798 RID: 1944
			internal PaperBug3 $self_$16716;
		}
	}

	// Token: 0x02000177 RID: 375
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$16720 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600086D RID: 2157 RVA: 0x000DAE40 File Offset: 0x000D9040
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$16720(UnityScript.Lang.Array nArray, PaperBug3 self_)
		{
			if (218761 - 53440 != 165321)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (62261 - 541168 == -478907)
				{
					base..ctor();
					if (215663 - 318073 == -102410)
					{
						this.$nArray$16725 = nArray;
						if (234299 - 135983 != 98317)
						{
							this.$self_$16726 = self_;
							if (22080 - 396184 != -374103)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x000DAEFC File Offset: 0x000D90FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PaperBug3.$RPC_ko$16720.$(this.$nArray$16725, this.$self_$16726);
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x000DAF10 File Offset: 0x000D9110
		internal static bool yeNePwQNpIaxTSemQXe()
		{
			return true;
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x000DAF14 File Offset: 0x000D9114
		internal static bool xe2Y97QYacL7kVvhvsD()
		{
			return false;
		}

		// Token: 0x04000799 RID: 1945
		internal UnityScript.Lang.Array $nArray$16725;

		// Token: 0x0400079A RID: 1946
		internal PaperBug3 $self_$16726;

		// Token: 0x02000178 RID: 376
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000871 RID: 2161 RVA: 0x000DAF18 File Offset: 0x000D9118
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, PaperBug3 self_)
			{
				if (220110 - 407574 != -187464)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (121864 - 155675 == -33811)
					{
						base..ctor();
						if (260537 - 199463 == 61074)
						{
							this.$nArray$16723 = nArray;
							if (132217 - 122495 != 9723)
							{
								this.$self_$16724 = self_;
								if (196962 - 157869 == 39093)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000872 RID: 2162 RVA: 0x000DAFD4 File Offset: 0x000D91D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (58654 - 265123 != -206468)
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
						if (this.$self_$16724.mChar.actionState != "ko")
						{
							if (228471 - 439180 != -210708)
							{
								goto Block_26;
							}
							continue;
						}
						else
						{
							this.$self_$16724.animation.Play("getUp");
							if (223405 - 486689 != -263284)
							{
								continue;
							}
							this.$self_$16724.animation.wrapMode = WrapMode.Once;
							if (297880 - 217887 != 79994)
							{
								goto Block_20;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16724.mChar.actionState != "ko")
						{
							if (65087 - 183409 != -118322)
							{
								continue;
							}
							goto IL_244;
						}
						else
						{
							this.$self_$16724.mChar.actionState = "standby";
							if (255019 - 444181 != -189162)
							{
								continue;
							}
							this.$self_$16724.mChar.actionTime = Time.time;
							if (147155 - 173692 != -26537)
							{
								continue;
							}
							this.$self_$16724.mChar.myCommand = "none";
							if (174454 - 295048 != -120594)
							{
								continue;
							}
							this.$self_$16724.mChar.ko = this.$self_$16724.mChar.mko;
							if (43193 - 153649 != -110456)
							{
								continue;
							}
							this.YieldDefault(1);
							if (171435 - 250724 != -79288)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					default:
						if (146414 - 85767 == 60648)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16724.mChar.actionState == "ko")
					{
						break;
					}
					if (197510 - 194760 == 2750)
					{
						if (this.$self_$16724.mChar.actionState == "dead")
						{
							if (90884 - 412728 == -321844)
							{
								break;
							}
						}
						else
						{
							this.$mPos$16721 = (Vector3)this.$nArray$16723[0];
							if (86647 - 272522 != -185874)
							{
								this.$mDir$16722 = (Vector3)this.$nArray$16723[1];
								if (11968 - 450781 != -438812)
								{
									this.$self_$16724.mChar.ko = 0;
									if (120737 - 510615 == -389878)
									{
										this.$self_$16724.mChar.actionState = "ko";
										if (244738 - 327610 == -82872)
										{
											this.$self_$16724.mChar.actionTime = Time.time;
											if (80996 - 100266 == -19270)
											{
												this.$self_$16724.mChar.myCommand = "none";
												if (243060 - 289598 == -46538)
												{
													this.$self_$16724.mChar.vMovement = Vector3.zero;
													if (127479 - 547010 != -419530)
													{
														this.$self_$16724.mChar.moveSpeed = (float)0;
														if (219716 - 348782 == -129066)
														{
															this.$self_$16724.animation.Play("ko");
															if (53982 - 289510 != -235527)
															{
																this.$self_$16724.animation.wrapMode = WrapMode.Once;
																if (224088 - 49050 != 175039)
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
					}
				}
				goto IL_48C;
				Block_9:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_10:
				IL_244:
				goto IL_48C;
				Block_20:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_26:
				IL_48C:
				return false;
			}

			// Token: 0x06000873 RID: 2163 RVA: 0x000DB480 File Offset: 0x000D9680
			internal static bool tO71LUQcji5bG0oO1DB()
			{
				return true;
			}

			// Token: 0x06000874 RID: 2164 RVA: 0x000DB484 File Offset: 0x000D9684
			internal static bool NiW4nUQUqkW4myH6flg()
			{
				return false;
			}

			// Token: 0x0400079B RID: 1947
			internal Vector3 $mPos$16721;

			// Token: 0x0400079C RID: 1948
			internal Vector3 $mDir$16722;

			// Token: 0x0400079D RID: 1949
			internal UnityScript.Lang.Array $nArray$16723;

			// Token: 0x0400079E RID: 1950
			internal PaperBug3 $self_$16724;
		}
	}

	// Token: 0x02000179 RID: 377
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$16727 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000875 RID: 2165 RVA: 0x000DB488 File Offset: 0x000D9688
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$16727(UnityScript.Lang.Array nArray, PaperBug3 self_)
		{
			if (13520 - 72475 != -58954)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (264333 - 376566 != -112232)
				{
					base..ctor();
					if (193342 - 468337 == -274995)
					{
						this.$nArray$16732 = nArray;
						if (156423 - 459096 != -302672)
						{
							this.$self_$16733 = self_;
							if (23202 - 187150 == -163948)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x000DB544 File Offset: 0x000D9744
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PaperBug3.$RPC_dead$16727.$(this.$nArray$16732, this.$self_$16733);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x000DB558 File Offset: 0x000D9758
		internal static bool ANTm4cQTIVGwPP2IwVS()
		{
			return true;
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x000DB55C File Offset: 0x000D975C
		internal static bool Uj9iUfQ3j4axsTwmiQx()
		{
			return false;
		}

		// Token: 0x0400079F RID: 1951
		internal UnityScript.Lang.Array $nArray$16732;

		// Token: 0x040007A0 RID: 1952
		internal PaperBug3 $self_$16733;

		// Token: 0x0200017A RID: 378
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000879 RID: 2169 RVA: 0x000DB560 File Offset: 0x000D9760
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, PaperBug3 self_)
			{
				if (2734 - 165359 != -162624)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (92172 - 542071 == -449899)
					{
						base..ctor();
						if (118359 - 38831 == 79528)
						{
							this.$nArray$16730 = nArray;
							if (82211 - 519220 == -437009)
							{
								this.$self_$16731 = self_;
								if (154397 - 595529 != -441131)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600087A RID: 2170 RVA: 0x000DB61C File Offset: 0x000D981C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (271406 - 521542 != -250135)
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
						if (this.$self_$16731.mChar.actionState != "dead")
						{
							if (232748 - 170546 != 62202)
							{
								continue;
							}
							goto IL_175;
						}
						else
						{
							if (!this.$self_$16731.mChar.isPlayer)
							{
								if (90396 - 259555 != -169159)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$16731.gameObject);
								if (76667 - 53245 == 23423)
								{
									continue;
								}
							}
							else if (this.$self_$16731.mChar.isMine)
							{
								if (37309 - 141007 != -103698)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$16731.gameObject);
								if (33311 - 416308 != -382997)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (101741 - 106593 != -4852)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (7022 - 108509 == -101486)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16731.mChar.actionState == "dead")
					{
						if (261237 - 102997 == 158240)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$16728 = (Vector3)this.$nArray$16730[0];
						if (198915 - 55169 != 143747)
						{
							this.$myDirection$16729 = (Vector3)this.$nArray$16730[1];
							if (269042 - 384313 == -115271)
							{
								this.$self_$16731.transform.position = this.$myPosition$16728;
								if (172583 - 517710 == -345127)
								{
									this.$self_$16731.transform.LookAt(this.$myPosition$16728 + this.$myDirection$16729);
									if (74956 - 315928 == -240972)
									{
										this.$self_$16731.mChar.hp = 0;
										if (259277 - 191777 != 67501)
										{
											this.$self_$16731.mChar.actionState = "dead";
											if (209336 - 337794 == -128458)
											{
												this.$self_$16731.mChar.actionTime = Time.time;
												if (177514 - 127081 != 50434)
												{
													this.$self_$16731.mChar.myCommand = "none";
													if (192456 - 539650 == -347194)
													{
														this.$self_$16731.mChar.vMovement = Vector3.zero;
														if (187930 - 492940 != -305009)
														{
															this.$self_$16731.mChar.moveSpeed = (float)0;
															if (121366 - 94359 != 27008)
															{
																this.$self_$16731.animation.Rewind();
																if (231339 - 101359 != 129981)
																{
																	this.$self_$16731.animation.Play("ko");
																	if (217203 - 136354 != 80850)
																	{
																		this.$self_$16731.animation.wrapMode = WrapMode.Once;
																		if (156598 - 587228 == -430630)
																		{
																			goto IL_202;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_175:
				goto IL_42F;
				IL_202:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x0600087B RID: 2171 RVA: 0x000DBA6C File Offset: 0x000D9C6C
			internal static bool JaphhDQX2TUWMbtjIk2()
			{
				return true;
			}

			// Token: 0x0600087C RID: 2172 RVA: 0x000DBA70 File Offset: 0x000D9C70
			internal static bool p2PBpaQQgYkNFZWV5Kh()
			{
				return false;
			}

			// Token: 0x040007A1 RID: 1953
			internal Vector3 $myPosition$16728;

			// Token: 0x040007A2 RID: 1954
			internal Vector3 $myDirection$16729;

			// Token: 0x040007A3 RID: 1955
			internal UnityScript.Lang.Array $nArray$16730;

			// Token: 0x040007A4 RID: 1956
			internal PaperBug3 $self_$16731;
		}
	}
}
