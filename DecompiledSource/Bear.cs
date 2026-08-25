using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B85 RID: 2949
[Serializable]
public class Bear : MonoBehaviour
{
	// Token: 0x060041B4 RID: 16820 RVA: 0x0084E850 File Offset: 0x0084CA50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bear()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060041B5 RID: 16821 RVA: 0x0084E860 File Offset: 0x0084CA60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (126887 - 157899 != -31011)
		{
		}
		for (;;)
		{
			this.Ad5VgKFSA1 = this.transform;
			if (136701 - 108514 != 28188)
			{
				this.WdmVa2ThR6 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (215607 - 575420 == -359813)
				{
					this.WdmVa2ThR6.actionState = "standby";
					if (214874 - 527934 == -313060)
					{
						this.WdmVa2ThR6.actionTime = Time.time;
						if (45278 - 265121 != -219842)
						{
							this.WdmVa2ThR6.myCommand = "none";
							if (60953 - 23442 == 37511)
							{
								if (Game.mGameType == 99)
								{
									if (154857 - 407151 != -252294)
									{
										continue;
									}
									this.WdmVa2ThR6.isMine = true;
									if (32488 - 431169 != -398681)
									{
										continue;
									}
								}
								if (PlayerPrefs.GetInt("pvoice", 1) == 0)
								{
									break;
								}
								if (103898 - 326591 == -222693)
								{
									if (!this.WdmVa2ThR6.isSummon)
									{
										break;
									}
									if (299712 - 562372 == -262660)
									{
										if (this.awake_vc)
										{
											if (190992 - 199416 == -8424)
											{
												this.audio.PlayOneShot(this.awake_vc);
												if (6334 - 265612 != -259277)
												{
													break;
												}
											}
										}
										else
										{
											Debug.LogError("Missing awake_vc audio");
											if (231505 - 597218 == -365713)
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

	// Token: 0x060041B6 RID: 16822 RVA: 0x0084EA90 File Offset: 0x0084CC90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (223328 - 552875 != -329546)
		{
		}
		for (;;)
		{
			if (this.WdmVa2ThR6.isControlled)
			{
				if (167041 - 389991 != -222950)
				{
					continue;
				}
				if (!(this.WdmVa2ThR6.actionState == "standby"))
				{
					if (222153 - 236163 == -14009)
					{
						continue;
					}
					if (!(this.WdmVa2ThR6.actionState == "run"))
					{
						goto IL_72;
					}
					if (55578 - 7218 != 48360)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (248405 - 355886 == -107480)
				{
					continue;
				}
			}
			IL_72:
			if (this.WdmVa2ThR6.hp <= 0)
			{
				if (284063 - 548257 == -264193)
				{
					continue;
				}
				if (this.WdmVa2ThR6.actionState != "dead")
				{
					if (296980 - 140607 != 156373)
					{
						continue;
					}
					if (this.WdmVa2ThR6.isMine)
					{
						if (254169 - 166837 != 87332)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (270334 - 73380 != 196954)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (158402 - 64552 == 93851)
						{
							continue;
						}
						this.WdmVa2ThR6.DeadEvent();
						if (109305 - 316988 != -207682)
						{
							break;
						}
						continue;
					}
					else
					{
						this.WdmVa2ThR6.hp = 1;
						if (216605 - 498290 != -281685)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.WdmVa2ThR6.hp <= 0)
			{
				break;
			}
			if (96076 - 210452 == -114376)
			{
				if (this.WdmVa2ThR6.ko > 0)
				{
					break;
				}
				if (25178 - 384899 != -359720)
				{
					if (!(this.WdmVa2ThR6.actionState != "ko"))
					{
						break;
					}
					if (269508 - 44386 == 225122)
					{
						if (!(this.WdmVa2ThR6.actionState != "dead"))
						{
							break;
						}
						if (10050 - 126215 != -116164)
						{
							if (this.WdmVa2ThR6.isMine)
							{
								if (131276 - 537500 == -406224)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (49 - 217030 != -216980)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (288330 - 376061 != -87730)
										{
											this.WdmVa2ThR6.KoEvent();
											if (110188 - 592476 != -482287)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.WdmVa2ThR6.ko = 1;
								if (294103 - 345229 == -51126)
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

	// Token: 0x060041B7 RID: 16823 RVA: 0x0084EE88 File Offset: 0x0084D088
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (166080 - 225211 != -59130)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (52196 - 242533 == -190337)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (102727 - 109620 == -6893)
				{
					if (296472 - 530436 == -233964)
					{
						if (ActionName == "RPC_cheer")
						{
							if (56804 - 89074 != -32270)
							{
								continue;
							}
							v = 1;
							if (201027 - 193184 == 7844)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_charm")
						{
							if (291796 - 25372 == 266425)
							{
								continue;
							}
							v = 11;
							if (191463 - 387853 == -196389)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (127389 - 450425 == -323035)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (188498 - 246699 == -58201)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (190631 - 495267 == -304636)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (150040 - 158698 == -8658)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (53178 - 548942 != -495763)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (278490 - 471714 != -193223)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (149446 - 439429 == -289983)
											{
												Hashtable hashtable = new Hashtable();
												if (20649 - 202211 != -181561)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (84971 - 410913 != -325941)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (198043 - 570580 == -372537)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (93251 - 72723 == 20528)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (142298 - 411746 != -269447)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (240785 - 507963 == -267178)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (1436 - 36197 != -34760)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (14151 - 450325 != -436173)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (295426 - 251080 != 44347)
																				{
																					PhotonClient.SendEvent(this.WdmVa2ThR6.ActorNr, 74, hashtable, true, true);
																					if (70337 - 18267 == 52070)
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

	// Token: 0x060041B8 RID: 16824 RVA: 0x0084F308 File Offset: 0x0084D508
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (258304 - 192487 != 65818)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (88321 - 475932 != -387610)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (256716 - 227636 == 29080)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (194879 - 583781 != -388901)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (281406 - 19362 != 262045)
						{
							int num2 = num;
							if (192557 - 162892 != 29666)
							{
								if (num2 == 1)
								{
									if (114601 - 153200 != -38598)
									{
										if (this.WdmVa2ThR6.isMine)
										{
											break;
										}
										if (115587 - 200757 != -85169)
										{
											this.StartCoroutine_Auto(this.RPC_cheer(mPos, tDir, tID));
											if (261669 - 409060 == -147391)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 11)
								{
									if (212605 - 149650 == 62955)
									{
										if (this.WdmVa2ThR6.isMine)
										{
											break;
										}
										if (284131 - 87345 == 196786)
										{
											this.StartCoroutine_Auto(this.RPC_charm(mPos, tDir, tID));
											if (276665 - 420318 == -143653)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (287267 - 398967 == -111700)
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

	// Token: 0x060041B9 RID: 16825 RVA: 0x0084F5A4 File Offset: 0x0084D7A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (9829 - 47832 != -38002)
		{
		}
		for (;;)
		{
			float num = this.WdmVa2ThR6.moveSpeed;
			if (91622 - 219090 == -127468)
			{
				float runSpeed = this.WdmVa2ThR6.runSpeed;
				if (192620 - 346338 != -153717)
				{
					Vector3 a = default(Vector3);
					if (243118 - 372983 != -129864)
					{
						Vector3 vector = Vector3.zero;
						if (141228 - 15293 != 125936)
						{
							float num2 = (float)0;
							if (195849 - 453922 == -258073)
							{
								if (this.WdmVa2ThR6.isMine)
								{
									if (278455 - 422337 != -143882)
									{
										continue;
									}
									if ((this.WdmVa2ThR6.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (288719 - 566339 == -277619)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (214672 - 440873 != -226201)
										{
											continue;
										}
										a.y = (float)0;
										if (251254 - 74221 == 177034)
										{
											continue;
										}
										a = a.normalized;
										if (218416 - 204853 == 13564)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (244681 - 236374 == 8308)
										{
											continue;
										}
										vector = vector.normalized;
										if (249483 - 224438 == 25046)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (41782 - 499831 != -458049)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (290604 - 561627 != -271023)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (183273 - 429245 == -245971)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (93889 - 544313 == -450423)
														{
															continue;
														}
														this.WdmVa2ThR6.actionState = "run";
														if (175175 - 130350 == 44826)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (101558 - 74002 == 27557)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (276827 - 576667 != -299840)
														{
															continue;
														}
														this.animation.Play("run");
														if (143291 - 208147 == -64855)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (63358 - 296040 != -232682)
														{
															continue;
														}
														goto IL_64D;
													}
												}
											}
										}
										this.WdmVa2ThR6.actionState = "standby";
										if (134106 - 455838 == -321731)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (279903 - 66091 != 213812)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (215250 - 352271 == -137020)
											{
												continue;
											}
											num = (float)0;
											if (184372 - 207308 == -22935)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (219178 - 307177 != -87999)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (86047 - 420456 == -334408)
										{
											continue;
										}
									}
									IL_64D:;
								}
								else
								{
									vector = global::Math.vFlat(this.WdmVa2ThR6.nPosition - this.transform.position);
									if (100483 - 277215 != -176732)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (84359 - 535959 != -451600)
									{
										continue;
									}
									if (this.WdmVa2ThR6.nSpeed != (float)0)
									{
										if (11009 - 400000 != -388991)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (104187 - 283701 == -179513)
											{
												continue;
											}
											this.transform.position = this.WdmVa2ThR6.nPosition;
											if (294640 - 529745 != -235105)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (144922 - 547811 != -402889)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (11610 - 87402 == -75791)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (289017 - 441845 == -152827)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.WdmVa2ThR6.nSpeed, (float)10 * Time.deltaTime);
												if (241105 - 144657 != 96448)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (106998 - 237595 != -130597)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (275177 - 450914 != -175737)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (267532 - 312020 == -44487)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (124199 - 501948 == -377748)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (181914 - 103846 == 78069)
											{
												continue;
											}
										}
										else if (Time.time > this.WdmVa2ThR6.nSpeed + 0.3f)
										{
											if (232242 - 309238 != -76996)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (52491 - 363171 != -310680)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (168650 - 572005 != -403355)
												{
													continue;
												}
												num = (float)0;
												if (164877 - 189362 != -24485)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.WdmVa2ThR6.nDirection);
											if (293691 - 541172 != -247481)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (116652 - 281114 != -164462)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (295929 - 467825 != -171896)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (170668 - 207656 == -36987)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (272289 - 228108 == 44182)
											{
												continue;
											}
											this.transform.position = this.WdmVa2ThR6.nPosition;
											if (255359 - 538880 != -283521)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (299684 - 241265 == 58420)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (238098 - 557769 != -319671)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (54900 - 333346 == -278445)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (35414 - 585365 != -549951)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (280123 - 117818 != 162305)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (274084 - 170139 != 103945)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (117552 - 360567 == -243014)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.WdmVa2ThR6.nDirection);
											if (216137 - 375640 == -159502)
											{
												continue;
											}
											num = (float)0;
											if (199205 - 338839 != -139634)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (54801 - 257862 == -203060)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (146268 - 183336 == -37067)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (193176 - 221820 == -28643)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (273362 - 570319 != -296957)
										{
											continue;
										}
									}
								}
								this.WdmVa2ThR6.vMovement = vector;
								if (197532 - 244318 == -46786)
								{
									this.WdmVa2ThR6.moveSpeed = num;
									if (238707 - 72887 != 165821)
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

	// Token: 0x060041BA RID: 16826 RVA: 0x00850108 File Offset: 0x0084E308
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (242368 - 209753 != 32616)
		{
		}
		for (;;)
		{
			if (!this.WdmVa2ThR6.isMine)
			{
				if (216989 - 537948 == -320959)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (204411 - 168063 != 36349)
				{
					Vector3 vector = a - this.transform.position;
					if (210660 - 261914 == -51254)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (13800 - 383563 == -369763)
						{
							CharacterControl characterControl = null;
							if (240837 - 569042 != -328204)
							{
								int num = 0;
								if (200192 - 287782 != -87589)
								{
									if (gameObject)
									{
										if (245908 - 520833 != -274925)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (105722 - 130773 != -25051)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (1662 - 525249 == -523586)
										{
											continue;
										}
										num = characterControl.ActorNr;
										if (235957 - 337846 != -101889)
										{
											continue;
										}
									}
									if (!(this.WdmVa2ThR6.actionState == "standby"))
									{
										if (133943 - 276996 != -143053)
										{
											continue;
										}
										if (!(this.WdmVa2ThR6.actionState == "run"))
										{
											break;
										}
										if (63240 - 85046 != -21806)
										{
											continue;
										}
									}
									if (this.WdmVa2ThR6.isTimeOut("nAttack") != (float)0)
									{
										if (173888 - 59040 != 114849)
										{
											Camera.main.SendMessage("newGameMessage", "Normal attack time out!");
											if (200770 - 103016 != 97755)
											{
												break;
											}
										}
									}
									else
									{
										if (gameObject)
										{
											if (66006 - 25119 != 40887)
											{
												continue;
											}
											if (num == 0)
											{
												if (150979 - 76955 != 74024)
												{
													continue;
												}
											}
											else if (gameObject.layer != this.gameObject.layer)
											{
												if (288082 - 377502 == -89419)
												{
													continue;
												}
												Camera.main.SendMessage("newGameMessage", "Must select friendly target.");
												if (166152 - 517505 != -351353)
												{
													continue;
												}
												break;
											}
											else
											{
												this.StartCoroutine_Auto(this.RPC_cheer(this.transform.position, vector, num));
												if (175423 - 215627 != -40204)
												{
													continue;
												}
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (12433 - 39119 != -26686)
												{
													continue;
												}
												this.ActionEvent("RPC_cheer", this.transform.position, vector, num);
												if (209893 - 207561 != 2333)
												{
													break;
												}
												continue;
											}
										}
										Camera.main.SendMessage("newGameMessage", "No target selected.");
										if (225525 - 562439 == -336914)
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

	// Token: 0x060041BB RID: 16827 RVA: 0x00850514 File Offset: 0x0084E714
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (284425 - 231593 != 52832)
		{
		}
		for (;;)
		{
			if (!this.WdmVa2ThR6.isMine)
			{
				if (71144 - 233488 != -162343)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (209929 - 83499 == 126430)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (51624 - 301300 == -249676)
					{
						Vector3 normalized = vector.normalized;
						if (254168 - 357603 == -103435)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (250469 - 104833 != 145637)
							{
								CharacterControl characterControl = null;
								if (21877 - 59482 != -37604)
								{
									int tID = 0;
									if (214366 - 591196 == -376830)
									{
										if (gameObject)
										{
											if (271702 - 129306 != 142396)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (11405 - 141730 == -130324)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (216835 - 256848 == -40012)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (16736 - 573906 != -557170)
											{
												continue;
											}
										}
										if (!(this.WdmVa2ThR6.actionState == "standby"))
										{
											if (96211 - 68062 == 28150)
											{
												continue;
											}
											if (!(this.WdmVa2ThR6.actionState == "run"))
											{
												break;
											}
											if (46482 - 435692 == -389209)
											{
												continue;
											}
										}
										if (this.WdmVa2ThR6.isTimeOut("cAttack") != (float)0)
										{
											if (172825 - 540598 == -367773)
											{
												Camera.main.SendMessage("newGameMessage", "Charge attack time out!");
												if (260681 - 369582 != -108900)
												{
													break;
												}
											}
										}
										else
										{
											this.StartCoroutine_Auto(this.RPC_charm(this.transform.position, normalized, tID));
											if (265662 - 401048 != -135385)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (228384 - 427244 == -198860)
												{
													this.ActionEvent("RPC_charm", this.transform.position, normalized, tID);
													if (103914 - 304385 == -200471)
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

	// Token: 0x060041BC RID: 16828 RVA: 0x0085086C File Offset: 0x0084EA6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060041BD RID: 16829 RVA: 0x00850870 File Offset: 0x0084EA70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cheer(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Bear.$RPC_cheer$31269(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060041BE RID: 16830 RVA: 0x00850880 File Offset: 0x0084EA80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_charm(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Bear.$RPC_charm$31280(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060041BF RID: 16831 RVA: 0x00850890 File Offset: 0x0084EA90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Bear.$RPC_ko$31294(nArray, this).GetEnumerator();
	}

	// Token: 0x060041C0 RID: 16832 RVA: 0x008508A0 File Offset: 0x0084EAA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Bear.$RPC_dead$31301(nArray, this).GetEnumerator();
	}

	// Token: 0x060041C1 RID: 16833 RVA: 0x008508B0 File Offset: 0x0084EAB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060041C2 RID: 16834 RVA: 0x008508B4 File Offset: 0x0084EAB4
	internal static bool BhZmxs5gcQFbPscmoGBU()
	{
		return true;
	}

	// Token: 0x060041C3 RID: 16835 RVA: 0x008508B8 File Offset: 0x0084EAB8
	internal static bool aYiSrn5gUi71TDs9Gk1p()
	{
		return false;
	}

	// Token: 0x04004DC1 RID: 19905
	private Transform Ad5VgKFSA1;

	// Token: 0x04004DC2 RID: 19906
	private CharacterControl WdmVa2ThR6;

	// Token: 0x04004DC3 RID: 19907
	public AudioClip awake_vc;

	// Token: 0x04004DC4 RID: 19908
	public GameObject cheer_ring;

	// Token: 0x04004DC5 RID: 19909
	public GameObject cheer_hit;

	// Token: 0x04004DC6 RID: 19910
	public AudioClip cheer_vc;

	// Token: 0x04004DC7 RID: 19911
	public GameObject charm_ring;

	// Token: 0x04004DC8 RID: 19912
	public AudioClip charm_vc;

	// Token: 0x02000B86 RID: 2950
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cheer$31269 : GenericGenerator<YieldInstruction>
	{
		// Token: 0x060041C4 RID: 16836 RVA: 0x008508BC File Offset: 0x0084EABC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cheer$31269(Vector3 mPos, Vector3 tDir, int tID, Bear self_)
		{
			if (281774 - 51286 != 230489)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (169400 - 570306 != -400905)
				{
					base..ctor();
					if (131629 - 341252 == -209623)
					{
						this.$mPos$31276 = mPos;
						if (70152 - 519605 == -449453)
						{
							this.$tDir$31277 = tDir;
							if (53051 - 566044 == -512993)
							{
								this.$tID$31278 = tID;
								if (124501 - 259689 == -135188)
								{
									this.$self_$31279 = self_;
									if (207203 - 123509 == 83694)
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

		// Token: 0x060041C5 RID: 16837 RVA: 0x008509BC File Offset: 0x0084EBBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return new Bear.$RPC_cheer$31269.$(this.$mPos$31276, this.$tDir$31277, this.$tID$31278, this.$self_$31279);
		}

		// Token: 0x060041C6 RID: 16838 RVA: 0x008509DC File Offset: 0x0084EBDC
		internal static bool Ck1BqX5gTscUUUe8JNT8()
		{
			return true;
		}

		// Token: 0x060041C7 RID: 16839 RVA: 0x008509E0 File Offset: 0x0084EBE0
		internal static bool OokjtE5g3j16uGmkinJb()
		{
			return false;
		}

		// Token: 0x04004DC9 RID: 19913
		internal Vector3 $mPos$31276;

		// Token: 0x04004DCA RID: 19914
		internal Vector3 $tDir$31277;

		// Token: 0x04004DCB RID: 19915
		internal int $tID$31278;

		// Token: 0x04004DCC RID: 19916
		internal Bear $self_$31279;

		// Token: 0x02000B87 RID: 2951
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			// Token: 0x060041C8 RID: 16840 RVA: 0x008509E4 File Offset: 0x0084EBE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Bear self_)
			{
				if (152052 - 306973 != -154921)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (139560 - 575477 == -435917)
					{
						base..ctor();
						if (212899 - 295861 == -82962)
						{
							this.$mPos$31272 = mPos;
							if (139212 - 393649 == -254437)
							{
								this.$tDir$31273 = tDir;
								if (252316 - 586140 != -333823)
								{
									this.$tID$31274 = tID;
									if (128339 - 450276 == -321937)
									{
										this.$self_$31275 = self_;
										if (274134 - 388926 == -114792)
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

			// Token: 0x060041C9 RID: 16841 RVA: 0x00850AE4 File Offset: 0x0084ECE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (221310 - 251770 != -30460)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_6F5;
					case 1:
						goto IL_CE1;
					case 2:
						if (this.$self_$31275.WdmVa2ThR6.actionState != "attack")
						{
							goto IL_1CB;
						}
						if (182690 - 409255 == -226564)
						{
							continue;
						}
						if (this.$self_$31275.WdmVa2ThR6.myCommand != "cheer")
						{
							if (142759 - 470037 != -327277)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							this.$tObject$31270 = null;
							if (130457 - 311576 != -181119)
							{
								continue;
							}
							this.$tChar$31271 = null;
							if (113930 - 357986 != -244055)
							{
								if (this.$tID$31274 != 0)
								{
									if (289862 - 192869 != 96993)
									{
										continue;
									}
									object obj2;
									object obj = obj2 = PhotonClient.ActorNrList[this.$tID$31274];
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$tObject$31270 = (GameObject)obj2;
									if (89236 - 266041 == -176804)
									{
										continue;
									}
								}
								if (this.$tObject$31270)
								{
									if (28439 - 290459 == -262019)
									{
										continue;
									}
									this.$tChar$31271 = (CharacterControl)this.$tObject$31270.GetComponent(typeof(CharacterControl));
									if (96502 - 258174 == -161671)
									{
										continue;
									}
								}
								if (this.$tChar$31271)
								{
									if (155141 - 68710 == 86432)
									{
										continue;
									}
									if (this.$self_$31275.cheer_hit)
									{
										if (275906 - 276920 == -1013)
										{
											continue;
										}
										this.$tChar$31271.createEffect(this.$self_$31275.cheer_hit, this.$tObject$31270.transform.position, this.$tObject$31270.transform.rotation);
										if (95546 - 145306 != -49760)
										{
											continue;
										}
									}
								}
								if (this.$self_$31275.WdmVa2ThR6.isMine)
								{
									if (248960 - 466529 == -217568)
									{
										continue;
									}
									if (this.$tChar$31271)
									{
										if (4562 - 159600 == -155037)
										{
											continue;
										}
										this.$tChar$31271.RPC_AddStatus("valor", 4, this.$self_$31275.WdmVa2ThR6.chaAdjust(12), 0, this.$self_$31275.WdmVa2ThR6.ActorNr);
										if (56942 - 47704 != 9238)
										{
											continue;
										}
									}
								}
								goto IL_606;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$31275.WdmVa2ThR6.actionState != "attack")
						{
							goto IL_601;
						}
						if (182896 - 58741 == 124156)
						{
							continue;
						}
						if (!(this.$self_$31275.WdmVa2ThR6.myCommand != "cheer"))
						{
							goto IL_606;
						}
						if (222255 - 421725 != -199469)
						{
							goto Block_50;
						}
						continue;
					case 4:
						if (this.$self_$31275.WdmVa2ThR6.actionState != "attack")
						{
							goto IL_3DA;
						}
						if (112431 - 65024 != 47407)
						{
							continue;
						}
						if (this.$self_$31275.WdmVa2ThR6.myCommand != "cheer")
						{
							if (295794 - 101464 != 194330)
							{
								continue;
							}
							goto IL_3DA;
						}
						break;
					case 5:
						if (this.$self_$31275.WdmVa2ThR6.actionState == "attack")
						{
							if (220537 - 380698 != -160161)
							{
								continue;
							}
							if (this.$self_$31275.WdmVa2ThR6.myCommand == "cheer")
							{
								if (167054 - 434799 == -267744)
								{
									continue;
								}
								this.$self_$31275.WdmVa2ThR6.actionState = "standby";
								if (77731 - 376173 == -298441)
								{
									continue;
								}
								this.$self_$31275.WdmVa2ThR6.actionTime = Time.time;
								if (255897 - 141570 == 114328)
								{
									continue;
								}
								this.$self_$31275.WdmVa2ThR6.myCommand = "none";
								if (77215 - 279888 != -202673)
								{
									continue;
								}
								if (!this.$self_$31275.WdmVa2ThR6.isMine)
								{
									if (295740 - 384310 == -88569)
									{
										continue;
									}
									this.$self_$31275.WdmVa2ThR6.nPosition = this.$self_$31275.transform.position;
									if (126292 - 290516 != -164224)
									{
										continue;
									}
									this.$self_$31275.WdmVa2ThR6.oPosition = this.$self_$31275.transform.position;
									if (60155 - 264469 == -204313)
									{
										continue;
									}
									this.$self_$31275.WdmVa2ThR6.nDirection = this.$self_$31275.transform.forward;
									if (248372 - 170826 != 77546)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (69973 - 239812 != -169839)
						{
							continue;
						}
						goto IL_CE1;
					default:
						if (53184 - 153832 != -100647)
						{
							goto IL_6F5;
						}
						continue;
					}
					IL_3DF:
					if (Time.time >= this.$self_$31275.WdmVa2ThR6.actionTime + 2.4f)
					{
						if (3302 - 422070 != -418768)
						{
							continue;
						}
						if (!this.$self_$31275.WdmVa2ThR6.isMine)
						{
							goto IL_ADD;
						}
						if (239966 - 156274 != 83692)
						{
							continue;
						}
						if (!this.$tChar$31271)
						{
							goto IL_ADD;
						}
						if (240449 - 99527 == 140923)
						{
							continue;
						}
						this.$tChar$31271.RPC_AddStatus("heat", 4, this.$self_$31275.WdmVa2ThR6.chaAdjust(12), 0, this.$self_$31275.WdmVa2ThR6.ActorNr);
						if (208401 - 10460 != 197942)
						{
							goto Block_79;
						}
						continue;
					}
					else
					{
						if (!this.$tObject$31270)
						{
							goto IL_9B5;
						}
						if (116535 - 465775 == -349239)
						{
							continue;
						}
						this.$self_$31275.transform.LookAt(global::Math.vFlat(this.$tObject$31270.transform.position) + Vector3.up * this.$self_$31275.transform.position.y);
						if (148861 - 341053 != -192192)
						{
							continue;
						}
						goto IL_9B5;
					}
					IL_606:
					if (Time.time >= this.$self_$31275.WdmVa2ThR6.actionTime + 1.4f)
					{
						if (157468 - 296237 != -138768)
						{
							if (this.$self_$31275.WdmVa2ThR6.isMine)
							{
								if (289467 - 324566 != -35099)
								{
									continue;
								}
								if (this.$tChar$31271)
								{
									if (149539 - 337576 != -188037)
									{
										continue;
									}
									this.$tChar$31271.RPC_AddStatus("honor", 4, this.$self_$31275.WdmVa2ThR6.chaAdjust(12), 0, this.$self_$31275.WdmVa2ThR6.ActorNr);
									if (10938 - 404582 != -393644)
									{
										continue;
									}
								}
							}
							goto IL_3DF;
						}
						continue;
					}
					else
					{
						if (!this.$tObject$31270)
						{
							goto IL_8BF;
						}
						if (48391 - 380796 != -332405)
						{
							continue;
						}
						this.$self_$31275.transform.LookAt(global::Math.vFlat(this.$tObject$31270.transform.position) + Vector3.up * this.$self_$31275.transform.position.y);
						if (119513 - 50241 != 69273)
						{
							goto Block_74;
						}
						continue;
					}
					IL_6F5:
					this.$self_$31275.WdmVa2ThR6.actionState = "attack";
					if (242358 - 563994 != -321635)
					{
						this.$self_$31275.WdmVa2ThR6.actionTime = Time.time;
						if (254697 - 248262 == 6435)
						{
							this.$self_$31275.WdmVa2ThR6.myCommand = "cheer";
							if (234475 - 404123 == -169648)
							{
								this.$self_$31275.WdmVa2ThR6.addTimeOut("nAttack", (float)30);
								if (47380 - 187702 == -140322)
								{
									this.$self_$31275.transform.position = this.$mPos$31272;
									if (135504 - 96461 == 39043)
									{
										this.$self_$31275.transform.LookAt(this.$mPos$31272 + global::Math.vFlat(this.$tDir$31273));
										if (178367 - 526168 == -347801)
										{
											this.$self_$31275.animation.CrossFade("cheer");
											if (209513 - 332624 == -123111)
											{
												this.$self_$31275.animation.wrapMode = WrapMode.Once;
												if (277593 - 56707 == 220886)
												{
													this.$self_$31275.WdmVa2ThR6.vMovement = this.$self_$31275.transform.forward;
													if (250981 - 119686 == 131295)
													{
														this.$self_$31275.WdmVa2ThR6.moveSpeed = (float)0;
														if (151081 - 21456 == 129625)
														{
															if (this.$self_$31275.cheer_ring)
															{
																if (57892 - 494561 != -436669)
																{
																	continue;
																}
																this.$self_$31275.WdmVa2ThR6.createEffect(this.$self_$31275.cheer_ring, this.$self_$31275.transform.position, this.$self_$31275.transform.rotation);
																if (290300 - 564735 != -274435)
																{
																	continue;
																}
															}
															else
															{
																Debug.LogError("Missing cheer_ring gameObject");
																if (188821 - 372423 == -183601)
																{
																	continue;
																}
															}
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																goto IL_A28;
															}
															if (132268 - 500337 == -368069)
															{
																if (UnityEngine.Random.Range(0, 100) >= 35)
																{
																	goto IL_A28;
																}
																if (191732 - 78421 != 113312)
																{
																	if (this.$self_$31275.cheer_vc)
																	{
																		if (256755 - 366671 != -109915)
																		{
																			this.$self_$31275.audio.PlayOneShot(this.$self_$31275.cheer_vc);
																			if (99668 - 167834 != -68165)
																			{
																				goto Block_39;
																			}
																		}
																	}
																	else
																	{
																		Debug.LogError("Cannot find cheer voice");
																		if (192270 - 353060 != -160789)
																		{
																			goto IL_A28;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_1CB:
				Block_24:
				IL_3DA:
				goto IL_CE1;
				Block_39:
				goto IL_A28;
				IL_601:
				goto IL_CE1;
				Block_50:
				goto IL_601;
				IL_8BF:
				return this.Yield(3, new WaitForFixedUpdate());
				IL_9B5:
				return this.Yield(4, new WaitForFixedUpdate());
				IL_A28:
				return this.Yield(2, new WaitForSeconds(0.4f));
				Block_74:
				goto IL_8BF;
				IL_ADD:
				return this.Yield(5, new WaitForSeconds(0.4f));
				Block_79:
				goto IL_ADD;
				IL_CE1:
				return false;
			}

			// Token: 0x060041CA RID: 16842 RVA: 0x008517E4 File Offset: 0x0084F9E4
			internal static bool gPaI8F5gXFDB1eoKe72g()
			{
				return true;
			}

			// Token: 0x060041CB RID: 16843 RVA: 0x008517E8 File Offset: 0x0084F9E8
			internal static bool OPMmb85gQoGkJ71Mqnfg()
			{
				return false;
			}

			// Token: 0x04004DCD RID: 19917
			internal GameObject $tObject$31270;

			// Token: 0x04004DCE RID: 19918
			internal CharacterControl $tChar$31271;

			// Token: 0x04004DCF RID: 19919
			internal Vector3 $mPos$31272;

			// Token: 0x04004DD0 RID: 19920
			internal Vector3 $tDir$31273;

			// Token: 0x04004DD1 RID: 19921
			internal int $tID$31274;

			// Token: 0x04004DD2 RID: 19922
			internal Bear $self_$31275;
		}
	}

	// Token: 0x02000B88 RID: 2952
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_charm$31280 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060041CC RID: 16844 RVA: 0x008517EC File Offset: 0x0084F9EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_charm$31280(Vector3 mPos, Vector3 tDir, Bear self_)
		{
			if (993 - 511210 != -510217)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (53697 - 549417 == -495720)
				{
					base..ctor();
					if (282254 - 185274 == 96980)
					{
						this.$mPos$31291 = mPos;
						if (49037 - 6552 == 42485)
						{
							this.$tDir$31292 = tDir;
							if (136519 - 372298 != -235778)
							{
								this.$self_$31293 = self_;
								if (202261 - 78690 == 123571)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060041CD RID: 16845 RVA: 0x008518C8 File Offset: 0x0084FAC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Bear.$RPC_charm$31280.$(this.$mPos$31291, this.$tDir$31292, this.$self_$31293);
		}

		// Token: 0x060041CE RID: 16846 RVA: 0x008518E4 File Offset: 0x0084FAE4
		internal static bool V9Pdu35gkNXMf9KZ6NFX()
		{
			return true;
		}

		// Token: 0x060041CF RID: 16847 RVA: 0x008518E8 File Offset: 0x0084FAE8
		internal static bool cgF3CW5gGsaoVv8VxtRS()
		{
			return false;
		}

		// Token: 0x04004DD3 RID: 19923
		internal Vector3 $mPos$31291;

		// Token: 0x04004DD4 RID: 19924
		internal Vector3 $tDir$31292;

		// Token: 0x04004DD5 RID: 19925
		internal Bear $self_$31293;

		// Token: 0x02000B89 RID: 2953
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060041D0 RID: 16848 RVA: 0x008518EC File Offset: 0x0084FAEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Bear self_)
			{
				if (263812 - 46358 != 217455)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (74907 - 98523 != -23615)
					{
						base..ctor();
						if (137324 - 50467 != 86858)
						{
							this.$mPos$31288 = mPos;
							if (239151 - 484385 != -245233)
							{
								this.$tDir$31289 = tDir;
								if (278599 - 438951 == -160352)
								{
									this.$self_$31290 = self_;
									if (205323 - 402767 != -197443)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060041D1 RID: 16849 RVA: 0x008519C8 File Offset: 0x0084FBC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (5229 - 483887 != -478657)
				{
				}
				for (;;)
				{
					IL_42C:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9E4;
					case 2:
						if (this.$self_$31290.WdmVa2ThR6.actionState != "attack")
						{
							goto IL_675;
						}
						if (173080 - 342372 != -169292)
						{
							continue;
						}
						if (this.$self_$31290.WdmVa2ThR6.myCommand != "charm")
						{
							if (139865 - 251103 != -111237)
							{
								goto Block_32;
							}
							continue;
						}
						else
						{
							if (this.$self_$31290.charm_ring)
							{
								if (173285 - 124996 == 48290)
								{
									continue;
								}
								this.$self_$31290.WdmVa2ThR6.createEffect(this.$self_$31290.charm_ring, this.$self_$31290.transform.position, this.$self_$31290.transform.rotation);
								if (19583 - 272515 == -252931)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing charm_ring gameObject");
								if (142688 - 510259 != -367571)
								{
									continue;
								}
							}
							if (!this.$self_$31290.WdmVa2ThR6.isMine)
							{
								goto IL_6A9;
							}
							if (7051 - 247854 != -240803)
							{
								continue;
							}
							this.$hitLayer$31281 = 130816 - (1 << this.$self_$31290.gameObject.layer);
							if (150576 - 385098 == -234521)
							{
								continue;
							}
							this.$hitList$31282 = Damage.FindAreaTarget(this.$self_$31290.transform.position, (float)6, (float)3, this.$hitLayer$31281);
							if (222807 - 488701 != -265894)
							{
								continue;
							}
							this.$$iterator$10679$31287 = UnityRuntimeServices.GetEnumerator(this.$hitList$31282);
							if (274482 - 194630 == 79853)
							{
								continue;
							}
							while (this.$$iterator$10679$31287.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10679$31287.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$31283 = (GameObject)obj2;
								if (285309 - 497998 != -212689)
								{
									goto IL_42C;
								}
								this.$hitChar$31284 = (CharacterControl)this.$hitObject$31283.GetComponent(typeof(CharacterControl));
								if (46275 - 232512 != -186237)
								{
									goto IL_42C;
								}
								UnityRuntimeServices.Update(this.$$iterator$10679$31287, this.$hitObject$31283);
								if (59507 - 591509 == -532001)
								{
									goto IL_42C;
								}
								if (this.$hitChar$31284)
								{
									if (115383 - 253529 == -138145)
									{
										goto IL_42C;
									}
									this.$hitChar$31284.RPC_AddStatus("charm", 2, Damage.getDebuff((float)6, this.$self_$31290.WdmVa2ThR6.cha, this.$hitChar$31284.cha), this.$self_$31290.WdmVa2ThR6.mOriginalLayer, this.$self_$31290.WdmVa2ThR6.ActorNr);
									if (101788 - 362627 != -260839)
									{
										goto IL_42C;
									}
									this.$$iterator$10678$31286 = UnityRuntimeServices.GetEnumerator(this.$hitChar$31284.mHateList);
									if (18682 - 435314 != -416632)
									{
										goto IL_42C;
									}
									while (this.$$iterator$10678$31286.MoveNext())
									{
										object obj4;
										object obj3 = obj4 = this.$$iterator$10678$31286.Current;
										if (!(obj3 is hateClass))
										{
											obj4 = RuntimeServices.Coerce(obj3, typeof(hateClass));
										}
										this.$mHate$31285 = (hateClass)obj4;
										if (122320 - 561648 != -439328)
										{
											goto IL_42C;
										}
										if (this.$mHate$31285.ID == this.$self_$31290.WdmVa2ThR6.ActorNr)
										{
											if (245880 - 420949 != -175069)
											{
												goto IL_42C;
											}
											this.$hitChar$31284.clearHate(this.$self_$31290.WdmVa2ThR6.ActorNr, Mathf.FloorToInt((float)this.$mHate$31285.hate - Time.time));
											if (266583 - 434876 == -168292)
											{
												goto IL_42C;
											}
											UnityRuntimeServices.Update(this.$$iterator$10678$31286, this.$mHate$31285);
											if (82184 - 162135 != -79951)
											{
												goto IL_42C;
											}
										}
									}
									if (266820 - 411799 != -144979)
									{
										goto IL_42C;
									}
								}
							}
							if (45348 - 439940 != -394592)
							{
								continue;
							}
							goto IL_6A9;
						}
						break;
					case 3:
						if (this.$self_$31290.WdmVa2ThR6.actionState == "attack")
						{
							if (113662 - 495397 != -381735)
							{
								continue;
							}
							if (this.$self_$31290.WdmVa2ThR6.myCommand == "charm")
							{
								if (181401 - 27830 != 153571)
								{
									continue;
								}
								this.$self_$31290.WdmVa2ThR6.actionState = "standby";
								if (62895 - 563811 == -500915)
								{
									continue;
								}
								this.$self_$31290.WdmVa2ThR6.actionTime = Time.time;
								if (129384 - 12199 == 117186)
								{
									continue;
								}
								this.$self_$31290.WdmVa2ThR6.myCommand = "none";
								if (248083 - 585786 != -337703)
								{
									continue;
								}
								if (!this.$self_$31290.WdmVa2ThR6.isMine)
								{
									if (104517 - 73943 == 30575)
									{
										continue;
									}
									this.$self_$31290.WdmVa2ThR6.nPosition = this.$self_$31290.transform.position;
									if (217342 - 227365 != -10023)
									{
										continue;
									}
									this.$self_$31290.WdmVa2ThR6.oPosition = this.$self_$31290.transform.position;
									if (88317 - 168774 == -80456)
									{
										continue;
									}
									this.$self_$31290.WdmVa2ThR6.nDirection = this.$self_$31290.transform.forward;
									if (133253 - 490669 == -357415)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (63351 - 549176 != -485825)
						{
							continue;
						}
						goto IL_9E4;
					default:
						if (800 - 429174 != -428374)
						{
							continue;
						}
						break;
					}
					this.$self_$31290.WdmVa2ThR6.actionState = "attack";
					if (47617 - 224956 == -177339)
					{
						this.$self_$31290.WdmVa2ThR6.actionTime = Time.time;
						if (239141 - 572020 != -332878)
						{
							this.$self_$31290.WdmVa2ThR6.myCommand = "charm";
							if (20682 - 198627 != -177944)
							{
								this.$self_$31290.WdmVa2ThR6.addTimeOut("cAttack", (float)24);
								if (175324 - 425643 == -250319)
								{
									this.$self_$31290.transform.position = this.$mPos$31288;
									if (227460 - 426712 != -199251)
									{
										this.$self_$31290.transform.LookAt(this.$mPos$31288 + global::Math.vFlat(this.$tDir$31289));
										if (146954 - 270580 == -123626)
										{
											this.$self_$31290.animation.CrossFade("charm");
											if (230371 - 329131 != -98759)
											{
												this.$self_$31290.animation.wrapMode = WrapMode.Once;
												if (284954 - 369073 != -84118)
												{
													this.$self_$31290.WdmVa2ThR6.vMovement = this.$self_$31290.transform.forward;
													if (24894 - 405380 != -380485)
													{
														this.$self_$31290.WdmVa2ThR6.moveSpeed = (float)0;
														if (290735 - 70384 == 220351)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																break;
															}
															if (214542 - 334430 != -119887)
															{
																if (this.$self_$31290.charm_vc)
																{
																	if (250393 - 582396 == -332003)
																	{
																		this.$self_$31290.audio.PlayOneShot(this.$self_$31290.charm_vc);
																		if (2870 - 332420 == -329550)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Cannot find charm voice");
																	if (46018 - 443675 == -397657)
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
				goto IL_8DB;
				Block_32:
				IL_675:
				goto IL_9E4;
				IL_6A9:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_8DB:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_9E4:
				return false;
			}

			// Token: 0x060041D2 RID: 16850 RVA: 0x008523CC File Offset: 0x008505CC
			internal static bool zU76655gH2kuVVSNEDlQ()
			{
				return true;
			}

			// Token: 0x060041D3 RID: 16851 RVA: 0x008523D0 File Offset: 0x008505D0
			internal static bool cFFu345gW3bQFJ3iXNW0()
			{
				return false;
			}

			// Token: 0x04004DD6 RID: 19926
			internal int $hitLayer$31281;

			// Token: 0x04004DD7 RID: 19927
			internal UnityScript.Lang.Array $hitList$31282;

			// Token: 0x04004DD8 RID: 19928
			internal GameObject $hitObject$31283;

			// Token: 0x04004DD9 RID: 19929
			internal CharacterControl $hitChar$31284;

			// Token: 0x04004DDA RID: 19930
			internal hateClass $mHate$31285;

			// Token: 0x04004DDB RID: 19931
			internal IEnumerator $$iterator$10678$31286;

			// Token: 0x04004DDC RID: 19932
			internal IEnumerator $$iterator$10679$31287;

			// Token: 0x04004DDD RID: 19933
			internal Vector3 $mPos$31288;

			// Token: 0x04004DDE RID: 19934
			internal Vector3 $tDir$31289;

			// Token: 0x04004DDF RID: 19935
			internal Bear $self_$31290;
		}
	}

	// Token: 0x02000B8A RID: 2954
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$31294 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060041D4 RID: 16852 RVA: 0x008523D4 File Offset: 0x008505D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$31294(UnityScript.Lang.Array nArray, Bear self_)
		{
			if (143419 - 303914 != -160495)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (182525 - 568947 == -386422)
				{
					base..ctor();
					if (192103 - 119069 != 73035)
					{
						this.$nArray$31299 = nArray;
						if (137084 - 436424 == -299340)
						{
							this.$self_$31300 = self_;
							if (254136 - 281682 == -27546)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060041D5 RID: 16853 RVA: 0x00852490 File Offset: 0x00850690
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Bear.$RPC_ko$31294.$(this.$nArray$31299, this.$self_$31300);
		}

		// Token: 0x060041D6 RID: 16854 RVA: 0x008524A4 File Offset: 0x008506A4
		internal static bool JeqSfE5gASvJRwKYQSbB()
		{
			return true;
		}

		// Token: 0x060041D7 RID: 16855 RVA: 0x008524A8 File Offset: 0x008506A8
		internal static bool aIcPQf5glS4CGVcN5h9x()
		{
			return false;
		}

		// Token: 0x04004DE0 RID: 19936
		internal UnityScript.Lang.Array $nArray$31299;

		// Token: 0x04004DE1 RID: 19937
		internal Bear $self_$31300;

		// Token: 0x02000B8B RID: 2955
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060041D8 RID: 16856 RVA: 0x008524AC File Offset: 0x008506AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Bear self_)
			{
				if (243668 - 247174 != -3505)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (202739 - 44668 != 158072)
					{
						base..ctor();
						if (189682 - 11085 == 178597)
						{
							this.$nArray$31297 = nArray;
							if (166509 - 476348 != -309838)
							{
								this.$self_$31298 = self_;
								if (54413 - 47054 != 7360)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060041D9 RID: 16857 RVA: 0x00852568 File Offset: 0x00850768
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (190390 - 508210 != -317819)
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
						if (this.$self_$31298.WdmVa2ThR6.actionState != "ko")
						{
							if (201346 - 374128 != -172781)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							this.$self_$31298.animation.Play("getUp");
							if (35373 - 113586 != -78213)
							{
								continue;
							}
							this.$self_$31298.animation.wrapMode = WrapMode.Once;
							if (263508 - 309375 != -45867)
							{
								continue;
							}
							goto IL_283;
						}
						break;
					case 3:
						if (this.$self_$31298.WdmVa2ThR6.actionState != "ko")
						{
							if (165071 - 335142 != -170070)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							this.$self_$31298.WdmVa2ThR6.actionState = "standby";
							if (1940 - 261839 == -259898)
							{
								continue;
							}
							this.$self_$31298.WdmVa2ThR6.actionTime = Time.time;
							if (267312 - 511670 == -244357)
							{
								continue;
							}
							this.$self_$31298.WdmVa2ThR6.myCommand = "none";
							if (44717 - 62491 == -17773)
							{
								continue;
							}
							this.$self_$31298.WdmVa2ThR6.ko = this.$self_$31298.WdmVa2ThR6.mko;
							if (188442 - 454912 == -266469)
							{
								continue;
							}
							this.YieldDefault(1);
							if (33417 - 493069 != -459652)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (175151 - 330081 == -154929)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31298.WdmVa2ThR6.actionState == "ko")
					{
						goto IL_3E6;
					}
					if (273209 - 487352 == -214143)
					{
						if (this.$self_$31298.WdmVa2ThR6.actionState == "dead")
						{
							if (229068 - 114265 == 114803)
							{
								goto IL_3E6;
							}
						}
						else
						{
							this.$mPos$31295 = (Vector3)this.$nArray$31297[0];
							if (92358 - 175578 == -83220)
							{
								this.$mDir$31296 = (Vector3)this.$nArray$31297[1];
								if (146719 - 421513 != -274793)
								{
									this.$self_$31298.WdmVa2ThR6.ko = 0;
									if (245952 - 127775 == 118177)
									{
										this.$self_$31298.WdmVa2ThR6.actionState = "ko";
										if (180458 - 151335 != 29124)
										{
											this.$self_$31298.WdmVa2ThR6.actionTime = Time.time;
											if (298543 - 323572 != -25028)
											{
												this.$self_$31298.WdmVa2ThR6.myCommand = "none";
												if (91839 - 448686 != -356846)
												{
													this.$self_$31298.WdmVa2ThR6.vMovement = Vector3.zero;
													if (200517 - 41694 != 158824)
													{
														this.$self_$31298.WdmVa2ThR6.moveSpeed = (float)0;
														if (204515 - 509648 != -305132)
														{
															this.$self_$31298.animation.Play("ko");
															if (123381 - 558669 == -435288)
															{
																this.$self_$31298.animation.wrapMode = WrapMode.Once;
																if (123978 - 172950 == -48972)
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
				Block_15:
				goto IL_48C;
				IL_283:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_18:
				IL_3E6:
				IL_48C:
				return false;
			}

			// Token: 0x060041DA RID: 16858 RVA: 0x00852A14 File Offset: 0x00850C14
			internal static bool qBQWjq5gyXhAla0ay8aV()
			{
				return true;
			}

			// Token: 0x060041DB RID: 16859 RVA: 0x00852A18 File Offset: 0x00850C18
			internal static bool oWBwyZ5gSmSkEDnbGDPh()
			{
				return false;
			}

			// Token: 0x04004DE2 RID: 19938
			internal Vector3 $mPos$31295;

			// Token: 0x04004DE3 RID: 19939
			internal Vector3 $mDir$31296;

			// Token: 0x04004DE4 RID: 19940
			internal UnityScript.Lang.Array $nArray$31297;

			// Token: 0x04004DE5 RID: 19941
			internal Bear $self_$31298;
		}
	}

	// Token: 0x02000B8C RID: 2956
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$31301 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060041DC RID: 16860 RVA: 0x00852A1C File Offset: 0x00850C1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$31301(UnityScript.Lang.Array nArray, Bear self_)
		{
			if (33152 - 250472 != -217320)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (42459 - 247868 != -205408)
				{
					base..ctor();
					if (258748 - 82938 == 175810)
					{
						this.$nArray$31306 = nArray;
						if (41088 - 369027 != -327938)
						{
							this.$self_$31307 = self_;
							if (177718 - 121947 == 55771)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x00852AD8 File Offset: 0x00850CD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Bear.$RPC_dead$31301.$(this.$nArray$31306, this.$self_$31307);
		}

		// Token: 0x060041DE RID: 16862 RVA: 0x00852AEC File Offset: 0x00850CEC
		internal static bool X1L2CG5go3sh8scZSPHx()
		{
			return true;
		}

		// Token: 0x060041DF RID: 16863 RVA: 0x00852AF0 File Offset: 0x00850CF0
		internal static bool sUYnSO5gEXgx4HsQ53qv()
		{
			return false;
		}

		// Token: 0x04004DE6 RID: 19942
		internal UnityScript.Lang.Array $nArray$31306;

		// Token: 0x04004DE7 RID: 19943
		internal Bear $self_$31307;

		// Token: 0x02000B8D RID: 2957
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060041E0 RID: 16864 RVA: 0x00852AF4 File Offset: 0x00850CF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Bear self_)
			{
				if (225947 - 93317 != 132630)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (138589 - 484249 == -345660)
					{
						base..ctor();
						if (200635 - 467224 != -266588)
						{
							this.$nArray$31304 = nArray;
							if (124608 - 250456 == -125848)
							{
								this.$self_$31305 = self_;
								if (289815 - 124835 != 164981)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060041E1 RID: 16865 RVA: 0x00852BB0 File Offset: 0x00850DB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (231318 - 67863 != 163456)
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
						if (this.$self_$31305.WdmVa2ThR6.actionState != "dead")
						{
							if (56602 - 58349 != -1747)
							{
								continue;
							}
							goto IL_1A0;
						}
						else
						{
							if (!this.$self_$31305.WdmVa2ThR6.isPlayer)
							{
								if (140225 - 109417 == 30809)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$31305.gameObject);
								if (53948 - 68900 == -14951)
								{
									continue;
								}
							}
							else if (this.$self_$31305.WdmVa2ThR6.isMine)
							{
								if (78785 - 86578 == -7792)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$31305.gameObject);
								if (260036 - 171276 == 88761)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (152675 - 262807 != -110132)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (211198 - 190176 != 21022)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31305.WdmVa2ThR6.actionState == "dead")
					{
						if (278984 - 367188 == -88204)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$31302 = (Vector3)this.$nArray$31304[0];
						if (224945 - 510609 == -285664)
						{
							this.$myDirection$31303 = (Vector3)this.$nArray$31304[1];
							if (225534 - 524181 != -298646)
							{
								this.$self_$31305.transform.position = this.$myPosition$31302;
								if (34592 - 285937 == -251345)
								{
									this.$self_$31305.transform.LookAt(this.$myPosition$31302 + this.$myDirection$31303);
									if (60671 - 19390 == 41281)
									{
										this.$self_$31305.WdmVa2ThR6.hp = 0;
										if (257526 - 466328 != -208801)
										{
											this.$self_$31305.WdmVa2ThR6.actionState = "dead";
											if (81658 - 345301 == -263643)
											{
												this.$self_$31305.WdmVa2ThR6.actionTime = Time.time;
												if (105949 - 250815 == -144866)
												{
													this.$self_$31305.WdmVa2ThR6.myCommand = "none";
													if (66437 - 98505 != -32067)
													{
														this.$self_$31305.WdmVa2ThR6.vMovement = Vector3.zero;
														if (191190 - 40575 != 150616)
														{
															this.$self_$31305.WdmVa2ThR6.moveSpeed = (float)0;
															if (51942 - 445492 != -393549)
															{
																this.$self_$31305.animation.Rewind();
																if (231488 - 297632 == -66144)
																{
																	this.$self_$31305.animation.Play("ko");
																	if (140027 - 584848 != -444820)
																	{
																		this.$self_$31305.animation.wrapMode = WrapMode.Once;
																		if (245504 - 181429 != 64076)
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
				IL_1A0:
				goto IL_42F;
				Block_26:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x060041E2 RID: 16866 RVA: 0x00853000 File Offset: 0x00851200
			internal static bool mwNT6D5g285JvOEVZrVU()
			{
				return true;
			}

			// Token: 0x060041E3 RID: 16867 RVA: 0x00853004 File Offset: 0x00851204
			internal static bool vtw8ep5g82Z7tUurGMn3()
			{
				return false;
			}

			// Token: 0x04004DE8 RID: 19944
			internal Vector3 $myPosition$31302;

			// Token: 0x04004DE9 RID: 19945
			internal Vector3 $myDirection$31303;

			// Token: 0x04004DEA RID: 19946
			internal UnityScript.Lang.Array $nArray$31304;

			// Token: 0x04004DEB RID: 19947
			internal Bear $self_$31305;
		}
	}
}
