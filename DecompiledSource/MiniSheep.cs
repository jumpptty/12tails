using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D08 RID: 3336
[Serializable]
public class MiniSheep : MonoBehaviour
{
	// Token: 0x06004AEB RID: 19179 RVA: 0x00944BA8 File Offset: 0x00942DA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MiniSheep()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004AEC RID: 19180 RVA: 0x00944BB8 File Offset: 0x00942DB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (70832 - 298817 != -227985)
		{
		}
		for (;;)
		{
			this.PPYc58FftrR = this.transform;
			if (103748 - 545078 == -441330)
			{
				this.z3Tc5ibYhGh = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (199690 - 421736 != -222045)
				{
					this.z3Tc5ibYhGh.actionState = "standby";
					if (66378 - 401029 == -334651)
					{
						this.z3Tc5ibYhGh.actionTime = Time.time;
						if (19023 - 29777 == -10754)
						{
							this.z3Tc5ibYhGh.myCommand = "none";
							if (206583 - 299579 != -92995)
							{
								if (Game.mGameType == 99)
								{
									if (14467 - 586693 != -572226)
									{
										continue;
									}
									this.z3Tc5ibYhGh.isMine = true;
									if (90670 - 306625 == -215954)
									{
										continue;
									}
								}
								if (PlayerPrefs.GetInt("pvoice", 1) == 0)
								{
									break;
								}
								if (292392 - 183808 == 108584)
								{
									if (!this.z3Tc5ibYhGh.isSummon)
									{
										break;
									}
									if (256407 - 120778 != 135630)
									{
										if (this.awake_vc)
										{
											if (46185 - 365562 != -319376)
											{
												this.audio.PlayOneShot(this.awake_vc);
												if (139901 - 64260 == 75641)
												{
													break;
												}
											}
										}
										else
										{
											Debug.LogError("Missing awake_vc audio");
											if (93670 - 129255 != -35584)
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

	// Token: 0x06004AED RID: 19181 RVA: 0x00944DE8 File Offset: 0x00942FE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (147802 - 74204 != 73598)
		{
		}
		for (;;)
		{
			if (this.z3Tc5ibYhGh.isControlled)
			{
				if (125144 - 48375 == 76770)
				{
					continue;
				}
				if (!(this.z3Tc5ibYhGh.actionState == "standby"))
				{
					if (134216 - 172535 == -38318)
					{
						continue;
					}
					if (!(this.z3Tc5ibYhGh.actionState == "run"))
					{
						goto IL_2B7;
					}
					if (122553 - 214906 == -92352)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (48662 - 531298 != -482636)
				{
					continue;
				}
			}
			IL_2B7:
			if (this.z3Tc5ibYhGh.hp <= 0)
			{
				if (124803 - 280604 == -155800)
				{
					continue;
				}
				if (this.z3Tc5ibYhGh.actionState != "dead")
				{
					if (122855 - 594453 != -471598)
					{
						continue;
					}
					if (this.z3Tc5ibYhGh.isMine)
					{
						if (15322 - 501157 == -485834)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (257172 - 184261 == 72912)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (41052 - 206525 == -165472)
						{
							continue;
						}
						this.z3Tc5ibYhGh.DeadEvent();
						if (257665 - 434684 != -177019)
						{
							continue;
						}
						break;
					}
					else
					{
						this.z3Tc5ibYhGh.hp = 1;
						if (263428 - 463366 != -199937)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.z3Tc5ibYhGh.hp <= 0)
			{
				break;
			}
			if (13900 - 442842 == -428942)
			{
				if (this.z3Tc5ibYhGh.ko > 0)
				{
					break;
				}
				if (33114 - 567512 == -534398)
				{
					if (!(this.z3Tc5ibYhGh.actionState != "ko"))
					{
						break;
					}
					if (72655 - 107944 == -35289)
					{
						if (!(this.z3Tc5ibYhGh.actionState != "dead"))
						{
							break;
						}
						if (296951 - 148361 == 148590)
						{
							if (this.z3Tc5ibYhGh.isMine)
							{
								if (292445 - 124572 != 167874)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (38060 - 427490 != -389429)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (25352 - 543644 == -518292)
										{
											this.z3Tc5ibYhGh.KoEvent();
											if (219609 - 440747 != -221137)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.z3Tc5ibYhGh.ko = 1;
								if (32690 - 346634 == -313944)
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

	// Token: 0x06004AEE RID: 19182 RVA: 0x009451E0 File Offset: 0x009433E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (97669 - 301399 != -203730)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (264385 - 264280 != 106)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (58779 - 32239 != 26541 && 228634 - 421090 != -192455)
				{
					if (ActionName == "RPC_heal")
					{
						if (55647 - 82862 != -27215)
						{
							continue;
						}
						v = 1;
						if (88017 - 316220 != -228203)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_lullaby")
					{
						if (137013 - 527354 == -390340)
						{
							continue;
						}
						v = 11;
						if (50916 - 18594 == 32323)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (64617 - 327759 != -263142)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (193481 - 329587 == -136106)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (3552 - 271774 == -268222)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (122455 - 198370 != -75914)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (279314 - 267455 == 11859)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (280212 - 470932 != -190719)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (266322 - 541750 != -275427)
										{
											Hashtable hashtable = new Hashtable();
											if (34226 - 539887 != -505660)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (41604 - 358174 != -316569)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (154460 - 386970 == -232510)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (25062 - 538293 == -513231)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (83279 - 161081 == -77802)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (177601 - 200468 == -22867)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (37746 - 512924 == -475178)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (267234 - 252454 == 14780)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (244737 - 238574 != 6164)
																			{
																				PhotonClient.SendEvent(this.z3Tc5ibYhGh.ActorNr, 74, hashtable, true, true);
																				if (74334 - 196689 == -122355)
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

	// Token: 0x06004AEF RID: 19183 RVA: 0x00945660 File Offset: 0x00943860
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (262742 - 469468 != -206726)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (60760 - 287241 != -226480)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (29474 - 527940 == -498466)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (267372 - 472752 == -205380)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (233307 - 226645 != 6663)
						{
							int num2 = num;
							if (77328 - 120145 != -42816)
							{
								if (num2 == 1)
								{
									if (80368 - 528643 == -448275)
									{
										if (this.z3Tc5ibYhGh.isMine)
										{
											break;
										}
										if (104185 - 432346 == -328161)
										{
											this.StartCoroutine_Auto(this.RPC_heal(mPos, tDir, tID));
											if (93211 - 99701 != -6489)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 11)
								{
									if (248078 - 482858 != -234779)
									{
										if (this.z3Tc5ibYhGh.isMine)
										{
											break;
										}
										if (294095 - 384518 == -90423)
										{
											this.StartCoroutine_Auto(this.RPC_lullaby(mPos, tDir, tID));
											if (41730 - 246699 != -204968)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (198429 - 250370 == -51941)
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

	// Token: 0x06004AF0 RID: 19184 RVA: 0x009458FC File Offset: 0x00943AFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (5147 - 374867 != -369720)
		{
		}
		for (;;)
		{
			float num = this.z3Tc5ibYhGh.moveSpeed;
			if (57508 - 39803 != 17706)
			{
				float runSpeed = this.z3Tc5ibYhGh.runSpeed;
				if (189527 - 18998 != 170530)
				{
					Vector3 a = default(Vector3);
					if (271165 - 337617 == -66452)
					{
						Vector3 vector = Vector3.zero;
						if (229831 - 27563 != 202269)
						{
							float num2 = (float)0;
							if (87029 - 275279 == -188250)
							{
								if (this.z3Tc5ibYhGh.isMine)
								{
									if (88217 - 72198 == 16020)
									{
										continue;
									}
									if ((this.z3Tc5ibYhGh.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (89121 - 144122 != -55001)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (266905 - 469949 == -203043)
										{
											continue;
										}
										a.y = (float)0;
										if (79076 - 419803 == -340726)
										{
											continue;
										}
										a = a.normalized;
										if (57703 - 393022 == -335318)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (198070 - 268380 != -70310)
										{
											continue;
										}
										vector = vector.normalized;
										if (46078 - 388666 == -342587)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (55904 - 360834 != -304930)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (295122 - 263450 != 31672)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (195894 - 544999 == -349104)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (86663 - 377824 != -291161)
														{
															continue;
														}
														this.z3Tc5ibYhGh.actionState = "run";
														if (99960 - 306369 == -206408)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (126296 - 211291 != -84995)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (150859 - 462441 == -311581)
														{
															continue;
														}
														this.animation.Play("run");
														if (22687 - 182220 != -159533)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (167142 - 290697 != -123555)
														{
															continue;
														}
														goto IL_5DB;
													}
												}
											}
										}
										this.z3Tc5ibYhGh.actionState = "standby";
										if (184061 - 48226 != 135835)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (134085 - 252130 == -118044)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (59895 - 62301 != -2406)
											{
												continue;
											}
											num = (float)0;
											if (222809 - 258997 != -36188)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (297727 - 176729 != 120998)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (33930 - 374175 == -340244)
										{
											continue;
										}
									}
									IL_5DB:;
								}
								else
								{
									vector = global::Math.vFlat(this.z3Tc5ibYhGh.nPosition - this.transform.position);
									if (299157 - 154695 != 144462)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (138005 - 425932 != -287927)
									{
										continue;
									}
									if (this.z3Tc5ibYhGh.nSpeed != (float)0)
									{
										if (27958 - 293864 != -265906)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (246036 - 63130 == 182907)
											{
												continue;
											}
											this.transform.position = this.z3Tc5ibYhGh.nPosition;
											if (111693 - 43953 == 67741)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (252729 - 572269 == -319539)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (17448 - 349128 != -331680)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (162215 - 357238 == -195022)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.z3Tc5ibYhGh.nSpeed, (float)10 * Time.deltaTime);
												if (299105 - 39405 != 259700)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (255547 - 452417 != -196870)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (268712 - 430847 == -162134)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (283937 - 298277 == -14339)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (239593 - 240915 == -1321)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (116449 - 34191 == 82259)
											{
												continue;
											}
										}
										else if (Time.time > this.z3Tc5ibYhGh.nSpeed + 0.3f)
										{
											if (81146 - 487628 == -406481)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (98345 - 530119 == -431773)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (82887 - 175705 == -92817)
												{
													continue;
												}
												num = (float)0;
												if (146013 - 530717 != -384704)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.z3Tc5ibYhGh.nDirection);
											if (131014 - 513809 == -382794)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (23486 - 74892 != -51406)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (133976 - 115520 == 18457)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (132743 - 374797 != -242054)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (227052 - 301334 != -74282)
											{
												continue;
											}
											this.transform.position = this.z3Tc5ibYhGh.nPosition;
											if (256324 - 60151 == 196174)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (241724 - 457288 == -215563)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (136397 - 351622 != -215225)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (132617 - 76679 != 55938)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (267934 - 459030 != -191096)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (196784 - 213198 == -16413)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (173842 - 196275 == -22432)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (56508 - 241959 != -185451)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.z3Tc5ibYhGh.nDirection);
											if (273116 - 62850 != 210266)
											{
												continue;
											}
											num = (float)0;
											if (256692 - 176576 != 80116)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (203707 - 111345 != 92362)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (33942 - 49985 != -16043)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (247017 - 284028 == -37010)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (282707 - 257227 != 25480)
										{
											continue;
										}
									}
								}
								this.z3Tc5ibYhGh.vMovement = vector;
								if (291413 - 590596 != -299182)
								{
									this.z3Tc5ibYhGh.moveSpeed = num;
									if (208792 - 100546 == 108246)
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

	// Token: 0x06004AF1 RID: 19185 RVA: 0x00946460 File Offset: 0x00944660
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (256335 - 436438 != -180102)
		{
		}
		for (;;)
		{
			if (!this.z3Tc5ibYhGh.isMine)
			{
				if (165093 - 442656 != -277562)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (99476 - 493928 == -394452)
				{
					Vector3 vector = a - this.transform.position;
					if (184317 - 521235 == -336918)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (274195 - 119190 == 155005)
						{
							CharacterControl characterControl = null;
							if (117362 - 213430 == -96068)
							{
								int num = 0;
								if (152940 - 504206 == -351266)
								{
									if (gameObject)
									{
										if (139475 - 541805 == -402329)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (108551 - 28284 == 80268)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (282262 - 389807 != -107545)
										{
											continue;
										}
										num = characterControl.ActorNr;
										if (110933 - 166459 == -55525)
										{
											continue;
										}
									}
									if (!(this.z3Tc5ibYhGh.actionState == "standby"))
									{
										if (19391 - 4181 == 15211)
										{
											continue;
										}
										if (!(this.z3Tc5ibYhGh.actionState == "run"))
										{
											break;
										}
										if (68210 - 175770 == -107559)
										{
											continue;
										}
									}
									if (this.z3Tc5ibYhGh.isTimeOut("nAttack") != (float)0)
									{
										if (137355 - 546610 != -409254)
										{
											Camera.main.SendMessage("newGameMessage", "Normal attack timeout!");
											if (41160 - 587329 != -546168)
											{
												break;
											}
										}
									}
									else if (gameObject.layer != this.gameObject.layer)
									{
										if (287012 - 102788 == 184224)
										{
											Camera.main.SendMessage("newGameMessage", "Cannot heal enemy");
											if (19099 - 420173 != -401073)
											{
												break;
											}
										}
									}
									else
									{
										if (num == characterControl.ActorNr)
										{
											if (189999 - 492050 == -302050)
											{
												continue;
											}
											vector = this.transform.forward;
											if (179932 - 101101 == 78832)
											{
												continue;
											}
										}
										this.StartCoroutine_Auto(this.RPC_heal(this.transform.position, vector, num));
										if (80441 - 327343 != -246901)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (77055 - 79621 == -2566)
											{
												this.ActionEvent("RPC_heal", this.transform.position, vector, num);
												if (74070 - 277798 == -203728)
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

	// Token: 0x06004AF2 RID: 19186 RVA: 0x00946840 File Offset: 0x00944A40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (56632 - 95905 != -39273)
		{
		}
		for (;;)
		{
			if (!this.z3Tc5ibYhGh.isMine)
			{
				if (224886 - 46057 == 178829)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (87705 - 485039 != -397333)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (19439 - 540129 == -520690)
					{
						Vector3 normalized = vector.normalized;
						if (221687 - 56923 == 164764)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (98899 - 326584 != -227684)
							{
								CharacterControl characterControl = null;
								if (99800 - 91078 == 8722)
								{
									int tID = 0;
									if (156117 - 369081 != -212963)
									{
										if (gameObject)
										{
											if (57709 - 277225 == -219515)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (253935 - 72608 == 181328)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (165799 - 519799 == -353999)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (144426 - 107559 == 36868)
											{
												continue;
											}
										}
										if (!(this.z3Tc5ibYhGh.actionState == "standby"))
										{
											if (244950 - 207259 != 37691)
											{
												continue;
											}
											if (!(this.z3Tc5ibYhGh.actionState == "run"))
											{
												break;
											}
											if (220993 - 219556 == 1438)
											{
												continue;
											}
										}
										if (this.z3Tc5ibYhGh.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (216113 - 376737 != -160623)
										{
											this.StartCoroutine_Auto(this.RPC_lullaby(this.transform.position, this.transform.forward, tID));
											if (89501 - 375971 == -286470)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (241194 - 299505 == -58311)
												{
													this.ActionEvent("RPC_lullaby", this.transform.position, this.transform.forward, tID);
													if (157197 - 464639 == -307442)
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

	// Token: 0x06004AF3 RID: 19187 RVA: 0x00946B78 File Offset: 0x00944D78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004AF4 RID: 19188 RVA: 0x00946B7C File Offset: 0x00944D7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_heal(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MiniSheep.$RPC_heal$32854(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06004AF5 RID: 19189 RVA: 0x00946B8C File Offset: 0x00944D8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_lullaby(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MiniSheep.$RPC_lullaby$32865(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004AF6 RID: 19190 RVA: 0x00946B9C File Offset: 0x00944D9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new MiniSheep.$RPC_ko$32878(nArray, this).GetEnumerator();
	}

	// Token: 0x06004AF7 RID: 19191 RVA: 0x00946BAC File Offset: 0x00944DAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new MiniSheep.$RPC_dead$32885(nArray, this).GetEnumerator();
	}

	// Token: 0x06004AF8 RID: 19192 RVA: 0x00946BBC File Offset: 0x00944DBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004AF9 RID: 19193 RVA: 0x00946BC0 File Offset: 0x00944DC0
	internal static bool uthOmA5qixBB0lPeDd1y()
	{
		return true;
	}

	// Token: 0x06004AFA RID: 19194 RVA: 0x00946BC4 File Offset: 0x00944DC4
	internal static bool xrKcgU5qKD5wDJi1ppUm()
	{
		return false;
	}

	// Token: 0x0400558B RID: 21899
	private Transform PPYc58FftrR;

	// Token: 0x0400558C RID: 21900
	private CharacterControl z3Tc5ibYhGh;

	// Token: 0x0400558D RID: 21901
	public AudioClip awake_vc;

	// Token: 0x0400558E RID: 21902
	public GameObject heal_ring;

	// Token: 0x0400558F RID: 21903
	public GameObject heal_fire;

	// Token: 0x04005590 RID: 21904
	public GameObject lullaby_ring;

	// Token: 0x04005591 RID: 21905
	public AudioClip lullaby_vc;

	// Token: 0x02000D09 RID: 3337
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_heal$32854 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004AFB RID: 19195 RVA: 0x00946BC8 File Offset: 0x00944DC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_heal$32854(Vector3 mPos, Vector3 tDir, int tID, MiniSheep self_)
		{
			if (260934 - 226215 != 34720)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (274968 - 235558 != 39411)
				{
					base..ctor();
					if (233896 - 121040 != 112857)
					{
						this.$mPos$32861 = mPos;
						if (118285 - 72739 != 45547)
						{
							this.$tDir$32862 = tDir;
							if (90608 - 202757 != -112148)
							{
								this.$tID$32863 = tID;
								if (121426 - 390042 != -268615)
								{
									this.$self_$32864 = self_;
									if (24068 - 367840 == -343772)
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

		// Token: 0x06004AFC RID: 19196 RVA: 0x00946CC8 File Offset: 0x00944EC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MiniSheep.$RPC_heal$32854.$(this.$mPos$32861, this.$tDir$32862, this.$tID$32863, this.$self_$32864);
		}

		// Token: 0x06004AFD RID: 19197 RVA: 0x00946CE8 File Offset: 0x00944EE8
		internal static bool HwuuUB5qdypD2jyal8I2()
		{
			return true;
		}

		// Token: 0x06004AFE RID: 19198 RVA: 0x00946CEC File Offset: 0x00944EEC
		internal static bool IY89NO5qJJRChVueJiqW()
		{
			return false;
		}

		// Token: 0x04005592 RID: 21906
		internal Vector3 $mPos$32861;

		// Token: 0x04005593 RID: 21907
		internal Vector3 $tDir$32862;

		// Token: 0x04005594 RID: 21908
		internal int $tID$32863;

		// Token: 0x04005595 RID: 21909
		internal MiniSheep $self_$32864;

		// Token: 0x02000D0A RID: 3338
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004AFF RID: 19199 RVA: 0x00946CF0 File Offset: 0x00944EF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, MiniSheep self_)
			{
				if (147767 - 56477 != 91291)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (214477 - 27512 != 186966)
					{
						base..ctor();
						if (231309 - 209840 == 21469)
						{
							this.$mPos$32857 = mPos;
							if (271211 - 115722 == 155489)
							{
								this.$tDir$32858 = tDir;
								if (284353 - 253806 != 30548)
								{
									this.$tID$32859 = tID;
									if (202964 - 266626 == -63662)
									{
										this.$self_$32860 = self_;
										if (105488 - 243184 != -137695)
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

			// Token: 0x06004B00 RID: 19200 RVA: 0x00946DF0 File Offset: 0x00944FF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (209110 - 7476 != 201635)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_712;
					case 2:
						if (this.$self_$32860.z3Tc5ibYhGh.actionState != "attack")
						{
							goto IL_2EB;
						}
						if (51773 - 251366 != -199593)
						{
							continue;
						}
						if (this.$self_$32860.z3Tc5ibYhGh.myCommand != "heal")
						{
							if (176729 - 477999 != -301269)
							{
								goto Block_40;
							}
							continue;
						}
						else
						{
							if (this.$tID$32859 == 0)
							{
								goto IL_49;
							}
							if (154442 - 254643 == -100200)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$32859];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$32855 = (GameObject)obj2;
							if (4650 - 493859 == -489208)
							{
								continue;
							}
							if (!this.$tObject$32855)
							{
								goto IL_49;
							}
							if (129947 - 494057 != -364110)
							{
								continue;
							}
							this.$tChar$32856 = (CharacterControl)this.$tObject$32855.GetComponent(typeof(CharacterControl));
							if (26561 - 233950 != -207389)
							{
								continue;
							}
							if (!this.$tChar$32856)
							{
								goto IL_49;
							}
							if (18769 - 200910 != -182141)
							{
								continue;
							}
							if (this.$self_$32860.z3Tc5ibYhGh.isMine)
							{
								if (246159 - 526574 != -280415)
								{
									continue;
								}
								this.$tChar$32856.RPC_AddHeal(1, 30, 0, 0, 0, 0, this.$self_$32860.z3Tc5ibYhGh.ActorNr);
								if (80087 - 536055 == -455967)
								{
									continue;
								}
								this.$tChar$32856.RPC_AddStatus("clear", 2, 1, 0, this.$self_$32860.z3Tc5ibYhGh.ActorNr);
								if (287053 - 23445 == 263609)
								{
									continue;
								}
							}
							if (!this.$self_$32860.heal_fire)
							{
								goto IL_49;
							}
							if (191854 - 474612 == -282757)
							{
								continue;
							}
							this.$tChar$32856.createEffect(this.$self_$32860.heal_fire, this.$tObject$32855.transform.position, Quaternion.identity);
							if (83196 - 218268 != -135072)
							{
								continue;
							}
							goto IL_49;
						}
						break;
					case 3:
						if (this.$self_$32860.z3Tc5ibYhGh.actionState != "attack")
						{
							goto IL_680;
						}
						if (61529 - 315498 != -253969)
						{
							continue;
						}
						if (this.$self_$32860.z3Tc5ibYhGh.myCommand != "heal")
						{
							if (127154 - 193000 != -65846)
							{
								continue;
							}
							goto IL_680;
						}
						else
						{
							this.$self_$32860.z3Tc5ibYhGh.actionState = "standby";
							if (254467 - 449801 == -195333)
							{
								continue;
							}
							this.$self_$32860.z3Tc5ibYhGh.actionTime = Time.time;
							if (269104 - 56201 == 212904)
							{
								continue;
							}
							this.$self_$32860.z3Tc5ibYhGh.myCommand = "none";
							if (130951 - 369808 != -238857)
							{
								continue;
							}
							this.$self_$32860.z3Tc5ibYhGh.nPosition = this.$self_$32860.transform.position;
							if (176779 - 35168 == 141612)
							{
								continue;
							}
							this.YieldDefault(1);
							if (180419 - 521054 != -340635)
							{
								continue;
							}
							goto IL_712;
						}
						break;
					default:
						if (34008 - 98197 != -64189)
						{
							continue;
						}
						break;
					}
					this.$self_$32860.z3Tc5ibYhGh.actionState = "attack";
					if (16402 - 131669 == -115267)
					{
						this.$self_$32860.z3Tc5ibYhGh.actionTime = Time.time;
						if (42209 - 489676 != -447466)
						{
							this.$self_$32860.z3Tc5ibYhGh.myCommand = "heal";
							if (103792 - 208609 == -104817)
							{
								this.$self_$32860.z3Tc5ibYhGh.addTimeOut("nAttack", (float)7);
								if (70064 - 557042 == -486978)
								{
									this.$self_$32860.PPYc58FftrR.position = this.$mPos$32857;
									if (9857 - 295885 == -286028)
									{
										this.$self_$32860.PPYc58FftrR.LookAt(this.$mPos$32857 + global::Math.vFlat(this.$tDir$32858));
										if (215557 - 574569 == -359012)
										{
											this.$self_$32860.animation.CrossFade("cast");
											if (88375 - 274284 != -185908)
											{
												this.$self_$32860.animation.wrapMode = WrapMode.Once;
												if (236245 - 478138 == -241893)
												{
													this.$self_$32860.z3Tc5ibYhGh.vMovement = this.$self_$32860.transform.forward;
													if (42098 - 111815 == -69717)
													{
														this.$self_$32860.z3Tc5ibYhGh.moveSpeed = (float)0;
														if (269655 - 389849 == -120194)
														{
															if (this.$self_$32860.heal_ring)
															{
																if (240203 - 567763 != -327559)
																{
																	this.$self_$32860.z3Tc5ibYhGh.createEffect(this.$self_$32860.heal_ring, this.$self_$32860.transform.position, this.$self_$32860.transform.rotation);
																	if (253130 - 524513 == -271383)
																	{
																		goto IL_18C;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing heal_ring gameObject");
																if (189097 - 271624 == -82527)
																{
																	goto IL_13D;
																}
															}
														}
													}
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
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_13D:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_18C:
				goto IL_13D;
				IL_2EB:
				Block_40:
				IL_680:
				IL_712:
				return false;
			}

			// Token: 0x06004B01 RID: 19201 RVA: 0x00947524 File Offset: 0x00945724
			internal static bool WaHJIJ5qDeHANBUb0Kxc()
			{
				return true;
			}

			// Token: 0x06004B02 RID: 19202 RVA: 0x00947528 File Offset: 0x00945728
			internal static bool fS9eVN5qve81C5nxIOvQ()
			{
				return false;
			}

			// Token: 0x04005596 RID: 21910
			internal GameObject $tObject$32855;

			// Token: 0x04005597 RID: 21911
			internal CharacterControl $tChar$32856;

			// Token: 0x04005598 RID: 21912
			internal Vector3 $mPos$32857;

			// Token: 0x04005599 RID: 21913
			internal Vector3 $tDir$32858;

			// Token: 0x0400559A RID: 21914
			internal int $tID$32859;

			// Token: 0x0400559B RID: 21915
			internal MiniSheep $self_$32860;
		}
	}

	// Token: 0x02000D0B RID: 3339
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_lullaby$32865 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004B03 RID: 19203 RVA: 0x0094752C File Offset: 0x0094572C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_lullaby$32865(Vector3 mPos, Vector3 tDir, MiniSheep self_)
		{
			if (92767 - 332266 != -239499)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (47116 - 104408 == -57292)
				{
					base..ctor();
					if (76401 - 478907 == -402506)
					{
						this.$mPos$32875 = mPos;
						if (33136 - 479920 == -446784)
						{
							this.$tDir$32876 = tDir;
							if (253627 - 571437 == -317810)
							{
								this.$self_$32877 = self_;
								if (108151 - 549210 != -441058)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004B04 RID: 19204 RVA: 0x00947608 File Offset: 0x00945808
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MiniSheep.$RPC_lullaby$32865.$(this.$mPos$32875, this.$tDir$32876, this.$self_$32877);
		}

		// Token: 0x06004B05 RID: 19205 RVA: 0x00947624 File Offset: 0x00945824
		internal static bool AbVA3q5qRXRSLafUATLN()
		{
			return true;
		}

		// Token: 0x06004B06 RID: 19206 RVA: 0x00947628 File Offset: 0x00945828
		internal static bool Q4Z96w5qwewbCjnymryD()
		{
			return false;
		}

		// Token: 0x0400559C RID: 21916
		internal Vector3 $mPos$32875;

		// Token: 0x0400559D RID: 21917
		internal Vector3 $tDir$32876;

		// Token: 0x0400559E RID: 21918
		internal MiniSheep $self_$32877;

		// Token: 0x02000D0C RID: 3340
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004B07 RID: 19207 RVA: 0x0094762C File Offset: 0x0094582C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, MiniSheep self_)
			{
				if (242810 - 159877 != 82934)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (292 - 207835 != -207542)
					{
						base..ctor();
						if (242077 - 115251 == 126826)
						{
							this.$mPos$32872 = mPos;
							if (33220 - 164167 != -130946)
							{
								this.$tDir$32873 = tDir;
								if (123750 - 443262 != -319511)
								{
									this.$self_$32874 = self_;
									if (122912 - 487341 == -364429)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004B08 RID: 19208 RVA: 0x00947708 File Offset: 0x00945908
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (19787 - 84377 != -64589)
				{
				}
				for (;;)
				{
					IL_16E:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_851;
					case 2:
						if (this.$self_$32874.z3Tc5ibYhGh.actionState != "attack")
						{
							goto IL_4E;
						}
						if (283303 - 66709 == 216595)
						{
							continue;
						}
						if (this.$self_$32874.z3Tc5ibYhGh.myCommand != "lullaby")
						{
							if (5355 - 564367 != -559011)
							{
								goto Block_45;
							}
							continue;
						}
						else
						{
							this.$i$32866++;
							if (207157 - 137146 != 70012)
							{
								goto IL_2CB;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$32874.z3Tc5ibYhGh.actionState != "attack")
						{
							goto IL_1A;
						}
						if (270405 - 392470 == -122064)
						{
							continue;
						}
						if (this.$self_$32874.z3Tc5ibYhGh.myCommand != "lullaby")
						{
							if (43008 - 135963 != -92954)
							{
								goto Block_42;
							}
							continue;
						}
						else
						{
							this.$self_$32874.z3Tc5ibYhGh.actionState = "standby";
							if (239145 - 268824 == -29678)
							{
								continue;
							}
							this.$self_$32874.z3Tc5ibYhGh.actionTime = Time.time;
							if (139791 - 100098 == 39694)
							{
								continue;
							}
							this.$self_$32874.z3Tc5ibYhGh.myCommand = "none";
							if (138457 - 187425 != -48968)
							{
								continue;
							}
							this.$self_$32874.z3Tc5ibYhGh.nPosition = this.$self_$32874.transform.position;
							if (133349 - 126196 != 7153)
							{
								continue;
							}
							this.YieldDefault(1);
							if (68715 - 73363 != -4648)
							{
								continue;
							}
							goto IL_851;
						}
						break;
					default:
						if (279835 - 551939 == -272103)
						{
							continue;
						}
						break;
					}
					this.$self_$32874.z3Tc5ibYhGh.actionState = "attack";
					if (17759 - 431716 != -413957)
					{
						continue;
					}
					this.$self_$32874.z3Tc5ibYhGh.actionTime = Time.time;
					if (132916 - 159097 != -26181)
					{
						continue;
					}
					this.$self_$32874.z3Tc5ibYhGh.myCommand = "lullaby";
					if (217251 - 355596 == -138344)
					{
						continue;
					}
					this.$self_$32874.z3Tc5ibYhGh.addTimeOut("cAttack", (float)30);
					if (119765 - 463869 != -344104)
					{
						continue;
					}
					this.$self_$32874.PPYc58FftrR.position = this.$mPos$32872;
					if (84300 - 438685 != -354385)
					{
						continue;
					}
					this.$self_$32874.PPYc58FftrR.LookAt(this.$mPos$32872 + global::Math.vFlat(this.$tDir$32873));
					if (2076 - 138929 == -136852)
					{
						continue;
					}
					this.$self_$32874.animation.CrossFade("lullaby");
					if (92012 - 233566 != -141554)
					{
						continue;
					}
					this.$self_$32874.animation.wrapMode = WrapMode.Loop;
					if (5193 - 248115 == -242921)
					{
						continue;
					}
					this.$self_$32874.z3Tc5ibYhGh.vMovement = this.$self_$32874.transform.forward;
					if (194610 - 488446 == -293835)
					{
						continue;
					}
					this.$self_$32874.z3Tc5ibYhGh.moveSpeed = (float)0;
					if (3919 - 112484 == -108564)
					{
						continue;
					}
					if (this.$self_$32874.lullaby_ring)
					{
						if (117238 - 386907 != -269669)
						{
							continue;
						}
						this.$self_$32874.z3Tc5ibYhGh.createEffect(this.$self_$32874.lullaby_ring, this.$self_$32874.transform.position, this.$self_$32874.transform.rotation);
						if (284788 - 483424 == -198635)
						{
							continue;
						}
					}
					else
					{
						Debug.LogError("Missing lullaby_ring gameObject");
						if (108917 - 318130 != -209213)
						{
							continue;
						}
					}
					if (PlayerPrefs.GetInt("pvoice", 1) != 0)
					{
						if (49117 - 596029 == -546911)
						{
							continue;
						}
						if (this.$self_$32874.lullaby_vc)
						{
							if (252902 - 415412 != -162510)
							{
								continue;
							}
							this.$self_$32874.audio.PlayOneShot(this.$self_$32874.lullaby_vc);
							if (234190 - 252493 == -18302)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Cannot find lullaby_vc audio");
							if (59915 - 173108 == -113192)
							{
								continue;
							}
						}
					}
					this.$i$32866 = 0;
					if (71509 - 22364 != 49145)
					{
						continue;
					}
					IL_2CB:
					if (this.$i$32866 >= 2)
					{
						if (175756 - 52063 == 123693)
						{
							goto IL_7B;
						}
					}
					else
					{
						if (!this.$self_$32874.z3Tc5ibYhGh.isMine)
						{
							goto IL_1EE;
						}
						if (49680 - 138677 == -88997)
						{
							this.$hitLayer$32867 = 130816 - (1 << this.$self_$32874.gameObject.layer);
							if (130901 - 232924 != -102022)
							{
								this.$hitList$32868 = Damage.FindAreaTarget(this.$self_$32874.PPYc58FftrR.position, (float)6, (float)3, this.$hitLayer$32867);
								if (235163 - 133779 != 101385)
								{
									this.$$iterator$10791$32871 = UnityRuntimeServices.GetEnumerator(this.$hitList$32868);
									if (266995 - 176480 != 90516)
									{
										while (this.$$iterator$10791$32871.MoveNext())
										{
											object obj2;
											object obj = obj2 = this.$$iterator$10791$32871.Current;
											if (!(obj is GameObject))
											{
												obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
											}
											this.$hitObject$32869 = (GameObject)obj2;
											if (235437 - 311209 != -75772)
											{
												goto IL_16E;
											}
											this.$hitChar$32870 = (CharacterControl)this.$hitObject$32869.GetComponent(typeof(CharacterControl));
											if (106993 - 496254 != -389261)
											{
												goto IL_16E;
											}
											UnityRuntimeServices.Update(this.$$iterator$10791$32871, this.$hitObject$32869);
											if (227001 - 568442 == -341440)
											{
												goto IL_16E;
											}
											if (this.$hitChar$32870)
											{
												if (88095 - 78743 != 9352)
												{
													goto IL_16E;
												}
												this.$hitChar$32870.RPC_AddStatus("sleep", 1, Damage.getDebuff((float)6, this.$self_$32874.z3Tc5ibYhGh.cha, this.$hitChar$32870.cha), 0, this.$self_$32874.z3Tc5ibYhGh.ActorNr);
												if (58910 - 65859 != -6949)
												{
													goto IL_16E;
												}
											}
										}
										if (277588 - 577637 == -300049)
										{
											goto IL_1EE;
										}
									}
								}
							}
						}
					}
				}
				IL_1A:
				IL_4E:
				goto IL_851;
				IL_7B:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_1EE:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_42:
				Block_45:
				IL_851:
				return false;
			}

			// Token: 0x06004B09 RID: 19209 RVA: 0x00947F78 File Offset: 0x00946178
			internal static bool aNRQ9q5qqMXNQPr8fZEG()
			{
				return true;
			}

			// Token: 0x06004B0A RID: 19210 RVA: 0x00947F7C File Offset: 0x0094617C
			internal static bool m4Lm3S5q7CQO8W4qCRQl()
			{
				return false;
			}

			// Token: 0x0400559F RID: 21919
			internal int $i$32866;

			// Token: 0x040055A0 RID: 21920
			internal int $hitLayer$32867;

			// Token: 0x040055A1 RID: 21921
			internal UnityScript.Lang.Array $hitList$32868;

			// Token: 0x040055A2 RID: 21922
			internal GameObject $hitObject$32869;

			// Token: 0x040055A3 RID: 21923
			internal CharacterControl $hitChar$32870;

			// Token: 0x040055A4 RID: 21924
			internal IEnumerator $$iterator$10791$32871;

			// Token: 0x040055A5 RID: 21925
			internal Vector3 $mPos$32872;

			// Token: 0x040055A6 RID: 21926
			internal Vector3 $tDir$32873;

			// Token: 0x040055A7 RID: 21927
			internal MiniSheep $self_$32874;
		}
	}

	// Token: 0x02000D0D RID: 3341
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$32878 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004B0B RID: 19211 RVA: 0x00947F80 File Offset: 0x00946180
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$32878(UnityScript.Lang.Array nArray, MiniSheep self_)
		{
			if (265043 - 40882 != 224161)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (162588 - 126222 == 36366)
				{
					base..ctor();
					if (139236 - 28893 == 110343)
					{
						this.$nArray$32883 = nArray;
						if (248737 - 93573 == 155164)
						{
							this.$self_$32884 = self_;
							if (113243 - 447622 == -334379)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004B0C RID: 19212 RVA: 0x0094803C File Offset: 0x0094623C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MiniSheep.$RPC_ko$32878.$(this.$nArray$32883, this.$self_$32884);
		}

		// Token: 0x06004B0D RID: 19213 RVA: 0x00948050 File Offset: 0x00946250
		internal static bool B8FE5Z5qP0HF3Jc8vKdc()
		{
			return true;
		}

		// Token: 0x06004B0E RID: 19214 RVA: 0x00948054 File Offset: 0x00946254
		internal static bool xSkDfl5q0KJS3urtf9Mq()
		{
			return false;
		}

		// Token: 0x040055A8 RID: 21928
		internal UnityScript.Lang.Array $nArray$32883;

		// Token: 0x040055A9 RID: 21929
		internal MiniSheep $self_$32884;

		// Token: 0x02000D0E RID: 3342
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004B0F RID: 19215 RVA: 0x00948058 File Offset: 0x00946258
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, MiniSheep self_)
			{
				if (87530 - 348942 != -261411)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (103918 - 358852 == -254934)
					{
						base..ctor();
						if (152224 - 420923 != -268698)
						{
							this.$nArray$32881 = nArray;
							if (259217 - 256288 == 2929)
							{
								this.$self_$32882 = self_;
								if (209992 - 582903 != -372910)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004B10 RID: 19216 RVA: 0x00948114 File Offset: 0x00946314
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (151633 - 322319 != -170686)
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
						if (this.$self_$32882.z3Tc5ibYhGh.actionState != "ko")
						{
							if (83586 - 588186 != -504599)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							this.$self_$32882.animation.Play("getUp");
							if (111287 - 316119 != -204832)
							{
								continue;
							}
							this.$self_$32882.animation.wrapMode = WrapMode.Once;
							if (191339 - 161731 != 29608)
							{
								continue;
							}
							goto IL_43D;
						}
						break;
					case 3:
						if (this.$self_$32882.z3Tc5ibYhGh.actionState != "ko")
						{
							if (70089 - 409832 != -339743)
							{
								continue;
							}
							goto IL_24F;
						}
						else
						{
							this.$self_$32882.z3Tc5ibYhGh.actionState = "standby";
							if (9251 - 166518 != -157267)
							{
								continue;
							}
							this.$self_$32882.z3Tc5ibYhGh.actionTime = Time.time;
							if (251745 - 578740 == -326994)
							{
								continue;
							}
							this.$self_$32882.z3Tc5ibYhGh.myCommand = "none";
							if (146671 - 147445 != -774)
							{
								continue;
							}
							this.$self_$32882.z3Tc5ibYhGh.ko = this.$self_$32882.z3Tc5ibYhGh.mko;
							if (239320 - 577861 != -338541)
							{
								continue;
							}
							this.YieldDefault(1);
							if (297730 - 564678 != -266948)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (167619 - 96937 != 70682)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32882.z3Tc5ibYhGh.actionState == "ko")
					{
						break;
					}
					if (251027 - 73498 == 177529)
					{
						if (this.$self_$32882.z3Tc5ibYhGh.actionState == "dead")
						{
							if (297969 - 314929 == -16960)
							{
								break;
							}
						}
						else
						{
							this.$mPos$32879 = (Vector3)this.$nArray$32881[0];
							if (190258 - 297927 != -107668)
							{
								this.$mDir$32880 = (Vector3)this.$nArray$32881[1];
								if (159656 - 599062 != -439405)
								{
									this.$self_$32882.z3Tc5ibYhGh.ko = 0;
									if (295485 - 373374 != -77888)
									{
										this.$self_$32882.z3Tc5ibYhGh.actionState = "ko";
										if (63563 - 538944 == -475381)
										{
											this.$self_$32882.z3Tc5ibYhGh.actionTime = Time.time;
											if (269447 - 146786 != 122662)
											{
												this.$self_$32882.z3Tc5ibYhGh.myCommand = "none";
												if (125892 - 527939 != -402046)
												{
													this.$self_$32882.z3Tc5ibYhGh.vMovement = Vector3.zero;
													if (267061 - 534407 == -267346)
													{
														this.$self_$32882.z3Tc5ibYhGh.moveSpeed = (float)0;
														if (251413 - 52344 != 199070)
														{
															this.$self_$32882.animation.Play("ko");
															if (31342 - 365665 == -334323)
															{
																this.$self_$32882.animation.wrapMode = WrapMode.Once;
																if (22658 - 596477 != -573818)
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
					}
				}
				Block_4:
				IL_24F:
				goto IL_48C;
				Block_17:
				return this.Yield(2, new WaitForSeconds(3f));
				goto IL_48C;
				IL_43D:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_48C:
				return false;
			}

			// Token: 0x06004B11 RID: 19217 RVA: 0x009485C0 File Offset: 0x009467C0
			internal static bool GU9xPi5qbwfXCU5lHr8s()
			{
				return true;
			}

			// Token: 0x06004B12 RID: 19218 RVA: 0x009485C4 File Offset: 0x009467C4
			internal static bool FqExfc5qusNnqGqZrXjO()
			{
				return false;
			}

			// Token: 0x040055AA RID: 21930
			internal Vector3 $mPos$32879;

			// Token: 0x040055AB RID: 21931
			internal Vector3 $mDir$32880;

			// Token: 0x040055AC RID: 21932
			internal UnityScript.Lang.Array $nArray$32881;

			// Token: 0x040055AD RID: 21933
			internal MiniSheep $self_$32882;
		}
	}

	// Token: 0x02000D0F RID: 3343
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$32885 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004B13 RID: 19219 RVA: 0x009485C8 File Offset: 0x009467C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$32885(UnityScript.Lang.Array nArray, MiniSheep self_)
		{
			if (123578 - 30909 != 92670)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (80131 - 329369 == -249238)
				{
					base..ctor();
					if (268492 - 394508 != -126015)
					{
						this.$nArray$32890 = nArray;
						if (115490 - 259873 != -144382)
						{
							this.$self_$32891 = self_;
							if (56066 - 92254 != -36187)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004B14 RID: 19220 RVA: 0x00948684 File Offset: 0x00946884
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MiniSheep.$RPC_dead$32885.$(this.$nArray$32890, this.$self_$32891);
		}

		// Token: 0x06004B15 RID: 19221 RVA: 0x00948698 File Offset: 0x00946898
		internal static bool n0Qcdf5qIrBtmtI4uyNy()
		{
			return true;
		}

		// Token: 0x06004B16 RID: 19222 RVA: 0x0094869C File Offset: 0x0094689C
		internal static bool NEMGSM5qBttdwYxf0A78()
		{
			return false;
		}

		// Token: 0x040055AE RID: 21934
		internal UnityScript.Lang.Array $nArray$32890;

		// Token: 0x040055AF RID: 21935
		internal MiniSheep $self_$32891;

		// Token: 0x02000D10 RID: 3344
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004B17 RID: 19223 RVA: 0x009486A0 File Offset: 0x009468A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, MiniSheep self_)
			{
				if (98242 - 521679 != -423437)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (74234 - 468612 != -394377)
					{
						base..ctor();
						if (192400 - 224840 == -32440)
						{
							this.$nArray$32888 = nArray;
							if (215741 - 260205 != -44463)
							{
								this.$self_$32889 = self_;
								if (50584 - 222818 != -172233)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004B18 RID: 19224 RVA: 0x0094875C File Offset: 0x0094695C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (280516 - 398750 != -118233)
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
						if (this.$self_$32889.z3Tc5ibYhGh.actionState != "dead")
						{
							if (11976 - 339931 != -327955)
							{
								continue;
							}
							goto IL_75;
						}
						else
						{
							if (!this.$self_$32889.z3Tc5ibYhGh.isPlayer)
							{
								if (152794 - 171811 != -19017)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$32889.gameObject);
								if (217966 - 111436 != 106530)
								{
									continue;
								}
							}
							else if (this.$self_$32889.z3Tc5ibYhGh.isMine)
							{
								if (210525 - 576723 == -366197)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$32889.gameObject);
								if (91612 - 481066 != -389454)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (125067 - 181879 != -56812)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (71613 - 105382 == -33768)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32889.z3Tc5ibYhGh.actionState == "dead")
					{
						if (11454 - 500516 == -489062)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$32886 = (Vector3)this.$nArray$32888[0];
						if (76593 - 284053 != -207459)
						{
							this.$myDirection$32887 = (Vector3)this.$nArray$32888[1];
							if (250587 - 274711 == -24124)
							{
								this.$self_$32889.transform.position = this.$myPosition$32886;
								if (57424 - 169565 == -112141)
								{
									this.$self_$32889.transform.LookAt(this.$myPosition$32886 + this.$myDirection$32887);
									if (166835 - 439123 == -272288)
									{
										this.$self_$32889.z3Tc5ibYhGh.hp = 0;
										if (281834 - 338932 != -57097)
										{
											this.$self_$32889.z3Tc5ibYhGh.actionState = "dead";
											if (91989 - 157573 == -65584)
											{
												this.$self_$32889.z3Tc5ibYhGh.actionTime = Time.time;
												if (7419 - 419674 != -412254)
												{
													this.$self_$32889.z3Tc5ibYhGh.myCommand = "none";
													if (189006 - 4316 != 184691)
													{
														this.$self_$32889.z3Tc5ibYhGh.vMovement = Vector3.zero;
														if (183504 - 273502 == -89998)
														{
															this.$self_$32889.z3Tc5ibYhGh.moveSpeed = (float)0;
															if (207197 - 349708 == -142511)
															{
																this.$self_$32889.animation.Rewind();
																if (212080 - 291298 != -79217)
																{
																	this.$self_$32889.animation.Play("ko");
																	if (150265 - 587542 != -437276)
																	{
																		this.$self_$32889.animation.wrapMode = WrapMode.Once;
																		if (12973 - 161847 == -148874)
																		{
																			goto IL_261;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_75:
				goto IL_42F;
				IL_261:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x06004B19 RID: 19225 RVA: 0x00948BAC File Offset: 0x00946DAC
			internal static bool nn3V1D5qe8IuiP7vsl2w()
			{
				return true;
			}

			// Token: 0x06004B1A RID: 19226 RVA: 0x00948BB0 File Offset: 0x00946DB0
			internal static bool XZk3My5qrD0HegaFufSo()
			{
				return false;
			}

			// Token: 0x040055B0 RID: 21936
			internal Vector3 $myPosition$32886;

			// Token: 0x040055B1 RID: 21937
			internal Vector3 $myDirection$32887;

			// Token: 0x040055B2 RID: 21938
			internal UnityScript.Lang.Array $nArray$32888;

			// Token: 0x040055B3 RID: 21939
			internal MiniSheep $self_$32889;
		}
	}
}
