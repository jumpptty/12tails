using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000AFA RID: 2810
[Serializable]
public class RangerRobot : MonoBehaviour
{
	// Token: 0x06003E34 RID: 15924 RVA: 0x00801F48 File Offset: 0x00800148
	[MethodImpl(MethodImplOptions.NoInlining)]
	public RangerRobot()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003E35 RID: 15925 RVA: 0x00801F58 File Offset: 0x00800158
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (39433 - 572122 != -532688)
		{
		}
		for (;;)
		{
			this.MusycNskAQ = this.transform;
			if (246899 - 451282 == -204383)
			{
				this.aLCynQSVUV = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (181680 - 470831 == -289151)
				{
					this.aLCynQSVUV.actionState = "standby";
					if (134354 - 408957 != -274602)
					{
						this.aLCynQSVUV.actionTime = Time.time;
						if (58271 - 265883 != -207611)
						{
							this.aLCynQSVUV.myCommand = "none";
							if (160163 - 274953 != -114789)
							{
								if (this.aLCynQSVUV)
								{
									if (268838 - 37318 != 231520)
									{
										continue;
									}
									this.aLCynQSVUV.mImmuneList = new UnityScript.Lang.Array(new object[]
									{
										"powerBreak",
										"armorBreak",
										"burn",
										"paralysis",
										"needlePrison",
										"sticky",
										"petrify",
										"groundLock",
										"ice",
										"frost",
										"snowman",
										"lightBind",
										"sleep",
										"blind",
										"confuse",
										"mindControl"
									});
									if (158212 - 90144 != 68068)
									{
										continue;
									}
								}
								if (Game.mGameCode == 938)
								{
									if (62756 - 442239 != -379482)
									{
										this.StartCoroutine_Auto(this.RPC_summon(this.transform.position, this.transform.forward, 0));
										if (223312 - 528510 != -305197)
										{
											break;
										}
									}
								}
								else
								{
									if (Game.mGameType != 99)
									{
										break;
									}
									if (250849 - 45452 == 205397)
									{
										this.aLCynQSVUV.isMine = true;
										if (45431 - 316850 != -271418)
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

	// Token: 0x06003E36 RID: 15926 RVA: 0x00802204 File Offset: 0x00800404
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playLeftFootEvent(AnimationEvent animEvent)
	{
		if (56145 - 163547 != -107401)
		{
		}
		for (;;)
		{
			Vector3 vector = Camera.main.transform.position - this.transform.position;
			if (98285 - 124721 != -26435)
			{
				if (vector.sqrMagnitude >= (float)225)
				{
					break;
				}
				if (19934 - 425510 != -405575)
				{
					Camera.main.SendMessage("AddCamereShake", 0.1f);
					if (270406 - 530574 != -260167)
					{
						if (!this.footStep_left)
						{
							break;
						}
						if (113610 - 296982 != -183371)
						{
							this.audio.PlayOneShot(this.footStep_left);
							if (118021 - 342153 == -224132)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003E37 RID: 15927 RVA: 0x0080232C File Offset: 0x0080052C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playRightFootEvent(AnimationEvent animEvent)
	{
		if (217158 - 348277 != -131119)
		{
		}
		for (;;)
		{
			Vector3 vector = Camera.main.transform.position - this.transform.position;
			if (248478 - 49162 != 199317)
			{
				if (vector.sqrMagnitude >= (float)225)
				{
					break;
				}
				if (134791 - 527915 != -393123)
				{
					Camera.main.SendMessage("AddCamereShake", 0.1f);
					if (98857 - 26389 != 72469)
					{
						if (!this.footStep_right)
						{
							break;
						}
						if (181091 - 39537 != 141555)
						{
							this.audio.PlayOneShot(this.footStep_right);
							if (295865 - 93144 != 202722)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003E38 RID: 15928 RVA: 0x00802454 File Offset: 0x00800654
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (15574 - 322889 != -307314)
		{
		}
		for (;;)
		{
			if (this.aLCynQSVUV.isControlled)
			{
				if (231153 - 365076 == -133922)
				{
					continue;
				}
				if (!(this.aLCynQSVUV.actionState == "standby"))
				{
					if (187526 - 241045 == -53518)
					{
						continue;
					}
					if (!(this.aLCynQSVUV.actionState == "run"))
					{
						goto IL_332;
					}
					if (23217 - 366588 != -343371)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (83880 - 102680 == -18799)
				{
					continue;
				}
			}
			IL_332:
			if (this.aLCynQSVUV.hp <= 0)
			{
				if (143652 - 383066 != -239414)
				{
					continue;
				}
				if (this.aLCynQSVUV.actionState != "dead")
				{
					if (203910 - 298073 != -94163)
					{
						continue;
					}
					if (this.aLCynQSVUV.isMine)
					{
						if (2654 - 386203 == -383548)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (199312 - 428722 != -229410)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (122452 - 239887 == -117434)
						{
							continue;
						}
						this.aLCynQSVUV.DeadEvent();
						if (182088 - 1406 != 180682)
						{
							continue;
						}
						break;
					}
					else
					{
						this.aLCynQSVUV.hp = 1;
						if (282269 - 235339 != 46930)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.aLCynQSVUV.hp <= 0)
			{
				break;
			}
			if (148266 - 283862 == -135596)
			{
				if (this.aLCynQSVUV.ko > 0)
				{
					break;
				}
				if (216281 - 556061 != -339779)
				{
					if (!(this.aLCynQSVUV.actionState != "ko"))
					{
						break;
					}
					if (161306 - 176613 != -15306)
					{
						if (!(this.aLCynQSVUV.actionState != "dead"))
						{
							break;
						}
						if (13718 - 403828 == -390110)
						{
							if (this.aLCynQSVUV.isMine)
							{
								if (66356 - 347505 != -281148)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (69533 - 592401 != -522867)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (7981 - 339687 != -331705)
										{
											this.aLCynQSVUV.KoEvent();
											if (192542 - 524561 != -332018)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.aLCynQSVUV.ko = 1;
								if (159253 - 184415 != -25161)
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

	// Token: 0x06003E39 RID: 15929 RVA: 0x0080284C File Offset: 0x00800A4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (218208 - 74140 != 144069)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (162154 - 342968 != -180813)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (217343 - 476884 == -259541)
				{
					if (279130 - 556566 == -277436)
					{
						if (ActionName == "RPC_nAttack1")
						{
							if (34781 - 273081 != -238300)
							{
								continue;
							}
							v = 1;
							if (196087 - 473555 == -277467)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack2")
						{
							if (198742 - 340662 != -141920)
							{
								continue;
							}
							v = 2;
							if (56670 - 210151 == -153480)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (298662 - 39972 == 258691)
							{
								continue;
							}
							v = -1;
							if (52561 - 30832 == 21730)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_drillPunch")
						{
							if (165057 - 271456 == -106398)
							{
								continue;
							}
							v = 11;
							if (23264 - 201524 == -178259)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_clawPincer")
						{
							if (210560 - 264251 != -53691)
							{
								continue;
							}
							v = 21;
							if (183066 - 155741 != 27325)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_galaxyBlade")
						{
							if (178288 - 448761 != -270473)
							{
								continue;
							}
							v = 31;
							if (278709 - 248348 == 30362)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (87214 - 1580 == 85635)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (243656 - 543029 == -299373)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (49353 - 435040 == -385687)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (98971 - 343808 == -244837)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (283984 - 4369 == 279615)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (211379 - 553521 != -342141)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (146236 - 478653 != -332416)
											{
												Hashtable hashtable = new Hashtable();
												if (246479 - 528714 != -282234)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (176101 - 539148 == -363047)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (109401 - 539047 == -429646)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (190343 - 92063 != 98281)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (207721 - 290348 != -82626)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (214469 - 30937 != 183533)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (206566 - 65564 != 141003)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (253398 - 150614 == 102784)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (46651 - 77180 == -30529)
																				{
																					PhotonClient.SendEvent(this.aLCynQSVUV.ActorNr, 74, hashtable, true, true);
																					if (118728 - 139109 != -20380)
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

	// Token: 0x06003E3A RID: 15930 RVA: 0x00802DF8 File Offset: 0x00800FF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (30949 - 595121 != -564171)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (278616 - 415669 != -137052)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (16688 - 543618 != -526929)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (67981 - 507069 == -439088)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (156330 - 400087 == -243757)
						{
							int num3 = num;
							if (115768 - 491368 == -375600)
							{
								if (num3 == 1)
								{
									if (231402 - 545912 == -314510)
									{
										if (this.aLCynQSVUV.isMine)
										{
											break;
										}
										if (101723 - 90563 != 11161)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack1(vector, vector2, num2));
											if (233530 - 598386 == -364856)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (9730 - 570451 == -560721)
									{
										if (this.aLCynQSVUV.isMine)
										{
											break;
										}
										if (232566 - 383413 != -150846)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack2(vector, vector2, num2));
											if (56526 - 191725 != -135198)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (23501 - 465119 != -441617)
									{
										if (this.aLCynQSVUV.isMine)
										{
											break;
										}
										if (55180 - 177919 == -122739)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (173504 - 23164 != 150341)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (14878 - 557256 != -542377)
									{
										if (this.aLCynQSVUV.isMine)
										{
											break;
										}
										if (191150 - 149740 == 41410)
										{
											this.StartCoroutine_Auto(this.RPC_drillPunch(vector, vector2, num2));
											if (265638 - 399251 == -133613)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (253242 - 201832 == 51410)
									{
										if (this.aLCynQSVUV.isMine)
										{
											break;
										}
										if (7917 - 46197 != -38279)
										{
											this.StartCoroutine_Auto(this.RPC_clawPincer(vector, vector2, num2));
											if (162110 - 301903 == -139793)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (250279 - 569421 != -319141)
									{
										if (this.aLCynQSVUV.isMine)
										{
											break;
										}
										if (139627 - 113018 != 26610)
										{
											this.StartCoroutine_Auto(this.RPC_galaxyBlade(vector, vector2, num2));
											if (70865 - 288631 != -217765)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (72137 - 464049 == -391912)
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

	// Token: 0x06003E3B RID: 15931 RVA: 0x0080327C File Offset: 0x0080147C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (254127 - 353179 != -99051)
		{
		}
		for (;;)
		{
			float num = this.aLCynQSVUV.moveSpeed;
			if (92556 - 185546 != -92989)
			{
				float runSpeed = this.aLCynQSVUV.runSpeed;
				if (57784 - 387053 != -329268)
				{
					Vector3 a = default(Vector3);
					if (121614 - 104606 == 17008)
					{
						Vector3 vector = Vector3.zero;
						if (291142 - 391216 == -100074)
						{
							float num2 = (float)0;
							if (60863 - 178896 == -118033)
							{
								if (this.aLCynQSVUV.isMine)
								{
									if (70632 - 264209 != -193577)
									{
										continue;
									}
									if ((this.aLCynQSVUV.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (23988 - 15663 != 8325)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (285239 - 88373 != 196866)
										{
											continue;
										}
										a.y = (float)0;
										if (167171 - 151137 == 16035)
										{
											continue;
										}
										a = a.normalized;
										if (260106 - 249259 != 10847)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (188304 - 497812 != -309508)
										{
											continue;
										}
										vector = vector.normalized;
										if (173878 - 174470 == -591)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (285650 - 235993 != 49657)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (163643 - 268838 != -105195)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (112257 - 576897 != -464640)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (218484 - 443398 == -224913)
														{
															continue;
														}
														this.aLCynQSVUV.actionState = "run";
														if (73156 - 7098 == 66059)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (266633 - 427751 != -161118)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (138279 - 410034 != -271755)
														{
															continue;
														}
														this.animation.Play("run");
														if (234976 - 151534 == 83443)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (297987 - 106368 != 191620)
														{
															goto IL_113;
														}
														continue;
													}
												}
											}
										}
										this.aLCynQSVUV.actionState = "standby";
										if (111953 - 532546 == -420592)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (102977 - 179056 != -76079)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (189969 - 24865 == 165105)
											{
												continue;
											}
											num = (float)0;
											if (9840 - 265722 == -255881)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (18297 - 98702 != -80405)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (149843 - 357778 == -207934)
										{
											continue;
										}
									}
									IL_113:;
								}
								else
								{
									vector = global::Math.vFlat(this.aLCynQSVUV.nPosition - this.transform.position);
									if (49681 - 436413 == -386731)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (170940 - 343064 == -172123)
									{
										continue;
									}
									if (this.aLCynQSVUV.nSpeed != (float)0)
									{
										if (17319 - 251923 != -234604)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (217424 - 324961 == -107536)
											{
												continue;
											}
											this.transform.position = this.aLCynQSVUV.nPosition;
											if (72579 - 480989 == -408409)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (164232 - 473343 == -309110)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (221881 - 59409 != 162472)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (139411 - 298055 == -158643)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.aLCynQSVUV.nSpeed, (float)10 * Time.deltaTime);
												if (98906 - 351432 != -252526)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (9204 - 228303 != -219099)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (238814 - 56292 == 182523)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (248772 - 194250 == 54523)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (270300 - 281987 == -11686)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (490 - 390810 == -390319)
											{
												continue;
											}
										}
										else if (Time.time > this.aLCynQSVUV.nSpeed + 0.3f)
										{
											if (108854 - 12538 == 96317)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (220076 - 588508 == -368431)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (198251 - 262807 == -64555)
												{
													continue;
												}
												num = (float)0;
												if (256402 - 53676 == 202727)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.aLCynQSVUV.nDirection);
											if (267065 - 206604 == 60462)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (129447 - 393010 == -263562)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (31760 - 459790 != -428030)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (152668 - 173268 == -20599)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (70857 - 318789 != -247932)
											{
												continue;
											}
											this.transform.position = this.aLCynQSVUV.nPosition;
											if (263765 - 249178 != 14587)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (153040 - 466035 != -312995)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (281147 - 407195 == -126047)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (143869 - 506490 != -362621)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (299071 - 382728 != -83657)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (122327 - 146493 != -24166)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (215526 - 470499 != -254973)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (233050 - 82239 != 150811)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.aLCynQSVUV.nDirection);
											if (217290 - 324556 == -107265)
											{
												continue;
											}
											num = (float)0;
											if (187379 - 282742 == -95362)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (16453 - 442723 == -426269)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (130929 - 121716 != 9213)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (128366 - 482660 != -354294)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (118458 - 210263 != -91805)
										{
											continue;
										}
									}
								}
								this.aLCynQSVUV.vMovement = vector;
								if (18904 - 507384 == -488480)
								{
									this.aLCynQSVUV.moveSpeed = num;
									if (278883 - 565307 != -286423)
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

	// Token: 0x06003E3C RID: 15932 RVA: 0x00803DE0 File Offset: 0x00801FE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (136853 - 556806 != -419953)
		{
		}
		for (;;)
		{
			if (!this.aLCynQSVUV.isMine)
			{
				if (2682 - 131223 != -128540)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (221768 - 560064 != -338295)
				{
					Vector3 vector = a - this.transform.position;
					if (13719 - 207321 != -193601)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (297145 - 221735 != 75411)
						{
							CharacterControl characterControl = null;
							if (17270 - 266839 == -249569)
							{
								int tID = 0;
								if (230791 - 105615 == 125176)
								{
									if (gameObject)
									{
										if (119342 - 98085 != 21257)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (201984 - 290999 != -89015)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (125378 - 93723 != 31655)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (247811 - 193114 == 54698)
										{
											continue;
										}
									}
									if (!(this.aLCynQSVUV.actionState == "standby"))
									{
										if (176588 - 591557 != -414969)
										{
											continue;
										}
										if (!(this.aLCynQSVUV.actionState == "run"))
										{
											break;
										}
										if (91054 - 210552 != -119498)
										{
											continue;
										}
									}
									if (this.aLCynQSVUV.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (172325 - 166133 == 6192)
									{
										if (UnityEngine.Random.Range(0, 100) > 60)
										{
											if (16752 - 575446 == -558694)
											{
												this.StartCoroutine_Auto(this.RPC_nAttack1(this.transform.position, vector, tID));
												if (153692 - 487508 == -333816)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (195915 - 39879 != 156037)
													{
														this.ActionEvent("RPC_nAttack1", this.transform.position, vector, tID);
														if (64966 - 532593 == -467627)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											this.StartCoroutine_Auto(this.RPC_nAttack2(this.transform.position, vector, tID));
											if (233281 - 263536 == -30255)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (298698 - 415783 != -117084)
												{
													this.ActionEvent("RPC_nAttack2", this.transform.position, vector, tID);
													if (107708 - 432170 != -324461)
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

	// Token: 0x06003E3D RID: 15933 RVA: 0x00804194 File Offset: 0x00802394
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (157435 - 110524 != 46912)
		{
		}
		for (;;)
		{
			if (!this.aLCynQSVUV.isMine)
			{
				if (289891 - 418141 == -128250)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (169242 - 363063 == -193821)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (174030 - 222083 != -48052)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (177160 - 37155 == 140005)
						{
							CharacterControl characterControl = null;
							if (11957 - 578882 != -566924)
							{
								int tID = 0;
								if (15942 - 393004 != -377061)
								{
									if (gameObject)
									{
										if (187372 - 167011 != 20361)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (163419 - 124180 != 39239)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (208055 - 376191 == -168135)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (231775 - 89985 == 141791)
										{
											continue;
										}
									}
									if (!(this.aLCynQSVUV.actionState == "standby"))
									{
										if (67879 - 443023 != -375144)
										{
											continue;
										}
										if (!(this.aLCynQSVUV.actionState == "run"))
										{
											break;
										}
										if (139654 - 103786 != 35868)
										{
											continue;
										}
									}
									if (this.aLCynQSVUV.isTimeOut("galaxyBlade") == (float)0)
									{
										if (253206 - 485358 != -232152)
										{
											continue;
										}
										if (this.aLCynQSVUV.sp >= 80)
										{
											if (217183 - 557869 != -340686)
											{
												continue;
											}
											this.aLCynQSVUV.sp = this.aLCynQSVUV.sp - 80;
											if (275911 - 563803 != -287892)
											{
												continue;
											}
											this.StartCoroutine_Auto(this.RPC_galaxyBlade(this.transform.position, vector.normalized, tID));
											if (139512 - 45580 == 93933)
											{
												continue;
											}
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (284732 - 529966 != -245234)
											{
												continue;
											}
											this.ActionEvent("RPC_galaxyBlade", this.transform.position, vector.normalized, tID);
											if (259128 - 545361 != -286232)
											{
												break;
											}
											continue;
										}
									}
									if (this.aLCynQSVUV.sp >= 30)
									{
										if (40569 - 13257 == 27312)
										{
											if (vector.sqrMagnitude <= (float)100)
											{
												if (193140 - 269318 != -76177)
												{
													if (this.aLCynQSVUV.isTimeOut("drillPunch") != (float)0)
													{
														if (187627 - 309666 != -122038)
														{
															Camera.main.SendMessage("newGameMessage", "DrillPunch timeout!");
															if (118266 - 63286 == 54980)
															{
																break;
															}
														}
													}
													else
													{
														this.aLCynQSVUV.sp = this.aLCynQSVUV.sp - 30;
														if (128068 - 197927 != -69858)
														{
															this.StartCoroutine_Auto(this.RPC_drillPunch(this.transform.position, vector.normalized, tID));
															if (219891 - 371117 != -151225)
															{
																if (!PhotonClient.IsInitialized())
																{
																	break;
																}
																if (3488 - 358839 != -355350)
																{
																	this.ActionEvent("RPC_drillPunch", this.transform.position, vector.normalized, tID);
																	if (208492 - 231584 == -23092)
																	{
																		break;
																	}
																}
															}
														}
													}
												}
											}
											else if (this.aLCynQSVUV.isTimeOut("clawPincer") != (float)0)
											{
												if (196932 - 205204 != -8271)
												{
													Camera.main.SendMessage("newGameMessage", "ClawPincer timeout!");
													if (229121 - 35118 != 194004)
													{
														break;
													}
												}
											}
											else
											{
												this.aLCynQSVUV.sp = this.aLCynQSVUV.sp - 30;
												if (290296 - 55238 != 235059)
												{
													this.StartCoroutine_Auto(this.RPC_clawPincer(this.transform.position, vector.normalized, tID));
													if (76007 - 280075 == -204068)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (215174 - 54923 == 160251)
														{
															this.ActionEvent("RPC_clawPincer", this.transform.position, vector.normalized, tID);
															if (71293 - 240104 == -168811)
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
										Camera.main.SendMessage("newGameMessage", "Not enough sp.");
										if (19103 - 373852 != -354748)
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

	// Token: 0x06003E3E RID: 15934 RVA: 0x008047F0 File Offset: 0x008029F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003E3F RID: 15935 RVA: 0x008047F4 File Offset: 0x008029F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack1(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new RangerRobot.$RPC_nAttack1$30795(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003E40 RID: 15936 RVA: 0x00804804 File Offset: 0x00802A04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new RangerRobot.$RPC_nAttack2$30808(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003E41 RID: 15937 RVA: 0x00804814 File Offset: 0x00802A14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (211358 - 97911 != 113448)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (263547 - 327994 != -64447)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
				if (157165 - 151225 != 5940)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Missing nAttack_hit effect");
				if (129065 - 8720 == 120346)
				{
					continue;
				}
			}
			if (Time.time <= this.MRHyQFhiWa)
			{
				break;
			}
			if (237574 - 421703 != -184128)
			{
				this.MRHyQFhiWa = Time.time + 0.1f;
				if (155393 - 353994 != -198600)
				{
					if (!this.nAttack_hitFX)
					{
						break;
					}
					if (90525 - 64996 != 25530)
					{
						this.audio.PlayOneShot(this.nAttack_hitFX);
						if (29934 - 394709 == -364775)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003E42 RID: 15938 RVA: 0x00804978 File Offset: 0x00802B78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_drillPunch(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new RangerRobot.$RPC_drillPunch$30820(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003E43 RID: 15939 RVA: 0x00804988 File Offset: 0x00802B88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_clawPincer(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new RangerRobot.$RPC_clawPincer$30832(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003E44 RID: 15940 RVA: 0x00804998 File Offset: 0x00802B98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_galaxyBlade(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new RangerRobot.$RPC_galaxyBlade$30846(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003E45 RID: 15941 RVA: 0x008049A8 File Offset: 0x00802BA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_summon(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new RangerRobot.$RPC_summon$30857(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003E46 RID: 15942 RVA: 0x008049B8 File Offset: 0x00802BB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new RangerRobot.$RPC_ko$30864(nArray, this).GetEnumerator();
	}

	// Token: 0x06003E47 RID: 15943 RVA: 0x008049C8 File Offset: 0x00802BC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new RangerRobot.$RPC_dead$30871(nArray, this).GetEnumerator();
	}

	// Token: 0x06003E48 RID: 15944 RVA: 0x008049D8 File Offset: 0x00802BD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003E49 RID: 15945 RVA: 0x008049DC File Offset: 0x00802BDC
	internal static bool z0emFH5Odn9GNjogciOT()
	{
		return true;
	}

	// Token: 0x06003E4A RID: 15946 RVA: 0x008049E0 File Offset: 0x00802BE0
	internal static bool Bi8TgH5OJL5ZG5vf5OfW()
	{
		return false;
	}

	// Token: 0x04004B60 RID: 19296
	private Transform MusycNskAQ;

	// Token: 0x04004B61 RID: 19297
	private CharacterControl aLCynQSVUV;

	// Token: 0x04004B62 RID: 19298
	public AudioClip footStep_left;

	// Token: 0x04004B63 RID: 19299
	public AudioClip footStep_right;

	// Token: 0x04004B64 RID: 19300
	public GameObject nAttack1_ring;

	// Token: 0x04004B65 RID: 19301
	public GameObject nAttack2_ring;

	// Token: 0x04004B66 RID: 19302
	public GameObject nAttack_hit;

	// Token: 0x04004B67 RID: 19303
	public AudioClip nAttack_hitFX;

	// Token: 0x04004B68 RID: 19304
	private float MRHyQFhiWa;

	// Token: 0x04004B69 RID: 19305
	public GameObject drillPunch_ring;

	// Token: 0x04004B6A RID: 19306
	public GameObject clawPincer_ring;

	// Token: 0x04004B6B RID: 19307
	public GameObject clawPincer_hit;

	// Token: 0x04004B6C RID: 19308
	public GameObject galaxyBlade_ring;

	// Token: 0x04004B6D RID: 19309
	public GameObject summon_ring;

	// Token: 0x04004B6E RID: 19310
	public GameObject deadEffect;

	// Token: 0x02000AFB RID: 2811
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack1$30795 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003E4B RID: 15947 RVA: 0x008049E4 File Offset: 0x00802BE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack1$30795(Vector3 mPos, Vector3 tDir, RangerRobot self_)
		{
			if (160050 - 505225 != -345175)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (148225 - 251265 != -103039)
				{
					base..ctor();
					if (203713 - 116921 != 86793)
					{
						this.$mPos$30805 = mPos;
						if (10720 - 26013 == -15293)
						{
							this.$tDir$30806 = tDir;
							if (5841 - 144951 != -139109)
							{
								this.$self_$30807 = self_;
								if (82050 - 382737 == -300687)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003E4C RID: 15948 RVA: 0x00804AC0 File Offset: 0x00802CC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RangerRobot.$RPC_nAttack1$30795.$(this.$mPos$30805, this.$tDir$30806, this.$self_$30807);
		}

		// Token: 0x06003E4D RID: 15949 RVA: 0x00804ADC File Offset: 0x00802CDC
		internal static bool J6oJn85ODvJPHrQRiar5()
		{
			return true;
		}

		// Token: 0x06003E4E RID: 15950 RVA: 0x00804AE0 File Offset: 0x00802CE0
		internal static bool quh3fR5OvNiPOpcnJRv4()
		{
			return false;
		}

		// Token: 0x04004B6F RID: 19311
		internal Vector3 $mPos$30805;

		// Token: 0x04004B70 RID: 19312
		internal Vector3 $tDir$30806;

		// Token: 0x04004B71 RID: 19313
		internal RangerRobot $self_$30807;

		// Token: 0x02000AFC RID: 2812
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003E4F RID: 15951 RVA: 0x00804AE4 File Offset: 0x00802CE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, RangerRobot self_)
			{
				if (268343 - 156326 != 112017)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (219977 - 440949 == -220972)
					{
						base..ctor();
						if (71833 - 115462 != -43628)
						{
							this.$mPos$30802 = mPos;
							if (70200 - 235345 == -165145)
							{
								this.$tDir$30803 = tDir;
								if (115731 - 231482 != -115750)
								{
									this.$self_$30804 = self_;
									if (55725 - 156853 != -101127)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003E50 RID: 15952 RVA: 0x00804BC0 File Offset: 0x00802DC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (79823 - 242684 != -162861)
				{
				}
				for (;;)
				{
					IL_2E6:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_967;
					case 2:
						if (this.$self_$30804.aLCynQSVUV.actionState != "attack")
						{
							goto IL_4D5;
						}
						if (259444 - 443471 == -184026)
						{
							continue;
						}
						if (this.$self_$30804.aLCynQSVUV.myCommand != "nAttack1")
						{
							if (145964 - 306870 != -160905)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							this.$i$30796 = 0;
							if (235437 - 467440 != -232003)
							{
								continue;
							}
							goto IL_562;
						}
						break;
					case 3:
						if (this.$self_$30804.aLCynQSVUV.actionState != "attack")
						{
							goto IL_93A;
						}
						if (233993 - 430640 != -196647)
						{
							continue;
						}
						if (this.$self_$30804.aLCynQSVUV.myCommand != "nAttack1")
						{
							if (18612 - 406899 != -388287)
							{
								continue;
							}
							goto IL_93A;
						}
						else
						{
							this.$i$30796++;
							if (52698 - 107033 != -54335)
							{
								continue;
							}
							goto IL_562;
						}
						break;
					case 4:
						if (this.$self_$30804.aLCynQSVUV.actionState == "attack")
						{
							if (213357 - 9753 != 203604)
							{
								continue;
							}
							if (this.$self_$30804.aLCynQSVUV.myCommand == "nAttack1")
							{
								if (70129 - 19368 == 50762)
								{
									continue;
								}
								this.$self_$30804.aLCynQSVUV.actionState = "standby";
								if (51721 - 502896 == -451174)
								{
									continue;
								}
								this.$self_$30804.aLCynQSVUV.actionTime = Time.time;
								if (233518 - 597402 != -363884)
								{
									continue;
								}
								this.$self_$30804.aLCynQSVUV.myCommand = "none";
								if (153319 - 232417 != -79098)
								{
									continue;
								}
								if (!this.$self_$30804.aLCynQSVUV.isMine)
								{
									if (88619 - 226151 != -137532)
									{
										continue;
									}
									this.$self_$30804.aLCynQSVUV.nPosition = this.$self_$30804.transform.position;
									if (10560 - 431787 == -421226)
									{
										continue;
									}
									this.$self_$30804.aLCynQSVUV.oPosition = this.$self_$30804.transform.position;
									if (275854 - 588811 == -312956)
									{
										continue;
									}
									this.$self_$30804.aLCynQSVUV.nDirection = this.$self_$30804.transform.forward;
									if (221556 - 295193 != -73637)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (49065 - 547030 != -497964)
						{
							goto Block_45;
						}
						continue;
					default:
						if (226870 - 244720 == -17849)
						{
							continue;
						}
						break;
					}
					this.$self_$30804.aLCynQSVUV.actionState = "attack";
					if (243226 - 473799 == -230572)
					{
						continue;
					}
					this.$self_$30804.aLCynQSVUV.actionTime = Time.time;
					if (65715 - 361690 != -295975)
					{
						continue;
					}
					this.$self_$30804.aLCynQSVUV.myCommand = "nAttack1";
					if (76995 - 543451 == -466455)
					{
						continue;
					}
					this.$self_$30804.aLCynQSVUV.addTimeOut("nAttack", 1f);
					if (240735 - 42695 != 198040)
					{
						continue;
					}
					this.$self_$30804.transform.position = this.$mPos$30802;
					if (127570 - 475843 == -348272)
					{
						continue;
					}
					this.$self_$30804.transform.LookAt(this.$mPos$30802 + global::Math.vFlat(this.$tDir$30803));
					if (39476 - 409792 == -370315)
					{
						continue;
					}
					this.$self_$30804.animation.Rewind();
					if (168070 - 495428 == -327357)
					{
						continue;
					}
					this.$self_$30804.animation.CrossFade("nAttack1", 0.1f);
					if (6608 - 505080 != -498472)
					{
						continue;
					}
					this.$self_$30804.animation.wrapMode = WrapMode.Once;
					if (190928 - 437293 == -246364)
					{
						continue;
					}
					this.$self_$30804.aLCynQSVUV.vMovement = this.$self_$30804.transform.forward;
					if (133267 - 422687 == -289419)
					{
						continue;
					}
					this.$self_$30804.aLCynQSVUV.moveSpeed = (float)0;
					if (45490 - 345885 != -300395)
					{
						continue;
					}
					if (this.$self_$30804.nAttack1_ring)
					{
						if (261248 - 274387 != -13139)
						{
							continue;
						}
						this.$self_$30804.aLCynQSVUV.createEffect(this.$self_$30804.nAttack1_ring, this.$self_$30804.transform.position, this.$self_$30804.transform.rotation);
						if (208399 - 62507 != 145893)
						{
							goto Block_12;
						}
						continue;
					}
					else
					{
						Debug.LogError("Missing nAttack1 ring effect");
						if (68753 - 91070 != -22317)
						{
							continue;
						}
						goto IL_669;
					}
					IL_562:
					if (this.$i$30796 >= 2)
					{
						if (116428 - 334838 != -218409)
						{
							goto Block_34;
						}
					}
					else
					{
						if (!this.$self_$30804.aLCynQSVUV.isMine)
						{
							break;
						}
						if (145974 - 574022 != -428047)
						{
							this.$hitLayer$30797 = 130816 - (1 << this.$self_$30804.gameObject.layer);
							if (194891 - 223128 == -28237)
							{
								this.$hitList$30798 = Damage.FindAreaTarget(this.$mPos$30802 + this.$self_$30804.transform.TransformDirection(-0.5f, (float)0, (float)2), (float)3, (float)3, this.$hitLayer$30797);
								if (28359 - 473948 == -445589)
								{
									this.$$iterator$10649$30801 = UnityRuntimeServices.GetEnumerator(this.$hitList$30798);
									if (99643 - 500792 != -401148)
									{
										while (this.$$iterator$10649$30801.MoveNext())
										{
											object obj2;
											object obj = obj2 = this.$$iterator$10649$30801.Current;
											if (!(obj is GameObject))
											{
												obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
											}
											this.$hitObject$30799 = (GameObject)obj2;
											if (278625 - 311043 != -32418)
											{
												goto IL_2E6;
											}
											if (this.$self_$30804.aLCynQSVUV.hit(1, this.$hitObject$30799, this.$self_$30804.aLCynQSVUV.atk, 5, 0, Vector3.zero) != 0)
											{
												if (259521 - 85982 == 173540)
												{
													goto IL_2E6;
												}
												this.$hitPoint$30800 = this.$hitObject$30799.collider.ClosestPointOnBounds(this.$self_$30804.transform.position + (float)2 * Vector3.up);
												if (148646 - 21200 == 127447)
												{
													goto IL_2E6;
												}
												UnityRuntimeServices.Update(this.$$iterator$10649$30801, this.$hitObject$30799);
												if (293790 - 168247 == 125544)
												{
													goto IL_2E6;
												}
												this.$self_$30804.RPC_nAttack_hit(this.$hitPoint$30800, this.$self_$30804.transform.forward, 0);
												if (74030 - 221154 == -147123)
												{
													goto IL_2E6;
												}
												this.$self_$30804.ActionEvent("RPC_nAttack_hit", this.$hitPoint$30800, this.$self_$30804.transform.forward, 0);
												if (117418 - 139647 == -22228)
												{
													goto IL_2E6;
												}
											}
										}
										if (205059 - 208020 == -2961)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_5:
				goto IL_4D5;
				Block_12:
				goto IL_669;
				IL_4D5:
				goto IL_967;
				Block_34:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_669:
				return this.Yield(2, new WaitForSeconds(0.6f));
				Block_45:
				IL_93A:
				IL_967:
				return false;
			}

			// Token: 0x06003E51 RID: 15953 RVA: 0x00805548 File Offset: 0x00803748
			internal static bool DwLG6l5ORYmIeMQKQdPy()
			{
				return true;
			}

			// Token: 0x06003E52 RID: 15954 RVA: 0x0080554C File Offset: 0x0080374C
			internal static bool hgr2fW5Owu1TAWQccqXi()
			{
				return false;
			}

			// Token: 0x04004B72 RID: 19314
			internal int $i$30796;

			// Token: 0x04004B73 RID: 19315
			internal int $hitLayer$30797;

			// Token: 0x04004B74 RID: 19316
			internal UnityScript.Lang.Array $hitList$30798;

			// Token: 0x04004B75 RID: 19317
			internal GameObject $hitObject$30799;

			// Token: 0x04004B76 RID: 19318
			internal Vector3 $hitPoint$30800;

			// Token: 0x04004B77 RID: 19319
			internal IEnumerator $$iterator$10649$30801;

			// Token: 0x04004B78 RID: 19320
			internal Vector3 $mPos$30802;

			// Token: 0x04004B79 RID: 19321
			internal Vector3 $tDir$30803;

			// Token: 0x04004B7A RID: 19322
			internal RangerRobot $self_$30804;
		}
	}

	// Token: 0x02000AFD RID: 2813
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack2$30808 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003E53 RID: 15955 RVA: 0x00805550 File Offset: 0x00803750
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack2$30808(Vector3 mPos, Vector3 tDir, RangerRobot self_)
		{
			if (17693 - 178861 != -161168)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (221950 - 286172 != -64221)
				{
					base..ctor();
					if (9025 - 350554 == -341529)
					{
						this.$mPos$30817 = mPos;
						if (135673 - 544232 != -408558)
						{
							this.$tDir$30818 = tDir;
							if (237899 - 327935 == -90036)
							{
								this.$self_$30819 = self_;
								if (298548 - 135970 == 162578)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003E54 RID: 15956 RVA: 0x0080562C File Offset: 0x0080382C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RangerRobot.$RPC_nAttack2$30808.$(this.$mPos$30817, this.$tDir$30818, this.$self_$30819);
		}

		// Token: 0x06003E55 RID: 15957 RVA: 0x00805648 File Offset: 0x00803848
		internal static bool iAEdqP5OqKVVbf1Qblew()
		{
			return true;
		}

		// Token: 0x06003E56 RID: 15958 RVA: 0x0080564C File Offset: 0x0080384C
		internal static bool dP8VqY5O76MYfSDA2jNQ()
		{
			return false;
		}

		// Token: 0x04004B7B RID: 19323
		internal Vector3 $mPos$30817;

		// Token: 0x04004B7C RID: 19324
		internal Vector3 $tDir$30818;

		// Token: 0x04004B7D RID: 19325
		internal RangerRobot $self_$30819;

		// Token: 0x02000AFE RID: 2814
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003E57 RID: 15959 RVA: 0x00805650 File Offset: 0x00803850
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, RangerRobot self_)
			{
				if (264278 - 152091 != 112188)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (178557 - 218931 != -40373)
					{
						base..ctor();
						if (99453 - 146654 != -47200)
						{
							this.$mPos$30814 = mPos;
							if (84624 - 571640 != -487015)
							{
								this.$tDir$30815 = tDir;
								if (15342 - 563638 != -548295)
								{
									this.$self_$30816 = self_;
									if (84710 - 585378 != -500667)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003E58 RID: 15960 RVA: 0x0080572C File Offset: 0x0080392C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (285053 - 584998 != -299945)
				{
				}
				for (;;)
				{
					IL_5BE:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_86E;
					case 2:
						if (this.$self_$30816.aLCynQSVUV.actionState != "attack")
						{
							goto IL_379;
						}
						if (87308 - 64756 == 22553)
						{
							continue;
						}
						if (this.$self_$30816.aLCynQSVUV.myCommand != "nAttack2")
						{
							if (22668 - 221616 != -198948)
							{
								continue;
							}
							goto IL_379;
						}
						else
						{
							if (!this.$self_$30816.aLCynQSVUV.isMine)
							{
								goto IL_63C;
							}
							if (257962 - 263726 == -5763)
							{
								continue;
							}
							this.$hitLayer$30809 = 130816 - (1 << this.$self_$30816.gameObject.layer);
							if (103625 - 304345 == -200719)
							{
								continue;
							}
							this.$hitList$30810 = Damage.FindRecTarget(this.$mPos$30814, this.$self_$30816.transform.forward, (float)2, (float)2, (float)5, (float)4, this.$hitLayer$30809);
							if (49566 - 59357 != -9791)
							{
								continue;
							}
							this.$$iterator$10650$30813 = UnityRuntimeServices.GetEnumerator(this.$hitList$30810);
							if (206623 - 461079 == -254455)
							{
								continue;
							}
							while (this.$$iterator$10650$30813.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10650$30813.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$30811 = (GameObject)obj2;
								if (240666 - 562926 == -322259)
								{
									goto IL_5BE;
								}
								if (this.$self_$30816.aLCynQSVUV.hit(11, this.$hitObject$30811, 2 * this.$self_$30816.aLCynQSVUV.atk, 10, 0, (float)5 * this.$self_$30816.transform.forward) != 0)
								{
									if (183584 - 382912 != -199328)
									{
										goto IL_5BE;
									}
									this.$hitPoint$30812 = this.$hitObject$30811.collider.ClosestPointOnBounds(this.$self_$30816.transform.position + (float)4 * Vector3.up);
									if (164676 - 203819 == -39142)
									{
										goto IL_5BE;
									}
									UnityRuntimeServices.Update(this.$$iterator$10650$30813, this.$hitObject$30811);
									if (118798 - 510416 != -391618)
									{
										goto IL_5BE;
									}
									this.$self_$30816.RPC_nAttack_hit(this.$hitPoint$30812, this.$self_$30816.transform.forward, 0);
									if (97830 - 472500 == -374669)
									{
										goto IL_5BE;
									}
									this.$self_$30816.ActionEvent("RPC_nAttack_hit", this.$hitPoint$30812, this.$self_$30816.transform.forward, 0);
									if (121451 - 558363 == -436911)
									{
										goto IL_5BE;
									}
								}
							}
							if (14335 - 280133 != -265798)
							{
								continue;
							}
							goto IL_63C;
						}
						break;
					case 3:
						if (this.$self_$30816.aLCynQSVUV.actionState == "attack")
						{
							if (144540 - 399070 == -254529)
							{
								continue;
							}
							if (this.$self_$30816.aLCynQSVUV.myCommand == "nAttack2")
							{
								if (267726 - 88402 != 179324)
								{
									continue;
								}
								this.$self_$30816.aLCynQSVUV.actionState = "standby";
								if (149003 - 125309 != 23694)
								{
									continue;
								}
								this.$self_$30816.aLCynQSVUV.actionTime = Time.time;
								if (173506 - 507008 != -333502)
								{
									continue;
								}
								this.$self_$30816.aLCynQSVUV.myCommand = "none";
								if (94367 - 440782 == -346414)
								{
									continue;
								}
								if (!this.$self_$30816.aLCynQSVUV.isMine)
								{
									if (9170 - 258360 != -249190)
									{
										continue;
									}
									this.$self_$30816.aLCynQSVUV.nPosition = this.$self_$30816.transform.position;
									if (9542 - 347859 == -338316)
									{
										continue;
									}
									this.$self_$30816.aLCynQSVUV.oPosition = this.$self_$30816.transform.position;
									if (78782 - 258932 == -180149)
									{
										continue;
									}
									this.$self_$30816.aLCynQSVUV.nDirection = this.$self_$30816.transform.forward;
									if (166241 - 70174 != 96067)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (66252 - 198034 != -131782)
						{
							continue;
						}
						goto IL_86E;
					default:
						if (33308 - 56549 != -23241)
						{
							continue;
						}
						break;
					}
					this.$self_$30816.aLCynQSVUV.actionState = "attack";
					if (87941 - 122307 != -34365)
					{
						this.$self_$30816.aLCynQSVUV.actionTime = Time.time;
						if (81704 - 205278 != -123573)
						{
							this.$self_$30816.aLCynQSVUV.myCommand = "nAttack2";
							if (131180 - 559799 != -428618)
							{
								this.$self_$30816.aLCynQSVUV.addTimeOut("nAttack", 1f);
								if (128668 - 311878 != -183209)
								{
									this.$self_$30816.transform.position = this.$mPos$30814;
									if (237520 - 466899 == -229379)
									{
										this.$self_$30816.transform.LookAt(this.$mPos$30814 + global::Math.vFlat(this.$tDir$30815));
										if (174444 - 90721 == 83723)
										{
											this.$self_$30816.animation.Rewind();
											if (102030 - 80925 != 21106)
											{
												this.$self_$30816.animation.CrossFade("nAttack2", 0.1f);
												if (102348 - 315864 == -213516)
												{
													this.$self_$30816.animation.wrapMode = WrapMode.Once;
													if (184823 - 283909 == -99086)
													{
														this.$self_$30816.aLCynQSVUV.vMovement = this.$self_$30816.transform.forward;
														if (176343 - 413311 == -236968)
														{
															this.$self_$30816.aLCynQSVUV.moveSpeed = (float)0;
															if (177407 - 502243 == -324836)
															{
																if (this.$self_$30816.nAttack2_ring)
																{
																	if (189477 - 111372 == 78105)
																	{
																		this.$self_$30816.aLCynQSVUV.createEffect(this.$self_$30816.nAttack2_ring, this.$self_$30816.transform.position, this.$self_$30816.transform.rotation);
																		if (250349 - 575256 == -324907)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Missing nAttack2 ring effect");
																	if (195405 - 298204 == -102799)
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
				goto IL_56F;
				IL_379:
				goto IL_86E;
				IL_56F:
				return this.Yield(2, new WaitForSeconds(0.6f));
				IL_63C:
				return this.Yield(3, new WaitForSeconds(0.4f));
				IL_86E:
				return false;
			}

			// Token: 0x06003E59 RID: 15961 RVA: 0x00805FBC File Offset: 0x008041BC
			internal static bool QMlSu65OPk2FjPq5DgGU()
			{
				return true;
			}

			// Token: 0x06003E5A RID: 15962 RVA: 0x00805FC0 File Offset: 0x008041C0
			internal static bool JI1GZ85O0r1YCV4E1FZ0()
			{
				return false;
			}

			// Token: 0x04004B7E RID: 19326
			internal int $hitLayer$30809;

			// Token: 0x04004B7F RID: 19327
			internal UnityScript.Lang.Array $hitList$30810;

			// Token: 0x04004B80 RID: 19328
			internal GameObject $hitObject$30811;

			// Token: 0x04004B81 RID: 19329
			internal Vector3 $hitPoint$30812;

			// Token: 0x04004B82 RID: 19330
			internal IEnumerator $$iterator$10650$30813;

			// Token: 0x04004B83 RID: 19331
			internal Vector3 $mPos$30814;

			// Token: 0x04004B84 RID: 19332
			internal Vector3 $tDir$30815;

			// Token: 0x04004B85 RID: 19333
			internal RangerRobot $self_$30816;
		}
	}

	// Token: 0x02000AFF RID: 2815
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_drillPunch$30820 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003E5B RID: 15963 RVA: 0x00805FC4 File Offset: 0x008041C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_drillPunch$30820(Vector3 mPos, Vector3 tDir, RangerRobot self_)
		{
			if (241995 - 190075 != 51920)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (161615 - 154183 != 7433)
				{
					base..ctor();
					if (165046 - 185825 == -20779)
					{
						this.$mPos$30829 = mPos;
						if (104627 - 231914 != -127286)
						{
							this.$tDir$30830 = tDir;
							if (265168 - 585975 != -320806)
							{
								this.$self_$30831 = self_;
								if (260878 - 12487 != 248392)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003E5C RID: 15964 RVA: 0x008060A0 File Offset: 0x008042A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RangerRobot.$RPC_drillPunch$30820.$(this.$mPos$30829, this.$tDir$30830, this.$self_$30831);
		}

		// Token: 0x06003E5D RID: 15965 RVA: 0x008060BC File Offset: 0x008042BC
		internal static bool TJ18fi5ObvQckfq2uk7y()
		{
			return true;
		}

		// Token: 0x06003E5E RID: 15966 RVA: 0x008060C0 File Offset: 0x008042C0
		internal static bool VqcVXW5OujBZDUnk4pXB()
		{
			return false;
		}

		// Token: 0x04004B86 RID: 19334
		internal Vector3 $mPos$30829;

		// Token: 0x04004B87 RID: 19335
		internal Vector3 $tDir$30830;

		// Token: 0x04004B88 RID: 19336
		internal RangerRobot $self_$30831;

		// Token: 0x02000B00 RID: 2816
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003E5F RID: 15967 RVA: 0x008060C4 File Offset: 0x008042C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, RangerRobot self_)
			{
				if (207549 - 321275 != -113725)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (104579 - 128903 != -24323)
					{
						base..ctor();
						if (137080 - 454983 != -317902)
						{
							this.$mPos$30826 = mPos;
							if (156127 - 142524 != 13604)
							{
								this.$tDir$30827 = tDir;
								if (164845 - 517008 == -352163)
								{
									this.$self_$30828 = self_;
									if (39314 - 574568 == -535254)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003E60 RID: 15968 RVA: 0x008061A0 File Offset: 0x008043A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (26266 - 464941 != -438674)
				{
				}
				for (;;)
				{
					IL_754:
					switch (this._state)
					{
					case 0:
						goto IL_55D;
					case 1:
						goto IL_9A3;
					case 2:
						if (this.$self_$30828.aLCynQSVUV.actionState != "attack")
						{
							goto IL_698;
						}
						if (288837 - 490957 == -202119)
						{
							continue;
						}
						if (this.$self_$30828.aLCynQSVUV.myCommand != "drillPunch")
						{
							if (179764 - 388886 != -209121)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							this.$self_$30828.aLCynQSVUV.moveSpeed = (float)6;
							if (192722 - 29696 != 163026)
							{
								continue;
							}
							this.$i$30821 = 0;
							if (186429 - 366219 != -179790)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$30828.aLCynQSVUV.actionState != "attack")
						{
							goto IL_83D;
						}
						if (182448 - 272407 == -89958)
						{
							continue;
						}
						if (this.$self_$30828.aLCynQSVUV.myCommand != "drillPunch")
						{
							if (215912 - 378306 != -162394)
							{
								continue;
							}
							goto IL_83D;
						}
						else
						{
							if (this.$i$30821 == 4)
							{
								if (131258 - 146462 == -15203)
								{
									continue;
								}
								this.$self_$30828.aLCynQSVUV.moveSpeed = (float)4;
								if (272807 - 356124 != -83317)
								{
									continue;
								}
							}
							if (this.$i$30821 == 5)
							{
								if (236604 - 293164 == -56559)
								{
									continue;
								}
								this.$self_$30828.aLCynQSVUV.moveSpeed = (float)2;
								if (173335 - 232233 == -58897)
								{
									continue;
								}
							}
							if (this.$i$30821 == 6)
							{
								if (48863 - 572077 != -523214)
								{
									continue;
								}
								this.$self_$30828.aLCynQSVUV.moveSpeed = (float)0;
								if (174397 - 112220 == 62178)
								{
									continue;
								}
							}
							this.$i$30821++;
							if (66301 - 82035 == -15733)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$30828.aLCynQSVUV.actionState == "attack")
						{
							if (58033 - 279306 == -221272)
							{
								continue;
							}
							if (this.$self_$30828.aLCynQSVUV.myCommand == "drillPunch")
							{
								if (157862 - 362238 != -204376)
								{
									continue;
								}
								this.$self_$30828.aLCynQSVUV.actionState = "standby";
								if (233380 - 553545 != -320165)
								{
									continue;
								}
								this.$self_$30828.aLCynQSVUV.actionTime = Time.time;
								if (173822 - 239681 == -65858)
								{
									continue;
								}
								this.$self_$30828.aLCynQSVUV.myCommand = "none";
								if (162821 - 445939 != -283118)
								{
									continue;
								}
								if (!this.$self_$30828.aLCynQSVUV.isMine)
								{
									if (180558 - 352769 != -172211)
									{
										continue;
									}
									this.$self_$30828.aLCynQSVUV.nPosition = this.$self_$30828.transform.position;
									if (117359 - 231184 == -113824)
									{
										continue;
									}
									this.$self_$30828.aLCynQSVUV.oPosition = this.$self_$30828.transform.position;
									if (205223 - 539070 != -333847)
									{
										continue;
									}
									this.$self_$30828.aLCynQSVUV.nDirection = this.$self_$30828.transform.forward;
									if (116753 - 119500 != -2747)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (191952 - 471226 != -279274)
						{
							continue;
						}
						goto IL_9A3;
					default:
						if (239642 - 348621 != -108978)
						{
							goto IL_55D;
						}
						continue;
					}
					if (this.$i$30821 >= 7)
					{
						if (222799 - 58236 != 164564)
						{
							goto Block_60;
						}
						continue;
					}
					else
					{
						if (!this.$self_$30828.aLCynQSVUV.isMine)
						{
							goto IL_19D;
						}
						if (242145 - 525215 != -283070)
						{
							continue;
						}
						this.$hitLayer$30822 = 130816 - (1 << this.$self_$30828.gameObject.layer);
						if (9583 - 474586 == -465002)
						{
							continue;
						}
						this.$hitList$30823 = Damage.FindRecTarget(this.$mPos$30826, this.$self_$30828.transform.forward, (float)3, (float)3, (float)6, (float)3, this.$hitLayer$30822);
						if (54525 - 174463 != -119938)
						{
							continue;
						}
						this.$$iterator$10651$30825 = UnityRuntimeServices.GetEnumerator(this.$hitList$30823);
						if (212462 - 376661 == -164198)
						{
							continue;
						}
						while (this.$$iterator$10651$30825.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10651$30825.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$30824 = (GameObject)obj2;
							if (259041 - 2202 == 256840)
							{
								goto IL_754;
							}
							this.$self_$30828.aLCynQSVUV.hit(11, this.$hitObject$30824, 2 * this.$self_$30828.aLCynQSVUV.atk + this.$self_$30828.aLCynQSVUV.talAdjust(30), 10, 0, this.$self_$30828.transform.forward);
							if (74367 - 301050 == -226682)
							{
								goto IL_754;
							}
							UnityRuntimeServices.Update(this.$$iterator$10651$30825, this.$hitObject$30824);
							if (238023 - 212791 == 25233)
							{
								goto IL_754;
							}
						}
						if (42890 - 14542 != 28349)
						{
							goto Block_51;
						}
						continue;
					}
					IL_55D:
					this.$self_$30828.aLCynQSVUV.actionState = "attack";
					if (77297 - 287796 != -210498)
					{
						this.$self_$30828.aLCynQSVUV.actionTime = Time.time;
						if (247336 - 144364 != 102973)
						{
							this.$self_$30828.aLCynQSVUV.myCommand = "drillPunch";
							if (280415 - 154366 != 126050)
							{
								this.$self_$30828.aLCynQSVUV.addTimeOut("drillPunch", (float)10);
								if (196571 - 16632 == 179939)
								{
									this.$self_$30828.transform.position = this.$mPos$30826;
									if (282061 - 437606 == -155545)
									{
										this.$self_$30828.transform.LookAt(this.$mPos$30826 + global::Math.vFlat(this.$tDir$30827));
										if (299843 - 312677 != -12833)
										{
											this.$self_$30828.animation.CrossFade("drillPunch", 0.1f);
											if (90668 - 216023 == -125355)
											{
												this.$self_$30828.animation.wrapMode = WrapMode.Once;
												if (10954 - 418536 == -407582)
												{
													this.$self_$30828.aLCynQSVUV.vMovement = this.$self_$30828.transform.forward;
													if (32382 - 511466 == -479084)
													{
														this.$self_$30828.aLCynQSVUV.moveSpeed = (float)0;
														if (111492 - 197136 == -85644)
														{
															if (this.$self_$30828.drillPunch_ring)
															{
																if (167086 - 483311 != -316224)
																{
																	this.$self_$30828.aLCynQSVUV.createEffect(this.$self_$30828.drillPunch_ring, this.$self_$30828.transform.position, this.$self_$30828.transform.rotation);
																	if (127116 - 164499 != -37382)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing drillPunch ring effect");
																if (236709 - 257464 != -20754)
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
				IL_BB:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_19D:
				return this.Yield(3, new WaitForSeconds(0.1f));
				goto IL_BB;
				Block_29:
				goto IL_698;
				goto IL_BB;
				IL_698:
				goto IL_9A3;
				Block_51:
				goto IL_19D;
				IL_83D:
				goto IL_9A3;
				Block_60:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_9A3:
				return false;
			}

			// Token: 0x06003E61 RID: 15969 RVA: 0x00806B64 File Offset: 0x00804D64
			internal static bool WamMVU5OIKyPuhWwWFna()
			{
				return true;
			}

			// Token: 0x06003E62 RID: 15970 RVA: 0x00806B68 File Offset: 0x00804D68
			internal static bool YCGb6B5OBQFr64FcEoFC()
			{
				return false;
			}

			// Token: 0x04004B89 RID: 19337
			internal int $i$30821;

			// Token: 0x04004B8A RID: 19338
			internal int $hitLayer$30822;

			// Token: 0x04004B8B RID: 19339
			internal UnityScript.Lang.Array $hitList$30823;

			// Token: 0x04004B8C RID: 19340
			internal GameObject $hitObject$30824;

			// Token: 0x04004B8D RID: 19341
			internal IEnumerator $$iterator$10651$30825;

			// Token: 0x04004B8E RID: 19342
			internal Vector3 $mPos$30826;

			// Token: 0x04004B8F RID: 19343
			internal Vector3 $tDir$30827;

			// Token: 0x04004B90 RID: 19344
			internal RangerRobot $self_$30828;
		}
	}

	// Token: 0x02000B01 RID: 2817
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_clawPincer$30832 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003E63 RID: 15971 RVA: 0x00806B6C File Offset: 0x00804D6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_clawPincer$30832(Vector3 mPos, Vector3 tDir, RangerRobot self_)
		{
			if (26459 - 81427 != -54967)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (144678 - 485913 != -341234)
				{
					base..ctor();
					if (258871 - 29683 != 229189)
					{
						this.$mPos$30843 = mPos;
						if (87076 - 406739 != -319662)
						{
							this.$tDir$30844 = tDir;
							if (240249 - 581176 == -340927)
							{
								this.$self_$30845 = self_;
								if (267212 - 121248 != 145965)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003E64 RID: 15972 RVA: 0x00806C48 File Offset: 0x00804E48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RangerRobot.$RPC_clawPincer$30832.$(this.$mPos$30843, this.$tDir$30844, this.$self_$30845);
		}

		// Token: 0x06003E65 RID: 15973 RVA: 0x00806C64 File Offset: 0x00804E64
		internal static bool NJLdP75OeAefrZkQoEfK()
		{
			return true;
		}

		// Token: 0x06003E66 RID: 15974 RVA: 0x00806C68 File Offset: 0x00804E68
		internal static bool H0RRqn5OrZZCn4ABWUUW()
		{
			return false;
		}

		// Token: 0x04004B91 RID: 19345
		internal Vector3 $mPos$30843;

		// Token: 0x04004B92 RID: 19346
		internal Vector3 $tDir$30844;

		// Token: 0x04004B93 RID: 19347
		internal RangerRobot $self_$30845;

		// Token: 0x02000B02 RID: 2818
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003E67 RID: 15975 RVA: 0x00806C6C File Offset: 0x00804E6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, RangerRobot self_)
			{
				if (104184 - 43546 != 60638)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (87665 - 97802 == -10137)
					{
						base..ctor();
						if (267886 - 508160 == -240274)
						{
							this.$mPos$30840 = mPos;
							if (292258 - 509608 != -217349)
							{
								this.$tDir$30841 = tDir;
								if (155758 - 212702 == -56944)
								{
									this.$self_$30842 = self_;
									if (27709 - 519534 == -491825)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003E68 RID: 15976 RVA: 0x00806D48 File Offset: 0x00804F48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (14491 - 597095 != -582604)
				{
				}
				for (;;)
				{
					IL_32D:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_952;
					case 2:
						if (this.$self_$30842.aLCynQSVUV.actionState != "attack")
						{
							goto IL_4A5;
						}
						if (54391 - 248985 != -194594)
						{
							continue;
						}
						if (this.$self_$30842.aLCynQSVUV.myCommand != "clawPincer")
						{
							if (214182 - 473388 != -259206)
							{
								continue;
							}
							goto IL_4A5;
						}
						else
						{
							this.$hitLayer$30833 = 130816 - (1 << this.$self_$30842.gameObject.layer);
							if (114845 - 570400 == -455554)
							{
								continue;
							}
							this.$hitList$30834 = Damage.FindAreaTarget(this.$mPos$30840, (float)24, (float)3, this.$hitLayer$30833);
							if (86760 - 99210 != -12450)
							{
								continue;
							}
							this.$$iterator$10652$30839 = UnityRuntimeServices.GetEnumerator(this.$hitList$30834);
							if (219410 - 431437 == -212026)
							{
								continue;
							}
							while (this.$$iterator$10652$30839.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10652$30839.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$30835 = (GameObject)obj2;
								if (33707 - 297335 == -263627)
								{
									goto IL_32D;
								}
								this.$hitChar$30836 = (CharacterControl)this.$hitObject$30835.GetComponent(typeof(CharacterControl));
								if (187479 - 372806 == -185326)
								{
									goto IL_32D;
								}
								UnityRuntimeServices.Update(this.$$iterator$10652$30839, this.$hitObject$30835);
								if (48166 - 255941 == -207774)
								{
									goto IL_32D;
								}
								if (this.$hitChar$30836)
								{
									if (85288 - 414068 == -328779)
									{
										goto IL_32D;
									}
									if (this.$self_$30842.clawPincer_hit)
									{
										if (61194 - 151845 == -90650)
										{
											goto IL_32D;
										}
										this.$mClawPincer_hit$30837 = this.$hitChar$30836.createEffect(this.$self_$30842.clawPincer_hit, this.$hitObject$30835.collider.bounds.center, this.$hitObject$30835.transform.rotation);
										if (108735 - 395037 != -286302)
										{
											goto IL_32D;
										}
										UnityRuntimeServices.Update(this.$$iterator$10652$30839, this.$hitObject$30835);
										if (132073 - 227854 != -95781)
										{
											goto IL_32D;
										}
										this.$mClawPincer_BoltEmitter$30838 = (BoltEmitter)this.$mClawPincer_hit$30837.GetComponent(typeof(BoltEmitter));
										if (218206 - 197635 != 20571)
										{
											goto IL_32D;
										}
										if (this.$mClawPincer_BoltEmitter$30838)
										{
											if (224204 - 364518 != -140314)
											{
												goto IL_32D;
											}
											this.$mClawPincer_BoltEmitter$30838.TargetPosition = this.$self_$30842.transform.position + this.$self_$30842.transform.TransformDirection(0.8f, 3.8f, 3.5f);
											if (192315 - 320965 == -128649)
											{
												goto IL_32D;
											}
										}
									}
									if (this.$hitChar$30836.isMine)
									{
										if (76608 - 10455 == 66154)
										{
											goto IL_32D;
										}
										this.$hitChar$30836.RPC_AddEffectDamage(21, 500, 0, 0, Vector3.zero, this.$self_$30842.aLCynQSVUV.ActorNr);
										if (183838 - 90410 == 93429)
										{
											goto IL_32D;
										}
										this.$hitChar$30836.RPC_AddStatus("lock", 5, 6, 0, this.$self_$30842.aLCynQSVUV.ActorNr);
										if (210783 - 109813 != 100970)
										{
											goto IL_32D;
										}
									}
								}
							}
							if (281054 - 410118 != -129064)
							{
								continue;
							}
							goto IL_903;
						}
						break;
					case 3:
						if (this.$self_$30842.aLCynQSVUV.actionState == "attack")
						{
							if (257390 - 372694 == -115303)
							{
								continue;
							}
							if (this.$self_$30842.aLCynQSVUV.myCommand == "clawPincer")
							{
								if (272050 - 107666 != 164384)
								{
									continue;
								}
								this.$self_$30842.aLCynQSVUV.actionState = "standby";
								if (216922 - 233704 != -16782)
								{
									continue;
								}
								this.$self_$30842.aLCynQSVUV.actionTime = Time.time;
								if (119448 - 16722 != 102726)
								{
									continue;
								}
								this.$self_$30842.aLCynQSVUV.myCommand = "none";
								if (258813 - 505533 != -246720)
								{
									continue;
								}
								if (!this.$self_$30842.aLCynQSVUV.isMine)
								{
									if (98649 - 224754 != -126105)
									{
										continue;
									}
									this.$self_$30842.aLCynQSVUV.nPosition = this.$self_$30842.transform.position;
									if (86175 - 258117 == -171941)
									{
										continue;
									}
									this.$self_$30842.aLCynQSVUV.oPosition = this.$self_$30842.transform.position;
									if (141928 - 289573 == -147644)
									{
										continue;
									}
									this.$self_$30842.aLCynQSVUV.nDirection = this.$self_$30842.transform.forward;
									if (151424 - 65795 == 85630)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (115339 - 215357 != -100017)
						{
							goto Block_18;
						}
						continue;
					default:
						if (137337 - 352768 != -215431)
						{
							continue;
						}
						break;
					}
					this.$self_$30842.aLCynQSVUV.actionState = "attack";
					if (13911 - 566819 != -552907)
					{
						this.$self_$30842.aLCynQSVUV.actionTime = Time.time;
						if (158621 - 286467 != -127845)
						{
							this.$self_$30842.aLCynQSVUV.myCommand = "clawPincer";
							if (120790 - 137072 != -16281)
							{
								this.$self_$30842.aLCynQSVUV.addTimeOut("clawPincer", (float)24);
								if (88079 - 424009 == -335930)
								{
									this.$self_$30842.transform.position = this.$mPos$30840;
									if (195410 - 393598 != -198187)
									{
										this.$self_$30842.transform.LookAt(this.$mPos$30840 + global::Math.vFlat(this.$tDir$30841));
										if (270774 - 152722 != 118053)
										{
											this.$self_$30842.animation.CrossFade("clawPincer", 0.1f);
											if (164104 - 54543 == 109561)
											{
												this.$self_$30842.animation.wrapMode = WrapMode.Once;
												if (242036 - 25584 != 216453)
												{
													this.$self_$30842.aLCynQSVUV.vMovement = this.$self_$30842.transform.forward;
													if (298874 - 293756 != 5119)
													{
														this.$self_$30842.aLCynQSVUV.moveSpeed = (float)0;
														if (223573 - 41551 != 182023)
														{
															if (this.$self_$30842.clawPincer_ring)
															{
																if (294579 - 14634 == 279945)
																{
																	this.$self_$30842.aLCynQSVUV.createEffect(this.$self_$30842.clawPincer_ring, this.$self_$30842.transform.position, this.$self_$30842.transform.rotation);
																	if (31157 - 71775 == -40618)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing clawPincer ring effect");
																if (243390 - 242246 == 1144)
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
				goto IL_456;
				Block_18:
				goto IL_952;
				IL_456:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_4A5:
				goto IL_952;
				IL_903:
				return this.Yield(3, new WaitForSeconds(0.7f));
				IL_952:
				return false;
			}

			// Token: 0x06003E69 RID: 15977 RVA: 0x008076BC File Offset: 0x008058BC
			internal static bool MBYdtC5OjOshEot2YbNF()
			{
				return true;
			}

			// Token: 0x06003E6A RID: 15978 RVA: 0x008076C0 File Offset: 0x008058C0
			internal static bool nDpr465Oh7PtUBugoME4()
			{
				return false;
			}

			// Token: 0x04004B94 RID: 19348
			internal int $hitLayer$30833;

			// Token: 0x04004B95 RID: 19349
			internal UnityScript.Lang.Array $hitList$30834;

			// Token: 0x04004B96 RID: 19350
			internal GameObject $hitObject$30835;

			// Token: 0x04004B97 RID: 19351
			internal CharacterControl $hitChar$30836;

			// Token: 0x04004B98 RID: 19352
			internal GameObject $mClawPincer_hit$30837;

			// Token: 0x04004B99 RID: 19353
			internal BoltEmitter $mClawPincer_BoltEmitter$30838;

			// Token: 0x04004B9A RID: 19354
			internal IEnumerator $$iterator$10652$30839;

			// Token: 0x04004B9B RID: 19355
			internal Vector3 $mPos$30840;

			// Token: 0x04004B9C RID: 19356
			internal Vector3 $tDir$30841;

			// Token: 0x04004B9D RID: 19357
			internal RangerRobot $self_$30842;
		}
	}

	// Token: 0x02000B03 RID: 2819
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_galaxyBlade$30846 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003E6B RID: 15979 RVA: 0x008076C4 File Offset: 0x008058C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_galaxyBlade$30846(Vector3 mPos, Vector3 tDir, RangerRobot self_)
		{
			if (23826 - 106198 != -82371)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (290356 - 159573 == 130783)
				{
					base..ctor();
					if (172469 - 184991 != -12521)
					{
						this.$mPos$30854 = mPos;
						if (168632 - 282996 == -114364)
						{
							this.$tDir$30855 = tDir;
							if (103310 - 538722 != -435411)
							{
								this.$self_$30856 = self_;
								if (298557 - 533177 != -234619)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003E6C RID: 15980 RVA: 0x008077A0 File Offset: 0x008059A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RangerRobot.$RPC_galaxyBlade$30846.$(this.$mPos$30854, this.$tDir$30855, this.$self_$30856);
		}

		// Token: 0x06003E6D RID: 15981 RVA: 0x008077BC File Offset: 0x008059BC
		internal static bool IT8lnO5OsrlfVLHNiKjt()
		{
			return true;
		}

		// Token: 0x06003E6E RID: 15982 RVA: 0x008077C0 File Offset: 0x008059C0
		internal static bool N6bhEe5O9CHsBk1USeZo()
		{
			return false;
		}

		// Token: 0x04004B9E RID: 19358
		internal Vector3 $mPos$30854;

		// Token: 0x04004B9F RID: 19359
		internal Vector3 $tDir$30855;

		// Token: 0x04004BA0 RID: 19360
		internal RangerRobot $self_$30856;

		// Token: 0x02000B04 RID: 2820
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003E6F RID: 15983 RVA: 0x008077C4 File Offset: 0x008059C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, RangerRobot self_)
			{
				if (27702 - 402187 != -374485)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (136557 - 299570 != -163012)
					{
						base..ctor();
						if (286527 - 440112 != -153584)
						{
							this.$mPos$30851 = mPos;
							if (38183 - 492250 != -454066)
							{
								this.$tDir$30852 = tDir;
								if (132209 - 589955 != -457745)
								{
									this.$self_$30853 = self_;
									if (219738 - 166505 != 53234)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003E70 RID: 15984 RVA: 0x008078A0 File Offset: 0x00805AA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (266654 - 228267 != 38388)
				{
				}
				for (;;)
				{
					IL_668:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_78A;
					case 2:
						if (this.$self_$30853.aLCynQSVUV.actionState != "attack")
						{
							goto IL_133;
						}
						if (103967 - 361907 != -257940)
						{
							continue;
						}
						if (this.$self_$30853.aLCynQSVUV.myCommand != "galaxyBlade")
						{
							if (174389 - 30525 != 143864)
							{
								continue;
							}
							goto IL_133;
						}
						else
						{
							if (!this.$self_$30853.aLCynQSVUV.isMine)
							{
								goto IL_E4;
							}
							if (128569 - 317289 != -188720)
							{
								continue;
							}
							this.$hitLayer$30847 = 130816 - (1 << this.$self_$30853.gameObject.layer);
							if (52366 - 569854 != -517488)
							{
								continue;
							}
							this.$hitList$30848 = Damage.FindAngleTarget(this.$self_$30853.transform.position, this.$self_$30853.transform.forward, (float)50, (float)180, (float)6, this.$hitLayer$30847);
							if (16144 - 219877 == -203732)
							{
								continue;
							}
							this.$$iterator$10653$30850 = UnityRuntimeServices.GetEnumerator(this.$hitList$30848);
							if (119989 - 221099 != -101110)
							{
								continue;
							}
							while (this.$$iterator$10653$30850.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10653$30850.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$30849 = (GameObject)obj2;
								if (12180 - 182123 != -169943)
								{
									goto IL_668;
								}
								this.$self_$30853.aLCynQSVUV.hit(31, this.$hitObject$30849, this.$self_$30853.aLCynQSVUV.atk + this.$self_$30853.aLCynQSVUV.talAdjust(500), 100, 0, this.$self_$30853.transform.forward);
								if (6980 - 96679 != -89699)
								{
									goto IL_668;
								}
								UnityRuntimeServices.Update(this.$$iterator$10653$30850, this.$hitObject$30849);
								if (76949 - 533165 != -456216)
								{
									goto IL_668;
								}
							}
							if (143241 - 275339 != -132098)
							{
								continue;
							}
							goto IL_E4;
						}
						break;
					case 3:
						if (this.$self_$30853.aLCynQSVUV.actionState == "attack")
						{
							if (265512 - 162785 == 102728)
							{
								continue;
							}
							if (this.$self_$30853.aLCynQSVUV.myCommand == "galaxyBlade")
							{
								if (7736 - 273105 != -265369)
								{
									continue;
								}
								this.$self_$30853.aLCynQSVUV.actionState = "standby";
								if (197510 - 225400 != -27890)
								{
									continue;
								}
								this.$self_$30853.aLCynQSVUV.actionTime = Time.time;
								if (54064 - 490470 == -436405)
								{
									continue;
								}
								this.$self_$30853.aLCynQSVUV.myCommand = "none";
								if (198180 - 342864 != -144684)
								{
									continue;
								}
								if (!this.$self_$30853.aLCynQSVUV.isMine)
								{
									if (78364 - 5949 == 72416)
									{
										continue;
									}
									this.$self_$30853.aLCynQSVUV.nPosition = this.$self_$30853.transform.position;
									if (170862 - 88312 != 82550)
									{
										continue;
									}
									this.$self_$30853.aLCynQSVUV.oPosition = this.$self_$30853.transform.position;
									if (162355 - 267131 == -104775)
									{
										continue;
									}
									this.$self_$30853.aLCynQSVUV.nDirection = this.$self_$30853.transform.forward;
									if (249862 - 16587 == 233276)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (235432 - 392833 != -157401)
						{
							continue;
						}
						goto IL_78A;
					default:
						if (268714 - 215229 == 53486)
						{
							continue;
						}
						break;
					}
					this.$self_$30853.aLCynQSVUV.actionState = "attack";
					if (18490 - 314784 != -296293)
					{
						this.$self_$30853.aLCynQSVUV.actionTime = Time.time;
						if (265786 - 503294 != -237507)
						{
							this.$self_$30853.aLCynQSVUV.myCommand = "galaxyBlade";
							if (247287 - 222149 != 25139)
							{
								this.$self_$30853.aLCynQSVUV.addTimeOut("galaxyBlade", (float)60);
								if (138687 - 308939 != -170251)
								{
									this.$self_$30853.transform.position = this.$mPos$30851;
									if (202478 - 74322 == 128156)
									{
										this.$self_$30853.transform.LookAt(this.$mPos$30851 + global::Math.vFlat(this.$tDir$30852));
										if (269683 - 24952 != 244732)
										{
											this.$self_$30853.animation.CrossFade("galaxyBlade", 0.1f);
											if (50901 - 459957 == -409056)
											{
												this.$self_$30853.animation.wrapMode = WrapMode.Once;
												if (8801 - 188788 == -179987)
												{
													this.$self_$30853.aLCynQSVUV.vMovement = this.$self_$30853.transform.forward;
													if (171554 - 301847 != -130292)
													{
														this.$self_$30853.aLCynQSVUV.moveSpeed = (float)0;
														if (132278 - 467902 == -335624)
														{
															if (this.$self_$30853.galaxyBlade_ring)
															{
																if (82149 - 120917 != -38767)
																{
																	this.$self_$30853.aLCynQSVUV.createEffect(this.$self_$30853.galaxyBlade_ring, this.$self_$30853.transform.position, this.$self_$30853.transform.rotation);
																	if (234271 - 183950 == 50321)
																	{
																		goto IL_69D;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing galaxyBlade ring effect");
																if (213933 - 138623 == 75310)
																{
																	goto IL_445;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_E4:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_133:
				goto IL_78A;
				IL_445:
				return this.Yield(2, new WaitForSeconds(2.4f));
				IL_69D:
				goto IL_445;
				IL_78A:
				return false;
			}

			// Token: 0x06003E71 RID: 15985 RVA: 0x0080804C File Offset: 0x0080624C
			internal static bool WLb5HE5O1gQuWrnPARx9()
			{
				return true;
			}

			// Token: 0x06003E72 RID: 15986 RVA: 0x00808050 File Offset: 0x00806250
			internal static bool fc3BIC5O4kJtdN8jMpfg()
			{
				return false;
			}

			// Token: 0x04004BA1 RID: 19361
			internal int $hitLayer$30847;

			// Token: 0x04004BA2 RID: 19362
			internal UnityScript.Lang.Array $hitList$30848;

			// Token: 0x04004BA3 RID: 19363
			internal GameObject $hitObject$30849;

			// Token: 0x04004BA4 RID: 19364
			internal IEnumerator $$iterator$10653$30850;

			// Token: 0x04004BA5 RID: 19365
			internal Vector3 $mPos$30851;

			// Token: 0x04004BA6 RID: 19366
			internal Vector3 $tDir$30852;

			// Token: 0x04004BA7 RID: 19367
			internal RangerRobot $self_$30853;
		}
	}

	// Token: 0x02000B05 RID: 2821
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_summon$30857 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003E73 RID: 15987 RVA: 0x00808054 File Offset: 0x00806254
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_summon$30857(Vector3 mPos, Vector3 tDir, RangerRobot self_)
		{
			if (124382 - 430236 != -305854)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (153753 - 573855 == -420102)
				{
					base..ctor();
					if (251213 - 474625 == -223412)
					{
						this.$mPos$30861 = mPos;
						if (265489 - 466468 == -200979)
						{
							this.$tDir$30862 = tDir;
							if (266195 - 248017 != 18179)
							{
								this.$self_$30863 = self_;
								if (266816 - 140478 == 126338)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003E74 RID: 15988 RVA: 0x00808130 File Offset: 0x00806330
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RangerRobot.$RPC_summon$30857.$(this.$mPos$30861, this.$tDir$30862, this.$self_$30863);
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x0080814C File Offset: 0x0080634C
		internal static bool ad9cEs5Ozk49LDFUSyVR()
		{
			return true;
		}

		// Token: 0x06003E76 RID: 15990 RVA: 0x00808150 File Offset: 0x00806350
		internal static bool uhdb635maaLC1gxL0V0I()
		{
			return false;
		}

		// Token: 0x04004BA8 RID: 19368
		internal Vector3 $mPos$30861;

		// Token: 0x04004BA9 RID: 19369
		internal Vector3 $tDir$30862;

		// Token: 0x04004BAA RID: 19370
		internal RangerRobot $self_$30863;

		// Token: 0x02000B06 RID: 2822
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003E77 RID: 15991 RVA: 0x00808154 File Offset: 0x00806354
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, RangerRobot self_)
			{
				if (162088 - 33386 != 128702)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (272488 - 537854 != -265365)
					{
						base..ctor();
						if (285563 - 122152 != 163412)
						{
							this.$mPos$30858 = mPos;
							if (235658 - 177131 != 58528)
							{
								this.$tDir$30859 = tDir;
								if (70848 - 128191 == -57343)
								{
									this.$self_$30860 = self_;
									if (243556 - 215588 == 27968)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003E78 RID: 15992 RVA: 0x00808230 File Offset: 0x00806430
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (66626 - 382924 != -316297)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_50D;
					case 2:
						if (this.$self_$30860.aLCynQSVUV.actionState == "attack")
						{
							if (290618 - 271630 == 18989)
							{
								continue;
							}
							if (this.$self_$30860.aLCynQSVUV.myCommand == "summon")
							{
								if (16249 - 34595 == -18345)
								{
									continue;
								}
								this.$self_$30860.aLCynQSVUV.actionState = "standby";
								if (209338 - 191182 == 18157)
								{
									continue;
								}
								this.$self_$30860.aLCynQSVUV.actionTime = Time.time;
								if (64700 - 343087 == -278386)
								{
									continue;
								}
								this.$self_$30860.aLCynQSVUV.myCommand = "none";
								if (94589 - 504079 == -409489)
								{
									continue;
								}
								if (!this.$self_$30860.aLCynQSVUV.isMine)
								{
									if (66311 - 494618 == -428306)
									{
										continue;
									}
									this.$self_$30860.aLCynQSVUV.nPosition = this.$self_$30860.MusycNskAQ.position;
									if (272158 - 295691 != -23533)
									{
										continue;
									}
									this.$self_$30860.aLCynQSVUV.oPosition = this.$self_$30860.MusycNskAQ.position;
									if (37994 - 90551 != -52557)
									{
										continue;
									}
									this.$self_$30860.aLCynQSVUV.nDirection = this.$self_$30860.MusycNskAQ.forward;
									if (297746 - 449331 == -151584)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (284839 - 338981 != -54142)
						{
							continue;
						}
						goto IL_50D;
					default:
						if (23950 - 588988 == -565037)
						{
							continue;
						}
						break;
					}
					this.$self_$30860.aLCynQSVUV.actionState = "attack";
					if (261146 - 424383 != -163236)
					{
						this.$self_$30860.aLCynQSVUV.actionTime = Time.time;
						if (4618 - 72823 != -68204)
						{
							this.$self_$30860.aLCynQSVUV.myCommand = "summon";
							if (98878 - 492023 != -393144)
							{
								this.$self_$30860.aLCynQSVUV.addTimeOut("nAttack", (float)5);
								if (156200 - 496871 != -340670)
								{
									this.$self_$30860.MusycNskAQ.position = this.$mPos$30858;
									if (242964 - 56840 != 186125)
									{
										this.$self_$30860.MusycNskAQ.LookAt(this.$mPos$30858 + global::Math.vFlat(this.$tDir$30859));
										if (74952 - 201020 != -126067)
										{
											this.$self_$30860.animation.Play("summon");
											if (15037 - 372628 != -357590)
											{
												this.$self_$30860.animation.wrapMode = WrapMode.Once;
												if (169377 - 125397 == 43980)
												{
													if (this.$self_$30860.aLCynQSVUV)
													{
														if (159083 - 221836 == -62752)
														{
															continue;
														}
														this.$self_$30860.aLCynQSVUV.StartCoroutine_Auto(this.$self_$30860.aLCynQSVUV.addStatus("noDamage", 1, 3, 0, this.$self_$30860.aLCynQSVUV.ActorNr));
														if (1939 - 313689 == -311749)
														{
															continue;
														}
													}
													if (this.$self_$30860.summon_ring)
													{
														if (150685 - 444247 == -293562)
														{
															UnityEngine.Object.Instantiate(this.$self_$30860.summon_ring, this.$self_$30860.transform.position, this.$self_$30860.transform.rotation);
															if (6181 - 103124 == -96943)
															{
																break;
															}
														}
													}
													else
													{
														Debug.LogError("Missing summon_ring gameObject");
														if (244823 - 542246 == -297423)
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
				return this.Yield(2, new WaitForSeconds(2f));
				IL_50D:
				return false;
			}

			// Token: 0x06003E79 RID: 15993 RVA: 0x0080875C File Offset: 0x0080695C
			internal static bool xng8GY5m5iuJuFI2llx3()
			{
				return true;
			}

			// Token: 0x06003E7A RID: 15994 RVA: 0x00808760 File Offset: 0x00806960
			internal static bool pAA6Zr5mpAstZxvoWNuO()
			{
				return false;
			}

			// Token: 0x04004BAB RID: 19371
			internal Vector3 $mPos$30858;

			// Token: 0x04004BAC RID: 19372
			internal Vector3 $tDir$30859;

			// Token: 0x04004BAD RID: 19373
			internal RangerRobot $self_$30860;
		}
	}

	// Token: 0x02000B07 RID: 2823
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$30864 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003E7B RID: 15995 RVA: 0x00808764 File Offset: 0x00806964
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$30864(UnityScript.Lang.Array nArray, RangerRobot self_)
		{
			if (220512 - 71961 != 148552)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (291622 - 61987 == 229635)
				{
					base..ctor();
					if (181264 - 404430 == -223166)
					{
						this.$nArray$30869 = nArray;
						if (106489 - 409372 != -302882)
						{
							this.$self_$30870 = self_;
							if (57467 - 369067 != -311599)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003E7C RID: 15996 RVA: 0x00808820 File Offset: 0x00806A20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RangerRobot.$RPC_ko$30864.$(this.$nArray$30869, this.$self_$30870);
		}

		// Token: 0x06003E7D RID: 15997 RVA: 0x00808834 File Offset: 0x00806A34
		internal static bool yxJGfC5mVNUOlRG8AywP()
		{
			return true;
		}

		// Token: 0x06003E7E RID: 15998 RVA: 0x00808838 File Offset: 0x00806A38
		internal static bool wNr5Mp5mttOFyD5lVMGD()
		{
			return false;
		}

		// Token: 0x04004BAE RID: 19374
		internal UnityScript.Lang.Array $nArray$30869;

		// Token: 0x04004BAF RID: 19375
		internal RangerRobot $self_$30870;

		// Token: 0x02000B08 RID: 2824
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003E7F RID: 15999 RVA: 0x0080883C File Offset: 0x00806A3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, RangerRobot self_)
			{
				if (144748 - 507381 != -362632)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (256762 - 315852 != -59089)
					{
						base..ctor();
						if (144934 - 271892 == -126958)
						{
							this.$nArray$30867 = nArray;
							if (27966 - 17641 == 10325)
							{
								this.$self_$30868 = self_;
								if (124679 - 351860 != -227180)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003E80 RID: 16000 RVA: 0x008088F8 File Offset: 0x00806AF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (256314 - 331470 != -75156)
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
						if (this.$self_$30868.aLCynQSVUV.actionState != "ko")
						{
							if (256643 - 366865 != -110222)
							{
								continue;
							}
							goto IL_187;
						}
						else
						{
							this.$self_$30868.animation.Play("getUp");
							if (253726 - 17645 == 236082)
							{
								continue;
							}
							this.$self_$30868.animation.wrapMode = WrapMode.Once;
							if (201975 - 259819 != -57844)
							{
								continue;
							}
							goto IL_245;
						}
						break;
					case 3:
						if (this.$self_$30868.aLCynQSVUV.actionState != "ko")
						{
							if (53755 - 190275 != -136519)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$self_$30868.aLCynQSVUV.actionState = "standby";
							if (104458 - 328974 != -224516)
							{
								continue;
							}
							this.$self_$30868.aLCynQSVUV.actionTime = Time.time;
							if (21610 - 194015 != -172405)
							{
								continue;
							}
							this.$self_$30868.aLCynQSVUV.myCommand = "none";
							if (98049 - 464493 == -366443)
							{
								continue;
							}
							this.$self_$30868.aLCynQSVUV.ko = this.$self_$30868.aLCynQSVUV.mko;
							if (76110 - 176477 != -100367)
							{
								continue;
							}
							this.YieldDefault(1);
							if (216462 - 253811 != -37349)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (122100 - 280902 != -158802)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30868.aLCynQSVUV.actionState == "ko")
					{
						break;
					}
					if (75316 - 380204 == -304888)
					{
						if (this.$self_$30868.aLCynQSVUV.actionState == "dead")
						{
							if (270798 - 335993 != -65194)
							{
								break;
							}
						}
						else
						{
							this.$mPos$30865 = (Vector3)this.$nArray$30867[0];
							if (206368 - 566116 == -359748)
							{
								this.$mDir$30866 = (Vector3)this.$nArray$30867[1];
								if (232285 - 434823 == -202538)
								{
									this.$self_$30868.aLCynQSVUV.ko = 0;
									if (120759 - 69916 != 50844)
									{
										this.$self_$30868.aLCynQSVUV.actionState = "ko";
										if (120898 - 227275 == -106377)
										{
											this.$self_$30868.aLCynQSVUV.actionTime = Time.time;
											if (118621 - 199547 == -80926)
											{
												this.$self_$30868.aLCynQSVUV.myCommand = "none";
												if (103456 - 578642 == -475186)
												{
													this.$self_$30868.aLCynQSVUV.vMovement = Vector3.zero;
													if (112995 - 287260 == -174265)
													{
														this.$self_$30868.aLCynQSVUV.moveSpeed = (float)0;
														if (99123 - 203441 == -104318)
														{
															this.$self_$30868.animation.Play("ko");
															if (187121 - 237744 == -50623)
															{
																this.$self_$30868.animation.wrapMode = WrapMode.Once;
																if (198037 - 219909 != -21871)
																{
																	goto Block_28;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_187:
				goto IL_48C;
				IL_245:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_16:
				goto IL_48C;
				Block_28:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_48C:
				return false;
			}

			// Token: 0x06003E81 RID: 16001 RVA: 0x00808DA4 File Offset: 0x00806FA4
			internal static bool aQkTe75mNwsZ91Ucifc9()
			{
				return true;
			}

			// Token: 0x06003E82 RID: 16002 RVA: 0x00808DA8 File Offset: 0x00806FA8
			internal static bool p8R75f5mYPKqhBin7PSc()
			{
				return false;
			}

			// Token: 0x04004BB0 RID: 19376
			internal Vector3 $mPos$30865;

			// Token: 0x04004BB1 RID: 19377
			internal Vector3 $mDir$30866;

			// Token: 0x04004BB2 RID: 19378
			internal UnityScript.Lang.Array $nArray$30867;

			// Token: 0x04004BB3 RID: 19379
			internal RangerRobot $self_$30868;
		}
	}

	// Token: 0x02000B09 RID: 2825
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30871 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003E83 RID: 16003 RVA: 0x00808DAC File Offset: 0x00806FAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30871(UnityScript.Lang.Array nArray, RangerRobot self_)
		{
			if (159241 - 104768 != 54474)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (270004 - 280955 != -10950)
				{
					base..ctor();
					if (245960 - 30959 == 215001)
					{
						this.$nArray$30876 = nArray;
						if (117719 - 383128 == -265409)
						{
							this.$self_$30877 = self_;
							if (288144 - 120158 != 167987)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003E84 RID: 16004 RVA: 0x00808E68 File Offset: 0x00807068
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RangerRobot.$RPC_dead$30871.$(this.$nArray$30876, this.$self_$30877);
		}

		// Token: 0x06003E85 RID: 16005 RVA: 0x00808E7C File Offset: 0x0080707C
		internal static bool g697T95mcqSFuPOSyivi()
		{
			return true;
		}

		// Token: 0x06003E86 RID: 16006 RVA: 0x00808E80 File Offset: 0x00807080
		internal static bool RoT2fE5mUZyVsOvUuHGS()
		{
			return false;
		}

		// Token: 0x04004BB4 RID: 19380
		internal UnityScript.Lang.Array $nArray$30876;

		// Token: 0x04004BB5 RID: 19381
		internal RangerRobot $self_$30877;

		// Token: 0x02000B0A RID: 2826
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003E87 RID: 16007 RVA: 0x00808E84 File Offset: 0x00807084
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, RangerRobot self_)
			{
				if (175550 - 364178 != -188627)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (40924 - 514989 == -474065)
					{
						base..ctor();
						if (32130 - 207641 != -175510)
						{
							this.$nArray$30874 = nArray;
							if (37453 - 220251 != -182797)
							{
								this.$self_$30875 = self_;
								if (267045 - 190433 == 76612)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003E88 RID: 16008 RVA: 0x00808F40 File Offset: 0x00807140
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (153913 - 321488 != -167575)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4D2;
					case 2:
						if (this.$self_$30875.aLCynQSVUV.actionState != "dead")
						{
							if (4363 - 249986 != -245623)
							{
								continue;
							}
							goto IL_55;
						}
						else
						{
							if (this.$self_$30875.deadEffect)
							{
								if (19798 - 508334 != -488536)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$30875.deadEffect, this.$self_$30875.transform.position, this.$self_$30875.transform.rotation);
								if (42983 - 70084 != -27101)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing deadEffect effect");
								if (295357 - 426682 != -131325)
								{
									continue;
								}
							}
							if (!this.$self_$30875.aLCynQSVUV.isPlayer)
							{
								if (25016 - 389673 != -364657)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$30875.gameObject);
								if (212961 - 243142 == -30180)
								{
									continue;
								}
							}
							else if (this.$self_$30875.aLCynQSVUV.isMine)
							{
								if (145169 - 71787 != 73382)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30875.gameObject);
								if (246808 - 405235 != -158427)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (289532 - 461433 != -171901)
							{
								continue;
							}
							goto IL_4D2;
						}
						break;
					default:
						if (7187 - 119188 == -112000)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30875.aLCynQSVUV.actionState == "dead")
					{
						if (84325 - 189484 == -105159)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$30872 = (Vector3)this.$nArray$30874[0];
						if (241713 - 77307 == 164406)
						{
							this.$myDirection$30873 = (Vector3)this.$nArray$30874[1];
							if (109892 - 323687 == -213795)
							{
								this.$self_$30875.transform.position = this.$myPosition$30872;
								if (16792 - 226011 != -209218)
								{
									this.$self_$30875.transform.LookAt(this.$myPosition$30872 + this.$myDirection$30873);
									if (17113 - 380954 != -363840)
									{
										this.$self_$30875.aLCynQSVUV.hp = 0;
										if (98374 - 320804 == -222430)
										{
											this.$self_$30875.aLCynQSVUV.actionState = "dead";
											if (152566 - 157241 != -4674)
											{
												this.$self_$30875.aLCynQSVUV.actionTime = Time.time;
												if (252639 - 488988 == -236349)
												{
													this.$self_$30875.aLCynQSVUV.myCommand = "none";
													if (182650 - 593124 != -410473)
													{
														this.$self_$30875.aLCynQSVUV.vMovement = Vector3.zero;
														if (97921 - 104361 != -6439)
														{
															this.$self_$30875.aLCynQSVUV.moveSpeed = (float)0;
															if (148233 - 200830 != -52596)
															{
																this.$self_$30875.animation.Rewind();
																if (266197 - 255246 != 10952)
																{
																	this.$self_$30875.animation.Play("ko");
																	if (276641 - 121601 == 155040)
																	{
																		this.$self_$30875.animation.wrapMode = WrapMode.Once;
																		if (262018 - 435701 != -173682)
																		{
																			goto Block_10;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_55:
				goto IL_4D2;
				Block_10:
				return this.Yield(2, new WaitForSeconds(6f));
				IL_4D2:
				return false;
			}

			// Token: 0x06003E89 RID: 16009 RVA: 0x00809434 File Offset: 0x00807634
			internal static bool mWDrN75mTn7PYCcug97i()
			{
				return true;
			}

			// Token: 0x06003E8A RID: 16010 RVA: 0x00809438 File Offset: 0x00807638
			internal static bool HDZvbK5m3CB7IAfEmdvt()
			{
				return false;
			}

			// Token: 0x04004BB6 RID: 19382
			internal Vector3 $myPosition$30872;

			// Token: 0x04004BB7 RID: 19383
			internal Vector3 $myDirection$30873;

			// Token: 0x04004BB8 RID: 19384
			internal UnityScript.Lang.Array $nArray$30874;

			// Token: 0x04004BB9 RID: 19385
			internal RangerRobot $self_$30875;
		}
	}
}
