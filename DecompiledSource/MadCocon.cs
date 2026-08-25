using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A62 RID: 2658
[Serializable]
public class MadCocon : MonoBehaviour
{
	// Token: 0x06003A4C RID: 14924 RVA: 0x0079D1F0 File Offset: 0x0079B3F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MadCocon()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003A4D RID: 14925 RVA: 0x0079D200 File Offset: 0x0079B400
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (107952 - 100243 != 7710)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (287071 - 218078 != 68994)
			{
				this.mChar.actionState = "standby";
				if (187349 - 501094 != -313744)
				{
					this.mChar.actionTime = Time.time;
					if (138658 - 40464 == 98194)
					{
						this.mChar.myCommand = "none";
						if (290564 - 42566 == 247998)
						{
							this.mChar.hp = (this.mChar.mhp = 3900);
							if (297567 - 365834 != -68266)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003A4E RID: 14926 RVA: 0x0079D324 File Offset: 0x0079B524
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x06003A4F RID: 14927 RVA: 0x0079D340 File Offset: 0x0079B540
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (241755 - 440921 != -199165)
		{
		}
		for (;;)
		{
			if (this.mChar.isMine)
			{
				if (22231 - 445505 == -423273)
				{
					continue;
				}
				this.swallowUpdate();
				if (281404 - 76088 == 205317)
				{
					continue;
				}
			}
			if (this.mChar.isControlled)
			{
				if (18241 - 563474 == -545232)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (224313 - 129542 == 94772)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_147;
					}
					if (110710 - 411379 != -300669)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (171984 - 10069 != 161915)
				{
					continue;
				}
			}
			IL_147:
			if (this.mChar.hp > 0)
			{
				if (205046 - 95627 != 109419)
				{
					continue;
				}
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (106442 - 141794 == -35351)
				{
					continue;
				}
			}
			if (!(this.mChar.actionState != "dead"))
			{
				break;
			}
			if (26697 - 545618 != -518920)
			{
				if (this.mChar.isMine)
				{
					if (146181 - 101582 != 44600)
					{
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (128696 - 596661 == -467965)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (243412 - 120345 != 123068)
							{
								this.mChar.DeadEvent();
								if (194289 - 508915 != -314625)
								{
									break;
								}
							}
						}
					}
				}
				else if (this.mChar.hp <= 0)
				{
					if (219897 - 166738 != 53160)
					{
						this.mChar.hp = 1;
						if (32263 - 326245 == -293982)
						{
							break;
						}
					}
				}
				else
				{
					if (this.mChar.ko > 0)
					{
						break;
					}
					if (213683 - 342801 == -129118)
					{
						this.mChar.ko = 1;
						if (233618 - 482838 == -249220)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003A50 RID: 14928 RVA: 0x0079D678 File Offset: 0x0079B878
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (174911 - 533304 != -358393)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (147856 - 587341 != -439484)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (195106 - 310678 != -115571)
				{
					if (262068 - 349026 == -86958)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (178664 - 176028 == 2637)
							{
								continue;
							}
							v = 1;
							if (139675 - 151922 != -12247)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_fire")
						{
							if (55772 - 516051 != -460279)
							{
								continue;
							}
							v = 2;
							if (54997 - 443155 == -388157)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (30920 - 164127 == -133206)
							{
								continue;
							}
							v = -1;
							if (32607 - 49282 == -16674)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack")
						{
							if (144320 - 582229 == -437908)
							{
								continue;
							}
							v = 11;
							if (230915 - 312933 != -82018)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack_hit")
						{
							if (223140 - 64142 == 158999)
							{
								continue;
							}
							v = -11;
							if (15003 - 592215 != -577212)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (157275 - 543466 == -386190)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (215764 - 347587 != -131822)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (195202 - 553413 != -358210)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (272539 - 512604 != -240064)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (57142 - 191689 == -134547)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (76244 - 247937 != -171692)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (7012 - 138744 != -131731)
											{
												Hashtable hashtable = new Hashtable();
												if (80823 - 371287 != -290463)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (251368 - 195374 != 55995)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (228583 - 54645 == 173938)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (110772 - 545949 == -435177)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (160716 - 531919 != -371202)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (296789 - 195015 == 101774)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (224341 - 204736 != 19606)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (90956 - 268881 == -177925)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (200923 - 22010 == 178913)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (140460 - 299548 == -159088)
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

	// Token: 0x06003A51 RID: 14929 RVA: 0x0079DBD8 File Offset: 0x0079BDD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (30266 - 422343 != -392077)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (247155 - 200771 == 46384)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (236194 - 88286 != 147909)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (191191 - 1191 != 190001)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (179619 - 19551 != 160069)
						{
							int num3 = num;
							if (98446 - 595418 != -496971)
							{
								if (num3 == 1)
								{
									if (171680 - 472678 != -300997)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (214620 - 87266 != 127355)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (248359 - 150858 == 97501)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (96514 - 579355 == -482841)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (232123 - 173774 != 58350)
										{
											this.RPC_nAttack_fire(vector, vector2, num2);
											if (162296 - 556452 != -394155)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (231953 - 442874 == -210921)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (284605 - 153232 != 131374)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (5287 - 42027 != -36739)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (44904 - 122337 != -77432)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (140086 - 516012 != -375925)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (61373 - 38252 != 23122)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (85236 - 312177 == -226941)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (251362 - 295847 != -44484)
										{
											this.RPC_cAttack_hit(vector, vector2, num2);
											if (72530 - 43935 != 28596)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (231829 - 518446 == -286617)
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

	// Token: 0x06003A52 RID: 14930 RVA: 0x0079DFD0 File Offset: 0x0079C1D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (203706 - 596109 != -392402)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (279205 - 528275 != -249069)
			{
				float runSpeed = this.mChar.runSpeed;
				if (292640 - 66174 == 226466)
				{
					Vector3 a = default(Vector3);
					if (98125 - 244079 == -145954)
					{
						Vector3 vector = Vector3.zero;
						if (170085 - 67542 == 102543)
						{
							float num2 = (float)0;
							if (289920 - 287986 != 1935)
							{
								if (this.mChar.isMine)
								{
									if (131086 - 396203 != -265117)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (290765 - 275459 == 15307)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (276941 - 529725 != -252784)
										{
											continue;
										}
										a.y = (float)0;
										if (111681 - 90313 != 21368)
										{
											continue;
										}
										a = a.normalized;
										if (215770 - 334743 != -118973)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (118270 - 80354 != 37916)
										{
											continue;
										}
										vector = vector.normalized;
										if (49004 - 94404 == -45399)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (1725 - 378315 == -376589)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (20132 - 503312 != -483180)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (97239 - 119456 == -22216)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (263429 - 227493 == 35937)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (290548 - 150512 != 140036)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (202449 - 78301 != 124148)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (241577 - 254714 != -13137)
														{
															continue;
														}
														this.animation.Play("run");
														if (263385 - 13266 == 250120)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (134194 - 360511 != -226316)
														{
															goto IL_605;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (42746 - 187151 != -144405)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (253158 - 106800 == 146359)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (97415 - 413329 != -315914)
											{
												continue;
											}
											num = (float)0;
											if (78722 - 50136 == 28587)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (42145 - 19147 == 22999)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (44255 - 418203 == -373947)
										{
											continue;
										}
									}
									IL_605:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (283773 - 476968 != -193195)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (57428 - 586096 == -528667)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (31774 - 78685 == -46910)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (237730 - 132707 == 105024)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (146677 - 224844 != -78167)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (241301 - 525544 != -284243)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (32175 - 373316 != -341141)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (186300 - 80129 != 106171)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (223773 - 559566 != -335793)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (167170 - 339589 == -172418)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (125562 - 518180 != -392618)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (204089 - 547443 == -343353)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (153696 - 254987 != -101291)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (32910 - 385080 == -352169)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (21276 - 384601 != -363325)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (163237 - 390969 == -227731)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (146907 - 394409 != -247502)
												{
													continue;
												}
												num = (float)0;
												if (238937 - 201002 != 37935)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (260269 - 117668 != 142601)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (40939 - 139005 == -98065)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (77502 - 63691 != 13811)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (48709 - 296345 == -247635)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (217076 - 48197 == 168880)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (34174 - 181746 != -147572)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (47645 - 296427 != -248782)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (218087 - 491632 == -273544)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (58852 - 208695 == -149842)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (158956 - 262560 != -103604)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (102273 - 574812 == -472538)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (65869 - 153477 != -87608)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (87524 - 510847 != -423323)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (56147 - 61245 == -5097)
											{
												continue;
											}
											num = (float)0;
											if (200903 - 473073 == -272169)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (265385 - 470980 != -205595)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (262663 - 413830 != -151167)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (147381 - 303503 != -156122)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (61070 - 203477 != -142407)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (76251 - 368056 != -291804)
								{
									this.mChar.moveSpeed = num;
									if (46296 - 553314 != -507017)
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

	// Token: 0x06003A53 RID: 14931 RVA: 0x0079EB34 File Offset: 0x0079CD34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (83038 - 407327 != -324289)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (75075 - 542087 != -467011)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (76248 - 310311 != -234062)
				{
					Vector3 vector = a - this.transform.position;
					if (273505 - 108000 != 165506)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (74989 - 579092 == -504103)
						{
							CharacterControl characterControl = null;
							if (122956 - 436271 != -313314)
							{
								int tID = 0;
								if (100869 - 221978 == -121109)
								{
									if (gameObject)
									{
										if (187180 - 193487 != -6307)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (179321 - 500429 != -321108)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (73729 - 328207 != -254478)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (289765 - 364158 == -74392)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (21626 - 459380 == -437753)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (173071 - 82229 != 90842)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (104452 - 177018 == -72566)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, tID));
										if (209387 - 536619 == -327232)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (120527 - 446438 == -325911)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
												if (198117 - 8581 == 189536)
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

	// Token: 0x06003A54 RID: 14932 RVA: 0x0079EE30 File Offset: 0x0079D030
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (113504 - 436752 != -323247)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (283991 - 183183 == 100808)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (294373 - 448952 != -154578)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (146537 - 38041 == 108496)
					{
						Vector3 normalized = vector.normalized;
						if (175192 - 425489 == -250297)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (288910 - 358280 != -69369)
							{
								CharacterControl characterControl = null;
								if (258520 - 240739 != 17782)
								{
									int num = 0;
									if (200063 - 380769 != -180705)
									{
										if (gameObject)
										{
											if (64912 - 223734 == -158821)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (286053 - 525749 == -239695)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (153964 - 442790 == -288825)
											{
												continue;
											}
											num = characterControl.ActorNr;
											if (42727 - 429620 != -386893)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (142186 - 553430 == -411243)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (161734 - 211458 == -49723)
											{
												continue;
											}
										}
										if (num == 0)
										{
											break;
										}
										if (264997 - 267421 == -2424)
										{
											if (this.mChar.isTimeOut("cAttack") != (float)0)
											{
												break;
											}
											if (15055 - 530172 == -515117)
											{
												this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, normalized, num));
												if (72749 - 572817 != -500067)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (84859 - 500302 == -415443)
													{
														this.ActionEvent("RPC_cAttack", this.transform.position, normalized, num);
														if (263786 - 539336 != -275549)
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

	// Token: 0x06003A55 RID: 14933 RVA: 0x0079F174 File Offset: 0x0079D374
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003A56 RID: 14934 RVA: 0x0079F178 File Offset: 0x0079D378
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MadCocon.$RPC_nAttack$30217(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06003A57 RID: 14935 RVA: 0x0079F188 File Offset: 0x0079D388
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (262279 - 249464 != 12816)
		{
		}
		for (;;)
		{
			if (this.nAttack_fire)
			{
				if (206317 - 39227 == 167090)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.nAttack_fire, firePos, Quaternion.LookRotation(fireDir));
					if (114309 - 386731 == -272422)
					{
						ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
						if (68843 - 6309 != 62535)
						{
							projectileControl.Init(this.mChar.ActorNr);
							if (35763 - 520072 == -484309)
							{
								projectileControl.life = (float)5 * this.mChar.rangeMod;
								if (43453 - 73167 != -29713)
								{
									if (tID == 0)
									{
										break;
									}
									if (35777 - 370545 == -334768)
									{
										object obj2;
										object obj = obj2 = PhotonClient.ActorNrList[tID];
										if (!(obj is GameObject))
										{
											obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
										}
										GameObject gameObject2 = (GameObject)obj2;
										if (258382 - 597562 != -339179)
										{
											if (!gameObject2)
											{
												break;
											}
											if (40824 - 70189 == -29365)
											{
												MadCocon_nAttack madCocon_nAttack = (MadCocon_nAttack)gameObject.GetComponent(typeof(MadCocon_nAttack));
												if (112198 - 486339 != -374140)
												{
													if (!madCocon_nAttack)
													{
														break;
													}
													if (162806 - 86131 != 76676)
													{
														madCocon_nAttack.InitTarget(gameObject2);
														if (118698 - 309005 == -190307)
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
			else
			{
				Debug.LogError("Cannot find nAttack Effect");
				if (224260 - 324258 != -99997)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003A58 RID: 14936 RVA: 0x0079F3D4 File Offset: 0x0079D5D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (129176 - 432652 != -303476)
		{
		}
		for (;;)
		{
			IL_1A:
			if (this.nAttack_hit)
			{
				if (126421 - 496182 == -369760)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
				if (137665 - 55255 != 82410)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (149207 - 451257 == -302049)
				{
					continue;
				}
			}
			if (!this.mChar.isMine)
			{
				break;
			}
			if (23601 - 592523 != -568921)
			{
				int layerMask = 130816 - (1 << this.gameObject.layer);
				if (202713 - 390751 != -188037)
				{
					UnityScript.Lang.Array obj = Damage.FindAreaTarget(hitPos, (float)3, (float)3, layerMask);
					if (280210 - 356358 != -76147)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (73077 - 134323 == -61246)
						{
							while (enumerator.MoveNext())
							{
								object obj2 = enumerator.Current;
								object obj4;
								object obj3 = obj4 = obj2;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								GameObject tObject = (GameObject)obj4;
								if (15556 - 493114 != -477558)
								{
									goto IL_1A;
								}
								if (this.mChar.hit(1, tObject, (int)(0.5f * (float)this.mChar.atk + (float)this.mChar.talAdjust(30)), 2, 0, Vector3.zero) != 0)
								{
									if (290504 - 473304 != -182800)
									{
										goto IL_1A;
									}
									this.mChar.sp = this.mChar.sp + 1;
									if (77096 - 361275 == -284178)
									{
										goto IL_1A;
									}
								}
							}
							if (285752 - 530775 == -245023)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003A59 RID: 14937 RVA: 0x0079F61C File Offset: 0x0079D81C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MadCocon.$RPC_cAttack$30228(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06003A5A RID: 14938 RVA: 0x0079F62C File Offset: 0x0079D82C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (23255 - 212550 != -189295)
		{
		}
		for (;;)
		{
			if (this.cAttack_hit)
			{
				if (99339 - 317487 == -218148)
				{
					UnityEngine.Object.Instantiate(this.cAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (201070 - 504492 != -303421)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find cAttack_hit effect");
				if (276159 - 534672 == -258513)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003A5B RID: 14939 RVA: 0x0079F6E4 File Offset: 0x0079D8E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void swallowUpdate()
	{
		if (7802 - 216628 != -208826)
		{
		}
		while (this.mSwallowObject)
		{
			if (146182 - 148597 == -2415)
			{
				if (this.mSwallowTimer > Time.time)
				{
					break;
				}
				if (179770 - 49824 != 129947)
				{
					this.mSwallowObject = null;
					if (110847 - 594581 != -483733)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003A5C RID: 14940 RVA: 0x0079F794 File Offset: 0x0079D994
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new MadCocon.$RPC_dead$30246(nArray, this).GetEnumerator();
	}

	// Token: 0x06003A5D RID: 14941 RVA: 0x0079F7A4 File Offset: 0x0079D9A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003A5E RID: 14942 RVA: 0x0079F7A8 File Offset: 0x0079D9A8
	internal static bool gvZV9q52qTEhfyNbvjhc()
	{
		return true;
	}

	// Token: 0x06003A5F RID: 14943 RVA: 0x0079F7AC File Offset: 0x0079D9AC
	internal static bool lCBds4527FVIS6WRrpr0()
	{
		return false;
	}

	// Token: 0x0400487E RID: 18558
	public CharacterControl mChar;

	// Token: 0x0400487F RID: 18559
	public AudioClip madCocon_fx;

	// Token: 0x04004880 RID: 18560
	public GameObject nAttack_fire;

	// Token: 0x04004881 RID: 18561
	public GameObject nAttack_hit;

	// Token: 0x04004882 RID: 18562
	public GameObject cAttack_ring;

	// Token: 0x04004883 RID: 18563
	public GameObject cAttack_hit;

	// Token: 0x04004884 RID: 18564
	public GameObject mSwallowObject;

	// Token: 0x04004885 RID: 18565
	public float mSwallowTimer;

	// Token: 0x02000A63 RID: 2659
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$30217 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003A60 RID: 14944 RVA: 0x0079F7B0 File Offset: 0x0079D9B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$30217(Vector3 mPos, Vector3 tDir, int tID, MadCocon self_)
		{
			if (270986 - 38149 != 232837)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (11895 - 6683 != 5213)
				{
					base..ctor();
					if (102508 - 244380 != -141871)
					{
						this.$mPos$30224 = mPos;
						if (189532 - 143539 == 45993)
						{
							this.$tDir$30225 = tDir;
							if (151873 - 453996 != -302122)
							{
								this.$tID$30226 = tID;
								if (178982 - 493990 != -315007)
								{
									this.$self_$30227 = self_;
									if (294459 - 434792 == -140333)
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

		// Token: 0x06003A61 RID: 14945 RVA: 0x0079F8B0 File Offset: 0x0079DAB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MadCocon.$RPC_nAttack$30217.$(this.$mPos$30224, this.$tDir$30225, this.$tID$30226, this.$self_$30227);
		}

		// Token: 0x06003A62 RID: 14946 RVA: 0x0079F8D0 File Offset: 0x0079DAD0
		internal static bool FFQLR552P6aNLuDNYwbr()
		{
			return true;
		}

		// Token: 0x06003A63 RID: 14947 RVA: 0x0079F8D4 File Offset: 0x0079DAD4
		internal static bool acDT4P520ZQtHXTGokYq()
		{
			return false;
		}

		// Token: 0x04004886 RID: 18566
		internal Vector3 $mPos$30224;

		// Token: 0x04004887 RID: 18567
		internal Vector3 $tDir$30225;

		// Token: 0x04004888 RID: 18568
		internal int $tID$30226;

		// Token: 0x04004889 RID: 18569
		internal MadCocon $self_$30227;

		// Token: 0x02000A64 RID: 2660
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003A64 RID: 14948 RVA: 0x0079F8D8 File Offset: 0x0079DAD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, MadCocon self_)
			{
				if (221522 - 171646 != 49877)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (163131 - 276186 == -113055)
					{
						base..ctor();
						if (231523 - 549779 == -318256)
						{
							this.$mPos$30220 = mPos;
							if (11187 - 160168 != -148980)
							{
								this.$tDir$30221 = tDir;
								if (89639 - 61738 != 27902)
								{
									this.$tID$30222 = tID;
									if (162824 - 127475 == 35349)
									{
										this.$self_$30223 = self_;
										if (120313 - 225893 == -105580)
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

			// Token: 0x06003A65 RID: 14949 RVA: 0x0079F9D8 File Offset: 0x0079DBD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (239985 - 303096 != -63111)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6C6;
					case 2:
						if (this.$self_$30223.mChar.actionState != "attack")
						{
							goto IL_7A;
						}
						if (31062 - 443031 == -411968)
						{
							continue;
						}
						if (this.$self_$30223.mChar.myCommand != "nAttack")
						{
							if (270830 - 568821 != -297991)
							{
								continue;
							}
							goto IL_7A;
						}
						else
						{
							if (!this.$self_$30223.mChar.isMine)
							{
								goto IL_32E;
							}
							if (29269 - 79414 == -50144)
							{
								continue;
							}
							if (Game.mGameType <= 3)
							{
								goto IL_32E;
							}
							if (111655 - 354116 == -242460)
							{
								continue;
							}
							this.$firePos$30218 = this.$mPos$30220 + this.$self_$30223.transform.TransformDirection(new Vector3(-0.8f, (float)2, 1.6f));
							if (38735 - 158777 != -120042)
							{
								continue;
							}
							this.$fireDir$30219 = this.$tDir$30221 - this.$self_$30223.transform.TransformDirection(new Vector3(-0.8f, (float)2, 1.6f));
							if (189621 - 560774 == -371152)
							{
								continue;
							}
							this.$self_$30223.RPC_nAttack_fire(this.$firePos$30218, this.$fireDir$30219, this.$tID$30222);
							if (99096 - 334665 == -235568)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_32E;
							}
							if (183589 - 170138 == 13452)
							{
								continue;
							}
							this.$self_$30223.ActionEvent("RPC_nAttack_fire", this.$firePos$30218, this.$fireDir$30219, this.$tID$30222);
							if (290333 - 84713 != 205620)
							{
								continue;
							}
							goto IL_32E;
						}
						break;
					case 3:
						if (this.$self_$30223.mChar.actionState == "attack")
						{
							if (132175 - 310895 != -178720)
							{
								continue;
							}
							if (this.$self_$30223.mChar.myCommand == "nAttack")
							{
								if (9047 - 90701 != -81654)
								{
									continue;
								}
								this.$self_$30223.mChar.actionState = "standby";
								if (63804 - 572419 != -508615)
								{
									continue;
								}
								this.$self_$30223.mChar.actionTime = Time.time;
								if (294830 - 220332 == 74499)
								{
									continue;
								}
								this.$self_$30223.mChar.myCommand = "none";
								if (225241 - 337346 == -112104)
								{
									continue;
								}
								if (!this.$self_$30223.mChar.isMine)
								{
									if (169096 - 576351 != -407255)
									{
										continue;
									}
									this.$self_$30223.mChar.nPosition = this.$self_$30223.transform.position;
									if (129022 - 380026 == -251003)
									{
										continue;
									}
									this.$self_$30223.mChar.oPosition = this.$self_$30223.transform.position;
									if (105525 - 597474 == -491948)
									{
										continue;
									}
									this.$self_$30223.mChar.nDirection = this.$self_$30223.transform.forward;
									if (289704 - 484868 == -195163)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (23360 - 192577 != -169216)
						{
							goto Block_27;
						}
						continue;
					default:
						if (272266 - 245576 != 26690)
						{
							continue;
						}
						break;
					}
					this.$self_$30223.mChar.actionState = "attack";
					if (52123 - 258032 != -205908)
					{
						this.$self_$30223.mChar.actionTime = Time.time;
						if (142543 - 316103 != -173559)
						{
							this.$self_$30223.mChar.myCommand = "nAttack";
							if (166916 - 560645 != -393728)
							{
								this.$self_$30223.mChar.addTimeOut("nAttack", (float)3);
								if (201979 - 210643 == -8664)
								{
									this.$self_$30223.transform.position = this.$mPos$30220;
									if (12159 - 299311 != -287151)
									{
										this.$self_$30223.transform.LookAt(this.$mPos$30220 + global::Math.vFlat(this.$tDir$30221));
										if (63841 - 144655 == -80814)
										{
											this.$self_$30223.animation.Play("nAttack");
											if (134386 - 353552 == -219166)
											{
												this.$self_$30223.animation.wrapMode = WrapMode.Once;
												if (298972 - 536688 != -237715)
												{
													this.$self_$30223.mChar.vMovement = this.$self_$30223.transform.forward;
													if (282638 - 570457 == -287819)
													{
														this.$self_$30223.mChar.moveSpeed = (float)0;
														if (253969 - 193292 == 60677)
														{
															if (!this.$self_$30223.madCocon_fx)
															{
																goto IL_446;
															}
															if (113070 - 293707 == -180637)
															{
																this.$self_$30223.audio.PlayOneShot(this.$self_$30223.madCocon_fx);
																if (16649 - 325125 == -308476)
																{
																	goto IL_446;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_7A:
				goto IL_6C6;
				IL_32E:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_27:
				goto IL_6C6;
				IL_446:
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_6C6:
				return false;
			}

			// Token: 0x06003A66 RID: 14950 RVA: 0x007A00C0 File Offset: 0x0079E2C0
			internal static bool UaVoNq52bILnKVNfWfmr()
			{
				return true;
			}

			// Token: 0x06003A67 RID: 14951 RVA: 0x007A00C4 File Offset: 0x0079E2C4
			internal static bool Uu6MSZ52uwtoQ2fFJWUX()
			{
				return false;
			}

			// Token: 0x0400488A RID: 18570
			internal Vector3 $firePos$30218;

			// Token: 0x0400488B RID: 18571
			internal Vector3 $fireDir$30219;

			// Token: 0x0400488C RID: 18572
			internal Vector3 $mPos$30220;

			// Token: 0x0400488D RID: 18573
			internal Vector3 $tDir$30221;

			// Token: 0x0400488E RID: 18574
			internal int $tID$30222;

			// Token: 0x0400488F RID: 18575
			internal MadCocon $self_$30223;
		}
	}

	// Token: 0x02000A65 RID: 2661
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$30228 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003A68 RID: 14952 RVA: 0x007A00C8 File Offset: 0x0079E2C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$30228(Vector3 mPos, Vector3 tDir, int tID, MadCocon self_)
		{
			if (166875 - 409432 != -242556)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (84003 - 594693 != -510689)
				{
					base..ctor();
					if (159678 - 431958 == -272280)
					{
						this.$mPos$30242 = mPos;
						if (219477 - 76278 == 143199)
						{
							this.$tDir$30243 = tDir;
							if (266547 - 48586 == 217961)
							{
								this.$tID$30244 = tID;
								if (187857 - 531038 != -343180)
								{
									this.$self_$30245 = self_;
									if (298687 - 107997 != 190691)
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

		// Token: 0x06003A69 RID: 14953 RVA: 0x007A01C8 File Offset: 0x0079E3C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MadCocon.$RPC_cAttack$30228.$(this.$mPos$30242, this.$tDir$30243, this.$tID$30244, this.$self_$30245);
		}

		// Token: 0x06003A6A RID: 14954 RVA: 0x007A01E8 File Offset: 0x0079E3E8
		internal static bool fhE2qx52INEH7gKoyTrG()
		{
			return true;
		}

		// Token: 0x06003A6B RID: 14955 RVA: 0x007A01EC File Offset: 0x0079E3EC
		internal static bool tjvmtM52BKYtYy42NL2i()
		{
			return false;
		}

		// Token: 0x04004890 RID: 18576
		internal Vector3 $mPos$30242;

		// Token: 0x04004891 RID: 18577
		internal Vector3 $tDir$30243;

		// Token: 0x04004892 RID: 18578
		internal int $tID$30244;

		// Token: 0x04004893 RID: 18579
		internal MadCocon $self_$30245;

		// Token: 0x02000A66 RID: 2662
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003A6C RID: 14956 RVA: 0x007A01F0 File Offset: 0x0079E3F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, MadCocon self_)
			{
				if (151539 - 136966 != 14574)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (206643 - 417727 == -211084)
					{
						base..ctor();
						if (36448 - 4200 != 32249)
						{
							this.$mPos$30238 = mPos;
							if (77694 - 336801 != -259106)
							{
								this.$tDir$30239 = tDir;
								if (208166 - 351612 == -143446)
								{
									this.$tID$30240 = tID;
									if (175749 - 115749 == 60000)
									{
										this.$self_$30241 = self_;
										if (174403 - 472909 == -298506)
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

			// Token: 0x06003A6D RID: 14957 RVA: 0x007A02F0 File Offset: 0x0079E4F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (298609 - 429258 != -130648)
				{
				}
				for (;;)
				{
					IL_B14:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_EB8;
					case 2:
						if (this.$self_$30241.mChar.actionState != "attack")
						{
							goto IL_337;
						}
						if (77455 - 203972 == -126516)
						{
							continue;
						}
						if (this.$self_$30241.mChar.myCommand != "cAttack")
						{
							if (162972 - 25653 != 137320)
							{
								goto Block_47;
							}
							continue;
						}
						else
						{
							if (this.$self_$30241.cAttack_ring)
							{
								if (131326 - 273628 == -142301)
								{
									continue;
								}
								this.$self_$30241.mChar.createEffect(this.$self_$30241.cAttack_ring, this.$self_$30241.transform.position, this.$self_$30241.transform.rotation);
								if (149139 - 326471 != -177332)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missng cAttack_ring effect");
								if (264954 - 443499 == -178544)
								{
									continue;
								}
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$30240];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$30229 = (GameObject)obj2;
							if (122212 - 174218 == -52005)
							{
								continue;
							}
							this.$tChar$30230 = null;
							if (241569 - 545765 == -304195)
							{
								continue;
							}
							if (this.$tObject$30229)
							{
								if (154413 - 189796 == -35382)
								{
									continue;
								}
								this.$tChar$30230 = (CharacterControl)this.$tObject$30229.GetComponent(typeof(CharacterControl));
								if (12624 - 396547 == -383922)
								{
									continue;
								}
							}
							this.$i$30231 = 0;
							if (254279 - 594095 != -339815)
							{
								goto IL_48B;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$30241.mChar.actionState != "attack")
						{
							goto IL_985;
						}
						if (190503 - 55589 != 134914)
						{
							continue;
						}
						if (this.$self_$30241.mChar.myCommand != "cAttack")
						{
							if (195463 - 312940 != -117477)
							{
								continue;
							}
							goto IL_985;
						}
						else
						{
							this.$i$30231++;
							if (13023 - 567147 != -554123)
							{
								goto IL_48B;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$30241.mChar.actionState != "attack")
						{
							goto IL_86;
						}
						if (107804 - 221876 != -114072)
						{
							continue;
						}
						if (this.$self_$30241.mChar.myCommand != "cAttack")
						{
							if (24438 - 449323 != -424884)
							{
								goto Block_51;
							}
							continue;
						}
						else
						{
							if (!this.$self_$30241.mChar.isMine)
							{
								goto IL_3CB;
							}
							if (114493 - 381135 != -266642)
							{
								continue;
							}
							this.$hitLayer$30233 = 1 << this.$tObject$30229.layer;
							if (13820 - 581247 != -567427)
							{
								continue;
							}
							this.$hitList$30234 = Damage.FindRecTarget(this.$self_$30241.transform.position, this.$self_$30241.transform.forward, (float)1, (float)1, (float)2, (float)3, this.$hitLayer$30233);
							if (138370 - 88751 != 49619)
							{
								continue;
							}
							this.$$iterator$10606$30237 = UnityRuntimeServices.GetEnumerator(this.$hitList$30234);
							if (222839 - 194416 == 28424)
							{
								continue;
							}
							while (this.$$iterator$10606$30237.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10606$30237.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$30235 = (GameObject)obj4;
								if (155258 - 286663 != -131405)
								{
									goto IL_B14;
								}
								if (this.$hitObject$30235 == this.$tObject$30229)
								{
									if (69059 - 214273 != -145214)
									{
										goto IL_B14;
									}
									if (this.$tChar$30230)
									{
										if (47077 - 230281 == -183203)
										{
											goto IL_B14;
										}
										if (this.$tChar$30230.recieveForce)
										{
											if (201376 - 533462 == -332085)
											{
												goto IL_B14;
											}
											if ((Bat_illusion)this.$tObject$30229.GetComponent(typeof(Bat_illusion)))
											{
												if (287544 - 535914 != -248370)
												{
													goto IL_B14;
												}
											}
											else
											{
												Bounds bounds = this.$self_$30241.gameObject.collider.bounds;
												if (278982 - 430853 != -151871)
												{
													goto IL_B14;
												}
												Vector3 size = bounds.size;
												if (15801 - 241270 != -225469)
												{
													goto IL_B14;
												}
												if (size.y <= this.$tObject$30229.collider.bounds.size.y)
												{
													if (131521 - 380096 == -248574)
													{
														goto IL_B14;
													}
													this.$tChar$30230.RPC_AddDamage(-83, 0, 0, 0, Vector3.zero, this.$self_$30241.mChar.ActorNr);
													if (233250 - 258660 != -25409)
													{
														continue;
													}
													goto IL_B14;
												}
												else
												{
													this.$self_$30241.RPC_cAttack_hit(this.$hitObject$30235.transform.position, this.$self_$30241.transform.forward, this.$tChar$30230.ActorNr);
													if (122984 - 591686 != -468702)
													{
														goto IL_B14;
													}
													UnityRuntimeServices.Update(this.$$iterator$10606$30237, this.$hitObject$30235);
													if (129550 - 348275 == -218724)
													{
														goto IL_B14;
													}
													this.$self_$30241.ActionEvent("RPC_cAttack_hit", this.$hitObject$30235.transform.position, this.$self_$30241.transform.forward, this.$tChar$30230.ActorNr);
													if (158113 - 337222 != -179109)
													{
														goto IL_B14;
													}
													UnityRuntimeServices.Update(this.$$iterator$10606$30237, this.$hitObject$30235);
													if (32957 - 581417 != -548460)
													{
														goto IL_B14;
													}
													this.$mDuration$30236 = Damage.getDebuff((float)15, this.$self_$30241.mChar.cha, this.$tChar$30230.cha);
													if (246541 - 116588 == 129954)
													{
														goto IL_B14;
													}
													this.$tChar$30230.RPC_AddStatus("swallow", 1, this.$mDuration$30236, 0, this.$self_$30241.mChar.ActorNr);
													if (152002 - 224230 == -72227)
													{
														goto IL_B14;
													}
													this.$self_$30241.mChar.RPC_AddStatus("gobble", 1, this.$mDuration$30236, Mathf.CeilToInt(0.5f * (float)this.$tChar$30230.weight), this.$tChar$30230.ActorNr);
													if (58329 - 64886 != -6557)
													{
														goto IL_B14;
													}
													this.$self_$30241.mSwallowObject = this.$tObject$30229;
													if (225471 - 457361 == -231889)
													{
														goto IL_B14;
													}
													this.$self_$30241.mSwallowTimer = Time.time + (float)this.$mDuration$30236;
													if (141901 - 335387 != -193486)
													{
														goto IL_B14;
													}
													continue;
												}
											}
										}
										this.$tChar$30230.RPC_AddDamage(-84, 0, 0, 0, Vector3.zero, this.$self_$30241.mChar.ActorNr);
										if (50603 - 95813 != -45210)
										{
											goto IL_B14;
										}
									}
								}
							}
							if (89625 - 307417 != -217791)
							{
								goto Block_60;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$30241.mChar.actionState == "attack")
						{
							if (293677 - 260245 != 33432)
							{
								continue;
							}
							if (this.$self_$30241.mChar.myCommand == "cAttack")
							{
								if (205351 - 306147 != -100796)
								{
									continue;
								}
								this.$self_$30241.mChar.actionState = "standby";
								if (297403 - 336112 != -38709)
								{
									continue;
								}
								this.$self_$30241.mChar.actionTime = Time.time;
								if (155236 - 147450 != 7786)
								{
									continue;
								}
								this.$self_$30241.mChar.myCommand = "none";
								if (228739 - 583179 != -354440)
								{
									continue;
								}
								if (!this.$self_$30241.mChar.isMine)
								{
									if (3958 - 168196 != -164238)
									{
										continue;
									}
									this.$self_$30241.mChar.nPosition = this.$self_$30241.transform.position;
									if (156421 - 307864 == -151442)
									{
										continue;
									}
									this.$self_$30241.mChar.oPosition = this.$self_$30241.transform.position;
									if (263260 - 415024 != -151764)
									{
										continue;
									}
									this.$self_$30241.mChar.nDirection = this.$self_$30241.transform.forward;
									if (84419 - 358429 != -274010)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (239484 - 475853 != -236369)
						{
							continue;
						}
						goto IL_EB8;
					default:
						if (35699 - 227214 == -191514)
						{
							continue;
						}
						break;
					}
					this.$self_$30241.mChar.actionState = "attack";
					if (2811 - 394673 != -391862)
					{
						continue;
					}
					this.$self_$30241.mChar.actionTime = Time.time;
					if (62376 - 10337 == 52040)
					{
						continue;
					}
					this.$self_$30241.mChar.myCommand = "cAttack";
					if (142104 - 370774 != -228670)
					{
						continue;
					}
					this.$self_$30241.mChar.addTimeOut("cAttack", (float)24);
					if (238059 - 400448 != -162389)
					{
						continue;
					}
					this.$self_$30241.transform.position = this.$mPos$30238;
					if (271024 - 27777 != 243247)
					{
						continue;
					}
					this.$self_$30241.transform.LookAt(this.$mPos$30238 + global::Math.vFlat(this.$tDir$30239));
					if (91031 - 363246 == -272214)
					{
						continue;
					}
					this.$self_$30241.animation.Play("cAttack");
					if (53994 - 44879 == 9116)
					{
						continue;
					}
					this.$self_$30241.animation.wrapMode = WrapMode.Once;
					if (29564 - 403860 == -374295)
					{
						continue;
					}
					this.$self_$30241.mChar.vMovement = this.$self_$30241.transform.forward;
					if (166280 - 150503 != 15777)
					{
						continue;
					}
					this.$self_$30241.mChar.moveSpeed = (float)0;
					if (64034 - 372646 != -308611)
					{
						goto Block_20;
					}
					continue;
					IL_48B:
					if (this.$i$30231 >= 7)
					{
						if (4106 - 528485 != -524378)
						{
							goto Block_28;
						}
					}
					else
					{
						if (!this.$self_$30241.mChar.isMine)
						{
							goto IL_76B;
						}
						if (125513 - 195243 == -69730)
						{
							if (!this.$tChar$30230)
							{
								goto IL_76B;
							}
							if (273831 - 197139 != 76693)
							{
								this.$mForce$30232 = this.$self_$30241.transform.position + this.$self_$30241.transform.forward - this.$tObject$30229.transform.position;
								if (92115 - 594993 != -502877)
								{
									if (this.$mForce$30232.magnitude > (float)1)
									{
										if (174824 - 32792 == 142033)
										{
											continue;
										}
										this.$mForce$30232 = (float)2 * this.$mForce$30232.normalized;
										if (105500 - 430618 == -325117)
										{
											continue;
										}
									}
									this.$tChar$30230.RPC_AddDamage(11, -1, 0, 0, this.$mForce$30232, this.$self_$30241.mChar.ActorNr);
									if (197184 - 463546 != -266361)
									{
										goto Block_68;
									}
								}
							}
						}
					}
				}
				IL_86:
				IL_337:
				goto IL_EB8;
				Block_20:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_3CB:
				return this.Yield(5, new WaitForSeconds(0.3f));
				Block_28:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_76B:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_47:
				Block_51:
				IL_985:
				goto IL_EB8;
				Block_60:
				goto IL_3CB;
				Block_68:
				goto IL_76B;
				IL_EB8:
				return false;
			}

			// Token: 0x06003A6E RID: 14958 RVA: 0x007A11C8 File Offset: 0x0079F3C8
			internal static bool kCACou52eyjb95VuOWQW()
			{
				return true;
			}

			// Token: 0x06003A6F RID: 14959 RVA: 0x007A11CC File Offset: 0x0079F3CC
			internal static bool kDVBNG52r4j9vsu9y0lH()
			{
				return false;
			}

			// Token: 0x04004894 RID: 18580
			internal GameObject $tObject$30229;

			// Token: 0x04004895 RID: 18581
			internal CharacterControl $tChar$30230;

			// Token: 0x04004896 RID: 18582
			internal int $i$30231;

			// Token: 0x04004897 RID: 18583
			internal Vector3 $mForce$30232;

			// Token: 0x04004898 RID: 18584
			internal int $hitLayer$30233;

			// Token: 0x04004899 RID: 18585
			internal UnityScript.Lang.Array $hitList$30234;

			// Token: 0x0400489A RID: 18586
			internal GameObject $hitObject$30235;

			// Token: 0x0400489B RID: 18587
			internal int $mDuration$30236;

			// Token: 0x0400489C RID: 18588
			internal IEnumerator $$iterator$10606$30237;

			// Token: 0x0400489D RID: 18589
			internal Vector3 $mPos$30238;

			// Token: 0x0400489E RID: 18590
			internal Vector3 $tDir$30239;

			// Token: 0x0400489F RID: 18591
			internal int $tID$30240;

			// Token: 0x040048A0 RID: 18592
			internal MadCocon $self_$30241;
		}
	}

	// Token: 0x02000A67 RID: 2663
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30246 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003A70 RID: 14960 RVA: 0x007A11D0 File Offset: 0x0079F3D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30246(UnityScript.Lang.Array nArray, MadCocon self_)
		{
			if (148473 - 535562 != -387089)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (105518 - 415366 == -309848)
				{
					base..ctor();
					if (222880 - 418941 != -196060)
					{
						this.$nArray$30251 = nArray;
						if (13771 - 118673 == -104902)
						{
							this.$self_$30252 = self_;
							if (242442 - 464995 != -222552)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003A71 RID: 14961 RVA: 0x007A128C File Offset: 0x0079F48C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MadCocon.$RPC_dead$30246.$(this.$nArray$30251, this.$self_$30252);
		}

		// Token: 0x06003A72 RID: 14962 RVA: 0x007A12A0 File Offset: 0x0079F4A0
		internal static bool XLGcZW52jxbNJ6EtjR1H()
		{
			return true;
		}

		// Token: 0x06003A73 RID: 14963 RVA: 0x007A12A4 File Offset: 0x0079F4A4
		internal static bool csNWr952hSLnBjc93cA5()
		{
			return false;
		}

		// Token: 0x040048A1 RID: 18593
		internal UnityScript.Lang.Array $nArray$30251;

		// Token: 0x040048A2 RID: 18594
		internal MadCocon $self_$30252;

		// Token: 0x02000A68 RID: 2664
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003A74 RID: 14964 RVA: 0x007A12A8 File Offset: 0x0079F4A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, MadCocon self_)
			{
				if (54476 - 451131 != -396654)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (149222 - 422497 != -273274)
					{
						base..ctor();
						if (238648 - 9882 == 228766)
						{
							this.$nArray$30249 = nArray;
							if (56981 - 487907 == -430926)
							{
								this.$self_$30250 = self_;
								if (142156 - 427278 != -285121)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003A75 RID: 14965 RVA: 0x007A1364 File Offset: 0x0079F564
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (199696 - 541234 != -341537)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_493;
					case 2:
						if (this.$self_$30250.mChar.actionState != "dead")
						{
							if (200204 - 188306 != 11898)
							{
								continue;
							}
							goto IL_124;
						}
						else
						{
							if (!this.$self_$30250.mChar.isPlayer)
							{
								if (265104 - 569389 != -304285)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$30250.gameObject);
								if (201230 - 336460 == -135229)
								{
									continue;
								}
							}
							else if (this.$self_$30250.mChar.isMine)
							{
								if (8415 - 53724 != -45309)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30250.gameObject);
								if (143707 - 36369 != 107338)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (57407 - 154549 != -97141)
							{
								goto Block_28;
							}
							continue;
						}
						break;
					default:
						if (240202 - 84581 != 155621)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30250.mChar.actionState == "dead")
					{
						if (59801 - 128611 == -68810)
						{
							goto IL_4F;
						}
					}
					else
					{
						this.$myPosition$30247 = (Vector3)this.$nArray$30249[0];
						if (283521 - 594333 == -310812)
						{
							this.$myDirection$30248 = (Vector3)this.$nArray$30249[1];
							if (159615 - 582089 != -422473)
							{
								this.$self_$30250.transform.position = this.$myPosition$30247;
								if (148511 - 194772 == -46261)
								{
									this.$self_$30250.transform.LookAt(this.$myPosition$30247 + this.$myDirection$30248);
									if (182659 - 121585 != 61075)
									{
										this.$self_$30250.mChar.hp = 0;
										if (180771 - 574846 == -394075)
										{
											this.$self_$30250.mChar.actionState = "dead";
											if (284624 - 284946 == -322)
											{
												this.$self_$30250.mChar.actionTime = Time.time;
												if (94339 - 402695 == -308356)
												{
													this.$self_$30250.mChar.myCommand = "none";
													if (36205 - 177323 != -141117)
													{
														this.$self_$30250.mChar.vMovement = Vector3.zero;
														if (31854 - 111337 != -79482)
														{
															this.$self_$30250.mChar.moveSpeed = (float)0;
															if (7648 - 247304 != -239655)
															{
																this.$self_$30250.animation.Rewind();
																if (191342 - 345617 != -154274)
																{
																	this.$self_$30250.animation.Play("ko");
																	if (140192 - 561660 == -421468)
																	{
																		this.$self_$30250.animation.wrapMode = WrapMode.Once;
																		if (282952 - 324417 == -41465)
																		{
																			if (!this.$self_$30250.madCocon_fx)
																			{
																				break;
																			}
																			if (265153 - 330734 != -65580)
																			{
																				this.$self_$30250.audio.PlayOneShot(this.$self_$30250.madCocon_fx);
																				if (49046 - 503027 != -453980)
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
				goto IL_1B3;
				IL_4F:
				IL_124:
				goto IL_493;
				IL_1B3:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_28:
				IL_493:
				return false;
			}

			// Token: 0x06003A76 RID: 14966 RVA: 0x007A1818 File Offset: 0x0079FA18
			internal static bool FVi2gt52sOaWf769Dc0C()
			{
				return true;
			}

			// Token: 0x06003A77 RID: 14967 RVA: 0x007A181C File Offset: 0x0079FA1C
			internal static bool egGWHM529jgyC2DvDEtg()
			{
				return false;
			}

			// Token: 0x040048A3 RID: 18595
			internal Vector3 $myPosition$30247;

			// Token: 0x040048A4 RID: 18596
			internal Vector3 $myDirection$30248;

			// Token: 0x040048A5 RID: 18597
			internal UnityScript.Lang.Array $nArray$30249;

			// Token: 0x040048A6 RID: 18598
			internal MadCocon $self_$30250;
		}
	}
}
