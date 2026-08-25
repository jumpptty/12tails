using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200033D RID: 829
[Serializable]
public class LightGolem : MonoBehaviour
{
	// Token: 0x060012CE RID: 4814 RVA: 0x001D7314 File Offset: 0x001D5514
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LightGolem()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060012CF RID: 4815 RVA: 0x001D7324 File Offset: 0x001D5524
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (219994 - 456972 != -236978)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (94932 - 148690 != -53757)
			{
				this.mChar.actionState = "standby";
				if (286338 - 429970 != -143631)
				{
					this.mChar.actionTime = Time.time;
					if (263401 - 408122 != -144720)
					{
						this.mChar.myCommand = "none";
						if (187092 - 208408 == -21316)
						{
							this.O88t5PK7jj = Time.time + (float)300;
							if (4123 - 388184 == -384061)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060012D0 RID: 4816 RVA: 0x001D743C File Offset: 0x001D563C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (244718 - 275017 != -30299)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (200535 - 540521 == -339985)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (267587 - 419115 == -151527)
				{
					continue;
				}
			}
			if (this.gameObject.layer != 9)
			{
				break;
			}
			if (159489 - 505593 == -346104)
			{
				if (this.mChar)
				{
					if (98968 - 65079 != 33889)
					{
						continue;
					}
					this.mChar.mTargetAvartar = this.LightGolemIcon2;
					if (112444 - 401419 == -288974)
					{
						continue;
					}
				}
				Transform transform = this.transform.Find("CrystalBug_tri");
				if (139212 - 429100 == -289888)
				{
					if (transform)
					{
						if (204195 - 307348 != -103152)
						{
							SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer));
							if (213750 - 529003 == -315253)
							{
								if (skinnedMeshRenderer)
								{
									if (134525 - 567084 != -432558)
									{
										skinnedMeshRenderer.material = this.LightGolem2;
										if (244962 - 599080 == -354118)
										{
											break;
										}
									}
								}
								else
								{
									Debug.LogError("Cannot find LightGolem SkinnedMeshRenderer");
									if (199935 - 142016 == 57919)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						Debug.LogError("Cannot find LightGolem model");
						if (282125 - 449190 != -167064)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060012D1 RID: 4817 RVA: 0x001D7660 File Offset: 0x001D5860
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (99839 - 594079 != -494239)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (147416 - 436751 != -289335)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (184784 - 441777 != -256993)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_220;
					}
					if (58609 - 514748 != -456139)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (179491 - 414376 != -234885)
				{
					continue;
				}
			}
			IL_220:
			if (this.mChar.hp > 0)
			{
				if (141155 - 424599 == -283443)
				{
					continue;
				}
				if (Time.time <= this.O88t5PK7jj)
				{
					break;
				}
				if (201466 - 180539 == 20928)
				{
					continue;
				}
			}
			if (!(this.mChar.actionState != "dead"))
			{
				break;
			}
			if (276234 - 57326 == 218908)
			{
				if (this.mChar.isMine)
				{
					if (134609 - 211516 != -76906)
					{
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (81625 - 507715 == -426090)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (216398 - 467129 != -250730)
							{
								this.mChar.DeadEvent();
								if (69380 - 475688 != -406307)
								{
									break;
								}
							}
						}
					}
				}
				else
				{
					this.mChar.hp = 1;
					if (157400 - 71015 != 86386)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060012D2 RID: 4818 RVA: 0x001D78CC File Offset: 0x001D5ACC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (248027 - 224299 != 23729)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (76514 - 379101 != -302586)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (16950 - 57309 != -40358)
				{
					if (244053 - 244407 == -354)
					{
						if (ActionName == "RPC_nAttack1")
						{
							if (231519 - 16543 != 214976)
							{
								continue;
							}
							v = 1;
							if (7297 - 157631 == -150333)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack2")
						{
							if (293194 - 112433 == 180762)
							{
								continue;
							}
							v = 2;
							if (38899 - 187538 == -148638)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack3")
						{
							if (268448 - 174767 != 93681)
							{
								continue;
							}
							v = 3;
							if (3995 - 286529 == -282533)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (168187 - 477909 != -309722)
							{
								continue;
							}
							v = -1;
							if (42304 - 305459 != -263155)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (83939 - 409283 == -325343)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (63353 - 276634 == -213281)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (274768 - 383306 == -108538)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (166996 - 386113 == -219117)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (170875 - 58570 != 112306)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (17128 - 67125 != -49996)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (12124 - 552815 == -540691)
											{
												Hashtable hashtable = new Hashtable();
												if (1921 - 485494 == -483573)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (230854 - 508154 == -277300)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (106135 - 239224 != -133088)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (276189 - 143594 != 132596)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (108034 - 456296 == -348262)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (139277 - 411125 == -271848)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (110823 - 538407 != -427583)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (153811 - 192333 != -38521)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (246152 - 200313 != 45840)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (171301 - 90954 != 80348)
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

	// Token: 0x060012D3 RID: 4819 RVA: 0x001D7DE0 File Offset: 0x001D5FE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (280553 - 118453 != 162100)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (90051 - 369554 == -279503)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (264104 - 255323 == 8781)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (153381 - 355251 == -201870)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (50342 - 442154 != -391811)
						{
							int num3 = num;
							if (31213 - 361051 == -329838)
							{
								if (num3 == 1)
								{
									if (215215 - 436913 != -221697)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (286452 - 276848 != 9605)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack1(vector, vector2, num2));
											if (251842 - 378883 == -127041)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (190739 - 175836 != 14904)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (250510 - 248656 == 1854)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack2(vector, vector2, num2));
											if (104817 - 398945 != -294127)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 3)
								{
									if (113113 - 425673 != -312559)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (60976 - 234967 == -173991)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack3(vector, vector2, num2));
											if (299780 - 334003 != -34222)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (70226 - 436164 == -365938)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (49072 - 284599 != -235526)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (294910 - 103344 != 191567)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (131354 - 477096 != -345741)
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

	// Token: 0x060012D4 RID: 4820 RVA: 0x001D816C File Offset: 0x001D636C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (75360 - 236959 != -161598)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (97720 - 240763 != -143042)
			{
				float runSpeed = this.mChar.runSpeed;
				if (201778 - 537770 == -335992)
				{
					Vector3 a = default(Vector3);
					if (116246 - 426049 != -309802)
					{
						Vector3 vector = Vector3.zero;
						if (121710 - 353246 == -231536)
						{
							float num2 = (float)0;
							if (56746 - 428770 != -372023)
							{
								if (this.mChar.isMine)
								{
									if (155221 - 506125 != -350904)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (246957 - 571400 != -324443)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (107305 - 254939 != -147634)
										{
											continue;
										}
										a.y = (float)0;
										if (26221 - 467011 != -440790)
										{
											continue;
										}
										a = a.normalized;
										if (156959 - 345237 != -188278)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (72243 - 136232 == -63988)
										{
											continue;
										}
										vector = vector.normalized;
										if (81166 - 204605 != -123439)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (88378 - 51889 == 36490)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (169390 - 334462 == -165071)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (68863 - 575158 != -506295)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (7107 - 92971 != -85864)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (69813 - 431388 != -361575)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (217159 - 49475 != 167684)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (236076 - 21307 != 214769)
														{
															continue;
														}
														this.animation.Play("run");
														if (237934 - 374640 != -136706)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (46177 - 376673 != -330495)
														{
															goto IL_37D;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (235716 - 495071 != -259355)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (200478 - 175480 != 24998)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (4169 - 112844 == -108674)
											{
												continue;
											}
											num = (float)0;
											if (197520 - 518856 != -321336)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (89735 - 306402 != -216667)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (248628 - 35600 == 213029)
										{
											continue;
										}
									}
									IL_37D:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (229121 - 207852 == 21270)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (72477 - 517930 != -445453)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (237065 - 115668 != 121397)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (286128 - 226482 == 59647)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (26926 - 405578 != -378652)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (50676 - 555849 != -505173)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (235370 - 40410 == 194961)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (4931 - 4007 != 924)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (281839 - 223288 != 58551)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (32848 - 551383 != -518535)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (203664 - 334500 != -130836)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (146116 - 318759 == -172642)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (208569 - 415841 != -207272)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (10779 - 254017 == -243237)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (292163 - 240910 != 51253)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (299982 - 317056 == -17073)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (222060 - 379967 != -157907)
												{
													continue;
												}
												num = (float)0;
												if (231544 - 354314 == -122769)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (56471 - 206786 != -150315)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (110179 - 554964 != -444785)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (146054 - 26440 == 119615)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (261869 - 419004 != -157135)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (266422 - 329322 != -62900)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (55816 - 23896 == 31921)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (227873 - 541190 != -313317)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (278569 - 421583 == -143013)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (38536 - 295984 == -257447)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (20193 - 82102 != -61909)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (297723 - 126573 == 171151)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (271014 - 255970 == 15045)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (33314 - 511751 == -478436)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (125738 - 61182 == 64557)
											{
												continue;
											}
											num = (float)0;
											if (169540 - 387203 == -217662)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (13029 - 597205 == -584175)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (154754 - 292135 != -137381)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (15798 - 592007 != -576209)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (111901 - 319711 != -207810)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (59673 - 316569 == -256896)
								{
									this.mChar.moveSpeed = num;
									if (67186 - 200642 != -133455)
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

	// Token: 0x060012D5 RID: 4821 RVA: 0x001D8CD0 File Offset: 0x001D6ED0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (251113 - 385861 != -134748)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (5414 - 356050 != -350635)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (142733 - 325042 != -182308)
				{
					Vector3 vector = a - this.transform.position;
					if (211719 - 393911 != -182191)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (196728 - 163143 != 33586 && 223356 - 543660 != -320303)
						{
							if (gameObject)
							{
								if (89084 - 140112 == -51027)
								{
									continue;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (20500 - 285940 == -265439)
								{
									continue;
								}
							}
							if (!(this.mChar.actionState == "standby"))
							{
								if (88458 - 393964 == -305505)
								{
									continue;
								}
								if (!(this.mChar.actionState == "run"))
								{
									break;
								}
								if (52122 - 316993 != -264871)
								{
									continue;
								}
							}
							if (this.mChar.isTimeOut("nAttack") != (float)0)
							{
								break;
							}
							if (232829 - 134665 == 98164)
							{
								int num = UnityEngine.Random.Range(0, 100);
								if (223226 - 27123 == 196103)
								{
									if (num > 60)
									{
										if (63101 - 262161 == -199060)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack1(this.transform.position, vector, 0));
											if (272065 - 61345 == 210720)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (5462 - 376614 == -371152)
												{
													this.ActionEvent("RPC_nAttack1", this.transform.position, vector, 0);
													if (189024 - 557903 == -368879)
													{
														break;
													}
												}
											}
										}
									}
									else if (num > 30)
									{
										if (40971 - 536393 == -495422)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack2(this.transform.position, vector, 0));
											if (202229 - 143475 != 58755)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (2131 - 78612 != -76480)
												{
													this.ActionEvent("RPC_nAttack2", this.transform.position, vector, 0);
													if (249980 - 210666 == 39314)
													{
														break;
													}
												}
											}
										}
									}
									else
									{
										this.StartCoroutine_Auto(this.RPC_nAttack3(this.transform.position, vector, 0));
										if (183125 - 451724 != -268598)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (218282 - 11848 == 206434)
											{
												this.ActionEvent("RPC_nAttack3", this.transform.position, vector, 0);
												if (267753 - 286365 != -18611)
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

	// Token: 0x060012D6 RID: 4822 RVA: 0x001D90EC File Offset: 0x001D72EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060012D7 RID: 4823 RVA: 0x001D90F0 File Offset: 0x001D72F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060012D8 RID: 4824 RVA: 0x001D90F4 File Offset: 0x001D72F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack1(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new LightGolem.$RPC_nAttack1$18494(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060012D9 RID: 4825 RVA: 0x001D9104 File Offset: 0x001D7304
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new LightGolem.$RPC_nAttack2$18506(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060012DA RID: 4826 RVA: 0x001D9114 File Offset: 0x001D7314
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack3(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new LightGolem.$RPC_nAttack3$18518(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060012DB RID: 4827 RVA: 0x001D9124 File Offset: 0x001D7324
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (265428 - 354029 != -88601)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (245978 - 487288 != -241310)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
				if (196088 - 152445 == 43644)
				{
					continue;
				}
			}
			if (this.yQ1tc6esFs >= Time.time)
			{
				break;
			}
			if (262711 - 541067 == -278356)
			{
				this.yQ1tc6esFs = Time.time + 0.2f;
				if (46559 - 429383 == -382824)
				{
					if (!this.nAttack_hitFx)
					{
						break;
					}
					if (195216 - 208721 == -13505)
					{
						this.audio.PlayOneShot(this.nAttack_hitFx);
						if (4783 - 29874 != -25090)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060012DC RID: 4828 RVA: 0x001D9264 File Offset: 0x001D7464
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new LightGolem.$RPC_ko$18530(nArray, this).GetEnumerator();
	}

	// Token: 0x060012DD RID: 4829 RVA: 0x001D9274 File Offset: 0x001D7474
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new LightGolem.$RPC_dead$18537(nArray, this).GetEnumerator();
	}

	// Token: 0x060012DE RID: 4830 RVA: 0x001D9284 File Offset: 0x001D7484
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060012DF RID: 4831 RVA: 0x001D9288 File Offset: 0x001D7488
	internal static bool NwNiUWCqgWSFQNwt3FM()
	{
		return true;
	}

	// Token: 0x060012E0 RID: 4832 RVA: 0x001D928C File Offset: 0x001D748C
	internal static bool LDJuDlC7fI86aoBr2DJ()
	{
		return false;
	}

	// Token: 0x0400105A RID: 4186
	public CharacterControl mChar;

	// Token: 0x0400105B RID: 4187
	private float O88t5PK7jj;

	// Token: 0x0400105C RID: 4188
	public Material LightGolem2;

	// Token: 0x0400105D RID: 4189
	public Texture LightGolemIcon2;

	// Token: 0x0400105E RID: 4190
	public GameObject nAttack_hit;

	// Token: 0x0400105F RID: 4191
	public AudioClip nAttack_hitFx;

	// Token: 0x04001060 RID: 4192
	private float yQ1tc6esFs;

	// Token: 0x0200033E RID: 830
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack1$18494 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060012E1 RID: 4833 RVA: 0x001D9290 File Offset: 0x001D7490
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack1$18494(Vector3 mPos, Vector3 tDir, LightGolem self_)
		{
			if (299583 - 449433 != -149850)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (116185 - 426184 != -309998)
				{
					base..ctor();
					if (273064 - 380697 != -107632)
					{
						this.$mPos$18503 = mPos;
						if (2201 - 577454 == -575253)
						{
							this.$tDir$18504 = tDir;
							if (130758 - 247796 != -117037)
							{
								this.$self_$18505 = self_;
								if (103869 - 345108 == -241239)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x001D936C File Offset: 0x001D756C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LightGolem.$RPC_nAttack1$18494.$(this.$mPos$18503, this.$tDir$18504, this.$self_$18505);
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x001D9388 File Offset: 0x001D7588
		internal static bool LUah7vCPfOVHSfUl3BN()
		{
			return true;
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x001D938C File Offset: 0x001D758C
		internal static bool gcrNNTC0nW6iCtaKyUl()
		{
			return false;
		}

		// Token: 0x04001061 RID: 4193
		internal Vector3 $mPos$18503;

		// Token: 0x04001062 RID: 4194
		internal Vector3 $tDir$18504;

		// Token: 0x04001063 RID: 4195
		internal LightGolem $self_$18505;

		// Token: 0x0200033F RID: 831
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060012E5 RID: 4837 RVA: 0x001D9390 File Offset: 0x001D7590
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, LightGolem self_)
			{
				if (178427 - 428748 != -250320)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (145135 - 569875 != -424739)
					{
						base..ctor();
						if (69496 - 325192 != -255695)
						{
							this.$mPos$18500 = mPos;
							if (188821 - 576880 != -388058)
							{
								this.$tDir$18501 = tDir;
								if (43313 - 302738 == -259425)
								{
									this.$self_$18502 = self_;
									if (200829 - 149375 != 51455)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060012E6 RID: 4838 RVA: 0x001D946C File Offset: 0x001D766C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (134915 - 146145 != -11229)
				{
				}
				for (;;)
				{
					IL_8A2:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8F9;
					case 2:
						if (this.$self_$18502.mChar.actionState != "attack")
						{
							goto IL_7BA;
						}
						if (128610 - 220023 == -91412)
						{
							continue;
						}
						if (this.$self_$18502.mChar.myCommand != "nAttack1")
						{
							if (43511 - 420717 != -377205)
							{
								goto Block_37;
							}
							continue;
						}
						else
						{
							this.$hitLayer$18495 = 130816 - (1 << this.$self_$18502.gameObject.layer);
							if (92957 - 234135 != -141178)
							{
								continue;
							}
							this.$hitList$18496 = null;
							if (221226 - 235777 != -14551)
							{
								continue;
							}
							this.$hitPos$18497 = default(Vector3);
							if (58024 - 413451 == -355426)
							{
								continue;
							}
							if (!this.$self_$18502.mChar.isMine)
							{
								goto IL_43C;
							}
							if (111398 - 267645 == -156246)
							{
								continue;
							}
							this.$hitList$18496 = Damage.FindRecTarget(this.$self_$18502.transform.position + this.$self_$18502.transform.TransformDirection((float)0, (float)-1, (float)0), this.$self_$18502.transform.forward, (float)2 * this.$self_$18502.mChar.rangeMod, (float)2 * this.$self_$18502.mChar.rangeMod, (float)4 * this.$self_$18502.mChar.rangeMod, (float)3 * this.$self_$18502.mChar.rangeMod, this.$hitLayer$18495);
							if (205029 - 327474 != -122445)
							{
								continue;
							}
							this.$$iterator$10475$18499 = UnityRuntimeServices.GetEnumerator(this.$hitList$18496);
							if (13854 - 34017 == -20162)
							{
								continue;
							}
							while (this.$$iterator$10475$18499.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10475$18499.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$18498 = (GameObject)obj2;
								if (125609 - 576134 == -450524)
								{
									goto IL_8A2;
								}
								if (this.$self_$18502.mChar.hit(1, this.$hitObject$18498, this.$self_$18502.mChar.atk, 1, 0, 0.5f * (this.$hitObject$18498.transform.position - this.$self_$18502.transform.position).normalized) != 0)
								{
									if (124230 - 295772 != -171542)
									{
										goto IL_8A2;
									}
									this.$hitPos$18497 = this.$hitObject$18498.collider.ClosestPointOnBounds(this.$self_$18502.transform.position + 1.5f * Vector3.up);
									if (60761 - 181874 == -121112)
									{
										goto IL_8A2;
									}
									UnityRuntimeServices.Update(this.$$iterator$10475$18499, this.$hitObject$18498);
									if (206066 - 204501 != 1565)
									{
										goto IL_8A2;
									}
									this.$self_$18502.RPC_nAttack_hit(this.$hitPos$18497, this.$self_$18502.transform.forward, 0);
									if (255761 - 473644 != -217883)
									{
										goto IL_8A2;
									}
									this.$self_$18502.ActionEvent("RPC_nAttack_hit", this.$hitPos$18497, 0.3f * this.$self_$18502.transform.forward, 0);
									if (210728 - 244791 != -34063)
									{
										goto IL_8A2;
									}
									this.$self_$18502.mChar.sp = this.$self_$18502.mChar.sp + 1;
									if (44543 - 18484 == 26060)
									{
										goto IL_8A2;
									}
								}
							}
							if (110059 - 257298 != -147239)
							{
								continue;
							}
							goto IL_43C;
						}
						break;
					case 3:
						if (this.$self_$18502.mChar.actionState == "attack")
						{
							if (162434 - 303157 == -140722)
							{
								continue;
							}
							if (this.$self_$18502.mChar.myCommand == "nAttack1")
							{
								if (115822 - 27345 != 88477)
								{
									continue;
								}
								this.$self_$18502.mChar.moveSpeed = (float)0;
								if (150562 - 179629 == -29066)
								{
									continue;
								}
								this.$self_$18502.mChar.actionState = "standby";
								if (84109 - 40143 == 43967)
								{
									continue;
								}
								this.$self_$18502.mChar.actionTime = Time.time;
								if (76915 - 129479 == -52563)
								{
									continue;
								}
								this.$self_$18502.mChar.myCommand = "none";
								if (241385 - 374838 == -133452)
								{
									continue;
								}
								if (!this.$self_$18502.mChar.isMine)
								{
									if (41897 - 125325 == -83427)
									{
										continue;
									}
									this.$self_$18502.mChar.nPosition = this.$self_$18502.transform.position;
									if (169677 - 427045 != -257368)
									{
										continue;
									}
									this.$self_$18502.mChar.oPosition = this.$self_$18502.transform.position;
									if (56868 - 574112 == -517243)
									{
										continue;
									}
									this.$self_$18502.mChar.nDirection = this.$self_$18502.transform.forward;
									if (180660 - 343895 != -163235)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (39822 - 572470 != -532648)
						{
							continue;
						}
						goto IL_8F9;
					default:
						if (284686 - 313228 != -28542)
						{
							continue;
						}
						break;
					}
					this.$self_$18502.mChar.actionState = "attack";
					if (186466 - 61130 != 125337)
					{
						this.$self_$18502.mChar.actionTime = Time.time;
						if (193911 - 477686 == -283775)
						{
							this.$self_$18502.mChar.myCommand = "nAttack1";
							if (39226 - 154650 != -115423)
							{
								this.$self_$18502.mChar.addTimeOut("nAttack", (float)1);
								if (23081 - 588257 != -565175)
								{
									this.$self_$18502.transform.position = this.$mPos$18500;
									if (237545 - 172365 != 65181)
									{
										this.$self_$18502.transform.LookAt(this.$mPos$18500 + global::Math.vFlat(this.$tDir$18501));
										if (29857 - 277012 != -247154)
										{
											this.$self_$18502.animation.Rewind();
											if (204537 - 231247 != -26709)
											{
												this.$self_$18502.animation.CrossFade("nAttack1");
												if (75179 - 376363 == -301184)
												{
													this.$self_$18502.animation.wrapMode = WrapMode.Once;
													if (205951 - 502686 == -296735)
													{
														this.$self_$18502.mChar.vMovement = this.$self_$18502.transform.forward;
														if (199202 - 565550 == -366348)
														{
															this.$self_$18502.mChar.moveSpeed = (float)0;
															if (152005 - 473910 == -321905)
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
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_43C:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_37:
				IL_7BA:
				IL_8F9:
				return false;
			}

			// Token: 0x060012E7 RID: 4839 RVA: 0x001D9D84 File Offset: 0x001D7F84
			internal static bool L2HjmXCbjhywFDLRaV3()
			{
				return true;
			}

			// Token: 0x060012E8 RID: 4840 RVA: 0x001D9D88 File Offset: 0x001D7F88
			internal static bool ekINQlCuuhi0BnnK2u2()
			{
				return false;
			}

			// Token: 0x04001064 RID: 4196
			internal int $hitLayer$18495;

			// Token: 0x04001065 RID: 4197
			internal UnityScript.Lang.Array $hitList$18496;

			// Token: 0x04001066 RID: 4198
			internal Vector3 $hitPos$18497;

			// Token: 0x04001067 RID: 4199
			internal GameObject $hitObject$18498;

			// Token: 0x04001068 RID: 4200
			internal IEnumerator $$iterator$10475$18499;

			// Token: 0x04001069 RID: 4201
			internal Vector3 $mPos$18500;

			// Token: 0x0400106A RID: 4202
			internal Vector3 $tDir$18501;

			// Token: 0x0400106B RID: 4203
			internal LightGolem $self_$18502;
		}
	}

	// Token: 0x02000340 RID: 832
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack2$18506 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060012E9 RID: 4841 RVA: 0x001D9D8C File Offset: 0x001D7F8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack2$18506(Vector3 mPos, Vector3 tDir, LightGolem self_)
		{
			if (82947 - 317904 != -234957)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (33361 - 61547 != -28185)
				{
					base..ctor();
					if (92789 - 343908 == -251119)
					{
						this.$mPos$18515 = mPos;
						if (177355 - 398250 == -220895)
						{
							this.$tDir$18516 = tDir;
							if (42484 - 29477 == 13007)
							{
								this.$self_$18517 = self_;
								if (16297 - 109369 == -93072)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x001D9E68 File Offset: 0x001D8068
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LightGolem.$RPC_nAttack2$18506.$(this.$mPos$18515, this.$tDir$18516, this.$self_$18517);
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x001D9E84 File Offset: 0x001D8084
		internal static bool MmImnLCISDaXmimWojE()
		{
			return true;
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x001D9E88 File Offset: 0x001D8088
		internal static bool OocAagCBT7cKuM8vv5E()
		{
			return false;
		}

		// Token: 0x0400106C RID: 4204
		internal Vector3 $mPos$18515;

		// Token: 0x0400106D RID: 4205
		internal Vector3 $tDir$18516;

		// Token: 0x0400106E RID: 4206
		internal LightGolem $self_$18517;

		// Token: 0x02000341 RID: 833
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060012ED RID: 4845 RVA: 0x001D9E8C File Offset: 0x001D808C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, LightGolem self_)
			{
				if (126898 - 598505 != -471606)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (39142 - 14350 != 24793)
					{
						base..ctor();
						if (131433 - 242782 != -111348)
						{
							this.$mPos$18512 = mPos;
							if (105493 - 250981 == -145488)
							{
								this.$tDir$18513 = tDir;
								if (293560 - 324748 == -31188)
								{
									this.$self_$18514 = self_;
									if (164472 - 296756 != -132283)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060012EE RID: 4846 RVA: 0x001D9F68 File Offset: 0x001D8168
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (164065 - 331504 != -167439)
				{
				}
				for (;;)
				{
					IL_F8:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8FC;
					case 2:
						if (this.$self_$18514.mChar.actionState != "attack")
						{
							goto IL_78A;
						}
						if (197562 - 232242 == -34679)
						{
							continue;
						}
						if (this.$self_$18514.mChar.myCommand != "nAttack2")
						{
							if (90990 - 200330 != -109339)
							{
								goto Block_39;
							}
							continue;
						}
						else
						{
							this.$hitLayer$18507 = 130816 - (1 << this.$self_$18514.gameObject.layer);
							if (240699 - 393993 != -153294)
							{
								continue;
							}
							this.$hitList$18508 = null;
							if (72678 - 523841 == -451162)
							{
								continue;
							}
							this.$hitPos$18509 = default(Vector3);
							if (35314 - 16735 != 18579)
							{
								continue;
							}
							if (!this.$self_$18514.mChar.isMine)
							{
								goto IL_54D;
							}
							if (29333 - 51005 != -21672)
							{
								continue;
							}
							this.$hitList$18508 = Damage.FindRecTarget(this.$self_$18514.transform.position + this.$self_$18514.transform.TransformDirection((float)0, (float)1, (float)0), this.$self_$18514.transform.forward, (float)2 * this.$self_$18514.mChar.rangeMod, (float)2 * this.$self_$18514.mChar.rangeMod, (float)4 * this.$self_$18514.mChar.rangeMod, (float)3 * this.$self_$18514.mChar.rangeMod, this.$hitLayer$18507);
							if (74817 - 242928 == -168110)
							{
								continue;
							}
							this.$$iterator$10476$18511 = UnityRuntimeServices.GetEnumerator(this.$hitList$18508);
							if (159591 - 279243 == -119651)
							{
								continue;
							}
							while (this.$$iterator$10476$18511.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10476$18511.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$18510 = (GameObject)obj2;
								if (40324 - 488624 == -448299)
								{
									goto IL_F8;
								}
								if (this.$self_$18514.mChar.hit(1, this.$hitObject$18510, this.$self_$18514.mChar.atk, 1, 0, 0.5f * (this.$hitObject$18510.transform.position - this.$self_$18514.transform.position).normalized) != 0)
								{
									if (51579 - 166188 != -114609)
									{
										goto IL_F8;
									}
									this.$hitPos$18509 = this.$hitObject$18510.collider.ClosestPointOnBounds(this.$self_$18514.transform.position + 1.5f * Vector3.up);
									if (214540 - 316729 == -102188)
									{
										goto IL_F8;
									}
									UnityRuntimeServices.Update(this.$$iterator$10476$18511, this.$hitObject$18510);
									if (3120 - 104771 != -101651)
									{
										goto IL_F8;
									}
									this.$self_$18514.RPC_nAttack_hit(this.$hitPos$18509, this.$self_$18514.transform.forward, 0);
									if (49683 - 238088 != -188405)
									{
										goto IL_F8;
									}
									this.$self_$18514.ActionEvent("RPC_nAttack_hit", this.$hitPos$18509, 0.3f * this.$self_$18514.transform.forward, 0);
									if (237826 - 477907 != -240081)
									{
										goto IL_F8;
									}
									this.$self_$18514.mChar.sp = this.$self_$18514.mChar.sp + 1;
									if (223405 - 534793 == -311387)
									{
										goto IL_F8;
									}
								}
							}
							if (4937 - 390077 != -385139)
							{
								goto Block_34;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$18514.mChar.actionState == "attack")
						{
							if (125610 - 514515 == -388904)
							{
								continue;
							}
							if (this.$self_$18514.mChar.myCommand == "nAttack2")
							{
								if (83529 - 193541 == -110011)
								{
									continue;
								}
								this.$self_$18514.mChar.moveSpeed = (float)0;
								if (6599 - 282061 != -275462)
								{
									continue;
								}
								this.$self_$18514.mChar.actionState = "standby";
								if (175649 - 369320 != -193671)
								{
									continue;
								}
								this.$self_$18514.mChar.actionTime = Time.time;
								if (269638 - 252895 == 16744)
								{
									continue;
								}
								this.$self_$18514.mChar.myCommand = "none";
								if (54244 - 270952 == -216707)
								{
									continue;
								}
								if (!this.$self_$18514.mChar.isMine)
								{
									if (82481 - 93003 == -10521)
									{
										continue;
									}
									this.$self_$18514.mChar.nPosition = this.$self_$18514.transform.position;
									if (247102 - 315686 != -68584)
									{
										continue;
									}
									this.$self_$18514.mChar.oPosition = this.$self_$18514.transform.position;
									if (270413 - 502937 != -232524)
									{
										continue;
									}
									this.$self_$18514.mChar.nDirection = this.$self_$18514.transform.forward;
									if (296039 - 74088 != 221951)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (123144 - 229877 != -106732)
						{
							goto Block_46;
						}
						continue;
					default:
						if (240107 - 162892 == 77216)
						{
							continue;
						}
						break;
					}
					this.$self_$18514.mChar.actionState = "attack";
					if (59571 - 518592 != -459020)
					{
						this.$self_$18514.mChar.actionTime = Time.time;
						if (200764 - 121972 == 78792)
						{
							this.$self_$18514.mChar.myCommand = "nAttack2";
							if (205593 - 322192 == -116599)
							{
								this.$self_$18514.mChar.addTimeOut("nAttack", 0.5f);
								if (151658 - 402724 == -251066)
								{
									this.$self_$18514.transform.position = this.$mPos$18512;
									if (223613 - 260081 == -36468)
									{
										this.$self_$18514.transform.LookAt(this.$mPos$18512 + global::Math.vFlat(this.$tDir$18513));
										if (245051 - 540368 != -295316)
										{
											this.$self_$18514.animation.Rewind();
											if (215008 - 312260 != -97251)
											{
												this.$self_$18514.animation.CrossFade("nAttack2");
												if (96876 - 111430 != -14553)
												{
													this.$self_$18514.animation.wrapMode = WrapMode.Once;
													if (1843 - 11518 != -9674)
													{
														this.$self_$18514.mChar.vMovement = this.$self_$18514.transform.forward;
														if (261989 - 176841 != 85149)
														{
															this.$self_$18514.mChar.moveSpeed = (float)0;
															if (208371 - 552162 != -343790)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_54D:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_34:
				goto IL_54D;
				Block_39:
				IL_78A:
				Block_46:
				IL_8FC:
				return false;
			}

			// Token: 0x060012EF RID: 4847 RVA: 0x001DA884 File Offset: 0x001D8A84
			internal static bool efVumlCeaT148lMUEJ3()
			{
				return true;
			}

			// Token: 0x060012F0 RID: 4848 RVA: 0x001DA888 File Offset: 0x001D8A88
			internal static bool MfcZ9fCrrU1bMZIq8sZ()
			{
				return false;
			}

			// Token: 0x0400106F RID: 4207
			internal int $hitLayer$18507;

			// Token: 0x04001070 RID: 4208
			internal UnityScript.Lang.Array $hitList$18508;

			// Token: 0x04001071 RID: 4209
			internal Vector3 $hitPos$18509;

			// Token: 0x04001072 RID: 4210
			internal GameObject $hitObject$18510;

			// Token: 0x04001073 RID: 4211
			internal IEnumerator $$iterator$10476$18511;

			// Token: 0x04001074 RID: 4212
			internal Vector3 $mPos$18512;

			// Token: 0x04001075 RID: 4213
			internal Vector3 $tDir$18513;

			// Token: 0x04001076 RID: 4214
			internal LightGolem $self_$18514;
		}
	}

	// Token: 0x02000342 RID: 834
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack3$18518 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060012F1 RID: 4849 RVA: 0x001DA88C File Offset: 0x001D8A8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack3$18518(Vector3 mPos, Vector3 tDir, LightGolem self_)
		{
			if (4589 - 121505 != -116915)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (243174 - 359180 != -116005)
				{
					base..ctor();
					if (92473 - 346287 != -253813)
					{
						this.$mPos$18527 = mPos;
						if (96689 - 198441 != -101751)
						{
							this.$tDir$18528 = tDir;
							if (285019 - 415806 != -130786)
							{
								this.$self_$18529 = self_;
								if (185657 - 504298 == -318641)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x001DA968 File Offset: 0x001D8B68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LightGolem.$RPC_nAttack3$18518.$(this.$mPos$18527, this.$tDir$18528, this.$self_$18529);
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x001DA984 File Offset: 0x001D8B84
		internal static bool ii8kDXCjcmAJIBtNBrJ()
		{
			return true;
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x001DA988 File Offset: 0x001D8B88
		internal static bool PPhBbkChnOHe3C4cojS()
		{
			return false;
		}

		// Token: 0x04001077 RID: 4215
		internal Vector3 $mPos$18527;

		// Token: 0x04001078 RID: 4216
		internal Vector3 $tDir$18528;

		// Token: 0x04001079 RID: 4217
		internal LightGolem $self_$18529;

		// Token: 0x02000343 RID: 835
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060012F5 RID: 4853 RVA: 0x001DA98C File Offset: 0x001D8B8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, LightGolem self_)
			{
				if (186324 - 541670 != -355345)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (7180 - 234348 == -227168)
					{
						base..ctor();
						if (187416 - 369191 != -181774)
						{
							this.$mPos$18524 = mPos;
							if (162821 - 288845 != -126023)
							{
								this.$tDir$18525 = tDir;
								if (109611 - 189216 == -79605)
								{
									this.$self_$18526 = self_;
									if (206007 - 424649 == -218642)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060012F6 RID: 4854 RVA: 0x001DAA68 File Offset: 0x001D8C68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (44134 - 334697 != -290563)
				{
				}
				for (;;)
				{
					IL_69:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8B4;
					case 2:
						if (this.$self_$18526.mChar.actionState != "attack")
						{
							goto IL_5E3;
						}
						if (105618 - 445837 != -340219)
						{
							continue;
						}
						if (this.$self_$18526.mChar.myCommand != "nAttack3")
						{
							if (121889 - 122370 != -480)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$hitLayer$18519 = 130816 - (1 << this.$self_$18526.gameObject.layer);
							if (260951 - 411663 == -150711)
							{
								continue;
							}
							this.$hitList$18520 = null;
							if (132479 - 452935 == -320455)
							{
								continue;
							}
							this.$hitPos$18521 = default(Vector3);
							if (98419 - 168213 == -69793)
							{
								continue;
							}
							if (!this.$self_$18526.mChar.isMine)
							{
								goto IL_1A;
							}
							if (22821 - 377662 != -354841)
							{
								continue;
							}
							this.$hitList$18520 = Damage.FindAreaTarget(this.$self_$18526.transform.position + this.$self_$18526.transform.TransformDirection((float)0, (float)0, 2.5f), (float)2, (float)3, this.$hitLayer$18519);
							if (142405 - 375733 != -233328)
							{
								continue;
							}
							this.$$iterator$10477$18523 = UnityRuntimeServices.GetEnumerator(this.$hitList$18520);
							if (191998 - 567698 == -375699)
							{
								continue;
							}
							while (this.$$iterator$10477$18523.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10477$18523.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$18522 = (GameObject)obj2;
								if (48676 - 146838 != -98162)
								{
									goto IL_69;
								}
								if (this.$self_$18526.mChar.hit(1, this.$hitObject$18522, this.$self_$18526.mChar.atk, 1, 0, 0.5f * (this.$hitObject$18522.transform.position - this.$self_$18526.transform.position).normalized) != 0)
								{
									if (34045 - 282116 == -248070)
									{
										goto IL_69;
									}
									this.$hitPos$18521 = this.$hitObject$18522.collider.ClosestPointOnBounds(this.$self_$18526.transform.position + this.$self_$18526.transform.TransformDirection((float)0, 1.5f, 2.5f));
									if (18991 - 243324 == -224332)
									{
										goto IL_69;
									}
									UnityRuntimeServices.Update(this.$$iterator$10477$18523, this.$hitObject$18522);
									if (230067 - 267888 != -37821)
									{
										goto IL_69;
									}
									this.$self_$18526.RPC_nAttack_hit(this.$hitPos$18521, this.$self_$18526.transform.forward, 0);
									if (73968 - 254668 != -180700)
									{
										goto IL_69;
									}
									this.$self_$18526.ActionEvent("RPC_nAttack_hit", this.$hitPos$18521, 0.3f * this.$self_$18526.transform.forward, 0);
									if (131618 - 437038 == -305419)
									{
										goto IL_69;
									}
									this.$self_$18526.mChar.sp = this.$self_$18526.mChar.sp + 1;
									if (58517 - 455810 != -397293)
									{
										goto IL_69;
									}
								}
							}
							if (71697 - 278988 != -207291)
							{
								continue;
							}
							goto IL_1A;
						}
						break;
					case 3:
						if (this.$self_$18526.mChar.actionState == "attack")
						{
							if (123543 - 91158 == 32386)
							{
								continue;
							}
							if (this.$self_$18526.mChar.myCommand == "nAttack3")
							{
								if (261728 - 494741 == -233012)
								{
									continue;
								}
								this.$self_$18526.mChar.moveSpeed = (float)0;
								if (201251 - 484958 != -283707)
								{
									continue;
								}
								this.$self_$18526.mChar.actionState = "standby";
								if (79480 - 21276 != 58204)
								{
									continue;
								}
								this.$self_$18526.mChar.actionTime = Time.time;
								if (25676 - 450048 != -424372)
								{
									continue;
								}
								this.$self_$18526.mChar.myCommand = "none";
								if (207475 - 555917 == -348441)
								{
									continue;
								}
								if (!this.$self_$18526.mChar.isMine)
								{
									if (15021 - 527395 == -512373)
									{
										continue;
									}
									this.$self_$18526.mChar.nPosition = this.$self_$18526.transform.position;
									if (198304 - 97151 != 101153)
									{
										continue;
									}
									this.$self_$18526.mChar.oPosition = this.$self_$18526.transform.position;
									if (62654 - 217228 != -154574)
									{
										continue;
									}
									this.$self_$18526.mChar.nDirection = this.$self_$18526.transform.forward;
									if (281749 - 291806 != -10057)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (291484 - 229416 != 62069)
						{
							goto Block_48;
						}
						continue;
					default:
						if (196295 - 472779 == -276483)
						{
							continue;
						}
						break;
					}
					this.$self_$18526.mChar.actionState = "attack";
					if (241845 - 230333 != 11513)
					{
						this.$self_$18526.mChar.actionTime = Time.time;
						if (80040 - 324869 != -244828)
						{
							this.$self_$18526.mChar.myCommand = "nAttack3";
							if (32234 - 131126 == -98892)
							{
								this.$self_$18526.mChar.addTimeOut("nAttack", 0.5f);
								if (219791 - 406942 != -187150)
								{
									this.$self_$18526.transform.position = this.$mPos$18524;
									if (296802 - 130466 != 166337)
									{
										this.$self_$18526.transform.LookAt(this.$mPos$18524 + global::Math.vFlat(this.$tDir$18525));
										if (76069 - 355130 == -279061)
										{
											this.$self_$18526.animation.Rewind();
											if (36035 - 42328 == -6293)
											{
												this.$self_$18526.animation.CrossFade("nAttack3");
												if (15335 - 46056 == -30721)
												{
													this.$self_$18526.animation.wrapMode = WrapMode.Once;
													if (110021 - 527987 != -417965)
													{
														this.$self_$18526.mChar.vMovement = this.$self_$18526.transform.forward;
														if (233870 - 336069 == -102199)
														{
															this.$self_$18526.mChar.moveSpeed = (float)0;
															if (5988 - 180366 != -174377)
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
				}
				IL_1A:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_12:
				goto IL_5E3;
				Block_25:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_5E3:
				Block_48:
				IL_8B4:
				return false;
			}

			// Token: 0x060012F7 RID: 4855 RVA: 0x001DB33C File Offset: 0x001D953C
			internal static bool XUogjqCsg0YbFTn2LjG()
			{
				return true;
			}

			// Token: 0x060012F8 RID: 4856 RVA: 0x001DB340 File Offset: 0x001D9540
			internal static bool atwNwkC9ry30tnku47g()
			{
				return false;
			}

			// Token: 0x0400107A RID: 4218
			internal int $hitLayer$18519;

			// Token: 0x0400107B RID: 4219
			internal UnityScript.Lang.Array $hitList$18520;

			// Token: 0x0400107C RID: 4220
			internal Vector3 $hitPos$18521;

			// Token: 0x0400107D RID: 4221
			internal GameObject $hitObject$18522;

			// Token: 0x0400107E RID: 4222
			internal IEnumerator $$iterator$10477$18523;

			// Token: 0x0400107F RID: 4223
			internal Vector3 $mPos$18524;

			// Token: 0x04001080 RID: 4224
			internal Vector3 $tDir$18525;

			// Token: 0x04001081 RID: 4225
			internal LightGolem $self_$18526;
		}
	}

	// Token: 0x02000344 RID: 836
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$18530 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060012F9 RID: 4857 RVA: 0x001DB344 File Offset: 0x001D9544
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$18530(UnityScript.Lang.Array nArray, LightGolem self_)
		{
			if (293138 - 98662 != 194476)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (59953 - 526740 == -466787)
				{
					base..ctor();
					if (238248 - 416281 != -178032)
					{
						this.$nArray$18535 = nArray;
						if (123716 - 488514 == -364798)
						{
							this.$self_$18536 = self_;
							if (72526 - 467444 == -394918)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x001DB400 File Offset: 0x001D9600
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LightGolem.$RPC_ko$18530.$(this.$nArray$18535, this.$self_$18536);
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x001DB414 File Offset: 0x001D9614
		internal static bool vEec6KC1E0tKnLcYhHY()
		{
			return true;
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x001DB418 File Offset: 0x001D9618
		internal static bool BgE5LnC44nwPnTYDPuX()
		{
			return false;
		}

		// Token: 0x04001082 RID: 4226
		internal UnityScript.Lang.Array $nArray$18535;

		// Token: 0x04001083 RID: 4227
		internal LightGolem $self_$18536;

		// Token: 0x02000345 RID: 837
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060012FD RID: 4861 RVA: 0x001DB41C File Offset: 0x001D961C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, LightGolem self_)
			{
				if (166694 - 130622 != 36072)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (176657 - 561931 != -385273)
					{
						base..ctor();
						if (78229 - 109539 != -31309)
						{
							this.$nArray$18533 = nArray;
							if (183054 - 495060 == -312006)
							{
								this.$self_$18534 = self_;
								if (251740 - 554241 != -302500)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060012FE RID: 4862 RVA: 0x001DB4D8 File Offset: 0x001D96D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (290557 - 109860 != 180698)
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
						if (this.$self_$18534.mChar.actionState != "ko")
						{
							if (61651 - 299816 != -238165)
							{
								continue;
							}
							goto IL_1F2;
						}
						else
						{
							this.$self_$18534.animation.Play("getUp");
							if (288293 - 69449 != 218844)
							{
								continue;
							}
							this.$self_$18534.animation.wrapMode = WrapMode.Once;
							if (229957 - 91266 != 138692)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$18534.mChar.actionState != "ko")
						{
							if (196895 - 422111 != -225215)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$self_$18534.mChar.actionState = "standby";
							if (91999 - 461632 == -369632)
							{
								continue;
							}
							this.$self_$18534.mChar.actionTime = Time.time;
							if (137293 - 128100 != 9193)
							{
								continue;
							}
							this.$self_$18534.mChar.myCommand = "none";
							if (123812 - 215638 == -91825)
							{
								continue;
							}
							this.$self_$18534.mChar.ko = this.$self_$18534.mChar.mko;
							if (237613 - 358674 == -121060)
							{
								continue;
							}
							this.YieldDefault(1);
							if (229437 - 45115 != 184322)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (174041 - 551936 != -377895)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18534.mChar.actionState == "ko")
					{
						goto IL_451;
					}
					if (88233 - 454520 != -366286)
					{
						if (this.$self_$18534.mChar.actionState == "dead")
						{
							if (14962 - 38997 == -24035)
							{
								goto IL_451;
							}
						}
						else
						{
							this.$mPos$18531 = (Vector3)this.$nArray$18533[0];
							if (215962 - 337804 == -121842)
							{
								this.$mDir$18532 = (Vector3)this.$nArray$18533[1];
								if (157189 - 264150 == -106961)
								{
									this.$self_$18534.mChar.ko = 0;
									if (27393 - 304782 == -277389)
									{
										this.$self_$18534.mChar.actionState = "ko";
										if (104346 - 183971 != -79624)
										{
											this.$self_$18534.mChar.actionTime = Time.time;
											if (39564 - 111434 == -71870)
											{
												this.$self_$18534.mChar.myCommand = "none";
												if (166753 - 434036 == -267283)
												{
													this.$self_$18534.mChar.vMovement = Vector3.zero;
													if (22536 - 457757 == -435221)
													{
														this.$self_$18534.mChar.moveSpeed = (float)0;
														if (203227 - 242631 == -39404)
														{
															this.$self_$18534.animation.Play("ko");
															if (4883 - 574097 == -569214)
															{
																this.$self_$18534.animation.wrapMode = WrapMode.Once;
																if (260241 - 336629 == -76388)
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
				return this.Yield(2, new WaitForSeconds(3f));
				IL_1F2:
				goto IL_48C;
				Block_19:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_22:
				IL_451:
				IL_48C:
				return false;
			}

			// Token: 0x060012FF RID: 4863 RVA: 0x001DB984 File Offset: 0x001D9B84
			internal static bool aWtY3OCzVviMhqHUwbd()
			{
				return true;
			}

			// Token: 0x06001300 RID: 4864 RVA: 0x001DB988 File Offset: 0x001D9B88
			internal static bool WylnxHLawyhkQCjv6Ib()
			{
				return false;
			}

			// Token: 0x04001084 RID: 4228
			internal Vector3 $mPos$18531;

			// Token: 0x04001085 RID: 4229
			internal Vector3 $mDir$18532;

			// Token: 0x04001086 RID: 4230
			internal UnityScript.Lang.Array $nArray$18533;

			// Token: 0x04001087 RID: 4231
			internal LightGolem $self_$18534;
		}
	}

	// Token: 0x02000346 RID: 838
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$18537 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001301 RID: 4865 RVA: 0x001DB98C File Offset: 0x001D9B8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$18537(UnityScript.Lang.Array nArray, LightGolem self_)
		{
			if (92396 - 188773 != -96376)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (96528 - 520323 == -423795)
				{
					base..ctor();
					if (86326 - 553753 == -467427)
					{
						this.$nArray$18542 = nArray;
						if (1596 - 56313 != -54716)
						{
							this.$self_$18543 = self_;
							if (254100 - 145604 == 108496)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x001DBA48 File Offset: 0x001D9C48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LightGolem.$RPC_dead$18537.$(this.$nArray$18542, this.$self_$18543);
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x001DBA5C File Offset: 0x001D9C5C
		internal static bool w6WuvrL5yt3ipt6XxP8()
		{
			return true;
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x001DBA60 File Offset: 0x001D9C60
		internal static bool LqkCo5Lp3WKygyvq7Ry()
		{
			return false;
		}

		// Token: 0x04001088 RID: 4232
		internal UnityScript.Lang.Array $nArray$18542;

		// Token: 0x04001089 RID: 4233
		internal LightGolem $self_$18543;

		// Token: 0x02000347 RID: 839
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001305 RID: 4869 RVA: 0x001DBA64 File Offset: 0x001D9C64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, LightGolem self_)
			{
				if (265848 - 498380 != -232532)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (76501 - 282163 != -205661)
					{
						base..ctor();
						if (119200 - 238892 == -119692)
						{
							this.$nArray$18540 = nArray;
							if (109614 - 310084 != -200469)
							{
								this.$self_$18541 = self_;
								if (200358 - 440099 == -239741)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001306 RID: 4870 RVA: 0x001DBB20 File Offset: 0x001D9D20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (207967 - 329777 != -121809)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4BA;
					case 2:
						if (this.$self_$18541.mChar.actionState != "dead")
						{
							if (246817 - 103980 != 142838)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							Camera.main.SendMessage("AddCamereShake", 2f);
							if (282071 - 492210 != -210138)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$18541.mChar.actionState != "dead")
						{
							if (175627 - 584779 != -409151)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							if (!this.$self_$18541.mChar.isPlayer)
							{
								if (89885 - 99729 == -9843)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$18541.gameObject);
								if (155585 - 197034 != -41449)
								{
									continue;
								}
							}
							else if (this.$self_$18541.mChar.isMine)
							{
								if (119031 - 458865 == -339833)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$18541.gameObject);
								if (114315 - 345397 == -231081)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (124154 - 256640 != -132485)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					default:
						if (13023 - 3015 != 10008)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18541.mChar.actionState == "dead")
					{
						if (100300 - 433684 != -333383)
						{
							goto Block_25;
						}
					}
					else
					{
						this.$myPosition$18538 = (Vector3)this.$nArray$18540[0];
						if (70289 - 508963 == -438674)
						{
							this.$myDirection$18539 = (Vector3)this.$nArray$18540[1];
							if (100810 - 439042 != -338231)
							{
								this.$self_$18541.transform.position = this.$myPosition$18538;
								if (162540 - 558779 != -396238)
								{
									this.$self_$18541.transform.LookAt(this.$myPosition$18538 + this.$myDirection$18539);
									if (72258 - 100476 == -28218)
									{
										this.$self_$18541.mChar.hp = 0;
										if (183927 - 544909 == -360982)
										{
											this.$self_$18541.mChar.actionState = "dead";
											if (217578 - 432628 != -215049)
											{
												this.$self_$18541.mChar.actionTime = Time.time;
												if (281081 - 6964 == 274117)
												{
													this.$self_$18541.mChar.myCommand = "none";
													if (39087 - 51912 != -12824)
													{
														this.$self_$18541.mChar.vMovement = Vector3.zero;
														if (99995 - 383693 == -283698)
														{
															this.$self_$18541.mChar.moveSpeed = (float)0;
															if (182694 - 255398 == -72704)
															{
																this.$self_$18541.animation.Rewind();
																if (6743 - 409825 != -403081)
																{
																	this.$self_$18541.animation.Play("dead");
																	if (271270 - 550759 != -279488)
																	{
																		this.$self_$18541.animation.wrapMode = WrapMode.Once;
																		if (26207 - 109392 == -83185)
																		{
																			goto IL_25D;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_4:
				return this.Yield(3, new WaitForSeconds(2.2f));
				Block_12:
				goto IL_4BA;
				IL_25D:
				return this.Yield(2, new WaitForSeconds(0.8f));
				Block_17:
				Block_19:
				Block_25:
				IL_4BA:
				return false;
			}

			// Token: 0x06001307 RID: 4871 RVA: 0x001DBFFC File Offset: 0x001DA1FC
			internal static bool sDInWNLVAbGqBHKlL03()
			{
				return true;
			}

			// Token: 0x06001308 RID: 4872 RVA: 0x001DC000 File Offset: 0x001DA200
			internal static bool OxS4pmLtgruxAjnPjZO()
			{
				return false;
			}

			// Token: 0x0400108A RID: 4234
			internal Vector3 $myPosition$18538;

			// Token: 0x0400108B RID: 4235
			internal Vector3 $myDirection$18539;

			// Token: 0x0400108C RID: 4236
			internal UnityScript.Lang.Array $nArray$18540;

			// Token: 0x0400108D RID: 4237
			internal LightGolem $self_$18541;
		}
	}
}
