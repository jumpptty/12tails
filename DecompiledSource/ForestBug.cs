using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000070 RID: 112
[Serializable]
public class ForestBug : MonoBehaviour
{
	// Token: 0x06000256 RID: 598 RVA: 0x0003CED4 File Offset: 0x0003B0D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ForestBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000257 RID: 599 RVA: 0x0003CEE4 File Offset: 0x0003B0E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (174939 - 72690 != 102250)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (66203 - 553800 == -487597)
			{
				this.mChar.actionState = "standby";
				if (63482 - 592199 == -528717)
				{
					this.mChar.actionTime = Time.time;
					if (282220 - 359152 != -76931)
					{
						this.mChar.myCommand = "none";
						if (241529 - 379164 != -137634)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (265337 - 586961 == -321624)
							{
								this.mChar.isMine = true;
								if (252529 - 252039 != 491)
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

	// Token: 0x06000258 RID: 600 RVA: 0x0003D01C File Offset: 0x0003B21C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (231961 - 591255 != -359294)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (138296 - 123487 == 14810)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (248853 - 433995 != -185142)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_2BA;
					}
					if (11722 - 23329 == -11606)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (299207 - 568623 != -269416)
				{
					continue;
				}
			}
			IL_2BA:
			if (this.mChar.hp <= 0)
			{
				if (10611 - 229059 == -218447)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (152913 - 589239 == -436325)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (158465 - 527893 == -369427)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (20699 - 219405 == -198705)
						{
							continue;
						}
						if (status != null)
						{
							if (298699 - 378835 == -80135)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (78263 - 379962 == -301698)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (88421 - 185895 == -97473)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (147543 - 396362 == -248818)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (197894 - 561849 != -363954)
							{
								break;
							}
							continue;
						}
						else
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (276071 - 422118 != -146047)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (217917 - 578235 != -360318)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (108954 - 154603 != -45649)
							{
								continue;
							}
							break;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (48176 - 445386 != -397209)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.mChar.hp <= 0)
			{
				break;
			}
			if (118338 - 411645 != -293306)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (224205 - 14231 != 209975)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (102849 - 288385 == -185536)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (268893 - 404780 == -135887)
						{
							if (this.mChar.isMine)
							{
								if (118888 - 86424 == 32464)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (94307 - 395121 != -300813)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (257609 - 159729 != 97881)
										{
											this.mChar.KoEvent();
											if (87899 - 36575 != 51325)
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
								if (214453 - 568803 != -354349)
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

	// Token: 0x06000259 RID: 601 RVA: 0x0003D51C File Offset: 0x0003B71C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (151294 - 513854 != -362559)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (273964 - 444032 == -170068)
			{
				float runSpeed = this.mChar.runSpeed;
				if (128989 - 461267 == -332278)
				{
					Vector3 a = default(Vector3);
					if (30690 - 541019 == -510329)
					{
						Vector3 vector = Vector3.zero;
						if (217401 - 77995 != 139407)
						{
							float num2 = (float)0;
							if (26816 - 336341 != -309524)
							{
								if (this.mChar.isMine)
								{
									if (185953 - 360733 != -174780)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (155719 - 251383 == -95663)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (131566 - 599782 != -468216)
										{
											continue;
										}
										a.y = (float)0;
										if (101727 - 33216 != 68511)
										{
											continue;
										}
										a = a.normalized;
										if (241086 - 560066 != -318980)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (88922 - 203136 != -114214)
										{
											continue;
										}
										vector = vector.normalized;
										if (273134 - 396093 == -122958)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (119938 - 52565 != 67373)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (25939 - 427096 != -401157)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (197924 - 403420 != -205496)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (200493 - 95267 != 105226)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (67476 - 76617 != -9141)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (65959 - 383372 == -317412)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (147937 - 36002 == 111936)
														{
															continue;
														}
														this.animation.Play("run");
														if (8660 - 344024 == -335363)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (95984 - 169320 != -73335)
														{
															goto IL_5A2;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (12997 - 62620 != -49623)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (278349 - 218070 != 60279)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (2917 - 516496 != -513579)
											{
												continue;
											}
											num = (float)0;
											if (44633 - 484713 != -440080)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (79351 - 501994 != -422643)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (268442 - 44624 == 223819)
										{
											continue;
										}
									}
									IL_5A2:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (221550 - 473245 != -251695)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (89249 - 306966 != -217717)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (164835 - 315153 == -150317)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (155355 - 184201 != -28846)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (128034 - 243062 == -115027)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (281792 - 340405 != -58613)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (22074 - 187595 == -165520)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (253337 - 286139 == -32801)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (41211 - 336821 == -295609)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (160399 - 599984 == -439584)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (106282 - 105006 != 1276)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (118415 - 419259 == -300843)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (251197 - 492241 != -241044)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (76169 - 151898 == -75728)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (140038 - 474233 != -334195)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (144116 - 567652 != -423536)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (26248 - 436453 != -410205)
												{
													continue;
												}
												num = (float)0;
												if (267132 - 460621 != -193489)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (118518 - 58215 != 60303)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (275310 - 356962 != -81652)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (76111 - 523326 == -447214)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (287603 - 83549 == 204055)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (210363 - 90049 != 120314)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (3738 - 385694 == -381955)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (94299 - 500658 != -406359)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (694 - 340468 != -339774)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (27166 - 399392 != -372226)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (94449 - 120640 == -26190)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (130148 - 583550 != -453402)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (123498 - 294737 == -171238)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (73350 - 158323 == -84972)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (109121 - 523541 == -414419)
											{
												continue;
											}
											num = (float)0;
											if (47763 - 361888 != -314125)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (189766 - 359382 == -169615)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (236708 - 41348 == 195361)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (100717 - 267975 == -167257)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (203133 - 243794 == -40660)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (53655 - 134083 == -80428)
								{
									this.mChar.moveSpeed = num;
									if (242115 - 395476 != -153360)
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

	// Token: 0x0600025A RID: 602 RVA: 0x0003E080 File Offset: 0x0003C280
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (144189 - 336558 != -192369)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (15987 - 82321 != -66333)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (176230 - 447497 != -271266 && 268811 - 233488 != 35324)
				{
					if (ActionName == "RPC_forestBlast")
					{
						if (14993 - 597382 != -582389)
						{
							continue;
						}
						v = 1;
						if (47703 - 297404 == -249700)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_forestBlast_fire")
					{
						if (75954 - 483671 != -407717)
						{
							continue;
						}
						v = -1;
						if (40721 - 528321 != -487600)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (4202 - 523455 == -519253)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (66709 - 349531 != -282821)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (126187 - 123939 == 2248)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (240858 - 502134 == -261276)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (100258 - 513570 == -413312)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (268153 - 523397 == -255244)
										{
											Hashtable hashtable = new Hashtable();
											if (252123 - 386937 == -134814)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (293456 - 17982 == 275474)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (42636 - 327491 != -284854)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (110708 - 251048 == -140340)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (145945 - 542036 != -396090)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (132976 - 217151 != -84174)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (109910 - 535892 == -425982)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (47164 - 93450 == -46286)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (176115 - 161168 == 14947)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (168796 - 185516 == -16720)
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

	// Token: 0x0600025B RID: 603 RVA: 0x0003E4D4 File Offset: 0x0003C6D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (171005 - 188362 != -17357)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (39797 - 500191 == -460394)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (110805 - 490014 != -379208)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (4206 - 121442 != -117235)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (59529 - 314143 != -254613)
						{
							int num2 = num;
							if (123679 - 133512 != -9832)
							{
								if (num2 == 1)
								{
									if (240318 - 580606 == -340288)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (202207 - 568681 != -366473)
										{
											this.StartCoroutine_Auto(this.RPC_forestBlast(mPos, tDir, tID));
											if (76331 - 324016 == -247685)
											{
												break;
											}
										}
									}
								}
								else if (num2 == -1)
								{
									if (37086 - 173012 != -135925)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (51128 - 61392 != -10263)
										{
											this.StartCoroutine_Auto(this.RPC_forestBlast_fire(mPos, tDir, tID));
											if (26110 - 125203 == -99093)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (32858 - 124045 == -91187)
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

	// Token: 0x0600025C RID: 604 RVA: 0x0003E770 File Offset: 0x0003C970
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (165165 - 29692 != 135473)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (139056 - 293934 != -154877)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (8530 - 137730 != -129199)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (147354 - 167307 != -19952)
					{
						Vector3 normalized = vector.normalized;
						if (179917 - 50867 != 129051)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (231537 - 225681 != 5857)
							{
								CharacterControl characterControl = null;
								if (153629 - 540825 == -387196)
								{
									if (gameObject)
									{
										if (210632 - 577679 != -367047)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (79442 - 63735 == 15708)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (106726 - 175967 == -69240)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (168491 - 157351 != 11140)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (138174 - 468378 == -330204)
									{
										if (!characterControl)
										{
											if (152056 - 414627 == -262571)
											{
												Camera.main.SendMessage("newGameMessage", "No valid target selected");
												if (219910 - 114224 == 105686)
												{
													break;
												}
											}
										}
										else
										{
											this.StartCoroutine_Auto(this.RPC_forestBlast(this.transform.position, normalized, characterControl.ActorNr));
											if (133872 - 320342 == -186470)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (244820 - 162285 != 82536)
												{
													this.ActionEvent("RPC_forestBlast", this.transform.position, normalized, characterControl.ActorNr);
													if (44657 - 433886 == -389229)
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

	// Token: 0x0600025D RID: 605 RVA: 0x0003EA90 File Offset: 0x0003CC90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x0600025E RID: 606 RVA: 0x0003EAA8 File Offset: 0x0003CCA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600025F RID: 607 RVA: 0x0003EAAC File Offset: 0x0003CCAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_forestBlast(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ForestBug.$RPC_forestBlast$15616(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06000260 RID: 608 RVA: 0x0003EABC File Offset: 0x0003CCBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_forestBlast_fire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ForestBug.$RPC_forestBlast_fire$15626(mPos, this).GetEnumerator();
	}

	// Token: 0x06000261 RID: 609 RVA: 0x0003EACC File Offset: 0x0003CCCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new ForestBug.$RPC_ko$15636(nArray, this).GetEnumerator();
	}

	// Token: 0x06000262 RID: 610 RVA: 0x0003EADC File Offset: 0x0003CCDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new ForestBug.$RPC_dead$15643(nArray, this).GetEnumerator();
	}

	// Token: 0x06000263 RID: 611 RVA: 0x0003EAEC File Offset: 0x0003CCEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000264 RID: 612 RVA: 0x0003EAF0 File Offset: 0x0003CCF0
	internal static bool i96mDyViQtLHVF9yDM4()
	{
		return true;
	}

	// Token: 0x06000265 RID: 613 RVA: 0x0003EAF4 File Offset: 0x0003CCF4
	internal static bool ey0nDaVKyOTDWNinHsa()
	{
		return false;
	}

	// Token: 0x0400027B RID: 635
	public CharacterControl mChar;

	// Token: 0x0400027C RID: 636
	public GameObject forestBlast_ring;

	// Token: 0x0400027D RID: 637
	public GameObject forestBlast_fire;

	// Token: 0x02000071 RID: 113
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_forestBlast$15616 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000266 RID: 614 RVA: 0x0003EAF8 File Offset: 0x0003CCF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_forestBlast$15616(Vector3 mPos, Vector3 tDir, int tID, ForestBug self_)
		{
			if (20067 - 84969 != -64901)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (238580 - 90461 != 148120)
				{
					base..ctor();
					if (198802 - 505476 != -306673)
					{
						this.$mPos$15622 = mPos;
						if (282238 - 262645 != 19594)
						{
							this.$tDir$15623 = tDir;
							if (137417 - 136642 == 775)
							{
								this.$tID$15624 = tID;
								if (22606 - 294212 != -271605)
								{
									this.$self_$15625 = self_;
									if (283908 - 424315 != -140406)
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

		// Token: 0x06000267 RID: 615 RVA: 0x0003EBF8 File Offset: 0x0003CDF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ForestBug.$RPC_forestBlast$15616.$(this.$mPos$15622, this.$tDir$15623, this.$tID$15624, this.$self_$15625);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0003EC18 File Offset: 0x0003CE18
		internal static bool xkSvmIVdglXKvuxI0Vf()
		{
			return true;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0003EC1C File Offset: 0x0003CE1C
		internal static bool fQkN8VVJ17pTB1MxA7X()
		{
			return false;
		}

		// Token: 0x0400027E RID: 638
		internal Vector3 $mPos$15622;

		// Token: 0x0400027F RID: 639
		internal Vector3 $tDir$15623;

		// Token: 0x04000280 RID: 640
		internal int $tID$15624;

		// Token: 0x04000281 RID: 641
		internal ForestBug $self_$15625;

		// Token: 0x02000072 RID: 114
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600026A RID: 618 RVA: 0x0003EC20 File Offset: 0x0003CE20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, ForestBug self_)
			{
				if (215261 - 95409 != 119853)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (21227 - 78917 == -57690)
					{
						base..ctor();
						if (76864 - 434689 == -357825)
						{
							this.$mPos$15618 = mPos;
							if (265907 - 58685 == 207222)
							{
								this.$tDir$15619 = tDir;
								if (260077 - 295097 != -35019)
								{
									this.$tID$15620 = tID;
									if (170086 - 140599 != 29488)
									{
										this.$self_$15621 = self_;
										if (60643 - 304880 != -244236)
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

			// Token: 0x0600026B RID: 619 RVA: 0x0003ED20 File Offset: 0x0003CF20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (276685 - 295896 != -19210)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6DC;
					case 2:
					{
						if (!this.$self_$15621.mChar.isMine)
						{
							goto IL_523;
						}
						if (168879 - 370493 != -201614)
						{
							continue;
						}
						if (this.$tID$15620 == 0)
						{
							goto IL_523;
						}
						if (258100 - 408557 == -150456)
						{
							continue;
						}
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[this.$tID$15620];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						this.$tObject$15617 = (GameObject)obj2;
						if (39151 - 25768 != 13383)
						{
							continue;
						}
						if (!this.$tObject$15617)
						{
							goto IL_523;
						}
						if (117611 - 8895 == 108717)
						{
							continue;
						}
						this.$self_$15621.StartCoroutine_Auto(this.$self_$15621.RPC_forestBlast_fire(this.$tObject$15617.transform.position, this.$self_$15621.transform.forward, this.$tID$15620));
						if (34236 - 369104 != -334868)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							goto IL_523;
						}
						if (227279 - 237447 != -10168)
						{
							continue;
						}
						this.$self_$15621.ActionEvent("RPC_forestBlast_fire", this.$tObject$15617.transform.position, this.$self_$15621.transform.forward, this.$tID$15620);
						if (284676 - 442827 != -158150)
						{
							goto Block_10;
						}
						continue;
					}
					case 3:
						if (this.$self_$15621.mChar.actionState == "attack")
						{
							if (75593 - 506239 != -430646)
							{
								continue;
							}
							if (this.$self_$15621.mChar.myCommand == "cast")
							{
								if (259295 - 341690 != -82395)
								{
									continue;
								}
								this.$self_$15621.mChar.actionState = "standby";
								if (256268 - 57573 != 198695)
								{
									continue;
								}
								this.$self_$15621.mChar.actionTime = Time.time;
								if (211480 - 58637 != 152843)
								{
									continue;
								}
								this.$self_$15621.mChar.myCommand = "none";
								if (204688 - 412387 != -207699)
								{
									continue;
								}
								if (!this.$self_$15621.mChar.isMine)
								{
									if (250331 - 105689 != 144642)
									{
										continue;
									}
									this.$self_$15621.mChar.nPosition = this.$self_$15621.transform.position;
									if (69481 - 7092 == 62390)
									{
										continue;
									}
									this.$self_$15621.mChar.oPosition = this.$self_$15621.transform.position;
									if (157961 - 558023 != -400062)
									{
										continue;
									}
									this.$self_$15621.mChar.nDirection = this.$self_$15621.transform.forward;
									if (152202 - 223324 != -71122)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (200491 - 80994 != 119498)
						{
							goto Block_39;
						}
						continue;
					default:
						if (64588 - 28803 != 35785)
						{
							continue;
						}
						break;
					}
					this.$self_$15621.mChar.actionState = "attack";
					if (159299 - 219018 == -59719)
					{
						this.$self_$15621.mChar.actionTime = Time.time;
						if (54923 - 500390 != -445466)
						{
							this.$self_$15621.mChar.myCommand = "cast";
							if (250158 - 24511 != 225648)
							{
								this.$self_$15621.mChar.addTimeOut("nAttack", (float)6);
								if (144234 - 41375 == 102859)
								{
									this.$self_$15621.transform.position = this.$mPos$15618;
									if (60949 - 549753 == -488804)
									{
										this.$self_$15621.transform.LookAt(this.$mPos$15618 + global::Math.vFlat(this.$tDir$15619));
										if (132337 - 190221 == -57884)
										{
											this.$self_$15621.animation.Rewind();
											if (235838 - 497121 == -261283)
											{
												this.$self_$15621.animation.CrossFade("cast");
												if (209626 - 313391 == -103765)
												{
													this.$self_$15621.animation.wrapMode = WrapMode.Once;
													if (24669 - 401198 == -376529)
													{
														this.$self_$15621.mChar.vMovement = this.$self_$15621.transform.forward;
														if (71113 - 154501 == -83388)
														{
															this.$self_$15621.mChar.moveSpeed = (float)0;
															if (227305 - 323745 == -96440)
															{
																if (this.$self_$15621.forestBlast_ring)
																{
																	if (47388 - 199546 == -152158)
																	{
																		this.$self_$15621.mChar.createEffect(this.$self_$15621.forestBlast_ring, this.$self_$15621.transform.position, this.$self_$15621.transform.rotation);
																		if (57011 - 359782 == -302771)
																		{
																			goto IL_5DA;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Missing forestBlast_ring effect");
																	if (31359 - 59731 == -28372)
																	{
																		goto IL_4B3;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_10:
				goto IL_523;
				IL_4B3:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_523:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_5DA:
				goto IL_4B3;
				Block_39:
				IL_6DC:
				return false;
			}

			// Token: 0x0600026C RID: 620 RVA: 0x0003F41C File Offset: 0x0003D61C
			internal static bool gxrDomVDPSRR7bs6LYy()
			{
				return true;
			}

			// Token: 0x0600026D RID: 621 RVA: 0x0003F420 File Offset: 0x0003D620
			internal static bool Mj2UuFVviwyjntaDACv()
			{
				return false;
			}

			// Token: 0x04000282 RID: 642
			internal GameObject $tObject$15617;

			// Token: 0x04000283 RID: 643
			internal Vector3 $mPos$15618;

			// Token: 0x04000284 RID: 644
			internal Vector3 $tDir$15619;

			// Token: 0x04000285 RID: 645
			internal int $tID$15620;

			// Token: 0x04000286 RID: 646
			internal ForestBug $self_$15621;
		}
	}

	// Token: 0x02000073 RID: 115
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_forestBlast_fire$15626 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600026E RID: 622 RVA: 0x0003F424 File Offset: 0x0003D624
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_forestBlast_fire$15626(Vector3 mPos, ForestBug self_)
		{
			if (52155 - 544748 != -492593)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (153498 - 383632 != -230133)
				{
					base..ctor();
					if (32305 - 282997 != -250691)
					{
						this.$mPos$15634 = mPos;
						if (9309 - 355335 == -346026)
						{
							this.$self_$15635 = self_;
							if (72515 - 427535 != -355019)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0003F4E0 File Offset: 0x0003D6E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ForestBug.$RPC_forestBlast_fire$15626.$(this.$mPos$15634, this.$self_$15635);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0003F4F4 File Offset: 0x0003D6F4
		internal static bool PqIVXNVRdQxVDLg3I0F()
		{
			return true;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0003F4F8 File Offset: 0x0003D6F8
		internal static bool D6COAkVweqplOVmttnE()
		{
			return false;
		}

		// Token: 0x04000287 RID: 647
		internal Vector3 $mPos$15634;

		// Token: 0x04000288 RID: 648
		internal ForestBug $self_$15635;

		// Token: 0x02000074 RID: 116
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000272 RID: 626 RVA: 0x0003F4FC File Offset: 0x0003D6FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, ForestBug self_)
			{
				if (193689 - 555017 != -361328)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (27739 - 571276 != -543536)
					{
						base..ctor();
						if (151848 - 475178 != -323329)
						{
							this.$mPos$15632 = mPos;
							if (190792 - 443272 == -252480)
							{
								this.$self_$15633 = self_;
								if (22775 - 473439 == -450664)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000273 RID: 627 RVA: 0x0003F5B8 File Offset: 0x0003D7B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (95430 - 258460 != -163030)
				{
				}
				for (;;)
				{
					IL_92:
					switch (this._state)
					{
					case 0:
						goto IL_2BA;
					case 1:
						goto IL_360;
					case 2:
						if (this.$self_$15633.mChar.isMine)
						{
							if (42422 - 579094 != -536672)
							{
								continue;
							}
							this.$i$15627 = 0;
							if (290470 - 168987 != 121484)
							{
								goto IL_135;
							}
							continue;
						}
						break;
					case 3:
						this.$i$15627++;
						if (250588 - 208410 != 42178)
						{
							continue;
						}
						goto IL_135;
					default:
						if (290722 - 488095 != -197372)
						{
							goto IL_2BA;
						}
						continue;
					}
					IL_1A:
					this.YieldDefault(1);
					if (42632 - 374260 != -331627)
					{
						break;
					}
					continue;
					IL_2BA:
					if (this.$self_$15633.forestBlast_fire)
					{
						if (8480 - 200047 != -191567)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$15633.forestBlast_fire, this.$mPos$15632, Quaternion.identity);
						if (257274 - 132232 != 125042)
						{
							continue;
						}
						goto IL_C7;
					}
					else
					{
						Debug.LogError("Missing forestBlast_fire effect");
						if (73523 - 429848 != -356325)
						{
							continue;
						}
						goto IL_F0;
					}
					IL_135:
					if (this.$i$15627 >= 3)
					{
						if (51498 - 190977 == -139479)
						{
							goto IL_1A;
						}
					}
					else
					{
						this.$hitLayer$15628 = 130816 - (1 << this.$self_$15633.gameObject.layer);
						if (84429 - 186122 != -101692)
						{
							this.$hitList$15629 = Damage.FindAreaTarget(this.$mPos$15632, (float)2, (float)4, this.$hitLayer$15628);
							if (108603 - 178071 == -69468)
							{
								this.$$iterator$9904$15631 = UnityRuntimeServices.GetEnumerator(this.$hitList$15629);
								if (121379 - 216147 != -94767)
								{
									while (this.$$iterator$9904$15631.MoveNext())
									{
										object obj2;
										object obj = obj2 = this.$$iterator$9904$15631.Current;
										if (!(obj is GameObject))
										{
											obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
										}
										this.$hitObject$15630 = (GameObject)obj2;
										if (238479 - 118243 != 120236)
										{
											goto IL_92;
										}
										this.$self_$15633.mChar.hit(99, this.$hitObject$15630, this.$self_$15633.mChar.talAdjust(30), 2, 0, 0.5f * Vector3.up);
										if (177572 - 207880 != -30308)
										{
											goto IL_92;
										}
										UnityRuntimeServices.Update(this.$$iterator$9904$15631, this.$hitObject$15630);
										if (196409 - 27684 != 168725)
										{
											goto IL_92;
										}
									}
									if (160695 - 598080 == -437385)
									{
										goto IL_1F8;
									}
								}
							}
						}
					}
				}
				goto IL_360;
				IL_C7:
				IL_F0:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_1F8:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_360:
				return false;
			}

			// Token: 0x06000274 RID: 628 RVA: 0x0003F938 File Offset: 0x0003DB38
			internal static bool rPd8hVVqQ0qe3JOL1do()
			{
				return true;
			}

			// Token: 0x06000275 RID: 629 RVA: 0x0003F93C File Offset: 0x0003DB3C
			internal static bool rP7a67V7QXpxqVAuND0()
			{
				return false;
			}

			// Token: 0x04000289 RID: 649
			internal int $i$15627;

			// Token: 0x0400028A RID: 650
			internal int $hitLayer$15628;

			// Token: 0x0400028B RID: 651
			internal UnityScript.Lang.Array $hitList$15629;

			// Token: 0x0400028C RID: 652
			internal GameObject $hitObject$15630;

			// Token: 0x0400028D RID: 653
			internal IEnumerator $$iterator$9904$15631;

			// Token: 0x0400028E RID: 654
			internal Vector3 $mPos$15632;

			// Token: 0x0400028F RID: 655
			internal ForestBug $self_$15633;
		}
	}

	// Token: 0x02000075 RID: 117
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$15636 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000276 RID: 630 RVA: 0x0003F940 File Offset: 0x0003DB40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$15636(UnityScript.Lang.Array nArray, ForestBug self_)
		{
			if (65947 - 592636 != -526689)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (10582 - 7392 == 3190)
				{
					base..ctor();
					if (214392 - 305843 != -91450)
					{
						this.$nArray$15641 = nArray;
						if (150789 - 376776 == -225987)
						{
							this.$self_$15642 = self_;
							if (76901 - 387974 == -311073)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0003F9FC File Offset: 0x0003DBFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ForestBug.$RPC_ko$15636.$(this.$nArray$15641, this.$self_$15642);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0003FA10 File Offset: 0x0003DC10
		internal static bool sSe8XrVPeCRffWj4PxI()
		{
			return true;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0003FA14 File Offset: 0x0003DC14
		internal static bool eAwAT2V0wsKyQ5gHyLf()
		{
			return false;
		}

		// Token: 0x04000290 RID: 656
		internal UnityScript.Lang.Array $nArray$15641;

		// Token: 0x04000291 RID: 657
		internal ForestBug $self_$15642;

		// Token: 0x02000076 RID: 118
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600027A RID: 634 RVA: 0x0003FA18 File Offset: 0x0003DC18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, ForestBug self_)
			{
				if (128593 - 68490 != 60104)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (259652 - 256390 == 3262)
					{
						base..ctor();
						if (191681 - 563320 == -371639)
						{
							this.$nArray$15639 = nArray;
							if (1580 - 96913 == -95333)
							{
								this.$self_$15640 = self_;
								if (15871 - 467711 != -451839)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600027B RID: 635 RVA: 0x0003FAD4 File Offset: 0x0003DCD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (246195 - 594648 != -348453)
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
						if (this.$self_$15640.mChar.actionState != "ko")
						{
							if (56631 - 470336 != -413704)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							this.$self_$15640.animation.Play("getUp");
							if (17822 - 384798 == -366975)
							{
								continue;
							}
							this.$self_$15640.animation.wrapMode = WrapMode.Once;
							if (83451 - 532930 != -449478)
							{
								goto Block_8;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15640.mChar.actionState != "ko")
						{
							if (135206 - 317055 != -181848)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$self_$15640.mChar.actionState = "standby";
							if (207689 - 457007 == -249317)
							{
								continue;
							}
							this.$self_$15640.mChar.actionTime = Time.time;
							if (270177 - 308752 == -38574)
							{
								continue;
							}
							this.$self_$15640.mChar.myCommand = "none";
							if (109248 - 496119 != -386871)
							{
								continue;
							}
							this.$self_$15640.mChar.ko = this.$self_$15640.mChar.mko;
							if (93865 - 450116 != -356251)
							{
								continue;
							}
							this.YieldDefault(1);
							if (218552 - 82743 != 135810)
							{
								goto Block_3;
							}
							continue;
						}
						break;
					default:
						if (189581 - 457371 != -267790)
						{
							continue;
						}
						break;
					}
					if (this.$self_$15640.mChar.actionState == "ko")
					{
						break;
					}
					if (142009 - 557095 == -415086)
					{
						if (this.$self_$15640.mChar.actionState == "dead")
						{
							if (171053 - 361351 != -190297)
							{
								break;
							}
						}
						else
						{
							this.$mPos$15637 = (Vector3)this.$nArray$15639[0];
							if (261009 - 572993 == -311984)
							{
								this.$mDir$15638 = (Vector3)this.$nArray$15639[1];
								if (214820 - 439558 != -224737)
								{
									this.$self_$15640.mChar.ko = 0;
									if (82953 - 271369 == -188416)
									{
										this.$self_$15640.mChar.actionState = "ko";
										if (68704 - 130405 == -61701)
										{
											this.$self_$15640.mChar.actionTime = Time.time;
											if (155747 - 437915 != -282167)
											{
												this.$self_$15640.mChar.myCommand = "none";
												if (130714 - 488441 == -357727)
												{
													this.$self_$15640.mChar.vMovement = Vector3.zero;
													if (260386 - 544219 == -283833)
													{
														this.$self_$15640.mChar.moveSpeed = (float)0;
														if (32120 - 198544 != -166423)
														{
															this.$self_$15640.animation.Play("ko");
															if (43397 - 284704 != -241306)
															{
																this.$self_$15640.animation.wrapMode = WrapMode.Once;
																if (184042 - 585194 == -401152)
																{
																	goto IL_219;
																}
															}
														}
													}
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
				goto IL_48C;
				Block_8:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_219:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_15:
				Block_19:
				IL_48C:
				return false;
			}

			// Token: 0x0600027C RID: 636 RVA: 0x0003FF80 File Offset: 0x0003E180
			internal static bool Fw7o4cVbX7aUAy4aLux()
			{
				return true;
			}

			// Token: 0x0600027D RID: 637 RVA: 0x0003FF84 File Offset: 0x0003E184
			internal static bool G1sQYoVuI0tSNi1TEkH()
			{
				return false;
			}

			// Token: 0x04000292 RID: 658
			internal Vector3 $mPos$15637;

			// Token: 0x04000293 RID: 659
			internal Vector3 $mDir$15638;

			// Token: 0x04000294 RID: 660
			internal UnityScript.Lang.Array $nArray$15639;

			// Token: 0x04000295 RID: 661
			internal ForestBug $self_$15640;
		}
	}

	// Token: 0x02000077 RID: 119
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$15643 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600027E RID: 638 RVA: 0x0003FF88 File Offset: 0x0003E188
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$15643(UnityScript.Lang.Array nArray, ForestBug self_)
		{
			if (194654 - 549409 != -354754)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (22287 - 233477 == -211190)
				{
					base..ctor();
					if (282228 - 464035 == -181807)
					{
						this.$nArray$15648 = nArray;
						if (98069 - 37148 != 60922)
						{
							this.$self_$15649 = self_;
							if (283450 - 523223 != -239772)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00040044 File Offset: 0x0003E244
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ForestBug.$RPC_dead$15643.$(this.$nArray$15648, this.$self_$15649);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00040058 File Offset: 0x0003E258
		internal static bool YRcmIvVIVOE8GmaBIi4()
		{
			return true;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0004005C File Offset: 0x0003E25C
		internal static bool sWpYWLVBlhSPOJ3kJ6w()
		{
			return false;
		}

		// Token: 0x04000296 RID: 662
		internal UnityScript.Lang.Array $nArray$15648;

		// Token: 0x04000297 RID: 663
		internal ForestBug $self_$15649;

		// Token: 0x02000078 RID: 120
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000282 RID: 642 RVA: 0x00040060 File Offset: 0x0003E260
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, ForestBug self_)
			{
				if (73731 - 192206 != -118475)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (45419 - 185629 != -140209)
					{
						base..ctor();
						if (11841 - 83017 != -71175)
						{
							this.$nArray$15646 = nArray;
							if (130954 - 416345 == -285391)
							{
								this.$self_$15647 = self_;
								if (280229 - 293595 == -13366)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000283 RID: 643 RVA: 0x0004011C File Offset: 0x0003E31C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (143132 - 472065 != -328932)
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
						if (this.$self_$15647.mChar.actionState != "dead")
						{
							if (283972 - 215280 != 68693)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							if (!this.$self_$15647.mChar.isPlayer)
							{
								if (167878 - 548169 != -380291)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$15647.gameObject);
								if (70879 - 447120 == -376240)
								{
									continue;
								}
							}
							else if (this.$self_$15647.mChar.isMine)
							{
								if (251651 - 123432 == 128220)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$15647.gameObject);
								if (42874 - 5332 != 37542)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (22979 - 318074 != -295094)
							{
								goto Block_20;
							}
							continue;
						}
						break;
					default:
						if (188603 - 461260 != -272657)
						{
							continue;
						}
						break;
					}
					if (this.$self_$15647.mChar.actionState == "dead")
					{
						if (71853 - 48447 != 23407)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$15644 = (Vector3)this.$nArray$15646[0];
						if (270432 - 220594 == 49838)
						{
							this.$myDirection$15645 = (Vector3)this.$nArray$15646[1];
							if (54023 - 560045 != -506021)
							{
								this.$self_$15647.transform.position = this.$myPosition$15644;
								if (116984 - 300803 != -183818)
								{
									this.$self_$15647.transform.LookAt(this.$myPosition$15644 + this.$myDirection$15645);
									if (248305 - 103360 == 144945)
									{
										this.$self_$15647.mChar.hp = 0;
										if (52639 - 540320 != -487680)
										{
											this.$self_$15647.mChar.actionState = "dead";
											if (87908 - 149471 != -61562)
											{
												this.$self_$15647.mChar.actionTime = Time.time;
												if (7286 - 194489 == -187203)
												{
													this.$self_$15647.mChar.myCommand = "none";
													if (1917 - 437274 != -435356)
													{
														this.$self_$15647.mChar.vMovement = Vector3.zero;
														if (222567 - 401363 != -178795)
														{
															this.$self_$15647.mChar.moveSpeed = (float)0;
															if (279144 - 130015 == 149129)
															{
																this.$self_$15647.animation.Rewind();
																if (246776 - 380706 != -133929)
																{
																	this.$self_$15647.animation.Play("ko");
																	if (196688 - 517128 != -320439)
																	{
																		this.$self_$15647.animation.wrapMode = WrapMode.Once;
																		if (235016 - 501885 != -266868)
																		{
																			goto Block_14;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_42F;
				Block_14:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_20:
				Block_25:
				IL_42F:
				return false;
			}

			// Token: 0x06000284 RID: 644 RVA: 0x0004056C File Offset: 0x0003E76C
			internal static bool eQwZIKVe2pJxXwBX0In()
			{
				return true;
			}

			// Token: 0x06000285 RID: 645 RVA: 0x00040570 File Offset: 0x0003E770
			internal static bool IkNvtoVrNQx048lusRS()
			{
				return false;
			}

			// Token: 0x04000298 RID: 664
			internal Vector3 $myPosition$15644;

			// Token: 0x04000299 RID: 665
			internal Vector3 $myDirection$15645;

			// Token: 0x0400029A RID: 666
			internal UnityScript.Lang.Array $nArray$15646;

			// Token: 0x0400029B RID: 667
			internal ForestBug $self_$15647;
		}
	}
}
