using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B79 RID: 2937
[Serializable]
public class BatCult : MonoBehaviour
{
	// Token: 0x0600416D RID: 16749 RVA: 0x0084783C File Offset: 0x00845A3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BatCult()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600416E RID: 16750 RVA: 0x0084784C File Offset: 0x00845A4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (187616 - 564399 != -376782)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (157558 - 548764 == -391206)
			{
				this.mChar.actionState = "standby";
				if (297293 - 529843 != -232549)
				{
					this.mChar.actionTime = Time.time;
					if (202073 - 504038 != -301964)
					{
						this.mChar.myCommand = "none";
						if (257153 - 27262 == 229891)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600416F RID: 16751 RVA: 0x00847938 File Offset: 0x00845B38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (148531 - 499920 != -351389)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (16167 - 320085 == -303917)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (260212 - 329172 == -68959)
				{
					continue;
				}
			}
			if (Game.mGameCode != 934)
			{
				break;
			}
			if (35997 - 382747 == -346750)
			{
				if (this.mChar.ActorNr == 0)
				{
					break;
				}
				if (284620 - 194583 == 90037)
				{
					this.mChar.StartCoroutine_Auto(this.mChar.addStatus("darkRitual", 1, 999, 0, this.mChar.ActorNr));
					if (266232 - 42854 == 223378)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004170 RID: 16752 RVA: 0x00847A58 File Offset: 0x00845C58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (255665 - 434584 != -178919)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (68136 - 433637 != -365501)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (47703 - 127700 == -79996)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_255;
					}
					if (42716 - 398910 != -356194)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (100759 - 553051 == -452291)
				{
					continue;
				}
			}
			IL_255:
			if (this.mChar.hp <= 0)
			{
				if (278332 - 228516 != 49816)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (88981 - 420779 == -331797)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (51834 - 52181 != -347)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (245482 - 93221 != 152261)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (133381 - 267546 == -134164)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (29988 - 537858 != -507869)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (241278 - 257793 != -16515)
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
			if (182224 - 278723 != -96498)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (218503 - 516692 == -298189)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (131750 - 253493 == -121743)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (185364 - 309749 != -124384)
						{
							if (this.mChar.isMine)
							{
								if (117728 - 354844 == -237116)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (276240 - 146738 != 129503)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (54783 - 19981 == 34802)
										{
											this.mChar.KoEvent();
											if (93128 - 366541 == -273413)
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
								if (54993 - 378412 == -323419)
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

	// Token: 0x06004171 RID: 16753 RVA: 0x00847E50 File Offset: 0x00846050
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (159074 - 300567 != -141492)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (280122 - 362825 != -82702)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (50800 - 320990 == -270190)
				{
					if (37869 - 451419 != -413549)
					{
						if (ActionName == "RPC_randomCast")
						{
							if (269535 - 151178 != 118357)
							{
								continue;
							}
							v = 1;
							if (193793 - 161491 == 32303)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack")
						{
							if (175224 - 467490 == -292265)
							{
								continue;
							}
							v = 11;
							if (133139 - 506209 != -373070)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack0")
						{
							if (107461 - 480429 != -372968)
							{
								continue;
							}
							v = -11;
							if (74398 - 598179 != -523781)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (218956 - 229127 != -10171)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (177881 - 340750 != -162868)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (12939 - 475853 == -462914)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (66081 - 241829 != -175747)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (122226 - 179111 == -56885)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (204076 - 381438 != -177361)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (176268 - 38256 == 138012)
											{
												Hashtable hashtable = new Hashtable();
												if (241453 - 32572 != 208882)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (274880 - 273989 == 891)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (283735 - 368797 != -85061)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (190822 - 396085 == -205263)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (69271 - 129639 == -60368)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (219031 - 235048 != -16016)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (59830 - 470233 == -410403)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (33010 - 224899 == -191889)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (291440 - 448349 == -156909)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (187444 - 577982 != -390537)
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

	// Token: 0x06004172 RID: 16754 RVA: 0x0084831C File Offset: 0x0084651C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (156685 - 540207 != -383522)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (71274 - 64533 != 6742)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (285699 - 223450 != 62250)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (102855 - 588130 != -485274)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (175008 - 548781 != -373772)
						{
							int num2 = num;
							if (20223 - 141678 != -121454)
							{
								if (num2 == 1)
								{
									if (280661 - 565678 == -285017)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (195636 - 419899 != -224262)
										{
											this.StartCoroutine_Auto(this.RPC_randomCast(mPos, tDir, tID));
											if (652 - 98438 == -97786)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 11)
								{
									if (132003 - 9144 == 122859)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (60846 - 240552 != -179705)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(mPos, tDir, tID));
											if (148805 - 105553 != 43253)
											{
												break;
											}
										}
									}
								}
								else if (num2 == -11)
								{
									if (102102 - 567164 != -465061)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (205568 - 593408 == -387840)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack0(mPos, tDir, tID));
											if (4036 - 574009 == -569973)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (232302 - 168840 == 63462)
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

	// Token: 0x06004173 RID: 16755 RVA: 0x00848634 File Offset: 0x00846834
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (144238 - 310283 != -166044)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (133233 - 375366 != -242132)
			{
				float runSpeed = this.mChar.runSpeed;
				if (41282 - 514906 != -473623)
				{
					Vector3 a = default(Vector3);
					if (243166 - 146616 != 96551)
					{
						Vector3 vector = Vector3.zero;
						if (291764 - 120992 != 170773)
						{
							float num2 = (float)0;
							if (169540 - 411904 != -242363)
							{
								if (this.mChar.isMine)
								{
									if (11613 - 591369 == -579755)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (150709 - 483608 != -332899)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (261705 - 321348 != -59643)
										{
											continue;
										}
										a.y = (float)0;
										if (272121 - 386126 != -114005)
										{
											continue;
										}
										a = a.normalized;
										if (147277 - 136846 != 10431)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (260616 - 475075 == -214458)
										{
											continue;
										}
										vector = vector.normalized;
										if (3812 - 583354 != -579542)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (159749 - 331201 != -171452)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (100153 - 195001 == -94847)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (43252 - 464408 == -421155)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (204270 - 485606 == -281335)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (247287 - 256 == 247032)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (9618 - 594367 == -584748)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (4230 - 375080 == -370849)
														{
															continue;
														}
														this.animation.Play("run");
														if (135252 - 341236 != -205984)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (70299 - 64828 != 5472)
														{
															goto IL_53C;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (104890 - 323730 == -218839)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (160717 - 517463 != -356746)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (22810 - 417889 == -395078)
											{
												continue;
											}
											num = (float)0;
											if (275256 - 153434 == 121823)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (117026 - 367875 != -250849)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (139774 - 568285 == -428510)
										{
											continue;
										}
									}
									IL_53C:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (124003 - 107989 != 16014)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (122497 - 314776 == -192278)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (273034 - 447817 == -174782)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (164220 - 328142 == -163921)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (92858 - 504823 != -411965)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (127034 - 474079 == -347044)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (80918 - 38978 == 41941)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (221176 - 374603 != -153427)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (44345 - 295735 != -251390)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (11479 - 354119 == -342639)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (145237 - 111511 != 33726)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (192559 - 382507 == -189947)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (145173 - 198011 == -52837)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (82273 - 114349 == -32075)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (40767 - 457608 != -416841)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (118779 - 23434 != 95345)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (100841 - 555155 == -454313)
												{
													continue;
												}
												num = (float)0;
												if (18416 - 113741 == -95324)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (98692 - 532131 == -433438)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (261262 - 121961 != 139301)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (7687 - 197219 != -189532)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (182516 - 543261 == -360744)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (4584 - 226962 != -222378)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (292765 - 430859 != -138094)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (104778 - 144453 == -39674)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (190856 - 419738 == -228881)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (189929 - 544226 != -354297)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (203044 - 363614 != -160570)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (231927 - 273940 != -42013)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (46358 - 395771 != -349413)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (140972 - 93674 != 47298)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (262441 - 467633 == -205191)
											{
												continue;
											}
											num = (float)0;
											if (256692 - 366063 == -109370)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (195486 - 89889 == 105598)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (138849 - 199673 != -60824)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (71641 - 400409 != -328768)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (33968 - 119712 == -85743)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (278064 - 46445 != 231620)
								{
									this.mChar.moveSpeed = num;
									if (191859 - 37037 == 154822)
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

	// Token: 0x06004174 RID: 16756 RVA: 0x00849198 File Offset: 0x00847398
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (269051 - 382061 != -113010)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (199114 - 573212 != -374097)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (92570 - 408874 != -316303)
				{
					Vector3 vector = a - this.transform.position;
					if (288035 - 172514 == 115521)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (215652 - 70873 != 144780)
						{
							CharacterControl characterControl = null;
							if (154725 - 28706 == 126019)
							{
								if (115107 - 386589 == -271482)
								{
									if (gameObject)
									{
										if (173882 - 138787 == 35096)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (216885 - 84565 == 132321)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (48647 - 25555 != 23092)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (54487 - 69860 != -15373)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (20226 - 467961 == -447734)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (63093 - 113672 != -50579)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (152642 - 35565 == 117077)
									{
										Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
										if (230201 - 182902 != 47300)
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

	// Token: 0x06004175 RID: 16757 RVA: 0x0084943C File Offset: 0x0084763C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (93888 - 202625 != -108736)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (220525 - 70626 == 149899)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (55914 - 539525 == -483611)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (88982 - 489226 == -400244)
					{
						Vector3 normalized = vector.normalized;
						if (81581 - 288946 == -207365)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (166094 - 91839 != 74256)
							{
								CharacterControl characterControl = null;
								if (279833 - 304924 != -25090 && 158224 - 143244 == 14980)
								{
									if (gameObject)
									{
										if (223062 - 66343 == 156720)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (133015 - 26430 != 106585)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (221683 - 454246 == -232562)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (204455 - 171617 != 32838)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (298088 - 562235 != -264147)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (266145 - 543829 == -277683)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("cAttack") != (float)0)
									{
										break;
									}
									if (5100 - 9915 != -4814)
									{
										Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
										if (145930 - 402215 == -256285)
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

	// Token: 0x06004176 RID: 16758 RVA: 0x00849708 File Offset: 0x00847908
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004177 RID: 16759 RVA: 0x0084970C File Offset: 0x0084790C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_randomCast(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new BatCult.$RPC_randomCast$31221(mPos, tID, this).GetEnumerator();
	}

	// Token: 0x06004178 RID: 16760 RVA: 0x0084971C File Offset: 0x0084791C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new BatCult.$RPC_cAttack$31232(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06004179 RID: 16761 RVA: 0x0084972C File Offset: 0x0084792C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack0(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new BatCult.$RPC_cAttack0$31250(mPos, this).GetEnumerator();
	}

	// Token: 0x0600417A RID: 16762 RVA: 0x0084973C File Offset: 0x0084793C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new BatCult.$RPC_ko$31255(nArray, this).GetEnumerator();
	}

	// Token: 0x0600417B RID: 16763 RVA: 0x0084974C File Offset: 0x0084794C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new BatCult.$RPC_dead$31262(nArray, this).GetEnumerator();
	}

	// Token: 0x0600417C RID: 16764 RVA: 0x0084975C File Offset: 0x0084795C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600417D RID: 16765 RVA: 0x00849760 File Offset: 0x00847960
	internal static bool SYU0F15xqbq9Tu0R3WpH()
	{
		return true;
	}

	// Token: 0x0600417E RID: 16766 RVA: 0x00849764 File Offset: 0x00847964
	internal static bool ok4FLj5x7eQFJYBWAh5X()
	{
		return false;
	}

	// Token: 0x04004D8B RID: 19851
	public CharacterControl mChar;

	// Token: 0x04004D8C RID: 19852
	public GameObject castRing;

	// Token: 0x04004D8D RID: 19853
	public GameObject castEffect;

	// Token: 0x04004D8E RID: 19854
	public GameObject drainLife;

	// Token: 0x04004D8F RID: 19855
	public GameObject drainLife_charge;

	// Token: 0x02000B7A RID: 2938
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_randomCast$31221 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600417F RID: 16767 RVA: 0x00849768 File Offset: 0x00847968
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_randomCast$31221(Vector3 mPos, int tID, BatCult self_)
		{
			if (188279 - 278617 != -90338)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (230628 - 129739 == 100889)
				{
					base..ctor();
					if (115158 - 476859 != -361700)
					{
						this.$mPos$31229 = mPos;
						if (244401 - 347208 != -102806)
						{
							this.$tID$31230 = tID;
							if (27886 - 424145 == -396259)
							{
								this.$self_$31231 = self_;
								if (185382 - 545036 != -359653)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004180 RID: 16768 RVA: 0x00849844 File Offset: 0x00847A44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BatCult.$RPC_randomCast$31221.$(this.$mPos$31229, this.$tID$31230, this.$self_$31231);
		}

		// Token: 0x06004181 RID: 16769 RVA: 0x00849860 File Offset: 0x00847A60
		internal static bool DwUk8j5xPTW92uiIq8qi()
		{
			return true;
		}

		// Token: 0x06004182 RID: 16770 RVA: 0x00849864 File Offset: 0x00847A64
		internal static bool oPeTar5x0yyu2mMmraVY()
		{
			return false;
		}

		// Token: 0x04004D90 RID: 19856
		internal Vector3 $mPos$31229;

		// Token: 0x04004D91 RID: 19857
		internal int $tID$31230;

		// Token: 0x04004D92 RID: 19858
		internal BatCult $self_$31231;

		// Token: 0x02000B7B RID: 2939
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004183 RID: 16771 RVA: 0x00849868 File Offset: 0x00847A68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, int tID, BatCult self_)
			{
				if (9258 - 34688 != -25430)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (123927 - 211414 != -87486)
					{
						base..ctor();
						if (257475 - 415756 != -158280)
						{
							this.$mPos$31226 = mPos;
							if (27813 - 297723 != -269909)
							{
								this.$tID$31227 = tID;
								if (265246 - 101860 == 163386)
								{
									this.$self_$31228 = self_;
									if (111978 - 5326 != 106653)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004184 RID: 16772 RVA: 0x00849944 File Offset: 0x00847B44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (13690 - 81029 != -67339)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_73B;
					case 1:
						goto IL_B01;
					case 2:
						if (this.$self_$31228.castRing)
						{
							if (28173 - 569346 == -541172)
							{
								continue;
							}
							this.$self_$31228.mChar.createEffect(this.$self_$31228.castRing, this.$self_$31228.transform.position, Quaternion.Euler((float)270, (float)90, (float)0));
							if (155387 - 470719 == -315331)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$31228.mChar.actionState != "attack")
						{
							goto IL_234;
						}
						if (254346 - 420171 == -165824)
						{
							continue;
						}
						if (this.$self_$31228.mChar.myCommand != "randomCast")
						{
							if (231121 - 176327 != 54795)
							{
								goto Block_37;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$31228.mChar.actionState != "attack")
						{
							goto IL_653;
						}
						if (174570 - 321047 == -146476)
						{
							continue;
						}
						if (this.$self_$31228.mChar.myCommand != "randomCast")
						{
							if (108139 - 276074 != -167934)
							{
								goto Block_66;
							}
							continue;
						}
						else
						{
							this.$self_$31228.mChar.moveSpeed = (float)0;
							if (138036 - 42944 == 95093)
							{
								continue;
							}
							if (!this.$self_$31228.mChar.isMine)
							{
								goto IL_186;
							}
							if (188826 - 314550 == -125723)
							{
								continue;
							}
							this.$$switch$3508$31225 = UnityEngine.Random.Range(0, 3);
							if (25118 - 432988 == -407869)
							{
								continue;
							}
							if (this.$$switch$3508$31225 == 1)
							{
								if (210739 - 522027 != -311288)
								{
									continue;
								}
								this.$tChar$31223.RPC_AddStatus("blind", 2, Damage.getDebuff((float)15, this.$self_$31228.mChar.cha, this.$tChar$31223.cha), 0, this.$self_$31228.mChar.ActorNr);
								if (223618 - 399729 != -176111)
								{
									continue;
								}
								goto IL_1A;
							}
							else if (this.$$switch$3508$31225 == 2)
							{
								if (61951 - 64171 != -2220)
								{
									continue;
								}
								this.$tChar$31223.RPC_AddStatus("confuse", 2, Damage.getDebuff((float)15, this.$self_$31228.mChar.cha, this.$tChar$31223.cha), 0, this.$self_$31228.mChar.ActorNr);
								if (9187 - 524781 != -515594)
								{
									continue;
								}
								goto IL_433;
							}
							else
							{
								this.$tChar$31223.RPC_AddStatus("phantomBane", 4, Damage.getDebuff((float)15, this.$self_$31228.mChar.cha, this.$tChar$31223.cha), 0, this.$self_$31228.mChar.ActorNr);
								if (286973 - 175807 != 111166)
								{
									continue;
								}
								goto IL_181;
							}
						}
						break;
					case 5:
						if (this.$self_$31228.mChar.actionState != "attack")
						{
							goto IL_61F;
						}
						if (133246 - 356215 != -222969)
						{
							continue;
						}
						if (this.$self_$31228.mChar.myCommand != "randomCast")
						{
							if (262691 - 116815 != 145876)
							{
								continue;
							}
							goto IL_61F;
						}
						else
						{
							this.$self_$31228.mChar.actionState = "standby";
							if (271499 - 173160 == 98340)
							{
								continue;
							}
							this.$self_$31228.mChar.actionTime = Time.time;
							if (209313 - 136732 != 72581)
							{
								continue;
							}
							this.$self_$31228.mChar.myCommand = "none";
							if (144269 - 84167 == 60103)
							{
								continue;
							}
							this.$self_$31228.mChar.nPosition = this.$self_$31228.transform.position;
							if (283076 - 250716 != 32360)
							{
								continue;
							}
							this.YieldDefault(1);
							if (281159 - 242158 != 39002)
							{
								goto Block_24;
							}
							continue;
						}
						break;
					default:
						if (274624 - 348556 != -73931)
						{
							goto IL_73B;
						}
						continue;
					}
					if (Time.time >= this.$self_$31228.mChar.actionTime + 2f)
					{
						if (278144 - 526852 != -248708)
						{
							continue;
						}
						this.$self_$31228.mChar.vMovement = this.$self_$31228.transform.forward;
						if (294296 - 514210 == -219913)
						{
							continue;
						}
						this.$self_$31228.mChar.moveSpeed = -0.5f;
						if (15873 - 541153 == -525279)
						{
							continue;
						}
						if (!this.$self_$31228.castEffect)
						{
							goto IL_328;
						}
						if (268831 - 425425 == -156593)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$31228.castEffect, this.$self_$31228.transform.position + this.$self_$31228.transform.TransformDirection((float)0, 1.3f, (float)1), this.$self_$31228.transform.rotation);
						if (65645 - 534452 != -468806)
						{
							goto Block_50;
						}
						continue;
					}
					else
					{
						if (!this.$tObject$31222)
						{
							goto IL_96B;
						}
						if (244858 - 346471 == -101612)
						{
							continue;
						}
						if (!(this.$tObject$31222 != this.$self_$31228.gameObject))
						{
							goto IL_96B;
						}
						if (38781 - 233547 != -194766)
						{
							continue;
						}
						this.$tPos$31224 = global::Math.vFlat(this.$tObject$31222.transform.position) + Vector3.up * this.$self_$31228.transform.position.y;
						if (114758 - 596601 == -481842)
						{
							continue;
						}
						this.$self_$31228.transform.LookAt(this.$tPos$31224);
						if (221900 - 429265 != -207365)
						{
							continue;
						}
						goto IL_96B;
					}
					IL_73B:
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.$tID$31227];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.$tObject$31222 = (GameObject)obj2;
					if (201054 - 311914 != -110859)
					{
						if (!this.$tObject$31222)
						{
							goto IL_79;
						}
						if (156021 - 392491 == -236470)
						{
							if (this.$tObject$31222 == this.$self_$31228.gameObject)
							{
								if (49843 - 425221 == -375378)
								{
									goto IL_79;
								}
							}
							else
							{
								this.$tChar$31223 = (CharacterControl)this.$tObject$31222.GetComponent(typeof(CharacterControl));
								if (13627 - 233745 == -220118)
								{
									if (!this.$tChar$31223)
									{
										if (54968 - 81418 == -26450)
										{
											goto IL_F2;
										}
									}
									else
									{
										this.$tPos$31224 = this.$tObject$31222.transform.position;
										if (285330 - 530224 == -244894)
										{
											this.$tPos$31224.y = this.$mPos$31226.y;
											if (240154 - 534541 != -294386)
											{
												this.$self_$31228.transform.position = this.$mPos$31226;
												if (89186 - 572741 == -483555)
												{
													this.$self_$31228.transform.LookAt(this.$tPos$31224);
													if (253392 - 180117 == 73275)
													{
														this.$self_$31228.animation.CrossFade("cast", 0.2f);
														if (181719 - 339577 != -157857)
														{
															this.$self_$31228.animation.wrapMode = WrapMode.Once;
															if (265982 - 568135 != -302152)
															{
																this.$self_$31228.mChar.actionState = "attack";
																if (197035 - 336034 != -138998)
																{
																	this.$self_$31228.mChar.actionTime = Time.time;
																	if (11059 - 435350 != -424290)
																	{
																		this.$self_$31228.mChar.myCommand = "randomCast";
																		if (123212 - 526351 == -403139)
																		{
																			this.$self_$31228.mChar.vMovement = this.$self_$31228.transform.forward;
																			if (216172 - 563902 == -347730)
																			{
																				this.$self_$31228.mChar.moveSpeed = (float)0;
																				if (4084 - 16234 == -12150)
																				{
																					this.$self_$31228.mChar.addTimeOut("nAttack", (float)5);
																					if (158119 - 242274 != -84154)
																					{
																						goto Block_55;
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
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
				goto IL_186;
				IL_79:
				IL_F2:
				goto IL_B01;
				IL_181:
				IL_186:
				return this.Yield(5, new WaitForSeconds(0.4f));
				IL_234:
				goto IL_B01;
				IL_328:
				return this.Yield(4, new WaitForSeconds(0.4f));
				Block_24:
				goto IL_B01;
				IL_433:
				goto IL_186;
				Block_37:
				IL_61F:
				IL_653:
				goto IL_B01;
				Block_50:
				goto IL_328;
				Block_55:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_96B:
				return this.YieldDefault(3);
				Block_66:
				IL_B01:
				return false;
			}

			// Token: 0x06004185 RID: 16773 RVA: 0x0084A464 File Offset: 0x00848664
			internal static bool UpdMJn5xbS3qxNxxLcXA()
			{
				return true;
			}

			// Token: 0x06004186 RID: 16774 RVA: 0x0084A468 File Offset: 0x00848668
			internal static bool RU6xXV5xu0wTYRSy9E5E()
			{
				return false;
			}

			// Token: 0x04004D93 RID: 19859
			internal GameObject $tObject$31222;

			// Token: 0x04004D94 RID: 19860
			internal CharacterControl $tChar$31223;

			// Token: 0x04004D95 RID: 19861
			internal Vector3 $tPos$31224;

			// Token: 0x04004D96 RID: 19862
			internal int $$switch$3508$31225;

			// Token: 0x04004D97 RID: 19863
			internal Vector3 $mPos$31226;

			// Token: 0x04004D98 RID: 19864
			internal int $tID$31227;

			// Token: 0x04004D99 RID: 19865
			internal BatCult $self_$31228;
		}
	}

	// Token: 0x02000B7C RID: 2940
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$31232 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004187 RID: 16775 RVA: 0x0084A46C File Offset: 0x0084866C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$31232(Vector3 mPos, Vector3 tDir, int tID, BatCult self_)
		{
			if (63982 - 44261 != 19722)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (1976 - 597860 != -595883)
				{
					base..ctor();
					if (45105 - 213863 == -168758)
					{
						this.$mPos$31246 = mPos;
						if (187606 - 256644 != -69037)
						{
							this.$tDir$31247 = tDir;
							if (117361 - 292938 == -175577)
							{
								this.$tID$31248 = tID;
								if (39938 - 280548 != -240609)
								{
									this.$self_$31249 = self_;
									if (145000 - 594763 == -449763)
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

		// Token: 0x06004188 RID: 16776 RVA: 0x0084A56C File Offset: 0x0084876C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BatCult.$RPC_cAttack$31232.$(this.$mPos$31246, this.$tDir$31247, this.$tID$31248, this.$self_$31249);
		}

		// Token: 0x06004189 RID: 16777 RVA: 0x0084A58C File Offset: 0x0084878C
		internal static bool URBeS05xIU6uude7NXqx()
		{
			return true;
		}

		// Token: 0x0600418A RID: 16778 RVA: 0x0084A590 File Offset: 0x00848790
		internal static bool yTblV15xBqIs6J3sPL0V()
		{
			return false;
		}

		// Token: 0x04004D9A RID: 19866
		internal Vector3 $mPos$31246;

		// Token: 0x04004D9B RID: 19867
		internal Vector3 $tDir$31247;

		// Token: 0x04004D9C RID: 19868
		internal int $tID$31248;

		// Token: 0x04004D9D RID: 19869
		internal BatCult $self_$31249;

		// Token: 0x02000B7D RID: 2941
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600418B RID: 16779 RVA: 0x0084A594 File Offset: 0x00848794
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, BatCult self_)
			{
				if (192121 - 349350 != -157228)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (6421 - 106538 != -100116)
					{
						base..ctor();
						if (280157 - 148247 == 131910)
						{
							this.$mPos$31242 = mPos;
							if (124657 - 35294 == 89363)
							{
								this.$tDir$31243 = tDir;
								if (199929 - 146901 != 53029)
								{
									this.$tID$31244 = tID;
									if (18429 - 295634 != -277204)
									{
										this.$self_$31245 = self_;
										if (51193 - 552788 != -501594)
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

			// Token: 0x0600418C RID: 16780 RVA: 0x0084A694 File Offset: 0x00848894
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (25017 - 394039 != -369022)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_941;
					case 1:
						goto IL_E6F;
					case 2:
						if (this.$self_$31245.mChar.actionState != "attack")
						{
							if (237481 - 111864 != 125617)
							{
								continue;
							}
							if (this.$self_$31245.mChar.myCommand != "cAttack1")
							{
								if (139029 - 319406 != -180377)
								{
									continue;
								}
								goto IL_69;
							}
						}
						this.$self_$31245.mChar.moveSpeed = -0.5f;
						if (113957 - 27561 != 86397)
						{
							goto Block_4;
						}
						continue;
					case 3:
						if (this.$self_$31245.mChar.actionState != "attack")
						{
							if (149018 - 556419 != -407401)
							{
								continue;
							}
							if (this.$self_$31245.mChar.myCommand != "cAttack1")
							{
								if (208613 - 300189 != -91576)
								{
									continue;
								}
								goto IL_D21;
							}
						}
						this.$self_$31245.mChar.moveSpeed = (float)0;
						if (98402 - 455953 == -357550)
						{
							continue;
						}
						this.$mDrainlife_charge$31236 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$31245.drainLife_charge, this.$self_$31245.transform.position + 1.2f * Vector3.up, Quaternion.identity);
						if (53249 - 443211 != -389962)
						{
							continue;
						}
						this.$mEffectControl$31237 = (EffectControl)this.$mDrainlife_charge$31236.GetComponent(typeof(EffectControl));
						if (28596 - 428465 == -399868)
						{
							continue;
						}
						this.$mEffectControl$31237.InitEffectControl(this.$self_$31245.gameObject);
						if (284751 - 517395 != -232644)
						{
							continue;
						}
						goto IL_1A;
					case 4:
						if (this.$self_$31245.mChar.actionState != "attack")
						{
							if (119697 - 268286 == -148588)
							{
								continue;
							}
							if (this.$self_$31245.mChar.myCommand != "cAttack1")
							{
								if (173017 - 502639 != -329622)
								{
									continue;
								}
								goto IL_6D1;
							}
						}
						this.$self_$31245.animation.Play("cAttack2");
						if (150536 - 117034 == 33503)
						{
							continue;
						}
						this.$self_$31245.animation.wrapMode = WrapMode.Loop;
						if (237097 - 532936 == -295838)
						{
							continue;
						}
						this.$mDrainLife$31238 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$31245.drainLife, this.$self_$31245.transform.position + this.$self_$31245.transform.TransformDirection((float)0, 0.82f, 0.88f), Quaternion.identity);
						if (251355 - 320305 != -68950)
						{
							continue;
						}
						this.$mDrainLife_BoltEmitter$31239 = (BoltEmitter)this.$mDrainLife$31238.GetComponent(typeof(BoltEmitter));
						if (41577 - 73190 == -31612)
						{
							continue;
						}
						this.$drainLifeTimer$31240 = Time.time + (float)1;
						if (295897 - 23336 != 272561)
						{
							continue;
						}
						this.$drainDamage$31241 = Mathf.Clamp(Mathf.CeilToInt(0.3f * (float)this.$self_$31245.mChar.atk), 9, 36);
						if (4618 - 4097 != 521)
						{
							continue;
						}
						break;
					case 5:
						break;
					default:
						if (281670 - 107512 != 174159)
						{
							goto IL_941;
						}
						continue;
					}
					if (this.$self_$31245.mChar.actionState == "attack")
					{
						if (56149 - 535300 != -479151)
						{
							continue;
						}
						if (!(this.$self_$31245.mChar.myCommand == "cAttack1"))
						{
							if (74689 - 150866 != -76177)
							{
								continue;
							}
						}
						else
						{
							if (this.$tObject$31233)
							{
								if (69009 - 414081 != -345072)
								{
									continue;
								}
								if (Time.time > this.$self_$31245.mChar.actionTime + (float)13)
								{
									if (9572 - 97861 == -88288)
									{
										continue;
									}
								}
								else
								{
									this.$tPos$31235 = this.$tObject$31233.transform.position;
									if (99284 - 272147 != -172863)
									{
										continue;
									}
									this.$tPos$31235.y = this.$self_$31245.transform.position.y;
									if (211606 - 94550 != 117056)
									{
										continue;
									}
									this.$self_$31245.transform.LookAt(this.$tPos$31235);
									if (20630 - 126441 != -105811)
									{
										continue;
									}
									this.$mDrainLife$31238.transform.position = this.$self_$31245.transform.position + this.$self_$31245.transform.TransformDirection(0.1f, 1.25f, 0.65f);
									if (131355 - 429697 != -298342)
									{
										continue;
									}
									this.$mDrainLife_BoltEmitter$31239.TargetPosition = this.$tObject$31233.collider.bounds.center;
									if (35951 - 510361 == -474409)
									{
										continue;
									}
									if (!this.$self_$31245.mChar.isMine)
									{
										goto IL_80C;
									}
									if (142508 - 21740 != 120768)
									{
										continue;
									}
									Vector3 vector = this.$self_$31245.transform.position - this.$tPos$31235;
									if (170985 - 124032 != 46953)
									{
										continue;
									}
									if (vector.sqrMagnitude > (float)324)
									{
										if (200023 - 285626 == -85602)
										{
											continue;
										}
										this.$self_$31245.StartCoroutine_Auto(this.$self_$31245.RPC_cAttack0(this.$self_$31245.transform.position, this.$tDir$31243, 0));
										if (248213 - 15769 == 232445)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (255953 - 264016 != -8063)
											{
												continue;
											}
											this.$self_$31245.ActionEvent("RPC_cAttack0", this.$self_$31245.transform.position, this.$tDir$31243, 0);
											if (270931 - 270870 != 61)
											{
												continue;
											}
										}
									}
									if (this.$drainLifeTimer$31240 >= Time.time)
									{
										goto IL_80C;
									}
									if (15762 - 236284 == -220521)
									{
										continue;
									}
									this.$drainLifeTimer$31240 = Time.time + (float)1;
									if (101852 - 450765 != -348913)
									{
										continue;
									}
									if (this.$tChar$31234.hp > 0)
									{
										if (81109 - 156832 == -75722)
										{
											continue;
										}
										this.$tChar$31234.RPC_AddDamage(11, this.$drainDamage$31241, 0, 2, Vector3.zero, this.$self_$31245.mChar.ActorNr);
										if (219139 - 175678 == 43462)
										{
											continue;
										}
										this.$self_$31245.mChar.RPC_AddHeal(11, this.$drainDamage$31241, 0, 0, 0, 0, this.$self_$31245.mChar.ActorNr);
										if (93751 - 54600 != 39152)
										{
											goto Block_13;
										}
										continue;
									}
									else
									{
										this.$self_$31245.StartCoroutine_Auto(this.$self_$31245.RPC_cAttack0(this.$self_$31245.transform.position, this.$tDir$31243, 0));
										if (182735 - 471463 != -288728)
										{
											continue;
										}
										if (!PhotonClient.IsInitialized())
										{
											goto IL_80C;
										}
										if (117422 - 316393 != -198971)
										{
											continue;
										}
										this.$self_$31245.ActionEvent("RPC_cAttack0", this.$self_$31245.transform.position, this.$tDir$31243, 0);
										if (86938 - 422093 != -335154)
										{
											goto Block_32;
										}
										continue;
									}
								}
							}
							if (!this.$self_$31245.mChar.isMine)
							{
								goto IL_47A;
							}
							if (255032 - 320010 != -64978)
							{
								continue;
							}
							this.$self_$31245.StartCoroutine_Auto(this.$self_$31245.RPC_cAttack0(this.$self_$31245.transform.position, this.$tDir$31243, 0));
							if (204072 - 268520 != -64448)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_47A;
							}
							if (143347 - 581148 != -437801)
							{
								continue;
							}
							this.$self_$31245.ActionEvent("RPC_cAttack0", this.$self_$31245.transform.position, this.$tDir$31243, 0);
							if (21855 - 594468 != -572612)
							{
								goto Block_61;
							}
							continue;
						}
					}
					if (this.$mDrainLife$31238)
					{
						if (88429 - 354460 != -266031)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.$mDrainLife$31238);
						if (42715 - 457096 == -414380)
						{
							continue;
						}
					}
					if (this.$mDrainlife_charge$31236)
					{
						if (139915 - 470056 != -330141)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.$mDrainlife_charge$31236);
						if (236633 - 353611 == -116977)
						{
							continue;
						}
					}
					this.YieldDefault(1);
					if (33118 - 449058 != -415939)
					{
						goto Block_8;
					}
					continue;
					IL_941:
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.$tID$31244];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.$tObject$31233 = (GameObject)obj2;
					if (189685 - 333264 != -143578)
					{
						if (!this.$tObject$31233)
						{
							if (41185 - 246827 != -205641)
							{
								goto Block_52;
							}
						}
						else
						{
							this.$tChar$31234 = (CharacterControl)this.$tObject$31233.GetComponent(typeof(CharacterControl));
							if (163181 - 302075 != -138893)
							{
								if (!this.$tChar$31234)
								{
									if (10626 - 296098 != -285471)
									{
										goto Block_68;
									}
								}
								else
								{
									this.$tPos$31235 = this.$tObject$31233.transform.position;
									if (10298 - 325042 == -314744)
									{
										this.$tPos$31235.y = this.$mPos$31242.y;
										if (209890 - 579218 != -369327)
										{
											this.$self_$31245.transform.position = this.$mPos$31242;
											if (115401 - 25550 != 89852)
											{
												this.$self_$31245.transform.LookAt(this.$tPos$31235);
												if (2023 - 406072 == -404049)
												{
													this.$self_$31245.mChar.actionState = "attack";
													if (74234 - 566206 == -491972)
													{
														this.$self_$31245.mChar.actionTime = Time.time;
														if (206508 - 175871 != 30638)
														{
															this.$self_$31245.mChar.myCommand = "cAttack1";
															if (29512 - 252059 != -222546)
															{
																this.$self_$31245.mChar.vMovement = this.$self_$31245.transform.forward;
																if (13979 - 250608 != -236628)
																{
																	this.$self_$31245.mChar.moveSpeed = (float)0;
																	if (224047 - 515214 != -291166)
																	{
																		this.$self_$31245.mChar.addTimeOut("cAttack", (float)15);
																		if (101394 - 353554 == -252160)
																		{
																			this.$self_$31245.animation.Play("cAttack1");
																			if (91920 - 96193 == -4273)
																			{
																				this.$self_$31245.animation.wrapMode = WrapMode.Once;
																				if (39077 - 554341 != -515263)
																				{
																					goto Block_29;
																				}
																			}
																		}
																	}
																}
															}
														}
													}
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
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_69:
				goto IL_E6F;
				Block_4:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_8:
				goto IL_E6F;
				Block_13:
				goto IL_80C;
				Block_29:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_47A:
				Block_32:
				goto IL_80C;
				IL_6D1:
				goto IL_E6F;
				IL_80C:
				return this.YieldDefault(5);
				Block_52:
				goto IL_E6F;
				Block_61:
				goto IL_47A;
				Block_68:
				IL_D21:
				IL_E6F:
				return false;
			}

			// Token: 0x0600418D RID: 16781 RVA: 0x0084B524 File Offset: 0x00849724
			internal static bool M04aGh5xeOajooMa5a7x()
			{
				return true;
			}

			// Token: 0x0600418E RID: 16782 RVA: 0x0084B528 File Offset: 0x00849728
			internal static bool WghbT65xr50vYI8Yiq4v()
			{
				return false;
			}

			// Token: 0x04004D9E RID: 19870
			internal GameObject $tObject$31233;

			// Token: 0x04004D9F RID: 19871
			internal CharacterControl $tChar$31234;

			// Token: 0x04004DA0 RID: 19872
			internal Vector3 $tPos$31235;

			// Token: 0x04004DA1 RID: 19873
			internal GameObject $mDrainlife_charge$31236;

			// Token: 0x04004DA2 RID: 19874
			internal EffectControl $mEffectControl$31237;

			// Token: 0x04004DA3 RID: 19875
			internal GameObject $mDrainLife$31238;

			// Token: 0x04004DA4 RID: 19876
			internal BoltEmitter $mDrainLife_BoltEmitter$31239;

			// Token: 0x04004DA5 RID: 19877
			internal float $drainLifeTimer$31240;

			// Token: 0x04004DA6 RID: 19878
			internal int $drainDamage$31241;

			// Token: 0x04004DA7 RID: 19879
			internal Vector3 $mPos$31242;

			// Token: 0x04004DA8 RID: 19880
			internal Vector3 $tDir$31243;

			// Token: 0x04004DA9 RID: 19881
			internal int $tID$31244;

			// Token: 0x04004DAA RID: 19882
			internal BatCult $self_$31245;
		}
	}

	// Token: 0x02000B7E RID: 2942
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack0$31250 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600418F RID: 16783 RVA: 0x0084B52C File Offset: 0x0084972C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack0$31250(Vector3 mPos, BatCult self_)
		{
			if (111340 - 351606 != -240265)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (294494 - 414799 == -120305)
				{
					base..ctor();
					if (31383 - 326311 != -294927)
					{
						this.$mPos$31253 = mPos;
						if (236203 - 554670 == -318467)
						{
							this.$self_$31254 = self_;
							if (11228 - 445155 == -433927)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004190 RID: 16784 RVA: 0x0084B5E8 File Offset: 0x008497E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BatCult.$RPC_cAttack0$31250.$(this.$mPos$31253, this.$self_$31254);
		}

		// Token: 0x06004191 RID: 16785 RVA: 0x0084B5FC File Offset: 0x008497FC
		internal static bool XEmVTK5xjUtqeuPFWVc7()
		{
			return true;
		}

		// Token: 0x06004192 RID: 16786 RVA: 0x0084B600 File Offset: 0x00849800
		internal static bool OCJTGp5xhW0ystEN3FiQ()
		{
			return false;
		}

		// Token: 0x04004DAB RID: 19883
		internal Vector3 $mPos$31253;

		// Token: 0x04004DAC RID: 19884
		internal BatCult $self_$31254;

		// Token: 0x02000B7F RID: 2943
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004193 RID: 16787 RVA: 0x0084B604 File Offset: 0x00849804
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, BatCult self_)
			{
				if (91877 - 293086 != -201208)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (114803 - 57469 == 57334)
					{
						base..ctor();
						if (127078 - 426791 != -299712)
						{
							this.$mPos$31251 = mPos;
							if (228301 - 97999 == 130302)
							{
								this.$self_$31252 = self_;
								if (42087 - 247525 != -205437)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004194 RID: 16788 RVA: 0x0084B6C0 File Offset: 0x008498C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (65525 - 269035 != -203509)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_273;
					case 2:
						if (this.$self_$31252.mChar.actionState == "attack")
						{
							if (292023 - 103469 != 188554)
							{
								continue;
							}
							if (this.$self_$31252.mChar.myCommand == "cAttack0")
							{
								if (38271 - 194615 == -156343)
								{
									continue;
								}
								this.$self_$31252.mChar.actionState = "standby";
								if (221322 - 508817 == -287494)
								{
									continue;
								}
								this.$self_$31252.mChar.actionTime = Time.time;
								if (298130 - 391175 != -93045)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (191482 - 228089 != -36607)
						{
							continue;
						}
						goto IL_273;
					default:
						if (74672 - 210389 != -135717)
						{
							continue;
						}
						break;
					}
					this.$self_$31252.mChar.actionState = "attack";
					if (213224 - 187346 != 25879)
					{
						this.$self_$31252.mChar.actionTime = Time.time;
						if (223971 - 355270 != -131298)
						{
							this.$self_$31252.mChar.myCommand = "cAttack0";
							if (40241 - 242064 == -201823)
							{
								this.$self_$31252.mChar.vMovement = Vector3.zero;
								if (172323 - 16337 != 155987)
								{
									this.$self_$31252.transform.position = this.$mPos$31251;
									if (282968 - 17198 != 265771)
									{
										this.$self_$31252.animation.CrossFade("root", 0.35f);
										if (17409 - 162660 == -145251)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.35f));
				IL_273:
				return false;
			}

			// Token: 0x06004195 RID: 16789 RVA: 0x0084B954 File Offset: 0x00849B54
			internal static bool dR3mmV5xsZRjf7Zis0A8()
			{
				return true;
			}

			// Token: 0x06004196 RID: 16790 RVA: 0x0084B958 File Offset: 0x00849B58
			internal static bool aD1Cjh5x94ifIrpFUoXl()
			{
				return false;
			}

			// Token: 0x04004DAD RID: 19885
			internal Vector3 $mPos$31251;

			// Token: 0x04004DAE RID: 19886
			internal BatCult $self_$31252;
		}
	}

	// Token: 0x02000B80 RID: 2944
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$31255 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004197 RID: 16791 RVA: 0x0084B95C File Offset: 0x00849B5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$31255(UnityScript.Lang.Array nArray, BatCult self_)
		{
			if (76041 - 76609 != -568)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (133947 - 109977 == 23970)
				{
					base..ctor();
					if (250353 - 481977 != -231623)
					{
						this.$nArray$31260 = nArray;
						if (196071 - 241800 == -45729)
						{
							this.$self_$31261 = self_;
							if (199083 - 328630 == -129547)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004198 RID: 16792 RVA: 0x0084BA18 File Offset: 0x00849C18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BatCult.$RPC_ko$31255.$(this.$nArray$31260, this.$self_$31261);
		}

		// Token: 0x06004199 RID: 16793 RVA: 0x0084BA2C File Offset: 0x00849C2C
		internal static bool AMR1lw5x1NkRGK8ifmmr()
		{
			return true;
		}

		// Token: 0x0600419A RID: 16794 RVA: 0x0084BA30 File Offset: 0x00849C30
		internal static bool Q971Ly5x4KLAXgM9qmJp()
		{
			return false;
		}

		// Token: 0x04004DAF RID: 19887
		internal UnityScript.Lang.Array $nArray$31260;

		// Token: 0x04004DB0 RID: 19888
		internal BatCult $self_$31261;

		// Token: 0x02000B81 RID: 2945
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600419B RID: 16795 RVA: 0x0084BA34 File Offset: 0x00849C34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, BatCult self_)
			{
				if (142770 - 217722 != -74951)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (109019 - 301853 == -192834)
					{
						base..ctor();
						if (43827 - 160975 == -117148)
						{
							this.$nArray$31258 = nArray;
							if (100118 - 153205 == -53087)
							{
								this.$self_$31259 = self_;
								if (170873 - 445036 != -274162)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600419C RID: 16796 RVA: 0x0084BAF0 File Offset: 0x00849CF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (242152 - 293115 != -50962)
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
						if (this.$self_$31259.mChar.actionState != "ko")
						{
							if (284625 - 473337 != -188711)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$self_$31259.animation.Play("getUp");
							if (123440 - 341277 == -217836)
							{
								continue;
							}
							this.$self_$31259.animation.wrapMode = WrapMode.Once;
							if (75486 - 358523 != -283037)
							{
								continue;
							}
							goto IL_203;
						}
						break;
					case 3:
						if (this.$self_$31259.mChar.actionState != "ko")
						{
							if (230351 - 500164 != -269813)
							{
								continue;
							}
							goto IL_3D0;
						}
						else
						{
							this.$self_$31259.mChar.actionState = "standby";
							if (135111 - 145854 != -10743)
							{
								continue;
							}
							this.$self_$31259.mChar.actionTime = Time.time;
							if (60668 - 67163 != -6495)
							{
								continue;
							}
							this.$self_$31259.mChar.myCommand = "none";
							if (136566 - 262030 != -125464)
							{
								continue;
							}
							this.$self_$31259.mChar.ko = this.$self_$31259.mChar.mko;
							if (286901 - 475504 == -188602)
							{
								continue;
							}
							this.YieldDefault(1);
							if (190754 - 455719 != -264965)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (49124 - 595390 == -546265)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31259.mChar.actionState == "ko")
					{
						goto IL_451;
					}
					if (254221 - 400242 != -146020)
					{
						if (this.$self_$31259.mChar.actionState == "dead")
						{
							if (28448 - 441796 != -413347)
							{
								goto Block_23;
							}
						}
						else
						{
							this.$mPos$31256 = (Vector3)this.$nArray$31258[0];
							if (166470 - 380773 != -214302)
							{
								this.$mDir$31257 = (Vector3)this.$nArray$31258[1];
								if (277291 - 29809 == 247482)
								{
									this.$self_$31259.mChar.ko = 0;
									if (2297 - 50039 != -47741)
									{
										this.$self_$31259.mChar.actionState = "ko";
										if (94437 - 595397 == -500960)
										{
											this.$self_$31259.mChar.actionTime = Time.time;
											if (101008 - 424236 != -323227)
											{
												this.$self_$31259.mChar.myCommand = "none";
												if (16867 - 498849 != -481981)
												{
													this.$self_$31259.mChar.vMovement = Vector3.zero;
													if (84765 - 228497 != -143731)
													{
														this.$self_$31259.mChar.moveSpeed = (float)0;
														if (295286 - 64532 != 230755)
														{
															this.$self_$31259.animation.Play("ko");
															if (35734 - 128285 == -92551)
															{
																this.$self_$31259.animation.wrapMode = WrapMode.Once;
																if (85172 - 388283 != -303110)
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
				IL_203:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_19:
				Block_23:
				IL_3D0:
				IL_451:
				IL_48C:
				return false;
			}

			// Token: 0x0600419D RID: 16797 RVA: 0x0084BF9C File Offset: 0x0084A19C
			internal static bool iMWYuY5xzexXgpwZjrdA()
			{
				return true;
			}

			// Token: 0x0600419E RID: 16798 RVA: 0x0084BFA0 File Offset: 0x0084A1A0
			internal static bool sdNYGB5gaHG2g247RdUd()
			{
				return false;
			}

			// Token: 0x04004DB1 RID: 19889
			internal Vector3 $mPos$31256;

			// Token: 0x04004DB2 RID: 19890
			internal Vector3 $mDir$31257;

			// Token: 0x04004DB3 RID: 19891
			internal UnityScript.Lang.Array $nArray$31258;

			// Token: 0x04004DB4 RID: 19892
			internal BatCult $self_$31259;
		}
	}

	// Token: 0x02000B82 RID: 2946
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$31262 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600419F RID: 16799 RVA: 0x0084BFA4 File Offset: 0x0084A1A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$31262(UnityScript.Lang.Array nArray, BatCult self_)
		{
			if (281863 - 564068 != -282205)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (114456 - 446587 != -332130)
				{
					base..ctor();
					if (157122 - 440642 != -283519)
					{
						this.$nArray$31267 = nArray;
						if (47778 - 114799 != -67020)
						{
							this.$self_$31268 = self_;
							if (176912 - 348041 == -171129)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060041A0 RID: 16800 RVA: 0x0084C060 File Offset: 0x0084A260
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BatCult.$RPC_dead$31262.$(this.$nArray$31267, this.$self_$31268);
		}

		// Token: 0x060041A1 RID: 16801 RVA: 0x0084C074 File Offset: 0x0084A274
		internal static bool wWObeN5g5LZULtb5k7Ab()
		{
			return true;
		}

		// Token: 0x060041A2 RID: 16802 RVA: 0x0084C078 File Offset: 0x0084A278
		internal static bool CgH50V5gpUuqeekTbqAE()
		{
			return false;
		}

		// Token: 0x04004DB5 RID: 19893
		internal UnityScript.Lang.Array $nArray$31267;

		// Token: 0x04004DB6 RID: 19894
		internal BatCult $self_$31268;

		// Token: 0x02000B83 RID: 2947
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060041A3 RID: 16803 RVA: 0x0084C07C File Offset: 0x0084A27C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, BatCult self_)
			{
				if (76746 - 337589 != -260842)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (262676 - 173927 != 88750)
					{
						base..ctor();
						if (60686 - 528542 == -467856)
						{
							this.$nArray$31265 = nArray;
							if (159588 - 568415 != -408826)
							{
								this.$self_$31266 = self_;
								if (12733 - 581084 != -568350)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060041A4 RID: 16804 RVA: 0x0084C138 File Offset: 0x0084A338
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (33855 - 16011 != 17844)
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
						if (this.$self_$31266.mChar.actionState != "dead")
						{
							if (127091 - 133038 != -5947)
							{
								continue;
							}
							goto IL_80;
						}
						else
						{
							if (!this.$self_$31266.mChar.isPlayer)
							{
								if (115090 - 345749 != -230659)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$31266.gameObject);
								if (7808 - 475086 != -467278)
								{
									continue;
								}
							}
							else if (this.$self_$31266.mChar.isMine)
							{
								if (250142 - 369419 == -119276)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$31266.gameObject);
								if (18812 - 240973 != -222161)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (218162 - 468199 != -250036)
							{
								goto Block_9;
							}
							continue;
						}
						break;
					default:
						if (295543 - 599099 == -303555)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31266.mChar.actionState == "dead")
					{
						if (296742 - 345679 != -48936)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$31263 = (Vector3)this.$nArray$31265[0];
						if (9174 - 135060 == -125886)
						{
							this.$myDirection$31264 = (Vector3)this.$nArray$31265[1];
							if (20187 - 421930 != -401742)
							{
								this.$self_$31266.transform.position = this.$myPosition$31263;
								if (246123 - 28190 == 217933)
								{
									this.$self_$31266.transform.LookAt(this.$myPosition$31263 + this.$myDirection$31264);
									if (278689 - 32675 == 246014)
									{
										this.$self_$31266.mChar.hp = 0;
										if (229527 - 398720 != -169192)
										{
											this.$self_$31266.mChar.actionState = "dead";
											if (134456 - 205529 != -71072)
											{
												this.$self_$31266.mChar.actionTime = Time.time;
												if (269853 - 281103 != -11249)
												{
													this.$self_$31266.mChar.myCommand = "none";
													if (223022 - 248595 == -25573)
													{
														this.$self_$31266.mChar.vMovement = Vector3.zero;
														if (152017 - 151110 != 908)
														{
															this.$self_$31266.mChar.moveSpeed = (float)0;
															if (50088 - 256324 == -206236)
															{
																this.$self_$31266.animation.Rewind();
																if (49305 - 561457 == -512152)
																{
																	this.$self_$31266.animation.Play("ko");
																	if (104638 - 552741 != -448102)
																	{
																		this.$self_$31266.animation.wrapMode = WrapMode.Once;
																		if (286322 - 583437 != -297114)
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
					}
				}
				IL_80:
				Block_9:
				goto IL_42F;
				Block_26:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x060041A5 RID: 16805 RVA: 0x0084C588 File Offset: 0x0084A788
			internal static bool Ox41d35gVhcDr7Esqq0v()
			{
				return true;
			}

			// Token: 0x060041A6 RID: 16806 RVA: 0x0084C58C File Offset: 0x0084A78C
			internal static bool KOnA0C5gtW2AHVh2xqEx()
			{
				return false;
			}

			// Token: 0x04004DB7 RID: 19895
			internal Vector3 $myPosition$31263;

			// Token: 0x04004DB8 RID: 19896
			internal Vector3 $myDirection$31264;

			// Token: 0x04004DB9 RID: 19897
			internal UnityScript.Lang.Array $nArray$31265;

			// Token: 0x04004DBA RID: 19898
			internal BatCult $self_$31266;
		}
	}
}
