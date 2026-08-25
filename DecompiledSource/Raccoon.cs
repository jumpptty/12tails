using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D86 RID: 3462
[Serializable]
public class Raccoon : MonoBehaviour
{
	// Token: 0x06004DFC RID: 19964 RVA: 0x009986A4 File Offset: 0x009968A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Raccoon()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004DFD RID: 19965 RVA: 0x009986B4 File Offset: 0x009968B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (187296 - 582347 != -395051)
		{
		}
		for (;;)
		{
			this.RS1cntEdHkK = this.transform;
			if (185010 - 371620 == -186610)
			{
				this.IwVcnXAfLMQ = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (102232 - 474848 == -372616)
				{
					this.IwVcnXAfLMQ.actionState = "standby";
					if (260471 - 259301 != 1171)
					{
						this.IwVcnXAfLMQ.actionTime = Time.time;
						if (34763 - 535464 != -500700)
						{
							this.IwVcnXAfLMQ.myCommand = "none";
							if (145744 - 115077 == 30667)
							{
								if (Game.mGameType != 99)
								{
									break;
								}
								if (195120 - 98081 != 97040)
								{
									this.IwVcnXAfLMQ.isMine = true;
									if (161150 - 96560 == 64590)
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

	// Token: 0x06004DFE RID: 19966 RVA: 0x00998814 File Offset: 0x00996A14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (119127 - 164739 != -45611)
		{
		}
		for (;;)
		{
			if (this.IwVcnXAfLMQ.isControlled)
			{
				if (104514 - 8873 == 95642)
				{
					continue;
				}
				if (!(this.IwVcnXAfLMQ.actionState == "standby"))
				{
					if (137759 - 192156 == -54396)
					{
						continue;
					}
					if (!(this.IwVcnXAfLMQ.actionState == "run"))
					{
						goto IL_D1;
					}
					if (39814 - 87502 == -47687)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (189961 - 183786 != 6175)
				{
					continue;
				}
			}
			IL_D1:
			if (this.IwVcnXAfLMQ.hp <= 0)
			{
				if (34082 - 265355 != -231273)
				{
					continue;
				}
				if (this.IwVcnXAfLMQ.actionState != "dead")
				{
					if (132345 - 465730 == -333384)
					{
						continue;
					}
					if (this.IwVcnXAfLMQ.isMine)
					{
						if (65355 - 148976 == -83620)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (8935 - 60410 == -51474)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (36864 - 543153 != -506289)
						{
							continue;
						}
						this.IwVcnXAfLMQ.DeadEvent();
						if (14361 - 433001 != -418640)
						{
							continue;
						}
						break;
					}
					else
					{
						this.IwVcnXAfLMQ.hp = 1;
						if (88242 - 186939 != -98697)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.IwVcnXAfLMQ.hp <= 0)
			{
				break;
			}
			if (190192 - 336130 != -145937)
			{
				if (this.IwVcnXAfLMQ.ko > 0)
				{
					break;
				}
				if (41651 - 532297 == -490646)
				{
					if (!(this.IwVcnXAfLMQ.actionState != "ko"))
					{
						break;
					}
					if (216355 - 457994 != -241638)
					{
						if (!(this.IwVcnXAfLMQ.actionState != "dead"))
						{
							break;
						}
						if (249033 - 337755 == -88722)
						{
							if (this.IwVcnXAfLMQ.isMine)
							{
								if (77462 - 309982 != -232519)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (219642 - 127413 == 92229)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (243421 - 56802 == 186619)
										{
											this.IwVcnXAfLMQ.KoEvent();
											if (193296 - 398085 == -204789)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.IwVcnXAfLMQ.ko = 1;
								if (41095 - 48905 != -7809)
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

	// Token: 0x06004DFF RID: 19967 RVA: 0x00998C0C File Offset: 0x00996E0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (7994 - 119077 != -111082)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (3492 - 351865 == -348373)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (3842 - 504208 == -500366)
				{
					if (85493 - 263441 != -177947)
					{
						if (ActionName == "RPC_cheer")
						{
							if (9268 - 557087 != -547819)
							{
								continue;
							}
							v = 1;
							if (119 - 157027 != -156908)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (256359 - 49012 == 207348)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (68272 - 574513 == -506241)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (284438 - 515453 == -231015)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (139512 - 152053 != -12540)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (135639 - 232925 == -97286)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (41440 - 389091 != -347650)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (261415 - 61908 == 199507)
											{
												Hashtable hashtable = new Hashtable();
												if (76003 - 17756 == 58247)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (196272 - 146093 != 50180)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (82529 - 5099 == 77430)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (162756 - 401166 == -238410)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (216059 - 90464 == 125595)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (262145 - 341197 == -79052)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (21386 - 209018 != -187631)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (287496 - 539227 != -251730)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (92200 - 74950 == 17250)
																				{
																					PhotonClient.SendEvent(this.IwVcnXAfLMQ.ActorNr, 74, hashtable, true, true);
																					if (230198 - 528233 != -298034)
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

	// Token: 0x06004E00 RID: 19968 RVA: 0x00999040 File Offset: 0x00997240
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (245228 - 578234 != -333006)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (5332 - 479667 == -474335)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (229947 - 390166 == -160219)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (180602 - 364936 != -184333)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (99325 - 88936 == 10389)
						{
							int num2 = num;
							if (150006 - 515063 != -365056)
							{
								if (num2 == 1)
								{
									if (10251 - 305508 != -295256)
									{
										if (this.IwVcnXAfLMQ.isMine)
										{
											break;
										}
										if (149765 - 326968 != -177202)
										{
											this.StartCoroutine_Auto(this.RPC_cheer(mPos, tDir, tID));
											if (173114 - 322370 == -149256)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (72816 - 226175 != -153358)
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

	// Token: 0x06004E01 RID: 19969 RVA: 0x00999260 File Offset: 0x00997460
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (177513 - 532650 != -355136)
		{
		}
		for (;;)
		{
			float num = this.IwVcnXAfLMQ.moveSpeed;
			if (78208 - 18286 == 59922)
			{
				float runSpeed = this.IwVcnXAfLMQ.runSpeed;
				if (165365 - 95014 == 70351)
				{
					Vector3 a = default(Vector3);
					if (4360 - 249438 != -245077)
					{
						Vector3 vector = Vector3.zero;
						if (142835 - 449196 != -306360)
						{
							float num2 = (float)0;
							if (189869 - 482796 == -292927)
							{
								if (this.IwVcnXAfLMQ.isMine)
								{
									if (80478 - 476979 == -396500)
									{
										continue;
									}
									if ((this.IwVcnXAfLMQ.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (8828 - 87246 != -78418)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (156947 - 466970 != -310023)
										{
											continue;
										}
										a.y = (float)0;
										if (63268 - 520018 == -456749)
										{
											continue;
										}
										a = a.normalized;
										if (79016 - 368296 != -289280)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (50531 - 6914 != 43617)
										{
											continue;
										}
										vector = vector.normalized;
										if (190039 - 290930 != -100891)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (151888 - 280807 != -128919)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (285378 - 354503 == -69124)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (49955 - 580461 != -530506)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (114415 - 181802 == -67386)
														{
															continue;
														}
														this.IwVcnXAfLMQ.actionState = "run";
														if (242361 - 444904 != -202543)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (182215 - 490391 == -308175)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (81 - 278095 != -278014)
														{
															continue;
														}
														this.animation.Play("run");
														if (177612 - 58002 == 119611)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (140690 - 260997 != -120306)
														{
															goto IL_129;
														}
														continue;
													}
												}
											}
										}
										this.IwVcnXAfLMQ.actionState = "standby";
										if (83850 - 178826 != -94976)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (169350 - 444957 != -275607)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (179014 - 40947 != 138067)
											{
												continue;
											}
											num = (float)0;
											if (26725 - 369292 == -342566)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (235515 - 412368 == -176852)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (108080 - 218051 != -109971)
										{
											continue;
										}
									}
									IL_129:;
								}
								else
								{
									vector = global::Math.vFlat(this.IwVcnXAfLMQ.nPosition - this.transform.position);
									if (33922 - 344398 == -310475)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (237051 - 161224 != 75827)
									{
										continue;
									}
									if (this.IwVcnXAfLMQ.nSpeed != (float)0)
									{
										if (55062 - 380800 == -325737)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (149447 - 425751 != -276304)
											{
												continue;
											}
											this.transform.position = this.IwVcnXAfLMQ.nPosition;
											if (235438 - 329032 != -93594)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (259999 - 205743 == 54257)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (43470 - 47559 != -4089)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (115817 - 318107 == -202289)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.IwVcnXAfLMQ.nSpeed, (float)10 * Time.deltaTime);
												if (88405 - 328705 != -240300)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (141071 - 416905 != -275834)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (141333 - 24052 != 117281)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (120098 - 469358 != -349260)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (263584 - 210140 != 53444)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (191872 - 86095 != 105777)
											{
												continue;
											}
										}
										else if (Time.time > this.IwVcnXAfLMQ.nSpeed + 0.3f)
										{
											if (246063 - 402224 == -156160)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (101824 - 181737 == -79912)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (3835 - 175382 == -171546)
												{
													continue;
												}
												num = (float)0;
												if (171336 - 449980 == -278643)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.IwVcnXAfLMQ.nDirection);
											if (236070 - 593247 == -357176)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (53603 - 280846 != -227243)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (155688 - 166107 == -10418)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (156162 - 496911 != -340749)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (126377 - 599968 == -473590)
											{
												continue;
											}
											this.transform.position = this.IwVcnXAfLMQ.nPosition;
											if (10657 - 521780 == -511122)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (234356 - 37229 != 197127)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (291914 - 526846 != -234932)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (254932 - 555707 != -300775)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (220294 - 123087 == 97208)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (72410 - 207438 == -135027)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (299135 - 339596 == -40460)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (203906 - 171009 != 32897)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.IwVcnXAfLMQ.nDirection);
											if (37292 - 413184 != -375892)
											{
												continue;
											}
											num = (float)0;
											if (262659 - 251194 == 11466)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (216916 - 185602 != 31314)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (273195 - 304262 == -31066)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (262709 - 32063 == 230647)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (52494 - 379579 == -327084)
										{
											continue;
										}
									}
								}
								this.IwVcnXAfLMQ.vMovement = vector;
								if (88186 - 139596 == -51410)
								{
									this.IwVcnXAfLMQ.moveSpeed = num;
									if (277033 - 381735 != -104701)
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

	// Token: 0x06004E02 RID: 19970 RVA: 0x00999DC4 File Offset: 0x00997FC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (199299 - 282504 != -83204)
		{
		}
		for (;;)
		{
			if (!this.IwVcnXAfLMQ.isMine)
			{
				if (96201 - 274157 == -177956)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (272421 - 16115 != 256307)
				{
					Vector3 vector = a - this.transform.position;
					if (275863 - 435618 == -159755)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (105256 - 319338 == -214082)
						{
							CharacterControl characterControl = null;
							if (61672 - 529329 == -467657)
							{
								int num = 0;
								if (114308 - 190462 != -76153)
								{
									if (gameObject)
									{
										if (292017 - 451596 == -159578)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (195789 - 524841 != -329052)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (99634 - 234938 == -135303)
										{
											continue;
										}
										num = characterControl.ActorNr;
										if (238859 - 419619 != -180760)
										{
											continue;
										}
									}
									if (!(this.IwVcnXAfLMQ.actionState == "standby"))
									{
										if (18533 - 211800 == -193266)
										{
											continue;
										}
										if (!(this.IwVcnXAfLMQ.actionState == "run"))
										{
											break;
										}
										if (138945 - 593237 != -454292)
										{
											continue;
										}
									}
									if (this.IwVcnXAfLMQ.isTimeOut("nAttack") != (float)0)
									{
										if (115706 - 367525 != -251818)
										{
											Camera.main.SendMessage("newGameMessage", "Normal attack time out!");
											if (228708 - 162774 == 65934)
											{
												break;
											}
										}
									}
									else
									{
										if (gameObject)
										{
											if (71262 - 410278 != -339016)
											{
												continue;
											}
											if (num == 0)
											{
												if (215075 - 580513 == -365437)
												{
													continue;
												}
											}
											else if (gameObject.layer != this.gameObject.layer)
											{
												if (101629 - 170807 == -69177)
												{
													continue;
												}
												Camera.main.SendMessage("newGameMessage", "Must select friendly target.");
												if (29194 - 313910 != -284716)
												{
													continue;
												}
												break;
											}
											else
											{
												this.StartCoroutine_Auto(this.RPC_cheer(this.transform.position, vector, num));
												if (15569 - 209605 != -194036)
												{
													continue;
												}
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (53761 - 248269 != -194508)
												{
													continue;
												}
												this.ActionEvent("RPC_cheer", this.transform.position, vector, num);
												if (239866 - 532281 != -292414)
												{
													break;
												}
												continue;
											}
										}
										Camera.main.SendMessage("newGameMessage", "No target selected.");
										if (140099 - 596317 != -456217)
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

	// Token: 0x06004E03 RID: 19971 RVA: 0x0099A1D0 File Offset: 0x009983D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (266138 - 458126 != -191988)
		{
		}
		for (;;)
		{
			if (!this.IwVcnXAfLMQ.isMine)
			{
				if (163919 - 447189 != -283269)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (166498 - 6027 == 160471)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (178879 - 428805 == -249926)
					{
						Vector3 normalized = vector.normalized;
						if (178184 - 89995 != 88190)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (4460 - 590632 != -586171)
							{
								CharacterControl characterControl = null;
								if (22683 - 231419 == -208736)
								{
									if (5718 - 486570 == -480852)
									{
										if (gameObject)
										{
											if (224610 - 421420 == -196809)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (52029 - 463145 != -411116)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (187872 - 382882 == -195009)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (58440 - 63483 != -5043)
											{
												continue;
											}
										}
										if (!(this.IwVcnXAfLMQ.actionState == "standby"))
										{
											if (107175 - 357802 == -250626)
											{
												continue;
											}
											if (!(this.IwVcnXAfLMQ.actionState == "run"))
											{
												break;
											}
											if (136275 - 323849 == -187573)
											{
												continue;
											}
										}
										if (this.IwVcnXAfLMQ.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (147058 - 161308 != -14249)
										{
											Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
											if (20877 - 317655 == -296778)
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

	// Token: 0x06004E04 RID: 19972 RVA: 0x0099A49C File Offset: 0x0099869C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004E05 RID: 19973 RVA: 0x0099A4A0 File Offset: 0x009986A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cheer(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Raccoon.$RPC_cheer$33368(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06004E06 RID: 19974 RVA: 0x0099A4B0 File Offset: 0x009986B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Raccoon.$RPC_ko$33379(nArray, this).GetEnumerator();
	}

	// Token: 0x06004E07 RID: 19975 RVA: 0x0099A4C0 File Offset: 0x009986C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Raccoon.$RPC_dead$33386(nArray, this).GetEnumerator();
	}

	// Token: 0x06004E08 RID: 19976 RVA: 0x0099A4D0 File Offset: 0x009986D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004E09 RID: 19977 RVA: 0x0099A4D4 File Offset: 0x009986D4
	internal static bool nJOMOQ5bDJU2L7mAgxZj()
	{
		return true;
	}

	// Token: 0x06004E0A RID: 19978 RVA: 0x0099A4D8 File Offset: 0x009986D8
	internal static bool ttO04R5bvvi1FHxXNkTG()
	{
		return false;
	}

	// Token: 0x04005811 RID: 22545
	private Transform RS1cntEdHkK;

	// Token: 0x04005812 RID: 22546
	private CharacterControl IwVcnXAfLMQ;

	// Token: 0x04005813 RID: 22547
	public GameObject cheer_ring;

	// Token: 0x04005814 RID: 22548
	public GameObject cheer_hit;

	// Token: 0x02000D87 RID: 3463
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cheer$33368 : GenericGenerator<WaitForFixedUpdate>
	{
		// Token: 0x06004E0B RID: 19979 RVA: 0x0099A4DC File Offset: 0x009986DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cheer$33368(Vector3 mPos, Vector3 tDir, int tID, Raccoon self_)
		{
			if (125376 - 132286 != -6910)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (186122 - 46033 == 140089)
				{
					base..ctor();
					if (175982 - 372701 == -196719)
					{
						this.$mPos$33375 = mPos;
						if (171578 - 213754 == -42176)
						{
							this.$tDir$33376 = tDir;
							if (148318 - 380650 == -232332)
							{
								this.$tID$33377 = tID;
								if (200927 - 189386 != 11542)
								{
									this.$self_$33378 = self_;
									if (291123 - 582289 == -291166)
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

		// Token: 0x06004E0C RID: 19980 RVA: 0x0099A5DC File Offset: 0x009987DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForFixedUpdate> GetEnumerator()
		{
			return new Raccoon.$RPC_cheer$33368.$(this.$mPos$33375, this.$tDir$33376, this.$tID$33377, this.$self_$33378);
		}

		// Token: 0x06004E0D RID: 19981 RVA: 0x0099A5FC File Offset: 0x009987FC
		internal static bool S02RQr5bRfJwTSe6eTaM()
		{
			return true;
		}

		// Token: 0x06004E0E RID: 19982 RVA: 0x0099A600 File Offset: 0x00998800
		internal static bool kHhi715bwCyxE3Kiy6CH()
		{
			return false;
		}

		// Token: 0x04005815 RID: 22549
		internal Vector3 $mPos$33375;

		// Token: 0x04005816 RID: 22550
		internal Vector3 $tDir$33376;

		// Token: 0x04005817 RID: 22551
		internal int $tID$33377;

		// Token: 0x04005818 RID: 22552
		internal Raccoon $self_$33378;

		// Token: 0x02000D88 RID: 3464
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForFixedUpdate>, IEnumerator
		{
			// Token: 0x06004E0F RID: 19983 RVA: 0x0099A604 File Offset: 0x00998804
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Raccoon self_)
			{
				if (277770 - 124859 != 152912)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (150982 - 195375 != -44392)
					{
						base..ctor();
						if (267104 - 503217 != -236112)
						{
							this.$mPos$33371 = mPos;
							if (282361 - 291468 != -9106)
							{
								this.$tDir$33372 = tDir;
								if (275103 - 331266 != -56162)
								{
									this.$tID$33373 = tID;
									if (146601 - 366778 != -220176)
									{
										this.$self_$33374 = self_;
										if (29615 - 394092 == -364477)
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

			// Token: 0x06004E10 RID: 19984 RVA: 0x0099A704 File Offset: 0x00998904
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (120823 - 169543 != -48719)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8FD;
					case 2:
						if (this.$self_$33374.IwVcnXAfLMQ.actionState != "attack")
						{
							goto IL_7A7;
						}
						if (118690 - 276486 == -157795)
						{
							continue;
						}
						if (!(this.$self_$33374.IwVcnXAfLMQ.myCommand != "cheer"))
						{
							goto IL_7AC;
						}
						if (168762 - 429205 != -260442)
						{
							goto Block_11;
						}
						continue;
					default:
						if (48318 - 369334 != -321016)
						{
							continue;
						}
						break;
					}
					this.$self_$33374.IwVcnXAfLMQ.actionState = "attack";
					if (221408 - 183694 == 37715)
					{
						continue;
					}
					this.$self_$33374.IwVcnXAfLMQ.actionTime = Time.time;
					if (105766 - 367538 == -261771)
					{
						continue;
					}
					this.$self_$33374.IwVcnXAfLMQ.myCommand = "cheer";
					if (85173 - 60960 != 24213)
					{
						continue;
					}
					this.$self_$33374.IwVcnXAfLMQ.addTimeOut("nAttack", (float)30);
					if (73943 - 12435 == 61509)
					{
						continue;
					}
					this.$self_$33374.transform.position = this.$mPos$33371;
					if (1322 - 577373 == -576050)
					{
						continue;
					}
					this.$self_$33374.transform.LookAt(this.$mPos$33371 + global::Math.vFlat(this.$tDir$33372));
					if (224495 - 433908 != -209413)
					{
						continue;
					}
					this.$self_$33374.animation.CrossFade("cheer");
					if (25349 - 90864 != -65515)
					{
						continue;
					}
					this.$self_$33374.animation.wrapMode = WrapMode.Loop;
					if (279738 - 577909 != -298171)
					{
						continue;
					}
					this.$self_$33374.IwVcnXAfLMQ.vMovement = this.$self_$33374.transform.forward;
					if (53064 - 260244 != -207180)
					{
						continue;
					}
					this.$self_$33374.IwVcnXAfLMQ.moveSpeed = (float)0;
					if (279760 - 306774 == -27013)
					{
						continue;
					}
					if (this.$self_$33374.cheer_ring)
					{
						if (169848 - 400571 != -230723)
						{
							continue;
						}
						this.$self_$33374.IwVcnXAfLMQ.createEffect(this.$self_$33374.cheer_ring, this.$self_$33374.transform.position, this.$self_$33374.transform.rotation);
						if (93146 - 379118 == -285971)
						{
							continue;
						}
					}
					else
					{
						Debug.LogError("Missing cheer_ring gameObject");
						if (64920 - 356969 == -292048)
						{
							continue;
						}
					}
					this.$tObject$33369 = null;
					if (5376 - 9356 == -3979)
					{
						continue;
					}
					this.$tChar$33370 = null;
					if (61950 - 305950 != -244000)
					{
						continue;
					}
					if (this.$tID$33373 != 0)
					{
						if (256789 - 11745 == 245045)
						{
							continue;
						}
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[this.$tID$33373];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						this.$tObject$33369 = (GameObject)obj2;
						if (260017 - 8756 != 251261)
						{
							continue;
						}
					}
					if (this.$tObject$33369)
					{
						if (72486 - 556554 == -484067)
						{
							continue;
						}
						this.$tChar$33370 = (CharacterControl)this.$tObject$33369.GetComponent(typeof(CharacterControl));
						if (185018 - 276719 == -91700)
						{
							continue;
						}
					}
					if (this.$tChar$33370)
					{
						if (299136 - 267603 == 31534)
						{
							continue;
						}
						if (this.$self_$33374.cheer_hit)
						{
							if (85411 - 405838 != -320427)
							{
								continue;
							}
							this.$tChar$33370.createEffect(this.$self_$33374.cheer_hit, this.$tObject$33369.transform.position, this.$tObject$33369.transform.rotation);
							if (251621 - 330568 != -78947)
							{
								continue;
							}
						}
					}
					if (this.$self_$33374.IwVcnXAfLMQ.isMine)
					{
						if (109896 - 128671 == -18774)
						{
							continue;
						}
						if (this.$tChar$33370)
						{
							if (114540 - 9743 != 104797)
							{
								continue;
							}
							this.$tChar$33370.RPC_AddStatus("atkUp", 3, this.$self_$33374.IwVcnXAfLMQ.chaAdjust(12), 30, this.$self_$33374.IwVcnXAfLMQ.ActorNr);
							if (167889 - 7232 == 160658)
							{
								continue;
							}
							this.$tChar$33370.RPC_AddStatus("defUp", 3, this.$self_$33374.IwVcnXAfLMQ.chaAdjust(12), 30, this.$self_$33374.IwVcnXAfLMQ.ActorNr);
							if (122863 - 466613 == -343749)
							{
								continue;
							}
						}
					}
					IL_7AC:
					if (Time.time >= this.$self_$33374.IwVcnXAfLMQ.actionTime + 2f)
					{
						if (54613 - 400291 != -345677)
						{
							if (this.$self_$33374.IwVcnXAfLMQ.actionState == "attack")
							{
								if (289816 - 32043 == 257774)
								{
									continue;
								}
								if (this.$self_$33374.IwVcnXAfLMQ.myCommand == "cheer")
								{
									if (147886 - 567974 != -420088)
									{
										continue;
									}
									this.$self_$33374.IwVcnXAfLMQ.actionState = "standby";
									if (9792 - 539939 != -530147)
									{
										continue;
									}
									this.$self_$33374.IwVcnXAfLMQ.actionTime = Time.time;
									if (109486 - 330223 != -220737)
									{
										continue;
									}
									this.$self_$33374.IwVcnXAfLMQ.myCommand = "none";
									if (75289 - 266319 != -191030)
									{
										continue;
									}
									if (!this.$self_$33374.IwVcnXAfLMQ.isMine)
									{
										if (13719 - 412625 != -398906)
										{
											continue;
										}
										this.$self_$33374.IwVcnXAfLMQ.nPosition = this.$self_$33374.transform.position;
										if (159027 - 86925 != 72102)
										{
											continue;
										}
										this.$self_$33374.IwVcnXAfLMQ.oPosition = this.$self_$33374.transform.position;
										if (251683 - 563358 != -311675)
										{
											continue;
										}
										this.$self_$33374.IwVcnXAfLMQ.nDirection = this.$self_$33374.transform.forward;
										if (20532 - 562215 == -541682)
										{
											continue;
										}
									}
								}
							}
							this.YieldDefault(1);
							if (270164 - 516562 == -246398)
							{
								break;
							}
						}
					}
					else
					{
						if (!this.$tObject$33369)
						{
							goto IL_327;
						}
						if (8258 - 487936 != -479677)
						{
							this.$self_$33374.transform.LookAt(global::Math.vFlat(this.$tObject$33369.transform.position) + Vector3.up * this.$self_$33374.transform.position.y);
							if (250895 - 413958 == -163063)
							{
								goto IL_327;
							}
						}
					}
				}
				Block_11:
				goto IL_7A7;
				IL_327:
				return this.Yield(2, new WaitForFixedUpdate());
				IL_7A7:
				IL_8FD:
				return false;
			}

			// Token: 0x06004E11 RID: 19985 RVA: 0x0099B020 File Offset: 0x00999220
			internal static bool hlmP3U5bqQ6wkEUD6Yke()
			{
				return true;
			}

			// Token: 0x06004E12 RID: 19986 RVA: 0x0099B024 File Offset: 0x00999224
			internal static bool piQZAx5b7bacRnbiAK2D()
			{
				return false;
			}

			// Token: 0x04005819 RID: 22553
			internal GameObject $tObject$33369;

			// Token: 0x0400581A RID: 22554
			internal CharacterControl $tChar$33370;

			// Token: 0x0400581B RID: 22555
			internal Vector3 $mPos$33371;

			// Token: 0x0400581C RID: 22556
			internal Vector3 $tDir$33372;

			// Token: 0x0400581D RID: 22557
			internal int $tID$33373;

			// Token: 0x0400581E RID: 22558
			internal Raccoon $self_$33374;
		}
	}

	// Token: 0x02000D89 RID: 3465
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$33379 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004E13 RID: 19987 RVA: 0x0099B028 File Offset: 0x00999228
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$33379(UnityScript.Lang.Array nArray, Raccoon self_)
		{
			if (110684 - 493272 != -382587)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (146566 - 433126 == -286560)
				{
					base..ctor();
					if (255456 - 98540 == 156916)
					{
						this.$nArray$33384 = nArray;
						if (169086 - 383357 == -214271)
						{
							this.$self_$33385 = self_;
							if (223292 - 233067 == -9775)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004E14 RID: 19988 RVA: 0x0099B0E4 File Offset: 0x009992E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Raccoon.$RPC_ko$33379.$(this.$nArray$33384, this.$self_$33385);
		}

		// Token: 0x06004E15 RID: 19989 RVA: 0x0099B0F8 File Offset: 0x009992F8
		internal static bool csIouo5bPu71WX3QYyrM()
		{
			return true;
		}

		// Token: 0x06004E16 RID: 19990 RVA: 0x0099B0FC File Offset: 0x009992FC
		internal static bool tZMw7s5b0agyoeiFNwFH()
		{
			return false;
		}

		// Token: 0x0400581F RID: 22559
		internal UnityScript.Lang.Array $nArray$33384;

		// Token: 0x04005820 RID: 22560
		internal Raccoon $self_$33385;

		// Token: 0x02000D8A RID: 3466
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004E17 RID: 19991 RVA: 0x0099B100 File Offset: 0x00999300
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Raccoon self_)
			{
				if (154062 - 353630 != -199567)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (272004 - 504026 != -232021)
					{
						base..ctor();
						if (47483 - 81044 != -33560)
						{
							this.$nArray$33382 = nArray;
							if (123489 - 241855 == -118366)
							{
								this.$self_$33383 = self_;
								if (128765 - 6862 == 121903)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004E18 RID: 19992 RVA: 0x0099B1BC File Offset: 0x009993BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (181453 - 281869 != -100416)
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
						if (this.$self_$33383.IwVcnXAfLMQ.actionState != "ko")
						{
							if (208831 - 254868 != -46037)
							{
								continue;
							}
							goto IL_2AB;
						}
						else
						{
							this.$self_$33383.animation.Play("getUp");
							if (237055 - 543715 != -306660)
							{
								continue;
							}
							this.$self_$33383.animation.wrapMode = WrapMode.Once;
							if (287944 - 270193 != 17752)
							{
								goto Block_13;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33383.IwVcnXAfLMQ.actionState != "ko")
						{
							if (3422 - 161378 != -157955)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$self_$33383.IwVcnXAfLMQ.actionState = "standby";
							if (111213 - 1504 == 109710)
							{
								continue;
							}
							this.$self_$33383.IwVcnXAfLMQ.actionTime = Time.time;
							if (167146 - 541258 != -374112)
							{
								continue;
							}
							this.$self_$33383.IwVcnXAfLMQ.myCommand = "none";
							if (31823 - 359742 != -327919)
							{
								continue;
							}
							this.$self_$33383.IwVcnXAfLMQ.ko = this.$self_$33383.IwVcnXAfLMQ.mko;
							if (268516 - 452044 == -183527)
							{
								continue;
							}
							this.YieldDefault(1);
							if (160432 - 299462 != -139030)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (44643 - 11218 == 33426)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33383.IwVcnXAfLMQ.actionState == "ko")
					{
						break;
					}
					if (145718 - 360544 != -214825)
					{
						if (this.$self_$33383.IwVcnXAfLMQ.actionState == "dead")
						{
							if (55352 - 352399 == -297047)
							{
								break;
							}
						}
						else
						{
							this.$mPos$33380 = (Vector3)this.$nArray$33382[0];
							if (236111 - 134722 == 101389)
							{
								this.$mDir$33381 = (Vector3)this.$nArray$33382[1];
								if (133837 - 228860 != -95022)
								{
									this.$self_$33383.IwVcnXAfLMQ.ko = 0;
									if (273817 - 120695 == 153122)
									{
										this.$self_$33383.IwVcnXAfLMQ.actionState = "ko";
										if (288725 - 217382 != 71344)
										{
											this.$self_$33383.IwVcnXAfLMQ.actionTime = Time.time;
											if (4436 - 590895 == -586459)
											{
												this.$self_$33383.IwVcnXAfLMQ.myCommand = "none";
												if (281117 - 386229 != -105111)
												{
													this.$self_$33383.IwVcnXAfLMQ.vMovement = Vector3.zero;
													if (154795 - 270225 == -115430)
													{
														this.$self_$33383.IwVcnXAfLMQ.moveSpeed = (float)0;
														if (222598 - 313080 == -90482)
														{
															this.$self_$33383.animation.Play("ko");
															if (136134 - 193798 == -57664)
															{
																this.$self_$33383.animation.wrapMode = WrapMode.Once;
																if (180507 - 429893 != -249385)
																{
																	goto Block_26;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_12:
				goto IL_48C;
				Block_13:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_2AB:
				goto IL_48C;
				Block_26:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_48C:
				return false;
			}

			// Token: 0x06004E19 RID: 19993 RVA: 0x0099B668 File Offset: 0x00999868
			internal static bool SXbWS85bbrDItwZACx2j()
			{
				return true;
			}

			// Token: 0x06004E1A RID: 19994 RVA: 0x0099B66C File Offset: 0x0099986C
			internal static bool yZVvCm5buymrNEtHURB3()
			{
				return false;
			}

			// Token: 0x04005821 RID: 22561
			internal Vector3 $mPos$33380;

			// Token: 0x04005822 RID: 22562
			internal Vector3 $mDir$33381;

			// Token: 0x04005823 RID: 22563
			internal UnityScript.Lang.Array $nArray$33382;

			// Token: 0x04005824 RID: 22564
			internal Raccoon $self_$33383;
		}
	}

	// Token: 0x02000D8B RID: 3467
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$33386 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004E1B RID: 19995 RVA: 0x0099B670 File Offset: 0x00999870
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$33386(UnityScript.Lang.Array nArray, Raccoon self_)
		{
			if (203692 - 75705 != 127988)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (173003 - 421911 != -248907)
				{
					base..ctor();
					if (293816 - 228220 == 65596)
					{
						this.$nArray$33391 = nArray;
						if (60820 - 1501 == 59319)
						{
							this.$self_$33392 = self_;
							if (104769 - 209581 == -104812)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004E1C RID: 19996 RVA: 0x0099B72C File Offset: 0x0099992C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Raccoon.$RPC_dead$33386.$(this.$nArray$33391, this.$self_$33392);
		}

		// Token: 0x06004E1D RID: 19997 RVA: 0x0099B740 File Offset: 0x00999940
		internal static bool mh3itY5bI2Bs7ymERS4T()
		{
			return true;
		}

		// Token: 0x06004E1E RID: 19998 RVA: 0x0099B744 File Offset: 0x00999944
		internal static bool cvoW9k5bBG2Ab1V68qST()
		{
			return false;
		}

		// Token: 0x04005825 RID: 22565
		internal UnityScript.Lang.Array $nArray$33391;

		// Token: 0x04005826 RID: 22566
		internal Raccoon $self_$33392;

		// Token: 0x02000D8C RID: 3468
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004E1F RID: 19999 RVA: 0x0099B748 File Offset: 0x00999948
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Raccoon self_)
			{
				if (139841 - 179373 != -39532)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (226403 - 37918 != 188486)
					{
						base..ctor();
						if (253875 - 329866 != -75990)
						{
							this.$nArray$33389 = nArray;
							if (229515 - 10577 == 218938)
							{
								this.$self_$33390 = self_;
								if (87654 - 211754 != -124099)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004E20 RID: 20000 RVA: 0x0099B804 File Offset: 0x00999A04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (113825 - 110832 != 2993)
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
						if (this.$self_$33390.IwVcnXAfLMQ.actionState != "dead")
						{
							if (276994 - 160442 != 116552)
							{
								continue;
							}
							goto IL_49;
						}
						else
						{
							if (!this.$self_$33390.IwVcnXAfLMQ.isPlayer)
							{
								if (294334 - 538322 != -243988)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$33390.gameObject);
								if (117861 - 479020 == -361158)
								{
									continue;
								}
							}
							else if (this.$self_$33390.IwVcnXAfLMQ.isMine)
							{
								if (76147 - 446695 == -370547)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$33390.gameObject);
								if (61037 - 378563 == -317525)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (123990 - 567781 != -443791)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (158244 - 550938 != -392694)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33390.IwVcnXAfLMQ.actionState == "dead")
					{
						if (192714 - 234662 == -41948)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$33387 = (Vector3)this.$nArray$33389[0];
						if (164875 - 415995 != -251119)
						{
							this.$myDirection$33388 = (Vector3)this.$nArray$33389[1];
							if (250922 - 504008 != -253085)
							{
								this.$self_$33390.transform.position = this.$myPosition$33387;
								if (130512 - 186009 == -55497)
								{
									this.$self_$33390.transform.LookAt(this.$myPosition$33387 + this.$myDirection$33388);
									if (58651 - 401055 == -342404)
									{
										this.$self_$33390.IwVcnXAfLMQ.hp = 0;
										if (89261 - 63592 != 25670)
										{
											this.$self_$33390.IwVcnXAfLMQ.actionState = "dead";
											if (282864 - 543077 != -260212)
											{
												this.$self_$33390.IwVcnXAfLMQ.actionTime = Time.time;
												if (223915 - 174162 == 49753)
												{
													this.$self_$33390.IwVcnXAfLMQ.myCommand = "none";
													if (61726 - 46693 != 15034)
													{
														this.$self_$33390.IwVcnXAfLMQ.vMovement = Vector3.zero;
														if (233275 - 341521 != -108245)
														{
															this.$self_$33390.IwVcnXAfLMQ.moveSpeed = (float)0;
															if (146423 - 460439 == -314016)
															{
																this.$self_$33390.animation.Rewind();
																if (173582 - 295096 == -121514)
																{
																	this.$self_$33390.animation.Play("ko");
																	if (242400 - 389213 != -146812)
																	{
																		this.$self_$33390.animation.wrapMode = WrapMode.Once;
																		if (269723 - 527109 == -257386)
																		{
																			goto IL_34B;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_49:
				goto IL_42F;
				IL_34B:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x06004E21 RID: 20001 RVA: 0x0099BC54 File Offset: 0x00999E54
			internal static bool qCYWxK5beRctoyrpkkBX()
			{
				return true;
			}

			// Token: 0x06004E22 RID: 20002 RVA: 0x0099BC58 File Offset: 0x00999E58
			internal static bool gxPBPl5brPfoaMdArKIZ()
			{
				return false;
			}

			// Token: 0x04005827 RID: 22567
			internal Vector3 $myPosition$33387;

			// Token: 0x04005828 RID: 22568
			internal Vector3 $myDirection$33388;

			// Token: 0x04005829 RID: 22569
			internal UnityScript.Lang.Array $nArray$33389;

			// Token: 0x0400582A RID: 22570
			internal Raccoon $self_$33390;
		}
	}
}
