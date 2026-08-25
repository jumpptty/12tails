using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A6A RID: 2666
[Serializable]
public class MadPeppon : MonoBehaviour
{
	// Token: 0x06003A85 RID: 14981 RVA: 0x007A37F4 File Offset: 0x007A19F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MadPeppon()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003A86 RID: 14982 RVA: 0x007A3804 File Offset: 0x007A1A04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (193895 - 493882 != -299986)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (81284 - 171919 == -90635)
			{
				this.mChar.actionState = "standby";
				if (58825 - 339193 != -280367)
				{
					this.mChar.actionTime = Time.time;
					if (198174 - 36657 != 161518)
					{
						this.mChar.myCommand = "none";
						if (1387 - 280813 != -279425)
						{
							this.mChar.hp = (this.mChar.mhp = 3300);
							if (35313 - 241415 != -206101)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003A87 RID: 14983 RVA: 0x007A3928 File Offset: 0x007A1B28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x06003A88 RID: 14984 RVA: 0x007A3944 File Offset: 0x007A1B44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (150052 - 485700 != -335648)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (172957 - 186162 != -13205)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (201017 - 301366 == -100348)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_127;
					}
					if (119261 - 322918 != -203657)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (166011 - 451148 != -285137)
				{
					continue;
				}
			}
			IL_127:
			if (this.mChar.hp > 0)
			{
				if (252151 - 51816 == 200336)
				{
					continue;
				}
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (100212 - 507283 == -407070)
				{
					continue;
				}
			}
			if (!(this.mChar.actionState != "dead"))
			{
				break;
			}
			if (98160 - 57741 != 40420)
			{
				if (this.mChar.isMine)
				{
					if (151334 - 469583 != -318248)
					{
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (61845 - 408202 == -346357)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (38960 - 92072 == -53112)
							{
								this.mChar.DeadEvent();
								if (86402 - 338931 == -252529)
								{
									break;
								}
							}
						}
					}
				}
				else if (this.mChar.hp <= 0)
				{
					if (285658 - 255105 == 30553)
					{
						this.mChar.hp = 1;
						if (175291 - 297652 != -122360)
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
					if (28841 - 85602 == -56761)
					{
						this.mChar.ko = 1;
						if (72452 - 454609 == -382157)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003A89 RID: 14985 RVA: 0x007A3C30 File Offset: 0x007A1E30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (71678 - 556813 != -485134)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (73858 - 191304 != -117445)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (255742 - 488312 != -232569 && 133374 - 273355 != -139980)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (251401 - 510208 == -258806)
						{
							continue;
						}
						v = 1;
						if (232853 - 101780 != 131073)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (191439 - 581276 == -389836)
						{
							continue;
						}
						v = -1;
						if (33173 - 215482 != -182309)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack")
					{
						if (198602 - 456729 != -258127)
						{
							continue;
						}
						v = 11;
						if (255459 - 437448 == -181988)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (274603 - 456575 != -181972)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (188057 - 500864 != -312806)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (54202 - 158767 != -104564)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (114529 - 171886 != -57356)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (26833 - 406506 == -379673)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (213274 - 331564 != -118289)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (267651 - 387874 == -120223)
										{
											Hashtable hashtable = new Hashtable();
											if (123271 - 390603 == -267332)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (196850 - 168410 == 28440)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (112171 - 107134 == 5037)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (56808 - 410828 == -354020)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (184838 - 293179 != -108340)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (181759 - 496289 == -314530)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (214272 - 532576 != -318303)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (239449 - 432250 != -192800)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (98244 - 140500 == -42256)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (178186 - 239051 == -60865)
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

	// Token: 0x06003A8A RID: 14986 RVA: 0x007A40FC File Offset: 0x007A22FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (364 - 396012 != -395648)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (154390 - 597909 != -443518)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (101821 - 103172 == -1351)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (55134 - 229852 != -174717)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (116259 - 111664 != 4596)
						{
							int num3 = num;
							if (55585 - 540467 == -484882)
							{
								if (num3 == 1)
								{
									if (283338 - 398412 == -115074)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (32727 - 394961 == -362234)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (297484 - 329598 == -32114)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (48532 - 17226 != 31307)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (65064 - 184458 == -119394)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (248207 - 471771 == -223564)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (203971 - 41238 != 162734)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (1050 - 519551 == -518501)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (195995 - 327896 != -131900)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (156713 - 515778 != -359064)
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

	// Token: 0x06003A8B RID: 14987 RVA: 0x007A440C File Offset: 0x007A260C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (56450 - 429773 != -373322)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (65122 - 207862 == -142740)
			{
				float runSpeed = this.mChar.runSpeed;
				if (233388 - 229346 != 4043)
				{
					Vector3 a = default(Vector3);
					if (225926 - 155231 == 70695)
					{
						Vector3 vector = Vector3.zero;
						if (132586 - 532794 == -400208)
						{
							float num2 = (float)0;
							if (263571 - 414540 != -150968)
							{
								if (this.mChar.isMine)
								{
									if (17918 - 448330 != -430412)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (89523 - 37846 != 51677)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (59151 - 212329 != -153178)
										{
											continue;
										}
										a.y = (float)0;
										if (199016 - 201424 == -2407)
										{
											continue;
										}
										a = a.normalized;
										if (31614 - 106055 != -74441)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (141632 - 415417 != -273785)
										{
											continue;
										}
										vector = vector.normalized;
										if (5218 - 369579 != -364361)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (17814 - 402358 != -384544)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (50592 - 433394 == -382801)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (132404 - 137285 == -4880)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (22650 - 306312 != -283662)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (83393 - 574108 == -490714)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (34539 - 54308 != -19769)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (273755 - 141619 == 132137)
														{
															continue;
														}
														this.animation.Play("run");
														if (155665 - 438096 == -282430)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (67083 - 40822 != 26261)
														{
															continue;
														}
														goto IL_B06;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (65587 - 589737 != -524150)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (159685 - 2002 != 157683)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (59153 - 388906 == -329752)
											{
												continue;
											}
											num = (float)0;
											if (75504 - 381060 == -305555)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (120997 - 203849 == -82851)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (100026 - 115119 == -15092)
										{
											continue;
										}
									}
									IL_B06:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (262742 - 256268 != 6474)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (299839 - 431384 != -131545)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (164637 - 351378 == -186740)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (141478 - 60867 == 80612)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (251431 - 292892 != -41461)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (15072 - 401864 != -386792)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (174221 - 291186 == -116964)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (144630 - 421928 == -277297)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (155008 - 391562 == -236553)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (30683 - 412254 == -381570)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (188770 - 479815 != -291045)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (26346 - 62209 == -35862)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (18263 - 456850 == -438586)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (82629 - 538896 != -456267)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (7959 - 198696 == -190736)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (87055 - 58992 != 28063)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (259315 - 513763 == -254447)
												{
													continue;
												}
												num = (float)0;
												if (102478 - 471253 != -368775)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (189589 - 226932 != -37343)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (63133 - 506202 == -443068)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (91546 - 312407 == -220860)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (217436 - 5755 != 211681)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (288878 - 43712 != 245166)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (95014 - 423101 != -328087)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (174452 - 236990 != -62538)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (33088 - 241342 != -208254)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (146783 - 308481 != -161698)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (39439 - 201576 == -162136)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (199273 - 427554 == -228280)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (133805 - 435471 != -301666)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (29485 - 61650 == -32164)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (198865 - 583752 != -384887)
											{
												continue;
											}
											num = (float)0;
											if (133365 - 186388 != -53023)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (83294 - 166841 == -83546)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (9291 - 525789 == -516497)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (150335 - 544371 != -394036)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (3300 - 477618 != -474318)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (150460 - 12687 != 137774)
								{
									this.mChar.moveSpeed = num;
									if (12719 - 409720 == -397001)
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

	// Token: 0x06003A8C RID: 14988 RVA: 0x007A4F70 File Offset: 0x007A3170
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (253246 - 497806 != -244559)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (238766 - 450022 != -211255)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (118383 - 200764 != -82380)
				{
					Vector3 vector = a - this.transform.position;
					if (55957 - 234325 == -178368)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (218204 - 348462 != -130257)
						{
							CharacterControl characterControl = null;
							if (278287 - 482493 != -204205 && 237932 - 525483 != -287550)
							{
								if (gameObject)
								{
									if (200 - 305520 != -305320)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (252833 - 324275 != -71442)
									{
										continue;
									}
								}
								if (characterControl)
								{
									if (107073 - 333597 != -226524)
									{
										continue;
									}
									int actorNr = characterControl.ActorNr;
									if (212308 - 66671 != 145637)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (151831 - 261295 == -109463)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (43023 - 85880 != -42857)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (206007 - 149395 == 56612)
								{
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
									if (282433 - 19586 != 262848)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (28105 - 569542 == -541437)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
											if (110988 - 347663 != -236674)
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

	// Token: 0x06003A8D RID: 14989 RVA: 0x007A5268 File Offset: 0x007A3468
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (283158 - 158871 != 124288)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (10424 - 599921 != -589496)
				{
					break;
				}
			}
			else
			{
				Vector3 vector = (Vector3)targetArray[0];
				if (19864 - 116272 == -96408)
				{
					Vector3 vector2 = global::Math.vFlat(vector - this.transform.position);
					if (1713 - 325608 != -323894)
					{
						Vector3 vector3 = vector2.normalized;
						if (87955 - 582558 != -494602)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (8870 - 141965 != -133094)
							{
								CharacterControl characterControl = null;
								if (150094 - 19430 == 130664)
								{
									if (209201 - 353452 == -144251)
									{
										if (gameObject)
										{
											if (14253 - 357186 != -342933)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (127063 - 106946 == 20118)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (245352 - 502537 != -257185)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (113609 - 151301 != -37692)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (151478 - 269002 != -117524)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (74139 - 389089 == -314949)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (100135 - 275358 == -175223)
										{
											if (gameObject)
											{
												if (140075 - 422722 != -282647)
												{
													continue;
												}
												vector = global::Math.getSpawnPos(gameObject.transform.position - vector3 * gameObject.collider.bounds.extents.x);
												if (279904 - 392854 == -112949)
												{
													continue;
												}
												if (vector != Vector3.zero)
												{
													if (102401 - 245554 != -143153)
													{
														continue;
													}
													vector3 *= (float)-1;
													if (207691 - 546406 == -338714)
													{
														continue;
													}
												}
												else
												{
													vector = this.transform.position;
													if (252988 - 413205 != -160217)
													{
														continue;
													}
												}
											}
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector3, 0));
											if (291067 - 148602 != 142466)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (55917 - 496227 == -440310)
												{
													this.ActionEvent("RPC_cAttack", vector, vector3, 0);
													if (264897 - 280770 == -15873)
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

	// Token: 0x06003A8E RID: 14990 RVA: 0x007A5664 File Offset: 0x007A3864
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003A8F RID: 14991 RVA: 0x007A5668 File Offset: 0x007A3868
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MadPeppon.$RPC_nAttack$30253(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003A90 RID: 14992 RVA: 0x007A5678 File Offset: 0x007A3878
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (163661 - 358586 != -194925)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (49241 - 529740 != -480498)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (276796 - 529650 == -252854)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (181545 - 558440 != -376894)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003A91 RID: 14993 RVA: 0x007A5730 File Offset: 0x007A3930
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MadPeppon.$RPC_cAttack$30267(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003A92 RID: 14994 RVA: 0x007A5740 File Offset: 0x007A3940
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new MadPeppon.$RPC_dead$30281(nArray, this).GetEnumerator();
	}

	// Token: 0x06003A93 RID: 14995 RVA: 0x007A5750 File Offset: 0x007A3950
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003A94 RID: 14996 RVA: 0x007A5754 File Offset: 0x007A3954
	internal static bool nllCfa52zrm0vZp55lQu()
	{
		return true;
	}

	// Token: 0x06003A95 RID: 14997 RVA: 0x007A5758 File Offset: 0x007A3958
	internal static bool Xn0Dc358a7iUBPl0Bkcm()
	{
		return false;
	}

	// Token: 0x040048AD RID: 18605
	public CharacterControl mChar;

	// Token: 0x040048AE RID: 18606
	public AudioClip madPeppon_fx;

	// Token: 0x040048AF RID: 18607
	public GameObject nAttack_hit;

	// Token: 0x040048B0 RID: 18608
	public GameObject cAttack_ring1;

	// Token: 0x040048B1 RID: 18609
	public GameObject cAttack_ring2;

	// Token: 0x02000A6B RID: 2667
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$30253 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003A96 RID: 14998 RVA: 0x007A575C File Offset: 0x007A395C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$30253(Vector3 mPos, Vector3 tDir, MadPeppon self_)
		{
			if (218403 - 248892 != -30489)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (91755 - 6026 != 85730)
				{
					base..ctor();
					if (131426 - 217163 == -85737)
					{
						this.$mPos$30264 = mPos;
						if (108577 - 73040 == 35537)
						{
							this.$tDir$30265 = tDir;
							if (27536 - 271634 != -244097)
							{
								this.$self_$30266 = self_;
								if (233449 - 101731 != 131719)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003A97 RID: 14999 RVA: 0x007A5838 File Offset: 0x007A3A38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MadPeppon.$RPC_nAttack$30253.$(this.$mPos$30264, this.$tDir$30265, this.$self_$30266);
		}

		// Token: 0x06003A98 RID: 15000 RVA: 0x007A5854 File Offset: 0x007A3A54
		internal static bool tLTS3t585jVmRrDfipXk()
		{
			return true;
		}

		// Token: 0x06003A99 RID: 15001 RVA: 0x007A5858 File Offset: 0x007A3A58
		internal static bool vGLORe58pqTE4QBrBfcK()
		{
			return false;
		}

		// Token: 0x040048B2 RID: 18610
		internal Vector3 $mPos$30264;

		// Token: 0x040048B3 RID: 18611
		internal Vector3 $tDir$30265;

		// Token: 0x040048B4 RID: 18612
		internal MadPeppon $self_$30266;

		// Token: 0x02000A6C RID: 2668
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003A9A RID: 15002 RVA: 0x007A585C File Offset: 0x007A3A5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, MadPeppon self_)
			{
				if (297878 - 83123 != 214755)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (97393 - 95713 == 1680)
					{
						base..ctor();
						if (249202 - 239887 == 9315)
						{
							this.$mPos$30261 = mPos;
							if (268125 - 21288 == 246837)
							{
								this.$tDir$30262 = tDir;
								if (239368 - 187337 == 52031)
								{
									this.$self_$30263 = self_;
									if (196911 - 271492 == -74581)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003A9B RID: 15003 RVA: 0x007A5938 File Offset: 0x007A3B38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (121845 - 179021 != -57175)
				{
				}
				for (;;)
				{
					IL_656:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_ABD;
					case 2:
						if (this.$self_$30263.mChar.actionState != "attack")
						{
							goto IL_45D;
						}
						if (5736 - 240313 != -234577)
						{
							continue;
						}
						if (this.$self_$30263.mChar.myCommand != "nAttack")
						{
							if (170637 - 443339 != -272702)
							{
								continue;
							}
							goto IL_45D;
						}
						else
						{
							this.$self_$30263.mChar.moveSpeed = (float)6;
							if (21085 - 233463 != -212378)
							{
								continue;
							}
							this.$i$30254 = 0;
							if (144953 - 364871 != -219918)
							{
								continue;
							}
							goto IL_1BF;
						}
						break;
					case 3:
						if (this.$self_$30263.mChar.actionState != "attack")
						{
							goto IL_49;
						}
						if (214669 - 168020 == 46650)
						{
							continue;
						}
						if (this.$self_$30263.mChar.myCommand != "nAttack")
						{
							if (161970 - 159865 != 2105)
							{
								continue;
							}
							goto IL_49;
						}
						else
						{
							if (this.$i$30254 == 1)
							{
								if (103039 - 250773 != -147734)
								{
									continue;
								}
								this.$self_$30263.mChar.moveSpeed = (float)0;
								if (176536 - 401107 != -224571)
								{
									continue;
								}
							}
							if (this.$self_$30263.mChar.isMine)
							{
								if (75257 - 566565 == -491307)
								{
									continue;
								}
								this.$hitLayer$30255 = 130816 - (1 << this.$self_$30263.gameObject.layer);
								if (20461 - 338479 == -318017)
								{
									continue;
								}
								this.$hitList$30256 = Damage.FindRecTarget(this.$self_$30263.transform.position, this.$self_$30263.transform.forward, (float)1, (float)1, 2.4f, (float)3, this.$hitLayer$30255);
								if (218594 - 11159 != 207435)
								{
									continue;
								}
								this.$$iterator$10609$30260 = UnityRuntimeServices.GetEnumerator(this.$hitList$30256);
								if (161573 - 279732 != -118159)
								{
									continue;
								}
								while (this.$$iterator$10609$30260.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10609$30260.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$30257 = (GameObject)obj2;
									if (229142 - 174275 == 54868)
									{
										goto IL_656;
									}
									this.$hitDmg$30258 = this.$self_$30263.mChar.atk + ((Quaternion.Angle(this.$self_$30263.transform.rotation, this.$hitObject$30257.transform.rotation) >= (float)45) ? 0 : 45);
									if (80798 - 450116 != -369318)
									{
										goto IL_656;
									}
									UnityRuntimeServices.Update(this.$$iterator$10609$30260, this.$hitObject$30257);
									if (54731 - 595173 == -540441)
									{
										goto IL_656;
									}
									if (this.$self_$30263.mChar.hit(1, this.$hitObject$30257, this.$hitDmg$30258, 1, 0, (float)2 * this.$self_$30263.transform.forward) != 0)
									{
										if (180881 - 54463 == 126419)
										{
											goto IL_656;
										}
										this.$hitPos$30259 = this.$hitObject$30257.collider.ClosestPointOnBounds(this.$self_$30263.transform.position + Vector3.up);
										if (278891 - 388736 == -109844)
										{
											goto IL_656;
										}
										UnityRuntimeServices.Update(this.$$iterator$10609$30260, this.$hitObject$30257);
										if (190870 - 394925 == -204054)
										{
											goto IL_656;
										}
										this.$self_$30263.RPC_nAttack_hit(this.$hitPos$30259, this.$self_$30263.transform.forward, 0);
										if (35860 - 449734 != -413874)
										{
											goto IL_656;
										}
										if (PhotonClient.IsInitialized())
										{
											if (105635 - 327620 == -221984)
											{
												goto IL_656;
											}
											this.$self_$30263.ActionEvent("RPC_nAttack_hit", this.$hitPos$30259, this.$self_$30263.transform.forward, 0);
											if (252725 - 408138 == -155412)
											{
												goto IL_656;
											}
										}
										if ((float)this.$hitDmg$30258 > 0.5f * (float)this.$self_$30263.mChar.atk)
										{
											if (280715 - 297625 == -16909)
											{
												goto IL_656;
											}
											if (this.$hitObject$30257 == Game.mPlayer)
											{
												if (296424 - 177890 != 118534)
												{
													goto IL_656;
												}
												Camera.main.SendMessage("newGameMessage", "HiddenFan!");
												if (200010 - 483093 != -283083)
												{
													goto IL_656;
												}
											}
										}
									}
								}
								if (213844 - 275020 != -61176)
								{
									continue;
								}
							}
							this.$i$30254++;
							if (156107 - 549615 != -393507)
							{
								goto IL_1BF;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$30263.mChar.actionState == "attack")
						{
							if (122127 - 398037 != -275910)
							{
								continue;
							}
							if (this.$self_$30263.mChar.myCommand == "nAttack")
							{
								if (197253 - 282538 != -85285)
								{
									continue;
								}
								this.$self_$30263.mChar.actionState = "standby";
								if (279727 - 495908 == -216180)
								{
									continue;
								}
								this.$self_$30263.mChar.actionTime = Time.time;
								if (268225 - 338375 != -70150)
								{
									continue;
								}
								this.$self_$30263.mChar.myCommand = "none";
								if (23969 - 537225 != -513256)
								{
									continue;
								}
								if (!this.$self_$30263.mChar.isMine)
								{
									if (240480 - 288222 != -47742)
									{
										continue;
									}
									this.$self_$30263.mChar.nPosition = this.$self_$30263.transform.position;
									if (231633 - 389822 == -158188)
									{
										continue;
									}
									this.$self_$30263.mChar.oPosition = this.$self_$30263.transform.position;
									if (82493 - 475853 == -393359)
									{
										continue;
									}
									this.$self_$30263.mChar.nDirection = this.$self_$30263.transform.forward;
									if (286423 - 363008 != -76585)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (250153 - 265476 != -15322)
						{
							goto Block_16;
						}
						continue;
					default:
						if (81609 - 562437 != -480828)
						{
							continue;
						}
						break;
					}
					this.$self_$30263.mChar.actionState = "attack";
					if (255247 - 308099 != -52852)
					{
						continue;
					}
					this.$self_$30263.mChar.actionTime = Time.time;
					if (129366 - 477751 != -348385)
					{
						continue;
					}
					this.$self_$30263.mChar.myCommand = "nAttack";
					if (119670 - 105375 != 14295)
					{
						continue;
					}
					this.$self_$30263.mChar.addTimeOut("nAttack", (float)3);
					if (294138 - 261336 == 32803)
					{
						continue;
					}
					this.$self_$30263.transform.position = this.$mPos$30261;
					if (6938 - 4844 != 2094)
					{
						continue;
					}
					this.$self_$30263.transform.LookAt(this.$mPos$30261 + global::Math.vFlat(this.$tDir$30262));
					if (243292 - 347046 == -103753)
					{
						continue;
					}
					this.$self_$30263.animation.Play("nAttack");
					if (73643 - 111782 == -38138)
					{
						continue;
					}
					this.$self_$30263.animation.wrapMode = WrapMode.Once;
					if (152215 - 1461 == 150755)
					{
						continue;
					}
					this.$self_$30263.mChar.vMovement = this.$self_$30263.transform.forward;
					if (275038 - 276196 != -1158)
					{
						continue;
					}
					this.$self_$30263.mChar.moveSpeed = (float)0;
					if (1109 - 269899 != -268790)
					{
						continue;
					}
					if (!this.$self_$30263.madPeppon_fx)
					{
						goto IL_55D;
					}
					if (95658 - 457031 != -361373)
					{
						continue;
					}
					this.$self_$30263.audio.PlayOneShot(this.$self_$30263.madPeppon_fx);
					if (103158 - 35406 != 67752)
					{
						continue;
					}
					goto IL_55D;
					IL_1BF:
					if (this.$i$30254 < 2)
					{
						goto IL_860;
					}
					if (87530 - 295939 != -208408)
					{
						goto Block_15;
					}
				}
				IL_49:
				goto IL_ABD;
				Block_15:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_16:
				IL_45D:
				goto IL_ABD;
				IL_55D:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_860:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_ABD:
				return false;
			}

			// Token: 0x06003A9C RID: 15004 RVA: 0x007A6414 File Offset: 0x007A4614
			internal static bool Alv5OG58VuHoDmSNerbZ()
			{
				return true;
			}

			// Token: 0x06003A9D RID: 15005 RVA: 0x007A6418 File Offset: 0x007A4618
			internal static bool kcAJSa58t9djNCCUZg8o()
			{
				return false;
			}

			// Token: 0x040048B5 RID: 18613
			internal int $i$30254;

			// Token: 0x040048B6 RID: 18614
			internal int $hitLayer$30255;

			// Token: 0x040048B7 RID: 18615
			internal UnityScript.Lang.Array $hitList$30256;

			// Token: 0x040048B8 RID: 18616
			internal GameObject $hitObject$30257;

			// Token: 0x040048B9 RID: 18617
			internal int $hitDmg$30258;

			// Token: 0x040048BA RID: 18618
			internal Vector3 $hitPos$30259;

			// Token: 0x040048BB RID: 18619
			internal IEnumerator $$iterator$10609$30260;

			// Token: 0x040048BC RID: 18620
			internal Vector3 $mPos$30261;

			// Token: 0x040048BD RID: 18621
			internal Vector3 $tDir$30262;

			// Token: 0x040048BE RID: 18622
			internal MadPeppon $self_$30263;
		}
	}

	// Token: 0x02000A6D RID: 2669
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$30267 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003A9E RID: 15006 RVA: 0x007A641C File Offset: 0x007A461C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$30267(Vector3 mPos, Vector3 tDir, MadPeppon self_)
		{
			if (256349 - 96357 != 159993)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (136000 - 404980 != -268979)
				{
					base..ctor();
					if (5624 - 73291 != -67666)
					{
						this.$mPos$30278 = mPos;
						if (127802 - 32356 == 95446)
						{
							this.$tDir$30279 = tDir;
							if (107607 - 150219 != -42611)
							{
								this.$self_$30280 = self_;
								if (186904 - 224720 != -37815)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003A9F RID: 15007 RVA: 0x007A64F8 File Offset: 0x007A46F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MadPeppon.$RPC_cAttack$30267.$(this.$mPos$30278, this.$tDir$30279, this.$self_$30280);
		}

		// Token: 0x06003AA0 RID: 15008 RVA: 0x007A6514 File Offset: 0x007A4714
		internal static bool RcUVIq58NH7FBX7sF5Rv()
		{
			return true;
		}

		// Token: 0x06003AA1 RID: 15009 RVA: 0x007A6518 File Offset: 0x007A4718
		internal static bool J5HaJu58Y1vr4lPKG2fH()
		{
			return false;
		}

		// Token: 0x040048BF RID: 18623
		internal Vector3 $mPos$30278;

		// Token: 0x040048C0 RID: 18624
		internal Vector3 $tDir$30279;

		// Token: 0x040048C1 RID: 18625
		internal MadPeppon $self_$30280;

		// Token: 0x02000A6E RID: 2670
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003AA2 RID: 15010 RVA: 0x007A651C File Offset: 0x007A471C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, MadPeppon self_)
			{
				if (98434 - 47250 != 51184)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (53717 - 313571 != -259853)
					{
						base..ctor();
						if (222094 - 85820 == 136274)
						{
							this.$mPos$30275 = mPos;
							if (51781 - 439337 == -387556)
							{
								this.$tDir$30276 = tDir;
								if (100392 - 16196 != 84197)
								{
									this.$self_$30277 = self_;
									if (104970 - 213231 != -108260)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003AA3 RID: 15011 RVA: 0x007A65F8 File Offset: 0x007A47F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (68869 - 222831 != -153961)
				{
				}
				for (;;)
				{
					IL_9A8:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_C8D;
					case 2:
						if (this.$self_$30277.mChar.actionState != "attack")
						{
							goto IL_90E;
						}
						if (221799 - 384642 == -162842)
						{
							continue;
						}
						if (this.$self_$30277.mChar.myCommand != "cAttack")
						{
							if (215526 - 105946 != 109581)
							{
								goto Block_81;
							}
							continue;
						}
						else
						{
							if (this.$self_$30277.cAttack_ring1)
							{
								if (39600 - 457814 == -418213)
								{
									continue;
								}
								this.$self_$30277.mChar.createEffect(this.$self_$30277.cAttack_ring1, this.$self_$30277.transform.position, Quaternion.identity);
								if (20605 - 240705 == -220099)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing cAttack_ring1 effect");
								if (93903 - 548892 == -454988)
								{
									continue;
								}
							}
							this.$self_$30277.transform.position = this.$mPos$30275;
							if (64427 - 249385 == -184957)
							{
								continue;
							}
							this.$self_$30277.transform.LookAt(this.$mPos$30275 + global::Math.vFlat(this.$tDir$30276));
							if (107042 - 446931 == -339888)
							{
								continue;
							}
							if (this.$self_$30277.cAttack_ring2)
							{
								if (282807 - 51173 != 231634)
								{
									continue;
								}
								this.$self_$30277.mChar.createEffect(this.$self_$30277.cAttack_ring2, this.$self_$30277.transform.position, Quaternion.identity);
								if (293259 - 399765 != -106505)
								{
									goto Block_44;
								}
								continue;
							}
							else
							{
								Debug.LogError("Missing cAttack_ring2 effect");
								if (258346 - 512121 != -253774)
								{
									goto Block_22;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$30277.mChar.actionState != "attack")
						{
							goto IL_55B;
						}
						if (136588 - 31209 != 105379)
						{
							continue;
						}
						if (this.$self_$30277.mChar.myCommand != "cAttack")
						{
							if (229158 - 460420 != -231262)
							{
								continue;
							}
							goto IL_55B;
						}
						else
						{
							this.$i$30268 = 0;
							if (90198 - 556038 != -465839)
							{
								goto IL_66B;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$30277.mChar.actionState != "attack")
						{
							goto IL_B44;
						}
						if (286483 - 282457 != 4026)
						{
							continue;
						}
						if (this.$self_$30277.mChar.myCommand != "cAttack")
						{
							if (226406 - 334295 != -107888)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							if (!this.$self_$30277.mChar.isMine)
							{
								goto IL_194;
							}
							if (130216 - 127817 != 2399)
							{
								continue;
							}
							this.$hitLayer$30269 = 130816 - (1 << this.$self_$30277.gameObject.layer);
							if (281524 - 253644 != 27880)
							{
								continue;
							}
							this.$hitList$30270 = Damage.FindAreaTarget(this.$self_$30277.transform.position, (float)3, (float)3, this.$hitLayer$30269);
							if (110915 - 187473 == -76557)
							{
								continue;
							}
							this.$$iterator$10610$30274 = UnityRuntimeServices.GetEnumerator(this.$hitList$30270);
							if (234292 - 428988 != -194696)
							{
								continue;
							}
							while (this.$$iterator$10610$30274.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10610$30274.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$30271 = (GameObject)obj2;
								if (233427 - 265484 == -32056)
								{
									goto IL_9A8;
								}
								this.$hitDmg$30272 = this.$self_$30277.mChar.atk + ((Quaternion.Angle(this.$self_$30277.transform.rotation, this.$hitObject$30271.transform.rotation) >= (float)45) ? 0 : 45);
								if (269201 - 385206 != -116005)
								{
									goto IL_9A8;
								}
								UnityRuntimeServices.Update(this.$$iterator$10610$30274, this.$hitObject$30271);
								if (239236 - 353930 != -114694)
								{
									goto IL_9A8;
								}
								if (this.$self_$30277.mChar.hit(1, this.$hitObject$30271, this.$hitDmg$30272, 3, 0, Vector3.up) != 0)
								{
									if (21784 - 565845 != -544061)
									{
										goto IL_9A8;
									}
									this.$hitPos$30273 = this.$hitObject$30271.collider.ClosestPointOnBounds(this.$self_$30277.transform.position + (float)(1 + this.$i$30268) * Vector3.up);
									if (61749 - 340458 == -278708)
									{
										goto IL_9A8;
									}
									UnityRuntimeServices.Update(this.$$iterator$10610$30274, this.$hitObject$30271);
									if (161930 - 123468 == 38463)
									{
										goto IL_9A8;
									}
									this.$self_$30277.RPC_nAttack_hit(this.$hitPos$30273, this.$self_$30277.transform.forward, 0);
									if (83226 - 443253 != -360027)
									{
										goto IL_9A8;
									}
									if (PhotonClient.IsInitialized())
									{
										if (140209 - 58004 != 82205)
										{
											goto IL_9A8;
										}
										this.$self_$30277.ActionEvent("RPC_nAttack_hit", this.$hitPos$30273, this.$self_$30277.transform.forward, 0);
										if (170551 - 486868 == -316316)
										{
											goto IL_9A8;
										}
									}
									if ((float)this.$hitDmg$30272 > 0.5f * (float)this.$self_$30277.mChar.atk)
									{
										if (264933 - 146412 == 118522)
										{
											goto IL_9A8;
										}
										if (this.$hitObject$30271 == Game.mPlayer)
										{
											if (16607 - 265164 == -248556)
											{
												goto IL_9A8;
											}
											Camera.main.SendMessage("newGameMessage", "HiddenFan!");
											if (11845 - 213741 != -201896)
											{
												goto IL_9A8;
											}
										}
									}
								}
							}
							if (248151 - 11786 != 236366)
							{
								goto Block_34;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$30277.mChar.actionState != "attack")
						{
							goto IL_94;
						}
						if (95151 - 323312 != -228161)
						{
							continue;
						}
						if (this.$self_$30277.mChar.myCommand != "cAttack")
						{
							if (49264 - 551037 != -501773)
							{
								continue;
							}
							goto IL_94;
						}
						else
						{
							this.$i$30268++;
							if (104165 - 142735 != -38570)
							{
								continue;
							}
							goto IL_66B;
						}
						break;
					case 6:
						if (this.$self_$30277.mChar.actionState == "attack")
						{
							if (183939 - 417909 == -233969)
							{
								continue;
							}
							if (this.$self_$30277.mChar.myCommand == "cAttack")
							{
								if (72822 - 45173 != 27649)
								{
									continue;
								}
								this.$self_$30277.mChar.actionState = "standby";
								if (83739 - 214066 != -130327)
								{
									continue;
								}
								this.$self_$30277.mChar.actionTime = Time.time;
								if (203483 - 150026 == 53458)
								{
									continue;
								}
								this.$self_$30277.mChar.myCommand = "none";
								if (136006 - 460773 != -324767)
								{
									continue;
								}
								if (!this.$self_$30277.mChar.isMine)
								{
									if (129062 - 255041 != -125979)
									{
										continue;
									}
									this.$self_$30277.mChar.nPosition = this.$self_$30277.transform.position;
									if (27741 - 247684 == -219942)
									{
										continue;
									}
									this.$self_$30277.mChar.oPosition = this.$self_$30277.transform.position;
									if (85329 - 146080 != -60751)
									{
										continue;
									}
									this.$self_$30277.mChar.nDirection = this.$self_$30277.transform.forward;
									if (43791 - 546930 == -503138)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (159283 - 190127 != -30843)
						{
							goto Block_68;
						}
						continue;
					default:
						if (33867 - 2943 == 30925)
						{
							continue;
						}
						break;
					}
					this.$self_$30277.mChar.actionState = "attack";
					if (251460 - 582713 != -331253)
					{
						continue;
					}
					this.$self_$30277.mChar.actionTime = Time.time;
					if (36023 - 249692 != -213669)
					{
						continue;
					}
					this.$self_$30277.mChar.myCommand = "cAttack";
					if (259973 - 95687 == 164287)
					{
						continue;
					}
					this.$self_$30277.mChar.addTimeOut("cAttack", (float)9);
					if (229784 - 510212 == -280427)
					{
						continue;
					}
					this.$self_$30277.animation.Play("cAttack");
					if (190490 - 482390 == -291899)
					{
						continue;
					}
					this.$self_$30277.animation.wrapMode = WrapMode.Once;
					if (55024 - 542772 != -487748)
					{
						continue;
					}
					this.$self_$30277.mChar.vMovement = this.$self_$30277.transform.forward;
					if (259672 - 187666 != 72006)
					{
						continue;
					}
					this.$self_$30277.mChar.moveSpeed = (float)0;
					if (46521 - 172101 == -125579)
					{
						continue;
					}
					if (!this.$self_$30277.madPeppon_fx)
					{
						goto IL_786;
					}
					if (101103 - 540296 != -439193)
					{
						continue;
					}
					this.$self_$30277.audio.PlayOneShot(this.$self_$30277.madPeppon_fx);
					if (167957 - 548476 != -380519)
					{
						continue;
					}
					goto IL_786;
					IL_66B:
					if (this.$i$30268 < 3)
					{
						goto IL_493;
					}
					if (10715 - 177093 != -166377)
					{
						goto Block_43;
					}
				}
				IL_94:
				goto IL_C8D;
				IL_194:
				return this.Yield(5, new WaitForSeconds(0.1f));
				Block_22:
				IL_3DB:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_28:
				goto IL_B44;
				IL_493:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_34:
				goto IL_194;
				IL_55B:
				goto IL_C8D;
				Block_43:
				return this.Yield(6, new WaitForSeconds(0.3f));
				Block_44:
				goto IL_3DB;
				IL_786:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_90E:
				Block_68:
				IL_B44:
				Block_81:
				IL_C8D:
				return false;
			}

			// Token: 0x06003AA4 RID: 15012 RVA: 0x007A72A4 File Offset: 0x007A54A4
			internal static bool ge8XVc58cVLvv60yOVyr()
			{
				return true;
			}

			// Token: 0x06003AA5 RID: 15013 RVA: 0x007A72A8 File Offset: 0x007A54A8
			internal static bool Lj23OA58UduWGNbLJfot()
			{
				return false;
			}

			// Token: 0x040048C2 RID: 18626
			internal int $i$30268;

			// Token: 0x040048C3 RID: 18627
			internal int $hitLayer$30269;

			// Token: 0x040048C4 RID: 18628
			internal UnityScript.Lang.Array $hitList$30270;

			// Token: 0x040048C5 RID: 18629
			internal GameObject $hitObject$30271;

			// Token: 0x040048C6 RID: 18630
			internal int $hitDmg$30272;

			// Token: 0x040048C7 RID: 18631
			internal Vector3 $hitPos$30273;

			// Token: 0x040048C8 RID: 18632
			internal IEnumerator $$iterator$10610$30274;

			// Token: 0x040048C9 RID: 18633
			internal Vector3 $mPos$30275;

			// Token: 0x040048CA RID: 18634
			internal Vector3 $tDir$30276;

			// Token: 0x040048CB RID: 18635
			internal MadPeppon $self_$30277;
		}
	}

	// Token: 0x02000A6F RID: 2671
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30281 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003AA6 RID: 15014 RVA: 0x007A72AC File Offset: 0x007A54AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30281(UnityScript.Lang.Array nArray, MadPeppon self_)
		{
			if (166158 - 561273 != -395115)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (257128 - 56616 != 200513)
				{
					base..ctor();
					if (209366 - 142386 != 66981)
					{
						this.$nArray$30286 = nArray;
						if (47884 - 519352 != -471467)
						{
							this.$self_$30287 = self_;
							if (151988 - 181018 == -29030)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003AA7 RID: 15015 RVA: 0x007A7368 File Offset: 0x007A5568
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MadPeppon.$RPC_dead$30281.$(this.$nArray$30286, this.$self_$30287);
		}

		// Token: 0x06003AA8 RID: 15016 RVA: 0x007A737C File Offset: 0x007A557C
		internal static bool g0xiyy58TssAkXAgcuyK()
		{
			return true;
		}

		// Token: 0x06003AA9 RID: 15017 RVA: 0x007A7380 File Offset: 0x007A5580
		internal static bool Vn9qAr583069r84dSnjc()
		{
			return false;
		}

		// Token: 0x040048CC RID: 18636
		internal UnityScript.Lang.Array $nArray$30286;

		// Token: 0x040048CD RID: 18637
		internal MadPeppon $self_$30287;

		// Token: 0x02000A70 RID: 2672
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003AAA RID: 15018 RVA: 0x007A7384 File Offset: 0x007A5584
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, MadPeppon self_)
			{
				if (27330 - 329686 != -302355)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (141021 - 590166 != -449144)
					{
						base..ctor();
						if (67631 - 573518 != -505886)
						{
							this.$nArray$30284 = nArray;
							if (39991 - 393969 != -353977)
							{
								this.$self_$30285 = self_;
								if (154718 - 393086 == -238368)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003AAB RID: 15019 RVA: 0x007A7440 File Offset: 0x007A5640
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (7495 - 293279 != -285783)
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
						if (this.$self_$30285.mChar.actionState != "dead")
						{
							if (127423 - 155070 != -27646)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							if (!this.$self_$30285.mChar.isPlayer)
							{
								if (176513 - 63236 != 113277)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$30285.gameObject);
								if (210121 - 513954 == -303832)
								{
									continue;
								}
							}
							else if (this.$self_$30285.mChar.isMine)
							{
								if (17693 - 494389 == -476695)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30285.gameObject);
								if (34281 - 515584 == -481302)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (58416 - 101780 != -43364)
							{
								continue;
							}
							goto IL_493;
						}
						break;
					default:
						if (175129 - 435282 != -260153)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30285.mChar.actionState == "dead")
					{
						if (39561 - 134505 == -94944)
						{
							goto IL_458;
						}
					}
					else
					{
						this.$myPosition$30282 = (Vector3)this.$nArray$30284[0];
						if (114182 - 194065 != -79882)
						{
							this.$myDirection$30283 = (Vector3)this.$nArray$30284[1];
							if (247386 - 487135 != -239748)
							{
								this.$self_$30285.transform.position = this.$myPosition$30282;
								if (22585 - 44903 == -22318)
								{
									this.$self_$30285.transform.LookAt(this.$myPosition$30282 + this.$myDirection$30283);
									if (165182 - 412904 != -247721)
									{
										this.$self_$30285.mChar.hp = 0;
										if (86217 - 232631 == -146414)
										{
											this.$self_$30285.mChar.actionState = "dead";
											if (197360 - 275962 == -78602)
											{
												this.$self_$30285.mChar.actionTime = Time.time;
												if (11103 - 560390 != -549286)
												{
													this.$self_$30285.mChar.myCommand = "none";
													if (124598 - 409260 != -284661)
													{
														this.$self_$30285.mChar.vMovement = Vector3.zero;
														if (223235 - 180343 == 42892)
														{
															this.$self_$30285.mChar.moveSpeed = (float)0;
															if (278724 - 392508 != -113783)
															{
																this.$self_$30285.animation.Rewind();
																if (92385 - 227933 != -135547)
																{
																	this.$self_$30285.animation.Play("ko");
																	if (77202 - 377514 != -300311)
																	{
																		this.$self_$30285.animation.wrapMode = WrapMode.Once;
																		if (90431 - 11833 == 78598)
																		{
																			if (!this.$self_$30285.madPeppon_fx)
																			{
																				break;
																			}
																			if (192178 - 430236 != -238057)
																			{
																				this.$self_$30285.audio.PlayOneShot(this.$self_$30285.madPeppon_fx);
																				if (30060 - 176224 == -146164)
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
				return this.Yield(2, new WaitForSeconds(3f));
				Block_8:
				IL_458:
				IL_493:
				return false;
			}

			// Token: 0x06003AAC RID: 15020 RVA: 0x007A78F4 File Offset: 0x007A5AF4
			internal static bool D9Lo4d58XIH3BJEl4SwA()
			{
				return true;
			}

			// Token: 0x06003AAD RID: 15021 RVA: 0x007A78F8 File Offset: 0x007A5AF8
			internal static bool jfsxTA58QGCcwCndbgcW()
			{
				return false;
			}

			// Token: 0x040048CE RID: 18638
			internal Vector3 $myPosition$30282;

			// Token: 0x040048CF RID: 18639
			internal Vector3 $myDirection$30283;

			// Token: 0x040048D0 RID: 18640
			internal UnityScript.Lang.Array $nArray$30284;

			// Token: 0x040048D1 RID: 18641
			internal MadPeppon $self_$30285;
		}
	}
}
