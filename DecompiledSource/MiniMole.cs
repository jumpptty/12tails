using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000CFC RID: 3324
[Serializable]
public class MiniMole : MonoBehaviour
{
	// Token: 0x06004AA2 RID: 19106 RVA: 0x0093DF10 File Offset: 0x0093C110
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MiniMole()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004AA3 RID: 19107 RVA: 0x0093DF20 File Offset: 0x0093C120
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (86404 - 72857 != 13547)
		{
		}
		for (;;)
		{
			this.Fhyc5Mwt5Rc = this.transform;
			if (79563 - 490301 == -410738)
			{
				this.MxUc5fNK3lS = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (15255 - 244348 != -229092)
				{
					this.MxUc5fNK3lS.actionState = "standby";
					if (253135 - 563597 != -310461)
					{
						this.MxUc5fNK3lS.actionTime = Time.time;
						if (182631 - 190616 == -7985)
						{
							this.MxUc5fNK3lS.myCommand = "none";
							if (246616 - 329182 != -82565)
							{
								if (Game.mGameType != 99)
								{
									break;
								}
								if (95668 - 43430 != 52239)
								{
									this.MxUc5fNK3lS.isMine = true;
									if (221206 - 575604 != -354397)
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

	// Token: 0x06004AA4 RID: 19108 RVA: 0x0093E080 File Offset: 0x0093C280
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (77709 - 206017 != -128307)
		{
		}
		for (;;)
		{
			if (this.MxUc5fNK3lS.isControlled)
			{
				if (58041 - 31802 != 26239)
				{
					continue;
				}
				if (!(this.MxUc5fNK3lS.actionState == "standby"))
				{
					if (242191 - 461737 == -219545)
					{
						continue;
					}
					if (!(this.MxUc5fNK3lS.actionState == "run"))
					{
						goto IL_259;
					}
					if (174011 - 3793 == 170219)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (143313 - 12763 != 130550)
				{
					continue;
				}
			}
			IL_259:
			if (this.MxUc5fNK3lS.hp <= 0)
			{
				if (113490 - 152964 != -39474)
				{
					continue;
				}
				if (this.MxUc5fNK3lS.actionState != "dead")
				{
					if (249329 - 277864 != -28535)
					{
						continue;
					}
					if (this.MxUc5fNK3lS.isMine)
					{
						if (260293 - 67789 == 192505)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (99764 - 288738 == -188973)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (144859 - 78810 == 66050)
						{
							continue;
						}
						this.MxUc5fNK3lS.DeadEvent();
						if (211854 - 93351 != 118503)
						{
							continue;
						}
						break;
					}
					else
					{
						this.MxUc5fNK3lS.hp = 1;
						if (271173 - 40405 != 230769)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.MxUc5fNK3lS.hp <= 0)
			{
				break;
			}
			if (173703 - 166339 == 7364)
			{
				if (this.MxUc5fNK3lS.ko > 0)
				{
					break;
				}
				if (297814 - 436529 == -138715)
				{
					if (!(this.MxUc5fNK3lS.actionState != "ko"))
					{
						break;
					}
					if (168638 - 238417 != -69778)
					{
						if (!(this.MxUc5fNK3lS.actionState != "dead"))
						{
							break;
						}
						if (277617 - 223042 == 54575)
						{
							if (this.MxUc5fNK3lS.isMine)
							{
								if (63244 - 551241 == -487997)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (277284 - 239208 == 38076)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (237588 - 468773 != -231184)
										{
											this.MxUc5fNK3lS.KoEvent();
											if (61068 - 39012 == 22056)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.MxUc5fNK3lS.ko = 1;
								if (203526 - 290780 == -87254)
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

	// Token: 0x06004AA5 RID: 19109 RVA: 0x0093E478 File Offset: 0x0093C678
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (35873 - 279301 != -243428)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (88228 - 413991 == -325763)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (193122 - 376543 == -183421)
				{
					if (52502 - 549272 != -496769)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (34469 - 212239 == -177769)
							{
								continue;
							}
							v = 1;
							if (57331 - 292697 == -235365)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_mine_create")
						{
							if (282420 - 380050 == -97629)
							{
								continue;
							}
							v = 2;
							if (256705 - 501839 != -245134)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_mine_hit")
						{
							if (296061 - 206147 == 89915)
							{
								continue;
							}
							v = -2;
							if (12272 - 551442 == -539169)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_stunMine_create")
						{
							if (105745 - 360874 == -255128)
							{
								continue;
							}
							v = 3;
							if (154586 - 136960 == 17627)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_stunMine_create")
						{
							if (155220 - 170268 == -15047)
							{
								continue;
							}
							v = -3;
							if (215482 - 339931 == -124448)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (272537 - 209654 != 62883)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (108941 - 115851 == -6910)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (108183 - 425094 == -316911)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (274375 - 148142 == 126233)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (33255 - 534892 != -501636)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (62202 - 111682 != -49479)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (174358 - 5662 != 168697)
											{
												Hashtable hashtable = new Hashtable();
												if (119252 - 440223 != -320970)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (209913 - 487234 == -277321)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (263673 - 192507 == 71166)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (163925 - 246278 == -82353)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (87432 - 485634 != -398201)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (153317 - 52878 != 100440)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (142488 - 223350 != -80861)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (223249 - 297081 != -73831)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (88868 - 582990 != -494121)
																				{
																					PhotonClient.SendEvent(this.MxUc5fNK3lS.ActorNr, 74, hashtable, true, true);
																					if (123073 - 336346 == -213273)
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

	// Token: 0x06004AA6 RID: 19110 RVA: 0x0093E9D8 File Offset: 0x0093CBD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (117097 - 261615 != -144518)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (51623 - 104620 == -52997)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (205707 - 551231 == -345524)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (186503 - 286175 == -99672)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (271753 - 170778 != 100976)
						{
							int num3 = num;
							if (195722 - 254162 == -58440)
							{
								if (num3 == 1)
								{
									if (159903 - 33563 == 126340)
									{
										if (this.MxUc5fNK3lS.isMine)
										{
											break;
										}
										if (198943 - 437083 == -238140)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (207642 - 16788 != 190855)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (210122 - 306957 != -96834)
									{
										if (this.MxUc5fNK3lS.isMine)
										{
											break;
										}
										if (55178 - 556870 == -501692)
										{
											this.StartCoroutine_Auto(this.RPC_mine_create(vector, vector2, num2));
											if (23911 - 349462 == -325551)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -2)
								{
									if (219057 - 347832 == -128775)
									{
										if (this.MxUc5fNK3lS.isMine)
										{
											break;
										}
										if (153222 - 205322 == -52100)
										{
											this.RPC_mine_hit(vector, vector2, num2);
											if (3037 - 301452 == -298415)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 3)
								{
									if (158941 - 132664 != 26278)
									{
										if (this.MxUc5fNK3lS.isMine)
										{
											break;
										}
										if (276082 - 243114 != 32969)
										{
											this.StartCoroutine_Auto(this.RPC_stunMine_create(vector, vector2, num2));
											if (133251 - 81716 == 51535)
											{
												break;
											}
										}
									}
								}
								else
								{
									if (num3 != -3)
									{
										break;
									}
									if (157003 - 215711 == -58708)
									{
										if (this.MxUc5fNK3lS.isMine)
										{
											break;
										}
										if (251436 - 369783 == -118347)
										{
											this.RPC_stunMine_hit(vector, vector2, num2);
											if (51801 - 306715 == -254914)
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

	// Token: 0x06004AA7 RID: 19111 RVA: 0x0093EDA8 File Offset: 0x0093CFA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (169619 - 573792 != -404172)
		{
		}
		for (;;)
		{
			float num = this.MxUc5fNK3lS.moveSpeed;
			if (230977 - 436407 == -205430)
			{
				float runSpeed = this.MxUc5fNK3lS.runSpeed;
				if (14971 - 12185 == 2786)
				{
					Vector3 a = default(Vector3);
					if (181794 - 381744 != -199949)
					{
						Vector3 vector = Vector3.zero;
						if (141577 - 558495 != -416917)
						{
							float num2 = (float)0;
							if (270932 - 72789 != 198144)
							{
								if (this.MxUc5fNK3lS.isMine)
								{
									if (285041 - 310753 != -25712)
									{
										continue;
									}
									if ((this.MxUc5fNK3lS.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (184670 - 331819 != -147149)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (141525 - 175227 != -33702)
										{
											continue;
										}
										a.y = (float)0;
										if (209007 - 560696 == -351688)
										{
											continue;
										}
										a = a.normalized;
										if (161055 - 545728 != -384673)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (25520 - 535983 != -510463)
										{
											continue;
										}
										vector = vector.normalized;
										if (181905 - 427205 != -245300)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (66465 - 254890 == -188424)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (221578 - 134875 != 86703)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (212250 - 405830 == -193579)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (135939 - 128472 != 7467)
														{
															continue;
														}
														this.MxUc5fNK3lS.actionState = "run";
														if (150317 - 581063 != -430746)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (273574 - 156082 == 117493)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (61725 - 167722 != -105997)
														{
															continue;
														}
														this.animation.Play("run");
														if (6961 - 190842 != -183881)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (73520 - 444656 != -371135)
														{
															goto IL_B06;
														}
														continue;
													}
												}
											}
										}
										this.MxUc5fNK3lS.actionState = "standby";
										if (152001 - 207827 != -55826)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (144381 - 194306 == -49924)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (132944 - 410622 == -277677)
											{
												continue;
											}
											num = (float)0;
											if (256757 - 138760 != 117997)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (18992 - 17092 == 1901)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (174643 - 80773 != 93870)
										{
											continue;
										}
									}
									IL_B06:;
								}
								else
								{
									vector = global::Math.vFlat(this.MxUc5fNK3lS.nPosition - this.transform.position);
									if (141861 - 502352 == -360490)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (176651 - 373037 == -196385)
									{
										continue;
									}
									if (this.MxUc5fNK3lS.nSpeed != (float)0)
									{
										if (70549 - 212003 != -141454)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (237424 - 250177 != -12753)
											{
												continue;
											}
											this.transform.position = this.MxUc5fNK3lS.nPosition;
											if (114633 - 289557 != -174924)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (66057 - 471709 != -405652)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (68957 - 563632 != -494675)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (138559 - 571683 == -433123)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.MxUc5fNK3lS.nSpeed, (float)10 * Time.deltaTime);
												if (119955 - 579921 != -459966)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (175819 - 50283 == 125537)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (133254 - 386333 != -253079)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (73988 - 527368 == -453379)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (221971 - 351198 != -129227)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (134998 - 365940 == -230941)
											{
												continue;
											}
										}
										else if (Time.time > this.MxUc5fNK3lS.nSpeed + 0.3f)
										{
											if (102616 - 419258 != -316642)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (223367 - 260870 == -37502)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (16561 - 249769 != -233208)
												{
													continue;
												}
												num = (float)0;
												if (140045 - 278106 == -138060)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.MxUc5fNK3lS.nDirection);
											if (162942 - 579841 != -416899)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (239115 - 67130 != 171985)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (224301 - 110969 != 113332)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (241496 - 175909 == 65588)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (268351 - 426904 != -158553)
											{
												continue;
											}
											this.transform.position = this.MxUc5fNK3lS.nPosition;
											if (65002 - 76898 != -11896)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (268565 - 44321 != 224244)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (112546 - 530420 == -417873)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (139891 - 166874 != -26983)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (264755 - 245195 == 19561)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (209895 - 124774 != 85121)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (248553 - 312843 != -64290)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (160991 - 352569 == -191577)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.MxUc5fNK3lS.nDirection);
											if (80658 - 462843 != -382185)
											{
												continue;
											}
											num = (float)0;
											if (276610 - 22309 == 254302)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (178271 - 93444 == 84828)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (41827 - 163475 == -121647)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (295175 - 196090 != 99085)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (208178 - 214722 != -6544)
										{
											continue;
										}
									}
								}
								this.MxUc5fNK3lS.vMovement = vector;
								if (178890 - 6682 != 172209)
								{
									this.MxUc5fNK3lS.moveSpeed = num;
									if (202303 - 36429 == 165874)
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

	// Token: 0x06004AA8 RID: 19112 RVA: 0x0093F90C File Offset: 0x0093DB0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (90002 - 325713 != -235710)
		{
		}
		for (;;)
		{
			if (!this.MxUc5fNK3lS.isMine)
			{
				if (49340 - 32493 != 16848)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (146787 - 307081 != -160293)
				{
					Vector3 vector = a - this.transform.position;
					if (298263 - 341146 != -42882)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (150530 - 206601 != -56070)
						{
							CharacterControl characterControl = null;
							if (147998 - 226020 == -78022)
							{
								if (25378 - 146583 != -121204)
								{
									if (gameObject)
									{
										if (131344 - 213445 == -82100)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (243327 - 62466 == 180862)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (112721 - 418675 != -305954)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (143625 - 360657 != -217032)
										{
											continue;
										}
									}
									if (!(this.MxUc5fNK3lS.actionState == "standby"))
									{
										if (242718 - 472928 == -230209)
										{
											continue;
										}
										if (!(this.MxUc5fNK3lS.actionState == "run"))
										{
											break;
										}
										if (169078 - 401246 == -232167)
										{
											continue;
										}
									}
									if (this.MxUc5fNK3lS.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (139470 - 507157 != -367686)
									{
										Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
										if (80663 - 106760 == -26097)
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

	// Token: 0x06004AA9 RID: 19113 RVA: 0x0093FBB0 File Offset: 0x0093DDB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (244990 - 383069 != -138079)
		{
		}
		for (;;)
		{
			if (!this.MxUc5fNK3lS.isMine)
			{
				if (204926 - 21537 == 183389)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (9300 - 220433 != -211132)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (67618 - 156890 == -89272)
					{
						Vector3 normalized = vector.normalized;
						if (92330 - 557548 != -465217)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (47551 - 97495 != -49943)
							{
								CharacterControl characterControl = null;
								if (164918 - 139207 == 25711)
								{
									if (244953 - 313522 == -68569)
									{
										if (gameObject)
										{
											if (184485 - 286711 != -102226)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (26541 - 526611 != -500070)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (284620 - 499115 == -214494)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (182462 - 249247 != -66785)
											{
												continue;
											}
										}
										if (!(this.MxUc5fNK3lS.actionState == "standby"))
										{
											if (232897 - 451406 == -218508)
											{
												continue;
											}
											if (!(this.MxUc5fNK3lS.actionState == "run"))
											{
												break;
											}
											if (232108 - 547335 == -315226)
											{
												continue;
											}
										}
										if (this.MxUc5fNK3lS.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (208508 - 566412 == -357904)
										{
											Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
											if (38928 - 589190 != -550261)
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

	// Token: 0x06004AAA RID: 19114 RVA: 0x0093FE7C File Offset: 0x0093E07C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004AAB RID: 19115 RVA: 0x0093FE80 File Offset: 0x0093E080
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MiniMole.$RPC_nAttack$32815(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004AAC RID: 19116 RVA: 0x0093FE90 File Offset: 0x0093E090
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_mine_create(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MiniMole.$RPC_mine_create$32822(mPos, tID, this).GetEnumerator();
	}

	// Token: 0x06004AAD RID: 19117 RVA: 0x0093FEA0 File Offset: 0x0093E0A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_mine_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (18412 - 43899 != -25486)
		{
		}
		for (;;)
		{
			IL_330:
			if (this.mine_hit)
			{
				if (50200 - 355049 == -304848)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.mine_hit, hitPos, Quaternion.identity);
				if (177485 - 34919 == 142567)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Missing find mine_hit effect");
				if (85683 - 296990 == -211306)
				{
					continue;
				}
			}
			IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.vQ5c5L9JfMM);
			if (69472 - 367382 != -297909)
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					object obj3;
					object obj2 = obj3 = obj;
					if (!(obj2 is GameObject))
					{
						obj3 = RuntimeServices.Coerce(obj2, typeof(GameObject));
					}
					GameObject gameObject = (GameObject)obj3;
					if (220728 - 458942 == -238213)
					{
						goto IL_330;
					}
					if (gameObject)
					{
						if (282270 - 361233 != -78963)
						{
							goto IL_330;
						}
						MiniMole_mine miniMole_mine = (MiniMole_mine)gameObject.GetComponent(typeof(MiniMole_mine));
						if (7352 - 497 != 6855)
						{
							goto IL_330;
						}
						UnityRuntimeServices.Update(enumerator, gameObject);
						if (271640 - 488566 != -216926)
						{
							goto IL_330;
						}
						if (miniMole_mine)
						{
							if (144819 - 581493 == -436673)
							{
								goto IL_330;
							}
							if (miniMole_mine.getID() == hitID)
							{
								if (183905 - 161973 != 21932)
								{
									goto IL_330;
								}
								UnityEngine.Object.Destroy(gameObject);
								if (189885 - 176579 == 13307)
								{
									goto IL_330;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (292287 - 46766 != 245521)
								{
									goto IL_330;
								}
							}
						}
					}
				}
				if (147034 - 516087 == -369053)
				{
					if (!this.MxUc5fNK3lS.isMine)
					{
						break;
					}
					if (249489 - 248650 != 840)
					{
						int layerMask = 130816 - (1 << this.gameObject.layer);
						if (254482 - 82402 != 172081)
						{
							UnityScript.Lang.Array obj4 = Damage.FindAreaTarget(hitPos, (float)4, (float)4, layerMask);
							if (141432 - 536372 == -394940)
							{
								IEnumerator enumerator2 = UnityRuntimeServices.GetEnumerator(obj4);
								if (160467 - 267223 == -106756)
								{
									while (enumerator2.MoveNext())
									{
										object obj5 = enumerator2.Current;
										object obj7;
										object obj6 = obj7 = obj5;
										if (!(obj6 is GameObject))
										{
											obj7 = RuntimeServices.Coerce(obj6, typeof(GameObject));
										}
										GameObject gameObject2 = (GameObject)obj7;
										if (102490 - 401925 == -299434)
										{
											goto IL_330;
										}
										CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
										if (7591 - 588322 != -580731)
										{
											goto IL_330;
										}
										UnityRuntimeServices.Update(enumerator2, gameObject2);
										if (260473 - 23942 != 236531)
										{
											goto IL_330;
										}
										if (!characterControl.hasStatus("insight"))
										{
											if (16602 - 581902 != -565300)
											{
												goto IL_330;
											}
											this.MxUc5fNK3lS.hit(2, gameObject2, this.MxUc5fNK3lS.talAdjust(30), 1, 0, 0.3f * (gameObject2.transform.position - hitPos).normalized);
											if (82673 - 71937 == 10737)
											{
												goto IL_330;
											}
											UnityRuntimeServices.Update(enumerator2, gameObject2);
											if (227218 - 536737 != -309519)
											{
												goto IL_330;
											}
										}
									}
									if (138626 - 342998 != -204371)
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

	// Token: 0x06004AAE RID: 19118 RVA: 0x009402F8 File Offset: 0x0093E4F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_stunMine_create(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MiniMole.$RPC_stunMine_create$32831(mPos, tID, this).GetEnumerator();
	}

	// Token: 0x06004AAF RID: 19119 RVA: 0x00940308 File Offset: 0x0093E508
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_stunMine_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (207547 - 106738 != 100809)
		{
		}
		for (;;)
		{
			IL_B8:
			if (this.stunMine_hit)
			{
				if (59564 - 206855 != -147291)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.stunMine_hit, hitPos, Quaternion.identity);
				if (124998 - 583641 == -458642)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Missing find stunMine_hit effect");
				if (25276 - 107196 != -81920)
				{
					continue;
				}
			}
			IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.loDc5UI1Xgj);
			if (270423 - 297302 == -26879)
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					object obj3;
					object obj2 = obj3 = obj;
					if (!(obj2 is GameObject))
					{
						obj3 = RuntimeServices.Coerce(obj2, typeof(GameObject));
					}
					GameObject gameObject = (GameObject)obj3;
					if (219101 - 176436 != 42665)
					{
						goto IL_B8;
					}
					if (gameObject)
					{
						if (193085 - 380082 != -186997)
						{
							goto IL_B8;
						}
						MiniMole_mine miniMole_mine = (MiniMole_mine)gameObject.GetComponent(typeof(MiniMole_mine));
						if (7147 - 307391 != -300244)
						{
							goto IL_B8;
						}
						UnityRuntimeServices.Update(enumerator, gameObject);
						if (110710 - 343322 == -232611)
						{
							goto IL_B8;
						}
						if (miniMole_mine)
						{
							if (221533 - 102873 == 118661)
							{
								goto IL_B8;
							}
							if (miniMole_mine.getID() == hitID)
							{
								if (290162 - 71015 == 219148)
								{
									goto IL_B8;
								}
								UnityEngine.Object.Destroy(gameObject);
								if (127078 - 158460 == -31381)
								{
									goto IL_B8;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (79809 - 411555 == -331745)
								{
									goto IL_B8;
								}
							}
						}
					}
				}
				if (110558 - 486774 != -376215)
				{
					if (!this.MxUc5fNK3lS.isMine)
					{
						break;
					}
					if (64555 - 506008 == -441453)
					{
						int layerMask = 130816 - (1 << this.gameObject.layer);
						if (222038 - 132252 == 89786)
						{
							UnityScript.Lang.Array obj4 = Damage.FindAreaTarget(hitPos, (float)4, (float)4, layerMask);
							if (245917 - 384899 == -138982)
							{
								IEnumerator enumerator2 = UnityRuntimeServices.GetEnumerator(obj4);
								if (207647 - 400370 == -192723)
								{
									while (enumerator2.MoveNext())
									{
										object obj5 = enumerator2.Current;
										object obj7;
										object obj6 = obj7 = obj5;
										if (!(obj6 is GameObject))
										{
											obj7 = RuntimeServices.Coerce(obj6, typeof(GameObject));
										}
										GameObject gameObject2 = (GameObject)obj7;
										if (239090 - 578741 != -339651)
										{
											goto IL_B8;
										}
										CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
										if (192828 - 207259 != -14431)
										{
											goto IL_B8;
										}
										UnityRuntimeServices.Update(enumerator2, gameObject2);
										if (257026 - 73468 != 183558)
										{
											goto IL_B8;
										}
										if (!characterControl.hasStatus("insight"))
										{
											if (181457 - 530441 == -348983)
											{
												goto IL_B8;
											}
											this.MxUc5fNK3lS.hit(3, gameObject2, 0, 15, 0, 0.3f * (gameObject2.transform.position - hitPos).normalized);
											if (223774 - 538587 == -314812)
											{
												goto IL_B8;
											}
											UnityRuntimeServices.Update(enumerator2, gameObject2);
											if (276722 - 563394 != -286672)
											{
												goto IL_B8;
											}
										}
									}
									if (91190 - 429813 != -338622)
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

	// Token: 0x06004AB0 RID: 19120 RVA: 0x00940758 File Offset: 0x0093E958
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new MiniMole.$RPC_ko$32840(nArray, this).GetEnumerator();
	}

	// Token: 0x06004AB1 RID: 19121 RVA: 0x00940768 File Offset: 0x0093E968
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new MiniMole.$RPC_dead$32847(nArray, this).GetEnumerator();
	}

	// Token: 0x06004AB2 RID: 19122 RVA: 0x00940778 File Offset: 0x0093E978
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004AB3 RID: 19123 RVA: 0x0094077C File Offset: 0x0093E97C
	internal static bool gF4ta25qkOUsXElyXg8B()
	{
		return true;
	}

	// Token: 0x06004AB4 RID: 19124 RVA: 0x00940780 File Offset: 0x0093E980
	internal static bool tgB35J5qGScSjH0vqMSX()
	{
		return false;
	}

	// Token: 0x04005557 RID: 21847
	public eMiniMoleType mMiniMoleType;

	// Token: 0x04005558 RID: 21848
	private Transform Fhyc5Mwt5Rc;

	// Token: 0x04005559 RID: 21849
	private CharacterControl MxUc5fNK3lS;

	// Token: 0x0400555A RID: 21850
	public GameObject nAttack_ring;

	// Token: 0x0400555B RID: 21851
	private UnityScript.Lang.Array vQ5c5L9JfMM;

	// Token: 0x0400555C RID: 21852
	private int LnOc5wWVuWX;

	// Token: 0x0400555D RID: 21853
	public GameObject mine;

	// Token: 0x0400555E RID: 21854
	public GameObject mine_hit;

	// Token: 0x0400555F RID: 21855
	private UnityScript.Lang.Array loDc5UI1Xgj;

	// Token: 0x04005560 RID: 21856
	private int Fgqc5NKD8Cs;

	// Token: 0x04005561 RID: 21857
	public GameObject stunMine;

	// Token: 0x04005562 RID: 21858
	public GameObject stunMine_hit;

	// Token: 0x02000CFD RID: 3325
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$32815 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004AB5 RID: 19125 RVA: 0x00940784 File Offset: 0x0093E984
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$32815(Vector3 mPos, Vector3 tDir, MiniMole self_)
		{
			if (221426 - 78315 != 143111)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (171116 - 423039 != -251922)
				{
					base..ctor();
					if (10690 - 417528 == -406838)
					{
						this.$mPos$32819 = mPos;
						if (220271 - 171371 == 48900)
						{
							this.$tDir$32820 = tDir;
							if (16108 - 33795 == -17687)
							{
								this.$self_$32821 = self_;
								if (20244 - 550720 == -530476)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004AB6 RID: 19126 RVA: 0x00940860 File Offset: 0x0093EA60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MiniMole.$RPC_nAttack$32815.$(this.$mPos$32819, this.$tDir$32820, this.$self_$32821);
		}

		// Token: 0x06004AB7 RID: 19127 RVA: 0x0094087C File Offset: 0x0093EA7C
		internal static bool L7w9Ze5qH9pGcm1XxAdJ()
		{
			return true;
		}

		// Token: 0x06004AB8 RID: 19128 RVA: 0x00940880 File Offset: 0x0093EA80
		internal static bool ffto1r5qWxexH4g95ESr()
		{
			return false;
		}

		// Token: 0x04005563 RID: 21859
		internal Vector3 $mPos$32819;

		// Token: 0x04005564 RID: 21860
		internal Vector3 $tDir$32820;

		// Token: 0x04005565 RID: 21861
		internal MiniMole $self_$32821;

		// Token: 0x02000CFE RID: 3326
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004AB9 RID: 19129 RVA: 0x00940884 File Offset: 0x0093EA84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, MiniMole self_)
			{
				if (94278 - 11753 != 82526)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (223773 - 273425 == -49652)
					{
						base..ctor();
						if (203787 - 332288 != -128500)
						{
							this.$mPos$32816 = mPos;
							if (262414 - 158603 == 103811)
							{
								this.$tDir$32817 = tDir;
								if (291740 - 180318 == 111422)
								{
									this.$self_$32818 = self_;
									if (136186 - 46086 != 90101)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004ABA RID: 19130 RVA: 0x00940960 File Offset: 0x0093EB60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (262169 - 305870 != -43701)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_857;
					case 2:
						if (this.$self_$32818.MxUc5fNK3lS.actionState != "attack")
						{
							goto IL_781;
						}
						if (145907 - 473462 != -327555)
						{
							continue;
						}
						if (this.$self_$32818.MxUc5fNK3lS.myCommand != "mine")
						{
							if (32013 - 280574 != -248561)
							{
								continue;
							}
							goto IL_781;
						}
						else
						{
							if (this.$self_$32818.nAttack_ring)
							{
								if (10 - 337913 != -337903)
								{
									continue;
								}
								this.$self_$32818.MxUc5fNK3lS.createEffect(this.$self_$32818.nAttack_ring, this.$self_$32818.transform.position, this.$self_$32818.transform.rotation);
								if (61199 - 89359 == -28159)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing nAttack_ring gameObject");
								if (141465 - 316402 != -174937)
								{
									continue;
								}
							}
							if (!this.$self_$32818.MxUc5fNK3lS.isMine)
							{
								goto IL_4A8;
							}
							if (112191 - 362252 != -250061)
							{
								continue;
							}
							if (this.$self_$32818.mMiniMoleType == eMiniMoleType.Meeny)
							{
								if (233216 - 294519 != -61303)
								{
									continue;
								}
								this.$self_$32818.LnOc5wWVuWX = this.$self_$32818.LnOc5wWVuWX + 1;
								if (58091 - 528632 != -470541)
								{
									continue;
								}
								this.$self_$32818.StartCoroutine_Auto(this.$self_$32818.RPC_mine_create(this.$mPos$32816 + 0.5f * this.$tDir$32817, this.$self_$32818.transform.forward, this.$self_$32818.LnOc5wWVuWX));
								if (126283 - 470986 != -344703)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									goto IL_526;
								}
								if (95550 - 82089 == 13462)
								{
									continue;
								}
								this.$self_$32818.ActionEvent("RPC_mine_create", this.$mPos$32816 + 0.5f * this.$tDir$32817, this.$self_$32818.transform.forward, this.$self_$32818.LnOc5wWVuWX);
								if (207412 - 399399 != -191986)
								{
									goto Block_4;
								}
								continue;
							}
							else
							{
								this.$self_$32818.Fgqc5NKD8Cs = this.$self_$32818.Fgqc5NKD8Cs + 1;
								if (176857 - 504002 != -327145)
								{
									continue;
								}
								this.$self_$32818.StartCoroutine_Auto(this.$self_$32818.RPC_stunMine_create(this.$mPos$32816 + 0.5f * this.$tDir$32817, this.$self_$32818.transform.forward, this.$self_$32818.Fgqc5NKD8Cs));
								if (98611 - 364945 == -266333)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									goto IL_4A8;
								}
								if (35872 - 287239 == -251366)
								{
									continue;
								}
								this.$self_$32818.ActionEvent("RPC_stunMine_create", this.$mPos$32816 + 0.5f * this.$tDir$32817, this.$self_$32818.transform.forward, this.$self_$32818.Fgqc5NKD8Cs);
								if (7644 - 594006 != -586361)
								{
									goto Block_17;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$32818.MxUc5fNK3lS.actionState == "attack")
						{
							if (63945 - 74616 != -10671)
							{
								continue;
							}
							if (this.$self_$32818.MxUc5fNK3lS.myCommand == "mine")
							{
								if (116581 - 516674 == -400092)
								{
									continue;
								}
								this.$self_$32818.MxUc5fNK3lS.moveSpeed = (float)0;
								if (232189 - 281582 == -49392)
								{
									continue;
								}
								this.$self_$32818.MxUc5fNK3lS.actionState = "standby";
								if (36739 - 479600 == -442860)
								{
									continue;
								}
								this.$self_$32818.MxUc5fNK3lS.actionTime = Time.time;
								if (153372 - 193001 != -39629)
								{
									continue;
								}
								this.$self_$32818.MxUc5fNK3lS.myCommand = "none";
								if (233654 - 157885 != 75769)
								{
									continue;
								}
								if (!this.$self_$32818.MxUc5fNK3lS.isMine)
								{
									if (51622 - 599291 != -547669)
									{
										continue;
									}
									this.$self_$32818.MxUc5fNK3lS.nPosition = this.$self_$32818.transform.position;
									if (109585 - 59247 == 50339)
									{
										continue;
									}
									this.$self_$32818.MxUc5fNK3lS.oPosition = this.$self_$32818.transform.position;
									if (107997 - 63089 == 44909)
									{
										continue;
									}
									this.$self_$32818.MxUc5fNK3lS.nDirection = this.$self_$32818.transform.forward;
									if (208108 - 410958 == -202849)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (68658 - 136678 != -68020)
						{
							continue;
						}
						goto IL_857;
					default:
						if (143251 - 60983 != 82268)
						{
							continue;
						}
						break;
					}
					this.$self_$32818.MxUc5fNK3lS.actionState = "attack";
					if (256046 - 181261 == 74785)
					{
						this.$self_$32818.MxUc5fNK3lS.actionTime = Time.time;
						if (286621 - 521312 != -234690)
						{
							this.$self_$32818.MxUc5fNK3lS.myCommand = "mine";
							if (185497 - 454033 != -268535)
							{
								this.$self_$32818.MxUc5fNK3lS.addTimeOut("nAttack", (float)10);
								if (47989 - 538559 != -490569)
								{
									this.$self_$32818.transform.position = this.$mPos$32816;
									if (125817 - 523247 == -397430)
									{
										this.$self_$32818.transform.LookAt(this.$mPos$32816 + global::Math.vFlat(this.$tDir$32817));
										if (218222 - 139428 != 78795)
										{
											this.$self_$32818.animation.CrossFade("nAttack", 0.2f);
											if (36362 - 70758 == -34396)
											{
												this.$self_$32818.animation.wrapMode = WrapMode.Once;
												if (149523 - 216005 == -66482)
												{
													this.$self_$32818.MxUc5fNK3lS.vMovement = this.$self_$32818.transform.forward;
													if (137413 - 423018 == -285605)
													{
														this.$self_$32818.MxUc5fNK3lS.moveSpeed = (float)0;
														if (247031 - 425620 == -178589)
														{
															goto IL_6BE;
														}
													}
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
				Block_17:
				IL_4A8:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_526:
				goto IL_4A8;
				IL_6BE:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_781:
				IL_857:
				return false;
			}

			// Token: 0x06004ABB RID: 19131 RVA: 0x009411D8 File Offset: 0x0093F3D8
			internal static bool xGHwoP5qAgCOXu9v0kPF()
			{
				return true;
			}

			// Token: 0x06004ABC RID: 19132 RVA: 0x009411DC File Offset: 0x0093F3DC
			internal static bool ri3WXb5qlbonaiVpWf61()
			{
				return false;
			}

			// Token: 0x04005566 RID: 21862
			internal Vector3 $mPos$32816;

			// Token: 0x04005567 RID: 21863
			internal Vector3 $tDir$32817;

			// Token: 0x04005568 RID: 21864
			internal MiniMole $self_$32818;
		}
	}

	// Token: 0x02000CFF RID: 3327
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_mine_create$32822 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004ABD RID: 19133 RVA: 0x009411E0 File Offset: 0x0093F3E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_mine_create$32822(Vector3 mPos, int tID, MiniMole self_)
		{
			if (81429 - 538307 != -456878)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (7870 - 389262 != -381391)
				{
					base..ctor();
					if (127258 - 487837 != -360578)
					{
						this.$mPos$32828 = mPos;
						if (219026 - 52921 == 166105)
						{
							this.$tID$32829 = tID;
							if (127255 - 527841 == -400586)
							{
								this.$self_$32830 = self_;
								if (106334 - 330943 != -224608)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004ABE RID: 19134 RVA: 0x009412BC File Offset: 0x0093F4BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MiniMole.$RPC_mine_create$32822.$(this.$mPos$32828, this.$tID$32829, this.$self_$32830);
		}

		// Token: 0x06004ABF RID: 19135 RVA: 0x009412D8 File Offset: 0x0093F4D8
		internal static bool Nb9dlW5qyIh2k5awfV8O()
		{
			return true;
		}

		// Token: 0x06004AC0 RID: 19136 RVA: 0x009412DC File Offset: 0x0093F4DC
		internal static bool seTUKM5qStoF7VwvogIP()
		{
			return false;
		}

		// Token: 0x04005569 RID: 21865
		internal Vector3 $mPos$32828;

		// Token: 0x0400556A RID: 21866
		internal int $tID$32829;

		// Token: 0x0400556B RID: 21867
		internal MiniMole $self_$32830;

		// Token: 0x02000D00 RID: 3328
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004AC1 RID: 19137 RVA: 0x009412E0 File Offset: 0x0093F4E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, int tID, MiniMole self_)
			{
				if (202616 - 400667 != -198050)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (205845 - 118711 == 87134)
					{
						base..ctor();
						if (228519 - 190834 != 37686)
						{
							this.$mPos$32825 = mPos;
							if (64007 - 571562 != -507554)
							{
								this.$tID$32826 = tID;
								if (224587 - 299806 == -75219)
								{
									this.$self_$32827 = self_;
									if (167512 - 70870 != 96643)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004AC2 RID: 19138 RVA: 0x009413BC File Offset: 0x0093F5BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (252016 - 382888 != -130872)
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
						this.$mMineControl$32824 = (MiniMole_mine)this.$mMine$32823.GetComponent(typeof(MiniMole_mine));
						if (187319 - 21076 != 166243)
						{
							continue;
						}
						if (this.$mMineControl$32824)
						{
							if (51026 - 263686 == -212659)
							{
								continue;
							}
							this.$mMineControl$32824.Init(this.$tID$32826, this.$self_$32827.MxUc5fNK3lS.ActorNr);
							if (100374 - 94909 != 5465)
							{
								continue;
							}
						}
						if (this.$self_$32827.vQ5c5L9JfMM == null)
						{
							if (221118 - 489996 == -268877)
							{
								continue;
							}
							this.$self_$32827.vQ5c5L9JfMM = new UnityScript.Lang.Array();
							if (46698 - 65199 == -18500)
							{
								continue;
							}
						}
						this.$self_$32827.vQ5c5L9JfMM.Add(this.$mMine$32823);
						if (28220 - 576533 != -548312)
						{
							goto IL_1A8;
						}
						continue;
					default:
						if (49423 - 346475 == -297051)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32827.mine)
					{
						if (43049 - 244892 != -201843)
						{
							continue;
						}
						this.$mMine$32823 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$32827.mine, this.$mPos$32825, Quaternion.Euler((float)270, (float)90, (float)0));
						if (40146 - 541017 == -500870)
						{
							continue;
						}
						if (this.$mMine$32823)
						{
							if (295228 - 471581 != -176352)
							{
								break;
							}
							continue;
						}
					}
					else
					{
						Debug.LogError("Missing mine gameObject");
						if (10926 - 428007 == -417080)
						{
							continue;
						}
					}
					IL_1D1:
					this.YieldDefault(1);
					if (249872 - 176529 != 73343)
					{
						continue;
					}
					goto IL_273;
					IL_1A8:
					goto IL_1D1;
				}
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_273:
				return false;
			}

			// Token: 0x06004AC3 RID: 19139 RVA: 0x00941650 File Offset: 0x0093F850
			internal static bool QTUaB85qo5NV2d0CqhLT()
			{
				return true;
			}

			// Token: 0x06004AC4 RID: 19140 RVA: 0x00941654 File Offset: 0x0093F854
			internal static bool CgLaW15qEJpcjwkh74uQ()
			{
				return false;
			}

			// Token: 0x0400556C RID: 21868
			internal GameObject $mMine$32823;

			// Token: 0x0400556D RID: 21869
			internal MiniMole_mine $mMineControl$32824;

			// Token: 0x0400556E RID: 21870
			internal Vector3 $mPos$32825;

			// Token: 0x0400556F RID: 21871
			internal int $tID$32826;

			// Token: 0x04005570 RID: 21872
			internal MiniMole $self_$32827;
		}
	}

	// Token: 0x02000D01 RID: 3329
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_stunMine_create$32831 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004AC5 RID: 19141 RVA: 0x00941658 File Offset: 0x0093F858
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_stunMine_create$32831(Vector3 mPos, int tID, MiniMole self_)
		{
			if (210290 - 582622 != -372331)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (5105 - 83852 == -78747)
				{
					base..ctor();
					if (199939 - 278093 != -78153)
					{
						this.$mPos$32837 = mPos;
						if (2530 - 154938 != -152407)
						{
							this.$tID$32838 = tID;
							if (249066 - 339437 != -90370)
							{
								this.$self_$32839 = self_;
								if (212464 - 99730 != 112735)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004AC6 RID: 19142 RVA: 0x00941734 File Offset: 0x0093F934
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MiniMole.$RPC_stunMine_create$32831.$(this.$mPos$32837, this.$tID$32838, this.$self_$32839);
		}

		// Token: 0x06004AC7 RID: 19143 RVA: 0x00941750 File Offset: 0x0093F950
		internal static bool Mclwia5q2Bp676aMeFkk()
		{
			return true;
		}

		// Token: 0x06004AC8 RID: 19144 RVA: 0x00941754 File Offset: 0x0093F954
		internal static bool jUqbOr5q8t9uyqAhXV6V()
		{
			return false;
		}

		// Token: 0x04005571 RID: 21873
		internal Vector3 $mPos$32837;

		// Token: 0x04005572 RID: 21874
		internal int $tID$32838;

		// Token: 0x04005573 RID: 21875
		internal MiniMole $self_$32839;

		// Token: 0x02000D02 RID: 3330
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004AC9 RID: 19145 RVA: 0x00941758 File Offset: 0x0093F958
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, int tID, MiniMole self_)
			{
				if (19264 - 355298 != -336033)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (27656 - 311185 != -283528)
					{
						base..ctor();
						if (141195 - 375400 == -234205)
						{
							this.$mPos$32834 = mPos;
							if (266638 - 299666 != -33027)
							{
								this.$tID$32835 = tID;
								if (268849 - 164452 == 104397)
								{
									this.$self_$32836 = self_;
									if (80362 - 583901 == -503539)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004ACA RID: 19146 RVA: 0x00941834 File Offset: 0x0093FA34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (9456 - 536614 != -527158)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_1F4;
					case 1:
						goto IL_273;
					case 2:
						this.$mMineControl$32833 = (MiniMole_mine)this.$mStunMine$32832.GetComponent(typeof(MiniMole_mine));
						if (279082 - 387484 == -108401)
						{
							continue;
						}
						if (this.$mMineControl$32833)
						{
							if (168665 - 194986 != -26321)
							{
								continue;
							}
							this.$mMineControl$32833.Init(this.$tID$32835, this.$self_$32836.MxUc5fNK3lS.ActorNr);
							if (1918 - 530908 == -528989)
							{
								continue;
							}
						}
						if (this.$self_$32836.loDc5UI1Xgj == null)
						{
							if (214787 - 410252 == -195464)
							{
								continue;
							}
							this.$self_$32836.loDc5UI1Xgj = new UnityScript.Lang.Array();
							if (81066 - 440429 == -359362)
							{
								continue;
							}
						}
						this.$self_$32836.loDc5UI1Xgj.Add(this.$mStunMine$32832);
						if (207431 - 371289 == -163857)
						{
							continue;
						}
						break;
					default:
						if (141513 - 598306 != -456792)
						{
							goto IL_1F4;
						}
						continue;
					}
					IL_9E:
					this.YieldDefault(1);
					if (12357 - 384940 != -372583)
					{
						continue;
					}
					goto IL_273;
					IL_170:
					goto IL_9E;
					IL_1F4:
					if (this.$self_$32836.stunMine)
					{
						if (219439 - 492335 == -272896)
						{
							this.$mStunMine$32832 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$32836.stunMine, this.$mPos$32834, Quaternion.Euler((float)270, (float)90, (float)0));
							if (91532 - 595986 != -504453)
							{
								if (!this.$mStunMine$32832)
								{
									goto IL_170;
								}
								if (146954 - 562101 == -415147)
								{
									break;
								}
							}
						}
					}
					else
					{
						Debug.LogError("Missing stunMine gameObject");
						if (200979 - 24696 != 176284)
						{
							goto IL_9E;
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_273:
				return false;
			}

			// Token: 0x06004ACB RID: 19147 RVA: 0x00941AC8 File Offset: 0x0093FCC8
			internal static bool Ns31tA5qZ0L0CeaQgVxM()
			{
				return true;
			}

			// Token: 0x06004ACC RID: 19148 RVA: 0x00941ACC File Offset: 0x0093FCCC
			internal static bool rs8vxK5qCAhli6NQ6KQY()
			{
				return false;
			}

			// Token: 0x04005574 RID: 21876
			internal GameObject $mStunMine$32832;

			// Token: 0x04005575 RID: 21877
			internal MiniMole_mine $mMineControl$32833;

			// Token: 0x04005576 RID: 21878
			internal Vector3 $mPos$32834;

			// Token: 0x04005577 RID: 21879
			internal int $tID$32835;

			// Token: 0x04005578 RID: 21880
			internal MiniMole $self_$32836;
		}
	}

	// Token: 0x02000D03 RID: 3331
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$32840 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004ACD RID: 19149 RVA: 0x00941AD0 File Offset: 0x0093FCD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$32840(UnityScript.Lang.Array nArray, MiniMole self_)
		{
			if (67088 - 529916 != -462828)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (139353 - 418907 != -279553)
				{
					base..ctor();
					if (12221 - 109194 == -96973)
					{
						this.$nArray$32845 = nArray;
						if (85459 - 107785 != -22325)
						{
							this.$self_$32846 = self_;
							if (294758 - 499631 == -204873)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004ACE RID: 19150 RVA: 0x00941B8C File Offset: 0x0093FD8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MiniMole.$RPC_ko$32840.$(this.$nArray$32845, this.$self_$32846);
		}

		// Token: 0x06004ACF RID: 19151 RVA: 0x00941BA0 File Offset: 0x0093FDA0
		internal static bool tt5CLB5qLpbmxpsj014k()
		{
			return true;
		}

		// Token: 0x06004AD0 RID: 19152 RVA: 0x00941BA4 File Offset: 0x0093FDA4
		internal static bool cxkoke5qO35qrOUXwsLe()
		{
			return false;
		}

		// Token: 0x04005579 RID: 21881
		internal UnityScript.Lang.Array $nArray$32845;

		// Token: 0x0400557A RID: 21882
		internal MiniMole $self_$32846;

		// Token: 0x02000D04 RID: 3332
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004AD1 RID: 19153 RVA: 0x00941BA8 File Offset: 0x0093FDA8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, MiniMole self_)
			{
				if (242053 - 116737 != 125317)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (41671 - 315280 != -273608)
					{
						base..ctor();
						if (186858 - 466966 == -280108)
						{
							this.$nArray$32843 = nArray;
							if (244701 - 489091 != -244389)
							{
								this.$self_$32844 = self_;
								if (29995 - 429354 == -399359)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004AD2 RID: 19154 RVA: 0x00941C64 File Offset: 0x0093FE64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (205994 - 160669 != 45326)
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
						if (this.$self_$32844.MxUc5fNK3lS.actionState != "ko")
						{
							if (288920 - 412726 != -123805)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							this.$self_$32844.animation.Play("getUp");
							if (130757 - 463771 != -333014)
							{
								continue;
							}
							this.$self_$32844.animation.wrapMode = WrapMode.Once;
							if (173212 - 221183 != -47971)
							{
								continue;
							}
							goto IL_49;
						}
						break;
					case 3:
						if (this.$self_$32844.MxUc5fNK3lS.actionState != "ko")
						{
							if (148457 - 361874 != -213417)
							{
								continue;
							}
							goto IL_98;
						}
						else
						{
							this.$self_$32844.MxUc5fNK3lS.actionState = "standby";
							if (76737 - 167199 == -90461)
							{
								continue;
							}
							this.$self_$32844.MxUc5fNK3lS.actionTime = Time.time;
							if (236915 - 203360 != 33555)
							{
								continue;
							}
							this.$self_$32844.MxUc5fNK3lS.myCommand = "none";
							if (107375 - 467463 != -360088)
							{
								continue;
							}
							this.$self_$32844.MxUc5fNK3lS.ko = this.$self_$32844.MxUc5fNK3lS.mko;
							if (218997 - 531494 != -312497)
							{
								continue;
							}
							this.YieldDefault(1);
							if (250086 - 249501 != 585)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (248513 - 136914 == 111600)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32844.MxUc5fNK3lS.actionState == "ko")
					{
						goto IL_164;
					}
					if (92689 - 70420 != 22270)
					{
						if (this.$self_$32844.MxUc5fNK3lS.actionState == "dead")
						{
							if (154999 - 20424 != 134576)
							{
								goto Block_18;
							}
						}
						else
						{
							this.$mPos$32841 = (Vector3)this.$nArray$32843[0];
							if (224682 - 61179 != 163504)
							{
								this.$mDir$32842 = (Vector3)this.$nArray$32843[1];
								if (123753 - 7712 == 116041)
								{
									this.$self_$32844.MxUc5fNK3lS.ko = 0;
									if (14741 - 427891 == -413150)
									{
										this.$self_$32844.MxUc5fNK3lS.actionState = "ko";
										if (124541 - 462061 == -337520)
										{
											this.$self_$32844.MxUc5fNK3lS.actionTime = Time.time;
											if (151606 - 521021 == -369415)
											{
												this.$self_$32844.MxUc5fNK3lS.myCommand = "none";
												if (191478 - 499032 != -307553)
												{
													this.$self_$32844.MxUc5fNK3lS.vMovement = Vector3.zero;
													if (267068 - 246025 != 21044)
													{
														this.$self_$32844.MxUc5fNK3lS.moveSpeed = (float)0;
														if (3282 - 491084 == -487802)
														{
															this.$self_$32844.animation.Play("ko");
															if (292722 - 342652 != -49929)
															{
																this.$self_$32844.animation.wrapMode = WrapMode.Once;
																if (211515 - 67500 != 144016)
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
				IL_49:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_98:
				IL_164:
				goto IL_48C;
				Block_14:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_18:
				Block_27:
				IL_48C:
				return false;
			}

			// Token: 0x06004AD3 RID: 19155 RVA: 0x00942110 File Offset: 0x00940310
			internal static bool AoBIZg5qm7SYsoUyY1tr()
			{
				return true;
			}

			// Token: 0x06004AD4 RID: 19156 RVA: 0x00942114 File Offset: 0x00940314
			internal static bool CKsPDF5qF4ANOhkUsdJl()
			{
				return false;
			}

			// Token: 0x0400557B RID: 21883
			internal Vector3 $mPos$32841;

			// Token: 0x0400557C RID: 21884
			internal Vector3 $mDir$32842;

			// Token: 0x0400557D RID: 21885
			internal UnityScript.Lang.Array $nArray$32843;

			// Token: 0x0400557E RID: 21886
			internal MiniMole $self_$32844;
		}
	}

	// Token: 0x02000D05 RID: 3333
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$32847 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004AD5 RID: 19157 RVA: 0x00942118 File Offset: 0x00940318
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$32847(UnityScript.Lang.Array nArray, MiniMole self_)
		{
			if (92781 - 151245 != -58464)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (279183 - 455661 != -176477)
				{
					base..ctor();
					if (107935 - 202299 == -94364)
					{
						this.$nArray$32852 = nArray;
						if (35299 - 348294 == -312995)
						{
							this.$self_$32853 = self_;
							if (98644 - 416625 != -317980)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004AD6 RID: 19158 RVA: 0x009421D4 File Offset: 0x009403D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MiniMole.$RPC_dead$32847.$(this.$nArray$32852, this.$self_$32853);
		}

		// Token: 0x06004AD7 RID: 19159 RVA: 0x009421E8 File Offset: 0x009403E8
		internal static bool qXjQuo5qMghlBapqSrXT()
		{
			return true;
		}

		// Token: 0x06004AD8 RID: 19160 RVA: 0x009421EC File Offset: 0x009403EC
		internal static bool cG20QH5qxKxlKED084AR()
		{
			return false;
		}

		// Token: 0x0400557F RID: 21887
		internal UnityScript.Lang.Array $nArray$32852;

		// Token: 0x04005580 RID: 21888
		internal MiniMole $self_$32853;

		// Token: 0x02000D06 RID: 3334
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004AD9 RID: 19161 RVA: 0x009421F0 File Offset: 0x009403F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, MiniMole self_)
			{
				if (176143 - 131078 != 45066)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (113839 - 337208 != -223368)
					{
						base..ctor();
						if (18335 - 174791 == -156456)
						{
							this.$nArray$32850 = nArray;
							if (260873 - 589406 == -328533)
							{
								this.$self_$32851 = self_;
								if (72838 - 9837 != 63002)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004ADA RID: 19162 RVA: 0x009422AC File Offset: 0x009404AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (52637 - 378800 != -326162)
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
						if (this.$self_$32851.MxUc5fNK3lS.actionState != "dead")
						{
							if (188759 - 89389 != 99370)
							{
								continue;
							}
							goto IL_1D1;
						}
						else
						{
							if (!this.$self_$32851.MxUc5fNK3lS.isPlayer)
							{
								if (137950 - 182758 == -44807)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$32851.gameObject);
								if (127151 - 385887 == -258735)
								{
									continue;
								}
							}
							else if (this.$self_$32851.MxUc5fNK3lS.isMine)
							{
								if (235645 - 384174 == -148528)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$32851.gameObject);
								if (60170 - 204225 == -144054)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (227098 - 113972 != 113126)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (7607 - 294954 == -287346)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32851.MxUc5fNK3lS.actionState == "dead")
					{
						if (40465 - 473459 != -432993)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$32848 = (Vector3)this.$nArray$32850[0];
						if (261511 - 456566 != -195054)
						{
							this.$myDirection$32849 = (Vector3)this.$nArray$32850[1];
							if (165265 - 42234 != 123032)
							{
								this.$self_$32851.transform.position = this.$myPosition$32848;
								if (81504 - 594537 == -513033)
								{
									this.$self_$32851.transform.LookAt(this.$myPosition$32848 + this.$myDirection$32849);
									if (212898 - 355658 == -142760)
									{
										this.$self_$32851.MxUc5fNK3lS.hp = 0;
										if (110285 - 321725 != -211439)
										{
											this.$self_$32851.MxUc5fNK3lS.actionState = "dead";
											if (158502 - 132740 == 25762)
											{
												this.$self_$32851.MxUc5fNK3lS.actionTime = Time.time;
												if (176887 - 65298 == 111589)
												{
													this.$self_$32851.MxUc5fNK3lS.myCommand = "none";
													if (181244 - 300614 != -119369)
													{
														this.$self_$32851.MxUc5fNK3lS.vMovement = Vector3.zero;
														if (229742 - 51124 != 178619)
														{
															this.$self_$32851.MxUc5fNK3lS.moveSpeed = (float)0;
															if (41310 - 318133 == -276823)
															{
																this.$self_$32851.animation.Rewind();
																if (110308 - 298280 != -187971)
																{
																	this.$self_$32851.animation.Play("ko");
																	if (43042 - 267017 != -223974)
																	{
																		this.$self_$32851.animation.wrapMode = WrapMode.Once;
																		if (104570 - 401580 != -297009)
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
					}
				}
				goto IL_42F;
				Block_9:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_1D1:
				IL_42F:
				return false;
			}

			// Token: 0x06004ADB RID: 19163 RVA: 0x009426FC File Offset: 0x009408FC
			internal static bool umrsGF5qglu41PIZ8jlW()
			{
				return true;
			}

			// Token: 0x06004ADC RID: 19164 RVA: 0x00942700 File Offset: 0x00940900
			internal static bool BVxkNU5qff5E0e8wACo2()
			{
				return false;
			}

			// Token: 0x04005581 RID: 21889
			internal Vector3 $myPosition$32848;

			// Token: 0x04005582 RID: 21890
			internal Vector3 $myDirection$32849;

			// Token: 0x04005583 RID: 21891
			internal UnityScript.Lang.Array $nArray$32850;

			// Token: 0x04005584 RID: 21892
			internal MiniMole $self_$32851;
		}
	}
}
